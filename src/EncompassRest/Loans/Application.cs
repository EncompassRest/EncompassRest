using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Application : IDirty
    {
        private DirtyValue<string> _accountNumber1;
        public string AccountNumber1 { get => _accountNumber1; set => _accountNumber1 = value; }
        private DirtyValue<string> _accountNumber2;
        public string AccountNumber2 { get => _accountNumber2; set => _accountNumber2 = value; }
        private DirtyValue<decimal?> _allOtherPaymentsAmount;
        public decimal? AllOtherPaymentsAmount { get => _allOtherPaymentsAmount; set => _allOtherPaymentsAmount = value; }
        private DirtyValue<string> _applicationId;
        public string ApplicationId { get => _applicationId; set => _applicationId = value; }
        private DirtyValue<int?> _applicationIndex;
        public int? ApplicationIndex { get => _applicationIndex; set => _applicationIndex = value; }
        private DirtyValue<DateTime?> _applicationSignedDate;
        public DateTime? ApplicationSignedDate { get => _applicationSignedDate; set => _applicationSignedDate = value; }
        private DirtyList<Asset> _assets;
        public IList<Asset> Assets { get => _assets ?? (_assets = new DirtyList<Asset>()); set => _assets = new DirtyList<Asset>(value); }
        private DirtyValue<decimal?> _assetsAvailableAmount;
        public decimal? AssetsAvailableAmount { get => _assetsAvailableAmount; set => _assetsAvailableAmount = value; }
        private ATRQMBorrower _aTRQMBorrower;
        public ATRQMBorrower ATRQMBorrower { get => _aTRQMBorrower ?? (_aTRQMBorrower = new ATRQMBorrower()); set => _aTRQMBorrower = value; }
        private DirtyList<ATRQMBorrower> _aTRQMBorrowers;
        public IList<ATRQMBorrower> ATRQMBorrowers { get => _aTRQMBorrowers ?? (_aTRQMBorrowers = new DirtyList<ATRQMBorrower>()); set => _aTRQMBorrowers = new DirtyList<ATRQMBorrower>(value); }
        private DirtyList<AUSTrackingLog> _aUSTrackingLogs;
        public IList<AUSTrackingLog> AUSTrackingLogs { get => _aUSTrackingLogs ?? (_aUSTrackingLogs = new DirtyList<AUSTrackingLog>()); set => _aUSTrackingLogs = new DirtyList<AUSTrackingLog>(value); }
        private DirtyValue<decimal?> _balanceAvailableFamilySupportGuideline;
        public decimal? BalanceAvailableFamilySupportGuideline { get => _balanceAvailableFamilySupportGuideline; set => _balanceAvailableFamilySupportGuideline = value; }
        private Borrower _borrower;
        public Borrower Borrower { get => _borrower ?? (_borrower = new Borrower()); set => _borrower = value; }
        private DirtyValue<decimal?> _bottomRatioPercent;
        public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => _bottomRatioPercent = value; }
        private DirtyValue<decimal?> _brwCoBrwTotalTaxDeductions;
        public decimal? BrwCoBrwTotalTaxDeductions { get => _brwCoBrwTotalTaxDeductions; set => _brwCoBrwTotalTaxDeductions = value; }
        private Borrower _coborrower;
        public Borrower Coborrower { get => _coborrower ?? (_coborrower = new Borrower()); set => _coborrower = value; }
        private DirtyValue<string> _creditAliasName1;
        public string CreditAliasName1 { get => _creditAliasName1; set => _creditAliasName1 = value; }
        private DirtyValue<string> _creditAliasName2;
        public string CreditAliasName2 { get => _creditAliasName2; set => _creditAliasName2 = value; }
        private DirtyValue<string> _creditorName1;
        public string CreditorName1 { get => _creditorName1; set => _creditorName1 = value; }
        private DirtyValue<string> _creditorName2;
        public string CreditorName2 { get => _creditorName2; set => _creditorName2 = value; }
        private DirtyValue<string> _creditReportReferenceIdentifier;
        public string CreditReportReferenceIdentifier { get => _creditReportReferenceIdentifier; set => _creditReportReferenceIdentifier = value; }
        private DirtyList<Employment> _employment;
        public IList<Employment> Employment { get => _employment ?? (_employment = new DirtyList<Employment>()); set => _employment = new DirtyList<Employment>(value); }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _equifaxAddress;
        public string EquifaxAddress { get => _equifaxAddress; set => _equifaxAddress = value; }
        private DirtyValue<string> _equifaxCity;
        public string EquifaxCity { get => _equifaxCity; set => _equifaxCity = value; }
        private DirtyValue<string> _equifaxFax;
        public string EquifaxFax { get => _equifaxFax; set => _equifaxFax = value; }
        private DirtyValue<string> _equifaxModel;
        public string EquifaxModel { get => _equifaxModel; set => _equifaxModel = value; }
        private DirtyValue<string> _equifaxName;
        public string EquifaxName { get => _equifaxName; set => _equifaxName = value; }
        private DirtyValue<string> _equifaxPhone;
        public string EquifaxPhone { get => _equifaxPhone; set => _equifaxPhone = value; }
        private DirtyValue<string> _equifaxPostalCode;
        public string EquifaxPostalCode { get => _equifaxPostalCode; set => _equifaxPostalCode = value; }
        private DirtyValue<string> _equifaxScoreRangeFrom;
        public string EquifaxScoreRangeFrom { get => _equifaxScoreRangeFrom; set => _equifaxScoreRangeFrom = value; }
        private DirtyValue<string> _equifaxScoreRangeTo;
        public string EquifaxScoreRangeTo { get => _equifaxScoreRangeTo; set => _equifaxScoreRangeTo = value; }
        private DirtyValue<string> _equifaxState;
        public string EquifaxState { get => _equifaxState; set => _equifaxState = value; }
        private DirtyValue<string> _equifaxWebsite;
        public string EquifaxWebsite { get => _equifaxWebsite; set => _equifaxWebsite = value; }
        private DirtyValue<string> _experianAddress;
        public string ExperianAddress { get => _experianAddress; set => _experianAddress = value; }
        private DirtyValue<string> _experianCity;
        public string ExperianCity { get => _experianCity; set => _experianCity = value; }
        private DirtyValue<string> _experianFax;
        public string ExperianFax { get => _experianFax; set => _experianFax = value; }
        private DirtyValue<string> _experianModel;
        public string ExperianModel { get => _experianModel; set => _experianModel = value; }
        private DirtyValue<string> _experianName;
        public string ExperianName { get => _experianName; set => _experianName = value; }
        private DirtyValue<string> _experianPhone;
        public string ExperianPhone { get => _experianPhone; set => _experianPhone = value; }
        private DirtyValue<string> _experianPostalCode;
        public string ExperianPostalCode { get => _experianPostalCode; set => _experianPostalCode = value; }
        private DirtyValue<string> _experianScoreRangeFrom;
        public string ExperianScoreRangeFrom { get => _experianScoreRangeFrom; set => _experianScoreRangeFrom = value; }
        private DirtyValue<string> _experianScoreRangeTo;
        public string ExperianScoreRangeTo { get => _experianScoreRangeTo; set => _experianScoreRangeTo = value; }
        private DirtyValue<string> _experianState;
        public string ExperianState { get => _experianState; set => _experianState = value; }
        private DirtyValue<string> _experianWebsite;
        public string ExperianWebsite { get => _experianWebsite; set => _experianWebsite = value; }
        private DirtyValue<decimal?> _fhaVaDebtIncomeRatio;
        public decimal? FhaVaDebtIncomeRatio { get => _fhaVaDebtIncomeRatio; set => _fhaVaDebtIncomeRatio = value; }
        private DirtyValue<decimal?> _fhaVaFamilySupportAmount;
        public decimal? FhaVaFamilySupportAmount { get => _fhaVaFamilySupportAmount; set => _fhaVaFamilySupportAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; set => _fhaVaTotalEstimatedMonthlyShelterExpenseAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetEffectiveIncomeAmount;
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get => _fhaVaTotalNetEffectiveIncomeAmount; set => _fhaVaTotalNetEffectiveIncomeAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetIncomeAmount;
        public decimal? FhaVaTotalNetIncomeAmount { get => _fhaVaTotalNetIncomeAmount; set => _fhaVaTotalNetIncomeAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalNetTakeHomePayAmount;
        public decimal? FhaVaTotalNetTakeHomePayAmount { get => _fhaVaTotalNetTakeHomePayAmount; set => _fhaVaTotalNetTakeHomePayAmount = value; }
        private DirtyValue<decimal?> _fhaVaTotalOtherNetIncome;
        public decimal? FhaVaTotalOtherNetIncome { get => _fhaVaTotalOtherNetIncome; set => _fhaVaTotalOtherNetIncome = value; }
        private DirtyValue<decimal?> _firstMortgagePrincipalAndInterestAmount;
        public decimal? FirstMortgagePrincipalAndInterestAmount { get => _firstMortgagePrincipalAndInterestAmount; set => _firstMortgagePrincipalAndInterestAmount = value; }
        private DirtyValue<string> _freddieMacCreditReportReferenceIdentifier;
        public string FreddieMacCreditReportReferenceIdentifier { get => _freddieMacCreditReportReferenceIdentifier; set => _freddieMacCreditReportReferenceIdentifier = value; }
        private DirtyValue<decimal?> _freddieMacOccupantDebtRatio;
        public decimal? FreddieMacOccupantDebtRatio { get => _freddieMacOccupantDebtRatio; set => _freddieMacOccupantDebtRatio = value; }
        private DirtyValue<decimal?> _freddieMacOccupantHousingRatio;
        public decimal? FreddieMacOccupantHousingRatio { get => _freddieMacOccupantHousingRatio; set => _freddieMacOccupantHousingRatio = value; }
        private DirtyValue<decimal?> _freDebtToHousingGapRatio;
        public decimal? FreDebtToHousingGapRatio { get => _freDebtToHousingGapRatio; set => _freDebtToHousingGapRatio = value; }
        private DirtyValue<decimal?> _grossBaseIncomeAmount;
        public decimal? GrossBaseIncomeAmount { get => _grossBaseIncomeAmount; set => _grossBaseIncomeAmount = value; }
        private DirtyValue<decimal?> _grossIncomeForComortSet;
        public decimal? GrossIncomeForComortSet { get => _grossIncomeForComortSet; set => _grossIncomeForComortSet = value; }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => _grossNegativeCashFlow = value; }
        private DirtyValue<decimal?> _grossOtherIncomeAmount;
        public decimal? GrossOtherIncomeAmount { get => _grossOtherIncomeAmount; set => _grossOtherIncomeAmount = value; }
        private DirtyValue<decimal?> _grossPositiveCashFlow;
        public decimal? GrossPositiveCashFlow { get => _grossPositiveCashFlow; set => _grossPositiveCashFlow = value; }
        private DirtyValue<string> _hazardInsuranceAmount;
        public string HazardInsuranceAmount { get => _hazardInsuranceAmount; set => _hazardInsuranceAmount = value; }
        private DirtyValue<string> _homeownersAssociationDuesAndCondoFeesAmount;
        public string HomeownersAssociationDuesAndCondoFeesAmount { get => _homeownersAssociationDuesAndCondoFeesAmount; set => _homeownersAssociationDuesAndCondoFeesAmount = value; }
        private DirtyValue<string> _hudAutoLienHolderName1;
        public string HudAutoLienHolderName1 { get => _hudAutoLienHolderName1; set => _hudAutoLienHolderName1 = value; }
        private DirtyValue<string> _hudAutoLienHolderName2;
        public string HudAutoLienHolderName2 { get => _hudAutoLienHolderName2; set => _hudAutoLienHolderName2 = value; }
        private DirtyValue<decimal?> _hudAutoLoanAmount1;
        public decimal? HudAutoLoanAmount1 { get => _hudAutoLoanAmount1; set => _hudAutoLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudAutoLoanAmount2;
        public decimal? HudAutoLoanAmount2 { get => _hudAutoLoanAmount2; set => _hudAutoLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment1;
        public decimal? HudAutoMonthlyPayment1 { get => _hudAutoMonthlyPayment1; set => _hudAutoMonthlyPayment1 = value; }
        private DirtyValue<decimal?> _hudAutoMonthlyPayment2;
        public decimal? HudAutoMonthlyPayment2 { get => _hudAutoMonthlyPayment2; set => _hudAutoMonthlyPayment2 = value; }
        private DirtyValue<decimal?> _hudAutoPresentBalance1;
        public decimal? HudAutoPresentBalance1 { get => _hudAutoPresentBalance1; set => _hudAutoPresentBalance1 = value; }
        private DirtyValue<decimal?> _hudAutoPresentBalance2;
        public decimal? HudAutoPresentBalance2 { get => _hudAutoPresentBalance2; set => _hudAutoPresentBalance2 = value; }
        private DirtyValue<string> _hudAutoYearAndMake1;
        public string HudAutoYearAndMake1 { get => _hudAutoYearAndMake1; set => _hudAutoYearAndMake1 = value; }
        private DirtyValue<string> _hudAutoYearAndMake2;
        public string HudAutoYearAndMake2 { get => _hudAutoYearAndMake2; set => _hudAutoYearAndMake2 = value; }
        private DirtyValue<decimal?> _hudLoanAmount1;
        public decimal? HudLoanAmount1 { get => _hudLoanAmount1; set => _hudLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudLoanAmount10;
        public decimal? HudLoanAmount10 { get => _hudLoanAmount10; set => _hudLoanAmount10 = value; }
        private DirtyValue<decimal?> _hudLoanAmount11;
        public decimal? HudLoanAmount11 { get => _hudLoanAmount11; set => _hudLoanAmount11 = value; }
        private DirtyValue<decimal?> _hudLoanAmount2;
        public decimal? HudLoanAmount2 { get => _hudLoanAmount2; set => _hudLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudLoanAmount3;
        public decimal? HudLoanAmount3 { get => _hudLoanAmount3; set => _hudLoanAmount3 = value; }
        private DirtyValue<decimal?> _hudLoanAmount4;
        public decimal? HudLoanAmount4 { get => _hudLoanAmount4; set => _hudLoanAmount4 = value; }
        private DirtyValue<decimal?> _hudLoanAmount5;
        public decimal? HudLoanAmount5 { get => _hudLoanAmount5; set => _hudLoanAmount5 = value; }
        private DirtyValue<decimal?> _hudLoanAmount6;
        public decimal? HudLoanAmount6 { get => _hudLoanAmount6; set => _hudLoanAmount6 = value; }
        private DirtyValue<decimal?> _hudLoanAmount7;
        public decimal? HudLoanAmount7 { get => _hudLoanAmount7; set => _hudLoanAmount7 = value; }
        private DirtyValue<decimal?> _hudLoanAmount8;
        public decimal? HudLoanAmount8 { get => _hudLoanAmount8; set => _hudLoanAmount8 = value; }
        private DirtyValue<decimal?> _hudLoanAmount9;
        public decimal? HudLoanAmount9 { get => _hudLoanAmount9; set => _hudLoanAmount9 = value; }
        private DirtyValue<bool?> _hudRealEstateFhaInsured1;
        public bool? HudRealEstateFhaInsured1 { get => _hudRealEstateFhaInsured1; set => _hudRealEstateFhaInsured1 = value; }
        private DirtyValue<bool?> _hudRealEstateFhaInsured2;
        public bool? HudRealEstateFhaInsured2 { get => _hudRealEstateFhaInsured2; set => _hudRealEstateFhaInsured2 = value; }
        private DirtyValue<string> _hudRealEstateLienHolder1;
        public string HudRealEstateLienHolder1 { get => _hudRealEstateLienHolder1; set => _hudRealEstateLienHolder1 = value; }
        private DirtyValue<string> _hudRealEstateLienHolder2;
        public string HudRealEstateLienHolder2 { get => _hudRealEstateLienHolder2; set => _hudRealEstateLienHolder2 = value; }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount1;
        public decimal? HudRealEstateLoanAmount1 { get => _hudRealEstateLoanAmount1; set => _hudRealEstateLoanAmount1 = value; }
        private DirtyValue<decimal?> _hudRealEstateLoanAmount2;
        public decimal? HudRealEstateLoanAmount2 { get => _hudRealEstateLoanAmount2; set => _hudRealEstateLoanAmount2 = value; }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment1;
        public decimal? HudRealEstateMonthlyPayment1 { get => _hudRealEstateMonthlyPayment1; set => _hudRealEstateMonthlyPayment1 = value; }
        private DirtyValue<decimal?> _hudRealEstateMonthlyPayment2;
        public decimal? HudRealEstateMonthlyPayment2 { get => _hudRealEstateMonthlyPayment2; set => _hudRealEstateMonthlyPayment2 = value; }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance1;
        public decimal? HudRealEstatePresentBalance1 { get => _hudRealEstatePresentBalance1; set => _hudRealEstatePresentBalance1 = value; }
        private DirtyValue<decimal?> _hudRealEstatePresentBalance2;
        public decimal? HudRealEstatePresentBalance2 { get => _hudRealEstatePresentBalance2; set => _hudRealEstatePresentBalance2 = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyList<Income> _income;
        public IList<Income> Income { get => _income ?? (_income = new DirtyList<Income>()); set => _income = new DirtyList<Income>(value); }
        private DirtyValue<bool?> _incomeOfBorrowersSpouseUsedIndicator;
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get => _incomeOfBorrowersSpouseUsedIndicator; set => _incomeOfBorrowersSpouseUsedIndicator = value; }
        private DirtyValue<bool?> _incomeOtherThanBorrowerUsedIndicator;
        public bool? IncomeOtherThanBorrowerUsedIndicator { get => _incomeOtherThanBorrowerUsedIndicator; set => _incomeOtherThanBorrowerUsedIndicator = value; }
        private DirtyValue<bool?> _jointAssetLiabilityReportingIndicator;
        public bool? JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => _jointAssetLiabilityReportingIndicator = value; }
        private DirtyList<Liability> _liabilities;
        public IList<Liability> Liabilities { get => _liabilities ?? (_liabilities = new DirtyList<Liability>()); set => _liabilities = new DirtyList<Liability>(value); }
        private DirtyValue<decimal?> _liquidAssetsComortSet;
        public decimal? LiquidAssetsComortSet { get => _liquidAssetsComortSet; set => _liquidAssetsComortSet = value; }
        private DirtyValue<decimal?> _mcawBorrowerOtherMonthlyIncomeAmount;
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get => _mcawBorrowerOtherMonthlyIncomeAmount; set => _mcawBorrowerOtherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawCoborrowerOtherMonthlyIncomeAmount;
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get => _mcawCoborrowerOtherMonthlyIncomeAmount; set => _mcawCoborrowerOtherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawGrossMonthlyIncomeAmount;
        public decimal? McawGrossMonthlyIncomeAmount { get => _mcawGrossMonthlyIncomeAmount; set => _mcawGrossMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome1Amount;
        public decimal? McawMortgagePaymentToIncome1Amount { get => _mcawMortgagePaymentToIncome1Amount; set => _mcawMortgagePaymentToIncome1Amount = value; }
        private DirtyValue<decimal?> _mcawMortgagePaymentToIncome2Amount;
        public decimal? McawMortgagePaymentToIncome2Amount { get => _mcawMortgagePaymentToIncome2Amount; set => _mcawMortgagePaymentToIncome2Amount = value; }
        private DirtyValue<decimal?> _mcawOtherAmount;
        public decimal? McawOtherAmount { get => _mcawOtherAmount; set => _mcawOtherAmount = value; }
        private DirtyValue<decimal?> _mcawOtherDebtsAndObligationsAmount;
        public decimal? McawOtherDebtsAndObligationsAmount { get => _mcawOtherDebtsAndObligationsAmount; set => _mcawOtherDebtsAndObligationsAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForPurchaseAmount;
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get => _mcawTotalFixedPaymentForPurchaseAmount; set => _mcawTotalFixedPaymentForPurchaseAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentForRefinanceAmount;
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get => _mcawTotalFixedPaymentForRefinanceAmount; set => _mcawTotalFixedPaymentForRefinanceAmount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome1Amount;
        public decimal? McawTotalFixedPaymentToIncome1Amount { get => _mcawTotalFixedPaymentToIncome1Amount; set => _mcawTotalFixedPaymentToIncome1Amount = value; }
        private DirtyValue<decimal?> _mcawTotalFixedPaymentToIncome2Amount;
        public decimal? McawTotalFixedPaymentToIncome2Amount { get => _mcawTotalFixedPaymentToIncome2Amount; set => _mcawTotalFixedPaymentToIncome2Amount = value; }
        private DirtyValue<decimal?> _mcawTotalMonthlyPaymentsAmount;
        public decimal? McawTotalMonthlyPaymentsAmount { get => _mcawTotalMonthlyPaymentsAmount; set => _mcawTotalMonthlyPaymentsAmount = value; }
        private DirtyValue<decimal?> _mcawTotalMortgagePaymentAmount;
        public decimal? McawTotalMortgagePaymentAmount { get => _mcawTotalMortgagePaymentAmount; set => _mcawTotalMortgagePaymentAmount = value; }
        private DirtyValue<decimal?> _monthlyExpenseComortSet;
        public decimal? MonthlyExpenseComortSet { get => _monthlyExpenseComortSet; set => _monthlyExpenseComortSet = value; }
        private DirtyValue<decimal?> _monthlyHousingExpenseAmount;
        public decimal? MonthlyHousingExpenseAmount { get => _monthlyHousingExpenseAmount; set => _monthlyHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _monthlyInstallmentExpenseAmount;
        public decimal? MonthlyInstallmentExpenseAmount { get => _monthlyInstallmentExpenseAmount; set => _monthlyInstallmentExpenseAmount = value; }
        private DirtyValue<decimal?> _monthlyNegativeRealEstateAmount;
        public decimal? MonthlyNegativeRealEstateAmount { get => _monthlyNegativeRealEstateAmount; set => _monthlyNegativeRealEstateAmount = value; }
        private DirtyValue<decimal?> _monthlySecondHomeAmount;
        public decimal? MonthlySecondHomeAmount { get => _monthlySecondHomeAmount; set => _monthlySecondHomeAmount = value; }
        private DirtyValue<string> _mortgageInsuranceAmount;
        public string MortgageInsuranceAmount { get => _mortgageInsuranceAmount; set => _mortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _netWorthAmount;
        public decimal? NetWorthAmount { get => _netWorthAmount; set => _netWorthAmount = value; }
        private DirtyValue<decimal?> _otherHousingExpenseAmount;
        public decimal? OtherHousingExpenseAmount { get => _otherHousingExpenseAmount; set => _otherHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _otherItemsDeducted;
        public decimal? OtherItemsDeducted { get => _otherItemsDeducted; set => _otherItemsDeducted = value; }
        private DirtyValue<decimal?> _otherMortgagePrincipalAndInterestAmount;
        public decimal? OtherMortgagePrincipalAndInterestAmount { get => _otherMortgagePrincipalAndInterestAmount; set => _otherMortgagePrincipalAndInterestAmount = value; }
        private DirtyValue<StringEnumValue<PastCreditRecord>> _pastCreditRecord;
        public StringEnumValue<PastCreditRecord> PastCreditRecord { get => _pastCreditRecord; set => _pastCreditRecord = value; }
        private DirtyValue<decimal?> _presentHousingExpComortSet;
        public decimal? PresentHousingExpComortSet { get => _presentHousingExpComortSet; set => _presentHousingExpComortSet = value; }
        private DirtyValue<decimal?> _primaryResidenceComortSet;
        public decimal? PrimaryResidenceComortSet { get => _primaryResidenceComortSet; set => _primaryResidenceComortSet = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _propertyUsageType;
        public StringEnumValue<PropertyUsageType> PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<string> _proposedDuesAmount;
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => _proposedDuesAmount = value; }
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => _proposedFirstMortgageAmount = value; }
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => _proposedGroundRentAmount = value; }
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => _proposedHazardInsuranceAmount = value; }
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => _proposedMortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedOtherAmount;
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => _proposedOtherAmount = value; }
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => _proposedOtherMortgagesAmount = value; }
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => _proposedRealEstateTaxesAmount = value; }
        private DirtyValue<string> _realEstateTaxAmount;
        public string RealEstateTaxAmount { get => _realEstateTaxAmount; set => _realEstateTaxAmount = value; }
        private DirtyValue<decimal?> _rentAmount;
        public decimal? RentAmount { get => _rentAmount; set => _rentAmount = value; }
        private DirtyList<ReoProperty> _reoProperties;
        public IList<ReoProperty> ReoProperties { get => _reoProperties ?? (_reoProperties = new DirtyList<ReoProperty>()); set => _reoProperties = new DirtyList<ReoProperty>(value); }
        private DirtyValue<decimal?> _reoTotalGrossRentalIncomeAmount;
        public decimal? ReoTotalGrossRentalIncomeAmount { get => _reoTotalGrossRentalIncomeAmount; set => _reoTotalGrossRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _reoTotalMaintenanceAmount;
        public decimal? ReoTotalMaintenanceAmount { get => _reoTotalMaintenanceAmount; set => _reoTotalMaintenanceAmount = value; }
        private DirtyValue<decimal?> _reoTotalMarketValueAmount;
        public decimal? ReoTotalMarketValueAmount { get => _reoTotalMarketValueAmount; set => _reoTotalMarketValueAmount = value; }
        private DirtyValue<decimal?> _reoTotalMortgagePaymentsAmount;
        public decimal? ReoTotalMortgagePaymentsAmount { get => _reoTotalMortgagePaymentsAmount; set => _reoTotalMortgagePaymentsAmount = value; }
        private DirtyValue<decimal?> _reoTotalMortgagesAndLiensAmount;
        public decimal? ReoTotalMortgagesAndLiensAmount { get => _reoTotalMortgagesAndLiensAmount; set => _reoTotalMortgagesAndLiensAmount = value; }
        private DirtyValue<int?> _reoTotalNetRentalIncomeAmount;
        public int? ReoTotalNetRentalIncomeAmount { get => _reoTotalNetRentalIncomeAmount; set => _reoTotalNetRentalIncomeAmount = value; }
        private DirtyList<Residence> _residences;
        public IList<Residence> Residences { get => _residences ?? (_residences = new DirtyList<Residence>()); set => _residences = new DirtyList<Residence>(value); }
        private DirtyList<SelfEmployedIncome> _selfEmployedIncomes;
        public IList<SelfEmployedIncome> SelfEmployedIncomes { get => _selfEmployedIncomes ?? (_selfEmployedIncomes = new DirtyList<SelfEmployedIncome>()); set => _selfEmployedIncomes = new DirtyList<SelfEmployedIncome>(value); }
        private DirtyValue<string> _sofDBorrowerAddress;
        public string SofDBorrowerAddress { get => _sofDBorrowerAddress; set => _sofDBorrowerAddress = value; }
        private DirtyValue<string> _sofDBorrowerAddressCity;
        public string SofDBorrowerAddressCity { get => _sofDBorrowerAddressCity; set => _sofDBorrowerAddressCity = value; }
        private DirtyValue<string> _sofDBorrowerAddressState;
        public string SofDBorrowerAddressState { get => _sofDBorrowerAddressState; set => _sofDBorrowerAddressState = value; }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDBorrowerAddressType;
        public StringEnumValue<SofDBorrowerAddressType> SofDBorrowerAddressType { get => _sofDBorrowerAddressType; set => _sofDBorrowerAddressType = value; }
        private DirtyValue<string> _sofDBorrowerAddressZipcode;
        public string SofDBorrowerAddressZipcode { get => _sofDBorrowerAddressZipcode; set => _sofDBorrowerAddressZipcode = value; }
        private DirtyValue<string> _sofDCoBorrowerAddress;
        public string SofDCoBorrowerAddress { get => _sofDCoBorrowerAddress; set => _sofDCoBorrowerAddress = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressCity;
        public string SofDCoBorrowerAddressCity { get => _sofDCoBorrowerAddressCity; set => _sofDCoBorrowerAddressCity = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressState;
        public string SofDCoBorrowerAddressState { get => _sofDCoBorrowerAddressState; set => _sofDCoBorrowerAddressState = value; }
        private DirtyValue<StringEnumValue<SofDBorrowerAddressType>> _sofDCoBorrowerAddressType;
        public StringEnumValue<SofDBorrowerAddressType> SofDCoBorrowerAddressType { get => _sofDCoBorrowerAddressType; set => _sofDCoBorrowerAddressType = value; }
        private DirtyValue<string> _sofDCoBorrowerAddressZipcode;
        public string SofDCoBorrowerAddressZipcode { get => _sofDCoBorrowerAddressZipcode; set => _sofDCoBorrowerAddressZipcode = value; }
        private DirtyValue<bool?> _spouseIncomeConsider;
        public bool? SpouseIncomeConsider { get => _spouseIncomeConsider; set => _spouseIncomeConsider = value; }
        private DirtyList<Tax4506> _tax4506s;
        public IList<Tax4506> Tax4506s { get => _tax4506s ?? (_tax4506s = new DirtyList<Tax4506>()); set => _tax4506s = new DirtyList<Tax4506>(value); }
        private DirtyValue<decimal?> _topRatioPercent;
        public decimal? TopRatioPercent { get => _topRatioPercent; set => _topRatioPercent = value; }
        private DirtyValue<decimal?> _totalAssetsAmount;
        public decimal? TotalAssetsAmount { get => _totalAssetsAmount; set => _totalAssetsAmount = value; }
        private DirtyValue<decimal?> _totalBaseIncomeAmount;
        public decimal? TotalBaseIncomeAmount { get => _totalBaseIncomeAmount; set => _totalBaseIncomeAmount = value; }
        private DirtyValue<decimal?> _totalBonusAmount;
        public decimal? TotalBonusAmount { get => _totalBonusAmount; set => _totalBonusAmount = value; }
        private DirtyValue<decimal?> _totalCommissionsAmount;
        public decimal? TotalCommissionsAmount { get => _totalCommissionsAmount; set => _totalCommissionsAmount = value; }
        private DirtyValue<decimal?> _totalDeposit;
        public decimal? TotalDeposit { get => _totalDeposit; set => _totalDeposit = value; }
        private DirtyValue<decimal?> _totalDividendsInterestAmount;
        public decimal? TotalDividendsInterestAmount { get => _totalDividendsInterestAmount; set => _totalDividendsInterestAmount = value; }
        private DirtyValue<decimal?> _totalEmploymentAmount;
        public decimal? TotalEmploymentAmount { get => _totalEmploymentAmount; set => _totalEmploymentAmount = value; }
        private DirtyValue<decimal?> _totalFixedPaymentAmount;
        public decimal? TotalFixedPaymentAmount { get => _totalFixedPaymentAmount; set => _totalFixedPaymentAmount = value; }
        private DirtyValue<decimal?> _totalGrossMonthlyIncomeAmount;
        public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => _totalGrossMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _totalIncomeAmount;
        public decimal? TotalIncomeAmount { get => _totalIncomeAmount; set => _totalIncomeAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyPaymentAmount;
        public decimal? TotalMonthlyPaymentAmount { get => _totalMonthlyPaymentAmount; set => _totalMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _totalMortgagesBalanceAmount;
        public decimal? TotalMortgagesBalanceAmount { get => _totalMortgagesBalanceAmount; set => _totalMortgagesBalanceAmount = value; }
        private DirtyValue<decimal?> _totalMortgagesMonthlyPaymentAmount;
        public decimal? TotalMortgagesMonthlyPaymentAmount { get => _totalMortgagesMonthlyPaymentAmount; set => _totalMortgagesMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _totalNetRentalIncomeAmount;
        public decimal? TotalNetRentalIncomeAmount { get => _totalNetRentalIncomeAmount; set => _totalNetRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _totalOther1Amount;
        public decimal? TotalOther1Amount { get => _totalOther1Amount; set => _totalOther1Amount = value; }
        private DirtyValue<decimal?> _totalOther2Amount;
        public decimal? TotalOther2Amount { get => _totalOther2Amount; set => _totalOther2Amount = value; }
        private DirtyValue<decimal?> _totalOvertimeAmount;
        public decimal? TotalOvertimeAmount { get => _totalOvertimeAmount; set => _totalOvertimeAmount = value; }
        private DirtyValue<decimal?> _totalPaymentsAmount;
        public decimal? TotalPaymentsAmount { get => _totalPaymentsAmount; set => _totalPaymentsAmount = value; }
        private DirtyValue<decimal?> _totalPrimaryHousingExpenseAmount;
        public decimal? TotalPrimaryHousingExpenseAmount { get => _totalPrimaryHousingExpenseAmount; set => _totalPrimaryHousingExpenseAmount = value; }
        private DirtyValue<decimal?> _totalReoMarketValueAmount;
        public decimal? TotalReoMarketValueAmount { get => _totalReoMarketValueAmount; set => _totalReoMarketValueAmount = value; }
        private DirtyValue<decimal?> _totalUserDefinedIncome;
        public decimal? TotalUserDefinedIncome { get => _totalUserDefinedIncome; set => _totalUserDefinedIncome = value; }
        private DirtyList<TQLReportInformation> _tQLReports;
        public IList<TQLReportInformation> TQLReports { get => _tQLReports ?? (_tQLReports = new DirtyList<TQLReportInformation>()); set => _tQLReports = new DirtyList<TQLReportInformation>(value); }
        private DirtyValue<string> _transUnionAddress;
        public string TransUnionAddress { get => _transUnionAddress; set => _transUnionAddress = value; }
        private DirtyValue<string> _transUnionCity;
        public string TransUnionCity { get => _transUnionCity; set => _transUnionCity = value; }
        private DirtyValue<string> _transUnionFax;
        public string TransUnionFax { get => _transUnionFax; set => _transUnionFax = value; }
        private DirtyValue<string> _transUnionModel;
        public string TransUnionModel { get => _transUnionModel; set => _transUnionModel = value; }
        private DirtyValue<string> _transUnionName;
        public string TransUnionName { get => _transUnionName; set => _transUnionName = value; }
        private DirtyValue<string> _transUnionPhone;
        public string TransUnionPhone { get => _transUnionPhone; set => _transUnionPhone = value; }
        private DirtyValue<string> _transUnionPostalCode;
        public string TransUnionPostalCode { get => _transUnionPostalCode; set => _transUnionPostalCode = value; }
        private DirtyValue<string> _transUnionScoreRangeFrom;
        public string TransUnionScoreRangeFrom { get => _transUnionScoreRangeFrom; set => _transUnionScoreRangeFrom = value; }
        private DirtyValue<string> _transUnionScoreRangeTo;
        public string TransUnionScoreRangeTo { get => _transUnionScoreRangeTo; set => _transUnionScoreRangeTo = value; }
        private DirtyValue<string> _transUnionState;
        public string TransUnionState { get => _transUnionState; set => _transUnionState = value; }
        private DirtyValue<string> _transUnionWebsite;
        public string TransUnionWebsite { get => _transUnionWebsite; set => _transUnionWebsite = value; }
        private DirtyValue<decimal?> _userDefinedIncome;
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => _userDefinedIncome = value; }
        private DirtyValue<string> _userDefinedIncomeDescription;
        public string UserDefinedIncomeDescription { get => _userDefinedIncomeDescription; set => _userDefinedIncomeDescription = value; }
        private DirtyValue<StringEnumValue<YOrN>> _vACreditStandards;
        public StringEnumValue<YOrN> VACreditStandards { get => _vACreditStandards; set => _vACreditStandards = value; }
        private DirtyValue<decimal?> _vaSummarySpouseIncomeAmount;
        public decimal? VaSummarySpouseIncomeAmount { get => _vaSummarySpouseIncomeAmount; set => _vaSummarySpouseIncomeAmount = value; }
        private DirtyValue<decimal?> _vaSummaryTotalMonthlyGrossIncomeAmount;
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get => _vaSummaryTotalMonthlyGrossIncomeAmount; set => _vaSummaryTotalMonthlyGrossIncomeAmount = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _accountNumber1.Dirty
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
                    || _liquidAssetsComortSet.Dirty
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
                    || _tQLReports?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                _liquidAssetsComortSet.Dirty = value;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}