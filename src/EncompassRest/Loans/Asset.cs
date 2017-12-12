#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Asset : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountIdentifier;
        public string AccountIdentifier { get => _accountIdentifier; set => _accountIdentifier = value; }
        private DirtyValue<string> _altId;
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<int?> _assetIndex;
        public int? AssetIndex { get => _assetIndex; set => _assetIndex = value; }
        private DirtyValue<StringEnumValue<AssetType>> _assetType;
        public StringEnumValue<AssetType> AssetType { get => _assetType; set => _assetType = value; }
        private DirtyValue<string> _attention;
        public string Attention { get => _attention; set => _attention = value; }
        private DirtyValue<string> _borrowerId;
        public string BorrowerId { get => _borrowerId; set => _borrowerId = value; }
        private DirtyValue<decimal?> _cashOrMarketValueAmount;
        public decimal? CashOrMarketValueAmount { get => _cashOrMarketValueAmount; set => _cashOrMarketValueAmount = value; }
        private DirtyValue<string> _depositoryAccountName;
        public string DepositoryAccountName { get => _depositoryAccountName; set => _depositoryAccountName = value; }
        private DirtyValue<DateTime?> _depositoryRequestDate;
        public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => _depositoryRequestDate = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _holderAddressCity;
        public string HolderAddressCity { get => _holderAddressCity; set => _holderAddressCity = value; }
        private DirtyValue<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get => _holderAddressPostalCode; set => _holderAddressPostalCode = value; }
        private DirtyValue<string> _holderAddressState;
        public string HolderAddressState { get => _holderAddressState; set => _holderAddressState = value; }
        private DirtyValue<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => _holderAddressStreetLine1 = value; }
        private DirtyValue<string> _holderComments;
        public string HolderComments { get => _holderComments; set => _holderComments = value; }
        private DirtyValue<string> _holderEmail;
        public string HolderEmail { get => _holderEmail; set => _holderEmail = value; }
        private DirtyValue<string> _holderFax;
        public string HolderFax { get => _holderFax; set => _holderFax = value; }
        private DirtyValue<string> _holderName;
        public string HolderName { get => _holderName; set => _holderName = value; }
        private DirtyValue<string> _holderPhone;
        public string HolderPhone { get => _holderPhone; set => _holderPhone = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<bool?> _isVod;
        public bool? IsVod { get => _isVod; set => _isVod = value; }
        private DirtyValue<decimal?> _lifeInsuranceFaceValueAmount;
        public decimal? LifeInsuranceFaceValueAmount { get => _lifeInsuranceFaceValueAmount; set => _lifeInsuranceFaceValueAmount = value; }
        private DirtyValue<string> _nameInAccount;
        public string NameInAccount { get => _nameInAccount; set => _nameInAccount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<StringEnumValue<Owner>> _owner;
        public StringEnumValue<Owner> Owner { get => _owner; set => _owner = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<int?> _vodIndex;
        public int? VodIndex { get => _vodIndex; set => _vodIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _accountIdentifier.Dirty
                    || _altId.Dirty
                    || _assetIndex.Dirty
                    || _assetType.Dirty
                    || _attention.Dirty
                    || _borrowerId.Dirty
                    || _cashOrMarketValueAmount.Dirty
                    || _depositoryAccountName.Dirty
                    || _depositoryRequestDate.Dirty
                    || _description.Dirty
                    || _entityDeleted.Dirty
                    || _holderAddressCity.Dirty
                    || _holderAddressPostalCode.Dirty
                    || _holderAddressState.Dirty
                    || _holderAddressStreetLine1.Dirty
                    || _holderComments.Dirty
                    || _holderEmail.Dirty
                    || _holderFax.Dirty
                    || _holderName.Dirty
                    || _holderPhone.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _isVod.Dirty
                    || _lifeInsuranceFaceValueAmount.Dirty
                    || _nameInAccount.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _owner.Dirty
                    || _printAttachmentIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty
                    || _total.Dirty
                    || _vodIndex.Dirty;
            }
            set
            {
                _accountIdentifier.Dirty = value;
                _altId.Dirty = value;
                _assetIndex.Dirty = value;
                _assetType.Dirty = value;
                _attention.Dirty = value;
                _borrowerId.Dirty = value;
                _cashOrMarketValueAmount.Dirty = value;
                _depositoryAccountName.Dirty = value;
                _depositoryRequestDate.Dirty = value;
                _description.Dirty = value;
                _entityDeleted.Dirty = value;
                _holderAddressCity.Dirty = value;
                _holderAddressPostalCode.Dirty = value;
                _holderAddressState.Dirty = value;
                _holderAddressStreetLine1.Dirty = value;
                _holderComments.Dirty = value;
                _holderEmail.Dirty = value;
                _holderFax.Dirty = value;
                _holderName.Dirty = value;
                _holderPhone.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _isVod.Dirty = value;
                _lifeInsuranceFaceValueAmount.Dirty = value;
                _nameInAccount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _owner.Dirty = value;
                _printAttachmentIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
                _total.Dirty = value;
                _vodIndex.Dirty = value;
            }
        }
    }
}