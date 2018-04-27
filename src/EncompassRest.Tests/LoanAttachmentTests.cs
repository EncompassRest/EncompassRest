using System.IO;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Attachments;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanAttachmentTests : TestBaseClass
    {
        [TestMethod]
        public void LoanAttachment_Serialization()
        {
            var loanAttachment = new LoanAttachment { AttachmentType = AttachmentType.Image };
            Assert.AreEqual(@"{""attachmentType"":1}", loanAttachment.ToJson());
        }

        [TestMethod]
        public async Task LoanAttachments_Upload()
        {
            var client = await GetTestClientAsync();

            var loan = new Loan();
            var loanId = await client.Loans.CreateLoanAsync(loan);
            var attachment = new LoanAttachment
            {
                Title = "Testing Attachment",
                FileWithExtension = "Text.txt",
                CreateReason = AttachmentCreateReason.Upload
            };
            var text = "TESTING, TESTING, 1, 2, 3";
            var attachmentId = await loan.Attachments.UploadAttachmentAsync(attachment, Encoding.UTF8.GetBytes(text), true);
            Assert.IsFalse(string.IsNullOrEmpty(attachmentId));
            await Task.Delay(10000);
            var retrievedText = Encoding.UTF8.GetString(await loan.Attachments.DownloadAttachmentAsync(attachmentId));
            Assert.AreEqual(text, retrievedText);
            var stream = await loan.Attachments.DownloadAttachmentStreamAsync(attachmentId);
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                Assert.AreEqual(text, sr.ReadToEnd());
            }

            var newAttachment = new LoanAttachment
            {
                Title = "Bob",
                FileWithExtension = "Bobby.txt",
                CreateReason = AttachmentCreateReason.Upload
            };
            var newText = "This is a test of the emergency broadcast system, this is only a test.";
            var newAttachmentId = await loan.Attachments.UploadAttachmentAsync(newAttachment, new MemoryStream(Encoding.UTF8.GetBytes(newText)), true);
            Assert.IsFalse(string.IsNullOrEmpty(newAttachmentId));
            await Task.Delay(10000);
            var newRetrievedText = Encoding.UTF8.GetString(await loan.Attachments.DownloadAttachmentAsync(newAttachmentId));
            Assert.AreEqual(newText, newRetrievedText);
            var newStream = await loan.Attachments.DownloadAttachmentStreamAsync(newAttachmentId);
            using (var newSr = new StreamReader(newStream, Encoding.UTF8))
            {
                Assert.AreEqual(newText, newSr.ReadToEnd());
            }

            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }
    }
}
