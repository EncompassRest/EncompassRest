using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HomeBuyersOwnershipEducationCertificateInFile
    {
        [EnumMember(Value = "Homeowner education completed")]
        HomeownerEducationCompleted = 0,
        [EnumMember(Value = "1x1 counseling completed")]
        n1x1CounselingCompleted = 1,
        [EnumMember(Value = "Both completed")]
        BothCompleted = 2,
        Yes = 3,
        No = 4
    }
}