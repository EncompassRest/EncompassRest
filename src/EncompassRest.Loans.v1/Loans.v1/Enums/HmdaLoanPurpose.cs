using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HmdaLoanPurpose
    /// </summary>
    public enum HmdaLoanPurpose
    {
        /// <summary>
        /// 1. Home Purchase
        /// </summary>
        [Description("1. Home Purchase")]
        [EnumMember(Value = "Home Purchase")]
        HomePurchase = 0,
        /// <summary>
        /// 2. Home Improvement
        /// </summary>
        [Description("2. Home Improvement")]
        [EnumMember(Value = "Home Improvement")]
        HomeImprovement = 1,
        /// <summary>
        /// 31. Refinancing
        /// </summary>
        [Description("31. Refinancing")]
        Refinancing = 2,
        /// <summary>
        /// 32. Cash-out refinancing
        /// </summary>
        [Description("32. Cash-out refinancing")]
        [EnumMember(Value = "Cash-out refinancing")]
        CashOutRefinancing = 3,
        /// <summary>
        /// 4. Other purpose
        /// </summary>
        [Description("4. Other purpose")]
        [EnumMember(Value = "Other purpose")]
        OtherPurpose = 4,
        /// <summary>
        /// 5. Not applicable
        /// </summary>
        [Description("5. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 5
    }
}