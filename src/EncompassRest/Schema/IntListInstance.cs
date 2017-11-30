using EncompassRest.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class IntListInstance : Instance, IList<int>
    {
        private readonly List<int> _values;

        public int this[int index] { get => _values[index]; set => _values[index] = value; }

        public int Count => _values.Count;

        public override InstanceType Type => InstanceType.IntList;

        bool ICollection<int>.IsReadOnly => false;

        public IntListInstance()
        {
            _values = new List<int>();
        }

        public IntListInstance(IEnumerable<int> values)
        {
            Preconditions.NotNull(values, nameof(values));

            _values = new List<int>(values);
        }

        public void Add(int item) => _values.Add(item);
        public void Clear() => _values.Clear();
        public bool Contains(int item) => _values.Contains(item);
        public void CopyTo(int[] array, int arrayIndex) => _values.CopyTo(array, arrayIndex);
        public IEnumerator<int> GetEnumerator() => ((IList<int>)_values).GetEnumerator();
        public int IndexOf(int item) => _values.IndexOf(item);
        public void Insert(int index, int item) => _values.Insert(index, item);
        public bool Remove(int item) => _values.Remove(item);
        public void RemoveAt(int index) => _values.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}