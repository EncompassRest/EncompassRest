using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
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