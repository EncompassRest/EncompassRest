using System.Collections.Generic;

namespace EncompassREST.HelperClasses
{
    public class RequestParameters : List<RequestParameter>
    {
        public RequestParameters()
        {
        }

        public void Add(string key, string value)
        {
            Add(new RequestParameter(key, value));
        }

        public override string ToString()
        {
            return Count > 0 ? $"?{string.Join("&", this)}" : string.Empty;
        }
    }

    public class RequestParameter 
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public RequestParameter(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Key}={Value}";
        }
    }

    public static class RequestParametersStatic
    {
    }
}
