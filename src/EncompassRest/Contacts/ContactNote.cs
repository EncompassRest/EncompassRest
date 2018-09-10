using System;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class ContactNote : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _noteIdInt;
        [JsonProperty("noteId")]
        public int? NoteIdInt { get => _noteIdInt; set => SetField(ref _noteIdInt, value); }
        [JsonIgnore]
        public string NoteId
        {
            get => NoteIdInt?.ToString();
            set => NoteIdInt = value != null && int.TryParse(value, out var noteId) ? noteId : (int?)null;
        }
        private DirtyValue<string> _subject;
        public string Subject { get => _subject; set => SetField(ref _subject, value); }
        private DirtyValue<DateTime?> _timestamp;
        public DateTime? Timestamp { get => _timestamp; set => SetField(ref _timestamp, value); }
        private DirtyValue<string> _details;
        public string Details { get => _details; set => SetField(ref _details, value); }
        [IdPropertyName(nameof(NoteId))]
        string IIdentifiable.Id { get => NoteId; set => NoteId = value; }
    }
}