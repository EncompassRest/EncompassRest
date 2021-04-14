using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.Net.Http;
using System.Net;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using EncompassApi.Webhook;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.xUnitTests.Extensions;
using System;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace EncompassApi.xUnitTests.Webhook
{
    public class WebhookResourceTest
    {
        private readonly ITestOutputHelper _outputWriter;
        private readonly IMockedEncompassHttpClientService _mockedEncompassClient;
        public WebhookResourceTest(ITestOutputHelper outputWriter, IMockedEncompassHttpClientService mockedEncompassHttpClient)
        {
            outputWriter.WriteLine("### WebhookTest initiating! ###");
            _outputWriter = outputWriter;
            _mockedEncompassClient = mockedEncompassHttpClient;
        }

        [Theory]
        [WebhookResourceFile(JsonFileTypes.Array)]
        public async Task GetResourcesAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var target = objs.Should().BeSerializable<JObject, WebhookResource>(objs);
            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
                {
                    response.StatusCode = HttpStatusCode.OK;
                    response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(objs));
                }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
                .MockedEncompassClient.Webhook.GetResourcesAsync();

            source.Should()
                .AllBeOfType<WebhookResource>()
                .And
                .HaveCount(target.Count())
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Description.Equals(t.Description, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [WebhookResourceFile(JsonFileTypes.Array)]
        public async Task GetResourcesRawAsyncTestAsync(string methodName, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! ###", methodName);
            var target = objs.Should().BeSerializable<JObject, WebhookResource>(objs);
            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(objs));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourcesRawAsync();

            source.Should()
                .BeOfObjectArray<WebhookResource>(source, nameof(WebhookResource.Description), nameof(WebhookResource.Events))
                .And
                .BeEqual(target, source, (t, s) =>
                {
                    return s.Description.Equals(t.Description, StringComparison.OrdinalIgnoreCase);
                });
        }

        [Theory]
        [WebhookResourceFile(JsonFileTypes.Single, "Loan" , "Transaction", "TaskGroup")]
        public async Task GetResourceAsyncByEnumTestAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1}###", methodName, resourceType);

            Enum.TryParse(resourceType, out WebhookResourceType resourceTypeEnum)
                .Should().BeTrue(because: "{0} must be of type WebhookResourceType", resourceType);
            var target = (objs[0]).ToObject<WebhookResource>();
            target.Should().NotBeNull();

            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
             {
                 response.StatusCode = HttpStatusCode.OK;
                 response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
             }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceAsync(resourceTypeEnum);

            source.Should()
                .BeOfObject(source, nameof(WebhookResource.Description), nameof(WebhookResource.Events))
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

        [Theory]
        [WebhookResourceFile(JsonFileTypes.Single, "Loan", "Transaction" , "TaskGroup")]
        public async Task GetResourceAsyncByStringTestAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1} ###", methodName, resourceType);

            Enum.TryParse(resourceType, out WebhookResourceType resourceTypeEnum)
                .Should().BeTrue(because: "{0} must be of type WebhookResourceType", resourceType);
            var target = (objs[0]).ToObject<WebhookResource>();
            target.Should().NotBeNull();

            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceAsync(resourceType);

            source.Should()
                .BeOfObject(source, nameof(WebhookResource.Description), nameof(WebhookResource.Events))
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

        [Theory]
        [WebhookResourceFile(type: JsonFileTypes.Single, "Loan", "Transaction", "TaskGroup")]
        public async Task GetResourceRawAsync(string methodName, string resourceType, params JObject[] objs)
        {
            _outputWriter.WriteLine("### Starting {0}! with resourcetype {1} ###", methodName, resourceType);

            Enum.TryParse(resourceType, out WebhookResourceType resourceTypeEnum)
                .Should().BeTrue(because: "{0} must be of type WebhookResourceType", resourceType);
            var target = ((JObject)objs[0]).ToObject<WebhookResource>();
            target.Should().NotBeNull();

            // SET THE EXPECTED RESPONSE AND A HEADER FOR TESTING
            // CALL THE API
            // RETURN THE EXPECTED RESPONSE OBJECT
            var source = await (_mockedEncompassClient.SetupResponseMessage((response) =>
            {
                response.StatusCode = HttpStatusCode.OK;
                response.Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(target));
            }, testHeader: new KeyValuePair<string, string>("TestResponseHeader", Faker.RandomNumber.Next(10, 9999).ToString())))
            .MockedEncompassClient.Webhook.GetResourceRawAsync(resourceType);

            source.Should()
                .BeOfObject<WebhookResource>(source, nameof(WebhookResource.Description), nameof(WebhookResource.Events))
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
