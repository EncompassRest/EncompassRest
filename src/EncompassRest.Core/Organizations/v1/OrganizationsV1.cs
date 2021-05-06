using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Organizations Apis
    /// </summary>
    public interface IOrganizationsV1 : IApiObject
    {
        /// <summary>
        /// Gets the organization with the specified <paramref name="orgId"/> using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Organization> GetOrganizationAsync(string orgId, string? view, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the children of the organization with the specified <paramref name="orgId"/> using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="options">The organization children retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<OrganizationReference>> GetOrganizationChildrenAsync(string orgId, OrganizationChildrenRetrievalOptions? options, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the children of the organization with the specified <paramref name="orgId"/> as raw json.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetOrganizationChildrenRawAsync(string orgId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the organization with the specified <paramref name="orgId"/> as raw json.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetOrganizationRawAsync(string orgId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets organizations using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The organizations retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<Organization>> GetOrganizationsAsync(OrganizationsRetrievalOptions? options, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets organizations as raw json.
        /// </summary>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetOrganizationsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the root organization using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Organization> GetRootOrganizationAsync(string? view, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the root organization as raw json.
        /// </summary>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRootOrganizationRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class OrganizationsV1 : ApiObject, IOrganizationsV1
    {
        internal OrganizationsV1(EncompassRestClient client)
            : base(client, "encompass/v1/organizations")
        {
        }

        public Task<List<Organization>> GetOrganizationsAsync(OrganizationsRetrievalOptions? options, CancellationToken cancellationToken = default) => GetDirtyListAsync<Organization>(null, options?.GetQueryParameters().ToString(), nameof(GetOrganizationsAsync), null, cancellationToken);

        public Task<string> GetOrganizationsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetOrganizationsRawAsync), null, cancellationToken);

        public Task<Organization> GetRootOrganizationAsync(string? view, CancellationToken cancellationToken = default) => GetOrganizationAsync("root", view, cancellationToken);

        public Task<string> GetRootOrganizationRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetOrganizationRawAsync("root", queryString, cancellationToken);

        public Task<Organization> GetOrganizationAsync(string orgId, string? view, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(view))
            {
                queryParameters.Add("view", view);
            }
            return GetDirtyAsync<Organization>(orgId, queryParameters.ToString(), orgId == "root" ? nameof(GetRootOrganizationAsync) : nameof(GetOrganizationAsync), orgId, cancellationToken);
        }

        public Task<string> GetOrganizationRawAsync(string orgId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetRawAsync(orgId, queryString, orgId == "root" ? nameof(GetRootOrganizationRawAsync) : nameof(GetOrganizationRawAsync), orgId, cancellationToken);
        }

        public Task<List<OrganizationReference>> GetOrganizationChildrenAsync(string orgId, OrganizationChildrenRetrievalOptions? options, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetDirtyListAsync<OrganizationReference>($"{orgId}/children", options?.GetQueryParameters().ToString(), nameof(GetOrganizationChildrenAsync), orgId, cancellationToken);
        }

        public Task<string> GetOrganizationChildrenRawAsync(string orgId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(orgId, nameof(orgId));

            return GetRawAsync($"{orgId}/children", queryString, nameof(GetOrganizationChildrenRawAsync), orgId, cancellationToken);
        }
    }
}