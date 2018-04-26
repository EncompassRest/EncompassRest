using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ReverseMortgage
    /// </summary>
    public enum ReverseMortgage
    {
        /// <summary>
        /// 1. Reverse mortgage
        /// </summary>
        [Description("1. Reverse mortgage")]
        [EnumMember(Value = "Reverse mortgage")]
        ReverseMortgage = 0,
        /// <summary>
        /// 2. Not a reverse mortgage
        /// </summary>
        [Description("2. Not a reverse mortgage")]
        [EnumMember(Value = "Not a reverse mortgage")]
        NotAReverseMortgage = 1
    }
}