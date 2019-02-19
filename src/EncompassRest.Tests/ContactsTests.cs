using EncompassRest.Contacts;
using EncompassRest.Filters;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
#pragma warning disable CS0618 // Type or member is obsolete
            var borrowerContact = new BorrowerContact { AccessLevel = ContactAccessLevel.Private };
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""accessLevel"":0}", borrowerContact.ToJson());
            borrowerContact.Dirty = false;
            Assert.AreEqual("{}", borrowerContact.ToJson());
        }

        [TestMethod]
        public void BusinessContact_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var businessContact = new BusinessContact { AccessLevel = ContactAccessLevel.Private };
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""accessLevel"":0}", businessContact.ToJson());
            businessContact.Dirty = false;
            Assert.AreEqual("{}", businessContact.ToJson());
        }

        [TestMethod]
        [ApiTest]
        public async Task BorrowerContact_CreateRetrieveAndDelete()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token != "Token")
            {
                var borrowerContact = new BorrowerContact("Bob", "Bob@gmail.com");
                var contactId = await client.BorrowerContacts.CreateContactAsync(borrowerContact);

                try
                {

                    Assert.IsNotNull(contactId);
                    Assert.AreEqual(contactId, borrowerContact.Id);

                    var retrievedContact = await client.BorrowerContacts.GetContactAsync(contactId);
                    Assert.IsNotNull(retrievedContact);
                    Assert.AreEqual(contactId, retrievedContact.Id);
                    Assert.AreEqual(borrowerContact.FirstName, retrievedContact.FirstName);
                    Assert.AreEqual(borrowerContact.PersonalEmail, retrievedContact.PersonalEmail);
                    Assert.IsTrue(string.IsNullOrEmpty(retrievedContact.LastName));

                    borrowerContact = new BorrowerContact(client, contactId, "Bob", "Bob@gmail.com") { LastName = "Smith" };
                    await client.BorrowerContacts.UpdateContactAsync(borrowerContact);
                    retrievedContact = await client.BorrowerContacts.GetContactAsync(contactId);
                    Assert.IsNotNull(retrievedContact);
                    Assert.AreEqual(contactId, retrievedContact.Id);
                    Assert.AreEqual("Bob", retrievedContact.FirstName);
                    Assert.AreEqual("Bob@gmail.com", retrievedContact.PersonalEmail);
                    Assert.AreEqual("Smith", retrievedContact.LastName);
                }
                finally
                {
                    try
                    {
                        await client.BorrowerContacts.DeleteContactAsync(contactId);
                    }
                    catch
                    {
                    }
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task BusinessContact_CreateRetrieveAndDelete()
        {
            var client = await GetTestClientAsync();
            var businessContact = new BusinessContact("Bob", "Bob@gmail.com");
            var contactId = await client.BusinessContacts.CreateContactAsync(businessContact);

            try
            {

                Assert.IsNotNull(contactId);
                Assert.AreEqual(contactId, businessContact.Id);

                var retrievedContact = await client.BusinessContacts.GetContactAsync(contactId);
                Assert.IsNotNull(retrievedContact);
                Assert.AreEqual(contactId, retrievedContact.Id);
                Assert.AreEqual(businessContact.FirstName, retrievedContact.FirstName);
                Assert.AreEqual(businessContact.PersonalEmail, retrievedContact.PersonalEmail);
                Assert.IsTrue(string.IsNullOrEmpty(retrievedContact.LastName));

                businessContact = new BusinessContact(client, contactId, "Bob", "Bob@gmail.com") { LastName = "Smith" };
                await client.BusinessContacts.UpdateContactAsync(businessContact);
                retrievedContact = await client.BusinessContacts.GetContactAsync(contactId);
                Assert.IsNotNull(retrievedContact);
                Assert.AreEqual(contactId, retrievedContact.Id);
                Assert.AreEqual("Bob", retrievedContact.FirstName);
                Assert.AreEqual("Bob@gmail.com", retrievedContact.PersonalEmail);
                Assert.AreEqual("Smith", retrievedContact.LastName);
            }
            finally
            {
                try
                {
                    await client.BusinessContacts.DeleteContactAsync(contactId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Contacts_GetCanonicalNames()
        {
            var client = await GetTestClientAsync();
            var borrowerContactFieldDefinitions = await client.Settings.BorrowerContacts.GetCanonicalNamesAsync();
            var businessContactFieldDefinitions = await client.Settings.BusinessContacts.GetCanonicalNamesAsync();

            foreach (var contactFieldDefinition in borrowerContactFieldDefinitions.Concat(businessContactFieldDefinitions))
            {
                AssertNoExtensionData(contactFieldDefinition, "ContactFieldDefinition", contactFieldDefinition.CanonicalName, true);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Contacts_GetContactList()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { CanonicalContactField.FirstName.GetCanonicalName(), CanonicalContactField.LastName.GetCanonicalName() };
            var borrowerContacts = await client.BorrowerContactSelector.GetContactListAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
            var businessContacts = await client.BusinessContactSelector.GetContactListAsync(new ContactListParameters { Filter = new StringFieldFilter(CanonicalContactField.LastName, StringFieldMatchType.Contains, "a"), Fields = fields });
            var allContacts = borrowerContacts.Concat(businessContacts).ToList();

            foreach (var contact in allContacts)
            {
                AssertNoExtensionData(contact, "Contact", contact.Id, true);
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
        [ApiTest]
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