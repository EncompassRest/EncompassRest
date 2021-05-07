using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Settings.Personas.v1
{
    public static class PersonasExtensions
    {
        public static IPersonasV1? V1 { get; set; }

        private static IPersonasV1 GetV1(IPersonas personas)
        {
            var v1 = V1;
            if (personas is Personas p)
            {
                v1 = (IPersonasV1)p.ExtensionData.GetOrAdd("v1", k => new PersonasV1(p.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(personas, nameof(personas));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Persona> GetPersonaAsync(this IPersonas personas, string id, CancellationToken cancellationToken = default) => GetPersonaAsync(personas, id, (IEnumerable<string>?)null, cancellationToken);

        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="categories">The Persona Categories.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Persona> GetPersonaAsync(this IPersonas personas, string id, IEnumerable<PersonaCategory>? categories, CancellationToken cancellationToken = default) => GetPersonaAsync(personas, id, categories?.Select(c => c.Validate(nameof(categories)).GetValue()!), cancellationToken);

        /// <summary>
        /// Returns details for a specified persona.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="categories">The Persona Categories.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Persona> GetPersonaAsync(this IPersonas personas, string id, IEnumerable<string>? categories, CancellationToken cancellationToken = default) => GetV1(personas).GetPersonaAsync(id, categories, cancellationToken);

        /// <summary>
        /// Returns details for a specified persona as raw json.
        /// </summary>
        /// <param name="id">Unique Identifier of the persona.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetPersonaRawAsync(this IPersonas personas, string id, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(personas).GetPersonaRawAsync(id, queryString, cancellationToken);

        /// <summary>
        /// Returns the list of all personas on the Encompass instance.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<Persona>> GetPersonasAsync(this IPersonas personas, CancellationToken cancellationToken = default) => GetV1(personas).GetPersonasAsync(cancellationToken);

        /// <summary>
        /// Returns the list of all personas on the Encompass instance as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetPersonasRawAsync(this IPersonas personas, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(personas).GetPersonasRawAsync(queryString, cancellationToken);
    }
}