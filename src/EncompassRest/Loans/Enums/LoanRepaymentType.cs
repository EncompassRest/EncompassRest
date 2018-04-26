using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanRepaymentType
    /// </summary>
    public enum LoanRepaymentType
    {
        /// <summary>
        /// No Negative Amortization
        /// </summary>
        [Description("No Negative Amortization")]
        NoNegativeAmortization = 0,
        /// <summary>
        /// Scheduled Amortization
        /// </summary>
        [Description("Scheduled Amortization")]
        ScheduledAmortization = 1,
        /// <summary>
        /// Interest Only
        /// </summary>
        [Description("Interest Only")]
        InterestOnly = 2,
        /// <summary>
        /// Possible Negative Amortization
        /// </summary>
        [Description("Possible Negative Amortization")]
        PossibleNegativeAmortization = 3,
        /// <summary>
        /// Scheduled Negative Amortization
        /// </summary>
        [Description("Scheduled Negative Amortization")]
        ScheduledNegativeAmortization = 4
    }
}