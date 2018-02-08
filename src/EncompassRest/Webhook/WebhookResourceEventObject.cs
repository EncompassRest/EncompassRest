namespace EncompassRest.Webhook
{
    public sealed class WebhookResourceEventObject : ExtensibleObject
    {
        public StringEnumValue<WebhookResourceEvent> Name { get; set; }
    }
}