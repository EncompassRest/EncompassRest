using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NmlsLoanType
    {
        ResidentialFirst = 0,
        ClosedEndSecond = 1,
        HELOC = 2,
        ReverseMortgage = 3,
        Construction = 4,
        Multifamily = 5,
        Commercial = 6,
        Other = 7
    }
}