using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PropertyRightsType
    /// </summary>
    public enum PropertyRightsType
    {
        /// <summary>
        /// Fee Simple
        /// </summary>
        [Description("Fee Simple")]
        FeeSimple = 0,
        /// <summary>
        /// Leasehold
        /// </summary>
        Leasehold = 1
    }
}