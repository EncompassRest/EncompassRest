using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// FreddieMac
/// </summary>
public sealed partial class FreddieMac : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Freddie Mac Lender Affordable Product [CASASRN.X114]
    /// </summary>
    public StringEnumValue<AffordableProduct> AffordableProduct { get => GetValue<StringEnumValue<AffordableProduct>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac FHA/VA Alimony as Inc Reduc [CASASRN.X159]
    /// </summary>
    public decimal? AlimonyAsIncomeReduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total All Mo Pymts [CASASRN.X99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AllMonthlyPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Allows Neg Amort [CASASRN.X85]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Allows Negative Amortization\"}")]
    public bool? AllowsNegativeAmortizationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Amt Financed MI [CASASRN.X169]
    /// </summary>
    public string? AmountOfFinancedMI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender APN City [CASASRN.X17]
    /// </summary>
    public string? APNCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Arms-Length Trans [CASASRN.X81]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Arms-Length Transaction\"}")]
    public bool? ArmsLengthTransactionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Qualifies as Veteran [156]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"One or more borrowers qualifies as a veteran\"}")]
    public bool? BorrowerQualifiesAsVeteranIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Broker Originated [CASASRN.X165]
    /// </summary>
    public string? BrokerOriginated { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Buydown Contributor [CASASRN.X141]
    /// </summary>
    public StringEnumValue<BuydownContributor> BuydownContributor { get => GetValue<StringEnumValue<BuydownContributor>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Condo Class [CASASRN.X84]
    /// </summary>
    public StringEnumValue<CondoClass> CondoClass { get => GetValue<StringEnumValue<CondoClass>>(); set => SetValue(value); }

    /// <summary>
    /// Conversion Option Fee Amount [CnvrOpt.FeeAmt]
    /// </summary>
    public decimal? ConvertibleFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Conversion Option Fee Percent [CnvrOpt.FeePct]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Conversion Option Max. Rate Adj. [CnvrOpt.MaxRateAdj]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleMaxRateAdjPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Conversion Option Min. Rate Adj. [CnvrOpt.MinRateAdj]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConvertibleMinRateAdjPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Correspondent Assignment Center ID [CASASRN.X203]
    /// </summary>
    public string? CorrespondentAssignmentID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender County [977]
    /// </summary>
    public string? County { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Merged Credit Rpt Source [CASASRN.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<CreditReportCompany> CreditReportCompany { get => GetValue<StringEnumValue<CreditReportCompany>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Financing Concessions [CASASRN.X20]
    /// </summary>
    public decimal? FinancingConcessions { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac AccountChek Asset ID (Bor) [CASASRN.X31]
    /// </summary>
    public string? FreddieFiel11 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac AccountChek Asset ID (CoBor) [CASASRN.X32]
    /// </summary>
    public string? FreddieFiel12 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Freddie Field 13 [CASASRN.X33]
    /// </summary>
    public string? FreddieFiel13 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Risk Class [CASASRN.X34]
    /// </summary>
    public string? FreddieFiel14 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Assignment Name [CASASRN.X35]
    /// </summary>
    public string? FreddieFiel15 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Freddie Field 3 [CASASRN.X162]
    /// </summary>
    public string? FreddieField3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanBeam [CASASRN.X166]
    /// </summary>
    public string? FreddieField7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Appraisal Hybrid [CASASRN.X205]
    /// </summary>
    public string? FreddieMacAppraisalHybrid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Owned Message [CASASRN.X204]
    /// </summary>
    public string? FreddieMacOwnedMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac HELOC Actual Bal [CASASRN.X167]
    /// </summary>
    public string? HELOCActualBalance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac HELOC Credit Limit [CASASRN.X168]
    /// </summary>
    public string? HELOCCreditLimit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FreddieMac Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Alt Phone [CASASRN.X80]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderAltPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Registration # [CASASRN.X161]
    /// </summary>
    public string? LenderRegistration { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Loan Prospector ID [CASASRN.X200]
    /// </summary>
    public string? LoanProspectorID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Conduit [CASASRN.X106]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanToConduitCode> LoanToConduitCode { get => GetValue<StringEnumValue<LoanToConduitCode>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Long Legal Descr [CASASRN.X41]
    /// </summary>
    public string? LongLegalDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Loss Coverage Est [CASASRN.X160]
    /// </summary>
    public StringEnumValue<LossCoverage> LossCoverage { get => GetValue<StringEnumValue<LossCoverage>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac LP Key # [CASASRN.X13]
    /// </summary>
    public string? LPKeyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Refundable Option [CASASRN.X146]
    /// </summary>
    public StringEnumValue<MIRefundOption> MIRefundOption { get => GetValue<StringEnumValue<MIRefundOption>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Souce [CASASRN.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<MortgageInsuranceCompany> MortgageInsuranceCompany { get => GetValue<StringEnumValue<MortgageInsuranceCompany>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Net Purch Price [CASASRN.X109]
    /// </summary>
    public decimal? NetPurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac New Construction Type [CASASRN.X197]
    /// </summary>
    public StringEnumValue<NewConstructionType> NewConstructionType { get => GetValue<StringEnumValue<NewConstructionType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac No-Appraisal MAF [CASASRN.X164]
    /// </summary>
    public StringEnumValue<NoAppraisalMAF> NoAppraisalMAF { get => GetValue<StringEnumValue<NoAppraisalMAF>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total Debt [CASASRN.X174]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NonOccupantNonHousingDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total Non-Occ Pres Housing Exp [CASASRN.X131]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NonOccupantPresentHE { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Order Credit [CASASRN.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Order Credit Evaluation\"}")]
    public bool? OrderCreditEvaluationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Order Merged Credit Rpt [CASASRN.X88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Order Merged Credit Report\"}")]
    public bool? OrderMergedCreditReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Order MI [CASASRN.X89]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<OrderMortgageInsurance> OrderMortgageInsurance { get => GetValue<StringEnumValue<OrderMortgageInsurance>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Order Risk Grade Eval [CASASRN.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Order Risk Grade Evaluation\"}")]
    public bool? OrderRiskGradeEvaluationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Orig Interest Rate [CASASRN.X142]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginalIntRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac FHA/VA Originate ID [CASASRN.X27]
    /// </summary>
    public string? OriginateID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Pymt Frequency [CASASRN.X154]
    /// </summary>
    public StringEnumValue<PaymentFrequency> PaymentFrequency { get => GetValue<StringEnumValue<PaymentFrequency>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Pymt Option [CASASRN.X152]
    /// </summary>
    public StringEnumValue<PaymentOption> PaymentOption { get => GetValue<StringEnumValue<PaymentOption>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Borr Income from Self Emp [CASASRN.X178]
    /// </summary>
    public decimal? PersonIncomeForSelfEmployment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Co-Borr Income from Self Emp [CASASRN.X179]
    /// </summary>
    public decimal? PersonIncomeForSelfEmployment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Borr % of Business Owned [CASASRN.X176]
    /// </summary>
    public int? PersonPercentOfBusinessOwned1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Co-Borr % of Business Owned [CASASRN.X177]
    /// </summary>
    public int? PersonPercentOfBusinessOwned2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Premium Source [CASASRN.X158]
    /// </summary>
    public StringEnumValue<PremiumSource> PremiumSource { get => GetValue<StringEnumValue<PremiumSource>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total Present Housing Expense [CASASRN.X16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PresentHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Processing Point [CASASRN.X107]
    /// </summary>
    public StringEnumValue<ProcessingPoint> ProcessingPoint { get => GetValue<StringEnumValue<ProcessingPoint>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Property Type [CASASRN.X14]
    /// </summary>
    public StringEnumValue<FreddieMacPropertyType> PropertyType { get => GetValue<StringEnumValue<FreddieMacPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Loan Purpose [CASASRN.X29]
    /// </summary>
    public StringEnumValue<FreddieMacPurposeOfLoan> PurposeOfLoan { get => GetValue<StringEnumValue<FreddieMacPurposeOfLoan>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Renewal Option [CASASRN.X150]
    /// </summary>
    public StringEnumValue<RenewalOption> RenewalOption { get => GetValue<StringEnumValue<RenewalOption>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Renewal Type [CASASRN.X148]
    /// </summary>
    public StringEnumValue<RenewalType> RenewalType { get => GetValue<StringEnumValue<RenewalType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Requiredd Doc Type [CASASRN.X144]
    /// </summary>
    public StringEnumValue<RequiredDocumentType> RequiredDocumentType { get => GetValue<StringEnumValue<RequiredDocumentType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total Reserves [CASASRN.X78]
    /// </summary>
    public decimal? Reserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Retail Loan [CASASRN.X77]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Retail loan\"}")]
    public bool? RetailLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Risk Class [CASASRN.X98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FreddieMacRiskClass> RiskClass { get => GetValue<StringEnumValue<FreddieMacRiskClass>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Order Risk Grade Eval Source [CASASRN.X173]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<RiskGradeEvaluationType> RiskGradeEvaluationType { get => GetValue<StringEnumValue<RiskGradeEvaluationType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Sales Concessions [CASASRN.X19]
    /// </summary>
    public decimal? SalesConcessions { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Secondary Finance [CASASRN.X112]
    /// </summary>
    public StringEnumValue<SecondaryFinancingType> SecondaryFinancingType { get => GetValue<StringEnumValue<SecondaryFinancingType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender 2nd Trust Pd on Closing [CASASRN.X30]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Second Trust Paid on closing\"}")]
    public bool? SecondTrustRefiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender Simulated PITI [CASASRN.X15]
    /// </summary>
    public decimal? SimulatedPITI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac FHA/VA Info Houshld Size [CASASRN.X145]
    /// </summary>
    public string? SizeOfHousehold { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Special Instructions 1 [CASASRN.X100]
    /// </summary>
    public string? SpecialInstruction1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Special Instructions 2 [CASASRN.X101]
    /// </summary>
    public string? SpecialInstruction2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Special Instructions 3 [CASASRN.X102]
    /// </summary>
    public string? SpecialInstruction3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Special Instructions 4 [CASASRN.X103]
    /// </summary>
    public string? SpecialInstruction4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Special Instructions 5 [CASASRN.X104]
    /// </summary>
    public string? SpecialInstruction5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Lender APN State [CASASRN.X18]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Transfer Loan to Conduit [CASASRN.X10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Transfer Loan to Conduit\"}")]
    public bool? TransferLoanToConduitIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac MI Yrs Coverage [CASASRN.X156]
    /// </summary>
    public StringEnumValue<YearsOfCoverage> YearsOfCoverage { get => GetValue<StringEnumValue<YearsOfCoverage>>(); set => SetValue(value); }
}