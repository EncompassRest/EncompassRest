using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Asset : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountIdentifier.Clean
                    && _altId.Clean
                    && _assetIndex.Clean
                    && _assetType.Clean
                    && _attention.Clean
                    && _borrowerId.Clean
                    && _cashOrMarketValueAmount.Clean
                    && _depositoryAccountName.Clean
                    && _depositoryRequestDate.Clean
                    && _description.Clean
                    && _entityDeleted.Clean
                    && _holderAddressCity.Clean
                    && _holderAddressPostalCode.Clean
                    && _holderAddressState.Clean
                    && _holderAddressStreetLine1.Clean
                    && _holderComments.Clean
                    && _holderEmail.Clean
                    && _holderFax.Clean
                    && _holderName.Clean
                    && _holderPhone.Clean
                    && _id.Clean
                    && _isEmpty.Clean
                    && _isVod.Clean
                    && _lifeInsuranceFaceValueAmount.Clean
                    && _nameInAccount.Clean
                    && _noLinkToDocTrackIndicator.Clean
                    && _owner.Clean
                    && _printAttachmentIndicator.Clean
                    && _printUserNameIndicator.Clean
                    && _title.Clean
                    && _titleFax.Clean
                    && _titlePhone.Clean
                    && _total.Clean
                    && _vodIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _accountIdentifier; v0.Clean = value; _accountIdentifier = v0;
                var v1 = _altId; v1.Clean = value; _altId = v1;
                var v2 = _assetIndex; v2.Clean = value; _assetIndex = v2;
                var v3 = _assetType; v3.Clean = value; _assetType = v3;
                var v4 = _attention; v4.Clean = value; _attention = v4;
                var v5 = _borrowerId; v5.Clean = value; _borrowerId = v5;
                var v6 = _cashOrMarketValueAmount; v6.Clean = value; _cashOrMarketValueAmount = v6;
                var v7 = _depositoryAccountName; v7.Clean = value; _depositoryAccountName = v7;
                var v8 = _depositoryRequestDate; v8.Clean = value; _depositoryRequestDate = v8;
                var v9 = _description; v9.Clean = value; _description = v9;
                var v10 = _entityDeleted; v10.Clean = value; _entityDeleted = v10;
                var v11 = _holderAddressCity; v11.Clean = value; _holderAddressCity = v11;
                var v12 = _holderAddressPostalCode; v12.Clean = value; _holderAddressPostalCode = v12;
                var v13 = _holderAddressState; v13.Clean = value; _holderAddressState = v13;
                var v14 = _holderAddressStreetLine1; v14.Clean = value; _holderAddressStreetLine1 = v14;
                var v15 = _holderComments; v15.Clean = value; _holderComments = v15;
                var v16 = _holderEmail; v16.Clean = value; _holderEmail = v16;
                var v17 = _holderFax; v17.Clean = value; _holderFax = v17;
                var v18 = _holderName; v18.Clean = value; _holderName = v18;
                var v19 = _holderPhone; v19.Clean = value; _holderPhone = v19;
                var v20 = _id; v20.Clean = value; _id = v20;
                var v21 = _isEmpty; v21.Clean = value; _isEmpty = v21;
                var v22 = _isVod; v22.Clean = value; _isVod = v22;
                var v23 = _lifeInsuranceFaceValueAmount; v23.Clean = value; _lifeInsuranceFaceValueAmount = v23;
                var v24 = _nameInAccount; v24.Clean = value; _nameInAccount = v24;
                var v25 = _noLinkToDocTrackIndicator; v25.Clean = value; _noLinkToDocTrackIndicator = v25;
                var v26 = _owner; v26.Clean = value; _owner = v26;
                var v27 = _printAttachmentIndicator; v27.Clean = value; _printAttachmentIndicator = v27;
                var v28 = _printUserNameIndicator; v28.Clean = value; _printUserNameIndicator = v28;
                var v29 = _title; v29.Clean = value; _title = v29;
                var v30 = _titleFax; v30.Clean = value; _titleFax = v30;
                var v31 = _titlePhone; v31.Clean = value; _titlePhone = v31;
                var v32 = _total; v32.Clean = value; _total = v32;
                var v33 = _vodIndex; v33.Clean = value; _vodIndex = v33;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}