using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PTB
    /// </summary>
    public enum PTB
    {
        /// <summary>
        /// B
        /// </summary>
        [Description("B")]
        Broker = 0,
        /// <summary>
        /// L
        /// </summary>
        [Description("L")]
        Lender = 1,
        /// <summary>
        /// S
        /// </summary>
        [Description("S")]
        Seller = 2,
        /// <summary>
        /// I
        /// </summary>
        [Description("I")]
        Investor = 3,
        /// <summary>
        /// A
        /// </summary>
        [Description("A")]
        Affiliate = 4,
        /// <summary>
        /// O
        /// </summary>
        [Description("O")]
        Other = 5
    }
}