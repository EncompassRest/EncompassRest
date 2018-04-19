using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// VABenefitRelatedIndebtedness
    /// </summary>
    public enum VABenefitRelatedIndebtedness
    {
        /// <summary>
        /// DO NOT
        /// </summary>
        [Description("DO NOT")]
        [EnumMember(Value = "Do Not")]
        DoNot = 0,
        /// <summary>
        /// DO
        /// </summary>
        [Description("DO")]
        Do = 1
    }
}