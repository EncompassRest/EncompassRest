using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using EncompassREST.PipelineModels;
using Newtonsoft.Json;

namespace EncompassREST
{
    public class Pipeline
    {
        private const string _apiPath = "encompass/v1";

        public Session Session { get; }

        public Pipeline(Session session)
        {
            Session = session;
        }
        
        public async Task<string> PostPipelineQueryAsync(Filter filter, List<SortOrderItem> sortItem, List<string> fields, int limit = 0)
        {
            var obj = new
            {
                filter = filter,
                sortOrder = sortItem,
                fields = fields
            };
            var paramList = "";
            if (limit > 0)
            {
                var rp = new RequestParameters
                {
                    { "limit", limit.ToString() }
                };
                paramList = rp.ToString();
            }

            var message = new HttpRequestMessage(HttpMethod.Post, $"{_apiPath}/loanPipeline{paramList}");

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            message.Content = new StringContent(JsonConvert.SerializeObject(obj, settings), Encoding.UTF8, "application/json");

            var response = await Session.RESTClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RESTException("postPipelineQueryAsync", response);
            }
        }
    }
}
