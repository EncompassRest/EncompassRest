using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public enum BusinessContactCategory
    {
        Appraiser = 0,
        Attourney = 1,
        Credit_Company = 2,
        Doc_Signing = 3,
        Escrow_Company = 4,
        Flood_Insurance = 5,
        Hazard_Insurance = 6,
        Lender = 7,
        Mortgage_Insurance = 8,
        Real_Estate_Agent = 9,
        Servicing = 10,
        Title_Insurance = 11,
        Underwriter = 12,
        Surveyor = 13,
        No_Category = 14,
        Organization = 15,
        Verification = 16,
        Investor = 17,
        Warehouse_Bank = 18,
        Builder = 19,
        Dealer = 20,
        TradeAssignee = 21
    }

    public sealed class BusinessContact : Contact,IDirty
    {
        private static string s_apiPath = "encompass/v1/BusinessContacts";
        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public ContactNotes Notes { get; private set; }

        public BusinessContact(EncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            Id = contactId;
            Initialize(client);
        }

        [JsonConstructor]
        public BusinessContact()
        {

        }

        internal void Initialize(EncompassRestClient client)
        {
            Client = client;
            Notes = new ContactNotes(client, s_apiPath, Id);
        }

        private DirtyValue<BusinessContactCategory> _categoryId;
        [EnumOutput(EnumOutput.Integer)]
        public BusinessContactCategory CategoryId { get { return _categoryId; } set { _categoryId = value; } }
        private DirtyValue<string> _companyName;
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }
        private BusinessContactLicense _personalContactLicense;
        public BusinessContactLicense PersonalContactLicense { get { return _personalContactLicense ?? new BusinessContactLicense(); } set { _personalContactLicense = value; } }
        private BusinessContactLicense _businessContactLicesnse;
        public BusinessContactLicense BusinessContactLicense { get { return _businessContactLicesnse ?? new BusinessContactLicense(); } set { _businessContactLicesnse = value; } }
        private DirtyValue<bool?> _noSpam;
        public bool? NoSpam { get { return _noSpam; } set { _noSpam = value; } }
        private DirtyValue<string> _fees;
        public string Fees { get { return Fees; } set { _fees = value; } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal new bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = base.Dirty
                    || _categoryId.Dirty
                    || _companyName.Dirty
                    || _personalContactLicense?.Dirty == true
                    || _businessContactLicesnse?.Dirty == true
                    || _noSpam.Dirty
                    || _fees.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                base.Dirty = value;
                _categoryId.Dirty = value;
                _companyName.Dirty = value;
                if (_personalContactLicense!= null) _personalContactLicense.Dirty = value;
                if (_businessContactLicesnse!= null) _businessContactLicesnse.Dirty = value;
                _noSpam.Dirty = value;
                _fees.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
