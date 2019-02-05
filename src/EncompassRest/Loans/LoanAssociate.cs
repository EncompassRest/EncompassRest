using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanAssociate
    /// </summary>
    public sealed partial class LoanAssociate : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aPIClientID;
        private DirtyValue<string> _cellPhone;
        private DirtyValue<string> _email;
        private DirtyValue<StringEnumValue<YOrN>> _enableWriteAccess;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _id;
        private DirtyValue<string> _idString;
        private DirtyValue<StringEnumValue<LoanAssociateType>> _loanAssociateType;
        private DirtyValue<string> _name;
        private DirtyValue<string> _phone;
        private DirtyValue<int?> _roleId;
        private DirtyValue<string> _roleName;
        private DirtyValue<string> _title;
        private DirtyValue<string> _writeAccess;

        /// <summary>
        /// LoanAssociate APIClientID
        /// </summary>
        public string APIClientID { get => _aPIClientID; set => SetField(ref _aPIClientID, value); }

        /// <summary>
        /// LoanAssociate CellPhone
        /// </summary>
        public string CellPhone { get => _cellPhone; set => SetField(ref _cellPhone, value); }

        /// <summary>
        /// LoanAssociate Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// LoanAssociate EnableWriteAccess
        /// </summary>
        public StringEnumValue<YOrN> EnableWriteAccess { get => _enableWriteAccess; set => SetField(ref _enableWriteAccess, value); }

        /// <summary>
        /// LoanAssociate Fax
        /// </summary>
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// LoanAssociate Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LoanAssociate IdString
        /// </summary>
        public string IdString { get => _idString; set => SetField(ref _idString, value); }

        /// <summary>
        /// LoanAssociate LoanAssociateType
        /// </summary>
        public StringEnumValue<LoanAssociateType> LoanAssociateType { get => _loanAssociateType; set => SetField(ref _loanAssociateType, value); }

        /// <summary>
        /// LoanAssociate Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// LoanAssociate Phone
        /// </summary>
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// LoanAssociate RoleId
        /// </summary>
        public int? RoleId { get => _roleId; set => SetField(ref _roleId, value); }

        /// <summary>
        /// LoanAssociate RoleName
        /// </summary>
        public string RoleName { get => _roleName; set => SetField(ref _roleName, value); }

        /// <summary>
        /// LoanAssociate Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// LoanAssociate WriteAccess
        /// </summary>
        public string WriteAccess { get => _writeAccess; set => SetField(ref _writeAccess, value); }
    }
}