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
                            var snglObj = allData1.ToObject<object>();
                            rtrn1.Add(new object[] { arg, snglObj });
                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var allData1 = JObject.Parse(fileData);
                        var snglObj = allData1.ToObject<object>();
                        rtrn1.Add(new object[] { snglObj });
                    }
                    return rtrn1.AsEnumerable();
                case JsonFileTypes.Array:

                    if (_args.Count() > 0)
                        foreach (var arg in _args)
                        {
                            var fileData = GetFileString(_fileName, arg);
                            var arylObj = JsonConvert.DeserializeObject<object[]>(fileData);
                            rtrn1.Add(new object[] { arg, arylObj });
                        }
                    else
                    {
                        var fileData = GetFileString(_fileName);
                        var arylObj = JsonConvert.DeserializeObject<object[]>(fileData);
                        rtrn1.Add(arylObj);
                    }
                    return rtrn1.AsEnumerable();
                default:
                    return rtrn1.AsEnumerable();

            }

        }

       
    }
}
