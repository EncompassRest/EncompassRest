using EncompassRest.Utilities;
using System.Collections;
using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class StringListInstance : Instance, IList<string>
    {
        private readonly List<string> _values;

        public string this[int index] { get => _values[index]; set => _values[index] = value; }

        public int Count => _values.Count;

        public override InstanceType Type => InstanceType.StringList;

        bool ICollection<string>.IsReadOnly => false;

        public StringListInstance()
        {
            _values = new List<string>();
        }

        public StringListInstance(IEnumerable<string> values)
        {
            Preconditions.NotNull(values, nameof(values));

            _values = new List<string>(values);
        }

        public void Add(string item) => _values.Add(item);

        public void Clear() => _values.Clear();

        public bool Contains(string item) => _values.Contains(item);

        public void CopyTo(string[] array, int arrayIndex) => _values.CopyTo(array, arrayIndex);

        public IEnumerator<string> GetEnumerator() => ((IList<string>)_values).GetEnumerator();

        public int IndexOf(string item) => _values.IndexOf(item);

        public void Insert(int index, string item) => _values.Insert(index, item);

        public bool Remove(string item) => _values.Remove(item);

        public void RemoveAt(int index) => _values.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}