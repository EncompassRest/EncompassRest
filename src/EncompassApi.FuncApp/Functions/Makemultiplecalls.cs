using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;

namespace EncompassApi.FuncApp.Functions
{
    public  class Makemultiplecalls
    {
        private readonly ILogger _log;
        private readonly IEncompassApiClient _client;

        public Makemultiplecalls(IEncompassApiClient client, ILogger<TokenFunction> log)
        {
            _log = log;
            _client = client;
        }
        //This isn't doing anything yet, just setting up references and dependencies for project.
        [FunctionName("Makemultiplecalls")]
        public async Task<IActionResult> run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req)
        {
            _log.LogInformation("Token Service Validation start");

            //this call will fail but should call correct handlers to validate token

            List<Webhook.WebhookSubscription> result = new List<Webhook.WebhookSubscription>();
            List<System.Threading.Tasks.Task<List<Webhook.WebhookSubscription>>> tasks = new List<Task<List<Webhook.WebhookSubscription>>>();
            for(int i = 0; i<20; i++)
            {
                tasks.Add(_client.Webhook.GetSubscriptionsAsync());
            }
            var v = await Task.WhenAll(tasks);

            try
            {
                foreach (var ping in v)
                {
                    result.AddRange(ping);
                }
            }catch(Exception ex)
            {

            }

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            var name = "Bruh";

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(result);
        }
    }
}

