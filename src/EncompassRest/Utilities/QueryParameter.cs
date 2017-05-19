using System.Web;

namespace EncompassRest.Utilities
{
    internal sealed class QueryParameter 
    {
        public string Name { get; }

        public string Value { get; }

        public QueryParameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString() => $"{HttpUtility.UrlEncode(Name)}={HttpUtility.UrlEncode(Value)}";
    }
}