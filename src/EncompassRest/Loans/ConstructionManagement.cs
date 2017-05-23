using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ConstructionManagement
    {
        public string AdditionalDisbursementsConditions { get; set; }
        public JsonNullable<DateTime?> ArchitectsCertificateDate { get; set; }
        public JsonNullable<bool?> ArchitectsCertificateIndicator { get; set; }
        public JsonNullable<decimal?> AsCompletedAppraisedValue { get; set; }
        public JsonNullable<decimal?> AsCompletedPurchasePrice { get; set; }
        public JsonNullable<DateTime?> BudgetDate { get; set; }
        public JsonNullable<bool?> BudgetIndicator { get; set; }
        public JsonNullable<DateTime?> CommitmentExpirationDate { get; set; }
        public JsonNullable<DateTime?> CommitmentLetterDate { get; set; }
        public JsonNullable<DateTime?> ConstCompletionDate { get; set; }
        public string ConstOnlyAmortizationType { get; set; }
        public JsonNullable<bool?> ConstructionContractIndicator { get; set; }
        public JsonNullable<DateTime?> ConstructionContractIssuedDate { get; set; }
        public JsonNullable<DateTime?> ConstructionContractReceivedDate { get; set; }
        public JsonNullable<bool?> ConstructionPeriodIncludedInLoanTermFlag { get; set; }
        public JsonNullable<DateTime?> ContractorsAgreementDate { get; set; }
        public JsonNullable<bool?> ContractorsAgreementIndicator { get; set; }
        public JsonNullable<DateTime?> EnvironmentalAssessmentDate { get; set; }
        public JsonNullable<bool?> EnvironmentalAssessmentIndicator { get; set; }
        public JsonNullable<DateTime?> FloodHazardDeterminationDate { get; set; }
        public JsonNullable<bool?> FloodHazardDeterminationIndicator { get; set; }
        public JsonNullable<int?> FutureAdvancePeriod { get; set; }
        public JsonNullable<decimal?> HoldbackAmount { get; set; }
        public JsonNullable<decimal?> HoldbackPercent { get; set; }
        public JsonNullable<DateTime?> LienAgentNorthCarolinaDate { get; set; }
        public JsonNullable<bool?> LienAgentNorthCarolinaIndicator { get; set; }
        public JsonNullable<DateTime?> ListOfConstructionAgreementsDate { get; set; }
        public JsonNullable<bool?> ListOfConstructionAgreementsIndicator { get; set; }
        public JsonNullable<decimal?> MaxLTVPercent { get; set; }
        public JsonNullable<int?> MinimumDaysBetweenDisbursements { get; set; }
        public JsonNullable<DateTime?> OtherDate { get; set; }
        public string OtherDescription { get; set; }
        public JsonNullable<bool?> OtherIndicator { get; set; }
        public string PartialPrepaymentsElection { get; set; }
        public JsonNullable<DateTime?> PaymentAndPerformanceBondsDate { get; set; }
        public JsonNullable<bool?> PaymentAndPerformanceBondsIndicator { get; set; }
        public JsonNullable<DateTime?> PercolationTestDate { get; set; }
        public JsonNullable<bool?> PercolationTestIndicator { get; set; }
        public JsonNullable<DateTime?> PermitsDate { get; set; }
        public JsonNullable<bool?> PermitsIndicator { get; set; }
        public JsonNullable<DateTime?> PlansAndSpecificationsDate { get; set; }
        public JsonNullable<bool?> PlansAndSpecificationsIndicator { get; set; }
        public JsonNullable<decimal?> ProjectDelaySurchargePercent { get; set; }
        public JsonNullable<int?> ReturnLendersCopyCommitmentDays { get; set; }
        public JsonNullable<bool?> SecuredBySeparateProperty { get; set; }
        public JsonNullable<DateTime?> SoilReportDate { get; set; }
        public JsonNullable<bool?> SoilReportIndicator { get; set; }
        public JsonNullable<DateTime?> SurveyDate { get; set; }
        public JsonNullable<bool?> SurveyIndicator { get; set; }
        public JsonNullable<DateTime?> TakeOutCommitmentDate { get; set; }
        public JsonNullable<bool?> TakeOutCommitmentIndicator { get; set; }
        public JsonNullable<DateTime?> TakeOutCommitmentIssuedDate { get; set; }
        public string TakeOutLenderAddress { get; set; }
        public string TakeOutLenderCity { get; set; }
        public string TakeOutLenderContactName { get; set; }
        public string TakeOutLenderContactTitle { get; set; }
        public string TakeOutLenderEmail { get; set; }
        public string TakeOutLenderFax { get; set; }
        public string TakeOutLenderLicenseNumber { get; set; }
        public string TakeOutLenderName { get; set; }
        public string TakeOutLenderNMLSNumber { get; set; }
        public string TakeOutLenderPhone { get; set; }
        public string TakeOutLenderState { get; set; }
        public string TakeOutLenderZip { get; set; }
        public JsonNullable<DateTime?> TitleInsuranceDate { get; set; }
        public JsonNullable<bool?> TitleInsuranceIndicator { get; set; }
        public JsonNullable<DateTime?> UtilityLettersDate { get; set; }
        public JsonNullable<bool?> UtilityLettersIndicator { get; set; }
        public JsonNullable<DateTime?> WaterTestDate { get; set; }
        public JsonNullable<bool?> WaterTestIndicator { get; set; }
    }
}