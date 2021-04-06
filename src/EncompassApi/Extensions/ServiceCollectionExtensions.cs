using EncompassApi.Clients;
using EncompassApi.Configuration;
using EncompassApi.MessageHandlers;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using Polly;
using Polly.Extensions.Http;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace EncompassApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddClientWithEncompassTokenHandler(this IServiceCollection services, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = encompassTokenClientOptions.ClientId,
                ApiClientSecret = encompassTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            services.AddSingleton(clientParameters);

            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            services.AddSingleton(options);

            services.AddHttpClient<ITokenClient, EncompassTokenClient>(c => 
            {
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            $"{WebUtility.UrlEncode(encompassTokenClientOptions.ClientId)}:{WebUtility.UrlEncode(encompassTokenClientOptions.ClientSecret)}")));
            })
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);


            services.AddHttpClient<IEncompassApiClient, EncompassApiService>(c =>
            {
                c.BaseAddress = new Uri(encompassTokenClientOptions.BaseUrl);
            })
                .AddHttpMessageHandler<TokenHandler>()
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            return services;
        }

        public static IServiceCollection AddClientWithFairwayTokenHandler(this IServiceCollection services, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = fairwayTokenClientOptions.ClientId,
                ApiClientSecret = fairwayTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            services.AddSingleton(clientParameters);

            IOptions<FairwayTokenClientOptions> tokenClientIOptions = Options.Create(fairwayTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(fairwayTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(fairwayTokenClientOptions.TimeoutInSeconds);

            services.AddSingleton(tokenClientIOptions);
            services.AddHttpClient<ITokenClient, FairwayTokenClient>()
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddHttpClient<IEncompassApiClient, EncompassApiService>(c =>
            {
                c.BaseAddress = new Uri(fairwayTokenClientOptions.BaseUrl);
            })
                .AddHttpMessageHandler<TokenHandler>()
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));

            return services;
        }
        [Obsolete("This method is deprecated. Use AddClientWithEncompassTokenHandler instead")]
        public static IServiceCollection AddEncompassTokenHandlerWithRetry(this IServiceCollection services, EncompassTokenClientOptions encompassTokenClientOptions) => AddClientWithEncompassTokenHandler(services, encompassTokenClientOptions);

        [Obsolete("This method is deprecated. Use AddClientWithFairwayTokenHandler instead")]
        public static IServiceCollection AddFairwayTokenHandlerWithRetry(this IServiceCollection services, FairwayTokenClientOptions fairwayTokenClientOptions) => AddClientWithFairwayTokenHandler(services, fairwayTokenClientOptions);

        public static IHttpClientBuilder AddEncompassTokenHandler(this IServiceCollection services, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);
            services.AddSingleton(options);

            return services.AddHttpClient<ITokenClient, EncompassTokenClient>(c =>
            {
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            $"{WebUtility.UrlEncode(encompassTokenClientOptions.ClientId)}:{WebUtility.UrlEncode(encompassTokenClientOptions.ClientSecret)}")));
            });
        }

        public static IHttpClientBuilder AddFairwayTokenHandler(this IServiceCollection services, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
            IOptions<FairwayTokenClientOptions> options = Options.Create(fairwayTokenClientOptions);
            services.AddSingleton(options);

            return services.AddHttpClient<ITokenClient, FairwayTokenClient>();
        }

        public static IHttpClientBuilder AddEncompassApiClient(this IServiceCollection services, BaseHttpClientOptions baseOptions, string clientId, string clientSecret, CacheInitialization cacheInitialization = CacheInitialization.Never)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = clientId,
                ApiClientSecret = clientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = cacheInitialization;
            services.AddSingleton(clientParameters);

            return services.AddHttpClient<IEncompassApiClient, EncompassApiService>(c =>
            {
                c.BaseAddress = new Uri(baseOptions.BaseUrl);
            })
                .AddHttpMessageHandler<TokenHandler>();
        }

        public static EncompassHttpClientBuilder AddEncompassHttpClient(this IServiceCollection services, Action<HttpClient> config)
        {
            services.Configure(config);
            var httpClient = services.AddHttpClient("EncompassClient", config);

            return new EncompassHttpClientBuilder(httpClient, services);
        }

        public static EncompassHttpClientBuilder AddEncompassHttpClient(this IServiceCollection services , Action<HttpClientOptions> config)
        {
            services._addHttpClientOptions(config);

            var httpClient = services.AddHttpClient("EncompassClient", (s, c) =>
             {
                 var options = s.GetRequiredService<IOptions<HttpClientOptions>>();
                 if (options != null)
                 {
                     
                     foreach (var encoding in options.Value.CompressionOptions.DecompressionMethods)
                     {
                         c.DefaultRequestHeaders.Add(name: "Accept-Encoding", value: encoding.ToString());
                     }
                 }

             }).ConfigurPrimaryHttpClientHandler(services.BuildServiceProvider());

            return new EncompassHttpClientBuilder(httpClient, services);
        }

        public static EncompassHttpClientBuilder AddEncompassHttpClient(this IServiceCollection services, Action<HttpClientOptions> config, Action<HttpClient> configureClient)
        {
            services._addHttpClientOptions(config);
      
            var httpClient = services.AddHttpClient("EncompassClient", (s, c) =>
            {
                var options = s.GetRequiredService<IOptions<HttpClientOptions>>();
                if (options != null && options.Value.CompressionOptions.DecompressionMethods != null)
                {
                    foreach (var encoding in options.Value.CompressionOptions.DecompressionMethods)
                    {
                        c.DefaultRequestHeaders.Add(name: "Accept-Encoding", value: encoding.ToString());
                    }
                }

            }).ConfigurPrimaryHttpClientHandler(services.BuildServiceProvider());

            httpClient.ConfigureHttpClient(configureClient);
            
            return new EncompassHttpClientBuilder(httpClient, services);

        }

        static void _addHttpClientOptions(this IServiceCollection services, Action<HttpClientOptions> config)
        {
            HttpClientOptions httpClientOptions = new HttpClientOptions();
            config(httpClientOptions);
            services.PostConfigure(config);
        }
    }

}
