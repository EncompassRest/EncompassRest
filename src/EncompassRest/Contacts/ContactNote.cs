using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class ContactNote : IDirty
    {
        private DirtyValue<int?> _noteIdInt;
        [JsonProperty("noteId")]
        public int? NoteIdInt { get => _noteIdInt; set => _noteIdInt = value; }
        [JsonIgnore]
        public string NoteId
        {
            get => NoteIdInt?.ToString();
            set
            {
                if (value == null || !int.TryParse(value, out var noteId))
                {
                    NoteIdInt = null;
                }
                else
                {
                    NoteIdInt = noteId;
                }
            }
        }
        private DirtyValue<string> _subject;
        public string Subject { get => _subject; set => _subject = value; }
        private DirtyValue<DateTime?> _timestamp;
        public DateTime? Timestamp { get => _timestamp; set => _timestamp = value; }
        private DirtyValue<string> _details;
        public string Details { get => _details; set => _details = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _noteIdInt.Dirty
                    || _subject.Dirty
                    || _timestamp.Dirty
                    || _details.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _noteIdInt.Dirty = value;
                _subject.Dirty = value;
                _timestamp.Dirty = value;
                _details.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}
