using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfPurchaser
    {
        [EnumMember(Value = "Loan was not originated")]
        LoanWasNotOriginated = 0,
        FNMA = 1,
        GNMA = 2,
        FHLMC = 3,
        FAMC = 4,
        [EnumMember(Value = "Private Securitization")]
        PrivateSecuritization = 5,
        [EnumMember(Value = "Savings Bank")]
        SavingsBank = 6,
        [EnumMember(Value = "Credit union, mortgage company, or finance company")]
        CreditUnionMortgageCompanyOrFinanceCompany = 7,
        [EnumMember(Value = "Life Insurance Co.")]
        LifeInsuranceCo = 8,
        [EnumMember(Value = "Affiliate Institution")]
        AffiliateInstitution = 9,
        [EnumMember(Value = "Other type of purchaser")]
        OtherTypeOfPurchaser = 10
    }
}