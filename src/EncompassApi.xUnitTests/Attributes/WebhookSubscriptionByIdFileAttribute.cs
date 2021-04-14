using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    public class WebhookSubscriptionByIdFileAttribute : WebhookSubscriptionFileAttribute
    {
        public WebhookSubscriptionByIdFileAttribute(JsonFileTypes type, string[] resourceTypes, params string[] ids)
               : base(type, resourceTypes)
        {
            SubscriptionIds = ids;
        }
    }
}
