using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Usda : IDirty
    {
        private DirtyValue<decimal?> _additionalIncomeFromPrimaryEmployment;
        public decimal? AdditionalIncomeFromPrimaryEmployment { get { return _additionalIncomeFromPrimaryEmployment; } set { _additionalIncomeFromPrimaryEmployment = value; } }
        private DirtyValue<decimal?> _additionalMemberBaseIncome;
        public decimal? AdditionalMemberBaseIncome { get { return _additionalMemberBaseIncome; } set { _additionalMemberBaseIncome = value; } }
        private DirtyValue<decimal?> _adjustedAnnualIncome;
        public decimal? AdjustedAnnualIncome { get { return _adjustedAnnualIncome; } set { _adjustedAnnualIncome = value; } }
        private DirtyValue<string> _adjustedIncomeCalculationDescription1;
        public string AdjustedIncomeCalculationDescription1 { get { return _adjustedIncomeCalculationDescription1; } set { _adjustedIncomeCalculationDescription1 = value; } }
        private DirtyValue<string> _adjustedIncomeCalculationDescription2;
        public string AdjustedIncomeCalculationDescription2 { get { return _adjustedIncomeCalculationDescription2; } set { _adjustedIncomeCalculationDescription2 = value; } }
        private DirtyValue<string> _adjustedIncomeCalculationDescription3;
        public string AdjustedIncomeCalculationDescription3 { get { return _adjustedIncomeCalculationDescription3; } set { _adjustedIncomeCalculationDescription3 = value; } }
        private DirtyValue<decimal?> _advanceAmountToDate;
        public decimal? AdvanceAmountToDate { get { return _advanceAmountToDate; } set { _advanceAmountToDate = value; } }
        private DirtyValue<decimal?> _amountLoanlineCredit;
        public decimal? AmountLoanlineCredit { get { return _amountLoanlineCredit; } set { _amountLoanlineCredit = value; } }
        private DirtyValue<decimal?> _annualChildCareExpenses;
        public decimal? AnnualChildCareExpenses { get { return _annualChildCareExpenses; } set { _annualChildCareExpenses = value; } }
        private DirtyValue<decimal?> _annualIncome;
        public decimal? AnnualIncome { get { return _annualIncome; } set { _annualIncome = value; } }
        private DirtyValue<string> _annualIncomeCalculationDescription1;
        public string AnnualIncomeCalculationDescription1 { get { return _annualIncomeCalculationDescription1; } set { _annualIncomeCalculationDescription1 = value; } }
        private DirtyValue<string> _annualIncomeCalculationDescription2;
        public string AnnualIncomeCalculationDescription2 { get { return _annualIncomeCalculationDescription2; } set { _annualIncomeCalculationDescription2 = value; } }
        private DirtyValue<string> _annualIncomeCalculationDescription3;
        public string AnnualIncomeCalculationDescription3 { get { return _annualIncomeCalculationDescription3; } set { _annualIncomeCalculationDescription3 = value; } }
        private DirtyValue<string> _annualIncomeCalculationDescription4;
        public string AnnualIncomeCalculationDescription4 { get { return _annualIncomeCalculationDescription4; } set { _annualIncomeCalculationDescription4 = value; } }
        private DirtyValue<string> _annualIncomeCalculationDescription5;
        public string AnnualIncomeCalculationDescription5 { get { return _annualIncomeCalculationDescription5; } set { _annualIncomeCalculationDescription5 = value; } }
        private DirtyValue<DateTime?> _annualReviewDate;
        public DateTime? AnnualReviewDate { get { return _annualReviewDate; } set { _annualReviewDate = value; } }
        private DirtyValue<string> _applicationNumber;
        public string ApplicationNumber { get { return _applicationNumber; } set { _applicationNumber = value; } }
        private DirtyValue<string> _approvedLenderTaxId;
        public string ApprovedLenderTaxId { get { return _approvedLenderTaxId; } set { _approvedLenderTaxId = value; } }
        private DirtyValue<decimal?> _assetIncome;
        public decimal? AssetIncome { get { return _assetIncome; } set { _assetIncome = value; } }
        private DirtyValue<decimal?> _balanceOwedOnLoan;
        public decimal? BalanceOwedOnLoan { get { return _balanceOwedOnLoan; } set { _balanceOwedOnLoan = value; } }
        private DirtyValue<decimal?> _borrowerBaseIncome;
        public decimal? BorrowerBaseIncome { get { return _borrowerBaseIncome; } set { _borrowerBaseIncome = value; } }
        private DirtyValue<decimal?> _borrowerTotalStableIncome;
        public decimal? BorrowerTotalStableIncome { get { return _borrowerTotalStableIncome; } set { _borrowerTotalStableIncome = value; } }
        private StringEnumValue<BorrowerTypeCode> _borrowerTypeCode;
        public StringEnumValue<BorrowerTypeCode> BorrowerTypeCode { get { return _borrowerTypeCode; } set { _borrowerTypeCode = value; } }
        private DirtyValue<decimal?> _buydownInterestAssistanceRate;
        public decimal? BuydownInterestAssistanceRate { get { return _buydownInterestAssistanceRate; } set { _buydownInterestAssistanceRate = value; } }
        private DirtyValue<string> _caseNumberBorrowerId;
        public string CaseNumberBorrowerId { get { return _caseNumberBorrowerId; } set { _caseNumberBorrowerId = value; } }
        private DirtyValue<string> _caseNumberCo;
        public string CaseNumberCo { get { return _caseNumberCo; } set { _caseNumberCo = value; } }
        private DirtyValue<string> _caseNumberSt;
        public string CaseNumberSt { get { return _caseNumberSt; } set { _caseNumberSt = value; } }
        private DirtyValue<DateTime?> _certificationEffectiveDate;
        public DateTime? CertificationEffectiveDate { get { return _certificationEffectiveDate; } set { _certificationEffectiveDate = value; } }
        private DirtyValue<DateTime?> _certificationExpirationDate;
        public DateTime? CertificationExpirationDate { get { return _certificationExpirationDate; } set { _certificationExpirationDate = value; } }
        private DirtyValue<bool?> _certifiedLoanIndicator;
        public bool? CertifiedLoanIndicator { get { return _certifiedLoanIndicator; } set { _certifiedLoanIndicator = value; } }
        private DirtyValue<string> _childCareProviderAddress;
        public string ChildCareProviderAddress { get { return _childCareProviderAddress; } set { _childCareProviderAddress = value; } }
        private DirtyValue<string> _childCareProviderCity;
        public string ChildCareProviderCity { get { return _childCareProviderCity; } set { _childCareProviderCity = value; } }
        private DirtyValue<string> _childCareProviderPhone;
        public string ChildCareProviderPhone { get { return _childCareProviderPhone; } set { _childCareProviderPhone = value; } }
        private DirtyValue<string> _childCareProviderProviderName;
        public string ChildCareProviderProviderName { get { return _childCareProviderProviderName; } set { _childCareProviderProviderName = value; } }
        private DirtyValue<string> _childCareProviderState;
        public string ChildCareProviderState { get { return _childCareProviderState; } set { _childCareProviderState = value; } }
        private DirtyValue<string> _childCareProviderZip;
        public string ChildCareProviderZip { get { return _childCareProviderZip; } set { _childCareProviderZip = value; } }
        private DirtyValue<decimal?> _childCostPerMonth;
        public decimal? ChildCostPerMonth { get { return _childCostPerMonth; } set { _childCostPerMonth = value; } }
        private DirtyValue<decimal?> _childCostPerWeek;
        public decimal? ChildCostPerWeek { get { return _childCostPerWeek; } set { _childCostPerWeek = value; } }
        private DirtyValue<decimal?> _coborrowerBaseIncome;
        public decimal? CoborrowerBaseIncome { get { return _coborrowerBaseIncome; } set { _coborrowerBaseIncome = value; } }
        private DirtyValue<decimal?> _coborrowerStableBaseIncome;
        public decimal? CoborrowerStableBaseIncome { get { return _coborrowerStableBaseIncome; } set { _coborrowerStableBaseIncome = value; } }
        private DirtyValue<string> _coborrowerStableBaseIncomeDesc;
        public string CoborrowerStableBaseIncomeDesc { get { return _coborrowerStableBaseIncomeDesc; } set { _coborrowerStableBaseIncomeDesc = value; } }
        private DirtyValue<decimal?> _coborrowerStableOtherIncome;
        public decimal? CoborrowerStableOtherIncome { get { return _coborrowerStableOtherIncome; } set { _coborrowerStableOtherIncome = value; } }
        private DirtyValue<string> _coborrowerStableOtherIncomeDesc;
        public string CoborrowerStableOtherIncomeDesc { get { return _coborrowerStableOtherIncomeDesc; } set { _coborrowerStableOtherIncomeDesc = value; } }
        private DirtyValue<decimal?> _coBorrowerTotalStableIncome;
        public decimal? CoBorrowerTotalStableIncome { get { return _coBorrowerTotalStableIncome; } set { _coBorrowerTotalStableIncome = value; } }
        private DirtyValue<DateTime?> _dateConfirmedObligationProcessed;
        public DateTime? DateConfirmedObligationProcessed { get { return _dateConfirmedObligationProcessed; } set { _dateConfirmedObligationProcessed = value; } }
        private DirtyValue<DateTime?> _dateLoanNoteGuaranteeIssued;
        public DateTime? DateLoanNoteGuaranteeIssued { get { return _dateLoanNoteGuaranteeIssued; } set { _dateLoanNoteGuaranteeIssued = value; } }
        private DirtyValue<DateTime?> _dateLoanNoteGuaranteeRequestReceived;
        public DateTime? DateLoanNoteGuaranteeRequestReceived { get { return _dateLoanNoteGuaranteeRequestReceived; } set { _dateLoanNoteGuaranteeRequestReceived = value; } }
        private DirtyValue<DateTime?> _dateObligationInGls;
        public DateTime? DateObligationInGls { get { return _dateObligationInGls; } set { _dateObligationInGls = value; } }
        private DirtyValue<DateTime?> _dateVerifiedInUnifi;
        public DateTime? DateVerifiedInUnifi { get { return _dateVerifiedInUnifi; } set { _dateVerifiedInUnifi = value; } }
        private DirtyValue<decimal?> _dependentDeduction;
        public decimal? DependentDeduction { get { return _dependentDeduction; } set { _dependentDeduction = value; } }
        private DirtyValue<decimal?> _disabilityDeduction;
        public decimal? DisabilityDeduction { get { return _disabilityDeduction; } set { _disabilityDeduction = value; } }
        private DirtyValue<decimal?> _elderlyHouseholdDeduction;
        public decimal? ElderlyHouseholdDeduction { get { return _elderlyHouseholdDeduction; } set { _elderlyHouseholdDeduction = value; } }
        private DirtyValue<decimal?> _feeRate;
        public decimal? FeeRate { get { return _feeRate; } set { _feeRate = value; } }
        private DirtyValue<string> _financedLoanClosingCostDescription;
        public string FinancedLoanClosingCostDescription { get { return _financedLoanClosingCostDescription; } set { _financedLoanClosingCostDescription = value; } }
        private DirtyValue<decimal?> _guaranteeFeeCollected;
        public decimal? GuaranteeFeeCollected { get { return _guaranteeFeeCollected; } set { _guaranteeFeeCollected = value; } }
        private DirtyValue<decimal?> _guaranteeFeeOnCommitment;
        public decimal? GuaranteeFeeOnCommitment { get { return _guaranteeFeeOnCommitment; } set { _guaranteeFeeOnCommitment = value; } }
        private StringEnumValue<GuaranteeFeePurposeCodeType> _guaranteeFeePurposeCodeType;
        public StringEnumValue<GuaranteeFeePurposeCodeType> GuaranteeFeePurposeCodeType { get { return _guaranteeFeePurposeCodeType; } set { _guaranteeFeePurposeCodeType = value; } }
        private DirtyValue<DateTime?> _guaranteePeriodBeginsDate;
        public DateTime? GuaranteePeriodBeginsDate { get { return _guaranteePeriodBeginsDate; } set { _guaranteePeriodBeginsDate = value; } }
        private DirtyValue<DateTime?> _guaranteePeriodEndsDate;
        public DateTime? GuaranteePeriodEndsDate { get { return _guaranteePeriodEndsDate; } set { _guaranteePeriodEndsDate = value; } }
        private StringEnumValue<GuaranteeType> _guaranteeType;
        public StringEnumValue<GuaranteeType> GuaranteeType { get { return _guaranteeType; } set { _guaranteeType = value; } }
        private DirtyValue<int?> _householdSize;
        public int? HouseholdSize { get { return _householdSize; } set { _householdSize = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private StringEnumValue<InterestAssistanceCodeType> _interestAssistanceCodeType;
        public StringEnumValue<InterestAssistanceCodeType> InterestAssistanceCodeType { get { return _interestAssistanceCodeType; } set { _interestAssistanceCodeType = value; } }
        private DirtyValue<bool?> _interestRateBasedonFannieIndicator;
        public bool? InterestRateBasedonFannieIndicator { get { return _interestRateBasedonFannieIndicator; } set { _interestRateBasedonFannieIndicator = value; } }
        private StringEnumValue<InterestRateCodeType> _interestRateCodeType;
        public StringEnumValue<InterestRateCodeType> InterestRateCodeType { get { return _interestRateCodeType; } set { _interestRateCodeType = value; } }
        private DirtyValue<bool?> _interestRateFloatToLoanClosingIndicator;
        public bool? InterestRateFloatToLoanClosingIndicator { get { return _interestRateFloatToLoanClosingIndicator; } set { _interestRateFloatToLoanClosingIndicator = value; } }
        private DirtyValue<bool?> _lackAdequateHeatIndicator;
        public bool? LackAdequateHeatIndicator { get { return _lackAdequateHeatIndicator; } set { _lackAdequateHeatIndicator = value; } }
        private DirtyValue<string> _lenderAuthorizedRepCompany;
        public string LenderAuthorizedRepCompany { get { return _lenderAuthorizedRepCompany; } set { _lenderAuthorizedRepCompany = value; } }
        private DirtyValue<string> _lenderAuthorizedRepName;
        public string LenderAuthorizedRepName { get { return _lenderAuthorizedRepName; } set { _lenderAuthorizedRepName = value; } }
        private DirtyValue<string> _lenderAuthorizedRepTitle;
        public string LenderAuthorizedRepTitle { get { return _lenderAuthorizedRepTitle; } set { _lenderAuthorizedRepTitle = value; } }
        private DirtyValue<string> _lenderIdNo;
        public string LenderIdNo { get { return _lenderIdNo; } set { _lenderIdNo = value; } }
        private DirtyValue<decimal?> _lenderNoteRateOnGuaranteedPortion;
        public decimal? LenderNoteRateOnGuaranteedPortion { get { return _lenderNoteRateOnGuaranteedPortion; } set { _lenderNoteRateOnGuaranteedPortion = value; } }
        private DirtyValue<decimal?> _lenderNoteRateOnNonGuaranteedPortion;
        public decimal? LenderNoteRateOnNonGuaranteedPortion { get { return _lenderNoteRateOnNonGuaranteedPortion; } set { _lenderNoteRateOnNonGuaranteedPortion = value; } }
        private StringEnumValue<LenderStatusCodeType> _lenderStatusCodeType;
        public StringEnumValue<LenderStatusCodeType> LenderStatusCodeType { get { return _lenderStatusCodeType; } set { _lenderStatusCodeType = value; } }
        private StringEnumValue<LenderTypeCode> _lenderTypeCode;
        public StringEnumValue<LenderTypeCode> LenderTypeCode { get { return _lenderTypeCode; } set { _lenderTypeCode = value; } }
        private StringEnumValue<UsdaLoanType> _loanType;
        public StringEnumValue<UsdaLoanType> LoanType { get { return _loanType; } set { _loanType = value; } }
        private DirtyValue<bool?> _lockCompletePlumbingIndicator;
        public bool? LockCompletePlumbingIndicator { get { return _lockCompletePlumbingIndicator; } set { _lockCompletePlumbingIndicator = value; } }
        private DirtyValue<decimal?> _medicalExpenses;
        public decimal? MedicalExpenses { get { return _medicalExpenses; } set { _medicalExpenses = value; } }
        private DirtyValue<decimal?> _moderateIncomeLimit;
        public decimal? ModerateIncomeLimit { get { return _moderateIncomeLimit; } set { _moderateIncomeLimit = value; } }
        private DirtyValue<decimal?> _monthlyRepaymentIncome;
        public decimal? MonthlyRepaymentIncome { get { return _monthlyRepaymentIncome; } set { _monthlyRepaymentIncome = value; } }
        private DirtyValue<int?> _numberofDependents;
        public int? NumberofDependents { get { return _numberofDependents; } set { _numberofDependents = value; } }
        private DirtyValue<int?> _numberofPeopleInHousehold;
        public int? NumberofPeopleInHousehold { get { return _numberofPeopleInHousehold; } set { _numberofPeopleInHousehold = value; } }
        private DirtyValue<bool?> _obligationMatchesCommitmentLenderRequestIndicator;
        public bool? ObligationMatchesCommitmentLenderRequestIndicator { get { return _obligationMatchesCommitmentLenderRequestIndicator; } set { _obligationMatchesCommitmentLenderRequestIndicator = value; } }
        private DirtyValue<string> _officialWhoConfirmedGlsUpdated;
        public string OfficialWhoConfirmedGlsUpdated { get { return _officialWhoConfirmedGlsUpdated; } set { _officialWhoConfirmedGlsUpdated = value; } }
        private DirtyValue<decimal?> _otherIncome;
        public decimal? OtherIncome { get { return _otherIncome; } set { _otherIncome = value; } }
        private DirtyValue<decimal?> _otherStableDependableMonthlyIncome;
        public decimal? OtherStableDependableMonthlyIncome { get { return _otherStableDependableMonthlyIncome; } set { _otherStableDependableMonthlyIncome = value; } }
        private DirtyValue<bool?> _overcrowdedIndicator;
        public bool? OvercrowdedIndicator { get { return _overcrowdedIndicator; } set { _overcrowdedIndicator = value; } }
        private DirtyValue<decimal?> _percentofLoanGuaranteed;
        public decimal? PercentofLoanGuaranteed { get { return _percentofLoanGuaranteed; } set { _percentofLoanGuaranteed = value; } }
        private StringEnumValue<PeriodOperatingLineCreditYearsType> _periodOperatingLineCreditYearsType;
        public StringEnumValue<PeriodOperatingLineCreditYearsType> PeriodOperatingLineCreditYearsType { get { return _periodOperatingLineCreditYearsType; } set { _periodOperatingLineCreditYearsType = value; } }
        private DirtyValue<bool?> _physicallyDeterioratedIndicator;
        public bool? PhysicallyDeterioratedIndicator { get { return _physicallyDeterioratedIndicator; } set { _physicallyDeterioratedIndicator = value; } }
        private DirtyValue<string> _preparedByName;
        public string PreparedByName { get { return _preparedByName; } set { _preparedByName = value; } }
        private DirtyValue<string> _preparedByTitle;
        public string PreparedByTitle { get { return _preparedByTitle; } set { _preparedByTitle = value; } }
        private DirtyValue<string> _presentLandloardAddress;
        public string PresentLandloardAddress { get { return _presentLandloardAddress; } set { _presentLandloardAddress = value; } }
        private DirtyValue<string> _presentLandloardCity;
        public string PresentLandloardCity { get { return _presentLandloardCity; } set { _presentLandloardCity = value; } }
        private DirtyValue<string> _presentLandloardName;
        public string PresentLandloardName { get { return _presentLandloardName; } set { _presentLandloardName = value; } }
        private DirtyValue<string> _presentLandloardPhone;
        public string PresentLandloardPhone { get { return _presentLandloardPhone; } set { _presentLandloardPhone = value; } }
        private DirtyValue<string> _presentLandloardState;
        public string PresentLandloardState { get { return _presentLandloardState; } set { _presentLandloardState = value; } }
        private DirtyValue<string> _presentLandloardZip;
        public string PresentLandloardZip { get { return _presentLandloardZip; } set { _presentLandloardZip = value; } }
        private DirtyValue<string> _previousLandloardAddress;
        public string PreviousLandloardAddress { get { return _previousLandloardAddress; } set { _previousLandloardAddress = value; } }
        private DirtyValue<string> _previousLandloardCity;
        public string PreviousLandloardCity { get { return _previousLandloardCity; } set { _previousLandloardCity = value; } }
        private DirtyValue<string> _previousLandloardName;
        public string PreviousLandloardName { get { return _previousLandloardName; } set { _previousLandloardName = value; } }
        private DirtyValue<string> _previousLandloardPhone;
        public string PreviousLandloardPhone { get { return _previousLandloardPhone; } set { _previousLandloardPhone = value; } }
        private DirtyValue<string> _previousLandloardState;
        public string PreviousLandloardState { get { return _previousLandloardState; } set { _previousLandloardState = value; } }
        private DirtyValue<string> _previousLandloardZip;
        public string PreviousLandloardZip { get { return _previousLandloardZip; } set { _previousLandloardZip = value; } }
        private DirtyValue<decimal?> _purchaseOrRefinancedAmount;
        public decimal? PurchaseOrRefinancedAmount { get { return _purchaseOrRefinancedAmount; } set { _purchaseOrRefinancedAmount = value; } }
        private DirtyValue<string> _purchaseOrRefinanceDescription;
        public string PurchaseOrRefinanceDescription { get { return _purchaseOrRefinanceDescription; } set { _purchaseOrRefinanceDescription = value; } }
        private StringEnumValue<RdsfhRefinancedLoanIndicatorType> _rdsfhRefinancedLoanIndicatorType;
        public StringEnumValue<RdsfhRefinancedLoanIndicatorType> RdsfhRefinancedLoanIndicatorType { get { return _rdsfhRefinancedLoanIndicatorType; } set { _rdsfhRefinancedLoanIndicatorType = value; } }
        private DirtyValue<bool?> _refinanceLoanIndicator;
        public bool? RefinanceLoanIndicator { get { return _refinanceLoanIndicator; } set { _refinanceLoanIndicator = value; } }
        private DirtyValue<decimal?> _repairOtherAmount;
        public decimal? RepairOtherAmount { get { return _repairOtherAmount; } set { _repairOtherAmount = value; } }
        private DirtyValue<string> _repairOtherDescription;
        public string RepairOtherDescription { get { return _repairOtherDescription; } set { _repairOtherDescription = value; } }
        private DirtyValue<decimal?> _reservationAmountRequested;
        public decimal? ReservationAmountRequested { get { return _reservationAmountRequested; } set { _reservationAmountRequested = value; } }
        private DirtyValue<string> _reserved;
        public string Reserved { get { return _reserved; } set { _reserved = value; } }
        private DirtyValue<string> _servicingOfficeName;
        public string ServicingOfficeName { get { return _servicingOfficeName; } set { _servicingOfficeName = value; } }
        private DirtyValue<bool?> _sfhglpIndicator;
        public bool? SfhglpIndicator { get { return _sfhglpIndicator; } set { _sfhglpIndicator = value; } }
        private StringEnumValue<SourceOfFundsType> _sourceOfFundsType;
        public StringEnumValue<SourceOfFundsType> SourceOfFundsType { get { return _sourceOfFundsType; } set { _sourceOfFundsType = value; } }
        private DirtyValue<decimal?> _stableDependableMonthlyIncome;
        public decimal? StableDependableMonthlyIncome { get { return _stableDependableMonthlyIncome; } set { _stableDependableMonthlyIncome = value; } }
        private DirtyValue<string> _stableOtherIncomeDesc;
        public string StableOtherIncomeDesc { get { return _stableOtherIncomeDesc; } set { _stableOtherIncomeDesc = value; } }
        private DirtyValue<string> _submittingLenderAddress;
        public string SubmittingLenderAddress { get { return _submittingLenderAddress; } set { _submittingLenderAddress = value; } }
        private DirtyValue<string> _submittingLenderCity;
        public string SubmittingLenderCity { get { return _submittingLenderCity; } set { _submittingLenderCity = value; } }
        private DirtyValue<string> _submittingLenderContactFax;
        public string SubmittingLenderContactFax { get { return _submittingLenderContactFax; } set { _submittingLenderContactFax = value; } }
        private DirtyValue<string> _submittingLenderContactName;
        public string SubmittingLenderContactName { get { return _submittingLenderContactName; } set { _submittingLenderContactName = value; } }
        private DirtyValue<string> _submittingLenderContactPhone;
        public string SubmittingLenderContactPhone { get { return _submittingLenderContactPhone; } set { _submittingLenderContactPhone = value; } }
        private DirtyValue<string> _submittingLenderName;
        public string SubmittingLenderName { get { return _submittingLenderName; } set { _submittingLenderName = value; } }
        private DirtyValue<string> _submittingLenderState;
        public string SubmittingLenderState { get { return _submittingLenderState; } set { _submittingLenderState = value; } }
        private DirtyValue<string> _submittingLenderTaxId;
        public string SubmittingLenderTaxId { get { return _submittingLenderTaxId; } set { _submittingLenderTaxId = value; } }
        private DirtyValue<string> _submittingLenderZip;
        public string SubmittingLenderZip { get { return _submittingLenderZip; } set { _submittingLenderZip = value; } }
        private DirtyValue<int?> _termOfBuydown;
        public int? TermOfBuydown { get { return _termOfBuydown; } set { _termOfBuydown = value; } }
        private DirtyValue<string> _thirdPartyOriginator;
        public string ThirdPartyOriginator { get { return _thirdPartyOriginator; } set { _thirdPartyOriginator = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyValue<decimal?> _totalBorrowerStableBaseIncome;
        public decimal? TotalBorrowerStableBaseIncome { get { return _totalBorrowerStableBaseIncome; } set { _totalBorrowerStableBaseIncome = value; } }
        private DirtyValue<decimal?> _totalBorrowerStableOtherIncome;
        public decimal? TotalBorrowerStableOtherIncome { get { return _totalBorrowerStableOtherIncome; } set { _totalBorrowerStableOtherIncome = value; } }
        private DirtyValue<decimal?> _totalHouseholdDeduction;
        public decimal? TotalHouseholdDeduction { get { return _totalHouseholdDeduction; } set { _totalHouseholdDeduction = value; } }
        private DirtyValue<decimal?> _totalRequestAmount;
        public decimal? TotalRequestAmount { get { return _totalRequestAmount; } set { _totalRequestAmount = value; } }
        private DirtyValue<string> _tpoTaxId;
        public string TpoTaxId { get { return _tpoTaxId; } set { _tpoTaxId = value; } }
        private DirtyValue<string> _underwritingDecisionBy;
        public string UnderwritingDecisionBy { get { return _underwritingDecisionBy; } set { _underwritingDecisionBy = value; } }
        private DirtyValue<DateTime?> _underwritingDecisionDate;
        public DateTime? UnderwritingDecisionDate { get { return _underwritingDecisionDate; } set { _underwritingDecisionDate = value; } }
        private StringEnumValue<UnderwritingDecisionType> _underwritingDecisionType;
        public StringEnumValue<UnderwritingDecisionType> UnderwritingDecisionType { get { return _underwritingDecisionType; } set { _underwritingDecisionType = value; } }
        private DirtyList<UsdaHouseholdIncome> _usdaHouseholdIncomes;
        public IList<UsdaHouseholdIncome> UsdaHouseholdIncomes { get { return _usdaHouseholdIncomes ?? (_usdaHouseholdIncomes = new DirtyList<UsdaHouseholdIncome>()); } set { _usdaHouseholdIncomes = new DirtyList<UsdaHouseholdIncome>(value); } }
        private DirtyValue<string> _verificationCode;
        public string VerificationCode { get { return _verificationCode; } set { _verificationCode = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _additionalIncomeFromPrimaryEmployment.Dirty
                    || _additionalMemberBaseIncome.Dirty
                    || _adjustedAnnualIncome.Dirty
                    || _adjustedIncomeCalculationDescription1.Dirty
                    || _adjustedIncomeCalculationDescription2.Dirty
                    || _adjustedIncomeCalculationDescription3.Dirty
                    || _advanceAmountToDate.Dirty
                    || _amountLoanlineCredit.Dirty
                    || _annualChildCareExpenses.Dirty
                    || _annualIncome.Dirty
                    || _annualIncomeCalculationDescription1.Dirty
                    || _annualIncomeCalculationDescription2.Dirty
                    || _annualIncomeCalculationDescription3.Dirty
                    || _annualIncomeCalculationDescription4.Dirty
                    || _annualIncomeCalculationDescription5.Dirty
                    || _annualReviewDate.Dirty
                    || _applicationNumber.Dirty
                    || _approvedLenderTaxId.Dirty
                    || _assetIncome.Dirty
                    || _balanceOwedOnLoan.Dirty
                    || _borrowerBaseIncome.Dirty
                    || _borrowerTotalStableIncome.Dirty
                    || _borrowerTypeCode.Dirty
                    || _buydownInterestAssistanceRate.Dirty
                    || _caseNumberBorrowerId.Dirty
                    || _caseNumberCo.Dirty
                    || _caseNumberSt.Dirty
                    || _certificationEffectiveDate.Dirty
                    || _certificationExpirationDate.Dirty
                    || _certifiedLoanIndicator.Dirty
                    || _childCareProviderAddress.Dirty
                    || _childCareProviderCity.Dirty
                    || _childCareProviderPhone.Dirty
                    || _childCareProviderProviderName.Dirty
                    || _childCareProviderState.Dirty
                    || _childCareProviderZip.Dirty
                    || _childCostPerMonth.Dirty
                    || _childCostPerWeek.Dirty
                    || _coborrowerBaseIncome.Dirty
                    || _coborrowerStableBaseIncome.Dirty
                    || _coborrowerStableBaseIncomeDesc.Dirty
                    || _coborrowerStableOtherIncome.Dirty
                    || _coborrowerStableOtherIncomeDesc.Dirty
                    || _coBorrowerTotalStableIncome.Dirty
                    || _dateConfirmedObligationProcessed.Dirty
                    || _dateLoanNoteGuaranteeIssued.Dirty
                    || _dateLoanNoteGuaranteeRequestReceived.Dirty
                    || _dateObligationInGls.Dirty
                    || _dateVerifiedInUnifi.Dirty
                    || _dependentDeduction.Dirty
                    || _disabilityDeduction.Dirty
                    || _elderlyHouseholdDeduction.Dirty
                    || _feeRate.Dirty
                    || _financedLoanClosingCostDescription.Dirty
                    || _guaranteeFeeCollected.Dirty
                    || _guaranteeFeeOnCommitment.Dirty
                    || _guaranteeFeePurposeCodeType.Dirty
                    || _guaranteePeriodBeginsDate.Dirty
                    || _guaranteePeriodEndsDate.Dirty
                    || _guaranteeType.Dirty
                    || _householdSize.Dirty
                    || _id.Dirty
                    || _interestAssistanceCodeType.Dirty
                    || _interestRateBasedonFannieIndicator.Dirty
                    || _interestRateCodeType.Dirty
                    || _interestRateFloatToLoanClosingIndicator.Dirty
                    || _lackAdequateHeatIndicator.Dirty
                    || _lenderAuthorizedRepCompany.Dirty
                    || _lenderAuthorizedRepName.Dirty
                    || _lenderAuthorizedRepTitle.Dirty
                    || _lenderIdNo.Dirty
                    || _lenderNoteRateOnGuaranteedPortion.Dirty
                    || _lenderNoteRateOnNonGuaranteedPortion.Dirty
                    || _lenderStatusCodeType.Dirty
                    || _lenderTypeCode.Dirty
                    || _loanType.Dirty
                    || _lockCompletePlumbingIndicator.Dirty
                    || _medicalExpenses.Dirty
                    || _moderateIncomeLimit.Dirty
                    || _monthlyRepaymentIncome.Dirty
                    || _numberofDependents.Dirty
                    || _numberofPeopleInHousehold.Dirty
                    || _obligationMatchesCommitmentLenderRequestIndicator.Dirty
                    || _officialWhoConfirmedGlsUpdated.Dirty
                    || _otherIncome.Dirty
                    || _otherStableDependableMonthlyIncome.Dirty
                    || _overcrowdedIndicator.Dirty
                    || _percentofLoanGuaranteed.Dirty
                    || _periodOperatingLineCreditYearsType.Dirty
                    || _physicallyDeterioratedIndicator.Dirty
                    || _preparedByName.Dirty
                    || _preparedByTitle.Dirty
                    || _presentLandloardAddress.Dirty
                    || _presentLandloardCity.Dirty
                    || _presentLandloardName.Dirty
                    || _presentLandloardPhone.Dirty
                    || _presentLandloardState.Dirty
                    || _presentLandloardZip.Dirty
                    || _previousLandloardAddress.Dirty
                    || _previousLandloardCity.Dirty
                    || _previousLandloardName.Dirty
                    || _previousLandloardPhone.Dirty
                    || _previousLandloardState.Dirty
                    || _previousLandloardZip.Dirty
                    || _purchaseOrRefinancedAmount.Dirty
                    || _purchaseOrRefinanceDescription.Dirty
                    || _rdsfhRefinancedLoanIndicatorType.Dirty
                    || _refinanceLoanIndicator.Dirty
                    || _repairOtherAmount.Dirty
                    || _repairOtherDescription.Dirty
                    || _reservationAmountRequested.Dirty
                    || _reserved.Dirty
                    || _servicingOfficeName.Dirty
                    || _sfhglpIndicator.Dirty
                    || _sourceOfFundsType.Dirty
                    || _stableDependableMonthlyIncome.Dirty
                    || _stableOtherIncomeDesc.Dirty
                    || _submittingLenderAddress.Dirty
                    || _submittingLenderCity.Dirty
                    || _submittingLenderContactFax.Dirty
                    || _submittingLenderContactName.Dirty
                    || _submittingLenderContactPhone.Dirty
                    || _submittingLenderName.Dirty
                    || _submittingLenderState.Dirty
                    || _submittingLenderTaxId.Dirty
                    || _submittingLenderZip.Dirty
                    || _termOfBuydown.Dirty
                    || _thirdPartyOriginator.Dirty
                    || _title.Dirty
                    || _totalBorrowerStableBaseIncome.Dirty
                    || _totalBorrowerStableOtherIncome.Dirty
                    || _totalHouseholdDeduction.Dirty
                    || _totalRequestAmount.Dirty
                    || _tpoTaxId.Dirty
                    || _underwritingDecisionBy.Dirty
                    || _underwritingDecisionDate.Dirty
                    || _underwritingDecisionType.Dirty
                    || _verificationCode.Dirty
                    || _usdaHouseholdIncomes?.Dirty == true
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _additionalIncomeFromPrimaryEmployment.Dirty = value;
                _additionalMemberBaseIncome.Dirty = value;
                _adjustedAnnualIncome.Dirty = value;
                _adjustedIncomeCalculationDescription1.Dirty = value;
                _adjustedIncomeCalculationDescription2.Dirty = value;
                _adjustedIncomeCalculationDescription3.Dirty = value;
                _advanceAmountToDate.Dirty = value;
                _amountLoanlineCredit.Dirty = value;
                _annualChildCareExpenses.Dirty = value;
                _annualIncome.Dirty = value;
                _annualIncomeCalculationDescription1.Dirty = value;
                _annualIncomeCalculationDescription2.Dirty = value;
                _annualIncomeCalculationDescription3.Dirty = value;
                _annualIncomeCalculationDescription4.Dirty = value;
                _annualIncomeCalculationDescription5.Dirty = value;
                _annualReviewDate.Dirty = value;
                _applicationNumber.Dirty = value;
                _approvedLenderTaxId.Dirty = value;
                _assetIncome.Dirty = value;
                _balanceOwedOnLoan.Dirty = value;
                _borrowerBaseIncome.Dirty = value;
                _borrowerTotalStableIncome.Dirty = value;
                _borrowerTypeCode.Dirty = value;
                _buydownInterestAssistanceRate.Dirty = value;
                _caseNumberBorrowerId.Dirty = value;
                _caseNumberCo.Dirty = value;
                _caseNumberSt.Dirty = value;
                _certificationEffectiveDate.Dirty = value;
                _certificationExpirationDate.Dirty = value;
                _certifiedLoanIndicator.Dirty = value;
                _childCareProviderAddress.Dirty = value;
                _childCareProviderCity.Dirty = value;
                _childCareProviderPhone.Dirty = value;
                _childCareProviderProviderName.Dirty = value;
                _childCareProviderState.Dirty = value;
                _childCareProviderZip.Dirty = value;
                _childCostPerMonth.Dirty = value;
                _childCostPerWeek.Dirty = value;
                _coborrowerBaseIncome.Dirty = value;
                _coborrowerStableBaseIncome.Dirty = value;
                _coborrowerStableBaseIncomeDesc.Dirty = value;
                _coborrowerStableOtherIncome.Dirty = value;
                _coborrowerStableOtherIncomeDesc.Dirty = value;
                _coBorrowerTotalStableIncome.Dirty = value;
                _dateConfirmedObligationProcessed.Dirty = value;
                _dateLoanNoteGuaranteeIssued.Dirty = value;
                _dateLoanNoteGuaranteeRequestReceived.Dirty = value;
                _dateObligationInGls.Dirty = value;
                _dateVerifiedInUnifi.Dirty = value;
                _dependentDeduction.Dirty = value;
                _disabilityDeduction.Dirty = value;
                _elderlyHouseholdDeduction.Dirty = value;
                _feeRate.Dirty = value;
                _financedLoanClosingCostDescription.Dirty = value;
                _guaranteeFeeCollected.Dirty = value;
                _guaranteeFeeOnCommitment.Dirty = value;
                _guaranteeFeePurposeCodeType.Dirty = value;
                _guaranteePeriodBeginsDate.Dirty = value;
                _guaranteePeriodEndsDate.Dirty = value;
                _guaranteeType.Dirty = value;
                _householdSize.Dirty = value;
                _id.Dirty = value;
                _interestAssistanceCodeType.Dirty = value;
                _interestRateBasedonFannieIndicator.Dirty = value;
                _interestRateCodeType.Dirty = value;
                _interestRateFloatToLoanClosingIndicator.Dirty = value;
                _lackAdequateHeatIndicator.Dirty = value;
                _lenderAuthorizedRepCompany.Dirty = value;
                _lenderAuthorizedRepName.Dirty = value;
                _lenderAuthorizedRepTitle.Dirty = value;
                _lenderIdNo.Dirty = value;
                _lenderNoteRateOnGuaranteedPortion.Dirty = value;
                _lenderNoteRateOnNonGuaranteedPortion.Dirty = value;
                _lenderStatusCodeType.Dirty = value;
                _lenderTypeCode.Dirty = value;
                _loanType.Dirty = value;
                _lockCompletePlumbingIndicator.Dirty = value;
                _medicalExpenses.Dirty = value;
                _moderateIncomeLimit.Dirty = value;
                _monthlyRepaymentIncome.Dirty = value;
                _numberofDependents.Dirty = value;
                _numberofPeopleInHousehold.Dirty = value;
                _obligationMatchesCommitmentLenderRequestIndicator.Dirty = value;
                _officialWhoConfirmedGlsUpdated.Dirty = value;
                _otherIncome.Dirty = value;
                _otherStableDependableMonthlyIncome.Dirty = value;
                _overcrowdedIndicator.Dirty = value;
                _percentofLoanGuaranteed.Dirty = value;
                _periodOperatingLineCreditYearsType.Dirty = value;
                _physicallyDeterioratedIndicator.Dirty = value;
                _preparedByName.Dirty = value;
                _preparedByTitle.Dirty = value;
                _presentLandloardAddress.Dirty = value;
                _presentLandloardCity.Dirty = value;
                _presentLandloardName.Dirty = value;
                _presentLandloardPhone.Dirty = value;
                _presentLandloardState.Dirty = value;
                _presentLandloardZip.Dirty = value;
                _previousLandloardAddress.Dirty = value;
                _previousLandloardCity.Dirty = value;
                _previousLandloardName.Dirty = value;
                _previousLandloardPhone.Dirty = value;
                _previousLandloardState.Dirty = value;
                _previousLandloardZip.Dirty = value;
                _purchaseOrRefinancedAmount.Dirty = value;
                _purchaseOrRefinanceDescription.Dirty = value;
                _rdsfhRefinancedLoanIndicatorType.Dirty = value;
                _refinanceLoanIndicator.Dirty = value;
                _repairOtherAmount.Dirty = value;
                _repairOtherDescription.Dirty = value;
                _reservationAmountRequested.Dirty = value;
                _reserved.Dirty = value;
                _servicingOfficeName.Dirty = value;
                _sfhglpIndicator.Dirty = value;
                _sourceOfFundsType.Dirty = value;
                _stableDependableMonthlyIncome.Dirty = value;
                _stableOtherIncomeDesc.Dirty = value;
                _submittingLenderAddress.Dirty = value;
                _submittingLenderCity.Dirty = value;
                _submittingLenderContactFax.Dirty = value;
                _submittingLenderContactName.Dirty = value;
                _submittingLenderContactPhone.Dirty = value;
                _submittingLenderName.Dirty = value;
                _submittingLenderState.Dirty = value;
                _submittingLenderTaxId.Dirty = value;
                _submittingLenderZip.Dirty = value;
                _termOfBuydown.Dirty = value;
                _thirdPartyOriginator.Dirty = value;
                _title.Dirty = value;
                _totalBorrowerStableBaseIncome.Dirty = value;
                _totalBorrowerStableOtherIncome.Dirty = value;
                _totalHouseholdDeduction.Dirty = value;
                _totalRequestAmount.Dirty = value;
                _tpoTaxId.Dirty = value;
                _underwritingDecisionBy.Dirty = value;
                _underwritingDecisionDate.Dirty = value;
                _underwritingDecisionType.Dirty = value;
                _verificationCode.Dirty = value;
                if (_usdaHouseholdIncomes != null) _usdaHouseholdIncomes.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}