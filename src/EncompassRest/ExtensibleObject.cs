using System.Collections.Generic;
using System.IO;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class ExtensibleObject : IDirty, IIdentifiable
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
        string IIdentifiable.Id { get => string.Empty; set { } }
        internal ExtensibleObject()
        {
        }

        public override string ToString() => ToString(false);

        public string ToString(bool indent)
        {
            var serializer = indent ? JsonHelper.DefaultIndentedPublicSerializer : JsonHelper.DefaultPublicSerializer;
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, this);
                return writer.ToString();
            }
        }
    }
}