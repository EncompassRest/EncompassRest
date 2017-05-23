using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Property
    {
        public string AssessorsParcelIdentifier { get; set; }
        public string BlockIdentifier { get; set; }
        public JsonNullable<bool?> BorrowerHomesteadIndicator { get; set; }
        public string BuildingStatusType { get; set; }
        public string City { get; set; }
        public JsonNullable<bool?> CondotelIndicator { get; set; }
        public JsonNullable<decimal?> ConstructionImprovementCostsAmount { get; set; }
        public string County { get; set; }
        public JsonNullable<int?> FinancedNumberOfUnits { get; set; }
        public string FloodCertificationIdentifier { get; set; }
        public JsonNullable<decimal?> FreCashOutAmount { get; set; }
        public string GseRefinancePurposeType { get; set; }
        public string GseTitleMannerHeldDescription { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IsConstructionPhaseDisclosedSeparately { get; set; }
        public JsonNullable<decimal?> LandEstimatedValueAmount { get; set; }
        public string LegalDescriptionText1 { get; set; }
        public string LegalDescriptionText2 { get; set; }
        public JsonNullable<bool?> LinkedIsConstructionPhaseDisclosedSeparately { get; set; }
        public string LinkedLoanPurposeType { get; set; }
        public string LoanPurposeType { get; set; }
        public JsonNullable<decimal?> LotAcres { get; set; }
        public string LotIdentifier { get; set; }
        public string NameRecordingJurisdiction { get; set; }
        public JsonNullable<bool?> NonwarrantableProjectIndicator { get; set; }
        public JsonNullable<decimal?> NumberOfStories { get; set; }
        public string OtherLoanPurposeDescription { get; set; }
        public string PostalCode { get; set; }
        public string PriorLoanRecordationBookNumber { get; set; }
        public JsonNullable<decimal?> PriorLoanRecordationCurrentPrincipalAmount { get; set; }
        public JsonNullable<decimal?> PriorLoanRecordationOriginalPrincipalAmount { get; set; }
        public string PriorLoanRecordationPageNumber { get; set; }
        public JsonNullable<bool?> ProdIsSpInUnderservedArea { get; set; }
        public string PropertyAcquiredYear { get; set; }
        public JsonNullable<decimal?> PropertyExistingLienAmount { get; set; }
        public JsonNullable<DateTime?> PropertyLeaseholdExpirationDate { get; set; }
        public JsonNullable<decimal?> PropertyOriginalCostAmount { get; set; }
        public string PropertyRightsType { get; set; }
        public string PropertyUsageType { get; set; }
        public JsonNullable<decimal?> RefinanceImprovementCostsAmount { get; set; }
        public string RefinanceImprovementsType { get; set; }
        public string RefinancePropertyAcquiredYear { get; set; }
        public JsonNullable<decimal?> RefinancePropertyExistingLienAmount { get; set; }
        public JsonNullable<decimal?> RefinancePropertyOriginalCostAmount { get; set; }
        public string RefinanceProposedImprovementsDescription { get; set; }
        public JsonNullable<bool?> RuralAreaIndicator { get; set; }
        public string SectionIdentifier { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string StructureBuiltYear { get; set; }
        public JsonNullable<bool?> TexasContinuousMoneyLoanIndicator { get; set; }
        public JsonNullable<decimal?> TotalConstructionValueAmount { get; set; }
        public string TypeRecordingJurisdiction { get; set; }
        public string UnincorporatedAreaName { get; set; }
    }
}