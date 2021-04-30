using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LoanFromBrokerControledFundsType
    /// </summary>
    public enum LoanFromBrokerControledFundsType
    {
        /// <summary>
        /// may
        /// </summary>
        [EnumMember(Value = "may")]
        May = 0,
        /// <summary>
        /// will
        /// </summary>
        [EnumMember(Value = "will")]
        Will = 1,
        /// <summary>
        /// will not
        /// </summary>
        [EnumMember(Value = "will not")]
        WillNot = 2
    }
}