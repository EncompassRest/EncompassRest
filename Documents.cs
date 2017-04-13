using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassREST.Data;
using EncompassREST.Exceptions;
using EncompassREST.LoanDocs;
using Newtonsoft.Json;

namespace EncompassREST
{
    public class Documents
    {
        private readonly Loan _loan;

        public Session Session => _loan.Session;

        public Documents(Loan loan)
        {
            _loan = loan;
        }

        public async Task<List<Document>> GetDocumentsListAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"loans/{_loan.encompassId}/documents");

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Document>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RESTException(nameof(GetDocumentsListAsync), response);
            }
        }

        public async Task<Document> GetDocumentAsync(string documentId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"loans/{_loan.encompassId}/documents/{documentId}");
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Document>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RESTException(nameof(GetDocumentAsync), response);
            }
        }

        public async Task<List<Attachment>> GetDocumentAttachmentListAsync(string documentId)
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"loans/{_loan.encompassId}/documents/{documentId}/attachments");
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Attachment>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new RESTException(nameof(GetDocumentAttachmentListAsync), response);
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

            var message = new HttpRequestMessage(HttpMethod.Post, $"loans/{_loan.encompassId}/documents")
            {
                Content = new StringContent(JsonConvert.SerializeObject(newDoc), Encoding.UTF32, "application/json")
            };
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                var id = response.Headers.Location.Segments.Last();
                return await GetDocumentAsync(id);
            }
            else
            {
                throw new RESTException(nameof(PostDocumentAsync), response);
            }
        }

        public async Task<string> GetDownloadUrlAsync(Attachment attachment)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, $"loans/{_loan.encompassId}/attachments/{attachment.entityId}/url");
            var response = await Session.RESTClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var mu = JsonConvert.DeserializeObject<MediaURL>(await response.Content.ReadAsStringAsync());
                return mu.mediaUrl;
            }
            else
            {
                throw new RESTException(nameof(GetDownloadUrlAsync), response);
            }
        }
    }
}
