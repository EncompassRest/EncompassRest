using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Base class that supports extension data and dirty json serialization.
    /// </summary>
    public abstract class DirtyExtensibleObject : ExtensibleObject, IIdentifiable, INotifyPropertyChanged, IDirtyObject, ICloneable, INotifyPropertyChanging
    {
        internal readonly Dictionary<string, IDirty> Properties = new();

        /// <summary>
        /// Gets the value for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="propertyName">The property name.</param>
        /// <returns></returns>
        protected T? GetValue<T>([CallerMemberName] string? propertyName = null) => Properties.TryGetValue(propertyName!, out var value) ? (value is T t ? t : (T?)((IValue)value).Value) : default;

        /// <summary>
        /// Sets the value for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="value">The property value to set.</param>
        /// <param name="propertyName">The property name.</param>
        protected void SetValue<T>(T? value, [CallerMemberName] string? propertyName = null)
        {
            Properties.TryGetValue(propertyName!, out var existing);
            var changing = !EqualityComparer<T>.Default.Equals((T)((existing is IValue existingValue ? existingValue.Value : existing) ?? default(T))!, value!);
            if (changing)
            {
                OnPropertyChanging(propertyName);
            }
            Properties[propertyName!] = value is IDirty dirty ? dirty : new DirtyValue<T?>(value);
            if (changing)
            {
                OnPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Gets or creates the entity for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="propertyName">The property name.</param>
        /// <returns></returns>
        protected T GetEntity<T>([CallerMemberName] string? propertyName = null) where T : DirtyExtensibleObject, new()
        {
            if (!Properties.TryGetValue(propertyName!, out var value))
            {
                value = new T();
                Properties[propertyName!] = value;
            }
            return (T)value;
        }

        /// <summary>
        /// Sets the entity for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T">The property type.</typeparam>
        /// <param name="value">The value to set.</param>
        /// <param name="propertyName">The property name.</param>
        protected void SetEntity<T>(T? value, [CallerMemberName] string? propertyName = null) where T : DirtyExtensibleObject, new()
        {
            Properties.TryGetValue(propertyName!, out var existing);
            if (!ReferenceEquals(existing, value))
            {
                OnPropertyChanging(propertyName);
                if (value is null)
                {
                    Properties.Remove(propertyName!);
                }
                else
                {
                    Properties[propertyName!] = value;
                }
                OnPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Gets or creates the list for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName">The property name.</param>
        /// <returns></returns>
        protected IList<T> GetList<T>([CallerMemberName] string? propertyName = null)
        {
            if (!Properties.TryGetValue(propertyName!, out var value))
            {
                value = new DirtyList<T>();
                Properties[propertyName!] = value;
            }
            return (IList<T>)value;
        }

        /// <summary>
        /// Sets the list for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value to set.</param>
        /// <param name="propertyName">The property name.</param>
        protected void SetList<T>(IList<T>? value, [CallerMemberName] string? propertyName = null)
        {
            Properties.TryGetValue(propertyName!, out var existing);
            if (!ReferenceEquals(existing, value))
            {
                OnPropertyChanging(propertyName);
                if (value is null)
                {
                    Properties.Remove(propertyName!);
                }
                else
                {
                    Properties[propertyName!] = new DirtyList<T>(value);
                }
                OnPropertyChanged(propertyName);
            }
        }

        /// <summary>
        /// Gets or creates the dictionary for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="propertyName">The property name.</param>
        /// <returns></returns>
        protected IDictionary<TKey, TValue> GetDictionary<TKey, TValue>([CallerMemberName] string? propertyName = null)
        {
            if (!Properties.TryGetValue(propertyName!, out var value))
            {
                value = new DirtyDictionary<TKey, TValue>();
                Properties[propertyName!] = value;
            }
            return (IDictionary<TKey, TValue>)value;
        }

        /// <summary>
        /// Sets the dictionary for the <paramref name="propertyName"/>.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value">The value to set.</param>
        /// <param name="propertyName">The property name.</param>
        protected void SetDictionary<TKey, TValue>(IDictionary<TKey, TValue>? value, [CallerMemberName] string? propertyName = null)
        {
            Properties.TryGetValue(propertyName!, out var existing);
            if (!ReferenceEquals(existing, value))
            {
                OnPropertyChanging(propertyName);
                if (value is null)
                {
                    Properties.Remove(propertyName!);
                }
                else
                {
                    Properties[propertyName!] = new DirtyDictionary<TKey, TValue>(value);
                }
                OnPropertyChanged(propertyName);
            }
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <inheritdoc/>
        public event PropertyChangingEventHandler? PropertyChanging;

        internal virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        internal virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null) => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        internal void ClearPropertyChangedEvent() => PropertyChanged = null;

        internal void ClearPropertyChangingEvent() => PropertyChanging = null;

        private bool _gettingDirty;
        private bool _settingDirty;

        /// <inheritdoc/>
        public bool Dirty
        {
            get
            {
                if (_gettingDirty)
                {
                    return false;
                }
                _gettingDirty = true;
                var dirty = _extensionData?.Dirty == true || Properties.Any(p => p.Value.Dirty);
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (!_settingDirty)
                {
                    _settingDirty = true;
                    foreach (var pair in Properties)
                    {
                        pair.Value.Dirty = value;
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

        /// <inheritdoc/>
        public bool IsPropertyDirty(string propertyName)
        {
            Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

            return Properties.TryGetValue(propertyName, out var value) && value.Dirty;
        }

        /// <inheritdoc/>
        public bool SetPropertyDirty(string propertyName, bool value)
        {
            Preconditions.NotNullOrEmpty(propertyName, nameof(propertyName));

            if (Properties.TryGetValue(propertyName, out var v))
            {
                v.Dirty = value;
                return true;
            }
            return false;
        }

        internal string? LastId { get; set; }

        string? IIdentifiable.Id { get => string.Empty; set { } }

        internal DirtyExtensibleObject()
        {
        }

        internal static string GetIdPropertyName(Type type)
        {
            var idProperty = GetIdProperty(type);
            var idPropertyNameAttribute = idProperty.GetCustomAttribute<IdPropertyNameAttribute>(false);
            return idPropertyNameAttribute != null ? idPropertyNameAttribute.IdPropertyName : "Id";
        }

        private static PropertyInfo GetIdProperty(Type type) => type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).FirstOrDefault(p => p.Name == "EncompassRest.IIdentifiable.Id") ?? type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).FirstOrDefault(p => p.Name == "Id") ?? GetIdProperty(type.BaseType);

        object ICloneable.Clone() => this.Clone();
    }
}