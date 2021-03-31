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


        public EncompassHttpResponseHeaderLoggerOptions AddRange(params string[] items)
        {
            foreach (var item in items)
            {
                if (!TList.Any(h => h.Equals(item, StringComparison.OrdinalIgnoreCase)))
                {
                    TList.Add(item);
                }
            }
           
            return this;
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
