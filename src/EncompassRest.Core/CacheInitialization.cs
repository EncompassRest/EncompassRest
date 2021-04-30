using EncompassRest.Utilities;

namespace EncompassRest
{
    /// <summary>
    /// Specifies when the cache should be initialized.
    /// </summary>
    public enum CacheInitialization
    {
        /// <summary>
        /// Never initialize the cache initially.
        /// </summary>
        Never = 0,
        /// <summary>
        /// Initialize the cache if it's never been initialized.
        /// </summary>
        IfNotAlready = int.MaxValue,
        /// <summary>
        /// Always initialize the cache.
        /// </summary>
        Always = -1
    }

    /// <summary>
    /// Extensions to create cache initialization values based on a stale criteria.
    /// </summary>
    public static class CacheInitializationExtensions
    {
        /// <summary>
        /// Creates a cache initialization value based on the specified stale criteria.
        /// </summary>
        /// <param name="minutesUntilStale">Number of minutes until the cache is considered stale.</param>
        /// <returns></returns>
        public static CacheInitialization CreateFromMinutesUntilStale(int minutesUntilStale)
        {
            Preconditions.GreaterThan(minutesUntilStale, nameof(minutesUntilStale), 0);

            return (CacheInitialization)minutesUntilStale;
        }
    }
}