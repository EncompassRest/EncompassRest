using System.ComponentModel;

namespace EncompassRest.Filters
{
    public enum OrdinalFieldMatchType
    {
        [Description("==")]
        Equals = 0,
        [Description("!=")]
        NotEquals = 1,
        [Description(">")]
        GreaterThan = 2,
        [Description(">=")]
        GreaterThanOrEquals = 3,
        [Description("<")]
        LessThan = 4,
        [Description("<=")]
        LessThanOrEquals = 5
    }
}