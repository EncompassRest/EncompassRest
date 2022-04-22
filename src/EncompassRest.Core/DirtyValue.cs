﻿using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Value wrapper to use for dirty checking.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal sealed class DirtyValue<T> : IDirty, IValue
    {
        public static implicit operator T(DirtyValue<T>? value) => value != null ? value._value! : default!;

        public static implicit operator DirtyValue<T>(T value) => new DirtyValue<T>(value);

        private static readonly bool s_tImplementsIDirty = TypeData<T>.Data.Type.GetInterfaces().Any(implInterface => implInterface == TypeData<IDirty>.Type);

        internal readonly T _value;
        private bool _dirty;

        public bool Dirty
        {
            get => s_tImplementsIDirty && _value != null ? ((IDirty)_value).Dirty : _dirty;
            set
            {
                if (s_tImplementsIDirty && _value != null)
                {
                    ((IDirty)_value).Dirty = value;
                }
                else
                {
                    _dirty = value;
                }
            }
        }

        object? IValue.Value => _value;

        public DirtyValue(T value)
        {
            _value = value;
            _dirty = true;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string? ToString() => _value?.ToString();
    }
}