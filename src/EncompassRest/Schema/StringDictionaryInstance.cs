using EncompassRest.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class StringDictionaryInstance : Instance, IDictionary<string, string>
    {
        private readonly Dictionary<string, string> _dictionary;

        public string this[string key] { get => _dictionary[key]; set => _dictionary[key] = value; }

        public ICollection<string> Keys => _dictionary.Keys;

        public ICollection<string> Values => _dictionary.Values;

        public int Count => _dictionary.Count;

        public override InstanceType Type => InstanceType.StringDictionary;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        public StringDictionaryInstance()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public StringDictionaryInstance(IDictionary<string, string> dictionary)
        {
            Preconditions.NotNull(dictionary, nameof(dictionary));

            _dictionary = new Dictionary<string, string>(dictionary);
        }

        public void Add(string key, string value) => _dictionary.Add(key, value);

        public void Add(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Add(item);

        public void Clear() => _dictionary.Clear();

        public bool Contains(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Contains(item);

        public bool ContainsKey(string key) => _dictionary.ContainsKey(key);

        public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => ((IDictionary<string, string>)_dictionary).CopyTo(array, arrayIndex);

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => ((IDictionary<string, string>)_dictionary).GetEnumerator();

        public bool Remove(string key) => _dictionary.Remove(key);

        public bool Remove(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Remove(item);

        public bool TryGetValue(string key, out string value) => _dictionary.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}