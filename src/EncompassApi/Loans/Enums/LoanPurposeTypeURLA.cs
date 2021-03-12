using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LoanPurposeTypeURLA
    /// </summary>
    public enum LoanPurposeTypeURLA
    {
        /// <summary>
        /// Purchase
        /// </summary>
        Purchase = 0,
        /// <summary>
        /// Cash-Out Refi
        /// </summary>
        [EnumMember(Value = "Cash-Out Refi")]
        CashOutRefi = 1,
        /// <summary>
        /// No Cash-Out Refi
        /// </summary>
        [EnumMember(Value = "No Cash-Out Refi")]
        NoCashOutRefi = 2,
        /// <summary>
        /// Construction
        /// </summary>
        Construction = 3,
        /// <summary>
        /// Construction-Perm
        /// </summary>
        [EnumMember(Value = "Construction-Perm")]
        ConstructionPerm = 4,
        /// <summary>
        /// Other
        /// </summary>
        Other = 5,
        /// <summary>
        /// Refinance
        /// </summary>
        Refinance = 6
    }
}