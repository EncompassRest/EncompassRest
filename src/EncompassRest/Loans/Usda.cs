using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Usda
    /// </summary>
    public sealed partial class Usda : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalIncomeFromPrimaryEmployment;
        /// <summary>
        /// USDA - Additional Income to Primary Employment (Commission, Bonus, Overtime, Automobile Allowance, Mortgage Differential, Tips, Military, Secondary Employment, Seasonal Employment, Unemployment) [USDA.X168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Additional Income to Primary Employment (Commission, Bonus, Overtime, Automobile Allowance, Mortgage Differential, Tips, Military, Secondary Employment, Seasonal Employment, Unemployment)")]
        public decimal? AdditionalIncomeFromPrimaryEmployment { get => _additionalIncomeFromPrimaryEmployment; set => _additionalIncomeFromPrimaryEmployment = value; }
        private DirtyValue<decimal?> _additionalMemberBaseIncome;
        /// <summary>
        /// USDA - Additional Adult Household Member(s) (Base Income: Primary Employment from Wages, Salary, self-Employed, Additional income to Primary Employment, Other Income) [USDA.X167]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Additional Adult Household Member(s) (Base Income: Primary Employment from Wages, Salary, self-Employed, Additional income to Primary Employment, Other Income)")]
        public decimal? AdditionalMemberBaseIncome { get => _additionalMemberBaseIncome; set => _additionalMemberBaseIncome = value; }
        private DirtyValue<decimal?> _adjustedAnnualIncome;
        /// <summary>
        /// USDA - Adjusted Annual income for the household [USDA.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Adjusted Annual income for the household")]
        public decimal? AdjustedAnnualIncome { get => _adjustedAnnualIncome; set => _adjustedAnnualIncome = value; }
        private DirtyValue<string> _adjustedIncomeCalculationDescription1;
        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 8 [USDA.X214]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 8")]
        public string AdjustedIncomeCalculationDescription1 { get => _adjustedIncomeCalculationDescription1; set => _adjustedIncomeCalculationDescription1 = value; }
        private DirtyValue<string> _adjustedIncomeCalculationDescription2;
        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 10 [USDA.X215]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 10")]
        public string AdjustedIncomeCalculationDescription2 { get => _adjustedIncomeCalculationDescription2; set => _adjustedIncomeCalculationDescription2 = value; }
        private DirtyValue<string> _adjustedIncomeCalculationDescription3;
        /// <summary>
        /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 11 [USDA.X216]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 11")]
        public string AdjustedIncomeCalculationDescription3 { get => _adjustedIncomeCalculationDescription3; set => _adjustedIncomeCalculationDescription3 = value; }
        private DirtyValue<decimal?> _advanceAmountToDate;
        /// <summary>
        /// USDA - Loan Closing - Advance Amount to Date [USDA.X134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Loan Closing - Advance Amount to Date")]
        public decimal? AdvanceAmountToDate { get => _advanceAmountToDate; set => _advanceAmountToDate = value; }
        private DirtyValue<decimal?> _amountLoanlineCredit;
        /// <summary>
        /// USDA - Loan Closing - Amount of Loanline of Credit [USDA.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Loan Closing - Amount of Loanline of Credit")]
        public decimal? AmountLoanlineCredit { get => _amountLoanlineCredit; set => _amountLoanlineCredit = value; }
        private DirtyValue<decimal?> _annualChildCareExpenses;
        /// <summary>
        /// USDA - Annual Adjusted Income - Annual Child Care Expenses [USDA.X173]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Annual Child Care Expenses")]
        public decimal? AnnualChildCareExpenses { get => _annualChildCareExpenses; set => _annualChildCareExpenses = value; }
        private DirtyValue<decimal?> _annualIncome;
        /// <summary>
        /// USDA - Annual income for the household [USDA.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual income for the household")]
        public decimal? AnnualIncome { get => _annualIncome; set => _annualIncome = value; }
        private DirtyValue<string> _annualIncomeCalculationDescription1;
        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 1 [USDA.X209]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 1")]
        public string AnnualIncomeCalculationDescription1 { get => _annualIncomeCalculationDescription1; set => _annualIncomeCalculationDescription1 = value; }
        private DirtyValue<string> _annualIncomeCalculationDescription2;
        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 2 [USDA.X210]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 2")]
        public string AnnualIncomeCalculationDescription2 { get => _annualIncomeCalculationDescription2; set => _annualIncomeCalculationDescription2 = value; }
        private DirtyValue<string> _annualIncomeCalculationDescription3;
        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 3 [USDA.X211]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 3")]
        public string AnnualIncomeCalculationDescription3 { get => _annualIncomeCalculationDescription3; set => _annualIncomeCalculationDescription3 = value; }
        private DirtyValue<string> _annualIncomeCalculationDescription4;
        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 4 [USDA.X212]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 4")]
        public string AnnualIncomeCalculationDescription4 { get => _annualIncomeCalculationDescription4; set => _annualIncomeCalculationDescription4 = value; }
        private DirtyValue<string> _annualIncomeCalculationDescription5;
        /// <summary>
        /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 5 [USDA.X213]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 5")]
        public string AnnualIncomeCalculationDescription5 { get => _annualIncomeCalculationDescription5; set => _annualIncomeCalculationDescription5 = value; }
        private DirtyValue<DateTime?> _annualReviewDate;
        /// <summary>
        /// USDA - Loan Closing - Annual Review Date [USDA.X147]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Annual Review Date")]
        public DateTime? AnnualReviewDate { get => _annualReviewDate; set => _annualReviewDate = value; }
        private DirtyValue<string> _applicationNumber;
        /// <summary>
        /// USDA - Application Number [USDA.X29]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Application Number")]
        public string ApplicationNumber { get => _applicationNumber; set => _applicationNumber = value; }
        private DirtyValue<string> _approvedLenderTaxId;
        /// <summary>
        /// USDA - Approved Lender Tax ID No [USDA.X25]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Approved Lender Tax ID No")]
        public string ApprovedLenderTaxId { get => _approvedLenderTaxId; set => _approvedLenderTaxId = value; }
        private DirtyValue<decimal?> _assetIncome;
        /// <summary>
        /// USDA - Asset Income (Income from household assets as described in 1980.347(d) of RD Instruction 1980-D) [USDA.X170]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Asset Income (Income from household assets as described in 1980.347(d) of RD Instruction 1980-D)")]
        public decimal? AssetIncome { get => _assetIncome; set => _assetIncome = value; }
        private DirtyValue<decimal?> _balanceOwedOnLoan;
        /// <summary>
        /// USDA - Loan Closing - Balance Owed On Loan [USDA.X144]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Loan Closing - Balance Owed On Loan")]
        public decimal? BalanceOwedOnLoan { get => _balanceOwedOnLoan; set => _balanceOwedOnLoan = value; }
        private DirtyValue<decimal?> _borrowerBaseIncome;
        /// <summary>
        /// USDA - Annual Income - Applicant Base Income [USDA.X164]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Income - Applicant Base Income")]
        public decimal? BorrowerBaseIncome { get => _borrowerBaseIncome; set => _borrowerBaseIncome = value; }
        private DirtyValue<decimal?> _borrowerTotalStableIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Borrower Total Stable Income [USDA.X201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - Borrower Total Stable Income")]
        public decimal? BorrowerTotalStableIncome { get => _borrowerTotalStableIncome; set => _borrowerTotalStableIncome = value; }
        private DirtyValue<StringEnumValue<BorrowerTypeCode>> _borrowerTypeCode;
        /// <summary>
        /// USDA - Loan Closing - Borrower Type Code [USDA.X123]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Borrower Type Code")]
        public StringEnumValue<BorrowerTypeCode> BorrowerTypeCode { get => _borrowerTypeCode; set => _borrowerTypeCode = value; }
        private DirtyValue<decimal?> _buydownInterestAssistanceRate;
        /// <summary>
        /// USDA - Loan Closing - Buydown / Interest Assistance Rate [USDA.X139]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "USDA - Loan Closing - Buydown / Interest Assistance Rate")]
        public decimal? BuydownInterestAssistanceRate { get => _buydownInterestAssistanceRate; set => _buydownInterestAssistanceRate = value; }
        private DirtyValue<string> _caseNumberBorrowerId;
        /// <summary>
        /// USDA - Case Number - Borrower ID [USDA.X122]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Case Number - Borrower ID")]
        public string CaseNumberBorrowerId { get => _caseNumberBorrowerId; set => _caseNumberBorrowerId = value; }
        private DirtyValue<string> _caseNumberCo;
        /// <summary>
        /// USDA - Case Number - CO [USDA.X121]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Case Number - CO")]
        public string CaseNumberCo { get => _caseNumberCo; set => _caseNumberCo = value; }
        private DirtyValue<string> _caseNumberSt;
        /// <summary>
        /// USDA - Case Number - ST [USDA.X120]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Case Number - ST")]
        public string CaseNumberSt { get => _caseNumberSt; set => _caseNumberSt = value; }
        private DirtyValue<DateTime?> _certificationEffectiveDate;
        /// <summary>
        /// USDA - Loan Closing - Certification Effective Date [USDA.X126]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Certification Effective Date")]
        public DateTime? CertificationEffectiveDate { get => _certificationEffectiveDate; set => _certificationEffectiveDate = value; }
        private DirtyValue<DateTime?> _certificationExpirationDate;
        /// <summary>
        /// USDA - Loan Closing - Certification Expiration Date [USDA.X127]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Certification Expiration Date")]
        public DateTime? CertificationExpirationDate { get => _certificationExpirationDate; set => _certificationExpirationDate = value; }
        private DirtyValue<bool?> _certifiedLoanIndicator;
        /// <summary>
        /// USDA - Loan Closing - Certified Loan [USDA.X148]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Certified Loan")]
        public bool? CertifiedLoanIndicator { get => _certifiedLoanIndicator; set => _certifiedLoanIndicator = value; }
        private DirtyValue<string> _childCareProviderAddress;
        /// <summary>
        /// USDA - Child Care Provider - Address [USDA.X99]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Child Care Provider - Address")]
        public string ChildCareProviderAddress { get => _childCareProviderAddress; set => _childCareProviderAddress = value; }
        private DirtyValue<string> _childCareProviderCity;
        /// <summary>
        /// USDA - Child Care Provider - City [USDA.X100]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Child Care Provider - City")]
        public string ChildCareProviderCity { get => _childCareProviderCity; set => _childCareProviderCity = value; }
        private DirtyValue<string> _childCareProviderPhone;
        /// <summary>
        /// USDA - Child Care Provider - Phone Number [USDA.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "USDA - Child Care Provider - Phone Number")]
        public string ChildCareProviderPhone { get => _childCareProviderPhone; set => _childCareProviderPhone = value; }
        private DirtyValue<string> _childCareProviderProviderName;
        /// <summary>
        /// USDA - Child Care Provider - Name [USDA.X98]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Child Care Provider - Name")]
        public string ChildCareProviderProviderName { get => _childCareProviderProviderName; set => _childCareProviderProviderName = value; }
        private DirtyValue<StringEnumValue<State>> _childCareProviderState;
        /// <summary>
        /// USDA - Child Care Provider - State [USDA.X101]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Child Care Provider - State")]
        public StringEnumValue<State> ChildCareProviderState { get => _childCareProviderState; set => _childCareProviderState = value; }
        private DirtyValue<string> _childCareProviderZip;
        /// <summary>
        /// USDA - Child Care Provider - Zip [USDA.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "USDA - Child Care Provider - Zip")]
        public string ChildCareProviderZip { get => _childCareProviderZip; set => _childCareProviderZip = value; }
        private DirtyValue<decimal?> _childCostPerMonth;
        /// <summary>
        /// USDA - Child Care Cost Per Month [USDA.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Child Care Cost Per Month")]
        public decimal? ChildCostPerMonth { get => _childCostPerMonth; set => _childCostPerMonth = value; }
        private DirtyValue<decimal?> _childCostPerWeek;
        /// <summary>
        /// USDA - Child Care Cost Per Week [USDA.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Child Care Cost Per Week")]
        public decimal? ChildCostPerWeek { get => _childCostPerWeek; set => _childCostPerWeek = value; }
        private DirtyValue<decimal?> _coborrowerBaseIncome;
        /// <summary>
        /// USDA - Annual Income - Co-Applicant Base Income [USDA.X165]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Income - Co-Applicant Base Income")]
        public decimal? CoborrowerBaseIncome { get => _coborrowerBaseIncome; set => _coborrowerBaseIncome = value; }
        private DirtyValue<decimal?> _coborrowerStableBaseIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Co-Borrower Stable Dependable Monthly Income (parties to note only) [USDA.X202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Co-Borrower Stable Dependable Monthly Income (parties to note only)")]
        public decimal? CoborrowerStableBaseIncome { get => _coborrowerStableBaseIncome; set => _coborrowerStableBaseIncome = value; }
        private DirtyValue<string> _coborrowerStableBaseIncomeDesc;
        /// <summary>
        /// USDA - Annual Adjusted Income - Coborrower Calculation of Base Income Description [USDA.X203]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Coborrower Calculation of Base Income Description")]
        public string CoborrowerStableBaseIncomeDesc { get => _coborrowerStableBaseIncomeDesc; set => _coborrowerStableBaseIncomeDesc = value; }
        private DirtyValue<decimal?> _coborrowerStableOtherIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Co-Borrower Other Stable Dependable Monthly Income (parties to note only) [USDA.X204]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Co-Borrower Other Stable Dependable Monthly Income (parties to note only)")]
        public decimal? CoborrowerStableOtherIncome { get => _coborrowerStableOtherIncome; set => _coborrowerStableOtherIncome = value; }
        private DirtyValue<string> _coborrowerStableOtherIncomeDesc;
        /// <summary>
        /// USDA - Annual Adjusted Income - Coborrower Calculation of Other Income Description [USDA.X205]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Coborrower Calculation of Other Income Description")]
        public string CoborrowerStableOtherIncomeDesc { get => _coborrowerStableOtherIncomeDesc; set => _coborrowerStableOtherIncomeDesc = value; }
        private DirtyValue<decimal?> _coBorrowerTotalStableIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - CoBorrower Total Stable Income [USDA.X206]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - CoBorrower Total Stable Income")]
        public decimal? CoBorrowerTotalStableIncome { get => _coBorrowerTotalStableIncome; set => _coBorrowerTotalStableIncome = value; }
        private DirtyValue<DateTime?> _dateConfirmedObligationProcessed;
        /// <summary>
        /// USDA - Tracking - Date Confirmed Obligation Processed [USDA.X154]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Date Confirmed Obligation Processed")]
        public DateTime? DateConfirmedObligationProcessed { get => _dateConfirmedObligationProcessed; set => _dateConfirmedObligationProcessed = value; }
        private DirtyValue<DateTime?> _dateLoanNoteGuaranteeIssued;
        /// <summary>
        /// USDA - Tracking - Date Loan Note Guarantee Issued [USDA.X159]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Date Loan Note Guarantee Issued")]
        public DateTime? DateLoanNoteGuaranteeIssued { get => _dateLoanNoteGuaranteeIssued; set => _dateLoanNoteGuaranteeIssued = value; }
        private DirtyValue<DateTime?> _dateLoanNoteGuaranteeRequestReceived;
        /// <summary>
        /// USDA - Tracking - DateLoan Note Guarantee Request Received [USDA.X157]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - DateLoan Note Guarantee Request Received")]
        public DateTime? DateLoanNoteGuaranteeRequestReceived { get => _dateLoanNoteGuaranteeRequestReceived; set => _dateLoanNoteGuaranteeRequestReceived = value; }
        private DirtyValue<DateTime?> _dateObligationInGls;
        /// <summary>
        /// USDA - Tracking - Date of Obligation in GLS [USDA.X153]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Date of Obligation in GLS")]
        public DateTime? DateObligationInGls { get => _dateObligationInGls; set => _dateObligationInGls = value; }
        private DirtyValue<DateTime?> _dateVerifiedInUnifi;
        /// <summary>
        /// USDA - Tracking - Date Verified in Unifi [USDA.X162]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Date Verified in Unifi")]
        public DateTime? DateVerifiedInUnifi { get => _dateVerifiedInUnifi; set => _dateVerifiedInUnifi = value; }
        private DirtyValue<decimal?> _dependentDeduction;
        /// <summary>
        /// USDA - Annual Adjusted Income - Dependent Deduction [USDA.X172]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Dependent Deduction")]
        public decimal? DependentDeduction { get => _dependentDeduction; set => _dependentDeduction = value; }
        private DirtyValue<decimal?> _disabilityDeduction;
        /// <summary>
        /// USDA - Annual Adjusted Income - Disability Deduction [USDA.X175]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Disability Deduction")]
        public decimal? DisabilityDeduction { get => _disabilityDeduction; set => _disabilityDeduction = value; }
        private DirtyValue<decimal?> _elderlyHouseholdDeduction;
        /// <summary>
        /// USDA - Annual Adjusted Income - Elderly Household Deduction [USDA.X174]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Elderly Household Deduction")]
        public decimal? ElderlyHouseholdDeduction { get => _elderlyHouseholdDeduction; set => _elderlyHouseholdDeduction = value; }
        private DirtyValue<decimal?> _feeRate;
        /// <summary>
        /// USDA - Loan Closing - Fee Rate [USDA.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "USDA - Loan Closing - Fee Rate")]
        public decimal? FeeRate { get => _feeRate; set => _feeRate = value; }
        private DirtyValue<string> _financedLoanClosingCostDescription;
        /// <summary>
        /// USDA - Financed Loan Closing Cost Description [USDA.X21]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Financed Loan Closing Cost Description")]
        public string FinancedLoanClosingCostDescription { get => _financedLoanClosingCostDescription; set => _financedLoanClosingCostDescription = value; }
        private DirtyValue<decimal?> _financedLoanClosingCosts;
        /// <summary>
        /// USDA - Financed Loan Closing Costs [USDA.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Financed Loan Closing Costs")]
        public decimal? FinancedLoanClosingCosts { get => _financedLoanClosingCosts; set => _financedLoanClosingCosts = value; }
        private DirtyValue<decimal?> _guaranteeFeeCollected;
        /// <summary>
        /// USDA - Tracking - Guarantee Fee Collected [USDA.X160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Tracking - Guarantee Fee Collected")]
        public decimal? GuaranteeFeeCollected { get => _guaranteeFeeCollected; set => _guaranteeFeeCollected = value; }
        private DirtyValue<decimal?> _guaranteeFeeOnCommitment;
        /// <summary>
        /// USDA - Tracking - Guarantee Fee On Commitment [USDA.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Tracking - Guarantee Fee On Commitment")]
        public decimal? GuaranteeFeeOnCommitment { get => _guaranteeFeeOnCommitment; set => _guaranteeFeeOnCommitment = value; }
        private DirtyValue<StringEnumValue<GuaranteeFeePurposeCodeType>> _guaranteeFeePurposeCodeType;
        /// <summary>
        /// USDA - Loan Closing - Guarantee Fee Purpose Code [USDA.X130]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Guarantee Fee Purpose Code")]
        public StringEnumValue<GuaranteeFeePurposeCodeType> GuaranteeFeePurposeCodeType { get => _guaranteeFeePurposeCodeType; set => _guaranteeFeePurposeCodeType = value; }
        private DirtyValue<DateTime?> _guaranteePeriodBeginsDate;
        /// <summary>
        /// USDA - Loan Closing - Date Guarantee Period Begins [USDA.X145]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Date Guarantee Period Begins")]
        public DateTime? GuaranteePeriodBeginsDate { get => _guaranteePeriodBeginsDate; set => _guaranteePeriodBeginsDate = value; }
        private DirtyValue<DateTime?> _guaranteePeriodEndsDate;
        /// <summary>
        /// USDA - Loan Closing - Date Guarantee Period Ends [USDA.X146]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Date Guarantee Period Ends")]
        public DateTime? GuaranteePeriodEndsDate { get => _guaranteePeriodEndsDate; set => _guaranteePeriodEndsDate = value; }
        private DirtyValue<StringEnumValue<GuaranteeType>> _guaranteeType;
        /// <summary>
        /// USDA - Loan Closing - Type of Guarantee [USDA.X142]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Type of Guarantee")]
        public StringEnumValue<GuaranteeType> GuaranteeType { get => _guaranteeType; set => _guaranteeType = value; }
        private DirtyValue<int?> _householdSize;
        /// <summary>
        /// USDA - Annual Adjusted Income - Household Size [USDA.X179]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Household Size")]
        public int? HouseholdSize { get => _householdSize; set => _householdSize = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Usda Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<InterestAssistanceCodeType>> _interestAssistanceCodeType;
        /// <summary>
        /// USDA - Loan Closing - Interest Assistance Code [USDA.X129]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Interest Assistance Code")]
        public StringEnumValue<InterestAssistanceCodeType> InterestAssistanceCodeType { get => _interestAssistanceCodeType; set => _interestAssistanceCodeType = value; }
        private DirtyValue<bool?> _interestRateBasedonFannieIndicator;
        /// <summary>
        /// USDA - Is Interest Rate Based on Fannie Mae [USDA.X18]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Is Interest Rate Based on Fannie Mae")]
        public bool? InterestRateBasedonFannieIndicator { get => _interestRateBasedonFannieIndicator; set => _interestRateBasedonFannieIndicator = value; }
        private DirtyValue<StringEnumValue<InterestRateCodeType>> _interestRateCodeType;
        /// <summary>
        /// USDA - Loan Closing - Interest Rate Code [USDA.X143]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Interest Rate Code")]
        public StringEnumValue<InterestRateCodeType> InterestRateCodeType { get => _interestRateCodeType; set => _interestRateCodeType = value; }
        private DirtyValue<bool?> _interestRateFloatToLoanClosingIndicator;
        /// <summary>
        /// USDA - Is Interest Rate Based on Fannie Mae - Interest Rate will Float Until Loan Closing [USDA.X19]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Is Interest Rate Based on Fannie Mae - Interest Rate will Float Until Loan Closing")]
        public bool? InterestRateFloatToLoanClosingIndicator { get => _interestRateFloatToLoanClosingIndicator; set => _interestRateFloatToLoanClosingIndicator = value; }
        private DirtyValue<bool?> _lackAdequateHeatIndicator;
        /// <summary>
        /// USDA - Characteristics Present Housing - Lack Adequate Heat Indicator [USDA.X105]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Characteristics Present Housing - Lack Adequate Heat Indicator")]
        public bool? LackAdequateHeatIndicator { get => _lackAdequateHeatIndicator; set => _lackAdequateHeatIndicator = value; }
        private DirtyValue<string> _lenderAuthorizedRepCompany;
        /// <summary>
        /// USDA - Lender's Authorized Representative Company Name [USDA.X32]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Lender's Authorized Representative Company Name")]
        public string LenderAuthorizedRepCompany { get => _lenderAuthorizedRepCompany; set => _lenderAuthorizedRepCompany = value; }
        private DirtyValue<string> _lenderAuthorizedRepName;
        /// <summary>
        /// USDA - Lender's Authorized Representative Name [USDA.X31]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Lender's Authorized Representative Name")]
        public string LenderAuthorizedRepName { get => _lenderAuthorizedRepName; set => _lenderAuthorizedRepName = value; }
        private DirtyValue<string> _lenderAuthorizedRepTitle;
        /// <summary>
        /// USDA - Lender's Authorized Representative Title [USDA.X30]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Lender's Authorized Representative Title")]
        public string LenderAuthorizedRepTitle { get => _lenderAuthorizedRepTitle; set => _lenderAuthorizedRepTitle = value; }
        private DirtyValue<string> _lenderIdNo;
        /// <summary>
        /// USDA - Loan Closing - Lender ID No [USDA.X186]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Lender ID No")]
        public string LenderIdNo { get => _lenderIdNo; set => _lenderIdNo = value; }
        private DirtyValue<decimal?> _lenderNoteRateOnGuaranteedPortion;
        /// <summary>
        /// USDA - Loan Closing - Lender's Note Interest Rate On Guaranteed Portion [USDA.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "USDA - Loan Closing - Lender's Note Interest Rate On Guaranteed Portion")]
        public decimal? LenderNoteRateOnGuaranteedPortion { get => _lenderNoteRateOnGuaranteedPortion; set => _lenderNoteRateOnGuaranteedPortion = value; }
        private DirtyValue<decimal?> _lenderNoteRateOnNonGuaranteedPortion;
        /// <summary>
        /// USDA - Loan Closing - Lender's Note Interest Rate On Non-Guaranteed Portion [USDA.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "USDA - Loan Closing - Lender's Note Interest Rate On Non-Guaranteed Portion")]
        public decimal? LenderNoteRateOnNonGuaranteedPortion { get => _lenderNoteRateOnNonGuaranteedPortion; set => _lenderNoteRateOnNonGuaranteedPortion = value; }
        private DirtyValue<StringEnumValue<LenderStatusCodeType>> _lenderStatusCodeType;
        /// <summary>
        /// USDA - Loan Closing - Lender Status Code [USDA.X124]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Lender Status Code")]
        public StringEnumValue<LenderStatusCodeType> LenderStatusCodeType { get => _lenderStatusCodeType; set => _lenderStatusCodeType = value; }
        private DirtyValue<StringEnumValue<LenderTypeCode>> _lenderTypeCode;
        /// <summary>
        /// USDA - Loan Closing - Lender Type Code [USDA.X125]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Lender Type Code")]
        public StringEnumValue<LenderTypeCode> LenderTypeCode { get => _lenderTypeCode; set => _lenderTypeCode = value; }
        private DirtyValue<StringEnumValue<UsdaLoanType>> _loanType;
        /// <summary>
        /// USDA - Loan Type [USDA.X43]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Type")]
        public StringEnumValue<UsdaLoanType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<bool?> _lockCompletePlumbingIndicator;
        /// <summary>
        /// USDA - Characteristics Present Housing - Lock Complete Plumbing Indicator [USDA.X104]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Characteristics Present Housing - Lock Complete Plumbing Indicator")]
        public bool? LockCompletePlumbingIndicator { get => _lockCompletePlumbingIndicator; set => _lockCompletePlumbingIndicator = value; }
        private DirtyValue<decimal?> _medicalExpenses;
        /// <summary>
        /// USDA - Annual Adjusted Income - Medical Expenses [USDA.X176]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Medical Expenses")]
        public decimal? MedicalExpenses { get => _medicalExpenses; set => _medicalExpenses = value; }
        private DirtyValue<decimal?> _moderateIncomeLimit;
        /// <summary>
        /// USDA - Annual Adjusted Income - Moderate Income Limit [USDA.X180]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Moderate Income Limit")]
        public decimal? ModerateIncomeLimit { get => _moderateIncomeLimit; set => _moderateIncomeLimit = value; }
        private DirtyValue<decimal?> _monthlyRepaymentIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Monthly Repayment Income [USDA.X184]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - Monthly Repayment Income")]
        public decimal? MonthlyRepaymentIncome { get => _monthlyRepaymentIncome; set => _monthlyRepaymentIncome = value; }
        private DirtyValue<int?> _numberofDependents;
        /// <summary>
        /// USDA - Annual Adjusted Income - Number of Dependent for Deduction (child under age 18, or full-time student) [USDA.X185]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Number of Dependent for Deduction (child under age 18, or full-time student)")]
        public int? NumberofDependents { get => _numberofDependents; set => _numberofDependents = value; }
        private DirtyValue<int?> _numberofPeopleInHousehold;
        /// <summary>
        /// USDA - Number of people in household [USDA.X9]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Number of people in household")]
        public int? NumberofPeopleInHousehold { get => _numberofPeopleInHousehold; set => _numberofPeopleInHousehold = value; }
        private DirtyValue<bool?> _obligationMatchesCommitmentLenderRequestIndicator;
        /// <summary>
        /// USDA - Tracking - Obligation Matches Commitment and Lender Request [USDA.X156]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Obligation Matches Commitment and Lender Request")]
        public bool? ObligationMatchesCommitmentLenderRequestIndicator { get => _obligationMatchesCommitmentLenderRequestIndicator; set => _obligationMatchesCommitmentLenderRequestIndicator = value; }
        private DirtyValue<string> _officialWhoConfirmedGlsUpdated;
        /// <summary>
        /// USDA - Tracking - Official Who Confirmed GLS Updated [USDA.X155]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Official Who Confirmed GLS Updated")]
        public string OfficialWhoConfirmedGlsUpdated { get => _officialWhoConfirmedGlsUpdated; set => _officialWhoConfirmedGlsUpdated = value; }
        private DirtyValue<decimal?> _otherIncome;
        /// <summary>
        /// USDA - Other Income (Alimony, Child Support, y, Pension/Retirement, Social Security, Disability, Trust Income, Notes Receivable, etc.) [USDA.X169]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Other Income (Alimony, Child Support, y, Pension/Retirement, Social Security, Disability, Trust Income, Notes Receivable, etc.)")]
        public decimal? OtherIncome { get => _otherIncome; set => _otherIncome = value; }
        private DirtyValue<decimal?> _otherStableDependableMonthlyIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Other Stable Dependable Monthly Income (parties to note only) [USDA.X183]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Other Stable Dependable Monthly Income (parties to note only)")]
        public decimal? OtherStableDependableMonthlyIncome { get => _otherStableDependableMonthlyIncome; set => _otherStableDependableMonthlyIncome = value; }
        private DirtyValue<bool?> _overcrowdedIndicator;
        /// <summary>
        /// USDA - Characteristics Present Housing - Overcrowded Indicator [USDA.X107]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Characteristics Present Housing - Overcrowded Indicator")]
        public bool? OvercrowdedIndicator { get => _overcrowdedIndicator; set => _overcrowdedIndicator = value; }
        private DirtyValue<decimal?> _percentofLoanGuaranteed;
        /// <summary>
        /// USDA - Loan Closing - Percent of Loan Guaranteed [USDA.X199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "USDA - Loan Closing - Percent of Loan Guaranteed")]
        public decimal? PercentofLoanGuaranteed { get => _percentofLoanGuaranteed; set => _percentofLoanGuaranteed = value; }
        private DirtyValue<StringEnumValue<PeriodOperatingLineCreditYearsType>> _periodOperatingLineCreditYearsType;
        /// <summary>
        /// USDA - Loan Closing - Period of Operating Line of Credit Years [USDA.X140]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Period of Operating Line of Credit Years")]
        public StringEnumValue<PeriodOperatingLineCreditYearsType> PeriodOperatingLineCreditYearsType { get => _periodOperatingLineCreditYearsType; set => _periodOperatingLineCreditYearsType = value; }
        private DirtyValue<bool?> _physicallyDeterioratedIndicator;
        /// <summary>
        /// USDA - Characteristics Present Housing - Physically Deteriorated or Structurally Unsound Indicator [USDA.X106]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Characteristics Present Housing - Physically Deteriorated or Structurally Unsound Indicator")]
        public bool? PhysicallyDeterioratedIndicator { get => _physicallyDeterioratedIndicator; set => _physicallyDeterioratedIndicator = value; }
        private DirtyValue<string> _preparedByName;
        /// <summary>
        /// USDA - Annual and Repayment Income Worksheet Prepared By Name [USDA.X196]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual and Repayment Income Worksheet Prepared By Name")]
        public string PreparedByName { get => _preparedByName; set => _preparedByName = value; }
        private DirtyValue<string> _preparedByTitle;
        /// <summary>
        /// USDA -  Annual and Repayment Income Worksheet Prepared By Title [USDA.X197]
        /// </summary>
        [LoanFieldProperty(Description = "USDA -  Annual and Repayment Income Worksheet Prepared By Title")]
        public string PreparedByTitle { get => _preparedByTitle; set => _preparedByTitle = value; }
        private DirtyValue<string> _presentLandloardAddress;
        /// <summary>
        /// USDA - Present Landloard - Address [USDA.X109]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Present Landloard - Address")]
        public string PresentLandloardAddress { get => _presentLandloardAddress; set => _presentLandloardAddress = value; }
        private DirtyValue<string> _presentLandloardCity;
        /// <summary>
        /// USDA - Present Landloard - City [USDA.X110]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Present Landloard - City")]
        public string PresentLandloardCity { get => _presentLandloardCity; set => _presentLandloardCity = value; }
        private DirtyValue<string> _presentLandloardName;
        /// <summary>
        /// USDA - Present Landloard - Name [USDA.X108]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Present Landloard - Name")]
        public string PresentLandloardName { get => _presentLandloardName; set => _presentLandloardName = value; }
        private DirtyValue<string> _presentLandloardPhone;
        /// <summary>
        /// USDA - Present Landloard - Phone Number [USDA.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "USDA - Present Landloard - Phone Number")]
        public string PresentLandloardPhone { get => _presentLandloardPhone; set => _presentLandloardPhone = value; }
        private DirtyValue<StringEnumValue<State>> _presentLandloardState;
        /// <summary>
        /// USDA - Present Landloard - State [USDA.X111]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Present Landloard - State")]
        public StringEnumValue<State> PresentLandloardState { get => _presentLandloardState; set => _presentLandloardState = value; }
        private DirtyValue<string> _presentLandloardZip;
        /// <summary>
        /// USDA - Present Landloard - Zip [USDA.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "USDA - Present Landloard - Zip")]
        public string PresentLandloardZip { get => _presentLandloardZip; set => _presentLandloardZip = value; }
        private DirtyValue<string> _previousLandloardAddress;
        /// <summary>
        /// USDA - Previous Landloard - Address [USDA.X115]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Previous Landloard - Address")]
        public string PreviousLandloardAddress { get => _previousLandloardAddress; set => _previousLandloardAddress = value; }
        private DirtyValue<string> _previousLandloardCity;
        /// <summary>
        /// USDA - Previous Landloard - City [USDA.X116]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Previous Landloard - City")]
        public string PreviousLandloardCity { get => _previousLandloardCity; set => _previousLandloardCity = value; }
        private DirtyValue<string> _previousLandloardName;
        /// <summary>
        /// USDA - Previous Landloard - Name [USDA.X114]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Previous Landloard - Name")]
        public string PreviousLandloardName { get => _previousLandloardName; set => _previousLandloardName = value; }
        private DirtyValue<string> _previousLandloardPhone;
        /// <summary>
        /// USDA - Previous Landloard - Phone Number [USDA.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "USDA - Previous Landloard - Phone Number")]
        public string PreviousLandloardPhone { get => _previousLandloardPhone; set => _previousLandloardPhone = value; }
        private DirtyValue<StringEnumValue<State>> _previousLandloardState;
        /// <summary>
        /// USDA - Previous Landloard - State [USDA.X117]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Previous Landloard - State")]
        public StringEnumValue<State> PreviousLandloardState { get => _previousLandloardState; set => _previousLandloardState = value; }
        private DirtyValue<string> _previousLandloardZip;
        /// <summary>
        /// USDA - Previous Landloard - Zip [USDA.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "USDA - Previous Landloard - Zip")]
        public string PreviousLandloardZip { get => _previousLandloardZip; set => _previousLandloardZip = value; }
        private DirtyValue<decimal?> _purchaseOrRefinancedAmount;
        /// <summary>
        /// USDA - Purchase or Refinanced Amount [USDA.X198]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Purchase or Refinanced Amount")]
        public decimal? PurchaseOrRefinancedAmount { get => _purchaseOrRefinancedAmount; set => _purchaseOrRefinancedAmount = value; }
        private DirtyValue<string> _purchaseOrRefinanceDescription;
        /// <summary>
        /// USDA - Purchase / Refinance Description [USDA.X20]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Purchase / Refinance Description")]
        public string PurchaseOrRefinanceDescription { get => _purchaseOrRefinanceDescription; set => _purchaseOrRefinanceDescription = value; }
        private DirtyValue<StringEnumValue<RdsfhRefinancedLoanIndicatorType>> _rdsfhRefinancedLoanIndicatorType;
        /// <summary>
        /// USDA - RD SFH Refinance Loan Indicator [USDA.X8]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - RD SFH Refinance Loan Indicator")]
        public StringEnumValue<RdsfhRefinancedLoanIndicatorType> RdsfhRefinancedLoanIndicatorType { get => _rdsfhRefinancedLoanIndicatorType; set => _rdsfhRefinancedLoanIndicatorType = value; }
        private DirtyValue<bool?> _refinanceLoanIndicator;
        /// <summary>
        /// USDA Refinance Loan Indicator [USDA.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "USDA Refinance Loan Indicator")]
        public bool? RefinanceLoanIndicator { get => _refinanceLoanIndicator; set => _refinanceLoanIndicator = value; }
        private DirtyValue<decimal?> _repairOtherAmount;
        /// <summary>
        /// USDA - Repair / Other Amount [USDA.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Repair / Other Amount")]
        public decimal? RepairOtherAmount { get => _repairOtherAmount; set => _repairOtherAmount = value; }
        private DirtyValue<string> _repairOtherDescription;
        /// <summary>
        /// USDA - Repair / Other Description [USDA.X23]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Repair / Other Description")]
        public string RepairOtherDescription { get => _repairOtherDescription; set => _repairOtherDescription = value; }
        private DirtyValue<decimal?> _reservationAmountRequested;
        /// <summary>
        /// USDA - Reservation Amount Requested [USDA.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Reservation Amount Requested")]
        public decimal? ReservationAmountRequested { get => _reservationAmountRequested; set => _reservationAmountRequested = value; }
        private DirtyValue<string> _reserved;
        /// <summary>
        /// USDA - Loan Closing - Reserved [USDA.X141]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Reserved")]
        public string Reserved { get => _reserved; set => _reserved = value; }
        private DirtyValue<string> _servicingOfficeName;
        /// <summary>
        /// USDA - Loan Closing - Servicing Office [USDA.X128]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Servicing Office")]
        public string ServicingOfficeName { get => _servicingOfficeName; set => _servicingOfficeName = value; }
        private DirtyValue<bool?> _sfhglpIndicator;
        /// <summary>
        /// USDA - Annual Adjusted Income - Applicants Eligible for SFHGLP [USDA.X181]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Applicants Eligible for SFHGLP")]
        public bool? SfhglpIndicator { get => _sfhglpIndicator; set => _sfhglpIndicator = value; }
        private DirtyValue<StringEnumValue<SourceOfFundsType>> _sourceOfFundsType;
        /// <summary>
        /// USDA - Source of Funds [USDA.X166]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Source of Funds")]
        public StringEnumValue<SourceOfFundsType> SourceOfFundsType { get => _sourceOfFundsType; set => _sourceOfFundsType = value; }
        private DirtyValue<decimal?> _stableDependableMonthlyIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Stable Dependable Monthly Income (parties to note only) [USDA.X182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Annual Adjusted Income - Stable Dependable Monthly Income (parties to note only)")]
        public decimal? StableDependableMonthlyIncome { get => _stableDependableMonthlyIncome; set => _stableDependableMonthlyIncome = value; }
        private DirtyValue<string> _stableOtherIncomeDesc;
        /// <summary>
        /// USDA - Annual Adjusted Income - Borrower Calculation of Other Income Description [USDA.X200]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Annual Adjusted Income - Borrower Calculation of Other Income Description")]
        public string StableOtherIncomeDesc { get => _stableOtherIncomeDesc; set => _stableOtherIncomeDesc = value; }
        private DirtyValue<string> _submittingLenderAddress;
        /// <summary>
        /// USDA - Submitting Lender Information - Address [USDA.X36]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - Address")]
        public string SubmittingLenderAddress { get => _submittingLenderAddress; set => _submittingLenderAddress = value; }
        private DirtyValue<string> _submittingLenderCity;
        /// <summary>
        /// USDA - Submitting Lender Information - City [USDA.X37]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - City")]
        public string SubmittingLenderCity { get => _submittingLenderCity; set => _submittingLenderCity = value; }
        private DirtyValue<string> _submittingLenderContactFax;
        /// <summary>
        /// USDA - Submitting Lender Information - Contact Fax Number [USDA.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "USDA - Submitting Lender Information - Contact Fax Number")]
        public string SubmittingLenderContactFax { get => _submittingLenderContactFax; set => _submittingLenderContactFax = value; }
        private DirtyValue<string> _submittingLenderContactName;
        /// <summary>
        /// USDA - Submitting Lender Information - Contact Name [USDA.X40]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - Contact Name")]
        public string SubmittingLenderContactName { get => _submittingLenderContactName; set => _submittingLenderContactName = value; }
        private DirtyValue<string> _submittingLenderContactPhone;
        /// <summary>
        /// USDA - Submitting Lender Information - Contact Phone Number [USDA.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "USDA - Submitting Lender Information - Contact Phone Number")]
        public string SubmittingLenderContactPhone { get => _submittingLenderContactPhone; set => _submittingLenderContactPhone = value; }
        private DirtyValue<string> _submittingLenderName;
        /// <summary>
        /// USDA - Submitting Lender Information - Name [USDA.X34]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - Name")]
        public string SubmittingLenderName { get => _submittingLenderName; set => _submittingLenderName = value; }
        private DirtyValue<StringEnumValue<State>> _submittingLenderState;
        /// <summary>
        /// USDA - Submitting Lender Information - State [USDA.X38]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - State")]
        public StringEnumValue<State> SubmittingLenderState { get => _submittingLenderState; set => _submittingLenderState = value; }
        private DirtyValue<string> _submittingLenderTaxId;
        /// <summary>
        /// USDA - Submitting Lender Information - Tax ID No. [USDA.X35]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Submitting Lender Information - Tax ID No.")]
        public string SubmittingLenderTaxId { get => _submittingLenderTaxId; set => _submittingLenderTaxId = value; }
        private DirtyValue<string> _submittingLenderZip;
        /// <summary>
        /// USDA - Submitting Lender Information - Zip [USDA.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "USDA - Submitting Lender Information - Zip")]
        public string SubmittingLenderZip { get => _submittingLenderZip; set => _submittingLenderZip = value; }
        private DirtyValue<int?> _termOfBuydown;
        /// <summary>
        /// USDA - Loan Closing - Term of Buydown / Interest Assistance Years [USDA.X135]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Term of Buydown / Interest Assistance Years", OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\"}")]
        public int? TermOfBuydown { get => _termOfBuydown; set => _termOfBuydown = value; }
        private DirtyValue<string> _thirdPartyOriginator;
        /// <summary>
        /// USDA - Third Party Originator (TPO) [USDA.X27]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Third Party Originator (TPO)")]
        public string ThirdPartyOriginator { get => _thirdPartyOriginator; set => _thirdPartyOriginator = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// USDA - Loan Closing - Title [USDA.X149]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Loan Closing - Title")]
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<decimal?> _totalBorrowerStableBaseIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Base Income [USDA.X207]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Base Income")]
        public decimal? TotalBorrowerStableBaseIncome { get => _totalBorrowerStableBaseIncome; set => _totalBorrowerStableBaseIncome = value; }
        private DirtyValue<decimal?> _totalBorrowerStableOtherIncome;
        /// <summary>
        /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Other Income [USDA.X208]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Other Income")]
        public decimal? TotalBorrowerStableOtherIncome { get => _totalBorrowerStableOtherIncome; set => _totalBorrowerStableOtherIncome = value; }
        private DirtyValue<decimal?> _totalHouseholdDeduction;
        /// <summary>
        /// USDA - Annual Adjusted Income - Total Household Deduction [USDA.X177]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "USDA - Annual Adjusted Income - Total Household Deduction")]
        public decimal? TotalHouseholdDeduction { get => _totalHouseholdDeduction; set => _totalHouseholdDeduction = value; }
        private DirtyValue<decimal?> _totalRequestAmount;
        /// <summary>
        /// USDA - Total Request Amount [USDA.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "USDA - Total Request Amount")]
        public decimal? TotalRequestAmount { get => _totalRequestAmount; set => _totalRequestAmount = value; }
        private DirtyValue<string> _tpoTaxId;
        /// <summary>
        /// USDA - Third Party Originator (TPO) Tax ID No. [USDA.X28]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Third Party Originator (TPO) Tax ID No.")]
        public string TpoTaxId { get => _tpoTaxId; set => _tpoTaxId = value; }
        private DirtyValue<string> _underwritingDecisionBy;
        /// <summary>
        /// USDA - Tracking - Underwriting Decision By [USDA.X151]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Underwriting Decision By")]
        public string UnderwritingDecisionBy { get => _underwritingDecisionBy; set => _underwritingDecisionBy = value; }
        private DirtyValue<DateTime?> _underwritingDecisionDate;
        /// <summary>
        /// USDA - Tracking - Underwriting Decision Date [USDA.X150]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Underwriting Decision Date")]
        public DateTime? UnderwritingDecisionDate { get => _underwritingDecisionDate; set => _underwritingDecisionDate = value; }
        private DirtyValue<StringEnumValue<UnderwritingDecisionType>> _underwritingDecisionType;
        /// <summary>
        /// USDA - Tracking - Underwriting Decision [USDA.X152]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Underwriting Decision")]
        public StringEnumValue<UnderwritingDecisionType> UnderwritingDecisionType { get => _underwritingDecisionType; set => _underwritingDecisionType = value; }
        private DirtyList<UsdaHouseholdIncome> _usdaHouseholdIncomes;
        /// <summary>
        /// Usda UsdaHouseholdIncomes
        /// </summary>
        public IList<UsdaHouseholdIncome> UsdaHouseholdIncomes { get => _usdaHouseholdIncomes ?? (_usdaHouseholdIncomes = new DirtyList<UsdaHouseholdIncome>()); set => _usdaHouseholdIncomes = new DirtyList<UsdaHouseholdIncome>(value); }
        private DirtyValue<string> _verificationCode;
        /// <summary>
        /// USDA - Tracking - Verification Code [USDA.X163]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - Tracking - Verification Code")]
        public string VerificationCode { get => _verificationCode; set => _verificationCode = value; }
    }
}