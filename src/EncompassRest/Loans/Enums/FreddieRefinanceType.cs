using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieRefinanceType
    /// </summary>
    public enum FreddieRefinanceType
    {
        /// <summary>
        /// FRE Owned Streamlined Refinance
        /// </summary>
        [EnumMember(Value = "FRE Owned Streamlined Refinance")]
        FREOwnedStreamlinedRefinance = 0,
        /// <summary>
        /// Refi Plus
        /// </summary>
        [EnumMember(Value = "Refi Plus")]
        RefiPlus = 1,
        /// <summary>
        /// Relief Refinance Open Access
        /// </summary>
        [EnumMember(Value = "Relief Refinance Open Access")]
        ReliefRefinanceOpenAccess = 2,
        /// <summary>
        /// Relief Refinance Same Servicer
        /// </summary>
        [EnumMember(Value = "Relief Refinance Same Servicer")]
        ReliefRefinanceSameServicer = 3,
        /// <summary>
        /// Streamlined Relief Refinance
        /// </summary>
        [EnumMember(Value = "Streamlined Relief Refinance")]
        StreamlinedReliefRefinance = 4,
        /// <summary>
        /// Texas Equity
        /// </summary>
        [EnumMember(Value = "Texas Equity")]
        TexasEquity = 5,
        /// <summary>
        /// Enhanced Relief Refinance
        /// </summary>
        [EnumMember(Value = "Enhanced Relief Refinance")]
        EnhancedReliefRefinance = 6
    }
}