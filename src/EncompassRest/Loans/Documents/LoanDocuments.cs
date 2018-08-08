using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocuments : LoanApiObject
    {
        internal LoanDocuments(EncompassRestClient client, string loanId)
            : base(client, loanId, "documents")
        {
        }

        public Task<LoanDocument> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDirtyAsync<LoanDocument>(documentId, null, nameof(GetDocumentAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentRawAsync(string documentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync(documentId, queryString, nameof(GetDocumentRawAsync), documentId, cancellationToken);
        }

        public Task<List<LoanDocument>> GetDocumentsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<LoanDocument>(null, null, nameof(GetDocumentsAsync), null, cancellationToken);

        public Task<string> GetDocumentsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetDocumentsRawAsync), null, cancellationToken);

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetAsync<List<EntityReference>>($"{documentId}/attachments", null, nameof(GetDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync($"{documentId}/attachments", queryString, nameof(GetDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }

        public Task<string> CreateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default) => CreateDocumentAsync(document, false, cancellationToken);

        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PostPopulateDirtyAsync(null, nameof(CreateDocumentAsync), document, populate, cancellationToken);
        }

        public Task<string> CreateDocumentRawAsync(string document, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PostAsync(null, queryString, new JsonStringContent(document), nameof(CreateDocumentRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateDocumentAsync(LoanDocument document, CancellationToken cancellationToken = default) => UpdateDocumentAsync(document, false, cancellationToken);

        public Task UpdateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NotNullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PatchPopulateDirtyAsync(document.DocumentId, JsonStreamContent.Create(document), nameof(UpdateDocumentAsync), document.DocumentId, document, populate, true, cancellationToken);
        }

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PatchRawAsync(documentId, queryString, new JsonStringContent(document), nameof(UpdateDocumentRawAsync), documentId, cancellationToken);
        }

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.AsString(EnumJsonConverter.CamelCaseNameFormat)));
            return PatchAsync($"{documentId}/attachments", queryParameters.ToString(), JsonStreamContent.Create(attachmentEntities), nameof(AssignDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchAsync($"{documentId}/attachments", queryString, new JsonStringContent(attachmentEntities), nameof(AssignDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }
    }
}