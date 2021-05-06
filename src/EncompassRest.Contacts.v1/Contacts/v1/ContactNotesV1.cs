using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    public static class ContactNotesExtensions
    {
        public static IContactNotesV1? V1 { get; set; }

        private static IContactNotesV1 GetV1(IContactNotes contactNotes)
        {
            var v1 = V1;
            if (contactNotes is ContactNotes n)
            {
                v1 = (IContactNotesV1)n.ExtensionData.GetOrAdd("v1", k => new ContactNotesV1(n.Client, n.Type, n.ContactId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(contactNotes, nameof(contactNotes));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Adds a note to the contact and returns the note ID.
        /// </summary>
        /// <param name="note">The note to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateNoteAsync(this IContactNotes contactNotes, ContactNote note, CancellationToken cancellationToken = default) => GetV1(contactNotes).CreateNoteAsync(note, cancellationToken);

        /// <summary>
        /// Adds a note to the contact from raw json and returns the response body if not empty else the note ID.
        /// </summary>
        /// <param name="note">The note to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateNoteRawAsync(this IContactNotes contactNotes, string note, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).CreateNoteRawAsync(note, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).DeleteNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Retrieves the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ContactNote> GetNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Retrieves the specified note from the contact as raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetNoteRawAsync(this IContactNotes contactNotes, string noteId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNoteRawAsync(noteId, queryString, cancellationToken);

        /// <summary>
        /// Retrieve all notes from the contact.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactNote>> GetNotesAsync(this IContactNotes contactNotes, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNotesAsync(cancellationToken);

        /// <summary>
        /// Retrieve all notes from the contact as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetNotesRawAsync(this IContactNotes contactNotes, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNotesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).TryDeleteNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Updates the specified note with the values provided.
        /// </summary>
        /// <param name="note">The note to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateNoteAsync(this IContactNotes contactNotes, ContactNote note, CancellationToken cancellationToken = default) => GetV1(contactNotes).UpdateNoteAsync(note, cancellationToken);

        /// <summary>
        /// Updates the specified note with the values provided from raw json.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="note">The note to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateNoteRawAsync(this IContactNotes contactNotes, string noteId, string note, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).UpdateNoteRawAsync(noteId, note, queryString, cancellationToken);
    }

    /// <summary>
    /// The Contact Notes Apis.
    /// </summary>
    public interface IContactNotesV1 : IContactApiObject
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
        Task<string> CreateNoteRawAsync(string note, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteNoteAsync(string noteId, CancellationToken cancellationToken = default);
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
        Task<string> GetNoteRawAsync(string noteId, string? queryString = null, CancellationToken cancellationToken = default);
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
        Task<string> GetNotesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteNoteAsync(string noteId, CancellationToken cancellationToken = default);
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
        Task<string> UpdateNoteRawAsync(string noteId, string note, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class ContactNotesV1 : ContactApiObject, IContactNotesV1
    {
        internal ContactNotesV1(EncompassRestClient client, ContactType type, string contactId)
            : base(client, type, contactId, $"{(type == ContactType.Borrower ? "encompass/v1/borrowerContacts" : "encompass/v1/businessContacts")}/{contactId}/notes")
        {
        }

        public Task<List<ContactNote>> GetNotesAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<ContactNote>(null, null, nameof(GetNotesAsync), null, cancellationToken);

        public Task<string> GetNotesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetNotesRawAsync), null, cancellationToken);

        public Task<ContactNote> GetNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetDirtyAsync<ContactNote>(noteId, null, nameof(GetNoteAsync), noteId, cancellationToken);
        }

        public Task<string> GetNoteRawAsync(string noteId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return GetRawAsync(noteId, queryString, nameof(GetNoteRawAsync), noteId, cancellationToken);
        }

        public Task<string> CreateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => CreateNoteAsync(note, false, cancellationToken);

        private Task<string> CreateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            return PostPopulateDirtyAsync(null, nameof(CreateNoteAsync), note, populate, cancellationToken);
        }

        public Task<string> CreateNoteRawAsync(string note, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PostAsync(null, queryString, new JsonStringContent(note), nameof(CreateNoteRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateNoteAsync(ContactNote note, CancellationToken cancellationToken = default) => UpdateNoteAsync(note, false, cancellationToken);

        private Task UpdateNoteAsync(ContactNote note, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(note, nameof(note));
            Preconditions.NotNullOrEmpty(note.NoteId, $"{nameof(note)}.{nameof(note.NoteId)}");

            note.Dirty = true; // To be removed if Ellie Mae updates API to only update provided properties.
            return PatchPopulateDirtyAsync(note.NoteId, JsonStreamContent.Create(note), nameof(UpdateNoteAsync), note.NoteId, note, populate, cancellationToken);
        }

        public Task<string> UpdateNoteRawAsync(string noteId, string note, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));
            Preconditions.NotNullOrEmpty(note, nameof(note));

            return PatchRawAsync(noteId, queryString, new JsonStringContent(note), nameof(UpdateNoteRawAsync), noteId, cancellationToken);
        }

        public Task<bool> TryDeleteNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return TryDeleteAsync(noteId, null, cancellationToken);
        }

        public Task DeleteNoteAsync(string noteId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            return DeleteAsync(noteId, null, cancellationToken);
        }
    }
}