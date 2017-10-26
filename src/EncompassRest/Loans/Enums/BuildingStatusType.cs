using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BuildingStatusType
    {
        Existing = 0,
        Proposed = 1,
        SubjectToAlterationImprovementRepairAndRehabilitation = 2,
        SubstantiallyRehabilitated = 3,
        UnderConstruction = 4
    }
}