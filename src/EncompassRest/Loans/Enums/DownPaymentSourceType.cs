using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DownPaymentSourceType
    {
        Borrower = 0,
        CommunityNonProfit = 1,
        Employer = 2,
        FederalAgency = 3,
        LocalAgency = 4,
        Other = 5,
        Relative = 6,
        ReligiousNonProfit = 7,
        StateAgency = 8
    }
}