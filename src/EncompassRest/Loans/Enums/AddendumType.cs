using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AddendumType
    {
        [EnumMember(Value = "V.A.")]
        VA = 0,
        [EnumMember(Value = "HUD / FHA")]
        HUDFHA = 1
    }
}