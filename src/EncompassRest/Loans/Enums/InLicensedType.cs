using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// InLicensedType
    /// </summary>
    public enum InLicensedType
    {
        /// <summary>
        /// DFI First Lien Mortgage Lender
        /// </summary>
        [EnumMember(Value = "DFI First Lien Mortgage Lender")]
        DFIFirstLienMortgageLender = 0,
        /// <summary>
        /// SOS Loan Broker
        /// </summary>
        [EnumMember(Value = "SOS Loan Broker")]
        SOSLoanBroker = 1
    }
}