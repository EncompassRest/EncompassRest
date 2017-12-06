namespace EncompassRest.Utilities
{
    internal static class StringHelper
    {
        public static string PrecedeWith(this string value, string precedingText) => value?.StartsWith(precedingText) != false ? value : precedingText + value;
    }
}