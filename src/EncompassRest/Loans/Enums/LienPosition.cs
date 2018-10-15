using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LienPosition
    /// </summary>
    public enum LienPosition
    {
        /// <summary>
        /// 1
        /// </summary>
        [EnumMember(Value = "1")]
        n1 = 0,
        /// <summary>
        /// 2
        /// </summary>
        [EnumMember(Value = "2")]
        n2 = 1,
        /// <summary>
        /// 3
        /// </summary>
        [EnumMember(Value = "3")]
        n3 = 2,
        /// <summary>
        /// 4
        /// </summary>
        [EnumMember(Value = "4")]
        n4 = 3
    }
}