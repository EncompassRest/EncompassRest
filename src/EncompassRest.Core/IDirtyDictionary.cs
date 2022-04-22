namespace EncompassRest
{
    /// <summary>
    /// Interface to support getting and setting a dictionary's values dirtiness.
    /// </summary>
    /// <typeparam name="TKey">The key type.</typeparam>
    public interface IDirtyDictionary<TKey> : IDirty
    {
        /// <summary>
        /// Indicates if the value associated with <paramref name="key"/> is dirty or changed.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        bool IsValueDirty(TKey key);
        /// <summary>
        /// Indicates if the value associated with <paramref name="key"/> is dirty or changed.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The dirtiness value.</param>
        bool SetValueDirty(TKey key, bool value);
    }
}