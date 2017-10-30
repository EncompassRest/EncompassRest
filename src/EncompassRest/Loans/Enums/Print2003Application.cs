using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Print2003Application
    {
        N = 0,
        Y = 1,
        [EnumMember(Value = "2004")]
        n2004 = 2004,
        [EnumMember(Value = "2006")]
        n2006 = 2006,
        [EnumMember(Value = "2009")]
        n2009 = 2009
    }
}