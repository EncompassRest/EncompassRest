using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncompassApi.Configuration
{
    public class EncompassHttpResponseHeaderLoggerOptions : IEnumerable<string>
    {
        public List<string> TList
        { get; private set; }
        public EncompassHttpResponseHeaderLoggerOptions(params string[] headers)
        {
            TList = new List<string>(headers);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return TList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
