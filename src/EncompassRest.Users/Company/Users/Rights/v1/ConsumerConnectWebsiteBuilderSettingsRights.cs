namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ConsumerConnectWebsiteBuilderSettingsRights
    /// </summary>
    public sealed class ConsumerConnectWebsiteBuilderSettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ConsumerConnectWebsiteBuilderSettingsRights WebAdmin
        /// </summary>
        public bool? WebAdmin { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ConsumerConnectWebsiteBuilderSettingsRights WebContent
        /// </summary>
        public bool? WebContent { get => GetValue<bool?>(); set => SetValue(value); }
    }
}