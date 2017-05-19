using System.Runtime.Serialization;

namespace EncompassRest.Filters
{
    public enum SortOrder
    {
        [EnumMember(Value = "asc")]
        Ascending,
        [EnumMember(Value = "desc")]
        Descending
    }
}