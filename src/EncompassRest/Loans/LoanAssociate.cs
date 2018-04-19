#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LoanAssociate : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _cellPhone;
        public string CellPhone { get => _cellPhone; set => _cellPhone = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _idString;
        public string IdString { get => _idString; set => _idString = value; }
        private DirtyValue<StringEnumValue<LoanAssociateType>> _loanAssociateType;
        public StringEnumValue<LoanAssociateType> LoanAssociateType { get => _loanAssociateType; set => _loanAssociateType = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<int?> _roleId;
        public int? RoleId { get => _roleId; set => _roleId = value; }
        private DirtyValue<string> _roleName;
        public string RoleName { get => _roleName; set => _roleName = value; }
        private DirtyValue<string> _writeAccess;
        public string WriteAccess { get => _writeAccess; set => _writeAccess = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _cellPhone.Dirty
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
            }
            set
            {
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
            }
        }
    }
}