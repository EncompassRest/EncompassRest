using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InterestRateType
    {
        [EnumMember(Value = "Note Interest Rate")]
        NoteInterestRate = 0,
        [EnumMember(Value = "Prime Rate Plus")]
        PrimeRatePlus = 1,
        Other = 2
    }
}