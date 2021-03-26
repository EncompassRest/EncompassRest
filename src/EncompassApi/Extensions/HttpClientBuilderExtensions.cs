using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
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
            var options = s.GetRequiredService<IOptions<Configuration.HttpClientOptions>>();
            if (options != null)
            {
                var handler = new HttpClientHandler();

                if (options.Value.CompressionOptions.DecompressionMethods != null && options.Value.CompressionOptions.EnableAutoDecompression)
                {
                    // DecompressionMethods.None should be removed
                    DecompressionMethods decompressionMethods = DecompressionMethods.None;
                    for (int i = 0; i < options.Value.CompressionOptions.DecompressionMethods.Count(); i++)
                    {
                        if (i == 0) { decompressionMethods = options.Value.CompressionOptions.DecompressionMethods.ElementAt(i); }
                        else { decompressionMethods |= options.Value.CompressionOptions.DecompressionMethods.ElementAt(i); }

                    }
                    handler.AutomaticDecompression = decompressionMethods;
                }

                httpClientBuilder.ConfigurePrimaryHttpMessageHandler(h => handler);
            }

            return httpClientBuilder;
        }
    }
}
