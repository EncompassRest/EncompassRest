using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ReoProperty
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class ReoProperty : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _acquiredDate;
        private DirtyValue<string> _city;
        private DirtyValue<StringEnumValue<DispositionStatusType>> _dispositionStatusType;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<StringEnumValue<GsePropertyType>> _gsePropertyType;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isEmpty;
        private DirtyValue<decimal?> _lienInstallmentAmount;
        private DirtyValue<decimal?> _lienUpbAmount;
        private DirtyValue<string> _maintenanceExpenseAmount;
        private DirtyValue<decimal?> _marketValueAmount;
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        private DirtyValue<decimal?> _participationPercentage;
        private DirtyValue<decimal?> _percentageofRental;
        private DirtyValue<string> _postalCode;
        private DirtyValue<bool?> _printAttachIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        private DirtyValue<int?> _purchasePrice;
        private DirtyValue<decimal?> _rentalIncomeGrossAmount;
        private DirtyValue<decimal?> _rentalIncomeNetAmount;
        private DirtyValue<string> _reoComments;
        private DirtyValue<string> _reoId;
        private DirtyValue<int?> _reoPropertyIndex;
        private DirtyValue<DateTime?> _requestDate;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<string> _streetAddress;
        private DirtyValue<bool?> _subjectIndicator;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;

        /// <summary>
        /// Mortgage Property Date Acquired [FMNN22]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Date Acquired")]
        public DateTime? AcquiredDate { get => _acquiredDate; set => SetField(ref _acquiredDate, value); }

        /// <summary>
        /// Mortgage Property City [FMNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property City")]
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Mortgage Property Disposition Status [FMNN24]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Disposition Status")]
        public StringEnumValue<DispositionStatusType> DispositionStatusType { get => _dispositionStatusType; set => SetField(ref _dispositionStatusType, value); }

        /// <summary>
        /// ReoProperty EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Mortgage Property Type [FMNN18]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Type")]
        public StringEnumValue<GsePropertyType> GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }

        /// <summary>
        /// ReoProperty Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ReoProperty IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// Mortgage Property Monthly Payment [FMNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Payment")]
        public decimal? LienInstallmentAmount { get => _lienInstallmentAmount; set => SetField(ref _lienInstallmentAmount, value); }

        /// <summary>
        /// Mortgage Property Unpaid Balance [FMNN17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Unpaid Balance")]
        public decimal? LienUpbAmount { get => _lienUpbAmount; set => SetField(ref _lienUpbAmount, value); }

        /// <summary>
        /// Mortgage Property Monthly Expense [FMNN21]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Monthly Expense")]
        public string MaintenanceExpenseAmount { get => _maintenanceExpenseAmount; set => SetField(ref _maintenanceExpenseAmount, value); }

        /// <summary>
        /// Mortgage Property Market Value [FMNN19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Market Value")]
        public decimal? MarketValueAmount { get => _marketValueAmount; set => SetField(ref _marketValueAmount, value); }

        /// <summary>
        /// Mortgage Property No Link to Doc Tracking [FMNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property No Link to Doc Tracking")]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Mortgage Property Participation Percent [FMNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Participation Percent")]
        public decimal? ParticipationPercentage { get => _participationPercentage; set => SetField(ref _participationPercentage, value); }

        /// <summary>
        /// Mortgage Property Percent of Units Rented [FMNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Percent of Units Rented")]
        public decimal? PercentageofRental { get => _percentageofRental; set => SetField(ref _percentageofRental, value); }

        /// <summary>
        /// Mortgage Property Zipcode [FMNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Mortgage Property Zipcode")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Mortgage Property Print - See Attached Authorization [FMNN36]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print - See Attached Authorization", OptionsJson = "{\"true\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachIndicator { get => _printAttachIndicator; set => SetField(ref _printAttachIndicator, value); }

        /// <summary>
        /// Mortgage Property Print User Name as Title [FMNN38]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Print User Name as Title", OptionsJson = "{\"true\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Mortgage Property Use of Property [FMNN41]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Use of Property", OptionsJson = "{\"PrimaryResidence\":\"Primary Residence\",\"SecondHome\":\"Second Home\",\"Investor\":\"Investment Property\"}")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Mortgage Property Purchase Price [FMNN23]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Purchase Price")]
        public int? PurchasePrice { get => _purchasePrice; set => SetField(ref _purchasePrice, value); }

        /// <summary>
        /// Mortgage Property Monthly Gross Rental Income [FMNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Property Monthly Gross Rental Income")]
        public decimal? RentalIncomeGrossAmount { get => _rentalIncomeGrossAmount; set => SetField(ref _rentalIncomeGrossAmount, value); }

        /// <summary>
        /// Mortgage Property Net Rental Income [FMNN32]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Net Rental Income")]
        public decimal? RentalIncomeNetAmount { get => _rentalIncomeNetAmount; set => SetField(ref _rentalIncomeNetAmount, value); }

        /// <summary>
        /// Mortgage Property Comments [FMNN25]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Comments")]
        public string ReoComments { get => _reoComments; set => SetField(ref _reoComments, value); }

        /// <summary>
        /// Mortgage Property REO ID [FMNN43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mortgage Property REO ID")]
        public string ReoId { get => _reoId; set => SetField(ref _reoId, value); }

        /// <summary>
        /// ReoProperty ReoPropertyIndex
        /// </summary>
        public int? ReoPropertyIndex { get => _reoPropertyIndex; set => SetField(ref _reoPropertyIndex, value); }

        /// <summary>
        /// Mortgage Property Request Date [FMNN98]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Request Date")]
        public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }

        /// <summary>
        /// Mortgage Property State [FMNN07]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Mortgage Property Address [FMNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Address")]
        public string StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Mortgage Property Is the Subject Property [FMNN28]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property Is the Subject Property", OptionsJson = "{\"true\":\"Subject Property\"}")]
        public bool? SubjectIndicator { get => _subjectIndicator; set => SetField(ref _subjectIndicator, value); }

        /// <summary>
        /// Mortgage Property From Title [FMNN37]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Property From Title")]
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Mortgage Property From Fax [FMNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Fax")]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Mortgage Property From Phone [FMNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Mortgage Property From Phone")]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}