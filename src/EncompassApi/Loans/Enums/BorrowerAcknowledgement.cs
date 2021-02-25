using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// BorrowerAcknowledgement
    /// </summary>
    public enum BorrowerAcknowledgement
    {
        /// <summary>
        /// Pay the net interest income directly to me / us
        /// </summary>
        [Description("Pay the net interest income directly to me / us")]
        PayNetInterest = 0,
        /// <summary>
        /// Apply the net interest income directly to the mortgage principal
        /// </summary>
        [Description("Apply the net interest income directly to the mortgage principal")]
        ApplyNetInterest = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}