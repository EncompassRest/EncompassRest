using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum YesNoOrNA
    {
        No = 0,
        Yes = 1,
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}