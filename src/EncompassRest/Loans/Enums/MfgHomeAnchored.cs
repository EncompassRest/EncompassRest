using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum MfgHomeAnchored
    {
        Yes = 0,
        [EnumMember(Value = "Shall Be")]
        ShallBe = 1
    }
}