using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using EncompassRest.Filters;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class ContactListParameters : SerializableObject
    {
        private ReadOnlyCollection<string> _fields;
        private ReadOnlyCollection<FieldSort> _sortOrder;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Fields
        {
            get => _fields;
            set => _fields = value != null ? new ReadOnlyCollection<string>(value.ToList()) : null;
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldSort> SortOrder
        {
            get => _sortOrder;
            set => _sortOrder = value != null ? new ReadOnlyCollection<FieldSort>(value.ToList()) : null;
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ContactLoanMatchType> LoanMatchType { get; set; }

        [JsonConstructor]
        public ContactListParameters()
        {
        }

        [Obsolete("Use another constructor and explicitly set the Fields property in the initializer instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ContactListParameters(IEnumerable<string> fields)
        {
            Fields = fields;
        }
    }
}