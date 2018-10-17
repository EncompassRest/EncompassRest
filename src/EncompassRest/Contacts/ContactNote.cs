using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class ContactNote : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _noteIdInt;
        private DirtyValue<string> _subject;
        private DirtyValue<DateTime?> _timestamp;
        private DirtyValue<string> _details;

        [JsonProperty("noteId")]
        public int? NoteIdInt { get => _noteIdInt; set => SetField(ref _noteIdInt, value); }

        [JsonIgnore]
        public string NoteId
        {
            get => NoteIdInt?.ToString();
            set => NoteIdInt = value != null && int.TryParse(value, out var noteId) ? noteId : (int?)null;
        }

        public string Subject { get => _subject; set => SetField(ref _subject, value); }

        public DateTime? Timestamp { get => _timestamp; set => SetField(ref _timestamp, value); }

        public string Details { get => _details; set => SetField(ref _details, value); }

        [IdPropertyName(nameof(NoteId))]
        string IIdentifiable.Id { get => NoteId; set => NoteId = value; }

        /// <summary>
        /// Contact note creation constructor
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="details"></param>
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
        /// <param name="noteId"></param>
        public ContactNote(string noteId)
        {
            Preconditions.NotNullOrEmpty(noteId, nameof(noteId));

            NoteId = noteId;
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public ContactNote()
        {
        }
    }
}