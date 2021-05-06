namespace EncompassRest.Settings.Contacts
{
    /// <summary>
    /// The Business Contacts Settings Apis.
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