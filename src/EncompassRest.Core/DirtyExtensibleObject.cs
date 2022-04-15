using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EncompassRest.Utilities;
using Newtonsoft.Json.Serialization;

namespace EncompassRest
{
    /// <summary>
    /// Base interface that supports extension data and dirty json serialization.
    /// </summary>
    public interface IDirtyExtensibleObject : IExtensibleObject, INotifyPropertyChanged
    {
    }

    /// <summary>
    /// Base class that supports extension data and dirty json serialization.
    /// </summary>
    public abstract class DirtyExtensibleObject : ExtensibleObject, IDirty, IIdentifiable, IDirtyExtensibleObject
#if ICLONEABLE
        , ICloneable
#endif
    {
        /// <summary>
        /// The PropertyChanged Event
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        internal virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        internal void ClearPropertyChangedEvent() => PropertyChanged = null;

        internal void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            var equals = EqualityComparer<T>.Default.Equals(field, value);
            field = value;
            if (!equals)
            {
                OnPropertyChanged(propertyName);
            }
        }

        internal void SetField<T>(ref NeverSerializeValue<T>? field, T value, [CallerMemberName] string? propertyName = null)
        {
            var equals = EqualityComparer<T>.Default.Equals(field, value);
            field = value;
            if (!equals)
            {
                OnPropertyChanged(propertyName);
            }
        }

        internal void SetField<T>(ref DirtyValue<T>? field, T value, [CallerMemberName] string? propertyName = null)
        {
            var equals = EqualityComparer<T>.Default.Equals(field!, value);
            field = value;
            if (!equals)
            {
                OnPropertyChanged(propertyName);
            }
        }

        internal void SetField<T>(ref DirtyList<T>? field, IList<T>? value, [CallerMemberName] string? propertyName = null)
        {
            if (!ReferenceEquals(field, value))
            {
                field = value != null ? new DirtyList<T>(value) : null;
                OnPropertyChanged(propertyName);
            }
        }

        internal void SetField<T>(ref DirtyDictionary<string, T>? field, IDictionary<string, T>? value, [CallerMemberName] string? propertyName = null)
        {
            if (base.SetField(ref field, value))
            {
                OnPropertyChanged(propertyName);
            }
        }

        internal T GetField<T>(ref T? field) where T : DirtyExtensibleObject, new() => field ??= new T();

        internal IList<T> GetField<T>(ref DirtyList<T>? field) => field ??= new DirtyList<T>();

        internal IList<T> GetField<T>(ref List<T>? field) => field ??= new List<T>();

        internal new IDictionary<string, T> GetField<T>(ref DirtyDictionary<string, T>? field) => base.GetField(ref field);

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
                            var valueProvider = customContractResolver.GetBackingFieldInfo(property.DeclaringType!, property.UnderlyingName!)?.ValueProvider ?? property.ValueProvider!;
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
                            var valueProvider = customContractResolver.GetBackingFieldInfo(property.DeclaringType!, property.UnderlyingName!)?.ValueProvider ?? property.ValueProvider!;
                            if (valueProvider.GetValue(this) is IDirty dirtyObject)
                            {
                                dirtyObject.Dirty = value;
                            }
                        }
                    }
                    var extensionData = _extensionData;
                    if (extensionData != null)
                    {
                        extensionData.Dirty = value;
                    }
                    _settingDirty = false;
                }
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }

        internal string? LastId { get; set; }

        string? IIdentifiable.Id { get => string.Empty; set { } }

        internal DirtyExtensibleObject()
        {
        }

        internal static string GetIdPropertyName(TypeInfo typeInfo)
        {
            var idProperty = GetIdProperty(typeInfo);
            var idPropertyNameAttribute = idProperty.GetCustomAttribute<IdPropertyNameAttribute>(false);
            return idPropertyNameAttribute != null ? idPropertyNameAttribute.IdPropertyName : "Id";
        }

        private static PropertyInfo GetIdProperty(TypeInfo typeInfo) => typeInfo.DeclaredProperties.FirstOrDefault(p => p.Name == "EncompassRest.IIdentifiable.Id") ?? typeInfo.DeclaredProperties.FirstOrDefault(p => p.Name == "Id") ?? GetIdProperty(typeInfo.BaseType.GetTypeInfo());

#if ICLONEABLE
        object ICloneable.Clone() => this.Clone();
#endif
    }
}