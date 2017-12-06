#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class RateLock : ExtensibleObject
    {
        private DirtyValue<decimal?> _actualSellAmount;
        public decimal? ActualSellAmount { get => _actualSellAmount; set => _actualSellAmount = value; }
        private DirtyValue<decimal?> _actualSellPrice;
        public decimal? ActualSellPrice { get => _actualSellPrice; set => _actualSellPrice = value; }
        private DirtyValue<decimal?> _actualSellSideSRP;
        public decimal? ActualSellSideSRP { get => _actualSellSideSRP; set => _actualSellSideSRP = value; }
        private DirtyValue<decimal?> _actualSRPAmount;
        public decimal? ActualSRPAmount { get => _actualSRPAmount; set => _actualSRPAmount = value; }
        private DirtyValue<decimal?> _amountDue;
        public decimal? AmountDue { get => _amountDue; set => _amountDue = value; }
        private DirtyValue<StringEnumValue<PartyType>> _amountDueTo;
        public StringEnumValue<PartyType> AmountDueTo { get => _amountDueTo; set => _amountDueTo = value; }
        private DirtyValue<decimal?> _amountPaid;
        public decimal? AmountPaid { get => _amountPaid; set => _amountPaid = value; }
        private DirtyValue<StringEnumValue<PartyType>> _amountPaidTo;
        public StringEnumValue<PartyType> AmountPaidTo { get => _amountPaidTo; set => _amountPaidTo = value; }
        private DirtyValue<decimal?> _amountReceived;
        public decimal? AmountReceived { get => _amountReceived; set => _amountReceived = value; }
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => _balloonLoanMaturityTermMonths = value; }
        private DirtyValue<decimal?> _baseLoanAmount;
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => _baseLoanAmount = value; }
        private DirtyValue<decimal?> _borrowerRequestedLoanAmount;
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => _borrowerRequestedLoanAmount = value; }
        private DirtyValue<DateTime?> _branchApprovalDate;
        public DateTime? BranchApprovalDate { get => _branchApprovalDate; set => _branchApprovalDate = value; }
        private DirtyValue<string> _branchApprovedby;
        public string BranchApprovedby { get => _branchApprovedby; set => _branchApprovedby = value; }
        private DirtyValue<decimal?> _branchPrice;
        public decimal? BranchPrice { get => _branchPrice; set => _branchPrice = value; }
        private DirtyList<PriceAdjustment> _buySideAdjustments;
        public IList<PriceAdjustment> BuySideAdjustments { get => _buySideAdjustments ?? (_buySideAdjustments = new DirtyList<PriceAdjustment>()); set => _buySideAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyValue<string> _buySideComments;
        public string BuySideComments { get => _buySideComments; set => _buySideComments = value; }
        private DirtyValue<DateTime?> _buySideCommitmentDate;
        public DateTime? BuySideCommitmentDate { get => _buySideCommitmentDate; set => _buySideCommitmentDate = value; }
        private DirtyValue<string> _buySideCommitmentNumber;
        public string BuySideCommitmentNumber { get => _buySideCommitmentNumber; set => _buySideCommitmentNumber = value; }
        private DirtyValue<string> _buySideCommitmentType;
        public string BuySideCommitmentType { get => _buySideCommitmentType; set => _buySideCommitmentType = value; }
        private DirtyValue<DateTime?> _buySideCurrentRateSetDate;
        public DateTime? BuySideCurrentRateSetDate { get => _buySideCurrentRateSetDate; set => _buySideCurrentRateSetDate = value; }
        private DirtyValue<int?> _buySideDaystoExtend;
        public int? BuySideDaystoExtend { get => _buySideDaystoExtend; set => _buySideDaystoExtend = value; }
        private DirtyValue<DateTime?> _buySideDeliveryExpirationDate;
        public DateTime? BuySideDeliveryExpirationDate { get => _buySideDeliveryExpirationDate; set => _buySideDeliveryExpirationDate = value; }
        private DirtyValue<string> _buySideDeliveryType;
        public string BuySideDeliveryType { get => _buySideDeliveryType; set => _buySideDeliveryType = value; }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => _buySideExpirationDate = value; }
        private DirtyValue<DateTime?> _buySideExtendedLockExpires;
        public DateTime? BuySideExtendedLockExpires { get => _buySideExtendedLockExpires; set => _buySideExtendedLockExpires = value; }
        private DirtyValue<DateTime?> _buySideLockDate;
        public DateTime? BuySideLockDate { get => _buySideLockDate; set => _buySideLockDate = value; }
        private DirtyValue<DateTime?> _buySideLockExpires;
        public DateTime? BuySideLockExpires { get => _buySideLockExpires; set => _buySideLockExpires = value; }
        private DirtyValue<decimal?> _buySideLockExtendPriceAdjustment;
        public decimal? BuySideLockExtendPriceAdjustment { get => _buySideLockExtendPriceAdjustment; set => _buySideLockExtendPriceAdjustment = value; }
        private DirtyValue<decimal?> _buySideMarginNetBuyRate;
        public decimal? BuySideMarginNetBuyRate { get => _buySideMarginNetBuyRate; set => _buySideMarginNetBuyRate = value; }
        private DirtyValue<decimal?> _buySideMarginRate;
        public decimal? BuySideMarginRate { get => _buySideMarginRate; set => _buySideMarginRate = value; }
        private DirtyValue<decimal?> _buySideMarginTotalAdjustment;
        public decimal? BuySideMarginTotalAdjustment { get => _buySideMarginTotalAdjustment; set => _buySideMarginTotalAdjustment = value; }
        private DirtyValue<string> _buySideMasterCommitmentNumber;
        public string BuySideMasterCommitmentNumber { get => _buySideMasterCommitmentNumber; set => _buySideMasterCommitmentNumber = value; }
        private DirtyValue<int?> _buySideNumberOfDays;
        public int? BuySideNumberOfDays { get => _buySideNumberOfDays; set => _buySideNumberOfDays = value; }
        private DirtyValue<bool?> _buySideOnrpEligible;
        public bool? BuySideOnrpEligible { get => _buySideOnrpEligible; set => _buySideOnrpEligible = value; }
        private DirtyValue<DateTime?> _buySideOnrpLockDate;
        public DateTime? BuySideOnrpLockDate { get => _buySideOnrpLockDate; set => _buySideOnrpLockDate = value; }
        private DirtyValue<string> _buySideOnrpLockTime;
        public string BuySideOnrpLockTime { get => _buySideOnrpLockTime; set => _buySideOnrpLockTime = value; }
        private DirtyValue<string> _buySideOrgID;
        public string BuySideOrgID { get => _buySideOrgID; set => _buySideOrgID = value; }
        private DirtyValue<DateTime?> _buySideOriginalLockExpires;
        public DateTime? BuySideOriginalLockExpires { get => _buySideOriginalLockExpires; set => _buySideOriginalLockExpires = value; }
        private DirtyValue<decimal?> _buySidePriceNetBuyPrice;
        public decimal? BuySidePriceNetBuyPrice { get => _buySidePriceNetBuyPrice; set => _buySidePriceNetBuyPrice = value; }
        private DirtyValue<decimal?> _buySidePriceRate;
        public decimal? BuySidePriceRate { get => _buySidePriceRate; set => _buySidePriceRate = value; }
        private DirtyValue<decimal?> _buySidePriceTotalAdjustment;
        public decimal? BuySidePriceTotalAdjustment { get => _buySidePriceTotalAdjustment; set => _buySidePriceTotalAdjustment = value; }
        private DirtyValue<decimal?> _buySideRate;
        public decimal? BuySideRate { get => _buySideRate; set => _buySideRate = value; }
        private DirtyValue<decimal?> _buySideRateNetBuyRate;
        public decimal? BuySideRateNetBuyRate { get => _buySideRateNetBuyRate; set => _buySideRateNetBuyRate = value; }
        private DirtyValue<string> _buySideRateSheetID;
        public string BuySideRateSheetID { get => _buySideRateSheetID; set => _buySideRateSheetID = value; }
        private DirtyValue<decimal?> _buySideRateTotalAdjustment;
        public decimal? BuySideRateTotalAdjustment { get => _buySideRateTotalAdjustment; set => _buySideRateTotalAdjustment = value; }
        private DirtyValue<string> _buySideRequestedBy;
        public string BuySideRequestedBy { get => _buySideRequestedBy; set => _buySideRequestedBy = value; }
        private DirtyValue<decimal?> _buySideSRPPaidOut;
        public decimal? BuySideSRPPaidOut { get => _buySideSRPPaidOut; set => _buySideSRPPaidOut = value; }
        private DirtyValue<decimal?> _buySideStartingAdjPoint;
        public decimal? BuySideStartingAdjPoint { get => _buySideStartingAdjPoint; set => _buySideStartingAdjPoint = value; }
        private DirtyValue<decimal?> _buySideStartingAdjPrice;
        public decimal? BuySideStartingAdjPrice { get => _buySideStartingAdjPrice; set => _buySideStartingAdjPrice = value; }
        private DirtyValue<decimal?> _buySideStartingAdjRate;
        public decimal? BuySideStartingAdjRate { get => _buySideStartingAdjRate; set => _buySideStartingAdjRate = value; }
        private DirtyValue<string> _buySideTPOID;
        public string BuySideTPOID { get => _buySideTPOID; set => _buySideTPOID = value; }
        private DirtyValue<string> _buySideTPOName;
        public string BuySideTPOName { get => _buySideTPOName; set => _buySideTPOName = value; }
        private DirtyValue<string> _buySideTradeGuid;
        public string BuySideTradeGuid { get => _buySideTradeGuid; set => _buySideTradeGuid = value; }
        private DirtyValue<string> _buySideTradeNumber;
        public string BuySideTradeNumber { get => _buySideTradeNumber; set => _buySideTradeNumber = value; }
        private DirtyValue<decimal?> _buySideUnDiscountedRate;
        public decimal? BuySideUnDiscountedRate { get => _buySideUnDiscountedRate; set => _buySideUnDiscountedRate = value; }
        private DirtyValue<string> _cancellationRequestPending;
        public string CancellationRequestPending { get => _cancellationRequestPending; set => _cancellationRequestPending = value; }
        private DirtyValue<decimal?> _combinedLTV;
        public decimal? CombinedLTV { get => _combinedLTV; set => _combinedLTV = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _commitment;
        public string Commitment { get => _commitment; set => _commitment = value; }
        private DirtyValue<string> _commitmentType;
        public string CommitmentType { get => _commitmentType; set => _commitmentType = value; }
        private DirtyValue<decimal?> _compGainLossPercentage;
        public decimal? CompGainLossPercentage { get => _compGainLossPercentage; set => _compGainLossPercentage = value; }
        private DirtyValue<decimal?> _compGainLossPrice;
        public decimal? CompGainLossPrice { get => _compGainLossPrice; set => _compGainLossPrice = value; }
        private DirtyValue<decimal?> _compGainLossTotalBuyPrice;
        public decimal? CompGainLossTotalBuyPrice { get => _compGainLossTotalBuyPrice; set => _compGainLossTotalBuyPrice = value; }
        private DirtyValue<decimal?> _compGainLossTotalCompPrice;
        public decimal? CompGainLossTotalCompPrice { get => _compGainLossTotalCompPrice; set => _compGainLossTotalCompPrice = value; }
        private DirtyValue<string> _compInvestorAddress;
        public string CompInvestorAddress { get => _compInvestorAddress; set => _compInvestorAddress = value; }
        private DirtyValue<string> _compInvestorCity;
        public string CompInvestorCity { get => _compInvestorCity; set => _compInvestorCity = value; }
        private DirtyValue<string> _compInvestorCommitment;
        public string CompInvestorCommitment { get => _compInvestorCommitment; set => _compInvestorCommitment = value; }
        private DirtyValue<string> _compInvestorContact;
        public string CompInvestorContact { get => _compInvestorContact; set => _compInvestorContact = value; }
        private DirtyValue<string> _compInvestorEmail;
        public string CompInvestorEmail { get => _compInvestorEmail; set => _compInvestorEmail = value; }
        private DirtyValue<string> _compInvestorLockType;
        public string CompInvestorLockType { get => _compInvestorLockType; set => _compInvestorLockType = value; }
        private DirtyValue<string> _compInvestorName;
        public string CompInvestorName { get => _compInvestorName; set => _compInvestorName = value; }
        private DirtyValue<string> _compInvestorPhone;
        public string CompInvestorPhone { get => _compInvestorPhone; set => _compInvestorPhone = value; }
        private DirtyValue<string> _compInvestorPostalCode;
        public string CompInvestorPostalCode { get => _compInvestorPostalCode; set => _compInvestorPostalCode = value; }
        private DirtyValue<string> _compInvestorProgramCode;
        public string CompInvestorProgramCode { get => _compInvestorProgramCode; set => _compInvestorProgramCode = value; }
        private DirtyValue<string> _compInvestorState;
        public string CompInvestorState { get => _compInvestorState; set => _compInvestorState = value; }
        private DirtyValue<string> _compInvestorTemplateName;
        public string CompInvestorTemplateName { get => _compInvestorTemplateName; set => _compInvestorTemplateName = value; }
        private DirtyValue<string> _compInvestorWebsite;
        public string CompInvestorWebsite { get => _compInvestorWebsite; set => _compInvestorWebsite = value; }
        private DirtyList<PriceAdjustment> _compSideAdjustments;
        public IList<PriceAdjustment> CompSideAdjustments { get => _compSideAdjustments ?? (_compSideAdjustments = new DirtyList<PriceAdjustment>()); set => _compSideAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyValue<string> _compSideComments;
        public string CompSideComments { get => _compSideComments; set => _compSideComments = value; }
        private DirtyValue<string> _compSideComparisonedBy;
        public string CompSideComparisonedBy { get => _compSideComparisonedBy; set => _compSideComparisonedBy = value; }
        private DirtyValue<DateTime?> _compSideCurrentRateSetDate;
        public DateTime? CompSideCurrentRateSetDate { get => _compSideCurrentRateSetDate; set => _compSideCurrentRateSetDate = value; }
        private DirtyValue<int?> _compSideDaystoExtend;
        public int? CompSideDaystoExtend { get => _compSideDaystoExtend; set => _compSideDaystoExtend = value; }
        private DirtyValue<decimal?> _compSideDiscountYSP;
        public decimal? CompSideDiscountYSP { get => _compSideDiscountYSP; set => _compSideDiscountYSP = value; }
        private DirtyValue<DateTime?> _compSideExtendedLockExpires;
        public DateTime? CompSideExtendedLockExpires { get => _compSideExtendedLockExpires; set => _compSideExtendedLockExpires = value; }
        private DirtyValue<string> _compSideInvestorStatus;
        public string CompSideInvestorStatus { get => _compSideInvestorStatus; set => _compSideInvestorStatus = value; }
        private DirtyValue<DateTime?> _compSideInvestorStatusDate;
        public DateTime? CompSideInvestorStatusDate { get => _compSideInvestorStatusDate; set => _compSideInvestorStatusDate = value; }
        private DirtyValue<string> _compSideInvestorTradeNumber;
        public string CompSideInvestorTradeNumber { get => _compSideInvestorTradeNumber; set => _compSideInvestorTradeNumber = value; }
        private DirtyValue<string> _compSideLoanProgram;
        public string CompSideLoanProgram { get => _compSideLoanProgram; set => _compSideLoanProgram = value; }
        private DirtyValue<DateTime?> _compSideLockDate;
        public DateTime? CompSideLockDate { get => _compSideLockDate; set => _compSideLockDate = value; }
        private DirtyValue<DateTime?> _compSideLockExpires;
        public DateTime? CompSideLockExpires { get => _compSideLockExpires; set => _compSideLockExpires = value; }
        private DirtyValue<decimal?> _compSideLockExtendPriceAdjustment;
        public decimal? CompSideLockExtendPriceAdjustment { get => _compSideLockExtendPriceAdjustment; set => _compSideLockExtendPriceAdjustment = value; }
        private DirtyValue<decimal?> _compSideMarginNetCompRate;
        public decimal? CompSideMarginNetCompRate { get => _compSideMarginNetCompRate; set => _compSideMarginNetCompRate = value; }
        private DirtyValue<decimal?> _compSideMarginRate;
        public decimal? CompSideMarginRate { get => _compSideMarginRate; set => _compSideMarginRate = value; }
        private DirtyValue<decimal?> _compSideMarginTotalAdjustment;
        public decimal? CompSideMarginTotalAdjustment { get => _compSideMarginTotalAdjustment; set => _compSideMarginTotalAdjustment = value; }
        private DirtyValue<string> _compSideMasterContractNumber;
        public string CompSideMasterContractNumber { get => _compSideMasterContractNumber; set => _compSideMasterContractNumber = value; }
        private DirtyValue<decimal?> _compSideNetCompPrice;
        public decimal? CompSideNetCompPrice { get => _compSideNetCompPrice; set => _compSideNetCompPrice = value; }
        private DirtyValue<decimal?> _compSideNetCompRate;
        public decimal? CompSideNetCompRate { get => _compSideNetCompRate; set => _compSideNetCompRate = value; }
        private DirtyValue<int?> _compSideNumberOfDays;
        public int? CompSideNumberOfDays { get => _compSideNumberOfDays; set => _compSideNumberOfDays = value; }
        private DirtyValue<DateTime?> _compSideOriginalLockExpires;
        public DateTime? CompSideOriginalLockExpires { get => _compSideOriginalLockExpires; set => _compSideOriginalLockExpires = value; }
        private DirtyValue<decimal?> _compSidePriceRate;
        public decimal? CompSidePriceRate { get => _compSidePriceRate; set => _compSidePriceRate = value; }
        private DirtyValue<decimal?> _compSidePriceTotalAdjustment;
        public decimal? CompSidePriceTotalAdjustment { get => _compSidePriceTotalAdjustment; set => _compSidePriceTotalAdjustment = value; }
        private DirtyValue<decimal?> _compSideRate;
        public decimal? CompSideRate { get => _compSideRate; set => _compSideRate = value; }
        private DirtyValue<string> _compSideRateSheetID;
        public string CompSideRateSheetID { get => _compSideRateSheetID; set => _compSideRateSheetID = value; }
        private DirtyValue<decimal?> _compSideRateTotalAdjustment;
        public decimal? CompSideRateTotalAdjustment { get => _compSideRateTotalAdjustment; set => _compSideRateTotalAdjustment = value; }
        private DirtyValue<string> _compSideRequestedBy;
        public string CompSideRequestedBy { get => _compSideRequestedBy; set => _compSideRequestedBy = value; }
        private DirtyValue<StringEnumValue<ServicingType>> _compSideServicingType;
        public StringEnumValue<ServicingType> CompSideServicingType { get => _compSideServicingType; set => _compSideServicingType = value; }
        private DirtyValue<decimal?> _compSideSRPPaidOut;
        public decimal? CompSideSRPPaidOut { get => _compSideSRPPaidOut; set => _compSideSRPPaidOut = value; }
        private DirtyValue<string> _compSideTradeGuid;
        public string CompSideTradeGuid { get => _compSideTradeGuid; set => _compSideTradeGuid = value; }
        private DirtyValue<string> _compSideTradeNumber;
        public string CompSideTradeNumber { get => _compSideTradeNumber; set => _compSideTradeNumber = value; }
        private DirtyValue<string> _confirmedBy;
        public string ConfirmedBy { get => _confirmedBy; set => _confirmedBy = value; }
        private DirtyValue<DateTime?> _confirmedDate;
        public DateTime? ConfirmedDate { get => _confirmedDate; set => _confirmedDate = value; }
        private DirtyValue<DateTime?> _corporateApprovalDate;
        public DateTime? CorporateApprovalDate { get => _corporateApprovalDate; set => _corporateApprovalDate = value; }
        private DirtyValue<string> _corporateApprovedby;
        public string CorporateApprovedby { get => _corporateApprovedby; set => _corporateApprovedby = value; }
        private DirtyValue<decimal?> _corporatePrice;
        public decimal? CorporatePrice { get => _corporatePrice; set => _corporatePrice = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAdditionalEscrow;
        public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get => _correspondentAdditionalEscrowAdditionalEscrow; set => _correspondentAdditionalEscrowAdditionalEscrow = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1007;
        public decimal? CorrespondentAdditionalEscrowAmount1007 { get => _correspondentAdditionalEscrowAmount1007; set => _correspondentAdditionalEscrowAmount1007 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1008;
        public decimal? CorrespondentAdditionalEscrowAmount1008 { get => _correspondentAdditionalEscrowAmount1008; set => _correspondentAdditionalEscrowAmount1008 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1009;
        public decimal? CorrespondentAdditionalEscrowAmount1009 { get => _correspondentAdditionalEscrowAmount1009; set => _correspondentAdditionalEscrowAmount1009 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowCityPropertyTax;
        public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get => _correspondentAdditionalEscrowCityPropertyTax; set => _correspondentAdditionalEscrowCityPropertyTax = value; }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1007;
        public string CorrespondentAdditionalEscrowDescription1007 { get => _correspondentAdditionalEscrowDescription1007; set => _correspondentAdditionalEscrowDescription1007 = value; }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1008;
        public string CorrespondentAdditionalEscrowDescription1008 { get => _correspondentAdditionalEscrowDescription1008; set => _correspondentAdditionalEscrowDescription1008 = value; }
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1009;
        public string CorrespondentAdditionalEscrowDescription1009 { get => _correspondentAdditionalEscrowDescription1009; set => _correspondentAdditionalEscrowDescription1009 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowFloodInsurance;
        public decimal? CorrespondentAdditionalEscrowFloodInsurance { get => _correspondentAdditionalEscrowFloodInsurance; set => _correspondentAdditionalEscrowFloodInsurance = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowHomeInsurance;
        public decimal? CorrespondentAdditionalEscrowHomeInsurance { get => _correspondentAdditionalEscrowHomeInsurance; set => _correspondentAdditionalEscrowHomeInsurance = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowMIMIP;
        public decimal? CorrespondentAdditionalEscrowMIMIP { get => _correspondentAdditionalEscrowMIMIP; set => _correspondentAdditionalEscrowMIMIP = value; }
        private DirtyValue<int?> _correspondentAdditionalEscrowNumOfPayments;
        public int? CorrespondentAdditionalEscrowNumOfPayments { get => _correspondentAdditionalEscrowNumOfPayments; set => _correspondentAdditionalEscrowNumOfPayments = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption1Amount;
        public decimal? CorrespondentAdditionalEscrowOption1Amount { get => _correspondentAdditionalEscrowOption1Amount; set => _correspondentAdditionalEscrowOption1Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption1Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption1Desc { get => _correspondentAdditionalEscrowOption1Desc; set => _correspondentAdditionalEscrowOption1Desc = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption2Amount;
        public decimal? CorrespondentAdditionalEscrowOption2Amount { get => _correspondentAdditionalEscrowOption2Amount; set => _correspondentAdditionalEscrowOption2Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption2Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption2Desc { get => _correspondentAdditionalEscrowOption2Desc; set => _correspondentAdditionalEscrowOption2Desc = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowPropertyTax;
        public decimal? CorrespondentAdditionalEscrowPropertyTax { get => _correspondentAdditionalEscrowPropertyTax; set => _correspondentAdditionalEscrowPropertyTax = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowSumOfPayments;
        public decimal? CorrespondentAdditionalEscrowSumOfPayments { get => _correspondentAdditionalEscrowSumOfPayments; set => _correspondentAdditionalEscrowSumOfPayments = value; }
        private DirtyValue<decimal?> _correspondentAdditionalEscrowUSDAAnnualFee;
        public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get => _correspondentAdditionalEscrowUSDAAnnualFee; set => _correspondentAdditionalEscrowUSDAAnnualFee = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount1;
        public decimal? CorrespondentAdditionalLineAmount1 { get => _correspondentAdditionalLineAmount1; set => _correspondentAdditionalLineAmount1 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount10;
        public decimal? CorrespondentAdditionalLineAmount10 { get => _correspondentAdditionalLineAmount10; set => _correspondentAdditionalLineAmount10 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount11;
        public decimal? CorrespondentAdditionalLineAmount11 { get => _correspondentAdditionalLineAmount11; set => _correspondentAdditionalLineAmount11 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount12;
        public decimal? CorrespondentAdditionalLineAmount12 { get => _correspondentAdditionalLineAmount12; set => _correspondentAdditionalLineAmount12 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount13;
        public decimal? CorrespondentAdditionalLineAmount13 { get => _correspondentAdditionalLineAmount13; set => _correspondentAdditionalLineAmount13 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount2;
        public decimal? CorrespondentAdditionalLineAmount2 { get => _correspondentAdditionalLineAmount2; set => _correspondentAdditionalLineAmount2 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount3;
        public decimal? CorrespondentAdditionalLineAmount3 { get => _correspondentAdditionalLineAmount3; set => _correspondentAdditionalLineAmount3 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount4;
        public decimal? CorrespondentAdditionalLineAmount4 { get => _correspondentAdditionalLineAmount4; set => _correspondentAdditionalLineAmount4 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount5;
        public decimal? CorrespondentAdditionalLineAmount5 { get => _correspondentAdditionalLineAmount5; set => _correspondentAdditionalLineAmount5 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount6;
        public decimal? CorrespondentAdditionalLineAmount6 { get => _correspondentAdditionalLineAmount6; set => _correspondentAdditionalLineAmount6 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount7;
        public decimal? CorrespondentAdditionalLineAmount7 { get => _correspondentAdditionalLineAmount7; set => _correspondentAdditionalLineAmount7 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount8;
        public decimal? CorrespondentAdditionalLineAmount8 { get => _correspondentAdditionalLineAmount8; set => _correspondentAdditionalLineAmount8 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount9;
        public decimal? CorrespondentAdditionalLineAmount9 { get => _correspondentAdditionalLineAmount9; set => _correspondentAdditionalLineAmount9 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription1;
        public string CorrespondentAdditionalLineDescription1 { get => _correspondentAdditionalLineDescription1; set => _correspondentAdditionalLineDescription1 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription10;
        public string CorrespondentAdditionalLineDescription10 { get => _correspondentAdditionalLineDescription10; set => _correspondentAdditionalLineDescription10 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription11;
        public string CorrespondentAdditionalLineDescription11 { get => _correspondentAdditionalLineDescription11; set => _correspondentAdditionalLineDescription11 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription12;
        public string CorrespondentAdditionalLineDescription12 { get => _correspondentAdditionalLineDescription12; set => _correspondentAdditionalLineDescription12 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription2;
        public string CorrespondentAdditionalLineDescription2 { get => _correspondentAdditionalLineDescription2; set => _correspondentAdditionalLineDescription2 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription3;
        public string CorrespondentAdditionalLineDescription3 { get => _correspondentAdditionalLineDescription3; set => _correspondentAdditionalLineDescription3 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription4;
        public string CorrespondentAdditionalLineDescription4 { get => _correspondentAdditionalLineDescription4; set => _correspondentAdditionalLineDescription4 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription5;
        public string CorrespondentAdditionalLineDescription5 { get => _correspondentAdditionalLineDescription5; set => _correspondentAdditionalLineDescription5 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription6;
        public string CorrespondentAdditionalLineDescription6 { get => _correspondentAdditionalLineDescription6; set => _correspondentAdditionalLineDescription6 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription7;
        public string CorrespondentAdditionalLineDescription7 { get => _correspondentAdditionalLineDescription7; set => _correspondentAdditionalLineDescription7 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription8;
        public string CorrespondentAdditionalLineDescription8 { get => _correspondentAdditionalLineDescription8; set => _correspondentAdditionalLineDescription8 = value; }
        private DirtyValue<string> _correspondentAdditionalLineDescription9;
        public string CorrespondentAdditionalLineDescription9 { get => _correspondentAdditionalLineDescription9; set => _correspondentAdditionalLineDescription9 = value; }
        private DirtyValue<decimal?> _correspondentAdditionalLineTotalAmount;
        public decimal? CorrespondentAdditionalLineTotalAmount { get => _correspondentAdditionalLineTotalAmount; set => _correspondentAdditionalLineTotalAmount = value; }
        private DirtyValue<decimal?> _correspondentAdjusterAmount1;
        public decimal? CorrespondentAdjusterAmount1 { get => _correspondentAdjusterAmount1; set => _correspondentAdjusterAmount1 = value; }
        private DirtyValue<decimal?> _correspondentAdjusterAmount2;
        public decimal? CorrespondentAdjusterAmount2 { get => _correspondentAdjusterAmount2; set => _correspondentAdjusterAmount2 = value; }
        private DirtyValue<decimal?> _correspondentAdjusterAmount3;
        public decimal? CorrespondentAdjusterAmount3 { get => _correspondentAdjusterAmount3; set => _correspondentAdjusterAmount3 = value; }
        private DirtyValue<string> _correspondentAdjusterDescription1;
        public string CorrespondentAdjusterDescription1 { get => _correspondentAdjusterDescription1; set => _correspondentAdjusterDescription1 = value; }
        private DirtyValue<string> _correspondentAdjusterDescription2;
        public string CorrespondentAdjusterDescription2 { get => _correspondentAdjusterDescription2; set => _correspondentAdjusterDescription2 = value; }
        private DirtyValue<string> _correspondentAdjusterDescription3;
        public string CorrespondentAdjusterDescription3 { get => _correspondentAdjusterDescription3; set => _correspondentAdjusterDescription3 = value; }
        private DirtyValue<string> _correspondentConfirmedBy;
        public string CorrespondentConfirmedBy { get => _correspondentConfirmedBy; set => _correspondentConfirmedBy = value; }
        private DirtyValue<DateTime?> _correspondentConfirmedDate;
        public DateTime? CorrespondentConfirmedDate { get => _correspondentConfirmedDate; set => _correspondentConfirmedDate = value; }
        private DirtyValue<decimal?> _correspondentCurrentImpounds;
        public decimal? CorrespondentCurrentImpounds { get => _correspondentCurrentImpounds; set => _correspondentCurrentImpounds = value; }
        private DirtyValue<decimal?> _correspondentCurrentPrincipal;
        public decimal? CorrespondentCurrentPrincipal { get => _correspondentCurrentPrincipal; set => _correspondentCurrentPrincipal = value; }
        private DirtyValue<DateTime?> _correspondentDate;
        public DateTime? CorrespondentDate { get => _correspondentDate; set => _correspondentDate = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1007;
        public decimal? CorrespondentEscrowDisbursementsAmount1007 { get => _correspondentEscrowDisbursementsAmount1007; set => _correspondentEscrowDisbursementsAmount1007 = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1008;
        public decimal? CorrespondentEscrowDisbursementsAmount1008 { get => _correspondentEscrowDisbursementsAmount1008; set => _correspondentEscrowDisbursementsAmount1008 = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1009;
        public decimal? CorrespondentEscrowDisbursementsAmount1009 { get => _correspondentEscrowDisbursementsAmount1009; set => _correspondentEscrowDisbursementsAmount1009 = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsCityPropertyTax;
        public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get => _correspondentEscrowDisbursementsCityPropertyTax; set => _correspondentEscrowDisbursementsCityPropertyTax = value; }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1007;
        public string CorrespondentEscrowDisbursementsDescription1007 { get => _correspondentEscrowDisbursementsDescription1007; set => _correspondentEscrowDisbursementsDescription1007 = value; }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1008;
        public string CorrespondentEscrowDisbursementsDescription1008 { get => _correspondentEscrowDisbursementsDescription1008; set => _correspondentEscrowDisbursementsDescription1008 = value; }
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1009;
        public string CorrespondentEscrowDisbursementsDescription1009 { get => _correspondentEscrowDisbursementsDescription1009; set => _correspondentEscrowDisbursementsDescription1009 = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEscrowsToBePaidBySeller;
        public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get => _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; set => _correspondentEscrowDisbursementsEscrowsToBePaidBySeller = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEsrowFundedByInvestor;
        public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get => _correspondentEscrowDisbursementsEsrowFundedByInvestor; set => _correspondentEscrowDisbursementsEsrowFundedByInvestor = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsFloodInsurance;
        public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get => _correspondentEscrowDisbursementsFloodInsurance; set => _correspondentEscrowDisbursementsFloodInsurance = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsHomeInsurance;
        public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get => _correspondentEscrowDisbursementsHomeInsurance; set => _correspondentEscrowDisbursementsHomeInsurance = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsMortgageInsurance;
        public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get => _correspondentEscrowDisbursementsMortgageInsurance; set => _correspondentEscrowDisbursementsMortgageInsurance = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption1Amount;
        public decimal? CorrespondentEscrowDisbursementsOption1Amount { get => _correspondentEscrowDisbursementsOption1Amount; set => _correspondentEscrowDisbursementsOption1Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption1Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption1Desc { get => _correspondentEscrowDisbursementsOption1Desc; set => _correspondentEscrowDisbursementsOption1Desc = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption2Amount;
        public decimal? CorrespondentEscrowDisbursementsOption2Amount { get => _correspondentEscrowDisbursementsOption2Amount; set => _correspondentEscrowDisbursementsOption2Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption2Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption2Desc { get => _correspondentEscrowDisbursementsOption2Desc; set => _correspondentEscrowDisbursementsOption2Desc = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsPropertyTax;
        public decimal? CorrespondentEscrowDisbursementsPropertyTax { get => _correspondentEscrowDisbursementsPropertyTax; set => _correspondentEscrowDisbursementsPropertyTax = value; }
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsUSDAAnnualFee;
        public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get => _correspondentEscrowDisbursementsUSDAAnnualFee; set => _correspondentEscrowDisbursementsUSDAAnnualFee = value; }
        private DirtyValue<decimal?> _correspondentFinalBuyAmount;
        public decimal? CorrespondentFinalBuyAmount { get => _correspondentFinalBuyAmount; set => _correspondentFinalBuyAmount = value; }
        private DirtyValue<decimal?> _correspondentFinalBuyPrice;
        public decimal? CorrespondentFinalBuyPrice { get => _correspondentFinalBuyPrice; set => _correspondentFinalBuyPrice = value; }
        private DirtyValue<decimal?> _correspondentFinalCDAggAdjAmount;
        public decimal? CorrespondentFinalCDAggAdjAmount { get => _correspondentFinalCDAggAdjAmount; set => _correspondentFinalCDAggAdjAmount = value; }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1007;
        public decimal? CorrespondentFinalCDAmount1007 { get => _correspondentFinalCDAmount1007; set => _correspondentFinalCDAmount1007 = value; }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1008;
        public decimal? CorrespondentFinalCDAmount1008 { get => _correspondentFinalCDAmount1008; set => _correspondentFinalCDAmount1008 = value; }
        private DirtyValue<decimal?> _correspondentFinalCDAmount1009;
        public decimal? CorrespondentFinalCDAmount1009 { get => _correspondentFinalCDAmount1009; set => _correspondentFinalCDAmount1009 = value; }
        private DirtyValue<decimal?> _correspondentFinalCDCityPropertyTax;
        public decimal? CorrespondentFinalCDCityPropertyTax { get => _correspondentFinalCDCityPropertyTax; set => _correspondentFinalCDCityPropertyTax = value; }
        private DirtyValue<string> _correspondentFinalCDDescription1007;
        public string CorrespondentFinalCDDescription1007 { get => _correspondentFinalCDDescription1007; set => _correspondentFinalCDDescription1007 = value; }
        private DirtyValue<string> _correspondentFinalCDDescription1008;
        public string CorrespondentFinalCDDescription1008 { get => _correspondentFinalCDDescription1008; set => _correspondentFinalCDDescription1008 = value; }
        private DirtyValue<string> _correspondentFinalCDDescription1009;
        public string CorrespondentFinalCDDescription1009 { get => _correspondentFinalCDDescription1009; set => _correspondentFinalCDDescription1009 = value; }
        private DirtyValue<decimal?> _correspondentFinalCDFloodInsurance;
        public decimal? CorrespondentFinalCDFloodInsurance { get => _correspondentFinalCDFloodInsurance; set => _correspondentFinalCDFloodInsurance = value; }
        private DirtyValue<decimal?> _correspondentFinalCDHomeInsurance;
        public decimal? CorrespondentFinalCDHomeInsurance { get => _correspondentFinalCDHomeInsurance; set => _correspondentFinalCDHomeInsurance = value; }
        private DirtyValue<decimal?> _correspondentFinalCDMortgageInsurance;
        public decimal? CorrespondentFinalCDMortgageInsurance { get => _correspondentFinalCDMortgageInsurance; set => _correspondentFinalCDMortgageInsurance = value; }
        private DirtyValue<decimal?> _correspondentFinalCDOption1Amount;
        public decimal? CorrespondentFinalCDOption1Amount { get => _correspondentFinalCDOption1Amount; set => _correspondentFinalCDOption1Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption1Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption1Desc { get => _correspondentFinalCDOption1Desc; set => _correspondentFinalCDOption1Desc = value; }
        private DirtyValue<decimal?> _correspondentFinalCDOption2Amount;
        public decimal? CorrespondentFinalCDOption2Amount { get => _correspondentFinalCDOption2Amount; set => _correspondentFinalCDOption2Amount = value; }
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption2Desc;
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption2Desc { get => _correspondentFinalCDOption2Desc; set => _correspondentFinalCDOption2Desc = value; }
        private DirtyValue<decimal?> _correspondentFinalCDPropertyTax;
        public decimal? CorrespondentFinalCDPropertyTax { get => _correspondentFinalCDPropertyTax; set => _correspondentFinalCDPropertyTax = value; }
        private DirtyValue<decimal?> _correspondentFinalCDReservesCollectedAtClosing;
        public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get => _correspondentFinalCDReservesCollectedAtClosing; set => _correspondentFinalCDReservesCollectedAtClosing = value; }
        private DirtyValue<decimal?> _correspondentFinalCDUSDAAnnualFee;
        public decimal? CorrespondentFinalCDUSDAAnnualFee { get => _correspondentFinalCDUSDAAnnualFee; set => _correspondentFinalCDUSDAAnnualFee = value; }
        private DirtyValue<DateTime?> _correspondentFirstPaymentDate;
        public DateTime? CorrespondentFirstPaymentDate { get => _correspondentFirstPaymentDate; set => _correspondentFirstPaymentDate = value; }
        private DirtyValue<decimal?> _correspondentImpounds;
        public decimal? CorrespondentImpounds { get => _correspondentImpounds; set => _correspondentImpounds = value; }
        private DirtyValue<decimal?> _correspondentInterest;
        public decimal? CorrespondentInterest { get => _correspondentInterest; set => _correspondentInterest = value; }
        private DirtyValue<int?> _correspondentInterestDays;
        public int? CorrespondentInterestDays { get => _correspondentInterestDays; set => _correspondentInterestDays = value; }
        private DirtyValue<decimal?> _correspondentLateFeeAmount;
        public decimal? CorrespondentLateFeeAmount { get => _correspondentLateFeeAmount; set => _correspondentLateFeeAmount = value; }
        private DirtyValue<decimal?> _correspondentLateFeePriceAdjustment;
        public decimal? CorrespondentLateFeePriceAdjustment { get => _correspondentLateFeePriceAdjustment; set => _correspondentLateFeePriceAdjustment = value; }
        private DirtyValue<DateTime?> _correspondentPaidToDate;
        public DateTime? CorrespondentPaidToDate { get => _correspondentPaidToDate; set => _correspondentPaidToDate = value; }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryAnticipatedPurchaseDate;
        public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get => _correspondentPaymentHistoryAnticipatedPurchaseDate; set => _correspondentPaymentHistoryAnticipatedPurchaseDate = value; }
        private DirtyValue<decimal?> _correspondentPaymentHistoryCalculatedPurchasedPrincipal;
        public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get => _correspondentPaymentHistoryCalculatedPurchasedPrincipal; set => _correspondentPaymentHistoryCalculatedPurchasedPrincipal = value; }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstBorrowerPaymentDueDate;
        public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get => _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; set => _correspondentPaymentHistoryFirstBorrowerPaymentDueDate = value; }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstInvestorPaymentDate;
        public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get => _correspondentPaymentHistoryFirstInvestorPaymentDate; set => _correspondentPaymentHistoryFirstInvestorPaymentDate = value; }
        private DirtyValue<DateTime?> _correspondentPaymentHistoryNoteDate;
        public DateTime? CorrespondentPaymentHistoryNoteDate { get => _correspondentPaymentHistoryNoteDate; set => _correspondentPaymentHistoryNoteDate = value; }
        private DirtyValue<decimal?> _correspondentPaymentHistoryPricipalReduction;
        public decimal? CorrespondentPaymentHistoryPricipalReduction { get => _correspondentPaymentHistoryPricipalReduction; set => _correspondentPaymentHistoryPricipalReduction = value; }
        private DirtyValue<decimal?> _correspondentPurchasedPrincipal;
        public decimal? CorrespondentPurchasedPrincipal { get => _correspondentPurchasedPrincipal; set => _correspondentPurchasedPrincipal = value; }
        private DirtyValue<string> _correspondentReconcilationComments;
        public string CorrespondentReconcilationComments { get => _correspondentReconcilationComments; set => _correspondentReconcilationComments = value; }
        private DirtyValue<decimal?> _correspondentRemainingBuydownAmount;
        public decimal? CorrespondentRemainingBuydownAmount { get => _correspondentRemainingBuydownAmount; set => _correspondentRemainingBuydownAmount = value; }
        private DirtyValue<decimal?> _correspondentSRPAmount;
        public decimal? CorrespondentSRPAmount { get => _correspondentSRPAmount; set => _correspondentSRPAmount = value; }
        private DirtyValue<decimal?> _correspondentTotalBuyAmount;
        public decimal? CorrespondentTotalBuyAmount { get => _correspondentTotalBuyAmount; set => _correspondentTotalBuyAmount = value; }
        private DirtyValue<decimal?> _correspondentTotalFees;
        public decimal? CorrespondentTotalFees { get => _correspondentTotalFees; set => _correspondentTotalFees = value; }
        private DirtyValue<string> _correspondentWarehouseBankABANum;
        public string CorrespondentWarehouseBankABANum { get => _correspondentWarehouseBankABANum; set => _correspondentWarehouseBankABANum = value; }
        private DirtyValue<string> _correspondentWarehouseBankAcctName;
        public string CorrespondentWarehouseBankAcctName { get => _correspondentWarehouseBankAcctName; set => _correspondentWarehouseBankAcctName = value; }
        private DirtyValue<string> _correspondentWarehouseBankAcctNum;
        public string CorrespondentWarehouseBankAcctNum { get => _correspondentWarehouseBankAcctNum; set => _correspondentWarehouseBankAcctNum = value; }
        private DirtyValue<string> _correspondentWarehouseBankAddress;
        public string CorrespondentWarehouseBankAddress { get => _correspondentWarehouseBankAddress; set => _correspondentWarehouseBankAddress = value; }
        private DirtyValue<string> _correspondentWarehouseBankAddress1;
        public string CorrespondentWarehouseBankAddress1 { get => _correspondentWarehouseBankAddress1; set => _correspondentWarehouseBankAddress1 = value; }
        private DirtyValue<DateTime?> _correspondentWarehouseBankBaileeExpirationDate;
        public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get => _correspondentWarehouseBankBaileeExpirationDate; set => _correspondentWarehouseBankBaileeExpirationDate = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReceivedIndicator;
        public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get => _correspondentWarehouseBankBaileeLetterReceivedIndicator; set => _correspondentWarehouseBankBaileeLetterReceivedIndicator = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReqIndicator;
        public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get => _correspondentWarehouseBankBaileeLetterReqIndicator; set => _correspondentWarehouseBankBaileeLetterReqIndicator = value; }
        private DirtyValue<string> _correspondentWarehouseBankCity;
        public string CorrespondentWarehouseBankCity { get => _correspondentWarehouseBankCity; set => _correspondentWarehouseBankCity = value; }
        private DirtyValue<string> _correspondentWarehouseBankContactEmail;
        public string CorrespondentWarehouseBankContactEmail { get => _correspondentWarehouseBankContactEmail; set => _correspondentWarehouseBankContactEmail = value; }
        private DirtyValue<string> _correspondentWarehouseBankContactFax;
        public string CorrespondentWarehouseBankContactFax { get => _correspondentWarehouseBankContactFax; set => _correspondentWarehouseBankContactFax = value; }
        private DirtyValue<string> _correspondentWarehouseBankContactName;
        public string CorrespondentWarehouseBankContactName { get => _correspondentWarehouseBankContactName; set => _correspondentWarehouseBankContactName = value; }
        private DirtyValue<string> _correspondentWarehouseBankContactPhone;
        public string CorrespondentWarehouseBankContactPhone { get => _correspondentWarehouseBankContactPhone; set => _correspondentWarehouseBankContactPhone = value; }
        private DirtyValue<string> _correspondentWarehouseBankDescription;
        public string CorrespondentWarehouseBankDescription { get => _correspondentWarehouseBankDescription; set => _correspondentWarehouseBankDescription = value; }
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctName;
        public string CorrespondentWarehouseBankFurtherCreditAcctName { get => _correspondentWarehouseBankFurtherCreditAcctName; set => _correspondentWarehouseBankFurtherCreditAcctName = value; }
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctNum;
        public string CorrespondentWarehouseBankFurtherCreditAcctNum { get => _correspondentWarehouseBankFurtherCreditAcctNum; set => _correspondentWarehouseBankFurtherCreditAcctNum = value; }
        private DirtyValue<int?> _correspondentWarehouseBankId;
        public int? CorrespondentWarehouseBankId { get => _correspondentWarehouseBankId; set => _correspondentWarehouseBankId = value; }
        private DirtyValue<string> _correspondentWarehouseBankName;
        public string CorrespondentWarehouseBankName { get => _correspondentWarehouseBankName; set => _correspondentWarehouseBankName = value; }
        private DirtyValue<string> _correspondentWarehouseBankNotes;
        public string CorrespondentWarehouseBankNotes { get => _correspondentWarehouseBankNotes; set => _correspondentWarehouseBankNotes = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankSelfFunderIndicator;
        public bool? CorrespondentWarehouseBankSelfFunderIndicator { get => _correspondentWarehouseBankSelfFunderIndicator; set => _correspondentWarehouseBankSelfFunderIndicator = value; }
        private DirtyValue<string> _correspondentWarehouseBankState;
        public string CorrespondentWarehouseBankState { get => _correspondentWarehouseBankState; set => _correspondentWarehouseBankState = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankTriPartyContractIndicator;
        public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get => _correspondentWarehouseBankTriPartyContractIndicator; set => _correspondentWarehouseBankTriPartyContractIndicator = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankUseDefaultContactIndicator;
        public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get => _correspondentWarehouseBankUseDefaultContactIndicator; set => _correspondentWarehouseBankUseDefaultContactIndicator = value; }
        private DirtyValue<string> _correspondentWarehouseBankWireConfirmationNumber;
        public string CorrespondentWarehouseBankWireConfirmationNumber { get => _correspondentWarehouseBankWireConfirmationNumber; set => _correspondentWarehouseBankWireConfirmationNumber = value; }
        private DirtyValue<bool?> _correspondentWarehouseBankWireInstructionsReceivedIndicator;
        public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get => _correspondentWarehouseBankWireInstructionsReceivedIndicator; set => _correspondentWarehouseBankWireInstructionsReceivedIndicator = value; }
        private DirtyValue<string> _correspondentWarehouseBankZip;
        public string CorrespondentWarehouseBankZip { get => _correspondentWarehouseBankZip; set => _correspondentWarehouseBankZip = value; }
        private DirtyValue<string> _creditScoreToUse;
        public string CreditScoreToUse { get => _creditScoreToUse; set => _creditScoreToUse = value; }
        private DirtyValue<int?> _cumulatedDaystoExtend;
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => _cumulatedDaystoExtend = value; }
        private DirtyList<PriceAdjustment> _currentAdjustments;
        public IList<PriceAdjustment> CurrentAdjustments { get => _currentAdjustments ?? (_currentAdjustments = new DirtyList<PriceAdjustment>()); set => _currentAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyValue<string> _currentComments;
        public string CurrentComments { get => _currentComments; set => _currentComments = value; }
        private DirtyValue<DateTime?> _currentLockDate;
        public DateTime? CurrentLockDate { get => _currentLockDate; set => _currentLockDate = value; }
        private DirtyValue<DateTime?> _currentLockExpires;
        public DateTime? CurrentLockExpires { get => _currentLockExpires; set => _currentLockExpires = value; }
        private DirtyValue<decimal?> _currentMarginRate;
        public decimal? CurrentMarginRate { get => _currentMarginRate; set => _currentMarginRate = value; }
        private DirtyValue<decimal?> _currentMarginRateRequested;
        public decimal? CurrentMarginRateRequested { get => _currentMarginRateRequested; set => _currentMarginRateRequested = value; }
        private DirtyValue<decimal?> _currentMarginTotalAdjustment;
        public decimal? CurrentMarginTotalAdjustment { get => _currentMarginTotalAdjustment; set => _currentMarginTotalAdjustment = value; }
        private DirtyValue<int?> _currentNumberOfDays;
        public int? CurrentNumberOfDays { get => _currentNumberOfDays; set => _currentNumberOfDays = value; }
        private DirtyValue<decimal?> _currentPriceRate;
        public decimal? CurrentPriceRate { get => _currentPriceRate; set => _currentPriceRate = value; }
        private DirtyValue<decimal?> _currentPriceRateRequested;
        public decimal? CurrentPriceRateRequested { get => _currentPriceRateRequested; set => _currentPriceRateRequested = value; }
        private DirtyValue<decimal?> _currentPriceTotalAdjustment;
        public decimal? CurrentPriceTotalAdjustment { get => _currentPriceTotalAdjustment; set => _currentPriceTotalAdjustment = value; }
        private DirtyValue<decimal?> _currentRate;
        public decimal? CurrentRate { get => _currentRate; set => _currentRate = value; }
        private DirtyValue<decimal?> _currentRateRequested;
        public decimal? CurrentRateRequested { get => _currentRateRequested; set => _currentRateRequested = value; }
        private DirtyValue<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => _currentRateSetDate = value; }
        private DirtyValue<string> _currentRateSheetID;
        public string CurrentRateSheetID { get => _currentRateSheetID; set => _currentRateSheetID = value; }
        private DirtyValue<decimal?> _currentRateTotalAdjustment;
        public decimal? CurrentRateTotalAdjustment { get => _currentRateTotalAdjustment; set => _currentRateTotalAdjustment = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<DateTime?> _dateFirstPaymentToInvestor;
        public DateTime? DateFirstPaymentToInvestor { get => _dateFirstPaymentToInvestor; set => _dateFirstPaymentToInvestor = value; }
        private DirtyValue<DateTime?> _dateLockedWithInvestor;
        public DateTime? DateLockedWithInvestor { get => _dateLockedWithInvestor; set => _dateLockedWithInvestor = value; }
        private DirtyValue<DateTime?> _dateSold;
        public DateTime? DateSold { get => _dateSold; set => _dateSold = value; }
        private DirtyValue<DateTime?> _dateWarehoused;
        public DateTime? DateWarehoused { get => _dateWarehoused; set => _dateWarehoused = value; }
        private DirtyValue<int?> _daysToExtend;
        public int? DaysToExtend { get => _daysToExtend; set => _daysToExtend = value; }
        private DirtyValue<string> _deliveryType;
        public string DeliveryType { get => _deliveryType; set => _deliveryType = value; }
        private DirtyValue<decimal?> _diffAmountReceived;
        public decimal? DiffAmountReceived { get => _diffAmountReceived; set => _diffAmountReceived = value; }
        private DirtyValue<decimal?> _diffImpounds;
        public decimal? DiffImpounds { get => _diffImpounds; set => _diffImpounds = value; }
        private DirtyValue<decimal?> _diffInterest;
        public decimal? DiffInterest { get => _diffInterest; set => _diffInterest = value; }
        private DirtyValue<decimal?> _diffPremium;
        public decimal? DiffPremium { get => _diffPremium; set => _diffPremium = value; }
        private DirtyValue<decimal?> _diffPrinciple;
        public decimal? DiffPrinciple { get => _diffPrinciple; set => _diffPrinciple = value; }
        private DirtyValue<decimal?> _diffRemainingBuydownFunds;
        public decimal? DiffRemainingBuydownFunds { get => _diffRemainingBuydownFunds; set => _diffRemainingBuydownFunds = value; }
        private DirtyValue<decimal?> _diffSellAmount;
        public decimal? DiffSellAmount { get => _diffSellAmount; set => _diffSellAmount = value; }
        private DirtyValue<decimal?> _diffSellPrice;
        public decimal? DiffSellPrice { get => _diffSellPrice; set => _diffSellPrice = value; }
        private DirtyValue<decimal?> _diffSellSideSRP;
        public decimal? DiffSellSideSRP { get => _diffSellSideSRP; set => _diffSellSideSRP = value; }
        private DirtyValue<decimal?> _diffSRP;
        public decimal? DiffSRP { get => _diffSRP; set => _diffSRP = value; }
        private DirtyValue<decimal?> _diffSRPAmount;
        public decimal? DiffSRPAmount { get => _diffSRPAmount; set => _diffSRPAmount = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator1;
        public bool? EmploymentBorrowerSelfEmployedIndicator1 { get => _employmentBorrowerSelfEmployedIndicator1; set => _employmentBorrowerSelfEmployedIndicator1 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator10;
        public bool? EmploymentBorrowerSelfEmployedIndicator10 { get => _employmentBorrowerSelfEmployedIndicator10; set => _employmentBorrowerSelfEmployedIndicator10 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator11;
        public bool? EmploymentBorrowerSelfEmployedIndicator11 { get => _employmentBorrowerSelfEmployedIndicator11; set => _employmentBorrowerSelfEmployedIndicator11 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator12;
        public bool? EmploymentBorrowerSelfEmployedIndicator12 { get => _employmentBorrowerSelfEmployedIndicator12; set => _employmentBorrowerSelfEmployedIndicator12 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator2;
        public bool? EmploymentBorrowerSelfEmployedIndicator2 { get => _employmentBorrowerSelfEmployedIndicator2; set => _employmentBorrowerSelfEmployedIndicator2 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator3;
        public bool? EmploymentBorrowerSelfEmployedIndicator3 { get => _employmentBorrowerSelfEmployedIndicator3; set => _employmentBorrowerSelfEmployedIndicator3 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator4;
        public bool? EmploymentBorrowerSelfEmployedIndicator4 { get => _employmentBorrowerSelfEmployedIndicator4; set => _employmentBorrowerSelfEmployedIndicator4 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator5;
        public bool? EmploymentBorrowerSelfEmployedIndicator5 { get => _employmentBorrowerSelfEmployedIndicator5; set => _employmentBorrowerSelfEmployedIndicator5 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator6;
        public bool? EmploymentBorrowerSelfEmployedIndicator6 { get => _employmentBorrowerSelfEmployedIndicator6; set => _employmentBorrowerSelfEmployedIndicator6 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator7;
        public bool? EmploymentBorrowerSelfEmployedIndicator7 { get => _employmentBorrowerSelfEmployedIndicator7; set => _employmentBorrowerSelfEmployedIndicator7 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator8;
        public bool? EmploymentBorrowerSelfEmployedIndicator8 { get => _employmentBorrowerSelfEmployedIndicator8; set => _employmentBorrowerSelfEmployedIndicator8 = value; }
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator9;
        public bool? EmploymentBorrowerSelfEmployedIndicator9 { get => _employmentBorrowerSelfEmployedIndicator9; set => _employmentBorrowerSelfEmployedIndicator9 = value; }
        private DirtyValue<decimal?> _expectedAmountReceived;
        public decimal? ExpectedAmountReceived { get => _expectedAmountReceived; set => _expectedAmountReceived = value; }
        private DirtyValue<decimal?> _expectedImpounds;
        public decimal? ExpectedImpounds { get => _expectedImpounds; set => _expectedImpounds = value; }
        private DirtyValue<decimal?> _expectedInterest;
        public decimal? ExpectedInterest { get => _expectedInterest; set => _expectedInterest = value; }
        private DirtyValue<decimal?> _expectedPremium;
        public decimal? ExpectedPremium { get => _expectedPremium; set => _expectedPremium = value; }
        private DirtyValue<decimal?> _expectedPrinciple;
        public decimal? ExpectedPrinciple { get => _expectedPrinciple; set => _expectedPrinciple = value; }
        private DirtyValue<decimal?> _expectedRemainingBuydownFunds;
        public decimal? ExpectedRemainingBuydownFunds { get => _expectedRemainingBuydownFunds; set => _expectedRemainingBuydownFunds = value; }
        private DirtyValue<decimal?> _expectedSRP;
        public decimal? ExpectedSRP { get => _expectedSRP; set => _expectedSRP = value; }
        private DirtyValue<string> _extensionRequestPending;
        public string ExtensionRequestPending { get => _extensionRequestPending; set => _extensionRequestPending = value; }
        private DirtyValue<int?> _extensionSequenceNumber;
        public int? ExtensionSequenceNumber { get => _extensionSequenceNumber; set => _extensionSequenceNumber = value; }
        private DirtyList<ExtraPayment> _extraPayments;
        public IList<ExtraPayment> ExtraPayments { get => _extraPayments ?? (_extraPayments = new DirtyList<ExtraPayment>()); set => _extraPayments = new DirtyList<ExtraPayment>(value); }
        private DirtyValue<decimal?> _fHAUpfrontMIPremiumPercent;
        public decimal? FHAUpfrontMIPremiumPercent { get => _fHAUpfrontMIPremiumPercent; set => _fHAUpfrontMIPremiumPercent = value; }
        private DirtyValue<int?> _financedNumberOfUnits;
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => _financedNumberOfUnits = value; }
        private DirtyValue<StringEnumValue<PartyType>> _firstPaymenTo;
        public StringEnumValue<PartyType> FirstPaymenTo { get => _firstPaymenTo; set => _firstPaymenTo = value; }
        private DirtyValue<decimal?> _firstSubordinateAmount;
        public decimal? FirstSubordinateAmount { get => _firstSubordinateAmount; set => _firstSubordinateAmount = value; }
        private DirtyValue<bool?> _firstTimeHomebuyersIndicator;
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => _firstTimeHomebuyersIndicator = value; }
        private DirtyValue<string> _fNMProductPlanIdentifier;
        public string FNMProductPlanIdentifier { get => _fNMProductPlanIdentifier; set => _fNMProductPlanIdentifier = value; }
        private DirtyValue<decimal?> _fundingAmount;
        public decimal? FundingAmount { get => _fundingAmount; set => _fundingAmount = value; }
        private DirtyValue<decimal?> _gainLossPercentage;
        public decimal? GainLossPercentage { get => _gainLossPercentage; set => _gainLossPercentage = value; }
        private DirtyValue<decimal?> _gainLossPrice;
        public decimal? GainLossPrice { get => _gainLossPrice; set => _gainLossPrice = value; }
        private DirtyValue<decimal?> _gainLossTotalBuyPrice;
        public decimal? GainLossTotalBuyPrice { get => _gainLossTotalBuyPrice; set => _gainLossTotalBuyPrice = value; }
        private DirtyValue<decimal?> _gPMRate;
        public decimal? GPMRate { get => _gPMRate; set => _gPMRate = value; }
        private DirtyValue<int?> _gPMYears;
        public int? GPMYears { get => _gPMYears; set => _gPMYears = value; }
        private DirtyValue<StringEnumValue<PropertyType>> _gSEPropertyType;
        public StringEnumValue<PropertyType> GSEPropertyType { get => _gSEPropertyType; set => _gSEPropertyType = value; }
        private DirtyValue<StringEnumValue<YOrN>> _hedging;
        public StringEnumValue<YOrN> Hedging { get => _hedging; set => _hedging = value; }
        private DirtyValue<string> _hELOCActualBalance;
        public string HELOCActualBalance { get => _hELOCActualBalance; set => _hELOCActualBalance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _impounds;
        public decimal? Impounds { get => _impounds; set => _impounds = value; }
        private DirtyValue<StringEnumValue<ImpoundType>> _impoundType;
        public StringEnumValue<ImpoundType> ImpoundType { get => _impoundType; set => _impoundType = value; }
        private DirtyValue<StringEnumValue<ImpoundWaived>> _impoundWavied;
        public StringEnumValue<ImpoundWaived> ImpoundWavied { get => _impoundWavied; set => _impoundWavied = value; }
        private DirtyValue<decimal?> _interest;
        public decimal? Interest { get => _interest; set => _interest = value; }
        private DirtyValue<string> _investorAddress;
        public string InvestorAddress { get => _investorAddress; set => _investorAddress = value; }
        private DirtyValue<string> _investorCity;
        public string InvestorCity { get => _investorCity; set => _investorCity = value; }
        private DirtyValue<string> _investorCommitment;
        public string InvestorCommitment { get => _investorCommitment; set => _investorCommitment = value; }
        private DirtyValue<string> _investorContact;
        public string InvestorContact { get => _investorContact; set => _investorContact = value; }
        private DirtyValue<DateTime?> _investorDeliveryDate;
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => _investorDeliveryDate = value; }
        private DirtyValue<string> _investorEmail;
        public string InvestorEmail { get => _investorEmail; set => _investorEmail = value; }
        private DirtyValue<string> _investorLoanNumber;
        public string InvestorLoanNumber { get => _investorLoanNumber; set => _investorLoanNumber = value; }
        private DirtyValue<string> _investorLockType;
        public string InvestorLockType { get => _investorLockType; set => _investorLockType = value; }
        private DirtyValue<string> _investorMERSNumber;
        public string InvestorMERSNumber { get => _investorMERSNumber; set => _investorMERSNumber = value; }
        private DirtyValue<string> _investorName;
        public string InvestorName { get => _investorName; set => _investorName = value; }
        private DirtyValue<string> _investorPhone;
        public string InvestorPhone { get => _investorPhone; set => _investorPhone = value; }
        private DirtyValue<string> _investorPostalCode;
        public string InvestorPostalCode { get => _investorPostalCode; set => _investorPostalCode = value; }
        private DirtyValue<string> _investorProgramCode;
        public string InvestorProgramCode { get => _investorProgramCode; set => _investorProgramCode = value; }
        private DirtyValue<string> _investorState;
        public string InvestorState { get => _investorState; set => _investorState = value; }
        private DirtyValue<DateTime?> _investorTargetDeliveryDate;
        public DateTime? InvestorTargetDeliveryDate { get => _investorTargetDeliveryDate; set => _investorTargetDeliveryDate = value; }
        private DirtyValue<string> _investorTemplateName;
        public string InvestorTemplateName { get => _investorTemplateName; set => _investorTemplateName = value; }
        private DirtyValue<string> _investorWebsite;
        public string InvestorWebsite { get => _investorWebsite; set => _investorWebsite = value; }
        private DirtyValue<string> _isCancelled;
        public string IsCancelled { get => _isCancelled; set => _isCancelled = value; }
        private DirtyValue<bool?> _isDeliveryType;
        public bool? IsDeliveryType { get => _isDeliveryType; set => _isDeliveryType = value; }
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => _lenderPaidMortgageInsuranceIndicator = value; }
        private DirtyValue<StringEnumValue<LienType>> _lienPriorityType;
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => _lienPriorityType = value; }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => _loanAmortizationTermMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanAmortizationType;
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => _loanAmortizationType = value; }
        private DirtyValue<StringEnumValue<LoanDocumentationType>> _loanDocumentationType;
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => _loanDocumentationType = value; }
        private DirtyValue<bool?> _loanFor203K;
        public bool? LoanFor203K { get => _loanFor203K; set => _loanFor203K = value; }
        private DirtyValue<string> _loanProgram;
        public string LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<string> _loanProgramFile;
        public string LoanProgramFile { get => _loanProgramFile; set => _loanProgramFile = value; }
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => _loanScheduledClosingDate = value; }
        private DirtyValue<bool?> _lockField;
        public bool? LockField { get => _lockField; set => _lockField = value; }
        private DirtyList<PriceAdjustment> _lockRequestAdjustments;
        public IList<PriceAdjustment> LockRequestAdjustments { get => _lockRequestAdjustments ?? (_lockRequestAdjustments = new DirtyList<PriceAdjustment>()); set => _lockRequestAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyList<LockRequestBorrower> _lockRequestBorrowers;
        public IList<LockRequestBorrower> LockRequestBorrowers { get => _lockRequestBorrowers ?? (_lockRequestBorrowers = new DirtyList<LockRequestBorrower>()); set => _lockRequestBorrowers = new DirtyList<LockRequestBorrower>(value); }
        private DirtyValue<StringEnumValue<LockRequestLoanPurposeType>> _lockRequestLoanPurposeType;
        public StringEnumValue<LockRequestLoanPurposeType> LockRequestLoanPurposeType { get => _lockRequestLoanPurposeType; set => _lockRequestLoanPurposeType = value; }
        private DirtyValue<decimal?> _lTV;
        public decimal? LTV { get => _lTV; set => _lTV = value; }
        private DirtyValue<string> _minFICO;
        public string MinFICO { get => _minFICO; set => _minFICO = value; }
        private DirtyValue<string> _minFICO2;
        public string MinFICO2 { get => _minFICO2; set => _minFICO2 = value; }
        private DirtyValue<decimal?> _mIPPaidInCash;
        public decimal? MIPPaidInCash { get => _mIPPaidInCash; set => _mIPPaidInCash = value; }
        private DirtyValue<StringEnumValue<LoanType>> _mortgageType;
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<decimal?> _netSellAmount;
        public decimal? NetSellAmount { get => _netSellAmount; set => _netSellAmount = value; }
        private DirtyValue<decimal?> _netSellPrice;
        public decimal? NetSellPrice { get => _netSellPrice; set => _netSellPrice = value; }
        private DirtyValue<DateTime?> _nextPaymentDate;
        public DateTime? NextPaymentDate { get => _nextPaymentDate; set => _nextPaymentDate = value; }
        private DirtyValue<bool?> _noClosingCostOption;
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => _noClosingCostOption = value; }
        private DirtyValue<StringEnumValue<YOrN>> _oNRPLock;
        public StringEnumValue<YOrN> ONRPLock { get => _oNRPLock; set => _oNRPLock = value; }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => _otherAmortizationTypeDescription = value; }
        private DirtyValue<decimal?> _otherSubordinateAmount;
        public decimal? OtherSubordinateAmount { get => _otherSubordinateAmount; set => _otherSubordinateAmount = value; }
        private DirtyValue<StringEnumValue<PenaltyTerm>> _penaltyTerm;
        public StringEnumValue<PenaltyTerm> PenaltyTerm { get => _penaltyTerm; set => _penaltyTerm = value; }
        private DirtyValue<StringEnumValue<PerDiemInterestRoundingType>> _perDiemInterestRoundingType;
        public StringEnumValue<PerDiemInterestRoundingType> PerDiemInterestRoundingType { get => _perDiemInterestRoundingType; set => _perDiemInterestRoundingType = value; }
        private DirtyValue<string> _planCode;
        public string PlanCode { get => _planCode; set => _planCode = value; }
        private DirtyValue<decimal?> _premium;
        public decimal? Premium { get => _premium; set => _premium = value; }
        private DirtyValue<StringEnumValue<YOrN>> _prepayPenalty;
        public StringEnumValue<YOrN> PrepayPenalty { get => _prepayPenalty; set => _prepayPenalty = value; }
        private DirtyValue<decimal?> _priceAdjustment;
        public decimal? PriceAdjustment { get => _priceAdjustment; set => _priceAdjustment = value; }
        private DirtyList<PriceAdjustment> _priceAdjustments;
        public IList<PriceAdjustment> PriceAdjustments { get => _priceAdjustments ?? (_priceAdjustments = new DirtyList<PriceAdjustment>()); set => _priceAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyValue<string> _pricingHistoryData;
        public string PricingHistoryData { get => _pricingHistoryData; set => _pricingHistoryData = value; }
        private DirtyValue<string> _pricingUpdated;
        public string PricingUpdated { get => _pricingUpdated; set => _pricingUpdated = value; }
        private DirtyValue<decimal?> _principle;
        public decimal? Principle { get => _principle; set => _principle = value; }
        private DirtyValue<decimal?> _profitMarginAdjustedBuyPrice;
        public decimal? ProfitMarginAdjustedBuyPrice { get => _profitMarginAdjustedBuyPrice; set => _profitMarginAdjustedBuyPrice = value; }
        private DirtyValue<int?> _propertyAppraisedValueAmount;
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => _propertyAppraisedValueAmount = value; }
        private DirtyValue<int?> _propertyEstimatedValueAmount;
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => _propertyEstimatedValueAmount = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<int?> _purchaseAdviceNumberOfDays;
        public int? PurchaseAdviceNumberOfDays { get => _purchaseAdviceNumberOfDays; set => _purchaseAdviceNumberOfDays = value; }
        private DirtyList<PurchaseAdvicePayout> _purchaseAdvicePayouts;
        public IList<PurchaseAdvicePayout> PurchaseAdvicePayouts { get => _purchaseAdvicePayouts ?? (_purchaseAdvicePayouts = new DirtyList<PurchaseAdvicePayout>()); set => _purchaseAdvicePayouts = new DirtyList<PurchaseAdvicePayout>(value); }
        private DirtyValue<decimal?> _purchasePriceAmount;
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => _purchasePriceAmount = value; }
        private DirtyValue<string> _rateRequestStatus;
        public string RateRequestStatus { get => _rateRequestStatus; set => _rateRequestStatus = value; }
        private DirtyValue<string> _rateStatus;
        public string RateStatus { get => _rateStatus; set => _rateStatus = value; }
        private DirtyValue<string> _reasonforBranchApproval;
        public string ReasonforBranchApproval { get => _reasonforBranchApproval; set => _reasonforBranchApproval = value; }
        private DirtyValue<string> _reasonforCorporateApproval;
        public string ReasonforCorporateApproval { get => _reasonforCorporateApproval; set => _reasonforCorporateApproval = value; }
        private DirtyValue<decimal?> _reconciledDiff;
        public decimal? ReconciledDiff { get => _reconciledDiff; set => _reconciledDiff = value; }
        private DirtyValue<string> _reLockRequestPending;
        public string ReLockRequestPending { get => _reLockRequestPending; set => _reLockRequestPending = value; }
        private DirtyValue<decimal?> _remainingBuydownFunds;
        public decimal? RemainingBuydownFunds { get => _remainingBuydownFunds; set => _remainingBuydownFunds = value; }
        private DirtyValue<string> _requestComments;
        public string RequestComments { get => _requestComments; set => _requestComments = value; }
        private DirtyValue<DateTime?> _requestCurrentRateSetDate;
        public DateTime? RequestCurrentRateSetDate { get => _requestCurrentRateSetDate; set => _requestCurrentRateSetDate = value; }
        private DirtyValue<int?> _requestDaystoExtend;
        public int? RequestDaystoExtend { get => _requestDaystoExtend; set => _requestDaystoExtend = value; }
        private DirtyValue<DateTime?> _requestExtendedLockExpires;
        public DateTime? RequestExtendedLockExpires { get => _requestExtendedLockExpires; set => _requestExtendedLockExpires = value; }
        private DirtyValue<string> _requestFullfilledDateTime;
        public string RequestFullfilledDateTime { get => _requestFullfilledDateTime; set => _requestFullfilledDateTime = value; }
        private DirtyValue<StringEnumValue<ImpoundType>> _requestImpoundType;
        public StringEnumValue<ImpoundType> RequestImpoundType { get => _requestImpoundType; set => _requestImpoundType = value; }
        private DirtyValue<StringEnumValue<ImpoundWaived>> _requestImpoundWavied;
        public StringEnumValue<ImpoundWaived> RequestImpoundWavied { get => _requestImpoundWavied; set => _requestImpoundWavied = value; }
        private DirtyValue<string> _requestLockCancellationComment;
        public string RequestLockCancellationComment { get => _requestLockCancellationComment; set => _requestLockCancellationComment = value; }
        private DirtyValue<DateTime?> _requestLockCancellationDate;
        public DateTime? RequestLockCancellationDate { get => _requestLockCancellationDate; set => _requestLockCancellationDate = value; }
        private DirtyValue<DateTime?> _requestLockDate;
        public DateTime? RequestLockDate { get => _requestLockDate; set => _requestLockDate = value; }
        private DirtyValue<DateTime?> _requestLockExpires;
        public DateTime? RequestLockExpires { get => _requestLockExpires; set => _requestLockExpires = value; }
        private DirtyValue<string> _requestLockExtendComment;
        public string RequestLockExtendComment { get => _requestLockExtendComment; set => _requestLockExtendComment = value; }
        private DirtyValue<decimal?> _requestLockExtendPriceAdjustment;
        public decimal? RequestLockExtendPriceAdjustment { get => _requestLockExtendPriceAdjustment; set => _requestLockExtendPriceAdjustment = value; }
        private DirtyValue<string> _requestLockStatus;
        public string RequestLockStatus { get => _requestLockStatus; set => _requestLockStatus = value; }
        private DirtyValue<string> _requestLockType;
        public string RequestLockType { get => _requestLockType; set => _requestLockType = value; }
        private DirtyValue<decimal?> _requestMarginRate;
        public decimal? RequestMarginRate { get => _requestMarginRate; set => _requestMarginRate = value; }
        private DirtyValue<decimal?> _requestMarginRateRequested;
        public decimal? RequestMarginRateRequested { get => _requestMarginRateRequested; set => _requestMarginRateRequested = value; }
        private DirtyValue<decimal?> _requestMarginSRPPaidOut;
        public decimal? RequestMarginSRPPaidOut { get => _requestMarginSRPPaidOut; set => _requestMarginSRPPaidOut = value; }
        private DirtyValue<decimal?> _requestMarginTotalAdjustment;
        public decimal? RequestMarginTotalAdjustment { get => _requestMarginTotalAdjustment; set => _requestMarginTotalAdjustment = value; }
        private DirtyValue<int?> _requestNumberOfDays;
        public int? RequestNumberOfDays { get => _requestNumberOfDays; set => _requestNumberOfDays = value; }
        private DirtyValue<bool?> _requestOnrpEligible;
        public bool? RequestOnrpEligible { get => _requestOnrpEligible; set => _requestOnrpEligible = value; }
        private DirtyValue<DateTime?> _requestOnrpLockDate;
        public DateTime? RequestOnrpLockDate { get => _requestOnrpLockDate; set => _requestOnrpLockDate = value; }
        private DirtyValue<string> _requestOnrpLockTime;
        public string RequestOnrpLockTime { get => _requestOnrpLockTime; set => _requestOnrpLockTime = value; }
        private DirtyValue<DateTime?> _requestOriginalLockExpires;
        public DateTime? RequestOriginalLockExpires { get => _requestOriginalLockExpires; set => _requestOriginalLockExpires = value; }
        private DirtyValue<StringEnumValue<PenaltyTerm>> _requestPenaltyTerm;
        public StringEnumValue<PenaltyTerm> RequestPenaltyTerm { get => _requestPenaltyTerm; set => _requestPenaltyTerm = value; }
        private DirtyValue<string> _requestPending;
        public string RequestPending { get => _requestPending; set => _requestPending = value; }
        private DirtyValue<StringEnumValue<YOrN>> _requestPrepayPenalty;
        public StringEnumValue<YOrN> RequestPrepayPenalty { get => _requestPrepayPenalty; set => _requestPrepayPenalty = value; }
        private DirtyValue<decimal?> _requestPriceRate;
        public decimal? RequestPriceRate { get => _requestPriceRate; set => _requestPriceRate = value; }
        private DirtyValue<decimal?> _requestPriceRateRequested;
        public decimal? RequestPriceRateRequested { get => _requestPriceRateRequested; set => _requestPriceRateRequested = value; }
        private DirtyValue<decimal?> _requestPriceTotalAdjustment;
        public decimal? RequestPriceTotalAdjustment { get => _requestPriceTotalAdjustment; set => _requestPriceTotalAdjustment = value; }
        private DirtyValue<decimal?> _requestRate;
        public decimal? RequestRate { get => _requestRate; set => _requestRate = value; }
        private DirtyValue<decimal?> _requestRateRequested;
        public decimal? RequestRateRequested { get => _requestRateRequested; set => _requestRateRequested = value; }
        private DirtyValue<string> _requestRateSheetID;
        public string RequestRateSheetID { get => _requestRateSheetID; set => _requestRateSheetID = value; }
        private DirtyValue<decimal?> _requestRateTotalAdjustment;
        public decimal? RequestRateTotalAdjustment { get => _requestRateTotalAdjustment; set => _requestRateTotalAdjustment = value; }
        private DirtyValue<decimal?> _requestStartingAdjPoint;
        public decimal? RequestStartingAdjPoint { get => _requestStartingAdjPoint; set => _requestStartingAdjPoint = value; }
        private DirtyValue<decimal?> _requestStartingAdjRate;
        public decimal? RequestStartingAdjRate { get => _requestStartingAdjRate; set => _requestStartingAdjRate = value; }
        private DirtyValue<string> _requestType;
        public string RequestType { get => _requestType; set => _requestType = value; }
        private DirtyValue<decimal?> _requestUnDiscountedRate;
        public decimal? RequestUnDiscountedRate { get => _requestUnDiscountedRate; set => _requestUnDiscountedRate = value; }
        private DirtyValue<bool?> _roundToNearest50;
        public bool? RoundToNearest50 { get => _roundToNearest50; set => _roundToNearest50 = value; }
        private DirtyValue<decimal?> _secondSubordinateAmount;
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => _secondSubordinateAmount = value; }
        private DirtyValue<decimal?> _sellerPaidMIPremium;
        public decimal? SellerPaidMIPremium { get => _sellerPaidMIPremium; set => _sellerPaidMIPremium = value; }
        private DirtyList<PriceAdjustment> _sellSideAdjustments;
        public IList<PriceAdjustment> SellSideAdjustments { get => _sellSideAdjustments ?? (_sellSideAdjustments = new DirtyList<PriceAdjustment>()); set => _sellSideAdjustments = new DirtyList<PriceAdjustment>(value); }
        private DirtyValue<string> _sellSideComments;
        public string SellSideComments { get => _sellSideComments; set => _sellSideComments = value; }
        private DirtyValue<string> _sellSideCommitmentContractNumber;
        public string SellSideCommitmentContractNumber { get => _sellSideCommitmentContractNumber; set => _sellSideCommitmentContractNumber = value; }
        private DirtyValue<DateTime?> _sellSideCommitmentDate;
        public DateTime? SellSideCommitmentDate { get => _sellSideCommitmentDate; set => _sellSideCommitmentDate = value; }
        private DirtyValue<DateTime?> _sellSideCurrentRateSetDate;
        public DateTime? SellSideCurrentRateSetDate { get => _sellSideCurrentRateSetDate; set => _sellSideCurrentRateSetDate = value; }
        private DirtyValue<int?> _sellSideDaystoExtend;
        public int? SellSideDaystoExtend { get => _sellSideDaystoExtend; set => _sellSideDaystoExtend = value; }
        private DirtyValue<decimal?> _sellSideDiscountYSP;
        public decimal? SellSideDiscountYSP { get => _sellSideDiscountYSP; set => _sellSideDiscountYSP = value; }
        private DirtyValue<DateTime?> _sellSideExtendedLockExpires;
        public DateTime? SellSideExtendedLockExpires { get => _sellSideExtendedLockExpires; set => _sellSideExtendedLockExpires = value; }
        private DirtyValue<decimal?> _sellSideGuaranteeFee;
        public decimal? SellSideGuaranteeFee { get => _sellSideGuaranteeFee; set => _sellSideGuaranteeFee = value; }
        private DirtyValue<decimal?> _sellSideGuarantyBaseFee;
        public decimal? SellSideGuarantyBaseFee { get => _sellSideGuarantyBaseFee; set => _sellSideGuarantyBaseFee = value; }
        private DirtyValue<StringEnumValue<SellSideInvestorStatus>> _sellSideInvestorStatus;
        public StringEnumValue<SellSideInvestorStatus> SellSideInvestorStatus { get => _sellSideInvestorStatus; set => _sellSideInvestorStatus = value; }
        private DirtyValue<DateTime?> _sellSideInvestorStatusDate;
        public DateTime? SellSideInvestorStatusDate { get => _sellSideInvestorStatusDate; set => _sellSideInvestorStatusDate = value; }
        private DirtyValue<string> _sellSideInvestorTradeNumber;
        public string SellSideInvestorTradeNumber { get => _sellSideInvestorTradeNumber; set => _sellSideInvestorTradeNumber = value; }
        private DirtyValue<string> _sellSideLoanProgram;
        public string SellSideLoanProgram { get => _sellSideLoanProgram; set => _sellSideLoanProgram = value; }
        private DirtyValue<DateTime?> _sellSideLockDate;
        public DateTime? SellSideLockDate { get => _sellSideLockDate; set => _sellSideLockDate = value; }
        private DirtyValue<DateTime?> _sellSideLockExpires;
        public DateTime? SellSideLockExpires { get => _sellSideLockExpires; set => _sellSideLockExpires = value; }
        private DirtyValue<decimal?> _sellSideLockExtendPriceAdjustment;
        public decimal? SellSideLockExtendPriceAdjustment { get => _sellSideLockExtendPriceAdjustment; set => _sellSideLockExtendPriceAdjustment = value; }
        private DirtyValue<decimal?> _sellSideMarginNetSellRate;
        public decimal? SellSideMarginNetSellRate { get => _sellSideMarginNetSellRate; set => _sellSideMarginNetSellRate = value; }
        private DirtyValue<decimal?> _sellSideMarginRate;
        public decimal? SellSideMarginRate { get => _sellSideMarginRate; set => _sellSideMarginRate = value; }
        private DirtyValue<decimal?> _sellSideMarginTotalAdjustment;
        public decimal? SellSideMarginTotalAdjustment { get => _sellSideMarginTotalAdjustment; set => _sellSideMarginTotalAdjustment = value; }
        private DirtyValue<string> _sellSideMasterContractNumber;
        public string SellSideMasterContractNumber { get => _sellSideMasterContractNumber; set => _sellSideMasterContractNumber = value; }
        private DirtyValue<decimal?> _sellSideMSRValue;
        public decimal? SellSideMSRValue { get => _sellSideMSRValue; set => _sellSideMSRValue = value; }
        private DirtyValue<decimal?> _sellSideNetSellPrice;
        public decimal? SellSideNetSellPrice { get => _sellSideNetSellPrice; set => _sellSideNetSellPrice = value; }
        private DirtyValue<decimal?> _sellSideNetSellRate;
        public decimal? SellSideNetSellRate { get => _sellSideNetSellRate; set => _sellSideNetSellRate = value; }
        private DirtyValue<int?> _sellSideNumberOfDays;
        public int? SellSideNumberOfDays { get => _sellSideNumberOfDays; set => _sellSideNumberOfDays = value; }
        private DirtyValue<DateTime?> _sellSideOriginalLockExpires;
        public DateTime? SellSideOriginalLockExpires { get => _sellSideOriginalLockExpires; set => _sellSideOriginalLockExpires = value; }
        private DirtyValue<string> _sellSidePoolID;
        public string SellSidePoolID { get => _sellSidePoolID; set => _sellSidePoolID = value; }
        private DirtyValue<string> _sellSidePoolNumber;
        public string SellSidePoolNumber { get => _sellSidePoolNumber; set => _sellSidePoolNumber = value; }
        private DirtyValue<decimal?> _sellSidePriceRate;
        public decimal? SellSidePriceRate { get => _sellSidePriceRate; set => _sellSidePriceRate = value; }
        private DirtyValue<decimal?> _sellSidePriceTotalAdjustment;
        public decimal? SellSidePriceTotalAdjustment { get => _sellSidePriceTotalAdjustment; set => _sellSidePriceTotalAdjustment = value; }
        private DirtyValue<string> _sellSideProductName;
        public string SellSideProductName { get => _sellSideProductName; set => _sellSideProductName = value; }
        private DirtyValue<decimal?> _sellSideRate;
        public decimal? SellSideRate { get => _sellSideRate; set => _sellSideRate = value; }
        private DirtyValue<string> _sellSideRateSheetID;
        public string SellSideRateSheetID { get => _sellSideRateSheetID; set => _sellSideRateSheetID = value; }
        private DirtyValue<decimal?> _sellSideRateTotalAdjustment;
        public decimal? SellSideRateTotalAdjustment { get => _sellSideRateTotalAdjustment; set => _sellSideRateTotalAdjustment = value; }
        private DirtyValue<string> _sellSideRequestedBy;
        public string SellSideRequestedBy { get => _sellSideRequestedBy; set => _sellSideRequestedBy = value; }
        private DirtyValue<string> _sellSideServicer;
        public string SellSideServicer { get => _sellSideServicer; set => _sellSideServicer = value; }
        private DirtyValue<decimal?> _sellSideServicingFee;
        public decimal? SellSideServicingFee { get => _sellSideServicingFee; set => _sellSideServicingFee = value; }
        private DirtyValue<StringEnumValue<ServicingType>> _sellSideServicingType;
        public StringEnumValue<ServicingType> SellSideServicingType { get => _sellSideServicingType; set => _sellSideServicingType = value; }
        private DirtyValue<decimal?> _sellSideSRP;
        public decimal? SellSideSRP { get => _sellSideSRP; set => _sellSideSRP = value; }
        private DirtyValue<decimal?> _sellSideSRPPaidOut;
        public decimal? SellSideSRPPaidOut { get => _sellSideSRPPaidOut; set => _sellSideSRPPaidOut = value; }
        private DirtyValue<string> _sellSideTradeGuid;
        public string SellSideTradeGuid { get => _sellSideTradeGuid; set => _sellSideTradeGuid = value; }
        private DirtyValue<string> _sellSideTradeMgmtPrevConfirmedLockGuid;
        public string SellSideTradeMgmtPrevConfirmedLockGuid { get => _sellSideTradeMgmtPrevConfirmedLockGuid; set => _sellSideTradeMgmtPrevConfirmedLockGuid = value; }
        private DirtyValue<string> _sellSideTradeNumber;
        public string SellSideTradeNumber { get => _sellSideTradeNumber; set => _sellSideTradeNumber = value; }
        private DirtyValue<bool?> _servicingReleaseIndicator;
        public bool? ServicingReleaseIndicator { get => _servicingReleaseIndicator; set => _servicingReleaseIndicator = value; }
        private DirtyValue<decimal?> _sRP;
        public decimal? SRP { get => _sRP; set => _sRP = value; }
        private DirtyValue<decimal?> _sRPAmount;
        public decimal? SRPAmount { get => _sRPAmount; set => _sRPAmount = value; }
        private DirtyValue<decimal?> _sRPPaidOut;
        public decimal? SRPPaidOut { get => _sRPPaidOut; set => _sRPPaidOut = value; }
        private DirtyValue<string> _subjectPropertyCity;
        public string SubjectPropertyCity { get => _subjectPropertyCity; set => _subjectPropertyCity = value; }
        private DirtyValue<bool?> _subjectPropertyCondotelIndicator;
        public bool? SubjectPropertyCondotelIndicator { get => _subjectPropertyCondotelIndicator; set => _subjectPropertyCondotelIndicator = value; }
        private DirtyValue<string> _subjectPropertyCounty;
        public string SubjectPropertyCounty { get => _subjectPropertyCounty; set => _subjectPropertyCounty = value; }
        private DirtyValue<bool?> _subjectPropertyNonWarrantableProjectIndicator;
        public bool? SubjectPropertyNonWarrantableProjectIndicator { get => _subjectPropertyNonWarrantableProjectIndicator; set => _subjectPropertyNonWarrantableProjectIndicator = value; }
        private DirtyValue<string> _subjectPropertyPostalCode;
        public string SubjectPropertyPostalCode { get => _subjectPropertyPostalCode; set => _subjectPropertyPostalCode = value; }
        private DirtyValue<string> _subjectPropertyState;
        public string SubjectPropertyState { get => _subjectPropertyState; set => _subjectPropertyState = value; }
        private DirtyValue<string> _subjectPropertyStreetAddress;
        public string SubjectPropertyStreetAddress { get => _subjectPropertyStreetAddress; set => _subjectPropertyStreetAddress = value; }
        private DirtyValue<string> _timeLockedWithInvestor;
        public string TimeLockedWithInvestor { get => _timeLockedWithInvestor; set => _timeLockedWithInvestor = value; }
        private DirtyValue<decimal?> _totalBuyPrice;
        public decimal? TotalBuyPrice { get => _totalBuyPrice; set => _totalBuyPrice = value; }
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => _totalForLesserOfSumAsIs = value; }
        private DirtyValue<decimal?> _totalPrice;
        public decimal? TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        private DirtyValue<decimal?> _totalSubordinateFinancing;
        public decimal? TotalSubordinateFinancing { get => _totalSubordinateFinancing; set => _totalSubordinateFinancing = value; }
        private DirtyValue<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => _twelveMonthMortgageRentalHistoryIndicator = value; }
        private DirtyValue<string> _type;
        public string Type { get => _type; set => _type = value; }
        private DirtyValue<bool?> _usePoint;
        public bool? UsePoint { get => _usePoint; set => _usePoint = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _actualSellAmount.Dirty
                    || _actualSellPrice.Dirty
                    || _actualSellSideSRP.Dirty
                    || _actualSRPAmount.Dirty
                    || _amountDue.Dirty
                    || _amountDueTo.Dirty
                    || _amountPaid.Dirty
                    || _amountPaidTo.Dirty
                    || _amountReceived.Dirty
                    || _balloonLoanMaturityTermMonths.Dirty
                    || _baseLoanAmount.Dirty
                    || _borrowerRequestedLoanAmount.Dirty
                    || _branchApprovalDate.Dirty
                    || _branchApprovedby.Dirty
                    || _branchPrice.Dirty
                    || _buySideComments.Dirty
                    || _buySideCommitmentDate.Dirty
                    || _buySideCommitmentNumber.Dirty
                    || _buySideCommitmentType.Dirty
                    || _buySideCurrentRateSetDate.Dirty
                    || _buySideDaystoExtend.Dirty
                    || _buySideDeliveryExpirationDate.Dirty
                    || _buySideDeliveryType.Dirty
                    || _buySideExpirationDate.Dirty
                    || _buySideExtendedLockExpires.Dirty
                    || _buySideLockDate.Dirty
                    || _buySideLockExpires.Dirty
                    || _buySideLockExtendPriceAdjustment.Dirty
                    || _buySideMarginNetBuyRate.Dirty
                    || _buySideMarginRate.Dirty
                    || _buySideMarginTotalAdjustment.Dirty
                    || _buySideMasterCommitmentNumber.Dirty
                    || _buySideNumberOfDays.Dirty
                    || _buySideOnrpEligible.Dirty
                    || _buySideOnrpLockDate.Dirty
                    || _buySideOnrpLockTime.Dirty
                    || _buySideOrgID.Dirty
                    || _buySideOriginalLockExpires.Dirty
                    || _buySidePriceNetBuyPrice.Dirty
                    || _buySidePriceRate.Dirty
                    || _buySidePriceTotalAdjustment.Dirty
                    || _buySideRate.Dirty
                    || _buySideRateNetBuyRate.Dirty
                    || _buySideRateSheetID.Dirty
                    || _buySideRateTotalAdjustment.Dirty
                    || _buySideRequestedBy.Dirty
                    || _buySideSRPPaidOut.Dirty
                    || _buySideStartingAdjPoint.Dirty
                    || _buySideStartingAdjPrice.Dirty
                    || _buySideStartingAdjRate.Dirty
                    || _buySideTPOID.Dirty
                    || _buySideTPOName.Dirty
                    || _buySideTradeGuid.Dirty
                    || _buySideTradeNumber.Dirty
                    || _buySideUnDiscountedRate.Dirty
                    || _cancellationRequestPending.Dirty
                    || _combinedLTV.Dirty
                    || _comments.Dirty
                    || _commitment.Dirty
                    || _commitmentType.Dirty
                    || _compGainLossPercentage.Dirty
                    || _compGainLossPrice.Dirty
                    || _compGainLossTotalBuyPrice.Dirty
                    || _compGainLossTotalCompPrice.Dirty
                    || _compInvestorAddress.Dirty
                    || _compInvestorCity.Dirty
                    || _compInvestorCommitment.Dirty
                    || _compInvestorContact.Dirty
                    || _compInvestorEmail.Dirty
                    || _compInvestorLockType.Dirty
                    || _compInvestorName.Dirty
                    || _compInvestorPhone.Dirty
                    || _compInvestorPostalCode.Dirty
                    || _compInvestorProgramCode.Dirty
                    || _compInvestorState.Dirty
                    || _compInvestorTemplateName.Dirty
                    || _compInvestorWebsite.Dirty
                    || _compSideComments.Dirty
                    || _compSideComparisonedBy.Dirty
                    || _compSideCurrentRateSetDate.Dirty
                    || _compSideDaystoExtend.Dirty
                    || _compSideDiscountYSP.Dirty
                    || _compSideExtendedLockExpires.Dirty
                    || _compSideInvestorStatus.Dirty
                    || _compSideInvestorStatusDate.Dirty
                    || _compSideInvestorTradeNumber.Dirty
                    || _compSideLoanProgram.Dirty
                    || _compSideLockDate.Dirty
                    || _compSideLockExpires.Dirty
                    || _compSideLockExtendPriceAdjustment.Dirty
                    || _compSideMarginNetCompRate.Dirty
                    || _compSideMarginRate.Dirty
                    || _compSideMarginTotalAdjustment.Dirty
                    || _compSideMasterContractNumber.Dirty
                    || _compSideNetCompPrice.Dirty
                    || _compSideNetCompRate.Dirty
                    || _compSideNumberOfDays.Dirty
                    || _compSideOriginalLockExpires.Dirty
                    || _compSidePriceRate.Dirty
                    || _compSidePriceTotalAdjustment.Dirty
                    || _compSideRate.Dirty
                    || _compSideRateSheetID.Dirty
                    || _compSideRateTotalAdjustment.Dirty
                    || _compSideRequestedBy.Dirty
                    || _compSideServicingType.Dirty
                    || _compSideSRPPaidOut.Dirty
                    || _compSideTradeGuid.Dirty
                    || _compSideTradeNumber.Dirty
                    || _confirmedBy.Dirty
                    || _confirmedDate.Dirty
                    || _corporateApprovalDate.Dirty
                    || _corporateApprovedby.Dirty
                    || _corporatePrice.Dirty
                    || _correspondentAdditionalEscrowAdditionalEscrow.Dirty
                    || _correspondentAdditionalEscrowAmount1007.Dirty
                    || _correspondentAdditionalEscrowAmount1008.Dirty
                    || _correspondentAdditionalEscrowAmount1009.Dirty
                    || _correspondentAdditionalEscrowCityPropertyTax.Dirty
                    || _correspondentAdditionalEscrowDescription1007.Dirty
                    || _correspondentAdditionalEscrowDescription1008.Dirty
                    || _correspondentAdditionalEscrowDescription1009.Dirty
                    || _correspondentAdditionalEscrowFloodInsurance.Dirty
                    || _correspondentAdditionalEscrowHomeInsurance.Dirty
                    || _correspondentAdditionalEscrowMIMIP.Dirty
                    || _correspondentAdditionalEscrowNumOfPayments.Dirty
                    || _correspondentAdditionalEscrowOption1Amount.Dirty
                    || _correspondentAdditionalEscrowOption1Desc.Dirty
                    || _correspondentAdditionalEscrowOption2Amount.Dirty
                    || _correspondentAdditionalEscrowOption2Desc.Dirty
                    || _correspondentAdditionalEscrowPropertyTax.Dirty
                    || _correspondentAdditionalEscrowSumOfPayments.Dirty
                    || _correspondentAdditionalEscrowUSDAAnnualFee.Dirty
                    || _correspondentAdditionalLineAmount1.Dirty
                    || _correspondentAdditionalLineAmount10.Dirty
                    || _correspondentAdditionalLineAmount11.Dirty
                    || _correspondentAdditionalLineAmount12.Dirty
                    || _correspondentAdditionalLineAmount13.Dirty
                    || _correspondentAdditionalLineAmount2.Dirty
                    || _correspondentAdditionalLineAmount3.Dirty
                    || _correspondentAdditionalLineAmount4.Dirty
                    || _correspondentAdditionalLineAmount5.Dirty
                    || _correspondentAdditionalLineAmount6.Dirty
                    || _correspondentAdditionalLineAmount7.Dirty
                    || _correspondentAdditionalLineAmount8.Dirty
                    || _correspondentAdditionalLineAmount9.Dirty
                    || _correspondentAdditionalLineDescription1.Dirty
                    || _correspondentAdditionalLineDescription10.Dirty
                    || _correspondentAdditionalLineDescription11.Dirty
                    || _correspondentAdditionalLineDescription12.Dirty
                    || _correspondentAdditionalLineDescription2.Dirty
                    || _correspondentAdditionalLineDescription3.Dirty
                    || _correspondentAdditionalLineDescription4.Dirty
                    || _correspondentAdditionalLineDescription5.Dirty
                    || _correspondentAdditionalLineDescription6.Dirty
                    || _correspondentAdditionalLineDescription7.Dirty
                    || _correspondentAdditionalLineDescription8.Dirty
                    || _correspondentAdditionalLineDescription9.Dirty
                    || _correspondentAdditionalLineTotalAmount.Dirty
                    || _correspondentAdjusterAmount1.Dirty
                    || _correspondentAdjusterAmount2.Dirty
                    || _correspondentAdjusterAmount3.Dirty
                    || _correspondentAdjusterDescription1.Dirty
                    || _correspondentAdjusterDescription2.Dirty
                    || _correspondentAdjusterDescription3.Dirty
                    || _correspondentConfirmedBy.Dirty
                    || _correspondentConfirmedDate.Dirty
                    || _correspondentCurrentImpounds.Dirty
                    || _correspondentCurrentPrincipal.Dirty
                    || _correspondentDate.Dirty
                    || _correspondentEscrowDisbursementsAmount1007.Dirty
                    || _correspondentEscrowDisbursementsAmount1008.Dirty
                    || _correspondentEscrowDisbursementsAmount1009.Dirty
                    || _correspondentEscrowDisbursementsCityPropertyTax.Dirty
                    || _correspondentEscrowDisbursementsDescription1007.Dirty
                    || _correspondentEscrowDisbursementsDescription1008.Dirty
                    || _correspondentEscrowDisbursementsDescription1009.Dirty
                    || _correspondentEscrowDisbursementsEscrowsToBePaidBySeller.Dirty
                    || _correspondentEscrowDisbursementsEsrowFundedByInvestor.Dirty
                    || _correspondentEscrowDisbursementsFloodInsurance.Dirty
                    || _correspondentEscrowDisbursementsHomeInsurance.Dirty
                    || _correspondentEscrowDisbursementsMortgageInsurance.Dirty
                    || _correspondentEscrowDisbursementsOption1Amount.Dirty
                    || _correspondentEscrowDisbursementsOption1Desc.Dirty
                    || _correspondentEscrowDisbursementsOption2Amount.Dirty
                    || _correspondentEscrowDisbursementsOption2Desc.Dirty
                    || _correspondentEscrowDisbursementsPropertyTax.Dirty
                    || _correspondentEscrowDisbursementsUSDAAnnualFee.Dirty
                    || _correspondentFinalBuyAmount.Dirty
                    || _correspondentFinalBuyPrice.Dirty
                    || _correspondentFinalCDAggAdjAmount.Dirty
                    || _correspondentFinalCDAmount1007.Dirty
                    || _correspondentFinalCDAmount1008.Dirty
                    || _correspondentFinalCDAmount1009.Dirty
                    || _correspondentFinalCDCityPropertyTax.Dirty
                    || _correspondentFinalCDDescription1007.Dirty
                    || _correspondentFinalCDDescription1008.Dirty
                    || _correspondentFinalCDDescription1009.Dirty
                    || _correspondentFinalCDFloodInsurance.Dirty
                    || _correspondentFinalCDHomeInsurance.Dirty
                    || _correspondentFinalCDMortgageInsurance.Dirty
                    || _correspondentFinalCDOption1Amount.Dirty
                    || _correspondentFinalCDOption1Desc.Dirty
                    || _correspondentFinalCDOption2Amount.Dirty
                    || _correspondentFinalCDOption2Desc.Dirty
                    || _correspondentFinalCDPropertyTax.Dirty
                    || _correspondentFinalCDReservesCollectedAtClosing.Dirty
                    || _correspondentFinalCDUSDAAnnualFee.Dirty
                    || _correspondentFirstPaymentDate.Dirty
                    || _correspondentImpounds.Dirty
                    || _correspondentInterest.Dirty
                    || _correspondentInterestDays.Dirty
                    || _correspondentLateFeeAmount.Dirty
                    || _correspondentLateFeePriceAdjustment.Dirty
                    || _correspondentPaidToDate.Dirty
                    || _correspondentPaymentHistoryAnticipatedPurchaseDate.Dirty
                    || _correspondentPaymentHistoryCalculatedPurchasedPrincipal.Dirty
                    || _correspondentPaymentHistoryFirstBorrowerPaymentDueDate.Dirty
                    || _correspondentPaymentHistoryFirstInvestorPaymentDate.Dirty
                    || _correspondentPaymentHistoryNoteDate.Dirty
                    || _correspondentPaymentHistoryPricipalReduction.Dirty
                    || _correspondentPurchasedPrincipal.Dirty
                    || _correspondentReconcilationComments.Dirty
                    || _correspondentRemainingBuydownAmount.Dirty
                    || _correspondentSRPAmount.Dirty
                    || _correspondentTotalBuyAmount.Dirty
                    || _correspondentTotalFees.Dirty
                    || _correspondentWarehouseBankABANum.Dirty
                    || _correspondentWarehouseBankAcctName.Dirty
                    || _correspondentWarehouseBankAcctNum.Dirty
                    || _correspondentWarehouseBankAddress.Dirty
                    || _correspondentWarehouseBankAddress1.Dirty
                    || _correspondentWarehouseBankBaileeExpirationDate.Dirty
                    || _correspondentWarehouseBankBaileeLetterReceivedIndicator.Dirty
                    || _correspondentWarehouseBankBaileeLetterReqIndicator.Dirty
                    || _correspondentWarehouseBankCity.Dirty
                    || _correspondentWarehouseBankContactEmail.Dirty
                    || _correspondentWarehouseBankContactFax.Dirty
                    || _correspondentWarehouseBankContactName.Dirty
                    || _correspondentWarehouseBankContactPhone.Dirty
                    || _correspondentWarehouseBankDescription.Dirty
                    || _correspondentWarehouseBankFurtherCreditAcctName.Dirty
                    || _correspondentWarehouseBankFurtherCreditAcctNum.Dirty
                    || _correspondentWarehouseBankId.Dirty
                    || _correspondentWarehouseBankName.Dirty
                    || _correspondentWarehouseBankNotes.Dirty
                    || _correspondentWarehouseBankSelfFunderIndicator.Dirty
                    || _correspondentWarehouseBankState.Dirty
                    || _correspondentWarehouseBankTriPartyContractIndicator.Dirty
                    || _correspondentWarehouseBankUseDefaultContactIndicator.Dirty
                    || _correspondentWarehouseBankWireConfirmationNumber.Dirty
                    || _correspondentWarehouseBankWireInstructionsReceivedIndicator.Dirty
                    || _correspondentWarehouseBankZip.Dirty
                    || _creditScoreToUse.Dirty
                    || _cumulatedDaystoExtend.Dirty
                    || _currentComments.Dirty
                    || _currentLockDate.Dirty
                    || _currentLockExpires.Dirty
                    || _currentMarginRate.Dirty
                    || _currentMarginRateRequested.Dirty
                    || _currentMarginTotalAdjustment.Dirty
                    || _currentNumberOfDays.Dirty
                    || _currentPriceRate.Dirty
                    || _currentPriceRateRequested.Dirty
                    || _currentPriceTotalAdjustment.Dirty
                    || _currentRate.Dirty
                    || _currentRateRequested.Dirty
                    || _currentRateSetDate.Dirty
                    || _currentRateSheetID.Dirty
                    || _currentRateTotalAdjustment.Dirty
                    || _date.Dirty
                    || _dateFirstPaymentToInvestor.Dirty
                    || _dateLockedWithInvestor.Dirty
                    || _dateSold.Dirty
                    || _dateWarehoused.Dirty
                    || _daysToExtend.Dirty
                    || _deliveryType.Dirty
                    || _diffAmountReceived.Dirty
                    || _diffImpounds.Dirty
                    || _diffInterest.Dirty
                    || _diffPremium.Dirty
                    || _diffPrinciple.Dirty
                    || _diffRemainingBuydownFunds.Dirty
                    || _diffSellAmount.Dirty
                    || _diffSellPrice.Dirty
                    || _diffSellSideSRP.Dirty
                    || _diffSRP.Dirty
                    || _diffSRPAmount.Dirty
                    || _employmentBorrowerSelfEmployedIndicator1.Dirty
                    || _employmentBorrowerSelfEmployedIndicator10.Dirty
                    || _employmentBorrowerSelfEmployedIndicator11.Dirty
                    || _employmentBorrowerSelfEmployedIndicator12.Dirty
                    || _employmentBorrowerSelfEmployedIndicator2.Dirty
                    || _employmentBorrowerSelfEmployedIndicator3.Dirty
                    || _employmentBorrowerSelfEmployedIndicator4.Dirty
                    || _employmentBorrowerSelfEmployedIndicator5.Dirty
                    || _employmentBorrowerSelfEmployedIndicator6.Dirty
                    || _employmentBorrowerSelfEmployedIndicator7.Dirty
                    || _employmentBorrowerSelfEmployedIndicator8.Dirty
                    || _employmentBorrowerSelfEmployedIndicator9.Dirty
                    || _expectedAmountReceived.Dirty
                    || _expectedImpounds.Dirty
                    || _expectedInterest.Dirty
                    || _expectedPremium.Dirty
                    || _expectedPrinciple.Dirty
                    || _expectedRemainingBuydownFunds.Dirty
                    || _expectedSRP.Dirty
                    || _extensionRequestPending.Dirty
                    || _extensionSequenceNumber.Dirty
                    || _fHAUpfrontMIPremiumPercent.Dirty
                    || _financedNumberOfUnits.Dirty
                    || _firstPaymenTo.Dirty
                    || _firstSubordinateAmount.Dirty
                    || _firstTimeHomebuyersIndicator.Dirty
                    || _fNMProductPlanIdentifier.Dirty
                    || _fundingAmount.Dirty
                    || _gainLossPercentage.Dirty
                    || _gainLossPrice.Dirty
                    || _gainLossTotalBuyPrice.Dirty
                    || _gPMRate.Dirty
                    || _gPMYears.Dirty
                    || _gSEPropertyType.Dirty
                    || _hedging.Dirty
                    || _hELOCActualBalance.Dirty
                    || _id.Dirty
                    || _impounds.Dirty
                    || _impoundType.Dirty
                    || _impoundWavied.Dirty
                    || _interest.Dirty
                    || _investorAddress.Dirty
                    || _investorCity.Dirty
                    || _investorCommitment.Dirty
                    || _investorContact.Dirty
                    || _investorDeliveryDate.Dirty
                    || _investorEmail.Dirty
                    || _investorLoanNumber.Dirty
                    || _investorLockType.Dirty
                    || _investorMERSNumber.Dirty
                    || _investorName.Dirty
                    || _investorPhone.Dirty
                    || _investorPostalCode.Dirty
                    || _investorProgramCode.Dirty
                    || _investorState.Dirty
                    || _investorTargetDeliveryDate.Dirty
                    || _investorTemplateName.Dirty
                    || _investorWebsite.Dirty
                    || _isCancelled.Dirty
                    || _isDeliveryType.Dirty
                    || _lenderPaidMortgageInsuranceIndicator.Dirty
                    || _lienPriorityType.Dirty
                    || _loanAmortizationTermMonths.Dirty
                    || _loanAmortizationType.Dirty
                    || _loanDocumentationType.Dirty
                    || _loanFor203K.Dirty
                    || _loanProgram.Dirty
                    || _loanProgramFile.Dirty
                    || _loanScheduledClosingDate.Dirty
                    || _lockField.Dirty
                    || _lockRequestLoanPurposeType.Dirty
                    || _lTV.Dirty
                    || _minFICO.Dirty
                    || _minFICO2.Dirty
                    || _mIPPaidInCash.Dirty
                    || _mortgageType.Dirty
                    || _netSellAmount.Dirty
                    || _netSellPrice.Dirty
                    || _nextPaymentDate.Dirty
                    || _noClosingCostOption.Dirty
                    || _oNRPLock.Dirty
                    || _otherAmortizationTypeDescription.Dirty
                    || _otherSubordinateAmount.Dirty
                    || _penaltyTerm.Dirty
                    || _perDiemInterestRoundingType.Dirty
                    || _planCode.Dirty
                    || _premium.Dirty
                    || _prepayPenalty.Dirty
                    || _priceAdjustment.Dirty
                    || _pricingHistoryData.Dirty
                    || _pricingUpdated.Dirty
                    || _principle.Dirty
                    || _profitMarginAdjustedBuyPrice.Dirty
                    || _propertyAppraisedValueAmount.Dirty
                    || _propertyEstimatedValueAmount.Dirty
                    || _propertyUsageType.Dirty
                    || _purchaseAdviceNumberOfDays.Dirty
                    || _purchasePriceAmount.Dirty
                    || _rateRequestStatus.Dirty
                    || _rateStatus.Dirty
                    || _reasonforBranchApproval.Dirty
                    || _reasonforCorporateApproval.Dirty
                    || _reconciledDiff.Dirty
                    || _reLockRequestPending.Dirty
                    || _remainingBuydownFunds.Dirty
                    || _requestComments.Dirty
                    || _requestCurrentRateSetDate.Dirty
                    || _requestDaystoExtend.Dirty
                    || _requestExtendedLockExpires.Dirty
                    || _requestFullfilledDateTime.Dirty
                    || _requestImpoundType.Dirty
                    || _requestImpoundWavied.Dirty
                    || _requestLockCancellationComment.Dirty
                    || _requestLockCancellationDate.Dirty
                    || _requestLockDate.Dirty
                    || _requestLockExpires.Dirty
                    || _requestLockExtendComment.Dirty
                    || _requestLockExtendPriceAdjustment.Dirty
                    || _requestLockStatus.Dirty
                    || _requestLockType.Dirty
                    || _requestMarginRate.Dirty
                    || _requestMarginRateRequested.Dirty
                    || _requestMarginSRPPaidOut.Dirty
                    || _requestMarginTotalAdjustment.Dirty
                    || _requestNumberOfDays.Dirty
                    || _requestOnrpEligible.Dirty
                    || _requestOnrpLockDate.Dirty
                    || _requestOnrpLockTime.Dirty
                    || _requestOriginalLockExpires.Dirty
                    || _requestPenaltyTerm.Dirty
                    || _requestPending.Dirty
                    || _requestPrepayPenalty.Dirty
                    || _requestPriceRate.Dirty
                    || _requestPriceRateRequested.Dirty
                    || _requestPriceTotalAdjustment.Dirty
                    || _requestRate.Dirty
                    || _requestRateRequested.Dirty
                    || _requestRateSheetID.Dirty
                    || _requestRateTotalAdjustment.Dirty
                    || _requestStartingAdjPoint.Dirty
                    || _requestStartingAdjRate.Dirty
                    || _requestType.Dirty
                    || _requestUnDiscountedRate.Dirty
                    || _roundToNearest50.Dirty
                    || _secondSubordinateAmount.Dirty
                    || _sellerPaidMIPremium.Dirty
                    || _sellSideComments.Dirty
                    || _sellSideCommitmentContractNumber.Dirty
                    || _sellSideCommitmentDate.Dirty
                    || _sellSideCurrentRateSetDate.Dirty
                    || _sellSideDaystoExtend.Dirty
                    || _sellSideDiscountYSP.Dirty
                    || _sellSideExtendedLockExpires.Dirty
                    || _sellSideGuaranteeFee.Dirty
                    || _sellSideGuarantyBaseFee.Dirty
                    || _sellSideInvestorStatus.Dirty
                    || _sellSideInvestorStatusDate.Dirty
                    || _sellSideInvestorTradeNumber.Dirty
                    || _sellSideLoanProgram.Dirty
                    || _sellSideLockDate.Dirty
                    || _sellSideLockExpires.Dirty
                    || _sellSideLockExtendPriceAdjustment.Dirty
                    || _sellSideMarginNetSellRate.Dirty
                    || _sellSideMarginRate.Dirty
                    || _sellSideMarginTotalAdjustment.Dirty
                    || _sellSideMasterContractNumber.Dirty
                    || _sellSideMSRValue.Dirty
                    || _sellSideNetSellPrice.Dirty
                    || _sellSideNetSellRate.Dirty
                    || _sellSideNumberOfDays.Dirty
                    || _sellSideOriginalLockExpires.Dirty
                    || _sellSidePoolID.Dirty
                    || _sellSidePoolNumber.Dirty
                    || _sellSidePriceRate.Dirty
                    || _sellSidePriceTotalAdjustment.Dirty
                    || _sellSideProductName.Dirty
                    || _sellSideRate.Dirty
                    || _sellSideRateSheetID.Dirty
                    || _sellSideRateTotalAdjustment.Dirty
                    || _sellSideRequestedBy.Dirty
                    || _sellSideServicer.Dirty
                    || _sellSideServicingFee.Dirty
                    || _sellSideServicingType.Dirty
                    || _sellSideSRP.Dirty
                    || _sellSideSRPPaidOut.Dirty
                    || _sellSideTradeGuid.Dirty
                    || _sellSideTradeMgmtPrevConfirmedLockGuid.Dirty
                    || _sellSideTradeNumber.Dirty
                    || _servicingReleaseIndicator.Dirty
                    || _sRP.Dirty
                    || _sRPAmount.Dirty
                    || _sRPPaidOut.Dirty
                    || _subjectPropertyCity.Dirty
                    || _subjectPropertyCondotelIndicator.Dirty
                    || _subjectPropertyCounty.Dirty
                    || _subjectPropertyNonWarrantableProjectIndicator.Dirty
                    || _subjectPropertyPostalCode.Dirty
                    || _subjectPropertyState.Dirty
                    || _subjectPropertyStreetAddress.Dirty
                    || _timeLockedWithInvestor.Dirty
                    || _totalBuyPrice.Dirty
                    || _totalForLesserOfSumAsIs.Dirty
                    || _totalPrice.Dirty
                    || _totalSubordinateFinancing.Dirty
                    || _twelveMonthMortgageRentalHistoryIndicator.Dirty
                    || _type.Dirty
                    || _usePoint.Dirty
                    || _buySideAdjustments?.Dirty == true
                    || _compSideAdjustments?.Dirty == true
                    || _currentAdjustments?.Dirty == true
                    || _extraPayments?.Dirty == true
                    || _lockRequestAdjustments?.Dirty == true
                    || _lockRequestBorrowers?.Dirty == true
                    || _priceAdjustments?.Dirty == true
                    || _purchaseAdvicePayouts?.Dirty == true
                    || _sellSideAdjustments?.Dirty == true;
            }
            set
            {
                _actualSellAmount.Dirty = value;
                _actualSellPrice.Dirty = value;
                _actualSellSideSRP.Dirty = value;
                _actualSRPAmount.Dirty = value;
                _amountDue.Dirty = value;
                _amountDueTo.Dirty = value;
                _amountPaid.Dirty = value;
                _amountPaidTo.Dirty = value;
                _amountReceived.Dirty = value;
                _balloonLoanMaturityTermMonths.Dirty = value;
                _baseLoanAmount.Dirty = value;
                _borrowerRequestedLoanAmount.Dirty = value;
                _branchApprovalDate.Dirty = value;
                _branchApprovedby.Dirty = value;
                _branchPrice.Dirty = value;
                _buySideComments.Dirty = value;
                _buySideCommitmentDate.Dirty = value;
                _buySideCommitmentNumber.Dirty = value;
                _buySideCommitmentType.Dirty = value;
                _buySideCurrentRateSetDate.Dirty = value;
                _buySideDaystoExtend.Dirty = value;
                _buySideDeliveryExpirationDate.Dirty = value;
                _buySideDeliveryType.Dirty = value;
                _buySideExpirationDate.Dirty = value;
                _buySideExtendedLockExpires.Dirty = value;
                _buySideLockDate.Dirty = value;
                _buySideLockExpires.Dirty = value;
                _buySideLockExtendPriceAdjustment.Dirty = value;
                _buySideMarginNetBuyRate.Dirty = value;
                _buySideMarginRate.Dirty = value;
                _buySideMarginTotalAdjustment.Dirty = value;
                _buySideMasterCommitmentNumber.Dirty = value;
                _buySideNumberOfDays.Dirty = value;
                _buySideOnrpEligible.Dirty = value;
                _buySideOnrpLockDate.Dirty = value;
                _buySideOnrpLockTime.Dirty = value;
                _buySideOrgID.Dirty = value;
                _buySideOriginalLockExpires.Dirty = value;
                _buySidePriceNetBuyPrice.Dirty = value;
                _buySidePriceRate.Dirty = value;
                _buySidePriceTotalAdjustment.Dirty = value;
                _buySideRate.Dirty = value;
                _buySideRateNetBuyRate.Dirty = value;
                _buySideRateSheetID.Dirty = value;
                _buySideRateTotalAdjustment.Dirty = value;
                _buySideRequestedBy.Dirty = value;
                _buySideSRPPaidOut.Dirty = value;
                _buySideStartingAdjPoint.Dirty = value;
                _buySideStartingAdjPrice.Dirty = value;
                _buySideStartingAdjRate.Dirty = value;
                _buySideTPOID.Dirty = value;
                _buySideTPOName.Dirty = value;
                _buySideTradeGuid.Dirty = value;
                _buySideTradeNumber.Dirty = value;
                _buySideUnDiscountedRate.Dirty = value;
                _cancellationRequestPending.Dirty = value;
                _combinedLTV.Dirty = value;
                _comments.Dirty = value;
                _commitment.Dirty = value;
                _commitmentType.Dirty = value;
                _compGainLossPercentage.Dirty = value;
                _compGainLossPrice.Dirty = value;
                _compGainLossTotalBuyPrice.Dirty = value;
                _compGainLossTotalCompPrice.Dirty = value;
                _compInvestorAddress.Dirty = value;
                _compInvestorCity.Dirty = value;
                _compInvestorCommitment.Dirty = value;
                _compInvestorContact.Dirty = value;
                _compInvestorEmail.Dirty = value;
                _compInvestorLockType.Dirty = value;
                _compInvestorName.Dirty = value;
                _compInvestorPhone.Dirty = value;
                _compInvestorPostalCode.Dirty = value;
                _compInvestorProgramCode.Dirty = value;
                _compInvestorState.Dirty = value;
                _compInvestorTemplateName.Dirty = value;
                _compInvestorWebsite.Dirty = value;
                _compSideComments.Dirty = value;
                _compSideComparisonedBy.Dirty = value;
                _compSideCurrentRateSetDate.Dirty = value;
                _compSideDaystoExtend.Dirty = value;
                _compSideDiscountYSP.Dirty = value;
                _compSideExtendedLockExpires.Dirty = value;
                _compSideInvestorStatus.Dirty = value;
                _compSideInvestorStatusDate.Dirty = value;
                _compSideInvestorTradeNumber.Dirty = value;
                _compSideLoanProgram.Dirty = value;
                _compSideLockDate.Dirty = value;
                _compSideLockExpires.Dirty = value;
                _compSideLockExtendPriceAdjustment.Dirty = value;
                _compSideMarginNetCompRate.Dirty = value;
                _compSideMarginRate.Dirty = value;
                _compSideMarginTotalAdjustment.Dirty = value;
                _compSideMasterContractNumber.Dirty = value;
                _compSideNetCompPrice.Dirty = value;
                _compSideNetCompRate.Dirty = value;
                _compSideNumberOfDays.Dirty = value;
                _compSideOriginalLockExpires.Dirty = value;
                _compSidePriceRate.Dirty = value;
                _compSidePriceTotalAdjustment.Dirty = value;
                _compSideRate.Dirty = value;
                _compSideRateSheetID.Dirty = value;
                _compSideRateTotalAdjustment.Dirty = value;
                _compSideRequestedBy.Dirty = value;
                _compSideServicingType.Dirty = value;
                _compSideSRPPaidOut.Dirty = value;
                _compSideTradeGuid.Dirty = value;
                _compSideTradeNumber.Dirty = value;
                _confirmedBy.Dirty = value;
                _confirmedDate.Dirty = value;
                _corporateApprovalDate.Dirty = value;
                _corporateApprovedby.Dirty = value;
                _corporatePrice.Dirty = value;
                _correspondentAdditionalEscrowAdditionalEscrow.Dirty = value;
                _correspondentAdditionalEscrowAmount1007.Dirty = value;
                _correspondentAdditionalEscrowAmount1008.Dirty = value;
                _correspondentAdditionalEscrowAmount1009.Dirty = value;
                _correspondentAdditionalEscrowCityPropertyTax.Dirty = value;
                _correspondentAdditionalEscrowDescription1007.Dirty = value;
                _correspondentAdditionalEscrowDescription1008.Dirty = value;
                _correspondentAdditionalEscrowDescription1009.Dirty = value;
                _correspondentAdditionalEscrowFloodInsurance.Dirty = value;
                _correspondentAdditionalEscrowHomeInsurance.Dirty = value;
                _correspondentAdditionalEscrowMIMIP.Dirty = value;
                _correspondentAdditionalEscrowNumOfPayments.Dirty = value;
                _correspondentAdditionalEscrowOption1Amount.Dirty = value;
                _correspondentAdditionalEscrowOption1Desc.Dirty = value;
                _correspondentAdditionalEscrowOption2Amount.Dirty = value;
                _correspondentAdditionalEscrowOption2Desc.Dirty = value;
                _correspondentAdditionalEscrowPropertyTax.Dirty = value;
                _correspondentAdditionalEscrowSumOfPayments.Dirty = value;
                _correspondentAdditionalEscrowUSDAAnnualFee.Dirty = value;
                _correspondentAdditionalLineAmount1.Dirty = value;
                _correspondentAdditionalLineAmount10.Dirty = value;
                _correspondentAdditionalLineAmount11.Dirty = value;
                _correspondentAdditionalLineAmount12.Dirty = value;
                _correspondentAdditionalLineAmount13.Dirty = value;
                _correspondentAdditionalLineAmount2.Dirty = value;
                _correspondentAdditionalLineAmount3.Dirty = value;
                _correspondentAdditionalLineAmount4.Dirty = value;
                _correspondentAdditionalLineAmount5.Dirty = value;
                _correspondentAdditionalLineAmount6.Dirty = value;
                _correspondentAdditionalLineAmount7.Dirty = value;
                _correspondentAdditionalLineAmount8.Dirty = value;
                _correspondentAdditionalLineAmount9.Dirty = value;
                _correspondentAdditionalLineDescription1.Dirty = value;
                _correspondentAdditionalLineDescription10.Dirty = value;
                _correspondentAdditionalLineDescription11.Dirty = value;
                _correspondentAdditionalLineDescription12.Dirty = value;
                _correspondentAdditionalLineDescription2.Dirty = value;
                _correspondentAdditionalLineDescription3.Dirty = value;
                _correspondentAdditionalLineDescription4.Dirty = value;
                _correspondentAdditionalLineDescription5.Dirty = value;
                _correspondentAdditionalLineDescription6.Dirty = value;
                _correspondentAdditionalLineDescription7.Dirty = value;
                _correspondentAdditionalLineDescription8.Dirty = value;
                _correspondentAdditionalLineDescription9.Dirty = value;
                _correspondentAdditionalLineTotalAmount.Dirty = value;
                _correspondentAdjusterAmount1.Dirty = value;
                _correspondentAdjusterAmount2.Dirty = value;
                _correspondentAdjusterAmount3.Dirty = value;
                _correspondentAdjusterDescription1.Dirty = value;
                _correspondentAdjusterDescription2.Dirty = value;
                _correspondentAdjusterDescription3.Dirty = value;
                _correspondentConfirmedBy.Dirty = value;
                _correspondentConfirmedDate.Dirty = value;
                _correspondentCurrentImpounds.Dirty = value;
                _correspondentCurrentPrincipal.Dirty = value;
                _correspondentDate.Dirty = value;
                _correspondentEscrowDisbursementsAmount1007.Dirty = value;
                _correspondentEscrowDisbursementsAmount1008.Dirty = value;
                _correspondentEscrowDisbursementsAmount1009.Dirty = value;
                _correspondentEscrowDisbursementsCityPropertyTax.Dirty = value;
                _correspondentEscrowDisbursementsDescription1007.Dirty = value;
                _correspondentEscrowDisbursementsDescription1008.Dirty = value;
                _correspondentEscrowDisbursementsDescription1009.Dirty = value;
                _correspondentEscrowDisbursementsEscrowsToBePaidBySeller.Dirty = value;
                _correspondentEscrowDisbursementsEsrowFundedByInvestor.Dirty = value;
                _correspondentEscrowDisbursementsFloodInsurance.Dirty = value;
                _correspondentEscrowDisbursementsHomeInsurance.Dirty = value;
                _correspondentEscrowDisbursementsMortgageInsurance.Dirty = value;
                _correspondentEscrowDisbursementsOption1Amount.Dirty = value;
                _correspondentEscrowDisbursementsOption1Desc.Dirty = value;
                _correspondentEscrowDisbursementsOption2Amount.Dirty = value;
                _correspondentEscrowDisbursementsOption2Desc.Dirty = value;
                _correspondentEscrowDisbursementsPropertyTax.Dirty = value;
                _correspondentEscrowDisbursementsUSDAAnnualFee.Dirty = value;
                _correspondentFinalBuyAmount.Dirty = value;
                _correspondentFinalBuyPrice.Dirty = value;
                _correspondentFinalCDAggAdjAmount.Dirty = value;
                _correspondentFinalCDAmount1007.Dirty = value;
                _correspondentFinalCDAmount1008.Dirty = value;
                _correspondentFinalCDAmount1009.Dirty = value;
                _correspondentFinalCDCityPropertyTax.Dirty = value;
                _correspondentFinalCDDescription1007.Dirty = value;
                _correspondentFinalCDDescription1008.Dirty = value;
                _correspondentFinalCDDescription1009.Dirty = value;
                _correspondentFinalCDFloodInsurance.Dirty = value;
                _correspondentFinalCDHomeInsurance.Dirty = value;
                _correspondentFinalCDMortgageInsurance.Dirty = value;
                _correspondentFinalCDOption1Amount.Dirty = value;
                _correspondentFinalCDOption1Desc.Dirty = value;
                _correspondentFinalCDOption2Amount.Dirty = value;
                _correspondentFinalCDOption2Desc.Dirty = value;
                _correspondentFinalCDPropertyTax.Dirty = value;
                _correspondentFinalCDReservesCollectedAtClosing.Dirty = value;
                _correspondentFinalCDUSDAAnnualFee.Dirty = value;
                _correspondentFirstPaymentDate.Dirty = value;
                _correspondentImpounds.Dirty = value;
                _correspondentInterest.Dirty = value;
                _correspondentInterestDays.Dirty = value;
                _correspondentLateFeeAmount.Dirty = value;
                _correspondentLateFeePriceAdjustment.Dirty = value;
                _correspondentPaidToDate.Dirty = value;
                _correspondentPaymentHistoryAnticipatedPurchaseDate.Dirty = value;
                _correspondentPaymentHistoryCalculatedPurchasedPrincipal.Dirty = value;
                _correspondentPaymentHistoryFirstBorrowerPaymentDueDate.Dirty = value;
                _correspondentPaymentHistoryFirstInvestorPaymentDate.Dirty = value;
                _correspondentPaymentHistoryNoteDate.Dirty = value;
                _correspondentPaymentHistoryPricipalReduction.Dirty = value;
                _correspondentPurchasedPrincipal.Dirty = value;
                _correspondentReconcilationComments.Dirty = value;
                _correspondentRemainingBuydownAmount.Dirty = value;
                _correspondentSRPAmount.Dirty = value;
                _correspondentTotalBuyAmount.Dirty = value;
                _correspondentTotalFees.Dirty = value;
                _correspondentWarehouseBankABANum.Dirty = value;
                _correspondentWarehouseBankAcctName.Dirty = value;
                _correspondentWarehouseBankAcctNum.Dirty = value;
                _correspondentWarehouseBankAddress.Dirty = value;
                _correspondentWarehouseBankAddress1.Dirty = value;
                _correspondentWarehouseBankBaileeExpirationDate.Dirty = value;
                _correspondentWarehouseBankBaileeLetterReceivedIndicator.Dirty = value;
                _correspondentWarehouseBankBaileeLetterReqIndicator.Dirty = value;
                _correspondentWarehouseBankCity.Dirty = value;
                _correspondentWarehouseBankContactEmail.Dirty = value;
                _correspondentWarehouseBankContactFax.Dirty = value;
                _correspondentWarehouseBankContactName.Dirty = value;
                _correspondentWarehouseBankContactPhone.Dirty = value;
                _correspondentWarehouseBankDescription.Dirty = value;
                _correspondentWarehouseBankFurtherCreditAcctName.Dirty = value;
                _correspondentWarehouseBankFurtherCreditAcctNum.Dirty = value;
                _correspondentWarehouseBankId.Dirty = value;
                _correspondentWarehouseBankName.Dirty = value;
                _correspondentWarehouseBankNotes.Dirty = value;
                _correspondentWarehouseBankSelfFunderIndicator.Dirty = value;
                _correspondentWarehouseBankState.Dirty = value;
                _correspondentWarehouseBankTriPartyContractIndicator.Dirty = value;
                _correspondentWarehouseBankUseDefaultContactIndicator.Dirty = value;
                _correspondentWarehouseBankWireConfirmationNumber.Dirty = value;
                _correspondentWarehouseBankWireInstructionsReceivedIndicator.Dirty = value;
                _correspondentWarehouseBankZip.Dirty = value;
                _creditScoreToUse.Dirty = value;
                _cumulatedDaystoExtend.Dirty = value;
                _currentComments.Dirty = value;
                _currentLockDate.Dirty = value;
                _currentLockExpires.Dirty = value;
                _currentMarginRate.Dirty = value;
                _currentMarginRateRequested.Dirty = value;
                _currentMarginTotalAdjustment.Dirty = value;
                _currentNumberOfDays.Dirty = value;
                _currentPriceRate.Dirty = value;
                _currentPriceRateRequested.Dirty = value;
                _currentPriceTotalAdjustment.Dirty = value;
                _currentRate.Dirty = value;
                _currentRateRequested.Dirty = value;
                _currentRateSetDate.Dirty = value;
                _currentRateSheetID.Dirty = value;
                _currentRateTotalAdjustment.Dirty = value;
                _date.Dirty = value;
                _dateFirstPaymentToInvestor.Dirty = value;
                _dateLockedWithInvestor.Dirty = value;
                _dateSold.Dirty = value;
                _dateWarehoused.Dirty = value;
                _daysToExtend.Dirty = value;
                _deliveryType.Dirty = value;
                _diffAmountReceived.Dirty = value;
                _diffImpounds.Dirty = value;
                _diffInterest.Dirty = value;
                _diffPremium.Dirty = value;
                _diffPrinciple.Dirty = value;
                _diffRemainingBuydownFunds.Dirty = value;
                _diffSellAmount.Dirty = value;
                _diffSellPrice.Dirty = value;
                _diffSellSideSRP.Dirty = value;
                _diffSRP.Dirty = value;
                _diffSRPAmount.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator1.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator10.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator11.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator12.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator2.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator3.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator4.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator5.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator6.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator7.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator8.Dirty = value;
                _employmentBorrowerSelfEmployedIndicator9.Dirty = value;
                _expectedAmountReceived.Dirty = value;
                _expectedImpounds.Dirty = value;
                _expectedInterest.Dirty = value;
                _expectedPremium.Dirty = value;
                _expectedPrinciple.Dirty = value;
                _expectedRemainingBuydownFunds.Dirty = value;
                _expectedSRP.Dirty = value;
                _extensionRequestPending.Dirty = value;
                _extensionSequenceNumber.Dirty = value;
                _fHAUpfrontMIPremiumPercent.Dirty = value;
                _financedNumberOfUnits.Dirty = value;
                _firstPaymenTo.Dirty = value;
                _firstSubordinateAmount.Dirty = value;
                _firstTimeHomebuyersIndicator.Dirty = value;
                _fNMProductPlanIdentifier.Dirty = value;
                _fundingAmount.Dirty = value;
                _gainLossPercentage.Dirty = value;
                _gainLossPrice.Dirty = value;
                _gainLossTotalBuyPrice.Dirty = value;
                _gPMRate.Dirty = value;
                _gPMYears.Dirty = value;
                _gSEPropertyType.Dirty = value;
                _hedging.Dirty = value;
                _hELOCActualBalance.Dirty = value;
                _id.Dirty = value;
                _impounds.Dirty = value;
                _impoundType.Dirty = value;
                _impoundWavied.Dirty = value;
                _interest.Dirty = value;
                _investorAddress.Dirty = value;
                _investorCity.Dirty = value;
                _investorCommitment.Dirty = value;
                _investorContact.Dirty = value;
                _investorDeliveryDate.Dirty = value;
                _investorEmail.Dirty = value;
                _investorLoanNumber.Dirty = value;
                _investorLockType.Dirty = value;
                _investorMERSNumber.Dirty = value;
                _investorName.Dirty = value;
                _investorPhone.Dirty = value;
                _investorPostalCode.Dirty = value;
                _investorProgramCode.Dirty = value;
                _investorState.Dirty = value;
                _investorTargetDeliveryDate.Dirty = value;
                _investorTemplateName.Dirty = value;
                _investorWebsite.Dirty = value;
                _isCancelled.Dirty = value;
                _isDeliveryType.Dirty = value;
                _lenderPaidMortgageInsuranceIndicator.Dirty = value;
                _lienPriorityType.Dirty = value;
                _loanAmortizationTermMonths.Dirty = value;
                _loanAmortizationType.Dirty = value;
                _loanDocumentationType.Dirty = value;
                _loanFor203K.Dirty = value;
                _loanProgram.Dirty = value;
                _loanProgramFile.Dirty = value;
                _loanScheduledClosingDate.Dirty = value;
                _lockField.Dirty = value;
                _lockRequestLoanPurposeType.Dirty = value;
                _lTV.Dirty = value;
                _minFICO.Dirty = value;
                _minFICO2.Dirty = value;
                _mIPPaidInCash.Dirty = value;
                _mortgageType.Dirty = value;
                _netSellAmount.Dirty = value;
                _netSellPrice.Dirty = value;
                _nextPaymentDate.Dirty = value;
                _noClosingCostOption.Dirty = value;
                _oNRPLock.Dirty = value;
                _otherAmortizationTypeDescription.Dirty = value;
                _otherSubordinateAmount.Dirty = value;
                _penaltyTerm.Dirty = value;
                _perDiemInterestRoundingType.Dirty = value;
                _planCode.Dirty = value;
                _premium.Dirty = value;
                _prepayPenalty.Dirty = value;
                _priceAdjustment.Dirty = value;
                _pricingHistoryData.Dirty = value;
                _pricingUpdated.Dirty = value;
                _principle.Dirty = value;
                _profitMarginAdjustedBuyPrice.Dirty = value;
                _propertyAppraisedValueAmount.Dirty = value;
                _propertyEstimatedValueAmount.Dirty = value;
                _propertyUsageType.Dirty = value;
                _purchaseAdviceNumberOfDays.Dirty = value;
                _purchasePriceAmount.Dirty = value;
                _rateRequestStatus.Dirty = value;
                _rateStatus.Dirty = value;
                _reasonforBranchApproval.Dirty = value;
                _reasonforCorporateApproval.Dirty = value;
                _reconciledDiff.Dirty = value;
                _reLockRequestPending.Dirty = value;
                _remainingBuydownFunds.Dirty = value;
                _requestComments.Dirty = value;
                _requestCurrentRateSetDate.Dirty = value;
                _requestDaystoExtend.Dirty = value;
                _requestExtendedLockExpires.Dirty = value;
                _requestFullfilledDateTime.Dirty = value;
                _requestImpoundType.Dirty = value;
                _requestImpoundWavied.Dirty = value;
                _requestLockCancellationComment.Dirty = value;
                _requestLockCancellationDate.Dirty = value;
                _requestLockDate.Dirty = value;
                _requestLockExpires.Dirty = value;
                _requestLockExtendComment.Dirty = value;
                _requestLockExtendPriceAdjustment.Dirty = value;
                _requestLockStatus.Dirty = value;
                _requestLockType.Dirty = value;
                _requestMarginRate.Dirty = value;
                _requestMarginRateRequested.Dirty = value;
                _requestMarginSRPPaidOut.Dirty = value;
                _requestMarginTotalAdjustment.Dirty = value;
                _requestNumberOfDays.Dirty = value;
                _requestOnrpEligible.Dirty = value;
                _requestOnrpLockDate.Dirty = value;
                _requestOnrpLockTime.Dirty = value;
                _requestOriginalLockExpires.Dirty = value;
                _requestPenaltyTerm.Dirty = value;
                _requestPending.Dirty = value;
                _requestPrepayPenalty.Dirty = value;
                _requestPriceRate.Dirty = value;
                _requestPriceRateRequested.Dirty = value;
                _requestPriceTotalAdjustment.Dirty = value;
                _requestRate.Dirty = value;
                _requestRateRequested.Dirty = value;
                _requestRateSheetID.Dirty = value;
                _requestRateTotalAdjustment.Dirty = value;
                _requestStartingAdjPoint.Dirty = value;
                _requestStartingAdjRate.Dirty = value;
                _requestType.Dirty = value;
                _requestUnDiscountedRate.Dirty = value;
                _roundToNearest50.Dirty = value;
                _secondSubordinateAmount.Dirty = value;
                _sellerPaidMIPremium.Dirty = value;
                _sellSideComments.Dirty = value;
                _sellSideCommitmentContractNumber.Dirty = value;
                _sellSideCommitmentDate.Dirty = value;
                _sellSideCurrentRateSetDate.Dirty = value;
                _sellSideDaystoExtend.Dirty = value;
                _sellSideDiscountYSP.Dirty = value;
                _sellSideExtendedLockExpires.Dirty = value;
                _sellSideGuaranteeFee.Dirty = value;
                _sellSideGuarantyBaseFee.Dirty = value;
                _sellSideInvestorStatus.Dirty = value;
                _sellSideInvestorStatusDate.Dirty = value;
                _sellSideInvestorTradeNumber.Dirty = value;
                _sellSideLoanProgram.Dirty = value;
                _sellSideLockDate.Dirty = value;
                _sellSideLockExpires.Dirty = value;
                _sellSideLockExtendPriceAdjustment.Dirty = value;
                _sellSideMarginNetSellRate.Dirty = value;
                _sellSideMarginRate.Dirty = value;
                _sellSideMarginTotalAdjustment.Dirty = value;
                _sellSideMasterContractNumber.Dirty = value;
                _sellSideMSRValue.Dirty = value;
                _sellSideNetSellPrice.Dirty = value;
                _sellSideNetSellRate.Dirty = value;
                _sellSideNumberOfDays.Dirty = value;
                _sellSideOriginalLockExpires.Dirty = value;
                _sellSidePoolID.Dirty = value;
                _sellSidePoolNumber.Dirty = value;
                _sellSidePriceRate.Dirty = value;
                _sellSidePriceTotalAdjustment.Dirty = value;
                _sellSideProductName.Dirty = value;
                _sellSideRate.Dirty = value;
                _sellSideRateSheetID.Dirty = value;
                _sellSideRateTotalAdjustment.Dirty = value;
                _sellSideRequestedBy.Dirty = value;
                _sellSideServicer.Dirty = value;
                _sellSideServicingFee.Dirty = value;
                _sellSideServicingType.Dirty = value;
                _sellSideSRP.Dirty = value;
                _sellSideSRPPaidOut.Dirty = value;
                _sellSideTradeGuid.Dirty = value;
                _sellSideTradeMgmtPrevConfirmedLockGuid.Dirty = value;
                _sellSideTradeNumber.Dirty = value;
                _servicingReleaseIndicator.Dirty = value;
                _sRP.Dirty = value;
                _sRPAmount.Dirty = value;
                _sRPPaidOut.Dirty = value;
                _subjectPropertyCity.Dirty = value;
                _subjectPropertyCondotelIndicator.Dirty = value;
                _subjectPropertyCounty.Dirty = value;
                _subjectPropertyNonWarrantableProjectIndicator.Dirty = value;
                _subjectPropertyPostalCode.Dirty = value;
                _subjectPropertyState.Dirty = value;
                _subjectPropertyStreetAddress.Dirty = value;
                _timeLockedWithInvestor.Dirty = value;
                _totalBuyPrice.Dirty = value;
                _totalForLesserOfSumAsIs.Dirty = value;
                _totalPrice.Dirty = value;
                _totalSubordinateFinancing.Dirty = value;
                _twelveMonthMortgageRentalHistoryIndicator.Dirty = value;
                _type.Dirty = value;
                _usePoint.Dirty = value;
                if (_buySideAdjustments != null) _buySideAdjustments.Dirty = value;
                if (_compSideAdjustments != null) _compSideAdjustments.Dirty = value;
                if (_currentAdjustments != null) _currentAdjustments.Dirty = value;
                if (_extraPayments != null) _extraPayments.Dirty = value;
                if (_lockRequestAdjustments != null) _lockRequestAdjustments.Dirty = value;
                if (_lockRequestBorrowers != null) _lockRequestBorrowers.Dirty = value;
                if (_priceAdjustments != null) _priceAdjustments.Dirty = value;
                if (_purchaseAdvicePayouts != null) _purchaseAdvicePayouts.Dirty = value;
                if (_sellSideAdjustments != null) _sellSideAdjustments.Dirty = value;
            }
        }
    }
}