namespace EncompassRest.Settings.Loan
{
    /// <summary>
    /// The Loan Custom Fields Apis.
    /// </summary>
    public interface ICustomFieldDefinitions : IApiObject
    {
    }

    internal sealed class CustomFieldDefinitions : ApiObject, ICustomFieldDefinitions
    {
        internal CustomFieldDefinitions(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}