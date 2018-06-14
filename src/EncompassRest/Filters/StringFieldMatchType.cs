using System.ComponentModel;

namespace EncompassRest.Filters
{
    public enum StringFieldMatchType
    {
        [Description("==")]
        Exact = 0,
        [Description("=")]
        CaseInsensitive = 1,
        [Description("sw")]
        StartsWith = 2,
        [Description("like")]
        Contains = 3
    }
}