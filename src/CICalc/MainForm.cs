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
    public partial class MainForm : Form
    {
        private const int RateDivisionCount = 50; //根据最小到最大收益率范围分成的小区间段数量
        private const int RateRandomOffset = 3; //小区间的偏移段数量

        private decimal Input_RegAddInv = Convert.ToDecimal(100);
        private decimal Input_OnceInv = Convert.ToDecimal(100);
        private int Input_InvTime = 1;
        private decimal Input_SevChargeRate = Decimal.Zero;
        private decimal Input_FixedAnnualReturnsRate = Decimal.Zero;
        private decimal Input_MinAnnualReturnsRate = Decimal.Zero;
        private decimal Input_MaxAnnualReturnsRate = Decimal.Zero;
        private decimal Input_MinLossRate = Decimal.Zero;
        private decimal Input_MaxLossRate = Decimal.Zero;
        private decimal Input_LossProb = Decimal.Zero;
        private decimal Input_AdjustRegInv = Convert.ToDecimal(100);

        private InvType Input_InvType;
        private RegInvAdjType Input_RegInvAdjType;
        private DateUnit Input_RegAddDateUnit;
        private DateUnit Input_InvTimeDateUnit;
        private bool Input_IsFixedReturn;
        private bool Input_IsFullRandomRate;
        private DateFrequency Input_ShareOutFreq;
        private DateFrequency Input_CarryOverFreq;
        private DateFrequency Input_ReportDateFreq;
        private int Input_FracDigNum;

        private DateTime _startDay = new DateTime(2020, 12, 31);
        private DateTime _currentDay = new DateTime(2020, 12, 31);
        private DateTime _endDay = new DateTime(2020, 12, 31);

        private decimal _currentCarriedOverTotal; //当前已结转资产
        private decimal _currentNonCarriedOverReturns; //当前未结转收益
        private decimal _currentNonSharedOutReturns; //当前尚未计入的分红
        private decimal _currentTotal; //当前总资产
        private decimal _currentDayReturns; //当日收益
        private decimal _currentDayReturnsRate; //当日年化收益率
        private decimal _accumulativeReturns; //累计收益
        private decimal _accumulativeInvested; //累计投入

        private List<DailyStatus> _dailyStatuses = new List<DailyStatus>();

        private Random _random = null;

        #region Form initialization

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cmbRegCycleUnit.SelectedIndex = 1;
            this.cmbInvTimeUnit.SelectedIndex = 0;
            this.cmbAnnualReturnsMockType.SelectedIndex = 0;
            this.cmbShareOutCycleUnit.SelectedIndex = 0;
            this.cmbCarryOverCycleUnit.SelectedIndex = 0;
            this.cmbReportDetailUnit.SelectedIndex = 0;
            this.cmbFracDigNum.SelectedIndex = 0;

            this.cmbRateRandomType.SelectedIndex = 0;

            this.cmbInvType.SelectedIndex = 0;
            this.cmbAdjustRegInv.SelectedIndex = 0;
        }

        #endregion

        #region Calculation logic

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            _startDay = new DateTime(2020, 12, 31);
            _currentDay = new DateTime(2020, 12, 31);
            _endDay = new DateTime(2020, 12, 31);

            if (!this.PrepareInputCheck())
                return;
            this.btnGenReport.Enabled = false;

            InitializeData();

            DoCalculation();

            (new DetailReportForm(this._dailyStatuses, this.Input_ReportDateFreq, this.Input_FracDigNum)).ShowDialog();

            this.btnGenReport.Enabled = true;
        }

        private void InitializeData()
        {
            _dailyStatuses.Clear();

            if (this.Input_InvType == InvType.Once || this.Input_InvType == InvType.OnceAndRegular) //计入一次性固定投入
            {
                if (this.Input_SevChargeRate > Decimal.Zero) //考虑手续费
                {
                    this._currentCarriedOverTotal = this.Input_OnceInv * (1 - this.Input_SevChargeRate);
                }
                else
                {
                    this._currentCarriedOverTotal = this.Input_OnceInv;
                }
            }
            else
            {
                this._currentCarriedOverTotal = Decimal.Zero;
            }

            this._currentTotal = _currentCarriedOverTotal;
            this._currentNonCarriedOverReturns = Decimal.Zero;
            this._currentNonSharedOutReturns = Decimal.Zero;
            this._currentDayReturns = Decimal.Zero;
            this._currentDayReturnsRate = Decimal.Zero;
            this._accumulativeReturns = Decimal.Zero;
            this._accumulativeInvested = _currentCarriedOverTotal;
        }

        private void DoCalculation()
        {
            var totalDays = (this._endDay - this._startDay).Days;

            var lastRegInvAdjDate = new DateTime(2021, 1, 1);
            var hasFirstRegDone = false;

            while (this._endDay >= this._currentDay)
            {
                this._currentDay = this._currentDay.AddDays(1);
                var daysOfYear = DateTime.IsLeapYear(this._currentDay.Year) ? 366 : 365;
                var startedDays = (this._currentDay - this._startDay).Days;

                var dailyStatus = new DailyStatus();
                dailyStatus.Date = new DateTime(this._currentDay.Year, this._currentDay.Month, this._currentDay.Day);

                //计入定投
                if (this.Input_InvType == InvType.Regular || this.Input_InvType == InvType.OnceAndRegular)
                {
                    if (this.Input_RegInvAdjType != RegInvAdjType.None)
                    {
                        if (this.Input_RegInvAdjType == RegInvAdjType.Monthly) //定投额每月增加
                        {
                            if (this._currentDay.Year == lastRegInvAdjDate.Year && (this._currentDay.Month - lastRegInvAdjDate.Month) == 1)
                            {
                                this.Input_RegAddInv += this.Input_AdjustRegInv;
                                lastRegInvAdjDate = new DateTime(this._currentDay.Year, this._currentDay.Month, this._currentDay.Day);
                            }
                        }
                        else //定投额每年增加
                        {
                            if ((this._currentDay.Year - lastRegInvAdjDate.Year) == 1)
                            {
                                this.Input_RegAddInv += this.Input_AdjustRegInv;
                                lastRegInvAdjDate = new DateTime(this._currentDay.Year, this._currentDay.Month, this._currentDay.Day);
                            }
                        }
                    }

                    if (this.Input_InvType == InvType.Regular || hasFirstRegDone) //单纯定投
                    {
                        if (this.Input_RegAddDateUnit == DateUnit.Day ||
                            (this.Input_RegAddDateUnit == DateUnit.Month && this._currentDay.Day == 1) ||
                            (this.Input_RegAddDateUnit == DateUnit.Year && this._currentDay.Month == 1 && this._currentDay.Day == 1))
                        {
                            if (this.Input_SevChargeRate > Decimal.Zero) //考虑手续费
                            {
                                this._currentCarriedOverTotal += (this.Input_RegAddInv * (1 - this.Input_SevChargeRate));
                                this._accumulativeInvested += (this.Input_RegAddInv * (1 - this.Input_SevChargeRate));
                            }
                            else
                            {
                                this._currentCarriedOverTotal += this.Input_RegAddInv;
                                this._accumulativeInvested += this.Input_RegAddInv;
                            }
                        }
                    }

                    if (!hasFirstRegDone)
                        hasFirstRegDone = true;
                }

                //结转收益
                if (this.Input_CarryOverFreq == DateFrequency.Daily ||
                    (this.Input_CarryOverFreq == DateFrequency.Monthly && this._currentDay.Day == 1))
                {
                    this._currentCarriedOverTotal += this._currentNonCarriedOverReturns;
                    this._currentNonCarriedOverReturns = Decimal.Zero;
                }

                //生成当日年化收益率
                this._currentDayReturnsRate = GetCurrentDayReturnRate(this._currentDay, startedDays, totalDays);

                //计算当日收益
                this._currentDayReturns = this._currentCarriedOverTotal * this._currentDayReturnsRate / daysOfYear;

                //计入当日尚未分红的收益
                this._currentNonSharedOutReturns += this._currentDayReturns;

                //计入累计收益
                this._accumulativeReturns += this._currentDayReturns;

                //分红，并将收益计入未结转收益 - 待下一个结转日结转
                if (this.Input_ShareOutFreq == DateFrequency.Daily ||
                    (this.Input_ShareOutFreq == DateFrequency.Monthly && this._currentDay.Day == 1))
                {
                    this._currentNonCarriedOverReturns += this._currentNonSharedOutReturns;
                    this._currentNonSharedOutReturns = Decimal.Zero;
                }

                //计算当前总资产
                this._currentTotal = this._currentCarriedOverTotal + this._currentNonCarriedOverReturns;

                dailyStatus.CurrentCarriedOverTotal = this._currentCarriedOverTotal;
                dailyStatus.CurrentNonCarriedOverReturns = this._currentNonCarriedOverReturns;
                dailyStatus.CurrentTotal = this._currentTotal;
                dailyStatus.CurrentDayReturns = this._currentDayReturns;
                dailyStatus.CurrentDayReturnsRate = this._currentDayReturnsRate;
                dailyStatus.AccumulativeReturns = this._accumulativeReturns;
                dailyStatus.AccumulativeInvested = this._accumulativeInvested;

                //计算当日为止总平均年化收益率
                dailyStatus.CurrentAverageAnnualReturnsRate = ((this._accumulativeReturns / startedDays) * daysOfYear) / this._accumulativeInvested;
                //计算当日为止总资产较实际投入部分的增长率
                dailyStatus.CurrentTotalGrowthRate = (this._currentTotal - this._accumulativeInvested) / this._accumulativeInvested;

                if (this.Input_ReportDateFreq == DateFrequency.Daily || (this._currentDay.Day == 1))
                {
                    this._dailyStatuses.Add(dailyStatus);
                }
            }
        }

        private decimal GetCurrentDayReturnRate(DateTime date, int startedDays, int totalDays)
        {
            // 固定平均收益率
            if (this.Input_IsFixedReturn)
            {
                return this.Input_FixedAnnualReturnsRate;
            }

            // 判断亏损可能性
            if (this.Input_LossProb > Decimal.Zero)
            {
                bool isLoss = GetRandom().Next(1, 10001) > (10000 - (10000 * this.Input_LossProb));
                if (isLoss)
                {
                    // 返回负数亏损年化收益率
                    return Decimal.Zero - (((this.Input_MaxLossRate - this.Input_MinLossRate) * Convert.ToDecimal(GetRandom().NextDouble())) + this.Input_MinLossRate);
                }
            }

            if (this.Input_IsFullRandomRate) //收益率在最小和最大的范围内任何时间都整体随机
            {
                return ((this.Input_MaxAnnualReturnsRate - this.Input_MinAnnualReturnsRate) * Convert.ToDecimal(GetRandom().NextDouble())) + this.Input_MinAnnualReturnsRate;
            }
            else //整体收益率增长，小区间阶段内随机
            {
                // 根据已投资天数，从预设分隔单位区间，计算随机的浮动收益率
                var rateUnit = (this.Input_MaxAnnualReturnsRate - this.Input_MinAnnualReturnsRate) / RateDivisionCount;
                var currentPosition = Convert.ToInt32(Convert.ToDouble(RateDivisionCount) * (Convert.ToDouble(startedDays) / Convert.ToDouble(totalDays)));
                decimal currentRateRangeMin, currentRateRangeMax;
                if (currentPosition <= RateRandomOffset)
                {
                    currentRateRangeMin = this.Input_MinAnnualReturnsRate;
                    currentRateRangeMax = this.Input_MinAnnualReturnsRate + (rateUnit * RateRandomOffset * 2);
                }
                else if (currentPosition >= (RateDivisionCount - RateRandomOffset))
                {
                    currentRateRangeMin = this.Input_MaxAnnualReturnsRate - (rateUnit * RateRandomOffset * 2);
                    currentRateRangeMax = this.Input_MaxAnnualReturnsRate;
                }
                else
                {
                    var middlePositionRate = this.Input_MinAnnualReturnsRate + rateUnit * currentPosition;
                    currentRateRangeMin = middlePositionRate - (rateUnit * RateRandomOffset);
                    currentRateRangeMax = middlePositionRate + (rateUnit * RateRandomOffset);
                }
                return ((currentRateRangeMax - currentRateRangeMin) * Convert.ToDecimal(GetRandom().NextDouble())) + currentRateRangeMin;
            }
        }

        private Random GetRandom()
        {
            if (this._random == null)
            {
                DateTime date = DateTime.Now;
                _random = new Random(unchecked((int)date.Ticks));
            }
            return _random;
        }

        #endregion

        #region Form behaviors

        private void cmbAnnualReturnsMockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = this.cmbAnnualReturnsMockType.SelectedIndex == 0;

            this.Input_IsFixedReturn = flag;

            this.cmbRateRandomType.Visible = !flag;
            if (flag)
            {
                this.Width = 518;
                this.btnGenReport.Location = new Point((this.Width - this.btnGenReport.Width) / 2, this.btnGenReport.Location.Y);
            }
            else
            {
                this.Width = 600;
                this.btnGenReport.Location = new Point((this.Width - this.btnGenReport.Width) / 2, this.btnGenReport.Location.Y);
            }

            this.txtFixedAnnualReturnsRate.Enabled = flag;
            this.txtMinAnnualReturnsRate.Enabled = !flag;
            this.txtMaxAnnualReturnsRate.Enabled = !flag;
            this.txtMinLossRate.Enabled = !flag;
            this.txtMaxLossRate.Enabled = !flag;
            this.txtLossProb.Enabled = !flag;
        }

        private void cmbRateRandomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Input_IsFullRandomRate = this.cmbRateRandomType.SelectedIndex == 1;
        }

        private void OnAllTextBoxMouseClick(object sender, MouseEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (e.Button == MouseButtons.Left)
                textBox.SelectAll();
        }

        private void cmbInvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbInvType.SelectedIndex == 0)
            {
                this.Input_InvType = InvType.Once;

                this.cmbRegCycleUnit.Enabled = false;
                this.txtRegAddInv.Enabled = false;
                this.txtOnceInv.Enabled = true;
                this.cmbAdjustRegInv.Enabled = false;
                this.txtAdjustRegInv.Enabled = false;
            }
            else if (this.cmbInvType.SelectedIndex == 1)
            {
                this.Input_InvType = InvType.Regular;

                this.cmbRegCycleUnit.Enabled = true;
                this.txtRegAddInv.Enabled = true;
                this.txtOnceInv.Enabled = false;
                this.cmbAdjustRegInv.Enabled = true;
                this.txtAdjustRegInv.Enabled = true;
            }
            else if (this.cmbInvType.SelectedIndex == 2)
            {
                this.Input_InvType = InvType.OnceAndRegular;

                this.cmbRegCycleUnit.Enabled = true;
                this.txtRegAddInv.Enabled = true;
                this.txtOnceInv.Enabled = true;
                this.cmbAdjustRegInv.Enabled = true;
                this.txtAdjustRegInv.Enabled = true;
            }
            else
            {
                // Do nothing.
            }
        }

        private void cmbAdjustRegInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbAdjustRegInv.SelectedIndex == 0)
            {
                this.Input_RegInvAdjType = RegInvAdjType.None;
            }
            else if (this.cmbAdjustRegInv.SelectedIndex == 1)
            {
                this.Input_RegInvAdjType = RegInvAdjType.Yearly;
            }
            else if (this.cmbAdjustRegInv.SelectedIndex == 2)
            {
                this.Input_RegInvAdjType = RegInvAdjType.Monthly;
            }
            else
            {
                // Do nothing.
            }

            var flag = this.Input_RegInvAdjType == RegInvAdjType.None;
            this.txtAdjustRegInv.Visible = !flag;
            this.label31.Visible = !flag;
        }

        private void OnAllTextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender == this.txtRegAddInv) //定投金额
            {
                try { this.Input_RegAddInv = Convert.ToDecimal(this.txtRegAddInv.Text); } catch { this.Input_RegAddInv = -1; }
            }
            else if (sender == this.txtOnceInv) //一次性投入金额
            {
                try { this.Input_OnceInv = Convert.ToDecimal(this.txtOnceInv.Text); } catch { this.Input_OnceInv = -1; }
            }
            else if (sender == this.txtInvTime) //投入时长
            {
                try { this.Input_InvTime = Convert.ToInt32(this.txtInvTime.Text); } catch { this.Input_InvTime = -1; }
            }
            else if (sender == this.txtSevChargeRate) //手续费率
            {
                try { this.Input_SevChargeRate = Convert.ToDecimal(this.txtSevChargeRate.Text) / 100; } catch { this.Input_SevChargeRate = -1; }
            }
            else if (sender == this.txtFixedAnnualReturnsRate) //固定年化收益率
            {
                try { this.Input_FixedAnnualReturnsRate = Convert.ToDecimal(this.txtFixedAnnualReturnsRate.Text) / 100; } catch { this.Input_FixedAnnualReturnsRate = -1; }
            }
            else if (sender == this.txtMinAnnualReturnsRate) //最小年化收益率
            {
                try { this.Input_MinAnnualReturnsRate = Convert.ToDecimal(this.txtMinAnnualReturnsRate.Text) / 100; } catch { this.Input_MinAnnualReturnsRate = -1; }
            }
            else if (sender == this.txtMaxAnnualReturnsRate) //最大年化收益率
            {
                try { this.Input_MaxAnnualReturnsRate = Convert.ToDecimal(this.txtMaxAnnualReturnsRate.Text) / 100; } catch { this.Input_MaxAnnualReturnsRate = -1; }
            }
            else if (sender == this.txtMinLossRate) //最小亏损率
            {
                try { this.Input_MinLossRate = Convert.ToDecimal(this.txtMinLossRate.Text) / 100; } catch { this.Input_MinLossRate = -1; }
            }
            else if (sender == this.txtMaxLossRate) //最大亏损率
            {
                try { this.Input_MaxLossRate = Convert.ToDecimal(this.txtMaxLossRate.Text) / 100; } catch { this.Input_MaxLossRate = -1; }
            }
            else if (sender == this.txtLossProb) //亏损概率
            {
                try { this.Input_LossProb = Convert.ToDecimal(this.txtLossProb.Text) / 100; } catch { this.Input_LossProb = -1; }
            }
            else if (sender == this.txtAdjustRegInv) //定投增长额
            {
                try { this.Input_AdjustRegInv = Convert.ToDecimal(this.txtAdjustRegInv.Text); } catch { this.Input_AdjustRegInv = -1; }
            }
            else
            {
                // Nothing to do.
            }
        }

        private void btnAddInvTime_Click(object sender, EventArgs e)
        {
            if (this.Input_InvTime < 0)
            {
                this.Input_InvTime = 1;
            }
            else
            {
                this.Input_InvTime += 1;
            }
            this.txtInvTime.Text = this.Input_InvTime.ToString();
        }

        private void btnReduceInvTime_Click(object sender, EventArgs e)
        {
            if (this.Input_InvTime > 1)
            {
                this.Input_InvTime -= 1;
            }
            else
            {
                this.Input_InvTime = 1;
            }
            this.txtInvTime.Text = this.Input_InvTime.ToString();
        }

        private bool PrepareInputCheck()
        {
            try { this.Input_RegAddInv = Convert.ToDecimal(this.txtRegAddInv.Text); } catch { this.Input_RegAddInv = -1; }
            try { this.Input_AdjustRegInv = Convert.ToDecimal(this.txtAdjustRegInv.Text); } catch { this.Input_AdjustRegInv = -1; }

            if (this.Input_InvType == InvType.Once || this.Input_InvType == InvType.OnceAndRegular)
            {
                if (this.Input_OnceInv < 100)
                {
                    MessageBox.Show("一次性投入金额不能低于100元.", "输入有误");
                    return false;
                }
            }

            if (this.Input_InvType == InvType.Regular || this.Input_InvType == InvType.OnceAndRegular)
            {
                if (this.Input_RegAddInv < 100)
                {
                    MessageBox.Show("定投金额不能低于100元.", "输入有误");
                    return false;
                }

                if (this.Input_RegInvAdjType != RegInvAdjType.None)
                {
                    if (this.Input_AdjustRegInv < 100)
                    {
                        MessageBox.Show("定投增加金额不能低于100元.", "输入有误");
                        return false;
                    }
                }
            }

            if (this.Input_InvTime < 1)
            {
                MessageBox.Show("投资时长不能短于1天.", "输入有误");
                return false;
            }
            if (this.Input_SevChargeRate < 0)
            {
                MessageBox.Show("手续费率不能低于0%.", "输入有误");
                return false;
            }

            if (this.Input_IsFixedReturn)
            {
                if (this.Input_FixedAnnualReturnsRate < 0)
                {
                    MessageBox.Show("固定平均年化收益率不能低于0%.", "输入有误");
                    return false;
                }
            }
            else
            {
                if (this.Input_MinAnnualReturnsRate < 0)
                {
                    MessageBox.Show("最小年化收益率不能低于0%.", "输入有误");
                    return false;
                }
                if (this.Input_MaxAnnualReturnsRate < 0)
                {
                    MessageBox.Show("最大年化收益率不能低于0%.", "输入有误");
                    return false;
                }
                if (this.Input_MaxAnnualReturnsRate < this.Input_MinAnnualReturnsRate)
                {
                    MessageBox.Show("最大年化收益率不能低于最小年化收益率.", "输入有误");
                    return false;
                }
                if (this.Input_MinLossRate < 0)
                {
                    MessageBox.Show("最小亏损率不能低于0%.", "输入有误");
                    return false;
                }
                if (this.Input_MaxLossRate < 0)
                {
                    MessageBox.Show("最大亏损率不能低于0%.", "输入有误");
                    return false;
                }
                if (this.Input_MaxLossRate < this.Input_MinLossRate)
                {
                    MessageBox.Show("最大亏损率不能低于最小亏损率.", "输入有误");
                    return false;
                }
                if (this.Input_LossProb < 0)
                {
                    MessageBox.Show("亏损概率不能低于0%.", "输入有误");
                    return false;
                }
            }

            int flag = this.cmbRegCycleUnit.SelectedIndex;
            this.Input_RegAddDateUnit = flag == 0 ? DateUnit.Year : (flag == 1 ? DateUnit.Month : DateUnit.Day);
            flag = this.cmbInvTimeUnit.SelectedIndex;
            this.Input_InvTimeDateUnit = flag == 0 ? DateUnit.Year : (flag == 1 ? DateUnit.Month : DateUnit.Day);
            flag = this.cmbShareOutCycleUnit.SelectedIndex;
            this.Input_ShareOutFreq = flag == 0 ? DateFrequency.Daily : DateFrequency.Monthly;
            flag = this.cmbCarryOverCycleUnit.SelectedIndex;
            this.Input_CarryOverFreq = flag == 0 ? DateFrequency.Daily : DateFrequency.Monthly;
            flag = this.cmbReportDetailUnit.SelectedIndex;
            this.Input_ReportDateFreq = flag == 0 ? DateFrequency.Daily : DateFrequency.Monthly;

            this.Input_FracDigNum = Int32.Parse(this.cmbFracDigNum.SelectedItem.ToString());

            switch (this.Input_InvTimeDateUnit)
            {
                case DateUnit.Year:
                    this._endDay = this._startDay.AddYears(this.Input_InvTime);
                    break;
                case DateUnit.Month:
                    this._endDay = this._startDay.AddMonths(this.Input_InvTime);
                    break;
                case DateUnit.Day:
                    this._endDay = this._startDay.AddDays(this.Input_InvTime);
                    break;
                default:
                    break;
            }

            return true;
        }

        #endregion
    }
}
