namespace EncompassRest.EFolder
{
    /// <summary>
    /// Status of the export job.
    /// </summary>
    public enum ExportStatus
    {
        /// <summary>
        /// Queued
        /// </summary>
        Queued = 0,
        /// <summary>
        /// Running
        /// </summary>
        Running = 1,
        /// <summary>
        /// Retrying
        /// </summary>
        Retrying = 2,
        /// <summary>
        /// Success
        /// </summary>
        Success = 3,
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 4
    }
}
