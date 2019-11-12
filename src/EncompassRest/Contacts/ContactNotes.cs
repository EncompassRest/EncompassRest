using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Notes Apis.
    /// </summary>
    public interface IContactNotes : IContactApiObject
    {
        /// <summary>
        /// Adds a note to the contact and returns the note ID.
        /// </summary>
        /// <param name="note">The note to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds a note to the contact from raw json and returns the response body if not empty else the note ID.
        /// </summary>
        /// <param name="note">The note to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateNoteRawAsync(string note, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves the specified note from the contact as raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetNoteRawAsync(string noteId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all notes from the contact.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all notes from the contact as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetNotesRawAsync(string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the specified note with the values provided.
        /// </summary>
        /// <param name="note">The note to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the specified note with the values provided from raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="note">The note to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Contact Notes Apis.
    /// </summary>
    public sealed class ContactNotes : ContactApiObject, IContactNotes
    {
        internal ContactNotes(EncompassRestClient client, string contactId, string baseApiPath)
            : base(client, contactId, $"{baseApiPath}/{contactId}/notes")
        {
        }

        /// <summary>
        /// Retrieve all notes from the contact.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<ContactNote>(null, null, nameof(GetNotesAsync), null, cancellationToken);

        /// <summary>
        /// Retrieve all notes from the contact as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetNotesRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetNotesRawAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            var note = await GetDirtyAsync<ContactNote>(noteId, null, nameof(GetNoteAsync), noteId, cancellationToken).ConfigureAwait(false);
            note.NoteId = noteId; //TODO: Remove this when EM corrects bug
            return note;
        }

        /// <summary>
        /// Retrieves the specified note from the contact as raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetNoteRawAsync(string noteId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetRawAsync(noteId, queryString, nameof(GetNoteRawAsync), noteId, cancellationToken);
        }

        /// <summary>
        /// Adds a note to the contact and returns the note ID.
        /// </summary>
        /// <param name="note">The note to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PostPopulateDirtyAsync(null, nameof(CreateNoteAsync), note, populate, cancellationToken);
        }

        /// <summary>
        /// Adds a note to the contact from raw json and returns the response body if not empty else the note ID.
        /// </summary>
        /// <param name="note">The note to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateNoteRawAsync(string note, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PostAsync(null, queryString, new JsonStringContent(note), nameof(CreateNoteRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Updates the specified note with the values provided.
        /// </summary>
        /// <param name="note">The note to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NotNullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            note.Dirty = true; // To be removed if Ellie Mae updates API to only update provided properties.
            return PatchPopulateDirtyAsync(note.NoteId, JsonStreamContent.Create(note), nameof(UpdateNoteAsync), note.NoteId, note, populate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified note with the values provided from raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="note">The note to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateNoteRawAsync(string noteId, string note, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PatchRawAsync(noteId, queryString, new JsonStringContent(note), nameof(UpdateNoteRawAsync), noteId, cancellationToken);
        }

        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return TryDeleteAsync(noteId, null, cancellationToken);
        }
    }
}