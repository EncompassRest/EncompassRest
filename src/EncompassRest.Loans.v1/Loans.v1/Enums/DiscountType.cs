using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// DiscountType
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// Below Note Rate
        /// </summary>
        [Description("Below Note Rate")]
        BelowNoteRate = 0,
        /// <summary>
        /// of The Payment
        /// </summary>
        [Description("of The Payment")]
        [EnumMember(Value = "ofThePayment")]
        OfThePayment = 1
    }
}