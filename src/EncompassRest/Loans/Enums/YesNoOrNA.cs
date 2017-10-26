using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum YesNoOrNA
    {
        Yes = 0,
        No = 1,
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}