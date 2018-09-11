using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PriceAdjustmentType
    /// </summary>
    public enum PriceAdjustmentType
    {
        /// <summary>
        /// BaseRate
        /// </summary>
        BaseRate = 0,
        /// <summary>
        /// BasePrice
        /// </summary>
        BasePrice = 1,
        /// <summary>
        /// BaseMargin
        /// </summary>
        BaseMargin = 2,
        /// <summary>
        /// ProfitMargin
        /// </summary>
        ProfitMargin = 3
    }
}