using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieRefinanceType
    {
        [EnumMember(Value = "FRE Owned Streamlined Refinance")]
        FREOwnedStreamlinedRefinance = 0,
        [EnumMember(Value = "Refi Plus")]
        RefiPlus = 1,
        [EnumMember(Value = "Relief Refinance Open Access")]
        ReliefRefinanceOpenAccess = 2,
        [EnumMember(Value = "Relief Refinance Same Servicer")]
        ReliefRefinanceSameServicer = 3,
        [EnumMember(Value = "Streamlined Relief Refinance")]
        StreamlinedReliefRefinance = 4,
        [EnumMember(Value = "Texas Equity")]
        TexasEquity = 5
    }
}