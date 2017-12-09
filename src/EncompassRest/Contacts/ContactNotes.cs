using System.Collections.Generic;
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

        public async Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            var note = await GetAsync<ContactNote>(noteId, null, nameof(GetNoteAsync), noteId, cancellationToken).ConfigureAwait(false);
            note.NoteId = noteId; //TODO: Remove this when EM corrects bug
            note.Dirty = false;
            return note;
        }

        public Task<string> GetNoteRawAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetRawAsync(noteId, null, nameof(GetNoteRawAsync), noteId, cancellationToken);
        }

        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<ContactNote>(null, null, nameof(GetNotesAsync), null, cancellationToken);

        public Task<string> GetNotesRawAsync(CancellationToken cancellationToken = default) => GetRawAsync(null, null, nameof(GetNotesRawAsync), null, cancellationToken);

        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PostPopulateDirtyAsync(null, note, nameof(CreateNoteAsync), populate, cancellationToken);
        }

        public Task<string> CreateNoteRawAsync(string note, CancellationToken cancellationToken = default) => CreateNoteRawAsync(note, null, cancellationToken);

        private Task<string> CreateNoteRawAsync(string note, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PostAsync(null, queryString, new JsonStringContent(note), nameof(CreateNoteRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NotNullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PatchPopulateDirtyAsync(note.NoteId, JsonStreamContent.Create(note), nameof(UpdateNoteAsync), note.NoteId, cancellationToken, note, populate);
        }

        public Task<string> UpdateNoteRawAsync(string noteId, string note, CancellationToken cancellationToken = default) => UpdateNoteRawAsync(noteId, note, null, cancellationToken);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PatchRawAsync(noteId, queryString, new JsonStringContent(note), nameof(UpdateNoteRawAsync), noteId, cancellationToken);
        }

        public Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return DeleteAsync(noteId, cancellationToken);
        }
    }
}