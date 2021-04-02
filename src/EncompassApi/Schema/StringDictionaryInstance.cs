using EncompassApi.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace EncompassApi.Schema
{
    /// <summary>
    /// StringDictionaryInstance
    /// </summary>
    public sealed class StringDictionaryInstance : Instance, IDictionary<string, string>, IReadOnlyDictionary<string, string>
    {
        private readonly Dictionary<string, string> _dictionary;

        /// <summary>
        /// The StringDictionaryInstance indexer.
        /// </summary>
        /// <param name="key">The key of the item.</param>
        /// <returns></returns>
        public string this[string key] { get => _dictionary[key]; set => _dictionary[key] = value; }

        /// <summary>
        /// The StringDictionaryInstance key collection.
        /// </summary>
        public ICollection<string> Keys => _dictionary.Keys;

        /// <summary>
        /// The StringDictionaryInstance value collection.
        /// </summary>
        public ICollection<string> Values => _dictionary.Values;

        /// <summary>
        /// The StringDictionaryInstance count.
        /// </summary>
        public int Count => _dictionary.Count;

        /// <summary>
        /// The instance type.
        /// </summary>
        public override InstanceType Type => InstanceType.StringDictionary;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Keys => Keys;

        IEnumerable<string> IReadOnlyDictionary<string, string>.Values => Values;

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        /// <summary>
        /// The StringDictionaryInstance constructor.
        /// </summary>
        public StringDictionaryInstance()
        {
            _dictionary = new Dictionary<string, string>();
        }

        /// <summary>
        /// The StringDictionaryInstance constructor.
        /// </summary>
        /// <param name="dictionary">The values to initialize the instance with.</param>
        public StringDictionaryInstance(IDictionary<string, string> dictionary)
        {
            Preconditions.NotNull(dictionary, nameof(dictionary));

            _dictionary = new Dictionary<string, string>(dictionary);
        }

        /// <summary>
        /// Adds the <paramref name="value"/> with the specified <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The key of the item to add.</param>
        /// <param name="value">The value of the item to add.</param>
        public void Add(string key, string value) => _dictionary.Add(key, value);

        /// <summary>
        /// Clears the contents of the collection.
        /// </summary>
        public void Clear() => _dictionary.Clear();

        /// <summary>
        /// Indicates if an item with the specified <paramref name="key"/> is contained within the collection.
        /// </summary>
        /// <param name="key">The key of the item to look for.</param>
        /// <returns></returns>
        public bool ContainsKey(string key) => _dictionary.ContainsKey(key);

        /// <summary>
        /// Gets an enumerator for the collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => ((IDictionary<string, string>)_dictionary).GetEnumerator();

        /// <summary>
        /// Removes the item with the specified <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The key of the item to remove.</param>
        /// <returns></returns>
        public bool Remove(string key) => _dictionary.Remove(key);

        /// <summary>
        /// Tries to get the value with the specified <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The key of the item to get.</param>
        /// <param name="value">The value of the item to get.</param>
        /// <returns></returns>
        public bool TryGetValue(string key, out string value) => _dictionary.TryGetValue(key, out value);

        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Add(item);

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Contains(item);

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => ((IDictionary<string, string>)_dictionary).CopyTo(array, arrayIndex);

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => ((IDictionary<string, string>)_dictionary).Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}