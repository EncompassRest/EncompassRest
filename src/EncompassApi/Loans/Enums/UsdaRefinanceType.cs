using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// UsdaRefinanceType
    /// </summary>
    public enum UsdaRefinanceType
    {
        /// <summary>
        /// Non-Streamlined
        /// </summary>
        [Description("Non-Streamlined")]
        [EnumMember(Value = "Non Streamlined")]
        NonStreamlined = 0,
        /// <summary>
        /// Streamlined
        /// </summary>
        Streamlined = 1,
        /// <summary>
        /// Streamlined-Assist
        /// </summary>
        [Description("Streamlined-Assist")]
        [EnumMember(Value = "Streamlined Assist")]
        StreamlinedAssist = 2
    }
}