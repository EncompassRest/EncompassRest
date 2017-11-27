using EncompassRest.Contacts;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ContactNoteTests : TestBaseClass
    {
        [TestMethod]
        public void ContactNote_Serialization()
        {
            var contactNote = new ContactNote { NoteId = "5" };
            Assert.AreEqual(contactNote.NoteIdInt, 5);
            Assert.AreEqual(@"{""noteId"":5}", contactNote.ToJson());
            contactNote.Dirty = false;
            Assert.AreEqual("{}", contactNote.ToJson());
        }

        [TestMethod]
        public async Task ContactNote_CreateRetrieveAndDelete()
        {
            //create borrower contact to test notes
            var client = await GetTestClientAsync();
            var businessContact = new BusinessContact
            {
                FirstName = "test",
                PersonalEmail = "me@me.com"
            };
            var contactId = await client.BusinessContacts.CreateContactAsync(businessContact);

            //test notes
            var note = new ContactNote
            {
                Subject = "test",
                Details = "testing data"
            };
            var noteId = await businessContact.Notes.CreateNoteAsync(note);
            Assert.IsNotNull(noteId);

            var newNote = await businessContact.Notes.GetNoteAsync(noteId);
            Assert.IsNotNull(newNote);
            Assert.AreEqual(newNote.NoteId, noteId);

            Assert.IsTrue(await businessContact.Notes.DeleteNoteAsync(noteId).ConfigureAwait(false));

            Assert.IsTrue(await client.BusinessContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
        }
    }
}
