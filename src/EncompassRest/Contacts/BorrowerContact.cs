using Newtonsoft.Json;
using System;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact
    {
        internal override string ApiPath => "encompass/v1/borrowerContacts";

        private DirtyValue<string> _employerName;
        public string EmployerName { get => _employerName; set => SetField(ref _employerName, value); }
        private DirtyValue<DateTime?> _birthdate;
        public DateTime? Birthdate { get => _birthdate; set => SetField(ref _birthdate, value); }
        private DirtyValue<string> _referral;
        public string Referral { get => _referral; set => SetField(ref _referral, value); }

        /// <summary>
        /// BorrowerContact creation constructor
        /// </summary>
        [JsonConstructor]
        public BorrowerContact()
        {
        }

        /// <summary>
        /// BusinessContact update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="contactId"></param>
        public BorrowerContact(EncompassRestClient client, string contactId)
            : base(client, contactId)
        {
        }
    }
}