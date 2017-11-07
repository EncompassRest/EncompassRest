using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FinalSignatureType
    {
        [EnumMember(Value = "esigned")]
        Esigned = 0,
        [EnumMember(Value = "wetsigned")]
        Wetsigned = 1,
        [EnumMember(Value = "other")]
        Other = 2
    }
}