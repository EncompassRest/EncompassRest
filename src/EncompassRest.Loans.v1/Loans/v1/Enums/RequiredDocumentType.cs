using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RequiredDocumentType
    /// </summary>
    public enum RequiredDocumentType
    {
        /// <summary>
        /// No DV
        /// </summary>
        [Description("No DV")]
        B = 0,
        /// <summary>
        /// No EV or IV
        /// </summary>
        [Description("No EV or IV")]
        C = 1,
        /// <summary>
        /// No DV, EV or IV
        /// </summary>
        [Description("No DV, EV or IV")]
        E = 2,
        /// <summary>
        /// Full documentation
        /// </summary>
        [Description("Full documentation")]
        Z = 3
    }
}