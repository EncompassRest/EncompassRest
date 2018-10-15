using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact
    {
        private DirtyValue<string> _employerName;
        private DirtyValue<DateTime?> _birthdate;
        private DirtyValue<string> _referral;

        public string EmployerName { get => _employerName; set => SetField(ref _employerName, value); }
        
        public DateTime? Birthdate { get => _birthdate; set => SetField(ref _birthdate, value); }
        
        public string Referral { get => _referral; set => SetField(ref _referral, value); }

        internal override string ApiPath => "encompass/v1/borrowerContacts";

        /// <summary>
        /// Borrower contact creation constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="personalEmail"></param>
        public BorrowerContact(string firstName, string personalEmail)
            : base(firstName, personalEmail)
        {
        }

        /// <summary>
        /// Borrower contact update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="contactId"></param>
        /// <param name="firstName"></param>
        /// <param name="personalEmail"></param>
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
        /// BusinessContact update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="contactId"></param>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public BorrowerContact(EncompassRestClient client, string contactId)
        {
            Initialize(client, contactId);
        }
    }
}