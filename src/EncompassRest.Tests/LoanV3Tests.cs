using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.v3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public sealed class LoanV3Tests : LoanTests
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public override ILoan ConstructLoan() => new Loan();
#pragma warning restore CS0618 // Type or member is obsolete

        public override ILoan ConstructLoan(IEncompassRestClient client) => new Loan(client);

        public override ILoan ConstructLoan(IEncompassRestClient client, string loanId) => new Loan(client, loanId);

        public override Task<string> CreateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false) => client.Loans.CreateLoanAsync((Loan)loan, new LoanCreationOptions("My Pipeline") { View = populate ? LoanView.Full : LoanView.Id });

        public override Task DeleteLoanAsync(IEncompassRestClient client, string loanId) => client.Loans.DeleteLoanAsync(loanId);

        public override async Task<ILoan> GetLoanAsync(IEncompassRestClient client, string loanId) => await client.Loans.GetLoanAsync(loanId);

        public override Task UpdateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false) => client.Loans.UpdateLoanAsync((Loan)loan, new LoanUpdateOptions { View = populate ? LoanView.Full : LoanView.Id });

        [TestMethod]
        public void Loan_FieldsComplex()
        {
            var loan = ConstructLoan();
            var field = loan.Fields["VEND.X5"];
            Assert.AreEqual("loan.contacts[(contactType == 'CUSTOM' && customContactIndex == '4')].state", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = "MO";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM"",""customContactIndex"":4,""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            ((IDirty)loan).Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            value = "NY";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM"",""customContactIndex"":4,""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
        }
    }
}