using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Usda : IClean
    {
        private Value<decimal?> _additionalIncomeFromPrimaryEmployment;
        public decimal? AdditionalIncomeFromPrimaryEmployment { get { return _additionalIncomeFromPrimaryEmployment; } set { _additionalIncomeFromPrimaryEmployment = value; } }
        private Value<decimal?> _additionalMemberBaseIncome;
        public decimal? AdditionalMemberBaseIncome { get { return _additionalMemberBaseIncome; } set { _additionalMemberBaseIncome = value; } }
        private Value<decimal?> _adjustedAnnualIncome;
        public decimal? AdjustedAnnualIncome { get { return _adjustedAnnualIncome; } set { _adjustedAnnualIncome = value; } }
        private Value<string> _adjustedIncomeCalculationDescription1;
        public string AdjustedIncomeCalculationDescription1 { get { return _adjustedIncomeCalculationDescription1; } set { _adjustedIncomeCalculationDescription1 = value; } }
        private Value<string> _adjustedIncomeCalculationDescription2;
        public string AdjustedIncomeCalculationDescription2 { get { return _adjustedIncomeCalculationDescription2; } set { _adjustedIncomeCalculationDescription2 = value; } }
        private Value<string> _adjustedIncomeCalculationDescription3;
        public string AdjustedIncomeCalculationDescription3 { get { return _adjustedIncomeCalculationDescription3; } set { _adjustedIncomeCalculationDescription3 = value; } }
        private Value<decimal?> _advanceAmountToDate;
        public decimal? AdvanceAmountToDate { get { return _advanceAmountToDate; } set { _advanceAmountToDate = value; } }
        private Value<decimal?> _amountLoanlineCredit;
        public decimal? AmountLoanlineCredit { get { return _amountLoanlineCredit; } set { _amountLoanlineCredit = value; } }
        private Value<decimal?> _annualChildCareExpenses;
        public decimal? AnnualChildCareExpenses { get { return _annualChildCareExpenses; } set { _annualChildCareExpenses = value; } }
        private Value<decimal?> _annualIncome;
        public decimal? AnnualIncome { get { return _annualIncome; } set { _annualIncome = value; } }
        private Value<string> _annualIncomeCalculationDescription1;
        public string AnnualIncomeCalculationDescription1 { get { return _annualIncomeCalculationDescription1; } set { _annualIncomeCalculationDescription1 = value; } }
        private Value<string> _annualIncomeCalculationDescription2;
        public string AnnualIncomeCalculationDescription2 { get { return _annualIncomeCalculationDescription2; } set { _annualIncomeCalculationDescription2 = value; } }
        private Value<string> _annualIncomeCalculationDescription3;
        public string AnnualIncomeCalculationDescription3 { get { return _annualIncomeCalculationDescription3; } set { _annualIncomeCalculationDescription3 = value; } }
        private Value<string> _annualIncomeCalculationDescription4;
        public string AnnualIncomeCalculationDescription4 { get { return _annualIncomeCalculationDescription4; } set { _annualIncomeCalculationDescription4 = value; } }
        private Value<string> _annualIncomeCalculationDescription5;
        public string AnnualIncomeCalculationDescription5 { get { return _annualIncomeCalculationDescription5; } set { _annualIncomeCalculationDescription5 = value; } }
        private Value<DateTime?> _annualReviewDate;
        public DateTime? AnnualReviewDate { get { return _annualReviewDate; } set { _annualReviewDate = value; } }
        private Value<string> _applicationNumber;
        public string ApplicationNumber { get { return _applicationNumber; } set { _applicationNumber = value; } }
        private Value<string> _approvedLenderTaxId;
        public string ApprovedLenderTaxId { get { return _approvedLenderTaxId; } set { _approvedLenderTaxId = value; } }
        private Value<decimal?> _assetIncome;
        public decimal? AssetIncome { get { return _assetIncome; } set { _assetIncome = value; } }
        private Value<decimal?> _balanceOwedOnLoan;
        public decimal? BalanceOwedOnLoan { get { return _balanceOwedOnLoan; } set { _balanceOwedOnLoan = value; } }
        private Value<decimal?> _borrowerBaseIncome;
        public decimal? BorrowerBaseIncome { get { return _borrowerBaseIncome; } set { _borrowerBaseIncome = value; } }
        private Value<decimal?> _borrowerTotalStableIncome;
        public decimal? BorrowerTotalStableIncome { get { return _borrowerTotalStableIncome; } set { _borrowerTotalStableIncome = value; } }
        private Value<string> _borrowerTypeCode;
        public string BorrowerTypeCode { get { return _borrowerTypeCode; } set { _borrowerTypeCode = value; } }
        private Value<decimal?> _buydownInterestAssistanceRate;
        public decimal? BuydownInterestAssistanceRate { get { return _buydownInterestAssistanceRate; } set { _buydownInterestAssistanceRate = value; } }
        private Value<string> _caseNumberBorrowerId;
        public string CaseNumberBorrowerId { get { return _caseNumberBorrowerId; } set { _caseNumberBorrowerId = value; } }
        private Value<string> _caseNumberCo;
        public string CaseNumberCo { get { return _caseNumberCo; } set { _caseNumberCo = value; } }
        private Value<string> _caseNumberSt;
        public string CaseNumberSt { get { return _caseNumberSt; } set { _caseNumberSt = value; } }
        private Value<DateTime?> _certificationEffectiveDate;
        public DateTime? CertificationEffectiveDate { get { return _certificationEffectiveDate; } set { _certificationEffectiveDate = value; } }
        private Value<DateTime?> _certificationExpirationDate;
        public DateTime? CertificationExpirationDate { get { return _certificationExpirationDate; } set { _certificationExpirationDate = value; } }
        private Value<bool?> _certifiedLoanIndicator;
        public bool? CertifiedLoanIndicator { get { return _certifiedLoanIndicator; } set { _certifiedLoanIndicator = value; } }
        private Value<string> _childCareProviderAddress;
        public string ChildCareProviderAddress { get { return _childCareProviderAddress; } set { _childCareProviderAddress = value; } }
        private Value<string> _childCareProviderCity;
        public string ChildCareProviderCity { get { return _childCareProviderCity; } set { _childCareProviderCity = value; } }
        private Value<string> _childCareProviderPhone;
        public string ChildCareProviderPhone { get { return _childCareProviderPhone; } set { _childCareProviderPhone = value; } }
        private Value<string> _childCareProviderProviderName;
        public string ChildCareProviderProviderName { get { return _childCareProviderProviderName; } set { _childCareProviderProviderName = value; } }
        private Value<string> _childCareProviderState;
        public string ChildCareProviderState { get { return _childCareProviderState; } set { _childCareProviderState = value; } }
        private Value<string> _childCareProviderZip;
        public string ChildCareProviderZip { get { return _childCareProviderZip; } set { _childCareProviderZip = value; } }
        private Value<decimal?> _childCostPerMonth;
        public decimal? ChildCostPerMonth { get { return _childCostPerMonth; } set { _childCostPerMonth = value; } }
        private Value<decimal?> _childCostPerWeek;
        public decimal? ChildCostPerWeek { get { return _childCostPerWeek; } set { _childCostPerWeek = value; } }
        private Value<decimal?> _coborrowerBaseIncome;
        public decimal? CoborrowerBaseIncome { get { return _coborrowerBaseIncome; } set { _coborrowerBaseIncome = value; } }
        private Value<decimal?> _coborrowerStableBaseIncome;
        public decimal? CoborrowerStableBaseIncome { get { return _coborrowerStableBaseIncome; } set { _coborrowerStableBaseIncome = value; } }
        private Value<string> _coborrowerStableBaseIncomeDesc;
        public string CoborrowerStableBaseIncomeDesc { get { return _coborrowerStableBaseIncomeDesc; } set { _coborrowerStableBaseIncomeDesc = value; } }
        private Value<decimal?> _coborrowerStableOtherIncome;
        public decimal? CoborrowerStableOtherIncome { get { return _coborrowerStableOtherIncome; } set { _coborrowerStableOtherIncome = value; } }
        private Value<string> _coborrowerStableOtherIncomeDesc;
        public string CoborrowerStableOtherIncomeDesc { get { return _coborrowerStableOtherIncomeDesc; } set { _coborrowerStableOtherIncomeDesc = value; } }
        private Value<decimal?> _coBorrowerTotalStableIncome;
        public decimal? CoBorrowerTotalStableIncome { get { return _coBorrowerTotalStableIncome; } set { _coBorrowerTotalStableIncome = value; } }
        private Value<DateTime?> _dateConfirmedObligationProcessed;
        public DateTime? DateConfirmedObligationProcessed { get { return _dateConfirmedObligationProcessed; } set { _dateConfirmedObligationProcessed = value; } }
        private Value<DateTime?> _dateLoanNoteGuaranteeIssued;
        public DateTime? DateLoanNoteGuaranteeIssued { get { return _dateLoanNoteGuaranteeIssued; } set { _dateLoanNoteGuaranteeIssued = value; } }
        private Value<DateTime?> _dateLoanNoteGuaranteeRequestReceived;
        public DateTime? DateLoanNoteGuaranteeRequestReceived { get { return _dateLoanNoteGuaranteeRequestReceived; } set { _dateLoanNoteGuaranteeRequestReceived = value; } }
        private Value<DateTime?> _dateObligationInGls;
        public DateTime? DateObligationInGls { get { return _dateObligationInGls; } set { _dateObligationInGls = value; } }
        private Value<DateTime?> _dateVerifiedInUnifi;
        public DateTime? DateVerifiedInUnifi { get { return _dateVerifiedInUnifi; } set { _dateVerifiedInUnifi = value; } }
        private Value<decimal?> _dependentDeduction;
        public decimal? DependentDeduction { get { return _dependentDeduction; } set { _dependentDeduction = value; } }
        private Value<decimal?> _disabilityDeduction;
        public decimal? DisabilityDeduction { get { return _disabilityDeduction; } set { _disabilityDeduction = value; } }
        private Value<decimal?> _elderlyHouseholdDeduction;
        public decimal? ElderlyHouseholdDeduction { get { return _elderlyHouseholdDeduction; } set { _elderlyHouseholdDeduction = value; } }
        private Value<decimal?> _feeRate;
        public decimal? FeeRate { get { return _feeRate; } set { _feeRate = value; } }
        private Value<string> _financedLoanClosingCostDescription;
        public string FinancedLoanClosingCostDescription { get { return _financedLoanClosingCostDescription; } set { _financedLoanClosingCostDescription = value; } }
        private Value<decimal?> _guaranteeFeeCollected;
        public decimal? GuaranteeFeeCollected { get { return _guaranteeFeeCollected; } set { _guaranteeFeeCollected = value; } }
        private Value<decimal?> _guaranteeFeeOnCommitment;
        public decimal? GuaranteeFeeOnCommitment { get { return _guaranteeFeeOnCommitment; } set { _guaranteeFeeOnCommitment = value; } }
        private Value<string> _guaranteeFeePurposeCodeType;
        public string GuaranteeFeePurposeCodeType { get { return _guaranteeFeePurposeCodeType; } set { _guaranteeFeePurposeCodeType = value; } }
        private Value<DateTime?> _guaranteePeriodBeginsDate;
        public DateTime? GuaranteePeriodBeginsDate { get { return _guaranteePeriodBeginsDate; } set { _guaranteePeriodBeginsDate = value; } }
        private Value<DateTime?> _guaranteePeriodEndsDate;
        public DateTime? GuaranteePeriodEndsDate { get { return _guaranteePeriodEndsDate; } set { _guaranteePeriodEndsDate = value; } }
        private Value<string> _guaranteeType;
        public string GuaranteeType { get { return _guaranteeType; } set { _guaranteeType = value; } }
        private Value<int?> _householdSize;
        public int? HouseholdSize { get { return _householdSize; } set { _householdSize = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _interestAssistanceCodeType;
        public string InterestAssistanceCodeType { get { return _interestAssistanceCodeType; } set { _interestAssistanceCodeType = value; } }
        private Value<bool?> _interestRateBasedonFannieIndicator;
        public bool? InterestRateBasedonFannieIndicator { get { return _interestRateBasedonFannieIndicator; } set { _interestRateBasedonFannieIndicator = value; } }
        private Value<string> _interestRateCodeType;
        public string InterestRateCodeType { get { return _interestRateCodeType; } set { _interestRateCodeType = value; } }
        private Value<bool?> _interestRateFloatToLoanClosingIndicator;
        public bool? InterestRateFloatToLoanClosingIndicator { get { return _interestRateFloatToLoanClosingIndicator; } set { _interestRateFloatToLoanClosingIndicator = value; } }
        private Value<bool?> _lackAdequateHeatIndicator;
        public bool? LackAdequateHeatIndicator { get { return _lackAdequateHeatIndicator; } set { _lackAdequateHeatIndicator = value; } }
        private Value<string> _lenderAuthorizedRepCompany;
        public string LenderAuthorizedRepCompany { get { return _lenderAuthorizedRepCompany; } set { _lenderAuthorizedRepCompany = value; } }
        private Value<string> _lenderAuthorizedRepName;
        public string LenderAuthorizedRepName { get { return _lenderAuthorizedRepName; } set { _lenderAuthorizedRepName = value; } }
        private Value<string> _lenderAuthorizedRepTitle;
        public string LenderAuthorizedRepTitle { get { return _lenderAuthorizedRepTitle; } set { _lenderAuthorizedRepTitle = value; } }
        private Value<string> _lenderIdNo;
        public string LenderIdNo { get { return _lenderIdNo; } set { _lenderIdNo = value; } }
        private Value<decimal?> _lenderNoteRateOnGuaranteedPortion;
        public decimal? LenderNoteRateOnGuaranteedPortion { get { return _lenderNoteRateOnGuaranteedPortion; } set { _lenderNoteRateOnGuaranteedPortion = value; } }
        private Value<decimal?> _lenderNoteRateOnNonGuaranteedPortion;
        public decimal? LenderNoteRateOnNonGuaranteedPortion { get { return _lenderNoteRateOnNonGuaranteedPortion; } set { _lenderNoteRateOnNonGuaranteedPortion = value; } }
        private Value<string> _lenderStatusCodeType;
        public string LenderStatusCodeType { get { return _lenderStatusCodeType; } set { _lenderStatusCodeType = value; } }
        private Value<string> _lenderTypeCode;
        public string LenderTypeCode { get { return _lenderTypeCode; } set { _lenderTypeCode = value; } }
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        private Value<bool?> _lockCompletePlumbingIndicator;
        public bool? LockCompletePlumbingIndicator { get { return _lockCompletePlumbingIndicator; } set { _lockCompletePlumbingIndicator = value; } }
        private Value<decimal?> _medicalExpenses;
        public decimal? MedicalExpenses { get { return _medicalExpenses; } set { _medicalExpenses = value; } }
        private Value<decimal?> _moderateIncomeLimit;
        public decimal? ModerateIncomeLimit { get { return _moderateIncomeLimit; } set { _moderateIncomeLimit = value; } }
        private Value<decimal?> _monthlyRepaymentIncome;
        public decimal? MonthlyRepaymentIncome { get { return _monthlyRepaymentIncome; } set { _monthlyRepaymentIncome = value; } }
        private Value<int?> _numberofDependents;
        public int? NumberofDependents { get { return _numberofDependents; } set { _numberofDependents = value; } }
        private Value<int?> _numberofPeopleInHousehold;
        public int? NumberofPeopleInHousehold { get { return _numberofPeopleInHousehold; } set { _numberofPeopleInHousehold = value; } }
        private Value<bool?> _obligationMatchesCommitmentLenderRequestIndicator;
        public bool? ObligationMatchesCommitmentLenderRequestIndicator { get { return _obligationMatchesCommitmentLenderRequestIndicator; } set { _obligationMatchesCommitmentLenderRequestIndicator = value; } }
        private Value<string> _officialWhoConfirmedGlsUpdated;
        public string OfficialWhoConfirmedGlsUpdated { get { return _officialWhoConfirmedGlsUpdated; } set { _officialWhoConfirmedGlsUpdated = value; } }
        private Value<decimal?> _otherIncome;
        public decimal? OtherIncome { get { return _otherIncome; } set { _otherIncome = value; } }
        private Value<decimal?> _otherStableDependableMonthlyIncome;
        public decimal? OtherStableDependableMonthlyIncome { get { return _otherStableDependableMonthlyIncome; } set { _otherStableDependableMonthlyIncome = value; } }
        private Value<bool?> _overcrowdedIndicator;
        public bool? OvercrowdedIndicator { get { return _overcrowdedIndicator; } set { _overcrowdedIndicator = value; } }
        private Value<decimal?> _percentofLoanGuaranteed;
        public decimal? PercentofLoanGuaranteed { get { return _percentofLoanGuaranteed; } set { _percentofLoanGuaranteed = value; } }
        private Value<string> _periodOperatingLineCreditYearsType;
        public string PeriodOperatingLineCreditYearsType { get { return _periodOperatingLineCreditYearsType; } set { _periodOperatingLineCreditYearsType = value; } }
        private Value<bool?> _physicallyDeterioratedIndicator;
        public bool? PhysicallyDeterioratedIndicator { get { return _physicallyDeterioratedIndicator; } set { _physicallyDeterioratedIndicator = value; } }
        private Value<string> _preparedByName;
        public string PreparedByName { get { return _preparedByName; } set { _preparedByName = value; } }
        private Value<string> _preparedByTitle;
        public string PreparedByTitle { get { return _preparedByTitle; } set { _preparedByTitle = value; } }
        private Value<string> _presentLandloardAddress;
        public string PresentLandloardAddress { get { return _presentLandloardAddress; } set { _presentLandloardAddress = value; } }
        private Value<string> _presentLandloardCity;
        public string PresentLandloardCity { get { return _presentLandloardCity; } set { _presentLandloardCity = value; } }
        private Value<string> _presentLandloardName;
        public string PresentLandloardName { get { return _presentLandloardName; } set { _presentLandloardName = value; } }
        private Value<string> _presentLandloardPhone;
        public string PresentLandloardPhone { get { return _presentLandloardPhone; } set { _presentLandloardPhone = value; } }
        private Value<string> _presentLandloardState;
        public string PresentLandloardState { get { return _presentLandloardState; } set { _presentLandloardState = value; } }
        private Value<string> _presentLandloardZip;
        public string PresentLandloardZip { get { return _presentLandloardZip; } set { _presentLandloardZip = value; } }
        private Value<string> _previousLandloardAddress;
        public string PreviousLandloardAddress { get { return _previousLandloardAddress; } set { _previousLandloardAddress = value; } }
        private Value<string> _previousLandloardCity;
        public string PreviousLandloardCity { get { return _previousLandloardCity; } set { _previousLandloardCity = value; } }
        private Value<string> _previousLandloardName;
        public string PreviousLandloardName { get { return _previousLandloardName; } set { _previousLandloardName = value; } }
        private Value<string> _previousLandloardPhone;
        public string PreviousLandloardPhone { get { return _previousLandloardPhone; } set { _previousLandloardPhone = value; } }
        private Value<string> _previousLandloardState;
        public string PreviousLandloardState { get { return _previousLandloardState; } set { _previousLandloardState = value; } }
        private Value<string> _previousLandloardZip;
        public string PreviousLandloardZip { get { return _previousLandloardZip; } set { _previousLandloardZip = value; } }
        private Value<decimal?> _purchaseOrRefinancedAmount;
        public decimal? PurchaseOrRefinancedAmount { get { return _purchaseOrRefinancedAmount; } set { _purchaseOrRefinancedAmount = value; } }
        private Value<string> _purchaseOrRefinanceDescription;
        public string PurchaseOrRefinanceDescription { get { return _purchaseOrRefinanceDescription; } set { _purchaseOrRefinanceDescription = value; } }
        private Value<string> _rdsfhRefinancedLoanIndicatorType;
        public string RdsfhRefinancedLoanIndicatorType { get { return _rdsfhRefinancedLoanIndicatorType; } set { _rdsfhRefinancedLoanIndicatorType = value; } }
        private Value<bool?> _refinanceLoanIndicator;
        public bool? RefinanceLoanIndicator { get { return _refinanceLoanIndicator; } set { _refinanceLoanIndicator = value; } }
        private Value<decimal?> _repairOtherAmount;
        public decimal? RepairOtherAmount { get { return _repairOtherAmount; } set { _repairOtherAmount = value; } }
        private Value<string> _repairOtherDescription;
        public string RepairOtherDescription { get { return _repairOtherDescription; } set { _repairOtherDescription = value; } }
        private Value<decimal?> _reservationAmountRequested;
        public decimal? ReservationAmountRequested { get { return _reservationAmountRequested; } set { _reservationAmountRequested = value; } }
        private Value<string> _reserved;
        public string Reserved { get { return _reserved; } set { _reserved = value; } }
        private Value<string> _servicingOfficeName;
        public string ServicingOfficeName { get { return _servicingOfficeName; } set { _servicingOfficeName = value; } }
        private Value<bool?> _sfhglpIndicator;
        public bool? SfhglpIndicator { get { return _sfhglpIndicator; } set { _sfhglpIndicator = value; } }
        private Value<string> _sourceOfFundsType;
        public string SourceOfFundsType { get { return _sourceOfFundsType; } set { _sourceOfFundsType = value; } }
        private Value<decimal?> _stableDependableMonthlyIncome;
        public decimal? StableDependableMonthlyIncome { get { return _stableDependableMonthlyIncome; } set { _stableDependableMonthlyIncome = value; } }
        private Value<string> _stableOtherIncomeDesc;
        public string StableOtherIncomeDesc { get { return _stableOtherIncomeDesc; } set { _stableOtherIncomeDesc = value; } }
        private Value<string> _submittingLenderAddress;
        public string SubmittingLenderAddress { get { return _submittingLenderAddress; } set { _submittingLenderAddress = value; } }
        private Value<string> _submittingLenderCity;
        public string SubmittingLenderCity { get { return _submittingLenderCity; } set { _submittingLenderCity = value; } }
        private Value<string> _submittingLenderContactFax;
        public string SubmittingLenderContactFax { get { return _submittingLenderContactFax; } set { _submittingLenderContactFax = value; } }
        private Value<string> _submittingLenderContactName;
        public string SubmittingLenderContactName { get { return _submittingLenderContactName; } set { _submittingLenderContactName = value; } }
        private Value<string> _submittingLenderContactPhone;
        public string SubmittingLenderContactPhone { get { return _submittingLenderContactPhone; } set { _submittingLenderContactPhone = value; } }
        private Value<string> _submittingLenderName;
        public string SubmittingLenderName { get { return _submittingLenderName; } set { _submittingLenderName = value; } }
        private Value<string> _submittingLenderState;
        public string SubmittingLenderState { get { return _submittingLenderState; } set { _submittingLenderState = value; } }
        private Value<string> _submittingLenderTaxId;
        public string SubmittingLenderTaxId { get { return _submittingLenderTaxId; } set { _submittingLenderTaxId = value; } }
        private Value<string> _submittingLenderZip;
        public string SubmittingLenderZip { get { return _submittingLenderZip; } set { _submittingLenderZip = value; } }
        private Value<int?> _termOfBuydown;
        public int? TermOfBuydown { get { return _termOfBuydown; } set { _termOfBuydown = value; } }
        private Value<string> _thirdPartyOriginator;
        public string ThirdPartyOriginator { get { return _thirdPartyOriginator; } set { _thirdPartyOriginator = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<decimal?> _totalBorrowerStableBaseIncome;
        public decimal? TotalBorrowerStableBaseIncome { get { return _totalBorrowerStableBaseIncome; } set { _totalBorrowerStableBaseIncome = value; } }
        private Value<decimal?> _totalBorrowerStableOtherIncome;
        public decimal? TotalBorrowerStableOtherIncome { get { return _totalBorrowerStableOtherIncome; } set { _totalBorrowerStableOtherIncome = value; } }
        private Value<decimal?> _totalHouseholdDeduction;
        public decimal? TotalHouseholdDeduction { get { return _totalHouseholdDeduction; } set { _totalHouseholdDeduction = value; } }
        private Value<decimal?> _totalRequestAmount;
        public decimal? TotalRequestAmount { get { return _totalRequestAmount; } set { _totalRequestAmount = value; } }
        private Value<string> _tpoTaxId;
        public string TpoTaxId { get { return _tpoTaxId; } set { _tpoTaxId = value; } }
        private Value<string> _underwritingDecisionBy;
        public string UnderwritingDecisionBy { get { return _underwritingDecisionBy; } set { _underwritingDecisionBy = value; } }
        private Value<DateTime?> _underwritingDecisionDate;
        public DateTime? UnderwritingDecisionDate { get { return _underwritingDecisionDate; } set { _underwritingDecisionDate = value; } }
        private Value<string> _underwritingDecisionType;
        public string UnderwritingDecisionType { get { return _underwritingDecisionType; } set { _underwritingDecisionType = value; } }
        private Value<List<UsdaHouseholdIncome>> _usdaHouseholdIncomes;
        public List<UsdaHouseholdIncome> UsdaHouseholdIncomes { get { return _usdaHouseholdIncomes; } set { _usdaHouseholdIncomes = value; } }
        private Value<string> _verificationCode;
        public string VerificationCode { get { return _verificationCode; } set { _verificationCode = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalIncomeFromPrimaryEmployment.Clean
                    && _additionalMemberBaseIncome.Clean
                    && _adjustedAnnualIncome.Clean
                    && _adjustedIncomeCalculationDescription1.Clean
                    && _adjustedIncomeCalculationDescription2.Clean
                    && _adjustedIncomeCalculationDescription3.Clean
                    && _advanceAmountToDate.Clean
                    && _amountLoanlineCredit.Clean
                    && _annualChildCareExpenses.Clean
                    && _annualIncome.Clean
                    && _annualIncomeCalculationDescription1.Clean
                    && _annualIncomeCalculationDescription2.Clean
                    && _annualIncomeCalculationDescription3.Clean
                    && _annualIncomeCalculationDescription4.Clean
                    && _annualIncomeCalculationDescription5.Clean
                    && _annualReviewDate.Clean
                    && _applicationNumber.Clean
                    && _approvedLenderTaxId.Clean
                    && _assetIncome.Clean
                    && _balanceOwedOnLoan.Clean
                    && _borrowerBaseIncome.Clean
                    && _borrowerTotalStableIncome.Clean
                    && _borrowerTypeCode.Clean
                    && _buydownInterestAssistanceRate.Clean
                    && _caseNumberBorrowerId.Clean
                    && _caseNumberCo.Clean
                    && _caseNumberSt.Clean
                    && _certificationEffectiveDate.Clean
                    && _certificationExpirationDate.Clean
                    && _certifiedLoanIndicator.Clean
                    && _childCareProviderAddress.Clean
                    && _childCareProviderCity.Clean
                    && _childCareProviderPhone.Clean
                    && _childCareProviderProviderName.Clean
                    && _childCareProviderState.Clean
                    && _childCareProviderZip.Clean
                    && _childCostPerMonth.Clean
                    && _childCostPerWeek.Clean
                    && _coborrowerBaseIncome.Clean
                    && _coborrowerStableBaseIncome.Clean
                    && _coborrowerStableBaseIncomeDesc.Clean
                    && _coborrowerStableOtherIncome.Clean
                    && _coborrowerStableOtherIncomeDesc.Clean
                    && _coBorrowerTotalStableIncome.Clean
                    && _dateConfirmedObligationProcessed.Clean
                    && _dateLoanNoteGuaranteeIssued.Clean
                    && _dateLoanNoteGuaranteeRequestReceived.Clean
                    && _dateObligationInGls.Clean
                    && _dateVerifiedInUnifi.Clean
                    && _dependentDeduction.Clean
                    && _disabilityDeduction.Clean
                    && _elderlyHouseholdDeduction.Clean
                    && _feeRate.Clean
                    && _financedLoanClosingCostDescription.Clean
                    && _guaranteeFeeCollected.Clean
                    && _guaranteeFeeOnCommitment.Clean
                    && _guaranteeFeePurposeCodeType.Clean
                    && _guaranteePeriodBeginsDate.Clean
                    && _guaranteePeriodEndsDate.Clean
                    && _guaranteeType.Clean
                    && _householdSize.Clean
                    && _id.Clean
                    && _interestAssistanceCodeType.Clean
                    && _interestRateBasedonFannieIndicator.Clean
                    && _interestRateCodeType.Clean
                    && _interestRateFloatToLoanClosingIndicator.Clean
                    && _lackAdequateHeatIndicator.Clean
                    && _lenderAuthorizedRepCompany.Clean
                    && _lenderAuthorizedRepName.Clean
                    && _lenderAuthorizedRepTitle.Clean
                    && _lenderIdNo.Clean
                    && _lenderNoteRateOnGuaranteedPortion.Clean
                    && _lenderNoteRateOnNonGuaranteedPortion.Clean
                    && _lenderStatusCodeType.Clean
                    && _lenderTypeCode.Clean
                    && _loanType.Clean
                    && _lockCompletePlumbingIndicator.Clean
                    && _medicalExpenses.Clean
                    && _moderateIncomeLimit.Clean
                    && _monthlyRepaymentIncome.Clean
                    && _numberofDependents.Clean
                    && _numberofPeopleInHousehold.Clean
                    && _obligationMatchesCommitmentLenderRequestIndicator.Clean
                    && _officialWhoConfirmedGlsUpdated.Clean
                    && _otherIncome.Clean
                    && _otherStableDependableMonthlyIncome.Clean
                    && _overcrowdedIndicator.Clean
                    && _percentofLoanGuaranteed.Clean
                    && _periodOperatingLineCreditYearsType.Clean
                    && _physicallyDeterioratedIndicator.Clean
                    && _preparedByName.Clean
                    && _preparedByTitle.Clean
                    && _presentLandloardAddress.Clean
                    && _presentLandloardCity.Clean
                    && _presentLandloardName.Clean
                    && _presentLandloardPhone.Clean
                    && _presentLandloardState.Clean
                    && _presentLandloardZip.Clean
                    && _previousLandloardAddress.Clean
                    && _previousLandloardCity.Clean
                    && _previousLandloardName.Clean
                    && _previousLandloardPhone.Clean
                    && _previousLandloardState.Clean
                    && _previousLandloardZip.Clean
                    && _purchaseOrRefinancedAmount.Clean
                    && _purchaseOrRefinanceDescription.Clean
                    && _rdsfhRefinancedLoanIndicatorType.Clean
                    && _refinanceLoanIndicator.Clean
                    && _repairOtherAmount.Clean
                    && _repairOtherDescription.Clean
                    && _reservationAmountRequested.Clean
                    && _reserved.Clean
                    && _servicingOfficeName.Clean
                    && _sfhglpIndicator.Clean
                    && _sourceOfFundsType.Clean
                    && _stableDependableMonthlyIncome.Clean
                    && _stableOtherIncomeDesc.Clean
                    && _submittingLenderAddress.Clean
                    && _submittingLenderCity.Clean
                    && _submittingLenderContactFax.Clean
                    && _submittingLenderContactName.Clean
                    && _submittingLenderContactPhone.Clean
                    && _submittingLenderName.Clean
                    && _submittingLenderState.Clean
                    && _submittingLenderTaxId.Clean
                    && _submittingLenderZip.Clean
                    && _termOfBuydown.Clean
                    && _thirdPartyOriginator.Clean
                    && _title.Clean
                    && _totalBorrowerStableBaseIncome.Clean
                    && _totalBorrowerStableOtherIncome.Clean
                    && _totalHouseholdDeduction.Clean
                    && _totalRequestAmount.Clean
                    && _tpoTaxId.Clean
                    && _underwritingDecisionBy.Clean
                    && _underwritingDecisionDate.Clean
                    && _underwritingDecisionType.Clean
                    && _usdaHouseholdIncomes.Clean
                    && _verificationCode.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var additionalIncomeFromPrimaryEmployment = _additionalIncomeFromPrimaryEmployment; additionalIncomeFromPrimaryEmployment.Clean = value; _additionalIncomeFromPrimaryEmployment = additionalIncomeFromPrimaryEmployment;
                var additionalMemberBaseIncome = _additionalMemberBaseIncome; additionalMemberBaseIncome.Clean = value; _additionalMemberBaseIncome = additionalMemberBaseIncome;
                var adjustedAnnualIncome = _adjustedAnnualIncome; adjustedAnnualIncome.Clean = value; _adjustedAnnualIncome = adjustedAnnualIncome;
                var adjustedIncomeCalculationDescription1 = _adjustedIncomeCalculationDescription1; adjustedIncomeCalculationDescription1.Clean = value; _adjustedIncomeCalculationDescription1 = adjustedIncomeCalculationDescription1;
                var adjustedIncomeCalculationDescription2 = _adjustedIncomeCalculationDescription2; adjustedIncomeCalculationDescription2.Clean = value; _adjustedIncomeCalculationDescription2 = adjustedIncomeCalculationDescription2;
                var adjustedIncomeCalculationDescription3 = _adjustedIncomeCalculationDescription3; adjustedIncomeCalculationDescription3.Clean = value; _adjustedIncomeCalculationDescription3 = adjustedIncomeCalculationDescription3;
                var advanceAmountToDate = _advanceAmountToDate; advanceAmountToDate.Clean = value; _advanceAmountToDate = advanceAmountToDate;
                var amountLoanlineCredit = _amountLoanlineCredit; amountLoanlineCredit.Clean = value; _amountLoanlineCredit = amountLoanlineCredit;
                var annualChildCareExpenses = _annualChildCareExpenses; annualChildCareExpenses.Clean = value; _annualChildCareExpenses = annualChildCareExpenses;
                var annualIncome = _annualIncome; annualIncome.Clean = value; _annualIncome = annualIncome;
                var annualIncomeCalculationDescription1 = _annualIncomeCalculationDescription1; annualIncomeCalculationDescription1.Clean = value; _annualIncomeCalculationDescription1 = annualIncomeCalculationDescription1;
                var annualIncomeCalculationDescription2 = _annualIncomeCalculationDescription2; annualIncomeCalculationDescription2.Clean = value; _annualIncomeCalculationDescription2 = annualIncomeCalculationDescription2;
                var annualIncomeCalculationDescription3 = _annualIncomeCalculationDescription3; annualIncomeCalculationDescription3.Clean = value; _annualIncomeCalculationDescription3 = annualIncomeCalculationDescription3;
                var annualIncomeCalculationDescription4 = _annualIncomeCalculationDescription4; annualIncomeCalculationDescription4.Clean = value; _annualIncomeCalculationDescription4 = annualIncomeCalculationDescription4;
                var annualIncomeCalculationDescription5 = _annualIncomeCalculationDescription5; annualIncomeCalculationDescription5.Clean = value; _annualIncomeCalculationDescription5 = annualIncomeCalculationDescription5;
                var annualReviewDate = _annualReviewDate; annualReviewDate.Clean = value; _annualReviewDate = annualReviewDate;
                var applicationNumber = _applicationNumber; applicationNumber.Clean = value; _applicationNumber = applicationNumber;
                var approvedLenderTaxId = _approvedLenderTaxId; approvedLenderTaxId.Clean = value; _approvedLenderTaxId = approvedLenderTaxId;
                var assetIncome = _assetIncome; assetIncome.Clean = value; _assetIncome = assetIncome;
                var balanceOwedOnLoan = _balanceOwedOnLoan; balanceOwedOnLoan.Clean = value; _balanceOwedOnLoan = balanceOwedOnLoan;
                var borrowerBaseIncome = _borrowerBaseIncome; borrowerBaseIncome.Clean = value; _borrowerBaseIncome = borrowerBaseIncome;
                var borrowerTotalStableIncome = _borrowerTotalStableIncome; borrowerTotalStableIncome.Clean = value; _borrowerTotalStableIncome = borrowerTotalStableIncome;
                var borrowerTypeCode = _borrowerTypeCode; borrowerTypeCode.Clean = value; _borrowerTypeCode = borrowerTypeCode;
                var buydownInterestAssistanceRate = _buydownInterestAssistanceRate; buydownInterestAssistanceRate.Clean = value; _buydownInterestAssistanceRate = buydownInterestAssistanceRate;
                var caseNumberBorrowerId = _caseNumberBorrowerId; caseNumberBorrowerId.Clean = value; _caseNumberBorrowerId = caseNumberBorrowerId;
                var caseNumberCo = _caseNumberCo; caseNumberCo.Clean = value; _caseNumberCo = caseNumberCo;
                var caseNumberSt = _caseNumberSt; caseNumberSt.Clean = value; _caseNumberSt = caseNumberSt;
                var certificationEffectiveDate = _certificationEffectiveDate; certificationEffectiveDate.Clean = value; _certificationEffectiveDate = certificationEffectiveDate;
                var certificationExpirationDate = _certificationExpirationDate; certificationExpirationDate.Clean = value; _certificationExpirationDate = certificationExpirationDate;
                var certifiedLoanIndicator = _certifiedLoanIndicator; certifiedLoanIndicator.Clean = value; _certifiedLoanIndicator = certifiedLoanIndicator;
                var childCareProviderAddress = _childCareProviderAddress; childCareProviderAddress.Clean = value; _childCareProviderAddress = childCareProviderAddress;
                var childCareProviderCity = _childCareProviderCity; childCareProviderCity.Clean = value; _childCareProviderCity = childCareProviderCity;
                var childCareProviderPhone = _childCareProviderPhone; childCareProviderPhone.Clean = value; _childCareProviderPhone = childCareProviderPhone;
                var childCareProviderProviderName = _childCareProviderProviderName; childCareProviderProviderName.Clean = value; _childCareProviderProviderName = childCareProviderProviderName;
                var childCareProviderState = _childCareProviderState; childCareProviderState.Clean = value; _childCareProviderState = childCareProviderState;
                var childCareProviderZip = _childCareProviderZip; childCareProviderZip.Clean = value; _childCareProviderZip = childCareProviderZip;
                var childCostPerMonth = _childCostPerMonth; childCostPerMonth.Clean = value; _childCostPerMonth = childCostPerMonth;
                var childCostPerWeek = _childCostPerWeek; childCostPerWeek.Clean = value; _childCostPerWeek = childCostPerWeek;
                var coborrowerBaseIncome = _coborrowerBaseIncome; coborrowerBaseIncome.Clean = value; _coborrowerBaseIncome = coborrowerBaseIncome;
                var coborrowerStableBaseIncome = _coborrowerStableBaseIncome; coborrowerStableBaseIncome.Clean = value; _coborrowerStableBaseIncome = coborrowerStableBaseIncome;
                var coborrowerStableBaseIncomeDesc = _coborrowerStableBaseIncomeDesc; coborrowerStableBaseIncomeDesc.Clean = value; _coborrowerStableBaseIncomeDesc = coborrowerStableBaseIncomeDesc;
                var coborrowerStableOtherIncome = _coborrowerStableOtherIncome; coborrowerStableOtherIncome.Clean = value; _coborrowerStableOtherIncome = coborrowerStableOtherIncome;
                var coborrowerStableOtherIncomeDesc = _coborrowerStableOtherIncomeDesc; coborrowerStableOtherIncomeDesc.Clean = value; _coborrowerStableOtherIncomeDesc = coborrowerStableOtherIncomeDesc;
                var coBorrowerTotalStableIncome = _coBorrowerTotalStableIncome; coBorrowerTotalStableIncome.Clean = value; _coBorrowerTotalStableIncome = coBorrowerTotalStableIncome;
                var dateConfirmedObligationProcessed = _dateConfirmedObligationProcessed; dateConfirmedObligationProcessed.Clean = value; _dateConfirmedObligationProcessed = dateConfirmedObligationProcessed;
                var dateLoanNoteGuaranteeIssued = _dateLoanNoteGuaranteeIssued; dateLoanNoteGuaranteeIssued.Clean = value; _dateLoanNoteGuaranteeIssued = dateLoanNoteGuaranteeIssued;
                var dateLoanNoteGuaranteeRequestReceived = _dateLoanNoteGuaranteeRequestReceived; dateLoanNoteGuaranteeRequestReceived.Clean = value; _dateLoanNoteGuaranteeRequestReceived = dateLoanNoteGuaranteeRequestReceived;
                var dateObligationInGls = _dateObligationInGls; dateObligationInGls.Clean = value; _dateObligationInGls = dateObligationInGls;
                var dateVerifiedInUnifi = _dateVerifiedInUnifi; dateVerifiedInUnifi.Clean = value; _dateVerifiedInUnifi = dateVerifiedInUnifi;
                var dependentDeduction = _dependentDeduction; dependentDeduction.Clean = value; _dependentDeduction = dependentDeduction;
                var disabilityDeduction = _disabilityDeduction; disabilityDeduction.Clean = value; _disabilityDeduction = disabilityDeduction;
                var elderlyHouseholdDeduction = _elderlyHouseholdDeduction; elderlyHouseholdDeduction.Clean = value; _elderlyHouseholdDeduction = elderlyHouseholdDeduction;
                var feeRate = _feeRate; feeRate.Clean = value; _feeRate = feeRate;
                var financedLoanClosingCostDescription = _financedLoanClosingCostDescription; financedLoanClosingCostDescription.Clean = value; _financedLoanClosingCostDescription = financedLoanClosingCostDescription;
                var guaranteeFeeCollected = _guaranteeFeeCollected; guaranteeFeeCollected.Clean = value; _guaranteeFeeCollected = guaranteeFeeCollected;
                var guaranteeFeeOnCommitment = _guaranteeFeeOnCommitment; guaranteeFeeOnCommitment.Clean = value; _guaranteeFeeOnCommitment = guaranteeFeeOnCommitment;
                var guaranteeFeePurposeCodeType = _guaranteeFeePurposeCodeType; guaranteeFeePurposeCodeType.Clean = value; _guaranteeFeePurposeCodeType = guaranteeFeePurposeCodeType;
                var guaranteePeriodBeginsDate = _guaranteePeriodBeginsDate; guaranteePeriodBeginsDate.Clean = value; _guaranteePeriodBeginsDate = guaranteePeriodBeginsDate;
                var guaranteePeriodEndsDate = _guaranteePeriodEndsDate; guaranteePeriodEndsDate.Clean = value; _guaranteePeriodEndsDate = guaranteePeriodEndsDate;
                var guaranteeType = _guaranteeType; guaranteeType.Clean = value; _guaranteeType = guaranteeType;
                var householdSize = _householdSize; householdSize.Clean = value; _householdSize = householdSize;
                var id = _id; id.Clean = value; _id = id;
                var interestAssistanceCodeType = _interestAssistanceCodeType; interestAssistanceCodeType.Clean = value; _interestAssistanceCodeType = interestAssistanceCodeType;
                var interestRateBasedonFannieIndicator = _interestRateBasedonFannieIndicator; interestRateBasedonFannieIndicator.Clean = value; _interestRateBasedonFannieIndicator = interestRateBasedonFannieIndicator;
                var interestRateCodeType = _interestRateCodeType; interestRateCodeType.Clean = value; _interestRateCodeType = interestRateCodeType;
                var interestRateFloatToLoanClosingIndicator = _interestRateFloatToLoanClosingIndicator; interestRateFloatToLoanClosingIndicator.Clean = value; _interestRateFloatToLoanClosingIndicator = interestRateFloatToLoanClosingIndicator;
                var lackAdequateHeatIndicator = _lackAdequateHeatIndicator; lackAdequateHeatIndicator.Clean = value; _lackAdequateHeatIndicator = lackAdequateHeatIndicator;
                var lenderAuthorizedRepCompany = _lenderAuthorizedRepCompany; lenderAuthorizedRepCompany.Clean = value; _lenderAuthorizedRepCompany = lenderAuthorizedRepCompany;
                var lenderAuthorizedRepName = _lenderAuthorizedRepName; lenderAuthorizedRepName.Clean = value; _lenderAuthorizedRepName = lenderAuthorizedRepName;
                var lenderAuthorizedRepTitle = _lenderAuthorizedRepTitle; lenderAuthorizedRepTitle.Clean = value; _lenderAuthorizedRepTitle = lenderAuthorizedRepTitle;
                var lenderIdNo = _lenderIdNo; lenderIdNo.Clean = value; _lenderIdNo = lenderIdNo;
                var lenderNoteRateOnGuaranteedPortion = _lenderNoteRateOnGuaranteedPortion; lenderNoteRateOnGuaranteedPortion.Clean = value; _lenderNoteRateOnGuaranteedPortion = lenderNoteRateOnGuaranteedPortion;
                var lenderNoteRateOnNonGuaranteedPortion = _lenderNoteRateOnNonGuaranteedPortion; lenderNoteRateOnNonGuaranteedPortion.Clean = value; _lenderNoteRateOnNonGuaranteedPortion = lenderNoteRateOnNonGuaranteedPortion;
                var lenderStatusCodeType = _lenderStatusCodeType; lenderStatusCodeType.Clean = value; _lenderStatusCodeType = lenderStatusCodeType;
                var lenderTypeCode = _lenderTypeCode; lenderTypeCode.Clean = value; _lenderTypeCode = lenderTypeCode;
                var loanType = _loanType; loanType.Clean = value; _loanType = loanType;
                var lockCompletePlumbingIndicator = _lockCompletePlumbingIndicator; lockCompletePlumbingIndicator.Clean = value; _lockCompletePlumbingIndicator = lockCompletePlumbingIndicator;
                var medicalExpenses = _medicalExpenses; medicalExpenses.Clean = value; _medicalExpenses = medicalExpenses;
                var moderateIncomeLimit = _moderateIncomeLimit; moderateIncomeLimit.Clean = value; _moderateIncomeLimit = moderateIncomeLimit;
                var monthlyRepaymentIncome = _monthlyRepaymentIncome; monthlyRepaymentIncome.Clean = value; _monthlyRepaymentIncome = monthlyRepaymentIncome;
                var numberofDependents = _numberofDependents; numberofDependents.Clean = value; _numberofDependents = numberofDependents;
                var numberofPeopleInHousehold = _numberofPeopleInHousehold; numberofPeopleInHousehold.Clean = value; _numberofPeopleInHousehold = numberofPeopleInHousehold;
                var obligationMatchesCommitmentLenderRequestIndicator = _obligationMatchesCommitmentLenderRequestIndicator; obligationMatchesCommitmentLenderRequestIndicator.Clean = value; _obligationMatchesCommitmentLenderRequestIndicator = obligationMatchesCommitmentLenderRequestIndicator;
                var officialWhoConfirmedGlsUpdated = _officialWhoConfirmedGlsUpdated; officialWhoConfirmedGlsUpdated.Clean = value; _officialWhoConfirmedGlsUpdated = officialWhoConfirmedGlsUpdated;
                var otherIncome = _otherIncome; otherIncome.Clean = value; _otherIncome = otherIncome;
                var otherStableDependableMonthlyIncome = _otherStableDependableMonthlyIncome; otherStableDependableMonthlyIncome.Clean = value; _otherStableDependableMonthlyIncome = otherStableDependableMonthlyIncome;
                var overcrowdedIndicator = _overcrowdedIndicator; overcrowdedIndicator.Clean = value; _overcrowdedIndicator = overcrowdedIndicator;
                var percentofLoanGuaranteed = _percentofLoanGuaranteed; percentofLoanGuaranteed.Clean = value; _percentofLoanGuaranteed = percentofLoanGuaranteed;
                var periodOperatingLineCreditYearsType = _periodOperatingLineCreditYearsType; periodOperatingLineCreditYearsType.Clean = value; _periodOperatingLineCreditYearsType = periodOperatingLineCreditYearsType;
                var physicallyDeterioratedIndicator = _physicallyDeterioratedIndicator; physicallyDeterioratedIndicator.Clean = value; _physicallyDeterioratedIndicator = physicallyDeterioratedIndicator;
                var preparedByName = _preparedByName; preparedByName.Clean = value; _preparedByName = preparedByName;
                var preparedByTitle = _preparedByTitle; preparedByTitle.Clean = value; _preparedByTitle = preparedByTitle;
                var presentLandloardAddress = _presentLandloardAddress; presentLandloardAddress.Clean = value; _presentLandloardAddress = presentLandloardAddress;
                var presentLandloardCity = _presentLandloardCity; presentLandloardCity.Clean = value; _presentLandloardCity = presentLandloardCity;
                var presentLandloardName = _presentLandloardName; presentLandloardName.Clean = value; _presentLandloardName = presentLandloardName;
                var presentLandloardPhone = _presentLandloardPhone; presentLandloardPhone.Clean = value; _presentLandloardPhone = presentLandloardPhone;
                var presentLandloardState = _presentLandloardState; presentLandloardState.Clean = value; _presentLandloardState = presentLandloardState;
                var presentLandloardZip = _presentLandloardZip; presentLandloardZip.Clean = value; _presentLandloardZip = presentLandloardZip;
                var previousLandloardAddress = _previousLandloardAddress; previousLandloardAddress.Clean = value; _previousLandloardAddress = previousLandloardAddress;
                var previousLandloardCity = _previousLandloardCity; previousLandloardCity.Clean = value; _previousLandloardCity = previousLandloardCity;
                var previousLandloardName = _previousLandloardName; previousLandloardName.Clean = value; _previousLandloardName = previousLandloardName;
                var previousLandloardPhone = _previousLandloardPhone; previousLandloardPhone.Clean = value; _previousLandloardPhone = previousLandloardPhone;
                var previousLandloardState = _previousLandloardState; previousLandloardState.Clean = value; _previousLandloardState = previousLandloardState;
                var previousLandloardZip = _previousLandloardZip; previousLandloardZip.Clean = value; _previousLandloardZip = previousLandloardZip;
                var purchaseOrRefinancedAmount = _purchaseOrRefinancedAmount; purchaseOrRefinancedAmount.Clean = value; _purchaseOrRefinancedAmount = purchaseOrRefinancedAmount;
                var purchaseOrRefinanceDescription = _purchaseOrRefinanceDescription; purchaseOrRefinanceDescription.Clean = value; _purchaseOrRefinanceDescription = purchaseOrRefinanceDescription;
                var rdsfhRefinancedLoanIndicatorType = _rdsfhRefinancedLoanIndicatorType; rdsfhRefinancedLoanIndicatorType.Clean = value; _rdsfhRefinancedLoanIndicatorType = rdsfhRefinancedLoanIndicatorType;
                var refinanceLoanIndicator = _refinanceLoanIndicator; refinanceLoanIndicator.Clean = value; _refinanceLoanIndicator = refinanceLoanIndicator;
                var repairOtherAmount = _repairOtherAmount; repairOtherAmount.Clean = value; _repairOtherAmount = repairOtherAmount;
                var repairOtherDescription = _repairOtherDescription; repairOtherDescription.Clean = value; _repairOtherDescription = repairOtherDescription;
                var reservationAmountRequested = _reservationAmountRequested; reservationAmountRequested.Clean = value; _reservationAmountRequested = reservationAmountRequested;
                var reserved = _reserved; reserved.Clean = value; _reserved = reserved;
                var servicingOfficeName = _servicingOfficeName; servicingOfficeName.Clean = value; _servicingOfficeName = servicingOfficeName;
                var sfhglpIndicator = _sfhglpIndicator; sfhglpIndicator.Clean = value; _sfhglpIndicator = sfhglpIndicator;
                var sourceOfFundsType = _sourceOfFundsType; sourceOfFundsType.Clean = value; _sourceOfFundsType = sourceOfFundsType;
                var stableDependableMonthlyIncome = _stableDependableMonthlyIncome; stableDependableMonthlyIncome.Clean = value; _stableDependableMonthlyIncome = stableDependableMonthlyIncome;
                var stableOtherIncomeDesc = _stableOtherIncomeDesc; stableOtherIncomeDesc.Clean = value; _stableOtherIncomeDesc = stableOtherIncomeDesc;
                var submittingLenderAddress = _submittingLenderAddress; submittingLenderAddress.Clean = value; _submittingLenderAddress = submittingLenderAddress;
                var submittingLenderCity = _submittingLenderCity; submittingLenderCity.Clean = value; _submittingLenderCity = submittingLenderCity;
                var submittingLenderContactFax = _submittingLenderContactFax; submittingLenderContactFax.Clean = value; _submittingLenderContactFax = submittingLenderContactFax;
                var submittingLenderContactName = _submittingLenderContactName; submittingLenderContactName.Clean = value; _submittingLenderContactName = submittingLenderContactName;
                var submittingLenderContactPhone = _submittingLenderContactPhone; submittingLenderContactPhone.Clean = value; _submittingLenderContactPhone = submittingLenderContactPhone;
                var submittingLenderName = _submittingLenderName; submittingLenderName.Clean = value; _submittingLenderName = submittingLenderName;
                var submittingLenderState = _submittingLenderState; submittingLenderState.Clean = value; _submittingLenderState = submittingLenderState;
                var submittingLenderTaxId = _submittingLenderTaxId; submittingLenderTaxId.Clean = value; _submittingLenderTaxId = submittingLenderTaxId;
                var submittingLenderZip = _submittingLenderZip; submittingLenderZip.Clean = value; _submittingLenderZip = submittingLenderZip;
                var termOfBuydown = _termOfBuydown; termOfBuydown.Clean = value; _termOfBuydown = termOfBuydown;
                var thirdPartyOriginator = _thirdPartyOriginator; thirdPartyOriginator.Clean = value; _thirdPartyOriginator = thirdPartyOriginator;
                var title = _title; title.Clean = value; _title = title;
                var totalBorrowerStableBaseIncome = _totalBorrowerStableBaseIncome; totalBorrowerStableBaseIncome.Clean = value; _totalBorrowerStableBaseIncome = totalBorrowerStableBaseIncome;
                var totalBorrowerStableOtherIncome = _totalBorrowerStableOtherIncome; totalBorrowerStableOtherIncome.Clean = value; _totalBorrowerStableOtherIncome = totalBorrowerStableOtherIncome;
                var totalHouseholdDeduction = _totalHouseholdDeduction; totalHouseholdDeduction.Clean = value; _totalHouseholdDeduction = totalHouseholdDeduction;
                var totalRequestAmount = _totalRequestAmount; totalRequestAmount.Clean = value; _totalRequestAmount = totalRequestAmount;
                var tpoTaxId = _tpoTaxId; tpoTaxId.Clean = value; _tpoTaxId = tpoTaxId;
                var underwritingDecisionBy = _underwritingDecisionBy; underwritingDecisionBy.Clean = value; _underwritingDecisionBy = underwritingDecisionBy;
                var underwritingDecisionDate = _underwritingDecisionDate; underwritingDecisionDate.Clean = value; _underwritingDecisionDate = underwritingDecisionDate;
                var underwritingDecisionType = _underwritingDecisionType; underwritingDecisionType.Clean = value; _underwritingDecisionType = underwritingDecisionType;
                var usdaHouseholdIncomes = _usdaHouseholdIncomes; usdaHouseholdIncomes.Clean = value; _usdaHouseholdIncomes = usdaHouseholdIncomes;
                var verificationCode = _verificationCode; verificationCode.Clean = value; _verificationCode = verificationCode;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Usda()
        {
            Clean = true;
        }
    }
}