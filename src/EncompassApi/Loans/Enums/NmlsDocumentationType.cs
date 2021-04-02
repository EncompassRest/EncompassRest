using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// NmlsDocumentationType
    /// </summary>
    public enum NmlsDocumentationType
    {
        /// <summary>
        /// Full Documentation
        /// </summary>
        [Description("Full Documentation")]
        Full = 0,
        /// <summary>
        /// Alt Documentation
        /// </summary>
        [Description("Alt Documentation")]
        Alt = 1
    }
}