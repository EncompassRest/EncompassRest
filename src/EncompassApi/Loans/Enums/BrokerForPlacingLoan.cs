using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// BrokerForPlacingLoan
    /// </summary>
    public enum BrokerForPlacingLoan
    {
        /// <summary>
        /// Is Not
        /// </summary>
        [EnumMember(Value = "Is Not")]
        IsNot = 0,
        /// <summary>
        /// Is
        /// </summary>
        Is = 1
    }
}