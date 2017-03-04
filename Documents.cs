using EncompassREST.Data;
using EncompassREST.LoanDocs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST
{
    public class Documents
    {
        private Loan _loan;
        

        public Session Session
        {
            get { return _loan.Session; }
        }

        public Documents(Loan Loan)
        {
            _loan = Loan;

        }

        public async Task<List<Document>> getDocumentsListAsync()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents", _loan.encompassId));

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Document>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }

        }

        public async Task<Document> getDocumentAsync(string DocumentID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents/{1}", _loan.encompassId,DocumentID));
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<Document>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }
        }

        public async Task<List<Attachment>> getDocumentAttachmentListAsync(string DocumentID)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("loans/{0}/documents/{1}/attachments", _loan.encompassId, DocumentID));
            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Attachment>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }
        }

        public async Task<Document> postDocument(string title,string applicationId = "All")
        {
            var newDoc = new
            {
                title = title,
                applicationId = applicationId,
                entityId = 1,
                entityType = "document"
            };
            
            

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("loans/{0}/documents", _loan.encompassId));
            message.Content = new StringContent(JsonConvert.SerializeObject(newDoc), Encoding.UTF32, "application/json");

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                var ID = response.Headers.Location.Segments.Last();
                return await getDocumentAsync(ID);
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDocuments", response);
            }

        }


        public async Task<string> getDownloadUrlAsync(Attachment attachment)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("loans/{0}/attachments/{1}/url", _loan.encompassId,attachment.entityId));
            var response = await Session.RESTClient.SendAsync(message);

            if (response.IsSuccessStatusCode)
            {
                var mu = JsonConvert.DeserializeObject<MediaURL>(await response.Content.ReadAsStringAsync());
                return mu.mediaUrl;
            }
            else
            {
                throw new EncompassREST.Exceptions.RESTException("getDownloadUrlAsync", response);
            }
        }

    }
}
