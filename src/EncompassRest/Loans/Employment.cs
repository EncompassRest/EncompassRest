using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Employment : IDirty
    {
        private DirtyValue<string> _addressCity;
        public string AddressCity { get => _addressCity; set => _addressCity = value; }
        private DirtyValue<string> _addressPostalCode;
        public string AddressPostalCode { get => _addressPostalCode; set => _addressPostalCode = value; }
        private DirtyValue<string> _addressState;
        public string AddressState { get => _addressState; set => _addressState = value; }
        private DirtyValue<string> _addressStreetLine1;
        public string AddressStreetLine1 { get => _addressStreetLine1; set => _addressStreetLine1 = value; }
        private DirtyValue<string> _altId;
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _attention;
        public string Attention { get => _attention; set => _attention = value; }
        private DirtyValue<string> _badgeOrEmployeeID;
        public string BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => _badgeOrEmployeeID = value; }
        private DirtyValue<decimal?> _basePayAmount;
        public decimal? BasePayAmount { get => _basePayAmount; set => _basePayAmount = value; }
        private DirtyValue<decimal?> _bonusAmount;
        public decimal? BonusAmount { get => _bonusAmount; set => _bonusAmount = value; }
        private DirtyValue<string> _businessName;
        public string BusinessName { get => _businessName; set => _businessName = value; }
        private DirtyValue<decimal?> _businessOwnedPercent;
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => _businessOwnedPercent = value; }
        private DirtyValue<string> _businessPhone;
        public string BusinessPhone { get => _businessPhone; set => _businessPhone = value; }
        private DirtyValue<decimal?> _commissionsAmount;
        public decimal? CommissionsAmount { get => _commissionsAmount; set => _commissionsAmount = value; }
        private DirtyValue<bool?> _currentEmploymentIndicator;
        public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => _currentEmploymentIndicator = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _employerComments;
        public string EmployerComments { get => _employerComments; set => _employerComments = value; }
        private DirtyValue<string> _employerName;
        public string EmployerName { get => _employerName; set => _employerName = value; }
        private DirtyValue<DateTime?> _endDate;
        public DateTime? EndDate { get => _endDate; set => _endDate = value; }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _monthlyIncomeAmount;
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => _monthlyIncomeAmount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<decimal?> _otherAmount;
        public decimal? OtherAmount { get => _otherAmount; set => _otherAmount = value; }
        private DirtyValue<decimal?> _overtimeAmount;
        public decimal? OvertimeAmount { get => _overtimeAmount; set => _overtimeAmount = value; }
        private DirtyValue<string> _owner;
        public string Owner { get => _owner; set => _owner = value; }
        private DirtyValue<string> _phoneNumber;
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        private DirtyValue<string> _positionDescription;
        public string PositionDescription { get => _positionDescription; set => _positionDescription = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<bool?> _selfEmployedIndicator;
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => _selfEmployedIndicator = value; }
        private DirtyValue<DateTime?> _startDate;
        public DateTime? StartDate { get => _startDate; set => _startDate = value; }
        private DirtyValue<int?> _timeInLineOfWorkMonths;
        public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => _timeInLineOfWorkMonths = value; }
        private DirtyValue<int?> _timeInLineOfWorkYears;
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => _timeInLineOfWorkYears = value; }
        private DirtyValue<int?> _timeOnJobTermMonths;
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => _timeOnJobTermMonths = value; }
        private DirtyValue<int?> _timeOnJobTermYears;
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => _timeOnJobTermYears = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        private DirtyValue<DateTime?> _verificationRequestDate;
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => _verificationRequestDate = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _addressCity.Dirty
                    || _addressPostalCode.Dirty
                    || _addressState.Dirty
                    || _addressStreetLine1.Dirty
                    || _altId.Dirty
                    || _attention.Dirty
                    || _badgeOrEmployeeID.Dirty
                    || _basePayAmount.Dirty
                    || _bonusAmount.Dirty
                    || _businessName.Dirty
                    || _businessOwnedPercent.Dirty
                    || _businessPhone.Dirty
                    || _commissionsAmount.Dirty
                    || _currentEmploymentIndicator.Dirty
                    || _email.Dirty
                    || _employerComments.Dirty
                    || _employerName.Dirty
                    || _endDate.Dirty
                    || _entityDeleted.Dirty
                    || _fax.Dirty
                    || _id.Dirty
                    || _monthlyIncomeAmount.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _otherAmount.Dirty
                    || _overtimeAmount.Dirty
                    || _owner.Dirty
                    || _phoneNumber.Dirty
                    || _positionDescription.Dirty
                    || _printAttachmentIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _selfEmployedIndicator.Dirty
                    || _startDate.Dirty
                    || _timeInLineOfWorkMonths.Dirty
                    || _timeInLineOfWorkYears.Dirty
                    || _timeOnJobTermMonths.Dirty
                    || _timeOnJobTermYears.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty
                    || _verificationRequestDate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _addressCity.Dirty = value;
                _addressPostalCode.Dirty = value;
                _addressState.Dirty = value;
                _addressStreetLine1.Dirty = value;
                _altId.Dirty = value;
                _attention.Dirty = value;
                _badgeOrEmployeeID.Dirty = value;
                _basePayAmount.Dirty = value;
                _bonusAmount.Dirty = value;
                _businessName.Dirty = value;
                _businessOwnedPercent.Dirty = value;
                _businessPhone.Dirty = value;
                _commissionsAmount.Dirty = value;
                _currentEmploymentIndicator.Dirty = value;
                _email.Dirty = value;
                _employerComments.Dirty = value;
                _employerName.Dirty = value;
                _endDate.Dirty = value;
                _entityDeleted.Dirty = value;
                _fax.Dirty = value;
                _id.Dirty = value;
                _monthlyIncomeAmount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _otherAmount.Dirty = value;
                _overtimeAmount.Dirty = value;
                _owner.Dirty = value;
                _phoneNumber.Dirty = value;
                _positionDescription.Dirty = value;
                _printAttachmentIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _selfEmployedIndicator.Dirty = value;
                _startDate.Dirty = value;
                _timeInLineOfWorkMonths.Dirty = value;
                _timeInLineOfWorkYears.Dirty = value;
                _timeOnJobTermMonths.Dirty = value;
                _timeOnJobTermYears.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
                _verificationRequestDate.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}