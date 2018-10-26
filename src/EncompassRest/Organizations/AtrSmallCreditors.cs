using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    public enum AtrSmallCreditors
    {
        [EnumMember(Value = "Small Creditor")]
        SmallCreditor = 0,
        [EnumMember(Value = "Rural Small Creditor")]
        RuralSmallCreditor = 1
    }
}