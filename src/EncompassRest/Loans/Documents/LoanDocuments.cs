using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocuments
    {
        private const string s_apiPath = "encompass/v1/loans";

        public EncompassRestClient Client { get; }

        public string LoanId { get; }

        internal LoanDocuments(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }

        public Task<LoanDocument> GetDocumentAsync(string documentId) => GetDocumentAsync(documentId, CancellationToken.None);

        public Task<LoanDocument> GetDocumentAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentInternalAsync(documentId, cancellationToken, async response =>
            {
                var document = await response.Content.ReadAsAsync<LoanDocument>().ConfigureAwait(false);
                document.Dirty = false;
                return document;
            });
        }

        public Task<string> GetDocumentRawAsync(string documentId) => GetDocumentRawAsync(documentId, CancellationToken.None);

        public Task<string> GetDocumentRawAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentInternalAsync(documentId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetDocumentInternalAsync<T>(string documentId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{LoanId}/documents/{documentId}", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanDocument>> GetDocumentsAsync() => GetDocumentsAsync(CancellationToken.None);

        public Task<List<LoanDocument>> GetDocumentsAsync(CancellationToken cancellationToken) => GetDocumentsInternalAsync(cancellationToken, async response =>
        {
            var documents = await response.Content.ReadAsAsync<List<LoanDocument>>().ConfigureAwait(false);
            foreach (var document in documents)
            {
                document.Dirty = false;
            }
            return documents;
        });

        public Task<string> GetDocumentsRawAsync() => GetDocumentsRawAsync(CancellationToken.None);

        public Task<string> GetDocumentsRawAsync(CancellationToken cancellationToken) => GetDocumentsInternalAsync(cancellationToken, response => response.Content.ReadAsStringAsync());

        private async Task<T> GetDocumentsInternalAsync<T>(CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{LoanId}/documents", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId) => GetDocumentAttachmentsAsync(documentId, CancellationToken.None);

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentAttachmentsInternalAsync(documentId, cancellationToken, response => response.Content.ReadAsAsync<List<EntityReference>>());
        }

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId) => GetDocumentAttachmentsRawAsync(documentId, CancellationToken.None);

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentAttachmentsInternalAsync(documentId, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetDocumentAttachmentsInternalAsync<T>(string documentId, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{s_apiPath}/{LoanId}/documents/{documentId}/attachments", cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentAttachmentsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateDocumentAsync(LoanDocument document) => CreateDocumentAsync(document, false, CancellationToken.None);

        public Task<string> CreateDocumentAsync(LoanDocument document, CancellationToken cancellationToken) => CreateDocumentAsync(document, false, cancellationToken);

        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate) => CreateDocumentAsync(document, populate, CancellationToken.None);

        public Task<string> CreateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(document, nameof(document));

            return CreateDocumentInternalAsync(JsonStreamContent.Create(document), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(document).ConfigureAwait(false);
                }
                document.Dirty = false;
                return Path.GetFileName(response.Headers.Location.OriginalString);
            });
        }

        public Task<string> CreateDocumentRawAsync(string document) => CreateDocumentRawAsync(document, null, CancellationToken.None);

        public Task<string> CreateDocumentRawAsync(string document, CancellationToken cancellationToken) => CreateDocumentRawAsync(document, null, cancellationToken);

        public Task<string> CreateDocumentRawAsync(string document, string queryString) => CreateDocumentRawAsync(document, queryString, CancellationToken.None);

        public Task<string> CreateDocumentRawAsync(string document, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return CreateDocumentInternalAsync(new JsonStringContent(document), queryString, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }

        private async Task<string> CreateDocumentInternalAsync(HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PostAsync($"{s_apiPath}/{LoanId}/documents{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateDocumentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task UpdateDocumentAsync(LoanDocument document) => UpdateDocumentAsync(document, false, CancellationToken.None);

        public Task UpdateDocumentAsync(LoanDocument document, CancellationToken cancellationToken) => UpdateDocumentAsync(document, false, cancellationToken);

        public Task UpdateDocumentAsync(LoanDocument document, bool populate) => UpdateDocumentAsync(document, populate, CancellationToken.None);

        public Task UpdateDocumentAsync(LoanDocument document, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(document, nameof(document));

            return UpdateDocumentInternalAsync(document.DocumentId, JsonStreamContent.Create(document), populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(document).ConfigureAwait(false);
                }
                document.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateDocumentRawAsync(string documentId, string document) => UpdateDocumentRawAsync(documentId, document, null, CancellationToken.None);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, CancellationToken cancellationToken) => UpdateDocumentRawAsync(documentId, document, null, cancellationToken);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string queryString) => UpdateDocumentRawAsync(documentId, document, queryString, CancellationToken.None);

        public Task<string> UpdateDocumentRawAsync(string documentId, string document, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return UpdateDocumentInternalAsync(documentId, new JsonStringContent(document), queryString, cancellationToken, response => response.Content.ReadAsStringAsync());
        }

        private async Task<string> UpdateDocumentInternalAsync(string documentId, HttpContent content, string queryString, CancellationToken cancellationToken, Func<HttpResponseMessage, Task<string>> func)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{LoanId}/documents/{documentId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateDocumentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, params EntityReference[] attachmentEntities) => AssignDocumentAttachmentsAsync(documentId, action, attachmentEntities, CancellationToken.None);

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities) => AssignDocumentAttachmentsAsync(documentId, action, attachmentEntities, CancellationToken.None);

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.AsString(EnumJsonConverter.CamelCaseNameFormat)));
            return AssignDocumentAttachmentsInternalAsync(documentId, JsonStreamContent.Create(attachmentEntities), queryParameters.ToString(), cancellationToken);
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

            return AssignDocumentAttachmentsInternalAsync(documentId, new JsonStringContent(attachmentEntities), queryString, cancellationToken);
        }

        private async Task AssignDocumentAttachmentsInternalAsync(string documentId, HttpContent content, string queryString, CancellationToken cancellationToken)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{s_apiPath}/{LoanId}/documents/{documentId}{(!string.IsNullOrEmpty(queryString) && queryString[0] != '?' ? "?" : string.Empty)}{queryString}", content, cancellationToken).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateDocumentAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}