using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocTADailyBalanceType
    /// </summary>
    public enum HelocTADailyBalanceType
    {
        /// <summary>
        /// daily balance (including current transactions)
        /// </summary>
        [EnumMember(Value = "daily balance (including current transactions)")]
        DailyBalanceIncludingCurrentTransactions = 0,
        /// <summary>
        /// daily  balance (excluding current transactions)
        /// </summary>
        [EnumMember(Value = "daily  balance (excluding current transactions)")]
        DailyBalanceExcludingCurrentTransactions = 1,
        /// <summary>
        /// average daily balance (including current transactions)
        /// </summary>
        [EnumMember(Value = "average daily balance (including current transactions)")]
        AverageDailyBalanceIncludingCurrentTransactions = 2,
        /// <summary>
        /// average daily balance (excluding current transactions)
        /// </summary>
        [EnumMember(Value = "average daily balance (excluding current transactions)")]
        AverageDailyBalanceExcludingCurrentTransactions = 3
    }
}