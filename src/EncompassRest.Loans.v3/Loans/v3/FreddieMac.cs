using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FreddieMac
/// </summary>
public sealed partial class FreddieMac : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<AffordableProduct>>? _affordableProduct;
    private DirtyValue<decimal?>? _alimonyAsIncomeReduction;
    private DirtyValue<decimal?>? _allMonthlyPayments;
    private DirtyValue<bool?>? _allowsNegativeAmortizationIndicator;
    private DirtyValue<string?>? _amountOfFinancedMi;
    private DirtyValue<string?>? _apnCity;
    private DirtyValue<bool?>? _armsLengthTransactionIndicator;
    private DirtyValue<bool?>? _borrowerQualifiesAsVeteranIndicator;
    private DirtyValue<string?>? _brokerOriginated;
    private DirtyValue<StringEnumValue<BuydownContributor>>? _buydownContributor;
    private DirtyValue<StringEnumValue<CondoClass>>? _condoClass;
    private DirtyValue<decimal?>? _convertibleFeeAmount;
    private DirtyValue<decimal?>? _convertibleFeePercent;
    private DirtyValue<decimal?>? _convertibleMaxRateAdjPercent;
    private DirtyValue<decimal?>? _convertibleMinRateAdjPercent;
    private DirtyValue<string?>? _correspondentAssignmentId;
    private DirtyValue<string?>? _county;
    private DirtyValue<StringEnumValue<CreditReportCompany>>? _creditReportCompany;
    private DirtyValue<decimal?>? _financingConcessions;
    private DirtyValue<string?>? _freddieFiel11;
    private DirtyValue<string?>? _freddieFiel12;
    private DirtyValue<string?>? _freddieFiel13;
    private DirtyValue<string?>? _freddieFiel14;
    private DirtyValue<string?>? _freddieFiel15;
    private DirtyValue<string?>? _freddieField3;
    private DirtyValue<string?>? _freddieField7;
    private DirtyValue<string?>? _freddieMacAppraisalHybrid;
    private DirtyValue<string?>? _freddieMacOwnedMessage;
    private DirtyValue<string?>? _helocActualBalance;
    private DirtyValue<string?>? _helocCreditLimit;
    private DirtyValue<string?>? _lenderAltPhone;
    private DirtyValue<string?>? _lenderRegistration;
    private DirtyValue<string?>? _loanProspectorId;
    private DirtyValue<StringEnumValue<LoanToConduitCode>>? _loanToConduitCode;
    private DirtyValue<string?>? _longLegalDescription;
    private DirtyValue<StringEnumValue<LossCoverage>>? _lossCoverage;
    private DirtyValue<string?>? _lpKeyNumber;
    private DirtyValue<StringEnumValue<MIRefundOption>>? _miRefundOption;
    private DirtyValue<StringEnumValue<MortgageInsuranceCompany>>? _mortgageInsuranceCompany;
    private DirtyValue<decimal?>? _netPurchasePrice;
    private DirtyValue<StringEnumValue<NewConstructionType>>? _newConstructionType;
    private DirtyValue<StringEnumValue<NoAppraisalMAF>>? _noAppraisalMaf;
    private DirtyValue<decimal?>? _nonOccupantNonHousingDebt;
    private DirtyValue<decimal?>? _nonOccupantPresentHe;
    private DirtyValue<bool?>? _orderCreditEvaluationIndicator;
    private DirtyValue<bool?>? _orderMergedCreditReportIndicator;
    private DirtyValue<StringEnumValue<OrderMortgageInsurance>>? _orderMortgageInsurance;
    private DirtyValue<bool?>? _orderRiskGradeEvaluationIndicator;
    private DirtyValue<decimal?>? _originalIntRate;
    private DirtyValue<string?>? _originateId;
    private DirtyValue<StringEnumValue<PaymentFrequency>>? _paymentFrequency;
    private DirtyValue<StringEnumValue<PaymentOption>>? _paymentOption;
    private DirtyValue<decimal?>? _personIncomeForSelfEmployment1;
    private DirtyValue<decimal?>? _personIncomeForSelfEmployment2;
    private DirtyValue<int?>? _personPercentOfBusinessOwned1;
    private DirtyValue<int?>? _personPercentOfBusinessOwned2;
    private DirtyValue<StringEnumValue<PremiumSource>>? _premiumSource;
    private DirtyValue<decimal?>? _presentHousingExpense;
    private DirtyValue<StringEnumValue<ProcessingPoint>>? _processingPoint;
    private DirtyValue<StringEnumValue<FreddieMacPropertyType>>? _propertyType;
    private DirtyValue<StringEnumValue<FreddieMacPurposeOfLoan>>? _purposeOfLoan;
    private DirtyValue<StringEnumValue<RenewalOption>>? _renewalOption;
    private DirtyValue<StringEnumValue<RenewalType>>? _renewalType;
    private DirtyValue<StringEnumValue<RequiredDocumentType>>? _requiredDocumentType;
    private DirtyValue<decimal?>? _reserves;
    private DirtyValue<bool?>? _retailLoanIndicator;
    private DirtyValue<StringEnumValue<FreddieMacRiskClass>>? _riskClass;
    private DirtyValue<StringEnumValue<RiskGradeEvaluationType>>? _riskGradeEvaluationType;
    private DirtyValue<decimal?>? _salesConcessions;
    private DirtyValue<StringEnumValue<SecondaryFinancingType>>? _secondaryFinancingType;
    private DirtyValue<bool?>? _secondTrustRefiIndicator;
    private DirtyValue<decimal?>? _simulatedPiti;
    private DirtyValue<string?>? _sizeOfHousehold;
    private DirtyValue<string?>? _specialInstruction1;
    private DirtyValue<string?>? _specialInstruction2;
    private DirtyValue<string?>? _specialInstruction3;
    private DirtyValue<string?>? _specialInstruction4;
    private DirtyValue<string?>? _specialInstruction5;
    private DirtyValue<string?>? _state;
    private DirtyValue<bool?>? _transferLoanToConduitIndicator;
    private DirtyValue<StringEnumValue<YearsOfCoverage>>? _yearsOfCoverage;

    /// <summary>
    /// Freddie Mac Lender Affordable Product [CASASRN.X114]
    /// </summary>
    public StringEnumValue<AffordableProduct> AffordableProduct { get => _affordableProduct; set => SetField(ref _affordableProduct, value); }

    /// <summary>
    /// Freddie Mac FHA/VA Alimony as Inc Reduc [CASASRN.X159]
    /// </summary>
    public decimal? AlimonyAsIncomeReduction { get => _alimonyAsIncomeReduction; set => SetField(ref _alimonyAsIncomeReduction, value); }

    /// <summary>
    /// Freddie Mac Total All Mo Pymts [CASASRN.X99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AllMonthlyPayments { get => _allMonthlyPayments; set => SetField(ref _allMonthlyPayments, value); }

    /// <summary>
    /// Freddie Mac Lender Allows Neg Amort [CASASRN.X85]
    /// </summary>
    public bool? AllowsNegativeAmortizationIndicator { get => _allowsNegativeAmortizationIndicator; set => SetField(ref _allowsNegativeAmortizationIndicator, value); }

    /// <summary>
    /// Freddie Mac Amt Financed MI [CASASRN.X169]
    /// </summary>
    public string? AmountOfFinancedMi { get => _amountOfFinancedMi; set => SetField(ref _amountOfFinancedMi, value); }

    /// <summary>
    /// Freddie Mac Lender APN City [CASASRN.X17]
    /// </summary>
    public string? ApnCity { get => _apnCity; set => SetField(ref _apnCity, value); }

    /// <summary>
    /// Freddie Mac Lender Arms-Length Trans [CASASRN.X81]
    /// </summary>
    public bool? ArmsLengthTransactionIndicator { get => _armsLengthTransactionIndicator; set => SetField(ref _armsLengthTransactionIndicator, value); }

    /// <summary>
    /// Borr Qualifies as Veteran [156]
    /// </summary>
    public bool? BorrowerQualifiesAsVeteranIndicator { get => _borrowerQualifiesAsVeteranIndicator; set => SetField(ref _borrowerQualifiesAsVeteranIndicator, value); }

    /// <summary>
    /// Freddie Mac Broker Originated [CASASRN.X165]
    /// </summary>
    public string? BrokerOriginated { get => _brokerOriginated; set => SetField(ref _brokerOriginated, value); }

    /// <summary>
    /// Freddie Mac Buydown Contributor [CASASRN.X141]
    /// </summary>
    public StringEnumValue<BuydownContributor> BuydownContributor { get => _buydownContributor; set => SetField(ref _buydownContributor, value); }

    /// <summary>
    /// Freddie Mac Lender Condo Class [CASASRN.X84]
    /// </summary>
    public StringEnumValue<CondoClass> CondoClass { get => _condoClass; set => SetField(ref _condoClass, value); }

    /// <summary>
    /// Conversion Option Fee Amount [CnvrOpt.FeeAmt]
    /// </summary>
    public decimal? ConvertibleFeeAmount { get => _convertibleFeeAmount; set => SetField(ref _convertibleFeeAmount, value); }

    /// <summary>
    /// Conversion Option Fee Percent [CnvrOpt.FeePct]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleFeePercent { get => _convertibleFeePercent; set => SetField(ref _convertibleFeePercent, value); }

    /// <summary>
    /// Conversion Option Max. Rate Adj. [CnvrOpt.MaxRateAdj]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleMaxRateAdjPercent { get => _convertibleMaxRateAdjPercent; set => SetField(ref _convertibleMaxRateAdjPercent, value); }

    /// <summary>
    /// Conversion Option Min. Rate Adj. [CnvrOpt.MinRateAdj]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleMinRateAdjPercent { get => _convertibleMinRateAdjPercent; set => SetField(ref _convertibleMinRateAdjPercent, value); }

    /// <summary>
    /// Freddie Mac Correspondent Assignment Center ID [CASASRN.X203]
    /// </summary>
    public string? CorrespondentAssignmentId { get => _correspondentAssignmentId; set => SetField(ref _correspondentAssignmentId, value); }

    /// <summary>
    /// Freddie Mac Lender County [977]
    /// </summary>
    public string? County { get => _county; set => SetField(ref _county, value); }

    /// <summary>
    /// Freddie Mac Merged Credit Rpt Source [CASASRN.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<CreditReportCompany> CreditReportCompany { get => _creditReportCompany; set => SetField(ref _creditReportCompany, value); }

    /// <summary>
    /// Freddie Mac Financing Concessions [CASASRN.X20]
    /// </summary>
    public decimal? FinancingConcessions { get => _financingConcessions; set => SetField(ref _financingConcessions, value); }

    /// <summary>
    /// Freddie Mac AccountChek Asset ID (Bor) [CASASRN.X31]
    /// </summary>
    public string? FreddieFiel11 { get => _freddieFiel11; set => SetField(ref _freddieFiel11, value); }

    /// <summary>
    /// Freddie Mac AccountChek Asset ID (CoBor) [CASASRN.X32]
    /// </summary>
    public string? FreddieFiel12 { get => _freddieFiel12; set => SetField(ref _freddieFiel12, value); }

    /// <summary>
    /// Freddie Mac Freddie Field 13 [CASASRN.X33]
    /// </summary>
    public string? FreddieFiel13 { get => _freddieFiel13; set => SetField(ref _freddieFiel13, value); }

    /// <summary>
    /// Freddie Mac Risk Class [CASASRN.X34]
    /// </summary>
    public string? FreddieFiel14 { get => _freddieFiel14; set => SetField(ref _freddieFiel14, value); }

    /// <summary>
    /// Correspondent Assignment Name [CASASRN.X35]
    /// </summary>
    public string? FreddieFiel15 { get => _freddieFiel15; set => SetField(ref _freddieFiel15, value); }

    /// <summary>
    /// Freddie Mac Freddie Field 3 [CASASRN.X162]
    /// </summary>
    public string? FreddieField3 { get => _freddieField3; set => SetField(ref _freddieField3, value); }

    /// <summary>
    /// LoanBeam [CASASRN.X166]
    /// </summary>
    public string? FreddieField7 { get => _freddieField7; set => SetField(ref _freddieField7, value); }

    /// <summary>
    /// Freddie Mac Appraisal Hybrid [CASASRN.X205]
    /// </summary>
    public string? FreddieMacAppraisalHybrid { get => _freddieMacAppraisalHybrid; set => SetField(ref _freddieMacAppraisalHybrid, value); }

    /// <summary>
    /// Freddie Mac Owned Message [CASASRN.X204]
    /// </summary>
    public string? FreddieMacOwnedMessage { get => _freddieMacOwnedMessage; set => SetField(ref _freddieMacOwnedMessage, value); }

    /// <summary>
    /// Freddie Mac HELOC Actual Bal [CASASRN.X167]
    /// </summary>
    public string? HelocActualBalance { get => _helocActualBalance; set => SetField(ref _helocActualBalance, value); }

    /// <summary>
    /// Freddie Mac HELOC Credit Limit [CASASRN.X168]
    /// </summary>
    public string? HelocCreditLimit { get => _helocCreditLimit; set => SetField(ref _helocCreditLimit, value); }

    /// <summary>
    /// Freddie Mac Lender Alt Phone [CASASRN.X80]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderAltPhone { get => _lenderAltPhone; set => SetField(ref _lenderAltPhone, value); }

    /// <summary>
    /// Freddie Mac Lender Registration # [CASASRN.X161]
    /// </summary>
    public string? LenderRegistration { get => _lenderRegistration; set => SetField(ref _lenderRegistration, value); }

    /// <summary>
    /// Freddie Mac Loan Prospector ID [CASASRN.X200]
    /// </summary>
    public string? LoanProspectorId { get => _loanProspectorId; set => SetField(ref _loanProspectorId, value); }

    /// <summary>
    /// Freddie Mac Conduit [CASASRN.X106]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanToConduitCode> LoanToConduitCode { get => _loanToConduitCode; set => SetField(ref _loanToConduitCode, value); }

    /// <summary>
    /// Freddie Mac Long Legal Descr [CASASRN.X41]
    /// </summary>
    public string? LongLegalDescription { get => _longLegalDescription; set => SetField(ref _longLegalDescription, value); }

    /// <summary>
    /// Freddie Mac Loss Coverage Est [CASASRN.X160]
    /// </summary>
    public StringEnumValue<LossCoverage> LossCoverage { get => _lossCoverage; set => SetField(ref _lossCoverage, value); }

    /// <summary>
    /// Freddie Mac LP Key # [CASASRN.X13]
    /// </summary>
    public string? LpKeyNumber { get => _lpKeyNumber; set => SetField(ref _lpKeyNumber, value); }

    /// <summary>
    /// Freddie Mac MI Refundable Option [CASASRN.X146]
    /// </summary>
    public StringEnumValue<MIRefundOption> MiRefundOption { get => _miRefundOption; set => SetField(ref _miRefundOption, value); }

    /// <summary>
    /// Freddie Mac MI Souce [CASASRN.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<MortgageInsuranceCompany> MortgageInsuranceCompany { get => _mortgageInsuranceCompany; set => SetField(ref _mortgageInsuranceCompany, value); }

    /// <summary>
    /// Freddie Mac Lender Net Purch Price [CASASRN.X109]
    /// </summary>
    public decimal? NetPurchasePrice { get => _netPurchasePrice; set => SetField(ref _netPurchasePrice, value); }

    /// <summary>
    /// Freddie Mac New Construction Type [CASASRN.X197]
    /// </summary>
    public StringEnumValue<NewConstructionType> NewConstructionType { get => _newConstructionType; set => SetField(ref _newConstructionType, value); }

    /// <summary>
    /// Freddie Mac No-Appraisal MAF [CASASRN.X164]
    /// </summary>
    public StringEnumValue<NoAppraisalMAF> NoAppraisalMaf { get => _noAppraisalMaf; set => SetField(ref _noAppraisalMaf, value); }

    /// <summary>
    /// Freddie Mac Total Debt [CASASRN.X174]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NonOccupantNonHousingDebt { get => _nonOccupantNonHousingDebt; set => SetField(ref _nonOccupantNonHousingDebt, value); }

    /// <summary>
    /// Freddie Mac Total Non-Occ Pres Housing Exp [CASASRN.X131]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NonOccupantPresentHe { get => _nonOccupantPresentHe; set => SetField(ref _nonOccupantPresentHe, value); }

    /// <summary>
    /// Freddie Mac Order Credit [CASASRN.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? OrderCreditEvaluationIndicator { get => _orderCreditEvaluationIndicator; set => SetField(ref _orderCreditEvaluationIndicator, value); }

    /// <summary>
    /// Freddie Mac Order Merged Credit Rpt [CASASRN.X88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? OrderMergedCreditReportIndicator { get => _orderMergedCreditReportIndicator; set => SetField(ref _orderMergedCreditReportIndicator, value); }

    /// <summary>
    /// Freddie Mac Order MI [CASASRN.X89]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<OrderMortgageInsurance> OrderMortgageInsurance { get => _orderMortgageInsurance; set => SetField(ref _orderMortgageInsurance, value); }

    /// <summary>
    /// Freddie Mac Order Risk Grade Eval [CASASRN.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? OrderRiskGradeEvaluationIndicator { get => _orderRiskGradeEvaluationIndicator; set => SetField(ref _orderRiskGradeEvaluationIndicator, value); }

    /// <summary>
    /// Freddie Mac Lender Orig Interest Rate [CASASRN.X142]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginalIntRate { get => _originalIntRate; set => SetField(ref _originalIntRate, value); }

    /// <summary>
    /// Freddie Mac FHA/VA Originate ID [CASASRN.X27]
    /// </summary>
    public string? OriginateId { get => _originateId; set => SetField(ref _originateId, value); }

    /// <summary>
    /// Freddie Mac MI Pymt Frequency [CASASRN.X154]
    /// </summary>
    public StringEnumValue<PaymentFrequency> PaymentFrequency { get => _paymentFrequency; set => SetField(ref _paymentFrequency, value); }

    /// <summary>
    /// Freddie Mac MI Pymt Option [CASASRN.X152]
    /// </summary>
    public StringEnumValue<PaymentOption> PaymentOption { get => _paymentOption; set => SetField(ref _paymentOption, value); }

    /// <summary>
    /// Freddie Mac Borr Income from Self Emp [CASASRN.X178]
    /// </summary>
    public decimal? PersonIncomeForSelfEmployment1 { get => _personIncomeForSelfEmployment1; set => SetField(ref _personIncomeForSelfEmployment1, value); }

    /// <summary>
    /// Freddie Mac Co-Borr Income from Self Emp [CASASRN.X179]
    /// </summary>
    public decimal? PersonIncomeForSelfEmployment2 { get => _personIncomeForSelfEmployment2; set => SetField(ref _personIncomeForSelfEmployment2, value); }

    /// <summary>
    /// Freddie Mac Borr % of Business Owned [CASASRN.X176]
    /// </summary>
    public int? PersonPercentOfBusinessOwned1 { get => _personPercentOfBusinessOwned1; set => SetField(ref _personPercentOfBusinessOwned1, value); }

    /// <summary>
    /// Freddie Mac Co-Borr % of Business Owned [CASASRN.X177]
    /// </summary>
    public int? PersonPercentOfBusinessOwned2 { get => _personPercentOfBusinessOwned2; set => SetField(ref _personPercentOfBusinessOwned2, value); }

    /// <summary>
    /// Freddie Mac MI Premium Source [CASASRN.X158]
    /// </summary>
    public StringEnumValue<PremiumSource> PremiumSource { get => _premiumSource; set => SetField(ref _premiumSource, value); }

    /// <summary>
    /// Freddie Mac Total Present Housing Expense [CASASRN.X16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PresentHousingExpense { get => _presentHousingExpense; set => SetField(ref _presentHousingExpense, value); }

    /// <summary>
    /// Freddie Mac Lender Processing Point [CASASRN.X107]
    /// </summary>
    public StringEnumValue<ProcessingPoint> ProcessingPoint { get => _processingPoint; set => SetField(ref _processingPoint, value); }

    /// <summary>
    /// Freddie Mac Lender Property Type [CASASRN.X14]
    /// </summary>
    public StringEnumValue<FreddieMacPropertyType> PropertyType { get => _propertyType; set => SetField(ref _propertyType, value); }

    /// <summary>
    /// Freddie Mac Lender Loan Purpose [CASASRN.X29]
    /// </summary>
    public StringEnumValue<FreddieMacPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => SetField(ref _purposeOfLoan, value); }

    /// <summary>
    /// Freddie Mac MI Renewal Option [CASASRN.X150]
    /// </summary>
    public StringEnumValue<RenewalOption> RenewalOption { get => _renewalOption; set => SetField(ref _renewalOption, value); }

    /// <summary>
    /// Freddie Mac MI Renewal Type [CASASRN.X148]
    /// </summary>
    public StringEnumValue<RenewalType> RenewalType { get => _renewalType; set => SetField(ref _renewalType, value); }

    /// <summary>
    /// Freddie Mac Lender Requiredd Doc Type [CASASRN.X144]
    /// </summary>
    public StringEnumValue<RequiredDocumentType> RequiredDocumentType { get => _requiredDocumentType; set => SetField(ref _requiredDocumentType, value); }

    /// <summary>
    /// Freddie Mac Total Reserves [CASASRN.X78]
    /// </summary>
    public decimal? Reserves { get => _reserves; set => SetField(ref _reserves, value); }

    /// <summary>
    /// Freddie Mac Lender Retail Loan [CASASRN.X77]
    /// </summary>
    public bool? RetailLoanIndicator { get => _retailLoanIndicator; set => SetField(ref _retailLoanIndicator, value); }

    /// <summary>
    /// Freddie Mac Risk Class [CASASRN.X98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FreddieMacRiskClass> RiskClass { get => _riskClass; set => SetField(ref _riskClass, value); }

    /// <summary>
    /// Freddie Mac Order Risk Grade Eval Source [CASASRN.X173]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<RiskGradeEvaluationType> RiskGradeEvaluationType { get => _riskGradeEvaluationType; set => SetField(ref _riskGradeEvaluationType, value); }

    /// <summary>
    /// Freddie Mac Lender Sales Concessions [CASASRN.X19]
    /// </summary>
    public decimal? SalesConcessions { get => _salesConcessions; set => SetField(ref _salesConcessions, value); }

    /// <summary>
    /// Freddie Mac Lender Secondary Finance [CASASRN.X112]
    /// </summary>
    public StringEnumValue<SecondaryFinancingType> SecondaryFinancingType { get => _secondaryFinancingType; set => SetField(ref _secondaryFinancingType, value); }

    /// <summary>
    /// Freddie Mac Lender 2nd Trust Pd on Closing [CASASRN.X30]
    /// </summary>
    public bool? SecondTrustRefiIndicator { get => _secondTrustRefiIndicator; set => SetField(ref _secondTrustRefiIndicator, value); }

    /// <summary>
    /// Freddie Mac Lender Simulated PITI [CASASRN.X15]
    /// </summary>
    public decimal? SimulatedPiti { get => _simulatedPiti; set => SetField(ref _simulatedPiti, value); }

    /// <summary>
    /// Freddie Mac FHA/VA Info Houshld Size [CASASRN.X145]
    /// </summary>
    public string? SizeOfHousehold { get => _sizeOfHousehold; set => SetField(ref _sizeOfHousehold, value); }

    /// <summary>
    /// Freddie Mac Special Instructions 1 [CASASRN.X100]
    /// </summary>
    public string? SpecialInstruction1 { get => _specialInstruction1; set => SetField(ref _specialInstruction1, value); }

    /// <summary>
    /// Freddie Mac Special Instructions 2 [CASASRN.X101]
    /// </summary>
    public string? SpecialInstruction2 { get => _specialInstruction2; set => SetField(ref _specialInstruction2, value); }

    /// <summary>
    /// Freddie Mac Special Instructions 3 [CASASRN.X102]
    /// </summary>
    public string? SpecialInstruction3 { get => _specialInstruction3; set => SetField(ref _specialInstruction3, value); }

    /// <summary>
    /// Freddie Mac Special Instructions 4 [CASASRN.X103]
    /// </summary>
    public string? SpecialInstruction4 { get => _specialInstruction4; set => SetField(ref _specialInstruction4, value); }

    /// <summary>
    /// Freddie Mac Special Instructions 5 [CASASRN.X104]
    /// </summary>
    public string? SpecialInstruction5 { get => _specialInstruction5; set => SetField(ref _specialInstruction5, value); }

    /// <summary>
    /// Freddie Mac Lender APN State [CASASRN.X18]
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// Freddie Mac Transfer Loan to Conduit [CASASRN.X10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? TransferLoanToConduitIndicator { get => _transferLoanToConduitIndicator; set => SetField(ref _transferLoanToConduitIndicator, value); }

    /// <summary>
    /// Freddie Mac MI Yrs Coverage [CASASRN.X156]
    /// </summary>
    public StringEnumValue<YearsOfCoverage> YearsOfCoverage { get => _yearsOfCoverage; set => SetField(ref _yearsOfCoverage, value); }
}