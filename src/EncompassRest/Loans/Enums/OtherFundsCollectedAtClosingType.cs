using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OtherFundsCollectedAtClosingType
    /// </summary>
    public enum OtherFundsCollectedAtClosingType
    {
        /// <summary>
        /// Advanced PITI Payment - Retired
        /// </summary>
        [Description("Advanced PITI Payment - Retired")]
        AdvancedPITIPayment = 0,
        /// <summary>
        /// Escrow Funds
        /// </summary>
        [Description("Escrow Funds")]
        EscrowFunds = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2,
        /// <summary>
        /// Principal Curtailment - Retired
        /// </summary>
        [Description("Principal Curtailment - Retired")]
        PrincipalCurtailment = 3
    }
}