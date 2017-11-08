using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PropertyValuationMethodType
    {
        AutomatedValuationModel = 0,
        DesktopAppraisal = 1,
        DriveBy = 2,
        Estimation = 3,
        FieldReview = 4,
        FullAppraisal = 5,
        None = 6,
        Other = 7,
        PriorAppraisalUsed = 8
    }
}