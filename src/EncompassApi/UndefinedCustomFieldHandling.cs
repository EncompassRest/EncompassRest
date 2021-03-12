namespace EncompassApi
{
    /// <summary>
    /// Specifies how the client should handle undefined custom fields.
    /// </summary>
    public enum UndefinedCustomFieldHandling
    {
        /// <summary>
        /// Default (Allow it)
        /// </summary>
        Default = 0,
        /// <summary>
        /// Error only if custom fields definitions have been retrieved
        /// </summary>
        ErrorIfCustomFieldsInitialized = 1,
        /// <summary>
        /// Always Error
        /// </summary>
        Error = 2
    }
}