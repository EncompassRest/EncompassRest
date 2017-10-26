using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieARMIndexType
    {
        LIBOROneYearWSJDaily = 0,
        [EnumMember(Value = "SixMonthLIBOR_WSJDaily")]
        SixMonthLIBORWSJDaily = 1,
        WeeklyFiveYearTreasurySecuritiesConstantMaturityFRBH15 = 2,
        WeeklyOneYearTreasurySecuritiesConstantMaturityFRBH15 = 3,
        WeeklyThreeYearTreasurySecuritiesConstantMaturityFRBH15 = 4
    }
}