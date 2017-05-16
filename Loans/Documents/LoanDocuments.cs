using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
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

        public async Task<LoanDocument> GetDocumentAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents/{documentId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetDocumentAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<LoanDocument>(json);
            }
        }

        public async Task<List<LoanDocument>> GetDocumentsAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetDocumentsAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<List<LoanDocument>>(json);
            }
        }

        public async Task<List<EntityInfo>> GetDocumentAttachmentsAsync(string documentId)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{LoanId}/documents/{documentId}/attachments"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetDocumentAttachmentsAsync), response);
                }

                var json = await response.Content.ReadAsStringAsync();
                return JsonHelper.FromJson<List<EntityInfo>>(json);
            }
        }

        public async Task<string> CreateDocumentAsync(LoanDocument document)
        {
            Preconditions.NotNull(document, nameof(document));

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}/{LoanId}/documents", JsonContent.Create(document)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(CreateDocumentAsync), response);
                }

                var location = response.Headers.Location.OriginalString;
                return location.Substring(location.LastIndexOf('/') + 1);
            }
        }

        public async Task UpdateDocumentAsync(LoanDocument document)
        {
            Preconditions.NotNull(document, nameof(document));

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/documents/{document.DocumentId}", JsonContent.Create(document)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(UpdateDocumentAsync), response);
                }
            }
        }

        public async Task AssignDocumentAttachmentsAsync(string documentId, AssignmentAction action, params EntityInfo[] attachmentEntities)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.ToJson().Unquote()));

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{LoanId}/documents/{documentId}{queryParameters}", JsonContent.Create(attachmentEntities)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(UpdateDocumentAsync), response);
                }
            }
        }
    }
}