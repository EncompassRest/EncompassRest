using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using EncompassREST.HelperClasses;

namespace EncompassREST
{
    public static class HelperStatics
    {

        //accesstoken
        public static FormUrlEncodedContent buildPostContent(this RequestParameters Items)
        {
            var kvp = Items.Select(x => new KeyValuePair<string, string>(x.key, x.value)).ToList();

            FormUrlEncodedContent content = new FormUrlEncodedContent(kvp);
            return content;
        }

    }
}
