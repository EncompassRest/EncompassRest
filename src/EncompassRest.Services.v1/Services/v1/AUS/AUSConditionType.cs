using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.AUS
{
    /// <summary>
    /// AUSConditionType
    /// </summary>
    public enum AUSConditionType
    {
        /// <summary>
        /// preliminary
        /// </summary>
        [EnumMember(Value = "preliminary")]
        Preliminary = 0,
        /// <summary>
        /// underwriting
        /// </summary>
        [EnumMember(Value = "underwriting")]
        Underwriting = 1
    }
}