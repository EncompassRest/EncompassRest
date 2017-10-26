using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CreditReportCompany
    {
        [EnumMember(Value = "1")]
        n1 = 0,
        [EnumMember(Value = "4")]
        n4 = 1,
        [EnumMember(Value = "5")]
        n5 = 2,
        [EnumMember(Value = "6")]
        n6 = 3,
        [EnumMember(Value = "8")]
        n8 = 4,
        A = 5,
        B = 6
    }
}