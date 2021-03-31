using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class ConcurrencyHeaderLimit : IHeaderLimit
    {
        public ConcurrencyHeaderLimit(string name, string tag, string uri, bool logAll = false)
        {
            Name = name;
            Tag = tag;
            Uri = uri;
            Collection = new Dictionary<string, decimal>();
            LogAll = logAll;
        }

        public Dictionary<string, decimal> Collection { get; set; }

        public string Tag { get; }
        public string Uri { get; }

        public string Name { get; }

        public string RemainingName => "X-Concurrency-Limit-Remaining";

        public string LimitName => "X-Concurrency-Limit-Limit";

        public bool LogAll { get; }
    }
}
