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
        private readonly string _filePath;
        private readonly string _propertyName;
        private readonly bool _allowListOfObjects;

        /// <summary>
        /// Load data from a JSON file as the data source for a theory
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the JSON file to load</param>
        public JsonFileDataAttribute(string filePath, bool allowListOfObjects)
            : this(filePath, string.Empty) {
            _allowListOfObjects = allowListOfObjects;
        }

        /// <summary>
        /// Load data from a JSON file as the data source for a theory
        /// </summary>
        /// <param name="filePath">The absolute or relative path to the JSON file to load</param>
        /// <param name="propertyName">The name of the property on the JSON file that contains the data for the test</param>
        public JsonFileDataAttribute(string filePath, string propertyName) 
        {
            _filePath = filePath;
            _propertyName = propertyName;
            
            
        }

        

        /// <inheritDoc />
        public override  IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(_filePath)
                ? _filePath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), _filePath);

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            // Load the file
            var fileData = File.ReadAllText(_filePath);

            if (string.IsNullOrEmpty(_propertyName))
            {
                ////whole file is the data
                if (_allowListOfObjects)
                    return JsonConvert.DeserializeObject<List<object[]>>(fileData);

                var obj = JsonConvert.DeserializeObject<object[]>(fileData);
                var objs = new List<object[]>() { obj  };
                return objs;
                
            }

            // Only use the specified property as the data
            var allData = JObject.Parse(fileData);
            var data = allData[_propertyName];
            return data.ToObject<IEnumerable<object[]>>();
        }

       
    }
}
