using System.Runtime.Serialization;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Filters
{
    [EnumFormat(EnumFormat.EnumMemberValue)]
    public enum SortOrder
    {
        [EnumMember(Value = "asc")]
        Ascending = 0,
        [EnumMember(Value = "desc")]
        Descending = 1
    }
}