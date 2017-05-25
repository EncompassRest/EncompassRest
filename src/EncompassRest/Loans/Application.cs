using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _accountNumber1; v0.Clean = value; _accountNumber1 = v0;
                var v1 = _accountNumber2; v1.Clean = value; _accountNumber2 = v1;
                var v2 = _allOtherPaymentsAmount; v2.Clean = value; _allOtherPaymentsAmount = v2;
                var v3 = _applicationId; v3.Clean = value; _applicationId = v3;
                var v4 = _applicationIndex; v4.Clean = value; _applicationIndex = v4;
                var v5 = _applicationSignedDate; v5.Clean = value; _applicationSignedDate = v5;
                var v6 = _assets; v6.Clean = value; _assets = v6;
                var v7 = _assetsAvailableAmount; v7.Clean = value; _assetsAvailableAmount = v7;
                var v8 = _aTRQMBorrowers; v8.Clean = value; _aTRQMBorrowers = v8;
                var v9 = _aUSTrackingLogs; v9.Clean = value; _aUSTrackingLogs = v9;
                var v10 = _balanceAvailableFamilySupportGuideline; v10.Clean = value; _balanceAvailableFamilySupportGuideline = v10;
                var v11 = _bottomRatioPercent; v11.Clean = value; _bottomRatioPercent = v11;
                var v12 = _brwCoBrwTotalTaxDeductions; v12.Clean = value; _brwCoBrwTotalTaxDeductions = v12;
                var v13 = _creditAliasName1; v13.Clean = value; _creditAliasName1 = v13;
                var v14 = _creditAliasName2; v14.Clean = value; _creditAliasName2 = v14;
                var v15 = _creditorName1; v15.Clean = value; _creditorName1 = v15;
                var v16 = _creditorName2; v16.Clean = value; _creditorName2 = v16;
                var v17 = _creditReportReferenceIdentifier; v17.Clean = value; _creditReportReferenceIdentifier = v17;
                var v18 = _employment; v18.Clean = value; _employment = v18;
                var v19 = _entityDeleted; v19.Clean = value; _entityDeleted = v19;
                var v20 = _equifaxAddress; v20.Clean = value; _equifaxAddress = v20;
                var v21 = _equifaxCity; v21.Clean = value; _equifaxCity = v21;
                var v22 = _equifaxFax; v22.Clean = value; _equifaxFax = v22;
                var v23 = _equifaxModel; v23.Clean = value; _equifaxModel = v23;
                var v24 = _equifaxName; v24.Clean = value; _equifaxName = v24;
                var v25 = _equifaxPhone; v25.Clean = value; _equifaxPhone = v25;
                var v26 = _equifaxPostalCode; v26.Clean = value; _equifaxPostalCode = v26;
                var v27 = _equifaxScoreRangeFrom; v27.Clean = value; _equifaxScoreRangeFrom = v27;
                var v28 = _equifaxScoreRangeTo; v28.Clean = value; _equifaxScoreRangeTo = v28;
                var v29 = _equifaxState; v29.Clean = value; _equifaxState = v29;
                var v30 = _equifaxWebsite; v30.Clean = value; _equifaxWebsite = v30;
                var v31 = _experianAddress; v31.Clean = value; _experianAddress = v31;
                var v32 = _experianCity; v32.Clean = value; _experianCity = v32;
                var v33 = _experianFax; v33.Clean = value; _experianFax = v33;
                var v34 = _experianModel; v34.Clean = value; _experianModel = v34;
                var v35 = _experianName; v35.Clean = value; _experianName = v35;
                var v36 = _experianPhone; v36.Clean = value; _experianPhone = v36;
                var v37 = _experianPostalCode; v37.Clean = value; _experianPostalCode = v37;
                var v38 = _experianScoreRangeFrom; v38.Clean = value; _experianScoreRangeFrom = v38;
                var v39 = _experianScoreRangeTo; v39.Clean = value; _experianScoreRangeTo = v39;
                var v40 = _experianState; v40.Clean = value; _experianState = v40;
                var v41 = _experianWebsite; v41.Clean = value; _experianWebsite = v41;
                var v42 = _fhaVaDebtIncomeRatio; v42.Clean = value; _fhaVaDebtIncomeRatio = v42;
                var v43 = _fhaVaFamilySupportAmount; v43.Clean = value; _fhaVaFamilySupportAmount = v43;
                var v44 = _fhaVaTotalEstimatedMonthlyShelterExpenseAmount; v44.Clean = value; _fhaVaTotalEstimatedMonthlyShelterExpenseAmount = v44;
                var v45 = _fhaVaTotalNetEffectiveIncomeAmount; v45.Clean = value; _fhaVaTotalNetEffectiveIncomeAmount = v45;
                var v46 = _fhaVaTotalNetIncomeAmount; v46.Clean = value; _fhaVaTotalNetIncomeAmount = v46;
                var v47 = _fhaVaTotalNetTakeHomePayAmount; v47.Clean = value; _fhaVaTotalNetTakeHomePayAmount = v47;
                var v48 = _fhaVaTotalOtherNetIncome; v48.Clean = value; _fhaVaTotalOtherNetIncome = v48;
                var v49 = _firstMortgagePrincipalAndInterestAmount; v49.Clean = value; _firstMortgagePrincipalAndInterestAmount = v49;
                var v50 = _freddieMacCreditReportReferenceIdentifier; v50.Clean = value; _freddieMacCreditReportReferenceIdentifier = v50;
                var v51 = _freddieMacOccupantDebtRatio; v51.Clean = value; _freddieMacOccupantDebtRatio = v51;
                var v52 = _freddieMacOccupantHousingRatio; v52.Clean = value; _freddieMacOccupantHousingRatio = v52;
                var v53 = _freDebtToHousingGapRatio; v53.Clean = value; _freDebtToHousingGapRatio = v53;
                var v54 = _grossBaseIncomeAmount; v54.Clean = value; _grossBaseIncomeAmount = v54;
                var v55 = _grossIncomeForComortSet; v55.Clean = value; _grossIncomeForComortSet = v55;
                var v56 = _grossNegativeCashFlow; v56.Clean = value; _grossNegativeCashFlow = v56;
                var v57 = _grossOtherIncomeAmount; v57.Clean = value; _grossOtherIncomeAmount = v57;
                var v58 = _grossPositiveCashFlow; v58.Clean = value; _grossPositiveCashFlow = v58;
                var v59 = _hazardInsuranceAmount; v59.Clean = value; _hazardInsuranceAmount = v59;
                var v60 = _homeownersAssociationDuesAndCondoFeesAmount; v60.Clean = value; _homeownersAssociationDuesAndCondoFeesAmount = v60;
                var v61 = _hudAutoLienHolderName1; v61.Clean = value; _hudAutoLienHolderName1 = v61;
                var v62 = _hudAutoLienHolderName2; v62.Clean = value; _hudAutoLienHolderName2 = v62;
                var v63 = _hudAutoLoanAmount1; v63.Clean = value; _hudAutoLoanAmount1 = v63;
                var v64 = _hudAutoLoanAmount2; v64.Clean = value; _hudAutoLoanAmount2 = v64;
                var v65 = _hudAutoMonthlyPayment1; v65.Clean = value; _hudAutoMonthlyPayment1 = v65;
                var v66 = _hudAutoMonthlyPayment2; v66.Clean = value; _hudAutoMonthlyPayment2 = v66;
                var v67 = _hudAutoPresentBalance1; v67.Clean = value; _hudAutoPresentBalance1 = v67;
                var v68 = _hudAutoPresentBalance2; v68.Clean = value; _hudAutoPresentBalance2 = v68;
                var v69 = _hudAutoYearAndMake1; v69.Clean = value; _hudAutoYearAndMake1 = v69;
                var v70 = _hudAutoYearAndMake2; v70.Clean = value; _hudAutoYearAndMake2 = v70;
                var v71 = _hudLoanAmount1; v71.Clean = value; _hudLoanAmount1 = v71;
                var v72 = _hudLoanAmount10; v72.Clean = value; _hudLoanAmount10 = v72;
                var v73 = _hudLoanAmount11; v73.Clean = value; _hudLoanAmount11 = v73;
                var v74 = _hudLoanAmount2; v74.Clean = value; _hudLoanAmount2 = v74;
                var v75 = _hudLoanAmount3; v75.Clean = value; _hudLoanAmount3 = v75;
                var v76 = _hudLoanAmount4; v76.Clean = value; _hudLoanAmount4 = v76;
                var v77 = _hudLoanAmount5; v77.Clean = value; _hudLoanAmount5 = v77;
                var v78 = _hudLoanAmount6; v78.Clean = value; _hudLoanAmount6 = v78;
                var v79 = _hudLoanAmount7; v79.Clean = value; _hudLoanAmount7 = v79;
                var v80 = _hudLoanAmount8; v80.Clean = value; _hudLoanAmount8 = v80;
                var v81 = _hudLoanAmount9; v81.Clean = value; _hudLoanAmount9 = v81;
                var v82 = _hudRealEstateFhaInsured1; v82.Clean = value; _hudRealEstateFhaInsured1 = v82;
                var v83 = _hudRealEstateFhaInsured2; v83.Clean = value; _hudRealEstateFhaInsured2 = v83;
                var v84 = _hudRealEstateLienHolder1; v84.Clean = value; _hudRealEstateLienHolder1 = v84;
                var v85 = _hudRealEstateLienHolder2; v85.Clean = value; _hudRealEstateLienHolder2 = v85;
                var v86 = _hudRealEstateLoanAmount1; v86.Clean = value; _hudRealEstateLoanAmount1 = v86;
                var v87 = _hudRealEstateLoanAmount2; v87.Clean = value; _hudRealEstateLoanAmount2 = v87;
                var v88 = _hudRealEstateMonthlyPayment1; v88.Clean = value; _hudRealEstateMonthlyPayment1 = v88;
                var v89 = _hudRealEstateMonthlyPayment2; v89.Clean = value; _hudRealEstateMonthlyPayment2 = v89;
                var v90 = _hudRealEstatePresentBalance1; v90.Clean = value; _hudRealEstatePresentBalance1 = v90;
                var v91 = _hudRealEstatePresentBalance2; v91.Clean = value; _hudRealEstatePresentBalance2 = v91;
                var v92 = _id; v92.Clean = value; _id = v92;
                var v93 = _income; v93.Clean = value; _income = v93;
                var v94 = _incomeOfBorrowersSpouseUsedIndicator; v94.Clean = value; _incomeOfBorrowersSpouseUsedIndicator = v94;
                var v95 = _incomeOtherThanBorrowerUsedIndicator; v95.Clean = value; _incomeOtherThanBorrowerUsedIndicator = v95;
                var v96 = _jointAssetLiabilityReportingIndicator; v96.Clean = value; _jointAssetLiabilityReportingIndicator = v96;
                var v97 = _liabilities; v97.Clean = value; _liabilities = v97;
                var v98 = _liquidAssetsComortSet; v98.Clean = value; _liquidAssetsComortSet = v98;
                var v99 = _mcawBorrowerOtherMonthlyIncomeAmount; v99.Clean = value; _mcawBorrowerOtherMonthlyIncomeAmount = v99;
                var v100 = _mcawCoborrowerOtherMonthlyIncomeAmount; v100.Clean = value; _mcawCoborrowerOtherMonthlyIncomeAmount = v100;
                var v101 = _mcawGrossMonthlyIncomeAmount; v101.Clean = value; _mcawGrossMonthlyIncomeAmount = v101;
                var v102 = _mcawMortgagePaymentToIncome1Amount; v102.Clean = value; _mcawMortgagePaymentToIncome1Amount = v102;
                var v103 = _mcawMortgagePaymentToIncome2Amount; v103.Clean = value; _mcawMortgagePaymentToIncome2Amount = v103;
                var v104 = _mcawOtherAmount; v104.Clean = value; _mcawOtherAmount = v104;
                var v105 = _mcawOtherDebtsAndObligationsAmount; v105.Clean = value; _mcawOtherDebtsAndObligationsAmount = v105;
                var v106 = _mcawTotalFixedPaymentForPurchaseAmount; v106.Clean = value; _mcawTotalFixedPaymentForPurchaseAmount = v106;
                var v107 = _mcawTotalFixedPaymentForRefinanceAmount; v107.Clean = value; _mcawTotalFixedPaymentForRefinanceAmount = v107;
                var v108 = _mcawTotalFixedPaymentToIncome1Amount; v108.Clean = value; _mcawTotalFixedPaymentToIncome1Amount = v108;
                var v109 = _mcawTotalFixedPaymentToIncome2Amount; v109.Clean = value; _mcawTotalFixedPaymentToIncome2Amount = v109;
                var v110 = _mcawTotalMonthlyPaymentsAmount; v110.Clean = value; _mcawTotalMonthlyPaymentsAmount = v110;
                var v111 = _mcawTotalMortgagePaymentAmount; v111.Clean = value; _mcawTotalMortgagePaymentAmount = v111;
                var v112 = _monthlyExpenseComortSet; v112.Clean = value; _monthlyExpenseComortSet = v112;
                var v113 = _monthlyHousingExpenseAmount; v113.Clean = value; _monthlyHousingExpenseAmount = v113;
                var v114 = _monthlyInstallmentExpenseAmount; v114.Clean = value; _monthlyInstallmentExpenseAmount = v114;
                var v115 = _monthlyNegativeRealEstateAmount; v115.Clean = value; _monthlyNegativeRealEstateAmount = v115;
                var v116 = _monthlySecondHomeAmount; v116.Clean = value; _monthlySecondHomeAmount = v116;
                var v117 = _mortgageInsuranceAmount; v117.Clean = value; _mortgageInsuranceAmount = v117;
                var v118 = _netWorthAmount; v118.Clean = value; _netWorthAmount = v118;
                var v119 = _otherHousingExpenseAmount; v119.Clean = value; _otherHousingExpenseAmount = v119;
                var v120 = _otherItemsDeducted; v120.Clean = value; _otherItemsDeducted = v120;
                var v121 = _otherMortgagePrincipalAndInterestAmount; v121.Clean = value; _otherMortgagePrincipalAndInterestAmount = v121;
                var v122 = _pastCreditRecord; v122.Clean = value; _pastCreditRecord = v122;
                var v123 = _presentHousingExpComortSet; v123.Clean = value; _presentHousingExpComortSet = v123;
                var v124 = _primaryResidenceComortSet; v124.Clean = value; _primaryResidenceComortSet = v124;
                var v125 = _propertyUsageType; v125.Clean = value; _propertyUsageType = v125;
                var v126 = _proposedDuesAmount; v126.Clean = value; _proposedDuesAmount = v126;
                var v127 = _proposedFirstMortgageAmount; v127.Clean = value; _proposedFirstMortgageAmount = v127;
                var v128 = _proposedGroundRentAmount; v128.Clean = value; _proposedGroundRentAmount = v128;
                var v129 = _proposedHazardInsuranceAmount; v129.Clean = value; _proposedHazardInsuranceAmount = v129;
                var v130 = _proposedMortgageInsuranceAmount; v130.Clean = value; _proposedMortgageInsuranceAmount = v130;
                var v131 = _proposedOtherAmount; v131.Clean = value; _proposedOtherAmount = v131;
                var v132 = _proposedOtherMortgagesAmount; v132.Clean = value; _proposedOtherMortgagesAmount = v132;
                var v133 = _proposedRealEstateTaxesAmount; v133.Clean = value; _proposedRealEstateTaxesAmount = v133;
                var v134 = _realEstateTaxAmount; v134.Clean = value; _realEstateTaxAmount = v134;
                var v135 = _rentAmount; v135.Clean = value; _rentAmount = v135;
                var v136 = _reoProperties; v136.Clean = value; _reoProperties = v136;
                var v137 = _reoTotalGrossRentalIncomeAmount; v137.Clean = value; _reoTotalGrossRentalIncomeAmount = v137;
                var v138 = _reoTotalMaintenanceAmount; v138.Clean = value; _reoTotalMaintenanceAmount = v138;
                var v139 = _reoTotalMarketValueAmount; v139.Clean = value; _reoTotalMarketValueAmount = v139;
                var v140 = _reoTotalMortgagePaymentsAmount; v140.Clean = value; _reoTotalMortgagePaymentsAmount = v140;
                var v141 = _reoTotalMortgagesAndLiensAmount; v141.Clean = value; _reoTotalMortgagesAndLiensAmount = v141;
                var v142 = _reoTotalNetRentalIncomeAmount; v142.Clean = value; _reoTotalNetRentalIncomeAmount = v142;
                var v143 = _residences; v143.Clean = value; _residences = v143;
                var v144 = _selfEmployedIncomes; v144.Clean = value; _selfEmployedIncomes = v144;
                var v145 = _sofDBorrowerAddress; v145.Clean = value; _sofDBorrowerAddress = v145;
                var v146 = _sofDBorrowerAddressCity; v146.Clean = value; _sofDBorrowerAddressCity = v146;
                var v147 = _sofDBorrowerAddressState; v147.Clean = value; _sofDBorrowerAddressState = v147;
                var v148 = _sofDBorrowerAddressType; v148.Clean = value; _sofDBorrowerAddressType = v148;
                var v149 = _sofDBorrowerAddressZipcode; v149.Clean = value; _sofDBorrowerAddressZipcode = v149;
                var v150 = _sofDCoBorrowerAddress; v150.Clean = value; _sofDCoBorrowerAddress = v150;
                var v151 = _sofDCoBorrowerAddressCity; v151.Clean = value; _sofDCoBorrowerAddressCity = v151;
                var v152 = _sofDCoBorrowerAddressState; v152.Clean = value; _sofDCoBorrowerAddressState = v152;
                var v153 = _sofDCoBorrowerAddressType; v153.Clean = value; _sofDCoBorrowerAddressType = v153;
                var v154 = _sofDCoBorrowerAddressZipcode; v154.Clean = value; _sofDCoBorrowerAddressZipcode = v154;
                var v155 = _spouseIncomeConsider; v155.Clean = value; _spouseIncomeConsider = v155;
                var v156 = _tax4506s; v156.Clean = value; _tax4506s = v156;
                var v157 = _topRatioPercent; v157.Clean = value; _topRatioPercent = v157;
                var v158 = _totalAssetsAmount; v158.Clean = value; _totalAssetsAmount = v158;
                var v159 = _totalBaseIncomeAmount; v159.Clean = value; _totalBaseIncomeAmount = v159;
                var v160 = _totalBonusAmount; v160.Clean = value; _totalBonusAmount = v160;
                var v161 = _totalCommissionsAmount; v161.Clean = value; _totalCommissionsAmount = v161;
                var v162 = _totalDeposit; v162.Clean = value; _totalDeposit = v162;
                var v163 = _totalDividendsInterestAmount; v163.Clean = value; _totalDividendsInterestAmount = v163;
                var v164 = _totalEmploymentAmount; v164.Clean = value; _totalEmploymentAmount = v164;
                var v165 = _totalFixedPaymentAmount; v165.Clean = value; _totalFixedPaymentAmount = v165;
                var v166 = _totalGrossMonthlyIncomeAmount; v166.Clean = value; _totalGrossMonthlyIncomeAmount = v166;
                var v167 = _totalIncomeAmount; v167.Clean = value; _totalIncomeAmount = v167;
                var v168 = _totalMonthlyPaymentAmount; v168.Clean = value; _totalMonthlyPaymentAmount = v168;
                var v169 = _totalMortgagesBalanceAmount; v169.Clean = value; _totalMortgagesBalanceAmount = v169;
                var v170 = _totalMortgagesMonthlyPaymentAmount; v170.Clean = value; _totalMortgagesMonthlyPaymentAmount = v170;
                var v171 = _totalNetRentalIncomeAmount; v171.Clean = value; _totalNetRentalIncomeAmount = v171;
                var v172 = _totalOther1Amount; v172.Clean = value; _totalOther1Amount = v172;
                var v173 = _totalOther2Amount; v173.Clean = value; _totalOther2Amount = v173;
                var v174 = _totalOvertimeAmount; v174.Clean = value; _totalOvertimeAmount = v174;
                var v175 = _totalPaymentsAmount; v175.Clean = value; _totalPaymentsAmount = v175;
                var v176 = _totalPrimaryHousingExpenseAmount; v176.Clean = value; _totalPrimaryHousingExpenseAmount = v176;
                var v177 = _totalReoMarketValueAmount; v177.Clean = value; _totalReoMarketValueAmount = v177;
                var v178 = _totalUserDefinedIncome; v178.Clean = value; _totalUserDefinedIncome = v178;
                var v179 = _tQLReports; v179.Clean = value; _tQLReports = v179;
                var v180 = _transUnionAddress; v180.Clean = value; _transUnionAddress = v180;
                var v181 = _transUnionCity; v181.Clean = value; _transUnionCity = v181;
                var v182 = _transUnionFax; v182.Clean = value; _transUnionFax = v182;
                var v183 = _transUnionModel; v183.Clean = value; _transUnionModel = v183;
                var v184 = _transUnionName; v184.Clean = value; _transUnionName = v184;
                var v185 = _transUnionPhone; v185.Clean = value; _transUnionPhone = v185;
                var v186 = _transUnionPostalCode; v186.Clean = value; _transUnionPostalCode = v186;
                var v187 = _transUnionScoreRangeFrom; v187.Clean = value; _transUnionScoreRangeFrom = v187;
                var v188 = _transUnionScoreRangeTo; v188.Clean = value; _transUnionScoreRangeTo = v188;
                var v189 = _transUnionState; v189.Clean = value; _transUnionState = v189;
                var v190 = _transUnionWebsite; v190.Clean = value; _transUnionWebsite = v190;
                var v191 = _userDefinedIncome; v191.Clean = value; _userDefinedIncome = v191;
                var v192 = _userDefinedIncomeDescription; v192.Clean = value; _userDefinedIncomeDescription = v192;
                var v193 = _vACreditStandards; v193.Clean = value; _vACreditStandards = v193;
                var v194 = _vaSummarySpouseIncomeAmount; v194.Clean = value; _vaSummarySpouseIncomeAmount = v194;
                var v195 = _vaSummaryTotalMonthlyGrossIncomeAmount; v195.Clean = value; _vaSummaryTotalMonthlyGrossIncomeAmount = v195;
                if (ATRQMBorrower != null) ATRQMBorrower.Clean = value;
                if (Borrower != null) Borrower.Clean = value;
                if (Coborrower != null) Coborrower.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}