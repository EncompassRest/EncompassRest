using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PrimaryMIAbsenceReasonType
    {
        MICanceledBasedOnCurrentLTV = 0,
        NoMIBasedOnOriginalLTV = 1,
        Other = 2
    }
}