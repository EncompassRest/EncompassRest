using System;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact
    {
        internal override string ApiPath => "encompass/v1/borrowerContacts";

        private DirtyValue<string> _employerName;
        public string EmployerName { get => _employerName; set => _employerName = value; }
        private DirtyValue<DateTime?> _birthdate;
        public DateTime? Birthdate { get => _birthdate; set => _birthdate = value; }
        private DirtyValue<string> _referral;
        public string Referral { get => _referral; set => _referral = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return base.DirtyInternal
                    || _employerName.Dirty
                    || _birthdate.Dirty
                    || _referral.Dirty;
            }
            set
            {
                base.DirtyInternal = value;
                _employerName.Dirty = value;
                _birthdate.Dirty = value;
                _referral.Dirty = value;
            }
        }
    }
}