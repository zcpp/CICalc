namespace CICalc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvTime = new System.Windows.Forms.TextBox();
            this.cmbInvTimeUnit = new System.Windows.Forms.ComboBox();
            this.btnAddInvTime = new System.Windows.Forms.Button();
            this.btnReduceInvTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRegCycleUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegAddInv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOnceInv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSevChargeRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbReportDetailUnit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbShareOutCycleUnit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAnnualReturnsMockType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinAnnualReturnsRate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaxAnnualReturnsRate = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMaxLossRate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMinLossRate = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtLossProb = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtFixedAnnualReturnsRate = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbCarryOverCycleUnit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFracDigNum = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbRateRandomType = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbAdjustRegInv = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtAdjustRegInv = new System.Windows.Forms.TextBox();
            this.cmbInvType = new System.Windows.Forms.ComboBox();
            this.chkPassWeekend = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "投资方式:";
            // 
            // btnGenReport
            // 
            this.btnGenReport.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.btnGenReport.Location = new System.Drawing.Point(153, 689);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(212, 52);
            this.btnGenReport.TabIndex = 24;
            this.btnGenReport.Text = "计算并生成模拟明细";
            this.btnGenReport.UseVisualStyleBackColor = true;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "投资时长:";
            // 
            // txtInvTime
            // 
            this.txtInvTime.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtInvTime.Location = new System.Drawing.Point(265, 179);
            this.txtInvTime.Name = "txtInvTime";
            this.txtInvTime.Size = new System.Drawing.Size(50, 28);
            this.txtInvTime.TabIndex = 6;
            this.txtInvTime.Text = "1";
            this.txtInvTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInvTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtInvTime.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // cmbInvTimeUnit
            // 
            this.cmbInvTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvTimeUnit.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbInvTimeUnit.FormattingEnabled = true;
            this.cmbInvTimeUnit.Items.AddRange(new object[] {
            "年",
            "月",
            "天"});
            this.cmbInvTimeUnit.Location = new System.Drawing.Point(351, 180);
            this.cmbInvTimeUnit.Name = "cmbInvTimeUnit";
            this.cmbInvTimeUnit.Size = new System.Drawing.Size(42, 27);
            this.cmbInvTimeUnit.TabIndex = 9;
            // 
            // btnAddInvTime
            // 
            this.btnAddInvTime.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddInvTime.Location = new System.Drawing.Point(322, 179);
            this.btnAddInvTime.Name = "btnAddInvTime";
            this.btnAddInvTime.Size = new System.Drawing.Size(21, 28);
            this.btnAddInvTime.TabIndex = 8;
            this.btnAddInvTime.Text = "+";
            this.btnAddInvTime.UseVisualStyleBackColor = true;
            this.btnAddInvTime.Click += new System.EventHandler(this.btnAddInvTime_Click);
            // 
            // btnReduceInvTime
            // 
            this.btnReduceInvTime.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReduceInvTime.Location = new System.Drawing.Point(238, 179);
            this.btnReduceInvTime.Name = "btnReduceInvTime";
            this.btnReduceInvTime.Size = new System.Drawing.Size(21, 28);
            this.btnReduceInvTime.TabIndex = 7;
            this.btnReduceInvTime.Text = "-";
            this.btnReduceInvTime.UseVisualStyleBackColor = true;
            this.btnReduceInvTime.Click += new System.EventHandler(this.btnReduceInvTime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "定投方案:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(234, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "每";
            // 
            // cmbRegCycleUnit
            // 
            this.cmbRegCycleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegCycleUnit.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbRegCycleUnit.FormattingEnabled = true;
            this.cmbRegCycleUnit.Items.AddRange(new object[] {
            "年",
            "月",
            "天"});
            this.cmbRegCycleUnit.Location = new System.Drawing.Point(266, 97);
            this.cmbRegCycleUnit.Name = "cmbRegCycleUnit";
            this.cmbRegCycleUnit.Size = new System.Drawing.Size(42, 27);
            this.cmbRegCycleUnit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(314, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "定投";
            // 
            // txtRegAddInv
            // 
            this.txtRegAddInv.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtRegAddInv.Location = new System.Drawing.Point(366, 96);
            this.txtRegAddInv.Name = "txtRegAddInv";
            this.txtRegAddInv.Size = new System.Drawing.Size(94, 28);
            this.txtRegAddInv.TabIndex = 3;
            this.txtRegAddInv.Text = "100";
            this.txtRegAddInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRegAddInv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtRegAddInv.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(466, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "一次性/首次投入:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(341, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "元";
            // 
            // txtOnceInv
            // 
            this.txtOnceInv.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtOnceInv.Location = new System.Drawing.Point(238, 57);
            this.txtOnceInv.Name = "txtOnceInv";
            this.txtOnceInv.Size = new System.Drawing.Size(94, 28);
            this.txtOnceInv.TabIndex = 1;
            this.txtOnceInv.Text = "100";
            this.txtOnceInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOnceInv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtOnceInv.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "交易手续费率:";
            // 
            // txtSevChargeRate
            // 
            this.txtSevChargeRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtSevChargeRate.Location = new System.Drawing.Point(238, 221);
            this.txtSevChargeRate.Name = "txtSevChargeRate";
            this.txtSevChargeRate.Size = new System.Drawing.Size(58, 28);
            this.txtSevChargeRate.TabIndex = 10;
            this.txtSevChargeRate.Text = "0";
            this.txtSevChargeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSevChargeRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtSevChargeRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(296, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "计算结果周期单位:";
            // 
            // cmbReportDetailUnit
            // 
            this.cmbReportDetailUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportDetailUnit.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbReportDetailUnit.FormattingEnabled = true;
            this.cmbReportDetailUnit.Items.AddRange(new object[] {
            "天",
            "月"});
            this.cmbReportDetailUnit.Location = new System.Drawing.Point(238, 566);
            this.cmbReportDetailUnit.Name = "cmbReportDetailUnit";
            this.cmbReportDetailUnit.Size = new System.Drawing.Size(42, 27);
            this.cmbReportDetailUnit.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(12, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "分红";
            // 
            // cmbShareOutCycleUnit
            // 
            this.cmbShareOutCycleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShareOutCycleUnit.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbShareOutCycleUnit.FormattingEnabled = true;
            this.cmbShareOutCycleUnit.Items.AddRange(new object[] {
            "日",
            "月"});
            this.cmbShareOutCycleUnit.Location = new System.Drawing.Point(270, 482);
            this.cmbShareOutCycleUnit.Name = "cmbShareOutCycleUnit";
            this.cmbShareOutCycleUnit.Size = new System.Drawing.Size(42, 27);
            this.cmbShareOutCycleUnit.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(235, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "每";
            // 
            // cmbAnnualReturnsMockType
            // 
            this.cmbAnnualReturnsMockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnualReturnsMockType.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbAnnualReturnsMockType.FormattingEnabled = true;
            this.cmbAnnualReturnsMockType.Items.AddRange(new object[] {
            "固定平均",
            "随机浮动"});
            this.cmbAnnualReturnsMockType.Location = new System.Drawing.Point(238, 264);
            this.cmbAnnualReturnsMockType.Name = "cmbAnnualReturnsMockType";
            this.cmbAnnualReturnsMockType.Size = new System.Drawing.Size(114, 27);
            this.cmbAnnualReturnsMockType.TabIndex = 11;
            this.cmbAnnualReturnsMockType.SelectedIndexChanged += new System.EventHandler(this.cmbAnnualReturnsMockType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(12, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "年化收益率模拟方式:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(12, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "年化收益率浮动范围:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(296, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 19);
            this.label18.TabIndex = 36;
            this.label18.Text = "%";
            // 
            // txtMinAnnualReturnsRate
            // 
            this.txtMinAnnualReturnsRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtMinAnnualReturnsRate.Location = new System.Drawing.Point(238, 354);
            this.txtMinAnnualReturnsRate.Name = "txtMinAnnualReturnsRate";
            this.txtMinAnnualReturnsRate.Size = new System.Drawing.Size(57, 28);
            this.txtMinAnnualReturnsRate.TabIndex = 14;
            this.txtMinAnnualReturnsRate.Text = "0";
            this.txtMinAnnualReturnsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinAnnualReturnsRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtMinAnnualReturnsRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(321, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 19);
            this.label19.TabIndex = 37;
            this.label19.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(408, 357);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 19);
            this.label20.TabIndex = 39;
            this.label20.Text = "%";
            // 
            // txtMaxAnnualReturnsRate
            // 
            this.txtMaxAnnualReturnsRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtMaxAnnualReturnsRate.Location = new System.Drawing.Point(350, 354);
            this.txtMaxAnnualReturnsRate.Name = "txtMaxAnnualReturnsRate";
            this.txtMaxAnnualReturnsRate.Size = new System.Drawing.Size(57, 28);
            this.txtMaxAnnualReturnsRate.TabIndex = 15;
            this.txtMaxAnnualReturnsRate.Text = "0";
            this.txtMaxAnnualReturnsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxAnnualReturnsRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtMaxAnnualReturnsRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(408, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 19);
            this.label21.TabIndex = 45;
            this.label21.Text = "%";
            // 
            // txtMaxLossRate
            // 
            this.txtMaxLossRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtMaxLossRate.Location = new System.Drawing.Point(350, 397);
            this.txtMaxLossRate.Name = "txtMaxLossRate";
            this.txtMaxLossRate.Size = new System.Drawing.Size(57, 28);
            this.txtMaxLossRate.TabIndex = 17;
            this.txtMaxLossRate.Text = "0";
            this.txtMaxLossRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxLossRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtMaxLossRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(321, 400);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 19);
            this.label22.TabIndex = 43;
            this.label22.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(296, 400);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 19);
            this.label23.TabIndex = 42;
            this.label23.Text = "%";
            // 
            // txtMinLossRate
            // 
            this.txtMinLossRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtMinLossRate.Location = new System.Drawing.Point(238, 397);
            this.txtMinLossRate.Name = "txtMinLossRate";
            this.txtMinLossRate.Size = new System.Drawing.Size(57, 28);
            this.txtMinLossRate.TabIndex = 16;
            this.txtMinLossRate.Text = "0";
            this.txtMinLossRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinLossRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtMinLossRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(12, 400);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 19);
            this.label24.TabIndex = 40;
            this.label24.Text = "亏损率范围:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(296, 443);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 19);
            this.label25.TabIndex = 48;
            this.label25.Text = "%";
            // 
            // txtLossProb
            // 
            this.txtLossProb.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtLossProb.Location = new System.Drawing.Point(238, 440);
            this.txtLossProb.Name = "txtLossProb";
            this.txtLossProb.Size = new System.Drawing.Size(57, 28);
            this.txtLossProb.TabIndex = 18;
            this.txtLossProb.Text = "0";
            this.txtLossProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLossProb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtLossProb.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(12, 443);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 19);
            this.label26.TabIndex = 46;
            this.label26.Text = "亏损概率:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(297, 312);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 19);
            this.label27.TabIndex = 51;
            this.label27.Text = "%";
            // 
            // txtFixedAnnualReturnsRate
            // 
            this.txtFixedAnnualReturnsRate.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtFixedAnnualReturnsRate.Location = new System.Drawing.Point(238, 309);
            this.txtFixedAnnualReturnsRate.Name = "txtFixedAnnualReturnsRate";
            this.txtFixedAnnualReturnsRate.Size = new System.Drawing.Size(57, 28);
            this.txtFixedAnnualReturnsRate.TabIndex = 13;
            this.txtFixedAnnualReturnsRate.Text = "0";
            this.txtFixedAnnualReturnsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFixedAnnualReturnsRate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtFixedAnnualReturnsRate.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(12, 312);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(199, 19);
            this.label28.TabIndex = 49;
            this.label28.Text = "固定平均年化收益率:";
            // 
            // cmbCarryOverCycleUnit
            // 
            this.cmbCarryOverCycleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarryOverCycleUnit.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbCarryOverCycleUnit.FormattingEnabled = true;
            this.cmbCarryOverCycleUnit.Items.AddRange(new object[] {
            "日",
            "月"});
            this.cmbCarryOverCycleUnit.Location = new System.Drawing.Point(270, 524);
            this.cmbCarryOverCycleUnit.Name = "cmbCarryOverCycleUnit";
            this.cmbCarryOverCycleUnit.Size = new System.Drawing.Size(42, 27);
            this.cmbCarryOverCycleUnit.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(235, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = "每";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(12, 527);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 52;
            this.label15.Text = "结转";
            // 
            // cmbFracDigNum
            // 
            this.cmbFracDigNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFracDigNum.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbFracDigNum.FormattingEnabled = true;
            this.cmbFracDigNum.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbFracDigNum.Location = new System.Drawing.Point(238, 608);
            this.cmbFracDigNum.Name = "cmbFracDigNum";
            this.cmbFracDigNum.Size = new System.Drawing.Size(42, 27);
            this.cmbFracDigNum.TabIndex = 22;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(12, 611);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(179, 19);
            this.label29.TabIndex = 55;
            this.label29.Text = "小数点后保留位数:";
            // 
            // cmbRateRandomType
            // 
            this.cmbRateRandomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRateRandomType.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbRateRandomType.FormattingEnabled = true;
            this.cmbRateRandomType.Items.AddRange(new object[] {
            "整体增长小区间随机",
            "整体随机"});
            this.cmbRateRandomType.Location = new System.Drawing.Point(366, 264);
            this.cmbRateRandomType.Name = "cmbRateRandomType";
            this.cmbRateRandomType.Size = new System.Drawing.Size(212, 27);
            this.cmbRateRandomType.TabIndex = 12;
            this.cmbRateRandomType.SelectedIndexChanged += new System.EventHandler(this.cmbRateRandomType_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(12, 142);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 19);
            this.label30.TabIndex = 57;
            this.label30.Text = "定投额调整:";
            // 
            // cmbAdjustRegInv
            // 
            this.cmbAdjustRegInv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdjustRegInv.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbAdjustRegInv.FormattingEnabled = true;
            this.cmbAdjustRegInv.Items.AddRange(new object[] {
            "保持不变",
            "每年增加",
            "每月增加"});
            this.cmbAdjustRegInv.Location = new System.Drawing.Point(238, 139);
            this.cmbAdjustRegInv.Name = "cmbAdjustRegInv";
            this.cmbAdjustRegInv.Size = new System.Drawing.Size(114, 27);
            this.cmbAdjustRegInv.TabIndex = 4;
            this.cmbAdjustRegInv.SelectedIndexChanged += new System.EventHandler(this.cmbAdjustRegInv_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(466, 143);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 19);
            this.label31.TabIndex = 60;
            this.label31.Text = "元";
            // 
            // txtAdjustRegInv
            // 
            this.txtAdjustRegInv.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.txtAdjustRegInv.Location = new System.Drawing.Point(366, 139);
            this.txtAdjustRegInv.Name = "txtAdjustRegInv";
            this.txtAdjustRegInv.Size = new System.Drawing.Size(94, 28);
            this.txtAdjustRegInv.TabIndex = 5;
            this.txtAdjustRegInv.Text = "100";
            this.txtAdjustRegInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdjustRegInv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnAllTextBoxMouseClick);
            this.txtAdjustRegInv.TextChanged += new System.EventHandler(this.OnAllTextBoxTextChanged);
            // 
            // cmbInvType
            // 
            this.cmbInvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvType.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbInvType.FormattingEnabled = true;
            this.cmbInvType.Items.AddRange(new object[] {
            "一次性",
            "定投",
            "首次 + 定投"});
            this.cmbInvType.Location = new System.Drawing.Point(238, 19);
            this.cmbInvType.Name = "cmbInvType";
            this.cmbInvType.Size = new System.Drawing.Size(189, 27);
            this.cmbInvType.TabIndex = 0;
            this.cmbInvType.SelectedIndexChanged += new System.EventHandler(this.cmbInvType_SelectedIndexChanged);
            // 
            // chkPassWeekend
            // 
            this.chkPassWeekend.AutoSize = true;
            this.chkPassWeekend.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.chkPassWeekend.Location = new System.Drawing.Point(16, 651);
            this.chkPassWeekend.Name = "chkPassWeekend";
            this.chkPassWeekend.Size = new System.Drawing.Size(288, 23);
            this.chkPassWeekend.TabIndex = 23;
            this.chkPassWeekend.Text = "非交易日无收益(仅支持周末)";
            this.chkPassWeekend.UseVisualStyleBackColor = true;
            this.chkPassWeekend.CheckedChanged += new System.EventHandler(this.chkPassWeekend_CheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 756);
            this.Controls.Add(this.chkPassWeekend);
            this.Controls.Add(this.cmbInvType);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtAdjustRegInv);
            this.Controls.Add(this.cmbAdjustRegInv);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.cmbRateRandomType);
            this.Controls.Add(this.cmbFracDigNum);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.cmbCarryOverCycleUnit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtFixedAnnualReturnsRate);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtLossProb);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtMaxLossRate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtMinLossRate);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMaxAnnualReturnsRate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtMinAnnualReturnsRate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbAnnualReturnsMockType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbShareOutCycleUnit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbReportDetailUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSevChargeRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOnceInv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRegAddInv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRegCycleUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReduceInvTime);
            this.Controls.Add(this.btnAddInvTime);
            this.Controls.Add(this.cmbInvTimeUnit);
            this.Controls.Add(this.txtInvTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "投资复利收益计算器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvTime;
        private System.Windows.Forms.ComboBox cmbInvTimeUnit;
        private System.Windows.Forms.Button btnAddInvTime;
        private System.Windows.Forms.Button btnReduceInvTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRegCycleUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegAddInv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOnceInv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSevChargeRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbReportDetailUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbShareOutCycleUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAnnualReturnsMockType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMinAnnualReturnsRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaxAnnualReturnsRate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMaxLossRate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtMinLossRate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtLossProb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtFixedAnnualReturnsRate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbCarryOverCycleUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbFracDigNum;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbRateRandomType;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cmbAdjustRegInv;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtAdjustRegInv;
        private System.Windows.Forms.ComboBox cmbInvType;
        private System.Windows.Forms.CheckBox chkPassWeekend;
    }
}

