using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HomeBuyersOwnershipEducationCertificateInFile
    /// </summary>
    public enum HomeBuyersOwnershipEducationCertificateInFile
    {
        /// <summary>
        /// Homeowner education completed
        /// </summary>
        [EnumMember(Value = "Homeowner education completed")]
        HomeownerEducationCompleted = 0,
        /// <summary>
        /// 1x1 counseling completed
        /// </summary>
        [EnumMember(Value = "1x1 counseling completed")]
        n1x1CounselingCompleted = 1,
        /// <summary>
        /// Both completed
        /// </summary>
        [EnumMember(Value = "Both completed")]
        BothCompleted = 2,
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 3,
        /// <summary>
        /// No
        /// </summary>
        No = 4
    }
}