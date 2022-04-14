using EncompassRest.Utilities;

namespace EncompassRest.Loans.Documents.v3
{
    /// <summary>
    /// The document retrieval options.
    /// </summary>
    public sealed class DocumentRetrievalOptions
    {
        /// <summary>
        /// When set to <c>true</c> only documents with active attachments are returned.
        /// </summary>
        public bool? RequireActiveAttachments { get; set; }

        /// <summary>
        /// When set to <c>true</c>, the response includes documents marked as removed.
        /// </summary>
        public bool? IncludeRemoved { get; set; }

        internal QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            if (RequireActiveAttachments.HasValue)
            {
                queryParameters.Add("requireActiveAttachments", RequireActiveAttachments.ToString().ToLower());
            }
            if (IncludeRemoved.HasValue)
            {
                queryParameters.Add("includeRemoved", IncludeRemoved.ToString().ToLower());
            }
            return queryParameters;
        }
    }
}