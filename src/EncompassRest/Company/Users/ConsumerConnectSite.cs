namespace EncompassRest.Company.Users
{
    /// <summary>
    /// ConsumerConnectSite
    /// </summary>
    public sealed class ConsumerConnectSite : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool> _useParentInformation;
        private DirtyValue<string> _url;
        private DirtyValue<string> _siteId;

        /// <summary>
        /// ConsumerConnectSite UseParentInformation
        /// </summary>
        public bool UseParentInformation { get => _useParentInformation; set => SetField(ref _useParentInformation, value); }

        /// <summary>
        /// ConsumerConnectSite Url
        /// </summary>
        public string Url { get => _url; set => SetField(ref _url, value); }

        /// <summary>
        /// ConsumerConnectSite SiteId
        /// </summary>
        public string SiteId { get => _siteId; set => SetField(ref _siteId, value); }

        [IdPropertyName(nameof(SiteId))]
        string IIdentifiable.Id { get => SiteId; set => SiteId = value; }
    }
}