namespace EncompassRest
{
    /// <summary>
    /// Interface to support getting and setting properties dirtiness.
    /// </summary>
    public interface IDirtyObject : IDirty
    {
        /// <summary>
        /// Indicates if the <paramref name="propertyName"/> is dirty or changed.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <returns></returns>
        bool IsPropertyDirty(string propertyName);
        /// <summary>
        /// Sets the <paramref name="propertyName"/>'s dirtiness value.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <param name="value">The dirtiness value.</param>
        /// <returns>Indicates if setting the properties dirtiness value succeeded.</returns>
        bool SetPropertyDirty(string propertyName, bool value);
    }
}