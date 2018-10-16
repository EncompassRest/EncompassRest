using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HelocCalcSign
    /// </summary>
    public enum HelocCalcSign
    {
        /// <summary>
        /// +
        /// </summary>
        [EnumMember(Value = "+")]
        Plus = 0,
        /// <summary>
        /// -
        /// </summary>
        [EnumMember(Value = "-")]
        Minus = 1
    }
}