using EncompassApi.Loans.Enums;

namespace EncompassApi.Loans
{
    /// <summary>
    /// URLAAlternateName
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(Owner), SerializeWholeListWhenDirty = true)]
    public sealed partial class URLAAlternateName : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _altId;
        private DirtyValue<EntityReference?>? _contact;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _firstName;
        private DirtyValue<string?>? _fullName;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _lastName;
        private DirtyValue<string?>? _middleName;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _owner;
        private DirtyValue<string?>? _suffix;

        /// <summary>
        /// URLAAlternateName AltId [URLABAKANN06], [URLACAKANN06]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// URLAAlternateName Contact
        /// </summary>
        public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// URLAAlternateName EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// URLAAlternateName FirstName [URLABAKANN01], [URLACAKANN01]
        /// </summary>
        public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// URLAAlternateName FullName [URLABAKANN05], [URLACAKANN05]
        /// </summary>
        public string? FullName { get => _fullName; set => SetField(ref _fullName, value); }

        /// <summary>
        /// URLAAlternateName Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// URLAAlternateName LastName [URLABAKANN03], [URLACAKANN03]
        /// </summary>
        public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// URLAAlternateName MiddleName [URLABAKANN02], [URLACAKANN02]
        /// </summary>
        public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

        /// <summary>
        /// URLAAlternateName Owner
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// URLAAlternateName Suffix [URLABAKANN04], [URLACAKANN04]
        /// </summary>
        public string? Suffix { get => _suffix; set => SetField(ref _suffix, value); }
    }
}