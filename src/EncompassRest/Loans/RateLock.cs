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
        private Value<string> _correspondentWarehouseBankAcctName;
        public string CorrespondentWarehouseBankAcctName { get { return _correspondentWarehouseBankAcctName; } set { _correspondentWarehouseBankAcctName = value; } }
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
        private Value<string> _correspondentWarehouseBankFurtherCreditAcctName;
        public string CorrespondentWarehouseBankFurtherCreditAcctName { get { return _correspondentWarehouseBankFurtherCreditAcctName; } set { _correspondentWarehouseBankFurtherCreditAcctName = value; } }
        private Value<string> _correspondentWarehouseBankFurtherCreditAcctNum;
        public string CorrespondentWarehouseBankFurtherCreditAcctNum { get { return _correspondentWarehouseBankFurtherCreditAcctNum; } set { _correspondentWarehouseBankFurtherCreditAcctNum = value; } }
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
                    && _correspondentWarehouseBankAcctName.Clean
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
                    && _correspondentWarehouseBankFurtherCreditAcctName.Clean
                    && _correspondentWarehouseBankFurtherCreditAcctNum.Clean
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
                var actualSellAmount = _actualSellAmount; actualSellAmount.Clean = value; _actualSellAmount = actualSellAmount;
                var actualSellPrice = _actualSellPrice; actualSellPrice.Clean = value; _actualSellPrice = actualSellPrice;
                var actualSellSideSRP = _actualSellSideSRP; actualSellSideSRP.Clean = value; _actualSellSideSRP = actualSellSideSRP;
                var actualSRPAmount = _actualSRPAmount; actualSRPAmount.Clean = value; _actualSRPAmount = actualSRPAmount;
                var amountDue = _amountDue; amountDue.Clean = value; _amountDue = amountDue;
                var amountDueTo = _amountDueTo; amountDueTo.Clean = value; _amountDueTo = amountDueTo;
                var amountPaid = _amountPaid; amountPaid.Clean = value; _amountPaid = amountPaid;
                var amountPaidTo = _amountPaidTo; amountPaidTo.Clean = value; _amountPaidTo = amountPaidTo;
                var amountReceived = _amountReceived; amountReceived.Clean = value; _amountReceived = amountReceived;
                var balloonLoanMaturityTermMonths = _balloonLoanMaturityTermMonths; balloonLoanMaturityTermMonths.Clean = value; _balloonLoanMaturityTermMonths = balloonLoanMaturityTermMonths;
                var baseLoanAmount = _baseLoanAmount; baseLoanAmount.Clean = value; _baseLoanAmount = baseLoanAmount;
                var borrowerRequestedLoanAmount = _borrowerRequestedLoanAmount; borrowerRequestedLoanAmount.Clean = value; _borrowerRequestedLoanAmount = borrowerRequestedLoanAmount;
                var branchApprovalDate = _branchApprovalDate; branchApprovalDate.Clean = value; _branchApprovalDate = branchApprovalDate;
                var branchApprovedby = _branchApprovedby; branchApprovedby.Clean = value; _branchApprovedby = branchApprovedby;
                var branchPrice = _branchPrice; branchPrice.Clean = value; _branchPrice = branchPrice;
                var buySideAdjustments = _buySideAdjustments; buySideAdjustments.Clean = value; _buySideAdjustments = buySideAdjustments;
                var buySideComments = _buySideComments; buySideComments.Clean = value; _buySideComments = buySideComments;
                var buySideCommitmentDate = _buySideCommitmentDate; buySideCommitmentDate.Clean = value; _buySideCommitmentDate = buySideCommitmentDate;
                var buySideCommitmentNumber = _buySideCommitmentNumber; buySideCommitmentNumber.Clean = value; _buySideCommitmentNumber = buySideCommitmentNumber;
                var buySideCommitmentType = _buySideCommitmentType; buySideCommitmentType.Clean = value; _buySideCommitmentType = buySideCommitmentType;
                var buySideCurrentRateSetDate = _buySideCurrentRateSetDate; buySideCurrentRateSetDate.Clean = value; _buySideCurrentRateSetDate = buySideCurrentRateSetDate;
                var buySideDaystoExtend = _buySideDaystoExtend; buySideDaystoExtend.Clean = value; _buySideDaystoExtend = buySideDaystoExtend;
                var buySideDeliveryExpirationDate = _buySideDeliveryExpirationDate; buySideDeliveryExpirationDate.Clean = value; _buySideDeliveryExpirationDate = buySideDeliveryExpirationDate;
                var buySideDeliveryType = _buySideDeliveryType; buySideDeliveryType.Clean = value; _buySideDeliveryType = buySideDeliveryType;
                var buySideExpirationDate = _buySideExpirationDate; buySideExpirationDate.Clean = value; _buySideExpirationDate = buySideExpirationDate;
                var buySideExtendedLockExpires = _buySideExtendedLockExpires; buySideExtendedLockExpires.Clean = value; _buySideExtendedLockExpires = buySideExtendedLockExpires;
                var buySideLockDate = _buySideLockDate; buySideLockDate.Clean = value; _buySideLockDate = buySideLockDate;
                var buySideLockExpires = _buySideLockExpires; buySideLockExpires.Clean = value; _buySideLockExpires = buySideLockExpires;
                var buySideLockExtendPriceAdjustment = _buySideLockExtendPriceAdjustment; buySideLockExtendPriceAdjustment.Clean = value; _buySideLockExtendPriceAdjustment = buySideLockExtendPriceAdjustment;
                var buySideMarginNetBuyRate = _buySideMarginNetBuyRate; buySideMarginNetBuyRate.Clean = value; _buySideMarginNetBuyRate = buySideMarginNetBuyRate;
                var buySideMarginRate = _buySideMarginRate; buySideMarginRate.Clean = value; _buySideMarginRate = buySideMarginRate;
                var buySideMarginTotalAdjustment = _buySideMarginTotalAdjustment; buySideMarginTotalAdjustment.Clean = value; _buySideMarginTotalAdjustment = buySideMarginTotalAdjustment;
                var buySideMasterCommitmentNumber = _buySideMasterCommitmentNumber; buySideMasterCommitmentNumber.Clean = value; _buySideMasterCommitmentNumber = buySideMasterCommitmentNumber;
                var buySideNumberOfDays = _buySideNumberOfDays; buySideNumberOfDays.Clean = value; _buySideNumberOfDays = buySideNumberOfDays;
                var buySideOnrpEligible = _buySideOnrpEligible; buySideOnrpEligible.Clean = value; _buySideOnrpEligible = buySideOnrpEligible;
                var buySideOnrpLockDate = _buySideOnrpLockDate; buySideOnrpLockDate.Clean = value; _buySideOnrpLockDate = buySideOnrpLockDate;
                var buySideOnrpLockTime = _buySideOnrpLockTime; buySideOnrpLockTime.Clean = value; _buySideOnrpLockTime = buySideOnrpLockTime;
                var buySideOrgID = _buySideOrgID; buySideOrgID.Clean = value; _buySideOrgID = buySideOrgID;
                var buySideOriginalLockExpires = _buySideOriginalLockExpires; buySideOriginalLockExpires.Clean = value; _buySideOriginalLockExpires = buySideOriginalLockExpires;
                var buySidePriceNetBuyPrice = _buySidePriceNetBuyPrice; buySidePriceNetBuyPrice.Clean = value; _buySidePriceNetBuyPrice = buySidePriceNetBuyPrice;
                var buySidePriceRate = _buySidePriceRate; buySidePriceRate.Clean = value; _buySidePriceRate = buySidePriceRate;
                var buySidePriceTotalAdjustment = _buySidePriceTotalAdjustment; buySidePriceTotalAdjustment.Clean = value; _buySidePriceTotalAdjustment = buySidePriceTotalAdjustment;
                var buySideRate = _buySideRate; buySideRate.Clean = value; _buySideRate = buySideRate;
                var buySideRateNetBuyRate = _buySideRateNetBuyRate; buySideRateNetBuyRate.Clean = value; _buySideRateNetBuyRate = buySideRateNetBuyRate;
                var buySideRateSheetID = _buySideRateSheetID; buySideRateSheetID.Clean = value; _buySideRateSheetID = buySideRateSheetID;
                var buySideRateTotalAdjustment = _buySideRateTotalAdjustment; buySideRateTotalAdjustment.Clean = value; _buySideRateTotalAdjustment = buySideRateTotalAdjustment;
                var buySideRequestedBy = _buySideRequestedBy; buySideRequestedBy.Clean = value; _buySideRequestedBy = buySideRequestedBy;
                var buySideSRPPaidOut = _buySideSRPPaidOut; buySideSRPPaidOut.Clean = value; _buySideSRPPaidOut = buySideSRPPaidOut;
                var buySideStartingAdjPoint = _buySideStartingAdjPoint; buySideStartingAdjPoint.Clean = value; _buySideStartingAdjPoint = buySideStartingAdjPoint;
                var buySideStartingAdjPrice = _buySideStartingAdjPrice; buySideStartingAdjPrice.Clean = value; _buySideStartingAdjPrice = buySideStartingAdjPrice;
                var buySideStartingAdjRate = _buySideStartingAdjRate; buySideStartingAdjRate.Clean = value; _buySideStartingAdjRate = buySideStartingAdjRate;
                var buySideTPOID = _buySideTPOID; buySideTPOID.Clean = value; _buySideTPOID = buySideTPOID;
                var buySideTPOName = _buySideTPOName; buySideTPOName.Clean = value; _buySideTPOName = buySideTPOName;
                var buySideTradeGuid = _buySideTradeGuid; buySideTradeGuid.Clean = value; _buySideTradeGuid = buySideTradeGuid;
                var buySideTradeNumber = _buySideTradeNumber; buySideTradeNumber.Clean = value; _buySideTradeNumber = buySideTradeNumber;
                var buySideUnDiscountedRate = _buySideUnDiscountedRate; buySideUnDiscountedRate.Clean = value; _buySideUnDiscountedRate = buySideUnDiscountedRate;
                var cancellationRequestPending = _cancellationRequestPending; cancellationRequestPending.Clean = value; _cancellationRequestPending = cancellationRequestPending;
                var combinedLTV = _combinedLTV; combinedLTV.Clean = value; _combinedLTV = combinedLTV;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var commitment = _commitment; commitment.Clean = value; _commitment = commitment;
                var commitmentType = _commitmentType; commitmentType.Clean = value; _commitmentType = commitmentType;
                var compGainLossPercentage = _compGainLossPercentage; compGainLossPercentage.Clean = value; _compGainLossPercentage = compGainLossPercentage;
                var compGainLossPrice = _compGainLossPrice; compGainLossPrice.Clean = value; _compGainLossPrice = compGainLossPrice;
                var compGainLossTotalBuyPrice = _compGainLossTotalBuyPrice; compGainLossTotalBuyPrice.Clean = value; _compGainLossTotalBuyPrice = compGainLossTotalBuyPrice;
                var compGainLossTotalCompPrice = _compGainLossTotalCompPrice; compGainLossTotalCompPrice.Clean = value; _compGainLossTotalCompPrice = compGainLossTotalCompPrice;
                var compInvestorAddress = _compInvestorAddress; compInvestorAddress.Clean = value; _compInvestorAddress = compInvestorAddress;
                var compInvestorCity = _compInvestorCity; compInvestorCity.Clean = value; _compInvestorCity = compInvestorCity;
                var compInvestorCommitment = _compInvestorCommitment; compInvestorCommitment.Clean = value; _compInvestorCommitment = compInvestorCommitment;
                var compInvestorContact = _compInvestorContact; compInvestorContact.Clean = value; _compInvestorContact = compInvestorContact;
                var compInvestorEmail = _compInvestorEmail; compInvestorEmail.Clean = value; _compInvestorEmail = compInvestorEmail;
                var compInvestorLockType = _compInvestorLockType; compInvestorLockType.Clean = value; _compInvestorLockType = compInvestorLockType;
                var compInvestorName = _compInvestorName; compInvestorName.Clean = value; _compInvestorName = compInvestorName;
                var compInvestorPhone = _compInvestorPhone; compInvestorPhone.Clean = value; _compInvestorPhone = compInvestorPhone;
                var compInvestorPostalCode = _compInvestorPostalCode; compInvestorPostalCode.Clean = value; _compInvestorPostalCode = compInvestorPostalCode;
                var compInvestorProgramCode = _compInvestorProgramCode; compInvestorProgramCode.Clean = value; _compInvestorProgramCode = compInvestorProgramCode;
                var compInvestorState = _compInvestorState; compInvestorState.Clean = value; _compInvestorState = compInvestorState;
                var compInvestorTemplateName = _compInvestorTemplateName; compInvestorTemplateName.Clean = value; _compInvestorTemplateName = compInvestorTemplateName;
                var compInvestorWebsite = _compInvestorWebsite; compInvestorWebsite.Clean = value; _compInvestorWebsite = compInvestorWebsite;
                var compSideAdjustments = _compSideAdjustments; compSideAdjustments.Clean = value; _compSideAdjustments = compSideAdjustments;
                var compSideComments = _compSideComments; compSideComments.Clean = value; _compSideComments = compSideComments;
                var compSideComparisonedBy = _compSideComparisonedBy; compSideComparisonedBy.Clean = value; _compSideComparisonedBy = compSideComparisonedBy;
                var compSideCurrentRateSetDate = _compSideCurrentRateSetDate; compSideCurrentRateSetDate.Clean = value; _compSideCurrentRateSetDate = compSideCurrentRateSetDate;
                var compSideDaystoExtend = _compSideDaystoExtend; compSideDaystoExtend.Clean = value; _compSideDaystoExtend = compSideDaystoExtend;
                var compSideDiscountYSP = _compSideDiscountYSP; compSideDiscountYSP.Clean = value; _compSideDiscountYSP = compSideDiscountYSP;
                var compSideExtendedLockExpires = _compSideExtendedLockExpires; compSideExtendedLockExpires.Clean = value; _compSideExtendedLockExpires = compSideExtendedLockExpires;
                var compSideInvestorStatus = _compSideInvestorStatus; compSideInvestorStatus.Clean = value; _compSideInvestorStatus = compSideInvestorStatus;
                var compSideInvestorStatusDate = _compSideInvestorStatusDate; compSideInvestorStatusDate.Clean = value; _compSideInvestorStatusDate = compSideInvestorStatusDate;
                var compSideInvestorTradeNumber = _compSideInvestorTradeNumber; compSideInvestorTradeNumber.Clean = value; _compSideInvestorTradeNumber = compSideInvestorTradeNumber;
                var compSideLoanProgram = _compSideLoanProgram; compSideLoanProgram.Clean = value; _compSideLoanProgram = compSideLoanProgram;
                var compSideLockDate = _compSideLockDate; compSideLockDate.Clean = value; _compSideLockDate = compSideLockDate;
                var compSideLockExpires = _compSideLockExpires; compSideLockExpires.Clean = value; _compSideLockExpires = compSideLockExpires;
                var compSideLockExtendPriceAdjustment = _compSideLockExtendPriceAdjustment; compSideLockExtendPriceAdjustment.Clean = value; _compSideLockExtendPriceAdjustment = compSideLockExtendPriceAdjustment;
                var compSideMarginNetCompRate = _compSideMarginNetCompRate; compSideMarginNetCompRate.Clean = value; _compSideMarginNetCompRate = compSideMarginNetCompRate;
                var compSideMarginRate = _compSideMarginRate; compSideMarginRate.Clean = value; _compSideMarginRate = compSideMarginRate;
                var compSideMarginTotalAdjustment = _compSideMarginTotalAdjustment; compSideMarginTotalAdjustment.Clean = value; _compSideMarginTotalAdjustment = compSideMarginTotalAdjustment;
                var compSideMasterContractNumber = _compSideMasterContractNumber; compSideMasterContractNumber.Clean = value; _compSideMasterContractNumber = compSideMasterContractNumber;
                var compSideNetCompPrice = _compSideNetCompPrice; compSideNetCompPrice.Clean = value; _compSideNetCompPrice = compSideNetCompPrice;
                var compSideNetCompRate = _compSideNetCompRate; compSideNetCompRate.Clean = value; _compSideNetCompRate = compSideNetCompRate;
                var compSideNumberOfDays = _compSideNumberOfDays; compSideNumberOfDays.Clean = value; _compSideNumberOfDays = compSideNumberOfDays;
                var compSideOriginalLockExpires = _compSideOriginalLockExpires; compSideOriginalLockExpires.Clean = value; _compSideOriginalLockExpires = compSideOriginalLockExpires;
                var compSidePriceRate = _compSidePriceRate; compSidePriceRate.Clean = value; _compSidePriceRate = compSidePriceRate;
                var compSidePriceTotalAdjustment = _compSidePriceTotalAdjustment; compSidePriceTotalAdjustment.Clean = value; _compSidePriceTotalAdjustment = compSidePriceTotalAdjustment;
                var compSideRate = _compSideRate; compSideRate.Clean = value; _compSideRate = compSideRate;
                var compSideRateSheetID = _compSideRateSheetID; compSideRateSheetID.Clean = value; _compSideRateSheetID = compSideRateSheetID;
                var compSideRateTotalAdjustment = _compSideRateTotalAdjustment; compSideRateTotalAdjustment.Clean = value; _compSideRateTotalAdjustment = compSideRateTotalAdjustment;
                var compSideRequestedBy = _compSideRequestedBy; compSideRequestedBy.Clean = value; _compSideRequestedBy = compSideRequestedBy;
                var compSideServicingType = _compSideServicingType; compSideServicingType.Clean = value; _compSideServicingType = compSideServicingType;
                var compSideSRPPaidOut = _compSideSRPPaidOut; compSideSRPPaidOut.Clean = value; _compSideSRPPaidOut = compSideSRPPaidOut;
                var compSideTradeGuid = _compSideTradeGuid; compSideTradeGuid.Clean = value; _compSideTradeGuid = compSideTradeGuid;
                var compSideTradeNumber = _compSideTradeNumber; compSideTradeNumber.Clean = value; _compSideTradeNumber = compSideTradeNumber;
                var confirmedBy = _confirmedBy; confirmedBy.Clean = value; _confirmedBy = confirmedBy;
                var confirmedDate = _confirmedDate; confirmedDate.Clean = value; _confirmedDate = confirmedDate;
                var corporateApprovalDate = _corporateApprovalDate; corporateApprovalDate.Clean = value; _corporateApprovalDate = corporateApprovalDate;
                var corporateApprovedby = _corporateApprovedby; corporateApprovedby.Clean = value; _corporateApprovedby = corporateApprovedby;
                var corporatePrice = _corporatePrice; corporatePrice.Clean = value; _corporatePrice = corporatePrice;
                var correspondentAdditionalEscrowAdditionalEscrow = _correspondentAdditionalEscrowAdditionalEscrow; correspondentAdditionalEscrowAdditionalEscrow.Clean = value; _correspondentAdditionalEscrowAdditionalEscrow = correspondentAdditionalEscrowAdditionalEscrow;
                var correspondentAdditionalEscrowAmount1007 = _correspondentAdditionalEscrowAmount1007; correspondentAdditionalEscrowAmount1007.Clean = value; _correspondentAdditionalEscrowAmount1007 = correspondentAdditionalEscrowAmount1007;
                var correspondentAdditionalEscrowAmount1008 = _correspondentAdditionalEscrowAmount1008; correspondentAdditionalEscrowAmount1008.Clean = value; _correspondentAdditionalEscrowAmount1008 = correspondentAdditionalEscrowAmount1008;
                var correspondentAdditionalEscrowAmount1009 = _correspondentAdditionalEscrowAmount1009; correspondentAdditionalEscrowAmount1009.Clean = value; _correspondentAdditionalEscrowAmount1009 = correspondentAdditionalEscrowAmount1009;
                var correspondentAdditionalEscrowCityPropertyTax = _correspondentAdditionalEscrowCityPropertyTax; correspondentAdditionalEscrowCityPropertyTax.Clean = value; _correspondentAdditionalEscrowCityPropertyTax = correspondentAdditionalEscrowCityPropertyTax;
                var correspondentAdditionalEscrowDescription1007 = _correspondentAdditionalEscrowDescription1007; correspondentAdditionalEscrowDescription1007.Clean = value; _correspondentAdditionalEscrowDescription1007 = correspondentAdditionalEscrowDescription1007;
                var correspondentAdditionalEscrowDescription1008 = _correspondentAdditionalEscrowDescription1008; correspondentAdditionalEscrowDescription1008.Clean = value; _correspondentAdditionalEscrowDescription1008 = correspondentAdditionalEscrowDescription1008;
                var correspondentAdditionalEscrowDescription1009 = _correspondentAdditionalEscrowDescription1009; correspondentAdditionalEscrowDescription1009.Clean = value; _correspondentAdditionalEscrowDescription1009 = correspondentAdditionalEscrowDescription1009;
                var correspondentAdditionalEscrowFloodInsurance = _correspondentAdditionalEscrowFloodInsurance; correspondentAdditionalEscrowFloodInsurance.Clean = value; _correspondentAdditionalEscrowFloodInsurance = correspondentAdditionalEscrowFloodInsurance;
                var correspondentAdditionalEscrowHomeInsurance = _correspondentAdditionalEscrowHomeInsurance; correspondentAdditionalEscrowHomeInsurance.Clean = value; _correspondentAdditionalEscrowHomeInsurance = correspondentAdditionalEscrowHomeInsurance;
                var correspondentAdditionalEscrowMIMIP = _correspondentAdditionalEscrowMIMIP; correspondentAdditionalEscrowMIMIP.Clean = value; _correspondentAdditionalEscrowMIMIP = correspondentAdditionalEscrowMIMIP;
                var correspondentAdditionalEscrowNumOfPayments = _correspondentAdditionalEscrowNumOfPayments; correspondentAdditionalEscrowNumOfPayments.Clean = value; _correspondentAdditionalEscrowNumOfPayments = correspondentAdditionalEscrowNumOfPayments;
                var correspondentAdditionalEscrowOption1Amount = _correspondentAdditionalEscrowOption1Amount; correspondentAdditionalEscrowOption1Amount.Clean = value; _correspondentAdditionalEscrowOption1Amount = correspondentAdditionalEscrowOption1Amount;
                var correspondentAdditionalEscrowOption1Desc = _correspondentAdditionalEscrowOption1Desc; correspondentAdditionalEscrowOption1Desc.Clean = value; _correspondentAdditionalEscrowOption1Desc = correspondentAdditionalEscrowOption1Desc;
                var correspondentAdditionalEscrowOption2Amount = _correspondentAdditionalEscrowOption2Amount; correspondentAdditionalEscrowOption2Amount.Clean = value; _correspondentAdditionalEscrowOption2Amount = correspondentAdditionalEscrowOption2Amount;
                var correspondentAdditionalEscrowOption2Desc = _correspondentAdditionalEscrowOption2Desc; correspondentAdditionalEscrowOption2Desc.Clean = value; _correspondentAdditionalEscrowOption2Desc = correspondentAdditionalEscrowOption2Desc;
                var correspondentAdditionalEscrowPropertyTax = _correspondentAdditionalEscrowPropertyTax; correspondentAdditionalEscrowPropertyTax.Clean = value; _correspondentAdditionalEscrowPropertyTax = correspondentAdditionalEscrowPropertyTax;
                var correspondentAdditionalEscrowSumOfPayments = _correspondentAdditionalEscrowSumOfPayments; correspondentAdditionalEscrowSumOfPayments.Clean = value; _correspondentAdditionalEscrowSumOfPayments = correspondentAdditionalEscrowSumOfPayments;
                var correspondentAdditionalEscrowUSDAAnnualFee = _correspondentAdditionalEscrowUSDAAnnualFee; correspondentAdditionalEscrowUSDAAnnualFee.Clean = value; _correspondentAdditionalEscrowUSDAAnnualFee = correspondentAdditionalEscrowUSDAAnnualFee;
                var correspondentAdditionalLineAmount1 = _correspondentAdditionalLineAmount1; correspondentAdditionalLineAmount1.Clean = value; _correspondentAdditionalLineAmount1 = correspondentAdditionalLineAmount1;
                var correspondentAdditionalLineAmount10 = _correspondentAdditionalLineAmount10; correspondentAdditionalLineAmount10.Clean = value; _correspondentAdditionalLineAmount10 = correspondentAdditionalLineAmount10;
                var correspondentAdditionalLineAmount11 = _correspondentAdditionalLineAmount11; correspondentAdditionalLineAmount11.Clean = value; _correspondentAdditionalLineAmount11 = correspondentAdditionalLineAmount11;
                var correspondentAdditionalLineAmount12 = _correspondentAdditionalLineAmount12; correspondentAdditionalLineAmount12.Clean = value; _correspondentAdditionalLineAmount12 = correspondentAdditionalLineAmount12;
                var correspondentAdditionalLineAmount13 = _correspondentAdditionalLineAmount13; correspondentAdditionalLineAmount13.Clean = value; _correspondentAdditionalLineAmount13 = correspondentAdditionalLineAmount13;
                var correspondentAdditionalLineAmount2 = _correspondentAdditionalLineAmount2; correspondentAdditionalLineAmount2.Clean = value; _correspondentAdditionalLineAmount2 = correspondentAdditionalLineAmount2;
                var correspondentAdditionalLineAmount3 = _correspondentAdditionalLineAmount3; correspondentAdditionalLineAmount3.Clean = value; _correspondentAdditionalLineAmount3 = correspondentAdditionalLineAmount3;
                var correspondentAdditionalLineAmount4 = _correspondentAdditionalLineAmount4; correspondentAdditionalLineAmount4.Clean = value; _correspondentAdditionalLineAmount4 = correspondentAdditionalLineAmount4;
                var correspondentAdditionalLineAmount5 = _correspondentAdditionalLineAmount5; correspondentAdditionalLineAmount5.Clean = value; _correspondentAdditionalLineAmount5 = correspondentAdditionalLineAmount5;
                var correspondentAdditionalLineAmount6 = _correspondentAdditionalLineAmount6; correspondentAdditionalLineAmount6.Clean = value; _correspondentAdditionalLineAmount6 = correspondentAdditionalLineAmount6;
                var correspondentAdditionalLineAmount7 = _correspondentAdditionalLineAmount7; correspondentAdditionalLineAmount7.Clean = value; _correspondentAdditionalLineAmount7 = correspondentAdditionalLineAmount7;
                var correspondentAdditionalLineAmount8 = _correspondentAdditionalLineAmount8; correspondentAdditionalLineAmount8.Clean = value; _correspondentAdditionalLineAmount8 = correspondentAdditionalLineAmount8;
                var correspondentAdditionalLineAmount9 = _correspondentAdditionalLineAmount9; correspondentAdditionalLineAmount9.Clean = value; _correspondentAdditionalLineAmount9 = correspondentAdditionalLineAmount9;
                var correspondentAdditionalLineDescription1 = _correspondentAdditionalLineDescription1; correspondentAdditionalLineDescription1.Clean = value; _correspondentAdditionalLineDescription1 = correspondentAdditionalLineDescription1;
                var correspondentAdditionalLineDescription10 = _correspondentAdditionalLineDescription10; correspondentAdditionalLineDescription10.Clean = value; _correspondentAdditionalLineDescription10 = correspondentAdditionalLineDescription10;
                var correspondentAdditionalLineDescription11 = _correspondentAdditionalLineDescription11; correspondentAdditionalLineDescription11.Clean = value; _correspondentAdditionalLineDescription11 = correspondentAdditionalLineDescription11;
                var correspondentAdditionalLineDescription12 = _correspondentAdditionalLineDescription12; correspondentAdditionalLineDescription12.Clean = value; _correspondentAdditionalLineDescription12 = correspondentAdditionalLineDescription12;
                var correspondentAdditionalLineDescription2 = _correspondentAdditionalLineDescription2; correspondentAdditionalLineDescription2.Clean = value; _correspondentAdditionalLineDescription2 = correspondentAdditionalLineDescription2;
                var correspondentAdditionalLineDescription3 = _correspondentAdditionalLineDescription3; correspondentAdditionalLineDescription3.Clean = value; _correspondentAdditionalLineDescription3 = correspondentAdditionalLineDescription3;
                var correspondentAdditionalLineDescription4 = _correspondentAdditionalLineDescription4; correspondentAdditionalLineDescription4.Clean = value; _correspondentAdditionalLineDescription4 = correspondentAdditionalLineDescription4;
                var correspondentAdditionalLineDescription5 = _correspondentAdditionalLineDescription5; correspondentAdditionalLineDescription5.Clean = value; _correspondentAdditionalLineDescription5 = correspondentAdditionalLineDescription5;
                var correspondentAdditionalLineDescription6 = _correspondentAdditionalLineDescription6; correspondentAdditionalLineDescription6.Clean = value; _correspondentAdditionalLineDescription6 = correspondentAdditionalLineDescription6;
                var correspondentAdditionalLineDescription7 = _correspondentAdditionalLineDescription7; correspondentAdditionalLineDescription7.Clean = value; _correspondentAdditionalLineDescription7 = correspondentAdditionalLineDescription7;
                var correspondentAdditionalLineDescription8 = _correspondentAdditionalLineDescription8; correspondentAdditionalLineDescription8.Clean = value; _correspondentAdditionalLineDescription8 = correspondentAdditionalLineDescription8;
                var correspondentAdditionalLineDescription9 = _correspondentAdditionalLineDescription9; correspondentAdditionalLineDescription9.Clean = value; _correspondentAdditionalLineDescription9 = correspondentAdditionalLineDescription9;
                var correspondentAdditionalLineTotalAmount = _correspondentAdditionalLineTotalAmount; correspondentAdditionalLineTotalAmount.Clean = value; _correspondentAdditionalLineTotalAmount = correspondentAdditionalLineTotalAmount;
                var correspondentAdjusterAmount1 = _correspondentAdjusterAmount1; correspondentAdjusterAmount1.Clean = value; _correspondentAdjusterAmount1 = correspondentAdjusterAmount1;
                var correspondentAdjusterAmount2 = _correspondentAdjusterAmount2; correspondentAdjusterAmount2.Clean = value; _correspondentAdjusterAmount2 = correspondentAdjusterAmount2;
                var correspondentAdjusterAmount3 = _correspondentAdjusterAmount3; correspondentAdjusterAmount3.Clean = value; _correspondentAdjusterAmount3 = correspondentAdjusterAmount3;
                var correspondentAdjusterDescription1 = _correspondentAdjusterDescription1; correspondentAdjusterDescription1.Clean = value; _correspondentAdjusterDescription1 = correspondentAdjusterDescription1;
                var correspondentAdjusterDescription2 = _correspondentAdjusterDescription2; correspondentAdjusterDescription2.Clean = value; _correspondentAdjusterDescription2 = correspondentAdjusterDescription2;
                var correspondentAdjusterDescription3 = _correspondentAdjusterDescription3; correspondentAdjusterDescription3.Clean = value; _correspondentAdjusterDescription3 = correspondentAdjusterDescription3;
                var correspondentConfirmedBy = _correspondentConfirmedBy; correspondentConfirmedBy.Clean = value; _correspondentConfirmedBy = correspondentConfirmedBy;
                var correspondentConfirmedDate = _correspondentConfirmedDate; correspondentConfirmedDate.Clean = value; _correspondentConfirmedDate = correspondentConfirmedDate;
                var correspondentCurrentImpounds = _correspondentCurrentImpounds; correspondentCurrentImpounds.Clean = value; _correspondentCurrentImpounds = correspondentCurrentImpounds;
                var correspondentCurrentPrincipal = _correspondentCurrentPrincipal; correspondentCurrentPrincipal.Clean = value; _correspondentCurrentPrincipal = correspondentCurrentPrincipal;
                var correspondentDate = _correspondentDate; correspondentDate.Clean = value; _correspondentDate = correspondentDate;
                var correspondentEscrowDisbursementsAmount1007 = _correspondentEscrowDisbursementsAmount1007; correspondentEscrowDisbursementsAmount1007.Clean = value; _correspondentEscrowDisbursementsAmount1007 = correspondentEscrowDisbursementsAmount1007;
                var correspondentEscrowDisbursementsAmount1008 = _correspondentEscrowDisbursementsAmount1008; correspondentEscrowDisbursementsAmount1008.Clean = value; _correspondentEscrowDisbursementsAmount1008 = correspondentEscrowDisbursementsAmount1008;
                var correspondentEscrowDisbursementsAmount1009 = _correspondentEscrowDisbursementsAmount1009; correspondentEscrowDisbursementsAmount1009.Clean = value; _correspondentEscrowDisbursementsAmount1009 = correspondentEscrowDisbursementsAmount1009;
                var correspondentEscrowDisbursementsCityPropertyTax = _correspondentEscrowDisbursementsCityPropertyTax; correspondentEscrowDisbursementsCityPropertyTax.Clean = value; _correspondentEscrowDisbursementsCityPropertyTax = correspondentEscrowDisbursementsCityPropertyTax;
                var correspondentEscrowDisbursementsDescription1007 = _correspondentEscrowDisbursementsDescription1007; correspondentEscrowDisbursementsDescription1007.Clean = value; _correspondentEscrowDisbursementsDescription1007 = correspondentEscrowDisbursementsDescription1007;
                var correspondentEscrowDisbursementsDescription1008 = _correspondentEscrowDisbursementsDescription1008; correspondentEscrowDisbursementsDescription1008.Clean = value; _correspondentEscrowDisbursementsDescription1008 = correspondentEscrowDisbursementsDescription1008;
                var correspondentEscrowDisbursementsDescription1009 = _correspondentEscrowDisbursementsDescription1009; correspondentEscrowDisbursementsDescription1009.Clean = value; _correspondentEscrowDisbursementsDescription1009 = correspondentEscrowDisbursementsDescription1009;
                var correspondentEscrowDisbursementsEscrowsToBePaidBySeller = _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; correspondentEscrowDisbursementsEscrowsToBePaidBySeller.Clean = value; _correspondentEscrowDisbursementsEscrowsToBePaidBySeller = correspondentEscrowDisbursementsEscrowsToBePaidBySeller;
                var correspondentEscrowDisbursementsEsrowFundedByInvestor = _correspondentEscrowDisbursementsEsrowFundedByInvestor; correspondentEscrowDisbursementsEsrowFundedByInvestor.Clean = value; _correspondentEscrowDisbursementsEsrowFundedByInvestor = correspondentEscrowDisbursementsEsrowFundedByInvestor;
                var correspondentEscrowDisbursementsFloodInsurance = _correspondentEscrowDisbursementsFloodInsurance; correspondentEscrowDisbursementsFloodInsurance.Clean = value; _correspondentEscrowDisbursementsFloodInsurance = correspondentEscrowDisbursementsFloodInsurance;
                var correspondentEscrowDisbursementsHomeInsurance = _correspondentEscrowDisbursementsHomeInsurance; correspondentEscrowDisbursementsHomeInsurance.Clean = value; _correspondentEscrowDisbursementsHomeInsurance = correspondentEscrowDisbursementsHomeInsurance;
                var correspondentEscrowDisbursementsMortgageInsurance = _correspondentEscrowDisbursementsMortgageInsurance; correspondentEscrowDisbursementsMortgageInsurance.Clean = value; _correspondentEscrowDisbursementsMortgageInsurance = correspondentEscrowDisbursementsMortgageInsurance;
                var correspondentEscrowDisbursementsOption1Amount = _correspondentEscrowDisbursementsOption1Amount; correspondentEscrowDisbursementsOption1Amount.Clean = value; _correspondentEscrowDisbursementsOption1Amount = correspondentEscrowDisbursementsOption1Amount;
                var correspondentEscrowDisbursementsOption1Desc = _correspondentEscrowDisbursementsOption1Desc; correspondentEscrowDisbursementsOption1Desc.Clean = value; _correspondentEscrowDisbursementsOption1Desc = correspondentEscrowDisbursementsOption1Desc;
                var correspondentEscrowDisbursementsOption2Amount = _correspondentEscrowDisbursementsOption2Amount; correspondentEscrowDisbursementsOption2Amount.Clean = value; _correspondentEscrowDisbursementsOption2Amount = correspondentEscrowDisbursementsOption2Amount;
                var correspondentEscrowDisbursementsOption2Desc = _correspondentEscrowDisbursementsOption2Desc; correspondentEscrowDisbursementsOption2Desc.Clean = value; _correspondentEscrowDisbursementsOption2Desc = correspondentEscrowDisbursementsOption2Desc;
                var correspondentEscrowDisbursementsPropertyTax = _correspondentEscrowDisbursementsPropertyTax; correspondentEscrowDisbursementsPropertyTax.Clean = value; _correspondentEscrowDisbursementsPropertyTax = correspondentEscrowDisbursementsPropertyTax;
                var correspondentEscrowDisbursementsUSDAAnnualFee = _correspondentEscrowDisbursementsUSDAAnnualFee; correspondentEscrowDisbursementsUSDAAnnualFee.Clean = value; _correspondentEscrowDisbursementsUSDAAnnualFee = correspondentEscrowDisbursementsUSDAAnnualFee;
                var correspondentFinalBuyAmount = _correspondentFinalBuyAmount; correspondentFinalBuyAmount.Clean = value; _correspondentFinalBuyAmount = correspondentFinalBuyAmount;
                var correspondentFinalBuyPrice = _correspondentFinalBuyPrice; correspondentFinalBuyPrice.Clean = value; _correspondentFinalBuyPrice = correspondentFinalBuyPrice;
                var correspondentFinalCDAggAdjAmount = _correspondentFinalCDAggAdjAmount; correspondentFinalCDAggAdjAmount.Clean = value; _correspondentFinalCDAggAdjAmount = correspondentFinalCDAggAdjAmount;
                var correspondentFinalCDAmount1007 = _correspondentFinalCDAmount1007; correspondentFinalCDAmount1007.Clean = value; _correspondentFinalCDAmount1007 = correspondentFinalCDAmount1007;
                var correspondentFinalCDAmount1008 = _correspondentFinalCDAmount1008; correspondentFinalCDAmount1008.Clean = value; _correspondentFinalCDAmount1008 = correspondentFinalCDAmount1008;
                var correspondentFinalCDAmount1009 = _correspondentFinalCDAmount1009; correspondentFinalCDAmount1009.Clean = value; _correspondentFinalCDAmount1009 = correspondentFinalCDAmount1009;
                var correspondentFinalCDCityPropertyTax = _correspondentFinalCDCityPropertyTax; correspondentFinalCDCityPropertyTax.Clean = value; _correspondentFinalCDCityPropertyTax = correspondentFinalCDCityPropertyTax;
                var correspondentFinalCDDescription1007 = _correspondentFinalCDDescription1007; correspondentFinalCDDescription1007.Clean = value; _correspondentFinalCDDescription1007 = correspondentFinalCDDescription1007;
                var correspondentFinalCDDescription1008 = _correspondentFinalCDDescription1008; correspondentFinalCDDescription1008.Clean = value; _correspondentFinalCDDescription1008 = correspondentFinalCDDescription1008;
                var correspondentFinalCDDescription1009 = _correspondentFinalCDDescription1009; correspondentFinalCDDescription1009.Clean = value; _correspondentFinalCDDescription1009 = correspondentFinalCDDescription1009;
                var correspondentFinalCDFloodInsurance = _correspondentFinalCDFloodInsurance; correspondentFinalCDFloodInsurance.Clean = value; _correspondentFinalCDFloodInsurance = correspondentFinalCDFloodInsurance;
                var correspondentFinalCDHomeInsurance = _correspondentFinalCDHomeInsurance; correspondentFinalCDHomeInsurance.Clean = value; _correspondentFinalCDHomeInsurance = correspondentFinalCDHomeInsurance;
                var correspondentFinalCDMortgageInsurance = _correspondentFinalCDMortgageInsurance; correspondentFinalCDMortgageInsurance.Clean = value; _correspondentFinalCDMortgageInsurance = correspondentFinalCDMortgageInsurance;
                var correspondentFinalCDOption1Amount = _correspondentFinalCDOption1Amount; correspondentFinalCDOption1Amount.Clean = value; _correspondentFinalCDOption1Amount = correspondentFinalCDOption1Amount;
                var correspondentFinalCDOption1Desc = _correspondentFinalCDOption1Desc; correspondentFinalCDOption1Desc.Clean = value; _correspondentFinalCDOption1Desc = correspondentFinalCDOption1Desc;
                var correspondentFinalCDOption2Amount = _correspondentFinalCDOption2Amount; correspondentFinalCDOption2Amount.Clean = value; _correspondentFinalCDOption2Amount = correspondentFinalCDOption2Amount;
                var correspondentFinalCDOption2Desc = _correspondentFinalCDOption2Desc; correspondentFinalCDOption2Desc.Clean = value; _correspondentFinalCDOption2Desc = correspondentFinalCDOption2Desc;
                var correspondentFinalCDPropertyTax = _correspondentFinalCDPropertyTax; correspondentFinalCDPropertyTax.Clean = value; _correspondentFinalCDPropertyTax = correspondentFinalCDPropertyTax;
                var correspondentFinalCDReservesCollectedAtClosing = _correspondentFinalCDReservesCollectedAtClosing; correspondentFinalCDReservesCollectedAtClosing.Clean = value; _correspondentFinalCDReservesCollectedAtClosing = correspondentFinalCDReservesCollectedAtClosing;
                var correspondentFinalCDUSDAAnnualFee = _correspondentFinalCDUSDAAnnualFee; correspondentFinalCDUSDAAnnualFee.Clean = value; _correspondentFinalCDUSDAAnnualFee = correspondentFinalCDUSDAAnnualFee;
                var correspondentFirstPaymentDate = _correspondentFirstPaymentDate; correspondentFirstPaymentDate.Clean = value; _correspondentFirstPaymentDate = correspondentFirstPaymentDate;
                var correspondentImpounds = _correspondentImpounds; correspondentImpounds.Clean = value; _correspondentImpounds = correspondentImpounds;
                var correspondentInterest = _correspondentInterest; correspondentInterest.Clean = value; _correspondentInterest = correspondentInterest;
                var correspondentInterestDays = _correspondentInterestDays; correspondentInterestDays.Clean = value; _correspondentInterestDays = correspondentInterestDays;
                var correspondentLateFeeAmount = _correspondentLateFeeAmount; correspondentLateFeeAmount.Clean = value; _correspondentLateFeeAmount = correspondentLateFeeAmount;
                var correspondentLateFeePriceAdjustment = _correspondentLateFeePriceAdjustment; correspondentLateFeePriceAdjustment.Clean = value; _correspondentLateFeePriceAdjustment = correspondentLateFeePriceAdjustment;
                var correspondentPaidToDate = _correspondentPaidToDate; correspondentPaidToDate.Clean = value; _correspondentPaidToDate = correspondentPaidToDate;
                var correspondentPaymentHistoryAnticipatedPurchaseDate = _correspondentPaymentHistoryAnticipatedPurchaseDate; correspondentPaymentHistoryAnticipatedPurchaseDate.Clean = value; _correspondentPaymentHistoryAnticipatedPurchaseDate = correspondentPaymentHistoryAnticipatedPurchaseDate;
                var correspondentPaymentHistoryCalculatedPurchasedPrincipal = _correspondentPaymentHistoryCalculatedPurchasedPrincipal; correspondentPaymentHistoryCalculatedPurchasedPrincipal.Clean = value; _correspondentPaymentHistoryCalculatedPurchasedPrincipal = correspondentPaymentHistoryCalculatedPurchasedPrincipal;
                var correspondentPaymentHistoryFirstBorrowerPaymentDueDate = _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; correspondentPaymentHistoryFirstBorrowerPaymentDueDate.Clean = value; _correspondentPaymentHistoryFirstBorrowerPaymentDueDate = correspondentPaymentHistoryFirstBorrowerPaymentDueDate;
                var correspondentPaymentHistoryFirstInvestorPaymentDate = _correspondentPaymentHistoryFirstInvestorPaymentDate; correspondentPaymentHistoryFirstInvestorPaymentDate.Clean = value; _correspondentPaymentHistoryFirstInvestorPaymentDate = correspondentPaymentHistoryFirstInvestorPaymentDate;
                var correspondentPaymentHistoryNoteDate = _correspondentPaymentHistoryNoteDate; correspondentPaymentHistoryNoteDate.Clean = value; _correspondentPaymentHistoryNoteDate = correspondentPaymentHistoryNoteDate;
                var correspondentPaymentHistoryPricipalReduction = _correspondentPaymentHistoryPricipalReduction; correspondentPaymentHistoryPricipalReduction.Clean = value; _correspondentPaymentHistoryPricipalReduction = correspondentPaymentHistoryPricipalReduction;
                var correspondentPurchasedPrincipal = _correspondentPurchasedPrincipal; correspondentPurchasedPrincipal.Clean = value; _correspondentPurchasedPrincipal = correspondentPurchasedPrincipal;
                var correspondentReconcilationComments = _correspondentReconcilationComments; correspondentReconcilationComments.Clean = value; _correspondentReconcilationComments = correspondentReconcilationComments;
                var correspondentRemainingBuydownAmount = _correspondentRemainingBuydownAmount; correspondentRemainingBuydownAmount.Clean = value; _correspondentRemainingBuydownAmount = correspondentRemainingBuydownAmount;
                var correspondentSRPAmount = _correspondentSRPAmount; correspondentSRPAmount.Clean = value; _correspondentSRPAmount = correspondentSRPAmount;
                var correspondentTotalBuyAmount = _correspondentTotalBuyAmount; correspondentTotalBuyAmount.Clean = value; _correspondentTotalBuyAmount = correspondentTotalBuyAmount;
                var correspondentTotalFees = _correspondentTotalFees; correspondentTotalFees.Clean = value; _correspondentTotalFees = correspondentTotalFees;
                var correspondentWarehouseBankABANum = _correspondentWarehouseBankABANum; correspondentWarehouseBankABANum.Clean = value; _correspondentWarehouseBankABANum = correspondentWarehouseBankABANum;
                var correspondentWarehouseBankAcctName = _correspondentWarehouseBankAcctName; correspondentWarehouseBankAcctName.Clean = value; _correspondentWarehouseBankAcctName = correspondentWarehouseBankAcctName;
                var correspondentWarehouseBankAcctNum = _correspondentWarehouseBankAcctNum; correspondentWarehouseBankAcctNum.Clean = value; _correspondentWarehouseBankAcctNum = correspondentWarehouseBankAcctNum;
                var correspondentWarehouseBankAddress = _correspondentWarehouseBankAddress; correspondentWarehouseBankAddress.Clean = value; _correspondentWarehouseBankAddress = correspondentWarehouseBankAddress;
                var correspondentWarehouseBankAddress1 = _correspondentWarehouseBankAddress1; correspondentWarehouseBankAddress1.Clean = value; _correspondentWarehouseBankAddress1 = correspondentWarehouseBankAddress1;
                var correspondentWarehouseBankBaileeExpirationDate = _correspondentWarehouseBankBaileeExpirationDate; correspondentWarehouseBankBaileeExpirationDate.Clean = value; _correspondentWarehouseBankBaileeExpirationDate = correspondentWarehouseBankBaileeExpirationDate;
                var correspondentWarehouseBankBaileeLetterReceivedIndicator = _correspondentWarehouseBankBaileeLetterReceivedIndicator; correspondentWarehouseBankBaileeLetterReceivedIndicator.Clean = value; _correspondentWarehouseBankBaileeLetterReceivedIndicator = correspondentWarehouseBankBaileeLetterReceivedIndicator;
                var correspondentWarehouseBankBaileeLetterReqIndicator = _correspondentWarehouseBankBaileeLetterReqIndicator; correspondentWarehouseBankBaileeLetterReqIndicator.Clean = value; _correspondentWarehouseBankBaileeLetterReqIndicator = correspondentWarehouseBankBaileeLetterReqIndicator;
                var correspondentWarehouseBankCity = _correspondentWarehouseBankCity; correspondentWarehouseBankCity.Clean = value; _correspondentWarehouseBankCity = correspondentWarehouseBankCity;
                var correspondentWarehouseBankContactEmail = _correspondentWarehouseBankContactEmail; correspondentWarehouseBankContactEmail.Clean = value; _correspondentWarehouseBankContactEmail = correspondentWarehouseBankContactEmail;
                var correspondentWarehouseBankContactFax = _correspondentWarehouseBankContactFax; correspondentWarehouseBankContactFax.Clean = value; _correspondentWarehouseBankContactFax = correspondentWarehouseBankContactFax;
                var correspondentWarehouseBankContactName = _correspondentWarehouseBankContactName; correspondentWarehouseBankContactName.Clean = value; _correspondentWarehouseBankContactName = correspondentWarehouseBankContactName;
                var correspondentWarehouseBankContactPhone = _correspondentWarehouseBankContactPhone; correspondentWarehouseBankContactPhone.Clean = value; _correspondentWarehouseBankContactPhone = correspondentWarehouseBankContactPhone;
                var correspondentWarehouseBankDescription = _correspondentWarehouseBankDescription; correspondentWarehouseBankDescription.Clean = value; _correspondentWarehouseBankDescription = correspondentWarehouseBankDescription;
                var correspondentWarehouseBankFurtherCreditAcctName = _correspondentWarehouseBankFurtherCreditAcctName; correspondentWarehouseBankFurtherCreditAcctName.Clean = value; _correspondentWarehouseBankFurtherCreditAcctName = correspondentWarehouseBankFurtherCreditAcctName;
                var correspondentWarehouseBankFurtherCreditAcctNum = _correspondentWarehouseBankFurtherCreditAcctNum; correspondentWarehouseBankFurtherCreditAcctNum.Clean = value; _correspondentWarehouseBankFurtherCreditAcctNum = correspondentWarehouseBankFurtherCreditAcctNum;
                var correspondentWarehouseBankId = _correspondentWarehouseBankId; correspondentWarehouseBankId.Clean = value; _correspondentWarehouseBankId = correspondentWarehouseBankId;
                var correspondentWarehouseBankName = _correspondentWarehouseBankName; correspondentWarehouseBankName.Clean = value; _correspondentWarehouseBankName = correspondentWarehouseBankName;
                var correspondentWarehouseBankNotes = _correspondentWarehouseBankNotes; correspondentWarehouseBankNotes.Clean = value; _correspondentWarehouseBankNotes = correspondentWarehouseBankNotes;
                var correspondentWarehouseBankSelfFunderIndicator = _correspondentWarehouseBankSelfFunderIndicator; correspondentWarehouseBankSelfFunderIndicator.Clean = value; _correspondentWarehouseBankSelfFunderIndicator = correspondentWarehouseBankSelfFunderIndicator;
                var correspondentWarehouseBankState = _correspondentWarehouseBankState; correspondentWarehouseBankState.Clean = value; _correspondentWarehouseBankState = correspondentWarehouseBankState;
                var correspondentWarehouseBankTriPartyContractIndicator = _correspondentWarehouseBankTriPartyContractIndicator; correspondentWarehouseBankTriPartyContractIndicator.Clean = value; _correspondentWarehouseBankTriPartyContractIndicator = correspondentWarehouseBankTriPartyContractIndicator;
                var correspondentWarehouseBankUseDefaultContactIndicator = _correspondentWarehouseBankUseDefaultContactIndicator; correspondentWarehouseBankUseDefaultContactIndicator.Clean = value; _correspondentWarehouseBankUseDefaultContactIndicator = correspondentWarehouseBankUseDefaultContactIndicator;
                var correspondentWarehouseBankWireConfirmationNumber = _correspondentWarehouseBankWireConfirmationNumber; correspondentWarehouseBankWireConfirmationNumber.Clean = value; _correspondentWarehouseBankWireConfirmationNumber = correspondentWarehouseBankWireConfirmationNumber;
                var correspondentWarehouseBankWireInstructionsReceivedIndicator = _correspondentWarehouseBankWireInstructionsReceivedIndicator; correspondentWarehouseBankWireInstructionsReceivedIndicator.Clean = value; _correspondentWarehouseBankWireInstructionsReceivedIndicator = correspondentWarehouseBankWireInstructionsReceivedIndicator;
                var correspondentWarehouseBankZip = _correspondentWarehouseBankZip; correspondentWarehouseBankZip.Clean = value; _correspondentWarehouseBankZip = correspondentWarehouseBankZip;
                var creditScoreToUse = _creditScoreToUse; creditScoreToUse.Clean = value; _creditScoreToUse = creditScoreToUse;
                var cumulatedDaystoExtend = _cumulatedDaystoExtend; cumulatedDaystoExtend.Clean = value; _cumulatedDaystoExtend = cumulatedDaystoExtend;
                var currentAdjustments = _currentAdjustments; currentAdjustments.Clean = value; _currentAdjustments = currentAdjustments;
                var currentComments = _currentComments; currentComments.Clean = value; _currentComments = currentComments;
                var currentLockDate = _currentLockDate; currentLockDate.Clean = value; _currentLockDate = currentLockDate;
                var currentLockExpires = _currentLockExpires; currentLockExpires.Clean = value; _currentLockExpires = currentLockExpires;
                var currentMarginRate = _currentMarginRate; currentMarginRate.Clean = value; _currentMarginRate = currentMarginRate;
                var currentMarginRateRequested = _currentMarginRateRequested; currentMarginRateRequested.Clean = value; _currentMarginRateRequested = currentMarginRateRequested;
                var currentMarginTotalAdjustment = _currentMarginTotalAdjustment; currentMarginTotalAdjustment.Clean = value; _currentMarginTotalAdjustment = currentMarginTotalAdjustment;
                var currentNumberOfDays = _currentNumberOfDays; currentNumberOfDays.Clean = value; _currentNumberOfDays = currentNumberOfDays;
                var currentPriceRate = _currentPriceRate; currentPriceRate.Clean = value; _currentPriceRate = currentPriceRate;
                var currentPriceRateRequested = _currentPriceRateRequested; currentPriceRateRequested.Clean = value; _currentPriceRateRequested = currentPriceRateRequested;
                var currentPriceTotalAdjustment = _currentPriceTotalAdjustment; currentPriceTotalAdjustment.Clean = value; _currentPriceTotalAdjustment = currentPriceTotalAdjustment;
                var currentRate = _currentRate; currentRate.Clean = value; _currentRate = currentRate;
                var currentRateRequested = _currentRateRequested; currentRateRequested.Clean = value; _currentRateRequested = currentRateRequested;
                var currentRateSetDate = _currentRateSetDate; currentRateSetDate.Clean = value; _currentRateSetDate = currentRateSetDate;
                var currentRateSheetID = _currentRateSheetID; currentRateSheetID.Clean = value; _currentRateSheetID = currentRateSheetID;
                var currentRateTotalAdjustment = _currentRateTotalAdjustment; currentRateTotalAdjustment.Clean = value; _currentRateTotalAdjustment = currentRateTotalAdjustment;
                var date = _date; date.Clean = value; _date = date;
                var dateFirstPaymentToInvestor = _dateFirstPaymentToInvestor; dateFirstPaymentToInvestor.Clean = value; _dateFirstPaymentToInvestor = dateFirstPaymentToInvestor;
                var dateLockedWithInvestor = _dateLockedWithInvestor; dateLockedWithInvestor.Clean = value; _dateLockedWithInvestor = dateLockedWithInvestor;
                var dateSold = _dateSold; dateSold.Clean = value; _dateSold = dateSold;
                var dateWarehoused = _dateWarehoused; dateWarehoused.Clean = value; _dateWarehoused = dateWarehoused;
                var daysToExtend = _daysToExtend; daysToExtend.Clean = value; _daysToExtend = daysToExtend;
                var deliveryType = _deliveryType; deliveryType.Clean = value; _deliveryType = deliveryType;
                var diffAmountReceived = _diffAmountReceived; diffAmountReceived.Clean = value; _diffAmountReceived = diffAmountReceived;
                var diffImpounds = _diffImpounds; diffImpounds.Clean = value; _diffImpounds = diffImpounds;
                var diffInterest = _diffInterest; diffInterest.Clean = value; _diffInterest = diffInterest;
                var diffPremium = _diffPremium; diffPremium.Clean = value; _diffPremium = diffPremium;
                var diffPrinciple = _diffPrinciple; diffPrinciple.Clean = value; _diffPrinciple = diffPrinciple;
                var diffRemainingBuydownFunds = _diffRemainingBuydownFunds; diffRemainingBuydownFunds.Clean = value; _diffRemainingBuydownFunds = diffRemainingBuydownFunds;
                var diffSellAmount = _diffSellAmount; diffSellAmount.Clean = value; _diffSellAmount = diffSellAmount;
                var diffSellPrice = _diffSellPrice; diffSellPrice.Clean = value; _diffSellPrice = diffSellPrice;
                var diffSellSideSRP = _diffSellSideSRP; diffSellSideSRP.Clean = value; _diffSellSideSRP = diffSellSideSRP;
                var diffSRP = _diffSRP; diffSRP.Clean = value; _diffSRP = diffSRP;
                var diffSRPAmount = _diffSRPAmount; diffSRPAmount.Clean = value; _diffSRPAmount = diffSRPAmount;
                var employmentBorrowerSelfEmployedIndicator1 = _employmentBorrowerSelfEmployedIndicator1; employmentBorrowerSelfEmployedIndicator1.Clean = value; _employmentBorrowerSelfEmployedIndicator1 = employmentBorrowerSelfEmployedIndicator1;
                var employmentBorrowerSelfEmployedIndicator10 = _employmentBorrowerSelfEmployedIndicator10; employmentBorrowerSelfEmployedIndicator10.Clean = value; _employmentBorrowerSelfEmployedIndicator10 = employmentBorrowerSelfEmployedIndicator10;
                var employmentBorrowerSelfEmployedIndicator11 = _employmentBorrowerSelfEmployedIndicator11; employmentBorrowerSelfEmployedIndicator11.Clean = value; _employmentBorrowerSelfEmployedIndicator11 = employmentBorrowerSelfEmployedIndicator11;
                var employmentBorrowerSelfEmployedIndicator12 = _employmentBorrowerSelfEmployedIndicator12; employmentBorrowerSelfEmployedIndicator12.Clean = value; _employmentBorrowerSelfEmployedIndicator12 = employmentBorrowerSelfEmployedIndicator12;
                var employmentBorrowerSelfEmployedIndicator2 = _employmentBorrowerSelfEmployedIndicator2; employmentBorrowerSelfEmployedIndicator2.Clean = value; _employmentBorrowerSelfEmployedIndicator2 = employmentBorrowerSelfEmployedIndicator2;
                var employmentBorrowerSelfEmployedIndicator3 = _employmentBorrowerSelfEmployedIndicator3; employmentBorrowerSelfEmployedIndicator3.Clean = value; _employmentBorrowerSelfEmployedIndicator3 = employmentBorrowerSelfEmployedIndicator3;
                var employmentBorrowerSelfEmployedIndicator4 = _employmentBorrowerSelfEmployedIndicator4; employmentBorrowerSelfEmployedIndicator4.Clean = value; _employmentBorrowerSelfEmployedIndicator4 = employmentBorrowerSelfEmployedIndicator4;
                var employmentBorrowerSelfEmployedIndicator5 = _employmentBorrowerSelfEmployedIndicator5; employmentBorrowerSelfEmployedIndicator5.Clean = value; _employmentBorrowerSelfEmployedIndicator5 = employmentBorrowerSelfEmployedIndicator5;
                var employmentBorrowerSelfEmployedIndicator6 = _employmentBorrowerSelfEmployedIndicator6; employmentBorrowerSelfEmployedIndicator6.Clean = value; _employmentBorrowerSelfEmployedIndicator6 = employmentBorrowerSelfEmployedIndicator6;
                var employmentBorrowerSelfEmployedIndicator7 = _employmentBorrowerSelfEmployedIndicator7; employmentBorrowerSelfEmployedIndicator7.Clean = value; _employmentBorrowerSelfEmployedIndicator7 = employmentBorrowerSelfEmployedIndicator7;
                var employmentBorrowerSelfEmployedIndicator8 = _employmentBorrowerSelfEmployedIndicator8; employmentBorrowerSelfEmployedIndicator8.Clean = value; _employmentBorrowerSelfEmployedIndicator8 = employmentBorrowerSelfEmployedIndicator8;
                var employmentBorrowerSelfEmployedIndicator9 = _employmentBorrowerSelfEmployedIndicator9; employmentBorrowerSelfEmployedIndicator9.Clean = value; _employmentBorrowerSelfEmployedIndicator9 = employmentBorrowerSelfEmployedIndicator9;
                var expectedAmountReceived = _expectedAmountReceived; expectedAmountReceived.Clean = value; _expectedAmountReceived = expectedAmountReceived;
                var expectedImpounds = _expectedImpounds; expectedImpounds.Clean = value; _expectedImpounds = expectedImpounds;
                var expectedInterest = _expectedInterest; expectedInterest.Clean = value; _expectedInterest = expectedInterest;
                var expectedPremium = _expectedPremium; expectedPremium.Clean = value; _expectedPremium = expectedPremium;
                var expectedPrinciple = _expectedPrinciple; expectedPrinciple.Clean = value; _expectedPrinciple = expectedPrinciple;
                var expectedRemainingBuydownFunds = _expectedRemainingBuydownFunds; expectedRemainingBuydownFunds.Clean = value; _expectedRemainingBuydownFunds = expectedRemainingBuydownFunds;
                var expectedSRP = _expectedSRP; expectedSRP.Clean = value; _expectedSRP = expectedSRP;
                var extensionRequestPending = _extensionRequestPending; extensionRequestPending.Clean = value; _extensionRequestPending = extensionRequestPending;
                var extensionSequenceNumber = _extensionSequenceNumber; extensionSequenceNumber.Clean = value; _extensionSequenceNumber = extensionSequenceNumber;
                var extraPayments = _extraPayments; extraPayments.Clean = value; _extraPayments = extraPayments;
                var fHAUpfrontMIPremiumPercent = _fHAUpfrontMIPremiumPercent; fHAUpfrontMIPremiumPercent.Clean = value; _fHAUpfrontMIPremiumPercent = fHAUpfrontMIPremiumPercent;
                var financedNumberOfUnits = _financedNumberOfUnits; financedNumberOfUnits.Clean = value; _financedNumberOfUnits = financedNumberOfUnits;
                var firstPaymenTo = _firstPaymenTo; firstPaymenTo.Clean = value; _firstPaymenTo = firstPaymenTo;
                var firstSubordinateAmount = _firstSubordinateAmount; firstSubordinateAmount.Clean = value; _firstSubordinateAmount = firstSubordinateAmount;
                var firstTimeHomebuyersIndicator = _firstTimeHomebuyersIndicator; firstTimeHomebuyersIndicator.Clean = value; _firstTimeHomebuyersIndicator = firstTimeHomebuyersIndicator;
                var fNMProductPlanIdentifier = _fNMProductPlanIdentifier; fNMProductPlanIdentifier.Clean = value; _fNMProductPlanIdentifier = fNMProductPlanIdentifier;
                var fundingAmount = _fundingAmount; fundingAmount.Clean = value; _fundingAmount = fundingAmount;
                var gainLossPercentage = _gainLossPercentage; gainLossPercentage.Clean = value; _gainLossPercentage = gainLossPercentage;
                var gainLossPrice = _gainLossPrice; gainLossPrice.Clean = value; _gainLossPrice = gainLossPrice;
                var gainLossTotalBuyPrice = _gainLossTotalBuyPrice; gainLossTotalBuyPrice.Clean = value; _gainLossTotalBuyPrice = gainLossTotalBuyPrice;
                var gPMRate = _gPMRate; gPMRate.Clean = value; _gPMRate = gPMRate;
                var gPMYears = _gPMYears; gPMYears.Clean = value; _gPMYears = gPMYears;
                var gSEPropertyType = _gSEPropertyType; gSEPropertyType.Clean = value; _gSEPropertyType = gSEPropertyType;
                var hedging = _hedging; hedging.Clean = value; _hedging = hedging;
                var hELOCActualBalance = _hELOCActualBalance; hELOCActualBalance.Clean = value; _hELOCActualBalance = hELOCActualBalance;
                var id = _id; id.Clean = value; _id = id;
                var impounds = _impounds; impounds.Clean = value; _impounds = impounds;
                var impoundType = _impoundType; impoundType.Clean = value; _impoundType = impoundType;
                var impoundWavied = _impoundWavied; impoundWavied.Clean = value; _impoundWavied = impoundWavied;
                var interest = _interest; interest.Clean = value; _interest = interest;
                var investorAddress = _investorAddress; investorAddress.Clean = value; _investorAddress = investorAddress;
                var investorCity = _investorCity; investorCity.Clean = value; _investorCity = investorCity;
                var investorCommitment = _investorCommitment; investorCommitment.Clean = value; _investorCommitment = investorCommitment;
                var investorContact = _investorContact; investorContact.Clean = value; _investorContact = investorContact;
                var investorDeliveryDate = _investorDeliveryDate; investorDeliveryDate.Clean = value; _investorDeliveryDate = investorDeliveryDate;
                var investorEmail = _investorEmail; investorEmail.Clean = value; _investorEmail = investorEmail;
                var investorLoanNumber = _investorLoanNumber; investorLoanNumber.Clean = value; _investorLoanNumber = investorLoanNumber;
                var investorLockType = _investorLockType; investorLockType.Clean = value; _investorLockType = investorLockType;
                var investorMERSNumber = _investorMERSNumber; investorMERSNumber.Clean = value; _investorMERSNumber = investorMERSNumber;
                var investorName = _investorName; investorName.Clean = value; _investorName = investorName;
                var investorPhone = _investorPhone; investorPhone.Clean = value; _investorPhone = investorPhone;
                var investorPostalCode = _investorPostalCode; investorPostalCode.Clean = value; _investorPostalCode = investorPostalCode;
                var investorProgramCode = _investorProgramCode; investorProgramCode.Clean = value; _investorProgramCode = investorProgramCode;
                var investorState = _investorState; investorState.Clean = value; _investorState = investorState;
                var investorTargetDeliveryDate = _investorTargetDeliveryDate; investorTargetDeliveryDate.Clean = value; _investorTargetDeliveryDate = investorTargetDeliveryDate;
                var investorTemplateName = _investorTemplateName; investorTemplateName.Clean = value; _investorTemplateName = investorTemplateName;
                var investorWebsite = _investorWebsite; investorWebsite.Clean = value; _investorWebsite = investorWebsite;
                var isCancelled = _isCancelled; isCancelled.Clean = value; _isCancelled = isCancelled;
                var isDeliveryType = _isDeliveryType; isDeliveryType.Clean = value; _isDeliveryType = isDeliveryType;
                var lenderPaidMortgageInsuranceIndicator = _lenderPaidMortgageInsuranceIndicator; lenderPaidMortgageInsuranceIndicator.Clean = value; _lenderPaidMortgageInsuranceIndicator = lenderPaidMortgageInsuranceIndicator;
                var lienPriorityType = _lienPriorityType; lienPriorityType.Clean = value; _lienPriorityType = lienPriorityType;
                var loanAmortizationTermMonths = _loanAmortizationTermMonths; loanAmortizationTermMonths.Clean = value; _loanAmortizationTermMonths = loanAmortizationTermMonths;
                var loanAmortizationType = _loanAmortizationType; loanAmortizationType.Clean = value; _loanAmortizationType = loanAmortizationType;
                var loanDocumentationType = _loanDocumentationType; loanDocumentationType.Clean = value; _loanDocumentationType = loanDocumentationType;
                var loanFor203K = _loanFor203K; loanFor203K.Clean = value; _loanFor203K = loanFor203K;
                var loanProgram = _loanProgram; loanProgram.Clean = value; _loanProgram = loanProgram;
                var loanProgramFile = _loanProgramFile; loanProgramFile.Clean = value; _loanProgramFile = loanProgramFile;
                var loanScheduledClosingDate = _loanScheduledClosingDate; loanScheduledClosingDate.Clean = value; _loanScheduledClosingDate = loanScheduledClosingDate;
                var lockField = _lockField; lockField.Clean = value; _lockField = lockField;
                var lockRequestAdjustments = _lockRequestAdjustments; lockRequestAdjustments.Clean = value; _lockRequestAdjustments = lockRequestAdjustments;
                var lockRequestBorrowers = _lockRequestBorrowers; lockRequestBorrowers.Clean = value; _lockRequestBorrowers = lockRequestBorrowers;
                var lockRequestLoanPurposeType = _lockRequestLoanPurposeType; lockRequestLoanPurposeType.Clean = value; _lockRequestLoanPurposeType = lockRequestLoanPurposeType;
                var lTV = _lTV; lTV.Clean = value; _lTV = lTV;
                var minFICO = _minFICO; minFICO.Clean = value; _minFICO = minFICO;
                var minFICO2 = _minFICO2; minFICO2.Clean = value; _minFICO2 = minFICO2;
                var mIPPaidInCash = _mIPPaidInCash; mIPPaidInCash.Clean = value; _mIPPaidInCash = mIPPaidInCash;
                var mortgageType = _mortgageType; mortgageType.Clean = value; _mortgageType = mortgageType;
                var netSellAmount = _netSellAmount; netSellAmount.Clean = value; _netSellAmount = netSellAmount;
                var netSellPrice = _netSellPrice; netSellPrice.Clean = value; _netSellPrice = netSellPrice;
                var nextPaymentDate = _nextPaymentDate; nextPaymentDate.Clean = value; _nextPaymentDate = nextPaymentDate;
                var noClosingCostOption = _noClosingCostOption; noClosingCostOption.Clean = value; _noClosingCostOption = noClosingCostOption;
                var oNRPLock = _oNRPLock; oNRPLock.Clean = value; _oNRPLock = oNRPLock;
                var otherAmortizationTypeDescription = _otherAmortizationTypeDescription; otherAmortizationTypeDescription.Clean = value; _otherAmortizationTypeDescription = otherAmortizationTypeDescription;
                var otherSubordinateAmount = _otherSubordinateAmount; otherSubordinateAmount.Clean = value; _otherSubordinateAmount = otherSubordinateAmount;
                var penaltyTerm = _penaltyTerm; penaltyTerm.Clean = value; _penaltyTerm = penaltyTerm;
                var perDiemInterestRoundingType = _perDiemInterestRoundingType; perDiemInterestRoundingType.Clean = value; _perDiemInterestRoundingType = perDiemInterestRoundingType;
                var planCode = _planCode; planCode.Clean = value; _planCode = planCode;
                var premium = _premium; premium.Clean = value; _premium = premium;
                var prepayPenalty = _prepayPenalty; prepayPenalty.Clean = value; _prepayPenalty = prepayPenalty;
                var priceAdjustment = _priceAdjustment; priceAdjustment.Clean = value; _priceAdjustment = priceAdjustment;
                var priceAdjustments = _priceAdjustments; priceAdjustments.Clean = value; _priceAdjustments = priceAdjustments;
                var pricingHistoryData = _pricingHistoryData; pricingHistoryData.Clean = value; _pricingHistoryData = pricingHistoryData;
                var pricingUpdated = _pricingUpdated; pricingUpdated.Clean = value; _pricingUpdated = pricingUpdated;
                var principle = _principle; principle.Clean = value; _principle = principle;
                var profitMarginAdjustedBuyPrice = _profitMarginAdjustedBuyPrice; profitMarginAdjustedBuyPrice.Clean = value; _profitMarginAdjustedBuyPrice = profitMarginAdjustedBuyPrice;
                var propertyAppraisedValueAmount = _propertyAppraisedValueAmount; propertyAppraisedValueAmount.Clean = value; _propertyAppraisedValueAmount = propertyAppraisedValueAmount;
                var propertyEstimatedValueAmount = _propertyEstimatedValueAmount; propertyEstimatedValueAmount.Clean = value; _propertyEstimatedValueAmount = propertyEstimatedValueAmount;
                var propertyUsageType = _propertyUsageType; propertyUsageType.Clean = value; _propertyUsageType = propertyUsageType;
                var purchaseAdviceNumberOfDays = _purchaseAdviceNumberOfDays; purchaseAdviceNumberOfDays.Clean = value; _purchaseAdviceNumberOfDays = purchaseAdviceNumberOfDays;
                var purchaseAdvicePayouts = _purchaseAdvicePayouts; purchaseAdvicePayouts.Clean = value; _purchaseAdvicePayouts = purchaseAdvicePayouts;
                var purchasePriceAmount = _purchasePriceAmount; purchasePriceAmount.Clean = value; _purchasePriceAmount = purchasePriceAmount;
                var rateRequestStatus = _rateRequestStatus; rateRequestStatus.Clean = value; _rateRequestStatus = rateRequestStatus;
                var rateStatus = _rateStatus; rateStatus.Clean = value; _rateStatus = rateStatus;
                var reasonforBranchApproval = _reasonforBranchApproval; reasonforBranchApproval.Clean = value; _reasonforBranchApproval = reasonforBranchApproval;
                var reasonforCorporateApproval = _reasonforCorporateApproval; reasonforCorporateApproval.Clean = value; _reasonforCorporateApproval = reasonforCorporateApproval;
                var reconciledDiff = _reconciledDiff; reconciledDiff.Clean = value; _reconciledDiff = reconciledDiff;
                var reLockRequestPending = _reLockRequestPending; reLockRequestPending.Clean = value; _reLockRequestPending = reLockRequestPending;
                var remainingBuydownFunds = _remainingBuydownFunds; remainingBuydownFunds.Clean = value; _remainingBuydownFunds = remainingBuydownFunds;
                var requestComments = _requestComments; requestComments.Clean = value; _requestComments = requestComments;
                var requestCurrentRateSetDate = _requestCurrentRateSetDate; requestCurrentRateSetDate.Clean = value; _requestCurrentRateSetDate = requestCurrentRateSetDate;
                var requestDaystoExtend = _requestDaystoExtend; requestDaystoExtend.Clean = value; _requestDaystoExtend = requestDaystoExtend;
                var requestExtendedLockExpires = _requestExtendedLockExpires; requestExtendedLockExpires.Clean = value; _requestExtendedLockExpires = requestExtendedLockExpires;
                var requestFullfilledDateTime = _requestFullfilledDateTime; requestFullfilledDateTime.Clean = value; _requestFullfilledDateTime = requestFullfilledDateTime;
                var requestImpoundType = _requestImpoundType; requestImpoundType.Clean = value; _requestImpoundType = requestImpoundType;
                var requestImpoundWavied = _requestImpoundWavied; requestImpoundWavied.Clean = value; _requestImpoundWavied = requestImpoundWavied;
                var requestLockCancellationComment = _requestLockCancellationComment; requestLockCancellationComment.Clean = value; _requestLockCancellationComment = requestLockCancellationComment;
                var requestLockCancellationDate = _requestLockCancellationDate; requestLockCancellationDate.Clean = value; _requestLockCancellationDate = requestLockCancellationDate;
                var requestLockDate = _requestLockDate; requestLockDate.Clean = value; _requestLockDate = requestLockDate;
                var requestLockExpires = _requestLockExpires; requestLockExpires.Clean = value; _requestLockExpires = requestLockExpires;
                var requestLockExtendComment = _requestLockExtendComment; requestLockExtendComment.Clean = value; _requestLockExtendComment = requestLockExtendComment;
                var requestLockExtendPriceAdjustment = _requestLockExtendPriceAdjustment; requestLockExtendPriceAdjustment.Clean = value; _requestLockExtendPriceAdjustment = requestLockExtendPriceAdjustment;
                var requestLockType = _requestLockType; requestLockType.Clean = value; _requestLockType = requestLockType;
                var requestMarginRate = _requestMarginRate; requestMarginRate.Clean = value; _requestMarginRate = requestMarginRate;
                var requestMarginRateRequested = _requestMarginRateRequested; requestMarginRateRequested.Clean = value; _requestMarginRateRequested = requestMarginRateRequested;
                var requestMarginSRPPaidOut = _requestMarginSRPPaidOut; requestMarginSRPPaidOut.Clean = value; _requestMarginSRPPaidOut = requestMarginSRPPaidOut;
                var requestMarginTotalAdjustment = _requestMarginTotalAdjustment; requestMarginTotalAdjustment.Clean = value; _requestMarginTotalAdjustment = requestMarginTotalAdjustment;
                var requestNumberOfDays = _requestNumberOfDays; requestNumberOfDays.Clean = value; _requestNumberOfDays = requestNumberOfDays;
                var requestOnrpEligible = _requestOnrpEligible; requestOnrpEligible.Clean = value; _requestOnrpEligible = requestOnrpEligible;
                var requestOnrpLockDate = _requestOnrpLockDate; requestOnrpLockDate.Clean = value; _requestOnrpLockDate = requestOnrpLockDate;
                var requestOnrpLockTime = _requestOnrpLockTime; requestOnrpLockTime.Clean = value; _requestOnrpLockTime = requestOnrpLockTime;
                var requestOriginalLockExpires = _requestOriginalLockExpires; requestOriginalLockExpires.Clean = value; _requestOriginalLockExpires = requestOriginalLockExpires;
                var requestPenaltyTerm = _requestPenaltyTerm; requestPenaltyTerm.Clean = value; _requestPenaltyTerm = requestPenaltyTerm;
                var requestPending = _requestPending; requestPending.Clean = value; _requestPending = requestPending;
                var requestPrepayPenalty = _requestPrepayPenalty; requestPrepayPenalty.Clean = value; _requestPrepayPenalty = requestPrepayPenalty;
                var requestPriceRate = _requestPriceRate; requestPriceRate.Clean = value; _requestPriceRate = requestPriceRate;
                var requestPriceRateRequested = _requestPriceRateRequested; requestPriceRateRequested.Clean = value; _requestPriceRateRequested = requestPriceRateRequested;
                var requestPriceTotalAdjustment = _requestPriceTotalAdjustment; requestPriceTotalAdjustment.Clean = value; _requestPriceTotalAdjustment = requestPriceTotalAdjustment;
                var requestRate = _requestRate; requestRate.Clean = value; _requestRate = requestRate;
                var requestRateRequested = _requestRateRequested; requestRateRequested.Clean = value; _requestRateRequested = requestRateRequested;
                var requestRateSheetID = _requestRateSheetID; requestRateSheetID.Clean = value; _requestRateSheetID = requestRateSheetID;
                var requestRateTotalAdjustment = _requestRateTotalAdjustment; requestRateTotalAdjustment.Clean = value; _requestRateTotalAdjustment = requestRateTotalAdjustment;
                var requestStartingAdjPoint = _requestStartingAdjPoint; requestStartingAdjPoint.Clean = value; _requestStartingAdjPoint = requestStartingAdjPoint;
                var requestStartingAdjRate = _requestStartingAdjRate; requestStartingAdjRate.Clean = value; _requestStartingAdjRate = requestStartingAdjRate;
                var requestType = _requestType; requestType.Clean = value; _requestType = requestType;
                var requestUnDiscountedRate = _requestUnDiscountedRate; requestUnDiscountedRate.Clean = value; _requestUnDiscountedRate = requestUnDiscountedRate;
                var roundToNearest50 = _roundToNearest50; roundToNearest50.Clean = value; _roundToNearest50 = roundToNearest50;
                var secondSubordinateAmount = _secondSubordinateAmount; secondSubordinateAmount.Clean = value; _secondSubordinateAmount = secondSubordinateAmount;
                var sellerPaidMIPremium = _sellerPaidMIPremium; sellerPaidMIPremium.Clean = value; _sellerPaidMIPremium = sellerPaidMIPremium;
                var sellSideAdjustments = _sellSideAdjustments; sellSideAdjustments.Clean = value; _sellSideAdjustments = sellSideAdjustments;
                var sellSideComments = _sellSideComments; sellSideComments.Clean = value; _sellSideComments = sellSideComments;
                var sellSideCommitmentContractNumber = _sellSideCommitmentContractNumber; sellSideCommitmentContractNumber.Clean = value; _sellSideCommitmentContractNumber = sellSideCommitmentContractNumber;
                var sellSideCommitmentDate = _sellSideCommitmentDate; sellSideCommitmentDate.Clean = value; _sellSideCommitmentDate = sellSideCommitmentDate;
                var sellSideCurrentRateSetDate = _sellSideCurrentRateSetDate; sellSideCurrentRateSetDate.Clean = value; _sellSideCurrentRateSetDate = sellSideCurrentRateSetDate;
                var sellSideDaystoExtend = _sellSideDaystoExtend; sellSideDaystoExtend.Clean = value; _sellSideDaystoExtend = sellSideDaystoExtend;
                var sellSideDiscountYSP = _sellSideDiscountYSP; sellSideDiscountYSP.Clean = value; _sellSideDiscountYSP = sellSideDiscountYSP;
                var sellSideExtendedLockExpires = _sellSideExtendedLockExpires; sellSideExtendedLockExpires.Clean = value; _sellSideExtendedLockExpires = sellSideExtendedLockExpires;
                var sellSideGuaranteeFee = _sellSideGuaranteeFee; sellSideGuaranteeFee.Clean = value; _sellSideGuaranteeFee = sellSideGuaranteeFee;
                var sellSideGuarantyBaseFee = _sellSideGuarantyBaseFee; sellSideGuarantyBaseFee.Clean = value; _sellSideGuarantyBaseFee = sellSideGuarantyBaseFee;
                var sellSideInvestorStatus = _sellSideInvestorStatus; sellSideInvestorStatus.Clean = value; _sellSideInvestorStatus = sellSideInvestorStatus;
                var sellSideInvestorStatusDate = _sellSideInvestorStatusDate; sellSideInvestorStatusDate.Clean = value; _sellSideInvestorStatusDate = sellSideInvestorStatusDate;
                var sellSideInvestorTradeNumber = _sellSideInvestorTradeNumber; sellSideInvestorTradeNumber.Clean = value; _sellSideInvestorTradeNumber = sellSideInvestorTradeNumber;
                var sellSideLoanProgram = _sellSideLoanProgram; sellSideLoanProgram.Clean = value; _sellSideLoanProgram = sellSideLoanProgram;
                var sellSideLockDate = _sellSideLockDate; sellSideLockDate.Clean = value; _sellSideLockDate = sellSideLockDate;
                var sellSideLockExpires = _sellSideLockExpires; sellSideLockExpires.Clean = value; _sellSideLockExpires = sellSideLockExpires;
                var sellSideLockExtendPriceAdjustment = _sellSideLockExtendPriceAdjustment; sellSideLockExtendPriceAdjustment.Clean = value; _sellSideLockExtendPriceAdjustment = sellSideLockExtendPriceAdjustment;
                var sellSideMarginNetSellRate = _sellSideMarginNetSellRate; sellSideMarginNetSellRate.Clean = value; _sellSideMarginNetSellRate = sellSideMarginNetSellRate;
                var sellSideMarginRate = _sellSideMarginRate; sellSideMarginRate.Clean = value; _sellSideMarginRate = sellSideMarginRate;
                var sellSideMarginTotalAdjustment = _sellSideMarginTotalAdjustment; sellSideMarginTotalAdjustment.Clean = value; _sellSideMarginTotalAdjustment = sellSideMarginTotalAdjustment;
                var sellSideMasterContractNumber = _sellSideMasterContractNumber; sellSideMasterContractNumber.Clean = value; _sellSideMasterContractNumber = sellSideMasterContractNumber;
                var sellSideMSRValue = _sellSideMSRValue; sellSideMSRValue.Clean = value; _sellSideMSRValue = sellSideMSRValue;
                var sellSideNetSellPrice = _sellSideNetSellPrice; sellSideNetSellPrice.Clean = value; _sellSideNetSellPrice = sellSideNetSellPrice;
                var sellSideNetSellRate = _sellSideNetSellRate; sellSideNetSellRate.Clean = value; _sellSideNetSellRate = sellSideNetSellRate;
                var sellSideNumberOfDays = _sellSideNumberOfDays; sellSideNumberOfDays.Clean = value; _sellSideNumberOfDays = sellSideNumberOfDays;
                var sellSideOriginalLockExpires = _sellSideOriginalLockExpires; sellSideOriginalLockExpires.Clean = value; _sellSideOriginalLockExpires = sellSideOriginalLockExpires;
                var sellSidePoolID = _sellSidePoolID; sellSidePoolID.Clean = value; _sellSidePoolID = sellSidePoolID;
                var sellSidePoolNumber = _sellSidePoolNumber; sellSidePoolNumber.Clean = value; _sellSidePoolNumber = sellSidePoolNumber;
                var sellSidePriceRate = _sellSidePriceRate; sellSidePriceRate.Clean = value; _sellSidePriceRate = sellSidePriceRate;
                var sellSidePriceTotalAdjustment = _sellSidePriceTotalAdjustment; sellSidePriceTotalAdjustment.Clean = value; _sellSidePriceTotalAdjustment = sellSidePriceTotalAdjustment;
                var sellSideProductName = _sellSideProductName; sellSideProductName.Clean = value; _sellSideProductName = sellSideProductName;
                var sellSideRate = _sellSideRate; sellSideRate.Clean = value; _sellSideRate = sellSideRate;
                var sellSideRateSheetID = _sellSideRateSheetID; sellSideRateSheetID.Clean = value; _sellSideRateSheetID = sellSideRateSheetID;
                var sellSideRateTotalAdjustment = _sellSideRateTotalAdjustment; sellSideRateTotalAdjustment.Clean = value; _sellSideRateTotalAdjustment = sellSideRateTotalAdjustment;
                var sellSideRequestedBy = _sellSideRequestedBy; sellSideRequestedBy.Clean = value; _sellSideRequestedBy = sellSideRequestedBy;
                var sellSideServicer = _sellSideServicer; sellSideServicer.Clean = value; _sellSideServicer = sellSideServicer;
                var sellSideServicingFee = _sellSideServicingFee; sellSideServicingFee.Clean = value; _sellSideServicingFee = sellSideServicingFee;
                var sellSideServicingType = _sellSideServicingType; sellSideServicingType.Clean = value; _sellSideServicingType = sellSideServicingType;
                var sellSideSRP = _sellSideSRP; sellSideSRP.Clean = value; _sellSideSRP = sellSideSRP;
                var sellSideSRPPaidOut = _sellSideSRPPaidOut; sellSideSRPPaidOut.Clean = value; _sellSideSRPPaidOut = sellSideSRPPaidOut;
                var sellSideTradeGuid = _sellSideTradeGuid; sellSideTradeGuid.Clean = value; _sellSideTradeGuid = sellSideTradeGuid;
                var sellSideTradeMgmtPrevConfirmedLockGuid = _sellSideTradeMgmtPrevConfirmedLockGuid; sellSideTradeMgmtPrevConfirmedLockGuid.Clean = value; _sellSideTradeMgmtPrevConfirmedLockGuid = sellSideTradeMgmtPrevConfirmedLockGuid;
                var sellSideTradeNumber = _sellSideTradeNumber; sellSideTradeNumber.Clean = value; _sellSideTradeNumber = sellSideTradeNumber;
                var servicingReleaseIndicator = _servicingReleaseIndicator; servicingReleaseIndicator.Clean = value; _servicingReleaseIndicator = servicingReleaseIndicator;
                var sRP = _sRP; sRP.Clean = value; _sRP = sRP;
                var sRPAmount = _sRPAmount; sRPAmount.Clean = value; _sRPAmount = sRPAmount;
                var sRPPaidOut = _sRPPaidOut; sRPPaidOut.Clean = value; _sRPPaidOut = sRPPaidOut;
                var subjectPropertyCity = _subjectPropertyCity; subjectPropertyCity.Clean = value; _subjectPropertyCity = subjectPropertyCity;
                var subjectPropertyCondotelIndicator = _subjectPropertyCondotelIndicator; subjectPropertyCondotelIndicator.Clean = value; _subjectPropertyCondotelIndicator = subjectPropertyCondotelIndicator;
                var subjectPropertyCounty = _subjectPropertyCounty; subjectPropertyCounty.Clean = value; _subjectPropertyCounty = subjectPropertyCounty;
                var subjectPropertyNonWarrantableProjectIndicator = _subjectPropertyNonWarrantableProjectIndicator; subjectPropertyNonWarrantableProjectIndicator.Clean = value; _subjectPropertyNonWarrantableProjectIndicator = subjectPropertyNonWarrantableProjectIndicator;
                var subjectPropertyPostalCode = _subjectPropertyPostalCode; subjectPropertyPostalCode.Clean = value; _subjectPropertyPostalCode = subjectPropertyPostalCode;
                var subjectPropertyState = _subjectPropertyState; subjectPropertyState.Clean = value; _subjectPropertyState = subjectPropertyState;
                var subjectPropertyStreetAddress = _subjectPropertyStreetAddress; subjectPropertyStreetAddress.Clean = value; _subjectPropertyStreetAddress = subjectPropertyStreetAddress;
                var timeLockedWithInvestor = _timeLockedWithInvestor; timeLockedWithInvestor.Clean = value; _timeLockedWithInvestor = timeLockedWithInvestor;
                var totalBuyPrice = _totalBuyPrice; totalBuyPrice.Clean = value; _totalBuyPrice = totalBuyPrice;
                var totalForLesserOfSumAsIs = _totalForLesserOfSumAsIs; totalForLesserOfSumAsIs.Clean = value; _totalForLesserOfSumAsIs = totalForLesserOfSumAsIs;
                var totalPrice = _totalPrice; totalPrice.Clean = value; _totalPrice = totalPrice;
                var totalSubordinateFinancing = _totalSubordinateFinancing; totalSubordinateFinancing.Clean = value; _totalSubordinateFinancing = totalSubordinateFinancing;
                var twelveMonthMortgageRentalHistoryIndicator = _twelveMonthMortgageRentalHistoryIndicator; twelveMonthMortgageRentalHistoryIndicator.Clean = value; _twelveMonthMortgageRentalHistoryIndicator = twelveMonthMortgageRentalHistoryIndicator;
                var type = _type; type.Clean = value; _type = type;
                var usePoint = _usePoint; usePoint.Clean = value; _usePoint = usePoint;
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