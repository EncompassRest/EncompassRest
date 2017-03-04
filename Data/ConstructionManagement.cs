
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class ConstructionManagement
{
public bool? constructionPeriodIncludedInLoanTermFlag { get; set; }
public bool? securedBySeparateProperty { get; set; }
public DateTime? constCompletionDate { get; set; }
public decimal? maxLTVPercent { get; set; }
public decimal? holdbackPercent { get; set; }
public decimal? holdbackAmount { get; set; }
public decimal? projectDelaySurchargePercent { get; set; }
public string constOnlyAmortizationType { get; set; }
public string partialPrepaymentsElection { get; set; }
public decimal? asCompletedPurchasePrice { get; set; }
public decimal? asCompletedAppraisedValue { get; set; }
public string takeOutLenderName { get; set; }
public string takeOutLenderNMLSNumber { get; set; }
public string takeOutLenderLicenseNumber { get; set; }
public string takeOutLenderAddress { get; set; }
public string takeOutLenderCity { get; set; }
public string takeOutLenderState { get; set; }
public string takeOutLenderZip { get; set; }
public DateTime? takeOutCommitmentIssuedDate { get; set; }
public string takeOutLenderContactName { get; set; }
public string takeOutLenderContactTitle { get; set; }
public string takeOutLenderPhone { get; set; }
public string takeOutLenderEmail { get; set; }
public string takeOutLenderFax { get; set; }
public DateTime? constructionContractIssuedDate { get; set; }
public DateTime? commitmentLetterDate { get; set; }
public DateTime? commitmentExpirationDate { get; set; }
public int? returnLendersCopyCommitmentDays { get; set; }
public bool? takeOutCommitmentIndicator { get; set; }
public DateTime? takeOutCommitmentDate { get; set; }
public bool? titleInsuranceIndicator { get; set; }
public DateTime? titleInsuranceDate { get; set; }
public bool? surveyIndicator { get; set; }
public DateTime? surveyDate { get; set; }
public bool? permitsIndicator { get; set; }
public DateTime? permitsDate { get; set; }
public bool? utilityLettersIndicator { get; set; }
public DateTime? utilityLettersDate { get; set; }
public bool? plansAndSpecificationsIndicator { get; set; }
public DateTime? plansAndSpecificationsDate { get; set; }
public bool? constructionContractIndicator { get; set; }
public DateTime? constructionContractReceivedDate { get; set; }
public bool? budgetIndicator { get; set; }
public DateTime? budgetDate { get; set; }
public bool? contractorsAgreementIndicator { get; set; }
public DateTime? contractorsAgreementDate { get; set; }
public bool? architectsCertificateIndicator { get; set; }
public DateTime? architectsCertificateDate { get; set; }
public bool? environmentalAssessmentIndicator { get; set; }
public DateTime? environmentalAssessmentDate { get; set; }
public bool? soilReportIndicator { get; set; }
public DateTime? soilReportDate { get; set; }
public bool? waterTestIndicator { get; set; }
public DateTime? waterTestDate { get; set; }
public bool? percolationTestIndicator { get; set; }
public DateTime? percolationTestDate { get; set; }
public bool? paymentAndPerformanceBondsIndicator { get; set; }
public DateTime? paymentAndPerformanceBondsDate { get; set; }
public bool? lienAgentNorthCarolinaIndicator { get; set; }
public DateTime? lienAgentNorthCarolinaDate { get; set; }
public bool? floodHazardDeterminationIndicator { get; set; }
public DateTime? floodHazardDeterminationDate { get; set; }
public bool? listOfConstructionAgreementsIndicator { get; set; }
public DateTime? listOfConstructionAgreementsDate { get; set; }
public bool? otherIndicator { get; set; }
public DateTime? otherDate { get; set; }
public string otherDescription { get; set; }
public int? futureAdvancePeriod { get; set; }
public int? minimumDaysBetweenDisbursements { get; set; }
public string additionalDisbursementsConditions { get; set; }

    }
}