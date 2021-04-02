using System.Collections.Generic;

namespace EncompassApi.Configuration
{
    /// <summary>
    /// Option configuration for HttpClient compression handler
    /// </summary>
    public class HttpClientCompressionHandlerOptions
    {
        /// <summary>
        /// Decopression methods
        /// </summary>
        /// <example>System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate</example>
        public IEnumerable<System.Net.DecompressionMethods> DecompressionMethods { get; set; }

        /// <summary>
        /// Allow to auto decompress if set to true
        /// The decompression will be set to DecompressionMethods property
        /// </summary>
        public bool EnableAutoDecompression { get; set; }
    }
}
