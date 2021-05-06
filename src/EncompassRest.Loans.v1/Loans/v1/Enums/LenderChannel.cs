using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LenderChannel
    /// </summary>
    public enum LenderChannel
    {
        /// <summary>
        /// Retail
        /// </summary>
        Retail = 0,
        /// <summary>
        /// Wholesale Broker
        /// </summary>
        [Description("Wholesale Broker")]
        Broker = 1,
        /// <summary>
        /// Wholesale Correspondent
        /// </summary>
        [Description("Wholesale Correspondent")]
        Correspondent = 2
    }
}