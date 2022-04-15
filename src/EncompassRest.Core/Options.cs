using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// A base class for query parameter options.
    /// </summary>
    public abstract class Options
    {
        private Dictionary<string, string>? _additionalQueryParameters;

        /// <summary>
        /// Allows specifying additional query parameters not directly exposed from the options similar to ExtensionData.
        /// </summary>
        public Dictionary<string, string> AdditionalQueryParameters
        {
            get => _additionalQueryParameters ??= new Dictionary<string, string>();
            set => _additionalQueryParameters = value;
        }

        internal Options()
        {
        }

        internal virtual QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            var additionalQueryParameters = _additionalQueryParameters;
            if (additionalQueryParameters != null)
            {
                foreach (var pair in additionalQueryParameters)
                {
                    queryParameters.Add(pair.Key, pair.Value);
                }
            }
            return queryParameters;
        }

        /// <summary>
        /// Serializes the options as query parameters.
        /// </summary>
        /// <returns>The options query string representation.</returns>
        public sealed override string ToString() => ToQueryParameters().ToString();
    }
}