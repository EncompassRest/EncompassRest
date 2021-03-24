using EncompassApi.FuncApp.MessageHandlers;
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

            
            

            var clientParameters = new ClientParameters("ApiClientId", "ApiClientSecret");

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;
            builder.Services.AddSingleton(clientParameters);
            
        }

        public void AddFairwayTokenHandlerWithRetry(IFunctionsHostBuilder builder, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
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
        }

        public void AddEncompassTokenHandlerWithRetry(IFunctionsHostBuilder builder, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(options);
            builder.Services.AddHttpClient(encompassTokenClientOptions.ClientName)
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp =>
                new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(encompassTokenClientOptions.ClientName), options));

            builder.Services.AddHttpClient("EncompassClient")
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()));
        }

        public void AddFairwayTokenHandlerWithInterceptor(IFunctionsHostBuilder builder, FairwayTokenClientOptions fairwayTokenClientOptions)
        {
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
        }

        public void AddEncompassTokenHandlerWithInterceptor(IFunctionsHostBuilder builder, EncompassTokenClientOptions encompassTokenClientOptions)
        {
            IOptions<EncompassTokenClientOptions> options = Options.Create(encompassTokenClientOptions);

            var retryPolicy = HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount);
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds);

            builder.Services.AddSingleton(options);
            builder.Services.AddHttpClient(encompassTokenClientOptions.ClientName)
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy);

            builder.Services.AddScoped<ITokenClient>(sp =>
                new EncompassTokenClient(sp.GetService<IHttpClientFactory>().CreateClient(encompassTokenClientOptions.ClientName), options));

            builder.Services.AddHttpClient("EncompassClient")
                .AddPolicyHandler(retryPolicy)
                .AddPolicyHandler(timeoutPolicy)
                .AddHttpMessageHandler(sp => new TokenHandler(sp.GetService<ITokenClient>()))
                .AddHttpMessageHandler<AuthHeaderInterceptorHandler>();
        }
    }
}
