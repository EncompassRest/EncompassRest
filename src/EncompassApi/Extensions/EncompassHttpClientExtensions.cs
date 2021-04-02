using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using EncompassApi.Configuration;

namespace EncompassApi.Extensions
{
    public static class EncompassHttpClientExtensions
    {
        public static void AddDefaultRequestHeaders(this HttpClient httpClient, IHttpClientOptions options)
        {
            if (options != null && options.CompressionOptions.DecompressionMethods != null)
            {
                foreach (var encoding in options.CompressionOptions.DecompressionMethods)
                {
                    httpClient.DefaultRequestHeaders.Add(name: "Accept-Encoding", value: encoding.ToString());
                }
            }
        }
    }
}
