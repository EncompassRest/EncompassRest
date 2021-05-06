using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NmlsLienStatus
    /// </summary>
    public enum NmlsLienStatus
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
        NotSecuredByALien = 2
    }
}