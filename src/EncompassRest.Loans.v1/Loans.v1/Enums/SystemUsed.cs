using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// SystemUsed
    /// </summary>
    public enum SystemUsed
    {
        /// <summary>
        /// LP
        /// </summary>
        [Description("LP")]
        [EnumMember(Value = "01")]
        n01 = 1,
        /// <summary>
        /// DU
        /// </summary>
        [Description("DU")]
        [EnumMember(Value = "02")]
        n02 = 2,
        /// <summary>
        /// PMI AURA
        /// </summary>
        [Description("PMI AURA")]
        [EnumMember(Value = "03")]
        n03 = 3,
        /// <summary>
        /// CLUES
        /// </summary>
        [Description("CLUES")]
        [EnumMember(Value = "04")]
        n04 = 4,
        /// <summary>
        /// ZIPPY
        /// </summary>
        [Description("ZIPPY")]
        [EnumMember(Value = "05")]
        n05 = 5
    }
}