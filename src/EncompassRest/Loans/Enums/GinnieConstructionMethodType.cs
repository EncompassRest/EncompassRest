using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
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