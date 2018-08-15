using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Miscellaneous
    /// </summary>
    public sealed partial class Miscellaneous : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// Borr Info Address [4097]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Address")]
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<string> _allRoles;
        /// <summary>
        /// All Roles Informaton [EDS.X6]
        /// </summary>
        [LoanFieldProperty(Description = "All Roles Informaton")]
        public string AllRoles { get => _allRoles; set => SetField(ref _allRoles, value); }
        private DirtyValue<string> _allUserInfo;
        /// <summary>
        /// All Users Informaton [EDS.X7]
        /// </summary>
        [LoanFieldProperty(Description = "All Users Informaton")]
        public string AllUserInfo { get => _allUserInfo; set => SetField(ref _allUserInfo, value); }
        private DirtyValue<string> _borrowerDescription1;
        /// <summary>
        /// Borr Info Other Descr 1 [1193]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Other Descr 1")]
        public string BorrowerDescription1 { get => _borrowerDescription1; set => SetField(ref _borrowerDescription1, value); }
        private DirtyValue<string> _borrowerDescription2;
        /// <summary>
        /// Borr Info Other Descr 2 [1194]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Other Descr 2")]
        public string BorrowerDescription2 { get => _borrowerDescription2; set => SetField(ref _borrowerDescription2, value); }
        private DirtyValue<string> _borrowerDescription3;
        /// <summary>
        /// Borr Info Other Descr 3 [1195]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Other Descr 3")]
        public string BorrowerDescription3 { get => _borrowerDescription3; set => SetField(ref _borrowerDescription3, value); }
        private DirtyValue<string> _borrowerDescription4;
        /// <summary>
        /// Borr Info Other Descr 4 [3620]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Other Descr 4")]
        public string BorrowerDescription4 { get => _borrowerDescription4; set => SetField(ref _borrowerDescription4, value); }
        private DirtyValue<string> _borrowerDescription5;
        /// <summary>
        /// Borr Info Other Descr 5 [3621]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Other Descr 5")]
        public string BorrowerDescription5 { get => _borrowerDescription5; set => SetField(ref _borrowerDescription5, value); }
        private DirtyValue<string> _borrowerDescription6;
        /// <summary>
        /// Borr Info BorrowerDescription 6 [4101]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info BorrowerDescription 6")]
        public string BorrowerDescription6 { get => _borrowerDescription6; set => SetField(ref _borrowerDescription6, value); }
        private DirtyValue<string> _borrowerDescription7;
        /// <summary>
        /// Borr Info BorrowerDescription 7 [4102]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info BorrowerDescription 7")]
        public string BorrowerDescription7 { get => _borrowerDescription7; set => SetField(ref _borrowerDescription7, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// Borr Info City [4098]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info City")]
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _closingCostProgramFile;
        /// <summary>
        /// Trans Details Closing Cost Program Template File Applied [2862]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Closing Cost Program Template File Applied")]
        public string ClosingCostProgramFile { get => _closingCostProgramFile; set => SetField(ref _closingCostProgramFile, value); }
        private DirtyValue<string> _closingTaxYear;
        /// <summary>
        /// 1098 Tax Year [3614]
        /// </summary>
        [LoanFieldProperty(Description = "1098 Tax Year")]
        public string ClosingTaxYear { get => _closingTaxYear; set => SetField(ref _closingTaxYear, value); }
        private DirtyValue<decimal?> _closingTaxYearInterestReceived;
        /// <summary>
        /// Mortgage Interest Received [3615]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Interest Received")]
        public decimal? ClosingTaxYearInterestReceived { get => _closingTaxYearInterestReceived; set => SetField(ref _closingTaxYearInterestReceived, value); }
        private DirtyValue<string> _complianceVersionCD3X1505;
        /// <summary>
        /// Pre2017KBYOAmendments Indicator  [COMPLIANCEVERSION.CD3X1505]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Pre2017KBYOAmendments Indicator ")]
        public string ComplianceVersionCD3X1505 { get => _complianceVersionCD3X1505; set => SetField(ref _complianceVersionCD3X1505, value); }
        private DirtyValue<string> _contactFax;
        /// <summary>
        /// Liability - Contact Info Fax [EDS.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability - Contact Info Fax")]
        public string ContactFax { get => _contactFax; set => SetField(ref _contactFax, value); }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// Liability - Contact Info Name [EDS.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Liability - Contact Info Name")]
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }
        private DirtyValue<string> _contactPhone;
        /// <summary>
        /// Liability - Contact Info Phone [EDS.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Liability - Contact Info Phone")]
        public string ContactPhone { get => _contactPhone; set => SetField(ref _contactPhone, value); }
        private DirtyValue<string> _contactTitle;
        /// <summary>
        /// Liability - Contact Info Title [EDS.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Liability - Contact Info Title")]
        public string ContactTitle { get => _contactTitle; set => SetField(ref _contactTitle, value); }
        private DirtyValue<bool?> _copyFromSubjectProperty;
        /// <summary>
        /// Borr Info Is copy from subject property [4104]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Is copy from subject property")]
        public bool? CopyFromSubjectProperty { get => _copyFromSubjectProperty; set => SetField(ref _copyFromSubjectProperty, value); }
        private DirtyValue<string> _dataTracLoanId;
        /// <summary>
        /// DataTrac loan ID [DATATRAC.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "DataTrac loan ID")]
        public string DataTracLoanId { get => _dataTracLoanId; set => SetField(ref _dataTracLoanId, value); }
        private DirtyValue<string> _docSetFile;
        /// <summary>
        /// Trans Details Document Tracking Template File Applied [2863]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Document Tracking Template File Applied")]
        public string DocSetFile { get => _docSetFile; set => SetField(ref _docSetFile, value); }
        private DirtyValue<int?> _factorForRevolvingDebt;
        /// <summary>
        /// Liabilities Factor for Revolving Debt [SYS.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Factor for Revolving Debt")]
        public int? FactorForRevolvingDebt { get => _factorForRevolvingDebt; set => SetField(ref _factorForRevolvingDebt, value); }
        private DirtyValue<bool?> _fannieDuAutoOrderIndicator;
        /// <summary>
        /// Fannie DU Report Auto Order Indicator [FANNIESERVICE.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fannie DU Report Auto Order Indicator")]
        public bool? FannieDuAutoOrderIndicator { get => _fannieDuAutoOrderIndicator; set => SetField(ref _fannieDuAutoOrderIndicator, value); }
        private DirtyValue<bool?> _fannieEcAutoOrderIndicator;
        /// <summary>
        /// Fannie EarlyCheck Report Auto Order Indicator [FANNIESERVICE.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fannie EarlyCheck Report Auto Order Indicator")]
        public bool? FannieEcAutoOrderIndicator { get => _fannieEcAutoOrderIndicator; set => SetField(ref _fannieEcAutoOrderIndicator, value); }
        private DirtyValue<string> _floodInsuranceExcluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp Flood Ins Excl [1801]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp Flood Ins Excl")]
        public string FloodInsuranceExcluded { get => _floodInsuranceExcluded; set => SetField(ref _floodInsuranceExcluded, value); }
        private DirtyValue<string> _formListFile;
        /// <summary>
        /// Trans Details Form List Template File Applied [2864]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Form List Template File Applied")]
        public string FormListFile { get => _formListFile; set => SetField(ref _formListFile, value); }
        private DirtyValue<bool?> _freddieLPAAutoOrderIndicator;
        /// <summary>
        /// Freddie LPA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie LPA Report Auto Order Indicator")]
        public bool? FreddieLPAAutoOrderIndicator { get => _freddieLPAAutoOrderIndicator; set => SetField(ref _freddieLPAAutoOrderIndicator, value); }
        private DirtyValue<bool?> _freddieLQAAutoOrderIndicator;
        /// <summary>
        /// Freddie LQA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie LQA Report Auto Order Indicator")]
        public bool? FreddieLQAAutoOrderIndicator { get => _freddieLQAAutoOrderIndicator; set => SetField(ref _freddieLQAAutoOrderIndicator, value); }
        private DirtyValue<decimal?> _housingExpenseIntRate1;
        /// <summary>
        /// Expenses Calc First Mtg Pymt Int Rate [INTRATE1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Expenses Calc First Mtg Pymt Int Rate")]
        public decimal? HousingExpenseIntRate1 { get => _housingExpenseIntRate1; set => SetField(ref _housingExpenseIntRate1, value); }
        private DirtyValue<decimal?> _housingExpenseIntRate2;
        /// <summary>
        /// Expenses Calc Other Fin Pymt Int Rate [INTRATE2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Expenses Calc Other Fin Pymt Int Rate")]
        public decimal? HousingExpenseIntRate2 { get => _housingExpenseIntRate2; set => SetField(ref _housingExpenseIntRate2, value); }
        private DirtyValue<decimal?> _housingExpenseLoanAmt1;
        /// <summary>
        /// Expenses Housing Expense Pymt Calc 1 Loan Amt [LOANAMT1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Housing Expense Pymt Calc 1 Loan Amt")]
        public decimal? HousingExpenseLoanAmt1 { get => _housingExpenseLoanAmt1; set => SetField(ref _housingExpenseLoanAmt1, value); }
        private DirtyValue<decimal?> _housingExpenseLoanAmt2;
        /// <summary>
        /// Expenses Housing Expense Pymt Calc 2 Loan Amt [LOANAMT2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Housing Expense Pymt Calc 2 Loan Amt")]
        public decimal? HousingExpenseLoanAmt2 { get => _housingExpenseLoanAmt2; set => SetField(ref _housingExpenseLoanAmt2, value); }
        private DirtyValue<decimal?> _housingExpensePayment1;
        /// <summary>
        /// Expenses Calc First Mtg Pymt Mo Pymt [PAYMENT1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Calc First Mtg Pymt Mo Pymt")]
        public decimal? HousingExpensePayment1 { get => _housingExpensePayment1; set => SetField(ref _housingExpensePayment1, value); }
        private DirtyValue<decimal?> _housingExpensePayment2;
        /// <summary>
        /// Expenses Calc Other Fin Pymt Mo Pymt [PAYMENT2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Calc Other Fin Pymt Mo Pymt")]
        public decimal? HousingExpensePayment2 { get => _housingExpensePayment2; set => SetField(ref _housingExpensePayment2, value); }
        private DirtyValue<int?> _housingExpenseTerm1;
        /// <summary>
        /// Expenses Calc First Mtg Pymt Term [TERM1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc First Mtg Pymt Term")]
        public int? HousingExpenseTerm1 { get => _housingExpenseTerm1; set => SetField(ref _housingExpenseTerm1, value); }
        private DirtyValue<int?> _housingExpenseTerm2;
        /// <summary>
        /// Expenses Calc Other Fin Pymt Term [TERM2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc Other Fin Pymt Term")]
        public int? HousingExpenseTerm2 { get => _housingExpenseTerm2; set => SetField(ref _housingExpenseTerm2, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Miscellaneous Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSameAddresswithPayer;
        /// <summary>
        /// Borr Info Is same Address with Payer/Borr [4103]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Is same Address with Payer/Borr")]
        public bool? IsSameAddresswithPayer { get => _isSameAddresswithPayer; set => SetField(ref _isSameAddresswithPayer, value); }
        private DirtyValue<string> _line1006Excluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp 1007 User Def Excl [1802]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp 1007 User Def Excl")]
        public string Line1006Excluded { get => _line1006Excluded; set => SetField(ref _line1006Excluded, value); }
        private DirtyValue<string> _line1007Excluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp 1008 User Def Excl [1803]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp 1008 User Def Excl")]
        public string Line1007Excluded { get => _line1007Excluded; set => SetField(ref _line1007Excluded, value); }
        private DirtyValue<string> _line1008Excluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp 1009 User Def Excl [1804]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp 1009 User Def Excl")]
        public string Line1008Excluded { get => _line1008Excluded; set => SetField(ref _line1008Excluded, value); }
        private DirtyValue<string> _line1010Excluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp 1010 USDA Monthly Premium Excl [3357]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp 1010 USDA Monthly Premium Excl")]
        public string Line1010Excluded { get => _line1010Excluded; set => SetField(ref _line1010Excluded, value); }
        private DirtyValue<int?> _loanFileSequenceNumber;
        /// <summary>
        /// Loan File Sequence Number [LOANFILESEQUENCENUMBER]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan File Sequence Number")]
        public int? LoanFileSequenceNumber { get => _loanFileSequenceNumber; set => SetField(ref _loanFileSequenceNumber, value); }
        private DirtyValue<string> _loanProgramFile;
        /// <summary>
        /// Trans Details Loan Program Template File Applied [2861]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Loan Program Template File Applied")]
        public string LoanProgramFile { get => _loanProgramFile; set => SetField(ref _loanProgramFile, value); }
        private DirtyValue<string> _loanTemplateFile;
        /// <summary>
        /// Trans Details Loan Template File Applied [2860]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Loan Template File Applied")]
        public string LoanTemplateFile { get => _loanTemplateFile; set => SetField(ref _loanTemplateFile, value); }
        private DirtyValue<string> _maventATRQMResult;
        /// <summary>
        /// Mavent Compliance Review ATR/QM Result [COMPLIANCEREVIEW.X18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review ATR/QM Result")]
        public string MaventATRQMResult { get => _maventATRQMResult; set => SetField(ref _maventATRQMResult, value); }
        private DirtyValue<bool?> _maventAutoOrderIndicator;
        /// <summary>
        /// Mavent Compliance Review Auto Order Indicator [COMPLIANCEREVIEW.X15]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Auto Order Indicator")]
        public bool? MaventAutoOrderIndicator { get => _maventAutoOrderIndicator; set => SetField(ref _maventAutoOrderIndicator, value); }
        private DirtyValue<string> _maventCraxResult;
        /// <summary>
        /// Mavent Compliance Review CRAx Result [COMPLIANCEREVIEW.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review CRAx Result")]
        public string MaventCraxResult { get => _maventCraxResult; set => SetField(ref _maventCraxResult, value); }
        private DirtyValue<string> _maventEnterpriseResult;
        /// <summary>
        /// Mavent Compliance Review Enterprise Result [COMPLIANCEREVIEW.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Enterprise Result")]
        public string MaventEnterpriseResult { get => _maventEnterpriseResult; set => SetField(ref _maventEnterpriseResult, value); }
        private DirtyValue<string> _maventGseResult;
        /// <summary>
        /// Mavent Compliance Review GSE Result [COMPLIANCEREVIEW.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review GSE Result")]
        public string MaventGseResult { get => _maventGseResult; set => SetField(ref _maventGseResult, value); }
        private DirtyValue<string> _maventHighCostResult;
        /// <summary>
        /// Mavent Compliance Review High Cost Result [COMPLIANCEREVIEW.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review High Cost Result")]
        public string MaventHighCostResult { get => _maventHighCostResult; set => SetField(ref _maventHighCostResult, value); }
        private DirtyValue<string> _maventHmdaResult;
        /// <summary>
        /// Mavent Compliance Review HMDA Result [COMPLIANCEREVIEW.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review HMDA Result")]
        public string MaventHmdaResult { get => _maventHmdaResult; set => SetField(ref _maventHmdaResult, value); }
        private DirtyValue<string> _maventHpmlResult;
        /// <summary>
        /// Mavent Compliance Review HPML Result [COMPLIANCEREVIEW.X16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review HPML Result")]
        public string MaventHpmlResult { get => _maventHpmlResult; set => SetField(ref _maventHpmlResult, value); }
        private DirtyValue<string> _maventLicenseResult;
        /// <summary>
        /// Mavent Compliance Review License Result [COMPLIANCEREVIEW.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review License Result")]
        public string MaventLicenseResult { get => _maventLicenseResult; set => SetField(ref _maventLicenseResult, value); }
        private DirtyValue<string> _maventNmlsResult;
        /// <summary>
        /// Mavent Compliance Review NMLS Result [COMPLIANCEREVIEW.X17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review NMLS Result")]
        public string MaventNmlsResult { get => _maventNmlsResult; set => SetField(ref _maventNmlsResult, value); }
        private DirtyValue<string> _maventOfacResult;
        /// <summary>
        /// Mavent Compliance Review OFAC Result [COMPLIANCEREVIEW.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review OFAC Result")]
        public string MaventOfacResult { get => _maventOfacResult; set => SetField(ref _maventOfacResult, value); }
        private DirtyValue<string> _maventOrderedBy;
        /// <summary>
        /// Mavent Compliance Review Ordered By [COMPLIANCEREVIEW.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Ordered By")]
        public string MaventOrderedBy { get => _maventOrderedBy; set => SetField(ref _maventOrderedBy, value); }
        private DirtyValue<DateTime?> _maventOrderedDate;
        /// <summary>
        /// Mavent Compliance Review Ordered Date [COMPLIANCEREVIEW.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Ordered Date")]
        public DateTime? MaventOrderedDate { get => _maventOrderedDate; set => SetField(ref _maventOrderedDate, value); }
        private DirtyValue<string> _maventOtherResult;
        /// <summary>
        /// Mavent Compliance Review Other Result [COMPLIANCEREVIEW.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Other Result")]
        public string MaventOtherResult { get => _maventOtherResult; set => SetField(ref _maventOtherResult, value); }
        private DirtyValue<string> _maventReviewResult;
        /// <summary>
        /// Mavent Compliance Review Result [COMPLIANCEREVIEW.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review Result")]
        public string MaventReviewResult { get => _maventReviewResult; set => SetField(ref _maventReviewResult, value); }
        private DirtyValue<string> _maventStateResult;
        /// <summary>
        /// Mavent Compliance Review State Result [COMPLIANCEREVIEW.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review State Result")]
        public string MaventStateResult { get => _maventStateResult; set => SetField(ref _maventStateResult, value); }
        private DirtyValue<string> _maventTilaRorResult;
        /// <summary>
        /// Mavent Compliance Review TILA ROR Result [COMPLIANCEREVIEW.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review TILA ROR Result")]
        public string MaventTilaRorResult { get => _maventTilaRorResult; set => SetField(ref _maventTilaRorResult, value); }
        private DirtyValue<string> _maventTilaToleranceResult;
        /// <summary>
        /// Mavent Compliance Review TILA Tolerance Result [COMPLIANCEREVIEW.X14]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Mavent Compliance Review TILA Tolerance Result")]
        public string MaventTilaToleranceResult { get => _maventTilaToleranceResult; set => SetField(ref _maventTilaToleranceResult, value); }
        private DirtyValue<decimal?> _mIPremiums;
        /// <summary>
        /// Borr Info MI Premiums [3842]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info MI Premiums")]
        public decimal? MIPremiums { get => _mIPremiums; set => SetField(ref _mIPremiums, value); }
        private DirtyValue<string> _miscDataFile;
        /// <summary>
        /// Trans Details Misc Data Template File Applied [2865]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Misc Data Template File Applied")]
        public string MiscDataFile { get => _miscDataFile; set => SetField(ref _miscDataFile, value); }
        private DirtyValue<int?> _monthsToExclude;
        /// <summary>
        /// Liabilities Install Mos to Exclude [998]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Install Mos to Exclude")]
        public int? MonthsToExclude { get => _monthsToExclude; set => SetField(ref _monthsToExclude, value); }
        private DirtyValue<string> _optimalBlueHistoryData;
        /// <summary>
        /// History Data From Optimal Blue [OPTIMAL.HISTORY]
        /// </summary>
        [LoanFieldProperty(Description = "History Data From Optimal Blue")]
        public string OptimalBlueHistoryData { get => _optimalBlueHistoryData; set => SetField(ref _optimalBlueHistoryData, value); }
        private DirtyValue<string> _optimalBlueRequest;
        /// <summary>
        /// Request String For Optimal Blue [OPTIMAL.REQUEST]
        /// </summary>
        [LoanFieldProperty(Description = "Request String For Optimal Blue")]
        public string OptimalBlueRequest { get => _optimalBlueRequest; set => SetField(ref _optimalBlueRequest, value); }
        private DirtyValue<string> _optimalBlueResponse;
        /// <summary>
        /// Response String From Optimal Blue [OPTIMAL.RESPONSE]
        /// </summary>
        [LoanFieldProperty(Description = "Response String From Optimal Blue")]
        public string OptimalBlueResponse { get => _optimalBlueResponse; set => SetField(ref _optimalBlueResponse, value); }
        private DirtyValue<decimal?> _otherPresentHousingExpense;
        /// <summary>
        /// Expenses Calc Other Hous Exp Other Amt [1799]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Calc Other Hous Exp Other Amt")]
        public decimal? OtherPresentHousingExpense { get => _otherPresentHousingExpense; set => SetField(ref _otherPresentHousingExpense, value); }
        private DirtyValue<decimal?> _outstandingMtgPrincipal;
        /// <summary>
        /// Borr Info Outstanding Mtg Principal [4095]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info Outstanding Mtg Principal")]
        public decimal? OutstandingMtgPrincipal { get => _outstandingMtgPrincipal; set => SetField(ref _outstandingMtgPrincipal, value); }
        private DirtyValue<DateTime?> _outstandingMtgPrincipalDate;
        /// <summary>
        /// Borr Info Outstanding Mtg Principal Date [4096]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Outstanding Mtg Principal Date")]
        public DateTime? OutstandingMtgPrincipalDate { get => _outstandingMtgPrincipalDate; set => SetField(ref _outstandingMtgPrincipalDate, value); }
        private DirtyValue<bool?> _participateHomePoints;
        /// <summary>
        /// Home Points Program Loan will Participate [2859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Home Points Program Loan will Participate", OptionsJson = "{\"true\":\"Loan Will Participate in the HomePoints Program\"}")]
        public bool? ParticipateHomePoints { get => _participateHomePoints; set => SetField(ref _participateHomePoints, value); }
        private DirtyValue<string> _partnerEmail;
        /// <summary>
        /// Trans Details Processing Network Partner Email [EPN.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Processing Network Partner Email")]
        public string PartnerEmail { get => _partnerEmail; set => SetField(ref _partnerEmail, value); }
        private DirtyValue<string> _partnerName;
        /// <summary>
        /// Trans Details Processing Network Partner Name [EPN.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Processing Network Partner Name")]
        public string PartnerName { get => _partnerName; set => SetField(ref _partnerName, value); }
        private DirtyValue<string> _partnerPhone;
        /// <summary>
        /// Trans Details Processing Network Partner Phone [EPN.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Trans Details Processing Network Partner Phone")]
        public string PartnerPhone { get => _partnerPhone; set => SetField(ref _partnerPhone, value); }
        private DirtyValue<decimal?> _pointsPaid;
        /// <summary>
        /// Borr Info Points Paid [1191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info Points Paid")]
        public decimal? PointsPaid { get => _pointsPaid; set => SetField(ref _pointsPaid, value); }
        private DirtyValue<bool?> _printStateLicenseOn1003;
        /// <summary>
        /// Liability - Print State License Number on 1003 [EDS.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Liability - Print State License Number on 1003")]
        public bool? PrintStateLicenseOn1003 { get => _printStateLicenseOn1003; set => SetField(ref _printStateLicenseOn1003, value); }
        private DirtyValue<DateTime?> _rateRegistrationExpirationDate;
        /// <summary>
        /// Rate Registration Expiration Date [2824]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Expiration Date")]
        public DateTime? RateRegistrationExpirationDate { get => _rateRegistrationExpirationDate; set => SetField(ref _rateRegistrationExpirationDate, value); }
        private DirtyValue<string> _rateRegistrationInvestorName;
        /// <summary>
        /// Rate Registration Investor Name [2825]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Investor Name")]
        public string RateRegistrationInvestorName { get => _rateRegistrationInvestorName; set => SetField(ref _rateRegistrationInvestorName, value); }
        private DirtyValue<bool?> _rateRegistrationLoanIsRegistered;
        /// <summary>
        /// Rate Registration Loan Is Registered [2827]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Registration Loan Is Registered")]
        public bool? RateRegistrationLoanIsRegistered { get => _rateRegistrationLoanIsRegistered; set => SetField(ref _rateRegistrationLoanIsRegistered, value); }
        private DirtyValue<string> _rateRegistrationReference;
        /// <summary>
        /// Rate Registration Reference [2826]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Reference")]
        public string RateRegistrationReference { get => _rateRegistrationReference; set => SetField(ref _rateRegistrationReference, value); }
        private DirtyValue<string> _rateRegistrationRegisteredBy;
        /// <summary>
        /// Rate Registration Created By [2822]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Created By")]
        public string RateRegistrationRegisteredBy { get => _rateRegistrationRegisteredBy; set => SetField(ref _rateRegistrationRegisteredBy, value); }
        private DirtyValue<string> _rateRegistrationRegisteredUserId;
        /// <summary>
        /// Rate Registration Created By User ID [2828]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Created By User ID")]
        public string RateRegistrationRegisteredUserId { get => _rateRegistrationRegisteredUserId; set => SetField(ref _rateRegistrationRegisteredUserId, value); }
        private DirtyValue<DateTime?> _rateRegistrationRegistrationDate;
        /// <summary>
        /// Rate Registration Date [2823]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Registration Date")]
        public DateTime? RateRegistrationRegistrationDate { get => _rateRegistrationRegistrationDate; set => SetField(ref _rateRegistrationRegistrationDate, value); }
        private DirtyValue<decimal?> _refundOrOverpaidInterest;
        /// <summary>
        /// Borr Info Refund of Overpaid Interest [1192]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info Refund of Overpaid Interest")]
        public decimal? RefundOrOverpaidInterest { get => _refundOrOverpaidInterest; set => SetField(ref _refundOrOverpaidInterest, value); }
        private DirtyValue<string> _savedLogVersion;
        /// <summary>
        /// Encompass Version When Disclosure Tracking Log is Added to Loan [COMPLIANCEVERSION.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Encompass Version When Disclosure Tracking Log is Added to Loan")]
        public string SavedLogVersion { get => _savedLogVersion; set => SetField(ref _savedLogVersion, value); }
        private DirtyValue<string> _schoolTaxExcluded;
        /// <summary>
        /// Expenses Calc Other Hous Exp City Prop Tax Excl [1800]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Other Hous Exp City Prop Tax Excl")]
        public string SchoolTaxExcluded { get => _schoolTaxExcluded; set => SetField(ref _schoolTaxExcluded, value); }
        private DirtyValue<string> _state;
        /// <summary>
        /// Borr Info State [4099]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info State")]
        public string State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<string> _statusUrl;
        /// <summary>
        /// Trans Details Processing Network Status URL [EPN.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Processing Network Status URL")]
        public string StatusUrl { get => _statusUrl; set => SetField(ref _statusUrl, value); }
        private DirtyValue<DateTime?> _submitDate;
        /// <summary>
        /// Trans Details Processing Network Submit Date [EPN.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Processing Network Submit Date")]
        public DateTime? SubmitDate { get => _submitDate; set => SetField(ref _submitDate, value); }
        private DirtyValue<string> _subTaxYear;
        /// <summary>
        /// 1098 Tax Year [3616]
        /// </summary>
        [LoanFieldProperty(Description = "1098 Tax Year")]
        public string SubTaxYear { get => _subTaxYear; set => SetField(ref _subTaxYear, value); }
        private DirtyValue<decimal?> _subTaxYearInterestReceived;
        /// <summary>
        /// Mortgage Interest Received [3617]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Mortgage Interest Received")]
        public decimal? SubTaxYearInterestReceived { get => _subTaxYearInterestReceived; set => SetField(ref _subTaxYearInterestReceived, value); }
        private DirtyValue<decimal?> _subTaxYearMIPremiums;
        /// <summary>
        /// Borr Info MI Premiums [3843]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info MI Premiums")]
        public decimal? SubTaxYearMIPremiums { get => _subTaxYearMIPremiums; set => SetField(ref _subTaxYearMIPremiums, value); }
        private DirtyValue<decimal?> _subTaxYearPointsPaid;
        /// <summary>
        /// Borr Info Points Paid [3618]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info Points Paid")]
        public decimal? SubTaxYearPointsPaid { get => _subTaxYearPointsPaid; set => SetField(ref _subTaxYearPointsPaid, value); }
        private DirtyValue<decimal?> _subTaxYearRefundOrOverpaidInterest;
        /// <summary>
        /// Borr Info Refund of Overpaid Interest [3619]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Info Refund of Overpaid Interest")]
        public decimal? SubTaxYearRefundOrOverpaidInterest { get => _subTaxYearRefundOrOverpaidInterest; set => SetField(ref _subTaxYearRefundOrOverpaidInterest, value); }
        private DirtyValue<string> _taxId;
        /// <summary>
        /// File Contacts Lender Info Tax ID [1196]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender Info Tax ID")]
        public string TaxId { get => _taxId; set => SetField(ref _taxId, value); }
        private DirtyValue<decimal?> _totalBox4;
        /// <summary>
        /// IRS Total of MI for Tax Year and Upfront MIP [2846]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "IRS Total of MI for Tax Year and Upfront MIP")]
        public decimal? TotalBox4 { get => _totalBox4; set => SetField(ref _totalBox4, value); }
        private DirtyValue<decimal?> _totalYearlyMi;
        /// <summary>
        /// IRS Total of MI for Tax Year [2845]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "IRS Total of MI for Tax Year")]
        public decimal? TotalYearlyMi { get => _totalYearlyMi; set => SetField(ref _totalYearlyMi, value); }
        private DirtyValue<bool?> _tPOConnectStatusUpdated;
        /// <summary>
        /// TPO Connect Status Updated [TPOCONNECTSTATUSUPDATED]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TPO Connect Status Updated")]
        public bool? TPOConnectStatusUpdated { get => _tPOConnectStatusUpdated; set => SetField(ref _tPOConnectStatusUpdated, value); }
        private DirtyValue<string> _useGfeTax;
        /// <summary>
        /// Real Estate Tax Overide w/GFE Tax [USEGFETAX]
        /// </summary>
        [LoanFieldProperty(Description = "Real Estate Tax Overide w/GFE Tax")]
        public string UseGfeTax { get => _useGfeTax; set => SetField(ref _useGfeTax, value); }
        private DirtyValue<string> _useRegZMi;
        /// <summary>
        /// Expenses Calc Mtg Ins Override w/ REGZ MI [USEREGZMI]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc Mtg Ins Override w/ REGZ MI")]
        public string UseRegZMi { get => _useRegZMi; set => SetField(ref _useRegZMi, value); }
        private DirtyValue<string> _zip;
        /// <summary>
        /// Borr Info Zip [4100]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Info Zip")]
        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}