using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace EncompassRest.Data
{
    public class EntityReference { }
    public class FileAttachmentReference { }

    public partial class Loan
    {
        internal string _startingData;
        internal EncompassRestClient _client;

        internal Documents _Documents;

        public Documents Documents
        {
            get { return _Documents; }
        }

        public Loan(EncompassRestClient client)
        {
            _client = client;
            _Documents = new EncompassRest.Documents(this);
        }
        
        public void Clear()
        {
            Type type = GetType(); 

            var propList = type.GetProperties();
            foreach (PropertyInfo prop in propList)
            {
                if (prop.GetCustomAttributes(typeof(JsonIgnoreAttribute),false).Count()==0)
                {
                    var obj = prop.GetValue(this, null);
                    if (obj == null)
                        continue;

                    if (obj.GetType().IsValueType)
                    {
                        prop.SetValue(this, null);
                        continue;
                    }

                    if (Nullable.GetUnderlyingType(obj.GetType())!= null)
                    {
                        prop.SetValue(this, null);
                        continue;
                    }

                    if (obj.GetType() == typeof(string))
                    {
                        prop.SetValue(this, "");
                        continue;
                    }
                }
            }
            _startingData = "";
        }

        [JsonIgnore]
        public string RawData
        {
            get { return _startingData; }
        }

        [JsonIgnore]
        public string JsonValue
        {
            get
            {
                return Serialization.NewtonsoftJsonSerializer.Default.Serialize(this);
                //return JsonConvert.SerializeObject(this,);
            }
        }

        [JsonIgnore]
        public EncompassRestClient Client
        {
            get { return _client; }
        }
    }
}
