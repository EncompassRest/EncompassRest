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
        Internet = 1
    }
}