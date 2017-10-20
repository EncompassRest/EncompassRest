using System;

namespace EncompassRest.Contacts
{
    public sealed class ContactAddress : IDirty
    {
        private DirtyValue<string> _street1;
        public string Street1 { get { return _street1; } set { _street1 = value; } }
        private DirtyValue<string> _street2;
        public string Street2 { get { return _street2; } set { _street2 = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private DirtyValue<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _street1.Dirty
                    || _street2.Dirty
                    || _city.Dirty
                    || _state.Dirty
                    || _zip.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _street1.Dirty = value;
                _street2.Dirty = value;
                _city.Dirty = value;
                _state.Dirty = value;
                _zip.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
