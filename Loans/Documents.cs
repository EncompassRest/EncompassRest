using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using EncompassRest.LoanDocs;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class Documents
    {
        private const string _apiPath = "encompass/v1/loans";

        private readonly Loan _loan;

        public EncompassRestClient Client => _loan.Client;

        public Documents(Loan loan)
        {
            _loan = loan;
        }

        public async Task<List<Document>> GetDocumentsListAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/{_loan.EncompassId}/documents");

            var response = await Client.HttpClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Document>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RestException(nameof(GetDocumentsListAsync), response);
            }
        }

        public async Task<Document> GetDocumentAsync(string documentId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/{_loan.EncompassId}/documents/{documentId}");
            var response = await Client.HttpClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Document>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RestException(nameof(GetDocumentAsync), response);
            }
        }

        public async Task<List<Attachment>> GetDocumentAttachmentListAsync(string documentId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/{_loan.EncompassId}/documents/{documentId}/attachments");
            var response = await Client.HttpClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Attachment>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RestException(nameof(GetDocumentAttachmentListAsync), response);
            }
        }

        public async Task<Document> PostDocumentAsync(string title, string applicationId = "All")
        {
            var newDoc = new
            {
                title = title,
                applicationId = applicationId,
                entityId = 1,
                entityType = "document"
            };

            var message = new HttpRequestMessage(HttpMethod.Post, $"{_apiPath}/{_loan.EncompassId}/documents")
            {
                Content = new StringContent(JsonConvert.SerializeObject(newDoc), Encoding.UTF32, "application/json")
            };
            var response = await Client.HttpClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                var id = response.Headers.Location.Segments.Last();
                return await GetDocumentAsync(id);
            }
            else
            {
                throw new RestException(nameof(PostDocumentAsync), response);
            }
        }

        public async Task<string> GetDownloadUrlAsync(Attachment attachment)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, $"{_apiPath}/{_loan.EncompassId}/attachments/{attachment.entityId}/url");
            var response = await Client.HttpClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var mu = JsonConvert.DeserializeObject<MediaURL>(await response.Content.ReadAsStringAsync());
                return mu.mediaUrl;
            }
            else
            {
                throw new RestException(nameof(GetDownloadUrlAsync), response);
            }
        }
    }
}
