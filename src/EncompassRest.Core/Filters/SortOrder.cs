using System.Runtime.Serialization;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Filters
{
    /// <summary>
    /// SortOrder
    /// </summary>
    [EnumFormat(EnumFormat.EnumMemberValue)]
    public enum SortOrder
    {
        /// <summary>
        /// asc
        /// </summary>
        [EnumMember(Value = "asc")]
        Ascending = 0,
        /// <summary>
        /// desc
        /// </summary>
        [EnumMember(Value = "desc")]
        Descending = 1
    }
}