using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Property
    {
        public Value<string> AssessorsParcelIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssessorsParcelIdentifier() => !AssessorsParcelIdentifier.Clean;
        public Value<string> BlockIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBlockIdentifier() => !BlockIdentifier.Clean;
        public Value<bool?> BorrowerHomesteadIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerHomesteadIndicator() => !BorrowerHomesteadIndicator.Clean;
        public Value<string> BuildingStatusType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingStatusType() => !BuildingStatusType.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<bool?> CondotelIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondotelIndicator() => !CondotelIndicator.Clean;
        public Value<decimal?> ConstructionImprovementCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionImprovementCostsAmount() => !ConstructionImprovementCostsAmount.Clean;
        public Value<string> County { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !County.Clean;
        public Value<int?> FinancedNumberOfUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedNumberOfUnits() => !FinancedNumberOfUnits.Clean;
        public Value<string> FloodCertificationIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodCertificationIdentifier() => !FloodCertificationIdentifier.Clean;
        public Value<decimal?> FreCashOutAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreCashOutAmount() => !FreCashOutAmount.Clean;
        public Value<string> GseRefinancePurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGseRefinancePurposeType() => !GseRefinancePurposeType.Clean;
        public Value<string> GseTitleMannerHeldDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGseTitleMannerHeldDescription() => !GseTitleMannerHeldDescription.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsConstructionPhaseDisclosedSeparately { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsConstructionPhaseDisclosedSeparately() => !IsConstructionPhaseDisclosedSeparately.Clean;
        public Value<decimal?> LandEstimatedValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandEstimatedValueAmount() => !LandEstimatedValueAmount.Clean;
        public Value<string> LegalDescriptionText1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalDescriptionText1() => !LegalDescriptionText1.Clean;
        public Value<string> LegalDescriptionText2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalDescriptionText2() => !LegalDescriptionText2.Clean;
        public Value<bool?> LinkedIsConstructionPhaseDisclosedSeparately { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinkedIsConstructionPhaseDisclosedSeparately() => !LinkedIsConstructionPhaseDisclosedSeparately.Clean;
        public Value<string> LinkedLoanPurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinkedLoanPurposeType() => !LinkedLoanPurposeType.Clean;
        public Value<string> LoanPurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurposeType() => !LoanPurposeType.Clean;
        public Value<decimal?> LotAcres { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotAcres() => !LotAcres.Clean;
        public Value<string> LotIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotIdentifier() => !LotIdentifier.Clean;
        public Value<string> NameRecordingJurisdiction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameRecordingJurisdiction() => !NameRecordingJurisdiction.Clean;
        public Value<bool?> NonwarrantableProjectIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonwarrantableProjectIndicator() => !NonwarrantableProjectIndicator.Clean;
        public Value<decimal?> NumberOfStories { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfStories() => !NumberOfStories.Clean;
        public Value<string> OtherLoanPurposeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLoanPurposeDescription() => !OtherLoanPurposeDescription.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> PriorLoanRecordationBookNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationBookNumber() => !PriorLoanRecordationBookNumber.Clean;
        public Value<decimal?> PriorLoanRecordationCurrentPrincipalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationCurrentPrincipalAmount() => !PriorLoanRecordationCurrentPrincipalAmount.Clean;
        public Value<decimal?> PriorLoanRecordationOriginalPrincipalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationOriginalPrincipalAmount() => !PriorLoanRecordationOriginalPrincipalAmount.Clean;
        public Value<string> PriorLoanRecordationPageNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanRecordationPageNumber() => !PriorLoanRecordationPageNumber.Clean;
        public Value<bool?> ProdIsSpInUnderservedArea { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProdIsSpInUnderservedArea() => !ProdIsSpInUnderservedArea.Clean;
        public Value<string> PropertyAcquiredYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAcquiredYear() => !PropertyAcquiredYear.Clean;
        public Value<decimal?> PropertyExistingLienAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyExistingLienAmount() => !PropertyExistingLienAmount.Clean;
        public Value<DateTime?> PropertyLeaseholdExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLeaseholdExpirationDate() => !PropertyLeaseholdExpirationDate.Clean;
        public Value<decimal?> PropertyOriginalCostAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOriginalCostAmount() => !PropertyOriginalCostAmount.Clean;
        public Value<string> PropertyRightsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyRightsType() => !PropertyRightsType.Clean;
        public Value<string> PropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !PropertyUsageType.Clean;
        public Value<decimal?> RefinanceImprovementCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceImprovementCostsAmount() => !RefinanceImprovementCostsAmount.Clean;
        public Value<string> RefinanceImprovementsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceImprovementsType() => !RefinanceImprovementsType.Clean;
        public Value<string> RefinancePropertyAcquiredYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyAcquiredYear() => !RefinancePropertyAcquiredYear.Clean;
        public Value<decimal?> RefinancePropertyExistingLienAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyExistingLienAmount() => !RefinancePropertyExistingLienAmount.Clean;
        public Value<decimal?> RefinancePropertyOriginalCostAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancePropertyOriginalCostAmount() => !RefinancePropertyOriginalCostAmount.Clean;
        public Value<string> RefinanceProposedImprovementsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceProposedImprovementsDescription() => !RefinanceProposedImprovementsDescription.Clean;
        public Value<bool?> RuralAreaIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRuralAreaIndicator() => !RuralAreaIndicator.Clean;
        public Value<string> SectionIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSectionIdentifier() => !SectionIdentifier.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> StreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress() => !StreetAddress.Clean;
        public Value<string> StreetAddress2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAddress2() => !StreetAddress2.Clean;
        public Value<string> StructureBuiltYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStructureBuiltYear() => !StructureBuiltYear.Clean;
        public Value<bool?> TexasContinuousMoneyLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasContinuousMoneyLoanIndicator() => !TexasContinuousMoneyLoanIndicator.Clean;
        public Value<decimal?> TotalConstructionValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalConstructionValueAmount() => !TotalConstructionValueAmount.Clean;
        public Value<string> TypeRecordingJurisdiction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeRecordingJurisdiction() => !TypeRecordingJurisdiction.Clean;
        public Value<string> UnincorporatedAreaName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnincorporatedAreaName() => !UnincorporatedAreaName.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AssessorsParcelIdentifier.Clean
                    && BlockIdentifier.Clean
                    && BorrowerHomesteadIndicator.Clean
                    && BuildingStatusType.Clean
                    && City.Clean
                    && CondotelIndicator.Clean
                    && ConstructionImprovementCostsAmount.Clean
                    && County.Clean
                    && FinancedNumberOfUnits.Clean
                    && FloodCertificationIdentifier.Clean
                    && FreCashOutAmount.Clean
                    && GseRefinancePurposeType.Clean
                    && GseTitleMannerHeldDescription.Clean
                    && Id.Clean
                    && IsConstructionPhaseDisclosedSeparately.Clean
                    && LandEstimatedValueAmount.Clean
                    && LegalDescriptionText1.Clean
                    && LegalDescriptionText2.Clean
                    && LinkedIsConstructionPhaseDisclosedSeparately.Clean
                    && LinkedLoanPurposeType.Clean
                    && LoanPurposeType.Clean
                    && LotAcres.Clean
                    && LotIdentifier.Clean
                    && NameRecordingJurisdiction.Clean
                    && NonwarrantableProjectIndicator.Clean
                    && NumberOfStories.Clean
                    && OtherLoanPurposeDescription.Clean
                    && PostalCode.Clean
                    && PriorLoanRecordationBookNumber.Clean
                    && PriorLoanRecordationCurrentPrincipalAmount.Clean
                    && PriorLoanRecordationOriginalPrincipalAmount.Clean
                    && PriorLoanRecordationPageNumber.Clean
                    && ProdIsSpInUnderservedArea.Clean
                    && PropertyAcquiredYear.Clean
                    && PropertyExistingLienAmount.Clean
                    && PropertyLeaseholdExpirationDate.Clean
                    && PropertyOriginalCostAmount.Clean
                    && PropertyRightsType.Clean
                    && PropertyUsageType.Clean
                    && RefinanceImprovementCostsAmount.Clean
                    && RefinanceImprovementsType.Clean
                    && RefinancePropertyAcquiredYear.Clean
                    && RefinancePropertyExistingLienAmount.Clean
                    && RefinancePropertyOriginalCostAmount.Clean
                    && RefinanceProposedImprovementsDescription.Clean
                    && RuralAreaIndicator.Clean
                    && SectionIdentifier.Clean
                    && State.Clean
                    && StreetAddress.Clean
                    && StreetAddress2.Clean
                    && StructureBuiltYear.Clean
                    && TexasContinuousMoneyLoanIndicator.Clean
                    && TotalConstructionValueAmount.Clean
                    && TypeRecordingJurisdiction.Clean
                    && UnincorporatedAreaName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AssessorsParcelIdentifier; v0.Clean = value; AssessorsParcelIdentifier = v0;
                var v1 = BlockIdentifier; v1.Clean = value; BlockIdentifier = v1;
                var v2 = BorrowerHomesteadIndicator; v2.Clean = value; BorrowerHomesteadIndicator = v2;
                var v3 = BuildingStatusType; v3.Clean = value; BuildingStatusType = v3;
                var v4 = City; v4.Clean = value; City = v4;
                var v5 = CondotelIndicator; v5.Clean = value; CondotelIndicator = v5;
                var v6 = ConstructionImprovementCostsAmount; v6.Clean = value; ConstructionImprovementCostsAmount = v6;
                var v7 = County; v7.Clean = value; County = v7;
                var v8 = FinancedNumberOfUnits; v8.Clean = value; FinancedNumberOfUnits = v8;
                var v9 = FloodCertificationIdentifier; v9.Clean = value; FloodCertificationIdentifier = v9;
                var v10 = FreCashOutAmount; v10.Clean = value; FreCashOutAmount = v10;
                var v11 = GseRefinancePurposeType; v11.Clean = value; GseRefinancePurposeType = v11;
                var v12 = GseTitleMannerHeldDescription; v12.Clean = value; GseTitleMannerHeldDescription = v12;
                var v13 = Id; v13.Clean = value; Id = v13;
                var v14 = IsConstructionPhaseDisclosedSeparately; v14.Clean = value; IsConstructionPhaseDisclosedSeparately = v14;
                var v15 = LandEstimatedValueAmount; v15.Clean = value; LandEstimatedValueAmount = v15;
                var v16 = LegalDescriptionText1; v16.Clean = value; LegalDescriptionText1 = v16;
                var v17 = LegalDescriptionText2; v17.Clean = value; LegalDescriptionText2 = v17;
                var v18 = LinkedIsConstructionPhaseDisclosedSeparately; v18.Clean = value; LinkedIsConstructionPhaseDisclosedSeparately = v18;
                var v19 = LinkedLoanPurposeType; v19.Clean = value; LinkedLoanPurposeType = v19;
                var v20 = LoanPurposeType; v20.Clean = value; LoanPurposeType = v20;
                var v21 = LotAcres; v21.Clean = value; LotAcres = v21;
                var v22 = LotIdentifier; v22.Clean = value; LotIdentifier = v22;
                var v23 = NameRecordingJurisdiction; v23.Clean = value; NameRecordingJurisdiction = v23;
                var v24 = NonwarrantableProjectIndicator; v24.Clean = value; NonwarrantableProjectIndicator = v24;
                var v25 = NumberOfStories; v25.Clean = value; NumberOfStories = v25;
                var v26 = OtherLoanPurposeDescription; v26.Clean = value; OtherLoanPurposeDescription = v26;
                var v27 = PostalCode; v27.Clean = value; PostalCode = v27;
                var v28 = PriorLoanRecordationBookNumber; v28.Clean = value; PriorLoanRecordationBookNumber = v28;
                var v29 = PriorLoanRecordationCurrentPrincipalAmount; v29.Clean = value; PriorLoanRecordationCurrentPrincipalAmount = v29;
                var v30 = PriorLoanRecordationOriginalPrincipalAmount; v30.Clean = value; PriorLoanRecordationOriginalPrincipalAmount = v30;
                var v31 = PriorLoanRecordationPageNumber; v31.Clean = value; PriorLoanRecordationPageNumber = v31;
                var v32 = ProdIsSpInUnderservedArea; v32.Clean = value; ProdIsSpInUnderservedArea = v32;
                var v33 = PropertyAcquiredYear; v33.Clean = value; PropertyAcquiredYear = v33;
                var v34 = PropertyExistingLienAmount; v34.Clean = value; PropertyExistingLienAmount = v34;
                var v35 = PropertyLeaseholdExpirationDate; v35.Clean = value; PropertyLeaseholdExpirationDate = v35;
                var v36 = PropertyOriginalCostAmount; v36.Clean = value; PropertyOriginalCostAmount = v36;
                var v37 = PropertyRightsType; v37.Clean = value; PropertyRightsType = v37;
                var v38 = PropertyUsageType; v38.Clean = value; PropertyUsageType = v38;
                var v39 = RefinanceImprovementCostsAmount; v39.Clean = value; RefinanceImprovementCostsAmount = v39;
                var v40 = RefinanceImprovementsType; v40.Clean = value; RefinanceImprovementsType = v40;
                var v41 = RefinancePropertyAcquiredYear; v41.Clean = value; RefinancePropertyAcquiredYear = v41;
                var v42 = RefinancePropertyExistingLienAmount; v42.Clean = value; RefinancePropertyExistingLienAmount = v42;
                var v43 = RefinancePropertyOriginalCostAmount; v43.Clean = value; RefinancePropertyOriginalCostAmount = v43;
                var v44 = RefinanceProposedImprovementsDescription; v44.Clean = value; RefinanceProposedImprovementsDescription = v44;
                var v45 = RuralAreaIndicator; v45.Clean = value; RuralAreaIndicator = v45;
                var v46 = SectionIdentifier; v46.Clean = value; SectionIdentifier = v46;
                var v47 = State; v47.Clean = value; State = v47;
                var v48 = StreetAddress; v48.Clean = value; StreetAddress = v48;
                var v49 = StreetAddress2; v49.Clean = value; StreetAddress2 = v49;
                var v50 = StructureBuiltYear; v50.Clean = value; StructureBuiltYear = v50;
                var v51 = TexasContinuousMoneyLoanIndicator; v51.Clean = value; TexasContinuousMoneyLoanIndicator = v51;
                var v52 = TotalConstructionValueAmount; v52.Clean = value; TotalConstructionValueAmount = v52;
                var v53 = TypeRecordingJurisdiction; v53.Clean = value; TypeRecordingJurisdiction = v53;
                var v54 = UnincorporatedAreaName; v54.Clean = value; UnincorporatedAreaName = v54;
                _settingClean = 0;
            }
        }
    }
}