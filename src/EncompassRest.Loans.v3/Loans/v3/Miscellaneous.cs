using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Miscellaneous
/// </summary>
public sealed partial class Miscellaneous : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Borr Info Address [4097]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// All Roles Informaton [EDS.X6]
    /// </summary>
    public string? AllRoles { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// All Users Informaton [EDS.X7]
    /// </summary>
    public string? AllUserInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Other Descr 1 [1193]
    /// </summary>
    public string? BorrowerDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Other Descr 2 [1194]
    /// </summary>
    public string? BorrowerDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Other Descr 3 [1195]
    /// </summary>
    public string? BorrowerDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Other Descr 4 [3620]
    /// </summary>
    public string? BorrowerDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Other Descr 5 [3621]
    /// </summary>
    public string? BorrowerDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info BorrowerDescription 6 [4101]
    /// </summary>
    public string? BorrowerDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info BorrowerDescription 7 [4102]
    /// </summary>
    public string? BorrowerDescription7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info City [4098]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Closing Cost Program Template File Applied [2862]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgramFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// 1098 Tax Year [3614]
    /// </summary>
    public string? ClosingTaxYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Interest Received [3615]
    /// </summary>
    public decimal? ClosingTaxYearInterestReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Pre2017KBYOAmendments Indicator  [COMPLIANCEVERSION.CD3X1505]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ComplianceVersionCd3X1505 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability - Contact Info Fax [EDS.X4]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ContactFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability - Contact Info Name [EDS.X1]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability - Contact Info Phone [EDS.X3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ContactPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability - Contact Info Title [EDS.X2]
    /// </summary>
    public string? ContactTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Is copy from subject property [4104]
    /// </summary>
    public bool? CopyFromSubjectProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DataTrac loan ID [DATATRAC.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DataTracLoanId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Document Tracking Template File Applied [2863]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocSetFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck UCD Status [FANNIESERVICE.X14]
    /// </summary>
    public string? EarlyCheckUcdPassFail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Factor for Revolving Debt [SYS.X13]
    /// </summary>
    public int? FactorForRevolvingDebt { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie DU Report Auto Order Indicator [FANNIESERVICE.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? FannieDuAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report Appraisal Value [FANNIESERVICE.X9]
    /// </summary>
    public string? FannieEcAppraisalValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report Auto Order Indicator [FANNIESERVICE.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? FannieEcAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report Document FileId [FANNIESERVICE.X8]
    /// </summary>
    public string? FannieEcDocumentFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report DU Case file ID [FANNIESERVICE.X13]
    /// </summary>
    public string? FannieEcDuCaseFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report DU Latest Submission Date Time [FANNIESERVICE.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieEcDuLatestSubmissionDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report DU Latest Submission Number [FANNIESERVICE.X12]
    /// </summary>
    public string? FannieEcDuLatestSubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report DU Underwriting Recommendation Code [FANNIESERVICE.X10]
    /// </summary>
    public string? FannieEcDuUnderwritingRecommendationCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie EarlyCheck Report UCDP Last Submission Date Time [FANNIESERVICE.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? FannieEcUcdpLastSubmissionDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp Flood Ins Excl [1801]
    /// </summary>
    public string? FloodInsuranceExcluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Form List Template File Applied [2864]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FormListFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie LPA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X1]
    /// </summary>
    public bool? FreddieLpaAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie LQA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X2]
    /// </summary>
    public bool? FreddieLqaAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc First Mtg Pymt Int Rate [INTRATE1]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? HousingExpenseIntRate1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Fin Pymt Int Rate [INTRATE2]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? HousingExpenseIntRate2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Housing Expense Pymt Calc 1 Loan Amt [LOANAMT1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? HousingExpenseLoanAmt1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Housing Expense Pymt Calc 2 Loan Amt [LOANAMT2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? HousingExpenseLoanAmt2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc First Mtg Pymt Mo Pymt [PAYMENT1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? HousingExpensePayment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Fin Pymt Mo Pymt [PAYMENT2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? HousingExpensePayment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc First Mtg Pymt Term [TERM1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? HousingExpenseTerm1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Fin Pymt Term [TERM2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? HousingExpenseTerm2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Is same Address with Payer/Borr [4103]
    /// </summary>
    public bool? IsSameAddresswithPayer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Last Fee Import Date to Support Data Imports [4498]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LastFeeImportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Fee Quote ID to Support Fee Data Imports [4496]
    /// </summary>
    public string? LenderFeeQuoteId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp 1007 User Def Excl [1802]
    /// </summary>
    public string? Line1006Excluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp 1008 User Def Excl [1803]
    /// </summary>
    public string? Line1007Excluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp 1009 User Def Excl [1804]
    /// </summary>
    public string? Line1008Excluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp 1010 USDA Monthly Premium Excl [3357]
    /// </summary>
    public string? Line1010Excluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan File Sequence Number [LOANFILESEQUENCENUMBER]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LoanFileSequenceNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Program Template File Applied [2861]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanProgramFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Template File Applied [2860]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanTemplateFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review ATR/QM Result [COMPLIANCEREVIEW.X18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventAtrqmResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Auto Order Indicator [COMPLIANCEREVIEW.X15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? MaventAutoOrderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review CRAx Result [COMPLIANCEREVIEW.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventCraxResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Enterprise Result [COMPLIANCEREVIEW.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventEnterpriseResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review GSE Result [COMPLIANCEREVIEW.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventGseResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review High Cost Result [COMPLIANCEREVIEW.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventHighCostResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review HMDA Result [COMPLIANCEREVIEW.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventHmdaResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review HPML Result [COMPLIANCEREVIEW.X16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventHpmlResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review License Result [COMPLIANCEREVIEW.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventLicenseResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review NMLS Result [COMPLIANCEREVIEW.X17]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventNmlsResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review OFAC Result [COMPLIANCEREVIEW.X10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventOfacResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Ordered By [COMPLIANCEREVIEW.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventOrderedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Ordered Date [COMPLIANCEREVIEW.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MaventOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Other Result [COMPLIANCEREVIEW.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventOtherResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review Result [COMPLIANCEREVIEW.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventReviewResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review State Result [COMPLIANCEREVIEW.X12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventStateResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review TILA ROR Result [COMPLIANCEREVIEW.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventTilaRorResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mavent Compliance Review TILA Tolerance Result [COMPLIANCEREVIEW.X14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MaventTilaToleranceResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info MI Premiums [3842]
    /// </summary>
    public decimal? MiPremiums { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Misc Data Template File Applied [2865]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MiscDataFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Install Mos to Exclude [998]
    /// </summary>
    public int? MonthsToExclude { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown Calculation - New Buydown Feature Enabled Flag [COMPLIANCEVERSION.NEWBUYDOWNENABLED]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NewBuyDownEnabled { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// History Data From Optimal Blue [OPTIMAL.HISTORY]
    /// </summary>
    public string? OptimalBlueHistoryData { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request String For Optimal Blue [OPTIMAL.REQUEST]
    /// </summary>
    public string? OptimalBlueRequest { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Response String From Optimal Blue [OPTIMAL.RESPONSE]
    /// </summary>
    public string? OptimalBlueResponse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp Other Amt [1799]
    /// </summary>
    public decimal? OtherPresentHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Outstanding Mtg Principal [4095]
    /// </summary>
    public decimal? OutstandingMtgPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Outstanding Mtg Principal Date [4096]
    /// </summary>
    public DateTime? OutstandingMtgPrincipalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Home Points Program Loan will Participate [2859]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? ParticipateHomePoints { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Processing Network Partner Email [EPN.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PartnerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Partner Fee Quote ID to Support Fee Data Imports [4497]
    /// </summary>
    public string? PartnerFeeQuoteId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Processing Network Partner Name [EPN.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PartnerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Processing Network Partner Phone [EPN.X2]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? PartnerPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Points Paid [1191]
    /// </summary>
    public decimal? PointsPaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability - Print State License Number on 1003 [EDS.X5]
    /// </summary>
    public bool? PrintStateLicenseOn1003 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Expiration Date [2824]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RateRegistrationExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Investor Name [2825]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RateRegistrationInvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Loan Is Registered [2827]
    /// </summary>
    public bool? RateRegistrationLoanIsRegistered { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Reference [2826]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RateRegistrationReference { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Created By [2822]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RateRegistrationRegisteredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Created By User ID [2828]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RateRegistrationRegisteredUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Registration Date [2823]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RateRegistrationRegistrationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Refund of Overpaid Interest [1192]
    /// </summary>
    public decimal? RefundOrOverpaidInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Encompass Version When Disclosure Tracking Log is Added to Loan [COMPLIANCEVERSION.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SavedLogVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Other Hous Exp City Prop Tax Excl [1800]
    /// </summary>
    public string? SchoolTaxExcluded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info State [4099]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Processing Network Status URL [EPN.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? StatusUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Processing Network Submit Date [EPN.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SubmitDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// 1098 Tax Year [3616]
    /// </summary>
    public string? SubTaxYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Interest Received [3617]
    /// </summary>
    public decimal? SubTaxYearInterestReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info MI Premiums [3843]
    /// </summary>
    public decimal? SubTaxYearMiPremiums { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Points Paid [3618]
    /// </summary>
    public decimal? SubTaxYearPointsPaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Refund of Overpaid Interest [3619]
    /// </summary>
    public decimal? SubTaxYearRefundOrOverpaidInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Lender Info Tax ID [1196]
    /// </summary>
    public string? TaxId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Total of MI for Tax Year and Upfront MIP [2846]
    /// </summary>
    public decimal? TotalBox4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// IRS Total of MI for Tax Year [2845]
    /// </summary>
    public decimal? TotalYearlyMi { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Connect Status Updated [TPOCONNECTSTATUSUPDATED]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? TpoConnectStatusUpdated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Real Estate Tax Overide w/GFE Tax [USEGFETAX]
    /// </summary>
    public string? UseGfeTax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown Calculation Indicator - Yes to use old logic [COMPLIANCEVERSION.CASASRNX141]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? UseOldBuydownUiAndLogic { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Mtg Ins Override w/ REGZ MI [USEREGZMI]
    /// </summary>
    public string? UseRegZMi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Info Zip [4100]
    /// </summary>
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}