using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Property
    {
        public string otherLoanPurposeDescription { get; set; }
        public decimal? propertyExistingLienAmount { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public int? financedNumberOfUnits { get; set; }
        public string legalDescriptionText1 { get; set; }
        public string structureBuiltYear { get; set; }
        public string loanPurposeType { get; set; }
        public string propertyAcquiredYear { get; set; }
        public decimal? propertyOriginalCostAmount { get; set; }
        public decimal? landEstimatedValueAmount { get; set; }
        public decimal? constructionImprovementCostsAmount { get; set; }
        public string refinancePropertyAcquiredYear { get; set; }
        public decimal? refinancePropertyOriginalCostAmount { get; set; }
        public decimal? refinancePropertyExistingLienAmount { get; set; }
        public decimal? refinanceImprovementCostsAmount { get; set; }
        public string refinanceImprovementsType { get; set; }
        public string gseTitleMannerHeldDescription { get; set; }
        public string propertyUsageType { get; set; }
        public string refinanceProposedImprovementsDescription { get; set; }
        public string gseRefinancePurposeType { get; set; }
        public string buildingStatusType { get; set; }
        public DateTime? propertyLeaseholdExpirationDate { get; set; }
        public string propertyRightsType { get; set; }
        public decimal? totalConstructionValueAmount { get; set; }
        public string legalDescriptionText2 { get; set; }
        public string assessorsParcelIdentifier { get; set; }
        public string priorLoanRecordationBookNumber { get; set; }
        public string priorLoanRecordationPageNumber { get; set; }
        public decimal? priorLoanRecordationOriginalPrincipalAmount { get; set; }
        public decimal? priorLoanRecordationCurrentPrincipalAmount { get; set; }
        public bool? isConstructionPhaseDisclosedSeparately { get; set; }
        public decimal? freCashOutAmount { get; set; }
        public string lotIdentifier { get; set; }
        public string blockIdentifier { get; set; }
        public string sectionIdentifier { get; set; }
        public string floodCertificationIdentifier { get; set; }
        public decimal? numberOfStories { get; set; }
        public bool? borrowerHomesteadIndicator { get; set; }
        public bool? texasContinuousMoneyLoanIndicator { get; set; }
        public string unincorporatedAreaName { get; set; }
        public bool? ruralAreaIndicator { get; set; }
        public bool? condotelIndicator { get; set; }
        public bool? nonwarrantableProjectIndicator { get; set; }
        public decimal? lotAcres { get; set; }
        public string typeRecordingJurisdiction { get; set; }
        public string nameRecordingJurisdiction { get; set; }
        public bool? prodIsSpInUnderservedArea { get; set; }
        public string streetAddress2 { get; set; }
        public string id { get; set; }

    }
}
