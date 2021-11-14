using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Correspondent
    /// </summary>
    public sealed partial class Correspondent : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _abaNumber;
        private DirtyValue<string?>? _accountNumber;
        private DirtyValue<string?>? _accountNumber2;
        private DirtyValue<string?>? _activatedBy;
        private DirtyValue<DateTime?>? _activatedDate;
        private DirtyValue<decimal?>? _additionalFloodCoverage;
        private DirtyValue<decimal?>? _additionalHazardCoverage;
        private DirtyValue<string?>? _additionalInsuranceCompanyName;
        private DirtyValue<decimal?>? _additionalInsuranceCoverage;
        private DirtyValue<decimal?>? _additionalInsuranceCoverageAmount;
        private DirtyValue<int?>? _additionalInsuranceCoverageTerm;
        private DirtyValue<decimal?>? _additionalInsuranceDeductible;
        private DirtyValue<string?>? _additionalInsuranceEstimator;
        private DirtyValue<bool?>? _additionalInsuranceExcludePitiPayment;
        private DirtyValue<bool?>? _additionalInsuranceGuaranteedReplacementCost;
        private DirtyValue<decimal?>? _additionalInsuranceMonthlyAmount;
        private DirtyValue<string?>? _additionalInsurancePaymentType;
        private DirtyValue<DateTime?>? _additionalInsurancePolicyEffectiveDate;
        private DirtyValue<DateTime?>? _additionalInsurancePolicyExpirationDate;
        private DirtyValue<string?>? _additionalInsurancePolicyNumber;
        private DirtyValue<decimal?>? _additionalInsurancePolicyPremium;
        private DirtyValue<string?>? _additionalInsurancePolicyType;
        private DirtyValue<DateTime?>? _additionalInsurancePremiumDueDate;
        private DirtyValue<string?>? _additionalInsuranceType;
        private DirtyValue<decimal?>? _additionalLateFeeCharge;
        private DirtyValue<decimal?>? _additionalWindCoverage;
        private DirtyValue<decimal?>? _afterImprovedLtv;
        private DirtyValue<decimal?>? _aggregateAdjustment;
        private DirtyValue<string?>? _alternateLoanNumber;
        private DirtyValue<decimal?>? _amountFinanced;
        private DirtyValue<decimal?>? _annualMipRate;
        private DirtyValue<string?>? _appraisalAddressCounty;
        private DirtyValue<DateTime?>? _appraisalApptDate;
        private DirtyValue<bool?>? _appraisalCheckbox;
        private DirtyValue<string?>? _appraisalCountyName;
        private DirtyValue<decimal?>? _appraisalFee;
        private DirtyValue<DateTime?>? _appraisalFinalInspectionDate;
        private DirtyValue<bool?>? _appraisalFinalInspectionFlag;
        private DirtyValue<StringEnumValue<FloodZone>>? _appraisalFloodZone;
        private DirtyValue<string?>? _appraisalLegalDescription1;
        private DirtyValue<string?>? _appraisalLegalDescription2;
        private DirtyValue<StringEnumValue<AppraisalPropertyType>>? _appraisalPropertyType;
        private DirtyValue<string?>? _appraisalUsage;
        private DirtyValue<bool?>? _appraisalWaiver;
        private DirtyValue<string?>? _appraisedCondition;
        private DirtyValue<int?>? _appraisedValue;
        private DirtyValue<string?>? _appraiserName;
        private DirtyValue<string?>? _appraisersLicenseNumber;
        private DirtyValue<string?>? _appraisersPropertyAddress1;
        private DirtyValue<string?>? _appraisersPropertyAddress2;
        private DirtyValue<string?>? _appraisersStateLicenseNumber;
        private DirtyValue<string?>? _appraiserSupervisorsName;
        private DirtyValue<DateTime?>? _approvedToFundDate;
        private DirtyValue<decimal?>? _aprPercent;
        private DirtyValue<decimal?>? _armIndex;
        private DirtyValue<bool?>? _armIndicator;
        private DirtyValue<decimal?>? _armMargin;
        private DirtyValue<decimal?>? _armMargin2;
        private DirtyValue<decimal?>? _armRateFloor;
        private DirtyValue<decimal?>? _armRateFloor2;
        private DirtyValue<StringEnumValue<AssignmentType>>? _assignmentType;
        private DirtyValue<int?>? _ausAppraisedValue;
        private DirtyValue<decimal?>? _ausAssetsToBeVerified;
        private DirtyValue<decimal?>? _ausCltv;
        private DirtyValue<string?>? _ausCreditReportCertNumber;
        private DirtyValue<DateTime?>? _ausCreditReportDate;
        private DirtyValue<string?>? _ausFreeFormComments;
        private DirtyValue<decimal?>? _ausHcltv;
        private DirtyValue<decimal?>? _ausInterestRate;
        private DirtyValue<decimal?>? _ausLoanAmount;
        private DirtyValue<string?>? _ausLoanNumber;
        private DirtyValue<decimal?>? _ausLtv;
        private DirtyValue<decimal?>? _ausPrimaryHousingExpense;
        private DirtyValue<string?>? _ausPropertyAddress1;
        private DirtyValue<string?>? _ausPropertyAddress2;
        private DirtyValue<string?>? _ausPropertyCity;
        private DirtyValue<StringEnumValue<State>>? _ausPropertyState;
        private DirtyValue<string?>? _ausPropertyZip;
        private DirtyValue<decimal?>? _ausPurchasePrice;
        private DirtyValue<string?>? _ausReferenceNumber;
        private DirtyValue<string?>? _ausSubmissionNumber;
        private DirtyValue<decimal?>? _ausTotalAvailableAssets;
        private DirtyValue<decimal?>? _ausTotalDti;
        private DirtyValue<decimal?>? _ausTotalMonthlyDebt;
        private DirtyValue<decimal?>? _ausTotalMonthlyIncome;
        private DirtyValue<bool?>? _autoPublishConditions;
        private DirtyValue<decimal?>? _averagePrimeOfferRate;
        private DirtyValue<decimal?>? _avmAppraisedValue;
        private DirtyValue<bool?>? _avmCheckbox;
        private DirtyValue<string?>? _avmConfidenceScore;
        private DirtyValue<DateTime?>? _avmOrderDate;
        private DirtyValue<string?>? _avmOrderNumber;
        private DirtyValue<string?>? _avmType;
        private DirtyValue<string?>? _bankAddress;
        private DirtyValue<string?>? _bankAddress2;
        private DirtyValue<string?>? _bankAddressCity;
        private DirtyValue<StringEnumValue<State>>? _bankAddressState;
        private DirtyValue<string?>? _bankName;
        private DirtyValue<string?>? _bankZip;
        private DirtyValue<decimal?>? _baseLoanAmount;
        private DirtyValue<decimal?>? _basePrice;
        private DirtyValue<decimal?>? _borPaidDiscountPoints;
        private DirtyValue<decimal?>? _borrowerRequestedLoanAmount;
        private DirtyValue<bool?>? _borrowerSignedIndicator;
        private DirtyValue<decimal?>? _bottomRatioPercent;
        private DirtyValue<StringEnumValue<BuildingStatusType>>? _buildingStatus;
        private DirtyValue<DateTime?>? _cancelledDate;
        private DirtyValue<bool?>? _cashOutNtbComparisonFormIndicator;
        private DirtyValue<decimal?>? _cashToOrFromBorrowerAmount;
        private DirtyValue<bool?>? _cashToOrFromBorrowerIndicator;
        private DirtyValue<decimal?>? _cdSectionjLenderCreditTotal;
        private DirtyValue<decimal?>? _cdSellerCreditAmount;
        private DirtyValue<decimal?>? _cdShoppableServices;
        private DirtyValue<decimal?>? _cdTaxesAndGovtFeesE;
        private DirtyValue<decimal?>? _cdTotalBorrowerClosingCosts;
        private DirtyValue<bool?>? _cemaIndicator;
        private DirtyValue<string?>? _censusTrack;
        private DirtyValue<bool?>? _certOfEligibilityProvided;
        private DirtyValue<bool?>? _cityTaxesExcludePitiPayment;
        private DirtyValue<string?>? _cityTaxesFrequency;
        private DirtyValue<DateTime?>? _cityTaxesNextPaymentDueDate;
        private DirtyValue<decimal?>? _closingBorrowerAdjustments;
        private DirtyValue<decimal?>? _closingCostsAmount;
        private DirtyValue<decimal?>? _closingDisclosureLenderCreditAmount;
        private DirtyValue<decimal?>? _closingDisclosureLenderPocAmount;
        private DirtyValue<string?>? _collateralTrackingNumber;
        private DirtyValue<string?>? _collateralUnderwriterScore;
        private DirtyValue<decimal?>? _combinedLtv;
        private DirtyValue<decimal?>? _commitmentAmount;
        private DirtyValue<StringEnumValue<CommitmentType>>? _commitmentType;
        private DirtyValue<DateTime?>? _conditionsReceivedDate;
        private DirtyValue<string?>? _condoProjectClass;
        private DirtyValue<string?>? _condoProjectStatusType;
        private DirtyValue<DateTime?>? _conversionModificationDate;
        private DirtyValue<DateTime?>? _correspondentCommitmentDate;
        private DirtyValue<DateTime?>? _correspondentCommitmentExpirationDate;
        private DirtyValue<int?>? _correspondentCommitmentPeriod;
        private DirtyValue<bool?>? _correspondentLoanMiIndicator;
        private DirtyValue<StringEnumValue<CorrespondentStatus>>? _correspondentStatus;
        private DirtyList<CorrOtherInsurance>? _corrOtherInsurances;
        private DirtyValue<bool?>? _countyTaxesExcludePitiPayment;
        private DirtyValue<string?>? _countyTaxesFrequency;
        private DirtyValue<decimal?>? _countyTaxesMonthlyAmount;
        private DirtyValue<DateTime?>? _countyTaxesNextPaymentDueDate;
        private DirtyValue<decimal?>? _creditReport;
        private DirtyValue<decimal?>? _currentFinanceCharge;
        private DirtyValue<string?>? _customMinimumMi;
        private DirtyValue<DateTime?>? _dateOfSale;
        private DirtyValue<DateTime?>? _deliveryExpirationDate;
        private DirtyValue<string?>? _deliveryType;
        private DirtyValue<decimal?>? _disclosedAprPercent;
        private DirtyValue<decimal?>? _disclosedDailyInterestCharge;
        private DirtyValue<decimal?>? _disclosedFinanceCharge;
        private DirtyValue<decimal?>? _disclosedTemporaryBuydownFund;
        private DirtyValue<decimal?>? _disclosedTotalPayments;
        private DirtyValue<decimal?>? _disclosedUpfrontMipFinanced;
        private DirtyValue<DateTime?>? _disclosureLastSentDate;
        private DirtyValue<DateTime?>? _disclosureReceivedDate;
        private DirtyList<Disclosure>? _disclosures;
        private DirtyValue<decimal?>? _discountPointsApplied;
        private DirtyValue<decimal?>? _discountPointsPaidbyOther;
        private DirtyValue<DateTime?>? _documentReceiptDate;
        private DirtyList<EarlyCheck>? _earlyChecks;
        private DirtyValue<decimal?>? _ecAppraisalValue;
        private DirtyValue<string?>? _ecDoumentFileId;
        private DirtyValue<decimal?>? _effectivePropertyValue;
        private DirtyValue<bool?>? _energyEfficientIndicator;
        private DirtyValue<bool?>? _eNoteIndicator;
        private DirtyValue<decimal?>? _escrowHoldback;
        private DirtyValue<decimal?>? _escrowReservesCollectedAtClosing;
        private DirtyValue<decimal?>? _estimatedEscrow;
        private DirtyValue<decimal?>? _estValueOfRepairs;
        private DirtyValue<decimal?>? _feeRate;
        private DirtyValue<DateTime?>? _fhaInsuredDate;
        private DirtyValue<string?>? _fhaVaCaseNumber;
        private DirtyValue<bool?>? _fhlmcEnergyEfficientIndicator;
        private DirtyValue<string?>? _fhlmcPurchaseEligibility;
        private DirtyValue<string?>? _fhlmcUcdCaseFileId;
        private DirtyValue<bool?>? _fhlmcUcdSuccessFlag;
        private DirtyValue<bool?>? _finalInspectionReqIndicator;
        private DirtyValue<DateTime?>? _firstPaymentChangeDate;
        private DirtyValue<decimal?>? _firstPaymentLetterAdditionalInsuranceAmount;
        private DirtyValue<decimal?>? _firstPaymentLetterCityTaxes;
        private DirtyValue<decimal?>? _firstPaymentLetterCountyTaxes;
        private DirtyValue<decimal?>? _firstPaymentLetterFloodAmount;
        private DirtyValue<decimal?>? _firstPaymentLetterHazardAmount;
        private DirtyValue<decimal?>? _firstPaymentLetterHoaAmount;
        private DirtyValue<decimal?>? _firstPaymentLetterOtherTaxes;
        private DirtyValue<decimal?>? _firstPaymentLetterPiti;
        private DirtyValue<decimal?>? _firstPaymentLetterPmiMipAmount;
        private DirtyValue<decimal?>? _firstPaymentLetterSchoolTaxes;
        private DirtyValue<decimal?>? _firstPaymentLetterWindHailAmount;
        private DirtyValue<decimal?>? _firstPaymentPi;
        private DirtyValue<DateTime?>? _firstRateChangeDate;
        private DirtyValue<int?>? _floodCoverageTerm;
        private DirtyValue<decimal?>? _floodDeductible;
        private DirtyValue<bool?>? _floodExcludePitiPayment;
        private DirtyValue<bool?>? _floodInsuranceCoverageIndicator;
        private DirtyValue<string?>? _floodInsuranceEstimator;
        private DirtyValue<bool?>? _floodInsuranceGuaranteedReplacementCost;
        private DirtyValue<bool?>? _floodInsuranceIndicator;
        private DirtyValue<bool?>? _floodInsuranceRequired;
        private DirtyValue<string?>? _floodPaymentType;
        private DirtyValue<DateTime?>? _floodPolicyEffectiveDate;
        private DirtyValue<string?>? _floodPolicyType;
        private DirtyValue<DateTime?>? _floodPremiumDueDate;
        private DirtyValue<string?>? _fnmaUcdCaseFileId;
        private DirtyValue<DateTime?>? _fnmaUcdSubmissionDate;
        private DirtyValue<string?>? _fnmaUcdSuccessFlag;
        private DirtyValue<string?>? _fnmCondominiumProjectManagerProjectIdentifier;
        private DirtyValue<string?>? _freddieProjectClass;
        private DirtyValue<DateTime?>? _fundedDate;
        private DirtyValue<int?>? _gracePeriodDays;
        private DirtyValue<DateTime?>? _gracePeriodStartDate;
        private DirtyValue<string?>? _gracePeriodStartTrigger;
        private DirtyValue<decimal?>? _guaranteeFeeCollected;
        private DirtyValue<int?>? _hazardCoverageTerm;
        private DirtyValue<decimal?>? _hazardDeductible;
        private DirtyValue<bool?>? _hazardExcludePitiPayment;
        private DirtyValue<string?>? _hazardInsuranceEstimator;
        private DirtyValue<bool?>? _hazardInsuranceGuaranteedReplacementCost;
        private DirtyValue<bool?>? _hazardInsuranceIndicator;
        private DirtyValue<string?>? _hazardPaymentType;
        private DirtyValue<DateTime?>? _hazardPolicyEffectiveDate;
        private DirtyValue<string?>? _hazardPolicyType;
        private DirtyValue<DateTime?>? _hazardPremiumDueDate;
        private DirtyValue<bool?>? _highPricedLoanIndicator;
        private DirtyValue<string?>? _highPricedMortageLoanIndicator;
        private DirtyValue<decimal?>? _hoaBudgetedAssessmentIncome;
        private DirtyValue<decimal?>? _hoaBudgetedReplacementReserves;
        private DirtyValue<bool?>? _hoaLitigationStatus;
        private DirtyValue<bool?>? _homeOneIndicator;
        private DirtyValue<bool?>? _homePossibleAdvIndicator;
        private DirtyValue<bool?>? _homePossibleIndicator;
        private DirtyValue<bool?>? _homeReadyIndicator;
        private DirtyValue<bool?>? _homeStyleIndicator;
        private DirtyValue<decimal?>? _housingRatio;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _ieadInitialDeposit;
        private DirtyValue<bool?>? _includesWallsIn;
        private DirtyValue<bool?>? _includesWindOrHail;
        private DirtyValue<string?>? _incomeType;
        private DirtyValue<string?>? _indexType;
        private DirtyValue<decimal?>? _initialAdjustedRate;
        private DirtyValue<decimal?>? _initialAdjustedRatePoint;
        private DirtyValue<DateTime?>? _initialSuspenseDate;
        private DirtyValue<DateTime?>? _initialTilDisclosureProvidedDate;
        private DirtyValue<DateTime?>? _initialTilDisclosureReceivedDate;
        private DirtyValue<string?>? _insuranceType;
        private DirtyValue<bool?>? _interestRateExportationIndicator;
        private DirtyValue<bool?>? _isAdditionalInsurance;
        private DirtyValue<bool?>? _isFloodInsurance;
        private DirtyValue<bool?>? _isHazardIncludedMasterPolicy;
        private DirtyValue<bool?>? _isSubjectPropertyImproved;
        private DirtyValue<string?>? _isTheHighestAndTheBestUseOfSubjectPropertyAsImproved;
        private DirtyValue<bool?>? _isWindHailInsurance;
        private DirtyValue<bool?>? _jumbo;
        private DirtyValue<string?>? _lastAusResult;
        private DirtyValue<DateTime?>? _lastAusRunDate;
        private DirtyValue<string?>? _lastAusType;
        private DirtyValue<DateTime?>? _lastDisclosureDate;
        private DirtyValue<DateTime?>? _lastDisclosureReceivedDate;
        private DirtyValue<DateTime?>? _lastPublishedConditionsNotificationDateTime;
        private DirtyValue<int?>? _lateChargeDays;
        private DirtyValue<decimal?>? _lateChargePercent;
        private DirtyValue<DateTime?>? _lateDaysBegin;
        private DirtyValue<DateTime?>? _lateDaysEnd;
        private DirtyValue<string?>? _lateDaysEndTrigger;
        private DirtyValue<decimal?>? _lateFee;
        private DirtyValue<StringEnumValue<LateFeeChargeType>>? _lateFeeChargeType;
        private DirtyValue<string?>? _lateFeeFrequency;
        private DirtyValue<string?>? _lateFeeNotes;
        private DirtyValue<decimal?>? _lateFeePercentage;
        private DirtyValue<decimal?>? _lateFeeTotalPriceAdjustment;
        private DirtyValue<DateTime?>? _latestConditionsDate;
        private DirtyValue<decimal?>? _lenderPaidMiRate;
        private DirtyValue<decimal?>? _lenderPaidPremiumAmount;
        private DirtyValue<int?>? _leSectionjLenderCreditTotal;
        private DirtyValue<decimal?>? _lFSAmount;
        private DirtyValue<int?>? _lFSCalculateAs;
        private DirtyValue<int?>? _lFSDayCleared;
        private DirtyValue<string?>? _lFSDayClearedOtherDate;
        private DirtyValue<string?>? _lfsDayClearedOtherDateDescription;
        private DirtyValue<string?>? _lFSDayClearedOtherDateValue;
        private DirtyValue<int?>? _lFSFeeHandledAs;
        private DirtyValue<int?>? _lFSGracePeriodCalendar;
        private DirtyValue<int?>? _lFSGracePeriodDays;
        private DirtyValue<int?>? _lFSGracePeriodLaterOf;
        private DirtyValue<int?>? _lFSGracePeriodStarts;
        private DirtyValue<int?>? _lFSIncludeDay;
        private DirtyValue<decimal?>? _lFSLateFee;
        private DirtyValue<int?>? _lFSLateFeeBasedOn;
        private DirtyValue<int?>? _lFSMaxLateDays;
        private DirtyValue<string?>? _lFSOtherDate;
        private DirtyValue<string?>? _lFSOtherDateValue;
        private DirtyValue<int?>? _lFSStartOnWeekend;
        private DirtyValue<bool?>? _lifeOfLoan;
        private DirtyValue<decimal?>? _lifeTimeCap1;
        private DirtyValue<decimal?>? _lifeTimeCap2;
        private DirtyValue<decimal?>? _livingArea;
        private DirtyValue<decimal?>? _loanDiscountFee;
        private DirtyValue<bool?>? _loanIsCommitted;
        private DirtyValue<string?>? _loanProduct;
        private DirtyValue<string?>? _loanStatus;
        private DirtyValue<string?>? _loanStatusChangeUserName;
        private DirtyValue<DateTime?>? _loanStatusDateTimeStamp;
        private DirtyValue<DateTime?>? _loanStatusLastUpdatedDateTime;
        private DirtyValue<string?>? _loanStatusOcr;
        private DirtyValue<DateTime?>? _lomaLomr;
        private DirtyValue<string?>? _lookbackPeriod1;
        private DirtyValue<string?>? _lookbackPeriod2;
        private DirtyValue<decimal?>? _ltv;
        private DirtyValue<decimal?>? _masterCoverageAmount;
        private DirtyValue<int?>? _masterCoverageTerm;
        private DirtyValue<string?>? _masterInsuranceCompanyName;
        private DirtyValue<string?>? _masterPaymentType;
        private DirtyValue<DateTime?>? _masterPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _masterPolicyExpirationDate;
        private DirtyValue<string?>? _masterPolicyFloodCompanyName;
        private DirtyValue<decimal?>? _masterPolicyFloodCoverageAmount;
        private DirtyValue<string?>? _masterPolicyFloodPaymentType;
        private DirtyValue<DateTime?>? _masterPolicyFloodPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _masterPolicyFloodPolicyExpirationDate;
        private DirtyValue<string?>? _masterPolicyFloodPolicyNumber;
        private DirtyValue<string?>? _masterPolicyHazardCompanyName;
        private DirtyValue<decimal?>? _masterPolicyHazardCoverageAmount;
        private DirtyValue<string?>? _masterPolicyHazardPaymentType;
        private DirtyValue<DateTime?>? _masterPolicyHazardPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _masterPolicyHazardPolicyExpirationDate;
        private DirtyValue<string?>? _masterPolicyHazardPolicyNumber;
        private DirtyValue<string?>? _masterPolicyNumber;
        private DirtyValue<string?>? _masterPolicyOtherCompanyName;
        private DirtyValue<decimal?>? _masterPolicyOtherCoverageAmount;
        private DirtyValue<string?>? _masterPolicyOtherInsuranceTypeDescription;
        private DirtyValue<string?>? _masterPolicyOtherPaymentType;
        private DirtyValue<DateTime?>? _masterPolicyOtherPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _masterPolicyOtherPolicyExpirationDate;
        private DirtyValue<string?>? _masterPolicyOtherPolicyNumber;
        private DirtyValue<string?>? _masterPolicyWindOrHailCompanyName;
        private DirtyValue<decimal?>? _masterPolicyWindOrHailCoverageAmount;
        private DirtyValue<string?>? _masterPolicyWindOrHailPaymentType;
        private DirtyValue<DateTime?>? _masterPolicyWindOrHailPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _masterPolicyWindOrHailPolicyExpirationDate;
        private DirtyValue<string?>? _masterPolicyWindOrHailPolicyNumber;
        private DirtyValue<decimal?>? _maxFirstChangeRate1;
        private DirtyValue<decimal?>? _maxFirstChangeRate2;
        private DirtyValue<decimal?>? _minFirstChangeRate1;
        private DirtyValue<decimal?>? _minFirstChangeRate2;
        private DirtyValue<StringEnumValue<MiOrderedBy>>? _miOrderedBy;
        private DirtyValue<string?>? _miPremiumPaymentType;
        private DirtyValue<int?>? _miPremiumTerm;
        private DirtyValue<DateTime?>? _miTerminationDate;
        private DirtyValue<bool?>? _modification;
        private DirtyValue<DateTime?>? _modificationDate;
        private DirtyValue<bool?>? _momIndicator;
        private DirtyValue<decimal?>? _monthlyAmount;
        private DirtyValue<decimal?>? _monthlyHousingExpense;
        private DirtyValue<string?>? _monthlyPremiumAmount;
        private DirtyValue<decimal?>? _monthlyRentAmountUnit3;
        private DirtyValue<decimal?>? _monthlyRentAmountUnit4;
        private DirtyValue<int?>? _monthsOfMiPrepaid;
        private DirtyValue<decimal?>? _mortgageInsurancePremiumUpfrontFactorPercent;
        private DirtyValue<decimal?>? _negativeCashFlow;
        private DirtyValue<DateTime?>? _nfipPaneldate;
        private DirtyValue<string?>? _nfipPanelNumber;
        private DirtyValue<StringEnumValue<NfipProgramType>>? _nfipProgramType;
        private DirtyValue<decimal?>? _nonMortgagePayoffAmount;
        private DirtyValue<decimal?>? _nonShoppableServicesB;
        private DirtyValue<bool?>? _nonTraditionalCredit;
        private DirtyValue<DateTime?>? _notaryAcknowledgementDate;
        private DirtyValue<DateTime?>? _noteDate;
        private DirtyValue<decimal?>? _notePAndI2;
        private DirtyValue<decimal?>? _notePi;
        private DirtyValue<decimal?>? _novAmount;
        private DirtyValue<int?>? _numberofBedrooms;
        private DirtyValue<int?>? _numberofBedroomsUnit1;
        private DirtyValue<int?>? _numberofBedroomsUnit2;
        private DirtyValue<int?>? _numberOfBedroomUnit3;
        private DirtyValue<int?>? _numberOfBedroomUnit4;
        private DirtyValue<int?>? _numberOfBuydownPeriods;
        private DirtyValue<int?>? _numberOfUnits;
        private DirtyValue<decimal?>? _originalPrincipalBalance;
        private DirtyValue<decimal?>? _originationChargedA;
        private DirtyValue<string?>? _otherInsuranceType;
        private DirtyValue<bool?>? _otherTaxesExcludePitiPayment;
        private DirtyValue<string?>? _otherTaxesFrequency;
        private DirtyValue<decimal?>? _otherTaxesMonthlyAmount;
        private DirtyValue<DateTime?>? _otherTaxesNextPaymentDueDate;
        private DirtyValue<string?>? _panelNumber;
        private DirtyValue<decimal?>? _paymentAmount;
        private DirtyValue<decimal?>? _periodicChangePercent1;
        private DirtyValue<decimal?>? _periodicChangePercent2;
        private DirtyValue<decimal?>? _pointsInInitialAdjustedRate;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<bool?>? _powerofAttorneyIndicator;
        private DirtyValue<string?>? _premiumTerm;
        private DirtyValue<decimal?>? _prepaidFinance;
        private DirtyValue<int?>? _prepaidInterestDays;
        private DirtyValue<bool?>? _prepaymentPenalty;
        private DirtyValue<bool?>? _prepaymentPenaltyIndicator;
        private DirtyValue<bool?>? _prepaymentRiderIndicator;
        private DirtyValue<decimal?>? _principalAndInterestMonthlyPaymentAmount;
        private DirtyValue<DateTime?>? _priorApplicationDate;
        private DirtyValue<decimal?>? _priorDisclosedDailyInterest;
        private DirtyValue<DateTime?>? _priorDisclosureDate;
        private DirtyValue<StringEnumValue<ProjectType>>? _projectClass;
        private DirtyValue<string?>? _projectName;
        private DirtyValue<bool?>? _propertyAcquiredLessThanOneYearAgo;
        private DirtyValue<string?>? _propertyAppraisalType;
        private DirtyValue<string?>? _propertyAppraisalUnitNumber;
        private DirtyValue<StringEnumValue<AttachmentType>>? _propertyAttachmentType;
        private DirtyValue<bool?>? _propertyFlipIndicator;
        private DirtyValue<StringEnumValue<PropertyUsageType>>? _propertyUsageCode;
        private DirtyValue<decimal?>? _propertyValue;
        private DirtyValue<string?>? _proposedDuesAmount;
        private DirtyValue<string?>? _proposedHazardInsuranceAmount;
        private DirtyValue<string?>? _proposedMortgageInsuranceAmount;
        private DirtyValue<decimal?>? _proposedOtherAmount;
        private DirtyValue<string?>? _proposedRealEstateTaxesAmount;
        private DirtyValue<decimal?>? _purchaseContractSalesPrice;
        private DirtyValue<decimal?>? _rateAdjustmentPeriodicCap;
        private DirtyValue<decimal?>? _rateAdjustmentPeriodicCap2;
        private DirtyValue<decimal?>? _rateReductionBasisPoints;
        private DirtyValue<string?>? _ratesheet;
        private DirtyValue<DateTime?>? _receivedDate;
        private DirtyValue<int?>? _recoupmentNumberOfMonths;
        private DirtyValue<bool?>? _reducedMiIndicator;
        private DirtyValue<StringEnumValue<CorrespondentRefinanceType>>? _refinanceType;
        private DirtyValue<bool?>? _refundUnearnedMipIndicator;
        private DirtyValue<DateTime?>? _rejectedDate;
        private DirtyValue<bool?>? _renovation;
        private DirtyValue<bool?>? _renovationCompleteIndicator;
        private DirtyValue<bool?>? _renovationProgramIndicator;
        private DirtyValue<decimal?>? _rentAmountUnit1;
        private DirtyValue<decimal?>? _rentAmountUnit2;
        private DirtyList<Rider>? _riders;
        private DirtyValue<DateTime?>? _sarExpirationDate;
        private DirtyList<Scenario>? _scenarios;
        private DirtyValue<DateTime?>? _scheduledFirstPaymentDate;
        private DirtyValue<decimal?>? _schoolTaxesMonthlyAmount;
        private DirtyValue<decimal?>? _section32Apr;
        private DirtyValue<DateTime?>? _section32DisclosureDate;
        private DirtyValue<bool?>? _section32Indicator;
        private DirtyValue<decimal?>? _sellerPaidDiscountFees;
        private DirtyValue<decimal?>? _siteValue;
        private DirtyValue<string?>? _specialtyProduct;
        private DirtyValue<string?>? _standardDeviation;
        private DirtyValue<decimal?>? _statedGrossRent;
        private DirtyValue<string?>? _statedPropertyCondition;
        private DirtyValue<StringEnumValue<PropertyType>>? _statedPropertyType;
        private DirtyValue<bool?>? _stateTaxesExcludePitiPayment;
        private DirtyValue<string?>? _stateTaxesFrequency;
        private DirtyValue<DateTime?>? _stateTaxesNextPaymentDueDate;
        private DirtyValue<string?>? _subjectAddressCity;
        private DirtyValue<StringEnumValue<PropertyImprovementsType>>? _subjectPropertyImproved;
        private DirtyValue<StringEnumValue<State>>? _subjectPropertyState;
        private DirtyValue<string?>? _subjectPropertyUnitNumber;
        private DirtyValue<DateTime?>? _submittedforPurchaseDate;
        private DirtyValue<string?>? _subordinationType;
        private DirtyValue<int?>? _subsequentAdjustmentTerm;
        private DirtyValue<string?>? _supervisoryAppraiserLicenseNumber;
        private DirtyValue<bool?>? _texasA6Indicator;
        private DirtyValue<bool?>? _texasA6Indicator2;
        private DirtyValue<decimal?>? _topRatioPercent;
        private DirtyValue<decimal?>? _totalEscrowsCollectedAtClosing;
        private DirtyValue<int?>? _totalLateDays;
        private DirtyValue<decimal?>? _totalLateFee;
        private DirtyValue<decimal?>? _totalNetMonthlySalary;
        private DirtyValue<decimal?>? _totalOfPayments;
        private DirtyValue<DateTime?>? _txPrecloseCdBorrDeliveryDate;
        private DirtyValue<DateTime?>? _txPrecloseCdBorrReceiptDate;
        private DirtyValue<DateTime?>? _ucdLastSubmissionDateTime;
        private DirtyValue<DateTime?>? _ucdpAppraisalEffectiveDate;
        private DirtyValue<int?>? _ucdpAppraisedValueAmount;
        private DirtyValue<string?>? _ucdpDocFileId;
        private DirtyValue<string?>? _ucdpOverValuation;
        private DirtyValue<DateTime?>? _ucdSubmissionDate;
        private DirtyValue<string?>? _ucdSubmissionResult;
        private DirtyValue<StringEnumValue<RiskAssessmentType>>? _underwritingMethod;
        private DirtyValue<decimal?>? _undiscountedRate;
        private DirtyValue<decimal?>? _unpaidPrincipalBalance;
        private DirtyValue<decimal?>? _upfrontMipRate;
        private DirtyValue<decimal?>? _upfrontPremiumAmount;
        private DirtyValue<bool?>? _usdaOneTimeClose;
        private DirtyValue<DateTime?>? _vaCashOutNtbComparisonFormDate;
        private DirtyValue<DateTime?>? _vaInsuredDate;
        private DirtyValue<decimal?>? _vaIrrrlStatutoryPAndIAmount;
        private DirtyList<Valuation>? _valuations;
        private DirtyValue<decimal?>? _valueUsedForAdditionalInsurance;
        private DirtyValue<decimal?>? _valueUsedForFloodInsurance;
        private DirtyValue<decimal?>? _valueUsedForHazardInsurance;
        private DirtyValue<decimal?>? _valueUsedForWindHailInsurance;
        private DirtyValue<DateTime?>? _voidedDate;
        private DirtyValue<decimal?>? _windHailCoverageAmount;
        private DirtyValue<int?>? _windHailCoverageTerm;
        private DirtyValue<decimal?>? _windHailDeductible;
        private DirtyValue<bool?>? _windHailExcludePitiPayment;
        private DirtyValue<string?>? _windHailInsuranceCompanyName;
        private DirtyValue<string?>? _windHailInsuranceEstimator;
        private DirtyValue<bool?>? _windHailInsuranceGuaranteedReplacementCost;
        private DirtyValue<string?>? _windHailPaymentType;
        private DirtyValue<DateTime?>? _windHailPolicyEffectiveDate;
        private DirtyValue<DateTime?>? _windHailPolicyExpirationDate;
        private DirtyValue<string?>? _windHailPolicyNumber;
        private DirtyValue<decimal?>? _windHailPolicyPremium;
        private DirtyValue<string?>? _windHailPolicyType;
        private DirtyValue<DateTime?>? _windHailPremiumDueDate;
        private DirtyValue<DateTime?>? _withdrawalRequestedDate;
        private DirtyValue<DateTime?>? _withdrawnDate;
        private DirtyValue<string?>? _yearBuilt;
        private DirtyValue<string?>? _zoningCompliance;

        /// <summary>
        /// Correspondent ABA Number [CORRESPONDENT.X74]
        /// </summary>
        public string? AbaNumber { get => _abaNumber; set => SetField(ref _abaNumber, value); }

        /// <summary>
        /// Correspondent Account Number [CORRESPONDENT.X75]
        /// </summary>
        public string? AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }

        /// <summary>
        /// Correspondent Account Number 2 [CORRESPONDENT.X76]
        /// </summary>
        public string? AccountNumber2 { get => _accountNumber2; set => SetField(ref _accountNumber2, value); }

        /// <summary>
        /// Correspondent Activated By [CORRESPONDENT.X495]
        /// </summary>
        public string? ActivatedBy { get => _activatedBy; set => SetField(ref _activatedBy, value); }

        /// <summary>
        /// Correspondent Activated Date [CORRESPONDENT.X494]
        /// </summary>
        public DateTime? ActivatedDate { get => _activatedDate; set => SetField(ref _activatedDate, value); }

        /// <summary>
        /// Correspondent Additional Flood Coverage [CORRESPONDENT.X78]
        /// </summary>
        public decimal? AdditionalFloodCoverage { get => _additionalFloodCoverage; set => SetField(ref _additionalFloodCoverage, value); }

        /// <summary>
        /// Correspondent Additional Hazard Coverage [CORRESPONDENT.X79]
        /// </summary>
        public decimal? AdditionalHazardCoverage { get => _additionalHazardCoverage; set => SetField(ref _additionalHazardCoverage, value); }

        /// <summary>
        /// Correspondent Additional Insurance Company Name [CORRESPONDENT.X222]
        /// </summary>
        public string? AdditionalInsuranceCompanyName { get => _additionalInsuranceCompanyName; set => SetField(ref _additionalInsuranceCompanyName, value); }

        /// <summary>
        /// Correspondent Additional Insurance Additional Coverage [CORRESPONDENT.X77]
        /// </summary>
        public decimal? AdditionalInsuranceCoverage { get => _additionalInsuranceCoverage; set => SetField(ref _additionalInsuranceCoverage, value); }

        /// <summary>
        /// Correspondent Additional Insurance Coverage Amount [CORRESPONDENT.X149]
        /// </summary>
        public decimal? AdditionalInsuranceCoverageAmount { get => _additionalInsuranceCoverageAmount; set => SetField(ref _additionalInsuranceCoverageAmount, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X152]
        /// </summary>
        public int? AdditionalInsuranceCoverageTerm { get => _additionalInsuranceCoverageTerm; set => SetField(ref _additionalInsuranceCoverageTerm, value); }

        /// <summary>
        /// Correspondent Additional Insurance Deductible [CORRESPONDENT.X160]
        /// </summary>
        public decimal? AdditionalInsuranceDeductible { get => _additionalInsuranceDeductible; set => SetField(ref _additionalInsuranceDeductible, value); }

        /// <summary>
        /// Correspondent Additional Insurance Estimator [CORRESPONDENT.X225]
        /// </summary>
        public string? AdditionalInsuranceEstimator { get => _additionalInsuranceEstimator; set => SetField(ref _additionalInsuranceEstimator, value); }

        /// <summary>
        /// Correspondent Additional Insurance Exclude from PITI Payment [CORRESPONDENT.X176]
        /// </summary>
        public bool? AdditionalInsuranceExcludePitiPayment { get => _additionalInsuranceExcludePitiPayment; set => SetField(ref _additionalInsuranceExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent Additional Insurance Guaranteed Replacement Cost [CORRESPONDENT.X203]
        /// </summary>
        public bool? AdditionalInsuranceGuaranteedReplacementCost { get => _additionalInsuranceGuaranteedReplacementCost; set => SetField(ref _additionalInsuranceGuaranteedReplacementCost, value); }

        /// <summary>
        /// Correspondent Additional Insurance Monthly Amount [CORRESPONDENT.X363]
        /// </summary>
        public decimal? AdditionalInsuranceMonthlyAmount { get => _additionalInsuranceMonthlyAmount; set => SetField(ref _additionalInsuranceMonthlyAmount, value); }

        /// <summary>
        /// Correspondent Additional Insurance Payment Type [CORRESPONDENT.X461]
        /// </summary>
        public string? AdditionalInsurancePaymentType { get => _additionalInsurancePaymentType; set => SetField(ref _additionalInsurancePaymentType, value); }

        /// <summary>
        /// Correspondent Additional Insurance Policy Effective Date [CORRESPONDENT.X277]
        /// </summary>
        public DateTime? AdditionalInsurancePolicyEffectiveDate { get => _additionalInsurancePolicyEffectiveDate; set => SetField(ref _additionalInsurancePolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Additional Insurance Policy Expiration Date [CORRESPONDENT.X282]
        /// </summary>
        public DateTime? AdditionalInsurancePolicyExpirationDate { get => _additionalInsurancePolicyExpirationDate; set => SetField(ref _additionalInsurancePolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Additional Insurance Panel Number [CORRESPONDENT.X285]
        /// </summary>
        public string? AdditionalInsurancePolicyNumber { get => _additionalInsurancePolicyNumber; set => SetField(ref _additionalInsurancePolicyNumber, value); }

        /// <summary>
        /// Correspondent Additional Insurance Policy Premium [CORRESPONDENT.X288]
        /// </summary>
        public decimal? AdditionalInsurancePolicyPremium { get => _additionalInsurancePolicyPremium; set => SetField(ref _additionalInsurancePolicyPremium, value); }

        /// <summary>
        /// Correspondent Additional Insurance Policy Type [CORRESPONDENT.X290]
        /// </summary>
        public string? AdditionalInsurancePolicyType { get => _additionalInsurancePolicyType; set => SetField(ref _additionalInsurancePolicyType, value); }

        /// <summary>
        /// Correspondent Additional Insurance Premium Due Date [CORRESPONDENT.X295]
        /// </summary>
        public DateTime? AdditionalInsurancePremiumDueDate { get => _additionalInsurancePremiumDueDate; set => SetField(ref _additionalInsurancePremiumDueDate, value); }

        /// <summary>
        /// Correspondent Additional Insurance Estimator [CORRESPONDENT.X229]
        /// </summary>
        public string? AdditionalInsuranceType { get => _additionalInsuranceType; set => SetField(ref _additionalInsuranceType, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Additional Charge [3932]
        /// </summary>
        public decimal? AdditionalLateFeeCharge { get => _additionalLateFeeCharge; set => SetField(ref _additionalLateFeeCharge, value); }

        /// <summary>
        /// Correspondent Additional Wind Coverage [CORRESPONDENT.X80]
        /// </summary>
        public decimal? AdditionalWindCoverage { get => _additionalWindCoverage; set => SetField(ref _additionalWindCoverage, value); }

        /// <summary>
        /// Correspondent After-Improved LTV Value [CORRESPONDENT.X400]
        /// </summary>
        public decimal? AfterImprovedLtv { get => _afterImprovedLtv; set => SetField(ref _afterImprovedLtv, value); }

        /// <summary>
        /// Correspondent Aggregate Adjustment [CORRESPONDENT.X82]
        /// </summary>
        public decimal? AggregateAdjustment { get => _aggregateAdjustment; set => SetField(ref _aggregateAdjustment, value); }

        /// <summary>
        /// Correspondent Loan Status - Alternate Loan Number [4548]
        /// </summary>
        public string? AlternateLoanNumber { get => _alternateLoanNumber; set => SetField(ref _alternateLoanNumber, value); }

        /// <summary>
        /// Correspondent REGZ Total Amt Financed [CORRESPONDENT.X25]
        /// </summary>
        public decimal? AmountFinanced { get => _amountFinanced; set => SetField(ref _amountFinanced, value); }

        /// <summary>
        /// Correspondent Annual Mip Rate [CORRESPONDENT.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? AnnualMipRate { get => _annualMipRate; set => SetField(ref _annualMipRate, value); }

        /// <summary>
        /// Correspondent Appraisal Address County [CORRESPONDENT.X86]
        /// </summary>
        public string? AppraisalAddressCounty { get => _appraisalAddressCounty; set => SetField(ref _appraisalAddressCounty, value); }

        /// <summary>
        /// Correspondent Appraisal Appt Date [CORRESPONDENT.X87]
        /// </summary>
        public DateTime? AppraisalApptDate { get => _appraisalApptDate; set => SetField(ref _appraisalApptDate, value); }

        /// <summary>
        /// Correspondent Appraisal Checkbox [CORRESPONDENT.X438]
        /// </summary>
        public bool? AppraisalCheckbox { get => _appraisalCheckbox; set => SetField(ref _appraisalCheckbox, value); }

        /// <summary>
        /// Correspondent Appraisal County Name [CORRESPONDENT.X88]
        /// </summary>
        public string? AppraisalCountyName { get => _appraisalCountyName; set => SetField(ref _appraisalCountyName, value); }

        /// <summary>
        /// Correspondent Appraisal Fee [CORRESPONDENT.X89]
        /// </summary>
        public decimal? AppraisalFee { get => _appraisalFee; set => SetField(ref _appraisalFee, value); }

        /// <summary>
        /// Correspondent Appraisal Final Inspection Date [CORRESPONDENT.X90]
        /// </summary>
        public DateTime? AppraisalFinalInspectionDate { get => _appraisalFinalInspectionDate; set => SetField(ref _appraisalFinalInspectionDate, value); }

        /// <summary>
        /// Correspondent Appraisal Final Inspection Flag [CORRESPONDENT.X91]
        /// </summary>
        public bool? AppraisalFinalInspectionFlag { get => _appraisalFinalInspectionFlag; set => SetField(ref _appraisalFinalInspectionFlag, value); }

        /// <summary>
        /// Correspondent Flood Zone [CORRESPONDENT.X92]
        /// </summary>
        public StringEnumValue<FloodZone> AppraisalFloodZone { get => _appraisalFloodZone; set => SetField(ref _appraisalFloodZone, value); }

        /// <summary>
        /// Correspondent Appraisal Legal Description 1 [CORRESPONDENT.X234]
        /// </summary>
        public string? AppraisalLegalDescription1 { get => _appraisalLegalDescription1; set => SetField(ref _appraisalLegalDescription1, value); }

        /// <summary>
        /// Correspondent Appraisal Legal Description 2 [CORRESPONDENT.X235]
        /// </summary>
        public string? AppraisalLegalDescription2 { get => _appraisalLegalDescription2; set => SetField(ref _appraisalLegalDescription2, value); }

        /// <summary>
        /// Correspondent Property Appraisal Type [CORRESPONDENT.X93]
        /// </summary>
        public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => _appraisalPropertyType; set => SetField(ref _appraisalPropertyType, value); }

        /// <summary>
        /// Correspondent Property Appraisal Usage [CORRESPONDENT.X351]
        /// </summary>
        public string? AppraisalUsage { get => _appraisalUsage; set => SetField(ref _appraisalUsage, value); }

        /// <summary>
        /// Correspondent Appraisal Waiver [CORRESPONDENT.X94]
        /// </summary>
        public bool? AppraisalWaiver { get => _appraisalWaiver; set => SetField(ref _appraisalWaiver, value); }

        /// <summary>
        /// Correspondent Appraised Condition [CORRESPONDENT.X95]
        /// </summary>
        public string? AppraisedCondition { get => _appraisedCondition; set => SetField(ref _appraisedCondition, value); }

        /// <summary>
        /// Correspondent Appraised Value [CORRESPONDENT.X96]
        /// </summary>
        public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

        /// <summary>
        /// Correspondent Appraiser Name [CORRESPONDENT.X97]
        /// </summary>
        public string? AppraiserName { get => _appraiserName; set => SetField(ref _appraiserName, value); }

        /// <summary>
        /// Correspondent Appraisers License Number [CORRESPONDENT.X99]
        /// </summary>
        public string? AppraisersLicenseNumber { get => _appraisersLicenseNumber; set => SetField(ref _appraisersLicenseNumber, value); }

        /// <summary>
        /// Correspondent Appraisers Property Address 1 [CORRESPONDENT.X101]
        /// </summary>
        public string? AppraisersPropertyAddress1 { get => _appraisersPropertyAddress1; set => SetField(ref _appraisersPropertyAddress1, value); }

        /// <summary>
        /// Correspondent Appraisers Property Address 2 [CORRESPONDENT.X102]
        /// </summary>
        public string? AppraisersPropertyAddress2 { get => _appraisersPropertyAddress2; set => SetField(ref _appraisersPropertyAddress2, value); }

        /// <summary>
        /// Correspondent Appraisers State License Number [CORRESPONDENT.X100]
        /// </summary>
        public string? AppraisersStateLicenseNumber { get => _appraisersStateLicenseNumber; set => SetField(ref _appraisersStateLicenseNumber, value); }

        /// <summary>
        /// Correspondent Appraiser Supervisors Name [CORRESPONDENT.X98]
        /// </summary>
        public string? AppraiserSupervisorsName { get => _appraiserSupervisorsName; set => SetField(ref _appraiserSupervisorsName, value); }

        /// <summary>
        /// Correspondent Loan Status - Cleared for Purchase Date [3921]
        /// </summary>
        public DateTime? ApprovedToFundDate { get => _approvedToFundDate; set => SetField(ref _approvedToFundDate, value); }

        /// <summary>
        /// Correspondent APR Percent [CORRESPONDENT.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AprPercent { get => _aprPercent; set => SetField(ref _aprPercent, value); }

        /// <summary>
        /// Correspondent ARM Index [CORRESPONDENT.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ArmIndex { get => _armIndex; set => SetField(ref _armIndex, value); }

        /// <summary>
        /// Correspondent ARM Indicator [CORRESPONDENT.X449]
        /// </summary>
        public bool? ArmIndicator { get => _armIndicator; set => SetField(ref _armIndicator, value); }

        /// <summary>
        /// Correspondent ARM Margin [CORRESPONDENT.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ArmMargin { get => _armMargin; set => SetField(ref _armMargin, value); }

        /// <summary>
        /// Correspondent ARM Margin 2 [CORRESPONDENT.X106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ArmMargin2 { get => _armMargin2; set => SetField(ref _armMargin2, value); }

        /// <summary>
        /// Correspondent ARM Floor Rate [CORRESPONDENT.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ArmRateFloor { get => _armRateFloor; set => SetField(ref _armRateFloor, value); }

        /// <summary>
        /// Correspondent ARM Floor Rate 2 [CORRESPONDENT.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ArmRateFloor2 { get => _armRateFloor2; set => SetField(ref _armRateFloor2, value); }

        /// <summary>
        /// Correspondent - Assignment Type [CORRESPONDENT.X476]
        /// </summary>
        public StringEnumValue<AssignmentType> AssignmentType { get => _assignmentType; set => SetField(ref _assignmentType, value); }

        /// <summary>
        /// Correspondent AUS Appraised Value [CORRESPONDENT.X109]
        /// </summary>
        public int? AusAppraisedValue { get => _ausAppraisedValue; set => SetField(ref _ausAppraisedValue, value); }

        /// <summary>
        /// Correspondent AUS Assets To Be Verified [CORRESPONDENT.X110]
        /// </summary>
        public decimal? AusAssetsToBeVerified { get => _ausAssetsToBeVerified; set => SetField(ref _ausAssetsToBeVerified, value); }

        /// <summary>
        /// Correspondent - AUS Results from Lender for CLTV [CORRESPONDENT.X469]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AusCltv { get => _ausCltv; set => SetField(ref _ausCltv, value); }

        /// <summary>
        /// Correspondent AUS Credit Report Cert Number [CORRESPONDENT.X111]
        /// </summary>
        public string? AusCreditReportCertNumber { get => _ausCreditReportCertNumber; set => SetField(ref _ausCreditReportCertNumber, value); }

        /// <summary>
        /// Correspondent AUS Credit Report Date  [CORRESPONDENT.X112]
        /// </summary>
        public DateTime? AusCreditReportDate { get => _ausCreditReportDate; set => SetField(ref _ausCreditReportDate, value); }

        /// <summary>
        /// Correspondent Aus Free Form Comments  [CORRESPONDENT.X114]
        /// </summary>
        public string? AusFreeFormComments { get => _ausFreeFormComments; set => SetField(ref _ausFreeFormComments, value); }

        /// <summary>
        /// Correspondent - AUS Results from Lender for HCLTV [CORRESPONDENT.X470]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AusHcltv { get => _ausHcltv; set => SetField(ref _ausHcltv, value); }

        /// <summary>
        /// Correspondent AUS Interest Rate [CORRESPONDENT.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AusInterestRate { get => _ausInterestRate; set => SetField(ref _ausInterestRate, value); }

        /// <summary>
        /// Correspondent AUS Total Loan Amount [CORRESPONDENT.X116]
        /// </summary>
        public decimal? AusLoanAmount { get => _ausLoanAmount; set => SetField(ref _ausLoanAmount, value); }

        /// <summary>
        /// Correspondent - AUS Results from Lender for Loan Number [CORRESPONDENT.X471]
        /// </summary>
        public string? AusLoanNumber { get => _ausLoanNumber; set => SetField(ref _ausLoanNumber, value); }

        /// <summary>
        /// Correspondent - AUS Results from Lender for LTV [CORRESPONDENT.X468]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AusLtv { get => _ausLtv; set => SetField(ref _ausLtv, value); }

        /// <summary>
        /// Correspondent AUS Tracking - Housing Expense Ratio [CORRESPONDENT.X117]
        /// </summary>
        public decimal? AusPrimaryHousingExpense { get => _ausPrimaryHousingExpense; set => SetField(ref _ausPrimaryHousingExpense, value); }

        /// <summary>
        /// Correspondent AUS Tracking Property Address 1 [CORRESPONDENT.X118]
        /// </summary>
        public string? AusPropertyAddress1 { get => _ausPropertyAddress1; set => SetField(ref _ausPropertyAddress1, value); }

        /// <summary>
        /// Correspondent AUS Tracking Property Address 2 [CORRESPONDENT.X119]
        /// </summary>
        public string? AusPropertyAddress2 { get => _ausPropertyAddress2; set => SetField(ref _ausPropertyAddress2, value); }

        /// <summary>
        /// Correspondent AUS Tracking Property City [CORRESPONDENT.X120]
        /// </summary>
        public string? AusPropertyCity { get => _ausPropertyCity; set => SetField(ref _ausPropertyCity, value); }

        /// <summary>
        /// Correspondent AUS Tracking Property State [CORRESPONDENT.X121]
        /// </summary>
        public StringEnumValue<State> AusPropertyState { get => _ausPropertyState; set => SetField(ref _ausPropertyState, value); }

        /// <summary>
        /// Correspondent AUS Tracking Property Zipcode [CORRESPONDENT.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? AusPropertyZip { get => _ausPropertyZip; set => SetField(ref _ausPropertyZip, value); }

        /// <summary>
        /// Correspondent AUS Purchase Price [CORRESPONDENT.X123]
        /// </summary>
        public decimal? AusPurchasePrice { get => _ausPurchasePrice; set => SetField(ref _ausPurchasePrice, value); }

        /// <summary>
        /// Correspondent AUS Reference Number [CORRESPONDENT.X124]
        /// </summary>
        public string? AusReferenceNumber { get => _ausReferenceNumber; set => SetField(ref _ausReferenceNumber, value); }

        /// <summary>
        /// Correspondent - AUS Results from Lender for Submission Number [CORRESPONDENT.X467]
        /// </summary>
        public string? AusSubmissionNumber { get => _ausSubmissionNumber; set => SetField(ref _ausSubmissionNumber, value); }

        /// <summary>
        /// Correspondent AUS Total Assets [CORRESPONDENT.X125]
        /// </summary>
        public decimal? AusTotalAvailableAssets { get => _ausTotalAvailableAssets; set => SetField(ref _ausTotalAvailableAssets, value); }

        /// <summary>
        /// AUS Total DTI [CORRESPONDENT.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AusTotalDti { get => _ausTotalDti; set => SetField(ref _ausTotalDti, value); }

        /// <summary>
        /// Correspondent AUS Total Monthly Debt [CORRESPONDENT.X127]
        /// </summary>
        public decimal? AusTotalMonthlyDebt { get => _ausTotalMonthlyDebt; set => SetField(ref _ausTotalMonthlyDebt, value); }

        /// <summary>
        /// Correspondent AUS Total Monthly Income [CORRESPONDENT.X128]
        /// </summary>
        public decimal? AusTotalMonthlyIncome { get => _ausTotalMonthlyIncome; set => SetField(ref _ausTotalMonthlyIncome, value); }

        /// <summary>
        /// Correspondent Auto Publish Conditions [CORRESPONDENT.X55]
        /// </summary>
        public bool? AutoPublishConditions { get => _autoPublishConditions; set => SetField(ref _autoPublishConditions, value); }

        /// <summary>
        /// Correspondent Average Prime Offer Rate [CORRESPONDENT.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AveragePrimeOfferRate { get => _averagePrimeOfferRate; set => SetField(ref _averagePrimeOfferRate, value); }

        /// <summary>
        /// Correspondent AVM Appraised Value [CORRESPONDENT.X129]
        /// </summary>
        public decimal? AvmAppraisedValue { get => _avmAppraisedValue; set => SetField(ref _avmAppraisedValue, value); }

        /// <summary>
        /// Correspondent AVM Checkbox [CORRESPONDENT.X437]
        /// </summary>
        public bool? AvmCheckbox { get => _avmCheckbox; set => SetField(ref _avmCheckbox, value); }

        /// <summary>
        /// Correspondent AVM Confidence Score [CORRESPONDENT.X130]
        /// </summary>
        public string? AvmConfidenceScore { get => _avmConfidenceScore; set => SetField(ref _avmConfidenceScore, value); }

        /// <summary>
        /// Correspondent AVM Order Date [CORRESPONDENT.X132]
        /// </summary>
        public DateTime? AvmOrderDate { get => _avmOrderDate; set => SetField(ref _avmOrderDate, value); }

        /// <summary>
        /// Correspondent AVM Order Number [CORRESPONDENT.X131]
        /// </summary>
        public string? AvmOrderNumber { get => _avmOrderNumber; set => SetField(ref _avmOrderNumber, value); }

        /// <summary>
        /// Correspondent AVM Type [CORRESPONDENT.X133]
        /// </summary>
        public string? AvmType { get => _avmType; set => SetField(ref _avmType, value); }

        /// <summary>
        /// Correspondent Bank Address [CORRESPONDENT.X134]
        /// </summary>
        public string? BankAddress { get => _bankAddress; set => SetField(ref _bankAddress, value); }

        /// <summary>
        /// Correspondent Address 2 [CORRESPONDENT.X135]
        /// </summary>
        public string? BankAddress2 { get => _bankAddress2; set => SetField(ref _bankAddress2, value); }

        /// <summary>
        /// Correspondent Bank AddressCity [CORRESPONDENT.X136]
        /// </summary>
        public string? BankAddressCity { get => _bankAddressCity; set => SetField(ref _bankAddressCity, value); }

        /// <summary>
        /// Correspondent Bank Address State [CORRESPONDENT.X137]
        /// </summary>
        public StringEnumValue<State> BankAddressState { get => _bankAddressState; set => SetField(ref _bankAddressState, value); }

        /// <summary>
        /// Correspondent Bank Name  [CORRESPONDENT.X139]
        /// </summary>
        public string? BankName { get => _bankName; set => SetField(ref _bankName, value); }

        /// <summary>
        /// Correspondent Bank  Zip Code [CORRESPONDENT.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? BankZip { get => _bankZip; set => SetField(ref _bankZip, value); }

        /// <summary>
        /// Correspondent Total Loan Amt (w/ MIP/FF) [CORRESPONDENT.X2]
        /// </summary>
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }

        /// <summary>
        /// Correspondent Loan Status - Base Price [3924]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// Correspondent Borrower Paid Discount Points [CORRESPONDENT.X447]
        /// </summary>
        public decimal? BorPaidDiscountPoints { get => _borPaidDiscountPoints; set => SetField(ref _borPaidDiscountPoints, value); }

        /// <summary>
        /// Correspondent Loan Amount [CORRESPONDENT.X1]
        /// </summary>
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => SetField(ref _borrowerRequestedLoanAmount, value); }

        /// <summary>
        /// Correspondent Borrower Signed Indicator [CORRESPONDENT.X166]
        /// </summary>
        public bool? BorrowerSignedIndicator { get => _borrowerSignedIndicator; set => SetField(ref _borrowerSignedIndicator, value); }

        /// <summary>
        /// Correspondent Trans Details Qual Ratio Bottom [CORRESPONDENT.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => SetField(ref _bottomRatioPercent, value); }

        /// <summary>
        /// Subject Property Building Status [CORRESPONDENT.X140]
        /// </summary>
        public StringEnumValue<BuildingStatusType> BuildingStatus { get => _buildingStatus; set => SetField(ref _buildingStatus, value); }

        /// <summary>
        /// Correspondent Loan Status - Cancelled Date [4207]
        /// </summary>
        public DateTime? CancelledDate { get => _cancelledDate; set => SetField(ref _cancelledDate, value); }

        /// <summary>
        /// Correspondent Cash Out NTB Comparison Form Indicator [CORRESPONDENT.X431]
        /// </summary>
        public bool? CashOutNtbComparisonFormIndicator { get => _cashOutNtbComparisonFormIndicator; set => SetField(ref _cashOutNtbComparisonFormIndicator, value); }

        /// <summary>
        /// Correspondent - Cash to/from Borrower Amount [CORRESPONDENT.X477]
        /// </summary>
        public decimal? CashToOrFromBorrowerAmount { get => _cashToOrFromBorrowerAmount; set => SetField(ref _cashToOrFromBorrowerAmount, value); }

        /// <summary>
        /// Correspondent - Cash to/from Borrower Indicator [CORRESPONDENT.X482]
        /// </summary>
        public bool? CashToOrFromBorrowerIndicator { get => _cashToOrFromBorrowerIndicator; set => SetField(ref _cashToOrFromBorrowerIndicator, value); }

        /// <summary>
        /// Correspondent Compliance Review - CD Section J Lender Credit Total [CORRESPONDENT.X60]
        /// </summary>
        public decimal? CdSectionjLenderCreditTotal { get => _cdSectionjLenderCreditTotal; set => SetField(ref _cdSectionjLenderCreditTotal, value); }

        /// <summary>
        /// Correspondent CD Seller Credit Amount [CORRESPONDENT.X321]
        /// </summary>
        public decimal? CdSellerCreditAmount { get => _cdSellerCreditAmount; set => SetField(ref _cdSellerCreditAmount, value); }

        /// <summary>
        /// Correspondent CD Shoppable Services [CORRESPONDENT.X322]
        /// </summary>
        public decimal? CdShoppableServices { get => _cdShoppableServices; set => SetField(ref _cdShoppableServices, value); }

        /// <summary>
        /// Correspondent CD Taxes And Govt Fees E [CORRESPONDENT.X336]
        /// </summary>
        public decimal? CdTaxesAndGovtFeesE { get => _cdTaxesAndGovtFeesE; set => SetField(ref _cdTaxesAndGovtFeesE, value); }

        /// <summary>
        /// Correspondent CD Total Borrower Closing Costs [CORRESPONDENT.X339]
        /// </summary>
        public decimal? CdTotalBorrowerClosingCosts { get => _cdTotalBorrowerClosingCosts; set => SetField(ref _cdTotalBorrowerClosingCosts, value); }

        /// <summary>
        /// Correspondent CEMA Indicator [CORRESPONDENT.X141]
        /// </summary>
        public bool? CemaIndicator { get => _cemaIndicator; set => SetField(ref _cemaIndicator, value); }

        /// <summary>
        /// Correspondent Census Tract [CORRESPONDENT.X142]
        /// </summary>
        public string? CensusTrack { get => _censusTrack; set => SetField(ref _censusTrack, value); }

        /// <summary>
        /// Correspondent Certificate Of Eligibility Provided [CORRESPONDENT.X143]
        /// </summary>
        public bool? CertOfEligibilityProvided { get => _certOfEligibilityProvided; set => SetField(ref _certOfEligibilityProvided, value); }

        /// <summary>
        /// Correspondent City Taxes Exclude PITI Payment [CORRESPONDENT.X177]
        /// </summary>
        public bool? CityTaxesExcludePitiPayment { get => _cityTaxesExcludePitiPayment; set => SetField(ref _cityTaxesExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent City Taxes Frequency [CORRESPONDENT.X199]
        /// </summary>
        public string? CityTaxesFrequency { get => _cityTaxesFrequency; set => SetField(ref _cityTaxesFrequency, value); }

        /// <summary>
        /// Correspondent City Taxes Next Payment Due Date [CORRESPONDENT.X258]
        /// </summary>
        public DateTime? CityTaxesNextPaymentDueDate { get => _cityTaxesNextPaymentDueDate; set => SetField(ref _cityTaxesNextPaymentDueDate, value); }

        /// <summary>
        /// Correspondent Closing Borrower Adjustments [CORRESPONDENT.X81]
        /// </summary>
        public decimal? ClosingBorrowerAdjustments { get => _closingBorrowerAdjustments; set => SetField(ref _closingBorrowerAdjustments, value); }

        /// <summary>
        /// Correspondent Closing Costs [CORRESPONDENT.X144]
        /// </summary>
        public decimal? ClosingCostsAmount { get => _closingCostsAmount; set => SetField(ref _closingCostsAmount, value); }

        /// <summary>
        /// Correspondent Closing Disclosure Lender Credit Amount [CORRESPONDENT.X236]
        /// </summary>
        public decimal? ClosingDisclosureLenderCreditAmount { get => _closingDisclosureLenderCreditAmount; set => SetField(ref _closingDisclosureLenderCreditAmount, value); }

        /// <summary>
        /// Correspondent Closing Disclosure Lender POC Amount [CORRESPONDENT.X237]
        /// </summary>
        public decimal? ClosingDisclosureLenderPocAmount { get => _closingDisclosureLenderPocAmount; set => SetField(ref _closingDisclosureLenderPocAmount, value); }

        /// <summary>
        /// Correspondent Loan Status - Collateral Tracking Number [4547]
        /// </summary>
        public string? CollateralTrackingNumber { get => _collateralTrackingNumber; set => SetField(ref _collateralTrackingNumber, value); }

        /// <summary>
        /// Correspondent Collateral Underwriter Score [CORRESPONDENT.X113]
        /// </summary>
        public string? CollateralUnderwriterScore { get => _collateralUnderwriterScore; set => SetField(ref _collateralUnderwriterScore, value); }

        /// <summary>
        /// Correspondent Trans Details Comb Loan to Value (CLTV) [CORRESPONDENT.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CombinedLtv { get => _combinedLtv; set => SetField(ref _combinedLtv, value); }

        /// <summary>
        /// Correspondent Commitment Amount [CORRESPONDENT.X38]
        /// </summary>
        public decimal? CommitmentAmount { get => _commitmentAmount; set => SetField(ref _commitmentAmount, value); }

        /// <summary>
        /// Correspondent Loan Status - Commitment Type [4105]
        /// </summary>
        public StringEnumValue<CommitmentType> CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Approval Date [3920]
        /// </summary>
        public DateTime? ConditionsReceivedDate { get => _conditionsReceivedDate; set => SetField(ref _conditionsReceivedDate, value); }

        /// <summary>
        /// Correspondent Condo Project Class [CORRESPONDENT.X147]
        /// </summary>
        public string? CondoProjectClass { get => _condoProjectClass; set => SetField(ref _condoProjectClass, value); }

        /// <summary>
        /// Correspondent Condo Project Status Type [CORRESPONDENT.X148]
        /// </summary>
        public string? CondoProjectStatusType { get => _condoProjectStatusType; set => SetField(ref _condoProjectStatusType, value); }

        /// <summary>
        /// Correspondent Conversion/Modification Date [CORRESPONDENT.X436]
        /// </summary>
        public DateTime? ConversionModificationDate { get => _conversionModificationDate; set => SetField(ref _conversionModificationDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Commitment Date [4527]
        /// </summary>
        public DateTime? CorrespondentCommitmentDate { get => _correspondentCommitmentDate; set => SetField(ref _correspondentCommitmentDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Commitment Expiration Date [4529]
        /// </summary>
        public DateTime? CorrespondentCommitmentExpirationDate { get => _correspondentCommitmentExpirationDate; set => SetField(ref _correspondentCommitmentExpirationDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Commitment Period [4528]
        /// </summary>
        public int? CorrespondentCommitmentPeriod { get => _correspondentCommitmentPeriod; set => SetField(ref _correspondentCommitmentPeriod, value); }

        /// <summary>
        /// Correspondent Correspondent Loan Has MI  [CORRESPONDENT.X489]
        /// </summary>
        public bool? CorrespondentLoanMiIndicator { get => _correspondentLoanMiIndicator; set => SetField(ref _correspondentLoanMiIndicator, value); }

        /// <summary>
        /// Correspondent Loan Status - Correspondent Status [3916]
        /// </summary>
        public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => _correspondentStatus; set => SetField(ref _correspondentStatus, value); }

        /// <summary>
        /// Correspondent CorrOtherInsurances
        /// </summary>
        [AllowNull]
        public IList<CorrOtherInsurance> CorrOtherInsurances { get => GetField(ref _corrOtherInsurances); set => SetField(ref _corrOtherInsurances, value); }

        /// <summary>
        /// Correspondent County Taxes Exclude PITI Payment [CORRESPONDENT.X178]
        /// </summary>
        public bool? CountyTaxesExcludePitiPayment { get => _countyTaxesExcludePitiPayment; set => SetField(ref _countyTaxesExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent County Taxes Frequency [CORRESPONDENT.X200]
        /// </summary>
        public string? CountyTaxesFrequency { get => _countyTaxesFrequency; set => SetField(ref _countyTaxesFrequency, value); }

        /// <summary>
        /// Correspondent County Taxes Monthly Amount [CORRESPONDENT.X383]
        /// </summary>
        public decimal? CountyTaxesMonthlyAmount { get => _countyTaxesMonthlyAmount; set => SetField(ref _countyTaxesMonthlyAmount, value); }

        /// <summary>
        /// Correspondent County Taxes Next Payment Due Date [CORRESPONDENT.X259]
        /// </summary>
        public DateTime? CountyTaxesNextPaymentDueDate { get => _countyTaxesNextPaymentDueDate; set => SetField(ref _countyTaxesNextPaymentDueDate, value); }

        /// <summary>
        /// Correspondent Credit Report  [CORRESPONDENT.X157]
        /// </summary>
        public decimal? CreditReport { get => _creditReport; set => SetField(ref _creditReport, value); }

        /// <summary>
        /// Correspondent Current Finance Charge [CORRESPONDENT.X404]
        /// </summary>
        public decimal? CurrentFinanceCharge { get => _currentFinanceCharge; set => SetField(ref _currentFinanceCharge, value); }

        /// <summary>
        /// Correspondent Custom Minimum Mi [CORRESPONDENT.X158]
        /// </summary>
        public string? CustomMinimumMi { get => _customMinimumMi; set => SetField(ref _customMinimumMi, value); }

        /// <summary>
        /// Correspondent Date Of Sale [CORRESPONDENT.X159]
        /// </summary>
        public DateTime? DateOfSale { get => _dateOfSale; set => SetField(ref _dateOfSale, value); }

        /// <summary>
        /// Correspondent Loan Status - Delivery Expiration Date [3926]
        /// </summary>
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => SetField(ref _deliveryExpirationDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Delivery Type [3967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }

        /// <summary>
        /// Correspondent Trans Details Disclosed APR [CORRESPONDENT.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DisclosedAprPercent { get => _disclosedAprPercent; set => SetField(ref _disclosedAprPercent, value); }

        /// <summary>
        /// Correspondent Disclosed Daily Interest Charges [CORRESPONDENT.X26]
        /// </summary>
        public decimal? DisclosedDailyInterestCharge { get => _disclosedDailyInterestCharge; set => SetField(ref _disclosedDailyInterestCharge, value); }

        /// <summary>
        /// Correspondent Disclosed Fees Total Finance Charges [CORRESPONDENT.X24]
        /// </summary>
        public decimal? DisclosedFinanceCharge { get => _disclosedFinanceCharge; set => SetField(ref _disclosedFinanceCharge, value); }

        /// <summary>
        /// Correspondent - Disclosed Temporary Buydown Fund [CORRESPONDENT.X472]
        /// </summary>
        public decimal? DisclosedTemporaryBuydownFund { get => _disclosedTemporaryBuydownFund; set => SetField(ref _disclosedTemporaryBuydownFund, value); }

        /// <summary>
        /// Correspondent Closing disclosure Total Payments [CORRESPONDENT.X164]
        /// </summary>
        public decimal? DisclosedTotalPayments { get => _disclosedTotalPayments; set => SetField(ref _disclosedTotalPayments, value); }

        /// <summary>
        /// Correspondent - Disclosed Upfront MIP Financed [CORRESPONDENT.X473]
        /// </summary>
        public decimal? DisclosedUpfrontMipFinanced { get => _disclosedUpfrontMipFinanced; set => SetField(ref _disclosedUpfrontMipFinanced, value); }

        /// <summary>
        /// Correspondent Loan Estimate - Disclosure Last Sent Date [CORRESPONDENT.X19]
        /// </summary>
        public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => SetField(ref _disclosureLastSentDate, value); }

        /// <summary>
        /// Correspondent Loan Estimate - Disclosure Received Date [CORRESPONDENT.X20]
        /// </summary>
        public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => SetField(ref _disclosureReceivedDate, value); }

        /// <summary>
        /// Correspondent Disclosures
        /// </summary>
        [AllowNull]
        public IList<Disclosure> Disclosures { get => GetField(ref _disclosures); set => SetField(ref _disclosures, value); }

        /// <summary>
        /// Correspondent Discount Points Applied [CORRESPONDENT.X39]
        /// </summary>
        public decimal? DiscountPointsApplied { get => _discountPointsApplied; set => SetField(ref _discountPointsApplied, value); }

        /// <summary>
        /// Correspondent - Discount Points Paid by Other [CORRESPONDENT.X485]
        /// </summary>
        public decimal? DiscountPointsPaidbyOther { get => _discountPointsPaidbyOther; set => SetField(ref _discountPointsPaidbyOther, value); }

        /// <summary>
        /// Correspondent - Document Receipt Date [CORRESPONDENT.X483]
        /// </summary>
        public DateTime? DocumentReceiptDate { get => _documentReceiptDate; set => SetField(ref _documentReceiptDate, value); }

        /// <summary>
        /// Correspondent EarlyChecks
        /// </summary>
        [AllowNull]
        public IList<EarlyCheck> EarlyChecks { get => GetField(ref _earlyChecks); set => SetField(ref _earlyChecks, value); }

        /// <summary>
        /// Correspondent EcAppraisalValue
        /// </summary>
        public decimal? EcAppraisalValue { get => _ecAppraisalValue; set => SetField(ref _ecAppraisalValue, value); }

        /// <summary>
        /// Correspondent EcDoumentFileId
        /// </summary>
        public string? EcDoumentFileId { get => _ecDoumentFileId; set => SetField(ref _ecDoumentFileId, value); }

        /// <summary>
        /// Correspondent Effective Property Value [CORRESPONDENT.X172]
        /// </summary>
        public decimal? EffectivePropertyValue { get => _effectivePropertyValue; set => SetField(ref _effectivePropertyValue, value); }

        /// <summary>
        /// Correspondent Energy Efficient Indicator [CORRESPONDENT.X173]
        /// </summary>
        public bool? EnergyEfficientIndicator { get => _energyEfficientIndicator; set => SetField(ref _energyEfficientIndicator, value); }

        /// <summary>
        /// Correspondent eNote Indicator [CORRESPONDENT.X171]
        /// </summary>
        public bool? ENoteIndicator { get => _eNoteIndicator; set => SetField(ref _eNoteIndicator, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X174]
        /// </summary>
        public decimal? EscrowHoldback { get => _escrowHoldback; set => SetField(ref _escrowHoldback, value); }

        /// <summary>
        /// Correspondent Escrow Reserves Collected at Closing [CORRESPONDENT.X466]
        /// </summary>
        public decimal? EscrowReservesCollectedAtClosing { get => _escrowReservesCollectedAtClosing; set => SetField(ref _escrowReservesCollectedAtClosing, value); }

        /// <summary>
        /// Correspondent Estimated Escrow [CORRESPONDENT.X403]
        /// </summary>
        public decimal? EstimatedEscrow { get => _estimatedEscrow; set => SetField(ref _estimatedEscrow, value); }

        /// <summary>
        /// Correspondent Estimated Value Of Repairs [CORRESPONDENT.X175]
        /// </summary>
        public decimal? EstValueOfRepairs { get => _estValueOfRepairs; set => SetField(ref _estValueOfRepairs, value); }

        /// <summary>
        /// Correspondent USDA - Loan Closing - Fee Rate [CORRESPONDENT.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FeeRate { get => _feeRate; set => SetField(ref _feeRate, value); }

        /// <summary>
        /// Correspondent FHA Insured Date [CORRESPONDENT.X486]
        /// </summary>
        public DateTime? FhaInsuredDate { get => _fhaInsuredDate; set => SetField(ref _fhaInsuredDate, value); }

        /// <summary>
        /// Correspondent FHA VA Case Number [CORRESPONDENT.X433]
        /// </summary>
        public string? FhaVaCaseNumber { get => _fhaVaCaseNumber; set => SetField(ref _fhaVaCaseNumber, value); }

        /// <summary>
        /// Correspondent FHLMC Energy Efficient Indicator [CORRESPONDENT.X184]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Energy Efficient Mortgage\"}")]
        public bool? FhlmcEnergyEfficientIndicator { get => _fhlmcEnergyEfficientIndicator; set => SetField(ref _fhlmcEnergyEfficientIndicator, value); }

        /// <summary>
        /// Correspondent Freddie Mac - Purchase Eligibility [CORRESPONDENT.X185]
        /// </summary>
        public string? FhlmcPurchaseEligibility { get => _fhlmcPurchaseEligibility; set => SetField(ref _fhlmcPurchaseEligibility, value); }

        /// <summary>
        /// Correspondent FHLMC UCD  Case File ID # [CORRESPONDENT.X186]
        /// </summary>
        public string? FhlmcUcdCaseFileId { get => _fhlmcUcdCaseFileId; set => SetField(ref _fhlmcUcdCaseFileId, value); }

        /// <summary>
        /// Correspondent FHLMC UCD Success Flag [CORRESPONDENT.X188]
        /// </summary>
        public bool? FhlmcUcdSuccessFlag { get => _fhlmcUcdSuccessFlag; set => SetField(ref _fhlmcUcdSuccessFlag, value); }

        /// <summary>
        /// Correspondent Final Inspection Req Indicator [CORRESPONDENT.X189]
        /// </summary>
        public bool? FinalInspectionReqIndicator { get => _finalInspectionReqIndicator; set => SetField(ref _finalInspectionReqIndicator, value); }

        /// <summary>
        /// Correspondent First Rate Change Payment Effective Date [CORRESPONDENT.X190]
        /// </summary>
        public DateTime? FirstPaymentChangeDate { get => _firstPaymentChangeDate; set => SetField(ref _firstPaymentChangeDate, value); }

        /// <summary>
        /// Correspondent First Payment Letter Additional Insurance Amount [CORRESPONDENT.X393]
        /// </summary>
        public decimal? FirstPaymentLetterAdditionalInsuranceAmount { get => _firstPaymentLetterAdditionalInsuranceAmount; set => SetField(ref _firstPaymentLetterAdditionalInsuranceAmount, value); }

        /// <summary>
        /// Correspondent First Payment Letter City Taxes [CORRESPONDENT.X394]
        /// </summary>
        public decimal? FirstPaymentLetterCityTaxes { get => _firstPaymentLetterCityTaxes; set => SetField(ref _firstPaymentLetterCityTaxes, value); }

        /// <summary>
        /// Correspondent First Payment Letter County Taxes [CORRESPONDENT.X395]
        /// </summary>
        public decimal? FirstPaymentLetterCountyTaxes { get => _firstPaymentLetterCountyTaxes; set => SetField(ref _firstPaymentLetterCountyTaxes, value); }

        /// <summary>
        /// Correspondent First Payment Letter Flood Amount [CORRESPONDENT.X391]
        /// </summary>
        public decimal? FirstPaymentLetterFloodAmount { get => _firstPaymentLetterFloodAmount; set => SetField(ref _firstPaymentLetterFloodAmount, value); }

        /// <summary>
        /// Correspondent First Payment Letter Hazard Amount [CORRESPONDENT.X390]
        /// </summary>
        public decimal? FirstPaymentLetterHazardAmount { get => _firstPaymentLetterHazardAmount; set => SetField(ref _firstPaymentLetterHazardAmount, value); }

        /// <summary>
        /// Correspondent First Payment Letter HOA Amount [CORRESPONDENT.X397]
        /// </summary>
        public decimal? FirstPaymentLetterHoaAmount { get => _firstPaymentLetterHoaAmount; set => SetField(ref _firstPaymentLetterHoaAmount, value); }

        /// <summary>
        /// Correspondent First Payment Letter Other Taxes [CORRESPONDENT.X399]
        /// </summary>
        public decimal? FirstPaymentLetterOtherTaxes { get => _firstPaymentLetterOtherTaxes; set => SetField(ref _firstPaymentLetterOtherTaxes, value); }

        /// <summary>
        /// Correspondent First Payment Letter PITI [CORRESPONDENT.X191]
        /// </summary>
        public decimal? FirstPaymentLetterPiti { get => _firstPaymentLetterPiti; set => SetField(ref _firstPaymentLetterPiti, value); }

        /// <summary>
        /// Correspondent First Payment Letter PMI/MIP Amount [CORRESPONDENT.X398]
        /// </summary>
        public decimal? FirstPaymentLetterPmiMipAmount { get => _firstPaymentLetterPmiMipAmount; set => SetField(ref _firstPaymentLetterPmiMipAmount, value); }

        /// <summary>
        /// Correspondent First Payment Letter School Taxes [CORRESPONDENT.X396]
        /// </summary>
        public decimal? FirstPaymentLetterSchoolTaxes { get => _firstPaymentLetterSchoolTaxes; set => SetField(ref _firstPaymentLetterSchoolTaxes, value); }

        /// <summary>
        /// Correspondent First Payment Letter Wind/Hail Amount [CORRESPONDENT.X392]
        /// </summary>
        public decimal? FirstPaymentLetterWindHailAmount { get => _firstPaymentLetterWindHailAmount; set => SetField(ref _firstPaymentLetterWindHailAmount, value); }

        /// <summary>
        /// Correspondent First Payment P&amp;I [CORRESPONDENT.X192]
        /// </summary>
        public decimal? FirstPaymentPi { get => _firstPaymentPi; set => SetField(ref _firstPaymentPi, value); }

        /// <summary>
        /// Correspondent First Rate Change Date [CORRESPONDENT.X448]
        /// </summary>
        public DateTime? FirstRateChangeDate { get => _firstRateChangeDate; set => SetField(ref _firstRateChangeDate, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X153]
        /// </summary>
        public int? FloodCoverageTerm { get => _floodCoverageTerm; set => SetField(ref _floodCoverageTerm, value); }

        /// <summary>
        /// Correspondent Flood Deductible [CORRESPONDENT.X161]
        /// </summary>
        public decimal? FloodDeductible { get => _floodDeductible; set => SetField(ref _floodDeductible, value); }

        /// <summary>
        /// Correspondent Flood Exclude from PITI Payment [CORRESPONDENT.X179]
        /// </summary>
        public bool? FloodExcludePitiPayment { get => _floodExcludePitiPayment; set => SetField(ref _floodExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent Flood insurance coverage may not be available (Building/Mobile Home in CBRA or OPA) [CORRESPONDENT.X497]
        /// </summary>
        public bool? FloodInsuranceCoverageIndicator { get => _floodInsuranceCoverageIndicator; set => SetField(ref _floodInsuranceCoverageIndicator, value); }

        /// <summary>
        /// Correspondent Flood Insurance Estimator [CORRESPONDENT.X226]
        /// </summary>
        public string? FloodInsuranceEstimator { get => _floodInsuranceEstimator; set => SetField(ref _floodInsuranceEstimator, value); }

        /// <summary>
        /// Correspondent Flood Insurance Guaranteed Replacement Cost [CORRESPONDENT.X204]
        /// </summary>
        public bool? FloodInsuranceGuaranteedReplacementCost { get => _floodInsuranceGuaranteedReplacementCost; set => SetField(ref _floodInsuranceGuaranteedReplacementCost, value); }

        /// <summary>
        /// Correspondent Property has Flood Insurance  [CORRESPONDENT.X498]
        /// </summary>
        public bool? FloodInsuranceIndicator { get => _floodInsuranceIndicator; set => SetField(ref _floodInsuranceIndicator, value); }

        /// <summary>
        /// Correspondent Flood Insurance Required [CORRESPONDENT.X193]
        /// </summary>
        public bool? FloodInsuranceRequired { get => _floodInsuranceRequired; set => SetField(ref _floodInsuranceRequired, value); }

        /// <summary>
        /// Correspondent Flood Payment Type [CORRESPONDENT.X462]
        /// </summary>
        public string? FloodPaymentType { get => _floodPaymentType; set => SetField(ref _floodPaymentType, value); }

        /// <summary>
        /// Correspondent Flood Policy Effective Date [CORRESPONDENT.X278]
        /// </summary>
        public DateTime? FloodPolicyEffectiveDate { get => _floodPolicyEffectiveDate; set => SetField(ref _floodPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Flood Policy Type [CORRESPONDENT.X291]
        /// </summary>
        public string? FloodPolicyType { get => _floodPolicyType; set => SetField(ref _floodPolicyType, value); }

        /// <summary>
        /// Correspondent Flood Premium Due Date [CORRESPONDENT.X296]
        /// </summary>
        public DateTime? FloodPremiumDueDate { get => _floodPremiumDueDate; set => SetField(ref _floodPremiumDueDate, value); }

        /// <summary>
        /// Correspondent FNMA UCD Case File Id [CORRESPONDENT.X195]
        /// </summary>
        public string? FnmaUcdCaseFileId { get => _fnmaUcdCaseFileId; set => SetField(ref _fnmaUcdCaseFileId, value); }

        /// <summary>
        /// Correspondent FNMA UCD Submission Date [CORRESPONDENT.X196]
        /// </summary>
        public DateTime? FnmaUcdSubmissionDate { get => _fnmaUcdSubmissionDate; set => SetField(ref _fnmaUcdSubmissionDate, value); }

        /// <summary>
        /// Correspondent FNMA UCD Success Flag [CORRESPONDENT.X197]
        /// </summary>
        public string? FnmaUcdSuccessFlag { get => _fnmaUcdSuccessFlag; set => SetField(ref _fnmaUcdSuccessFlag, value); }

        /// <summary>
        /// Correspondent FNM Condominium Project Manager Project Identifier [CORRESPONDENT.X194]
        /// </summary>
        public string? FnmCondominiumProjectManagerProjectIdentifier { get => _fnmCondominiumProjectManagerProjectIdentifier; set => SetField(ref _fnmCondominiumProjectManagerProjectIdentifier, value); }

        /// <summary>
        /// Correspondent Freddie Project Class [CORRESPONDENT.X198]
        /// </summary>
        public string? FreddieProjectClass { get => _freddieProjectClass; set => SetField(ref _freddieProjectClass, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Date [3922]
        /// </summary>
        public DateTime? FundedDate { get => _fundedDate; set => SetField(ref _fundedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period # of Days [3927]
        /// </summary>
        public int? GracePeriodDays { get => _gracePeriodDays; set => SetField(ref _gracePeriodDays, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Date [4110]
        /// </summary>
        public DateTime? GracePeriodStartDate { get => _gracePeriodStartDate; set => SetField(ref _gracePeriodStartDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Trigger Date [4111]
        /// </summary>
        public string? GracePeriodStartTrigger { get => _gracePeriodStartTrigger; set => SetField(ref _gracePeriodStartTrigger, value); }

        /// <summary>
        /// Correspondent USDA - Tracking - Guarantee Fee Collected [CORRESPONDENT.X17]
        /// </summary>
        public decimal? GuaranteeFeeCollected { get => _guaranteeFeeCollected; set => SetField(ref _guaranteeFeeCollected, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X154]
        /// </summary>
        public int? HazardCoverageTerm { get => _hazardCoverageTerm; set => SetField(ref _hazardCoverageTerm, value); }

        /// <summary>
        /// Correspondent Hazard Deductible [CORRESPONDENT.X162]
        /// </summary>
        public decimal? HazardDeductible { get => _hazardDeductible; set => SetField(ref _hazardDeductible, value); }

        /// <summary>
        /// Correspondent Hazard Exclude from PITI Payment [CORRESPONDENT.X180]
        /// </summary>
        public bool? HazardExcludePitiPayment { get => _hazardExcludePitiPayment; set => SetField(ref _hazardExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent Hazard Insurance Estimator [CORRESPONDENT.X227]
        /// </summary>
        public string? HazardInsuranceEstimator { get => _hazardInsuranceEstimator; set => SetField(ref _hazardInsuranceEstimator, value); }

        /// <summary>
        /// Correspondent Hazard Insurance Guaranteed Replacement Cost [CORRESPONDENT.X205]
        /// </summary>
        public bool? HazardInsuranceGuaranteedReplacementCost { get => _hazardInsuranceGuaranteedReplacementCost; set => SetField(ref _hazardInsuranceGuaranteedReplacementCost, value); }

        /// <summary>
        /// Correspondent Property has Hazard Insurance  [CORRESPONDENT.X499]
        /// </summary>
        public bool? HazardInsuranceIndicator { get => _hazardInsuranceIndicator; set => SetField(ref _hazardInsuranceIndicator, value); }

        /// <summary>
        /// Correspondent Hazard Payment Type [CORRESPONDENT.X463]
        /// </summary>
        public string? HazardPaymentType { get => _hazardPaymentType; set => SetField(ref _hazardPaymentType, value); }

        /// <summary>
        /// Correspondent Hazard Policy Effective Date [CORRESPONDENT.X279]
        /// </summary>
        public DateTime? HazardPolicyEffectiveDate { get => _hazardPolicyEffectiveDate; set => SetField(ref _hazardPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Hazard Policy Type [CORRESPONDENT.X292]
        /// </summary>
        public string? HazardPolicyType { get => _hazardPolicyType; set => SetField(ref _hazardPolicyType, value); }

        /// <summary>
        /// Correspondent Hazard Premium Due Date [CORRESPONDENT.X297]
        /// </summary>
        public DateTime? HazardPremiumDueDate { get => _hazardPremiumDueDate; set => SetField(ref _hazardPremiumDueDate, value); }

        /// <summary>
        /// Correspondent - High Priced Mortgage Loan Indicator [CORRESPONDENT.X474]
        /// </summary>
        public bool? HighPricedLoanIndicator { get => _highPricedLoanIndicator; set => SetField(ref _highPricedLoanIndicator, value); }

        /// <summary>
        /// Obsolete - Correspondent High Priced Mortgage Loan Indicator [CORRESPONDENT.X207]
        /// </summary>
        public string? HighPricedMortageLoanIndicator { get => _highPricedMortageLoanIndicator; set => SetField(ref _highPricedMortageLoanIndicator, value); }

        /// <summary>
        /// Correspondent HOA Budgeted Assessment Income [CORRESPONDENT.X208]
        /// </summary>
        public decimal? HoaBudgetedAssessmentIncome { get => _hoaBudgetedAssessmentIncome; set => SetField(ref _hoaBudgetedAssessmentIncome, value); }

        /// <summary>
        /// Correspondent HOA Budgeted Replacement Reserves [CORRESPONDENT.X209]
        /// </summary>
        public decimal? HoaBudgetedReplacementReserves { get => _hoaBudgetedReplacementReserves; set => SetField(ref _hoaBudgetedReplacementReserves, value); }

        /// <summary>
        /// Correspondent HOA Litigation Status [CORRESPONDENT.X210]
        /// </summary>
        public bool? HoaLitigationStatus { get => _hoaLitigationStatus; set => SetField(ref _hoaLitigationStatus, value); }

        /// <summary>
        /// Correspondent Home One Indicator [CORRESPONDENT.X211]
        /// </summary>
        public bool? HomeOneIndicator { get => _homeOneIndicator; set => SetField(ref _homeOneIndicator, value); }

        /// <summary>
        /// Correspondent Home Possible Adv Indicator [CORRESPONDENT.X213]
        /// </summary>
        public bool? HomePossibleAdvIndicator { get => _homePossibleAdvIndicator; set => SetField(ref _homePossibleAdvIndicator, value); }

        /// <summary>
        /// Correspondent Home Possible Indicator [CORRESPONDENT.X212]
        /// </summary>
        public bool? HomePossibleIndicator { get => _homePossibleIndicator; set => SetField(ref _homePossibleIndicator, value); }

        /// <summary>
        /// Correspondent Home Ready Indicator [CORRESPONDENT.X214]
        /// </summary>
        public bool? HomeReadyIndicator { get => _homeReadyIndicator; set => SetField(ref _homeReadyIndicator, value); }

        /// <summary>
        /// Correspondent Home Style Indicator [CORRESPONDENT.X215]
        /// </summary>
        public bool? HomeStyleIndicator { get => _homeStyleIndicator; set => SetField(ref _homeStyleIndicator, value); }

        /// <summary>
        /// Correspondent Housing Ratio [CORRESPONDENT.X450]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? HousingRatio { get => _housingRatio; set => SetField(ref _housingRatio, value); }

        /// <summary>
        /// Correspondent Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Correspondent IEAD Initial Deposit [CORRESPONDENT.X216]
        /// </summary>
        public decimal? IeadInitialDeposit { get => _ieadInitialDeposit; set => SetField(ref _ieadInitialDeposit, value); }

        /// <summary>
        /// Correspondent Includes Walls In [CORRESPONDENT.X502]
        /// </summary>
        public bool? IncludesWallsIn { get => _includesWallsIn; set => SetField(ref _includesWallsIn, value); }

        /// <summary>
        /// Correspondent - Includes Wind/Hail [CORRESPONDENT.X478]
        /// </summary>
        public bool? IncludesWindOrHail { get => _includesWindOrHail; set => SetField(ref _includesWindOrHail, value); }

        /// <summary>
        /// Correspondent Income Type [CORRESPONDENT.X220]
        /// </summary>
        public string? IncomeType { get => _incomeType; set => SetField(ref _incomeType, value); }

        /// <summary>
        /// Correspondent Index Type [CORRESPONDENT.X221]
        /// </summary>
        public string? IndexType { get => _indexType; set => SetField(ref _indexType, value); }

        /// <summary>
        /// Correspondent Fees Initial Adjusted Rate Permanent Phase [CORRESPONDENT.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InitialAdjustedRate { get => _initialAdjustedRate; set => SetField(ref _initialAdjustedRate, value); }

        /// <summary>
        /// Correspondent Fees Initial Adjusted Point Permanent Phase [CORRESPONDENT.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InitialAdjustedRatePoint { get => _initialAdjustedRatePoint; set => SetField(ref _initialAdjustedRatePoint, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Suspense Date [3918]
        /// </summary>
        public DateTime? InitialSuspenseDate { get => _initialSuspenseDate; set => SetField(ref _initialSuspenseDate, value); }

        /// <summary>
        /// Correspondent TIL Intl Disclosure Provided Date [CORRESPONDENT.X18]
        /// </summary>
        public DateTime? InitialTilDisclosureProvidedDate { get => _initialTilDisclosureProvidedDate; set => SetField(ref _initialTilDisclosureProvidedDate, value); }

        /// <summary>
        /// Correspondent TIL Intl TIL Disclosure Rcvd Date [CORRESPONDENT.X22]
        /// </summary>
        public DateTime? InitialTilDisclosureReceivedDate { get => _initialTilDisclosureReceivedDate; set => SetField(ref _initialTilDisclosureReceivedDate, value); }

        /// <summary>
        /// Correspondent Insurance Type [CORRESPONDENT.X501]
        /// </summary>
        public string? InsuranceType { get => _insuranceType; set => SetField(ref _insuranceType, value); }

        /// <summary>
        /// Correspondent My Company Wishes to not apply interest rate exportation [CORRESPONDENT.X504]
        /// </summary>
        public bool? InterestRateExportationIndicator { get => _interestRateExportationIndicator; set => SetField(ref _interestRateExportationIndicator, value); }

        /// <summary>
        /// Correspondent Additional Insurance included [CORRESPONDENT.X217]
        /// </summary>
        public bool? IsAdditionalInsurance { get => _isAdditionalInsurance; set => SetField(ref _isAdditionalInsurance, value); }

        /// <summary>
        /// Correspondent Flood Insurance included [CORRESPONDENT.X218]
        /// </summary>
        public bool? IsFloodInsurance { get => _isFloodInsurance; set => SetField(ref _isFloodInsurance, value); }

        /// <summary>
        /// Correspondent Hazard Included in Master Policy  [CORRESPONDENT.X500]
        /// </summary>
        public bool? IsHazardIncludedMasterPolicy { get => _isHazardIncludedMasterPolicy; set => SetField(ref _isHazardIncludedMasterPolicy, value); }

        /// <summary>
        /// Correspondent Subject Property Improve Indicator [CORRESPONDENT.X230]
        /// </summary>
        public bool? IsSubjectPropertyImproved { get => _isSubjectPropertyImproved; set => SetField(ref _isSubjectPropertyImproved, value); }

        /// <summary>
        /// Correspondent Is the highest and the best use of subject property as improved [CORRESPONDENT.X432]
        /// </summary>
        public string? IsTheHighestAndTheBestUseOfSubjectPropertyAsImproved { get => _isTheHighestAndTheBestUseOfSubjectPropertyAsImproved; set => SetField(ref _isTheHighestAndTheBestUseOfSubjectPropertyAsImproved, value); }

        /// <summary>
        /// Correspondent Wind/Hail Insurance included [CORRESPONDENT.X219]
        /// </summary>
        public bool? IsWindHailInsurance { get => _isWindHailInsurance; set => SetField(ref _isWindHailInsurance, value); }

        /// <summary>
        /// Correspondent Jumbo [CORRESPONDENT.X362]
        /// </summary>
        public bool? Jumbo { get => _jumbo; set => SetField(ref _jumbo, value); }

        /// <summary>
        /// Correspondent Last AUS Result [CORRESPONDENT.X231]
        /// </summary>
        public string? LastAusResult { get => _lastAusResult; set => SetField(ref _lastAusResult, value); }

        /// <summary>
        /// Correspondent Last AUS Run Date [CORRESPONDENT.X232]
        /// </summary>
        public DateTime? LastAusRunDate { get => _lastAusRunDate; set => SetField(ref _lastAusRunDate, value); }

        /// <summary>
        /// Correspondent Last AUS Type [CORRESPONDENT.X233]
        /// </summary>
        public string? LastAusType { get => _lastAusType; set => SetField(ref _lastAusType, value); }

        /// <summary>
        /// Correspondent Last Disclosure Date [CORRESPONDENT.X401]
        /// </summary>
        public DateTime? LastDisclosureDate { get => _lastDisclosureDate; set => SetField(ref _lastDisclosureDate, value); }

        /// <summary>
        /// Correspondent Last Disclosure Received Date [CORRESPONDENT.X402]
        /// </summary>
        public DateTime? LastDisclosureReceivedDate { get => _lastDisclosureReceivedDate; set => SetField(ref _lastDisclosureReceivedDate, value); }

        /// <summary>
        /// Correspondent Last Published Conditions Notification Date Time [CORRESPONDENT.X56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
        public DateTime? LastPublishedConditionsNotificationDateTime { get => _lastPublishedConditionsNotificationDateTime; set => SetField(ref _lastPublishedConditionsNotificationDateTime, value); }

        /// <summary>
        /// Correspondent Trans Details Late Charge Days [CORRESPONDENT.X10]
        /// </summary>
        public int? LateChargeDays { get => _lateChargeDays; set => SetField(ref _lateChargeDays, value); }

        /// <summary>
        /// Correspondent Trans Details Late Charge % [CORRESPONDENT.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LateChargePercent { get => _lateChargePercent; set => SetField(ref _lateChargePercent, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days Begin [3928]
        /// </summary>
        public DateTime? LateDaysBegin { get => _lateDaysBegin; set => SetField(ref _lateDaysBegin, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days End [3929]
        /// </summary>
        public DateTime? LateDaysEnd { get => _lateDaysEnd; set => SetField(ref _lateDaysEnd, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days End Trigger  Date [4112]
        /// </summary>
        public string? LateDaysEndTrigger { get => _lateDaysEndTrigger; set => SetField(ref _lateDaysEndTrigger, value); }

        /// <summary>
        /// Correspondent Trans Details Late Fee [CORRESPONDENT.X9]
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee Charge Type [3936]
        /// </summary>
        public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => _lateFeeChargeType; set => SetField(ref _lateFeeChargeType, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Frequency [3933]
        /// </summary>
        public string? LateFeeFrequency { get => _lateFeeFrequency; set => SetField(ref _lateFeeFrequency, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Notes [3935]
        /// </summary>
        public string? LateFeeNotes { get => _lateFeeNotes; set => SetField(ref _lateFeeNotes, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Late Fee Percentage [3931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
        public decimal? LateFeePercentage { get => _lateFeePercentage; set => SetField(ref _lateFeePercentage, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Total Price Adjustment [3934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, ReadOnly = true)]
        public decimal? LateFeeTotalPriceAdjustment { get => _lateFeeTotalPriceAdjustment; set => SetField(ref _lateFeeTotalPriceAdjustment, value); }

        /// <summary>
        /// Correspondent Loan Status - Latest Conds Issued Date [3919]
        /// </summary>
        public DateTime? LatestConditionsDate { get => _latestConditionsDate; set => SetField(ref _latestConditionsDate, value); }

        /// <summary>
        /// Correspondent Lender Paid MI Rate [CORRESPONDENT.X491]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LenderPaidMiRate { get => _lenderPaidMiRate; set => SetField(ref _lenderPaidMiRate, value); }

        /// <summary>
        /// Correspondent - Lender Paid Premium Amount [CORRESPONDENT.X492]
        /// </summary>
        public decimal? LenderPaidPremiumAmount { get => _lenderPaidPremiumAmount; set => SetField(ref _lenderPaidPremiumAmount, value); }

        /// <summary>
        /// Correspondent Compliance Review - LE Section J Lender Credit Total [CORRESPONDENT.X59]
        /// </summary>
        public int? LeSectionjLenderCreditTotal { get => _leSectionjLenderCreditTotal; set => SetField(ref _leSectionjLenderCreditTotal, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - Amount Value [LATEFEESETTING.X17]
        /// </summary>
        public decimal? LFSAmount { get => _lFSAmount; set => SetField(ref _lFSAmount, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X1]
        /// </summary>
        public int? LFSCalculateAs { get => _lFSCalculateAs; set => SetField(ref _lFSCalculateAs, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayCleared [LATEFEESETTING.X12]
        /// </summary>
        public int? LFSDayCleared { get => _lFSDayCleared; set => SetField(ref _lFSDayCleared, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate [LATEFEESETTING.X13]
        /// </summary>
        public string? LFSDayClearedOtherDate { get => _lFSDayClearedOtherDate; set => SetField(ref _lFSDayClearedOtherDate, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Description [LATEFEESETTING.X18]
        /// </summary>
        public string? LfsDayClearedOtherDateDescription { get => _lfsDayClearedOtherDateDescription; set => SetField(ref _lfsDayClearedOtherDateDescription, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value [LATEFEESETTING.X15]
        /// </summary>
        public string? LFSDayClearedOtherDateValue { get => _lFSDayClearedOtherDateValue; set => SetField(ref _lFSDayClearedOtherDateValue, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - FeeHandledAs [LATEFEESETTING.X2]
        /// </summary>
        public int? LFSFeeHandledAs { get => _lFSFeeHandledAs; set => SetField(ref _lFSFeeHandledAs, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar [LATEFEESETTING.X3]
        /// </summary>
        public int? LFSGracePeriodCalendar { get => _lFSGracePeriodCalendar; set => SetField(ref _lFSGracePeriodCalendar, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodDays [LATEFEESETTING.X11]
        /// </summary>
        public int? LFSGracePeriodDays { get => _lFSGracePeriodDays; set => SetField(ref _lFSGracePeriodDays, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf [LATEFEESETTING.X4]
        /// </summary>
        public int? LFSGracePeriodLaterOf { get => _lFSGracePeriodLaterOf; set => SetField(ref _lFSGracePeriodLaterOf, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts [LATEFEESETTING.X5]
        /// </summary>
        public int? LFSGracePeriodStarts { get => _lFSGracePeriodStarts; set => SetField(ref _lFSGracePeriodStarts, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X6]
        /// </summary>
        public int? LFSIncludeDay { get => _lFSIncludeDay; set => SetField(ref _lFSIncludeDay, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFee Value [LATEFEESETTING.X16]
        /// </summary>
        public decimal? LFSLateFee { get => _lFSLateFee; set => SetField(ref _lFSLateFee, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn [LATEFEESETTING.X7]
        /// </summary>
        public int? LFSLateFeeBasedOn { get => _lFSLateFeeBasedOn; set => SetField(ref _lFSLateFeeBasedOn, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - MaxLateDays [LATEFEESETTING.X8]
        /// </summary>
        public int? LFSMaxLateDays { get => _lFSMaxLateDays; set => SetField(ref _lFSMaxLateDays, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate [LATEFEESETTING.X9]
        /// </summary>
        public string? LFSOtherDate { get => _lFSOtherDate; set => SetField(ref _lFSOtherDate, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate Value [LATEFEESETTING.X14]
        /// </summary>
        public string? LFSOtherDateValue { get => _lFSOtherDateValue; set => SetField(ref _lFSOtherDateValue, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - StartOnWeekend [LATEFEESETTING.X10]
        /// </summary>
        public int? LFSStartOnWeekend { get => _lFSStartOnWeekend; set => SetField(ref _lFSStartOnWeekend, value); }

        /// <summary>
        /// Correspondent Life Of Loan [CORRESPONDENT.X238]
        /// </summary>
        public bool? LifeOfLoan { get => _lifeOfLoan; set => SetField(ref _lifeOfLoan, value); }

        /// <summary>
        /// Correspondent Life Time Cap 1 [CORRESPONDENT.X239]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LifeTimeCap1 { get => _lifeTimeCap1; set => SetField(ref _lifeTimeCap1, value); }

        /// <summary>
        /// Correspondent Life Time Cap 2 [CORRESPONDENT.X240]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LifeTimeCap2 { get => _lifeTimeCap2; set => SetField(ref _lifeTimeCap2, value); }

        /// <summary>
        /// Correspondent Living Area [CORRESPONDENT.X241]
        /// </summary>
        public decimal? LivingArea { get => _livingArea; set => SetField(ref _livingArea, value); }

        /// <summary>
        /// Correspondent Loan Discount Fee [CORRESPONDENT.X242]
        /// </summary>
        public decimal? LoanDiscountFee { get => _loanDiscountFee; set => SetField(ref _loanDiscountFee, value); }

        /// <summary>
        /// Correspondent Loan Status - Loan is Committed [4532]
        /// </summary>
        public bool? LoanIsCommitted { get => _loanIsCommitted; set => SetField(ref _loanIsCommitted, value); }

        /// <summary>
        /// Correspondent Disclosed Product [CORRESPONDENT.X28]
        /// </summary>
        public string? LoanProduct { get => _loanProduct; set => SetField(ref _loanProduct, value); }

        /// <summary>
        /// Correspondent Loan Status [CORRESPONDENT.X53]
        /// </summary>
        public string? LoanStatus { get => _loanStatus; set => SetField(ref _loanStatus, value); }

        /// <summary>
        /// Correspondent Loan Status Change User Name [CORRESPONDENT.X245]
        /// </summary>
        public string? LoanStatusChangeUserName { get => _loanStatusChangeUserName; set => SetField(ref _loanStatusChangeUserName, value); }

        /// <summary>
        /// Correspondent Loan Status Change DateTime Stamp [CORRESPONDENT.X246]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LoanStatusDateTimeStamp { get => _loanStatusDateTimeStamp; set => SetField(ref _loanStatusDateTimeStamp, value); }

        /// <summary>
        /// Correspondent Loan Status Last Updated DateTime [CORRESPONDENT.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
        public DateTime? LoanStatusLastUpdatedDateTime { get => _loanStatusLastUpdatedDateTime; set => SetField(ref _loanStatusLastUpdatedDateTime, value); }

        /// <summary>
        /// Correspondent Loan Status OCR [CORRESPONDENT.X244]
        /// </summary>
        public string? LoanStatusOcr { get => _loanStatusOcr; set => SetField(ref _loanStatusOcr, value); }

        /// <summary>
        /// Correspondent LOMA/LOMR [CORRESPONDENT.X247]
        /// </summary>
        public DateTime? LomaLomr { get => _lomaLomr; set => SetField(ref _lomaLomr, value); }

        /// <summary>
        /// Correspondent Lookback Period 1 [CORRESPONDENT.X248]
        /// </summary>
        public string? LookbackPeriod1 { get => _lookbackPeriod1; set => SetField(ref _lookbackPeriod1, value); }

        /// <summary>
        /// Correspondent Lookback Period 2 [CORRESPONDENT.X249]
        /// </summary>
        public string? LookbackPeriod2 { get => _lookbackPeriod2; set => SetField(ref _lookbackPeriod2, value); }

        /// <summary>
        /// Correspondent Freddie Mac Loan To Value (LTV) [CORRESPONDENT.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

        /// <summary>
        /// Correspondent Master Coverage Amount [CORRESPONDENT.X150]
        /// </summary>
        public decimal? MasterCoverageAmount { get => _masterCoverageAmount; set => SetField(ref _masterCoverageAmount, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X155]
        /// </summary>
        public int? MasterCoverageTerm { get => _masterCoverageTerm; set => SetField(ref _masterCoverageTerm, value); }

        /// <summary>
        /// Correspondent Master Insurance Company Name [CORRESPONDENT.X223]
        /// </summary>
        public string? MasterInsuranceCompanyName { get => _masterInsuranceCompanyName; set => SetField(ref _masterInsuranceCompanyName, value); }

        /// <summary>
        /// Correspondent Master Payment Type [CORRESPONDENT.X464]
        /// </summary>
        public string? MasterPaymentType { get => _masterPaymentType; set => SetField(ref _masterPaymentType, value); }

        /// <summary>
        /// Correspondent Master Policy Effective Date [CORRESPONDENT.X280]
        /// </summary>
        public DateTime? MasterPolicyEffectiveDate { get => _masterPolicyEffectiveDate; set => SetField(ref _masterPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Master Policy Expiration Date [CORRESPONDENT.X283]
        /// </summary>
        public DateTime? MasterPolicyExpirationDate { get => _masterPolicyExpirationDate; set => SetField(ref _masterPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Company Name [CORRESPONDENT.X412]
        /// </summary>
        public string? MasterPolicyFloodCompanyName { get => _masterPolicyFloodCompanyName; set => SetField(ref _masterPolicyFloodCompanyName, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Coverage Amount [CORRESPONDENT.X417]
        /// </summary>
        public decimal? MasterPolicyFloodCoverageAmount { get => _masterPolicyFloodCoverageAmount; set => SetField(ref _masterPolicyFloodCoverageAmount, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Payment Type [CORRESPONDENT.X416]
        /// </summary>
        public string? MasterPolicyFloodPaymentType { get => _masterPolicyFloodPaymentType; set => SetField(ref _masterPolicyFloodPaymentType, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Policy Effective Date [CORRESPONDENT.X414]
        /// </summary>
        public DateTime? MasterPolicyFloodPolicyEffectiveDate { get => _masterPolicyFloodPolicyEffectiveDate; set => SetField(ref _masterPolicyFloodPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Policy Expiration Date [CORRESPONDENT.X415]
        /// </summary>
        public DateTime? MasterPolicyFloodPolicyExpirationDate { get => _masterPolicyFloodPolicyExpirationDate; set => SetField(ref _masterPolicyFloodPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Master Policy Flood: Policy Number [CORRESPONDENT.X413]
        /// </summary>
        public string? MasterPolicyFloodPolicyNumber { get => _masterPolicyFloodPolicyNumber; set => SetField(ref _masterPolicyFloodPolicyNumber, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Company Name [CORRESPONDENT.X406]
        /// </summary>
        public string? MasterPolicyHazardCompanyName { get => _masterPolicyHazardCompanyName; set => SetField(ref _masterPolicyHazardCompanyName, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Coverage Amount [CORRESPONDENT.X411]
        /// </summary>
        public decimal? MasterPolicyHazardCoverageAmount { get => _masterPolicyHazardCoverageAmount; set => SetField(ref _masterPolicyHazardCoverageAmount, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Payment Type [CORRESPONDENT.X410]
        /// </summary>
        public string? MasterPolicyHazardPaymentType { get => _masterPolicyHazardPaymentType; set => SetField(ref _masterPolicyHazardPaymentType, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Policy Effective Date [CORRESPONDENT.X408]
        /// </summary>
        public DateTime? MasterPolicyHazardPolicyEffectiveDate { get => _masterPolicyHazardPolicyEffectiveDate; set => SetField(ref _masterPolicyHazardPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Policy Expiration Date [CORRESPONDENT.X409]
        /// </summary>
        public DateTime? MasterPolicyHazardPolicyExpirationDate { get => _masterPolicyHazardPolicyExpirationDate; set => SetField(ref _masterPolicyHazardPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Master Policy Hazard: Policy Number [CORRESPONDENT.X407]
        /// </summary>
        public string? MasterPolicyHazardPolicyNumber { get => _masterPolicyHazardPolicyNumber; set => SetField(ref _masterPolicyHazardPolicyNumber, value); }

        /// <summary>
        /// Correspondent Master Panel Number [CORRESPONDENT.X286]
        /// </summary>
        public string? MasterPolicyNumber { get => _masterPolicyNumber; set => SetField(ref _masterPolicyNumber, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Company Name [CORRESPONDENT.X425]
        /// </summary>
        public string? MasterPolicyOtherCompanyName { get => _masterPolicyOtherCompanyName; set => SetField(ref _masterPolicyOtherCompanyName, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Coverage Amount [CORRESPONDENT.X430]
        /// </summary>
        public decimal? MasterPolicyOtherCoverageAmount { get => _masterPolicyOtherCoverageAmount; set => SetField(ref _masterPolicyOtherCoverageAmount, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Insurance Type Description [CORRESPONDENT.X424]
        /// </summary>
        public string? MasterPolicyOtherInsuranceTypeDescription { get => _masterPolicyOtherInsuranceTypeDescription; set => SetField(ref _masterPolicyOtherInsuranceTypeDescription, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Payment Type [CORRESPONDENT.X429]
        /// </summary>
        public string? MasterPolicyOtherPaymentType { get => _masterPolicyOtherPaymentType; set => SetField(ref _masterPolicyOtherPaymentType, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Policy Effective Date [CORRESPONDENT.X427]
        /// </summary>
        public DateTime? MasterPolicyOtherPolicyEffectiveDate { get => _masterPolicyOtherPolicyEffectiveDate; set => SetField(ref _masterPolicyOtherPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Policy Expiration Date [CORRESPONDENT.X428]
        /// </summary>
        public DateTime? MasterPolicyOtherPolicyExpirationDate { get => _masterPolicyOtherPolicyExpirationDate; set => SetField(ref _masterPolicyOtherPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Master Policy Other: Policy Number [CORRESPONDENT.X426]
        /// </summary>
        public string? MasterPolicyOtherPolicyNumber { get => _masterPolicyOtherPolicyNumber; set => SetField(ref _masterPolicyOtherPolicyNumber, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Company Name [CORRESPONDENT.X418]
        /// </summary>
        public string? MasterPolicyWindOrHailCompanyName { get => _masterPolicyWindOrHailCompanyName; set => SetField(ref _masterPolicyWindOrHailCompanyName, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Coverage Amount [CORRESPONDENT.X423]
        /// </summary>
        public decimal? MasterPolicyWindOrHailCoverageAmount { get => _masterPolicyWindOrHailCoverageAmount; set => SetField(ref _masterPolicyWindOrHailCoverageAmount, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Payment Type [CORRESPONDENT.X422]
        /// </summary>
        public string? MasterPolicyWindOrHailPaymentType { get => _masterPolicyWindOrHailPaymentType; set => SetField(ref _masterPolicyWindOrHailPaymentType, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Policy Effective Date [CORRESPONDENT.X420]
        /// </summary>
        public DateTime? MasterPolicyWindOrHailPolicyEffectiveDate { get => _masterPolicyWindOrHailPolicyEffectiveDate; set => SetField(ref _masterPolicyWindOrHailPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Policy Expiration Date [CORRESPONDENT.X421]
        /// </summary>
        public DateTime? MasterPolicyWindOrHailPolicyExpirationDate { get => _masterPolicyWindOrHailPolicyExpirationDate; set => SetField(ref _masterPolicyWindOrHailPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Master Policy Wind/Hail: Policy Number [CORRESPONDENT.X419]
        /// </summary>
        public string? MasterPolicyWindOrHailPolicyNumber { get => _masterPolicyWindOrHailPolicyNumber; set => SetField(ref _masterPolicyWindOrHailPolicyNumber, value); }

        /// <summary>
        /// Correspondent Max First Change Rate 1 [CORRESPONDENT.X250]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxFirstChangeRate1 { get => _maxFirstChangeRate1; set => SetField(ref _maxFirstChangeRate1, value); }

        /// <summary>
        /// Correspondent Max First Change Rate 2 [CORRESPONDENT.X251]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxFirstChangeRate2 { get => _maxFirstChangeRate2; set => SetField(ref _maxFirstChangeRate2, value); }

        /// <summary>
        /// Correspondent Min First Change Rate 1 [CORRESPONDENT.X253]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinFirstChangeRate1 { get => _minFirstChangeRate1; set => SetField(ref _minFirstChangeRate1, value); }

        /// <summary>
        /// Correspondent Min First Change Rate 2 [CORRESPONDENT.X254]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinFirstChangeRate2 { get => _minFirstChangeRate2; set => SetField(ref _minFirstChangeRate2, value); }

        /// <summary>
        /// Correspondent - Mi Ordered By [CORRESPONDENT.X493]
        /// </summary>
        public StringEnumValue<MiOrderedBy> MiOrderedBy { get => _miOrderedBy; set => SetField(ref _miOrderedBy, value); }

        /// <summary>
        /// Correspondent MI Premium Payment Type [CORRESPONDENT.X252]
        /// </summary>
        public string? MiPremiumPaymentType { get => _miPremiumPaymentType; set => SetField(ref _miPremiumPaymentType, value); }

        /// <summary>
        /// Correspondent MI Premium Term [CORRESPONDENT.X490]
        /// </summary>
        public int? MiPremiumTerm { get => _miPremiumTerm; set => SetField(ref _miPremiumTerm, value); }

        /// <summary>
        /// Correspondent Date of First Payment Without Monthly MI [CORRESPONDENT.X475]
        /// </summary>
        public DateTime? MiTerminationDate { get => _miTerminationDate; set => SetField(ref _miTerminationDate, value); }

        /// <summary>
        /// Correspondent - Modification [CORRESPONDENT.X480]
        /// </summary>
        public bool? Modification { get => _modification; set => SetField(ref _modification, value); }

        /// <summary>
        /// Correspondent - Modification Date [CORRESPONDENT.X481]
        /// </summary>
        public DateTime? ModificationDate { get => _modificationDate; set => SetField(ref _modificationDate, value); }

        /// <summary>
        /// Correspondent MOM Indicator [CORRESPONDENT.X255]
        /// </summary>
        public bool? MomIndicator { get => _momIndicator; set => SetField(ref _momIndicator, value); }

        /// <summary>
        /// Correspondent Monthly Amount [CORRESPONDENT.X446]
        /// </summary>
        public decimal? MonthlyAmount { get => _monthlyAmount; set => SetField(ref _monthlyAmount, value); }

        /// <summary>
        /// Correspondent VA Monthly Housing Expense [CORRESPONDENT.X37]
        /// </summary>
        public decimal? MonthlyHousingExpense { get => _monthlyHousingExpense; set => SetField(ref _monthlyHousingExpense, value); }

        /// <summary>
        /// Correspondent Monthly Premium Amount [CORRESPONDENT.X83]
        /// </summary>
        public string? MonthlyPremiumAmount { get => _monthlyPremiumAmount; set => SetField(ref _monthlyPremiumAmount, value); }

        /// <summary>
        /// Correspondent Monthly Rent Amount Unit3 [CORRESPONDENT.X256]
        /// </summary>
        public decimal? MonthlyRentAmountUnit3 { get => _monthlyRentAmountUnit3; set => SetField(ref _monthlyRentAmountUnit3, value); }

        /// <summary>
        /// Correspondent Monthly Rent Amount Unit4 [CORRESPONDENT.X257]
        /// </summary>
        public decimal? MonthlyRentAmountUnit4 { get => _monthlyRentAmountUnit4; set => SetField(ref _monthlyRentAmountUnit4, value); }

        /// <summary>
        /// Correspondent Insurance Mtg Ins Mos Prepaid [CORRESPONDENT.X14]
        /// </summary>
        public int? MonthsOfMiPrepaid { get => _monthsOfMiPrepaid; set => SetField(ref _monthsOfMiPrepaid, value); }

        /// <summary>
        /// Correspondent Insurance Mtg Ins Upfront Factor [CORRESPONDENT.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => _mortgageInsurancePremiumUpfrontFactorPercent; set => SetField(ref _mortgageInsurancePremiumUpfrontFactorPercent, value); }

        /// <summary>
        /// Correspondent Negative Cash Flow [CORRESPONDENT.X439]
        /// </summary>
        public decimal? NegativeCashFlow { get => _negativeCashFlow; set => SetField(ref _negativeCashFlow, value); }

        /// <summary>
        /// Correspondent NFIP Panel date [CORRESPONDENT.X262]
        /// </summary>
        public DateTime? NfipPaneldate { get => _nfipPaneldate; set => SetField(ref _nfipPaneldate, value); }

        /// <summary>
        /// Correspondent NFIP Panel Number [CORRESPONDENT.X263]
        /// </summary>
        public string? NfipPanelNumber { get => _nfipPanelNumber; set => SetField(ref _nfipPanelNumber, value); }

        /// <summary>
        /// Correspondent - NFIP Program Type [CORRESPONDENT.X496]
        /// </summary>
        public StringEnumValue<NfipProgramType> NfipProgramType { get => _nfipProgramType; set => SetField(ref _nfipProgramType, value); }

        /// <summary>
        /// Correspondent Non-Mortgage Payoff Amount [CORRESPONDENT.X264]
        /// </summary>
        public decimal? NonMortgagePayoffAmount { get => _nonMortgagePayoffAmount; set => SetField(ref _nonMortgagePayoffAmount, value); }

        /// <summary>
        /// Correspondent Non-Shoppable Services (B) [CORRESPONDENT.X265]
        /// </summary>
        public decimal? NonShoppableServicesB { get => _nonShoppableServicesB; set => SetField(ref _nonShoppableServicesB, value); }

        /// <summary>
        /// Correspondent Non-Traditional Credit [CORRESPONDENT.X266]
        /// </summary>
        public bool? NonTraditionalCredit { get => _nonTraditionalCredit; set => SetField(ref _nonTraditionalCredit, value); }

        /// <summary>
        /// Correspondent Notary Acknowledgement Date [CORRESPONDENT.X267]
        /// </summary>
        public DateTime? NotaryAcknowledgementDate { get => _notaryAcknowledgementDate; set => SetField(ref _notaryAcknowledgementDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Note Date [3925]
        /// </summary>
        public DateTime? NoteDate { get => _noteDate; set => SetField(ref _noteDate, value); }

        /// <summary>
        /// Correspondent Note (P&amp;I) 2 [CORRESPONDENT.X360]
        /// </summary>
        public decimal? NotePAndI2 { get => _notePAndI2; set => SetField(ref _notePAndI2, value); }

        /// <summary>
        /// Correspondent Note P &amp; I [CORRESPONDENT.X268]
        /// </summary>
        public decimal? NotePi { get => _notePi; set => SetField(ref _notePi, value); }

        /// <summary>
        /// Correspondent NOV Amount [CORRESPONDENT.X434]
        /// </summary>
        public decimal? NovAmount { get => _novAmount; set => SetField(ref _novAmount, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms [CORRESPONDENT.X269]
        /// </summary>
        public int? NumberofBedrooms { get => _numberofBedrooms; set => SetField(ref _numberofBedrooms, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms Unit 1 [CORRESPONDENT.X270]
        /// </summary>
        public int? NumberofBedroomsUnit1 { get => _numberofBedroomsUnit1; set => SetField(ref _numberofBedroomsUnit1, value); }

        /// <summary>
        /// Correspondent Number of Bedrooms Unit 2 [CORRESPONDENT.X271]
        /// </summary>
        public int? NumberofBedroomsUnit2 { get => _numberofBedroomsUnit2; set => SetField(ref _numberofBedroomsUnit2, value); }

        /// <summary>
        /// Correspondent Number Of Bedroom Unit 3 [CORRESPONDENT.X70]
        /// </summary>
        public int? NumberOfBedroomUnit3 { get => _numberOfBedroomUnit3; set => SetField(ref _numberOfBedroomUnit3, value); }

        /// <summary>
        /// Correspondent Number Of Bedroom Unit 4 [CORRESPONDENT.X71]
        /// </summary>
        public int? NumberOfBedroomUnit4 { get => _numberOfBedroomUnit4; set => SetField(ref _numberOfBedroomUnit4, value); }

        /// <summary>
        /// Correspondent Number Of Buydown Periods [CORRESPONDENT.X72]
        /// </summary>
        public int? NumberOfBuydownPeriods { get => _numberOfBuydownPeriods; set => SetField(ref _numberOfBuydownPeriods, value); }

        /// <summary>
        /// Correspondent Number of Units [CORRESPONDENT.X272]
        /// </summary>
        public int? NumberOfUnits { get => _numberOfUnits; set => SetField(ref _numberOfUnits, value); }

        /// <summary>
        /// Correspondent Loan Status - Original Principal Balance [4107]
        /// </summary>
        public decimal? OriginalPrincipalBalance { get => _originalPrincipalBalance; set => SetField(ref _originalPrincipalBalance, value); }

        /// <summary>
        /// Correspondent Origination Charged (A) [CORRESPONDENT.X273]
        /// </summary>
        public decimal? OriginationChargedA { get => _originationChargedA; set => SetField(ref _originationChargedA, value); }

        /// <summary>
        /// Correspondent Other Insurance Type [CORRESPONDENT.X451]
        /// </summary>
        public string? OtherInsuranceType { get => _otherInsuranceType; set => SetField(ref _otherInsuranceType, value); }

        /// <summary>
        /// Correspondent Other Taxes Exclude PITI Payment [CORRESPONDENT.X181]
        /// </summary>
        public bool? OtherTaxesExcludePitiPayment { get => _otherTaxesExcludePitiPayment; set => SetField(ref _otherTaxesExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent Other Taxes Frequency [CORRESPONDENT.X201]
        /// </summary>
        public string? OtherTaxesFrequency { get => _otherTaxesFrequency; set => SetField(ref _otherTaxesFrequency, value); }

        /// <summary>
        /// Correspondent Other Taxes Monthly Amount [CORRESPONDENT.X385]
        /// </summary>
        public decimal? OtherTaxesMonthlyAmount { get => _otherTaxesMonthlyAmount; set => SetField(ref _otherTaxesMonthlyAmount, value); }

        /// <summary>
        /// Correspondent Other Taxes Next Payment Due Date [CORRESPONDENT.X260]
        /// </summary>
        public DateTime? OtherTaxesNextPaymentDueDate { get => _otherTaxesNextPaymentDueDate; set => SetField(ref _otherTaxesNextPaymentDueDate, value); }

        /// <summary>
        /// Correspondent Panel Number [CORRESPONDENT.X274]
        /// </summary>
        public string? PanelNumber { get => _panelNumber; set => SetField(ref _panelNumber, value); }

        /// <summary>
        /// Correspondent Payment Amount [CORRESPONDENT.X30]
        /// </summary>
        public decimal? PaymentAmount { get => _paymentAmount; set => SetField(ref _paymentAmount, value); }

        /// <summary>
        /// Correspondent Periodic Change % [CORRESPONDENT.X275]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PeriodicChangePercent1 { get => _periodicChangePercent1; set => SetField(ref _periodicChangePercent1, value); }

        /// <summary>
        /// Correspondent Periodic Change % [CORRESPONDENT.X276]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PeriodicChangePercent2 { get => _periodicChangePercent2; set => SetField(ref _periodicChangePercent2, value); }

        /// <summary>
        /// Correspondent Points in Initial Adjusted Rate [CORRESPONDENT.X505]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PointsInInitialAdjustedRate { get => _pointsInInitialAdjustedRate; set => SetField(ref _pointsInInitialAdjustedRate, value); }

        /// <summary>
        /// Correspondent Zip Code 4 digits [CORRESPONDENT.X358]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Correspondent Power of Attorney Indicator [CORRESPONDENT.X294]
        /// </summary>
        public bool? PowerofAttorneyIndicator { get => _powerofAttorneyIndicator; set => SetField(ref _powerofAttorneyIndicator, value); }

        /// <summary>
        /// Correspondent Premium Term [CORRESPONDENT.X299]
        /// </summary>
        public string? PremiumTerm { get => _premiumTerm; set => SetField(ref _premiumTerm, value); }

        /// <summary>
        /// Correspondent Prepaid Finance [CORRESPONDENT.X300]
        /// </summary>
        public decimal? PrepaidFinance { get => _prepaidFinance; set => SetField(ref _prepaidFinance, value); }

        /// <summary>
        /// Correspondent Prepaid Interest Days [CORRESPONDENT.X73]
        /// </summary>
        public int? PrepaidInterestDays { get => _prepaidInterestDays; set => SetField(ref _prepaidInterestDays, value); }

        /// <summary>
        /// Correspondent Compliance Review - Prepayment Penalty [CORRESPONDENT.X58]
        /// </summary>
        public bool? PrepaymentPenalty { get => _prepaymentPenalty; set => SetField(ref _prepaymentPenalty, value); }

        /// <summary>
        /// Correspondent Prepayment Penalty [CORRESPONDENT.X29]
        /// </summary>
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }

        /// <summary>
        /// Correspondent Prepayment Rider Indicator [CORRESPONDENT.X165]
        /// </summary>
        public bool? PrepaymentRiderIndicator { get => _prepaymentRiderIndicator; set => SetField(ref _prepaymentRiderIndicator, value); }

        /// <summary>
        /// Correspondent Mo Pymt (P&amp;I) [CORRESPONDENT.X3]
        /// </summary>
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => _principalAndInterestMonthlyPaymentAmount; set => SetField(ref _principalAndInterestMonthlyPaymentAmount, value); }

        /// <summary>
        /// Correspondent Compliance Review - Prior Application Date [CORRESPONDENT.X62]
        /// </summary>
        public DateTime? PriorApplicationDate { get => _priorApplicationDate; set => SetField(ref _priorApplicationDate, value); }

        /// <summary>
        /// Correspondent Prior Disclosed Daily Interest [CORRESPONDENT.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PriorDisclosedDailyInterest { get => _priorDisclosedDailyInterest; set => SetField(ref _priorDisclosedDailyInterest, value); }

        /// <summary>
        /// Correspondent Compliance Review - Prior Disclosure Date [CORRESPONDENT.X57]
        /// </summary>
        public DateTime? PriorDisclosureDate { get => _priorDisclosureDate; set => SetField(ref _priorDisclosureDate, value); }

        /// <summary>
        /// Correspondent Project Class [CORRESPONDENT.X301]
        /// </summary>
        public StringEnumValue<ProjectType> ProjectClass { get => _projectClass; set => SetField(ref _projectClass, value); }

        /// <summary>
        /// Correspondent Project Name [CORRESPONDENT.X302]
        /// </summary>
        public string? ProjectName { get => _projectName; set => SetField(ref _projectName, value); }

        /// <summary>
        /// Correspondent Property Acquired Less Than One Year Ago [CORRESPONDENT.X303]
        /// </summary>
        public bool? PropertyAcquiredLessThanOneYearAgo { get => _propertyAcquiredLessThanOneYearAgo; set => SetField(ref _propertyAcquiredLessThanOneYearAgo, value); }

        /// <summary>
        /// Correspondent Property Appraisal Type [CORRESPONDENT.X304]
        /// </summary>
        public string? PropertyAppraisalType { get => _propertyAppraisalType; set => SetField(ref _propertyAppraisalType, value); }

        /// <summary>
        /// Correspondent Property Appraisal Unit Number [CORRESPONDENT.X348]
        /// </summary>
        public string? PropertyAppraisalUnitNumber { get => _propertyAppraisalUnitNumber; set => SetField(ref _propertyAppraisalUnitNumber, value); }

        /// <summary>
        /// Correspondent Property Attachment Type [CORRESPONDENT.X305]
        /// </summary>
        public StringEnumValue<AttachmentType> PropertyAttachmentType { get => _propertyAttachmentType; set => SetField(ref _propertyAttachmentType, value); }

        /// <summary>
        /// Correspondent Property Flip Indicator [CORRESPONDENT.X361]
        /// </summary>
        public bool? PropertyFlipIndicator { get => _propertyFlipIndicator; set => SetField(ref _propertyFlipIndicator, value); }

        /// <summary>
        /// Correspondent Occupancy Status [CORRESPONDENT.X306]
        /// </summary>
        public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => _propertyUsageCode; set => SetField(ref _propertyUsageCode, value); }

        /// <summary>
        /// Correspondent Property Value [CORRESPONDENT.X307]
        /// </summary>
        public decimal? PropertyValue { get => _propertyValue; set => SetField(ref _propertyValue, value); }

        /// <summary>
        /// Correspondent Expenses Proposed HOA [CORRESPONDENT.X34]
        /// </summary>
        public string? ProposedDuesAmount { get => _proposedDuesAmount; set => SetField(ref _proposedDuesAmount, value); }

        /// <summary>
        /// Correspondent Expenses Proposed Haz Ins [CORRESPONDENT.X31]
        /// </summary>
        public string? ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => SetField(ref _proposedHazardInsuranceAmount, value); }

        /// <summary>
        /// Correspondent Expenses Proposed Mtg Ins [CORRESPONDENT.X33]
        /// </summary>
        public string? ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => SetField(ref _proposedMortgageInsuranceAmount, value); }

        /// <summary>
        /// Correspondent Expenses Proposed Other Housing [CORRESPONDENT.X35]
        /// </summary>
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => SetField(ref _proposedOtherAmount, value); }

        /// <summary>
        /// Correspondent Expenses Proposed Taxes [CORRESPONDENT.X32]
        /// </summary>
        public string? ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => SetField(ref _proposedRealEstateTaxesAmount, value); }

        /// <summary>
        /// Correspondent Purchase Contract Sales Price [CORRESPONDENT.X308]
        /// </summary>
        public decimal? PurchaseContractSalesPrice { get => _purchaseContractSalesPrice; set => SetField(ref _purchaseContractSalesPrice, value); }

        /// <summary>
        /// Correspondent Rate Adjustment Periodic Cap [CORRESPONDENT.X309]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateAdjustmentPeriodicCap { get => _rateAdjustmentPeriodicCap; set => SetField(ref _rateAdjustmentPeriodicCap, value); }

        /// <summary>
        /// Correspondent Rate Adjustment Periodic Cap 2 [CORRESPONDENT.X310]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateAdjustmentPeriodicCap2 { get => _rateAdjustmentPeriodicCap2; set => SetField(ref _rateAdjustmentPeriodicCap2, value); }

        /// <summary>
        /// Correspondent ATR QM - Qualification - Rate Reduction Basis Points % [CORRESPONDENT.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateReductionBasisPoints { get => _rateReductionBasisPoints; set => SetField(ref _rateReductionBasisPoints, value); }

        /// <summary>
        /// Correspondent Loan Status - Rate Sheet ID [3923]
        /// </summary>
        public string? Ratesheet { get => _ratesheet; set => SetField(ref _ratesheet, value); }

        /// <summary>
        /// Correspondent Loan Status - Received Date [3917]
        /// </summary>
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        /// <summary>
        /// Correspondent Recoupment Number of Months [CORRESPONDENT.X311]
        /// </summary>
        public int? RecoupmentNumberOfMonths { get => _recoupmentNumberOfMonths; set => SetField(ref _recoupmentNumberOfMonths, value); }

        /// <summary>
        /// Correspondent Reduced MI Indicator [CORRESPONDENT.X312]
        /// </summary>
        public bool? ReducedMiIndicator { get => _reducedMiIndicator; set => SetField(ref _reducedMiIndicator, value); }

        /// <summary>
        /// Correspondent Refinance Type [CORRESPONDENT.X503]
        /// </summary>
        public StringEnumValue<CorrespondentRefinanceType> RefinanceType { get => _refinanceType; set => SetField(ref _refinanceType, value); }

        /// <summary>
        /// Correspondent Refund prorated unearned Up Front MI Premiums [CORRESPONDENT.X15]
        /// </summary>
        public bool? RefundUnearnedMipIndicator { get => _refundUnearnedMipIndicator; set => SetField(ref _refundUnearnedMipIndicator, value); }

        /// <summary>
        /// Correspondent Loan Status - Rejected Date [3940]
        /// </summary>
        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }

        /// <summary>
        /// Correspondent - Renovation [CORRESPONDENT.X479]
        /// </summary>
        public bool? Renovation { get => _renovation; set => SetField(ref _renovation, value); }

        /// <summary>
        /// Correspondent Renovation Complete Indicator [CORRESPONDENT.X313]
        /// </summary>
        public bool? RenovationCompleteIndicator { get => _renovationCompleteIndicator; set => SetField(ref _renovationCompleteIndicator, value); }

        /// <summary>
        /// Correspondent Renovation Program  [CORRESPONDENT.X488]
        /// </summary>
        public bool? RenovationProgramIndicator { get => _renovationProgramIndicator; set => SetField(ref _renovationProgramIndicator, value); }

        /// <summary>
        /// Correspondent Rent Amount Unit 1 [CORRESPONDENT.X314]
        /// </summary>
        public decimal? RentAmountUnit1 { get => _rentAmountUnit1; set => SetField(ref _rentAmountUnit1, value); }

        /// <summary>
        /// Correspondent Rent Amount Unit 2 [CORRESPONDENT.X315]
        /// </summary>
        public decimal? RentAmountUnit2 { get => _rentAmountUnit2; set => SetField(ref _rentAmountUnit2, value); }

        /// <summary>
        /// Correspondent Riders
        /// </summary>
        [AllowNull]
        public IList<Rider> Riders { get => GetField(ref _riders); set => SetField(ref _riders, value); }

        /// <summary>
        /// Correspondent SAR Expiration Date [CORRESPONDENT.X435]
        /// </summary>
        public DateTime? SarExpirationDate { get => _sarExpirationDate; set => SetField(ref _sarExpirationDate, value); }

        /// <summary>
        /// Correspondent Scenarios
        /// </summary>
        [AllowNull]
        public IList<Scenario> Scenarios { get => GetField(ref _scenarios); set => SetField(ref _scenarios, value); }

        /// <summary>
        /// Correspondent Trans Details First Pymt Date [CORRESPONDENT.X40]
        /// </summary>
        public DateTime? ScheduledFirstPaymentDate { get => _scheduledFirstPaymentDate; set => SetField(ref _scheduledFirstPaymentDate, value); }

        /// <summary>
        /// Correspondent School Taxes Monthly Amount [CORRESPONDENT.X384]
        /// </summary>
        public decimal? SchoolTaxesMonthlyAmount { get => _schoolTaxesMonthlyAmount; set => SetField(ref _schoolTaxesMonthlyAmount, value); }

        /// <summary>
        /// Correspondent Sec 32 - HOEPA APR [CORRESPONDENT.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Section32Apr { get => _section32Apr; set => SetField(ref _section32Apr, value); }

        /// <summary>
        /// Correspondent Section32 Disclosure Date [CORRESPONDENT.X319]
        /// </summary>
        public DateTime? Section32DisclosureDate { get => _section32DisclosureDate; set => SetField(ref _section32DisclosureDate, value); }

        /// <summary>
        /// Correspondent Loan qualifies as high cost under Section 32 [CORRESPONDENT.X320]
        /// </summary>
        public bool? Section32Indicator { get => _section32Indicator; set => SetField(ref _section32Indicator, value); }

        /// <summary>
        /// Correspondent - Seller Paid Discount Fees [CORRESPONDENT.X484]
        /// </summary>
        public decimal? SellerPaidDiscountFees { get => _sellerPaidDiscountFees; set => SetField(ref _sellerPaidDiscountFees, value); }

        /// <summary>
        /// Correspondent Site Value [CORRESPONDENT.X323]
        /// </summary>
        public decimal? SiteValue { get => _siteValue; set => SetField(ref _siteValue, value); }

        /// <summary>
        /// Correspondent Specialty Product [CORRESPONDENT.X324]
        /// </summary>
        public string? SpecialtyProduct { get => _specialtyProduct; set => SetField(ref _specialtyProduct, value); }

        /// <summary>
        /// Correspondent Standard Deviation [CORRESPONDENT.X325]
        /// </summary>
        public string? StandardDeviation { get => _standardDeviation; set => SetField(ref _standardDeviation, value); }

        /// <summary>
        /// Correspondent Stated Gross Rent [CORRESPONDENT.X327]
        /// </summary>
        public decimal? StatedGrossRent { get => _statedGrossRent; set => SetField(ref _statedGrossRent, value); }

        /// <summary>
        /// Correspondent Stated Property Condition [CORRESPONDENT.X328]
        /// </summary>
        public string? StatedPropertyCondition { get => _statedPropertyCondition; set => SetField(ref _statedPropertyCondition, value); }

        /// <summary>
        /// Correspondent Stated Property Type [CORRESPONDENT.X329]
        /// </summary>
        public StringEnumValue<PropertyType> StatedPropertyType { get => _statedPropertyType; set => SetField(ref _statedPropertyType, value); }

        /// <summary>
        /// Correspondent State Taxes Exclude from PITI Payment [CORRESPONDENT.X182]
        /// </summary>
        public bool? StateTaxesExcludePitiPayment { get => _stateTaxesExcludePitiPayment; set => SetField(ref _stateTaxesExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent State Taxes Frequency [CORRESPONDENT.X202]
        /// </summary>
        public string? StateTaxesFrequency { get => _stateTaxesFrequency; set => SetField(ref _stateTaxesFrequency, value); }

        /// <summary>
        /// Correspondent State Taxes Next Payment Due Date [CORRESPONDENT.X261]
        /// </summary>
        public DateTime? StateTaxesNextPaymentDueDate { get => _stateTaxesNextPaymentDueDate; set => SetField(ref _stateTaxesNextPaymentDueDate, value); }

        /// <summary>
        /// Correspondent Subject Address City [CORRESPONDENT.X330]
        /// </summary>
        public string? SubjectAddressCity { get => _subjectAddressCity; set => SetField(ref _subjectAddressCity, value); }

        /// <summary>
        /// Correspondent Subject Property Improved [CORRESPONDENT.X331]
        /// </summary>
        public StringEnumValue<PropertyImprovementsType> SubjectPropertyImproved { get => _subjectPropertyImproved; set => SetField(ref _subjectPropertyImproved, value); }

        /// <summary>
        /// Correspondent State [CORRESPONDENT.X326]
        /// </summary>
        public StringEnumValue<State> SubjectPropertyState { get => _subjectPropertyState; set => SetField(ref _subjectPropertyState, value); }

        /// <summary>
        /// Correspondent Subject Property Unit Number [CORRESPONDENT.X332]
        /// </summary>
        public string? SubjectPropertyUnitNumber { get => _subjectPropertyUnitNumber; set => SetField(ref _subjectPropertyUnitNumber, value); }

        /// <summary>
        /// Correspondent Loan Status - Submitted for Review Date [4119]
        /// </summary>
        public DateTime? SubmittedforPurchaseDate { get => _submittedforPurchaseDate; set => SetField(ref _submittedforPurchaseDate, value); }

        /// <summary>
        /// Correspondent Subordination Type [CORRESPONDENT.X333]
        /// </summary>
        public string? SubordinationType { get => _subordinationType; set => SetField(ref _subordinationType, value); }

        /// <summary>
        /// Correspondent Subsequent Adjustment Term [CORRESPONDENT.X334]
        /// </summary>
        public int? SubsequentAdjustmentTerm { get => _subsequentAdjustmentTerm; set => SetField(ref _subsequentAdjustmentTerm, value); }

        /// <summary>
        /// Correspondent Supervisory Appraisal Co License # [CORRESPONDENT.X335]
        /// </summary>
        public string? SupervisoryAppraiserLicenseNumber { get => _supervisoryAppraiserLicenseNumber; set => SetField(ref _supervisoryAppraiserLicenseNumber, value); }

        /// <summary>
        /// Correspondent Texas A6 Indicator [CORRESPONDENT.X337]
        /// </summary>
        public bool? TexasA6Indicator { get => _texasA6Indicator; set => SetField(ref _texasA6Indicator, value); }

        /// <summary>
        /// Correspondent Texas A6 Indicator 2 [CORRESPONDENT.X338]
        /// </summary>
        public bool? TexasA6Indicator2 { get => _texasA6Indicator2; set => SetField(ref _texasA6Indicator2, value); }

        /// <summary>
        /// Correspondent Trans Details Qual Ratio Top [CORRESPONDENT.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? TopRatioPercent { get => _topRatioPercent; set => SetField(ref _topRatioPercent, value); }

        /// <summary>
        /// Correspondent Total Escrows Collected At Closing [CORRESPONDENT.X340]
        /// </summary>
        public decimal? TotalEscrowsCollectedAtClosing { get => _totalEscrowsCollectedAtClosing; set => SetField(ref _totalEscrowsCollectedAtClosing, value); }

        /// <summary>
        /// Correspondent Loan Status - Total Late Days [3930]
        /// </summary>
        public int? TotalLateDays { get => _totalLateDays; set => SetField(ref _totalLateDays, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee -Total Late Fee [3937]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalLateFee { get => _totalLateFee; set => SetField(ref _totalLateFee, value); }

        /// <summary>
        /// Correspondent Total Net Monthly Salary [CORRESPONDENT.X36]
        /// </summary>
        public decimal? TotalNetMonthlySalary { get => _totalNetMonthlySalary; set => SetField(ref _totalNetMonthlySalary, value); }

        /// <summary>
        /// Correspondent REGZ Total Amt All Pymts [CORRESPONDENT.X21]
        /// </summary>
        public decimal? TotalOfPayments { get => _totalOfPayments; set => SetField(ref _totalOfPayments, value); }

        /// <summary>
        /// Correspondent TX Preclose CD Borrower Delivery Date [CORRESPONDENT.X341]
        /// </summary>
        public DateTime? TxPrecloseCdBorrDeliveryDate { get => _txPrecloseCdBorrDeliveryDate; set => SetField(ref _txPrecloseCdBorrDeliveryDate, value); }

        /// <summary>
        /// Correspondent TX Preclose CD Borrower Receipt Date [CORRESPONDENT.X342]
        /// </summary>
        public DateTime? TxPrecloseCdBorrReceiptDate { get => _txPrecloseCdBorrReceiptDate; set => SetField(ref _txPrecloseCdBorrReceiptDate, value); }

        /// <summary>
        /// Correspondent UcdLastSubmissionDateTime
        /// </summary>
        public DateTime? UcdLastSubmissionDateTime { get => _ucdLastSubmissionDateTime; set => SetField(ref _ucdLastSubmissionDateTime, value); }

        /// <summary>
        /// Correspondent UCDP Appraisal Effective Date [CORRESPONDENT.X343]
        /// </summary>
        public DateTime? UcdpAppraisalEffectiveDate { get => _ucdpAppraisalEffectiveDate; set => SetField(ref _ucdpAppraisalEffectiveDate, value); }

        /// <summary>
        /// Correspondent UCDP Appraised Value [CORRESPONDENT.X344]
        /// </summary>
        public int? UcdpAppraisedValueAmount { get => _ucdpAppraisedValueAmount; set => SetField(ref _ucdpAppraisedValueAmount, value); }

        /// <summary>
        /// Correspondent UCDP DOC File ID [CORRESPONDENT.X345]
        /// </summary>
        public string? UcdpDocFileId { get => _ucdpDocFileId; set => SetField(ref _ucdpDocFileId, value); }

        /// <summary>
        /// Correspondent UCDP Over Valuation [CORRESPONDENT.X346]
        /// </summary>
        public string? UcdpOverValuation { get => _ucdpOverValuation; set => SetField(ref _ucdpOverValuation, value); }

        /// <summary>
        /// Correspondent FHLMC UCD Submission Date [CORRESPONDENT.X187]
        /// </summary>
        public DateTime? UcdSubmissionDate { get => _ucdSubmissionDate; set => SetField(ref _ucdSubmissionDate, value); }

        /// <summary>
        /// Correspondent UCD EC Result [CORRESPONDENT.X167]
        /// </summary>
        public string? UcdSubmissionResult { get => _ucdSubmissionResult; set => SetField(ref _ucdSubmissionResult, value); }

        /// <summary>
        /// Correspondent Underwriting Method [CORRESPONDENT.X347]
        /// </summary>
        public StringEnumValue<RiskAssessmentType> UnderwritingMethod { get => _underwritingMethod; set => SetField(ref _underwritingMethod, value); }

        /// <summary>
        /// Correspondent UnDiscounted Rate Permanent Phase [CORRESPONDENT.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? UndiscountedRate { get => _undiscountedRate; set => SetField(ref _undiscountedRate, value); }

        /// <summary>
        /// Correspondent Loan Status - Unpaid Principal Balance [4106]
        /// </summary>
        public decimal? UnpaidPrincipalBalance { get => _unpaidPrincipalBalance; set => SetField(ref _unpaidPrincipalBalance, value); }

        /// <summary>
        /// Correspondent Upfront MIP Rate [CORRESPONDENT.X349]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? UpfrontMipRate { get => _upfrontMipRate; set => SetField(ref _upfrontMipRate, value); }

        /// <summary>
        /// Correspondent Up Front Premium Amt [CORRESPONDENT.X350]
        /// </summary>
        public decimal? UpfrontPremiumAmount { get => _upfrontPremiumAmount; set => SetField(ref _upfrontPremiumAmount, value); }

        /// <summary>
        /// Correspondent USDA One Time Close [CORRESPONDENT.X445]
        /// </summary>
        public bool? UsdaOneTimeClose { get => _usdaOneTimeClose; set => SetField(ref _usdaOneTimeClose, value); }

        /// <summary>
        /// Correspondent VA Cash Out NTB Comparison Form Date [CORRESPONDENT.X352]
        /// </summary>
        public DateTime? VaCashOutNtbComparisonFormDate { get => _vaCashOutNtbComparisonFormDate; set => SetField(ref _vaCashOutNtbComparisonFormDate, value); }

        /// <summary>
        /// Correspondent VA Insured Date [CORRESPONDENT.X487]
        /// </summary>
        public DateTime? VaInsuredDate { get => _vaInsuredDate; set => SetField(ref _vaInsuredDate, value); }

        /// <summary>
        /// Correspondent Compliance Review - VA IRRRL Statutory P&amp;I Amount [CORRESPONDENT.X61]
        /// </summary>
        public decimal? VaIrrrlStatutoryPAndIAmount { get => _vaIrrrlStatutoryPAndIAmount; set => SetField(ref _vaIrrrlStatutoryPAndIAmount, value); }

        /// <summary>
        /// Correspondent Valuations
        /// </summary>
        [AllowNull]
        public IList<Valuation> Valuations { get => GetField(ref _valuations); set => SetField(ref _valuations, value); }

        /// <summary>
        /// Correspondent Value Used For Additional Insurance [CORRESPONDENT.X353]
        /// </summary>
        public decimal? ValueUsedForAdditionalInsurance { get => _valueUsedForAdditionalInsurance; set => SetField(ref _valueUsedForAdditionalInsurance, value); }

        /// <summary>
        /// Correspondent Value Used For Flood Insurance [CORRESPONDENT.X354]
        /// </summary>
        public decimal? ValueUsedForFloodInsurance { get => _valueUsedForFloodInsurance; set => SetField(ref _valueUsedForFloodInsurance, value); }

        /// <summary>
        /// Correspondent Value Used For Hazard Insurance [CORRESPONDENT.X355]
        /// </summary>
        public decimal? ValueUsedForHazardInsurance { get => _valueUsedForHazardInsurance; set => SetField(ref _valueUsedForHazardInsurance, value); }

        /// <summary>
        /// Correspondent Value Used For Wind/Hail Insurance [CORRESPONDENT.X356]
        /// </summary>
        public decimal? ValueUsedForWindHailInsurance { get => _valueUsedForWindHailInsurance; set => SetField(ref _valueUsedForWindHailInsurance, value); }

        /// <summary>
        /// Correspondent Loan Status - Voided Date [4208]
        /// </summary>
        public DateTime? VoidedDate { get => _voidedDate; set => SetField(ref _voidedDate, value); }

        /// <summary>
        /// Correspondent Wind/Hail Coverage Amount [CORRESPONDENT.X151]
        /// </summary>
        public decimal? WindHailCoverageAmount { get => _windHailCoverageAmount; set => SetField(ref _windHailCoverageAmount, value); }

        /// <summary>
        /// Undefined [CORRESPONDENT.X156]
        /// </summary>
        public int? WindHailCoverageTerm { get => _windHailCoverageTerm; set => SetField(ref _windHailCoverageTerm, value); }

        /// <summary>
        /// Correspondent Wind/Hail Deductible [CORRESPONDENT.X163]
        /// </summary>
        public decimal? WindHailDeductible { get => _windHailDeductible; set => SetField(ref _windHailDeductible, value); }

        /// <summary>
        /// Correspondent Wind/Hail Exclude from PITI Payment [CORRESPONDENT.X183]
        /// </summary>
        public bool? WindHailExcludePitiPayment { get => _windHailExcludePitiPayment; set => SetField(ref _windHailExcludePitiPayment, value); }

        /// <summary>
        /// Correspondent Wind/Hail Insurance Company Name [CORRESPONDENT.X224]
        /// </summary>
        public string? WindHailInsuranceCompanyName { get => _windHailInsuranceCompanyName; set => SetField(ref _windHailInsuranceCompanyName, value); }

        /// <summary>
        /// Correspondent Wind/Hail Insurance Estimator [CORRESPONDENT.X228]
        /// </summary>
        public string? WindHailInsuranceEstimator { get => _windHailInsuranceEstimator; set => SetField(ref _windHailInsuranceEstimator, value); }

        /// <summary>
        /// Correspondent Wind/Hail Insurance Guaranteed Replacement Cost [CORRESPONDENT.X206]
        /// </summary>
        public bool? WindHailInsuranceGuaranteedReplacementCost { get => _windHailInsuranceGuaranteedReplacementCost; set => SetField(ref _windHailInsuranceGuaranteedReplacementCost, value); }

        /// <summary>
        /// Correspondent Wind/Hail Payment Type [CORRESPONDENT.X465]
        /// </summary>
        public string? WindHailPaymentType { get => _windHailPaymentType; set => SetField(ref _windHailPaymentType, value); }

        /// <summary>
        /// Correspondent Wind/Hail Policy Effective Date [CORRESPONDENT.X281]
        /// </summary>
        public DateTime? WindHailPolicyEffectiveDate { get => _windHailPolicyEffectiveDate; set => SetField(ref _windHailPolicyEffectiveDate, value); }

        /// <summary>
        /// Correspondent Wind/Hail Policy Expiration Date [CORRESPONDENT.X284]
        /// </summary>
        public DateTime? WindHailPolicyExpirationDate { get => _windHailPolicyExpirationDate; set => SetField(ref _windHailPolicyExpirationDate, value); }

        /// <summary>
        /// Correspondent Wind/Hail Panel Number [CORRESPONDENT.X287]
        /// </summary>
        public string? WindHailPolicyNumber { get => _windHailPolicyNumber; set => SetField(ref _windHailPolicyNumber, value); }

        /// <summary>
        /// Correspondent Wind/Hail Policy Premium [CORRESPONDENT.X289]
        /// </summary>
        public decimal? WindHailPolicyPremium { get => _windHailPolicyPremium; set => SetField(ref _windHailPolicyPremium, value); }

        /// <summary>
        /// Correspondent WindHail Policy Type [CORRESPONDENT.X293]
        /// </summary>
        public string? WindHailPolicyType { get => _windHailPolicyType; set => SetField(ref _windHailPolicyType, value); }

        /// <summary>
        /// Correspondent Wind/Hail Premium Due Date [CORRESPONDENT.X298]
        /// </summary>
        public DateTime? WindHailPremiumDueDate { get => _windHailPremiumDueDate; set => SetField(ref _windHailPremiumDueDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Withdrawal Requested Date [4242]
        /// </summary>
        public DateTime? WithdrawalRequestedDate { get => _withdrawalRequestedDate; set => SetField(ref _withdrawalRequestedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Withdrawn Date [4120]
        /// </summary>
        public DateTime? WithdrawnDate { get => _withdrawnDate; set => SetField(ref _withdrawnDate, value); }

        /// <summary>
        /// Correspondent Year Built [CORRESPONDENT.X357]
        /// </summary>
        public string? YearBuilt { get => _yearBuilt; set => SetField(ref _yearBuilt, value); }

        /// <summary>
        /// Correspondent Zoning Compliance [CORRESPONDENT.X359]
        /// </summary>
        public string? ZoningCompliance { get => _zoningCompliance; set => SetField(ref _zoningCompliance, value); }
    }
}