using EncompassRest.Contacts;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ContactsTests : TestBaseClass
    {
        [TestMethod]
        public void BorrowerContact_Serialization()
        {
            var borrowerContact = new BorrowerContact { AccessLevel = ContactAccessLevel.Private };
            Assert.AreEqual(@"{""accessLevel"":0}", borrowerContact.ToJson());
            borrowerContact.Dirty = false;
            Assert.AreEqual("{}", borrowerContact.ToJson());
        }

        [TestMethod]
        public void BusinessContact_Serialization()
        {
            var businessContact = new BusinessContact { AccessLevel = ContactAccessLevel.Private };
            Assert.AreEqual(@"{""accessLevel"":0}", businessContact.ToJson());
            businessContact.Dirty = false;
            Assert.AreEqual("{}", businessContact.ToJson());
        }

        [TestMethod]
        public async Task BorrowerContact_CreateRetrieveAndDelete()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token != "Token")
            {
                var borrowerContact = new BorrowerContact
                {
                    FirstName = "Bob",
                    PersonalEmail = "Bob@gmail.com"
                };
                var contactId = await client.BorrowerContacts.CreateContactAsync(borrowerContact).ConfigureAwait(false);

                Assert.IsNotNull(contactId);
                Assert.AreEqual(contactId, borrowerContact.Id);

                var retrievedContact = await client.BorrowerContacts.GetContactAsync(contactId);
                Assert.IsNotNull(retrievedContact);
                Assert.AreEqual(contactId, retrievedContact.Id);

                Assert.IsTrue(await client.BorrowerContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
            }
        }

        [TestMethod]
        public async Task BusinessContact_CreateRetrieveAndDelete()
        {
            var client = await GetTestClientAsync();
            var businessContact = new BusinessContact
            {
                FirstName = "Bob",
                PersonalEmail = "Bob@gmail.com"
            };
            var contactId = await client.BusinessContacts.CreateContactAsync(businessContact).ConfigureAwait(false);
            Assert.IsNotNull(contactId);
            Assert.AreEqual(contactId, businessContact.Id);

            var retrievedContact = await client.BusinessContacts.GetContactAsync(contactId);
            Assert.IsNotNull(retrievedContact);
            Assert.AreEqual(contactId, retrievedContact.Id);

            Assert.IsTrue(await client.BusinessContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task Contacts_GetCanonicalNames()
        {
            var client = await GetTestClientAsync();
            var borrowerContactFieldDefinitions = await client.Settings.BorrowerContacts.GetCanonicalNamesAsync();
            var businessContactFieldDefinitions = await client.Settings.BusinessContacts.GetCanonicalNamesAsync();

            foreach (var borrowerContactFieldDefinition in borrowerContactFieldDefinitions)
            {
                Assert.AreEqual(0, borrowerContactFieldDefinition.ExtensionData.Count);
            }

            foreach (var businessContactFieldDefinition in businessContactFieldDefinitions)
            {
                Assert.AreEqual(0, businessContactFieldDefinition.ExtensionData.Count);
            }

            Assert.IsTrue(borrowerContactFieldDefinitions.Concat(businessContactFieldDefinitions).All(fd => fd.Category.EnumValue.HasValue));
            var existingCategories = new HashSet<string>(Enums.GetMembers<FieldDefinitionCategory>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), StringComparer.Ordinal);
            var categories = new HashSet<string>(borrowerContactFieldDefinitions.Select(fd => fd.Category.Value).Concat(businessContactFieldDefinitions.Select(fd => fd.Category.Value)), StringComparer.Ordinal);
            var newCategories = categories.Except(existingCategories).ToList();
            Assert.AreEqual(0, newCategories.Count);

            Assert.IsTrue(borrowerContactFieldDefinitions.Concat(businessContactFieldDefinitions).All(fd => fd.DataSource.EnumValue.HasValue));
            var existingDataSources = new HashSet<string>(Enums.GetMembers<FieldDefinitionDataSource>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), StringComparer.Ordinal);
            var dataSources = new HashSet<string>(borrowerContactFieldDefinitions.Select(fd => fd.DataSource.Value).Concat(businessContactFieldDefinitions.Select(fd => fd.DataSource.Value)), StringComparer.Ordinal);
            var newDataSources = dataSources.Except(existingDataSources).ToList();
            Assert.AreEqual(0, newDataSources.Count);

            Assert.IsTrue(borrowerContactFieldDefinitions.Concat(businessContactFieldDefinitions).All(fd => fd.DataType.EnumValue.HasValue));
            var existingFieldFormats = new HashSet<string>(Enums.GetMembers<LoanFieldFormat>().Select(m => m.AsString(EnumFormat.Name)), StringComparer.Ordinal);
            var fieldFormats = new HashSet<string>(borrowerContactFieldDefinitions.Select(fd => fd.DataType.Value).Concat(businessContactFieldDefinitions.Select(fd => fd.DataType.Value)), StringComparer.Ordinal);
            var newFieldFormats = fieldFormats.Except(existingFieldFormats).ToList();
            Assert.AreEqual(0, newFieldFormats.Count);
        }

        [TestMethod]
        public async Task Contacts_GetContactList()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { "Contact.FirstName", "Contact.LastName" };
            var borrowerContacts = await client.BorrowerContactSelector.GetContactListAsync(new ContactListParameters(fields));
            var businessContacts = await client.BusinessContactSelector.GetContactListAsync(new ContactListParameters(fields));
            var allContacts = borrowerContacts.Concat(businessContacts).ToList();

            foreach (var contact in allContacts)
            {
                Assert.AreEqual(0, contact.ExtensionData.Count);
                Assert.IsFalse(string.IsNullOrEmpty(contact.Id));
                Assert.IsNotNull(contact.Fields);
                Assert.AreEqual(fields.Length, contact.Fields.Count);
                foreach (var field in fields)
                {
                    Assert.IsTrue(contact.Fields.ContainsKey(field));
                }
            }
        }
    }
}