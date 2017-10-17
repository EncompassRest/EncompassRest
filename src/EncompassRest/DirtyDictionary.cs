using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    internal sealed class DirtyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IDirty
    {
        internal readonly Dictionary<TKey, DirtyValue<TValue>> _dictionary = new Dictionary<TKey, DirtyValue<TValue>>();

        public TValue this[TKey key] { get { return _dictionary[key]; } set { _dictionary[key] = value; } }

        public ICollection<TKey> Keys => _dictionary.Keys;

        public ICollection<TValue> Values => _dictionary.Values.Cast<TValue>().ToList();

        public int Count => _dictionary.Count;

        public bool IsReadOnly => false;

        public bool Dirty
        {
            get
            {
                return _dictionary.Any(pair => pair.Value.Dirty);
            }
            set
            {
                foreach (var pair in _dictionary.ToList())
                {
                    var pairValue = pair.Value;
                    pairValue.Dirty = value;
                    _dictionary[pair.Key] = pairValue;
                }
            }
        }

        public DirtyDictionary()
        {
        }

        public DirtyDictionary(IDictionary<TKey, TValue> dictionary)
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

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            DirtyValue<TValue> value;
            return _dictionary.TryGetValue(item.Key, out value) && EqualityComparer<TValue>.Default.Equals(item.Value, value);
        }

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

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var pair in _dictionary)
            {
                yield return new KeyValuePair<TKey, TValue>(pair.Key, pair.Value);
            }
        }

        public bool Remove(TKey key) => _dictionary.Remove(key);

        public bool Remove(KeyValuePair<TKey, TValue> item) => Contains(item) && Remove(item.Key);

        public bool TryGetValue(TKey key, out TValue value)
        {
            DirtyValue<TValue> dirtyValue;
            var success = _dictionary.TryGetValue(key, out dirtyValue);
            value = success ? (TValue)dirtyValue : default(TValue);
            return success;
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IDictionary<TKey, TValue>)_dictionary).GetEnumerator();

        internal IEnumerable<KeyValuePair<TKey, TValue>> GetDirtyItems() => _dictionary.Where(pair => pair.Value.Dirty).Select(pair => new KeyValuePair<TKey, TValue>(pair.Key, pair.Value));
    }

    internal sealed class DirtyDictionaryConverter<TKey, TValue> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<DirtyDictionary<TKey, TValue>>.Type;

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, ((DirtyDictionary<TKey, TValue>)value).GetDirtyItems());
    }
}