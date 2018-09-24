using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Application
    /// </summary>
    public sealed partial class Application : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountNumber1;
        private DirtyValue<string> _accountNumber2;
        private DirtyValue<decimal?> _allOtherPaymentsAmount;
        private DirtyValue<string> _applicationId;
        private DirtyValue<int?> _applicationIndex;
        private DirtyValue<DateTime?> _applicationSignedDate;
        private DirtyList<Asset> _assets;
        private DirtyValue<decimal?> _assetsAvailableAmount;
        private ATRQMBorrower _aTRQMBorrower;
        private DirtyList<ATRQMBorrower> _aTRQMBorrowers;
        private DirtyList<AUSTrackingLog> _aUSTrackingLogs;
        private DirtyValue<decimal?> _balanceAvailableFamilySupportGuideline;
        private Borrower _borrower;
        private DirtyValue<decimal?> _bottomRatioPercent;
        private DirtyValue<decimal?> _brwCoBrwTotalTaxDeductions;
        private Borrower _coborrower;
        private DirtyValue<string> _creditAliasName1;
        private DirtyValue<string> _creditAliasName2;
        private DirtyValue<string> _creditorName1;
        private DirtyValue<string> _creditorName2;
        private DirtyValue<string> _creditReportReferenceIdentifier;
        private DirtyList<Employment> _employment;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<string> _equifaxAddress;
        private DirtyValue<string> _equifaxCity;
        private DirtyValue<string> _equifaxFax;
        private DirtyValue<string> _equifaxModel;
        private DirtyValue<string> _equifaxName;
        private DirtyValue<string> _equifaxPhone;
        private DirtyValue<string> _equifaxPostalCode;
        private DirtyValue<string> _equifaxScoreRangeFrom;
        private DirtyValue<string> _equifaxScoreRangeTo;
        private DirtyValue<StringEnumValue<State>> _equifaxState;
        private DirtyValue<string> _equifaxWebsite;
        private DirtyValue<string> _experianAddress;
        private DirtyValue<string> _experianCity;
        private DirtyValue<string> _experianFax;
        private DirtyValue<string> _experianModel;
        private DirtyValue<string> _experianName;
        private DirtyValue<string> _experianPhone;
        private DirtyValue<string> _experianPostalCode;
        private DirtyValue<string> _experianScoreRangeFrom;
        private DirtyValue<string> _experianScoreRangeTo;
        private DirtyValue<StringEnumValue<State>> _experianState;
        private DirtyValue<string> _experianWebsite;
        private DirtyValue<decimal?> _fhaVaDebtIncomeRatio;
        private DirtyValue<decimal?> _fhaVaFamilySupportAmount;
        private DirtyValue<decimal?> _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
        private DirtyValue<decimal?> _fhaVaTotalNetEffectiveIncomeAmount;
        private DirtyValue<decimal?> _fhaVaTotalNetIncomeAmount;
        private DirtyValue<decimal?> _fhaVaTotalNetTakeHomePayAmount;
        private DirtyValue<decimal?> _fhaVaTotalOtherNetIncome;
        private DirtyValue<decimal?> _firstMortgagePrincipalAndInterestAmount;
        private DirtyValue<string> _freddieMacCreditReportReferenceIdentifier;
        private DirtyValue<decimal?> _freddieMacOccupantDebtRatio;
        private DirtyValue<decimal?> _freddieMacOccupantHousingRatio;
        private DirtyValue<decimal?> _freDebtToHousingGapRatio;
        private DirtyValue<decimal?> _grossBaseIncomeAmount;
        private DirtyValue<decimal?> _grossIncomeForComortSet;
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        private DirtyValue<decimal?> _grossOtherIncomeAmount;
        private DirtyValue<decimal?> _grossPositiveCashFlow;
        private DirtyValue<string> _hazardInsuranceAmount;
        private DirtyValue<string> _homeownersAssociationDuesAndCondoFeesAmount;
        private DirtyValue<string> _hudAutoLienHolderName1;
        private DirtyValue<string> _hudAutoLienHolderName2;
        private DirtyValue<decimal?> _hudAutoLoanAmount1;
        private DirtyValue<decimal?> _hudAutoLoanAmount2;
        private DirtyValue<decimal?> _hudAutoMonthlyPayment1;
        private DirtyValue<decimal?> _hudAutoMonthlyPayment2;
        private DirtyValue<decimal?> _hudAutoPresentBalance1;
        private DirtyValue<decimal?> _hudAutoPresentBalance2;
        private DirtyValue<string> _hudAutoYearAndMake1;
        private DirtyValue<string> _hudAutoYearAndMake2;
        private DirtyValue<decimal?> _hudLoanAmount1;
        private DirtyValue<decimal?> _hudLoanAmount10;
        private DirtyValue<decimal?> _hudLoanAmount11;
        private DirtyValue<decimal?> _hudLoanAmount2;
        private DirtyValue<decimal?> _hudLoanAmount3;
        private DirtyValue<decimal?> _hudLoanAmount4;
        private DirtyValue<decimal?> _hudLoanAmount5;
        private DirtyValue<decimal?> _hudLoanAmount6;
        private DirtyValue<decimal?> _hudLoanAmount7;
        private DirtyValue<decimal?> _hudLoanAmount8;
        private DirtyValue<decimal?> _hudLoanAmount9;
        private DirtyValue<bool?> _hudRealEstateFhaInsured1;
        private DirtyValue<bool?> _hudRealEstateFhaInsured2;
        private DirtyValue<string> _hudRealEstateLienHolder1;
        private DirtyValue<string> _hudRealEstateLienHolder2;
        private DirtyValue<decimal?> _hudRealEstateLoanAmount1;
        private DirtyValue<decimal?> _hudRealEstateLoanAmount2;
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment1;
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment2;
        private DirtyValue<decimal?> _hudRealEstatePresentBalance1;
        private DirtyValue<decimal?> _hudRealEstatePresentBalance2;
        private DirtyValue<string> _id;
        private DirtyList<Income> _income;
        private DirtyValue<bool?> _incomeOfBorrowersSpouseUsedIndicator;
        private DirtyValue<bool?> _incomeOtherThanBorrowerUsedIndicator;
        private DirtyValue<bool?> _jointAssetLiabilityReportingIndicator;
        private DirtyValue<string> _lastModified;
        private DirtyList<Liability> _liabilities;
        private DirtyValue<decimal?> _liquidAssetsComortSet;
        private DirtyValue<string> _loanAmount;
        private DirtyValue<string> _loanOfficerId;
        private DirtyValue<string> _loanOfficerName;
        private DirtyValue<decimal?> _mcawBorrowerOtherMonthlyIncomeAmount;
        private DirtyValue<decimal?> _mcawCoborrowerOtherMonthlyIncomeAmount;
        private DirtyValue<decimal?> _mcawGrossMonthlyIncomeAmount;
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome1Amount;
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome2Amount;
        private DirtyValue<decimal?> _mcawOtherAmount;
        private DirtyValue<decimal?> _mcawOtherDebtsAndObligationsAmount;
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForPurchaseAmount;
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForRefinanceAmount;
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome1Amount;
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome2Amount;
        private DirtyValue<decimal?> _mcawTotalMonthlyPaymentsAmount;
        private DirtyValue<decimal?> _mcawTotalMortgagePaymentAmount;
        private DirtyValue<decimal?> _monthlyExpenseComortSet;
        private DirtyValue<decimal?> _monthlyHousingExpenseAmount;
        private DirtyValue<decimal?> _monthlyInstallmentExpenseAmount;
        private DirtyValue<decimal?> _monthlyNegativeRealEstateAmount;
        private DirtyValue<decimal?> _monthlySecondHomeAmount;
        private DirtyValue<string> _mortgageInsuranceAmount;
        private DirtyValue<decimal?> _netWorthAmount;
        private DirtyValue<decimal?> _otherHousingExpenseAmount;
        private DirtyValue<decimal?> _otherItemsDeducted;
        private DirtyValue<decimal?> _otherMortgagePrincipalAndInterestAmount;
        private DirtyValue<StringEnumValue<PastCreditRecord>> _pastCreditRecord;
        private DirtyValue<decimal?> _presentHousingExpComortSet;
        private DirtyValue<decimal?> _primaryResidenceComortSet;
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        private DirtyValue<string> _proposedDuesAmount;
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        private DirtyValue<decimal?> _proposedOtherAmount;
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        private DirtyValue<string> _realEstateTaxAmount;
        private DirtyValue<decimal?> _rentAmount;
        private DirtyList<ReoProperty> _reoProperties;
        private DirtyValue<decimal?> _reoTotalGrossRentalIncomeAmount;
        private DirtyValue<decimal?> _reoTotalMaintenanceAmount;
        private DirtyValue<decimal?> _reoTotalMarketValueAmount;
        private DirtyValue<decimal?> _reoTotalMortgagePaymentsAmount;
        private DirtyValue<decimal?> _reoTotalMortgagesAndLiensAmount;
        private DirtyValue<int?> _reoTotalNetRentalIncomeAmount;
        private DirtyList<Residence> _residences;
        private DirtyValue<string> _respa6;
        private DirtyList<SelfEmployedIncome> _selfEmployedIncomes;
        private DirtyValue<string> _sofDBorrowerAddress;
        private DirtyValue<string> _sofDBorrowerAddressCity;
        private DirtyValue<StringEnumValue<State>> _sofDBorrowerAddressState;
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDBorrowerAddressType;
        private DirtyValue<string> _sofDBorrowerAddressZipcode;
        private DirtyValue<string> _sofDCoBorrowerAddress;
        private DirtyValue<string> _sofDCoBorrowerAddressCity;
        private DirtyValue<StringEnumValue<State>> _sofDCoBorrowerAddressState;
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDCoBorrowerAddressType;
        private DirtyValue<string> _sofDCoBorrowerAddressZipcode;
        private DirtyValue<bool?> _spouseIncomeConsider;
        private DirtyList<Tax4506> _tax4506s;
        private DirtyValue<decimal?> _topRatioPercent;
        private DirtyValue<decimal?> _totalAssetsAmount;
        private DirtyValue<decimal?> _totalBaseIncomeAmount;
        private DirtyValue<decimal?> _totalBonusAmount;
        private DirtyValue<decimal?> _totalCommissionsAmount;
        private DirtyValue<decimal?> _totalDeposit;
        private DirtyValue<decimal?> _totalDividendsInterestAmount;
        private DirtyValue<decimal?> _totalEmploymentAmount;
        private DirtyValue<decimal?> _totalFixedPaymentAmount;
        private DirtyValue<decimal?> _totalGrossMonthlyIncomeAmount;
        private DirtyValue<decimal?> _totalIncomeAmount;
        private DirtyValue<decimal?> _totalMonthlyPaymentAmount;
        private DirtyValue<decimal?> _totalMortgagesBalanceAmount;
        private DirtyValue<decimal?> _totalMortgagesMonthlyPaymentAmount;
        private DirtyValue<decimal?> _totalNetRentalIncomeAmount;
        private DirtyValue<decimal?> _totalOther1Amount;
        private DirtyValue<decimal?> _totalOther2Amount;
        private DirtyValue<decimal?> _totalOvertimeAmount;
        private DirtyValue<decimal?> _totalPaymentsAmount;
        private DirtyValue<decimal?> _totalPrimaryHousingExpenseAmount;
        private DirtyValue<decimal?> _totalReoMarketValueAmount;
        private DirtyValue<decimal?> _totalUserDefinedIncome;
        private DirtyList<TQLReportInformation> _tQLReports;
        private DirtyValue<string> _transUnionAddress;
        private DirtyValue<string> _transUnionCity;
        private DirtyValue<string> _transUnionFax;
        private DirtyValue<string> _transUnionModel;
        private DirtyValue<string> _transUnionName;
        private DirtyValue<string> _transUnionPhone;
        private DirtyValue<string> _transUnionPostalCode;
        private DirtyValue<string> _transUnionScoreRangeFrom;
        private DirtyValue<string> _transUnionScoreRangeTo;
        private DirtyValue<StringEnumValue<State>> _transUnionState;
        private DirtyValue<string> _transUnionWebsite;
        private DirtyValue<decimal?> _userDefinedIncome;
        private DirtyValue<string> _userDefinedIncomeDescription;
        private DirtyValue<StringEnumValue<YOrN>> _vACreditStandards;
        private DirtyValue<decimal?> _vaSummarySpouseIncomeAmount;
        private DirtyValue<decimal?> _vaSummaryTotalMonthlyGrossIncomeAmount;

        /// <summary>
        /// Liabilities Alternate Acct # 1 [1735]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Acct # 1")]
        public string AccountNumber1 { get => _accountNumber1; set => SetField(ref _accountNumber1, value); }

        /// <summary>
        /// Liabilities Alternate Acct # 2 [1737]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Acct # 2")]
        public string AccountNumber2 { get => _accountNumber2; set => SetField(ref _accountNumber2, value); }

        /// <summary>
        /// Underwriting All Other Pymts [1733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting All Other Pymts")]
        public decimal? AllOtherPaymentsAmount { get => _allOtherPaymentsAmount; set => SetField(ref _allOtherPaymentsAmount, value); }

        /// <summary>
        /// Application ApplicationId
        /// </summary>
        public string ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }

        /// <summary>
        /// Application ApplicationIndex
        /// </summary>
        public int? ApplicationIndex { get => _applicationIndex; set => SetField(ref _applicationIndex, value); }

        /// <summary>
        /// Fannie Mae Signature Date [MORNET.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Signature Date")]
        public DateTime? ApplicationSignedDate { get => _applicationSignedDate; set => SetField(ref _applicationSignedDate, value); }

        /// <summary>
        /// Application Assets
        /// </summary>
        public IList<Asset> Assets { get => GetField(ref _assets); set => SetField(ref _assets, value); }

        /// <summary>
        /// FHA MCAW Assets Available [1094]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Assets Available")]
        public decimal? AssetsAvailableAmount { get => _assetsAvailableAmount; set => SetField(ref _assetsAvailableAmount, value); }

        /// <summary>
        /// Application ATRQMBorrower
        /// </summary>
        public ATRQMBorrower ATRQMBorrower { get => GetField(ref _aTRQMBorrower); set => SetField(ref _aTRQMBorrower, value); }

        /// <summary>
        /// Application ATRQMBorrowers
        /// </summary>
        public IList<ATRQMBorrower> ATRQMBorrowers { get => GetField(ref _aTRQMBorrowers); set => SetField(ref _aTRQMBorrowers, value); }

        /// <summary>
        /// Application AUSTrackingLogs
        /// </summary>
        public IList<AUSTrackingLog> AUSTrackingLogs { get => GetField(ref _aUSTrackingLogs); set => SetField(ref _aUSTrackingLogs, value); }

        /// <summary>
        /// VA Bal Avail Family Support Guideline [1340]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Bal Avail Family Support Guideline")]
        public decimal? BalanceAvailableFamilySupportGuideline { get => _balanceAvailableFamilySupportGuideline; set => SetField(ref _balanceAvailableFamilySupportGuideline, value); }

        /// <summary>
        /// Application Borrower
        /// </summary>
        public Borrower Borrower { get => GetField(ref _borrower); set => SetField(ref _borrower, value); }

        /// <summary>
        /// Trans Details Qual Ratio Bottom [742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Bottom")]
        public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => SetField(ref _bottomRatioPercent, value); }

        /// <summary>
        /// Income Total Deductions Spouse/Borr [1312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Deductions Spouse/Borr")]
        public decimal? BrwCoBrwTotalTaxDeductions { get => _brwCoBrwTotalTaxDeductions; set => SetField(ref _brwCoBrwTotalTaxDeductions, value); }

        /// <summary>
        /// Application Coborrower
        /// </summary>
        public Borrower Coborrower { get => GetField(ref _coborrower); set => SetField(ref _coborrower, value); }

        /// <summary>
        /// Liabilities Alternate Name 1 [206]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 1")]
        public string CreditAliasName1 { get => _creditAliasName1; set => SetField(ref _creditAliasName1, value); }

        /// <summary>
        /// Liabilities Alternate Name 2 [203]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Alternate Name 2")]
        public string CreditAliasName2 { get => _creditAliasName2; set => SetField(ref _creditAliasName2, value); }

        /// <summary>
        /// Liabilities Creditor Name 1 [1734]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 1")]
        public string CreditorName1 { get => _creditorName1; set => SetField(ref _creditorName1, value); }

        /// <summary>
        /// Liabilities Creditor Name 2 [1736]
        /// </summary>
        [LoanFieldProperty(Description = "Liabilities Creditor Name 2")]
        public string CreditorName2 { get => _creditorName2; set => SetField(ref _creditorName2, value); }

        /// <summary>
        /// Trans Details Credit Rpt Ref # [300]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Credit Rpt Ref #")]
        public string CreditReportReferenceIdentifier { get => _creditReportReferenceIdentifier; set => SetField(ref _creditReportReferenceIdentifier, value); }

        /// <summary>
        /// Application Employment
        /// </summary>
        public IList<Employment> Employment { get => GetField(ref _employment); set => SetField(ref _employment, value); }

        /// <summary>
        /// Application EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Addr [DISCLOSURE.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Addr")]
        public string EquifaxAddress { get => _equifaxAddress; set => SetField(ref _equifaxAddress, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co City [DISCLOSURE.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co City")]
        public string EquifaxCity { get => _equifaxCity; set => SetField(ref _equifaxCity, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Fax [DISCLOSURE.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Fax")]
        public string EquifaxFax { get => _equifaxFax; set => SetField(ref _equifaxFax, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Model [DISCLOSURE.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Model")]
        public string EquifaxModel { get => _equifaxModel; set => SetField(ref _equifaxModel, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Name [DISCLOSURE.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Name")]
        public string EquifaxName { get => _equifaxName; set => SetField(ref _equifaxName, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Phone [DISCLOSURE.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 3 Co Phone")]
        public string EquifaxPhone { get => _equifaxPhone; set => SetField(ref _equifaxPhone, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Zip [DISCLOSURE.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 3 Co Zip")]
        public string EquifaxPostalCode { get => _equifaxPostalCode; set => SetField(ref _equifaxPostalCode, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores From [DISCLOSURE.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores From")]
        public string EquifaxScoreRangeFrom { get => _equifaxScoreRangeFrom; set => SetField(ref _equifaxScoreRangeFrom, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Range Scores To [DISCLOSURE.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Range Scores To")]
        public string EquifaxScoreRangeTo { get => _equifaxScoreRangeTo; set => SetField(ref _equifaxScoreRangeTo, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co State [DISCLOSURE.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co State")]
        public StringEnumValue<State> EquifaxState { get => _equifaxState; set => SetField(ref _equifaxState, value); }

        /// <summary>
        /// Disclosure Cred Bureau 3 Co Website [DISCLOSURE.X640]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 3 Co Website")]
        public string EquifaxWebsite { get => _equifaxWebsite; set => SetField(ref _equifaxWebsite, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Addr [DISCLOSURE.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Addr")]
        public string ExperianAddress { get => _experianAddress; set => SetField(ref _experianAddress, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co City [DISCLOSURE.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co City")]
        public string ExperianCity { get => _experianCity; set => SetField(ref _experianCity, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Fax [DISCLOSURE.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Fax")]
        public string ExperianFax { get => _experianFax; set => SetField(ref _experianFax, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Model Used [DISCLOSURE.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Model Used")]
        public string ExperianModel { get => _experianModel; set => SetField(ref _experianModel, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Name [DISCLOSURE.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Name")]
        public string ExperianName { get => _experianName; set => SetField(ref _experianName, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Phone [DISCLOSURE.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 1 Co Phone")]
        public string ExperianPhone { get => _experianPhone; set => SetField(ref _experianPhone, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Zip [DISCLOSURE.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 1 Co Zip")]
        public string ExperianPostalCode { get => _experianPostalCode; set => SetField(ref _experianPostalCode, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores From [DISCLOSURE.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores From")]
        public string ExperianScoreRangeFrom { get => _experianScoreRangeFrom; set => SetField(ref _experianScoreRangeFrom, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Range Scores To [DISCLOSURE.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Range Scores To")]
        public string ExperianScoreRangeTo { get => _experianScoreRangeTo; set => SetField(ref _experianScoreRangeTo, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co State [DISCLOSURE.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co State")]
        public StringEnumValue<State> ExperianState { get => _experianState; set => SetField(ref _experianState, value); }

        /// <summary>
        /// Disclosure Cred Bureau 1 Co Website [DISCLOSURE.X638]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 1 Co Website")]
        public string ExperianWebsite { get => _experianWebsite; set => SetField(ref _experianWebsite, value); }

        /// <summary>
        /// VA Debt-to-Income Ratio [1341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Debt-to-Income Ratio")]
        public decimal? FhaVaDebtIncomeRatio { get => _fhaVaDebtIncomeRatio; set => SetField(ref _fhaVaDebtIncomeRatio, value); }

        /// <summary>
        /// Income Total Residual Income Spouse/Borr [1325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Residual Income Spouse/Borr")]
        public decimal? FhaVaFamilySupportAmount { get => _fhaVaFamilySupportAmount; set => SetField(ref _fhaVaFamilySupportAmount, value); }

        /// <summary>
        /// Expenses Total Mo Shelter Exp Est [1349]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Shelter Exp Est")]
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; set => SetField(ref _fhaVaTotalEstimatedMonthlyShelterExpenseAmount, value); }

        /// <summary>
        /// Income Total Net Effective Income [1323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Effective Income")]
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => _fhaVaTotalNetEffectiveIncomeAmount; set => SetField(ref _fhaVaTotalNetEffectiveIncomeAmount, value); }

        /// <summary>
        /// Income Total Net Spouse/Borr [1321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Spouse/Borr")]
        public decimal? FhaVaTotalNetIncomeAmount { get => _fhaVaTotalNetIncomeAmount; set => SetField(ref _fhaVaTotalNetIncomeAmount, value); }

        /// <summary>
        /// Income Net Take Home Pay Spouse/Borr [1315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Net Take Home Pay Spouse/Borr")]
        public decimal? FhaVaTotalNetTakeHomePayAmount { get => _fhaVaTotalNetTakeHomePayAmount; set => SetField(ref _fhaVaTotalNetTakeHomePayAmount, value); }

        /// <summary>
        /// Income Other Net Spouse/Borr [1318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Other Net Spouse/Borr")]
        public decimal? FhaVaTotalOtherNetIncome { get => _fhaVaTotalOtherNetIncome; set => SetField(ref _fhaVaTotalOtherNetIncome, value); }

        /// <summary>
        /// Expenses Present Mtg Pymt [120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Mtg Pymt")]
        public decimal? FirstMortgagePrincipalAndInterestAmount { get => _firstMortgagePrincipalAndInterestAmount; set => SetField(ref _firstMortgagePrincipalAndInterestAmount, value); }

        /// <summary>
        /// Freddie Mac Credit Ref # [CASASRN.X198]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Freddie Mac Credit Ref #")]
        public string FreddieMacCreditReportReferenceIdentifier { get => _freddieMacCreditReportReferenceIdentifier; set => SetField(ref _freddieMacCreditReportReferenceIdentifier, value); }

        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Debt Ratio [CASASRN.X202]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Debt Ratio")]
        public decimal? FreddieMacOccupantDebtRatio { get => _freddieMacOccupantDebtRatio; set => SetField(ref _freddieMacOccupantDebtRatio, value); }

        /// <summary>
        /// Freddie Mac Additional Data - Occupancy Housing Ratio [CASASRN.X201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Freddie Mac Additional Data - Occupancy Housing Ratio")]
        public decimal? FreddieMacOccupantHousingRatio { get => _freddieMacOccupantHousingRatio; set => SetField(ref _freddieMacOccupantHousingRatio, value); }

        /// <summary>
        /// Trans Details Qual Ratio Debt-to-Housing [1539]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Ratio Debt-to-Housing")]
        public decimal? FreDebtToHousingGapRatio { get => _freDebtToHousingGapRatio; set => SetField(ref _freDebtToHousingGapRatio, value); }

        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [273]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? GrossBaseIncomeAmount { get => _grossBaseIncomeAmount; set => SetField(ref _grossBaseIncomeAmount, value); }

        /// <summary>
        /// Underwriting Co-Mortgagor Income [1374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Income")]
        public decimal? GrossIncomeForComortSet { get => _grossIncomeForComortSet; set => SetField(ref _grossIncomeForComortSet, value); }

        /// <summary>
        /// Underwriting Negative Cash Flow [462]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Negative Cash Flow")]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => SetField(ref _grossNegativeCashFlow, value); }

        /// <summary>
        /// Income Total Other Income (Borr/Co-Borr) [1168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (Borr/Co-Borr)")]
        public decimal? GrossOtherIncomeAmount { get => _grossOtherIncomeAmount; set => SetField(ref _grossOtherIncomeAmount, value); }

        /// <summary>
        /// Income Total Positive Cash Flow (Borr/Co-Borr) [1171]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Positive Cash Flow (Borr/Co-Borr)")]
        public decimal? GrossPositiveCashFlow { get => _grossPositiveCashFlow; set => SetField(ref _grossPositiveCashFlow, value); }

        /// <summary>
        /// Expenses Present Haz Ins [122]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Haz Ins")]
        public string HazardInsuranceAmount { get => _hazardInsuranceAmount; set => SetField(ref _hazardInsuranceAmount, value); }

        /// <summary>
        /// Expenses Present HOA [125]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present HOA")]
        public string HomeownersAssociationDuesAndCondoFeesAmount { get => _homeownersAssociationDuesAndCondoFeesAmount; set => SetField(ref _homeownersAssociationDuesAndCondoFeesAmount, value); }

        /// <summary>
        /// HUD Property Improve Auto 1 Lienholder [CAPIAP.X134]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Lienholder")]
        public string HudAutoLienHolderName1 { get => _hudAutoLienHolderName1; set => SetField(ref _hudAutoLienHolderName1, value); }

        /// <summary>
        /// HUD Property Improve Auto 2 Lienholder [CAPIAP.X139]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Lienholder")]
        public string HudAutoLienHolderName2 { get => _hudAutoLienHolderName2; set => SetField(ref _hudAutoLienHolderName2, value); }

        /// <summary>
        /// HUD Property Improve Auto 1 Loan Amt [CAPIAP.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Loan Amt")]
        public decimal? HudAutoLoanAmount1 { get => _hudAutoLoanAmount1; set => SetField(ref _hudAutoLoanAmount1, value); }

        /// <summary>
        /// HUD Property Improve Auto 2 Loan Amt [CAPIAP.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Loan Amt")]
        public decimal? HudAutoLoanAmount2 { get => _hudAutoLoanAmount2; set => SetField(ref _hudAutoLoanAmount2, value); }

        /// <summary>
        /// HUD Property Improve Auto 1 Mo Pymt [CAPIAP.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment1 { get => _hudAutoMonthlyPayment1; set => SetField(ref _hudAutoMonthlyPayment1, value); }

        /// <summary>
        /// HUD Property Improve Auto 2 Mo Pymt [CAPIAP.X143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Mo Pymt")]
        public decimal? HudAutoMonthlyPayment2 { get => _hudAutoMonthlyPayment2; set => SetField(ref _hudAutoMonthlyPayment2, value); }

        /// <summary>
        /// HUD Property Improve Auto 1 Present Bal [CAPIAP.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 1 Present Bal")]
        public decimal? HudAutoPresentBalance1 { get => _hudAutoPresentBalance1; set => SetField(ref _hudAutoPresentBalance1, value); }

        /// <summary>
        /// HUD Property Improve Auto 2 Present Bal [CAPIAP.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Auto 2 Present Bal")]
        public decimal? HudAutoPresentBalance2 { get => _hudAutoPresentBalance2; set => SetField(ref _hudAutoPresentBalance2, value); }

        /// <summary>
        /// HUD Property Improve Auto 1 Yr/Make [CAPIAP.X135]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 1 Yr/Make")]
        public string HudAutoYearAndMake1 { get => _hudAutoYearAndMake1; set => SetField(ref _hudAutoYearAndMake1, value); }

        /// <summary>
        /// HUD Property Improve Auto 2 Yr/Make [CAPIAP.X140]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Auto 2 Yr/Make")]
        public string HudAutoYearAndMake2 { get => _hudAutoYearAndMake2; set => SetField(ref _hudAutoYearAndMake2, value); }

        /// <summary>
        /// HUD Property Improve Liability 1 Loan Amt [CAPIAP.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 1 Loan Amt")]
        public decimal? HudLoanAmount1 { get => _hudLoanAmount1; set => SetField(ref _hudLoanAmount1, value); }

        /// <summary>
        /// HUD Property Improve Liability 10 Loan Amt [CAPIAP.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 10 Loan Amt")]
        public decimal? HudLoanAmount10 { get => _hudLoanAmount10; set => SetField(ref _hudLoanAmount10, value); }

        /// <summary>
        /// HUD Property Improve Liability 11 Loan Amt [CAPIAP.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 11 Loan Amt")]
        public decimal? HudLoanAmount11 { get => _hudLoanAmount11; set => SetField(ref _hudLoanAmount11, value); }

        /// <summary>
        /// HUD Property Improve Liability 2 Loan Amt [CAPIAP.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 2 Loan Amt")]
        public decimal? HudLoanAmount2 { get => _hudLoanAmount2; set => SetField(ref _hudLoanAmount2, value); }

        /// <summary>
        /// HUD Property Improve Liability 3 Loan Amt [CAPIAP.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 3 Loan Amt")]
        public decimal? HudLoanAmount3 { get => _hudLoanAmount3; set => SetField(ref _hudLoanAmount3, value); }

        /// <summary>
        /// HUD Property Improve Liability 4 Loan Amt [CAPIAP.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 4 Loan Amt")]
        public decimal? HudLoanAmount4 { get => _hudLoanAmount4; set => SetField(ref _hudLoanAmount4, value); }

        /// <summary>
        /// HUD Property Improve Liability 5 Loan Amt [CAPIAP.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 5 Loan Amt")]
        public decimal? HudLoanAmount5 { get => _hudLoanAmount5; set => SetField(ref _hudLoanAmount5, value); }

        /// <summary>
        /// HUD Property Improve Liability 6 Loan Amt [CAPIAP.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 6 Loan Amt")]
        public decimal? HudLoanAmount6 { get => _hudLoanAmount6; set => SetField(ref _hudLoanAmount6, value); }

        /// <summary>
        /// HUD Property Improve Liability 7 Loan Amt [CAPIAP.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 7 Loan Amt")]
        public decimal? HudLoanAmount7 { get => _hudLoanAmount7; set => SetField(ref _hudLoanAmount7, value); }

        /// <summary>
        /// HUD Property Improve Liability 8 Loan Amt [CAPIAP.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 8 Loan Amt")]
        public decimal? HudLoanAmount8 { get => _hudLoanAmount8; set => SetField(ref _hudLoanAmount8, value); }

        /// <summary>
        /// HUD Property Improve Liability 9 Loan Amt [CAPIAP.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Liability 9 Loan Amt")]
        public decimal? HudLoanAmount9 { get => _hudLoanAmount9; set => SetField(ref _hudLoanAmount9, value); }

        /// <summary>
        /// HUD Property Improve RE 1 FHA Insured [CAPIAP.X28]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured1 { get => _hudRealEstateFhaInsured1; set => SetField(ref _hudRealEstateFhaInsured1, value); }

        /// <summary>
        /// HUD Property Improve RE 2 FHA Insured [CAPIAP.X30]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 FHA Insured", OptionsJson = "{\"true\":\"FHA Insured\"}")]
        public bool? HudRealEstateFhaInsured2 { get => _hudRealEstateFhaInsured2; set => SetField(ref _hudRealEstateFhaInsured2, value); }

        /// <summary>
        /// HUD Property Improve RE 1 Lienholder [CAPIAP.X148]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 1 Lienholder")]
        public string HudRealEstateLienHolder1 { get => _hudRealEstateLienHolder1; set => SetField(ref _hudRealEstateLienHolder1, value); }

        /// <summary>
        /// HUD Property Improve RE 2 Lienholder [CAPIAP.X149]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve RE 2 Lienholder")]
        public string HudRealEstateLienHolder2 { get => _hudRealEstateLienHolder2; set => SetField(ref _hudRealEstateLienHolder2, value); }

        /// <summary>
        /// HUD Property Improve RE 1 Loan Amt [CAPIAP.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Loan Amt")]
        public decimal? HudRealEstateLoanAmount1 { get => _hudRealEstateLoanAmount1; set => SetField(ref _hudRealEstateLoanAmount1, value); }

        /// <summary>
        /// HUD Property Improve RE 2 Loan Amt [CAPIAP.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Loan Amt")]
        public decimal? HudRealEstateLoanAmount2 { get => _hudRealEstateLoanAmount2; set => SetField(ref _hudRealEstateLoanAmount2, value); }

        /// <summary>
        /// HUD Property Improve RE 1 Mo Pymt [CAPIAP.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment1 { get => _hudRealEstateMonthlyPayment1; set => SetField(ref _hudRealEstateMonthlyPayment1, value); }

        /// <summary>
        /// HUD Property Improve RE 2 Mo Pymt [CAPIAP.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Mo Pymt")]
        public decimal? HudRealEstateMonthlyPayment2 { get => _hudRealEstateMonthlyPayment2; set => SetField(ref _hudRealEstateMonthlyPayment2, value); }

        /// <summary>
        /// HUD Property Improve RE 1 Present Bal [CAPIAP.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 1 Present Bal")]
        public decimal? HudRealEstatePresentBalance1 { get => _hudRealEstatePresentBalance1; set => SetField(ref _hudRealEstatePresentBalance1, value); }

        /// <summary>
        /// HUD Property Improve RE 2 Present Bal [CAPIAP.X152]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve RE 2 Present Bal")]
        public decimal? HudRealEstatePresentBalance2 { get => _hudRealEstatePresentBalance2; set => SetField(ref _hudRealEstatePresentBalance2, value); }

        /// <summary>
        /// Application Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Application Income
        /// </summary>
        public IList<Income> Income { get => GetField(ref _income); set => SetField(ref _income, value); }

        /// <summary>
        /// Trans Details Income of Spouse will not be used [35]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Spouse will not be used", OptionsJson = "{\"true\":\"The income/assets of the Borrower's spouse will not be used..\"}")]
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get => _incomeOfBorrowersSpouseUsedIndicator; set => SetField(ref _incomeOfBorrowersSpouseUsedIndicator, value); }

        /// <summary>
        /// Trans Details Income of Other will be used [307]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Income of Other will be used", OptionsJson = "{\"true\":\"The income/assets of a person other than Borrower will be used...\"}")]
        public bool? IncomeOtherThanBorrowerUsedIndicator { get => _incomeOtherThanBorrowerUsedIndicator; set => SetField(ref _incomeOtherThanBorrowerUsedIndicator, value); }

        /// <summary>
        /// Assets/Liabilities Completed Jointly/Not Jointly [181]
        /// </summary>
        [LoanFieldProperty(Description = "Assets/Liabilities Completed Jointly/Not Jointly")]
        public bool? JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => SetField(ref _jointAssetLiabilityReportingIndicator, value); }

        /// <summary>
        /// Application LastModified
        /// </summary>
        public string LastModified { get => _lastModified; set => SetField(ref _lastModified, value); }

        /// <summary>
        /// Application Liabilities
        /// </summary>
        public IList<Liability> Liabilities { get => GetField(ref _liabilities); set => SetField(ref _liabilities, value); }

        /// <summary>
        /// Assets Co-Borr Liquid Assets [267]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Co-Borr Liquid Assets")]
        public decimal? LiquidAssetsComortSet { get => _liquidAssetsComortSet; set => SetField(ref _liquidAssetsComortSet, value); }

        /// <summary>
        /// Application LoanAmount
        /// </summary>
        public string LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

        /// <summary>
        /// Application LoanOfficerId
        /// </summary>
        public string LoanOfficerId { get => _loanOfficerId; set => SetField(ref _loanOfficerId, value); }

        /// <summary>
        /// Application LoanOfficerName
        /// </summary>
        public string LoanOfficerName { get => _loanOfficerName; set => SetField(ref _loanOfficerName, value); }

        /// <summary>
        /// FHA MCAW Borr Other Mo Income [936]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Borr Other Mo Income")]
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => _mcawBorrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawBorrowerOtherMonthlyIncomeAmount, value); }

        /// <summary>
        /// FHA MCAW Co-Borr Other Mo Income [938]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Co-Borr Other Mo Income")]
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => _mcawCoborrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawCoborrowerOtherMonthlyIncomeAmount, value); }

        /// <summary>
        /// FHA MCAW Total Gross Mo Income [1761]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Gross Mo Income")]
        public decimal? McawGrossMonthlyIncomeAmount { get => _mcawGrossMonthlyIncomeAmount; set => SetField(ref _mcawGrossMonthlyIncomeAmount, value); }

        /// <summary>
        /// FHA MCAW Mtg Pymt-to-Income Ratio [MCAWPUR.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Mtg Pymt-to-Income Ratio")]
        public decimal? McawMortgagePaymentToIncome1Amount { get => _mcawMortgagePaymentToIncome1Amount; set => SetField(ref _mcawMortgagePaymentToIncome1Amount, value); }

        /// <summary>
        /// FHA MCAW Ratio Mtg Pymt-to-Income [GMCAW.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Mtg Pymt-to-Income")]
        public decimal? McawMortgagePaymentToIncome2Amount { get => _mcawMortgagePaymentToIncome2Amount; set => SetField(ref _mcawMortgagePaymentToIncome2Amount, value); }

        /// <summary>
        /// FHA MCAW Liabilities Other [1161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Other")]
        public decimal? McawOtherAmount { get => _mcawOtherAmount; set => SetField(ref _mcawOtherAmount, value); }

        /// <summary>
        /// FHA MCAW Liabilities Unpaid Bal [1163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Liabilities Unpaid Bal")]
        public decimal? McawOtherDebtsAndObligationsAmount { get => _mcawOtherDebtsAndObligationsAmount; set => SetField(ref _mcawOtherDebtsAndObligationsAmount, value); }

        /// <summary>
        /// FHA MCAW Total Fixed Pymt [MCAWPUR.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get => _mcawTotalFixedPaymentForPurchaseAmount; set => SetField(ref _mcawTotalFixedPaymentForPurchaseAmount, value); }

        /// <summary>
        /// FHA MCAW Total Fixed Pymt [GMCAW.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt")]
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get => _mcawTotalFixedPaymentForRefinanceAmount; set => SetField(ref _mcawTotalFixedPaymentForRefinanceAmount, value); }

        /// <summary>
        /// FHA MCAW Total Fixed Pymt-to-Income Ratio [MCAWPUR.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Total Fixed Pymt-to-Income Ratio")]
        public decimal? McawTotalFixedPaymentToIncome1Amount { get => _mcawTotalFixedPaymentToIncome1Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome1Amount, value); }

        /// <summary>
        /// FHA MCAW Ratio Total Fixed Pymt-to-Income [GMCAW.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Total Fixed Pymt-to-Income")]
        public decimal? McawTotalFixedPaymentToIncome2Amount { get => _mcawTotalFixedPaymentToIncome2Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome2Amount, value); }

        /// <summary>
        /// FHA MCAW Liabilities Total Mo Pymt [1150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Liabilities Total Mo Pymt")]
        public decimal? McawTotalMonthlyPaymentsAmount { get => _mcawTotalMonthlyPaymentsAmount; set => SetField(ref _mcawTotalMonthlyPaymentsAmount, value); }

        /// <summary>
        /// FHA MCAW Total Mtg Pymt [739]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Mtg Pymt")]
        public decimal? McawTotalMortgagePaymentAmount { get => _mcawTotalMortgagePaymentAmount; set => SetField(ref _mcawTotalMortgagePaymentAmount, value); }

        /// <summary>
        /// Underwriting Co-Mortgagor [1384]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor")]
        public decimal? MonthlyExpenseComortSet { get => _monthlyExpenseComortSet; set => SetField(ref _monthlyExpenseComortSet, value); }

        /// <summary>
        /// Expenses Total Housing Expense [1809]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Housing Expense")]
        public decimal? MonthlyHousingExpenseAmount { get => _monthlyHousingExpenseAmount; set => SetField(ref _monthlyHousingExpenseAmount, value); }

        /// <summary>
        /// Expenses Total Mo Installment Exp [382]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Installment Exp")]
        public decimal? MonthlyInstallmentExpenseAmount { get => _monthlyInstallmentExpenseAmount; set => SetField(ref _monthlyInstallmentExpenseAmount, value); }

        /// <summary>
        /// Expenses Negative Real Estate [LOANSUB.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Negative Real Estate")]
        public decimal? MonthlyNegativeRealEstateAmount { get => _monthlyNegativeRealEstateAmount; set => SetField(ref _monthlyNegativeRealEstateAmount, value); }

        /// <summary>
        /// Expenses 2nd/Vacation Home [1476]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses 2nd/Vacation Home")]
        public decimal? MonthlySecondHomeAmount { get => _monthlySecondHomeAmount; set => SetField(ref _monthlySecondHomeAmount, value); }

        /// <summary>
        /// Expenses Present MTG Ins [124]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present MTG Ins")]
        public string MortgageInsuranceAmount { get => _mortgageInsuranceAmount; set => SetField(ref _mortgageInsuranceAmount, value); }

        /// <summary>
        /// Liabilities Net Worth [734]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Net Worth")]
        public decimal? NetWorthAmount { get => _netWorthAmount; set => SetField(ref _netWorthAmount, value); }

        /// <summary>
        /// Expenses Present Other Housing [126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Housing")]
        public decimal? OtherHousingExpenseAmount { get => _otherHousingExpenseAmount; set => SetField(ref _otherHousingExpenseAmount, value); }

        /// <summary>
        /// Income Deductions Other Items Deducted [198]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Deductions Other Items Deducted")]
        public decimal? OtherItemsDeducted { get => _otherItemsDeducted; set => SetField(ref _otherItemsDeducted, value); }

        /// <summary>
        /// Expenses Present Other Pymt [121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Other Pymt")]
        public decimal? OtherMortgagePrincipalAndInterestAmount { get => _otherMortgagePrincipalAndInterestAmount; set => SetField(ref _otherMortgagePrincipalAndInterestAmount, value); }

        /// <summary>
        /// VA Past Credit Record [1326]
        /// </summary>
        [LoanFieldProperty(Description = "VA Past Credit Record")]
        public StringEnumValue<PastCreditRecord> PastCreditRecord { get => _pastCreditRecord; set => SetField(ref _pastCreditRecord, value); }

        /// <summary>
        /// Expenses Co-Borr Present Mo Hous Exp [268]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Co-Borr Present Mo Hous Exp")]
        public decimal? PresentHousingExpComortSet { get => _presentHousingExpComortSet; set => SetField(ref _presentHousingExpComortSet, value); }

        /// <summary>
        /// Underwriting Co-Mortgagor Primary Exp [1379]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Co-Mortgagor Primary Exp")]
        public decimal? PrimaryResidenceComortSet { get => _primaryResidenceComortSet; set => SetField(ref _primaryResidenceComortSet, value); }

        /// <summary>
        /// Subject Property Occupancy Status [1811]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Occupancy Status")]
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Underwriting HOA Fees [1729]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting HOA Fees")]
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => SetField(ref _proposedDuesAmount, value); }

        /// <summary>
        /// Underwriting First Mtg P&amp;I [1724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting First Mtg P&I")]
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => SetField(ref _proposedFirstMortgageAmount, value); }

        /// <summary>
        /// Underwriting Rent [1723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Rent")]
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => SetField(ref _proposedGroundRentAmount, value); }

        /// <summary>
        /// Underwriting Hazard Ins [1726]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Hazard Ins")]
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => SetField(ref _proposedHazardInsuranceAmount, value); }

        /// <summary>
        /// Insurance Mtg Ins Mo Pymt [1728]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Mtg Ins Mo Pymt")]
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => SetField(ref _proposedMortgageInsuranceAmount, value); }

        /// <summary>
        /// Underwriting Other Fees [1730]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Other Fees")]
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => SetField(ref _proposedOtherAmount, value); }

        /// <summary>
        /// Underwriting Second Mtg P&amp;I [1725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Second Mtg P&I")]
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => SetField(ref _proposedOtherMortgagesAmount, value); }

        /// <summary>
        /// Underwriting Taxes [1727]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Underwriting Taxes")]
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => SetField(ref _proposedRealEstateTaxesAmount, value); }

        /// <summary>
        /// Expenses Present Taxes [123]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Present Taxes")]
        public string RealEstateTaxAmount { get => _realEstateTaxAmount; set => SetField(ref _realEstateTaxAmount, value); }

        /// <summary>
        /// Expenses Present Rent [119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Present Rent")]
        public decimal? RentAmount { get => _rentAmount; set => SetField(ref _rentAmount, value); }

        /// <summary>
        /// Application ReoProperties
        /// </summary>
        public IList<ReoProperty> ReoProperties { get => GetField(ref _reoProperties); set => SetField(ref _reoProperties, value); }

        /// <summary>
        /// Income Total Gross Rent Income [921]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Gross Rent Income")]
        public decimal? ReoTotalGrossRentalIncomeAmount { get => _reoTotalGrossRentalIncomeAmount; set => SetField(ref _reoTotalGrossRentalIncomeAmount, value); }

        /// <summary>
        /// Income Total Ins/Tax/Exp Income [923]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Ins/Tax/Exp Income")]
        public decimal? ReoTotalMaintenanceAmount { get => _reoTotalMaintenanceAmount; set => SetField(ref _reoTotalMaintenanceAmount, value); }

        /// <summary>
        /// Assets Real Estate Owned [919]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Real Estate Owned")]
        public decimal? ReoTotalMarketValueAmount { get => _reoTotalMarketValueAmount; set => SetField(ref _reoTotalMarketValueAmount, value); }

        /// <summary>
        /// Income Total Mortgage Pymts Income [922]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mortgage Pymts Income")]
        public decimal? ReoTotalMortgagePaymentsAmount { get => _reoTotalMortgagePaymentsAmount; set => SetField(ref _reoTotalMortgagePaymentsAmount, value); }

        /// <summary>
        /// Income Total Amt of Mortgages Income [920]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Amt of Mortgages Income")]
        public decimal? ReoTotalMortgagesAndLiensAmount { get => _reoTotalMortgagesAndLiensAmount; set => SetField(ref _reoTotalMortgagesAndLiensAmount, value); }

        /// <summary>
        /// Income Total Net Rental Income [924]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Income Total Net Rental Income")]
        public int? ReoTotalNetRentalIncomeAmount { get => _reoTotalNetRentalIncomeAmount; set => SetField(ref _reoTotalNetRentalIncomeAmount, value); }

        /// <summary>
        /// Application Residences
        /// </summary>
        public IList<Residence> Residences { get => GetField(ref _residences); set => SetField(ref _residences, value); }

        /// <summary>
        /// Application Respa6
        /// </summary>
        public string Respa6 { get => _respa6; set => SetField(ref _respa6, value); }

        /// <summary>
        /// Application SelfEmployedIncomes
        /// </summary>
        public IList<SelfEmployedIncome> SelfEmployedIncomes { get => GetField(ref _selfEmployedIncomes); set => SetField(ref _selfEmployedIncomes, value); }

        /// <summary>
        /// Denial Discl Info - Borrower Address [DENIAL.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address")]
        public string SofDBorrowerAddress { get => _sofDBorrowerAddress; set => SetField(ref _sofDBorrowerAddress, value); }

        /// <summary>
        /// Denial Discl Info - Borrower Address - City [DENIAL.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address - City")]
        public string SofDBorrowerAddressCity { get => _sofDBorrowerAddressCity; set => SetField(ref _sofDBorrowerAddressCity, value); }

        /// <summary>
        /// Denial Discl Info - Borrower Address - State [DENIAL.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address - State")]
        public StringEnumValue<State> SofDBorrowerAddressState { get => _sofDBorrowerAddressState; set => SetField(ref _sofDBorrowerAddressState, value); }

        /// <summary>
        /// Denial Discl Info - Borrower Address Type [DENIAL.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Borrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => _sofDBorrowerAddressType; set => SetField(ref _sofDBorrowerAddressType, value); }

        /// <summary>
        /// Denial Discl Info - Borrower Address - Zipcode [DENIAL.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Borrower Address - Zipcode")]
        public string SofDBorrowerAddressZipcode { get => _sofDBorrowerAddressZipcode; set => SetField(ref _sofDBorrowerAddressZipcode, value); }

        /// <summary>
        /// Denial Discl Info - Coborrower Address [DENIAL.X87]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address")]
        public string SofDCoBorrowerAddress { get => _sofDCoBorrowerAddress; set => SetField(ref _sofDCoBorrowerAddress, value); }

        /// <summary>
        /// Denial Discl Info - Coborrower Address - City [DENIAL.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address - City")]
        public string SofDCoBorrowerAddressCity { get => _sofDCoBorrowerAddressCity; set => SetField(ref _sofDCoBorrowerAddressCity, value); }

        /// <summary>
        /// Denial Discl Info - Coborrower Address - State [DENIAL.X89]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address - State")]
        public StringEnumValue<State> SofDCoBorrowerAddressState { get => _sofDCoBorrowerAddressState; set => SetField(ref _sofDCoBorrowerAddressState, value); }

        /// <summary>
        /// Denial Discl Info - Coborrower Address Type [DENIAL.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info - Coborrower Address Type")]
        public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => _sofDCoBorrowerAddressType; set => SetField(ref _sofDCoBorrowerAddressType, value); }

        /// <summary>
        /// Denial Discl Info - Coborrower Address - Zipcode [DENIAL.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial Discl Info - Coborrower Address - Zipcode")]
        public string SofDCoBorrowerAddressZipcode { get => _sofDCoBorrowerAddressZipcode; set => SetField(ref _sofDCoBorrowerAddressZipcode, value); }

        /// <summary>
        /// VA Veteran Income Consider Spouse Income [1006]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Income Consider Spouse Income")]
        public bool? SpouseIncomeConsider { get => _spouseIncomeConsider; set => SetField(ref _spouseIncomeConsider, value); }

        /// <summary>
        /// Application Tax4506s
        /// </summary>
        public IList<Tax4506> Tax4506s { get => GetField(ref _tax4506s); set => SetField(ref _tax4506s, value); }

        /// <summary>
        /// Trans Details Qual Ratio Top [740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Trans Details Qual Ratio Top")]
        public decimal? TopRatioPercent { get => _topRatioPercent; set => SetField(ref _topRatioPercent, value); }

        /// <summary>
        /// Assets Total Assets [732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Assets")]
        public decimal? TotalAssetsAmount { get => _totalAssetsAmount; set => SetField(ref _totalAssetsAmount, value); }

        /// <summary>
        /// Income Total Base Income (Borr/Co-Borr) [901]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Base Income (Borr/Co-Borr)")]
        public decimal? TotalBaseIncomeAmount { get => _totalBaseIncomeAmount; set => SetField(ref _totalBaseIncomeAmount, value); }

        /// <summary>
        /// Income Total Bonuses (Borr/Co-Borr) [903]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Bonuses (Borr/Co-Borr)")]
        public decimal? TotalBonusAmount { get => _totalBonusAmount; set => SetField(ref _totalBonusAmount, value); }

        /// <summary>
        /// Income Total Commissions (Borr/Co-Borr) [904]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Commissions (Borr/Co-Borr)")]
        public decimal? TotalCommissionsAmount { get => _totalCommissionsAmount; set => SetField(ref _totalCommissionsAmount, value); }

        /// <summary>
        /// Assets Total Bank Deposits [979]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Total Bank Deposits")]
        public decimal? TotalDeposit { get => _totalDeposit; set => SetField(ref _totalDeposit, value); }

        /// <summary>
        /// Income Total Div/Int (Borr/Co-Borr) [905]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Div/Int (Borr/Co-Borr)")]
        public decimal? TotalDividendsInterestAmount { get => _totalDividendsInterestAmount; set => SetField(ref _totalDividendsInterestAmount, value); }

        /// <summary>
        /// Income Total Mo Income Spouse/Borr [1810]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income Spouse/Borr")]
        public decimal? TotalEmploymentAmount { get => _totalEmploymentAmount; set => SetField(ref _totalEmploymentAmount, value); }

        /// <summary>
        /// Expenses Total Mo Expense [1187]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Mo Expense")]
        public decimal? TotalFixedPaymentAmount { get => _totalFixedPaymentAmount; set => SetField(ref _totalFixedPaymentAmount, value); }

        /// <summary>
        /// Income Total Mo Income (Borr/Co-Borr) [1389]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Income (Borr/Co-Borr)")]
        public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => SetField(ref _totalGrossMonthlyIncomeAmount, value); }

        /// <summary>
        /// Income Total Mo Income [736]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Mo Income")]
        public decimal? TotalIncomeAmount { get => _totalIncomeAmount; set => SetField(ref _totalIncomeAmount, value); }

        /// <summary>
        /// Liabilities Total Liability Pymt [350]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Total Liability Pymt")]
        public decimal? TotalMonthlyPaymentAmount { get => _totalMonthlyPaymentAmount; set => SetField(ref _totalMonthlyPaymentAmount, value); }

        /// <summary>
        /// Trans Details Total Mtg Bal [941]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Bal")]
        public decimal? TotalMortgagesBalanceAmount { get => _totalMortgagesBalanceAmount; set => SetField(ref _totalMortgagesBalanceAmount, value); }

        /// <summary>
        /// Trans Details Total Mtg Mo Pymt [909]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Mtg Mo Pymt")]
        public decimal? TotalMortgagesMonthlyPaymentAmount { get => _totalMortgagesMonthlyPaymentAmount; set => SetField(ref _totalMortgagesMonthlyPaymentAmount, value); }

        /// <summary>
        /// Income Total Net Rent Income (Borr/Co-Borr) [906]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Net Rent Income (Borr/Co-Borr)")]
        public decimal? TotalNetRentalIncomeAmount { get => _totalNetRentalIncomeAmount; set => SetField(ref _totalNetRentalIncomeAmount, value); }

        /// <summary>
        /// Income Total Other 1 (Borr/Co-Borr) [907]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 1 (Borr/Co-Borr)")]
        public decimal? TotalOther1Amount { get => _totalOther1Amount; set => SetField(ref _totalOther1Amount, value); }

        /// <summary>
        /// Income Total Other 2 (Borr/Co-Borr) [908]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other 2 (Borr/Co-Borr)")]
        public decimal? TotalOther2Amount { get => _totalOther2Amount; set => SetField(ref _totalOther2Amount, value); }

        /// <summary>
        /// Income Total Overtime (Borr/Co-Borr) [902]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Overtime (Borr/Co-Borr)")]
        public decimal? TotalOvertimeAmount { get => _totalOvertimeAmount; set => SetField(ref _totalOvertimeAmount, value); }

        /// <summary>
        /// Trans Details Total Proposed Mo Pymt [1742]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Proposed Mo Pymt")]
        public decimal? TotalPaymentsAmount { get => _totalPaymentsAmount; set => SetField(ref _totalPaymentsAmount, value); }

        /// <summary>
        /// Expenses Total Primary Expenses [1731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Primary Expenses")]
        public decimal? TotalPrimaryHousingExpenseAmount { get => _totalPrimaryHousingExpenseAmount; set => SetField(ref _totalPrimaryHousingExpenseAmount, value); }

        /// <summary>
        /// Application TotalReoMarketValueAmount
        /// </summary>
        public decimal? TotalReoMarketValueAmount { get => _totalReoMarketValueAmount; set => SetField(ref _totalReoMarketValueAmount, value); }

        /// <summary>
        /// Income Total Other Income (User Defined) [1817]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Income Total Other Income (User Defined)")]
        public decimal? TotalUserDefinedIncome { get => _totalUserDefinedIncome; set => SetField(ref _totalUserDefinedIncome, value); }

        /// <summary>
        /// Application TQLReports
        /// </summary>
        public IList<TQLReportInformation> TQLReports { get => GetField(ref _tQLReports); set => SetField(ref _tQLReports, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Addr [DISCLOSURE.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Addr")]
        public string TransUnionAddress { get => _transUnionAddress; set => SetField(ref _transUnionAddress, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co City [DISCLOSURE.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co City")]
        public string TransUnionCity { get => _transUnionCity; set => SetField(ref _transUnionCity, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Fax [DISCLOSURE.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Fax")]
        public string TransUnionFax { get => _transUnionFax; set => SetField(ref _transUnionFax, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Model [DISCLOSURE.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Model")]
        public string TransUnionModel { get => _transUnionModel; set => SetField(ref _transUnionModel, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Name [DISCLOSURE.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Name")]
        public string TransUnionName { get => _transUnionName; set => SetField(ref _transUnionName, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Phone [DISCLOSURE.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Cred Bureau 2 Co Phone")]
        public string TransUnionPhone { get => _transUnionPhone; set => SetField(ref _transUnionPhone, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Zip [DISCLOSURE.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Cred Bureau 2 Co Zip")]
        public string TransUnionPostalCode { get => _transUnionPostalCode; set => SetField(ref _transUnionPostalCode, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores From [DISCLOSURE.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores From")]
        public string TransUnionScoreRangeFrom { get => _transUnionScoreRangeFrom; set => SetField(ref _transUnionScoreRangeFrom, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Range Scores To [DISCLOSURE.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Range Scores To")]
        public string TransUnionScoreRangeTo { get => _transUnionScoreRangeTo; set => SetField(ref _transUnionScoreRangeTo, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co State [DISCLOSURE.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co State")]
        public StringEnumValue<State> TransUnionState { get => _transUnionState; set => SetField(ref _transUnionState, value); }

        /// <summary>
        /// Disclosure Cred Bureau 2 Co Website [DISCLOSURE.X639]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Cred Bureau 2 Co Website")]
        public string TransUnionWebsite { get => _transUnionWebsite; set => SetField(ref _transUnionWebsite, value); }

        /// <summary>
        /// Application UserDefinedIncome
        /// </summary>
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => SetField(ref _userDefinedIncome, value); }

        /// <summary>
        /// Income Borr/Co-Borr Other Income 2 Descr [1818]
        /// </summary>
        [LoanFieldProperty(Description = "Income Borr/Co-Borr Other Income 2 Descr")]
        public string UserDefinedIncomeDescription { get => _userDefinedIncomeDescription; set => SetField(ref _userDefinedIncomeDescription, value); }

        /// <summary>
        /// VA Meets VA Credit Standards [1327]
        /// </summary>
        [LoanFieldProperty(Description = "VA Meets VA Credit Standards")]
        public StringEnumValue<YOrN> VACreditStandards { get => _vACreditStandards; set => SetField(ref _vACreditStandards, value); }

        /// <summary>
        /// VA Veteran Income Spouse Income Amt [1008]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Veteran Income Spouse Income Amt")]
        public decimal? VaSummarySpouseIncomeAmount { get => _vaSummarySpouseIncomeAmount; set => SetField(ref _vaSummarySpouseIncomeAmount, value); }

        /// <summary>
        /// Income Total Mo Gross Income [993]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Total Mo Gross Income")]
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => _vaSummaryTotalMonthlyGrossIncomeAmount; set => SetField(ref _vaSummaryTotalMonthlyGrossIncomeAmount, value); }
    }
}