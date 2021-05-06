using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ImpoundType3
    /// </summary>
    public enum ImpoundType3
    {
        /// <summary>
        /// Loan Amount
        /// </summary>
        [EnumMember(Value = "Loan Amount")]
        LoanAmount = 0,
        /// <summary>
        /// Purchase Price
        /// </summary>
        [EnumMember(Value = "Purchase Price")]
        PurchasePrice = 1,
        /// <summary>
        /// Appraisal Value
        /// </summary>
        [EnumMember(Value = "Appraisal Value")]
        AppraisalValue = 2,
        /// <summary>
        /// Base Loan Amount
        /// </summary>
        [EnumMember(Value = "Base Loan Amount")]
        BaseLoanAmount = 3
    }
}