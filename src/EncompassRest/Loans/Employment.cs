using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Employment
    /// </summary>
    public sealed partial class Employment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addressCity;
        /// <summary>
        /// Employment AddressCity
        /// </summary>
        public string AddressCity { get => _addressCity; set => _addressCity = value; }
        private DirtyValue<string> _addressPostalCode;
        /// <summary>
        /// Employment AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string AddressPostalCode { get => _addressPostalCode; set => _addressPostalCode = value; }
        private DirtyValue<string> _addressState;
        /// <summary>
        /// Employment AddressState
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string AddressState { get => _addressState; set => _addressState = value; }
        private DirtyValue<string> _addressStreetLine1;
        /// <summary>
        /// Employment AddressStreetLine1
        /// </summary>
        public string AddressStreetLine1 { get => _addressStreetLine1; set => _addressStreetLine1 = value; }
        private DirtyValue<string> _altId;
        /// <summary>
        /// Employment AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _attention;
        /// <summary>
        /// Employment Attention
        /// </summary>
        public string Attention { get => _attention; set => _attention = value; }
        private DirtyValue<string> _badgeOrEmployeeID;
        /// <summary>
        /// Employment BadgeOrEmployeeID
        /// </summary>
        public string BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => _badgeOrEmployeeID = value; }
        private DirtyValue<decimal?> _basePayAmount;
        /// <summary>
        /// Employment BasePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BasePayAmount { get => _basePayAmount; set => _basePayAmount = value; }
        private DirtyValue<decimal?> _bonusAmount;
        /// <summary>
        /// Employment BonusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BonusAmount { get => _bonusAmount; set => _bonusAmount = value; }
        private DirtyValue<string> _businessName;
        /// <summary>
        /// Employment BusinessName
        /// </summary>
        public string BusinessName { get => _businessName; set => _businessName = value; }
        private DirtyValue<decimal?> _businessOwnedPercent;
        /// <summary>
        /// Employment BusinessOwnedPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => _businessOwnedPercent = value; }
        private DirtyValue<string> _businessPhone;
        /// <summary>
        /// Employment BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string BusinessPhone { get => _businessPhone; set => _businessPhone = value; }
        private DirtyValue<decimal?> _commissionsAmount;
        /// <summary>
        /// Employment CommissionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CommissionsAmount { get => _commissionsAmount; set => _commissionsAmount = value; }
        private EntityReference _contact;
        /// <summary>
        /// Employment Contact
        /// </summary>
        public EntityReference Contact { get => _contact ?? (_contact = new EntityReference()); set => _contact = value; }
        private DirtyValue<bool?> _currentEmploymentIndicator;
        /// <summary>
        /// Employment CurrentEmploymentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Current\",\"false\":\"Prior\"}")]
        public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => _currentEmploymentIndicator = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// Employment Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _employerComments;
        /// <summary>
        /// Employment EmployerComments
        /// </summary>
        public string EmployerComments { get => _employerComments; set => _employerComments = value; }
        private DirtyValue<string> _employerName;
        /// <summary>
        /// Employment EmployerName
        /// </summary>
        public string EmployerName { get => _employerName; set => _employerName = value; }
        private DirtyValue<DateTime?> _endDate;
        /// <summary>
        /// Employment EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => _endDate = value; }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Employment EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Employment Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Employment Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _monthlyIncomeAmount;
        /// <summary>
        /// Employment MonthlyIncomeAmount
        /// </summary>
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => _monthlyIncomeAmount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Employment NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<decimal?> _otherAmount;
        /// <summary>
        /// Employment OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherAmount { get => _otherAmount; set => _otherAmount = value; }
        private DirtyValue<decimal?> _overtimeAmount;
        /// <summary>
        /// Employment OvertimeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OvertimeAmount { get => _overtimeAmount; set => _overtimeAmount = value; }
        private DirtyValue<string> _owner;
        /// <summary>
        /// Employment Owner
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Owner { get => _owner; set => _owner = value; }
        private DirtyValue<string> _phoneNumber;
        /// <summary>
        /// Employment PhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        private DirtyValue<string> _positionDescription;
        /// <summary>
        /// Employment PositionDescription
        /// </summary>
        public string PositionDescription { get => _positionDescription; set => _positionDescription = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        /// <summary>
        /// Employment PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Employment PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<bool?> _selfEmployedIndicator;
        /// <summary>
        /// Employment SelfEmployedIndicator
        /// </summary>
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => _selfEmployedIndicator = value; }
        private DirtyValue<DateTime?> _startDate;
        /// <summary>
        /// Employment StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => _startDate = value; }
        private DirtyValue<int?> _timeInLineOfWorkMonths;
        /// <summary>
        /// Employment TimeInLineOfWorkMonths
        /// </summary>
        public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => _timeInLineOfWorkMonths = value; }
        private DirtyValue<int?> _timeInLineOfWorkYears;
        /// <summary>
        /// Employment TimeInLineOfWorkYears
        /// </summary>
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => _timeInLineOfWorkYears = value; }
        private DirtyValue<int?> _timeOnJobTermMonths;
        /// <summary>
        /// Employment TimeOnJobTermMonths
        /// </summary>
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => _timeOnJobTermMonths = value; }
        private DirtyValue<int?> _timeOnJobTermYears;
        /// <summary>
        /// Employment TimeOnJobTermYears
        /// </summary>
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => _timeOnJobTermYears = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// Employment Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Employment TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Employment TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        private DirtyValue<DateTime?> _verificationRequestDate;
        /// <summary>
        /// Employment VerificationRequestDate
        /// </summary>
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => _verificationRequestDate = value; }
        internal override bool DirtyInternal
        {
            get => _addressCity.Dirty
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
                || _contact?.Dirty == true;
            set
            {
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
                if (_contact != null) _contact.Dirty = value;
            }
        }
    }
}