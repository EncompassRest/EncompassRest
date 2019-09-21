using System;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class BorrowerPairsTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task BorrowerPairs_ReflectToLoanObject()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client)
            {
                Applications = new[]
                {
                    new Application
                    {
                        Borrower = new Borrower { FirstName = "John", LastName = "Doe" }, Coborrower = new Borrower { FirstName = "Brenda", LastName = "Smith" }
                    }
                }
            };
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                loan = new Loan(client, loanId);
                Assert.AreEqual(0, loan.Applications.Count);
                loan.LoanApis.ReflectToLoanObject = true;
                var borrowerPairs = await loan.LoanApis.BorrowerPairs.GetBorrowerPairsAsync();
                Assert.AreSame(loan.Applications, borrowerPairs);
                Assert.IsTrue(loan.Applications.Count > 0);
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                var oldCount = loan.Applications.Count;
                var application = new Application();
                var applicationId = await loan.LoanApis.BorrowerPairs.CreateBorrowerPairAsync(application);
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(oldCount + 1, loan.Applications.Count);
                Assert.AreSame(application, loan.Applications.First(a => a.Id == applicationId));
                application.ApplicationSignedDate = DateTime.Now.AddDays(-5);
                var newApplication = new Application { Id = applicationId, ApplicationSignedDate = DateTime.Now.AddDays(2), Borrower = new Borrower { FirstName = "Bob", LastName = "Smith" }, Coborrower = new Borrower { FirstName = "Jane", LastName = "Doe" } };
                await loan.LoanApis.BorrowerPairs.UpdateBorrowerPairAsync(newApplication);
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(newApplication.ApplicationSignedDate, loan.Applications.First(a => a.Id == applicationId).ApplicationSignedDate);

                borrowerPairs = await loan.LoanApis.BorrowerPairs.GetBorrowerPairsAsync();
                Assert.AreEqual(2, borrowerPairs.Count);
                await loan.LoanApis.BorrowerPairs.MoveBorrowerPairsAsync(new[] { new Application { Id = borrowerPairs[0].Id, ApplicationIndex = borrowerPairs[1].ApplicationIndex, Borrower = new Borrower { AltId = borrowerPairs[0].Borrower.AltId }, Coborrower = new Borrower { AltId = borrowerPairs[1].Coborrower.AltId } }, new Application { Id = borrowerPairs[1].Id, ApplicationIndex = borrowerPairs[0].ApplicationIndex, Borrower = new Borrower { AltId = borrowerPairs[0].Coborrower.AltId }, Coborrower = new Borrower { AltId = borrowerPairs[1].Borrower.AltId } } });

                Assert.AreEqual(2, loan.Applications.Count);
                var firstApplication = loan.Applications.First(app => app.ApplicationIndex == 0);
                Assert.AreEqual("Brenda Smith", firstApplication.Borrower.FullName);
                Assert.AreEqual("Bob Smith", firstApplication.Coborrower.FullName);
                var secondApplication = loan.Applications.First(app => app.ApplicationIndex == 1);
                Assert.AreEqual("John Doe", secondApplication.Borrower.FullName);
                Assert.AreEqual("Jane Doe", secondApplication.Coborrower.FullName);

                borrowerPairs = await loan.LoanApis.BorrowerPairs.GetBorrowerPairsAsync();
                Assert.AreEqual(2, borrowerPairs.Count);
                Assert.AreEqual("Brenda Smith", borrowerPairs[0].Borrower.FullName);
                Assert.AreEqual("Bob Smith", borrowerPairs[0].Coborrower.FullName);
                Assert.AreEqual("John Doe", borrowerPairs[1].Borrower.FullName);
                Assert.AreEqual("Jane Doe", borrowerPairs[1].Coborrower.FullName);

                oldCount = loan.Applications.Count;
                Assert.IsTrue(await loan.LoanApis.BorrowerPairs.DeleteBorrowerPairAsync(applicationId));
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(oldCount - 1, loan.Applications.Count);
                Assert.IsNull(loan.Applications.FirstOrDefault(a => a.Id == applicationId));
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

        [TestMethod]
        [ApiTest]
        public async Task BorrowerPairs_DontReflectToLoanObject()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            Assert.AreEqual(0, loan.Applications.Count);
            await BorrowerPairsTest(client, loan, loanId, loan.LoanApis);
        }

        [TestMethod]
        [ApiTest]
        public async Task BorrowerPairs()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            Assert.AreEqual(0, loan.Applications.Count);
            await BorrowerPairsTest(client, loan, loanId, client.Loans.GetLoanApis(loanId));
        }

        private static async Task BorrowerPairsTest(IEncompassRestClient client, Loan loan, string loanId, ILoanApis loanApis)
        {
            try
            {
                var borrowerPairs = await loanApis.BorrowerPairs.GetBorrowerPairsAsync();
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(0, loan.Applications.Count);
                var application = new Application();
                var applicationId = await loanApis.BorrowerPairs.CreateBorrowerPairAsync(application);
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(0, loan.Applications.Count);
                var newApplication = new Application { Id = applicationId, ApplicationSignedDate = DateTime.Now.AddDays(2) };
                await loanApis.BorrowerPairs.UpdateBorrowerPairAsync(newApplication);
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(0, loan.Applications.Count);
                Assert.IsTrue(await loanApis.BorrowerPairs.DeleteBorrowerPairAsync(applicationId));
                Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}""}}", loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(0, loan.Applications.Count);
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