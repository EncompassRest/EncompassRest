using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Application
    /// </summary>
    public sealed partial class Application : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountNumber1;
        /// <summary>
        /// Liabilities Alternate Acct # 1 [1735]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Acct # 1")]
        public string AccountNumber1 { get => _accountNumber1; set => _accountNumber1 = value; }
        private DirtyValue<string> _accountNumber2;
        /// <summary>
        /// Liabilities Alternate Acct # 2 [1737]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Acct # 2")]
        public string AccountNumber2 { get => _accountNumber2; set => _accountNumber2 = value; }
        private DirtyValue<decimal?> _allOtherPaymentsAmount;
        /// <summary>
        /// Underwriting All Other Pymts [1733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting All Other Pymts")]
        public decimal? AllOtherPaymentsAmount { get => _allOtherPaymentsAmount; set => _allOtherPaymentsAmount = value; }
        private DirtyValue<string> _applicationId;
        /// <summary>
        /// Application ApplicationId
        /// </summary>
        public string ApplicationId { get => _applicationId; set => _applicationId = value; }
        private DirtyValue<int?> _applicationIndex;
        /// <summary>
        /// Application ApplicationIndex
        /// </summary>
        public int? ApplicationIndex { get => _applicationIndex; set => _applicationIndex = value; }
        private DirtyValue<DateTime?> _applicationSignedDate;
        /// <summary>
        /// Fannie Mae Signature Date [MORNET.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Signature Date")]
        public DateTime? ApplicationSignedDate { get => _applicationSignedDate; set => _applicationSignedDate = value; }
        private DirtyList<Asset> _assets;
        /// <summary>
        /// Application Assets
        /// </summary>
        public IList<Asset> Assets { get => _assets ?? (_assets = new DirtyList<Asset>()); set => _assets = new DirtyList<Asset>(value); }
        private DirtyValue<decimal?> _assetsAvailableAmount;
        /// <summary>
        /// FHA MCAW Assets Available [1094]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Assets Available")]
        public decimal? AssetsAvailableAmount { get => _assetsAvailableAmount; set => _assetsAvailableAmount = value; }
        private ATRQMBorrower _aTRQMBorrower;
        /// <summary>
        /// Application ATRQMBorrower
        /// </summary>
        public ATRQMBorrower ATRQMBorrower { get => _aTRQMBorrower ?? (_aTRQMBorrower = new ATRQMBorrower()); set => _aTRQMBorrower = value; }
        private DirtyList<ATRQMBorrower> _aTRQMBorrowers;
        /// <summary>
        /// Application ATRQMBorrowers
        /// </summary>
        public IList<ATRQMBorrower> ATRQMBorrowers { get => _aTRQMBorrowers ?? (_aTRQMBorrowers = new DirtyList<ATRQMBorrower>()); set => _aTRQMBorrowers = new DirtyList<ATRQMBorrower>(value); }
        private DirtyList<AUSTrackingLog> _aUSTrackingLogs;
        /// <summary>
        /// Application AUSTrackingLogs
        /// </summary>
        public IList<AUSTrackingLog> AUSTrackingLogs { get => _aUSTrackingLogs ?? (_aUSTrackingLogs = new DirtyList<AUSTrackingLog>()); set => _aUSTrackingLogs = new DirtyList<AUSTrackingLog>(value); }
        private DirtyValue<decimal?> _balanceAvailableFamilySupportGuideline;
        /// <summary>
        /// VA Bal Avail Family Support Guideline [1340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Bal Avail Family Support Guideline")]
        public decimal? BalanceAvailableFamilySupportGuideline { get => _balanceAvailableFamilySupportGuideline; set => _balanceAvailableFamilySupportGuideline = value; }
        private Borrower _borrower;
        /// <summary>
        /// Application Borrower
        /// </summary>
        public Borrower Borrower { get => _borrower ?? (_borrower = new Borrower()); set => _borrower = value; }
        private DirtyValue<decimal?> _bottomRatioPercent;
        /// <summary>
        /// Trans Details Qual Ratio Bottom [742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Bottom")]
        public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => _bottomRatioPercent = value; }
        private DirtyValue<decimal?> _brwCoBrwTotalTaxDeductions;
        /// <summary>
        /// Income Total Deductions Spouse/Borr [1312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Deductions Spouse/Borr")]
        public decimal? BrwCoBrwTotalTaxDeductions { get => _brwCoBrwTotalTaxDeductions; set => _brwCoBrwTotalTaxDeductions = value; }
        private Borrower _coborrower;
        /// <summary>
        /// Application Coborrower
        /// </summary>
        public Borrower Coborrower { get => _coborrower ?? (_coborrower = new Borrower()); set => _coborrower = value; }
        private DirtyValue<string> _creditAliasName1;
        /// <summary>
        /// Liabilities Alternate Name 1 [206]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 1")]
        public string CreditAliasName1 { get => _creditAliasName1; set => _creditAliasName1 = value; }
        private DirtyValue<string> _creditAliasName2;
        /// <summary>
        /// Liabilities Alternate Name 2 [203]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 2")]
        public string CreditAliasName2 { get => _creditAliasName2; set => _creditAliasName2 = value; }
        private DirtyValue<string> _creditorName1;
        /// <summary>
        /// Liabilities Creditor Name 1 [1734]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 1")]
        public string CreditorName1 { get => _creditorName1; set => _creditorName1 = value; }
        private DirtyValue<string> _creditorName2;
        /// <summary>
        /// Liabilities Creditor Name 2 [1736]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 2")]
        public string CreditorName2 { get => _creditorName2; set => _creditorName2 = value; }
        private DirtyValue<string> _creditReportReferenceIdentifier;
        /// <summary>
        /// Trans Details Credit Rpt Ref # [300]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Credit Rpt Ref #")]
        public string CreditReportReferenceIdentifier { get => _creditReportReferenceIdentifier; set => _creditReportReferenceIdentifier = value; }
        private DirtyList<Employment> _employment;
        /// <summary>
        /// Application Employment
        /// </summary>
        public IList<Employment> Employment { get => _employment ?? (_employment = new DirtyList<Employment>()); set => _employment = new DirtyList<Employment>(value); }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Application EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _equifaxAddress;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Addr [DISCLOSURE.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Addr")]
        public string EquifaxAddress { get => _equifaxAddress; set => _equifaxAddress = value; }
        private DirtyValue<string> _equifaxCity;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co City [DISCLOSURE.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co City")]
        public string EquifaxCity { get => _equifaxCity; set => _equifaxCity = value; }
        private DirtyValue<string> _equifaxFax;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Fax [DISCLOSURE.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Fax")]
        public string EquifaxFax { get => _equifaxFax; set => _equifaxFax = value; }
        private DirtyValue<string> _equifaxModel;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Model [DISCLOSURE.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Model")]
        public string EquifaxModel { get => _equifaxModel; set => _equifaxModel = value; }
        private DirtyValue<string> _equifaxName;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Name [DISCLOSURE.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Name")]
        public string EquifaxName { get => _equifaxName; set => _equifaxName = value; }
        private DirtyValue<string> _equifaxPhone;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Phone [DISCLOSURE.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Phone")]
        public string EquifaxPhone { get => _equifaxPhone; set => _equifaxPhone = value; }
        private DirtyValue<string> _equifaxPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Zip [DISCLOSURE.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 3 Co Zip")]
        public string EquifaxPostalCode { get => _equifaxPostalCode; set => _equifaxPostalCode = value; }
        private DirtyValue<string> _equifaxScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores From [DISCLOSURE.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores From")]
        public string EquifaxScoreRangeFrom { get => _equifaxScoreRangeFrom; set => _equifaxScoreRangeFrom = value; }
        private DirtyValue<string> _equifaxScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores To [DISCLOSURE.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores To")]
        public string EquifaxScoreRangeTo { get => _equifaxScoreRangeTo; set => _equifaxScoreRangeTo = value; }
        private DirtyValue<string> _equifaxState;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co State [DISCLOSURE.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Disclosure Cred Bureau 3 Co State")]
        public string EquifaxState { get => _equifaxState; set => _equifaxState = value; }
        private DirtyValue<string> _equifaxWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Website [DISCLOSURE.X640]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Website")]
        public string EquifaxWebsite { get => _equifaxWebsite; set => _equifaxWebsite = value; }
        private DirtyValue<string> _experianAddress;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Addr [DISCLOSURE.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Addr")]
        public string ExperianAddress { get => _experianAddress; set => _experianAddress = value; }
        private DirtyValue<string> _experianCity;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co City [DISCLOSURE.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co City")]
        public string ExperianCity { get => _experianCity; set => _experianCity = value; }
        private DirtyValue<string> _experianFax;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Fax [DISCLOSURE.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Fax")]
        public string ExperianFax { get => _experianFax; set => _experianFax = value; }
        private DirtyValue<string> _experianModel;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Model Used [DISCLOSURE.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Model Used")]
        public string ExperianModel { get => _experianModel; set => _experianModel = value; }
        private DirtyValue<string> _experianName;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Name [DISCLOSURE.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Name")]
        public string ExperianName { get => _experianName; set => _experianName = value; }
        private DirtyValue<string> _experianPhone;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Phone [DISCLOSURE.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Phone")]
        public string ExperianPhone { get => _experianPhone; set => _experianPhone = value; }
        private DirtyValue<string> _experianPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Zip [DISCLOSURE.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 1 Co Zip")]
        public string ExperianPostalCode { get => _experianPostalCode; set => _experianPostalCode = value; }
        private DirtyValue<string> _experianScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores From [DISCLOSURE.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores From")]
        public string ExperianScoreRangeFrom { get => _experianScoreRangeFrom; set => _experianScoreRangeFrom = value; }
        private DirtyValue<string> _experianScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores To [DISCLOSURE.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores To")]
        public string ExperianScoreRangeTo { get => _experianScoreRangeTo; set => _experianScoreRangeTo = value; }
        private DirtyValue<string> _experianState;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co State [DISCLOSURE.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Disclosure Cred Bureau 1 Co State")]
        public string ExperianState { get => _experianState; set => _experianState = value; }
        private DirtyValue<string> _experianWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Website [DISCLOSURE.X638]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Website")]
        public string ExperianWebsite { get => _experianWebsite; set => _experianWebsite = value; }
        private DirtyValue<decimal?> _fhaVaDebtIncomeRatio;
        /// <summary>
        /// VA Debt-to-Income Ratio [1341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Debt-to-Income Ratio")]
        public decimal? FhaVaDebtIncomeRatio { get => _fhaVaDebtIncomeRatio; set => _fhaVaDebtIncomeRatio = value; }
        private DirtyValue<decimal?> _fhaVaFamilySupportAmount;
        /// <summary>
        /// Income Total Residual Income Spouse/Borr [1325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Residual Income Spouse/Borr")]
        public decimal? FhaVaFamilySupportAmount { get => _fhaVaFamilySupportAmount; set => _fhaVaFamilySupportAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
        /// <summary>
        /// Expenses Total Mo Shelter Exp Est [1349]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Shelter Exp Est")]
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; set => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetEffectiveIncomeAmount;
        /// <summary>
        /// Income Total Net Effective Income [1323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Effective Income")]
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => _fhaVaTotalNetEffectiveIncomeAmount; set => _fhaVaTotalNetEffectiveIncomeAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetIncomeAmount;
        /// <summary>
        /// Income Total Net Spouse/Borr [1321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Spouse/Borr")]
        public decimal? FhaVaTotalNetIncomeAmount { get => _fhaVaTotalNetIncomeAmount; set => _fhaVaTotalNetIncomeAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetTakeHomePayAmount;
        /// <summary>
        /// Income Net Take Home Pay Spouse/Borr [1315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Net Take Home Pay Spouse/Borr")]
        public decimal? FhaVaTotalNetTakeHomePayAmount { get => _fhaVaTotalNetTakeHomePayAmount; set => _fhaVaTotalNetTakeHomePayAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalOtherNetIncome;
        /// <summary>
        /// Income Other Net Spouse/Borr [1318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Other Net Spouse/Borr")]
        public decimal? FhaVaTotalOtherNetIncome { get => _fhaVaTotalOtherNetIncome; set => _fhaVaTotalOtherNetIncome = value; }
        private DirtyValue<decimal?> _firstMortgagePrincipalAndInterestAmount;
        /// <summary>
        /// Expenses Present Mtg Pymt [120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Mtg Pymt")]
        public decimal? FirstMortgagePrincipalAndInterestAmount { get => _firstMortgagePrincipalAndInterestAmount; set => _firstMortgagePrincipalAndInterestAmount = value; }
        private DirtyValue<string> _freddieMacCreditReportReferenceIdentifier;
        /// <summary>
        /// Freddie Mac Credit Ref # [CASASRN.X198]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Credit Ref #")]
        public string FreddieMacCreditReportReferenceIdentifier { get => _freddieMacCreditReportReferenceIdentifier; set => _freddieMacCreditReportReferenceIdentifier = value; }
        private DirtyValue<decimal?> _freddieMacOccupantDebtRatio;
        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Debt Ratio [CASASRN.X202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Debt Ratio")]
        public decimal? FreddieMacOccupantDebtRatio { get => _freddieMacOccupantDebtRatio; set => _freddieMacOccupantDebtRatio = value; }
        private DirtyValue<decimal?> _freddieMacOccupantHousingRatio;
        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Housing Ratio [CASASRN.X201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Housing Ratio")]
        public decimal? FreddieMacOccupantHousingRatio { get => _freddieMacOccupantHousingRatio; set => _freddieMacOccupantHousingRatio = value; }
        private DirtyValue<decimal?> _freDebtToHousingGapRatio;
        /// <summary>
        /// Trans Details Qual Ratio Debt-to-Housing [1539]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Debt-to-Housing")]
        public decimal? FreDebtToHousingGapRatio { get => _freDebtToHousingGapRatio; set => _freDebtToHousingGapRatio = value; }
        private DirtyValue<decimal?> _grossBaseIncomeAmount;
        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [273]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? GrossBaseIncomeAmount { get => _grossBaseIncomeAmount; set => _grossBaseIncomeAmount = value; }
        private DirtyValue<decimal?> _grossIncomeForComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor Income [1374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Income")]
        public decimal? GrossIncomeForComortSet { get => _grossIncomeForComortSet; set => _grossIncomeForComortSet = value; }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        /// <summary>
        /// Underwriting Negative Cash Flow [462]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Negative Cash Flow")]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => _grossNegativeCashFlow = value; }
        private DirtyValue<decimal?> _grossOtherIncomeAmount;
        /// <summary>
        /// Income Total Other Income (Borr/Co-Borr) [1168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (Borr/Co-Borr)")]
        public decimal? GrossOtherIncomeAmount { get => _grossOtherIncomeAmount; set => _grossOtherIncomeAmount = value; }
        private DirtyValue<decimal?> _grossPositiveCashFlow;
        /// <summary>
        /// Income Total Positive Cash Flow (Borr/Co-Borr) [1171]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Positive Cash Flow (Borr/Co-Borr)")]
        public decimal? GrossPositiveCashFlow { get => _grossPositiveCashFlow; set => _grossPositiveCashFlow = value; }
        private DirtyValue<string> _hazardInsuranceAmount;
        /// <summary>
        /// Expenses Present Haz Ins [122]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Haz Ins")]
        public string HazardInsuranceAmount { get => _hazardInsuranceAmount; set => _hazardInsuranceAmount = value; }
        private DirtyValue<string> _homeownersAssociationDuesAndCondoFeesAmount;
        /// <summary>
        /// Expenses Present HOA [125]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present HOA")]
        public string HomeownersAssociationDuesAndCondoFeesAmount { get => _homeownersAssociationDuesAndCondoFeesAmount; set => _homeownersAssociationDuesAndCondoFeesAmount = value; }
        private DirtyValue<string> _hudAutoLienHolderName1;
        /// <summary>
        /// HUD Property Improve Auto 1 Lienholder [CAPIAP.X134]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Lienholder")]
        public string HudAutoLienHolderName1 { get => _hudAutoLienHolderName1; set => _hudAutoLienHolderName1 = value; }
        private DirtyValue<string> _hudAutoLienHolderName2;
        /// <summary>
        /// HUD Property Improve Auto 2 Lienholder [CAPIAP.X139]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Lienholder")]
        public string HudAutoLienHolderName2 { get => _hudAutoLienHolderName2; set => _hudAutoLienHolderName2 = value; }
        private DirtyValue<decimal?> _hudAutoLoanAmount1;
        /// <summary>
        /// HUD Property Improve Auto 1 Loan Amt [CAPIAP.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Loan Amt")]
        public decimal? HudAutoLoanAmount1 { get => _hudAutoLoanAmount1; set => _hudAutoLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudAutoLoanAmount2;
        /// <summary>
        /// HUD Property Improve Auto 2 Loan Amt [CAPIAP.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Loan Amt")]
        public decimal? HudAutoLoanAmount2 { get => _hudAutoLoanAmount2; set => _hudAutoLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment1;
        /// <summary>
        /// HUD Property Improve Auto 1 Mo Pymt [CAPIAP.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment1 { get => _hudAutoMonthlyPayment1; set => _hudAutoMonthlyPayment1 = value; }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment2;
        /// <summary>
        /// HUD Property Improve Auto 2 Mo Pymt [CAPIAP.X143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment2 { get => _hudAutoMonthlyPayment2; set => _hudAutoMonthlyPayment2 = value; }
        private DirtyValue<decimal?> _hudAutoPresentBalance1;
        /// <summary>
        /// HUD Property Improve Auto 1 Present Bal [CAPIAP.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Present Bal")]
        public decimal? HudAutoPresentBalance1 { get => _hudAutoPresentBalance1; set => _hudAutoPresentBalance1 = value; }
        private DirtyValue<decimal?> _hudAutoPresentBalance2;
        /// <summary>
        /// HUD Property Improve Auto 2 Present Bal [CAPIAP.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Present Bal")]
        public decimal? HudAutoPresentBalance2 { get => _hudAutoPresentBalance2; set => _hudAutoPresentBalance2 = value; }
        private DirtyValue<string> _hudAutoYearAndMake1;
        /// <summary>
        /// HUD Property Improve Auto 1 Yr/Make [CAPIAP.X135]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Yr/Make")]
        public string HudAutoYearAndMake1 { get => _hudAutoYearAndMake1; set => _hudAutoYearAndMake1 = value; }
        private DirtyValue<string> _hudAutoYearAndMake2;
        /// <summary>
        /// HUD Property Improve Auto 2 Yr/Make [CAPIAP.X140]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Yr/Make")]
        public string HudAutoYearAndMake2 { get => _hudAutoYearAndMake2; set => _hudAutoYearAndMake2 = value; }
        private DirtyValue<decimal?> _hudLoanAmount1;
        /// <summary>
        /// HUD Property Improve Liability 1 Loan Amt [CAPIAP.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 1 Loan Amt")]
        public decimal? HudLoanAmount1 { get => _hudLoanAmount1; set => _hudLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudLoanAmount10;
        /// <summary>
        /// HUD Property Improve Liability 10 Loan Amt [CAPIAP.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 10 Loan Amt")]
        public decimal? HudLoanAmount10 { get => _hudLoanAmount10; set => _hudLoanAmount10 = value; }
        private DirtyValue<decimal?> _hudLoanAmount11;
        /// <summary>
        /// HUD Property Improve Liability 11 Loan Amt [CAPIAP.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 11 Loan Amt")]
        public decimal? HudLoanAmount11 { get => _hudLoanAmount11; set => _hudLoanAmount11 = value; }
        private DirtyValue<decimal?> _hudLoanAmount2;
        /// <summary>
        /// HUD Property Improve Liability 2 Loan Amt [CAPIAP.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 2 Loan Amt")]
        public decimal? HudLoanAmount2 { get => _hudLoanAmount2; set => _hudLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudLoanAmount3;
        /// <summary>
        /// HUD Property Improve Liability 3 Loan Amt [CAPIAP.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 3 Loan Amt")]
        public decimal? HudLoanAmount3 { get => _hudLoanAmount3; set => _hudLoanAmount3 = value; }
        private DirtyValue<decimal?> _hudLoanAmount4;
        /// <summary>
        /// HUD Property Improve Liability 4 Loan Amt [CAPIAP.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 4 Loan Amt")]
        public decimal? HudLoanAmount4 { get => _hudLoanAmount4; set => _hudLoanAmount4 = value; }
        private DirtyValue<decimal?> _hudLoanAmount5;
        /// <summary>
        /// HUD Property Improve Liability 5 Loan Amt [CAPIAP.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 5 Loan Amt")]
        public decimal? HudLoanAmount5 { get => _hudLoanAmount5; set => _hudLoanAmount5 = value; }
        private DirtyValue<decimal?> _hudLoanAmount6;
        /// <summary>
        /// HUD Property Improve Liability 6 Loan Amt [CAPIAP.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 6 Loan Amt")]
        public decimal? HudLoanAmount6 { get => _hudLoanAmount6; set => _hudLoanAmount6 = value; }
        private DirtyValue<decimal?> _hudLoanAmount7;
        /// <summary>
        /// HUD Property Improve Liability 7 Loan Amt [CAPIAP.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 7 Loan Amt")]
        public decimal? HudLoanAmount7 { get => _hudLoanAmount7; set => _hudLoanAmount7 = value; }
        private DirtyValue<decimal?> _hudLoanAmount8;
        /// <summary>
        /// HUD Property Improve Liability 8 Loan Amt [CAPIAP.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 8 Loan Amt")]
        public decimal? HudLoanAmount8 { get => _hudLoanAmount8; set => _hudLoanAmount8 = value; }
        private DirtyValue<decimal?> _hudLoanAmount9;
        /// <summary>
        /// HUD Property Improve Liability 9 Loan Amt [CAPIAP.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 9 Loan Amt")]
        public decimal? HudLoanAmount9 { get => _hudLoanAmount9; set => _hudLoanAmount9 = value; }
        private DirtyValue<bool?> _hudRealEstateFhaInsured1;
        /// <summary>
        /// HUD Property Improve RE 1 FHA Insured [CAPIAP.X28]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured1 { get => _hudRealEstateFhaInsured1; set => _hudRealEstateFhaInsured1 = value; }
        private DirtyValue<bool?> _hudRealEstateFhaInsured2;
        /// <summary>
        /// HUD Property Improve RE 2 FHA Insured [CAPIAP.X30]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured2 { get => _hudRealEstateFhaInsured2; set => _hudRealEstateFhaInsured2 = value; }
        private DirtyValue<string> _hudRealEstateLienHolder1;
        /// <summary>
        /// HUD Property Improve RE 1 Lienholder [CAPIAP.X148]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 Lienholder")]
        public string HudRealEstateLienHolder1 { get => _hudRealEstateLienHolder1; set => _hudRealEstateLienHolder1 = value; }
        private DirtyValue<string> _hudRealEstateLienHolder2;
        /// <summary>
        /// HUD Property Improve RE 2 Lienholder [CAPIAP.X149]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 Lienholder")]
        public string HudRealEstateLienHolder2 { get => _hudRealEstateLienHolder2; set => _hudRealEstateLienHolder2 = value; }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount1;
        /// <summary>
        /// HUD Property Improve RE 1 Loan Amt [CAPIAP.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Loan Amt")]
        public decimal? HudRealEstateLoanAmount1 { get => _hudRealEstateLoanAmount1; set => _hudRealEstateLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount2;
        /// <summary>
        /// HUD Property Improve RE 2 Loan Amt [CAPIAP.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Loan Amt")]
        public decimal? HudRealEstateLoanAmount2 { get => _hudRealEstateLoanAmount2; set => _hudRealEstateLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment1;
        /// <summary>
        /// HUD Property Improve RE 1 Mo Pymt [CAPIAP.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment1 { get => _hudRealEstateMonthlyPayment1; set => _hudRealEstateMonthlyPayment1 = value; }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment2;
        /// <summary>
        /// HUD Property Improve RE 2 Mo Pymt [CAPIAP.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment2 { get => _hudRealEstateMonthlyPayment2; set => _hudRealEstateMonthlyPayment2 = value; }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance1;
        /// <summary>
        /// HUD Property Improve RE 1 Present Bal [CAPIAP.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Present Bal")]
        public decimal? HudRealEstatePresentBalance1 { get => _hudRealEstatePresentBalance1; set => _hudRealEstatePresentBalance1 = value; }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance2;
        /// <summary>
        /// HUD Property Improve RE 2 Present Bal [CAPIAP.X152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Present Bal")]
        public decimal? HudRealEstatePresentBalance2 { get => _hudRealEstatePresentBalance2; set => _hudRealEstatePresentBalance2 = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Application Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyList<Income> _income;
        /// <summary>
        /// Application Income
        /// </summary>
        public IList<Income> Income { get => _income ?? (_income = new DirtyList<Income>()); set => _income = new DirtyList<Income>(value); }
        private DirtyValue<bool?> _incomeOfBorrowersSpouseUsedIndicator;
        /// <summary>
        /// Trans Details Income of Spouse will not be used [35]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Spouse will not be used", OptionsJson = "{\"true\":\"The income/assets of the Borrower's spouse will not be used..\"}")]
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get => _incomeOfBorrowersSpouseUsedIndicator; set => _incomeOfBorrowersSpouseUsedIndicator = value; }
        private DirtyValue<bool?> _incomeOtherThanBorrowerUsedIndicator;
        /// <summary>
        /// Trans Details Income of Other will be used [307]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Other will be used", OptionsJson = "{\"true\":\"The income/assets of a person other than Borrower will be used...\"}")]
        public bool? IncomeOtherThanBorrowerUsedIndicator { get => _incomeOtherThanBorrowerUsedIndicator; set => _incomeOtherThanBorrowerUsedIndicator = value; }
        private DirtyValue<bool?> _jointAssetLiabilityReportingIndicator;
        /// <summary>
        /// Assets/Liabilities Completed Jointly/Not Jointly [181]
        /// </summary>
        [LoanFieldProperty(Description = "Assets/Liabilities Completed Jointly/Not Jointly")]
        public bool? JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => _jointAssetLiabilityReportingIndicator = value; }
        private DirtyValue<string> _lastModified;
        /// <summary>
        /// Application LastModified
        /// </summary>
        public string LastModified { get => _lastModified; set => _lastModified = value; }
        private DirtyList<Liability> _liabilities;
        /// <summary>
        /// Application Liabilities
        /// </summary>
        public IList<Liability> Liabilities { get => _liabilities ?? (_liabilities = new DirtyList<Liability>()); set => _liabilities = new DirtyList<Liability>(value); }
        private DirtyValue<decimal?> _liquidAssetsComortSet;
        /// <summary>
        /// Assets Co-Borr Liquid Assets [267]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Co-Borr Liquid Assets")]
        public decimal? LiquidAssetsComortSet { get => _liquidAssetsComortSet; set => _liquidAssetsComortSet = value; }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// Application LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<string> _loanOfficerId;
        /// <summary>
        /// Application LoanOfficerId
        /// </summary>
        public string LoanOfficerId { get => _loanOfficerId; set => _loanOfficerId = value; }
        private DirtyValue<string> _loanOfficerName;
        /// <summary>
        /// Application LoanOfficerName
        /// </summary>
        public string LoanOfficerName { get => _loanOfficerName; set => _loanOfficerName = value; }
        private DirtyValue<decimal?> _mcawBorrowerOtherMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Borr Other Mo Income [936]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Borr Other Mo Income")]
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => _mcawBorrowerOtherMonthlyIncomeAmount; set => _mcawBorrowerOtherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawCoborrowerOtherMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Co-Borr Other Mo Income [938]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Co-Borr Other Mo Income")]
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => _mcawCoborrowerOtherMonthlyIncomeAmount; set => _mcawCoborrowerOtherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawGrossMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Total Gross Mo Income [1761]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Gross Mo Income")]
        public decimal? McawGrossMonthlyIncomeAmount { get => _mcawGrossMonthlyIncomeAmount; set => _mcawGrossMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome1Amount;
        /// <summary>
        /// FHA MCAW Mtg Pymt-to-Income Ratio [MCAWPUR.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Mtg Pymt-to-Income Ratio")]
        public decimal? McawMortgagePaymentToIncome1Amount { get => _mcawMortgagePaymentToIncome1Amount; set => _mcawMortgagePaymentToIncome1Amount = value; }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome2Amount;
        /// <summary>
        /// FHA MCAW Ratio Mtg Pymt-to-Income [GMCAW.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Mtg Pymt-to-Income")]
        public decimal? McawMortgagePaymentToIncome2Amount { get => _mcawMortgagePaymentToIncome2Amount; set => _mcawMortgagePaymentToIncome2Amount = value; }
        private DirtyValue<decimal?> _mcawOtherAmount;
        /// <summary>
        /// FHA MCAW Liabilities Other [1161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Other")]
        public decimal? McawOtherAmount { get => _mcawOtherAmount; set => _mcawOtherAmount = value; }
        private DirtyValue<decimal?> _mcawOtherDebtsAndObligationsAmount;
        /// <summary>
        /// FHA MCAW Liabilities Unpaid Bal [1163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Unpaid Bal")]
        public decimal? McawOtherDebtsAndObligationsAmount { get => _mcawOtherDebtsAndObligationsAmount; set => _mcawOtherDebtsAndObligationsAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForPurchaseAmount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt [MCAWPUR.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get => _mcawTotalFixedPaymentForPurchaseAmount; set => _mcawTotalFixedPaymentForPurchaseAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForRefinanceAmount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt [GMCAW.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get => _mcawTotalFixedPaymentForRefinanceAmount; set => _mcawTotalFixedPaymentForRefinanceAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome1Amount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt-to-Income Ratio [MCAWPUR.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt-to-Income Ratio")]
        public decimal? McawTotalFixedPaymentToIncome1Amount { get => _mcawTotalFixedPaymentToIncome1Amount; set => _mcawTotalFixedPaymentToIncome1Amount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome2Amount;
        /// <summary>
        /// FHA MCAW Ratio Total Fixed Pymt-to-Income [GMCAW.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Total Fixed Pymt-to-Income")]
        public decimal? McawTotalFixedPaymentToIncome2Amount { get => _mcawTotalFixedPaymentToIncome2Amount; set => _mcawTotalFixedPaymentToIncome2Amount = value; }
        private DirtyValue<decimal?> _mcawTotalMonthlyPaymentsAmount;
        /// <summary>
        /// FHA MCAW Liabilities Total Mo Pymt [1150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Liabilities Total Mo Pymt")]
        public decimal? McawTotalMonthlyPaymentsAmount { get => _mcawTotalMonthlyPaymentsAmount; set => _mcawTotalMonthlyPaymentsAmount = value; }
        private DirtyValue<decimal?> _mcawTotalMortgagePaymentAmount;
        /// <summary>
        /// FHA MCAW Total Mtg Pymt [739]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Mtg Pymt")]
        public decimal? McawTotalMortgagePaymentAmount { get => _mcawTotalMortgagePaymentAmount; set => _mcawTotalMortgagePaymentAmount = value; }
        private DirtyValue<decimal?> _monthlyExpenseComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor [1384]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor")]
        public decimal? MonthlyExpenseComortSet { get => _monthlyExpenseComortSet; set => _monthlyExpenseComortSet = value; }
        private DirtyValue<decimal?> _monthlyHousingExpenseAmount;
        /// <summary>
        /// Expenses Total Housing Expense [1809]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Housing Expense")]
        public decimal? MonthlyHousingExpenseAmount { get => _monthlyHousingExpenseAmount; set => _monthlyHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _monthlyInstallmentExpenseAmount;
        /// <summary>
        /// Expenses Total Mo Installment Exp [382]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Installment Exp")]
        public decimal? MonthlyInstallmentExpenseAmount { get => _monthlyInstallmentExpenseAmount; set => _monthlyInstallmentExpenseAmount = value; }
        private DirtyValue<decimal?> _monthlyNegativeRealEstateAmount;
        /// <summary>
        /// Expenses Negative Real Estate [LOANSUB.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Negative Real Estate")]
        public decimal? MonthlyNegativeRealEstateAmount { get => _monthlyNegativeRealEstateAmount; set => _monthlyNegativeRealEstateAmount = value; }
        private DirtyValue<decimal?> _monthlySecondHomeAmount;
        /// <summary>
        /// Expenses 2nd/Vacation Home [1476]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses 2nd/Vacation Home")]
        public decimal? MonthlySecondHomeAmount { get => _monthlySecondHomeAmount; set => _monthlySecondHomeAmount = value; }
        private DirtyValue<string> _mortgageInsuranceAmount;
        /// <summary>
        /// Expenses Present MTG Ins [124]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present MTG Ins")]
        public string MortgageInsuranceAmount { get => _mortgageInsuranceAmount; set => _mortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _netWorthAmount;
        /// <summary>
        /// Liabilities Net Worth [734]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Net Worth")]
        public decimal? NetWorthAmount { get => _netWorthAmount; set => _netWorthAmount = value; }
        private DirtyValue<decimal?> _otherHousingExpenseAmount;
        /// <summary>
        /// Expenses Present Other Housing [126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Housing")]
        public decimal? OtherHousingExpenseAmount { get => _otherHousingExpenseAmount; set => _otherHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _otherItemsDeducted;
        /// <summary>
        /// Income Deductions Other Items Deducted [198]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Deductions Other Items Deducted")]
        public decimal? OtherItemsDeducted { get => _otherItemsDeducted; set => _otherItemsDeducted = value; }
        private DirtyValue<decimal?> _otherMortgagePrincipalAndInterestAmount;
        /// <summary>
        /// Expenses Present Other Pymt [121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Pymt")]
        public decimal? OtherMortgagePrincipalAndInterestAmount { get => _otherMortgagePrincipalAndInterestAmount; set => _otherMortgagePrincipalAndInterestAmount = value; }
        private DirtyValue<StringEnumValue<PastCreditRecord>> _pastCreditRecord;
        /// <summary>
        /// VA Past Credit Record [1326]
        /// </summary>
        [LoanFieldProperty(Description = "VA Past Credit Record")]
        public StringEnumValue<PastCreditRecord> PastCreditRecord { get => _pastCreditRecord; set => _pastCreditRecord = value; }
        private DirtyValue<decimal?> _presentHousingExpComortSet;
        /// <summary>
        /// Expenses Co-Borr Present Mo Hous Exp [268]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Co-Borr Present Mo Hous Exp")]
        public decimal? PresentHousingExpComortSet { get => _presentHousingExpComortSet; set => _presentHousingExpComortSet = value; }
        private DirtyValue<decimal?> _primaryResidenceComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor Primary Exp [1379]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Primary Exp")]
        public decimal? PrimaryResidenceComortSet { get => _primaryResidenceComortSet; set => _primaryResidenceComortSet = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        /// <summary>
        /// Subject Property Occupancy Status [1811]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Occupancy Status")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<string> _proposedDuesAmount;
        /// <summary>
        /// Underwriting HOA Fees [1729]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting HOA Fees")]
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => _proposedDuesAmount = value; }
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        /// <summary>
        /// Underwriting First Mtg P&amp;I [1724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting First Mtg P&I")]
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => _proposedFirstMortgageAmount = value; }
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        /// <summary>
        /// Underwriting Rent [1723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Rent")]
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => _proposedGroundRentAmount = value; }
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        /// <summary>
        /// Underwriting Hazard Ins [1726]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Hazard Ins")]
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => _proposedHazardInsuranceAmount = value; }
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        /// <summary>
        /// Insurance Mtg Ins Mo Pymt [1728]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Mtg Ins Mo Pymt")]
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => _proposedMortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedOtherAmount;
        /// <summary>
        /// Underwriting Other Fees [1730]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Other Fees")]
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => _proposedOtherAmount = value; }
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        /// <summary>
        /// Underwriting Second Mtg P&amp;I [1725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Second Mtg P&I")]
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => _proposedOtherMortgagesAmount = value; }
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        /// <summary>
        /// Underwriting Taxes [1727]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Taxes")]
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => _proposedRealEstateTaxesAmount = value; }
        private DirtyValue<string> _realEstateTaxAmount;
        /// <summary>
        /// Expenses Present Taxes [123]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Taxes")]
        public string RealEstateTaxAmount { get => _realEstateTaxAmount; set => _realEstateTaxAmount = value; }
        private DirtyValue<decimal?> _rentAmount;
        /// <summary>
        /// Expenses Present Rent [119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Rent")]
        public decimal? RentAmount { get => _rentAmount; set => _rentAmount = value; }
        private DirtyList<ReoProperty> _reoProperties;
        /// <summary>
        /// Application ReoProperties
        /// </summary>
        public IList<ReoProperty> ReoProperties { get => _reoProperties ?? (_reoProperties = new DirtyList<ReoProperty>()); set => _reoProperties = new DirtyList<ReoProperty>(value); }
        private DirtyValue<decimal?> _reoTotalGrossRentalIncomeAmount;
        /// <summary>
        /// Income Total Gross Rent Income [921]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Gross Rent Income")]
        public decimal? ReoTotalGrossRentalIncomeAmount { get => _reoTotalGrossRentalIncomeAmount; set => _reoTotalGrossRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _reoTotalMaintenanceAmount;
        /// <summary>
        /// Income Total Ins/Tax/Exp Income [923]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Ins/Tax/Exp Income")]
        public decimal? ReoTotalMaintenanceAmount { get => _reoTotalMaintenanceAmount; set => _reoTotalMaintenanceAmount = value; }
        private DirtyValue<decimal?> _reoTotalMarketValueAmount;
        /// <summary>
        /// Assets Real Estate Owned [919]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Real Estate Owned")]
        public decimal? ReoTotalMarketValueAmount { get => _reoTotalMarketValueAmount; set => _reoTotalMarketValueAmount = value; }
        private DirtyValue<decimal?> _reoTotalMortgagePaymentsAmount;
        /// <summary>
        /// Income Total Mortgage Pymts Income [922]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mortgage Pymts Income")]
        public decimal? ReoTotalMortgagePaymentsAmount { get => _reoTotalMortgagePaymentsAmount; set => _reoTotalMortgagePaymentsAmount = value; }
        private DirtyValue<decimal?> _reoTotalMortgagesAndLiensAmount;
        /// <summary>
        /// Income Total Amt of Mortgages Income [920]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Amt of Mortgages Income")]
        public decimal? ReoTotalMortgagesAndLiensAmount { get => _reoTotalMortgagesAndLiensAmount; set => _reoTotalMortgagesAndLiensAmount = value; }
        private DirtyValue<int?> _reoTotalNetRentalIncomeAmount;
        /// <summary>
        /// Income Total Net Rental Income [924]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Income Total Net Rental Income")]
        public int? ReoTotalNetRentalIncomeAmount { get => _reoTotalNetRentalIncomeAmount; set => _reoTotalNetRentalIncomeAmount = value; }
        private DirtyList<Residence> _residences;
        /// <summary>
        /// Application Residences
        /// </summary>
        public IList<Residence> Residences { get => _residences ?? (_residences = new DirtyList<Residence>()); set => _residences = new DirtyList<Residence>(value); }
        private DirtyValue<string> _respa6;
        /// <summary>
        /// Application Respa6
        /// </summary>
        public string Respa6 { get => _respa6; set => _respa6 = value; }
        private DirtyList<SelfEmployedIncome> _selfEmployedIncomes;
        /// <summary>
        /// Application SelfEmployedIncomes
        /// </summary>
        public IList<SelfEmployedIncome> SelfEmployedIncomes { get => _selfEmployedIncomes ?? (_selfEmployedIncomes = new DirtyList<SelfEmployedIncome>()); set => _selfEmployedIncomes = new DirtyList<SelfEmployedIncome>(value); }
        private DirtyValue<string> _sofDBorrowerAddress;
        /// <summary>
        /// Denial Discl Info - Borrower Address [DENIAL.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address")]
        public string SofDBorrowerAddress { get => _sofDBorrowerAddress; set => _sofDBorrowerAddress = value; }
        private DirtyValue<string> _sofDBorrowerAddressCity;
        /// <summary>
        /// Denial Discl Info - Borrower Address - City [DENIAL.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address - City")]
        public string SofDBorrowerAddressCity { get => _sofDBorrowerAddressCity; set => _sofDBorrowerAddressCity = value; }
        private DirtyValue<string> _sofDBorrowerAddressState;
        /// <summary>
        /// Denial Discl Info - Borrower Address - State [DENIAL.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Denial Discl Info - Borrower Address - State")]
        public string SofDBorrowerAddressState { get => _sofDBorrowerAddressState; set => _sofDBorrowerAddressState = value; }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDBorrowerAddressType;
        /// <summary>
        /// Denial Discl Info - Borrower Address Type [DENIAL.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => _sofDBorrowerAddressType; set => _sofDBorrowerAddressType = value; }
        private DirtyValue<string> _sofDBorrowerAddressZipcode;
        /// <summary>
        /// Denial Discl Info - Borrower Address - Zipcode [DENIAL.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Borrower Address - Zipcode")]
        public string SofDBorrowerAddressZipcode { get => _sofDBorrowerAddressZipcode; set => _sofDBorrowerAddressZipcode = value; }
        private DirtyValue<string> _sofDCoBorrowerAddress;
        /// <summary>
        /// Denial Discl Info - Coborrower Address [DENIAL.X87]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address")]
        public string SofDCoBorrowerAddress { get => _sofDCoBorrowerAddress; set => _sofDCoBorrowerAddress = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressCity;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - City [DENIAL.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address - City")]
        public string SofDCoBorrowerAddressCity { get => _sofDCoBorrowerAddressCity; set => _sofDCoBorrowerAddressCity = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressState;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - State [DENIAL.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Denial Discl Info - Coborrower Address - State")]
        public string SofDCoBorrowerAddressState { get => _sofDCoBorrowerAddressState; set => _sofDCoBorrowerAddressState = value; }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDCoBorrowerAddressType;
        /// <summary>
        /// Denial Discl Info - Coborrower Address Type [DENIAL.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => _sofDCoBorrowerAddressType; set => _sofDCoBorrowerAddressType = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressZipcode;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - Zipcode [DENIAL.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Coborrower Address - Zipcode")]
        public string SofDCoBorrowerAddressZipcode { get => _sofDCoBorrowerAddressZipcode; set => _sofDCoBorrowerAddressZipcode = value; }
        private DirtyValue<bool?> _spouseIncomeConsider;
        /// <summary>
        /// VA Veteran Income Consider Spouse Income [1006]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Income Consider Spouse Income")]
        public bool? SpouseIncomeConsider { get => _spouseIncomeConsider; set => _spouseIncomeConsider = value; }
        private DirtyList<Tax4506> _tax4506s;
        /// <summary>
        /// Application Tax4506s
        /// </summary>
        public IList<Tax4506> Tax4506s { get => _tax4506s ?? (_tax4506s = new DirtyList<Tax4506>()); set => _tax4506s = new DirtyList<Tax4506>(value); }
        private DirtyValue<decimal?> _topRatioPercent;
        /// <summary>
        /// Trans Details Qual Ratio Top [740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Trans Details Qual Ratio Top")]
        public decimal? TopRatioPercent { get => _topRatioPercent; set => _topRatioPercent = value; }
        private DirtyValue<decimal?> _totalAssetsAmount;
        /// <summary>
        /// Assets Total Assets [732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Assets")]
        public decimal? TotalAssetsAmount { get => _totalAssetsAmount; set => _totalAssetsAmount = value; }
        private DirtyValue<decimal?> _totalBaseIncomeAmount;
        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [901]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? TotalBaseIncomeAmount { get => _totalBaseIncomeAmount; set => _totalBaseIncomeAmount = value; }
        private DirtyValue<decimal?> _totalBonusAmount;
        /// <summary>
        /// Income Total Bonuses (Borr/Co-Borr) [903]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Bonuses (Borr/Co-Borr)")]
        public decimal? TotalBonusAmount { get => _totalBonusAmount; set => _totalBonusAmount = value; }
        private DirtyValue<decimal?> _totalCommissionsAmount;
        /// <summary>
        /// Income Total Commissions (Borr/Co-Borr) [904]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Commissions (Borr/Co-Borr)")]
        public decimal? TotalCommissionsAmount { get => _totalCommissionsAmount; set => _totalCommissionsAmount = value; }
        private DirtyValue<decimal?> _totalDeposit;
        /// <summary>
        /// Assets Total Bank Deposits [979]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Bank Deposits")]
        public decimal? TotalDeposit { get => _totalDeposit; set => _totalDeposit = value; }
        private DirtyValue<decimal?> _totalDividendsInterestAmount;
        /// <summary>
        /// Income Total Div/Int (Borr/Co-Borr) [905]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Div/Int (Borr/Co-Borr)")]
        public decimal? TotalDividendsInterestAmount { get => _totalDividendsInterestAmount; set => _totalDividendsInterestAmount = value; }
        private DirtyValue<decimal?> _totalEmploymentAmount;
        /// <summary>
        /// Income Total Mo Income Spouse/Borr [1810]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income Spouse/Borr")]
        public decimal? TotalEmploymentAmount { get => _totalEmploymentAmount; set => _totalEmploymentAmount = value; }
        private DirtyValue<decimal?> _totalFixedPaymentAmount;
        /// <summary>
        /// Expenses Total Mo Expense [1187]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Expense")]
        public decimal? TotalFixedPaymentAmount { get => _totalFixedPaymentAmount; set => _totalFixedPaymentAmount = value; }
        private DirtyValue<decimal?> _totalGrossMonthlyIncomeAmount;
        /// <summary>
        /// Income Total Mo Income (Borr/Co-Borr) [1389]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Income (Borr/Co-Borr)")]
        public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => _totalGrossMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _totalIncomeAmount;
        /// <summary>
        /// Income Total Mo Income [736]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income")]
        public decimal? TotalIncomeAmount { get => _totalIncomeAmount; set => _totalIncomeAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyPaymentAmount;
        /// <summary>
        /// Liabilities Total Liability Pymt [350]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Total Liability Pymt")]
        public decimal? TotalMonthlyPaymentAmount { get => _totalMonthlyPaymentAmount; set => _totalMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _totalMortgagesBalanceAmount;
        /// <summary>
        /// Trans Details Total Mtg Bal [941]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Bal")]
        public decimal? TotalMortgagesBalanceAmount { get => _totalMortgagesBalanceAmount; set => _totalMortgagesBalanceAmount = value; }
        private DirtyValue<decimal?> _totalMortgagesMonthlyPaymentAmount;
        /// <summary>
        /// Trans Details Total Mtg Mo Pymt [909]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Mo Pymt")]
        public decimal? TotalMortgagesMonthlyPaymentAmount { get => _totalMortgagesMonthlyPaymentAmount; set => _totalMortgagesMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _totalNetRentalIncomeAmount;
        /// <summary>
        /// Income Total Net Rent Income (Borr/Co-Borr) [906]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Rent Income (Borr/Co-Borr)")]
        public decimal? TotalNetRentalIncomeAmount { get => _totalNetRentalIncomeAmount; set => _totalNetRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _totalOther1Amount;
        /// <summary>
        /// Income Total Other 1 (Borr/Co-Borr) [907]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 1 (Borr/Co-Borr)")]
        public decimal? TotalOther1Amount { get => _totalOther1Amount; set => _totalOther1Amount = value; }
        private DirtyValue<decimal?> _totalOther2Amount;
        /// <summary>
        /// Income Total Other 2 (Borr/Co-Borr) [908]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 2 (Borr/Co-Borr)")]
        public decimal? TotalOther2Amount { get => _totalOther2Amount; set => _totalOther2Amount = value; }
        private DirtyValue<decimal?> _totalOvertimeAmount;
        /// <summary>
        /// Income Total Overtime (Borr/Co-Borr) [902]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Overtime (Borr/Co-Borr)")]
        public decimal? TotalOvertimeAmount { get => _totalOvertimeAmount; set => _totalOvertimeAmount = value; }
        private DirtyValue<decimal?> _totalPaymentsAmount;
        /// <summary>
        /// Trans Details Total Proposed Mo Pymt [1742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Proposed Mo Pymt")]
        public decimal? TotalPaymentsAmount { get => _totalPaymentsAmount; set => _totalPaymentsAmount = value; }
        private DirtyValue<decimal?> _totalPrimaryHousingExpenseAmount;
        /// <summary>
        /// Expenses Total Primary Expenses [1731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Primary Expenses")]
        public decimal? TotalPrimaryHousingExpenseAmount { get => _totalPrimaryHousingExpenseAmount; set => _totalPrimaryHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _totalReoMarketValueAmount;
        /// <summary>
        /// Application TotalReoMarketValueAmount
        /// </summary>
        public decimal? TotalReoMarketValueAmount { get => _totalReoMarketValueAmount; set => _totalReoMarketValueAmount = value; }
        private DirtyValue<decimal?> _totalUserDefinedIncome;
        /// <summary>
        /// Income Total Other Income (User Defined) [1817]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (User Defined)")]
        public decimal? TotalUserDefinedIncome { get => _totalUserDefinedIncome; set => _totalUserDefinedIncome = value; }
        private DirtyList<TQLReportInformation> _tQLReports;
        /// <summary>
        /// Application TQLReports
        /// </summary>
        public IList<TQLReportInformation> TQLReports { get => _tQLReports ?? (_tQLReports = new DirtyList<TQLReportInformation>()); set => _tQLReports = new DirtyList<TQLReportInformation>(value); }
        private DirtyValue<string> _transUnionAddress;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Addr [DISCLOSURE.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Addr")]
        public string TransUnionAddress { get => _transUnionAddress; set => _transUnionAddress = value; }
        private DirtyValue<string> _transUnionCity;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co City [DISCLOSURE.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co City")]
        public string TransUnionCity { get => _transUnionCity; set => _transUnionCity = value; }
        private DirtyValue<string> _transUnionFax;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Fax [DISCLOSURE.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Fax")]
        public string TransUnionFax { get => _transUnionFax; set => _transUnionFax = value; }
        private DirtyValue<string> _transUnionModel;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Model [DISCLOSURE.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Model")]
        public string TransUnionModel { get => _transUnionModel; set => _transUnionModel = value; }
        private DirtyValue<string> _transUnionName;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Name [DISCLOSURE.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Name")]
        public string TransUnionName { get => _transUnionName; set => _transUnionName = value; }
        private DirtyValue<string> _transUnionPhone;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Phone [DISCLOSURE.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Phone")]
        public string TransUnionPhone { get => _transUnionPhone; set => _transUnionPhone = value; }
        private DirtyValue<string> _transUnionPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Zip [DISCLOSURE.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 2 Co Zip")]
        public string TransUnionPostalCode { get => _transUnionPostalCode; set => _transUnionPostalCode = value; }
        private DirtyValue<string> _transUnionScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores From [DISCLOSURE.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores From")]
        public string TransUnionScoreRangeFrom { get => _transUnionScoreRangeFrom; set => _transUnionScoreRangeFrom = value; }
        private DirtyValue<string> _transUnionScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores To [DISCLOSURE.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores To")]
        public string TransUnionScoreRangeTo { get => _transUnionScoreRangeTo; set => _transUnionScoreRangeTo = value; }
        private DirtyValue<string> _transUnionState;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co State [DISCLOSURE.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Disclosure Cred Bureau 2 Co State")]
        public string TransUnionState { get => _transUnionState; set => _transUnionState = value; }
        private DirtyValue<string> _transUnionWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Website [DISCLOSURE.X639]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Website")]
        public string TransUnionWebsite { get => _transUnionWebsite; set => _transUnionWebsite = value; }
        private DirtyValue<decimal?> _userDefinedIncome;
        /// <summary>
        /// Application UserDefinedIncome
        /// </summary>
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => _userDefinedIncome = value; }
        private DirtyValue<string> _userDefinedIncomeDescription;
        /// <summary>
        /// Income Borr/Co-Borr Other Income 2 Descr [1818]
        /// </summary>
        [LoanFieldProperty(Description = "Income Borr/Co-Borr Other Income 2 Descr")]
        public string UserDefinedIncomeDescription { get => _userDefinedIncomeDescription; set => _userDefinedIncomeDescription = value; }
        private DirtyValue<StringEnumValue<YOrN>> _vACreditStandards;
        /// <summary>
        /// VA Meets VA Credit Standards [1327]
        /// </summary>
        [LoanFieldProperty(Description = "VA Meets VA Credit Standards")]
        public StringEnumValue<YOrN> VACreditStandards { get => _vACreditStandards; set => _vACreditStandards = value; }
        private DirtyValue<decimal?> _vaSummarySpouseIncomeAmount;
        /// <summary>
        /// VA Veteran Income Spouse Income Amt [1008]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Veteran Income Spouse Income Amt")]
        public decimal? VaSummarySpouseIncomeAmount { get => _vaSummarySpouseIncomeAmount; set => _vaSummarySpouseIncomeAmount = value; }
        private DirtyValue<decimal?> _vaSummaryTotalMonthlyGrossIncomeAmount;
        /// <summary>
        /// Income Total Mo Gross Income [993]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Gross Income")]
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => _vaSummaryTotalMonthlyGrossIncomeAmount; set => _vaSummaryTotalMonthlyGrossIncomeAmount = value; }
        internal override bool DirtyInternal
        {
            get => _accountNumber1.Dirty
                || _accountNumber2.Dirty
                || _allOtherPaymentsAmount.Dirty
                || _applicationId.Dirty
                || _applicationIndex.Dirty
                || _applicationSignedDate.Dirty
                || _assetsAvailableAmount.Dirty
                || _balanceAvailableFamilySupportGuideline.Dirty
                || _bottomRatioPercent.Dirty
                || _brwCoBrwTotalTaxDeductions.Dirty
                || _creditAliasName1.Dirty
                || _creditAliasName2.Dirty
                || _creditorName1.Dirty
                || _creditorName2.Dirty
                || _creditReportReferenceIdentifier.Dirty
                || _entityDeleted.Dirty
                || _equifaxAddress.Dirty
                || _equifaxCity.Dirty
                || _equifaxFax.Dirty
                || _equifaxModel.Dirty
                || _equifaxName.Dirty
                || _equifaxPhone.Dirty
                || _equifaxPostalCode.Dirty
                || _equifaxScoreRangeFrom.Dirty
                || _equifaxScoreRangeTo.Dirty
                || _equifaxState.Dirty
                || _equifaxWebsite.Dirty
                || _experianAddress.Dirty
                || _experianCity.Dirty
                || _experianFax.Dirty
                || _experianModel.Dirty
                || _experianName.Dirty
                || _experianPhone.Dirty
                || _experianPostalCode.Dirty
                || _experianScoreRangeFrom.Dirty
                || _experianScoreRangeTo.Dirty
                || _experianState.Dirty
                || _experianWebsite.Dirty
                || _fhaVaDebtIncomeRatio.Dirty
                || _fhaVaFamilySupportAmount.Dirty
                || _fhaVaTotalEstimatedMonthlyShelterExpenseAmount.Dirty
                || _fhaVaTotalNetEffectiveIncomeAmount.Dirty
                || _fhaVaTotalNetIncomeAmount.Dirty
                || _fhaVaTotalNetTakeHomePayAmount.Dirty
                || _fhaVaTotalOtherNetIncome.Dirty
                || _firstMortgagePrincipalAndInterestAmount.Dirty
                || _freddieMacCreditReportReferenceIdentifier.Dirty
                || _freddieMacOccupantDebtRatio.Dirty
                || _freddieMacOccupantHousingRatio.Dirty
                || _freDebtToHousingGapRatio.Dirty
                || _grossBaseIncomeAmount.Dirty
                || _grossIncomeForComortSet.Dirty
                || _grossNegativeCashFlow.Dirty
                || _grossOtherIncomeAmount.Dirty
                || _grossPositiveCashFlow.Dirty
                || _hazardInsuranceAmount.Dirty
                || _homeownersAssociationDuesAndCondoFeesAmount.Dirty
                || _hudAutoLienHolderName1.Dirty
                || _hudAutoLienHolderName2.Dirty
                || _hudAutoLoanAmount1.Dirty
                || _hudAutoLoanAmount2.Dirty
                || _hudAutoMonthlyPayment1.Dirty
                || _hudAutoMonthlyPayment2.Dirty
                || _hudAutoPresentBalance1.Dirty
                || _hudAutoPresentBalance2.Dirty
                || _hudAutoYearAndMake1.Dirty
                || _hudAutoYearAndMake2.Dirty
                || _hudLoanAmount1.Dirty
                || _hudLoanAmount10.Dirty
                || _hudLoanAmount11.Dirty
                || _hudLoanAmount2.Dirty
                || _hudLoanAmount3.Dirty
                || _hudLoanAmount4.Dirty
                || _hudLoanAmount5.Dirty
                || _hudLoanAmount6.Dirty
                || _hudLoanAmount7.Dirty
                || _hudLoanAmount8.Dirty
                || _hudLoanAmount9.Dirty
                || _hudRealEstateFhaInsured1.Dirty
                || _hudRealEstateFhaInsured2.Dirty
                || _hudRealEstateLienHolder1.Dirty
                || _hudRealEstateLienHolder2.Dirty
                || _hudRealEstateLoanAmount1.Dirty
                || _hudRealEstateLoanAmount2.Dirty
                || _hudRealEstateMonthlyPayment1.Dirty
                || _hudRealEstateMonthlyPayment2.Dirty
                || _hudRealEstatePresentBalance1.Dirty
                || _hudRealEstatePresentBalance2.Dirty
                || _id.Dirty
                || _incomeOfBorrowersSpouseUsedIndicator.Dirty
                || _incomeOtherThanBorrowerUsedIndicator.Dirty
                || _jointAssetLiabilityReportingIndicator.Dirty
                || _lastModified.Dirty
                || _liquidAssetsComortSet.Dirty
                || _loanAmount.Dirty
                || _loanOfficerId.Dirty
                || _loanOfficerName.Dirty
                || _mcawBorrowerOtherMonthlyIncomeAmount.Dirty
                || _mcawCoborrowerOtherMonthlyIncomeAmount.Dirty
                || _mcawGrossMonthlyIncomeAmount.Dirty
                || _mcawMortgagePaymentToIncome1Amount.Dirty
                || _mcawMortgagePaymentToIncome2Amount.Dirty
                || _mcawOtherAmount.Dirty
                || _mcawOtherDebtsAndObligationsAmount.Dirty
                || _mcawTotalFixedPaymentForPurchaseAmount.Dirty
                || _mcawTotalFixedPaymentForRefinanceAmount.Dirty
                || _mcawTotalFixedPaymentToIncome1Amount.Dirty
                || _mcawTotalFixedPaymentToIncome2Amount.Dirty
                || _mcawTotalMonthlyPaymentsAmount.Dirty
                || _mcawTotalMortgagePaymentAmount.Dirty
                || _monthlyExpenseComortSet.Dirty
                || _monthlyHousingExpenseAmount.Dirty
                || _monthlyInstallmentExpenseAmount.Dirty
                || _monthlyNegativeRealEstateAmount.Dirty
                || _monthlySecondHomeAmount.Dirty
                || _mortgageInsuranceAmount.Dirty
                || _netWorthAmount.Dirty
                || _otherHousingExpenseAmount.Dirty
                || _otherItemsDeducted.Dirty
                || _otherMortgagePrincipalAndInterestAmount.Dirty
                || _pastCreditRecord.Dirty
                || _presentHousingExpComortSet.Dirty
                || _primaryResidenceComortSet.Dirty
                || _propertyUsageType.Dirty
                || _proposedDuesAmount.Dirty
                || _proposedFirstMortgageAmount.Dirty
                || _proposedGroundRentAmount.Dirty
                || _proposedHazardInsuranceAmount.Dirty
                || _proposedMortgageInsuranceAmount.Dirty
                || _proposedOtherAmount.Dirty
                || _proposedOtherMortgagesAmount.Dirty
                || _proposedRealEstateTaxesAmount.Dirty
                || _realEstateTaxAmount.Dirty
                || _rentAmount.Dirty
                || _reoTotalGrossRentalIncomeAmount.Dirty
                || _reoTotalMaintenanceAmount.Dirty
                || _reoTotalMarketValueAmount.Dirty
                || _reoTotalMortgagePaymentsAmount.Dirty
                || _reoTotalMortgagesAndLiensAmount.Dirty
                || _reoTotalNetRentalIncomeAmount.Dirty
                || _respa6.Dirty
                || _sofDBorrowerAddress.Dirty
                || _sofDBorrowerAddressCity.Dirty
                || _sofDBorrowerAddressState.Dirty
                || _sofDBorrowerAddressType.Dirty
                || _sofDBorrowerAddressZipcode.Dirty
                || _sofDCoBorrowerAddress.Dirty
                || _sofDCoBorrowerAddressCity.Dirty
                || _sofDCoBorrowerAddressState.Dirty
                || _sofDCoBorrowerAddressType.Dirty
                || _sofDCoBorrowerAddressZipcode.Dirty
                || _spouseIncomeConsider.Dirty
                || _topRatioPercent.Dirty
                || _totalAssetsAmount.Dirty
                || _totalBaseIncomeAmount.Dirty
                || _totalBonusAmount.Dirty
                || _totalCommissionsAmount.Dirty
                || _totalDeposit.Dirty
                || _totalDividendsInterestAmount.Dirty
                || _totalEmploymentAmount.Dirty
                || _totalFixedPaymentAmount.Dirty
                || _totalGrossMonthlyIncomeAmount.Dirty
                || _totalIncomeAmount.Dirty
                || _totalMonthlyPaymentAmount.Dirty
                || _totalMortgagesBalanceAmount.Dirty
                || _totalMortgagesMonthlyPaymentAmount.Dirty
                || _totalNetRentalIncomeAmount.Dirty
                || _totalOther1Amount.Dirty
                || _totalOther2Amount.Dirty
                || _totalOvertimeAmount.Dirty
                || _totalPaymentsAmount.Dirty
                || _totalPrimaryHousingExpenseAmount.Dirty
                || _totalReoMarketValueAmount.Dirty
                || _totalUserDefinedIncome.Dirty
                || _transUnionAddress.Dirty
                || _transUnionCity.Dirty
                || _transUnionFax.Dirty
                || _transUnionModel.Dirty
                || _transUnionName.Dirty
                || _transUnionPhone.Dirty
                || _transUnionPostalCode.Dirty
                || _transUnionScoreRangeFrom.Dirty
                || _transUnionScoreRangeTo.Dirty
                || _transUnionState.Dirty
                || _transUnionWebsite.Dirty
                || _userDefinedIncome.Dirty
                || _userDefinedIncomeDescription.Dirty
                || _vACreditStandards.Dirty
                || _vaSummarySpouseIncomeAmount.Dirty
                || _vaSummaryTotalMonthlyGrossIncomeAmount.Dirty
                || _assets?.Dirty == true
                || _aTRQMBorrower?.Dirty == true
                || _aTRQMBorrowers?.Dirty == true
                || _aUSTrackingLogs?.Dirty == true
                || _borrower?.Dirty == true
                || _coborrower?.Dirty == true
                || _employment?.Dirty == true
                || _income?.Dirty == true
                || _liabilities?.Dirty == true
                || _reoProperties?.Dirty == true
                || _residences?.Dirty == true
                || _selfEmployedIncomes?.Dirty == true
                || _tax4506s?.Dirty == true
                || _tQLReports?.Dirty == true;
            set
            {
                _accountNumber1.Dirty = value;
                _accountNumber2.Dirty = value;
                _allOtherPaymentsAmount.Dirty = value;
                _applicationId.Dirty = value;
                _applicationIndex.Dirty = value;
                _applicationSignedDate.Dirty = value;
                _assetsAvailableAmount.Dirty = value;
                _balanceAvailableFamilySupportGuideline.Dirty = value;
                _bottomRatioPercent.Dirty = value;
                _brwCoBrwTotalTaxDeductions.Dirty = value;
                _creditAliasName1.Dirty = value;
                _creditAliasName2.Dirty = value;
                _creditorName1.Dirty = value;
                _creditorName2.Dirty = value;
                _creditReportReferenceIdentifier.Dirty = value;
                _entityDeleted.Dirty = value;
                _equifaxAddress.Dirty = value;
                _equifaxCity.Dirty = value;
                _equifaxFax.Dirty = value;
                _equifaxModel.Dirty = value;
                _equifaxName.Dirty = value;
                _equifaxPhone.Dirty = value;
                _equifaxPostalCode.Dirty = value;
                _equifaxScoreRangeFrom.Dirty = value;
                _equifaxScoreRangeTo.Dirty = value;
                _equifaxState.Dirty = value;
                _equifaxWebsite.Dirty = value;
                _experianAddress.Dirty = value;
                _experianCity.Dirty = value;
                _experianFax.Dirty = value;
                _experianModel.Dirty = value;
                _experianName.Dirty = value;
                _experianPhone.Dirty = value;
                _experianPostalCode.Dirty = value;
                _experianScoreRangeFrom.Dirty = value;
                _experianScoreRangeTo.Dirty = value;
                _experianState.Dirty = value;
                _experianWebsite.Dirty = value;
                _fhaVaDebtIncomeRatio.Dirty = value;
                _fhaVaFamilySupportAmount.Dirty = value;
                _fhaVaTotalEstimatedMonthlyShelterExpenseAmount.Dirty = value;
                _fhaVaTotalNetEffectiveIncomeAmount.Dirty = value;
                _fhaVaTotalNetIncomeAmount.Dirty = value;
                _fhaVaTotalNetTakeHomePayAmount.Dirty = value;
                _fhaVaTotalOtherNetIncome.Dirty = value;
                _firstMortgagePrincipalAndInterestAmount.Dirty = value;
                _freddieMacCreditReportReferenceIdentifier.Dirty = value;
                _freddieMacOccupantDebtRatio.Dirty = value;
                _freddieMacOccupantHousingRatio.Dirty = value;
                _freDebtToHousingGapRatio.Dirty = value;
                _grossBaseIncomeAmount.Dirty = value;
                _grossIncomeForComortSet.Dirty = value;
                _grossNegativeCashFlow.Dirty = value;
                _grossOtherIncomeAmount.Dirty = value;
                _grossPositiveCashFlow.Dirty = value;
                _hazardInsuranceAmount.Dirty = value;
                _homeownersAssociationDuesAndCondoFeesAmount.Dirty = value;
                _hudAutoLienHolderName1.Dirty = value;
                _hudAutoLienHolderName2.Dirty = value;
                _hudAutoLoanAmount1.Dirty = value;
                _hudAutoLoanAmount2.Dirty = value;
                _hudAutoMonthlyPayment1.Dirty = value;
                _hudAutoMonthlyPayment2.Dirty = value;
                _hudAutoPresentBalance1.Dirty = value;
                _hudAutoPresentBalance2.Dirty = value;
                _hudAutoYearAndMake1.Dirty = value;
                _hudAutoYearAndMake2.Dirty = value;
                _hudLoanAmount1.Dirty = value;
                _hudLoanAmount10.Dirty = value;
                _hudLoanAmount11.Dirty = value;
                _hudLoanAmount2.Dirty = value;
                _hudLoanAmount3.Dirty = value;
                _hudLoanAmount4.Dirty = value;
                _hudLoanAmount5.Dirty = value;
                _hudLoanAmount6.Dirty = value;
                _hudLoanAmount7.Dirty = value;
                _hudLoanAmount8.Dirty = value;
                _hudLoanAmount9.Dirty = value;
                _hudRealEstateFhaInsured1.Dirty = value;
                _hudRealEstateFhaInsured2.Dirty = value;
                _hudRealEstateLienHolder1.Dirty = value;
                _hudRealEstateLienHolder2.Dirty = value;
                _hudRealEstateLoanAmount1.Dirty = value;
                _hudRealEstateLoanAmount2.Dirty = value;
                _hudRealEstateMonthlyPayment1.Dirty = value;
                _hudRealEstateMonthlyPayment2.Dirty = value;
                _hudRealEstatePresentBalance1.Dirty = value;
                _hudRealEstatePresentBalance2.Dirty = value;
                _id.Dirty = value;
                _incomeOfBorrowersSpouseUsedIndicator.Dirty = value;
                _incomeOtherThanBorrowerUsedIndicator.Dirty = value;
                _jointAssetLiabilityReportingIndicator.Dirty = value;
                _lastModified.Dirty = value;
                _liquidAssetsComortSet.Dirty = value;
                _loanAmount.Dirty = value;
                _loanOfficerId.Dirty = value;
                _loanOfficerName.Dirty = value;
                _mcawBorrowerOtherMonthlyIncomeAmount.Dirty = value;
                _mcawCoborrowerOtherMonthlyIncomeAmount.Dirty = value;
                _mcawGrossMonthlyIncomeAmount.Dirty = value;
                _mcawMortgagePaymentToIncome1Amount.Dirty = value;
                _mcawMortgagePaymentToIncome2Amount.Dirty = value;
                _mcawOtherAmount.Dirty = value;
                _mcawOtherDebtsAndObligationsAmount.Dirty = value;
                _mcawTotalFixedPaymentForPurchaseAmount.Dirty = value;
                _mcawTotalFixedPaymentForRefinanceAmount.Dirty = value;
                _mcawTotalFixedPaymentToIncome1Amount.Dirty = value;
                _mcawTotalFixedPaymentToIncome2Amount.Dirty = value;
                _mcawTotalMonthlyPaymentsAmount.Dirty = value;
                _mcawTotalMortgagePaymentAmount.Dirty = value;
                _monthlyExpenseComortSet.Dirty = value;
                _monthlyHousingExpenseAmount.Dirty = value;
                _monthlyInstallmentExpenseAmount.Dirty = value;
                _monthlyNegativeRealEstateAmount.Dirty = value;
                _monthlySecondHomeAmount.Dirty = value;
                _mortgageInsuranceAmount.Dirty = value;
                _netWorthAmount.Dirty = value;
                _otherHousingExpenseAmount.Dirty = value;
                _otherItemsDeducted.Dirty = value;
                _otherMortgagePrincipalAndInterestAmount.Dirty = value;
                _pastCreditRecord.Dirty = value;
                _presentHousingExpComortSet.Dirty = value;
                _primaryResidenceComortSet.Dirty = value;
                _propertyUsageType.Dirty = value;
                _proposedDuesAmount.Dirty = value;
                _proposedFirstMortgageAmount.Dirty = value;
                _proposedGroundRentAmount.Dirty = value;
                _proposedHazardInsuranceAmount.Dirty = value;
                _proposedMortgageInsuranceAmount.Dirty = value;
                _proposedOtherAmount.Dirty = value;
                _proposedOtherMortgagesAmount.Dirty = value;
                _proposedRealEstateTaxesAmount.Dirty = value;
                _realEstateTaxAmount.Dirty = value;
                _rentAmount.Dirty = value;
                _reoTotalGrossRentalIncomeAmount.Dirty = value;
                _reoTotalMaintenanceAmount.Dirty = value;
                _reoTotalMarketValueAmount.Dirty = value;
                _reoTotalMortgagePaymentsAmount.Dirty = value;
                _reoTotalMortgagesAndLiensAmount.Dirty = value;
                _reoTotalNetRentalIncomeAmount.Dirty = value;
                _respa6.Dirty = value;
                _sofDBorrowerAddress.Dirty = value;
                _sofDBorrowerAddressCity.Dirty = value;
                _sofDBorrowerAddressState.Dirty = value;
                _sofDBorrowerAddressType.Dirty = value;
                _sofDBorrowerAddressZipcode.Dirty = value;
                _sofDCoBorrowerAddress.Dirty = value;
                _sofDCoBorrowerAddressCity.Dirty = value;
                _sofDCoBorrowerAddressState.Dirty = value;
                _sofDCoBorrowerAddressType.Dirty = value;
                _sofDCoBorrowerAddressZipcode.Dirty = value;
                _spouseIncomeConsider.Dirty = value;
                _topRatioPercent.Dirty = value;
                _totalAssetsAmount.Dirty = value;
                _totalBaseIncomeAmount.Dirty = value;
                _totalBonusAmount.Dirty = value;
                _totalCommissionsAmount.Dirty = value;
                _totalDeposit.Dirty = value;
                _totalDividendsInterestAmount.Dirty = value;
                _totalEmploymentAmount.Dirty = value;
                _totalFixedPaymentAmount.Dirty = value;
                _totalGrossMonthlyIncomeAmount.Dirty = value;
                _totalIncomeAmount.Dirty = value;
                _totalMonthlyPaymentAmount.Dirty = value;
                _totalMortgagesBalanceAmount.Dirty = value;
                _totalMortgagesMonthlyPaymentAmount.Dirty = value;
                _totalNetRentalIncomeAmount.Dirty = value;
                _totalOther1Amount.Dirty = value;
                _totalOther2Amount.Dirty = value;
                _totalOvertimeAmount.Dirty = value;
                _totalPaymentsAmount.Dirty = value;
                _totalPrimaryHousingExpenseAmount.Dirty = value;
                _totalReoMarketValueAmount.Dirty = value;
                _totalUserDefinedIncome.Dirty = value;
                _transUnionAddress.Dirty = value;
                _transUnionCity.Dirty = value;
                _transUnionFax.Dirty = value;
                _transUnionModel.Dirty = value;
                _transUnionName.Dirty = value;
                _transUnionPhone.Dirty = value;
                _transUnionPostalCode.Dirty = value;
                _transUnionScoreRangeFrom.Dirty = value;
                _transUnionScoreRangeTo.Dirty = value;
                _transUnionState.Dirty = value;
                _transUnionWebsite.Dirty = value;
                _userDefinedIncome.Dirty = value;
                _userDefinedIncomeDescription.Dirty = value;
                _vACreditStandards.Dirty = value;
                _vaSummarySpouseIncomeAmount.Dirty = value;
                _vaSummaryTotalMonthlyGrossIncomeAmount.Dirty = value;
                if (_assets != null) _assets.Dirty = value;
                if (_aTRQMBorrower != null) _aTRQMBorrower.Dirty = value;
                if (_aTRQMBorrowers != null) _aTRQMBorrowers.Dirty = value;
                if (_aUSTrackingLogs != null) _aUSTrackingLogs.Dirty = value;
                if (_borrower != null) _borrower.Dirty = value;
                if (_coborrower != null) _coborrower.Dirty = value;
                if (_employment != null) _employment.Dirty = value;
                if (_income != null) _income.Dirty = value;
                if (_liabilities != null) _liabilities.Dirty = value;
                if (_reoProperties != null) _reoProperties.Dirty = value;
                if (_residences != null) _residences.Dirty = value;
                if (_selfEmployedIncomes != null) _selfEmployedIncomes.Dirty = value;
                if (_tax4506s != null) _tax4506s.Dirty = value;
                if (_tQLReports != null) _tQLReports.Dirty = value;
            }
        }
    }
}