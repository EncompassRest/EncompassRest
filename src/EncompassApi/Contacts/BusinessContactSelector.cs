namespace EncompassApi.Contacts
{
    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public interface IBusinessContactSelector : IContactSelector
    {
    }

    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public sealed class BusinessContactSelector : ContactSelector, IBusinessContactSelector
    {
        internal BusinessContactSelector(IEncompassApiClient client)
            : base(client, "encompass/v1/businessContactSelector")
        {
        }
    }
}