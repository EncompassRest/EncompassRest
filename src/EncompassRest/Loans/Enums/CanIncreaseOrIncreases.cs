using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CanIncreaseOrIncreases
    {
        [EnumMember(Value = "Can increase")]
        CanIncrease = 0,
        Increases = 1
    }
}