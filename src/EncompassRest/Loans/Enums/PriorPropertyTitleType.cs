using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PriorPropertyTitleType
    /// </summary>
    public enum PriorPropertyTitleType
    {
        /// <summary>
        /// Sole Ownership
        /// </summary>
        [Description("Sole Ownership")]
        Sole = 0,
        /// <summary>
        /// Joint With Spouse
        /// </summary>
        [Description("Joint With Spouse")]
        JointWithSpouse = 1,
        /// <summary>
        /// Joint With Other Than Spouse
        /// </summary>
        [Description("Joint With Other Than Spouse")]
        JointWithOtherThanSpouse = 2
    }
}