using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CICalc
{
    public partial class ChartForm : Form
    {
        private ChartDataType _chartDataType;
        private List<DataTable> _dataTables;
        ToolTip _toolTip;

        public ChartForm(ChartDataType chartDataType, List<DataTable> dataTables)
        {
            this._chartDataType = chartDataType;
            this._dataTables = dataTables;
            InitializeComponent();

            _toolTip = new ToolTip();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            InitChart();
            LoadChartData();
        }

        private void InitChart()
        {
            this.chartReport.ChartAreas[0].CursorX.IsUserEnabled = true;
            this.chartReport.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            this.chartReport.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.chartReport.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            this.chartReport.ChartAreas[0].AxisX.ScrollBar.Size = 20;
            this.chartReport.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            this.chartReport.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = double.NaN;
            this.chartReport.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 2;

            this.chartReport.MouseClick += ChartReport_MouseClick;
        }

        private void ChartReport_MouseClick(object sender, MouseEventArgs e)
        {
            var cursorXValue = this.chartReport.ChartAreas[0].CursorX.Position;
            if (!double.IsNaN(cursorXValue) && cursorXValue >= 0)
            {
                //当X轴值类型为string时，获取到的CursorX的值实际上就是X轴的顺序编号(会在datasource table rows count前后各加一个)
                var cusorXIndex = Convert.ToInt32(cursorXValue);
                if (cusorXIndex > 0 && cusorXIndex <= this._dataTables[0].Rows.Count)
                {
                    bool isDateSet = false;
                    var sb = new StringBuilder();
                    for (int i = 0; i < this._dataTables.Count; i++)
                    {
                        if (!isDateSet)
                        {
                            var date = this._dataTables[i].Rows[cusorXIndex - 1].ItemArray[0].ToString();
                            isDateSet = true;
                            sb.AppendLine(date);
                        }
                        sb.AppendLine(
                            string.Format(
                                "{0}: {1}%",
                                this.chartReport.Series[i].Name.Substring(0, this.chartReport.Series[i].Name.Length - 3),
                                this.chartReport.Series[i].Points[cusorXIndex - 1].YValues[0].ToString()));
                    }
                    //tooltip悬停显示3秒钟
                    _toolTip.Show(sb.ToString(), this, e.X, e.Y, 3000);
                }
            }
        }
        
        private void LoadChartData()
        {
            this.chartReport.Series.Clear();

            if (this._dataTables != null && this._dataTables.Count > 0)
            {
                if (_chartDataType == ChartDataType.All)
                {
                    for (int i = 0; i < this._dataTables.Count; i++)
                    {
                        var series = new Series(GetChartSeriesName(ChartDataType.All, i));
                        series.Points.DataBind(this._dataTables[i].AsEnumerable(), "Date", "Rate", "");
                        series.XValueType = ChartValueType.String;
                        series.ChartType = SeriesChartType.Spline;
                        series.BorderWidth = 2;
                        this.chartReport.Series.Add(series);
                    }
                }
                else
                {
                    var series = new Series(GetChartSeriesName(_chartDataType));
                    series.Points.DataBind(this._dataTables[0].AsEnumerable(), "Date", "Rate", "");
                    series.XValueType = ChartValueType.String;
                    series.ChartType = SeriesChartType.Spline;
                    series.BorderWidth = 2;
                    this.chartReport.Series.Add(series);
                }
            }
        }

        private string GetChartSeriesName(ChartDataType chartDataType, int dataTableIndex)
        {
            if (chartDataType != ChartDataType.All)
                return string.Empty;

            switch (dataTableIndex)
            {
                case 0:
                    return "年化收益率(%)";
                case 1:
                    return "平均年化收益率(%)";
                case 2:
                    return "资产增长率(%)";
                default:
                    return string.Empty;
            }
        }

        private string GetChartSeriesName(ChartDataType chartDataType)
        {
            if (chartDataType == ChartDataType.All)
                return string.Empty;

            switch (chartDataType)
            {
                case ChartDataType.DailyAnnualReturnsRate:
                    return "年化收益率(%)";
                case ChartDataType.DailyAvgAnnualReturnsRate:
                    return "平均年化收益率(%)";
                case ChartDataType.TotalGrowthRate:
                    return "资产增长率(%)";
                default:
                    return string.Empty;
            }
        }
    }
}
