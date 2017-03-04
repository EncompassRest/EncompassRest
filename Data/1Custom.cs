using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class EntityReference { }
    public class FileAttachmentReference { }

    public partial class Loan
    {
        
      
        internal string _StartingData;
        internal Session _Session;

        internal Documents _Documents;

        public Documents Documents
        {
            get { return _Documents; }
        }


        public Loan(Session eSession)
        {
            _Session = eSession;
            _Documents = new EncompassREST.Documents(this);
        }

        
        public void Clear()
        {
            Type type = this.GetType(); 

            var propList = type.GetProperties();
            foreach (PropertyInfo prop in propList)
            {
                if (prop.GetCustomAttributes(typeof(JsonIgnoreAttribute),false).Count()==0)
                {
                    Object obj = prop.GetValue(this, null);
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
            _StartingData = "";
        }


        [JsonIgnore]
        public string RawData
        {
            get { return _StartingData; }
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
        public Session Session
        {
            get { return _Session; }
        }

        
    }

    
}
