using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum YNOrNA
    {
        N = 0,
        Y = 1,
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}