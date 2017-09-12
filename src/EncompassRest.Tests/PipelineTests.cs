using EncompassRest.Filters;
using EncompassRest.LoanPipeline;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class PipelineTests
    {
        [TestMethod]
        public void ViewPipelineParameters_Serialization()
        {
            var parameters = new ViewPipelineParameters(new StringFieldFilter(CanonicalField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new[] { "Fields.364", "Fields.4002" });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""fields"":[""Fields.364"",""Fields.4002""]}", parameters.ToJson());
        }
    }
}
