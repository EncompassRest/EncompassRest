using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate : IDirty
    {
        private Value<string> _cellPhone;
        public string CellPhone { get { return _cellPhone; } set { _cellPhone = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _idString;
        public string IdString { get { return _idString; } set { _idString = value; } }
        private Value<string> _loanAssociateType;
        public string LoanAssociateType { get { return _loanAssociateType; } set { _loanAssociateType = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<int?> _roleId;
        public int? RoleId { get { return _roleId; } set { _roleId = value; } }
        private Value<string> _roleName;
        public string RoleName { get { return _roleName; } set { _roleName = value; } }
        private Value<string> _writeAccess;
        public string WriteAccess { get { return _writeAccess; } set { _writeAccess = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _writeAccess.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}