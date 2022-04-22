namespace EncompassRest
{
    /// <summary>
    /// Interface for defining if a value is considered dirty or changed.
    /// </summary>
    public interface IDirty
    {
        /// <summary>
        /// Gets or sets if a value is considered dirty or changed.
        /// </summary>
        bool Dirty { get; set; }
    }
}