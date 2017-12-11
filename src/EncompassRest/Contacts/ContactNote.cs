using System;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class ContactNote : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _noteIdInt;
        [JsonProperty("noteId")]
        public int? NoteIdInt { get => _noteIdInt; set => _noteIdInt = value; }
        [JsonIgnore]
        public string NoteId
        {
            get => NoteIdInt?.ToString();
            set => NoteIdInt = value != null && int.TryParse(value, out var noteId) ? noteId : (int?)null;
        }
        private DirtyValue<string> _subject;
        public string Subject { get => _subject; set => _subject = value; }
        private DirtyValue<DateTime?> _timestamp;
        public DateTime? Timestamp { get => _timestamp; set => _timestamp = value; }
        private DirtyValue<string> _details;
        public string Details { get => _details; set => _details = value; }
        [IdPropertyName(nameof(NoteId))]
        string IIdentifiable.Id { get => NoteId; set => NoteId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _noteIdInt.Dirty
                    || _subject.Dirty
                    || _timestamp.Dirty
                    || _details.Dirty;
            }
            set
            {
                _noteIdInt.Dirty = value;
                _subject.Dirty = value;
                _timestamp.Dirty = value;
                _details.Dirty = value;
            }
        }
    }
}