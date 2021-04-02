using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// GinnieConstructionMethodType
    /// </summary>
    public enum GinnieConstructionMethodType
    {
        /// <summary>
        /// Manufactured
        /// </summary>
        Manufactured = 0,
        /// <summary>
        /// Site Built
        /// </summary>
        [EnumMember(Value = "Site Built")]
        SiteBuilt = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}