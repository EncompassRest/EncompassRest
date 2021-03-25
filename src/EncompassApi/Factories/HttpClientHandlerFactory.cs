using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace EncompassApi.Factories
{
    public static class HttpClientHandlerFactory
    {
        public static IHttpClientBuilder AddHttpClientHandlerFactory(this IHttpClientBuilder httpClientBuilder, IServiceProvider s)
        {
            var options = s.GetService<Configuration.HttpClientOptions>();
            if (options != null)
            {
                var handler = new HttpClientHandler();

                if (options.CompressionOptions.DecompressionMethods != null && options.CompressionOptions.EnableAutoDecompression)
                {
                    DecompressionMethods decompressionMethods = DecompressionMethods.None;
                    foreach (var method in options.CompressionOptions.DecompressionMethods)
                    {
                        decompressionMethods |= method;

                    }
                }

                httpClientBuilder.ConfigurePrimaryHttpMessageHandler(h => handler);
            }

            return httpClientBuilder;
        }
    }
}
