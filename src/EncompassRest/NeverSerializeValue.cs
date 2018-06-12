namespace EncompassRest
{
    internal sealed class NeverSerializeValue<T> : IDirty
    {
        public static implicit operator T(NeverSerializeValue<T> value) => value._value;

        public static implicit operator NeverSerializeValue<T>(T value) => new NeverSerializeValue<T>(value);

        internal readonly T _value;

        public bool Dirty { get => false; set { } }

        public NeverSerializeValue(T value)
        {
            _value = value;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
}