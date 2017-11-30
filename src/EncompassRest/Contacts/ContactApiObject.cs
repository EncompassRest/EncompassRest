namespace EncompassRest.Contacts
{
    public abstract class ContactApiObject : ApiObject
    {
        public string ContactId { get; }

        internal ContactApiObject(EncompassRestClient client, string contactId, string baseApiPath)
            : base(client, baseApiPath)
        {
            ContactId = contactId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{ContactId}{(string.IsNullOrEmpty(resourceId) ? string.Empty : $"/{resourceId}")}");
    }
}