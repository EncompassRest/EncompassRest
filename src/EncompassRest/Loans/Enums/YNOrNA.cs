using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum YNOrNA
    {
        Y = 0,
        N = 1,
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}