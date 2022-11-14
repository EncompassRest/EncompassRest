using System;
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
        private DirtyValue<DateTime?>? _acquiredDate;
        private DirtyValue<string?>? _city;
        private DirtyValue<string?>? _country;
        private DirtyValue<string?>? _countryCode;
        private DirtyValue<StringEnumValue<DispositionStatusType>>? _dispositionStatusType;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<bool?>? _foreignAddressIndicator;
        private DirtyValue<StringEnumValue<FuturePropertyUsageType>>? _futurePropertyUsageType;
        private DirtyValue<string?>? _futureUsageTypeOtherDesc;
        private DirtyValue<StringEnumValue<GsePropertyType>>? _gsePropertyType;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _includeInAusExport;
        private DirtyValue<bool?>? _isEmpty;
        private DirtyValue<bool?>? _liabilityDoesNotApply;
        private DirtyValue<decimal?>? _lienInstallmentAmount;
        private DirtyValue<decimal?>? _lienUpbAmount;
        private DirtyValue<string?>? _maintenanceExpenseAmount;
        private DirtyValue<decimal?>? _marketValueAmount;
        private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
        private DirtyValue<int?>? _numberOfUnits;
        private DirtyValue<StringEnumValue<Owner>>? _owner;
        private DirtyValue<decimal?>? _participationPercentage;
        private DirtyValue<DateTime?>? _pendingSaleDate;
        private DirtyValue<decimal?>? _percentageofRental;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<bool?>? _printAttachIndicator;
        private DirtyValue<bool?>? _printUserJobTitleIndicator;
        private DirtyValue<bool?>? _printUserNameIndicator;
        private DirtyValue<StringEnumValue<ReoPropertyUsageType>>? _propertyUsageType;
        private DirtyValue<decimal?>? _purchasePrice;
        private DirtyValue<decimal?>? _rentalIncomeGrossAmount;
        private DirtyValue<decimal?>? _rentalIncomeNetAmount;
        private DirtyValue<string?>? _reoComments;
        private DirtyValue<string?>? _reoId;
        private DirtyValue<int?>? _reoPropertyIndex;
        private DirtyValue<DateTime?>? _requestDate;
        private DirtyValue<StringEnumValue<State>>? _state;
        private DirtyValue<string?>? _streetAddress;
        private DirtyValue<bool?>? _subjectIndicator;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _titleFax;
        private DirtyValue<string?>? _titlePhone;
        private DirtyValue<string?>? _unitNumber;
        private DirtyValue<StringEnumValue<UnitType>>? _unitType;
        private DirtyValue<string?>? _uRLA2020StreetAddress;
        private DirtyValue<string?>? _yearBuilt;

        /// <summary>
        /// Mortgage Property Date Acquired [FMNN22]
        /// </summary>
        public DateTime? AcquiredDate { get => _acquiredDate; set => SetField(ref _acquiredDate, value); }

        /// <summary>
        /// Mortgage Property City [FMNN06]
        /// </summary>
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Mortgage Property Country [FMNN57]
        /// </summary>
        public string? Country { get => _country; set => SetField(ref _country, value); }

        /// <summary>
        /// Mortgage Property Country Code [FMNN51]
        /// </summary>
        public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

        /// <summary>
        /// Mortgage Property Disposition Status [FMNN24]
        /// </summary>
        public StringEnumValue<DispositionStatusType> DispositionStatusType { get => _dispositionStatusType; set => SetField(ref _dispositionStatusType, value); }

        /// <summary>
        /// ReoProperty EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Mortgage Property Foreign Address Indicator [FMNN58]
        /// </summary>
        public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

        /// <summary>
        /// Mortgage Property Future Use of Property [FMNN55]
        /// </summary>
        public StringEnumValue<FuturePropertyUsageType> FuturePropertyUsageType { get => _futurePropertyUsageType; set => SetField(ref _futurePropertyUsageType, value); }

        /// <summary>
        /// Description If Future Use of Property Is Other [FMNN56]
        /// </summary>
        public string? FutureUsageTypeOtherDesc { get => _futureUsageTypeOtherDesc; set => SetField(ref _futureUsageTypeOtherDesc, value); }

        /// <summary>
        /// Mortgage Property Type [FMNN18]
        /// </summary>
        public StringEnumValue<GsePropertyType> GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }

        /// <summary>
        /// ReoProperty Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Include In AUS/Export [FMNN52]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Include In AUS/Export\"}")]
        public bool? IncludeInAusExport { get => _includeInAusExport; set => SetField(ref _includeInAusExport, value); }

        /// <summary>
        /// ReoProperty IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// Mortgage Property Not linked to Liability [FMNN49]
        /// </summary>
        public bool? LiabilityDoesNotApply { get => _liabilityDoesNotApply; set => SetField(ref _liabilityDoesNotApply, value); }

        /// <summary>
        /// Mortgage Property Monthly Payment [FMNN16]
        /// </summary>
        public decimal? LienInstallmentAmount { get => _lienInstallmentAmount; set => SetField(ref _lienInstallmentAmount, value); }

        /// <summary>
        /// Mortgage Property Unpaid Balance [FMNN17]
        /// </summary>
        public decimal? LienUpbAmount { get => _lienUpbAmount; set => SetField(ref _lienUpbAmount, value); }

        /// <summary>
        /// Mortgage Property Monthly Expense [FMNN21]
        /// </summary>
        public string? MaintenanceExpenseAmount { get => _maintenanceExpenseAmount; set => SetField(ref _maintenanceExpenseAmount, value); }

        /// <summary>
        /// Mortgage Property Market Value [FMNN19]
        /// </summary>
        public decimal? MarketValueAmount { get => _marketValueAmount; set => SetField(ref _marketValueAmount, value); }

        /// <summary>
        /// Mortgage Property No Link to Doc Tracking [FMNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Number of Units [FMNN54]
        /// </summary>
        public int? NumberOfUnits { get => _numberOfUnits; set => SetField(ref _numberOfUnits, value); }

        /// <summary>
        /// Mortgage Property Owner [FMNN46]
        /// </summary>
        public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Mortgage Property Participation Percent [FMNN14]
        /// </summary>
        public decimal? ParticipationPercentage { get => _participationPercentage; set => SetField(ref _participationPercentage, value); }

        /// <summary>
        /// Mortgage Property Pending Sale Date [FMNN59]
        /// </summary>
        public DateTime? PendingSaleDate { get => _pendingSaleDate; set => SetField(ref _pendingSaleDate, value); }

        /// <summary>
        /// Mortgage Property Percent of Units Rented [FMNN26]
        /// </summary>
        public decimal? PercentageofRental { get => _percentageofRental; set => SetField(ref _percentageofRental, value); }

        /// <summary>
        /// Mortgage Property Zipcode [FMNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Mortgage Property Print - See Attached Authorization [FMNN36]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
        public bool? PrintAttachIndicator { get => _printAttachIndicator; set => SetField(ref _printAttachIndicator, value); }

        /// <summary>
        /// Mortgage Property Print User Job Title [FMNN64]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Mortgage Property Print User Name as Title [FMNN38]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Mortgage Property Use of Property [FMNN41]
        /// </summary>
        public StringEnumValue<ReoPropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Mortgage Property Purchase Price [FMNN23]
        /// </summary>
        public decimal? PurchasePrice { get => _purchasePrice; set => SetField(ref _purchasePrice, value); }

        /// <summary>
        /// Mortgage Property Monthly Gross Rental Income [FMNN20]
        /// </summary>
        public decimal? RentalIncomeGrossAmount { get => _rentalIncomeGrossAmount; set => SetField(ref _rentalIncomeGrossAmount, value); }

        /// <summary>
        /// Mortgage Property Net Rental Income [FMNN32]
        /// </summary>
        public decimal? RentalIncomeNetAmount { get => _rentalIncomeNetAmount; set => SetField(ref _rentalIncomeNetAmount, value); }

        /// <summary>
        /// Mortgage Property Comments [FMNN25]
        /// </summary>
        public string? ReoComments { get => _reoComments; set => SetField(ref _reoComments, value); }

        /// <summary>
        /// Mortgage Property REO ID [FMNN43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ReoId { get => _reoId; set => SetField(ref _reoId, value); }

        /// <summary>
        /// ReoProperty ReoPropertyIndex
        /// </summary>
        public int? ReoPropertyIndex { get => _reoPropertyIndex; set => SetField(ref _reoPropertyIndex, value); }

        /// <summary>
        /// Mortgage Property Request Date [FMNN98]
        /// </summary>
        public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }

        /// <summary>
        /// Mortgage Property State [FMNN07]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Mortgage Property Address [FMNN04]
        /// </summary>
        public string? StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Mortgage Property Is the Subject Property [FMNN28]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Subject Property\"}")]
        public bool? SubjectIndicator { get => _subjectIndicator; set => SetField(ref _subjectIndicator, value); }

        /// <summary>
        /// Mortgage Property From Title [FMNN37]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Mortgage Property From Fax [FMNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Mortgage Property From Phone [FMNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Mortgage Property Unit Number [FMNN48]
        /// </summary>
        public string? UnitNumber { get => _unitNumber; set => SetField(ref _unitNumber, value); }

        /// <summary>
        /// Mortgage Property Unit Type [FMNN47]
        /// </summary>
        public StringEnumValue<UnitType> UnitType { get => _unitType; set => SetField(ref _unitType, value); }

        /// <summary>
        /// Mortgage Property URLA 2020 Street Address [FMNN50]
        /// </summary>
        public string? URLA2020StreetAddress { get => _uRLA2020StreetAddress; set => SetField(ref _uRLA2020StreetAddress, value); }

        /// <summary>
        /// Mortgage Property Year in Which Built [FMNN53]
        /// </summary>
        public string? YearBuilt { get => _yearBuilt; set => SetField(ref _yearBuilt, value); }
    }
}