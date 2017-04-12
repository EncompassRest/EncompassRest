using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using EncompassREST.HelperClasses;

namespace EncompassREST
{
    public static class HelperStatics
    {
        //accesstoken
        public static FormUrlEncodedContent BuildPostContent(this RequestParameters Items)
        {
            var kvp = Items.Select(x => new KeyValuePair<string, string>(x.Key, x.Value)).ToList();

            var content = new FormUrlEncodedContent(kvp);
            return content;
        }
    }
}
