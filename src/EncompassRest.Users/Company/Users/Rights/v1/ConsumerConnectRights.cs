using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ConsumerConnectRights
    /// </summary>
    public sealed class ConsumerConnectRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ConsumerConnectRights ConsumerConnectWebsiteBuilderSettings
        /// </summary>
        [JsonProperty("cosumerConnectWebsiteBuilderSettings")]
        [AllowNull]
        public ConsumerConnectWebsiteBuilderSettingsRights ConsumerConnectWebsiteBuilderSettings { get => GetEntity<ConsumerConnectWebsiteBuilderSettingsRights>(); set => SetEntity(value); }
    }
}