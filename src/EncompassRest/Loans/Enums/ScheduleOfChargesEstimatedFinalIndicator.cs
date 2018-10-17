using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ScheduleOfChargesEstimatedFinalIndicator
    /// </summary>
    public enum ScheduleOfChargesEstimatedFinalIndicator
    {
        /// <summary>
        /// Estimated, subject to change
        /// </summary>
        [Description("Estimated, subject to change")]
        Estimated = 0,
        /// <summary>
        /// Final, not subject to change
        /// </summary>
        [Description("Final, not subject to change")]
        Final = 1
    }
}