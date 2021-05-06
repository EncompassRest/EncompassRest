using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ConformingJumbo
    /// </summary>
    public enum ConformingJumbo
    {
        /// <summary>
        /// Conforming
        /// </summary>
        Conforming = 0,
        /// <summary>
        /// Non-Conforming (Jumbo)
        /// </summary>
        [Description("Non-Conforming (Jumbo)")]
        Jumbo = 1
    }
}