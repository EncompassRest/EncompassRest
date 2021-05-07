namespace EncompassRest.Webhook
{
    /// <summary>
    /// The Webhook Apis exposed as extension methods
    /// within the EncompassRest.Webhook.v1 namespace.
    /// </summary>
    public interface IWebhook : IApiObject
    {
    }

    internal sealed class Webhook : ApiObject, IWebhook
    {
        internal Webhook(EncompassRestClient client)
            : base(client, "webhook/v1")
        {
        }
    }
}