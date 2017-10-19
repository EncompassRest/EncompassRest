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
            var borrowerContact = new BorrowerContact();
            borrowerContact.FirstName = "test";
            borrowerContact.PersonalEmail = "me@me.com";
            var contactId = await client.BorrowerContacts.CreateContactAsync(borrowerContact);
            borrowerContact.Initialize(client);

            //test notes
            var note = new ContactNote();
            note.Subject = "test";
            note.Details = "testing data";
            var noteId = await borrowerContact.Notes.CreateNoteAsync(note);
            Assert.IsNotNull(noteId);

            var newNote = await borrowerContact.Notes.GetNoteAsync(noteId);
            Assert.IsNotNull(newNote);
            Assert.AreEqual(newNote.NoteId, noteId);

            Assert.IsTrue(await borrowerContact.Notes.DeleteNoteAsync(noteId).ConfigureAwait(false));

            Assert.IsTrue(await client.BorrowerContacts.DeleteContactAsync(contactId).ConfigureAwait(false));
        }
    }
}
