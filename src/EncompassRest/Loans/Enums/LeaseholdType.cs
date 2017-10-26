using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LeaseholdType
    {
        [EnumMember(Value = "99 Years")]
        n99Years = 0,
        Renewable = 1,
        [EnumMember(Value = "HUD/VA approved")]
        HUDVAApproved = 2
    }
}