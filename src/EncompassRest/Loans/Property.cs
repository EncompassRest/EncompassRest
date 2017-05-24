using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Property
    {
        private Value<string> _assessorsParcelIdentifier;
        public string AssessorsParcelIdentifier { get { return _assessorsParcelIdentifier; } set { _assessorsParcelIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssessorsParcelIdentifier() => !_assessorsParcelIdentifier.Clean;
        private Value<string> _blockIdentifier;
        public string BlockIdentifier { get { return _blockIdentifier; } set { _blockIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBlockIdentifier() => !_blockIdentifier.Clean;
        private Value<bool?> _borrowerHomesteadIndicator;
        public bool? BorrowerHomesteadIndicator { get { return _borrowerHomesteadIndicator; } set { _borrowerHomesteadIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerHomesteadIndicator() => !_borrowerHomesteadIndicator.Clean;
        private Value<string> _buildingStatusType;
        public string BuildingStatusType { get { return _buildingStatusType; } set { _buildingStatusType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingStatusType() => !_buildingStatusType.Clean;
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !_city.Clean;
        private Value<bool?> _condotelIndicator;
        public bool? CondotelIndicator { get { return _condotelIndicator; } set { _condotelIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondotelIndicator() => !_condotelIndicator.Clean;
        private Value<decimal?> _constructionImprovementCostsAmount;
        public decimal? ConstructionImprovementCostsAmount { get { return _constructionImprovementCostsAmount; } set { _constructionImprovementCostsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionImprovementCostsAmount() => !_constructionImprovementCostsAmount.Clean;
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !_county.Clean;
        private Value<int?> _financedNumberOfUnits;
        public int? FinancedNumberOfUnits { get { return _financedNumberOfUnits; } set { _financedNumberOfUnits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedNumberOfUnits() => !_financedNumberOfUnits.Clean;
        private Value<string> _floodCertificationIdentifier;
        public string FloodCertificationIdentifier { get { return _floodCertificationIdentifier; } set { _floodCertificationIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodCertificationIdentifier() => !_floodCertificationIdentifier.Clean;
        private Value<decimal?> _freCashOutAmount;
        public decimal? FreCashOutAmount { get { return _freCashOutAmount; } set { _freCashOutAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreCashOutAmount() => !_freCashOutAmount.Clean;
        private Value<string> _gseRefinancePurposeType;
        public string GseRefinancePurposeType { get { return _gseRefinancePurposeType; } set { _gseRefinancePurposeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGseRefinancePurposeType() => !_gseRefinancePurposeType.Clean;
        private Value<string> _gseTitleMannerHeldDescription;
        public string GseTitleMannerHeldDescription { get { return _gseTitleMannerHeldDescription; } set { _gseTitleMannerHeldDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGseTitleMannerHeldDescription() => !_gseTitleMannerHeldDescription.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isConstructionPhaseDisclosedSeparately;
        public bool? IsConstructionPhaseDisclosedSeparately { get { return _isConstructionPhaseDisclosedSeparately; } set { _isConstructionPhaseDisclosedSeparately = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsConstructionPhaseDisclosedSeparately() => !_isConstructionPhaseDisclosedSeparately.Clean;
        private Value<decimal?> _landEstimatedValueAmount;
        public decimal? LandEstimatedValueAmount { get { return _landEstimatedValueAmount; } set { _landEstimatedValueAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandEstimatedValueAmount() => !_landEstimatedValueAmount.Clean;
        private Value<string> _legalDescriptionText1;
        public string LegalDescriptionText1 { get { return _legalDescriptionText1; } set { _legalDescriptionText1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalDescriptionText1() => !_legalDescriptionText1.Clean;
        private Value<string> _legalDescriptionText2;
        public string LegalDescriptionText2 { get { return _legalDescriptionText2; } set { _legalDescriptionText2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalDescriptionText2() => !_legalDescriptionText2.Clean;
        private Value<bool?> _linkedIsConstructionPhaseDisclosedSeparately;
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get { return _linkedIsConstructionPhaseDisclosedSeparately; } set { _linkedIsConstructionPhaseDisclosedSeparately = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinkedIsConstructionPhaseDisclosedSeparately() => !_linkedIsConstructionPhaseDisclosedSeparately.Clean;
        private Value<string> _linkedLoanPurposeType;
        public string LinkedLoanPurposeType { get { return _linkedLoanPurposeType; } set { _linkedLoanPurposeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinkedLoanPurposeType() => !_linkedLoanPurposeType.Clean;
        private Value<string> _loanPurposeType;
        public string LoanPurposeType { get { return _loanPurposeType; } set { _loanPurposeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurposeType() => !_loanPurposeType.Clean;
        private Value<decimal?> _lotAcres;
        public decimal? LotAcres { get { return _lotAcres; } set { _lotAcres = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotAcres() => !_lotAcres.Clean;
        private Value<string> _lotIdentifier;
        public string LotIdentifier { get { return _lotIdentifier; } set { _lotIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotIdentifier() => !_lotIdentifier.Clean;
        private Value<string> _nameRecordingJurisdiction;
        public string NameRecordingJurisdiction { get { return _nameRecordingJurisdiction; } set { _nameRecordingJurisdiction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameRecordingJurisdiction() => !_nameRecordingJurisdiction.Clean;
        private Value<bool?> _nonwarrantableProjectIndicator;
        public bool? NonwarrantableProjectIndicator { get { return _nonwarrantableProjectIndicator; } set { _nonwarrantableProjectIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonwarrantableProjectIndicator() => !_nonwarrantableProjectIndicator.Clean;
        private Value<decimal?> _numberOfStories;
        public decimal? NumberOfStories { get { return _numberOfStories; } set { _numberOfStories = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfStories() => !_numberOfStories.Clean;
        private Value<string> _otherLoanPurposeDescription;
        public string OtherLoanPurposeDescription { get { return _otherLoanPurposeDescription; } set { _otherLoanPurposeDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLoanPurposeDescription() => !_otherLoanPurposeDescription.Clean;
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !_postalCode.Clean;
        private Value<string> _priorLoanRecordationBookNumber;
        public string PriorLoanRecordationBookNumber { get { return _priorLoanRecordationBookNumber; } set { _priorLoanRecordationBookNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationBookNumber() => !_priorLoanRecordationBookNumber.Clean;
        private Value<decimal?> _priorLoanRecordationCurrentPrincipalAmount;
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get { return _priorLoanRecordationCurrentPrincipalAmount; } set { _priorLoanRecordationCurrentPrincipalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationCurrentPrincipalAmount() => !_priorLoanRecordationCurrentPrincipalAmount.Clean;
        private Value<decimal?> _priorLoanRecordationOriginalPrincipalAmount;
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get { return _priorLoanRecordationOriginalPrincipalAmount; } set { _priorLoanRecordationOriginalPrincipalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationOriginalPrincipalAmount() => !_priorLoanRecordationOriginalPrincipalAmount.Clean;
        private Value<string> _priorLoanRecordationPageNumber;
        public string PriorLoanRecordationPageNumber { get { return _priorLoanRecordationPageNumber; } set { _priorLoanRecordationPageNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationPageNumber() => !_priorLoanRecordationPageNumber.Clean;
        private Value<bool?> _prodIsSpInUnderservedArea;
        public bool? ProdIsSpInUnderservedArea { get { return _prodIsSpInUnderservedArea; } set { _prodIsSpInUnderservedArea = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProdIsSpInUnderservedArea() => !_prodIsSpInUnderservedArea.Clean;
        private Value<string> _propertyAcquiredYear;
        public string PropertyAcquiredYear { get { return _propertyAcquiredYear; } set { _propertyAcquiredYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAcquiredYear() => !_propertyAcquiredYear.Clean;
        private Value<decimal?> _propertyExistingLienAmount;
        public decimal? PropertyExistingLienAmount { get { return _propertyExistingLienAmount; } set { _propertyExistingLienAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyExistingLienAmount() => !_propertyExistingLienAmount.Clean;
        private Value<DateTime?> _propertyLeaseholdExpirationDate;
        public DateTime? PropertyLeaseholdExpirationDate { get { return _propertyLeaseholdExpirationDate; } set { _propertyLeaseholdExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLeaseholdExpirationDate() => !_propertyLeaseholdExpirationDate.Clean;
        private Value<decimal?> _propertyOriginalCostAmount;
        public decimal? PropertyOriginalCostAmount { get { return _propertyOriginalCostAmount; } set { _propertyOriginalCostAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOriginalCostAmount() => !_propertyOriginalCostAmount.Clean;
        private Value<string> _propertyRightsType;
        public string PropertyRightsType { get { return _propertyRightsType; } set { _propertyRightsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyRightsType() => !_propertyRightsType.Clean;
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !_propertyUsageType.Clean;
        private Value<decimal?> _refinanceImprovementCostsAmount;
        public decimal? RefinanceImprovementCostsAmount { get { return _refinanceImprovementCostsAmount; } set { _refinanceImprovementCostsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceImprovementCostsAmount() => !_refinanceImprovementCostsAmount.Clean;
        private Value<string> _refinanceImprovementsType;
        public string RefinanceImprovementsType { get { return _refinanceImprovementsType; } set { _refinanceImprovementsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceImprovementsType() => !_refinanceImprovementsType.Clean;
        private Value<string> _refinancePropertyAcquiredYear;
        public string RefinancePropertyAcquiredYear { get { return _refinancePropertyAcquiredYear; } set { _refinancePropertyAcquiredYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyAcquiredYear() => !_refinancePropertyAcquiredYear.Clean;
        private Value<decimal?> _refinancePropertyExistingLienAmount;
        public decimal? RefinancePropertyExistingLienAmount { get { return _refinancePropertyExistingLienAmount; } set { _refinancePropertyExistingLienAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyExistingLienAmount() => !_refinancePropertyExistingLienAmount.Clean;
        private Value<decimal?> _refinancePropertyOriginalCostAmount;
        public decimal? RefinancePropertyOriginalCostAmount { get { return _refinancePropertyOriginalCostAmount; } set { _refinancePropertyOriginalCostAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyOriginalCostAmount() => !_refinancePropertyOriginalCostAmount.Clean;
        private Value<string> _refinanceProposedImprovementsDescription;
        public string RefinanceProposedImprovementsDescription { get { return _refinanceProposedImprovementsDescription; } set { _refinanceProposedImprovementsDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceProposedImprovementsDescription() => !_refinanceProposedImprovementsDescription.Clean;
        private Value<bool?> _ruralAreaIndicator;
        public bool? RuralAreaIndicator { get { return _ruralAreaIndicator; } set { _ruralAreaIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRuralAreaIndicator() => !_ruralAreaIndicator.Clean;
        private Value<string> _sectionIdentifier;
        public string SectionIdentifier { get { return _sectionIdentifier; } set { _sectionIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSectionIdentifier() => !_sectionIdentifier.Clean;
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !_state.Clean;
        private Value<string> _streetAddress;
        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress() => !_streetAddress.Clean;
        private Value<string> _streetAddress2;
        public string StreetAddress2 { get { return _streetAddress2; } set { _streetAddress2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress2() => !_streetAddress2.Clean;
        private Value<string> _structureBuiltYear;
        public string StructureBuiltYear { get { return _structureBuiltYear; } set { _structureBuiltYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStructureBuiltYear() => !_structureBuiltYear.Clean;
        private Value<bool?> _texasContinuousMoneyLoanIndicator;
        public bool? TexasContinuousMoneyLoanIndicator { get { return _texasContinuousMoneyLoanIndicator; } set { _texasContinuousMoneyLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasContinuousMoneyLoanIndicator() => !_texasContinuousMoneyLoanIndicator.Clean;
        private Value<decimal?> _totalConstructionValueAmount;
        public decimal? TotalConstructionValueAmount { get { return _totalConstructionValueAmount; } set { _totalConstructionValueAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalConstructionValueAmount() => !_totalConstructionValueAmount.Clean;
        private Value<string> _typeRecordingJurisdiction;
        public string TypeRecordingJurisdiction { get { return _typeRecordingJurisdiction; } set { _typeRecordingJurisdiction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeRecordingJurisdiction() => !_typeRecordingJurisdiction.Clean;
        private Value<string> _unincorporatedAreaName;
        public string UnincorporatedAreaName { get { return _unincorporatedAreaName; } set { _unincorporatedAreaName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnincorporatedAreaName() => !_unincorporatedAreaName.Clean;
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
                var v0 = _assessorsParcelIdentifier; v0.Clean = value; _assessorsParcelIdentifier = v0;
                var v1 = _blockIdentifier; v1.Clean = value; _blockIdentifier = v1;
                var v2 = _borrowerHomesteadIndicator; v2.Clean = value; _borrowerHomesteadIndicator = v2;
                var v3 = _buildingStatusType; v3.Clean = value; _buildingStatusType = v3;
                var v4 = _city; v4.Clean = value; _city = v4;
                var v5 = _condotelIndicator; v5.Clean = value; _condotelIndicator = v5;
                var v6 = _constructionImprovementCostsAmount; v6.Clean = value; _constructionImprovementCostsAmount = v6;
                var v7 = _county; v7.Clean = value; _county = v7;
                var v8 = _financedNumberOfUnits; v8.Clean = value; _financedNumberOfUnits = v8;
                var v9 = _floodCertificationIdentifier; v9.Clean = value; _floodCertificationIdentifier = v9;
                var v10 = _freCashOutAmount; v10.Clean = value; _freCashOutAmount = v10;
                var v11 = _gseRefinancePurposeType; v11.Clean = value; _gseRefinancePurposeType = v11;
                var v12 = _gseTitleMannerHeldDescription; v12.Clean = value; _gseTitleMannerHeldDescription = v12;
                var v13 = _id; v13.Clean = value; _id = v13;
                var v14 = _isConstructionPhaseDisclosedSeparately; v14.Clean = value; _isConstructionPhaseDisclosedSeparately = v14;
                var v15 = _landEstimatedValueAmount; v15.Clean = value; _landEstimatedValueAmount = v15;
                var v16 = _legalDescriptionText1; v16.Clean = value; _legalDescriptionText1 = v16;
                var v17 = _legalDescriptionText2; v17.Clean = value; _legalDescriptionText2 = v17;
                var v18 = _linkedIsConstructionPhaseDisclosedSeparately; v18.Clean = value; _linkedIsConstructionPhaseDisclosedSeparately = v18;
                var v19 = _linkedLoanPurposeType; v19.Clean = value; _linkedLoanPurposeType = v19;
                var v20 = _loanPurposeType; v20.Clean = value; _loanPurposeType = v20;
                var v21 = _lotAcres; v21.Clean = value; _lotAcres = v21;
                var v22 = _lotIdentifier; v22.Clean = value; _lotIdentifier = v22;
                var v23 = _nameRecordingJurisdiction; v23.Clean = value; _nameRecordingJurisdiction = v23;
                var v24 = _nonwarrantableProjectIndicator; v24.Clean = value; _nonwarrantableProjectIndicator = v24;
                var v25 = _numberOfStories; v25.Clean = value; _numberOfStories = v25;
                var v26 = _otherLoanPurposeDescription; v26.Clean = value; _otherLoanPurposeDescription = v26;
                var v27 = _postalCode; v27.Clean = value; _postalCode = v27;
                var v28 = _priorLoanRecordationBookNumber; v28.Clean = value; _priorLoanRecordationBookNumber = v28;
                var v29 = _priorLoanRecordationCurrentPrincipalAmount; v29.Clean = value; _priorLoanRecordationCurrentPrincipalAmount = v29;
                var v30 = _priorLoanRecordationOriginalPrincipalAmount; v30.Clean = value; _priorLoanRecordationOriginalPrincipalAmount = v30;
                var v31 = _priorLoanRecordationPageNumber; v31.Clean = value; _priorLoanRecordationPageNumber = v31;
                var v32 = _prodIsSpInUnderservedArea; v32.Clean = value; _prodIsSpInUnderservedArea = v32;
                var v33 = _propertyAcquiredYear; v33.Clean = value; _propertyAcquiredYear = v33;
                var v34 = _propertyExistingLienAmount; v34.Clean = value; _propertyExistingLienAmount = v34;
                var v35 = _propertyLeaseholdExpirationDate; v35.Clean = value; _propertyLeaseholdExpirationDate = v35;
                var v36 = _propertyOriginalCostAmount; v36.Clean = value; _propertyOriginalCostAmount = v36;
                var v37 = _propertyRightsType; v37.Clean = value; _propertyRightsType = v37;
                var v38 = _propertyUsageType; v38.Clean = value; _propertyUsageType = v38;
                var v39 = _refinanceImprovementCostsAmount; v39.Clean = value; _refinanceImprovementCostsAmount = v39;
                var v40 = _refinanceImprovementsType; v40.Clean = value; _refinanceImprovementsType = v40;
                var v41 = _refinancePropertyAcquiredYear; v41.Clean = value; _refinancePropertyAcquiredYear = v41;
                var v42 = _refinancePropertyExistingLienAmount; v42.Clean = value; _refinancePropertyExistingLienAmount = v42;
                var v43 = _refinancePropertyOriginalCostAmount; v43.Clean = value; _refinancePropertyOriginalCostAmount = v43;
                var v44 = _refinanceProposedImprovementsDescription; v44.Clean = value; _refinanceProposedImprovementsDescription = v44;
                var v45 = _ruralAreaIndicator; v45.Clean = value; _ruralAreaIndicator = v45;
                var v46 = _sectionIdentifier; v46.Clean = value; _sectionIdentifier = v46;
                var v47 = _state; v47.Clean = value; _state = v47;
                var v48 = _streetAddress; v48.Clean = value; _streetAddress = v48;
                var v49 = _streetAddress2; v49.Clean = value; _streetAddress2 = v49;
                var v50 = _structureBuiltYear; v50.Clean = value; _structureBuiltYear = v50;
                var v51 = _texasContinuousMoneyLoanIndicator; v51.Clean = value; _texasContinuousMoneyLoanIndicator = v51;
                var v52 = _totalConstructionValueAmount; v52.Clean = value; _totalConstructionValueAmount = v52;
                var v53 = _typeRecordingJurisdiction; v53.Clean = value; _typeRecordingJurisdiction = v53;
                var v54 = _unincorporatedAreaName; v54.Clean = value; _unincorporatedAreaName = v54;
                _settingClean = 0;
            }
        }
    }
}