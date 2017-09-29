﻿using System;
using System.Collections;
using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    [JsonConverter(typeof(DirtyListConverter<>))]
    internal sealed class DirtyList<T> : IList<T>, IDirty
    {
        internal readonly List<Value<T>> _list;
        private bool _dirty;

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _dirty = true;
                _list[index] = value;
            }
        }

        public bool Dirty
        {
            get
            {
                var dirty = _dirty;
                if (!dirty)
                {
                    foreach (var item in _list)
                    {
                        if (item.Dirty)
                        {
                            dirty = true;
                            break;
                        }
                    }
                }
                return dirty;
            }
            set
            {
                _dirty = value;
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
            _list = new List<Value<T>>();
        }

        public DirtyList(IEnumerable<T> list)
            : this()
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            _dirty = true;
            _list.Add(item);
        }

        public void Clear()
        {
            _dirty = true;
            _list.Clear();
        }

        public bool Contains(T item) => IndexOf(item) >= 0;

        public void CopyTo(T[] array, int arrayIndex)
        {
            Preconditions.NotNull(array, nameof(array));
            Preconditions.LessThan(arrayIndex, nameof(arrayIndex), array.Length);
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
            _dirty = true;
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

        public void RemoveAt(int index)
        {
            _dirty = true;
            _list.RemoveAt(index);
        }

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

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dirtyList = (DirtyList<T>)value;
            var listToSerialize = new List<T>();
            foreach (var item in dirtyList._list)
            {
                if (item.Dirty)
                {
                    listToSerialize.Add(item);
                }
            }
            serializer.Serialize(writer, listToSerialize);
        }
    }
}