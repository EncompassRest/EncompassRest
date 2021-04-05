using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Xunit.DependencyInjection;
using Xunit.DependencyInjection.Logging;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.Extensions;
using EncompassApi.Configuration;
using System.Net;

namespace EncompassApi.xUnitTests
{
    public partial class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        public void ConfigureServices(IServiceCollection services) =>
            services.AddLogging(builder => builder.SetMinimumLevel(LogLevel.Debug))
            .AddScoped<ITestDependencycs, TestDependency>()
            .AddEncompassHttpClient(
                options =>
                {
                    options.CompressionOptions = new HttpClientCompressionHandlerOptions()
                    {
                        DecompressionMethods = new DecompressionMethods[] { DecompressionMethods.GZip, DecompressionMethods.Deflate },
                        EnableAutoDecompression = true
                    };
                    options.ClientParameters = new ClientParameters()
                    {
                        ApiClientId = "ApiCLientId",
                        ApiClientSecret = "ApiClientSecret"
                    };

                },
                config =>
                {
                    config.BaseAddress = new System.Uri("https://fakerapi.it/api");
                })
            .AddEncompassHttpResponseHeaderLoggingHandler()
            .Build(services);
            



        public void Configure(ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor) =>
            loggerFactory.AddProvider(new XunitTestOutputLoggerProvider(accessor, delegate { return true; }));
    }
}
