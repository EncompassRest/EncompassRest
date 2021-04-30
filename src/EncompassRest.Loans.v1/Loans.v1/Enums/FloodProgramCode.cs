using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// FloodProgramCode
    /// </summary>
    public enum FloodProgramCode
    {
        /// <summary>
        /// Regular
        /// </summary>
        Regular = 0,
        /// <summary>
        /// Emergency
        /// </summary>
        Emergency = 1,
        /// <summary>
        /// Probation
        /// </summary>
        Probation = 2,
        /// <summary>
        /// Suspended
        /// </summary>
        Suspended = 3,
        /// <summary>
        /// Non-participating
        /// </summary>
        [EnumMember(Value = "Non-participating")]
        NonParticipating = 4
    }
}