using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// OtherIncomeSource
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class OtherIncomeSource : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _altId;
        private DirtyValue<string?>? _attention;
        private DirtyValue<string?>? _borrowerId;
        private DirtyValue<EntityReference?>? _contact;
        private DirtyValue<StringEnumValue<OtherIncomeSourceDescription>>? _description;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<bool?>? _foreignIncomeIndicator;
        private DirtyValue<string?>? _holderAddressCity;
        private DirtyValue<string?>? _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>>? _holderAddressState;
        private DirtyValue<string?>? _holderAddressStreetLine1;
        private DirtyValue<string?>? _holderEmail;
        private DirtyValue<string?>? _holderFax;
        private DirtyValue<string?>? _holderName;
        private DirtyValue<string?>? _holderPhone;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _monthlyAmount;
        private DirtyValue<string?>? _otherDescription;
        private DirtyValue<DateTime?>? _otherIncomeSourceDate;
        private DirtyValue<int?>? _otherIncomeSourceIndex;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _owner;
        private DirtyValue<bool?>? _printAttachmentIndicator;
        private DirtyValue<bool?>? _printUserJobTitleIndicator;
        private DirtyValue<bool?>? _printUserNameIndicator;
        private DirtyValue<bool?>? _seasonalIncomeIndicator;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _titleFax;
        private DirtyValue<string?>? _titlePhone;

        /// <summary>
        /// Other Income Source ID [URLAROISNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Attention Contact [URLAROISNN06]
        /// </summary>
        public string? Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// OtherIncomeSource BorrowerId
        /// </summary>
        public string? BorrowerId { get => _borrowerId; set => SetField(ref _borrowerId, value); }

        /// <summary>
        /// OtherIncomeSource Contact
        /// </summary>
        public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Other Income Source Description [URLAROISNN18]
        /// </summary>
        public StringEnumValue<OtherIncomeSourceDescription> Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// OtherIncomeSource EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Foreign Income [URLAROISNN20]
        /// </summary>
        public bool? ForeignIncomeIndicator { get => _foreignIncomeIndicator; set => SetField(ref _foreignIncomeIndicator, value); }

        /// <summary>
        /// Attention City [URLAROISNN08]
        /// </summary>
        public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Attention Zipcode [URLAROISNN10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Attention State [URLAROISNN09]
        /// </summary>
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Address [URLAROISNN07]
        /// </summary>
        public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Email [URLAROISNN13]
        /// </summary>
        public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Fax [URLAROISNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Name [URLAROISNN05]
        /// </summary>
        public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Phone [URLAROISNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// OtherIncomeSource Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Monthly Amount [URLAROISNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyAmount { get => _monthlyAmount; set => SetField(ref _monthlyAmount, value); }

        /// <summary>
        /// Other Description [URLAROISNN19]
        /// </summary>
        public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

        /// <summary>
        /// Other Income Source Date [URLAROISNN03]
        /// </summary>
        public DateTime? OtherIncomeSourceDate { get => _otherIncomeSourceDate; set => SetField(ref _otherIncomeSourceDate, value); }

        /// <summary>
        /// OtherIncomeSource OtherIncomeSourceIndex
        /// </summary>
        public int? OtherIncomeSourceIndex { get => _otherIncomeSourceIndex; set => SetField(ref _otherIncomeSourceIndex, value); }

        /// <summary>
        /// Other Income Source is For [URLAROISNN02]
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Other Income Source Print - See Attached Authorization [URLAROISNN04]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Other Income Source Print User Job Title [URLAROISNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Other Income Source Print User Name [URLAROISNN15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Seasonal Income [URLAROISNN21]
        /// </summary>
        public bool? SeasonalIncomeIndicator { get => _seasonalIncomeIndicator; set => SetField(ref _seasonalIncomeIndicator, value); }

        /// <summary>
        /// Other Income Source From Title [URLAROISNN14]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Other Income Source From Fax [URLAROISNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Other Income Source From Phone [URLAROISNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}