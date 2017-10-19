using EncompassRest.Contacts;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EncompassRest.Tests
{
    class ContactsTests : TestBaseClass
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
            var businessContact = new BorrowerContact { AccessLevel = ContactAccessLevel.Private };
            Assert.AreEqual(@"{""accessLevel"":0}", businessContact.ToJson());
            businessContact.Dirty = false;
            Assert.AreEqual("{}", businessContact.ToJson());
        }

        [TestMethod]
        public async Task BorrowerContact_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var borrowerContact = new BorrowerContact();
            var contactId = await client.BorrowerContacts.CreateContactAsync(borrowerContact).ConfigureAwait(false);
            Assert.IsNotNull(contactId);
            Assert.AreEqual(contactId, borrowerContact.Id);
            Assert.IsTrue(await client.BorrowerContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task BusinessContact_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var businessContact = new BusinessContact();
            var contactId = await client.BusinessContacts.CreateContactAsync(businessContact).ConfigureAwait(false);
            Assert.IsNotNull(contactId);
            Assert.AreEqual(contactId, businessContact.Id);
            Assert.IsTrue(await client.BusinessContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
        }
    }
}
