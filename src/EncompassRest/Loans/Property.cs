using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Property : IDirty
    {
        private Value<string> _assessorsParcelIdentifier;
        public string AssessorsParcelIdentifier { get { return _assessorsParcelIdentifier; } set { _assessorsParcelIdentifier = value; } }
        private Value<string> _blockIdentifier;
        public string BlockIdentifier { get { return _blockIdentifier; } set { _blockIdentifier = value; } }
        private Value<bool?> _borrowerHomesteadIndicator;
        public bool? BorrowerHomesteadIndicator { get { return _borrowerHomesteadIndicator; } set { _borrowerHomesteadIndicator = value; } }
        private Value<string> _buildingStatusType;
        public string BuildingStatusType { get { return _buildingStatusType; } set { _buildingStatusType = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<bool?> _condotelIndicator;
        public bool? CondotelIndicator { get { return _condotelIndicator; } set { _condotelIndicator = value; } }
        private Value<decimal?> _constructionImprovementCostsAmount;
        public decimal? ConstructionImprovementCostsAmount { get { return _constructionImprovementCostsAmount; } set { _constructionImprovementCostsAmount = value; } }
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        private Value<int?> _financedNumberOfUnits;
        public int? FinancedNumberOfUnits { get { return _financedNumberOfUnits; } set { _financedNumberOfUnits = value; } }
        private Value<string> _floodCertificationIdentifier;
        public string FloodCertificationIdentifier { get { return _floodCertificationIdentifier; } set { _floodCertificationIdentifier = value; } }
        private Value<decimal?> _freCashOutAmount;
        public decimal? FreCashOutAmount { get { return _freCashOutAmount; } set { _freCashOutAmount = value; } }
        private Value<string> _gseRefinancePurposeType;
        public string GseRefinancePurposeType { get { return _gseRefinancePurposeType; } set { _gseRefinancePurposeType = value; } }
        private Value<string> _gseTitleMannerHeldDescription;
        public string GseTitleMannerHeldDescription { get { return _gseTitleMannerHeldDescription; } set { _gseTitleMannerHeldDescription = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isConstructionPhaseDisclosedSeparately;
        public bool? IsConstructionPhaseDisclosedSeparately { get { return _isConstructionPhaseDisclosedSeparately; } set { _isConstructionPhaseDisclosedSeparately = value; } }
        private Value<decimal?> _landEstimatedValueAmount;
        public decimal? LandEstimatedValueAmount { get { return _landEstimatedValueAmount; } set { _landEstimatedValueAmount = value; } }
        private Value<string> _legalDescriptionText1;
        public string LegalDescriptionText1 { get { return _legalDescriptionText1; } set { _legalDescriptionText1 = value; } }
        private Value<string> _legalDescriptionText2;
        public string LegalDescriptionText2 { get { return _legalDescriptionText2; } set { _legalDescriptionText2 = value; } }
        private Value<bool?> _linkedIsConstructionPhaseDisclosedSeparately;
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get { return _linkedIsConstructionPhaseDisclosedSeparately; } set { _linkedIsConstructionPhaseDisclosedSeparately = value; } }
        private Value<string> _linkedLoanPurposeType;
        public string LinkedLoanPurposeType { get { return _linkedLoanPurposeType; } set { _linkedLoanPurposeType = value; } }
        private Value<string> _loanPurposeType;
        public string LoanPurposeType { get { return _loanPurposeType; } set { _loanPurposeType = value; } }
        private Value<decimal?> _lotAcres;
        public decimal? LotAcres { get { return _lotAcres; } set { _lotAcres = value; } }
        private Value<string> _lotIdentifier;
        public string LotIdentifier { get { return _lotIdentifier; } set { _lotIdentifier = value; } }
        private Value<string> _nameRecordingJurisdiction;
        public string NameRecordingJurisdiction { get { return _nameRecordingJurisdiction; } set { _nameRecordingJurisdiction = value; } }
        private Value<bool?> _nonwarrantableProjectIndicator;
        public bool? NonwarrantableProjectIndicator { get { return _nonwarrantableProjectIndicator; } set { _nonwarrantableProjectIndicator = value; } }
        private Value<decimal?> _numberOfStories;
        public decimal? NumberOfStories { get { return _numberOfStories; } set { _numberOfStories = value; } }
        private Value<string> _otherLoanPurposeDescription;
        public string OtherLoanPurposeDescription { get { return _otherLoanPurposeDescription; } set { _otherLoanPurposeDescription = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _priorLoanRecordationBookNumber;
        public string PriorLoanRecordationBookNumber { get { return _priorLoanRecordationBookNumber; } set { _priorLoanRecordationBookNumber = value; } }
        private Value<decimal?> _priorLoanRecordationCurrentPrincipalAmount;
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get { return _priorLoanRecordationCurrentPrincipalAmount; } set { _priorLoanRecordationCurrentPrincipalAmount = value; } }
        private Value<decimal?> _priorLoanRecordationOriginalPrincipalAmount;
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get { return _priorLoanRecordationOriginalPrincipalAmount; } set { _priorLoanRecordationOriginalPrincipalAmount = value; } }
        private Value<string> _priorLoanRecordationPageNumber;
        public string PriorLoanRecordationPageNumber { get { return _priorLoanRecordationPageNumber; } set { _priorLoanRecordationPageNumber = value; } }
        private Value<bool?> _prodIsSpInUnderservedArea;
        public bool? ProdIsSpInUnderservedArea { get { return _prodIsSpInUnderservedArea; } set { _prodIsSpInUnderservedArea = value; } }
        private Value<string> _propertyAcquiredYear;
        public string PropertyAcquiredYear { get { return _propertyAcquiredYear; } set { _propertyAcquiredYear = value; } }
        private Value<decimal?> _propertyExistingLienAmount;
        public decimal? PropertyExistingLienAmount { get { return _propertyExistingLienAmount; } set { _propertyExistingLienAmount = value; } }
        private Value<DateTime?> _propertyLeaseholdExpirationDate;
        public DateTime? PropertyLeaseholdExpirationDate { get { return _propertyLeaseholdExpirationDate; } set { _propertyLeaseholdExpirationDate = value; } }
        private Value<decimal?> _propertyOriginalCostAmount;
        public decimal? PropertyOriginalCostAmount { get { return _propertyOriginalCostAmount; } set { _propertyOriginalCostAmount = value; } }
        private Value<string> _propertyRightsType;
        public string PropertyRightsType { get { return _propertyRightsType; } set { _propertyRightsType = value; } }
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private Value<decimal?> _refinanceImprovementCostsAmount;
        public decimal? RefinanceImprovementCostsAmount { get { return _refinanceImprovementCostsAmount; } set { _refinanceImprovementCostsAmount = value; } }
        private Value<string> _refinanceImprovementsType;
        public string RefinanceImprovementsType { get { return _refinanceImprovementsType; } set { _refinanceImprovementsType = value; } }
        private Value<string> _refinancePropertyAcquiredYear;
        public string RefinancePropertyAcquiredYear { get { return _refinancePropertyAcquiredYear; } set { _refinancePropertyAcquiredYear = value; } }
        private Value<decimal?> _refinancePropertyExistingLienAmount;
        public decimal? RefinancePropertyExistingLienAmount { get { return _refinancePropertyExistingLienAmount; } set { _refinancePropertyExistingLienAmount = value; } }
        private Value<decimal?> _refinancePropertyOriginalCostAmount;
        public decimal? RefinancePropertyOriginalCostAmount { get { return _refinancePropertyOriginalCostAmount; } set { _refinancePropertyOriginalCostAmount = value; } }
        private Value<string> _refinanceProposedImprovementsDescription;
        public string RefinanceProposedImprovementsDescription { get { return _refinanceProposedImprovementsDescription; } set { _refinanceProposedImprovementsDescription = value; } }
        private Value<bool?> _ruralAreaIndicator;
        public bool? RuralAreaIndicator { get { return _ruralAreaIndicator; } set { _ruralAreaIndicator = value; } }
        private Value<string> _sectionIdentifier;
        public string SectionIdentifier { get { return _sectionIdentifier; } set { _sectionIdentifier = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _streetAddress;
        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        private Value<string> _streetAddress2;
        public string StreetAddress2 { get { return _streetAddress2; } set { _streetAddress2 = value; } }
        private Value<string> _structureBuiltYear;
        public string StructureBuiltYear { get { return _structureBuiltYear; } set { _structureBuiltYear = value; } }
        private Value<bool?> _texasContinuousMoneyLoanIndicator;
        public bool? TexasContinuousMoneyLoanIndicator { get { return _texasContinuousMoneyLoanIndicator; } set { _texasContinuousMoneyLoanIndicator = value; } }
        private Value<decimal?> _totalConstructionValueAmount;
        public decimal? TotalConstructionValueAmount { get { return _totalConstructionValueAmount; } set { _totalConstructionValueAmount = value; } }
        private Value<string> _typeRecordingJurisdiction;
        public string TypeRecordingJurisdiction { get { return _typeRecordingJurisdiction; } set { _typeRecordingJurisdiction = value; } }
        private Value<string> _unincorporatedAreaName;
        public string UnincorporatedAreaName { get { return _unincorporatedAreaName; } set { _unincorporatedAreaName = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _assessorsParcelIdentifier.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}