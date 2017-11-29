using EncompassRest.Filters;
using EncompassRest.LoanBatch;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class BatchUpdateTests
    {
        [TestMethod]
        public void BatchUpdateParameters_Serialization()
        {
            var batchUpdateParameters = new BatchUpdateParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new Loan { Tltv = 85.00M });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""loanData"":{""tltv"":85.00}}", batchUpdateParameters.ToJson());
        }
    }
}
