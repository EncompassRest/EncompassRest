using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents
{
    public sealed class LoanDocuments
    {
        private const string _apiPath = "encompass/v1/loans";

        public EncompassRestClient Client { get; }

        public string LoanId { get; }

        internal LoanDocuments(EncompassRestClient client, string loanId)
        {
            Client = client;
            LoanId = loanId;
        }

        public Task<LoanDocument> GetDocumentAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentInternalAsync(documentId, response => response.Content.ReadAsAsync<LoanDocument>());
        }

        public Task<string> GetDocumentRawAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentInternalAsync(documentId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetDocumentInternalAsync<T>(string documentId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents/{documentId}").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanDocument>> GetDocumentsAsync() => GetDocumentsInternalAsync(response => response.Content.ReadAsAsync<List<LoanDocument>>());

        public Task<string> GetDocumentsRawAsync() => GetDocumentsInternalAsync(response => response.Content.ReadAsStringAsync());

        private async Task<T> GetDocumentsInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<EntityReference>> GetDocumentAttachmentsAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentAttachmentsInternalAsync(documentId, response => response.Content.ReadAsAsync<List<EntityReference>>());
        }

        public Task<string> GetDocumentAttachmentsRawAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDocumentAttachmentsInternalAsync(documentId, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> GetDocumentAttachmentsInternalAsync<T>(string documentId, Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents/{documentId}/attachments").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetDocumentAttachmentsAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<string> CreateDocumentAsync(LoanDocument document)
        {
            Preconditions.NotNull(document, nameof(document));

            return CreateDocumentInternalAsync(JsonStreamContent.Create(document));
        }

        public Task<string> CreateDocumentAsync(string document)
        {
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return CreateDocumentInternalAsync(new JsonContent(document));
        }

        private async Task<string> CreateDocumentInternalAsync(HttpContent content)
        {
            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/{LoanId}/documents", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(CreateDocumentAsync), response).ConfigureAwait(false);
                }

                return Path.GetFileName(response.Headers.Location.OriginalString);
            }
        }

        public Task UpdateDocumentAsync(LoanDocument document)
        {
            Preconditions.NotNull(document, nameof(document));

            return UpdateDocumentInternalAsync(document.DocumentId, JsonStreamContent.Create(document));
        }

        public Task UpdateDocumentAsync(string documentId, string document)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(document, nameof(document));

            return UpdateDocumentInternalAsync(documentId, new JsonContent(document));
        }

        private async Task UpdateDocumentInternalAsync(string documentId, HttpContent content)
        {
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/documents/{documentId}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateDocumentAsync), response).ConfigureAwait(false);
                }
            }
        }

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, params EntityReference[] attachmentEntities) => AssignDocumentAttachmentsAsync(documentId, action, (IEnumerable<EntityReference>)attachmentEntities);

        public Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            return AssignDocumentAttachmentsInternalAsync(documentId, action, JsonStreamContent.Create(attachmentEntities));
        }

        public Task AssignDocumentAttachmentsRawAsync(string documentId, AssignmentAction action, string attachmentEntities)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            return AssignDocumentAttachmentsInternalAsync(documentId, action, new JsonContent(attachmentEntities));
        }

        private async Task AssignDocumentAttachmentsInternalAsync(string documentId, AssignmentAction action, HttpContent content)
        {
            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.ToJson().Unquote()));
            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/documents/{documentId}{queryParameters}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(UpdateDocumentAsync), response).ConfigureAwait(false);
                }
            }
        }
    }
}