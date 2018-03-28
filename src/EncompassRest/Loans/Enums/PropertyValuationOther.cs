using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PropertyValuationOther
    {
        [EnumMember(Value = "Desk Review")]
        DeskReview = 0,
        [EnumMember(Value = "Field Review")]
        FieldReview = 1
    }
}