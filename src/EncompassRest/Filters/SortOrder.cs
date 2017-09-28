using System.Runtime.Serialization;
using EncompassRest.Utilities;

namespace EncompassRest.Filters
{
    [EnumOutput(EnumOutput.EnumMemberValue)]
    public enum SortOrder
    {
        [EnumMember(Value = "asc")]
        Ascending,
        [EnumMember(Value = "desc")]
        Descending
    }
}