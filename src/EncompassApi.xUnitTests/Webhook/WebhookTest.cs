using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.xUnitTests.Extensions;
using System;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;

        public WebhookTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        /// <summary>
        ///  Test EncompassApi.Webhook.ResourcesAsyncTestAsync()
        /// </summary>
        [Theory]
        [JsonFileData("WebhookResources", null,  JsonFileTypes.Array)]
        public async Task GetResourcesAsyncTestAsync(params JObject[] payloads)
        {
            _outputWriter.WriteLine("### Starting GetResourcesAsyncTestAsync! ###");
            var target = payloads.Should().BeOfType<JObject, EncompassApi.Webhook.WebhookResource>(payloads);
            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payloads));
                }, testHeader: new System.Collections.Generic.KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
                .MockedEncompassClient.Webhook.GetResourcesAsync();

            source.Should()
                .AllBeOfType<EncompassApi.Webhook.WebhookResource>()
                .And
                .HaveCount(target.Count())
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Description.Equals(t.Description, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [JsonFileData("WebhookResources", null,  JsonFileTypes.Array)]
        public async Task GetResourcesRawAsyncTestAsync(params JObject[] payloads)
        {
            _outputWriter.WriteLine("### Starting GetResourcesRawAsyncTestAsync! ###");
            var target = payloads.Should().BeOfType<JObject, EncompassApi.Webhook.WebhookResource>(payloads);
            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payloads));
            }, testHeader: new System.Collections.Generic.KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourcesRawAsync();

            source.Should()
                .BeObjectArray<EncompassApi.Webhook.WebhookResource>(source, "Description", "Events")
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Description.Equals(t.Description, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [JsonFileData("WebhookResource.Loan", null,  JsonFileTypes.Single, "Loan")]
        [JsonFileData("WebhookResource.Transaction", null, JsonFileTypes.Single, "Transaction")]
        public async Task  GetResourceAsyncTestAsync(params object[] args)
        {
            _outputWriter.WriteLine("### Starting GetResourceAsyncTestAsync! ###");
            var resourceType = (string)args[0];
            var target = ((JObject)args[1]).ToObject<EncompassApi.Webhook.WebhookResource>();
            target.Should().NotBeNull();

            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await(_mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new System.Collections.Generic.KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceAsync(EncompassApi.Webhook.WebhookResourceType.Loan);

            source.Should()
                .BeObject<EncompassApi.Webhook.WebhookResource>(source, nameof(EncompassApi.Webhook.WebhookResource.Description), nameof(EncompassApi.Webhook.WebhookResource.Events))
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Description.Equals(t.Description, StringComparison.OrdinalIgnoreCase);
                })
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Name.Equals(resourceType);
                });
        }
    }
}
