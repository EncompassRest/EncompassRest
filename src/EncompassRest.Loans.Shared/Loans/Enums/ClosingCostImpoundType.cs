using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// ClosingCostImpoundType
/// </summary>
public enum ClosingCostImpoundType
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
    BaseLoanAmount = 3,
    /// <summary>
    /// As Completed Purchase Price
    /// </summary>
    [EnumMember(Value = "As Completed Purchase Price")]
    AsCompletedPurchasePrice = 4,
    /// <summary>
    /// As Completed Appraised Value
    /// </summary>
    [EnumMember(Value = "As Completed Appraised Value")]
    AsCompletedAppraisedValue = 5
}