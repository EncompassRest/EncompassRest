using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Miscellaneous
    /// </summary>
    public sealed partial class Miscellaneous : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        private DirtyValue<string> _allRoles;
        private DirtyValue<string> _allUserInfo;
        private DirtyValue<string> _borrowerDescription1;
        private DirtyValue<string> _borrowerDescription2;
        private DirtyValue<string> _borrowerDescription3;
        private DirtyValue<string> _borrowerDescription4;
        private DirtyValue<string> _borrowerDescription5;
        private DirtyValue<string> _borrowerDescription6;
        private DirtyValue<string> _borrowerDescription7;
        private DirtyValue<string> _city;
        private DirtyValue<string> _closingCostProgramFile;
        private DirtyValue<string> _closingTaxYear;
        private DirtyValue<decimal?> _closingTaxYearInterestReceived;
        private DirtyValue<string> _complianceVersionCD3X1505;
        private DirtyValue<string> _contactFax;
        private DirtyValue<string> _contactName;
        private DirtyValue<string> _contactPhone;
        private DirtyValue<string> _contactTitle;
        private DirtyValue<bool?> _copyFromSubjectProperty;
        private DirtyValue<string> _dataTracLoanId;
        private DirtyValue<string> _docSetFile;
        private DirtyValue<int?> _factorForRevolvingDebt;
        private DirtyValue<bool?> _fannieDuAutoOrderIndicator;
        private DirtyValue<bool?> _fannieEcAutoOrderIndicator;
        private DirtyValue<string> _floodInsuranceExcluded;
        private DirtyValue<string> _formListFile;
        private DirtyValue<bool?> _freddieLPAAutoOrderIndicator;
        private DirtyValue<bool?> _freddieLQAAutoOrderIndicator;
        private DirtyValue<decimal?> _housingExpenseIntRate1;
        private DirtyValue<decimal?> _housingExpenseIntRate2;
        private DirtyValue<decimal?> _housingExpenseLoanAmt1;
        private DirtyValue<decimal?> _housingExpenseLoanAmt2;
        private DirtyValue<decimal?> _housingExpensePayment1;
        private DirtyValue<decimal?> _housingExpensePayment2;
        private DirtyValue<int?> _housingExpenseTerm1;
        private DirtyValue<int?> _housingExpenseTerm2;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSameAddresswithPayer;
        private DirtyValue<DateTime?> _lastFeeImportDate;
        private DirtyValue<string> _lenderFeeQuoteID;
        private DirtyValue<string> _line1006Excluded;
        private DirtyValue<string> _line1007Excluded;
        private DirtyValue<string> _line1008Excluded;
        private DirtyValue<string> _line1010Excluded;
        private DirtyValue<int?> _loanFileSequenceNumber;
        private DirtyValue<string> _loanProgramFile;
        private DirtyValue<string> _loanTemplateFile;
        private DirtyValue<string> _maventATRQMResult;
        private DirtyValue<bool?> _maventAutoOrderIndicator;
        private DirtyValue<string> _maventCraxResult;
        private DirtyValue<string> _maventEnterpriseResult;
        private DirtyValue<string> _maventGseResult;
        private DirtyValue<string> _maventHighCostResult;
        private DirtyValue<string> _maventHmdaResult;
        private DirtyValue<string> _maventHpmlResult;
        private DirtyValue<string> _maventLicenseResult;
        private DirtyValue<string> _maventNmlsResult;
        private DirtyValue<string> _maventOfacResult;
        private DirtyValue<string> _maventOrderedBy;
        private DirtyValue<DateTime?> _maventOrderedDate;
        private DirtyValue<string> _maventOtherResult;
        private DirtyValue<string> _maventReviewResult;
        private DirtyValue<string> _maventStateResult;
        private DirtyValue<string> _maventTilaRorResult;
        private DirtyValue<string> _maventTilaToleranceResult;
        private DirtyValue<decimal?> _mIPremiums;
        private DirtyValue<string> _miscDataFile;
        private DirtyValue<int?> _monthsToExclude;
        private DirtyValue<string> _optimalBlueHistoryData;
        private DirtyValue<string> _optimalBlueRequest;
        private DirtyValue<string> _optimalBlueResponse;
        private DirtyValue<decimal?> _otherPresentHousingExpense;
        private DirtyValue<decimal?> _outstandingMtgPrincipal;
        private DirtyValue<DateTime?> _outstandingMtgPrincipalDate;
        private DirtyValue<bool?> _participateHomePoints;
        private DirtyValue<string> _partnerEmail;
        private DirtyValue<string> _partnerFeeQuoteID;
        private DirtyValue<string> _partnerName;
        private DirtyValue<string> _partnerPhone;
        private DirtyValue<decimal?> _pointsPaid;
        private DirtyValue<bool?> _printStateLicenseOn1003;
        private DirtyValue<DateTime?> _rateRegistrationExpirationDate;
        private DirtyValue<string> _rateRegistrationInvestorName;
        private DirtyValue<bool?> _rateRegistrationLoanIsRegistered;
        private DirtyValue<string> _rateRegistrationReference;
        private DirtyValue<string> _rateRegistrationRegisteredBy;
        private DirtyValue<string> _rateRegistrationRegisteredUserId;
        private DirtyValue<DateTime?> _rateRegistrationRegistrationDate;
        private DirtyValue<decimal?> _refundOrOverpaidInterest;
        private DirtyValue<string> _savedLogVersion;
        private DirtyValue<string> _schoolTaxExcluded;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<string> _statusUrl;
        private DirtyValue<DateTime?> _submitDate;
        private DirtyValue<string> _subTaxYear;
        private DirtyValue<decimal?> _subTaxYearInterestReceived;
        private DirtyValue<decimal?> _subTaxYearMIPremiums;
        private DirtyValue<decimal?> _subTaxYearPointsPaid;
        private DirtyValue<decimal?> _subTaxYearRefundOrOverpaidInterest;
        private DirtyValue<string> _taxId;
        private DirtyValue<decimal?> _totalBox4;
        private DirtyValue<decimal?> _totalYearlyMi;
        private DirtyValue<bool?> _tPOConnectStatusUpdated;
        private DirtyValue<string> _useGfeTax;
        private DirtyValue<string> _useRegZMi;
        private DirtyValue<string> _zip;

        /// <summary>
        /// Borr Info Address [4097]
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }

        /// <summary>
        /// All Roles Informaton [EDS.X6]
        /// </summary>
        public string AllRoles { get => _allRoles; set => SetField(ref _allRoles, value); }

        /// <summary>
        /// All Users Informaton [EDS.X7]
        /// </summary>
        public string AllUserInfo { get => _allUserInfo; set => SetField(ref _allUserInfo, value); }

        /// <summary>
        /// Borr Info Other Descr 1 [1193]
        /// </summary>
        public string BorrowerDescription1 { get => _borrowerDescription1; set => SetField(ref _borrowerDescription1, value); }

        /// <summary>
        /// Borr Info Other Descr 2 [1194]
        /// </summary>
        public string BorrowerDescription2 { get => _borrowerDescription2; set => SetField(ref _borrowerDescription2, value); }

        /// <summary>
        /// Borr Info Other Descr 3 [1195]
        /// </summary>
        public string BorrowerDescription3 { get => _borrowerDescription3; set => SetField(ref _borrowerDescription3, value); }

        /// <summary>
        /// Borr Info Other Descr 4 [3620]
        /// </summary>
        public string BorrowerDescription4 { get => _borrowerDescription4; set => SetField(ref _borrowerDescription4, value); }

        /// <summary>
        /// Borr Info Other Descr 5 [3621]
        /// </summary>
        public string BorrowerDescription5 { get => _borrowerDescription5; set => SetField(ref _borrowerDescription5, value); }

        /// <summary>
        /// Borr Info BorrowerDescription 6 [4101]
        /// </summary>
        public string BorrowerDescription6 { get => _borrowerDescription6; set => SetField(ref _borrowerDescription6, value); }

        /// <summary>
        /// Borr Info BorrowerDescription 7 [4102]
        /// </summary>
        public string BorrowerDescription7 { get => _borrowerDescription7; set => SetField(ref _borrowerDescription7, value); }

        /// <summary>
        /// Borr Info City [4098]
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Trans Details Closing Cost Program Template File Applied [2862]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ClosingCostProgramFile { get => _closingCostProgramFile; set => SetField(ref _closingCostProgramFile, value); }

        /// <summary>
        /// 1098 Tax Year [3614]
        /// </summary>
        public string ClosingTaxYear { get => _closingTaxYear; set => SetField(ref _closingTaxYear, value); }

        /// <summary>
        /// Mortgage Interest Received [3615]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClosingTaxYearInterestReceived { get => _closingTaxYearInterestReceived; set => SetField(ref _closingTaxYearInterestReceived, value); }

        /// <summary>
        /// Pre2017KBYOAmendments Indicator  [COMPLIANCEVERSION.CD3X1505]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ComplianceVersionCD3X1505 { get => _complianceVersionCD3X1505; set => SetField(ref _complianceVersionCD3X1505, value); }

        /// <summary>
        /// Liability - Contact Info Fax [EDS.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string ContactFax { get => _contactFax; set => SetField(ref _contactFax, value); }

        /// <summary>
        /// Liability - Contact Info Name [EDS.X1]
        /// </summary>
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }

        /// <summary>
        /// Liability - Contact Info Phone [EDS.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string ContactPhone { get => _contactPhone; set => SetField(ref _contactPhone, value); }

        /// <summary>
        /// Liability - Contact Info Title [EDS.X2]
        /// </summary>
        public string ContactTitle { get => _contactTitle; set => SetField(ref _contactTitle, value); }

        /// <summary>
        /// Borr Info Is copy from subject property [4104]
        /// </summary>
        public bool? CopyFromSubjectProperty { get => _copyFromSubjectProperty; set => SetField(ref _copyFromSubjectProperty, value); }

        /// <summary>
        /// DataTrac loan ID [DATATRAC.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DataTracLoanId { get => _dataTracLoanId; set => SetField(ref _dataTracLoanId, value); }

        /// <summary>
        /// Trans Details Document Tracking Template File Applied [2863]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DocSetFile { get => _docSetFile; set => SetField(ref _docSetFile, value); }

        /// <summary>
        /// Liabilities Factor for Revolving Debt [SYS.X13]
        /// </summary>
        public int? FactorForRevolvingDebt { get => _factorForRevolvingDebt; set => SetField(ref _factorForRevolvingDebt, value); }

        /// <summary>
        /// Fannie DU Report Auto Order Indicator [FANNIESERVICE.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? FannieDuAutoOrderIndicator { get => _fannieDuAutoOrderIndicator; set => SetField(ref _fannieDuAutoOrderIndicator, value); }

        /// <summary>
        /// Fannie EarlyCheck Report Auto Order Indicator [FANNIESERVICE.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? FannieEcAutoOrderIndicator { get => _fannieEcAutoOrderIndicator; set => SetField(ref _fannieEcAutoOrderIndicator, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp Flood Ins Excl [1801]
        /// </summary>
        public string FloodInsuranceExcluded { get => _floodInsuranceExcluded; set => SetField(ref _floodInsuranceExcluded, value); }

        /// <summary>
        /// Trans Details Form List Template File Applied [2864]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FormListFile { get => _formListFile; set => SetField(ref _formListFile, value); }

        /// <summary>
        /// Freddie LPA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X1]
        /// </summary>
        public bool? FreddieLPAAutoOrderIndicator { get => _freddieLPAAutoOrderIndicator; set => SetField(ref _freddieLPAAutoOrderIndicator, value); }

        /// <summary>
        /// Freddie LQA Report Auto Order Indicator [ORDERFREDDIEINDICATOR.X2]
        /// </summary>
        public bool? FreddieLQAAutoOrderIndicator { get => _freddieLQAAutoOrderIndicator; set => SetField(ref _freddieLQAAutoOrderIndicator, value); }

        /// <summary>
        /// Expenses Calc First Mtg Pymt Int Rate [INTRATE1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? HousingExpenseIntRate1 { get => _housingExpenseIntRate1; set => SetField(ref _housingExpenseIntRate1, value); }

        /// <summary>
        /// Expenses Calc Other Fin Pymt Int Rate [INTRATE2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? HousingExpenseIntRate2 { get => _housingExpenseIntRate2; set => SetField(ref _housingExpenseIntRate2, value); }

        /// <summary>
        /// Expenses Housing Expense Pymt Calc 1 Loan Amt [LOANAMT1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? HousingExpenseLoanAmt1 { get => _housingExpenseLoanAmt1; set => SetField(ref _housingExpenseLoanAmt1, value); }

        /// <summary>
        /// Expenses Housing Expense Pymt Calc 2 Loan Amt [LOANAMT2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? HousingExpenseLoanAmt2 { get => _housingExpenseLoanAmt2; set => SetField(ref _housingExpenseLoanAmt2, value); }

        /// <summary>
        /// Expenses Calc First Mtg Pymt Mo Pymt [PAYMENT1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? HousingExpensePayment1 { get => _housingExpensePayment1; set => SetField(ref _housingExpensePayment1, value); }

        /// <summary>
        /// Expenses Calc Other Fin Pymt Mo Pymt [PAYMENT2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? HousingExpensePayment2 { get => _housingExpensePayment2; set => SetField(ref _housingExpensePayment2, value); }

        /// <summary>
        /// Expenses Calc First Mtg Pymt Term [TERM1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? HousingExpenseTerm1 { get => _housingExpenseTerm1; set => SetField(ref _housingExpenseTerm1, value); }

        /// <summary>
        /// Expenses Calc Other Fin Pymt Term [TERM2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? HousingExpenseTerm2 { get => _housingExpenseTerm2; set => SetField(ref _housingExpenseTerm2, value); }

        /// <summary>
        /// Miscellaneous Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Borr Info Is same Address with Payer/Borr [4103]
        /// </summary>
        public bool? IsSameAddresswithPayer { get => _isSameAddresswithPayer; set => SetField(ref _isSameAddresswithPayer, value); }

        /// <summary>
        /// Last Fee Import Date to Support Data Imports [4498]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LastFeeImportDate { get => _lastFeeImportDate; set => SetField(ref _lastFeeImportDate, value); }

        /// <summary>
        /// Lender Fee Quote ID to Support Fee Data Imports [4496]
        /// </summary>
        public string LenderFeeQuoteID { get => _lenderFeeQuoteID; set => SetField(ref _lenderFeeQuoteID, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp 1007 User Def Excl [1802]
        /// </summary>
        public string Line1006Excluded { get => _line1006Excluded; set => SetField(ref _line1006Excluded, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp 1008 User Def Excl [1803]
        /// </summary>
        public string Line1007Excluded { get => _line1007Excluded; set => SetField(ref _line1007Excluded, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp 1009 User Def Excl [1804]
        /// </summary>
        public string Line1008Excluded { get => _line1008Excluded; set => SetField(ref _line1008Excluded, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp 1010 USDA Monthly Premium Excl [3357]
        /// </summary>
        public string Line1010Excluded { get => _line1010Excluded; set => SetField(ref _line1010Excluded, value); }

        /// <summary>
        /// Loan File Sequence Number [LOANFILESEQUENCENUMBER]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LoanFileSequenceNumber { get => _loanFileSequenceNumber; set => SetField(ref _loanFileSequenceNumber, value); }

        /// <summary>
        /// Trans Details Loan Program Template File Applied [2861]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanProgramFile { get => _loanProgramFile; set => SetField(ref _loanProgramFile, value); }

        /// <summary>
        /// Trans Details Loan Template File Applied [2860]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanTemplateFile { get => _loanTemplateFile; set => SetField(ref _loanTemplateFile, value); }

        /// <summary>
        /// Mavent Compliance Review ATR/QM Result [COMPLIANCEREVIEW.X18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventATRQMResult { get => _maventATRQMResult; set => SetField(ref _maventATRQMResult, value); }

        /// <summary>
        /// Mavent Compliance Review Auto Order Indicator [COMPLIANCEREVIEW.X15]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? MaventAutoOrderIndicator { get => _maventAutoOrderIndicator; set => SetField(ref _maventAutoOrderIndicator, value); }

        /// <summary>
        /// Mavent Compliance Review CRAx Result [COMPLIANCEREVIEW.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventCraxResult { get => _maventCraxResult; set => SetField(ref _maventCraxResult, value); }

        /// <summary>
        /// Mavent Compliance Review Enterprise Result [COMPLIANCEREVIEW.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventEnterpriseResult { get => _maventEnterpriseResult; set => SetField(ref _maventEnterpriseResult, value); }

        /// <summary>
        /// Mavent Compliance Review GSE Result [COMPLIANCEREVIEW.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventGseResult { get => _maventGseResult; set => SetField(ref _maventGseResult, value); }

        /// <summary>
        /// Mavent Compliance Review High Cost Result [COMPLIANCEREVIEW.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventHighCostResult { get => _maventHighCostResult; set => SetField(ref _maventHighCostResult, value); }

        /// <summary>
        /// Mavent Compliance Review HMDA Result [COMPLIANCEREVIEW.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventHmdaResult { get => _maventHmdaResult; set => SetField(ref _maventHmdaResult, value); }

        /// <summary>
        /// Mavent Compliance Review HPML Result [COMPLIANCEREVIEW.X16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventHpmlResult { get => _maventHpmlResult; set => SetField(ref _maventHpmlResult, value); }

        /// <summary>
        /// Mavent Compliance Review License Result [COMPLIANCEREVIEW.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventLicenseResult { get => _maventLicenseResult; set => SetField(ref _maventLicenseResult, value); }

        /// <summary>
        /// Mavent Compliance Review NMLS Result [COMPLIANCEREVIEW.X17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventNmlsResult { get => _maventNmlsResult; set => SetField(ref _maventNmlsResult, value); }

        /// <summary>
        /// Mavent Compliance Review OFAC Result [COMPLIANCEREVIEW.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventOfacResult { get => _maventOfacResult; set => SetField(ref _maventOfacResult, value); }

        /// <summary>
        /// Mavent Compliance Review Ordered By [COMPLIANCEREVIEW.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventOrderedBy { get => _maventOrderedBy; set => SetField(ref _maventOrderedBy, value); }

        /// <summary>
        /// Mavent Compliance Review Ordered Date [COMPLIANCEREVIEW.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? MaventOrderedDate { get => _maventOrderedDate; set => SetField(ref _maventOrderedDate, value); }

        /// <summary>
        /// Mavent Compliance Review Other Result [COMPLIANCEREVIEW.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventOtherResult { get => _maventOtherResult; set => SetField(ref _maventOtherResult, value); }

        /// <summary>
        /// Mavent Compliance Review Result [COMPLIANCEREVIEW.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventReviewResult { get => _maventReviewResult; set => SetField(ref _maventReviewResult, value); }

        /// <summary>
        /// Mavent Compliance Review State Result [COMPLIANCEREVIEW.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventStateResult { get => _maventStateResult; set => SetField(ref _maventStateResult, value); }

        /// <summary>
        /// Mavent Compliance Review TILA ROR Result [COMPLIANCEREVIEW.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventTilaRorResult { get => _maventTilaRorResult; set => SetField(ref _maventTilaRorResult, value); }

        /// <summary>
        /// Mavent Compliance Review TILA Tolerance Result [COMPLIANCEREVIEW.X14]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaventTilaToleranceResult { get => _maventTilaToleranceResult; set => SetField(ref _maventTilaToleranceResult, value); }

        /// <summary>
        /// Borr Info MI Premiums [3842]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MIPremiums { get => _mIPremiums; set => SetField(ref _mIPremiums, value); }

        /// <summary>
        /// Trans Details Misc Data Template File Applied [2865]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MiscDataFile { get => _miscDataFile; set => SetField(ref _miscDataFile, value); }

        /// <summary>
        /// Liabilities Install Mos to Exclude [998]
        /// </summary>
        public int? MonthsToExclude { get => _monthsToExclude; set => SetField(ref _monthsToExclude, value); }

        /// <summary>
        /// History Data From Optimal Blue [OPTIMAL.HISTORY]
        /// </summary>
        public string OptimalBlueHistoryData { get => _optimalBlueHistoryData; set => SetField(ref _optimalBlueHistoryData, value); }

        /// <summary>
        /// Request String For Optimal Blue [OPTIMAL.REQUEST]
        /// </summary>
        public string OptimalBlueRequest { get => _optimalBlueRequest; set => SetField(ref _optimalBlueRequest, value); }

        /// <summary>
        /// Response String From Optimal Blue [OPTIMAL.RESPONSE]
        /// </summary>
        public string OptimalBlueResponse { get => _optimalBlueResponse; set => SetField(ref _optimalBlueResponse, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp Other Amt [1799]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherPresentHousingExpense { get => _otherPresentHousingExpense; set => SetField(ref _otherPresentHousingExpense, value); }

        /// <summary>
        /// Borr Info Outstanding Mtg Principal [4095]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OutstandingMtgPrincipal { get => _outstandingMtgPrincipal; set => SetField(ref _outstandingMtgPrincipal, value); }

        /// <summary>
        /// Borr Info Outstanding Mtg Principal Date [4096]
        /// </summary>
        public DateTime? OutstandingMtgPrincipalDate { get => _outstandingMtgPrincipalDate; set => SetField(ref _outstandingMtgPrincipalDate, value); }

        /// <summary>
        /// Home Points Program Loan will Participate [2859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"true\":\"Loan Will Participate in the HomePoints Program\"}")]
        public bool? ParticipateHomePoints { get => _participateHomePoints; set => SetField(ref _participateHomePoints, value); }

        /// <summary>
        /// Trans Details Processing Network Partner Email [EPN.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PartnerEmail { get => _partnerEmail; set => SetField(ref _partnerEmail, value); }

        /// <summary>
        /// Partner Fee Quote ID to Support Fee Data Imports [4497]
        /// </summary>
        public string PartnerFeeQuoteID { get => _partnerFeeQuoteID; set => SetField(ref _partnerFeeQuoteID, value); }

        /// <summary>
        /// Trans Details Processing Network Partner Name [EPN.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PartnerName { get => _partnerName; set => SetField(ref _partnerName, value); }

        /// <summary>
        /// Trans Details Processing Network Partner Phone [EPN.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
        public string PartnerPhone { get => _partnerPhone; set => SetField(ref _partnerPhone, value); }

        /// <summary>
        /// Borr Info Points Paid [1191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PointsPaid { get => _pointsPaid; set => SetField(ref _pointsPaid, value); }

        /// <summary>
        /// Liability - Print State License Number on 1003 [EDS.X5]
        /// </summary>
        public bool? PrintStateLicenseOn1003 { get => _printStateLicenseOn1003; set => SetField(ref _printStateLicenseOn1003, value); }

        /// <summary>
        /// Rate Registration Expiration Date [2824]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? RateRegistrationExpirationDate { get => _rateRegistrationExpirationDate; set => SetField(ref _rateRegistrationExpirationDate, value); }

        /// <summary>
        /// Rate Registration Investor Name [2825]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RateRegistrationInvestorName { get => _rateRegistrationInvestorName; set => SetField(ref _rateRegistrationInvestorName, value); }

        /// <summary>
        /// Rate Registration Loan Is Registered [2827]
        /// </summary>
        public bool? RateRegistrationLoanIsRegistered { get => _rateRegistrationLoanIsRegistered; set => SetField(ref _rateRegistrationLoanIsRegistered, value); }

        /// <summary>
        /// Rate Registration Reference [2826]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RateRegistrationReference { get => _rateRegistrationReference; set => SetField(ref _rateRegistrationReference, value); }

        /// <summary>
        /// Rate Registration Created By [2822]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RateRegistrationRegisteredBy { get => _rateRegistrationRegisteredBy; set => SetField(ref _rateRegistrationRegisteredBy, value); }

        /// <summary>
        /// Rate Registration Created By User ID [2828]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RateRegistrationRegisteredUserId { get => _rateRegistrationRegisteredUserId; set => SetField(ref _rateRegistrationRegisteredUserId, value); }

        /// <summary>
        /// Rate Registration Date [2823]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? RateRegistrationRegistrationDate { get => _rateRegistrationRegistrationDate; set => SetField(ref _rateRegistrationRegistrationDate, value); }

        /// <summary>
        /// Borr Info Refund of Overpaid Interest [1192]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RefundOrOverpaidInterest { get => _refundOrOverpaidInterest; set => SetField(ref _refundOrOverpaidInterest, value); }

        /// <summary>
        /// Encompass Version When Disclosure Tracking Log is Added to Loan [COMPLIANCEVERSION.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SavedLogVersion { get => _savedLogVersion; set => SetField(ref _savedLogVersion, value); }

        /// <summary>
        /// Expenses Calc Other Hous Exp City Prop Tax Excl [1800]
        /// </summary>
        public string SchoolTaxExcluded { get => _schoolTaxExcluded; set => SetField(ref _schoolTaxExcluded, value); }

        /// <summary>
        /// Borr Info State [4099]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Trans Details Processing Network Status URL [EPN.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string StatusUrl { get => _statusUrl; set => SetField(ref _statusUrl, value); }

        /// <summary>
        /// Trans Details Processing Network Submit Date [EPN.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? SubmitDate { get => _submitDate; set => SetField(ref _submitDate, value); }

        /// <summary>
        /// 1098 Tax Year [3616]
        /// </summary>
        public string SubTaxYear { get => _subTaxYear; set => SetField(ref _subTaxYear, value); }

        /// <summary>
        /// Mortgage Interest Received [3617]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SubTaxYearInterestReceived { get => _subTaxYearInterestReceived; set => SetField(ref _subTaxYearInterestReceived, value); }

        /// <summary>
        /// Borr Info MI Premiums [3843]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SubTaxYearMIPremiums { get => _subTaxYearMIPremiums; set => SetField(ref _subTaxYearMIPremiums, value); }

        /// <summary>
        /// Borr Info Points Paid [3618]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SubTaxYearPointsPaid { get => _subTaxYearPointsPaid; set => SetField(ref _subTaxYearPointsPaid, value); }

        /// <summary>
        /// Borr Info Refund of Overpaid Interest [3619]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SubTaxYearRefundOrOverpaidInterest { get => _subTaxYearRefundOrOverpaidInterest; set => SetField(ref _subTaxYearRefundOrOverpaidInterest, value); }

        /// <summary>
        /// File Contacts Lender Info Tax ID [1196]
        /// </summary>
        public string TaxId { get => _taxId; set => SetField(ref _taxId, value); }

        /// <summary>
        /// IRS Total of MI for Tax Year and Upfront MIP [2846]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBox4 { get => _totalBox4; set => SetField(ref _totalBox4, value); }

        /// <summary>
        /// IRS Total of MI for Tax Year [2845]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalYearlyMi { get => _totalYearlyMi; set => SetField(ref _totalYearlyMi, value); }

        /// <summary>
        /// TPO Connect Status Updated [TPOCONNECTSTATUSUPDATED]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? TPOConnectStatusUpdated { get => _tPOConnectStatusUpdated; set => SetField(ref _tPOConnectStatusUpdated, value); }

        /// <summary>
        /// Real Estate Tax Overide w/GFE Tax [USEGFETAX]
        /// </summary>
        public string UseGfeTax { get => _useGfeTax; set => SetField(ref _useGfeTax, value); }

        /// <summary>
        /// Expenses Calc Mtg Ins Override w/ REGZ MI [USEREGZMI]
        /// </summary>
        public string UseRegZMi { get => _useRegZMi; set => SetField(ref _useRegZMi, value); }

        /// <summary>
        /// Borr Info Zip [4100]
        /// </summary>
        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}