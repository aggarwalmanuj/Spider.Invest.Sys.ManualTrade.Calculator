namespace Spider.Invest.Sys.ManualTrade.Calculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabZb = new System.Windows.Forms.TabPage();
            this.txtZbStopDecimals = new System.Windows.Forms.TextBox();
            this.txtZbStopDegrees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZbTargetDecimals = new System.Windows.Forms.TextBox();
            this.txtZbTargetDegrees = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numZbStopLossSize = new System.Windows.Forms.NumericUpDown();
            this.numZbProfitTargetSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numZbPriceDegrees = new System.Windows.Forms.NumericUpDown();
            this.numZbPriceMain = new System.Windows.Forms.NumericUpDown();
            this.lblZbPriceNormalized = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEs = new System.Windows.Forms.TabPage();
            this.radZbShort = new System.Windows.Forms.RadioButton();
            this.radZbLong = new System.Windows.Forms.RadioButton();
            this.radEsShort = new System.Windows.Forms.RadioButton();
            this.radEsLong = new System.Windows.Forms.RadioButton();
            this.txtEsStopLossPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEsTargetPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numEsStopLossSize = new System.Windows.Forms.NumericUpDown();
            this.numEsProfitTargetSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numEsPriceDecimals = new System.Windows.Forms.NumericUpDown();
            this.numEsPriceMain = new System.Windows.Forms.NumericUpDown();
            this.lblEsPriceNormalized = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabZb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZbStopLossSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbProfitTargetSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbPriceDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbPriceMain)).BeginInit();
            this.tabEs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEsStopLossSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsProfitTargetSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsPriceDecimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsPriceMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabZb);
            this.tabMain.Controls.Add(this.tabEs);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabMain.Location = new System.Drawing.Point(0, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(360, 252);
            this.tabMain.TabIndex = 0;
            // 
            // tabZb
            // 
            this.tabZb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabZb.Controls.Add(this.radZbShort);
            this.tabZb.Controls.Add(this.radZbLong);
            this.tabZb.Controls.Add(this.txtZbStopDecimals);
            this.tabZb.Controls.Add(this.txtZbStopDegrees);
            this.tabZb.Controls.Add(this.label1);
            this.tabZb.Controls.Add(this.txtZbTargetDecimals);
            this.tabZb.Controls.Add(this.txtZbTargetDegrees);
            this.tabZb.Controls.Add(this.label6);
            this.tabZb.Controls.Add(this.label4);
            this.tabZb.Controls.Add(this.numZbStopLossSize);
            this.tabZb.Controls.Add(this.numZbProfitTargetSize);
            this.tabZb.Controls.Add(this.label3);
            this.tabZb.Controls.Add(this.numZbPriceDegrees);
            this.tabZb.Controls.Add(this.numZbPriceMain);
            this.tabZb.Controls.Add(this.lblZbPriceNormalized);
            this.tabZb.Controls.Add(this.label2);
            this.tabZb.Location = new System.Drawing.Point(4, 22);
            this.tabZb.Name = "tabZb";
            this.tabZb.Padding = new System.Windows.Forms.Padding(3);
            this.tabZb.Size = new System.Drawing.Size(352, 226);
            this.tabZb.TabIndex = 0;
            this.tabZb.Text = "ZB";
            // 
            // txtZbStopDecimals
            // 
            this.txtZbStopDecimals.Location = new System.Drawing.Point(215, 190);
            this.txtZbStopDecimals.Name = "txtZbStopDecimals";
            this.txtZbStopDecimals.ReadOnly = true;
            this.txtZbStopDecimals.Size = new System.Drawing.Size(120, 20);
            this.txtZbStopDecimals.TabIndex = 15;
            // 
            // txtZbStopDegrees
            // 
            this.txtZbStopDegrees.Location = new System.Drawing.Point(89, 190);
            this.txtZbStopDegrees.Name = "txtZbStopDegrees";
            this.txtZbStopDegrees.ReadOnly = true;
            this.txtZbStopDegrees.Size = new System.Drawing.Size(120, 20);
            this.txtZbStopDegrees.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Stop:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZbTargetDecimals
            // 
            this.txtZbTargetDecimals.Location = new System.Drawing.Point(215, 166);
            this.txtZbTargetDecimals.Name = "txtZbTargetDecimals";
            this.txtZbTargetDecimals.ReadOnly = true;
            this.txtZbTargetDecimals.Size = new System.Drawing.Size(120, 20);
            this.txtZbTargetDecimals.TabIndex = 12;
            // 
            // txtZbTargetDegrees
            // 
            this.txtZbTargetDegrees.Location = new System.Drawing.Point(89, 166);
            this.txtZbTargetDegrees.Name = "txtZbTargetDegrees";
            this.txtZbTargetDegrees.ReadOnly = true;
            this.txtZbTargetDegrees.Size = new System.Drawing.Size(120, 20);
            this.txtZbTargetDegrees.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Target:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numZbStopLossSize
            // 
            this.numZbStopLossSize.Location = new System.Drawing.Point(89, 132);
            this.numZbStopLossSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numZbStopLossSize.Name = "numZbStopLossSize";
            this.numZbStopLossSize.Size = new System.Drawing.Size(120, 20);
            this.numZbStopLossSize.TabIndex = 9;
            this.numZbStopLossSize.ValueChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // numZbProfitTargetSize
            // 
            this.numZbProfitTargetSize.Location = new System.Drawing.Point(89, 106);
            this.numZbProfitTargetSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numZbProfitTargetSize.Name = "numZbProfitTargetSize";
            this.numZbProfitTargetSize.Size = new System.Drawing.Size(120, 20);
            this.numZbProfitTargetSize.TabIndex = 7;
            this.numZbProfitTargetSize.ValueChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numZbPriceDegrees
            // 
            this.numZbPriceDegrees.Location = new System.Drawing.Point(215, 58);
            this.numZbPriceDegrees.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numZbPriceDegrees.Name = "numZbPriceDegrees";
            this.numZbPriceDegrees.Size = new System.Drawing.Size(120, 20);
            this.numZbPriceDegrees.TabIndex = 4;
            this.numZbPriceDegrees.ValueChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // numZbPriceMain
            // 
            this.numZbPriceMain.Location = new System.Drawing.Point(89, 58);
            this.numZbPriceMain.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numZbPriceMain.Name = "numZbPriceMain";
            this.numZbPriceMain.Size = new System.Drawing.Size(120, 20);
            this.numZbPriceMain.TabIndex = 3;
            this.numZbPriceMain.ValueChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // lblZbPriceNormalized
            // 
            this.lblZbPriceNormalized.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZbPriceNormalized.Location = new System.Drawing.Point(89, 81);
            this.lblZbPriceNormalized.Name = "lblZbPriceNormalized";
            this.lblZbPriceNormalized.Size = new System.Drawing.Size(246, 22);
            this.lblZbPriceNormalized.TabIndex = 5;
            this.lblZbPriceNormalized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabEs
            // 
            this.tabEs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabEs.Controls.Add(this.radEsShort);
            this.tabEs.Controls.Add(this.radEsLong);
            this.tabEs.Controls.Add(this.txtEsStopLossPrice);
            this.tabEs.Controls.Add(this.label5);
            this.tabEs.Controls.Add(this.txtEsTargetPrice);
            this.tabEs.Controls.Add(this.label7);
            this.tabEs.Controls.Add(this.label8);
            this.tabEs.Controls.Add(this.numEsStopLossSize);
            this.tabEs.Controls.Add(this.numEsProfitTargetSize);
            this.tabEs.Controls.Add(this.label9);
            this.tabEs.Controls.Add(this.numEsPriceDecimals);
            this.tabEs.Controls.Add(this.numEsPriceMain);
            this.tabEs.Controls.Add(this.lblEsPriceNormalized);
            this.tabEs.Controls.Add(this.label11);
            this.tabEs.Location = new System.Drawing.Point(4, 22);
            this.tabEs.Name = "tabEs";
            this.tabEs.Padding = new System.Windows.Forms.Padding(3);
            this.tabEs.Size = new System.Drawing.Size(352, 226);
            this.tabEs.TabIndex = 1;
            this.tabEs.Text = "ES";
            // 
            // radZbShort
            // 
            this.radZbShort.AutoSize = true;
            this.radZbShort.Location = new System.Drawing.Point(89, 26);
            this.radZbShort.Name = "radZbShort";
            this.radZbShort.Size = new System.Drawing.Size(50, 17);
            this.radZbShort.TabIndex = 1;
            this.radZbShort.Text = "Short";
            this.radZbShort.UseVisualStyleBackColor = true;
            this.radZbShort.CheckedChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // radZbLong
            // 
            this.radZbLong.AutoSize = true;
            this.radZbLong.Checked = true;
            this.radZbLong.Location = new System.Drawing.Point(8, 26);
            this.radZbLong.Name = "radZbLong";
            this.radZbLong.Size = new System.Drawing.Size(49, 17);
            this.radZbLong.TabIndex = 0;
            this.radZbLong.TabStop = true;
            this.radZbLong.Text = "Long";
            this.radZbLong.UseVisualStyleBackColor = true;
            this.radZbLong.CheckedChanged += new System.EventHandler(this.ZbInputChanged);
            // 
            // radEsShort
            // 
            this.radEsShort.AutoSize = true;
            this.radEsShort.Location = new System.Drawing.Point(94, 20);
            this.radEsShort.Name = "radEsShort";
            this.radEsShort.Size = new System.Drawing.Size(50, 17);
            this.radEsShort.TabIndex = 1;
            this.radEsShort.Text = "Short";
            this.radEsShort.UseVisualStyleBackColor = true;
            this.radEsShort.CheckedChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // radEsLong
            // 
            this.radEsLong.AutoSize = true;
            this.radEsLong.Checked = true;
            this.radEsLong.Location = new System.Drawing.Point(13, 20);
            this.radEsLong.Name = "radEsLong";
            this.radEsLong.Size = new System.Drawing.Size(49, 17);
            this.radEsLong.TabIndex = 0;
            this.radEsLong.TabStop = true;
            this.radEsLong.Text = "Long";
            this.radEsLong.UseVisualStyleBackColor = true;
            this.radEsLong.CheckedChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // txtEsStopLossPrice
            // 
            this.txtEsStopLossPrice.Location = new System.Drawing.Point(94, 184);
            this.txtEsStopLossPrice.Name = "txtEsStopLossPrice";
            this.txtEsStopLossPrice.ReadOnly = true;
            this.txtEsStopLossPrice.Size = new System.Drawing.Size(120, 20);
            this.txtEsStopLossPrice.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stop:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEsTargetPrice
            // 
            this.txtEsTargetPrice.Location = new System.Drawing.Point(94, 160);
            this.txtEsTargetPrice.Name = "txtEsTargetPrice";
            this.txtEsTargetPrice.ReadOnly = true;
            this.txtEsTargetPrice.Size = new System.Drawing.Size(120, 20);
            this.txtEsTargetPrice.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(13, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Target:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(13, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stop:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEsStopLossSize
            // 
            this.numEsStopLossSize.Location = new System.Drawing.Point(94, 126);
            this.numEsStopLossSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numEsStopLossSize.Name = "numEsStopLossSize";
            this.numEsStopLossSize.Size = new System.Drawing.Size(120, 20);
            this.numEsStopLossSize.TabIndex = 9;
            this.numEsStopLossSize.ValueChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // numEsProfitTargetSize
            // 
            this.numEsProfitTargetSize.Location = new System.Drawing.Point(94, 100);
            this.numEsProfitTargetSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numEsProfitTargetSize.Name = "numEsProfitTargetSize";
            this.numEsProfitTargetSize.Size = new System.Drawing.Size(120, 20);
            this.numEsProfitTargetSize.TabIndex = 7;
            this.numEsProfitTargetSize.ValueChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(13, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Target:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEsPriceDecimals
            // 
            this.numEsPriceDecimals.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numEsPriceDecimals.Location = new System.Drawing.Point(220, 52);
            this.numEsPriceDecimals.Name = "numEsPriceDecimals";
            this.numEsPriceDecimals.Size = new System.Drawing.Size(120, 20);
            this.numEsPriceDecimals.TabIndex = 4;
            this.numEsPriceDecimals.ValueChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // numEsPriceMain
            // 
            this.numEsPriceMain.Location = new System.Drawing.Point(94, 52);
            this.numEsPriceMain.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numEsPriceMain.Name = "numEsPriceMain";
            this.numEsPriceMain.Size = new System.Drawing.Size(120, 20);
            this.numEsPriceMain.TabIndex = 3;
            this.numEsPriceMain.ValueChanged += new System.EventHandler(this.EsInputChanged);
            // 
            // lblEsPriceNormalized
            // 
            this.lblEsPriceNormalized.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEsPriceNormalized.Location = new System.Drawing.Point(94, 75);
            this.lblEsPriceNormalized.Name = "lblEsPriceNormalized";
            this.lblEsPriceNormalized.Size = new System.Drawing.Size(246, 22);
            this.lblEsPriceNormalized.TabIndex = 5;
            this.lblEsPriceNormalized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(13, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Price:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 264);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spider Manual Trading Price Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabZb.ResumeLayout(false);
            this.tabZb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZbStopLossSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbProfitTargetSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbPriceDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZbPriceMain)).EndInit();
            this.tabEs.ResumeLayout(false);
            this.tabEs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEsStopLossSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsProfitTargetSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsPriceDecimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEsPriceMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabZb;
        private System.Windows.Forms.TabPage tabEs;
        private System.Windows.Forms.Label lblZbPriceNormalized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numZbPriceDegrees;
        private System.Windows.Forms.NumericUpDown numZbPriceMain;
        private System.Windows.Forms.TextBox txtZbStopDecimals;
        private System.Windows.Forms.TextBox txtZbStopDegrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZbTargetDecimals;
        private System.Windows.Forms.TextBox txtZbTargetDegrees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numZbStopLossSize;
        private System.Windows.Forms.NumericUpDown numZbProfitTargetSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radZbShort;
        private System.Windows.Forms.RadioButton radZbLong;
        private System.Windows.Forms.RadioButton radEsShort;
        private System.Windows.Forms.RadioButton radEsLong;
        private System.Windows.Forms.TextBox txtEsStopLossPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEsTargetPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numEsStopLossSize;
        private System.Windows.Forms.NumericUpDown numEsProfitTargetSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numEsPriceDecimals;
        private System.Windows.Forms.NumericUpDown numEsPriceMain;
        private System.Windows.Forms.Label lblEsPriceNormalized;
        private System.Windows.Forms.Label label11;
    }
}

