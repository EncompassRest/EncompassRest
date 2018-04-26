using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CurrentFirstMortgageHolderType
    /// </summary>
    public enum CurrentFirstMortgageHolderType
    {
        /// <summary>
        /// Seller / Other
        /// </summary>
        [Description("Seller / Other")]
        Other = 0,
        /// <summary>
        /// Freddie Mac
        /// </summary>
        [Description("Freddie Mac")]
        FRE = 1,
        /// <summary>
        /// Fannie Mae
        /// </summary>
        [Description("Fannie Mae")]
        FNM = 2
    }
}