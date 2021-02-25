using System;
using System.Collections.Generic;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi
{
    /// <summary>
    /// General Extensions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Clones the object.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="value">The object to clone.</param>
        /// <returns></returns>
        public static T Clone<T>(this T value)
            where T : DirtyExtensibleObject
        {
            Preconditions.NotNull(value, nameof(value));

            return JsonHelper.DefaultPublicSerializer.Clone(value);
        }

        /// <summary>
        /// Gets the item with the specified id or else returns <c>null</c>.
        /// </summary>
        /// <typeparam name="T">The list's element type.</typeparam>
        /// <param name="list">The list to search.</param>
        /// <param name="id">The id to search for.</param>
        /// <returns></returns>
        public static T? GetById<T>(this IList<T> list, string id)
            where T : DirtyExtensibleObject
        {
            var index = list.IndexOf(id);
            return index >= 0 ? list[index] : default;
        }

        /// <summary>
        /// Gets the index of the item with the specified id or else returns -1.
        /// </summary>
        /// <typeparam name="T">The list's element type.</typeparam>
        /// <param name="list">The list to search.</param>
        /// <param name="id">The id to search for.</param>
        /// <returns></returns>
        public static int IndexOf<T>(this IList<T> list, string id)
            where T : DirtyExtensibleObject => IndexOf((IEnumerable<DirtyExtensibleObject>)list, id);

        internal static int IndexOf(IEnumerable<DirtyExtensibleObject> list, string id)
        {
            Preconditions.NotNull(list, nameof(list));
            Preconditions.NotNullOrEmpty(id, nameof(id));

            if (list is IIndexOfId indexOfId)
            {
                return indexOfId.IndexOf(id);
            }
            var index = 0;
            foreach (var item in list)
            {
                if (string.Equals(((IIdentifiable)item)?.Id, id, StringComparison.OrdinalIgnoreCase))
                {
                    return index;
                }
                ++index;
            }
            return -1;
        }

        internal static string? GetValue<TEnum>(this TEnum value) where TEnum : struct, Enum => value.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
    }
}