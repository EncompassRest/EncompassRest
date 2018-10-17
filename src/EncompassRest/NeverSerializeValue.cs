namespace EncompassRest
{
    internal sealed class NeverSerializeValue<T> : IDirty, IValue
    {
        public static implicit operator T(NeverSerializeValue<T> value) => value != null ? value._value : default;

        public static implicit operator NeverSerializeValue<T>(T value) => value != null ? new NeverSerializeValue<T>(value) : default;

        internal readonly T _value;

        public bool Dirty { get => false; set { } }

        object IValue.Value => _value;

        public NeverSerializeValue(T value)
        {
            _value = value;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
}