using EncompassRest.Utilities;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Organization children retrieval options.
    /// </summary>
    public sealed class OrganizationChildrenRetrievalOptions
    {
        /// <summary>
        /// When set to <c>true</c>, the response includes references to all child organizations and users under this organization's hierarchy. 
        /// When set to <c>false</c>, only the immediate child organizations and its users will be included in the response.
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// By default, both organizations and users are included in the response. To request only organizations, set type to organization. To request only users, set type to user.
        /// </summary>
        public StringEnumValue<OrganizationChildType> Type { get; set; }

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
            if (Recursive.HasValue)
            {
                queryParameters.Add("recursive", Recursive.ToString().ToLower());
            }
            if (!string.IsNullOrEmpty(Type))
            {
                queryParameters.Add("type", Type);
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