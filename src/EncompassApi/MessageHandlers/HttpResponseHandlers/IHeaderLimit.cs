using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public interface IHeaderLimit
    {
        Dictionary<string, decimal> Collection { get; set; }
        string Tag { get; }
        string Uri { get; }
    }
}
