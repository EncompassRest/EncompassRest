namespace EncompassRest
{
    /// <summary>
    /// Value wrapper useful for updates in dictionaries with immutable values
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal sealed class WrapperObject<T>
    {
        public static implicit operator T(WrapperObject<T> wrapperObject) => wrapperObject.Value;

        public static implicit operator WrapperObject<T>(T value) => new WrapperObject<T> { Value = value };

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public T Value { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    }
}