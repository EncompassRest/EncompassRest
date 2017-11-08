using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum QMLoanType
    {
        [EnumMember(Value = "General QM")]
        GeneralQM = 0,
        [EnumMember(Value = "Agency/GSE QM")]
        AgencyGSEQM = 1,
        [EnumMember(Value = "FHA QM")]
        FHAQM = 2,
        [EnumMember(Value = "Small Creditor QM")]
        SmallCreditorQM = 3,
        [EnumMember(Value = "Small Creditor Rural QM")]
        SmallCreditorRuralQM = 4,
        [EnumMember(Value = "VA QM")]
        VAQM = 5
    }
}