using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;
using EnumsNET.NonGeneric;
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

        protected static void AssertNoExtensionData(IEnumerable<ExtensibleObject> values, string rootName, string id, bool testForUndefinedEnumOptions, Dictionary<Type, HashSet<string>> enumOptionsToIgnore = null)
        {
            var fails = new List<string>();
            var i = 0;
            foreach (var value in values)
            {
                TestForExtensionData(value, new List<string> { $"{rootName}[{i}]" }, fails, testForUndefinedEnumOptions, enumOptionsToIgnore);
                ++i;
            }
            Assert.AreEqual(0, fails.Count, $@"{id} has the following issues.
{string.Join(Environment.NewLine, fails)}");
        }

        protected static void AssertNoExtensionData(ExtensibleObject value, string rootName, string id, bool testForUndefinedEnumOptions, Dictionary<Type, HashSet<string>> enumOptionsToIgnore = null)
        {
            var fails = new List<string>();
            TestForExtensionData(value, new List<string> { rootName }, fails, testForUndefinedEnumOptions, enumOptionsToIgnore);
            Assert.AreEqual(0, fails.Count, $@"{id} has the following issues.
{string.Join(Environment.NewLine, fails)}");
        }

        private static void TestForExtensionData(ExtensibleObject value, List<string> path, List<string> fails, bool testForUndefinedEnumOptions, Dictionary<Type, HashSet<string>> enumOptionsToIgnore)
        {
            if (value.ExtensionData.Count > 0)
            {
                fails.Add($"{string.Concat(path)} has the extension data {JsonConvert.SerializeObject(new Dictionary<string, object>(value.ExtensionData))}");
            }
            var type = value.GetType();
            var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(type);
            if (contract is JsonObjectContract jsonObjectContract)
            {
                foreach (var property in jsonObjectContract.Properties)
                {
                    var propertyUnderlyingName = property.UnderlyingName;
                    var valueProvider = JsonHelper.InternalPrivateContractResolver.GetBackingFieldInfo(contract.UnderlyingType, propertyUnderlyingName)?.ValueProvider ?? property.ValueProvider;
                    var propertyValue = valueProvider.GetValue(value);
                    if (propertyValue != null)
                    {
                        path.Add($".{propertyUnderlyingName}");
                        switch (propertyValue)
                        {
                            case ExtensibleObject extensibleObject:
                                TestForExtensionData(extensibleObject, path, fails, testForUndefinedEnumOptions, enumOptionsToIgnore);
                                break;
                            case IList list:
                                var i = 0;
                                foreach (var element in list)
                                {
                                    path.Add($"[{i}]");
                                    if (element is ExtensibleObject extObj)
                                    {
                                        TestForExtensionData(extObj, path, fails, testForUndefinedEnumOptions, enumOptionsToIgnore);
                                    }
                                    else
                                    {
                                        TestForUndefinedEnumOptions(path, fails, enumOptionsToIgnore, element);
                                    }
                                    path.RemoveAt(path.Count - 1);
                                    ++i;
                                }
                                break;
                            case IDictionary dictionary:
                                foreach (DictionaryEntry pair in dictionary)
                                {
                                    if (pair.Value is ExtensibleObject extObj)
                                    {
                                        path.Add($".{pair.Key}");
                                        TestForExtensionData(extObj, path, fails, testForUndefinedEnumOptions, enumOptionsToIgnore);
                                        path.RemoveAt(path.Count - 1);
                                    }
                                }
                                break;
                            default:
                                if (testForUndefinedEnumOptions)
                                {
                                    TestForUndefinedEnumOptions(path, fails, enumOptionsToIgnore, propertyValue);
                                }
                                break;
                        }
                        path.RemoveAt(path.Count - 1);
                    }
                }
            }

            
        }

        protected static void AssertNoUndefinedEnumOptions(IEnumerable stringEnumValues, string rootName, Dictionary<Type, HashSet<string>> enumOptionsToIgnore)
        {
            var path = new List<string> { rootName };
            var fails = new List<string>();
            var i = 0;
            foreach (var element in stringEnumValues)
            {
                path.Add($"[{i}]");
                TestForUndefinedEnumOptions(path, fails, enumOptionsToIgnore, element);
                path.RemoveAt(path.Count - 1);
                ++i;
            }
        }

        private static void TestForUndefinedEnumOptions(List<string> path, List<string> fails, Dictionary<Type, HashSet<string>> enumOptionsToIgnore, object itemValue)
        {
            var typeInfo = itemValue.GetType().GetTypeInfo();
            if (typeInfo.IsGenericType && !typeInfo.IsGenericTypeDefinition && typeInfo.GetGenericTypeDefinition() == TypeData.OpenStringEnumValueType)
            {
                var stringValue = itemValue.ToString();
                if (!string.IsNullOrEmpty(stringValue))
                {
                    var enumType = typeInfo.GenericTypeArguments[0];
                    if (!NonGenericEnums.TryParse(enumType, stringValue, true, out _, EnumFormat.EnumMemberValue, EnumFormat.Name) && (enumOptionsToIgnore == null || !enumOptionsToIgnore.TryGetValue(enumType, out var optionsToIgnore) || !optionsToIgnore.Contains(stringValue)))
                    {
                        fails.Add($"{string.Concat(path)} value of '{stringValue}' is not defined in {enumType.Name}");
                    }
                }
            }
        }
    }
}