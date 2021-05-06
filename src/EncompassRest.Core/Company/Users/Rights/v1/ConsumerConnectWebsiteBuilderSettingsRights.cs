namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ConsumerConnectWebsiteBuilderSettingsRights
    /// </summary>
    public sealed class ConsumerConnectWebsiteBuilderSettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _webAdmin;
        private DirtyValue<bool?>? _webContent;

        /// <summary>
        /// ConsumerConnectWebsiteBuilderSettingsRights WebAdmin
        /// </summary>
        public bool? WebAdmin { get => _webAdmin; set => SetField(ref _webAdmin, value); }

        /// <summary>
        /// ConsumerConnectWebsiteBuilderSettingsRights WebContent
        /// </summary>
        public bool? WebContent { get => _webContent; set => SetField(ref _webContent, value); }
    }
}