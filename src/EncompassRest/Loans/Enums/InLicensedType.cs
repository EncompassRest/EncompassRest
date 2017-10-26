using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum InLicensedType
    {
        [EnumMember(Value = "DFI First Lien Mortgage Lender")]
        DFIFirstLienMortgageLender = 0,
        [EnumMember(Value = "SOS Loan Broker")]
        SOSLoanBroker = 1
    }
}