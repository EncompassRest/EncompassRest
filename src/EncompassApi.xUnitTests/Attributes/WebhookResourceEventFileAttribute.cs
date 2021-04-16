using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    public class WebhookResourceEventFileAttribute : WebhookResourceFileAttribute
    {
        public WebhookResourceEventFileAttribute(JsonFileTypes type, params string[] args)
           : base("WebhookResourceEvent", type, args) { }
    }
}
