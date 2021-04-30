using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RenewalType
    /// </summary>
    public enum RenewalType
    {
        /// <summary>
        /// Guaranteed
        /// </summary>
        Guaranteed = 0,
        /// <summary>
        /// Variable
        /// </summary>
        Variable = 1,
        /// <summary>
        /// Not Applicable
        /// </summary>
        [EnumMember(Value = "Not Applicable")]
        NotApplicable = 2
    }
}