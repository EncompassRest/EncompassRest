using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocRate
    /// </summary>
    public enum HelocRate
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
        n688 = 1
    }
}