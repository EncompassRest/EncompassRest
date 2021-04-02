using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// TrustClassificationType
    /// </summary>
    public enum TrustClassificationType
    {
        /// <summary>
        /// Land Trust
        /// </summary>
        [Description("Land Trust")]
        LandTrust = 0,
        /// <summary>
        /// Living Trust
        /// </summary>
        [Description("Living Trust")]
        LivingTrust = 1
    }
}