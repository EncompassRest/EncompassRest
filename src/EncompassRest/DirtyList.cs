using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Collection to use for dirty checking.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonConverter(typeof(DirtyListConverter<>))]
    internal sealed class DirtyList<T> : IList<T>, IDirty
    {
        internal readonly List<DirtyValue<T>> _list;

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public bool Dirty
        {
            get
            {
                return _list.Any(item => item.Dirty);
            }
            set
            {
                for (var i = 0; i < _list.Count; ++i)
                {
                    var item = _list[i];
                    item.Dirty = value;
                    _list[i] = item;
                }
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public DirtyList()
        {
            _list = new List<DirtyValue<T>>();
        }

        public DirtyList(IEnumerable<T> list)
            : this()
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public void Add(T item) => _list.Add(item);

        public void Clear() => _list.Clear();

        public bool Contains(T item) => IndexOf(item) >= 0;

        public void CopyTo(T[] array, int arrayIndex)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length, $"{nameof(array)}.Length");
            Preconditions.GreaterThanOrEquals(array.Length - arrayIndex, $"{nameof(array)}.Length - {nameof(arrayIndex)}", Count, nameof(Count));
            
            for (var i = 0; i < _list.Count; ++i)
            {
                array[arrayIndex + i] = _list[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return item;
            }
        }

        public int IndexOf(T item)
        {
            var equalityComparer = EqualityComparer<T>.Default;
            for (var i = 0; i < _list.Count; ++i)
            {
                if (equalityComparer.Equals(_list[i], item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            var i = IndexOf(item);
            if (i >= 0)
            {
                RemoveAt(i);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index) => _list.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    internal sealed class DirtyListConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<DirtyList<T>>.Type;

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, ((DirtyList<T>)value)._list.Where(item => item.Dirty).Select(item => (T)item));
    }
}