namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Notes Apis.
    /// </summary>
    public interface IContactNotes : IContactApiObject
    {
    }

    internal sealed class ContactNotes : ContactApiObject, IContactNotes
    {
        internal ContactNotes(EncompassRestClient client, ContactType type, string contactId)
            : base(client, type, contactId, null)
        {
        }
    }
}