using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Value wrapper to use for dirty checking.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal struct Value<T> : IDirty
    {
        public static implicit operator T(Value<T> value) => value._value;

        public static implicit operator Value<T>(T value) => new Value<T>(value);

        private static readonly bool s_tImplementsIDirty = TypeData<T>.Data.TypeInfo.ImplementedInterfaces.Any(implInterface => implInterface == TypeData<IDirty>.Type);

        private readonly T _value;
        private bool _dirty;

        public bool Dirty
        {
            get
            {
                return s_tImplementsIDirty ? ((IDirty)_value).Dirty : _dirty;
            }
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

        public Value(T value)
        {
            _value = value;
            _dirty = true;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
}