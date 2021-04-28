using EncompassApi.xUnitTests.TestServices;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Xunit.DependencyInjection.Logging;

namespace EncompassApi.xUnitTests
{
    public class InjectionTest
    {
        private readonly ITestOutputHelper _outputWriter;

        public ITestDependencycs _testService { get; }

        private readonly ILogger<InjectionTest> _logger;

        public InjectionTest(ITestOutputHelper outputWriter, ILogger<InjectionTest> logger, TestServices.ITestDependencycs testDependencycs) 
        {
            _outputWriter = outputWriter;
            _testService = testDependencycs;
            _logger = logger;
        }

        [Fact]
        public void Test()
        {
            var result = _testService.TestMethod(5);
            _logger.LogDebug("LogDebug");
            _logger.LogInformation("LogInformation");
            _logger.LogError("LogError");
            _outputWriter.WriteLine("Test completed!");
            Assert.Equal( 5, result);
        }
    }
}
