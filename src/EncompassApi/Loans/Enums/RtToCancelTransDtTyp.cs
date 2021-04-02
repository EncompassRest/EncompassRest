using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RtToCancelTransDtTyp
    /// </summary>
    public enum RtToCancelTransDtTyp
    {
        /// <summary>
        /// Closing Date
        /// </summary>
        [EnumMember(Value = "Closing Date")]
        ClosingDate = 0,
        /// <summary>
        /// Document Date
        /// </summary>
        [EnumMember(Value = "Document Date")]
        DocumentDate = 1
    }
}