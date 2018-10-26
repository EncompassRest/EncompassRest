using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EncompassRest.Tests
{
    public class TestBaseClass
    {
        private static EncompassRestClient s_testClient;

        /// <summary>
        /// Do not dispose of this object as it is reused on tests
        /// </summary>
        /// <returns></returns>
        public static async Task<EncompassRestClient> GetTestClientAsync()
        {
            var client = s_testClient;
            if (client == null)
            {
                const string testClientCredentialsFile = "C:\\EncompassRestTestClientCredentials.json"; // Never include this file in source control
                if (File.Exists(testClientCredentialsFile))
                {
                    TestClientCredentials credentials;
                    using (var fs = File.OpenRead(testClientCredentialsFile))
                    {
                        using (var sr = new StreamReader(fs))
                        {
                            credentials = JsonHelper.FromJson<TestClientCredentials>(sr);
                        }
                    }
                    client = await EncompassRestClient.CreateAsync(credentials.Parameters, tc => tc.FromUserCredentialsAsync(credentials.InstanceId, credentials.UserId, credentials.Password));
                    Console.WriteLine("Using test client credentials file");
                }
                else
                {
                    client = new EncompassRestClient(new ClientParameters("ApiClientId", "ApiClientSecret"));
                    var accessToken = client.AccessToken;
                    accessToken.Token = "Token";
                    var httpClient = client.HttpClient;
                    httpClient.BaseAddress = new Uri("https://try.readme.io/");
                    var defaultRequestHeaders = httpClient.DefaultRequestHeaders;
                    defaultRequestHeaders.Clear();
                    defaultRequestHeaders.Add("x-api-key", "9JsmcmHyzJuokoWeJJ8HGiRgS5GR8cSKVswz");
                    defaultRequestHeaders.Add("origin", string.Empty);
                    Console.WriteLine("Using Encompass Developer Connect Try It endpoint");
                }
                client = Interlocked.CompareExchange(ref s_testClient, client, null) ?? client;
            }
            return client;
        }

        private sealed class TestClientCredentials
        {
            public ClientParameters Parameters { get; set; }
            public string InstanceId { get; set; }
            public string UserId { get; set; }
            public string Password { get; set; }
        }

        protected void AssertNoExtensionData(IEnumerable<ExtensibleObject> values, string rootName, string id)
        {
            var fails = new List<string>();
            var i = 0;
            foreach (var value in values)
            {
                TestForExtensionData(value, new List<string> { $"{rootName}[{i}]" }, fails);
                ++i;
            }
            Assert.AreEqual(0, fails.Count, $@"{id} has the following extension data.
{string.Join(Environment.NewLine, fails)}");
        }

        protected void AssertNoExtensionData(ExtensibleObject value, string rootName, string id)
        {
            var fails = new List<string>();
            TestForExtensionData(value, new List<string> { rootName }, fails);
            Assert.AreEqual(0, fails.Count, $@"{id} has the following extension data.
{string.Join(Environment.NewLine, fails)}");
        }

        private void TestForExtensionData(ExtensibleObject value, List<string> path, List<string> fails)
        {
            if (value.ExtensionData.Count > 0)
            {
                fails.Add($"{string.Concat(path)}: {JsonConvert.SerializeObject(new Dictionary<string, object>(value.ExtensionData))}");
            }
            var type = value.GetType();
            var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(type);
            switch (contract)
            {
                case JsonObjectContract jsonObjectContract:
                    foreach (var property in jsonObjectContract.Properties)
                    {
                        var propertyUnderlyingName = property.UnderlyingName;
                        var propertyValue = property.ValueProvider.GetValue(value);
                        if (propertyValue != null)
                        {
                            switch (propertyValue)
                            {
                                case ExtensibleObject extensibleObject:
                                    path.Add($".{propertyUnderlyingName}");
                                    TestForExtensionData(extensibleObject, path, fails);
                                    path.RemoveAt(path.Count - 1);
                                    break;
                                case IList list:
                                    var i = 0;
                                    foreach (var element in list)
                                    {
                                        if (element is ExtensibleObject extObj)
                                        {
                                            path.Add($".{propertyUnderlyingName}[{i}]");
                                            TestForExtensionData(extObj, path, fails);
                                            path.RemoveAt(path.Count - 1);
                                        }
                                        ++i;
                                    }
                                    break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}