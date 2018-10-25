using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// Users retrieval options.
    /// </summary>
    public sealed class UsersRetrievalOptions
    {
        /// <summary>
        /// Optionally include the email signature in the response object.
        /// </summary>
        public bool? ViewEmailSignature { get; set; }

        /// <summary>
        /// Optionally filters results on group id.
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// Optionally filters results on role id.
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// Optionally filters results on persona id.
        /// </summary>
        public string PersonaId { get; set; }

        /// <summary>
        /// Optionally filters results on organization id.
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// Optionally filters results on users' names containing this value.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Optional start index.
        /// </summary>
        public int? Start { get; set; }

        /// <summary>
        /// Optional limit of number of users to return.
        /// </summary>
        public int? Limit { get; set; }

        internal QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            if (ViewEmailSignature.HasValue)
            {
                queryParameters.Add("viewEmailSignature", ViewEmailSignature.ToString().ToLower());
            }
            if (!string.IsNullOrEmpty(GroupId))
            {
                queryParameters.Add("groupId", GroupId);
            }
            if (!string.IsNullOrEmpty(RoleId))
            {
                queryParameters.Add("roleId", RoleId);
            }
            if (!string.IsNullOrEmpty(PersonaId))
            {
                queryParameters.Add("personaId", PersonaId);
            }
            if (!string.IsNullOrEmpty(OrganizationId))
            {
                queryParameters.Add("organizationId", OrganizationId);
            }
            if (!string.IsNullOrEmpty(UserName))
            {
                queryParameters.Add("userName", UserName);
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