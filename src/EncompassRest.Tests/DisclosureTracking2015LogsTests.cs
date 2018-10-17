using System.Threading.Tasks;
using EncompassRest.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class DisclosureTracking2015LogsTests : TestBaseClass
    {
        [TestMethod]
        public async Task GetLogs()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                var logs = await loan.LoanApis.DisclosureTracking2015Logs.GetDisclosureTrackingLogsAsync();
                Assert.AreEqual(0, logs.Count);
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }
    }
}