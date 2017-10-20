using EncompassRest.Utilities;
using Newtonsoft.Json;
using System;

namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact, IDirty
    {
        internal override string ApiPath { get { return "encompass/v1/borrowerContacts"; } }

        private DirtyValue<string> _employerName;
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        private DirtyValue<DateTime?> _birthdate;
        public DateTime? Birthdate { get { return _birthdate; } set { _birthdate = value; } }
        private DirtyValue<string> _referral;
        public string Referral { get { return _referral; } set { _referral = value; } }
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
                    || _referral.Dirty;
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
                _referral.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
