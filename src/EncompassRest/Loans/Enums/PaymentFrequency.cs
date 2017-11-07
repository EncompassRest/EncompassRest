using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PaymentFrequency
    {
        Monthly = 0,
        Annually = 1,
        [EnumMember(Value = "One time lump sum")]
        OneTimeLumpSum = 2,
        [EnumMember(Value = "Single Specific")]
        SingleSpecific = 3,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 4
    }
}