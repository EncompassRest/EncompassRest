using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EncompassRest.Tests
{
    [TestClass]
    public class MockingTests : TestBaseClass
    {
        [TestMethod]
        public async Task MockTest()
        {
            var loanId = "abc";
            var client = Mock.Of<IEncompassRestClient>();
#pragma warning disable CS0618 // Type or member is obsolete
            LoansExtensions.V1 = Mock.Of<ILoansV1>(l => l.GetLoanAsync(loanId, null, default) == Task.FromResult(new Loan { Id = loanId }));
#pragma warning restore CS0618 // Type or member is obsolete
            var loan = await client.Loans.GetLoanAsync(loanId);
            Assert.AreEqual(loanId, loan.Id);
        }
    }
}