using System;

namespace EncompassRest
{
    internal sealed class EntityAttribute : Attribute
    {
        public string PropertiesToAlwaysSerialize { get; set; }

        public bool SerializeWholeListWhenDirty { get; set; }
    }
}