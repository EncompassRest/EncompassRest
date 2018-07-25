using System.Collections.Generic;

namespace EncompassRest.Contacts
{
    public sealed class ContactCursor : Cursor<ContactData>
    {
        internal ContactCursor(ApiObject apiObject, EncompassRestClient client, string cursorId, int count, IEnumerable<string> fields)
            : base(apiObject, client, cursorId, count, fields)
        {
        }
    }
}