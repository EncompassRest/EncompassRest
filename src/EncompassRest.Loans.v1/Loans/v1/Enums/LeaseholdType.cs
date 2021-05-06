using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LeaseholdType
    /// </summary>
    public enum LeaseholdType
    {
        /// <summary>
        /// Renewable
        /// </summary>
        Renewable = 0,
        /// <summary>
        /// HUD/VA approved
        /// </summary>
        [EnumMember(Value = "HUD/VA approved")]
        HUDVAApproved = 1,
        /// <summary>
        /// 99 Years
        /// </summary>
        [EnumMember(Value = "99 Years")]
        n99Years = 99
    }
}