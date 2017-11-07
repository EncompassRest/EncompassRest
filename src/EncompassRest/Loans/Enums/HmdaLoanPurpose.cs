using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum HmdaLoanPurpose
    {
        [EnumMember(Value = "Home Purchase")]
        HomePurchase = 0,
        [EnumMember(Value = "Home Improvement")]
        HomeImprovement = 1,
        Refinancing = 2,
        [EnumMember(Value = "Cash-out refinancing")]
        CashOutRefinancing = 3,
        [EnumMember(Value = "Other purpose")]
        OtherPurpose = 4
    }
}