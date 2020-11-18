namespace CICalc
{
    partial class DetailReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailReportForm));
            this.dgvDetailReport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiagramIndicator = new System.Windows.Forms.ComboBox();
            this.btnGenDiagram = new System.Windows.Forms.Button();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGarriedOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNonCarriedOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDailyReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDailyReturnsRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccumulativeReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccumulativeInvested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvgAnnualReturnsRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalGrowthRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailReport
            // 
            this.dgvDetailReport.AllowUserToAddRows = false;
            this.dgvDetailReport.AllowUserToDeleteRows = false;
            this.dgvDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("YouYuan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetailReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColGarriedOver,
            this.ColNonCarriedOver,
            this.ColDailyReturns,
            this.ColDailyReturnsRate,
            this.ColAccumulativeReturns,
            this.ColAccumulativeInvested,
            this.ColAvgAnnualReturnsRate,
            this.ColTotalGrowthRate,
            this.ColTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("YouYuan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetailReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetailReport.Location = new System.Drawing.Point(12, 12);
            this.dgvDetailReport.Name = "dgvDetailReport";
            this.dgvDetailReport.ReadOnly = true;
            this.dgvDetailReport.RowHeadersVisible = false;
            this.dgvDetailReport.RowTemplate.Height = 23;
            this.dgvDetailReport.Size = new System.Drawing.Size(1004, 572);
            this.dgvDetailReport.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("YouYuan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(522, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "曲线指标:";
            // 
            // cmbDiagramIndicator
            // 
            this.cmbDiagramIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiagramIndicator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagramIndicator.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.cmbDiagramIndicator.FormattingEnabled = true;
            this.cmbDiagramIndicator.Items.AddRange(new object[] {
            "合并",
            "每日年化收益率",
            "每日平均年化收益率",
            "资产增长率"});
            this.cmbDiagramIndicator.Location = new System.Drawing.Point(627, 605);
            this.cmbDiagramIndicator.Name = "cmbDiagramIndicator";
            this.cmbDiagramIndicator.Size = new System.Drawing.Size(222, 27);
            this.cmbDiagramIndicator.TabIndex = 1;
            // 
            // btnGenDiagram
            // 
            this.btnGenDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenDiagram.Font = new System.Drawing.Font("YouYuan", 14.25F);
            this.btnGenDiagram.Location = new System.Drawing.Point(868, 599);
            this.btnGenDiagram.Name = "btnGenDiagram";
            this.btnGenDiagram.Size = new System.Drawing.Size(148, 37);
            this.btnGenDiagram.TabIndex = 2;
            this.btnGenDiagram.Text = "生成曲线图";
            this.btnGenDiagram.UseVisualStyleBackColor = true;
            this.btnGenDiagram.Click += new System.EventHandler(this.btnGenDiagram_Click);
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "日期";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColGarriedOver
            // 
            this.ColGarriedOver.HeaderText = "已结转(元)";
            this.ColGarriedOver.Name = "ColGarriedOver";
            this.ColGarriedOver.ReadOnly = true;
            this.ColGarriedOver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColNonCarriedOver
            // 
            this.ColNonCarriedOver.HeaderText = "未结转(元)";
            this.ColNonCarriedOver.Name = "ColNonCarriedOver";
            this.ColNonCarriedOver.ReadOnly = true;
            this.ColNonCarriedOver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDailyReturns
            // 
            this.ColDailyReturns.HeaderText = "收益(元)";
            this.ColDailyReturns.Name = "ColDailyReturns";
            this.ColDailyReturns.ReadOnly = true;
            this.ColDailyReturns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDailyReturnsRate
            // 
            this.ColDailyReturnsRate.HeaderText = "年化收益率(%)";
            this.ColDailyReturnsRate.Name = "ColDailyReturnsRate";
            this.ColDailyReturnsRate.ReadOnly = true;
            this.ColDailyReturnsRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAccumulativeReturns
            // 
            this.ColAccumulativeReturns.HeaderText = "累计收益(元)";
            this.ColAccumulativeReturns.Name = "ColAccumulativeReturns";
            this.ColAccumulativeReturns.ReadOnly = true;
            this.ColAccumulativeReturns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAccumulativeInvested
            // 
            this.ColAccumulativeInvested.HeaderText = "累计投入(元)";
            this.ColAccumulativeInvested.Name = "ColAccumulativeInvested";
            this.ColAccumulativeInvested.ReadOnly = true;
            this.ColAccumulativeInvested.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAvgAnnualReturnsRate
            // 
            this.ColAvgAnnualReturnsRate.HeaderText = "平均年化收益率(%)";
            this.ColAvgAnnualReturnsRate.Name = "ColAvgAnnualReturnsRate";
            this.ColAvgAnnualReturnsRate.ReadOnly = true;
            this.ColAvgAnnualReturnsRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTotalGrowthRate
            // 
            this.ColTotalGrowthRate.HeaderText = "资产增长率(%)";
            this.ColTotalGrowthRate.Name = "ColTotalGrowthRate";
            this.ColTotalGrowthRate.ReadOnly = true;
            this.ColTotalGrowthRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "总资产(元)";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DetailReportForm
            // 
            this.AcceptButton = this.btnGenDiagram;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 646);
            this.Controls.Add(this.btnGenDiagram);
            this.Controls.Add(this.cmbDiagramIndicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDetailReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "计算结果";
            this.Load += new System.EventHandler(this.DetailReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDiagramIndicator;
        private System.Windows.Forms.Button btnGenDiagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGarriedOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNonCarriedOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDailyReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDailyReturnsRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccumulativeReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccumulativeInvested;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvgAnnualReturnsRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalGrowthRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}