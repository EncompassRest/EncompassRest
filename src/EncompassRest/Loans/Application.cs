using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Application
    {
        public Value<string> AccountNumber1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountNumber1() => !AccountNumber1.Clean;
        public Value<string> AccountNumber2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountNumber2() => !AccountNumber2.Clean;
        public Value<decimal?> AllOtherPaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllOtherPaymentsAmount() => !AllOtherPaymentsAmount.Clean;
        public Value<string> ApplicationId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationId() => !ApplicationId.Clean;
        public Value<int?> ApplicationIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationIndex() => !ApplicationIndex.Clean;
        public Value<DateTime?> ApplicationSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationSignedDate() => !ApplicationSignedDate.Clean;
        public Value<List<Asset>> Assets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssets() => !Assets.Clean;
        public Value<decimal?> AssetsAvailableAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssetsAvailableAmount() => !AssetsAvailableAmount.Clean;
        public ATRQMBorrower ATRQMBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRQMBorrower() => ATRQMBorrower?.Clean == false;
        public Value<List<ATRQMBorrower>> ATRQMBorrowers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRQMBorrowers() => !ATRQMBorrowers.Clean;
        public Value<List<AUSTrackingLog>> AUSTrackingLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSTrackingLogs() => !AUSTrackingLogs.Clean;
        public Value<decimal?> BalanceAvailableFamilySupportGuideline { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalanceAvailableFamilySupportGuideline() => !BalanceAvailableFamilySupportGuideline.Clean;
        public Borrower Borrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrower() => Borrower?.Clean == false;
        public Value<decimal?> BottomRatioPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBottomRatioPercent() => !BottomRatioPercent.Clean;
        public Value<decimal?> BrwCoBrwTotalTaxDeductions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrwCoBrwTotalTaxDeductions() => !BrwCoBrwTotalTaxDeductions.Clean;
        public Borrower Coborrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrower() => Coborrower?.Clean == false;
        public Value<string> CreditAliasName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditAliasName1() => !CreditAliasName1.Clean;
        public Value<string> CreditAliasName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditAliasName2() => !CreditAliasName2.Clean;
        public Value<string> CreditorName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorName1() => !CreditorName1.Clean;
        public Value<string> CreditorName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorName2() => !CreditorName2.Clean;
        public Value<string> CreditReportReferenceIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportReferenceIdentifier() => !CreditReportReferenceIdentifier.Clean;
        public Value<List<Employment>> Employment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployment() => !Employment.Clean;
        public Value<bool?> EntityDeleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !EntityDeleted.Clean;
        public Value<string> EquifaxAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxAddress() => !EquifaxAddress.Clean;
        public Value<string> EquifaxCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxCity() => !EquifaxCity.Clean;
        public Value<string> EquifaxFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFax() => !EquifaxFax.Clean;
        public Value<string> EquifaxModel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxModel() => !EquifaxModel.Clean;
        public Value<string> EquifaxName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxName() => !EquifaxName.Clean;
        public Value<string> EquifaxPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxPhone() => !EquifaxPhone.Clean;
        public Value<string> EquifaxPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxPostalCode() => !EquifaxPostalCode.Clean;
        public Value<string> EquifaxScoreRangeFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxScoreRangeFrom() => !EquifaxScoreRangeFrom.Clean;
        public Value<string> EquifaxScoreRangeTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxScoreRangeTo() => !EquifaxScoreRangeTo.Clean;
        public Value<string> EquifaxState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxState() => !EquifaxState.Clean;
        public Value<string> EquifaxWebsite { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxWebsite() => !EquifaxWebsite.Clean;
        public Value<string> ExperianAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianAddress() => !ExperianAddress.Clean;
        public Value<string> ExperianCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianCity() => !ExperianCity.Clean;
        public Value<string> ExperianFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFax() => !ExperianFax.Clean;
        public Value<string> ExperianModel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianModel() => !ExperianModel.Clean;
        public Value<string> ExperianName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianName() => !ExperianName.Clean;
        public Value<string> ExperianPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianPhone() => !ExperianPhone.Clean;
        public Value<string> ExperianPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianPostalCode() => !ExperianPostalCode.Clean;
        public Value<string> ExperianScoreRangeFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianScoreRangeFrom() => !ExperianScoreRangeFrom.Clean;
        public Value<string> ExperianScoreRangeTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianScoreRangeTo() => !ExperianScoreRangeTo.Clean;
        public Value<string> ExperianState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianState() => !ExperianState.Clean;
        public Value<string> ExperianWebsite { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianWebsite() => !ExperianWebsite.Clean;
        public Value<decimal?> FhaVaDebtIncomeRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaDebtIncomeRatio() => !FhaVaDebtIncomeRatio.Clean;
        public Value<decimal?> FhaVaFamilySupportAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaFamilySupportAmount() => !FhaVaFamilySupportAmount.Clean;
        public Value<decimal?> FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaTotalEstimatedMonthlyShelterExpenseAmount() => !FhaVaTotalEstimatedMonthlyShelterExpenseAmount.Clean;
        public Value<decimal?> FhaVaTotalNetEffectiveIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaTotalNetEffectiveIncomeAmount() => !FhaVaTotalNetEffectiveIncomeAmount.Clean;
        public Value<decimal?> FhaVaTotalNetIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaTotalNetIncomeAmount() => !FhaVaTotalNetIncomeAmount.Clean;
        public Value<decimal?> FhaVaTotalNetTakeHomePayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaTotalNetTakeHomePayAmount() => !FhaVaTotalNetTakeHomePayAmount.Clean;
        public Value<decimal?> FhaVaTotalOtherNetIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaTotalOtherNetIncome() => !FhaVaTotalOtherNetIncome.Clean;
        public Value<decimal?> FirstMortgagePrincipalAndInterestAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstMortgagePrincipalAndInterestAmount() => !FirstMortgagePrincipalAndInterestAmount.Clean;
        public Value<string> FreddieMacCreditReportReferenceIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacCreditReportReferenceIdentifier() => !FreddieMacCreditReportReferenceIdentifier.Clean;
        public Value<decimal?> FreddieMacOccupantDebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacOccupantDebtRatio() => !FreddieMacOccupantDebtRatio.Clean;
        public Value<decimal?> FreddieMacOccupantHousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacOccupantHousingRatio() => !FreddieMacOccupantHousingRatio.Clean;
        public Value<decimal?> FreDebtToHousingGapRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreDebtToHousingGapRatio() => !FreDebtToHousingGapRatio.Clean;
        public Value<decimal?> GrossBaseIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossBaseIncomeAmount() => !GrossBaseIncomeAmount.Clean;
        public Value<decimal?> GrossIncomeForComortSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossIncomeForComortSet() => !GrossIncomeForComortSet.Clean;
        public Value<decimal?> GrossNegativeCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossNegativeCashFlow() => !GrossNegativeCashFlow.Clean;
        public Value<decimal?> GrossOtherIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossOtherIncomeAmount() => !GrossOtherIncomeAmount.Clean;
        public Value<decimal?> GrossPositiveCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossPositiveCashFlow() => !GrossPositiveCashFlow.Clean;
        public Value<string> HazardInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardInsuranceAmount() => !HazardInsuranceAmount.Clean;
        public Value<string> HomeownersAssociationDuesAndCondoFeesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeownersAssociationDuesAndCondoFeesAmount() => !HomeownersAssociationDuesAndCondoFeesAmount.Clean;
        public Value<string> HudAutoLienHolderName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoLienHolderName1() => !HudAutoLienHolderName1.Clean;
        public Value<string> HudAutoLienHolderName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoLienHolderName2() => !HudAutoLienHolderName2.Clean;
        public Value<decimal?> HudAutoLoanAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoLoanAmount1() => !HudAutoLoanAmount1.Clean;
        public Value<decimal?> HudAutoLoanAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoLoanAmount2() => !HudAutoLoanAmount2.Clean;
        public Value<decimal?> HudAutoMonthlyPayment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoMonthlyPayment1() => !HudAutoMonthlyPayment1.Clean;
        public Value<decimal?> HudAutoMonthlyPayment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoMonthlyPayment2() => !HudAutoMonthlyPayment2.Clean;
        public Value<decimal?> HudAutoPresentBalance1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoPresentBalance1() => !HudAutoPresentBalance1.Clean;
        public Value<decimal?> HudAutoPresentBalance2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoPresentBalance2() => !HudAutoPresentBalance2.Clean;
        public Value<string> HudAutoYearAndMake1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoYearAndMake1() => !HudAutoYearAndMake1.Clean;
        public Value<string> HudAutoYearAndMake2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudAutoYearAndMake2() => !HudAutoYearAndMake2.Clean;
        public Value<decimal?> HudLoanAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount1() => !HudLoanAmount1.Clean;
        public Value<decimal?> HudLoanAmount10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount10() => !HudLoanAmount10.Clean;
        public Value<decimal?> HudLoanAmount11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount11() => !HudLoanAmount11.Clean;
        public Value<decimal?> HudLoanAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount2() => !HudLoanAmount2.Clean;
        public Value<decimal?> HudLoanAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount3() => !HudLoanAmount3.Clean;
        public Value<decimal?> HudLoanAmount4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount4() => !HudLoanAmount4.Clean;
        public Value<decimal?> HudLoanAmount5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount5() => !HudLoanAmount5.Clean;
        public Value<decimal?> HudLoanAmount6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount6() => !HudLoanAmount6.Clean;
        public Value<decimal?> HudLoanAmount7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount7() => !HudLoanAmount7.Clean;
        public Value<decimal?> HudLoanAmount8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount8() => !HudLoanAmount8.Clean;
        public Value<decimal?> HudLoanAmount9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanAmount9() => !HudLoanAmount9.Clean;
        public Value<bool?> HudRealEstateFhaInsured1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateFhaInsured1() => !HudRealEstateFhaInsured1.Clean;
        public Value<bool?> HudRealEstateFhaInsured2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateFhaInsured2() => !HudRealEstateFhaInsured2.Clean;
        public Value<string> HudRealEstateLienHolder1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateLienHolder1() => !HudRealEstateLienHolder1.Clean;
        public Value<string> HudRealEstateLienHolder2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateLienHolder2() => !HudRealEstateLienHolder2.Clean;
        public Value<decimal?> HudRealEstateLoanAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateLoanAmount1() => !HudRealEstateLoanAmount1.Clean;
        public Value<decimal?> HudRealEstateLoanAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateLoanAmount2() => !HudRealEstateLoanAmount2.Clean;
        public Value<decimal?> HudRealEstateMonthlyPayment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateMonthlyPayment1() => !HudRealEstateMonthlyPayment1.Clean;
        public Value<decimal?> HudRealEstateMonthlyPayment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstateMonthlyPayment2() => !HudRealEstateMonthlyPayment2.Clean;
        public Value<decimal?> HudRealEstatePresentBalance1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstatePresentBalance1() => !HudRealEstatePresentBalance1.Clean;
        public Value<decimal?> HudRealEstatePresentBalance2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudRealEstatePresentBalance2() => !HudRealEstatePresentBalance2.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<List<Income>> Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncome() => !Income.Clean;
        public Value<bool?> IncomeOfBorrowersSpouseUsedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncomeOfBorrowersSpouseUsedIndicator() => !IncomeOfBorrowersSpouseUsedIndicator.Clean;
        public Value<bool?> IncomeOtherThanBorrowerUsedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncomeOtherThanBorrowerUsedIndicator() => !IncomeOtherThanBorrowerUsedIndicator.Clean;
        public Value<bool?> JointAssetLiabilityReportingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeJointAssetLiabilityReportingIndicator() => !JointAssetLiabilityReportingIndicator.Clean;
        public Value<List<Liability>> Liabilities { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilities() => !Liabilities.Clean;
        public Value<decimal?> LiquidAssetsComortSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiquidAssetsComortSet() => !LiquidAssetsComortSet.Clean;
        public Value<decimal?> McawBorrowerOtherMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawBorrowerOtherMonthlyIncomeAmount() => !McawBorrowerOtherMonthlyIncomeAmount.Clean;
        public Value<decimal?> McawCoborrowerOtherMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawCoborrowerOtherMonthlyIncomeAmount() => !McawCoborrowerOtherMonthlyIncomeAmount.Clean;
        public Value<decimal?> McawGrossMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawGrossMonthlyIncomeAmount() => !McawGrossMonthlyIncomeAmount.Clean;
        public Value<decimal?> McawMortgagePaymentToIncome1Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawMortgagePaymentToIncome1Amount() => !McawMortgagePaymentToIncome1Amount.Clean;
        public Value<decimal?> McawMortgagePaymentToIncome2Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawMortgagePaymentToIncome2Amount() => !McawMortgagePaymentToIncome2Amount.Clean;
        public Value<decimal?> McawOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawOtherAmount() => !McawOtherAmount.Clean;
        public Value<decimal?> McawOtherDebtsAndObligationsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawOtherDebtsAndObligationsAmount() => !McawOtherDebtsAndObligationsAmount.Clean;
        public Value<decimal?> McawTotalFixedPaymentForPurchaseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalFixedPaymentForPurchaseAmount() => !McawTotalFixedPaymentForPurchaseAmount.Clean;
        public Value<decimal?> McawTotalFixedPaymentForRefinanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalFixedPaymentForRefinanceAmount() => !McawTotalFixedPaymentForRefinanceAmount.Clean;
        public Value<decimal?> McawTotalFixedPaymentToIncome1Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalFixedPaymentToIncome1Amount() => !McawTotalFixedPaymentToIncome1Amount.Clean;
        public Value<decimal?> McawTotalFixedPaymentToIncome2Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalFixedPaymentToIncome2Amount() => !McawTotalFixedPaymentToIncome2Amount.Clean;
        public Value<decimal?> McawTotalMonthlyPaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalMonthlyPaymentsAmount() => !McawTotalMonthlyPaymentsAmount.Clean;
        public Value<decimal?> McawTotalMortgagePaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcawTotalMortgagePaymentAmount() => !McawTotalMortgagePaymentAmount.Clean;
        public Value<decimal?> MonthlyExpenseComortSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyExpenseComortSet() => !MonthlyExpenseComortSet.Clean;
        public Value<decimal?> MonthlyHousingExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyHousingExpenseAmount() => !MonthlyHousingExpenseAmount.Clean;
        public Value<decimal?> MonthlyInstallmentExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyInstallmentExpenseAmount() => !MonthlyInstallmentExpenseAmount.Clean;
        public Value<decimal?> MonthlyNegativeRealEstateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyNegativeRealEstateAmount() => !MonthlyNegativeRealEstateAmount.Clean;
        public Value<decimal?> MonthlySecondHomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlySecondHomeAmount() => !MonthlySecondHomeAmount.Clean;
        public Value<string> MortgageInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceAmount() => !MortgageInsuranceAmount.Clean;
        public Value<decimal?> NetWorthAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetWorthAmount() => !NetWorthAmount.Clean;
        public Value<decimal?> OtherHousingExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherHousingExpenseAmount() => !OtherHousingExpenseAmount.Clean;
        public Value<decimal?> OtherItemsDeducted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherItemsDeducted() => !OtherItemsDeducted.Clean;
        public Value<decimal?> OtherMortgagePrincipalAndInterestAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMortgagePrincipalAndInterestAmount() => !OtherMortgagePrincipalAndInterestAmount.Clean;
        public Value<string> PastCreditRecord { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePastCreditRecord() => !PastCreditRecord.Clean;
        public Value<decimal?> PresentHousingExpComortSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentHousingExpComortSet() => !PresentHousingExpComortSet.Clean;
        public Value<decimal?> PrimaryResidenceComortSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrimaryResidenceComortSet() => !PrimaryResidenceComortSet.Clean;
        public Value<string> PropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !PropertyUsageType.Clean;
        public Value<string> ProposedDuesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedDuesAmount() => !ProposedDuesAmount.Clean;
        public Value<decimal?> ProposedFirstMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedFirstMortgageAmount() => !ProposedFirstMortgageAmount.Clean;
        public Value<decimal?> ProposedGroundRentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedGroundRentAmount() => !ProposedGroundRentAmount.Clean;
        public Value<string> ProposedHazardInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedHazardInsuranceAmount() => !ProposedHazardInsuranceAmount.Clean;
        public Value<string> ProposedMortgageInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMortgageInsuranceAmount() => !ProposedMortgageInsuranceAmount.Clean;
        public Value<decimal?> ProposedOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedOtherAmount() => !ProposedOtherAmount.Clean;
        public Value<decimal?> ProposedOtherMortgagesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedOtherMortgagesAmount() => !ProposedOtherMortgagesAmount.Clean;
        public Value<string> ProposedRealEstateTaxesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedRealEstateTaxesAmount() => !ProposedRealEstateTaxesAmount.Clean;
        public Value<string> RealEstateTaxAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateTaxAmount() => !RealEstateTaxAmount.Clean;
        public Value<decimal?> RentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentAmount() => !RentAmount.Clean;
        public Value<List<ReoProperty>> ReoProperties { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoProperties() => !ReoProperties.Clean;
        public Value<decimal?> ReoTotalGrossRentalIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalGrossRentalIncomeAmount() => !ReoTotalGrossRentalIncomeAmount.Clean;
        public Value<decimal?> ReoTotalMaintenanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalMaintenanceAmount() => !ReoTotalMaintenanceAmount.Clean;
        public Value<decimal?> ReoTotalMarketValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalMarketValueAmount() => !ReoTotalMarketValueAmount.Clean;
        public Value<decimal?> ReoTotalMortgagePaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalMortgagePaymentsAmount() => !ReoTotalMortgagePaymentsAmount.Clean;
        public Value<decimal?> ReoTotalMortgagesAndLiensAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalMortgagesAndLiensAmount() => !ReoTotalMortgagesAndLiensAmount.Clean;
        public Value<int?> ReoTotalNetRentalIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReoTotalNetRentalIncomeAmount() => !ReoTotalNetRentalIncomeAmount.Clean;
        public Value<List<Residence>> Residences { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidences() => !Residences.Clean;
        public Value<List<SelfEmployedIncome>> SelfEmployedIncomes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelfEmployedIncomes() => !SelfEmployedIncomes.Clean;
        public Value<string> SofDBorrowerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDBorrowerAddress() => !SofDBorrowerAddress.Clean;
        public Value<string> SofDBorrowerAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDBorrowerAddressCity() => !SofDBorrowerAddressCity.Clean;
        public Value<string> SofDBorrowerAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDBorrowerAddressState() => !SofDBorrowerAddressState.Clean;
        public Value<string> SofDBorrowerAddressType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDBorrowerAddressType() => !SofDBorrowerAddressType.Clean;
        public Value<string> SofDBorrowerAddressZipcode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDBorrowerAddressZipcode() => !SofDBorrowerAddressZipcode.Clean;
        public Value<string> SofDCoBorrowerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDCoBorrowerAddress() => !SofDCoBorrowerAddress.Clean;
        public Value<string> SofDCoBorrowerAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDCoBorrowerAddressCity() => !SofDCoBorrowerAddressCity.Clean;
        public Value<string> SofDCoBorrowerAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDCoBorrowerAddressState() => !SofDCoBorrowerAddressState.Clean;
        public Value<string> SofDCoBorrowerAddressType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDCoBorrowerAddressType() => !SofDCoBorrowerAddressType.Clean;
        public Value<string> SofDCoBorrowerAddressZipcode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSofDCoBorrowerAddressZipcode() => !SofDCoBorrowerAddressZipcode.Clean;
        public Value<bool?> SpouseIncomeConsider { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpouseIncomeConsider() => !SpouseIncomeConsider.Clean;
        public Value<List<Tax4506>> Tax4506s { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506s() => !Tax4506s.Clean;
        public Value<decimal?> TopRatioPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTopRatioPercent() => !TopRatioPercent.Clean;
        public Value<decimal?> TotalAssetsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAssetsAmount() => !TotalAssetsAmount.Clean;
        public Value<decimal?> TotalBaseIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBaseIncomeAmount() => !TotalBaseIncomeAmount.Clean;
        public Value<decimal?> TotalBonusAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBonusAmount() => !TotalBonusAmount.Clean;
        public Value<decimal?> TotalCommissionsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCommissionsAmount() => !TotalCommissionsAmount.Clean;
        public Value<decimal?> TotalDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDeposit() => !TotalDeposit.Clean;
        public Value<decimal?> TotalDividendsInterestAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDividendsInterestAmount() => !TotalDividendsInterestAmount.Clean;
        public Value<decimal?> TotalEmploymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEmploymentAmount() => !TotalEmploymentAmount.Clean;
        public Value<decimal?> TotalFixedPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFixedPaymentAmount() => !TotalFixedPaymentAmount.Clean;
        public Value<decimal?> TotalGrossMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalGrossMonthlyIncomeAmount() => !TotalGrossMonthlyIncomeAmount.Clean;
        public Value<decimal?> TotalIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncomeAmount() => !TotalIncomeAmount.Clean;
        public Value<decimal?> TotalMonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyPaymentAmount() => !TotalMonthlyPaymentAmount.Clean;
        public Value<decimal?> TotalMortgagesBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgagesBalanceAmount() => !TotalMortgagesBalanceAmount.Clean;
        public Value<decimal?> TotalMortgagesMonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgagesMonthlyPaymentAmount() => !TotalMortgagesMonthlyPaymentAmount.Clean;
        public Value<decimal?> TotalNetRentalIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNetRentalIncomeAmount() => !TotalNetRentalIncomeAmount.Clean;
        public Value<decimal?> TotalOther1Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOther1Amount() => !TotalOther1Amount.Clean;
        public Value<decimal?> TotalOther2Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOther2Amount() => !TotalOther2Amount.Clean;
        public Value<decimal?> TotalOvertimeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOvertimeAmount() => !TotalOvertimeAmount.Clean;
        public Value<decimal?> TotalPaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaymentsAmount() => !TotalPaymentsAmount.Clean;
        public Value<decimal?> TotalPrimaryHousingExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrimaryHousingExpenseAmount() => !TotalPrimaryHousingExpenseAmount.Clean;
        public Value<decimal?> TotalReoMarketValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalReoMarketValueAmount() => !TotalReoMarketValueAmount.Clean;
        public Value<decimal?> TotalUserDefinedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalUserDefinedIncome() => !TotalUserDefinedIncome.Clean;
        public Value<List<TQLReportInformation>> TQLReports { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLReports() => !TQLReports.Clean;
        public Value<string> TransUnionAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionAddress() => !TransUnionAddress.Clean;
        public Value<string> TransUnionCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionCity() => !TransUnionCity.Clean;
        public Value<string> TransUnionFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFax() => !TransUnionFax.Clean;
        public Value<string> TransUnionModel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionModel() => !TransUnionModel.Clean;
        public Value<string> TransUnionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionName() => !TransUnionName.Clean;
        public Value<string> TransUnionPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionPhone() => !TransUnionPhone.Clean;
        public Value<string> TransUnionPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionPostalCode() => !TransUnionPostalCode.Clean;
        public Value<string> TransUnionScoreRangeFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionScoreRangeFrom() => !TransUnionScoreRangeFrom.Clean;
        public Value<string> TransUnionScoreRangeTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionScoreRangeTo() => !TransUnionScoreRangeTo.Clean;
        public Value<string> TransUnionState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionState() => !TransUnionState.Clean;
        public Value<string> TransUnionWebsite { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionWebsite() => !TransUnionWebsite.Clean;
        public Value<decimal?> UserDefinedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedIncome() => !UserDefinedIncome.Clean;
        public Value<string> UserDefinedIncomeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedIncomeDescription() => !UserDefinedIncomeDescription.Clean;
        public Value<string> VACreditStandards { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVACreditStandards() => !VACreditStandards.Clean;
        public Value<decimal?> VaSummarySpouseIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaSummarySpouseIncomeAmount() => !VaSummarySpouseIncomeAmount.Clean;
        public Value<decimal?> VaSummaryTotalMonthlyGrossIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaSummaryTotalMonthlyGrossIncomeAmount() => !VaSummaryTotalMonthlyGrossIncomeAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AccountNumber1.Clean
                    && AccountNumber2.Clean
                    && AllOtherPaymentsAmount.Clean
                    && ApplicationId.Clean
                    && ApplicationIndex.Clean
                    && ApplicationSignedDate.Clean
                    && Assets.Clean
                    && AssetsAvailableAmount.Clean
                    && ATRQMBorrowers.Clean
                    && AUSTrackingLogs.Clean
                    && BalanceAvailableFamilySupportGuideline.Clean
                    && BottomRatioPercent.Clean
                    && BrwCoBrwTotalTaxDeductions.Clean
                    && CreditAliasName1.Clean
                    && CreditAliasName2.Clean
                    && CreditorName1.Clean
                    && CreditorName2.Clean
                    && CreditReportReferenceIdentifier.Clean
                    && Employment.Clean
                    && EntityDeleted.Clean
                    && EquifaxAddress.Clean
                    && EquifaxCity.Clean
                    && EquifaxFax.Clean
                    && EquifaxModel.Clean
                    && EquifaxName.Clean
                    && EquifaxPhone.Clean
                    && EquifaxPostalCode.Clean
                    && EquifaxScoreRangeFrom.Clean
                    && EquifaxScoreRangeTo.Clean
                    && EquifaxState.Clean
                    && EquifaxWebsite.Clean
                    && ExperianAddress.Clean
                    && ExperianCity.Clean
                    && ExperianFax.Clean
                    && ExperianModel.Clean
                    && ExperianName.Clean
                    && ExperianPhone.Clean
                    && ExperianPostalCode.Clean
                    && ExperianScoreRangeFrom.Clean
                    && ExperianScoreRangeTo.Clean
                    && ExperianState.Clean
                    && ExperianWebsite.Clean
                    && FhaVaDebtIncomeRatio.Clean
                    && FhaVaFamilySupportAmount.Clean
                    && FhaVaTotalEstimatedMonthlyShelterExpenseAmount.Clean
                    && FhaVaTotalNetEffectiveIncomeAmount.Clean
                    && FhaVaTotalNetIncomeAmount.Clean
                    && FhaVaTotalNetTakeHomePayAmount.Clean
                    && FhaVaTotalOtherNetIncome.Clean
                    && FirstMortgagePrincipalAndInterestAmount.Clean
                    && FreddieMacCreditReportReferenceIdentifier.Clean
                    && FreddieMacOccupantDebtRatio.Clean
                    && FreddieMacOccupantHousingRatio.Clean
                    && FreDebtToHousingGapRatio.Clean
                    && GrossBaseIncomeAmount.Clean
                    && GrossIncomeForComortSet.Clean
                    && GrossNegativeCashFlow.Clean
                    && GrossOtherIncomeAmount.Clean
                    && GrossPositiveCashFlow.Clean
                    && HazardInsuranceAmount.Clean
                    && HomeownersAssociationDuesAndCondoFeesAmount.Clean
                    && HudAutoLienHolderName1.Clean
                    && HudAutoLienHolderName2.Clean
                    && HudAutoLoanAmount1.Clean
                    && HudAutoLoanAmount2.Clean
                    && HudAutoMonthlyPayment1.Clean
                    && HudAutoMonthlyPayment2.Clean
                    && HudAutoPresentBalance1.Clean
                    && HudAutoPresentBalance2.Clean
                    && HudAutoYearAndMake1.Clean
                    && HudAutoYearAndMake2.Clean
                    && HudLoanAmount1.Clean
                    && HudLoanAmount10.Clean
                    && HudLoanAmount11.Clean
                    && HudLoanAmount2.Clean
                    && HudLoanAmount3.Clean
                    && HudLoanAmount4.Clean
                    && HudLoanAmount5.Clean
                    && HudLoanAmount6.Clean
                    && HudLoanAmount7.Clean
                    && HudLoanAmount8.Clean
                    && HudLoanAmount9.Clean
                    && HudRealEstateFhaInsured1.Clean
                    && HudRealEstateFhaInsured2.Clean
                    && HudRealEstateLienHolder1.Clean
                    && HudRealEstateLienHolder2.Clean
                    && HudRealEstateLoanAmount1.Clean
                    && HudRealEstateLoanAmount2.Clean
                    && HudRealEstateMonthlyPayment1.Clean
                    && HudRealEstateMonthlyPayment2.Clean
                    && HudRealEstatePresentBalance1.Clean
                    && HudRealEstatePresentBalance2.Clean
                    && Id.Clean
                    && Income.Clean
                    && IncomeOfBorrowersSpouseUsedIndicator.Clean
                    && IncomeOtherThanBorrowerUsedIndicator.Clean
                    && JointAssetLiabilityReportingIndicator.Clean
                    && Liabilities.Clean
                    && LiquidAssetsComortSet.Clean
                    && McawBorrowerOtherMonthlyIncomeAmount.Clean
                    && McawCoborrowerOtherMonthlyIncomeAmount.Clean
                    && McawGrossMonthlyIncomeAmount.Clean
                    && McawMortgagePaymentToIncome1Amount.Clean
                    && McawMortgagePaymentToIncome2Amount.Clean
                    && McawOtherAmount.Clean
                    && McawOtherDebtsAndObligationsAmount.Clean
                    && McawTotalFixedPaymentForPurchaseAmount.Clean
                    && McawTotalFixedPaymentForRefinanceAmount.Clean
                    && McawTotalFixedPaymentToIncome1Amount.Clean
                    && McawTotalFixedPaymentToIncome2Amount.Clean
                    && McawTotalMonthlyPaymentsAmount.Clean
                    && McawTotalMortgagePaymentAmount.Clean
                    && MonthlyExpenseComortSet.Clean
                    && MonthlyHousingExpenseAmount.Clean
                    && MonthlyInstallmentExpenseAmount.Clean
                    && MonthlyNegativeRealEstateAmount.Clean
                    && MonthlySecondHomeAmount.Clean
                    && MortgageInsuranceAmount.Clean
                    && NetWorthAmount.Clean
                    && OtherHousingExpenseAmount.Clean
                    && OtherItemsDeducted.Clean
                    && OtherMortgagePrincipalAndInterestAmount.Clean
                    && PastCreditRecord.Clean
                    && PresentHousingExpComortSet.Clean
                    && PrimaryResidenceComortSet.Clean
                    && PropertyUsageType.Clean
                    && ProposedDuesAmount.Clean
                    && ProposedFirstMortgageAmount.Clean
                    && ProposedGroundRentAmount.Clean
                    && ProposedHazardInsuranceAmount.Clean
                    && ProposedMortgageInsuranceAmount.Clean
                    && ProposedOtherAmount.Clean
                    && ProposedOtherMortgagesAmount.Clean
                    && ProposedRealEstateTaxesAmount.Clean
                    && RealEstateTaxAmount.Clean
                    && RentAmount.Clean
                    && ReoProperties.Clean
                    && ReoTotalGrossRentalIncomeAmount.Clean
                    && ReoTotalMaintenanceAmount.Clean
                    && ReoTotalMarketValueAmount.Clean
                    && ReoTotalMortgagePaymentsAmount.Clean
                    && ReoTotalMortgagesAndLiensAmount.Clean
                    && ReoTotalNetRentalIncomeAmount.Clean
                    && Residences.Clean
                    && SelfEmployedIncomes.Clean
                    && SofDBorrowerAddress.Clean
                    && SofDBorrowerAddressCity.Clean
                    && SofDBorrowerAddressState.Clean
                    && SofDBorrowerAddressType.Clean
                    && SofDBorrowerAddressZipcode.Clean
                    && SofDCoBorrowerAddress.Clean
                    && SofDCoBorrowerAddressCity.Clean
                    && SofDCoBorrowerAddressState.Clean
                    && SofDCoBorrowerAddressType.Clean
                    && SofDCoBorrowerAddressZipcode.Clean
                    && SpouseIncomeConsider.Clean
                    && Tax4506s.Clean
                    && TopRatioPercent.Clean
                    && TotalAssetsAmount.Clean
                    && TotalBaseIncomeAmount.Clean
                    && TotalBonusAmount.Clean
                    && TotalCommissionsAmount.Clean
                    && TotalDeposit.Clean
                    && TotalDividendsInterestAmount.Clean
                    && TotalEmploymentAmount.Clean
                    && TotalFixedPaymentAmount.Clean
                    && TotalGrossMonthlyIncomeAmount.Clean
                    && TotalIncomeAmount.Clean
                    && TotalMonthlyPaymentAmount.Clean
                    && TotalMortgagesBalanceAmount.Clean
                    && TotalMortgagesMonthlyPaymentAmount.Clean
                    && TotalNetRentalIncomeAmount.Clean
                    && TotalOther1Amount.Clean
                    && TotalOther2Amount.Clean
                    && TotalOvertimeAmount.Clean
                    && TotalPaymentsAmount.Clean
                    && TotalPrimaryHousingExpenseAmount.Clean
                    && TotalReoMarketValueAmount.Clean
                    && TotalUserDefinedIncome.Clean
                    && TQLReports.Clean
                    && TransUnionAddress.Clean
                    && TransUnionCity.Clean
                    && TransUnionFax.Clean
                    && TransUnionModel.Clean
                    && TransUnionName.Clean
                    && TransUnionPhone.Clean
                    && TransUnionPostalCode.Clean
                    && TransUnionScoreRangeFrom.Clean
                    && TransUnionScoreRangeTo.Clean
                    && TransUnionState.Clean
                    && TransUnionWebsite.Clean
                    && UserDefinedIncome.Clean
                    && UserDefinedIncomeDescription.Clean
                    && VACreditStandards.Clean
                    && VaSummarySpouseIncomeAmount.Clean
                    && VaSummaryTotalMonthlyGrossIncomeAmount.Clean
                    && ATRQMBorrower.Clean
                    && Borrower.Clean
                    && Coborrower.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountNumber1; v0.Clean = value; AccountNumber1 = v0;
                var v1 = AccountNumber2; v1.Clean = value; AccountNumber2 = v1;
                var v2 = AllOtherPaymentsAmount; v2.Clean = value; AllOtherPaymentsAmount = v2;
                var v3 = ApplicationId; v3.Clean = value; ApplicationId = v3;
                var v4 = ApplicationIndex; v4.Clean = value; ApplicationIndex = v4;
                var v5 = ApplicationSignedDate; v5.Clean = value; ApplicationSignedDate = v5;
                var v6 = Assets; v6.Clean = value; Assets = v6;
                var v7 = AssetsAvailableAmount; v7.Clean = value; AssetsAvailableAmount = v7;
                var v8 = ATRQMBorrowers; v8.Clean = value; ATRQMBorrowers = v8;
                var v9 = AUSTrackingLogs; v9.Clean = value; AUSTrackingLogs = v9;
                var v10 = BalanceAvailableFamilySupportGuideline; v10.Clean = value; BalanceAvailableFamilySupportGuideline = v10;
                var v11 = BottomRatioPercent; v11.Clean = value; BottomRatioPercent = v11;
                var v12 = BrwCoBrwTotalTaxDeductions; v12.Clean = value; BrwCoBrwTotalTaxDeductions = v12;
                var v13 = CreditAliasName1; v13.Clean = value; CreditAliasName1 = v13;
                var v14 = CreditAliasName2; v14.Clean = value; CreditAliasName2 = v14;
                var v15 = CreditorName1; v15.Clean = value; CreditorName1 = v15;
                var v16 = CreditorName2; v16.Clean = value; CreditorName2 = v16;
                var v17 = CreditReportReferenceIdentifier; v17.Clean = value; CreditReportReferenceIdentifier = v17;
                var v18 = Employment; v18.Clean = value; Employment = v18;
                var v19 = EntityDeleted; v19.Clean = value; EntityDeleted = v19;
                var v20 = EquifaxAddress; v20.Clean = value; EquifaxAddress = v20;
                var v21 = EquifaxCity; v21.Clean = value; EquifaxCity = v21;
                var v22 = EquifaxFax; v22.Clean = value; EquifaxFax = v22;
                var v23 = EquifaxModel; v23.Clean = value; EquifaxModel = v23;
                var v24 = EquifaxName; v24.Clean = value; EquifaxName = v24;
                var v25 = EquifaxPhone; v25.Clean = value; EquifaxPhone = v25;
                var v26 = EquifaxPostalCode; v26.Clean = value; EquifaxPostalCode = v26;
                var v27 = EquifaxScoreRangeFrom; v27.Clean = value; EquifaxScoreRangeFrom = v27;
                var v28 = EquifaxScoreRangeTo; v28.Clean = value; EquifaxScoreRangeTo = v28;
                var v29 = EquifaxState; v29.Clean = value; EquifaxState = v29;
                var v30 = EquifaxWebsite; v30.Clean = value; EquifaxWebsite = v30;
                var v31 = ExperianAddress; v31.Clean = value; ExperianAddress = v31;
                var v32 = ExperianCity; v32.Clean = value; ExperianCity = v32;
                var v33 = ExperianFax; v33.Clean = value; ExperianFax = v33;
                var v34 = ExperianModel; v34.Clean = value; ExperianModel = v34;
                var v35 = ExperianName; v35.Clean = value; ExperianName = v35;
                var v36 = ExperianPhone; v36.Clean = value; ExperianPhone = v36;
                var v37 = ExperianPostalCode; v37.Clean = value; ExperianPostalCode = v37;
                var v38 = ExperianScoreRangeFrom; v38.Clean = value; ExperianScoreRangeFrom = v38;
                var v39 = ExperianScoreRangeTo; v39.Clean = value; ExperianScoreRangeTo = v39;
                var v40 = ExperianState; v40.Clean = value; ExperianState = v40;
                var v41 = ExperianWebsite; v41.Clean = value; ExperianWebsite = v41;
                var v42 = FhaVaDebtIncomeRatio; v42.Clean = value; FhaVaDebtIncomeRatio = v42;
                var v43 = FhaVaFamilySupportAmount; v43.Clean = value; FhaVaFamilySupportAmount = v43;
                var v44 = FhaVaTotalEstimatedMonthlyShelterExpenseAmount; v44.Clean = value; FhaVaTotalEstimatedMonthlyShelterExpenseAmount = v44;
                var v45 = FhaVaTotalNetEffectiveIncomeAmount; v45.Clean = value; FhaVaTotalNetEffectiveIncomeAmount = v45;
                var v46 = FhaVaTotalNetIncomeAmount; v46.Clean = value; FhaVaTotalNetIncomeAmount = v46;
                var v47 = FhaVaTotalNetTakeHomePayAmount; v47.Clean = value; FhaVaTotalNetTakeHomePayAmount = v47;
                var v48 = FhaVaTotalOtherNetIncome; v48.Clean = value; FhaVaTotalOtherNetIncome = v48;
                var v49 = FirstMortgagePrincipalAndInterestAmount; v49.Clean = value; FirstMortgagePrincipalAndInterestAmount = v49;
                var v50 = FreddieMacCreditReportReferenceIdentifier; v50.Clean = value; FreddieMacCreditReportReferenceIdentifier = v50;
                var v51 = FreddieMacOccupantDebtRatio; v51.Clean = value; FreddieMacOccupantDebtRatio = v51;
                var v52 = FreddieMacOccupantHousingRatio; v52.Clean = value; FreddieMacOccupantHousingRatio = v52;
                var v53 = FreDebtToHousingGapRatio; v53.Clean = value; FreDebtToHousingGapRatio = v53;
                var v54 = GrossBaseIncomeAmount; v54.Clean = value; GrossBaseIncomeAmount = v54;
                var v55 = GrossIncomeForComortSet; v55.Clean = value; GrossIncomeForComortSet = v55;
                var v56 = GrossNegativeCashFlow; v56.Clean = value; GrossNegativeCashFlow = v56;
                var v57 = GrossOtherIncomeAmount; v57.Clean = value; GrossOtherIncomeAmount = v57;
                var v58 = GrossPositiveCashFlow; v58.Clean = value; GrossPositiveCashFlow = v58;
                var v59 = HazardInsuranceAmount; v59.Clean = value; HazardInsuranceAmount = v59;
                var v60 = HomeownersAssociationDuesAndCondoFeesAmount; v60.Clean = value; HomeownersAssociationDuesAndCondoFeesAmount = v60;
                var v61 = HudAutoLienHolderName1; v61.Clean = value; HudAutoLienHolderName1 = v61;
                var v62 = HudAutoLienHolderName2; v62.Clean = value; HudAutoLienHolderName2 = v62;
                var v63 = HudAutoLoanAmount1; v63.Clean = value; HudAutoLoanAmount1 = v63;
                var v64 = HudAutoLoanAmount2; v64.Clean = value; HudAutoLoanAmount2 = v64;
                var v65 = HudAutoMonthlyPayment1; v65.Clean = value; HudAutoMonthlyPayment1 = v65;
                var v66 = HudAutoMonthlyPayment2; v66.Clean = value; HudAutoMonthlyPayment2 = v66;
                var v67 = HudAutoPresentBalance1; v67.Clean = value; HudAutoPresentBalance1 = v67;
                var v68 = HudAutoPresentBalance2; v68.Clean = value; HudAutoPresentBalance2 = v68;
                var v69 = HudAutoYearAndMake1; v69.Clean = value; HudAutoYearAndMake1 = v69;
                var v70 = HudAutoYearAndMake2; v70.Clean = value; HudAutoYearAndMake2 = v70;
                var v71 = HudLoanAmount1; v71.Clean = value; HudLoanAmount1 = v71;
                var v72 = HudLoanAmount10; v72.Clean = value; HudLoanAmount10 = v72;
                var v73 = HudLoanAmount11; v73.Clean = value; HudLoanAmount11 = v73;
                var v74 = HudLoanAmount2; v74.Clean = value; HudLoanAmount2 = v74;
                var v75 = HudLoanAmount3; v75.Clean = value; HudLoanAmount3 = v75;
                var v76 = HudLoanAmount4; v76.Clean = value; HudLoanAmount4 = v76;
                var v77 = HudLoanAmount5; v77.Clean = value; HudLoanAmount5 = v77;
                var v78 = HudLoanAmount6; v78.Clean = value; HudLoanAmount6 = v78;
                var v79 = HudLoanAmount7; v79.Clean = value; HudLoanAmount7 = v79;
                var v80 = HudLoanAmount8; v80.Clean = value; HudLoanAmount8 = v80;
                var v81 = HudLoanAmount9; v81.Clean = value; HudLoanAmount9 = v81;
                var v82 = HudRealEstateFhaInsured1; v82.Clean = value; HudRealEstateFhaInsured1 = v82;
                var v83 = HudRealEstateFhaInsured2; v83.Clean = value; HudRealEstateFhaInsured2 = v83;
                var v84 = HudRealEstateLienHolder1; v84.Clean = value; HudRealEstateLienHolder1 = v84;
                var v85 = HudRealEstateLienHolder2; v85.Clean = value; HudRealEstateLienHolder2 = v85;
                var v86 = HudRealEstateLoanAmount1; v86.Clean = value; HudRealEstateLoanAmount1 = v86;
                var v87 = HudRealEstateLoanAmount2; v87.Clean = value; HudRealEstateLoanAmount2 = v87;
                var v88 = HudRealEstateMonthlyPayment1; v88.Clean = value; HudRealEstateMonthlyPayment1 = v88;
                var v89 = HudRealEstateMonthlyPayment2; v89.Clean = value; HudRealEstateMonthlyPayment2 = v89;
                var v90 = HudRealEstatePresentBalance1; v90.Clean = value; HudRealEstatePresentBalance1 = v90;
                var v91 = HudRealEstatePresentBalance2; v91.Clean = value; HudRealEstatePresentBalance2 = v91;
                var v92 = Id; v92.Clean = value; Id = v92;
                var v93 = Income; v93.Clean = value; Income = v93;
                var v94 = IncomeOfBorrowersSpouseUsedIndicator; v94.Clean = value; IncomeOfBorrowersSpouseUsedIndicator = v94;
                var v95 = IncomeOtherThanBorrowerUsedIndicator; v95.Clean = value; IncomeOtherThanBorrowerUsedIndicator = v95;
                var v96 = JointAssetLiabilityReportingIndicator; v96.Clean = value; JointAssetLiabilityReportingIndicator = v96;
                var v97 = Liabilities; v97.Clean = value; Liabilities = v97;
                var v98 = LiquidAssetsComortSet; v98.Clean = value; LiquidAssetsComortSet = v98;
                var v99 = McawBorrowerOtherMonthlyIncomeAmount; v99.Clean = value; McawBorrowerOtherMonthlyIncomeAmount = v99;
                var v100 = McawCoborrowerOtherMonthlyIncomeAmount; v100.Clean = value; McawCoborrowerOtherMonthlyIncomeAmount = v100;
                var v101 = McawGrossMonthlyIncomeAmount; v101.Clean = value; McawGrossMonthlyIncomeAmount = v101;
                var v102 = McawMortgagePaymentToIncome1Amount; v102.Clean = value; McawMortgagePaymentToIncome1Amount = v102;
                var v103 = McawMortgagePaymentToIncome2Amount; v103.Clean = value; McawMortgagePaymentToIncome2Amount = v103;
                var v104 = McawOtherAmount; v104.Clean = value; McawOtherAmount = v104;
                var v105 = McawOtherDebtsAndObligationsAmount; v105.Clean = value; McawOtherDebtsAndObligationsAmount = v105;
                var v106 = McawTotalFixedPaymentForPurchaseAmount; v106.Clean = value; McawTotalFixedPaymentForPurchaseAmount = v106;
                var v107 = McawTotalFixedPaymentForRefinanceAmount; v107.Clean = value; McawTotalFixedPaymentForRefinanceAmount = v107;
                var v108 = McawTotalFixedPaymentToIncome1Amount; v108.Clean = value; McawTotalFixedPaymentToIncome1Amount = v108;
                var v109 = McawTotalFixedPaymentToIncome2Amount; v109.Clean = value; McawTotalFixedPaymentToIncome2Amount = v109;
                var v110 = McawTotalMonthlyPaymentsAmount; v110.Clean = value; McawTotalMonthlyPaymentsAmount = v110;
                var v111 = McawTotalMortgagePaymentAmount; v111.Clean = value; McawTotalMortgagePaymentAmount = v111;
                var v112 = MonthlyExpenseComortSet; v112.Clean = value; MonthlyExpenseComortSet = v112;
                var v113 = MonthlyHousingExpenseAmount; v113.Clean = value; MonthlyHousingExpenseAmount = v113;
                var v114 = MonthlyInstallmentExpenseAmount; v114.Clean = value; MonthlyInstallmentExpenseAmount = v114;
                var v115 = MonthlyNegativeRealEstateAmount; v115.Clean = value; MonthlyNegativeRealEstateAmount = v115;
                var v116 = MonthlySecondHomeAmount; v116.Clean = value; MonthlySecondHomeAmount = v116;
                var v117 = MortgageInsuranceAmount; v117.Clean = value; MortgageInsuranceAmount = v117;
                var v118 = NetWorthAmount; v118.Clean = value; NetWorthAmount = v118;
                var v119 = OtherHousingExpenseAmount; v119.Clean = value; OtherHousingExpenseAmount = v119;
                var v120 = OtherItemsDeducted; v120.Clean = value; OtherItemsDeducted = v120;
                var v121 = OtherMortgagePrincipalAndInterestAmount; v121.Clean = value; OtherMortgagePrincipalAndInterestAmount = v121;
                var v122 = PastCreditRecord; v122.Clean = value; PastCreditRecord = v122;
                var v123 = PresentHousingExpComortSet; v123.Clean = value; PresentHousingExpComortSet = v123;
                var v124 = PrimaryResidenceComortSet; v124.Clean = value; PrimaryResidenceComortSet = v124;
                var v125 = PropertyUsageType; v125.Clean = value; PropertyUsageType = v125;
                var v126 = ProposedDuesAmount; v126.Clean = value; ProposedDuesAmount = v126;
                var v127 = ProposedFirstMortgageAmount; v127.Clean = value; ProposedFirstMortgageAmount = v127;
                var v128 = ProposedGroundRentAmount; v128.Clean = value; ProposedGroundRentAmount = v128;
                var v129 = ProposedHazardInsuranceAmount; v129.Clean = value; ProposedHazardInsuranceAmount = v129;
                var v130 = ProposedMortgageInsuranceAmount; v130.Clean = value; ProposedMortgageInsuranceAmount = v130;
                var v131 = ProposedOtherAmount; v131.Clean = value; ProposedOtherAmount = v131;
                var v132 = ProposedOtherMortgagesAmount; v132.Clean = value; ProposedOtherMortgagesAmount = v132;
                var v133 = ProposedRealEstateTaxesAmount; v133.Clean = value; ProposedRealEstateTaxesAmount = v133;
                var v134 = RealEstateTaxAmount; v134.Clean = value; RealEstateTaxAmount = v134;
                var v135 = RentAmount; v135.Clean = value; RentAmount = v135;
                var v136 = ReoProperties; v136.Clean = value; ReoProperties = v136;
                var v137 = ReoTotalGrossRentalIncomeAmount; v137.Clean = value; ReoTotalGrossRentalIncomeAmount = v137;
                var v138 = ReoTotalMaintenanceAmount; v138.Clean = value; ReoTotalMaintenanceAmount = v138;
                var v139 = ReoTotalMarketValueAmount; v139.Clean = value; ReoTotalMarketValueAmount = v139;
                var v140 = ReoTotalMortgagePaymentsAmount; v140.Clean = value; ReoTotalMortgagePaymentsAmount = v140;
                var v141 = ReoTotalMortgagesAndLiensAmount; v141.Clean = value; ReoTotalMortgagesAndLiensAmount = v141;
                var v142 = ReoTotalNetRentalIncomeAmount; v142.Clean = value; ReoTotalNetRentalIncomeAmount = v142;
                var v143 = Residences; v143.Clean = value; Residences = v143;
                var v144 = SelfEmployedIncomes; v144.Clean = value; SelfEmployedIncomes = v144;
                var v145 = SofDBorrowerAddress; v145.Clean = value; SofDBorrowerAddress = v145;
                var v146 = SofDBorrowerAddressCity; v146.Clean = value; SofDBorrowerAddressCity = v146;
                var v147 = SofDBorrowerAddressState; v147.Clean = value; SofDBorrowerAddressState = v147;
                var v148 = SofDBorrowerAddressType; v148.Clean = value; SofDBorrowerAddressType = v148;
                var v149 = SofDBorrowerAddressZipcode; v149.Clean = value; SofDBorrowerAddressZipcode = v149;
                var v150 = SofDCoBorrowerAddress; v150.Clean = value; SofDCoBorrowerAddress = v150;
                var v151 = SofDCoBorrowerAddressCity; v151.Clean = value; SofDCoBorrowerAddressCity = v151;
                var v152 = SofDCoBorrowerAddressState; v152.Clean = value; SofDCoBorrowerAddressState = v152;
                var v153 = SofDCoBorrowerAddressType; v153.Clean = value; SofDCoBorrowerAddressType = v153;
                var v154 = SofDCoBorrowerAddressZipcode; v154.Clean = value; SofDCoBorrowerAddressZipcode = v154;
                var v155 = SpouseIncomeConsider; v155.Clean = value; SpouseIncomeConsider = v155;
                var v156 = Tax4506s; v156.Clean = value; Tax4506s = v156;
                var v157 = TopRatioPercent; v157.Clean = value; TopRatioPercent = v157;
                var v158 = TotalAssetsAmount; v158.Clean = value; TotalAssetsAmount = v158;
                var v159 = TotalBaseIncomeAmount; v159.Clean = value; TotalBaseIncomeAmount = v159;
                var v160 = TotalBonusAmount; v160.Clean = value; TotalBonusAmount = v160;
                var v161 = TotalCommissionsAmount; v161.Clean = value; TotalCommissionsAmount = v161;
                var v162 = TotalDeposit; v162.Clean = value; TotalDeposit = v162;
                var v163 = TotalDividendsInterestAmount; v163.Clean = value; TotalDividendsInterestAmount = v163;
                var v164 = TotalEmploymentAmount; v164.Clean = value; TotalEmploymentAmount = v164;
                var v165 = TotalFixedPaymentAmount; v165.Clean = value; TotalFixedPaymentAmount = v165;
                var v166 = TotalGrossMonthlyIncomeAmount; v166.Clean = value; TotalGrossMonthlyIncomeAmount = v166;
                var v167 = TotalIncomeAmount; v167.Clean = value; TotalIncomeAmount = v167;
                var v168 = TotalMonthlyPaymentAmount; v168.Clean = value; TotalMonthlyPaymentAmount = v168;
                var v169 = TotalMortgagesBalanceAmount; v169.Clean = value; TotalMortgagesBalanceAmount = v169;
                var v170 = TotalMortgagesMonthlyPaymentAmount; v170.Clean = value; TotalMortgagesMonthlyPaymentAmount = v170;
                var v171 = TotalNetRentalIncomeAmount; v171.Clean = value; TotalNetRentalIncomeAmount = v171;
                var v172 = TotalOther1Amount; v172.Clean = value; TotalOther1Amount = v172;
                var v173 = TotalOther2Amount; v173.Clean = value; TotalOther2Amount = v173;
                var v174 = TotalOvertimeAmount; v174.Clean = value; TotalOvertimeAmount = v174;
                var v175 = TotalPaymentsAmount; v175.Clean = value; TotalPaymentsAmount = v175;
                var v176 = TotalPrimaryHousingExpenseAmount; v176.Clean = value; TotalPrimaryHousingExpenseAmount = v176;
                var v177 = TotalReoMarketValueAmount; v177.Clean = value; TotalReoMarketValueAmount = v177;
                var v178 = TotalUserDefinedIncome; v178.Clean = value; TotalUserDefinedIncome = v178;
                var v179 = TQLReports; v179.Clean = value; TQLReports = v179;
                var v180 = TransUnionAddress; v180.Clean = value; TransUnionAddress = v180;
                var v181 = TransUnionCity; v181.Clean = value; TransUnionCity = v181;
                var v182 = TransUnionFax; v182.Clean = value; TransUnionFax = v182;
                var v183 = TransUnionModel; v183.Clean = value; TransUnionModel = v183;
                var v184 = TransUnionName; v184.Clean = value; TransUnionName = v184;
                var v185 = TransUnionPhone; v185.Clean = value; TransUnionPhone = v185;
                var v186 = TransUnionPostalCode; v186.Clean = value; TransUnionPostalCode = v186;
                var v187 = TransUnionScoreRangeFrom; v187.Clean = value; TransUnionScoreRangeFrom = v187;
                var v188 = TransUnionScoreRangeTo; v188.Clean = value; TransUnionScoreRangeTo = v188;
                var v189 = TransUnionState; v189.Clean = value; TransUnionState = v189;
                var v190 = TransUnionWebsite; v190.Clean = value; TransUnionWebsite = v190;
                var v191 = UserDefinedIncome; v191.Clean = value; UserDefinedIncome = v191;
                var v192 = UserDefinedIncomeDescription; v192.Clean = value; UserDefinedIncomeDescription = v192;
                var v193 = VACreditStandards; v193.Clean = value; VACreditStandards = v193;
                var v194 = VaSummarySpouseIncomeAmount; v194.Clean = value; VaSummarySpouseIncomeAmount = v194;
                var v195 = VaSummaryTotalMonthlyGrossIncomeAmount; v195.Clean = value; VaSummaryTotalMonthlyGrossIncomeAmount = v195;
                if (ATRQMBorrower != null) ATRQMBorrower.Clean = value;
                if (Borrower != null) Borrower.Clean = value;
                if (Coborrower != null) Coborrower.Clean = value;
                _settingClean = 0;
            }
        }
    }
}