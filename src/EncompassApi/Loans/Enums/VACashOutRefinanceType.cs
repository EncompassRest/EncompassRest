using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// VACashOutRefinanceType
    /// </summary>
    public enum VACashOutRefinanceType
    {
        /// <summary>
        /// TYPE I Cash-Out Refinance
        /// </summary>
        [Description("TYPE I Cash-Out Refinance")]
        [EnumMember(Value = "Type I Cash-Out Refinance")]
        TypeICashOutRefinance = 0,
        /// <summary>
        /// TYPE II Cash-Out Refinance
        /// </summary>
        [Description("TYPE II Cash-Out Refinance")]
        [EnumMember(Value = "Type II Cash-Out Refinance")]
        TypeIICashOutRefinance = 1
    }
}