using EncompassRest.Utilities;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Organizations retrieval options.
    /// </summary>
    public sealed class OrganizationsRetrievalOptions
    {
        /// <summary>
        /// The view of the organizations to get.
        /// </summary>
        public StringEnumValue<OrganizationView> View { get; set; }

        /// <summary>
        /// Returns organizations for the specified parent ID.
        /// </summary>
        public string? ParentId { get; set; }

        /// <summary>
        /// Starting index or record number from which to retrieve the organization details. The default is 1.
        /// </summary>
        public int? Start { get; set; }

        /// <summary>
        /// The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.
        /// </summary>
        public int? Limit { get; set; }

        internal QueryParameters GetQueryParameters()
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(View))
            {
                queryParameters.Add("view", View);
            }
            if (!string.IsNullOrEmpty(ParentId))
            {
                queryParameters.Add("parentId", ParentId);
            }
            if (Start.HasValue)
            {
                queryParameters.Add("start", Start.ToString());
            }
            if (Limit.HasValue)
            {
                queryParameters.Add("limit", Limit.ToString());
            }
            return queryParameters;
        }
    }
}