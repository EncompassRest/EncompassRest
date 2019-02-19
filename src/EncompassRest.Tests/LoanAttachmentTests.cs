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
#pragma warning disable CS0618 // Type or member is obsolete
            var loanAttachment = new LoanAttachment { AttachmentType = AttachmentType.Image };
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""attachmentType"":1}", loanAttachment.ToJson());
        }

        [TestMethod]
        [ApiTest]
        public async Task LoanAttachments_Upload()
        {
            var client = await GetTestClientAsync();

            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                var attachment = new LoanAttachment("Testing Attachment", "Text.txt", AttachmentCreateReason.Upload);
                var text = "TESTING, TESTING, 1, 2, 3";
                var attachmentId = await loan.LoanApis.Attachments.UploadAttachmentAsync(attachment, Encoding.UTF8.GetBytes(text), true);
                Assert.IsFalse(string.IsNullOrEmpty(attachmentId));
                await Task.Delay(10000);
                var retrievedText = Encoding.UTF8.GetString(await loan.LoanApis.Attachments.DownloadAttachmentAsync(attachmentId));
                Assert.AreEqual(text, retrievedText);
                var stream = await loan.LoanApis.Attachments.DownloadAttachmentStreamAsync(attachmentId);
                using (var sr = new StreamReader(stream, Encoding.UTF8))
                {
                    Assert.AreEqual(text, sr.ReadToEnd());
                }

                Assert.IsTrue(string.IsNullOrEmpty(attachment.MediaUrl));
                retrievedText = Encoding.UTF8.GetString(await attachment.DownloadAsync());
                Assert.IsFalse(string.IsNullOrEmpty(attachment.MediaUrl));
                Assert.AreEqual(text, retrievedText);
                stream = await attachment.DownloadStreamAsync();
                using (var sr = new StreamReader(stream, Encoding.UTF8))
                {
                    Assert.AreEqual(text, sr.ReadToEnd());
                }

                attachment = await loan.LoanApis.Attachments.GetAttachmentAsync(attachmentId, true);
                Assert.AreEqual("Testing Attachment", attachment.Title);
                Assert.IsFalse(string.IsNullOrEmpty(attachment.MediaUrl));
                retrievedText = Encoding.UTF8.GetString(await attachment.DownloadAsync());
                Assert.AreEqual(text, retrievedText);
                stream = await attachment.DownloadStreamAsync();
                using (var sr = new StreamReader(stream, Encoding.UTF8))
                {
                    Assert.AreEqual(text, sr.ReadToEnd());
                }

                attachment = new LoanAttachment(attachmentId) { Title = "Updated Title" };
                await loan.LoanApis.Attachments.UpdateAttachmentAsync(attachment);
                attachment = await loan.LoanApis.Attachments.GetAttachmentAsync(attachmentId);
                Assert.AreEqual("Updated Title", attachment.Title);

                var newAttachment = new LoanAttachment("Bob", "Bobby.txt", AttachmentCreateReason.Upload);
                var newText = "This is a test of the emergency broadcast system, this is only a test.";
                var newAttachmentId = await loan.LoanApis.Attachments.UploadAttachmentAsync(newAttachment, new MemoryStream(Encoding.UTF8.GetBytes(newText)), true);
                Assert.IsFalse(string.IsNullOrEmpty(newAttachmentId));
                await Task.Delay(10000);
                var newRetrievedText = Encoding.UTF8.GetString(await loan.LoanApis.Attachments.DownloadAttachmentAsync(newAttachmentId));
                Assert.AreEqual(newText, newRetrievedText);
                var newStream = await loan.LoanApis.Attachments.DownloadAttachmentStreamAsync(newAttachmentId);
                using (var newSr = new StreamReader(newStream, Encoding.UTF8))
                {
                    Assert.AreEqual(newText, newSr.ReadToEnd());
                }

                Assert.IsTrue(string.IsNullOrEmpty(newAttachment.MediaUrl));
                newStream = await newAttachment.DownloadStreamAsync();
                Assert.IsFalse(string.IsNullOrEmpty(newAttachment.MediaUrl));
                using (var sr = new StreamReader(newStream, Encoding.UTF8))
                {
                    Assert.AreEqual(newText, sr.ReadToEnd());
                }
                newRetrievedText = Encoding.UTF8.GetString(await newAttachment.DownloadAsync());
                Assert.AreEqual(newText, newRetrievedText);

                newAttachment = await loan.LoanApis.Attachments.GetAttachmentAsync(newAttachmentId, true);
                Assert.AreEqual("Bob", newAttachment.Title);
                Assert.IsFalse(string.IsNullOrEmpty(newAttachment.MediaUrl));
                newRetrievedText = Encoding.UTF8.GetString(await newAttachment.DownloadAsync());
                Assert.AreEqual(newText, newRetrievedText);
                newStream = await newAttachment.DownloadStreamAsync();
                using (var sr = new StreamReader(newStream, Encoding.UTF8))
                {
                    Assert.AreEqual(newText, sr.ReadToEnd());
                }
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }
    }
}