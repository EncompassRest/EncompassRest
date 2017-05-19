using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ConstructionManagement
    {
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get; set; }
        public bool? SecuredBySeparateProperty { get; set; }
        public DateTime? ConstCompletionDate { get; set; }
        public decimal? MaxLTVPercent { get; set; }
        public decimal? HoldbackPercent { get; set; }
        public decimal? HoldbackAmount { get; set; }
        public decimal? ProjectDelaySurchargePercent { get; set; }
        public string ConstOnlyAmortizationType { get; set; }
        public string PartialPrepaymentsElection { get; set; }
        public decimal? AsCompletedPurchasePrice { get; set; }
        public decimal? AsCompletedAppraisedValue { get; set; }
        public string TakeOutLenderName { get; set; }
        public string TakeOutLenderNMLSNumber { get; set; }
        public string TakeOutLenderLicenseNumber { get; set; }
        public string TakeOutLenderAddress { get; set; }
        public string TakeOutLenderCity { get; set; }
        public string TakeOutLenderState { get; set; }
        public string TakeOutLenderZip { get; set; }
        public DateTime? TakeOutCommitmentIssuedDate { get; set; }
        public string TakeOutLenderContactName { get; set; }
        public string TakeOutLenderContactTitle { get; set; }
        public string TakeOutLenderPhone { get; set; }
        public string TakeOutLenderEmail { get; set; }
        public string TakeOutLenderFax { get; set; }
        public DateTime? ConstructionContractIssuedDate { get; set; }
        public DateTime? CommitmentLetterDate { get; set; }
        public DateTime? CommitmentExpirationDate { get; set; }
        public int? ReturnLendersCopyCommitmentDays { get; set; }
        public bool? TakeOutCommitmentIndicator { get; set; }
        public DateTime? TakeOutCommitmentDate { get; set; }
        public bool? TitleInsuranceIndicator { get; set; }
        public DateTime? TitleInsuranceDate { get; set; }
        public bool? SurveyIndicator { get; set; }
        public DateTime? SurveyDate { get; set; }
        public bool? PermitsIndicator { get; set; }
        public DateTime? PermitsDate { get; set; }
        public bool? UtilityLettersIndicator { get; set; }
        public DateTime? UtilityLettersDate { get; set; }
        public bool? PlansAndSpecificationsIndicator { get; set; }
        public DateTime? PlansAndSpecificationsDate { get; set; }
        public bool? ConstructionContractIndicator { get; set; }
        public DateTime? ConstructionContractReceivedDate { get; set; }
        public bool? BudgetIndicator { get; set; }
        public DateTime? BudgetDate { get; set; }
        public bool? ContractorsAgreementIndicator { get; set; }
        public DateTime? ContractorsAgreementDate { get; set; }
        public bool? ArchitectsCertificateIndicator { get; set; }
        public DateTime? ArchitectsCertificateDate { get; set; }
        public bool? EnvironmentalAssessmentIndicator { get; set; }
        public DateTime? EnvironmentalAssessmentDate { get; set; }
        public bool? SoilReportIndicator { get; set; }
        public DateTime? SoilReportDate { get; set; }
        public bool? WaterTestIndicator { get; set; }
        public DateTime? WaterTestDate { get; set; }
        public bool? PercolationTestIndicator { get; set; }
        public DateTime? PercolationTestDate { get; set; }
        public bool? PaymentAndPerformanceBondsIndicator { get; set; }
        public DateTime? PaymentAndPerformanceBondsDate { get; set; }
        public bool? LienAgentNorthCarolinaIndicator { get; set; }
        public DateTime? LienAgentNorthCarolinaDate { get; set; }
        public bool? FloodHazardDeterminationIndicator { get; set; }
        public DateTime? FloodHazardDeterminationDate { get; set; }
        public bool? ListOfConstructionAgreementsIndicator { get; set; }
        public DateTime? ListOfConstructionAgreementsDate { get; set; }
        public bool? OtherIndicator { get; set; }
        public DateTime? OtherDate { get; set; }
        public string OtherDescription { get; set; }
        public int? FutureAdvancePeriod { get; set; }
        public int? MinimumDaysBetweenDisbursements { get; set; }
        public string AdditionalDisbursementsConditions { get; set; }
    }
}