using System.Threading.Tasks;
using EncompassRest.Loans;
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
            var client = Mock.Of<IEncompassRestClient>(c => c.Loans.GetLoanAsync(loanId, default) == Task.FromResult(new Loan() { Id = loanId }));
            var loan = await client.Loans.GetLoanAsync(loanId);
            Assert.AreEqual(loanId, loan.Id);
        }
    }
}