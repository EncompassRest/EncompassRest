using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Contact
    /// </summary>
    public abstract class Contact : DirtyExtensibleObject, IIdentifiable
    {
        private ContactNotes _notes;

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
        private DirtyList<int?> _groupIDs;

        /// <summary>
        /// The contact's first name.
        /// </summary>
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// The contact's last name.
        /// </summary>
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// User ID of the user who submitted the API request.
        /// </summary>
        public string OwnerId { get => _ownerId; set => SetField(ref _ownerId, value); }

        /// <summary>
        /// Contact AccessLevel
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public ContactAccessLevel? AccessLevel { get => _accessLevel; set => SetField(ref _accessLevel, value); }

        /// <summary>
        /// The contact's home address.
        /// </summary>
        public ContactAddress CurrentMailingAddress { get => GetField(ref _currentMailingAddress); set => SetField(ref _currentMailingAddress, value); }

        /// <summary>
        /// Website address for the business.
        /// </summary>
        public string BusinessWebUrl { get => _businessWebUrl; set => SetField(ref _businessWebUrl, value); }

        /// <summary>
        /// The contact's job title.
        /// </summary>
        public string JobTitle { get => _jobTitle; set => SetField(ref _jobTitle, value); }

        /// <summary>
        /// The contact's work phone number.
        /// </summary>
        public string WorkPhone { get => _workPhone; set => SetField(ref _workPhone, value); }

        /// <summary>
        /// The contact's home phone number.
        /// </summary>
        public string HomePhone { get => _homePhone; set => SetField(ref _homePhone, value); }

        /// <summary>
        /// The contact's cell phone number.
        /// </summary>
        public string MobilePhone { get => _mobilePhone; set => SetField(ref _mobilePhone, value); }

        /// <summary>
        /// The contact's fax number.
        /// </summary>
        public string FaxNumber { get => _faxNumber; set => SetField(ref _faxNumber, value); }

        /// <summary>
        /// The contact's personal email address.
        /// </summary>
        public string PersonalEmail { get => _personalEmail; set => SetField(ref _personalEmail, value); }

        /// <summary>
        /// The contact's work email address.
        /// </summary>
        public string BusinessEmail { get => _businessEmail; set => SetField(ref _businessEmail, value); }

        /// <summary>
        /// Contact Salutation
        /// </summary>
        public string Salutation { get => _salutation; set => SetField(ref _salutation, value); }

        /// <summary>
        /// The contactId (or id) is the unique identifier of the borrower contact.
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Contact GroupIDs
        /// </summary>
        public IList<int?> GroupIDs { get => GetField(ref _groupIDs); set => SetField(ref _groupIDs, value); }

        internal abstract string ApiPath { get; }

        /// <summary>
        /// The <see cref="EncompassRestClient"/> associated with this object.
        /// </summary>
        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        /// <summary>
        /// The Contact Notes Apis. Contact object must be initialized to use Notes.
        /// </summary>
        [JsonIgnore]
        public ContactNotes Notes => _notes ?? throw new InvalidOperationException("Contact object must be initialized to use Notes");

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

        /// <summary>
        /// Initializes the contact object with the specified <paramref name="client"/> and <paramref name="contactId"/>. This allows the use of the <see cref="Notes"/> property.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="contactId"></param>
        public void Initialize(EncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            if (!ReferenceEquals(Client, client))
            {
                Client = client;
                Id = contactId;
                _notes = new ContactNotes(client, Id, ApiPath);
            }
        }
    }
}