using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace EncompassApi.Extensions
{
    public static class HttpClientBuilderExtensions
    {
        public static IHttpClientBuilder ConfigurPrimaryHttpClientHandler(this IHttpClientBuilder httpClientBuilder, IServiceProvider s)
        {
            var options = s.GetService<Configuration.HttpClientOptions>();
            if (options != null)
            {
                var handler = new HttpClientHandler();

                if (options.CompressionOptions.DecompressionMethods != null && options.CompressionOptions.EnableAutoDecompression)
                {
                    // DecompressionMethods.None should be removed
                    DecompressionMethods decompressionMethods = DecompressionMethods.None;
                    for (int i = 0; i < options.CompressionOptions.DecompressionMethods.Count(); i++)
                    {
                        if (i == 0) { decompressionMethods = options.CompressionOptions.DecompressionMethods.ElementAt(i); }
                        else { decompressionMethods |= options.CompressionOptions.DecompressionMethods.ElementAt(i); }

                    }
                }

                httpClientBuilder.ConfigurePrimaryHttpMessageHandler(h => handler);
            }

            return httpClientBuilder;
        }
    }
}
