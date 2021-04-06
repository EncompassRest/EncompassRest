using EncompassApi.xUnitTests.TestServices;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.DependencyInjection.Logging;

namespace EncompassApi.xUnitTests
{
    public class InjectionTest
    {
        private readonly ILogger<InjectionTest> _logger;

        public ITestDependencycs _testService { get; }

        public InjectionTest(ILogger<InjectionTest> logger, TestServices.ITestDependencycs testDependencycs) 
        {
            _logger = logger;
            _testService = testDependencycs;
        }

        [Fact]
        public void Test()
        {
            var result = _testService.TestMethod(5);
            _logger.LogDebug("LogDebug");
            _logger.LogInformation("LogInformation");
            _logger.LogError("LogError");
            Assert.Equal( 5, result);
        }
    }
}
