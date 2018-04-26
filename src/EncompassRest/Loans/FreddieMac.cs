using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FreddieMac
    /// </summary>
    public sealed partial class FreddieMac : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AffordableProduct>> _affordableProduct;
        /// <summary>
        /// Freddie Mac Lender Affordable Product [CASASRN.X114]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Affordable Product")]
        public StringEnumValue<AffordableProduct> AffordableProduct { get => _affordableProduct; set => _affordableProduct = value; }
        private DirtyValue<decimal?> _alimonyAsIncomeReduction;
        /// <summary>
        /// Freddie Mac FHA/VA Alimony as Inc Reduc [CASASRN.X159]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac FHA/VA Alimony as Inc Reduc")]
        public decimal? AlimonyAsIncomeReduction { get => _alimonyAsIncomeReduction; set => _alimonyAsIncomeReduction = value; }
        private DirtyValue<decimal?> _allMonthlyPayments;
        /// <summary>
        /// Freddie Mac Total All Mo Pymts [CASASRN.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Freddie Mac Total All Mo Pymts")]
        public decimal? AllMonthlyPayments { get => _allMonthlyPayments; set => _allMonthlyPayments = value; }
        private DirtyValue<bool?> _allowsNegativeAmortizationIndicator;
        /// <summary>
        /// Freddie Mac Lender Allows Neg Amort [CASASRN.X85]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Allows Neg Amort", OptionsJson = "{\"true\":\"Allows Negative Amortization\"}")]
        public bool? AllowsNegativeAmortizationIndicator { get => _allowsNegativeAmortizationIndicator; set => _allowsNegativeAmortizationIndicator = value; }
        private DirtyValue<string> _amountOfFinancedMI;
        /// <summary>
        /// Freddie Mac Amt Financed MI [CASASRN.X169]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Amt Financed MI")]
        public string AmountOfFinancedMI { get => _amountOfFinancedMI; set => _amountOfFinancedMI = value; }
        private DirtyValue<string> _aPNCity;
        /// <summary>
        /// Freddie Mac Lender APN City [CASASRN.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender APN City")]
        public string APNCity { get => _aPNCity; set => _aPNCity = value; }
        private DirtyValue<bool?> _armsLengthTransactionIndicator;
        /// <summary>
        /// Freddie Mac Lender Arms-Length Trans [CASASRN.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Arms-Length Trans", OptionsJson = "{\"true\":\"Arms-Length Transaction\"}")]
        public bool? ArmsLengthTransactionIndicator { get => _armsLengthTransactionIndicator; set => _armsLengthTransactionIndicator = value; }
        private DirtyValue<bool?> _borrowerQualifiesAsVeteranIndicator;
        /// <summary>
        /// Borr Qualifies as Veteran [156]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Qualifies as Veteran", OptionsJson = "{\"true\":\"One or more borrowers qualifies as a veteran\"}")]
        public bool? BorrowerQualifiesAsVeteranIndicator { get => _borrowerQualifiesAsVeteranIndicator; set => _borrowerQualifiesAsVeteranIndicator = value; }
        private DirtyValue<string> _brokerOriginated;
        /// <summary>
        /// Freddie Mac Broker Originated [CASASRN.X165]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Broker Originated")]
        public string BrokerOriginated { get => _brokerOriginated; set => _brokerOriginated = value; }
        private DirtyValue<StringEnumValue<BuydownContributor>> _buydownContributor;
        /// <summary>
        /// Freddie Mac Buydown Contributor [CASASRN.X141]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Buydown Contributor")]
        public StringEnumValue<BuydownContributor> BuydownContributor { get => _buydownContributor; set => _buydownContributor = value; }
        private DirtyValue<StringEnumValue<CondoClass>> _condoClass;
        /// <summary>
        /// Freddie Mac Lender Condo Class [CASASRN.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Condo Class")]
        public StringEnumValue<CondoClass> CondoClass { get => _condoClass; set => _condoClass = value; }
        private DirtyValue<decimal?> _convertibleFeeAmount;
        /// <summary>
        /// Conversion Option Fee Amount [CnvrOpt.FeeAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Conversion Option Fee Amount")]
        public decimal? ConvertibleFeeAmount { get => _convertibleFeeAmount; set => _convertibleFeeAmount = value; }
        private DirtyValue<decimal?> _convertibleFeePercent;
        /// <summary>
        /// Conversion Option Fee Percent [CnvrOpt.FeePct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Conversion Option Fee Percent")]
        public decimal? ConvertibleFeePercent { get => _convertibleFeePercent; set => _convertibleFeePercent = value; }
        private DirtyValue<decimal?> _convertibleMaxRateAdjPercent;
        /// <summary>
        /// Conversion Option Max. Rate Adj. [CnvrOpt.MaxRateAdj]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Conversion Option Max. Rate Adj.")]
        public decimal? ConvertibleMaxRateAdjPercent { get => _convertibleMaxRateAdjPercent; set => _convertibleMaxRateAdjPercent = value; }
        private DirtyValue<decimal?> _convertibleMinRateAdjPercent;
        /// <summary>
        /// Conversion Option Min. Rate Adj. [CnvrOpt.MinRateAdj]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Conversion Option Min. Rate Adj.")]
        public decimal? ConvertibleMinRateAdjPercent { get => _convertibleMinRateAdjPercent; set => _convertibleMinRateAdjPercent = value; }
        private DirtyValue<string> _correspondentAssignmentID;
        /// <summary>
        /// Freddie Mac Correspondent Assignment Center ID [CASASRN.X203]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Correspondent Assignment Center ID")]
        public string CorrespondentAssignmentID { get => _correspondentAssignmentID; set => _correspondentAssignmentID = value; }
        private DirtyValue<string> _county;
        /// <summary>
        /// Freddie Mac Lender County [977]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender County")]
        public string County { get => _county; set => _county = value; }
        private DirtyValue<StringEnumValue<CreditReportCompany>> _creditReportCompany;
        /// <summary>
        /// Freddie Mac Merged Credit Rpt Source [CASASRN.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Merged Credit Rpt Source")]
        public StringEnumValue<CreditReportCompany> CreditReportCompany { get => _creditReportCompany; set => _creditReportCompany = value; }
        private DirtyValue<decimal?> _financingConcessions;
        /// <summary>
        /// Freddie Mac Financing Concessions [CASASRN.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Financing Concessions")]
        public decimal? FinancingConcessions { get => _financingConcessions; set => _financingConcessions = value; }
        private DirtyValue<string> _freddieFiel11;
        /// <summary>
        /// Freddie Mac AccountChek Asset ID (Bor) [CASASRN.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac AccountChek Asset ID (Bor)")]
        public string FreddieFiel11 { get => _freddieFiel11; set => _freddieFiel11 = value; }
        private DirtyValue<string> _freddieFiel12;
        /// <summary>
        /// Freddie Mac AccountChek Asset ID (CoBor) [CASASRN.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac AccountChek Asset ID (CoBor)")]
        public string FreddieFiel12 { get => _freddieFiel12; set => _freddieFiel12 = value; }
        private DirtyValue<string> _freddieFiel13;
        /// <summary>
        /// Freddie Mac Freddie Field 13 [CASASRN.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Freddie Field 13")]
        public string FreddieFiel13 { get => _freddieFiel13; set => _freddieFiel13 = value; }
        private DirtyValue<string> _freddieFiel14;
        /// <summary>
        /// Freddie Mac Freddie Field 14 [CASASRN.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Freddie Field 14")]
        public string FreddieFiel14 { get => _freddieFiel14; set => _freddieFiel14 = value; }
        private DirtyValue<string> _freddieFiel15;
        /// <summary>
        /// Freddie Mac Freddie Field 15 [CASASRN.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Freddie Field 15")]
        public string FreddieFiel15 { get => _freddieFiel15; set => _freddieFiel15 = value; }
        private DirtyValue<string> _freddieField3;
        /// <summary>
        /// Freddie Mac Freddie Field 3 [CASASRN.X162]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Freddie Field 3")]
        public string FreddieField3 { get => _freddieField3; set => _freddieField3 = value; }
        private DirtyValue<string> _freddieField7;
        /// <summary>
        /// Freddie Mac Freddie Field 7 [CASASRN.X166]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Freddie Field 7")]
        public string FreddieField7 { get => _freddieField7; set => _freddieField7 = value; }
        private DirtyValue<string> _hELOCActualBalance;
        /// <summary>
        /// Freddie Mac HELOC Actual Bal [CASASRN.X167]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac HELOC Actual Bal")]
        public string HELOCActualBalance { get => _hELOCActualBalance; set => _hELOCActualBalance = value; }
        private DirtyValue<string> _hELOCCreditLimit;
        /// <summary>
        /// Freddie Mac HELOC Credit Limit [CASASRN.X168]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac HELOC Credit Limit")]
        public string HELOCCreditLimit { get => _hELOCCreditLimit; set => _hELOCCreditLimit = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FreddieMac Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _lenderAltPhone;
        /// <summary>
        /// Freddie Mac Lender Alt Phone [CASASRN.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Freddie Mac Lender Alt Phone")]
        public string LenderAltPhone { get => _lenderAltPhone; set => _lenderAltPhone = value; }
        private DirtyValue<string> _lenderRegistration;
        /// <summary>
        /// Freddie Mac Lender Registration # [CASASRN.X161]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Registration #")]
        public string LenderRegistration { get => _lenderRegistration; set => _lenderRegistration = value; }
        private DirtyValue<string> _loanProspectorID;
        /// <summary>
        /// Freddie Mac Loan Prospector ID [CASASRN.X200]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Loan Prospector ID")]
        public string LoanProspectorID { get => _loanProspectorID; set => _loanProspectorID = value; }
        private DirtyValue<StringEnumValue<LoanToConduitCode>> _loanToConduitCode;
        /// <summary>
        /// Freddie Mac Conduit [CASASRN.X106]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Conduit")]
        public StringEnumValue<LoanToConduitCode> LoanToConduitCode { get => _loanToConduitCode; set => _loanToConduitCode = value; }
        private DirtyValue<string> _longLegalDescription;
        /// <summary>
        /// Freddie Mac Long Legal Descr [CASASRN.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Long Legal Descr")]
        public string LongLegalDescription { get => _longLegalDescription; set => _longLegalDescription = value; }
        private DirtyValue<StringEnumValue<LossCoverage>> _lossCoverage;
        /// <summary>
        /// Freddie Mac Loss Coverage Est [CASASRN.X160]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Loss Coverage Est")]
        public StringEnumValue<LossCoverage> LossCoverage { get => _lossCoverage; set => _lossCoverage = value; }
        private DirtyValue<string> _lPKeyNumber;
        /// <summary>
        /// Freddie Mac LP Key # [CASASRN.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac LP Key #")]
        public string LPKeyNumber { get => _lPKeyNumber; set => _lPKeyNumber = value; }
        private DirtyValue<StringEnumValue<MIRefundOption>> _mIRefundOption;
        /// <summary>
        /// Freddie Mac MI Refundable Option [CASASRN.X146]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Refundable Option")]
        public StringEnumValue<MIRefundOption> MIRefundOption { get => _mIRefundOption; set => _mIRefundOption = value; }
        private DirtyValue<StringEnumValue<MortgageInsuranceCompany>> _mortgageInsuranceCompany;
        /// <summary>
        /// Freddie Mac MI Souce [CASASRN.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Souce")]
        public StringEnumValue<MortgageInsuranceCompany> MortgageInsuranceCompany { get => _mortgageInsuranceCompany; set => _mortgageInsuranceCompany = value; }
        private DirtyValue<decimal?> _netPurchasePrice;
        /// <summary>
        /// Freddie Mac Lender Net Purch Price [CASASRN.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Lender Net Purch Price")]
        public decimal? NetPurchasePrice { get => _netPurchasePrice; set => _netPurchasePrice = value; }
        private DirtyValue<StringEnumValue<NewConstructionType>> _newConstructionType;
        /// <summary>
        /// Freddie Mac New Construction Type [CASASRN.X197]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac New Construction Type")]
        public StringEnumValue<NewConstructionType> NewConstructionType { get => _newConstructionType; set => _newConstructionType = value; }
        private DirtyValue<StringEnumValue<NoAppraisalMAF>> _noAppraisalMAF;
        /// <summary>
        /// Freddie Mac No-Appraisal MAF [CASASRN.X164]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac No-Appraisal MAF")]
        public StringEnumValue<NoAppraisalMAF> NoAppraisalMAF { get => _noAppraisalMAF; set => _noAppraisalMAF = value; }
        private DirtyValue<decimal?> _nonOccupantNonHousingDebt;
        /// <summary>
        /// Freddie Mac Total Debt [CASASRN.X174]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Freddie Mac Total Debt")]
        public decimal? NonOccupantNonHousingDebt { get => _nonOccupantNonHousingDebt; set => _nonOccupantNonHousingDebt = value; }
        private DirtyValue<decimal?> _nonOccupantPresentHE;
        /// <summary>
        /// Freddie Mac Total Non-Occ Pres Housing Exp [CASASRN.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Freddie Mac Total Non-Occ Pres Housing Exp")]
        public decimal? NonOccupantPresentHE { get => _nonOccupantPresentHE; set => _nonOccupantPresentHE = value; }
        private DirtyValue<bool?> _orderCreditEvaluationIndicator;
        /// <summary>
        /// Freddie Mac Order Credit [CASASRN.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Order Credit", OptionsJson = "{\"true\":\"Order Credit Evaluation\"}")]
        public bool? OrderCreditEvaluationIndicator { get => _orderCreditEvaluationIndicator; set => _orderCreditEvaluationIndicator = value; }
        private DirtyValue<bool?> _orderMergedCreditReportIndicator;
        /// <summary>
        /// Freddie Mac Order Merged Credit Rpt [CASASRN.X88]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Order Merged Credit Rpt", OptionsJson = "{\"true\":\"Order Merged Credit Report\"}")]
        public bool? OrderMergedCreditReportIndicator { get => _orderMergedCreditReportIndicator; set => _orderMergedCreditReportIndicator = value; }
        private DirtyValue<StringEnumValue<OrderMortgageInsurance>> _orderMortgageInsurance;
        /// <summary>
        /// Freddie Mac Order MI [CASASRN.X89]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Order MI")]
        public StringEnumValue<OrderMortgageInsurance> OrderMortgageInsurance { get => _orderMortgageInsurance; set => _orderMortgageInsurance = value; }
        private DirtyValue<bool?> _orderRiskGradeEvaluationIndicator;
        /// <summary>
        /// Freddie Mac Order Risk Grade Eval [CASASRN.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Order Risk Grade Eval", OptionsJson = "{\"true\":\"Order Risk Grade Evaluation\"}")]
        public bool? OrderRiskGradeEvaluationIndicator { get => _orderRiskGradeEvaluationIndicator; set => _orderRiskGradeEvaluationIndicator = value; }
        private DirtyValue<decimal?> _originalIntRate;
        /// <summary>
        /// Freddie Mac Lender Orig Interest Rate [CASASRN.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Freddie Mac Lender Orig Interest Rate")]
        public decimal? OriginalIntRate { get => _originalIntRate; set => _originalIntRate = value; }
        private DirtyValue<string> _originateID;
        /// <summary>
        /// Freddie Mac FHA/VA Originate ID [CASASRN.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac FHA/VA Originate ID")]
        public string OriginateID { get => _originateID; set => _originateID = value; }
        private DirtyValue<StringEnumValue<PaymentFrequency>> _paymentFrequency;
        /// <summary>
        /// Freddie Mac MI Pymt Frequency [CASASRN.X154]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Pymt Frequency")]
        public StringEnumValue<PaymentFrequency> PaymentFrequency { get => _paymentFrequency; set => _paymentFrequency = value; }
        private DirtyValue<StringEnumValue<PaymentOption>> _paymentOption;
        /// <summary>
        /// Freddie Mac MI Pymt Option [CASASRN.X152]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Pymt Option")]
        public StringEnumValue<PaymentOption> PaymentOption { get => _paymentOption; set => _paymentOption = value; }
        private DirtyValue<decimal?> _personIncomeForSelfEmployment1;
        /// <summary>
        /// Freddie Mac Borr Income from Self Emp [CASASRN.X178]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Borr Income from Self Emp")]
        public decimal? PersonIncomeForSelfEmployment1 { get => _personIncomeForSelfEmployment1; set => _personIncomeForSelfEmployment1 = value; }
        private DirtyValue<decimal?> _personIncomeForSelfEmployment2;
        /// <summary>
        /// Freddie Mac Co-Borr Income from Self Emp [CASASRN.X179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Co-Borr Income from Self Emp")]
        public decimal? PersonIncomeForSelfEmployment2 { get => _personIncomeForSelfEmployment2; set => _personIncomeForSelfEmployment2 = value; }
        private DirtyValue<int?> _personPercentOfBusinessOwned1;
        /// <summary>
        /// Freddie Mac Borr % of Business Owned [CASASRN.X176]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Borr % of Business Owned")]
        public int? PersonPercentOfBusinessOwned1 { get => _personPercentOfBusinessOwned1; set => _personPercentOfBusinessOwned1 = value; }
        private DirtyValue<int?> _personPercentOfBusinessOwned2;
        /// <summary>
        /// Freddie Mac Co-Borr % of Business Owned [CASASRN.X177]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Co-Borr % of Business Owned")]
        public int? PersonPercentOfBusinessOwned2 { get => _personPercentOfBusinessOwned2; set => _personPercentOfBusinessOwned2 = value; }
        private DirtyValue<StringEnumValue<PremiumSource>> _premiumSource;
        /// <summary>
        /// Freddie Mac MI Premium Source [CASASRN.X158]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Premium Source")]
        public StringEnumValue<PremiumSource> PremiumSource { get => _premiumSource; set => _premiumSource = value; }
        private DirtyValue<decimal?> _presentHousingExpense;
        /// <summary>
        /// Freddie Mac Total Present Housing Expense [CASASRN.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Freddie Mac Total Present Housing Expense")]
        public decimal? PresentHousingExpense { get => _presentHousingExpense; set => _presentHousingExpense = value; }
        private DirtyValue<StringEnumValue<ProcessingPoint>> _processingPoint;
        /// <summary>
        /// Freddie Mac Lender Processing Point [CASASRN.X107]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Processing Point")]
        public StringEnumValue<ProcessingPoint> ProcessingPoint { get => _processingPoint; set => _processingPoint = value; }
        private DirtyValue<StringEnumValue<FreddieMacPropertyType>> _propertyType;
        /// <summary>
        /// Freddie Mac Lender Property Type [CASASRN.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Property Type")]
        public StringEnumValue<FreddieMacPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<StringEnumValue<FreddieMacPurposeOfLoan>> _purposeOfLoan;
        /// <summary>
        /// Freddie Mac Lender Loan Purpose [CASASRN.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Loan Purpose")]
        public StringEnumValue<FreddieMacPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => _purposeOfLoan = value; }
        private DirtyValue<StringEnumValue<RenewalOption>> _renewalOption;
        /// <summary>
        /// Freddie Mac MI Renewal Option [CASASRN.X150]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Renewal Option")]
        public StringEnumValue<RenewalOption> RenewalOption { get => _renewalOption; set => _renewalOption = value; }
        private DirtyValue<StringEnumValue<RenewalType>> _renewalType;
        /// <summary>
        /// Freddie Mac MI Renewal Type [CASASRN.X148]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Renewal Type")]
        public StringEnumValue<RenewalType> RenewalType { get => _renewalType; set => _renewalType = value; }
        private DirtyValue<StringEnumValue<RequiredDocumentType>> _requiredDocumentType;
        /// <summary>
        /// Freddie Mac Lender Requiredd Doc Type [CASASRN.X144]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Requiredd Doc Type")]
        public StringEnumValue<RequiredDocumentType> RequiredDocumentType { get => _requiredDocumentType; set => _requiredDocumentType = value; }
        private DirtyValue<decimal?> _reserves;
        /// <summary>
        /// Freddie Mac Total Reserves [CASASRN.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Freddie Mac Total Reserves")]
        public decimal? Reserves { get => _reserves; set => _reserves = value; }
        private DirtyValue<bool?> _retailLoanIndicator;
        /// <summary>
        /// Freddie Mac Lender Retail Loan [CASASRN.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Retail Loan", OptionsJson = "{\"true\":\"Retail loan\"}")]
        public bool? RetailLoanIndicator { get => _retailLoanIndicator; set => _retailLoanIndicator = value; }
        private DirtyValue<StringEnumValue<FreddieMacRiskClass>> _riskClass;
        /// <summary>
        /// Freddie Mac Risk Class [CASASRN.X98]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Risk Class")]
        public StringEnumValue<FreddieMacRiskClass> RiskClass { get => _riskClass; set => _riskClass = value; }
        private DirtyValue<StringEnumValue<RiskGradeEvaluationType>> _riskGradeEvaluationType;
        /// <summary>
        /// Freddie Mac Order Risk Grade Eval Source [CASASRN.X173]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Order Risk Grade Eval Source")]
        public StringEnumValue<RiskGradeEvaluationType> RiskGradeEvaluationType { get => _riskGradeEvaluationType; set => _riskGradeEvaluationType = value; }
        private DirtyValue<decimal?> _salesConcessions;
        /// <summary>
        /// Freddie Mac Lender Sales Concessions [CASASRN.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Lender Sales Concessions")]
        public decimal? SalesConcessions { get => _salesConcessions; set => _salesConcessions = value; }
        private DirtyValue<StringEnumValue<SecondaryFinancingType>> _secondaryFinancingType;
        /// <summary>
        /// Freddie Mac Lender Secondary Finance [CASASRN.X112]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Secondary Finance")]
        public StringEnumValue<SecondaryFinancingType> SecondaryFinancingType { get => _secondaryFinancingType; set => _secondaryFinancingType = value; }
        private DirtyValue<bool?> _secondTrustRefiIndicator;
        /// <summary>
        /// Freddie Mac Lender 2nd Trust Pd on Closing [CASASRN.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender 2nd Trust Pd on Closing", OptionsJson = "{\"true\":\"Second Trust Paid on closing\"}")]
        public bool? SecondTrustRefiIndicator { get => _secondTrustRefiIndicator; set => _secondTrustRefiIndicator = value; }
        private DirtyValue<decimal?> _simulatedPITI;
        /// <summary>
        /// Freddie Mac Lender Simulated PITI [CASASRN.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Lender Simulated PITI")]
        public decimal? SimulatedPITI { get => _simulatedPITI; set => _simulatedPITI = value; }
        private DirtyValue<string> _sizeOfHousehold;
        /// <summary>
        /// Freddie Mac FHA/VA Info Houshld Size [CASASRN.X145]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac FHA/VA Info Houshld Size")]
        public string SizeOfHousehold { get => _sizeOfHousehold; set => _sizeOfHousehold = value; }
        private DirtyValue<string> _specialInstruction1;
        /// <summary>
        /// Freddie Mac Special Instructions 1 [CASASRN.X100]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Special Instructions 1")]
        public string SpecialInstruction1 { get => _specialInstruction1; set => _specialInstruction1 = value; }
        private DirtyValue<string> _specialInstruction2;
        /// <summary>
        /// Freddie Mac Special Instructions 2 [CASASRN.X101]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Special Instructions 2")]
        public string SpecialInstruction2 { get => _specialInstruction2; set => _specialInstruction2 = value; }
        private DirtyValue<string> _specialInstruction3;
        /// <summary>
        /// Freddie Mac Special Instructions 3 [CASASRN.X102]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Special Instructions 3")]
        public string SpecialInstruction3 { get => _specialInstruction3; set => _specialInstruction3 = value; }
        private DirtyValue<string> _specialInstruction4;
        /// <summary>
        /// Freddie Mac Special Instructions 4 [CASASRN.X103]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Special Instructions 4")]
        public string SpecialInstruction4 { get => _specialInstruction4; set => _specialInstruction4 = value; }
        private DirtyValue<string> _specialInstruction5;
        /// <summary>
        /// Freddie Mac Special Instructions 5 [CASASRN.X104]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Special Instructions 5")]
        public string SpecialInstruction5 { get => _specialInstruction5; set => _specialInstruction5 = value; }
        private DirtyValue<string> _state;
        /// <summary>
        /// Freddie Mac Lender APN State [CASASRN.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender APN State")]
        public string State { get => _state; set => _state = value; }
        private DirtyValue<bool?> _transferLoanToConduitIndicator;
        /// <summary>
        /// Freddie Mac Transfer Loan to Conduit [CASASRN.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Transfer Loan to Conduit", OptionsJson = "{\"true\":\"Transfer Loan to Conduit\"}")]
        public bool? TransferLoanToConduitIndicator { get => _transferLoanToConduitIndicator; set => _transferLoanToConduitIndicator = value; }
        private DirtyValue<StringEnumValue<YearsOfCoverage>> _yearsOfCoverage;
        /// <summary>
        /// Freddie Mac MI Yrs Coverage [CASASRN.X156]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac MI Yrs Coverage")]
        public StringEnumValue<YearsOfCoverage> YearsOfCoverage { get => _yearsOfCoverage; set => _yearsOfCoverage = value; }
        internal override bool DirtyInternal
        {
            get => _affordableProduct.Dirty
                || _alimonyAsIncomeReduction.Dirty
                || _allMonthlyPayments.Dirty
                || _allowsNegativeAmortizationIndicator.Dirty
                || _amountOfFinancedMI.Dirty
                || _aPNCity.Dirty
                || _armsLengthTransactionIndicator.Dirty
                || _borrowerQualifiesAsVeteranIndicator.Dirty
                || _brokerOriginated.Dirty
                || _buydownContributor.Dirty
                || _condoClass.Dirty
                || _convertibleFeeAmount.Dirty
                || _convertibleFeePercent.Dirty
                || _convertibleMaxRateAdjPercent.Dirty
                || _convertibleMinRateAdjPercent.Dirty
                || _correspondentAssignmentID.Dirty
                || _county.Dirty
                || _creditReportCompany.Dirty
                || _financingConcessions.Dirty
                || _freddieFiel11.Dirty
                || _freddieFiel12.Dirty
                || _freddieFiel13.Dirty
                || _freddieFiel14.Dirty
                || _freddieFiel15.Dirty
                || _freddieField3.Dirty
                || _freddieField7.Dirty
                || _hELOCActualBalance.Dirty
                || _hELOCCreditLimit.Dirty
                || _id.Dirty
                || _lenderAltPhone.Dirty
                || _lenderRegistration.Dirty
                || _loanProspectorID.Dirty
                || _loanToConduitCode.Dirty
                || _longLegalDescription.Dirty
                || _lossCoverage.Dirty
                || _lPKeyNumber.Dirty
                || _mIRefundOption.Dirty
                || _mortgageInsuranceCompany.Dirty
                || _netPurchasePrice.Dirty
                || _newConstructionType.Dirty
                || _noAppraisalMAF.Dirty
                || _nonOccupantNonHousingDebt.Dirty
                || _nonOccupantPresentHE.Dirty
                || _orderCreditEvaluationIndicator.Dirty
                || _orderMergedCreditReportIndicator.Dirty
                || _orderMortgageInsurance.Dirty
                || _orderRiskGradeEvaluationIndicator.Dirty
                || _originalIntRate.Dirty
                || _originateID.Dirty
                || _paymentFrequency.Dirty
                || _paymentOption.Dirty
                || _personIncomeForSelfEmployment1.Dirty
                || _personIncomeForSelfEmployment2.Dirty
                || _personPercentOfBusinessOwned1.Dirty
                || _personPercentOfBusinessOwned2.Dirty
                || _premiumSource.Dirty
                || _presentHousingExpense.Dirty
                || _processingPoint.Dirty
                || _propertyType.Dirty
                || _purposeOfLoan.Dirty
                || _renewalOption.Dirty
                || _renewalType.Dirty
                || _requiredDocumentType.Dirty
                || _reserves.Dirty
                || _retailLoanIndicator.Dirty
                || _riskClass.Dirty
                || _riskGradeEvaluationType.Dirty
                || _salesConcessions.Dirty
                || _secondaryFinancingType.Dirty
                || _secondTrustRefiIndicator.Dirty
                || _simulatedPITI.Dirty
                || _sizeOfHousehold.Dirty
                || _specialInstruction1.Dirty
                || _specialInstruction2.Dirty
                || _specialInstruction3.Dirty
                || _specialInstruction4.Dirty
                || _specialInstruction5.Dirty
                || _state.Dirty
                || _transferLoanToConduitIndicator.Dirty
                || _yearsOfCoverage.Dirty;
            set
            {
                _affordableProduct.Dirty = value;
                _alimonyAsIncomeReduction.Dirty = value;
                _allMonthlyPayments.Dirty = value;
                _allowsNegativeAmortizationIndicator.Dirty = value;
                _amountOfFinancedMI.Dirty = value;
                _aPNCity.Dirty = value;
                _armsLengthTransactionIndicator.Dirty = value;
                _borrowerQualifiesAsVeteranIndicator.Dirty = value;
                _brokerOriginated.Dirty = value;
                _buydownContributor.Dirty = value;
                _condoClass.Dirty = value;
                _convertibleFeeAmount.Dirty = value;
                _convertibleFeePercent.Dirty = value;
                _convertibleMaxRateAdjPercent.Dirty = value;
                _convertibleMinRateAdjPercent.Dirty = value;
                _correspondentAssignmentID.Dirty = value;
                _county.Dirty = value;
                _creditReportCompany.Dirty = value;
                _financingConcessions.Dirty = value;
                _freddieFiel11.Dirty = value;
                _freddieFiel12.Dirty = value;
                _freddieFiel13.Dirty = value;
                _freddieFiel14.Dirty = value;
                _freddieFiel15.Dirty = value;
                _freddieField3.Dirty = value;
                _freddieField7.Dirty = value;
                _hELOCActualBalance.Dirty = value;
                _hELOCCreditLimit.Dirty = value;
                _id.Dirty = value;
                _lenderAltPhone.Dirty = value;
                _lenderRegistration.Dirty = value;
                _loanProspectorID.Dirty = value;
                _loanToConduitCode.Dirty = value;
                _longLegalDescription.Dirty = value;
                _lossCoverage.Dirty = value;
                _lPKeyNumber.Dirty = value;
                _mIRefundOption.Dirty = value;
                _mortgageInsuranceCompany.Dirty = value;
                _netPurchasePrice.Dirty = value;
                _newConstructionType.Dirty = value;
                _noAppraisalMAF.Dirty = value;
                _nonOccupantNonHousingDebt.Dirty = value;
                _nonOccupantPresentHE.Dirty = value;
                _orderCreditEvaluationIndicator.Dirty = value;
                _orderMergedCreditReportIndicator.Dirty = value;
                _orderMortgageInsurance.Dirty = value;
                _orderRiskGradeEvaluationIndicator.Dirty = value;
                _originalIntRate.Dirty = value;
                _originateID.Dirty = value;
                _paymentFrequency.Dirty = value;
                _paymentOption.Dirty = value;
                _personIncomeForSelfEmployment1.Dirty = value;
                _personIncomeForSelfEmployment2.Dirty = value;
                _personPercentOfBusinessOwned1.Dirty = value;
                _personPercentOfBusinessOwned2.Dirty = value;
                _premiumSource.Dirty = value;
                _presentHousingExpense.Dirty = value;
                _processingPoint.Dirty = value;
                _propertyType.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _renewalOption.Dirty = value;
                _renewalType.Dirty = value;
                _requiredDocumentType.Dirty = value;
                _reserves.Dirty = value;
                _retailLoanIndicator.Dirty = value;
                _riskClass.Dirty = value;
                _riskGradeEvaluationType.Dirty = value;
                _salesConcessions.Dirty = value;
                _secondaryFinancingType.Dirty = value;
                _secondTrustRefiIndicator.Dirty = value;
                _simulatedPITI.Dirty = value;
                _sizeOfHousehold.Dirty = value;
                _specialInstruction1.Dirty = value;
                _specialInstruction2.Dirty = value;
                _specialInstruction3.Dirty = value;
                _specialInstruction4.Dirty = value;
                _specialInstruction5.Dirty = value;
                _state.Dirty = value;
                _transferLoanToConduitIndicator.Dirty = value;
                _yearsOfCoverage.Dirty = value;
            }
        }
    }
}