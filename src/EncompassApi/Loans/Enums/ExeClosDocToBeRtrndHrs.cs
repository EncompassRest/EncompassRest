using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ExeClosDocToBeRtrndHrs
    /// </summary>
    public enum ExeClosDocToBeRtrndHrs
    {
        /// <summary>
        /// 24
        /// </summary>
        [EnumMember(Value = "24")]
        n24 = 24,
        /// <summary>
        /// 48
        /// </summary>
        [EnumMember(Value = "48")]
        n48 = 48
    }
}