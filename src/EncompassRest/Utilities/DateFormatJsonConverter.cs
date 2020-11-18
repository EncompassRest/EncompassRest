using System;
using EnumsNET;
using Newtonsoft.Json.Converters;

namespace EncompassRest.Utilities
{
    internal sealed class DateFormatJsonConverter : IsoDateTimeConverter
    {
        public DateFormatJsonConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}