using EncompassRest.Contacts;
using EncompassRest.Filters;
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
            var allContactFieldDefinitions = borrowerContactFieldDefinitions.Concat(businessContactFieldDefinitions).ToList();

            foreach (var contactFieldDefinition in allContactFieldDefinitions)
            {
                Assert.AreEqual(0, contactFieldDefinition.ExtensionData.Count);
            }

            var existingCategories = new HashSet<string>(Enums.GetMembers<FieldDefinitionCategory>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), StringComparer.Ordinal);
            var categories = new HashSet<string>(allContactFieldDefinitions.Select(fd => fd.Category.Value), StringComparer.Ordinal);
            var newCategories = categories.Except(existingCategories).ToList();
            Assert.AreEqual(0, newCategories.Count);
            Assert.IsTrue(allContactFieldDefinitions.All(fd => fd.Category.EnumValue.HasValue));

            var existingDataSources = new HashSet<string>(Enums.GetMembers<FieldDefinitionDataSource>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)), StringComparer.Ordinal);
            var dataSources = new HashSet<string>(allContactFieldDefinitions.Select(fd => fd.DataSource.Value), StringComparer.Ordinal);
            var newDataSources = dataSources.Except(existingDataSources).ToList();
            Assert.AreEqual(0, newDataSources.Count);
            Assert.IsTrue(allContactFieldDefinitions.All(fd => fd.DataSource.EnumValue.HasValue));

            var existingFieldFormats = new HashSet<string>(Enums.GetMembers<LoanFieldFormat>().Select(m => m.AsString(EnumFormat.Name)), StringComparer.Ordinal);
            var fieldFormats = new HashSet<string>(allContactFieldDefinitions.Select(fd => fd.DataType.Value), StringComparer.Ordinal);
            var newFieldFormats = fieldFormats.Except(existingFieldFormats).ToList();
            Assert.AreEqual(0, newFieldFormats.Count);
            Assert.IsTrue(allContactFieldDefinitions.All(fd => fd.DataType.EnumValue.HasValue));
        }

        [TestMethod]
        public async Task Contacts_GetContactList()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { CanonicalContactField.FirstName.GetCanonicalName(), CanonicalContactField.LastName.GetCanonicalName() };
            var borrowerContacts = await client.BorrowerContactSelector.GetContactListAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
            var businessContacts = await client.BusinessContactSelector.GetContactListAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
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

        [TestMethod]
        public async Task Contacts_Cursor()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { CanonicalContactField.FirstName.GetCanonicalName(), CanonicalContactField.LastName.GetCanonicalName() };

            var borrowerContactCursor = await client.BorrowerContactSelector.CreateCursorAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
            await UseCursorAsync(borrowerContactCursor);
            var businessContactCursor = await client.BusinessContactSelector.CreateCursorAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
            await UseCursorAsync(businessContactCursor);

            async Task UseCursorAsync(ContactCursor cursor)
            {
                Assert.IsNotNull(cursor);
                CollectionAssert.AreEqual(fields, cursor.Fields.ToList());
                Assert.IsFalse(string.IsNullOrEmpty(cursor.CursorId));
                Assert.IsTrue(cursor.Count > 0);
                var items = await cursor.GetItemsAsync(0, 50);
                foreach (var item in items)
                {
                    ValidateItem(item);
                }
                Assert.IsTrue(items.Count() <= 50);
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(-1, 1));
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(cursor.Count, 1));
                items = await cursor.GetItemsAsync(cursor.Count - 1, 1);
                ValidateItem(items[0]);
                items = await cursor.GetItemsAsync(cursor.Count - 1, int.MaxValue); // Does not throw ArgumentOutOfRangeException
                Assert.AreEqual(1, items.Count);
                ValidateItem(items[0]);

                void ValidateItem(ContactData item)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(item.Id));
                    if (fields?.Length > 0)
                    {
                        Assert.IsNotNull(item.Fields);
                        Assert.AreEqual(fields.Length, item.Fields.Count);
                        foreach (var field in fields)
                        {
                            Assert.IsTrue(item.Fields.ContainsKey(field));
                        }
                    }
                    else
                    {
                        Assert.IsNull(item.Fields);
                    }
                }
            }
        }
    }
}