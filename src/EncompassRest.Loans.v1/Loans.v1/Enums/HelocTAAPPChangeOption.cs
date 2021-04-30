using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
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