using EncompassRest.Contacts;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
