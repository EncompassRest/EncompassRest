using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FreddieMacPurposeOfLoan
    /// </summary>
    public enum FreddieMacPurposeOfLoan
    {
        /// <summary>
        /// Purchase
        /// </summary>
        [Description("Purchase")]
        P = 0,
        /// <summary>
        /// Regular refinance
        /// </summary>
        [Description("Regular refinance")]
        RR = 1,
        /// <summary>
        /// Streamline refinance
        /// </summary>
        [Description("Streamline refinance")]
        RS = 2,
        /// <summary>
        /// Freddie-owned refinance
        /// </summary>
        [Description("Freddie-owned refinance")]
        RT = 3,
        /// <summary>
        /// FHA Credit Qualifying refinance
        /// </summary>
        [Description("FHA Credit Qualifying refinance")]
        RF = 4
    }
}