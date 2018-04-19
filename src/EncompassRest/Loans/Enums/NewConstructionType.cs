using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// NewConstructionType
    /// </summary>
    public enum NewConstructionType
    {
        /// <summary>
        /// Newly Built
        /// </summary>
        [Description("Newly Built")]
        NewlyBuilt = 0,
        /// <summary>
        /// Construction Conversion
        /// </summary>
        [Description("Construction Conversion")]
        ConstructionConversion = 1
    }
}