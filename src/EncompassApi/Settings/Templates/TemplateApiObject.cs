using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Utilities;

namespace EncompassApi.Settings.Templates
{
    /// <summary>
    /// The base interface for Template Apis.
    /// </summary>
    public interface ITemplateApiObject : IApiObject
    {
        /// <summary>
        /// Retrieves a list of template files from the specified template path.
        /// </summary>
        /// <param name="path">Path to where the template files are located.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<EntityReference>> GetTemplateFilesAsync(string path, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of template files from the specified template path as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request. This should include a path parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetTemplateFilesRawAsync(string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of template folders from the specified location.
        /// </summary>
        /// <param name="path">Location of the loan template folder. The default parent path starts with public or personal.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<EntityReference>> GetTemplateFoldersAsync(string path, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of template folders from the specified location as raw json.
        /// </summary>
        /// <param name="path">Location of the loan template folder. The default parent path starts with public or personal.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetTemplateFoldersRawAsync(string path, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The base class for Template Apis.
    /// </summary>
    public abstract class TemplateApiObject : ApiObject, ITemplateApiObject
    {
        internal TemplateApiObject(EncompassApiClient client, string baseApiPath)
            : base(client, $"encompass/v1/settings/templates{baseApiPath?.PrecedeWith("/")}")
        {
        }

        /// <inheritdoc/>
        public Task<List<EntityReference>> GetTemplateFoldersAsync(string path, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            return GetAsync<List<EntityReference>>($"folders{path.PrecedeWith("/")}", null, nameof(GetTemplateFoldersAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetTemplateFoldersRawAsync(string path, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            return GetRawAsync($"folders{path.PrecedeWith("/")}", queryString, nameof(GetTemplateFoldersRawAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<List<EntityReference>> GetTemplateFilesAsync(string path, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            var queryParameters = new QueryParameters(
                new QueryParameter("path", path));

            return GetAsync<List<EntityReference>>("items", queryParameters.ToString(), nameof(GetTemplateFilesAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetTemplateFilesRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync("items", queryString, nameof(GetTemplateFilesRawAsync), null, cancellationToken);
        }
    }
}