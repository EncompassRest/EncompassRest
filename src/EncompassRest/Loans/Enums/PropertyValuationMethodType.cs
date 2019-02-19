using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PropertyValuationMethodType
    /// </summary>
    public enum PropertyValuationMethodType
    {
        /// <summary>
        /// Automated Valuation Model
        /// </summary>
        [Description("Automated Valuation Model")]
        AutomatedValuationModel = 0,
        /// <summary>
        /// Desktop Appraisal
        /// </summary>
        [Description("Desktop Appraisal")]
        DesktopAppraisal = 1,
        /// <summary>
        /// Drive By
        /// </summary>
        [Description("Drive By")]
        DriveBy = 2,
        /// <summary>
        /// Estimation
        /// </summary>
        Estimation = 3,
        /// <summary>
        /// Full Appraisal
        /// </summary>
        [Description("Full Appraisal")]
        FullAppraisal = 5,
        /// <summary>
        /// None
        /// </summary>
        None = 6,
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
        /// <summary>
        /// Prior Appraisal Used
        /// </summary>
        [Description("Prior Appraisal Used")]
        PriorAppraisalUsed = 8
    }
}