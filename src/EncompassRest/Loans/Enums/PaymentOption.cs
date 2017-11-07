using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PaymentOption
    {
        [EnumMember(Value = "Standard Front Loaded")]
        StandardFrontLoaded = 0,
        Level = 1,
        [EnumMember(Value = "Life of Loan")]
        LifeOfLoan = 2,
        [EnumMember(Value = "Single Specific")]
        SingleSpecific = 3,
        [EnumMember(Value = "Standard Back Loaded")]
        StandardBackLoaded = 4,
        Deferred = 5
    }
}