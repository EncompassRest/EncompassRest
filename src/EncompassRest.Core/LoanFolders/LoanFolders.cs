namespace EncompassRest.LoanFolders
{
    /// <summary>
    /// The Loan Folders Apis.
    /// </summary>
    public interface ILoanFolders : IApiObject
    {
    }

    internal sealed class LoanFolders : ApiObject, ILoanFolders
    {
        internal LoanFolders(EncompassRestClient client)
            : base(client, null)
        {
        }
    }
}