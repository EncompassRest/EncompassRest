using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate : IDirty
    {
        private DirtyValue<string> _cellPhone;
        public string CellPhone { get { return _cellPhone; } set { _cellPhone = value; } }
        private DirtyValue<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private DirtyValue<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _idString;
        public string IdString { get { return _idString; } set { _idString = value; } }
        private DirtyValue<string> _loanAssociateType;
        public string LoanAssociateType { get { return _loanAssociateType; } set { _loanAssociateType = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private DirtyValue<int?> _roleId;
        public int? RoleId { get { return _roleId; } set { _roleId = value; } }
        private DirtyValue<string> _roleName;
        public string RoleName { get { return _roleName; } set { _roleName = value; } }
        private DirtyValue<string> _writeAccess;
        public string WriteAccess { get { return _writeAccess; } set { _writeAccess = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _cellPhone.Dirty
                    || _email.Dirty
                    || _fax.Dirty
                    || _id.Dirty
                    || _idString.Dirty
                    || _loanAssociateType.Dirty
                    || _name.Dirty
                    || _phone.Dirty
                    || _roleId.Dirty
                    || _roleName.Dirty
                    || _writeAccess.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _cellPhone.Dirty = value;
                _email.Dirty = value;
                _fax.Dirty = value;
                _id.Dirty = value;
                _idString.Dirty = value;
                _loanAssociateType.Dirty = value;
                _name.Dirty = value;
                _phone.Dirty = value;
                _roleId.Dirty = value;
                _roleName.Dirty = value;
                _writeAccess.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}