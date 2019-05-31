using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GiftGrant
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class GiftGrant : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _altId;
        private DirtyValue<decimal?> _amount;
        private DirtyValue<StringEnumValue<GiftGrantAssetType>> _assetType;
        private DirtyValue<string> _attention;
        private DirtyValue<string> _borrowerId;
        private DirtyValue<EntityReference> _contact;
        private DirtyValue<bool?> _depositedIndicator;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<int?> _giftGrantIndex;
        private DirtyValue<DateTime?> _giftorGrantDate;
        private DirtyValue<string> _holderAddressCity;
        private DirtyValue<string> _holderAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _holderAddressState;
        private DirtyValue<string> _holderAddressStreetLine1;
        private DirtyValue<string> _holderEmail;
        private DirtyValue<string> _holderFax;
        private DirtyValue<string> _holderName;
        private DirtyValue<string> _holderPhone;
        private DirtyValue<string> _id;
        private DirtyValue<string> _otherSourceDescription;
        private DirtyValue<StringEnumValue<Owner>> _owner;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserJobTitleIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<StringEnumValue<GiftGrantSource>> _source;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;

        /// <summary>
        /// Gift or Grant ID [URLARGGNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Amount [URLARGGNN21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// Gift or Grant Asset Type [URLARGGNN18]
        /// </summary>
        public StringEnumValue<GiftGrantAssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }

        /// <summary>
        /// Attention Contact [URLARGGNN06]
        /// </summary>
        public string Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// GiftGrant BorrowerId
        /// </summary>
        public string BorrowerId { get => _borrowerId; set => SetField(ref _borrowerId, value); }

        /// <summary>
        /// GiftGrant Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Deposited [URLARGGNN20]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Deposited\"}")]
        public bool? DepositedIndicator { get => _depositedIndicator; set => SetField(ref _depositedIndicator, value); }

        /// <summary>
        /// GiftGrant EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// GiftGrant GiftGrantIndex
        /// </summary>
        public int? GiftGrantIndex { get => _giftGrantIndex; set => SetField(ref _giftGrantIndex, value); }

        /// <summary>
        /// Gift or Grant Date [URLARGGNN03]
        /// </summary>
        public DateTime? GiftorGrantDate { get => _giftorGrantDate; set => SetField(ref _giftorGrantDate, value); }

        /// <summary>
        /// Attention City [URLARGGNN08]
        /// </summary>
        public string HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

        /// <summary>
        /// Attention Zipcode [URLARGGNN10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

        /// <summary>
        /// Attention State [URLARGGNN09]
        /// </summary>
        public StringEnumValue<State> HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

        /// <summary>
        /// Address [URLARGGNN07]
        /// </summary>
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

        /// <summary>
        /// Email [URLARGGNN13]
        /// </summary>
        public string HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

        /// <summary>
        /// Fax [URLARGGNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

        /// <summary>
        /// Name [URLARGGNN05]
        /// </summary>
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// Phone [URLARGGNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

        /// <summary>
        /// GiftGrant Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Other Source Description [URLARGGNN22]
        /// </summary>
        public string OtherSourceDescription { get => _otherSourceDescription; set => SetField(ref _otherSourceDescription, value); }

        /// <summary>
        /// Gift or Grant is For [URLARGGNN02]
        /// </summary>
        public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Gift or Grant Print - See Attached Authorization [URLARGGNN04]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Gift or Grant Print user's job title [URLARGGNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Gift or Grant Print User Name [URLARGGNN15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Gift or Grant Source [URLARGGNN19]
        /// </summary>
        public StringEnumValue<GiftGrantSource> Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// Gift or Grant From Title [URLARGGNN14]
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Gift or Grant From Fax [URLARGGNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Gift or Grant From Phone [URLARGGNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}