using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Property : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _assessorsParcelIdentifier.Clean
                    && _blockIdentifier.Clean
                    && _borrowerHomesteadIndicator.Clean
                    && _buildingStatusType.Clean
                    && _city.Clean
                    && _condotelIndicator.Clean
                    && _constructionImprovementCostsAmount.Clean
                    && _county.Clean
                    && _financedNumberOfUnits.Clean
                    && _floodCertificationIdentifier.Clean
                    && _freCashOutAmount.Clean
                    && _gseRefinancePurposeType.Clean
                    && _gseTitleMannerHeldDescription.Clean
                    && _id.Clean
                    && _isConstructionPhaseDisclosedSeparately.Clean
                    && _landEstimatedValueAmount.Clean
                    && _legalDescriptionText1.Clean
                    && _legalDescriptionText2.Clean
                    && _linkedIsConstructionPhaseDisclosedSeparately.Clean
                    && _linkedLoanPurposeType.Clean
                    && _loanPurposeType.Clean
                    && _lotAcres.Clean
                    && _lotIdentifier.Clean
                    && _nameRecordingJurisdiction.Clean
                    && _nonwarrantableProjectIndicator.Clean
                    && _numberOfStories.Clean
                    && _otherLoanPurposeDescription.Clean
                    && _postalCode.Clean
                    && _priorLoanRecordationBookNumber.Clean
                    && _priorLoanRecordationCurrentPrincipalAmount.Clean
                    && _priorLoanRecordationOriginalPrincipalAmount.Clean
                    && _priorLoanRecordationPageNumber.Clean
                    && _prodIsSpInUnderservedArea.Clean
                    && _propertyAcquiredYear.Clean
                    && _propertyExistingLienAmount.Clean
                    && _propertyLeaseholdExpirationDate.Clean
                    && _propertyOriginalCostAmount.Clean
                    && _propertyRightsType.Clean
                    && _propertyUsageType.Clean
                    && _refinanceImprovementCostsAmount.Clean
                    && _refinanceImprovementsType.Clean
                    && _refinancePropertyAcquiredYear.Clean
                    && _refinancePropertyExistingLienAmount.Clean
                    && _refinancePropertyOriginalCostAmount.Clean
                    && _refinanceProposedImprovementsDescription.Clean
                    && _ruralAreaIndicator.Clean
                    && _sectionIdentifier.Clean
                    && _state.Clean
                    && _streetAddress.Clean
                    && _streetAddress2.Clean
                    && _structureBuiltYear.Clean
                    && _texasContinuousMoneyLoanIndicator.Clean
                    && _totalConstructionValueAmount.Clean
                    && _typeRecordingJurisdiction.Clean
                    && _unincorporatedAreaName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var assessorsParcelIdentifier = _assessorsParcelIdentifier; assessorsParcelIdentifier.Clean = value; _assessorsParcelIdentifier = assessorsParcelIdentifier;
                var blockIdentifier = _blockIdentifier; blockIdentifier.Clean = value; _blockIdentifier = blockIdentifier;
                var borrowerHomesteadIndicator = _borrowerHomesteadIndicator; borrowerHomesteadIndicator.Clean = value; _borrowerHomesteadIndicator = borrowerHomesteadIndicator;
                var buildingStatusType = _buildingStatusType; buildingStatusType.Clean = value; _buildingStatusType = buildingStatusType;
                var city = _city; city.Clean = value; _city = city;
                var condotelIndicator = _condotelIndicator; condotelIndicator.Clean = value; _condotelIndicator = condotelIndicator;
                var constructionImprovementCostsAmount = _constructionImprovementCostsAmount; constructionImprovementCostsAmount.Clean = value; _constructionImprovementCostsAmount = constructionImprovementCostsAmount;
                var county = _county; county.Clean = value; _county = county;
                var financedNumberOfUnits = _financedNumberOfUnits; financedNumberOfUnits.Clean = value; _financedNumberOfUnits = financedNumberOfUnits;
                var floodCertificationIdentifier = _floodCertificationIdentifier; floodCertificationIdentifier.Clean = value; _floodCertificationIdentifier = floodCertificationIdentifier;
                var freCashOutAmount = _freCashOutAmount; freCashOutAmount.Clean = value; _freCashOutAmount = freCashOutAmount;
                var gseRefinancePurposeType = _gseRefinancePurposeType; gseRefinancePurposeType.Clean = value; _gseRefinancePurposeType = gseRefinancePurposeType;
                var gseTitleMannerHeldDescription = _gseTitleMannerHeldDescription; gseTitleMannerHeldDescription.Clean = value; _gseTitleMannerHeldDescription = gseTitleMannerHeldDescription;
                var id = _id; id.Clean = value; _id = id;
                var isConstructionPhaseDisclosedSeparately = _isConstructionPhaseDisclosedSeparately; isConstructionPhaseDisclosedSeparately.Clean = value; _isConstructionPhaseDisclosedSeparately = isConstructionPhaseDisclosedSeparately;
                var landEstimatedValueAmount = _landEstimatedValueAmount; landEstimatedValueAmount.Clean = value; _landEstimatedValueAmount = landEstimatedValueAmount;
                var legalDescriptionText1 = _legalDescriptionText1; legalDescriptionText1.Clean = value; _legalDescriptionText1 = legalDescriptionText1;
                var legalDescriptionText2 = _legalDescriptionText2; legalDescriptionText2.Clean = value; _legalDescriptionText2 = legalDescriptionText2;
                var linkedIsConstructionPhaseDisclosedSeparately = _linkedIsConstructionPhaseDisclosedSeparately; linkedIsConstructionPhaseDisclosedSeparately.Clean = value; _linkedIsConstructionPhaseDisclosedSeparately = linkedIsConstructionPhaseDisclosedSeparately;
                var linkedLoanPurposeType = _linkedLoanPurposeType; linkedLoanPurposeType.Clean = value; _linkedLoanPurposeType = linkedLoanPurposeType;
                var loanPurposeType = _loanPurposeType; loanPurposeType.Clean = value; _loanPurposeType = loanPurposeType;
                var lotAcres = _lotAcres; lotAcres.Clean = value; _lotAcres = lotAcres;
                var lotIdentifier = _lotIdentifier; lotIdentifier.Clean = value; _lotIdentifier = lotIdentifier;
                var nameRecordingJurisdiction = _nameRecordingJurisdiction; nameRecordingJurisdiction.Clean = value; _nameRecordingJurisdiction = nameRecordingJurisdiction;
                var nonwarrantableProjectIndicator = _nonwarrantableProjectIndicator; nonwarrantableProjectIndicator.Clean = value; _nonwarrantableProjectIndicator = nonwarrantableProjectIndicator;
                var numberOfStories = _numberOfStories; numberOfStories.Clean = value; _numberOfStories = numberOfStories;
                var otherLoanPurposeDescription = _otherLoanPurposeDescription; otherLoanPurposeDescription.Clean = value; _otherLoanPurposeDescription = otherLoanPurposeDescription;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var priorLoanRecordationBookNumber = _priorLoanRecordationBookNumber; priorLoanRecordationBookNumber.Clean = value; _priorLoanRecordationBookNumber = priorLoanRecordationBookNumber;
                var priorLoanRecordationCurrentPrincipalAmount = _priorLoanRecordationCurrentPrincipalAmount; priorLoanRecordationCurrentPrincipalAmount.Clean = value; _priorLoanRecordationCurrentPrincipalAmount = priorLoanRecordationCurrentPrincipalAmount;
                var priorLoanRecordationOriginalPrincipalAmount = _priorLoanRecordationOriginalPrincipalAmount; priorLoanRecordationOriginalPrincipalAmount.Clean = value; _priorLoanRecordationOriginalPrincipalAmount = priorLoanRecordationOriginalPrincipalAmount;
                var priorLoanRecordationPageNumber = _priorLoanRecordationPageNumber; priorLoanRecordationPageNumber.Clean = value; _priorLoanRecordationPageNumber = priorLoanRecordationPageNumber;
                var prodIsSpInUnderservedArea = _prodIsSpInUnderservedArea; prodIsSpInUnderservedArea.Clean = value; _prodIsSpInUnderservedArea = prodIsSpInUnderservedArea;
                var propertyAcquiredYear = _propertyAcquiredYear; propertyAcquiredYear.Clean = value; _propertyAcquiredYear = propertyAcquiredYear;
                var propertyExistingLienAmount = _propertyExistingLienAmount; propertyExistingLienAmount.Clean = value; _propertyExistingLienAmount = propertyExistingLienAmount;
                var propertyLeaseholdExpirationDate = _propertyLeaseholdExpirationDate; propertyLeaseholdExpirationDate.Clean = value; _propertyLeaseholdExpirationDate = propertyLeaseholdExpirationDate;
                var propertyOriginalCostAmount = _propertyOriginalCostAmount; propertyOriginalCostAmount.Clean = value; _propertyOriginalCostAmount = propertyOriginalCostAmount;
                var propertyRightsType = _propertyRightsType; propertyRightsType.Clean = value; _propertyRightsType = propertyRightsType;
                var propertyUsageType = _propertyUsageType; propertyUsageType.Clean = value; _propertyUsageType = propertyUsageType;
                var refinanceImprovementCostsAmount = _refinanceImprovementCostsAmount; refinanceImprovementCostsAmount.Clean = value; _refinanceImprovementCostsAmount = refinanceImprovementCostsAmount;
                var refinanceImprovementsType = _refinanceImprovementsType; refinanceImprovementsType.Clean = value; _refinanceImprovementsType = refinanceImprovementsType;
                var refinancePropertyAcquiredYear = _refinancePropertyAcquiredYear; refinancePropertyAcquiredYear.Clean = value; _refinancePropertyAcquiredYear = refinancePropertyAcquiredYear;
                var refinancePropertyExistingLienAmount = _refinancePropertyExistingLienAmount; refinancePropertyExistingLienAmount.Clean = value; _refinancePropertyExistingLienAmount = refinancePropertyExistingLienAmount;
                var refinancePropertyOriginalCostAmount = _refinancePropertyOriginalCostAmount; refinancePropertyOriginalCostAmount.Clean = value; _refinancePropertyOriginalCostAmount = refinancePropertyOriginalCostAmount;
                var refinanceProposedImprovementsDescription = _refinanceProposedImprovementsDescription; refinanceProposedImprovementsDescription.Clean = value; _refinanceProposedImprovementsDescription = refinanceProposedImprovementsDescription;
                var ruralAreaIndicator = _ruralAreaIndicator; ruralAreaIndicator.Clean = value; _ruralAreaIndicator = ruralAreaIndicator;
                var sectionIdentifier = _sectionIdentifier; sectionIdentifier.Clean = value; _sectionIdentifier = sectionIdentifier;
                var state = _state; state.Clean = value; _state = state;
                var streetAddress = _streetAddress; streetAddress.Clean = value; _streetAddress = streetAddress;
                var streetAddress2 = _streetAddress2; streetAddress2.Clean = value; _streetAddress2 = streetAddress2;
                var structureBuiltYear = _structureBuiltYear; structureBuiltYear.Clean = value; _structureBuiltYear = structureBuiltYear;
                var texasContinuousMoneyLoanIndicator = _texasContinuousMoneyLoanIndicator; texasContinuousMoneyLoanIndicator.Clean = value; _texasContinuousMoneyLoanIndicator = texasContinuousMoneyLoanIndicator;
                var totalConstructionValueAmount = _totalConstructionValueAmount; totalConstructionValueAmount.Clean = value; _totalConstructionValueAmount = totalConstructionValueAmount;
                var typeRecordingJurisdiction = _typeRecordingJurisdiction; typeRecordingJurisdiction.Clean = value; _typeRecordingJurisdiction = typeRecordingJurisdiction;
                var unincorporatedAreaName = _unincorporatedAreaName; unincorporatedAreaName.Clean = value; _unincorporatedAreaName = unincorporatedAreaName;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Property()
        {
            Clean = true;
        }
    }
}