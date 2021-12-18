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
        GoodFaithAmount = 4,
        /// <summary>
        /// Initial
        /// </summary>
        Initial = 5,
        /// <summary>
        /// Latest
        /// </summary>
        Latest = 6,
        /// <summary>
        /// CannotDecrease
        /// </summary>
        CannotDecrease = 7,
        /// <summary>
        /// CannotIncrease
        /// </summary>
        CannotIncrease = 8,
        /// <summary>
        /// CannotIncrease10
        /// </summary>
        CannotIncrease10 = 9
    }
}