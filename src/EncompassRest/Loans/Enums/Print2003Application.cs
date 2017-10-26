using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Print2003Application
    {
        Y = 0,
        N = 1,
        [EnumMember(Value = "2004")]
        n2004 = 2,
        [EnumMember(Value = "2006")]
        n2006 = 3,
        [EnumMember(Value = "2009")]
        n2009 = 4
    }
}