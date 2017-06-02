using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _cellPhone.Clean
                    && _email.Clean
                    && _fax.Clean
                    && _id.Clean
                    && _idString.Clean
                    && _loanAssociateType.Clean
                    && _name.Clean
                    && _phone.Clean
                    && _roleId.Clean
                    && _roleName.Clean
                    && _writeAccess.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _cellPhone; v0.Clean = value; _cellPhone = v0;
                var v1 = _email; v1.Clean = value; _email = v1;
                var v2 = _fax; v2.Clean = value; _fax = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _idString; v4.Clean = value; _idString = v4;
                var v5 = _loanAssociateType; v5.Clean = value; _loanAssociateType = v5;
                var v6 = _name; v6.Clean = value; _name = v6;
                var v7 = _phone; v7.Clean = value; _phone = v7;
                var v8 = _roleId; v8.Clean = value; _roleId = v8;
                var v9 = _roleName; v9.Clean = value; _roleName = v9;
                var v10 = _writeAccess; v10.Clean = value; _writeAccess = v10;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanAssociate()
        {
            Clean = true;
        }
    }
}