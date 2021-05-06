using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
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