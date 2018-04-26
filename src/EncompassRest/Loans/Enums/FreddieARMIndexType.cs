using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieARMIndexType
    /// </summary>
    public enum FreddieARMIndexType
    {
        /// <summary>
        /// LIBOROneYearWSJDaily
        /// </summary>
        LIBOROneYearWSJDaily = 0,
        /// <summary>
        /// SixMonthLIBOR_WSJDaily
        /// </summary>
        [EnumMember(Value = "SixMonthLIBOR_WSJDaily")]
        SixMonthLIBORWSJDaily = 1,
        /// <summary>
        /// WeeklyFiveYearTreasurySecuritiesConstantMaturityFRBH15
        /// </summary>
        WeeklyFiveYearTreasurySecuritiesConstantMaturityFRBH15 = 2,
        /// <summary>
        /// WeeklyOneYearTreasurySecuritiesConstantMaturityFRBH15
        /// </summary>
        WeeklyOneYearTreasurySecuritiesConstantMaturityFRBH15 = 3,
        /// <summary>
        /// WeeklyThreeYearTreasurySecuritiesConstantMaturityFRBH15
        /// </summary>
        WeeklyThreeYearTreasurySecuritiesConstantMaturityFRBH15 = 4
    }
}