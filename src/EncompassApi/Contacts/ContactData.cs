using System;
using System.Collections.Generic;

namespace EncompassApi.Contacts
{
    /// <summary>
    /// ContactData
    /// </summary>
    public sealed class ContactData : ExtensibleObject
    {
        private Dictionary<string, string?>? _fields;

        /// <summary>
        /// ContactData Id
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public string Id { get; set; }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        /// <summary>
        /// ContactData Fields
        /// </summary>
        public Dictionary<string, string?>? Fields
        {
            get => _fields;
            set => _fields = value?.Comparer == StringComparer.OrdinalIgnoreCase ? value : new Dictionary<string, string?>(value, StringComparer.OrdinalIgnoreCase);
        }
    }
}