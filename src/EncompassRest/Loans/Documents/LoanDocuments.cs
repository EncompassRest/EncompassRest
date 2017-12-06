using System.Collections.Generic;
using System.IO;
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

        public Task<LoanDocument> GetDocumentAsync(string documentId) => GetDocumentAsync(documentId, CancellationToken.None);

        public Task<LoanDocument> GetDocumentAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDirtyAsync<LoanDocument>(documentId, null, nameof(GetDocumentAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentRawAsync(string documentId) => GetDocumentRawAsync(documentId, CancellationToken.None);

        public Task<string> GetDocumentRawAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync(documentId, null, nameof(GetDocumentRawAsync), documentId, cancellationToken);
        }

        public Task<List<LoanDocument>> GetDocumentsAsync() => GetDocumentsAsync(CancellationToken.None);

        public Task<List<LoanDocument>> GetDocumentsAsync(CancellationToken cancellationToken) => GetDirtyListAsync<LoanDocument>(null, null, nameof(GetDocumentsAsync), null, cancellationToken);

        public Task<string> GetDocumentsRawAsync() => GetDocumentsRawAsync(CancellationToken.None);

        public Task<string> GetDocumentsRawAsync(CancellationToken cancellationToken) => GetRawAsync(null, null, nameof(GetDocumentsRawAsync), null, cancellationToken);

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId) => GetDocumentAttachmentsAsync(documentId, CancellationToken.None);

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetAsync<List<EntityReference>>($"{documentId}/attachments", null, nameof(GetDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId) => GetDocumentAttachmentsRawAsync(documentId, CancellationToken.None);

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync($"{documentId}/attachments", null, nameof(GetDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }

        public Task<string> CreateDocumentAsync(LoanDocument document) => CreateDocumentAsync(document, false, CancellationToken.None);

        public Task<string> CreateDocumentAsync(LoanDocument document, CancellationToken cancellationToken) => CreateDocumentAsync(document, false, cancellationToken);

        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate) => CreateDocumentAsync(document, populate, CancellationToken.None);

        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PostAsync(null, populate ? ViewEntityQueryString : null, JsonStreamContent.Create(document), nameof(CreateDocumentAsync), null, cancellationToken, async response =>
            {
                var documentId = GetLocation(response);
                document.DocumentId = documentId;
                if (populate)
                {
                    await response.Content.PopulateAsync(document).ConfigureAwait(false);
                }
                document.Dirty = false;
                return documentId;
            });
        }

        public Task<string> CreateDocumentRawAsync(string document) => CreateDocumentRawAsync(document, null, CancellationToken.None);

        public Task<string> CreateDocumentRawAsync(string document, CancellationToken cancellationToken) => CreateDocumentRawAsync(document, null, cancellationToken);

        public Task<string> CreateDocumentRawAsync(string document, string queryString) => CreateDocumentRawAsync(document, queryString, CancellationToken.None);

        public Task<string> CreateDocumentRawAsync(string document, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PostAsync(null, queryString, new JsonStringContent(document), nameof(CreateDocumentRawAsync), null, cancellationToken, ReadContentOrLocationFunc);
        }

        public Task UpdateDocumentAsync(LoanDocument document) => UpdateDocumentAsync(document, false, CancellationToken.None);

        public Task UpdateDocumentAsync(LoanDocument document, CancellationToken cancellationToken) => UpdateDocumentAsync(document, false, cancellationToken);

        public Task UpdateDocumentAsync(LoanDocument document, bool populate) => UpdateDocumentAsync(document, populate, CancellationToken.None);

        public Task UpdateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(document, nameof(document));
            Preconditions.NotNullOrEmpty(document.DocumentId, $"{nameof(document)}.{nameof(document.DocumentId)}");

            return PatchPopulateDirtyAsync(document.DocumentId, JsonStreamContent.Create(document), nameof(UpdateDocumentAsync), document.DocumentId, cancellationToken, document, populate);
        }

        public Task<string> UpdateDocumentRawAsync(string documentId, string document) => UpdateDocumentRawAsync(documentId, document, null, CancellationToken.None);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, CancellationToken cancellationToken) => UpdateDocumentRawAsync(documentId, document, null, cancellationToken);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string queryString) => UpdateDocumentRawAsync(documentId, document, queryString, CancellationToken.None);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return PatchRawAsync(documentId, queryString, new JsonStringContent(document), nameof(UpdateDocumentRawAsync), documentId, cancellationToken);
        }

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities) => AssignDocumentAttachmentsAsync(documentId, action, attachmentEntities, CancellationToken.None);

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.AsString(EnumJsonConverter.CamelCaseNameFormat)));
            return PatchAsync($"{documentId}/attachments", queryParameters.ToString(), JsonStreamContent.Create(attachmentEntities), nameof(AssignDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, AssignmentAction action) => AssignDocumentAttachmentsRawAsync(documentId, attachmentEntities, action, CancellationToken.None);

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, AssignmentAction action, CancellationToken cancellationToken)
        {
            action.Validate(nameof(action));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.AsString(EnumJsonConverter.CamelCaseNameFormat)));
            return AssignDocumentAttachmentsRawAsync(documentId, attachmentEntities, queryParameters.ToString(), cancellationToken);
        }

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString) => AssignDocumentAttachmentsRawAsync(documentId, attachmentEntities, queryString, CancellationToken.None);

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchAsync($"{documentId}/attachments", queryString, new JsonStringContent(attachmentEntities), nameof(AssignDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }
    }
}