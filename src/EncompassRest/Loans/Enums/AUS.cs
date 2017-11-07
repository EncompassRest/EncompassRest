using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AUS
    {
        DU = 0,
        LP = 1,
        TOTAL = 2,
        GUS = 3,
        Other = 4,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 5
    }
}