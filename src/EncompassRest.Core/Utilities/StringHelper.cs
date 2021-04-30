namespace EncompassRest.Utilities
{
    internal static class StringHelper
    {
        public static string PrecedeWith(this string value, string precedingText) => string.IsNullOrEmpty(value) || value.StartsWith(precedingText) ? value : precedingText + value;
    }
}