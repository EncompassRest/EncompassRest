using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    [JsonConverter(typeof(DirtyDictionaryConverter<,>))]
    internal sealed class DirtyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>, IDictionary, IDirty
    {
        internal readonly Dictionary<TKey, DirtyValue<TValue>> _dictionary;
        private ValueCollection? _values;

        public TValue this[TKey key] { get => _dictionary[key]; set => _dictionary[key] = value; }

        public ICollection<TKey> Keys => _dictionary.Keys;

        public ICollection<TValue> Values => _values ?? (_values = new ValueCollection(this));

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;

        public bool Dirty
        {
            get => _dictionary.Any(pair => pair.Value.Dirty == true);
            set
            {
                foreach (var pair in _dictionary)
                {
                    pair.Value.Dirty = value;
                }
            }
        }

        IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => Keys;

        IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => Values;

        bool IDictionary.IsFixedSize => false;

        ICollection IDictionary.Keys => _dictionary.Keys;

        ICollection IDictionary.Values => (ICollection)Values;

        int ICollection.Count => Count;

        bool ICollection.IsSynchronized => ((ICollection)_dictionary).IsSynchronized;

        object ICollection.SyncRoot => ((ICollection)_dictionary).SyncRoot;

        object? IDictionary.this[object key] { get => this[ValidateKey(key)]; set => this[ValidateKey(key)] = ValidateValue(value); }

        public DirtyDictionary()
            : this((IEqualityComparer<TKey>?)null)
        {
        }

        public DirtyDictionary(IEqualityComparer<TKey>? comparer)
        {
            _dictionary = new Dictionary<TKey, DirtyValue<TValue>>(comparer);
        }

        public DirtyDictionary(IDictionary<TKey, TValue>? dictionary)
            : this(dictionary, null)
        {
        }

        public DirtyDictionary(IDictionary<TKey, TValue>? dictionary, IEqualityComparer<TKey>? comparer)
            : this(comparer)
        {
            if (dictionary != null)
            {
                foreach (var pair in dictionary)
                {
                    Add(pair);
                }
            }
        }

        public void Add(TKey key, TValue value) => _dictionary.Add(key, value);

        public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);

        public void Clear() => _dictionary.Clear();

        public bool Contains(KeyValuePair<TKey, TValue> item) => _dictionary.TryGetValue(item.Key, out var value) && EqualityComparer<TValue>.Default.Equals(item.Value, value);

        public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
            Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));

            var i = 0;
            foreach (var pair in _dictionary)
            {
                array[arrayIndex + i] = new KeyValuePair<TKey, TValue>(pair.Key, pair.Value);
                ++i;
            }
        }

        public Enumerator GetEnumerator() => new Enumerator(this, false);

        public bool Remove(TKey key) => _dictionary.Remove(key);

        public bool Remove(KeyValuePair<TKey, TValue> item) => Contains(item) && Remove(item.Key);

        public bool TryGetValue(TKey key, out TValue value)
        {
            var success = _dictionary.TryGetValue(key, out var dirtyValue);
            value = success ? dirtyValue._value! : default!;
            return success;
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        internal IEnumerable<KeyValuePair<TKey, TValue>> GetDirtyItems() => _dictionary.Where(pair => pair.Value.Dirty).Select(pair => new KeyValuePair<TKey, TValue>(pair.Key, pair.Value));

        void IDictionary.Add(object key, object value) => Add(ValidateKey(key), ValidateValue(value));

        bool IDictionary.Contains(object key) => ContainsKey(ValidateKey(key));

        IDictionaryEnumerator IDictionary.GetEnumerator() => new Enumerator(this, true);

        void IDictionary.Remove(object key) => Remove(ValidateKey(key));

        void ICollection.CopyTo(Array array, int index)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(index, nameof(index), array.Length, $"{nameof(array)}.Length");
            Preconditions.GreaterThanOrEquals(array.Length - index, $"{nameof(array)}.Length - {nameof(index)}", Count, nameof(Count));

            var i = 0;
            foreach (var pair in _dictionary)
            {
                array.SetValue(new KeyValuePair<TKey, TValue>(pair.Key, pair.Value), index + i);
                ++i;
            }
        }

        private TKey ValidateKey(object key)
        {
            if (!(key is TKey tKey))
            {
                throw new ArgumentException($"key is not of type {TypeData<TKey>.Type.Name}");
            }
            return tKey;
        }

        private TValue ValidateValue(object? value)
        {
            if (value == null)
            {
                return default!;
            }
            if (!(value is TValue tValue))
            {
                throw new ArgumentException($"value is not of type {TypeData<TValue>.Type.Name}");
            }
            return tValue;
        }

        private sealed class ValueCollection : ICollection<TValue>, IReadOnlyCollection<TValue>, ICollection
        {
            private readonly DirtyDictionary<TKey, TValue> _dictionary;

            public ValueCollection(DirtyDictionary<TKey, TValue> dictionary)
            {
                _dictionary = dictionary;
            }

            public int Count => _dictionary.Count;

            public bool IsReadOnly => true;

            public bool IsSynchronized => ((ICollection)_dictionary._dictionary).IsSynchronized;

            public object SyncRoot => ((ICollection)_dictionary._dictionary).SyncRoot;

            public void Add(TValue item) => throw new NotSupportedException();

            public void Clear() => throw new NotSupportedException();

            public bool Contains(TValue item)
            {
                var comparer = EqualityComparer<TValue>.Default;
                foreach (var pair in _dictionary._dictionary)
                {
                    if (comparer.Equals(item, pair.Value))
                    {
                        return true;
                    }
                }
                return false;
            }

            public void CopyTo(TValue[] array, int arrayIndex)
            {
                Preconditions.NotNull(array, nameof(array));
                Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
                Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));

                var i = 0;
                foreach (var pair in _dictionary._dictionary)
                {
                    array[i] = pair.Value;
                    ++i;
                }
            }

            public void CopyTo(Array array, int index)
            {
                Preconditions.NotNull(array, nameof(array));
                Preconditions.LessThan(index, nameof(index), array.Length, $"{nameof(array)}.Length");
                Preconditions.GreaterThanOrEquals(array.Length - index, $"{nameof(array)}.Length - {nameof(index)}", Count, nameof(Count));

                var i = 0;
                foreach (var pair in _dictionary._dictionary)
                {
                    array.SetValue((TValue)pair.Value, i);
                    ++i;
                }
            }

            public IEnumerator<TValue> GetEnumerator()
            {
                foreach (var pair in _dictionary._dictionary)
                {
                    yield return pair.Value;
                }
            }

            public bool Remove(TValue item) => throw new NotSupportedException();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDictionaryEnumerator
        {
            private readonly IEnumerator<KeyValuePair<TKey, DirtyValue<TValue>>> _enumerator;
            private readonly bool _dictionaryEnumerator;

            public KeyValuePair<TKey, TValue> Current => new KeyValuePair<TKey, TValue>(_enumerator.Current.Key, _enumerator.Current.Value);

            public DictionaryEntry Entry => new DictionaryEntry(Current.Key, Current.Value);

            public object Key => Current.Key!;

            public object? Value => Current.Value;

            object IEnumerator.Current => _dictionaryEnumerator ? Entry : (object)Current;

            internal Enumerator(DirtyDictionary<TKey, TValue> dictionary, bool dictionaryEnumerator)
            {
                _enumerator = dictionary._dictionary.GetEnumerator();
                _dictionaryEnumerator = dictionaryEnumerator;
            }

            public void Dispose() => _enumerator.Dispose();

            public bool MoveNext() => _enumerator.MoveNext();

            public void Reset() => _enumerator.Reset();
        }
    }

    internal sealed class DirtyDictionaryConverter<TKey, TValue> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<DirtyDictionary<TKey, TValue>>.Type;

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotSupportedException();

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dirtyDictionary = (DirtyDictionary<TKey, TValue>)value;
            var dirtyItems = dirtyDictionary.GetDirtyItems();
            var dictionary = new Dictionary<TKey, TValue>(dirtyDictionary._dictionary.Comparer);
            foreach (var dirtyItem in dirtyItems)
            {
                dictionary[dirtyItem.Key] = dirtyItem.Value;
            }
            serializer.Serialize(writer, dictionary);
        }
    }
}