using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AppraisalMade
    {
        [EnumMember(Value = "As Is")]
        AsIs = 0,
        [EnumMember(Value = "As Improved")]
        AsImproved = 1
    }
}