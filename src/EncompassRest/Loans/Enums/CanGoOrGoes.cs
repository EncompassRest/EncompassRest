using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CanGoOrGoes
    {
        [EnumMember(Value = "Can go")]
        CanGo = 0,
        Goes = 1
    }
}