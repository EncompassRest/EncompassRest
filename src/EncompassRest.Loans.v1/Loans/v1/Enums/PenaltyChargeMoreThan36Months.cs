using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PenaltyChargeMoreThan36Months
    /// </summary>
    public enum PenaltyChargeMoreThan36Months
    {
        /// <summary>
        /// will
        /// </summary>
        [EnumMember(Value = "will")]
        Will = 0,
        /// <summary>
        /// will not
        /// </summary>
        [EnumMember(Value = "will not")]
        WillNot = 1
    }
}