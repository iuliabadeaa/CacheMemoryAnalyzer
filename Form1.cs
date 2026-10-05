using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proiectMemCache
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private OpenFileDialog ofd;

		private static string ReadBenchmarkFile(string filePath)
		{
			try
			{
				return File.ReadAllText(filePath);
			}
			catch
			{
				return null;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ofd = new OpenFileDialog();

			sizeIC.Items.Add(4);
			sizeIC.Items.Add(8);
			sizeIC.Items.Add(64);
			sizeIC.Items.Add(128);
			sizeIC.Items.Add(256);
			sizeIC.Items.Add(512);
			sizeIC.SelectedItem = 128;

			issueRateMaxim.Items.Add(1);
			issueRateMaxim.Items.Add(2);
			issueRateMaxim.Items.Add(4);
			issueRateMaxim.Items.Add(8);
			issueRateMaxim.Items.Add(16);
			issueRateMaxim.SelectedItem = 4;

			fetchRate.Items.Add(1);
			fetchRate.Items.Add(2);
			fetchRate.Items.Add(4);
			fetchRate.Items.Add(8);
			fetchRate.Items.Add(16);
			fetchRate.SelectedItem = 4;

			instructionBufferSize.Items.Add(1);
			instructionBufferSize.Items.Add(2);
			instructionBufferSize.Items.Add(4);
			instructionBufferSize.Items.Add(8);
			instructionBufferSize.Items.Add(16);
			instructionBufferSize.SelectedItem = 2;

			missInCache.Items.Add(1);
			missInCache.Items.Add(2);
			missInCache.Items.Add(3);
			missInCache.Items.Add(4);
			missInCache.Items.Add(5);
			missInCache.SelectedItem = 3;

		}

		private void alegeFisier_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
				caleFisier.Text = ofd.FileName;
		}

		private List<string> SplitBenchmarks(string benchmarkData)
		{
			List<string> result = new List<string>();
			if (string.IsNullOrEmpty(benchmarkData))
				return result;

			var pattern = new Regex(@"([BSL])\s+(\d+)\s+(\d+)");
			foreach (Match match in pattern.Matches(benchmarkData))
				result.Add($"{match.Groups[1].Value} {match.Groups[2].Value} {match.Groups[3].Value}");

			return result;
		}

		int LoadInstruction = 0;
		int StoreInstruction = 0;
		int BranchInstruction = 0;
		int Arithinstruction = 0;
		int hitCount = 0;
		int missCount = 0;
		int nrCicli = 0;

		private void startSimulare_Click(object sender, EventArgs e)
		{

			int AcceseDisponibileLaMemorie = uniportRadioButton.Checked ? 1 : 2;
			int accesariInCicluCurent = 0;

			string benchmarkData = ReadBenchmarkFile(caleFisier.Text);
			List<string> benchmarkSplit = SplitBenchmarks(benchmarkData);

			List<Instructiune> instructiuni = new List<Instructiune>();
			foreach (string benchmark in benchmarkSplit)
			{
				string[] parts = benchmark.Split(' ');
				instructiuni.Add(new Instructiune
				{
					TipInstructiune = parts[0][0],
					PCcurent = int.Parse(parts[1]),
					Target = int.Parse(parts[2])
				});
			}

			int cacheSize = (int)sizeIC.SelectedItem;
			int blockSize = Convert.ToInt32(fetchRate.SelectedItem);
			int issueRate = Convert.ToInt32(issueRateMaxim.SelectedItem);

			Queue<int> MemorieCache = new Queue<int>(cacheSize);

			int PCnormal = 0;

			foreach (Instructiune instr in instructiuni)
			{
				while (PCnormal != instr.PCcurent)
				{
					Arithinstruction++;
					nrCicli++;
					PCnormal++;
				}

				if (instr.TipInstructiune == 'L') LoadInstruction++;
				else if (instr.TipInstructiune == 'S') StoreInstruction++;
				else if (instr.TipInstructiune == 'B') BranchInstruction++;

				if (instr.TipInstructiune == 'L' ||
					instr.TipInstructiune == 'S' ||
					instr.TipInstructiune == 'B')
				{
					if (accesariInCicluCurent >= AcceseDisponibileLaMemorie)
					{
						nrCicli++;
						accesariInCicluCurent = 0;
					}
					accesariInCicluCurent++;

					int blockAddress = instr.PCcurent / blockSize;
					bool found = false;

					foreach (int cachedBlock in MemorieCache)
					{
						if (cachedBlock == blockAddress)
						{
							hitCount++;
							found = true;
							break;
						}
					}

					if (!found)
					{
						missCount++;
						nrCicli += Convert.ToInt32(missInCache.SelectedItem);

						if (MemorieCache.Count >= cacheSize)
							MemorieCache.Dequeue();

						MemorieCache.Enqueue(blockAddress);
					}

					if (instr.TipInstructiune == 'B')
					{
						MemorieCache.Clear();
						PCnormal = instr.Target;
						accesariInCicluCurent = 0;
					}
					else
					{
						PCnormal++;
					}

					nrCicli++;
				}
			}

			nrCicli = nrCicli / issueRate;

			loadBox.Text = LoadInstruction.ToString();
			storeBox.Text = StoreInstruction.ToString();
			branchBox.Text = BranchInstruction.ToString();
			arithBox.Text = Arithinstruction.ToString();

			int totalInstr = LoadInstruction + StoreInstruction + BranchInstruction + Arithinstruction;
			totalBox.Text = totalInstr.ToString();

			oneCycleBox.Text = nrCicli.ToString();
			ticksBox.Text = (nrCicli * (int)latentaBox.Value).ToString();

			double hitRate = (double)hitCount / (hitCount + missCount) * 100;
			double missRate = (double)missCount / (hitCount + missCount) * 100;
			Console.WriteLine("Hit Rate: " + hitRate + "%");
			Console.WriteLine("Miss Rate: " + missRate + "%");

			double issueRateReal = (double)totalInstr / nrCicli;
			issueRateBox.Text = issueRateReal.ToString("F2");
		}
	}
}
