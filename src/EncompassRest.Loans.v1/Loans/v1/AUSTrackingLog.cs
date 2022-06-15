using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AUSTrackingLog
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AUSTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AUSTrackingLog AUSTrackingLogIndex
    /// </summary>
    public int? AUSTrackingLogIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog BatchDocumentRefId
    /// </summary>
    public string? BatchDocumentRefId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog IsEmpty
    /// </summary>
    public bool? IsEmpty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog IsHistory
    /// </summary>
    public bool? IsHistory { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Accept Plus Eligible [AUS.X127]
    /// </summary>
    public string? LogAcceptPlusEligible { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Affordable Product Type [AUS.X155]
    /// </summary>
    public string? LogAffordableProductType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - All Other Payments [AUS.X71]
    /// </summary>
    public decimal? LogAllOtherPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Amortization Months [AUS.X144]
    /// </summary>
    public int? LogAmortizationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Amortization Type [AUS.X22]
    /// </summary>
    public StringEnumValue<AmortizationType> LogAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Amt. Subordinate Fin. [AUS.X57]
    /// </summary>
    public decimal? LogAmtSubordinateFin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Appraisal Type/MAF [AUS.X125]
    /// </summary>
    public string? LogAppraisalTypeMAF { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Appraised Value [AUS.X18]
    /// </summary>
    public int? LogAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - ARM Qualifying Rate [AUS.X145]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogARMQualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Assessment Type [AUS.X123]
    /// </summary>
    public string? LogAssessmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Average Median Credit Score [AUS.X199]
    /// </summary>
    public string? LogAusAverageMedianCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Log Extension Id [AUS.X197]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LogAusLogExtensionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Order LinkId  [AUS.X196]
    /// </summary>
    public string? LogAusOrderLinkId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Recommendation [AUS.X6]
    /// </summary>
    public string? LogAUSRecommendation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Aus Response File Name [AUS.X198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LogAusResponseFileName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Status [AUS.X121]
    /// </summary>
    public string? LogAUSStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Tracking Type [AUS.X999]
    /// </summary>
    public StringEnumValue<LogAUSTrackingType> LogAUSTrackingType { get => GetValue<StringEnumValue<LogAUSTrackingType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Transaction # [AUS.X114]
    /// </summary>
    public string? LogAUSTransactionID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - AUS Version # [AUS.X9]
    /// </summary>
    public string? LogAUSVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Balloon [AUS.X53]
    /// </summary>
    public string? LogBalloon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Balloon Term [AUS.X143]
    /// </summary>
    public int? LogBalloonTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Amount [AUS.X109]
    /// </summary>
    public decimal? LogBorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Name [AUS.X106]
    /// </summary>
    public string? LogBorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Type [AUS.X107]
    /// </summary>
    public string? LogBorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 1 [AUS.X93]
    /// </summary>
    public string? LogBorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 2 [AUS.X94]
    /// </summary>
    public string? LogBorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 3 [AUS.X95]
    /// </summary>
    public string? LogBorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Equifax/BEACON [AUS.X134]
    /// </summary>
    public string? LogBorrowerEquifaxBEACON { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Experian/FICO [AUS.X132]
    /// </summary>
    public string? LogBorrowerExperianFICO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Amount [AUS.X102]
    /// </summary>
    public decimal? LogBorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Name [AUS.X100]
    /// </summary>
    public string? LogBorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Type [AUS.X101]
    /// </summary>
    public string? LogBorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Institution Name [AUS.X108]
    /// </summary>
    public string? LogBorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Name [AUS.X43]
    /// </summary>
    public string? LogBorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Score Name [AUS.X92]
    /// </summary>
    public string? LogBorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica [AUS.X133]
    /// </summary>
    public string? LogBorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type [AUS.X84]
    /// </summary>
    public string? LogBorrowerType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type 2 [AUS.X88]
    /// </summary>
    public string? LogBorrowerType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Bought Down Rate [AUS.X64]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogBoughtDownRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Buydown [AUS.X59]
    /// </summary>
    public string? LogBuydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Cash Back [AUS.X77]
    /// </summary>
    public decimal? LogCashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Cash Out Amount [AUS.X158]
    /// </summary>
    public decimal? LogCashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - CLTV [AUS.X12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogCLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Amount [AUS.X113]
    /// </summary>
    public decimal? LogCoBorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Name [AUS.X110]
    /// </summary>
    public string? LogCoBorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Type [AUS.X111]
    /// </summary>
    public string? LogCoBorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 1 [AUS.X97]
    /// </summary>
    public string? LogCoBorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 2 [AUS.X98]
    /// </summary>
    public string? LogCoBorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 3 [AUS.X99]
    /// </summary>
    public string? LogCoBorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON [AUS.X137]
    /// </summary>
    public string? LogCoBorrowerEquifaxBEACON { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Experian FICO [AUS.X135]
    /// </summary>
    public string? LogCoBorrowerExperianFICO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Amount [AUS.X105]
    /// </summary>
    public decimal? LogCoBorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Name [AUS.X103]
    /// </summary>
    public string? LogCoBorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Type [AUS.X104]
    /// </summary>
    public string? LogCoBorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Institution Name [AUS.X112]
    /// </summary>
    public string? LogCoBorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Coborrower Name [AUS.X45]
    /// </summary>
    public string? LogCoborrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Score Name 2 [AUS.X96]
    /// </summary>
    public string? LogCoBorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica [AUS.X136]
    /// </summary>
    public string? LogCoBorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 1 [AUS.X80]
    /// </summary>
    public string? LogCode1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 2 [AUS.X82]
    /// </summary>
    public string? LogCode2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 1 [AUS.X81]
    /// </summary>
    public string? LogCodeDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 2 [AUS.X83]
    /// </summary>
    public string? LogCodeDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Community Lending [AUS.X54]
    /// </summary>
    public string? LogCommunityLending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog LogCreatedOn
    /// </summary>
    public DateTime? LogCreatedOn { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 1 [AUS.X85]
    /// </summary>
    public string? LogCreditAgency1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 2 [AUS.X89]
    /// </summary>
    public string? LogCreditAgency2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 1 [AUS.X87]
    /// </summary>
    public DateTime? LogCreditReportDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 2 [AUS.X91]
    /// </summary>
    public DateTime? LogCreditReportDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 1 [AUS.X86]
    /// </summary>
    public string? LogCreditReportID1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 2 [AUS.X90]
    /// </summary>
    public string? LogCreditReportID2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Amortization Type [AUS.CuredX22]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<AmortizationType> LogCuredAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Appraised Value [AUS.CuredX18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LogCuredAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Cured AUS Average Median Credit Score [AUS.CuredX199]
    /// </summary>
    public string? LogCuredAusAverageMedianCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CuredAUS Tracking - CLTV [AUS.CuredX12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LogCuredCLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Housing Expense Ratio [AUS.CuredX14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LogCuredHousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Purpose [AUS.CuredX23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanPurposeType> LogCuredLoanPurpose { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Term [AUS.CuredX21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LogCuredLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Type [AUS.CuredX20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanType> LogCuredLoanType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - LTV [AUS.CuredX11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LogCuredLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Note Rate [AUS.CuredX19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LogCuredNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.CuredX32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LogCuredProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Refinance Purpose [AUS.CuredX24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<RefinancePurpose> LogCuredRefinancePurpose { get => GetValue<StringEnumValue<RefinancePurpose>>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Total Expense Ratio [AUS.CuredX15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LogCuredTotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Total Loan Amount [AUS.CuredX16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LogCuredTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cured AUS Tracking - Income / Assets - Total Monthly Income [AUS.CuredX41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LogCuredTotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Assessed [AUS.X169]
    /// </summary>
    public string? LogDateTimeAssessed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Requested [AUS.X168]
    /// </summary>
    public string? LogDateTimeRequested { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Debt Ratio [AUS.X149]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Documentation Level [AUS.X118]
    /// </summary>
    public string? LogDocumentationLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - DU Case ID/ LP AUS Key # [AUS.X7]
    /// </summary>
    public string? LogDUCaseIDorLPAUSKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Type [AUS.X50]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"MHAdvantage\"]")]
    public StringEnumValue<PropertyType> LogDUPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - eFolder GUID [AUS.EFOLDERGUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LogeFolderGUID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Error Info [AUS.X195]
    /// </summary>
    public string? LogErrorInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified [AUS.X79]
    /// </summary>
    public decimal? LogExcessAvailableAssetsNoVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fatal Edit Info [AUS.X193]
    /// </summary>
    public string? LogFatalEditInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - File Type [AUS.X192]
    /// </summary>
    public StringEnumValue<LogFileType> LogFileType { get => GetValue<StringEnumValue<LogFileType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Financed MI Amount [AUS.X61]
    /// </summary>
    public decimal? LogFinancedMIAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - First P&amp;I [AUS.X25]
    /// </summary>
    public decimal? LogFirstPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - First Submission Date [AUS.X4]
    /// </summary>
    public DateTime? LogFirstSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - First Submission Time [AUS.X174]
    /// </summary>
    public string? LogFirstSubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Doc Class (Freddie) [AUS.X10]
    /// </summary>
    public string? LogFreddieDocClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Funds Required to Close [AUS.X74]
    /// </summary>
    public decimal? LogFundsRequiredClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog LogGUID
    /// </summary>
    public string? LogGUID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - HLCTV [AUS.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogHLCTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Housing Expense [AUS.X65]
    /// </summary>
    public decimal? LogHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Housing Expense Ratio [AUS.X14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogHousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Housing Ratio [AUS.X148]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - HTLTV [AUS.X147]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogHTLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Including Less Than 10 Mos. [AUS.X67]
    /// </summary>
    public string? LogIncludingLess10Mos { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Base [AUS.X34]
    /// </summary>
    public decimal? LogIncomeAssetBase { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Bonus [AUS.X36]
    /// </summary>
    public decimal? LogIncomeAssetBonus { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Commission [AUS.X35]
    /// </summary>
    public decimal? LogIncomeAssetCommission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Other [AUS.X38]
    /// </summary>
    public decimal? LogIncomeAssetOther { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Overtime [AUS.X37]
    /// </summary>
    public decimal? LogIncomeAssetOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Subj. Pos. Cash Flow [AUS.X40]
    /// </summary>
    public decimal? LogIncomeAssetPosCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Positive Net Rental [AUS.X39]
    /// </summary>
    public decimal? LogIncomeAssetPositiveNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Indicator Score [AUS.X128]
    /// </summary>
    public string? LogIndicatorScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Intended Use of Property [AUS.X157]
    /// </summary>
    public string? LogIntendedUseofProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1 [AUS.X185]
    /// </summary>
    public string? LogLCLAEvaluatedServiceConclusion1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2 [AUS.X187]
    /// </summary>
    public string? LogLCLAEvaluatedServiceConclusion2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3 [AUS.X189]
    /// </summary>
    public string? LogLCLAEvaluatedServiceConclusion3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4 [AUS.X191]
    /// </summary>
    public string? LogLCLAEvaluatedServiceConclusion4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1 [AUS.X184]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType1> LogLCLAEvaluatedServiceType1 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType1>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2 [AUS.X186]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType2> LogLCLAEvaluatedServiceType2 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType2>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3 [AUS.X188]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType3> LogLCLAEvaluatedServiceType3 { get => GetValue<StringEnumValue<LogLCLAEvaluatedServiceType3>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4 [AUS.X190]
    /// </summary>
    public string? LogLCLAEvaluatedServiceType4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lender Loan # [AUS.X44]
    /// </summary>
    public string? LogLenderLoan { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lien Type [AUS.X56]
    /// </summary>
    public StringEnumValue<LienType> LogLienType { get => GetValue<StringEnumValue<LienType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Loan Amount [AUS.X60]
    /// </summary>
    public decimal? LogLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Application # [AUS.X142]
    /// </summary>
    public string? LogLoanApplicationID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Processing Stage [AUS.X122]
    /// </summary>
    public string? LogLoanProcessingStage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Prospector ID [AUS.X115]
    /// </summary>
    public string? LogLoanProspectorID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Purpose [AUS.X23]
    /// </summary>
    public StringEnumValue<LoanPurposeType> LogLoanPurpose { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Term [AUS.X21]
    /// </summary>
    public int? LogLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Loan Type [AUS.X20]
    /// </summary>
    public StringEnumValue<LoanType> LogLoanType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Assmt. Exp. Date [AUS.X131]
    /// </summary>
    public DateTime? LogLPAssmtExpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Property Type [AUS.X172]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Detached Condominium\"]")]
    public StringEnumValue<OtherPropertyType> LogLPPropertyType { get => GetValue<StringEnumValue<OtherPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Version [AUS.X124]
    /// </summary>
    public string? LogLPVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion [AUS.X183]
    /// </summary>
    public string? LogLQACollateralRepWarrantyServiceConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion [AUS.X181]
    /// </summary>
    public string? LogLQACreditRiskAssessmentConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion [AUS.X179]
    /// </summary>
    public string? LogLQADataCompareFieldConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Name [AUS.X178]
    /// </summary>
    public string? LogLQADataCompareFieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Result [AUS.X175]
    /// </summary>
    public string? LogLQADataCompareResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - LP Key [AUS.X176]
    /// </summary>
    public string? LogLQALPKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result [AUS.X182]
    /// </summary>
    public string? LogLQAPurchaseEligibilityResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Risk Assessment Key [AUS.X180]
    /// </summary>
    public string? LogLQARiskAssessmentKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Submission DateTime [AUS.X177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LogLQASubmissionDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - LTV [AUS.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Max Mortgage Limit [AUS.X162]
    /// </summary>
    public decimal? LogMaxMortgageLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - MI Decision [AUS.X126]
    /// </summary>
    public string? LogMIDecision { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Mortgage Type [AUS.X119]
    /// </summary>
    public string? LogMortgageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Neg. Amortization Type [AUS.X152]
    /// </summary>
    public string? LogNegAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Negative Net Rental [AUS.X69]
    /// </summary>
    public decimal? LogNegativeNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Net Cash Back [AUS.X78]
    /// </summary>
    public decimal? LogNetCashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - New Construction [AUS.X154]
    /// </summary>
    public string? LogNewConstruction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Note Rate [AUS.X19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - NOTP Number [AUS.X171]
    /// </summary>
    public string? LogNOTPNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - No Units [AUS.X51]
    /// </summary>
    public int? LogNoUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - # of Submissions [AUS.X170]
    /// </summary>
    public string? LogNumberOfSubmissions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Occupancy Status [AUS.X52]
    /// </summary>
    public string? LogOccupancyStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Debt Ratio [AUS.X151]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogOccupantDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Housing Ratio [AUS.X150]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogOccupantHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Offering Identifier [AUS.X156]
    /// </summary>
    public string? LogOfferingIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Order Status [AUS.X194]
    /// </summary>
    public string? LogOrderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Originating Company [AUS.X164]
    /// </summary>
    public string? LogOriginatingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Owner Existing Mtg. [AUS.X58]
    /// </summary>
    public decimal? LogOwnerExistingMtg { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - P &amp; I [AUS.X62]
    /// </summary>
    public decimal? LogPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Payment Frequency [AUS.X55]
    /// </summary>
    public int? LogPaymentFrequency { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address [AUS.X138]
    /// </summary>
    public string? LogPresentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address City [AUS.X139]
    /// </summary>
    public string? LogPresentAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address State [AUS.X140]
    /// </summary>
    public StringEnumValue<State> LogPresentAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address Zipcode [AUS.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LogPresentAddressZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Housing Expense [AUS.X161]
    /// </summary>
    public decimal? LogPresentHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Present/Principal Housing Payment [AUS.X73]
    /// </summary>
    public decimal? LogPresentPrincipalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Address [AUS.X46]
    /// </summary>
    public string? LogPropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property City [AUS.X47]
    /// </summary>
    public string? LogPropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property State [AUS.X48]
    /// </summary>
    public StringEnumValue<State> LogPropertyState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Zipcode [AUS.X49]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LogPropertyZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance [AUS.X27]
    /// </summary>
    public decimal? LogProposedHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees [AUS.X30]
    /// </summary>
    public decimal? LogProposedHOAFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Proposed Housing (PITI) [AUS.X160]
    /// </summary>
    public decimal? LogProposedHousingPITI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance [AUS.X29]
    /// </summary>
    public decimal? LogProposedMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Other [AUS.X31]
    /// </summary>
    public decimal? LogProposedOtherPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Taxes [AUS.X28]
    /// </summary>
    public decimal? LogProposedTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.X32]
    /// </summary>
    public decimal? LogProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt [AUS.X33]
    /// </summary>
    public decimal? LogProposedTotalMonthlyDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Purchase Eligibility [AUS.X120]
    /// </summary>
    public string? LogPurchaseEligibility { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Qualifying Rate [AUS.X63]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogQualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUSTrackingLog LogRecordType
    /// </summary>
    public string? LogRecordType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Refinance Purpose [AUS.X24]
    /// </summary>
    public StringEnumValue<RefinancePurpose> LogRefinancePurpose { get => GetValue<StringEnumValue<RefinancePurpose>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Reserves [AUS.X159]
    /// </summary>
    public decimal? LogReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified [AUS.X75]
    /// </summary>
    public decimal? LogReservesRequiredVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Risk Class [AUS.X117]
    /// </summary>
    public string? LogRiskClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Sales Concessions [AUS.X163]
    /// </summary>
    public string? LogSalesConcessions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Sales Price [AUS.X17]
    /// </summary>
    public decimal? LogSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Second P&amp;I [AUS.X26]
    /// </summary>
    public decimal? LogSecondPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Borrower [AUS.X130]
    /// </summary>
    public string? LogSelectedBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Repository [AUS.X129]
    /// </summary>
    public string? LogSelectedRepository { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Seller Number [AUS.X166]
    /// </summary>
    public string? LogSellerNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow [AUS.X70]
    /// </summary>
    public decimal? LogSubjNegCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Date [AUS.X3]
    /// </summary>
    public DateTime? LogSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Number [AUS.X5]
    /// </summary>
    public string? LogSubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submission Time [AUS.X173]
    /// </summary>
    public string? LogSubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Submitted By [AUS.X8]
    /// </summary>
    public string? LogSubmittedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Submitting Company [AUS.X165]
    /// </summary>
    public string? LogSubmittingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Temporary Subsidy Buydown [AUS.X153]
    /// </summary>
    public string? LogTemporarySubsidyBuydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TLTV [AUS.X146]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogTLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Assets [AUS.X42]
    /// </summary>
    public decimal? LogTotalAsset { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense [AUS.X66]
    /// </summary>
    public decimal? LogTotalExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense Pmt [AUS.X72]
    /// </summary>
    public decimal? LogTotalExpensePmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Total Expense Ratio [AUS.X15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LogTotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Funds to be Verified [AUS.X76]
    /// </summary>
    public decimal? LogTotalFundsVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Total Loan Amount [AUS.X16]
    /// </summary>
    public decimal? LogTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Monthly Income [AUS.X41]
    /// </summary>
    public decimal? LogTotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TPO Number [AUS.X167]
    /// </summary>
    public string? LogTPONumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Transaction ID [AUS.X116]
    /// </summary>
    public string? LogTransactionID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Other Type [AUS.X2]
    /// </summary>
    public string? LogUnderwritingRiskAssessOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Type [AUS.X1]
    /// </summary>
    public StringEnumValue<RiskAssessmentType> LogUnderwritingRiskAssessType { get => GetValue<StringEnumValue<RiskAssessmentType>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - With Undisclosed Debt [AUS.X68]
    /// </summary>
    public string? LogWithUndisclosedDebt { get => GetValue<string?>(); set => SetValue(value); }
}