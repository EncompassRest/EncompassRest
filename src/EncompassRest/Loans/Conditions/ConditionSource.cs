using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Loans.Conditions
{
    public enum ConditionSource
    {
        Escrow = 0,
        Investor = 1,
        [EnumMember(Value = "Recorder's Office")]
        RecordersOffice = 2,
        Borrowers = 3,
        FHA = 4,
        VA = 5,
        MI = 6,
        Company = 7,
        Other = 8,
        Manual = 9,
        [EnumMember(Value = "Condition Set")]
        ConditionSet = 10,
        [EnumMember(Value = "Automated Conditions")]
        AutomatedConditions = 11
    }
}