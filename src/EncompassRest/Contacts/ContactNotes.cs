using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public sealed class ContactNotes : ContactApiObject
    {
        internal ContactNotes(EncompassRestClient client, string contactId, string baseApiPath)
            : base(client, contactId, $"{baseApiPath}/{contactId}/notes")
        {
        }

        public Task<ContactNote> GetNoteAsync(string noteId) => GetNoteAsync(noteId, CancellationToken.None);

        public async Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            var note = await GetAsync<ContactNote>(noteId, null, nameof(GetNoteAsync), noteId, cancellationToken).ConfigureAwait(false);
            note.NoteId = noteId; //TODO: Remove this when EM corrects bug
            note.Dirty = false;
            return note;
        }

        public Task<string> GetNoteRawAsync(string noteId) => GetNoteRawAsync(noteId, CancellationToken.None);

        public Task<string> GetNoteRawAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetRawAsync(noteId, null, nameof(GetNoteRawAsync), noteId, cancellationToken);
        }

        public Task<List<ContactNote>> GetNotesAsync() => GetNotesAsync(CancellationToken.None);

        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken) => GetDirtyListAsync<ContactNote>(null, null, nameof(GetNotesAsync), null, cancellationToken);

        public Task<string> GetNotesRawAsync() => GetNotesRawAsync(CancellationToken.None);

        public Task<string> GetNotesRawAsync(CancellationToken cancellationToken) => GetRawAsync(null, null, nameof(GetNotesRawAsync), null, cancellationToken);

        public Task<string> CreateNoteAsync(ContactNote note) => CreateNoteAsync(note, false, CancellationToken.None);

        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate) => CreateNoteAsync(note, populate, CancellationToken.None);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PostPopulateDirtyAsync(null, note, nameof(CreateNoteAsync), populate, cancellationToken);
        }

        public Task<string> CreateNoteRawAsync(string note) => CreateNoteRawAsync(note, null, CancellationToken.None);

        public Task<string> CreateNoteRawAsync(string note, CancellationToken cancellationToken) => CreateNoteRawAsync(note, null, cancellationToken);

        private Task<string> CreateNoteRawAsync(string note, string queryString) => CreateNoteRawAsync(note, queryString, CancellationToken.None);

        private Task<string> CreateNoteRawAsync(string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PostAsync(null, queryString, new JsonStringContent(note), nameof(CreateNoteRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateNoteAsync(ContactNote note) => UpdateNoteAsync(note, false, CancellationToken.None);

        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate) => UpdateNoteAsync(note, populate, CancellationToken.None);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NotNullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PatchPopulateDirtyAsync(note.NoteId, JsonStreamContent.Create(note), nameof(UpdateNoteAsync), note.NoteId, cancellationToken, note, populate);
        }

        public Task<string> UpdateNoteRawAsync(string noteId, string note) => UpdateNoteRawAsync(noteId, note, null, CancellationToken.None);

        public Task<string> UpdateNoteRawAsync(string noteId, string note, CancellationToken cancellationToken) => UpdateNoteRawAsync(noteId, note, null, cancellationToken);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString) => UpdateNoteRawAsync(noteId, note, queryString, CancellationToken.None);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PatchRawAsync(noteId, queryString, new JsonStringContent(note), nameof(UpdateNoteRawAsync), noteId, cancellationToken);
        }

        public Task<bool> DeleteNoteAsync(string noteId) => DeleteNoteAsync(noteId, CancellationToken.None);

        public Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return DeleteAsync(noteId, cancellationToken);
        }
    }
}