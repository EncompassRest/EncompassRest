using System.Threading.Tasks;
using EncompassRest.Utilities;
using EncompassRest.Webhook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using EnumsNET;

namespace EncompassRest.Tests
{
    [TestClass]
    public class WebhookTests : TestBaseClass
    {
        [TestMethod]
        public async Task Webhook_GetResources()
        {
            var client = await GetTestClientAsync();
            var resources = await client.Webhook.GetResourcesAsync();
            var webhookResourceTypes = new HashSet<string>(resources.Select(r => r.Name.Value));
            var existingWebhookResourceTypes = new HashSet<string>(Enums.GetMembers<WebhookResourceType>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookResourceTypes = webhookResourceTypes.Except(existingWebhookResourceTypes).ToList();
            Assert.AreEqual(0, newWebhookResourceTypes.Count);

            var webhookEvents = new HashSet<string>(resources.SelectMany(r => r.Events.Select(e => e.Value)));
            var existingWebhookEvents = new HashSet<string>(Enums.GetMembers<WebhookResourceEvent>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookEvents = webhookEvents.Except(existingWebhookEvents).ToList();
            Assert.AreEqual(0, newWebhookEvents.Count);

            var webhookStatuses = new HashSet<string>(resources.Select(r => r.Status.Value));
            var existingWebhookStatuses = new HashSet<string>(Enums.GetMembers<WebhookResourceStatus>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookStatuses = webhookStatuses.Except(existingWebhookStatuses).ToList();
            Assert.AreEqual(0, newWebhookStatuses.Count);
        }

        [TestMethod]
        public void WebhookSubscription_Serialization()
        {
            var subscription = new WebhookSubscription("https://google.com");
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
            subscription.Dirty = false;
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
            subscription.ClientId = "1234567890";
            subscription.Events = new StringEnumValue<WebhookResourceEvent>[] { "add", "update", "remove" };
            Assert.AreEqual(@"{""endpoint"":""https://google.com"",""clientId"":""1234567890"",""events"":[""add"",""update"",""remove""]}", subscription.ToJson());
            subscription.Dirty = false;
            Assert.AreEqual(@"{""endpoint"":""https://google.com""}", subscription.ToJson());
        }

        [TestMethod]
        public async Task Webhook_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var subscriptions = await client.Webhook.GetSubscriptionsAsync();
            const string endpoint = "https://abc123mortgage.com";
            var existingSubscription = subscriptions.FirstOrDefault(s => s.Endpoint == endpoint);
            if (existingSubscription != null)
            {
                await client.Webhook.DeleteSubscriptionAsync(existingSubscription.SubscriptionId);
            }
            var subscription = new WebhookSubscription(endpoint);
            var subscriptionId = await client.Webhook.CreateSubscriptionAsync(subscription);
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            Assert.IsTrue(await client.Webhook.DeleteSubscriptionAsync(subscriptionId));
        }

        [TestMethod]
        public async Task Webhook_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var subscriptions = await client.Webhook.GetSubscriptionsAsync();
            const string endpoint = "https://xyz987bank.com";
            var existingSubscription = subscriptions.FirstOrDefault(s => s.Endpoint == endpoint);
            if (existingSubscription != null)
            {
                await client.Webhook.DeleteSubscriptionAsync(existingSubscription.SubscriptionId);
            }
            var subscriptionId = await client.Webhook.CreateSubscriptionRawAsync($@"{{""endpoint"":""{endpoint}""}}");
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            Assert.IsTrue(await client.Webhook.DeleteSubscriptionAsync(subscriptionId));
        }
    }
}