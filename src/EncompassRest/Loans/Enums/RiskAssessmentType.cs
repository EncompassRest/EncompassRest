using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum RiskAssessmentType
    {
        [EnumMember(Value = "Manual Underwriting")]
        ManualUnderwriting = 0,
        DU = 1,
        LP = 2,
        LQA = 3,
        Other = 4
    }
}