
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class LoanEstimate1
{
public bool? rangePaymentIndicatorC1 { get; set; }
public bool? rangePaymentIndicatorC2 { get; set; }
public bool? rangePaymentIndicatorC3 { get; set; }
public bool? rangePaymentIndicatorC4 { get; set; }
public DateTime? lEDateIssued { get; set; }
public int? loanTermYears { get; set; }
public int? loanTermMonths { get; set; }
public string loanPurpose { get; set; }
public string loanProduct { get; set; }
public string rateLockExpirationTime { get; set; }
public string rateLockExpirationTimeZone { get; set; }
public string closingCostEstimateExpirationTime { get; set; }
public string closingCostEstimateExpirationTimeZone { get; set; }
public string loanAmountCanGoGoes { get; set; }
public string loanAmountCanIncreaseOrIncreases { get; set; }
public int? yearsToRecast { get; set; }
public string interestRateAdjustsEveryYears { get; set; }
public string adjustsTermType { get; set; }
public string interestRateAdjustsStartingInType { get; set; }
public int? interestRateAfterAdjustment { get; set; }
public string interestRateCanGoGoes { get; set; }
public int? interestRateAdjustsInYear { get; set; }
public string monthlyPIAdjustsEveryYears { get; set; }
public string monthlyPIAdjustsTermType { get; set; }
public string monthlyPIAdjustsStartingInType { get; set; }
public int? monthlyPIAfterAdjustment { get; set; }
public string monthlyPICanGoGoes { get; set; }
public decimal? highestMonthlyPI { get; set; }
public int? monthlyPIAdjustsInYear { get; set; }
public int? monthlyPIInterestOnlyUntilYear { get; set; }
public int? prepaymentPenaltyPayOffDuringYear { get; set; }
public DateTime? closingCostEstimateExpirationDate { get; set; }
public decimal? estimatedTaxesInsuranceAssessments { get; set; }
public string estimatedTaxesInsuranceAssessmentsUI { get; set; }
public string inEscrowPropertyTaxes { get; set; }
public string inEscrowHomeownerInsurance { get; set; }
public string inEscrowOther { get; set; }
public DateTime? disclosureLastSentDate { get; set; }
public string disclosureBy { get; set; }
public string disclosureSentMethod { get; set; }
public DateTime? disclosureClosingCostExpDate { get; set; }
public string disclosureClosingCostExpTime { get; set; }
public string disclosureClosingCostExpTimeZone { get; set; }
public DateTime? disclosureReceivedDate { get; set; }
public string disclosureComments { get; set; }
public int? pPC1Year { get; set; }
public decimal? pPC1MinimumPIPayment { get; set; }
public string pPC1MinimumPIPaymentUI { get; set; }
public decimal? pPC1MaximumPIPayment { get; set; }
public string pPC1MaximumPIPaymentUI { get; set; }
public bool? pPC1InterestOnly { get; set; }
public int? pPC1MIAmount { get; set; }
public string pPC1MIAmountUI { get; set; }
public int? pPC1EstimatedEscrowAmount { get; set; }
public string pPC1EstimatedEscrowAmountUI { get; set; }
public int? pPC1MinimumMonthlyPayment { get; set; }
public string pPC1MinimumMonthlyPaymentUI { get; set; }
public decimal? pPC1MaximumMonthlyPayment { get; set; }
public string pPC1MaximumMonthlyPaymentUI { get; set; }
public int? pPC2YearFrom { get; set; }
public int? pPC2YearTo { get; set; }
public decimal? pPC2MinimumPIPayment { get; set; }
public string pPC2MinimumPIPaymentUI { get; set; }
public decimal? pPC2MaximumPIPayment { get; set; }
public string pPC2MaximumPIPaymentUI { get; set; }
public bool? pPC2InterestOnly { get; set; }
public int? pPC2MIAmount { get; set; }
public string pPC2MIAmountUI { get; set; }
public int? pPC2EstimatedEscrowAmount { get; set; }
public string pPC2EstimatedEscrowAmountUI { get; set; }
public int? pPC2MinimumMonthlyPayment { get; set; }
public string pPC2MinimumMonthlyPaymentUI { get; set; }
public decimal? pPC2MaximumMonthlyPayment { get; set; }
public string pPC2MaximumMonthlyPaymentUI { get; set; }
public int? pPC3YearFrom { get; set; }
public int? pPC3YearTo { get; set; }
public decimal? pPC3MinimumPIPayment { get; set; }
public string pPC3MinimumPIPaymentUI { get; set; }
public decimal? pPC3MaximumPIPayment { get; set; }
public string pPC3MaximumPIPaymentUI { get; set; }
public bool? pPC3InterestOnly { get; set; }
public int? pPC3MIAmount { get; set; }
public string pPC3MIAmountUI { get; set; }
public int? pPC3EstimatedEscrowAmount { get; set; }
public string pPC3EstimatedEscrowAmountUI { get; set; }
public int? pPC3MinimumMonthlyPayment { get; set; }
public string pPC3MinimumMonthlyPaymentUI { get; set; }
public decimal? pPC3MaximumMonthlyPayment { get; set; }
public string pPC3MaximumMonthlyPaymentUI { get; set; }
public int? pPC4YearFrom { get; set; }
public int? pPC4YearTo { get; set; }
public decimal? pPC4MinimumPIPayment { get; set; }
public string pPC4MinimumPIPaymentUI { get; set; }
public decimal? pPC4MaximumPIPayment { get; set; }
public string pPC4MaximumPIPaymentUI { get; set; }
public bool? pPC4InterestOnly { get; set; }
public int? pPC4MIAmount { get; set; }
public string pPC4MIAmountUI { get; set; }
public int? pPC4EstimatedEscrowAmount { get; set; }
public string pPC4EstimatedEscrowAmountUI { get; set; }
public int? pPC4MinimumMonthlyPayment { get; set; }
public string pPC4MinimumMonthlyPaymentUI { get; set; }
public decimal? pPC4MaximumMonthlyPayment { get; set; }
public string pPC4MaximumMonthlyPaymentUI { get; set; }
public bool? pPEstimatedEscrowIndicator { get; set; }
public bool? reasonSettlementCharges { get; set; }
public bool? reasonEligibility { get; set; }
public bool? reasonRevisions { get; set; }
public bool? reasonInterestRate { get; set; }
public bool? reasonExpiration { get; set; }
public bool? reasonDelayedSettlement { get; set; }
public bool? reasonOther { get; set; }
public string reasonOtherDescription { get; set; }
public string changedCircumstanceComments { get; set; }
public decimal? totalEstimatedCashClose { get; set; }
public string monthlyPIAdjustedInDateType { get; set; }
public string monthlyPIInterestOnlyDateType { get; set; }
public string reasonChangedCircumstanceFlags { get; set; }
public string prepaymentPenaltyPayOffInDateType { get; set; }
public string prepaymentPenaltyPayOffInFirstYear { get; set; }
public string id { get; set; }

    }
}