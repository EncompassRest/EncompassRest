using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OwnershipFormatType
    /// </summary>
    public enum OwnershipFormatType
    {
        /// <summary>
        /// Face To Face
        /// </summary>
        [Description("Face To Face")]
        FaceToFace = 0,
        /// <summary>
        /// Internet
        /// </summary>
        Internet = 1,
        /// <summary>
        /// Attended Workshop In Person
        /// </summary>
        [Description("Attended Workshop In Person")]
        InPerson = 2,
        /// <summary>
        /// Completed Web-Based Workshop
        /// </summary>
        [Description("Completed Web-Based Workshop")]
        WebBased = 3,
        /// <summary>
        /// Telephone
        /// </summary>
        Telephone = 4
    }
}