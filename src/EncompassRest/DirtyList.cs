using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Collection to use for dirty checking.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonConverter(typeof(DirtyListConverter<>))]
    internal sealed class DirtyList<T> : IList<T>, IList, IDirty
    {
        internal readonly List<DirtyValue<T>> _list = new List<DirtyValue<T>>();

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public bool Dirty
        {
            get => _list.Any(item => item.Dirty);
            set
            {
                foreach (var dirtyValue in _list)
                {
                    dirtyValue.Dirty = value;
                }
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;
        
        bool IList.IsFixedSize => ((IList)_list).IsFixedSize;

        bool ICollection.IsSynchronized => ((IList)_list).IsSynchronized;

        object ICollection.SyncRoot => ((IList)_list).SyncRoot;

        object IList.this[int index] { get => this[index]; set => this[index] = ValidateValue(value); }

        public DirtyList()
        {
        }

        public DirtyList(IEnumerable<T> list)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    Add(item);
                }
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

        public void Insert(int index, T item) => _list.Insert(index, item);

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

        int IList.Add(object value)
        {
            Add(ValidateValue(value));
            return Count - 1;
        }

        bool IList.Contains(object value) => Contains(ValidateValue(value));

        int IList.IndexOf(object value) => IndexOf(ValidateValue(value));

        void IList.Insert(int index, object value) => Insert(index, ValidateValue(value));

        void IList.Remove(object value) => Remove(ValidateValue(value));

        void ICollection.CopyTo(Array array, int index)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.GreaterThanOrEquals(index, nameof(index), 0);
            Preconditions.LessThanOrEquals(index + Count, $"{nameof(index)} + {nameof(Count)}", array.Length, $"{nameof(array)}.{nameof(array.Length)}");

            for (var i = 0; i < _list.Count; ++i)
            {
                array.SetValue(this[i], index + i);
            }
        }

        private T ValidateValue(object value) => value is T tValue ? tValue : throw new ArgumentException($"must be of type {TypeData<T>.Type.Name}", nameof(value));
    }

    internal sealed class DirtyListConverter<T> : JsonConverter
    {
        private static readonly bool s_serializeWholeList = TypeData<T>.TypeInfo.GetCustomAttribute<EntityAttribute>(false)?.SerializeWholeListWhenDirty == true;

        public override bool CanConvert(Type objectType) => objectType == TypeData<DirtyList<T>>.Type;

        public override bool CanRead => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotSupportedException();

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => serializer.Serialize(writer, (s_serializeWholeList ? ((DirtyList<T>)value)._list : ((DirtyList<T>)value)._list.Where(item => item.Dirty)).Select(item => (T)item));
    }
}