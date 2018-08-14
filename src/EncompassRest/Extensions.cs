using System;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public static class Extensions
    {
        public static T Clone<T>(this T value)
            where T : ExtensibleObject
        {
            Preconditions.NotNull(value, nameof(value));

            return JsonHelper.DefaultPublicSerializer.Clone(value);
        }

        public static T GetById<T>(this IList<T> list, string id)
            where T : ExtensibleObject
        {
            Preconditions.NotNull(list, nameof(list));
            Preconditions.NotNullOrEmpty(id, nameof(id));

            if (list is DirtyList<T> dirtyList)
            {
                return dirtyList.GetById(id);
            }
            return list.FirstOrDefault(v => string.Equals(((IIdentifiable)v)?.Id, id, StringComparison.OrdinalIgnoreCase));
        }
    }
}