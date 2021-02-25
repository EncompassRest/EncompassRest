using System.Runtime.Serialization;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.Filters
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