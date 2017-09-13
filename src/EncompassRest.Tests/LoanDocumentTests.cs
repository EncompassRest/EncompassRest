using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanDocumentTests
    {
        [TestMethod]
        public void LoanDocument_Serialization()
        {
            var document = new LoanDocument { Title = "Mortgage Insurance" };
            Assert.AreEqual(@"{""title"":""Mortgage Insurance""}", document.ToJson());
        }
    }
}