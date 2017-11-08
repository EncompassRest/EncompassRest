using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanType
    {
        Conventional = 0,
        VA = 1,
        FHA = 2,
        Other = 3,
        FarmersHomeAdministration = 4,
        HELOC = 5
    }
}