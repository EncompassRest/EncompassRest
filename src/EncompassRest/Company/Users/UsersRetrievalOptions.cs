using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// Users retrieval options.
    /// </summary>
    public sealed class UsersRetrievalOptions
    {
        /// <summary>
        /// Indicates whether the email signature should be returned as part of the response.
        /// </summary>
        public bool? ViewEmailSignature { get; set; }

        /// <summary>
        /// List users who belong to the specified User Group ID.
        /// </summary>
        public string GroupId { get; set; }

        /// <summary>
        /// List users with the specified Role ID.
        /// </summary>
        public string RoleId { get; set; }

        /// <summary>
        /// List users with the specified User Persona ID.
        /// </summary>
        public string PersonaId { get; set; }

        /// <summary>
        /// List users who belong to the specified organization ID.
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// List users with the specified string in their name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Starting index or record number from which to retrieve the contacts. The default is 1.
        /// </summary>
        public int? Start { get; set; }

        /// <summary>
        /// The maximum number of records to return in a page. Response size is limited to 6 MB and is recalculated if the response exceeds 6 MB. The default value is 1000. The maximum value is limited to 10000.
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