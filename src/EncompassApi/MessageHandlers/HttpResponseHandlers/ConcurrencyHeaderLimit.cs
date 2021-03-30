using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class ConcurrencyHeaderLimit : IHeaderLimit
    {
        public ConcurrencyHeaderLimit(string tag, string uri)
        {
            Tag = tag;
            Uri = uri;
            Collection = new Dictionary<string, decimal>();
        }

        public Dictionary<string, decimal> Collection { get; set; }

        public string Tag { get; }
        public string Uri { get; }

    }
}
