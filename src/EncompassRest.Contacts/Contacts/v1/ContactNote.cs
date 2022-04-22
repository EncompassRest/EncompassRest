using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// ContactNote
    /// </summary>
    public sealed class ContactNote : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Contact note id as an <see cref="int"/>.
        /// </summary>
        [JsonProperty("noteId")]
        public int? NoteIdInt { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Contact note id.
        /// </summary>
        [JsonIgnore]
        public string? NoteId
        {
            get => NoteIdInt?.ToString();
            set => NoteIdInt = value != null && int.TryParse(value, out var noteId) ? noteId : (int?)null;
        }

        /// <summary>
        /// Contact note subject.
        /// </summary>
        public string? Subject { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Contact note timestamp.
        /// </summary>
        public DateTime? Timestamp { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Contact note details.
        /// </summary>
        public string? Details { get => GetValue<string?>(); set => SetValue(value); }

        [IdPropertyName(nameof(NoteId))]
        string? IIdentifiable.Id { get => NoteId; set => NoteId = value; }

        /// <summary>
        /// Contact note creation constructor
        /// </summary>
        /// <param name="subject">Contact note subject.</param>
        /// <param name="details">Contact note details.</param>
        public ContactNote(string subject, string details)
        {
            Preconditions.NotNullOrEmpty(subject, nameof(subject));
            Preconditions.NotNullOrEmpty(details, nameof(details));

            Subject = subject;
            Details = details;
        }

        /// <summary>
        /// Contact note update constructor
        /// </summary>
        /// <param name="noteId">Contact note id.</param>
        public ContactNote(string noteId)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            NoteId = noteId;
        }

        /// <summary>
        /// Contact note deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public ContactNote()
        {
        }
    }
}