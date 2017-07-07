using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Application : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountNumber1.Clean
                    && _accountNumber2.Clean
                    && _allOtherPaymentsAmount.Clean
                    && _applicationId.Clean
                    && _applicationIndex.Clean
                    && _applicationSignedDate.Clean
                    && _assets.Clean
                    && _assetsAvailableAmount.Clean
                    && _aTRQMBorrowers.Clean
                    && _aUSTrackingLogs.Clean
                    && _balanceAvailableFamilySupportGuideline.Clean
                    && _bottomRatioPercent.Clean
                    && _brwCoBrwTotalTaxDeductions.Clean
                    && _creditAliasName1.Clean
                    && _creditAliasName2.Clean
                    && _creditorName1.Clean
                    && _creditorName2.Clean
                    && _creditReportReferenceIdentifier.Clean
                    && _employment.Clean
                    && _entityDeleted.Clean
                    && _equifaxAddress.Clean
                    && _equifaxCity.Clean
                    && _equifaxFax.Clean
                    && _equifaxModel.Clean
                    && _equifaxName.Clean
                    && _equifaxPhone.Clean
                    && _equifaxPostalCode.Clean
                    && _equifaxScoreRangeFrom.Clean
                    && _equifaxScoreRangeTo.Clean
                    && _equifaxState.Clean
                    && _equifaxWebsite.Clean
                    && _experianAddress.Clean
                    && _experianCity.Clean
                    && _experianFax.Clean
                    && _experianModel.Clean
                    && _experianName.Clean
                    && _experianPhone.Clean
                    && _experianPostalCode.Clean
                    && _experianScoreRangeFrom.Clean
                    && _experianScoreRangeTo.Clean
                    && _experianState.Clean
                    && _experianWebsite.Clean
                    && _fhaVaDebtIncomeRatio.Clean
                    && _fhaVaFamilySupportAmount.Clean
                    && _fhaVaTotalEstimatedMonthlyShelterExpenseAmount.Clean
                    && _fhaVaTotalNetEffectiveIncomeAmount.Clean
                    && _fhaVaTotalNetIncomeAmount.Clean
                    && _fhaVaTotalNetTakeHomePayAmount.Clean
                    && _fhaVaTotalOtherNetIncome.Clean
                    && _firstMortgagePrincipalAndInterestAmount.Clean
                    && _freddieMacCreditReportReferenceIdentifier.Clean
                    && _freddieMacOccupantDebtRatio.Clean
                    && _freddieMacOccupantHousingRatio.Clean
                    && _freDebtToHousingGapRatio.Clean
                    && _grossBaseIncomeAmount.Clean
                    && _grossIncomeForComortSet.Clean
                    && _grossNegativeCashFlow.Clean
                    && _grossOtherIncomeAmount.Clean
                    && _grossPositiveCashFlow.Clean
                    && _hazardInsuranceAmount.Clean
                    && _homeownersAssociationDuesAndCondoFeesAmount.Clean
                    && _hudAutoLienHolderName1.Clean
                    && _hudAutoLienHolderName2.Clean
                    && _hudAutoLoanAmount1.Clean
                    && _hudAutoLoanAmount2.Clean
                    && _hudAutoMonthlyPayment1.Clean
                    && _hudAutoMonthlyPayment2.Clean
                    && _hudAutoPresentBalance1.Clean
                    && _hudAutoPresentBalance2.Clean
                    && _hudAutoYearAndMake1.Clean
                    && _hudAutoYearAndMake2.Clean
                    && _hudLoanAmount1.Clean
                    && _hudLoanAmount10.Clean
                    && _hudLoanAmount11.Clean
                    && _hudLoanAmount2.Clean
                    && _hudLoanAmount3.Clean
                    && _hudLoanAmount4.Clean
                    && _hudLoanAmount5.Clean
                    && _hudLoanAmount6.Clean
                    && _hudLoanAmount7.Clean
                    && _hudLoanAmount8.Clean
                    && _hudLoanAmount9.Clean
                    && _hudRealEstateFhaInsured1.Clean
                    && _hudRealEstateFhaInsured2.Clean
                    && _hudRealEstateLienHolder1.Clean
                    && _hudRealEstateLienHolder2.Clean
                    && _hudRealEstateLoanAmount1.Clean
                    && _hudRealEstateLoanAmount2.Clean
                    && _hudRealEstateMonthlyPayment1.Clean
                    && _hudRealEstateMonthlyPayment2.Clean
                    && _hudRealEstatePresentBalance1.Clean
                    && _hudRealEstatePresentBalance2.Clean
                    && _id.Clean
                    && _income.Clean
                    && _incomeOfBorrowersSpouseUsedIndicator.Clean
                    && _incomeOtherThanBorrowerUsedIndicator.Clean
                    && _jointAssetLiabilityReportingIndicator.Clean
                    && _liabilities.Clean
                    && _liquidAssetsComortSet.Clean
                    && _mcawBorrowerOtherMonthlyIncomeAmount.Clean
                    && _mcawCoborrowerOtherMonthlyIncomeAmount.Clean
                    && _mcawGrossMonthlyIncomeAmount.Clean
                    && _mcawMortgagePaymentToIncome1Amount.Clean
                    && _mcawMortgagePaymentToIncome2Amount.Clean
                    && _mcawOtherAmount.Clean
                    && _mcawOtherDebtsAndObligationsAmount.Clean
                    && _mcawTotalFixedPaymentForPurchaseAmount.Clean
                    && _mcawTotalFixedPaymentForRefinanceAmount.Clean
                    && _mcawTotalFixedPaymentToIncome1Amount.Clean
                    && _mcawTotalFixedPaymentToIncome2Amount.Clean
                    && _mcawTotalMonthlyPaymentsAmount.Clean
                    && _mcawTotalMortgagePaymentAmount.Clean
                    && _monthlyExpenseComortSet.Clean
                    && _monthlyHousingExpenseAmount.Clean
                    && _monthlyInstallmentExpenseAmount.Clean
                    && _monthlyNegativeRealEstateAmount.Clean
                    && _monthlySecondHomeAmount.Clean
                    && _mortgageInsuranceAmount.Clean
                    && _netWorthAmount.Clean
                    && _otherHousingExpenseAmount.Clean
                    && _otherItemsDeducted.Clean
                    && _otherMortgagePrincipalAndInterestAmount.Clean
                    && _pastCreditRecord.Clean
                    && _presentHousingExpComortSet.Clean
                    && _primaryResidenceComortSet.Clean
                    && _propertyUsageType.Clean
                    && _proposedDuesAmount.Clean
                    && _proposedFirstMortgageAmount.Clean
                    && _proposedGroundRentAmount.Clean
                    && _proposedHazardInsuranceAmount.Clean
                    && _proposedMortgageInsuranceAmount.Clean
                    && _proposedOtherAmount.Clean
                    && _proposedOtherMortgagesAmount.Clean
                    && _proposedRealEstateTaxesAmount.Clean
                    && _realEstateTaxAmount.Clean
                    && _rentAmount.Clean
                    && _reoProperties.Clean
                    && _reoTotalGrossRentalIncomeAmount.Clean
                    && _reoTotalMaintenanceAmount.Clean
                    && _reoTotalMarketValueAmount.Clean
                    && _reoTotalMortgagePaymentsAmount.Clean
                    && _reoTotalMortgagesAndLiensAmount.Clean
                    && _reoTotalNetRentalIncomeAmount.Clean
                    && _residences.Clean
                    && _selfEmployedIncomes.Clean
                    && _sofDBorrowerAddress.Clean
                    && _sofDBorrowerAddressCity.Clean
                    && _sofDBorrowerAddressState.Clean
                    && _sofDBorrowerAddressType.Clean
                    && _sofDBorrowerAddressZipcode.Clean
                    && _sofDCoBorrowerAddress.Clean
                    && _sofDCoBorrowerAddressCity.Clean
                    && _sofDCoBorrowerAddressState.Clean
                    && _sofDCoBorrowerAddressType.Clean
                    && _sofDCoBorrowerAddressZipcode.Clean
                    && _spouseIncomeConsider.Clean
                    && _tax4506s.Clean
                    && _topRatioPercent.Clean
                    && _totalAssetsAmount.Clean
                    && _totalBaseIncomeAmount.Clean
                    && _totalBonusAmount.Clean
                    && _totalCommissionsAmount.Clean
                    && _totalDeposit.Clean
                    && _totalDividendsInterestAmount.Clean
                    && _totalEmploymentAmount.Clean
                    && _totalFixedPaymentAmount.Clean
                    && _totalGrossMonthlyIncomeAmount.Clean
                    && _totalIncomeAmount.Clean
                    && _totalMonthlyPaymentAmount.Clean
                    && _totalMortgagesBalanceAmount.Clean
                    && _totalMortgagesMonthlyPaymentAmount.Clean
                    && _totalNetRentalIncomeAmount.Clean
                    && _totalOther1Amount.Clean
                    && _totalOther2Amount.Clean
                    && _totalOvertimeAmount.Clean
                    && _totalPaymentsAmount.Clean
                    && _totalPrimaryHousingExpenseAmount.Clean
                    && _totalReoMarketValueAmount.Clean
                    && _totalUserDefinedIncome.Clean
                    && _tQLReports.Clean
                    && _transUnionAddress.Clean
                    && _transUnionCity.Clean
                    && _transUnionFax.Clean
                    && _transUnionModel.Clean
                    && _transUnionName.Clean
                    && _transUnionPhone.Clean
                    && _transUnionPostalCode.Clean
                    && _transUnionScoreRangeFrom.Clean
                    && _transUnionScoreRangeTo.Clean
                    && _transUnionState.Clean
                    && _transUnionWebsite.Clean
                    && _userDefinedIncome.Clean
                    && _userDefinedIncomeDescription.Clean
                    && _vACreditStandards.Clean
                    && _vaSummarySpouseIncomeAmount.Clean
                    && _vaSummaryTotalMonthlyGrossIncomeAmount.Clean
                    && ATRQMBorrower.Clean
                    && Borrower.Clean
                    && Coborrower.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var accountNumber1 = _accountNumber1; accountNumber1.Clean = value; _accountNumber1 = accountNumber1;
                var accountNumber2 = _accountNumber2; accountNumber2.Clean = value; _accountNumber2 = accountNumber2;
                var allOtherPaymentsAmount = _allOtherPaymentsAmount; allOtherPaymentsAmount.Clean = value; _allOtherPaymentsAmount = allOtherPaymentsAmount;
                var applicationId = _applicationId; applicationId.Clean = value; _applicationId = applicationId;
                var applicationIndex = _applicationIndex; applicationIndex.Clean = value; _applicationIndex = applicationIndex;
                var applicationSignedDate = _applicationSignedDate; applicationSignedDate.Clean = value; _applicationSignedDate = applicationSignedDate;
                var assets = _assets; assets.Clean = value; _assets = assets;
                var assetsAvailableAmount = _assetsAvailableAmount; assetsAvailableAmount.Clean = value; _assetsAvailableAmount = assetsAvailableAmount;
                var aTRQMBorrowers = _aTRQMBorrowers; aTRQMBorrowers.Clean = value; _aTRQMBorrowers = aTRQMBorrowers;
                var aUSTrackingLogs = _aUSTrackingLogs; aUSTrackingLogs.Clean = value; _aUSTrackingLogs = aUSTrackingLogs;
                var balanceAvailableFamilySupportGuideline = _balanceAvailableFamilySupportGuideline; balanceAvailableFamilySupportGuideline.Clean = value; _balanceAvailableFamilySupportGuideline = balanceAvailableFamilySupportGuideline;
                var bottomRatioPercent = _bottomRatioPercent; bottomRatioPercent.Clean = value; _bottomRatioPercent = bottomRatioPercent;
                var brwCoBrwTotalTaxDeductions = _brwCoBrwTotalTaxDeductions; brwCoBrwTotalTaxDeductions.Clean = value; _brwCoBrwTotalTaxDeductions = brwCoBrwTotalTaxDeductions;
                var creditAliasName1 = _creditAliasName1; creditAliasName1.Clean = value; _creditAliasName1 = creditAliasName1;
                var creditAliasName2 = _creditAliasName2; creditAliasName2.Clean = value; _creditAliasName2 = creditAliasName2;
                var creditorName1 = _creditorName1; creditorName1.Clean = value; _creditorName1 = creditorName1;
                var creditorName2 = _creditorName2; creditorName2.Clean = value; _creditorName2 = creditorName2;
                var creditReportReferenceIdentifier = _creditReportReferenceIdentifier; creditReportReferenceIdentifier.Clean = value; _creditReportReferenceIdentifier = creditReportReferenceIdentifier;
                var employment = _employment; employment.Clean = value; _employment = employment;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var equifaxAddress = _equifaxAddress; equifaxAddress.Clean = value; _equifaxAddress = equifaxAddress;
                var equifaxCity = _equifaxCity; equifaxCity.Clean = value; _equifaxCity = equifaxCity;
                var equifaxFax = _equifaxFax; equifaxFax.Clean = value; _equifaxFax = equifaxFax;
                var equifaxModel = _equifaxModel; equifaxModel.Clean = value; _equifaxModel = equifaxModel;
                var equifaxName = _equifaxName; equifaxName.Clean = value; _equifaxName = equifaxName;
                var equifaxPhone = _equifaxPhone; equifaxPhone.Clean = value; _equifaxPhone = equifaxPhone;
                var equifaxPostalCode = _equifaxPostalCode; equifaxPostalCode.Clean = value; _equifaxPostalCode = equifaxPostalCode;
                var equifaxScoreRangeFrom = _equifaxScoreRangeFrom; equifaxScoreRangeFrom.Clean = value; _equifaxScoreRangeFrom = equifaxScoreRangeFrom;
                var equifaxScoreRangeTo = _equifaxScoreRangeTo; equifaxScoreRangeTo.Clean = value; _equifaxScoreRangeTo = equifaxScoreRangeTo;
                var equifaxState = _equifaxState; equifaxState.Clean = value; _equifaxState = equifaxState;
                var equifaxWebsite = _equifaxWebsite; equifaxWebsite.Clean = value; _equifaxWebsite = equifaxWebsite;
                var experianAddress = _experianAddress; experianAddress.Clean = value; _experianAddress = experianAddress;
                var experianCity = _experianCity; experianCity.Clean = value; _experianCity = experianCity;
                var experianFax = _experianFax; experianFax.Clean = value; _experianFax = experianFax;
                var experianModel = _experianModel; experianModel.Clean = value; _experianModel = experianModel;
                var experianName = _experianName; experianName.Clean = value; _experianName = experianName;
                var experianPhone = _experianPhone; experianPhone.Clean = value; _experianPhone = experianPhone;
                var experianPostalCode = _experianPostalCode; experianPostalCode.Clean = value; _experianPostalCode = experianPostalCode;
                var experianScoreRangeFrom = _experianScoreRangeFrom; experianScoreRangeFrom.Clean = value; _experianScoreRangeFrom = experianScoreRangeFrom;
                var experianScoreRangeTo = _experianScoreRangeTo; experianScoreRangeTo.Clean = value; _experianScoreRangeTo = experianScoreRangeTo;
                var experianState = _experianState; experianState.Clean = value; _experianState = experianState;
                var experianWebsite = _experianWebsite; experianWebsite.Clean = value; _experianWebsite = experianWebsite;
                var fhaVaDebtIncomeRatio = _fhaVaDebtIncomeRatio; fhaVaDebtIncomeRatio.Clean = value; _fhaVaDebtIncomeRatio = fhaVaDebtIncomeRatio;
                var fhaVaFamilySupportAmount = _fhaVaFamilySupportAmount; fhaVaFamilySupportAmount.Clean = value; _fhaVaFamilySupportAmount = fhaVaFamilySupportAmount;
                var fhaVaTotalEstimatedMonthlyShelterExpenseAmount = _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; fhaVaTotalEstimatedMonthlyShelterExpenseAmount.Clean = value; _fhaVaTotalEstimatedMonthlyShelterExpenseAmount = fhaVaTotalEstimatedMonthlyShelterExpenseAmount;
                var fhaVaTotalNetEffectiveIncomeAmount = _fhaVaTotalNetEffectiveIncomeAmount; fhaVaTotalNetEffectiveIncomeAmount.Clean = value; _fhaVaTotalNetEffectiveIncomeAmount = fhaVaTotalNetEffectiveIncomeAmount;
                var fhaVaTotalNetIncomeAmount = _fhaVaTotalNetIncomeAmount; fhaVaTotalNetIncomeAmount.Clean = value; _fhaVaTotalNetIncomeAmount = fhaVaTotalNetIncomeAmount;
                var fhaVaTotalNetTakeHomePayAmount = _fhaVaTotalNetTakeHomePayAmount; fhaVaTotalNetTakeHomePayAmount.Clean = value; _fhaVaTotalNetTakeHomePayAmount = fhaVaTotalNetTakeHomePayAmount;
                var fhaVaTotalOtherNetIncome = _fhaVaTotalOtherNetIncome; fhaVaTotalOtherNetIncome.Clean = value; _fhaVaTotalOtherNetIncome = fhaVaTotalOtherNetIncome;
                var firstMortgagePrincipalAndInterestAmount = _firstMortgagePrincipalAndInterestAmount; firstMortgagePrincipalAndInterestAmount.Clean = value; _firstMortgagePrincipalAndInterestAmount = firstMortgagePrincipalAndInterestAmount;
                var freddieMacCreditReportReferenceIdentifier = _freddieMacCreditReportReferenceIdentifier; freddieMacCreditReportReferenceIdentifier.Clean = value; _freddieMacCreditReportReferenceIdentifier = freddieMacCreditReportReferenceIdentifier;
                var freddieMacOccupantDebtRatio = _freddieMacOccupantDebtRatio; freddieMacOccupantDebtRatio.Clean = value; _freddieMacOccupantDebtRatio = freddieMacOccupantDebtRatio;
                var freddieMacOccupantHousingRatio = _freddieMacOccupantHousingRatio; freddieMacOccupantHousingRatio.Clean = value; _freddieMacOccupantHousingRatio = freddieMacOccupantHousingRatio;
                var freDebtToHousingGapRatio = _freDebtToHousingGapRatio; freDebtToHousingGapRatio.Clean = value; _freDebtToHousingGapRatio = freDebtToHousingGapRatio;
                var grossBaseIncomeAmount = _grossBaseIncomeAmount; grossBaseIncomeAmount.Clean = value; _grossBaseIncomeAmount = grossBaseIncomeAmount;
                var grossIncomeForComortSet = _grossIncomeForComortSet; grossIncomeForComortSet.Clean = value; _grossIncomeForComortSet = grossIncomeForComortSet;
                var grossNegativeCashFlow = _grossNegativeCashFlow; grossNegativeCashFlow.Clean = value; _grossNegativeCashFlow = grossNegativeCashFlow;
                var grossOtherIncomeAmount = _grossOtherIncomeAmount; grossOtherIncomeAmount.Clean = value; _grossOtherIncomeAmount = grossOtherIncomeAmount;
                var grossPositiveCashFlow = _grossPositiveCashFlow; grossPositiveCashFlow.Clean = value; _grossPositiveCashFlow = grossPositiveCashFlow;
                var hazardInsuranceAmount = _hazardInsuranceAmount; hazardInsuranceAmount.Clean = value; _hazardInsuranceAmount = hazardInsuranceAmount;
                var homeownersAssociationDuesAndCondoFeesAmount = _homeownersAssociationDuesAndCondoFeesAmount; homeownersAssociationDuesAndCondoFeesAmount.Clean = value; _homeownersAssociationDuesAndCondoFeesAmount = homeownersAssociationDuesAndCondoFeesAmount;
                var hudAutoLienHolderName1 = _hudAutoLienHolderName1; hudAutoLienHolderName1.Clean = value; _hudAutoLienHolderName1 = hudAutoLienHolderName1;
                var hudAutoLienHolderName2 = _hudAutoLienHolderName2; hudAutoLienHolderName2.Clean = value; _hudAutoLienHolderName2 = hudAutoLienHolderName2;
                var hudAutoLoanAmount1 = _hudAutoLoanAmount1; hudAutoLoanAmount1.Clean = value; _hudAutoLoanAmount1 = hudAutoLoanAmount1;
                var hudAutoLoanAmount2 = _hudAutoLoanAmount2; hudAutoLoanAmount2.Clean = value; _hudAutoLoanAmount2 = hudAutoLoanAmount2;
                var hudAutoMonthlyPayment1 = _hudAutoMonthlyPayment1; hudAutoMonthlyPayment1.Clean = value; _hudAutoMonthlyPayment1 = hudAutoMonthlyPayment1;
                var hudAutoMonthlyPayment2 = _hudAutoMonthlyPayment2; hudAutoMonthlyPayment2.Clean = value; _hudAutoMonthlyPayment2 = hudAutoMonthlyPayment2;
                var hudAutoPresentBalance1 = _hudAutoPresentBalance1; hudAutoPresentBalance1.Clean = value; _hudAutoPresentBalance1 = hudAutoPresentBalance1;
                var hudAutoPresentBalance2 = _hudAutoPresentBalance2; hudAutoPresentBalance2.Clean = value; _hudAutoPresentBalance2 = hudAutoPresentBalance2;
                var hudAutoYearAndMake1 = _hudAutoYearAndMake1; hudAutoYearAndMake1.Clean = value; _hudAutoYearAndMake1 = hudAutoYearAndMake1;
                var hudAutoYearAndMake2 = _hudAutoYearAndMake2; hudAutoYearAndMake2.Clean = value; _hudAutoYearAndMake2 = hudAutoYearAndMake2;
                var hudLoanAmount1 = _hudLoanAmount1; hudLoanAmount1.Clean = value; _hudLoanAmount1 = hudLoanAmount1;
                var hudLoanAmount10 = _hudLoanAmount10; hudLoanAmount10.Clean = value; _hudLoanAmount10 = hudLoanAmount10;
                var hudLoanAmount11 = _hudLoanAmount11; hudLoanAmount11.Clean = value; _hudLoanAmount11 = hudLoanAmount11;
                var hudLoanAmount2 = _hudLoanAmount2; hudLoanAmount2.Clean = value; _hudLoanAmount2 = hudLoanAmount2;
                var hudLoanAmount3 = _hudLoanAmount3; hudLoanAmount3.Clean = value; _hudLoanAmount3 = hudLoanAmount3;
                var hudLoanAmount4 = _hudLoanAmount4; hudLoanAmount4.Clean = value; _hudLoanAmount4 = hudLoanAmount4;
                var hudLoanAmount5 = _hudLoanAmount5; hudLoanAmount5.Clean = value; _hudLoanAmount5 = hudLoanAmount5;
                var hudLoanAmount6 = _hudLoanAmount6; hudLoanAmount6.Clean = value; _hudLoanAmount6 = hudLoanAmount6;
                var hudLoanAmount7 = _hudLoanAmount7; hudLoanAmount7.Clean = value; _hudLoanAmount7 = hudLoanAmount7;
                var hudLoanAmount8 = _hudLoanAmount8; hudLoanAmount8.Clean = value; _hudLoanAmount8 = hudLoanAmount8;
                var hudLoanAmount9 = _hudLoanAmount9; hudLoanAmount9.Clean = value; _hudLoanAmount9 = hudLoanAmount9;
                var hudRealEstateFhaInsured1 = _hudRealEstateFhaInsured1; hudRealEstateFhaInsured1.Clean = value; _hudRealEstateFhaInsured1 = hudRealEstateFhaInsured1;
                var hudRealEstateFhaInsured2 = _hudRealEstateFhaInsured2; hudRealEstateFhaInsured2.Clean = value; _hudRealEstateFhaInsured2 = hudRealEstateFhaInsured2;
                var hudRealEstateLienHolder1 = _hudRealEstateLienHolder1; hudRealEstateLienHolder1.Clean = value; _hudRealEstateLienHolder1 = hudRealEstateLienHolder1;
                var hudRealEstateLienHolder2 = _hudRealEstateLienHolder2; hudRealEstateLienHolder2.Clean = value; _hudRealEstateLienHolder2 = hudRealEstateLienHolder2;
                var hudRealEstateLoanAmount1 = _hudRealEstateLoanAmount1; hudRealEstateLoanAmount1.Clean = value; _hudRealEstateLoanAmount1 = hudRealEstateLoanAmount1;
                var hudRealEstateLoanAmount2 = _hudRealEstateLoanAmount2; hudRealEstateLoanAmount2.Clean = value; _hudRealEstateLoanAmount2 = hudRealEstateLoanAmount2;
                var hudRealEstateMonthlyPayment1 = _hudRealEstateMonthlyPayment1; hudRealEstateMonthlyPayment1.Clean = value; _hudRealEstateMonthlyPayment1 = hudRealEstateMonthlyPayment1;
                var hudRealEstateMonthlyPayment2 = _hudRealEstateMonthlyPayment2; hudRealEstateMonthlyPayment2.Clean = value; _hudRealEstateMonthlyPayment2 = hudRealEstateMonthlyPayment2;
                var hudRealEstatePresentBalance1 = _hudRealEstatePresentBalance1; hudRealEstatePresentBalance1.Clean = value; _hudRealEstatePresentBalance1 = hudRealEstatePresentBalance1;
                var hudRealEstatePresentBalance2 = _hudRealEstatePresentBalance2; hudRealEstatePresentBalance2.Clean = value; _hudRealEstatePresentBalance2 = hudRealEstatePresentBalance2;
                var id = _id; id.Clean = value; _id = id;
                var income = _income; income.Clean = value; _income = income;
                var incomeOfBorrowersSpouseUsedIndicator = _incomeOfBorrowersSpouseUsedIndicator; incomeOfBorrowersSpouseUsedIndicator.Clean = value; _incomeOfBorrowersSpouseUsedIndicator = incomeOfBorrowersSpouseUsedIndicator;
                var incomeOtherThanBorrowerUsedIndicator = _incomeOtherThanBorrowerUsedIndicator; incomeOtherThanBorrowerUsedIndicator.Clean = value; _incomeOtherThanBorrowerUsedIndicator = incomeOtherThanBorrowerUsedIndicator;
                var jointAssetLiabilityReportingIndicator = _jointAssetLiabilityReportingIndicator; jointAssetLiabilityReportingIndicator.Clean = value; _jointAssetLiabilityReportingIndicator = jointAssetLiabilityReportingIndicator;
                var liabilities = _liabilities; liabilities.Clean = value; _liabilities = liabilities;
                var liquidAssetsComortSet = _liquidAssetsComortSet; liquidAssetsComortSet.Clean = value; _liquidAssetsComortSet = liquidAssetsComortSet;
                var mcawBorrowerOtherMonthlyIncomeAmount = _mcawBorrowerOtherMonthlyIncomeAmount; mcawBorrowerOtherMonthlyIncomeAmount.Clean = value; _mcawBorrowerOtherMonthlyIncomeAmount = mcawBorrowerOtherMonthlyIncomeAmount;
                var mcawCoborrowerOtherMonthlyIncomeAmount = _mcawCoborrowerOtherMonthlyIncomeAmount; mcawCoborrowerOtherMonthlyIncomeAmount.Clean = value; _mcawCoborrowerOtherMonthlyIncomeAmount = mcawCoborrowerOtherMonthlyIncomeAmount;
                var mcawGrossMonthlyIncomeAmount = _mcawGrossMonthlyIncomeAmount; mcawGrossMonthlyIncomeAmount.Clean = value; _mcawGrossMonthlyIncomeAmount = mcawGrossMonthlyIncomeAmount;
                var mcawMortgagePaymentToIncome1Amount = _mcawMortgagePaymentToIncome1Amount; mcawMortgagePaymentToIncome1Amount.Clean = value; _mcawMortgagePaymentToIncome1Amount = mcawMortgagePaymentToIncome1Amount;
                var mcawMortgagePaymentToIncome2Amount = _mcawMortgagePaymentToIncome2Amount; mcawMortgagePaymentToIncome2Amount.Clean = value; _mcawMortgagePaymentToIncome2Amount = mcawMortgagePaymentToIncome2Amount;
                var mcawOtherAmount = _mcawOtherAmount; mcawOtherAmount.Clean = value; _mcawOtherAmount = mcawOtherAmount;
                var mcawOtherDebtsAndObligationsAmount = _mcawOtherDebtsAndObligationsAmount; mcawOtherDebtsAndObligationsAmount.Clean = value; _mcawOtherDebtsAndObligationsAmount = mcawOtherDebtsAndObligationsAmount;
                var mcawTotalFixedPaymentForPurchaseAmount = _mcawTotalFixedPaymentForPurchaseAmount; mcawTotalFixedPaymentForPurchaseAmount.Clean = value; _mcawTotalFixedPaymentForPurchaseAmount = mcawTotalFixedPaymentForPurchaseAmount;
                var mcawTotalFixedPaymentForRefinanceAmount = _mcawTotalFixedPaymentForRefinanceAmount; mcawTotalFixedPaymentForRefinanceAmount.Clean = value; _mcawTotalFixedPaymentForRefinanceAmount = mcawTotalFixedPaymentForRefinanceAmount;
                var mcawTotalFixedPaymentToIncome1Amount = _mcawTotalFixedPaymentToIncome1Amount; mcawTotalFixedPaymentToIncome1Amount.Clean = value; _mcawTotalFixedPaymentToIncome1Amount = mcawTotalFixedPaymentToIncome1Amount;
                var mcawTotalFixedPaymentToIncome2Amount = _mcawTotalFixedPaymentToIncome2Amount; mcawTotalFixedPaymentToIncome2Amount.Clean = value; _mcawTotalFixedPaymentToIncome2Amount = mcawTotalFixedPaymentToIncome2Amount;
                var mcawTotalMonthlyPaymentsAmount = _mcawTotalMonthlyPaymentsAmount; mcawTotalMonthlyPaymentsAmount.Clean = value; _mcawTotalMonthlyPaymentsAmount = mcawTotalMonthlyPaymentsAmount;
                var mcawTotalMortgagePaymentAmount = _mcawTotalMortgagePaymentAmount; mcawTotalMortgagePaymentAmount.Clean = value; _mcawTotalMortgagePaymentAmount = mcawTotalMortgagePaymentAmount;
                var monthlyExpenseComortSet = _monthlyExpenseComortSet; monthlyExpenseComortSet.Clean = value; _monthlyExpenseComortSet = monthlyExpenseComortSet;
                var monthlyHousingExpenseAmount = _monthlyHousingExpenseAmount; monthlyHousingExpenseAmount.Clean = value; _monthlyHousingExpenseAmount = monthlyHousingExpenseAmount;
                var monthlyInstallmentExpenseAmount = _monthlyInstallmentExpenseAmount; monthlyInstallmentExpenseAmount.Clean = value; _monthlyInstallmentExpenseAmount = monthlyInstallmentExpenseAmount;
                var monthlyNegativeRealEstateAmount = _monthlyNegativeRealEstateAmount; monthlyNegativeRealEstateAmount.Clean = value; _monthlyNegativeRealEstateAmount = monthlyNegativeRealEstateAmount;
                var monthlySecondHomeAmount = _monthlySecondHomeAmount; monthlySecondHomeAmount.Clean = value; _monthlySecondHomeAmount = monthlySecondHomeAmount;
                var mortgageInsuranceAmount = _mortgageInsuranceAmount; mortgageInsuranceAmount.Clean = value; _mortgageInsuranceAmount = mortgageInsuranceAmount;
                var netWorthAmount = _netWorthAmount; netWorthAmount.Clean = value; _netWorthAmount = netWorthAmount;
                var otherHousingExpenseAmount = _otherHousingExpenseAmount; otherHousingExpenseAmount.Clean = value; _otherHousingExpenseAmount = otherHousingExpenseAmount;
                var otherItemsDeducted = _otherItemsDeducted; otherItemsDeducted.Clean = value; _otherItemsDeducted = otherItemsDeducted;
                var otherMortgagePrincipalAndInterestAmount = _otherMortgagePrincipalAndInterestAmount; otherMortgagePrincipalAndInterestAmount.Clean = value; _otherMortgagePrincipalAndInterestAmount = otherMortgagePrincipalAndInterestAmount;
                var pastCreditRecord = _pastCreditRecord; pastCreditRecord.Clean = value; _pastCreditRecord = pastCreditRecord;
                var presentHousingExpComortSet = _presentHousingExpComortSet; presentHousingExpComortSet.Clean = value; _presentHousingExpComortSet = presentHousingExpComortSet;
                var primaryResidenceComortSet = _primaryResidenceComortSet; primaryResidenceComortSet.Clean = value; _primaryResidenceComortSet = primaryResidenceComortSet;
                var propertyUsageType = _propertyUsageType; propertyUsageType.Clean = value; _propertyUsageType = propertyUsageType;
                var proposedDuesAmount = _proposedDuesAmount; proposedDuesAmount.Clean = value; _proposedDuesAmount = proposedDuesAmount;
                var proposedFirstMortgageAmount = _proposedFirstMortgageAmount; proposedFirstMortgageAmount.Clean = value; _proposedFirstMortgageAmount = proposedFirstMortgageAmount;
                var proposedGroundRentAmount = _proposedGroundRentAmount; proposedGroundRentAmount.Clean = value; _proposedGroundRentAmount = proposedGroundRentAmount;
                var proposedHazardInsuranceAmount = _proposedHazardInsuranceAmount; proposedHazardInsuranceAmount.Clean = value; _proposedHazardInsuranceAmount = proposedHazardInsuranceAmount;
                var proposedMortgageInsuranceAmount = _proposedMortgageInsuranceAmount; proposedMortgageInsuranceAmount.Clean = value; _proposedMortgageInsuranceAmount = proposedMortgageInsuranceAmount;
                var proposedOtherAmount = _proposedOtherAmount; proposedOtherAmount.Clean = value; _proposedOtherAmount = proposedOtherAmount;
                var proposedOtherMortgagesAmount = _proposedOtherMortgagesAmount; proposedOtherMortgagesAmount.Clean = value; _proposedOtherMortgagesAmount = proposedOtherMortgagesAmount;
                var proposedRealEstateTaxesAmount = _proposedRealEstateTaxesAmount; proposedRealEstateTaxesAmount.Clean = value; _proposedRealEstateTaxesAmount = proposedRealEstateTaxesAmount;
                var realEstateTaxAmount = _realEstateTaxAmount; realEstateTaxAmount.Clean = value; _realEstateTaxAmount = realEstateTaxAmount;
                var rentAmount = _rentAmount; rentAmount.Clean = value; _rentAmount = rentAmount;
                var reoProperties = _reoProperties; reoProperties.Clean = value; _reoProperties = reoProperties;
                var reoTotalGrossRentalIncomeAmount = _reoTotalGrossRentalIncomeAmount; reoTotalGrossRentalIncomeAmount.Clean = value; _reoTotalGrossRentalIncomeAmount = reoTotalGrossRentalIncomeAmount;
                var reoTotalMaintenanceAmount = _reoTotalMaintenanceAmount; reoTotalMaintenanceAmount.Clean = value; _reoTotalMaintenanceAmount = reoTotalMaintenanceAmount;
                var reoTotalMarketValueAmount = _reoTotalMarketValueAmount; reoTotalMarketValueAmount.Clean = value; _reoTotalMarketValueAmount = reoTotalMarketValueAmount;
                var reoTotalMortgagePaymentsAmount = _reoTotalMortgagePaymentsAmount; reoTotalMortgagePaymentsAmount.Clean = value; _reoTotalMortgagePaymentsAmount = reoTotalMortgagePaymentsAmount;
                var reoTotalMortgagesAndLiensAmount = _reoTotalMortgagesAndLiensAmount; reoTotalMortgagesAndLiensAmount.Clean = value; _reoTotalMortgagesAndLiensAmount = reoTotalMortgagesAndLiensAmount;
                var reoTotalNetRentalIncomeAmount = _reoTotalNetRentalIncomeAmount; reoTotalNetRentalIncomeAmount.Clean = value; _reoTotalNetRentalIncomeAmount = reoTotalNetRentalIncomeAmount;
                var residences = _residences; residences.Clean = value; _residences = residences;
                var selfEmployedIncomes = _selfEmployedIncomes; selfEmployedIncomes.Clean = value; _selfEmployedIncomes = selfEmployedIncomes;
                var sofDBorrowerAddress = _sofDBorrowerAddress; sofDBorrowerAddress.Clean = value; _sofDBorrowerAddress = sofDBorrowerAddress;
                var sofDBorrowerAddressCity = _sofDBorrowerAddressCity; sofDBorrowerAddressCity.Clean = value; _sofDBorrowerAddressCity = sofDBorrowerAddressCity;
                var sofDBorrowerAddressState = _sofDBorrowerAddressState; sofDBorrowerAddressState.Clean = value; _sofDBorrowerAddressState = sofDBorrowerAddressState;
                var sofDBorrowerAddressType = _sofDBorrowerAddressType; sofDBorrowerAddressType.Clean = value; _sofDBorrowerAddressType = sofDBorrowerAddressType;
                var sofDBorrowerAddressZipcode = _sofDBorrowerAddressZipcode; sofDBorrowerAddressZipcode.Clean = value; _sofDBorrowerAddressZipcode = sofDBorrowerAddressZipcode;
                var sofDCoBorrowerAddress = _sofDCoBorrowerAddress; sofDCoBorrowerAddress.Clean = value; _sofDCoBorrowerAddress = sofDCoBorrowerAddress;
                var sofDCoBorrowerAddressCity = _sofDCoBorrowerAddressCity; sofDCoBorrowerAddressCity.Clean = value; _sofDCoBorrowerAddressCity = sofDCoBorrowerAddressCity;
                var sofDCoBorrowerAddressState = _sofDCoBorrowerAddressState; sofDCoBorrowerAddressState.Clean = value; _sofDCoBorrowerAddressState = sofDCoBorrowerAddressState;
                var sofDCoBorrowerAddressType = _sofDCoBorrowerAddressType; sofDCoBorrowerAddressType.Clean = value; _sofDCoBorrowerAddressType = sofDCoBorrowerAddressType;
                var sofDCoBorrowerAddressZipcode = _sofDCoBorrowerAddressZipcode; sofDCoBorrowerAddressZipcode.Clean = value; _sofDCoBorrowerAddressZipcode = sofDCoBorrowerAddressZipcode;
                var spouseIncomeConsider = _spouseIncomeConsider; spouseIncomeConsider.Clean = value; _spouseIncomeConsider = spouseIncomeConsider;
                var tax4506s = _tax4506s; tax4506s.Clean = value; _tax4506s = tax4506s;
                var topRatioPercent = _topRatioPercent; topRatioPercent.Clean = value; _topRatioPercent = topRatioPercent;
                var totalAssetsAmount = _totalAssetsAmount; totalAssetsAmount.Clean = value; _totalAssetsAmount = totalAssetsAmount;
                var totalBaseIncomeAmount = _totalBaseIncomeAmount; totalBaseIncomeAmount.Clean = value; _totalBaseIncomeAmount = totalBaseIncomeAmount;
                var totalBonusAmount = _totalBonusAmount; totalBonusAmount.Clean = value; _totalBonusAmount = totalBonusAmount;
                var totalCommissionsAmount = _totalCommissionsAmount; totalCommissionsAmount.Clean = value; _totalCommissionsAmount = totalCommissionsAmount;
                var totalDeposit = _totalDeposit; totalDeposit.Clean = value; _totalDeposit = totalDeposit;
                var totalDividendsInterestAmount = _totalDividendsInterestAmount; totalDividendsInterestAmount.Clean = value; _totalDividendsInterestAmount = totalDividendsInterestAmount;
                var totalEmploymentAmount = _totalEmploymentAmount; totalEmploymentAmount.Clean = value; _totalEmploymentAmount = totalEmploymentAmount;
                var totalFixedPaymentAmount = _totalFixedPaymentAmount; totalFixedPaymentAmount.Clean = value; _totalFixedPaymentAmount = totalFixedPaymentAmount;
                var totalGrossMonthlyIncomeAmount = _totalGrossMonthlyIncomeAmount; totalGrossMonthlyIncomeAmount.Clean = value; _totalGrossMonthlyIncomeAmount = totalGrossMonthlyIncomeAmount;
                var totalIncomeAmount = _totalIncomeAmount; totalIncomeAmount.Clean = value; _totalIncomeAmount = totalIncomeAmount;
                var totalMonthlyPaymentAmount = _totalMonthlyPaymentAmount; totalMonthlyPaymentAmount.Clean = value; _totalMonthlyPaymentAmount = totalMonthlyPaymentAmount;
                var totalMortgagesBalanceAmount = _totalMortgagesBalanceAmount; totalMortgagesBalanceAmount.Clean = value; _totalMortgagesBalanceAmount = totalMortgagesBalanceAmount;
                var totalMortgagesMonthlyPaymentAmount = _totalMortgagesMonthlyPaymentAmount; totalMortgagesMonthlyPaymentAmount.Clean = value; _totalMortgagesMonthlyPaymentAmount = totalMortgagesMonthlyPaymentAmount;
                var totalNetRentalIncomeAmount = _totalNetRentalIncomeAmount; totalNetRentalIncomeAmount.Clean = value; _totalNetRentalIncomeAmount = totalNetRentalIncomeAmount;
                var totalOther1Amount = _totalOther1Amount; totalOther1Amount.Clean = value; _totalOther1Amount = totalOther1Amount;
                var totalOther2Amount = _totalOther2Amount; totalOther2Amount.Clean = value; _totalOther2Amount = totalOther2Amount;
                var totalOvertimeAmount = _totalOvertimeAmount; totalOvertimeAmount.Clean = value; _totalOvertimeAmount = totalOvertimeAmount;
                var totalPaymentsAmount = _totalPaymentsAmount; totalPaymentsAmount.Clean = value; _totalPaymentsAmount = totalPaymentsAmount;
                var totalPrimaryHousingExpenseAmount = _totalPrimaryHousingExpenseAmount; totalPrimaryHousingExpenseAmount.Clean = value; _totalPrimaryHousingExpenseAmount = totalPrimaryHousingExpenseAmount;
                var totalReoMarketValueAmount = _totalReoMarketValueAmount; totalReoMarketValueAmount.Clean = value; _totalReoMarketValueAmount = totalReoMarketValueAmount;
                var totalUserDefinedIncome = _totalUserDefinedIncome; totalUserDefinedIncome.Clean = value; _totalUserDefinedIncome = totalUserDefinedIncome;
                var tQLReports = _tQLReports; tQLReports.Clean = value; _tQLReports = tQLReports;
                var transUnionAddress = _transUnionAddress; transUnionAddress.Clean = value; _transUnionAddress = transUnionAddress;
                var transUnionCity = _transUnionCity; transUnionCity.Clean = value; _transUnionCity = transUnionCity;
                var transUnionFax = _transUnionFax; transUnionFax.Clean = value; _transUnionFax = transUnionFax;
                var transUnionModel = _transUnionModel; transUnionModel.Clean = value; _transUnionModel = transUnionModel;
                var transUnionName = _transUnionName; transUnionName.Clean = value; _transUnionName = transUnionName;
                var transUnionPhone = _transUnionPhone; transUnionPhone.Clean = value; _transUnionPhone = transUnionPhone;
                var transUnionPostalCode = _transUnionPostalCode; transUnionPostalCode.Clean = value; _transUnionPostalCode = transUnionPostalCode;
                var transUnionScoreRangeFrom = _transUnionScoreRangeFrom; transUnionScoreRangeFrom.Clean = value; _transUnionScoreRangeFrom = transUnionScoreRangeFrom;
                var transUnionScoreRangeTo = _transUnionScoreRangeTo; transUnionScoreRangeTo.Clean = value; _transUnionScoreRangeTo = transUnionScoreRangeTo;
                var transUnionState = _transUnionState; transUnionState.Clean = value; _transUnionState = transUnionState;
                var transUnionWebsite = _transUnionWebsite; transUnionWebsite.Clean = value; _transUnionWebsite = transUnionWebsite;
                var userDefinedIncome = _userDefinedIncome; userDefinedIncome.Clean = value; _userDefinedIncome = userDefinedIncome;
                var userDefinedIncomeDescription = _userDefinedIncomeDescription; userDefinedIncomeDescription.Clean = value; _userDefinedIncomeDescription = userDefinedIncomeDescription;
                var vACreditStandards = _vACreditStandards; vACreditStandards.Clean = value; _vACreditStandards = vACreditStandards;
                var vaSummarySpouseIncomeAmount = _vaSummarySpouseIncomeAmount; vaSummarySpouseIncomeAmount.Clean = value; _vaSummarySpouseIncomeAmount = vaSummarySpouseIncomeAmount;
                var vaSummaryTotalMonthlyGrossIncomeAmount = _vaSummaryTotalMonthlyGrossIncomeAmount; vaSummaryTotalMonthlyGrossIncomeAmount.Clean = value; _vaSummaryTotalMonthlyGrossIncomeAmount = vaSummaryTotalMonthlyGrossIncomeAmount;
                if (ATRQMBorrower != null) ATRQMBorrower.Clean = value;
                if (Borrower != null) Borrower.Clean = value;
                if (Coborrower != null) Coborrower.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Application()
        {
            Clean = true;
        }
    }
}