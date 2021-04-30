using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NmlsProductionSoldToType
    /// </summary>
    public enum NmlsProductionSoldToType
    {
        /// <summary>
        /// Production Sold to Secondary Market Agency (Fannie, Freddie, Ginnie)
        /// </summary>
        [Description("Production Sold to Secondary Market Agency (Fannie, Freddie, Ginnie)")]
        SecondaryMarketAgency = 0,
        /// <summary>
        /// Production Sold to Other (Non-Affiliate)
        /// </summary>
        [Description("Production Sold to Other (Non-Affiliate)")]
        NonAffiliate = 1,
        /// <summary>
        /// Production Sold to Other (Affiliate)
        /// </summary>
        [Description("Production Sold to Other (Affiliate)")]
        Affiliate = 2,
        /// <summary>
        /// Production Kept in Portfolio/Held for Investment
        /// </summary>
        [Description("Production Kept in Portfolio/Held for Investment")]
        HeldForInvestment = 3,
        /// <summary>
        /// Production Sold through Non-Agency Securitizations with Sale Treatment
        /// </summary>
        [Description("Production Sold through Non-Agency Securitizations with Sale Treatment")]
        NonAgencyWithSaleTreatment = 4,
        /// <summary>
        /// Production Sold through Non-Agency Securitizations without Sale Treatment
        /// </summary>
        [Description("Production Sold through Non-Agency Securitizations without Sale Treatment")]
        NonAgencyWithoutSaleTreatment = 5
    }
}