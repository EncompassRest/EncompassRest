namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Notes Apis exposed as extension methods from the EncompassRest.Contacts.v1 package
    /// within the EncompassRest.Contacts.v1 namespace.
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