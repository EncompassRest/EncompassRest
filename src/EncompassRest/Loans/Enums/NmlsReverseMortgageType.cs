using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NmlsReverseMortgageType
    {
        [EnumMember(Value = "HECM-Standard")]
        HECMStandard = 0,
        [EnumMember(Value = "HECM-Saver")]
        HECMSaver = 1,
        [EnumMember(Value = "Proprietary/Other")]
        ProprietaryOther = 2
    }
}