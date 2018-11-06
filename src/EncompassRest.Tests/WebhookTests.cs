using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using EncompassRest.Webhook;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            foreach (var resource in resources)
            {
                AssertNoExtensionData(resource, "Resource", resource.Name);
            }

            Assert.IsTrue(resources.All(r => r.Name.EnumValue.HasValue));
            var webhookResourceTypes = new HashSet<string>(resources.Select(r => r.Name.Value));
            var existingWebhookResourceTypes = new HashSet<string>(Enums.GetMembers<WebhookResourceType>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookResourceTypes = webhookResourceTypes.Except(existingWebhookResourceTypes).ToList();
            Assert.AreEqual(0, newWebhookResourceTypes.Count);

            Assert.IsTrue(resources.All(r => r.Events.All(e => e.Name.EnumValue.HasValue)));
            var webhookEvents = new HashSet<string>(resources.SelectMany(r => r.Events.Select(e => e.Name.Value)));
            var existingWebhookEvents = new HashSet<string>(Enums.GetMembers<WebhookResourceEvent>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookEvents = webhookEvents.Except(existingWebhookEvents).ToList();
            Assert.AreEqual(0, newWebhookEvents.Count);

            Assert.IsTrue(resources.All(r => r.Status.EnumValue.HasValue));
            var webhookStatuses = new HashSet<string>(resources.Select(r => r.Status.Value));
            var existingWebhookStatuses = new HashSet<string>(Enums.GetMembers<WebhookResourceStatus>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newWebhookStatuses = webhookStatuses.Except(existingWebhookStatuses).ToList();
            Assert.AreEqual(0, newWebhookStatuses.Count);
        }

        [TestMethod]
        public async Task Webhook_GetResource()
        {
            var client = await GetTestClientAsync();
            var resources = await client.Webhook.GetResourcesAsync();

            foreach (var resource in resources)
            {
                var retrievedResource = await client.Webhook.GetResourceAsync(resource.Name);
                Assert.AreEqual(resource.ToString(), retrievedResource.ToString());
            }
        }

        [TestMethod]
        public void WebhookSubscription_Serialization()
        {
            var subscription = new WebhookSubscription("https://google.com", WebhookResourceType.Loan, new[] { WebhookResourceEvent.Create, WebhookResourceEvent.Update }) { ClientId = "1234567890" };
            Assert.AreEqual(@"{""events"":[""create"",""update""],""endpoint"":""https://google.com"",""resource"":""Loan""}", subscription.ToJson());
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
            var subscription = new WebhookSubscription(endpoint, WebhookResourceType.Loan, new[] { WebhookResourceEvent.Change });
            subscription.Filters.Attributes.Add("/milestoneLogs/*/doneIndicator");
            var subscriptionId = await client.Webhook.CreateSubscriptionAsync(subscription);
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            try
            {
                var retrievedSubscription = await client.Webhook.GetSubscriptionAsync(subscriptionId);
                Assert.AreEqual(subscription.Endpoint, retrievedSubscription.Endpoint);
                Assert.AreEqual(subscription.Resource.Value, retrievedSubscription.Resource.Value);
                CollectionAssert.AreEquivalent(subscription.Events.Select(e => e.Value).ToList(), retrievedSubscription.Events.Select(e => e.Value).ToList());
                CollectionAssert.AreEquivalent(subscription.Filters.Attributes.ToList(), retrievedSubscription.Filters.Attributes.ToList());
            }
            finally
            {
                await client.Webhook.DeleteSubscriptionAsync(subscriptionId);
            }
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

        [TestMethod]
        public async Task Webhook_FilterAttributes()
        {
            var client = await GetTestClientAsync();
            var subscriptions = await client.Webhook.GetSubscriptionsAsync();
            const string endpoint = "https://abc123mortgage.com";
            var existingSubscription = subscriptions.FirstOrDefault(s => s.Endpoint == endpoint);
            if (existingSubscription != null)
            {
                await client.Webhook.DeleteSubscriptionAsync(existingSubscription.SubscriptionId);
            }
            var subscription = new WebhookSubscription(endpoint, WebhookResourceType.Loan, new[] { WebhookResourceEvent.Change });
            var attributes = subscription.Filters.Attributes;
            var fieldDescriptors = client.Loans.FieldDescriptors;
            foreach (var pair in LoanFieldDescriptors.StandardFields.Skip(new Random().Next(10000)).Where(p => !p.Value.MultiInstance && p.Value.AttributePath.IndexOf('[') < 0).Take(10))
            {
                attributes.Add(pair.Value.AttributePath);
            }
            var subscriptionId = await client.Webhook.CreateSubscriptionAsync(subscription);
            Assert.IsFalse(string.IsNullOrEmpty(subscriptionId));
            try
            {
                var retrievedSubscription = await client.Webhook.GetSubscriptionAsync(subscriptionId);
                Assert.AreEqual(subscription.Endpoint, retrievedSubscription.Endpoint);
                Assert.AreEqual(subscription.Resource.Value, retrievedSubscription.Resource.Value);
                CollectionAssert.AreEquivalent(subscription.Events.Select(e => e.Value).ToList(), retrievedSubscription.Events.Select(e => e.Value).ToList());
                CollectionAssert.AreEquivalent(subscription.Filters.Attributes.ToList(), retrievedSubscription.Filters.Attributes.ToList());
            }
            finally
            {
                await client.Webhook.DeleteSubscriptionAsync(subscriptionId);
            }
        }
    }
}