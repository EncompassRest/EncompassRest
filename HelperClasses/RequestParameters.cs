using System;
using System.Collections.Generic;
using System.Text;

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
            if (Count > 0)
            {
                var sb = new StringBuilder();
                sb.Append('?');
                var first = true;
                foreach (var requestParameter in this)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        sb.Append('&');
                    }
                    sb.Append(requestParameter);
                }

                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
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
