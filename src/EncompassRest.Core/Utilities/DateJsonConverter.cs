using Newtonsoft.Json.Converters;

namespace EncompassRest.Utilities
{
    internal sealed class DateJsonConverter : IsoDateTimeConverter
    {
        public DateJsonConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}