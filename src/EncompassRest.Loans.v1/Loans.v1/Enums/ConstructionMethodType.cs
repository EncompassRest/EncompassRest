using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ConstructionMethodType
    /// </summary>
    public enum ConstructionMethodType
    {
        /// <summary>
        /// 1. Site-built
        /// </summary>
        [Description("1. Site-built")]
        [EnumMember(Value = "Site Built")]
        SiteBuilt = 0,
        /// <summary>
        /// 2. Manufactured Home
        /// </summary>
        [Description("2. Manufactured Home")]
        Manufactured = 1
    }
}