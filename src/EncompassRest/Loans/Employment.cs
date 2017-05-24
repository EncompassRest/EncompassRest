using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Employment
    {
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
        public Value<string> Attention { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttention() => !Attention.Clean;
        public Value<string> BadgeOrEmployeeID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBadgeOrEmployeeID() => !BadgeOrEmployeeID.Clean;
        public Value<decimal?> BasePayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePayAmount() => !BasePayAmount.Clean;
        public Value<decimal?> BonusAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusAmount() => !BonusAmount.Clean;
        public Value<string> BusinessName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessName() => !BusinessName.Clean;
        public Value<decimal?> BusinessOwnedPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessOwnedPercent() => !BusinessOwnedPercent.Clean;
        public Value<string> BusinessPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessPhone() => !BusinessPhone.Clean;
        public Value<decimal?> CommissionsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommissionsAmount() => !CommissionsAmount.Clean;
        public Value<bool?> CurrentEmploymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentEmploymentIndicator() => !CurrentEmploymentIndicator.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<string> EmployerComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerComments() => !EmployerComments.Clean;
        public Value<string> EmployerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerName() => !EmployerName.Clean;
        public Value<DateTime?> EndDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndDate() => !EndDate.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> MonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyIncomeAmount() => !MonthlyIncomeAmount.Clean;
        public Value<bool?> NoLinkToDocTrackIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !NoLinkToDocTrackIndicator.Clean;
        public Value<decimal?> OtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmount() => !OtherAmount.Clean;
        public Value<decimal?> OvertimeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOvertimeAmount() => !OvertimeAmount.Clean;
        public Value<string> Owner { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !Owner.Clean;
        public Value<string> PhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhoneNumber() => !PhoneNumber.Clean;
        public Value<string> PositionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePositionDescription() => !PositionDescription.Clean;
        public Value<bool?> PrintAttachmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !PrintAttachmentIndicator.Clean;
        public Value<bool?> PrintUserNameIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !PrintUserNameIndicator.Clean;
        public Value<bool?> SelfEmployedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelfEmployedIndicator() => !SelfEmployedIndicator.Clean;
        public Value<DateTime?> StartDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartDate() => !StartDate.Clean;
        public Value<int?> TimeInLineOfWorkMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeInLineOfWorkMonths() => !TimeInLineOfWorkMonths.Clean;
        public Value<int?> TimeInLineOfWorkYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeInLineOfWorkYears() => !TimeInLineOfWorkYears.Clean;
        public Value<int?> TimeOnJobTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeOnJobTermMonths() => !TimeOnJobTermMonths.Clean;
        public Value<int?> TimeOnJobTermYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeOnJobTermYears() => !TimeOnJobTermYears.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !TitleFax.Clean;
        public Value<string> TitlePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !TitlePhone.Clean;
        public Value<DateTime?> VerificationRequestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationRequestDate() => !VerificationRequestDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AddressCity.Clean
                    && AddressPostalCode.Clean
                    && AddressState.Clean
                    && AddressStreetLine1.Clean
                    && AltId.Clean
                    && Attention.Clean
                    && BadgeOrEmployeeID.Clean
                    && BasePayAmount.Clean
                    && BonusAmount.Clean
                    && BusinessName.Clean
                    && BusinessOwnedPercent.Clean
                    && BusinessPhone.Clean
                    && CommissionsAmount.Clean
                    && CurrentEmploymentIndicator.Clean
                    && Email.Clean
                    && EmployerComments.Clean
                    && EmployerName.Clean
                    && EndDate.Clean
                    && EntityDeleted.Clean
                    && Fax.Clean
                    && Id.Clean
                    && MonthlyIncomeAmount.Clean
                    && NoLinkToDocTrackIndicator.Clean
                    && OtherAmount.Clean
                    && OvertimeAmount.Clean
                    && Owner.Clean
                    && PhoneNumber.Clean
                    && PositionDescription.Clean
                    && PrintAttachmentIndicator.Clean
                    && PrintUserNameIndicator.Clean
                    && SelfEmployedIndicator.Clean
                    && StartDate.Clean
                    && TimeInLineOfWorkMonths.Clean
                    && TimeInLineOfWorkYears.Clean
                    && TimeOnJobTermMonths.Clean
                    && TimeOnJobTermYears.Clean
                    && Title.Clean
                    && TitleFax.Clean
                    && TitlePhone.Clean
                    && VerificationRequestDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddressCity; v0.Clean = value; AddressCity = v0;
                var v1 = AddressPostalCode; v1.Clean = value; AddressPostalCode = v1;
                var v2 = AddressState; v2.Clean = value; AddressState = v2;
                var v3 = AddressStreetLine1; v3.Clean = value; AddressStreetLine1 = v3;
                var v4 = AltId; v4.Clean = value; AltId = v4;
                var v5 = Attention; v5.Clean = value; Attention = v5;
                var v6 = BadgeOrEmployeeID; v6.Clean = value; BadgeOrEmployeeID = v6;
                var v7 = BasePayAmount; v7.Clean = value; BasePayAmount = v7;
                var v8 = BonusAmount; v8.Clean = value; BonusAmount = v8;
                var v9 = BusinessName; v9.Clean = value; BusinessName = v9;
                var v10 = BusinessOwnedPercent; v10.Clean = value; BusinessOwnedPercent = v10;
                var v11 = BusinessPhone; v11.Clean = value; BusinessPhone = v11;
                var v12 = CommissionsAmount; v12.Clean = value; CommissionsAmount = v12;
                var v13 = CurrentEmploymentIndicator; v13.Clean = value; CurrentEmploymentIndicator = v13;
                var v14 = Email; v14.Clean = value; Email = v14;
                var v15 = EmployerComments; v15.Clean = value; EmployerComments = v15;
                var v16 = EmployerName; v16.Clean = value; EmployerName = v16;
                var v17 = EndDate; v17.Clean = value; EndDate = v17;
                var v18 = EntityDeleted; v18.Clean = value; EntityDeleted = v18;
                var v19 = Fax; v19.Clean = value; Fax = v19;
                var v20 = Id; v20.Clean = value; Id = v20;
                var v21 = MonthlyIncomeAmount; v21.Clean = value; MonthlyIncomeAmount = v21;
                var v22 = NoLinkToDocTrackIndicator; v22.Clean = value; NoLinkToDocTrackIndicator = v22;
                var v23 = OtherAmount; v23.Clean = value; OtherAmount = v23;
                var v24 = OvertimeAmount; v24.Clean = value; OvertimeAmount = v24;
                var v25 = Owner; v25.Clean = value; Owner = v25;
                var v26 = PhoneNumber; v26.Clean = value; PhoneNumber = v26;
                var v27 = PositionDescription; v27.Clean = value; PositionDescription = v27;
                var v28 = PrintAttachmentIndicator; v28.Clean = value; PrintAttachmentIndicator = v28;
                var v29 = PrintUserNameIndicator; v29.Clean = value; PrintUserNameIndicator = v29;
                var v30 = SelfEmployedIndicator; v30.Clean = value; SelfEmployedIndicator = v30;
                var v31 = StartDate; v31.Clean = value; StartDate = v31;
                var v32 = TimeInLineOfWorkMonths; v32.Clean = value; TimeInLineOfWorkMonths = v32;
                var v33 = TimeInLineOfWorkYears; v33.Clean = value; TimeInLineOfWorkYears = v33;
                var v34 = TimeOnJobTermMonths; v34.Clean = value; TimeOnJobTermMonths = v34;
                var v35 = TimeOnJobTermYears; v35.Clean = value; TimeOnJobTermYears = v35;
                var v36 = Title; v36.Clean = value; Title = v36;
                var v37 = TitleFax; v37.Clean = value; TitleFax = v37;
                var v38 = TitlePhone; v38.Clean = value; TitlePhone = v38;
                var v39 = VerificationRequestDate; v39.Clean = value; VerificationRequestDate = v39;
                _settingClean = 0;
            }
        }
    }
}