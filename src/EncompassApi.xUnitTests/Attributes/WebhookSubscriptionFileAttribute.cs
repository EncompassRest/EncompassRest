using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests
{
    public class WebhookSubscriptionFileAttribute : JsonFileDataAttribute
    {
        private readonly string[] Args2;
        protected string[] SubscriptionIds { get; set; }

        public WebhookSubscriptionFileAttribute(JsonFileTypes type, params string[] args)
            : base("WebhookSubscription", null, type, args) {
            if (type == JsonFileTypes.Array) _fileName += "s";
        }
        public WebhookSubscriptionFileAttribute(JsonFileTypes type, string[] args, params string[] args2) 
            : base("WebhookSubscription", null, type, args) {
            Args2 = args2;
            if (type == JsonFileTypes.Array) _fileName += "s";

        }

        public WebhookSubscriptionFileAttribute(JsonFileTypes type, string[] args,  string arg2)
            : base("WebhookSubscription", null, type, args)
        {
            Args2 = new string[] { arg2 };
            if (type == JsonFileTypes.Array) _fileName += "s";

        }


        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }
            var rtrn1 = new List<object[]>();

            switch (_type)
            {
                case JsonFileTypes.Single:
                    if (_args.Count() > 0)
                        foreach (var arg in _args)
                        {
                            var fileData = GetFileString(_fileName, arg);
                            var allData1 = JObject.Parse(fileData);
                            if (SubscriptionIds != null && SubscriptionIds.Length > 0)
                                foreach (var id in SubscriptionIds)
                                {
                                    rtrn1.Add(GetObject(testMethod.Name, allData1, id, arg, Args2));
                                }
                            else
                                rtrn1.Add(GetObject(testMethod.Name, allData1, null, arg, Args2));

                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var allData1 = JObject.Parse(fileData);
                        if (SubscriptionIds != null && SubscriptionIds.Length > 0)
                            foreach (var id in SubscriptionIds)
                            {
                                rtrn1.Add(GetObject(testMethod.Name, allData1, id: id));
                            }   
                        else
                            rtrn1.Add(GetObject(testMethod.Name, allData1, id: null)); 
                    }
                    return rtrn1.AsEnumerable();
                case JsonFileTypes.Array:
                    if (_args.Count() > 0)
                        foreach (var arg in _args)
                        {
                            var fileData = GetFileString(_fileName, arg);
                            var arylObj = JsonConvert.DeserializeObject<JObject[]>(fileData);
                            if (SubscriptionIds != null && SubscriptionIds.Length > 0)
                                foreach (var id in SubscriptionIds)
                                {
                                    rtrn1.Add(GetObject(testMethod.Name, arylObj, id, resourceType: arg, args2: Args2));
                                }
                            else
                                rtrn1.Add(GetObject(testMethod.Name, arylObj, null, resourceType: arg, args2: Args2));
                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var arylObj = JsonConvert.DeserializeObject<JObject[]>(fileData);
                        if (SubscriptionIds != null && SubscriptionIds.Length > 0)
                            foreach (var id in SubscriptionIds)
                            {
                                rtrn1.Add(GetObject(testMethod.Name, arylObj, id: id));
                            }
                        else
                            rtrn1.Add(GetObject(testMethod.Name, arylObj, id: null));
                    }
                    return rtrn1.AsEnumerable();
                default:
                    return rtrn1.AsEnumerable();
            }
        }

        private object[] GetObject(string testName,  object objs, string id = null, string resourceType = null, params string[] args2)
        {
            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(resourceType))
                return (new object[] { testName, resourceType, id, objs });

            if (string.IsNullOrEmpty(resourceType) && args2.Length == 0)
                return (new object[] { testName, objs });

            if(args2 == null || args2.Length == 0)
                return (new object[] { testName, resourceType, objs });
            
            return (new object[] { testName, resourceType, args2, objs });
        }
    }
}
