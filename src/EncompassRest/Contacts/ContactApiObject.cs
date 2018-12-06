using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Base Contact Api Class.
    /// </summary>
    public abstract class ContactApiObject : ApiObject
    {
        /// <summary>
        /// The contact id associated with the Api.
        /// </summary>
        public string ContactId { get; }

        internal ContactApiObject(EncompassRestClient client, string contactId, string baseApiPath)
            : base(client, baseApiPath)
        {
            ContactId = contactId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{ContactId}{resourceId?.PrecedeWith("/")}");
    }
}