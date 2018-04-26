using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PrimaryMIAbsenceReasonType
    /// </summary>
    public enum PrimaryMIAbsenceReasonType
    {
        /// <summary>
        /// MI Canceled Based On Current LTV
        /// </summary>
        [Description("MI Canceled Based On Current LTV")]
        MICanceledBasedOnCurrentLTV = 0,
        /// <summary>
        /// No MI Based On Original LTV
        /// </summary>
        [Description("No MI Based On Original LTV")]
        NoMIBasedOnOriginalLTV = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}