using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Asset : IDirty
    {
        private DirtyValue<string> _accountIdentifier;
        public string AccountIdentifier { get { return _accountIdentifier; } set { _accountIdentifier = value; } }
        private DirtyValue<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private DirtyValue<int?> _assetIndex;
        public int? AssetIndex { get { return _assetIndex; } set { _assetIndex = value; } }
        private StringEnumValue<AssetType> _assetType;
        public StringEnumValue<AssetType> AssetType { get { return _assetType; } set { _assetType = value; } }
        private DirtyValue<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        private DirtyValue<string> _borrowerId;
        public string BorrowerId { get { return _borrowerId; } set { _borrowerId = value; } }
        private DirtyValue<decimal?> _cashOrMarketValueAmount;
        public decimal? CashOrMarketValueAmount { get { return _cashOrMarketValueAmount; } set { _cashOrMarketValueAmount = value; } }
        private DirtyValue<string> _depositoryAccountName;
        public string DepositoryAccountName { get { return _depositoryAccountName; } set { _depositoryAccountName = value; } }
        private DirtyValue<DateTime?> _depositoryRequestDate;
        public DateTime? DepositoryRequestDate { get { return _depositoryRequestDate; } set { _depositoryRequestDate = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private DirtyValue<string> _holderAddressCity;
        public string HolderAddressCity { get { return _holderAddressCity; } set { _holderAddressCity = value; } }
        private DirtyValue<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get { return _holderAddressPostalCode; } set { _holderAddressPostalCode = value; } }
        private DirtyValue<string> _holderAddressState;
        public string HolderAddressState { get { return _holderAddressState; } set { _holderAddressState = value; } }
        private DirtyValue<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get { return _holderAddressStreetLine1; } set { _holderAddressStreetLine1 = value; } }
        private DirtyValue<string> _holderComments;
        public string HolderComments { get { return _holderComments; } set { _holderComments = value; } }
        private DirtyValue<string> _holderEmail;
        public string HolderEmail { get { return _holderEmail; } set { _holderEmail = value; } }
        private DirtyValue<string> _holderFax;
        public string HolderFax { get { return _holderFax; } set { _holderFax = value; } }
        private DirtyValue<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        private DirtyValue<string> _holderPhone;
        public string HolderPhone { get { return _holderPhone; } set { _holderPhone = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private DirtyValue<bool?> _isVod;
        public bool? IsVod { get { return _isVod; } set { _isVod = value; } }
        private DirtyValue<decimal?> _lifeInsuranceFaceValueAmount;
        public decimal? LifeInsuranceFaceValueAmount { get { return _lifeInsuranceFaceValueAmount; } set { _lifeInsuranceFaceValueAmount = value; } }
        private DirtyValue<string> _nameInAccount;
        public string NameInAccount { get { return _nameInAccount; } set { _nameInAccount = value; } }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private StringEnumValue<Owner> _owner;
        public StringEnumValue<Owner> Owner { get { return _owner; } set { _owner = value; } }
        private DirtyValue<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private DirtyValue<int?> _vodIndex;
        public int? VodIndex { get { return _vodIndex; } set { _vodIndex = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _accountIdentifier.Dirty
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
                    || _vodIndex.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}