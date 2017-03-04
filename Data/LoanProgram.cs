
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class LoanProgram
    {
        public string mortgageType { get; set; }
        public string propertyUsageType { get; set; }
        public string lienPriorityType { get; set; }
        public string type { get; set; }
        public string loanAmortizationType { get; set; }
        public decimal? requestedInterestRatePercent { get; set; }
        public decimal? qualifyingRatePercent { get; set; }
        public int? loanAmortizationTermMonths { get; set; }
        public int? balloonLoanMaturityTermMonths { get; set; }
        public decimal? buydownIncreaseRatePercent1 { get; set; }
        public int? buydownChangeFrequencyMonths1 { get; set; }
        public decimal? buydownIncreaseRatePercent2 { get; set; }
        public int? buydownChangeFrequencyMonths2 { get; set; }
        public decimal? buydownIncreaseRatePercent3 { get; set; }
        public int? buydownChangeFrequencyMonths3 { get; set; }
        public decimal? buydownIncreaseRatePercent4 { get; set; }
        public int? buydownChangeFrequencyMonths4 { get; set; }
        public decimal? buydownIncreaseRatePercent5 { get; set; }
        public int? buydownChangeFrequencyMonths5 { get; set; }
        public decimal? buydownIncreaseRatePercent6 { get; set; }
        public int? buydownChangeFrequencyMonths6 { get; set; }
        public string loanFeaturesPaymentFrequencyType { get; set; }
        public int? interestOnlyMonths { get; set; }
        public decimal? rateAdjustmentPercent { get; set; }
        public int? rateAdjustmentSubsequentRateAdjustmentMonths { get; set; }
        public decimal? rateAdjustmentSubsequentCapPercent { get; set; }
        public int? rateAdjustmentDurationMonths { get; set; }
        public decimal? rateAdjustmentLifetimeCapPercent { get; set; }
        public decimal? indexMarginPercent { get; set; }
        public decimal? indexCurrentValuePercent { get; set; }
        public decimal? floorPercent { get; set; }
        public decimal? roundPercent { get; set; }
        public string roundType { get; set; }
        public decimal? paymentAdjustmentPeriodicCapPercent { get; set; }
        public int? paymentAdjustmentDurationMonths { get; set; }
        public int? recastPaidMonths { get; set; }
        public int? recastStopMonths { get; set; }
        public decimal? maximumBalance { get; set; }
        public decimal? gpmRate { get; set; }
        public int? gpmYears { get; set; }
        public decimal? gpmExtraPaymentForEarlyPayOff { get; set; }
        public string loanProgramName { get; set; }
        public decimal? maxLoanAmount { get; set; }
        public decimal? maxLtv { get; set; }
        public decimal? maxCltv { get; set; }
        public string minCreditScore { get; set; }
        public decimal? maxFrontRatio { get; set; }
        public decimal? maxBackRatio { get; set; }
        public string lenderInvestorCode { get; set; }
        public decimal? paymentFactor { get; set; }
        public int? constructionPeriodMonths { get; set; }
        public decimal? constructionRate { get; set; }
        public decimal? constructionInterestReserveAmount { get; set; }
        public string constructionDescription { get; set; }
        public decimal? mortgageInsuranceAdjustmentFactor1 { get; set; }
        public int? mortgageInsuranceMonthsOfAdjustment1 { get; set; }
        public decimal? mortgageInsuranceMonthlyPayment1 { get; set; }
        public decimal? mortgageInsuranceAdjustmentFactor2 { get; set; }
        public int? mortgageInsuranceMonthsOfAdjustment2 { get; set; }
        public decimal? mortgageInsuranceMonthlyPayment2 { get; set; }
        public decimal? mortgageInsuranceCancelPercent { get; set; }
        public string requiredDeposit { get; set; }
        public string demandFeature { get; set; }
        public string variableRateFeature { get; set; }
        public string additionalArmInformation { get; set; }
        public string securityInterestInNameOf { get; set; }
        public string securityType { get; set; }
        public string prepaymentPenaltyIndicator { get; set; }
        public string refundPaymentIndicator { get; set; }
        public int? lateChargeDays { get; set; }
        public decimal? lateChargePercent { get; set; }
        public string lateChargeType { get; set; }
        public string assumptionOnYourProperty { get; set; }
        public string convertible { get; set; }
        public string programCode { get; set; }
        public string meansAnEstimate { get; set; }
        public string allDateAndNumericalDisclosures { get; set; }
        public decimal? subjectPropertyGrossRentalIncome { get; set; }
        public decimal? percentageOfRental { get; set; }
        public string otherMortgageTypeDescription { get; set; }
        public string armTypeDescription { get; set; }
        public string otherAmortizationTypeDescription { get; set; }
        public string description { get; set; }
        public string creditLifeInsurance { get; set; }
        public string creditDisability { get; set; }
        public string propertyInsurance { get; set; }
        public string floodInsurance { get; set; }
        public string ifYouPurchase { get; set; }
        public string ifYouPurchaseType { get; set; }
        public decimal? yearlyTerm { get; set; }
        public string otherLoanPurposeDescription { get; set; }
        public string closingCostProgram { get; set; }
        public string midpointCancellation { get; set; }
        public string calculateBasedOnRemainingBalance { get; set; }
        public string miCalculationType { get; set; }
        public decimal? fhaUpfrontMiPremiumPercent { get; set; }
        public string lockField { get; set; }
        public decimal? mipPaidInCash { get; set; }
        public decimal? fundingFeePaidInCash { get; set; }
        public string useDaysInYears { get; set; }
        public string usePitiForRatio { get; set; }
        public string loanDocumentationType { get; set; }
        public string mmi { get; set; }
        public string pmi { get; set; }
        public string disclosureType { get; set; }
        public string perDiemCalculationMethodType { get; set; }
        public string constructionLoanMethod { get; set; }
        public string acquisition { get; set; }
        public decimal? initialAdvanceAmount { get; set; }
        public decimal? annualFeeNeeded { get; set; }
        public decimal? teaserRate { get; set; }
        public decimal? thirdPartyFeeFrom { get; set; }
        public decimal? thirdPartyFeeTo { get; set; }
        public decimal? minimumAdvanceAmount { get; set; }
        public decimal? minimumAllowableApr { get; set; }
        public decimal? minimumPaymentPercent { get; set; }
        public decimal? minimumPaymentAmount { get; set; }
        public string discounted { get; set; }
        public decimal? discountedRate { get; set; }
        public string drawRepayPeriodTableName { get; set; }
        public decimal? terminationFeeAmount { get; set; }
        public int? terminationPeriodMonthsCount { get; set; }
        public string id { get; set; }

    }
}