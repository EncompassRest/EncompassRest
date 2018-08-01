using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Property
    /// </summary>
    public sealed partial class Property : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _assessorsParcelIdentifier;
        /// <summary>
        /// Property Info Parcel # [1894]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Parcel #")]
        public string AssessorsParcelIdentifier { get => _assessorsParcelIdentifier; set => _assessorsParcelIdentifier = value; }
        private DirtyValue<string> _blockIdentifier;
        /// <summary>
        /// Property Info Block Identifier [2974]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Block Identifier")]
        public string BlockIdentifier { get => _blockIdentifier; set => _blockIdentifier = value; }
        private DirtyValue<bool?> _borrowerHomesteadIndicator;
        /// <summary>
        /// Subject Property is Borrower's Homestead [3198]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property is Borrower's Homestead")]
        public bool? BorrowerHomesteadIndicator { get => _borrowerHomesteadIndicator; set => _borrowerHomesteadIndicator = value; }
        private DirtyValue<StringEnumValue<BuildingStatusType>> _buildingStatusType;
        /// <summary>
        /// Subject Property Building Status [601]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Building Status")]
        public StringEnumValue<BuildingStatusType> BuildingStatusType { get => _buildingStatusType; set => _buildingStatusType = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Subject Property City [12]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property City")]
        public string City { get => _city; set => _city = value; }
        private DirtyValue<bool?> _condotelIndicator;
        /// <summary>
        /// Property Info Is Condotel [3315]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Condotel")]
        public bool? CondotelIndicator { get => _condotelIndicator; set => _condotelIndicator = value; }
        private DirtyValue<decimal?> _constructionImprovementCostsAmount;
        /// <summary>
        /// Loan Info Constr Loan Improvement Cost [23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Improvement Cost")]
        public decimal? ConstructionImprovementCostsAmount { get => _constructionImprovementCostsAmount; set => _constructionImprovementCostsAmount = value; }
        private DirtyValue<string> _county;
        /// <summary>
        /// Subject Property County [13]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property County")]
        public string County { get => _county; set => _county = value; }
        private DirtyValue<int?> _financedNumberOfUnits;
        /// <summary>
        /// Subject Property # Units [16]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property # Units")]
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => _financedNumberOfUnits = value; }
        private DirtyValue<string> _floodCertificationIdentifier;
        /// <summary>
        /// Property Info Flood Certification Identifier [2977]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Flood Certification Identifier")]
        public string FloodCertificationIdentifier { get => _floodCertificationIdentifier; set => _floodCertificationIdentifier = value; }
        private DirtyValue<decimal?> _freCashOutAmount;
        /// <summary>
        /// Freddie Mac Lender Cash Out Amt [CASASRN.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Lender Cash Out Amt")]
        public decimal? FreCashOutAmount { get => _freCashOutAmount; set => _freCashOutAmount = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _gseRefinancePurposeType;
        /// <summary>
        /// Loan Info Refi Purpose [299]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Purpose")]
        public StringEnumValue<RefinancePurpose> GseRefinancePurposeType { get => _gseRefinancePurposeType; set => _gseRefinancePurposeType = value; }
        private DirtyValue<StringEnumValue<GseTitleMannerHeldDescription>> _gseTitleMannerHeldDescription;
        /// <summary>
        /// Subject Property Manner Held [33]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Manner Held")]
        public StringEnumValue<GseTitleMannerHeldDescription> GseTitleMannerHeldDescription { get => _gseTitleMannerHeldDescription; set => _gseTitleMannerHeldDescription = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Property Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isConstructionPhaseDisclosedSeparately;
        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately [4084]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Construction Phase Disclosed Separately")]
        public bool? IsConstructionPhaseDisclosedSeparately { get => _isConstructionPhaseDisclosedSeparately; set => _isConstructionPhaseDisclosedSeparately = value; }
        private DirtyValue<decimal?> _landEstimatedValueAmount;
        /// <summary>
        /// Loan Info Constr Loan Lot Value [22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Lot Value")]
        public decimal? LandEstimatedValueAmount { get => _landEstimatedValueAmount; set => _landEstimatedValueAmount = value; }
        private DirtyValue<string> _legalDescriptionText1;
        /// <summary>
        /// Subject Property Legal Desc1 [17]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Desc1")]
        public string LegalDescriptionText1 { get => _legalDescriptionText1; set => _legalDescriptionText1 = value; }
        private DirtyValue<string> _legalDescriptionText2;
        /// <summary>
        /// Subject Property Legal Descr 2 [1824]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 2")]
        public string LegalDescriptionText2 { get => _legalDescriptionText2; set => _legalDescriptionText2 = value; }
        private DirtyValue<bool?> _linkedIsConstructionPhaseDisclosedSeparately;
        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately - Copied from Linekd Loan [LINK_4084]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Construction Phase Disclosed Separately - Copied from Linekd Loan")]
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get => _linkedIsConstructionPhaseDisclosedSeparately; set => _linkedIsConstructionPhaseDisclosedSeparately = value; }
        private DirtyValue<StringEnumValue<LienType>> _linkedLienPriorityType;
        /// <summary>
        /// Trans Details Lien Position - Copied from Linekd Loan [LINK_420]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lien Position - Copied from Linekd Loan")]
        public StringEnumValue<LienType> LinkedLienPriorityType { get => _linkedLienPriorityType; set => _linkedLienPriorityType = value; }
        private DirtyValue<string> _linkedLoanPurposeType;
        /// <summary>
        /// Trans Details Loan Purpose - Copied from Linked Loan [LINK_19]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose - Copied from Linked Loan")]
        public string LinkedLoanPurposeType { get => _linkedLoanPurposeType; set => _linkedLoanPurposeType = value; }
        private DirtyValue<StringEnumValue<LoanType>> _linkedMortgageType;
        /// <summary>
        /// Trans Details Loan Type - Copied from Linekd Loan [LINK_1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type - Copied from Linekd Loan")]
        public StringEnumValue<LoanType> LinkedMortgageType { get => _linkedMortgageType; set => _linkedMortgageType = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _loanPurposeType;
        /// <summary>
        /// Trans Details Loan Purpose [19]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose")]
        public StringEnumValue<LoanPurposeType> LoanPurposeType { get => _loanPurposeType; set => _loanPurposeType = value; }
        private DirtyValue<decimal?> _lotAcres;
        /// <summary>
        /// Property Info # of Lot Acres [3543]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info # of Lot Acres")]
        public decimal? LotAcres { get => _lotAcres; set => _lotAcres = value; }
        private DirtyValue<string> _lotIdentifier;
        /// <summary>
        /// Property Info Lot Identifier [2973]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Lot Identifier")]
        public string LotIdentifier { get => _lotIdentifier; set => _lotIdentifier = value; }
        private DirtyValue<string> _nameRecordingJurisdiction;
        /// <summary>
        /// Property Info Name of Recording Jurisdiction [3559]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Name of Recording Jurisdiction")]
        public string NameRecordingJurisdiction { get => _nameRecordingJurisdiction; set => _nameRecordingJurisdiction = value; }
        private DirtyValue<bool?> _nonwarrantableProjectIndicator;
        /// <summary>
        /// Property Info Is Non-Warrantable Project [3316]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Non-Warrantable Project")]
        public bool? NonwarrantableProjectIndicator { get => _nonwarrantableProjectIndicator; set => _nonwarrantableProjectIndicator = value; }
        private DirtyValue<decimal?> _numberOfStories;
        /// <summary>
        /// Property Info Number of Stories [3245]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_1, Description = "Property Info Number of Stories")]
        public decimal? NumberOfStories { get => _numberOfStories; set => _numberOfStories = value; }
        private DirtyValue<string> _otherLoanPurposeDescription;
        /// <summary>
        /// Trans Details Loan Purpose other [9]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose other")]
        public string OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => _otherLoanPurposeDescription = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Subject Property Zip [15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Subject Property Zip")]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _priorLoanRecordationBookNumber;
        /// <summary>
        /// Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded [3553]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded")]
        public string PriorLoanRecordationBookNumber { get => _priorLoanRecordationBookNumber; set => _priorLoanRecordationBookNumber = value; }
        private DirtyValue<decimal?> _priorLoanRecordationCurrentPrincipalAmount;
        /// <summary>
        /// Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage [3556]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage")]
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get => _priorLoanRecordationCurrentPrincipalAmount; set => _priorLoanRecordationCurrentPrincipalAmount = value; }
        private DirtyValue<DateTime?> _priorLoanRecordationDated;
        /// <summary>
        /// The date of the prior mortgage as recorded [4241]
        /// </summary>
        [LoanFieldProperty(Description = "The date of the prior mortgage as recorded")]
        public DateTime? PriorLoanRecordationDated { get => _priorLoanRecordationDated; set => _priorLoanRecordationDated = value; }
        private DirtyValue<string> _priorLoanRecordationOriginalLoanNumber;
        /// <summary>
        /// The original loan number of the prior mortgage [4240]
        /// </summary>
        [LoanFieldProperty(Description = "The original loan number of the prior mortgage")]
        public string PriorLoanRecordationOriginalLoanNumber { get => _priorLoanRecordationOriginalLoanNumber; set => _priorLoanRecordationOriginalLoanNumber = value; }
        private DirtyValue<decimal?> _priorLoanRecordationOriginalPrincipalAmount;
        /// <summary>
        /// Property Info The Original Principal Amount of The Prior Mortgage as Recorded [3555]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info The Original Principal Amount of The Prior Mortgage as Recorded")]
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get => _priorLoanRecordationOriginalPrincipalAmount; set => _priorLoanRecordationOriginalPrincipalAmount = value; }
        private DirtyValue<string> _priorLoanRecordationPageNumber;
        /// <summary>
        /// Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded [3554]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded")]
        public string PriorLoanRecordationPageNumber { get => _priorLoanRecordationPageNumber; set => _priorLoanRecordationPageNumber = value; }
        private DirtyValue<bool?> _prodIsSpInUnderservedArea;
        /// <summary>
        /// ATR\QM Management Tool - Basic Info - Subject Property is in an Underserved Area [3850]
        /// </summary>
        [LoanFieldProperty(Description = "ATR\\QM Management Tool - Basic Info - Subject Property is in an Underserved Area")]
        public bool? ProdIsSpInUnderservedArea { get => _prodIsSpInUnderservedArea; set => _prodIsSpInUnderservedArea = value; }
        private DirtyValue<string> _propertyAcquiredYear;
        /// <summary>
        /// Loan Info Constr Loan Yr Acquired [20]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Constr Loan Yr Acquired")]
        public string PropertyAcquiredYear { get => _propertyAcquiredYear; set => _propertyAcquiredYear = value; }
        private DirtyValue<decimal?> _propertyExistingLienAmount;
        /// <summary>
        /// Loan Info Constr Loan Existing Lien [10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Existing Lien")]
        public decimal? PropertyExistingLienAmount { get => _propertyExistingLienAmount; set => _propertyExistingLienAmount = value; }
        private DirtyValue<DateTime?> _propertyLeaseholdExpirationDate;
        /// <summary>
        /// Subject Property Leasehold Expir Date [1034]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Leasehold Expir Date")]
        public DateTime? PropertyLeaseholdExpirationDate { get => _propertyLeaseholdExpirationDate; set => _propertyLeaseholdExpirationDate = value; }
        private DirtyValue<decimal?> _propertyOriginalCostAmount;
        /// <summary>
        /// Loan Info Constr Loan Original Cost [21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Original Cost")]
        public decimal? PropertyOriginalCostAmount { get => _propertyOriginalCostAmount; set => _propertyOriginalCostAmount = value; }
        private DirtyValue<StringEnumValue<PropertyRightsType>> _propertyRightsType;
        /// <summary>
        /// Subject Property Estate Held [1066]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Estate Held")]
        public StringEnumValue<PropertyRightsType> PropertyRightsType { get => _propertyRightsType; set => _propertyRightsType = value; }
        private DirtyValue<string> _propertyUsageType;
        /// <summary>
        /// Subject Property Use Type [190]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Use Type")]
        public string PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<decimal?> _refinanceImprovementCostsAmount;
        /// <summary>
        /// Loan Info Refi Improvement Cost [29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Improvement Cost")]
        public decimal? RefinanceImprovementCostsAmount { get => _refinanceImprovementCostsAmount; set => _refinanceImprovementCostsAmount = value; }
        private DirtyValue<StringEnumValue<RefinanceImprovementsType>> _refinanceImprovementsType;
        /// <summary>
        /// Loan Info Refi Improve made/to be made [30]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Improve made/to be made")]
        public StringEnumValue<RefinanceImprovementsType> RefinanceImprovementsType { get => _refinanceImprovementsType; set => _refinanceImprovementsType = value; }
        private DirtyValue<string> _refinancePropertyAcquiredYear;
        /// <summary>
        /// Loan Info Refi Yr Acquired [24]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Yr Acquired")]
        public string RefinancePropertyAcquiredYear { get => _refinancePropertyAcquiredYear; set => _refinancePropertyAcquiredYear = value; }
        private DirtyValue<decimal?> _refinancePropertyExistingLienAmount;
        /// <summary>
        /// Loan Info Refi Existing Lien [26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Existing Lien")]
        public decimal? RefinancePropertyExistingLienAmount { get => _refinancePropertyExistingLienAmount; set => _refinancePropertyExistingLienAmount = value; }
        private DirtyValue<decimal?> _refinancePropertyOriginalCostAmount;
        /// <summary>
        /// Loan Info Refi Original Cost [25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Original Cost")]
        public decimal? RefinancePropertyOriginalCostAmount { get => _refinancePropertyOriginalCostAmount; set => _refinancePropertyOriginalCostAmount = value; }
        private DirtyValue<string> _refinanceProposedImprovementsDescription;
        /// <summary>
        /// Loan Info Refi Improvement Descr [205]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Improvement Descr")]
        public string RefinanceProposedImprovementsDescription { get => _refinanceProposedImprovementsDescription; set => _refinanceProposedImprovementsDescription = value; }
        private DirtyValue<bool?> _ruralAreaIndicator;
        /// <summary>
        /// Property Info Is Rural Area [3314]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Rural Area")]
        public bool? RuralAreaIndicator { get => _ruralAreaIndicator; set => _ruralAreaIndicator = value; }
        private DirtyValue<string> _sectionIdentifier;
        /// <summary>
        /// Property Info Section Identifier [2975]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Section Identifier")]
        public string SectionIdentifier { get => _sectionIdentifier; set => _sectionIdentifier = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Subject Property State [14]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property State")]
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        private DirtyValue<string> _streetAddress;
        /// <summary>
        /// Subject Property Street [11]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street")]
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private DirtyValue<string> _streetAddress2;
        /// <summary>
        /// Subject Property Street 2 [3893]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street 2")]
        public string StreetAddress2 { get => _streetAddress2; set => _streetAddress2 = value; }
        private DirtyValue<string> _structureBuiltYear;
        /// <summary>
        /// Subject Property Yr Built [18]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Yr Built")]
        public string StructureBuiltYear { get => _structureBuiltYear; set => _structureBuiltYear = value; }
        private DirtyValue<bool?> _texasContinuousMoneyLoanIndicator;
        /// <summary>
        /// Continuous Money Loan (Texas Only) [3199]
        /// </summary>
        [LoanFieldProperty(Description = "Continuous Money Loan (Texas Only)")]
        public bool? TexasContinuousMoneyLoanIndicator { get => _texasContinuousMoneyLoanIndicator; set => _texasContinuousMoneyLoanIndicator = value; }
        private DirtyValue<decimal?> _totalConstructionValueAmount;
        /// <summary>
        /// Loan Info Constr Loan Total [1074]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Loan Info Constr Loan Total")]
        public decimal? TotalConstructionValueAmount { get => _totalConstructionValueAmount; set => _totalConstructionValueAmount = value; }
        private DirtyValue<string> _typeRecordingJurisdiction;
        /// <summary>
        /// Property Info Type of Recording Jurisdiction [3558]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Type of Recording Jurisdiction")]
        public string TypeRecordingJurisdiction { get => _typeRecordingJurisdiction; set => _typeRecordingJurisdiction = value; }
        private DirtyValue<string> _unincorporatedAreaName;
        /// <summary>
        /// Property Info Unincorporated Area Name [3258]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Unincorporated Area Name")]
        public string UnincorporatedAreaName { get => _unincorporatedAreaName; set => _unincorporatedAreaName = value; }
        internal override bool DirtyInternal
        {
            get => _assessorsParcelIdentifier.Dirty
                || _blockIdentifier.Dirty
                || _borrowerHomesteadIndicator.Dirty
                || _buildingStatusType.Dirty
                || _city.Dirty
                || _condotelIndicator.Dirty
                || _constructionImprovementCostsAmount.Dirty
                || _county.Dirty
                || _financedNumberOfUnits.Dirty
                || _floodCertificationIdentifier.Dirty
                || _freCashOutAmount.Dirty
                || _gseRefinancePurposeType.Dirty
                || _gseTitleMannerHeldDescription.Dirty
                || _id.Dirty
                || _isConstructionPhaseDisclosedSeparately.Dirty
                || _landEstimatedValueAmount.Dirty
                || _legalDescriptionText1.Dirty
                || _legalDescriptionText2.Dirty
                || _linkedIsConstructionPhaseDisclosedSeparately.Dirty
                || _linkedLienPriorityType.Dirty
                || _linkedLoanPurposeType.Dirty
                || _linkedMortgageType.Dirty
                || _loanPurposeType.Dirty
                || _lotAcres.Dirty
                || _lotIdentifier.Dirty
                || _nameRecordingJurisdiction.Dirty
                || _nonwarrantableProjectIndicator.Dirty
                || _numberOfStories.Dirty
                || _otherLoanPurposeDescription.Dirty
                || _postalCode.Dirty
                || _priorLoanRecordationBookNumber.Dirty
                || _priorLoanRecordationCurrentPrincipalAmount.Dirty
                || _priorLoanRecordationDated.Dirty
                || _priorLoanRecordationOriginalLoanNumber.Dirty
                || _priorLoanRecordationOriginalPrincipalAmount.Dirty
                || _priorLoanRecordationPageNumber.Dirty
                || _prodIsSpInUnderservedArea.Dirty
                || _propertyAcquiredYear.Dirty
                || _propertyExistingLienAmount.Dirty
                || _propertyLeaseholdExpirationDate.Dirty
                || _propertyOriginalCostAmount.Dirty
                || _propertyRightsType.Dirty
                || _propertyUsageType.Dirty
                || _refinanceImprovementCostsAmount.Dirty
                || _refinanceImprovementsType.Dirty
                || _refinancePropertyAcquiredYear.Dirty
                || _refinancePropertyExistingLienAmount.Dirty
                || _refinancePropertyOriginalCostAmount.Dirty
                || _refinanceProposedImprovementsDescription.Dirty
                || _ruralAreaIndicator.Dirty
                || _sectionIdentifier.Dirty
                || _state.Dirty
                || _streetAddress.Dirty
                || _streetAddress2.Dirty
                || _structureBuiltYear.Dirty
                || _texasContinuousMoneyLoanIndicator.Dirty
                || _totalConstructionValueAmount.Dirty
                || _typeRecordingJurisdiction.Dirty
                || _unincorporatedAreaName.Dirty;
            set
            {
                _assessorsParcelIdentifier.Dirty = value;
                _blockIdentifier.Dirty = value;
                _borrowerHomesteadIndicator.Dirty = value;
                _buildingStatusType.Dirty = value;
                _city.Dirty = value;
                _condotelIndicator.Dirty = value;
                _constructionImprovementCostsAmount.Dirty = value;
                _county.Dirty = value;
                _financedNumberOfUnits.Dirty = value;
                _floodCertificationIdentifier.Dirty = value;
                _freCashOutAmount.Dirty = value;
                _gseRefinancePurposeType.Dirty = value;
                _gseTitleMannerHeldDescription.Dirty = value;
                _id.Dirty = value;
                _isConstructionPhaseDisclosedSeparately.Dirty = value;
                _landEstimatedValueAmount.Dirty = value;
                _legalDescriptionText1.Dirty = value;
                _legalDescriptionText2.Dirty = value;
                _linkedIsConstructionPhaseDisclosedSeparately.Dirty = value;
                _linkedLienPriorityType.Dirty = value;
                _linkedLoanPurposeType.Dirty = value;
                _linkedMortgageType.Dirty = value;
                _loanPurposeType.Dirty = value;
                _lotAcres.Dirty = value;
                _lotIdentifier.Dirty = value;
                _nameRecordingJurisdiction.Dirty = value;
                _nonwarrantableProjectIndicator.Dirty = value;
                _numberOfStories.Dirty = value;
                _otherLoanPurposeDescription.Dirty = value;
                _postalCode.Dirty = value;
                _priorLoanRecordationBookNumber.Dirty = value;
                _priorLoanRecordationCurrentPrincipalAmount.Dirty = value;
                _priorLoanRecordationDated.Dirty = value;
                _priorLoanRecordationOriginalLoanNumber.Dirty = value;
                _priorLoanRecordationOriginalPrincipalAmount.Dirty = value;
                _priorLoanRecordationPageNumber.Dirty = value;
                _prodIsSpInUnderservedArea.Dirty = value;
                _propertyAcquiredYear.Dirty = value;
                _propertyExistingLienAmount.Dirty = value;
                _propertyLeaseholdExpirationDate.Dirty = value;
                _propertyOriginalCostAmount.Dirty = value;
                _propertyRightsType.Dirty = value;
                _propertyUsageType.Dirty = value;
                _refinanceImprovementCostsAmount.Dirty = value;
                _refinanceImprovementsType.Dirty = value;
                _refinancePropertyAcquiredYear.Dirty = value;
                _refinancePropertyExistingLienAmount.Dirty = value;
                _refinancePropertyOriginalCostAmount.Dirty = value;
                _refinanceProposedImprovementsDescription.Dirty = value;
                _ruralAreaIndicator.Dirty = value;
                _sectionIdentifier.Dirty = value;
                _state.Dirty = value;
                _streetAddress.Dirty = value;
                _streetAddress2.Dirty = value;
                _structureBuiltYear.Dirty = value;
                _texasContinuousMoneyLoanIndicator.Dirty = value;
                _totalConstructionValueAmount.Dirty = value;
                _typeRecordingJurisdiction.Dirty = value;
                _unincorporatedAreaName.Dirty = value;
            }
        }
    }
}