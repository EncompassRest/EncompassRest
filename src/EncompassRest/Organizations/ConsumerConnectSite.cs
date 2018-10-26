namespace EncompassRest.Organizations
{
    /// <summary>
    /// ConsumerConnectSite
    /// </summary>
    public sealed class ConsumerConnectSite : ParentInformation, IIdentifiable
    {
        private DirtyValue<string> _url;
        private DirtyValue<string> _siteId;

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