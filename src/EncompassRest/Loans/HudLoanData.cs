using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HudLoanData
    {
        private Value<decimal?> _actualCashInvRequired;
        public decimal? ActualCashInvRequired { get { return _actualCashInvRequired; } set { _actualCashInvRequired = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualCashInvRequired() => !_actualCashInvRequired.Clean;
        private Value<decimal?> _adjustedMaxMtgAmount;
        public decimal? AdjustedMaxMtgAmount { get { return _adjustedMaxMtgAmount; } set { _adjustedMaxMtgAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedMaxMtgAmount() => !_adjustedMaxMtgAmount.Clean;
        private Value<decimal?> _afterImprovedValue;
        public decimal? AfterImprovedValue { get { return _afterImprovedValue; } set { _afterImprovedValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterImprovedValue() => !_afterImprovedValue.Clean;
        private Value<decimal?> _afterImprovedValueAfter20Percent;
        public decimal? AfterImprovedValueAfter20Percent { get { return _afterImprovedValueAfter20Percent; } set { _afterImprovedValueAfter20Percent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAfterImprovedValueAfter20Percent() => !_afterImprovedValueAfter20Percent.Clean;
        private Value<decimal?> _allowableEnergyImprovements;
        public decimal? AllowableEnergyImprovements { get { return _allowableEnergyImprovements; } set { _allowableEnergyImprovements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllowableEnergyImprovements() => !_allowableEnergyImprovements.Clean;
        private Value<decimal?> _appropriateLTVFactor;
        public decimal? AppropriateLTVFactor { get { return _appropriateLTVFactor; } set { _appropriateLTVFactor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppropriateLTVFactor() => !_appropriateLTVFactor.Clean;
        private Value<decimal?> _architecturalEngineeringFee;
        public decimal? ArchitecturalEngineeringFee { get { return _architecturalEngineeringFee; } set { _architecturalEngineeringFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchitecturalEngineeringFee() => !_architecturalEngineeringFee.Clean;
        private Value<decimal?> _asIsValue;
        public decimal? AsIsValue { get { return _asIsValue; } set { _asIsValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsIsValue() => !_asIsValue.Clean;
        private Value<decimal?> _baseMortgageAmountFrom3COr3D;
        public decimal? BaseMortgageAmountFrom3COr3D { get { return _baseMortgageAmountFrom3COr3D; } set { _baseMortgageAmountFrom3COr3D = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseMortgageAmountFrom3COr3D() => !_baseMortgageAmountFrom3COr3D.Clean;
        private Value<string> _borrowerAcknowledgement;
        public string BorrowerAcknowledgement { get { return _borrowerAcknowledgement; } set { _borrowerAcknowledgement = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerAcknowledgement() => !_borrowerAcknowledgement.Clean;
        private Value<decimal?> _borrowerEstimatedProfit1;
        public decimal? BorrowerEstimatedProfit1 { get { return _borrowerEstimatedProfit1; } set { _borrowerEstimatedProfit1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerEstimatedProfit1() => !_borrowerEstimatedProfit1.Clean;
        private Value<decimal?> _borrowerEstimatedProfit2;
        public decimal? BorrowerEstimatedProfit2 { get { return _borrowerEstimatedProfit2; } set { _borrowerEstimatedProfit2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerEstimatedProfit2() => !_borrowerEstimatedProfit2.Clean;
        private Value<decimal?> _borrowerPaidClosingCosts;
        public decimal? BorrowerPaidClosingCosts { get { return _borrowerPaidClosingCosts; } set { _borrowerPaidClosingCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidClosingCosts() => !_borrowerPaidClosingCosts.Clean;
        private Value<decimal?> _borrowerRequiredInvestment;
        public decimal? BorrowerRequiredInvestment { get { return _borrowerRequiredInvestment; } set { _borrowerRequiredInvestment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerRequiredInvestment() => !_borrowerRequiredInvestment.Clean;
        private Value<decimal?> _borrowersOwnFundsforContingencyReserves;
        public decimal? BorrowersOwnFundsforContingencyReserves { get { return _borrowersOwnFundsforContingencyReserves; } set { _borrowersOwnFundsforContingencyReserves = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowersOwnFundsforContingencyReserves() => !_borrowersOwnFundsforContingencyReserves.Clean;
        private Value<bool?> _buildingOnOwnLand;
        public bool? BuildingOnOwnLand { get { return _buildingOnOwnLand; } set { _buildingOnOwnLand = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingOnOwnLand() => !_buildingOnOwnLand.Clean;
        private Value<DateTime?> _caseAssignedDate;
        public DateTime? CaseAssignedDate { get { return _caseAssignedDate; } set { _caseAssignedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseAssignedDate() => !_caseAssignedDate.Clean;
        private Value<decimal?> _childSupportBalance;
        public decimal? ChildSupportBalance { get { return _childSupportBalance; } set { _childSupportBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildSupportBalance() => !_childSupportBalance.Clean;
        private Value<string> _cHUMSForAppraisal;
        public string CHUMSForAppraisal { get { return _cHUMSForAppraisal; } set { _cHUMSForAppraisal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCHUMSForAppraisal() => !_cHUMSForAppraisal.Clean;
        private Value<decimal?> _commitmentMaximumMortgageAmount;
        public decimal? CommitmentMaximumMortgageAmount { get { return _commitmentMaximumMortgageAmount; } set { _commitmentMaximumMortgageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentMaximumMortgageAmount() => !_commitmentMaximumMortgageAmount.Clean;
        private Value<string> _commitmentStage;
        public string CommitmentStage { get { return _commitmentStage; } set { _commitmentStage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentStage() => !_commitmentStage.Clean;
        private Value<decimal?> _constructionRepairsRehabilitationCosts;
        public decimal? ConstructionRepairsRehabilitationCosts { get { return _constructionRepairsRehabilitationCosts; } set { _constructionRepairsRehabilitationCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionRepairsRehabilitationCosts() => !_constructionRepairsRehabilitationCosts.Clean;
        private Value<decimal?> _contingencyReserveCostsAmount;
        public decimal? ContingencyReserveCostsAmount { get { return _contingencyReserveCostsAmount; } set { _contingencyReserveCostsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContingencyReserveCostsAmount() => !_contingencyReserveCostsAmount.Clean;
        private Value<decimal?> _contingencyReserveCostsPercent;
        public decimal? ContingencyReserveCostsPercent { get { return _contingencyReserveCostsPercent; } set { _contingencyReserveCostsPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContingencyReserveCostsPercent() => !_contingencyReserveCostsPercent.Clean;
        private Value<decimal?> _contractSalesPrice;
        public decimal? ContractSalesPrice { get { return _contractSalesPrice; } set { _contractSalesPrice = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractSalesPrice() => !_contractSalesPrice.Clean;
        private Value<string> _criteriaForAppropriateLTVFactor;
        public string CriteriaForAppropriateLTVFactor { get { return _criteriaForAppropriateLTVFactor; } set { _criteriaForAppropriateLTVFactor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCriteriaForAppropriateLTVFactor() => !_criteriaForAppropriateLTVFactor.Clean;
        private Value<string> _dealerContractorAddress;
        public string DealerContractorAddress { get { return _dealerContractorAddress; } set { _dealerContractorAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorAddress() => !_dealerContractorAddress.Clean;
        private Value<string> _dealerContractorCity;
        public string DealerContractorCity { get { return _dealerContractorCity; } set { _dealerContractorCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorCity() => !_dealerContractorCity.Clean;
        private Value<string> _dealerContractorName;
        public string DealerContractorName { get { return _dealerContractorName; } set { _dealerContractorName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorName() => !_dealerContractorName.Clean;
        private Value<string> _dealerContractorPostalCode;
        public string DealerContractorPostalCode { get { return _dealerContractorPostalCode; } set { _dealerContractorPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorPostalCode() => !_dealerContractorPostalCode.Clean;
        private Value<string> _dealerContractorState;
        public string DealerContractorState { get { return _dealerContractorState; } set { _dealerContractorState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDealerContractorState() => !_dealerContractorState.Clean;
        private Value<decimal?> _discountPointsAmount;
        public decimal? DiscountPointsAmount { get { return _discountPointsAmount; } set { _discountPointsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointsAmount() => !_discountPointsAmount.Clean;
        private Value<decimal?> _discountPointsPercent;
        public decimal? DiscountPointsPercent { get { return _discountPointsPercent; } set { _discountPointsPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointsPercent() => !_discountPointsPercent.Clean;
        private Value<bool?> _eEMIndicator;
        public bool? EEMIndicator { get { return _eEMIndicator; } set { _eEMIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEEMIndicator() => !_eEMIndicator.Clean;
        private Value<decimal?> _energyEfficientMortgageAmount;
        public decimal? EnergyEfficientMortgageAmount { get { return _energyEfficientMortgageAmount; } set { _energyEfficientMortgageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageAmount() => !_energyEfficientMortgageAmount.Clean;
        private Value<string> _escrowCommitment;
        public string EscrowCommitment { get { return _escrowCommitment; } set { _escrowCommitment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowCommitment() => !_escrowCommitment.Clean;
        private Value<bool?> _existingDebt;
        public bool? ExistingDebt { get { return _existingDebt; } set { _existingDebt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebt() => !_existingDebt.Clean;
        private Value<decimal?> _existingDebtPlusRehabCosts;
        public decimal? ExistingDebtPlusRehabCosts { get { return _existingDebtPlusRehabCosts; } set { _existingDebtPlusRehabCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebtPlusRehabCosts() => !_existingDebtPlusRehabCosts.Clean;
        private Value<decimal?> _existingDebtPlusRehabCostsPlusNewLoanFees;
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get { return _existingDebtPlusRehabCostsPlusNewLoanFees; } set { _existingDebtPlusRehabCostsPlusNewLoanFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebtPlusRehabCostsPlusNewLoanFees() => !_existingDebtPlusRehabCostsPlusNewLoanFees.Clean;
        private Value<decimal?> _feasibilityStudyWhenNecessary;
        public decimal? FeasibilityStudyWhenNecessary { get { return _feasibilityStudyWhenNecessary; } set { _feasibilityStudyWhenNecessary = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeasibilityStudyWhenNecessary() => !_feasibilityStudyWhenNecessary.Clean;
        private Value<decimal?> _feesAssociatedWithNewLoan;
        public decimal? FeesAssociatedWithNewLoan { get { return _feesAssociatedWithNewLoan; } set { _feesAssociatedWithNewLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeesAssociatedWithNewLoan() => !_feesAssociatedWithNewLoan.Clean;
        private Value<decimal?> _fHA203kB10SubTotal;
        public decimal? FHA203kB10SubTotal { get { return _fHA203kB10SubTotal; } set { _fHA203kB10SubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHA203kB10SubTotal() => !_fHA203kB10SubTotal.Clean;
        private Value<string> _fHA203kRemarks;
        public string FHA203kRemarks { get { return _fHA203kRemarks; } set { _fHA203kRemarks = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHA203kRemarks() => !_fHA203kRemarks.Clean;
        private Value<string> _fHAStreamlineType;
        public string FHAStreamlineType { get { return _fHAStreamlineType; } set { _fHAStreamlineType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAStreamlineType() => !_fHAStreamlineType.Clean;
        private Value<decimal?> _finalBaseMortgageAmount;
        public decimal? FinalBaseMortgageAmount { get { return _finalBaseMortgageAmount; } set { _finalBaseMortgageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalBaseMortgageAmount() => !_finalBaseMortgageAmount.Clean;
        private Value<decimal?> _financeableMortgageFeesIfCharged;
        public decimal? FinanceableMortgageFeesIfCharged { get { return _financeableMortgageFeesIfCharged; } set { _financeableMortgageFeesIfCharged = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceableMortgageFeesIfCharged() => !_financeableMortgageFeesIfCharged.Clean;
        private Value<bool?> _haveOtherPendingApplicationForFHA;
        public bool? HaveOtherPendingApplicationForFHA { get { return _haveOtherPendingApplicationForFHA; } set { _haveOtherPendingApplicationForFHA = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHaveOtherPendingApplicationForFHA() => !_haveOtherPendingApplicationForFHA.Clean;
        private Value<bool?> _hUDOwned;
        public bool? HUDOwned { get { return _hUDOwned; } set { _hUDOwned = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUDOwned() => !_hUDOwned.Clean;
        private Value<bool?> _hUDREOIndicator;
        public bool? HUDREOIndicator { get { return _hUDREOIndicator; } set { _hUDREOIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUDREOIndicator() => !_hUDREOIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _independentConsultantFee;
        public decimal? IndependentConsultantFee { get { return _independentConsultantFee; } set { _independentConsultantFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndependentConsultantFee() => !_independentConsultantFee.Clean;
        private Value<decimal?> _initialBaseMortgageAmountPlusEEMImprovementAmount;
        public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get { return _initialBaseMortgageAmountPlusEEMImprovementAmount; } set { _initialBaseMortgageAmountPlusEEMImprovementAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialBaseMortgageAmountPlusEEMImprovementAmount() => !_initialBaseMortgageAmountPlusEEMImprovementAmount.Clean;
        private Value<decimal?> _initialDrawAtClosingTotal;
        public decimal? InitialDrawAtClosingTotal { get { return _initialDrawAtClosingTotal; } set { _initialDrawAtClosingTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialDrawAtClosingTotal() => !_initialDrawAtClosingTotal.Clean;
        private Value<decimal?> _inspectionFeeAmount;
        public decimal? InspectionFeeAmount { get { return _inspectionFeeAmount; } set { _inspectionFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeAmount() => !_inspectionFeeAmount.Clean;
        private Value<decimal?> _inspectionFeesDuringRehabilitation;
        public decimal? InspectionFeesDuringRehabilitation { get { return _inspectionFeesDuringRehabilitation; } set { _inspectionFeesDuringRehabilitation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeesDuringRehabilitation() => !_inspectionFeesDuringRehabilitation.Clean;
        private Value<int?> _inspectionFeeTimes;
        public int? InspectionFeeTimes { get { return _inspectionFeeTimes; } set { _inspectionFeeTimes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeTimes() => !_inspectionFeeTimes.Clean;
        private Value<bool?> _lDPGSAForBorrower;
        public bool? LDPGSAForBorrower { get { return _lDPGSAForBorrower; } set { _lDPGSAForBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSAForBorrower() => !_lDPGSAForBorrower.Clean;
        private Value<bool?> _lDPGSAForCoBorrower;
        public bool? LDPGSAForCoBorrower { get { return _lDPGSAForCoBorrower; } set { _lDPGSAForCoBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSAForCoBorrower() => !_lDPGSAForCoBorrower.Clean;
        private Value<bool?> _leasedFromSomeoneElse;
        public bool? LeasedFromSomeoneElse { get { return _leasedFromSomeoneElse; } set { _leasedFromSomeoneElse = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeasedFromSomeoneElse() => !_leasedFromSomeoneElse.Clean;
        private Value<DateTime?> _leaseExpiradionDate;
        public DateTime? LeaseExpiradionDate { get { return _leaseExpiradionDate; } set { _leaseExpiradionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseExpiradionDate() => !_leaseExpiradionDate.Clean;
        private Value<decimal?> _leaseMonthlyPayment;
        public decimal? LeaseMonthlyPayment { get { return _leaseMonthlyPayment; } set { _leaseMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseMonthlyPayment() => !_leaseMonthlyPayment.Clean;
        private Value<decimal?> _lessAllowableDownpayment;
        public decimal? LessAllowableDownpayment { get { return _lessAllowableDownpayment; } set { _lessAllowableDownpayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLessAllowableDownpayment() => !_lessAllowableDownpayment.Clean;
        private Value<decimal?> _lesserOf3AOr3B;
        public decimal? LesserOf3AOr3B { get { return _lesserOf3AOr3B; } set { _lesserOf3AOr3B = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOf3AOr3B() => !_lesserOf3AOr3B.Clean;
        private Value<decimal?> _lesserOf3AOr3BMultiply3F;
        public decimal? LesserOf3AOr3BMultiply3F { get { return _lesserOf3AOr3BMultiply3F; } set { _lesserOf3AOr3BMultiply3F = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOf3AOr3BMultiply3F() => !_lesserOf3AOr3BMultiply3F.Clean;
        private Value<decimal?> _lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get { return _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; } set { _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfMaximumFinanceableSolarOrWindEnergyAmount() => !_lesserOfMaximumFinanceableSolarOrWindEnergyAmount.Clean;
        private Value<decimal?> _lesserOfSalesPrice;
        public decimal? LesserOfSalesPrice { get { return _lesserOfSalesPrice; } set { _lesserOfSalesPrice = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSalesPrice() => !_lesserOfSalesPrice.Clean;
        private Value<decimal?> _lesserOfSumAmount;
        public decimal? LesserOfSumAmount { get { return _lesserOfSumAmount; } set { _lesserOfSumAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumAmount() => !_lesserOfSumAmount.Clean;
        private Value<decimal?> _lesserOfSumAsIs;
        public decimal? LesserOfSumAsIs { get { return _lesserOfSumAsIs; } set { _lesserOfSumAsIs = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumAsIs() => !_lesserOfSumAsIs.Clean;
        private Value<decimal?> _lesserOfSumPercent;
        public decimal? LesserOfSumPercent { get { return _lesserOfSumPercent; } set { _lesserOfSumPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserOfSumPercent() => !_lesserOfSumPercent.Clean;
        private Value<bool?> _limitedProgram;
        public bool? LimitedProgram { get { return _limitedProgram; } set { _limitedProgram = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitedProgram() => !_limitedProgram.Clean;
        private Value<bool?> _loanFor203KIndicator;
        public bool? LoanFor203KIndicator { get { return _loanFor203KIndicator; } set { _loanFor203KIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFor203KIndicator() => !_loanFor203KIndicator.Clean;
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurpose() => !_loanPurpose.Clean;
        private Value<decimal?> _materialCostsOrderedPrepaidByBorrowerContractor;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get { return _materialCostsOrderedPrepaidByBorrowerContractor; } set { _materialCostsOrderedPrepaidByBorrowerContractor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaterialCostsOrderedPrepaidByBorrowerContractor() => !_materialCostsOrderedPrepaidByBorrowerContractor.Clean;
        private Value<decimal?> _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get { return _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; } set { _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent() => !_materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean;
        private Value<decimal?> _maximumMortgageWithUFMIP;
        public decimal? MaximumMortgageWithUFMIP { get { return _maximumMortgageWithUFMIP; } set { _maximumMortgageWithUFMIP = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumMortgageWithUFMIP() => !_maximumMortgageWithUFMIP.Clean;
        private Value<decimal?> _mIPLTV;
        public decimal? MIPLTV { get { return _mIPLTV; } set { _mIPLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPLTV() => !_mIPLTV.Clean;
        private Value<bool?> _mtgOrDeedOfTrusOnProperty;
        public bool? MtgOrDeedOfTrusOnProperty { get { return _mtgOrDeedOfTrusOnProperty; } set { _mtgOrDeedOfTrusOnProperty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgOrDeedOfTrusOnProperty() => !_mtgOrDeedOfTrusOnProperty.Clean;
        private Value<decimal?> _mtgPaymentEscrowedAmount;
        public decimal? MtgPaymentEscrowedAmount { get { return _mtgPaymentEscrowedAmount; } set { _mtgPaymentEscrowedAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgPaymentEscrowedAmount() => !_mtgPaymentEscrowedAmount.Clean;
        private Value<int?> _mtgPaymentEscrowedTimes;
        public int? MtgPaymentEscrowedTimes { get { return _mtgPaymentEscrowedTimes; } set { _mtgPaymentEscrowedTimes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgPaymentEscrowedTimes() => !_mtgPaymentEscrowedTimes.Clean;
        private Value<decimal?> _nationwideMortgageLimit;
        public decimal? NationwideMortgageLimit { get { return _nationwideMortgageLimit; } set { _nationwideMortgageLimit = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNationwideMortgageLimit() => !_nationwideMortgageLimit.Clean;
        private Value<decimal?> _nationwideMortgageLimitAfter120Percent;
        public decimal? NationwideMortgageLimitAfter120Percent { get { return _nationwideMortgageLimitAfter120Percent; } set { _nationwideMortgageLimitAfter120Percent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNationwideMortgageLimitAfter120Percent() => !_nationwideMortgageLimitAfter120Percent.Clean;
        private Value<bool?> _newResidential;
        public bool? NewResidential { get { return _newResidential; } set { _newResidential = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewResidential() => !_newResidential.Clean;
        private Value<string> _nonresidentialTypeOfUse;
        public string NonresidentialTypeOfUse { get { return _nonresidentialTypeOfUse; } set { _nonresidentialTypeOfUse = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonresidentialTypeOfUse() => !_nonresidentialTypeOfUse.Clean;
        private Value<int?> _numberOfHistoricUnits;
        public int? NumberOfHistoricUnits { get { return _numberOfHistoricUnits; } set { _numberOfHistoricUnits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfHistoricUnits() => !_numberOfHistoricUnits.Clean;
        private Value<int?> _numberOfMultifamilyUnits;
        public int? NumberOfMultifamilyUnits { get { return _numberOfMultifamilyUnits; } set { _numberOfMultifamilyUnits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMultifamilyUnits() => !_numberOfMultifamilyUnits.Clean;
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !_otherDescription.Clean;
        private Value<bool?> _ownedByBorrower;
        public bool? OwnedByBorrower { get { return _ownedByBorrower; } set { _ownedByBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnedByBorrower() => !_ownedByBorrower.Clean;
        private Value<decimal?> _percentAfterImprovedValue;
        public decimal? PercentAfterImprovedValue { get { return _percentAfterImprovedValue; } set { _percentAfterImprovedValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentAfterImprovedValue() => !_percentAfterImprovedValue.Clean;
        private Value<decimal?> _permitsAndOtherFee;
        public decimal? PermitsAndOtherFee { get { return _permitsAndOtherFee; } set { _permitsAndOtherFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePermitsAndOtherFee() => !_permitsAndOtherFee.Clean;
        private Value<decimal?> _planReviewerFeeAddition;
        public decimal? PlanReviewerFeeAddition { get { return _planReviewerFeeAddition; } set { _planReviewerFeeAddition = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeAddition() => !_planReviewerFeeAddition.Clean;
        private Value<decimal?> _planReviewerFeeAmount;
        public decimal? PlanReviewerFeeAmount { get { return _planReviewerFeeAmount; } set { _planReviewerFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeAmount() => !_planReviewerFeeAmount.Clean;
        private Value<int?> _planReviewerFeeMiles;
        public int? PlanReviewerFeeMiles { get { return _planReviewerFeeMiles; } set { _planReviewerFeeMiles = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanReviewerFeeMiles() => !_planReviewerFeeMiles.Clean;
        private Value<string> _propertyOwnerAddress;
        public string PropertyOwnerAddress { get { return _propertyOwnerAddress; } set { _propertyOwnerAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerAddress() => !_propertyOwnerAddress.Clean;
        private Value<string> _propertyOwnerCity;
        public string PropertyOwnerCity { get { return _propertyOwnerCity; } set { _propertyOwnerCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerCity() => !_propertyOwnerCity.Clean;
        private Value<string> _propertyOwnerName;
        public string PropertyOwnerName { get { return _propertyOwnerName; } set { _propertyOwnerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerName() => !_propertyOwnerName.Clean;
        private Value<string> _propertyOwnerPostalCode;
        public string PropertyOwnerPostalCode { get { return _propertyOwnerPostalCode; } set { _propertyOwnerPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerPostalCode() => !_propertyOwnerPostalCode.Clean;
        private Value<string> _propertyOwnerState;
        public string PropertyOwnerState { get { return _propertyOwnerState; } set { _propertyOwnerState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOwnerState() => !_propertyOwnerState.Clean;
        private Value<string> _propertyToBeImproved;
        public string PropertyToBeImproved { get { return _propertyToBeImproved; } set { _propertyToBeImproved = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyToBeImproved() => !_propertyToBeImproved.Clean;
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyType() => !_propertyType.Clean;
        private Value<DateTime?> _purchaseDate;
        public DateTime? PurchaseDate { get { return _purchaseDate; } set { _purchaseDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseDate() => !_purchaseDate.Clean;
        private Value<bool?> _purchasedOnContract;
        public bool? PurchasedOnContract { get { return _purchasedOnContract; } set { _purchasedOnContract = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasedOnContract() => !_purchasedOnContract.Clean;
        private Value<decimal?> _purchaseMaximumMortgageAmount;
        public decimal? PurchaseMaximumMortgageAmount { get { return _purchaseMaximumMortgageAmount; } set { _purchaseMaximumMortgageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseMaximumMortgageAmount() => !_purchaseMaximumMortgageAmount.Clean;
        private Value<decimal?> _purchaseMaximumMortgagePercent;
        public decimal? PurchaseMaximumMortgagePercent { get { return _purchaseMaximumMortgagePercent; } set { _purchaseMaximumMortgagePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseMaximumMortgagePercent() => !_purchaseMaximumMortgagePercent.Clean;
        private Value<decimal?> _purchasePriceLessInducementToPurchase;
        public decimal? PurchasePriceLessInducementToPurchase { get { return _purchasePriceLessInducementToPurchase; } set { _purchasePriceLessInducementToPurchase = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceLessInducementToPurchase() => !_purchasePriceLessInducementToPurchase.Clean;
        private Value<decimal?> _refinanceMaximumMortgageAmount;
        public decimal? RefinanceMaximumMortgageAmount { get { return _refinanceMaximumMortgageAmount; } set { _refinanceMaximumMortgageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceMaximumMortgageAmount() => !_refinanceMaximumMortgageAmount.Clean;
        private Value<bool?> _refinancingATitleILoan;
        public bool? RefinancingATitleILoan { get { return _refinancingATitleILoan; } set { _refinancingATitleILoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancingATitleILoan() => !_refinancingATitleILoan.Clean;
        private Value<decimal?> _rehabilitationEscrowAccount;
        public decimal? RehabilitationEscrowAccount { get { return _rehabilitationEscrowAccount; } set { _rehabilitationEscrowAccount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRehabilitationEscrowAccount() => !_rehabilitationEscrowAccount.Clean;
        private Value<decimal?> _rehabilitationEscrowAmountBalanceForFutureDraws;
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get { return _rehabilitationEscrowAmountBalanceForFutureDraws; } set { _rehabilitationEscrowAmountBalanceForFutureDraws = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRehabilitationEscrowAmountBalanceForFutureDraws() => !_rehabilitationEscrowAmountBalanceForFutureDraws.Clean;
        private Value<decimal?> _rentalCashFlowBalance;
        public decimal? RentalCashFlowBalance { get { return _rentalCashFlowBalance; } set { _rentalCashFlowBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRentalCashFlowBalance() => !_rentalCashFlowBalance.Clean;
        private Value<string> _residencyType;
        public string ResidencyType { get { return _residencyType; } set { _residencyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyType() => !_residencyType.Clean;
        private Value<string> _riskClass;
        public string RiskClass { get { return _riskClass; } set { _riskClass = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskClass() => !_riskClass.Clean;
        private Value<bool?> _scoredByTotal;
        public bool? ScoredByTotal { get { return _scoredByTotal; } set { _scoredByTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScoredByTotal() => !_scoredByTotal.Clean;
        private Value<List<SecondaryFinancingProvider>> _secondaryFinancingProviders;
        public List<SecondaryFinancingProvider> SecondaryFinancingProviders { get { return _secondaryFinancingProviders; } set { _secondaryFinancingProviders = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondaryFinancingProviders() => !_secondaryFinancingProviders.Clean;
        private Value<decimal?> _sellerContributionRate;
        public decimal? SellerContributionRate { get { return _sellerContributionRate; } set { _sellerContributionRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerContributionRate() => !_sellerContributionRate.Clean;
        private Value<bool?> _simpleRefinance;
        public bool? SimpleRefinance { get { return _simpleRefinance; } set { _simpleRefinance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSimpleRefinance() => !_simpleRefinance.Clean;
        private Value<decimal?> _statutoryInvestment;
        public decimal? StatutoryInvestment { get { return _statutoryInvestment; } set { _statutoryInvestment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatutoryInvestment() => !_statutoryInvestment.Clean;
        private Value<decimal?> _step2EPlusStep1E;
        public decimal? Step2EPlusStep1E { get { return _step2EPlusStep1E; } set { _step2EPlusStep1E = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStep2EPlusStep1E() => !_step2EPlusStep1E.Clean;
        private Value<bool?> _streamlined;
        public bool? Streamlined { get { return _streamlined; } set { _streamlined = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreamlined() => !_streamlined.Clean;
        private Value<decimal?> _subTotalForEscrowAccount;
        public decimal? SubTotalForEscrowAccount { get { return _subTotalForEscrowAccount; } set { _subTotalForEscrowAccount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTotalForEscrowAccount() => !_subTotalForEscrowAccount.Clean;
        private Value<decimal?> _subTotalForReleaseAtClosing;
        public decimal? SubTotalForReleaseAtClosing { get { return _subTotalForReleaseAtClosing; } set { _subTotalForReleaseAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTotalForReleaseAtClosing() => !_subTotalForReleaseAtClosing.Clean;
        private Value<decimal?> _sumForInvestor;
        public decimal? SumForInvestor { get { return _sumForInvestor; } set { _sumForInvestor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumForInvestor() => !_sumForInvestor.Clean;
        private Value<decimal?> _sumForOwnerOccupied;
        public decimal? SumForOwnerOccupied { get { return _sumForOwnerOccupied; } set { _sumForOwnerOccupied = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumForOwnerOccupied() => !_sumForOwnerOccupied.Clean;
        private Value<decimal?> _sumOfExistingDebt;
        public decimal? SumOfExistingDebt { get { return _sumOfExistingDebt; } set { _sumOfExistingDebt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSumOfExistingDebt() => !_sumOfExistingDebt.Clean;
        private Value<decimal?> _suplementalOriginationFee;
        public decimal? SuplementalOriginationFee { get { return _suplementalOriginationFee; } set { _suplementalOriginationFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuplementalOriginationFee() => !_suplementalOriginationFee.Clean;
        private Value<decimal?> _title1LoanBalance;
        public decimal? Title1LoanBalance { get { return _title1LoanBalance; } set { _title1LoanBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanBalance() => !_title1LoanBalance.Clean;
        private Value<string> _title1LoanNumber;
        public string Title1LoanNumber { get { return _title1LoanNumber; } set { _title1LoanNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanNumber() => !_title1LoanNumber.Clean;
        private Value<string> _title1LoanWithWhom;
        public string Title1LoanWithWhom { get { return _title1LoanWithWhom; } set { _title1LoanWithWhom = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle1LoanWithWhom() => !_title1LoanWithWhom.Clean;
        private Value<decimal?> _titleUpdateFeeAmount;
        public decimal? TitleUpdateFeeAmount { get { return _titleUpdateFeeAmount; } set { _titleUpdateFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFeeAmount() => !_titleUpdateFeeAmount.Clean;
        private Value<decimal?> _titleUpdateFees;
        public decimal? TitleUpdateFees { get { return _titleUpdateFees; } set { _titleUpdateFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFees() => !_titleUpdateFees.Clean;
        private Value<int?> _titleUpdateFeeTimes;
        public int? TitleUpdateFeeTimes { get { return _titleUpdateFeeTimes; } set { _titleUpdateFeeTimes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleUpdateFeeTimes() => !_titleUpdateFeeTimes.Clean;
        private Value<decimal?> _totalCostsOfRepairsInA6;
        public decimal? TotalCostsOfRepairsInA6 { get { return _totalCostsOfRepairsInA6; } set { _totalCostsOfRepairsInA6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCostsOfRepairsInA6() => !_totalCostsOfRepairsInA6.Clean;
        private Value<decimal?> _totalEscrowCommitment;
        public decimal? TotalEscrowCommitment { get { return _totalEscrowCommitment; } set { _totalEscrowCommitment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowCommitment() => !_totalEscrowCommitment.Clean;
        private Value<decimal?> _totalEscrowedFunds;
        public decimal? TotalEscrowedFunds { get { return _totalEscrowedFunds; } set { _totalEscrowedFunds = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowedFunds() => !_totalEscrowedFunds.Clean;
        private Value<decimal?> _totalFixedUnpaidBalance;
        public decimal? TotalFixedUnpaidBalance { get { return _totalFixedUnpaidBalance; } set { _totalFixedUnpaidBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFixedUnpaidBalance() => !_totalFixedUnpaidBalance.Clean;
        private Value<decimal?> _totalForBorrowerEstimatedProfit;
        public decimal? TotalForBorrowerEstimatedProfit { get { return _totalForBorrowerEstimatedProfit; } set { _totalForBorrowerEstimatedProfit = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorrowerEstimatedProfit() => !_totalForBorrowerEstimatedProfit.Clean;
        private Value<decimal?> _totalForInspectionAndTitleFee;
        public decimal? TotalForInspectionAndTitleFee { get { return _totalForInspectionAndTitleFee; } set { _totalForInspectionAndTitleFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForInspectionAndTitleFee() => !_totalForInspectionAndTitleFee.Clean;
        private Value<decimal?> _totalForLesserOfSumAsIs;
        public decimal? TotalForLesserOfSumAsIs { get { return _totalForLesserOfSumAsIs; } set { _totalForLesserOfSumAsIs = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForLesserOfSumAsIs() => !_totalForLesserOfSumAsIs.Clean;
        private Value<decimal?> _totalForMtgPaymentEscrowed;
        public decimal? TotalForMtgPaymentEscrowed { get { return _totalForMtgPaymentEscrowed; } set { _totalForMtgPaymentEscrowed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForMtgPaymentEscrowed() => !_totalForMtgPaymentEscrowed.Clean;
        private Value<decimal?> _totalForPlanReviewerFee;
        public decimal? TotalForPlanReviewerFee { get { return _totalForPlanReviewerFee; } set { _totalForPlanReviewerFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForPlanReviewerFee() => !_totalForPlanReviewerFee.Clean;
        private Value<decimal?> _totalForRehabilitationCost;
        public decimal? TotalForRehabilitationCost { get { return _totalForRehabilitationCost; } set { _totalForRehabilitationCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForRehabilitationCost() => !_totalForRehabilitationCost.Clean;
        private Value<decimal?> _totalRehabilitationCosts;
        public decimal? TotalRehabilitationCosts { get { return _totalRehabilitationCosts; } set { _totalRehabilitationCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRehabilitationCosts() => !_totalRehabilitationCosts.Clean;
        private Value<decimal?> _totalRehabilitationCostsFeesReserves;
        public decimal? TotalRehabilitationCostsFeesReserves { get { return _totalRehabilitationCostsFeesReserves; } set { _totalRehabilitationCostsFeesReserves = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRehabilitationCostsFeesReserves() => !_totalRehabilitationCostsFeesReserves.Clean;
        private Value<decimal?> _valueEstablished;
        public decimal? ValueEstablished { get { return _valueEstablished; } set { _valueEstablished = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValueEstablished() => !_valueEstablished.Clean;
        private Value<decimal?> _windEnergySystemActualCost;
        public decimal? WindEnergySystemActualCost { get { return _windEnergySystemActualCost; } set { _windEnergySystemActualCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWindEnergySystemActualCost() => !_windEnergySystemActualCost.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualCashInvRequired.Clean
                    && _adjustedMaxMtgAmount.Clean
                    && _afterImprovedValue.Clean
                    && _afterImprovedValueAfter20Percent.Clean
                    && _allowableEnergyImprovements.Clean
                    && _appropriateLTVFactor.Clean
                    && _architecturalEngineeringFee.Clean
                    && _asIsValue.Clean
                    && _baseMortgageAmountFrom3COr3D.Clean
                    && _borrowerAcknowledgement.Clean
                    && _borrowerEstimatedProfit1.Clean
                    && _borrowerEstimatedProfit2.Clean
                    && _borrowerPaidClosingCosts.Clean
                    && _borrowerRequiredInvestment.Clean
                    && _borrowersOwnFundsforContingencyReserves.Clean
                    && _buildingOnOwnLand.Clean
                    && _caseAssignedDate.Clean
                    && _childSupportBalance.Clean
                    && _cHUMSForAppraisal.Clean
                    && _commitmentMaximumMortgageAmount.Clean
                    && _commitmentStage.Clean
                    && _constructionRepairsRehabilitationCosts.Clean
                    && _contingencyReserveCostsAmount.Clean
                    && _contingencyReserveCostsPercent.Clean
                    && _contractSalesPrice.Clean
                    && _criteriaForAppropriateLTVFactor.Clean
                    && _dealerContractorAddress.Clean
                    && _dealerContractorCity.Clean
                    && _dealerContractorName.Clean
                    && _dealerContractorPostalCode.Clean
                    && _dealerContractorState.Clean
                    && _discountPointsAmount.Clean
                    && _discountPointsPercent.Clean
                    && _eEMIndicator.Clean
                    && _energyEfficientMortgageAmount.Clean
                    && _escrowCommitment.Clean
                    && _existingDebt.Clean
                    && _existingDebtPlusRehabCosts.Clean
                    && _existingDebtPlusRehabCostsPlusNewLoanFees.Clean
                    && _feasibilityStudyWhenNecessary.Clean
                    && _feesAssociatedWithNewLoan.Clean
                    && _fHA203kB10SubTotal.Clean
                    && _fHA203kRemarks.Clean
                    && _fHAStreamlineType.Clean
                    && _finalBaseMortgageAmount.Clean
                    && _financeableMortgageFeesIfCharged.Clean
                    && _haveOtherPendingApplicationForFHA.Clean
                    && _hUDOwned.Clean
                    && _hUDREOIndicator.Clean
                    && _id.Clean
                    && _independentConsultantFee.Clean
                    && _initialBaseMortgageAmountPlusEEMImprovementAmount.Clean
                    && _initialDrawAtClosingTotal.Clean
                    && _inspectionFeeAmount.Clean
                    && _inspectionFeesDuringRehabilitation.Clean
                    && _inspectionFeeTimes.Clean
                    && _lDPGSAForBorrower.Clean
                    && _lDPGSAForCoBorrower.Clean
                    && _leasedFromSomeoneElse.Clean
                    && _leaseExpiradionDate.Clean
                    && _leaseMonthlyPayment.Clean
                    && _lessAllowableDownpayment.Clean
                    && _lesserOf3AOr3B.Clean
                    && _lesserOf3AOr3BMultiply3F.Clean
                    && _lesserOfMaximumFinanceableSolarOrWindEnergyAmount.Clean
                    && _lesserOfSalesPrice.Clean
                    && _lesserOfSumAmount.Clean
                    && _lesserOfSumAsIs.Clean
                    && _lesserOfSumPercent.Clean
                    && _limitedProgram.Clean
                    && _loanFor203KIndicator.Clean
                    && _loanPurpose.Clean
                    && _materialCostsOrderedPrepaidByBorrowerContractor.Clean
                    && _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean
                    && _maximumMortgageWithUFMIP.Clean
                    && _mIPLTV.Clean
                    && _mtgOrDeedOfTrusOnProperty.Clean
                    && _mtgPaymentEscrowedAmount.Clean
                    && _mtgPaymentEscrowedTimes.Clean
                    && _nationwideMortgageLimit.Clean
                    && _nationwideMortgageLimitAfter120Percent.Clean
                    && _newResidential.Clean
                    && _nonresidentialTypeOfUse.Clean
                    && _numberOfHistoricUnits.Clean
                    && _numberOfMultifamilyUnits.Clean
                    && _otherDescription.Clean
                    && _ownedByBorrower.Clean
                    && _percentAfterImprovedValue.Clean
                    && _permitsAndOtherFee.Clean
                    && _planReviewerFeeAddition.Clean
                    && _planReviewerFeeAmount.Clean
                    && _planReviewerFeeMiles.Clean
                    && _propertyOwnerAddress.Clean
                    && _propertyOwnerCity.Clean
                    && _propertyOwnerName.Clean
                    && _propertyOwnerPostalCode.Clean
                    && _propertyOwnerState.Clean
                    && _propertyToBeImproved.Clean
                    && _propertyType.Clean
                    && _purchaseDate.Clean
                    && _purchasedOnContract.Clean
                    && _purchaseMaximumMortgageAmount.Clean
                    && _purchaseMaximumMortgagePercent.Clean
                    && _purchasePriceLessInducementToPurchase.Clean
                    && _refinanceMaximumMortgageAmount.Clean
                    && _refinancingATitleILoan.Clean
                    && _rehabilitationEscrowAccount.Clean
                    && _rehabilitationEscrowAmountBalanceForFutureDraws.Clean
                    && _rentalCashFlowBalance.Clean
                    && _residencyType.Clean
                    && _riskClass.Clean
                    && _scoredByTotal.Clean
                    && _secondaryFinancingProviders.Clean
                    && _sellerContributionRate.Clean
                    && _simpleRefinance.Clean
                    && _statutoryInvestment.Clean
                    && _step2EPlusStep1E.Clean
                    && _streamlined.Clean
                    && _subTotalForEscrowAccount.Clean
                    && _subTotalForReleaseAtClosing.Clean
                    && _sumForInvestor.Clean
                    && _sumForOwnerOccupied.Clean
                    && _sumOfExistingDebt.Clean
                    && _suplementalOriginationFee.Clean
                    && _title1LoanBalance.Clean
                    && _title1LoanNumber.Clean
                    && _title1LoanWithWhom.Clean
                    && _titleUpdateFeeAmount.Clean
                    && _titleUpdateFees.Clean
                    && _titleUpdateFeeTimes.Clean
                    && _totalCostsOfRepairsInA6.Clean
                    && _totalEscrowCommitment.Clean
                    && _totalEscrowedFunds.Clean
                    && _totalFixedUnpaidBalance.Clean
                    && _totalForBorrowerEstimatedProfit.Clean
                    && _totalForInspectionAndTitleFee.Clean
                    && _totalForLesserOfSumAsIs.Clean
                    && _totalForMtgPaymentEscrowed.Clean
                    && _totalForPlanReviewerFee.Clean
                    && _totalForRehabilitationCost.Clean
                    && _totalRehabilitationCosts.Clean
                    && _totalRehabilitationCostsFeesReserves.Clean
                    && _valueEstablished.Clean
                    && _windEnergySystemActualCost.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actualCashInvRequired; v0.Clean = value; _actualCashInvRequired = v0;
                var v1 = _adjustedMaxMtgAmount; v1.Clean = value; _adjustedMaxMtgAmount = v1;
                var v2 = _afterImprovedValue; v2.Clean = value; _afterImprovedValue = v2;
                var v3 = _afterImprovedValueAfter20Percent; v3.Clean = value; _afterImprovedValueAfter20Percent = v3;
                var v4 = _allowableEnergyImprovements; v4.Clean = value; _allowableEnergyImprovements = v4;
                var v5 = _appropriateLTVFactor; v5.Clean = value; _appropriateLTVFactor = v5;
                var v6 = _architecturalEngineeringFee; v6.Clean = value; _architecturalEngineeringFee = v6;
                var v7 = _asIsValue; v7.Clean = value; _asIsValue = v7;
                var v8 = _baseMortgageAmountFrom3COr3D; v8.Clean = value; _baseMortgageAmountFrom3COr3D = v8;
                var v9 = _borrowerAcknowledgement; v9.Clean = value; _borrowerAcknowledgement = v9;
                var v10 = _borrowerEstimatedProfit1; v10.Clean = value; _borrowerEstimatedProfit1 = v10;
                var v11 = _borrowerEstimatedProfit2; v11.Clean = value; _borrowerEstimatedProfit2 = v11;
                var v12 = _borrowerPaidClosingCosts; v12.Clean = value; _borrowerPaidClosingCosts = v12;
                var v13 = _borrowerRequiredInvestment; v13.Clean = value; _borrowerRequiredInvestment = v13;
                var v14 = _borrowersOwnFundsforContingencyReserves; v14.Clean = value; _borrowersOwnFundsforContingencyReserves = v14;
                var v15 = _buildingOnOwnLand; v15.Clean = value; _buildingOnOwnLand = v15;
                var v16 = _caseAssignedDate; v16.Clean = value; _caseAssignedDate = v16;
                var v17 = _childSupportBalance; v17.Clean = value; _childSupportBalance = v17;
                var v18 = _cHUMSForAppraisal; v18.Clean = value; _cHUMSForAppraisal = v18;
                var v19 = _commitmentMaximumMortgageAmount; v19.Clean = value; _commitmentMaximumMortgageAmount = v19;
                var v20 = _commitmentStage; v20.Clean = value; _commitmentStage = v20;
                var v21 = _constructionRepairsRehabilitationCosts; v21.Clean = value; _constructionRepairsRehabilitationCosts = v21;
                var v22 = _contingencyReserveCostsAmount; v22.Clean = value; _contingencyReserveCostsAmount = v22;
                var v23 = _contingencyReserveCostsPercent; v23.Clean = value; _contingencyReserveCostsPercent = v23;
                var v24 = _contractSalesPrice; v24.Clean = value; _contractSalesPrice = v24;
                var v25 = _criteriaForAppropriateLTVFactor; v25.Clean = value; _criteriaForAppropriateLTVFactor = v25;
                var v26 = _dealerContractorAddress; v26.Clean = value; _dealerContractorAddress = v26;
                var v27 = _dealerContractorCity; v27.Clean = value; _dealerContractorCity = v27;
                var v28 = _dealerContractorName; v28.Clean = value; _dealerContractorName = v28;
                var v29 = _dealerContractorPostalCode; v29.Clean = value; _dealerContractorPostalCode = v29;
                var v30 = _dealerContractorState; v30.Clean = value; _dealerContractorState = v30;
                var v31 = _discountPointsAmount; v31.Clean = value; _discountPointsAmount = v31;
                var v32 = _discountPointsPercent; v32.Clean = value; _discountPointsPercent = v32;
                var v33 = _eEMIndicator; v33.Clean = value; _eEMIndicator = v33;
                var v34 = _energyEfficientMortgageAmount; v34.Clean = value; _energyEfficientMortgageAmount = v34;
                var v35 = _escrowCommitment; v35.Clean = value; _escrowCommitment = v35;
                var v36 = _existingDebt; v36.Clean = value; _existingDebt = v36;
                var v37 = _existingDebtPlusRehabCosts; v37.Clean = value; _existingDebtPlusRehabCosts = v37;
                var v38 = _existingDebtPlusRehabCostsPlusNewLoanFees; v38.Clean = value; _existingDebtPlusRehabCostsPlusNewLoanFees = v38;
                var v39 = _feasibilityStudyWhenNecessary; v39.Clean = value; _feasibilityStudyWhenNecessary = v39;
                var v40 = _feesAssociatedWithNewLoan; v40.Clean = value; _feesAssociatedWithNewLoan = v40;
                var v41 = _fHA203kB10SubTotal; v41.Clean = value; _fHA203kB10SubTotal = v41;
                var v42 = _fHA203kRemarks; v42.Clean = value; _fHA203kRemarks = v42;
                var v43 = _fHAStreamlineType; v43.Clean = value; _fHAStreamlineType = v43;
                var v44 = _finalBaseMortgageAmount; v44.Clean = value; _finalBaseMortgageAmount = v44;
                var v45 = _financeableMortgageFeesIfCharged; v45.Clean = value; _financeableMortgageFeesIfCharged = v45;
                var v46 = _haveOtherPendingApplicationForFHA; v46.Clean = value; _haveOtherPendingApplicationForFHA = v46;
                var v47 = _hUDOwned; v47.Clean = value; _hUDOwned = v47;
                var v48 = _hUDREOIndicator; v48.Clean = value; _hUDREOIndicator = v48;
                var v49 = _id; v49.Clean = value; _id = v49;
                var v50 = _independentConsultantFee; v50.Clean = value; _independentConsultantFee = v50;
                var v51 = _initialBaseMortgageAmountPlusEEMImprovementAmount; v51.Clean = value; _initialBaseMortgageAmountPlusEEMImprovementAmount = v51;
                var v52 = _initialDrawAtClosingTotal; v52.Clean = value; _initialDrawAtClosingTotal = v52;
                var v53 = _inspectionFeeAmount; v53.Clean = value; _inspectionFeeAmount = v53;
                var v54 = _inspectionFeesDuringRehabilitation; v54.Clean = value; _inspectionFeesDuringRehabilitation = v54;
                var v55 = _inspectionFeeTimes; v55.Clean = value; _inspectionFeeTimes = v55;
                var v56 = _lDPGSAForBorrower; v56.Clean = value; _lDPGSAForBorrower = v56;
                var v57 = _lDPGSAForCoBorrower; v57.Clean = value; _lDPGSAForCoBorrower = v57;
                var v58 = _leasedFromSomeoneElse; v58.Clean = value; _leasedFromSomeoneElse = v58;
                var v59 = _leaseExpiradionDate; v59.Clean = value; _leaseExpiradionDate = v59;
                var v60 = _leaseMonthlyPayment; v60.Clean = value; _leaseMonthlyPayment = v60;
                var v61 = _lessAllowableDownpayment; v61.Clean = value; _lessAllowableDownpayment = v61;
                var v62 = _lesserOf3AOr3B; v62.Clean = value; _lesserOf3AOr3B = v62;
                var v63 = _lesserOf3AOr3BMultiply3F; v63.Clean = value; _lesserOf3AOr3BMultiply3F = v63;
                var v64 = _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; v64.Clean = value; _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = v64;
                var v65 = _lesserOfSalesPrice; v65.Clean = value; _lesserOfSalesPrice = v65;
                var v66 = _lesserOfSumAmount; v66.Clean = value; _lesserOfSumAmount = v66;
                var v67 = _lesserOfSumAsIs; v67.Clean = value; _lesserOfSumAsIs = v67;
                var v68 = _lesserOfSumPercent; v68.Clean = value; _lesserOfSumPercent = v68;
                var v69 = _limitedProgram; v69.Clean = value; _limitedProgram = v69;
                var v70 = _loanFor203KIndicator; v70.Clean = value; _loanFor203KIndicator = v70;
                var v71 = _loanPurpose; v71.Clean = value; _loanPurpose = v71;
                var v72 = _materialCostsOrderedPrepaidByBorrowerContractor; v72.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractor = v72;
                var v73 = _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; v73.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = v73;
                var v74 = _maximumMortgageWithUFMIP; v74.Clean = value; _maximumMortgageWithUFMIP = v74;
                var v75 = _mIPLTV; v75.Clean = value; _mIPLTV = v75;
                var v76 = _mtgOrDeedOfTrusOnProperty; v76.Clean = value; _mtgOrDeedOfTrusOnProperty = v76;
                var v77 = _mtgPaymentEscrowedAmount; v77.Clean = value; _mtgPaymentEscrowedAmount = v77;
                var v78 = _mtgPaymentEscrowedTimes; v78.Clean = value; _mtgPaymentEscrowedTimes = v78;
                var v79 = _nationwideMortgageLimit; v79.Clean = value; _nationwideMortgageLimit = v79;
                var v80 = _nationwideMortgageLimitAfter120Percent; v80.Clean = value; _nationwideMortgageLimitAfter120Percent = v80;
                var v81 = _newResidential; v81.Clean = value; _newResidential = v81;
                var v82 = _nonresidentialTypeOfUse; v82.Clean = value; _nonresidentialTypeOfUse = v82;
                var v83 = _numberOfHistoricUnits; v83.Clean = value; _numberOfHistoricUnits = v83;
                var v84 = _numberOfMultifamilyUnits; v84.Clean = value; _numberOfMultifamilyUnits = v84;
                var v85 = _otherDescription; v85.Clean = value; _otherDescription = v85;
                var v86 = _ownedByBorrower; v86.Clean = value; _ownedByBorrower = v86;
                var v87 = _percentAfterImprovedValue; v87.Clean = value; _percentAfterImprovedValue = v87;
                var v88 = _permitsAndOtherFee; v88.Clean = value; _permitsAndOtherFee = v88;
                var v89 = _planReviewerFeeAddition; v89.Clean = value; _planReviewerFeeAddition = v89;
                var v90 = _planReviewerFeeAmount; v90.Clean = value; _planReviewerFeeAmount = v90;
                var v91 = _planReviewerFeeMiles; v91.Clean = value; _planReviewerFeeMiles = v91;
                var v92 = _propertyOwnerAddress; v92.Clean = value; _propertyOwnerAddress = v92;
                var v93 = _propertyOwnerCity; v93.Clean = value; _propertyOwnerCity = v93;
                var v94 = _propertyOwnerName; v94.Clean = value; _propertyOwnerName = v94;
                var v95 = _propertyOwnerPostalCode; v95.Clean = value; _propertyOwnerPostalCode = v95;
                var v96 = _propertyOwnerState; v96.Clean = value; _propertyOwnerState = v96;
                var v97 = _propertyToBeImproved; v97.Clean = value; _propertyToBeImproved = v97;
                var v98 = _propertyType; v98.Clean = value; _propertyType = v98;
                var v99 = _purchaseDate; v99.Clean = value; _purchaseDate = v99;
                var v100 = _purchasedOnContract; v100.Clean = value; _purchasedOnContract = v100;
                var v101 = _purchaseMaximumMortgageAmount; v101.Clean = value; _purchaseMaximumMortgageAmount = v101;
                var v102 = _purchaseMaximumMortgagePercent; v102.Clean = value; _purchaseMaximumMortgagePercent = v102;
                var v103 = _purchasePriceLessInducementToPurchase; v103.Clean = value; _purchasePriceLessInducementToPurchase = v103;
                var v104 = _refinanceMaximumMortgageAmount; v104.Clean = value; _refinanceMaximumMortgageAmount = v104;
                var v105 = _refinancingATitleILoan; v105.Clean = value; _refinancingATitleILoan = v105;
                var v106 = _rehabilitationEscrowAccount; v106.Clean = value; _rehabilitationEscrowAccount = v106;
                var v107 = _rehabilitationEscrowAmountBalanceForFutureDraws; v107.Clean = value; _rehabilitationEscrowAmountBalanceForFutureDraws = v107;
                var v108 = _rentalCashFlowBalance; v108.Clean = value; _rentalCashFlowBalance = v108;
                var v109 = _residencyType; v109.Clean = value; _residencyType = v109;
                var v110 = _riskClass; v110.Clean = value; _riskClass = v110;
                var v111 = _scoredByTotal; v111.Clean = value; _scoredByTotal = v111;
                var v112 = _secondaryFinancingProviders; v112.Clean = value; _secondaryFinancingProviders = v112;
                var v113 = _sellerContributionRate; v113.Clean = value; _sellerContributionRate = v113;
                var v114 = _simpleRefinance; v114.Clean = value; _simpleRefinance = v114;
                var v115 = _statutoryInvestment; v115.Clean = value; _statutoryInvestment = v115;
                var v116 = _step2EPlusStep1E; v116.Clean = value; _step2EPlusStep1E = v116;
                var v117 = _streamlined; v117.Clean = value; _streamlined = v117;
                var v118 = _subTotalForEscrowAccount; v118.Clean = value; _subTotalForEscrowAccount = v118;
                var v119 = _subTotalForReleaseAtClosing; v119.Clean = value; _subTotalForReleaseAtClosing = v119;
                var v120 = _sumForInvestor; v120.Clean = value; _sumForInvestor = v120;
                var v121 = _sumForOwnerOccupied; v121.Clean = value; _sumForOwnerOccupied = v121;
                var v122 = _sumOfExistingDebt; v122.Clean = value; _sumOfExistingDebt = v122;
                var v123 = _suplementalOriginationFee; v123.Clean = value; _suplementalOriginationFee = v123;
                var v124 = _title1LoanBalance; v124.Clean = value; _title1LoanBalance = v124;
                var v125 = _title1LoanNumber; v125.Clean = value; _title1LoanNumber = v125;
                var v126 = _title1LoanWithWhom; v126.Clean = value; _title1LoanWithWhom = v126;
                var v127 = _titleUpdateFeeAmount; v127.Clean = value; _titleUpdateFeeAmount = v127;
                var v128 = _titleUpdateFees; v128.Clean = value; _titleUpdateFees = v128;
                var v129 = _titleUpdateFeeTimes; v129.Clean = value; _titleUpdateFeeTimes = v129;
                var v130 = _totalCostsOfRepairsInA6; v130.Clean = value; _totalCostsOfRepairsInA6 = v130;
                var v131 = _totalEscrowCommitment; v131.Clean = value; _totalEscrowCommitment = v131;
                var v132 = _totalEscrowedFunds; v132.Clean = value; _totalEscrowedFunds = v132;
                var v133 = _totalFixedUnpaidBalance; v133.Clean = value; _totalFixedUnpaidBalance = v133;
                var v134 = _totalForBorrowerEstimatedProfit; v134.Clean = value; _totalForBorrowerEstimatedProfit = v134;
                var v135 = _totalForInspectionAndTitleFee; v135.Clean = value; _totalForInspectionAndTitleFee = v135;
                var v136 = _totalForLesserOfSumAsIs; v136.Clean = value; _totalForLesserOfSumAsIs = v136;
                var v137 = _totalForMtgPaymentEscrowed; v137.Clean = value; _totalForMtgPaymentEscrowed = v137;
                var v138 = _totalForPlanReviewerFee; v138.Clean = value; _totalForPlanReviewerFee = v138;
                var v139 = _totalForRehabilitationCost; v139.Clean = value; _totalForRehabilitationCost = v139;
                var v140 = _totalRehabilitationCosts; v140.Clean = value; _totalRehabilitationCosts = v140;
                var v141 = _totalRehabilitationCostsFeesReserves; v141.Clean = value; _totalRehabilitationCostsFeesReserves = v141;
                var v142 = _valueEstablished; v142.Clean = value; _valueEstablished = v142;
                var v143 = _windEnergySystemActualCost; v143.Clean = value; _windEnergySystemActualCost = v143;
                _settingClean = 0;
            }
        }
    }
}