using System;
using EncompassApi.Loans.Enums;
using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// Property
    /// </summary>
    public sealed partial class Property : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addressLineText;
        private DirtyValue<StringEnumValue<UnitType>>? _addressUnitDesignatorType;
        private DirtyValue<string?>? _addressUnitIdentifier;
        private DirtyValue<string?>? _assessorsParcelIdentifier;
        private DirtyValue<string?>? _blockIdentifier;
        private DirtyValue<bool?>? _borrowerHomesteadIndicator;
        private DirtyValue<StringEnumValue<BuildingStatusType>>? _buildingStatusType;
        private DirtyValue<string?>? _city;
        private DirtyValue<bool?>? _condotelIndicator;
        private DirtyValue<decimal?>? _constructionImprovementCostsAmount;
        private DirtyValue<string?>? _county;
        private DirtyValue<bool?>? _fHASecondaryResidenceIndicator;
        private DirtyValue<int?>? _financedNumberOfUnits;
        private DirtyValue<string?>? _floodCertificationIdentifier;
        private DirtyValue<decimal?>? _freCashOutAmount;
        private DirtyValue<StringEnumValue<RefinancePurpose>>? _gseRefinancePurposeType;
        private DirtyValue<StringEnumValue<GseTitleMannerHeldDescription>>? _gseTitleMannerHeldDescription;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isConstructionPhaseDisclosedSeparately;
        private DirtyValue<decimal?>? _landEstimatedValueAmount;
        private DirtyValue<string?>? _legalDescriptionText1;
        private DirtyValue<string?>? _legalDescriptionText2;
        private DirtyValue<decimal?>? _linkedAmountApplyToDownPayment;
        private DirtyValue<decimal?>? _linkedBaseLoanAmount;
        private DirtyValue<decimal?>? _linkedClosedEndPrimaryMortgageLoanAmount;
        private DirtyValue<decimal?>? _linkedClosedEndSubordinateMortgageLoanAmount;
        private DirtyValue<StringEnumValue<LienPosition>>? _linkedHELOCLienPosition;
        private DirtyValue<decimal?>? _linkedHelocNewFinancingNotLinkedCreditLimit;
        private DirtyValue<decimal?>? _linkedHelocNewFinancingNotLinkedDrawAmount;
        private DirtyValue<decimal?>? _linkedInitialAdvanceAmount;
        private DirtyValue<bool?>? _linkedIsConstructionPhaseDisclosedSeparately;
        private DirtyValue<string?>? _linkedLenderName;
        private DirtyValue<StringEnumValue<LienType>>? _linkedLienPriorityType;
        private DirtyValue<string?>? _linkedLoanNumber;
        private DirtyValue<string?>? _linkedLoanPurposeType;
        private DirtyValue<decimal?>? _linkedMax5YrsPrincipleAndInterest;
        private DirtyValue<StringEnumValue<LoanType>>? _linkedMortgageType;
        private DirtyValue<decimal?>? _linkedProposedFirstMortgageAmount;
        private DirtyValue<decimal?>? _linkedProposedOtherAmount;
        private DirtyValue<decimal?>? _linkedProposedOtherMortgagesAmount;
        private DirtyValue<StringEnumValue<LoanPurposeType>>? _loanPurposeType;
        private DirtyValue<string?>? _loanPurposeTypeOtherDescription;
        private DirtyValue<StringEnumValue<LoanPurposeTypeURLA>>? _loanPurposeTypeURLA;
        private DirtyValue<decimal?>? _lotAcres;
        private DirtyValue<string?>? _lotIdentifier;
        private DirtyValue<string?>? _nameRecordingJurisdiction;
        private DirtyValue<bool?>? _nonwarrantableProjectIndicator;
        private DirtyValue<decimal?>? _numberOfStories;
        private DirtyValue<string?>? _occupancyDisplayField;
        private DirtyValue<bool?>? _oneTimeClose;
        private DirtyValue<string?>? _otherLoanPurposeDescription;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<string?>? _priorLoanRecordationBookNumber;
        private DirtyValue<decimal?>? _priorLoanRecordationCurrentPrincipalAmount;
        private DirtyValue<DateTime?>? _priorLoanRecordationDated;
        private DirtyValue<string?>? _priorLoanRecordationOriginalLoanNumber;
        private DirtyValue<decimal?>? _priorLoanRecordationOriginalPrincipalAmount;
        private DirtyValue<string?>? _priorLoanRecordationPageNumber;
        private DirtyValue<bool?>? _prodIsSpInUnderservedArea;
        private DirtyValue<string?>? _propertyAcquiredYear;
        private DirtyValue<decimal?>? _propertyExistingLienAmount;
        private DirtyValue<DateTime?>? _propertyLeaseholdExpirationDate;
        private DirtyValue<bool?>? _propertyMixedUsageIndicator;
        private DirtyValue<decimal?>? _propertyOriginalCostAmount;
        private DirtyValue<StringEnumValue<PropertyRightsType>>? _propertyRightsType;
        private DirtyValue<string?>? _propertyUsageType;
        private DirtyValue<decimal?>? _refinanceImprovementCostsAmount;
        private DirtyValue<StringEnumValue<PropertyImprovementsType>>? _refinanceImprovementsType;
        private DirtyValue<string?>? _refinancePropertyAcquiredYear;
        private DirtyValue<decimal?>? _refinancePropertyExistingLienAmount;
        private DirtyValue<decimal?>? _refinancePropertyOriginalCostAmount;
        private DirtyValue<string?>? _refinanceProposedImprovementsDescription;
        private DirtyValue<bool?>? _ruralAreaIndicator;
        private DirtyValue<string?>? _sectionIdentifier;
        private DirtyValue<StringEnumValue<State>>? _state;
        private DirtyValue<string?>? _streetAddress;
        private DirtyValue<string?>? _streetAddress2;
        private DirtyValue<string?>? _structureBuiltYear;
        private DirtyValue<bool?>? _texasContinuousMoneyLoanIndicator;
        private DirtyValue<decimal?>? _totalConstructionValueAmount;
        private DirtyValue<bool?>? _twoTimeClose;
        private DirtyValue<string?>? _typeRecordingJurisdiction;
        private DirtyValue<string?>? _unincorporatedAreaName;

        /// <summary>
        /// Property Address Line Text [URLA.X73]
        /// </summary>
        public string? AddressLineText { get => _addressLineText; set => SetField(ref _addressLineText, value); }

        /// <summary>
        /// Address Unit Type Identifier [URLA.X74]
        /// </summary>
        public StringEnumValue<UnitType> AddressUnitDesignatorType { get => _addressUnitDesignatorType; set => SetField(ref _addressUnitDesignatorType, value); }

        /// <summary>
        /// Property Address Unit Identifier [URLA.X75]
        /// </summary>
        public string? AddressUnitIdentifier { get => _addressUnitIdentifier; set => SetField(ref _addressUnitIdentifier, value); }

        /// <summary>
        /// Property Info Parcel # [1894]
        /// </summary>
        public string? AssessorsParcelIdentifier { get => _assessorsParcelIdentifier; set => SetField(ref _assessorsParcelIdentifier, value); }

        /// <summary>
        /// Property Info Block Identifier [2974]
        /// </summary>
        public string? BlockIdentifier { get => _blockIdentifier; set => SetField(ref _blockIdentifier, value); }

        /// <summary>
        /// Subject Property is Borrower's Homestead [3198]
        /// </summary>
        public bool? BorrowerHomesteadIndicator { get => _borrowerHomesteadIndicator; set => SetField(ref _borrowerHomesteadIndicator, value); }

        /// <summary>
        /// Subject Property Building Status [601]
        /// </summary>
        public StringEnumValue<BuildingStatusType> BuildingStatusType { get => _buildingStatusType; set => SetField(ref _buildingStatusType, value); }

        /// <summary>
        /// Subject Property City [12]
        /// </summary>
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Property Info Is Condotel [3315]
        /// </summary>
        public bool? CondotelIndicator { get => _condotelIndicator; set => SetField(ref _condotelIndicator, value); }

        /// <summary>
        /// Loan Info Constr Loan Improvement Cost [23]
        /// </summary>
        public decimal? ConstructionImprovementCostsAmount { get => _constructionImprovementCostsAmount; set => SetField(ref _constructionImprovementCostsAmount, value); }

        /// <summary>
        /// Subject Property County [13]
        /// </summary>
        public string? County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// FHA Secondary Residence Indicator [URLA.X76]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Secondary Residence\"}")]
        public bool? FHASecondaryResidenceIndicator { get => _fHASecondaryResidenceIndicator; set => SetField(ref _fHASecondaryResidenceIndicator, value); }

        /// <summary>
        /// Subject Property # Units [16]
        /// </summary>
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => SetField(ref _financedNumberOfUnits, value); }

        /// <summary>
        /// Property Info Flood Certification Identifier [2977]
        /// </summary>
        public string? FloodCertificationIdentifier { get => _floodCertificationIdentifier; set => SetField(ref _floodCertificationIdentifier, value); }

        /// <summary>
        /// Freddie Mac Lender Cash Out Amt [CASASRN.X79]
        /// </summary>
        public decimal? FreCashOutAmount { get => _freCashOutAmount; set => SetField(ref _freCashOutAmount, value); }

        /// <summary>
        /// Loan Info Refi Purpose [299]
        /// </summary>
        public StringEnumValue<RefinancePurpose> GseRefinancePurposeType { get => _gseRefinancePurposeType; set => SetField(ref _gseRefinancePurposeType, value); }

        /// <summary>
        /// Subject Property Manner Held [33]
        /// </summary>
        public StringEnumValue<GseTitleMannerHeldDescription> GseTitleMannerHeldDescription { get => _gseTitleMannerHeldDescription; set => SetField(ref _gseTitleMannerHeldDescription, value); }

        /// <summary>
        /// Property Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately [4084]
        /// </summary>
        public bool? IsConstructionPhaseDisclosedSeparately { get => _isConstructionPhaseDisclosedSeparately; set => SetField(ref _isConstructionPhaseDisclosedSeparately, value); }

        /// <summary>
        /// Loan Info Constr Loan Lot Value [22]
        /// </summary>
        public decimal? LandEstimatedValueAmount { get => _landEstimatedValueAmount; set => SetField(ref _landEstimatedValueAmount, value); }

        /// <summary>
        /// Subject Property Legal Desc1 [17]
        /// </summary>
        public string? LegalDescriptionText1 { get => _legalDescriptionText1; set => SetField(ref _legalDescriptionText1, value); }

        /// <summary>
        /// Subject Property Legal Descr 2 [1824]
        /// </summary>
        public string? LegalDescriptionText2 { get => _legalDescriptionText2; set => SetField(ref _legalDescriptionText2, value); }

        /// <summary>
        /// HELOC Amount Apply To Down Payment - Copied from Linked Loan [LINK_4493]
        /// </summary>
        public decimal? LinkedAmountApplyToDownPayment { get => _linkedAmountApplyToDownPayment; set => SetField(ref _linkedAmountApplyToDownPayment, value); }

        /// <summary>
        /// Linked Trans Details Total Loan Amt (w/ MIP/FF) [LINK_2]
        /// </summary>
        public decimal? LinkedBaseLoanAmount { get => _linkedBaseLoanAmount; set => SetField(ref _linkedBaseLoanAmount, value); }

        /// <summary>
        /// Closed End Primary Mortgage Loan Amount Copied from Linked Loan [LINK_4487]
        /// </summary>
        public decimal? LinkedClosedEndPrimaryMortgageLoanAmount { get => _linkedClosedEndPrimaryMortgageLoanAmount; set => SetField(ref _linkedClosedEndPrimaryMortgageLoanAmount, value); }

        /// <summary>
        /// Closed End Subordinate Mortgage Loan Amount - Copied from Linked Loan [LINK_4488]
        /// </summary>
        public decimal? LinkedClosedEndSubordinateMortgageLoanAmount { get => _linkedClosedEndSubordinateMortgageLoanAmount; set => SetField(ref _linkedClosedEndSubordinateMortgageLoanAmount, value); }

        /// <summary>
        /// HELOC Lien Position - Copied from Linked Loan [LINK_4494]
        /// </summary>
        public StringEnumValue<LienPosition> LinkedHELOCLienPosition { get => _linkedHELOCLienPosition; set => SetField(ref _linkedHELOCLienPosition, value); }

        /// <summary>
        /// Heloc New Financing Not Linked Credit Limit - Copied from Linked Loan [LINK_4490]
        /// </summary>
        public decimal? LinkedHelocNewFinancingNotLinkedCreditLimit { get => _linkedHelocNewFinancingNotLinkedCreditLimit; set => SetField(ref _linkedHelocNewFinancingNotLinkedCreditLimit, value); }

        /// <summary>
        /// Heloc New Financing Not Linked Draw Amount - Copied from Linked Loan [LINK_4489]
        /// </summary>
        public decimal? LinkedHelocNewFinancingNotLinkedDrawAmount { get => _linkedHelocNewFinancingNotLinkedDrawAmount; set => SetField(ref _linkedHelocNewFinancingNotLinkedDrawAmount, value); }

        /// <summary>
        /// HELOC Initial Advance - Copied from Linked Loan [LINK_1888]
        /// </summary>
        public decimal? LinkedInitialAdvanceAmount { get => _linkedInitialAdvanceAmount; set => SetField(ref _linkedInitialAdvanceAmount, value); }

        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately - Copied from Linked Loan [LINK_4084]
        /// </summary>
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get => _linkedIsConstructionPhaseDisclosedSeparately; set => SetField(ref _linkedIsConstructionPhaseDisclosedSeparately, value); }

        /// <summary>
        /// Linked File Contacts Lender Co Name [LINK_1264]
        /// </summary>
        public string? LinkedLenderName { get => _linkedLenderName; set => SetField(ref _linkedLenderName, value); }

        /// <summary>
        /// Trans Details Lien Position - Copied from Linked Loan [LINK_420]
        /// </summary>
        public StringEnumValue<LienType> LinkedLienPriorityType { get => _linkedLienPriorityType; set => SetField(ref _linkedLienPriorityType, value); }

        /// <summary>
        /// Trans Details Loan # - Copied from Linked Loan [LINK_364]
        /// </summary>
        public string? LinkedLoanNumber { get => _linkedLoanNumber; set => SetField(ref _linkedLoanNumber, value); }

        /// <summary>
        /// Trans Details Loan Purpose - Copied from Linked Loan [LINK_19]
        /// </summary>
        public string? LinkedLoanPurposeType { get => _linkedLoanPurposeType; set => SetField(ref _linkedLoanPurposeType, value); }

        /// <summary>
        /// Linked ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [LINK_QM.X337]
        /// </summary>
        public decimal? LinkedMax5YrsPrincipleAndInterest { get => _linkedMax5YrsPrincipleAndInterest; set => SetField(ref _linkedMax5YrsPrincipleAndInterest, value); }

        /// <summary>
        /// Trans Details Loan Type - Copied from Linked Loan [LINK_1172]
        /// </summary>
        public StringEnumValue<LoanType> LinkedMortgageType { get => _linkedMortgageType; set => SetField(ref _linkedMortgageType, value); }

        /// <summary>
        /// Linked Expenses Proposed Mtg Pymt [LINK_228]
        /// </summary>
        public decimal? LinkedProposedFirstMortgageAmount { get => _linkedProposedFirstMortgageAmount; set => SetField(ref _linkedProposedFirstMortgageAmount, value); }

        /// <summary>
        /// Linked Expenses Proposed Other Housing [LINK_234]
        /// </summary>
        public decimal? LinkedProposedOtherAmount { get => _linkedProposedOtherAmount; set => SetField(ref _linkedProposedOtherAmount, value); }

        /// <summary>
        /// Linked Expenses Proposed Other Pymt [LINK_229]
        /// </summary>
        public decimal? LinkedProposedOtherMortgagesAmount { get => _linkedProposedOtherMortgagesAmount; set => SetField(ref _linkedProposedOtherMortgagesAmount, value); }

        /// <summary>
        /// Trans Details Loan Purpose [19]
        /// </summary>
        public StringEnumValue<LoanPurposeType> LoanPurposeType { get => _loanPurposeType; set => SetField(ref _loanPurposeType, value); }

        /// <summary>
        /// Loan Purpose Other Description URLA [URLA.X72]
        /// </summary>
        public string? LoanPurposeTypeOtherDescription { get => _loanPurposeTypeOtherDescription; set => SetField(ref _loanPurposeTypeOtherDescription, value); }

        /// <summary>
        /// Display Loan Purpose Type for Property [URLA.X71]
        /// </summary>
        public StringEnumValue<LoanPurposeTypeURLA> LoanPurposeTypeURLA { get => _loanPurposeTypeURLA; set => SetField(ref _loanPurposeTypeURLA, value); }

        /// <summary>
        /// Property Info # of Lot Acres [3543]
        /// </summary>
        public decimal? LotAcres { get => _lotAcres; set => SetField(ref _lotAcres, value); }

        /// <summary>
        /// Property Info Lot Identifier [2973]
        /// </summary>
        public string? LotIdentifier { get => _lotIdentifier; set => SetField(ref _lotIdentifier, value); }

        /// <summary>
        /// Property Info Name of Recording Jurisdiction [3559]
        /// </summary>
        public string? NameRecordingJurisdiction { get => _nameRecordingJurisdiction; set => SetField(ref _nameRecordingJurisdiction, value); }

        /// <summary>
        /// Property Info Is Non-Warrantable Project [3316]
        /// </summary>
        public bool? NonwarrantableProjectIndicator { get => _nonwarrantableProjectIndicator; set => SetField(ref _nonwarrantableProjectIndicator, value); }

        /// <summary>
        /// Property Info Number of Stories [3245]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_1)]
        public decimal? NumberOfStories { get => _numberOfStories; set => SetField(ref _numberOfStories, value); }

        /// <summary>
        /// Property Address Occupancy Display Field [URLA.X108]
        /// </summary>
        public string? OccupancyDisplayField { get => _occupancyDisplayField; set => SetField(ref _occupancyDisplayField, value); }

        /// <summary>
        /// Construction Type one time close  [URLA.X192]
        /// </summary>
        public bool? OneTimeClose { get => _oneTimeClose; set => SetField(ref _oneTimeClose, value); }

        /// <summary>
        /// Trans Details Loan Purpose other [9]
        /// </summary>
        public string? OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => SetField(ref _otherLoanPurposeDescription, value); }

        /// <summary>
        /// Subject Property Zip [15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded [3553]
        /// </summary>
        public string? PriorLoanRecordationBookNumber { get => _priorLoanRecordationBookNumber; set => SetField(ref _priorLoanRecordationBookNumber, value); }

        /// <summary>
        /// Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage [3556]
        /// </summary>
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get => _priorLoanRecordationCurrentPrincipalAmount; set => SetField(ref _priorLoanRecordationCurrentPrincipalAmount, value); }

        /// <summary>
        /// The date of the prior mortgage as recorded [4241]
        /// </summary>
        public DateTime? PriorLoanRecordationDated { get => _priorLoanRecordationDated; set => SetField(ref _priorLoanRecordationDated, value); }

        /// <summary>
        /// The original loan number of the prior mortgage [4240]
        /// </summary>
        public string? PriorLoanRecordationOriginalLoanNumber { get => _priorLoanRecordationOriginalLoanNumber; set => SetField(ref _priorLoanRecordationOriginalLoanNumber, value); }

        /// <summary>
        /// Property Info The Original Principal Amount of The Prior Mortgage as Recorded [3555]
        /// </summary>
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get => _priorLoanRecordationOriginalPrincipalAmount; set => SetField(ref _priorLoanRecordationOriginalPrincipalAmount, value); }

        /// <summary>
        /// Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded [3554]
        /// </summary>
        public string? PriorLoanRecordationPageNumber { get => _priorLoanRecordationPageNumber; set => SetField(ref _priorLoanRecordationPageNumber, value); }

        /// <summary>
        /// ATR\QM Management Tool - Basic Info - Subject Property is in an Underserved Area [3850]
        /// </summary>
        public bool? ProdIsSpInUnderservedArea { get => _prodIsSpInUnderservedArea; set => SetField(ref _prodIsSpInUnderservedArea, value); }

        /// <summary>
        /// Loan Info Constr Loan Yr Acquired [20]
        /// </summary>
        public string? PropertyAcquiredYear { get => _propertyAcquiredYear; set => SetField(ref _propertyAcquiredYear, value); }

        /// <summary>
        /// Loan Info Constr Loan Existing Lien [10]
        /// </summary>
        public decimal? PropertyExistingLienAmount { get => _propertyExistingLienAmount; set => SetField(ref _propertyExistingLienAmount, value); }

        /// <summary>
        /// Subject Property Leasehold Expir Date [1034]
        /// </summary>
        public DateTime? PropertyLeaseholdExpirationDate { get => _propertyLeaseholdExpirationDate; set => SetField(ref _propertyLeaseholdExpirationDate, value); }

        /// <summary>
        /// Mixed Use Property Indicator [URLA.X77]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"If you will occupy the property, will you set aside space within the property to operate your own business? \"}")]
        public bool? PropertyMixedUsageIndicator { get => _propertyMixedUsageIndicator; set => SetField(ref _propertyMixedUsageIndicator, value); }

        /// <summary>
        /// Loan Info Constr Loan Original Cost [21]
        /// </summary>
        public decimal? PropertyOriginalCostAmount { get => _propertyOriginalCostAmount; set => SetField(ref _propertyOriginalCostAmount, value); }

        /// <summary>
        /// Subject Property Estate Held [1066]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Other\"]")]
        public StringEnumValue<PropertyRightsType> PropertyRightsType { get => _propertyRightsType; set => SetField(ref _propertyRightsType, value); }

        /// <summary>
        /// Subject Property Use Type [190]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Loan Info Refi Improvement Cost [29]
        /// </summary>
        public decimal? RefinanceImprovementCostsAmount { get => _refinanceImprovementCostsAmount; set => SetField(ref _refinanceImprovementCostsAmount, value); }

        /// <summary>
        /// Loan Info Refi Improve made/to be made [30]
        /// </summary>
        public StringEnumValue<PropertyImprovementsType> RefinanceImprovementsType { get => _refinanceImprovementsType; set => SetField(ref _refinanceImprovementsType, value); }

        /// <summary>
        /// Loan Info Refi Yr Acquired [24]
        /// </summary>
        public string? RefinancePropertyAcquiredYear { get => _refinancePropertyAcquiredYear; set => SetField(ref _refinancePropertyAcquiredYear, value); }

        /// <summary>
        /// Loan Info Refi Existing Lien [26]
        /// </summary>
        public decimal? RefinancePropertyExistingLienAmount { get => _refinancePropertyExistingLienAmount; set => SetField(ref _refinancePropertyExistingLienAmount, value); }

        /// <summary>
        /// Loan Info Refi Original Cost [25]
        /// </summary>
        public decimal? RefinancePropertyOriginalCostAmount { get => _refinancePropertyOriginalCostAmount; set => SetField(ref _refinancePropertyOriginalCostAmount, value); }

        /// <summary>
        /// Loan Info Refi Improvement Descr [205]
        /// </summary>
        public string? RefinanceProposedImprovementsDescription { get => _refinanceProposedImprovementsDescription; set => SetField(ref _refinanceProposedImprovementsDescription, value); }

        /// <summary>
        /// Property Info Is Rural Area [3314]
        /// </summary>
        public bool? RuralAreaIndicator { get => _ruralAreaIndicator; set => SetField(ref _ruralAreaIndicator, value); }

        /// <summary>
        /// Property Info Section Identifier [2975]
        /// </summary>
        public string? SectionIdentifier { get => _sectionIdentifier; set => SetField(ref _sectionIdentifier, value); }

        /// <summary>
        /// Subject Property State [14]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Subject Property Street [11]
        /// </summary>
        public string? StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Subject Property Street 2 [3893]
        /// </summary>
        public string? StreetAddress2 { get => _streetAddress2; set => SetField(ref _streetAddress2, value); }

        /// <summary>
        /// Subject Property Yr Built [18]
        /// </summary>
        public string? StructureBuiltYear { get => _structureBuiltYear; set => SetField(ref _structureBuiltYear, value); }

        /// <summary>
        /// Continuous Money Loan (Texas Only) [3199]
        /// </summary>
        public bool? TexasContinuousMoneyLoanIndicator { get => _texasContinuousMoneyLoanIndicator; set => SetField(ref _texasContinuousMoneyLoanIndicator, value); }

        /// <summary>
        /// Loan Info Constr Loan Total [1074]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalConstructionValueAmount { get => _totalConstructionValueAmount; set => SetField(ref _totalConstructionValueAmount, value); }

        /// <summary>
        /// Constrution Type two time close [URLA.X193]
        /// </summary>
        public bool? TwoTimeClose { get => _twoTimeClose; set => SetField(ref _twoTimeClose, value); }

        /// <summary>
        /// Property Info Type of Recording Jurisdiction [3558]
        /// </summary>
        public string? TypeRecordingJurisdiction { get => _typeRecordingJurisdiction; set => SetField(ref _typeRecordingJurisdiction, value); }

        /// <summary>
        /// Property Info Unincorporated Area Name [3258]
        /// </summary>
        public string? UnincorporatedAreaName { get => _unincorporatedAreaName; set => SetField(ref _unincorporatedAreaName, value); }
    }
}