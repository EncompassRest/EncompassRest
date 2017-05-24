using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Employment
    {
        private Value<string> _addressCity;
        public string AddressCity { get { return _addressCity; } set { _addressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressCity() => !_addressCity.Clean;
        private Value<string> _addressPostalCode;
        public string AddressPostalCode { get { return _addressPostalCode; } set { _addressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressPostalCode() => !_addressPostalCode.Clean;
        private Value<string> _addressState;
        public string AddressState { get { return _addressState; } set { _addressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressState() => !_addressState.Clean;
        private Value<string> _addressStreetLine1;
        public string AddressStreetLine1 { get { return _addressStreetLine1; } set { _addressStreetLine1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressStreetLine1() => !_addressStreetLine1.Clean;
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !_altId.Clean;
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttention() => !_attention.Clean;
        private Value<string> _badgeOrEmployeeID;
        public string BadgeOrEmployeeID { get { return _badgeOrEmployeeID; } set { _badgeOrEmployeeID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBadgeOrEmployeeID() => !_badgeOrEmployeeID.Clean;
        private Value<decimal?> _basePayAmount;
        public decimal? BasePayAmount { get { return _basePayAmount; } set { _basePayAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePayAmount() => !_basePayAmount.Clean;
        private Value<decimal?> _bonusAmount;
        public decimal? BonusAmount { get { return _bonusAmount; } set { _bonusAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusAmount() => !_bonusAmount.Clean;
        private Value<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessName() => !_businessName.Clean;
        private Value<decimal?> _businessOwnedPercent;
        public decimal? BusinessOwnedPercent { get { return _businessOwnedPercent; } set { _businessOwnedPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessOwnedPercent() => !_businessOwnedPercent.Clean;
        private Value<string> _businessPhone;
        public string BusinessPhone { get { return _businessPhone; } set { _businessPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessPhone() => !_businessPhone.Clean;
        private Value<decimal?> _commissionsAmount;
        public decimal? CommissionsAmount { get { return _commissionsAmount; } set { _commissionsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommissionsAmount() => !_commissionsAmount.Clean;
        private Value<bool?> _currentEmploymentIndicator;
        public bool? CurrentEmploymentIndicator { get { return _currentEmploymentIndicator; } set { _currentEmploymentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentEmploymentIndicator() => !_currentEmploymentIndicator.Clean;
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !_email.Clean;
        private Value<string> _employerComments;
        public string EmployerComments { get { return _employerComments; } set { _employerComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerComments() => !_employerComments.Clean;
        private Value<string> _employerName;
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerName() => !_employerName.Clean;
        private Value<DateTime?> _endDate;
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndDate() => !_endDate.Clean;
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !_entityDeleted.Clean;
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !_fax.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<int?> _monthlyIncomeAmount;
        public int? MonthlyIncomeAmount { get { return _monthlyIncomeAmount; } set { _monthlyIncomeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyIncomeAmount() => !_monthlyIncomeAmount.Clean;
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !_noLinkToDocTrackIndicator.Clean;
        private Value<decimal?> _otherAmount;
        public decimal? OtherAmount { get { return _otherAmount; } set { _otherAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmount() => !_otherAmount.Clean;
        private Value<decimal?> _overtimeAmount;
        public decimal? OvertimeAmount { get { return _overtimeAmount; } set { _overtimeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOvertimeAmount() => !_overtimeAmount.Clean;
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwner() => !_owner.Clean;
        private Value<string> _phoneNumber;
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhoneNumber() => !_phoneNumber.Clean;
        private Value<string> _positionDescription;
        public string PositionDescription { get { return _positionDescription; } set { _positionDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePositionDescription() => !_positionDescription.Clean;
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !_printAttachmentIndicator.Clean;
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !_printUserNameIndicator.Clean;
        private Value<bool?> _selfEmployedIndicator;
        public bool? SelfEmployedIndicator { get { return _selfEmployedIndicator; } set { _selfEmployedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelfEmployedIndicator() => !_selfEmployedIndicator.Clean;
        private Value<DateTime?> _startDate;
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartDate() => !_startDate.Clean;
        private Value<int?> _timeInLineOfWorkMonths;
        public int? TimeInLineOfWorkMonths { get { return _timeInLineOfWorkMonths; } set { _timeInLineOfWorkMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeInLineOfWorkMonths() => !_timeInLineOfWorkMonths.Clean;
        private Value<int?> _timeInLineOfWorkYears;
        public int? TimeInLineOfWorkYears { get { return _timeInLineOfWorkYears; } set { _timeInLineOfWorkYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeInLineOfWorkYears() => !_timeInLineOfWorkYears.Clean;
        private Value<int?> _timeOnJobTermMonths;
        public int? TimeOnJobTermMonths { get { return _timeOnJobTermMonths; } set { _timeOnJobTermMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeOnJobTermMonths() => !_timeOnJobTermMonths.Clean;
        private Value<int?> _timeOnJobTermYears;
        public int? TimeOnJobTermYears { get { return _timeOnJobTermYears; } set { _timeOnJobTermYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeOnJobTermYears() => !_timeOnJobTermYears.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !_titleFax.Clean;
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !_titlePhone.Clean;
        private Value<DateTime?> _verificationRequestDate;
        public DateTime? VerificationRequestDate { get { return _verificationRequestDate; } set { _verificationRequestDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationRequestDate() => !_verificationRequestDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addressCity.Clean
                    && _addressPostalCode.Clean
                    && _addressState.Clean
                    && _addressStreetLine1.Clean
                    && _altId.Clean
                    && _attention.Clean
                    && _badgeOrEmployeeID.Clean
                    && _basePayAmount.Clean
                    && _bonusAmount.Clean
                    && _businessName.Clean
                    && _businessOwnedPercent.Clean
                    && _businessPhone.Clean
                    && _commissionsAmount.Clean
                    && _currentEmploymentIndicator.Clean
                    && _email.Clean
                    && _employerComments.Clean
                    && _employerName.Clean
                    && _endDate.Clean
                    && _entityDeleted.Clean
                    && _fax.Clean
                    && _id.Clean
                    && _monthlyIncomeAmount.Clean
                    && _noLinkToDocTrackIndicator.Clean
                    && _otherAmount.Clean
                    && _overtimeAmount.Clean
                    && _owner.Clean
                    && _phoneNumber.Clean
                    && _positionDescription.Clean
                    && _printAttachmentIndicator.Clean
                    && _printUserNameIndicator.Clean
                    && _selfEmployedIndicator.Clean
                    && _startDate.Clean
                    && _timeInLineOfWorkMonths.Clean
                    && _timeInLineOfWorkYears.Clean
                    && _timeOnJobTermMonths.Clean
                    && _timeOnJobTermYears.Clean
                    && _title.Clean
                    && _titleFax.Clean
                    && _titlePhone.Clean
                    && _verificationRequestDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addressCity; v0.Clean = value; _addressCity = v0;
                var v1 = _addressPostalCode; v1.Clean = value; _addressPostalCode = v1;
                var v2 = _addressState; v2.Clean = value; _addressState = v2;
                var v3 = _addressStreetLine1; v3.Clean = value; _addressStreetLine1 = v3;
                var v4 = _altId; v4.Clean = value; _altId = v4;
                var v5 = _attention; v5.Clean = value; _attention = v5;
                var v6 = _badgeOrEmployeeID; v6.Clean = value; _badgeOrEmployeeID = v6;
                var v7 = _basePayAmount; v7.Clean = value; _basePayAmount = v7;
                var v8 = _bonusAmount; v8.Clean = value; _bonusAmount = v8;
                var v9 = _businessName; v9.Clean = value; _businessName = v9;
                var v10 = _businessOwnedPercent; v10.Clean = value; _businessOwnedPercent = v10;
                var v11 = _businessPhone; v11.Clean = value; _businessPhone = v11;
                var v12 = _commissionsAmount; v12.Clean = value; _commissionsAmount = v12;
                var v13 = _currentEmploymentIndicator; v13.Clean = value; _currentEmploymentIndicator = v13;
                var v14 = _email; v14.Clean = value; _email = v14;
                var v15 = _employerComments; v15.Clean = value; _employerComments = v15;
                var v16 = _employerName; v16.Clean = value; _employerName = v16;
                var v17 = _endDate; v17.Clean = value; _endDate = v17;
                var v18 = _entityDeleted; v18.Clean = value; _entityDeleted = v18;
                var v19 = _fax; v19.Clean = value; _fax = v19;
                var v20 = _id; v20.Clean = value; _id = v20;
                var v21 = _monthlyIncomeAmount; v21.Clean = value; _monthlyIncomeAmount = v21;
                var v22 = _noLinkToDocTrackIndicator; v22.Clean = value; _noLinkToDocTrackIndicator = v22;
                var v23 = _otherAmount; v23.Clean = value; _otherAmount = v23;
                var v24 = _overtimeAmount; v24.Clean = value; _overtimeAmount = v24;
                var v25 = _owner; v25.Clean = value; _owner = v25;
                var v26 = _phoneNumber; v26.Clean = value; _phoneNumber = v26;
                var v27 = _positionDescription; v27.Clean = value; _positionDescription = v27;
                var v28 = _printAttachmentIndicator; v28.Clean = value; _printAttachmentIndicator = v28;
                var v29 = _printUserNameIndicator; v29.Clean = value; _printUserNameIndicator = v29;
                var v30 = _selfEmployedIndicator; v30.Clean = value; _selfEmployedIndicator = v30;
                var v31 = _startDate; v31.Clean = value; _startDate = v31;
                var v32 = _timeInLineOfWorkMonths; v32.Clean = value; _timeInLineOfWorkMonths = v32;
                var v33 = _timeInLineOfWorkYears; v33.Clean = value; _timeInLineOfWorkYears = v33;
                var v34 = _timeOnJobTermMonths; v34.Clean = value; _timeOnJobTermMonths = v34;
                var v35 = _timeOnJobTermYears; v35.Clean = value; _timeOnJobTermYears = v35;
                var v36 = _title; v36.Clean = value; _title = v36;
                var v37 = _titleFax; v37.Clean = value; _titleFax = v37;
                var v38 = _titlePhone; v38.Clean = value; _titlePhone = v38;
                var v39 = _verificationRequestDate; v39.Clean = value; _verificationRequestDate = v39;
                _settingClean = 0;
            }
        }
    }
}