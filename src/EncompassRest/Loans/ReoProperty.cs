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
        public DateTime? AcquiredDate { get => _acquiredDate; set => _acquiredDate = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Mortgage Property City [FMNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property City")]
        public string City { get => _city; set => _city = value; }
        private DirtyValue<StringEnumValue<DispositionStatusType>> _dispositionStatusType;
        /// <summary>
        /// Mortgage Property Disposition Status [FMNN24]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Disposition Status")]
        public StringEnumValue<DispositionStatusType> DispositionStatusType { get => _dispositionStatusType; set => _dispositionStatusType = value; }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// ReoProperty EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<StringEnumValue<GsePropertyType>> _gsePropertyType;
        /// <summary>
        /// Mortgage Property Type [FMNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Type")]
        public StringEnumValue<GsePropertyType> GsePropertyType { get => _gsePropertyType; set => _gsePropertyType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ReoProperty Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// ReoProperty IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<decimal?> _lienInstallmentAmount;
        /// <summary>
        /// Mortgage Property Monthly Payment [FMNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Payment")]
        public decimal? LienInstallmentAmount { get => _lienInstallmentAmount; set => _lienInstallmentAmount = value; }
        private DirtyValue<decimal?> _lienUpbAmount;
        /// <summary>
        /// Mortgage Property Unpaid Balance [FMNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Unpaid Balance")]
        public decimal? LienUpbAmount { get => _lienUpbAmount; set => _lienUpbAmount = value; }
        private DirtyValue<string> _maintenanceExpenseAmount;
        /// <summary>
        /// Mortgage Property Monthly Expense [FMNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Monthly Expense")]
        public string MaintenanceExpenseAmount { get => _maintenanceExpenseAmount; set => _maintenanceExpenseAmount = value; }
        private DirtyValue<decimal?> _marketValueAmount;
        /// <summary>
        /// Mortgage Property Market Value [FMNN19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Market Value")]
        public decimal? MarketValueAmount { get => _marketValueAmount; set => _marketValueAmount = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Mortgage Property No Link to Doc Tracking [FMNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<decimal?> _participationPercentage;
        /// <summary>
        /// Mortgage Property Participation Percent [FMNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Participation Percent")]
        public decimal? ParticipationPercentage { get => _participationPercentage; set => _participationPercentage = value; }
        private DirtyValue<decimal?> _percentageofRental;
        /// <summary>
        /// Mortgage Property Percent of Units Rented [FMNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Percent of Units Rented")]
        public decimal? PercentageofRental { get => _percentageofRental; set => _percentageofRental = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Mortgage Property Zipcode [FMNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Mortgage Property Zipcode")]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<bool?> _printAttachIndicator;
        /// <summary>
        /// Mortgage Property Print - See Attached Authorization [FMNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachIndicator { get => _printAttachIndicator; set => _printAttachIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Mortgage Property Print User Name as Title [FMNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        /// <summary>
        /// Mortgage Property Use of Property [FMNN41]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Use of Property", OptionsJson = "{\"PrimaryResidence\":\"Primary Residence\",\"SecondHome\":\"Second Home\",\"Investor\":\"Investment Property\"}")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<int?> _purchasePrice;
        /// <summary>
        /// Mortgage Property Purchase Price [FMNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Purchase Price")]
        public int? PurchasePrice { get => _purchasePrice; set => _purchasePrice = value; }
        private DirtyValue<decimal?> _rentalIncomeGrossAmount;
        /// <summary>
        /// Mortgage Property Monthly Gross Rental Income [FMNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Gross Rental Income")]
        public decimal? RentalIncomeGrossAmount { get => _rentalIncomeGrossAmount; set => _rentalIncomeGrossAmount = value; }
        private DirtyValue<decimal?> _rentalIncomeNetAmount;
        /// <summary>
        /// Mortgage Property Net Rental Income [FMNN32]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Net Rental Income")]
        public decimal? RentalIncomeNetAmount { get => _rentalIncomeNetAmount; set => _rentalIncomeNetAmount = value; }
        private DirtyValue<string> _reoComments;
        /// <summary>
        /// Mortgage Property Comments [FMNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Comments")]
        public string ReoComments { get => _reoComments; set => _reoComments = value; }
        private DirtyValue<string> _reoId;
        /// <summary>
        /// Mortgage Property REO ID [FMNN43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property REO ID")]
        public string ReoId { get => _reoId; set => _reoId = value; }
        private DirtyValue<int?> _reoPropertyIndex;
        /// <summary>
        /// ReoProperty ReoPropertyIndex
        /// </summary>
        public int? ReoPropertyIndex { get => _reoPropertyIndex; set => _reoPropertyIndex = value; }
        private DirtyValue<DateTime?> _requestDate;
        /// <summary>
        /// Mortgage Property Request Date [FMNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Request Date")]
        public DateTime? RequestDate { get => _requestDate; set => _requestDate = value; }
        private DirtyValue<string> _state;
        /// <summary>
        /// Mortgage Property State [FMNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Mortgage Property State")]
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _streetAddress;
        /// <summary>
        /// Mortgage Property Address [FMNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Address")]
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private DirtyValue<bool?> _subjectIndicator;
        /// <summary>
        /// Mortgage Property Is the Subject Property [FMNN28]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Is the Subject Property", OptionsJson = "{\"true\":\"Subject Property\"}")]
        public bool? SubjectIndicator { get => _subjectIndicator; set => _subjectIndicator = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// Mortgage Property From Title [FMNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property From Title")]
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Mortgage Property From Fax [FMNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Fax")]
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Mortgage Property From Phone [FMNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Phone")]
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        internal override bool DirtyInternal
        {
            get => _acquiredDate.Dirty
                || _city.Dirty
                || _dispositionStatusType.Dirty
                || _entityDeleted.Dirty
                || _gsePropertyType.Dirty
                || _id.Dirty
                || _isEmpty.Dirty
                || _lienInstallmentAmount.Dirty
                || _lienUpbAmount.Dirty
                || _maintenanceExpenseAmount.Dirty
                || _marketValueAmount.Dirty
                || _noLinkToDocTrackIndicator.Dirty
                || _participationPercentage.Dirty
                || _percentageofRental.Dirty
                || _postalCode.Dirty
                || _printAttachIndicator.Dirty
                || _printUserNameIndicator.Dirty
                || _propertyUsageType.Dirty
                || _purchasePrice.Dirty
                || _rentalIncomeGrossAmount.Dirty
                || _rentalIncomeNetAmount.Dirty
                || _reoComments.Dirty
                || _reoId.Dirty
                || _reoPropertyIndex.Dirty
                || _requestDate.Dirty
                || _state.Dirty
                || _streetAddress.Dirty
                || _subjectIndicator.Dirty
                || _title.Dirty
                || _titleFax.Dirty
                || _titlePhone.Dirty;
            set
            {
                _acquiredDate.Dirty = value;
                _city.Dirty = value;
                _dispositionStatusType.Dirty = value;
                _entityDeleted.Dirty = value;
                _gsePropertyType.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _lienInstallmentAmount.Dirty = value;
                _lienUpbAmount.Dirty = value;
                _maintenanceExpenseAmount.Dirty = value;
                _marketValueAmount.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _participationPercentage.Dirty = value;
                _percentageofRental.Dirty = value;
                _postalCode.Dirty = value;
                _printAttachIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _propertyUsageType.Dirty = value;
                _purchasePrice.Dirty = value;
                _rentalIncomeGrossAmount.Dirty = value;
                _rentalIncomeNetAmount.Dirty = value;
                _reoComments.Dirty = value;
                _reoId.Dirty = value;
                _reoPropertyIndex.Dirty = value;
                _requestDate.Dirty = value;
                _state.Dirty = value;
                _streetAddress.Dirty = value;
                _subjectIndicator.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
            }
        }
    }
}