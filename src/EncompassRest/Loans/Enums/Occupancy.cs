using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Occupancy
    {
        ActuallyOccupyPropertyAsMyHome = 0,
        ActuallyOccupyPropertyWithin60DaysContinueAtLeast1Year = 1,
        DoNotIntendToOccupyPropertyAsMyHome = 2,
        SpouseOnActiveMilitaryDuty = 3,
        VeteranOnActiveMilitaryDuty = 4,
        PreviouslyOccupiedTheProperty = 5,
        PreviouslyOccupiedWhileSpouseOnActiveMilitaryDuty = 6,
        PreviouslyDependentOccupiedWhileVeteranOnActiveMilitaryDuty = 7
    }
}