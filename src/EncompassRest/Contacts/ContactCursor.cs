using System.Collections.Generic;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Contact cursor.
    /// </summary>
    public sealed class ContactCursor : Cursor<ContactData>
    {
        internal ContactCursor(ApiObject apiObject, EncompassRestClient client, string cursorId, int count, IEnumerable<string> fields)
            : base(apiObject, client, cursorId, count, fields)
        {
        }
    }
}