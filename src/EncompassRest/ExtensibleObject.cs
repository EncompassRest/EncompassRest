using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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
                var dirty = _extensionData?.Dirty == true;
                if (!dirty)
                {
                    var customContractResolver = JsonHelper.InternalPrivateContractResolver;
                    var contract = (JsonObjectContract)customContractResolver.ResolveContract(GetType());
                    foreach (var property in contract.Properties)
                    {
                        if (!property.Ignored)
                        {
                            var valueProvider = customContractResolver.GetBackingFieldInfo(property.DeclaringType, property.UnderlyingName)?.ValueProvider ?? property.ValueProvider;
                            if ((valueProvider.GetValue(this) as IDirty)?.Dirty == true)
                            {
                                dirty = true;
                                break;
                            }
                        }
                    }
                }
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (!_settingDirty)
                {
                    _settingDirty = true;
                    var customContractResolver = JsonHelper.InternalPrivateContractResolver;
                    var contract = (JsonObjectContract)customContractResolver.ResolveContract(GetType());
                    foreach (var property in contract.Properties)
                    {
                        if (!property.Ignored)
                        {
                            var valueProvider = customContractResolver.GetBackingFieldInfo(property.DeclaringType, property.UnderlyingName)?.ValueProvider ?? property.ValueProvider;
                            if (valueProvider.GetValue(this) is IDirty dirtyObject)
                            {
                                dirtyObject.Dirty = value;
                            }
                        }
                    }
                    if (_extensionData != null)
                    {
                        _extensionData.Dirty = value;
                    }
                    _settingDirty = false;
                }
            }
        }
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