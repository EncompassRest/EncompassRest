using EncompassApi.Configuration;
using EncompassApi.Extensions;
using EncompassApi.xUnitTests.TestServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EncompassApi.xUnitTests.Extensions
{
   public static class ServiceExtensions
    {
        public static IServiceCollection AddMockedEncompassHttpClient(this IServiceCollection services, Action<HttpClientOptions> config, Action<HttpClient> configureClient)
        {
            services.AddTransient<IMockedEncompassHttpClientService, MockedEncompassHttpClientService>();
            return services;
        }

        public static IServiceCollection AddMockedEncompassHttpClient(this IServiceCollection services,  Action<HttpClient> configureClient)
        {
            services.AddTransient<IMockedEncompassHttpClientService, MockedEncompassHttpClientService>();
            return services;
        }

        public static IServiceCollection AddMockedEncompassHttpClient(this IServiceCollection services, Action<HttpClientOptions> config)
        {
            services.AddTransient<IMockedEncompassHttpClientService, MockedEncompassHttpClientService>();
            return services;
        }

        public static IServiceCollection AddMockedEncompassHttpClient(this IServiceCollection services)
        {
            services.AddTransient<IMockedEncompassHttpClientService, MockedEncompassHttpClientService>();
            return services;
        }


    }
}
