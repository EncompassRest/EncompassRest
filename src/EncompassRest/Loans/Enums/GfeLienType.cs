using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GfeLienType
    {
        Undefined = 0,
        [EnumMember(Value = "BORROWER_LIENS")]
        BORROWERLIENS = 1,
        [EnumMember(Value = "PROPERTY_LIENS")]
        PROPERTYLIENS = 2
    }
}