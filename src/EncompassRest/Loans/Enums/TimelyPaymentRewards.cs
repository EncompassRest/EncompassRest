using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TimelyPaymentRewards
    {
        Y = 0,
        N = 1,
        [EnumMember(Value = "Y_Level1")]
        YLevel1 = 2,
        [EnumMember(Value = "Y_Level2")]
        YLevel2 = 3,
        [EnumMember(Value = "Y_Level3")]
        YLevel3 = 4
    }
}