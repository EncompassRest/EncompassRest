using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ClosingCostSourceType
    {
        Borrower = 0,
        CommunityNonProfit = 1,
        Employer = 2,
        FederalAgency = 3,
        Lender = 4,
        LocalAgency = 5,
        Other = 6,
        PropertySeller = 7,
        Relative = 8,
        ReligiousNonProfit = 9,
        StateAgency = 10
    }
}