using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Organizations.v1
{
    public static class OrganizationsExtensions
    {
        public static IOrganizationsV1? V1 { get; set; }

        private static IOrganizationsV1 GetV1(IOrganizations organizations)
        {
            var v1 = V1;
            if (organizations is Organizations o)
            {
                v1 = (IOrganizationsV1)o.ExtensionData.GetOrAdd("v1", k => new OrganizationsV1(o.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(organizations, nameof(organizations));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets a summary view of the organization with the specified <paramref name="orgId"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetOrganizationAsync(this IOrganizations organizations, string orgId, CancellationToken cancellationToken = default) => GetOrganizationAsync(organizations, orgId, view: null, cancellationToken);

        /// <summary>
        /// Gets the organization with the specified <paramref name="orgId"/> using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetOrganizationAsync(this IOrganizations organizations, string orgId, OrganizationView view, CancellationToken cancellationToken = default) => GetOrganizationAsync(organizations, orgId, view.Validate(nameof(view)).GetValue(), cancellationToken);

        /// <summary>
        /// Gets the organization with the specified <paramref name="orgId"/> using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetOrganizationAsync(this IOrganizations organizations, string orgId, string? view, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationAsync(orgId, view, cancellationToken);

        /// <summary>
        /// Gets the children of the organization with the specified <paramref name="orgId"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<OrganizationReference>> GetOrganizationChildrenAsync(this IOrganizations organizations, string orgId, CancellationToken cancellationToken = default) => GetOrganizationChildrenAsync(organizations, orgId, options: null, cancellationToken);

        /// <summary>
        /// Gets the children of the organization with the specified <paramref name="orgId"/> using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="options">The organization children retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<OrganizationReference>> GetOrganizationChildrenAsync(this IOrganizations organizations, string orgId, OrganizationChildrenRetrievalOptions? options, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationChildrenAsync(orgId, options, cancellationToken);

        /// <summary>
        /// Gets the children of the organization with the specified <paramref name="orgId"/> as raw json.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetOrganizationChildrenRawAsync(this IOrganizations organizations, string orgId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationChildrenRawAsync(orgId, queryString, cancellationToken);

        /// <summary>
        /// Gets the organization with the specified <paramref name="orgId"/> as raw json.
        /// </summary>
        /// <param name="orgId">The organization's id.</param>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetOrganizationRawAsync(this IOrganizations organizations, string orgId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationRawAsync(orgId, queryString, cancellationToken);

        /// <summary>
        /// Gets a summary view of all organizations.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<Organization>> GetOrganizationsAsync(this IOrganizations organizations, CancellationToken cancellationToken = default) => GetOrganizationsAsync(organizations, options: null, cancellationToken);

        /// <summary>
        /// Gets organizations using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The organizations retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<Organization>> GetOrganizationsAsync(this IOrganizations organizations, OrganizationsRetrievalOptions? options, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationsAsync(options, cancellationToken);

        /// <summary>
        /// Gets organizations as raw json.
        /// </summary>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetOrganizationsRawAsync(this IOrganizations organizations, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(organizations).GetOrganizationsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Gets a summary view of the root organization.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetRootOrganizationAsync(this IOrganizations organizations, CancellationToken cancellationToken = default) => GetRootOrganizationAsync(organizations, view: null, cancellationToken);

        /// <summary>
        /// Gets the root organization using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetRootOrganizationAsync(this IOrganizations organizations, OrganizationView view, CancellationToken cancellationToken = default) => GetRootOrganizationAsync(organizations, view.Validate(nameof(view)).GetValue(), cancellationToken);

        /// <summary>
        /// Gets the root organization using the specified <paramref name="view"/>.
        /// </summary>
        /// <param name="view">The view of the organization to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Organization> GetRootOrganizationAsync(this IOrganizations organizations, string? view, CancellationToken cancellationToken = default) => GetV1(organizations).GetRootOrganizationAsync(view, cancellationToken);

        /// <summary>
        /// Gets the root organization as raw json.
        /// </summary>
        /// <param name="queryString">The query string to send in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetRootOrganizationRawAsync(this IOrganizations organizations, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(organizations).GetRootOrganizationRawAsync(queryString, cancellationToken);
    }
}