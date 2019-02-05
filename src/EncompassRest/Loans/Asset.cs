using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Asset
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(AssetType), SerializeWholeListWhenDirty = true)]
    public sealed partial class Asset : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        private DirtyValue<string> _altId;
        private DirtyValue<int?> _assetIndex;
        private DirtyValue<StringEnumValue<AssetType>> _assetType;
        private DirtyValue<string> _attention;
        private DirtyValue<string> _borrowerId;
        private DirtyValue<decimal?> _cashOrMarketValueAmount;
        private DirtyValue<EntityReference> _contact;
        private DirtyValue<string> _depositoryAccountName;
        private DirtyValue<DateTime?> _depositoryRequestDate;
        private DirtyValue<string> _description;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<string> _holderAddressCity;
        private DirtyValue<string> _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        private DirtyValue<string> _holderAddressStreetLine1;
        private DirtyValue<string> _holderComments;
        private DirtyValue<string> _holderEmail;
        private DirtyValue<string> _holderFax;
        private DirtyValue<string> _holderName;
        private DirtyValue<string> _holderPhone;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isEmpty;
        private DirtyValue<bool?> _isVod;
        private DirtyValue<decimal?> _lifeInsuranceFaceValueAmount;
        private DirtyValue<string> _nameInAccount;
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        private DirtyValue<StringEnumValue<Owner>> _owner;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserJobTitleIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;
        private DirtyValue<decimal?> _total;
        private DirtyValue<decimal?> _urla2020CashOrMarketValueAmount;
        private DirtyValue<int?> _vodIndex;

        /// <summary>
        /// Asset AccountIdentifier
        /// </summary>
        public string AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

        /// <summary>
        /// Depository Request ID [DDNN35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Asset AssetIndex
        /// </summary>
        public int? AssetIndex { get => _assetIndex; set => SetField(ref _assetIndex, value); }

        /// <summary>
        /// Asset AssetType
        /// </summary>
        public StringEnumValue<AssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }

        /// <summary>
        /// Asset Attention
        /// </summary>
        public string Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Asset BorrowerId
        /// </summary>
        public string BorrowerId { get => _borrowerId; set => SetField(ref _borrowerId, value); }

        /// <summary>
        /// Asset CashOrMarketValueAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CashOrMarketValueAmount { get => _cashOrMarketValueAmount; set => SetField(ref _cashOrMarketValueAmount, value); }

        /// <summary>
        /// Asset Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Asset DepositoryAccountName
        /// </summary>
        public string DepositoryAccountName { get => _depositoryAccountName; set => SetField(ref _depositoryAccountName, value); }

        /// <summary>
        /// Depository Request Date [DDNN98]
        /// </summary>
        public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => SetField(ref _depositoryRequestDate, value); }

        /// <summary>
        /// Asset Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Asset EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Depository Attention City [DDNN05]
        /// </summary>
        public string HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Depository Attention Zipcode [DDNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Depository Attention State [DDNN06]
        /// </summary>
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Depository Address [DDNN04]
        /// </summary>
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Depository Comments [DDNN29]
        /// </summary>
        public string HolderComments { get => _holderComments; set => SetField(ref _holderComments, value); }

        /// <summary>
        /// Depository Email [DDNN28]
        /// </summary>
        public string HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Depository Fax [DDNN27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Asset HolderName [DDNN02]
        /// </summary>
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Depository Phone [DDNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// Asset Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Asset IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// Asset IsVod
        /// </summary>
        public bool? IsVod { get => _isVod; set => SetField(ref _isVod, value); }

        /// <summary>
        /// Assets Life Ins Face Amt [303]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LifeInsuranceFaceValueAmount { get => _lifeInsuranceFaceValueAmount; set => SetField(ref _lifeInsuranceFaceValueAmount, value); }

        /// <summary>
        /// Asset NameInAccount
        /// </summary>
        public string NameInAccount { get => _nameInAccount; set => SetField(ref _nameInAccount, value); }

        /// <summary>
        /// Depository No Link to Doc Tracking [DDNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Depository Request is For [DDNN24]
        /// </summary>
        public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Depository Print - See Attached Authorization [DDNN36]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Depository Print User Job Title [DDNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Depository Print User Name as Title [DDNN38]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Depository From Title [DDNN37]
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Depository From Fax [DDNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Depository From Phone [DDNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Depository Total Balance [DDNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Total { get => _total; set => SetField(ref _total, value); }

        /// <summary>
        /// Asset Urla2020CashOrMarketValueAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Urla2020CashOrMarketValueAmount { get => _urla2020CashOrMarketValueAmount; set => SetField(ref _urla2020CashOrMarketValueAmount, value); }

        /// <summary>
        /// Asset VodIndex
        /// </summary>
        public int? VodIndex { get => _vodIndex; set => SetField(ref _vodIndex, value); }
    }
}