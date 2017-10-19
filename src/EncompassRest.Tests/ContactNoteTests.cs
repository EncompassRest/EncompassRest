using EncompassRest.Contacts;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    class ContactNoteTests
    {
        public void ContactNote_Serialization()
        {
            var contactNote = new ContactNote { NoteId = "5" };
            Assert.AreEqual(contactNote.NoteIdInt, 5);
            Assert.AreEqual(@"{""noteId"":5", contactNote.ToJson());
            contactNote.Dirty = false;
            Assert.AreEqual("{}", contactNote.ToJson());
        }
    }
}
