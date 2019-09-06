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

    /// <summary>
    /// The Loan Settings Apis.
    /// </summary>
    public sealed class LoanSettings : ApiObject, ILoanSettings
    {
        private CustomFieldDefinitions _customFields;

        /// <summary>
        /// The Loan Custom Fields Apis.
        /// </summary>
        public CustomFieldDefinitions CustomFields
        {
            get
            {
                var customFields = _customFields;
                return customFields ?? Interlocked.CompareExchange(ref _customFields, (customFields = new CustomFieldDefinitions(Client)), null) ?? customFields;
            }
        }

        ICustomFieldDefinitions ILoanSettings.CustomFields => CustomFields;

        internal LoanSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan")
        {
        }
    }
}