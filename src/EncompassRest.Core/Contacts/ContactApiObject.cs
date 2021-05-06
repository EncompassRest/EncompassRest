using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Base Contact Api Interface.
    /// </summary>
    public interface IContactApiObject : IApiObject
    {
        /// <summary>
        /// The contact type.
        /// </summary>
        ContactType Type { get; }

        /// <summary>
        /// The contact id associated with the Api.
        /// </summary>
        string ContactId { get; }
    }

    internal abstract class ContactApiObject : ApiObject, IContactApiObject
    {
        public ContactType Type { get; }

        public string ContactId { get; }

        internal ContactApiObject(EncompassRestClient client, ContactType type, string contactId, string? baseApiPath)
            : base(client, baseApiPath)
        {
            Type = type;
            ContactId = contactId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{ContactId}{resourceId?.PrecedeWith("/")}");
    }
}