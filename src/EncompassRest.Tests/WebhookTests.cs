using System.Threading.Tasks;
using EncompassRest.Utilities;
using EncompassRest.Webhook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class WebhookTests : TestBaseClass
    {
        [TestMethod]
        public void WebhookSubscription_Serialization()
        {
            var subscription = new WebhookSubscription("https://google.com");
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
            subscription.Dirty = false;
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
            subscription.ClientId = "1234567890";
            subscription.Events = new[] { "add", "update", "remove" };
            Assert.AreEqual(@"{""endpoint"":""https://google.com"",""clientId"":""1234567890"",""events"":[""add"",""update"",""remove""]}", subscription.ToJson());
            subscription.Dirty = false;
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
        }

        [TestMethod]
        public async Task Webhook_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var subscription = new WebhookSubscription("https://abc123mortgage.com");
            var subscriptionId = await client.Webhook.CreateSubscriptionAsync(subscription);
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            await client.Webhook.DeleteSubscriptionAsync(subscriptionId);
        }

        [TestMethod]
        public async Task Webhook_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var subscriptionId = await client.Webhook.CreateSubscriptionRawAsync(@"{""endpoint"":""https://xyz987bank.com""}");
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            await client.Webhook.DeleteSubscriptionAsync(subscriptionId);
        }
    }
}