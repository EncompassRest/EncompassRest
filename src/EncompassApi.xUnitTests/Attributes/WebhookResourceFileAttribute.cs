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
    public class WebhookResourceFileAttribute : JsonFileDataAttribute
    {
        protected WebhookResourceFileAttribute(string fileName, JsonFileTypes type, params string[] args)
           : base(fileName, null, type, args)
        {
            if (type == JsonFileTypes.Array) _fileName += "s";
        }

        public WebhookResourceFileAttribute(JsonFileTypes type, params string[] args)
            : base("WebhookResource", null, type, args)
        {
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
                            rtrn1.Add(new object[] {testMethod.Name, arg, allData1 });
                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var allData1 = JObject.Parse(fileData);
                        rtrn1.Add(new object[] { testMethod.Name, allData1 });
                    }
                    return rtrn1.AsEnumerable();
                case JsonFileTypes.Array:

                    if (_args.Count() > 0)
                        foreach (var arg in _args)
                        {
                            var fileData = GetFileString(_fileName, arg);
                            var arylObj = JsonConvert.DeserializeObject<JObject[]>(fileData);
                            rtrn1.Add(new object[] {testMethod.Name, arg, arylObj });
                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var arylObj = JsonConvert.DeserializeObject<JObject[]>(fileData);
                        rtrn1.Add(new object[] { testMethod.Name,  arylObj });
                    }
                    return rtrn1.AsEnumerable();
                default:
                    return rtrn1.AsEnumerable();

            }

        }

       
    }
}
