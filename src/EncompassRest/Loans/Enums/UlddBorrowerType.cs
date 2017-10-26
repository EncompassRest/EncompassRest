using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UlddBorrowerType
    {
        Individual = 0,
        [EnumMember(Value = "Legal Entity")]
        LegalEntity = 1
    }
}