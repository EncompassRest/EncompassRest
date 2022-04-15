using System.Collections;
using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// IntListInstance
    /// </summary>
    public sealed class IntListInstance : Instance, IList<int>, IReadOnlyList<int>
    {
        private readonly List<int> _values;

        /// <summary>
        /// The IntListInstance indexer.
        /// </summary>
        /// <param name="index">The index of the item to get or set.</param>
        /// <returns></returns>
        public int this[int index] { get => _values[index]; set => _values[index] = value; }

        /// <summary>
        /// The IntListInstance count.
        /// </summary>
        public int Count => _values.Count;

        /// <summary>
        /// The instance type.
        /// </summary>
        public override InstanceType Type => InstanceType.IntList;

        bool ICollection<int>.IsReadOnly => false;

        /// <summary>
        /// The IntListInstance constructor.
        /// </summary>
        public IntListInstance()
        {
            _values = new List<int>();
        }

        /// <summary>
        /// The IntListInstance constructor.
        /// </summary>
        /// <param name="values">The values to initialize the instance with.</param>
        public IntListInstance(IEnumerable<int> values)
        {
            Preconditions.NotNull(values, nameof(values));

            _values = new List<int>(values);
        }

        /// <summary>
        /// Adds the item to the collection.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void Add(int item) => _values.Add(item);

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public void Clear() => _values.Clear();

        /// <summary>
        /// Indicates if an <paramref name="item"/> is contained within the collection.
        /// </summary>
        /// <param name="item">The item to look for.</param>
        /// <returns></returns>
        public bool Contains(int item) => _values.Contains(item);

        /// <summary>
        /// Gets an enumerator for the collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<int> GetEnumerator() => ((IList<int>)_values).GetEnumerator();

        /// <summary>
        /// Gets the index of the <paramref name="item"/>.
        /// </summary>
        /// <param name="item">The item to look for.</param>
        /// <returns></returns>
        public int IndexOf(int item) => _values.IndexOf(item);

        /// <summary>
        /// Inserts the <paramref name="item"/> at the specified <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index at which to insert the item.</param>
        /// <param name="item">The item to insert.</param>
        public void Insert(int index, int item) => _values.Insert(index, item);

        /// <summary>
        /// Removes the specified <paramref name="item"/>.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        /// <returns></returns>
        public bool Remove(int item) => _values.Remove(item);

        /// <summary>
        /// Removes the item at the specified <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index of the item to remove.</param>
        public void RemoveAt(int index) => _values.RemoveAt(index);

        void ICollection<int>.CopyTo(int[] array, int arrayIndex) => _values.CopyTo(array, arrayIndex);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}