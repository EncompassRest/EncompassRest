using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ServicingType
    /// </summary>
    public enum ServicingType
    {
        /// <summary>
        /// Service Retained
        /// </summary>
        [EnumMember(Value = "Service Retained")]
        ServiceRetained = 0,
        /// <summary>
        /// Service Released
        /// </summary>
        [EnumMember(Value = "Service Released")]
        ServiceReleased = 1
    }
}