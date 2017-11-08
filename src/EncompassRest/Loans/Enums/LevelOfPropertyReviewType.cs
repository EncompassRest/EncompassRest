using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LevelOfPropertyReviewType
    {
        [EnumMember(Value = "Exterior/Interior")]
        ExteriorInterior = 0,
        [EnumMember(Value = "Exterior Only")]
        ExteriorOnly = 1,
        [EnumMember(Value = "No Appraisal")]
        NoAppraisal = 2
    }
}