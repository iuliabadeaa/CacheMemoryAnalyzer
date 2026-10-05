namespace proiectMemCache
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.fetchRate = new System.Windows.Forms.ComboBox();
			this.issueRateMaxim = new System.Windows.Forms.ComboBox();
			this.instructionBufferSize = new System.Windows.Forms.ComboBox();
			this.latentaBox = new System.Windows.Forms.NumericUpDown();
			this.missInCache = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.sizeIC = new System.Windows.Forms.ComboBox();
			this.uniportRadioButton = new System.Windows.Forms.RadioButton();
			this.biportRadioButton = new System.Windows.Forms.RadioButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.alegeFisier = new System.Windows.Forms.Button();
			this.startSimulare = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.loadBox = new System.Windows.Forms.TextBox();
			this.storeBox = new System.Windows.Forms.TextBox();
			this.branchBox = new System.Windows.Forms.TextBox();
			this.totalBox = new System.Windows.Forms.TextBox();
			this.oneCycleBox = new System.Windows.Forms.TextBox();
			this.issueRateBox = new System.Windows.Forms.TextBox();
			this.ticksBox = new System.Windows.Forms.TextBox();
			this.caleFisier = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.arithBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.latentaBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fetch Rate (FR)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Parametri Simulator";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Issue Rate Maxim (IRmax)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Instruction Buffer Size(IBS)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Latenta";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "N_PEN";
			// 
			// fetchRate
			// 
			this.fetchRate.FormattingEnabled = true;
			this.fetchRate.Location = new System.Drawing.Point(132, 34);
			this.fetchRate.MaxDropDownItems = 20;
			this.fetchRate.Name = "fetchRate";
			this.fetchRate.Size = new System.Drawing.Size(54, 24);
			this.fetchRate.TabIndex = 7;
			// 
			// issueRateMaxim
			// 
			this.issueRateMaxim.FormattingEnabled = true;
			this.issueRateMaxim.Location = new System.Drawing.Point(201, 63);
			this.issueRateMaxim.MaxDropDownItems = 20;
			this.issueRateMaxim.Name = "issueRateMaxim";
			this.issueRateMaxim.Size = new System.Drawing.Size(54, 24);
			this.issueRateMaxim.TabIndex = 8;
			// 
			// instructionBufferSize
			// 
			this.instructionBufferSize.FormattingEnabled = true;
			this.instructionBufferSize.Location = new System.Drawing.Point(201, 93);
			this.instructionBufferSize.MaxDropDownItems = 20;
			this.instructionBufferSize.Name = "instructionBufferSize";
			this.instructionBufferSize.Size = new System.Drawing.Size(54, 24);
			this.instructionBufferSize.TabIndex = 9;
			// 
			// latentaBox
			// 
			this.latentaBox.Location = new System.Drawing.Point(77, 122);
			this.latentaBox.Name = "latentaBox";
			this.latentaBox.Size = new System.Drawing.Size(48, 22);
			this.latentaBox.TabIndex = 10;
			// 
			// missInCache
			// 
			this.missInCache.FormattingEnabled = true;
			this.missInCache.Location = new System.Drawing.Point(77, 150);
			this.missInCache.MaxDropDownItems = 20;
			this.missInCache.Name = "missInCache";
			this.missInCache.Size = new System.Drawing.Size(54, 24);
			this.missInCache.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(328, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(233, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "Parametri Cache (Complet asociativa)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(341, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "Instruction Cache";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(310, 71);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 16);
			this.label12.TabIndex = 17;
			this.label12.Text = "Size IC";
			// 
			// sizeIC
			// 
			this.sizeIC.FormattingEnabled = true;
			this.sizeIC.Location = new System.Drawing.Point(364, 66);
			this.sizeIC.MaxDropDownItems = 20;
			this.sizeIC.Name = "sizeIC";
			this.sizeIC.Size = new System.Drawing.Size(54, 24);
			this.sizeIC.TabIndex = 21;
			// 
			// uniportRadioButton
			// 
			this.uniportRadioButton.AutoSize = true;
			this.uniportRadioButton.Location = new System.Drawing.Point(313, 164);
			this.uniportRadioButton.Name = "uniportRadioButton";
			this.uniportRadioButton.Size = new System.Drawing.Size(71, 20);
			this.uniportRadioButton.TabIndex = 25;
			this.uniportRadioButton.TabStop = true;
			this.uniportRadioButton.Text = "Uniport";
			this.uniportRadioButton.UseVisualStyleBackColor = true;
			// 
			// biportRadioButton
			// 
			this.biportRadioButton.AutoSize = true;
			this.biportRadioButton.Location = new System.Drawing.Point(313, 190);
			this.biportRadioButton.Name = "biportRadioButton";
			this.biportRadioButton.Size = new System.Drawing.Size(63, 20);
			this.biportRadioButton.TabIndex = 26;
			this.biportRadioButton.TabStop = true;
			this.biportRadioButton.Text = "Biport";
			this.biportRadioButton.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// alegeFisier
			// 
			this.alegeFisier.Location = new System.Drawing.Point(15, 256);
			this.alegeFisier.Name = "alegeFisier";
			this.alegeFisier.Size = new System.Drawing.Size(138, 35);
			this.alegeFisier.TabIndex = 27;
			this.alegeFisier.Text = "Alege fisier";
			this.alegeFisier.UseVisualStyleBackColor = true;
			this.alegeFisier.Click += new System.EventHandler(this.alegeFisier_Click);
			// 
			// startSimulare
			// 
			this.startSimulare.Location = new System.Drawing.Point(15, 335);
			this.startSimulare.Name = "startSimulare";
			this.startSimulare.Size = new System.Drawing.Size(138, 59);
			this.startSimulare.TabIndex = 28;
			this.startSimulare.Text = "START SIMULARE";
			this.startSimulare.UseVisualStyleBackColor = true;
			this.startSimulare.Click += new System.EventHandler(this.startSimulare_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(37, 419);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(88, 35);
			this.exitButton.TabIndex = 29;
			this.exitButton.Text = "EXIT";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(259, 244);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 16);
			this.label16.TabIndex = 30;
			this.label16.Text = "Instructiuni";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(500, 256);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(63, 16);
			this.label17.TabIndex = 31;
			this.label17.Text = "Rezultate";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(218, 281);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 16);
			this.label18.TabIndex = 32;
			this.label18.Text = "Load";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(219, 319);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(39, 16);
			this.label19.TabIndex = 33;
			this.label19.Text = "Store";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(218, 356);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(49, 16);
			this.label20.TabIndex = 34;
			this.label20.Text = "Branch";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(219, 419);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 16);
			this.label21.TabIndex = 35;
			this.label21.Text = "Total";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(444, 298);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(70, 16);
			this.label22.TabIndex = 36;
			this.label22.Text = "One-Cycle";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(444, 335);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(71, 16);
			this.label23.TabIndex = 37;
			this.label23.Text = "Issue Rate";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(444, 378);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(40, 16);
			this.label24.TabIndex = 38;
			this.label24.Text = "Ticks";
			// 
			// loadBox
			// 
			this.loadBox.Location = new System.Drawing.Point(276, 275);
			this.loadBox.Name = "loadBox";
			this.loadBox.Size = new System.Drawing.Size(82, 22);
			this.loadBox.TabIndex = 39;
			// 
			// storeBox
			// 
			this.storeBox.Location = new System.Drawing.Point(276, 313);
			this.storeBox.Name = "storeBox";
			this.storeBox.Size = new System.Drawing.Size(82, 22);
			this.storeBox.TabIndex = 40;
			// 
			// branchBox
			// 
			this.branchBox.Location = new System.Drawing.Point(276, 353);
			this.branchBox.Name = "branchBox";
			this.branchBox.Size = new System.Drawing.Size(82, 22);
			this.branchBox.TabIndex = 41;
			// 
			// totalBox
			// 
			this.totalBox.Location = new System.Drawing.Point(276, 413);
			this.totalBox.Name = "totalBox";
			this.totalBox.Size = new System.Drawing.Size(82, 22);
			this.totalBox.TabIndex = 42;
			// 
			// oneCycleBox
			// 
			this.oneCycleBox.Location = new System.Drawing.Point(529, 292);
			this.oneCycleBox.Name = "oneCycleBox";
			this.oneCycleBox.Size = new System.Drawing.Size(82, 22);
			this.oneCycleBox.TabIndex = 43;
			// 
			// issueRateBox
			// 
			this.issueRateBox.Location = new System.Drawing.Point(529, 332);
			this.issueRateBox.Name = "issueRateBox";
			this.issueRateBox.Size = new System.Drawing.Size(82, 22);
			this.issueRateBox.TabIndex = 44;
			// 
			// ticksBox
			// 
			this.ticksBox.Location = new System.Drawing.Point(503, 372);
			this.ticksBox.Name = "ticksBox";
			this.ticksBox.Size = new System.Drawing.Size(82, 22);
			this.ticksBox.TabIndex = 45;
			// 
			// caleFisier
			// 
			this.caleFisier.Location = new System.Drawing.Point(15, 298);
			this.caleFisier.Name = "caleFisier";
			this.caleFisier.Size = new System.Drawing.Size(138, 22);
			this.caleFisier.TabIndex = 46;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(219, 390);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 16);
			this.label10.TabIndex = 47;
			this.label10.Text = "Arith";
			// 
			// arithBox
			// 
			this.arithBox.Location = new System.Drawing.Point(276, 381);
			this.arithBox.Name = "arithBox";
			this.arithBox.Size = new System.Drawing.Size(82, 22);
			this.arithBox.TabIndex = 48;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 506);
			this.Controls.Add(this.arithBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.caleFisier);
			this.Controls.Add(this.ticksBox);
			this.Controls.Add(this.issueRateBox);
			this.Controls.Add(this.oneCycleBox);
			this.Controls.Add(this.totalBox);
			this.Controls.Add(this.branchBox);
			this.Controls.Add(this.storeBox);
			this.Controls.Add(this.loadBox);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.startSimulare);
			this.Controls.Add(this.alegeFisier);
			this.Controls.Add(this.biportRadioButton);
			this.Controls.Add(this.uniportRadioButton);
			this.Controls.Add(this.sizeIC);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.missInCache);
			this.Controls.Add(this.latentaBox);
			this.Controls.Add(this.instructionBufferSize);
			this.Controls.Add(this.issueRateMaxim);
			this.Controls.Add(this.fetchRate);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.latentaBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox fetchRate;
		private System.Windows.Forms.ComboBox issueRateMaxim;
		private System.Windows.Forms.ComboBox instructionBufferSize;
		private System.Windows.Forms.NumericUpDown latentaBox;
		private System.Windows.Forms.ComboBox missInCache;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox sizeIC;
		private System.Windows.Forms.RadioButton uniportRadioButton;
		private System.Windows.Forms.RadioButton biportRadioButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button alegeFisier;
		private System.Windows.Forms.Button startSimulare;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox loadBox;
		private System.Windows.Forms.TextBox storeBox;
		private System.Windows.Forms.TextBox branchBox;
		private System.Windows.Forms.TextBox totalBox;
		private System.Windows.Forms.TextBox oneCycleBox;
		private System.Windows.Forms.TextBox issueRateBox;
		private System.Windows.Forms.TextBox ticksBox;
		private System.Windows.Forms.TextBox caleFisier;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox arithBox;
	}
}

