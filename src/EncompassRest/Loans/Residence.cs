using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Residence
    {
        public Value<string> AccountName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountName() => !AccountName.Clean;
        public Value<string> AddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressCity() => !AddressCity.Clean;
        public Value<string> AddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressPostalCode() => !AddressPostalCode.Clean;
        public Value<string> AddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressState() => !AddressState.Clean;
        public Value<string> AddressStreetLine1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressStreetLine1() => !AddressStreetLine1.Clean;
        public Value<string> AltId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !AltId.Clean;
        public Value<string> ApplicantType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantType() => !ApplicantType.Clean;
        public Value<string> County { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !County.Clean;
        public Value<int?> DurationTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationTermMonths() => !DurationTermMonths.Clean;
        public Value<int?> DurationTermYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationTermYears() => !DurationTermYears.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LandlordAttention { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordAttention() => !LandlordAttention.Clean;
        public Value<string> LandlordCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordCity() => !LandlordCity.Clean;
        public Value<string> LandlordComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordComments() => !LandlordComments.Clean;
        public Value<string> LandlordEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordEmail() => !LandlordEmail.Clean;
        public Value<string> LandlordFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordFax() => !LandlordFax.Clean;
        public Value<string> LandlordName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordName() => !LandlordName.Clean;
        public Value<string> LandlordPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordPhone() => !LandlordPhone.Clean;
        public Value<string> LandlordPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordPostalCode() => !LandlordPostalCode.Clean;
        public Value<string> LandlordState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordState() => !LandlordState.Clean;
        public Value<string> LandlordStreet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordStreet() => !LandlordStreet.Clean;
        public Value<bool?> MailingAddressIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingAddressIndicator() => !MailingAddressIndicator.Clean;
        public Value<bool?> NoLinkToDocTrackIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !NoLinkToDocTrackIndicator.Clean;
        public Value<bool?> PrintAttachmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !PrintAttachmentIndicator.Clean;
        public Value<bool?> PrintUserNameIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !PrintUserNameIndicator.Clean;
        public Value<int?> Rent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRent() => !Rent.Clean;
        public Value<DateTime?> RequestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestDate() => !RequestDate.Clean;
        public Value<string> ResidencyBasisType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyBasisType() => !ResidencyBasisType.Clean;
        public Value<string> ResidencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyType() => !ResidencyType.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !TitleFax.Clean;
        public Value<string> TitlePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !TitlePhone.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccountName.Clean
                    && AddressCity.Clean
                    && AddressPostalCode.Clean
                    && AddressState.Clean
                    && AddressStreetLine1.Clean
                    && AltId.Clean
                    && ApplicantType.Clean
                    && County.Clean
                    && DurationTermMonths.Clean
                    && DurationTermYears.Clean
                    && EntityDeleted.Clean
                    && Id.Clean
                    && LandlordAttention.Clean
                    && LandlordCity.Clean
                    && LandlordComments.Clean
                    && LandlordEmail.Clean
                    && LandlordFax.Clean
                    && LandlordName.Clean
                    && LandlordPhone.Clean
                    && LandlordPostalCode.Clean
                    && LandlordState.Clean
                    && LandlordStreet.Clean
                    && MailingAddressIndicator.Clean
                    && NoLinkToDocTrackIndicator.Clean
                    && PrintAttachmentIndicator.Clean
                    && PrintUserNameIndicator.Clean
                    && Rent.Clean
                    && RequestDate.Clean
                    && ResidencyBasisType.Clean
                    && ResidencyType.Clean
                    && Title.Clean
                    && TitleFax.Clean
                    && TitlePhone.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountName; v0.Clean = value; AccountName = v0;
                var v1 = AddressCity; v1.Clean = value; AddressCity = v1;
                var v2 = AddressPostalCode; v2.Clean = value; AddressPostalCode = v2;
                var v3 = AddressState; v3.Clean = value; AddressState = v3;
                var v4 = AddressStreetLine1; v4.Clean = value; AddressStreetLine1 = v4;
                var v5 = AltId; v5.Clean = value; AltId = v5;
                var v6 = ApplicantType; v6.Clean = value; ApplicantType = v6;
                var v7 = County; v7.Clean = value; County = v7;
                var v8 = DurationTermMonths; v8.Clean = value; DurationTermMonths = v8;
                var v9 = DurationTermYears; v9.Clean = value; DurationTermYears = v9;
                var v10 = EntityDeleted; v10.Clean = value; EntityDeleted = v10;
                var v11 = Id; v11.Clean = value; Id = v11;
                var v12 = LandlordAttention; v12.Clean = value; LandlordAttention = v12;
                var v13 = LandlordCity; v13.Clean = value; LandlordCity = v13;
                var v14 = LandlordComments; v14.Clean = value; LandlordComments = v14;
                var v15 = LandlordEmail; v15.Clean = value; LandlordEmail = v15;
                var v16 = LandlordFax; v16.Clean = value; LandlordFax = v16;
                var v17 = LandlordName; v17.Clean = value; LandlordName = v17;
                var v18 = LandlordPhone; v18.Clean = value; LandlordPhone = v18;
                var v19 = LandlordPostalCode; v19.Clean = value; LandlordPostalCode = v19;
                var v20 = LandlordState; v20.Clean = value; LandlordState = v20;
                var v21 = LandlordStreet; v21.Clean = value; LandlordStreet = v21;
                var v22 = MailingAddressIndicator; v22.Clean = value; MailingAddressIndicator = v22;
                var v23 = NoLinkToDocTrackIndicator; v23.Clean = value; NoLinkToDocTrackIndicator = v23;
                var v24 = PrintAttachmentIndicator; v24.Clean = value; PrintAttachmentIndicator = v24;
                var v25 = PrintUserNameIndicator; v25.Clean = value; PrintUserNameIndicator = v25;
                var v26 = Rent; v26.Clean = value; Rent = v26;
                var v27 = RequestDate; v27.Clean = value; RequestDate = v27;
                var v28 = ResidencyBasisType; v28.Clean = value; ResidencyBasisType = v28;
                var v29 = ResidencyType; v29.Clean = value; ResidencyType = v29;
                var v30 = Title; v30.Clean = value; Title = v30;
                var v31 = TitleFax; v31.Clean = value; TitleFax = v31;
                var v32 = TitlePhone; v32.Clean = value; TitlePhone = v32;
                _settingClean = 0;
            }
        }
    }
}