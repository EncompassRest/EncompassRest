using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using EncompassRest.Filters;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// ContactListParameters
    /// </summary>
    public sealed class ContactListParameters : SerializableObject
    {
        private ReadOnlyCollection<string> _fields;
        private ReadOnlyCollection<FieldSort> _sortOrder;

        /// <summary>
        /// Contacts filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }

        /// <summary>
        /// Canonical field names to include.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Fields
        {
            get => _fields;
            set => _fields = value != null ? new ReadOnlyCollection<string>(value.ToList()) : null;
        }

        /// <summary>
        /// Specifies how the results should be ordered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldSort> SortOrder
        {
            get => _sortOrder;
            set => _sortOrder = value != null ? new ReadOnlyCollection<FieldSort>(value.ToList()) : null;
        }

        /// <summary>
        /// Type of loans to query.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ContactLoanMatchType> LoanMatchType { get; set; }

        /// <summary>
        /// ContactListParameters constructor.
        /// </summary>
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