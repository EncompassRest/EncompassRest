using EncompassApi.FuncApp.Configuration;
using EncompassApi.MessageHandlers;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Extensions.Http;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

            //TODO: Real dev values and Options Pattern
            var httpClientOptions = new HttpClientOptions
            {
                Retry = true,
                RetryCount = 3,
                TimeoutInSeconds = 30,
                ClientURL = "http://localhost:7071/api/",
                ClientName = "TestClient"
            };

            var clientParameters = new ClientParameters("ApiClientId", "ApiClientSecret");

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);
            AddSingleClientHttpClient(builder, httpClientOptions);
        }

        public void AddSingleClientHttpClient(IFunctionsHostBuilder builder, HttpClientOptions httpOptions)
        {
            if (httpOptions.Retry)
            {
                var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(httpOptions.RetryCount);
                var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(httpOptions.TimeoutInSeconds);

                builder.Services.AddHttpClient(httpOptions.ClientName,
                  c => c.BaseAddress = new Uri(httpOptions.ClientURL))
                  .AddPolicyHandler(retryPolicy)
                  .AddPolicyHandler(timeoutPolicy);
                //token handler config here, calls will fail without token handler config and insert of handler using .AddHttpMessageHandler
                //TODO for MOR-177
                //TODO convert to Extension method in the library 
            }
            else
            {
                builder.Services.AddHttpClient(httpOptions.ClientName,
                  c =>
                  {
                      c.BaseAddress = new Uri(httpOptions.ClientURL);
                      c.Timeout = TimeSpan.FromSeconds(httpOptions.TimeoutInSeconds);
                  });
            }
        }

        public void AddFairwayTokenHandlerWithRetry(IFunctionsHostBuilder builder, HttpClientOptions httpOptions, TokenServiceClientOptions tokenServiceOptions)
        {
            IOptions<TokenServiceClientOptions> tokenClientIOptions = Options.Create(tokenServiceOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(httpOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(httpOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(tokenClientIOptions);
            builder.Services.AddHttpClient("TokenClient")
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenServiceClient>(sp => 
                new TokenServiceClient(sp.GetService<IHttpClientFactory>().CreateClient("TokenClient"), tokenClientIOptions));

            builder.Services.AddHttpClient("EncompassHttpClient", c => c.BaseAddress = new Uri(tokenServiceOptions.BaseUrl))
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenServiceClient>()));
        }
    }
}
