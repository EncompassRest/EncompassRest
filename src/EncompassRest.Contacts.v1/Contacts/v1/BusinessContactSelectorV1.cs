namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Business Contact Selector Apis.
    /// </summary>
    public interface IBusinessContactSelectorV1 : IContactSelectorV1
    {
    }

    internal sealed class BusinessContactSelectorV1 : ContactSelectorV1, IBusinessContactSelectorV1
    {
        internal BusinessContactSelectorV1(EncompassRestClient client)
            : base(client, "encompass/v1/businessContactSelector")
        {
        }
    }
}