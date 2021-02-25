using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// MfgHomeAnchored
    /// </summary>
    public enum MfgHomeAnchored
    {
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 0,
        /// <summary>
        /// Shall Be
        /// </summary>
        [EnumMember(Value = "Shall Be")]
        ShallBe = 1
    }
}