using System.Threading;

namespace EncompassRest.Settings.Loan
{
    /// <summary>
    /// The Loan Settings Apis.
    /// </summary>
    public interface ILoanSettings : IApiObject
    {
        /// <summary>
        /// The Loan Custom Fields Apis.
        /// </summary>
        ICustomFieldDefinitions CustomFields { get; }
    }

    internal sealed class LoanSettings : ApiObject, ILoanSettings
    {
        private CustomFieldDefinitions? _customFields;

        public ICustomFieldDefinitions CustomFields
        {
            get
            {
                var customFields = _customFields;
                return customFields ?? Interlocked.CompareExchange(ref _customFields, (customFields = new CustomFieldDefinitions(Client)), null) ?? customFields;
            }
        }

        internal LoanSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan")
        {
        }
    }
}