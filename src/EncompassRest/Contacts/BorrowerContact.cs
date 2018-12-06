using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// BorrowerContact
    /// </summary>
    public sealed class BorrowerContact : Contact
    {
        private DirtyValue<string> _employerName;
        private DirtyValue<DateTime?> _birthdate;
        private DirtyValue<string> _referral;

        /// <summary>
        /// The name of the contact's employer.
        /// </summary>
        public string EmployerName { get => _employerName; set => SetField(ref _employerName, value); }

        /// <summary>
        /// The contact's date of birth.
        /// </summary>
        public DateTime? Birthdate { get => _birthdate; set => SetField(ref _birthdate, value); }

        /// <summary>
        /// The name of a person or company, if any, who referred the borrower to you.
        /// </summary>
        public string Referral { get => _referral; set => SetField(ref _referral, value); }

        internal override string ApiPath => "encompass/v1/borrowerContacts";

        /// <summary>
        /// Borrower contact creation constructor
        /// </summary>
        /// <param name="firstName">The contact's first name.</param>
        /// <param name="personalEmail">The contact's personal email address.</param>
        public BorrowerContact(string firstName, string personalEmail)
            : base(firstName, personalEmail)
        {
        }

        /// <summary>
        /// Borrower contact update constructor
        /// </summary>
        /// <param name="client">The client to initialize the contact object with.</param>
        /// <param name="contactId">The contactId (or id) is the unique identifier of the contact.</param>
        /// <param name="firstName">The contact's first name.</param>
        /// <param name="personalEmail">The contact's personal email address.</param>
        public BorrowerContact(EncompassRestClient client, string contactId, string firstName, string personalEmail)
            : base(client, contactId, firstName, personalEmail)
        {
        }

        /// <summary>
        /// Borrower contact deserialization constructor
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public BorrowerContact()
        {
        }

        /// <summary>
        /// BorrowerContact update constructor
        /// </summary>
        /// <param name="client">The <see cref="EncompassRestClient"/> to associate with this object.</param>
        /// <param name="contactId">The contactId (or id) is the unique identifier of the contact.</param>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public BorrowerContact(EncompassRestClient client, string contactId)
        {
            Initialize(client, contactId);
        }
    }
}