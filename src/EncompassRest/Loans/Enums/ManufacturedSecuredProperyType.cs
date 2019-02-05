using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ManufacturedSecuredProperyType
    /// </summary>
    public enum ManufacturedSecuredProperyType
    {
        /// <summary>
        /// 1. Manufactured home and land
        /// </summary>
        [Description("1. Manufactured home and land")]
        [EnumMember(Value = "Manufactured home and land")]
        ManufacturedHomeAndLand = 0,
        /// <summary>
        /// 2. Manufactured home and not land
        /// </summary>
        [Description("2. Manufactured home and not land")]
        [EnumMember(Value = "Manufactured home and not land")]
        ManufacturedHomeAndNotLand = 1,
        /// <summary>
        /// 3. Not applicable
        /// </summary>
        [Description("3. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2,
        /// <summary>
        /// 1111 Partially Exempt
        /// </summary>
        [Description("1111 Partially Exempt")]
        [EnumMember(Value = "Partially Exempt")]
        PartiallyExempt = 3
    }
}