using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Application
/// </summary>
public sealed partial class Application : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountNumber1;
    private DirtyValue<string?>? _accountNumber2;
    private DirtyList<AdditionalLoan>? _additionalLoans;
    private DirtyValue<decimal?>? _allOtherPaymentsAmount;
    private DirtyValue<string?>? _applicationId;
    private DirtyValue<int?>? _applicationIndex;
    private DirtyValue<DateTime?>? _applicationSignedDate;
    private DirtyList<Asset>? _assets;
    private DirtyValue<decimal?>? _assetsAvailableAmount;
    private DirtyValue<ATRQMBorrower?>? _aTRQMBorrower;
    private DirtyList<ATRQMBorrower>? _aTRQMBorrowers;
    private DirtyList<AUSTrackingLog>? _aUSTrackingLogs;
    private DirtyValue<decimal?>? _balanceAvailableFamilySupportGuideline;
    private Borrower? _borrower;
    private DirtyValue<string?>? _borrowerPairId;
    private DirtyValue<decimal?>? _bottomRatioPercent;
    private DirtyValue<decimal?>? _brwCoBrwTotalTaxDeductions;
    private DirtyValue<DateTime?>? _closingDisclosureBorDeliveryDate;
    private DirtyValue<DateTime?>? _closingDisclosureBorReceivedDate;
    private Borrower? _coborrower;
    private DirtyValue<string?>? _creditAliasName1;
    private DirtyValue<string?>? _creditAliasName2;
    private DirtyValue<string?>? _creditorName1;
    private DirtyValue<string?>? _creditorName2;
    private DirtyValue<string?>? _creditReportReferenceIdentifier;
    private DirtyList<Employment>? _employment;
    private DirtyValue<bool?>? _entityDeleted;
    private DirtyValue<string?>? _equifaxAddress;
    private DirtyValue<string?>? _equifaxCity;
    private DirtyValue<string?>? _equifaxFax;
    private DirtyValue<string?>? _equifaxModel;
    private DirtyValue<string?>? _equifaxName;
    private DirtyValue<string?>? _equifaxPhone;
    private DirtyValue<string?>? _equifaxPostalCode;
    private DirtyValue<string?>? _equifaxScoreRangeFrom;
    private DirtyValue<string?>? _equifaxScoreRangeTo;
    private DirtyValue<StringEnumValue<State>>? _equifaxState;
    private DirtyValue<string?>? _equifaxWebsite;
    private DirtyValue<string?>? _experianAddress;
    private DirtyValue<string?>? _experianCity;
    private DirtyValue<string?>? _experianFax;
    private DirtyValue<string?>? _experianModel;
    private DirtyValue<string?>? _experianName;
    private DirtyValue<string?>? _experianPhone;
    private DirtyValue<string?>? _experianPostalCode;
    private DirtyValue<string?>? _experianScoreRangeFrom;
    private DirtyValue<string?>? _experianScoreRangeTo;
    private DirtyValue<StringEnumValue<State>>? _experianState;
    private DirtyValue<string?>? _experianWebsite;
    private DirtyValue<decimal?>? _fhaVaDebtIncomeRatio;
    private DirtyValue<decimal?>? _fhaVaFamilySupportAmount;
    private DirtyValue<decimal?>? _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
    private DirtyValue<decimal?>? _fhaVaTotalNetEffectiveIncomeAmount;
    private DirtyValue<decimal?>? _fhaVaTotalNetIncomeAmount;
    private DirtyValue<decimal?>? _fhaVaTotalNetTakeHomePayAmount;
    private DirtyValue<decimal?>? _fhaVaTotalOtherNetIncome;
    private DirtyValue<decimal?>? _firstMortgagePrincipalAndInterestAmount;
    private DirtyValue<string?>? _freddieMacCreditReportReferenceIdentifier;
    private DirtyValue<decimal?>? _freddieMacOccupantDebtRatio;
    private DirtyValue<decimal?>? _freddieMacOccupantHousingRatio;
    private DirtyValue<decimal?>? _freDebtToHousingGapRatio;
    private DirtyList<GiftGrant>? _giftsGrants;
    private DirtyValue<decimal?>? _grossBaseIncomeAmount;
    private DirtyValue<decimal?>? _grossIncomeForComortSet;
    private DirtyValue<decimal?>? _grossNegativeCashFlow;
    private DirtyValue<decimal?>? _grossOtherIncomeAmount;
    private DirtyValue<decimal?>? _grossPositiveCashFlow;
    private DirtyValue<string?>? _hazardInsuranceAmount;
    private DirtyValue<string?>? _homeownersAssociationDuesAndCondoFeesAmount;
    private DirtyValue<string?>? _hudAutoLienHolderName1;
    private DirtyValue<string?>? _hudAutoLienHolderName2;
    private DirtyValue<decimal?>? _hudAutoLoanAmount1;
    private DirtyValue<decimal?>? _hudAutoLoanAmount2;
    private DirtyValue<decimal?>? _hudAutoMonthlyPayment1;
    private DirtyValue<decimal?>? _hudAutoMonthlyPayment2;
    private DirtyValue<decimal?>? _hudAutoPresentBalance1;
    private DirtyValue<decimal?>? _hudAutoPresentBalance2;
    private DirtyValue<string?>? _hudAutoYearAndMake1;
    private DirtyValue<string?>? _hudAutoYearAndMake2;
    private DirtyValue<decimal?>? _hudLoanAmount1;
    private DirtyValue<decimal?>? _hudLoanAmount10;
    private DirtyValue<decimal?>? _hudLoanAmount11;
    private DirtyValue<decimal?>? _hudLoanAmount2;
    private DirtyValue<decimal?>? _hudLoanAmount3;
    private DirtyValue<decimal?>? _hudLoanAmount4;
    private DirtyValue<decimal?>? _hudLoanAmount5;
    private DirtyValue<decimal?>? _hudLoanAmount6;
    private DirtyValue<decimal?>? _hudLoanAmount7;
    private DirtyValue<decimal?>? _hudLoanAmount8;
    private DirtyValue<decimal?>? _hudLoanAmount9;
    private DirtyValue<bool?>? _hudRealEstateFhaInsured1;
    private DirtyValue<bool?>? _hudRealEstateFhaInsured2;
    private DirtyValue<string?>? _hudRealEstateLienHolder1;
    private DirtyValue<string?>? _hudRealEstateLienHolder2;
    private DirtyValue<decimal?>? _hudRealEstateLoanAmount1;
    private DirtyValue<decimal?>? _hudRealEstateLoanAmount2;
    private DirtyValue<decimal?>? _hudRealEstateMonthlyPayment1;
    private DirtyValue<decimal?>? _hudRealEstateMonthlyPayment2;
    private DirtyValue<decimal?>? _hudRealEstatePresentBalance1;
    private DirtyValue<decimal?>? _hudRealEstatePresentBalance2;
    private DirtyValue<string?>? _id;
    private DirtyList<Income>? _income;
    private DirtyValue<bool?>? _incomeOfBorrowersSpouseUsedIndicator;
    private DirtyValue<bool?>? _incomeOtherThanBorrowerUsedIndicator;
    private DirtyValue<bool?>? _jointAssetLiabilityReportingIndicator;
    private DirtyValue<string?>? _lastModified;
    private DirtyList<Liability>? _liabilities;
    private DirtyValue<decimal?>? _liquidAssetsComortSet;
    private DirtyValue<string?>? _loanAmount;
    private DirtyValue<DateTime?>? _loanEstimateDeliveryDate;
    private DirtyValue<string?>? _loanOfficerId;
    private DirtyValue<string?>? _loanOfficerName;
    private DirtyValue<decimal?>? _mcawBorrowerOtherMonthlyIncomeAmount;
    private DirtyValue<decimal?>? _mcawCoborrowerOtherMonthlyIncomeAmount;
    private DirtyValue<decimal?>? _mcawGrossMonthlyIncomeAmount;
    private DirtyValue<decimal?>? _mcawMortgagePaymentToIncome1Amount;
    private DirtyValue<decimal?>? _mcawMortgagePaymentToIncome2Amount;
    private DirtyValue<decimal?>? _mcawOtherAmount;
    private DirtyValue<decimal?>? _mcawOtherDebtsAndObligationsAmount;
    private DirtyValue<decimal?>? _mcawTotalFixedPaymentForPurchaseAmount;
    private DirtyValue<decimal?>? _mcawTotalFixedPaymentForRefinanceAmount;
    private DirtyValue<decimal?>? _mcawTotalFixedPaymentToIncome1Amount;
    private DirtyValue<decimal?>? _mcawTotalFixedPaymentToIncome2Amount;
    private DirtyValue<decimal?>? _mcawTotalMonthlyPaymentsAmount;
    private DirtyValue<decimal?>? _mcawTotalMortgagePaymentAmount;
    private DirtyValue<decimal?>? _monthlyExpenseComortSet;
    private DirtyValue<decimal?>? _monthlyHousingExpenseAmount;
    private DirtyValue<decimal?>? _monthlyInstallmentExpenseAmount;
    private DirtyValue<decimal?>? _monthlyNegativeRealEstateAmount;
    private DirtyValue<decimal?>? _monthlySecondHomeAmount;
    private DirtyValue<string?>? _mortgageInsuranceAmount;
    private DirtyValue<decimal?>? _netWorthAmount;
    private DirtyList<OtherAsset>? _otherAssets;
    private DirtyValue<decimal?>? _otherHousingExpenseAmount;
    private DirtyList<OtherIncomeSource>? _otherIncomeSources;
    private DirtyValue<decimal?>? _otherItemsDeducted;
    private DirtyList<OtherLiability>? _otherLiabilities;
    private DirtyValue<decimal?>? _otherMortgagePrincipalAndInterestAmount;
    private DirtyValue<decimal?>? _otherTotalIncome;
    private DirtyValue<StringEnumValue<PastCreditRecord>>? _pastCreditRecord;
    private DirtyValue<bool?>? _prequalCreditReportIndicator;
    private DirtyValue<decimal?>? _presentHousingExpComortSet;
    private DirtyValue<decimal?>? _presentSupplementalPropertyInsuranceAmount;
    private DirtyValue<decimal?>? _primaryResidenceComortSet;
    private DirtyValue<StringEnumValue<PropertyUsageType>>? _propertyUsageType;
    private DirtyValue<string?>? _proposedDuesAmount;
    private DirtyValue<decimal?>? _proposedFirstMortgageAmount;
    private DirtyValue<decimal?>? _proposedGroundRentAmount;
    private DirtyValue<string?>? _proposedHazardInsuranceAmount;
    private DirtyValue<string?>? _proposedMortgageInsuranceAmount;
    private DirtyValue<decimal?>? _proposedOtherAmount;
    private DirtyValue<decimal?>? _proposedOtherMortgagesAmount;
    private DirtyValue<string?>? _proposedRealEstateTaxesAmount;
    private DirtyList<ProvidedDocument>? _providedDocuments;
    private DirtyValue<string?>? _realEstateTaxAmount;
    private DirtyValue<decimal?>? _rentAmount;
    private DirtyList<ReoProperty>? _reoProperties;
    private DirtyValue<decimal?>? _reoTotalGrossRentalIncomeAmount;
    private DirtyValue<decimal?>? _reoTotalMaintenanceAmount;
    private DirtyValue<decimal?>? _reoTotalMarketValueAmount;
    private DirtyValue<decimal?>? _reoTotalMortgagePaymentsAmount;
    private DirtyValue<decimal?>? _reoTotalMortgagesAndLiensAmount;
    private DirtyValue<int?>? _reoTotalNetRentalIncomeAmount;
    private DirtyValue<DateTime?>? _rescissionDate;
    private DirtyValue<DateTime?>? _rescissionNoteSignedDate;
    private DirtyList<Residence>? _residences;
    private DirtyValue<string?>? _respa6;
    private DirtyList<SelfEmployedIncome>? _selfEmployedIncomes;
    private DirtyValue<string?>? _sofDBorrCountry;
    private DirtyValue<bool?>? _sofDBorrForeignAddressIndicator;
    private DirtyValue<string?>? _sofDBorrowerAddress;
    private DirtyValue<string?>? _sofDBorrowerAddressCity;
    private DirtyValue<StringEnumValue<State>>? _sofDBorrowerAddressState;
    private DirtyValue<StringEnumValue<SofDBorrowerAddressType>>? _sofDBorrowerAddressType;
    private DirtyValue<string?>? _sofDBorrowerAddressZipcode;
    private DirtyValue<string?>? _sofDCoBorrCountry;
    private DirtyValue<bool?>? _sofDCoBorrForeignAddressIndicator;
    private DirtyValue<string?>? _sofDCoBorrowerAddress;
    private DirtyValue<string?>? _sofDCoBorrowerAddressCity;
    private DirtyValue<StringEnumValue<State>>? _sofDCoBorrowerAddressState;
    private DirtyValue<StringEnumValue<SofDBorrowerAddressType>>? _sofDCoBorrowerAddressType;
    private DirtyValue<string?>? _sofDCoBorrowerAddressZipcode;
    private DirtyValue<bool?>? _spouseIncomeConsider;
    private DirtyList<Tax4506>? _tax4506s;
    private DirtyValue<decimal?>? _topRatioPercent;
    private DirtyValue<decimal?>? _totalAdditionalAssetsAmount;
    private DirtyValue<decimal?>? _totalAdditionalLoansAmount;
    private DirtyValue<decimal?>? _totalAdditionalOtherAssetsAmount;
    private DirtyValue<decimal?>? _totalAppliedToDownpayment;
    private DirtyValue<decimal?>? _totalAssetsAmount;
    private DirtyValue<decimal?>? _totalBaseIncomeAmount;
    private DirtyValue<decimal?>? _totalBonusAmount;
    private DirtyValue<decimal?>? _totalCommissionsAmount;
    private DirtyValue<decimal?>? _totalDeposit;
    private DirtyValue<decimal?>? _totalDividendsInterestAmount;
    private DirtyValue<decimal?>? _totalEmploymentAmount;
    private DirtyValue<decimal?>? _totalFixedPaymentAmount;
    private DirtyValue<decimal?>? _totalGrossMonthlyIncomeAmount;
    private DirtyValue<decimal?>? _totalIncomeAmount;
    private DirtyValue<decimal?>? _totalMonthlyPaymentAmount;
    private DirtyValue<decimal?>? _totalMortgagesBalanceAmount;
    private DirtyValue<decimal?>? _totalMortgagesMonthlyPaymentAmount;
    private DirtyValue<decimal?>? _totalNetRentalIncomeAmount;
    private DirtyValue<decimal?>? _totalOther1Amount;
    private DirtyValue<decimal?>? _totalOther2Amount;
    private DirtyValue<decimal?>? _totalOtherAssetsAmount;
    private DirtyValue<decimal?>? _totalOvertimeAmount;
    private DirtyValue<decimal?>? _totalPaymentsAmount;
    private DirtyValue<decimal?>? _totalPrimaryHousingExpenseAmount;
    private DirtyValue<decimal?>? _totalReoMarketValueAmount;
    private DirtyValue<decimal?>? _totalURLA2020AssetsAmount;
    private DirtyValue<decimal?>? _totalUserDefinedIncome;
    private DirtyList<TQLReportInformation>? _tQLReports;
    private DirtyValue<string?>? _transUnionAddress;
    private DirtyValue<string?>? _transUnionCity;
    private DirtyValue<string?>? _transUnionFax;
    private DirtyValue<string?>? _transUnionModel;
    private DirtyValue<string?>? _transUnionName;
    private DirtyValue<string?>? _transUnionPhone;
    private DirtyValue<string?>? _transUnionPostalCode;
    private DirtyValue<string?>? _transUnionScoreRangeFrom;
    private DirtyValue<string?>? _transUnionScoreRangeTo;
    private DirtyValue<StringEnumValue<State>>? _transUnionState;
    private DirtyValue<string?>? _transUnionWebsite;
    private DirtyList<URLAAlternateName>? _uRLAAlternateNames;
    private DirtyValue<decimal?>? _userDefinedIncome;
    private DirtyValue<string?>? _userDefinedIncomeDescription;
    private DirtyValue<StringEnumValue<YOrN>>? _vACreditStandards;
    private DirtyValue<decimal?>? _vaSummarySpouseIncomeAmount;
    private DirtyValue<decimal?>? _vaSummaryTotalMonthlyGrossIncomeAmount;

    /// <summary>
    /// Liabilities Alternate Acct # 1 [1735]
    /// </summary>
    public string? AccountNumber1 { get => _accountNumber1; set => SetField(ref _accountNumber1, value); }

    /// <summary>
    /// Liabilities Alternate Acct # 2 [1737]
    /// </summary>
    public string? AccountNumber2 { get => _accountNumber2; set => SetField(ref _accountNumber2, value); }

    /// <summary>
    /// Application AdditionalLoans
    /// </summary>
    [AllowNull]
    public IList<AdditionalLoan> AdditionalLoans { get => GetField(ref _additionalLoans); set => SetField(ref _additionalLoans, value); }

    /// <summary>
    /// Underwriting All Other Pymts [1733]
    /// </summary>
    public decimal? AllOtherPaymentsAmount { get => _allOtherPaymentsAmount; set => SetField(ref _allOtherPaymentsAmount, value); }

    /// <summary>
    /// Application ApplicationId
    /// </summary>
    public string? ApplicationId { get => _applicationId; set => SetField(ref _applicationId, value); }

    /// <summary>
    /// Application ApplicationIndex
    /// </summary>
    public int? ApplicationIndex { get => _applicationIndex; set => SetField(ref _applicationIndex, value); }

    /// <summary>
    /// Fannie Mae Signature Date [MORNET.X68]
    /// </summary>
    public DateTime? ApplicationSignedDate { get => _applicationSignedDate; set => SetField(ref _applicationSignedDate, value); }

    /// <summary>
    /// Application Assets
    /// </summary>
    [AllowNull]
    public IList<Asset> Assets { get => GetField(ref _assets); set => SetField(ref _assets, value); }

    /// <summary>
    /// FHA MCAW Assets Available [1094]
    /// </summary>
    public decimal? AssetsAvailableAmount { get => _assetsAvailableAmount; set => SetField(ref _assetsAvailableAmount, value); }

    /// <summary>
    /// Application ATRQMBorrower
    /// </summary>
    public ATRQMBorrower? ATRQMBorrower { get => _aTRQMBorrower; set => SetField(ref _aTRQMBorrower, value); }

    /// <summary>
    /// Application ATRQMBorrowers
    /// </summary>
    [AllowNull]
    public IList<ATRQMBorrower> ATRQMBorrowers { get => GetField(ref _aTRQMBorrowers); set => SetField(ref _aTRQMBorrowers, value); }

    /// <summary>
    /// Application AUSTrackingLogs
    /// </summary>
    [AllowNull]
    public IList<AUSTrackingLog> AUSTrackingLogs { get => GetField(ref _aUSTrackingLogs); set => SetField(ref _aUSTrackingLogs, value); }

    /// <summary>
    /// VA Bal Avail Family Support Guideline [1340]
    /// </summary>
    public decimal? BalanceAvailableFamilySupportGuideline { get => _balanceAvailableFamilySupportGuideline; set => SetField(ref _balanceAvailableFamilySupportGuideline, value); }

    /// <summary>
    /// Application Borrower
    /// </summary>
    [AllowNull]
    public Borrower Borrower { get => GetField(ref _borrower); set => SetField(ref _borrower, value); }

    /// <summary>
    /// Borrower Pair ID [BORPAIRID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }

    /// <summary>
    /// Trans Details Qual Ratio Bottom [742]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => SetField(ref _bottomRatioPercent, value); }

    /// <summary>
    /// Income Total Deductions Spouse/Borr [1312]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrwCoBrwTotalTaxDeductions { get => _brwCoBrwTotalTaxDeductions; set => SetField(ref _brwCoBrwTotalTaxDeductions, value); }

    /// <summary>
    /// Correspondent Closing Disclosure Borrower Delivery Date [CORRESPONDENT.X145]
    /// </summary>
    public DateTime? ClosingDisclosureBorDeliveryDate { get => _closingDisclosureBorDeliveryDate; set => SetField(ref _closingDisclosureBorDeliveryDate, value); }

    /// <summary>
    /// Correspondent Closing Disclosure Received Date [CORRESPONDENT.X146]
    /// </summary>
    public DateTime? ClosingDisclosureBorReceivedDate { get => _closingDisclosureBorReceivedDate; set => SetField(ref _closingDisclosureBorReceivedDate, value); }

    /// <summary>
    /// Application Coborrower
    /// </summary>
    [AllowNull]
    public Borrower Coborrower { get => GetField(ref _coborrower); set => SetField(ref _coborrower, value); }

    /// <summary>
    /// Liabilities Alternate Name 1 [206]
    /// </summary>
    public string? CreditAliasName1 { get => _creditAliasName1; set => SetField(ref _creditAliasName1, value); }

    /// <summary>
    /// Liabilities Alternate Name 2 [203]
    /// </summary>
    public string? CreditAliasName2 { get => _creditAliasName2; set => SetField(ref _creditAliasName2, value); }

    /// <summary>
    /// Liabilities Creditor Name 1 [1734]
    /// </summary>
    public string? CreditorName1 { get => _creditorName1; set => SetField(ref _creditorName1, value); }

    /// <summary>
    /// Liabilities Creditor Name 2 [1736]
    /// </summary>
    public string? CreditorName2 { get => _creditorName2; set => SetField(ref _creditorName2, value); }

    /// <summary>
    /// Trans Details Credit Rpt Ref # [300]
    /// </summary>
    public string? CreditReportReferenceIdentifier { get => _creditReportReferenceIdentifier; set => SetField(ref _creditReportReferenceIdentifier, value); }

    /// <summary>
    /// Application Employment
    /// </summary>
    [AllowNull]
    public IList<Employment> Employment { get => GetField(ref _employment); set => SetField(ref _employment, value); }

    /// <summary>
    /// Application EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Addr [DISCLOSURE.X42]
    /// </summary>
    public string? EquifaxAddress { get => _equifaxAddress; set => SetField(ref _equifaxAddress, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co City [DISCLOSURE.X43]
    /// </summary>
    public string? EquifaxCity { get => _equifaxCity; set => SetField(ref _equifaxCity, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Fax [DISCLOSURE.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EquifaxFax { get => _equifaxFax; set => SetField(ref _equifaxFax, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Model [DISCLOSURE.X48]
    /// </summary>
    public string? EquifaxModel { get => _equifaxModel; set => SetField(ref _equifaxModel, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Name [DISCLOSURE.X41]
    /// </summary>
    public string? EquifaxName { get => _equifaxName; set => SetField(ref _equifaxName, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Phone [DISCLOSURE.X46]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EquifaxPhone { get => _equifaxPhone; set => SetField(ref _equifaxPhone, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Zip [DISCLOSURE.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? EquifaxPostalCode { get => _equifaxPostalCode; set => SetField(ref _equifaxPostalCode, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Range Scores From [DISCLOSURE.X49]
    /// </summary>
    public string? EquifaxScoreRangeFrom { get => _equifaxScoreRangeFrom; set => SetField(ref _equifaxScoreRangeFrom, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Range Scores To [DISCLOSURE.X50]
    /// </summary>
    public string? EquifaxScoreRangeTo { get => _equifaxScoreRangeTo; set => SetField(ref _equifaxScoreRangeTo, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co State [DISCLOSURE.X44]
    /// </summary>
    public StringEnumValue<State> EquifaxState { get => _equifaxState; set => SetField(ref _equifaxState, value); }

    /// <summary>
    /// Disclosure Cred Bureau 3 Co Website [DISCLOSURE.X640]
    /// </summary>
    public string? EquifaxWebsite { get => _equifaxWebsite; set => SetField(ref _equifaxWebsite, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Addr [DISCLOSURE.X2]
    /// </summary>
    public string? ExperianAddress { get => _experianAddress; set => SetField(ref _experianAddress, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co City [DISCLOSURE.X3]
    /// </summary>
    public string? ExperianCity { get => _experianCity; set => SetField(ref _experianCity, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Fax [DISCLOSURE.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ExperianFax { get => _experianFax; set => SetField(ref _experianFax, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Model Used [DISCLOSURE.X8]
    /// </summary>
    public string? ExperianModel { get => _experianModel; set => SetField(ref _experianModel, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Name [DISCLOSURE.X1]
    /// </summary>
    public string? ExperianName { get => _experianName; set => SetField(ref _experianName, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Phone [DISCLOSURE.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ExperianPhone { get => _experianPhone; set => SetField(ref _experianPhone, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Zip [DISCLOSURE.X5]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ExperianPostalCode { get => _experianPostalCode; set => SetField(ref _experianPostalCode, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Range Scores From [DISCLOSURE.X9]
    /// </summary>
    public string? ExperianScoreRangeFrom { get => _experianScoreRangeFrom; set => SetField(ref _experianScoreRangeFrom, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Range Scores To [DISCLOSURE.X10]
    /// </summary>
    public string? ExperianScoreRangeTo { get => _experianScoreRangeTo; set => SetField(ref _experianScoreRangeTo, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co State [DISCLOSURE.X4]
    /// </summary>
    public StringEnumValue<State> ExperianState { get => _experianState; set => SetField(ref _experianState, value); }

    /// <summary>
    /// Disclosure Cred Bureau 1 Co Website [DISCLOSURE.X638]
    /// </summary>
    public string? ExperianWebsite { get => _experianWebsite; set => SetField(ref _experianWebsite, value); }

    /// <summary>
    /// VA Debt-to-Income Ratio [1341]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FhaVaDebtIncomeRatio { get => _fhaVaDebtIncomeRatio; set => SetField(ref _fhaVaDebtIncomeRatio, value); }

    /// <summary>
    /// Income Total Residual Income Spouse/Borr [1325]
    /// </summary>
    public decimal? FhaVaFamilySupportAmount { get => _fhaVaFamilySupportAmount; set => SetField(ref _fhaVaFamilySupportAmount, value); }

    /// <summary>
    /// Expenses Total Mo Shelter Exp Est [1349]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; set => SetField(ref _fhaVaTotalEstimatedMonthlyShelterExpenseAmount, value); }

    /// <summary>
    /// Income Total Net Effective Income [1323]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => _fhaVaTotalNetEffectiveIncomeAmount; set => SetField(ref _fhaVaTotalNetEffectiveIncomeAmount, value); }

    /// <summary>
    /// Income Total Net Spouse/Borr [1321]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetIncomeAmount { get => _fhaVaTotalNetIncomeAmount; set => SetField(ref _fhaVaTotalNetIncomeAmount, value); }

    /// <summary>
    /// Income Net Take Home Pay Spouse/Borr [1315]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalNetTakeHomePayAmount { get => _fhaVaTotalNetTakeHomePayAmount; set => SetField(ref _fhaVaTotalNetTakeHomePayAmount, value); }

    /// <summary>
    /// Income Other Net Spouse/Borr [1318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaVaTotalOtherNetIncome { get => _fhaVaTotalOtherNetIncome; set => SetField(ref _fhaVaTotalOtherNetIncome, value); }

    /// <summary>
    /// Expenses Present Mtg Pymt [120]
    /// </summary>
    public decimal? FirstMortgagePrincipalAndInterestAmount { get => _firstMortgagePrincipalAndInterestAmount; set => SetField(ref _firstMortgagePrincipalAndInterestAmount, value); }

    /// <summary>
    /// Freddie Mac Credit Ref # [CASASRN.X198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FreddieMacCreditReportReferenceIdentifier { get => _freddieMacCreditReportReferenceIdentifier; set => SetField(ref _freddieMacCreditReportReferenceIdentifier, value); }

    /// <summary>
    /// Freddie Mac Additional Data - Occupancy Debt Ratio [CASASRN.X202]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FreddieMacOccupantDebtRatio { get => _freddieMacOccupantDebtRatio; set => SetField(ref _freddieMacOccupantDebtRatio, value); }

    /// <summary>
    /// Freddie Mac Additional Data - Occupancy Housing Ratio [CASASRN.X201]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FreddieMacOccupantHousingRatio { get => _freddieMacOccupantHousingRatio; set => SetField(ref _freddieMacOccupantHousingRatio, value); }

    /// <summary>
    /// Trans Details Qual Ratio Debt-to-Housing [1539]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FreDebtToHousingGapRatio { get => _freDebtToHousingGapRatio; set => SetField(ref _freDebtToHousingGapRatio, value); }

    /// <summary>
    /// Application GiftsGrants
    /// </summary>
    [AllowNull]
    public IList<GiftGrant> GiftsGrants { get => GetField(ref _giftsGrants); set => SetField(ref _giftsGrants, value); }

    /// <summary>
    /// Income Total Base Income (Borr/Co-Borr) [273]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossBaseIncomeAmount { get => _grossBaseIncomeAmount; set => SetField(ref _grossBaseIncomeAmount, value); }

    /// <summary>
    /// Underwriting Co-Mortgagor Income [1374]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossIncomeForComortSet { get => _grossIncomeForComortSet; set => SetField(ref _grossIncomeForComortSet, value); }

    /// <summary>
    /// Underwriting Negative Cash Flow [462]
    /// </summary>
    public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => SetField(ref _grossNegativeCashFlow, value); }

    /// <summary>
    /// Income Total Other Income (Borr/Co-Borr) [1168]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossOtherIncomeAmount { get => _grossOtherIncomeAmount; set => SetField(ref _grossOtherIncomeAmount, value); }

    /// <summary>
    /// Income Total Positive Cash Flow (Borr/Co-Borr) [1171]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossPositiveCashFlow { get => _grossPositiveCashFlow; set => SetField(ref _grossPositiveCashFlow, value); }

    /// <summary>
    /// Expenses Present Haz Ins [122]
    /// </summary>
    public string? HazardInsuranceAmount { get => _hazardInsuranceAmount; set => SetField(ref _hazardInsuranceAmount, value); }

    /// <summary>
    /// Expenses Present HOA [125]
    /// </summary>
    public string? HomeownersAssociationDuesAndCondoFeesAmount { get => _homeownersAssociationDuesAndCondoFeesAmount; set => SetField(ref _homeownersAssociationDuesAndCondoFeesAmount, value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Lienholder [CAPIAP.X134]
    /// </summary>
    public string? HudAutoLienHolderName1 { get => _hudAutoLienHolderName1; set => SetField(ref _hudAutoLienHolderName1, value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Lienholder [CAPIAP.X139]
    /// </summary>
    public string? HudAutoLienHolderName2 { get => _hudAutoLienHolderName2; set => SetField(ref _hudAutoLienHolderName2, value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Loan Amt [CAPIAP.X136]
    /// </summary>
    public decimal? HudAutoLoanAmount1 { get => _hudAutoLoanAmount1; set => SetField(ref _hudAutoLoanAmount1, value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Loan Amt [CAPIAP.X141]
    /// </summary>
    public decimal? HudAutoLoanAmount2 { get => _hudAutoLoanAmount2; set => SetField(ref _hudAutoLoanAmount2, value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Mo Pymt [CAPIAP.X138]
    /// </summary>
    public decimal? HudAutoMonthlyPayment1 { get => _hudAutoMonthlyPayment1; set => SetField(ref _hudAutoMonthlyPayment1, value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Mo Pymt [CAPIAP.X143]
    /// </summary>
    public decimal? HudAutoMonthlyPayment2 { get => _hudAutoMonthlyPayment2; set => SetField(ref _hudAutoMonthlyPayment2, value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Present Bal [CAPIAP.X137]
    /// </summary>
    public decimal? HudAutoPresentBalance1 { get => _hudAutoPresentBalance1; set => SetField(ref _hudAutoPresentBalance1, value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Present Bal [CAPIAP.X142]
    /// </summary>
    public decimal? HudAutoPresentBalance2 { get => _hudAutoPresentBalance2; set => SetField(ref _hudAutoPresentBalance2, value); }

    /// <summary>
    /// HUD Property Improve Auto 1 Yr/Make [CAPIAP.X135]
    /// </summary>
    public string? HudAutoYearAndMake1 { get => _hudAutoYearAndMake1; set => SetField(ref _hudAutoYearAndMake1, value); }

    /// <summary>
    /// HUD Property Improve Auto 2 Yr/Make [CAPIAP.X140]
    /// </summary>
    public string? HudAutoYearAndMake2 { get => _hudAutoYearAndMake2; set => SetField(ref _hudAutoYearAndMake2, value); }

    /// <summary>
    /// HUD Property Improve Liability 1 Loan Amt [CAPIAP.X25]
    /// </summary>
    public decimal? HudLoanAmount1 { get => _hudLoanAmount1; set => SetField(ref _hudLoanAmount1, value); }

    /// <summary>
    /// HUD Property Improve Liability 10 Loan Amt [CAPIAP.X38]
    /// </summary>
    public decimal? HudLoanAmount10 { get => _hudLoanAmount10; set => SetField(ref _hudLoanAmount10, value); }

    /// <summary>
    /// HUD Property Improve Liability 11 Loan Amt [CAPIAP.X39]
    /// </summary>
    public decimal? HudLoanAmount11 { get => _hudLoanAmount11; set => SetField(ref _hudLoanAmount11, value); }

    /// <summary>
    /// HUD Property Improve Liability 2 Loan Amt [CAPIAP.X26]
    /// </summary>
    public decimal? HudLoanAmount2 { get => _hudLoanAmount2; set => SetField(ref _hudLoanAmount2, value); }

    /// <summary>
    /// HUD Property Improve Liability 3 Loan Amt [CAPIAP.X31]
    /// </summary>
    public decimal? HudLoanAmount3 { get => _hudLoanAmount3; set => SetField(ref _hudLoanAmount3, value); }

    /// <summary>
    /// HUD Property Improve Liability 4 Loan Amt [CAPIAP.X32]
    /// </summary>
    public decimal? HudLoanAmount4 { get => _hudLoanAmount4; set => SetField(ref _hudLoanAmount4, value); }

    /// <summary>
    /// HUD Property Improve Liability 5 Loan Amt [CAPIAP.X33]
    /// </summary>
    public decimal? HudLoanAmount5 { get => _hudLoanAmount5; set => SetField(ref _hudLoanAmount5, value); }

    /// <summary>
    /// HUD Property Improve Liability 6 Loan Amt [CAPIAP.X34]
    /// </summary>
    public decimal? HudLoanAmount6 { get => _hudLoanAmount6; set => SetField(ref _hudLoanAmount6, value); }

    /// <summary>
    /// HUD Property Improve Liability 7 Loan Amt [CAPIAP.X35]
    /// </summary>
    public decimal? HudLoanAmount7 { get => _hudLoanAmount7; set => SetField(ref _hudLoanAmount7, value); }

    /// <summary>
    /// HUD Property Improve Liability 8 Loan Amt [CAPIAP.X36]
    /// </summary>
    public decimal? HudLoanAmount8 { get => _hudLoanAmount8; set => SetField(ref _hudLoanAmount8, value); }

    /// <summary>
    /// HUD Property Improve Liability 9 Loan Amt [CAPIAP.X37]
    /// </summary>
    public decimal? HudLoanAmount9 { get => _hudLoanAmount9; set => SetField(ref _hudLoanAmount9, value); }

    /// <summary>
    /// HUD Property Improve RE 1 FHA Insured [CAPIAP.X28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Insured\"}")]
    public bool? HudRealEstateFhaInsured1 { get => _hudRealEstateFhaInsured1; set => SetField(ref _hudRealEstateFhaInsured1, value); }

    /// <summary>
    /// HUD Property Improve RE 2 FHA Insured [CAPIAP.X30]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FHA Insured\"}")]
    public bool? HudRealEstateFhaInsured2 { get => _hudRealEstateFhaInsured2; set => SetField(ref _hudRealEstateFhaInsured2, value); }

    /// <summary>
    /// HUD Property Improve RE 1 Lienholder [CAPIAP.X148]
    /// </summary>
    public string? HudRealEstateLienHolder1 { get => _hudRealEstateLienHolder1; set => SetField(ref _hudRealEstateLienHolder1, value); }

    /// <summary>
    /// HUD Property Improve RE 2 Lienholder [CAPIAP.X149]
    /// </summary>
    public string? HudRealEstateLienHolder2 { get => _hudRealEstateLienHolder2; set => SetField(ref _hudRealEstateLienHolder2, value); }

    /// <summary>
    /// HUD Property Improve RE 1 Loan Amt [CAPIAP.X27]
    /// </summary>
    public decimal? HudRealEstateLoanAmount1 { get => _hudRealEstateLoanAmount1; set => SetField(ref _hudRealEstateLoanAmount1, value); }

    /// <summary>
    /// HUD Property Improve RE 2 Loan Amt [CAPIAP.X29]
    /// </summary>
    public decimal? HudRealEstateLoanAmount2 { get => _hudRealEstateLoanAmount2; set => SetField(ref _hudRealEstateLoanAmount2, value); }

    /// <summary>
    /// HUD Property Improve RE 1 Mo Pymt [CAPIAP.X151]
    /// </summary>
    public decimal? HudRealEstateMonthlyPayment1 { get => _hudRealEstateMonthlyPayment1; set => SetField(ref _hudRealEstateMonthlyPayment1, value); }

    /// <summary>
    /// HUD Property Improve RE 2 Mo Pymt [CAPIAP.X153]
    /// </summary>
    public decimal? HudRealEstateMonthlyPayment2 { get => _hudRealEstateMonthlyPayment2; set => SetField(ref _hudRealEstateMonthlyPayment2, value); }

    /// <summary>
    /// HUD Property Improve RE 1 Present Bal [CAPIAP.X150]
    /// </summary>
    public decimal? HudRealEstatePresentBalance1 { get => _hudRealEstatePresentBalance1; set => SetField(ref _hudRealEstatePresentBalance1, value); }

    /// <summary>
    /// HUD Property Improve RE 2 Present Bal [CAPIAP.X152]
    /// </summary>
    public decimal? HudRealEstatePresentBalance2 { get => _hudRealEstatePresentBalance2; set => SetField(ref _hudRealEstatePresentBalance2, value); }

    /// <summary>
    /// Application Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Application Income
    /// </summary>
    [AllowNull]
    public IList<Income> Income { get => GetField(ref _income); set => SetField(ref _income, value); }

    /// <summary>
    /// Trans Details Income of Spouse will not be used [35]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The income/assets of the Borrower's spouse will not be used..\"}")]
    public bool? IncomeOfBorrowersSpouseUsedIndicator { get => _incomeOfBorrowersSpouseUsedIndicator; set => SetField(ref _incomeOfBorrowersSpouseUsedIndicator, value); }

    /// <summary>
    /// Trans Details Income of Other will be used [307]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The income/assets of a person other than Borrower will be used...\"}")]
    public bool? IncomeOtherThanBorrowerUsedIndicator { get => _incomeOtherThanBorrowerUsedIndicator; set => SetField(ref _incomeOtherThanBorrowerUsedIndicator, value); }

    /// <summary>
    /// Assets/Liabilities Completed Jointly/Not Jointly [181]
    /// </summary>
    public bool? JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => SetField(ref _jointAssetLiabilityReportingIndicator, value); }

    /// <summary>
    /// Application LastModified
    /// </summary>
    public string? LastModified { get => _lastModified; set => SetField(ref _lastModified, value); }

    /// <summary>
    /// Application Liabilities
    /// </summary>
    [AllowNull]
    public IList<Liability> Liabilities { get => GetField(ref _liabilities); set => SetField(ref _liabilities, value); }

    /// <summary>
    /// Assets Co-Borr Liquid Assets [267]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LiquidAssetsComortSet { get => _liquidAssetsComortSet; set => SetField(ref _liquidAssetsComortSet, value); }

    /// <summary>
    /// Application LoanAmount
    /// </summary>
    public string? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// Correspondent Loan Estimate Delivery Date [CORRESPONDENT.X243]
    /// </summary>
    public DateTime? LoanEstimateDeliveryDate { get => _loanEstimateDeliveryDate; set => SetField(ref _loanEstimateDeliveryDate, value); }

    /// <summary>
    /// Application LoanOfficerId
    /// </summary>
    public string? LoanOfficerId { get => _loanOfficerId; set => SetField(ref _loanOfficerId, value); }

    /// <summary>
    /// Application LoanOfficerName
    /// </summary>
    public string? LoanOfficerName { get => _loanOfficerName; set => SetField(ref _loanOfficerName, value); }

    /// <summary>
    /// FHA MCAW Borr Other Mo Income [936]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => _mcawBorrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawBorrowerOtherMonthlyIncomeAmount, value); }

    /// <summary>
    /// FHA MCAW Co-Borr Other Mo Income [938]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => _mcawCoborrowerOtherMonthlyIncomeAmount; set => SetField(ref _mcawCoborrowerOtherMonthlyIncomeAmount, value); }

    /// <summary>
    /// FHA MCAW Total Gross Mo Income [1761]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawGrossMonthlyIncomeAmount { get => _mcawGrossMonthlyIncomeAmount; set => SetField(ref _mcawGrossMonthlyIncomeAmount, value); }

    /// <summary>
    /// FHA MCAW Mtg Pymt-to-Income Ratio [MCAWPUR.X22]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawMortgagePaymentToIncome1Amount { get => _mcawMortgagePaymentToIncome1Amount; set => SetField(ref _mcawMortgagePaymentToIncome1Amount, value); }

    /// <summary>
    /// FHA MCAW Ratio Mtg Pymt-to-Income [GMCAW.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawMortgagePaymentToIncome2Amount { get => _mcawMortgagePaymentToIncome2Amount; set => SetField(ref _mcawMortgagePaymentToIncome2Amount, value); }

    /// <summary>
    /// FHA MCAW Liabilities Other [1161]
    /// </summary>
    public decimal? McawOtherAmount { get => _mcawOtherAmount; set => SetField(ref _mcawOtherAmount, value); }

    /// <summary>
    /// FHA MCAW Liabilities Unpaid Bal [1163]
    /// </summary>
    public decimal? McawOtherDebtsAndObligationsAmount { get => _mcawOtherDebtsAndObligationsAmount; set => SetField(ref _mcawOtherDebtsAndObligationsAmount, value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt [MCAWPUR.X24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalFixedPaymentForPurchaseAmount { get => _mcawTotalFixedPaymentForPurchaseAmount; set => SetField(ref _mcawTotalFixedPaymentForPurchaseAmount, value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt [GMCAW.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalFixedPaymentForRefinanceAmount { get => _mcawTotalFixedPaymentForRefinanceAmount; set => SetField(ref _mcawTotalFixedPaymentForRefinanceAmount, value); }

    /// <summary>
    /// FHA MCAW Total Fixed Pymt-to-Income Ratio [MCAWPUR.X23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawTotalFixedPaymentToIncome1Amount { get => _mcawTotalFixedPaymentToIncome1Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome1Amount, value); }

    /// <summary>
    /// FHA MCAW Ratio Total Fixed Pymt-to-Income [GMCAW.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? McawTotalFixedPaymentToIncome2Amount { get => _mcawTotalFixedPaymentToIncome2Amount; set => SetField(ref _mcawTotalFixedPaymentToIncome2Amount, value); }

    /// <summary>
    /// FHA MCAW Liabilities Total Mo Pymt [1150]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalMonthlyPaymentsAmount { get => _mcawTotalMonthlyPaymentsAmount; set => SetField(ref _mcawTotalMonthlyPaymentsAmount, value); }

    /// <summary>
    /// FHA MCAW Total Mtg Pymt [739]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? McawTotalMortgagePaymentAmount { get => _mcawTotalMortgagePaymentAmount; set => SetField(ref _mcawTotalMortgagePaymentAmount, value); }

    /// <summary>
    /// Underwriting Co-Mortgagor [1384]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyExpenseComortSet { get => _monthlyExpenseComortSet; set => SetField(ref _monthlyExpenseComortSet, value); }

    /// <summary>
    /// Expenses Total Housing Expense [1809]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyHousingExpenseAmount { get => _monthlyHousingExpenseAmount; set => SetField(ref _monthlyHousingExpenseAmount, value); }

    /// <summary>
    /// Expenses Total Mo Installment Exp [382]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyInstallmentExpenseAmount { get => _monthlyInstallmentExpenseAmount; set => SetField(ref _monthlyInstallmentExpenseAmount, value); }

    /// <summary>
    /// Expenses Negative Real Estate [LOANSUB.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyNegativeRealEstateAmount { get => _monthlyNegativeRealEstateAmount; set => SetField(ref _monthlyNegativeRealEstateAmount, value); }

    /// <summary>
    /// Expenses 2nd/Vacation Home [1476]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlySecondHomeAmount { get => _monthlySecondHomeAmount; set => SetField(ref _monthlySecondHomeAmount, value); }

    /// <summary>
    /// Expenses Present MTG Ins [124]
    /// </summary>
    public string? MortgageInsuranceAmount { get => _mortgageInsuranceAmount; set => SetField(ref _mortgageInsuranceAmount, value); }

    /// <summary>
    /// Liabilities Net Worth [734]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NetWorthAmount { get => _netWorthAmount; set => SetField(ref _netWorthAmount, value); }

    /// <summary>
    /// Application OtherAssets
    /// </summary>
    [AllowNull]
    public IList<OtherAsset> OtherAssets { get => GetField(ref _otherAssets); set => SetField(ref _otherAssets, value); }

    /// <summary>
    /// Expenses Present Other Housing [126]
    /// </summary>
    public decimal? OtherHousingExpenseAmount { get => _otherHousingExpenseAmount; set => SetField(ref _otherHousingExpenseAmount, value); }

    /// <summary>
    /// Application OtherIncomeSources
    /// </summary>
    [AllowNull]
    public IList<OtherIncomeSource> OtherIncomeSources { get => GetField(ref _otherIncomeSources); set => SetField(ref _otherIncomeSources, value); }

    /// <summary>
    /// Income Deductions Other Items Deducted [198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherItemsDeducted { get => _otherItemsDeducted; set => SetField(ref _otherItemsDeducted, value); }

    /// <summary>
    /// Application OtherLiabilities
    /// </summary>
    [AllowNull]
    public IList<OtherLiability> OtherLiabilities { get => GetField(ref _otherLiabilities); set => SetField(ref _otherLiabilities, value); }

    /// <summary>
    /// Expenses Present Other Pymt [121]
    /// </summary>
    public decimal? OtherMortgagePrincipalAndInterestAmount { get => _otherMortgagePrincipalAndInterestAmount; set => SetField(ref _otherMortgagePrincipalAndInterestAmount, value); }

    /// <summary>
    /// Borr Other Total Income [URLA.X44]
    /// </summary>
    public decimal? OtherTotalIncome { get => _otherTotalIncome; set => SetField(ref _otherTotalIncome, value); }

    /// <summary>
    /// VA Past Credit Record [1326]
    /// </summary>
    public StringEnumValue<PastCreditRecord> PastCreditRecord { get => _pastCreditRecord; set => SetField(ref _pastCreditRecord, value); }

    /// <summary>
    /// Prequal Credit Report Indicator  [4750]
    /// </summary>
    public bool? PrequalCreditReportIndicator { get => _prequalCreditReportIndicator; set => SetField(ref _prequalCreditReportIndicator, value); }

    /// <summary>
    /// Expenses Co-Borr Present Mo Hous Exp [268]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PresentHousingExpComortSet { get => _presentHousingExpComortSet; set => SetField(ref _presentHousingExpComortSet, value); }

    /// <summary>
    /// Present Supplemental Property Insurance Amount [URLA.X212]
    /// </summary>
    public decimal? PresentSupplementalPropertyInsuranceAmount { get => _presentSupplementalPropertyInsuranceAmount; set => SetField(ref _presentSupplementalPropertyInsuranceAmount, value); }

    /// <summary>
    /// Underwriting Co-Mortgagor Primary Exp [1379]
    /// </summary>
    public decimal? PrimaryResidenceComortSet { get => _primaryResidenceComortSet; set => SetField(ref _primaryResidenceComortSet, value); }

    /// <summary>
    /// Subject Property Occupancy Status [1811]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

    /// <summary>
    /// Underwriting HOA Fees [1729]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedDuesAmount { get => _proposedDuesAmount; set => SetField(ref _proposedDuesAmount, value); }

    /// <summary>
    /// Underwriting First Mtg P&amp;I [1724]
    /// </summary>
    public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => SetField(ref _proposedFirstMortgageAmount, value); }

    /// <summary>
    /// Underwriting Rent [1723]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => SetField(ref _proposedGroundRentAmount, value); }

    /// <summary>
    /// Underwriting Hazard Ins [1726]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => SetField(ref _proposedHazardInsuranceAmount, value); }

    /// <summary>
    /// Insurance Mtg Ins Mo Pymt [1728]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => SetField(ref _proposedMortgageInsuranceAmount, value); }

    /// <summary>
    /// Underwriting Other Fees [1730]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => SetField(ref _proposedOtherAmount, value); }

    /// <summary>
    /// Underwriting Second Mtg P&amp;I [1725]
    /// </summary>
    public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => SetField(ref _proposedOtherMortgagesAmount, value); }

    /// <summary>
    /// Underwriting Taxes [1727]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => SetField(ref _proposedRealEstateTaxesAmount, value); }

    /// <summary>
    /// Application ProvidedDocuments
    /// </summary>
    [AllowNull]
    public IList<ProvidedDocument> ProvidedDocuments { get => GetField(ref _providedDocuments); set => SetField(ref _providedDocuments, value); }

    /// <summary>
    /// Expenses Present Taxes [123]
    /// </summary>
    public string? RealEstateTaxAmount { get => _realEstateTaxAmount; set => SetField(ref _realEstateTaxAmount, value); }

    /// <summary>
    /// Expenses Present Rent [119]
    /// </summary>
    public decimal? RentAmount { get => _rentAmount; set => SetField(ref _rentAmount, value); }

    /// <summary>
    /// Application ReoProperties
    /// </summary>
    [AllowNull]
    public IList<ReoProperty> ReoProperties { get => GetField(ref _reoProperties); set => SetField(ref _reoProperties, value); }

    /// <summary>
    /// Income Total Gross Rent Income [921]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalGrossRentalIncomeAmount { get => _reoTotalGrossRentalIncomeAmount; set => SetField(ref _reoTotalGrossRentalIncomeAmount, value); }

    /// <summary>
    /// Income Total Ins/Tax/Exp Income [923]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMaintenanceAmount { get => _reoTotalMaintenanceAmount; set => SetField(ref _reoTotalMaintenanceAmount, value); }

    /// <summary>
    /// Assets Real Estate Owned [919]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMarketValueAmount { get => _reoTotalMarketValueAmount; set => SetField(ref _reoTotalMarketValueAmount, value); }

    /// <summary>
    /// Income Total Mortgage Pymts Income [922]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMortgagePaymentsAmount { get => _reoTotalMortgagePaymentsAmount; set => SetField(ref _reoTotalMortgagePaymentsAmount, value); }

    /// <summary>
    /// Income Total Amt of Mortgages Income [920]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ReoTotalMortgagesAndLiensAmount { get => _reoTotalMortgagesAndLiensAmount; set => SetField(ref _reoTotalMortgagesAndLiensAmount, value); }

    /// <summary>
    /// Income Total Net Rental Income [924]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ReoTotalNetRentalIncomeAmount { get => _reoTotalNetRentalIncomeAmount; set => SetField(ref _reoTotalNetRentalIncomeAmount, value); }

    /// <summary>
    /// Correspondent Rescission Date [CORRESPONDENT.X316]
    /// </summary>
    public DateTime? RescissionDate { get => _rescissionDate; set => SetField(ref _rescissionDate, value); }

    /// <summary>
    /// Correspondent Rescission Note Signed Date [CORRESPONDENT.X317]
    /// </summary>
    public DateTime? RescissionNoteSignedDate { get => _rescissionNoteSignedDate; set => SetField(ref _rescissionNoteSignedDate, value); }

    /// <summary>
    /// Application Residences
    /// </summary>
    [AllowNull]
    public IList<Residence> Residences { get => GetField(ref _residences); set => SetField(ref _residences, value); }

    /// <summary>
    /// Application Respa6
    /// </summary>
    public string? Respa6 { get => _respa6; set => SetField(ref _respa6, value); }

    /// <summary>
    /// Application SelfEmployedIncomes
    /// </summary>
    [AllowNull]
    public IList<SelfEmployedIncome> SelfEmployedIncomes { get => GetField(ref _selfEmployedIncomes); set => SetField(ref _selfEmployedIncomes, value); }

    /// <summary>
    /// Denial Info - Borrower Country [DENIAL.X98]
    /// </summary>
    public string? SofDBorrCountry { get => _sofDBorrCountry; set => SetField(ref _sofDBorrCountry, value); }

    /// <summary>
    /// Denial Info - Borrower Foreign Address Indicator [DENIAL.X97]
    /// </summary>
    public bool? SofDBorrForeignAddressIndicator { get => _sofDBorrForeignAddressIndicator; set => SetField(ref _sofDBorrForeignAddressIndicator, value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address [DENIAL.X82]
    /// </summary>
    public string? SofDBorrowerAddress { get => _sofDBorrowerAddress; set => SetField(ref _sofDBorrowerAddress, value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - City [DENIAL.X83]
    /// </summary>
    public string? SofDBorrowerAddressCity { get => _sofDBorrowerAddressCity; set => SetField(ref _sofDBorrowerAddressCity, value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - State [DENIAL.X84]
    /// </summary>
    public StringEnumValue<State> SofDBorrowerAddressState { get => _sofDBorrowerAddressState; set => SetField(ref _sofDBorrowerAddressState, value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address Type [DENIAL.X81]
    /// </summary>
    public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => _sofDBorrowerAddressType; set => SetField(ref _sofDBorrowerAddressType, value); }

    /// <summary>
    /// Denial Discl Info - Borrower Address - Zipcode [DENIAL.X85]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SofDBorrowerAddressZipcode { get => _sofDBorrowerAddressZipcode; set => SetField(ref _sofDBorrowerAddressZipcode, value); }

    /// <summary>
    /// Denial Info - Coborrower Country [DENIAL.X100]
    /// </summary>
    public string? SofDCoBorrCountry { get => _sofDCoBorrCountry; set => SetField(ref _sofDCoBorrCountry, value); }

    /// <summary>
    /// Denial Info - Coborrower Foreign Address Indicator [DENIAL.X99]
    /// </summary>
    public bool? SofDCoBorrForeignAddressIndicator { get => _sofDCoBorrForeignAddressIndicator; set => SetField(ref _sofDCoBorrForeignAddressIndicator, value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address [DENIAL.X87]
    /// </summary>
    public string? SofDCoBorrowerAddress { get => _sofDCoBorrowerAddress; set => SetField(ref _sofDCoBorrowerAddress, value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - City [DENIAL.X88]
    /// </summary>
    public string? SofDCoBorrowerAddressCity { get => _sofDCoBorrowerAddressCity; set => SetField(ref _sofDCoBorrowerAddressCity, value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - State [DENIAL.X89]
    /// </summary>
    public StringEnumValue<State> SofDCoBorrowerAddressState { get => _sofDCoBorrowerAddressState; set => SetField(ref _sofDCoBorrowerAddressState, value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address Type [DENIAL.X86]
    /// </summary>
    public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => _sofDCoBorrowerAddressType; set => SetField(ref _sofDCoBorrowerAddressType, value); }

    /// <summary>
    /// Denial Discl Info - Coborrower Address - Zipcode [DENIAL.X90]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SofDCoBorrowerAddressZipcode { get => _sofDCoBorrowerAddressZipcode; set => SetField(ref _sofDCoBorrowerAddressZipcode, value); }

    /// <summary>
    /// VA Veteran Income Consider Spouse Income [1006]
    /// </summary>
    public bool? SpouseIncomeConsider { get => _spouseIncomeConsider; set => SetField(ref _spouseIncomeConsider, value); }

    /// <summary>
    /// Application Tax4506s
    /// </summary>
    [AllowNull]
    public IList<Tax4506> Tax4506s { get => GetField(ref _tax4506s); set => SetField(ref _tax4506s, value); }

    /// <summary>
    /// Trans Details Qual Ratio Top [740]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TopRatioPercent { get => _topRatioPercent; set => SetField(ref _topRatioPercent, value); }

    /// <summary>
    /// Total Additional Assets Amount [URLA.X49]
    /// </summary>
    public decimal? TotalAdditionalAssetsAmount { get => _totalAdditionalAssetsAmount; set => SetField(ref _totalAdditionalAssetsAmount, value); }

    /// <summary>
    /// Total Additional Loans Amount [URLA.X229]
    /// </summary>
    public decimal? TotalAdditionalLoansAmount { get => _totalAdditionalLoansAmount; set => SetField(ref _totalAdditionalLoansAmount, value); }

    /// <summary>
    /// Total Additional Other Assets Amount [URLA.X53]
    /// </summary>
    public decimal? TotalAdditionalOtherAssetsAmount { get => _totalAdditionalOtherAssetsAmount; set => SetField(ref _totalAdditionalOtherAssetsAmount, value); }

    /// <summary>
    /// Total Applied To Downpayment [URLA.X230]
    /// </summary>
    public decimal? TotalAppliedToDownpayment { get => _totalAppliedToDownpayment; set => SetField(ref _totalAppliedToDownpayment, value); }

    /// <summary>
    /// Assets Total Assets [732]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAssetsAmount { get => _totalAssetsAmount; set => SetField(ref _totalAssetsAmount, value); }

    /// <summary>
    /// Income Total Base Income (Borr/Co-Borr) [901]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBaseIncomeAmount { get => _totalBaseIncomeAmount; set => SetField(ref _totalBaseIncomeAmount, value); }

    /// <summary>
    /// Income Total Bonuses (Borr/Co-Borr) [903]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBonusAmount { get => _totalBonusAmount; set => SetField(ref _totalBonusAmount, value); }

    /// <summary>
    /// Income Total Commissions (Borr/Co-Borr) [904]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCommissionsAmount { get => _totalCommissionsAmount; set => SetField(ref _totalCommissionsAmount, value); }

    /// <summary>
    /// Assets Total Bank Deposits [979]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDeposit { get => _totalDeposit; set => SetField(ref _totalDeposit, value); }

    /// <summary>
    /// Income Total Div/Int (Borr/Co-Borr) [905]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDividendsInterestAmount { get => _totalDividendsInterestAmount; set => SetField(ref _totalDividendsInterestAmount, value); }

    /// <summary>
    /// Income Total Mo Income Spouse/Borr [1810]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEmploymentAmount { get => _totalEmploymentAmount; set => SetField(ref _totalEmploymentAmount, value); }

    /// <summary>
    /// Expenses Total Mo Expense [1187]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalFixedPaymentAmount { get => _totalFixedPaymentAmount; set => SetField(ref _totalFixedPaymentAmount, value); }

    /// <summary>
    /// Income Total Mo Income (Borr/Co-Borr) [1389]
    /// </summary>
    public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => SetField(ref _totalGrossMonthlyIncomeAmount, value); }

    /// <summary>
    /// Income Total Mo Income [736]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalIncomeAmount { get => _totalIncomeAmount; set => SetField(ref _totalIncomeAmount, value); }

    /// <summary>
    /// Liabilities Total Liability Pymt [350]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyPaymentAmount { get => _totalMonthlyPaymentAmount; set => SetField(ref _totalMonthlyPaymentAmount, value); }

    /// <summary>
    /// Trans Details Total Mtg Bal [941]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMortgagesBalanceAmount { get => _totalMortgagesBalanceAmount; set => SetField(ref _totalMortgagesBalanceAmount, value); }

    /// <summary>
    /// Trans Details Total Mtg Mo Pymt [909]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMortgagesMonthlyPaymentAmount { get => _totalMortgagesMonthlyPaymentAmount; set => SetField(ref _totalMortgagesMonthlyPaymentAmount, value); }

    /// <summary>
    /// Income Total Net Rent Income (Borr/Co-Borr) [906]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalNetRentalIncomeAmount { get => _totalNetRentalIncomeAmount; set => SetField(ref _totalNetRentalIncomeAmount, value); }

    /// <summary>
    /// Income Total Other 1 (Borr/Co-Borr) [907]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOther1Amount { get => _totalOther1Amount; set => SetField(ref _totalOther1Amount, value); }

    /// <summary>
    /// Income Total Other 2 (Borr/Co-Borr) [908]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOther2Amount { get => _totalOther2Amount; set => SetField(ref _totalOther2Amount, value); }

    /// <summary>
    /// Total Other Assets Amount [URLA.X54]
    /// </summary>
    public decimal? TotalOtherAssetsAmount { get => _totalOtherAssetsAmount; set => SetField(ref _totalOtherAssetsAmount, value); }

    /// <summary>
    /// Income Total Overtime (Borr/Co-Borr) [902]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOvertimeAmount { get => _totalOvertimeAmount; set => SetField(ref _totalOvertimeAmount, value); }

    /// <summary>
    /// Trans Details Total Proposed Mo Pymt [1742]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaymentsAmount { get => _totalPaymentsAmount; set => SetField(ref _totalPaymentsAmount, value); }

    /// <summary>
    /// Expenses Total Primary Expenses [1731]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPrimaryHousingExpenseAmount { get => _totalPrimaryHousingExpenseAmount; set => SetField(ref _totalPrimaryHousingExpenseAmount, value); }

    /// <summary>
    /// Application TotalReoMarketValueAmount
    /// </summary>
    public decimal? TotalReoMarketValueAmount { get => _totalReoMarketValueAmount; set => SetField(ref _totalReoMarketValueAmount, value); }

    /// <summary>
    /// Total Assets Amount [URLA.X50]
    /// </summary>
    public decimal? TotalURLA2020AssetsAmount { get => _totalURLA2020AssetsAmount; set => SetField(ref _totalURLA2020AssetsAmount, value); }

    /// <summary>
    /// Income Total Other Income (User Defined) [1817]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalUserDefinedIncome { get => _totalUserDefinedIncome; set => SetField(ref _totalUserDefinedIncome, value); }

    /// <summary>
    /// Application TQLReports
    /// </summary>
    [AllowNull]
    public IList<TQLReportInformation> TQLReports { get => GetField(ref _tQLReports); set => SetField(ref _tQLReports, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Addr [DISCLOSURE.X22]
    /// </summary>
    public string? TransUnionAddress { get => _transUnionAddress; set => SetField(ref _transUnionAddress, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co City [DISCLOSURE.X23]
    /// </summary>
    public string? TransUnionCity { get => _transUnionCity; set => SetField(ref _transUnionCity, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Fax [DISCLOSURE.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TransUnionFax { get => _transUnionFax; set => SetField(ref _transUnionFax, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Model [DISCLOSURE.X28]
    /// </summary>
    public string? TransUnionModel { get => _transUnionModel; set => SetField(ref _transUnionModel, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Name [DISCLOSURE.X21]
    /// </summary>
    public string? TransUnionName { get => _transUnionName; set => SetField(ref _transUnionName, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Phone [DISCLOSURE.X26]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TransUnionPhone { get => _transUnionPhone; set => SetField(ref _transUnionPhone, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Zip [DISCLOSURE.X25]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? TransUnionPostalCode { get => _transUnionPostalCode; set => SetField(ref _transUnionPostalCode, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Range Scores From [DISCLOSURE.X29]
    /// </summary>
    public string? TransUnionScoreRangeFrom { get => _transUnionScoreRangeFrom; set => SetField(ref _transUnionScoreRangeFrom, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Range Scores To [DISCLOSURE.X30]
    /// </summary>
    public string? TransUnionScoreRangeTo { get => _transUnionScoreRangeTo; set => SetField(ref _transUnionScoreRangeTo, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co State [DISCLOSURE.X24]
    /// </summary>
    public StringEnumValue<State> TransUnionState { get => _transUnionState; set => SetField(ref _transUnionState, value); }

    /// <summary>
    /// Disclosure Cred Bureau 2 Co Website [DISCLOSURE.X639]
    /// </summary>
    public string? TransUnionWebsite { get => _transUnionWebsite; set => SetField(ref _transUnionWebsite, value); }

    /// <summary>
    /// Application URLAAlternateNames
    /// </summary>
    [AllowNull]
    public IList<URLAAlternateName> URLAAlternateNames { get => GetField(ref _uRLAAlternateNames); set => SetField(ref _uRLAAlternateNames, value); }

    /// <summary>
    /// Application UserDefinedIncome
    /// </summary>
    public decimal? UserDefinedIncome { get => _userDefinedIncome; set => SetField(ref _userDefinedIncome, value); }

    /// <summary>
    /// Income Borr/Co-Borr Other Income 2 Descr [1818]
    /// </summary>
    public string? UserDefinedIncomeDescription { get => _userDefinedIncomeDescription; set => SetField(ref _userDefinedIncomeDescription, value); }

    /// <summary>
    /// VA Meets VA Credit Standards [1327]
    /// </summary>
    public StringEnumValue<YOrN> VACreditStandards { get => _vACreditStandards; set => SetField(ref _vACreditStandards, value); }

    /// <summary>
    /// VA Veteran Income Spouse Income Amt [1008]
    /// </summary>
    public decimal? VaSummarySpouseIncomeAmount { get => _vaSummarySpouseIncomeAmount; set => SetField(ref _vaSummarySpouseIncomeAmount, value); }

    /// <summary>
    /// Income Total Mo Gross Income [993]
    /// </summary>
    public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => _vaSummaryTotalMonthlyGrossIncomeAmount; set => SetField(ref _vaSummaryTotalMonthlyGrossIncomeAmount, value); }
}