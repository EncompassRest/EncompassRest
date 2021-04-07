﻿using EncompassApi.Clients;
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

            var clientParameters = new ClientParameters
            {
                ApiClientId = encompassTokenClientOptions.ClientId,
                ApiClientSecret = encompassTokenClientOptions.ClientSecret
            };

            clientParameters.CustomFieldsCacheInitialization = EncompassApi.CacheInitialization.Never;

            var headers = new EncompassHttpResponseHeaderLoggerOptions();
            headers.AddRange("X-Concurrency-Limit-Limit", "X-Concurrency-Limit-Remaining", "X-Rate-Limit-Limit", "X-Rate-Limit-Remaining", "X-Rate-Limit-Reset");
            

            var httpClientOptions = new HttpClientOptions
            {
                ClientParameters = clientParameters,
                CompressionOptions = new HttpClientCompressionHandlerOptions()
                {
                    DecompressionMethods = new DecompressionMethods[] { DecompressionMethods.GZip },
                    EnableAutoDecompression = true
                },
                TokenClientOptions = encompassTokenClientOptions,
                EncompassHttpResponseHeaderLoggerOptions = headers
            };

            var httpClientIOptions = Options.Create(httpClientOptions);            
            var encompassIOptions = Options.Create(encompassTokenClientOptions);

            builder.Services.AddSingleton(clientParameters);
            //builder.Services.AddSingleton(httpClientIOptions); //this is added upon creation
            builder.Services.AddSingleton(encompassIOptions);

            builder.Services.AddEncompassTokenHandler(encompassTokenClientOptions)
                .AddPolicyHandler(HttpPolicyExtensions.HandleTransientHttpError().RetryAsync(encompassTokenClientOptions.RetryCount))
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(encompassTokenClientOptions.TimeoutInSeconds));

            builder.Services.AddEncompassHttpClient(options =>
            {
                options.CompressionOptions = new HttpClientCompressionHandlerOptions()
                {
                    DecompressionMethods = new DecompressionMethods[] { DecompressionMethods.GZip },
                    EnableAutoDecompression = true
                };
                options.ClientParameters = clientParameters;
                options.TokenClientOptions = encompassTokenClientOptions;
            },
            config => config.BaseAddress = new Uri(encompassTokenClientOptions.BaseUrl) )
                .AddEncompassTokenMessageHandler()
                .AddEncompassHttpResponseHeaderLoggingHandler()
                //.AddEncompassMessageHandler(sp => new AuthHeaderInterceptorHandler(sp.GetService<ILogger<AuthHeaderInterceptorHandler>>()))
                .AddEncompassRetryPolicyHandler()
                .AddEncompassTimeoutPolicyHandler()
                .Build(builder.Services);            
        }
    }
}
