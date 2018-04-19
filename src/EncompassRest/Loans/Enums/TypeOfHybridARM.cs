using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// TypeOfHybridARM
    /// </summary>
    public enum TypeOfHybridARM
    {
        /// <summary>
        /// 3/1
        /// </summary>
        [EnumMember(Value = "3/1")]
        n31 = 31,
        /// <summary>
        /// 5/1
        /// </summary>
        [EnumMember(Value = "5/1")]
        n51 = 51,
        /// <summary>
        /// 7/1
        /// </summary>
        [EnumMember(Value = "7/1")]
        n71 = 71,
        /// <summary>
        /// 10/1
        /// </summary>
        [EnumMember(Value = "10/1")]
        n101 = 101
    }
}