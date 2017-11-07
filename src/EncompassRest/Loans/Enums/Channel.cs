using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Channel
    {
        [EnumMember(Value = "Banked - Retail")]
        BankedRetail = 0,
        [EnumMember(Value = "Banked - Wholesale")]
        BankedWholesale = 1,
        Brokered = 2,
        Correspondent = 3
    }
}