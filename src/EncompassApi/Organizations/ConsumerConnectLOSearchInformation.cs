using EncompassApi.Company;

namespace EncompassApi.Organizations
{
    /// <summary>
    /// Object containing information about Encompass Consumer Connect Loan Officer Search settings.
    /// </summary>
    /// <remarks>
    /// This applies if an Encompass Consumer Connect website is associated with the organization. If a website is associated with the organization, the organization will be listed in the website's search results for loan officers.
    /// </remarks>
    public sealed class ConsumerConnectLOSearchInformation : ParentInformation
    {
        private DirtyValue<bool?>? _showInSearch;
        private DirtyValue<string?>? _name;

        /// <summary>
        /// Indicates whether the organization is displayed in Encompass Consumer Connect search.
        /// </summary>
        public bool? ShowInSearch { get => _showInSearch; set => SetField(ref _showInSearch, value); }

        /// <summary>
        /// The name that will appear in the Encompass Consumer Connect search for this organization.
        /// </summary>
        public string? Name { get => _name; set => SetField(ref _name, value); }
    }
}