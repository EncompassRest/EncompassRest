using EncompassRest.Utilities;

namespace EncompassRest
{
    public enum CacheInitialization
    {
        Never = 0,
        IfNotAlready = int.MaxValue,
        Always = -1
    }

    public static class CacheInitializationExtensions
    {
        public static CacheInitialization CreateFromMinutesUntilStale(int minutesUntilStale)
        {
            Preconditions.GreaterThan(minutesUntilStale, nameof(minutesUntilStale), 0);

            return (CacheInitialization)minutesUntilStale;
        }
    }
}