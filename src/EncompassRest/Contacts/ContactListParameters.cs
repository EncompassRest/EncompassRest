using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    public sealed class ContactListParameters : SerializableObject
    {
        public IEnumerable<string> Fields { get; }

        public ContactListParameters(IEnumerable<string> fields)
        {
            Preconditions.NotNull(fields, nameof(fields));

            Fields = new ReadOnlyCollection<string>(fields.ToList());
        }
    }
}