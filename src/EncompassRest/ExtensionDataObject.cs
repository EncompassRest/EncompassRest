using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EncompassRest
{
    internal sealed class ExtensionDataObject : IDictionary<string, object>, IDirty
    {
        internal readonly DirtyDictionary<string, object> _dictionary = new DirtyDictionary<string, object>();

        public object this[string key]
        {
            get
            {
                DirtyValue<object> dirtyValue;
                if (!_dictionary._dictionary.TryGetValue(key, out dirtyValue) || !dirtyValue.Dirty)
                {
                    throw new KeyNotFoundException();
                }
                return dirtyValue._value;
            }
            set
            {
                _dictionary[key] = value;
            }
        }

        public ICollection<string> Keys => _dictionary.GetDirtyItems().Select(item => item.Key).ToList();

        public ICollection<object> Values => _dictionary.GetDirtyItems().Select(item => item.Value).ToList();

        public int Count => _dictionary.GetDirtyItems().Count();

        public bool IsReadOnly => _dictionary.IsReadOnly;

        public bool Dirty { get => _dictionary.Dirty; set => _dictionary.Dirty = value; }

        public IDictionary<string, object> InternalDictionary => _dictionary;

        public ExtensionDataObject()
        {
        }

        public ExtensionDataObject(IDictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                foreach (var pair in dictionary)
                {
                    _dictionary.Add(pair);
                }
            }
        }

        public void Add(string key, object value)
        {
            if (_dictionary.ContainsKey(key))
            {
                _dictionary[key] = value;
            }
            else
            {
                _dictionary.Add(key, value);
            }
        }

        public void Add(KeyValuePair<string, object> item) => Add(item.Key, item.Value);

        public void Clear() => _dictionary.Clear();

        public bool Contains(KeyValuePair<string, object> item) => ContainsKey(item.Key);

        public bool ContainsKey(string key)
        {
            DirtyValue<object> dirtyValue;
            return _dictionary._dictionary.TryGetValue(key, out dirtyValue) && dirtyValue.Dirty;
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            _dictionary.GetDirtyItems().ToList().CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            foreach (var pair in _dictionary.GetDirtyItems())
            {
                yield return pair;
            }
        }

        public bool Remove(string key) => ContainsKey(key) && _dictionary.Remove(key);

        public bool Remove(KeyValuePair<string, object> item) => Remove(item.Key);

        public bool TryGetValue(string key, out object value)
        {
            DirtyValue<object> dirtyValue;
            var success = _dictionary._dictionary.TryGetValue(key, out dirtyValue) && dirtyValue.Dirty;
            value = success ? dirtyValue._value : null;
            return success;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}