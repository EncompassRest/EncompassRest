using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Base class that supports extension data and json serialization.
    /// </summary>
    public abstract class ExtensibleObject : SerializableObject, IDirty, IIdentifiable
#if HAVE_ICLONEABLE
        , ICloneable
#endif
    {
        private DirtyDictionary<string, object> _extensionData;
        /// <summary>
        /// Extension Data
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>(StringComparer.OrdinalIgnoreCase)); set => _extensionData = new DirtyDictionary<string, object>(value, StringComparer.OrdinalIgnoreCase); }
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
                var dirty = CustomDirty || DirtyInternal || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (!_settingDirty)
                {
                    _settingDirty = true;
                    CustomDirty = value;
                    DirtyInternal = value;
                    if (_extensionData != null)
                    {
                        _extensionData.Dirty = value;
                    }
                    _settingDirty = false;
                }
            }
        }
        internal virtual bool CustomDirty { get => false; set { } }
        internal virtual bool DirtyInternal { get => false; set { } }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
        string IIdentifiable.Id { get => string.Empty; set { } }
        internal ExtensibleObject()
        {
        }

#if HAVE_ICLONEABLE
        object ICloneable.Clone() => this.Clone();
#endif
    }
}