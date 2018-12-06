using System.Threading;

namespace EncompassRest.Settings.Loan
{
    /// <summary>
    /// The Loan Settings Apis.
    /// </summary>
    public sealed class LoanSettings : ApiObject
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

        internal LoanSettings(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan")
        {
        }
    }
}