using System.ComponentModel;

namespace EncompassRest.Filters
{
    /// <summary>
    /// StringFieldMatchType
    /// </summary>
    public enum StringFieldMatchType
    {
        /// <summary>
        /// Exact
        /// </summary>
        [Description("==")]
        Exact = 0,
        /// <summary>
        /// CaseInsensitive
        /// </summary>
        [Description("=")]
        CaseInsensitive = 1,
        /// <summary>
        /// StartsWith
        /// </summary>
        [Description("sw")]
        StartsWith = 2,
        /// <summary>
        /// Contains
        /// </summary>
        [Description("like")]
        Contains = 3
    }
}