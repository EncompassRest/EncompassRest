using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Asset : IDirty
    {
        private Value<string> _accountIdentifier;
        public string AccountIdentifier { get { return _accountIdentifier; } set { _accountIdentifier = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<int?> _assetIndex;
        public int? AssetIndex { get { return _assetIndex; } set { _assetIndex = value; } }
        private Value<string> _assetType;
        public string AssetType { get { return _assetType; } set { _assetType = value; } }
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        private Value<string> _borrowerId;
        public string BorrowerId { get { return _borrowerId; } set { _borrowerId = value; } }
        private Value<decimal?> _cashOrMarketValueAmount;
        public decimal? CashOrMarketValueAmount { get { return _cashOrMarketValueAmount; } set { _cashOrMarketValueAmount = value; } }
        private Value<string> _depositoryAccountName;
        public string DepositoryAccountName { get { return _depositoryAccountName; } set { _depositoryAccountName = value; } }
        private Value<DateTime?> _depositoryRequestDate;
        public DateTime? DepositoryRequestDate { get { return _depositoryRequestDate; } set { _depositoryRequestDate = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _holderAddressCity;
        public string HolderAddressCity { get { return _holderAddressCity; } set { _holderAddressCity = value; } }
        private Value<string> _holderAddressPostalCode;
        public string HolderAddressPostalCode { get { return _holderAddressPostalCode; } set { _holderAddressPostalCode = value; } }
        private Value<string> _holderAddressState;
        public string HolderAddressState { get { return _holderAddressState; } set { _holderAddressState = value; } }
        private Value<string> _holderAddressStreetLine1;
        public string HolderAddressStreetLine1 { get { return _holderAddressStreetLine1; } set { _holderAddressStreetLine1 = value; } }
        private Value<string> _holderComments;
        public string HolderComments { get { return _holderComments; } set { _holderComments = value; } }
        private Value<string> _holderEmail;
        public string HolderEmail { get { return _holderEmail; } set { _holderEmail = value; } }
        private Value<string> _holderFax;
        public string HolderFax { get { return _holderFax; } set { _holderFax = value; } }
        private Value<string> _holderName;
        public string HolderName { get { return _holderName; } set { _holderName = value; } }
        private Value<string> _holderPhone;
        public string HolderPhone { get { return _holderPhone; } set { _holderPhone = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private Value<bool?> _isVod;
        public bool? IsVod { get { return _isVod; } set { _isVod = value; } }
        private Value<decimal?> _lifeInsuranceFaceValueAmount;
        public decimal? LifeInsuranceFaceValueAmount { get { return _lifeInsuranceFaceValueAmount; } set { _lifeInsuranceFaceValueAmount = value; } }
        private Value<string> _nameInAccount;
        public string NameInAccount { get { return _nameInAccount; } set { _nameInAccount = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private Value<int?> _vodIndex;
        public int? VodIndex { get { return _vodIndex; } set { _vodIndex = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _vodIndex.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}