using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DispositionStatusType
    /// </summary>
    public enum DispositionStatusType
    {
        /// <summary>
        /// S
        /// </summary>
        [Description("S")]
        Sold = 0,
        /// <summary>
        /// PS
        /// </summary>
        [Description("PS")]
        PendingSale = 1,
        /// <summary>
        /// R
        /// </summary>
        [Description("R")]
        RetainForRental = 2,
        /// <summary>
        /// H
        /// </summary>
        [Description("H")]
        RetainForPrimaryOrSecondaryResidence = 3
    }
}