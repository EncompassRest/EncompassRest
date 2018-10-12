using System;
using System.Collections.Generic;
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

        public static T GetById<T>(this IList<T> list, string id)
            where T : DirtyExtensibleObject
        {
            var index = list.IndexOf(id);
            return index >= 0 ? list[index] : default;
        }

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
    }
}