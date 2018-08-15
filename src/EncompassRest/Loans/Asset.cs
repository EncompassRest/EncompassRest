using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Asset
    /// </summary>
    public sealed partial class Asset : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        /// <summary>
        /// Asset AccountIdentifier
        /// </summary>
        public string AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }
        private DirtyValue<string> _altId;
        /// <summary>
        /// Depository Request ID [DDNN35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Depository Request ID")]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }
        private DirtyValue<int?> _assetIndex;
        /// <summary>
        /// Asset AssetIndex
        /// </summary>
        public int? AssetIndex { get => _assetIndex; set => SetField(ref _assetIndex, value); }
        private DirtyValue<StringEnumValue<AssetType>> _assetType;
        /// <summary>
        /// Asset AssetType
        /// </summary>
        public StringEnumValue<AssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }
        private DirtyValue<string> _attention;
        /// <summary>
        /// Depository Attention Contact [DDNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Attention Contact")]
        public string Attention { get => _attention; set => SetField(ref _attention, value); }
        private DirtyValue<string> _borrowerId;
        /// <summary>
        /// Asset BorrowerId
        /// </summary>
        public string BorrowerId { get => _borrowerId; set => SetField(ref _borrowerId, value); }
        private DirtyValue<decimal?> _cashOrMarketValueAmount;
        /// <summary>
        /// Asset CashOrMarketValueAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CashOrMarketValueAmount { get => _cashOrMarketValueAmount; set => SetField(ref _cashOrMarketValueAmount, value); }
        private EntityReference _contact;
        /// <summary>
        /// Asset Contact
        /// </summary>
        public EntityReference Contact { get => GetField(ref _contact); set => SetField(ref _contact, value); }
        private DirtyValue<string> _depositoryAccountName;
        /// <summary>
        /// Asset DepositoryAccountName
        /// </summary>
        public string DepositoryAccountName { get => _depositoryAccountName; set => SetField(ref _depositoryAccountName, value); }
        private DirtyValue<DateTime?> _depositoryRequestDate;
        /// <summary>
        /// Depository Request Date [DDNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Request Date")]
        public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => SetField(ref _depositoryRequestDate, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// Asset Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Asset EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }
        private DirtyValue<string> _holderAddressCity;
        /// <summary>
        /// Depository Attention City [DDNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Attention City")]
        public string HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }
        private DirtyValue<string> _holderAddressPostalCode;
        /// <summary>
        /// Depository Attention Zipcode [DDNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Depository Attention Zipcode")]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        /// <summary>
        /// Depository Attention State [DDNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Attention State")]
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }
        private DirtyValue<string> _holderAddressStreetLine1;
        /// <summary>
        /// Depository Address [DDNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Address")]
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }
        private DirtyValue<string> _holderComments;
        /// <summary>
        /// Depository Comments [DDNN29]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Comments")]
        public string HolderComments { get => _holderComments; set => SetField(ref _holderComments, value); }
        private DirtyValue<string> _holderEmail;
        /// <summary>
        /// Depository Email [DDNN28]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Email")]
        public string HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }
        private DirtyValue<string> _holderFax;
        /// <summary>
        /// Depository Fax [DDNN27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Depository Fax")]
        public string HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }
        private DirtyValue<string> _holderName;
        /// <summary>
        /// Asset HolderName [DDNN02]
        /// </summary>
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }
        private DirtyValue<string> _holderPhone;
        /// <summary>
        /// Depository Phone [DDNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Depository Phone")]
        public string HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Asset Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// Asset IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }
        private DirtyValue<bool?> _isVod;
        /// <summary>
        /// Asset IsVod
        /// </summary>
        public bool? IsVod { get => _isVod; set => SetField(ref _isVod, value); }
        private DirtyValue<decimal?> _lifeInsuranceFaceValueAmount;
        /// <summary>
        /// Assets Life Ins Face Amt [303]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Assets Life Ins Face Amt")]
        public decimal? LifeInsuranceFaceValueAmount { get => _lifeInsuranceFaceValueAmount; set => SetField(ref _lifeInsuranceFaceValueAmount, value); }
        private DirtyValue<string> _nameInAccount;
        /// <summary>
        /// Asset NameInAccount
        /// </summary>
        public string NameInAccount { get => _nameInAccount; set => SetField(ref _nameInAccount, value); }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Depository No Link to Doc Tracking [DDNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Depository No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }
        private DirtyValue<StringEnumValue<Owner>> _owner;
        /// <summary>
        /// Depository Request is For [DDNN24]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Request is For")]
        public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }
        private DirtyValue<bool?> _printAttachmentIndicator;
        /// <summary>
        /// Depository Print - See Attached Authorization [DDNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Depository Print User Name as Title [DDNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Depository Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// Depository From Title [DDNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Depository From Title")]
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Depository From Fax [DDNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Depository From Fax")]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Depository From Phone [DDNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Depository From Phone")]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// Depository Total Balance [DDNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Depository Total Balance")]
        public decimal? Total { get => _total; set => SetField(ref _total, value); }
        private DirtyValue<int?> _vodIndex;
        /// <summary>
        /// Asset VodIndex
        /// </summary>
        public int? VodIndex { get => _vodIndex; set => SetField(ref _vodIndex, value); }
    }
}