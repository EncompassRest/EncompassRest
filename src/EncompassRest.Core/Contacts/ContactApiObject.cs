using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Base Contact Api Interface.
    /// </summary>
    public interface IContactApiObject : IApiObject
    {
        /// <summary>
        /// The contact id associated with the Api.
        /// </summary>
        string ContactId { get; }
    }

    internal abstract class ContactApiObject : ApiObject, IContactApiObject
    {
        public string ContactId { get; }

        internal ContactApiObject(EncompassRestClient client, string contactId, string baseApiPath)
            : base(client, baseApiPath)
        {
            ContactId = contactId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{ContactId}{resourceId?.PrecedeWith("/")}");
    }
}