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
        public string AccountNumber1 { get => _accountNumber1; set => SetField(ref _accountNumber1, value); }
        private DirtyValue<string> _accountNumber2;
        /// <summary>
        /// Liabilities Alternate Acct # 2 [1737]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Acct # 2")]
        public string AccountNumber2 { get => _accountNumber2; set => SetField(ref _accountNumber2, value); }
        private DirtyValue<decimal?> _allOtherPaymentsAmount;
        /// <summary>
        /// Underwriting All Other Pymts [1733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting All Other Pymts")]
        public decimal? AllOtherPaymentsAmount { get => _allOtherPaymentsAmount; set => SetField(ref _allOtherPaymentsAmount, value); }
        private DirtyValue<string> _applicationId;
        /// <summary>
        /// Application ApplicationId
        /// </summary>
        public string ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }
        private DirtyValue<int?> _applicationIndex;
        /// <summary>
        /// Application ApplicationIndex
        /// </summary>
        public int? ApplicationIndex { get => _applicationIndex; set => SetField(ref _applicationIndex, value); }
        private DirtyValue<DateTime?> _applicationSignedDate;
        /// <summary>
        /// Fannie Mae Signature Date [MORNET.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Signature Date")]
        public DateTime? ApplicationSignedDate { get => _applicationSignedDate; set => SetField(ref _applicationSignedDate, value); }
        private DirtyList<Asset> _assets;
        /// <summary>
        /// Application Assets
        /// </summary>
        public IList<Asset> Assets { get => GetField(ref _assets); set => SetField(ref _assets, value); }
        private DirtyValue<decimal?> _assetsAvailableAmount;
        /// <summary>
        /// FHA MCAW Assets Available [1094]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Assets Available")]
        public decimal? AssetsAvailableAmount { get => _assetsAvailableAmount; set => SetField(ref _assetsAvailableAmount, value); }
        private ATRQMBorrower _aTRQMBorrower;
        /// <summary>
        /// Application ATRQMBorrower
        /// </summary>
        public ATRQMBorrower ATRQMBorrower { get => GetField(ref _aTRQMBorrower); set => SetField(ref _aTRQMBorrower, value); }
        private DirtyList<ATRQMBorrower> _aTRQMBorrowers;
        /// <summary>
        /// Application ATRQMBorrowers
        /// </summary>
        public IList<ATRQMBorrower> ATRQMBorrowers { get => GetField(ref _aTRQMBorrowers); set => SetField(ref _aTRQMBorrowers, value); }
        private DirtyList<AUSTrackingLog> _aUSTrackingLogs;
        /// <summary>
        /// Application AUSTrackingLogs
        /// </summary>
        public IList<AUSTrackingLog> AUSTrackingLogs { get => GetField(ref _aUSTrackingLogs); set => SetField(ref _aUSTrackingLogs, value); }
        private DirtyValue<decimal?> _balanceAvailableFamilySupportGuideline;
        /// <summary>
        /// VA Bal Avail Family Support Guideline [1340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Bal Avail Family Support Guideline")]
        public decimal? BalanceAvailableFamilySupportGuideline { get => _balanceAvailableFamilySupportGuideline; set => SetField(ref _balanceAvailableFamilySupportGuideline, value); }
        private Borrower _borrower;
        /// <summary>
        /// Application Borrower
        /// </summary>
        public Borrower Borrower { get => GetField(ref _borrower); set => SetField(ref _borrower, value); }
        private DirtyValue<decimal?> _bottomRatioPercent;
        /// <summary>
        /// Trans Details Qual Ratio Bottom [742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Bottom")]
        public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => SetField(ref _bottomRatioPercent, value); }
        private DirtyValue<decimal?> _brwCoBrwTotalTaxDeductions;
        /// <summary>
        /// Income Total Deductions Spouse/Borr [1312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Deductions Spouse/Borr")]
        public decimal? BrwCoBrwTotalTaxDeductions { get => _brwCoBrwTotalTaxDeductions; set => SetField(ref _brwCoBrwTotalTaxDeductions, value); }
        private Borrower _coborrower;
        /// <summary>
        /// Application Coborrower
        /// </summary>
        public Borrower Coborrower { get => GetField(ref _coborrower); set => SetField(ref _coborrower, value); }
        private DirtyValue<string> _creditAliasName1;
        /// <summary>
        /// Liabilities Alternate Name 1 [206]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 1")]
        public string CreditAliasName1 { get => _creditAliasName1; set => SetField(ref _creditAliasName1, value); }
        private DirtyValue<string> _creditAliasName2;
        /// <summary>
        /// Liabilities Alternate Name 2 [203]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 2")]
        public string CreditAliasName2 { get => _creditAliasName2; set => SetField(ref _creditAliasName2, value); }
        private DirtyValue<string> _creditorName1;
        /// <summary>
        /// Liabilities Creditor Name 1 [1734]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 1")]
        public string CreditorName1 { get => _creditorName1; set => SetField(ref _creditorName1, value); }
        private DirtyValue<string> _creditorName2;
        /// <summary>
        /// Liabilities Creditor Name 2 [1736]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 2")]
        public string CreditorName2 { get => _creditorName2; set => SetField(ref _creditorName2, value); }
        private DirtyValue<string> _creditReportReferenceIdentifier;
        /// <summary>
        /// Trans Details Credit Rpt Ref # [300]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Credit Rpt Ref #")]
        public string CreditReportReferenceIdentifier { get => _creditReportReferenceIdentifier; set => SetField(ref _creditReportReferenceIdentifier, value); }
        private DirtyList<Employment> _employment;
        /// <summary>
        /// Application Employment
        /// </summary>
        public IList<Employment> Employment { get => GetField(ref _employment); set => SetField(ref _employment, value); }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Application EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }
        private DirtyValue<string> _equifaxAddress;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Addr [DISCLOSURE.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Addr")]
        public string EquifaxAddress { get => _equifaxAddress; set => SetField(ref _equifaxAddress, value); }
        private DirtyValue<string> _equifaxCity;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co City [DISCLOSURE.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co City")]
        public string EquifaxCity { get => _equifaxCity; set => SetField(ref _equifaxCity, value); }
        private DirtyValue<string> _equifaxFax;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Fax [DISCLOSURE.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Fax")]
        public string EquifaxFax { get => _equifaxFax; set => SetField(ref _equifaxFax, value); }
        private DirtyValue<string> _equifaxModel;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Model [DISCLOSURE.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Model")]
        public string EquifaxModel { get => _equifaxModel; set => SetField(ref _equifaxModel, value); }
        private DirtyValue<string> _equifaxName;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Name [DISCLOSURE.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Name")]
        public string EquifaxName { get => _equifaxName; set => SetField(ref _equifaxName, value); }
        private DirtyValue<string> _equifaxPhone;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Phone [DISCLOSURE.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Phone")]
        public string EquifaxPhone { get => _equifaxPhone; set => SetField(ref _equifaxPhone, value); }
        private DirtyValue<string> _equifaxPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Zip [DISCLOSURE.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 3 Co Zip")]
        public string EquifaxPostalCode { get => _equifaxPostalCode; set => SetField(ref _equifaxPostalCode, value); }
        private DirtyValue<string> _equifaxScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores From [DISCLOSURE.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores From")]
        public string EquifaxScoreRangeFrom { get => _equifaxScoreRangeFrom; set => SetField(ref _equifaxScoreRangeFrom, value); }
        private DirtyValue<string> _equifaxScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores To [DISCLOSURE.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores To")]
        public string EquifaxScoreRangeTo { get => _equifaxScoreRangeTo; set => SetField(ref _equifaxScoreRangeTo, value); }
        private DirtyValue<StringEnumValue<State>> _equifaxState;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co State [DISCLOSURE.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co State")]
        public StringEnumValue<State> EquifaxState { get => _equifaxState; set => SetField(ref _equifaxState, value); }
        private DirtyValue<string> _equifaxWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 3 Co Website [DISCLOSURE.X640]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Website")]
        public string EquifaxWebsite { get => _equifaxWebsite; set => SetField(ref _equifaxWebsite, value); }
        private DirtyValue<string> _experianAddress;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Addr [DISCLOSURE.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Addr")]
        public string ExperianAddress { get => _experianAddress; set => SetField(ref _experianAddress, value); }
        private DirtyValue<string> _experianCity;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co City [DISCLOSURE.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co City")]
        public string ExperianCity { get => _experianCity; set => SetField(ref _experianCity, value); }
        private DirtyValue<string> _experianFax;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Fax [DISCLOSURE.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Fax")]
        public string ExperianFax { get => _experianFax; set => SetField(ref _experianFax, value); }
        private DirtyValue<string> _experianModel;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Model Used [DISCLOSURE.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Model Used")]
        public string ExperianModel { get => _experianModel; set => SetField(ref _experianModel, value); }
        private DirtyValue<string> _experianName;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Name [DISCLOSURE.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Name")]
        public string ExperianName { get => _experianName; set => SetField(ref _experianName, value); }
        private DirtyValue<string> _experianPhone;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Phone [DISCLOSURE.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Phone")]
        public string ExperianPhone { get => _experianPhone; set => SetField(ref _experianPhone, value); }
        private DirtyValue<string> _experianPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Zip [DISCLOSURE.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 1 Co Zip")]
        public string ExperianPostalCode { get => _experianPostalCode; set => SetField(ref _experianPostalCode, value); }
        private DirtyValue<string> _experianScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores From [DISCLOSURE.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores From")]
        public string ExperianScoreRangeFrom { get => _experianScoreRangeFrom; set => SetField(ref _experianScoreRangeFrom, value); }
        private DirtyValue<string> _experianScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores To [DISCLOSURE.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores To")]
        public string ExperianScoreRangeTo { get => _experianScoreRangeTo; set => SetField(ref _experianScoreRangeTo, value); }
        private DirtyValue<StringEnumValue<State>> _experianState;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co State [DISCLOSURE.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co State")]
        public StringEnumValue<State> ExperianState { get => _experianState; set => SetField(ref _experianState, value); }
        private DirtyValue<string> _experianWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 1 Co Website [DISCLOSURE.X638]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Website")]
        public string ExperianWebsite { get => _experianWebsite; set => SetField(ref _experianWebsite, value); }
        private DirtyValue<decimal?> _fhaVaDebtIncomeRatio;
        /// <summary>
        /// VA Debt-to-Income Ratio [1341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Debt-to-Income Ratio")]
        public decimal? FhaVaDebtIncomeRatio { get => _fhaVaDebtIncomeRatio; set => SetField(ref _fhaVaDebtIncomeRatio, value); }
        private DirtyValue<decimal?> _fhaVaFamilySupportAmount;
        /// <summary>
        /// Income Total Residual Income Spouse/Borr [1325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Residual Income Spouse/Borr")]
        public decimal? FhaVaFamilySupportAmount { get => _fhaVaFamilySupportAmount; set => SetField(ref _fhaVaFamilySupportAmount, value); }
        private DirtyValue<decimal?> _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
        /// <summary>
        /// Expenses Total Mo Shelter Exp Est [1349]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Shelter Exp Est")]
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; set => SetField(ref _fhaVaTotalEstimatedMonthlyShelterExpenseAmount, value); }
        private DirtyValue<decimal?> _fhaVaTotalNetEffectiveIncomeAmount;
        /// <summary>
        /// Income Total Net Effective Income [1323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Effective Income")]
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => _fhaVaTotalNetEffectiveIncomeAmount; set => SetField(ref _fhaVaTotalNetEffectiveIncomeAmount, value); }
        private DirtyValue<decimal?> _fhaVaTotalNetIncomeAmount;
        /// <summary>
        /// Income Total Net Spouse/Borr [1321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Spouse/Borr")]
        public decimal? FhaVaTotalNetIncomeAmount { get => _fhaVaTotalNetIncomeAmount; set => SetField(ref _fhaVaTotalNetIncomeAmount, value); }
        private DirtyValue<decimal?> _fhaVaTotalNetTakeHomePayAmount;
        /// <summary>
        /// Income Net Take Home Pay Spouse/Borr [1315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Net Take Home Pay Spouse/Borr")]
        public decimal? FhaVaTotalNetTakeHomePayAmount { get => _fhaVaTotalNetTakeHomePayAmount; set => SetField(ref _fhaVaTotalNetTakeHomePayAmount, value); }
        private DirtyValue<decimal?> _fhaVaTotalOtherNetIncome;
        /// <summary>
        /// Income Other Net Spouse/Borr [1318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Other Net Spouse/Borr")]
        public decimal? FhaVaTotalOtherNetIncome { get => _fhaVaTotalOtherNetIncome; set => SetField(ref _fhaVaTotalOtherNetIncome, value); }
        private DirtyValue<decimal?> _firstMortgagePrincipalAndInterestAmount;
        /// <summary>
        /// Expenses Present Mtg Pymt [120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Mtg Pymt")]
        public decimal? FirstMortgagePrincipalAndInterestAmount { get => _firstMortgagePrincipalAndInterestAmount; set => SetField(ref _firstMortgagePrincipalAndInterestAmount, value); }
        private DirtyValue<string> _freddieMacCreditReportReferenceIdentifier;
        /// <summary>
        /// Freddie Mac Credit Ref # [CASASRN.X198]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Credit Ref #")]
        public string FreddieMacCreditReportReferenceIdentifier { get => _freddieMacCreditReportReferenceIdentifier; set => SetField(ref _freddieMacCreditReportReferenceIdentifier, value); }
        private DirtyValue<decimal?> _freddieMacOccupantDebtRatio;
        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Debt Ratio [CASASRN.X202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Debt Ratio")]
        public decimal? FreddieMacOccupantDebtRatio { get => _freddieMacOccupantDebtRatio; set => SetField(ref _freddieMacOccupantDebtRatio, value); }
        private DirtyValue<decimal?> _freddieMacOccupantHousingRatio;
        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Housing Ratio [CASASRN.X201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Housing Ratio")]
        public decimal? FreddieMacOccupantHousingRatio { get => _freddieMacOccupantHousingRatio; set => SetField(ref _freddieMacOccupantHousingRatio, value); }
        private DirtyValue<decimal?> _freDebtToHousingGapRatio;
        /// <summary>
        /// Trans Details Qual Ratio Debt-to-Housing [1539]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Debt-to-Housing")]
        public decimal? FreDebtToHousingGapRatio { get => _freDebtToHousingGapRatio; set => SetField(ref _freDebtToHousingGapRatio, value); }
        private DirtyValue<decimal?> _grossBaseIncomeAmount;
        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [273]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? GrossBaseIncomeAmount { get => _grossBaseIncomeAmount; set => SetField(ref _grossBaseIncomeAmount, value); }
        private DirtyValue<decimal?> _grossIncomeForComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor Income [1374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Income")]
        public decimal? GrossIncomeForComortSet { get => _grossIncomeForComortSet; set => SetField(ref _grossIncomeForComortSet, value); }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        /// <summary>
        /// Underwriting Negative Cash Flow [462]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Negative Cash Flow")]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => SetField(ref _grossNegativeCashFlow, value); }
        private DirtyValue<decimal?> _grossOtherIncomeAmount;
        /// <summary>
        /// Income Total Other Income (Borr/Co-Borr) [1168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (Borr/Co-Borr)")]
        public decimal? GrossOtherIncomeAmount { get => _grossOtherIncomeAmount; set => SetField(ref _grossOtherIncomeAmount, value); }
        private DirtyValue<decimal?> _grossPositiveCashFlow;
        /// <summary>
        /// Income Total Positive Cash Flow (Borr/Co-Borr) [1171]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Positive Cash Flow (Borr/Co-Borr)")]
        public decimal? GrossPositiveCashFlow { get => _grossPositiveCashFlow; set => SetField(ref _grossPositiveCashFlow, value); }
        private DirtyValue<string> _hazardInsuranceAmount;
        /// <summary>
        /// Expenses Present Haz Ins [122]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Haz Ins")]
        public string HazardInsuranceAmount { get => _hazardInsuranceAmount; set => SetField(ref _hazardInsuranceAmount, value); }
        private DirtyValue<string> _homeownersAssociationDuesAndCondoFeesAmount;
        /// <summary>
        /// Expenses Present HOA [125]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present HOA")]
        public string HomeownersAssociationDuesAndCondoFeesAmount { get => _homeownersAssociationDuesAndCondoFeesAmount; set => SetField(ref _homeownersAssociationDuesAndCondoFeesAmount, value); }
        private DirtyValue<string> _hudAutoLienHolderName1;
        /// <summary>
        /// HUD Property Improve Auto 1 Lienholder [CAPIAP.X134]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Lienholder")]
        public string HudAutoLienHolderName1 { get => _hudAutoLienHolderName1; set => SetField(ref _hudAutoLienHolderName1, value); }
        private DirtyValue<string> _hudAutoLienHolderName2;
        /// <summary>
        /// HUD Property Improve Auto 2 Lienholder [CAPIAP.X139]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Lienholder")]
        public string HudAutoLienHolderName2 { get => _hudAutoLienHolderName2; set => SetField(ref _hudAutoLienHolderName2, value); }
        private DirtyValue<decimal?> _hudAutoLoanAmount1;
        /// <summary>
        /// HUD Property Improve Auto 1 Loan Amt [CAPIAP.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Loan Amt")]
        public decimal? HudAutoLoanAmount1 { get => _hudAutoLoanAmount1; set => SetField(ref _hudAutoLoanAmount1, value); }
        private DirtyValue<decimal?> _hudAutoLoanAmount2;
        /// <summary>
        /// HUD Property Improve Auto 2 Loan Amt [CAPIAP.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Loan Amt")]
        public decimal? HudAutoLoanAmount2 { get => _hudAutoLoanAmount2; set => SetField(ref _hudAutoLoanAmount2, value); }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment1;
        /// <summary>
        /// HUD Property Improve Auto 1 Mo Pymt [CAPIAP.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment1 { get => _hudAutoMonthlyPayment1; set => SetField(ref _hudAutoMonthlyPayment1, value); }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment2;
        /// <summary>
        /// HUD Property Improve Auto 2 Mo Pymt [CAPIAP.X143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment2 { get => _hudAutoMonthlyPayment2; set => SetField(ref _hudAutoMonthlyPayment2, value); }
        private DirtyValue<decimal?> _hudAutoPresentBalance1;
        /// <summary>
        /// HUD Property Improve Auto 1 Present Bal [CAPIAP.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Present Bal")]
        public decimal? HudAutoPresentBalance1 { get => _hudAutoPresentBalance1; set => SetField(ref _hudAutoPresentBalance1, value); }
        private DirtyValue<decimal?> _hudAutoPresentBalance2;
        /// <summary>
        /// HUD Property Improve Auto 2 Present Bal [CAPIAP.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Present Bal")]
        public decimal? HudAutoPresentBalance2 { get => _hudAutoPresentBalance2; set => SetField(ref _hudAutoPresentBalance2, value); }
        private DirtyValue<string> _hudAutoYearAndMake1;
        /// <summary>
        /// HUD Property Improve Auto 1 Yr/Make [CAPIAP.X135]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Yr/Make")]
        public string HudAutoYearAndMake1 { get => _hudAutoYearAndMake1; set => SetField(ref _hudAutoYearAndMake1, value); }
        private DirtyValue<string> _hudAutoYearAndMake2;
        /// <summary>
        /// HUD Property Improve Auto 2 Yr/Make [CAPIAP.X140]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Yr/Make")]
        public string HudAutoYearAndMake2 { get => _hudAutoYearAndMake2; set => SetField(ref _hudAutoYearAndMake2, value); }
        private DirtyValue<decimal?> _hudLoanAmount1;
        /// <summary>
        /// HUD Property Improve Liability 1 Loan Amt [CAPIAP.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 1 Loan Amt")]
        public decimal? HudLoanAmount1 { get => _hudLoanAmount1; set => SetField(ref _hudLoanAmount1, value); }
        private DirtyValue<decimal?> _hudLoanAmount10;
        /// <summary>
        /// HUD Property Improve Liability 10 Loan Amt [CAPIAP.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 10 Loan Amt")]
        public decimal? HudLoanAmount10 { get => _hudLoanAmount10; set => SetField(ref _hudLoanAmount10, value); }
        private DirtyValue<decimal?> _hudLoanAmount11;
        /// <summary>
        /// HUD Property Improve Liability 11 Loan Amt [CAPIAP.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 11 Loan Amt")]
        public decimal? HudLoanAmount11 { get => _hudLoanAmount11; set => SetField(ref _hudLoanAmount11, value); }
        private DirtyValue<decimal?> _hudLoanAmount2;
        /// <summary>
        /// HUD Property Improve Liability 2 Loan Amt [CAPIAP.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 2 Loan Amt")]
        public decimal? HudLoanAmount2 { get => _hudLoanAmount2; set => SetField(ref _hudLoanAmount2, value); }
        private DirtyValue<decimal?> _hudLoanAmount3;
        /// <summary>
        /// HUD Property Improve Liability 3 Loan Amt [CAPIAP.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 3 Loan Amt")]
        public decimal? HudLoanAmount3 { get => _hudLoanAmount3; set => SetField(ref _hudLoanAmount3, value); }
        private DirtyValue<decimal?> _hudLoanAmount4;
        /// <summary>
        /// HUD Property Improve Liability 4 Loan Amt [CAPIAP.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 4 Loan Amt")]
        public decimal? HudLoanAmount4 { get => _hudLoanAmount4; set => SetField(ref _hudLoanAmount4, value); }
        private DirtyValue<decimal?> _hudLoanAmount5;
        /// <summary>
        /// HUD Property Improve Liability 5 Loan Amt [CAPIAP.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 5 Loan Amt")]
        public decimal? HudLoanAmount5 { get => _hudLoanAmount5; set => SetField(ref _hudLoanAmount5, value); }
        private DirtyValue<decimal?> _hudLoanAmount6;
        /// <summary>
        /// HUD Property Improve Liability 6 Loan Amt [CAPIAP.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 6 Loan Amt")]
        public decimal? HudLoanAmount6 { get => _hudLoanAmount6; set => SetField(ref _hudLoanAmount6, value); }
        private DirtyValue<decimal?> _hudLoanAmount7;
        /// <summary>
        /// HUD Property Improve Liability 7 Loan Amt [CAPIAP.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 7 Loan Amt")]
        public decimal? HudLoanAmount7 { get => _hudLoanAmount7; set => SetField(ref _hudLoanAmount7, value); }
        private DirtyValue<decimal?> _hudLoanAmount8;
        /// <summary>
        /// HUD Property Improve Liability 8 Loan Amt [CAPIAP.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 8 Loan Amt")]
        public decimal? HudLoanAmount8 { get => _hudLoanAmount8; set => SetField(ref _hudLoanAmount8, value); }
        private DirtyValue<decimal?> _hudLoanAmount9;
        /// <summary>
        /// HUD Property Improve Liability 9 Loan Amt [CAPIAP.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 9 Loan Amt")]
        public decimal? HudLoanAmount9 { get => _hudLoanAmount9; set => SetField(ref _hudLoanAmount9, value); }
        private DirtyValue<bool?> _hudRealEstateFhaInsured1;
        /// <summary>
        /// HUD Property Improve RE 1 FHA Insured [CAPIAP.X28]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured1 { get => _hudRealEstateFhaInsured1; set => SetField(ref _hudRealEstateFhaInsured1, value); }
        private DirtyValue<bool?> _hudRealEstateFhaInsured2;
        /// <summary>
        /// HUD Property Improve RE 2 FHA Insured [CAPIAP.X30]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured2 { get => _hudRealEstateFhaInsured2; set => SetField(ref _hudRealEstateFhaInsured2, value); }
        private DirtyValue<string> _hudRealEstateLienHolder1;
        /// <summary>
        /// HUD Property Improve RE 1 Lienholder [CAPIAP.X148]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 Lienholder")]
        public string HudRealEstateLienHolder1 { get => _hudRealEstateLienHolder1; set => SetField(ref _hudRealEstateLienHolder1, value); }
        private DirtyValue<string> _hudRealEstateLienHolder2;
        /// <summary>
        /// HUD Property Improve RE 2 Lienholder [CAPIAP.X149]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 Lienholder")]
        public string HudRealEstateLienHolder2 { get => _hudRealEstateLienHolder2; set => SetField(ref _hudRealEstateLienHolder2, value); }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount1;
        /// <summary>
        /// HUD Property Improve RE 1 Loan Amt [CAPIAP.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Loan Amt")]
        public decimal? HudRealEstateLoanAmount1 { get => _hudRealEstateLoanAmount1; set => SetField(ref _hudRealEstateLoanAmount1, value); }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount2;
        /// <summary>
        /// HUD Property Improve RE 2 Loan Amt [CAPIAP.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Loan Amt")]
        public decimal? HudRealEstateLoanAmount2 { get => _hudRealEstateLoanAmount2; set => SetField(ref _hudRealEstateLoanAmount2, value); }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment1;
        /// <summary>
        /// HUD Property Improve RE 1 Mo Pymt [CAPIAP.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment1 { get => _hudRealEstateMonthlyPayment1; set => SetField(ref _hudRealEstateMonthlyPayment1, value); }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment2;
        /// <summary>
        /// HUD Property Improve RE 2 Mo Pymt [CAPIAP.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment2 { get => _hudRealEstateMonthlyPayment2; set => SetField(ref _hudRealEstateMonthlyPayment2, value); }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance1;
        /// <summary>
        /// HUD Property Improve RE 1 Present Bal [CAPIAP.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Present Bal")]
        public decimal? HudRealEstatePresentBalance1 { get => _hudRealEstatePresentBalance1; set => SetField(ref _hudRealEstatePresentBalance1, value); }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance2;
        /// <summary>
        /// HUD Property Improve RE 2 Present Bal [CAPIAP.X152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Present Bal")]
        public decimal? HudRealEstatePresentBalance2 { get => _hudRealEstatePresentBalance2; set => SetField(ref _hudRealEstatePresentBalance2, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Application Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyList<Income> _income;
        /// <summary>
        /// Application Income
        /// </summary>
        public IList<Income> Income { get => GetField(ref _income); set => SetField(ref _income, value); }
        private DirtyValue<bool?> _incomeOfBorrowersSpouseUsedIndicator;
        /// <summary>
        /// Trans Details Income of Spouse will not be used [35]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Spouse will not be used", OptionsJson = "{\"true\":\"The income/assets of the Borrower's spouse will not be used..\"}")]
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get => _incomeOfBorrowersSpouseUsedIndicator; set => SetField(ref _incomeOfBorrowersSpouseUsedIndicator, value); }
        private DirtyValue<bool?> _incomeOtherThanBorrowerUsedIndicator;
        /// <summary>
        /// Trans Details Income of Other will be used [307]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Other will be used", OptionsJson = "{\"true\":\"The income/assets of a person other than Borrower will be used...\"}")]
        public bool? IncomeOtherThanBorrowerUsedIndicator { get => _incomeOtherThanBorrowerUsedIndicator; set => SetField(ref _incomeOtherThanBorrowerUsedIndicator, value); }
        private DirtyValue<bool?> _jointAssetLiabilityReportingIndicator;
        /// <summary>
        /// Assets/Liabilities Completed Jointly/Not Jointly [181]
        /// </summary>
        [LoanFieldProperty(Description = "Assets/Liabilities Completed Jointly/Not Jointly")]
        public bool? JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => SetField(ref _jointAssetLiabilityReportingIndicator, value); }
        private DirtyValue<string> _lastModified;
        /// <summary>
        /// Application LastModified
        /// </summary>
        public string LastModified { get => _lastModified; set => SetField(ref _lastModified, value); }
        private DirtyList<Liability> _liabilities;
        /// <summary>
        /// Application Liabilities
        /// </summary>
        public IList<Liability> Liabilities { get => GetField(ref _liabilities); set => SetField(ref _liabilities, value); }
        private DirtyValue<decimal?> _liquidAssetsComortSet;
        /// <summary>
        /// Assets Co-Borr Liquid Assets [267]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Co-Borr Liquid Assets")]
        public decimal? LiquidAssetsComortSet { get => _liquidAssetsComortSet; set => SetField(ref _liquidAssetsComortSet, value); }
        private DirtyValue<string> _loanAmount;
        /// <summary>
        /// Application LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }
        private DirtyValue<string> _loanOfficerId;
        /// <summary>
        /// Application LoanOfficerId
        /// </summary>
        public string LoanOfficerId { get => _loanOfficerId; set => SetField(ref _loanOfficerId, value); }
        private DirtyValue<string> _loanOfficerName;
        /// <summary>
        /// Application LoanOfficerName
        /// </summary>
        public string LoanOfficerName { get => _loanOfficerName; set => SetField(ref _loanOfficerName, value); }
        private DirtyValue<decimal?> _mcawBorrowerOtherMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Borr Other Mo Income [936]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Borr Other Mo Income")]
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => _mcawBorrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawBorrowerOtherMonthlyIncomeAmount, value); }
        private DirtyValue<decimal?> _mcawCoborrowerOtherMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Co-Borr Other Mo Income [938]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Co-Borr Other Mo Income")]
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => _mcawCoborrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawCoborrowerOtherMonthlyIncomeAmount, value); }
        private DirtyValue<decimal?> _mcawGrossMonthlyIncomeAmount;
        /// <summary>
        /// FHA MCAW Total Gross Mo Income [1761]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Gross Mo Income")]
        public decimal? McawGrossMonthlyIncomeAmount { get => _mcawGrossMonthlyIncomeAmount; set => SetField(ref _mcawGrossMonthlyIncomeAmount, value); }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome1Amount;
        /// <summary>
        /// FHA MCAW Mtg Pymt-to-Income Ratio [MCAWPUR.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Mtg Pymt-to-Income Ratio")]
        public decimal? McawMortgagePaymentToIncome1Amount { get => _mcawMortgagePaymentToIncome1Amount; set => SetField(ref _mcawMortgagePaymentToIncome1Amount, value); }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome2Amount;
        /// <summary>
        /// FHA MCAW Ratio Mtg Pymt-to-Income [GMCAW.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Mtg Pymt-to-Income")]
        public decimal? McawMortgagePaymentToIncome2Amount { get => _mcawMortgagePaymentToIncome2Amount; set => SetField(ref _mcawMortgagePaymentToIncome2Amount, value); }
        private DirtyValue<decimal?> _mcawOtherAmount;
        /// <summary>
        /// FHA MCAW Liabilities Other [1161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Other")]
        public decimal? McawOtherAmount { get => _mcawOtherAmount; set => SetField(ref _mcawOtherAmount, value); }
        private DirtyValue<decimal?> _mcawOtherDebtsAndObligationsAmount;
        /// <summary>
        /// FHA MCAW Liabilities Unpaid Bal [1163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Unpaid Bal")]
        public decimal? McawOtherDebtsAndObligationsAmount { get => _mcawOtherDebtsAndObligationsAmount; set => SetField(ref _mcawOtherDebtsAndObligationsAmount, value); }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForPurchaseAmount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt [MCAWPUR.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get => _mcawTotalFixedPaymentForPurchaseAmount; set => SetField(ref _mcawTotalFixedPaymentForPurchaseAmount, value); }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForRefinanceAmount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt [GMCAW.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get => _mcawTotalFixedPaymentForRefinanceAmount; set => SetField(ref _mcawTotalFixedPaymentForRefinanceAmount, value); }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome1Amount;
        /// <summary>
        /// FHA MCAW Total Fixed Pymt-to-Income Ratio [MCAWPUR.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt-to-Income Ratio")]
        public decimal? McawTotalFixedPaymentToIncome1Amount { get => _mcawTotalFixedPaymentToIncome1Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome1Amount, value); }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome2Amount;
        /// <summary>
        /// FHA MCAW Ratio Total Fixed Pymt-to-Income [GMCAW.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Total Fixed Pymt-to-Income")]
        public decimal? McawTotalFixedPaymentToIncome2Amount { get => _mcawTotalFixedPaymentToIncome2Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome2Amount, value); }
        private DirtyValue<decimal?> _mcawTotalMonthlyPaymentsAmount;
        /// <summary>
        /// FHA MCAW Liabilities Total Mo Pymt [1150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Liabilities Total Mo Pymt")]
        public decimal? McawTotalMonthlyPaymentsAmount { get => _mcawTotalMonthlyPaymentsAmount; set => SetField(ref _mcawTotalMonthlyPaymentsAmount, value); }
        private DirtyValue<decimal?> _mcawTotalMortgagePaymentAmount;
        /// <summary>
        /// FHA MCAW Total Mtg Pymt [739]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Mtg Pymt")]
        public decimal? McawTotalMortgagePaymentAmount { get => _mcawTotalMortgagePaymentAmount; set => SetField(ref _mcawTotalMortgagePaymentAmount, value); }
        private DirtyValue<decimal?> _monthlyExpenseComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor [1384]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor")]
        public decimal? MonthlyExpenseComortSet { get => _monthlyExpenseComortSet; set => SetField(ref _monthlyExpenseComortSet, value); }
        private DirtyValue<decimal?> _monthlyHousingExpenseAmount;
        /// <summary>
        /// Expenses Total Housing Expense [1809]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Housing Expense")]
        public decimal? MonthlyHousingExpenseAmount { get => _monthlyHousingExpenseAmount; set => SetField(ref _monthlyHousingExpenseAmount, value); }
        private DirtyValue<decimal?> _monthlyInstallmentExpenseAmount;
        /// <summary>
        /// Expenses Total Mo Installment Exp [382]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Installment Exp")]
        public decimal? MonthlyInstallmentExpenseAmount { get => _monthlyInstallmentExpenseAmount; set => SetField(ref _monthlyInstallmentExpenseAmount, value); }
        private DirtyValue<decimal?> _monthlyNegativeRealEstateAmount;
        /// <summary>
        /// Expenses Negative Real Estate [LOANSUB.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Negative Real Estate")]
        public decimal? MonthlyNegativeRealEstateAmount { get => _monthlyNegativeRealEstateAmount; set => SetField(ref _monthlyNegativeRealEstateAmount, value); }
        private DirtyValue<decimal?> _monthlySecondHomeAmount;
        /// <summary>
        /// Expenses 2nd/Vacation Home [1476]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses 2nd/Vacation Home")]
        public decimal? MonthlySecondHomeAmount { get => _monthlySecondHomeAmount; set => SetField(ref _monthlySecondHomeAmount, value); }
        private DirtyValue<string> _mortgageInsuranceAmount;
        /// <summary>
        /// Expenses Present MTG Ins [124]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present MTG Ins")]
        public string MortgageInsuranceAmount { get => _mortgageInsuranceAmount; set => SetField(ref _mortgageInsuranceAmount, value); }
        private DirtyValue<decimal?> _netWorthAmount;
        /// <summary>
        /// Liabilities Net Worth [734]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Net Worth")]
        public decimal? NetWorthAmount { get => _netWorthAmount; set => SetField(ref _netWorthAmount, value); }
        private DirtyValue<decimal?> _otherHousingExpenseAmount;
        /// <summary>
        /// Expenses Present Other Housing [126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Housing")]
        public decimal? OtherHousingExpenseAmount { get => _otherHousingExpenseAmount; set => SetField(ref _otherHousingExpenseAmount, value); }
        private DirtyValue<decimal?> _otherItemsDeducted;
        /// <summary>
        /// Income Deductions Other Items Deducted [198]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Deductions Other Items Deducted")]
        public decimal? OtherItemsDeducted { get => _otherItemsDeducted; set => SetField(ref _otherItemsDeducted, value); }
        private DirtyValue<decimal?> _otherMortgagePrincipalAndInterestAmount;
        /// <summary>
        /// Expenses Present Other Pymt [121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Pymt")]
        public decimal? OtherMortgagePrincipalAndInterestAmount { get => _otherMortgagePrincipalAndInterestAmount; set => SetField(ref _otherMortgagePrincipalAndInterestAmount, value); }
        private DirtyValue<StringEnumValue<PastCreditRecord>> _pastCreditRecord;
        /// <summary>
        /// VA Past Credit Record [1326]
        /// </summary>
        [LoanFieldProperty(Description = "VA Past Credit Record")]
        public StringEnumValue<PastCreditRecord> PastCreditRecord { get => _pastCreditRecord; set => SetField(ref _pastCreditRecord, value); }
        private DirtyValue<decimal?> _presentHousingExpComortSet;
        /// <summary>
        /// Expenses Co-Borr Present Mo Hous Exp [268]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Co-Borr Present Mo Hous Exp")]
        public decimal? PresentHousingExpComortSet { get => _presentHousingExpComortSet; set => SetField(ref _presentHousingExpComortSet, value); }
        private DirtyValue<decimal?> _primaryResidenceComortSet;
        /// <summary>
        /// Underwriting Co-Mortgagor Primary Exp [1379]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Primary Exp")]
        public decimal? PrimaryResidenceComortSet { get => _primaryResidenceComortSet; set => SetField(ref _primaryResidenceComortSet, value); }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        /// <summary>
        /// Subject Property Occupancy Status [1811]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Occupancy Status")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }
        private DirtyValue<string> _proposedDuesAmount;
        /// <summary>
        /// Underwriting HOA Fees [1729]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting HOA Fees")]
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => SetField(ref _proposedDuesAmount, value); }
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        /// <summary>
        /// Underwriting First Mtg P&amp;I [1724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting First Mtg P&I")]
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => SetField(ref _proposedFirstMortgageAmount, value); }
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        /// <summary>
        /// Underwriting Rent [1723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Rent")]
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => SetField(ref _proposedGroundRentAmount, value); }
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        /// <summary>
        /// Underwriting Hazard Ins [1726]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Hazard Ins")]
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => SetField(ref _proposedHazardInsuranceAmount, value); }
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        /// <summary>
        /// Insurance Mtg Ins Mo Pymt [1728]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Mtg Ins Mo Pymt")]
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => SetField(ref _proposedMortgageInsuranceAmount, value); }
        private DirtyValue<decimal?> _proposedOtherAmount;
        /// <summary>
        /// Underwriting Other Fees [1730]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Other Fees")]
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => SetField(ref _proposedOtherAmount, value); }
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        /// <summary>
        /// Underwriting Second Mtg P&amp;I [1725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Second Mtg P&I")]
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => SetField(ref _proposedOtherMortgagesAmount, value); }
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        /// <summary>
        /// Underwriting Taxes [1727]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Taxes")]
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => SetField(ref _proposedRealEstateTaxesAmount, value); }
        private DirtyValue<string> _realEstateTaxAmount;
        /// <summary>
        /// Expenses Present Taxes [123]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Taxes")]
        public string RealEstateTaxAmount { get => _realEstateTaxAmount; set => SetField(ref _realEstateTaxAmount, value); }
        private DirtyValue<decimal?> _rentAmount;
        /// <summary>
        /// Expenses Present Rent [119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Rent")]
        public decimal? RentAmount { get => _rentAmount; set => SetField(ref _rentAmount, value); }
        private DirtyList<ReoProperty> _reoProperties;
        /// <summary>
        /// Application ReoProperties
        /// </summary>
        public IList<ReoProperty> ReoProperties { get => GetField(ref _reoProperties); set => SetField(ref _reoProperties, value); }
        private DirtyValue<decimal?> _reoTotalGrossRentalIncomeAmount;
        /// <summary>
        /// Income Total Gross Rent Income [921]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Gross Rent Income")]
        public decimal? ReoTotalGrossRentalIncomeAmount { get => _reoTotalGrossRentalIncomeAmount; set => SetField(ref _reoTotalGrossRentalIncomeAmount, value); }
        private DirtyValue<decimal?> _reoTotalMaintenanceAmount;
        /// <summary>
        /// Income Total Ins/Tax/Exp Income [923]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Ins/Tax/Exp Income")]
        public decimal? ReoTotalMaintenanceAmount { get => _reoTotalMaintenanceAmount; set => SetField(ref _reoTotalMaintenanceAmount, value); }
        private DirtyValue<decimal?> _reoTotalMarketValueAmount;
        /// <summary>
        /// Assets Real Estate Owned [919]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Real Estate Owned")]
        public decimal? ReoTotalMarketValueAmount { get => _reoTotalMarketValueAmount; set => SetField(ref _reoTotalMarketValueAmount, value); }
        private DirtyValue<decimal?> _reoTotalMortgagePaymentsAmount;
        /// <summary>
        /// Income Total Mortgage Pymts Income [922]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mortgage Pymts Income")]
        public decimal? ReoTotalMortgagePaymentsAmount { get => _reoTotalMortgagePaymentsAmount; set => SetField(ref _reoTotalMortgagePaymentsAmount, value); }
        private DirtyValue<decimal?> _reoTotalMortgagesAndLiensAmount;
        /// <summary>
        /// Income Total Amt of Mortgages Income [920]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Amt of Mortgages Income")]
        public decimal? ReoTotalMortgagesAndLiensAmount { get => _reoTotalMortgagesAndLiensAmount; set => SetField(ref _reoTotalMortgagesAndLiensAmount, value); }
        private DirtyValue<int?> _reoTotalNetRentalIncomeAmount;
        /// <summary>
        /// Income Total Net Rental Income [924]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Income Total Net Rental Income")]
        public int? ReoTotalNetRentalIncomeAmount { get => _reoTotalNetRentalIncomeAmount; set => SetField(ref _reoTotalNetRentalIncomeAmount, value); }
        private DirtyList<Residence> _residences;
        /// <summary>
        /// Application Residences
        /// </summary>
        public IList<Residence> Residences { get => GetField(ref _residences); set => SetField(ref _residences, value); }
        private DirtyValue<string> _respa6;
        /// <summary>
        /// Application Respa6
        /// </summary>
        public string Respa6 { get => _respa6; set => SetField(ref _respa6, value); }
        private DirtyList<SelfEmployedIncome> _selfEmployedIncomes;
        /// <summary>
        /// Application SelfEmployedIncomes
        /// </summary>
        public IList<SelfEmployedIncome> SelfEmployedIncomes { get => GetField(ref _selfEmployedIncomes); set => SetField(ref _selfEmployedIncomes, value); }
        private DirtyValue<string> _sofDBorrowerAddress;
        /// <summary>
        /// Denial Discl Info - Borrower Address [DENIAL.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address")]
        public string SofDBorrowerAddress { get => _sofDBorrowerAddress; set => SetField(ref _sofDBorrowerAddress, value); }
        private DirtyValue<string> _sofDBorrowerAddressCity;
        /// <summary>
        /// Denial Discl Info - Borrower Address - City [DENIAL.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address - City")]
        public string SofDBorrowerAddressCity { get => _sofDBorrowerAddressCity; set => SetField(ref _sofDBorrowerAddressCity, value); }
        private DirtyValue<StringEnumValue<State>> _sofDBorrowerAddressState;
        /// <summary>
        /// Denial Discl Info - Borrower Address - State [DENIAL.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address - State")]
        public StringEnumValue<State> SofDBorrowerAddressState { get => _sofDBorrowerAddressState; set => SetField(ref _sofDBorrowerAddressState, value); }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDBorrowerAddressType;
        /// <summary>
        /// Denial Discl Info - Borrower Address Type [DENIAL.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => _sofDBorrowerAddressType; set => SetField(ref _sofDBorrowerAddressType, value); }
        private DirtyValue<string> _sofDBorrowerAddressZipcode;
        /// <summary>
        /// Denial Discl Info - Borrower Address - Zipcode [DENIAL.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Borrower Address - Zipcode")]
        public string SofDBorrowerAddressZipcode { get => _sofDBorrowerAddressZipcode; set => SetField(ref _sofDBorrowerAddressZipcode, value); }
        private DirtyValue<string> _sofDCoBorrowerAddress;
        /// <summary>
        /// Denial Discl Info - Coborrower Address [DENIAL.X87]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address")]
        public string SofDCoBorrowerAddress { get => _sofDCoBorrowerAddress; set => SetField(ref _sofDCoBorrowerAddress, value); }
        private DirtyValue<string> _sofDCoBorrowerAddressCity;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - City [DENIAL.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address - City")]
        public string SofDCoBorrowerAddressCity { get => _sofDCoBorrowerAddressCity; set => SetField(ref _sofDCoBorrowerAddressCity, value); }
        private DirtyValue<StringEnumValue<State>> _sofDCoBorrowerAddressState;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - State [DENIAL.X89]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address - State")]
        public StringEnumValue<State> SofDCoBorrowerAddressState { get => _sofDCoBorrowerAddressState; set => SetField(ref _sofDCoBorrowerAddressState, value); }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDCoBorrowerAddressType;
        /// <summary>
        /// Denial Discl Info - Coborrower Address Type [DENIAL.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => _sofDCoBorrowerAddressType; set => SetField(ref _sofDCoBorrowerAddressType, value); }
        private DirtyValue<string> _sofDCoBorrowerAddressZipcode;
        /// <summary>
        /// Denial Discl Info - Coborrower Address - Zipcode [DENIAL.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Coborrower Address - Zipcode")]
        public string SofDCoBorrowerAddressZipcode { get => _sofDCoBorrowerAddressZipcode; set => SetField(ref _sofDCoBorrowerAddressZipcode, value); }
        private DirtyValue<bool?> _spouseIncomeConsider;
        /// <summary>
        /// VA Veteran Income Consider Spouse Income [1006]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Income Consider Spouse Income")]
        public bool? SpouseIncomeConsider { get => _spouseIncomeConsider; set => SetField(ref _spouseIncomeConsider, value); }
        private DirtyList<Tax4506> _tax4506s;
        /// <summary>
        /// Application Tax4506s
        /// </summary>
        public IList<Tax4506> Tax4506s { get => GetField(ref _tax4506s); set => SetField(ref _tax4506s, value); }
        private DirtyValue<decimal?> _topRatioPercent;
        /// <summary>
        /// Trans Details Qual Ratio Top [740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Trans Details Qual Ratio Top")]
        public decimal? TopRatioPercent { get => _topRatioPercent; set => SetField(ref _topRatioPercent, value); }
        private DirtyValue<decimal?> _totalAssetsAmount;
        /// <summary>
        /// Assets Total Assets [732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Assets")]
        public decimal? TotalAssetsAmount { get => _totalAssetsAmount; set => SetField(ref _totalAssetsAmount, value); }
        private DirtyValue<decimal?> _totalBaseIncomeAmount;
        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [901]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? TotalBaseIncomeAmount { get => _totalBaseIncomeAmount; set => SetField(ref _totalBaseIncomeAmount, value); }
        private DirtyValue<decimal?> _totalBonusAmount;
        /// <summary>
        /// Income Total Bonuses (Borr/Co-Borr) [903]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Bonuses (Borr/Co-Borr)")]
        public decimal? TotalBonusAmount { get => _totalBonusAmount; set => SetField(ref _totalBonusAmount, value); }
        private DirtyValue<decimal?> _totalCommissionsAmount;
        /// <summary>
        /// Income Total Commissions (Borr/Co-Borr) [904]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Commissions (Borr/Co-Borr)")]
        public decimal? TotalCommissionsAmount { get => _totalCommissionsAmount; set => SetField(ref _totalCommissionsAmount, value); }
        private DirtyValue<decimal?> _totalDeposit;
        /// <summary>
        /// Assets Total Bank Deposits [979]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Bank Deposits")]
        public decimal? TotalDeposit { get => _totalDeposit; set => SetField(ref _totalDeposit, value); }
        private DirtyValue<decimal?> _totalDividendsInterestAmount;
        /// <summary>
        /// Income Total Div/Int (Borr/Co-Borr) [905]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Div/Int (Borr/Co-Borr)")]
        public decimal? TotalDividendsInterestAmount { get => _totalDividendsInterestAmount; set => SetField(ref _totalDividendsInterestAmount, value); }
        private DirtyValue<decimal?> _totalEmploymentAmount;
        /// <summary>
        /// Income Total Mo Income Spouse/Borr [1810]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income Spouse/Borr")]
        public decimal? TotalEmploymentAmount { get => _totalEmploymentAmount; set => SetField(ref _totalEmploymentAmount, value); }
        private DirtyValue<decimal?> _totalFixedPaymentAmount;
        /// <summary>
        /// Expenses Total Mo Expense [1187]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Expense")]
        public decimal? TotalFixedPaymentAmount { get => _totalFixedPaymentAmount; set => SetField(ref _totalFixedPaymentAmount, value); }
        private DirtyValue<decimal?> _totalGrossMonthlyIncomeAmount;
        /// <summary>
        /// Income Total Mo Income (Borr/Co-Borr) [1389]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Income (Borr/Co-Borr)")]
        public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => SetField(ref _totalGrossMonthlyIncomeAmount, value); }
        private DirtyValue<decimal?> _totalIncomeAmount;
        /// <summary>
        /// Income Total Mo Income [736]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income")]
        public decimal? TotalIncomeAmount { get => _totalIncomeAmount; set => SetField(ref _totalIncomeAmount, value); }
        private DirtyValue<decimal?> _totalMonthlyPaymentAmount;
        /// <summary>
        /// Liabilities Total Liability Pymt [350]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Total Liability Pymt")]
        public decimal? TotalMonthlyPaymentAmount { get => _totalMonthlyPaymentAmount; set => SetField(ref _totalMonthlyPaymentAmount, value); }
        private DirtyValue<decimal?> _totalMortgagesBalanceAmount;
        /// <summary>
        /// Trans Details Total Mtg Bal [941]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Bal")]
        public decimal? TotalMortgagesBalanceAmount { get => _totalMortgagesBalanceAmount; set => SetField(ref _totalMortgagesBalanceAmount, value); }
        private DirtyValue<decimal?> _totalMortgagesMonthlyPaymentAmount;
        /// <summary>
        /// Trans Details Total Mtg Mo Pymt [909]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Mo Pymt")]
        public decimal? TotalMortgagesMonthlyPaymentAmount { get => _totalMortgagesMonthlyPaymentAmount; set => SetField(ref _totalMortgagesMonthlyPaymentAmount, value); }
        private DirtyValue<decimal?> _totalNetRentalIncomeAmount;
        /// <summary>
        /// Income Total Net Rent Income (Borr/Co-Borr) [906]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Rent Income (Borr/Co-Borr)")]
        public decimal? TotalNetRentalIncomeAmount { get => _totalNetRentalIncomeAmount; set => SetField(ref _totalNetRentalIncomeAmount, value); }
        private DirtyValue<decimal?> _totalOther1Amount;
        /// <summary>
        /// Income Total Other 1 (Borr/Co-Borr) [907]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 1 (Borr/Co-Borr)")]
        public decimal? TotalOther1Amount { get => _totalOther1Amount; set => SetField(ref _totalOther1Amount, value); }
        private DirtyValue<decimal?> _totalOther2Amount;
        /// <summary>
        /// Income Total Other 2 (Borr/Co-Borr) [908]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 2 (Borr/Co-Borr)")]
        public decimal? TotalOther2Amount { get => _totalOther2Amount; set => SetField(ref _totalOther2Amount, value); }
        private DirtyValue<decimal?> _totalOvertimeAmount;
        /// <summary>
        /// Income Total Overtime (Borr/Co-Borr) [902]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Overtime (Borr/Co-Borr)")]
        public decimal? TotalOvertimeAmount { get => _totalOvertimeAmount; set => SetField(ref _totalOvertimeAmount, value); }
        private DirtyValue<decimal?> _totalPaymentsAmount;
        /// <summary>
        /// Trans Details Total Proposed Mo Pymt [1742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Proposed Mo Pymt")]
        public decimal? TotalPaymentsAmount { get => _totalPaymentsAmount; set => SetField(ref _totalPaymentsAmount, value); }
        private DirtyValue<decimal?> _totalPrimaryHousingExpenseAmount;
        /// <summary>
        /// Expenses Total Primary Expenses [1731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Primary Expenses")]
        public decimal? TotalPrimaryHousingExpenseAmount { get => _totalPrimaryHousingExpenseAmount; set => SetField(ref _totalPrimaryHousingExpenseAmount, value); }
        private DirtyValue<decimal?> _totalReoMarketValueAmount;
        /// <summary>
        /// Application TotalReoMarketValueAmount
        /// </summary>
        public decimal? TotalReoMarketValueAmount { get => _totalReoMarketValueAmount; set => SetField(ref _totalReoMarketValueAmount, value); }
        private DirtyValue<decimal?> _totalUserDefinedIncome;
        /// <summary>
        /// Income Total Other Income (User Defined) [1817]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (User Defined)")]
        public decimal? TotalUserDefinedIncome { get => _totalUserDefinedIncome; set => SetField(ref _totalUserDefinedIncome, value); }
        private DirtyList<TQLReportInformation> _tQLReports;
        /// <summary>
        /// Application TQLReports
        /// </summary>
        public IList<TQLReportInformation> TQLReports { get => GetField(ref _tQLReports); set => SetField(ref _tQLReports, value); }
        private DirtyValue<string> _transUnionAddress;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Addr [DISCLOSURE.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Addr")]
        public string TransUnionAddress { get => _transUnionAddress; set => SetField(ref _transUnionAddress, value); }
        private DirtyValue<string> _transUnionCity;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co City [DISCLOSURE.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co City")]
        public string TransUnionCity { get => _transUnionCity; set => SetField(ref _transUnionCity, value); }
        private DirtyValue<string> _transUnionFax;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Fax [DISCLOSURE.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Fax")]
        public string TransUnionFax { get => _transUnionFax; set => SetField(ref _transUnionFax, value); }
        private DirtyValue<string> _transUnionModel;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Model [DISCLOSURE.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Model")]
        public string TransUnionModel { get => _transUnionModel; set => SetField(ref _transUnionModel, value); }
        private DirtyValue<string> _transUnionName;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Name [DISCLOSURE.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Name")]
        public string TransUnionName { get => _transUnionName; set => SetField(ref _transUnionName, value); }
        private DirtyValue<string> _transUnionPhone;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Phone [DISCLOSURE.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Phone")]
        public string TransUnionPhone { get => _transUnionPhone; set => SetField(ref _transUnionPhone, value); }
        private DirtyValue<string> _transUnionPostalCode;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Zip [DISCLOSURE.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 2 Co Zip")]
        public string TransUnionPostalCode { get => _transUnionPostalCode; set => SetField(ref _transUnionPostalCode, value); }
        private DirtyValue<string> _transUnionScoreRangeFrom;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores From [DISCLOSURE.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores From")]
        public string TransUnionScoreRangeFrom { get => _transUnionScoreRangeFrom; set => SetField(ref _transUnionScoreRangeFrom, value); }
        private DirtyValue<string> _transUnionScoreRangeTo;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores To [DISCLOSURE.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores To")]
        public string TransUnionScoreRangeTo { get => _transUnionScoreRangeTo; set => SetField(ref _transUnionScoreRangeTo, value); }
        private DirtyValue<StringEnumValue<State>> _transUnionState;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co State [DISCLOSURE.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co State")]
        public StringEnumValue<State> TransUnionState { get => _transUnionState; set => SetField(ref _transUnionState, value); }
        private DirtyValue<string> _transUnionWebsite;
        /// <summary>
        /// Disclosure Cred Bureau 2 Co Website [DISCLOSURE.X639]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Website")]
        public string TransUnionWebsite { get => _transUnionWebsite; set => SetField(ref _transUnionWebsite, value); }
        private DirtyValue<decimal?> _userDefinedIncome;
        /// <summary>
        /// Application UserDefinedIncome
        /// </summary>
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => SetField(ref _userDefinedIncome, value); }
        private DirtyValue<string> _userDefinedIncomeDescription;
        /// <summary>
        /// Income Borr/Co-Borr Other Income 2 Descr [1818]
        /// </summary>
        [LoanFieldProperty(Description = "Income Borr/Co-Borr Other Income 2 Descr")]
        public string UserDefinedIncomeDescription { get => _userDefinedIncomeDescription; set => SetField(ref _userDefinedIncomeDescription, value); }
        private DirtyValue<StringEnumValue<YOrN>> _vACreditStandards;
        /// <summary>
        /// VA Meets VA Credit Standards [1327]
        /// </summary>
        [LoanFieldProperty(Description = "VA Meets VA Credit Standards")]
        public StringEnumValue<YOrN> VACreditStandards { get => _vACreditStandards; set => SetField(ref _vACreditStandards, value); }
        private DirtyValue<decimal?> _vaSummarySpouseIncomeAmount;
        /// <summary>
        /// VA Veteran Income Spouse Income Amt [1008]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Veteran Income Spouse Income Amt")]
        public decimal? VaSummarySpouseIncomeAmount { get => _vaSummarySpouseIncomeAmount; set => SetField(ref _vaSummarySpouseIncomeAmount, value); }
        private DirtyValue<decimal?> _vaSummaryTotalMonthlyGrossIncomeAmount;
        /// <summary>
        /// Income Total Mo Gross Income [993]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Gross Income")]
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => _vaSummaryTotalMonthlyGrossIncomeAmount; set => SetField(ref _vaSummaryTotalMonthlyGrossIncomeAmount, value); }
    }
}