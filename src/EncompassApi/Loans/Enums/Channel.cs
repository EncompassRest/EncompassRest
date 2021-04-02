using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// Channel
    /// </summary>
    public enum Channel
    {
        /// <summary>
        /// Banked - Retail
        /// </summary>
        [EnumMember(Value = "Banked - Retail")]
        BankedRetail = 0,
        /// <summary>
        /// Banked - Wholesale
        /// </summary>
        [EnumMember(Value = "Banked - Wholesale")]
        BankedWholesale = 1,
        /// <summary>
        /// Brokered
        /// </summary>
        Brokered = 2,
        /// <summary>
        /// Correspondent
        /// </summary>
        Correspondent = 3
    }
}