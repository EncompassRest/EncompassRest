using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// AssumptionOnYourProperty
    /// </summary>
    public enum AssumptionOnYourProperty
    {
        /// <summary>
        /// may (only for RESPA 2010)
        /// </summary>
        [Description("may (only for RESPA 2010)")]
        May = 0,
        /// <summary>
        /// may not
        /// </summary>
        [Description("may not")]
        [EnumMember(Value = "May_not")]
        MayNot = 1,
        /// <summary>
        /// may, subject to conditions
        /// </summary>
        [Description("may, subject to conditions")]
        [EnumMember(Value = "May_SubjectToConditions")]
        MaySubjectToConditions = 2
    }
}