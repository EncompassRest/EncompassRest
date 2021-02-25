using System.ComponentModel;

namespace EncompassApi.Filters
{
    /// <summary>
    /// OrdinalFieldMatchType
    /// </summary>
    public enum OrdinalFieldMatchType
    {
        /// <summary>
        /// Equals
        /// </summary>
        [Description("==")]
        Equals = 0,
        /// <summary>
        /// NotEquals
        /// </summary>
        [Description("!=")]
        NotEquals = 1,
        /// <summary>
        /// GreaterThan
        /// </summary>
        [Description(">")]
        GreaterThan = 2,
        /// <summary>
        /// GreaterThanOrEquals
        /// </summary>
        [Description(">=")]
        GreaterThanOrEquals = 3,
        /// <summary>
        /// LessThan
        /// </summary>
        [Description("<")]
        LessThan = 4,
        /// <summary>
        /// LessThanOrEquals
        /// </summary>
        [Description("<=")]
        LessThanOrEquals = 5
    }
}