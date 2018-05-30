using System;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class BorrowerPairsTests : TestBaseClass
    {
        [TestMethod]
        public async Task BorrowerPairs_ReflectToLoanObject()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            Assert.AreEqual(0, loan.Applications.Count);
            loan.LoanApis.ReflectToLoanObject = true;
            var borrowerPairs = await loan.LoanApis.BorrowerPairs.GetBorrowerPairsAsync();
            Assert.IsTrue(loan.Applications.Count > 0);
            Assert.AreEqual(borrowerPairs.Count, loan.Applications.Count);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            var oldCount = loan.Applications.Count;
            var application = new Application();
            var applicationId = await loan.LoanApis.BorrowerPairs.CreateBorrowerPairAsync(application);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(oldCount + 1, loan.Applications.Count);
            Assert.AreSame(application, loan.Applications.First(a => a.ApplicationId == applicationId));
            application.ApplicationSignedDate = DateTime.Now.AddDays(-5);
            var newApplication = new Application { ApplicationId = applicationId, ApplicationSignedDate = DateTime.Now.AddDays(2) };
            await loan.LoanApis.BorrowerPairs.UpdateBorrowerPairAsync(newApplication);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(newApplication.ApplicationSignedDate, loan.Applications.First(a => a.ApplicationId == applicationId).ApplicationSignedDate);
            oldCount = loan.Applications.Count;
            Assert.IsTrue(await loan.LoanApis.BorrowerPairs.DeleteBorrowerPairAsync(applicationId));
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(oldCount - 1, loan.Applications.Count);
            Assert.IsNull(loan.Applications.FirstOrDefault(a => a.ApplicationId == applicationId));
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }

        [TestMethod]
        public async Task BorrowerPairs_DontReflectToLoanObject()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            Assert.AreEqual(0, loan.Applications.Count);
            await BorrowerPairsTest(client, loan, loanId, loan.LoanApis);
        }

        [TestMethod]
        public async Task BorrowerPairs()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            Assert.AreEqual(0, loan.Applications.Count);
            await BorrowerPairsTest(client, loan, loanId, client.Loans.GetLoanApis(loanId));
        }

        private static async Task BorrowerPairsTest(EncompassRestClient client, Loan loan, string loanId, LoanApis loanApis)
        {
            var borrowerPairs = await loanApis.BorrowerPairs.GetBorrowerPairsAsync();
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(0, loan.Applications.Count);
            var application = new Application();
            var applicationId = await loanApis.BorrowerPairs.CreateBorrowerPairAsync(application);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(0, loan.Applications.Count);
            var newApplication = new Application { ApplicationId = applicationId, ApplicationSignedDate = DateTime.Now.AddDays(2) };
            await loanApis.BorrowerPairs.UpdateBorrowerPairAsync(newApplication);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(0, loan.Applications.Count);
            Assert.IsTrue(await loanApis.BorrowerPairs.DeleteBorrowerPairAsync(applicationId));
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToJson());
            Assert.AreEqual(0, loan.Applications.Count);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }
    }
}