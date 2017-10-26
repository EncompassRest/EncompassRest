using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClosingCostImpoundType
    {
        [EnumMember(Value = "Loan Amount")]
        LoanAmount = 0,
        [EnumMember(Value = "Purchase Price")]
        PurchasePrice = 1,
        [EnumMember(Value = "Appraisal Value")]
        AppraisalValue = 2,
        [EnumMember(Value = "Base Loan Amount")]
        BaseLoanAmount = 3,
        [EnumMember(Value = "As Completed Purchase Price")]
        AsCompletedPurchasePrice = 4,
        [EnumMember(Value = "As Completed Appraised Value")]
        AsCompletedAppraisedValue = 5
    }
}