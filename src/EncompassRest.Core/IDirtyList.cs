namespace EncompassRest
{
    /// <summary>
    /// Interface to support getting and setting a list's elements dirtiness.
    /// </summary>
    public interface IDirtyList : IDirty
    {
        /// <summary>
        /// Indicates if the element at <paramref name="index"/> is dirty or changed.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <returns></returns>
        bool IsElementDirty(int index);
        /// <summary>
        /// Sets the element at <paramref name="index"/>'s dirtiness value.
        /// </summary>
        /// <param name="index">The element index.</param>
        /// <param name="value">The dirtiness value.</param>
        void SetElementDirty(int index, bool value);
    }
}