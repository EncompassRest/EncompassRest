using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanLinkSyncType
    {
        None = 0,
        ConstructionPrimary = 1,
        ConstructionLinked = 2,
        PiggybackPrimary = 3,
        PiggybackLinked = 4
    }
}