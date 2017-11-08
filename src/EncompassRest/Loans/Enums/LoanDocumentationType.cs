using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanDocumentationType
    {
        Alternative = 0,
        FullDocumentation = 1,
        Reduced = 2,
        StreamlineRefinance = 3,
        NoDocumentation = 4,
        NoRatio = 5,
        LimitedDocumentation = 6,
        NoIncomeNoEmploymentNoAssetsOn1003 = 7,
        NoDepositVerificationEmploymentVerificationOrIncomeVerification = 8,
        NoDepositVerification = 9,
        NoEmploymentVerificationOrIncomeVerification = 10,
        NoIncomeOn1003 = 11,
        NoVerificationOfStatedIncomeEmploymentOrAssets = 12,
        NoVerificationOfStatedIncomeOrAssets = 13,
        NoVerificationOfStatedAssets = 14,
        NoVerificationOfStatedIncomeOrEmployment = 15,
        NoVerificationOfStatedIncome = 16,
        VerbalVerificationOfEmployment = 17,
        OnePaystub = 18,
        OnePaystubAndVerbalVerificationOfEmployment = 19,
        OnePaystubAndOneW2AndVerbalVerificationOfEmploymentOrOneYear1040 = 20
    }
}