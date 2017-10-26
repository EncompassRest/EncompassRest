using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DiscountType
    {
        BelowNoteRate = 0,
        [EnumMember(Value = "ofThePayment")]
        OfThePayment = 1
    }
}