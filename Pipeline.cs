using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using EncompassRest.HelperClasses;
using EncompassRest.Filters;
using Newtonsoft.Json;

namespace EncompassRest
{
    public sealed class Pipeline
    {
        private const string _apiPath = "encompass/v1/loanPipeline";

        public EncompassRestClient Client { get; }

        internal Pipeline(EncompassRestClient client)
        {
            Client = client;
        }
        
        public async Task<string> PostPipelineQueryAsync(Filter filter, List<FieldSort> sortItem, List<string> fields, int limit = 0)
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

            var message = new HttpRequestMessage(HttpMethod.Post, $"{_apiPath}{paramList}");

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            message.Content = new StringContent(JsonConvert.SerializeObject(obj, settings), Encoding.UTF8, "application/json");

            var response = await Client.HttpClient.SendAsync(message);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new RestException("postPipelineQueryAsync", response);
            }
        }
    }
}
