using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public interface IHeaderLimit
    {
        string Name { get; }
        string RemainingName { get; }
        string LimitName { get; }
        Dictionary<string, decimal> Collection { get; set; }
        string Tag { get; }
        string Uri { get; }

        bool LogAll { get; }
    }
}
