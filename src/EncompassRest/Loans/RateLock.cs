using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RateLock : IClean
    {
        private Value<decimal?> _actualSellAmount;
        public decimal? ActualSellAmount { get { return _actualSellAmount; } set { _actualSellAmount = value; } }
        private Value<decimal?> _actualSellPrice;
        public decimal? ActualSellPrice { get { return _actualSellPrice; } set { _actualSellPrice = value; } }
        private Value<decimal?> _actualSellSideSRP;
        public decimal? ActualSellSideSRP { get { return _actualSellSideSRP; } set { _actualSellSideSRP = value; } }
        private Value<decimal?> _actualSRPAmount;
        public decimal? ActualSRPAmount { get { return _actualSRPAmount; } set { _actualSRPAmount = value; } }
        private Value<decimal?> _amountDue;
        public decimal? AmountDue { get { return _amountDue; } set { _amountDue = value; } }
        private Value<string> _amountDueTo;
        public string AmountDueTo { get { return _amountDueTo; } set { _amountDueTo = value; } }
        private Value<decimal?> _amountPaid;
        public decimal? AmountPaid { get { return _amountPaid; } set { _amountPaid = value; } }
        private Value<string> _amountPaidTo;
        public string AmountPaidTo { get { return _amountPaidTo; } set { _amountPaidTo = value; } }
        private Value<decimal?> _amountReceived;
        public decimal? AmountReceived { get { return _amountReceived; } set { _amountReceived = value; } }
        private Value<int?> _balloonLoanMaturityTermMonths;
        public int? BalloonLoanMaturityTermMonths { get { return _balloonLoanMaturityTermMonths; } set { _balloonLoanMaturityTermMonths = value; } }
        private Value<decimal?> _baseLoanAmount;
        public decimal? BaseLoanAmount { get { return _baseLoanAmount; } set { _baseLoanAmount = value; } }
        private Value<decimal?> _borrowerRequestedLoanAmount;
        public decimal? BorrowerRequestedLoanAmount { get { return _borrowerRequestedLoanAmount; } set { _borrowerRequestedLoanAmount = value; } }
        private Value<DateTime?> _branchApprovalDate;
        public DateTime? BranchApprovalDate { get { return _branchApprovalDate; } set { _branchApprovalDate = value; } }
        private Value<string> _branchApprovedby;
        public string BranchApprovedby { get { return _branchApprovedby; } set { _branchApprovedby = value; } }
        private Value<decimal?> _branchPrice;
        public decimal? BranchPrice { get { return _branchPrice; } set { _branchPrice = value; } }
        private Value<List<PriceAdjustment>> _buySideAdjustments;
        public List<PriceAdjustment> BuySideAdjustments { get { return _buySideAdjustments; } set { _buySideAdjustments = value; } }
        private Value<string> _buySideComments;
        public string BuySideComments { get { return _buySideComments; } set { _buySideComments = value; } }
        private Value<DateTime?> _buySideCommitmentDate;
        public DateTime? BuySideCommitmentDate { get { return _buySideCommitmentDate; } set { _buySideCommitmentDate = value; } }
        private Value<string> _buySideCommitmentNumber;
        public string BuySideCommitmentNumber { get { return _buySideCommitmentNumber; } set { _buySideCommitmentNumber = value; } }
        private Value<string> _buySideCommitmentType;
        public string BuySideCommitmentType { get { return _buySideCommitmentType; } set { _buySideCommitmentType = value; } }
        private Value<DateTime?> _buySideCurrentRateSetDate;
        public DateTime? BuySideCurrentRateSetDate { get { return _buySideCurrentRateSetDate; } set { _buySideCurrentRateSetDate = value; } }
        private Value<int?> _buySideDaystoExtend;
        public int? BuySideDaystoExtend { get { return _buySideDaystoExtend; } set { _buySideDaystoExtend = value; } }
        private Value<DateTime?> _buySideDeliveryExpirationDate;
        public DateTime? BuySideDeliveryExpirationDate { get { return _buySideDeliveryExpirationDate; } set { _buySideDeliveryExpirationDate = value; } }
        private Value<string> _buySideDeliveryType;
        public string BuySideDeliveryType { get { return _buySideDeliveryType; } set { _buySideDeliveryType = value; } }
        private Value<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get { return _buySideExpirationDate; } set { _buySideExpirationDate = value; } }
        private Value<DateTime?> _buySideExtendedLockExpires;
        public DateTime? BuySideExtendedLockExpires { get { return _buySideExtendedLockExpires; } set { _buySideExtendedLockExpires = value; } }
        private Value<DateTime?> _buySideLockDate;
        public DateTime? BuySideLockDate { get { return _buySideLockDate; } set { _buySideLockDate = value; } }
        private Value<DateTime?> _buySideLockExpires;
        public DateTime? BuySideLockExpires { get { return _buySideLockExpires; } set { _buySideLockExpires = value; } }
        private Value<decimal?> _buySideLockExtendPriceAdjustment;
        public decimal? BuySideLockExtendPriceAdjustment { get { return _buySideLockExtendPriceAdjustment; } set { _buySideLockExtendPriceAdjustment = value; } }
        private Value<decimal?> _buySideMarginNetBuyRate;
        public decimal? BuySideMarginNetBuyRate { get { return _buySideMarginNetBuyRate; } set { _buySideMarginNetBuyRate = value; } }
        private Value<decimal?> _buySideMarginRate;
        public decimal? BuySideMarginRate { get { return _buySideMarginRate; } set { _buySideMarginRate = value; } }
        private Value<decimal?> _buySideMarginTotalAdjustment;
        public decimal? BuySideMarginTotalAdjustment { get { return _buySideMarginTotalAdjustment; } set { _buySideMarginTotalAdjustment = value; } }
        private Value<string> _buySideMasterCommitmentNumber;
        public string BuySideMasterCommitmentNumber { get { return _buySideMasterCommitmentNumber; } set { _buySideMasterCommitmentNumber = value; } }
        private Value<int?> _buySideNumberOfDays;
        public int? BuySideNumberOfDays { get { return _buySideNumberOfDays; } set { _buySideNumberOfDays = value; } }
        private Value<bool?> _buySideOnrpEligible;
        public bool? BuySideOnrpEligible { get { return _buySideOnrpEligible; } set { _buySideOnrpEligible = value; } }
        private Value<DateTime?> _buySideOnrpLockDate;
        public DateTime? BuySideOnrpLockDate { get { return _buySideOnrpLockDate; } set { _buySideOnrpLockDate = value; } }
        private Value<string> _buySideOnrpLockTime;
        public string BuySideOnrpLockTime { get { return _buySideOnrpLockTime; } set { _buySideOnrpLockTime = value; } }
        private Value<string> _buySideOrgID;
        public string BuySideOrgID { get { return _buySideOrgID; } set { _buySideOrgID = value; } }
        private Value<DateTime?> _buySideOriginalLockExpires;
        public DateTime? BuySideOriginalLockExpires { get { return _buySideOriginalLockExpires; } set { _buySideOriginalLockExpires = value; } }
        private Value<decimal?> _buySidePriceNetBuyPrice;
        public decimal? BuySidePriceNetBuyPrice { get { return _buySidePriceNetBuyPrice; } set { _buySidePriceNetBuyPrice = value; } }
        private Value<decimal?> _buySidePriceRate;
        public decimal? BuySidePriceRate { get { return _buySidePriceRate; } set { _buySidePriceRate = value; } }
        private Value<decimal?> _buySidePriceTotalAdjustment;
        public decimal? BuySidePriceTotalAdjustment { get { return _buySidePriceTotalAdjustment; } set { _buySidePriceTotalAdjustment = value; } }
        private Value<decimal?> _buySideRate;
        public decimal? BuySideRate { get { return _buySideRate; } set { _buySideRate = value; } }
        private Value<decimal?> _buySideRateNetBuyRate;
        public decimal? BuySideRateNetBuyRate { get { return _buySideRateNetBuyRate; } set { _buySideRateNetBuyRate = value; } }
        private Value<string> _buySideRateSheetID;
        public string BuySideRateSheetID { get { return _buySideRateSheetID; } set { _buySideRateSheetID = value; } }
        private Value<decimal?> _buySideRateTotalAdjustment;
        public decimal? BuySideRateTotalAdjustment { get { return _buySideRateTotalAdjustment; } set { _buySideRateTotalAdjustment = value; } }
        private Value<string> _buySideRequestedBy;
        public string BuySideRequestedBy { get { return _buySideRequestedBy; } set { _buySideRequestedBy = value; } }
        private Value<decimal?> _buySideSRPPaidOut;
        public decimal? BuySideSRPPaidOut { get { return _buySideSRPPaidOut; } set { _buySideSRPPaidOut = value; } }
        private Value<decimal?> _buySideStartingAdjPoint;
        public decimal? BuySideStartingAdjPoint { get { return _buySideStartingAdjPoint; } set { _buySideStartingAdjPoint = value; } }
        private Value<decimal?> _buySideStartingAdjPrice;
        public decimal? BuySideStartingAdjPrice { get { return _buySideStartingAdjPrice; } set { _buySideStartingAdjPrice = value; } }
        private Value<decimal?> _buySideStartingAdjRate;
        public decimal? BuySideStartingAdjRate { get { return _buySideStartingAdjRate; } set { _buySideStartingAdjRate = value; } }
        private Value<string> _buySideTPOID;
        public string BuySideTPOID { get { return _buySideTPOID; } set { _buySideTPOID = value; } }
        private Value<string> _buySideTPOName;
        public string BuySideTPOName { get { return _buySideTPOName; } set { _buySideTPOName = value; } }
        private Value<string> _buySideTradeGuid;
        public string BuySideTradeGuid { get { return _buySideTradeGuid; } set { _buySideTradeGuid = value; } }
        private Value<string> _buySideTradeNumber;
        public string BuySideTradeNumber { get { return _buySideTradeNumber; } set { _buySideTradeNumber = value; } }
        private Value<decimal?> _buySideUnDiscountedRate;
        public decimal? BuySideUnDiscountedRate { get { return _buySideUnDiscountedRate; } set { _buySideUnDiscountedRate = value; } }
        private Value<string> _cancellationRequestPending;
        public string CancellationRequestPending { get { return _cancellationRequestPending; } set { _cancellationRequestPending = value; } }
        private Value<decimal?> _combinedLTV;
        public decimal? CombinedLTV { get { return _combinedLTV; } set { _combinedLTV = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _commitment;
        public string Commitment { get { return _commitment; } set { _commitment = value; } }
        private Value<decimal?> _compGainLossPercentage;
        public decimal? CompGainLossPercentage { get { return _compGainLossPercentage; } set { _compGainLossPercentage = value; } }
        private Value<decimal?> _compGainLossPrice;
        public decimal? CompGainLossPrice { get { return _compGainLossPrice; } set { _compGainLossPrice = value; } }
        private Value<decimal?> _compGainLossTotalBuyPrice;
        public decimal? CompGainLossTotalBuyPrice { get { return _compGainLossTotalBuyPrice; } set { _compGainLossTotalBuyPrice = value; } }
        private Value<decimal?> _compGainLossTotalCompPrice;
        public decimal? CompGainLossTotalCompPrice { get { return _compGainLossTotalCompPrice; } set { _compGainLossTotalCompPrice = value; } }
        private Value<string> _compInvestorAddress;
        public string CompInvestorAddress { get { return _compInvestorAddress; } set { _compInvestorAddress = value; } }
        private Value<string> _compInvestorCity;
        public string CompInvestorCity { get { return _compInvestorCity; } set { _compInvestorCity = value; } }
        private Value<string> _compInvestorCommitment;
        public string CompInvestorCommitment { get { return _compInvestorCommitment; } set { _compInvestorCommitment = value; } }
        private Value<string> _compInvestorContact;
        public string CompInvestorContact { get { return _compInvestorContact; } set { _compInvestorContact = value; } }
        private Value<string> _compInvestorEmail;
        public string CompInvestorEmail { get { return _compInvestorEmail; } set { _compInvestorEmail = value; } }
        private Value<string> _compInvestorLockType;
        public string CompInvestorLockType { get { return _compInvestorLockType; } set { _compInvestorLockType = value; } }
        private Value<string> _compInvestorName;
        public string CompInvestorName { get { return _compInvestorName; } set { _compInvestorName = value; } }
        private Value<string> _compInvestorPhone;
        public string CompInvestorPhone { get { return _compInvestorPhone; } set { _compInvestorPhone = value; } }
        private Value<string> _compInvestorPostalCode;
        public string CompInvestorPostalCode { get { return _compInvestorPostalCode; } set { _compInvestorPostalCode = value; } }
        private Value<string> _compInvestorProgramCode;
        public string CompInvestorProgramCode { get { return _compInvestorProgramCode; } set { _compInvestorProgramCode = value; } }
        private Value<string> _compInvestorState;
        public string CompInvestorState { get { return _compInvestorState; } set { _compInvestorState = value; } }
        private Value<string> _compInvestorTemplateName;
        public string CompInvestorTemplateName { get { return _compInvestorTemplateName; } set { _compInvestorTemplateName = value; } }
        private Value<string> _compInvestorWebsite;
        public string CompInvestorWebsite { get { return _compInvestorWebsite; } set { _compInvestorWebsite = value; } }
        private Value<List<PriceAdjustment>> _compSideAdjustments;
        public List<PriceAdjustment> CompSideAdjustments { get { return _compSideAdjustments; } set { _compSideAdjustments = value; } }
        private Value<string> _compSideComments;
        public string CompSideComments { get { return _compSideComments; } set { _compSideComments = value; } }
        private Value<string> _compSideComparisonedBy;
        public string CompSideComparisonedBy { get { return _compSideComparisonedBy; } set { _compSideComparisonedBy = value; } }
        private Value<DateTime?> _compSideCurrentRateSetDate;
        public DateTime? CompSideCurrentRateSetDate { get { return _compSideCurrentRateSetDate; } set { _compSideCurrentRateSetDate = value; } }
        private Value<int?> _compSideDaystoExtend;
        public int? CompSideDaystoExtend { get { return _compSideDaystoExtend; } set { _compSideDaystoExtend = value; } }
        private Value<decimal?> _compSideDiscountYSP;
        public decimal? CompSideDiscountYSP { get { return _compSideDiscountYSP; } set { _compSideDiscountYSP = value; } }
        private Value<DateTime?> _compSideExtendedLockExpires;
        public DateTime? CompSideExtendedLockExpires { get { return _compSideExtendedLockExpires; } set { _compSideExtendedLockExpires = value; } }
        private Value<string> _compSideInvestorStatus;
        public string CompSideInvestorStatus { get { return _compSideInvestorStatus; } set { _compSideInvestorStatus = value; } }
        private Value<DateTime?> _compSideInvestorStatusDate;
        public DateTime? CompSideInvestorStatusDate { get { return _compSideInvestorStatusDate; } set { _compSideInvestorStatusDate = value; } }
        private Value<string> _compSideInvestorTradeNumber;
        public string CompSideInvestorTradeNumber { get { return _compSideInvestorTradeNumber; } set { _compSideInvestorTradeNumber = value; } }
        private Value<string> _compSideLoanProgram;
        public string CompSideLoanProgram { get { return _compSideLoanProgram; } set { _compSideLoanProgram = value; } }
        private Value<DateTime?> _compSideLockDate;
        public DateTime? CompSideLockDate { get { return _compSideLockDate; } set { _compSideLockDate = value; } }
        private Value<DateTime?> _compSideLockExpires;
        public DateTime? CompSideLockExpires { get { return _compSideLockExpires; } set { _compSideLockExpires = value; } }
        private Value<decimal?> _compSideLockExtendPriceAdjustment;
        public decimal? CompSideLockExtendPriceAdjustment { get { return _compSideLockExtendPriceAdjustment; } set { _compSideLockExtendPriceAdjustment = value; } }
        private Value<decimal?> _compSideMarginNetCompRate;
        public decimal? CompSideMarginNetCompRate { get { return _compSideMarginNetCompRate; } set { _compSideMarginNetCompRate = value; } }
        private Value<decimal?> _compSideMarginRate;
        public decimal? CompSideMarginRate { get { return _compSideMarginRate; } set { _compSideMarginRate = value; } }
        private Value<decimal?> _compSideMarginTotalAdjustment;
        public decimal? CompSideMarginTotalAdjustment { get { return _compSideMarginTotalAdjustment; } set { _compSideMarginTotalAdjustment = value; } }
        private Value<string> _compSideMasterContractNumber;
        public string CompSideMasterContractNumber { get { return _compSideMasterContractNumber; } set { _compSideMasterContractNumber = value; } }
        private Value<decimal?> _compSideNetCompPrice;
        public decimal? CompSideNetCompPrice { get { return _compSideNetCompPrice; } set { _compSideNetCompPrice = value; } }
        private Value<decimal?> _compSideNetCompRate;
        public decimal? CompSideNetCompRate { get { return _compSideNetCompRate; } set { _compSideNetCompRate = value; } }
        private Value<int?> _compSideNumberOfDays;
        public int? CompSideNumberOfDays { get { return _compSideNumberOfDays; } set { _compSideNumberOfDays = value; } }
        private Value<DateTime?> _compSideOriginalLockExpires;
        public DateTime? CompSideOriginalLockExpires { get { return _compSideOriginalLockExpires; } set { _compSideOriginalLockExpires = value; } }
        private Value<decimal?> _compSidePriceRate;
        public decimal? CompSidePriceRate { get { return _compSidePriceRate; } set { _compSidePriceRate = value; } }
        private Value<decimal?> _compSidePriceTotalAdjustment;
        public decimal? CompSidePriceTotalAdjustment { get { return _compSidePriceTotalAdjustment; } set { _compSidePriceTotalAdjustment = value; } }
        private Value<decimal?> _compSideRate;
        public decimal? CompSideRate { get { return _compSideRate; } set { _compSideRate = value; } }
        private Value<string> _compSideRateSheetID;
        public string CompSideRateSheetID { get { return _compSideRateSheetID; } set { _compSideRateSheetID = value; } }
        private Value<decimal?> _compSideRateTotalAdjustment;
        public decimal? CompSideRateTotalAdjustment { get { return _compSideRateTotalAdjustment; } set { _compSideRateTotalAdjustment = value; } }
        private Value<string> _compSideRequestedBy;
        public string CompSideRequestedBy { get { return _compSideRequestedBy; } set { _compSideRequestedBy = value; } }
        private Value<string> _compSideServicingType;
        public string CompSideServicingType { get { return _compSideServicingType; } set { _compSideServicingType = value; } }
        private Value<decimal?> _compSideSRPPaidOut;
        public decimal? CompSideSRPPaidOut { get { return _compSideSRPPaidOut; } set { _compSideSRPPaidOut = value; } }
        private Value<string> _compSideTradeGuid;
        public string CompSideTradeGuid { get { return _compSideTradeGuid; } set { _compSideTradeGuid = value; } }
        private Value<string> _compSideTradeNumber;
        public string CompSideTradeNumber { get { return _compSideTradeNumber; } set { _compSideTradeNumber = value; } }
        private Value<string> _confirmedBy;
        public string ConfirmedBy { get { return _confirmedBy; } set { _confirmedBy = value; } }
        private Value<DateTime?> _confirmedDate;
        public DateTime? ConfirmedDate { get { return _confirmedDate; } set { _confirmedDate = value; } }
        private Value<DateTime?> _corporateApprovalDate;
        public DateTime? CorporateApprovalDate { get { return _corporateApprovalDate; } set { _corporateApprovalDate = value; } }
        private Value<string> _corporateApprovedby;
        public string CorporateApprovedby { get { return _corporateApprovedby; } set { _corporateApprovedby = value; } }
        private Value<decimal?> _corporatePrice;
        public decimal? CorporatePrice { get { return _corporatePrice; } set { _corporatePrice = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount1;
        public decimal? CorrespondentAdditionalLineAmount1 { get { return _correspondentAdditionalLineAmount1; } set { _correspondentAdditionalLineAmount1 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount10;
        public decimal? CorrespondentAdditionalLineAmount10 { get { return _correspondentAdditionalLineAmount10; } set { _correspondentAdditionalLineAmount10 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount11;
        public decimal? CorrespondentAdditionalLineAmount11 { get { return _correspondentAdditionalLineAmount11; } set { _correspondentAdditionalLineAmount11 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount12;
        public decimal? CorrespondentAdditionalLineAmount12 { get { return _correspondentAdditionalLineAmount12; } set { _correspondentAdditionalLineAmount12 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount13;
        public decimal? CorrespondentAdditionalLineAmount13 { get { return _correspondentAdditionalLineAmount13; } set { _correspondentAdditionalLineAmount13 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount2;
        public decimal? CorrespondentAdditionalLineAmount2 { get { return _correspondentAdditionalLineAmount2; } set { _correspondentAdditionalLineAmount2 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount3;
        public decimal? CorrespondentAdditionalLineAmount3 { get { return _correspondentAdditionalLineAmount3; } set { _correspondentAdditionalLineAmount3 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount4;
        public decimal? CorrespondentAdditionalLineAmount4 { get { return _correspondentAdditionalLineAmount4; } set { _correspondentAdditionalLineAmount4 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount5;
        public decimal? CorrespondentAdditionalLineAmount5 { get { return _correspondentAdditionalLineAmount5; } set { _correspondentAdditionalLineAmount5 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount6;
        public decimal? CorrespondentAdditionalLineAmount6 { get { return _correspondentAdditionalLineAmount6; } set { _correspondentAdditionalLineAmount6 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount7;
        public decimal? CorrespondentAdditionalLineAmount7 { get { return _correspondentAdditionalLineAmount7; } set { _correspondentAdditionalLineAmount7 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount8;
        public decimal? CorrespondentAdditionalLineAmount8 { get { return _correspondentAdditionalLineAmount8; } set { _correspondentAdditionalLineAmount8 = value; } }
        private Value<decimal?> _correspondentAdditionalLineAmount9;
        public decimal? CorrespondentAdditionalLineAmount9 { get { return _correspondentAdditionalLineAmount9; } set { _correspondentAdditionalLineAmount9 = value; } }
        private Value<string> _correspondentAdditionalLineDescription1;
        public string CorrespondentAdditionalLineDescription1 { get { return _correspondentAdditionalLineDescription1; } set { _correspondentAdditionalLineDescription1 = value; } }
        private Value<string> _correspondentAdditionalLineDescription10;
        public string CorrespondentAdditionalLineDescription10 { get { return _correspondentAdditionalLineDescription10; } set { _correspondentAdditionalLineDescription10 = value; } }
        private Value<string> _correspondentAdditionalLineDescription11;
        public string CorrespondentAdditionalLineDescription11 { get { return _correspondentAdditionalLineDescription11; } set { _correspondentAdditionalLineDescription11 = value; } }
        private Value<string> _correspondentAdditionalLineDescription12;
        public string CorrespondentAdditionalLineDescription12 { get { return _correspondentAdditionalLineDescription12; } set { _correspondentAdditionalLineDescription12 = value; } }
        private Value<string> _correspondentAdditionalLineDescription2;
        public string CorrespondentAdditionalLineDescription2 { get { return _correspondentAdditionalLineDescription2; } set { _correspondentAdditionalLineDescription2 = value; } }
        private Value<string> _correspondentAdditionalLineDescription3;
        public string CorrespondentAdditionalLineDescription3 { get { return _correspondentAdditionalLineDescription3; } set { _correspondentAdditionalLineDescription3 = value; } }
        private Value<string> _correspondentAdditionalLineDescription4;
        public string CorrespondentAdditionalLineDescription4 { get { return _correspondentAdditionalLineDescription4; } set { _correspondentAdditionalLineDescription4 = value; } }
        private Value<string> _correspondentAdditionalLineDescription5;
        public string CorrespondentAdditionalLineDescription5 { get { return _correspondentAdditionalLineDescription5; } set { _correspondentAdditionalLineDescription5 = value; } }
        private Value<string> _correspondentAdditionalLineDescription6;
        public string CorrespondentAdditionalLineDescription6 { get { return _correspondentAdditionalLineDescription6; } set { _correspondentAdditionalLineDescription6 = value; } }
        private Value<string> _correspondentAdditionalLineDescription7;
        public string CorrespondentAdditionalLineDescription7 { get { return _correspondentAdditionalLineDescription7; } set { _correspondentAdditionalLineDescription7 = value; } }
        private Value<string> _correspondentAdditionalLineDescription8;
        public string CorrespondentAdditionalLineDescription8 { get { return _correspondentAdditionalLineDescription8; } set { _correspondentAdditionalLineDescription8 = value; } }
        private Value<string> _correspondentAdditionalLineDescription9;
        public string CorrespondentAdditionalLineDescription9 { get { return _correspondentAdditionalLineDescription9; } set { _correspondentAdditionalLineDescription9 = value; } }
        private Value<decimal?> _correspondentAdditionalLineTotalAmount;
        public decimal? CorrespondentAdditionalLineTotalAmount { get { return _correspondentAdditionalLineTotalAmount; } set { _correspondentAdditionalLineTotalAmount = value; } }
        private Value<decimal?> _correspondentAdjusterAmount1;
        public decimal? CorrespondentAdjusterAmount1 { get { return _correspondentAdjusterAmount1; } set { _correspondentAdjusterAmount1 = value; } }
        private Value<decimal?> _correspondentAdjusterAmount2;
        public decimal? CorrespondentAdjusterAmount2 { get { return _correspondentAdjusterAmount2; } set { _correspondentAdjusterAmount2 = value; } }
        private Value<decimal?> _correspondentAdjusterAmount3;
        public decimal? CorrespondentAdjusterAmount3 { get { return _correspondentAdjusterAmount3; } set { _correspondentAdjusterAmount3 = value; } }
        private Value<string> _correspondentAdjusterDescription1;
        public string CorrespondentAdjusterDescription1 { get { return _correspondentAdjusterDescription1; } set { _correspondentAdjusterDescription1 = value; } }
        private Value<string> _correspondentAdjusterDescription2;
        public string CorrespondentAdjusterDescription2 { get { return _correspondentAdjusterDescription2; } set { _correspondentAdjusterDescription2 = value; } }
        private Value<string> _correspondentAdjusterDescription3;
        public string CorrespondentAdjusterDescription3 { get { return _correspondentAdjusterDescription3; } set { _correspondentAdjusterDescription3 = value; } }
        private Value<string> _correspondentConfirmedBy;
        public string CorrespondentConfirmedBy { get { return _correspondentConfirmedBy; } set { _correspondentConfirmedBy = value; } }
        private Value<DateTime?> _correspondentConfirmedDate;
        public DateTime? CorrespondentConfirmedDate { get { return _correspondentConfirmedDate; } set { _correspondentConfirmedDate = value; } }
        private Value<decimal?> _correspondentCurrentImpounds;
        public decimal? CorrespondentCurrentImpounds { get { return _correspondentCurrentImpounds; } set { _correspondentCurrentImpounds = value; } }
        private Value<decimal?> _correspondentCurrentPrincipal;
        public decimal? CorrespondentCurrentPrincipal { get { return _correspondentCurrentPrincipal; } set { _correspondentCurrentPrincipal = value; } }
        private Value<DateTime?> _correspondentDate;
        public DateTime? CorrespondentDate { get { return _correspondentDate; } set { _correspondentDate = value; } }
        private Value<decimal?> _correspondentFinalBuyAmount;
        public decimal? CorrespondentFinalBuyAmount { get { return _correspondentFinalBuyAmount; } set { _correspondentFinalBuyAmount = value; } }
        private Value<decimal?> _correspondentFinalBuyPrice;
        public decimal? CorrespondentFinalBuyPrice { get { return _correspondentFinalBuyPrice; } set { _correspondentFinalBuyPrice = value; } }
        private Value<DateTime?> _correspondentFirstPaymentDate;
        public DateTime? CorrespondentFirstPaymentDate { get { return _correspondentFirstPaymentDate; } set { _correspondentFirstPaymentDate = value; } }
        private Value<decimal?> _correspondentImpounds;
        public decimal? CorrespondentImpounds { get { return _correspondentImpounds; } set { _correspondentImpounds = value; } }
        private Value<decimal?> _correspondentInterest;
        public decimal? CorrespondentInterest { get { return _correspondentInterest; } set { _correspondentInterest = value; } }
        private Value<int?> _correspondentInterestDays;
        public int? CorrespondentInterestDays { get { return _correspondentInterestDays; } set { _correspondentInterestDays = value; } }
        private Value<decimal?> _correspondentLateFeeAmount;
        public decimal? CorrespondentLateFeeAmount { get { return _correspondentLateFeeAmount; } set { _correspondentLateFeeAmount = value; } }
        private Value<decimal?> _correspondentLateFeePriceAdjustment;
        public decimal? CorrespondentLateFeePriceAdjustment { get { return _correspondentLateFeePriceAdjustment; } set { _correspondentLateFeePriceAdjustment = value; } }
        private Value<DateTime?> _correspondentPaidToDate;
        public DateTime? CorrespondentPaidToDate { get { return _correspondentPaidToDate; } set { _correspondentPaidToDate = value; } }
        private Value<decimal?> _correspondentPurchasedPrincipal;
        public decimal? CorrespondentPurchasedPrincipal { get { return _correspondentPurchasedPrincipal; } set { _correspondentPurchasedPrincipal = value; } }
        private Value<string> _correspondentReconcilationComments;
        public string CorrespondentReconcilationComments { get { return _correspondentReconcilationComments; } set { _correspondentReconcilationComments = value; } }
        private Value<decimal?> _correspondentRemainingBuydownAmount;
        public decimal? CorrespondentRemainingBuydownAmount { get { return _correspondentRemainingBuydownAmount; } set { _correspondentRemainingBuydownAmount = value; } }
        private Value<decimal?> _correspondentSRPAmount;
        public decimal? CorrespondentSRPAmount { get { return _correspondentSRPAmount; } set { _correspondentSRPAmount = value; } }
        private Value<string> _correspondentWarehouseBankABANum;
        public string CorrespondentWarehouseBankABANum { get { return _correspondentWarehouseBankABANum; } set { _correspondentWarehouseBankABANum = value; } }
        private Value<string> _correspondentWarehouseBankAcctNum;
        public string CorrespondentWarehouseBankAcctNum { get { return _correspondentWarehouseBankAcctNum; } set { _correspondentWarehouseBankAcctNum = value; } }
        private Value<string> _correspondentWarehouseBankAddress;
        public string CorrespondentWarehouseBankAddress { get { return _correspondentWarehouseBankAddress; } set { _correspondentWarehouseBankAddress = value; } }
        private Value<string> _correspondentWarehouseBankAddress1;
        public string CorrespondentWarehouseBankAddress1 { get { return _correspondentWarehouseBankAddress1; } set { _correspondentWarehouseBankAddress1 = value; } }
        private Value<DateTime?> _correspondentWarehouseBankBaileeExpirationDate;
        public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get { return _correspondentWarehouseBankBaileeExpirationDate; } set { _correspondentWarehouseBankBaileeExpirationDate = value; } }
        private Value<bool?> _correspondentWarehouseBankBaileeLetterReceivedIndicator;
        public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get { return _correspondentWarehouseBankBaileeLetterReceivedIndicator; } set { _correspondentWarehouseBankBaileeLetterReceivedIndicator = value; } }
        private Value<bool?> _correspondentWarehouseBankBaileeLetterReqIndicator;
        public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get { return _correspondentWarehouseBankBaileeLetterReqIndicator; } set { _correspondentWarehouseBankBaileeLetterReqIndicator = value; } }
        private Value<string> _correspondentWarehouseBankCity;
        public string CorrespondentWarehouseBankCity { get { return _correspondentWarehouseBankCity; } set { _correspondentWarehouseBankCity = value; } }
        private Value<string> _correspondentWarehouseBankContactEmail;
        public string CorrespondentWarehouseBankContactEmail { get { return _correspondentWarehouseBankContactEmail; } set { _correspondentWarehouseBankContactEmail = value; } }
        private Value<string> _correspondentWarehouseBankContactFax;
        public string CorrespondentWarehouseBankContactFax { get { return _correspondentWarehouseBankContactFax; } set { _correspondentWarehouseBankContactFax = value; } }
        private Value<string> _correspondentWarehouseBankContactName;
        public string CorrespondentWarehouseBankContactName { get { return _correspondentWarehouseBankContactName; } set { _correspondentWarehouseBankContactName = value; } }
        private Value<string> _correspondentWarehouseBankContactPhone;
        public string CorrespondentWarehouseBankContactPhone { get { return _correspondentWarehouseBankContactPhone; } set { _correspondentWarehouseBankContactPhone = value; } }
        private Value<string> _correspondentWarehouseBankDescription;
        public string CorrespondentWarehouseBankDescription { get { return _correspondentWarehouseBankDescription; } set { _correspondentWarehouseBankDescription = value; } }
        private Value<int?> _correspondentWarehouseBankId;
        public int? CorrespondentWarehouseBankId { get { return _correspondentWarehouseBankId; } set { _correspondentWarehouseBankId = value; } }
        private Value<string> _correspondentWarehouseBankName;
        public string CorrespondentWarehouseBankName { get { return _correspondentWarehouseBankName; } set { _correspondentWarehouseBankName = value; } }
        private Value<string> _correspondentWarehouseBankNotes;
        public string CorrespondentWarehouseBankNotes { get { return _correspondentWarehouseBankNotes; } set { _correspondentWarehouseBankNotes = value; } }
        private Value<bool?> _correspondentWarehouseBankSelfFunderIndicator;
        public bool? CorrespondentWarehouseBankSelfFunderIndicator { get { return _correspondentWarehouseBankSelfFunderIndicator; } set { _correspondentWarehouseBankSelfFunderIndicator = value; } }
        private Value<string> _correspondentWarehouseBankState;
        public string CorrespondentWarehouseBankState { get { return _correspondentWarehouseBankState; } set { _correspondentWarehouseBankState = value; } }
        private Value<bool?> _correspondentWarehouseBankTriPartyContractIndicator;
        public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get { return _correspondentWarehouseBankTriPartyContractIndicator; } set { _correspondentWarehouseBankTriPartyContractIndicator = value; } }
        private Value<bool?> _correspondentWarehouseBankUseDefaultContactIndicator;
        public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get { return _correspondentWarehouseBankUseDefaultContactIndicator; } set { _correspondentWarehouseBankUseDefaultContactIndicator = value; } }
        private Value<bool?> _correspondentWarehouseBankWireInstructionsReceivedIndicator;
        public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get { return _correspondentWarehouseBankWireInstructionsReceivedIndicator; } set { _correspondentWarehouseBankWireInstructionsReceivedIndicator = value; } }
        private Value<string> _correspondentWarehouseBankZip;
        public string CorrespondentWarehouseBankZip { get { return _correspondentWarehouseBankZip; } set { _correspondentWarehouseBankZip = value; } }
        private Value<string> _creditScoreToUse;
        public string CreditScoreToUse { get { return _creditScoreToUse; } set { _creditScoreToUse = value; } }
        private Value<int?> _cumulatedDaystoExtend;
        public int? CumulatedDaystoExtend { get { return _cumulatedDaystoExtend; } set { _cumulatedDaystoExtend = value; } }
        private Value<List<PriceAdjustment>> _currentAdjustments;
        public List<PriceAdjustment> CurrentAdjustments { get { return _currentAdjustments; } set { _currentAdjustments = value; } }
        private Value<string> _currentComments;
        public string CurrentComments { get { return _currentComments; } set { _currentComments = value; } }
        private Value<DateTime?> _currentLockDate;
        public DateTime? CurrentLockDate { get { return _currentLockDate; } set { _currentLockDate = value; } }
        private Value<DateTime?> _currentLockExpires;
        public DateTime? CurrentLockExpires { get { return _currentLockExpires; } set { _currentLockExpires = value; } }
        private Value<decimal?> _currentMarginRate;
        public decimal? CurrentMarginRate { get { return _currentMarginRate; } set { _currentMarginRate = value; } }
        private Value<decimal?> _currentMarginRateRequested;
        public decimal? CurrentMarginRateRequested { get { return _currentMarginRateRequested; } set { _currentMarginRateRequested = value; } }
        private Value<decimal?> _currentMarginTotalAdjustment;
        public decimal? CurrentMarginTotalAdjustment { get { return _currentMarginTotalAdjustment; } set { _currentMarginTotalAdjustment = value; } }
        private Value<int?> _currentNumberOfDays;
        public int? CurrentNumberOfDays { get { return _currentNumberOfDays; } set { _currentNumberOfDays = value; } }
        private Value<decimal?> _currentPriceRate;
        public decimal? CurrentPriceRate { get { return _currentPriceRate; } set { _currentPriceRate = value; } }
        private Value<decimal?> _currentPriceRateRequested;
        public decimal? CurrentPriceRateRequested { get { return _currentPriceRateRequested; } set { _currentPriceRateRequested = value; } }
        private Value<decimal?> _currentPriceTotalAdjustment;
        public decimal? CurrentPriceTotalAdjustment { get { return _currentPriceTotalAdjustment; } set { _currentPriceTotalAdjustment = value; } }
        private Value<decimal?> _currentRate;
        public decimal? CurrentRate { get { return _currentRate; } set { _currentRate = value; } }
        private Value<decimal?> _currentRateRequested;
        public decimal? CurrentRateRequested { get { return _currentRateRequested; } set { _currentRateRequested = value; } }
        private Value<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get { return _currentRateSetDate; } set { _currentRateSetDate = value; } }
        private Value<string> _currentRateSheetID;
        public string CurrentRateSheetID { get { return _currentRateSheetID; } set { _currentRateSheetID = value; } }
        private Value<decimal?> _currentRateTotalAdjustment;
        public decimal? CurrentRateTotalAdjustment { get { return _currentRateTotalAdjustment; } set { _currentRateTotalAdjustment = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<DateTime?> _dateFirstPaymentToInvestor;
        public DateTime? DateFirstPaymentToInvestor { get { return _dateFirstPaymentToInvestor; } set { _dateFirstPaymentToInvestor = value; } }
        private Value<DateTime?> _dateLockedWithInvestor;
        public DateTime? DateLockedWithInvestor { get { return _dateLockedWithInvestor; } set { _dateLockedWithInvestor = value; } }
        private Value<DateTime?> _dateSold;
        public DateTime? DateSold { get { return _dateSold; } set { _dateSold = value; } }
        private Value<DateTime?> _dateWarehoused;
        public DateTime? DateWarehoused { get { return _dateWarehoused; } set { _dateWarehoused = value; } }
        private Value<int?> _daysToExtend;
        public int? DaysToExtend { get { return _daysToExtend; } set { _daysToExtend = value; } }
        private Value<string> _deliveryType;
        public string DeliveryType { get { return _deliveryType; } set { _deliveryType = value; } }
        private Value<decimal?> _diffAmountReceived;
        public decimal? DiffAmountReceived { get { return _diffAmountReceived; } set { _diffAmountReceived = value; } }
        private Value<decimal?> _diffImpounds;
        public decimal? DiffImpounds { get { return _diffImpounds; } set { _diffImpounds = value; } }
        private Value<decimal?> _diffInterest;
        public decimal? DiffInterest { get { return _diffInterest; } set { _diffInterest = value; } }
        private Value<decimal?> _diffPremium;
        public decimal? DiffPremium { get { return _diffPremium; } set { _diffPremium = value; } }
        private Value<decimal?> _diffPrinciple;
        public decimal? DiffPrinciple { get { return _diffPrinciple; } set { _diffPrinciple = value; } }
        private Value<decimal?> _diffRemainingBuydownFunds;
        public decimal? DiffRemainingBuydownFunds { get { return _diffRemainingBuydownFunds; } set { _diffRemainingBuydownFunds = value; } }
        private Value<decimal?> _diffSellAmount;
        public decimal? DiffSellAmount { get { return _diffSellAmount; } set { _diffSellAmount = value; } }
        private Value<decimal?> _diffSellPrice;
        public decimal? DiffSellPrice { get { return _diffSellPrice; } set { _diffSellPrice = value; } }
        private Value<decimal?> _diffSellSideSRP;
        public decimal? DiffSellSideSRP { get { return _diffSellSideSRP; } set { _diffSellSideSRP = value; } }
        private Value<decimal?> _diffSRP;
        public decimal? DiffSRP { get { return _diffSRP; } set { _diffSRP = value; } }
        private Value<decimal?> _diffSRPAmount;
        public decimal? DiffSRPAmount { get { return _diffSRPAmount; } set { _diffSRPAmount = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator1;
        public bool? EmploymentBorrowerSelfEmployedIndicator1 { get { return _employmentBorrowerSelfEmployedIndicator1; } set { _employmentBorrowerSelfEmployedIndicator1 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator10;
        public bool? EmploymentBorrowerSelfEmployedIndicator10 { get { return _employmentBorrowerSelfEmployedIndicator10; } set { _employmentBorrowerSelfEmployedIndicator10 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator11;
        public bool? EmploymentBorrowerSelfEmployedIndicator11 { get { return _employmentBorrowerSelfEmployedIndicator11; } set { _employmentBorrowerSelfEmployedIndicator11 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator12;
        public bool? EmploymentBorrowerSelfEmployedIndicator12 { get { return _employmentBorrowerSelfEmployedIndicator12; } set { _employmentBorrowerSelfEmployedIndicator12 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator2;
        public bool? EmploymentBorrowerSelfEmployedIndicator2 { get { return _employmentBorrowerSelfEmployedIndicator2; } set { _employmentBorrowerSelfEmployedIndicator2 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator3;
        public bool? EmploymentBorrowerSelfEmployedIndicator3 { get { return _employmentBorrowerSelfEmployedIndicator3; } set { _employmentBorrowerSelfEmployedIndicator3 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator4;
        public bool? EmploymentBorrowerSelfEmployedIndicator4 { get { return _employmentBorrowerSelfEmployedIndicator4; } set { _employmentBorrowerSelfEmployedIndicator4 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator5;
        public bool? EmploymentBorrowerSelfEmployedIndicator5 { get { return _employmentBorrowerSelfEmployedIndicator5; } set { _employmentBorrowerSelfEmployedIndicator5 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator6;
        public bool? EmploymentBorrowerSelfEmployedIndicator6 { get { return _employmentBorrowerSelfEmployedIndicator6; } set { _employmentBorrowerSelfEmployedIndicator6 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator7;
        public bool? EmploymentBorrowerSelfEmployedIndicator7 { get { return _employmentBorrowerSelfEmployedIndicator7; } set { _employmentBorrowerSelfEmployedIndicator7 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator8;
        public bool? EmploymentBorrowerSelfEmployedIndicator8 { get { return _employmentBorrowerSelfEmployedIndicator8; } set { _employmentBorrowerSelfEmployedIndicator8 = value; } }
        private Value<bool?> _employmentBorrowerSelfEmployedIndicator9;
        public bool? EmploymentBorrowerSelfEmployedIndicator9 { get { return _employmentBorrowerSelfEmployedIndicator9; } set { _employmentBorrowerSelfEmployedIndicator9 = value; } }
        private Value<decimal?> _expectedAmountReceived;
        public decimal? ExpectedAmountReceived { get { return _expectedAmountReceived; } set { _expectedAmountReceived = value; } }
        private Value<decimal?> _expectedImpounds;
        public decimal? ExpectedImpounds { get { return _expectedImpounds; } set { _expectedImpounds = value; } }
        private Value<decimal?> _expectedInterest;
        public decimal? ExpectedInterest { get { return _expectedInterest; } set { _expectedInterest = value; } }
        private Value<decimal?> _expectedPremium;
        public decimal? ExpectedPremium { get { return _expectedPremium; } set { _expectedPremium = value; } }
        private Value<decimal?> _expectedPrinciple;
        public decimal? ExpectedPrinciple { get { return _expectedPrinciple; } set { _expectedPrinciple = value; } }
        private Value<decimal?> _expectedRemainingBuydownFunds;
        public decimal? ExpectedRemainingBuydownFunds { get { return _expectedRemainingBuydownFunds; } set { _expectedRemainingBuydownFunds = value; } }
        private Value<decimal?> _expectedSRP;
        public decimal? ExpectedSRP { get { return _expectedSRP; } set { _expectedSRP = value; } }
        private Value<string> _extensionRequestPending;
        public string ExtensionRequestPending { get { return _extensionRequestPending; } set { _extensionRequestPending = value; } }
        private Value<int?> _extensionSequenceNumber;
        public int? ExtensionSequenceNumber { get { return _extensionSequenceNumber; } set { _extensionSequenceNumber = value; } }
        private Value<decimal?> _fHAUpfrontMIPremiumPercent;
        public decimal? FHAUpfrontMIPremiumPercent { get { return _fHAUpfrontMIPremiumPercent; } set { _fHAUpfrontMIPremiumPercent = value; } }
        private Value<int?> _financedNumberOfUnits;
        public int? FinancedNumberOfUnits { get { return _financedNumberOfUnits; } set { _financedNumberOfUnits = value; } }
        private Value<string> _firstPaymenTo;
        public string FirstPaymenTo { get { return _firstPaymenTo; } set { _firstPaymenTo = value; } }
        private Value<decimal?> _firstSubordinateAmount;
        public decimal? FirstSubordinateAmount { get { return _firstSubordinateAmount; } set { _firstSubordinateAmount = value; } }
        private Value<bool?> _firstTimeHomebuyersIndicator;
        public bool? FirstTimeHomebuyersIndicator { get { return _firstTimeHomebuyersIndicator; } set { _firstTimeHomebuyersIndicator = value; } }
        private Value<string> _fNMProductPlanIdentifier;
        public string FNMProductPlanIdentifier { get { return _fNMProductPlanIdentifier; } set { _fNMProductPlanIdentifier = value; } }
        private Value<decimal?> _fundingAmount;
        public decimal? FundingAmount { get { return _fundingAmount; } set { _fundingAmount = value; } }
        private Value<decimal?> _gainLossPercentage;
        public decimal? GainLossPercentage { get { return _gainLossPercentage; } set { _gainLossPercentage = value; } }
        private Value<decimal?> _gainLossPrice;
        public decimal? GainLossPrice { get { return _gainLossPrice; } set { _gainLossPrice = value; } }
        private Value<decimal?> _gainLossTotalBuyPrice;
        public decimal? GainLossTotalBuyPrice { get { return _gainLossTotalBuyPrice; } set { _gainLossTotalBuyPrice = value; } }
        private Value<decimal?> _gPMRate;
        public decimal? GPMRate { get { return _gPMRate; } set { _gPMRate = value; } }
        private Value<int?> _gPMYears;
        public int? GPMYears { get { return _gPMYears; } set { _gPMYears = value; } }
        private Value<string> _gSEPropertyType;
        public string GSEPropertyType { get { return _gSEPropertyType; } set { _gSEPropertyType = value; } }
        private Value<string> _hedging;
        public string Hedging { get { return _hedging; } set { _hedging = value; } }
        private Value<string> _hELOCActualBalance;
        public string HELOCActualBalance { get { return _hELOCActualBalance; } set { _hELOCActualBalance = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _impounds;
        public decimal? Impounds { get { return _impounds; } set { _impounds = value; } }
        private Value<string> _impoundType;
        public string ImpoundType { get { return _impoundType; } set { _impoundType = value; } }
        private Value<string> _impoundWavied;
        public string ImpoundWavied { get { return _impoundWavied; } set { _impoundWavied = value; } }
        private Value<decimal?> _interest;
        public decimal? Interest { get { return _interest; } set { _interest = value; } }
        private Value<string> _investorAddress;
        public string InvestorAddress { get { return _investorAddress; } set { _investorAddress = value; } }
        private Value<string> _investorCity;
        public string InvestorCity { get { return _investorCity; } set { _investorCity = value; } }
        private Value<string> _investorCommitment;
        public string InvestorCommitment { get { return _investorCommitment; } set { _investorCommitment = value; } }
        private Value<string> _investorContact;
        public string InvestorContact { get { return _investorContact; } set { _investorContact = value; } }
        private Value<DateTime?> _investorDeliveryDate;
        public DateTime? InvestorDeliveryDate { get { return _investorDeliveryDate; } set { _investorDeliveryDate = value; } }
        private Value<string> _investorEmail;
        public string InvestorEmail { get { return _investorEmail; } set { _investorEmail = value; } }
        private Value<string> _investorLoanNumber;
        public string InvestorLoanNumber { get { return _investorLoanNumber; } set { _investorLoanNumber = value; } }
        private Value<string> _investorLockType;
        public string InvestorLockType { get { return _investorLockType; } set { _investorLockType = value; } }
        private Value<string> _investorMERSNumber;
        public string InvestorMERSNumber { get { return _investorMERSNumber; } set { _investorMERSNumber = value; } }
        private Value<string> _investorName;
        public string InvestorName { get { return _investorName; } set { _investorName = value; } }
        private Value<string> _investorPhone;
        public string InvestorPhone { get { return _investorPhone; } set { _investorPhone = value; } }
        private Value<string> _investorPostalCode;
        public string InvestorPostalCode { get { return _investorPostalCode; } set { _investorPostalCode = value; } }
        private Value<string> _investorProgramCode;
        public string InvestorProgramCode { get { return _investorProgramCode; } set { _investorProgramCode = value; } }
        private Value<string> _investorState;
        public string InvestorState { get { return _investorState; } set { _investorState = value; } }
        private Value<DateTime?> _investorTargetDeliveryDate;
        public DateTime? InvestorTargetDeliveryDate { get { return _investorTargetDeliveryDate; } set { _investorTargetDeliveryDate = value; } }
        private Value<string> _investorTemplateName;
        public string InvestorTemplateName { get { return _investorTemplateName; } set { _investorTemplateName = value; } }
        private Value<string> _investorWebsite;
        public string InvestorWebsite { get { return _investorWebsite; } set { _investorWebsite = value; } }
        private Value<string> _isCancelled;
        public string IsCancelled { get { return _isCancelled; } set { _isCancelled = value; } }
        private Value<bool?> _isDeliveryType;
        public bool? IsDeliveryType { get { return _isDeliveryType; } set { _isDeliveryType = value; } }
        private Value<bool?> _lenderPaidMortgageInsuranceIndicator;
        public bool? LenderPaidMortgageInsuranceIndicator { get { return _lenderPaidMortgageInsuranceIndicator; } set { _lenderPaidMortgageInsuranceIndicator = value; } }
        private Value<string> _lienPriorityType;
        public string LienPriorityType { get { return _lienPriorityType; } set { _lienPriorityType = value; } }
        private Value<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get { return _loanAmortizationTermMonths; } set { _loanAmortizationTermMonths = value; } }
        private Value<string> _loanAmortizationType;
        public string LoanAmortizationType { get { return _loanAmortizationType; } set { _loanAmortizationType = value; } }
        private Value<string> _loanDocumentationType;
        public string LoanDocumentationType { get { return _loanDocumentationType; } set { _loanDocumentationType = value; } }
        private Value<bool?> _loanFor203K;
        public bool? LoanFor203K { get { return _loanFor203K; } set { _loanFor203K = value; } }
        private Value<string> _loanProgram;
        public string LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        private Value<string> _loanProgramFile;
        public string LoanProgramFile { get { return _loanProgramFile; } set { _loanProgramFile = value; } }
        private Value<DateTime?> _loanScheduledClosingDate;
        public DateTime? LoanScheduledClosingDate { get { return _loanScheduledClosingDate; } set { _loanScheduledClosingDate = value; } }
        private Value<bool?> _lockField;
        public bool? LockField { get { return _lockField; } set { _lockField = value; } }
        private Value<List<PriceAdjustment>> _lockRequestAdjustments;
        public List<PriceAdjustment> LockRequestAdjustments { get { return _lockRequestAdjustments; } set { _lockRequestAdjustments = value; } }
        private Value<List<LockRequestBorrower>> _lockRequestBorrowers;
        public List<LockRequestBorrower> LockRequestBorrowers { get { return _lockRequestBorrowers; } set { _lockRequestBorrowers = value; } }
        private Value<string> _lockRequestLoanPurposeType;
        public string LockRequestLoanPurposeType { get { return _lockRequestLoanPurposeType; } set { _lockRequestLoanPurposeType = value; } }
        private Value<decimal?> _lTV;
        public decimal? LTV { get { return _lTV; } set { _lTV = value; } }
        private Value<string> _minFICO;
        public string MinFICO { get { return _minFICO; } set { _minFICO = value; } }
        private Value<string> _minFICO2;
        public string MinFICO2 { get { return _minFICO2; } set { _minFICO2 = value; } }
        private Value<decimal?> _mIPPaidInCash;
        public decimal? MIPPaidInCash { get { return _mIPPaidInCash; } set { _mIPPaidInCash = value; } }
        private Value<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        private Value<decimal?> _netSellAmount;
        public decimal? NetSellAmount { get { return _netSellAmount; } set { _netSellAmount = value; } }
        private Value<decimal?> _netSellPrice;
        public decimal? NetSellPrice { get { return _netSellPrice; } set { _netSellPrice = value; } }
        private Value<DateTime?> _nextPaymentDate;
        public DateTime? NextPaymentDate { get { return _nextPaymentDate; } set { _nextPaymentDate = value; } }
        private Value<bool?> _noClosingCostOption;
        public bool? NoClosingCostOption { get { return _noClosingCostOption; } set { _noClosingCostOption = value; } }
        private Value<string> _oNRPLock;
        public string ONRPLock { get { return _oNRPLock; } set { _oNRPLock = value; } }
        private Value<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get { return _otherAmortizationTypeDescription; } set { _otherAmortizationTypeDescription = value; } }
        private Value<decimal?> _otherSubordinateAmount;
        public decimal? OtherSubordinateAmount { get { return _otherSubordinateAmount; } set { _otherSubordinateAmount = value; } }
        private Value<string> _penaltyTerm;
        public string PenaltyTerm { get { return _penaltyTerm; } set { _penaltyTerm = value; } }
        private Value<string> _perDiemInterestRoundingType;
        public string PerDiemInterestRoundingType { get { return _perDiemInterestRoundingType; } set { _perDiemInterestRoundingType = value; } }
        private Value<string> _planCode;
        public string PlanCode { get { return _planCode; } set { _planCode = value; } }
        private Value<decimal?> _premium;
        public decimal? Premium { get { return _premium; } set { _premium = value; } }
        private Value<string> _prepayPenalty;
        public string PrepayPenalty { get { return _prepayPenalty; } set { _prepayPenalty = value; } }
        private Value<decimal?> _priceAdjustment;
        public decimal? PriceAdjustment { get { return _priceAdjustment; } set { _priceAdjustment = value; } }
        private Value<List<PriceAdjustment>> _priceAdjustments;
        public List<PriceAdjustment> PriceAdjustments { get { return _priceAdjustments; } set { _priceAdjustments = value; } }
        private Value<string> _pricingHistoryData;
        public string PricingHistoryData { get { return _pricingHistoryData; } set { _pricingHistoryData = value; } }
        private Value<string> _pricingUpdated;
        public string PricingUpdated { get { return _pricingUpdated; } set { _pricingUpdated = value; } }
        private Value<decimal?> _principle;
        public decimal? Principle { get { return _principle; } set { _principle = value; } }
        private Value<decimal?> _profitMarginAdjustedBuyPrice;
        public decimal? ProfitMarginAdjustedBuyPrice { get { return _profitMarginAdjustedBuyPrice; } set { _profitMarginAdjustedBuyPrice = value; } }
        private Value<int?> _propertyAppraisedValueAmount;
        public int? PropertyAppraisedValueAmount { get { return _propertyAppraisedValueAmount; } set { _propertyAppraisedValueAmount = value; } }
        private Value<int?> _propertyEstimatedValueAmount;
        public int? PropertyEstimatedValueAmount { get { return _propertyEstimatedValueAmount; } set { _propertyEstimatedValueAmount = value; } }
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private Value<int?> _purchaseAdviceNumberOfDays;
        public int? PurchaseAdviceNumberOfDays { get { return _purchaseAdviceNumberOfDays; } set { _purchaseAdviceNumberOfDays = value; } }
        private Value<List<PurchaseAdvicePayout>> _purchaseAdvicePayouts;
        public List<PurchaseAdvicePayout> PurchaseAdvicePayouts { get { return _purchaseAdvicePayouts; } set { _purchaseAdvicePayouts = value; } }
        private Value<decimal?> _purchasePriceAmount;
        public decimal? PurchasePriceAmount { get { return _purchasePriceAmount; } set { _purchasePriceAmount = value; } }
        private Value<string> _rateRequestStatus;
        public string RateRequestStatus { get { return _rateRequestStatus; } set { _rateRequestStatus = value; } }
        private Value<string> _rateStatus;
        public string RateStatus { get { return _rateStatus; } set { _rateStatus = value; } }
        private Value<string> _reasonforBranchApproval;
        public string ReasonforBranchApproval { get { return _reasonforBranchApproval; } set { _reasonforBranchApproval = value; } }
        private Value<string> _reasonforCorporateApproval;
        public string ReasonforCorporateApproval { get { return _reasonforCorporateApproval; } set { _reasonforCorporateApproval = value; } }
        private Value<decimal?> _reconciledDiff;
        public decimal? ReconciledDiff { get { return _reconciledDiff; } set { _reconciledDiff = value; } }
        private Value<string> _reLockRequestPending;
        public string ReLockRequestPending { get { return _reLockRequestPending; } set { _reLockRequestPending = value; } }
        private Value<decimal?> _remainingBuydownFunds;
        public decimal? RemainingBuydownFunds { get { return _remainingBuydownFunds; } set { _remainingBuydownFunds = value; } }
        private Value<string> _requestComments;
        public string RequestComments { get { return _requestComments; } set { _requestComments = value; } }
        private Value<DateTime?> _requestCurrentRateSetDate;
        public DateTime? RequestCurrentRateSetDate { get { return _requestCurrentRateSetDate; } set { _requestCurrentRateSetDate = value; } }
        private Value<int?> _requestDaystoExtend;
        public int? RequestDaystoExtend { get { return _requestDaystoExtend; } set { _requestDaystoExtend = value; } }
        private Value<DateTime?> _requestExtendedLockExpires;
        public DateTime? RequestExtendedLockExpires { get { return _requestExtendedLockExpires; } set { _requestExtendedLockExpires = value; } }
        private Value<string> _requestFullfilledDateTime;
        public string RequestFullfilledDateTime { get { return _requestFullfilledDateTime; } set { _requestFullfilledDateTime = value; } }
        private Value<string> _requestImpoundType;
        public string RequestImpoundType { get { return _requestImpoundType; } set { _requestImpoundType = value; } }
        private Value<string> _requestImpoundWavied;
        public string RequestImpoundWavied { get { return _requestImpoundWavied; } set { _requestImpoundWavied = value; } }
        private Value<string> _requestLockCancellationComment;
        public string RequestLockCancellationComment { get { return _requestLockCancellationComment; } set { _requestLockCancellationComment = value; } }
        private Value<DateTime?> _requestLockCancellationDate;
        public DateTime? RequestLockCancellationDate { get { return _requestLockCancellationDate; } set { _requestLockCancellationDate = value; } }
        private Value<DateTime?> _requestLockDate;
        public DateTime? RequestLockDate { get { return _requestLockDate; } set { _requestLockDate = value; } }
        private Value<DateTime?> _requestLockExpires;
        public DateTime? RequestLockExpires { get { return _requestLockExpires; } set { _requestLockExpires = value; } }
        private Value<string> _requestLockExtendComment;
        public string RequestLockExtendComment { get { return _requestLockExtendComment; } set { _requestLockExtendComment = value; } }
        private Value<decimal?> _requestLockExtendPriceAdjustment;
        public decimal? RequestLockExtendPriceAdjustment { get { return _requestLockExtendPriceAdjustment; } set { _requestLockExtendPriceAdjustment = value; } }
        private Value<string> _requestLockType;
        public string RequestLockType { get { return _requestLockType; } set { _requestLockType = value; } }
        private Value<decimal?> _requestMarginRate;
        public decimal? RequestMarginRate { get { return _requestMarginRate; } set { _requestMarginRate = value; } }
        private Value<decimal?> _requestMarginRateRequested;
        public decimal? RequestMarginRateRequested { get { return _requestMarginRateRequested; } set { _requestMarginRateRequested = value; } }
        private Value<decimal?> _requestMarginSRPPaidOut;
        public decimal? RequestMarginSRPPaidOut { get { return _requestMarginSRPPaidOut; } set { _requestMarginSRPPaidOut = value; } }
        private Value<decimal?> _requestMarginTotalAdjustment;
        public decimal? RequestMarginTotalAdjustment { get { return _requestMarginTotalAdjustment; } set { _requestMarginTotalAdjustment = value; } }
        private Value<int?> _requestNumberOfDays;
        public int? RequestNumberOfDays { get { return _requestNumberOfDays; } set { _requestNumberOfDays = value; } }
        private Value<bool?> _requestOnrpEligible;
        public bool? RequestOnrpEligible { get { return _requestOnrpEligible; } set { _requestOnrpEligible = value; } }
        private Value<DateTime?> _requestOnrpLockDate;
        public DateTime? RequestOnrpLockDate { get { return _requestOnrpLockDate; } set { _requestOnrpLockDate = value; } }
        private Value<string> _requestOnrpLockTime;
        public string RequestOnrpLockTime { get { return _requestOnrpLockTime; } set { _requestOnrpLockTime = value; } }
        private Value<DateTime?> _requestOriginalLockExpires;
        public DateTime? RequestOriginalLockExpires { get { return _requestOriginalLockExpires; } set { _requestOriginalLockExpires = value; } }
        private Value<string> _requestPenaltyTerm;
        public string RequestPenaltyTerm { get { return _requestPenaltyTerm; } set { _requestPenaltyTerm = value; } }
        private Value<string> _requestPending;
        public string RequestPending { get { return _requestPending; } set { _requestPending = value; } }
        private Value<string> _requestPrepayPenalty;
        public string RequestPrepayPenalty { get { return _requestPrepayPenalty; } set { _requestPrepayPenalty = value; } }
        private Value<decimal?> _requestPriceRate;
        public decimal? RequestPriceRate { get { return _requestPriceRate; } set { _requestPriceRate = value; } }
        private Value<decimal?> _requestPriceRateRequested;
        public decimal? RequestPriceRateRequested { get { return _requestPriceRateRequested; } set { _requestPriceRateRequested = value; } }
        private Value<decimal?> _requestPriceTotalAdjustment;
        public decimal? RequestPriceTotalAdjustment { get { return _requestPriceTotalAdjustment; } set { _requestPriceTotalAdjustment = value; } }
        private Value<decimal?> _requestRate;
        public decimal? RequestRate { get { return _requestRate; } set { _requestRate = value; } }
        private Value<decimal?> _requestRateRequested;
        public decimal? RequestRateRequested { get { return _requestRateRequested; } set { _requestRateRequested = value; } }
        private Value<string> _requestRateSheetID;
        public string RequestRateSheetID { get { return _requestRateSheetID; } set { _requestRateSheetID = value; } }
        private Value<decimal?> _requestRateTotalAdjustment;
        public decimal? RequestRateTotalAdjustment { get { return _requestRateTotalAdjustment; } set { _requestRateTotalAdjustment = value; } }
        private Value<decimal?> _requestStartingAdjPoint;
        public decimal? RequestStartingAdjPoint { get { return _requestStartingAdjPoint; } set { _requestStartingAdjPoint = value; } }
        private Value<decimal?> _requestStartingAdjRate;
        public decimal? RequestStartingAdjRate { get { return _requestStartingAdjRate; } set { _requestStartingAdjRate = value; } }
        private Value<string> _requestType;
        public string RequestType { get { return _requestType; } set { _requestType = value; } }
        private Value<decimal?> _requestUnDiscountedRate;
        public decimal? RequestUnDiscountedRate { get { return _requestUnDiscountedRate; } set { _requestUnDiscountedRate = value; } }
        private Value<bool?> _roundToNearest50;
        public bool? RoundToNearest50 { get { return _roundToNearest50; } set { _roundToNearest50 = value; } }
        private Value<decimal?> _secondSubordinateAmount;
        public decimal? SecondSubordinateAmount { get { return _secondSubordinateAmount; } set { _secondSubordinateAmount = value; } }
        private Value<decimal?> _sellerPaidMIPremium;
        public decimal? SellerPaidMIPremium { get { return _sellerPaidMIPremium; } set { _sellerPaidMIPremium = value; } }
        private Value<List<PriceAdjustment>> _sellSideAdjustments;
        public List<PriceAdjustment> SellSideAdjustments { get { return _sellSideAdjustments; } set { _sellSideAdjustments = value; } }
        private Value<string> _sellSideComments;
        public string SellSideComments { get { return _sellSideComments; } set { _sellSideComments = value; } }
        private Value<string> _sellSideCommitmentContractNumber;
        public string SellSideCommitmentContractNumber { get { return _sellSideCommitmentContractNumber; } set { _sellSideCommitmentContractNumber = value; } }
        private Value<DateTime?> _sellSideCommitmentDate;
        public DateTime? SellSideCommitmentDate { get { return _sellSideCommitmentDate; } set { _sellSideCommitmentDate = value; } }
        private Value<DateTime?> _sellSideCurrentRateSetDate;
        public DateTime? SellSideCurrentRateSetDate { get { return _sellSideCurrentRateSetDate; } set { _sellSideCurrentRateSetDate = value; } }
        private Value<int?> _sellSideDaystoExtend;
        public int? SellSideDaystoExtend { get { return _sellSideDaystoExtend; } set { _sellSideDaystoExtend = value; } }
        private Value<decimal?> _sellSideDiscountYSP;
        public decimal? SellSideDiscountYSP { get { return _sellSideDiscountYSP; } set { _sellSideDiscountYSP = value; } }
        private Value<DateTime?> _sellSideExtendedLockExpires;
        public DateTime? SellSideExtendedLockExpires { get { return _sellSideExtendedLockExpires; } set { _sellSideExtendedLockExpires = value; } }
        private Value<decimal?> _sellSideGuaranteeFee;
        public decimal? SellSideGuaranteeFee { get { return _sellSideGuaranteeFee; } set { _sellSideGuaranteeFee = value; } }
        private Value<decimal?> _sellSideGuarantyBaseFee;
        public decimal? SellSideGuarantyBaseFee { get { return _sellSideGuarantyBaseFee; } set { _sellSideGuarantyBaseFee = value; } }
        private Value<string> _sellSideInvestorStatus;
        public string SellSideInvestorStatus { get { return _sellSideInvestorStatus; } set { _sellSideInvestorStatus = value; } }
        private Value<DateTime?> _sellSideInvestorStatusDate;
        public DateTime? SellSideInvestorStatusDate { get { return _sellSideInvestorStatusDate; } set { _sellSideInvestorStatusDate = value; } }
        private Value<string> _sellSideInvestorTradeNumber;
        public string SellSideInvestorTradeNumber { get { return _sellSideInvestorTradeNumber; } set { _sellSideInvestorTradeNumber = value; } }
        private Value<string> _sellSideLoanProgram;
        public string SellSideLoanProgram { get { return _sellSideLoanProgram; } set { _sellSideLoanProgram = value; } }
        private Value<DateTime?> _sellSideLockDate;
        public DateTime? SellSideLockDate { get { return _sellSideLockDate; } set { _sellSideLockDate = value; } }
        private Value<DateTime?> _sellSideLockExpires;
        public DateTime? SellSideLockExpires { get { return _sellSideLockExpires; } set { _sellSideLockExpires = value; } }
        private Value<decimal?> _sellSideLockExtendPriceAdjustment;
        public decimal? SellSideLockExtendPriceAdjustment { get { return _sellSideLockExtendPriceAdjustment; } set { _sellSideLockExtendPriceAdjustment = value; } }
        private Value<decimal?> _sellSideMarginNetSellRate;
        public decimal? SellSideMarginNetSellRate { get { return _sellSideMarginNetSellRate; } set { _sellSideMarginNetSellRate = value; } }
        private Value<decimal?> _sellSideMarginRate;
        public decimal? SellSideMarginRate { get { return _sellSideMarginRate; } set { _sellSideMarginRate = value; } }
        private Value<decimal?> _sellSideMarginTotalAdjustment;
        public decimal? SellSideMarginTotalAdjustment { get { return _sellSideMarginTotalAdjustment; } set { _sellSideMarginTotalAdjustment = value; } }
        private Value<string> _sellSideMasterContractNumber;
        public string SellSideMasterContractNumber { get { return _sellSideMasterContractNumber; } set { _sellSideMasterContractNumber = value; } }
        private Value<decimal?> _sellSideMSRValue;
        public decimal? SellSideMSRValue { get { return _sellSideMSRValue; } set { _sellSideMSRValue = value; } }
        private Value<decimal?> _sellSideNetSellPrice;
        public decimal? SellSideNetSellPrice { get { return _sellSideNetSellPrice; } set { _sellSideNetSellPrice = value; } }
        private Value<decimal?> _sellSideNetSellRate;
        public decimal? SellSideNetSellRate { get { return _sellSideNetSellRate; } set { _sellSideNetSellRate = value; } }
        private Value<int?> _sellSideNumberOfDays;
        public int? SellSideNumberOfDays { get { return _sellSideNumberOfDays; } set { _sellSideNumberOfDays = value; } }
        private Value<DateTime?> _sellSideOriginalLockExpires;
        public DateTime? SellSideOriginalLockExpires { get { return _sellSideOriginalLockExpires; } set { _sellSideOriginalLockExpires = value; } }
        private Value<string> _sellSidePoolID;
        public string SellSidePoolID { get { return _sellSidePoolID; } set { _sellSidePoolID = value; } }
        private Value<string> _sellSidePoolNumber;
        public string SellSidePoolNumber { get { return _sellSidePoolNumber; } set { _sellSidePoolNumber = value; } }
        private Value<decimal?> _sellSidePriceRate;
        public decimal? SellSidePriceRate { get { return _sellSidePriceRate; } set { _sellSidePriceRate = value; } }
        private Value<decimal?> _sellSidePriceTotalAdjustment;
        public decimal? SellSidePriceTotalAdjustment { get { return _sellSidePriceTotalAdjustment; } set { _sellSidePriceTotalAdjustment = value; } }
        private Value<string> _sellSideProductName;
        public string SellSideProductName { get { return _sellSideProductName; } set { _sellSideProductName = value; } }
        private Value<decimal?> _sellSideRate;
        public decimal? SellSideRate { get { return _sellSideRate; } set { _sellSideRate = value; } }
        private Value<string> _sellSideRateSheetID;
        public string SellSideRateSheetID { get { return _sellSideRateSheetID; } set { _sellSideRateSheetID = value; } }
        private Value<decimal?> _sellSideRateTotalAdjustment;
        public decimal? SellSideRateTotalAdjustment { get { return _sellSideRateTotalAdjustment; } set { _sellSideRateTotalAdjustment = value; } }
        private Value<string> _sellSideRequestedBy;
        public string SellSideRequestedBy { get { return _sellSideRequestedBy; } set { _sellSideRequestedBy = value; } }
        private Value<string> _sellSideServicer;
        public string SellSideServicer { get { return _sellSideServicer; } set { _sellSideServicer = value; } }
        private Value<decimal?> _sellSideServicingFee;
        public decimal? SellSideServicingFee { get { return _sellSideServicingFee; } set { _sellSideServicingFee = value; } }
        private Value<string> _sellSideServicingType;
        public string SellSideServicingType { get { return _sellSideServicingType; } set { _sellSideServicingType = value; } }
        private Value<decimal?> _sellSideSRP;
        public decimal? SellSideSRP { get { return _sellSideSRP; } set { _sellSideSRP = value; } }
        private Value<decimal?> _sellSideSRPPaidOut;
        public decimal? SellSideSRPPaidOut { get { return _sellSideSRPPaidOut; } set { _sellSideSRPPaidOut = value; } }
        private Value<string> _sellSideTradeGuid;
        public string SellSideTradeGuid { get { return _sellSideTradeGuid; } set { _sellSideTradeGuid = value; } }
        private Value<string> _sellSideTradeMgmtPrevConfirmedLockGuid;
        public string SellSideTradeMgmtPrevConfirmedLockGuid { get { return _sellSideTradeMgmtPrevConfirmedLockGuid; } set { _sellSideTradeMgmtPrevConfirmedLockGuid = value; } }
        private Value<string> _sellSideTradeNumber;
        public string SellSideTradeNumber { get { return _sellSideTradeNumber; } set { _sellSideTradeNumber = value; } }
        private Value<bool?> _servicingReleaseIndicator;
        public bool? ServicingReleaseIndicator { get { return _servicingReleaseIndicator; } set { _servicingReleaseIndicator = value; } }
        private Value<decimal?> _sRP;
        public decimal? SRP { get { return _sRP; } set { _sRP = value; } }
        private Value<decimal?> _sRPAmount;
        public decimal? SRPAmount { get { return _sRPAmount; } set { _sRPAmount = value; } }
        private Value<string> _subjectPropertyCity;
        public string SubjectPropertyCity { get { return _subjectPropertyCity; } set { _subjectPropertyCity = value; } }
        private Value<bool?> _subjectPropertyCondotelIndicator;
        public bool? SubjectPropertyCondotelIndicator { get { return _subjectPropertyCondotelIndicator; } set { _subjectPropertyCondotelIndicator = value; } }
        private Value<string> _subjectPropertyCounty;
        public string SubjectPropertyCounty { get { return _subjectPropertyCounty; } set { _subjectPropertyCounty = value; } }
        private Value<bool?> _subjectPropertyNonWarrantableProjectIndicator;
        public bool? SubjectPropertyNonWarrantableProjectIndicator { get { return _subjectPropertyNonWarrantableProjectIndicator; } set { _subjectPropertyNonWarrantableProjectIndicator = value; } }
        private Value<string> _subjectPropertyPostalCode;
        public string SubjectPropertyPostalCode { get { return _subjectPropertyPostalCode; } set { _subjectPropertyPostalCode = value; } }
        private Value<string> _subjectPropertyState;
        public string SubjectPropertyState { get { return _subjectPropertyState; } set { _subjectPropertyState = value; } }
        private Value<string> _subjectPropertyStreetAddress;
        public string SubjectPropertyStreetAddress { get { return _subjectPropertyStreetAddress; } set { _subjectPropertyStreetAddress = value; } }
        private Value<string> _timeLockedWithInvestor;
        public string TimeLockedWithInvestor { get { return _timeLockedWithInvestor; } set { _timeLockedWithInvestor = value; } }
        private Value<decimal?> _totalBuyPrice;
        public decimal? TotalBuyPrice { get { return _totalBuyPrice; } set { _totalBuyPrice = value; } }
        private Value<decimal?> _totalForLesserOfSumAsIs;
        public decimal? TotalForLesserOfSumAsIs { get { return _totalForLesserOfSumAsIs; } set { _totalForLesserOfSumAsIs = value; } }
        private Value<decimal?> _totalPrice;
        public decimal? TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }
        private Value<decimal?> _totalSubordinateFinancing;
        public decimal? TotalSubordinateFinancing { get { return _totalSubordinateFinancing; } set { _totalSubordinateFinancing = value; } }
        private Value<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get { return _twelveMonthMortgageRentalHistoryIndicator; } set { _twelveMonthMortgageRentalHistoryIndicator = value; } }
        private Value<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        private Value<bool?> _usePoint;
        public bool? UsePoint { get { return _usePoint; } set { _usePoint = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualSellAmount.Clean
                    && _actualSellPrice.Clean
                    && _actualSellSideSRP.Clean
                    && _actualSRPAmount.Clean
                    && _amountDue.Clean
                    && _amountDueTo.Clean
                    && _amountPaid.Clean
                    && _amountPaidTo.Clean
                    && _amountReceived.Clean
                    && _balloonLoanMaturityTermMonths.Clean
                    && _baseLoanAmount.Clean
                    && _borrowerRequestedLoanAmount.Clean
                    && _branchApprovalDate.Clean
                    && _branchApprovedby.Clean
                    && _branchPrice.Clean
                    && _buySideAdjustments.Clean
                    && _buySideComments.Clean
                    && _buySideCommitmentDate.Clean
                    && _buySideCommitmentNumber.Clean
                    && _buySideCommitmentType.Clean
                    && _buySideCurrentRateSetDate.Clean
                    && _buySideDaystoExtend.Clean
                    && _buySideDeliveryExpirationDate.Clean
                    && _buySideDeliveryType.Clean
                    && _buySideExpirationDate.Clean
                    && _buySideExtendedLockExpires.Clean
                    && _buySideLockDate.Clean
                    && _buySideLockExpires.Clean
                    && _buySideLockExtendPriceAdjustment.Clean
                    && _buySideMarginNetBuyRate.Clean
                    && _buySideMarginRate.Clean
                    && _buySideMarginTotalAdjustment.Clean
                    && _buySideMasterCommitmentNumber.Clean
                    && _buySideNumberOfDays.Clean
                    && _buySideOnrpEligible.Clean
                    && _buySideOnrpLockDate.Clean
                    && _buySideOnrpLockTime.Clean
                    && _buySideOrgID.Clean
                    && _buySideOriginalLockExpires.Clean
                    && _buySidePriceNetBuyPrice.Clean
                    && _buySidePriceRate.Clean
                    && _buySidePriceTotalAdjustment.Clean
                    && _buySideRate.Clean
                    && _buySideRateNetBuyRate.Clean
                    && _buySideRateSheetID.Clean
                    && _buySideRateTotalAdjustment.Clean
                    && _buySideRequestedBy.Clean
                    && _buySideSRPPaidOut.Clean
                    && _buySideStartingAdjPoint.Clean
                    && _buySideStartingAdjPrice.Clean
                    && _buySideStartingAdjRate.Clean
                    && _buySideTPOID.Clean
                    && _buySideTPOName.Clean
                    && _buySideTradeGuid.Clean
                    && _buySideTradeNumber.Clean
                    && _buySideUnDiscountedRate.Clean
                    && _cancellationRequestPending.Clean
                    && _combinedLTV.Clean
                    && _comments.Clean
                    && _commitment.Clean
                    && _compGainLossPercentage.Clean
                    && _compGainLossPrice.Clean
                    && _compGainLossTotalBuyPrice.Clean
                    && _compGainLossTotalCompPrice.Clean
                    && _compInvestorAddress.Clean
                    && _compInvestorCity.Clean
                    && _compInvestorCommitment.Clean
                    && _compInvestorContact.Clean
                    && _compInvestorEmail.Clean
                    && _compInvestorLockType.Clean
                    && _compInvestorName.Clean
                    && _compInvestorPhone.Clean
                    && _compInvestorPostalCode.Clean
                    && _compInvestorProgramCode.Clean
                    && _compInvestorState.Clean
                    && _compInvestorTemplateName.Clean
                    && _compInvestorWebsite.Clean
                    && _compSideAdjustments.Clean
                    && _compSideComments.Clean
                    && _compSideComparisonedBy.Clean
                    && _compSideCurrentRateSetDate.Clean
                    && _compSideDaystoExtend.Clean
                    && _compSideDiscountYSP.Clean
                    && _compSideExtendedLockExpires.Clean
                    && _compSideInvestorStatus.Clean
                    && _compSideInvestorStatusDate.Clean
                    && _compSideInvestorTradeNumber.Clean
                    && _compSideLoanProgram.Clean
                    && _compSideLockDate.Clean
                    && _compSideLockExpires.Clean
                    && _compSideLockExtendPriceAdjustment.Clean
                    && _compSideMarginNetCompRate.Clean
                    && _compSideMarginRate.Clean
                    && _compSideMarginTotalAdjustment.Clean
                    && _compSideMasterContractNumber.Clean
                    && _compSideNetCompPrice.Clean
                    && _compSideNetCompRate.Clean
                    && _compSideNumberOfDays.Clean
                    && _compSideOriginalLockExpires.Clean
                    && _compSidePriceRate.Clean
                    && _compSidePriceTotalAdjustment.Clean
                    && _compSideRate.Clean
                    && _compSideRateSheetID.Clean
                    && _compSideRateTotalAdjustment.Clean
                    && _compSideRequestedBy.Clean
                    && _compSideServicingType.Clean
                    && _compSideSRPPaidOut.Clean
                    && _compSideTradeGuid.Clean
                    && _compSideTradeNumber.Clean
                    && _confirmedBy.Clean
                    && _confirmedDate.Clean
                    && _corporateApprovalDate.Clean
                    && _corporateApprovedby.Clean
                    && _corporatePrice.Clean
                    && _correspondentAdditionalLineAmount1.Clean
                    && _correspondentAdditionalLineAmount10.Clean
                    && _correspondentAdditionalLineAmount11.Clean
                    && _correspondentAdditionalLineAmount12.Clean
                    && _correspondentAdditionalLineAmount13.Clean
                    && _correspondentAdditionalLineAmount2.Clean
                    && _correspondentAdditionalLineAmount3.Clean
                    && _correspondentAdditionalLineAmount4.Clean
                    && _correspondentAdditionalLineAmount5.Clean
                    && _correspondentAdditionalLineAmount6.Clean
                    && _correspondentAdditionalLineAmount7.Clean
                    && _correspondentAdditionalLineAmount8.Clean
                    && _correspondentAdditionalLineAmount9.Clean
                    && _correspondentAdditionalLineDescription1.Clean
                    && _correspondentAdditionalLineDescription10.Clean
                    && _correspondentAdditionalLineDescription11.Clean
                    && _correspondentAdditionalLineDescription12.Clean
                    && _correspondentAdditionalLineDescription2.Clean
                    && _correspondentAdditionalLineDescription3.Clean
                    && _correspondentAdditionalLineDescription4.Clean
                    && _correspondentAdditionalLineDescription5.Clean
                    && _correspondentAdditionalLineDescription6.Clean
                    && _correspondentAdditionalLineDescription7.Clean
                    && _correspondentAdditionalLineDescription8.Clean
                    && _correspondentAdditionalLineDescription9.Clean
                    && _correspondentAdditionalLineTotalAmount.Clean
                    && _correspondentAdjusterAmount1.Clean
                    && _correspondentAdjusterAmount2.Clean
                    && _correspondentAdjusterAmount3.Clean
                    && _correspondentAdjusterDescription1.Clean
                    && _correspondentAdjusterDescription2.Clean
                    && _correspondentAdjusterDescription3.Clean
                    && _correspondentConfirmedBy.Clean
                    && _correspondentConfirmedDate.Clean
                    && _correspondentCurrentImpounds.Clean
                    && _correspondentCurrentPrincipal.Clean
                    && _correspondentDate.Clean
                    && _correspondentFinalBuyAmount.Clean
                    && _correspondentFinalBuyPrice.Clean
                    && _correspondentFirstPaymentDate.Clean
                    && _correspondentImpounds.Clean
                    && _correspondentInterest.Clean
                    && _correspondentInterestDays.Clean
                    && _correspondentLateFeeAmount.Clean
                    && _correspondentLateFeePriceAdjustment.Clean
                    && _correspondentPaidToDate.Clean
                    && _correspondentPurchasedPrincipal.Clean
                    && _correspondentReconcilationComments.Clean
                    && _correspondentRemainingBuydownAmount.Clean
                    && _correspondentSRPAmount.Clean
                    && _correspondentWarehouseBankABANum.Clean
                    && _correspondentWarehouseBankAcctNum.Clean
                    && _correspondentWarehouseBankAddress.Clean
                    && _correspondentWarehouseBankAddress1.Clean
                    && _correspondentWarehouseBankBaileeExpirationDate.Clean
                    && _correspondentWarehouseBankBaileeLetterReceivedIndicator.Clean
                    && _correspondentWarehouseBankBaileeLetterReqIndicator.Clean
                    && _correspondentWarehouseBankCity.Clean
                    && _correspondentWarehouseBankContactEmail.Clean
                    && _correspondentWarehouseBankContactFax.Clean
                    && _correspondentWarehouseBankContactName.Clean
                    && _correspondentWarehouseBankContactPhone.Clean
                    && _correspondentWarehouseBankDescription.Clean
                    && _correspondentWarehouseBankId.Clean
                    && _correspondentWarehouseBankName.Clean
                    && _correspondentWarehouseBankNotes.Clean
                    && _correspondentWarehouseBankSelfFunderIndicator.Clean
                    && _correspondentWarehouseBankState.Clean
                    && _correspondentWarehouseBankTriPartyContractIndicator.Clean
                    && _correspondentWarehouseBankUseDefaultContactIndicator.Clean
                    && _correspondentWarehouseBankWireInstructionsReceivedIndicator.Clean
                    && _correspondentWarehouseBankZip.Clean
                    && _creditScoreToUse.Clean
                    && _cumulatedDaystoExtend.Clean
                    && _currentAdjustments.Clean
                    && _currentComments.Clean
                    && _currentLockDate.Clean
                    && _currentLockExpires.Clean
                    && _currentMarginRate.Clean
                    && _currentMarginRateRequested.Clean
                    && _currentMarginTotalAdjustment.Clean
                    && _currentNumberOfDays.Clean
                    && _currentPriceRate.Clean
                    && _currentPriceRateRequested.Clean
                    && _currentPriceTotalAdjustment.Clean
                    && _currentRate.Clean
                    && _currentRateRequested.Clean
                    && _currentRateSetDate.Clean
                    && _currentRateSheetID.Clean
                    && _currentRateTotalAdjustment.Clean
                    && _date.Clean
                    && _dateFirstPaymentToInvestor.Clean
                    && _dateLockedWithInvestor.Clean
                    && _dateSold.Clean
                    && _dateWarehoused.Clean
                    && _daysToExtend.Clean
                    && _deliveryType.Clean
                    && _diffAmountReceived.Clean
                    && _diffImpounds.Clean
                    && _diffInterest.Clean
                    && _diffPremium.Clean
                    && _diffPrinciple.Clean
                    && _diffRemainingBuydownFunds.Clean
                    && _diffSellAmount.Clean
                    && _diffSellPrice.Clean
                    && _diffSellSideSRP.Clean
                    && _diffSRP.Clean
                    && _diffSRPAmount.Clean
                    && _employmentBorrowerSelfEmployedIndicator1.Clean
                    && _employmentBorrowerSelfEmployedIndicator10.Clean
                    && _employmentBorrowerSelfEmployedIndicator11.Clean
                    && _employmentBorrowerSelfEmployedIndicator12.Clean
                    && _employmentBorrowerSelfEmployedIndicator2.Clean
                    && _employmentBorrowerSelfEmployedIndicator3.Clean
                    && _employmentBorrowerSelfEmployedIndicator4.Clean
                    && _employmentBorrowerSelfEmployedIndicator5.Clean
                    && _employmentBorrowerSelfEmployedIndicator6.Clean
                    && _employmentBorrowerSelfEmployedIndicator7.Clean
                    && _employmentBorrowerSelfEmployedIndicator8.Clean
                    && _employmentBorrowerSelfEmployedIndicator9.Clean
                    && _expectedAmountReceived.Clean
                    && _expectedImpounds.Clean
                    && _expectedInterest.Clean
                    && _expectedPremium.Clean
                    && _expectedPrinciple.Clean
                    && _expectedRemainingBuydownFunds.Clean
                    && _expectedSRP.Clean
                    && _extensionRequestPending.Clean
                    && _extensionSequenceNumber.Clean
                    && _fHAUpfrontMIPremiumPercent.Clean
                    && _financedNumberOfUnits.Clean
                    && _firstPaymenTo.Clean
                    && _firstSubordinateAmount.Clean
                    && _firstTimeHomebuyersIndicator.Clean
                    && _fNMProductPlanIdentifier.Clean
                    && _fundingAmount.Clean
                    && _gainLossPercentage.Clean
                    && _gainLossPrice.Clean
                    && _gainLossTotalBuyPrice.Clean
                    && _gPMRate.Clean
                    && _gPMYears.Clean
                    && _gSEPropertyType.Clean
                    && _hedging.Clean
                    && _hELOCActualBalance.Clean
                    && _id.Clean
                    && _impounds.Clean
                    && _impoundType.Clean
                    && _impoundWavied.Clean
                    && _interest.Clean
                    && _investorAddress.Clean
                    && _investorCity.Clean
                    && _investorCommitment.Clean
                    && _investorContact.Clean
                    && _investorDeliveryDate.Clean
                    && _investorEmail.Clean
                    && _investorLoanNumber.Clean
                    && _investorLockType.Clean
                    && _investorMERSNumber.Clean
                    && _investorName.Clean
                    && _investorPhone.Clean
                    && _investorPostalCode.Clean
                    && _investorProgramCode.Clean
                    && _investorState.Clean
                    && _investorTargetDeliveryDate.Clean
                    && _investorTemplateName.Clean
                    && _investorWebsite.Clean
                    && _isCancelled.Clean
                    && _isDeliveryType.Clean
                    && _lenderPaidMortgageInsuranceIndicator.Clean
                    && _lienPriorityType.Clean
                    && _loanAmortizationTermMonths.Clean
                    && _loanAmortizationType.Clean
                    && _loanDocumentationType.Clean
                    && _loanFor203K.Clean
                    && _loanProgram.Clean
                    && _loanProgramFile.Clean
                    && _loanScheduledClosingDate.Clean
                    && _lockField.Clean
                    && _lockRequestAdjustments.Clean
                    && _lockRequestBorrowers.Clean
                    && _lockRequestLoanPurposeType.Clean
                    && _lTV.Clean
                    && _minFICO.Clean
                    && _minFICO2.Clean
                    && _mIPPaidInCash.Clean
                    && _mortgageType.Clean
                    && _netSellAmount.Clean
                    && _netSellPrice.Clean
                    && _nextPaymentDate.Clean
                    && _noClosingCostOption.Clean
                    && _oNRPLock.Clean
                    && _otherAmortizationTypeDescription.Clean
                    && _otherSubordinateAmount.Clean
                    && _penaltyTerm.Clean
                    && _perDiemInterestRoundingType.Clean
                    && _planCode.Clean
                    && _premium.Clean
                    && _prepayPenalty.Clean
                    && _priceAdjustment.Clean
                    && _priceAdjustments.Clean
                    && _pricingHistoryData.Clean
                    && _pricingUpdated.Clean
                    && _principle.Clean
                    && _profitMarginAdjustedBuyPrice.Clean
                    && _propertyAppraisedValueAmount.Clean
                    && _propertyEstimatedValueAmount.Clean
                    && _propertyUsageType.Clean
                    && _purchaseAdviceNumberOfDays.Clean
                    && _purchaseAdvicePayouts.Clean
                    && _purchasePriceAmount.Clean
                    && _rateRequestStatus.Clean
                    && _rateStatus.Clean
                    && _reasonforBranchApproval.Clean
                    && _reasonforCorporateApproval.Clean
                    && _reconciledDiff.Clean
                    && _reLockRequestPending.Clean
                    && _remainingBuydownFunds.Clean
                    && _requestComments.Clean
                    && _requestCurrentRateSetDate.Clean
                    && _requestDaystoExtend.Clean
                    && _requestExtendedLockExpires.Clean
                    && _requestFullfilledDateTime.Clean
                    && _requestImpoundType.Clean
                    && _requestImpoundWavied.Clean
                    && _requestLockCancellationComment.Clean
                    && _requestLockCancellationDate.Clean
                    && _requestLockDate.Clean
                    && _requestLockExpires.Clean
                    && _requestLockExtendComment.Clean
                    && _requestLockExtendPriceAdjustment.Clean
                    && _requestLockType.Clean
                    && _requestMarginRate.Clean
                    && _requestMarginRateRequested.Clean
                    && _requestMarginSRPPaidOut.Clean
                    && _requestMarginTotalAdjustment.Clean
                    && _requestNumberOfDays.Clean
                    && _requestOnrpEligible.Clean
                    && _requestOnrpLockDate.Clean
                    && _requestOnrpLockTime.Clean
                    && _requestOriginalLockExpires.Clean
                    && _requestPenaltyTerm.Clean
                    && _requestPending.Clean
                    && _requestPrepayPenalty.Clean
                    && _requestPriceRate.Clean
                    && _requestPriceRateRequested.Clean
                    && _requestPriceTotalAdjustment.Clean
                    && _requestRate.Clean
                    && _requestRateRequested.Clean
                    && _requestRateSheetID.Clean
                    && _requestRateTotalAdjustment.Clean
                    && _requestStartingAdjPoint.Clean
                    && _requestStartingAdjRate.Clean
                    && _requestType.Clean
                    && _requestUnDiscountedRate.Clean
                    && _roundToNearest50.Clean
                    && _secondSubordinateAmount.Clean
                    && _sellerPaidMIPremium.Clean
                    && _sellSideAdjustments.Clean
                    && _sellSideComments.Clean
                    && _sellSideCommitmentContractNumber.Clean
                    && _sellSideCommitmentDate.Clean
                    && _sellSideCurrentRateSetDate.Clean
                    && _sellSideDaystoExtend.Clean
                    && _sellSideDiscountYSP.Clean
                    && _sellSideExtendedLockExpires.Clean
                    && _sellSideGuaranteeFee.Clean
                    && _sellSideGuarantyBaseFee.Clean
                    && _sellSideInvestorStatus.Clean
                    && _sellSideInvestorStatusDate.Clean
                    && _sellSideInvestorTradeNumber.Clean
                    && _sellSideLoanProgram.Clean
                    && _sellSideLockDate.Clean
                    && _sellSideLockExpires.Clean
                    && _sellSideLockExtendPriceAdjustment.Clean
                    && _sellSideMarginNetSellRate.Clean
                    && _sellSideMarginRate.Clean
                    && _sellSideMarginTotalAdjustment.Clean
                    && _sellSideMasterContractNumber.Clean
                    && _sellSideMSRValue.Clean
                    && _sellSideNetSellPrice.Clean
                    && _sellSideNetSellRate.Clean
                    && _sellSideNumberOfDays.Clean
                    && _sellSideOriginalLockExpires.Clean
                    && _sellSidePoolID.Clean
                    && _sellSidePoolNumber.Clean
                    && _sellSidePriceRate.Clean
                    && _sellSidePriceTotalAdjustment.Clean
                    && _sellSideProductName.Clean
                    && _sellSideRate.Clean
                    && _sellSideRateSheetID.Clean
                    && _sellSideRateTotalAdjustment.Clean
                    && _sellSideRequestedBy.Clean
                    && _sellSideServicer.Clean
                    && _sellSideServicingFee.Clean
                    && _sellSideServicingType.Clean
                    && _sellSideSRP.Clean
                    && _sellSideSRPPaidOut.Clean
                    && _sellSideTradeGuid.Clean
                    && _sellSideTradeMgmtPrevConfirmedLockGuid.Clean
                    && _sellSideTradeNumber.Clean
                    && _servicingReleaseIndicator.Clean
                    && _sRP.Clean
                    && _sRPAmount.Clean
                    && _subjectPropertyCity.Clean
                    && _subjectPropertyCondotelIndicator.Clean
                    && _subjectPropertyCounty.Clean
                    && _subjectPropertyNonWarrantableProjectIndicator.Clean
                    && _subjectPropertyPostalCode.Clean
                    && _subjectPropertyState.Clean
                    && _subjectPropertyStreetAddress.Clean
                    && _timeLockedWithInvestor.Clean
                    && _totalBuyPrice.Clean
                    && _totalForLesserOfSumAsIs.Clean
                    && _totalPrice.Clean
                    && _totalSubordinateFinancing.Clean
                    && _twelveMonthMortgageRentalHistoryIndicator.Clean
                    && _type.Clean
                    && _usePoint.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actualSellAmount; v0.Clean = value; _actualSellAmount = v0;
                var v1 = _actualSellPrice; v1.Clean = value; _actualSellPrice = v1;
                var v2 = _actualSellSideSRP; v2.Clean = value; _actualSellSideSRP = v2;
                var v3 = _actualSRPAmount; v3.Clean = value; _actualSRPAmount = v3;
                var v4 = _amountDue; v4.Clean = value; _amountDue = v4;
                var v5 = _amountDueTo; v5.Clean = value; _amountDueTo = v5;
                var v6 = _amountPaid; v6.Clean = value; _amountPaid = v6;
                var v7 = _amountPaidTo; v7.Clean = value; _amountPaidTo = v7;
                var v8 = _amountReceived; v8.Clean = value; _amountReceived = v8;
                var v9 = _balloonLoanMaturityTermMonths; v9.Clean = value; _balloonLoanMaturityTermMonths = v9;
                var v10 = _baseLoanAmount; v10.Clean = value; _baseLoanAmount = v10;
                var v11 = _borrowerRequestedLoanAmount; v11.Clean = value; _borrowerRequestedLoanAmount = v11;
                var v12 = _branchApprovalDate; v12.Clean = value; _branchApprovalDate = v12;
                var v13 = _branchApprovedby; v13.Clean = value; _branchApprovedby = v13;
                var v14 = _branchPrice; v14.Clean = value; _branchPrice = v14;
                var v15 = _buySideAdjustments; v15.Clean = value; _buySideAdjustments = v15;
                var v16 = _buySideComments; v16.Clean = value; _buySideComments = v16;
                var v17 = _buySideCommitmentDate; v17.Clean = value; _buySideCommitmentDate = v17;
                var v18 = _buySideCommitmentNumber; v18.Clean = value; _buySideCommitmentNumber = v18;
                var v19 = _buySideCommitmentType; v19.Clean = value; _buySideCommitmentType = v19;
                var v20 = _buySideCurrentRateSetDate; v20.Clean = value; _buySideCurrentRateSetDate = v20;
                var v21 = _buySideDaystoExtend; v21.Clean = value; _buySideDaystoExtend = v21;
                var v22 = _buySideDeliveryExpirationDate; v22.Clean = value; _buySideDeliveryExpirationDate = v22;
                var v23 = _buySideDeliveryType; v23.Clean = value; _buySideDeliveryType = v23;
                var v24 = _buySideExpirationDate; v24.Clean = value; _buySideExpirationDate = v24;
                var v25 = _buySideExtendedLockExpires; v25.Clean = value; _buySideExtendedLockExpires = v25;
                var v26 = _buySideLockDate; v26.Clean = value; _buySideLockDate = v26;
                var v27 = _buySideLockExpires; v27.Clean = value; _buySideLockExpires = v27;
                var v28 = _buySideLockExtendPriceAdjustment; v28.Clean = value; _buySideLockExtendPriceAdjustment = v28;
                var v29 = _buySideMarginNetBuyRate; v29.Clean = value; _buySideMarginNetBuyRate = v29;
                var v30 = _buySideMarginRate; v30.Clean = value; _buySideMarginRate = v30;
                var v31 = _buySideMarginTotalAdjustment; v31.Clean = value; _buySideMarginTotalAdjustment = v31;
                var v32 = _buySideMasterCommitmentNumber; v32.Clean = value; _buySideMasterCommitmentNumber = v32;
                var v33 = _buySideNumberOfDays; v33.Clean = value; _buySideNumberOfDays = v33;
                var v34 = _buySideOnrpEligible; v34.Clean = value; _buySideOnrpEligible = v34;
                var v35 = _buySideOnrpLockDate; v35.Clean = value; _buySideOnrpLockDate = v35;
                var v36 = _buySideOnrpLockTime; v36.Clean = value; _buySideOnrpLockTime = v36;
                var v37 = _buySideOrgID; v37.Clean = value; _buySideOrgID = v37;
                var v38 = _buySideOriginalLockExpires; v38.Clean = value; _buySideOriginalLockExpires = v38;
                var v39 = _buySidePriceNetBuyPrice; v39.Clean = value; _buySidePriceNetBuyPrice = v39;
                var v40 = _buySidePriceRate; v40.Clean = value; _buySidePriceRate = v40;
                var v41 = _buySidePriceTotalAdjustment; v41.Clean = value; _buySidePriceTotalAdjustment = v41;
                var v42 = _buySideRate; v42.Clean = value; _buySideRate = v42;
                var v43 = _buySideRateNetBuyRate; v43.Clean = value; _buySideRateNetBuyRate = v43;
                var v44 = _buySideRateSheetID; v44.Clean = value; _buySideRateSheetID = v44;
                var v45 = _buySideRateTotalAdjustment; v45.Clean = value; _buySideRateTotalAdjustment = v45;
                var v46 = _buySideRequestedBy; v46.Clean = value; _buySideRequestedBy = v46;
                var v47 = _buySideSRPPaidOut; v47.Clean = value; _buySideSRPPaidOut = v47;
                var v48 = _buySideStartingAdjPoint; v48.Clean = value; _buySideStartingAdjPoint = v48;
                var v49 = _buySideStartingAdjPrice; v49.Clean = value; _buySideStartingAdjPrice = v49;
                var v50 = _buySideStartingAdjRate; v50.Clean = value; _buySideStartingAdjRate = v50;
                var v51 = _buySideTPOID; v51.Clean = value; _buySideTPOID = v51;
                var v52 = _buySideTPOName; v52.Clean = value; _buySideTPOName = v52;
                var v53 = _buySideTradeGuid; v53.Clean = value; _buySideTradeGuid = v53;
                var v54 = _buySideTradeNumber; v54.Clean = value; _buySideTradeNumber = v54;
                var v55 = _buySideUnDiscountedRate; v55.Clean = value; _buySideUnDiscountedRate = v55;
                var v56 = _cancellationRequestPending; v56.Clean = value; _cancellationRequestPending = v56;
                var v57 = _combinedLTV; v57.Clean = value; _combinedLTV = v57;
                var v58 = _comments; v58.Clean = value; _comments = v58;
                var v59 = _commitment; v59.Clean = value; _commitment = v59;
                var v60 = _compGainLossPercentage; v60.Clean = value; _compGainLossPercentage = v60;
                var v61 = _compGainLossPrice; v61.Clean = value; _compGainLossPrice = v61;
                var v62 = _compGainLossTotalBuyPrice; v62.Clean = value; _compGainLossTotalBuyPrice = v62;
                var v63 = _compGainLossTotalCompPrice; v63.Clean = value; _compGainLossTotalCompPrice = v63;
                var v64 = _compInvestorAddress; v64.Clean = value; _compInvestorAddress = v64;
                var v65 = _compInvestorCity; v65.Clean = value; _compInvestorCity = v65;
                var v66 = _compInvestorCommitment; v66.Clean = value; _compInvestorCommitment = v66;
                var v67 = _compInvestorContact; v67.Clean = value; _compInvestorContact = v67;
                var v68 = _compInvestorEmail; v68.Clean = value; _compInvestorEmail = v68;
                var v69 = _compInvestorLockType; v69.Clean = value; _compInvestorLockType = v69;
                var v70 = _compInvestorName; v70.Clean = value; _compInvestorName = v70;
                var v71 = _compInvestorPhone; v71.Clean = value; _compInvestorPhone = v71;
                var v72 = _compInvestorPostalCode; v72.Clean = value; _compInvestorPostalCode = v72;
                var v73 = _compInvestorProgramCode; v73.Clean = value; _compInvestorProgramCode = v73;
                var v74 = _compInvestorState; v74.Clean = value; _compInvestorState = v74;
                var v75 = _compInvestorTemplateName; v75.Clean = value; _compInvestorTemplateName = v75;
                var v76 = _compInvestorWebsite; v76.Clean = value; _compInvestorWebsite = v76;
                var v77 = _compSideAdjustments; v77.Clean = value; _compSideAdjustments = v77;
                var v78 = _compSideComments; v78.Clean = value; _compSideComments = v78;
                var v79 = _compSideComparisonedBy; v79.Clean = value; _compSideComparisonedBy = v79;
                var v80 = _compSideCurrentRateSetDate; v80.Clean = value; _compSideCurrentRateSetDate = v80;
                var v81 = _compSideDaystoExtend; v81.Clean = value; _compSideDaystoExtend = v81;
                var v82 = _compSideDiscountYSP; v82.Clean = value; _compSideDiscountYSP = v82;
                var v83 = _compSideExtendedLockExpires; v83.Clean = value; _compSideExtendedLockExpires = v83;
                var v84 = _compSideInvestorStatus; v84.Clean = value; _compSideInvestorStatus = v84;
                var v85 = _compSideInvestorStatusDate; v85.Clean = value; _compSideInvestorStatusDate = v85;
                var v86 = _compSideInvestorTradeNumber; v86.Clean = value; _compSideInvestorTradeNumber = v86;
                var v87 = _compSideLoanProgram; v87.Clean = value; _compSideLoanProgram = v87;
                var v88 = _compSideLockDate; v88.Clean = value; _compSideLockDate = v88;
                var v89 = _compSideLockExpires; v89.Clean = value; _compSideLockExpires = v89;
                var v90 = _compSideLockExtendPriceAdjustment; v90.Clean = value; _compSideLockExtendPriceAdjustment = v90;
                var v91 = _compSideMarginNetCompRate; v91.Clean = value; _compSideMarginNetCompRate = v91;
                var v92 = _compSideMarginRate; v92.Clean = value; _compSideMarginRate = v92;
                var v93 = _compSideMarginTotalAdjustment; v93.Clean = value; _compSideMarginTotalAdjustment = v93;
                var v94 = _compSideMasterContractNumber; v94.Clean = value; _compSideMasterContractNumber = v94;
                var v95 = _compSideNetCompPrice; v95.Clean = value; _compSideNetCompPrice = v95;
                var v96 = _compSideNetCompRate; v96.Clean = value; _compSideNetCompRate = v96;
                var v97 = _compSideNumberOfDays; v97.Clean = value; _compSideNumberOfDays = v97;
                var v98 = _compSideOriginalLockExpires; v98.Clean = value; _compSideOriginalLockExpires = v98;
                var v99 = _compSidePriceRate; v99.Clean = value; _compSidePriceRate = v99;
                var v100 = _compSidePriceTotalAdjustment; v100.Clean = value; _compSidePriceTotalAdjustment = v100;
                var v101 = _compSideRate; v101.Clean = value; _compSideRate = v101;
                var v102 = _compSideRateSheetID; v102.Clean = value; _compSideRateSheetID = v102;
                var v103 = _compSideRateTotalAdjustment; v103.Clean = value; _compSideRateTotalAdjustment = v103;
                var v104 = _compSideRequestedBy; v104.Clean = value; _compSideRequestedBy = v104;
                var v105 = _compSideServicingType; v105.Clean = value; _compSideServicingType = v105;
                var v106 = _compSideSRPPaidOut; v106.Clean = value; _compSideSRPPaidOut = v106;
                var v107 = _compSideTradeGuid; v107.Clean = value; _compSideTradeGuid = v107;
                var v108 = _compSideTradeNumber; v108.Clean = value; _compSideTradeNumber = v108;
                var v109 = _confirmedBy; v109.Clean = value; _confirmedBy = v109;
                var v110 = _confirmedDate; v110.Clean = value; _confirmedDate = v110;
                var v111 = _corporateApprovalDate; v111.Clean = value; _corporateApprovalDate = v111;
                var v112 = _corporateApprovedby; v112.Clean = value; _corporateApprovedby = v112;
                var v113 = _corporatePrice; v113.Clean = value; _corporatePrice = v113;
                var v114 = _correspondentAdditionalLineAmount1; v114.Clean = value; _correspondentAdditionalLineAmount1 = v114;
                var v115 = _correspondentAdditionalLineAmount10; v115.Clean = value; _correspondentAdditionalLineAmount10 = v115;
                var v116 = _correspondentAdditionalLineAmount11; v116.Clean = value; _correspondentAdditionalLineAmount11 = v116;
                var v117 = _correspondentAdditionalLineAmount12; v117.Clean = value; _correspondentAdditionalLineAmount12 = v117;
                var v118 = _correspondentAdditionalLineAmount13; v118.Clean = value; _correspondentAdditionalLineAmount13 = v118;
                var v119 = _correspondentAdditionalLineAmount2; v119.Clean = value; _correspondentAdditionalLineAmount2 = v119;
                var v120 = _correspondentAdditionalLineAmount3; v120.Clean = value; _correspondentAdditionalLineAmount3 = v120;
                var v121 = _correspondentAdditionalLineAmount4; v121.Clean = value; _correspondentAdditionalLineAmount4 = v121;
                var v122 = _correspondentAdditionalLineAmount5; v122.Clean = value; _correspondentAdditionalLineAmount5 = v122;
                var v123 = _correspondentAdditionalLineAmount6; v123.Clean = value; _correspondentAdditionalLineAmount6 = v123;
                var v124 = _correspondentAdditionalLineAmount7; v124.Clean = value; _correspondentAdditionalLineAmount7 = v124;
                var v125 = _correspondentAdditionalLineAmount8; v125.Clean = value; _correspondentAdditionalLineAmount8 = v125;
                var v126 = _correspondentAdditionalLineAmount9; v126.Clean = value; _correspondentAdditionalLineAmount9 = v126;
                var v127 = _correspondentAdditionalLineDescription1; v127.Clean = value; _correspondentAdditionalLineDescription1 = v127;
                var v128 = _correspondentAdditionalLineDescription10; v128.Clean = value; _correspondentAdditionalLineDescription10 = v128;
                var v129 = _correspondentAdditionalLineDescription11; v129.Clean = value; _correspondentAdditionalLineDescription11 = v129;
                var v130 = _correspondentAdditionalLineDescription12; v130.Clean = value; _correspondentAdditionalLineDescription12 = v130;
                var v131 = _correspondentAdditionalLineDescription2; v131.Clean = value; _correspondentAdditionalLineDescription2 = v131;
                var v132 = _correspondentAdditionalLineDescription3; v132.Clean = value; _correspondentAdditionalLineDescription3 = v132;
                var v133 = _correspondentAdditionalLineDescription4; v133.Clean = value; _correspondentAdditionalLineDescription4 = v133;
                var v134 = _correspondentAdditionalLineDescription5; v134.Clean = value; _correspondentAdditionalLineDescription5 = v134;
                var v135 = _correspondentAdditionalLineDescription6; v135.Clean = value; _correspondentAdditionalLineDescription6 = v135;
                var v136 = _correspondentAdditionalLineDescription7; v136.Clean = value; _correspondentAdditionalLineDescription7 = v136;
                var v137 = _correspondentAdditionalLineDescription8; v137.Clean = value; _correspondentAdditionalLineDescription8 = v137;
                var v138 = _correspondentAdditionalLineDescription9; v138.Clean = value; _correspondentAdditionalLineDescription9 = v138;
                var v139 = _correspondentAdditionalLineTotalAmount; v139.Clean = value; _correspondentAdditionalLineTotalAmount = v139;
                var v140 = _correspondentAdjusterAmount1; v140.Clean = value; _correspondentAdjusterAmount1 = v140;
                var v141 = _correspondentAdjusterAmount2; v141.Clean = value; _correspondentAdjusterAmount2 = v141;
                var v142 = _correspondentAdjusterAmount3; v142.Clean = value; _correspondentAdjusterAmount3 = v142;
                var v143 = _correspondentAdjusterDescription1; v143.Clean = value; _correspondentAdjusterDescription1 = v143;
                var v144 = _correspondentAdjusterDescription2; v144.Clean = value; _correspondentAdjusterDescription2 = v144;
                var v145 = _correspondentAdjusterDescription3; v145.Clean = value; _correspondentAdjusterDescription3 = v145;
                var v146 = _correspondentConfirmedBy; v146.Clean = value; _correspondentConfirmedBy = v146;
                var v147 = _correspondentConfirmedDate; v147.Clean = value; _correspondentConfirmedDate = v147;
                var v148 = _correspondentCurrentImpounds; v148.Clean = value; _correspondentCurrentImpounds = v148;
                var v149 = _correspondentCurrentPrincipal; v149.Clean = value; _correspondentCurrentPrincipal = v149;
                var v150 = _correspondentDate; v150.Clean = value; _correspondentDate = v150;
                var v151 = _correspondentFinalBuyAmount; v151.Clean = value; _correspondentFinalBuyAmount = v151;
                var v152 = _correspondentFinalBuyPrice; v152.Clean = value; _correspondentFinalBuyPrice = v152;
                var v153 = _correspondentFirstPaymentDate; v153.Clean = value; _correspondentFirstPaymentDate = v153;
                var v154 = _correspondentImpounds; v154.Clean = value; _correspondentImpounds = v154;
                var v155 = _correspondentInterest; v155.Clean = value; _correspondentInterest = v155;
                var v156 = _correspondentInterestDays; v156.Clean = value; _correspondentInterestDays = v156;
                var v157 = _correspondentLateFeeAmount; v157.Clean = value; _correspondentLateFeeAmount = v157;
                var v158 = _correspondentLateFeePriceAdjustment; v158.Clean = value; _correspondentLateFeePriceAdjustment = v158;
                var v159 = _correspondentPaidToDate; v159.Clean = value; _correspondentPaidToDate = v159;
                var v160 = _correspondentPurchasedPrincipal; v160.Clean = value; _correspondentPurchasedPrincipal = v160;
                var v161 = _correspondentReconcilationComments; v161.Clean = value; _correspondentReconcilationComments = v161;
                var v162 = _correspondentRemainingBuydownAmount; v162.Clean = value; _correspondentRemainingBuydownAmount = v162;
                var v163 = _correspondentSRPAmount; v163.Clean = value; _correspondentSRPAmount = v163;
                var v164 = _correspondentWarehouseBankABANum; v164.Clean = value; _correspondentWarehouseBankABANum = v164;
                var v165 = _correspondentWarehouseBankAcctNum; v165.Clean = value; _correspondentWarehouseBankAcctNum = v165;
                var v166 = _correspondentWarehouseBankAddress; v166.Clean = value; _correspondentWarehouseBankAddress = v166;
                var v167 = _correspondentWarehouseBankAddress1; v167.Clean = value; _correspondentWarehouseBankAddress1 = v167;
                var v168 = _correspondentWarehouseBankBaileeExpirationDate; v168.Clean = value; _correspondentWarehouseBankBaileeExpirationDate = v168;
                var v169 = _correspondentWarehouseBankBaileeLetterReceivedIndicator; v169.Clean = value; _correspondentWarehouseBankBaileeLetterReceivedIndicator = v169;
                var v170 = _correspondentWarehouseBankBaileeLetterReqIndicator; v170.Clean = value; _correspondentWarehouseBankBaileeLetterReqIndicator = v170;
                var v171 = _correspondentWarehouseBankCity; v171.Clean = value; _correspondentWarehouseBankCity = v171;
                var v172 = _correspondentWarehouseBankContactEmail; v172.Clean = value; _correspondentWarehouseBankContactEmail = v172;
                var v173 = _correspondentWarehouseBankContactFax; v173.Clean = value; _correspondentWarehouseBankContactFax = v173;
                var v174 = _correspondentWarehouseBankContactName; v174.Clean = value; _correspondentWarehouseBankContactName = v174;
                var v175 = _correspondentWarehouseBankContactPhone; v175.Clean = value; _correspondentWarehouseBankContactPhone = v175;
                var v176 = _correspondentWarehouseBankDescription; v176.Clean = value; _correspondentWarehouseBankDescription = v176;
                var v177 = _correspondentWarehouseBankId; v177.Clean = value; _correspondentWarehouseBankId = v177;
                var v178 = _correspondentWarehouseBankName; v178.Clean = value; _correspondentWarehouseBankName = v178;
                var v179 = _correspondentWarehouseBankNotes; v179.Clean = value; _correspondentWarehouseBankNotes = v179;
                var v180 = _correspondentWarehouseBankSelfFunderIndicator; v180.Clean = value; _correspondentWarehouseBankSelfFunderIndicator = v180;
                var v181 = _correspondentWarehouseBankState; v181.Clean = value; _correspondentWarehouseBankState = v181;
                var v182 = _correspondentWarehouseBankTriPartyContractIndicator; v182.Clean = value; _correspondentWarehouseBankTriPartyContractIndicator = v182;
                var v183 = _correspondentWarehouseBankUseDefaultContactIndicator; v183.Clean = value; _correspondentWarehouseBankUseDefaultContactIndicator = v183;
                var v184 = _correspondentWarehouseBankWireInstructionsReceivedIndicator; v184.Clean = value; _correspondentWarehouseBankWireInstructionsReceivedIndicator = v184;
                var v185 = _correspondentWarehouseBankZip; v185.Clean = value; _correspondentWarehouseBankZip = v185;
                var v186 = _creditScoreToUse; v186.Clean = value; _creditScoreToUse = v186;
                var v187 = _cumulatedDaystoExtend; v187.Clean = value; _cumulatedDaystoExtend = v187;
                var v188 = _currentAdjustments; v188.Clean = value; _currentAdjustments = v188;
                var v189 = _currentComments; v189.Clean = value; _currentComments = v189;
                var v190 = _currentLockDate; v190.Clean = value; _currentLockDate = v190;
                var v191 = _currentLockExpires; v191.Clean = value; _currentLockExpires = v191;
                var v192 = _currentMarginRate; v192.Clean = value; _currentMarginRate = v192;
                var v193 = _currentMarginRateRequested; v193.Clean = value; _currentMarginRateRequested = v193;
                var v194 = _currentMarginTotalAdjustment; v194.Clean = value; _currentMarginTotalAdjustment = v194;
                var v195 = _currentNumberOfDays; v195.Clean = value; _currentNumberOfDays = v195;
                var v196 = _currentPriceRate; v196.Clean = value; _currentPriceRate = v196;
                var v197 = _currentPriceRateRequested; v197.Clean = value; _currentPriceRateRequested = v197;
                var v198 = _currentPriceTotalAdjustment; v198.Clean = value; _currentPriceTotalAdjustment = v198;
                var v199 = _currentRate; v199.Clean = value; _currentRate = v199;
                var v200 = _currentRateRequested; v200.Clean = value; _currentRateRequested = v200;
                var v201 = _currentRateSetDate; v201.Clean = value; _currentRateSetDate = v201;
                var v202 = _currentRateSheetID; v202.Clean = value; _currentRateSheetID = v202;
                var v203 = _currentRateTotalAdjustment; v203.Clean = value; _currentRateTotalAdjustment = v203;
                var v204 = _date; v204.Clean = value; _date = v204;
                var v205 = _dateFirstPaymentToInvestor; v205.Clean = value; _dateFirstPaymentToInvestor = v205;
                var v206 = _dateLockedWithInvestor; v206.Clean = value; _dateLockedWithInvestor = v206;
                var v207 = _dateSold; v207.Clean = value; _dateSold = v207;
                var v208 = _dateWarehoused; v208.Clean = value; _dateWarehoused = v208;
                var v209 = _daysToExtend; v209.Clean = value; _daysToExtend = v209;
                var v210 = _deliveryType; v210.Clean = value; _deliveryType = v210;
                var v211 = _diffAmountReceived; v211.Clean = value; _diffAmountReceived = v211;
                var v212 = _diffImpounds; v212.Clean = value; _diffImpounds = v212;
                var v213 = _diffInterest; v213.Clean = value; _diffInterest = v213;
                var v214 = _diffPremium; v214.Clean = value; _diffPremium = v214;
                var v215 = _diffPrinciple; v215.Clean = value; _diffPrinciple = v215;
                var v216 = _diffRemainingBuydownFunds; v216.Clean = value; _diffRemainingBuydownFunds = v216;
                var v217 = _diffSellAmount; v217.Clean = value; _diffSellAmount = v217;
                var v218 = _diffSellPrice; v218.Clean = value; _diffSellPrice = v218;
                var v219 = _diffSellSideSRP; v219.Clean = value; _diffSellSideSRP = v219;
                var v220 = _diffSRP; v220.Clean = value; _diffSRP = v220;
                var v221 = _diffSRPAmount; v221.Clean = value; _diffSRPAmount = v221;
                var v222 = _employmentBorrowerSelfEmployedIndicator1; v222.Clean = value; _employmentBorrowerSelfEmployedIndicator1 = v222;
                var v223 = _employmentBorrowerSelfEmployedIndicator10; v223.Clean = value; _employmentBorrowerSelfEmployedIndicator10 = v223;
                var v224 = _employmentBorrowerSelfEmployedIndicator11; v224.Clean = value; _employmentBorrowerSelfEmployedIndicator11 = v224;
                var v225 = _employmentBorrowerSelfEmployedIndicator12; v225.Clean = value; _employmentBorrowerSelfEmployedIndicator12 = v225;
                var v226 = _employmentBorrowerSelfEmployedIndicator2; v226.Clean = value; _employmentBorrowerSelfEmployedIndicator2 = v226;
                var v227 = _employmentBorrowerSelfEmployedIndicator3; v227.Clean = value; _employmentBorrowerSelfEmployedIndicator3 = v227;
                var v228 = _employmentBorrowerSelfEmployedIndicator4; v228.Clean = value; _employmentBorrowerSelfEmployedIndicator4 = v228;
                var v229 = _employmentBorrowerSelfEmployedIndicator5; v229.Clean = value; _employmentBorrowerSelfEmployedIndicator5 = v229;
                var v230 = _employmentBorrowerSelfEmployedIndicator6; v230.Clean = value; _employmentBorrowerSelfEmployedIndicator6 = v230;
                var v231 = _employmentBorrowerSelfEmployedIndicator7; v231.Clean = value; _employmentBorrowerSelfEmployedIndicator7 = v231;
                var v232 = _employmentBorrowerSelfEmployedIndicator8; v232.Clean = value; _employmentBorrowerSelfEmployedIndicator8 = v232;
                var v233 = _employmentBorrowerSelfEmployedIndicator9; v233.Clean = value; _employmentBorrowerSelfEmployedIndicator9 = v233;
                var v234 = _expectedAmountReceived; v234.Clean = value; _expectedAmountReceived = v234;
                var v235 = _expectedImpounds; v235.Clean = value; _expectedImpounds = v235;
                var v236 = _expectedInterest; v236.Clean = value; _expectedInterest = v236;
                var v237 = _expectedPremium; v237.Clean = value; _expectedPremium = v237;
                var v238 = _expectedPrinciple; v238.Clean = value; _expectedPrinciple = v238;
                var v239 = _expectedRemainingBuydownFunds; v239.Clean = value; _expectedRemainingBuydownFunds = v239;
                var v240 = _expectedSRP; v240.Clean = value; _expectedSRP = v240;
                var v241 = _extensionRequestPending; v241.Clean = value; _extensionRequestPending = v241;
                var v242 = _extensionSequenceNumber; v242.Clean = value; _extensionSequenceNumber = v242;
                var v243 = _fHAUpfrontMIPremiumPercent; v243.Clean = value; _fHAUpfrontMIPremiumPercent = v243;
                var v244 = _financedNumberOfUnits; v244.Clean = value; _financedNumberOfUnits = v244;
                var v245 = _firstPaymenTo; v245.Clean = value; _firstPaymenTo = v245;
                var v246 = _firstSubordinateAmount; v246.Clean = value; _firstSubordinateAmount = v246;
                var v247 = _firstTimeHomebuyersIndicator; v247.Clean = value; _firstTimeHomebuyersIndicator = v247;
                var v248 = _fNMProductPlanIdentifier; v248.Clean = value; _fNMProductPlanIdentifier = v248;
                var v249 = _fundingAmount; v249.Clean = value; _fundingAmount = v249;
                var v250 = _gainLossPercentage; v250.Clean = value; _gainLossPercentage = v250;
                var v251 = _gainLossPrice; v251.Clean = value; _gainLossPrice = v251;
                var v252 = _gainLossTotalBuyPrice; v252.Clean = value; _gainLossTotalBuyPrice = v252;
                var v253 = _gPMRate; v253.Clean = value; _gPMRate = v253;
                var v254 = _gPMYears; v254.Clean = value; _gPMYears = v254;
                var v255 = _gSEPropertyType; v255.Clean = value; _gSEPropertyType = v255;
                var v256 = _hedging; v256.Clean = value; _hedging = v256;
                var v257 = _hELOCActualBalance; v257.Clean = value; _hELOCActualBalance = v257;
                var v258 = _id; v258.Clean = value; _id = v258;
                var v259 = _impounds; v259.Clean = value; _impounds = v259;
                var v260 = _impoundType; v260.Clean = value; _impoundType = v260;
                var v261 = _impoundWavied; v261.Clean = value; _impoundWavied = v261;
                var v262 = _interest; v262.Clean = value; _interest = v262;
                var v263 = _investorAddress; v263.Clean = value; _investorAddress = v263;
                var v264 = _investorCity; v264.Clean = value; _investorCity = v264;
                var v265 = _investorCommitment; v265.Clean = value; _investorCommitment = v265;
                var v266 = _investorContact; v266.Clean = value; _investorContact = v266;
                var v267 = _investorDeliveryDate; v267.Clean = value; _investorDeliveryDate = v267;
                var v268 = _investorEmail; v268.Clean = value; _investorEmail = v268;
                var v269 = _investorLoanNumber; v269.Clean = value; _investorLoanNumber = v269;
                var v270 = _investorLockType; v270.Clean = value; _investorLockType = v270;
                var v271 = _investorMERSNumber; v271.Clean = value; _investorMERSNumber = v271;
                var v272 = _investorName; v272.Clean = value; _investorName = v272;
                var v273 = _investorPhone; v273.Clean = value; _investorPhone = v273;
                var v274 = _investorPostalCode; v274.Clean = value; _investorPostalCode = v274;
                var v275 = _investorProgramCode; v275.Clean = value; _investorProgramCode = v275;
                var v276 = _investorState; v276.Clean = value; _investorState = v276;
                var v277 = _investorTargetDeliveryDate; v277.Clean = value; _investorTargetDeliveryDate = v277;
                var v278 = _investorTemplateName; v278.Clean = value; _investorTemplateName = v278;
                var v279 = _investorWebsite; v279.Clean = value; _investorWebsite = v279;
                var v280 = _isCancelled; v280.Clean = value; _isCancelled = v280;
                var v281 = _isDeliveryType; v281.Clean = value; _isDeliveryType = v281;
                var v282 = _lenderPaidMortgageInsuranceIndicator; v282.Clean = value; _lenderPaidMortgageInsuranceIndicator = v282;
                var v283 = _lienPriorityType; v283.Clean = value; _lienPriorityType = v283;
                var v284 = _loanAmortizationTermMonths; v284.Clean = value; _loanAmortizationTermMonths = v284;
                var v285 = _loanAmortizationType; v285.Clean = value; _loanAmortizationType = v285;
                var v286 = _loanDocumentationType; v286.Clean = value; _loanDocumentationType = v286;
                var v287 = _loanFor203K; v287.Clean = value; _loanFor203K = v287;
                var v288 = _loanProgram; v288.Clean = value; _loanProgram = v288;
                var v289 = _loanProgramFile; v289.Clean = value; _loanProgramFile = v289;
                var v290 = _loanScheduledClosingDate; v290.Clean = value; _loanScheduledClosingDate = v290;
                var v291 = _lockField; v291.Clean = value; _lockField = v291;
                var v292 = _lockRequestAdjustments; v292.Clean = value; _lockRequestAdjustments = v292;
                var v293 = _lockRequestBorrowers; v293.Clean = value; _lockRequestBorrowers = v293;
                var v294 = _lockRequestLoanPurposeType; v294.Clean = value; _lockRequestLoanPurposeType = v294;
                var v295 = _lTV; v295.Clean = value; _lTV = v295;
                var v296 = _minFICO; v296.Clean = value; _minFICO = v296;
                var v297 = _minFICO2; v297.Clean = value; _minFICO2 = v297;
                var v298 = _mIPPaidInCash; v298.Clean = value; _mIPPaidInCash = v298;
                var v299 = _mortgageType; v299.Clean = value; _mortgageType = v299;
                var v300 = _netSellAmount; v300.Clean = value; _netSellAmount = v300;
                var v301 = _netSellPrice; v301.Clean = value; _netSellPrice = v301;
                var v302 = _nextPaymentDate; v302.Clean = value; _nextPaymentDate = v302;
                var v303 = _noClosingCostOption; v303.Clean = value; _noClosingCostOption = v303;
                var v304 = _oNRPLock; v304.Clean = value; _oNRPLock = v304;
                var v305 = _otherAmortizationTypeDescription; v305.Clean = value; _otherAmortizationTypeDescription = v305;
                var v306 = _otherSubordinateAmount; v306.Clean = value; _otherSubordinateAmount = v306;
                var v307 = _penaltyTerm; v307.Clean = value; _penaltyTerm = v307;
                var v308 = _perDiemInterestRoundingType; v308.Clean = value; _perDiemInterestRoundingType = v308;
                var v309 = _planCode; v309.Clean = value; _planCode = v309;
                var v310 = _premium; v310.Clean = value; _premium = v310;
                var v311 = _prepayPenalty; v311.Clean = value; _prepayPenalty = v311;
                var v312 = _priceAdjustment; v312.Clean = value; _priceAdjustment = v312;
                var v313 = _priceAdjustments; v313.Clean = value; _priceAdjustments = v313;
                var v314 = _pricingHistoryData; v314.Clean = value; _pricingHistoryData = v314;
                var v315 = _pricingUpdated; v315.Clean = value; _pricingUpdated = v315;
                var v316 = _principle; v316.Clean = value; _principle = v316;
                var v317 = _profitMarginAdjustedBuyPrice; v317.Clean = value; _profitMarginAdjustedBuyPrice = v317;
                var v318 = _propertyAppraisedValueAmount; v318.Clean = value; _propertyAppraisedValueAmount = v318;
                var v319 = _propertyEstimatedValueAmount; v319.Clean = value; _propertyEstimatedValueAmount = v319;
                var v320 = _propertyUsageType; v320.Clean = value; _propertyUsageType = v320;
                var v321 = _purchaseAdviceNumberOfDays; v321.Clean = value; _purchaseAdviceNumberOfDays = v321;
                var v322 = _purchaseAdvicePayouts; v322.Clean = value; _purchaseAdvicePayouts = v322;
                var v323 = _purchasePriceAmount; v323.Clean = value; _purchasePriceAmount = v323;
                var v324 = _rateRequestStatus; v324.Clean = value; _rateRequestStatus = v324;
                var v325 = _rateStatus; v325.Clean = value; _rateStatus = v325;
                var v326 = _reasonforBranchApproval; v326.Clean = value; _reasonforBranchApproval = v326;
                var v327 = _reasonforCorporateApproval; v327.Clean = value; _reasonforCorporateApproval = v327;
                var v328 = _reconciledDiff; v328.Clean = value; _reconciledDiff = v328;
                var v329 = _reLockRequestPending; v329.Clean = value; _reLockRequestPending = v329;
                var v330 = _remainingBuydownFunds; v330.Clean = value; _remainingBuydownFunds = v330;
                var v331 = _requestComments; v331.Clean = value; _requestComments = v331;
                var v332 = _requestCurrentRateSetDate; v332.Clean = value; _requestCurrentRateSetDate = v332;
                var v333 = _requestDaystoExtend; v333.Clean = value; _requestDaystoExtend = v333;
                var v334 = _requestExtendedLockExpires; v334.Clean = value; _requestExtendedLockExpires = v334;
                var v335 = _requestFullfilledDateTime; v335.Clean = value; _requestFullfilledDateTime = v335;
                var v336 = _requestImpoundType; v336.Clean = value; _requestImpoundType = v336;
                var v337 = _requestImpoundWavied; v337.Clean = value; _requestImpoundWavied = v337;
                var v338 = _requestLockCancellationComment; v338.Clean = value; _requestLockCancellationComment = v338;
                var v339 = _requestLockCancellationDate; v339.Clean = value; _requestLockCancellationDate = v339;
                var v340 = _requestLockDate; v340.Clean = value; _requestLockDate = v340;
                var v341 = _requestLockExpires; v341.Clean = value; _requestLockExpires = v341;
                var v342 = _requestLockExtendComment; v342.Clean = value; _requestLockExtendComment = v342;
                var v343 = _requestLockExtendPriceAdjustment; v343.Clean = value; _requestLockExtendPriceAdjustment = v343;
                var v344 = _requestLockType; v344.Clean = value; _requestLockType = v344;
                var v345 = _requestMarginRate; v345.Clean = value; _requestMarginRate = v345;
                var v346 = _requestMarginRateRequested; v346.Clean = value; _requestMarginRateRequested = v346;
                var v347 = _requestMarginSRPPaidOut; v347.Clean = value; _requestMarginSRPPaidOut = v347;
                var v348 = _requestMarginTotalAdjustment; v348.Clean = value; _requestMarginTotalAdjustment = v348;
                var v349 = _requestNumberOfDays; v349.Clean = value; _requestNumberOfDays = v349;
                var v350 = _requestOnrpEligible; v350.Clean = value; _requestOnrpEligible = v350;
                var v351 = _requestOnrpLockDate; v351.Clean = value; _requestOnrpLockDate = v351;
                var v352 = _requestOnrpLockTime; v352.Clean = value; _requestOnrpLockTime = v352;
                var v353 = _requestOriginalLockExpires; v353.Clean = value; _requestOriginalLockExpires = v353;
                var v354 = _requestPenaltyTerm; v354.Clean = value; _requestPenaltyTerm = v354;
                var v355 = _requestPending; v355.Clean = value; _requestPending = v355;
                var v356 = _requestPrepayPenalty; v356.Clean = value; _requestPrepayPenalty = v356;
                var v357 = _requestPriceRate; v357.Clean = value; _requestPriceRate = v357;
                var v358 = _requestPriceRateRequested; v358.Clean = value; _requestPriceRateRequested = v358;
                var v359 = _requestPriceTotalAdjustment; v359.Clean = value; _requestPriceTotalAdjustment = v359;
                var v360 = _requestRate; v360.Clean = value; _requestRate = v360;
                var v361 = _requestRateRequested; v361.Clean = value; _requestRateRequested = v361;
                var v362 = _requestRateSheetID; v362.Clean = value; _requestRateSheetID = v362;
                var v363 = _requestRateTotalAdjustment; v363.Clean = value; _requestRateTotalAdjustment = v363;
                var v364 = _requestStartingAdjPoint; v364.Clean = value; _requestStartingAdjPoint = v364;
                var v365 = _requestStartingAdjRate; v365.Clean = value; _requestStartingAdjRate = v365;
                var v366 = _requestType; v366.Clean = value; _requestType = v366;
                var v367 = _requestUnDiscountedRate; v367.Clean = value; _requestUnDiscountedRate = v367;
                var v368 = _roundToNearest50; v368.Clean = value; _roundToNearest50 = v368;
                var v369 = _secondSubordinateAmount; v369.Clean = value; _secondSubordinateAmount = v369;
                var v370 = _sellerPaidMIPremium; v370.Clean = value; _sellerPaidMIPremium = v370;
                var v371 = _sellSideAdjustments; v371.Clean = value; _sellSideAdjustments = v371;
                var v372 = _sellSideComments; v372.Clean = value; _sellSideComments = v372;
                var v373 = _sellSideCommitmentContractNumber; v373.Clean = value; _sellSideCommitmentContractNumber = v373;
                var v374 = _sellSideCommitmentDate; v374.Clean = value; _sellSideCommitmentDate = v374;
                var v375 = _sellSideCurrentRateSetDate; v375.Clean = value; _sellSideCurrentRateSetDate = v375;
                var v376 = _sellSideDaystoExtend; v376.Clean = value; _sellSideDaystoExtend = v376;
                var v377 = _sellSideDiscountYSP; v377.Clean = value; _sellSideDiscountYSP = v377;
                var v378 = _sellSideExtendedLockExpires; v378.Clean = value; _sellSideExtendedLockExpires = v378;
                var v379 = _sellSideGuaranteeFee; v379.Clean = value; _sellSideGuaranteeFee = v379;
                var v380 = _sellSideGuarantyBaseFee; v380.Clean = value; _sellSideGuarantyBaseFee = v380;
                var v381 = _sellSideInvestorStatus; v381.Clean = value; _sellSideInvestorStatus = v381;
                var v382 = _sellSideInvestorStatusDate; v382.Clean = value; _sellSideInvestorStatusDate = v382;
                var v383 = _sellSideInvestorTradeNumber; v383.Clean = value; _sellSideInvestorTradeNumber = v383;
                var v384 = _sellSideLoanProgram; v384.Clean = value; _sellSideLoanProgram = v384;
                var v385 = _sellSideLockDate; v385.Clean = value; _sellSideLockDate = v385;
                var v386 = _sellSideLockExpires; v386.Clean = value; _sellSideLockExpires = v386;
                var v387 = _sellSideLockExtendPriceAdjustment; v387.Clean = value; _sellSideLockExtendPriceAdjustment = v387;
                var v388 = _sellSideMarginNetSellRate; v388.Clean = value; _sellSideMarginNetSellRate = v388;
                var v389 = _sellSideMarginRate; v389.Clean = value; _sellSideMarginRate = v389;
                var v390 = _sellSideMarginTotalAdjustment; v390.Clean = value; _sellSideMarginTotalAdjustment = v390;
                var v391 = _sellSideMasterContractNumber; v391.Clean = value; _sellSideMasterContractNumber = v391;
                var v392 = _sellSideMSRValue; v392.Clean = value; _sellSideMSRValue = v392;
                var v393 = _sellSideNetSellPrice; v393.Clean = value; _sellSideNetSellPrice = v393;
                var v394 = _sellSideNetSellRate; v394.Clean = value; _sellSideNetSellRate = v394;
                var v395 = _sellSideNumberOfDays; v395.Clean = value; _sellSideNumberOfDays = v395;
                var v396 = _sellSideOriginalLockExpires; v396.Clean = value; _sellSideOriginalLockExpires = v396;
                var v397 = _sellSidePoolID; v397.Clean = value; _sellSidePoolID = v397;
                var v398 = _sellSidePoolNumber; v398.Clean = value; _sellSidePoolNumber = v398;
                var v399 = _sellSidePriceRate; v399.Clean = value; _sellSidePriceRate = v399;
                var v400 = _sellSidePriceTotalAdjustment; v400.Clean = value; _sellSidePriceTotalAdjustment = v400;
                var v401 = _sellSideProductName; v401.Clean = value; _sellSideProductName = v401;
                var v402 = _sellSideRate; v402.Clean = value; _sellSideRate = v402;
                var v403 = _sellSideRateSheetID; v403.Clean = value; _sellSideRateSheetID = v403;
                var v404 = _sellSideRateTotalAdjustment; v404.Clean = value; _sellSideRateTotalAdjustment = v404;
                var v405 = _sellSideRequestedBy; v405.Clean = value; _sellSideRequestedBy = v405;
                var v406 = _sellSideServicer; v406.Clean = value; _sellSideServicer = v406;
                var v407 = _sellSideServicingFee; v407.Clean = value; _sellSideServicingFee = v407;
                var v408 = _sellSideServicingType; v408.Clean = value; _sellSideServicingType = v408;
                var v409 = _sellSideSRP; v409.Clean = value; _sellSideSRP = v409;
                var v410 = _sellSideSRPPaidOut; v410.Clean = value; _sellSideSRPPaidOut = v410;
                var v411 = _sellSideTradeGuid; v411.Clean = value; _sellSideTradeGuid = v411;
                var v412 = _sellSideTradeMgmtPrevConfirmedLockGuid; v412.Clean = value; _sellSideTradeMgmtPrevConfirmedLockGuid = v412;
                var v413 = _sellSideTradeNumber; v413.Clean = value; _sellSideTradeNumber = v413;
                var v414 = _servicingReleaseIndicator; v414.Clean = value; _servicingReleaseIndicator = v414;
                var v415 = _sRP; v415.Clean = value; _sRP = v415;
                var v416 = _sRPAmount; v416.Clean = value; _sRPAmount = v416;
                var v417 = _subjectPropertyCity; v417.Clean = value; _subjectPropertyCity = v417;
                var v418 = _subjectPropertyCondotelIndicator; v418.Clean = value; _subjectPropertyCondotelIndicator = v418;
                var v419 = _subjectPropertyCounty; v419.Clean = value; _subjectPropertyCounty = v419;
                var v420 = _subjectPropertyNonWarrantableProjectIndicator; v420.Clean = value; _subjectPropertyNonWarrantableProjectIndicator = v420;
                var v421 = _subjectPropertyPostalCode; v421.Clean = value; _subjectPropertyPostalCode = v421;
                var v422 = _subjectPropertyState; v422.Clean = value; _subjectPropertyState = v422;
                var v423 = _subjectPropertyStreetAddress; v423.Clean = value; _subjectPropertyStreetAddress = v423;
                var v424 = _timeLockedWithInvestor; v424.Clean = value; _timeLockedWithInvestor = v424;
                var v425 = _totalBuyPrice; v425.Clean = value; _totalBuyPrice = v425;
                var v426 = _totalForLesserOfSumAsIs; v426.Clean = value; _totalForLesserOfSumAsIs = v426;
                var v427 = _totalPrice; v427.Clean = value; _totalPrice = v427;
                var v428 = _totalSubordinateFinancing; v428.Clean = value; _totalSubordinateFinancing = v428;
                var v429 = _twelveMonthMortgageRentalHistoryIndicator; v429.Clean = value; _twelveMonthMortgageRentalHistoryIndicator = v429;
                var v430 = _type; v430.Clean = value; _type = v430;
                var v431 = _usePoint; v431.Clean = value; _usePoint = v431;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}