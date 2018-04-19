using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SectionOfActType
    /// </summary>
    public enum SectionOfActType
    {
        /// <summary>
        /// 184
        /// </summary>
        [EnumMember(Value = "184")]
        n184 = 0,
        /// <summary>
        /// 203B
        /// </summary>
        [EnumMember(Value = "203B")]
        n203B = 1,
        /// <summary>
        /// 203B251
        /// </summary>
        [EnumMember(Value = "203B251")]
        n203B251 = 2,
        /// <summary>
        /// 203B2
        /// </summary>
        [EnumMember(Value = "203B2")]
        n203B2 = 3,
        /// <summary>
        /// 203K
        /// </summary>
        [EnumMember(Value = "203K")]
        n203K = 4,
        /// <summary>
        /// 203K251
        /// </summary>
        [EnumMember(Value = "203K251")]
        n203K251 = 5,
        /// <summary>
        /// 221D2
        /// </summary>
        [EnumMember(Value = "221D2")]
        n221D2 = 6,
        /// <summary>
        /// 221D2251
        /// </summary>
        [EnumMember(Value = "221D2251")]
        n221D2251 = 7,
        /// <summary>
        /// 234C
        /// </summary>
        [EnumMember(Value = "234C")]
        n234C = 8,
        /// <summary>
        /// 234C251
        /// </summary>
        [EnumMember(Value = "234C251")]
        n234C251 = 9,
        /// <summary>
        /// 257
        /// </summary>
        [EnumMember(Value = "257")]
        n257 = 10,
        /// <summary>
        /// 203H
        /// </summary>
        [Description("203H")]
        [EnumMember(Value = "203")]
        n203 = 11
    }
}