using System.Collections.Generic;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// Contact cursor.
    /// </summary>
    public interface IContactCursor : ICursor<ContactData>
    {
    }

    internal sealed class ContactCursor : Cursor<ContactData>, IContactCursor
    {
        internal ContactCursor(ApiObject apiObject, EncompassRestClient client, string? cursorId, int count, IEnumerable<string>? fields)
            : base(apiObject, client, cursorId, count, fields)
        {
        }
    }
}