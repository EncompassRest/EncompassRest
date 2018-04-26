using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Valuation
    /// </summary>
    public enum Valuation
    {
        /// <summary>
        /// I was aware of this valuation when I signed my contract
        /// </summary>
        [Description("I was aware of this valuation when I signed my contract")]
        AwareOfThisValuation = 0,
        /// <summary>
        /// I was not aware of this valuation when I signed my contract
        /// </summary>
        [Description("I was not aware of this valuation when I signed my contract")]
        NotAwareOfThisValuation = 1
    }
}