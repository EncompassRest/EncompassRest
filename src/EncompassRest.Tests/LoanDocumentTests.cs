using System.IO;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Loans.Attachments.v1;
using EncompassRest.Loans.Documents.v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanDocumentTests : TestBaseClass
    {
        [TestMethod]
        public void LoanDocument_Serialization()
        {
            var document = new LoanDocument("Mortgage Insurance", "All");
            Assert.AreEqual(@"{""title"":""Mortgage Insurance"",""applicationId"":""All""}", document.ToString(SerializationOptions.Dirty));
            document.Dirty = false;
            Assert.AreEqual("{}", document.ToString(SerializationOptions.Dirty));
            document.Status = "expected";
            Assert.IsNotNull(document.Status.EnumValue);
            Assert.AreEqual(DocumentStatus.Expected, document.Status.EnumValue.GetValueOrDefault());
            Assert.AreEqual(@"{""status"":""expected""}", document.ToString(SerializationOptions.Dirty));
            document.Status = "ready to ship";
            Assert.IsNull(document.Status.EnumValue);
            Assert.AreEqual(@"{""status"":""ready to ship""}", document.ToString(SerializationOptions.Dirty));
            document.Dirty = false;
            Assert.AreEqual("{}", document.ToString(SerializationOptions.Dirty));
            document.Status = DocumentStatus.Added;
            Assert.AreEqual("added", document.Status.Value);
            Assert.AreEqual(@"{""status"":""added""}", document.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        [ApiTest]
        public async Task LoanDocument_Upload()
        {
            var client = await GetTestClientAsync();

            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                var document = new LoanDocument("Final 1003", "All");
                var documentId = await loan.LoanApis.Documents.CreateDocumentAsync(document, true);
                Assert.IsFalse(string.IsNullOrEmpty(documentId));

                document = await loan.LoanApis.Documents.GetDocumentAsync(documentId);
                Assert.AreEqual("Final 1003", document.Title);
                Assert.AreEqual("All", document.ApplicationId);
                Assert.AreEqual(0, document.Attachments.Count);

                document = new LoanDocument(documentId) { Title = "Updated Title" };
                await loan.LoanApis.Documents.UpdateDocumentAsync(document);
                document = await loan.LoanApis.Documents.GetDocumentAsync(documentId);
                Assert.AreEqual("Updated Title", document.Title);
                Assert.AreEqual("All", document.ApplicationId);
                Assert.AreEqual(0, document.Attachments.Count);

                var attachment = new LoanAttachment("Testing Attachment", "Text.txt", AttachmentCreateReason.Upload)
                {
                    DocumentRefId = documentId
                };
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

                document = await loan.LoanApis.Documents.GetDocumentAsync(documentId);
                Assert.AreEqual("Updated Title", document.Title);
                Assert.AreEqual("All", document.ApplicationId);
                Assert.AreEqual(1, document.Attachments.Count);
                Assert.AreEqual(attachmentId, document.Attachments[0].EntityId);
                Assert.AreEqual(EntityType.Attachment, document.Attachments[0].EntityType.EnumValue);
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