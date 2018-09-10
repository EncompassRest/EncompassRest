using EncompassRest.Utilities;

namespace EncompassRest
{
    public static class Extensions
    {
        public static T Clone<T>(this T value)
            where T : DirtyExtensibleObject
        {
            Preconditions.NotNull(value, nameof(value));

            return JsonHelper.DefaultPublicSerializer.Clone(value);
        }
    }
}