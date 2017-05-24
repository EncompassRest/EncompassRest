using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RateLock
    {
        public Value<decimal?> ActualSellAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSellAmount() => !ActualSellAmount.Clean;
        public Value<decimal?> ActualSellPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSellPrice() => !ActualSellPrice.Clean;
        public Value<decimal?> ActualSellSideSRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSellSideSRP() => !ActualSellSideSRP.Clean;
        public Value<decimal?> ActualSRPAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSRPAmount() => !ActualSRPAmount.Clean;
        public Value<decimal?> AmountDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountDue() => !AmountDue.Clean;
        public Value<string> AmountDueTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountDueTo() => !AmountDueTo.Clean;
        public Value<decimal?> AmountPaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountPaid() => !AmountPaid.Clean;
        public Value<string> AmountPaidTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountPaidTo() => !AmountPaidTo.Clean;
        public Value<decimal?> AmountReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountReceived() => !AmountReceived.Clean;
        public Value<int?> BalloonLoanMaturityTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonLoanMaturityTermMonths() => !BalloonLoanMaturityTermMonths.Clean;
        public Value<decimal?> BaseLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseLoanAmount() => !BaseLoanAmount.Clean;
        public Value<decimal?> BorrowerRequestedLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerRequestedLoanAmount() => !BorrowerRequestedLoanAmount.Clean;
        public Value<DateTime?> BranchApprovalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchApprovalDate() => !BranchApprovalDate.Clean;
        public Value<string> BranchApprovedby { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchApprovedby() => !BranchApprovedby.Clean;
        public Value<decimal?> BranchPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchPrice() => !BranchPrice.Clean;
        public Value<List<PriceAdjustment>> BuySideAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideAdjustments() => !BuySideAdjustments.Clean;
        public Value<string> BuySideComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideComments() => !BuySideComments.Clean;
        public Value<DateTime?> BuySideCommitmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideCommitmentDate() => !BuySideCommitmentDate.Clean;
        public Value<string> BuySideCommitmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideCommitmentNumber() => !BuySideCommitmentNumber.Clean;
        public Value<string> BuySideCommitmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideCommitmentType() => !BuySideCommitmentType.Clean;
        public Value<DateTime?> BuySideCurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideCurrentRateSetDate() => !BuySideCurrentRateSetDate.Clean;
        public Value<int?> BuySideDaystoExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideDaystoExtend() => !BuySideDaystoExtend.Clean;
        public Value<DateTime?> BuySideDeliveryExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideDeliveryExpirationDate() => !BuySideDeliveryExpirationDate.Clean;
        public Value<string> BuySideDeliveryType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideDeliveryType() => !BuySideDeliveryType.Clean;
        public Value<DateTime?> BuySideExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExpirationDate() => !BuySideExpirationDate.Clean;
        public Value<DateTime?> BuySideExtendedLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideExtendedLockExpires() => !BuySideExtendedLockExpires.Clean;
        public Value<DateTime?> BuySideLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideLockDate() => !BuySideLockDate.Clean;
        public Value<DateTime?> BuySideLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideLockExpires() => !BuySideLockExpires.Clean;
        public Value<decimal?> BuySideLockExtendPriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideLockExtendPriceAdjustment() => !BuySideLockExtendPriceAdjustment.Clean;
        public Value<decimal?> BuySideMarginNetBuyRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideMarginNetBuyRate() => !BuySideMarginNetBuyRate.Clean;
        public Value<decimal?> BuySideMarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideMarginRate() => !BuySideMarginRate.Clean;
        public Value<decimal?> BuySideMarginTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideMarginTotalAdjustment() => !BuySideMarginTotalAdjustment.Clean;
        public Value<string> BuySideMasterCommitmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideMasterCommitmentNumber() => !BuySideMasterCommitmentNumber.Clean;
        public Value<int?> BuySideNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideNumberOfDays() => !BuySideNumberOfDays.Clean;
        public Value<bool?> BuySideOnrpEligible { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideOnrpEligible() => !BuySideOnrpEligible.Clean;
        public Value<DateTime?> BuySideOnrpLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideOnrpLockDate() => !BuySideOnrpLockDate.Clean;
        public Value<string> BuySideOnrpLockTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideOnrpLockTime() => !BuySideOnrpLockTime.Clean;
        public Value<string> BuySideOrgID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideOrgID() => !BuySideOrgID.Clean;
        public Value<DateTime?> BuySideOriginalLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideOriginalLockExpires() => !BuySideOriginalLockExpires.Clean;
        public Value<decimal?> BuySidePriceNetBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySidePriceNetBuyPrice() => !BuySidePriceNetBuyPrice.Clean;
        public Value<decimal?> BuySidePriceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySidePriceRate() => !BuySidePriceRate.Clean;
        public Value<decimal?> BuySidePriceTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySidePriceTotalAdjustment() => !BuySidePriceTotalAdjustment.Clean;
        public Value<decimal?> BuySideRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideRate() => !BuySideRate.Clean;
        public Value<decimal?> BuySideRateNetBuyRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideRateNetBuyRate() => !BuySideRateNetBuyRate.Clean;
        public Value<string> BuySideRateSheetID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideRateSheetID() => !BuySideRateSheetID.Clean;
        public Value<decimal?> BuySideRateTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideRateTotalAdjustment() => !BuySideRateTotalAdjustment.Clean;
        public Value<string> BuySideRequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideRequestedBy() => !BuySideRequestedBy.Clean;
        public Value<decimal?> BuySideSRPPaidOut { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideSRPPaidOut() => !BuySideSRPPaidOut.Clean;
        public Value<decimal?> BuySideStartingAdjPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideStartingAdjPoint() => !BuySideStartingAdjPoint.Clean;
        public Value<decimal?> BuySideStartingAdjPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideStartingAdjPrice() => !BuySideStartingAdjPrice.Clean;
        public Value<decimal?> BuySideStartingAdjRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideStartingAdjRate() => !BuySideStartingAdjRate.Clean;
        public Value<string> BuySideTPOID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideTPOID() => !BuySideTPOID.Clean;
        public Value<string> BuySideTPOName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideTPOName() => !BuySideTPOName.Clean;
        public Value<string> BuySideTradeGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideTradeGuid() => !BuySideTradeGuid.Clean;
        public Value<string> BuySideTradeNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideTradeNumber() => !BuySideTradeNumber.Clean;
        public Value<decimal?> BuySideUnDiscountedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuySideUnDiscountedRate() => !BuySideUnDiscountedRate.Clean;
        public Value<string> CancellationRequestPending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCancellationRequestPending() => !CancellationRequestPending.Clean;
        public Value<decimal?> CombinedLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCombinedLTV() => !CombinedLTV.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> Commitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitment() => !Commitment.Clean;
        public Value<decimal?> CompGainLossPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompGainLossPercentage() => !CompGainLossPercentage.Clean;
        public Value<decimal?> CompGainLossPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompGainLossPrice() => !CompGainLossPrice.Clean;
        public Value<decimal?> CompGainLossTotalBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompGainLossTotalBuyPrice() => !CompGainLossTotalBuyPrice.Clean;
        public Value<decimal?> CompGainLossTotalCompPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompGainLossTotalCompPrice() => !CompGainLossTotalCompPrice.Clean;
        public Value<string> CompInvestorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorAddress() => !CompInvestorAddress.Clean;
        public Value<string> CompInvestorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorCity() => !CompInvestorCity.Clean;
        public Value<string> CompInvestorCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorCommitment() => !CompInvestorCommitment.Clean;
        public Value<string> CompInvestorContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorContact() => !CompInvestorContact.Clean;
        public Value<string> CompInvestorEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorEmail() => !CompInvestorEmail.Clean;
        public Value<string> CompInvestorLockType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorLockType() => !CompInvestorLockType.Clean;
        public Value<string> CompInvestorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorName() => !CompInvestorName.Clean;
        public Value<string> CompInvestorPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorPhone() => !CompInvestorPhone.Clean;
        public Value<string> CompInvestorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorPostalCode() => !CompInvestorPostalCode.Clean;
        public Value<string> CompInvestorProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorProgramCode() => !CompInvestorProgramCode.Clean;
        public Value<string> CompInvestorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorState() => !CompInvestorState.Clean;
        public Value<string> CompInvestorTemplateName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorTemplateName() => !CompInvestorTemplateName.Clean;
        public Value<string> CompInvestorWebsite { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompInvestorWebsite() => !CompInvestorWebsite.Clean;
        public Value<List<PriceAdjustment>> CompSideAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideAdjustments() => !CompSideAdjustments.Clean;
        public Value<string> CompSideComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideComments() => !CompSideComments.Clean;
        public Value<string> CompSideComparisonedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideComparisonedBy() => !CompSideComparisonedBy.Clean;
        public Value<DateTime?> CompSideCurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideCurrentRateSetDate() => !CompSideCurrentRateSetDate.Clean;
        public Value<int?> CompSideDaystoExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideDaystoExtend() => !CompSideDaystoExtend.Clean;
        public Value<decimal?> CompSideDiscountYSP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideDiscountYSP() => !CompSideDiscountYSP.Clean;
        public Value<DateTime?> CompSideExtendedLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideExtendedLockExpires() => !CompSideExtendedLockExpires.Clean;
        public Value<string> CompSideInvestorStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideInvestorStatus() => !CompSideInvestorStatus.Clean;
        public Value<DateTime?> CompSideInvestorStatusDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideInvestorStatusDate() => !CompSideInvestorStatusDate.Clean;
        public Value<string> CompSideInvestorTradeNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideInvestorTradeNumber() => !CompSideInvestorTradeNumber.Clean;
        public Value<string> CompSideLoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideLoanProgram() => !CompSideLoanProgram.Clean;
        public Value<DateTime?> CompSideLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideLockDate() => !CompSideLockDate.Clean;
        public Value<DateTime?> CompSideLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideLockExpires() => !CompSideLockExpires.Clean;
        public Value<decimal?> CompSideLockExtendPriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideLockExtendPriceAdjustment() => !CompSideLockExtendPriceAdjustment.Clean;
        public Value<decimal?> CompSideMarginNetCompRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideMarginNetCompRate() => !CompSideMarginNetCompRate.Clean;
        public Value<decimal?> CompSideMarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideMarginRate() => !CompSideMarginRate.Clean;
        public Value<decimal?> CompSideMarginTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideMarginTotalAdjustment() => !CompSideMarginTotalAdjustment.Clean;
        public Value<string> CompSideMasterContractNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideMasterContractNumber() => !CompSideMasterContractNumber.Clean;
        public Value<decimal?> CompSideNetCompPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideNetCompPrice() => !CompSideNetCompPrice.Clean;
        public Value<decimal?> CompSideNetCompRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideNetCompRate() => !CompSideNetCompRate.Clean;
        public Value<int?> CompSideNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideNumberOfDays() => !CompSideNumberOfDays.Clean;
        public Value<DateTime?> CompSideOriginalLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideOriginalLockExpires() => !CompSideOriginalLockExpires.Clean;
        public Value<decimal?> CompSidePriceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSidePriceRate() => !CompSidePriceRate.Clean;
        public Value<decimal?> CompSidePriceTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSidePriceTotalAdjustment() => !CompSidePriceTotalAdjustment.Clean;
        public Value<decimal?> CompSideRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideRate() => !CompSideRate.Clean;
        public Value<string> CompSideRateSheetID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideRateSheetID() => !CompSideRateSheetID.Clean;
        public Value<decimal?> CompSideRateTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideRateTotalAdjustment() => !CompSideRateTotalAdjustment.Clean;
        public Value<string> CompSideRequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideRequestedBy() => !CompSideRequestedBy.Clean;
        public Value<string> CompSideServicingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideServicingType() => !CompSideServicingType.Clean;
        public Value<decimal?> CompSideSRPPaidOut { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideSRPPaidOut() => !CompSideSRPPaidOut.Clean;
        public Value<string> CompSideTradeGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideTradeGuid() => !CompSideTradeGuid.Clean;
        public Value<string> CompSideTradeNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompSideTradeNumber() => !CompSideTradeNumber.Clean;
        public Value<string> ConfirmedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedBy() => !ConfirmedBy.Clean;
        public Value<DateTime?> ConfirmedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedDate() => !ConfirmedDate.Clean;
        public Value<DateTime?> CorporateApprovalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorporateApprovalDate() => !CorporateApprovalDate.Clean;
        public Value<string> CorporateApprovedby { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorporateApprovedby() => !CorporateApprovedby.Clean;
        public Value<decimal?> CorporatePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorporatePrice() => !CorporatePrice.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount1() => !CorrespondentAdditionalLineAmount1.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount10() => !CorrespondentAdditionalLineAmount10.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount11() => !CorrespondentAdditionalLineAmount11.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount12() => !CorrespondentAdditionalLineAmount12.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount13() => !CorrespondentAdditionalLineAmount13.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount2() => !CorrespondentAdditionalLineAmount2.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount3() => !CorrespondentAdditionalLineAmount3.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount4() => !CorrespondentAdditionalLineAmount4.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount5() => !CorrespondentAdditionalLineAmount5.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount6() => !CorrespondentAdditionalLineAmount6.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount7() => !CorrespondentAdditionalLineAmount7.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount8() => !CorrespondentAdditionalLineAmount8.Clean;
        public Value<decimal?> CorrespondentAdditionalLineAmount9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineAmount9() => !CorrespondentAdditionalLineAmount9.Clean;
        public Value<string> CorrespondentAdditionalLineDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription1() => !CorrespondentAdditionalLineDescription1.Clean;
        public Value<string> CorrespondentAdditionalLineDescription10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription10() => !CorrespondentAdditionalLineDescription10.Clean;
        public Value<string> CorrespondentAdditionalLineDescription11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription11() => !CorrespondentAdditionalLineDescription11.Clean;
        public Value<string> CorrespondentAdditionalLineDescription12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription12() => !CorrespondentAdditionalLineDescription12.Clean;
        public Value<string> CorrespondentAdditionalLineDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription2() => !CorrespondentAdditionalLineDescription2.Clean;
        public Value<string> CorrespondentAdditionalLineDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription3() => !CorrespondentAdditionalLineDescription3.Clean;
        public Value<string> CorrespondentAdditionalLineDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription4() => !CorrespondentAdditionalLineDescription4.Clean;
        public Value<string> CorrespondentAdditionalLineDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription5() => !CorrespondentAdditionalLineDescription5.Clean;
        public Value<string> CorrespondentAdditionalLineDescription6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription6() => !CorrespondentAdditionalLineDescription6.Clean;
        public Value<string> CorrespondentAdditionalLineDescription7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription7() => !CorrespondentAdditionalLineDescription7.Clean;
        public Value<string> CorrespondentAdditionalLineDescription8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription8() => !CorrespondentAdditionalLineDescription8.Clean;
        public Value<string> CorrespondentAdditionalLineDescription9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineDescription9() => !CorrespondentAdditionalLineDescription9.Clean;
        public Value<decimal?> CorrespondentAdditionalLineTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdditionalLineTotalAmount() => !CorrespondentAdditionalLineTotalAmount.Clean;
        public Value<decimal?> CorrespondentAdjusterAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterAmount1() => !CorrespondentAdjusterAmount1.Clean;
        public Value<decimal?> CorrespondentAdjusterAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterAmount2() => !CorrespondentAdjusterAmount2.Clean;
        public Value<decimal?> CorrespondentAdjusterAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterAmount3() => !CorrespondentAdjusterAmount3.Clean;
        public Value<string> CorrespondentAdjusterDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterDescription1() => !CorrespondentAdjusterDescription1.Clean;
        public Value<string> CorrespondentAdjusterDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterDescription2() => !CorrespondentAdjusterDescription2.Clean;
        public Value<string> CorrespondentAdjusterDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentAdjusterDescription3() => !CorrespondentAdjusterDescription3.Clean;
        public Value<string> CorrespondentConfirmedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentConfirmedBy() => !CorrespondentConfirmedBy.Clean;
        public Value<DateTime?> CorrespondentConfirmedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentConfirmedDate() => !CorrespondentConfirmedDate.Clean;
        public Value<decimal?> CorrespondentCurrentImpounds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentCurrentImpounds() => !CorrespondentCurrentImpounds.Clean;
        public Value<decimal?> CorrespondentCurrentPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentCurrentPrincipal() => !CorrespondentCurrentPrincipal.Clean;
        public Value<DateTime?> CorrespondentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentDate() => !CorrespondentDate.Clean;
        public Value<decimal?> CorrespondentFinalBuyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentFinalBuyAmount() => !CorrespondentFinalBuyAmount.Clean;
        public Value<decimal?> CorrespondentFinalBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentFinalBuyPrice() => !CorrespondentFinalBuyPrice.Clean;
        public Value<DateTime?> CorrespondentFirstPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentFirstPaymentDate() => !CorrespondentFirstPaymentDate.Clean;
        public Value<decimal?> CorrespondentImpounds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentImpounds() => !CorrespondentImpounds.Clean;
        public Value<decimal?> CorrespondentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentInterest() => !CorrespondentInterest.Clean;
        public Value<int?> CorrespondentInterestDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentInterestDays() => !CorrespondentInterestDays.Clean;
        public Value<decimal?> CorrespondentLateFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentLateFeeAmount() => !CorrespondentLateFeeAmount.Clean;
        public Value<decimal?> CorrespondentLateFeePriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentLateFeePriceAdjustment() => !CorrespondentLateFeePriceAdjustment.Clean;
        public Value<DateTime?> CorrespondentPaidToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentPaidToDate() => !CorrespondentPaidToDate.Clean;
        public Value<decimal?> CorrespondentPurchasedPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentPurchasedPrincipal() => !CorrespondentPurchasedPrincipal.Clean;
        public Value<string> CorrespondentReconcilationComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentReconcilationComments() => !CorrespondentReconcilationComments.Clean;
        public Value<decimal?> CorrespondentRemainingBuydownAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentRemainingBuydownAmount() => !CorrespondentRemainingBuydownAmount.Clean;
        public Value<decimal?> CorrespondentSRPAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentSRPAmount() => !CorrespondentSRPAmount.Clean;
        public Value<string> CorrespondentWarehouseBankABANum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankABANum() => !CorrespondentWarehouseBankABANum.Clean;
        public Value<string> CorrespondentWarehouseBankAcctNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankAcctNum() => !CorrespondentWarehouseBankAcctNum.Clean;
        public Value<string> CorrespondentWarehouseBankAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankAddress() => !CorrespondentWarehouseBankAddress.Clean;
        public Value<string> CorrespondentWarehouseBankAddress1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankAddress1() => !CorrespondentWarehouseBankAddress1.Clean;
        public Value<DateTime?> CorrespondentWarehouseBankBaileeExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankBaileeExpirationDate() => !CorrespondentWarehouseBankBaileeExpirationDate.Clean;
        public Value<bool?> CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankBaileeLetterReceivedIndicator() => !CorrespondentWarehouseBankBaileeLetterReceivedIndicator.Clean;
        public Value<bool?> CorrespondentWarehouseBankBaileeLetterReqIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankBaileeLetterReqIndicator() => !CorrespondentWarehouseBankBaileeLetterReqIndicator.Clean;
        public Value<string> CorrespondentWarehouseBankCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankCity() => !CorrespondentWarehouseBankCity.Clean;
        public Value<string> CorrespondentWarehouseBankContactEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankContactEmail() => !CorrespondentWarehouseBankContactEmail.Clean;
        public Value<string> CorrespondentWarehouseBankContactFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankContactFax() => !CorrespondentWarehouseBankContactFax.Clean;
        public Value<string> CorrespondentWarehouseBankContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankContactName() => !CorrespondentWarehouseBankContactName.Clean;
        public Value<string> CorrespondentWarehouseBankContactPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankContactPhone() => !CorrespondentWarehouseBankContactPhone.Clean;
        public Value<string> CorrespondentWarehouseBankDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankDescription() => !CorrespondentWarehouseBankDescription.Clean;
        public Value<int?> CorrespondentWarehouseBankId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankId() => !CorrespondentWarehouseBankId.Clean;
        public Value<string> CorrespondentWarehouseBankName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankName() => !CorrespondentWarehouseBankName.Clean;
        public Value<string> CorrespondentWarehouseBankNotes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankNotes() => !CorrespondentWarehouseBankNotes.Clean;
        public Value<bool?> CorrespondentWarehouseBankSelfFunderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankSelfFunderIndicator() => !CorrespondentWarehouseBankSelfFunderIndicator.Clean;
        public Value<string> CorrespondentWarehouseBankState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankState() => !CorrespondentWarehouseBankState.Clean;
        public Value<bool?> CorrespondentWarehouseBankTriPartyContractIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankTriPartyContractIndicator() => !CorrespondentWarehouseBankTriPartyContractIndicator.Clean;
        public Value<bool?> CorrespondentWarehouseBankUseDefaultContactIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankUseDefaultContactIndicator() => !CorrespondentWarehouseBankUseDefaultContactIndicator.Clean;
        public Value<bool?> CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankWireInstructionsReceivedIndicator() => !CorrespondentWarehouseBankWireInstructionsReceivedIndicator.Clean;
        public Value<string> CorrespondentWarehouseBankZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentWarehouseBankZip() => !CorrespondentWarehouseBankZip.Clean;
        public Value<string> CreditScoreToUse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScoreToUse() => !CreditScoreToUse.Clean;
        public Value<int?> CumulatedDaystoExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCumulatedDaystoExtend() => !CumulatedDaystoExtend.Clean;
        public Value<List<PriceAdjustment>> CurrentAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentAdjustments() => !CurrentAdjustments.Clean;
        public Value<string> CurrentComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentComments() => !CurrentComments.Clean;
        public Value<DateTime?> CurrentLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentLockDate() => !CurrentLockDate.Clean;
        public Value<DateTime?> CurrentLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentLockExpires() => !CurrentLockExpires.Clean;
        public Value<decimal?> CurrentMarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentMarginRate() => !CurrentMarginRate.Clean;
        public Value<decimal?> CurrentMarginRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentMarginRateRequested() => !CurrentMarginRateRequested.Clean;
        public Value<decimal?> CurrentMarginTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentMarginTotalAdjustment() => !CurrentMarginTotalAdjustment.Clean;
        public Value<int?> CurrentNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentNumberOfDays() => !CurrentNumberOfDays.Clean;
        public Value<decimal?> CurrentPriceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentPriceRate() => !CurrentPriceRate.Clean;
        public Value<decimal?> CurrentPriceRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentPriceRateRequested() => !CurrentPriceRateRequested.Clean;
        public Value<decimal?> CurrentPriceTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentPriceTotalAdjustment() => !CurrentPriceTotalAdjustment.Clean;
        public Value<decimal?> CurrentRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRate() => !CurrentRate.Clean;
        public Value<decimal?> CurrentRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateRequested() => !CurrentRateRequested.Clean;
        public Value<DateTime?> CurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateSetDate() => !CurrentRateSetDate.Clean;
        public Value<string> CurrentRateSheetID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateSheetID() => !CurrentRateSheetID.Clean;
        public Value<decimal?> CurrentRateTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateTotalAdjustment() => !CurrentRateTotalAdjustment.Clean;
        public Value<DateTime?> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<DateTime?> DateFirstPaymentToInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateFirstPaymentToInvestor() => !DateFirstPaymentToInvestor.Clean;
        public Value<DateTime?> DateLockedWithInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLockedWithInvestor() => !DateLockedWithInvestor.Clean;
        public Value<DateTime?> DateSold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateSold() => !DateSold.Clean;
        public Value<DateTime?> DateWarehoused { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateWarehoused() => !DateWarehoused.Clean;
        public Value<int?> DaysToExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToExtend() => !DaysToExtend.Clean;
        public Value<string> DeliveryType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeliveryType() => !DeliveryType.Clean;
        public Value<decimal?> DiffAmountReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffAmountReceived() => !DiffAmountReceived.Clean;
        public Value<decimal?> DiffImpounds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffImpounds() => !DiffImpounds.Clean;
        public Value<decimal?> DiffInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffInterest() => !DiffInterest.Clean;
        public Value<decimal?> DiffPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffPremium() => !DiffPremium.Clean;
        public Value<decimal?> DiffPrinciple { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffPrinciple() => !DiffPrinciple.Clean;
        public Value<decimal?> DiffRemainingBuydownFunds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffRemainingBuydownFunds() => !DiffRemainingBuydownFunds.Clean;
        public Value<decimal?> DiffSellAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffSellAmount() => !DiffSellAmount.Clean;
        public Value<decimal?> DiffSellPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffSellPrice() => !DiffSellPrice.Clean;
        public Value<decimal?> DiffSellSideSRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffSellSideSRP() => !DiffSellSideSRP.Clean;
        public Value<decimal?> DiffSRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffSRP() => !DiffSRP.Clean;
        public Value<decimal?> DiffSRPAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffSRPAmount() => !DiffSRPAmount.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator1() => !EmploymentBorrowerSelfEmployedIndicator1.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator10() => !EmploymentBorrowerSelfEmployedIndicator10.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator11() => !EmploymentBorrowerSelfEmployedIndicator11.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator12() => !EmploymentBorrowerSelfEmployedIndicator12.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator2() => !EmploymentBorrowerSelfEmployedIndicator2.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator3() => !EmploymentBorrowerSelfEmployedIndicator3.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator4() => !EmploymentBorrowerSelfEmployedIndicator4.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator5() => !EmploymentBorrowerSelfEmployedIndicator5.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator6() => !EmploymentBorrowerSelfEmployedIndicator6.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator7() => !EmploymentBorrowerSelfEmployedIndicator7.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator8() => !EmploymentBorrowerSelfEmployedIndicator8.Clean;
        public Value<bool?> EmploymentBorrowerSelfEmployedIndicator9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmploymentBorrowerSelfEmployedIndicator9() => !EmploymentBorrowerSelfEmployedIndicator9.Clean;
        public Value<decimal?> ExpectedAmountReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedAmountReceived() => !ExpectedAmountReceived.Clean;
        public Value<decimal?> ExpectedImpounds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedImpounds() => !ExpectedImpounds.Clean;
        public Value<decimal?> ExpectedInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedInterest() => !ExpectedInterest.Clean;
        public Value<decimal?> ExpectedPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedPremium() => !ExpectedPremium.Clean;
        public Value<decimal?> ExpectedPrinciple { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedPrinciple() => !ExpectedPrinciple.Clean;
        public Value<decimal?> ExpectedRemainingBuydownFunds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedRemainingBuydownFunds() => !ExpectedRemainingBuydownFunds.Clean;
        public Value<decimal?> ExpectedSRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedSRP() => !ExpectedSRP.Clean;
        public Value<string> ExtensionRequestPending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExtensionRequestPending() => !ExtensionRequestPending.Clean;
        public Value<int?> ExtensionSequenceNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExtensionSequenceNumber() => !ExtensionSequenceNumber.Clean;
        public Value<decimal?> FHAUpfrontMIPremiumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAUpfrontMIPremiumPercent() => !FHAUpfrontMIPremiumPercent.Clean;
        public Value<int?> FinancedNumberOfUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedNumberOfUnits() => !FinancedNumberOfUnits.Clean;
        public Value<string> FirstPaymenTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstPaymenTo() => !FirstPaymenTo.Clean;
        public Value<decimal?> FirstSubordinateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubordinateAmount() => !FirstSubordinateAmount.Clean;
        public Value<bool?> FirstTimeHomebuyersIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTimeHomebuyersIndicator() => !FirstTimeHomebuyersIndicator.Clean;
        public Value<string> FNMProductPlanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFNMProductPlanIdentifier() => !FNMProductPlanIdentifier.Clean;
        public Value<decimal?> FundingAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingAmount() => !FundingAmount.Clean;
        public Value<decimal?> GainLossPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGainLossPercentage() => !GainLossPercentage.Clean;
        public Value<decimal?> GainLossPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGainLossPrice() => !GainLossPrice.Clean;
        public Value<decimal?> GainLossTotalBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGainLossTotalBuyPrice() => !GainLossTotalBuyPrice.Clean;
        public Value<decimal?> GPMRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGPMRate() => !GPMRate.Clean;
        public Value<int?> GPMYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGPMYears() => !GPMYears.Clean;
        public Value<string> GSEPropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEPropertyType() => !GSEPropertyType.Clean;
        public Value<string> Hedging { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHedging() => !Hedging.Clean;
        public Value<string> HELOCActualBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHELOCActualBalance() => !HELOCActualBalance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> Impounds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpounds() => !Impounds.Clean;
        public Value<string> ImpoundType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundType() => !ImpoundType.Clean;
        public Value<string> ImpoundWavied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundWavied() => !ImpoundWavied.Clean;
        public Value<decimal?> Interest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterest() => !Interest.Clean;
        public Value<string> InvestorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorAddress() => !InvestorAddress.Clean;
        public Value<string> InvestorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCity() => !InvestorCity.Clean;
        public Value<string> InvestorCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCommitment() => !InvestorCommitment.Clean;
        public Value<string> InvestorContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorContact() => !InvestorContact.Clean;
        public Value<DateTime?> InvestorDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorDeliveryDate() => !InvestorDeliveryDate.Clean;
        public Value<string> InvestorEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorEmail() => !InvestorEmail.Clean;
        public Value<string> InvestorLoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLoanNumber() => !InvestorLoanNumber.Clean;
        public Value<string> InvestorLockType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLockType() => !InvestorLockType.Clean;
        public Value<string> InvestorMERSNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorMERSNumber() => !InvestorMERSNumber.Clean;
        public Value<string> InvestorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName() => !InvestorName.Clean;
        public Value<string> InvestorPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorPhone() => !InvestorPhone.Clean;
        public Value<string> InvestorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorPostalCode() => !InvestorPostalCode.Clean;
        public Value<string> InvestorProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorProgramCode() => !InvestorProgramCode.Clean;
        public Value<string> InvestorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorState() => !InvestorState.Clean;
        public Value<DateTime?> InvestorTargetDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorTargetDeliveryDate() => !InvestorTargetDeliveryDate.Clean;
        public Value<string> InvestorTemplateName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorTemplateName() => !InvestorTemplateName.Clean;
        public Value<string> InvestorWebsite { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorWebsite() => !InvestorWebsite.Clean;
        public Value<string> IsCancelled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsCancelled() => !IsCancelled.Clean;
        public Value<bool?> IsDeliveryType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDeliveryType() => !IsDeliveryType.Clean;
        public Value<bool?> LenderPaidMortgageInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidMortgageInsuranceIndicator() => !LenderPaidMortgageInsuranceIndicator.Clean;
        public Value<string> LienPriorityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienPriorityType() => !LienPriorityType.Clean;
        public Value<int?> LoanAmortizationTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationTermMonths() => !LoanAmortizationTermMonths.Clean;
        public Value<string> LoanAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationType() => !LoanAmortizationType.Clean;
        public Value<string> LoanDocumentationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDocumentationType() => !LoanDocumentationType.Clean;
        public Value<bool?> LoanFor203K { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFor203K() => !LoanFor203K.Clean;
        public Value<string> LoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgram() => !LoanProgram.Clean;
        public Value<string> LoanProgramFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgramFile() => !LoanProgramFile.Clean;
        public Value<DateTime?> LoanScheduledClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanScheduledClosingDate() => !LoanScheduledClosingDate.Clean;
        public Value<bool?> LockField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockField() => !LockField.Clean;
        public Value<List<PriceAdjustment>> LockRequestAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockRequestAdjustments() => !LockRequestAdjustments.Clean;
        public Value<List<LockRequestBorrower>> LockRequestBorrowers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockRequestBorrowers() => !LockRequestBorrowers.Clean;
        public Value<string> LockRequestLoanPurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockRequestLoanPurposeType() => !LockRequestLoanPurposeType.Clean;
        public Value<decimal?> LTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLTV() => !LTV.Clean;
        public Value<string> MinFICO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinFICO() => !MinFICO.Clean;
        public Value<string> MinFICO2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinFICO2() => !MinFICO2.Clean;
        public Value<decimal?> MIPPaidInCash { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPPaidInCash() => !MIPPaidInCash.Clean;
        public Value<string> MortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageType() => !MortgageType.Clean;
        public Value<decimal?> NetSellAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetSellAmount() => !NetSellAmount.Clean;
        public Value<decimal?> NetSellPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetSellPrice() => !NetSellPrice.Clean;
        public Value<DateTime?> NextPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentDate() => !NextPaymentDate.Clean;
        public Value<bool?> NoClosingCostOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoClosingCostOption() => !NoClosingCostOption.Clean;
        public Value<string> ONRPLock { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeONRPLock() => !ONRPLock.Clean;
        public Value<string> OtherAmortizationTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmortizationTypeDescription() => !OtherAmortizationTypeDescription.Clean;
        public Value<decimal?> OtherSubordinateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherSubordinateAmount() => !OtherSubordinateAmount.Clean;
        public Value<string> PenaltyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePenaltyTerm() => !PenaltyTerm.Clean;
        public Value<string> PerDiemInterestRoundingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerDiemInterestRoundingType() => !PerDiemInterestRoundingType.Clean;
        public Value<string> PlanCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCode() => !PlanCode.Clean;
        public Value<decimal?> Premium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePremium() => !Premium.Clean;
        public Value<string> PrepayPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepayPenalty() => !PrepayPenalty.Clean;
        public Value<decimal?> PriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceAdjustment() => !PriceAdjustment.Clean;
        public Value<List<PriceAdjustment>> PriceAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceAdjustments() => !PriceAdjustments.Clean;
        public Value<string> PricingHistoryData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePricingHistoryData() => !PricingHistoryData.Clean;
        public Value<string> PricingUpdated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePricingUpdated() => !PricingUpdated.Clean;
        public Value<decimal?> Principle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrinciple() => !Principle.Clean;
        public Value<decimal?> ProfitMarginAdjustedBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProfitMarginAdjustedBuyPrice() => !ProfitMarginAdjustedBuyPrice.Clean;
        public Value<int?> PropertyAppraisedValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAppraisedValueAmount() => !PropertyAppraisedValueAmount.Clean;
        public Value<int?> PropertyEstimatedValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyEstimatedValueAmount() => !PropertyEstimatedValueAmount.Clean;
        public Value<string> PropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !PropertyUsageType.Clean;
        public Value<int?> PurchaseAdviceNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseAdviceNumberOfDays() => !PurchaseAdviceNumberOfDays.Clean;
        public Value<List<PurchaseAdvicePayout>> PurchaseAdvicePayouts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseAdvicePayouts() => !PurchaseAdvicePayouts.Clean;
        public Value<decimal?> PurchasePriceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceAmount() => !PurchasePriceAmount.Clean;
        public Value<string> RateRequestStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRequestStatus() => !RateRequestStatus.Clean;
        public Value<string> RateStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateStatus() => !RateStatus.Clean;
        public Value<string> ReasonforBranchApproval { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonforBranchApproval() => !ReasonforBranchApproval.Clean;
        public Value<string> ReasonforCorporateApproval { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonforCorporateApproval() => !ReasonforCorporateApproval.Clean;
        public Value<decimal?> ReconciledDiff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReconciledDiff() => !ReconciledDiff.Clean;
        public Value<string> ReLockRequestPending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReLockRequestPending() => !ReLockRequestPending.Clean;
        public Value<decimal?> RemainingBuydownFunds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingBuydownFunds() => !RemainingBuydownFunds.Clean;
        public Value<string> RequestComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestComments() => !RequestComments.Clean;
        public Value<DateTime?> RequestCurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestCurrentRateSetDate() => !RequestCurrentRateSetDate.Clean;
        public Value<int?> RequestDaystoExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestDaystoExtend() => !RequestDaystoExtend.Clean;
        public Value<DateTime?> RequestExtendedLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestExtendedLockExpires() => !RequestExtendedLockExpires.Clean;
        public Value<string> RequestFullfilledDateTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestFullfilledDateTime() => !RequestFullfilledDateTime.Clean;
        public Value<string> RequestImpoundType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestImpoundType() => !RequestImpoundType.Clean;
        public Value<string> RequestImpoundWavied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestImpoundWavied() => !RequestImpoundWavied.Clean;
        public Value<string> RequestLockCancellationComment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockCancellationComment() => !RequestLockCancellationComment.Clean;
        public Value<DateTime?> RequestLockCancellationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockCancellationDate() => !RequestLockCancellationDate.Clean;
        public Value<DateTime?> RequestLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockDate() => !RequestLockDate.Clean;
        public Value<DateTime?> RequestLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockExpires() => !RequestLockExpires.Clean;
        public Value<string> RequestLockExtendComment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockExtendComment() => !RequestLockExtendComment.Clean;
        public Value<decimal?> RequestLockExtendPriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockExtendPriceAdjustment() => !RequestLockExtendPriceAdjustment.Clean;
        public Value<string> RequestLockType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestLockType() => !RequestLockType.Clean;
        public Value<decimal?> RequestMarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestMarginRate() => !RequestMarginRate.Clean;
        public Value<decimal?> RequestMarginRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestMarginRateRequested() => !RequestMarginRateRequested.Clean;
        public Value<decimal?> RequestMarginSRPPaidOut { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestMarginSRPPaidOut() => !RequestMarginSRPPaidOut.Clean;
        public Value<decimal?> RequestMarginTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestMarginTotalAdjustment() => !RequestMarginTotalAdjustment.Clean;
        public Value<int?> RequestNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestNumberOfDays() => !RequestNumberOfDays.Clean;
        public Value<bool?> RequestOnrpEligible { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestOnrpEligible() => !RequestOnrpEligible.Clean;
        public Value<DateTime?> RequestOnrpLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestOnrpLockDate() => !RequestOnrpLockDate.Clean;
        public Value<string> RequestOnrpLockTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestOnrpLockTime() => !RequestOnrpLockTime.Clean;
        public Value<DateTime?> RequestOriginalLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestOriginalLockExpires() => !RequestOriginalLockExpires.Clean;
        public Value<string> RequestPenaltyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPenaltyTerm() => !RequestPenaltyTerm.Clean;
        public Value<string> RequestPending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPending() => !RequestPending.Clean;
        public Value<string> RequestPrepayPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPrepayPenalty() => !RequestPrepayPenalty.Clean;
        public Value<decimal?> RequestPriceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPriceRate() => !RequestPriceRate.Clean;
        public Value<decimal?> RequestPriceRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPriceRateRequested() => !RequestPriceRateRequested.Clean;
        public Value<decimal?> RequestPriceTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestPriceTotalAdjustment() => !RequestPriceTotalAdjustment.Clean;
        public Value<decimal?> RequestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestRate() => !RequestRate.Clean;
        public Value<decimal?> RequestRateRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestRateRequested() => !RequestRateRequested.Clean;
        public Value<string> RequestRateSheetID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestRateSheetID() => !RequestRateSheetID.Clean;
        public Value<decimal?> RequestRateTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestRateTotalAdjustment() => !RequestRateTotalAdjustment.Clean;
        public Value<decimal?> RequestStartingAdjPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestStartingAdjPoint() => !RequestStartingAdjPoint.Clean;
        public Value<decimal?> RequestStartingAdjRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestStartingAdjRate() => !RequestStartingAdjRate.Clean;
        public Value<string> RequestType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestType() => !RequestType.Clean;
        public Value<decimal?> RequestUnDiscountedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestUnDiscountedRate() => !RequestUnDiscountedRate.Clean;
        public Value<bool?> RoundToNearest50 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundToNearest50() => !RoundToNearest50.Clean;
        public Value<decimal?> SecondSubordinateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondSubordinateAmount() => !SecondSubordinateAmount.Clean;
        public Value<decimal?> SellerPaidMIPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPaidMIPremium() => !SellerPaidMIPremium.Clean;
        public Value<List<PriceAdjustment>> SellSideAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideAdjustments() => !SellSideAdjustments.Clean;
        public Value<string> SellSideComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideComments() => !SellSideComments.Clean;
        public Value<string> SellSideCommitmentContractNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideCommitmentContractNumber() => !SellSideCommitmentContractNumber.Clean;
        public Value<DateTime?> SellSideCommitmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideCommitmentDate() => !SellSideCommitmentDate.Clean;
        public Value<DateTime?> SellSideCurrentRateSetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideCurrentRateSetDate() => !SellSideCurrentRateSetDate.Clean;
        public Value<int?> SellSideDaystoExtend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDaystoExtend() => !SellSideDaystoExtend.Clean;
        public Value<decimal?> SellSideDiscountYSP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideDiscountYSP() => !SellSideDiscountYSP.Clean;
        public Value<DateTime?> SellSideExtendedLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideExtendedLockExpires() => !SellSideExtendedLockExpires.Clean;
        public Value<decimal?> SellSideGuaranteeFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideGuaranteeFee() => !SellSideGuaranteeFee.Clean;
        public Value<decimal?> SellSideGuarantyBaseFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideGuarantyBaseFee() => !SellSideGuarantyBaseFee.Clean;
        public Value<string> SellSideInvestorStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideInvestorStatus() => !SellSideInvestorStatus.Clean;
        public Value<DateTime?> SellSideInvestorStatusDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideInvestorStatusDate() => !SellSideInvestorStatusDate.Clean;
        public Value<string> SellSideInvestorTradeNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideInvestorTradeNumber() => !SellSideInvestorTradeNumber.Clean;
        public Value<string> SellSideLoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideLoanProgram() => !SellSideLoanProgram.Clean;
        public Value<DateTime?> SellSideLockDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideLockDate() => !SellSideLockDate.Clean;
        public Value<DateTime?> SellSideLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideLockExpires() => !SellSideLockExpires.Clean;
        public Value<decimal?> SellSideLockExtendPriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideLockExtendPriceAdjustment() => !SellSideLockExtendPriceAdjustment.Clean;
        public Value<decimal?> SellSideMarginNetSellRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideMarginNetSellRate() => !SellSideMarginNetSellRate.Clean;
        public Value<decimal?> SellSideMarginRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideMarginRate() => !SellSideMarginRate.Clean;
        public Value<decimal?> SellSideMarginTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideMarginTotalAdjustment() => !SellSideMarginTotalAdjustment.Clean;
        public Value<string> SellSideMasterContractNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideMasterContractNumber() => !SellSideMasterContractNumber.Clean;
        public Value<decimal?> SellSideMSRValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideMSRValue() => !SellSideMSRValue.Clean;
        public Value<decimal?> SellSideNetSellPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNetSellPrice() => !SellSideNetSellPrice.Clean;
        public Value<decimal?> SellSideNetSellRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNetSellRate() => !SellSideNetSellRate.Clean;
        public Value<int?> SellSideNumberOfDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideNumberOfDays() => !SellSideNumberOfDays.Clean;
        public Value<DateTime?> SellSideOriginalLockExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideOriginalLockExpires() => !SellSideOriginalLockExpires.Clean;
        public Value<string> SellSidePoolID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSidePoolID() => !SellSidePoolID.Clean;
        public Value<string> SellSidePoolNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSidePoolNumber() => !SellSidePoolNumber.Clean;
        public Value<decimal?> SellSidePriceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSidePriceRate() => !SellSidePriceRate.Clean;
        public Value<decimal?> SellSidePriceTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSidePriceTotalAdjustment() => !SellSidePriceTotalAdjustment.Clean;
        public Value<string> SellSideProductName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideProductName() => !SellSideProductName.Clean;
        public Value<decimal?> SellSideRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideRate() => !SellSideRate.Clean;
        public Value<string> SellSideRateSheetID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideRateSheetID() => !SellSideRateSheetID.Clean;
        public Value<decimal?> SellSideRateTotalAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideRateTotalAdjustment() => !SellSideRateTotalAdjustment.Clean;
        public Value<string> SellSideRequestedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideRequestedBy() => !SellSideRequestedBy.Clean;
        public Value<string> SellSideServicer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideServicer() => !SellSideServicer.Clean;
        public Value<decimal?> SellSideServicingFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideServicingFee() => !SellSideServicingFee.Clean;
        public Value<string> SellSideServicingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideServicingType() => !SellSideServicingType.Clean;
        public Value<decimal?> SellSideSRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideSRP() => !SellSideSRP.Clean;
        public Value<decimal?> SellSideSRPPaidOut { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideSRPPaidOut() => !SellSideSRPPaidOut.Clean;
        public Value<string> SellSideTradeGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideTradeGuid() => !SellSideTradeGuid.Clean;
        public Value<string> SellSideTradeMgmtPrevConfirmedLockGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideTradeMgmtPrevConfirmedLockGuid() => !SellSideTradeMgmtPrevConfirmedLockGuid.Clean;
        public Value<string> SellSideTradeNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellSideTradeNumber() => !SellSideTradeNumber.Clean;
        public Value<bool?> ServicingReleaseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingReleaseIndicator() => !ServicingReleaseIndicator.Clean;
        public Value<decimal?> SRP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSRP() => !SRP.Clean;
        public Value<decimal?> SRPAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSRPAmount() => !SRPAmount.Clean;
        public Value<string> SubjectPropertyCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyCity() => !SubjectPropertyCity.Clean;
        public Value<bool?> SubjectPropertyCondotelIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyCondotelIndicator() => !SubjectPropertyCondotelIndicator.Clean;
        public Value<string> SubjectPropertyCounty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyCounty() => !SubjectPropertyCounty.Clean;
        public Value<bool?> SubjectPropertyNonWarrantableProjectIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyNonWarrantableProjectIndicator() => !SubjectPropertyNonWarrantableProjectIndicator.Clean;
        public Value<string> SubjectPropertyPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyPostalCode() => !SubjectPropertyPostalCode.Clean;
        public Value<string> SubjectPropertyState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyState() => !SubjectPropertyState.Clean;
        public Value<string> SubjectPropertyStreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyStreetAddress() => !SubjectPropertyStreetAddress.Clean;
        public Value<string> TimeLockedWithInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimeLockedWithInvestor() => !TimeLockedWithInvestor.Clean;
        public Value<decimal?> TotalBuyPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBuyPrice() => !TotalBuyPrice.Clean;
        public Value<decimal?> TotalForLesserOfSumAsIs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForLesserOfSumAsIs() => !TotalForLesserOfSumAsIs.Clean;
        public Value<decimal?> TotalPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrice() => !TotalPrice.Clean;
        public Value<decimal?> TotalSubordinateFinancing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSubordinateFinancing() => !TotalSubordinateFinancing.Clean;
        public Value<bool?> TwelveMonthMortgageRentalHistoryIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTwelveMonthMortgageRentalHistoryIndicator() => !TwelveMonthMortgageRentalHistoryIndicator.Clean;
        public Value<string> Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeType() => !Type.Clean;
        public Value<bool?> UsePoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsePoint() => !UsePoint.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualSellAmount.Clean
                    && ActualSellPrice.Clean
                    && ActualSellSideSRP.Clean
                    && ActualSRPAmount.Clean
                    && AmountDue.Clean
                    && AmountDueTo.Clean
                    && AmountPaid.Clean
                    && AmountPaidTo.Clean
                    && AmountReceived.Clean
                    && BalloonLoanMaturityTermMonths.Clean
                    && BaseLoanAmount.Clean
                    && BorrowerRequestedLoanAmount.Clean
                    && BranchApprovalDate.Clean
                    && BranchApprovedby.Clean
                    && BranchPrice.Clean
                    && BuySideAdjustments.Clean
                    && BuySideComments.Clean
                    && BuySideCommitmentDate.Clean
                    && BuySideCommitmentNumber.Clean
                    && BuySideCommitmentType.Clean
                    && BuySideCurrentRateSetDate.Clean
                    && BuySideDaystoExtend.Clean
                    && BuySideDeliveryExpirationDate.Clean
                    && BuySideDeliveryType.Clean
                    && BuySideExpirationDate.Clean
                    && BuySideExtendedLockExpires.Clean
                    && BuySideLockDate.Clean
                    && BuySideLockExpires.Clean
                    && BuySideLockExtendPriceAdjustment.Clean
                    && BuySideMarginNetBuyRate.Clean
                    && BuySideMarginRate.Clean
                    && BuySideMarginTotalAdjustment.Clean
                    && BuySideMasterCommitmentNumber.Clean
                    && BuySideNumberOfDays.Clean
                    && BuySideOnrpEligible.Clean
                    && BuySideOnrpLockDate.Clean
                    && BuySideOnrpLockTime.Clean
                    && BuySideOrgID.Clean
                    && BuySideOriginalLockExpires.Clean
                    && BuySidePriceNetBuyPrice.Clean
                    && BuySidePriceRate.Clean
                    && BuySidePriceTotalAdjustment.Clean
                    && BuySideRate.Clean
                    && BuySideRateNetBuyRate.Clean
                    && BuySideRateSheetID.Clean
                    && BuySideRateTotalAdjustment.Clean
                    && BuySideRequestedBy.Clean
                    && BuySideSRPPaidOut.Clean
                    && BuySideStartingAdjPoint.Clean
                    && BuySideStartingAdjPrice.Clean
                    && BuySideStartingAdjRate.Clean
                    && BuySideTPOID.Clean
                    && BuySideTPOName.Clean
                    && BuySideTradeGuid.Clean
                    && BuySideTradeNumber.Clean
                    && BuySideUnDiscountedRate.Clean
                    && CancellationRequestPending.Clean
                    && CombinedLTV.Clean
                    && Comments.Clean
                    && Commitment.Clean
                    && CompGainLossPercentage.Clean
                    && CompGainLossPrice.Clean
                    && CompGainLossTotalBuyPrice.Clean
                    && CompGainLossTotalCompPrice.Clean
                    && CompInvestorAddress.Clean
                    && CompInvestorCity.Clean
                    && CompInvestorCommitment.Clean
                    && CompInvestorContact.Clean
                    && CompInvestorEmail.Clean
                    && CompInvestorLockType.Clean
                    && CompInvestorName.Clean
                    && CompInvestorPhone.Clean
                    && CompInvestorPostalCode.Clean
                    && CompInvestorProgramCode.Clean
                    && CompInvestorState.Clean
                    && CompInvestorTemplateName.Clean
                    && CompInvestorWebsite.Clean
                    && CompSideAdjustments.Clean
                    && CompSideComments.Clean
                    && CompSideComparisonedBy.Clean
                    && CompSideCurrentRateSetDate.Clean
                    && CompSideDaystoExtend.Clean
                    && CompSideDiscountYSP.Clean
                    && CompSideExtendedLockExpires.Clean
                    && CompSideInvestorStatus.Clean
                    && CompSideInvestorStatusDate.Clean
                    && CompSideInvestorTradeNumber.Clean
                    && CompSideLoanProgram.Clean
                    && CompSideLockDate.Clean
                    && CompSideLockExpires.Clean
                    && CompSideLockExtendPriceAdjustment.Clean
                    && CompSideMarginNetCompRate.Clean
                    && CompSideMarginRate.Clean
                    && CompSideMarginTotalAdjustment.Clean
                    && CompSideMasterContractNumber.Clean
                    && CompSideNetCompPrice.Clean
                    && CompSideNetCompRate.Clean
                    && CompSideNumberOfDays.Clean
                    && CompSideOriginalLockExpires.Clean
                    && CompSidePriceRate.Clean
                    && CompSidePriceTotalAdjustment.Clean
                    && CompSideRate.Clean
                    && CompSideRateSheetID.Clean
                    && CompSideRateTotalAdjustment.Clean
                    && CompSideRequestedBy.Clean
                    && CompSideServicingType.Clean
                    && CompSideSRPPaidOut.Clean
                    && CompSideTradeGuid.Clean
                    && CompSideTradeNumber.Clean
                    && ConfirmedBy.Clean
                    && ConfirmedDate.Clean
                    && CorporateApprovalDate.Clean
                    && CorporateApprovedby.Clean
                    && CorporatePrice.Clean
                    && CorrespondentAdditionalLineAmount1.Clean
                    && CorrespondentAdditionalLineAmount10.Clean
                    && CorrespondentAdditionalLineAmount11.Clean
                    && CorrespondentAdditionalLineAmount12.Clean
                    && CorrespondentAdditionalLineAmount13.Clean
                    && CorrespondentAdditionalLineAmount2.Clean
                    && CorrespondentAdditionalLineAmount3.Clean
                    && CorrespondentAdditionalLineAmount4.Clean
                    && CorrespondentAdditionalLineAmount5.Clean
                    && CorrespondentAdditionalLineAmount6.Clean
                    && CorrespondentAdditionalLineAmount7.Clean
                    && CorrespondentAdditionalLineAmount8.Clean
                    && CorrespondentAdditionalLineAmount9.Clean
                    && CorrespondentAdditionalLineDescription1.Clean
                    && CorrespondentAdditionalLineDescription10.Clean
                    && CorrespondentAdditionalLineDescription11.Clean
                    && CorrespondentAdditionalLineDescription12.Clean
                    && CorrespondentAdditionalLineDescription2.Clean
                    && CorrespondentAdditionalLineDescription3.Clean
                    && CorrespondentAdditionalLineDescription4.Clean
                    && CorrespondentAdditionalLineDescription5.Clean
                    && CorrespondentAdditionalLineDescription6.Clean
                    && CorrespondentAdditionalLineDescription7.Clean
                    && CorrespondentAdditionalLineDescription8.Clean
                    && CorrespondentAdditionalLineDescription9.Clean
                    && CorrespondentAdditionalLineTotalAmount.Clean
                    && CorrespondentAdjusterAmount1.Clean
                    && CorrespondentAdjusterAmount2.Clean
                    && CorrespondentAdjusterAmount3.Clean
                    && CorrespondentAdjusterDescription1.Clean
                    && CorrespondentAdjusterDescription2.Clean
                    && CorrespondentAdjusterDescription3.Clean
                    && CorrespondentConfirmedBy.Clean
                    && CorrespondentConfirmedDate.Clean
                    && CorrespondentCurrentImpounds.Clean
                    && CorrespondentCurrentPrincipal.Clean
                    && CorrespondentDate.Clean
                    && CorrespondentFinalBuyAmount.Clean
                    && CorrespondentFinalBuyPrice.Clean
                    && CorrespondentFirstPaymentDate.Clean
                    && CorrespondentImpounds.Clean
                    && CorrespondentInterest.Clean
                    && CorrespondentInterestDays.Clean
                    && CorrespondentLateFeeAmount.Clean
                    && CorrespondentLateFeePriceAdjustment.Clean
                    && CorrespondentPaidToDate.Clean
                    && CorrespondentPurchasedPrincipal.Clean
                    && CorrespondentReconcilationComments.Clean
                    && CorrespondentRemainingBuydownAmount.Clean
                    && CorrespondentSRPAmount.Clean
                    && CorrespondentWarehouseBankABANum.Clean
                    && CorrespondentWarehouseBankAcctNum.Clean
                    && CorrespondentWarehouseBankAddress.Clean
                    && CorrespondentWarehouseBankAddress1.Clean
                    && CorrespondentWarehouseBankBaileeExpirationDate.Clean
                    && CorrespondentWarehouseBankBaileeLetterReceivedIndicator.Clean
                    && CorrespondentWarehouseBankBaileeLetterReqIndicator.Clean
                    && CorrespondentWarehouseBankCity.Clean
                    && CorrespondentWarehouseBankContactEmail.Clean
                    && CorrespondentWarehouseBankContactFax.Clean
                    && CorrespondentWarehouseBankContactName.Clean
                    && CorrespondentWarehouseBankContactPhone.Clean
                    && CorrespondentWarehouseBankDescription.Clean
                    && CorrespondentWarehouseBankId.Clean
                    && CorrespondentWarehouseBankName.Clean
                    && CorrespondentWarehouseBankNotes.Clean
                    && CorrespondentWarehouseBankSelfFunderIndicator.Clean
                    && CorrespondentWarehouseBankState.Clean
                    && CorrespondentWarehouseBankTriPartyContractIndicator.Clean
                    && CorrespondentWarehouseBankUseDefaultContactIndicator.Clean
                    && CorrespondentWarehouseBankWireInstructionsReceivedIndicator.Clean
                    && CorrespondentWarehouseBankZip.Clean
                    && CreditScoreToUse.Clean
                    && CumulatedDaystoExtend.Clean
                    && CurrentAdjustments.Clean
                    && CurrentComments.Clean
                    && CurrentLockDate.Clean
                    && CurrentLockExpires.Clean
                    && CurrentMarginRate.Clean
                    && CurrentMarginRateRequested.Clean
                    && CurrentMarginTotalAdjustment.Clean
                    && CurrentNumberOfDays.Clean
                    && CurrentPriceRate.Clean
                    && CurrentPriceRateRequested.Clean
                    && CurrentPriceTotalAdjustment.Clean
                    && CurrentRate.Clean
                    && CurrentRateRequested.Clean
                    && CurrentRateSetDate.Clean
                    && CurrentRateSheetID.Clean
                    && CurrentRateTotalAdjustment.Clean
                    && Date.Clean
                    && DateFirstPaymentToInvestor.Clean
                    && DateLockedWithInvestor.Clean
                    && DateSold.Clean
                    && DateWarehoused.Clean
                    && DaysToExtend.Clean
                    && DeliveryType.Clean
                    && DiffAmountReceived.Clean
                    && DiffImpounds.Clean
                    && DiffInterest.Clean
                    && DiffPremium.Clean
                    && DiffPrinciple.Clean
                    && DiffRemainingBuydownFunds.Clean
                    && DiffSellAmount.Clean
                    && DiffSellPrice.Clean
                    && DiffSellSideSRP.Clean
                    && DiffSRP.Clean
                    && DiffSRPAmount.Clean
                    && EmploymentBorrowerSelfEmployedIndicator1.Clean
                    && EmploymentBorrowerSelfEmployedIndicator10.Clean
                    && EmploymentBorrowerSelfEmployedIndicator11.Clean
                    && EmploymentBorrowerSelfEmployedIndicator12.Clean
                    && EmploymentBorrowerSelfEmployedIndicator2.Clean
                    && EmploymentBorrowerSelfEmployedIndicator3.Clean
                    && EmploymentBorrowerSelfEmployedIndicator4.Clean
                    && EmploymentBorrowerSelfEmployedIndicator5.Clean
                    && EmploymentBorrowerSelfEmployedIndicator6.Clean
                    && EmploymentBorrowerSelfEmployedIndicator7.Clean
                    && EmploymentBorrowerSelfEmployedIndicator8.Clean
                    && EmploymentBorrowerSelfEmployedIndicator9.Clean
                    && ExpectedAmountReceived.Clean
                    && ExpectedImpounds.Clean
                    && ExpectedInterest.Clean
                    && ExpectedPremium.Clean
                    && ExpectedPrinciple.Clean
                    && ExpectedRemainingBuydownFunds.Clean
                    && ExpectedSRP.Clean
                    && ExtensionRequestPending.Clean
                    && ExtensionSequenceNumber.Clean
                    && FHAUpfrontMIPremiumPercent.Clean
                    && FinancedNumberOfUnits.Clean
                    && FirstPaymenTo.Clean
                    && FirstSubordinateAmount.Clean
                    && FirstTimeHomebuyersIndicator.Clean
                    && FNMProductPlanIdentifier.Clean
                    && FundingAmount.Clean
                    && GainLossPercentage.Clean
                    && GainLossPrice.Clean
                    && GainLossTotalBuyPrice.Clean
                    && GPMRate.Clean
                    && GPMYears.Clean
                    && GSEPropertyType.Clean
                    && Hedging.Clean
                    && HELOCActualBalance.Clean
                    && Id.Clean
                    && Impounds.Clean
                    && ImpoundType.Clean
                    && ImpoundWavied.Clean
                    && Interest.Clean
                    && InvestorAddress.Clean
                    && InvestorCity.Clean
                    && InvestorCommitment.Clean
                    && InvestorContact.Clean
                    && InvestorDeliveryDate.Clean
                    && InvestorEmail.Clean
                    && InvestorLoanNumber.Clean
                    && InvestorLockType.Clean
                    && InvestorMERSNumber.Clean
                    && InvestorName.Clean
                    && InvestorPhone.Clean
                    && InvestorPostalCode.Clean
                    && InvestorProgramCode.Clean
                    && InvestorState.Clean
                    && InvestorTargetDeliveryDate.Clean
                    && InvestorTemplateName.Clean
                    && InvestorWebsite.Clean
                    && IsCancelled.Clean
                    && IsDeliveryType.Clean
                    && LenderPaidMortgageInsuranceIndicator.Clean
                    && LienPriorityType.Clean
                    && LoanAmortizationTermMonths.Clean
                    && LoanAmortizationType.Clean
                    && LoanDocumentationType.Clean
                    && LoanFor203K.Clean
                    && LoanProgram.Clean
                    && LoanProgramFile.Clean
                    && LoanScheduledClosingDate.Clean
                    && LockField.Clean
                    && LockRequestAdjustments.Clean
                    && LockRequestBorrowers.Clean
                    && LockRequestLoanPurposeType.Clean
                    && LTV.Clean
                    && MinFICO.Clean
                    && MinFICO2.Clean
                    && MIPPaidInCash.Clean
                    && MortgageType.Clean
                    && NetSellAmount.Clean
                    && NetSellPrice.Clean
                    && NextPaymentDate.Clean
                    && NoClosingCostOption.Clean
                    && ONRPLock.Clean
                    && OtherAmortizationTypeDescription.Clean
                    && OtherSubordinateAmount.Clean
                    && PenaltyTerm.Clean
                    && PerDiemInterestRoundingType.Clean
                    && PlanCode.Clean
                    && Premium.Clean
                    && PrepayPenalty.Clean
                    && PriceAdjustment.Clean
                    && PriceAdjustments.Clean
                    && PricingHistoryData.Clean
                    && PricingUpdated.Clean
                    && Principle.Clean
                    && ProfitMarginAdjustedBuyPrice.Clean
                    && PropertyAppraisedValueAmount.Clean
                    && PropertyEstimatedValueAmount.Clean
                    && PropertyUsageType.Clean
                    && PurchaseAdviceNumberOfDays.Clean
                    && PurchaseAdvicePayouts.Clean
                    && PurchasePriceAmount.Clean
                    && RateRequestStatus.Clean
                    && RateStatus.Clean
                    && ReasonforBranchApproval.Clean
                    && ReasonforCorporateApproval.Clean
                    && ReconciledDiff.Clean
                    && ReLockRequestPending.Clean
                    && RemainingBuydownFunds.Clean
                    && RequestComments.Clean
                    && RequestCurrentRateSetDate.Clean
                    && RequestDaystoExtend.Clean
                    && RequestExtendedLockExpires.Clean
                    && RequestFullfilledDateTime.Clean
                    && RequestImpoundType.Clean
                    && RequestImpoundWavied.Clean
                    && RequestLockCancellationComment.Clean
                    && RequestLockCancellationDate.Clean
                    && RequestLockDate.Clean
                    && RequestLockExpires.Clean
                    && RequestLockExtendComment.Clean
                    && RequestLockExtendPriceAdjustment.Clean
                    && RequestLockType.Clean
                    && RequestMarginRate.Clean
                    && RequestMarginRateRequested.Clean
                    && RequestMarginSRPPaidOut.Clean
                    && RequestMarginTotalAdjustment.Clean
                    && RequestNumberOfDays.Clean
                    && RequestOnrpEligible.Clean
                    && RequestOnrpLockDate.Clean
                    && RequestOnrpLockTime.Clean
                    && RequestOriginalLockExpires.Clean
                    && RequestPenaltyTerm.Clean
                    && RequestPending.Clean
                    && RequestPrepayPenalty.Clean
                    && RequestPriceRate.Clean
                    && RequestPriceRateRequested.Clean
                    && RequestPriceTotalAdjustment.Clean
                    && RequestRate.Clean
                    && RequestRateRequested.Clean
                    && RequestRateSheetID.Clean
                    && RequestRateTotalAdjustment.Clean
                    && RequestStartingAdjPoint.Clean
                    && RequestStartingAdjRate.Clean
                    && RequestType.Clean
                    && RequestUnDiscountedRate.Clean
                    && RoundToNearest50.Clean
                    && SecondSubordinateAmount.Clean
                    && SellerPaidMIPremium.Clean
                    && SellSideAdjustments.Clean
                    && SellSideComments.Clean
                    && SellSideCommitmentContractNumber.Clean
                    && SellSideCommitmentDate.Clean
                    && SellSideCurrentRateSetDate.Clean
                    && SellSideDaystoExtend.Clean
                    && SellSideDiscountYSP.Clean
                    && SellSideExtendedLockExpires.Clean
                    && SellSideGuaranteeFee.Clean
                    && SellSideGuarantyBaseFee.Clean
                    && SellSideInvestorStatus.Clean
                    && SellSideInvestorStatusDate.Clean
                    && SellSideInvestorTradeNumber.Clean
                    && SellSideLoanProgram.Clean
                    && SellSideLockDate.Clean
                    && SellSideLockExpires.Clean
                    && SellSideLockExtendPriceAdjustment.Clean
                    && SellSideMarginNetSellRate.Clean
                    && SellSideMarginRate.Clean
                    && SellSideMarginTotalAdjustment.Clean
                    && SellSideMasterContractNumber.Clean
                    && SellSideMSRValue.Clean
                    && SellSideNetSellPrice.Clean
                    && SellSideNetSellRate.Clean
                    && SellSideNumberOfDays.Clean
                    && SellSideOriginalLockExpires.Clean
                    && SellSidePoolID.Clean
                    && SellSidePoolNumber.Clean
                    && SellSidePriceRate.Clean
                    && SellSidePriceTotalAdjustment.Clean
                    && SellSideProductName.Clean
                    && SellSideRate.Clean
                    && SellSideRateSheetID.Clean
                    && SellSideRateTotalAdjustment.Clean
                    && SellSideRequestedBy.Clean
                    && SellSideServicer.Clean
                    && SellSideServicingFee.Clean
                    && SellSideServicingType.Clean
                    && SellSideSRP.Clean
                    && SellSideSRPPaidOut.Clean
                    && SellSideTradeGuid.Clean
                    && SellSideTradeMgmtPrevConfirmedLockGuid.Clean
                    && SellSideTradeNumber.Clean
                    && ServicingReleaseIndicator.Clean
                    && SRP.Clean
                    && SRPAmount.Clean
                    && SubjectPropertyCity.Clean
                    && SubjectPropertyCondotelIndicator.Clean
                    && SubjectPropertyCounty.Clean
                    && SubjectPropertyNonWarrantableProjectIndicator.Clean
                    && SubjectPropertyPostalCode.Clean
                    && SubjectPropertyState.Clean
                    && SubjectPropertyStreetAddress.Clean
                    && TimeLockedWithInvestor.Clean
                    && TotalBuyPrice.Clean
                    && TotalForLesserOfSumAsIs.Clean
                    && TotalPrice.Clean
                    && TotalSubordinateFinancing.Clean
                    && TwelveMonthMortgageRentalHistoryIndicator.Clean
                    && Type.Clean
                    && UsePoint.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualSellAmount; v0.Clean = value; ActualSellAmount = v0;
                var v1 = ActualSellPrice; v1.Clean = value; ActualSellPrice = v1;
                var v2 = ActualSellSideSRP; v2.Clean = value; ActualSellSideSRP = v2;
                var v3 = ActualSRPAmount; v3.Clean = value; ActualSRPAmount = v3;
                var v4 = AmountDue; v4.Clean = value; AmountDue = v4;
                var v5 = AmountDueTo; v5.Clean = value; AmountDueTo = v5;
                var v6 = AmountPaid; v6.Clean = value; AmountPaid = v6;
                var v7 = AmountPaidTo; v7.Clean = value; AmountPaidTo = v7;
                var v8 = AmountReceived; v8.Clean = value; AmountReceived = v8;
                var v9 = BalloonLoanMaturityTermMonths; v9.Clean = value; BalloonLoanMaturityTermMonths = v9;
                var v10 = BaseLoanAmount; v10.Clean = value; BaseLoanAmount = v10;
                var v11 = BorrowerRequestedLoanAmount; v11.Clean = value; BorrowerRequestedLoanAmount = v11;
                var v12 = BranchApprovalDate; v12.Clean = value; BranchApprovalDate = v12;
                var v13 = BranchApprovedby; v13.Clean = value; BranchApprovedby = v13;
                var v14 = BranchPrice; v14.Clean = value; BranchPrice = v14;
                var v15 = BuySideAdjustments; v15.Clean = value; BuySideAdjustments = v15;
                var v16 = BuySideComments; v16.Clean = value; BuySideComments = v16;
                var v17 = BuySideCommitmentDate; v17.Clean = value; BuySideCommitmentDate = v17;
                var v18 = BuySideCommitmentNumber; v18.Clean = value; BuySideCommitmentNumber = v18;
                var v19 = BuySideCommitmentType; v19.Clean = value; BuySideCommitmentType = v19;
                var v20 = BuySideCurrentRateSetDate; v20.Clean = value; BuySideCurrentRateSetDate = v20;
                var v21 = BuySideDaystoExtend; v21.Clean = value; BuySideDaystoExtend = v21;
                var v22 = BuySideDeliveryExpirationDate; v22.Clean = value; BuySideDeliveryExpirationDate = v22;
                var v23 = BuySideDeliveryType; v23.Clean = value; BuySideDeliveryType = v23;
                var v24 = BuySideExpirationDate; v24.Clean = value; BuySideExpirationDate = v24;
                var v25 = BuySideExtendedLockExpires; v25.Clean = value; BuySideExtendedLockExpires = v25;
                var v26 = BuySideLockDate; v26.Clean = value; BuySideLockDate = v26;
                var v27 = BuySideLockExpires; v27.Clean = value; BuySideLockExpires = v27;
                var v28 = BuySideLockExtendPriceAdjustment; v28.Clean = value; BuySideLockExtendPriceAdjustment = v28;
                var v29 = BuySideMarginNetBuyRate; v29.Clean = value; BuySideMarginNetBuyRate = v29;
                var v30 = BuySideMarginRate; v30.Clean = value; BuySideMarginRate = v30;
                var v31 = BuySideMarginTotalAdjustment; v31.Clean = value; BuySideMarginTotalAdjustment = v31;
                var v32 = BuySideMasterCommitmentNumber; v32.Clean = value; BuySideMasterCommitmentNumber = v32;
                var v33 = BuySideNumberOfDays; v33.Clean = value; BuySideNumberOfDays = v33;
                var v34 = BuySideOnrpEligible; v34.Clean = value; BuySideOnrpEligible = v34;
                var v35 = BuySideOnrpLockDate; v35.Clean = value; BuySideOnrpLockDate = v35;
                var v36 = BuySideOnrpLockTime; v36.Clean = value; BuySideOnrpLockTime = v36;
                var v37 = BuySideOrgID; v37.Clean = value; BuySideOrgID = v37;
                var v38 = BuySideOriginalLockExpires; v38.Clean = value; BuySideOriginalLockExpires = v38;
                var v39 = BuySidePriceNetBuyPrice; v39.Clean = value; BuySidePriceNetBuyPrice = v39;
                var v40 = BuySidePriceRate; v40.Clean = value; BuySidePriceRate = v40;
                var v41 = BuySidePriceTotalAdjustment; v41.Clean = value; BuySidePriceTotalAdjustment = v41;
                var v42 = BuySideRate; v42.Clean = value; BuySideRate = v42;
                var v43 = BuySideRateNetBuyRate; v43.Clean = value; BuySideRateNetBuyRate = v43;
                var v44 = BuySideRateSheetID; v44.Clean = value; BuySideRateSheetID = v44;
                var v45 = BuySideRateTotalAdjustment; v45.Clean = value; BuySideRateTotalAdjustment = v45;
                var v46 = BuySideRequestedBy; v46.Clean = value; BuySideRequestedBy = v46;
                var v47 = BuySideSRPPaidOut; v47.Clean = value; BuySideSRPPaidOut = v47;
                var v48 = BuySideStartingAdjPoint; v48.Clean = value; BuySideStartingAdjPoint = v48;
                var v49 = BuySideStartingAdjPrice; v49.Clean = value; BuySideStartingAdjPrice = v49;
                var v50 = BuySideStartingAdjRate; v50.Clean = value; BuySideStartingAdjRate = v50;
                var v51 = BuySideTPOID; v51.Clean = value; BuySideTPOID = v51;
                var v52 = BuySideTPOName; v52.Clean = value; BuySideTPOName = v52;
                var v53 = BuySideTradeGuid; v53.Clean = value; BuySideTradeGuid = v53;
                var v54 = BuySideTradeNumber; v54.Clean = value; BuySideTradeNumber = v54;
                var v55 = BuySideUnDiscountedRate; v55.Clean = value; BuySideUnDiscountedRate = v55;
                var v56 = CancellationRequestPending; v56.Clean = value; CancellationRequestPending = v56;
                var v57 = CombinedLTV; v57.Clean = value; CombinedLTV = v57;
                var v58 = Comments; v58.Clean = value; Comments = v58;
                var v59 = Commitment; v59.Clean = value; Commitment = v59;
                var v60 = CompGainLossPercentage; v60.Clean = value; CompGainLossPercentage = v60;
                var v61 = CompGainLossPrice; v61.Clean = value; CompGainLossPrice = v61;
                var v62 = CompGainLossTotalBuyPrice; v62.Clean = value; CompGainLossTotalBuyPrice = v62;
                var v63 = CompGainLossTotalCompPrice; v63.Clean = value; CompGainLossTotalCompPrice = v63;
                var v64 = CompInvestorAddress; v64.Clean = value; CompInvestorAddress = v64;
                var v65 = CompInvestorCity; v65.Clean = value; CompInvestorCity = v65;
                var v66 = CompInvestorCommitment; v66.Clean = value; CompInvestorCommitment = v66;
                var v67 = CompInvestorContact; v67.Clean = value; CompInvestorContact = v67;
                var v68 = CompInvestorEmail; v68.Clean = value; CompInvestorEmail = v68;
                var v69 = CompInvestorLockType; v69.Clean = value; CompInvestorLockType = v69;
                var v70 = CompInvestorName; v70.Clean = value; CompInvestorName = v70;
                var v71 = CompInvestorPhone; v71.Clean = value; CompInvestorPhone = v71;
                var v72 = CompInvestorPostalCode; v72.Clean = value; CompInvestorPostalCode = v72;
                var v73 = CompInvestorProgramCode; v73.Clean = value; CompInvestorProgramCode = v73;
                var v74 = CompInvestorState; v74.Clean = value; CompInvestorState = v74;
                var v75 = CompInvestorTemplateName; v75.Clean = value; CompInvestorTemplateName = v75;
                var v76 = CompInvestorWebsite; v76.Clean = value; CompInvestorWebsite = v76;
                var v77 = CompSideAdjustments; v77.Clean = value; CompSideAdjustments = v77;
                var v78 = CompSideComments; v78.Clean = value; CompSideComments = v78;
                var v79 = CompSideComparisonedBy; v79.Clean = value; CompSideComparisonedBy = v79;
                var v80 = CompSideCurrentRateSetDate; v80.Clean = value; CompSideCurrentRateSetDate = v80;
                var v81 = CompSideDaystoExtend; v81.Clean = value; CompSideDaystoExtend = v81;
                var v82 = CompSideDiscountYSP; v82.Clean = value; CompSideDiscountYSP = v82;
                var v83 = CompSideExtendedLockExpires; v83.Clean = value; CompSideExtendedLockExpires = v83;
                var v84 = CompSideInvestorStatus; v84.Clean = value; CompSideInvestorStatus = v84;
                var v85 = CompSideInvestorStatusDate; v85.Clean = value; CompSideInvestorStatusDate = v85;
                var v86 = CompSideInvestorTradeNumber; v86.Clean = value; CompSideInvestorTradeNumber = v86;
                var v87 = CompSideLoanProgram; v87.Clean = value; CompSideLoanProgram = v87;
                var v88 = CompSideLockDate; v88.Clean = value; CompSideLockDate = v88;
                var v89 = CompSideLockExpires; v89.Clean = value; CompSideLockExpires = v89;
                var v90 = CompSideLockExtendPriceAdjustment; v90.Clean = value; CompSideLockExtendPriceAdjustment = v90;
                var v91 = CompSideMarginNetCompRate; v91.Clean = value; CompSideMarginNetCompRate = v91;
                var v92 = CompSideMarginRate; v92.Clean = value; CompSideMarginRate = v92;
                var v93 = CompSideMarginTotalAdjustment; v93.Clean = value; CompSideMarginTotalAdjustment = v93;
                var v94 = CompSideMasterContractNumber; v94.Clean = value; CompSideMasterContractNumber = v94;
                var v95 = CompSideNetCompPrice; v95.Clean = value; CompSideNetCompPrice = v95;
                var v96 = CompSideNetCompRate; v96.Clean = value; CompSideNetCompRate = v96;
                var v97 = CompSideNumberOfDays; v97.Clean = value; CompSideNumberOfDays = v97;
                var v98 = CompSideOriginalLockExpires; v98.Clean = value; CompSideOriginalLockExpires = v98;
                var v99 = CompSidePriceRate; v99.Clean = value; CompSidePriceRate = v99;
                var v100 = CompSidePriceTotalAdjustment; v100.Clean = value; CompSidePriceTotalAdjustment = v100;
                var v101 = CompSideRate; v101.Clean = value; CompSideRate = v101;
                var v102 = CompSideRateSheetID; v102.Clean = value; CompSideRateSheetID = v102;
                var v103 = CompSideRateTotalAdjustment; v103.Clean = value; CompSideRateTotalAdjustment = v103;
                var v104 = CompSideRequestedBy; v104.Clean = value; CompSideRequestedBy = v104;
                var v105 = CompSideServicingType; v105.Clean = value; CompSideServicingType = v105;
                var v106 = CompSideSRPPaidOut; v106.Clean = value; CompSideSRPPaidOut = v106;
                var v107 = CompSideTradeGuid; v107.Clean = value; CompSideTradeGuid = v107;
                var v108 = CompSideTradeNumber; v108.Clean = value; CompSideTradeNumber = v108;
                var v109 = ConfirmedBy; v109.Clean = value; ConfirmedBy = v109;
                var v110 = ConfirmedDate; v110.Clean = value; ConfirmedDate = v110;
                var v111 = CorporateApprovalDate; v111.Clean = value; CorporateApprovalDate = v111;
                var v112 = CorporateApprovedby; v112.Clean = value; CorporateApprovedby = v112;
                var v113 = CorporatePrice; v113.Clean = value; CorporatePrice = v113;
                var v114 = CorrespondentAdditionalLineAmount1; v114.Clean = value; CorrespondentAdditionalLineAmount1 = v114;
                var v115 = CorrespondentAdditionalLineAmount10; v115.Clean = value; CorrespondentAdditionalLineAmount10 = v115;
                var v116 = CorrespondentAdditionalLineAmount11; v116.Clean = value; CorrespondentAdditionalLineAmount11 = v116;
                var v117 = CorrespondentAdditionalLineAmount12; v117.Clean = value; CorrespondentAdditionalLineAmount12 = v117;
                var v118 = CorrespondentAdditionalLineAmount13; v118.Clean = value; CorrespondentAdditionalLineAmount13 = v118;
                var v119 = CorrespondentAdditionalLineAmount2; v119.Clean = value; CorrespondentAdditionalLineAmount2 = v119;
                var v120 = CorrespondentAdditionalLineAmount3; v120.Clean = value; CorrespondentAdditionalLineAmount3 = v120;
                var v121 = CorrespondentAdditionalLineAmount4; v121.Clean = value; CorrespondentAdditionalLineAmount4 = v121;
                var v122 = CorrespondentAdditionalLineAmount5; v122.Clean = value; CorrespondentAdditionalLineAmount5 = v122;
                var v123 = CorrespondentAdditionalLineAmount6; v123.Clean = value; CorrespondentAdditionalLineAmount6 = v123;
                var v124 = CorrespondentAdditionalLineAmount7; v124.Clean = value; CorrespondentAdditionalLineAmount7 = v124;
                var v125 = CorrespondentAdditionalLineAmount8; v125.Clean = value; CorrespondentAdditionalLineAmount8 = v125;
                var v126 = CorrespondentAdditionalLineAmount9; v126.Clean = value; CorrespondentAdditionalLineAmount9 = v126;
                var v127 = CorrespondentAdditionalLineDescription1; v127.Clean = value; CorrespondentAdditionalLineDescription1 = v127;
                var v128 = CorrespondentAdditionalLineDescription10; v128.Clean = value; CorrespondentAdditionalLineDescription10 = v128;
                var v129 = CorrespondentAdditionalLineDescription11; v129.Clean = value; CorrespondentAdditionalLineDescription11 = v129;
                var v130 = CorrespondentAdditionalLineDescription12; v130.Clean = value; CorrespondentAdditionalLineDescription12 = v130;
                var v131 = CorrespondentAdditionalLineDescription2; v131.Clean = value; CorrespondentAdditionalLineDescription2 = v131;
                var v132 = CorrespondentAdditionalLineDescription3; v132.Clean = value; CorrespondentAdditionalLineDescription3 = v132;
                var v133 = CorrespondentAdditionalLineDescription4; v133.Clean = value; CorrespondentAdditionalLineDescription4 = v133;
                var v134 = CorrespondentAdditionalLineDescription5; v134.Clean = value; CorrespondentAdditionalLineDescription5 = v134;
                var v135 = CorrespondentAdditionalLineDescription6; v135.Clean = value; CorrespondentAdditionalLineDescription6 = v135;
                var v136 = CorrespondentAdditionalLineDescription7; v136.Clean = value; CorrespondentAdditionalLineDescription7 = v136;
                var v137 = CorrespondentAdditionalLineDescription8; v137.Clean = value; CorrespondentAdditionalLineDescription8 = v137;
                var v138 = CorrespondentAdditionalLineDescription9; v138.Clean = value; CorrespondentAdditionalLineDescription9 = v138;
                var v139 = CorrespondentAdditionalLineTotalAmount; v139.Clean = value; CorrespondentAdditionalLineTotalAmount = v139;
                var v140 = CorrespondentAdjusterAmount1; v140.Clean = value; CorrespondentAdjusterAmount1 = v140;
                var v141 = CorrespondentAdjusterAmount2; v141.Clean = value; CorrespondentAdjusterAmount2 = v141;
                var v142 = CorrespondentAdjusterAmount3; v142.Clean = value; CorrespondentAdjusterAmount3 = v142;
                var v143 = CorrespondentAdjusterDescription1; v143.Clean = value; CorrespondentAdjusterDescription1 = v143;
                var v144 = CorrespondentAdjusterDescription2; v144.Clean = value; CorrespondentAdjusterDescription2 = v144;
                var v145 = CorrespondentAdjusterDescription3; v145.Clean = value; CorrespondentAdjusterDescription3 = v145;
                var v146 = CorrespondentConfirmedBy; v146.Clean = value; CorrespondentConfirmedBy = v146;
                var v147 = CorrespondentConfirmedDate; v147.Clean = value; CorrespondentConfirmedDate = v147;
                var v148 = CorrespondentCurrentImpounds; v148.Clean = value; CorrespondentCurrentImpounds = v148;
                var v149 = CorrespondentCurrentPrincipal; v149.Clean = value; CorrespondentCurrentPrincipal = v149;
                var v150 = CorrespondentDate; v150.Clean = value; CorrespondentDate = v150;
                var v151 = CorrespondentFinalBuyAmount; v151.Clean = value; CorrespondentFinalBuyAmount = v151;
                var v152 = CorrespondentFinalBuyPrice; v152.Clean = value; CorrespondentFinalBuyPrice = v152;
                var v153 = CorrespondentFirstPaymentDate; v153.Clean = value; CorrespondentFirstPaymentDate = v153;
                var v154 = CorrespondentImpounds; v154.Clean = value; CorrespondentImpounds = v154;
                var v155 = CorrespondentInterest; v155.Clean = value; CorrespondentInterest = v155;
                var v156 = CorrespondentInterestDays; v156.Clean = value; CorrespondentInterestDays = v156;
                var v157 = CorrespondentLateFeeAmount; v157.Clean = value; CorrespondentLateFeeAmount = v157;
                var v158 = CorrespondentLateFeePriceAdjustment; v158.Clean = value; CorrespondentLateFeePriceAdjustment = v158;
                var v159 = CorrespondentPaidToDate; v159.Clean = value; CorrespondentPaidToDate = v159;
                var v160 = CorrespondentPurchasedPrincipal; v160.Clean = value; CorrespondentPurchasedPrincipal = v160;
                var v161 = CorrespondentReconcilationComments; v161.Clean = value; CorrespondentReconcilationComments = v161;
                var v162 = CorrespondentRemainingBuydownAmount; v162.Clean = value; CorrespondentRemainingBuydownAmount = v162;
                var v163 = CorrespondentSRPAmount; v163.Clean = value; CorrespondentSRPAmount = v163;
                var v164 = CorrespondentWarehouseBankABANum; v164.Clean = value; CorrespondentWarehouseBankABANum = v164;
                var v165 = CorrespondentWarehouseBankAcctNum; v165.Clean = value; CorrespondentWarehouseBankAcctNum = v165;
                var v166 = CorrespondentWarehouseBankAddress; v166.Clean = value; CorrespondentWarehouseBankAddress = v166;
                var v167 = CorrespondentWarehouseBankAddress1; v167.Clean = value; CorrespondentWarehouseBankAddress1 = v167;
                var v168 = CorrespondentWarehouseBankBaileeExpirationDate; v168.Clean = value; CorrespondentWarehouseBankBaileeExpirationDate = v168;
                var v169 = CorrespondentWarehouseBankBaileeLetterReceivedIndicator; v169.Clean = value; CorrespondentWarehouseBankBaileeLetterReceivedIndicator = v169;
                var v170 = CorrespondentWarehouseBankBaileeLetterReqIndicator; v170.Clean = value; CorrespondentWarehouseBankBaileeLetterReqIndicator = v170;
                var v171 = CorrespondentWarehouseBankCity; v171.Clean = value; CorrespondentWarehouseBankCity = v171;
                var v172 = CorrespondentWarehouseBankContactEmail; v172.Clean = value; CorrespondentWarehouseBankContactEmail = v172;
                var v173 = CorrespondentWarehouseBankContactFax; v173.Clean = value; CorrespondentWarehouseBankContactFax = v173;
                var v174 = CorrespondentWarehouseBankContactName; v174.Clean = value; CorrespondentWarehouseBankContactName = v174;
                var v175 = CorrespondentWarehouseBankContactPhone; v175.Clean = value; CorrespondentWarehouseBankContactPhone = v175;
                var v176 = CorrespondentWarehouseBankDescription; v176.Clean = value; CorrespondentWarehouseBankDescription = v176;
                var v177 = CorrespondentWarehouseBankId; v177.Clean = value; CorrespondentWarehouseBankId = v177;
                var v178 = CorrespondentWarehouseBankName; v178.Clean = value; CorrespondentWarehouseBankName = v178;
                var v179 = CorrespondentWarehouseBankNotes; v179.Clean = value; CorrespondentWarehouseBankNotes = v179;
                var v180 = CorrespondentWarehouseBankSelfFunderIndicator; v180.Clean = value; CorrespondentWarehouseBankSelfFunderIndicator = v180;
                var v181 = CorrespondentWarehouseBankState; v181.Clean = value; CorrespondentWarehouseBankState = v181;
                var v182 = CorrespondentWarehouseBankTriPartyContractIndicator; v182.Clean = value; CorrespondentWarehouseBankTriPartyContractIndicator = v182;
                var v183 = CorrespondentWarehouseBankUseDefaultContactIndicator; v183.Clean = value; CorrespondentWarehouseBankUseDefaultContactIndicator = v183;
                var v184 = CorrespondentWarehouseBankWireInstructionsReceivedIndicator; v184.Clean = value; CorrespondentWarehouseBankWireInstructionsReceivedIndicator = v184;
                var v185 = CorrespondentWarehouseBankZip; v185.Clean = value; CorrespondentWarehouseBankZip = v185;
                var v186 = CreditScoreToUse; v186.Clean = value; CreditScoreToUse = v186;
                var v187 = CumulatedDaystoExtend; v187.Clean = value; CumulatedDaystoExtend = v187;
                var v188 = CurrentAdjustments; v188.Clean = value; CurrentAdjustments = v188;
                var v189 = CurrentComments; v189.Clean = value; CurrentComments = v189;
                var v190 = CurrentLockDate; v190.Clean = value; CurrentLockDate = v190;
                var v191 = CurrentLockExpires; v191.Clean = value; CurrentLockExpires = v191;
                var v192 = CurrentMarginRate; v192.Clean = value; CurrentMarginRate = v192;
                var v193 = CurrentMarginRateRequested; v193.Clean = value; CurrentMarginRateRequested = v193;
                var v194 = CurrentMarginTotalAdjustment; v194.Clean = value; CurrentMarginTotalAdjustment = v194;
                var v195 = CurrentNumberOfDays; v195.Clean = value; CurrentNumberOfDays = v195;
                var v196 = CurrentPriceRate; v196.Clean = value; CurrentPriceRate = v196;
                var v197 = CurrentPriceRateRequested; v197.Clean = value; CurrentPriceRateRequested = v197;
                var v198 = CurrentPriceTotalAdjustment; v198.Clean = value; CurrentPriceTotalAdjustment = v198;
                var v199 = CurrentRate; v199.Clean = value; CurrentRate = v199;
                var v200 = CurrentRateRequested; v200.Clean = value; CurrentRateRequested = v200;
                var v201 = CurrentRateSetDate; v201.Clean = value; CurrentRateSetDate = v201;
                var v202 = CurrentRateSheetID; v202.Clean = value; CurrentRateSheetID = v202;
                var v203 = CurrentRateTotalAdjustment; v203.Clean = value; CurrentRateTotalAdjustment = v203;
                var v204 = Date; v204.Clean = value; Date = v204;
                var v205 = DateFirstPaymentToInvestor; v205.Clean = value; DateFirstPaymentToInvestor = v205;
                var v206 = DateLockedWithInvestor; v206.Clean = value; DateLockedWithInvestor = v206;
                var v207 = DateSold; v207.Clean = value; DateSold = v207;
                var v208 = DateWarehoused; v208.Clean = value; DateWarehoused = v208;
                var v209 = DaysToExtend; v209.Clean = value; DaysToExtend = v209;
                var v210 = DeliveryType; v210.Clean = value; DeliveryType = v210;
                var v211 = DiffAmountReceived; v211.Clean = value; DiffAmountReceived = v211;
                var v212 = DiffImpounds; v212.Clean = value; DiffImpounds = v212;
                var v213 = DiffInterest; v213.Clean = value; DiffInterest = v213;
                var v214 = DiffPremium; v214.Clean = value; DiffPremium = v214;
                var v215 = DiffPrinciple; v215.Clean = value; DiffPrinciple = v215;
                var v216 = DiffRemainingBuydownFunds; v216.Clean = value; DiffRemainingBuydownFunds = v216;
                var v217 = DiffSellAmount; v217.Clean = value; DiffSellAmount = v217;
                var v218 = DiffSellPrice; v218.Clean = value; DiffSellPrice = v218;
                var v219 = DiffSellSideSRP; v219.Clean = value; DiffSellSideSRP = v219;
                var v220 = DiffSRP; v220.Clean = value; DiffSRP = v220;
                var v221 = DiffSRPAmount; v221.Clean = value; DiffSRPAmount = v221;
                var v222 = EmploymentBorrowerSelfEmployedIndicator1; v222.Clean = value; EmploymentBorrowerSelfEmployedIndicator1 = v222;
                var v223 = EmploymentBorrowerSelfEmployedIndicator10; v223.Clean = value; EmploymentBorrowerSelfEmployedIndicator10 = v223;
                var v224 = EmploymentBorrowerSelfEmployedIndicator11; v224.Clean = value; EmploymentBorrowerSelfEmployedIndicator11 = v224;
                var v225 = EmploymentBorrowerSelfEmployedIndicator12; v225.Clean = value; EmploymentBorrowerSelfEmployedIndicator12 = v225;
                var v226 = EmploymentBorrowerSelfEmployedIndicator2; v226.Clean = value; EmploymentBorrowerSelfEmployedIndicator2 = v226;
                var v227 = EmploymentBorrowerSelfEmployedIndicator3; v227.Clean = value; EmploymentBorrowerSelfEmployedIndicator3 = v227;
                var v228 = EmploymentBorrowerSelfEmployedIndicator4; v228.Clean = value; EmploymentBorrowerSelfEmployedIndicator4 = v228;
                var v229 = EmploymentBorrowerSelfEmployedIndicator5; v229.Clean = value; EmploymentBorrowerSelfEmployedIndicator5 = v229;
                var v230 = EmploymentBorrowerSelfEmployedIndicator6; v230.Clean = value; EmploymentBorrowerSelfEmployedIndicator6 = v230;
                var v231 = EmploymentBorrowerSelfEmployedIndicator7; v231.Clean = value; EmploymentBorrowerSelfEmployedIndicator7 = v231;
                var v232 = EmploymentBorrowerSelfEmployedIndicator8; v232.Clean = value; EmploymentBorrowerSelfEmployedIndicator8 = v232;
                var v233 = EmploymentBorrowerSelfEmployedIndicator9; v233.Clean = value; EmploymentBorrowerSelfEmployedIndicator9 = v233;
                var v234 = ExpectedAmountReceived; v234.Clean = value; ExpectedAmountReceived = v234;
                var v235 = ExpectedImpounds; v235.Clean = value; ExpectedImpounds = v235;
                var v236 = ExpectedInterest; v236.Clean = value; ExpectedInterest = v236;
                var v237 = ExpectedPremium; v237.Clean = value; ExpectedPremium = v237;
                var v238 = ExpectedPrinciple; v238.Clean = value; ExpectedPrinciple = v238;
                var v239 = ExpectedRemainingBuydownFunds; v239.Clean = value; ExpectedRemainingBuydownFunds = v239;
                var v240 = ExpectedSRP; v240.Clean = value; ExpectedSRP = v240;
                var v241 = ExtensionRequestPending; v241.Clean = value; ExtensionRequestPending = v241;
                var v242 = ExtensionSequenceNumber; v242.Clean = value; ExtensionSequenceNumber = v242;
                var v243 = FHAUpfrontMIPremiumPercent; v243.Clean = value; FHAUpfrontMIPremiumPercent = v243;
                var v244 = FinancedNumberOfUnits; v244.Clean = value; FinancedNumberOfUnits = v244;
                var v245 = FirstPaymenTo; v245.Clean = value; FirstPaymenTo = v245;
                var v246 = FirstSubordinateAmount; v246.Clean = value; FirstSubordinateAmount = v246;
                var v247 = FirstTimeHomebuyersIndicator; v247.Clean = value; FirstTimeHomebuyersIndicator = v247;
                var v248 = FNMProductPlanIdentifier; v248.Clean = value; FNMProductPlanIdentifier = v248;
                var v249 = FundingAmount; v249.Clean = value; FundingAmount = v249;
                var v250 = GainLossPercentage; v250.Clean = value; GainLossPercentage = v250;
                var v251 = GainLossPrice; v251.Clean = value; GainLossPrice = v251;
                var v252 = GainLossTotalBuyPrice; v252.Clean = value; GainLossTotalBuyPrice = v252;
                var v253 = GPMRate; v253.Clean = value; GPMRate = v253;
                var v254 = GPMYears; v254.Clean = value; GPMYears = v254;
                var v255 = GSEPropertyType; v255.Clean = value; GSEPropertyType = v255;
                var v256 = Hedging; v256.Clean = value; Hedging = v256;
                var v257 = HELOCActualBalance; v257.Clean = value; HELOCActualBalance = v257;
                var v258 = Id; v258.Clean = value; Id = v258;
                var v259 = Impounds; v259.Clean = value; Impounds = v259;
                var v260 = ImpoundType; v260.Clean = value; ImpoundType = v260;
                var v261 = ImpoundWavied; v261.Clean = value; ImpoundWavied = v261;
                var v262 = Interest; v262.Clean = value; Interest = v262;
                var v263 = InvestorAddress; v263.Clean = value; InvestorAddress = v263;
                var v264 = InvestorCity; v264.Clean = value; InvestorCity = v264;
                var v265 = InvestorCommitment; v265.Clean = value; InvestorCommitment = v265;
                var v266 = InvestorContact; v266.Clean = value; InvestorContact = v266;
                var v267 = InvestorDeliveryDate; v267.Clean = value; InvestorDeliveryDate = v267;
                var v268 = InvestorEmail; v268.Clean = value; InvestorEmail = v268;
                var v269 = InvestorLoanNumber; v269.Clean = value; InvestorLoanNumber = v269;
                var v270 = InvestorLockType; v270.Clean = value; InvestorLockType = v270;
                var v271 = InvestorMERSNumber; v271.Clean = value; InvestorMERSNumber = v271;
                var v272 = InvestorName; v272.Clean = value; InvestorName = v272;
                var v273 = InvestorPhone; v273.Clean = value; InvestorPhone = v273;
                var v274 = InvestorPostalCode; v274.Clean = value; InvestorPostalCode = v274;
                var v275 = InvestorProgramCode; v275.Clean = value; InvestorProgramCode = v275;
                var v276 = InvestorState; v276.Clean = value; InvestorState = v276;
                var v277 = InvestorTargetDeliveryDate; v277.Clean = value; InvestorTargetDeliveryDate = v277;
                var v278 = InvestorTemplateName; v278.Clean = value; InvestorTemplateName = v278;
                var v279 = InvestorWebsite; v279.Clean = value; InvestorWebsite = v279;
                var v280 = IsCancelled; v280.Clean = value; IsCancelled = v280;
                var v281 = IsDeliveryType; v281.Clean = value; IsDeliveryType = v281;
                var v282 = LenderPaidMortgageInsuranceIndicator; v282.Clean = value; LenderPaidMortgageInsuranceIndicator = v282;
                var v283 = LienPriorityType; v283.Clean = value; LienPriorityType = v283;
                var v284 = LoanAmortizationTermMonths; v284.Clean = value; LoanAmortizationTermMonths = v284;
                var v285 = LoanAmortizationType; v285.Clean = value; LoanAmortizationType = v285;
                var v286 = LoanDocumentationType; v286.Clean = value; LoanDocumentationType = v286;
                var v287 = LoanFor203K; v287.Clean = value; LoanFor203K = v287;
                var v288 = LoanProgram; v288.Clean = value; LoanProgram = v288;
                var v289 = LoanProgramFile; v289.Clean = value; LoanProgramFile = v289;
                var v290 = LoanScheduledClosingDate; v290.Clean = value; LoanScheduledClosingDate = v290;
                var v291 = LockField; v291.Clean = value; LockField = v291;
                var v292 = LockRequestAdjustments; v292.Clean = value; LockRequestAdjustments = v292;
                var v293 = LockRequestBorrowers; v293.Clean = value; LockRequestBorrowers = v293;
                var v294 = LockRequestLoanPurposeType; v294.Clean = value; LockRequestLoanPurposeType = v294;
                var v295 = LTV; v295.Clean = value; LTV = v295;
                var v296 = MinFICO; v296.Clean = value; MinFICO = v296;
                var v297 = MinFICO2; v297.Clean = value; MinFICO2 = v297;
                var v298 = MIPPaidInCash; v298.Clean = value; MIPPaidInCash = v298;
                var v299 = MortgageType; v299.Clean = value; MortgageType = v299;
                var v300 = NetSellAmount; v300.Clean = value; NetSellAmount = v300;
                var v301 = NetSellPrice; v301.Clean = value; NetSellPrice = v301;
                var v302 = NextPaymentDate; v302.Clean = value; NextPaymentDate = v302;
                var v303 = NoClosingCostOption; v303.Clean = value; NoClosingCostOption = v303;
                var v304 = ONRPLock; v304.Clean = value; ONRPLock = v304;
                var v305 = OtherAmortizationTypeDescription; v305.Clean = value; OtherAmortizationTypeDescription = v305;
                var v306 = OtherSubordinateAmount; v306.Clean = value; OtherSubordinateAmount = v306;
                var v307 = PenaltyTerm; v307.Clean = value; PenaltyTerm = v307;
                var v308 = PerDiemInterestRoundingType; v308.Clean = value; PerDiemInterestRoundingType = v308;
                var v309 = PlanCode; v309.Clean = value; PlanCode = v309;
                var v310 = Premium; v310.Clean = value; Premium = v310;
                var v311 = PrepayPenalty; v311.Clean = value; PrepayPenalty = v311;
                var v312 = PriceAdjustment; v312.Clean = value; PriceAdjustment = v312;
                var v313 = PriceAdjustments; v313.Clean = value; PriceAdjustments = v313;
                var v314 = PricingHistoryData; v314.Clean = value; PricingHistoryData = v314;
                var v315 = PricingUpdated; v315.Clean = value; PricingUpdated = v315;
                var v316 = Principle; v316.Clean = value; Principle = v316;
                var v317 = ProfitMarginAdjustedBuyPrice; v317.Clean = value; ProfitMarginAdjustedBuyPrice = v317;
                var v318 = PropertyAppraisedValueAmount; v318.Clean = value; PropertyAppraisedValueAmount = v318;
                var v319 = PropertyEstimatedValueAmount; v319.Clean = value; PropertyEstimatedValueAmount = v319;
                var v320 = PropertyUsageType; v320.Clean = value; PropertyUsageType = v320;
                var v321 = PurchaseAdviceNumberOfDays; v321.Clean = value; PurchaseAdviceNumberOfDays = v321;
                var v322 = PurchaseAdvicePayouts; v322.Clean = value; PurchaseAdvicePayouts = v322;
                var v323 = PurchasePriceAmount; v323.Clean = value; PurchasePriceAmount = v323;
                var v324 = RateRequestStatus; v324.Clean = value; RateRequestStatus = v324;
                var v325 = RateStatus; v325.Clean = value; RateStatus = v325;
                var v326 = ReasonforBranchApproval; v326.Clean = value; ReasonforBranchApproval = v326;
                var v327 = ReasonforCorporateApproval; v327.Clean = value; ReasonforCorporateApproval = v327;
                var v328 = ReconciledDiff; v328.Clean = value; ReconciledDiff = v328;
                var v329 = ReLockRequestPending; v329.Clean = value; ReLockRequestPending = v329;
                var v330 = RemainingBuydownFunds; v330.Clean = value; RemainingBuydownFunds = v330;
                var v331 = RequestComments; v331.Clean = value; RequestComments = v331;
                var v332 = RequestCurrentRateSetDate; v332.Clean = value; RequestCurrentRateSetDate = v332;
                var v333 = RequestDaystoExtend; v333.Clean = value; RequestDaystoExtend = v333;
                var v334 = RequestExtendedLockExpires; v334.Clean = value; RequestExtendedLockExpires = v334;
                var v335 = RequestFullfilledDateTime; v335.Clean = value; RequestFullfilledDateTime = v335;
                var v336 = RequestImpoundType; v336.Clean = value; RequestImpoundType = v336;
                var v337 = RequestImpoundWavied; v337.Clean = value; RequestImpoundWavied = v337;
                var v338 = RequestLockCancellationComment; v338.Clean = value; RequestLockCancellationComment = v338;
                var v339 = RequestLockCancellationDate; v339.Clean = value; RequestLockCancellationDate = v339;
                var v340 = RequestLockDate; v340.Clean = value; RequestLockDate = v340;
                var v341 = RequestLockExpires; v341.Clean = value; RequestLockExpires = v341;
                var v342 = RequestLockExtendComment; v342.Clean = value; RequestLockExtendComment = v342;
                var v343 = RequestLockExtendPriceAdjustment; v343.Clean = value; RequestLockExtendPriceAdjustment = v343;
                var v344 = RequestLockType; v344.Clean = value; RequestLockType = v344;
                var v345 = RequestMarginRate; v345.Clean = value; RequestMarginRate = v345;
                var v346 = RequestMarginRateRequested; v346.Clean = value; RequestMarginRateRequested = v346;
                var v347 = RequestMarginSRPPaidOut; v347.Clean = value; RequestMarginSRPPaidOut = v347;
                var v348 = RequestMarginTotalAdjustment; v348.Clean = value; RequestMarginTotalAdjustment = v348;
                var v349 = RequestNumberOfDays; v349.Clean = value; RequestNumberOfDays = v349;
                var v350 = RequestOnrpEligible; v350.Clean = value; RequestOnrpEligible = v350;
                var v351 = RequestOnrpLockDate; v351.Clean = value; RequestOnrpLockDate = v351;
                var v352 = RequestOnrpLockTime; v352.Clean = value; RequestOnrpLockTime = v352;
                var v353 = RequestOriginalLockExpires; v353.Clean = value; RequestOriginalLockExpires = v353;
                var v354 = RequestPenaltyTerm; v354.Clean = value; RequestPenaltyTerm = v354;
                var v355 = RequestPending; v355.Clean = value; RequestPending = v355;
                var v356 = RequestPrepayPenalty; v356.Clean = value; RequestPrepayPenalty = v356;
                var v357 = RequestPriceRate; v357.Clean = value; RequestPriceRate = v357;
                var v358 = RequestPriceRateRequested; v358.Clean = value; RequestPriceRateRequested = v358;
                var v359 = RequestPriceTotalAdjustment; v359.Clean = value; RequestPriceTotalAdjustment = v359;
                var v360 = RequestRate; v360.Clean = value; RequestRate = v360;
                var v361 = RequestRateRequested; v361.Clean = value; RequestRateRequested = v361;
                var v362 = RequestRateSheetID; v362.Clean = value; RequestRateSheetID = v362;
                var v363 = RequestRateTotalAdjustment; v363.Clean = value; RequestRateTotalAdjustment = v363;
                var v364 = RequestStartingAdjPoint; v364.Clean = value; RequestStartingAdjPoint = v364;
                var v365 = RequestStartingAdjRate; v365.Clean = value; RequestStartingAdjRate = v365;
                var v366 = RequestType; v366.Clean = value; RequestType = v366;
                var v367 = RequestUnDiscountedRate; v367.Clean = value; RequestUnDiscountedRate = v367;
                var v368 = RoundToNearest50; v368.Clean = value; RoundToNearest50 = v368;
                var v369 = SecondSubordinateAmount; v369.Clean = value; SecondSubordinateAmount = v369;
                var v370 = SellerPaidMIPremium; v370.Clean = value; SellerPaidMIPremium = v370;
                var v371 = SellSideAdjustments; v371.Clean = value; SellSideAdjustments = v371;
                var v372 = SellSideComments; v372.Clean = value; SellSideComments = v372;
                var v373 = SellSideCommitmentContractNumber; v373.Clean = value; SellSideCommitmentContractNumber = v373;
                var v374 = SellSideCommitmentDate; v374.Clean = value; SellSideCommitmentDate = v374;
                var v375 = SellSideCurrentRateSetDate; v375.Clean = value; SellSideCurrentRateSetDate = v375;
                var v376 = SellSideDaystoExtend; v376.Clean = value; SellSideDaystoExtend = v376;
                var v377 = SellSideDiscountYSP; v377.Clean = value; SellSideDiscountYSP = v377;
                var v378 = SellSideExtendedLockExpires; v378.Clean = value; SellSideExtendedLockExpires = v378;
                var v379 = SellSideGuaranteeFee; v379.Clean = value; SellSideGuaranteeFee = v379;
                var v380 = SellSideGuarantyBaseFee; v380.Clean = value; SellSideGuarantyBaseFee = v380;
                var v381 = SellSideInvestorStatus; v381.Clean = value; SellSideInvestorStatus = v381;
                var v382 = SellSideInvestorStatusDate; v382.Clean = value; SellSideInvestorStatusDate = v382;
                var v383 = SellSideInvestorTradeNumber; v383.Clean = value; SellSideInvestorTradeNumber = v383;
                var v384 = SellSideLoanProgram; v384.Clean = value; SellSideLoanProgram = v384;
                var v385 = SellSideLockDate; v385.Clean = value; SellSideLockDate = v385;
                var v386 = SellSideLockExpires; v386.Clean = value; SellSideLockExpires = v386;
                var v387 = SellSideLockExtendPriceAdjustment; v387.Clean = value; SellSideLockExtendPriceAdjustment = v387;
                var v388 = SellSideMarginNetSellRate; v388.Clean = value; SellSideMarginNetSellRate = v388;
                var v389 = SellSideMarginRate; v389.Clean = value; SellSideMarginRate = v389;
                var v390 = SellSideMarginTotalAdjustment; v390.Clean = value; SellSideMarginTotalAdjustment = v390;
                var v391 = SellSideMasterContractNumber; v391.Clean = value; SellSideMasterContractNumber = v391;
                var v392 = SellSideMSRValue; v392.Clean = value; SellSideMSRValue = v392;
                var v393 = SellSideNetSellPrice; v393.Clean = value; SellSideNetSellPrice = v393;
                var v394 = SellSideNetSellRate; v394.Clean = value; SellSideNetSellRate = v394;
                var v395 = SellSideNumberOfDays; v395.Clean = value; SellSideNumberOfDays = v395;
                var v396 = SellSideOriginalLockExpires; v396.Clean = value; SellSideOriginalLockExpires = v396;
                var v397 = SellSidePoolID; v397.Clean = value; SellSidePoolID = v397;
                var v398 = SellSidePoolNumber; v398.Clean = value; SellSidePoolNumber = v398;
                var v399 = SellSidePriceRate; v399.Clean = value; SellSidePriceRate = v399;
                var v400 = SellSidePriceTotalAdjustment; v400.Clean = value; SellSidePriceTotalAdjustment = v400;
                var v401 = SellSideProductName; v401.Clean = value; SellSideProductName = v401;
                var v402 = SellSideRate; v402.Clean = value; SellSideRate = v402;
                var v403 = SellSideRateSheetID; v403.Clean = value; SellSideRateSheetID = v403;
                var v404 = SellSideRateTotalAdjustment; v404.Clean = value; SellSideRateTotalAdjustment = v404;
                var v405 = SellSideRequestedBy; v405.Clean = value; SellSideRequestedBy = v405;
                var v406 = SellSideServicer; v406.Clean = value; SellSideServicer = v406;
                var v407 = SellSideServicingFee; v407.Clean = value; SellSideServicingFee = v407;
                var v408 = SellSideServicingType; v408.Clean = value; SellSideServicingType = v408;
                var v409 = SellSideSRP; v409.Clean = value; SellSideSRP = v409;
                var v410 = SellSideSRPPaidOut; v410.Clean = value; SellSideSRPPaidOut = v410;
                var v411 = SellSideTradeGuid; v411.Clean = value; SellSideTradeGuid = v411;
                var v412 = SellSideTradeMgmtPrevConfirmedLockGuid; v412.Clean = value; SellSideTradeMgmtPrevConfirmedLockGuid = v412;
                var v413 = SellSideTradeNumber; v413.Clean = value; SellSideTradeNumber = v413;
                var v414 = ServicingReleaseIndicator; v414.Clean = value; ServicingReleaseIndicator = v414;
                var v415 = SRP; v415.Clean = value; SRP = v415;
                var v416 = SRPAmount; v416.Clean = value; SRPAmount = v416;
                var v417 = SubjectPropertyCity; v417.Clean = value; SubjectPropertyCity = v417;
                var v418 = SubjectPropertyCondotelIndicator; v418.Clean = value; SubjectPropertyCondotelIndicator = v418;
                var v419 = SubjectPropertyCounty; v419.Clean = value; SubjectPropertyCounty = v419;
                var v420 = SubjectPropertyNonWarrantableProjectIndicator; v420.Clean = value; SubjectPropertyNonWarrantableProjectIndicator = v420;
                var v421 = SubjectPropertyPostalCode; v421.Clean = value; SubjectPropertyPostalCode = v421;
                var v422 = SubjectPropertyState; v422.Clean = value; SubjectPropertyState = v422;
                var v423 = SubjectPropertyStreetAddress; v423.Clean = value; SubjectPropertyStreetAddress = v423;
                var v424 = TimeLockedWithInvestor; v424.Clean = value; TimeLockedWithInvestor = v424;
                var v425 = TotalBuyPrice; v425.Clean = value; TotalBuyPrice = v425;
                var v426 = TotalForLesserOfSumAsIs; v426.Clean = value; TotalForLesserOfSumAsIs = v426;
                var v427 = TotalPrice; v427.Clean = value; TotalPrice = v427;
                var v428 = TotalSubordinateFinancing; v428.Clean = value; TotalSubordinateFinancing = v428;
                var v429 = TwelveMonthMortgageRentalHistoryIndicator; v429.Clean = value; TwelveMonthMortgageRentalHistoryIndicator = v429;
                var v430 = Type; v430.Clean = value; Type = v430;
                var v431 = UsePoint; v431.Clean = value; UsePoint = v431;
                _settingClean = 0;
            }
        }
    }
}