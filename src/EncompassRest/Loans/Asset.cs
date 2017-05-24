using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Asset
    {
        public Value<string> AccountIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountIdentifier() => !AccountIdentifier.Clean;
        public Value<string> AltId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !AltId.Clean;
        public Value<int?> AssetIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssetIndex() => !AssetIndex.Clean;
        public Value<string> AssetType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssetType() => !AssetType.Clean;
        public Value<string> Attention { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttention() => !Attention.Clean;
        public Value<string> BorrowerId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerId() => !BorrowerId.Clean;
        public Value<decimal?> CashOrMarketValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashOrMarketValueAmount() => !CashOrMarketValueAmount.Clean;
        public Value<string> DepositoryAccountName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDepositoryAccountName() => !DepositoryAccountName.Clean;
        public Value<DateTime?> DepositoryRequestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDepositoryRequestDate() => !DepositoryRequestDate.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<string> HolderAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressCity() => !HolderAddressCity.Clean;
        public Value<string> HolderAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressPostalCode() => !HolderAddressPostalCode.Clean;
        public Value<string> HolderAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressState() => !HolderAddressState.Clean;
        public Value<string> HolderAddressStreetLine1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderAddressStreetLine1() => !HolderAddressStreetLine1.Clean;
        public Value<string> HolderComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderComments() => !HolderComments.Clean;
        public Value<string> HolderEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderEmail() => !HolderEmail.Clean;
        public Value<string> HolderFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderFax() => !HolderFax.Clean;
        public Value<string> HolderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderName() => !HolderName.Clean;
        public Value<string> HolderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHolderPhone() => !HolderPhone.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEmpty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !IsEmpty.Clean;
        public Value<bool?> IsVod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsVod() => !IsVod.Clean;
        public Value<decimal?> LifeInsuranceFaceValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLifeInsuranceFaceValueAmount() => !LifeInsuranceFaceValueAmount.Clean;
        public Value<string> NameInAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameInAccount() => !NameInAccount.Clean;
        public Value<bool?> NoLinkToDocTrackIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !NoLinkToDocTrackIndicator.Clean;
        public Value<string> Owner { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !Owner.Clean;
        public Value<bool?> PrintAttachmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !PrintAttachmentIndicator.Clean;
        public Value<bool?> PrintUserNameIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !PrintUserNameIndicator.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !TitleFax.Clean;
        public Value<string> TitlePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !TitlePhone.Clean;
        public Value<decimal?> Total { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !Total.Clean;
        public Value<int?> VodIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVodIndex() => !VodIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccountIdentifier.Clean
                    && AltId.Clean
                    && AssetIndex.Clean
                    && AssetType.Clean
                    && Attention.Clean
                    && BorrowerId.Clean
                    && CashOrMarketValueAmount.Clean
                    && DepositoryAccountName.Clean
                    && DepositoryRequestDate.Clean
                    && Description.Clean
                    && EntityDeleted.Clean
                    && HolderAddressCity.Clean
                    && HolderAddressPostalCode.Clean
                    && HolderAddressState.Clean
                    && HolderAddressStreetLine1.Clean
                    && HolderComments.Clean
                    && HolderEmail.Clean
                    && HolderFax.Clean
                    && HolderName.Clean
                    && HolderPhone.Clean
                    && Id.Clean
                    && IsEmpty.Clean
                    && IsVod.Clean
                    && LifeInsuranceFaceValueAmount.Clean
                    && NameInAccount.Clean
                    && NoLinkToDocTrackIndicator.Clean
                    && Owner.Clean
                    && PrintAttachmentIndicator.Clean
                    && PrintUserNameIndicator.Clean
                    && Title.Clean
                    && TitleFax.Clean
                    && TitlePhone.Clean
                    && Total.Clean
                    && VodIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountIdentifier; v0.Clean = value; AccountIdentifier = v0;
                var v1 = AltId; v1.Clean = value; AltId = v1;
                var v2 = AssetIndex; v2.Clean = value; AssetIndex = v2;
                var v3 = AssetType; v3.Clean = value; AssetType = v3;
                var v4 = Attention; v4.Clean = value; Attention = v4;
                var v5 = BorrowerId; v5.Clean = value; BorrowerId = v5;
                var v6 = CashOrMarketValueAmount; v6.Clean = value; CashOrMarketValueAmount = v6;
                var v7 = DepositoryAccountName; v7.Clean = value; DepositoryAccountName = v7;
                var v8 = DepositoryRequestDate; v8.Clean = value; DepositoryRequestDate = v8;
                var v9 = Description; v9.Clean = value; Description = v9;
                var v10 = EntityDeleted; v10.Clean = value; EntityDeleted = v10;
                var v11 = HolderAddressCity; v11.Clean = value; HolderAddressCity = v11;
                var v12 = HolderAddressPostalCode; v12.Clean = value; HolderAddressPostalCode = v12;
                var v13 = HolderAddressState; v13.Clean = value; HolderAddressState = v13;
                var v14 = HolderAddressStreetLine1; v14.Clean = value; HolderAddressStreetLine1 = v14;
                var v15 = HolderComments; v15.Clean = value; HolderComments = v15;
                var v16 = HolderEmail; v16.Clean = value; HolderEmail = v16;
                var v17 = HolderFax; v17.Clean = value; HolderFax = v17;
                var v18 = HolderName; v18.Clean = value; HolderName = v18;
                var v19 = HolderPhone; v19.Clean = value; HolderPhone = v19;
                var v20 = Id; v20.Clean = value; Id = v20;
                var v21 = IsEmpty; v21.Clean = value; IsEmpty = v21;
                var v22 = IsVod; v22.Clean = value; IsVod = v22;
                var v23 = LifeInsuranceFaceValueAmount; v23.Clean = value; LifeInsuranceFaceValueAmount = v23;
                var v24 = NameInAccount; v24.Clean = value; NameInAccount = v24;
                var v25 = NoLinkToDocTrackIndicator; v25.Clean = value; NoLinkToDocTrackIndicator = v25;
                var v26 = Owner; v26.Clean = value; Owner = v26;
                var v27 = PrintAttachmentIndicator; v27.Clean = value; PrintAttachmentIndicator = v27;
                var v28 = PrintUserNameIndicator; v28.Clean = value; PrintUserNameIndicator = v28;
                var v29 = Title; v29.Clean = value; Title = v29;
                var v30 = TitleFax; v30.Clean = value; TitleFax = v30;
                var v31 = TitlePhone; v31.Clean = value; TitlePhone = v31;
                var v32 = Total; v32.Clean = value; Total = v32;
                var v33 = VodIndex; v33.Clean = value; VodIndex = v33;
                _settingClean = 0;
            }
        }
    }
}