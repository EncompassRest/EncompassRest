using EncompassRest.Loans.Attachments;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanAttachmentTests
    {
        [TestMethod]
        public void LoanAttachment_Serialization()
        {
            var loanAttachment = new LoanAttachment { AttachmentType = AttachmentType.Image };
            Assert.AreEqual(@"{""attachmentType"":1}", loanAttachment.ToJson());
        }
    }
}
