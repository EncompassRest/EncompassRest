using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class BusinessContact : Contact
    {
        internal override string ApiPath => "encompass/v1/businessContacts";

        private DirtyValue<BusinessContactCategory?> _categoryId;
        [EnumFormat(EnumFormat.DecimalValue)]
        public BusinessContactCategory? CategoryId { get => _categoryId; set => SetField(ref _categoryId, value); }
        private DirtyValue<string> _companyName;
        public string CompanyName { get => _companyName; set => SetField(ref _companyName, value); }
        private BusinessContactLicense _personalContactLicense;
        public BusinessContactLicense PersonalContactLicense { get => GetField(ref _personalContactLicense); set => SetField(ref _personalContactLicense, value); }
        private BusinessContactLicense _businessContactLicense;
        public BusinessContactLicense BusinessContactLicense { get => GetField(ref _businessContactLicense); set => SetField(ref _businessContactLicense, value); }
        private DirtyValue<bool?> _noSpam;
        public bool? NoSpam { get => _noSpam; set => SetField(ref _noSpam, value); }
        private DirtyValue<int?> _fees;
        public int? Fees { get => Fees; set => SetField(ref _fees, value); }

        /// <summary>
        /// BusinessContact creation constructor
        /// </summary>
        [JsonConstructor]
        public BusinessContact()
        {
        }

        /// <summary>
        /// BusinessContact update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="contactId"></param>
        public BusinessContact(EncompassRestClient client, string contactId)
            : base(client, contactId)
        {
        }
    }
}