using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HudLoanData
    {
        public Value<decimal?> ActualCashInvRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualCashInvRequired() => !ActualCashInvRequired.Clean;
        public Value<decimal?> AdjustedMaxMtgAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedMaxMtgAmount() => !AdjustedMaxMtgAmount.Clean;
        public Value<decimal?> AfterImprovedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterImprovedValue() => !AfterImprovedValue.Clean;
        public Value<decimal?> AfterImprovedValueAfter20Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterImprovedValueAfter20Percent() => !AfterImprovedValueAfter20Percent.Clean;
        public Value<decimal?> AllowableEnergyImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowableEnergyImprovements() => !AllowableEnergyImprovements.Clean;
        public Value<decimal?> AppropriateLTVFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppropriateLTVFactor() => !AppropriateLTVFactor.Clean;
        public Value<decimal?> ArchitecturalEngineeringFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchitecturalEngineeringFee() => !ArchitecturalEngineeringFee.Clean;
        public Value<decimal?> AsIsValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsIsValue() => !AsIsValue.Clean;
        public Value<decimal?> BaseMortgageAmountFrom3COr3D { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseMortgageAmountFrom3COr3D() => !BaseMortgageAmountFrom3COr3D.Clean;
        public Value<string> BorrowerAcknowledgement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerAcknowledgement() => !BorrowerAcknowledgement.Clean;
        public Value<decimal?> BorrowerEstimatedProfit1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerEstimatedProfit1() => !BorrowerEstimatedProfit1.Clean;
        public Value<decimal?> BorrowerEstimatedProfit2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerEstimatedProfit2() => !BorrowerEstimatedProfit2.Clean;
        public Value<decimal?> BorrowerPaidClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidClosingCosts() => !BorrowerPaidClosingCosts.Clean;
        public Value<decimal?> BorrowerRequiredInvestment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerRequiredInvestment() => !BorrowerRequiredInvestment.Clean;
        public Value<decimal?> BorrowersOwnFundsforContingencyReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowersOwnFundsforContingencyReserves() => !BorrowersOwnFundsforContingencyReserves.Clean;
        public Value<bool?> BuildingOnOwnLand { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingOnOwnLand() => !BuildingOnOwnLand.Clean;
        public Value<DateTime?> CaseAssignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseAssignedDate() => !CaseAssignedDate.Clean;
        public Value<decimal?> ChildSupportBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildSupportBalance() => !ChildSupportBalance.Clean;
        public Value<string> CHUMSForAppraisal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCHUMSForAppraisal() => !CHUMSForAppraisal.Clean;
        public Value<decimal?> CommitmentMaximumMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentMaximumMortgageAmount() => !CommitmentMaximumMortgageAmount.Clean;
        public Value<string> CommitmentStage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentStage() => !CommitmentStage.Clean;
        public Value<decimal?> ConstructionRepairsRehabilitationCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionRepairsRehabilitationCosts() => !ConstructionRepairsRehabilitationCosts.Clean;
        public Value<decimal?> ContingencyReserveCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContingencyReserveCostsAmount() => !ContingencyReserveCostsAmount.Clean;
        public Value<decimal?> ContingencyReserveCostsPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContingencyReserveCostsPercent() => !ContingencyReserveCostsPercent.Clean;
        public Value<decimal?> ContractSalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractSalesPrice() => !ContractSalesPrice.Clean;
        public Value<string> CriteriaForAppropriateLTVFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCriteriaForAppropriateLTVFactor() => !CriteriaForAppropriateLTVFactor.Clean;
        public Value<string> DealerContractorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorAddress() => !DealerContractorAddress.Clean;
        public Value<string> DealerContractorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorCity() => !DealerContractorCity.Clean;
        public Value<string> DealerContractorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorName() => !DealerContractorName.Clean;
        public Value<string> DealerContractorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorPostalCode() => !DealerContractorPostalCode.Clean;
        public Value<string> DealerContractorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorState() => !DealerContractorState.Clean;
        public Value<decimal?> DiscountPointsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointsAmount() => !DiscountPointsAmount.Clean;
        public Value<decimal?> DiscountPointsPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointsPercent() => !DiscountPointsPercent.Clean;
        public Value<bool?> EEMIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEEMIndicator() => !EEMIndicator.Clean;
        public Value<decimal?> EnergyEfficientMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageAmount() => !EnergyEfficientMortgageAmount.Clean;
        public Value<string> EscrowCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowCommitment() => !EscrowCommitment.Clean;
        public Value<bool?> ExistingDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebt() => !ExistingDebt.Clean;
        public Value<decimal?> ExistingDebtPlusRehabCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebtPlusRehabCosts() => !ExistingDebtPlusRehabCosts.Clean;
        public Value<decimal?> ExistingDebtPlusRehabCostsPlusNewLoanFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebtPlusRehabCostsPlusNewLoanFees() => !ExistingDebtPlusRehabCostsPlusNewLoanFees.Clean;
        public Value<decimal?> FeasibilityStudyWhenNecessary { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeasibilityStudyWhenNecessary() => !FeasibilityStudyWhenNecessary.Clean;
        public Value<decimal?> FeesAssociatedWithNewLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeesAssociatedWithNewLoan() => !FeesAssociatedWithNewLoan.Clean;
        public Value<decimal?> FHA203kB10SubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHA203kB10SubTotal() => !FHA203kB10SubTotal.Clean;
        public Value<string> FHA203kRemarks { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHA203kRemarks() => !FHA203kRemarks.Clean;
        public Value<string> FHAStreamlineType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAStreamlineType() => !FHAStreamlineType.Clean;
        public Value<decimal?> FinalBaseMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalBaseMortgageAmount() => !FinalBaseMortgageAmount.Clean;
        public Value<decimal?> FinanceableMortgageFeesIfCharged { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceableMortgageFeesIfCharged() => !FinanceableMortgageFeesIfCharged.Clean;
        public Value<bool?> HaveOtherPendingApplicationForFHA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHaveOtherPendingApplicationForFHA() => !HaveOtherPendingApplicationForFHA.Clean;
        public Value<bool?> HUDOwned { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUDOwned() => !HUDOwned.Clean;
        public Value<bool?> HUDREOIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUDREOIndicator() => !HUDREOIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndependentConsultantFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndependentConsultantFee() => !IndependentConsultantFee.Clean;
        public Value<decimal?> InitialBaseMortgageAmountPlusEEMImprovementAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialBaseMortgageAmountPlusEEMImprovementAmount() => !InitialBaseMortgageAmountPlusEEMImprovementAmount.Clean;
        public Value<decimal?> InitialDrawAtClosingTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialDrawAtClosingTotal() => !InitialDrawAtClosingTotal.Clean;
        public Value<decimal?> InspectionFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeAmount() => !InspectionFeeAmount.Clean;
        public Value<decimal?> InspectionFeesDuringRehabilitation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeesDuringRehabilitation() => !InspectionFeesDuringRehabilitation.Clean;
        public Value<int?> InspectionFeeTimes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeTimes() => !InspectionFeeTimes.Clean;
        public Value<bool?> LDPGSAForBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSAForBorrower() => !LDPGSAForBorrower.Clean;
        public Value<bool?> LDPGSAForCoBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSAForCoBorrower() => !LDPGSAForCoBorrower.Clean;
        public Value<bool?> LeasedFromSomeoneElse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeasedFromSomeoneElse() => !LeasedFromSomeoneElse.Clean;
        public Value<DateTime?> LeaseExpiradionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseExpiradionDate() => !LeaseExpiradionDate.Clean;
        public Value<decimal?> LeaseMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseMonthlyPayment() => !LeaseMonthlyPayment.Clean;
        public Value<decimal?> LessAllowableDownpayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLessAllowableDownpayment() => !LessAllowableDownpayment.Clean;
        public Value<decimal?> LesserOf3AOr3B { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOf3AOr3B() => !LesserOf3AOr3B.Clean;
        public Value<decimal?> LesserOf3AOr3BMultiply3F { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOf3AOr3BMultiply3F() => !LesserOf3AOr3BMultiply3F.Clean;
        public Value<decimal?> LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfMaximumFinanceableSolarOrWindEnergyAmount() => !LesserOfMaximumFinanceableSolarOrWindEnergyAmount.Clean;
        public Value<decimal?> LesserOfSalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSalesPrice() => !LesserOfSalesPrice.Clean;
        public Value<decimal?> LesserOfSumAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumAmount() => !LesserOfSumAmount.Clean;
        public Value<decimal?> LesserOfSumAsIs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumAsIs() => !LesserOfSumAsIs.Clean;
        public Value<decimal?> LesserOfSumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumPercent() => !LesserOfSumPercent.Clean;
        public Value<bool?> LimitedProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitedProgram() => !LimitedProgram.Clean;
        public Value<bool?> LoanFor203KIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFor203KIndicator() => !LoanFor203KIndicator.Clean;
        public Value<string> LoanPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurpose() => !LoanPurpose.Clean;
        public Value<decimal?> MaterialCostsOrderedPrepaidByBorrowerContractor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaterialCostsOrderedPrepaidByBorrowerContractor() => !MaterialCostsOrderedPrepaidByBorrowerContractor.Clean;
        public Value<decimal?> MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent() => !MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean;
        public Value<decimal?> MaximumMortgageWithUFMIP { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumMortgageWithUFMIP() => !MaximumMortgageWithUFMIP.Clean;
        public Value<decimal?> MIPLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPLTV() => !MIPLTV.Clean;
        public Value<bool?> MtgOrDeedOfTrusOnProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgOrDeedOfTrusOnProperty() => !MtgOrDeedOfTrusOnProperty.Clean;
        public Value<decimal?> MtgPaymentEscrowedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgPaymentEscrowedAmount() => !MtgPaymentEscrowedAmount.Clean;
        public Value<int?> MtgPaymentEscrowedTimes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgPaymentEscrowedTimes() => !MtgPaymentEscrowedTimes.Clean;
        public Value<decimal?> NationwideMortgageLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNationwideMortgageLimit() => !NationwideMortgageLimit.Clean;
        public Value<decimal?> NationwideMortgageLimitAfter120Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNationwideMortgageLimitAfter120Percent() => !NationwideMortgageLimitAfter120Percent.Clean;
        public Value<bool?> NewResidential { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewResidential() => !NewResidential.Clean;
        public Value<string> NonresidentialTypeOfUse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonresidentialTypeOfUse() => !NonresidentialTypeOfUse.Clean;
        public Value<int?> NumberOfHistoricUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfHistoricUnits() => !NumberOfHistoricUnits.Clean;
        public Value<int?> NumberOfMultifamilyUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMultifamilyUnits() => !NumberOfMultifamilyUnits.Clean;
        public Value<string> OtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !OtherDescription.Clean;
        public Value<bool?> OwnedByBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnedByBorrower() => !OwnedByBorrower.Clean;
        public Value<decimal?> PercentAfterImprovedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentAfterImprovedValue() => !PercentAfterImprovedValue.Clean;
        public Value<decimal?> PermitsAndOtherFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePermitsAndOtherFee() => !PermitsAndOtherFee.Clean;
        public Value<decimal?> PlanReviewerFeeAddition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeAddition() => !PlanReviewerFeeAddition.Clean;
        public Value<decimal?> PlanReviewerFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeAmount() => !PlanReviewerFeeAmount.Clean;
        public Value<int?> PlanReviewerFeeMiles { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeMiles() => !PlanReviewerFeeMiles.Clean;
        public Value<string> PropertyOwnerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerAddress() => !PropertyOwnerAddress.Clean;
        public Value<string> PropertyOwnerCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerCity() => !PropertyOwnerCity.Clean;
        public Value<string> PropertyOwnerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerName() => !PropertyOwnerName.Clean;
        public Value<string> PropertyOwnerPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerPostalCode() => !PropertyOwnerPostalCode.Clean;
        public Value<string> PropertyOwnerState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerState() => !PropertyOwnerState.Clean;
        public Value<string> PropertyToBeImproved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyToBeImproved() => !PropertyToBeImproved.Clean;
        public Value<string> PropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyType() => !PropertyType.Clean;
        public Value<DateTime?> PurchaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseDate() => !PurchaseDate.Clean;
        public Value<bool?> PurchasedOnContract { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasedOnContract() => !PurchasedOnContract.Clean;
        public Value<decimal?> PurchaseMaximumMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseMaximumMortgageAmount() => !PurchaseMaximumMortgageAmount.Clean;
        public Value<decimal?> PurchaseMaximumMortgagePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseMaximumMortgagePercent() => !PurchaseMaximumMortgagePercent.Clean;
        public Value<decimal?> PurchasePriceLessInducementToPurchase { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceLessInducementToPurchase() => !PurchasePriceLessInducementToPurchase.Clean;
        public Value<decimal?> RefinanceMaximumMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceMaximumMortgageAmount() => !RefinanceMaximumMortgageAmount.Clean;
        public Value<bool?> RefinancingATitleILoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancingATitleILoan() => !RefinancingATitleILoan.Clean;
        public Value<decimal?> RehabilitationEscrowAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRehabilitationEscrowAccount() => !RehabilitationEscrowAccount.Clean;
        public Value<decimal?> RehabilitationEscrowAmountBalanceForFutureDraws { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRehabilitationEscrowAmountBalanceForFutureDraws() => !RehabilitationEscrowAmountBalanceForFutureDraws.Clean;
        public Value<decimal?> RentalCashFlowBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentalCashFlowBalance() => !RentalCashFlowBalance.Clean;
        public Value<string> ResidencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyType() => !ResidencyType.Clean;
        public Value<string> RiskClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskClass() => !RiskClass.Clean;
        public Value<bool?> ScoredByTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScoredByTotal() => !ScoredByTotal.Clean;
        public Value<List<SecondaryFinancingProvider>> SecondaryFinancingProviders { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondaryFinancingProviders() => !SecondaryFinancingProviders.Clean;
        public Value<decimal?> SellerContributionRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerContributionRate() => !SellerContributionRate.Clean;
        public Value<bool?> SimpleRefinance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSimpleRefinance() => !SimpleRefinance.Clean;
        public Value<decimal?> StatutoryInvestment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatutoryInvestment() => !StatutoryInvestment.Clean;
        public Value<decimal?> Step2EPlusStep1E { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStep2EPlusStep1E() => !Step2EPlusStep1E.Clean;
        public Value<bool?> Streamlined { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreamlined() => !Streamlined.Clean;
        public Value<decimal?> SubTotalForEscrowAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTotalForEscrowAccount() => !SubTotalForEscrowAccount.Clean;
        public Value<decimal?> SubTotalForReleaseAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTotalForReleaseAtClosing() => !SubTotalForReleaseAtClosing.Clean;
        public Value<decimal?> SumForInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumForInvestor() => !SumForInvestor.Clean;
        public Value<decimal?> SumForOwnerOccupied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumForOwnerOccupied() => !SumForOwnerOccupied.Clean;
        public Value<decimal?> SumOfExistingDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumOfExistingDebt() => !SumOfExistingDebt.Clean;
        public Value<decimal?> SuplementalOriginationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuplementalOriginationFee() => !SuplementalOriginationFee.Clean;
        public Value<decimal?> Title1LoanBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanBalance() => !Title1LoanBalance.Clean;
        public Value<string> Title1LoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanNumber() => !Title1LoanNumber.Clean;
        public Value<string> Title1LoanWithWhom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanWithWhom() => !Title1LoanWithWhom.Clean;
        public Value<decimal?> TitleUpdateFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFeeAmount() => !TitleUpdateFeeAmount.Clean;
        public Value<decimal?> TitleUpdateFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFees() => !TitleUpdateFees.Clean;
        public Value<int?> TitleUpdateFeeTimes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFeeTimes() => !TitleUpdateFeeTimes.Clean;
        public Value<decimal?> TotalCostsOfRepairsInA6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCostsOfRepairsInA6() => !TotalCostsOfRepairsInA6.Clean;
        public Value<decimal?> TotalEscrowCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowCommitment() => !TotalEscrowCommitment.Clean;
        public Value<decimal?> TotalEscrowedFunds { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowedFunds() => !TotalEscrowedFunds.Clean;
        public Value<decimal?> TotalFixedUnpaidBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFixedUnpaidBalance() => !TotalFixedUnpaidBalance.Clean;
        public Value<decimal?> TotalForBorrowerEstimatedProfit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorrowerEstimatedProfit() => !TotalForBorrowerEstimatedProfit.Clean;
        public Value<decimal?> TotalForInspectionAndTitleFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForInspectionAndTitleFee() => !TotalForInspectionAndTitleFee.Clean;
        public Value<decimal?> TotalForLesserOfSumAsIs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForLesserOfSumAsIs() => !TotalForLesserOfSumAsIs.Clean;
        public Value<decimal?> TotalForMtgPaymentEscrowed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForMtgPaymentEscrowed() => !TotalForMtgPaymentEscrowed.Clean;
        public Value<decimal?> TotalForPlanReviewerFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForPlanReviewerFee() => !TotalForPlanReviewerFee.Clean;
        public Value<decimal?> TotalForRehabilitationCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForRehabilitationCost() => !TotalForRehabilitationCost.Clean;
        public Value<decimal?> TotalRehabilitationCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRehabilitationCosts() => !TotalRehabilitationCosts.Clean;
        public Value<decimal?> TotalRehabilitationCostsFeesReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRehabilitationCostsFeesReserves() => !TotalRehabilitationCostsFeesReserves.Clean;
        public Value<decimal?> ValueEstablished { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValueEstablished() => !ValueEstablished.Clean;
        public Value<decimal?> WindEnergySystemActualCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWindEnergySystemActualCost() => !WindEnergySystemActualCost.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualCashInvRequired.Clean
                    && AdjustedMaxMtgAmount.Clean
                    && AfterImprovedValue.Clean
                    && AfterImprovedValueAfter20Percent.Clean
                    && AllowableEnergyImprovements.Clean
                    && AppropriateLTVFactor.Clean
                    && ArchitecturalEngineeringFee.Clean
                    && AsIsValue.Clean
                    && BaseMortgageAmountFrom3COr3D.Clean
                    && BorrowerAcknowledgement.Clean
                    && BorrowerEstimatedProfit1.Clean
                    && BorrowerEstimatedProfit2.Clean
                    && BorrowerPaidClosingCosts.Clean
                    && BorrowerRequiredInvestment.Clean
                    && BorrowersOwnFundsforContingencyReserves.Clean
                    && BuildingOnOwnLand.Clean
                    && CaseAssignedDate.Clean
                    && ChildSupportBalance.Clean
                    && CHUMSForAppraisal.Clean
                    && CommitmentMaximumMortgageAmount.Clean
                    && CommitmentStage.Clean
                    && ConstructionRepairsRehabilitationCosts.Clean
                    && ContingencyReserveCostsAmount.Clean
                    && ContingencyReserveCostsPercent.Clean
                    && ContractSalesPrice.Clean
                    && CriteriaForAppropriateLTVFactor.Clean
                    && DealerContractorAddress.Clean
                    && DealerContractorCity.Clean
                    && DealerContractorName.Clean
                    && DealerContractorPostalCode.Clean
                    && DealerContractorState.Clean
                    && DiscountPointsAmount.Clean
                    && DiscountPointsPercent.Clean
                    && EEMIndicator.Clean
                    && EnergyEfficientMortgageAmount.Clean
                    && EscrowCommitment.Clean
                    && ExistingDebt.Clean
                    && ExistingDebtPlusRehabCosts.Clean
                    && ExistingDebtPlusRehabCostsPlusNewLoanFees.Clean
                    && FeasibilityStudyWhenNecessary.Clean
                    && FeesAssociatedWithNewLoan.Clean
                    && FHA203kB10SubTotal.Clean
                    && FHA203kRemarks.Clean
                    && FHAStreamlineType.Clean
                    && FinalBaseMortgageAmount.Clean
                    && FinanceableMortgageFeesIfCharged.Clean
                    && HaveOtherPendingApplicationForFHA.Clean
                    && HUDOwned.Clean
                    && HUDREOIndicator.Clean
                    && Id.Clean
                    && IndependentConsultantFee.Clean
                    && InitialBaseMortgageAmountPlusEEMImprovementAmount.Clean
                    && InitialDrawAtClosingTotal.Clean
                    && InspectionFeeAmount.Clean
                    && InspectionFeesDuringRehabilitation.Clean
                    && InspectionFeeTimes.Clean
                    && LDPGSAForBorrower.Clean
                    && LDPGSAForCoBorrower.Clean
                    && LeasedFromSomeoneElse.Clean
                    && LeaseExpiradionDate.Clean
                    && LeaseMonthlyPayment.Clean
                    && LessAllowableDownpayment.Clean
                    && LesserOf3AOr3B.Clean
                    && LesserOf3AOr3BMultiply3F.Clean
                    && LesserOfMaximumFinanceableSolarOrWindEnergyAmount.Clean
                    && LesserOfSalesPrice.Clean
                    && LesserOfSumAmount.Clean
                    && LesserOfSumAsIs.Clean
                    && LesserOfSumPercent.Clean
                    && LimitedProgram.Clean
                    && LoanFor203KIndicator.Clean
                    && LoanPurpose.Clean
                    && MaterialCostsOrderedPrepaidByBorrowerContractor.Clean
                    && MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean
                    && MaximumMortgageWithUFMIP.Clean
                    && MIPLTV.Clean
                    && MtgOrDeedOfTrusOnProperty.Clean
                    && MtgPaymentEscrowedAmount.Clean
                    && MtgPaymentEscrowedTimes.Clean
                    && NationwideMortgageLimit.Clean
                    && NationwideMortgageLimitAfter120Percent.Clean
                    && NewResidential.Clean
                    && NonresidentialTypeOfUse.Clean
                    && NumberOfHistoricUnits.Clean
                    && NumberOfMultifamilyUnits.Clean
                    && OtherDescription.Clean
                    && OwnedByBorrower.Clean
                    && PercentAfterImprovedValue.Clean
                    && PermitsAndOtherFee.Clean
                    && PlanReviewerFeeAddition.Clean
                    && PlanReviewerFeeAmount.Clean
                    && PlanReviewerFeeMiles.Clean
                    && PropertyOwnerAddress.Clean
                    && PropertyOwnerCity.Clean
                    && PropertyOwnerName.Clean
                    && PropertyOwnerPostalCode.Clean
                    && PropertyOwnerState.Clean
                    && PropertyToBeImproved.Clean
                    && PropertyType.Clean
                    && PurchaseDate.Clean
                    && PurchasedOnContract.Clean
                    && PurchaseMaximumMortgageAmount.Clean
                    && PurchaseMaximumMortgagePercent.Clean
                    && PurchasePriceLessInducementToPurchase.Clean
                    && RefinanceMaximumMortgageAmount.Clean
                    && RefinancingATitleILoan.Clean
                    && RehabilitationEscrowAccount.Clean
                    && RehabilitationEscrowAmountBalanceForFutureDraws.Clean
                    && RentalCashFlowBalance.Clean
                    && ResidencyType.Clean
                    && RiskClass.Clean
                    && ScoredByTotal.Clean
                    && SecondaryFinancingProviders.Clean
                    && SellerContributionRate.Clean
                    && SimpleRefinance.Clean
                    && StatutoryInvestment.Clean
                    && Step2EPlusStep1E.Clean
                    && Streamlined.Clean
                    && SubTotalForEscrowAccount.Clean
                    && SubTotalForReleaseAtClosing.Clean
                    && SumForInvestor.Clean
                    && SumForOwnerOccupied.Clean
                    && SumOfExistingDebt.Clean
                    && SuplementalOriginationFee.Clean
                    && Title1LoanBalance.Clean
                    && Title1LoanNumber.Clean
                    && Title1LoanWithWhom.Clean
                    && TitleUpdateFeeAmount.Clean
                    && TitleUpdateFees.Clean
                    && TitleUpdateFeeTimes.Clean
                    && TotalCostsOfRepairsInA6.Clean
                    && TotalEscrowCommitment.Clean
                    && TotalEscrowedFunds.Clean
                    && TotalFixedUnpaidBalance.Clean
                    && TotalForBorrowerEstimatedProfit.Clean
                    && TotalForInspectionAndTitleFee.Clean
                    && TotalForLesserOfSumAsIs.Clean
                    && TotalForMtgPaymentEscrowed.Clean
                    && TotalForPlanReviewerFee.Clean
                    && TotalForRehabilitationCost.Clean
                    && TotalRehabilitationCosts.Clean
                    && TotalRehabilitationCostsFeesReserves.Clean
                    && ValueEstablished.Clean
                    && WindEnergySystemActualCost.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualCashInvRequired; v0.Clean = value; ActualCashInvRequired = v0;
                var v1 = AdjustedMaxMtgAmount; v1.Clean = value; AdjustedMaxMtgAmount = v1;
                var v2 = AfterImprovedValue; v2.Clean = value; AfterImprovedValue = v2;
                var v3 = AfterImprovedValueAfter20Percent; v3.Clean = value; AfterImprovedValueAfter20Percent = v3;
                var v4 = AllowableEnergyImprovements; v4.Clean = value; AllowableEnergyImprovements = v4;
                var v5 = AppropriateLTVFactor; v5.Clean = value; AppropriateLTVFactor = v5;
                var v6 = ArchitecturalEngineeringFee; v6.Clean = value; ArchitecturalEngineeringFee = v6;
                var v7 = AsIsValue; v7.Clean = value; AsIsValue = v7;
                var v8 = BaseMortgageAmountFrom3COr3D; v8.Clean = value; BaseMortgageAmountFrom3COr3D = v8;
                var v9 = BorrowerAcknowledgement; v9.Clean = value; BorrowerAcknowledgement = v9;
                var v10 = BorrowerEstimatedProfit1; v10.Clean = value; BorrowerEstimatedProfit1 = v10;
                var v11 = BorrowerEstimatedProfit2; v11.Clean = value; BorrowerEstimatedProfit2 = v11;
                var v12 = BorrowerPaidClosingCosts; v12.Clean = value; BorrowerPaidClosingCosts = v12;
                var v13 = BorrowerRequiredInvestment; v13.Clean = value; BorrowerRequiredInvestment = v13;
                var v14 = BorrowersOwnFundsforContingencyReserves; v14.Clean = value; BorrowersOwnFundsforContingencyReserves = v14;
                var v15 = BuildingOnOwnLand; v15.Clean = value; BuildingOnOwnLand = v15;
                var v16 = CaseAssignedDate; v16.Clean = value; CaseAssignedDate = v16;
                var v17 = ChildSupportBalance; v17.Clean = value; ChildSupportBalance = v17;
                var v18 = CHUMSForAppraisal; v18.Clean = value; CHUMSForAppraisal = v18;
                var v19 = CommitmentMaximumMortgageAmount; v19.Clean = value; CommitmentMaximumMortgageAmount = v19;
                var v20 = CommitmentStage; v20.Clean = value; CommitmentStage = v20;
                var v21 = ConstructionRepairsRehabilitationCosts; v21.Clean = value; ConstructionRepairsRehabilitationCosts = v21;
                var v22 = ContingencyReserveCostsAmount; v22.Clean = value; ContingencyReserveCostsAmount = v22;
                var v23 = ContingencyReserveCostsPercent; v23.Clean = value; ContingencyReserveCostsPercent = v23;
                var v24 = ContractSalesPrice; v24.Clean = value; ContractSalesPrice = v24;
                var v25 = CriteriaForAppropriateLTVFactor; v25.Clean = value; CriteriaForAppropriateLTVFactor = v25;
                var v26 = DealerContractorAddress; v26.Clean = value; DealerContractorAddress = v26;
                var v27 = DealerContractorCity; v27.Clean = value; DealerContractorCity = v27;
                var v28 = DealerContractorName; v28.Clean = value; DealerContractorName = v28;
                var v29 = DealerContractorPostalCode; v29.Clean = value; DealerContractorPostalCode = v29;
                var v30 = DealerContractorState; v30.Clean = value; DealerContractorState = v30;
                var v31 = DiscountPointsAmount; v31.Clean = value; DiscountPointsAmount = v31;
                var v32 = DiscountPointsPercent; v32.Clean = value; DiscountPointsPercent = v32;
                var v33 = EEMIndicator; v33.Clean = value; EEMIndicator = v33;
                var v34 = EnergyEfficientMortgageAmount; v34.Clean = value; EnergyEfficientMortgageAmount = v34;
                var v35 = EscrowCommitment; v35.Clean = value; EscrowCommitment = v35;
                var v36 = ExistingDebt; v36.Clean = value; ExistingDebt = v36;
                var v37 = ExistingDebtPlusRehabCosts; v37.Clean = value; ExistingDebtPlusRehabCosts = v37;
                var v38 = ExistingDebtPlusRehabCostsPlusNewLoanFees; v38.Clean = value; ExistingDebtPlusRehabCostsPlusNewLoanFees = v38;
                var v39 = FeasibilityStudyWhenNecessary; v39.Clean = value; FeasibilityStudyWhenNecessary = v39;
                var v40 = FeesAssociatedWithNewLoan; v40.Clean = value; FeesAssociatedWithNewLoan = v40;
                var v41 = FHA203kB10SubTotal; v41.Clean = value; FHA203kB10SubTotal = v41;
                var v42 = FHA203kRemarks; v42.Clean = value; FHA203kRemarks = v42;
                var v43 = FHAStreamlineType; v43.Clean = value; FHAStreamlineType = v43;
                var v44 = FinalBaseMortgageAmount; v44.Clean = value; FinalBaseMortgageAmount = v44;
                var v45 = FinanceableMortgageFeesIfCharged; v45.Clean = value; FinanceableMortgageFeesIfCharged = v45;
                var v46 = HaveOtherPendingApplicationForFHA; v46.Clean = value; HaveOtherPendingApplicationForFHA = v46;
                var v47 = HUDOwned; v47.Clean = value; HUDOwned = v47;
                var v48 = HUDREOIndicator; v48.Clean = value; HUDREOIndicator = v48;
                var v49 = Id; v49.Clean = value; Id = v49;
                var v50 = IndependentConsultantFee; v50.Clean = value; IndependentConsultantFee = v50;
                var v51 = InitialBaseMortgageAmountPlusEEMImprovementAmount; v51.Clean = value; InitialBaseMortgageAmountPlusEEMImprovementAmount = v51;
                var v52 = InitialDrawAtClosingTotal; v52.Clean = value; InitialDrawAtClosingTotal = v52;
                var v53 = InspectionFeeAmount; v53.Clean = value; InspectionFeeAmount = v53;
                var v54 = InspectionFeesDuringRehabilitation; v54.Clean = value; InspectionFeesDuringRehabilitation = v54;
                var v55 = InspectionFeeTimes; v55.Clean = value; InspectionFeeTimes = v55;
                var v56 = LDPGSAForBorrower; v56.Clean = value; LDPGSAForBorrower = v56;
                var v57 = LDPGSAForCoBorrower; v57.Clean = value; LDPGSAForCoBorrower = v57;
                var v58 = LeasedFromSomeoneElse; v58.Clean = value; LeasedFromSomeoneElse = v58;
                var v59 = LeaseExpiradionDate; v59.Clean = value; LeaseExpiradionDate = v59;
                var v60 = LeaseMonthlyPayment; v60.Clean = value; LeaseMonthlyPayment = v60;
                var v61 = LessAllowableDownpayment; v61.Clean = value; LessAllowableDownpayment = v61;
                var v62 = LesserOf3AOr3B; v62.Clean = value; LesserOf3AOr3B = v62;
                var v63 = LesserOf3AOr3BMultiply3F; v63.Clean = value; LesserOf3AOr3BMultiply3F = v63;
                var v64 = LesserOfMaximumFinanceableSolarOrWindEnergyAmount; v64.Clean = value; LesserOfMaximumFinanceableSolarOrWindEnergyAmount = v64;
                var v65 = LesserOfSalesPrice; v65.Clean = value; LesserOfSalesPrice = v65;
                var v66 = LesserOfSumAmount; v66.Clean = value; LesserOfSumAmount = v66;
                var v67 = LesserOfSumAsIs; v67.Clean = value; LesserOfSumAsIs = v67;
                var v68 = LesserOfSumPercent; v68.Clean = value; LesserOfSumPercent = v68;
                var v69 = LimitedProgram; v69.Clean = value; LimitedProgram = v69;
                var v70 = LoanFor203KIndicator; v70.Clean = value; LoanFor203KIndicator = v70;
                var v71 = LoanPurpose; v71.Clean = value; LoanPurpose = v71;
                var v72 = MaterialCostsOrderedPrepaidByBorrowerContractor; v72.Clean = value; MaterialCostsOrderedPrepaidByBorrowerContractor = v72;
                var v73 = MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; v73.Clean = value; MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = v73;
                var v74 = MaximumMortgageWithUFMIP; v74.Clean = value; MaximumMortgageWithUFMIP = v74;
                var v75 = MIPLTV; v75.Clean = value; MIPLTV = v75;
                var v76 = MtgOrDeedOfTrusOnProperty; v76.Clean = value; MtgOrDeedOfTrusOnProperty = v76;
                var v77 = MtgPaymentEscrowedAmount; v77.Clean = value; MtgPaymentEscrowedAmount = v77;
                var v78 = MtgPaymentEscrowedTimes; v78.Clean = value; MtgPaymentEscrowedTimes = v78;
                var v79 = NationwideMortgageLimit; v79.Clean = value; NationwideMortgageLimit = v79;
                var v80 = NationwideMortgageLimitAfter120Percent; v80.Clean = value; NationwideMortgageLimitAfter120Percent = v80;
                var v81 = NewResidential; v81.Clean = value; NewResidential = v81;
                var v82 = NonresidentialTypeOfUse; v82.Clean = value; NonresidentialTypeOfUse = v82;
                var v83 = NumberOfHistoricUnits; v83.Clean = value; NumberOfHistoricUnits = v83;
                var v84 = NumberOfMultifamilyUnits; v84.Clean = value; NumberOfMultifamilyUnits = v84;
                var v85 = OtherDescription; v85.Clean = value; OtherDescription = v85;
                var v86 = OwnedByBorrower; v86.Clean = value; OwnedByBorrower = v86;
                var v87 = PercentAfterImprovedValue; v87.Clean = value; PercentAfterImprovedValue = v87;
                var v88 = PermitsAndOtherFee; v88.Clean = value; PermitsAndOtherFee = v88;
                var v89 = PlanReviewerFeeAddition; v89.Clean = value; PlanReviewerFeeAddition = v89;
                var v90 = PlanReviewerFeeAmount; v90.Clean = value; PlanReviewerFeeAmount = v90;
                var v91 = PlanReviewerFeeMiles; v91.Clean = value; PlanReviewerFeeMiles = v91;
                var v92 = PropertyOwnerAddress; v92.Clean = value; PropertyOwnerAddress = v92;
                var v93 = PropertyOwnerCity; v93.Clean = value; PropertyOwnerCity = v93;
                var v94 = PropertyOwnerName; v94.Clean = value; PropertyOwnerName = v94;
                var v95 = PropertyOwnerPostalCode; v95.Clean = value; PropertyOwnerPostalCode = v95;
                var v96 = PropertyOwnerState; v96.Clean = value; PropertyOwnerState = v96;
                var v97 = PropertyToBeImproved; v97.Clean = value; PropertyToBeImproved = v97;
                var v98 = PropertyType; v98.Clean = value; PropertyType = v98;
                var v99 = PurchaseDate; v99.Clean = value; PurchaseDate = v99;
                var v100 = PurchasedOnContract; v100.Clean = value; PurchasedOnContract = v100;
                var v101 = PurchaseMaximumMortgageAmount; v101.Clean = value; PurchaseMaximumMortgageAmount = v101;
                var v102 = PurchaseMaximumMortgagePercent; v102.Clean = value; PurchaseMaximumMortgagePercent = v102;
                var v103 = PurchasePriceLessInducementToPurchase; v103.Clean = value; PurchasePriceLessInducementToPurchase = v103;
                var v104 = RefinanceMaximumMortgageAmount; v104.Clean = value; RefinanceMaximumMortgageAmount = v104;
                var v105 = RefinancingATitleILoan; v105.Clean = value; RefinancingATitleILoan = v105;
                var v106 = RehabilitationEscrowAccount; v106.Clean = value; RehabilitationEscrowAccount = v106;
                var v107 = RehabilitationEscrowAmountBalanceForFutureDraws; v107.Clean = value; RehabilitationEscrowAmountBalanceForFutureDraws = v107;
                var v108 = RentalCashFlowBalance; v108.Clean = value; RentalCashFlowBalance = v108;
                var v109 = ResidencyType; v109.Clean = value; ResidencyType = v109;
                var v110 = RiskClass; v110.Clean = value; RiskClass = v110;
                var v111 = ScoredByTotal; v111.Clean = value; ScoredByTotal = v111;
                var v112 = SecondaryFinancingProviders; v112.Clean = value; SecondaryFinancingProviders = v112;
                var v113 = SellerContributionRate; v113.Clean = value; SellerContributionRate = v113;
                var v114 = SimpleRefinance; v114.Clean = value; SimpleRefinance = v114;
                var v115 = StatutoryInvestment; v115.Clean = value; StatutoryInvestment = v115;
                var v116 = Step2EPlusStep1E; v116.Clean = value; Step2EPlusStep1E = v116;
                var v117 = Streamlined; v117.Clean = value; Streamlined = v117;
                var v118 = SubTotalForEscrowAccount; v118.Clean = value; SubTotalForEscrowAccount = v118;
                var v119 = SubTotalForReleaseAtClosing; v119.Clean = value; SubTotalForReleaseAtClosing = v119;
                var v120 = SumForInvestor; v120.Clean = value; SumForInvestor = v120;
                var v121 = SumForOwnerOccupied; v121.Clean = value; SumForOwnerOccupied = v121;
                var v122 = SumOfExistingDebt; v122.Clean = value; SumOfExistingDebt = v122;
                var v123 = SuplementalOriginationFee; v123.Clean = value; SuplementalOriginationFee = v123;
                var v124 = Title1LoanBalance; v124.Clean = value; Title1LoanBalance = v124;
                var v125 = Title1LoanNumber; v125.Clean = value; Title1LoanNumber = v125;
                var v126 = Title1LoanWithWhom; v126.Clean = value; Title1LoanWithWhom = v126;
                var v127 = TitleUpdateFeeAmount; v127.Clean = value; TitleUpdateFeeAmount = v127;
                var v128 = TitleUpdateFees; v128.Clean = value; TitleUpdateFees = v128;
                var v129 = TitleUpdateFeeTimes; v129.Clean = value; TitleUpdateFeeTimes = v129;
                var v130 = TotalCostsOfRepairsInA6; v130.Clean = value; TotalCostsOfRepairsInA6 = v130;
                var v131 = TotalEscrowCommitment; v131.Clean = value; TotalEscrowCommitment = v131;
                var v132 = TotalEscrowedFunds; v132.Clean = value; TotalEscrowedFunds = v132;
                var v133 = TotalFixedUnpaidBalance; v133.Clean = value; TotalFixedUnpaidBalance = v133;
                var v134 = TotalForBorrowerEstimatedProfit; v134.Clean = value; TotalForBorrowerEstimatedProfit = v134;
                var v135 = TotalForInspectionAndTitleFee; v135.Clean = value; TotalForInspectionAndTitleFee = v135;
                var v136 = TotalForLesserOfSumAsIs; v136.Clean = value; TotalForLesserOfSumAsIs = v136;
                var v137 = TotalForMtgPaymentEscrowed; v137.Clean = value; TotalForMtgPaymentEscrowed = v137;
                var v138 = TotalForPlanReviewerFee; v138.Clean = value; TotalForPlanReviewerFee = v138;
                var v139 = TotalForRehabilitationCost; v139.Clean = value; TotalForRehabilitationCost = v139;
                var v140 = TotalRehabilitationCosts; v140.Clean = value; TotalRehabilitationCosts = v140;
                var v141 = TotalRehabilitationCostsFeesReserves; v141.Clean = value; TotalRehabilitationCostsFeesReserves = v141;
                var v142 = ValueEstablished; v142.Clean = value; ValueEstablished = v142;
                var v143 = WindEnergySystemActualCost; v143.Clean = value; WindEnergySystemActualCost = v143;
                _settingClean = 0;
            }
        }
    }
}