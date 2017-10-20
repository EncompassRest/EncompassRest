using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EncompassRest.Contacts
{
    public sealed class ContactNote : IDirty
    {
        private DirtyValue<int?> _noteIdInt;
        [JsonProperty("noteId")]
        public int? NoteIdInt { get { return _noteIdInt; } set { _noteIdInt = value; } }
        [JsonIgnore]
        public string NoteId
        {
            get
            {
                return NoteIdInt?.ToString();
            }
            set
            {
                int noteId;
                if (value == null || !int.TryParse(value, out noteId))
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
        public string Subject { get { return _subject; } set { _subject = value; } }
        private DirtyValue<DateTime?> _timestamp;
        public DateTime? Timestamp { get { return _timestamp; } set { _timestamp = value; } }
        private DirtyValue<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                    || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
