using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;


namespace EncompassApi.xUnitTests
{
    public class JsonFileDataAttribute : DataAttribute
    {
        private readonly string _fileName;
        private readonly string _propertyName;
        private readonly JsonFileTypes _type;
        private readonly List<string> _args;



        /// <summary>
        /// Load data from a JSON file as the data source for a theory
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the JSON file to load</param>
        /// <param name="propertyName">The name of the property on the JSON file that contains the data for the test</param>
        public JsonFileDataAttribute(string jsonFileName, string propertyName, JsonFileTypes type, params string[] args) 
        {
            _fileName = jsonFileName;
            _propertyName = propertyName;
            _type = type;

            _args = new List<string>();
            foreach (var item in args)
            {
                _args.Add(item);
            }
        }

        /// <inheritDoc />
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }
            var fullPath = $"Payloads/{_fileName}.json";

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(fullPath)
                ? fullPath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), fullPath);

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }
            // Load the file
            var fileData = File.ReadAllText(fullPath);

            if (string.IsNullOrEmpty(_propertyName))
            {
                
                var rtrn1 = new List<object[]>();

                switch (_type)
                {
                    case JsonFileTypes.Single:
                        var allData1 = JObject.Parse(fileData);
                        var snglObj = allData1.ToObject<object>();
                        if (_args.Count() > 0)
                            foreach (var arg in _args)
                                rtrn1.Add(new object[] { arg, snglObj });
                        else
                            rtrn1.Add(new object[] { snglObj });
                        return rtrn1.AsEnumerable();
                    case JsonFileTypes.Array:
                        var arylObj = JsonConvert.DeserializeObject<object[]>(fileData);
                        if (_args.Count() > 0)
                            foreach (var arg in _args)
                                rtrn1.Add(new object[] { arg, arylObj });
                        else
                            rtrn1.Add( arylObj );
                        return rtrn1.AsEnumerable();
                    default:
                        return rtrn1.AsEnumerable();

                }
            }


            var allData = JObject.Parse(fileData);
            var data = allData[_propertyName];
            return data.ToObject<IEnumerable<object[]>>();

        }

        
    }

    public enum JsonFileTypes
    {
        Single = 0,
        Array = 1
    }
}
