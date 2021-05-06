namespace EncompassRest.Webhook
{
    /// <summary>
    /// The Webhook Apis.
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