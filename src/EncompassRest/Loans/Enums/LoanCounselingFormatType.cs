using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanCounselingFormatType
    /// </summary>
    public enum LoanCounselingFormatType
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
        /// Telephone
        /// </summary>
        Telephone = 2
    }
}