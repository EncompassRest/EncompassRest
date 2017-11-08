using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HmdaCreditScoringModel
    {
        [EnumMember(Value = "Equifax Beacon 5.0")]
        EquifaxBeacon50 = 0,
        [EnumMember(Value = "Experian Fair Isaac")]
        ExperianFairIsaac = 1,
        [EnumMember(Value = "FICO Risk Score Classic 04")]
        FICORiskScoreClassic04 = 2,
        [EnumMember(Value = "FICO Risk Score Classic 98")]
        FICORiskScoreClassic98 = 3,
        [EnumMember(Value = "VantageScore 2.0")]
        VantageScore20 = 4,
        [EnumMember(Value = "VantageScore 3.0")]
        VantageScore30 = 5,
        [EnumMember(Value = "More than one credit scoring model")]
        MoreThanOneCreditScoringModel = 6,
        [EnumMember(Value = "Other credit scoring model")]
        OtherCreditScoringModel = 7,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 8
    }
}