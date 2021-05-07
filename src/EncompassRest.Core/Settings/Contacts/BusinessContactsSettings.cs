namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Business Contacts Settings Apis exposed as extension methods from the EncompassRest.Contacts package
    /// within the EncompassRest.Settings.Contacts.v1 namespace.
    /// </summary>
    public interface IBusinessContactsSettings : IApiObject
    {
    }

    internal sealed class BusinessContactsSettings : ApiObject, IBusinessContactsSettings
    {
        internal BusinessContactsSettings(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}