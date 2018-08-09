using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanAssociate
    /// </summary>
    public sealed partial class LoanAssociate : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _cellPhone;
        /// <summary>
        /// LoanAssociate CellPhone
        /// </summary>
        public string CellPhone { get => _cellPhone; set => _cellPhone = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// LoanAssociate Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// LoanAssociate Fax
        /// </summary>
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanAssociate Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _idString;
        /// <summary>
        /// LoanAssociate IdString
        /// </summary>
        public string IdString { get => _idString; set => _idString = value; }
        private DirtyValue<StringEnumValue<LoanAssociateType>> _loanAssociateType;
        /// <summary>
        /// LoanAssociate LoanAssociateType
        /// </summary>
        public StringEnumValue<LoanAssociateType> LoanAssociateType { get => _loanAssociateType; set => _loanAssociateType = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// LoanAssociate Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// LoanAssociate Phone
        /// </summary>
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<int?> _roleId;
        /// <summary>
        /// LoanAssociate RoleId
        /// </summary>
        public int? RoleId { get => _roleId; set => _roleId = value; }
        private DirtyValue<string> _roleName;
        /// <summary>
        /// LoanAssociate RoleName
        /// </summary>
        public string RoleName { get => _roleName; set => _roleName = value; }
        private DirtyValue<string> _writeAccess;
        /// <summary>
        /// LoanAssociate WriteAccess
        /// </summary>
        public string WriteAccess { get => _writeAccess; set => _writeAccess = value; }
    }
}