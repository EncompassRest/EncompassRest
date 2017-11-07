using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LiabilityType
    {
        ChildCare = 0,
        ChildSupport = 1,
        CollectionsJudgementsAndLiens = 2,
        HELOC = 3,
        Installment = 4,
        LeasePayments = 5,
        MortgageLoan = 6,
        Open30DayChargeAccount = 7,
        OtherLiability = 8,
        Revolving = 9,
        SeparateMaintenanceExpense = 10,
        OtherExpense = 11,
        Taxes = 12
    }
}