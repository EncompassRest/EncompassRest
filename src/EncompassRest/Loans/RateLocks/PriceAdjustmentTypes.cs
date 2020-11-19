using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// PriceAdjustmentTypes
    /// </summary>
    public enum PriceAdjustmentTypes
    {
        /// <summary>
        /// Undefined
        /// </summary>
        [EnumMember(Value = "undefined")]
        Undefined = 0,
        /// <summary>
        /// BaseMargin
        /// </summary>
        [EnumMember(Value = "baseMargin")]
        BaseMargin = 1,
        /// <summary>
        /// BasePrice
        /// </summary>
        [EnumMember(Value = "basePrice")]
        BasePrice = 2,
        /// <summary>
        /// BaseRate
        /// </summary>
        [EnumMember(Value = "baseRate")]
        BaseRate = 3,
        /// <summary>
        /// ProfitMargin
        /// </summary>
        [EnumMember(Value = "profitMargin")]
        ProfitMargin = 4

    }
}