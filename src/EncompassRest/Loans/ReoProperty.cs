using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ReoProperty
    /// </summary>
    public sealed partial class ReoProperty : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _acquiredDate;
        /// <summary>
        /// Mortgage Property Date Acquired [FMNN22]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Date Acquired")]
        public DateTime? AcquiredDate { get => _acquiredDate; set => SetField(ref _acquiredDate, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// Mortgage Property City [FMNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property City")]
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<StringEnumValue<DispositionStatusType>> _dispositionStatusType;
        /// <summary>
        /// Mortgage Property Disposition Status [FMNN24]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Disposition Status")]
        public StringEnumValue<DispositionStatusType> DispositionStatusType { get => _dispositionStatusType; set => SetField(ref _dispositionStatusType, value); }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// ReoProperty EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }
        private DirtyValue<StringEnumValue<GsePropertyType>> _gsePropertyType;
        /// <summary>
        /// Mortgage Property Type [FMNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Type")]
        public StringEnumValue<GsePropertyType> GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ReoProperty Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// ReoProperty IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }
        private DirtyValue<decimal?> _lienInstallmentAmount;
        /// <summary>
        /// Mortgage Property Monthly Payment [FMNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Payment")]
        public decimal? LienInstallmentAmount { get => _lienInstallmentAmount; set => SetField(ref _lienInstallmentAmount, value); }
        private DirtyValue<decimal?> _lienUpbAmount;
        /// <summary>
        /// Mortgage Property Unpaid Balance [FMNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Unpaid Balance")]
        public decimal? LienUpbAmount { get => _lienUpbAmount; set => SetField(ref _lienUpbAmount, value); }
        private DirtyValue<string> _maintenanceExpenseAmount;
        /// <summary>
        /// Mortgage Property Monthly Expense [FMNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Monthly Expense")]
        public string MaintenanceExpenseAmount { get => _maintenanceExpenseAmount; set => SetField(ref _maintenanceExpenseAmount, value); }
        private DirtyValue<decimal?> _marketValueAmount;
        /// <summary>
        /// Mortgage Property Market Value [FMNN19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Market Value")]
        public decimal? MarketValueAmount { get => _marketValueAmount; set => SetField(ref _marketValueAmount, value); }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Mortgage Property No Link to Doc Tracking [FMNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }
        private DirtyValue<decimal?> _participationPercentage;
        /// <summary>
        /// Mortgage Property Participation Percent [FMNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Participation Percent")]
        public decimal? ParticipationPercentage { get => _participationPercentage; set => SetField(ref _participationPercentage, value); }
        private DirtyValue<decimal?> _percentageofRental;
        /// <summary>
        /// Mortgage Property Percent of Units Rented [FMNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Percent of Units Rented")]
        public decimal? PercentageofRental { get => _percentageofRental; set => SetField(ref _percentageofRental, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Mortgage Property Zipcode [FMNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Mortgage Property Zipcode")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<bool?> _printAttachIndicator;
        /// <summary>
        /// Mortgage Property Print - See Attached Authorization [FMNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachIndicator { get => _printAttachIndicator; set => SetField(ref _printAttachIndicator, value); }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Mortgage Property Print User Name as Title [FMNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        /// <summary>
        /// Mortgage Property Use of Property [FMNN41]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Use of Property", OptionsJson = "{\"PrimaryResidence\":\"Primary Residence\",\"SecondHome\":\"Second Home\",\"Investor\":\"Investment Property\"}")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }
        private DirtyValue<int?> _purchasePrice;
        /// <summary>
        /// Mortgage Property Purchase Price [FMNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Purchase Price")]
        public int? PurchasePrice { get => _purchasePrice; set => SetField(ref _purchasePrice, value); }
        private DirtyValue<decimal?> _rentalIncomeGrossAmount;
        /// <summary>
        /// Mortgage Property Monthly Gross Rental Income [FMNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Gross Rental Income")]
        public decimal? RentalIncomeGrossAmount { get => _rentalIncomeGrossAmount; set => SetField(ref _rentalIncomeGrossAmount, value); }
        private DirtyValue<decimal?> _rentalIncomeNetAmount;
        /// <summary>
        /// Mortgage Property Net Rental Income [FMNN32]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Net Rental Income")]
        public decimal? RentalIncomeNetAmount { get => _rentalIncomeNetAmount; set => SetField(ref _rentalIncomeNetAmount, value); }
        private DirtyValue<string> _reoComments;
        /// <summary>
        /// Mortgage Property Comments [FMNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Comments")]
        public string ReoComments { get => _reoComments; set => SetField(ref _reoComments, value); }
        private DirtyValue<string> _reoId;
        /// <summary>
        /// Mortgage Property REO ID [FMNN43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property REO ID")]
        public string ReoId { get => _reoId; set => SetField(ref _reoId, value); }
        private DirtyValue<int?> _reoPropertyIndex;
        /// <summary>
        /// ReoProperty ReoPropertyIndex
        /// </summary>
        public int? ReoPropertyIndex { get => _reoPropertyIndex; set => SetField(ref _reoPropertyIndex, value); }
        private DirtyValue<DateTime?> _requestDate;
        /// <summary>
        /// Mortgage Property Request Date [FMNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Request Date")]
        public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Mortgage Property State [FMNN07]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<string> _streetAddress;
        /// <summary>
        /// Mortgage Property Address [FMNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Address")]
        public string StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }
        private DirtyValue<bool?> _subjectIndicator;
        /// <summary>
        /// Mortgage Property Is the Subject Property [FMNN28]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Is the Subject Property", OptionsJson = "{\"true\":\"Subject Property\"}")]
        public bool? SubjectIndicator { get => _subjectIndicator; set => SetField(ref _subjectIndicator, value); }
        private DirtyValue<string> _title;
        /// <summary>
        /// Mortgage Property From Title [FMNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property From Title")]
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Mortgage Property From Fax [FMNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Fax")]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Mortgage Property From Phone [FMNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Phone")]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}