using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ImpoundType3
    {
        [EnumMember(Value = "Loan Amount")]
        LoanAmount = 0,
        [EnumMember(Value = "Purchase Price")]
        PurchasePrice = 1,
        [EnumMember(Value = "Appraisal Value")]
        AppraisalValue = 2,
        [EnumMember(Value = "Base Loan Amount")]
        BaseLoanAmount = 3
    }
}