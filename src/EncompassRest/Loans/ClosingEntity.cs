using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingEntity
    {
        public Value<string> Alias { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlias() => !Alias.Clean;
        public Value<string> Assignee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssignee() => !Assignee.Clean;
        public Value<bool?> AuthorizedToSignIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAuthorizedToSignIndicator() => !AuthorizedToSignIndicator.Clean;
        public Value<string> BorrowerPair { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPair() => !BorrowerPair.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ClosingEntityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingEntityType() => !ClosingEntityType.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> County { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !County.Clean;
        public Value<DateTime?> DateOfBirth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfBirth() => !DateOfBirth.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> OccupancyIntent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancyIntent() => !OccupancyIntent.Clean;
        public Value<string> OccupancyStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancyStatus() => !OccupancyStatus.Clean;
        public Value<string> OrganizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationType() => !OrganizationType.Clean;
        public Value<string> OrganizedUnderTheLawsOfJurisdictionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizedUnderTheLawsOfJurisdictionName() => !OrganizedUnderTheLawsOfJurisdictionName.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> Phone1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone1() => !Phone1.Clean;
        public Value<string> Phone2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone2() => !Phone2.Clean;
        public Value<string> PoaSignatureText { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoaSignatureText() => !PoaSignatureText.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> PowerOfAttorney { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePowerOfAttorney() => !PowerOfAttorney.Clean;
        public Value<DateTime?> RecordableDocumentTrustDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordableDocumentTrustDate() => !RecordableDocumentTrustDate.Clean;
        public Value<string> RecordCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordCity() => !RecordCity.Clean;
        public Value<string> Ssn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSsn() => !Ssn.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> StreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress() => !StreetAddress.Clean;
        public Value<string> TaxIdentificationNumberIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxIdentificationNumberIdentifier() => !TaxIdentificationNumberIdentifier.Clean;
        public Value<string> TrustOfficerName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustOfficerName1() => !TrustOfficerName1.Clean;
        public Value<string> TrustOfficerName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustOfficerName2() => !TrustOfficerName2.Clean;
        public Value<string> TrustOfficerTitle1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustOfficerTitle1() => !TrustOfficerTitle1.Clean;
        public Value<string> TrustOfficerTitle2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustOfficerTitle2() => !TrustOfficerTitle2.Clean;
        public Value<string> UnparsedName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnparsedName() => !UnparsedName.Clean;
        public Value<string> Vesting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVesting() => !Vesting.Clean;
        public Value<string> VestingGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVestingGuid() => !VestingGuid.Clean;
        public Value<string> VestingTrusteeOfType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVestingTrusteeOfType() => !VestingTrusteeOfType.Clean;
        public Value<string> VestingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVestingType() => !VestingType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Alias.Clean
                    && Assignee.Clean
                    && AuthorizedToSignIndicator.Clean
                    && BorrowerPair.Clean
                    && City.Clean
                    && ClosingEntityType.Clean
                    && Comments.Clean
                    && County.Clean
                    && DateOfBirth.Clean
                    && Fax.Clean
                    && Id.Clean
                    && OccupancyIntent.Clean
                    && OccupancyStatus.Clean
                    && OrganizationType.Clean
                    && OrganizedUnderTheLawsOfJurisdictionName.Clean
                    && Phone.Clean
                    && Phone1.Clean
                    && Phone2.Clean
                    && PoaSignatureText.Clean
                    && PostalCode.Clean
                    && PowerOfAttorney.Clean
                    && RecordableDocumentTrustDate.Clean
                    && RecordCity.Clean
                    && Ssn.Clean
                    && State.Clean
                    && StreetAddress.Clean
                    && TaxIdentificationNumberIdentifier.Clean
                    && TrustOfficerName1.Clean
                    && TrustOfficerName2.Clean
                    && TrustOfficerTitle1.Clean
                    && TrustOfficerTitle2.Clean
                    && UnparsedName.Clean
                    && Vesting.Clean
                    && VestingGuid.Clean
                    && VestingTrusteeOfType.Clean
                    && VestingType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Alias; v0.Clean = value; Alias = v0;
                var v1 = Assignee; v1.Clean = value; Assignee = v1;
                var v2 = AuthorizedToSignIndicator; v2.Clean = value; AuthorizedToSignIndicator = v2;
                var v3 = BorrowerPair; v3.Clean = value; BorrowerPair = v3;
                var v4 = City; v4.Clean = value; City = v4;
                var v5 = ClosingEntityType; v5.Clean = value; ClosingEntityType = v5;
                var v6 = Comments; v6.Clean = value; Comments = v6;
                var v7 = County; v7.Clean = value; County = v7;
                var v8 = DateOfBirth; v8.Clean = value; DateOfBirth = v8;
                var v9 = Fax; v9.Clean = value; Fax = v9;
                var v10 = Id; v10.Clean = value; Id = v10;
                var v11 = OccupancyIntent; v11.Clean = value; OccupancyIntent = v11;
                var v12 = OccupancyStatus; v12.Clean = value; OccupancyStatus = v12;
                var v13 = OrganizationType; v13.Clean = value; OrganizationType = v13;
                var v14 = OrganizedUnderTheLawsOfJurisdictionName; v14.Clean = value; OrganizedUnderTheLawsOfJurisdictionName = v14;
                var v15 = Phone; v15.Clean = value; Phone = v15;
                var v16 = Phone1; v16.Clean = value; Phone1 = v16;
                var v17 = Phone2; v17.Clean = value; Phone2 = v17;
                var v18 = PoaSignatureText; v18.Clean = value; PoaSignatureText = v18;
                var v19 = PostalCode; v19.Clean = value; PostalCode = v19;
                var v20 = PowerOfAttorney; v20.Clean = value; PowerOfAttorney = v20;
                var v21 = RecordableDocumentTrustDate; v21.Clean = value; RecordableDocumentTrustDate = v21;
                var v22 = RecordCity; v22.Clean = value; RecordCity = v22;
                var v23 = Ssn; v23.Clean = value; Ssn = v23;
                var v24 = State; v24.Clean = value; State = v24;
                var v25 = StreetAddress; v25.Clean = value; StreetAddress = v25;
                var v26 = TaxIdentificationNumberIdentifier; v26.Clean = value; TaxIdentificationNumberIdentifier = v26;
                var v27 = TrustOfficerName1; v27.Clean = value; TrustOfficerName1 = v27;
                var v28 = TrustOfficerName2; v28.Clean = value; TrustOfficerName2 = v28;
                var v29 = TrustOfficerTitle1; v29.Clean = value; TrustOfficerTitle1 = v29;
                var v30 = TrustOfficerTitle2; v30.Clean = value; TrustOfficerTitle2 = v30;
                var v31 = UnparsedName; v31.Clean = value; UnparsedName = v31;
                var v32 = Vesting; v32.Clean = value; Vesting = v32;
                var v33 = VestingGuid; v33.Clean = value; VestingGuid = v33;
                var v34 = VestingTrusteeOfType; v34.Clean = value; VestingTrusteeOfType = v34;
                var v35 = VestingType; v35.Clean = value; VestingType = v35;
                _settingClean = 0;
            }
        }
    }
}