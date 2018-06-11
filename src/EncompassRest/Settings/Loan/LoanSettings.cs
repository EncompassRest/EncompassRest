using System.Threading;

namespace EncompassRest.Settings.Loan
{
    public sealed class LoanSettings : ApiObject
    {
        private CustomFieldDefinitions _customFields;

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