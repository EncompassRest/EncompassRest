using Newtonsoft.Json;
using System.Collections.Generic;

namespace EncompassRest
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class ExtensibleObject : IDirty
    {
        private DirtyDictionary<string, object> _extensionData;
        [JsonExtensionData]
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty)
                {
                    return false;
                }
                _gettingDirty = true;
                var dirty = DirtyInternal || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (!_settingDirty)
                {
                    _settingDirty = true;
                    DirtyInternal = value;
                    if (_extensionData != null)
                    {
                        _extensionData.Dirty = value;
                    }
                    _settingDirty = false;
                }
            }
        }
        internal virtual bool DirtyInternal { get => false; set { } }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
        internal ExtensibleObject()
        {
        }
    }
}