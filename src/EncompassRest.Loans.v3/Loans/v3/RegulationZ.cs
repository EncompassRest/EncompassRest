using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegulationZ
/// </summary>
public sealed partial class RegulationZ : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _acknowledgedDay;
    private DirtyValue<string?>? _acknowledgedMonth;
    private DirtyValue<string?>? _acknowledgedYear;
    private DirtyValue<bool?>? _acquisition;
    private DirtyValue<string?>? _additionalArmInformation;
    private DirtyValue<bool?>? _allDateAndNumericalDisclosuresIndicator;
    private DirtyValue<decimal?>? _amountFinanced;
    private DirtyValue<decimal?>? _aprPercent;
    private DirtyValue<string?>? _aprPercentUi;
    private DirtyValue<string?>? _armDisclosureDescription;
    private DirtyValue<StringEnumValue<AssumptionOnYourProperty>>? _assumptionOnYourProperty;
    private DirtyValue<DateTime?>? _borrowerIntendToContinueDate;
    private DirtyValue<bool?>? _borrowerIntendToContinueIndicator;
    private DirtyValue<DateTime?>? _borrowerMiTerminationDate;
    private DirtyValue<string?>? _calculateBasedOnRemainingBalance;
    private DirtyValue<bool?>? _chargesAddedToPaymentsIndicator;
    private DirtyValue<bool?>? _chargesAtLoanClosingIndicator;
    private DirtyValue<string?>? _circumstanceChangeReason;
    private DirtyValue<DateTime?>? _circumstanceChangeReceivedDate;
    private DirtyValue<DateTime?>? _closingDisclosureReceivedDate;
    private DirtyValue<DateTime?>? _closingDisclosureSentDate;
    private DirtyValue<StringEnumValue<ConstructionFirstIntChangeAdjType>>? _constructionFirstIntChangeAdjType;
    private DirtyValue<string?>? _constructionLoanDescription;
    private DirtyValue<StringEnumValue<ConstructionLoanMethod>>? _constructionLoanMethod;
    private DirtyValue<int?>? _constructionPeriodMonths;
    private DirtyValue<decimal?>? _constructionRatePercent;
    private DirtyValue<bool?>? _constructionRefinanceIndicator;
    private DirtyValue<decimal?>? _creditDisability;
    private DirtyValue<bool?>? _creditDisabilityIndicator;
    private DirtyValue<decimal?>? _creditLife;
    private DirtyValue<decimal?>? _creditLifeAndCreditDisability;
    private DirtyValue<bool?>? _creditLifeInsuranceIndicator;
    private DirtyValue<bool?>? _customizePaymentScheduleIndicator;
    private DirtyValue<bool?>? _demandFeatureIndicator;
    private DirtyValue<decimal?>? _disclosedAprPercent;
    private DirtyValue<bool?>? _disclosedByBrokerIndicator;
    private DirtyValue<string?>? _disclosedComments;
    private DirtyValue<decimal?>? _disclosedDailyInterestCharge;
    private DirtyValue<decimal?>? _disclosedFinanceCharge;
    private DirtyValue<bool?>? _disclosedPrepayment;
    private DirtyValue<string?>? _disclosedProduct;
    private DirtyValue<StringEnumValue<DisclosureMethod>>? _disclosureMethod;
    private DirtyValue<StringEnumValue<DisclosureType>>? _disclosureType;
    private DirtyValue<int?>? _discountPeriod;
    private DirtyValue<decimal?>? _discountRatePercent;
    private DirtyValue<StringEnumValue<DiscountType>>? _discountType;
    private DirtyValue<DateTime?>? _dueDate;
    private DirtyValue<DateTime?>? _earliestClosingDate;
    private DirtyValue<DateTime?>? _earliestFeeCollectionDate;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted1;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted2;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted3;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted4;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted5;
    private DirtyValue<DateTime?>? _eSignConsentBorrowerDateAccepted6;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress1;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress2;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress3;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress4;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress5;
    private DirtyValue<string?>? _eSignConsentBorrowerIpAddress6;
    private DirtyValue<string?>? _eSignConsentBorrowerSource1;
    private DirtyValue<string?>? _eSignConsentBorrowerSource2;
    private DirtyValue<string?>? _eSignConsentBorrowerSource3;
    private DirtyValue<string?>? _eSignConsentBorrowerSource4;
    private DirtyValue<string?>? _eSignConsentBorrowerSource5;
    private DirtyValue<string?>? _eSignConsentBorrowerSource6;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus1;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus2;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus3;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus4;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus5;
    private DirtyValue<string?>? _eSignConsentBorrowerStatus6;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted1;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted2;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted3;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted4;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted5;
    private DirtyValue<DateTime?>? _eSignConsentCoBorrowerDateAccepted6;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress1;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress2;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress3;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress4;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress5;
    private DirtyValue<string?>? _eSignConsentCoBorrowerIpAddress6;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource1;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource2;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource3;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource4;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource5;
    private DirtyValue<string?>? _eSignConsentCoBorrowerSource6;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus1;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus2;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus3;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus4;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus5;
    private DirtyValue<string?>? _eSignConsentCoBorrowerStatus6;
    private DirtyValue<DateTime?>? _eSignConsentDate;
    private DirtyValue<string?>? _externaleConsent;
    private DirtyValue<decimal?>? _extraPaymentForEarlyPayOff;
    private DirtyValue<DateTime?>? _feeCollectedDate;
    private DirtyValue<bool?>? _feeLevelDisclosuresIndicator;
    private DirtyValue<decimal?>? _filingFees;
    private DirtyValue<DateTime?>? _finalPaymentDate;
    private DirtyValue<decimal?>? _financeCharge;
    private DirtyValue<decimal?>? _financedAllGuaranteeFeeAmount;
    private DirtyValue<decimal?>? _financedAllGuaranteeFeePercent;
    private DirtyValue<decimal?>? _financedAllTotalLoanAmount;
    private DirtyValue<decimal?>? _financedPortionGuaranteeFeeAmount;
    private DirtyValue<decimal?>? _financedPortionGuaranteeFeePercent;
    private DirtyValue<decimal?>? _financedPortionTotalLoanAmount;
    private DirtyValue<StringEnumValue<FinancingType>>? _financingType;
    private DirtyValue<DateTime?>? _firstAmortizationPaymentDate;
    private DirtyValue<bool?>? _floodInsuranceIndicator;
    private DirtyValue<DateTime?>? _gfeApplicationDate;
    private DirtyValue<bool?>? _gfeChangedCircumstanceIndicator;
    private DirtyValue<string?>? _gfeChangedCircumstanceItem;
    private DirtyValue<string?>? _gfeChangedCirsumstanceItemCode;
    private DirtyValue<DateTime?>? _gfeDate;
    private DirtyValue<DateTime?>? _gfeExpirationDate;
    private DirtyValue<string?>? _gfeExpirationPeriod;
    private DirtyValue<bool?>? _gfeRateLockRedisclosureRequiredIndicator;
    private DirtyValue<DateTime?>? _gfeRedisclosureProvidedDate;
    private DirtyValue<DateTime?>? _gfeRedisclosureReceivedDate;
    private DirtyValue<int?>? _helocTeaserRatePeriod;
    private DirtyValue<DateTime?>? _highCostDisclosure;
    private DirtyValue<DateTime?>? _homeCounselingProvidedDate;
    private DirtyValue<bool?>? _hud1ToleranceViolatedIndicator;
    private DirtyValue<string?>? _hudToleranceResolutionComments;
    private DirtyValue<DateTime?>? _hudToleranceResolutionDate;
    private DirtyValue<string?>? _hudToleranceResolvedBy;
    private DirtyValue<bool?>? _ifYouPurchaseIndicator;
    private DirtyValue<StringEnumValue<IfYouPurchaseType>>? _ifYouPurchaseType;
    private DirtyValue<bool?>? _includeMiIndicator;
    private DirtyValue<bool?>? _includePmiIndicator;
    private DirtyValue<bool?>? _includeTaxesInsuranceIndicator;
    private DirtyValue<DateTime?>? _initialAvmProvidedDate;
    private DirtyValue<DateTime?>? _initialDisclosureDueDate;
    private DirtyValue<DateTime?>? _initialDisclosureProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeAffiliatedBusinessProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeAppraisalProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeCharmBookletProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeDisclosureProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeDisclosureReceivedDate;
    private DirtyValue<DateTime?>? _initialGfeHelocBrochureProvidedDate;
    private DirtyValue<DateTime?>? _initialGfeHudSpecialBookletProvidedDate;
    private DirtyValue<DateTime?>? _initialSubsequentAppraisalProvidedDate;
    private DirtyValue<DateTime?>? _initialTilDisclosureProvidedDate;
    private DirtyValue<DateTime?>? _initialTilDisclosureReceivedDate;
    private DirtyValue<string?>? _insuranceRequiredDescription;
    private DirtyValue<StringEnumValue<InterestAccrual>>? _interestAccrual;
    private DirtyValue<string?>? _interestInNameOf;
    private DirtyValue<bool?>? _interestOnly;
    private DirtyValue<bool?>? _interestOnlyIndicator;
    private DirtyValue<int?>? _interestOnlyMonths;
    private DirtyValue<StringEnumValue<InterestRateType>>? _interestRateType;
    private DirtyValue<decimal?>? _interestReserveAmount;
    private DirtyValue<StringEnumValue<LandValueType>>? _landValueType;
    private DirtyValue<string?>? _lastDisclosedBy;
    private DirtyValue<DateTime?>? _lastDisclosedDate;
    private DirtyValue<DateTime?>? _lastDisclosedGfeReceivedDate;
    private DirtyValue<decimal?>? _lateChargeBasis;
    private DirtyValue<string?>? _lateChargeComments;
    private DirtyValue<int?>? _lateChargeDays;
    private DirtyValue<decimal?>? _lateChargePercent;
    private DirtyValue<StringEnumValue<LateChargeType>>? _lateChargeType;
    private DirtyValue<decimal?>? _lateFee;
    private DirtyValue<string?>? _leIntentToProceedComment;
    private DirtyValue<bool?>? _lenderPaidMortgageInsuranceIndicator;
    private DirtyValue<decimal?>? _lendersInspectionFee;
    private DirtyValue<string?>? _leReceivedBy;
    private DirtyValue<StringEnumValue<LEReceivedMethod>>? _leReceivedMethod;
    private DirtyValue<string?>? _leReceivedMethodOther;
    private DirtyValue<DateTime?>? _leSentOnDate;
    private DirtyValue<decimal?>? _marginPlusIndexPercent;
    private DirtyValue<decimal?>? _maximumLateCharge;
    private DirtyValue<decimal?>? _maximumPayment;
    private DirtyValue<bool?>? _meansAnEstimateIndicator;
    private DirtyValue<decimal?>? _miAdjustmentFactorLevel2;
    private DirtyValue<bool?>? _miDecliningRenewalsIndicator;
    private DirtyValue<string?>? _midpointCancellation;
    private DirtyValue<decimal?>? _miMonthlyPaymentLevel1;
    private DirtyValue<decimal?>? _miMonthlyPaymentLevel2;
    private DirtyValue<int?>? _miMonthsOfAdjustmentLevel1;
    private DirtyValue<int?>? _miMonthsOfAdjustmentLevel2;
    private DirtyValue<decimal?>? _minimumLateCharge;
    private DirtyValue<decimal?>? _minimumPayment;
    private DirtyValue<bool?>? _mipFactorLocked;
    private DirtyValue<decimal?>? _miPrepaidAmount;
    private DirtyValue<bool?>? _miPrepaidIndicator;
    private DirtyValue<DateTime?>? _miScheduledTerminationDate;
    private DirtyValue<bool?>? _mmiIndicator;
    private DirtyValue<decimal?>? _monthlyTerm;
    private DirtyValue<int?>? _monthsOfMiPrepaid;
    private DirtyValue<decimal?>? _mortgageInsuranceCancelPercent;
    private DirtyValue<string?>? _namePreparedBy;
    private DirtyValue<string?>? _newConstructionIndicator;
    private DirtyValue<int?>? _numberOfPayments;
    private DirtyValue<DateTime?>? _occupancyCertDate;
    private DirtyValue<DateTime?>? _originalContractDate;
    private DirtyValue<decimal?>? _outstandingBalance;
    private DirtyValue<string?>? _paymentFrequencyType;
    private DirtyValue<decimal?>? _paymentIncreasePercent;
    private DirtyValue<string?>? _phonePreparedBy;
    private DirtyValue<bool?>? _pmiIndicator;
    private DirtyValue<DateTime?>? _pmiMidpointCancelationDate;
    private DirtyValue<DateTime?>? _postConsummationDisclosureReceivedDate;
    private DirtyValue<DateTime?>? _postConsummationDisclosureSentDate;
    private DirtyValue<decimal?>? _prepaidFinanceCharge;
    private DirtyValue<bool?>? _propertyInsuranceIndicator;
    private DirtyValue<DateTime?>? _rateLockGfeDueDate;
    private DirtyValue<decimal?>? _ratePercent;
    private DirtyValue<int?>? _recastPaidMonths;
    private DirtyValue<int?>? _recastStopMonths;
    private DirtyValue<bool?>? _refundPaymentIndicator;
    private DirtyValue<bool?>? _refundUnearnedMipIndicator;
    private DirtyList<RegulationZInterestRatePeriod>? _regulationZInterestRatePeriods;
    private DirtyList<RegulationZPayment>? _regulationZPayments;
    private DirtyValue<string?>? _regzTableType;
    private DirtyValue<bool?>? _requiredDepositIndicator;
    private DirtyValue<DateTime?>? _revisedClosingDisclosureReceivedDate;
    private DirtyValue<DateTime?>? _revisedClosingDisclosureSentDate;
    private DirtyValue<DateTime?>? _revisedGfeDueDate;
    private DirtyValue<decimal?>? _roundedMarginPlusIndexPercent;
    private DirtyValue<DateTime?>? _safeHarborSentDate;
    private DirtyValue<decimal?>? _samplePayments;
    private DirtyValue<StringEnumValue<SecurityType>>? _securityType;
    private DirtyValue<bool?>? _simpleInterestAccrualIndicator;
    private DirtyValue<bool?>? _simpleInterestLeapYearIndicator;
    private DirtyValue<DateTime?>? _ssplSentDate;
    private DirtyValue<DateTime?>? _tilDate;
    private DirtyValue<string?>? _tilDisclosedComments;
    private DirtyValue<StringEnumValue<DisclosureMethod>>? _tilDisclosureMethod;
    private DirtyValue<DateTime?>? _tilLastDisclosedBorrowerReceivedDate;
    private DirtyValue<string?>? _tilLastDisclosedBy;
    private DirtyValue<DateTime?>? _tilLastDisclosedDate;
    private DirtyValue<DateTime?>? _tilRedisclosureProvidedDate;
    private DirtyValue<DateTime?>? _tilRedisclosureReceivedDate;
    private DirtyValue<decimal?>? _totalBrokerFees;
    private DirtyValue<decimal?>? _totalLatePayment;
    private DirtyValue<decimal?>? _totalLenderFees;
    private DirtyValue<decimal?>? _totalOfPayments;
    private DirtyValue<decimal?>? _totalOfPrincipalAndInterest;
    private DirtyValue<bool?>? _useCustomLenderProfile;
    private DirtyValue<StringEnumValue<DaysInYear>>? _useDaysInYears;
    private DirtyValue<bool?>? _usePitiForRatioIndicator;
    private DirtyValue<bool?>? _variableRateFeatureIndicator;
    private DirtyValue<decimal?>? _yearlyTerm;
    private DirtyValue<string?>? _yearOfMaximumPayment;
    private DirtyValue<int?>? _years;
    private DirtyValue<StringEnumValue<ZeroPercentPaymentOption>>? _zeroPercentPaymentOption;

    /// <summary>
    /// REGZ Acknowledgement Day [REGZ_DAY]
    /// </summary>
    public string? AcknowledgedDay { get => _acknowledgedDay; set => SetField(ref _acknowledgedDay, value); }

    /// <summary>
    /// REGZ Acknowledgement Mo [REGZ_MONTH]
    /// </summary>
    public string? AcknowledgedMonth { get => _acknowledgedMonth; set => SetField(ref _acknowledgedMonth, value); }

    /// <summary>
    /// REGZ Acknowledgement Yr [REGZ_YR]
    /// </summary>
    public string? AcknowledgedYear { get => _acknowledgedYear; set => SetField(ref _acknowledgedYear, value); }

    /// <summary>
    /// Initial Acquisition of Land [1964]
    /// </summary>
    public bool? Acquisition { get => _acquisition; set => SetField(ref _acquisition, value); }

    /// <summary>
    /// REGZ Pymt Sched Additional Info [666]
    /// </summary>
    public string? AdditionalArmInformation { get => _additionalArmInformation; set => SetField(ref _additionalArmInformation, value); }

    /// <summary>
    /// Trans Details Dates/Num Discl Are Estimates [679]
    /// </summary>
    public bool? AllDateAndNumericalDisclosuresIndicator { get => _allDateAndNumericalDisclosuresIndicator; set => SetField(ref _allDateAndNumericalDisclosuresIndicator, value); }

    /// <summary>
    /// REGZ Total Amt Financed [948]
    /// </summary>
    public decimal? AmountFinanced { get => _amountFinanced; set => SetField(ref _amountFinanced, value); }

    /// <summary>
    /// Trans Details APR [799]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprPercent { get => _aprPercent; set => SetField(ref _aprPercent, value); }

    /// <summary>
    /// Trans Details APR - Display field with KBYO rounding rules [KBYO.XD799]
    /// </summary>
    public string? AprPercentUi { get => _aprPercentUi; set => SetField(ref _aprPercentUi, value); }

    /// <summary>
    /// Prequal ARM Index [1960]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ArmDisclosureDescription { get => _armDisclosureDescription; set => SetField(ref _armDisclosureDescription, value); }

    /// <summary>
    /// Trans Details Assumption May/May Not [677]
    /// </summary>
    public StringEnumValue<AssumptionOnYourProperty> AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => SetField(ref _assumptionOnYourProperty, value); }

    /// <summary>
    /// Borrower Intent to Continue Date [3197]
    /// </summary>
    public DateTime? BorrowerIntendToContinueDate { get => _borrowerIntendToContinueDate; set => SetField(ref _borrowerIntendToContinueDate, value); }

    /// <summary>
    /// Borrower Intends to Continue Chkbx [3164]
    /// </summary>
    public bool? BorrowerIntendToContinueIndicator { get => _borrowerIntendToContinueIndicator; set => SetField(ref _borrowerIntendToContinueIndicator, value); }

    /// <summary>
    /// Insurance Borr MI Termination Date [109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? BorrowerMiTerminationDate { get => _borrowerMiTerminationDate; set => SetField(ref _borrowerMiTerminationDate, value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Based On Remain Bal [1775]
    /// </summary>
    public string? CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => SetField(ref _calculateBasedOnRemainingBalance, value); }

    /// <summary>
    /// Charges for the insurance are added to your loan payments [3531]
    /// </summary>
    public bool? ChargesAddedToPaymentsIndicator { get => _chargesAddedToPaymentsIndicator; set => SetField(ref _chargesAddedToPaymentsIndicator, value); }

    /// <summary>
    /// Charges for the insurance are collected upfront at loan closing [3532]
    /// </summary>
    public bool? ChargesAtLoanClosingIndicator { get => _chargesAtLoanClosingIndicator; set => SetField(ref _chargesAtLoanClosingIndicator, value); }

    /// <summary>
    /// GFE Changed Circumstance Comments [3166]
    /// </summary>
    public string? CircumstanceChangeReason { get => _circumstanceChangeReason; set => SetField(ref _circumstanceChangeReason, value); }

    /// <summary>
    /// Changed Circumstance Rcvd Date [3165]
    /// </summary>
    public DateTime? CircumstanceChangeReceivedDate { get => _circumstanceChangeReceivedDate; set => SetField(ref _circumstanceChangeReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure Received Date [3978]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ClosingDisclosureReceivedDate { get => _closingDisclosureReceivedDate; set => SetField(ref _closingDisclosureReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure Sent Date [3977]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ClosingDisclosureSentDate { get => _closingDisclosureSentDate; set => SetField(ref _closingDisclosureSentDate, value); }

    /// <summary>
    /// Construction 1st Int. Change Adj. [Constr.FstIntChgAdj]
    /// </summary>
    public StringEnumValue<ConstructionFirstIntChangeAdjType> ConstructionFirstIntChangeAdjType { get => _constructionFirstIntChangeAdjType; set => SetField(ref _constructionFirstIntChangeAdjType, value); }

    /// <summary>
    /// Loan Info Constr Loan Descr [1404]
    /// </summary>
    public string? ConstructionLoanDescription { get => _constructionLoanDescription; set => SetField(ref _constructionLoanDescription, value); }

    /// <summary>
    /// REGZ Construction Mortgage Est Interest On [SYS.X6]
    /// </summary>
    public StringEnumValue<ConstructionLoanMethod> ConstructionLoanMethod { get => _constructionLoanMethod; set => SetField(ref _constructionLoanMethod, value); }

    /// <summary>
    /// Loan Info Constr Loan Period [1176]
    /// </summary>
    public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => SetField(ref _constructionPeriodMonths, value); }

    /// <summary>
    /// Loan Info Constr Loan Interest Rate [1677]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConstructionRatePercent { get => _constructionRatePercent; set => SetField(ref _constructionRatePercent, value); }

    /// <summary>
    /// Construction Refinance Indicator [Constr.Refi]
    /// </summary>
    public bool? ConstructionRefinanceIndicator { get => _constructionRefinanceIndicator; set => SetField(ref _constructionRefinanceIndicator, value); }

    /// <summary>
    /// Insurance Premium Credit Disability [1704]
    /// </summary>
    public decimal? CreditDisability { get => _creditDisability; set => SetField(ref _creditDisability, value); }

    /// <summary>
    /// Insurance Credit Disability [1698]
    /// </summary>
    public bool? CreditDisabilityIndicator { get => _creditDisabilityIndicator; set => SetField(ref _creditDisabilityIndicator, value); }

    /// <summary>
    /// Insurance Premium Credit Life [1703]
    /// </summary>
    public decimal? CreditLife { get => _creditLife; set => SetField(ref _creditLife, value); }

    /// <summary>
    /// Insurance Premium Credit Life/Disability [1705]
    /// </summary>
    public decimal? CreditLifeAndCreditDisability { get => _creditLifeAndCreditDisability; set => SetField(ref _creditLifeAndCreditDisability, value); }

    /// <summary>
    /// Insurance Credit Life [1697]
    /// </summary>
    public bool? CreditLifeInsuranceIndicator { get => _creditLifeInsuranceIndicator; set => SetField(ref _creditLifeInsuranceIndicator, value); }

    /// <summary>
    /// REGZ Pymt Sched Customize [1678]
    /// </summary>
    public bool? CustomizePaymentScheduleIndicator { get => _customizePaymentScheduleIndicator; set => SetField(ref _customizePaymentScheduleIndicator, value); }

    /// <summary>
    /// REGZ Pymt Sched Demand Feature [663]
    /// </summary>
    public bool? DemandFeatureIndicator { get => _demandFeatureIndicator; set => SetField(ref _demandFeatureIndicator, value); }

    /// <summary>
    /// Trans Details Disclosed APR [3121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosedAprPercent { get => _disclosedAprPercent; set => SetField(ref _disclosedAprPercent, value); }

    /// <summary>
    /// Disclosed By Broker Chbx [3136]
    /// </summary>
    public bool? DisclosedByBrokerIndicator { get => _disclosedByBrokerIndicator; set => SetField(ref _disclosedByBrokerIndicator, value); }

    /// <summary>
    /// GFE Disclosed Comments [3141]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosedComments { get => _disclosedComments; set => SetField(ref _disclosedComments, value); }

    /// <summary>
    /// Disclosed Daily Interest Charges [3887]
    /// </summary>
    public decimal? DisclosedDailyInterestCharge { get => _disclosedDailyInterestCharge; set => SetField(ref _disclosedDailyInterestCharge, value); }

    /// <summary>
    /// Disclosed Fees Total Finance Charges [3246]
    /// </summary>
    public decimal? DisclosedFinanceCharge { get => _disclosedFinanceCharge; set => SetField(ref _disclosedFinanceCharge, value); }

    /// <summary>
    /// Disclosed Prepayment [4018]
    /// </summary>
    public bool? DisclosedPrepayment { get => _disclosedPrepayment; set => SetField(ref _disclosedPrepayment, value); }

    /// <summary>
    /// Disclosed Product [4017]
    /// </summary>
    public string? DisclosedProduct { get => _disclosedProduct; set => SetField(ref _disclosedProduct, value); }

    /// <summary>
    /// GFE Disclosure Method [3138]
    /// </summary>
    public StringEnumValue<DisclosureMethod> DisclosureMethod { get => _disclosureMethod; set => SetField(ref _disclosureMethod, value); }

    /// <summary>
    /// Trans Details Initial/Final Disclosure [662]
    /// </summary>
    public StringEnumValue<DisclosureType> DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Period [2552]
    /// </summary>
    public int? DiscountPeriod { get => _discountPeriod; set => SetField(ref _discountPeriod, value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Rate [2551]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountRatePercent { get => _discountRatePercent; set => SetField(ref _discountRatePercent, value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Type [2307]
    /// </summary>
    public StringEnumValue<DiscountType> DiscountType { get => _discountType; set => SetField(ref _discountType, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Due Date [3287]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? DueDate { get => _dueDate; set => SetField(ref _dueDate, value); }

    /// <summary>
    /// Earliest Closing Date [3147]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? EarliestClosingDate { get => _earliestClosingDate; set => SetField(ref _earliestClosingDate, value); }

    /// <summary>
    /// Earliest Fee Collection Date [3145]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? EarliestFeeCollectionDate { get => _earliestFeeCollectionDate; set => SetField(ref _earliestFeeCollectionDate, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 1 [3985]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted1 { get => _eSignConsentBorrowerDateAccepted1; set => SetField(ref _eSignConsentBorrowerDateAccepted1, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 2 [3993]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted2 { get => _eSignConsentBorrowerDateAccepted2; set => SetField(ref _eSignConsentBorrowerDateAccepted2, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 3 [4024]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted3 { get => _eSignConsentBorrowerDateAccepted3; set => SetField(ref _eSignConsentBorrowerDateAccepted3, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 4 [4032]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted4 { get => _eSignConsentBorrowerDateAccepted4; set => SetField(ref _eSignConsentBorrowerDateAccepted4, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 5 [4040]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted5 { get => _eSignConsentBorrowerDateAccepted5; set => SetField(ref _eSignConsentBorrowerDateAccepted5, value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 6 [4048]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted6 { get => _eSignConsentBorrowerDateAccepted6; set => SetField(ref _eSignConsentBorrowerDateAccepted6, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 1 [3986]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress1 { get => _eSignConsentBorrowerIpAddress1; set => SetField(ref _eSignConsentBorrowerIpAddress1, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 2 [3994]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress2 { get => _eSignConsentBorrowerIpAddress2; set => SetField(ref _eSignConsentBorrowerIpAddress2, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 3 [4025]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress3 { get => _eSignConsentBorrowerIpAddress3; set => SetField(ref _eSignConsentBorrowerIpAddress3, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 4 [4033]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress4 { get => _eSignConsentBorrowerIpAddress4; set => SetField(ref _eSignConsentBorrowerIpAddress4, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 5 [4041]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress5 { get => _eSignConsentBorrowerIpAddress5; set => SetField(ref _eSignConsentBorrowerIpAddress5, value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 6 [4049]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress6 { get => _eSignConsentBorrowerIpAddress6; set => SetField(ref _eSignConsentBorrowerIpAddress6, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 1 [3987]
    /// </summary>
    public string? ESignConsentBorrowerSource1 { get => _eSignConsentBorrowerSource1; set => SetField(ref _eSignConsentBorrowerSource1, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 2 [3995]
    /// </summary>
    public string? ESignConsentBorrowerSource2 { get => _eSignConsentBorrowerSource2; set => SetField(ref _eSignConsentBorrowerSource2, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 3 [4026]
    /// </summary>
    public string? ESignConsentBorrowerSource3 { get => _eSignConsentBorrowerSource3; set => SetField(ref _eSignConsentBorrowerSource3, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 4 [4034]
    /// </summary>
    public string? ESignConsentBorrowerSource4 { get => _eSignConsentBorrowerSource4; set => SetField(ref _eSignConsentBorrowerSource4, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 5 [4042]
    /// </summary>
    public string? ESignConsentBorrowerSource5 { get => _eSignConsentBorrowerSource5; set => SetField(ref _eSignConsentBorrowerSource5, value); }

    /// <summary>
    /// eConsent Borrower Source Pair 6 [4050]
    /// </summary>
    public string? ESignConsentBorrowerSource6 { get => _eSignConsentBorrowerSource6; set => SetField(ref _eSignConsentBorrowerSource6, value); }

    /// <summary>
    /// Borrower 1 eConsent Status [3984]
    /// </summary>
    public string? ESignConsentBorrowerStatus1 { get => _eSignConsentBorrowerStatus1; set => SetField(ref _eSignConsentBorrowerStatus1, value); }

    /// <summary>
    /// Borrower 2 eConsent Status [3992]
    /// </summary>
    public string? ESignConsentBorrowerStatus2 { get => _eSignConsentBorrowerStatus2; set => SetField(ref _eSignConsentBorrowerStatus2, value); }

    /// <summary>
    /// Borrower 3 eConsent Status [4023]
    /// </summary>
    public string? ESignConsentBorrowerStatus3 { get => _eSignConsentBorrowerStatus3; set => SetField(ref _eSignConsentBorrowerStatus3, value); }

    /// <summary>
    /// Borrower 4 eConsent Status [4031]
    /// </summary>
    public string? ESignConsentBorrowerStatus4 { get => _eSignConsentBorrowerStatus4; set => SetField(ref _eSignConsentBorrowerStatus4, value); }

    /// <summary>
    /// Borrower 5 eConsent Status [4039]
    /// </summary>
    public string? ESignConsentBorrowerStatus5 { get => _eSignConsentBorrowerStatus5; set => SetField(ref _eSignConsentBorrowerStatus5, value); }

    /// <summary>
    /// Borrower 6 eConsent Status [4047]
    /// </summary>
    public string? ESignConsentBorrowerStatus6 { get => _eSignConsentBorrowerStatus6; set => SetField(ref _eSignConsentBorrowerStatus6, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 1 [3989]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted1 { get => _eSignConsentCoBorrowerDateAccepted1; set => SetField(ref _eSignConsentCoBorrowerDateAccepted1, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 2 [3997]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted2 { get => _eSignConsentCoBorrowerDateAccepted2; set => SetField(ref _eSignConsentCoBorrowerDateAccepted2, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 3 [4028]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted3 { get => _eSignConsentCoBorrowerDateAccepted3; set => SetField(ref _eSignConsentCoBorrowerDateAccepted3, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 4 [4036]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted4 { get => _eSignConsentCoBorrowerDateAccepted4; set => SetField(ref _eSignConsentCoBorrowerDateAccepted4, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 5 [4044]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted5 { get => _eSignConsentCoBorrowerDateAccepted5; set => SetField(ref _eSignConsentCoBorrowerDateAccepted5, value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 6 [4052]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted6 { get => _eSignConsentCoBorrowerDateAccepted6; set => SetField(ref _eSignConsentCoBorrowerDateAccepted6, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 1 [3990]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress1 { get => _eSignConsentCoBorrowerIpAddress1; set => SetField(ref _eSignConsentCoBorrowerIpAddress1, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 2 [3998]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress2 { get => _eSignConsentCoBorrowerIpAddress2; set => SetField(ref _eSignConsentCoBorrowerIpAddress2, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 3 [4029]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress3 { get => _eSignConsentCoBorrowerIpAddress3; set => SetField(ref _eSignConsentCoBorrowerIpAddress3, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 4 [4037]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress4 { get => _eSignConsentCoBorrowerIpAddress4; set => SetField(ref _eSignConsentCoBorrowerIpAddress4, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 5 [4045]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress5 { get => _eSignConsentCoBorrowerIpAddress5; set => SetField(ref _eSignConsentCoBorrowerIpAddress5, value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 6 [4053]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress6 { get => _eSignConsentCoBorrowerIpAddress6; set => SetField(ref _eSignConsentCoBorrowerIpAddress6, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 1 [3991]
    /// </summary>
    public string? ESignConsentCoBorrowerSource1 { get => _eSignConsentCoBorrowerSource1; set => SetField(ref _eSignConsentCoBorrowerSource1, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 2 [3999]
    /// </summary>
    public string? ESignConsentCoBorrowerSource2 { get => _eSignConsentCoBorrowerSource2; set => SetField(ref _eSignConsentCoBorrowerSource2, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 3 [4030]
    /// </summary>
    public string? ESignConsentCoBorrowerSource3 { get => _eSignConsentCoBorrowerSource3; set => SetField(ref _eSignConsentCoBorrowerSource3, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 4 [4038]
    /// </summary>
    public string? ESignConsentCoBorrowerSource4 { get => _eSignConsentCoBorrowerSource4; set => SetField(ref _eSignConsentCoBorrowerSource4, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 5 [4046]
    /// </summary>
    public string? ESignConsentCoBorrowerSource5 { get => _eSignConsentCoBorrowerSource5; set => SetField(ref _eSignConsentCoBorrowerSource5, value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 6 [4054]
    /// </summary>
    public string? ESignConsentCoBorrowerSource6 { get => _eSignConsentCoBorrowerSource6; set => SetField(ref _eSignConsentCoBorrowerSource6, value); }

    /// <summary>
    /// Co-Borrower 1 eConsent Status [3988]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus1 { get => _eSignConsentCoBorrowerStatus1; set => SetField(ref _eSignConsentCoBorrowerStatus1, value); }

    /// <summary>
    /// Co-Borrower 2 eConsent Status [3996]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus2 { get => _eSignConsentCoBorrowerStatus2; set => SetField(ref _eSignConsentCoBorrowerStatus2, value); }

    /// <summary>
    /// Co-Borrower 3 eConsent Status [4027]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus3 { get => _eSignConsentCoBorrowerStatus3; set => SetField(ref _eSignConsentCoBorrowerStatus3, value); }

    /// <summary>
    /// Co-Borrower 4 eConsent Status [4035]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus4 { get => _eSignConsentCoBorrowerStatus4; set => SetField(ref _eSignConsentCoBorrowerStatus4, value); }

    /// <summary>
    /// Co-Borrower 5 eConsent Status [4043]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus5 { get => _eSignConsentCoBorrowerStatus5; set => SetField(ref _eSignConsentCoBorrowerStatus5, value); }

    /// <summary>
    /// Co-Borrower 6 eConsent Status [4051]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus6 { get => _eSignConsentCoBorrowerStatus6; set => SetField(ref _eSignConsentCoBorrowerStatus6, value); }

    /// <summary>
    /// eConsent Date [3983]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ESignConsentDate { get => _eSignConsentDate; set => SetField(ref _eSignConsentDate, value); }

    /// <summary>
    /// Flag to know whether loan is external eConsent [4499]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ExternaleConsent { get => _externaleConsent; set => SetField(ref _externaleConsent, value); }

    /// <summary>
    /// Trans Details Amort Type GPM Extra Pymt [312]
    /// </summary>
    public decimal? ExtraPaymentForEarlyPayOff { get => _extraPaymentForEarlyPayOff; set => SetField(ref _extraPaymentForEarlyPayOff, value); }

    /// <summary>
    /// Fee Collected Date [3146]
    /// </summary>
    public DateTime? FeeCollectedDate { get => _feeCollectedDate; set => SetField(ref _feeCollectedDate, value); }

    /// <summary>
    /// Fee Level Disclosures Indicator [4461]
    /// </summary>
    public bool? FeeLevelDisclosuresIndicator { get => _feeLevelDisclosuresIndicator; set => SetField(ref _feeLevelDisclosuresIndicator, value); }

    /// <summary>
    /// Trans Details Filing Fees [1707]
    /// </summary>
    public decimal? FilingFees { get => _filingFees; set => SetField(ref _filingFees, value); }

    /// <summary>
    /// REGZ Construction Mortgage Final Pymt Date [1961]
    /// </summary>
    public DateTime? FinalPaymentDate { get => _finalPaymentDate; set => SetField(ref _finalPaymentDate, value); }

    /// <summary>
    /// Fees Total Finance Charges [1206]
    /// </summary>
    public decimal? FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }

    /// <summary>
    /// Financed Guarantee Fee - Guarantee Amount [3561]
    /// </summary>
    public decimal? FinancedAllGuaranteeFeeAmount { get => _financedAllGuaranteeFeeAmount; set => SetField(ref _financedAllGuaranteeFeeAmount, value); }

    /// <summary>
    /// Financed Guarantee Fee - Guarantee Percentage [3560]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"0.50\":\"0.50\",\"1.00\":\"1.00\",\"1.25\":\"1.25\",\"1.50\":\"1.50\",\"1.75\":\"1.75\",\"2.00\":\"2.00\",\"2.25\":\"2.25\",\"2.50\":\"2.50\",\"2.75\":\"2.75\",\"3.00\":\"3.00\",\"3.25\":\"3.25\",\"3.50\":\"3.50\",\"3.75\":\"3.75\",\"4.00\":\"4.00\"}")]
    public decimal? FinancedAllGuaranteeFeePercent { get => _financedAllGuaranteeFeePercent; set => SetField(ref _financedAllGuaranteeFeePercent, value); }

    /// <summary>
    /// Financed Guarantee Fee - Total Loan Amount [3562]
    /// </summary>
    public decimal? FinancedAllTotalLoanAmount { get => _financedAllTotalLoanAmount; set => SetField(ref _financedAllTotalLoanAmount, value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Guarantee Amount [3564]
    /// </summary>
    public decimal? FinancedPortionGuaranteeFeeAmount { get => _financedPortionGuaranteeFeeAmount; set => SetField(ref _financedPortionGuaranteeFeeAmount, value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Guarantee Percentage [3563]
    /// </summary>
    public decimal? FinancedPortionGuaranteeFeePercent { get => _financedPortionGuaranteeFeePercent; set => SetField(ref _financedPortionGuaranteeFeePercent, value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Total Loan Amount [3565]
    /// </summary>
    public decimal? FinancedPortionTotalLoanAmount { get => _financedPortionTotalLoanAmount; set => SetField(ref _financedPortionTotalLoanAmount, value); }

    /// <summary>
    /// USDA Financing Type [3566]
    /// </summary>
    public StringEnumValue<FinancingType> FinancingType { get => _financingType; set => SetField(ref _financingType, value); }

    /// <summary>
    /// REGZ Construction Mortgage 1st Amortization Date [1963]
    /// </summary>
    public DateTime? FirstAmortizationPaymentDate { get => _firstAmortizationPaymentDate; set => SetField(ref _firstAmortizationPaymentDate, value); }

    /// <summary>
    /// Insurance Flood [676]
    /// </summary>
    public bool? FloodInsuranceIndicator { get => _floodInsuranceIndicator; set => SetField(ref _floodInsuranceIndicator, value); }

    /// <summary>
    /// Application Date [3142]
    /// </summary>
    public DateTime? GfeApplicationDate { get => _gfeApplicationDate; set => SetField(ref _gfeApplicationDate, value); }

    /// <summary>
    /// Changed Circumstance Chkbx [3168]
    /// </summary>
    public bool? GfeChangedCircumstanceIndicator { get => _gfeChangedCircumstanceIndicator; set => SetField(ref _gfeChangedCircumstanceIndicator, value); }

    /// <summary>
    /// GFE Changed Circumstance [3169]
    /// </summary>
    public string? GfeChangedCircumstanceItem { get => _gfeChangedCircumstanceItem; set => SetField(ref _gfeChangedCircumstanceItem, value); }

    /// <summary>
    /// GFE Changed Circumstance Code [3627]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? GfeChangedCirsumstanceItemCode { get => _gfeChangedCirsumstanceItemCode; set => SetField(ref _gfeChangedCirsumstanceItemCode, value); }

    /// <summary>
    /// GFE Date for Printed Form [3170]
    /// </summary>
    public DateTime? GfeDate { get => _gfeDate; set => SetField(ref _gfeDate, value); }

    /// <summary>
    /// GFE Expiration Date [3140]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeExpirationDate { get => _gfeExpirationDate; set => SetField(ref _gfeExpirationDate, value); }

    /// <summary>
    /// No. of Days GFE Valid After Received [3162]
    /// </summary>
    public string? GfeExpirationPeriod { get => _gfeExpirationPeriod; set => SetField(ref _gfeExpirationPeriod, value); }

    /// <summary>
    /// GFE Redisclosure Required Due to Rate Lock [3201]
    /// </summary>
    public bool? GfeRateLockRedisclosureRequiredIndicator { get => _gfeRateLockRedisclosureRequiredIndicator; set => SetField(ref _gfeRateLockRedisclosureRequiredIndicator, value); }

    /// <summary>
    /// GFE Redisclosure Provided Date [3150]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeRedisclosureProvidedDate { get => _gfeRedisclosureProvidedDate; set => SetField(ref _gfeRedisclosureProvidedDate, value); }

    /// <summary>
    /// GFE Redisclosure Received Date [3151]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeRedisclosureReceivedDate { get => _gfeRedisclosureReceivedDate; set => SetField(ref _gfeRedisclosureReceivedDate, value); }

    /// <summary>
    /// Heloc Teaser Rate Period Months [4492]
    /// </summary>
    public int? HelocTeaserRatePeriod { get => _helocTeaserRatePeriod; set => SetField(ref _helocTeaserRatePeriod, value); }

    /// <summary>
    /// The Date that the High Cost Disclosure is signed [4022]
    /// </summary>
    public DateTime? HighCostDisclosure { get => _highCostDisclosure; set => SetField(ref _highCostDisclosure, value); }

    /// <summary>
    /// Date the Home Counseling Disclosure Provided to the Borrower [3859]
    /// </summary>
    public DateTime? HomeCounselingProvidedDate { get => _homeCounselingProvidedDate; set => SetField(ref _homeCounselingProvidedDate, value); }

    /// <summary>
    /// HUD-1Tolerance Lmt Violation [3160]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? Hud1ToleranceViolatedIndicator { get => _hud1ToleranceViolatedIndicator; set => SetField(ref _hud1ToleranceViolatedIndicator, value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution Comments [3172]
    /// </summary>
    public string? HudToleranceResolutionComments { get => _hudToleranceResolutionComments; set => SetField(ref _hudToleranceResolutionComments, value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution Date [3171]
    /// </summary>
    public DateTime? HudToleranceResolutionDate { get => _hudToleranceResolutionDate; set => SetField(ref _hudToleranceResolutionDate, value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution User [3173]
    /// </summary>
    public string? HudToleranceResolvedBy { get => _hudToleranceResolvedBy; set => SetField(ref _hudToleranceResolvedBy, value); }

    /// <summary>
    /// Insurance Premium If you purchase [1708]
    /// </summary>
    public bool? IfYouPurchaseIndicator { get => _ifYouPurchaseIndicator; set => SetField(ref _ifYouPurchaseIndicator, value); }

    /// <summary>
    /// Insurance Premium Haz/Flood/Haz&amp;Flood [1709]
    /// </summary>
    public StringEnumValue<IfYouPurchaseType> IfYouPurchaseType { get => _ifYouPurchaseType; set => SetField(ref _ifYouPurchaseType, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Mortgage Insurance [3266]
    /// </summary>
    public bool? IncludeMiIndicator { get => _includeMiIndicator; set => SetField(ref _includeMiIndicator, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Private Mortgage Insurance [3265]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? IncludePmiIndicator { get => _includePmiIndicator; set => SetField(ref _includePmiIndicator, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Escrowed Taxes and Insurance [3264]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? IncludeTaxesInsuranceIndicator { get => _includeTaxesInsuranceIndicator; set => SetField(ref _includeTaxesInsuranceIndicator, value); }

    /// <summary>
    /// Date the AVM Provided to the Borrower [3858]
    /// </summary>
    public DateTime? InitialAvmProvidedDate { get => _initialAvmProvidedDate; set => SetField(ref _initialAvmProvidedDate, value); }

    /// <summary>
    /// Initial Disclosure Due Date [3143]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialDisclosureDueDate { get => _initialDisclosureDueDate; set => SetField(ref _initialDisclosureDueDate, value); }

    /// <summary>
    /// Initial Disclosure Provided Date [3144]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialDisclosureProvidedDate { get => _initialDisclosureProvidedDate; set => SetField(ref _initialDisclosureProvidedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Affiliated Business Disclosure Provided Date [3544]
    /// </summary>
    public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get => _initialGfeAffiliatedBusinessProvidedDate; set => SetField(ref _initialGfeAffiliatedBusinessProvidedDate, value); }

    /// <summary>
    /// Date the Appraisal was provided to the Borrower [3624]
    /// </summary>
    public DateTime? InitialGfeAppraisalProvidedDate { get => _initialGfeAppraisalProvidedDate; set => SetField(ref _initialGfeAppraisalProvidedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure CHARM Booklet Provided Date [3545]
    /// </summary>
    public DateTime? InitialGfeCharmBookletProvidedDate { get => _initialGfeCharmBookletProvidedDate; set => SetField(ref _initialGfeCharmBookletProvidedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Provided Date [3148]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialGfeDisclosureProvidedDate { get => _initialGfeDisclosureProvidedDate; set => SetField(ref _initialGfeDisclosureProvidedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Received Date [3149]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialGfeDisclosureReceivedDate { get => _initialGfeDisclosureReceivedDate; set => SetField(ref _initialGfeDisclosureReceivedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure HELOC Brochure Provided Date [3547]
    /// </summary>
    public DateTime? InitialGfeHelocBrochureProvidedDate { get => _initialGfeHelocBrochureProvidedDate; set => SetField(ref _initialGfeHelocBrochureProvidedDate, value); }

    /// <summary>
    /// GFE Initial GFE Disclosure HUD Special Booklet Provided Date [3546]
    /// </summary>
    public DateTime? InitialGfeHudSpecialBookletProvidedDate { get => _initialGfeHudSpecialBookletProvidedDate; set => SetField(ref _initialGfeHudSpecialBookletProvidedDate, value); }

    /// <summary>
    /// Date the Subsequent Appraisal Provided to the Borrower [3857]
    /// </summary>
    public DateTime? InitialSubsequentAppraisalProvidedDate { get => _initialSubsequentAppraisalProvidedDate; set => SetField(ref _initialSubsequentAppraisalProvidedDate, value); }

    /// <summary>
    /// TIL Intl Disclosure Provided Date [3152]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialTilDisclosureProvidedDate { get => _initialTilDisclosureProvidedDate; set => SetField(ref _initialTilDisclosureProvidedDate, value); }

    /// <summary>
    /// TIL Intl TIL Disclosure Rcvd Date [3153]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialTilDisclosureReceivedDate { get => _initialTilDisclosureReceivedDate; set => SetField(ref _initialTilDisclosureReceivedDate, value); }

    /// <summary>
    /// Insurance Required [1702]
    /// </summary>
    public string? InsuranceRequiredDescription { get => _insuranceRequiredDescription; set => SetField(ref _insuranceRequiredDescription, value); }

    /// <summary>
    /// Interest Accrual for APR [4747]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<InterestAccrual> InterestAccrual { get => _interestAccrual; set => SetField(ref _interestAccrual, value); }

    /// <summary>
    /// Trans Details Security Interest [1603]
    /// </summary>
    public string? InterestInNameOf { get => _interestInNameOf; set => SetField(ref _interestInNameOf, value); }

    /// <summary>
    /// Interest Only Indicator [Terms.IntrOnly]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? InterestOnly { get => _interestOnly; set => SetField(ref _interestOnly, value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [2982]
    /// </summary>
    public bool? InterestOnlyIndicator { get => _interestOnlyIndicator; set => SetField(ref _interestOnlyIndicator, value); }

    /// <summary>
    /// Trans Details Interest Only Mos [1177]
    /// </summary>
    public int? InterestOnlyMonths { get => _interestOnlyMonths; set => SetField(ref _interestOnlyMonths, value); }

    /// <summary>
    /// REGZ Construction Mortgage Interest Rate Type [2820]
    /// </summary>
    public StringEnumValue<InterestRateType> InterestRateType { get => _interestRateType; set => SetField(ref _interestRateType, value); }

    /// <summary>
    /// Loan Info Constr Loan Required Resrv [1265]
    /// </summary>
    public decimal? InterestReserveAmount { get => _interestReserveAmount; set => SetField(ref _interestReserveAmount, value); }

    /// <summary>
    /// Construction Loan Info - Land Value Type [URLA.X262]
    /// </summary>
    public StringEnumValue<LandValueType> LandValueType { get => _landValueType; set => SetField(ref _landValueType, value); }

    /// <summary>
    /// GFE Last Disclosed By [3139]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastDisclosedBy { get => _lastDisclosedBy; set => SetField(ref _lastDisclosedBy, value); }

    /// <summary>
    /// GFE Last Disclosed Date [3137]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastDisclosedDate { get => _lastDisclosedDate; set => SetField(ref _lastDisclosedDate, value); }

    /// <summary>
    /// GFE Last Disclosure Rcvd Date [3163]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastDisclosedGfeReceivedDate { get => _lastDisclosedGfeReceivedDate; set => SetField(ref _lastDisclosedGfeReceivedDate, value); }

    /// <summary>
    /// Late Charge Basis [4186]
    /// </summary>
    public decimal? LateChargeBasis { get => _lateChargeBasis; set => SetField(ref _lateChargeBasis, value); }

    /// <summary>
    /// Trans Details Late Charge Additional Detail [1854]
    /// </summary>
    public string? LateChargeComments { get => _lateChargeComments; set => SetField(ref _lateChargeComments, value); }

    /// <summary>
    /// Trans Details Late Charge Days [672]
    /// </summary>
    public int? LateChargeDays { get => _lateChargeDays; set => SetField(ref _lateChargeDays, value); }

    /// <summary>
    /// Trans Details Late Charge % [674]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LateChargePercent { get => _lateChargePercent; set => SetField(ref _lateChargePercent, value); }

    /// <summary>
    /// Trans Details Late Charge % Based On [1719]
    /// </summary>
    public StringEnumValue<LateChargeType> LateChargeType { get => _lateChargeType; set => SetField(ref _lateChargeType, value); }

    /// <summary>
    /// Trans Details Late Fee [3876]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }

    /// <summary>
    /// LE Intent To Proceed Comment [3976]
    /// </summary>
    public string? LeIntentToProceedComment { get => _leIntentToProceedComment; set => SetField(ref _leIntentToProceedComment, value); }

    /// <summary>
    /// Lender Paid Mortgage Insurance [3533]
    /// </summary>
    public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => SetField(ref _lenderPaidMortgageInsuranceIndicator, value); }

    /// <summary>
    /// REGZ Construction Mortgage Lenders Inspection Rate [3899]
    /// </summary>
    public decimal? LendersInspectionFee { get => _lendersInspectionFee; set => SetField(ref _lendersInspectionFee, value); }

    /// <summary>
    /// LE Intent To Proceed Received By [3973]
    /// </summary>
    public string? LeReceivedBy { get => _leReceivedBy; set => SetField(ref _leReceivedBy, value); }

    /// <summary>
    /// LE Intent To Proceed Received Method [3974]
    /// </summary>
    public StringEnumValue<LEReceivedMethod> LeReceivedMethod { get => _leReceivedMethod; set => SetField(ref _leReceivedMethod, value); }

    /// <summary>
    /// LE Intent To Proceed Received Method Other [3975]
    /// </summary>
    public string? LeReceivedMethodOther { get => _leReceivedMethodOther; set => SetField(ref _leReceivedMethodOther, value); }

    /// <summary>
    /// LE Intent To Proceed Sent On Date [3972]
    /// </summary>
    public DateTime? LeSentOnDate { get => _leSentOnDate; set => SetField(ref _leSentOnDate, value); }

    /// <summary>
    /// Loan Info ARM Margin + Index [1827]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MarginPlusIndexPercent { get => _marginPlusIndexPercent; set => SetField(ref _marginPlusIndexPercent, value); }

    /// <summary>
    /// Trans Details Maximum Late Charge [2832]
    /// </summary>
    public decimal? MaximumLateCharge { get => _maximumLateCharge; set => SetField(ref _maximumLateCharge, value); }

    /// <summary>
    /// Prequal Maximum Payment [1896]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumPayment { get => _maximumPayment; set => SetField(ref _maximumPayment, value); }

    /// <summary>
    /// Trans Details E Means Estimate [680]
    /// </summary>
    public bool? MeansAnEstimateIndicator { get => _meansAnEstimateIndicator; set => SetField(ref _meansAnEstimateIndicator, value); }

    /// <summary>
    /// Insurance Mtg Ins Periodic Factor 2 [1201]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? MiAdjustmentFactorLevel2 { get => _miAdjustmentFactorLevel2; set => SetField(ref _miAdjustmentFactorLevel2, value); }

    /// <summary>
    /// Insurance Mtg Declining Renewals [3248]
    /// </summary>
    public bool? MiDecliningRenewalsIndicator { get => _miDecliningRenewalsIndicator; set => SetField(ref _miDecliningRenewalsIndicator, value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Midpoint Pymt Cancel [1753]
    /// </summary>
    public string? MidpointCancellation { get => _midpointCancellation; set => SetField(ref _midpointCancellation, value); }

    /// <summary>
    /// Insurance Mtg Ins Pymt 1 [1766]
    /// </summary>
    public decimal? MiMonthlyPaymentLevel1 { get => _miMonthlyPaymentLevel1; set => SetField(ref _miMonthlyPaymentLevel1, value); }

    /// <summary>
    /// Insurance Mtg Ins Pymt 2 [1770]
    /// </summary>
    public decimal? MiMonthlyPaymentLevel2 { get => _miMonthlyPaymentLevel2; set => SetField(ref _miMonthlyPaymentLevel2, value); }

    /// <summary>
    /// Insurance Mtg Ins Period 1 [1198]
    /// </summary>
    public int? MiMonthsOfAdjustmentLevel1 { get => _miMonthsOfAdjustmentLevel1; set => SetField(ref _miMonthsOfAdjustmentLevel1, value); }

    /// <summary>
    /// Insurance Mtg Ins Period 2 [1200]
    /// </summary>
    public int? MiMonthsOfAdjustmentLevel2 { get => _miMonthsOfAdjustmentLevel2; set => SetField(ref _miMonthsOfAdjustmentLevel2, value); }

    /// <summary>
    /// Trans Details Minimum Late Charge [2831]
    /// </summary>
    public decimal? MinimumLateCharge { get => _minimumLateCharge; set => SetField(ref _minimumLateCharge, value); }

    /// <summary>
    /// Prequal Minimum Payment [1895]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumPayment { get => _minimumPayment; set => SetField(ref _minimumPayment, value); }

    /// <summary>
    /// MI Factor Field Locked [3625]
    /// </summary>
    public bool? MipFactorLocked { get => _mipFactorLocked; set => SetField(ref _mipFactorLocked, value); }

    /// <summary>
    /// MI Prepaid Amount [3971]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MiPrepaidAmount { get => _miPrepaidAmount; set => SetField(ref _miPrepaidAmount, value); }

    /// <summary>
    /// Insurance Mtg Ins Mnths Prepaid [2978]
    /// </summary>
    public bool? MiPrepaidIndicator { get => _miPrepaidIndicator; set => SetField(ref _miPrepaidIndicator, value); }

    /// <summary>
    /// Insurance Calculation Borr MI Termination Date [118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MiScheduledTerminationDate { get => _miScheduledTerminationDate; set => SetField(ref _miScheduledTerminationDate, value); }

    /// <summary>
    /// Insurance MMI [723]
    /// </summary>
    public bool? MmiIndicator { get => _mmiIndicator; set => SetField(ref _mmiIndicator, value); }

    /// <summary>
    /// Insurance Premium 1 Monthly Term Pymt [4081]
    /// </summary>
    public decimal? MonthlyTerm { get => _monthlyTerm; set => SetField(ref _monthlyTerm, value); }

    /// <summary>
    /// Insurance Mtg Ins Mos Prepaid [1209]
    /// </summary>
    public int? MonthsOfMiPrepaid { get => _monthsOfMiPrepaid; set => SetField(ref _monthsOfMiPrepaid, value); }

    /// <summary>
    /// Insurance Mtg Ins Cancel at % [1205]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => SetField(ref _mortgageInsuranceCancelPercent, value); }

    /// <summary>
    /// Loan Info Prepared By Name [2026]
    /// </summary>
    public string? NamePreparedBy { get => _namePreparedBy; set => SetField(ref _namePreparedBy, value); }

    /// <summary>
    /// Construction Loan New Construction Indicator [2645]
    /// </summary>
    public string? NewConstructionIndicator { get => _newConstructionIndicator; set => SetField(ref _newConstructionIndicator, value); }

    /// <summary>
    /// REGZ Total # Pymts [1701]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? NumberOfPayments { get => _numberOfPayments; set => SetField(ref _numberOfPayments, value); }

    /// <summary>
    /// Occupancy Cert Date [4080]
    /// </summary>
    public DateTime? OccupancyCertDate { get => _occupancyCertDate; set => SetField(ref _occupancyCertDate, value); }

    /// <summary>
    /// Construction Loan Original Contract Date [2646]
    /// </summary>
    public DateTime? OriginalContractDate { get => _originalContractDate; set => SetField(ref _originalContractDate, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Outstanding Balance [3288]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OutstandingBalance { get => _outstandingBalance; set => SetField(ref _outstandingBalance, value); }

    /// <summary>
    /// REGZ Payment Frequency Type Description [3291]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PaymentFrequencyType { get => _paymentFrequencyType; set => SetField(ref _paymentFrequencyType, value); }

    /// <summary>
    /// GPM Payment Increase [Terms.GPMPmtIncr]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PaymentIncreasePercent { get => _paymentIncreasePercent; set => SetField(ref _paymentIncreasePercent, value); }

    /// <summary>
    /// Loan Info Prepared By Phone [2027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhonePreparedBy { get => _phonePreparedBy; set => SetField(ref _phonePreparedBy, value); }

    /// <summary>
    /// Insurance PMI [8]
    /// </summary>
    public bool? PmiIndicator { get => _pmiIndicator; set => SetField(ref _pmiIndicator, value); }

    /// <summary>
    /// PMI Midpoint Cancelation Date [3548]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PmiMidpointCancelationDate { get => _pmiMidpointCancelationDate; set => SetField(ref _pmiMidpointCancelationDate, value); }

    /// <summary>
    /// Post Consummation Disclosure Received Date [3982]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PostConsummationDisclosureReceivedDate { get => _postConsummationDisclosureReceivedDate; set => SetField(ref _postConsummationDisclosureReceivedDate, value); }

    /// <summary>
    /// Post Consummation Disclosure Sent Date [3981]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PostConsummationDisclosureSentDate { get => _postConsummationDisclosureSentDate; set => SetField(ref _postConsummationDisclosureSentDate, value); }

    /// <summary>
    /// Fees Total Prepaid Finance Charges [949]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrepaidFinanceCharge { get => _prepaidFinanceCharge; set => SetField(ref _prepaidFinanceCharge, value); }

    /// <summary>
    /// Insurance Property [1242]
    /// </summary>
    public bool? PropertyInsuranceIndicator { get => _propertyInsuranceIndicator; set => SetField(ref _propertyInsuranceIndicator, value); }

    /// <summary>
    /// Rate Lock GFE Due Date [3161]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RateLockGfeDueDate { get => _rateLockGfeDueDate; set => SetField(ref _rateLockGfeDueDate, value); }

    /// <summary>
    /// Trans Details Amort Type GPM Rate [1267]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RatePercent { get => _ratePercent; set => SetField(ref _ratePercent, value); }

    /// <summary>
    /// Loan Info ARM Recast Period [1712]
    /// </summary>
    public int? RecastPaidMonths { get => _recastPaidMonths; set => SetField(ref _recastPaidMonths, value); }

    /// <summary>
    /// Loan Info ARM Recast Stop [1713]
    /// </summary>
    public int? RecastStopMonths { get => _recastStopMonths; set => SetField(ref _recastStopMonths, value); }

    /// <summary>
    /// Trans Details Prepymt - May/Will Not Refund [670]
    /// </summary>
    public bool? RefundPaymentIndicator { get => _refundPaymentIndicator; set => SetField(ref _refundPaymentIndicator, value); }

    /// <summary>
    /// Refund prorated unearned Up Front MI Premiums [3262]
    /// </summary>
    public bool? RefundUnearnedMipIndicator { get => _refundUnearnedMipIndicator; set => SetField(ref _refundUnearnedMipIndicator, value); }

    /// <summary>
    /// RegulationZContract RegulationZInterestRatePeriods
    /// </summary>
    [AllowNull]
    public IList<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get => GetField(ref _regulationZInterestRatePeriods); set => SetField(ref _regulationZInterestRatePeriods, value); }

    /// <summary>
    /// RegulationZContract RegulationZPayments
    /// </summary>
    [AllowNull]
    public IList<RegulationZPayment> RegulationZPayments { get => GetField(ref _regulationZPayments); set => SetField(ref _regulationZPayments, value); }

    /// <summary>
    /// REGZ Summary Table Type Used in REGZ-TIL Output [REGZ_TABLETYPE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RegzTableType { get => _regzTableType; set => SetField(ref _regzTableType, value); }

    /// <summary>
    /// REGZ Pymt Sched Required Deposit [664]
    /// </summary>
    public bool? RequiredDepositIndicator { get => _requiredDepositIndicator; set => SetField(ref _requiredDepositIndicator, value); }

    /// <summary>
    /// Revised Closing Disclosure received date [3980]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedClosingDisclosureReceivedDate { get => _revisedClosingDisclosureReceivedDate; set => SetField(ref _revisedClosingDisclosureReceivedDate, value); }

    /// <summary>
    /// Revised Closing Disclosure sent date [3979]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedClosingDisclosureSentDate { get => _revisedClosingDisclosureSentDate; set => SetField(ref _revisedClosingDisclosureSentDate, value); }

    /// <summary>
    /// Revised GFE Due Date [3167]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedGfeDueDate { get => _revisedGfeDueDate; set => SetField(ref _revisedGfeDueDate, value); }

    /// <summary>
    /// Loan Info ARM Rounded Margin + Index [3296]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RoundedMarginPlusIndexPercent { get => _roundedMarginPlusIndexPercent; set => SetField(ref _roundedMarginPlusIndexPercent, value); }

    /// <summary>
    /// Safe Harbor Sent Date [4015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SafeHarborSentDate { get => _safeHarborSentDate; set => SetField(ref _safeHarborSentDate, value); }

    /// <summary>
    /// Prequal Sample Pymt Amt [1958]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SamplePayments { get => _samplePayments; set => SetField(ref _samplePayments, value); }

    /// <summary>
    /// Trans Details Goods Prchsd/Prprty Owned [671]
    /// </summary>
    public StringEnumValue<SecurityType> SecurityType { get => _securityType; set => SetField(ref _securityType, value); }

    /// <summary>
    /// Use Simple Interest Accrual [4749]
    /// </summary>
    public bool? SimpleInterestAccrualIndicator { get => _simpleInterestAccrualIndicator; set => SetField(ref _simpleInterestAccrualIndicator, value); }

    /// <summary>
    /// Simple Interest Uses Leap Year [4748]
    /// </summary>
    public bool? SimpleInterestLeapYearIndicator { get => _simpleInterestLeapYearIndicator; set => SetField(ref _simpleInterestLeapYearIndicator, value); }

    /// <summary>
    /// Settlement Services Provider List Sent Date [4014]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SsplSentDate { get => _ssplSentDate; set => SetField(ref _ssplSentDate, value); }

    /// <summary>
    /// Trans Details Disclosed Date [3122]
    /// </summary>
    public DateTime? TilDate { get => _tilDate; set => SetField(ref _tilDate, value); }

    /// <summary>
    /// TIL Disclosed Comments [3159]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TilDisclosedComments { get => _tilDisclosedComments; set => SetField(ref _tilDisclosedComments, value); }

    /// <summary>
    /// TIL Disclosure Method Drpdwn [3157]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<DisclosureMethod> TilDisclosureMethod { get => _tilDisclosureMethod; set => SetField(ref _tilDisclosureMethod, value); }

    /// <summary>
    /// TIL Last Disclosed Borrower Received Date [3247]
    /// </summary>
    public DateTime? TilLastDisclosedBorrowerReceivedDate { get => _tilLastDisclosedBorrowerReceivedDate; set => SetField(ref _tilLastDisclosedBorrowerReceivedDate, value); }

    /// <summary>
    /// TIL Last Disclosed By [3158]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TilLastDisclosedBy { get => _tilLastDisclosedBy; set => SetField(ref _tilLastDisclosedBy, value); }

    /// <summary>
    ///  Last CD Sent Date [3156]
    /// </summary>
    public DateTime? TilLastDisclosedDate { get => _tilLastDisclosedDate; set => SetField(ref _tilLastDisclosedDate, value); }

    /// <summary>
    /// TIL Redisclosure Provided Date [3154]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? TilRedisclosureProvidedDate { get => _tilRedisclosureProvidedDate; set => SetField(ref _tilRedisclosureProvidedDate, value); }

    /// <summary>
    /// TIL Redisclosure Rcvd Date [3155]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? TilRedisclosureReceivedDate { get => _tilRedisclosureReceivedDate; set => SetField(ref _tilRedisclosureReceivedDate, value); }

    /// <summary>
    /// Total Broker Fees Collected [3310]
    /// </summary>
    public decimal? TotalBrokerFees { get => _totalBrokerFees; set => SetField(ref _totalBrokerFees, value); }

    /// <summary>
    /// Trans Details Total Late Payment [3877]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLatePayment { get => _totalLatePayment; set => SetField(ref _totalLatePayment, value); }

    /// <summary>
    /// Total Lender Fees Collected [3311]
    /// </summary>
    public decimal? TotalLenderFees { get => _totalLenderFees; set => SetField(ref _totalLenderFees, value); }

    /// <summary>
    /// REGZ Total Amt All Pymts [1207]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOfPayments { get => _totalOfPayments; set => SetField(ref _totalOfPayments, value); }

    /// <summary>
    /// REGZ Total Amt All Principal and Interest [4071]
    /// </summary>
    public decimal? TotalOfPrincipalAndInterest { get => _totalOfPrincipalAndInterest; set => SetField(ref _totalOfPrincipalAndInterest, value); }

    /// <summary>
    /// Use Custom Lender Profile [3626]
    /// </summary>
    public bool? UseCustomLenderProfile { get => _useCustomLenderProfile; set => SetField(ref _useCustomLenderProfile, value); }

    /// <summary>
    /// Trans Details Amort Type Biweekly Days/Yr [SYS.X2]
    /// </summary>
    public StringEnumValue<DaysInYear> UseDaysInYears { get => _useDaysInYears; set => SetField(ref _useDaysInYears, value); }

    /// <summary>
    /// Trans Details Qualify Using P&amp;I [1853]
    /// </summary>
    public bool? UsePitiForRatioIndicator { get => _usePitiForRatioIndicator; set => SetField(ref _usePitiForRatioIndicator, value); }

    /// <summary>
    /// REGZ Pymt Sched Variable Rate Feature [665]
    /// </summary>
    public bool? VariableRateFeatureIndicator { get => _variableRateFeatureIndicator; set => SetField(ref _variableRateFeatureIndicator, value); }

    /// <summary>
    /// Insurance Premium 1 Yr Term Pymt [1710]
    /// </summary>
    public decimal? YearlyTerm { get => _yearlyTerm; set => SetField(ref _yearlyTerm, value); }

    /// <summary>
    /// Prequal Max Pymt Yr [1957]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? YearOfMaximumPayment { get => _yearOfMaximumPayment; set => SetField(ref _yearOfMaximumPayment, value); }

    /// <summary>
    /// Trans Details Amort Type GPM Yrs [1266]
    /// </summary>
    public int? Years { get => _years; set => SetField(ref _years, value); }

    /// <summary>
    /// Zero Percent Payment Options [4746]
    /// </summary>
    public StringEnumValue<ZeroPercentPaymentOption> ZeroPercentPaymentOption { get => _zeroPercentPaymentOption; set => SetField(ref _zeroPercentPaymentOption, value); }
}