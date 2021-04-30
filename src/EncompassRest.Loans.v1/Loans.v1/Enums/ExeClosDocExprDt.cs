using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ExeClosDocExprDt
    /// </summary>
    public enum ExeClosDocExprDt
    {
        /// <summary>
        /// Funding Date
        /// </summary>
        [EnumMember(Value = "Funding Date")]
        FundingDate = 0,
        /// <summary>
        /// Closing Date
        /// </summary>
        [EnumMember(Value = "Closing Date")]
        ClosingDate = 1
    }
}