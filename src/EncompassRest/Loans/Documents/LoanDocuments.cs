using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents
{
    /// <summary>
    /// The Loan Documents Apis.
    /// </summary>
    public interface ILoanDocuments : ILoanApiObject
    {
        /// <summary>
        /// Assigns or unassigns attachments.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="action">The action to perform, assign or unassign.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns or unassigns attachments.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="action">The action to perform, assign or unassign.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignDocumentAttachmentsAsync(string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns or unassigns attachments from raw json.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new document for the loan and returns the document ID.
        /// </summary>
        /// <param name="document">The document to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new document for the loan and returns the document ID and optionally populates the document object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="document">The document to create.</param>
        /// <param name="populate">Indicates if the document object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new document for the loan from raw json and returns the response body if not empty else the document ID.
        /// </summary>
        /// <param name="document">The document to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateDocumentRawAsync(string document, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves properties for the specified eFolder document. The response includes roles that have access to the document, any comments applied to the document, and file attachment information.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanDocument> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of file attachments for the document with the specified <paramref name="documentId"/>.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of file attachments for the document with the specified <paramref name="documentId"/> as raw json.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDocumentAttachmentsRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves properties for the specified eFolder document as raw json.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDocumentRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all eFolder documents for the loan. The response includes a list of eFolder documents for the loan, roles that have access to the documents, and any comments applied to the documents.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanDocument>> GetDocumentsAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all eFolder documents for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetDocumentsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties of the specified <paramref name="document"/>.
        /// </summary>
        /// <param name="document">The document to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties of the specified <paramref name="document"/> and optionally populates the document object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="document">The document to update.</param>
        /// <param name="populate">Indicates if the document object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates properties of the document with the specified <paramref name="documentId"/> from raw json.
        /// </summary>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="document">The document to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateDocumentRawAsync(string documentId, string document, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Documents Apis.
    /// </summary>
    public sealed class LoanDocuments : LoanApiObject, ILoanDocuments
    {
        internal LoanDocuments(IEncompassRestClient client, string loanId)
            : base(client, loanId, "documents")
        {
        }

        /// <inheritdoc/>
        public Task<List<LoanDocument>> GetDocumentsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanDocument>(null, null, nameof(GetDocumentsAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetDocumentsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetDocumentsRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<LoanDocument> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDirtyAsync<LoanDocument>(documentId, null, nameof(GetDocumentAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetDocumentRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync(documentId, queryString, nameof(GetDocumentRawAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetAsync<List<EntityReference>>($"{documentId}/attachments", null, nameof(GetDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetDocumentAttachmentsRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync($"{documentId}/attachments", queryString, nameof(GetDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default) => CreateDocumentAsync(document, false, cancellationToken);

        /// <inheritdoc/>
        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PostPopulateDirtyAsync(null, nameof(CreateDocumentAsync), document, populate, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateDocumentRawAsync(string document, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PostAsync(null, queryString, new JsonStringContent(document), nameof(CreateDocumentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <inheritdoc/>
        public Task UpdateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default) => UpdateDocumentAsync(document, false, cancellationToken);

        /// <inheritdoc/>
        public Task UpdateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NotNullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PatchPopulateDirtyAsync(document.DocumentId, JsonStreamContent.Create(document), nameof(UpdateDocumentAsync), document.DocumentId, document, populate, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PatchRawAsync(documentId, queryString, new JsonStringContent(document), nameof(UpdateDocumentRawAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default) => AssignDocumentAttachmentsAsync(documentId, action.Validate(nameof(action)).GetValue()!, attachmentEntities, cancellationToken);

        /// <inheritdoc/>
        public Task AssignDocumentAttachmentsAsync(string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(action, nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action));
            return PatchAsync($"{documentId}/attachments", queryParameters.ToString(), JsonStreamContent.Create(attachmentEntities), nameof(AssignDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchAsync($"{documentId}/attachments", queryString, new JsonStringContent(attachmentEntities), nameof(AssignDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }
    }
}