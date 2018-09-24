using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Employment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(CurrentEmploymentIndicator) + "," + nameof(Owner), SerializeWholeListWhenDirty = true)]
    public sealed partial class Employment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addressCity;
        private DirtyValue<string> _addressPostalCode;
        private DirtyValue<StringEnumValue<State>> _addressState;
        private DirtyValue<string> _addressStreetLine1;
        private DirtyValue<string> _altId;
        private DirtyValue<string> _attention;
        private DirtyValue<string> _badgeOrEmployeeID;
        private DirtyValue<decimal?> _basePayAmount;
        private DirtyValue<decimal?> _bonusAmount;
        private DirtyValue<string> _businessName;
        private DirtyValue<decimal?> _businessOwnedPercent;
        private DirtyValue<string> _businessPhone;
        private DirtyValue<decimal?> _commissionsAmount;
        private EntityReference _contact;
        private DirtyValue<bool?> _currentEmploymentIndicator;
        private DirtyValue<string> _email;
        private DirtyValue<string> _employerComments;
        private DirtyValue<string> _employerName;
        private DirtyValue<DateTime?> _endDate;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _id;
        private DirtyValue<int?> _monthlyIncomeAmount;
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        private DirtyValue<decimal?> _otherAmount;
        private DirtyValue<decimal?> _overtimeAmount;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _owner;
        private DirtyValue<string> _phoneNumber;
        private DirtyValue<string> _positionDescription;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<bool?> _selfEmployedIndicator;
        private DirtyValue<DateTime?> _startDate;
        private DirtyValue<int?> _timeInLineOfWorkMonths;
        private DirtyValue<int?> _timeInLineOfWorkYears;
        private DirtyValue<int?> _timeOnJobTermMonths;
        private DirtyValue<int?> _timeOnJobTermYears;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;
        private DirtyValue<DateTime?> _verificationRequestDate;

        /// <summary>
        /// Employment AddressCity
        /// </summary>
        public string AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

        /// <summary>
        /// Employment AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

        /// <summary>
        /// Employment AddressState
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }

        /// <summary>
        /// Employment AddressStreetLine1
        /// </summary>
        public string AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

        /// <summary>
        /// Employment AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Employment Attention
        /// </summary>
        public string Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Employment BadgeOrEmployeeID
        /// </summary>
        public string BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => SetField(ref _badgeOrEmployeeID, value); }

        /// <summary>
        /// Employment BasePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BasePayAmount { get => _basePayAmount; set => SetField(ref _basePayAmount, value); }

        /// <summary>
        /// Employment BonusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BonusAmount { get => _bonusAmount; set => SetField(ref _bonusAmount, value); }

        /// <summary>
        /// Employment BusinessName
        /// </summary>
        public string BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

        /// <summary>
        /// Employment BusinessOwnedPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => SetField(ref _businessOwnedPercent, value); }

        /// <summary>
        /// Employment BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }

        /// <summary>
        /// Employment CommissionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CommissionsAmount { get => _commissionsAmount; set => SetField(ref _commissionsAmount, value); }

        /// <summary>
        /// Employment Contact
        /// </summary>
        public EntityReference Contact { get => GetField(ref _contact); set => SetField(ref _contact, value); }

        /// <summary>
        /// Employment CurrentEmploymentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Current\",\"false\":\"Prior\"}")]
        public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => SetField(ref _currentEmploymentIndicator, value); }

        /// <summary>
        /// Employment Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// Employment EmployerComments
        /// </summary>
        public string EmployerComments { get => _employerComments; set => SetField(ref _employerComments, value); }

        /// <summary>
        /// Employment EmployerName
        /// </summary>
        public string EmployerName { get => _employerName; set => SetField(ref _employerName, value); }

        /// <summary>
        /// Employment EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        /// <summary>
        /// Employment EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Employment Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// Employment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Employment MonthlyIncomeAmount
        /// </summary>
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => SetField(ref _monthlyIncomeAmount, value); }

        /// <summary>
        /// Employment NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Employment OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

        /// <summary>
        /// Employment OvertimeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OvertimeAmount { get => _overtimeAmount; set => SetField(ref _overtimeAmount, value); }

        /// <summary>
        /// Employment Owner
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Employment PhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string PhoneNumber { get => _phoneNumber; set => SetField(ref _phoneNumber, value); }

        /// <summary>
        /// Employment PositionDescription
        /// </summary>
        public string PositionDescription { get => _positionDescription; set => SetField(ref _positionDescription, value); }

        /// <summary>
        /// Employment PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Employment PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Employment SelfEmployedIndicator
        /// </summary>
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => SetField(ref _selfEmployedIndicator, value); }

        /// <summary>
        /// Employment StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        /// <summary>
        /// Employment TimeInLineOfWorkMonths
        /// </summary>
        public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => SetField(ref _timeInLineOfWorkMonths, value); }

        /// <summary>
        /// Employment TimeInLineOfWorkYears
        /// </summary>
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => SetField(ref _timeInLineOfWorkYears, value); }

        /// <summary>
        /// Employment TimeOnJobTermMonths
        /// </summary>
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => SetField(ref _timeOnJobTermMonths, value); }

        /// <summary>
        /// Employment TimeOnJobTermYears
        /// </summary>
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => SetField(ref _timeOnJobTermYears, value); }

        /// <summary>
        /// Employment Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Employment TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Employment TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Employment VerificationRequestDate
        /// </summary>
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => SetField(ref _verificationRequestDate, value); }
    }
}