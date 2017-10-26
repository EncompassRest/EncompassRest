using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum VABenefitRelatedIndebtedness
    {
        Do = 0,
        [EnumMember(Value = "Do Not")]
        DoNot = 1
    }
}