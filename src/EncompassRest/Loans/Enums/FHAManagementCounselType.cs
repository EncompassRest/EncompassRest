using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FHAManagementCounselType
    {
        [EnumMember(Value = "Not Counseled")]
        NotCounseled = 0,
        [EnumMember(Value = "HUD Approved Counseling Agency")]
        HUDApprovedCounselingAgency = 1
    }
}