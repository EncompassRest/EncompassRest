using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// TypeOfMortgage
    /// </summary>
    public enum TypeOfMortgage
    {
        /// <summary>
        /// Regular Fixed Payment
        /// </summary>
        [Description("Regular Fixed Payment")]
        RegularFixed = 0,
        /// <summary>
        /// GPM-Never Exceed CRV
        /// </summary>
        [Description("GPM-Never Exceed CRV")]
        GPM = 1,
        /// <summary>
        /// Other GPMs
        /// </summary>
        [Description("Other GPMs")]
        OtherGPM = 2,
        /// <summary>
        /// GEM
        /// </summary>
        GEM = 3,
        /// <summary>
        /// Temporary Buydown
        /// </summary>
        [Description("Temporary Buydown")]
        TemporaryBuydown = 4,
        /// <summary>
        /// Hybrid ARM
        /// </summary>
        [Description("Hybrid ARM")]
        HybridARM = 5,
        /// <summary>
        /// ARM
        /// </summary>
        ARM = 6
    }
}