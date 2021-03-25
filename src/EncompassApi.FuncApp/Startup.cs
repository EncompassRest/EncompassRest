using EncompassApi.Clients;
using EncompassApi.Configuration;
using EncompassApi.FuncApp.Configuration;
using EncompassApi.FuncApp.MessageHandlers;
using EncompassApi.MessageHandlers;
using EncompassApi.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Extensions.Http;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

[assembly: FunctionsStartup(typeof(EncompassApi.FuncApp.Startup))]

namespace EncompassApi.FuncApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .Enrich.WithExceptionDetails()
                .Enrich.FromLogContext()
#if DEBUG
                .MinimumLevel.Verbose()
                .WriteTo.Debug()
#endif
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            builder.Services.AddLogging(p => p.AddSerilog(logger));

            var encompassTokenClientOptions = ConfigHelper.GetEncompassTokenClientOptions();
            var fairwayTokenClientOptions = ConfigHelper.GetFairwayTokenClientOptions();

            var encompassIOptions = Options.Create(encompassTokenClientOptions);
            var fairwayIOptions = Options.Create(fairwayTokenClientOptions);

            builder.Services.AddSingleton(encompassIOptions);
            builder.Services.AddSingleton(fairwayIOptions);

            //builder.Services.AddOptions<EncompassTokenClientOptions>()
            //    .Configure<IConfiguration>((settings, configuration) =>
            //    {
            //        var configSection = configuration.GetSection(EncompassTokenClientOptions.EncompassTokenClient);
            //        encompassTokenClientOptions = configSection?.Get<EncompassTokenClientOptions>();
            //        configSection.Bind(settings);
            //    });

            //builder.Services.AddOptions<FairwayTokenClientOptions>()
            //    .Configure<IConfiguration>((settings, configuration) =>
            //    {
            //        var configSection = configuration.GetSection(FairwayTokenClientOptions.FairwayTokenClient);
            //        fairwayTokenClientOptions = configSection?.Get<FairwayTokenClientOptions>();
            //        configSection.Bind(settings);
            //    });

            //builder.Services.AddEncompassTokenHandlerWithRetry(encompassTokenClientOptions);
            //builder.Services.AddFairwayTokenHandlerWithRetry(fairwayTokenClientOptions);

            AddEncompassTokenHandlerWithInterceptor(builder, encompassTokenClientOptions);
        }

        public void AddFairwayTokenHandlerWithRetry(IFunctionsHostBuilder builder, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = fairwayTokenClientOptions.ClientId,
                ApiClientSecret = fairwayTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);

            IOptions<FairwayTokenClientOptions> tokenClientIOptions = Options.Create(fairwayTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(fairwayTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(fairwayTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(tokenClientIOptions);
            builder.Services.AddHttpClient(fairwayTokenClientOptions.ClientName)
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp => 
                new FairwayTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(fairwayTokenClientOptions.ClientName), tokenClientIOptions));

            builder.Services.AddHttpClient("EncompassClient")
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()));

            builder.Services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));
        }

        public void AddEncompassTokenHandlerWithRetry(IFunctionsHostBuilder builder, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = encompassTokenClientOptions.ClientId,
                ApiClientSecret = encompassTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);

            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(options);
            builder.Services.AddHttpClient(encompassTokenClientOptions.ClientName, c => {
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            $"{WebUtility.UrlEncode(encompassTokenClientOptions.ClientId)}:{WebUtility.UrlEncode(encompassTokenClientOptions.ClientSecret)}")));
            })
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp =>
                new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(encompassTokenClientOptions.ClientName), options));

            builder.Services.AddHttpClient("EncompassClient", c =>
            {
                c.BaseAddress = new Uri(encompassTokenClientOptions.BaseUrl);
            })
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()));

            builder.Services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));
        }

        public void AddFairwayTokenHandlerWithInterceptor(IFunctionsHostBuilder builder, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = fairwayTokenClientOptions.ClientId,
                ApiClientSecret = fairwayTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);

            IOptions<FairwayTokenClientOptions> tokenClientIOptions = Options.Create(fairwayTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(fairwayTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(fairwayTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(tokenClientIOptions);
            builder.Services.AddHttpClient(fairwayTokenClientOptions.ClientName)
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp =>
                new FairwayTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(fairwayTokenClientOptions.ClientName), tokenClientIOptions));

            builder.Services.AddHttpClient("EncompassClient")
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()))
                .AddHttpMessageHandler<AuthHeaderInterceptorHandler>();

            builder.Services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));
        }

        public void AddEncompassTokenHandlerWithInterceptor(IFunctionsHostBuilder builder, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            var clientParameters = new ClientParameters
            {
                ApiClientId = encompassTokenClientOptions.ClientId,
                ApiClientSecret = encompassTokenClientOptions.ClientSecret
            };
            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);

            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(options);
            builder.Services.AddHttpClient(encompassTokenClientOptions.ClientName, c => {
                c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            $"{WebUtility.UrlEncode(encompassTokenClientOptions.ClientId)}:{WebUtility.UrlEncode(encompassTokenClientOptions.ClientSecret)}")));
            })
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp =>
                new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(encompassTokenClientOptions.ClientName), options));

            builder.Services
                .AddEncompassHttpClient(o =>
                {
                    o.BaseAddress = new Uri(encompassTokenClientOptions.BaseUrl);
                    o.CompressionOptions = new HttpClientCompressionHandlerOptions()
                    {
                        DecompressionMethods = new DecompressionMethods[] { DecompressionMethods.GZip, DecompressionMethods.Deflate },
                        EnableAutoDecompression = true
                    };
                })
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()))
                .AddHttpMessageHandler(sp => new AuthHeaderInterceptorHandler(sp.GetService<ILogger<AuthHeaderInterceptorHandler>>()))
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddTransient<IEncompassApiClient>(sp => new EncompassApiService(sp.GetService<IHttpClientFactory>().CreateClient("EncompassClient"), clientParameters));
        }

        
    }
}
