using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Xunit.DependencyInjection;
using Xunit.DependencyInjection.Logging;
using EncompassApi.xUnitTests.TestServices;
using EncompassApi.xUnitTests.Extensions;

namespace EncompassApi.xUnitTests
{
    public partial class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.UseServiceProviderFactory(new AutofacServiceProviderFactory());

        public void ConfigureServices(IServiceCollection services) =>
            services.AddLogging(builder => builder.SetMinimumLevel(LogLevel.Debug))
            .AddScoped<ITestDependencycs, TestDependency>()
            .AddMockedEncompassHttpClient();

        public void Configure(ILoggerFactory loggerFactory, ITestOutputHelperAccessor accessor) =>
            loggerFactory.AddProvider(new XunitTestOutputLoggerProvider(accessor, delegate { return true; }));
    }
}
