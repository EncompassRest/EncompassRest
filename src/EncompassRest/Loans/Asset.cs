using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var accountIdentifier = _accountIdentifier; accountIdentifier.Clean = value; _accountIdentifier = accountIdentifier;
                var altId = _altId; altId.Clean = value; _altId = altId;
                var assetIndex = _assetIndex; assetIndex.Clean = value; _assetIndex = assetIndex;
                var assetType = _assetType; assetType.Clean = value; _assetType = assetType;
                var attention = _attention; attention.Clean = value; _attention = attention;
                var borrowerId = _borrowerId; borrowerId.Clean = value; _borrowerId = borrowerId;
                var cashOrMarketValueAmount = _cashOrMarketValueAmount; cashOrMarketValueAmount.Clean = value; _cashOrMarketValueAmount = cashOrMarketValueAmount;
                var depositoryAccountName = _depositoryAccountName; depositoryAccountName.Clean = value; _depositoryAccountName = depositoryAccountName;
                var depositoryRequestDate = _depositoryRequestDate; depositoryRequestDate.Clean = value; _depositoryRequestDate = depositoryRequestDate;
                var description = _description; description.Clean = value; _description = description;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var holderAddressCity = _holderAddressCity; holderAddressCity.Clean = value; _holderAddressCity = holderAddressCity;
                var holderAddressPostalCode = _holderAddressPostalCode; holderAddressPostalCode.Clean = value; _holderAddressPostalCode = holderAddressPostalCode;
                var holderAddressState = _holderAddressState; holderAddressState.Clean = value; _holderAddressState = holderAddressState;
                var holderAddressStreetLine1 = _holderAddressStreetLine1; holderAddressStreetLine1.Clean = value; _holderAddressStreetLine1 = holderAddressStreetLine1;
                var holderComments = _holderComments; holderComments.Clean = value; _holderComments = holderComments;
                var holderEmail = _holderEmail; holderEmail.Clean = value; _holderEmail = holderEmail;
                var holderFax = _holderFax; holderFax.Clean = value; _holderFax = holderFax;
                var holderName = _holderName; holderName.Clean = value; _holderName = holderName;
                var holderPhone = _holderPhone; holderPhone.Clean = value; _holderPhone = holderPhone;
                var id = _id; id.Clean = value; _id = id;
                var isEmpty = _isEmpty; isEmpty.Clean = value; _isEmpty = isEmpty;
                var isVod = _isVod; isVod.Clean = value; _isVod = isVod;
                var lifeInsuranceFaceValueAmount = _lifeInsuranceFaceValueAmount; lifeInsuranceFaceValueAmount.Clean = value; _lifeInsuranceFaceValueAmount = lifeInsuranceFaceValueAmount;
                var nameInAccount = _nameInAccount; nameInAccount.Clean = value; _nameInAccount = nameInAccount;
                var noLinkToDocTrackIndicator = _noLinkToDocTrackIndicator; noLinkToDocTrackIndicator.Clean = value; _noLinkToDocTrackIndicator = noLinkToDocTrackIndicator;
                var owner = _owner; owner.Clean = value; _owner = owner;
                var printAttachmentIndicator = _printAttachmentIndicator; printAttachmentIndicator.Clean = value; _printAttachmentIndicator = printAttachmentIndicator;
                var printUserNameIndicator = _printUserNameIndicator; printUserNameIndicator.Clean = value; _printUserNameIndicator = printUserNameIndicator;
                var title = _title; title.Clean = value; _title = title;
                var titleFax = _titleFax; titleFax.Clean = value; _titleFax = titleFax;
                var titlePhone = _titlePhone; titlePhone.Clean = value; _titlePhone = titlePhone;
                var total = _total; total.Clean = value; _total = total;
                var vodIndex = _vodIndex; vodIndex.Clean = value; _vodIndex = vodIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Asset()
        {
            Clean = true;
        }
    }
}