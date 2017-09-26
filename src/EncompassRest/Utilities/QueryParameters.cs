using System.Collections.Generic;

namespace EncompassRest.Utilities
{
    internal sealed class QueryParameters
    {
        private readonly List<QueryParameter> _parameters;

        public QueryParameters()
        {
            _parameters = new List<QueryParameter>();
        }

        public QueryParameters(params QueryParameter[] parameters)
        {
            _parameters = new List<QueryParameter>(parameters);
        }

        public void Add(string name, string value) => Add(new QueryParameter(name, value));

        public void Add(QueryParameter parameter) => _parameters.Add(parameter);

        public override string ToString() => _parameters.Count > 0 ? $"?{string.Join("&", _parameters)}" : string.Empty;
    }
}
