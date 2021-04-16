using Newtonsoft.Json.Linq;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EncompassApi.xUnitTests.Payloads
{
    public class CleanUpPayloads
    {
        const string FILEPATH = "C:/Users/MichaelS/source/repos/RealMichaelSeifi/EncompassApi/src/EncompassApi.xUnitTests";

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array)]
        public void WebhookSubscriptions(string methodName, params JObject[] objs)
        {
            var subs = objs.Select(_ => _.ToObject<EncompassApi.Webhook.WebhookSubscription>()).ToArray();
            foreach (var s in subs)
            {
                s.Endpoint = "https://www.example.com/" + Faker.Name.First();
                s.InstanceId = "be" + Faker.RandomNumber.Next(10000000, 99999999).ToString();
                s.ClientId = Faker.RandomNumber.Next(10000000, 99999999).ToString();
                s.Signingkey = Convert.ToBase64String((new System.Text.ASCIIEncoding()).GetBytes("sigingkey"));
                s.ObjectUrn = $"urn:elli:webhook:{s.ClientId}:{s.InstanceId}:loan";


            }

            Helper.SaveJsonFile(methodName.Replace('_', '.'), FILEPATH, Newtonsoft.Json.JsonConvert.SerializeObject(subs));
        }

        [Theory]
        [WebhookSubscriptionFile(JsonFileTypes.Array, "Loan")]
        public void WebhookSubscriptions_Loan(string methodName, string resourceType, params JObject[] objs)
        {
            var subs = objs.Select(_ => _.ToObject<EncompassApi.Webhook.WebhookSubscription>()).ToArray();
            foreach (var s in subs)
            {
                s.Endpoint = "https://www.example.com/" + Faker.Name.First();
                s.InstanceId = "be" + Faker.RandomNumber.Next(10000000, 99999999).ToString();
                s.ClientId = Faker.RandomNumber.Next(10000000, 99999999).ToString();
                s.Signingkey = Convert.ToBase64String((new System.Text.ASCIIEncoding()).GetBytes("sigingkey"));
                s.ObjectUrn = $"urn:elli:webhook:{s.ClientId}:{s.InstanceId}:loan";
            }

            Helper.SaveJsonFile(methodName.Replace('_', '.'), FILEPATH, Newtonsoft.Json.JsonConvert.SerializeObject(subs));
        }
    }
}
