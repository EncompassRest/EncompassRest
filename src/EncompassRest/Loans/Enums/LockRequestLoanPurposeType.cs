using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LockRequestLoanPurposeType
    {
        ConstructionToPermanent = 0,
        [EnumMember(Value = "NoCash-Out Refinance")]
        NoCashOutRefinance = 1,
        Purchase = 2,
        ConstructionOnly = 3,
        [EnumMember(Value = "Cash-Out Refinance")]
        CashOutRefinance = 4,
        Other = 5,
        Construction = 6
    }
}