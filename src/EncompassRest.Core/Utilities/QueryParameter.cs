using System.Net;

namespace EncompassRest.Utilities
{
    internal sealed class QueryParameter 
    {
        public string Name { get; }

        public string? Value { get; }

        public QueryParameter(string name, string? value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString() => $"{WebUtility.UrlEncode(Name)}={WebUtility.UrlEncode(Value)}";
    }
}