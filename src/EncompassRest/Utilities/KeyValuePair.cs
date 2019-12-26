#if !KEYVALUEPAIR_CREATE
namespace System.Collections.Generic
{
    internal static class KeyValuePair
    {
        public static KeyValuePair<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value) => new KeyValuePair<TKey, TValue>(key, value);
    }
}
#endif