using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// BusinessOrCommercialPurpose
    /// </summary>
    public enum BusinessOrCommercialPurpose
    {
        /// <summary>
        /// 1. Primarily for a business or commercial purpose
        /// </summary>
        [Description("1. Primarily for a business or commercial purpose")]
        [EnumMember(Value = "Primarily for a business or commercial purpose")]
        PrimarilyForABusinessOrCommercialPurpose = 0,
        /// <summary>
        /// 2. Not primarily for a business or commercial purpose
        /// </summary>
        [Description("2. Not primarily for a business or commercial purpose")]
        [EnumMember(Value = "Not primarily for a business or commercial purpose")]
        NotPrimarilyForABusinessOrCommercialPurpose = 1,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 2
    }
}