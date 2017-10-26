using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RtToCancelTransDtTyp
    {
        [EnumMember(Value = "Closing Date")]
        ClosingDate = 0,
        [EnumMember(Value = "Document Date")]
        DocumentDate = 1
    }
}