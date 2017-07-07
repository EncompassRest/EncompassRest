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
                var cellPhone = _cellPhone; cellPhone.Clean = value; _cellPhone = cellPhone;
                var email = _email; email.Clean = value; _email = email;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var id = _id; id.Clean = value; _id = id;
                var idString = _idString; idString.Clean = value; _idString = idString;
                var loanAssociateType = _loanAssociateType; loanAssociateType.Clean = value; _loanAssociateType = loanAssociateType;
                var name = _name; name.Clean = value; _name = name;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var roleId = _roleId; roleId.Clean = value; _roleId = roleId;
                var roleName = _roleName; roleName.Clean = value; _roleName = roleName;
                var writeAccess = _writeAccess; writeAccess.Clean = value; _writeAccess = writeAccess;
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