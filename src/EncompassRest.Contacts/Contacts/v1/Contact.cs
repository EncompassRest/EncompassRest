using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// Contact
    /// </summary>
    public abstract class Contact : DirtyExtensibleObject, IIdentifiable
    {
        private IContactNotes? _notes;

        /// <summary>
        /// The contact's first name.
        /// </summary>
        public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's last name.
        /// </summary>
        public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// User ID of the user who submitted the API request.
        /// </summary>
        public string? OwnerId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Contact AccessLevel
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public ContactAccessLevel? AccessLevel { get => GetValue<ContactAccessLevel?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's home address.
        /// </summary>
        [AllowNull]
        public Address CurrentMailingAddress { get => GetEntity<Address>(); set => SetEntity(value); }

        /// <summary>
        /// Website address for the business.
        /// </summary>
        public string? BusinessWebUrl { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's job title.
        /// </summary>
        public string? JobTitle { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's work phone number.
        /// </summary>
        public string? WorkPhone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's home phone number.
        /// </summary>
        public string? HomePhone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's cell phone number.
        /// </summary>
        public string? MobilePhone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's fax number.
        /// </summary>
        public string? FaxNumber { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's personal email address.
        /// </summary>
        public string? PersonalEmail { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contact's work email address.
        /// </summary>
        public string? BusinessEmail { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Contact Salutation
        /// </summary>
        public string? Salutation { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The contactId (or id) is the unique identifier of the contact.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Contact GroupIDs
        /// </summary>
        [AllowNull]
        public IList<int?> GroupIDs { get => GetList<int?>(); set => SetList(value); }

        /// <summary>
        /// The <see cref="EncompassRestClient"/> associated with this object.
        /// </summary>
        [JsonIgnore]
        public IEncompassRestClient? Client { get; private set; }

        /// <summary>
        /// The Contact Notes Apis. Contact object must be initialized to use Notes.
        /// </summary>
        [JsonIgnore]
        public IContactNotes Notes => _notes ?? throw new InvalidOperationException("Contact object must be initialized to use Notes");

        /// <summary>
        /// The contact type.
        /// </summary>
        [JsonIgnore]
        public abstract ContactType Type { get; }

        internal Contact(IEncompassRestClient client, string contactId, string firstName, string personalEmail)
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
        /// <param name="client">The <see cref="EncompassRestClient"/> to associate with this object.</param>
        /// <param name="contactId">The contactId (or id) is the unique identifier of the contact.</param>
        public void Initialize(IEncompassRestClient client, string contactId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(contactId, nameof(contactId));

            if (!ReferenceEquals(Client, client))
            {
                Client = client;
                Id = contactId;
                _notes = client.Contacts.GetContactNotes(Type, Id);
            }
        }
    }
}