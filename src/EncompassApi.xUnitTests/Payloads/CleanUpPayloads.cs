using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EncompassApi.xUnitTests.Payloads
{
    public class CleanUpPayloads
    {

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public void WebhookSubscriptions(string methodName, params JObject[] objs)
        {
            var subs = objs.Select(_ => _.ToObject<EncompassApi.Webhook.WebhookSubscription>());
            foreach (var s in subs)
            {
                s.Endpoint = Faker.Internet.SecureUrl();
                s.InstanceId = Faker.Lorem.GetFirstWord();
            }

            Helper.SaveJsonFile(methodName.Replace('_', '.'), Newtonsoft.Json.JsonConvert.SerializeObject(subs));
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array, "Loan")]
        public void WebhookSubscriptions_Loan(string methodName, string resourceType, params JObject[] objs)
        {
            var subs = objs.Select(_ => _.ToObject<EncompassApi.Webhook.WebhookSubscription>());
            foreach (var s in subs)
            {
                s.Endpoint = Faker.Internet.SecureUrl();
                s.InstanceId = Faker.Lorem.GetFirstWord();
            }

            Helper.SaveJsonFile(methodName.Replace('_', '.'), Newtonsoft.Json.JsonConvert.SerializeObject(subs));
        }
    }
}
