using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate1
    {
        public Value<string> AdjustsTermType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustsTermType() => !AdjustsTermType.Clean;
        public Value<string> ChangedCircumstanceComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangedCircumstanceComments() => !ChangedCircumstanceComments.Clean;
        public Value<DateTime?> ClosingCostEstimateExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationDate() => !ClosingCostEstimateExpirationDate.Clean;
        public Value<string> ClosingCostEstimateExpirationTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationTime() => !ClosingCostEstimateExpirationTime.Clean;
        public Value<string> ClosingCostEstimateExpirationTimeZone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationTimeZone() => !ClosingCostEstimateExpirationTimeZone.Clean;
        public Value<string> DisclosureBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureBy() => !DisclosureBy.Clean;
        public Value<DateTime?> DisclosureClosingCostExpDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpDate() => !DisclosureClosingCostExpDate.Clean;
        public Value<string> DisclosureClosingCostExpTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpTime() => !DisclosureClosingCostExpTime.Clean;
        public Value<string> DisclosureClosingCostExpTimeZone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpTimeZone() => !DisclosureClosingCostExpTimeZone.Clean;
        public Value<string> DisclosureComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureComments() => !DisclosureComments.Clean;
        public Value<DateTime?> DisclosureLastSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureLastSentDate() => !DisclosureLastSentDate.Clean;
        public Value<DateTime?> DisclosureReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureReceivedDate() => !DisclosureReceivedDate.Clean;
        public Value<string> DisclosureSentMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureSentMethod() => !DisclosureSentMethod.Clean;
        public Value<decimal?> EstimatedTaxesInsuranceAssessments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTaxesInsuranceAssessments() => !EstimatedTaxesInsuranceAssessments.Clean;
        public Value<string> EstimatedTaxesInsuranceAssessmentsUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTaxesInsuranceAssessmentsUI() => !EstimatedTaxesInsuranceAssessmentsUI.Clean;
        public Value<decimal?> HighestMonthlyPI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighestMonthlyPI() => !HighestMonthlyPI.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InEscrowHomeownerInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowHomeownerInsurance() => !InEscrowHomeownerInsurance.Clean;
        public Value<string> InEscrowOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowOther() => !InEscrowOther.Clean;
        public Value<string> InEscrowPropertyTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowPropertyTaxes() => !InEscrowPropertyTaxes.Clean;
        public Value<string> InterestRateAdjustsEveryYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsEveryYears() => !InterestRateAdjustsEveryYears.Clean;
        public Value<int?> InterestRateAdjustsInYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsInYear() => !InterestRateAdjustsInYear.Clean;
        public Value<string> InterestRateAdjustsStartingInType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsStartingInType() => !InterestRateAdjustsStartingInType.Clean;
        public Value<int?> InterestRateAfterAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAfterAdjustment() => !InterestRateAfterAdjustment.Clean;
        public Value<string> InterestRateCanGoGoes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateCanGoGoes() => !InterestRateCanGoGoes.Clean;
        public Value<DateTime?> LEDateIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEDateIssued() => !LEDateIssued.Clean;
        public Value<string> LoanAmountCanGoGoes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountCanGoGoes() => !LoanAmountCanGoGoes.Clean;
        public Value<string> LoanAmountCanIncreaseOrIncreases { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountCanIncreaseOrIncreases() => !LoanAmountCanIncreaseOrIncreases.Clean;
        public Value<string> LoanProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProduct() => !LoanProduct.Clean;
        public Value<string> LoanPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurpose() => !LoanPurpose.Clean;
        public Value<int?> LoanTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTermMonths() => !LoanTermMonths.Clean;
        public Value<int?> LoanTermYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTermYears() => !LoanTermYears.Clean;
        public Value<string> MonthlyPIAdjustedInDateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustedInDateType() => !MonthlyPIAdjustedInDateType.Clean;
        public Value<string> MonthlyPIAdjustsEveryYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsEveryYears() => !MonthlyPIAdjustsEveryYears.Clean;
        public Value<int?> MonthlyPIAdjustsInYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsInYear() => !MonthlyPIAdjustsInYear.Clean;
        public Value<string> MonthlyPIAdjustsStartingInType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsStartingInType() => !MonthlyPIAdjustsStartingInType.Clean;
        public Value<string> MonthlyPIAdjustsTermType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsTermType() => !MonthlyPIAdjustsTermType.Clean;
        public Value<int?> MonthlyPIAfterAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAfterAdjustment() => !MonthlyPIAfterAdjustment.Clean;
        public Value<string> MonthlyPICanGoGoes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPICanGoGoes() => !MonthlyPICanGoGoes.Clean;
        public Value<string> MonthlyPIInterestOnlyDateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIInterestOnlyDateType() => !MonthlyPIInterestOnlyDateType.Clean;
        public Value<int?> MonthlyPIInterestOnlyUntilYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIInterestOnlyUntilYear() => !MonthlyPIInterestOnlyUntilYear.Clean;
        public Value<int?> PPC1EstimatedEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1EstimatedEscrowAmount() => !PPC1EstimatedEscrowAmount.Clean;
        public Value<string> PPC1EstimatedEscrowAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1EstimatedEscrowAmountUI() => !PPC1EstimatedEscrowAmountUI.Clean;
        public Value<bool?> PPC1InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1InterestOnly() => !PPC1InterestOnly.Clean;
        public Value<decimal?> PPC1MaximumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumMonthlyPayment() => !PPC1MaximumMonthlyPayment.Clean;
        public Value<string> PPC1MaximumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumMonthlyPaymentUI() => !PPC1MaximumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC1MaximumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumPIPayment() => !PPC1MaximumPIPayment.Clean;
        public Value<string> PPC1MaximumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumPIPaymentUI() => !PPC1MaximumPIPaymentUI.Clean;
        public Value<int?> PPC1MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmount() => !PPC1MIAmount.Clean;
        public Value<string> PPC1MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmountUI() => !PPC1MIAmountUI.Clean;
        public Value<int?> PPC1MinimumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumMonthlyPayment() => !PPC1MinimumMonthlyPayment.Clean;
        public Value<string> PPC1MinimumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumMonthlyPaymentUI() => !PPC1MinimumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC1MinimumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumPIPayment() => !PPC1MinimumPIPayment.Clean;
        public Value<string> PPC1MinimumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumPIPaymentUI() => !PPC1MinimumPIPaymentUI.Clean;
        public Value<int?> PPC1Year { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1Year() => !PPC1Year.Clean;
        public Value<int?> PPC2EstimatedEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2EstimatedEscrowAmount() => !PPC2EstimatedEscrowAmount.Clean;
        public Value<string> PPC2EstimatedEscrowAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2EstimatedEscrowAmountUI() => !PPC2EstimatedEscrowAmountUI.Clean;
        public Value<bool?> PPC2InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2InterestOnly() => !PPC2InterestOnly.Clean;
        public Value<decimal?> PPC2MaximumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumMonthlyPayment() => !PPC2MaximumMonthlyPayment.Clean;
        public Value<string> PPC2MaximumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumMonthlyPaymentUI() => !PPC2MaximumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC2MaximumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumPIPayment() => !PPC2MaximumPIPayment.Clean;
        public Value<string> PPC2MaximumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumPIPaymentUI() => !PPC2MaximumPIPaymentUI.Clean;
        public Value<int?> PPC2MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmount() => !PPC2MIAmount.Clean;
        public Value<string> PPC2MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmountUI() => !PPC2MIAmountUI.Clean;
        public Value<int?> PPC2MinimumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumMonthlyPayment() => !PPC2MinimumMonthlyPayment.Clean;
        public Value<string> PPC2MinimumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumMonthlyPaymentUI() => !PPC2MinimumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC2MinimumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumPIPayment() => !PPC2MinimumPIPayment.Clean;
        public Value<string> PPC2MinimumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumPIPaymentUI() => !PPC2MinimumPIPaymentUI.Clean;
        public Value<int?> PPC2YearFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2YearFrom() => !PPC2YearFrom.Clean;
        public Value<int?> PPC2YearTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2YearTo() => !PPC2YearTo.Clean;
        public Value<int?> PPC3EstimatedEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3EstimatedEscrowAmount() => !PPC3EstimatedEscrowAmount.Clean;
        public Value<string> PPC3EstimatedEscrowAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3EstimatedEscrowAmountUI() => !PPC3EstimatedEscrowAmountUI.Clean;
        public Value<bool?> PPC3InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3InterestOnly() => !PPC3InterestOnly.Clean;
        public Value<decimal?> PPC3MaximumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumMonthlyPayment() => !PPC3MaximumMonthlyPayment.Clean;
        public Value<string> PPC3MaximumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumMonthlyPaymentUI() => !PPC3MaximumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC3MaximumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumPIPayment() => !PPC3MaximumPIPayment.Clean;
        public Value<string> PPC3MaximumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumPIPaymentUI() => !PPC3MaximumPIPaymentUI.Clean;
        public Value<int?> PPC3MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmount() => !PPC3MIAmount.Clean;
        public Value<string> PPC3MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmountUI() => !PPC3MIAmountUI.Clean;
        public Value<int?> PPC3MinimumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumMonthlyPayment() => !PPC3MinimumMonthlyPayment.Clean;
        public Value<string> PPC3MinimumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumMonthlyPaymentUI() => !PPC3MinimumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC3MinimumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumPIPayment() => !PPC3MinimumPIPayment.Clean;
        public Value<string> PPC3MinimumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumPIPaymentUI() => !PPC3MinimumPIPaymentUI.Clean;
        public Value<int?> PPC3YearFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3YearFrom() => !PPC3YearFrom.Clean;
        public Value<int?> PPC3YearTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3YearTo() => !PPC3YearTo.Clean;
        public Value<int?> PPC4EstimatedEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4EstimatedEscrowAmount() => !PPC4EstimatedEscrowAmount.Clean;
        public Value<string> PPC4EstimatedEscrowAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4EstimatedEscrowAmountUI() => !PPC4EstimatedEscrowAmountUI.Clean;
        public Value<bool?> PPC4InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4InterestOnly() => !PPC4InterestOnly.Clean;
        public Value<decimal?> PPC4MaximumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumMonthlyPayment() => !PPC4MaximumMonthlyPayment.Clean;
        public Value<string> PPC4MaximumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumMonthlyPaymentUI() => !PPC4MaximumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC4MaximumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumPIPayment() => !PPC4MaximumPIPayment.Clean;
        public Value<string> PPC4MaximumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumPIPaymentUI() => !PPC4MaximumPIPaymentUI.Clean;
        public Value<int?> PPC4MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmount() => !PPC4MIAmount.Clean;
        public Value<string> PPC4MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmountUI() => !PPC4MIAmountUI.Clean;
        public Value<int?> PPC4MinimumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumMonthlyPayment() => !PPC4MinimumMonthlyPayment.Clean;
        public Value<string> PPC4MinimumMonthlyPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumMonthlyPaymentUI() => !PPC4MinimumMonthlyPaymentUI.Clean;
        public Value<decimal?> PPC4MinimumPIPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumPIPayment() => !PPC4MinimumPIPayment.Clean;
        public Value<string> PPC4MinimumPIPaymentUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumPIPaymentUI() => !PPC4MinimumPIPaymentUI.Clean;
        public Value<int?> PPC4YearFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4YearFrom() => !PPC4YearFrom.Clean;
        public Value<int?> PPC4YearTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4YearTo() => !PPC4YearTo.Clean;
        public Value<bool?> PPEstimatedEscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPEstimatedEscrowIndicator() => !PPEstimatedEscrowIndicator.Clean;
        public Value<int?> PrepaymentPenaltyPayOffDuringYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffDuringYear() => !PrepaymentPenaltyPayOffDuringYear.Clean;
        public Value<string> PrepaymentPenaltyPayOffInDateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffInDateType() => !PrepaymentPenaltyPayOffInDateType.Clean;
        public Value<string> PrepaymentPenaltyPayOffInFirstYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffInFirstYear() => !PrepaymentPenaltyPayOffInFirstYear.Clean;
        public Value<bool?> RangePaymentIndicatorC1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC1() => !RangePaymentIndicatorC1.Clean;
        public Value<bool?> RangePaymentIndicatorC2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC2() => !RangePaymentIndicatorC2.Clean;
        public Value<bool?> RangePaymentIndicatorC3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC3() => !RangePaymentIndicatorC3.Clean;
        public Value<bool?> RangePaymentIndicatorC4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC4() => !RangePaymentIndicatorC4.Clean;
        public Value<string> RateLockExpirationTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockExpirationTime() => !RateLockExpirationTime.Clean;
        public Value<string> RateLockExpirationTimeZone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockExpirationTimeZone() => !RateLockExpirationTimeZone.Clean;
        public Value<string> ReasonChangedCircumstanceFlags { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangedCircumstanceFlags() => !ReasonChangedCircumstanceFlags.Clean;
        public Value<bool?> ReasonDelayedSettlement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonDelayedSettlement() => !ReasonDelayedSettlement.Clean;
        public Value<bool?> ReasonEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonEligibility() => !ReasonEligibility.Clean;
        public Value<bool?> ReasonExpiration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonExpiration() => !ReasonExpiration.Clean;
        public Value<bool?> ReasonInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonInterestRate() => !ReasonInterestRate.Clean;
        public Value<bool?> ReasonOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOther() => !ReasonOther.Clean;
        public Value<string> ReasonOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOtherDescription() => !ReasonOtherDescription.Clean;
        public Value<bool?> ReasonRevisions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonRevisions() => !ReasonRevisions.Clean;
        public Value<bool?> ReasonSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonSettlementCharges() => !ReasonSettlementCharges.Clean;
        public Value<decimal?> TotalEstimatedCashClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEstimatedCashClose() => !TotalEstimatedCashClose.Clean;
        public Value<int?> YearsToRecast { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearsToRecast() => !YearsToRecast.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustsTermType.Clean
                    && ChangedCircumstanceComments.Clean
                    && ClosingCostEstimateExpirationDate.Clean
                    && ClosingCostEstimateExpirationTime.Clean
                    && ClosingCostEstimateExpirationTimeZone.Clean
                    && DisclosureBy.Clean
                    && DisclosureClosingCostExpDate.Clean
                    && DisclosureClosingCostExpTime.Clean
                    && DisclosureClosingCostExpTimeZone.Clean
                    && DisclosureComments.Clean
                    && DisclosureLastSentDate.Clean
                    && DisclosureReceivedDate.Clean
                    && DisclosureSentMethod.Clean
                    && EstimatedTaxesInsuranceAssessments.Clean
                    && EstimatedTaxesInsuranceAssessmentsUI.Clean
                    && HighestMonthlyPI.Clean
                    && Id.Clean
                    && InEscrowHomeownerInsurance.Clean
                    && InEscrowOther.Clean
                    && InEscrowPropertyTaxes.Clean
                    && InterestRateAdjustsEveryYears.Clean
                    && InterestRateAdjustsInYear.Clean
                    && InterestRateAdjustsStartingInType.Clean
                    && InterestRateAfterAdjustment.Clean
                    && InterestRateCanGoGoes.Clean
                    && LEDateIssued.Clean
                    && LoanAmountCanGoGoes.Clean
                    && LoanAmountCanIncreaseOrIncreases.Clean
                    && LoanProduct.Clean
                    && LoanPurpose.Clean
                    && LoanTermMonths.Clean
                    && LoanTermYears.Clean
                    && MonthlyPIAdjustedInDateType.Clean
                    && MonthlyPIAdjustsEveryYears.Clean
                    && MonthlyPIAdjustsInYear.Clean
                    && MonthlyPIAdjustsStartingInType.Clean
                    && MonthlyPIAdjustsTermType.Clean
                    && MonthlyPIAfterAdjustment.Clean
                    && MonthlyPICanGoGoes.Clean
                    && MonthlyPIInterestOnlyDateType.Clean
                    && MonthlyPIInterestOnlyUntilYear.Clean
                    && PPC1EstimatedEscrowAmount.Clean
                    && PPC1EstimatedEscrowAmountUI.Clean
                    && PPC1InterestOnly.Clean
                    && PPC1MaximumMonthlyPayment.Clean
                    && PPC1MaximumMonthlyPaymentUI.Clean
                    && PPC1MaximumPIPayment.Clean
                    && PPC1MaximumPIPaymentUI.Clean
                    && PPC1MIAmount.Clean
                    && PPC1MIAmountUI.Clean
                    && PPC1MinimumMonthlyPayment.Clean
                    && PPC1MinimumMonthlyPaymentUI.Clean
                    && PPC1MinimumPIPayment.Clean
                    && PPC1MinimumPIPaymentUI.Clean
                    && PPC1Year.Clean
                    && PPC2EstimatedEscrowAmount.Clean
                    && PPC2EstimatedEscrowAmountUI.Clean
                    && PPC2InterestOnly.Clean
                    && PPC2MaximumMonthlyPayment.Clean
                    && PPC2MaximumMonthlyPaymentUI.Clean
                    && PPC2MaximumPIPayment.Clean
                    && PPC2MaximumPIPaymentUI.Clean
                    && PPC2MIAmount.Clean
                    && PPC2MIAmountUI.Clean
                    && PPC2MinimumMonthlyPayment.Clean
                    && PPC2MinimumMonthlyPaymentUI.Clean
                    && PPC2MinimumPIPayment.Clean
                    && PPC2MinimumPIPaymentUI.Clean
                    && PPC2YearFrom.Clean
                    && PPC2YearTo.Clean
                    && PPC3EstimatedEscrowAmount.Clean
                    && PPC3EstimatedEscrowAmountUI.Clean
                    && PPC3InterestOnly.Clean
                    && PPC3MaximumMonthlyPayment.Clean
                    && PPC3MaximumMonthlyPaymentUI.Clean
                    && PPC3MaximumPIPayment.Clean
                    && PPC3MaximumPIPaymentUI.Clean
                    && PPC3MIAmount.Clean
                    && PPC3MIAmountUI.Clean
                    && PPC3MinimumMonthlyPayment.Clean
                    && PPC3MinimumMonthlyPaymentUI.Clean
                    && PPC3MinimumPIPayment.Clean
                    && PPC3MinimumPIPaymentUI.Clean
                    && PPC3YearFrom.Clean
                    && PPC3YearTo.Clean
                    && PPC4EstimatedEscrowAmount.Clean
                    && PPC4EstimatedEscrowAmountUI.Clean
                    && PPC4InterestOnly.Clean
                    && PPC4MaximumMonthlyPayment.Clean
                    && PPC4MaximumMonthlyPaymentUI.Clean
                    && PPC4MaximumPIPayment.Clean
                    && PPC4MaximumPIPaymentUI.Clean
                    && PPC4MIAmount.Clean
                    && PPC4MIAmountUI.Clean
                    && PPC4MinimumMonthlyPayment.Clean
                    && PPC4MinimumMonthlyPaymentUI.Clean
                    && PPC4MinimumPIPayment.Clean
                    && PPC4MinimumPIPaymentUI.Clean
                    && PPC4YearFrom.Clean
                    && PPC4YearTo.Clean
                    && PPEstimatedEscrowIndicator.Clean
                    && PrepaymentPenaltyPayOffDuringYear.Clean
                    && PrepaymentPenaltyPayOffInDateType.Clean
                    && PrepaymentPenaltyPayOffInFirstYear.Clean
                    && RangePaymentIndicatorC1.Clean
                    && RangePaymentIndicatorC2.Clean
                    && RangePaymentIndicatorC3.Clean
                    && RangePaymentIndicatorC4.Clean
                    && RateLockExpirationTime.Clean
                    && RateLockExpirationTimeZone.Clean
                    && ReasonChangedCircumstanceFlags.Clean
                    && ReasonDelayedSettlement.Clean
                    && ReasonEligibility.Clean
                    && ReasonExpiration.Clean
                    && ReasonInterestRate.Clean
                    && ReasonOther.Clean
                    && ReasonOtherDescription.Clean
                    && ReasonRevisions.Clean
                    && ReasonSettlementCharges.Clean
                    && TotalEstimatedCashClose.Clean
                    && YearsToRecast.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdjustsTermType; v0.Clean = value; AdjustsTermType = v0;
                var v1 = ChangedCircumstanceComments; v1.Clean = value; ChangedCircumstanceComments = v1;
                var v2 = ClosingCostEstimateExpirationDate; v2.Clean = value; ClosingCostEstimateExpirationDate = v2;
                var v3 = ClosingCostEstimateExpirationTime; v3.Clean = value; ClosingCostEstimateExpirationTime = v3;
                var v4 = ClosingCostEstimateExpirationTimeZone; v4.Clean = value; ClosingCostEstimateExpirationTimeZone = v4;
                var v5 = DisclosureBy; v5.Clean = value; DisclosureBy = v5;
                var v6 = DisclosureClosingCostExpDate; v6.Clean = value; DisclosureClosingCostExpDate = v6;
                var v7 = DisclosureClosingCostExpTime; v7.Clean = value; DisclosureClosingCostExpTime = v7;
                var v8 = DisclosureClosingCostExpTimeZone; v8.Clean = value; DisclosureClosingCostExpTimeZone = v8;
                var v9 = DisclosureComments; v9.Clean = value; DisclosureComments = v9;
                var v10 = DisclosureLastSentDate; v10.Clean = value; DisclosureLastSentDate = v10;
                var v11 = DisclosureReceivedDate; v11.Clean = value; DisclosureReceivedDate = v11;
                var v12 = DisclosureSentMethod; v12.Clean = value; DisclosureSentMethod = v12;
                var v13 = EstimatedTaxesInsuranceAssessments; v13.Clean = value; EstimatedTaxesInsuranceAssessments = v13;
                var v14 = EstimatedTaxesInsuranceAssessmentsUI; v14.Clean = value; EstimatedTaxesInsuranceAssessmentsUI = v14;
                var v15 = HighestMonthlyPI; v15.Clean = value; HighestMonthlyPI = v15;
                var v16 = Id; v16.Clean = value; Id = v16;
                var v17 = InEscrowHomeownerInsurance; v17.Clean = value; InEscrowHomeownerInsurance = v17;
                var v18 = InEscrowOther; v18.Clean = value; InEscrowOther = v18;
                var v19 = InEscrowPropertyTaxes; v19.Clean = value; InEscrowPropertyTaxes = v19;
                var v20 = InterestRateAdjustsEveryYears; v20.Clean = value; InterestRateAdjustsEveryYears = v20;
                var v21 = InterestRateAdjustsInYear; v21.Clean = value; InterestRateAdjustsInYear = v21;
                var v22 = InterestRateAdjustsStartingInType; v22.Clean = value; InterestRateAdjustsStartingInType = v22;
                var v23 = InterestRateAfterAdjustment; v23.Clean = value; InterestRateAfterAdjustment = v23;
                var v24 = InterestRateCanGoGoes; v24.Clean = value; InterestRateCanGoGoes = v24;
                var v25 = LEDateIssued; v25.Clean = value; LEDateIssued = v25;
                var v26 = LoanAmountCanGoGoes; v26.Clean = value; LoanAmountCanGoGoes = v26;
                var v27 = LoanAmountCanIncreaseOrIncreases; v27.Clean = value; LoanAmountCanIncreaseOrIncreases = v27;
                var v28 = LoanProduct; v28.Clean = value; LoanProduct = v28;
                var v29 = LoanPurpose; v29.Clean = value; LoanPurpose = v29;
                var v30 = LoanTermMonths; v30.Clean = value; LoanTermMonths = v30;
                var v31 = LoanTermYears; v31.Clean = value; LoanTermYears = v31;
                var v32 = MonthlyPIAdjustedInDateType; v32.Clean = value; MonthlyPIAdjustedInDateType = v32;
                var v33 = MonthlyPIAdjustsEveryYears; v33.Clean = value; MonthlyPIAdjustsEveryYears = v33;
                var v34 = MonthlyPIAdjustsInYear; v34.Clean = value; MonthlyPIAdjustsInYear = v34;
                var v35 = MonthlyPIAdjustsStartingInType; v35.Clean = value; MonthlyPIAdjustsStartingInType = v35;
                var v36 = MonthlyPIAdjustsTermType; v36.Clean = value; MonthlyPIAdjustsTermType = v36;
                var v37 = MonthlyPIAfterAdjustment; v37.Clean = value; MonthlyPIAfterAdjustment = v37;
                var v38 = MonthlyPICanGoGoes; v38.Clean = value; MonthlyPICanGoGoes = v38;
                var v39 = MonthlyPIInterestOnlyDateType; v39.Clean = value; MonthlyPIInterestOnlyDateType = v39;
                var v40 = MonthlyPIInterestOnlyUntilYear; v40.Clean = value; MonthlyPIInterestOnlyUntilYear = v40;
                var v41 = PPC1EstimatedEscrowAmount; v41.Clean = value; PPC1EstimatedEscrowAmount = v41;
                var v42 = PPC1EstimatedEscrowAmountUI; v42.Clean = value; PPC1EstimatedEscrowAmountUI = v42;
                var v43 = PPC1InterestOnly; v43.Clean = value; PPC1InterestOnly = v43;
                var v44 = PPC1MaximumMonthlyPayment; v44.Clean = value; PPC1MaximumMonthlyPayment = v44;
                var v45 = PPC1MaximumMonthlyPaymentUI; v45.Clean = value; PPC1MaximumMonthlyPaymentUI = v45;
                var v46 = PPC1MaximumPIPayment; v46.Clean = value; PPC1MaximumPIPayment = v46;
                var v47 = PPC1MaximumPIPaymentUI; v47.Clean = value; PPC1MaximumPIPaymentUI = v47;
                var v48 = PPC1MIAmount; v48.Clean = value; PPC1MIAmount = v48;
                var v49 = PPC1MIAmountUI; v49.Clean = value; PPC1MIAmountUI = v49;
                var v50 = PPC1MinimumMonthlyPayment; v50.Clean = value; PPC1MinimumMonthlyPayment = v50;
                var v51 = PPC1MinimumMonthlyPaymentUI; v51.Clean = value; PPC1MinimumMonthlyPaymentUI = v51;
                var v52 = PPC1MinimumPIPayment; v52.Clean = value; PPC1MinimumPIPayment = v52;
                var v53 = PPC1MinimumPIPaymentUI; v53.Clean = value; PPC1MinimumPIPaymentUI = v53;
                var v54 = PPC1Year; v54.Clean = value; PPC1Year = v54;
                var v55 = PPC2EstimatedEscrowAmount; v55.Clean = value; PPC2EstimatedEscrowAmount = v55;
                var v56 = PPC2EstimatedEscrowAmountUI; v56.Clean = value; PPC2EstimatedEscrowAmountUI = v56;
                var v57 = PPC2InterestOnly; v57.Clean = value; PPC2InterestOnly = v57;
                var v58 = PPC2MaximumMonthlyPayment; v58.Clean = value; PPC2MaximumMonthlyPayment = v58;
                var v59 = PPC2MaximumMonthlyPaymentUI; v59.Clean = value; PPC2MaximumMonthlyPaymentUI = v59;
                var v60 = PPC2MaximumPIPayment; v60.Clean = value; PPC2MaximumPIPayment = v60;
                var v61 = PPC2MaximumPIPaymentUI; v61.Clean = value; PPC2MaximumPIPaymentUI = v61;
                var v62 = PPC2MIAmount; v62.Clean = value; PPC2MIAmount = v62;
                var v63 = PPC2MIAmountUI; v63.Clean = value; PPC2MIAmountUI = v63;
                var v64 = PPC2MinimumMonthlyPayment; v64.Clean = value; PPC2MinimumMonthlyPayment = v64;
                var v65 = PPC2MinimumMonthlyPaymentUI; v65.Clean = value; PPC2MinimumMonthlyPaymentUI = v65;
                var v66 = PPC2MinimumPIPayment; v66.Clean = value; PPC2MinimumPIPayment = v66;
                var v67 = PPC2MinimumPIPaymentUI; v67.Clean = value; PPC2MinimumPIPaymentUI = v67;
                var v68 = PPC2YearFrom; v68.Clean = value; PPC2YearFrom = v68;
                var v69 = PPC2YearTo; v69.Clean = value; PPC2YearTo = v69;
                var v70 = PPC3EstimatedEscrowAmount; v70.Clean = value; PPC3EstimatedEscrowAmount = v70;
                var v71 = PPC3EstimatedEscrowAmountUI; v71.Clean = value; PPC3EstimatedEscrowAmountUI = v71;
                var v72 = PPC3InterestOnly; v72.Clean = value; PPC3InterestOnly = v72;
                var v73 = PPC3MaximumMonthlyPayment; v73.Clean = value; PPC3MaximumMonthlyPayment = v73;
                var v74 = PPC3MaximumMonthlyPaymentUI; v74.Clean = value; PPC3MaximumMonthlyPaymentUI = v74;
                var v75 = PPC3MaximumPIPayment; v75.Clean = value; PPC3MaximumPIPayment = v75;
                var v76 = PPC3MaximumPIPaymentUI; v76.Clean = value; PPC3MaximumPIPaymentUI = v76;
                var v77 = PPC3MIAmount; v77.Clean = value; PPC3MIAmount = v77;
                var v78 = PPC3MIAmountUI; v78.Clean = value; PPC3MIAmountUI = v78;
                var v79 = PPC3MinimumMonthlyPayment; v79.Clean = value; PPC3MinimumMonthlyPayment = v79;
                var v80 = PPC3MinimumMonthlyPaymentUI; v80.Clean = value; PPC3MinimumMonthlyPaymentUI = v80;
                var v81 = PPC3MinimumPIPayment; v81.Clean = value; PPC3MinimumPIPayment = v81;
                var v82 = PPC3MinimumPIPaymentUI; v82.Clean = value; PPC3MinimumPIPaymentUI = v82;
                var v83 = PPC3YearFrom; v83.Clean = value; PPC3YearFrom = v83;
                var v84 = PPC3YearTo; v84.Clean = value; PPC3YearTo = v84;
                var v85 = PPC4EstimatedEscrowAmount; v85.Clean = value; PPC4EstimatedEscrowAmount = v85;
                var v86 = PPC4EstimatedEscrowAmountUI; v86.Clean = value; PPC4EstimatedEscrowAmountUI = v86;
                var v87 = PPC4InterestOnly; v87.Clean = value; PPC4InterestOnly = v87;
                var v88 = PPC4MaximumMonthlyPayment; v88.Clean = value; PPC4MaximumMonthlyPayment = v88;
                var v89 = PPC4MaximumMonthlyPaymentUI; v89.Clean = value; PPC4MaximumMonthlyPaymentUI = v89;
                var v90 = PPC4MaximumPIPayment; v90.Clean = value; PPC4MaximumPIPayment = v90;
                var v91 = PPC4MaximumPIPaymentUI; v91.Clean = value; PPC4MaximumPIPaymentUI = v91;
                var v92 = PPC4MIAmount; v92.Clean = value; PPC4MIAmount = v92;
                var v93 = PPC4MIAmountUI; v93.Clean = value; PPC4MIAmountUI = v93;
                var v94 = PPC4MinimumMonthlyPayment; v94.Clean = value; PPC4MinimumMonthlyPayment = v94;
                var v95 = PPC4MinimumMonthlyPaymentUI; v95.Clean = value; PPC4MinimumMonthlyPaymentUI = v95;
                var v96 = PPC4MinimumPIPayment; v96.Clean = value; PPC4MinimumPIPayment = v96;
                var v97 = PPC4MinimumPIPaymentUI; v97.Clean = value; PPC4MinimumPIPaymentUI = v97;
                var v98 = PPC4YearFrom; v98.Clean = value; PPC4YearFrom = v98;
                var v99 = PPC4YearTo; v99.Clean = value; PPC4YearTo = v99;
                var v100 = PPEstimatedEscrowIndicator; v100.Clean = value; PPEstimatedEscrowIndicator = v100;
                var v101 = PrepaymentPenaltyPayOffDuringYear; v101.Clean = value; PrepaymentPenaltyPayOffDuringYear = v101;
                var v102 = PrepaymentPenaltyPayOffInDateType; v102.Clean = value; PrepaymentPenaltyPayOffInDateType = v102;
                var v103 = PrepaymentPenaltyPayOffInFirstYear; v103.Clean = value; PrepaymentPenaltyPayOffInFirstYear = v103;
                var v104 = RangePaymentIndicatorC1; v104.Clean = value; RangePaymentIndicatorC1 = v104;
                var v105 = RangePaymentIndicatorC2; v105.Clean = value; RangePaymentIndicatorC2 = v105;
                var v106 = RangePaymentIndicatorC3; v106.Clean = value; RangePaymentIndicatorC3 = v106;
                var v107 = RangePaymentIndicatorC4; v107.Clean = value; RangePaymentIndicatorC4 = v107;
                var v108 = RateLockExpirationTime; v108.Clean = value; RateLockExpirationTime = v108;
                var v109 = RateLockExpirationTimeZone; v109.Clean = value; RateLockExpirationTimeZone = v109;
                var v110 = ReasonChangedCircumstanceFlags; v110.Clean = value; ReasonChangedCircumstanceFlags = v110;
                var v111 = ReasonDelayedSettlement; v111.Clean = value; ReasonDelayedSettlement = v111;
                var v112 = ReasonEligibility; v112.Clean = value; ReasonEligibility = v112;
                var v113 = ReasonExpiration; v113.Clean = value; ReasonExpiration = v113;
                var v114 = ReasonInterestRate; v114.Clean = value; ReasonInterestRate = v114;
                var v115 = ReasonOther; v115.Clean = value; ReasonOther = v115;
                var v116 = ReasonOtherDescription; v116.Clean = value; ReasonOtherDescription = v116;
                var v117 = ReasonRevisions; v117.Clean = value; ReasonRevisions = v117;
                var v118 = ReasonSettlementCharges; v118.Clean = value; ReasonSettlementCharges = v118;
                var v119 = TotalEstimatedCashClose; v119.Clean = value; TotalEstimatedCashClose = v119;
                var v120 = YearsToRecast; v120.Clean = value; YearsToRecast = v120;
                _settingClean = 0;
            }
        }
    }
}