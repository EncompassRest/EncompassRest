using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LeaseholdType
    {
        Renewable = 0,
        [EnumMember(Value = "HUD/VA approved")]
        HUDVAApproved = 1,
        [EnumMember(Value = "99 Years")]
        n99Years = 99
    }
}