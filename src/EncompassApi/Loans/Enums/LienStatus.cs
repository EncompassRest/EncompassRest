using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LienStatus
    /// </summary>
    public enum LienStatus
    {
        /// <summary>
        /// 1. Secured by a first lien
        /// </summary>
        [Description("1. Secured by a first lien")]
        [EnumMember(Value = "Secured by a first lien")]
        SecuredByAFirstLien = 0,
        /// <summary>
        /// 2. Secured by a subordinate lien
        /// </summary>
        [Description("2. Secured by a subordinate lien")]
        [EnumMember(Value = "Secured by a subordinate lien")]
        SecuredByASubordinateLien = 1,
        /// <summary>
        /// 3. Not secured by a lien
        /// </summary>
        [Description("3. Not secured by a lien")]
        [EnumMember(Value = "Not secured by a lien")]
        NotSecuredByALien = 2,
        /// <summary>
        /// 4. Not applicable
        /// </summary>
        [Description("4. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 3
    }
}