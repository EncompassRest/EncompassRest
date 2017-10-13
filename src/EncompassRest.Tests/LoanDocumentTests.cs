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
            document.Dirty = false;
            Assert.AreEqual("{}", document.ToJson());
            document.StatusString = "ready to ship";
            Assert.IsNull(document.Status);
            Assert.AreEqual(@"{""status"":""ready to ship""}", document.ToJson());
            document.Dirty = false;
            Assert.AreEqual("{}", document.ToJson());
            document.Status = DocumentStatus.Added;
            Assert.AreEqual("added", document.StatusString);
            Assert.AreEqual(@"{""status"":""added""}", document.ToJson());
        }
    }
}