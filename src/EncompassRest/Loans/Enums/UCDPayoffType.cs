using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UCDPayoffType
    {
        BorrowerEstimatedTotalMonthlyLiabilityPayment = 0,
        CollectionsJudgmentsAndLiens = 1,
        DeferredStudentLoan = 2,
        DelinquentTaxes = 3,
        FirstPositionMortgageLien = 4,
        Garnishments = 5,
        HELOC = 6,
        HomeownersAssociationLien = 7,
        Installment = 8,
        LeasePayment = 9,
        MortgageLoan = 10,
        Open30DayChargeAccount = 11,
        Other = 12,
        PersonalLoan = 13,
        Revolving = 14,
        SecondPositionMortgageLien = 15,
        Taxes = 16,
        TaxLien = 17,
        ThirdPositionMortgageLien = 18,
        UnsecuredHomeImprovementLoanInstallment = 19,
        UnsecuredHomeImprovementLoanRevolving = 20
    }
}