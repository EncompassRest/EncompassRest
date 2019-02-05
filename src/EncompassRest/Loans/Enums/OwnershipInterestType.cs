using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OwnershipInterestType
    /// </summary>
    public enum OwnershipInterestType
    {
        /// <summary>
        /// I have an ownership share of less 25%
        /// </summary>
        [Description("I have an ownership share of less 25%")]
        GreaterThanOrEqualTo25Percent = 0,
        /// <summary>
        /// I have an ownership share of 25% or more
        /// </summary>
        [Description("I have an ownership share of 25% or more")]
        LessThan25Percent = 1
    }
}