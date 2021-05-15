using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Contact Notes Api extension methods.
    /// </summary>
    public static class ContactNotesExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IContactNotesV1? V1 { get; set; }

        private static IContactNotesV1 GetV1(IContactNotes contactNotes)
        {
            var v1 = V1;
            if (contactNotes is ContactNotes n)
            {
                v1 = n.ExtensionData.GetOrAdd(() => new ContactNotesV1(n.Client, n.Type, n.ContactId));
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
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="note">The note to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateNoteAsync(this IContactNotes contactNotes, ContactNote note, CancellationToken cancellationToken = default) => GetV1(contactNotes).CreateNoteAsync(note, cancellationToken);

        /// <summary>
        /// Adds a note to the contact from raw json and returns the response body if not empty else the note ID.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="note">The note to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateNoteRawAsync(this IContactNotes contactNotes, string note, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).CreateNoteRawAsync(note, queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).DeleteNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Retrieves the specified note from the contact.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ContactNote> GetNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Retrieves the specified note from the contact as raw json.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetNoteRawAsync(this IContactNotes contactNotes, string noteId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNoteRawAsync(noteId, queryString, cancellationToken);

        /// <summary>
        /// Retrieve all notes from the contact.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactNote>> GetNotesAsync(this IContactNotes contactNotes, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNotesAsync(cancellationToken);

        /// <summary>
        /// Retrieve all notes from the contact as raw json.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetNotesRawAsync(this IContactNotes contactNotes, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).GetNotesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Permanently deletes the specified note from the contact.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteNoteAsync(this IContactNotes contactNotes, string noteId, CancellationToken cancellationToken = default) => GetV1(contactNotes).TryDeleteNoteAsync(noteId, cancellationToken);

        /// <summary>
        /// Updates the specified note with the values provided.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="note">The note to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateNoteAsync(this IContactNotes contactNotes, ContactNote note, CancellationToken cancellationToken = default) => GetV1(contactNotes).UpdateNoteAsync(note, cancellationToken);

        /// <summary>
        /// Updates the specified note with the values provided from raw json.
        /// </summary>
        /// <param name="contactNotes">The Contact Notes Api Object.</param>
        /// <param name="noteId">Unique identifier of the note assigned to the note when it was created.</param>
        /// <param name="note">The note to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateNoteRawAsync(this IContactNotes contactNotes, string noteId, string note, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactNotes).UpdateNoteRawAsync(noteId, note, queryString, cancellationToken);
    }
}