using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ServicingStatus
    /// </summary>
    public enum ServicingStatus
    {
        /// <summary>
        /// Not Servicing
        /// </summary>
        [EnumMember(Value = "Not Servicing")]
        NotServicing = 0,
        /// <summary>
        /// Current
        /// </summary>
        Current = 1,
        /// <summary>
        /// Past Due
        /// </summary>
        [EnumMember(Value = "Past Due")]
        PastDue = 2,
        /// <summary>
        /// Foreclosure
        /// </summary>
        Foreclosure = 3,
        /// <summary>
        /// Servicing Released
        /// </summary>
        [EnumMember(Value = "Servicing Released")]
        ServicingReleased = 4
    }
}