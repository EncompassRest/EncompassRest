using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AssumptionOnYourProperty
    {
        May = 0,
        [EnumMember(Value = "May_not")]
        MayNot = 1,
        [EnumMember(Value = "May_SubjectToConditions")]
        MaySubjectToConditions = 2
    }
}