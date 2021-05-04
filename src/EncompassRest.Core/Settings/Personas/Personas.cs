using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// The Personas Apis.
    /// </summary>
    public interface IPersonas : IApiObject
    {
        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Persona> GetPersonaAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="categories">The Persona Categories.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Persona> GetPersonaAsync(string id, IEnumerable<PersonaCategory>? categories, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="categories">The Persona Categories.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Persona> GetPersonaAsync(string id, IEnumerable<string>? categories, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns details for a specified persona as raw json.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetPersonaRawAsync(string id, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of all personas on the Encompass instance.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<Persona>> GetPersonasAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of all personas on the Encompass instance as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetPersonasRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class Personas : ApiObject, IPersonas
    {
        internal Personas(EncompassRestClient client)
            : base(client, "encompass/v1/settings/personas")
        {
        }

        public Task<List<Persona>> GetPersonasAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<Persona>(null, null, nameof(GetPersonasAsync), null, cancellationToken);

        public Task<string> GetPersonasRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetPersonasRawAsync), null, cancellationToken);

        public Task<Persona> GetPersonaAsync(string id, CancellationToken cancellationToken = default) => GetPersonaAsync(id, (IEnumerable<string>?)null, cancellationToken);

        public Task<Persona> GetPersonaAsync(string id, IEnumerable<PersonaCategory>? categories, CancellationToken cancellationToken = default) => GetPersonaAsync(id, categories?.Select(c => c.Validate(nameof(categories)).GetValue()!), cancellationToken);

        public Task<Persona> GetPersonaAsync(string id, IEnumerable<string>? categories, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));

            var queryParams = new QueryParameters();
            if (categories != null)
            {
                queryParams.Add("categories", string.Join(",", categories));
            }
            return GetDirtyAsync<Persona>(id, queryParams.ToString(), nameof(GetPersonaAsync), id, cancellationToken);
        }

        public Task<string> GetPersonaRawAsync(string id, string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(id, queryString, nameof(GetPersonaRawAsync), id, cancellationToken);
    }
}