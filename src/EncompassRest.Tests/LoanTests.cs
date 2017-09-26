using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanTests : TestBaseClass
    {
        [TestMethod]
        public void Loan_Empty_Serialization()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NonNullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = 85.00M
            };
            Assert.AreEqual(@"{""tltv"":85.00}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = null
            };
            Assert.AreEqual(@"{""tltv"":null}", loan.ToJson());
        }

        [TestMethod]
        public async Task Loan_CreateAndDelete()
        {
            using (var client = GetTestClient())
            {
                var loan = new Loan();
                var loanId = await client.Loans.CreateLoanAsync(loan, true).ConfigureAwait(false);
                await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false);
            }
        }
    }
}
 