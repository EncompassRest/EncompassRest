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
            var contactNote = new ContactNote("5");
            Assert.AreEqual(contactNote.NoteIdInt, 5);
            Assert.AreEqual(@"{""noteId"":5}", contactNote.ToString(SerializationOptions.Dirty));
            contactNote.Dirty = false;
            Assert.AreEqual(@"{""noteId"":5}", contactNote.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        [ApiTest]
        public async Task ContactNote_CreateRetrieveAndDelete()
        {
            //create borrower contact to test notes
            var client = await GetTestClientAsync();
            var businessContact = new BusinessContact("test", "me@me.com");
            var contactId = await client.Contacts.BusinessContacts.CreateContactAsync(businessContact);

            try
            {
                //test notes
                var note = new ContactNote("test", "testing data");
                var noteId = await businessContact.Notes.CreateNoteAsync(note);
                Assert.IsNotNull(noteId);

                var retrievedNote = await businessContact.Notes.GetNoteAsync(noteId);
                Assert.IsNotNull(retrievedNote);
                Assert.AreEqual(noteId, retrievedNote.NoteId);
                Assert.AreEqual(note.Subject, retrievedNote.Subject);
                Assert.AreEqual(note.Details, retrievedNote.Details);

                note = new ContactNote(noteId) { Subject = "New Subject", Details = "New Details" };
                await businessContact.Notes.UpdateNoteAsync(note);
                retrievedNote = await businessContact.Notes.GetNoteAsync(noteId);
                Assert.IsNotNull(retrievedNote);
                Assert.AreEqual(noteId, retrievedNote.NoteId);
                Assert.AreEqual(note.Subject, retrievedNote.Subject);
                Assert.AreEqual(note.Details, retrievedNote.Details);

                Assert.IsTrue(await businessContact.Notes.DeleteNoteAsync(noteId));
                Assert.IsFalse(await businessContact.Notes.DeleteNoteAsync(noteId));
            }
            finally
            {
                try
                {
                    await client.Contacts.BusinessContacts.DeleteContactAsync(contactId);
                }
                catch
                {
                }
            }
        }
    }
}