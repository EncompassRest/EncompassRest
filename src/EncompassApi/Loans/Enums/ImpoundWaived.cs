using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
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