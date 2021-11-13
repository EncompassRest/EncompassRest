using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// eCloseClosingType
    /// </summary>
    public enum eCloseClosingType
    {
        /// <summary>
        /// Ink Only
        /// </summary>
        [Description("Ink Only")]
        InkOnly = 0,
        /// <summary>
        /// Hybrid
        /// </summary>
        Hybrid = 1,
        /// <summary>
        /// Hybrid With ENote
        /// </summary>
        [Description("Hybrid With ENote")]
        HybridWithENote = 2,
        /// <summary>
        /// ESign Only
        /// </summary>
        [Description("ESign Only")]
        ESignOnly = 3
    }
}