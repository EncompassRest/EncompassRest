using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMacOfferingIdentifier
    /// </summary>
    public enum FreddieMacOfferingIdentifier
    {
        /// <summary>
        /// Home Possible
        /// </summary>
        [EnumMember(Value = "Home Possible")]
        HomePossible = 0,
        /// <summary>
        /// HFA Advantage
        /// </summary>
        [EnumMember(Value = "HFA Advantage")]
        HFAAdvantage = 1,
        /// <summary>
        /// Refi Possible
        /// </summary>
        [EnumMember(Value = "Refi Possible")]
        RefiPossible = 2
    }
}