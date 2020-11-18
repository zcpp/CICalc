using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CICalc
{
    public partial class DetailReportForm : Form
    {
        private string DecimalFormat = "{0:N2}";

        private List<DailyStatus> _dailyStatuses;
        private DateFrequency _reportDateFreq;

        private List<DataTable> _dataTables;

        public DetailReportForm(List<DailyStatus> dailyStatuses, DateFrequency reportDateFreq, int fracDigNum)
        {
            this._dailyStatuses = dailyStatuses;
            this._reportDateFreq = reportDateFreq;

            this.DecimalFormat = "{0:N" + fracDigNum.ToString() + "}";

            InitializeComponent();
        }

        private void DetailReportForm_Load(object sender, EventArgs e)
        {
            this.btnGenDiagram.Enabled = false;
            this.cmbDiagramIndicator.SelectedIndex = 0;
            LoadReport();
        }

        private void LoadReport()
        {
            this.dgvDetailReport.Rows.Clear();
            if (this._dailyStatuses != null && this._dailyStatuses.Count > 0)
            {
                foreach (var dailyStatus in this._dailyStatuses)
                {
                    this.dgvDetailReport.Rows.Add(
                        dailyStatus.Date.ToString("yyyy-MM-dd"),
                        string.Format(DecimalFormat, dailyStatus.CurrentCarriedOverTotal),
                        string.Format(DecimalFormat, dailyStatus.CurrentNonCarriedOverReturns),
                        string.Format(DecimalFormat, dailyStatus.CurrentDayReturns),
                        string.Format(DecimalFormat, dailyStatus.CurrentDayReturnsRate * 100),
                        string.Format(DecimalFormat, dailyStatus.AccumulativeReturns),
                        string.Format(DecimalFormat, dailyStatus.AccumulativeInvested),
                        string.Format(DecimalFormat, dailyStatus.CurrentAverageAnnualReturnsRate * 100),
                        string.Format(DecimalFormat, dailyStatus.CurrentTotalGrowthRate * 100),
                        string.Format(DecimalFormat, dailyStatus.CurrentTotal)
                        );
                }

                this.btnGenDiagram.Enabled = true;
            }
            else
            {
                this.btnGenDiagram.Enabled = false;
            }
        }

        private void btnGenDiagram_Click(object sender, EventArgs e)
        {
            ChartDataType chartDataType = ChartDataType.All;
            _dataTables = new List<DataTable>();
            DataTable dt1, dt2, dt3;
            switch(this.cmbDiagramIndicator.SelectedIndex)
            {
                case 0: //合并
                    chartDataType = ChartDataType.All;

                    dt1 = new DataTable();
                    dt1.Columns.Add("Date", typeof(string));
                    dt1.Columns.Add("Rate", typeof(decimal));
                    dt2 = new DataTable();
                    dt2.Columns.Add("Date", typeof(string));
                    dt2.Columns.Add("Rate", typeof(decimal));
                    dt3 = new DataTable();
                    dt3.Columns.Add("Date", typeof(string));
                    dt3.Columns.Add("Rate", typeof(decimal));
                    foreach (var item in this._dailyStatuses)
                    {
                        if (this._reportDateFreq == DateFrequency.Daily ||
                            (this._reportDateFreq == DateFrequency.Monthly && item.Date.Day == 1))
                        {
                            dt1.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentDayReturnsRate * 100)));
                            dt2.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentAverageAnnualReturnsRate * 100)));
                            dt3.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentTotalGrowthRate * 100)));
                        }
                    }
                    _dataTables.Add(dt1);
                    _dataTables.Add(dt2);
                    _dataTables.Add(dt3);
                    break;
                case 1: //每日年化收益率
                    chartDataType = ChartDataType.DailyAnnualReturnsRate;

                    dt1 = new DataTable();
                    dt1.Columns.Add("Date", typeof(string));
                    dt1.Columns.Add("Rate", typeof(decimal));
                    foreach (var item in this._dailyStatuses)
                    {
                        if (this._reportDateFreq == DateFrequency.Daily ||
                            (this._reportDateFreq == DateFrequency.Monthly && item.Date.Day == 1))
                        {
                            dt1.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentDayReturnsRate * 100)));
                        }
                    }
                    _dataTables.Add(dt1);
                    break;
                case 2: //每日平均年化收益率
                    chartDataType = ChartDataType.DailyAvgAnnualReturnsRate;

                    dt2 = new DataTable();
                    dt2.Columns.Add("Date", typeof(string));
                    dt2.Columns.Add("Rate", typeof(decimal));
                    foreach (var item in this._dailyStatuses)
                    {
                        if (this._reportDateFreq == DateFrequency.Daily ||
                            (this._reportDateFreq == DateFrequency.Monthly && item.Date.Day == 1))
                        {
                            dt2.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentAverageAnnualReturnsRate * 100)));
                        }
                    }
                    _dataTables.Add(dt2);
                    break;
                case 3: //资产增长率
                    chartDataType = ChartDataType.TotalGrowthRate;

                    dt3 = new DataTable();
                    dt3.Columns.Add("Date", typeof(string));
                    dt3.Columns.Add("Rate", typeof(decimal));
                    foreach (var item in this._dailyStatuses)
                    {
                        if (this._reportDateFreq == DateFrequency.Daily ||
                            (this._reportDateFreq == DateFrequency.Monthly && item.Date.Day == 1))
                        {
                            dt3.Rows.Add(item.Date.ToString("yyyy-MM-dd"), Decimal.Parse(string.Format(DecimalFormat, item.CurrentTotalGrowthRate * 100)));
                        }
                    }
                    _dataTables.Add(dt3);
                    break;
                default:
                    break;
            }

            (new ChartForm(chartDataType, _dataTables)).ShowDialog();
        }
    }
}
