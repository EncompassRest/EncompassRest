using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public abstract class Contact : ExtensibleObject, IIdentifiable
    {
        internal abstract string ApiPath { get; }

        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public ContactNotes Notes { get; private set; }

        internal Contact(EncompassRestClient client, string contactId)
        {
            Initialize(client, contactId);
        }
        
        internal Contact()
        {
        }

        public void Initialize(EncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            if (!ReferenceEquals(Client, client))
            {
                Client = client;
                Id = contactId;
                Notes = new ContactNotes(client, Id, ApiPath);
            }
        }

        private DirtyValue<string> _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<string> _ownerId;
        public string OwnerId { get => _ownerId; set => _ownerId = value; }
        private DirtyValue<ContactAccessLevel?> _accessLevel;
        [EnumFormat(EnumFormat.DecimalValue)]
        public ContactAccessLevel? AccessLevel { get => _accessLevel; set => _accessLevel = value; }
        private ContactAddress _currentMailingAddress;
        public ContactAddress CurrentMailingAddress { get => _currentMailingAddress ?? (_currentMailingAddress = new ContactAddress()); set => _currentMailingAddress = value; }
        private DirtyValue<string> _businessWebUrl;
        public string BusinessWebUrl { get => _businessWebUrl; set => _businessWebUrl = value; }
        private DirtyValue<string> _jobTitle;
        public string JobTitle { get => _jobTitle; set => _jobTitle = value; }
        private DirtyValue<string> _workPhone;
        public string WorkPhone { get => _workPhone; set => _workPhone = value; }
        private DirtyValue<string> _homePhone;
        public string HomePhone { get => _homePhone; set => _homePhone = value; }
        private DirtyValue<string> _mobilePhone;
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        private DirtyValue<string> _faxNumber;
        public string FaxNumber { get => _faxNumber; set => _faxNumber = value; }
        private DirtyValue<string> _personalEmail;
        public string PersonalEmail { get => _personalEmail; set => _personalEmail = value; }
        private DirtyValue<string> _businessEmail;
        public string BusinessEmail { get => _businessEmail; set => _businessEmail = value; }
        private DirtyValue<string> _salutation;
        public string Salutation { get => _salutation; set => _salutation = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
    }
}
