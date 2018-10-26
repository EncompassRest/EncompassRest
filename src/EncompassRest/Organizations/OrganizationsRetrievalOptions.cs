using EncompassRest.Utilities;

namespace EncompassRest.Organizations
{
    public sealed class OrganizationsRetrievalOptions
    {
        public StringEnumValue<OrganizationView> View { get; set; }

        public string ParentId { get; set; }

        public int? Start { get; set; }

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