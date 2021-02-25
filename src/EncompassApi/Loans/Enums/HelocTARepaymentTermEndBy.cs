using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// HelocTARepaymentTermEndBy
    /// </summary>
    public enum HelocTARepaymentTermEndBy
    {
        /// <summary>
        /// the scheduled end of the repayment period
        /// </summary>
        [EnumMember(Value = "the scheduled end of the repayment period")]
        TheScheduledEndOfTheRepaymentPeriod = 0,
        /// <summary>
        /// the end of the draw period
        /// </summary>
        [EnumMember(Value = "the end of the draw period")]
        TheEndOfTheDrawPeriod = 1,
        /// <summary>
        /// one month after the end of the draw period
        /// </summary>
        [EnumMember(Value = "one month after the end of the draw period")]
        OneMonthAfterTheEndOfTheDrawPeriod = 2
    }
}