using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FHAStreamlineType
    /// </summary>
    public enum FHAStreamlineType
    {
        /// <summary>
        /// Credit Qualifying
        /// </summary>
        [EnumMember(Value = "Credit Qualifying")]
        CreditQualifying = 0,
        /// <summary>
        /// Non-Credit Qualifying
        /// </summary>
        [EnumMember(Value = "Non-Credit Qualifying")]
        NonCreditQualifying = 1
    }
}