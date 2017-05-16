namespace EncompassRest.Utilities
{
    internal static class StringExtensions
    {
        public static string Unquote(this string value) => value.Substring(1, value.Length - 2);
    }
}