using EncompassRest.Utilities;

namespace EncompassRest.Organizations
{
    public sealed class OrganizationChildrenRetrievalOptions
    {
        public bool? Recursive { get; set; }

        public StringEnumValue<OrganizationChildType> Type { get; set; }

        public int? Start { get; set; }

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