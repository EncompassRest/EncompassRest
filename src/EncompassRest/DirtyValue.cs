using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Value wrapper to use for dirty checking.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal struct DirtyValue<T> : IDirty
    {
        public static implicit operator T(DirtyValue<T> value) => value._value;

        public static implicit operator DirtyValue<T>(T value) => new DirtyValue<T>(value);

        private static readonly bool s_tImplementsIDirty = TypeData<T>.Data.TypeInfo.ImplementedInterfaces.Any(implInterface => implInterface == TypeData<IDirty>.Type);

        internal readonly T _value;
        private bool _dirty;

        public bool Dirty
        {
            get => s_tImplementsIDirty ? ((IDirty)_value).Dirty : _dirty;
            set
            {
                if (s_tImplementsIDirty)
                {
                    ((IDirty)_value).Dirty = value;
                }
                else
                {
                    _dirty = value;
                }
            }
        }

        public DirtyValue(T value)
        {
            _value = value;
            _dirty = true;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
}