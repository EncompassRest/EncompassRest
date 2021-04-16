using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    public class WebhookEventFileAttribute : JsonFileDataAttribute
    {
        public WebhookEventFileAttribute(JsonFileTypes type, params string[] args)
           : base("WebhookEvent", null, type, args)
        {
            if (type == JsonFileTypes.Array) _fileName += "s";
        }
    }
}
