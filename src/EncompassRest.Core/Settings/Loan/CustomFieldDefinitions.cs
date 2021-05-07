namespace EncompassRest.Settings.Loan
{
    /// <summary>
    /// The Loan Custom Fields Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Settings.Loan.v1 namespace.
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