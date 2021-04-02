using System;

namespace EncompassApi
{
    internal sealed class EntityAttribute : Attribute
    {
        public string? PropertiesToAlwaysSerialize { get; set; }

        public bool SerializeWholeListWhenDirty { get; set; }
    }
}