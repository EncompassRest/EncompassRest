using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// HelocTAAPPChangeOption
    /// </summary>
    public enum HelocTAAPPChangeOption
    {
        /// <summary>
        /// Increase only
        /// </summary>
        [EnumMember(Value = "Increase only")]
        IncreaseOnly = 0,
        /// <summary>
        /// Increase and Decrease APR
        /// </summary>
        [EnumMember(Value = "Increase and Decrease APR")]
        IncreaseAndDecreaseAPR = 1
    }
}