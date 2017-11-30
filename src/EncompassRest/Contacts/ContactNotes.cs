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

        public Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetAsync(noteId, null, nameof(GetNoteAsync), noteId, cancellationToken, async response =>
            {
                var note = await response.Content.ReadAsAsync<ContactNote>().ConfigureAwait(false);
                note.NoteId = noteId; //TODO: Remove this when EM corrects bug
                note.Dirty = false;
                return note;
            });
        }

        public Task<string> GetNoteRawAsync(string noteId) => GetNoteRawAsync(noteId, CancellationToken.None);

        public Task<string> GetNoteRawAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetRawAsync(noteId, null, nameof(GetNoteRawAsync), noteId, cancellationToken);
        }

        public Task<List<ContactNote>> GetNotesAsync() => GetNotesAsync(CancellationToken.None);

        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken) => GetAsync(null, null, nameof(GetNotesAsync), null, cancellationToken, async response =>
        {
            var notes = await response.Content.ReadAsAsync<List<ContactNote>>().ConfigureAwait(false);
            foreach (var note in notes)
            {
                note.Dirty = false;
            }
            return notes;
        });

        public Task<string> GetNotesRawAsync() => GetNotesRawAsync(CancellationToken.None);

        public Task<string> GetNotesRawAsync(CancellationToken cancellationToken) => GetRawAsync(null, null, nameof(GetNotesRawAsync), null, cancellationToken);

        public Task<string> CreateNoteAsync(ContactNote note) => CreateNoteAsync(note, false, CancellationToken.None);

        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate) => CreateNoteAsync(note, populate, CancellationToken.None);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PostAsync(JsonStreamContent.Create(note), null, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(CreateNoteAsync), null, cancellationToken, async response =>
            {
                var noteId = Path.GetFileName(response.Headers.Location.OriginalString);
                note.NoteId = noteId;
                if (populate)
                {
                    await response.Content.PopulateAsync(note).ConfigureAwait(false);
                }
                note.Dirty = false;
                return noteId;
            });
        }

        public Task<string> CreateNoteRawAsync(string note) => CreateNoteRawAsync(note, null, CancellationToken.None);

        public Task<string> CreateNoteRawAsync(string note, CancellationToken cancellationToken) => CreateNoteRawAsync(note, null, cancellationToken);

        private Task<string> CreateNoteRawAsync(string note, string queryString) => CreateNoteRawAsync(note, queryString, CancellationToken.None);

        private Task<string> CreateNoteRawAsync(string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PostAsync(new JsonStringContent(note), null, queryString, nameof(CreateNoteRawAsync), null, cancellationToken, async response =>
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return string.IsNullOrEmpty(json) ? Path.GetFileName(response.Headers.Location.OriginalString) : json;
            });
        }

        public Task UpdateNoteAsync(ContactNote note) => UpdateNoteAsync(note, false, CancellationToken.None);

        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate) => UpdateNoteAsync(note, populate, CancellationToken.None);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NotNullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PatchAsync(JsonStreamContent.Create(note), note.NoteId, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(UpdateNoteAsync), note.NoteId, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(note).ConfigureAwait(false);
                }
                note.Dirty = false;
                return string.Empty;
            });
        }

        public Task<string> UpdateNoteRawAsync(string noteId, string note) => UpdateNoteRawAsync(noteId, note, null, CancellationToken.None);

        public Task<string> UpdateNoteRawAsync(string noteId, string note, CancellationToken cancellationToken) => UpdateNoteRawAsync(noteId, note, null, cancellationToken);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString) => UpdateNoteRawAsync(noteId, note, queryString, CancellationToken.None);

        private Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PatchRawAsync(new JsonStringContent(note), noteId, queryString, nameof(UpdateNoteRawAsync), noteId, cancellationToken);
        }

        public Task<bool> DeleteNoteAsync(string noteId) => DeleteNoteAsync(noteId, CancellationToken.None);

        public Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return DeleteAsync(noteId, cancellationToken);
        }
    }
}