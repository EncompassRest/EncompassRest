using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NmlsProductionSoldToType
    {
        SecondaryMarketAgency = 0,
        NonAffiliate = 1,
        Affiliate = 2,
        HeldForInvestment = 3,
        NonAgencyWithSaleTreatment = 4,
        NonAgencyWithoutSaleTreatment = 5
    }
}