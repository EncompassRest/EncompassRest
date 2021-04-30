using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// GSEProjectType
    /// </summary>
    public enum GSEProjectType
    {
        /// <summary>
        /// Condominium
        /// </summary>
        Condominium = 0,
        /// <summary>
        /// Co-Operative
        /// </summary>
        [Description("Co-Operative")]
        Cooperative = 1
    }
}