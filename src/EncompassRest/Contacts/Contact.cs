using EncompassRest.Utilities;
using System;

namespace EncompassRest.Contacts
{
    public enum ContactAccessLevel
    {
        Private = 0,
        Public = 1
    }

    public abstract class Contact : IDirty
    {
        private DirtyValue<string> _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private DirtyValue<string> _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private DirtyValue<string> _ownerId;
        public string OwnerID { get { return _ownerId; } set { _ownerId = value; } }
        private DirtyValue<ContactAccessLevel> _accessLevel;
        [EnumOutput(EnumOutput.Integer)]
        public ContactAccessLevel AccessLevel { get { return _accessLevel; } set { _accessLevel = value; } }
        private ContactAddress _currentMailingAddress;
        public ContactAddress CurrentMailingAddress { get { return _currentMailingAddress ?? new ContactAddress(); } set { _currentMailingAddress = value; } }
        private DirtyValue<string> _jobTitle;
        public string JobTitle { get { return _jobTitle; } set { _jobTitle = value; } }
        private DirtyValue<string> _workPhone;
        public string WorkPhone { get { return _workPhone; } set { _workPhone = value; } }
        private DirtyValue<string> _homePhone;
        public string HomePhone { get { return _homePhone; } set { _homePhone = value; } }
        private DirtyValue<string> _mobilePhone;
        public string MobilePhone { get { return _mobilePhone; } set { _mobilePhone = value; } }
        private DirtyValue<string> _faxNumber;
        public string FaxNumber { get { return _faxNumber; } set { _faxNumber = value; } }
        private DirtyValue<string> _personalEmail;
        public string PersonalEmail { get { return _personalEmail; } set { _personalEmail = value; } }
        private DirtyValue<string> _businessEmail;
        public string BusinessEmail { get { return _businessEmail; } set { _businessEmail = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        internal bool Dirty
        {
            get
            {
                var dirty = _firstName.Dirty
                    || _lastName.Dirty
                    || _ownerId.Dirty
                    || _accessLevel.Dirty
                    || _currentMailingAddress?.Dirty == true
                    || _jobTitle.Dirty
                    || _workPhone.Dirty
                    || _homePhone.Dirty
                    || _mobilePhone.Dirty
                    || _faxNumber.Dirty
                    || _personalEmail.Dirty
                    || _businessEmail.Dirty
                    || _id.Dirty;
                return dirty;
            }
            set
            {
                _firstName.Dirty = value;
                _lastName.Dirty = value;
                _ownerId.Dirty = value;
                _accessLevel.Dirty = value;
                if (_currentMailingAddress != null) _currentMailingAddress.Dirty = value;
                _jobTitle.Dirty = value;
                _workPhone.Dirty = value;
                _homePhone.Dirty = value;
                _mobilePhone.Dirty = value;
                _faxNumber.Dirty = value;
                _personalEmail.Dirty = value;
                _businessEmail.Dirty = value;
                _id.Dirty = value;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}
