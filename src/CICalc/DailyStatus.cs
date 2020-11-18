using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CICalc
{
    public class DailyStatus
    {
        public DateTime Date { get; set; } //日期
        public decimal CurrentCarriedOverTotal { get; set; } //当前已结转资产
        public decimal CurrentNonCarriedOverReturns { get; set; } //当前未结转收益
        public decimal CurrentDayReturns { get; set; } //当日收益
        public decimal CurrentDayReturnsRate { get; set; } //当日年化收益率
        public decimal AccumulativeReturns { get; set; } //累计收益
        public decimal AccumulativeInvested { get; set; } //累计投入
        public decimal CurrentAverageAnnualReturnsRate { get; set; } //总平均年化收益率
        public decimal CurrentTotalGrowthRate { get; set; } //总资产较实际投入部分增长率
        public decimal CurrentTotal { get; set; } //当前总资产
    }

    public enum DateUnit
    {
        Year,
        Month,
        Day
    }

    public enum DateFrequency
    {
        Monthly,
        Daily
    }

    public enum InvType
    {
        Once,
        Regular,
        OnceAndRegular
    }

    public enum RegInvAdjType
    {
        None,
        Yearly,
        Monthly
    }

    public enum ChartDataType
    {
        All,
        DailyAnnualReturnsRate,
        DailyAvgAnnualReturnsRate,
        TotalGrowthRate
    }
}
