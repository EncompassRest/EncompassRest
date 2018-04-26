using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OpenBankruptcy
    /// </summary>
    public enum OpenBankruptcy
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// 7
        /// </summary>
        [EnumMember(Value = "7")]
        n7 = 7,
        /// <summary>
        /// 11
        /// </summary>
        [EnumMember(Value = "11")]
        n11 = 11,
        /// <summary>
        /// 13
        /// </summary>
        [EnumMember(Value = "13")]
        n13 = 13
    }
}