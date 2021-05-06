using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocInitialRate
    /// </summary>
    public enum HelocInitialRate
    {
        /// <summary>
        /// Note Rate
        /// </summary>
        [Description("Note Rate")]
        [EnumMember(Value = "3")]
        n3 = 0,
        /// <summary>
        /// Index
        /// </summary>
        [Description("Index")]
        [EnumMember(Value = "688")]
        n688 = 1,
        /// <summary>
        /// Margin + Index
        /// </summary>
        [Description("Margin + Index")]
        [EnumMember(Value = "1827")]
        n1827 = 2,
        /// <summary>
        /// Teaser Rate
        /// </summary>
        [Description("Teaser Rate")]
        [EnumMember(Value = "1482")]
        n1482 = 3
    }
}