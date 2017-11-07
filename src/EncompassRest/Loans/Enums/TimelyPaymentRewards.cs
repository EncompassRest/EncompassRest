using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TimelyPaymentRewards
    {
        N = 0,
        Y = 1,
        [EnumMember(Value = "Y_Level1")]
        YLevel1 = 2,
        [EnumMember(Value = "Y_Level2")]
        YLevel2 = 3,
        [EnumMember(Value = "Y_Level3")]
        YLevel3 = 4
    }
}