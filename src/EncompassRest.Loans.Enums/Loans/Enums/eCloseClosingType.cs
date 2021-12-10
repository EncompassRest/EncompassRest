using System.ComponentModel;

namespace EncompassRest.Loans.Enums
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
        /// Hybrid With eNote
        /// </summary>
        [Description("Hybrid With eNote")]
        HybridWithENote = 2,
        /// <summary>
        /// eSign Only
        /// </summary>
        [Description("eSign Only")]
        ESignOnly = 3
    }
}