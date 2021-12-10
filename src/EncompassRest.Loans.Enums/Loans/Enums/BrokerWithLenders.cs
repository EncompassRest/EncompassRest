using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BrokerWithLenders
    /// </summary>
    public enum BrokerWithLenders
    {
        /// <summary>
        /// Only one
        /// </summary>
        [Description("Only one")]
        [EnumMember(Value = "Only One")]
        OnlyOne = 1,
        /// <summary>
        /// 3 or fewer
        /// </summary>
        [Description("3 or fewer")]
        [EnumMember(Value = "3 or Fewer")]
        n3OrFewer = 3,
        /// <summary>
        /// More than 3
        /// </summary>
        [Description("More than 3")]
        [EnumMember(Value = "More Than 3")]
        MoreThan3 = 4
    }
}