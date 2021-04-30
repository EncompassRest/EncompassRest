using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// TsumMortgageOriginator
    /// </summary>
    public enum TsumMortgageOriginator
    {
        /// <summary>
        /// Broker
        /// </summary>
        [Description("Broker")]
        ThirdParty = 0,
        /// <summary>
        /// Seller
        /// </summary>
        Seller = 1,
        /// <summary>
        /// Correspondent
        /// </summary>
        Correspondent = 2
    }
}