using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RateLock
    /// </summary>
    public sealed partial class RateLock : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualSellAmount;
        private DirtyValue<decimal?> _actualSellPrice;
        private DirtyValue<decimal?> _actualSellSideSRP;
        private DirtyValue<decimal?> _actualSRPAmount;
        private DirtyValue<decimal?> _amountDue;
        private DirtyValue<StringEnumValue<PartyType>> _amountDueTo;
        private DirtyValue<decimal?> _amountPaid;
        private DirtyValue<StringEnumValue<PartyType>> _amountPaidTo;
        private DirtyValue<decimal?> _amountReceived;
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        private DirtyValue<decimal?> _baseLoanAmount;
        private DirtyValue<string> _borrLenderPaid;
        private DirtyValue<decimal?> _borrowerRequestedLoanAmount;
        private DirtyValue<DateTime?> _branchApprovalDate;
        private DirtyValue<string> _branchApprovedby;
        private DirtyValue<decimal?> _branchPrice;
        private DirtyList<PriceAdjustment> _buySideAdjustments;
        private DirtyValue<string> _buySideComments;
        private DirtyValue<DateTime?> _buySideCommitmentDate;
        private DirtyValue<string> _buySideCommitmentNumber;
        private DirtyValue<string> _buySideCommitmentType;
        private DirtyValue<DateTime?> _buySideCurrentRateSetDate;
        private DirtyValue<int?> _buySideDaystoExtend;
        private DirtyValue<DateTime?> _buySideDeliveryExpirationDate;
        private DirtyValue<string> _buySideDeliveryType;
        private DirtyValue<DateTime?> _buySideExpirationDate;
        private DirtyValue<DateTime?> _buySideExtendedLockExpires;
        private DirtyValue<DateTime?> _buySideLockDate;
        private DirtyValue<DateTime?> _buySideLockExpires;
        private DirtyValue<decimal?> _buySideLockExtendPriceAdjustment;
        private DirtyValue<decimal?> _buySideMarginNetBuyRate;
        private DirtyValue<decimal?> _buySideMarginRate;
        private DirtyValue<decimal?> _buySideMarginTotalAdjustment;
        private DirtyValue<string> _buySideMasterCommitmentNumber;
        private DirtyValue<int?> _buySideNumberOfDays;
        private DirtyValue<bool?> _buySideOnrpEligible;
        private DirtyValue<DateTime?> _buySideOnrpLockDate;
        private DirtyValue<string> _buySideOnrpLockTime;
        private DirtyValue<string> _buySideOrgID;
        private DirtyValue<DateTime?> _buySideOriginalLockExpires;
        private DirtyValue<decimal?> _buySidePriceNetBuyPrice;
        private DirtyValue<decimal?> _buySidePriceRate;
        private DirtyValue<decimal?> _buySidePriceTotalAdjustment;
        private DirtyValue<decimal?> _buySideRate;
        private DirtyValue<decimal?> _buySideRateNetBuyRate;
        private DirtyValue<string> _buySideRateSheetID;
        private DirtyValue<decimal?> _buySideRateTotalAdjustment;
        private DirtyValue<string> _buySideRequestedBy;
        private DirtyValue<decimal?> _buySideSRPPaidOut;
        private DirtyValue<decimal?> _buySideStartingAdjPoint;
        private DirtyValue<decimal?> _buySideStartingAdjPrice;
        private DirtyValue<decimal?> _buySideStartingAdjRate;
        private DirtyValue<string> _buySideTPOID;
        private DirtyValue<string> _buySideTPOName;
        private DirtyValue<string> _buySideTradeGuid;
        private DirtyValue<string> _buySideTradeNumber;
        private DirtyValue<decimal?> _buySideUnDiscountedRate;
        private DirtyValue<string> _cancellationRequestPending;
        private DirtyValue<decimal?> _combinedLTV;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _commitment;
        private DirtyValue<string> _commitmentType;
        private DirtyValue<decimal?> _compGainLossPercentage;
        private DirtyValue<decimal?> _compGainLossPrice;
        private DirtyValue<decimal?> _compGainLossTotalBuyPrice;
        private DirtyValue<decimal?> _compGainLossTotalCompPrice;
        private DirtyValue<string> _compInvestorAddress;
        private DirtyValue<string> _compInvestorCity;
        private DirtyValue<string> _compInvestorCommitment;
        private DirtyValue<string> _compInvestorContact;
        private DirtyValue<string> _compInvestorEmail;
        private DirtyValue<string> _compInvestorLockType;
        private DirtyValue<string> _compInvestorName;
        private DirtyValue<string> _compInvestorPhone;
        private DirtyValue<string> _compInvestorPostalCode;
        private DirtyValue<string> _compInvestorProgramCode;
        private DirtyValue<StringEnumValue<State>> _compInvestorState;
        private DirtyValue<string> _compInvestorTemplateName;
        private DirtyValue<string> _compInvestorWebsite;
        private DirtyList<PriceAdjustment> _compSideAdjustments;
        private DirtyValue<string> _compSideComments;
        private DirtyValue<string> _compSideComparisonedBy;
        private DirtyValue<DateTime?> _compSideCurrentRateSetDate;
        private DirtyValue<int?> _compSideDaystoExtend;
        private DirtyValue<decimal?> _compSideDiscountYSP;
        private DirtyValue<DateTime?> _compSideExtendedLockExpires;
        private DirtyValue<string> _compSideInvestorStatus;
        private DirtyValue<DateTime?> _compSideInvestorStatusDate;
        private DirtyValue<string> _compSideInvestorTradeNumber;
        private DirtyValue<string> _compSideLoanProgram;
        private DirtyValue<DateTime?> _compSideLockDate;
        private DirtyValue<DateTime?> _compSideLockExpires;
        private DirtyValue<decimal?> _compSideLockExtendPriceAdjustment;
        private DirtyValue<decimal?> _compSideMarginNetCompRate;
        private DirtyValue<decimal?> _compSideMarginRate;
        private DirtyValue<decimal?> _compSideMarginTotalAdjustment;
        private DirtyValue<string> _compSideMasterContractNumber;
        private DirtyValue<decimal?> _compSideNetCompPrice;
        private DirtyValue<decimal?> _compSideNetCompRate;
        private DirtyValue<int?> _compSideNumberOfDays;
        private DirtyValue<DateTime?> _compSideOriginalLockExpires;
        private DirtyValue<decimal?> _compSidePriceRate;
        private DirtyValue<decimal?> _compSidePriceTotalAdjustment;
        private DirtyValue<decimal?> _compSideRate;
        private DirtyValue<string> _compSideRateSheetID;
        private DirtyValue<decimal?> _compSideRateTotalAdjustment;
        private DirtyValue<string> _compSideRequestedBy;
        private DirtyValue<StringEnumValue<ServicingType>> _compSideServicingType;
        private DirtyValue<decimal?> _compSideSRPPaidOut;
        private DirtyValue<string> _compSideTradeGuid;
        private DirtyValue<string> _compSideTradeNumber;
        private DirtyValue<string> _confirmedBy;
        private DirtyValue<DateTime?> _confirmedDate;
        private DirtyValue<DateTime?> _corporateApprovalDate;
        private DirtyValue<string> _corporateApprovedby;
        private DirtyValue<decimal?> _corporatePrice;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAdditionalEscrow;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1007;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1008;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowAmount1009;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowCityPropertyTax;
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1007;
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1008;
        private DirtyValue<string> _correspondentAdditionalEscrowDescription1009;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowFloodInsurance;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowHomeInsurance;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowMIMIP;
        private DirtyValue<int?> _correspondentAdditionalEscrowNumOfPayments;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption1Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption1Desc;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowOption2Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentAdditionalEscrowOption2Desc;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowPropertyTax;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowSumOfPayments;
        private DirtyValue<decimal?> _correspondentAdditionalEscrowUSDAAnnualFee;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount1;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount10;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount11;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount12;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount13;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount2;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount3;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount4;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount5;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount6;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount7;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount8;
        private DirtyValue<decimal?> _correspondentAdditionalLineAmount9;
        private DirtyValue<string> _correspondentAdditionalLineDescription1;
        private DirtyValue<string> _correspondentAdditionalLineDescription10;
        private DirtyValue<string> _correspondentAdditionalLineDescription11;
        private DirtyValue<string> _correspondentAdditionalLineDescription12;
        private DirtyValue<string> _correspondentAdditionalLineDescription2;
        private DirtyValue<string> _correspondentAdditionalLineDescription3;
        private DirtyValue<string> _correspondentAdditionalLineDescription4;
        private DirtyValue<string> _correspondentAdditionalLineDescription5;
        private DirtyValue<string> _correspondentAdditionalLineDescription6;
        private DirtyValue<string> _correspondentAdditionalLineDescription7;
        private DirtyValue<string> _correspondentAdditionalLineDescription8;
        private DirtyValue<string> _correspondentAdditionalLineDescription9;
        private DirtyValue<decimal?> _correspondentAdditionalLineTotalAmount;
        private DirtyValue<decimal?> _correspondentAdjusterAmount1;
        private DirtyValue<decimal?> _correspondentAdjusterAmount2;
        private DirtyValue<decimal?> _correspondentAdjusterAmount3;
        private DirtyValue<string> _correspondentAdjusterDescription1;
        private DirtyValue<string> _correspondentAdjusterDescription2;
        private DirtyValue<string> _correspondentAdjusterDescription3;
        private DirtyValue<string> _correspondentConfirmedBy;
        private DirtyValue<DateTime?> _correspondentConfirmedDate;
        private DirtyValue<decimal?> _correspondentCurrentImpounds;
        private DirtyValue<decimal?> _correspondentCurrentPrincipal;
        private DirtyValue<DateTime?> _correspondentDate;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1007;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1008;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsAmount1009;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsCityPropertyTax;
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1007;
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1008;
        private DirtyValue<string> _correspondentEscrowDisbursementsDescription1009;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEscrowsToBePaidBySeller;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsEsrowFundedByInvestor;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsFloodInsurance;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsHomeInsurance;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsMortgageInsurance;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption1Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption1Desc;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsOption2Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentEscrowDisbursementsOption2Desc;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsPropertyTax;
        private DirtyValue<decimal?> _correspondentEscrowDisbursementsUSDAAnnualFee;
        private DirtyValue<decimal?> _correspondentFinalBuyAmount;
        private DirtyValue<decimal?> _correspondentFinalBuyPrice;
        private DirtyValue<decimal?> _correspondentFinalCDAggAdjAmount;
        private DirtyValue<decimal?> _correspondentFinalCDAmount1007;
        private DirtyValue<decimal?> _correspondentFinalCDAmount1008;
        private DirtyValue<decimal?> _correspondentFinalCDAmount1009;
        private DirtyValue<decimal?> _correspondentFinalCDCityPropertyTax;
        private DirtyValue<string> _correspondentFinalCDDescription1007;
        private DirtyValue<string> _correspondentFinalCDDescription1008;
        private DirtyValue<string> _correspondentFinalCDDescription1009;
        private DirtyValue<decimal?> _correspondentFinalCDFloodInsurance;
        private DirtyValue<decimal?> _correspondentFinalCDHomeInsurance;
        private DirtyValue<decimal?> _correspondentFinalCDMortgageInsurance;
        private DirtyValue<decimal?> _correspondentFinalCDOption1Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption1Desc;
        private DirtyValue<decimal?> _correspondentFinalCDOption2Amount;
        private DirtyValue<StringEnumValue<CorrespondentOptionDesc>> _correspondentFinalCDOption2Desc;
        private DirtyValue<decimal?> _correspondentFinalCDPropertyTax;
        private DirtyValue<decimal?> _correspondentFinalCDReservesCollectedAtClosing;
        private DirtyValue<decimal?> _correspondentFinalCDUSDAAnnualFee;
        private DirtyValue<DateTime?> _correspondentFirstPaymentDate;
        private DirtyValue<decimal?> _correspondentImpounds;
        private DirtyValue<decimal?> _correspondentInterest;
        private DirtyValue<int?> _correspondentInterestDays;
        private DirtyValue<decimal?> _correspondentLateFeeAmount;
        private DirtyValue<decimal?> _correspondentLateFeePriceAdjustment;
        private DirtyValue<DateTime?> _correspondentPaidToDate;
        private DirtyValue<DateTime?> _correspondentPaymentHistoryAnticipatedPurchaseDate;
        private DirtyValue<decimal?> _correspondentPaymentHistoryCalculatedPurchasedPrincipal;
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstBorrowerPaymentDueDate;
        private DirtyValue<DateTime?> _correspondentPaymentHistoryFirstInvestorPaymentDate;
        private DirtyValue<DateTime?> _correspondentPaymentHistoryNoteDate;
        private DirtyValue<decimal?> _correspondentPaymentHistoryPricipalReduction;
        private DirtyValue<decimal?> _correspondentPurchasedPrincipal;
        private DirtyValue<string> _correspondentReconcilationComments;
        private DirtyValue<decimal?> _correspondentRemainingBuydownAmount;
        private DirtyValue<decimal?> _correspondentSRPAmount;
        private DirtyValue<decimal?> _correspondentTotalBuyAmount;
        private DirtyValue<decimal?> _correspondentTotalFees;
        private DirtyValue<string> _correspondentWarehouseBankABANum;
        private DirtyValue<string> _correspondentWarehouseBankAcctName;
        private DirtyValue<string> _correspondentWarehouseBankAcctNum;
        private DirtyValue<string> _correspondentWarehouseBankAddress;
        private DirtyValue<string> _correspondentWarehouseBankAddress1;
        private DirtyValue<DateTime?> _correspondentWarehouseBankBaileeExpirationDate;
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReceivedIndicator;
        private DirtyValue<bool?> _correspondentWarehouseBankBaileeLetterReqIndicator;
        private DirtyValue<string> _correspondentWarehouseBankCity;
        private DirtyValue<string> _correspondentWarehouseBankContactEmail;
        private DirtyValue<string> _correspondentWarehouseBankContactFax;
        private DirtyValue<string> _correspondentWarehouseBankContactName;
        private DirtyValue<string> _correspondentWarehouseBankContactPhone;
        private DirtyValue<string> _correspondentWarehouseBankDescription;
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctName;
        private DirtyValue<string> _correspondentWarehouseBankFurtherCreditAcctNum;
        private DirtyValue<int?> _correspondentWarehouseBankId;
        private DirtyValue<string> _correspondentWarehouseBankName;
        private DirtyValue<string> _correspondentWarehouseBankNotes;
        private DirtyValue<bool?> _correspondentWarehouseBankSelfFunderIndicator;
        private DirtyValue<StringEnumValue<State>> _correspondentWarehouseBankState;
        private DirtyValue<bool?> _correspondentWarehouseBankTriPartyContractIndicator;
        private DirtyValue<bool?> _correspondentWarehouseBankUseDefaultContactIndicator;
        private DirtyValue<string> _correspondentWarehouseBankWireConfirmationNumber;
        private DirtyValue<bool?> _correspondentWarehouseBankWireInstructionsReceivedIndicator;
        private DirtyValue<string> _correspondentWarehouseBankZip;
        private DirtyValue<string> _creditScoreToUse;
        private DirtyValue<int?> _cumulatedDaystoExtend;
        private DirtyValue<bool?> _currentAcquisition;
        private DirtyList<PriceAdjustment> _currentAdjustments;
        private DirtyValue<string> _currentComments;
        private DirtyValue<bool?> _currentConstructionRefi;
        private DirtyValue<DateTime?> _currentLockDate;
        private DirtyValue<DateTime?> _currentLockExpires;
        private DirtyValue<decimal?> _currentMarginRate;
        private DirtyValue<decimal?> _currentMarginRateRequested;
        private DirtyValue<decimal?> _currentMarginTotalAdjustment;
        private DirtyValue<int?> _currentNumberOfDays;
        private DirtyValue<decimal?> _currentPriceRate;
        private DirtyValue<decimal?> _currentPriceRateRequested;
        private DirtyValue<decimal?> _currentPriceTotalAdjustment;
        private DirtyValue<decimal?> _currentRate;
        private DirtyValue<decimal?> _currentRateRequested;
        private DirtyValue<DateTime?> _currentRateSetDate;
        private DirtyValue<string> _currentRateSheetID;
        private DirtyValue<decimal?> _currentRateTotalAdjustment;
        private DirtyValue<DateTime?> _date;
        private DirtyValue<DateTime?> _dateFirstPaymentToInvestor;
        private DirtyValue<DateTime?> _dateLockedWithInvestor;
        private DirtyValue<DateTime?> _dateSold;
        private DirtyValue<DateTime?> _dateWarehoused;
        private DirtyValue<int?> _daysToExtend;
        private DirtyValue<string> _deliveryType;
        private DirtyValue<decimal?> _diffAmountReceived;
        private DirtyValue<decimal?> _diffImpounds;
        private DirtyValue<decimal?> _diffInterest;
        private DirtyValue<decimal?> _diffPremium;
        private DirtyValue<decimal?> _diffPrinciple;
        private DirtyValue<decimal?> _diffRemainingBuydownFunds;
        private DirtyValue<decimal?> _diffSellAmount;
        private DirtyValue<decimal?> _diffSellPrice;
        private DirtyValue<decimal?> _diffSellSideSRP;
        private DirtyValue<decimal?> _diffSRP;
        private DirtyValue<decimal?> _diffSRPAmount;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator1;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator10;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator11;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator12;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator2;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator3;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator4;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator5;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator6;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator7;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator8;
        private DirtyValue<bool?> _employmentBorrowerSelfEmployedIndicator9;
        private DirtyValue<decimal?> _expectedAmountReceived;
        private DirtyValue<decimal?> _expectedImpounds;
        private DirtyValue<decimal?> _expectedInterest;
        private DirtyValue<decimal?> _expectedPremium;
        private DirtyValue<decimal?> _expectedPrinciple;
        private DirtyValue<decimal?> _expectedRemainingBuydownFunds;
        private DirtyValue<decimal?> _expectedSRP;
        private DirtyValue<string> _extensionRequestPending;
        private DirtyValue<int?> _extensionSequenceNumber;
        private DirtyList<ExtraPayment> _extraPayments;
        private DirtyValue<decimal?> _fHAUpfrontMIPremiumPercent;
        private DirtyValue<int?> _financedNumberOfUnits;
        private DirtyValue<StringEnumValue<PartyType>> _firstPaymenTo;
        private DirtyValue<decimal?> _firstSubordinateAmount;
        private DirtyValue<bool?> _firstTimeHomebuyersIndicator;
        private DirtyValue<string> _fNMProductPlanIdentifier;
        private DirtyValue<decimal?> _fundingAmount;
        private DirtyValue<decimal?> _gainLossPercentage;
        private DirtyValue<decimal?> _gainLossPrice;
        private DirtyValue<decimal?> _gainLossTotalBuyPrice;
        private DirtyValue<decimal?> _gPMRate;
        private DirtyValue<int?> _gPMYears;
        private DirtyValue<StringEnumValue<PropertyType>> _gSEPropertyType;
        private DirtyValue<StringEnumValue<YOrN>> _hedging;
        private DirtyValue<string> _hELOCActualBalance;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _impounds;
        private DirtyValue<StringEnumValue<ImpoundType>> _impoundType;
        private DirtyValue<string> _impoundWaived;
        private DirtyValue<StringEnumValue<ImpoundWaived>> _impoundWavied;
        private DirtyValue<decimal?> _interest;
        private DirtyValue<string> _investorAddress;
        private DirtyValue<string> _investorCity;
        private DirtyValue<string> _investorCommitment;
        private DirtyValue<string> _investorContact;
        private DirtyValue<DateTime?> _investorDeliveryDate;
        private DirtyValue<string> _investorEmail;
        private DirtyValue<string> _investorLoanNumber;
        private DirtyValue<string> _investorLockType;
        private DirtyValue<string> _investorMERSNumber;
        private DirtyValue<string> _investorName;
        private DirtyValue<string> _investorPhone;
        private DirtyValue<string> _investorPostalCode;
        private DirtyValue<string> _investorProgramCode;
        private DirtyValue<StringEnumValue<State>> _investorState;
        private DirtyValue<DateTime?> _investorTargetDeliveryDate;
        private DirtyValue<string> _investorTemplateName;
        private DirtyValue<string> _investorWebsite;
        private DirtyValue<string> _isCancelled;
        private DirtyValue<bool?> _isDeliveryType;
        private DirtyValue<bool?> _lenderFeeWaiverOption;
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        private DirtyValue<StringEnumValue<LienType>> _lienPriorityType;
        private DirtyValue<int?> _loanAmortizationTermMonths;
        private DirtyValue<StringEnumValue<AmortizationType>> _loanAmortizationType;
        private DirtyValue<StringEnumValue<LoanDocumentationType>> _loanDocumentationType;
        private DirtyValue<bool?> _loanFor203K;
        private DirtyValue<string> _loanProgram;
        private DirtyValue<string> _loanProgramFile;
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        private DirtyValue<bool?> _lockField;
        private DirtyList<PriceAdjustment> _lockRequestAdjustments;
        private DirtyList<LockRequestBorrower> _lockRequestBorrowers;
        private DirtyValue<StringEnumValue<LockRequestLoanPurposeType>> _lockRequestLoanPurposeType;
        private DirtyValue<decimal?> _lTV;
        private DirtyValue<string> _minFICO;
        private DirtyValue<string> _minFICO2;
        private DirtyValue<decimal?> _mIPPaidInCash;
        private DirtyValue<StringEnumValue<LoanType>> _mortgageType;
        private DirtyValue<decimal?> _netSellAmount;
        private DirtyValue<decimal?> _netSellPrice;
        private DirtyValue<DateTime?> _nextPaymentDate;
        private DirtyValue<bool?> _noClosingCostOption;
        private DirtyValue<StringEnumValue<YOrN>> _oNRPLock;
        private DirtyValue<string> _otherAmortizationTypeDescription;
        private DirtyValue<decimal?> _otherSubordinateAmount;
        private DirtyValue<StringEnumValue<PenaltyTerm>> _penaltyTerm;
        private DirtyValue<StringEnumValue<PerDiemInterestRoundingType>> _perDiemInterestRoundingType;
        private DirtyValue<string> _planCode;
        private DirtyValue<decimal?> _premium;
        private DirtyValue<StringEnumValue<YOrN>> _prepayPenalty;
        private DirtyValue<decimal?> _priceAdjustment;
        private DirtyList<PriceAdjustment> _priceAdjustments;
        private DirtyValue<string> _pricingHistoryData;
        private DirtyValue<string> _pricingUpdated;
        private DirtyValue<decimal?> _principle;
        private DirtyValue<decimal?> _profitMarginAdjustedBuyPrice;
        private DirtyValue<int?> _propertyAppraisedValueAmount;
        private DirtyValue<int?> _propertyEstimatedValueAmount;
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        private DirtyValue<int?> _purchaseAdviceNumberOfDays;
        private DirtyList<PurchaseAdvicePayout> _purchaseAdvicePayouts;
        private DirtyValue<decimal?> _purchasePriceAmount;
        private DirtyValue<string> _rateRequestStatus;
        private DirtyValue<string> _rateStatus;
        private DirtyValue<string> _reasonforBranchApproval;
        private DirtyValue<string> _reasonforCorporateApproval;
        private DirtyValue<decimal?> _reconciledDiff;
        private DirtyValue<string> _reLockRequestPending;
        private DirtyValue<decimal?> _remainingBuydownFunds;
        private DirtyValue<string> _requestComments;
        private DirtyValue<DateTime?> _requestCurrentRateSetDate;
        private DirtyValue<int?> _requestDaystoExtend;
        private DirtyValue<DateTime?> _requestExtendedLockExpires;
        private DirtyValue<string> _requestFullfilledDateTime;
        private DirtyValue<StringEnumValue<ImpoundType>> _requestImpoundType;
        private DirtyValue<string> _requestImpoundWaived;
        private DirtyValue<StringEnumValue<ImpoundWaived>> _requestImpoundWavied;
        private DirtyValue<string> _requestLockCancellationComment;
        private DirtyValue<DateTime?> _requestLockCancellationDate;
        private DirtyValue<DateTime?> _requestLockDate;
        private DirtyValue<DateTime?> _requestLockExpires;
        private DirtyValue<string> _requestLockExtendComment;
        private DirtyValue<decimal?> _requestLockExtendPriceAdjustment;
        private DirtyValue<string> _requestLockStatus;
        private DirtyValue<string> _requestLockType;
        private DirtyValue<decimal?> _requestMarginRate;
        private DirtyValue<decimal?> _requestMarginRateRequested;
        private DirtyValue<decimal?> _requestMarginSRPPaidOut;
        private DirtyValue<decimal?> _requestMarginTotalAdjustment;
        private DirtyValue<int?> _requestNumberOfDays;
        private DirtyValue<bool?> _requestOnrpEligible;
        private DirtyValue<DateTime?> _requestOnrpLockDate;
        private DirtyValue<string> _requestOnrpLockTime;
        private DirtyValue<DateTime?> _requestOriginalLockExpires;
        private DirtyValue<StringEnumValue<PenaltyTerm>> _requestPenaltyTerm;
        private DirtyValue<string> _requestPending;
        private DirtyValue<StringEnumValue<YOrN>> _requestPrepayPenalty;
        private DirtyValue<decimal?> _requestPriceRate;
        private DirtyValue<decimal?> _requestPriceRateRequested;
        private DirtyValue<decimal?> _requestPriceTotalAdjustment;
        private DirtyValue<string> _requestProgramNotes;
        private DirtyValue<decimal?> _requestRate;
        private DirtyValue<decimal?> _requestRateRequested;
        private DirtyValue<string> _requestRateSheetID;
        private DirtyValue<decimal?> _requestRateTotalAdjustment;
        private DirtyValue<decimal?> _requestStartingAdjPoint;
        private DirtyValue<decimal?> _requestStartingAdjRate;
        private DirtyValue<string> _requestType;
        private DirtyValue<decimal?> _requestUnDiscountedRate;
        private DirtyValue<bool?> _roundToNearest50;
        private DirtyValue<decimal?> _secondSubordinateAmount;
        private DirtyValue<decimal?> _sellerPaidMIPremium;
        private DirtyList<PriceAdjustment> _sellSideAdjustments;
        private DirtyValue<string> _sellSideComments;
        private DirtyValue<string> _sellSideCommitmentContractNumber;
        private DirtyValue<DateTime?> _sellSideCommitmentDate;
        private DirtyValue<DateTime?> _sellSideCurrentRateSetDate;
        private DirtyValue<int?> _sellSideDaystoExtend;
        private DirtyValue<decimal?> _sellSideDiscountYSP;
        private DirtyValue<DateTime?> _sellSideExtendedLockExpires;
        private DirtyValue<decimal?> _sellSideGuaranteeFee;
        private DirtyValue<decimal?> _sellSideGuarantyBaseFee;
        private DirtyValue<StringEnumValue<SellSideInvestorStatus>> _sellSideInvestorStatus;
        private DirtyValue<DateTime?> _sellSideInvestorStatusDate;
        private DirtyValue<string> _sellSideInvestorTradeNumber;
        private DirtyValue<string> _sellSideLoanProgram;
        private DirtyValue<DateTime?> _sellSideLockDate;
        private DirtyValue<DateTime?> _sellSideLockExpires;
        private DirtyValue<decimal?> _sellSideLockExtendPriceAdjustment;
        private DirtyValue<decimal?> _sellSideMarginNetSellRate;
        private DirtyValue<decimal?> _sellSideMarginRate;
        private DirtyValue<decimal?> _sellSideMarginTotalAdjustment;
        private DirtyValue<string> _sellSideMasterContractNumber;
        private DirtyValue<decimal?> _sellSideMSRValue;
        private DirtyValue<decimal?> _sellSideNetSellPrice;
        private DirtyValue<decimal?> _sellSideNetSellRate;
        private DirtyValue<int?> _sellSideNumberOfDays;
        private DirtyValue<DateTime?> _sellSideOriginalLockExpires;
        private DirtyValue<string> _sellSidePoolID;
        private DirtyValue<string> _sellSidePoolNumber;
        private DirtyValue<decimal?> _sellSidePriceRate;
        private DirtyValue<decimal?> _sellSidePriceTotalAdjustment;
        private DirtyValue<string> _sellSideProductName;
        private DirtyValue<decimal?> _sellSideRate;
        private DirtyValue<string> _sellSideRateSheetID;
        private DirtyValue<decimal?> _sellSideRateTotalAdjustment;
        private DirtyValue<string> _sellSideRequestedBy;
        private DirtyValue<string> _sellSideServicer;
        private DirtyValue<decimal?> _sellSideServicingFee;
        private DirtyValue<StringEnumValue<ServicingType>> _sellSideServicingType;
        private DirtyValue<decimal?> _sellSideSRP;
        private DirtyValue<decimal?> _sellSideSRPPaidOut;
        private DirtyValue<string> _sellSideTradeGuid;
        private DirtyValue<string> _sellSideTradeMgmtPrevConfirmedLockGuid;
        private DirtyValue<string> _sellSideTradeNumber;
        private DirtyValue<bool?> _servicingReleaseIndicator;
        private DirtyValue<decimal?> _sRP;
        private DirtyValue<decimal?> _sRPAmount;
        private DirtyValue<decimal?> _sRPPaidOut;
        private DirtyValue<string> _subjectPropertyCity;
        private DirtyValue<bool?> _subjectPropertyCondotelIndicator;
        private DirtyValue<string> _subjectPropertyCounty;
        private DirtyValue<bool?> _subjectPropertyNonWarrantableProjectIndicator;
        private DirtyValue<string> _subjectPropertyPostalCode;
        private DirtyValue<StringEnumValue<State>> _subjectPropertyState;
        private DirtyValue<string> _subjectPropertyStreetAddress;
        private DirtyValue<string> _timeLockedWithInvestor;
        private DirtyValue<decimal?> _totalBuyPrice;
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        private DirtyValue<decimal?> _totalPrice;
        private DirtyValue<decimal?> _totalSubordinateFinancing;
        private DirtyValue<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        private DirtyValue<string> _type;
        private DirtyValue<bool?> _usePoint;

        /// <summary>
        /// Purchase Advice Actual Sell Amount [3424]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Actual Sell Amount")]
        public decimal? ActualSellAmount { get => _actualSellAmount; set => SetField(ref _actualSellAmount, value); }

        /// <summary>
        /// Purchase Advice Actual Sell Price [3422]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Actual Sell Price")]
        public decimal? ActualSellPrice { get => _actualSellPrice; set => SetField(ref _actualSellPrice, value); }

        /// <summary>
        /// Purchase Advice Actual Sell Side SRP [3426]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Actual Sell Side SRP")]
        public decimal? ActualSellSideSRP { get => _actualSellSideSRP; set => SetField(ref _actualSellSideSRP, value); }

        /// <summary>
        /// Purchase Advice Actual SRP Amount [3428]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Actual SRP Amount")]
        public decimal? ActualSRPAmount { get => _actualSRPAmount; set => SetField(ref _actualSRPAmount, value); }

        /// <summary>
        /// Purchase Advice Amt Due To [2631]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Amt Due To")]
        public decimal? AmountDue { get => _amountDue; set => SetField(ref _amountDue, value); }

        /// <summary>
        /// Purchase Advice Amt Due to Lender/Investor [2627]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Purchase Advice Amt Due to Lender/Investor")]
        public StringEnumValue<PartyType> AmountDueTo { get => _amountDueTo; set => SetField(ref _amountDueTo, value); }

        /// <summary>
        /// Purchase Advice Amt Paid To [2632]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Amt Paid To")]
        public decimal? AmountPaid { get => _amountPaid; set => SetField(ref _amountPaid, value); }

        /// <summary>
        /// Purchase Advice Amt Paid to Lender/Investor [2628]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Purchase Advice Amt Paid to Lender/Investor")]
        public StringEnumValue<PartyType> AmountPaidTo { get => _amountPaidTo; set => SetField(ref _amountPaidTo, value); }

        /// <summary>
        /// Purchase Advice Amount Received [2214]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Amount Received")]
        public decimal? AmountReceived { get => _amountReceived; set => SetField(ref _amountReceived, value); }

        /// <summary>
        /// Lock Request Term Due In [2960]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Term Due In")]
        public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => SetField(ref _balloonLoanMaturityTermMonths, value); }

        /// <summary>
        /// Lock Request Loan Amnt Excluding MIP/PMI [3043]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Loan Amnt Excluding MIP/PMI")]
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }

        /// <summary>
        /// RateLock BorrLenderPaid
        /// </summary>
        public string BorrLenderPaid { get => _borrLenderPaid; set => SetField(ref _borrLenderPaid, value); }

        /// <summary>
        /// Lock Request Loan Amount [2965]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Loan Amount")]
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => SetField(ref _borrowerRequestedLoanAmount, value); }

        /// <summary>
        /// Rate Lock Buy Side Branch Concession Approval Date [3376]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Branch Concession Approval Date")]
        public DateTime? BranchApprovalDate { get => _branchApprovalDate; set => SetField(ref _branchApprovalDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Branch Concession Approved by [3377]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Branch Concession Approved by")]
        public string BranchApprovedby { get => _branchApprovedby; set => SetField(ref _branchApprovedby, value); }

        /// <summary>
        /// Rate Lock Buy Side Branch Price Concession [3375]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Branch Price Concession")]
        public decimal? BranchPrice { get => _branchPrice; set => SetField(ref _branchPrice, value); }

        /// <summary>
        /// RateLock BuySideAdjustments
        /// </summary>
        public IList<PriceAdjustment> BuySideAdjustments { get => GetField(ref _buySideAdjustments); set => SetField(ref _buySideAdjustments, value); }

        /// <summary>
        /// Rate Lock Buy Side Comments [2204]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Comments")]
        public string BuySideComments { get => _buySideComments; set => SetField(ref _buySideComments, value); }

        /// <summary>
        /// Rate Lock BuySide Commitment Date [3909]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Date")]
        public DateTime? BuySideCommitmentDate { get => _buySideCommitmentDate; set => SetField(ref _buySideCommitmentDate, value); }

        /// <summary>
        /// Rate Lock BuySide Commitment Number [3902]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Number")]
        public string BuySideCommitmentNumber { get => _buySideCommitmentNumber; set => SetField(ref _buySideCommitmentNumber, value); }

        /// <summary>
        /// Rate Lock BuySide Commitment Type [3910]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Commitment Type")]
        public string BuySideCommitmentType { get => _buySideCommitmentType; set => SetField(ref _buySideCommitmentType, value); }

        /// <summary>
        /// Rate Lock Buy Side Last Rate Set Date [3256]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Last Rate Set Date")]
        public DateTime? BuySideCurrentRateSetDate { get => _buySideCurrentRateSetDate; set => SetField(ref _buySideCurrentRateSetDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Days to Extend [3363]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Days to Extend")]
        public int? BuySideDaystoExtend { get => _buySideDaystoExtend; set => SetField(ref _buySideDaystoExtend, value); }

        /// <summary>
        /// Rate Lock BuySide Delivery Expiration Date [3913]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Delivery Expiration Date")]
        public DateTime? BuySideDeliveryExpirationDate { get => _buySideDeliveryExpirationDate; set => SetField(ref _buySideDeliveryExpirationDate, value); }

        /// <summary>
        /// Rate Lock BuySide Delivery Type [3911]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Delivery Type")]
        public string BuySideDeliveryType { get => _buySideDeliveryType; set => SetField(ref _buySideDeliveryType, value); }

        /// <summary>
        /// Rate Lock BuySide Expiration Date [3912]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Expiration Date")]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Extended Lock Expires Date [3364]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Extended Lock Expires Date")]
        public DateTime? BuySideExtendedLockExpires { get => _buySideExtendedLockExpires; set => SetField(ref _buySideExtendedLockExpires, value); }

        /// <summary>
        /// Rate Lock Buy Side Lock Date [2149]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Date")]
        public DateTime? BuySideLockDate { get => _buySideLockDate; set => SetField(ref _buySideLockDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Lock Expires Date [2151]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Expires Date")]
        public DateTime? BuySideLockExpires { get => _buySideLockExpires; set => SetField(ref _buySideLockExpires, value); }

        /// <summary>
        /// Rate Lock Buy Side Lock Extension Price Adjustment [3365]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Lock Extension Price Adjustment")]
        public decimal? BuySideLockExtendPriceAdjustment { get => _buySideLockExtendPriceAdjustment; set => SetField(ref _buySideLockExtendPriceAdjustment, value); }

        /// <summary>
        /// Rate Lock Buy Side Net Buy ARM Margin [2775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Net Buy ARM Margin")]
        public decimal? BuySideMarginNetBuyRate { get => _buySideMarginNetBuyRate; set => SetField(ref _buySideMarginNetBuyRate, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Margin [2733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Margin")]
        public decimal? BuySideMarginRate { get => _buySideMarginRate; set => SetField(ref _buySideMarginRate, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Rate Total Adjust [2774]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate Total Adjust")]
        public decimal? BuySideMarginTotalAdjustment { get => _buySideMarginTotalAdjustment; set => SetField(ref _buySideMarginTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock BuySide Master Commitment Number [3903]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Master Commitment Number")]
        public string BuySideMasterCommitmentNumber { get => _buySideMasterCommitmentNumber; set => SetField(ref _buySideMasterCommitmentNumber, value); }

        /// <summary>
        /// Rate Lock Buy Side Number of Days [2150]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Number of Days")]
        public int? BuySideNumberOfDays { get => _buySideNumberOfDays; set => SetField(ref _buySideNumberOfDays, value); }

        /// <summary>
        /// Rate Lock Buy Side ONRP Eligible Flag [4059]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Eligible Flag", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? BuySideOnrpEligible { get => _buySideOnrpEligible; set => SetField(ref _buySideOnrpEligible, value); }

        /// <summary>
        /// Rate Lock Buy Side ONRP Lock Date [4070]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Lock Date")]
        public DateTime? BuySideOnrpLockDate { get => _buySideOnrpLockDate; set => SetField(ref _buySideOnrpLockDate, value); }

        /// <summary>
        /// Rate Lock Buy Side ONRP Lock Time [4058]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Buy Side ONRP Lock Time")]
        public string BuySideOnrpLockTime { get => _buySideOnrpLockTime; set => SetField(ref _buySideOnrpLockTime, value); }

        /// <summary>
        /// Rate Lock BuySide Org ID [3906]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide Org ID")]
        public string BuySideOrgID { get => _buySideOrgID; set => SetField(ref _buySideOrgID, value); }

        /// <summary>
        /// Rate Lock Buy Side Lock Expires Date [3358]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Lock Expires Date")]
        public DateTime? BuySideOriginalLockExpires { get => _buySideOriginalLockExpires; set => SetField(ref _buySideOriginalLockExpires, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Price Rate Net Buy Price [2203]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Rate Net Buy Price")]
        public decimal? BuySidePriceNetBuyPrice { get => _buySidePriceNetBuyPrice; set => SetField(ref _buySidePriceNetBuyPrice, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Price Rate [2161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Rate")]
        public decimal? BuySidePriceRate { get => _buySidePriceRate; set => SetField(ref _buySidePriceRate, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Price Tot Adjustment [2202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Base Price Tot Adjustment")]
        public decimal? BuySidePriceTotalAdjustment { get => _buySidePriceTotalAdjustment; set => SetField(ref _buySidePriceTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Rate [2152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate")]
        public decimal? BuySideRate { get => _buySideRate; set => SetField(ref _buySideRate, value); }

        /// <summary>
        /// Rate Lock Buy Side Net Buy Rate [2160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Net Buy Rate")]
        public decimal? BuySideRateNetBuyRate { get => _buySideRateNetBuyRate; set => SetField(ref _buySideRateNetBuyRate, value); }

        /// <summary>
        /// Rate Lock Buy Side Rate Sheet ID [2148]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Rate Sheet ID")]
        public string BuySideRateSheetID { get => _buySideRateSheetID; set => SetField(ref _buySideRateSheetID, value); }

        /// <summary>
        /// Rate Lock Buy Side Base Rate Tot Adjustment [2159]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Base Rate Tot Adjustment")]
        public decimal? BuySideRateTotalAdjustment { get => _buySideRateTotalAdjustment; set => SetField(ref _buySideRateTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Buy Side Requested By [2029]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Requested By")]
        public string BuySideRequestedBy { get => _buySideRequestedBy; set => SetField(ref _buySideRequestedBy, value); }

        /// <summary>
        /// Rate Lock Buy Side SRP Paid Out [2205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side SRP Paid Out")]
        public decimal? BuySideSRPPaidOut { get => _buySideSRPPaidOut; set => SetField(ref _buySideSRPPaidOut, value); }

        /// <summary>
        /// Rate Lock BuySide Starting Adjust Point [3875]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide Starting Adjust Point")]
        public decimal? BuySideStartingAdjPoint { get => _buySideStartingAdjPoint; set => SetField(ref _buySideStartingAdjPoint, value); }

        /// <summary>
        /// RateLock BuySideStartingAdjPrice
        /// </summary>
        public decimal? BuySideStartingAdjPrice { get => _buySideStartingAdjPrice; set => SetField(ref _buySideStartingAdjPrice, value); }

        /// <summary>
        /// Rate Lock BuySide Starting Adjust Rate [3873]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide Starting Adjust Rate")]
        public decimal? BuySideStartingAdjRate { get => _buySideStartingAdjRate; set => SetField(ref _buySideStartingAdjRate, value); }

        /// <summary>
        /// Rate Lock BuySide TPOID [3905]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide TPOID")]
        public string BuySideTPOID { get => _buySideTPOID; set => SetField(ref _buySideTPOID, value); }

        /// <summary>
        /// Rate Lock BuySide TPO Name [3904]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock BuySide TPO Name")]
        public string BuySideTPOName { get => _buySideTPOName; set => SetField(ref _buySideTPOName, value); }

        /// <summary>
        /// Assigned Trade Unique Identifier [3914]
        /// </summary>
        [LoanFieldProperty(Description = "Assigned Trade Unique Identifier")]
        public string BuySideTradeGuid { get => _buySideTradeGuid; set => SetField(ref _buySideTradeGuid, value); }

        /// <summary>
        /// Rate Lock Assigned Trade Number [3915]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Assigned Trade Number")]
        public string BuySideTradeNumber { get => _buySideTradeNumber; set => SetField(ref _buySideTradeNumber, value); }

        /// <summary>
        /// Rate Lock BuySide UnDiscounted Rate [3848]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock BuySide UnDiscounted Rate")]
        public decimal? BuySideUnDiscountedRate { get => _buySideUnDiscountedRate; set => SetField(ref _buySideUnDiscountedRate, value); }

        /// <summary>
        /// RateLock CancellationRequestPending
        /// </summary>
        public string CancellationRequestPending { get => _cancellationRequestPending; set => SetField(ref _cancellationRequestPending, value); }

        /// <summary>
        /// Lock RequestCOmbined Loan to Value (CLTV) [3242]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Lock RequestCOmbined Loan to Value (CLTV)")]
        public decimal? CombinedLTV { get => _combinedLTV; set => SetField(ref _combinedLTV, value); }

        /// <summary>
        /// Purchase Adv Reconciliation Comments [2840]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Reconciliation Comments")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Rate Lock Buy Side Investor Commitment [2215]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Investor Commitment")]
        public string Commitment { get => _commitment; set => SetField(ref _commitment, value); }

        /// <summary>
        /// Rate Lock Request Commitment Type [4187]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Commitment Type")]
        public string CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }

        /// <summary>
        /// Rate Lock Comparison Gain Loss Percent [3836]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Gain Loss Percent")]
        public decimal? CompGainLossPercentage { get => _compGainLossPercentage; set => SetField(ref _compGainLossPercentage, value); }

        /// <summary>
        /// Rate Lock Comparison Gain Loss Price [3837]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Gain Loss Price")]
        public decimal? CompGainLossPrice { get => _compGainLossPrice; set => SetField(ref _compGainLossPrice, value); }

        /// <summary>
        /// RateLock CompGainLossTotalBuyPrice
        /// </summary>
        public decimal? CompGainLossTotalBuyPrice { get => _compGainLossTotalBuyPrice; set => SetField(ref _compGainLossTotalBuyPrice, value); }

        /// <summary>
        /// Rate Lock Comparison Total Comparison Price [3835]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Total Comparison Price")]
        public decimal? CompGainLossTotalCompPrice { get => _compGainLossTotalCompPrice; set => SetField(ref _compGainLossTotalCompPrice, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Address [3826]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Address")]
        public string CompInvestorAddress { get => _compInvestorAddress; set => SetField(ref _compInvestorAddress, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor City [3827]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor City")]
        public string CompInvestorCity { get => _compInvestorCity; set => SetField(ref _compInvestorCity, value); }

        /// <summary>
        /// RateLock CompInvestorCommitment
        /// </summary>
        public string CompInvestorCommitment { get => _compInvestorCommitment; set => SetField(ref _compInvestorCommitment, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Contact [3823]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Contact")]
        public string CompInvestorContact { get => _compInvestorContact; set => SetField(ref _compInvestorContact, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Email [3825]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Email")]
        public string CompInvestorEmail { get => _compInvestorEmail; set => SetField(ref _compInvestorEmail, value); }

        /// <summary>
        /// Rate Lock Comparison Investor Lock Type [3832]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Lock Type")]
        public string CompInvestorLockType { get => _compInvestorLockType; set => SetField(ref _compInvestorLockType, value); }

        /// <summary>
        /// Rate Lock Comparison Investor Name [3822]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Name")]
        public string CompInvestorName { get => _compInvestorName; set => SetField(ref _compInvestorName, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Phone [3824]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Rate Lock Comparison Side Investor Phone")]
        public string CompInvestorPhone { get => _compInvestorPhone; set => SetField(ref _compInvestorPhone, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Zipcode [3829]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Rate Lock Comparison Side Investor Zipcode")]
        public string CompInvestorPostalCode { get => _compInvestorPostalCode; set => SetField(ref _compInvestorPostalCode, value); }

        /// <summary>
        /// Rate Lock Comparison Investor Program Code [3833]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Program Code")]
        public string CompInvestorProgramCode { get => _compInvestorProgramCode; set => SetField(ref _compInvestorProgramCode, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor State [3828]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor State")]
        public StringEnumValue<State> CompInvestorState { get => _compInvestorState; set => SetField(ref _compInvestorState, value); }

        /// <summary>
        /// Rate Lock Comparison Investor Template Name [3838]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Investor Template Name")]
        public string CompInvestorTemplateName { get => _compInvestorTemplateName; set => SetField(ref _compInvestorTemplateName, value); }

        /// <summary>
        /// Rate Lock Comparison Side Investor Website [3830]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Side Investor Website")]
        public string CompInvestorWebsite { get => _compInvestorWebsite; set => SetField(ref _compInvestorWebsite, value); }

        /// <summary>
        /// RateLock CompSideAdjustments
        /// </summary>
        public IList<PriceAdjustment> CompSideAdjustments { get => GetField(ref _compSideAdjustments); set => SetField(ref _compSideAdjustments, value); }

        /// <summary>
        /// Rate Lock Comparison Comments [3834]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Comments")]
        public string CompSideComments { get => _compSideComments; set => SetField(ref _compSideComments, value); }

        /// <summary>
        /// Rate Lock Comparison Comparisoned By [3661]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Comparisoned By")]
        public string CompSideComparisonedBy { get => _compSideComparisonedBy; set => SetField(ref _compSideComparisonedBy, value); }

        /// <summary>
        /// Rate Lock Comparison Last Rate Set Date [3663]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Last Rate Set Date")]
        public DateTime? CompSideCurrentRateSetDate { get => _compSideCurrentRateSetDate; set => SetField(ref _compSideCurrentRateSetDate, value); }

        /// <summary>
        /// RateLock CompSideDaystoExtend
        /// </summary>
        public int? CompSideDaystoExtend { get => _compSideDaystoExtend; set => SetField(ref _compSideDaystoExtend, value); }

        /// <summary>
        /// Rate Lock Comparison Discount YSP [3821]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Discount YSP")]
        public decimal? CompSideDiscountYSP { get => _compSideDiscountYSP; set => SetField(ref _compSideDiscountYSP, value); }

        /// <summary>
        /// RateLock CompSideExtendedLockExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideExtendedLockExpires { get => _compSideExtendedLockExpires; set => SetField(ref _compSideExtendedLockExpires, value); }

        /// <summary>
        /// RateLock CompSideInvestorStatus
        /// </summary>
        public string CompSideInvestorStatus { get => _compSideInvestorStatus; set => SetField(ref _compSideInvestorStatus, value); }

        /// <summary>
        /// RateLock CompSideInvestorStatusDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideInvestorStatusDate { get => _compSideInvestorStatusDate; set => SetField(ref _compSideInvestorStatusDate, value); }

        /// <summary>
        /// RateLock CompSideInvestorTradeNumber
        /// </summary>
        public string CompSideInvestorTradeNumber { get => _compSideInvestorTradeNumber; set => SetField(ref _compSideInvestorTradeNumber, value); }

        /// <summary>
        /// Rate Lock Comparison Loan Program [3660]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Loan Program")]
        public string CompSideLoanProgram { get => _compSideLoanProgram; set => SetField(ref _compSideLoanProgram, value); }

        /// <summary>
        /// Rate Lock Comparison Lock Date [3664]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Lock Date")]
        public DateTime? CompSideLockDate { get => _compSideLockDate; set => SetField(ref _compSideLockDate, value); }

        /// <summary>
        /// Rate Lock Comparison Lock Expires Date [3666]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Lock Expires Date")]
        public DateTime? CompSideLockExpires { get => _compSideLockExpires; set => SetField(ref _compSideLockExpires, value); }

        /// <summary>
        /// RateLock CompSideLockExtendPriceAdjustment
        /// </summary>
        public decimal? CompSideLockExtendPriceAdjustment { get => _compSideLockExtendPriceAdjustment; set => SetField(ref _compSideLockExtendPriceAdjustment, value); }

        /// <summary>
        /// Rate Lock Comparison Net Comparison ARM Margin [3819]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Net Comparison ARM Margin")]
        public decimal? CompSideMarginNetCompRate { get => _compSideMarginNetCompRate; set => SetField(ref _compSideMarginNetCompRate, value); }

        /// <summary>
        /// Rate Lock Comparison Base Margin [3777]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Margin")]
        public decimal? CompSideMarginRate { get => _compSideMarginRate; set => SetField(ref _compSideMarginRate, value); }

        /// <summary>
        /// Rate Lock Comparison Base Rate Total Adjust [3818]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate Total Adjust")]
        public decimal? CompSideMarginTotalAdjustment { get => _compSideMarginTotalAdjustment; set => SetField(ref _compSideMarginTotalAdjustment, value); }

        /// <summary>
        /// RateLock CompSideMasterContractNumber
        /// </summary>
        public string CompSideMasterContractNumber { get => _compSideMasterContractNumber; set => SetField(ref _compSideMasterContractNumber, value); }

        /// <summary>
        /// Rate Lock Comparison Base Price Rate Net Comparison Price [3776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Rate Net Comparison Price")]
        public decimal? CompSideNetCompPrice { get => _compSideNetCompPrice; set => SetField(ref _compSideNetCompPrice, value); }

        /// <summary>
        /// Rate Lock Comparison Net Comparison Rate [3713]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Net Comparison Rate")]
        public decimal? CompSideNetCompRate { get => _compSideNetCompRate; set => SetField(ref _compSideNetCompRate, value); }

        /// <summary>
        /// Rate Lock Comparison Number of Days [3665]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Number of Days")]
        public int? CompSideNumberOfDays { get => _compSideNumberOfDays; set => SetField(ref _compSideNumberOfDays, value); }

        /// <summary>
        /// RateLock CompSideOriginalLockExpires
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CompSideOriginalLockExpires { get => _compSideOriginalLockExpires; set => SetField(ref _compSideOriginalLockExpires, value); }

        /// <summary>
        /// Rate Lock Comparison Base Price Rate [3714]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Rate")]
        public decimal? CompSidePriceRate { get => _compSidePriceRate; set => SetField(ref _compSidePriceRate, value); }

        /// <summary>
        /// Rate Lock Comparison Base Price Tot Adjustment [3775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Comparison Base Price Tot Adjustment")]
        public decimal? CompSidePriceTotalAdjustment { get => _compSidePriceTotalAdjustment; set => SetField(ref _compSidePriceTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Comparison Base Rate [3671]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate")]
        public decimal? CompSideRate { get => _compSideRate; set => SetField(ref _compSideRate, value); }

        /// <summary>
        /// Rate Lock Comparison Rate Sheet ID [3662]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Rate Sheet ID")]
        public string CompSideRateSheetID { get => _compSideRateSheetID; set => SetField(ref _compSideRateSheetID, value); }

        /// <summary>
        /// Rate Lock Comparison Base Rate Tot Adjustment [3712]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison Base Rate Tot Adjustment")]
        public decimal? CompSideRateTotalAdjustment { get => _compSideRateTotalAdjustment; set => SetField(ref _compSideRateTotalAdjustment, value); }

        /// <summary>
        /// RateLock CompSideRequestedBy
        /// </summary>
        public string CompSideRequestedBy { get => _compSideRequestedBy; set => SetField(ref _compSideRequestedBy, value); }

        /// <summary>
        /// Rate Lock Comparison Servicing Type [3831]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Comparison Servicing Type")]
        public StringEnumValue<ServicingType> CompSideServicingType { get => _compSideServicingType; set => SetField(ref _compSideServicingType, value); }

        /// <summary>
        /// Rate Lock Comparison SRP Paid Out [3820]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Comparison SRP Paid Out")]
        public decimal? CompSideSRPPaidOut { get => _compSideSRPPaidOut; set => SetField(ref _compSideSRPPaidOut, value); }

        /// <summary>
        /// RateLock CompSideTradeGuid
        /// </summary>
        public string CompSideTradeGuid { get => _compSideTradeGuid; set => SetField(ref _compSideTradeGuid, value); }

        /// <summary>
        /// RateLock CompSideTradeNumber
        /// </summary>
        public string CompSideTradeNumber { get => _compSideTradeNumber; set => SetField(ref _compSideTradeNumber, value); }

        /// <summary>
        /// Purchase Advice Confirmed By [2396]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Confirmed By")]
        public string ConfirmedBy { get => _confirmedBy; set => SetField(ref _confirmedBy, value); }

        /// <summary>
        /// Purchase Advice Confirmed Date [2630]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Confirmed Date")]
        public DateTime? ConfirmedDate { get => _confirmedDate; set => SetField(ref _confirmedDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Corporate Concession Approval Date [3372]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Corporate Concession Approval Date")]
        public DateTime? CorporateApprovalDate { get => _corporateApprovalDate; set => SetField(ref _corporateApprovalDate, value); }

        /// <summary>
        /// Rate Lock Buy Side Corporate Concession Approved by [3373]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Corporate Concession Approved by")]
        public string CorporateApprovedby { get => _corporateApprovedby; set => SetField(ref _corporateApprovedby, value); }

        /// <summary>
        /// Rate Lock Buy Side Corporate Price Concession [3371]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Corporate Price Concession")]
        public decimal? CorporatePrice { get => _corporatePrice; set => SetField(ref _corporatePrice, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Additional Escrow [CPA.ADDLESCROW.AdditionalEscrow]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Escrow")]
        public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get => _correspondentAdditionalEscrowAdditionalEscrow; set => SetField(ref _correspondentAdditionalEscrowAdditionalEscrow, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1007 Amount [CPA.ADDLESCROW.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1007 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1007 { get => _correspondentAdditionalEscrowAmount1007; set => SetField(ref _correspondentAdditionalEscrowAmount1007, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1008 Amount [CPA.ADDLESCROW.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1008 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1008 { get => _correspondentAdditionalEscrowAmount1008; set => SetField(ref _correspondentAdditionalEscrowAmount1008, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1009 Amount [CPA.ADDLESCROW.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Line 1009 Amount")]
        public decimal? CorrespondentAdditionalEscrowAmount1009 { get => _correspondentAdditionalEscrowAmount1009; set => SetField(ref _correspondentAdditionalEscrowAmount1009, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - City Property Tax [CPA.ADDLESCROW.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - City Property Tax")]
        public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get => _correspondentAdditionalEscrowCityPropertyTax; set => SetField(ref _correspondentAdditionalEscrowCityPropertyTax, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1007 Description [CPA.ADDLESCROW.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1007 Description")]
        public string CorrespondentAdditionalEscrowDescription1007 { get => _correspondentAdditionalEscrowDescription1007; set => SetField(ref _correspondentAdditionalEscrowDescription1007, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1008 Description [CPA.ADDLESCROW.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1008 Description")]
        public string CorrespondentAdditionalEscrowDescription1008 { get => _correspondentAdditionalEscrowDescription1008; set => SetField(ref _correspondentAdditionalEscrowDescription1008, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Line 1009 Description [CPA.ADDLESCROW.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Line 1009 Description")]
        public string CorrespondentAdditionalEscrowDescription1009 { get => _correspondentAdditionalEscrowDescription1009; set => SetField(ref _correspondentAdditionalEscrowDescription1009, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Flood Insurance [CPA.ADDLESCROW.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Flood Insurance")]
        public decimal? CorrespondentAdditionalEscrowFloodInsurance { get => _correspondentAdditionalEscrowFloodInsurance; set => SetField(ref _correspondentAdditionalEscrowFloodInsurance, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Homeowners Insurance [CPA.ADDLESCROW.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Homeowners Insurance")]
        public decimal? CorrespondentAdditionalEscrowHomeInsurance { get => _correspondentAdditionalEscrowHomeInsurance; set => SetField(ref _correspondentAdditionalEscrowHomeInsurance, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - MI/MIP [CPA.ADDLESCROW.MIMIP]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - MI/MIP")]
        public decimal? CorrespondentAdditionalEscrowMIMIP { get => _correspondentAdditionalEscrowMIMIP; set => SetField(ref _correspondentAdditionalEscrowMIMIP, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Number of Payments [CPA.ADDLESCROW.NumOfPayments]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Number of Payments")]
        public int? CorrespondentAdditionalEscrowNumOfPayments { get => _correspondentAdditionalEscrowNumOfPayments; set => SetField(ref _correspondentAdditionalEscrowNumOfPayments, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Value 1 [CPA.ADDLESCROW.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Amount Value 1")]
        public decimal? CorrespondentAdditionalEscrowOption1Amount { get => _correspondentAdditionalEscrowOption1Amount; set => SetField(ref _correspondentAdditionalEscrowOption1Amount, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Description 1 [CPA.ADDLESCROW.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption1Desc { get => _correspondentAdditionalEscrowOption1Desc; set => SetField(ref _correspondentAdditionalEscrowOption1Desc, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Value 2 [CPA.ADDLESCROW.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Additional Amount Value 2")]
        public decimal? CorrespondentAdditionalEscrowOption2Amount { get => _correspondentAdditionalEscrowOption2Amount; set => SetField(ref _correspondentAdditionalEscrowOption2Amount, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Additional Amount Description 2 [CPA.ADDLESCROW.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Additional Escrow Payment Collection - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption2Desc { get => _correspondentAdditionalEscrowOption2Desc; set => SetField(ref _correspondentAdditionalEscrowOption2Desc, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Property Tax [CPA.ADDLESCROW.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Property Tax")]
        public decimal? CorrespondentAdditionalEscrowPropertyTax { get => _correspondentAdditionalEscrowPropertyTax; set => SetField(ref _correspondentAdditionalEscrowPropertyTax, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - Sum of Payments [CPA.ADDLESCROW.SumOfPayments]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - Sum of Payments")]
        public decimal? CorrespondentAdditionalEscrowSumOfPayments { get => _correspondentAdditionalEscrowSumOfPayments; set => SetField(ref _correspondentAdditionalEscrowSumOfPayments, value); }

        /// <summary>
        /// Additional Escrow Payment Collection - USDA Annual Fee [CPA.ADDLESCROW.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Additional Escrow Payment Collection - USDA Annual Fee")]
        public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get => _correspondentAdditionalEscrowUSDAAnnualFee; set => SetField(ref _correspondentAdditionalEscrowUSDAAnnualFee, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 1 [3588]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 1")]
        public decimal? CorrespondentAdditionalLineAmount1 { get => _correspondentAdditionalLineAmount1; set => SetField(ref _correspondentAdditionalLineAmount1, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 10 [3606]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 10")]
        public decimal? CorrespondentAdditionalLineAmount10 { get => _correspondentAdditionalLineAmount10; set => SetField(ref _correspondentAdditionalLineAmount10, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 11 [3608]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 11")]
        public decimal? CorrespondentAdditionalLineAmount11 { get => _correspondentAdditionalLineAmount11; set => SetField(ref _correspondentAdditionalLineAmount11, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 12 [3610]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 12")]
        public decimal? CorrespondentAdditionalLineAmount12 { get => _correspondentAdditionalLineAmount12; set => SetField(ref _correspondentAdditionalLineAmount12, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3970]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Total Amount")]
        public decimal? CorrespondentAdditionalLineAmount13 { get => _correspondentAdditionalLineAmount13; set => SetField(ref _correspondentAdditionalLineAmount13, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 2 [3590]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 2")]
        public decimal? CorrespondentAdditionalLineAmount2 { get => _correspondentAdditionalLineAmount2; set => SetField(ref _correspondentAdditionalLineAmount2, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 3 [3592]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 3")]
        public decimal? CorrespondentAdditionalLineAmount3 { get => _correspondentAdditionalLineAmount3; set => SetField(ref _correspondentAdditionalLineAmount3, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 4 [3594]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 4")]
        public decimal? CorrespondentAdditionalLineAmount4 { get => _correspondentAdditionalLineAmount4; set => SetField(ref _correspondentAdditionalLineAmount4, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 5 [3596]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 5")]
        public decimal? CorrespondentAdditionalLineAmount5 { get => _correspondentAdditionalLineAmount5; set => SetField(ref _correspondentAdditionalLineAmount5, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 6 [3598]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 6")]
        public decimal? CorrespondentAdditionalLineAmount6 { get => _correspondentAdditionalLineAmount6; set => SetField(ref _correspondentAdditionalLineAmount6, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 7 [3600]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 7")]
        public decimal? CorrespondentAdditionalLineAmount7 { get => _correspondentAdditionalLineAmount7; set => SetField(ref _correspondentAdditionalLineAmount7, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 8 [3602]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 8")]
        public decimal? CorrespondentAdditionalLineAmount8 { get => _correspondentAdditionalLineAmount8; set => SetField(ref _correspondentAdditionalLineAmount8, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 9 [3604]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Amount 9")]
        public decimal? CorrespondentAdditionalLineAmount9 { get => _correspondentAdditionalLineAmount9; set => SetField(ref _correspondentAdditionalLineAmount9, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 1 [3587]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 1")]
        public string CorrespondentAdditionalLineDescription1 { get => _correspondentAdditionalLineDescription1; set => SetField(ref _correspondentAdditionalLineDescription1, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 10 [3605]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 10")]
        public string CorrespondentAdditionalLineDescription10 { get => _correspondentAdditionalLineDescription10; set => SetField(ref _correspondentAdditionalLineDescription10, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 11 [3607]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 11")]
        public string CorrespondentAdditionalLineDescription11 { get => _correspondentAdditionalLineDescription11; set => SetField(ref _correspondentAdditionalLineDescription11, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 12 [3609]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 12")]
        public string CorrespondentAdditionalLineDescription12 { get => _correspondentAdditionalLineDescription12; set => SetField(ref _correspondentAdditionalLineDescription12, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 2 [3589]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 2")]
        public string CorrespondentAdditionalLineDescription2 { get => _correspondentAdditionalLineDescription2; set => SetField(ref _correspondentAdditionalLineDescription2, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 3 [3591]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 3")]
        public string CorrespondentAdditionalLineDescription3 { get => _correspondentAdditionalLineDescription3; set => SetField(ref _correspondentAdditionalLineDescription3, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 4 [3593]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 4")]
        public string CorrespondentAdditionalLineDescription4 { get => _correspondentAdditionalLineDescription4; set => SetField(ref _correspondentAdditionalLineDescription4, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 5 [3595]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 5")]
        public string CorrespondentAdditionalLineDescription5 { get => _correspondentAdditionalLineDescription5; set => SetField(ref _correspondentAdditionalLineDescription5, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 6 [3597]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 6")]
        public string CorrespondentAdditionalLineDescription6 { get => _correspondentAdditionalLineDescription6; set => SetField(ref _correspondentAdditionalLineDescription6, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 7 [3599]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 7")]
        public string CorrespondentAdditionalLineDescription7 { get => _correspondentAdditionalLineDescription7; set => SetField(ref _correspondentAdditionalLineDescription7, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 8 [3601]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 8")]
        public string CorrespondentAdditionalLineDescription8 { get => _correspondentAdditionalLineDescription8; set => SetField(ref _correspondentAdditionalLineDescription8, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Description 9 [3603]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Additional Description 9")]
        public string CorrespondentAdditionalLineDescription9 { get => _correspondentAdditionalLineDescription9; set => SetField(ref _correspondentAdditionalLineDescription9, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3611]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Additional Total Amount")]
        public decimal? CorrespondentAdditionalLineTotalAmount { get => _correspondentAdditionalLineTotalAmount; set => SetField(ref _correspondentAdditionalLineTotalAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 1 Amount [3573]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 1 Amount")]
        public decimal? CorrespondentAdjusterAmount1 { get => _correspondentAdjusterAmount1; set => SetField(ref _correspondentAdjusterAmount1, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 2 Amount [3575]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 2 Amount")]
        public decimal? CorrespondentAdjusterAmount2 { get => _correspondentAdjusterAmount2; set => SetField(ref _correspondentAdjusterAmount2, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 3 Amount [3577]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters 3 Amount")]
        public decimal? CorrespondentAdjusterAmount3 { get => _correspondentAdjusterAmount3; set => SetField(ref _correspondentAdjusterAmount3, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 1 Description [3572]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 1 Description")]
        public string CorrespondentAdjusterDescription1 { get => _correspondentAdjusterDescription1; set => SetField(ref _correspondentAdjusterDescription1, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 2 Description [3574]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 2 Description")]
        public string CorrespondentAdjusterDescription2 { get => _correspondentAdjusterDescription2; set => SetField(ref _correspondentAdjusterDescription2, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters 3 Description [3576]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Adjusters 3 Description")]
        public string CorrespondentAdjusterDescription3 { get => _correspondentAdjusterDescription3; set => SetField(ref _correspondentAdjusterDescription3, value); }

        /// <summary>
        /// Correspondent Purchase Advice Confirmed By [3612]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Confirmed By")]
        public string CorrespondentConfirmedBy { get => _correspondentConfirmedBy; set => SetField(ref _correspondentConfirmedBy, value); }

        /// <summary>
        /// Correspondent Purchase Advice Confirmed Date [3613]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Confirmed Date")]
        public DateTime? CorrespondentConfirmedDate { get => _correspondentConfirmedDate; set => SetField(ref _correspondentConfirmedDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Current Impounds [3568]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Current Impounds")]
        public decimal? CorrespondentCurrentImpounds { get => _correspondentCurrentImpounds; set => SetField(ref _correspondentCurrentImpounds, value); }

        /// <summary>
        /// Correspondent Purchase Advice Current Principal [3571]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Current Principal")]
        public decimal? CorrespondentCurrentPrincipal { get => _correspondentCurrentPrincipal; set => SetField(ref _correspondentCurrentPrincipal, value); }

        /// <summary>
        /// Correspondent Purchase Advice Date [3567]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Date")]
        public DateTime? CorrespondentDate { get => _correspondentDate; set => SetField(ref _correspondentDate, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1007 Amount [CPA.ESCROWDISBURSE.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1007 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1007 { get => _correspondentEscrowDisbursementsAmount1007; set => SetField(ref _correspondentEscrowDisbursementsAmount1007, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1008 Amount [CPA.ESCROWDISBURSE.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1008 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1008 { get => _correspondentEscrowDisbursementsAmount1008; set => SetField(ref _correspondentEscrowDisbursementsAmount1008, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1009 Amount [CPA.ESCROWDISBURSE.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Line 1009 Amount")]
        public decimal? CorrespondentEscrowDisbursementsAmount1009 { get => _correspondentEscrowDisbursementsAmount1009; set => SetField(ref _correspondentEscrowDisbursementsAmount1009, value); }

        /// <summary>
        /// Escrow Disbursements - City Property Tax [CPA.ESCROWDISBURSE.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - City Property Tax")]
        public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get => _correspondentEscrowDisbursementsCityPropertyTax; set => SetField(ref _correspondentEscrowDisbursementsCityPropertyTax, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1007 Description [CPA.ESCROWDISBURSE.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1007 Description")]
        public string CorrespondentEscrowDisbursementsDescription1007 { get => _correspondentEscrowDisbursementsDescription1007; set => SetField(ref _correspondentEscrowDisbursementsDescription1007, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1008 Description [CPA.ESCROWDISBURSE.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1008 Description")]
        public string CorrespondentEscrowDisbursementsDescription1008 { get => _correspondentEscrowDisbursementsDescription1008; set => SetField(ref _correspondentEscrowDisbursementsDescription1008, value); }

        /// <summary>
        /// Escrow Disbursements - Line 1009 Description [CPA.ESCROWDISBURSE.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Line 1009 Description")]
        public string CorrespondentEscrowDisbursementsDescription1009 { get => _correspondentEscrowDisbursementsDescription1009; set => SetField(ref _correspondentEscrowDisbursementsDescription1009, value); }

        /// <summary>
        /// Escrow Disbursements - Escrows to be paid by Seller [CPA.ESCROWDISBURSE.EscrowsToBePaidBySeller]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Escrows to be paid by Seller")]
        public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get => _correspondentEscrowDisbursementsEscrowsToBePaidBySeller; set => SetField(ref _correspondentEscrowDisbursementsEscrowsToBePaidBySeller, value); }

        /// <summary>
        /// Escrow Disbursements - Total Escrow Net Funded by Investor [CPA.ESCROWDISBURSE.EsrowFundedByInvestor]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Total Escrow Net Funded by Investor")]
        public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get => _correspondentEscrowDisbursementsEsrowFundedByInvestor; set => SetField(ref _correspondentEscrowDisbursementsEsrowFundedByInvestor, value); }

        /// <summary>
        /// Escrow Disbursements - Flood Insurance [CPA.ESCROWDISBURSE.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Flood Insurance")]
        public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get => _correspondentEscrowDisbursementsFloodInsurance; set => SetField(ref _correspondentEscrowDisbursementsFloodInsurance, value); }

        /// <summary>
        /// Escrow Disbursements - Homeowners Insurance [CPA.ESCROWDISBURSE.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Homeowners Insurance")]
        public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get => _correspondentEscrowDisbursementsHomeInsurance; set => SetField(ref _correspondentEscrowDisbursementsHomeInsurance, value); }

        /// <summary>
        /// Escrow Disbursements - Mortgage Insurance [CPA.ESCROWDISBURSE.MortgageInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Mortgage Insurance")]
        public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get => _correspondentEscrowDisbursementsMortgageInsurance; set => SetField(ref _correspondentEscrowDisbursementsMortgageInsurance, value); }

        /// <summary>
        /// Escrow Disbursements - Additional Amount Value 1 [CPA.ESCROWDISBURSE.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Additional Amount Value 1")]
        public decimal? CorrespondentEscrowDisbursementsOption1Amount { get => _correspondentEscrowDisbursementsOption1Amount; set => SetField(ref _correspondentEscrowDisbursementsOption1Amount, value); }

        /// <summary>
        /// Escrow Disbursements - Additional Amount Description 1 [CPA.ESCROWDISBURSE.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption1Desc { get => _correspondentEscrowDisbursementsOption1Desc; set => SetField(ref _correspondentEscrowDisbursementsOption1Desc, value); }

        /// <summary>
        /// Escrow Disbursements - Additional Amount Value 2 [CPA.ESCROWDISBURSE.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Additional Amount Value 2")]
        public decimal? CorrespondentEscrowDisbursementsOption2Amount { get => _correspondentEscrowDisbursementsOption2Amount; set => SetField(ref _correspondentEscrowDisbursementsOption2Amount, value); }

        /// <summary>
        /// Escrow Disbursements - Additional Amount Description 2 [CPA.ESCROWDISBURSE.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Disbursements - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption2Desc { get => _correspondentEscrowDisbursementsOption2Desc; set => SetField(ref _correspondentEscrowDisbursementsOption2Desc, value); }

        /// <summary>
        /// Escrow Disbursements - Property Tax [CPA.ESCROWDISBURSE.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - Property Tax")]
        public decimal? CorrespondentEscrowDisbursementsPropertyTax { get => _correspondentEscrowDisbursementsPropertyTax; set => SetField(ref _correspondentEscrowDisbursementsPropertyTax, value); }

        /// <summary>
        /// Escrow Disbursements - USDA Annual Fee [CPA.ESCROWDISBURSE.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Disbursements - USDA Annual Fee")]
        public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get => _correspondentEscrowDisbursementsUSDAAnnualFee; set => SetField(ref _correspondentEscrowDisbursementsUSDAAnnualFee, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Final Buy Amount [3583]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Final Buy Amount")]
        public decimal? CorrespondentFinalBuyAmount { get => _correspondentFinalBuyAmount; set => SetField(ref _correspondentFinalBuyAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters Final Buy Price [3578]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters Final Buy Price")]
        public decimal? CorrespondentFinalBuyPrice { get => _correspondentFinalBuyPrice; set => SetField(ref _correspondentFinalBuyPrice, value); }

        /// <summary>
        /// Final CD - Aggregate Adjustment Amount [CPA.FCD.AggAdjAmount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Aggregate Adjustment Amount")]
        public decimal? CorrespondentFinalCDAggAdjAmount { get => _correspondentFinalCDAggAdjAmount; set => SetField(ref _correspondentFinalCDAggAdjAmount, value); }

        /// <summary>
        /// Final CD - Line 1007 Amount [CPA.FCD.1007Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1007 Amount")]
        public decimal? CorrespondentFinalCDAmount1007 { get => _correspondentFinalCDAmount1007; set => SetField(ref _correspondentFinalCDAmount1007, value); }

        /// <summary>
        /// Final CD - Line 1008 Amount [CPA.FCD.1008Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1008 Amount")]
        public decimal? CorrespondentFinalCDAmount1008 { get => _correspondentFinalCDAmount1008; set => SetField(ref _correspondentFinalCDAmount1008, value); }

        /// <summary>
        /// Final CD - Line 1009 Amount [CPA.FCD.1009Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Line 1009 Amount")]
        public decimal? CorrespondentFinalCDAmount1009 { get => _correspondentFinalCDAmount1009; set => SetField(ref _correspondentFinalCDAmount1009, value); }

        /// <summary>
        /// Final CD - City Property Tax [CPA.FCD.CityPropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - City Property Tax")]
        public decimal? CorrespondentFinalCDCityPropertyTax { get => _correspondentFinalCDCityPropertyTax; set => SetField(ref _correspondentFinalCDCityPropertyTax, value); }

        /// <summary>
        /// Final CD - Line 1007 Description [CPA.FCD.1007Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1007 Description")]
        public string CorrespondentFinalCDDescription1007 { get => _correspondentFinalCDDescription1007; set => SetField(ref _correspondentFinalCDDescription1007, value); }

        /// <summary>
        /// Final CD - Line 1008 Description [CPA.FCD.1008Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1008 Description")]
        public string CorrespondentFinalCDDescription1008 { get => _correspondentFinalCDDescription1008; set => SetField(ref _correspondentFinalCDDescription1008, value); }

        /// <summary>
        /// Final CD - Line 1009 Description [CPA.FCD.1009Description]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Line 1009 Description")]
        public string CorrespondentFinalCDDescription1009 { get => _correspondentFinalCDDescription1009; set => SetField(ref _correspondentFinalCDDescription1009, value); }

        /// <summary>
        /// Final CD - Flood Insurance [CPA.FCD.FloodInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Flood Insurance")]
        public decimal? CorrespondentFinalCDFloodInsurance { get => _correspondentFinalCDFloodInsurance; set => SetField(ref _correspondentFinalCDFloodInsurance, value); }

        /// <summary>
        /// Final CD - Homeowners Insurance [CPA.FCD.HomeInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Homeowners Insurance")]
        public decimal? CorrespondentFinalCDHomeInsurance { get => _correspondentFinalCDHomeInsurance; set => SetField(ref _correspondentFinalCDHomeInsurance, value); }

        /// <summary>
        /// Final CD - Mortgage Insurance [CPA.FCD.MortgageInsurance]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Mortgage Insurance")]
        public decimal? CorrespondentFinalCDMortgageInsurance { get => _correspondentFinalCDMortgageInsurance; set => SetField(ref _correspondentFinalCDMortgageInsurance, value); }

        /// <summary>
        /// Final CD - Additional Amount Value 1 [CPA.FCD.Option1Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Additional Amount Value 1")]
        public decimal? CorrespondentFinalCDOption1Amount { get => _correspondentFinalCDOption1Amount; set => SetField(ref _correspondentFinalCDOption1Amount, value); }

        /// <summary>
        /// Final CD - Additional Amount Description 1 [CPA.FCD.Option1Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Additional Amount Description 1")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption1Desc { get => _correspondentFinalCDOption1Desc; set => SetField(ref _correspondentFinalCDOption1Desc, value); }

        /// <summary>
        /// Final CD - Additional Amount Value 2 [CPA.FCD.Option2Amount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Additional Amount Value 2")]
        public decimal? CorrespondentFinalCDOption2Amount { get => _correspondentFinalCDOption2Amount; set => SetField(ref _correspondentFinalCDOption2Amount, value); }

        /// <summary>
        /// Final CD - Additional Amount Description 2 [CPA.FCD.Option2Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Final CD - Additional Amount Description 2")]
        public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption2Desc { get => _correspondentFinalCDOption2Desc; set => SetField(ref _correspondentFinalCDOption2Desc, value); }

        /// <summary>
        /// Final CD - Property Tax [CPA.FCD.PropertyTax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Property Tax")]
        public decimal? CorrespondentFinalCDPropertyTax { get => _correspondentFinalCDPropertyTax; set => SetField(ref _correspondentFinalCDPropertyTax, value); }

        /// <summary>
        /// Final CD - Reservces Collected at Closing [CPA.FCD.ReservesCollectedAtClosing]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - Reservces Collected at Closing")]
        public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get => _correspondentFinalCDReservesCollectedAtClosing; set => SetField(ref _correspondentFinalCDReservesCollectedAtClosing, value); }

        /// <summary>
        /// Final CD - USDA Annual Fee [CPA.FCD.USDAAnnualFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Final CD - USDA Annual Fee")]
        public decimal? CorrespondentFinalCDUSDAAnnualFee { get => _correspondentFinalCDUSDAAnnualFee; set => SetField(ref _correspondentFinalCDUSDAAnnualFee, value); }

        /// <summary>
        /// Correspondent Purchase Advice First Payment Date [3570]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice First Payment Date")]
        public DateTime? CorrespondentFirstPaymentDate { get => _correspondentFirstPaymentDate; set => SetField(ref _correspondentFirstPaymentDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Impounds [3582]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Impounds")]
        public decimal? CorrespondentImpounds { get => _correspondentImpounds; set => SetField(ref _correspondentImpounds, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Interest [3580]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Interest")]
        public decimal? CorrespondentInterest { get => _correspondentInterest; set => SetField(ref _correspondentInterest, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Interest Days [3581]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Additional Purchase Details Interest Days")]
        public int? CorrespondentInterestDays { get => _correspondentInterestDays; set => SetField(ref _correspondentInterestDays, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Late Fee [3939]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Late Fee")]
        public decimal? CorrespondentLateFeeAmount { get => _correspondentLateFeeAmount; set => SetField(ref _correspondentLateFeeAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Adjusters Late Fee Price Adjustment [3938]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Correspondent Purchase Advice Additional Adjusters Late Fee Price Adjustment")]
        public decimal? CorrespondentLateFeePriceAdjustment { get => _correspondentLateFeePriceAdjustment; set => SetField(ref _correspondentLateFeePriceAdjustment, value); }

        /// <summary>
        /// Correspondent Purchase Advice Paid to Date [3569]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Paid to Date")]
        public DateTime? CorrespondentPaidToDate { get => _correspondentPaidToDate; set => SetField(ref _correspondentPaidToDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Anticipated Purchase Date [CPA.PaymentHistory.AnticipatedPurchaseDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator Anticipated Purchase Date")]
        public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get => _correspondentPaymentHistoryAnticipatedPurchaseDate; set => SetField(ref _correspondentPaymentHistoryAnticipatedPurchaseDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Calculated Purchased Principal [CPA.PaymentHistory.CalculatedPurchasedPrincipal]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Payment History Calculator Calculated Purchased Principal")]
        public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get => _correspondentPaymentHistoryCalculatedPurchasedPrincipal; set => SetField(ref _correspondentPaymentHistoryCalculatedPurchasedPrincipal, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator 1st Payment Due from Borrower  [CPA.PaymentHistory.FirstBorrowerPaymentDueDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator 1st Payment Due from Borrower ")]
        public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get => _correspondentPaymentHistoryFirstBorrowerPaymentDueDate; set => SetField(ref _correspondentPaymentHistoryFirstBorrowerPaymentDueDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator ◦1st Payment Due to Investor [CPA.PaymentHistory.FirstInvestorPaymentDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator ◦1st Payment Due to Investor")]
        public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get => _correspondentPaymentHistoryFirstInvestorPaymentDate; set => SetField(ref _correspondentPaymentHistoryFirstInvestorPaymentDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator Note Date [CPA.PaymentHistory.NoteDate]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Payment History Calculator Note Date")]
        public DateTime? CorrespondentPaymentHistoryNoteDate { get => _correspondentPaymentHistoryNoteDate; set => SetField(ref _correspondentPaymentHistoryNoteDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Payment History Calculator principal reduction prior to 1st payment date [CPA.PaymentHistory.PricipalReduction]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Payment History Calculator principal reduction prior to 1st payment date")]
        public decimal? CorrespondentPaymentHistoryPricipalReduction { get => _correspondentPaymentHistoryPricipalReduction; set => SetField(ref _correspondentPaymentHistoryPricipalReduction, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Purchased Principal [3579]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Purchased Principal")]
        public decimal? CorrespondentPurchasedPrincipal { get => _correspondentPurchasedPrincipal; set => SetField(ref _correspondentPurchasedPrincipal, value); }

        /// <summary>
        /// Correspondent Purchase Advice Reconcilation Comments [3586]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Reconcilation Comments")]
        public string CorrespondentReconcilationComments { get => _correspondentReconcilationComments; set => SetField(ref _correspondentReconcilationComments, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Remaining Buydown Amount [3585]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Remaining Buydown Amount")]
        public decimal? CorrespondentRemainingBuydownAmount { get => _correspondentRemainingBuydownAmount; set => SetField(ref _correspondentRemainingBuydownAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details SRP Amount [3584]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details SRP Amount")]
        public decimal? CorrespondentSRPAmount { get => _correspondentSRPAmount; set => SetField(ref _correspondentSRPAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Total Buy Amount [4191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Total Buy Amount")]
        public decimal? CorrespondentTotalBuyAmount { get => _correspondentTotalBuyAmount; set => SetField(ref _correspondentTotalBuyAmount, value); }

        /// <summary>
        /// Correspondent Purchase Advice Additional Purchase Details Total Fees  [4192]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Purchase Advice Additional Purchase Details Total Fees ")]
        public decimal? CorrespondentTotalFees { get => _correspondentTotalFees; set => SetField(ref _correspondentTotalFees, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank ABA Number [3945]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank ABA Number")]
        public string CorrespondentWarehouseBankABANum { get => _correspondentWarehouseBankABANum; set => SetField(ref _correspondentWarehouseBankABANum, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Account Name [4202]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Account Name")]
        public string CorrespondentWarehouseBankAcctName { get => _correspondentWarehouseBankAcctName; set => SetField(ref _correspondentWarehouseBankAcctName, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Account Number [3944]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Account Number")]
        public string CorrespondentWarehouseBankAcctNum { get => _correspondentWarehouseBankAcctNum; set => SetField(ref _correspondentWarehouseBankAcctNum, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Address [3948]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Address")]
        public string CorrespondentWarehouseBankAddress { get => _correspondentWarehouseBankAddress; set => SetField(ref _correspondentWarehouseBankAddress, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Address1 [3949]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Address1")]
        public string CorrespondentWarehouseBankAddress1 { get => _correspondentWarehouseBankAddress1; set => SetField(ref _correspondentWarehouseBankAddress1, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Expiration Date [3956]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Expiration Date")]
        public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get => _correspondentWarehouseBankBaileeExpirationDate; set => SetField(ref _correspondentWarehouseBankBaileeExpirationDate, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Received Indicator [3947]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Letter Received Indicator")]
        public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get => _correspondentWarehouseBankBaileeLetterReceivedIndicator; set => SetField(ref _correspondentWarehouseBankBaileeLetterReceivedIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Required Indicator [3955]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Bailee Letter Required Indicator")]
        public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get => _correspondentWarehouseBankBaileeLetterReqIndicator; set => SetField(ref _correspondentWarehouseBankBaileeLetterReqIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank City [3950]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank City")]
        public string CorrespondentWarehouseBankCity { get => _correspondentWarehouseBankCity; set => SetField(ref _correspondentWarehouseBankCity, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Email [3959]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Contact Email")]
        public string CorrespondentWarehouseBankContactEmail { get => _correspondentWarehouseBankContactEmail; set => SetField(ref _correspondentWarehouseBankContactEmail, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Fax Number [3961]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Correspondent Purchase Advice Warehouse Bank Contact Fax Number")]
        public string CorrespondentWarehouseBankContactFax { get => _correspondentWarehouseBankContactFax; set => SetField(ref _correspondentWarehouseBankContactFax, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Contact Name [3958]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Contact Name")]
        public string CorrespondentWarehouseBankContactName { get => _correspondentWarehouseBankContactName; set => SetField(ref _correspondentWarehouseBankContactName, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Contact Phone Number [3960]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Correspondent Purchase Advice Warehouse Bank Contact Phone Number")]
        public string CorrespondentWarehouseBankContactPhone { get => _correspondentWarehouseBankContactPhone; set => SetField(ref _correspondentWarehouseBankContactPhone, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Description [3953]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Description")]
        public string CorrespondentWarehouseBankDescription { get => _correspondentWarehouseBankDescription; set => SetField(ref _correspondentWarehouseBankDescription, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Further Credit Account Name [4204]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Further Credit Account Name")]
        public string CorrespondentWarehouseBankFurtherCreditAcctName { get => _correspondentWarehouseBankFurtherCreditAcctName; set => SetField(ref _correspondentWarehouseBankFurtherCreditAcctName, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Further Credit Account Number [4203]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Further Credit Account Number")]
        public string CorrespondentWarehouseBankFurtherCreditAcctNum { get => _correspondentWarehouseBankFurtherCreditAcctNum; set => SetField(ref _correspondentWarehouseBankFurtherCreditAcctNum, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank ID  [3964]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank ID ")]
        public int? CorrespondentWarehouseBankId { get => _correspondentWarehouseBankId; set => SetField(ref _correspondentWarehouseBankId, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Name  [3943]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Name ")]
        public string CorrespondentWarehouseBankName { get => _correspondentWarehouseBankName; set => SetField(ref _correspondentWarehouseBankName, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Note [3962]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Note")]
        public string CorrespondentWarehouseBankNotes { get => _correspondentWarehouseBankNotes; set => SetField(ref _correspondentWarehouseBankNotes, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Self - Funder Indicator [3954]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Self - Funder Indicator")]
        public bool? CorrespondentWarehouseBankSelfFunderIndicator { get => _correspondentWarehouseBankSelfFunderIndicator; set => SetField(ref _correspondentWarehouseBankSelfFunderIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank State [3951]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank State")]
        public StringEnumValue<State> CorrespondentWarehouseBankState { get => _correspondentWarehouseBankState; set => SetField(ref _correspondentWarehouseBankState, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Tri - Party Contract Indicator [3957]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Tri - Party Contract Indicator")]
        public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get => _correspondentWarehouseBankTriPartyContractIndicator; set => SetField(ref _correspondentWarehouseBankTriPartyContractIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Use Default Contact Indicator [3963]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Use Default Contact Indicator")]
        public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get => _correspondentWarehouseBankUseDefaultContactIndicator; set => SetField(ref _correspondentWarehouseBankUseDefaultContactIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Wire Confirmation # [4190]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Wire Confirmation #")]
        public string CorrespondentWarehouseBankWireConfirmationNumber { get => _correspondentWarehouseBankWireConfirmationNumber; set => SetField(ref _correspondentWarehouseBankWireConfirmationNumber, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Wire Instructions Received Indicator [3946]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Purchase Advice Warehouse Bank Wire Instructions Received Indicator")]
        public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get => _correspondentWarehouseBankWireInstructionsReceivedIndicator; set => SetField(ref _correspondentWarehouseBankWireInstructionsReceivedIndicator, value); }

        /// <summary>
        /// Correspondent Purchase Advice Warehouse Bank Zip Code [3952]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Correspondent Purchase Advice Warehouse Bank Zip Code")]
        public string CorrespondentWarehouseBankZip { get => _correspondentWarehouseBankZip; set => SetField(ref _correspondentWarehouseBankZip, value); }

        /// <summary>
        /// RateLock CreditScoreToUse
        /// </summary>
        public string CreditScoreToUse { get => _creditScoreToUse; set => SetField(ref _creditScoreToUse, value); }

        /// <summary>
        /// Rate Lock Cumulated Days to Extend [3431]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Cumulated Days to Extend")]
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }

        /// <summary>
        /// Initial Acquisition of Land [4254]
        /// </summary>
        [LoanFieldProperty(Description = "Initial Acquisition of Land")]
        public bool? CurrentAcquisition { get => _currentAcquisition; set => SetField(ref _currentAcquisition, value); }

        /// <summary>
        /// RateLock CurrentAdjustments
        /// </summary>
        public IList<PriceAdjustment> CurrentAdjustments { get => GetField(ref _currentAdjustments); set => SetField(ref _currentAdjustments, value); }

        /// <summary>
        /// Rate Lock Current Comments [2035]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Current Comments")]
        public string CurrentComments { get => _currentComments; set => SetField(ref _currentComments, value); }

        /// <summary>
        /// Construction Refinance Indicator [4255]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Refinance Indicator")]
        public bool? CurrentConstructionRefi { get => _currentConstructionRefi; set => SetField(ref _currentConstructionRefi, value); }

        /// <summary>
        /// Rate Lock Current Lock Date [2145]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Date")]
        public DateTime? CurrentLockDate { get => _currentLockDate; set => SetField(ref _currentLockDate, value); }

        /// <summary>
        /// Rate Lock Current Lock Expires Date [2147]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Expires Date")]
        public DateTime? CurrentLockExpires { get => _currentLockExpires; set => SetField(ref _currentLockExpires, value); }

        /// <summary>
        /// Rate Lock Current Base Margin Rate [2690]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Rate")]
        public decimal? CurrentMarginRate { get => _currentMarginRate; set => SetField(ref _currentMarginRate, value); }

        /// <summary>
        /// Rate Lock Current Base Margin Rate Requested [2732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Rate Requested")]
        public decimal? CurrentMarginRateRequested { get => _currentMarginRateRequested; set => SetField(ref _currentMarginRateRequested, value); }

        /// <summary>
        /// Rate Lock Current Base Margin Total Adjustment [2731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Margin Total Adjustment")]
        public decimal? CurrentMarginTotalAdjustment { get => _currentMarginTotalAdjustment; set => SetField(ref _currentMarginTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Current Number of Days [2146]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Number of Days")]
        public int? CurrentNumberOfDays { get => _currentNumberOfDays; set => SetField(ref _currentNumberOfDays, value); }

        /// <summary>
        /// Rate Lock Current Base Price Rate [2045]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Rate")]
        public decimal? CurrentPriceRate { get => _currentPriceRate; set => SetField(ref _currentPriceRate, value); }

        /// <summary>
        /// Rate Lock Current Base Price Rate Requested [2087]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Rate Requested")]
        public decimal? CurrentPriceRateRequested { get => _currentPriceRateRequested; set => SetField(ref _currentPriceRateRequested, value); }

        /// <summary>
        /// Rate Lock Current Base Price Tot Adjustment [2086]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true, Description = "Rate Lock Current Base Price Tot Adjustment")]
        public decimal? CurrentPriceTotalAdjustment { get => _currentPriceTotalAdjustment; set => SetField(ref _currentPriceTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Current Base Rate [2036]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate")]
        public decimal? CurrentRate { get => _currentRate; set => SetField(ref _currentRate, value); }

        /// <summary>
        /// Rate Lock Current Base Rate Requested [2044]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate Requested")]
        public decimal? CurrentRateRequested { get => _currentRateRequested; set => SetField(ref _currentRateRequested, value); }

        /// <summary>
        /// Rate Lock Current Lock Last Rate Set Date [3255]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Current Lock Last Rate Set Date")]
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => SetField(ref _currentRateSetDate, value); }

        /// <summary>
        /// Rate Lock Current Rate Sheet ID [2034]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Current Rate Sheet ID")]
        public string CurrentRateSheetID { get => _currentRateSheetID; set => SetField(ref _currentRateSheetID, value); }

        /// <summary>
        /// Rate Lock Current Base Rate Tot Adjustment [2043]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Rate Lock Current Base Rate Tot Adjustment")]
        public decimal? CurrentRateTotalAdjustment { get => _currentRateTotalAdjustment; set => SetField(ref _currentRateTotalAdjustment, value); }

        /// <summary>
        /// Purchase Advice Date [2370]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Date")]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// Purchase Advice Date First Payment to Investor [3514]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Date First Payment to Investor")]
        public DateTime? DateFirstPaymentToInvestor { get => _dateFirstPaymentToInvestor; set => SetField(ref _dateFirstPaymentToInvestor, value); }

        /// <summary>
        /// Rate Lock Sell Side Date Locked with Investor [2291]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Date Locked with Investor")]
        public DateTime? DateLockedWithInvestor { get => _dateLockedWithInvestor; set => SetField(ref _dateLockedWithInvestor, value); }

        /// <summary>
        /// Date Sold to Third Party [3337]
        /// </summary>
        [LoanFieldProperty(Description = "Date Sold to Third Party")]
        public DateTime? DateSold { get => _dateSold; set => SetField(ref _dateSold, value); }

        /// <summary>
        /// Date Warehoused [3341]
        /// </summary>
        [LoanFieldProperty(Description = "Date Warehoused")]
        public DateTime? DateWarehoused { get => _dateWarehoused; set => SetField(ref _dateWarehoused, value); }

        /// <summary>
        /// RateLock DaysToExtend
        /// </summary>
        public int? DaysToExtend { get => _daysToExtend; set => SetField(ref _daysToExtend, value); }

        /// <summary>
        /// Rate Lock Request Delivery Type [3965]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Delivery Type")]
        public string DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }

        /// <summary>
        /// Purchase Advice Amt Rcvd Dif [2624]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Amt Rcvd Dif")]
        public decimal? DiffAmountReceived { get => _diffAmountReceived; set => SetField(ref _diffAmountReceived, value); }

        /// <summary>
        /// Purchase Adv Impounds Difference [2839]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Adv Impounds Difference")]
        public decimal? DiffImpounds { get => _diffImpounds; set => SetField(ref _diffImpounds, value); }

        /// <summary>
        /// Purchase Adv Interest Difference [2838]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Adv Interest Difference")]
        public decimal? DiffInterest { get => _diffInterest; set => SetField(ref _diffInterest, value); }

        /// <summary>
        /// Purchase Advice Premium Dif [2610]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Premium Dif")]
        public decimal? DiffPremium { get => _diffPremium; set => SetField(ref _diffPremium, value); }

        /// <summary>
        /// Purchase Advice Principal Dif [2609]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Principal Dif")]
        public decimal? DiffPrinciple { get => _diffPrinciple; set => SetField(ref _diffPrinciple, value); }

        /// <summary>
        /// Purch Adv Remaining Buydown Funds Dif. [3132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purch Adv Remaining Buydown Funds Dif.")]
        public decimal? DiffRemainingBuydownFunds { get => _diffRemainingBuydownFunds; set => SetField(ref _diffRemainingBuydownFunds, value); }

        /// <summary>
        /// Purchase Advice Diff Sell Amount [3425]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Diff Sell Amount")]
        public decimal? DiffSellAmount { get => _diffSellAmount; set => SetField(ref _diffSellAmount, value); }

        /// <summary>
        /// Purchase Advice Diff Sell Price [3423]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true, Description = "Purchase Advice Diff Sell Price")]
        public decimal? DiffSellPrice { get => _diffSellPrice; set => SetField(ref _diffSellPrice, value); }

        /// <summary>
        /// Purchase Advice Diff Sell Side SRP [3427]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true, Description = "Purchase Advice Diff Sell Side SRP")]
        public decimal? DiffSellSideSRP { get => _diffSellSideSRP; set => SetField(ref _diffSellSideSRP, value); }

        /// <summary>
        /// Purchase Advice SRP Received Dif [2611]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice SRP Received Dif")]
        public decimal? DiffSRP { get => _diffSRP; set => SetField(ref _diffSRP, value); }

        /// <summary>
        /// Purchase Advice Diff SRP Amount [3429]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Diff SRP Amount")]
        public decimal? DiffSRPAmount { get => _diffSRPAmount; set => SetField(ref _diffSRPAmount, value); }

        /// <summary>
        /// Lock Request Borr Self Employed [3516]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator1 { get => _employmentBorrowerSelfEmployedIndicator1; set => SetField(ref _employmentBorrowerSelfEmployedIndicator1, value); }

        /// <summary>
        /// Lock Request Co-Mort8 Self Employed [3525]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort8 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator10 { get => _employmentBorrowerSelfEmployedIndicator10; set => SetField(ref _employmentBorrowerSelfEmployedIndicator10, value); }

        /// <summary>
        /// Lock Request Co-Mort9 Self Employed [3526]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort9 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator11 { get => _employmentBorrowerSelfEmployedIndicator11; set => SetField(ref _employmentBorrowerSelfEmployedIndicator11, value); }

        /// <summary>
        /// Lock Request Co-Mort10 Self Employed [3527]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort10 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator12 { get => _employmentBorrowerSelfEmployedIndicator12; set => SetField(ref _employmentBorrowerSelfEmployedIndicator12, value); }

        /// <summary>
        /// Lock Request Co-Borr Self Employed [3517]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Borr Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator2 { get => _employmentBorrowerSelfEmployedIndicator2; set => SetField(ref _employmentBorrowerSelfEmployedIndicator2, value); }

        /// <summary>
        /// Lock Request Co-Mort1 Self Employed [3518]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort1 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator3 { get => _employmentBorrowerSelfEmployedIndicator3; set => SetField(ref _employmentBorrowerSelfEmployedIndicator3, value); }

        /// <summary>
        /// Lock Request Co-Mort2 Self Employed [3519]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort2 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator4 { get => _employmentBorrowerSelfEmployedIndicator4; set => SetField(ref _employmentBorrowerSelfEmployedIndicator4, value); }

        /// <summary>
        /// Lock Request Co-Mort3 Self Employed [3520]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort3 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator5 { get => _employmentBorrowerSelfEmployedIndicator5; set => SetField(ref _employmentBorrowerSelfEmployedIndicator5, value); }

        /// <summary>
        /// Lock Request Co-Mort4 Self Employed [3521]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort4 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator6 { get => _employmentBorrowerSelfEmployedIndicator6; set => SetField(ref _employmentBorrowerSelfEmployedIndicator6, value); }

        /// <summary>
        /// Lock Request Co-Mort5 Self Employed [3522]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort5 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator7 { get => _employmentBorrowerSelfEmployedIndicator7; set => SetField(ref _employmentBorrowerSelfEmployedIndicator7, value); }

        /// <summary>
        /// Lock Request Co-Mort6 Self Employed [3523]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort6 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator8 { get => _employmentBorrowerSelfEmployedIndicator8; set => SetField(ref _employmentBorrowerSelfEmployedIndicator8, value); }

        /// <summary>
        /// Lock Request Co-Mort7 Self Employed [3524]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Mort7 Self Employed")]
        public bool? EmploymentBorrowerSelfEmployedIndicator9 { get => _employmentBorrowerSelfEmployedIndicator9; set => SetField(ref _employmentBorrowerSelfEmployedIndicator9, value); }

        /// <summary>
        /// Purchase Advice Expctd Amt Rcvd [2608]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Expctd Amt Rcvd")]
        public decimal? ExpectedAmountReceived { get => _expectedAmountReceived; set => SetField(ref _expectedAmountReceived, value); }

        /// <summary>
        /// Purchase Adv Expected Impounds Transfer [2837]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Expected Impounds Transfer")]
        public decimal? ExpectedImpounds { get => _expectedImpounds; set => SetField(ref _expectedImpounds, value); }

        /// <summary>
        /// Purchase Adv Expected Int Pymt from Investor [2836]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Expected Int Pymt from Investor")]
        public decimal? ExpectedInterest { get => _expectedInterest; set => SetField(ref _expectedInterest, value); }

        /// <summary>
        /// Purchase Advice Expctd Premium [2594]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd Premium")]
        public decimal? ExpectedPremium { get => _expectedPremium; set => SetField(ref _expectedPremium, value); }

        /// <summary>
        /// Purchase Advice Expctd Principal [2593]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd Principal")]
        public decimal? ExpectedPrinciple { get => _expectedPrinciple; set => SetField(ref _expectedPrinciple, value); }

        /// <summary>
        /// Purch Adv Expctd Remaining Buydown Funds [3130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purch Adv Expctd Remaining Buydown Funds")]
        public decimal? ExpectedRemainingBuydownFunds { get => _expectedRemainingBuydownFunds; set => SetField(ref _expectedRemainingBuydownFunds, value); }

        /// <summary>
        /// Purchase Advice Expctd SRP Received [2595]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Expctd SRP Received")]
        public decimal? ExpectedSRP { get => _expectedSRP; set => SetField(ref _expectedSRP, value); }

        /// <summary>
        /// RateLock ExtensionRequestPending
        /// </summary>
        public string ExtensionRequestPending { get => _extensionRequestPending; set => SetField(ref _extensionRequestPending, value); }

        /// <summary>
        /// Rate Lock Extension Sequence Number [3433]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Extension Sequence Number")]
        public int? ExtensionSequenceNumber { get => _extensionSequenceNumber; set => SetField(ref _extensionSequenceNumber, value); }

        /// <summary>
        /// RateLock ExtraPayments
        /// </summary>
        public IList<ExtraPayment> ExtraPayments { get => GetField(ref _extraPayments); set => SetField(ref _extraPayments, value); }

        /// <summary>
        /// Lock Request MI Premium/Funding Fee % [3044]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Lock Request MI Premium/Funding Fee %")]
        public decimal? FHAUpfrontMIPremiumPercent { get => _fHAUpfrontMIPremiumPercent; set => SetField(ref _fHAUpfrontMIPremiumPercent, value); }

        /// <summary>
        /// Lock Request Subject Property # Units [3529]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property # Units")]
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => SetField(ref _financedNumberOfUnits, value); }

        /// <summary>
        /// Purchase Advice First Payment To [2371]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice First Payment To")]
        public StringEnumValue<PartyType> FirstPaymenTo { get => _firstPaymenTo; set => SetField(ref _firstPaymenTo, value); }

        /// <summary>
        /// Lock Request First Subordinate Amount [3035]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request First Subordinate Amount")]
        public decimal? FirstSubordinateAmount { get => _firstSubordinateAmount; set => SetField(ref _firstSubordinateAmount, value); }

        /// <summary>
        /// Lock Request Borr First Time Homebuyer [3528]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr First Time Homebuyer")]
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => SetField(ref _firstTimeHomebuyersIndicator, value); }

        /// <summary>
        /// Lock Request Amort Type ARM Descr [2956]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type ARM Descr")]
        public string FNMProductPlanIdentifier { get => _fNMProductPlanIdentifier; set => SetField(ref _fNMProductPlanIdentifier, value); }

        /// <summary>
        /// Lock Request MI Premium/Funding Amnt [3045]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request MI Premium/Funding Amnt")]
        public decimal? FundingAmount { get => _fundingAmount; set => SetField(ref _fundingAmount, value); }

        /// <summary>
        /// Rate Lock Sell Side Gain Loss Percent [2296]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Gain Loss Percent")]
        public decimal? GainLossPercentage { get => _gainLossPercentage; set => SetField(ref _gainLossPercentage, value); }

        /// <summary>
        /// Rate Lock Sell Side Gain Loss Price [2028]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Gain Loss Price")]
        public decimal? GainLossPrice { get => _gainLossPrice; set => SetField(ref _gainLossPrice, value); }

        /// <summary>
        /// Rate Lock Sell Side Total Sell Price [2295]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Total Sell Price")]
        public decimal? GainLossTotalBuyPrice { get => _gainLossTotalBuyPrice; set => SetField(ref _gainLossTotalBuyPrice, value); }

        /// <summary>
        /// Lock Request Amort Type GPM Rate [2954]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Amort Type GPM Rate")]
        public decimal? GPMRate { get => _gPMRate; set => SetField(ref _gPMRate, value); }

        /// <summary>
        /// Lock Request Amort Type GPM Years [2955]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type GPM Years")]
        public int? GPMYears { get => _gPMYears; set => SetField(ref _gPMYears, value); }

        /// <summary>
        /// Lock Request Subject Property Type [2947]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Type")]
        public StringEnumValue<PropertyType> GSEPropertyType { get => _gSEPropertyType; set => SetField(ref _gSEPropertyType, value); }

        /// <summary>
        /// Rate Lock Hedging [2401]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Hedging", OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public StringEnumValue<YOrN> Hedging { get => _hedging; set => SetField(ref _hedging, value); }

        /// <summary>
        /// Lock Request Freddie Mac HELOC Actual Bal [3846]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Freddie Mac HELOC Actual Bal")]
        public string HELOCActualBalance { get => _hELOCActualBalance; set => SetField(ref _hELOCActualBalance, value); }

        /// <summary>
        /// RateLock Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Purchase Adv Actual Impounds Transfer [2835]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Actual Impounds Transfer")]
        public decimal? Impounds { get => _impounds; set => SetField(ref _impounds, value); }

        /// <summary>
        /// Trans Details Impound Types [2294]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Impound Types")]
        public StringEnumValue<ImpoundType> ImpoundType { get => _impoundType; set => SetField(ref _impoundType, value); }

        /// <summary>
        /// RateLock ImpoundWaived
        /// </summary>
        public string ImpoundWaived { get => _impoundWaived; set => SetField(ref _impoundWaived, value); }

        /// <summary>
        /// Trans Details Impounds Waived [2293]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Impounds Waived")]
        public StringEnumValue<ImpoundWaived> ImpoundWavied { get => _impoundWavied; set => SetField(ref _impoundWavied, value); }

        /// <summary>
        /// Purchase Adv Actual Interest Payment from Investor [2834]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Adv Actual Interest Payment from Investor")]
        public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Address [2281]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Address")]
        public string InvestorAddress { get => _investorAddress; set => SetField(ref _investorAddress, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor City [2282]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor City")]
        public string InvestorCity { get => _investorCity; set => SetField(ref _investorCity, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Commitment [2286]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Commitment")]
        public string InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Contact [2279]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Contact")]
        public string InvestorContact { get => _investorContact; set => SetField(ref _investorContact, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Delivery Date [2297]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Delivery Date")]
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => SetField(ref _investorDeliveryDate, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Email [3055]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Email")]
        public string InvestorEmail { get => _investorEmail; set => SetField(ref _investorEmail, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Loan Number [2288]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Loan Number")]
        public string InvestorLoanNumber { get => _investorLoanNumber; set => SetField(ref _investorLoanNumber, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Lock Type [2287]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Lock Type")]
        public string InvestorLockType { get => _investorLockType; set => SetField(ref _investorLockType, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor MERS Number [2290]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor MERS Number")]
        public string InvestorMERSNumber { get => _investorMERSNumber; set => SetField(ref _investorMERSNumber, value); }

        /// <summary>
        /// Rate Lock Sell Investor Name [2278]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Investor Name")]
        public string InvestorName { get => _investorName; set => SetField(ref _investorName, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Phone [2280]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Rate Lock Sell Side Investor Phone")]
        public string InvestorPhone { get => _investorPhone; set => SetField(ref _investorPhone, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Zipcode [2284]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Rate Lock Sell Side Investor Zipcode")]
        public string InvestorPostalCode { get => _investorPostalCode; set => SetField(ref _investorPostalCode, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Program Code [2289]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Program Code")]
        public string InvestorProgramCode { get => _investorProgramCode; set => SetField(ref _investorProgramCode, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor State [2283]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor State")]
        public StringEnumValue<State> InvestorState { get => _investorState; set => SetField(ref _investorState, value); }

        /// <summary>
        /// Rate Lock Sell Side Target Delivery Date [2206]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Target Delivery Date")]
        public DateTime? InvestorTargetDeliveryDate { get => _investorTargetDeliveryDate; set => SetField(ref _investorTargetDeliveryDate, value); }

        /// <summary>
        /// Rate Lock Sell Investor Template Name [3263]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Investor Template Name")]
        public string InvestorTemplateName { get => _investorTemplateName; set => SetField(ref _investorTemplateName, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Website [2285]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Investor Website")]
        public string InvestorWebsite { get => _investorWebsite; set => SetField(ref _investorWebsite, value); }

        /// <summary>
        /// RateLock IsCancelled
        /// </summary>
        public string IsCancelled { get => _isCancelled; set => SetField(ref _isCancelled, value); }

        /// <summary>
        /// Rate Lock Request Delivery Type is Visible [3966]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Delivery Type is Visible")]
        public bool? IsDeliveryType { get => _isDeliveryType; set => SetField(ref _isDeliveryType, value); }

        /// <summary>
        /// Rate Lock Request Lender Fee Waiver Option [4459]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lender Fee Waiver Option")]
        public bool? LenderFeeWaiverOption { get => _lenderFeeWaiverOption; set => SetField(ref _lenderFeeWaiverOption, value); }

        /// <summary>
        /// Lock Request Lender Paid Mortgage Insurance [3628]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Lender Paid Mortgage Insurance")]
        public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => SetField(ref _lenderPaidMortgageInsuranceIndicator, value); }

        /// <summary>
        /// Lock Request Lein Position [2958]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Lein Position")]
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }

        /// <summary>
        /// Lock Request Term Months [2959]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Term Months")]
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => SetField(ref _loanAmortizationTermMonths, value); }

        /// <summary>
        /// Lock Request Amort Type [2953]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type")]
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }

        /// <summary>
        /// Lock Request Doc Type [2867]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Doc Type")]
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }

        /// <summary>
        /// Lock Request HUD 92900 LT Loan for 203K [3844]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request HUD 92900 LT Loan for 203K")]
        public bool? LoanFor203K { get => _loanFor203K; set => SetField(ref _loanFor203K, value); }

        /// <summary>
        /// Lock Request Loan Program [2866]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Program")]
        public string LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

        /// <summary>
        /// Lock Request Loan Program File [2967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Lock Request Loan Program File")]
        public string LoanProgramFile { get => _loanProgramFile; set => SetField(ref _loanProgramFile, value); }

        /// <summary>
        /// Lock Request Est Closing Date [2966]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Est Closing Date")]
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => SetField(ref _loanScheduledClosingDate, value); }

        /// <summary>
        /// Lock Request MI Premium/Funding Lock [3046]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request MI Premium/Funding Lock")]
        public bool? LockField { get => _lockField; set => SetField(ref _lockField, value); }

        /// <summary>
        /// RateLock LockRequestAdjustments
        /// </summary>
        public IList<PriceAdjustment> LockRequestAdjustments { get => GetField(ref _lockRequestAdjustments); set => SetField(ref _lockRequestAdjustments, value); }

        /// <summary>
        /// RateLock LockRequestBorrowers
        /// </summary>
        public IList<LockRequestBorrower> LockRequestBorrowers { get => GetField(ref _lockRequestBorrowers); set => SetField(ref _lockRequestBorrowers, value); }

        /// <summary>
        /// Lock Request Loan Purpose [2951]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Purpose")]
        public StringEnumValue<LockRequestLoanPurposeType> LockRequestLoanPurposeType { get => _lockRequestLoanPurposeType; set => SetField(ref _lockRequestLoanPurposeType, value); }

        /// <summary>
        /// Lock Request Loan to Value (LTV) [3241]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Lock Request Loan to Value (LTV)")]
        public decimal? LTV { get => _lTV; set => SetField(ref _lTV, value); }

        /// <summary>
        /// Lock Request Borr Minimum FICO Score [2940]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borr Minimum FICO Score")]
        public string MinFICO { get => _minFICO; set => SetField(ref _minFICO, value); }

        /// <summary>
        /// Lock Request Co-Borr Minimum FICO Score [2941]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Co-Borr Minimum FICO Score")]
        public string MinFICO2 { get => _minFICO2; set => SetField(ref _minFICO2, value); }

        /// <summary>
        /// Lock Request Upfont MI Premium/Funding Amt Paid in Cash [3047]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Upfont MI Premium/Funding Amt Paid in Cash")]
        public decimal? MIPPaidInCash { get => _mIPPaidInCash; set => SetField(ref _mIPPaidInCash, value); }

        /// <summary>
        /// Lock Request Loan Type [2952]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Loan Type")]
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

        /// <summary>
        /// Purchase Advice Sell Amount [2208]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Sell Amount")]
        public decimal? NetSellAmount { get => _netSellAmount; set => SetField(ref _netSellAmount, value); }

        /// <summary>
        /// Purchase Advice Net Sell Price [2207]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Net Sell Price")]
        public decimal? NetSellPrice { get => _netSellPrice; set => SetField(ref _netSellPrice, value); }

        /// <summary>
        /// Purchase Advice Next Payment Date [2397]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Advice Next Payment Date")]
        public DateTime? NextPaymentDate { get => _nextPaymentDate; set => SetField(ref _nextPaymentDate, value); }

        /// <summary>
        /// Rate Lock Request No Closing Cost Option [3892]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request No Closing Cost Option")]
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => SetField(ref _noClosingCostOption, value); }

        /// <summary>
        /// Locked during ONRP Window [4057]
        /// </summary>
        [LoanFieldProperty(Description = "Locked during ONRP Window", OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
        public StringEnumValue<YOrN> ONRPLock { get => _oNRPLock; set => SetField(ref _oNRPLock, value); }

        /// <summary>
        /// Lock Request Amort Type Other Descr [2957]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Amort Type Other Descr")]
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }

        /// <summary>
        /// Lock Request Other Subordinate Amount [3037]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Other Subordinate Amount")]
        public decimal? OtherSubordinateAmount { get => _otherSubordinateAmount; set => SetField(ref _otherSubordinateAmount, value); }

        /// <summary>
        /// Trans Details Penalty Term [2217]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Penalty Term")]
        public StringEnumValue<PenaltyTerm> PenaltyTerm { get => _penaltyTerm; set => SetField(ref _penaltyTerm, value); }

        /// <summary>
        /// Purchase Adv Interest Calcuation - Per Diem Interest Rounding [3550]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Interest Calcuation - Per Diem Interest Rounding")]
        public StringEnumValue<PerDiemInterestRoundingType> PerDiemInterestRoundingType { get => _perDiemInterestRoundingType; set => SetField(ref _perDiemInterestRoundingType, value); }

        /// <summary>
        /// Lock Request Plan Code [3041]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Plan Code")]
        public string PlanCode { get => _planCode; set => SetField(ref _planCode, value); }

        /// <summary>
        /// Purchase Advice Premium [2212]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice Premium")]
        public decimal? Premium { get => _premium; set => SetField(ref _premium, value); }

        /// <summary>
        /// Trans Details Prepay Penalty [2216]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Prepay Penalty")]
        public StringEnumValue<YOrN> PrepayPenalty { get => _prepayPenalty; set => SetField(ref _prepayPenalty, value); }

        /// <summary>
        /// RateLock PriceAdjustment
        /// </summary>
        public decimal? PriceAdjustment { get => _priceAdjustment; set => SetField(ref _priceAdjustment, value); }

        /// <summary>
        /// RateLock PriceAdjustments
        /// </summary>
        public IList<PriceAdjustment> PriceAdjustments { get => GetField(ref _priceAdjustments); set => SetField(ref _priceAdjustments, value); }

        /// <summary>
        /// RateLock PricingHistoryData
        /// </summary>
        public string PricingHistoryData { get => _pricingHistoryData; set => SetField(ref _pricingHistoryData, value); }

        /// <summary>
        /// Lock Request Field For Pricing Updated [3039]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Field For Pricing Updated")]
        public string PricingUpdated { get => _pricingUpdated; set => SetField(ref _pricingUpdated, value); }

        /// <summary>
        /// Purchase Advice Principal [2211]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Principal")]
        public decimal? Principle { get => _principle; set => SetField(ref _principle, value); }

        /// <summary>
        /// Rate Lock Buy Side Adjusted Buy Price [3420]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Adjusted Buy Price")]
        public decimal? ProfitMarginAdjustedBuyPrice { get => _profitMarginAdjustedBuyPrice; set => SetField(ref _profitMarginAdjustedBuyPrice, value); }

        /// <summary>
        /// Lock Request Subject Property Appraised Value [2949]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Appraised Value")]
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => SetField(ref _propertyAppraisedValueAmount, value); }

        /// <summary>
        /// Lock Request Subject Property Est Value [2948]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Est Value")]
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => SetField(ref _propertyEstimatedValueAmount, value); }

        /// <summary>
        /// Lock Request Subject Property Occupancy Status [2950]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Occupancy Status")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Purchase Adv Interest Calcuation - Number of Days [3549]
        /// </summary>
        [LoanFieldProperty(Description = "Purchase Adv Interest Calcuation - Number of Days", OptionsJson = "{\"360\":\"360\",\"364\":\"364\",\"365\":\"365\"}")]
        public int? PurchaseAdviceNumberOfDays { get => _purchaseAdviceNumberOfDays; set => SetField(ref _purchaseAdviceNumberOfDays, value); }

        /// <summary>
        /// RateLock PurchaseAdvicePayouts
        /// </summary>
        public IList<PurchaseAdvicePayout> PurchaseAdvicePayouts { get => GetField(ref _purchaseAdvicePayouts); set => SetField(ref _purchaseAdvicePayouts, value); }

        /// <summary>
        /// Lock Request Purchase Price Amount [3038]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Purchase Price Amount")]
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => SetField(ref _purchasePriceAmount, value); }

        /// <summary>
        /// RateLock RateRequestStatus
        /// </summary>
        public string RateRequestStatus { get => _rateRequestStatus; set => SetField(ref _rateRequestStatus, value); }

        /// <summary>
        /// RateLock RateStatus
        /// </summary>
        public string RateStatus { get => _rateStatus; set => SetField(ref _rateStatus, value); }

        /// <summary>
        /// Rate Lock Buy Side Reason for Branch Concession Approval [3378]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Reason for Branch Concession Approval")]
        public string ReasonforBranchApproval { get => _reasonforBranchApproval; set => SetField(ref _reasonforBranchApproval, value); }

        /// <summary>
        /// Rate Lock Buy Side Reason for Corporate  Concession Approval [3374]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Buy Side Reason for Corporate  Concession Approval")]
        public string ReasonforCorporateApproval { get => _reasonforCorporateApproval; set => SetField(ref _reasonforCorporateApproval, value); }

        /// <summary>
        /// Purchase Advice Reconciled Differences [2629]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice Reconciled Differences")]
        public decimal? ReconciledDiff { get => _reconciledDiff; set => SetField(ref _reconciledDiff, value); }

        /// <summary>
        /// RateLock ReLockRequestPending
        /// </summary>
        public string ReLockRequestPending { get => _reLockRequestPending; set => SetField(ref _reLockRequestPending, value); }

        /// <summary>
        /// Purch Adv Remaining Buydown Funds [3131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purch Adv Remaining Buydown Funds")]
        public decimal? RemainingBuydownFunds { get => _remainingBuydownFunds; set => SetField(ref _remainingBuydownFunds, value); }

        /// <summary>
        /// Rate Lock Request Comments [2144]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Comments")]
        public string RequestComments { get => _requestComments; set => SetField(ref _requestComments, value); }

        /// <summary>
        /// Rate Lock Request Last Rate Set Date [3254]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Last Rate Set Date")]
        public DateTime? RequestCurrentRateSetDate { get => _requestCurrentRateSetDate; set => SetField(ref _requestCurrentRateSetDate, value); }

        /// <summary>
        /// Rate Lock Request Days to Extend [3360]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Days to Extend")]
        public int? RequestDaystoExtend { get => _requestDaystoExtend; set => SetField(ref _requestDaystoExtend, value); }

        /// <summary>
        /// Rate Lock Request Extended Lock Expires Date [3361]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Extended Lock Expires Date")]
        public DateTime? RequestExtendedLockExpires { get => _requestExtendedLockExpires; set => SetField(ref _requestExtendedLockExpires, value); }

        /// <summary>
        /// Rate Lock Request Fulfilled Date Time [2592]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Fulfilled Date Time")]
        public string RequestFullfilledDateTime { get => _requestFullfilledDateTime; set => SetField(ref _requestFullfilledDateTime, value); }

        /// <summary>
        /// Lock Request Impound Types [2962]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Impound Types")]
        public StringEnumValue<ImpoundType> RequestImpoundType { get => _requestImpoundType; set => SetField(ref _requestImpoundType, value); }

        /// <summary>
        /// RateLock RequestImpoundWaived
        /// </summary>
        public string RequestImpoundWaived { get => _requestImpoundWaived; set => SetField(ref _requestImpoundWaived, value); }

        /// <summary>
        /// Lock Request Impounds Waived [2961]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Impounds Waived")]
        public StringEnumValue<ImpoundWaived> RequestImpoundWavied { get => _requestImpoundWavied; set => SetField(ref _requestImpoundWavied, value); }

        /// <summary>
        /// Rate Lock Request Lock Cancellation Comment [3623]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Cancellation Comment")]
        public string RequestLockCancellationComment { get => _requestLockCancellationComment; set => SetField(ref _requestLockCancellationComment, value); }

        /// <summary>
        /// Rate Lock Request Lock Cancellation Date [3622]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Cancellation Date")]
        public DateTime? RequestLockCancellationDate { get => _requestLockCancellationDate; set => SetField(ref _requestLockCancellationDate, value); }

        /// <summary>
        /// Rate Lock Request Lock Date [2089]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Date")]
        public DateTime? RequestLockDate { get => _requestLockDate; set => SetField(ref _requestLockDate, value); }

        /// <summary>
        /// Rate Lock Request Lock Expires Date [2091]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Expires Date")]
        public DateTime? RequestLockExpires { get => _requestLockExpires; set => SetField(ref _requestLockExpires, value); }

        /// <summary>
        /// Rate Lock Request Lock Extension Comment [3370]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Extension Comment")]
        public string RequestLockExtendComment { get => _requestLockExtendComment; set => SetField(ref _requestLockExtendComment, value); }

        /// <summary>
        /// Rate Lock Request Lock Extension Price Adjustment [3362]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Lock Extension Price Adjustment")]
        public decimal? RequestLockExtendPriceAdjustment { get => _requestLockExtendPriceAdjustment; set => SetField(ref _requestLockExtendPriceAdjustment, value); }

        /// <summary>
        /// Rate Lock Request Lock Status [4209]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Lock Status")]
        public string RequestLockStatus { get => _requestLockStatus; set => SetField(ref _requestLockStatus, value); }

        /// <summary>
        /// Rate Lock Request Type [3841]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Type")]
        public string RequestLockType { get => _requestLockType; set => SetField(ref _requestLockType, value); }

        /// <summary>
        /// Rate Lock Request Base Margin Rate [2647]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Rate")]
        public decimal? RequestMarginRate { get => _requestMarginRate; set => SetField(ref _requestMarginRate, value); }

        /// <summary>
        /// Rate Lock Request Base Margin Rate Requested [2689]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Rate Requested")]
        public decimal? RequestMarginRateRequested { get => _requestMarginRateRequested; set => SetField(ref _requestMarginRateRequested, value); }

        /// <summary>
        /// Lock Request SRP Paid Out [2848]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request SRP Paid Out")]
        public decimal? RequestMarginSRPPaidOut { get => _requestMarginSRPPaidOut; set => SetField(ref _requestMarginSRPPaidOut, value); }

        /// <summary>
        /// Rate Lock Request Base Margin Total Adjust [2688]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Margin Total Adjust")]
        public decimal? RequestMarginTotalAdjustment { get => _requestMarginTotalAdjustment; set => SetField(ref _requestMarginTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Request Number of Days [2090]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Number of Days")]
        public int? RequestNumberOfDays { get => _requestNumberOfDays; set => SetField(ref _requestNumberOfDays, value); }

        /// <summary>
        /// Rate Lock Request ONRP Eligible Flag [4061]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Eligible Flag", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? RequestOnrpEligible { get => _requestOnrpEligible; set => SetField(ref _requestOnrpEligible, value); }

        /// <summary>
        /// Rate Lock Request ONRP Lock Date [4069]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Lock Date")]
        public DateTime? RequestOnrpLockDate { get => _requestOnrpLockDate; set => SetField(ref _requestOnrpLockDate, value); }

        /// <summary>
        /// Rate Lock Request ONRP Lock Time [4060]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Request ONRP Lock Time")]
        public string RequestOnrpLockTime { get => _requestOnrpLockTime; set => SetField(ref _requestOnrpLockTime, value); }

        /// <summary>
        /// Rate Lock Request Original Lock Expires Date [3369]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Original Lock Expires Date")]
        public DateTime? RequestOriginalLockExpires { get => _requestOriginalLockExpires; set => SetField(ref _requestOriginalLockExpires, value); }

        /// <summary>
        /// Lock Request Penelaty Term [2964]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Penelaty Term")]
        public StringEnumValue<PenaltyTerm> RequestPenaltyTerm { get => _requestPenaltyTerm; set => SetField(ref _requestPenaltyTerm, value); }

        /// <summary>
        /// RateLock RequestPending
        /// </summary>
        public string RequestPending { get => _requestPending; set => SetField(ref _requestPending, value); }

        /// <summary>
        /// Lock Request Prepay Penalty [2963]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Prepay Penalty")]
        public StringEnumValue<YOrN> RequestPrepayPenalty { get => _requestPrepayPenalty; set => SetField(ref _requestPrepayPenalty, value); }

        /// <summary>
        /// Rate Lock Request Base Price Rate [2101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Rate")]
        public decimal? RequestPriceRate { get => _requestPriceRate; set => SetField(ref _requestPriceRate, value); }

        /// <summary>
        /// Rate Lock Request Base Price Rate Requested [2143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Rate Requested")]
        public decimal? RequestPriceRateRequested { get => _requestPriceRateRequested; set => SetField(ref _requestPriceRateRequested, value); }

        /// <summary>
        /// Rate Lock Request Base Price Tot Adjustment [2142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Request Base Price Tot Adjustment")]
        public decimal? RequestPriceTotalAdjustment { get => _requestPriceTotalAdjustment; set => SetField(ref _requestPriceTotalAdjustment, value); }

        /// <summary>
        /// RateLock RequestProgramNotes
        /// </summary>
        public string RequestProgramNotes { get => _requestProgramNotes; set => SetField(ref _requestProgramNotes, value); }

        /// <summary>
        /// Rate Lock Request Base Rate [2092]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate")]
        public decimal? RequestRate { get => _requestRate; set => SetField(ref _requestRate, value); }

        /// <summary>
        /// Rate Lock Request Base Rate Requested [2100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate Requested")]
        public decimal? RequestRateRequested { get => _requestRateRequested; set => SetField(ref _requestRateRequested, value); }

        /// <summary>
        /// Rate Lock Request Rate Sheet ID [2088]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Request Rate Sheet ID")]
        public string RequestRateSheetID { get => _requestRateSheetID; set => SetField(ref _requestRateSheetID, value); }

        /// <summary>
        /// Rate Lock Request Base Rate Tot Adjustment [2099]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request Base Rate Tot Adjustment")]
        public decimal? RequestRateTotalAdjustment { get => _requestRateTotalAdjustment; set => SetField(ref _requestRateTotalAdjustment, value); }

        /// <summary>
        /// Lock Request Starting Adjust Point [3874]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Starting Adjust Point")]
        public decimal? RequestStartingAdjPoint { get => _requestStartingAdjPoint; set => SetField(ref _requestStartingAdjPoint, value); }

        /// <summary>
        /// Lock Request Starting Adjust Rate [3872]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Starting Adjust Rate")]
        public decimal? RequestStartingAdjRate { get => _requestStartingAdjRate; set => SetField(ref _requestStartingAdjRate, value); }

        /// <summary>
        /// RateLock RequestType
        /// </summary>
        public string RequestType { get => _requestType; set => SetField(ref _requestType, value); }

        /// <summary>
        /// Lock Request UnDiscounted Rate [3847]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request UnDiscounted Rate")]
        public decimal? RequestUnDiscountedRate { get => _requestUnDiscountedRate; set => SetField(ref _requestUnDiscountedRate, value); }

        /// <summary>
        /// Lock Request Field For Rounding to Nearest $50 [3056]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Field For Rounding to Nearest $50")]
        public bool? RoundToNearest50 { get => _roundToNearest50; set => SetField(ref _roundToNearest50, value); }

        /// <summary>
        /// Lock Request Second Subordinate Amount [3036]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Second Subordinate Amount")]
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => SetField(ref _secondSubordinateAmount, value); }

        /// <summary>
        /// Lock Request Seller Paid MI Premium [3049]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lock Request Seller Paid MI Premium")]
        public decimal? SellerPaidMIPremium { get => _sellerPaidMIPremium; set => SetField(ref _sellerPaidMIPremium, value); }

        /// <summary>
        /// RateLock SellSideAdjustments
        /// </summary>
        public IList<PriceAdjustment> SellSideAdjustments { get => GetField(ref _sellSideAdjustments); set => SetField(ref _sellSideAdjustments, value); }

        /// <summary>
        /// Rate Lock Sell Side Comments [2275]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Comments")]
        public string SellSideComments { get => _sellSideComments; set => SetField(ref _sellSideComments, value); }

        /// <summary>
        /// Rate Lock Sell Side Commitment Contract Number [4093]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Commitment Contract Number")]
        public string SellSideCommitmentContractNumber { get => _sellSideCommitmentContractNumber; set => SetField(ref _sellSideCommitmentContractNumber, value); }

        /// <summary>
        /// Rate Lock Sell Side Commitment Date [4016]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Commitment Date")]
        public DateTime? SellSideCommitmentDate { get => _sellSideCommitmentDate; set => SetField(ref _sellSideCommitmentDate, value); }

        /// <summary>
        /// Rate Lock Sell Side Last Rate Set Date [3257]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Last Rate Set Date")]
        public DateTime? SellSideCurrentRateSetDate { get => _sellSideCurrentRateSetDate; set => SetField(ref _sellSideCurrentRateSetDate, value); }

        /// <summary>
        /// Rate Lock Sell Side Days to Extend [3366]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Days to Extend")]
        public int? SellSideDaystoExtend { get => _sellSideDaystoExtend; set => SetField(ref _sellSideDaystoExtend, value); }

        /// <summary>
        /// Rate Lock Sell Side Discount YSP [2277]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Discount YSP")]
        public decimal? SellSideDiscountYSP { get => _sellSideDiscountYSP; set => SetField(ref _sellSideDiscountYSP, value); }

        /// <summary>
        /// Rate Lock Sell Side Extended Lock Expires Date [3367]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Extended Lock Expires Date")]
        public DateTime? SellSideExtendedLockExpires { get => _sellSideExtendedLockExpires; set => SetField(ref _sellSideExtendedLockExpires, value); }

        /// <summary>
        /// Rate Lock Sell Side Guarantee Fee [3889]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Guarantee Fee")]
        public decimal? SellSideGuaranteeFee { get => _sellSideGuaranteeFee; set => SetField(ref _sellSideGuaranteeFee, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Guaranty Fee [4182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Base Guaranty Fee")]
        public decimal? SellSideGuarantyBaseFee { get => _sellSideGuarantyBaseFee; set => SetField(ref _sellSideGuarantyBaseFee, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Status [2031]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Sell Side Investor Status")]
        public StringEnumValue<SellSideInvestorStatus> SellSideInvestorStatus { get => _sellSideInvestorStatus; set => SetField(ref _sellSideInvestorStatus, value); }

        /// <summary>
        /// Rate Lock Sell Side Investor Status Modification Date [2033]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Sell Side Investor Status Modification Date")]
        public DateTime? SellSideInvestorStatusDate { get => _sellSideInvestorStatusDate; set => SetField(ref _sellSideInvestorStatusDate, value); }

        /// <summary>
        /// Investor Trade Number [2842]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Investor Trade Number")]
        public string SellSideInvestorTradeNumber { get => _sellSideInvestorTradeNumber; set => SetField(ref _sellSideInvestorTradeNumber, value); }

        /// <summary>
        /// Rate Lock Sell Side Loan Program [3123]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Loan Program")]
        public string SellSideLoanProgram { get => _sellSideLoanProgram; set => SetField(ref _sellSideLoanProgram, value); }

        /// <summary>
        /// Rate Lock Sell Side Lock Date [2220]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Date")]
        public DateTime? SellSideLockDate { get => _sellSideLockDate; set => SetField(ref _sellSideLockDate, value); }

        /// <summary>
        /// Rate Lock Sell Side Lock Expires Date [2222]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Expires Date")]
        public DateTime? SellSideLockExpires { get => _sellSideLockExpires; set => SetField(ref _sellSideLockExpires, value); }

        /// <summary>
        /// Rate Lock Sell Side Lock Extension Price Adjustment [3368]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Lock Extension Price Adjustment")]
        public decimal? SellSideLockExtendPriceAdjustment { get => _sellSideLockExtendPriceAdjustment; set => SetField(ref _sellSideLockExtendPriceAdjustment, value); }

        /// <summary>
        /// Rate Lock Sell Side Net Buy Rate [2818]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Net Buy Rate")]
        public decimal? SellSideMarginNetSellRate { get => _sellSideMarginNetSellRate; set => SetField(ref _sellSideMarginNetSellRate, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Rate [2776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate")]
        public decimal? SellSideMarginRate { get => _sellSideMarginRate; set => SetField(ref _sellSideMarginRate, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Rate Total Adjustment [2817]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate Total Adjustment")]
        public decimal? SellSideMarginTotalAdjustment { get => _sellSideMarginTotalAdjustment; set => SetField(ref _sellSideMarginTotalAdjustment, value); }

        /// <summary>
        /// Master Contract Number [2841]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Master Contract Number")]
        public string SellSideMasterContractNumber { get => _sellSideMasterContractNumber; set => SetField(ref _sellSideMasterContractNumber, value); }

        /// <summary>
        /// Rate Lock Sell Side MSR Value [4118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side MSR Value")]
        public decimal? SellSideMSRValue { get => _sellSideMSRValue; set => SetField(ref _sellSideMSRValue, value); }

        /// <summary>
        /// Rate Lock Sell Side Net Sell Price [2274]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Net Sell Price")]
        public decimal? SellSideNetSellPrice { get => _sellSideNetSellPrice; set => SetField(ref _sellSideNetSellPrice, value); }

        /// <summary>
        /// Rate Lock Sell Side Net Buy Rate [2231]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Net Buy Rate")]
        public decimal? SellSideNetSellRate { get => _sellSideNetSellRate; set => SetField(ref _sellSideNetSellRate, value); }

        /// <summary>
        /// Rate Lock Sell Side Number of Days [2221]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Number of Days")]
        public int? SellSideNumberOfDays { get => _sellSideNumberOfDays; set => SetField(ref _sellSideNumberOfDays, value); }

        /// <summary>
        /// Rate Lock Sell Side Lock Expires Date [3359]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Lock Expires Date")]
        public DateTime? SellSideOriginalLockExpires { get => _sellSideOriginalLockExpires; set => SetField(ref _sellSideOriginalLockExpires, value); }

        /// <summary>
        /// Rate Lock Sell Side Pool ID [4019]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Pool ID")]
        public string SellSidePoolID { get => _sellSidePoolID; set => SetField(ref _sellSidePoolID, value); }

        /// <summary>
        /// Rate Lock Sell Side Pool Number [3890]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Pool Number")]
        public string SellSidePoolNumber { get => _sellSidePoolNumber; set => SetField(ref _sellSidePoolNumber, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Price Rate [2232]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Base Price Rate")]
        public decimal? SellSidePriceRate { get => _sellSidePriceRate; set => SetField(ref _sellSidePriceRate, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Price Total Adjust [2273]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Sell Side Base Price Total Adjust")]
        public decimal? SellSidePriceTotalAdjustment { get => _sellSidePriceTotalAdjustment; set => SetField(ref _sellSidePriceTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Sell Side Product Name [4094]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Product Name")]
        public string SellSideProductName { get => _sellSideProductName; set => SetField(ref _sellSideProductName, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Rate [2223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate")]
        public decimal? SellSideRate { get => _sellSideRate; set => SetField(ref _sellSideRate, value); }

        /// <summary>
        /// Rate Lock Sell Side Rate Sheet ID [2219]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Rate Sheet ID")]
        public string SellSideRateSheetID { get => _sellSideRateSheetID; set => SetField(ref _sellSideRateSheetID, value); }

        /// <summary>
        /// Rate Lock Sell Side Base Rate Tot Adjustment [2230]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side Base Rate Tot Adjustment")]
        public decimal? SellSideRateTotalAdjustment { get => _sellSideRateTotalAdjustment; set => SetField(ref _sellSideRateTotalAdjustment, value); }

        /// <summary>
        /// Rate Lock Sell Side Requested By [2030]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Requested By")]
        public string SellSideRequestedBy { get => _sellSideRequestedBy; set => SetField(ref _sellSideRequestedBy, value); }

        /// <summary>
        /// Rate Lock Sell Side Servicer [3535]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Servicer")]
        public string SellSideServicer { get => _sellSideServicer; set => SetField(ref _sellSideServicer, value); }

        /// <summary>
        /// Rate Lock Sell Side Servicing Fee [3888]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Rate Lock Sell Side Servicing Fee")]
        public decimal? SellSideServicingFee { get => _sellSideServicingFee; set => SetField(ref _sellSideServicingFee, value); }

        /// <summary>
        /// Rate Lock Sell Side Servicing Type [3534]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Servicing Type")]
        public StringEnumValue<ServicingType> SellSideServicingType { get => _sellSideServicingType; set => SetField(ref _sellSideServicingType, value); }

        /// <summary>
        /// Purchase Advice Sell Side SRP [2209]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Purchase Advice Sell Side SRP")]
        public decimal? SellSideSRP { get => _sellSideSRP; set => SetField(ref _sellSideSRP, value); }

        /// <summary>
        /// Rate Lock Sell Side SRP Paid Out [2276]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Sell Side SRP Paid Out")]
        public decimal? SellSideSRPPaidOut { get => _sellSideSRPPaidOut; set => SetField(ref _sellSideSRPPaidOut, value); }

        /// <summary>
        /// Assigned Trade Unique Identifier [2819]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Assigned Trade Unique Identifier")]
        public string SellSideTradeGuid { get => _sellSideTradeGuid; set => SetField(ref _sellSideTradeGuid, value); }

        /// <summary>
        /// Rate Lock Identifier Trade Mgmt Prev Confirmed Lock [3839]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Identifier Trade Mgmt Prev Confirmed Lock")]
        public string SellSideTradeMgmtPrevConfirmedLockGuid { get => _sellSideTradeMgmtPrevConfirmedLockGuid; set => SetField(ref _sellSideTradeMgmtPrevConfirmedLockGuid, value); }

        /// <summary>
        /// Rate Lock Assigned Trade Number [2032]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock Assigned Trade Number")]
        public string SellSideTradeNumber { get => _sellSideTradeNumber; set => SetField(ref _sellSideTradeNumber, value); }

        /// <summary>
        /// Servicing Release Indicator [3338]
        /// </summary>
        [LoanFieldProperty(Description = "Servicing Release Indicator")]
        public bool? ServicingReleaseIndicator { get => _servicingReleaseIndicator; set => SetField(ref _servicingReleaseIndicator, value); }

        /// <summary>
        /// Purchase Advice SRP Received [2213]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Purchase Advice SRP Received")]
        public decimal? SRP { get => _sRP; set => SetField(ref _sRP, value); }

        /// <summary>
        /// Purchase Advice SRP Amount [2210]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Purchase Advice SRP Amount")]
        public decimal? SRPAmount { get => _sRPAmount; set => SetField(ref _sRPAmount, value); }

        /// <summary>
        /// Rate Lock Request SRP Paid Out [4201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Request SRP Paid Out")]
        public decimal? SRPPaidOut { get => _sRPPaidOut; set => SetField(ref _sRPPaidOut, value); }

        /// <summary>
        /// Lock Request Subject Property City [2943]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property City")]
        public string SubjectPropertyCity { get => _subjectPropertyCity; set => SetField(ref _subjectPropertyCity, value); }

        /// <summary>
        /// Lock Request Subject Property is a Condotel [4115]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property is a Condotel")]
        public bool? SubjectPropertyCondotelIndicator { get => _subjectPropertyCondotelIndicator; set => SetField(ref _subjectPropertyCondotelIndicator, value); }

        /// <summary>
        /// Lock Request Subject Property County [2944]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property County")]
        public string SubjectPropertyCounty { get => _subjectPropertyCounty; set => SetField(ref _subjectPropertyCounty, value); }

        /// <summary>
        /// Lock Request Subject Property is a Non-Warrantable Project [4116]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property is a Non-Warrantable Project")]
        public bool? SubjectPropertyNonWarrantableProjectIndicator { get => _subjectPropertyNonWarrantableProjectIndicator; set => SetField(ref _subjectPropertyNonWarrantableProjectIndicator, value); }

        /// <summary>
        /// Lock Request Subject Property Zip [2946]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Lock Request Subject Property Zip")]
        public string SubjectPropertyPostalCode { get => _subjectPropertyPostalCode; set => SetField(ref _subjectPropertyPostalCode, value); }

        /// <summary>
        /// Lock Request Subject Property State [2945]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property State")]
        public StringEnumValue<State> SubjectPropertyState { get => _subjectPropertyState; set => SetField(ref _subjectPropertyState, value); }

        /// <summary>
        /// Lock Request Subject Property Address [2942]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Subject Property Address")]
        public string SubjectPropertyStreetAddress { get => _subjectPropertyStreetAddress; set => SetField(ref _subjectPropertyStreetAddress, value); }

        /// <summary>
        /// Rate Lock Sell Side Time Locked with Investor [2292]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Sell Side Time Locked with Investor")]
        public string TimeLockedWithInvestor { get => _timeLockedWithInvestor; set => SetField(ref _timeLockedWithInvestor, value); }

        /// <summary>
        /// Rate Lock Buy Side Total Buy Price [2218]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, Description = "Rate Lock Buy Side Total Buy Price")]
        public decimal? TotalBuyPrice { get => _totalBuyPrice; set => SetField(ref _totalBuyPrice, value); }

        /// <summary>
        /// Lock Request FHA 203k D2 Lesser of Sum(A2+B14)/A4 [3845]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Lock Request FHA 203k D2 Lesser of Sum(A2+B14)/A4")]
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => SetField(ref _totalForLesserOfSumAsIs, value); }

        /// <summary>
        /// Rate Lock Buy Side Total Price Concessions [3379]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Rate Lock Buy Side Total Price Concessions")]
        public decimal? TotalPrice { get => _totalPrice; set => SetField(ref _totalPrice, value); }

        /// <summary>
        /// Loan Info Subordinate Financing [2398]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Subordinate Financing")]
        public decimal? TotalSubordinateFinancing { get => _totalSubordinateFinancing; set => SetField(ref _totalSubordinateFinancing, value); }

        /// <summary>
        /// Lock Request Borrower Can Demonstrate 12-Month Mortgage/Rental History [3530]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Borrower Can Demonstrate 12-Month Mortgage/Rental History")]
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => SetField(ref _twelveMonthMortgageRentalHistoryIndicator, value); }

        /// <summary>
        /// RateLock Type
        /// </summary>
        public string Type { get => _type; set => SetField(ref _type, value); }

        /// <summary>
        /// Use Point for Calculation SRP and Price Balancing [3430]
        /// </summary>
        [LoanFieldProperty(Description = "Use Point for Calculation SRP and Price Balancing")]
        public bool? UsePoint { get => _usePoint; set => SetField(ref _usePoint, value); }
    }
}