using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;
using FluentAssertions;
using EncompassApi.MessageHandlers;
using System.Collections.Generic;

namespace EncompassApi.xUnitTests
{
    public class HeaderLimitFactoryTest
    {
        private readonly ILogger<HeaderLimitFactoryTest> _logger;

        public HeaderLimitFactoryTest(ILogger<HeaderLimitFactoryTest> logger)
        {
            _logger = logger;
        }

        [Theory]
        [InlineData("X-Concurrency-Limit-Limit", "X-Concurrency-Limit-Remaining")]
        [InlineData("X-Rate-Limit-Limit", "X-Rate-Limit-Remaining")]
        public void GetRemainingLimitRatioTest(string header1, string header2)
        {
            var mockedFactory = new Mock<HeaderLimitFactory<IHeaderLimit>>();
            mockedFactory.SetupGet(_ => _.Dic).Returns(new System.Collections.Concurrent.ConcurrentDictionary<string, IHeaderLimit>());
            
            var mockedHeader = new Mock<IHeaderLimit>();
            mockedHeader.Setup(_ => _.LimitName).Returns(header1);
            mockedHeader.Setup(_ => _.RemainingName).Returns(header2);
            Dictionary<string, decimal> col = new Dictionary<string, decimal>();
            mockedHeader.Setup(_ => _.Collection).Returns(col);
            var limitFakerNum = (Faker.RandomNumber.Next(10, 99));
            var remainingFakerNum =(Faker.RandomNumber.Next(10, 99));
            var expectedValue = Math.Round((decimal)remainingFakerNum / (decimal)limitFakerNum, 2) * 100;
            mockedHeader.Setup(_ => _.Tag).Returns(Guid.NewGuid().ToString());

            mockedFactory.Object.AddToDictionary(mockedHeader.Object, header1, limitFakerNum);
            mockedFactory.Object.AddToDictionary(mockedHeader.Object, header2, remainingFakerNum);
            var mockedRatio = mockedFactory.Object.GetRemainingLimitRatio(mockedHeader.Object);
            mockedRatio.Should().Be(expectedValue);

        }
    }
}
