using System;
using EncompassRest.Utilities;

namespace EncompassRest.Webhook.v1
{
    /// <summary>
    /// WebhookEventOptions
    /// </summary>
    public sealed class WebhookEventOptions : ExtensibleObject
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        public StringEnumValue<WebhookResourceType> ResourceType { get; set; }

        /// <summary>
        /// The unique identifier of the resource the event is associated with (that is, the loan GUID).
        /// </summary>
        public string? ResourceId { get; set; }

        /// <summary>
        /// The type of event to return.
        /// </summary>
        public StringEnumValue<WebhookResourceEvent> EventType { get; set; }

        /// <summary>
        /// The unique identifier of a subscription. If specified, the event history of the subscription will be returned.
        /// </summary>
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// Start time (in ISO8601 format) from which to retrieve events. If a startTime is not specified, the previous day will be used.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// End time (in ISO8601 format) from which to retrieve events. If an endTime is not specified, the current time will be used.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Starting index or record number from which to retrieve events. The default is 1. Note that if start and limit are not specified, the first 100 events will be returned.
        /// </summary>
        public int? Start { get; set; }

        /// <summary>
        /// The maximum number of events to return in a page. The default value is 100. The maximum value is limited to 100. Note that if start and limit are not specified, the first 100 events will be returned.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// WebhookEventOptions Status
        /// </summary>
        public StringEnumValue<WebhookStatus> Status { get; set; }

        internal QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(ResourceType))
            {
                queryParameters.Add("resourceType", ResourceType);
            }
            if (!string.IsNullOrEmpty(ResourceId))
            {
                queryParameters.Add("resourceId", ResourceId);
            }
            if (!string.IsNullOrEmpty(EventType))
            {
                queryParameters.Add("eventType", EventType);
            }
            if (!string.IsNullOrEmpty(SubscriptionId))
            {
                queryParameters.Add("subscriptionId", SubscriptionId);
            }
            if (StartTime != null)
            {
                queryParameters.Add("startTime", StartTime?.ToString("o"));
            }
            if (EndTime != null)
            {
                queryParameters.Add("endTime", EndTime?.ToString("o"));
            }
            if (Start != null)
            {
                queryParameters.Add("start", Start.ToString());
            }
            if (Limit != null)
            {
                queryParameters.Add("limit", Limit.ToString());
            }
            if (!string.IsNullOrEmpty(Status))
            {
                queryParameters.Add("status", Status);
            }
            return queryParameters;
        }
    }
}