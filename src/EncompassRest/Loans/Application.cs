using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Application : IDirty
    {
        private Value<string> _accountNumber1;
        public string AccountNumber1 { get { return _accountNumber1; } set { _accountNumber1 = value; } }
        private Value<string> _accountNumber2;
        public string AccountNumber2 { get { return _accountNumber2; } set { _accountNumber2 = value; } }
        private Value<decimal?> _allOtherPaymentsAmount;
        public decimal? AllOtherPaymentsAmount { get { return _allOtherPaymentsAmount; } set { _allOtherPaymentsAmount = value; } }
        private Value<string> _applicationId;
        public string ApplicationId { get { return _applicationId; } set { _applicationId = value; } }
        private Value<int?> _applicationIndex;
        public int? ApplicationIndex { get { return _applicationIndex; } set { _applicationIndex = value; } }
        private Value<DateTime?> _applicationSignedDate;
        public DateTime? ApplicationSignedDate { get { return _applicationSignedDate; } set { _applicationSignedDate = value; } }
        private Value<List<Asset>> _assets;
        public List<Asset> Assets { get { return _assets; } set { _assets = value; } }
        private Value<decimal?> _assetsAvailableAmount;
        public decimal? AssetsAvailableAmount { get { return _assetsAvailableAmount; } set { _assetsAvailableAmount = value; } }
        public ATRQMBorrower ATRQMBorrower { get; set; }
        private Value<List<ATRQMBorrower>> _aTRQMBorrowers;
        public List<ATRQMBorrower> ATRQMBorrowers { get { return _aTRQMBorrowers; } set { _aTRQMBorrowers = value; } }
        private Value<List<AUSTrackingLog>> _aUSTrackingLogs;
        public List<AUSTrackingLog> AUSTrackingLogs { get { return _aUSTrackingLogs; } set { _aUSTrackingLogs = value; } }
        private Value<decimal?> _balanceAvailableFamilySupportGuideline;
        public decimal? BalanceAvailableFamilySupportGuideline { get { return _balanceAvailableFamilySupportGuideline; } set { _balanceAvailableFamilySupportGuideline = value; } }
        public Borrower Borrower { get; set; }
        private Value<decimal?> _bottomRatioPercent;
        public decimal? BottomRatioPercent { get { return _bottomRatioPercent; } set { _bottomRatioPercent = value; } }
        private Value<decimal?> _brwCoBrwTotalTaxDeductions;
        public decimal? BrwCoBrwTotalTaxDeductions { get { return _brwCoBrwTotalTaxDeductions; } set { _brwCoBrwTotalTaxDeductions = value; } }
        public Borrower Coborrower { get; set; }
        private Value<string> _creditAliasName1;
        public string CreditAliasName1 { get { return _creditAliasName1; } set { _creditAliasName1 = value; } }
        private Value<string> _creditAliasName2;
        public string CreditAliasName2 { get { return _creditAliasName2; } set { _creditAliasName2 = value; } }
        private Value<string> _creditorName1;
        public string CreditorName1 { get { return _creditorName1; } set { _creditorName1 = value; } }
        private Value<string> _creditorName2;
        public string CreditorName2 { get { return _creditorName2; } set { _creditorName2 = value; } }
        private Value<string> _creditReportReferenceIdentifier;
        public string CreditReportReferenceIdentifier { get { return _creditReportReferenceIdentifier; } set { _creditReportReferenceIdentifier = value; } }
        private Value<List<Employment>> _employment;
        public List<Employment> Employment { get { return _employment; } set { _employment = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _equifaxAddress;
        public string EquifaxAddress { get { return _equifaxAddress; } set { _equifaxAddress = value; } }
        private Value<string> _equifaxCity;
        public string EquifaxCity { get { return _equifaxCity; } set { _equifaxCity = value; } }
        private Value<string> _equifaxFax;
        public string EquifaxFax { get { return _equifaxFax; } set { _equifaxFax = value; } }
        private Value<string> _equifaxModel;
        public string EquifaxModel { get { return _equifaxModel; } set { _equifaxModel = value; } }
        private Value<string> _equifaxName;
        public string EquifaxName { get { return _equifaxName; } set { _equifaxName = value; } }
        private Value<string> _equifaxPhone;
        public string EquifaxPhone { get { return _equifaxPhone; } set { _equifaxPhone = value; } }
        private Value<string> _equifaxPostalCode;
        public string EquifaxPostalCode { get { return _equifaxPostalCode; } set { _equifaxPostalCode = value; } }
        private Value<string> _equifaxScoreRangeFrom;
        public string EquifaxScoreRangeFrom { get { return _equifaxScoreRangeFrom; } set { _equifaxScoreRangeFrom = value; } }
        private Value<string> _equifaxScoreRangeTo;
        public string EquifaxScoreRangeTo { get { return _equifaxScoreRangeTo; } set { _equifaxScoreRangeTo = value; } }
        private Value<string> _equifaxState;
        public string EquifaxState { get { return _equifaxState; } set { _equifaxState = value; } }
        private Value<string> _equifaxWebsite;
        public string EquifaxWebsite { get { return _equifaxWebsite; } set { _equifaxWebsite = value; } }
        private Value<string> _experianAddress;
        public string ExperianAddress { get { return _experianAddress; } set { _experianAddress = value; } }
        private Value<string> _experianCity;
        public string ExperianCity { get { return _experianCity; } set { _experianCity = value; } }
        private Value<string> _experianFax;
        public string ExperianFax { get { return _experianFax; } set { _experianFax = value; } }
        private Value<string> _experianModel;
        public string ExperianModel { get { return _experianModel; } set { _experianModel = value; } }
        private Value<string> _experianName;
        public string ExperianName { get { return _experianName; } set { _experianName = value; } }
        private Value<string> _experianPhone;
        public string ExperianPhone { get { return _experianPhone; } set { _experianPhone = value; } }
        private Value<string> _experianPostalCode;
        public string ExperianPostalCode { get { return _experianPostalCode; } set { _experianPostalCode = value; } }
        private Value<string> _experianScoreRangeFrom;
        public string ExperianScoreRangeFrom { get { return _experianScoreRangeFrom; } set { _experianScoreRangeFrom = value; } }
        private Value<string> _experianScoreRangeTo;
        public string ExperianScoreRangeTo { get { return _experianScoreRangeTo; } set { _experianScoreRangeTo = value; } }
        private Value<string> _experianState;
        public string ExperianState { get { return _experianState; } set { _experianState = value; } }
        private Value<string> _experianWebsite;
        public string ExperianWebsite { get { return _experianWebsite; } set { _experianWebsite = value; } }
        private Value<decimal?> _fhaVaDebtIncomeRatio;
        public decimal? FhaVaDebtIncomeRatio { get { return _fhaVaDebtIncomeRatio; } set { _fhaVaDebtIncomeRatio = value; } }
        private Value<decimal?> _fhaVaFamilySupportAmount;
        public decimal? FhaVaFamilySupportAmount { get { return _fhaVaFamilySupportAmount; } set { _fhaVaFamilySupportAmount = value; } }
        private Value<decimal?> _fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get { return _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; } set { _fhaVaTotalEstimatedMonthlyShelterExpenseAmount = value; } }
        private Value<decimal?> _fhaVaTotalNetEffectiveIncomeAmount;
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get { return _fhaVaTotalNetEffectiveIncomeAmount; } set { _fhaVaTotalNetEffectiveIncomeAmount = value; } }
        private Value<decimal?> _fhaVaTotalNetIncomeAmount;
        public decimal? FhaVaTotalNetIncomeAmount { get { return _fhaVaTotalNetIncomeAmount; } set { _fhaVaTotalNetIncomeAmount = value; } }
        private Value<decimal?> _fhaVaTotalNetTakeHomePayAmount;
        public decimal? FhaVaTotalNetTakeHomePayAmount { get { return _fhaVaTotalNetTakeHomePayAmount; } set { _fhaVaTotalNetTakeHomePayAmount = value; } }
        private Value<decimal?> _fhaVaTotalOtherNetIncome;
        public decimal? FhaVaTotalOtherNetIncome { get { return _fhaVaTotalOtherNetIncome; } set { _fhaVaTotalOtherNetIncome = value; } }
        private Value<decimal?> _firstMortgagePrincipalAndInterestAmount;
        public decimal? FirstMortgagePrincipalAndInterestAmount { get { return _firstMortgagePrincipalAndInterestAmount; } set { _firstMortgagePrincipalAndInterestAmount = value; } }
        private Value<string> _freddieMacCreditReportReferenceIdentifier;
        public string FreddieMacCreditReportReferenceIdentifier { get { return _freddieMacCreditReportReferenceIdentifier; } set { _freddieMacCreditReportReferenceIdentifier = value; } }
        private Value<decimal?> _freddieMacOccupantDebtRatio;
        public decimal? FreddieMacOccupantDebtRatio { get { return _freddieMacOccupantDebtRatio; } set { _freddieMacOccupantDebtRatio = value; } }
        private Value<decimal?> _freddieMacOccupantHousingRatio;
        public decimal? FreddieMacOccupantHousingRatio { get { return _freddieMacOccupantHousingRatio; } set { _freddieMacOccupantHousingRatio = value; } }
        private Value<decimal?> _freDebtToHousingGapRatio;
        public decimal? FreDebtToHousingGapRatio { get { return _freDebtToHousingGapRatio; } set { _freDebtToHousingGapRatio = value; } }
        private Value<decimal?> _grossBaseIncomeAmount;
        public decimal? GrossBaseIncomeAmount { get { return _grossBaseIncomeAmount; } set { _grossBaseIncomeAmount = value; } }
        private Value<decimal?> _grossIncomeForComortSet;
        public decimal? GrossIncomeForComortSet { get { return _grossIncomeForComortSet; } set { _grossIncomeForComortSet = value; } }
        private Value<decimal?> _grossNegativeCashFlow;
        public decimal? GrossNegativeCashFlow { get { return _grossNegativeCashFlow; } set { _grossNegativeCashFlow = value; } }
        private Value<decimal?> _grossOtherIncomeAmount;
        public decimal? GrossOtherIncomeAmount { get { return _grossOtherIncomeAmount; } set { _grossOtherIncomeAmount = value; } }
        private Value<decimal?> _grossPositiveCashFlow;
        public decimal? GrossPositiveCashFlow { get { return _grossPositiveCashFlow; } set { _grossPositiveCashFlow = value; } }
        private Value<string> _hazardInsuranceAmount;
        public string HazardInsuranceAmount { get { return _hazardInsuranceAmount; } set { _hazardInsuranceAmount = value; } }
        private Value<string> _homeownersAssociationDuesAndCondoFeesAmount;
        public string HomeownersAssociationDuesAndCondoFeesAmount { get { return _homeownersAssociationDuesAndCondoFeesAmount; } set { _homeownersAssociationDuesAndCondoFeesAmount = value; } }
        private Value<string> _hudAutoLienHolderName1;
        public string HudAutoLienHolderName1 { get { return _hudAutoLienHolderName1; } set { _hudAutoLienHolderName1 = value; } }
        private Value<string> _hudAutoLienHolderName2;
        public string HudAutoLienHolderName2 { get { return _hudAutoLienHolderName2; } set { _hudAutoLienHolderName2 = value; } }
        private Value<decimal?> _hudAutoLoanAmount1;
        public decimal? HudAutoLoanAmount1 { get { return _hudAutoLoanAmount1; } set { _hudAutoLoanAmount1 = value; } }
        private Value<decimal?> _hudAutoLoanAmount2;
        public decimal? HudAutoLoanAmount2 { get { return _hudAutoLoanAmount2; } set { _hudAutoLoanAmount2 = value; } }
        private Value<decimal?> _hudAutoMonthlyPayment1;
        public decimal? HudAutoMonthlyPayment1 { get { return _hudAutoMonthlyPayment1; } set { _hudAutoMonthlyPayment1 = value; } }
        private Value<decimal?> _hudAutoMonthlyPayment2;
        public decimal? HudAutoMonthlyPayment2 { get { return _hudAutoMonthlyPayment2; } set { _hudAutoMonthlyPayment2 = value; } }
        private Value<decimal?> _hudAutoPresentBalance1;
        public decimal? HudAutoPresentBalance1 { get { return _hudAutoPresentBalance1; } set { _hudAutoPresentBalance1 = value; } }
        private Value<decimal?> _hudAutoPresentBalance2;
        public decimal? HudAutoPresentBalance2 { get { return _hudAutoPresentBalance2; } set { _hudAutoPresentBalance2 = value; } }
        private Value<string> _hudAutoYearAndMake1;
        public string HudAutoYearAndMake1 { get { return _hudAutoYearAndMake1; } set { _hudAutoYearAndMake1 = value; } }
        private Value<string> _hudAutoYearAndMake2;
        public string HudAutoYearAndMake2 { get { return _hudAutoYearAndMake2; } set { _hudAutoYearAndMake2 = value; } }
        private Value<decimal?> _hudLoanAmount1;
        public decimal? HudLoanAmount1 { get { return _hudLoanAmount1; } set { _hudLoanAmount1 = value; } }
        private Value<decimal?> _hudLoanAmount10;
        public decimal? HudLoanAmount10 { get { return _hudLoanAmount10; } set { _hudLoanAmount10 = value; } }
        private Value<decimal?> _hudLoanAmount11;
        public decimal? HudLoanAmount11 { get { return _hudLoanAmount11; } set { _hudLoanAmount11 = value; } }
        private Value<decimal?> _hudLoanAmount2;
        public decimal? HudLoanAmount2 { get { return _hudLoanAmount2; } set { _hudLoanAmount2 = value; } }
        private Value<decimal?> _hudLoanAmount3;
        public decimal? HudLoanAmount3 { get { return _hudLoanAmount3; } set { _hudLoanAmount3 = value; } }
        private Value<decimal?> _hudLoanAmount4;
        public decimal? HudLoanAmount4 { get { return _hudLoanAmount4; } set { _hudLoanAmount4 = value; } }
        private Value<decimal?> _hudLoanAmount5;
        public decimal? HudLoanAmount5 { get { return _hudLoanAmount5; } set { _hudLoanAmount5 = value; } }
        private Value<decimal?> _hudLoanAmount6;
        public decimal? HudLoanAmount6 { get { return _hudLoanAmount6; } set { _hudLoanAmount6 = value; } }
        private Value<decimal?> _hudLoanAmount7;
        public decimal? HudLoanAmount7 { get { return _hudLoanAmount7; } set { _hudLoanAmount7 = value; } }
        private Value<decimal?> _hudLoanAmount8;
        public decimal? HudLoanAmount8 { get { return _hudLoanAmount8; } set { _hudLoanAmount8 = value; } }
        private Value<decimal?> _hudLoanAmount9;
        public decimal? HudLoanAmount9 { get { return _hudLoanAmount9; } set { _hudLoanAmount9 = value; } }
        private Value<bool?> _hudRealEstateFhaInsured1;
        public bool? HudRealEstateFhaInsured1 { get { return _hudRealEstateFhaInsured1; } set { _hudRealEstateFhaInsured1 = value; } }
        private Value<bool?> _hudRealEstateFhaInsured2;
        public bool? HudRealEstateFhaInsured2 { get { return _hudRealEstateFhaInsured2; } set { _hudRealEstateFhaInsured2 = value; } }
        private Value<string> _hudRealEstateLienHolder1;
        public string HudRealEstateLienHolder1 { get { return _hudRealEstateLienHolder1; } set { _hudRealEstateLienHolder1 = value; } }
        private Value<string> _hudRealEstateLienHolder2;
        public string HudRealEstateLienHolder2 { get { return _hudRealEstateLienHolder2; } set { _hudRealEstateLienHolder2 = value; } }
        private Value<decimal?> _hudRealEstateLoanAmount1;
        public decimal? HudRealEstateLoanAmount1 { get { return _hudRealEstateLoanAmount1; } set { _hudRealEstateLoanAmount1 = value; } }
        private Value<decimal?> _hudRealEstateLoanAmount2;
        public decimal? HudRealEstateLoanAmount2 { get { return _hudRealEstateLoanAmount2; } set { _hudRealEstateLoanAmount2 = value; } }
        private Value<decimal?> _hudRealEstateMonthlyPayment1;
        public decimal? HudRealEstateMonthlyPayment1 { get { return _hudRealEstateMonthlyPayment1; } set { _hudRealEstateMonthlyPayment1 = value; } }
        private Value<decimal?> _hudRealEstateMonthlyPayment2;
        public decimal? HudRealEstateMonthlyPayment2 { get { return _hudRealEstateMonthlyPayment2; } set { _hudRealEstateMonthlyPayment2 = value; } }
        private Value<decimal?> _hudRealEstatePresentBalance1;
        public decimal? HudRealEstatePresentBalance1 { get { return _hudRealEstatePresentBalance1; } set { _hudRealEstatePresentBalance1 = value; } }
        private Value<decimal?> _hudRealEstatePresentBalance2;
        public decimal? HudRealEstatePresentBalance2 { get { return _hudRealEstatePresentBalance2; } set { _hudRealEstatePresentBalance2 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<List<Income>> _income;
        public List<Income> Income { get { return _income; } set { _income = value; } }
        private Value<bool?> _incomeOfBorrowersSpouseUsedIndicator;
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get { return _incomeOfBorrowersSpouseUsedIndicator; } set { _incomeOfBorrowersSpouseUsedIndicator = value; } }
        private Value<bool?> _incomeOtherThanBorrowerUsedIndicator;
        public bool? IncomeOtherThanBorrowerUsedIndicator { get { return _incomeOtherThanBorrowerUsedIndicator; } set { _incomeOtherThanBorrowerUsedIndicator = value; } }
        private Value<bool?> _jointAssetLiabilityReportingIndicator;
        public bool? JointAssetLiabilityReportingIndicator { get { return _jointAssetLiabilityReportingIndicator; } set { _jointAssetLiabilityReportingIndicator = value; } }
        private Value<List<Liability>> _liabilities;
        public List<Liability> Liabilities { get { return _liabilities; } set { _liabilities = value; } }
        private Value<decimal?> _liquidAssetsComortSet;
        public decimal? LiquidAssetsComortSet { get { return _liquidAssetsComortSet; } set { _liquidAssetsComortSet = value; } }
        private Value<decimal?> _mcawBorrowerOtherMonthlyIncomeAmount;
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get { return _mcawBorrowerOtherMonthlyIncomeAmount; } set { _mcawBorrowerOtherMonthlyIncomeAmount = value; } }
        private Value<decimal?> _mcawCoborrowerOtherMonthlyIncomeAmount;
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get { return _mcawCoborrowerOtherMonthlyIncomeAmount; } set { _mcawCoborrowerOtherMonthlyIncomeAmount = value; } }
        private Value<decimal?> _mcawGrossMonthlyIncomeAmount;
        public decimal? McawGrossMonthlyIncomeAmount { get { return _mcawGrossMonthlyIncomeAmount; } set { _mcawGrossMonthlyIncomeAmount = value; } }
        private Value<decimal?> _mcawMortgagePaymentToIncome1Amount;
        public decimal? McawMortgagePaymentToIncome1Amount { get { return _mcawMortgagePaymentToIncome1Amount; } set { _mcawMortgagePaymentToIncome1Amount = value; } }
        private Value<decimal?> _mcawMortgagePaymentToIncome2Amount;
        public decimal? McawMortgagePaymentToIncome2Amount { get { return _mcawMortgagePaymentToIncome2Amount; } set { _mcawMortgagePaymentToIncome2Amount = value; } }
        private Value<decimal?> _mcawOtherAmount;
        public decimal? McawOtherAmount { get { return _mcawOtherAmount; } set { _mcawOtherAmount = value; } }
        private Value<decimal?> _mcawOtherDebtsAndObligationsAmount;
        public decimal? McawOtherDebtsAndObligationsAmount { get { return _mcawOtherDebtsAndObligationsAmount; } set { _mcawOtherDebtsAndObligationsAmount = value; } }
        private Value<decimal?> _mcawTotalFixedPaymentForPurchaseAmount;
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get { return _mcawTotalFixedPaymentForPurchaseAmount; } set { _mcawTotalFixedPaymentForPurchaseAmount = value; } }
        private Value<decimal?> _mcawTotalFixedPaymentForRefinanceAmount;
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get { return _mcawTotalFixedPaymentForRefinanceAmount; } set { _mcawTotalFixedPaymentForRefinanceAmount = value; } }
        private Value<decimal?> _mcawTotalFixedPaymentToIncome1Amount;
        public decimal? McawTotalFixedPaymentToIncome1Amount { get { return _mcawTotalFixedPaymentToIncome1Amount; } set { _mcawTotalFixedPaymentToIncome1Amount = value; } }
        private Value<decimal?> _mcawTotalFixedPaymentToIncome2Amount;
        public decimal? McawTotalFixedPaymentToIncome2Amount { get { return _mcawTotalFixedPaymentToIncome2Amount; } set { _mcawTotalFixedPaymentToIncome2Amount = value; } }
        private Value<decimal?> _mcawTotalMonthlyPaymentsAmount;
        public decimal? McawTotalMonthlyPaymentsAmount { get { return _mcawTotalMonthlyPaymentsAmount; } set { _mcawTotalMonthlyPaymentsAmount = value; } }
        private Value<decimal?> _mcawTotalMortgagePaymentAmount;
        public decimal? McawTotalMortgagePaymentAmount { get { return _mcawTotalMortgagePaymentAmount; } set { _mcawTotalMortgagePaymentAmount = value; } }
        private Value<decimal?> _monthlyExpenseComortSet;
        public decimal? MonthlyExpenseComortSet { get { return _monthlyExpenseComortSet; } set { _monthlyExpenseComortSet = value; } }
        private Value<decimal?> _monthlyHousingExpenseAmount;
        public decimal? MonthlyHousingExpenseAmount { get { return _monthlyHousingExpenseAmount; } set { _monthlyHousingExpenseAmount = value; } }
        private Value<decimal?> _monthlyInstallmentExpenseAmount;
        public decimal? MonthlyInstallmentExpenseAmount { get { return _monthlyInstallmentExpenseAmount; } set { _monthlyInstallmentExpenseAmount = value; } }
        private Value<decimal?> _monthlyNegativeRealEstateAmount;
        public decimal? MonthlyNegativeRealEstateAmount { get { return _monthlyNegativeRealEstateAmount; } set { _monthlyNegativeRealEstateAmount = value; } }
        private Value<decimal?> _monthlySecondHomeAmount;
        public decimal? MonthlySecondHomeAmount { get { return _monthlySecondHomeAmount; } set { _monthlySecondHomeAmount = value; } }
        private Value<string> _mortgageInsuranceAmount;
        public string MortgageInsuranceAmount { get { return _mortgageInsuranceAmount; } set { _mortgageInsuranceAmount = value; } }
        private Value<decimal?> _netWorthAmount;
        public decimal? NetWorthAmount { get { return _netWorthAmount; } set { _netWorthAmount = value; } }
        private Value<decimal?> _otherHousingExpenseAmount;
        public decimal? OtherHousingExpenseAmount { get { return _otherHousingExpenseAmount; } set { _otherHousingExpenseAmount = value; } }
        private Value<decimal?> _otherItemsDeducted;
        public decimal? OtherItemsDeducted { get { return _otherItemsDeducted; } set { _otherItemsDeducted = value; } }
        private Value<decimal?> _otherMortgagePrincipalAndInterestAmount;
        public decimal? OtherMortgagePrincipalAndInterestAmount { get { return _otherMortgagePrincipalAndInterestAmount; } set { _otherMortgagePrincipalAndInterestAmount = value; } }
        private Value<string> _pastCreditRecord;
        public string PastCreditRecord { get { return _pastCreditRecord; } set { _pastCreditRecord = value; } }
        private Value<decimal?> _presentHousingExpComortSet;
        public decimal? PresentHousingExpComortSet { get { return _presentHousingExpComortSet; } set { _presentHousingExpComortSet = value; } }
        private Value<decimal?> _primaryResidenceComortSet;
        public decimal? PrimaryResidenceComortSet { get { return _primaryResidenceComortSet; } set { _primaryResidenceComortSet = value; } }
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private Value<string> _proposedDuesAmount;
        public string ProposedDuesAmount { get { return _proposedDuesAmount; } set { _proposedDuesAmount = value; } }
        private Value<decimal?> _proposedFirstMortgageAmount;
        public decimal? ProposedFirstMortgageAmount { get { return _proposedFirstMortgageAmount; } set { _proposedFirstMortgageAmount = value; } }
        private Value<decimal?> _proposedGroundRentAmount;
        public decimal? ProposedGroundRentAmount { get { return _proposedGroundRentAmount; } set { _proposedGroundRentAmount = value; } }
        private Value<string> _proposedHazardInsuranceAmount;
        public string ProposedHazardInsuranceAmount { get { return _proposedHazardInsuranceAmount; } set { _proposedHazardInsuranceAmount = value; } }
        private Value<string> _proposedMortgageInsuranceAmount;
        public string ProposedMortgageInsuranceAmount { get { return _proposedMortgageInsuranceAmount; } set { _proposedMortgageInsuranceAmount = value; } }
        private Value<decimal?> _proposedOtherAmount;
        public decimal? ProposedOtherAmount { get { return _proposedOtherAmount; } set { _proposedOtherAmount = value; } }
        private Value<decimal?> _proposedOtherMortgagesAmount;
        public decimal? ProposedOtherMortgagesAmount { get { return _proposedOtherMortgagesAmount; } set { _proposedOtherMortgagesAmount = value; } }
        private Value<string> _proposedRealEstateTaxesAmount;
        public string ProposedRealEstateTaxesAmount { get { return _proposedRealEstateTaxesAmount; } set { _proposedRealEstateTaxesAmount = value; } }
        private Value<string> _realEstateTaxAmount;
        public string RealEstateTaxAmount { get { return _realEstateTaxAmount; } set { _realEstateTaxAmount = value; } }
        private Value<decimal?> _rentAmount;
        public decimal? RentAmount { get { return _rentAmount; } set { _rentAmount = value; } }
        private Value<List<ReoProperty>> _reoProperties;
        public List<ReoProperty> ReoProperties { get { return _reoProperties; } set { _reoProperties = value; } }
        private Value<decimal?> _reoTotalGrossRentalIncomeAmount;
        public decimal? ReoTotalGrossRentalIncomeAmount { get { return _reoTotalGrossRentalIncomeAmount; } set { _reoTotalGrossRentalIncomeAmount = value; } }
        private Value<decimal?> _reoTotalMaintenanceAmount;
        public decimal? ReoTotalMaintenanceAmount { get { return _reoTotalMaintenanceAmount; } set { _reoTotalMaintenanceAmount = value; } }
        private Value<decimal?> _reoTotalMarketValueAmount;
        public decimal? ReoTotalMarketValueAmount { get { return _reoTotalMarketValueAmount; } set { _reoTotalMarketValueAmount = value; } }
        private Value<decimal?> _reoTotalMortgagePaymentsAmount;
        public decimal? ReoTotalMortgagePaymentsAmount { get { return _reoTotalMortgagePaymentsAmount; } set { _reoTotalMortgagePaymentsAmount = value; } }
        private Value<decimal?> _reoTotalMortgagesAndLiensAmount;
        public decimal? ReoTotalMortgagesAndLiensAmount { get { return _reoTotalMortgagesAndLiensAmount; } set { _reoTotalMortgagesAndLiensAmount = value; } }
        private Value<int?> _reoTotalNetRentalIncomeAmount;
        public int? ReoTotalNetRentalIncomeAmount { get { return _reoTotalNetRentalIncomeAmount; } set { _reoTotalNetRentalIncomeAmount = value; } }
        private Value<List<Residence>> _residences;
        public List<Residence> Residences { get { return _residences; } set { _residences = value; } }
        private Value<List<SelfEmployedIncome>> _selfEmployedIncomes;
        public List<SelfEmployedIncome> SelfEmployedIncomes { get { return _selfEmployedIncomes; } set { _selfEmployedIncomes = value; } }
        private Value<string> _sofDBorrowerAddress;
        public string SofDBorrowerAddress { get { return _sofDBorrowerAddress; } set { _sofDBorrowerAddress = value; } }
        private Value<string> _sofDBorrowerAddressCity;
        public string SofDBorrowerAddressCity { get { return _sofDBorrowerAddressCity; } set { _sofDBorrowerAddressCity = value; } }
        private Value<string> _sofDBorrowerAddressState;
        public string SofDBorrowerAddressState { get { return _sofDBorrowerAddressState; } set { _sofDBorrowerAddressState = value; } }
        private Value<string> _sofDBorrowerAddressType;
        public string SofDBorrowerAddressType { get { return _sofDBorrowerAddressType; } set { _sofDBorrowerAddressType = value; } }
        private Value<string> _sofDBorrowerAddressZipcode;
        public string SofDBorrowerAddressZipcode { get { return _sofDBorrowerAddressZipcode; } set { _sofDBorrowerAddressZipcode = value; } }
        private Value<string> _sofDCoBorrowerAddress;
        public string SofDCoBorrowerAddress { get { return _sofDCoBorrowerAddress; } set { _sofDCoBorrowerAddress = value; } }
        private Value<string> _sofDCoBorrowerAddressCity;
        public string SofDCoBorrowerAddressCity { get { return _sofDCoBorrowerAddressCity; } set { _sofDCoBorrowerAddressCity = value; } }
        private Value<string> _sofDCoBorrowerAddressState;
        public string SofDCoBorrowerAddressState { get { return _sofDCoBorrowerAddressState; } set { _sofDCoBorrowerAddressState = value; } }
        private Value<string> _sofDCoBorrowerAddressType;
        public string SofDCoBorrowerAddressType { get { return _sofDCoBorrowerAddressType; } set { _sofDCoBorrowerAddressType = value; } }
        private Value<string> _sofDCoBorrowerAddressZipcode;
        public string SofDCoBorrowerAddressZipcode { get { return _sofDCoBorrowerAddressZipcode; } set { _sofDCoBorrowerAddressZipcode = value; } }
        private Value<bool?> _spouseIncomeConsider;
        public bool? SpouseIncomeConsider { get { return _spouseIncomeConsider; } set { _spouseIncomeConsider = value; } }
        private Value<List<Tax4506>> _tax4506s;
        public List<Tax4506> Tax4506s { get { return _tax4506s; } set { _tax4506s = value; } }
        private Value<decimal?> _topRatioPercent;
        public decimal? TopRatioPercent { get { return _topRatioPercent; } set { _topRatioPercent = value; } }
        private Value<decimal?> _totalAssetsAmount;
        public decimal? TotalAssetsAmount { get { return _totalAssetsAmount; } set { _totalAssetsAmount = value; } }
        private Value<decimal?> _totalBaseIncomeAmount;
        public decimal? TotalBaseIncomeAmount { get { return _totalBaseIncomeAmount; } set { _totalBaseIncomeAmount = value; } }
        private Value<decimal?> _totalBonusAmount;
        public decimal? TotalBonusAmount { get { return _totalBonusAmount; } set { _totalBonusAmount = value; } }
        private Value<decimal?> _totalCommissionsAmount;
        public decimal? TotalCommissionsAmount { get { return _totalCommissionsAmount; } set { _totalCommissionsAmount = value; } }
        private Value<decimal?> _totalDeposit;
        public decimal? TotalDeposit { get { return _totalDeposit; } set { _totalDeposit = value; } }
        private Value<decimal?> _totalDividendsInterestAmount;
        public decimal? TotalDividendsInterestAmount { get { return _totalDividendsInterestAmount; } set { _totalDividendsInterestAmount = value; } }
        private Value<decimal?> _totalEmploymentAmount;
        public decimal? TotalEmploymentAmount { get { return _totalEmploymentAmount; } set { _totalEmploymentAmount = value; } }
        private Value<decimal?> _totalFixedPaymentAmount;
        public decimal? TotalFixedPaymentAmount { get { return _totalFixedPaymentAmount; } set { _totalFixedPaymentAmount = value; } }
        private Value<decimal?> _totalGrossMonthlyIncomeAmount;
        public decimal? TotalGrossMonthlyIncomeAmount { get { return _totalGrossMonthlyIncomeAmount; } set { _totalGrossMonthlyIncomeAmount = value; } }
        private Value<decimal?> _totalIncomeAmount;
        public decimal? TotalIncomeAmount { get { return _totalIncomeAmount; } set { _totalIncomeAmount = value; } }
        private Value<decimal?> _totalMonthlyPaymentAmount;
        public decimal? TotalMonthlyPaymentAmount { get { return _totalMonthlyPaymentAmount; } set { _totalMonthlyPaymentAmount = value; } }
        private Value<decimal?> _totalMortgagesBalanceAmount;
        public decimal? TotalMortgagesBalanceAmount { get { return _totalMortgagesBalanceAmount; } set { _totalMortgagesBalanceAmount = value; } }
        private Value<decimal?> _totalMortgagesMonthlyPaymentAmount;
        public decimal? TotalMortgagesMonthlyPaymentAmount { get { return _totalMortgagesMonthlyPaymentAmount; } set { _totalMortgagesMonthlyPaymentAmount = value; } }
        private Value<decimal?> _totalNetRentalIncomeAmount;
        public decimal? TotalNetRentalIncomeAmount { get { return _totalNetRentalIncomeAmount; } set { _totalNetRentalIncomeAmount = value; } }
        private Value<decimal?> _totalOther1Amount;
        public decimal? TotalOther1Amount { get { return _totalOther1Amount; } set { _totalOther1Amount = value; } }
        private Value<decimal?> _totalOther2Amount;
        public decimal? TotalOther2Amount { get { return _totalOther2Amount; } set { _totalOther2Amount = value; } }
        private Value<decimal?> _totalOvertimeAmount;
        public decimal? TotalOvertimeAmount { get { return _totalOvertimeAmount; } set { _totalOvertimeAmount = value; } }
        private Value<decimal?> _totalPaymentsAmount;
        public decimal? TotalPaymentsAmount { get { return _totalPaymentsAmount; } set { _totalPaymentsAmount = value; } }
        private Value<decimal?> _totalPrimaryHousingExpenseAmount;
        public decimal? TotalPrimaryHousingExpenseAmount { get { return _totalPrimaryHousingExpenseAmount; } set { _totalPrimaryHousingExpenseAmount = value; } }
        private Value<decimal?> _totalReoMarketValueAmount;
        public decimal? TotalReoMarketValueAmount { get { return _totalReoMarketValueAmount; } set { _totalReoMarketValueAmount = value; } }
        private Value<decimal?> _totalUserDefinedIncome;
        public decimal? TotalUserDefinedIncome { get { return _totalUserDefinedIncome; } set { _totalUserDefinedIncome = value; } }
        private Value<List<TQLReportInformation>> _tQLReports;
        public List<TQLReportInformation> TQLReports { get { return _tQLReports; } set { _tQLReports = value; } }
        private Value<string> _transUnionAddress;
        public string TransUnionAddress { get { return _transUnionAddress; } set { _transUnionAddress = value; } }
        private Value<string> _transUnionCity;
        public string TransUnionCity { get { return _transUnionCity; } set { _transUnionCity = value; } }
        private Value<string> _transUnionFax;
        public string TransUnionFax { get { return _transUnionFax; } set { _transUnionFax = value; } }
        private Value<string> _transUnionModel;
        public string TransUnionModel { get { return _transUnionModel; } set { _transUnionModel = value; } }
        private Value<string> _transUnionName;
        public string TransUnionName { get { return _transUnionName; } set { _transUnionName = value; } }
        private Value<string> _transUnionPhone;
        public string TransUnionPhone { get { return _transUnionPhone; } set { _transUnionPhone = value; } }
        private Value<string> _transUnionPostalCode;
        public string TransUnionPostalCode { get { return _transUnionPostalCode; } set { _transUnionPostalCode = value; } }
        private Value<string> _transUnionScoreRangeFrom;
        public string TransUnionScoreRangeFrom { get { return _transUnionScoreRangeFrom; } set { _transUnionScoreRangeFrom = value; } }
        private Value<string> _transUnionScoreRangeTo;
        public string TransUnionScoreRangeTo { get { return _transUnionScoreRangeTo; } set { _transUnionScoreRangeTo = value; } }
        private Value<string> _transUnionState;
        public string TransUnionState { get { return _transUnionState; } set { _transUnionState = value; } }
        private Value<string> _transUnionWebsite;
        public string TransUnionWebsite { get { return _transUnionWebsite; } set { _transUnionWebsite = value; } }
        private Value<decimal?> _userDefinedIncome;
        public decimal? UserDefinedIncome { get { return _userDefinedIncome; } set { _userDefinedIncome = value; } }
        private Value<string> _userDefinedIncomeDescription;
        public string UserDefinedIncomeDescription { get { return _userDefinedIncomeDescription; } set { _userDefinedIncomeDescription = value; } }
        private Value<string> _vACreditStandards;
        public string VACreditStandards { get { return _vACreditStandards; } set { _vACreditStandards = value; } }
        private Value<decimal?> _vaSummarySpouseIncomeAmount;
        public decimal? VaSummarySpouseIncomeAmount { get { return _vaSummarySpouseIncomeAmount; } set { _vaSummarySpouseIncomeAmount = value; } }
        private Value<decimal?> _vaSummaryTotalMonthlyGrossIncomeAmount;
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get { return _vaSummaryTotalMonthlyGrossIncomeAmount; } set { _vaSummaryTotalMonthlyGrossIncomeAmount = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _accountNumber1.Dirty
                    || _accountNumber2.Dirty
                    || _allOtherPaymentsAmount.Dirty
                    || _applicationId.Dirty
                    || _applicationIndex.Dirty
                    || _applicationSignedDate.Dirty
                    || _assets.Dirty
                    || _assetsAvailableAmount.Dirty
                    || _aTRQMBorrowers.Dirty
                    || _aUSTrackingLogs.Dirty
                    || _balanceAvailableFamilySupportGuideline.Dirty
                    || _bottomRatioPercent.Dirty
                    || _brwCoBrwTotalTaxDeductions.Dirty
                    || _creditAliasName1.Dirty
                    || _creditAliasName2.Dirty
                    || _creditorName1.Dirty
                    || _creditorName2.Dirty
                    || _creditReportReferenceIdentifier.Dirty
                    || _employment.Dirty
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
                    || _income.Dirty
                    || _incomeOfBorrowersSpouseUsedIndicator.Dirty
                    || _incomeOtherThanBorrowerUsedIndicator.Dirty
                    || _jointAssetLiabilityReportingIndicator.Dirty
                    || _liabilities.Dirty
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
                    || _reoProperties.Dirty
                    || _reoTotalGrossRentalIncomeAmount.Dirty
                    || _reoTotalMaintenanceAmount.Dirty
                    || _reoTotalMarketValueAmount.Dirty
                    || _reoTotalMortgagePaymentsAmount.Dirty
                    || _reoTotalMortgagesAndLiensAmount.Dirty
                    || _reoTotalNetRentalIncomeAmount.Dirty
                    || _residences.Dirty
                    || _selfEmployedIncomes.Dirty
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
                    || _tax4506s.Dirty
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
                    || _tQLReports.Dirty
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
                    || ATRQMBorrower?.Dirty == true
                    || Borrower?.Dirty == true
                    || Coborrower?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _accountNumber1.Dirty = value;
                _accountNumber2.Dirty = value;
                _allOtherPaymentsAmount.Dirty = value;
                _applicationId.Dirty = value;
                _applicationIndex.Dirty = value;
                _applicationSignedDate.Dirty = value;
                _assets.Dirty = value;
                _assetsAvailableAmount.Dirty = value;
                _aTRQMBorrowers.Dirty = value;
                _aUSTrackingLogs.Dirty = value;
                _balanceAvailableFamilySupportGuideline.Dirty = value;
                _bottomRatioPercent.Dirty = value;
                _brwCoBrwTotalTaxDeductions.Dirty = value;
                _creditAliasName1.Dirty = value;
                _creditAliasName2.Dirty = value;
                _creditorName1.Dirty = value;
                _creditorName2.Dirty = value;
                _creditReportReferenceIdentifier.Dirty = value;
                _employment.Dirty = value;
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
                _income.Dirty = value;
                _incomeOfBorrowersSpouseUsedIndicator.Dirty = value;
                _incomeOtherThanBorrowerUsedIndicator.Dirty = value;
                _jointAssetLiabilityReportingIndicator.Dirty = value;
                _liabilities.Dirty = value;
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
                _reoProperties.Dirty = value;
                _reoTotalGrossRentalIncomeAmount.Dirty = value;
                _reoTotalMaintenanceAmount.Dirty = value;
                _reoTotalMarketValueAmount.Dirty = value;
                _reoTotalMortgagePaymentsAmount.Dirty = value;
                _reoTotalMortgagesAndLiensAmount.Dirty = value;
                _reoTotalNetRentalIncomeAmount.Dirty = value;
                _residences.Dirty = value;
                _selfEmployedIncomes.Dirty = value;
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
                _tax4506s.Dirty = value;
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
                _tQLReports.Dirty = value;
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
                if (ATRQMBorrower != null) ATRQMBorrower.Dirty = value;
                if (Borrower != null) Borrower.Dirty = value;
                if (Coborrower != null) Coborrower.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}