using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// IfYouPurchaseType
    /// </summary>
    public enum IfYouPurchaseType
    {
        /// <summary>
        /// Hazard
        /// </summary>
        [Description("Hazard")]
        Property = 0,
        /// <summary>
        /// Flood
        /// </summary>
        Flood = 1,
        /// <summary>
        /// Hazard &amp; Flood
        /// </summary>
        [Description("Hazard & Flood")]
        [EnumMember(Value = "Property and Flood")]
        PropertyAndFlood = 2
    }
}