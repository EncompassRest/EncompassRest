using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FeeVarianceFeeType
    /// </summary>
    public enum FeeVarianceFeeType
    {
        /// <summary>
        /// ChargesThatCannotDecrease
        /// </summary>
        ChargesThatCannotDecrease = 0,
        /// <summary>
        /// ChargesThatCannotIncrease
        /// </summary>
        ChargesThatCannotIncrease = 1,
        /// <summary>
        /// ChargesCannotIncrease10
        /// </summary>
        ChargesCannotIncrease10 = 2,
        /// <summary>
        /// ChargesThatCanChange
        /// </summary>
        ChargesThatCanChange = 3,
        /// <summary>
        /// GoodFaithAmount
        /// </summary>
        GoodFaithAmount = 4
    }
}