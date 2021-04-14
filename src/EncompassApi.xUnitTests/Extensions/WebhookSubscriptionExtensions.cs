using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassApi.Webhook;

namespace EncompassApi.xUnitTests.Extensions
{
    public static class WebhookSubscriptionExtensions
    {
        public static EncompassApi.Webhook.WebhookSubscription ShallowCopy(this EncompassApi.Webhook.WebhookSubscription s)
        {
            if (s.Resource.EnumValue is EncompassApi.Webhook.WebhookResourceType resourceValue &&
                 s.Events is IEnumerable<WebhookResourceEvent> eventsValue)
                return new EncompassApi.Webhook.WebhookSubscription(s.Endpoint, resourceValue, eventsValue);
                
            throw new Exception("resource type and/or events have no value(s)");
        }
    }
}
