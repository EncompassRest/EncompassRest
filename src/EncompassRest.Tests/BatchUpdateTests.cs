using EncompassRest.Filters;
using EncompassRest.LoanBatch.v1;
using EncompassRest.Loans.v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class BatchUpdateTests
    {
        [TestMethod]
        public void BatchUpdateParameters_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var batchUpdateParameters = new BatchUpdateParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new Loan { Tltv = 85.00M });
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""loanData"":{""tltv"":85.00}}", batchUpdateParameters.ToString(SerializationOptions.Dirty));
        }
    }
}
