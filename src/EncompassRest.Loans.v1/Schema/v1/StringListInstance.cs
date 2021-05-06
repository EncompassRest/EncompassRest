using EncompassRest.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// StringListInstance
    /// </summary>
    public sealed class StringListInstance : Instance, IList<string>, IReadOnlyList<string>
    {
        private readonly List<string> _values;

        /// <summary>
        /// The StringListInstance indexer.
        /// </summary>
        /// <param name="index">The index of the item to get or set.</param>
        /// <returns></returns>
        public string this[int index] { get => _values[index]; set => _values[index] = value; }

        /// <summary>
        /// The StringListInstance count.
        /// </summary>
        public int Count => _values.Count;

        /// <summary>
        /// The instance type.
        /// </summary>
        public override InstanceType Type => InstanceType.StringList;

        bool ICollection<string>.IsReadOnly => false;

        /// <summary>
        /// The StringListInstance constructor.
        /// </summary>
        public StringListInstance()
        {
            _values = new List<string>();
        }

        /// <summary>
        /// The StringListInstance constructor.
        /// </summary>
        /// <param name="values">The values to initialize the instance with.</param>
        public StringListInstance(IEnumerable<string> values)
        {
            Preconditions.NotNull(values, nameof(values));

            _values = new List<string>(values);
        }

        /// <summary>
        /// Adds the item to the collection.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(string item) => _values.Add(item);

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public void Clear() => _values.Clear();

        /// <summary>
        /// Indicates if an <paramref name="item"/> is contained within the collection.
        /// </summary>
        /// <param name="item">The item to look for.</param>
        /// <returns></returns>
        public bool Contains(string item) => _values.Contains(item);

        /// <summary>
        /// Gets an enumerator for the collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<string> GetEnumerator() => ((IList<string>)_values).GetEnumerator();

        /// <summary>
        /// Gets the index of the <paramref name="item"/>.
        /// </summary>
        /// <param name="item">The item to look for.</param>
        /// <returns></returns>
        public int IndexOf(string item) => _values.IndexOf(item);

        /// <summary>
        /// Inserts the <paramref name="item"/> at the specified <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index at which to insert the item.</param>
        /// <param name="item">The item to insert.</param>
        public void Insert(int index, string item) => _values.Insert(index, item);

        /// <summary>
        /// Removes the specified <paramref name="item"/>.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        /// <returns></returns>
        public bool Remove(string item) => _values.Remove(item);

        /// <summary>
        /// Removes the item at the specified <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index of the item to remove.</param>
        public void RemoveAt(int index) => _values.RemoveAt(index);

        void ICollection<string>.CopyTo(string[] array, int arrayIndex) => _values.CopyTo(array, arrayIndex);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}