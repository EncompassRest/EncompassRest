using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// TimelyPaymentRewards
    /// </summary>
    public enum TimelyPaymentRewards
    {
        /// <summary>
        /// N
        /// </summary>
        N = 0,
        /// <summary>
        /// Y
        /// </summary>
        Y = 1,
        /// <summary>
        /// Y_Level1
        /// </summary>
        [EnumMember(Value = "Y_Level1")]
        YLevel1 = 2,
        /// <summary>
        /// Y_Level2
        /// </summary>
        [EnumMember(Value = "Y_Level2")]
        YLevel2 = 3,
        /// <summary>
        /// Y_Level3
        /// </summary>
        [EnumMember(Value = "Y_Level3")]
        YLevel3 = 4
    }
}