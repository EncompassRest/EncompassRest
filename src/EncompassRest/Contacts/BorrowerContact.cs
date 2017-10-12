namespace EncompassRest.Contacts
{
    public sealed class BorrowerContact : Contact,IDirty
    {
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
