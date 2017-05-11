using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Property
    {
        public string OtherLoanPurposeDescription { get; set; }
        public decimal? PropertyExistingLienAmount { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int? FinancedNumberOfUnits { get; set; }
        public string LegalDescriptionText1 { get; set; }
        public string StructureBuiltYear { get; set; }
        public string LoanPurposeType { get; set; }
        public string PropertyAcquiredYear { get; set; }
        public decimal? PropertyOriginalCostAmount { get; set; }
        public decimal? LandEstimatedValueAmount { get; set; }
        public decimal? ConstructionImprovementCostsAmount { get; set; }
        public string RefinancePropertyAcquiredYear { get; set; }
        public decimal? RefinancePropertyOriginalCostAmount { get; set; }
        public decimal? RefinancePropertyExistingLienAmount { get; set; }
        public decimal? RefinanceImprovementCostsAmount { get; set; }
        public string RefinanceImprovementsType { get; set; }
        public string GseTitleMannerHeldDescription { get; set; }
        public string PropertyUsageType { get; set; }
        public string RefinanceProposedImprovementsDescription { get; set; }
        public string GseRefinancePurposeType { get; set; }
        public string BuildingStatusType { get; set; }
        public DateTime? PropertyLeaseholdExpirationDate { get; set; }
        public string PropertyRightsType { get; set; }
        public decimal? TotalConstructionValueAmount { get; set; }
        public string LegalDescriptionText2 { get; set; }
        public string AssessorsParcelIdentifier { get; set; }
        public string PriorLoanRecordationBookNumber { get; set; }
        public string PriorLoanRecordationPageNumber { get; set; }
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get; set; }
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get; set; }
        public bool? IsConstructionPhaseDisclosedSeparately { get; set; }
        public decimal? FreCashOutAmount { get; set; }
        public string LotIdentifier { get; set; }
        public string BlockIdentifier { get; set; }
        public string SectionIdentifier { get; set; }
        public string FloodCertificationIdentifier { get; set; }
        public decimal? NumberOfStories { get; set; }
        public bool? BorrowerHomesteadIndicator { get; set; }
        public bool? TexasContinuousMoneyLoanIndicator { get; set; }
        public string UnincorporatedAreaName { get; set; }
        public bool? RuralAreaIndicator { get; set; }
        public bool? CondotelIndicator { get; set; }
        public bool? NonwarrantableProjectIndicator { get; set; }
        public decimal? LotAcres { get; set; }
        public string TypeRecordingJurisdiction { get; set; }
        public string NameRecordingJurisdiction { get; set; }
        public bool? ProdIsSpInUnderservedArea { get; set; }
        public string StreetAddress2 { get; set; }
        public string LinkedLoanPurposeType { get; set; }
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get; set; }
        public string Id { get; set; }
    }
}