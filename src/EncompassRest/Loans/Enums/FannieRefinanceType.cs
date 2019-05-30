using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieRefinanceType
    /// </summary>
    public enum FannieRefinanceType
    {
        /// <summary>
        /// Disaster Response
        /// </summary>
        [EnumMember(Value = "Disaster Response")]
        DisasterResponse = 0,
        /// <summary>
        /// DU Refi Plus
        /// </summary>
        [EnumMember(Value = "DU Refi Plus")]
        DURefiPlus = 1,
        /// <summary>
        /// Refi Plus
        /// </summary>
        [EnumMember(Value = "Refi Plus")]
        RefiPlus = 2,
        /// <summary>
        /// High LTV Refi
        /// </summary>
        [EnumMember(Value = "High LTV Refi")]
        HighLTVRefi = 3,
        /// <summary>
        /// Texas Equity
        /// </summary>
        [EnumMember(Value = "Texas Equity")]
        TexasEquity = 4
    }
}