using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public abstract class Contact : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _firstName;
        private DirtyValue<string> _lastName;
        private DirtyValue<string> _ownerId;
        private DirtyValue<ContactAccessLevel?> _accessLevel;
        private ContactAddress _currentMailingAddress;
        private DirtyValue<string> _businessWebUrl;
        private DirtyValue<string> _jobTitle;
        private DirtyValue<string> _workPhone;
        private DirtyValue<string> _homePhone;
        private DirtyValue<string> _mobilePhone;
        private DirtyValue<string> _faxNumber;
        private DirtyValue<string> _personalEmail;
        private DirtyValue<string> _businessEmail;
        private DirtyValue<string> _salutation;
        private DirtyValue<string> _id;

        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }

        public string OwnerId { get => _ownerId; set => SetField(ref _ownerId, value); }

        [EnumFormat(EnumFormat.DecimalValue)]
        public ContactAccessLevel? AccessLevel { get => _accessLevel; set => SetField(ref _accessLevel, value); }

        public ContactAddress CurrentMailingAddress { get => GetField(ref _currentMailingAddress); set => SetField(ref _currentMailingAddress, value); }

        public string BusinessWebUrl { get => _businessWebUrl; set => SetField(ref _businessWebUrl, value); }

        public string JobTitle { get => _jobTitle; set => SetField(ref _jobTitle, value); }

        public string WorkPhone { get => _workPhone; set => SetField(ref _workPhone, value); }

        public string HomePhone { get => _homePhone; set => SetField(ref _homePhone, value); }

        public string MobilePhone { get => _mobilePhone; set => SetField(ref _mobilePhone, value); }

        public string FaxNumber { get => _faxNumber; set => SetField(ref _faxNumber, value); }

        public string PersonalEmail { get => _personalEmail; set => SetField(ref _personalEmail, value); }

        public string BusinessEmail { get => _businessEmail; set => SetField(ref _businessEmail, value); }

        public string Salutation { get => _salutation; set => SetField(ref _salutation, value); }

        public string Id { get => _id; set => SetField(ref _id, value); }

        internal abstract string ApiPath { get; }

        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public ContactNotes Notes { get; private set; }

        internal Contact(EncompassRestClient client, string contactId, string firstName, string personalEmail)
            : this(firstName, personalEmail)
        {
            Initialize(client, contactId);
        }

        internal Contact(string firstName, string personalEmail)
        {
            Preconditions.NotNullOrEmpty(firstName, nameof(firstName));
            Preconditions.NotNullOrEmpty(personalEmail, nameof(personalEmail));

            FirstName = firstName;
            PersonalEmail = personalEmail;
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
    }
}