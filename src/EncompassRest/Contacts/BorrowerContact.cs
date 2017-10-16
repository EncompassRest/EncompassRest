using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact,IDirty
    {
        private static string s_apiPath = "encompass/v1/BorrowerContacts";
        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public ContactNotes Notes { get; private set; }

        public BorrowerContact(EncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            Id = contactId;
            Initialize(client);
        }

        [JsonConstructor]
        public BorrowerContact()
        {

        }

        internal void Initialize(EncompassRestClient client)
        {
            Client = client;
            Notes = new ContactNotes(client,s_apiPath, Id);
        }

        private DirtyValue<string> _employerName;
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        private DirtyValue<string> _birthdate;
        public string Birthdate { get { return _birthdate; } set { _birthdate = value; } }
        private DirtyValue<string> _refferal;
        public string Referral { get { return _refferal; } set { _refferal = value; } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal new bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = base.Dirty
                    || _employerName.Dirty
                    || _birthdate.Dirty
                    || _refferal.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                base.Dirty = value;
                _employerName.Dirty = value;
                _birthdate.Dirty = value;
                _refferal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
