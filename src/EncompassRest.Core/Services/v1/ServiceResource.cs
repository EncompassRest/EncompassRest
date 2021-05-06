namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceResource
    /// </summary>
    public sealed class ServiceResource : ExtensibleObject
    {
        /// <summary>
        /// The unique identifier for an individual resource.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The MIME type/format of the resource.
        /// </summary>
        public string? MimeType { get; set; }

        /// <summary>
        /// The publicly accessible URL endpoint to access/retrieve the resource. The URL generated is temporarily accessible, with a time to expiration of 300 seconds (5 minutes) from when the API call is made.
        /// </summary>
        public string? Url { get; set; }
    }
}