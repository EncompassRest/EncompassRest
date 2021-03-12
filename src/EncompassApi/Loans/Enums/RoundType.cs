using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RoundType
    /// </summary>
    public enum RoundType
    {
        /// <summary>
        /// Up
        /// </summary>
        Up = 0,
        /// <summary>
        /// Down
        /// </summary>
        Down = 1,
        /// <summary>
        /// Nearest
        /// </summary>
        [Description("Nearest")]
        [EnumMember(Value = "")]
        Nearest = 2
    }
}