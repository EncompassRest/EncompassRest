using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ApplicationTakenMethodType
    /// </summary>
    public enum ApplicationTakenMethodType
    {
        /// <summary>
        /// Face-to-Face Interview (includes Electronic Media with Video Component)
        /// </summary>
        [Description("Face-to-Face Interview (includes Electronic Media with Video Component)")]
        FaceToFace = 0,
        /// <summary>
        /// Email or Internet
        /// </summary>
        [Description("Email or Internet")]
        Internet = 1,
        /// <summary>
        /// Fax or Mail
        /// </summary>
        [Description("Fax or Mail")]
        Mail = 2,
        /// <summary>
        /// Telephone Interview
        /// </summary>
        [Description("Telephone Interview")]
        Telephone = 3
    }
}