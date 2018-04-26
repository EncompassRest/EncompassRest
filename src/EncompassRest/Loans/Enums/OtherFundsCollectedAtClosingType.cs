using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OtherFundsCollectedAtClosingType
    /// </summary>
    public enum OtherFundsCollectedAtClosingType
    {
        /// <summary>
        /// Advanced PITI Payment
        /// </summary>
        [Description("Advanced PITI Payment")]
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
        /// Principal Curtailment
        /// </summary>
        [Description("Principal Curtailment")]
        PrincipalCurtailment = 3
    }
}