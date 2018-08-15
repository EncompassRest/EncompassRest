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
        public string AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }
        private DirtyValue<string> _addressPostalCode;
        /// <summary>
        /// Employment AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _addressState;
        /// <summary>
        /// Employment AddressState
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }
        private DirtyValue<string> _addressStreetLine1;
        /// <summary>
        /// Employment AddressStreetLine1
        /// </summary>
        public string AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }
        private DirtyValue<string> _altId;
        /// <summary>
        /// Employment AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }
        private DirtyValue<string> _attention;
        /// <summary>
        /// Employment Attention
        /// </summary>
        public string Attention { get => _attention; set => SetField(ref _attention, value); }
        private DirtyValue<string> _badgeOrEmployeeID;
        /// <summary>
        /// Employment BadgeOrEmployeeID
        /// </summary>
        public string BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => SetField(ref _badgeOrEmployeeID, value); }
        private DirtyValue<decimal?> _basePayAmount;
        /// <summary>
        /// Employment BasePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BasePayAmount { get => _basePayAmount; set => SetField(ref _basePayAmount, value); }
        private DirtyValue<decimal?> _bonusAmount;
        /// <summary>
        /// Employment BonusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BonusAmount { get => _bonusAmount; set => SetField(ref _bonusAmount, value); }
        private DirtyValue<string> _businessName;
        /// <summary>
        /// Employment BusinessName
        /// </summary>
        public string BusinessName { get => _businessName; set => SetField(ref _businessName, value); }
        private DirtyValue<decimal?> _businessOwnedPercent;
        /// <summary>
        /// Employment BusinessOwnedPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => SetField(ref _businessOwnedPercent, value); }
        private DirtyValue<string> _businessPhone;
        /// <summary>
        /// Employment BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }
        private DirtyValue<decimal?> _commissionsAmount;
        /// <summary>
        /// Employment CommissionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CommissionsAmount { get => _commissionsAmount; set => SetField(ref _commissionsAmount, value); }
        private EntityReference _contact;
        /// <summary>
        /// Employment Contact
        /// </summary>
        public EntityReference Contact { get => GetField(ref _contact); set => SetField(ref _contact, value); }
        private DirtyValue<bool?> _currentEmploymentIndicator;
        /// <summary>
        /// Employment CurrentEmploymentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Current\",\"false\":\"Prior\"}")]
        public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => SetField(ref _currentEmploymentIndicator, value); }
        private DirtyValue<string> _email;
        /// <summary>
        /// Employment Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }
        private DirtyValue<string> _employerComments;
        /// <summary>
        /// Employment EmployerComments
        /// </summary>
        public string EmployerComments { get => _employerComments; set => SetField(ref _employerComments, value); }
        private DirtyValue<string> _employerName;
        /// <summary>
        /// Employment EmployerName
        /// </summary>
        public string EmployerName { get => _employerName; set => SetField(ref _employerName, value); }
        private DirtyValue<DateTime?> _endDate;
        /// <summary>
        /// Employment EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Employment EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Employment Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Employment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _monthlyIncomeAmount;
        /// <summary>
        /// Employment MonthlyIncomeAmount
        /// </summary>
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => SetField(ref _monthlyIncomeAmount, value); }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Employment NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }
        private DirtyValue<decimal?> _otherAmount;
        /// <summary>
        /// Employment OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }
        private DirtyValue<decimal?> _overtimeAmount;
        /// <summary>
        /// Employment OvertimeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OvertimeAmount { get => _overtimeAmount; set => SetField(ref _overtimeAmount, value); }
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _owner;
        /// <summary>
        /// Employment Owner
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }
        private DirtyValue<string> _phoneNumber;
        /// <summary>
        /// Employment PhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string PhoneNumber { get => _phoneNumber; set => SetField(ref _phoneNumber, value); }
        private DirtyValue<string> _positionDescription;
        /// <summary>
        /// Employment PositionDescription
        /// </summary>
        public string PositionDescription { get => _positionDescription; set => SetField(ref _positionDescription, value); }
        private DirtyValue<bool?> _printAttachmentIndicator;
        /// <summary>
        /// Employment PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Employment PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }
        private DirtyValue<bool?> _selfEmployedIndicator;
        /// <summary>
        /// Employment SelfEmployedIndicator
        /// </summary>
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => SetField(ref _selfEmployedIndicator, value); }
        private DirtyValue<DateTime?> _startDate;
        /// <summary>
        /// Employment StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
        private DirtyValue<int?> _timeInLineOfWorkMonths;
        /// <summary>
        /// Employment TimeInLineOfWorkMonths
        /// </summary>
        public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => SetField(ref _timeInLineOfWorkMonths, value); }
        private DirtyValue<int?> _timeInLineOfWorkYears;
        /// <summary>
        /// Employment TimeInLineOfWorkYears
        /// </summary>
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => SetField(ref _timeInLineOfWorkYears, value); }
        private DirtyValue<int?> _timeOnJobTermMonths;
        /// <summary>
        /// Employment TimeOnJobTermMonths
        /// </summary>
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => SetField(ref _timeOnJobTermMonths, value); }
        private DirtyValue<int?> _timeOnJobTermYears;
        /// <summary>
        /// Employment TimeOnJobTermYears
        /// </summary>
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => SetField(ref _timeOnJobTermYears, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// Employment Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Employment TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Employment TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
        private DirtyValue<DateTime?> _verificationRequestDate;
        /// <summary>
        /// Employment VerificationRequestDate
        /// </summary>
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => SetField(ref _verificationRequestDate, value); }
    }
}