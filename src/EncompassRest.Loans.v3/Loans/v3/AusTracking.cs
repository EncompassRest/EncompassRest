using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AusTracking
/// </summary>
public sealed partial class AusTracking : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AUS Tracking - Freddie Mac - Accept Plus Eligible [AUS.X127]
    /// </summary>
    public string? AcceptPlusEligible { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Affordable Product Type [AUS.X155]
    /// </summary>
    public string? AffordableProductType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - All Other Payments [AUS.X71]
    /// </summary>
    public decimal? AllOtherPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Amortization Months [AUS.X144]
    /// </summary>
    public int? AmortizationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Amortization Type [AUS.X22]
    /// </summary>
    public StringEnumValue<AmortizationType> AmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Amt. Subordinate Fin. [AUS.X57]
    /// </summary>
    public decimal? AmtSubordinateFin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Appraisal Type/MAF [AUS.X125]
    /// </summary>
    public string? AppraisalTypeMaf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Appraised Value [AUS.X18]
    /// </summary>
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - ARM Qualifying Rate [AUS.X145]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmQualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Assessed [AUS.X169]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AssessedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Assessment Type [AUS.X123]
    /// </summary>
    public string? AssessmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Log Extension Id [AUS.X197]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AusLogExtensionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Order LinkId  [AUS.X196]
    /// </summary>
    public string? AusOrderLinkId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Recommendation [AUS.X6]
    /// </summary>
    public string? AusRecommendation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Aus Response File Name [AUS.X198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AusResponseFileName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Status [AUS.X121]
    /// </summary>
    public string? AusStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Tracking Type [AUS.X999]
    /// </summary>
    public StringEnumValue<LogAUSTrackingType> AusTrackingType { get => GetValue<StringEnumValue<LogAUSTrackingType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Transaction # [AUS.X114]
    /// </summary>
    public string? AusTransactionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Version # [AUS.X9]
    /// </summary>
    public string? AusVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Balloon [AUS.X53]
    /// </summary>
    public string? Balloon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Balloon Term [AUS.X143]
    /// </summary>
    public int? BalloonTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Amount [AUS.X109]
    /// </summary>
    public decimal? BorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Name [AUS.X106]
    /// </summary>
    public string? BorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Type [AUS.X107]
    /// </summary>
    public string? BorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 1 [AUS.X93]
    /// </summary>
    public string? BorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 2 [AUS.X94]
    /// </summary>
    public string? BorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 3 [AUS.X95]
    /// </summary>
    public string? BorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Equifax/BEACON [AUS.X134]
    /// </summary>
    public string? BorrowerEquifaxBeacon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Experian/FICO [AUS.X132]
    /// </summary>
    public string? BorrowerExperianFico { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Amount [AUS.X102]
    /// </summary>
    public decimal? BorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Name [AUS.X100]
    /// </summary>
    public string? BorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Type [AUS.X101]
    /// </summary>
    public string? BorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Institution Name [AUS.X108]
    /// </summary>
    public string? BorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Name [AUS.X43]
    /// </summary>
    public string? BorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Score Name [AUS.X92]
    /// </summary>
    public string? BorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica [AUS.X133]
    /// </summary>
    public string? BorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type [AUS.X84]
    /// </summary>
    public string? BorrowerType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type 2 [AUS.X88]
    /// </summary>
    public string? BorrowerType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Bought Down Rate [AUS.X64]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BoughtDownRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Buydown [AUS.X59]
    /// </summary>
    public string? Buydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Cash Back [AUS.X77]
    /// </summary>
    public decimal? CashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Cash Out Amount [AUS.X158]
    /// </summary>
    public decimal? CashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - CLTV [AUS.X12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Cltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Amount [AUS.X113]
    /// </summary>
    public decimal? CoBorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Name [AUS.X110]
    /// </summary>
    public string? CoBorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Type [AUS.X111]
    /// </summary>
    public string? CoBorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 1 [AUS.X97]
    /// </summary>
    public string? CoBorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 2 [AUS.X98]
    /// </summary>
    public string? CoBorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 3 [AUS.X99]
    /// </summary>
    public string? CoBorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON [AUS.X137]
    /// </summary>
    public string? CoBorrowerEquifaxBeacon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Experian FICO [AUS.X135]
    /// </summary>
    public string? CoBorrowerExperianFico { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Amount [AUS.X105]
    /// </summary>
    public decimal? CoBorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Name [AUS.X103]
    /// </summary>
    public string? CoBorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Type [AUS.X104]
    /// </summary>
    public string? CoBorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Institution Name [AUS.X112]
    /// </summary>
    public string? CoBorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Coborrower Name [AUS.X45]
    /// </summary>
    public string? CoborrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Score Name 2 [AUS.X96]
    /// </summary>
    public string? CoBorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica [AUS.X136]
    /// </summary>
    public string? CoBorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 1 [AUS.X80]
    /// </summary>
    public string? Code1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 2 [AUS.X82]
    /// </summary>
    public string? Code2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 1 [AUS.X81]
    /// </summary>
    public string? CodeDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 2 [AUS.X83]
    /// </summary>
    public string? CodeDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Community Lending [AUS.X54]
    /// </summary>
    public string? CommunityLending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTracking CreatedOn
    /// </summary>
    public DateTime? CreatedOn { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 1 [AUS.X85]
    /// </summary>
    public string? CreditAgency1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 2 [AUS.X89]
    /// </summary>
    public string? CreditAgency2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 1 [AUS.X87]
    /// </summary>
    public DateTime? CreditReportDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 2 [AUS.X91]
    /// </summary>
    public DateTime? CreditReportDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 1 [AUS.X86]
    /// </summary>
    public string? CreditReportId1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 2 [AUS.X90]
    /// </summary>
    public string? CreditReportId2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Amortization Type [AUS.CuredX22]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<AmortizationType> CuredAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Appraised Value [AUS.CuredX18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? CuredAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// CuredAUS Tracking - CLTV [AUS.CuredX12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredCltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Housing Expense Ratio [AUS.CuredX14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredHousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Purpose [AUS.CuredX23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanPurposeType> CuredLoanPurpose { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Term [AUS.CuredX21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? CuredLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Type [AUS.CuredX20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanType> CuredLoanType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - LTV [AUS.CuredX11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Note Rate [AUS.CuredX19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.CuredX32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Refinance Purpose [AUS.CuredX24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<RefinancePurpose> CuredRefinancePurpose { get => GetValue<StringEnumValue<RefinancePurpose>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Total Expense Ratio [AUS.CuredX15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredTotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Total Loan Amount [AUS.CuredX16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Income / Assets - Total Monthly Income [AUS.CuredX41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredTotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Debt Ratio [AUS.X149]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Documentation Level [AUS.X118]
    /// </summary>
    public string? DocumentationLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - DU Case ID/ LP AUS Key # [AUS.X7]
    /// </summary>
    public string? DuCaseIdorLpausKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Type [AUS.X50]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"MHAdvantage\"]")]
    public StringEnumValue<PropertyType> DuPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - eFolder GUID [AUS.EFOLDERGUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EFolderGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Error Info [AUS.X195]
    /// </summary>
    public string? ErrorInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified [AUS.X79]
    /// </summary>
    public decimal? ExcessAvailableAssetsNoVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fatal Edit Info [AUS.X193]
    /// </summary>
    public string? FatalEditInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - File Type [AUS.X192]
    /// </summary>
    public StringEnumValue<LogFileType> FileType { get => GetValue<StringEnumValue<LogFileType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Financed MI Amount [AUS.X61]
    /// </summary>
    public decimal? FinancedMiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - First P&amp;I [AUS.X25]
    /// </summary>
    public decimal? FirstPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - First Submission Date [AUS.X4]
    /// </summary>
    public DateTime? FirstSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - First Submission Time [AUS.X174]
    /// </summary>
    public string? FirstSubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Doc Class (Freddie) [AUS.X10]
    /// </summary>
    public string? FreddieDocClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Funds Required to Close [AUS.X74]
    /// </summary>
    public decimal? FundsRequiredClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - HLCTV [AUS.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Hlctv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Housing Expense [AUS.X65]
    /// </summary>
    public decimal? HousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Housing Expense Ratio [AUS.X14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Housing Ratio [AUS.X148]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - HTLTV [AUS.X147]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Htltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Including Less Than 10 Mos. [AUS.X67]
    /// </summary>
    public string? IncludingLess10Mos { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Base [AUS.X34]
    /// </summary>
    public decimal? IncomeAssetBase { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Bonus [AUS.X36]
    /// </summary>
    public decimal? IncomeAssetBonus { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Commission [AUS.X35]
    /// </summary>
    public decimal? IncomeAssetCommission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Other [AUS.X38]
    /// </summary>
    public decimal? IncomeAssetOther { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Overtime [AUS.X37]
    /// </summary>
    public decimal? IncomeAssetOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Subj. Pos. Cash Flow [AUS.X40]
    /// </summary>
    public decimal? IncomeAssetPosCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Positive Net Rental [AUS.X39]
    /// </summary>
    public decimal? IncomeAssetPositiveNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Indicator Score [AUS.X128]
    /// </summary>
    public string? IndicatorScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Intended Use of Property [AUS.X157]
    /// </summary>
    public string? IntendedUseofProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1 [AUS.X185]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2 [AUS.X187]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3 [AUS.X189]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4 [AUS.X191]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1 [AUS.X184]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType1> LclaEvaluatedServiceType1 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType1>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2 [AUS.X186]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType2> LclaEvaluatedServiceType2 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType2>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3 [AUS.X188]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType3> LclaEvaluatedServiceType3 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType3>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4 [AUS.X190]
    /// </summary>
    public string? LclaEvaluatedServiceType4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lender Loan # [AUS.X44]
    /// </summary>
    public string? LenderLoan { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lien Type [AUS.X56]
    /// </summary>
    public StringEnumValue<LienType> LienType { get => GetValue<StringEnumValue<LienType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Loan Amount [AUS.X60]
    /// </summary>
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Application # [AUS.X142]
    /// </summary>
    public string? LoanApplicationId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Processing Stage [AUS.X122]
    /// </summary>
    public string? LoanProcessingStage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Prospector ID [AUS.X115]
    /// </summary>
    public string? LoanProspectorId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Purpose [AUS.X23]
    /// </summary>
    public StringEnumValue<LoanPurposeType> LoanPurpose { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Term [AUS.X21]
    /// </summary>
    public int? LoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Type [AUS.X20]
    /// </summary>
    public StringEnumValue<LoanType> LoanType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Assmt. Exp. Date [AUS.X131]
    /// </summary>
    public DateTime? LpAssmtExpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Property Type [AUS.X172]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Detached Condominium\"]")]
    public StringEnumValue<OtherPropertyType> LpPropertyType { get => GetValue<StringEnumValue<OtherPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Version [AUS.X124]
    /// </summary>
    public string? LpVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion [AUS.X183]
    /// </summary>
    public string? LqaCollateralRepWarrantyServiceConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion [AUS.X181]
    /// </summary>
    public string? LqaCreditRiskAssessmentConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion [AUS.X179]
    /// </summary>
    public string? LqaDataCompareFieldConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Name [AUS.X178]
    /// </summary>
    public string? LqaDataCompareFieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Result [AUS.X175]
    /// </summary>
    public string? LqaDataCompareResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - LP Key [AUS.X176]
    /// </summary>
    public string? LqalpKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result [AUS.X182]
    /// </summary>
    public string? LqaPurchaseEligibilityResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Risk Assessment Key [AUS.X180]
    /// </summary>
    public string? LqaRiskAssessmentKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Submission DateTime [AUS.X177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaSubmissionDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - LTV [AUS.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Max Mortgage Limit [AUS.X162]
    /// </summary>
    public decimal? MaxMortgageLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - MI Decision [AUS.X126]
    /// </summary>
    public string? MiDecision { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Mortgage Type [AUS.X119]
    /// </summary>
    public string? MortgageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Neg. Amortization Type [AUS.X152]
    /// </summary>
    public string? NegAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Negative Net Rental [AUS.X69]
    /// </summary>
    public decimal? NegativeNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Net Cash Back [AUS.X78]
    /// </summary>
    public decimal? NetCashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - New Construction [AUS.X154]
    /// </summary>
    public string? NewConstruction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Note Rate [AUS.X19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - NOTP Number [AUS.X171]
    /// </summary>
    public string? NotpNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - No Units [AUS.X51]
    /// </summary>
    public int? NoUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - # of Submissions [AUS.X170]
    /// </summary>
    public string? NumberOfSubmissions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Occupancy Status [AUS.X52]
    /// </summary>
    public string? OccupancyStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Debt Ratio [AUS.X151]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OccupantDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Housing Ratio [AUS.X150]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OccupantHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Offering Identifier [AUS.X156]
    /// </summary>
    public string? OfferingIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Order Status [AUS.X194]
    /// </summary>
    public string? OrderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Originating Company [AUS.X164]
    /// </summary>
    public string? OriginatingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Owner Existing Mtg. [AUS.X58]
    /// </summary>
    public decimal? OwnerExistingMtg { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - P &amp; I [AUS.X62]
    /// </summary>
    public decimal? PandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Payment Frequency [AUS.X55]
    /// </summary>
    public int? PaymentFrequency { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address [AUS.X138]
    /// </summary>
    public string? PresentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address City [AUS.X139]
    /// </summary>
    public string? PresentAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address State [AUS.X140]
    /// </summary>
    public string? PresentAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address Zipcode [AUS.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PresentAddressZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Housing Expense [AUS.X161]
    /// </summary>
    public decimal? PresentHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Present/Principal Housing Payment [AUS.X73]
    /// </summary>
    public decimal? PresentPrincipalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Address [AUS.X46]
    /// </summary>
    public string? PropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property City [AUS.X47]
    /// </summary>
    public string? PropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property State [AUS.X48]
    /// </summary>
    public string? PropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Zipcode [AUS.X49]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance [AUS.X27]
    /// </summary>
    public decimal? ProposedHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees [AUS.X30]
    /// </summary>
    public decimal? ProposedHoaFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Proposed Housing (PITI) [AUS.X160]
    /// </summary>
    public decimal? ProposedHousingPiti { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance [AUS.X29]
    /// </summary>
    public decimal? ProposedMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Other [AUS.X31]
    /// </summary>
    public decimal? ProposedOtherPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Taxes [AUS.X28]
    /// </summary>
    public decimal? ProposedTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.X32]
    /// </summary>
    public decimal? ProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt [AUS.X33]
    /// </summary>
    public decimal? ProposedTotalMonthlyDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Purchase Eligibility [AUS.X120]
    /// </summary>
    public string? PurchaseEligibility { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Qualifying Rate [AUS.X63]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTracking RecordType
    /// </summary>
    public string? RecordType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Refinance Purpose [AUS.X24]
    /// </summary>
    public StringEnumValue<RefinancePurpose> RefinancePurpose { get => GetValue<StringEnumValue<RefinancePurpose>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Requested [AUS.X168]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RequestedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Reserves [AUS.X159]
    /// </summary>
    public decimal? Reserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified [AUS.X75]
    /// </summary>
    public decimal? ReservesRequiredVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Risk Class [AUS.X117]
    /// </summary>
    public string? RiskClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Sales Concessions [AUS.X163]
    /// </summary>
    public string? SalesConcessions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Sales Price [AUS.X17]
    /// </summary>
    public decimal? SalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Second P&amp;I [AUS.X26]
    /// </summary>
    public decimal? SecondPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Borrower [AUS.X130]
    /// </summary>
    public string? SelectedBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Repository [AUS.X129]
    /// </summary>
    public string? SelectedRepository { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Seller Number [AUS.X166]
    /// </summary>
    public string? SellerNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow [AUS.X70]
    /// </summary>
    public decimal? SubjNegCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Date [AUS.X3]
    /// </summary>
    public DateTime? SubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Number [AUS.X5]
    /// </summary>
    public string? SubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Time [AUS.X173]
    /// </summary>
    public string? SubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submitted By [AUS.X8]
    /// </summary>
    public string? SubmittedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Submitting Company [AUS.X165]
    /// </summary>
    public string? SubmittingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Temporary Subsidy Buydown [AUS.X153]
    /// </summary>
    public string? TemporarySubsidyBuydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TLTV [AUS.X146]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Tltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Assets [AUS.X42]
    /// </summary>
    public decimal? TotalAsset { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense [AUS.X66]
    /// </summary>
    public decimal? TotalExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense Pmt [AUS.X72]
    /// </summary>
    public decimal? TotalExpensePmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Total Expense Ratio [AUS.X15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Funds to be Verified [AUS.X76]
    /// </summary>
    public decimal? TotalFundsVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Total Loan Amount [AUS.X16]
    /// </summary>
    public decimal? TotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Monthly Income [AUS.X41]
    /// </summary>
    public decimal? TotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TPO Number [AUS.X167]
    /// </summary>
    public string? TpoNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Transaction ID [AUS.X116]
    /// </summary>
    public string? TransactionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Other Type [AUS.X2]
    /// </summary>
    public string? UnderwritingRiskAssessOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Type [AUS.X1]
    /// </summary>
    public StringEnumValue<RiskAssessmentType> UnderwritingRiskAssessType { get => GetValue<StringEnumValue<RiskAssessmentType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - With Undisclosed Debt [AUS.X68]
    /// </summary>
    public string? WithUndisclosedDebt { get => GetValue<string?>(); set => SetValue(value); }
}