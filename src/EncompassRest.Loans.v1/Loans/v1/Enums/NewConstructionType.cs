using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
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