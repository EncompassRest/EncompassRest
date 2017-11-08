using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum OtherNonAmortization
    {
        [EnumMember(Value = "Other non-fully amortizing features")]
        OtherNonFullyAmortizingFeatures = 0,
        [EnumMember(Value = "No other non-fully amortizing features")]
        NoOtherNonFullyAmortizingFeatures = 1
    }
}