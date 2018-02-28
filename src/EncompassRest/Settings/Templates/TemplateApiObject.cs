using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Templates
{
    public abstract class TemplateApiObject : ApiObject
    {
        internal TemplateApiObject(EncompassRestClient client, string baseApiPath)
            : base(client, $"encompass/v1/settings/templates{baseApiPath?.PrecedeWith("/")}")
        {
        }

        public Task<List<EntityReference>> GetTemplateFoldersAsync(string path, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            return GetAsync<List<EntityReference>>($"folders{path.PrecedeWith("/")}", null, nameof(GetTemplateFoldersAsync), null, cancellationToken);
        }

        public Task<string> GetTemplateFoldersRawAsync(string path, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            return GetRawAsync($"folders{path.PrecedeWith("/")}", queryString, nameof(GetTemplateFoldersRawAsync), null, cancellationToken);
        }

        public Task<List<EntityReference>> GetTemplateFilesAsync(string path, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(path, nameof(path));

            var queryParameters = new QueryParameters(
                new QueryParameter("path", path));

            return GetAsync<List<EntityReference>>("items", queryParameters.ToString(), nameof(GetTemplateFilesAsync), null, cancellationToken);
        }

        public Task<string> GetTemplateFilesRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync("items", queryString, nameof(GetTemplateFilesRawAsync), null, cancellationToken);
        }
    }
}