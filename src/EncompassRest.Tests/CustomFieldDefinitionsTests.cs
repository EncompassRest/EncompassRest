using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Settings.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class CustomFieldDefinitionsTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task CustomFieldDefitions_GetAll()
        {
            var client = await GetTestClientAsync();
            var customFields = await client.Settings.Loan.CustomFields.GetCustomFieldsAsync();
            Assert.IsTrue(customFields.Count > 0);
        }

        [TestMethod]
        [ApiTest]
        public async Task CustomFieldDefitions_Get()
        {
            var client = await GetTestClientAsync();
            const string fieldId = "CUST01FV";
            var customField = await client.Settings.Loan.CustomFields.GetCustomFieldAsync(fieldId);
            Assert.IsNotNull(customField);
            Assert.AreEqual(fieldId, customField.Id);
        }

        [TestMethod]
        [ApiTest]
        public async Task CustomFieldDefitions_CreateUpdateAndDelete()
        {
            var client = await GetTestClientAsync();
            const string fieldId = "CX.ABC";
            await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId);
            var description = "A, B, C";
            var format = LoanFieldFormat.DATE;
            var customField = new CustomFieldDefinition(fieldId, description, format);
            await client.Settings.Loan.CustomFields.CreateCustomFieldAsync(customField);
            customField = await client.Settings.Loan.CustomFields.GetCustomFieldAsync(fieldId);
            Assert.AreEqual(fieldId, customField.Id);
            Assert.AreEqual(description, customField.Description);
            Assert.AreEqual(format, customField.Format.EnumValue);
            description += " easy as 1, 2, 3";
            customField.Description = description;
            await client.Settings.Loan.CustomFields.UpdateCustomFieldAsync(customField);
            customField = await client.Settings.Loan.CustomFields.GetCustomFieldAsync(fieldId);
            Assert.AreEqual(fieldId, customField.Id);
            Assert.AreEqual(description, customField.Description);
            Assert.AreEqual(format, customField.Format.EnumValue);
            Assert.IsTrue(await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId));
        }

        [TestMethod]
        [ApiTest]
        public async Task CustomFieldDefitions_CreateDropdownField()
        {
            var client = await GetTestClientAsync();
            const string fieldId = "CX.PETS";
            await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId);
            var description = "Borrower's own pets";
            var format = LoanFieldFormat.DROPDOWNLIST;
            var options = new[] { "Dog", "Cat", "Other", "Multiple" };
            var customField = new CustomFieldDefinition(fieldId, description, format)
            {
                Options = options
            };
            await client.Settings.Loan.CustomFields.CreateCustomFieldAsync(customField);
            customField = await client.Settings.Loan.CustomFields.GetCustomFieldAsync(fieldId);
            Assert.AreEqual(fieldId, customField.Id);
            Assert.AreEqual(description, customField.Description);
            Assert.AreEqual(format, customField.Format.EnumValue);
            CollectionAssert.AreEqual(options, customField.Options.ToList());
            Assert.IsTrue(await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId));
        }

        [TestMethod]
        [ApiTest]
        public async Task CustomFieldDefitions_CreateAuditField()
        {
            var client = await GetTestClientAsync();
            const string fieldId = "CX.AUDIT364";
            await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId);
            var description = "AUDIT user id field for 364";
            var format = LoanFieldFormat.AUDIT;
            var audit = new FieldAudit("364", AuditData.UserID);
            var customField = new CustomFieldDefinition(fieldId, description, format)
            {
                Audit = audit
            };
            await client.Settings.Loan.CustomFields.CreateCustomFieldAsync(customField);
            customField = await client.Settings.Loan.CustomFields.GetCustomFieldAsync(fieldId);
            Assert.AreEqual(fieldId, customField.Id);
            Assert.AreEqual(description, customField.Description);
            Assert.AreEqual(format, customField.Format.EnumValue);
            Assert.AreEqual(audit.FieldId, customField.Audit.FieldId);
            Assert.AreEqual(audit.Data.EnumValue, customField.Audit.Data.EnumValue);
            Assert.IsTrue(await client.Settings.Loan.CustomFields.DeleteCustomFieldAsync(fieldId));
        }

        [TestMethod]
        [ApiTest]
        public async Task FieldDescriptors_RefreshCustomFields()
        {
            var client = await GetTestClientAsync();
            var fieldDescriptors = client.Loans.FieldDescriptors;
            var customFields = fieldDescriptors.CustomFields;
            Assert.AreEqual(0, customFields.Count);
            await fieldDescriptors.RefreshCustomFieldsAsync();
            Assert.IsTrue(customFields.Count > 0);
        }
    }
}