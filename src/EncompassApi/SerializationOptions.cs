using System;

namespace EncompassApi
{
    /// <summary>
    /// SerializationOptions
    /// </summary>
    [Flags]
    public enum SerializationOptions
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Indent the output
        /// </summary>
        Indent = 1,
        /// <summary>
        /// Serialize only the dirty elements
        /// </summary>
        Dirty = 2,
        /// <summary>
        /// Indent and serialize only the dirty elements
        /// </summary>
        IndentAndDirty = 3
    }
}