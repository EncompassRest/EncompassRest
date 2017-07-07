using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Employment : IClean
    {
        private Value<string> _addressCity;
        public string AddressCity { get { return _addressCity; } set { _addressCity = value; } }
        private Value<string> _addressPostalCode;
        public string AddressPostalCode { get { return _addressPostalCode; } set { _addressPostalCode = value; } }
        private Value<string> _addressState;
        public string AddressState { get { return _addressState; } set { _addressState = value; } }
        private Value<string> _addressStreetLine1;
        public string AddressStreetLine1 { get { return _addressStreetLine1; } set { _addressStreetLine1 = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _attention;
        public string Attention { get { return _attention; } set { _attention = value; } }
        private Value<string> _badgeOrEmployeeID;
        public string BadgeOrEmployeeID { get { return _badgeOrEmployeeID; } set { _badgeOrEmployeeID = value; } }
        private Value<decimal?> _basePayAmount;
        public decimal? BasePayAmount { get { return _basePayAmount; } set { _basePayAmount = value; } }
        private Value<decimal?> _bonusAmount;
        public decimal? BonusAmount { get { return _bonusAmount; } set { _bonusAmount = value; } }
        private Value<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        private Value<decimal?> _businessOwnedPercent;
        public decimal? BusinessOwnedPercent { get { return _businessOwnedPercent; } set { _businessOwnedPercent = value; } }
        private Value<string> _businessPhone;
        public string BusinessPhone { get { return _businessPhone; } set { _businessPhone = value; } }
        private Value<decimal?> _commissionsAmount;
        public decimal? CommissionsAmount { get { return _commissionsAmount; } set { _commissionsAmount = value; } }
        private Value<bool?> _currentEmploymentIndicator;
        public bool? CurrentEmploymentIndicator { get { return _currentEmploymentIndicator; } set { _currentEmploymentIndicator = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _employerComments;
        public string EmployerComments { get { return _employerComments; } set { _employerComments = value; } }
        private Value<string> _employerName;
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        private Value<DateTime?> _endDate;
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _monthlyIncomeAmount;
        public int? MonthlyIncomeAmount { get { return _monthlyIncomeAmount; } set { _monthlyIncomeAmount = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<decimal?> _otherAmount;
        public decimal? OtherAmount { get { return _otherAmount; } set { _otherAmount = value; } }
        private Value<decimal?> _overtimeAmount;
        public decimal? OvertimeAmount { get { return _overtimeAmount; } set { _overtimeAmount = value; } }
        private Value<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private Value<string> _phoneNumber;
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        private Value<string> _positionDescription;
        public string PositionDescription { get { return _positionDescription; } set { _positionDescription = value; } }
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<bool?> _selfEmployedIndicator;
        public bool? SelfEmployedIndicator { get { return _selfEmployedIndicator; } set { _selfEmployedIndicator = value; } }
        private Value<DateTime?> _startDate;
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        private Value<int?> _timeInLineOfWorkMonths;
        public int? TimeInLineOfWorkMonths { get { return _timeInLineOfWorkMonths; } set { _timeInLineOfWorkMonths = value; } }
        private Value<int?> _timeInLineOfWorkYears;
        public int? TimeInLineOfWorkYears { get { return _timeInLineOfWorkYears; } set { _timeInLineOfWorkYears = value; } }
        private Value<int?> _timeOnJobTermMonths;
        public int? TimeOnJobTermMonths { get { return _timeOnJobTermMonths; } set { _timeOnJobTermMonths = value; } }
        private Value<int?> _timeOnJobTermYears;
        public int? TimeOnJobTermYears { get { return _timeOnJobTermYears; } set { _timeOnJobTermYears = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private Value<DateTime?> _verificationRequestDate;
        public DateTime? VerificationRequestDate { get { return _verificationRequestDate; } set { _verificationRequestDate = value; } }
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
                var addressCity = _addressCity; addressCity.Clean = value; _addressCity = addressCity;
                var addressPostalCode = _addressPostalCode; addressPostalCode.Clean = value; _addressPostalCode = addressPostalCode;
                var addressState = _addressState; addressState.Clean = value; _addressState = addressState;
                var addressStreetLine1 = _addressStreetLine1; addressStreetLine1.Clean = value; _addressStreetLine1 = addressStreetLine1;
                var altId = _altId; altId.Clean = value; _altId = altId;
                var attention = _attention; attention.Clean = value; _attention = attention;
                var badgeOrEmployeeID = _badgeOrEmployeeID; badgeOrEmployeeID.Clean = value; _badgeOrEmployeeID = badgeOrEmployeeID;
                var basePayAmount = _basePayAmount; basePayAmount.Clean = value; _basePayAmount = basePayAmount;
                var bonusAmount = _bonusAmount; bonusAmount.Clean = value; _bonusAmount = bonusAmount;
                var businessName = _businessName; businessName.Clean = value; _businessName = businessName;
                var businessOwnedPercent = _businessOwnedPercent; businessOwnedPercent.Clean = value; _businessOwnedPercent = businessOwnedPercent;
                var businessPhone = _businessPhone; businessPhone.Clean = value; _businessPhone = businessPhone;
                var commissionsAmount = _commissionsAmount; commissionsAmount.Clean = value; _commissionsAmount = commissionsAmount;
                var currentEmploymentIndicator = _currentEmploymentIndicator; currentEmploymentIndicator.Clean = value; _currentEmploymentIndicator = currentEmploymentIndicator;
                var email = _email; email.Clean = value; _email = email;
                var employerComments = _employerComments; employerComments.Clean = value; _employerComments = employerComments;
                var employerName = _employerName; employerName.Clean = value; _employerName = employerName;
                var endDate = _endDate; endDate.Clean = value; _endDate = endDate;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var id = _id; id.Clean = value; _id = id;
                var monthlyIncomeAmount = _monthlyIncomeAmount; monthlyIncomeAmount.Clean = value; _monthlyIncomeAmount = monthlyIncomeAmount;
                var noLinkToDocTrackIndicator = _noLinkToDocTrackIndicator; noLinkToDocTrackIndicator.Clean = value; _noLinkToDocTrackIndicator = noLinkToDocTrackIndicator;
                var otherAmount = _otherAmount; otherAmount.Clean = value; _otherAmount = otherAmount;
                var overtimeAmount = _overtimeAmount; overtimeAmount.Clean = value; _overtimeAmount = overtimeAmount;
                var owner = _owner; owner.Clean = value; _owner = owner;
                var phoneNumber = _phoneNumber; phoneNumber.Clean = value; _phoneNumber = phoneNumber;
                var positionDescription = _positionDescription; positionDescription.Clean = value; _positionDescription = positionDescription;
                var printAttachmentIndicator = _printAttachmentIndicator; printAttachmentIndicator.Clean = value; _printAttachmentIndicator = printAttachmentIndicator;
                var printUserNameIndicator = _printUserNameIndicator; printUserNameIndicator.Clean = value; _printUserNameIndicator = printUserNameIndicator;
                var selfEmployedIndicator = _selfEmployedIndicator; selfEmployedIndicator.Clean = value; _selfEmployedIndicator = selfEmployedIndicator;
                var startDate = _startDate; startDate.Clean = value; _startDate = startDate;
                var timeInLineOfWorkMonths = _timeInLineOfWorkMonths; timeInLineOfWorkMonths.Clean = value; _timeInLineOfWorkMonths = timeInLineOfWorkMonths;
                var timeInLineOfWorkYears = _timeInLineOfWorkYears; timeInLineOfWorkYears.Clean = value; _timeInLineOfWorkYears = timeInLineOfWorkYears;
                var timeOnJobTermMonths = _timeOnJobTermMonths; timeOnJobTermMonths.Clean = value; _timeOnJobTermMonths = timeOnJobTermMonths;
                var timeOnJobTermYears = _timeOnJobTermYears; timeOnJobTermYears.Clean = value; _timeOnJobTermYears = timeOnJobTermYears;
                var title = _title; title.Clean = value; _title = title;
                var titleFax = _titleFax; titleFax.Clean = value; _titleFax = titleFax;
                var titlePhone = _titlePhone; titlePhone.Clean = value; _titlePhone = titlePhone;
                var verificationRequestDate = _verificationRequestDate; verificationRequestDate.Clean = value; _verificationRequestDate = verificationRequestDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Employment()
        {
            Clean = true;
        }
    }
}