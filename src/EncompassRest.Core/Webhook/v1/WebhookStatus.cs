namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookStatus
    /// </summary>
    public enum WebhookStatus
    {
        /// <summary>
        /// EventReceived
        /// </summary>
        EventReceived = 0,
        /// <summary>
        /// SubscriptionMatched
        /// </summary>
        SubscriptionMatched = 1,
        /// <summary>
        /// NotificationDelivered
        /// </summary>
        NotificationDelivered = 2,
        /// <summary>
        /// DeliveryAttempted
        /// </summary>
        DeliveryAttempted = 3
    }
}