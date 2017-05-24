using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure1
    {
        public Value<DateTime?> CDDateIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDDateIssued() => !CDDateIssued.Clean;
        public Value<string> ChangedCircumstance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangedCircumstance() => !ChangedCircumstance.Clean;
        public Value<bool?> ChangedCircumstanceFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangedCircumstanceFlag() => !ChangedCircumstanceFlag.Clean;
        public Value<DateTime?> ChangesReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangesReceivedDate() => !ChangesReceivedDate.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> DisclosureBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureBy() => !DisclosureBy.Clean;
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
        public Value<string> DocumentGUIDFinalExecutedCopyofAlternateCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentGUIDFinalExecutedCopyofAlternateCD() => !DocumentGUIDFinalExecutedCopyofAlternateCD.Clean;
        public Value<string> DocumentGUIDFinalExecutedCopyofSellerCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentGUIDFinalExecutedCopyofSellerCD() => !DocumentGUIDFinalExecutedCopyofSellerCD.Clean;
        public Value<string> DocumentGUIDFinalExecutedCopyofStandardCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentGUIDFinalExecutedCopyofStandardCD() => !DocumentGUIDFinalExecutedCopyofStandardCD.Clean;
        public Value<decimal?> EstimatedTaxesInsuranceAssessments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTaxesInsuranceAssessments() => !EstimatedTaxesInsuranceAssessments.Clean;
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
        public Value<DateTime?> InitialCDReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialCDReceivedDate() => !InitialCDReceivedDate.Clean;
        public Value<string> MICReference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMICReference() => !MICReference.Clean;
        public Value<bool?> NotNaturalPersonFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotNaturalPersonFlag() => !NotNaturalPersonFlag.Clean;
        public Value<decimal?> PPC1EstimatedEscrowAmount { get; set; }
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
        public Value<decimal?> PPC1MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmount() => !PPC1MIAmount.Clean;
        public Value<string> PPC1MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmountUI() => !PPC1MIAmountUI.Clean;
        public Value<decimal?> PPC1MinimumMonthlyPayment { get; set; }
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
        public Value<decimal?> PPC2EstimatedEscrowAmount { get; set; }
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
        public Value<decimal?> PPC2MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmount() => !PPC2MIAmount.Clean;
        public Value<string> PPC2MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmountUI() => !PPC2MIAmountUI.Clean;
        public Value<decimal?> PPC2MinimumMonthlyPayment { get; set; }
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
        public Value<decimal?> PPC3EstimatedEscrowAmount { get; set; }
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
        public Value<decimal?> PPC3MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmount() => !PPC3MIAmount.Clean;
        public Value<string> PPC3MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmountUI() => !PPC3MIAmountUI.Clean;
        public Value<decimal?> PPC3MinimumMonthlyPayment { get; set; }
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
        public Value<decimal?> PPC4EstimatedEscrowAmount { get; set; }
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
        public Value<decimal?> PPC4MIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmount() => !PPC4MIAmount.Clean;
        public Value<string> PPC4MIAmountUI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmountUI() => !PPC4MIAmountUI.Clean;
        public Value<decimal?> PPC4MinimumMonthlyPayment { get; set; }
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
        public Value<bool?> PPCEstimatedEscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPCEstimatedEscrowIndicator() => !PPCEstimatedEscrowIndicator.Clean;
        public Value<bool?> PPCMortgageInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPCMortgageInsuranceIndicator() => !PPCMortgageInsuranceIndicator.Clean;
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
        public Value<bool?> ReasonAdvancedReview { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonAdvancedReview() => !ReasonAdvancedReview.Clean;
        public Value<bool?> ReasonChangedCircumstanceElg { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangedCircumstanceElg() => !ReasonChangedCircumstanceElg.Clean;
        public Value<string> ReasonChangedCircumstanceFlags { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangedCircumstanceFlags() => !ReasonChangedCircumstanceFlags.Clean;
        public Value<bool?> ReasonChangeInAPR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangeInAPR() => !ReasonChangeInAPR.Clean;
        public Value<bool?> ReasonChangeInLoanProduct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangeInLoanProduct() => !ReasonChangeInLoanProduct.Clean;
        public Value<bool?> ReasonChangeSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangeSettlementCharges() => !ReasonChangeSettlementCharges.Clean;
        public Value<bool?> ReasonClericalErrorCorrection { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonClericalErrorCorrection() => !ReasonClericalErrorCorrection.Clean;
        public Value<bool?> ReasonInterestRatecharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonInterestRatecharges() => !ReasonInterestRatecharges.Clean;
        public Value<bool?> ReasonOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOther() => !ReasonOther.Clean;
        public Value<string> ReasonOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOtherDescription() => !ReasonOtherDescription.Clean;
        public Value<bool?> ReasonPrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonPrepaymentPenalty() => !ReasonPrepaymentPenalty.Clean;
        public Value<bool?> ReasonRevisionsReqConsumer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonRevisionsReqConsumer() => !ReasonRevisionsReqConsumer.Clean;
        public Value<bool?> ReasonToleranceCure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonToleranceCure() => !ReasonToleranceCure.Clean;
        public Value<DateTime?> RevisedCDDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRevisedCDDueDate() => !RevisedCDDueDate.Clean;
        public Value<DateTime?> RevisedCDReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRevisedCDReceivedDate() => !RevisedCDReceivedDate.Clean;
        public Value<string> SellerNames { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerNames() => !SellerNames.Clean;
        public Value<string> SignatureTypeFinalExecutedCopyofAlternateCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureTypeFinalExecutedCopyofAlternateCD() => !SignatureTypeFinalExecutedCopyofAlternateCD.Clean;
        public Value<string> SignatureTypeFinalExecutedCopyofSellerCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureTypeFinalExecutedCopyofSellerCD() => !SignatureTypeFinalExecutedCopyofSellerCD.Clean;
        public Value<string> SignatureTypeFinalExecutedCopyofStandardCD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureTypeFinalExecutedCopyofStandardCD() => !SignatureTypeFinalExecutedCopyofStandardCD.Clean;
        public Value<decimal?> TotalCashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCashToClose() => !TotalCashToClose.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CDDateIssued.Clean
                    && ChangedCircumstance.Clean
                    && ChangedCircumstanceFlag.Clean
                    && ChangesReceivedDate.Clean
                    && Comments.Clean
                    && DisclosureBy.Clean
                    && DisclosureComments.Clean
                    && DisclosureLastSentDate.Clean
                    && DisclosureReceivedDate.Clean
                    && DisclosureSentMethod.Clean
                    && DocumentGUIDFinalExecutedCopyofAlternateCD.Clean
                    && DocumentGUIDFinalExecutedCopyofSellerCD.Clean
                    && DocumentGUIDFinalExecutedCopyofStandardCD.Clean
                    && EstimatedTaxesInsuranceAssessments.Clean
                    && Id.Clean
                    && InEscrowHomeownerInsurance.Clean
                    && InEscrowOther.Clean
                    && InEscrowPropertyTaxes.Clean
                    && InitialCDReceivedDate.Clean
                    && MICReference.Clean
                    && NotNaturalPersonFlag.Clean
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
                    && PPCEstimatedEscrowIndicator.Clean
                    && PPCMortgageInsuranceIndicator.Clean
                    && RangePaymentIndicatorC1.Clean
                    && RangePaymentIndicatorC2.Clean
                    && RangePaymentIndicatorC3.Clean
                    && RangePaymentIndicatorC4.Clean
                    && ReasonAdvancedReview.Clean
                    && ReasonChangedCircumstanceElg.Clean
                    && ReasonChangedCircumstanceFlags.Clean
                    && ReasonChangeInAPR.Clean
                    && ReasonChangeInLoanProduct.Clean
                    && ReasonChangeSettlementCharges.Clean
                    && ReasonClericalErrorCorrection.Clean
                    && ReasonInterestRatecharges.Clean
                    && ReasonOther.Clean
                    && ReasonOtherDescription.Clean
                    && ReasonPrepaymentPenalty.Clean
                    && ReasonRevisionsReqConsumer.Clean
                    && ReasonToleranceCure.Clean
                    && RevisedCDDueDate.Clean
                    && RevisedCDReceivedDate.Clean
                    && SellerNames.Clean
                    && SignatureTypeFinalExecutedCopyofAlternateCD.Clean
                    && SignatureTypeFinalExecutedCopyofSellerCD.Clean
                    && SignatureTypeFinalExecutedCopyofStandardCD.Clean
                    && TotalCashToClose.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CDDateIssued; v0.Clean = value; CDDateIssued = v0;
                var v1 = ChangedCircumstance; v1.Clean = value; ChangedCircumstance = v1;
                var v2 = ChangedCircumstanceFlag; v2.Clean = value; ChangedCircumstanceFlag = v2;
                var v3 = ChangesReceivedDate; v3.Clean = value; ChangesReceivedDate = v3;
                var v4 = Comments; v4.Clean = value; Comments = v4;
                var v5 = DisclosureBy; v5.Clean = value; DisclosureBy = v5;
                var v6 = DisclosureComments; v6.Clean = value; DisclosureComments = v6;
                var v7 = DisclosureLastSentDate; v7.Clean = value; DisclosureLastSentDate = v7;
                var v8 = DisclosureReceivedDate; v8.Clean = value; DisclosureReceivedDate = v8;
                var v9 = DisclosureSentMethod; v9.Clean = value; DisclosureSentMethod = v9;
                var v10 = DocumentGUIDFinalExecutedCopyofAlternateCD; v10.Clean = value; DocumentGUIDFinalExecutedCopyofAlternateCD = v10;
                var v11 = DocumentGUIDFinalExecutedCopyofSellerCD; v11.Clean = value; DocumentGUIDFinalExecutedCopyofSellerCD = v11;
                var v12 = DocumentGUIDFinalExecutedCopyofStandardCD; v12.Clean = value; DocumentGUIDFinalExecutedCopyofStandardCD = v12;
                var v13 = EstimatedTaxesInsuranceAssessments; v13.Clean = value; EstimatedTaxesInsuranceAssessments = v13;
                var v14 = Id; v14.Clean = value; Id = v14;
                var v15 = InEscrowHomeownerInsurance; v15.Clean = value; InEscrowHomeownerInsurance = v15;
                var v16 = InEscrowOther; v16.Clean = value; InEscrowOther = v16;
                var v17 = InEscrowPropertyTaxes; v17.Clean = value; InEscrowPropertyTaxes = v17;
                var v18 = InitialCDReceivedDate; v18.Clean = value; InitialCDReceivedDate = v18;
                var v19 = MICReference; v19.Clean = value; MICReference = v19;
                var v20 = NotNaturalPersonFlag; v20.Clean = value; NotNaturalPersonFlag = v20;
                var v21 = PPC1EstimatedEscrowAmount; v21.Clean = value; PPC1EstimatedEscrowAmount = v21;
                var v22 = PPC1EstimatedEscrowAmountUI; v22.Clean = value; PPC1EstimatedEscrowAmountUI = v22;
                var v23 = PPC1InterestOnly; v23.Clean = value; PPC1InterestOnly = v23;
                var v24 = PPC1MaximumMonthlyPayment; v24.Clean = value; PPC1MaximumMonthlyPayment = v24;
                var v25 = PPC1MaximumMonthlyPaymentUI; v25.Clean = value; PPC1MaximumMonthlyPaymentUI = v25;
                var v26 = PPC1MaximumPIPayment; v26.Clean = value; PPC1MaximumPIPayment = v26;
                var v27 = PPC1MaximumPIPaymentUI; v27.Clean = value; PPC1MaximumPIPaymentUI = v27;
                var v28 = PPC1MIAmount; v28.Clean = value; PPC1MIAmount = v28;
                var v29 = PPC1MIAmountUI; v29.Clean = value; PPC1MIAmountUI = v29;
                var v30 = PPC1MinimumMonthlyPayment; v30.Clean = value; PPC1MinimumMonthlyPayment = v30;
                var v31 = PPC1MinimumMonthlyPaymentUI; v31.Clean = value; PPC1MinimumMonthlyPaymentUI = v31;
                var v32 = PPC1MinimumPIPayment; v32.Clean = value; PPC1MinimumPIPayment = v32;
                var v33 = PPC1MinimumPIPaymentUI; v33.Clean = value; PPC1MinimumPIPaymentUI = v33;
                var v34 = PPC1Year; v34.Clean = value; PPC1Year = v34;
                var v35 = PPC2EstimatedEscrowAmount; v35.Clean = value; PPC2EstimatedEscrowAmount = v35;
                var v36 = PPC2EstimatedEscrowAmountUI; v36.Clean = value; PPC2EstimatedEscrowAmountUI = v36;
                var v37 = PPC2InterestOnly; v37.Clean = value; PPC2InterestOnly = v37;
                var v38 = PPC2MaximumMonthlyPayment; v38.Clean = value; PPC2MaximumMonthlyPayment = v38;
                var v39 = PPC2MaximumMonthlyPaymentUI; v39.Clean = value; PPC2MaximumMonthlyPaymentUI = v39;
                var v40 = PPC2MaximumPIPayment; v40.Clean = value; PPC2MaximumPIPayment = v40;
                var v41 = PPC2MaximumPIPaymentUI; v41.Clean = value; PPC2MaximumPIPaymentUI = v41;
                var v42 = PPC2MIAmount; v42.Clean = value; PPC2MIAmount = v42;
                var v43 = PPC2MIAmountUI; v43.Clean = value; PPC2MIAmountUI = v43;
                var v44 = PPC2MinimumMonthlyPayment; v44.Clean = value; PPC2MinimumMonthlyPayment = v44;
                var v45 = PPC2MinimumMonthlyPaymentUI; v45.Clean = value; PPC2MinimumMonthlyPaymentUI = v45;
                var v46 = PPC2MinimumPIPayment; v46.Clean = value; PPC2MinimumPIPayment = v46;
                var v47 = PPC2MinimumPIPaymentUI; v47.Clean = value; PPC2MinimumPIPaymentUI = v47;
                var v48 = PPC2YearFrom; v48.Clean = value; PPC2YearFrom = v48;
                var v49 = PPC2YearTo; v49.Clean = value; PPC2YearTo = v49;
                var v50 = PPC3EstimatedEscrowAmount; v50.Clean = value; PPC3EstimatedEscrowAmount = v50;
                var v51 = PPC3EstimatedEscrowAmountUI; v51.Clean = value; PPC3EstimatedEscrowAmountUI = v51;
                var v52 = PPC3InterestOnly; v52.Clean = value; PPC3InterestOnly = v52;
                var v53 = PPC3MaximumMonthlyPayment; v53.Clean = value; PPC3MaximumMonthlyPayment = v53;
                var v54 = PPC3MaximumMonthlyPaymentUI; v54.Clean = value; PPC3MaximumMonthlyPaymentUI = v54;
                var v55 = PPC3MaximumPIPayment; v55.Clean = value; PPC3MaximumPIPayment = v55;
                var v56 = PPC3MaximumPIPaymentUI; v56.Clean = value; PPC3MaximumPIPaymentUI = v56;
                var v57 = PPC3MIAmount; v57.Clean = value; PPC3MIAmount = v57;
                var v58 = PPC3MIAmountUI; v58.Clean = value; PPC3MIAmountUI = v58;
                var v59 = PPC3MinimumMonthlyPayment; v59.Clean = value; PPC3MinimumMonthlyPayment = v59;
                var v60 = PPC3MinimumMonthlyPaymentUI; v60.Clean = value; PPC3MinimumMonthlyPaymentUI = v60;
                var v61 = PPC3MinimumPIPayment; v61.Clean = value; PPC3MinimumPIPayment = v61;
                var v62 = PPC3MinimumPIPaymentUI; v62.Clean = value; PPC3MinimumPIPaymentUI = v62;
                var v63 = PPC3YearFrom; v63.Clean = value; PPC3YearFrom = v63;
                var v64 = PPC3YearTo; v64.Clean = value; PPC3YearTo = v64;
                var v65 = PPC4EstimatedEscrowAmount; v65.Clean = value; PPC4EstimatedEscrowAmount = v65;
                var v66 = PPC4EstimatedEscrowAmountUI; v66.Clean = value; PPC4EstimatedEscrowAmountUI = v66;
                var v67 = PPC4InterestOnly; v67.Clean = value; PPC4InterestOnly = v67;
                var v68 = PPC4MaximumMonthlyPayment; v68.Clean = value; PPC4MaximumMonthlyPayment = v68;
                var v69 = PPC4MaximumMonthlyPaymentUI; v69.Clean = value; PPC4MaximumMonthlyPaymentUI = v69;
                var v70 = PPC4MaximumPIPayment; v70.Clean = value; PPC4MaximumPIPayment = v70;
                var v71 = PPC4MaximumPIPaymentUI; v71.Clean = value; PPC4MaximumPIPaymentUI = v71;
                var v72 = PPC4MIAmount; v72.Clean = value; PPC4MIAmount = v72;
                var v73 = PPC4MIAmountUI; v73.Clean = value; PPC4MIAmountUI = v73;
                var v74 = PPC4MinimumMonthlyPayment; v74.Clean = value; PPC4MinimumMonthlyPayment = v74;
                var v75 = PPC4MinimumMonthlyPaymentUI; v75.Clean = value; PPC4MinimumMonthlyPaymentUI = v75;
                var v76 = PPC4MinimumPIPayment; v76.Clean = value; PPC4MinimumPIPayment = v76;
                var v77 = PPC4MinimumPIPaymentUI; v77.Clean = value; PPC4MinimumPIPaymentUI = v77;
                var v78 = PPC4YearFrom; v78.Clean = value; PPC4YearFrom = v78;
                var v79 = PPC4YearTo; v79.Clean = value; PPC4YearTo = v79;
                var v80 = PPCEstimatedEscrowIndicator; v80.Clean = value; PPCEstimatedEscrowIndicator = v80;
                var v81 = PPCMortgageInsuranceIndicator; v81.Clean = value; PPCMortgageInsuranceIndicator = v81;
                var v82 = RangePaymentIndicatorC1; v82.Clean = value; RangePaymentIndicatorC1 = v82;
                var v83 = RangePaymentIndicatorC2; v83.Clean = value; RangePaymentIndicatorC2 = v83;
                var v84 = RangePaymentIndicatorC3; v84.Clean = value; RangePaymentIndicatorC3 = v84;
                var v85 = RangePaymentIndicatorC4; v85.Clean = value; RangePaymentIndicatorC4 = v85;
                var v86 = ReasonAdvancedReview; v86.Clean = value; ReasonAdvancedReview = v86;
                var v87 = ReasonChangedCircumstanceElg; v87.Clean = value; ReasonChangedCircumstanceElg = v87;
                var v88 = ReasonChangedCircumstanceFlags; v88.Clean = value; ReasonChangedCircumstanceFlags = v88;
                var v89 = ReasonChangeInAPR; v89.Clean = value; ReasonChangeInAPR = v89;
                var v90 = ReasonChangeInLoanProduct; v90.Clean = value; ReasonChangeInLoanProduct = v90;
                var v91 = ReasonChangeSettlementCharges; v91.Clean = value; ReasonChangeSettlementCharges = v91;
                var v92 = ReasonClericalErrorCorrection; v92.Clean = value; ReasonClericalErrorCorrection = v92;
                var v93 = ReasonInterestRatecharges; v93.Clean = value; ReasonInterestRatecharges = v93;
                var v94 = ReasonOther; v94.Clean = value; ReasonOther = v94;
                var v95 = ReasonOtherDescription; v95.Clean = value; ReasonOtherDescription = v95;
                var v96 = ReasonPrepaymentPenalty; v96.Clean = value; ReasonPrepaymentPenalty = v96;
                var v97 = ReasonRevisionsReqConsumer; v97.Clean = value; ReasonRevisionsReqConsumer = v97;
                var v98 = ReasonToleranceCure; v98.Clean = value; ReasonToleranceCure = v98;
                var v99 = RevisedCDDueDate; v99.Clean = value; RevisedCDDueDate = v99;
                var v100 = RevisedCDReceivedDate; v100.Clean = value; RevisedCDReceivedDate = v100;
                var v101 = SellerNames; v101.Clean = value; SellerNames = v101;
                var v102 = SignatureTypeFinalExecutedCopyofAlternateCD; v102.Clean = value; SignatureTypeFinalExecutedCopyofAlternateCD = v102;
                var v103 = SignatureTypeFinalExecutedCopyofSellerCD; v103.Clean = value; SignatureTypeFinalExecutedCopyofSellerCD = v103;
                var v104 = SignatureTypeFinalExecutedCopyofStandardCD; v104.Clean = value; SignatureTypeFinalExecutedCopyofStandardCD = v104;
                var v105 = TotalCashToClose; v105.Clean = value; TotalCashToClose = v105;
                _settingClean = 0;
            }
        }
    }
}