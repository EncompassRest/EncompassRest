using EncompassRest.Utilities;
using EncompassRest.Webhook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class WebhookTests
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
    }
}