using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Organizations Apis
    /// </summary>
    public sealed class Organizations : ApiObject
    {
        internal Organizations(EncompassRestClient client)
            : base(client, "encompass/v1/organizations")
        {
        }

        public Task<List<Organization>> GetOrganizationsAsync(CancellationToken cancellationToken = default) => GetOrganizationsAsync(null, cancellationToken);

        public Task<List<Organization>> GetOrganizationsAsync(OrganizationsRetrievalOptions options, CancellationToken cancellationToken = default) => GetDirtyListAsync<Organization>(null, options?.GetQueryParameters().ToString(), nameof(GetOrganizationsAsync), null, cancellationToken);

        public Task<string> GetOrganizationsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetOrganizationsRawAsync), null, cancellationToken);

        public Task<Organization> GetRootOrganizationAsync(CancellationToken cancellationToken = default) => GetRootOrganizationAsync(null, cancellationToken);

        public Task<Organization> GetRootOrganizationAsync(OrganizationView view, CancellationToken cancellationToken = default) => GetRootOrganizationAsync(view.Validate(nameof(view)).GetValue(), cancellationToken);

        public Task<Organization> GetRootOrganizationAsync(string view, CancellationToken cancellationToken = default) => GetOrganizationAsync("root", view, cancellationToken);

        public Task<string> GetRootOrganizationRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetOrganizationRawAsync("root", queryString, cancellationToken);

        public Task<Organization> GetOrganizationAsync(string orgId, CancellationToken cancellationToken = default) => GetOrganizationAsync(orgId, null, cancellationToken);

        public Task<Organization> GetOrganizationAsync(string orgId, OrganizationView view, CancellationToken cancellationToken = default) => GetOrganizationAsync(orgId, view.Validate(nameof(view)).GetValue(), cancellationToken);

        public Task<Organization> GetOrganizationAsync(string orgId, string view, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(view))
            {
                queryParameters.Add("view", view);
            }
            return GetDirtyAsync<Organization>(orgId, queryParameters.ToString(), orgId == "root" ? nameof(GetRootOrganizationAsync) : nameof(GetOrganizationAsync), orgId, cancellationToken);
        }

        public Task<string> GetOrganizationRawAsync(string orgId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetRawAsync(orgId, queryString, orgId == "root" ? nameof(GetRootOrganizationRawAsync) : nameof(GetOrganizationRawAsync), orgId, cancellationToken);
        }

        public Task<List<OrganizationReference>> GetOrganizationChildrenAsync(string orgId, CancellationToken cancellationToken = default) => GetOrganizationChildrenAsync(orgId, null, cancellationToken);

        public Task<List<OrganizationReference>> GetOrganizationChildrenAsync(string orgId, OrganizationChildrenRetrievalOptions options, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetDirtyListAsync<OrganizationReference>($"{orgId}/children", options?.GetQueryParameters().ToString(), nameof(GetOrganizationChildrenAsync), orgId, cancellationToken);
        }

        public Task<string> GetOrganizationChildrenRawAsync(string orgId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetRawAsync($"{orgId}/children", queryString, nameof(GetOrganizationChildrenRawAsync), orgId, cancellationToken);
        }
    }
}