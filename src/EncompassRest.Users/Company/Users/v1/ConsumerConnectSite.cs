namespace EncompassRest.Company.v1
{
    /// <summary>
    /// Object containing information about the associated Encompass Consumer Connect website.
    /// </summary>
    public sealed class ConsumerConnectSite : ParentInformation, IIdentifiable
    {
        /// <summary>
        /// The Encompass Consumer Connect site URL.
        /// </summary>
        public string? Url { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The Encompass Consumer Connect site ID.
        /// </summary>
        public string? SiteId { get => GetValue<string?>(); set => SetValue(value); }

        [IdPropertyName(nameof(SiteId))]
        string? IIdentifiable.Id { get => SiteId; set => SiteId = value; }
    }
}