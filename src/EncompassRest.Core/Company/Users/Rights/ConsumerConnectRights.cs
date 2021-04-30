using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ConsumerConnectRights
    /// </summary>
    public sealed class ConsumerConnectRights : DirtyExtensibleObject
    {
        private ConsumerConnectWebsiteBuilderSettingsRights? _cosumerConnectWebsiteBuilderSettings;

        /// <summary>
        /// ConsumerConnectRights ConsumerConnectWebsiteBuilderSettings
        /// </summary>
        [JsonProperty("cosumerConnectWebsiteBuilderSettings")]
        [AllowNull]
        public ConsumerConnectWebsiteBuilderSettingsRights ConsumerConnectWebsiteBuilderSettings { get => GetField(ref _cosumerConnectWebsiteBuilderSettings); set => SetField(ref _cosumerConnectWebsiteBuilderSettings, value); }
    }
}