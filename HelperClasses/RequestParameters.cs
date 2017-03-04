using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.HelperClasses
{
    public class RequestParameters : List<RequestParameter>
    {

        public RequestParameters()
        {

        }

        public void Add(string Key, string Value)
        {
            this.Add(new RequestParameter(Key, Value));
        }

        public override string ToString()
        {
            if (this.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("?");
                sb.Append(String.Join("&",this));

                return sb.ToString();
            }
            else
            {
                return "";
            }
        }

    }

    public class RequestParameter 
    {
        public RequestParameter(string Key, string Value)
        {
            key = Key;
            value = Value;
        }
        public string key { get; set; }
        public string value { get; set; }

        public override string ToString()
        {
            return key + "=" + value;
        }
    }
    public static class RequestParametersStatic
    {

        
    }
}
