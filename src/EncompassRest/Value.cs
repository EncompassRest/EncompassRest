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

        private readonly T _value;

        public bool Dirty { get; set; }

        public Value(T value)
        {
            _value = value;
            Dirty = true;
        }

        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value?.ToString();
    }
}