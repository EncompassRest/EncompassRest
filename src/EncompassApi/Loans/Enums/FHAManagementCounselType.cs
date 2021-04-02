using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FHAManagementCounselType
    /// </summary>
    public enum FHAManagementCounselType
    {
        /// <summary>
        /// Not Counseled
        /// </summary>
        [EnumMember(Value = "Not Counseled")]
        NotCounseled = 0,
        /// <summary>
        /// HUD Approved Counseling Agency
        /// </summary>
        [EnumMember(Value = "HUD Approved Counseling Agency")]
        HUDApprovedCounselingAgency = 1
    }
}