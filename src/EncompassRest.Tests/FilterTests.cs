using EncompassRest.Filters;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void Filter_Simple_Serialization()
        {
            var filter = new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans");
            Assert.AreEqual(@"{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""}", filter.ToJson());
        }

        [TestMethod]
        public void Filter_Advanced_Serialization()
        {
            var filter = new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans")
                .And(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 80000M));
            Assert.AreEqual(@"{""operator"":""and"",""terms"":[{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},{""matchType"":""greaterThanOrEquals"",""value"":80000.0,""canonicalName"":""Loan.LoanAmount""}]}", filter.ToJson());
        }
    }
}