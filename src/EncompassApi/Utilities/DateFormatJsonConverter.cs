using System;
using EnumsNET;
using Newtonsoft.Json.Converters;

namespace EncompassApi.Utilities
{
    internal sealed class ElliDateJsonConverter : IsoDateTimeConverter
    {
        public ElliDateJsonConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}