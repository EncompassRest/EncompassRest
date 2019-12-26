using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Usda
    /// </summary>
    public sealed partial class Usda : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _additionalMemberBaseIncome;
        private DirtyValue<string?>? _adjustedIncomeCalculationDescription1;
        private DirtyValue<string?>? _adjustedIncomeCalculationDescription2;
        private DirtyValue<string?>? _adjustedIncomeCalculationDescription3;
        private DirtyValue<decimal?>? _advanceAmountToDate;
        private DirtyValue<decimal?>? _amountLoanlineCredit;
        private DirtyValue<decimal?>? _annualChildCareExpenses;
        private DirtyValue<string?>? _annualIncomeCalculationDescription1;
        private DirtyValue<string?>? _annualIncomeCalculationDescription2;
        private DirtyValue<string?>? _annualIncomeCalculationDescription3;
        private DirtyValue<string?>? _annualIncomeCalculationDescription4;
        private DirtyValue<string?>? _annualIncomeCalculationDescription5;
        private DirtyValue<DateTime?>? _annualReviewDate;
        private DirtyValue<string?>? _applicationNumber;
        private DirtyValue<string?>? _approvedLenderTaxId;
        private DirtyValue<decimal?>? _balanceOwedOnLoan;
        private DirtyValue<decimal?>? _borrowerTotalStableIncome;
        private DirtyValue<StringEnumValue<BorrowerTypeCode>>? _borrowerTypeCode;
        private DirtyValue<decimal?>? _buydownInterestAssistanceRate;
        private DirtyValue<string?>? _caseNumberBorrowerId;
        private DirtyValue<string?>? _caseNumberCo;
        private DirtyValue<string?>? _caseNumberSt;
        private DirtyValue<DateTime?>? _certificationEffectiveDate;
        private DirtyValue<DateTime?>? _certificationExpirationDate;
        private DirtyValue<bool?>? _certifiedLoanIndicator;
        private DirtyValue<string?>? _childCareProviderAddress;
        private DirtyValue<string?>? _childCareProviderCity;
        private DirtyValue<string?>? _childCareProviderPhone;
        private DirtyValue<string?>? _childCareProviderProviderName;
        private DirtyValue<StringEnumValue<State>>? _childCareProviderState;
        private DirtyValue<string?>? _childCareProviderZip;
        private DirtyValue<decimal?>? _childCostPerMonth;
        private DirtyValue<decimal?>? _childCostPerWeek;
        private DirtyValue<decimal?>? _coborrowerStableBaseIncome;
        private DirtyValue<string?>? _coborrowerStableBaseIncomeDesc;
        private DirtyValue<decimal?>? _coborrowerStableOtherIncome;
        private DirtyValue<string?>? _coborrowerStableOtherIncomeDesc;
        private DirtyValue<decimal?>? _coBorrowerTotalStableIncome;
        private DirtyValue<DateTime?>? _dateConfirmedObligationProcessed;
        private DirtyValue<DateTime?>? _dateLoanNoteGuaranteeIssued;
        private DirtyValue<DateTime?>? _dateLoanNoteGuaranteeRequestReceived;
        private DirtyValue<DateTime?>? _dateObligationInGls;
        private DirtyValue<DateTime?>? _dateVerifiedInUnifi;
        private DirtyValue<decimal?>? _dependentDeduction;
        private DirtyValue<decimal?>? _disabilityDeduction;
        private DirtyValue<decimal?>? _elderlyHouseholdDeduction;
        private DirtyValue<decimal?>? _feeRate;
        private DirtyValue<string?>? _financedLoanClosingCostDescription;
        private DirtyValue<decimal?>? _financedLoanClosingCosts;
        private DirtyValue<decimal?>? _guaranteeFeeCollected;
        private DirtyValue<decimal?>? _guaranteeFeeOnCommitment;
        private DirtyValue<StringEnumValue<GuaranteeFeePurposeCodeType>>? _guaranteeFeePurposeCodeType;
        private DirtyValue<DateTime?>? _guaranteePeriodBeginsDate;
        private DirtyValue<DateTime?>? _guaranteePeriodEndsDate;
        private DirtyValue<StringEnumValue<GuaranteeType>>? _guaranteeType;
        private DirtyValue<int?>? _householdSize;
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<InterestAssistanceCodeType>>? _interestAssistanceCodeType;
        private DirtyValue<bool?>? _interestRateBasedonFannieIndicator;
        private DirtyValue<StringEnumValue<InterestRateCodeType>>? _interestRateCodeType;
        private DirtyValue<bool?>? _interestRateFloatToLoanClosingIndicator;
        private DirtyValue<bool?>? _lackAdequateHeatIndicator;
        private DirtyValue<string?>? _lenderAuthorizedRepCompany;
        private DirtyValue<string?>? _lenderAuthorizedRepName;
        private DirtyValue<string?>? _lenderAuthorizedRepTitle;
        private DirtyValue<string?>? _lenderIdNo;
        private DirtyValue<decimal?>? _lenderNoteRateOnGuaranteedPortion;
        private DirtyValue<decimal?>? _lenderNoteRateOnNonGuaranteedPortion;
        private DirtyValue<StringEnumValue<LenderStatusCodeType>>? _lenderStatusCodeType;
        private DirtyValue<StringEnumValue<LenderTypeCode>>? _lenderTypeCode;
        private DirtyValue<StringEnumValue<UsdaLoanType>>? _loanType;
        private DirtyValue<bool?>? _lockCompletePlumbingIndicator;
        private DirtyValue<decimal?>? _medicalExpenses;
        private DirtyValue<decimal?>? _moderateIncomeLimit;
        private DirtyValue<decimal?>? _monthlyRepaymentIncome;
        private DirtyValue<int?>? _numberofDependents;
        private DirtyValue<int?>? _numberofPeopleInHousehold;
        private DirtyValue<bool?>? _obligationMatchesCommitmentLenderRequestIndicator;
        private DirtyValue<string?>? _officialWhoConfirmedGlsUpdated;
        private DirtyValue<decimal?>? _otherIncome;
        private DirtyValue<decimal?>? _otherStableDependableMonthlyIncome;
        private DirtyValue<bool?>? _overcrowdedIndicator;
        private DirtyValue<decimal?>? _percentofLoanGuaranteed;
        private DirtyValue<StringEnumValue<PeriodOperatingLineCreditYearsType>>? _periodOperatingLineCreditYearsType;
        private DirtyValue<bool?>? _physicallyDeterioratedIndicator;
        private DirtyValue<string?>? _preparedByName;
        private DirtyValue<string?>? _preparedByTitle;
        private DirtyValue<string?>? _presentLandloardAddress;
        private DirtyValue<string?>? _presentLandloardCity;
        private DirtyValue<string?>? _presentLandloardName;
        private DirtyValue<string?>? _presentLandloardPhone;
        private DirtyValue<StringEnumValue<State>>? _presentLandloardState;
        private DirtyValue<string?>? _presentLandloardZip;
        private DirtyValue<string?>? _previousLandloardAddress;
        private DirtyValue<string?>? _previousLandloardCity;
        private DirtyValue<string?>? _previousLandloardName;
        private DirtyValue<string?>? _previousLandloardPhone;
        private DirtyValue<StringEnumValue<State>>? _previousLandloardState;
        private DirtyValue<string?>? _previousLandloardZip;
        private DirtyValue<decimal?>? _purchaseOrRefinancedAmount;
        private DirtyValue<string?>? _purchaseOrRefinanceDescription;
        private DirtyValue<StringEnumValue<RdsfhRefinancedLoanIndicatorType>>? _rdsfhRefinancedLoanIndicatorType;
        private DirtyValue<bool?>? _refinanceLoanIndicator;
        private DirtyValue<StringEnumValue<UsdaRefinanceType>>? _refinanceType;
        private DirtyValue<decimal?>? _repairOtherAmount;
        private DirtyValue<string?>? _repairOtherDescription;
        private DirtyValue<decimal?>? _reservationAmountRequested;
        private DirtyValue<string?>? _reserved;
        private DirtyValue<string?>? _servicingOfficeName;
        private DirtyValue<bool?>? _sfhglpIndicator;
        private DirtyValue<StringEnumValue<SourceOfFundsType>>? _sourceOfFundsType;
        private DirtyValue<decimal?>? _stableDependableMonthlyIncome;
        private DirtyValue<string?>? _stableOtherIncomeDesc;
        private DirtyValue<string?>? _submittingLenderAddress;
        private DirtyValue<string?>? _submittingLenderCity;
        private DirtyValue<string?>? _submittingLenderContactFax;
        private DirtyValue<string?>? _submittingLenderContactName;
        private DirtyValue<string?>? _submittingLenderContactPhone;
        private DirtyValue<string?>? _submittingLenderName;
        private DirtyValue<StringEnumValue<State>>? _submittingLenderState;
        private DirtyValue<string?>? _submittingLenderTaxId;
        private DirtyValue<string?>? _submittingLenderZip;
        private DirtyValue<int?>? _termOfBuydown;
        private DirtyValue<string?>? _thirdPartyOriginator;
        private DirtyValue<string?>? _title;
        private DirtyValue<decimal?>? _totalBorrowerStableBaseIncome;
        private DirtyValue<decimal?>? _totalBorrowerStableOtherIncome;
        private DirtyValue<decimal?>? _totalHouseholdDeduction;
        private DirtyValue<decimal?>? _totalRequestAmount;
        private DirtyValue<string?>? _tpoTaxId;
        private DirtyValue<string?>? _underwritingDecisionBy;
        private DirtyValue<DateTime?>? _underwritingDecisionDate;
        private DirtyValue<StringEnumValue<UnderwritingDecisionType>>? _underwritingDecisionType;
        private DirtyList<UsdaHouseholdIncome>? _usdaHouseholdIncomes;
        private DirtyValue<string?>? _verificationCode;

        /// <summary>
        /// USDA - Additional Adult Household Member(s) (Base Income: Primary Employment from Wages, Salary, self-Employed, Additional income to Primary Employment, Other Income) [USDA.X167]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdditionalMemberBaseIncome { get => _additionalMemberBaseIncome; set => SetField(ref _additionalMemberBaseIncome, value); }

        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 8 [USDA.X214]
        /// </summary>
        public string? AdjustedIncomeCalculationDescription1 { get => _adjustedIncomeCalculationDescription1; set => SetField(ref _adjustedIncomeCalculationDescription1, value); }

        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 10 [USDA.X215]
        /// </summary>
        public string? AdjustedIncomeCalculationDescription2 { get => _adjustedIncomeCalculationDescription2; set => SetField(ref _adjustedIncomeCalculationDescription2, value); }

        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 11 [USDA.X216]
        /// </summary>
        public string? AdjustedIncomeCalculationDescription3 { get => _adjustedIncomeCalculationDescription3; set => SetField(ref _adjustedIncomeCalculationDescription3, value); }

        /// <summary>
        /// USDA - Loan Closing - Advance Amount to Date [USDA.X134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdvanceAmountToDate { get => _advanceAmountToDate; set => SetField(ref _advanceAmountToDate, value); }

        /// <summary>
        /// USDA - Loan Closing - Amount of Loanline of Credit [USDA.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountLoanlineCredit { get => _amountLoanlineCredit; set => SetField(ref _amountLoanlineCredit, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Annual Child Care Expenses [USDA.X173]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualChildCareExpenses { get => _annualChildCareExpenses; set => SetField(ref _annualChildCareExpenses, value); }

        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 1 [USDA.X209]
        /// </summary>
        public string? AnnualIncomeCalculationDescription1 { get => _annualIncomeCalculationDescription1; set => SetField(ref _annualIncomeCalculationDescription1, value); }

        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 2 [USDA.X210]
        /// </summary>
        public string? AnnualIncomeCalculationDescription2 { get => _annualIncomeCalculationDescription2; set => SetField(ref _annualIncomeCalculationDescription2, value); }

        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 3 [USDA.X211]
        /// </summary>
        public string? AnnualIncomeCalculationDescription3 { get => _annualIncomeCalculationDescription3; set => SetField(ref _annualIncomeCalculationDescription3, value); }

        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 4 [USDA.X212]
        /// </summary>
        public string? AnnualIncomeCalculationDescription4 { get => _annualIncomeCalculationDescription4; set => SetField(ref _annualIncomeCalculationDescription4, value); }

        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 5 [USDA.X213]
        /// </summary>
        public string? AnnualIncomeCalculationDescription5 { get => _annualIncomeCalculationDescription5; set => SetField(ref _annualIncomeCalculationDescription5, value); }

        /// <summary>
        /// USDA - Loan Closing - Annual Review Date [USDA.X147]
        /// </summary>
        public DateTime? AnnualReviewDate { get => _annualReviewDate; set => SetField(ref _annualReviewDate, value); }

        /// <summary>
        /// USDA - Application Number [USDA.X29]
        /// </summary>
        public string? ApplicationNumber { get => _applicationNumber; set => SetField(ref _applicationNumber, value); }

        /// <summary>
        /// USDA - Approved Lender Tax ID No [USDA.X25]
        /// </summary>
        public string? ApprovedLenderTaxId { get => _approvedLenderTaxId; set => SetField(ref _approvedLenderTaxId, value); }

        /// <summary>
        /// USDA - Loan Closing - Balance Owed On Loan [USDA.X144]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BalanceOwedOnLoan { get => _balanceOwedOnLoan; set => SetField(ref _balanceOwedOnLoan, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Borrower Total Stable Income [USDA.X201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerTotalStableIncome { get => _borrowerTotalStableIncome; set => SetField(ref _borrowerTotalStableIncome, value); }

        /// <summary>
        /// USDA - Loan Closing - Borrower Type Code [USDA.X123]
        /// </summary>
        public StringEnumValue<BorrowerTypeCode> BorrowerTypeCode { get => _borrowerTypeCode; set => SetField(ref _borrowerTypeCode, value); }

        /// <summary>
        /// USDA - Loan Closing - Buydown / Interest Assistance Rate [USDA.X139]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BuydownInterestAssistanceRate { get => _buydownInterestAssistanceRate; set => SetField(ref _buydownInterestAssistanceRate, value); }

        /// <summary>
        /// USDA - Case Number - Borrower ID [USDA.X122]
        /// </summary>
        public string? CaseNumberBorrowerId { get => _caseNumberBorrowerId; set => SetField(ref _caseNumberBorrowerId, value); }

        /// <summary>
        /// USDA - Case Number - CO [USDA.X121]
        /// </summary>
        public string? CaseNumberCo { get => _caseNumberCo; set => SetField(ref _caseNumberCo, value); }

        /// <summary>
        /// USDA - Case Number - ST [USDA.X120]
        /// </summary>
        public string? CaseNumberSt { get => _caseNumberSt; set => SetField(ref _caseNumberSt, value); }

        /// <summary>
        /// USDA - Loan Closing - Certification Effective Date [USDA.X126]
        /// </summary>
        public DateTime? CertificationEffectiveDate { get => _certificationEffectiveDate; set => SetField(ref _certificationEffectiveDate, value); }

        /// <summary>
        /// USDA - Loan Closing - Certification Expiration Date [USDA.X127]
        /// </summary>
        public DateTime? CertificationExpirationDate { get => _certificationExpirationDate; set => SetField(ref _certificationExpirationDate, value); }

        /// <summary>
        /// USDA - Loan Closing - Certified Loan [USDA.X148]
        /// </summary>
        public bool? CertifiedLoanIndicator { get => _certifiedLoanIndicator; set => SetField(ref _certifiedLoanIndicator, value); }

        /// <summary>
        /// USDA - Child Care Provider - Address [USDA.X99]
        /// </summary>
        public string? ChildCareProviderAddress { get => _childCareProviderAddress; set => SetField(ref _childCareProviderAddress, value); }

        /// <summary>
        /// USDA - Child Care Provider - City [USDA.X100]
        /// </summary>
        public string? ChildCareProviderCity { get => _childCareProviderCity; set => SetField(ref _childCareProviderCity, value); }

        /// <summary>
        /// USDA - Child Care Provider - Phone Number [USDA.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? ChildCareProviderPhone { get => _childCareProviderPhone; set => SetField(ref _childCareProviderPhone, value); }

        /// <summary>
        /// USDA - Child Care Provider - Name [USDA.X98]
        /// </summary>
        public string? ChildCareProviderProviderName { get => _childCareProviderProviderName; set => SetField(ref _childCareProviderProviderName, value); }

        /// <summary>
        /// USDA - Child Care Provider - State [USDA.X101]
        /// </summary>
        public StringEnumValue<State> ChildCareProviderState { get => _childCareProviderState; set => SetField(ref _childCareProviderState, value); }

        /// <summary>
        /// USDA - Child Care Provider - Zip [USDA.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? ChildCareProviderZip { get => _childCareProviderZip; set => SetField(ref _childCareProviderZip, value); }

        /// <summary>
        /// USDA - Child Care Cost Per Month [USDA.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ChildCostPerMonth { get => _childCostPerMonth; set => SetField(ref _childCostPerMonth, value); }

        /// <summary>
        /// USDA - Child Care Cost Per Week [USDA.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ChildCostPerWeek { get => _childCostPerWeek; set => SetField(ref _childCostPerWeek, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Co-Borrower Stable Dependable Monthly Income (parties to note only) [USDA.X202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CoborrowerStableBaseIncome { get => _coborrowerStableBaseIncome; set => SetField(ref _coborrowerStableBaseIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Coborrower Calculation of Base Income Description [USDA.X203]
        /// </summary>
        public string? CoborrowerStableBaseIncomeDesc { get => _coborrowerStableBaseIncomeDesc; set => SetField(ref _coborrowerStableBaseIncomeDesc, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Co-Borrower Other Stable Dependable Monthly Income (parties to note only) [USDA.X204]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CoborrowerStableOtherIncome { get => _coborrowerStableOtherIncome; set => SetField(ref _coborrowerStableOtherIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Coborrower Calculation of Other Income Description [USDA.X205]
        /// </summary>
        public string? CoborrowerStableOtherIncomeDesc { get => _coborrowerStableOtherIncomeDesc; set => SetField(ref _coborrowerStableOtherIncomeDesc, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - CoBorrower Total Stable Income [USDA.X206]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? CoBorrowerTotalStableIncome { get => _coBorrowerTotalStableIncome; set => SetField(ref _coBorrowerTotalStableIncome, value); }

        /// <summary>
        /// USDA - Tracking - Date Confirmed Obligation Processed [USDA.X154]
        /// </summary>
        public DateTime? DateConfirmedObligationProcessed { get => _dateConfirmedObligationProcessed; set => SetField(ref _dateConfirmedObligationProcessed, value); }

        /// <summary>
        /// USDA - Tracking - Date Loan Note Guarantee Issued [USDA.X159]
        /// </summary>
        public DateTime? DateLoanNoteGuaranteeIssued { get => _dateLoanNoteGuaranteeIssued; set => SetField(ref _dateLoanNoteGuaranteeIssued, value); }

        /// <summary>
        /// USDA - Tracking - DateLoan Note Guarantee Request Received [USDA.X157]
        /// </summary>
        public DateTime? DateLoanNoteGuaranteeRequestReceived { get => _dateLoanNoteGuaranteeRequestReceived; set => SetField(ref _dateLoanNoteGuaranteeRequestReceived, value); }

        /// <summary>
        /// USDA - Tracking - Date of Obligation in GLS [USDA.X153]
        /// </summary>
        public DateTime? DateObligationInGls { get => _dateObligationInGls; set => SetField(ref _dateObligationInGls, value); }

        /// <summary>
        /// USDA - Tracking - Date Verified in Unifi [USDA.X162]
        /// </summary>
        public DateTime? DateVerifiedInUnifi { get => _dateVerifiedInUnifi; set => SetField(ref _dateVerifiedInUnifi, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Dependent Deduction [USDA.X172]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DependentDeduction { get => _dependentDeduction; set => SetField(ref _dependentDeduction, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Disability Deduction [USDA.X175]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DisabilityDeduction { get => _disabilityDeduction; set => SetField(ref _disabilityDeduction, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Elderly Household Deduction [USDA.X174]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ElderlyHouseholdDeduction { get => _elderlyHouseholdDeduction; set => SetField(ref _elderlyHouseholdDeduction, value); }

        /// <summary>
        /// USDA - Loan Closing - Fee Rate [USDA.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FeeRate { get => _feeRate; set => SetField(ref _feeRate, value); }

        /// <summary>
        /// USDA - Financed Loan Closing Cost Description [USDA.X21]
        /// </summary>
        public string? FinancedLoanClosingCostDescription { get => _financedLoanClosingCostDescription; set => SetField(ref _financedLoanClosingCostDescription, value); }

        /// <summary>
        /// USDA - Financed Loan Closing Costs [USDA.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinancedLoanClosingCosts { get => _financedLoanClosingCosts; set => SetField(ref _financedLoanClosingCosts, value); }

        /// <summary>
        /// USDA - Tracking - Guarantee Fee Collected [USDA.X160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? GuaranteeFeeCollected { get => _guaranteeFeeCollected; set => SetField(ref _guaranteeFeeCollected, value); }

        /// <summary>
        /// USDA - Tracking - Guarantee Fee On Commitment [USDA.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? GuaranteeFeeOnCommitment { get => _guaranteeFeeOnCommitment; set => SetField(ref _guaranteeFeeOnCommitment, value); }

        /// <summary>
        /// USDA - Loan Closing - Guarantee Fee Purpose Code [USDA.X130]
        /// </summary>
        public StringEnumValue<GuaranteeFeePurposeCodeType> GuaranteeFeePurposeCodeType { get => _guaranteeFeePurposeCodeType; set => SetField(ref _guaranteeFeePurposeCodeType, value); }

        /// <summary>
        /// USDA - Loan Closing - Date Guarantee Period Begins [USDA.X145]
        /// </summary>
        public DateTime? GuaranteePeriodBeginsDate { get => _guaranteePeriodBeginsDate; set => SetField(ref _guaranteePeriodBeginsDate, value); }

        /// <summary>
        /// USDA - Loan Closing - Date Guarantee Period Ends [USDA.X146]
        /// </summary>
        public DateTime? GuaranteePeriodEndsDate { get => _guaranteePeriodEndsDate; set => SetField(ref _guaranteePeriodEndsDate, value); }

        /// <summary>
        /// USDA - Loan Closing - Type of Guarantee [USDA.X142]
        /// </summary>
        public StringEnumValue<GuaranteeType> GuaranteeType { get => _guaranteeType; set => SetField(ref _guaranteeType, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Household Size [USDA.X179]
        /// </summary>
        public int? HouseholdSize { get => _householdSize; set => SetField(ref _householdSize, value); }

        /// <summary>
        /// Usda Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// USDA - Loan Closing - Interest Assistance Code [USDA.X129]
        /// </summary>
        public StringEnumValue<InterestAssistanceCodeType> InterestAssistanceCodeType { get => _interestAssistanceCodeType; set => SetField(ref _interestAssistanceCodeType, value); }

        /// <summary>
        /// USDA - Is Interest Rate Based on Fannie Mae [USDA.X18]
        /// </summary>
        public bool? InterestRateBasedonFannieIndicator { get => _interestRateBasedonFannieIndicator; set => SetField(ref _interestRateBasedonFannieIndicator, value); }

        /// <summary>
        /// USDA - Loan Closing - Interest Rate Code [USDA.X143]
        /// </summary>
        public StringEnumValue<InterestRateCodeType> InterestRateCodeType { get => _interestRateCodeType; set => SetField(ref _interestRateCodeType, value); }

        /// <summary>
        /// USDA - Is Interest Rate Based on Fannie Mae - Interest Rate will Float Until Loan Closing [USDA.X19]
        /// </summary>
        public bool? InterestRateFloatToLoanClosingIndicator { get => _interestRateFloatToLoanClosingIndicator; set => SetField(ref _interestRateFloatToLoanClosingIndicator, value); }

        /// <summary>
        /// USDA - Characteristics Present Housing - Lack Adequate Heat Indicator [USDA.X105]
        /// </summary>
        public bool? LackAdequateHeatIndicator { get => _lackAdequateHeatIndicator; set => SetField(ref _lackAdequateHeatIndicator, value); }

        /// <summary>
        /// USDA - Lender's Authorized Representative Company Name [USDA.X32]
        /// </summary>
        public string? LenderAuthorizedRepCompany { get => _lenderAuthorizedRepCompany; set => SetField(ref _lenderAuthorizedRepCompany, value); }

        /// <summary>
        /// USDA - Lender's Authorized Representative Name [USDA.X31]
        /// </summary>
        public string? LenderAuthorizedRepName { get => _lenderAuthorizedRepName; set => SetField(ref _lenderAuthorizedRepName, value); }

        /// <summary>
        /// USDA - Lender's Authorized Representative Title [USDA.X30]
        /// </summary>
        public string? LenderAuthorizedRepTitle { get => _lenderAuthorizedRepTitle; set => SetField(ref _lenderAuthorizedRepTitle, value); }

        /// <summary>
        /// USDA - Loan Closing - Lender ID No [USDA.X186]
        /// </summary>
        public string? LenderIdNo { get => _lenderIdNo; set => SetField(ref _lenderIdNo, value); }

        /// <summary>
        /// USDA - Loan Closing - Lender's Note Interest Rate On Guaranteed Portion [USDA.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LenderNoteRateOnGuaranteedPortion { get => _lenderNoteRateOnGuaranteedPortion; set => SetField(ref _lenderNoteRateOnGuaranteedPortion, value); }

        /// <summary>
        /// USDA - Loan Closing - Lender's Note Interest Rate On Non-Guaranteed Portion [USDA.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LenderNoteRateOnNonGuaranteedPortion { get => _lenderNoteRateOnNonGuaranteedPortion; set => SetField(ref _lenderNoteRateOnNonGuaranteedPortion, value); }

        /// <summary>
        /// USDA - Loan Closing - Lender Status Code [USDA.X124]
        /// </summary>
        public StringEnumValue<LenderStatusCodeType> LenderStatusCodeType { get => _lenderStatusCodeType; set => SetField(ref _lenderStatusCodeType, value); }

        /// <summary>
        /// USDA - Loan Closing - Lender Type Code [USDA.X125]
        /// </summary>
        public StringEnumValue<LenderTypeCode> LenderTypeCode { get => _lenderTypeCode; set => SetField(ref _lenderTypeCode, value); }

        /// <summary>
        /// USDA - Loan Type [USDA.X43]
        /// </summary>
        public StringEnumValue<UsdaLoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

        /// <summary>
        /// USDA - Characteristics Present Housing - Lock Complete Plumbing Indicator [USDA.X104]
        /// </summary>
        public bool? LockCompletePlumbingIndicator { get => _lockCompletePlumbingIndicator; set => SetField(ref _lockCompletePlumbingIndicator, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Medical Expenses [USDA.X176]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MedicalExpenses { get => _medicalExpenses; set => SetField(ref _medicalExpenses, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Moderate Income Limit [USDA.X180]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ModerateIncomeLimit { get => _moderateIncomeLimit; set => SetField(ref _moderateIncomeLimit, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Monthly Repayment Income [USDA.X184]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyRepaymentIncome { get => _monthlyRepaymentIncome; set => SetField(ref _monthlyRepaymentIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Number of Dependent for Deduction (child under age 18, or full-time student) [USDA.X185]
        /// </summary>
        public int? NumberofDependents { get => _numberofDependents; set => SetField(ref _numberofDependents, value); }

        /// <summary>
        /// USDA - Number of people in household [USDA.X9]
        /// </summary>
        public int? NumberofPeopleInHousehold { get => _numberofPeopleInHousehold; set => SetField(ref _numberofPeopleInHousehold, value); }

        /// <summary>
        /// USDA - Tracking - Obligation Matches Commitment and Lender Request [USDA.X156]
        /// </summary>
        public bool? ObligationMatchesCommitmentLenderRequestIndicator { get => _obligationMatchesCommitmentLenderRequestIndicator; set => SetField(ref _obligationMatchesCommitmentLenderRequestIndicator, value); }

        /// <summary>
        /// USDA - Tracking - Official Who Confirmed GLS Updated [USDA.X155]
        /// </summary>
        public string? OfficialWhoConfirmedGlsUpdated { get => _officialWhoConfirmedGlsUpdated; set => SetField(ref _officialWhoConfirmedGlsUpdated, value); }

        /// <summary>
        /// USDA - Other Income (Alimony, Child Support, y, Pension/Retirement, Social Security, Disability, Trust Income, Notes Receivable, etc.) [USDA.X169]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherIncome { get => _otherIncome; set => SetField(ref _otherIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Other Stable Dependable Monthly Income (parties to note only) [USDA.X183]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherStableDependableMonthlyIncome { get => _otherStableDependableMonthlyIncome; set => SetField(ref _otherStableDependableMonthlyIncome, value); }

        /// <summary>
        /// USDA - Characteristics Present Housing - Overcrowded Indicator [USDA.X107]
        /// </summary>
        public bool? OvercrowdedIndicator { get => _overcrowdedIndicator; set => SetField(ref _overcrowdedIndicator, value); }

        /// <summary>
        /// USDA - Loan Closing - Percent of Loan Guaranteed [USDA.X199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PercentofLoanGuaranteed { get => _percentofLoanGuaranteed; set => SetField(ref _percentofLoanGuaranteed, value); }

        /// <summary>
        /// USDA - Loan Closing - Period of Operating Line of Credit Years [USDA.X140]
        /// </summary>
        public StringEnumValue<PeriodOperatingLineCreditYearsType> PeriodOperatingLineCreditYearsType { get => _periodOperatingLineCreditYearsType; set => SetField(ref _periodOperatingLineCreditYearsType, value); }

        /// <summary>
        /// USDA - Characteristics Present Housing - Physically Deteriorated or Structurally Unsound Indicator [USDA.X106]
        /// </summary>
        public bool? PhysicallyDeterioratedIndicator { get => _physicallyDeterioratedIndicator; set => SetField(ref _physicallyDeterioratedIndicator, value); }

        /// <summary>
        /// USDA - Annual and Repayment Income Worksheet Prepared By Name [USDA.X196]
        /// </summary>
        public string? PreparedByName { get => _preparedByName; set => SetField(ref _preparedByName, value); }

        /// <summary>
        /// USDA -  Annual and Repayment Income Worksheet Prepared By Title [USDA.X197]
        /// </summary>
        public string? PreparedByTitle { get => _preparedByTitle; set => SetField(ref _preparedByTitle, value); }

        /// <summary>
        /// USDA - Present Landloard - Address [USDA.X109]
        /// </summary>
        public string? PresentLandloardAddress { get => _presentLandloardAddress; set => SetField(ref _presentLandloardAddress, value); }

        /// <summary>
        /// USDA - Present Landloard - City [USDA.X110]
        /// </summary>
        public string? PresentLandloardCity { get => _presentLandloardCity; set => SetField(ref _presentLandloardCity, value); }

        /// <summary>
        /// USDA - Present Landloard - Name [USDA.X108]
        /// </summary>
        public string? PresentLandloardName { get => _presentLandloardName; set => SetField(ref _presentLandloardName, value); }

        /// <summary>
        /// USDA - Present Landloard - Phone Number [USDA.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? PresentLandloardPhone { get => _presentLandloardPhone; set => SetField(ref _presentLandloardPhone, value); }

        /// <summary>
        /// USDA - Present Landloard - State [USDA.X111]
        /// </summary>
        public StringEnumValue<State> PresentLandloardState { get => _presentLandloardState; set => SetField(ref _presentLandloardState, value); }

        /// <summary>
        /// USDA - Present Landloard - Zip [USDA.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PresentLandloardZip { get => _presentLandloardZip; set => SetField(ref _presentLandloardZip, value); }

        /// <summary>
        /// USDA - Previous Landloard - Address [USDA.X115]
        /// </summary>
        public string? PreviousLandloardAddress { get => _previousLandloardAddress; set => SetField(ref _previousLandloardAddress, value); }

        /// <summary>
        /// USDA - Previous Landloard - City [USDA.X116]
        /// </summary>
        public string? PreviousLandloardCity { get => _previousLandloardCity; set => SetField(ref _previousLandloardCity, value); }

        /// <summary>
        /// USDA - Previous Landloard - Name [USDA.X114]
        /// </summary>
        public string? PreviousLandloardName { get => _previousLandloardName; set => SetField(ref _previousLandloardName, value); }

        /// <summary>
        /// USDA - Previous Landloard - Phone Number [USDA.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? PreviousLandloardPhone { get => _previousLandloardPhone; set => SetField(ref _previousLandloardPhone, value); }

        /// <summary>
        /// USDA - Previous Landloard - State [USDA.X117]
        /// </summary>
        public StringEnumValue<State> PreviousLandloardState { get => _previousLandloardState; set => SetField(ref _previousLandloardState, value); }

        /// <summary>
        /// USDA - Previous Landloard - Zip [USDA.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? PreviousLandloardZip { get => _previousLandloardZip; set => SetField(ref _previousLandloardZip, value); }

        /// <summary>
        /// USDA - Purchase or Refinanced Amount [USDA.X198]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PurchaseOrRefinancedAmount { get => _purchaseOrRefinancedAmount; set => SetField(ref _purchaseOrRefinancedAmount, value); }

        /// <summary>
        /// USDA - Purchase / Refinance Description [USDA.X20]
        /// </summary>
        public string? PurchaseOrRefinanceDescription { get => _purchaseOrRefinanceDescription; set => SetField(ref _purchaseOrRefinanceDescription, value); }

        /// <summary>
        /// USDA - RD SFH Refinance Loan Indicator [USDA.X8]
        /// </summary>
        public StringEnumValue<RdsfhRefinancedLoanIndicatorType> RdsfhRefinancedLoanIndicatorType { get => _rdsfhRefinancedLoanIndicatorType; set => SetField(ref _rdsfhRefinancedLoanIndicatorType, value); }

        /// <summary>
        /// USDA Refinance Loan Indicator [USDA.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? RefinanceLoanIndicator { get => _refinanceLoanIndicator; set => SetField(ref _refinanceLoanIndicator, value); }

        /// <summary>
        /// USDA - Refinance Type [USDA.X218]
        /// </summary>
        public StringEnumValue<UsdaRefinanceType> RefinanceType { get => _refinanceType; set => SetField(ref _refinanceType, value); }

        /// <summary>
        /// USDA - Repair / Other Amount [USDA.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RepairOtherAmount { get => _repairOtherAmount; set => SetField(ref _repairOtherAmount, value); }

        /// <summary>
        /// USDA - Repair / Other Description [USDA.X23]
        /// </summary>
        public string? RepairOtherDescription { get => _repairOtherDescription; set => SetField(ref _repairOtherDescription, value); }

        /// <summary>
        /// USDA - Reservation Amount Requested [USDA.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReservationAmountRequested { get => _reservationAmountRequested; set => SetField(ref _reservationAmountRequested, value); }

        /// <summary>
        /// USDA - Loan Closing - Reserved [USDA.X141]
        /// </summary>
        public string? Reserved { get => _reserved; set => SetField(ref _reserved, value); }

        /// <summary>
        /// USDA - Loan Closing - Servicing Office [USDA.X128]
        /// </summary>
        public string? ServicingOfficeName { get => _servicingOfficeName; set => SetField(ref _servicingOfficeName, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Applicants Eligible for SFHGLP [USDA.X181]
        /// </summary>
        public bool? SfhglpIndicator { get => _sfhglpIndicator; set => SetField(ref _sfhglpIndicator, value); }

        /// <summary>
        /// USDA - Source of Funds [USDA.X166]
        /// </summary>
        public StringEnumValue<SourceOfFundsType> SourceOfFundsType { get => _sourceOfFundsType; set => SetField(ref _sourceOfFundsType, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Stable Dependable Monthly Income (parties to note only) [USDA.X182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? StableDependableMonthlyIncome { get => _stableDependableMonthlyIncome; set => SetField(ref _stableDependableMonthlyIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Borrower Calculation of Other Income Description [USDA.X200]
        /// </summary>
        public string? StableOtherIncomeDesc { get => _stableOtherIncomeDesc; set => SetField(ref _stableOtherIncomeDesc, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Address [USDA.X36]
        /// </summary>
        public string? SubmittingLenderAddress { get => _submittingLenderAddress; set => SetField(ref _submittingLenderAddress, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - City [USDA.X37]
        /// </summary>
        public string? SubmittingLenderCity { get => _submittingLenderCity; set => SetField(ref _submittingLenderCity, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Contact Fax Number [USDA.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? SubmittingLenderContactFax { get => _submittingLenderContactFax; set => SetField(ref _submittingLenderContactFax, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Contact Name [USDA.X40]
        /// </summary>
        public string? SubmittingLenderContactName { get => _submittingLenderContactName; set => SetField(ref _submittingLenderContactName, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Contact Phone Number [USDA.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? SubmittingLenderContactPhone { get => _submittingLenderContactPhone; set => SetField(ref _submittingLenderContactPhone, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Name [USDA.X34]
        /// </summary>
        public string? SubmittingLenderName { get => _submittingLenderName; set => SetField(ref _submittingLenderName, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - State [USDA.X38]
        /// </summary>
        public StringEnumValue<State> SubmittingLenderState { get => _submittingLenderState; set => SetField(ref _submittingLenderState, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Tax ID No. [USDA.X35]
        /// </summary>
        public string? SubmittingLenderTaxId { get => _submittingLenderTaxId; set => SetField(ref _submittingLenderTaxId, value); }

        /// <summary>
        /// USDA - Submitting Lender Information - Zip [USDA.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? SubmittingLenderZip { get => _submittingLenderZip; set => SetField(ref _submittingLenderZip, value); }

        /// <summary>
        /// USDA - Loan Closing - Term of Buydown / Interest Assistance Years [USDA.X135]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\"}")]
        public int? TermOfBuydown { get => _termOfBuydown; set => SetField(ref _termOfBuydown, value); }

        /// <summary>
        /// USDA - Third Party Originator (TPO) [USDA.X27]
        /// </summary>
        public string? ThirdPartyOriginator { get => _thirdPartyOriginator; set => SetField(ref _thirdPartyOriginator, value); }

        /// <summary>
        /// USDA - Loan Closing - Title [USDA.X149]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Base Income [USDA.X207]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalBorrowerStableBaseIncome { get => _totalBorrowerStableBaseIncome; set => SetField(ref _totalBorrowerStableBaseIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Other Income [USDA.X208]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalBorrowerStableOtherIncome { get => _totalBorrowerStableOtherIncome; set => SetField(ref _totalBorrowerStableOtherIncome, value); }

        /// <summary>
        /// USDA - Annual Adjusted Income - Total Household Deduction [USDA.X177]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalHouseholdDeduction { get => _totalHouseholdDeduction; set => SetField(ref _totalHouseholdDeduction, value); }

        /// <summary>
        /// USDA - Total Request Amount [USDA.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalRequestAmount { get => _totalRequestAmount; set => SetField(ref _totalRequestAmount, value); }

        /// <summary>
        /// USDA - Third Party Originator (TPO) Tax ID No. [USDA.X28]
        /// </summary>
        public string? TpoTaxId { get => _tpoTaxId; set => SetField(ref _tpoTaxId, value); }

        /// <summary>
        /// USDA - Tracking - Underwriting Decision By [USDA.X151]
        /// </summary>
        public string? UnderwritingDecisionBy { get => _underwritingDecisionBy; set => SetField(ref _underwritingDecisionBy, value); }

        /// <summary>
        /// USDA - Tracking - Underwriting Decision Date [USDA.X150]
        /// </summary>
        public DateTime? UnderwritingDecisionDate { get => _underwritingDecisionDate; set => SetField(ref _underwritingDecisionDate, value); }

        /// <summary>
        /// USDA - Tracking - Underwriting Decision [USDA.X152]
        /// </summary>
        public StringEnumValue<UnderwritingDecisionType> UnderwritingDecisionType { get => _underwritingDecisionType; set => SetField(ref _underwritingDecisionType, value); }

        /// <summary>
        /// Usda UsdaHouseholdIncomes
        /// </summary>
        [AllowNull]
        public IList<UsdaHouseholdIncome> UsdaHouseholdIncomes { get => GetField(ref _usdaHouseholdIncomes); set => SetField(ref _usdaHouseholdIncomes, value); }

        /// <summary>
        /// USDA - Tracking - Verification Code [USDA.X163]
        /// </summary>
        public string? VerificationCode { get => _verificationCode; set => SetField(ref _verificationCode, value); }
    }
}