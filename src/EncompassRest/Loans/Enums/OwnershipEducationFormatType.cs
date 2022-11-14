using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OwnershipEducationFormatType
    /// </summary>
    public enum OwnershipEducationFormatType
    {
        /// <summary>
        /// Attended Workshop In Person
        /// </summary>
        [Description("Attended Workshop In Person")]
        InPerson = 0,
        /// <summary>
        /// Completed Web-Based Workshop
        /// </summary>
        [Description("Completed Web-Based Workshop")]
        WebBased = 1
    }
}