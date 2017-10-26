using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FHAStreamlineType
    {
        [EnumMember(Value = "Credit Qualifying")]
        CreditQualifying = 0,
        [EnumMember(Value = "Non-Credit Qualifying")]
        NonCreditQualifying = 1
    }
}