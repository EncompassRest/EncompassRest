using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
        private Value<string> _commitmentType;
        public string CommitmentType { get { return _commitmentType; } set { _commitmentType = value; } }
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
        private Value<decimal?> _correspondentAdditionalEscrowAdditionalEscrow;
        public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get { return _correspondentAdditionalEscrowAdditionalEscrow; } set { _correspondentAdditionalEscrowAdditionalEscrow = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowAmount1007;
        public decimal? CorrespondentAdditionalEscrowAmount1007 { get { return _correspondentAdditionalEscrowAmount1007; } set { _correspondentAdditionalEscrowAmount1007 = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowAmount1008;
        public decimal? CorrespondentAdditionalEscrowAmount1008 { get { return _correspondentAdditionalEscrowAmount1008; } set { _correspondentAdditionalEscrowAmount1008 = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowAmount1009;
        public decimal? CorrespondentAdditionalEscrowAmount1009 { get { return _correspondentAdditionalEscrowAmount1009; } set { _correspondentAdditionalEscrowAmount1009 = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowCityPropertyTax;
        public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get { return _correspondentAdditionalEscrowCityPropertyTax; } set { _correspondentAdditionalEscrowCityPropertyTax = value; } }
        private Value<string> _correspondentAdditionalEscrowDescription1007;
        public string CorrespondentAdditionalEscrowDescription1007 { get { return _correspondentAdditionalEscrowDescription1007; } set { _correspondentAdditionalEscrowDescription1007 = value; } }
        private Value<string> _correspondentAdditionalEscrowDescription1008;
        public string CorrespondentAdditionalEscrowDescription1008 { get { return _correspondentAdditionalEscrowDescription1008; } set { _correspondentAdditionalEscrowDescription1008 = value; } }
        private Value<string> _correspondentAdditionalEscrowDescription1009;
        public string CorrespondentAdditionalEscrowDescription1009 { get { return _correspondentAdditionalEscrowDescription1009; } set { _correspondentAdditionalEscrowDescription1009 = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowFloodInsurance;
        public decimal? CorrespondentAdditionalEscrowFloodInsurance { get { return _correspondentAdditionalEscrowFloodInsurance; } set { _correspondentAdditionalEscrowFloodInsurance = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowHomeInsurance;
        public decimal? CorrespondentAdditionalEscrowHomeInsurance { get { return _correspondentAdditionalEscrowHomeInsurance; } set { _correspondentAdditionalEscrowHomeInsurance = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowMIMIP;
        public decimal? CorrespondentAdditionalEscrowMIMIP { get { return _correspondentAdditionalEscrowMIMIP; } set { _correspondentAdditionalEscrowMIMIP = value; } }
        private Value<int?> _correspondentAdditionalEscrowNumOfPayments;
        public int? CorrespondentAdditionalEscrowNumOfPayments { get { return _correspondentAdditionalEscrowNumOfPayments; } set { _correspondentAdditionalEscrowNumOfPayments = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowOption1Amount;
        public decimal? CorrespondentAdditionalEscrowOption1Amount { get { return _correspondentAdditionalEscrowOption1Amount; } set { _correspondentAdditionalEscrowOption1Amount = value; } }
        private Value<string> _correspondentAdditionalEscrowOption1Desc;
        public string CorrespondentAdditionalEscrowOption1Desc { get { return _correspondentAdditionalEscrowOption1Desc; } set { _correspondentAdditionalEscrowOption1Desc = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowOption2Amount;
        public decimal? CorrespondentAdditionalEscrowOption2Amount { get { return _correspondentAdditionalEscrowOption2Amount; } set { _correspondentAdditionalEscrowOption2Amount = value; } }
        private Value<string> _correspondentAdditionalEscrowOption2Desc;
        public string CorrespondentAdditionalEscrowOption2Desc { get { return _correspondentAdditionalEscrowOption2Desc; } set { _correspondentAdditionalEscrowOption2Desc = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowPropertyTax;
        public decimal? CorrespondentAdditionalEscrowPropertyTax { get { return _correspondentAdditionalEscrowPropertyTax; } set { _correspondentAdditionalEscrowPropertyTax = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowSumOfPayments;
        public decimal? CorrespondentAdditionalEscrowSumOfPayments { get { return _correspondentAdditionalEscrowSumOfPayments; } set { _correspondentAdditionalEscrowSumOfPayments = value; } }
        private Value<decimal?> _correspondentAdditionalEscrowUSDAAnnualFee;
        public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get { return _correspondentAdditionalEscrowUSDAAnnualFee; } set { _correspondentAdditionalEscrowUSDAAnnualFee = value; } }
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
        private Value<decimal?> _correspondentEscrowDisbursementsAmount1007;
        public decimal? CorrespondentEscrowDisbursementsAmount1007 { get { return _correspondentEscrowDisbursementsAmount1007; } set { _correspondentEscrowDisbursementsAmount1007 = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsAmount1008;
        public decimal? CorrespondentEscrowDisbursementsAmount1008 { get { return _correspondentEscrowDisbursementsAmount1008; } set { _correspondentEscrowDisbursementsAmount1008 = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsAmount1009;
        public decimal? CorrespondentEscrowDisbursementsAmount1009 { get { return _correspondentEscrowDisbursementsAmount1009; } set { _correspondentEscrowDisbursementsAmount1009 = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsCityPropertyTax;
        public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get { return _correspondentEscrowDisbursementsCityPropertyTax; } set { _correspondentEscrowDisbursementsCityPropertyTax = value; } }
        private Value<string> _correspondentEscrowDisbursementsDescription1007;
        public string CorrespondentEscrowDisbursementsDescription1007 { get { return _correspondentEscrowDisbursementsDescription1007; } set { _correspondentEscrowDisbursementsDescription1007 = value; } }
        private Value<string> _correspondentEscrowDisbursementsDescription1008;
        public string CorrespondentEscrowDisbursementsDescription1008 { get { return _correspondentEscrowDisbursementsDescription1008; } set { _correspondentEscrowDisbursementsDescription1008 = value; } }
        private Value<string> _correspondentEscrowDisbursementsDescription1009;
        public string CorrespondentEscrowDisbursementsDescription1009 { get { return _correspondentEscrowDisbursementsDescription1009; } set { _correspondentEscrowDisbursementsDescription1009 = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsEscrowsToBePaidBySeller;
        public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get { return _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; } set { _correspondentEscrowDisbursementsEscrowsToBePaidBySeller = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsEsrowFundedByInvestor;
        public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get { return _correspondentEscrowDisbursementsEsrowFundedByInvestor; } set { _correspondentEscrowDisbursementsEsrowFundedByInvestor = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsFloodInsurance;
        public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get { return _correspondentEscrowDisbursementsFloodInsurance; } set { _correspondentEscrowDisbursementsFloodInsurance = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsHomeInsurance;
        public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get { return _correspondentEscrowDisbursementsHomeInsurance; } set { _correspondentEscrowDisbursementsHomeInsurance = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsMortgageInsurance;
        public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get { return _correspondentEscrowDisbursementsMortgageInsurance; } set { _correspondentEscrowDisbursementsMortgageInsurance = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsOption1Amount;
        public decimal? CorrespondentEscrowDisbursementsOption1Amount { get { return _correspondentEscrowDisbursementsOption1Amount; } set { _correspondentEscrowDisbursementsOption1Amount = value; } }
        private Value<string> _correspondentEscrowDisbursementsOption1Desc;
        public string CorrespondentEscrowDisbursementsOption1Desc { get { return _correspondentEscrowDisbursementsOption1Desc; } set { _correspondentEscrowDisbursementsOption1Desc = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsOption2Amount;
        public decimal? CorrespondentEscrowDisbursementsOption2Amount { get { return _correspondentEscrowDisbursementsOption2Amount; } set { _correspondentEscrowDisbursementsOption2Amount = value; } }
        private Value<string> _correspondentEscrowDisbursementsOption2Desc;
        public string CorrespondentEscrowDisbursementsOption2Desc { get { return _correspondentEscrowDisbursementsOption2Desc; } set { _correspondentEscrowDisbursementsOption2Desc = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsPropertyTax;
        public decimal? CorrespondentEscrowDisbursementsPropertyTax { get { return _correspondentEscrowDisbursementsPropertyTax; } set { _correspondentEscrowDisbursementsPropertyTax = value; } }
        private Value<decimal?> _correspondentEscrowDisbursementsUSDAAnnualFee;
        public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get { return _correspondentEscrowDisbursementsUSDAAnnualFee; } set { _correspondentEscrowDisbursementsUSDAAnnualFee = value; } }
        private Value<decimal?> _correspondentFinalBuyAmount;
        public decimal? CorrespondentFinalBuyAmount { get { return _correspondentFinalBuyAmount; } set { _correspondentFinalBuyAmount = value; } }
        private Value<decimal?> _correspondentFinalBuyPrice;
        public decimal? CorrespondentFinalBuyPrice { get { return _correspondentFinalBuyPrice; } set { _correspondentFinalBuyPrice = value; } }
        private Value<decimal?> _correspondentFinalCDAggAdjAmount;
        public decimal? CorrespondentFinalCDAggAdjAmount { get { return _correspondentFinalCDAggAdjAmount; } set { _correspondentFinalCDAggAdjAmount = value; } }
        private Value<decimal?> _correspondentFinalCDAmount1007;
        public decimal? CorrespondentFinalCDAmount1007 { get { return _correspondentFinalCDAmount1007; } set { _correspondentFinalCDAmount1007 = value; } }
        private Value<decimal?> _correspondentFinalCDAmount1008;
        public decimal? CorrespondentFinalCDAmount1008 { get { return _correspondentFinalCDAmount1008; } set { _correspondentFinalCDAmount1008 = value; } }
        private Value<decimal?> _correspondentFinalCDAmount1009;
        public decimal? CorrespondentFinalCDAmount1009 { get { return _correspondentFinalCDAmount1009; } set { _correspondentFinalCDAmount1009 = value; } }
        private Value<decimal?> _correspondentFinalCDCityPropertyTax;
        public decimal? CorrespondentFinalCDCityPropertyTax { get { return _correspondentFinalCDCityPropertyTax; } set { _correspondentFinalCDCityPropertyTax = value; } }
        private Value<string> _correspondentFinalCDDescription1007;
        public string CorrespondentFinalCDDescription1007 { get { return _correspondentFinalCDDescription1007; } set { _correspondentFinalCDDescription1007 = value; } }
        private Value<string> _correspondentFinalCDDescription1008;
        public string CorrespondentFinalCDDescription1008 { get { return _correspondentFinalCDDescription1008; } set { _correspondentFinalCDDescription1008 = value; } }
        private Value<string> _correspondentFinalCDDescription1009;
        public string CorrespondentFinalCDDescription1009 { get { return _correspondentFinalCDDescription1009; } set { _correspondentFinalCDDescription1009 = value; } }
        private Value<decimal?> _correspondentFinalCDFloodInsurance;
        public decimal? CorrespondentFinalCDFloodInsurance { get { return _correspondentFinalCDFloodInsurance; } set { _correspondentFinalCDFloodInsurance = value; } }
        private Value<decimal?> _correspondentFinalCDHomeInsurance;
        public decimal? CorrespondentFinalCDHomeInsurance { get { return _correspondentFinalCDHomeInsurance; } set { _correspondentFinalCDHomeInsurance = value; } }
        private Value<decimal?> _correspondentFinalCDMortgageInsurance;
        public decimal? CorrespondentFinalCDMortgageInsurance { get { return _correspondentFinalCDMortgageInsurance; } set { _correspondentFinalCDMortgageInsurance = value; } }
        private Value<decimal?> _correspondentFinalCDOption1Amount;
        public decimal? CorrespondentFinalCDOption1Amount { get { return _correspondentFinalCDOption1Amount; } set { _correspondentFinalCDOption1Amount = value; } }
        private Value<string> _correspondentFinalCDOption1Desc;
        public string CorrespondentFinalCDOption1Desc { get { return _correspondentFinalCDOption1Desc; } set { _correspondentFinalCDOption1Desc = value; } }
        private Value<decimal?> _correspondentFinalCDOption2Amount;
        public decimal? CorrespondentFinalCDOption2Amount { get { return _correspondentFinalCDOption2Amount; } set { _correspondentFinalCDOption2Amount = value; } }
        private Value<string> _correspondentFinalCDOption2Desc;
        public string CorrespondentFinalCDOption2Desc { get { return _correspondentFinalCDOption2Desc; } set { _correspondentFinalCDOption2Desc = value; } }
        private Value<decimal?> _correspondentFinalCDPropertyTax;
        public decimal? CorrespondentFinalCDPropertyTax { get { return _correspondentFinalCDPropertyTax; } set { _correspondentFinalCDPropertyTax = value; } }
        private Value<decimal?> _correspondentFinalCDReservesCollectedAtClosing;
        public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get { return _correspondentFinalCDReservesCollectedAtClosing; } set { _correspondentFinalCDReservesCollectedAtClosing = value; } }
        private Value<decimal?> _correspondentFinalCDUSDAAnnualFee;
        public decimal? CorrespondentFinalCDUSDAAnnualFee { get { return _correspondentFinalCDUSDAAnnualFee; } set { _correspondentFinalCDUSDAAnnualFee = value; } }
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
        private Value<DateTime?> _correspondentPaymentHistoryAnticipatedPurchaseDate;
        public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get { return _correspondentPaymentHistoryAnticipatedPurchaseDate; } set { _correspondentPaymentHistoryAnticipatedPurchaseDate = value; } }
        private Value<decimal?> _correspondentPaymentHistoryCalculatedPurchasedPrincipal;
        public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get { return _correspondentPaymentHistoryCalculatedPurchasedPrincipal; } set { _correspondentPaymentHistoryCalculatedPurchasedPrincipal = value; } }
        private Value<DateTime?> _correspondentPaymentHistoryFirstBorrowerPaymentDueDate;
        public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get { return _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; } set { _correspondentPaymentHistoryFirstBorrowerPaymentDueDate = value; } }
        private Value<DateTime?> _correspondentPaymentHistoryFirstInvestorPaymentDate;
        public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get { return _correspondentPaymentHistoryFirstInvestorPaymentDate; } set { _correspondentPaymentHistoryFirstInvestorPaymentDate = value; } }
        private Value<DateTime?> _correspondentPaymentHistoryNoteDate;
        public DateTime? CorrespondentPaymentHistoryNoteDate { get { return _correspondentPaymentHistoryNoteDate; } set { _correspondentPaymentHistoryNoteDate = value; } }
        private Value<decimal?> _correspondentPaymentHistoryPricipalReduction;
        public decimal? CorrespondentPaymentHistoryPricipalReduction { get { return _correspondentPaymentHistoryPricipalReduction; } set { _correspondentPaymentHistoryPricipalReduction = value; } }
        private Value<decimal?> _correspondentPurchasedPrincipal;
        public decimal? CorrespondentPurchasedPrincipal { get { return _correspondentPurchasedPrincipal; } set { _correspondentPurchasedPrincipal = value; } }
        private Value<string> _correspondentReconcilationComments;
        public string CorrespondentReconcilationComments { get { return _correspondentReconcilationComments; } set { _correspondentReconcilationComments = value; } }
        private Value<decimal?> _correspondentRemainingBuydownAmount;
        public decimal? CorrespondentRemainingBuydownAmount { get { return _correspondentRemainingBuydownAmount; } set { _correspondentRemainingBuydownAmount = value; } }
        private Value<decimal?> _correspondentSRPAmount;
        public decimal? CorrespondentSRPAmount { get { return _correspondentSRPAmount; } set { _correspondentSRPAmount = value; } }
        private Value<decimal?> _correspondentTotalBuyAmount;
        public decimal? CorrespondentTotalBuyAmount { get { return _correspondentTotalBuyAmount; } set { _correspondentTotalBuyAmount = value; } }
        private Value<decimal?> _correspondentTotalFees;
        public decimal? CorrespondentTotalFees { get { return _correspondentTotalFees; } set { _correspondentTotalFees = value; } }
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
        private Value<string> _correspondentWarehouseBankWireConfirmationNumber;
        public string CorrespondentWarehouseBankWireConfirmationNumber { get { return _correspondentWarehouseBankWireConfirmationNumber; } set { _correspondentWarehouseBankWireConfirmationNumber = value; } }
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
        private Value<List<ExtraPayment>> _extraPayments;
        public List<ExtraPayment> ExtraPayments { get { return _extraPayments; } set { _extraPayments = value; } }
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
        private Value<decimal?> _sRPPaidOut;
        public decimal? SRPPaidOut { get { return _sRPPaidOut; } set { _sRPPaidOut = value; } }
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
                    && _commitmentType.Clean
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
                    && _correspondentAdditionalEscrowAdditionalEscrow.Clean
                    && _correspondentAdditionalEscrowAmount1007.Clean
                    && _correspondentAdditionalEscrowAmount1008.Clean
                    && _correspondentAdditionalEscrowAmount1009.Clean
                    && _correspondentAdditionalEscrowCityPropertyTax.Clean
                    && _correspondentAdditionalEscrowDescription1007.Clean
                    && _correspondentAdditionalEscrowDescription1008.Clean
                    && _correspondentAdditionalEscrowDescription1009.Clean
                    && _correspondentAdditionalEscrowFloodInsurance.Clean
                    && _correspondentAdditionalEscrowHomeInsurance.Clean
                    && _correspondentAdditionalEscrowMIMIP.Clean
                    && _correspondentAdditionalEscrowNumOfPayments.Clean
                    && _correspondentAdditionalEscrowOption1Amount.Clean
                    && _correspondentAdditionalEscrowOption1Desc.Clean
                    && _correspondentAdditionalEscrowOption2Amount.Clean
                    && _correspondentAdditionalEscrowOption2Desc.Clean
                    && _correspondentAdditionalEscrowPropertyTax.Clean
                    && _correspondentAdditionalEscrowSumOfPayments.Clean
                    && _correspondentAdditionalEscrowUSDAAnnualFee.Clean
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
                    && _correspondentEscrowDisbursementsAmount1007.Clean
                    && _correspondentEscrowDisbursementsAmount1008.Clean
                    && _correspondentEscrowDisbursementsAmount1009.Clean
                    && _correspondentEscrowDisbursementsCityPropertyTax.Clean
                    && _correspondentEscrowDisbursementsDescription1007.Clean
                    && _correspondentEscrowDisbursementsDescription1008.Clean
                    && _correspondentEscrowDisbursementsDescription1009.Clean
                    && _correspondentEscrowDisbursementsEscrowsToBePaidBySeller.Clean
                    && _correspondentEscrowDisbursementsEsrowFundedByInvestor.Clean
                    && _correspondentEscrowDisbursementsFloodInsurance.Clean
                    && _correspondentEscrowDisbursementsHomeInsurance.Clean
                    && _correspondentEscrowDisbursementsMortgageInsurance.Clean
                    && _correspondentEscrowDisbursementsOption1Amount.Clean
                    && _correspondentEscrowDisbursementsOption1Desc.Clean
                    && _correspondentEscrowDisbursementsOption2Amount.Clean
                    && _correspondentEscrowDisbursementsOption2Desc.Clean
                    && _correspondentEscrowDisbursementsPropertyTax.Clean
                    && _correspondentEscrowDisbursementsUSDAAnnualFee.Clean
                    && _correspondentFinalBuyAmount.Clean
                    && _correspondentFinalBuyPrice.Clean
                    && _correspondentFinalCDAggAdjAmount.Clean
                    && _correspondentFinalCDAmount1007.Clean
                    && _correspondentFinalCDAmount1008.Clean
                    && _correspondentFinalCDAmount1009.Clean
                    && _correspondentFinalCDCityPropertyTax.Clean
                    && _correspondentFinalCDDescription1007.Clean
                    && _correspondentFinalCDDescription1008.Clean
                    && _correspondentFinalCDDescription1009.Clean
                    && _correspondentFinalCDFloodInsurance.Clean
                    && _correspondentFinalCDHomeInsurance.Clean
                    && _correspondentFinalCDMortgageInsurance.Clean
                    && _correspondentFinalCDOption1Amount.Clean
                    && _correspondentFinalCDOption1Desc.Clean
                    && _correspondentFinalCDOption2Amount.Clean
                    && _correspondentFinalCDOption2Desc.Clean
                    && _correspondentFinalCDPropertyTax.Clean
                    && _correspondentFinalCDReservesCollectedAtClosing.Clean
                    && _correspondentFinalCDUSDAAnnualFee.Clean
                    && _correspondentFirstPaymentDate.Clean
                    && _correspondentImpounds.Clean
                    && _correspondentInterest.Clean
                    && _correspondentInterestDays.Clean
                    && _correspondentLateFeeAmount.Clean
                    && _correspondentLateFeePriceAdjustment.Clean
                    && _correspondentPaidToDate.Clean
                    && _correspondentPaymentHistoryAnticipatedPurchaseDate.Clean
                    && _correspondentPaymentHistoryCalculatedPurchasedPrincipal.Clean
                    && _correspondentPaymentHistoryFirstBorrowerPaymentDueDate.Clean
                    && _correspondentPaymentHistoryFirstInvestorPaymentDate.Clean
                    && _correspondentPaymentHistoryNoteDate.Clean
                    && _correspondentPaymentHistoryPricipalReduction.Clean
                    && _correspondentPurchasedPrincipal.Clean
                    && _correspondentReconcilationComments.Clean
                    && _correspondentRemainingBuydownAmount.Clean
                    && _correspondentSRPAmount.Clean
                    && _correspondentTotalBuyAmount.Clean
                    && _correspondentTotalFees.Clean
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
                    && _correspondentWarehouseBankWireConfirmationNumber.Clean
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
                    && _extraPayments.Clean
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
                    && _sRPPaidOut.Clean
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
                var v60 = _commitmentType; v60.Clean = value; _commitmentType = v60;
                var v61 = _compGainLossPercentage; v61.Clean = value; _compGainLossPercentage = v61;
                var v62 = _compGainLossPrice; v62.Clean = value; _compGainLossPrice = v62;
                var v63 = _compGainLossTotalBuyPrice; v63.Clean = value; _compGainLossTotalBuyPrice = v63;
                var v64 = _compGainLossTotalCompPrice; v64.Clean = value; _compGainLossTotalCompPrice = v64;
                var v65 = _compInvestorAddress; v65.Clean = value; _compInvestorAddress = v65;
                var v66 = _compInvestorCity; v66.Clean = value; _compInvestorCity = v66;
                var v67 = _compInvestorCommitment; v67.Clean = value; _compInvestorCommitment = v67;
                var v68 = _compInvestorContact; v68.Clean = value; _compInvestorContact = v68;
                var v69 = _compInvestorEmail; v69.Clean = value; _compInvestorEmail = v69;
                var v70 = _compInvestorLockType; v70.Clean = value; _compInvestorLockType = v70;
                var v71 = _compInvestorName; v71.Clean = value; _compInvestorName = v71;
                var v72 = _compInvestorPhone; v72.Clean = value; _compInvestorPhone = v72;
                var v73 = _compInvestorPostalCode; v73.Clean = value; _compInvestorPostalCode = v73;
                var v74 = _compInvestorProgramCode; v74.Clean = value; _compInvestorProgramCode = v74;
                var v75 = _compInvestorState; v75.Clean = value; _compInvestorState = v75;
                var v76 = _compInvestorTemplateName; v76.Clean = value; _compInvestorTemplateName = v76;
                var v77 = _compInvestorWebsite; v77.Clean = value; _compInvestorWebsite = v77;
                var v78 = _compSideAdjustments; v78.Clean = value; _compSideAdjustments = v78;
                var v79 = _compSideComments; v79.Clean = value; _compSideComments = v79;
                var v80 = _compSideComparisonedBy; v80.Clean = value; _compSideComparisonedBy = v80;
                var v81 = _compSideCurrentRateSetDate; v81.Clean = value; _compSideCurrentRateSetDate = v81;
                var v82 = _compSideDaystoExtend; v82.Clean = value; _compSideDaystoExtend = v82;
                var v83 = _compSideDiscountYSP; v83.Clean = value; _compSideDiscountYSP = v83;
                var v84 = _compSideExtendedLockExpires; v84.Clean = value; _compSideExtendedLockExpires = v84;
                var v85 = _compSideInvestorStatus; v85.Clean = value; _compSideInvestorStatus = v85;
                var v86 = _compSideInvestorStatusDate; v86.Clean = value; _compSideInvestorStatusDate = v86;
                var v87 = _compSideInvestorTradeNumber; v87.Clean = value; _compSideInvestorTradeNumber = v87;
                var v88 = _compSideLoanProgram; v88.Clean = value; _compSideLoanProgram = v88;
                var v89 = _compSideLockDate; v89.Clean = value; _compSideLockDate = v89;
                var v90 = _compSideLockExpires; v90.Clean = value; _compSideLockExpires = v90;
                var v91 = _compSideLockExtendPriceAdjustment; v91.Clean = value; _compSideLockExtendPriceAdjustment = v91;
                var v92 = _compSideMarginNetCompRate; v92.Clean = value; _compSideMarginNetCompRate = v92;
                var v93 = _compSideMarginRate; v93.Clean = value; _compSideMarginRate = v93;
                var v94 = _compSideMarginTotalAdjustment; v94.Clean = value; _compSideMarginTotalAdjustment = v94;
                var v95 = _compSideMasterContractNumber; v95.Clean = value; _compSideMasterContractNumber = v95;
                var v96 = _compSideNetCompPrice; v96.Clean = value; _compSideNetCompPrice = v96;
                var v97 = _compSideNetCompRate; v97.Clean = value; _compSideNetCompRate = v97;
                var v98 = _compSideNumberOfDays; v98.Clean = value; _compSideNumberOfDays = v98;
                var v99 = _compSideOriginalLockExpires; v99.Clean = value; _compSideOriginalLockExpires = v99;
                var v100 = _compSidePriceRate; v100.Clean = value; _compSidePriceRate = v100;
                var v101 = _compSidePriceTotalAdjustment; v101.Clean = value; _compSidePriceTotalAdjustment = v101;
                var v102 = _compSideRate; v102.Clean = value; _compSideRate = v102;
                var v103 = _compSideRateSheetID; v103.Clean = value; _compSideRateSheetID = v103;
                var v104 = _compSideRateTotalAdjustment; v104.Clean = value; _compSideRateTotalAdjustment = v104;
                var v105 = _compSideRequestedBy; v105.Clean = value; _compSideRequestedBy = v105;
                var v106 = _compSideServicingType; v106.Clean = value; _compSideServicingType = v106;
                var v107 = _compSideSRPPaidOut; v107.Clean = value; _compSideSRPPaidOut = v107;
                var v108 = _compSideTradeGuid; v108.Clean = value; _compSideTradeGuid = v108;
                var v109 = _compSideTradeNumber; v109.Clean = value; _compSideTradeNumber = v109;
                var v110 = _confirmedBy; v110.Clean = value; _confirmedBy = v110;
                var v111 = _confirmedDate; v111.Clean = value; _confirmedDate = v111;
                var v112 = _corporateApprovalDate; v112.Clean = value; _corporateApprovalDate = v112;
                var v113 = _corporateApprovedby; v113.Clean = value; _corporateApprovedby = v113;
                var v114 = _corporatePrice; v114.Clean = value; _corporatePrice = v114;
                var v115 = _correspondentAdditionalEscrowAdditionalEscrow; v115.Clean = value; _correspondentAdditionalEscrowAdditionalEscrow = v115;
                var v116 = _correspondentAdditionalEscrowAmount1007; v116.Clean = value; _correspondentAdditionalEscrowAmount1007 = v116;
                var v117 = _correspondentAdditionalEscrowAmount1008; v117.Clean = value; _correspondentAdditionalEscrowAmount1008 = v117;
                var v118 = _correspondentAdditionalEscrowAmount1009; v118.Clean = value; _correspondentAdditionalEscrowAmount1009 = v118;
                var v119 = _correspondentAdditionalEscrowCityPropertyTax; v119.Clean = value; _correspondentAdditionalEscrowCityPropertyTax = v119;
                var v120 = _correspondentAdditionalEscrowDescription1007; v120.Clean = value; _correspondentAdditionalEscrowDescription1007 = v120;
                var v121 = _correspondentAdditionalEscrowDescription1008; v121.Clean = value; _correspondentAdditionalEscrowDescription1008 = v121;
                var v122 = _correspondentAdditionalEscrowDescription1009; v122.Clean = value; _correspondentAdditionalEscrowDescription1009 = v122;
                var v123 = _correspondentAdditionalEscrowFloodInsurance; v123.Clean = value; _correspondentAdditionalEscrowFloodInsurance = v123;
                var v124 = _correspondentAdditionalEscrowHomeInsurance; v124.Clean = value; _correspondentAdditionalEscrowHomeInsurance = v124;
                var v125 = _correspondentAdditionalEscrowMIMIP; v125.Clean = value; _correspondentAdditionalEscrowMIMIP = v125;
                var v126 = _correspondentAdditionalEscrowNumOfPayments; v126.Clean = value; _correspondentAdditionalEscrowNumOfPayments = v126;
                var v127 = _correspondentAdditionalEscrowOption1Amount; v127.Clean = value; _correspondentAdditionalEscrowOption1Amount = v127;
                var v128 = _correspondentAdditionalEscrowOption1Desc; v128.Clean = value; _correspondentAdditionalEscrowOption1Desc = v128;
                var v129 = _correspondentAdditionalEscrowOption2Amount; v129.Clean = value; _correspondentAdditionalEscrowOption2Amount = v129;
                var v130 = _correspondentAdditionalEscrowOption2Desc; v130.Clean = value; _correspondentAdditionalEscrowOption2Desc = v130;
                var v131 = _correspondentAdditionalEscrowPropertyTax; v131.Clean = value; _correspondentAdditionalEscrowPropertyTax = v131;
                var v132 = _correspondentAdditionalEscrowSumOfPayments; v132.Clean = value; _correspondentAdditionalEscrowSumOfPayments = v132;
                var v133 = _correspondentAdditionalEscrowUSDAAnnualFee; v133.Clean = value; _correspondentAdditionalEscrowUSDAAnnualFee = v133;
                var v134 = _correspondentAdditionalLineAmount1; v134.Clean = value; _correspondentAdditionalLineAmount1 = v134;
                var v135 = _correspondentAdditionalLineAmount10; v135.Clean = value; _correspondentAdditionalLineAmount10 = v135;
                var v136 = _correspondentAdditionalLineAmount11; v136.Clean = value; _correspondentAdditionalLineAmount11 = v136;
                var v137 = _correspondentAdditionalLineAmount12; v137.Clean = value; _correspondentAdditionalLineAmount12 = v137;
                var v138 = _correspondentAdditionalLineAmount13; v138.Clean = value; _correspondentAdditionalLineAmount13 = v138;
                var v139 = _correspondentAdditionalLineAmount2; v139.Clean = value; _correspondentAdditionalLineAmount2 = v139;
                var v140 = _correspondentAdditionalLineAmount3; v140.Clean = value; _correspondentAdditionalLineAmount3 = v140;
                var v141 = _correspondentAdditionalLineAmount4; v141.Clean = value; _correspondentAdditionalLineAmount4 = v141;
                var v142 = _correspondentAdditionalLineAmount5; v142.Clean = value; _correspondentAdditionalLineAmount5 = v142;
                var v143 = _correspondentAdditionalLineAmount6; v143.Clean = value; _correspondentAdditionalLineAmount6 = v143;
                var v144 = _correspondentAdditionalLineAmount7; v144.Clean = value; _correspondentAdditionalLineAmount7 = v144;
                var v145 = _correspondentAdditionalLineAmount8; v145.Clean = value; _correspondentAdditionalLineAmount8 = v145;
                var v146 = _correspondentAdditionalLineAmount9; v146.Clean = value; _correspondentAdditionalLineAmount9 = v146;
                var v147 = _correspondentAdditionalLineDescription1; v147.Clean = value; _correspondentAdditionalLineDescription1 = v147;
                var v148 = _correspondentAdditionalLineDescription10; v148.Clean = value; _correspondentAdditionalLineDescription10 = v148;
                var v149 = _correspondentAdditionalLineDescription11; v149.Clean = value; _correspondentAdditionalLineDescription11 = v149;
                var v150 = _correspondentAdditionalLineDescription12; v150.Clean = value; _correspondentAdditionalLineDescription12 = v150;
                var v151 = _correspondentAdditionalLineDescription2; v151.Clean = value; _correspondentAdditionalLineDescription2 = v151;
                var v152 = _correspondentAdditionalLineDescription3; v152.Clean = value; _correspondentAdditionalLineDescription3 = v152;
                var v153 = _correspondentAdditionalLineDescription4; v153.Clean = value; _correspondentAdditionalLineDescription4 = v153;
                var v154 = _correspondentAdditionalLineDescription5; v154.Clean = value; _correspondentAdditionalLineDescription5 = v154;
                var v155 = _correspondentAdditionalLineDescription6; v155.Clean = value; _correspondentAdditionalLineDescription6 = v155;
                var v156 = _correspondentAdditionalLineDescription7; v156.Clean = value; _correspondentAdditionalLineDescription7 = v156;
                var v157 = _correspondentAdditionalLineDescription8; v157.Clean = value; _correspondentAdditionalLineDescription8 = v157;
                var v158 = _correspondentAdditionalLineDescription9; v158.Clean = value; _correspondentAdditionalLineDescription9 = v158;
                var v159 = _correspondentAdditionalLineTotalAmount; v159.Clean = value; _correspondentAdditionalLineTotalAmount = v159;
                var v160 = _correspondentAdjusterAmount1; v160.Clean = value; _correspondentAdjusterAmount1 = v160;
                var v161 = _correspondentAdjusterAmount2; v161.Clean = value; _correspondentAdjusterAmount2 = v161;
                var v162 = _correspondentAdjusterAmount3; v162.Clean = value; _correspondentAdjusterAmount3 = v162;
                var v163 = _correspondentAdjusterDescription1; v163.Clean = value; _correspondentAdjusterDescription1 = v163;
                var v164 = _correspondentAdjusterDescription2; v164.Clean = value; _correspondentAdjusterDescription2 = v164;
                var v165 = _correspondentAdjusterDescription3; v165.Clean = value; _correspondentAdjusterDescription3 = v165;
                var v166 = _correspondentConfirmedBy; v166.Clean = value; _correspondentConfirmedBy = v166;
                var v167 = _correspondentConfirmedDate; v167.Clean = value; _correspondentConfirmedDate = v167;
                var v168 = _correspondentCurrentImpounds; v168.Clean = value; _correspondentCurrentImpounds = v168;
                var v169 = _correspondentCurrentPrincipal; v169.Clean = value; _correspondentCurrentPrincipal = v169;
                var v170 = _correspondentDate; v170.Clean = value; _correspondentDate = v170;
                var v171 = _correspondentEscrowDisbursementsAmount1007; v171.Clean = value; _correspondentEscrowDisbursementsAmount1007 = v171;
                var v172 = _correspondentEscrowDisbursementsAmount1008; v172.Clean = value; _correspondentEscrowDisbursementsAmount1008 = v172;
                var v173 = _correspondentEscrowDisbursementsAmount1009; v173.Clean = value; _correspondentEscrowDisbursementsAmount1009 = v173;
                var v174 = _correspondentEscrowDisbursementsCityPropertyTax; v174.Clean = value; _correspondentEscrowDisbursementsCityPropertyTax = v174;
                var v175 = _correspondentEscrowDisbursementsDescription1007; v175.Clean = value; _correspondentEscrowDisbursementsDescription1007 = v175;
                var v176 = _correspondentEscrowDisbursementsDescription1008; v176.Clean = value; _correspondentEscrowDisbursementsDescription1008 = v176;
                var v177 = _correspondentEscrowDisbursementsDescription1009; v177.Clean = value; _correspondentEscrowDisbursementsDescription1009 = v177;
                var v178 = _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; v178.Clean = value; _correspondentEscrowDisbursementsEscrowsToBePaidBySeller = v178;
                var v179 = _correspondentEscrowDisbursementsEsrowFundedByInvestor; v179.Clean = value; _correspondentEscrowDisbursementsEsrowFundedByInvestor = v179;
                var v180 = _correspondentEscrowDisbursementsFloodInsurance; v180.Clean = value; _correspondentEscrowDisbursementsFloodInsurance = v180;
                var v181 = _correspondentEscrowDisbursementsHomeInsurance; v181.Clean = value; _correspondentEscrowDisbursementsHomeInsurance = v181;
                var v182 = _correspondentEscrowDisbursementsMortgageInsurance; v182.Clean = value; _correspondentEscrowDisbursementsMortgageInsurance = v182;
                var v183 = _correspondentEscrowDisbursementsOption1Amount; v183.Clean = value; _correspondentEscrowDisbursementsOption1Amount = v183;
                var v184 = _correspondentEscrowDisbursementsOption1Desc; v184.Clean = value; _correspondentEscrowDisbursementsOption1Desc = v184;
                var v185 = _correspondentEscrowDisbursementsOption2Amount; v185.Clean = value; _correspondentEscrowDisbursementsOption2Amount = v185;
                var v186 = _correspondentEscrowDisbursementsOption2Desc; v186.Clean = value; _correspondentEscrowDisbursementsOption2Desc = v186;
                var v187 = _correspondentEscrowDisbursementsPropertyTax; v187.Clean = value; _correspondentEscrowDisbursementsPropertyTax = v187;
                var v188 = _correspondentEscrowDisbursementsUSDAAnnualFee; v188.Clean = value; _correspondentEscrowDisbursementsUSDAAnnualFee = v188;
                var v189 = _correspondentFinalBuyAmount; v189.Clean = value; _correspondentFinalBuyAmount = v189;
                var v190 = _correspondentFinalBuyPrice; v190.Clean = value; _correspondentFinalBuyPrice = v190;
                var v191 = _correspondentFinalCDAggAdjAmount; v191.Clean = value; _correspondentFinalCDAggAdjAmount = v191;
                var v192 = _correspondentFinalCDAmount1007; v192.Clean = value; _correspondentFinalCDAmount1007 = v192;
                var v193 = _correspondentFinalCDAmount1008; v193.Clean = value; _correspondentFinalCDAmount1008 = v193;
                var v194 = _correspondentFinalCDAmount1009; v194.Clean = value; _correspondentFinalCDAmount1009 = v194;
                var v195 = _correspondentFinalCDCityPropertyTax; v195.Clean = value; _correspondentFinalCDCityPropertyTax = v195;
                var v196 = _correspondentFinalCDDescription1007; v196.Clean = value; _correspondentFinalCDDescription1007 = v196;
                var v197 = _correspondentFinalCDDescription1008; v197.Clean = value; _correspondentFinalCDDescription1008 = v197;
                var v198 = _correspondentFinalCDDescription1009; v198.Clean = value; _correspondentFinalCDDescription1009 = v198;
                var v199 = _correspondentFinalCDFloodInsurance; v199.Clean = value; _correspondentFinalCDFloodInsurance = v199;
                var v200 = _correspondentFinalCDHomeInsurance; v200.Clean = value; _correspondentFinalCDHomeInsurance = v200;
                var v201 = _correspondentFinalCDMortgageInsurance; v201.Clean = value; _correspondentFinalCDMortgageInsurance = v201;
                var v202 = _correspondentFinalCDOption1Amount; v202.Clean = value; _correspondentFinalCDOption1Amount = v202;
                var v203 = _correspondentFinalCDOption1Desc; v203.Clean = value; _correspondentFinalCDOption1Desc = v203;
                var v204 = _correspondentFinalCDOption2Amount; v204.Clean = value; _correspondentFinalCDOption2Amount = v204;
                var v205 = _correspondentFinalCDOption2Desc; v205.Clean = value; _correspondentFinalCDOption2Desc = v205;
                var v206 = _correspondentFinalCDPropertyTax; v206.Clean = value; _correspondentFinalCDPropertyTax = v206;
                var v207 = _correspondentFinalCDReservesCollectedAtClosing; v207.Clean = value; _correspondentFinalCDReservesCollectedAtClosing = v207;
                var v208 = _correspondentFinalCDUSDAAnnualFee; v208.Clean = value; _correspondentFinalCDUSDAAnnualFee = v208;
                var v209 = _correspondentFirstPaymentDate; v209.Clean = value; _correspondentFirstPaymentDate = v209;
                var v210 = _correspondentImpounds; v210.Clean = value; _correspondentImpounds = v210;
                var v211 = _correspondentInterest; v211.Clean = value; _correspondentInterest = v211;
                var v212 = _correspondentInterestDays; v212.Clean = value; _correspondentInterestDays = v212;
                var v213 = _correspondentLateFeeAmount; v213.Clean = value; _correspondentLateFeeAmount = v213;
                var v214 = _correspondentLateFeePriceAdjustment; v214.Clean = value; _correspondentLateFeePriceAdjustment = v214;
                var v215 = _correspondentPaidToDate; v215.Clean = value; _correspondentPaidToDate = v215;
                var v216 = _correspondentPaymentHistoryAnticipatedPurchaseDate; v216.Clean = value; _correspondentPaymentHistoryAnticipatedPurchaseDate = v216;
                var v217 = _correspondentPaymentHistoryCalculatedPurchasedPrincipal; v217.Clean = value; _correspondentPaymentHistoryCalculatedPurchasedPrincipal = v217;
                var v218 = _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; v218.Clean = value; _correspondentPaymentHistoryFirstBorrowerPaymentDueDate = v218;
                var v219 = _correspondentPaymentHistoryFirstInvestorPaymentDate; v219.Clean = value; _correspondentPaymentHistoryFirstInvestorPaymentDate = v219;
                var v220 = _correspondentPaymentHistoryNoteDate; v220.Clean = value; _correspondentPaymentHistoryNoteDate = v220;
                var v221 = _correspondentPaymentHistoryPricipalReduction; v221.Clean = value; _correspondentPaymentHistoryPricipalReduction = v221;
                var v222 = _correspondentPurchasedPrincipal; v222.Clean = value; _correspondentPurchasedPrincipal = v222;
                var v223 = _correspondentReconcilationComments; v223.Clean = value; _correspondentReconcilationComments = v223;
                var v224 = _correspondentRemainingBuydownAmount; v224.Clean = value; _correspondentRemainingBuydownAmount = v224;
                var v225 = _correspondentSRPAmount; v225.Clean = value; _correspondentSRPAmount = v225;
                var v226 = _correspondentTotalBuyAmount; v226.Clean = value; _correspondentTotalBuyAmount = v226;
                var v227 = _correspondentTotalFees; v227.Clean = value; _correspondentTotalFees = v227;
                var v228 = _correspondentWarehouseBankABANum; v228.Clean = value; _correspondentWarehouseBankABANum = v228;
                var v229 = _correspondentWarehouseBankAcctNum; v229.Clean = value; _correspondentWarehouseBankAcctNum = v229;
                var v230 = _correspondentWarehouseBankAddress; v230.Clean = value; _correspondentWarehouseBankAddress = v230;
                var v231 = _correspondentWarehouseBankAddress1; v231.Clean = value; _correspondentWarehouseBankAddress1 = v231;
                var v232 = _correspondentWarehouseBankBaileeExpirationDate; v232.Clean = value; _correspondentWarehouseBankBaileeExpirationDate = v232;
                var v233 = _correspondentWarehouseBankBaileeLetterReceivedIndicator; v233.Clean = value; _correspondentWarehouseBankBaileeLetterReceivedIndicator = v233;
                var v234 = _correspondentWarehouseBankBaileeLetterReqIndicator; v234.Clean = value; _correspondentWarehouseBankBaileeLetterReqIndicator = v234;
                var v235 = _correspondentWarehouseBankCity; v235.Clean = value; _correspondentWarehouseBankCity = v235;
                var v236 = _correspondentWarehouseBankContactEmail; v236.Clean = value; _correspondentWarehouseBankContactEmail = v236;
                var v237 = _correspondentWarehouseBankContactFax; v237.Clean = value; _correspondentWarehouseBankContactFax = v237;
                var v238 = _correspondentWarehouseBankContactName; v238.Clean = value; _correspondentWarehouseBankContactName = v238;
                var v239 = _correspondentWarehouseBankContactPhone; v239.Clean = value; _correspondentWarehouseBankContactPhone = v239;
                var v240 = _correspondentWarehouseBankDescription; v240.Clean = value; _correspondentWarehouseBankDescription = v240;
                var v241 = _correspondentWarehouseBankId; v241.Clean = value; _correspondentWarehouseBankId = v241;
                var v242 = _correspondentWarehouseBankName; v242.Clean = value; _correspondentWarehouseBankName = v242;
                var v243 = _correspondentWarehouseBankNotes; v243.Clean = value; _correspondentWarehouseBankNotes = v243;
                var v244 = _correspondentWarehouseBankSelfFunderIndicator; v244.Clean = value; _correspondentWarehouseBankSelfFunderIndicator = v244;
                var v245 = _correspondentWarehouseBankState; v245.Clean = value; _correspondentWarehouseBankState = v245;
                var v246 = _correspondentWarehouseBankTriPartyContractIndicator; v246.Clean = value; _correspondentWarehouseBankTriPartyContractIndicator = v246;
                var v247 = _correspondentWarehouseBankUseDefaultContactIndicator; v247.Clean = value; _correspondentWarehouseBankUseDefaultContactIndicator = v247;
                var v248 = _correspondentWarehouseBankWireConfirmationNumber; v248.Clean = value; _correspondentWarehouseBankWireConfirmationNumber = v248;
                var v249 = _correspondentWarehouseBankWireInstructionsReceivedIndicator; v249.Clean = value; _correspondentWarehouseBankWireInstructionsReceivedIndicator = v249;
                var v250 = _correspondentWarehouseBankZip; v250.Clean = value; _correspondentWarehouseBankZip = v250;
                var v251 = _creditScoreToUse; v251.Clean = value; _creditScoreToUse = v251;
                var v252 = _cumulatedDaystoExtend; v252.Clean = value; _cumulatedDaystoExtend = v252;
                var v253 = _currentAdjustments; v253.Clean = value; _currentAdjustments = v253;
                var v254 = _currentComments; v254.Clean = value; _currentComments = v254;
                var v255 = _currentLockDate; v255.Clean = value; _currentLockDate = v255;
                var v256 = _currentLockExpires; v256.Clean = value; _currentLockExpires = v256;
                var v257 = _currentMarginRate; v257.Clean = value; _currentMarginRate = v257;
                var v258 = _currentMarginRateRequested; v258.Clean = value; _currentMarginRateRequested = v258;
                var v259 = _currentMarginTotalAdjustment; v259.Clean = value; _currentMarginTotalAdjustment = v259;
                var v260 = _currentNumberOfDays; v260.Clean = value; _currentNumberOfDays = v260;
                var v261 = _currentPriceRate; v261.Clean = value; _currentPriceRate = v261;
                var v262 = _currentPriceRateRequested; v262.Clean = value; _currentPriceRateRequested = v262;
                var v263 = _currentPriceTotalAdjustment; v263.Clean = value; _currentPriceTotalAdjustment = v263;
                var v264 = _currentRate; v264.Clean = value; _currentRate = v264;
                var v265 = _currentRateRequested; v265.Clean = value; _currentRateRequested = v265;
                var v266 = _currentRateSetDate; v266.Clean = value; _currentRateSetDate = v266;
                var v267 = _currentRateSheetID; v267.Clean = value; _currentRateSheetID = v267;
                var v268 = _currentRateTotalAdjustment; v268.Clean = value; _currentRateTotalAdjustment = v268;
                var v269 = _date; v269.Clean = value; _date = v269;
                var v270 = _dateFirstPaymentToInvestor; v270.Clean = value; _dateFirstPaymentToInvestor = v270;
                var v271 = _dateLockedWithInvestor; v271.Clean = value; _dateLockedWithInvestor = v271;
                var v272 = _dateSold; v272.Clean = value; _dateSold = v272;
                var v273 = _dateWarehoused; v273.Clean = value; _dateWarehoused = v273;
                var v274 = _daysToExtend; v274.Clean = value; _daysToExtend = v274;
                var v275 = _deliveryType; v275.Clean = value; _deliveryType = v275;
                var v276 = _diffAmountReceived; v276.Clean = value; _diffAmountReceived = v276;
                var v277 = _diffImpounds; v277.Clean = value; _diffImpounds = v277;
                var v278 = _diffInterest; v278.Clean = value; _diffInterest = v278;
                var v279 = _diffPremium; v279.Clean = value; _diffPremium = v279;
                var v280 = _diffPrinciple; v280.Clean = value; _diffPrinciple = v280;
                var v281 = _diffRemainingBuydownFunds; v281.Clean = value; _diffRemainingBuydownFunds = v281;
                var v282 = _diffSellAmount; v282.Clean = value; _diffSellAmount = v282;
                var v283 = _diffSellPrice; v283.Clean = value; _diffSellPrice = v283;
                var v284 = _diffSellSideSRP; v284.Clean = value; _diffSellSideSRP = v284;
                var v285 = _diffSRP; v285.Clean = value; _diffSRP = v285;
                var v286 = _diffSRPAmount; v286.Clean = value; _diffSRPAmount = v286;
                var v287 = _employmentBorrowerSelfEmployedIndicator1; v287.Clean = value; _employmentBorrowerSelfEmployedIndicator1 = v287;
                var v288 = _employmentBorrowerSelfEmployedIndicator10; v288.Clean = value; _employmentBorrowerSelfEmployedIndicator10 = v288;
                var v289 = _employmentBorrowerSelfEmployedIndicator11; v289.Clean = value; _employmentBorrowerSelfEmployedIndicator11 = v289;
                var v290 = _employmentBorrowerSelfEmployedIndicator12; v290.Clean = value; _employmentBorrowerSelfEmployedIndicator12 = v290;
                var v291 = _employmentBorrowerSelfEmployedIndicator2; v291.Clean = value; _employmentBorrowerSelfEmployedIndicator2 = v291;
                var v292 = _employmentBorrowerSelfEmployedIndicator3; v292.Clean = value; _employmentBorrowerSelfEmployedIndicator3 = v292;
                var v293 = _employmentBorrowerSelfEmployedIndicator4; v293.Clean = value; _employmentBorrowerSelfEmployedIndicator4 = v293;
                var v294 = _employmentBorrowerSelfEmployedIndicator5; v294.Clean = value; _employmentBorrowerSelfEmployedIndicator5 = v294;
                var v295 = _employmentBorrowerSelfEmployedIndicator6; v295.Clean = value; _employmentBorrowerSelfEmployedIndicator6 = v295;
                var v296 = _employmentBorrowerSelfEmployedIndicator7; v296.Clean = value; _employmentBorrowerSelfEmployedIndicator7 = v296;
                var v297 = _employmentBorrowerSelfEmployedIndicator8; v297.Clean = value; _employmentBorrowerSelfEmployedIndicator8 = v297;
                var v298 = _employmentBorrowerSelfEmployedIndicator9; v298.Clean = value; _employmentBorrowerSelfEmployedIndicator9 = v298;
                var v299 = _expectedAmountReceived; v299.Clean = value; _expectedAmountReceived = v299;
                var v300 = _expectedImpounds; v300.Clean = value; _expectedImpounds = v300;
                var v301 = _expectedInterest; v301.Clean = value; _expectedInterest = v301;
                var v302 = _expectedPremium; v302.Clean = value; _expectedPremium = v302;
                var v303 = _expectedPrinciple; v303.Clean = value; _expectedPrinciple = v303;
                var v304 = _expectedRemainingBuydownFunds; v304.Clean = value; _expectedRemainingBuydownFunds = v304;
                var v305 = _expectedSRP; v305.Clean = value; _expectedSRP = v305;
                var v306 = _extensionRequestPending; v306.Clean = value; _extensionRequestPending = v306;
                var v307 = _extensionSequenceNumber; v307.Clean = value; _extensionSequenceNumber = v307;
                var v308 = _extraPayments; v308.Clean = value; _extraPayments = v308;
                var v309 = _fHAUpfrontMIPremiumPercent; v309.Clean = value; _fHAUpfrontMIPremiumPercent = v309;
                var v310 = _financedNumberOfUnits; v310.Clean = value; _financedNumberOfUnits = v310;
                var v311 = _firstPaymenTo; v311.Clean = value; _firstPaymenTo = v311;
                var v312 = _firstSubordinateAmount; v312.Clean = value; _firstSubordinateAmount = v312;
                var v313 = _firstTimeHomebuyersIndicator; v313.Clean = value; _firstTimeHomebuyersIndicator = v313;
                var v314 = _fNMProductPlanIdentifier; v314.Clean = value; _fNMProductPlanIdentifier = v314;
                var v315 = _fundingAmount; v315.Clean = value; _fundingAmount = v315;
                var v316 = _gainLossPercentage; v316.Clean = value; _gainLossPercentage = v316;
                var v317 = _gainLossPrice; v317.Clean = value; _gainLossPrice = v317;
                var v318 = _gainLossTotalBuyPrice; v318.Clean = value; _gainLossTotalBuyPrice = v318;
                var v319 = _gPMRate; v319.Clean = value; _gPMRate = v319;
                var v320 = _gPMYears; v320.Clean = value; _gPMYears = v320;
                var v321 = _gSEPropertyType; v321.Clean = value; _gSEPropertyType = v321;
                var v322 = _hedging; v322.Clean = value; _hedging = v322;
                var v323 = _hELOCActualBalance; v323.Clean = value; _hELOCActualBalance = v323;
                var v324 = _id; v324.Clean = value; _id = v324;
                var v325 = _impounds; v325.Clean = value; _impounds = v325;
                var v326 = _impoundType; v326.Clean = value; _impoundType = v326;
                var v327 = _impoundWavied; v327.Clean = value; _impoundWavied = v327;
                var v328 = _interest; v328.Clean = value; _interest = v328;
                var v329 = _investorAddress; v329.Clean = value; _investorAddress = v329;
                var v330 = _investorCity; v330.Clean = value; _investorCity = v330;
                var v331 = _investorCommitment; v331.Clean = value; _investorCommitment = v331;
                var v332 = _investorContact; v332.Clean = value; _investorContact = v332;
                var v333 = _investorDeliveryDate; v333.Clean = value; _investorDeliveryDate = v333;
                var v334 = _investorEmail; v334.Clean = value; _investorEmail = v334;
                var v335 = _investorLoanNumber; v335.Clean = value; _investorLoanNumber = v335;
                var v336 = _investorLockType; v336.Clean = value; _investorLockType = v336;
                var v337 = _investorMERSNumber; v337.Clean = value; _investorMERSNumber = v337;
                var v338 = _investorName; v338.Clean = value; _investorName = v338;
                var v339 = _investorPhone; v339.Clean = value; _investorPhone = v339;
                var v340 = _investorPostalCode; v340.Clean = value; _investorPostalCode = v340;
                var v341 = _investorProgramCode; v341.Clean = value; _investorProgramCode = v341;
                var v342 = _investorState; v342.Clean = value; _investorState = v342;
                var v343 = _investorTargetDeliveryDate; v343.Clean = value; _investorTargetDeliveryDate = v343;
                var v344 = _investorTemplateName; v344.Clean = value; _investorTemplateName = v344;
                var v345 = _investorWebsite; v345.Clean = value; _investorWebsite = v345;
                var v346 = _isCancelled; v346.Clean = value; _isCancelled = v346;
                var v347 = _isDeliveryType; v347.Clean = value; _isDeliveryType = v347;
                var v348 = _lenderPaidMortgageInsuranceIndicator; v348.Clean = value; _lenderPaidMortgageInsuranceIndicator = v348;
                var v349 = _lienPriorityType; v349.Clean = value; _lienPriorityType = v349;
                var v350 = _loanAmortizationTermMonths; v350.Clean = value; _loanAmortizationTermMonths = v350;
                var v351 = _loanAmortizationType; v351.Clean = value; _loanAmortizationType = v351;
                var v352 = _loanDocumentationType; v352.Clean = value; _loanDocumentationType = v352;
                var v353 = _loanFor203K; v353.Clean = value; _loanFor203K = v353;
                var v354 = _loanProgram; v354.Clean = value; _loanProgram = v354;
                var v355 = _loanProgramFile; v355.Clean = value; _loanProgramFile = v355;
                var v356 = _loanScheduledClosingDate; v356.Clean = value; _loanScheduledClosingDate = v356;
                var v357 = _lockField; v357.Clean = value; _lockField = v357;
                var v358 = _lockRequestAdjustments; v358.Clean = value; _lockRequestAdjustments = v358;
                var v359 = _lockRequestBorrowers; v359.Clean = value; _lockRequestBorrowers = v359;
                var v360 = _lockRequestLoanPurposeType; v360.Clean = value; _lockRequestLoanPurposeType = v360;
                var v361 = _lTV; v361.Clean = value; _lTV = v361;
                var v362 = _minFICO; v362.Clean = value; _minFICO = v362;
                var v363 = _minFICO2; v363.Clean = value; _minFICO2 = v363;
                var v364 = _mIPPaidInCash; v364.Clean = value; _mIPPaidInCash = v364;
                var v365 = _mortgageType; v365.Clean = value; _mortgageType = v365;
                var v366 = _netSellAmount; v366.Clean = value; _netSellAmount = v366;
                var v367 = _netSellPrice; v367.Clean = value; _netSellPrice = v367;
                var v368 = _nextPaymentDate; v368.Clean = value; _nextPaymentDate = v368;
                var v369 = _noClosingCostOption; v369.Clean = value; _noClosingCostOption = v369;
                var v370 = _oNRPLock; v370.Clean = value; _oNRPLock = v370;
                var v371 = _otherAmortizationTypeDescription; v371.Clean = value; _otherAmortizationTypeDescription = v371;
                var v372 = _otherSubordinateAmount; v372.Clean = value; _otherSubordinateAmount = v372;
                var v373 = _penaltyTerm; v373.Clean = value; _penaltyTerm = v373;
                var v374 = _perDiemInterestRoundingType; v374.Clean = value; _perDiemInterestRoundingType = v374;
                var v375 = _planCode; v375.Clean = value; _planCode = v375;
                var v376 = _premium; v376.Clean = value; _premium = v376;
                var v377 = _prepayPenalty; v377.Clean = value; _prepayPenalty = v377;
                var v378 = _priceAdjustment; v378.Clean = value; _priceAdjustment = v378;
                var v379 = _priceAdjustments; v379.Clean = value; _priceAdjustments = v379;
                var v380 = _pricingHistoryData; v380.Clean = value; _pricingHistoryData = v380;
                var v381 = _pricingUpdated; v381.Clean = value; _pricingUpdated = v381;
                var v382 = _principle; v382.Clean = value; _principle = v382;
                var v383 = _profitMarginAdjustedBuyPrice; v383.Clean = value; _profitMarginAdjustedBuyPrice = v383;
                var v384 = _propertyAppraisedValueAmount; v384.Clean = value; _propertyAppraisedValueAmount = v384;
                var v385 = _propertyEstimatedValueAmount; v385.Clean = value; _propertyEstimatedValueAmount = v385;
                var v386 = _propertyUsageType; v386.Clean = value; _propertyUsageType = v386;
                var v387 = _purchaseAdviceNumberOfDays; v387.Clean = value; _purchaseAdviceNumberOfDays = v387;
                var v388 = _purchaseAdvicePayouts; v388.Clean = value; _purchaseAdvicePayouts = v388;
                var v389 = _purchasePriceAmount; v389.Clean = value; _purchasePriceAmount = v389;
                var v390 = _rateRequestStatus; v390.Clean = value; _rateRequestStatus = v390;
                var v391 = _rateStatus; v391.Clean = value; _rateStatus = v391;
                var v392 = _reasonforBranchApproval; v392.Clean = value; _reasonforBranchApproval = v392;
                var v393 = _reasonforCorporateApproval; v393.Clean = value; _reasonforCorporateApproval = v393;
                var v394 = _reconciledDiff; v394.Clean = value; _reconciledDiff = v394;
                var v395 = _reLockRequestPending; v395.Clean = value; _reLockRequestPending = v395;
                var v396 = _remainingBuydownFunds; v396.Clean = value; _remainingBuydownFunds = v396;
                var v397 = _requestComments; v397.Clean = value; _requestComments = v397;
                var v398 = _requestCurrentRateSetDate; v398.Clean = value; _requestCurrentRateSetDate = v398;
                var v399 = _requestDaystoExtend; v399.Clean = value; _requestDaystoExtend = v399;
                var v400 = _requestExtendedLockExpires; v400.Clean = value; _requestExtendedLockExpires = v400;
                var v401 = _requestFullfilledDateTime; v401.Clean = value; _requestFullfilledDateTime = v401;
                var v402 = _requestImpoundType; v402.Clean = value; _requestImpoundType = v402;
                var v403 = _requestImpoundWavied; v403.Clean = value; _requestImpoundWavied = v403;
                var v404 = _requestLockCancellationComment; v404.Clean = value; _requestLockCancellationComment = v404;
                var v405 = _requestLockCancellationDate; v405.Clean = value; _requestLockCancellationDate = v405;
                var v406 = _requestLockDate; v406.Clean = value; _requestLockDate = v406;
                var v407 = _requestLockExpires; v407.Clean = value; _requestLockExpires = v407;
                var v408 = _requestLockExtendComment; v408.Clean = value; _requestLockExtendComment = v408;
                var v409 = _requestLockExtendPriceAdjustment; v409.Clean = value; _requestLockExtendPriceAdjustment = v409;
                var v410 = _requestLockType; v410.Clean = value; _requestLockType = v410;
                var v411 = _requestMarginRate; v411.Clean = value; _requestMarginRate = v411;
                var v412 = _requestMarginRateRequested; v412.Clean = value; _requestMarginRateRequested = v412;
                var v413 = _requestMarginSRPPaidOut; v413.Clean = value; _requestMarginSRPPaidOut = v413;
                var v414 = _requestMarginTotalAdjustment; v414.Clean = value; _requestMarginTotalAdjustment = v414;
                var v415 = _requestNumberOfDays; v415.Clean = value; _requestNumberOfDays = v415;
                var v416 = _requestOnrpEligible; v416.Clean = value; _requestOnrpEligible = v416;
                var v417 = _requestOnrpLockDate; v417.Clean = value; _requestOnrpLockDate = v417;
                var v418 = _requestOnrpLockTime; v418.Clean = value; _requestOnrpLockTime = v418;
                var v419 = _requestOriginalLockExpires; v419.Clean = value; _requestOriginalLockExpires = v419;
                var v420 = _requestPenaltyTerm; v420.Clean = value; _requestPenaltyTerm = v420;
                var v421 = _requestPending; v421.Clean = value; _requestPending = v421;
                var v422 = _requestPrepayPenalty; v422.Clean = value; _requestPrepayPenalty = v422;
                var v423 = _requestPriceRate; v423.Clean = value; _requestPriceRate = v423;
                var v424 = _requestPriceRateRequested; v424.Clean = value; _requestPriceRateRequested = v424;
                var v425 = _requestPriceTotalAdjustment; v425.Clean = value; _requestPriceTotalAdjustment = v425;
                var v426 = _requestRate; v426.Clean = value; _requestRate = v426;
                var v427 = _requestRateRequested; v427.Clean = value; _requestRateRequested = v427;
                var v428 = _requestRateSheetID; v428.Clean = value; _requestRateSheetID = v428;
                var v429 = _requestRateTotalAdjustment; v429.Clean = value; _requestRateTotalAdjustment = v429;
                var v430 = _requestStartingAdjPoint; v430.Clean = value; _requestStartingAdjPoint = v430;
                var v431 = _requestStartingAdjRate; v431.Clean = value; _requestStartingAdjRate = v431;
                var v432 = _requestType; v432.Clean = value; _requestType = v432;
                var v433 = _requestUnDiscountedRate; v433.Clean = value; _requestUnDiscountedRate = v433;
                var v434 = _roundToNearest50; v434.Clean = value; _roundToNearest50 = v434;
                var v435 = _secondSubordinateAmount; v435.Clean = value; _secondSubordinateAmount = v435;
                var v436 = _sellerPaidMIPremium; v436.Clean = value; _sellerPaidMIPremium = v436;
                var v437 = _sellSideAdjustments; v437.Clean = value; _sellSideAdjustments = v437;
                var v438 = _sellSideComments; v438.Clean = value; _sellSideComments = v438;
                var v439 = _sellSideCommitmentContractNumber; v439.Clean = value; _sellSideCommitmentContractNumber = v439;
                var v440 = _sellSideCommitmentDate; v440.Clean = value; _sellSideCommitmentDate = v440;
                var v441 = _sellSideCurrentRateSetDate; v441.Clean = value; _sellSideCurrentRateSetDate = v441;
                var v442 = _sellSideDaystoExtend; v442.Clean = value; _sellSideDaystoExtend = v442;
                var v443 = _sellSideDiscountYSP; v443.Clean = value; _sellSideDiscountYSP = v443;
                var v444 = _sellSideExtendedLockExpires; v444.Clean = value; _sellSideExtendedLockExpires = v444;
                var v445 = _sellSideGuaranteeFee; v445.Clean = value; _sellSideGuaranteeFee = v445;
                var v446 = _sellSideGuarantyBaseFee; v446.Clean = value; _sellSideGuarantyBaseFee = v446;
                var v447 = _sellSideInvestorStatus; v447.Clean = value; _sellSideInvestorStatus = v447;
                var v448 = _sellSideInvestorStatusDate; v448.Clean = value; _sellSideInvestorStatusDate = v448;
                var v449 = _sellSideInvestorTradeNumber; v449.Clean = value; _sellSideInvestorTradeNumber = v449;
                var v450 = _sellSideLoanProgram; v450.Clean = value; _sellSideLoanProgram = v450;
                var v451 = _sellSideLockDate; v451.Clean = value; _sellSideLockDate = v451;
                var v452 = _sellSideLockExpires; v452.Clean = value; _sellSideLockExpires = v452;
                var v453 = _sellSideLockExtendPriceAdjustment; v453.Clean = value; _sellSideLockExtendPriceAdjustment = v453;
                var v454 = _sellSideMarginNetSellRate; v454.Clean = value; _sellSideMarginNetSellRate = v454;
                var v455 = _sellSideMarginRate; v455.Clean = value; _sellSideMarginRate = v455;
                var v456 = _sellSideMarginTotalAdjustment; v456.Clean = value; _sellSideMarginTotalAdjustment = v456;
                var v457 = _sellSideMasterContractNumber; v457.Clean = value; _sellSideMasterContractNumber = v457;
                var v458 = _sellSideMSRValue; v458.Clean = value; _sellSideMSRValue = v458;
                var v459 = _sellSideNetSellPrice; v459.Clean = value; _sellSideNetSellPrice = v459;
                var v460 = _sellSideNetSellRate; v460.Clean = value; _sellSideNetSellRate = v460;
                var v461 = _sellSideNumberOfDays; v461.Clean = value; _sellSideNumberOfDays = v461;
                var v462 = _sellSideOriginalLockExpires; v462.Clean = value; _sellSideOriginalLockExpires = v462;
                var v463 = _sellSidePoolID; v463.Clean = value; _sellSidePoolID = v463;
                var v464 = _sellSidePoolNumber; v464.Clean = value; _sellSidePoolNumber = v464;
                var v465 = _sellSidePriceRate; v465.Clean = value; _sellSidePriceRate = v465;
                var v466 = _sellSidePriceTotalAdjustment; v466.Clean = value; _sellSidePriceTotalAdjustment = v466;
                var v467 = _sellSideProductName; v467.Clean = value; _sellSideProductName = v467;
                var v468 = _sellSideRate; v468.Clean = value; _sellSideRate = v468;
                var v469 = _sellSideRateSheetID; v469.Clean = value; _sellSideRateSheetID = v469;
                var v470 = _sellSideRateTotalAdjustment; v470.Clean = value; _sellSideRateTotalAdjustment = v470;
                var v471 = _sellSideRequestedBy; v471.Clean = value; _sellSideRequestedBy = v471;
                var v472 = _sellSideServicer; v472.Clean = value; _sellSideServicer = v472;
                var v473 = _sellSideServicingFee; v473.Clean = value; _sellSideServicingFee = v473;
                var v474 = _sellSideServicingType; v474.Clean = value; _sellSideServicingType = v474;
                var v475 = _sellSideSRP; v475.Clean = value; _sellSideSRP = v475;
                var v476 = _sellSideSRPPaidOut; v476.Clean = value; _sellSideSRPPaidOut = v476;
                var v477 = _sellSideTradeGuid; v477.Clean = value; _sellSideTradeGuid = v477;
                var v478 = _sellSideTradeMgmtPrevConfirmedLockGuid; v478.Clean = value; _sellSideTradeMgmtPrevConfirmedLockGuid = v478;
                var v479 = _sellSideTradeNumber; v479.Clean = value; _sellSideTradeNumber = v479;
                var v480 = _servicingReleaseIndicator; v480.Clean = value; _servicingReleaseIndicator = v480;
                var v481 = _sRP; v481.Clean = value; _sRP = v481;
                var v482 = _sRPAmount; v482.Clean = value; _sRPAmount = v482;
                var v483 = _sRPPaidOut; v483.Clean = value; _sRPPaidOut = v483;
                var v484 = _subjectPropertyCity; v484.Clean = value; _subjectPropertyCity = v484;
                var v485 = _subjectPropertyCondotelIndicator; v485.Clean = value; _subjectPropertyCondotelIndicator = v485;
                var v486 = _subjectPropertyCounty; v486.Clean = value; _subjectPropertyCounty = v486;
                var v487 = _subjectPropertyNonWarrantableProjectIndicator; v487.Clean = value; _subjectPropertyNonWarrantableProjectIndicator = v487;
                var v488 = _subjectPropertyPostalCode; v488.Clean = value; _subjectPropertyPostalCode = v488;
                var v489 = _subjectPropertyState; v489.Clean = value; _subjectPropertyState = v489;
                var v490 = _subjectPropertyStreetAddress; v490.Clean = value; _subjectPropertyStreetAddress = v490;
                var v491 = _timeLockedWithInvestor; v491.Clean = value; _timeLockedWithInvestor = v491;
                var v492 = _totalBuyPrice; v492.Clean = value; _totalBuyPrice = v492;
                var v493 = _totalForLesserOfSumAsIs; v493.Clean = value; _totalForLesserOfSumAsIs = v493;
                var v494 = _totalPrice; v494.Clean = value; _totalPrice = v494;
                var v495 = _totalSubordinateFinancing; v495.Clean = value; _totalSubordinateFinancing = v495;
                var v496 = _twelveMonthMortgageRentalHistoryIndicator; v496.Clean = value; _twelveMonthMortgageRentalHistoryIndicator = v496;
                var v497 = _type; v497.Clean = value; _type = v497;
                var v498 = _usePoint; v498.Clean = value; _usePoint = v498;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RateLock()
        {
            Clean = true;
        }
    }
}