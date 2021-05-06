using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ImpoundWaived
    /// </summary>
    public enum ImpoundWaived
    {
        /// <summary>
        /// Waived
        /// </summary>
        Waived = 0,
        /// <summary>
        /// Not Waived
        /// </summary>
        [EnumMember(Value = "Not Waived")]
        NotWaived = 1
    }
}