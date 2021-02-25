using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// HelocTAOverLimitChargeOption
    /// </summary>
    public enum HelocTAOverLimitChargeOption
    {
        /// <summary>
        /// for each Advance in excess of your Credit Limit
        /// </summary>
        [EnumMember(Value = "for each Advance in excess of your Credit Limit")]
        ForEachAdvanceInExcessOfYourCreditLimit = 0,
        /// <summary>
        /// for each Monthly Statement Period in which your unpaid balance exceeds your Credit Limit at any time
        /// </summary>
        [EnumMember(Value = "for each Monthly Statement Period in which your unpaid balance exceeds your Credit Limit at any time")]
        ForEachMonthlyStatementPeriodInWhichYourUnpaidBalanceExceedsYourCreditLimitAtAnyTime = 1
    }
}