using System;
using System.Collections.Generic;

namespace EncompassRest.Contacts
{
    public sealed class ContactData : ExtensibleObject
    {
        private Dictionary<string, string> _fields;

        public string Id { get; set; }

        public Dictionary<string, string> Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string>(value, StringComparer.OrdinalIgnoreCase);
        }
    }
}
