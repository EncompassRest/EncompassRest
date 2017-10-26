using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DenialReason
    {
        [EnumMember(Value = "Debt to Income Ratio")]
        DebtToIncomeRatio = 0,
        [EnumMember(Value = "Employment history")]
        EmploymentHistory = 1,
        [EnumMember(Value = "Credit history")]
        CreditHistory = 2,
        Collateral = 3,
        [EnumMember(Value = "Insufficient Cash")]
        InsufficientCash = 4,
        [EnumMember(Value = "Unverifiable Information")]
        UnverifiableInformation = 5,
        [EnumMember(Value = "Credit application Incomplete")]
        CreditApplicationIncomplete = 6,
        [EnumMember(Value = "Mortgage insurance denied")]
        MortgageInsuranceDenied = 7,
        Other = 8,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 9
    }
}