using System;
using System.Collections.Generic;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// ContactData
    /// </summary>
    public sealed class ContactData : ExtensibleObject
    {
        private Dictionary<string, string> _fields;

        /// <summary>
        /// ContactData Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ContactData Fields
        /// </summary>
        public Dictionary<string, string> Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string>(value, StringComparer.OrdinalIgnoreCase);
        }
    }
}