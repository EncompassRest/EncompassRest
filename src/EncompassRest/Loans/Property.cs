#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Property : ExtensibleObject
    {
        private DirtyValue<string> _assessorsParcelIdentifier;
        public string AssessorsParcelIdentifier { get => _assessorsParcelIdentifier; set => _assessorsParcelIdentifier = value; }
        private DirtyValue<string> _blockIdentifier;
        public string BlockIdentifier { get => _blockIdentifier; set => _blockIdentifier = value; }
        private DirtyValue<bool?> _borrowerHomesteadIndicator;
        public bool? BorrowerHomesteadIndicator { get => _borrowerHomesteadIndicator; set => _borrowerHomesteadIndicator = value; }
        private DirtyValue<StringEnumValue<BuildingStatusType>> _buildingStatusType;
        public StringEnumValue<BuildingStatusType> BuildingStatusType { get => _buildingStatusType; set => _buildingStatusType = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<bool?> _condotelIndicator;
        public bool? CondotelIndicator { get => _condotelIndicator; set => _condotelIndicator = value; }
        private DirtyValue<decimal?> _constructionImprovementCostsAmount;
        public decimal? ConstructionImprovementCostsAmount { get => _constructionImprovementCostsAmount; set => _constructionImprovementCostsAmount = value; }
        private DirtyValue<string> _county;
        public string County { get => _county; set => _county = value; }
        private DirtyValue<int?> _financedNumberOfUnits;
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => _financedNumberOfUnits = value; }
        private DirtyValue<string> _floodCertificationIdentifier;
        public string FloodCertificationIdentifier { get => _floodCertificationIdentifier; set => _floodCertificationIdentifier = value; }
        private DirtyValue<decimal?> _freCashOutAmount;
        public decimal? FreCashOutAmount { get => _freCashOutAmount; set => _freCashOutAmount = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _gseRefinancePurposeType;
        public StringEnumValue<RefinancePurpose> GseRefinancePurposeType { get => _gseRefinancePurposeType; set => _gseRefinancePurposeType = value; }
        private DirtyValue<StringEnumValue<GseTitleMannerHeldDescription>> _gseTitleMannerHeldDescription;
        public StringEnumValue<GseTitleMannerHeldDescription> GseTitleMannerHeldDescription { get => _gseTitleMannerHeldDescription; set => _gseTitleMannerHeldDescription = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isConstructionPhaseDisclosedSeparately;
        public bool? IsConstructionPhaseDisclosedSeparately { get => _isConstructionPhaseDisclosedSeparately; set => _isConstructionPhaseDisclosedSeparately = value; }
        private DirtyValue<decimal?> _landEstimatedValueAmount;
        public decimal? LandEstimatedValueAmount { get => _landEstimatedValueAmount; set => _landEstimatedValueAmount = value; }
        private DirtyValue<string> _legalDescriptionText1;
        public string LegalDescriptionText1 { get => _legalDescriptionText1; set => _legalDescriptionText1 = value; }
        private DirtyValue<string> _legalDescriptionText2;
        public string LegalDescriptionText2 { get => _legalDescriptionText2; set => _legalDescriptionText2 = value; }
        private DirtyValue<bool?> _linkedIsConstructionPhaseDisclosedSeparately;
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get => _linkedIsConstructionPhaseDisclosedSeparately; set => _linkedIsConstructionPhaseDisclosedSeparately = value; }
        private DirtyValue<string> _linkedLoanPurposeType;
        public string LinkedLoanPurposeType { get => _linkedLoanPurposeType; set => _linkedLoanPurposeType = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _loanPurposeType;
        public StringEnumValue<LoanPurposeType> LoanPurposeType { get => _loanPurposeType; set => _loanPurposeType = value; }
        private DirtyValue<decimal?> _lotAcres;
        public decimal? LotAcres { get => _lotAcres; set => _lotAcres = value; }
        private DirtyValue<string> _lotIdentifier;
        public string LotIdentifier { get => _lotIdentifier; set => _lotIdentifier = value; }
        private DirtyValue<string> _nameRecordingJurisdiction;
        public string NameRecordingJurisdiction { get => _nameRecordingJurisdiction; set => _nameRecordingJurisdiction = value; }
        private DirtyValue<bool?> _nonwarrantableProjectIndicator;
        public bool? NonwarrantableProjectIndicator { get => _nonwarrantableProjectIndicator; set => _nonwarrantableProjectIndicator = value; }
        private DirtyValue<decimal?> _numberOfStories;
        public decimal? NumberOfStories { get => _numberOfStories; set => _numberOfStories = value; }
        private DirtyValue<string> _otherLoanPurposeDescription;
        public string OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => _otherLoanPurposeDescription = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _priorLoanRecordationBookNumber;
        public string PriorLoanRecordationBookNumber { get => _priorLoanRecordationBookNumber; set => _priorLoanRecordationBookNumber = value; }
        private DirtyValue<decimal?> _priorLoanRecordationCurrentPrincipalAmount;
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get => _priorLoanRecordationCurrentPrincipalAmount; set => _priorLoanRecordationCurrentPrincipalAmount = value; }
        private DirtyValue<decimal?> _priorLoanRecordationOriginalPrincipalAmount;
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get => _priorLoanRecordationOriginalPrincipalAmount; set => _priorLoanRecordationOriginalPrincipalAmount = value; }
        private DirtyValue<string> _priorLoanRecordationPageNumber;
        public string PriorLoanRecordationPageNumber { get => _priorLoanRecordationPageNumber; set => _priorLoanRecordationPageNumber = value; }
        private DirtyValue<bool?> _prodIsSpInUnderservedArea;
        public bool? ProdIsSpInUnderservedArea { get => _prodIsSpInUnderservedArea; set => _prodIsSpInUnderservedArea = value; }
        private DirtyValue<string> _propertyAcquiredYear;
        public string PropertyAcquiredYear { get => _propertyAcquiredYear; set => _propertyAcquiredYear = value; }
        private DirtyValue<decimal?> _propertyExistingLienAmount;
        public decimal? PropertyExistingLienAmount { get => _propertyExistingLienAmount; set => _propertyExistingLienAmount = value; }
        private DirtyValue<DateTime?> _propertyLeaseholdExpirationDate;
        public DateTime? PropertyLeaseholdExpirationDate { get => _propertyLeaseholdExpirationDate; set => _propertyLeaseholdExpirationDate = value; }
        private DirtyValue<decimal?> _propertyOriginalCostAmount;
        public decimal? PropertyOriginalCostAmount { get => _propertyOriginalCostAmount; set => _propertyOriginalCostAmount = value; }
        private DirtyValue<StringEnumValue<PropertyRightsType>> _propertyRightsType;
        public StringEnumValue<PropertyRightsType> PropertyRightsType { get => _propertyRightsType; set => _propertyRightsType = value; }
        private DirtyValue<string> _propertyUsageType;
        public string PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<decimal?> _refinanceImprovementCostsAmount;
        public decimal? RefinanceImprovementCostsAmount { get => _refinanceImprovementCostsAmount; set => _refinanceImprovementCostsAmount = value; }
        private DirtyValue<StringEnumValue<RefinanceImprovementsType>> _refinanceImprovementsType;
        public StringEnumValue<RefinanceImprovementsType> RefinanceImprovementsType { get => _refinanceImprovementsType; set => _refinanceImprovementsType = value; }
        private DirtyValue<string> _refinancePropertyAcquiredYear;
        public string RefinancePropertyAcquiredYear { get => _refinancePropertyAcquiredYear; set => _refinancePropertyAcquiredYear = value; }
        private DirtyValue<decimal?> _refinancePropertyExistingLienAmount;
        public decimal? RefinancePropertyExistingLienAmount { get => _refinancePropertyExistingLienAmount; set => _refinancePropertyExistingLienAmount = value; }
        private DirtyValue<decimal?> _refinancePropertyOriginalCostAmount;
        public decimal? RefinancePropertyOriginalCostAmount { get => _refinancePropertyOriginalCostAmount; set => _refinancePropertyOriginalCostAmount = value; }
        private DirtyValue<string> _refinanceProposedImprovementsDescription;
        public string RefinanceProposedImprovementsDescription { get => _refinanceProposedImprovementsDescription; set => _refinanceProposedImprovementsDescription = value; }
        private DirtyValue<bool?> _ruralAreaIndicator;
        public bool? RuralAreaIndicator { get => _ruralAreaIndicator; set => _ruralAreaIndicator = value; }
        private DirtyValue<string> _sectionIdentifier;
        public string SectionIdentifier { get => _sectionIdentifier; set => _sectionIdentifier = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _streetAddress;
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private DirtyValue<string> _streetAddress2;
        public string StreetAddress2 { get => _streetAddress2; set => _streetAddress2 = value; }
        private DirtyValue<string> _structureBuiltYear;
        public string StructureBuiltYear { get => _structureBuiltYear; set => _structureBuiltYear = value; }
        private DirtyValue<bool?> _texasContinuousMoneyLoanIndicator;
        public bool? TexasContinuousMoneyLoanIndicator { get => _texasContinuousMoneyLoanIndicator; set => _texasContinuousMoneyLoanIndicator = value; }
        private DirtyValue<decimal?> _totalConstructionValueAmount;
        public decimal? TotalConstructionValueAmount { get => _totalConstructionValueAmount; set => _totalConstructionValueAmount = value; }
        private DirtyValue<string> _typeRecordingJurisdiction;
        public string TypeRecordingJurisdiction { get => _typeRecordingJurisdiction; set => _typeRecordingJurisdiction = value; }
        private DirtyValue<string> _unincorporatedAreaName;
        public string UnincorporatedAreaName { get => _unincorporatedAreaName; set => _unincorporatedAreaName = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _assessorsParcelIdentifier.Dirty
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
                    || _linkedLoanPurposeType.Dirty
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
            }
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
                _linkedLoanPurposeType.Dirty = value;
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