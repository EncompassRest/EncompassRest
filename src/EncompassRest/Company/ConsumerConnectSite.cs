namespace EncompassRest.Company
{
    /// <summary>
    /// Object containing information about the associated Encompass Consumer Connect website.
    /// </summary>
    public sealed class ConsumerConnectSite : ParentInformation, IIdentifiable
    {
        private DirtyValue<string?>? _url;
        private DirtyValue<string?>? _siteId;

        /// <summary>
        /// The Encompass Consumer Connect site URL.
        /// </summary>
        public string? Url { get => _url; set => SetField(ref _url, value); }

        /// <summary>
        /// The Encompass Consumer Connect site ID.
        /// </summary>
        public string? SiteId { get => _siteId; set => SetField(ref _siteId, value); }

        [IdPropertyName(nameof(SiteId))]
        string? IIdentifiable.Id { get => SiteId; set => SiteId = value; }
    }
}