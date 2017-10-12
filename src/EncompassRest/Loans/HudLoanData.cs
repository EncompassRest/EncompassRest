using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HudLoanData : IDirty
    {
        private DirtyValue<decimal?> _actualCashInvRequired;
        public decimal? ActualCashInvRequired { get { return _actualCashInvRequired; } set { _actualCashInvRequired = value; } }
        private DirtyValue<decimal?> _adjustedMaxMtgAmount;
        public decimal? AdjustedMaxMtgAmount { get { return _adjustedMaxMtgAmount; } set { _adjustedMaxMtgAmount = value; } }
        private DirtyValue<decimal?> _afterImprovedValue;
        public decimal? AfterImprovedValue { get { return _afterImprovedValue; } set { _afterImprovedValue = value; } }
        private DirtyValue<decimal?> _afterImprovedValueAfter20Percent;
        public decimal? AfterImprovedValueAfter20Percent { get { return _afterImprovedValueAfter20Percent; } set { _afterImprovedValueAfter20Percent = value; } }
        private DirtyValue<decimal?> _allowableEnergyImprovements;
        public decimal? AllowableEnergyImprovements { get { return _allowableEnergyImprovements; } set { _allowableEnergyImprovements = value; } }
        private DirtyValue<decimal?> _appropriateLTVFactor;
        public decimal? AppropriateLTVFactor { get { return _appropriateLTVFactor; } set { _appropriateLTVFactor = value; } }
        private DirtyValue<decimal?> _architecturalEngineeringFee;
        public decimal? ArchitecturalEngineeringFee { get { return _architecturalEngineeringFee; } set { _architecturalEngineeringFee = value; } }
        private DirtyValue<decimal?> _asIsValue;
        public decimal? AsIsValue { get { return _asIsValue; } set { _asIsValue = value; } }
        private DirtyValue<decimal?> _baseMortgageAmountFrom3COr3D;
        public decimal? BaseMortgageAmountFrom3COr3D { get { return _baseMortgageAmountFrom3COr3D; } set { _baseMortgageAmountFrom3COr3D = value; } }
        private DirtyValue<string> _borrowerAcknowledgement;
        public string BorrowerAcknowledgement { get { return _borrowerAcknowledgement; } set { _borrowerAcknowledgement = value; } }
        private DirtyValue<decimal?> _borrowerEstimatedProfit1;
        public decimal? BorrowerEstimatedProfit1 { get { return _borrowerEstimatedProfit1; } set { _borrowerEstimatedProfit1 = value; } }
        private DirtyValue<decimal?> _borrowerEstimatedProfit2;
        public decimal? BorrowerEstimatedProfit2 { get { return _borrowerEstimatedProfit2; } set { _borrowerEstimatedProfit2 = value; } }
        private DirtyValue<decimal?> _borrowerPaidClosingCosts;
        public decimal? BorrowerPaidClosingCosts { get { return _borrowerPaidClosingCosts; } set { _borrowerPaidClosingCosts = value; } }
        private DirtyValue<decimal?> _borrowerRequiredInvestment;
        public decimal? BorrowerRequiredInvestment { get { return _borrowerRequiredInvestment; } set { _borrowerRequiredInvestment = value; } }
        private DirtyValue<decimal?> _borrowersOwnFundsforContingencyReserves;
        public decimal? BorrowersOwnFundsforContingencyReserves { get { return _borrowersOwnFundsforContingencyReserves; } set { _borrowersOwnFundsforContingencyReserves = value; } }
        private DirtyValue<bool?> _buildingOnOwnLand;
        public bool? BuildingOnOwnLand { get { return _buildingOnOwnLand; } set { _buildingOnOwnLand = value; } }
        private DirtyValue<DateTime?> _caseAssignedDate;
        public DateTime? CaseAssignedDate { get { return _caseAssignedDate; } set { _caseAssignedDate = value; } }
        private DirtyValue<decimal?> _caseLTV;
        public decimal? CaseLTV { get { return _caseLTV; } set { _caseLTV = value; } }
        private DirtyValue<decimal?> _childSupportBalance;
        public decimal? ChildSupportBalance { get { return _childSupportBalance; } set { _childSupportBalance = value; } }
        private DirtyValue<string> _cHUMSForAppraisal;
        public string CHUMSForAppraisal { get { return _cHUMSForAppraisal; } set { _cHUMSForAppraisal = value; } }
        private DirtyValue<decimal?> _commitmentMaximumMortgageAmount;
        public decimal? CommitmentMaximumMortgageAmount { get { return _commitmentMaximumMortgageAmount; } set { _commitmentMaximumMortgageAmount = value; } }
        private DirtyValue<string> _commitmentStage;
        public string CommitmentStage { get { return _commitmentStage; } set { _commitmentStage = value; } }
        private DirtyValue<decimal?> _constructionRepairsRehabilitationCosts;
        public decimal? ConstructionRepairsRehabilitationCosts { get { return _constructionRepairsRehabilitationCosts; } set { _constructionRepairsRehabilitationCosts = value; } }
        private DirtyValue<decimal?> _contingencyReserveCostsAmount;
        public decimal? ContingencyReserveCostsAmount { get { return _contingencyReserveCostsAmount; } set { _contingencyReserveCostsAmount = value; } }
        private DirtyValue<decimal?> _contingencyReserveCostsPercent;
        public decimal? ContingencyReserveCostsPercent { get { return _contingencyReserveCostsPercent; } set { _contingencyReserveCostsPercent = value; } }
        private DirtyValue<decimal?> _contractSalesPrice;
        public decimal? ContractSalesPrice { get { return _contractSalesPrice; } set { _contractSalesPrice = value; } }
        private DirtyValue<string> _criteriaForAppropriateLTVFactor;
        public string CriteriaForAppropriateLTVFactor { get { return _criteriaForAppropriateLTVFactor; } set { _criteriaForAppropriateLTVFactor = value; } }
        private DirtyValue<string> _dealerContractorAddress;
        public string DealerContractorAddress { get { return _dealerContractorAddress; } set { _dealerContractorAddress = value; } }
        private DirtyValue<string> _dealerContractorCity;
        public string DealerContractorCity { get { return _dealerContractorCity; } set { _dealerContractorCity = value; } }
        private DirtyValue<string> _dealerContractorName;
        public string DealerContractorName { get { return _dealerContractorName; } set { _dealerContractorName = value; } }
        private DirtyValue<string> _dealerContractorPostalCode;
        public string DealerContractorPostalCode { get { return _dealerContractorPostalCode; } set { _dealerContractorPostalCode = value; } }
        private DirtyValue<string> _dealerContractorState;
        public string DealerContractorState { get { return _dealerContractorState; } set { _dealerContractorState = value; } }
        private DirtyValue<decimal?> _discountPointsAmount;
        public decimal? DiscountPointsAmount { get { return _discountPointsAmount; } set { _discountPointsAmount = value; } }
        private DirtyValue<decimal?> _discountPointsPercent;
        public decimal? DiscountPointsPercent { get { return _discountPointsPercent; } set { _discountPointsPercent = value; } }
        private DirtyValue<bool?> _eEMIndicator;
        public bool? EEMIndicator { get { return _eEMIndicator; } set { _eEMIndicator = value; } }
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        public decimal? EnergyEfficientMortgageAmount { get { return _energyEfficientMortgageAmount; } set { _energyEfficientMortgageAmount = value; } }
        private DirtyValue<string> _escrowCommitment;
        public string EscrowCommitment { get { return _escrowCommitment; } set { _escrowCommitment = value; } }
        private DirtyValue<decimal?> _escrowShortages;
        public decimal? EscrowShortages { get { return _escrowShortages; } set { _escrowShortages = value; } }
        private DirtyValue<decimal?> _existing203KDebtTotal;
        public decimal? Existing203KDebtTotal { get { return _existing203KDebtTotal; } set { _existing203KDebtTotal = value; } }
        private DirtyValue<bool?> _existingDebt;
        public bool? ExistingDebt { get { return _existingDebt; } set { _existingDebt = value; } }
        private DirtyValue<decimal?> _existingDebtPlusRehabCosts;
        public decimal? ExistingDebtPlusRehabCosts { get { return _existingDebtPlusRehabCosts; } set { _existingDebtPlusRehabCosts = value; } }
        private DirtyValue<decimal?> _existingDebtPlusRehabCostsPlusNewLoanFees;
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get { return _existingDebtPlusRehabCostsPlusNewLoanFees; } set { _existingDebtPlusRehabCostsPlusNewLoanFees = value; } }
        private DirtyValue<decimal?> _feasibilityStudyWhenNecessary;
        public decimal? FeasibilityStudyWhenNecessary { get { return _feasibilityStudyWhenNecessary; } set { _feasibilityStudyWhenNecessary = value; } }
        private DirtyValue<decimal?> _feesAssociatedWithNewLoan;
        public decimal? FeesAssociatedWithNewLoan { get { return _feesAssociatedWithNewLoan; } set { _feesAssociatedWithNewLoan = value; } }
        private DirtyValue<decimal?> _fHA203kB10SubTotal;
        public decimal? FHA203kB10SubTotal { get { return _fHA203kB10SubTotal; } set { _fHA203kB10SubTotal = value; } }
        private DirtyValue<string> _fHA203kRemarks;
        public string FHA203kRemarks { get { return _fHA203kRemarks; } set { _fHA203kRemarks = value; } }
        private DirtyValue<string> _fHAStreamlineType;
        public string FHAStreamlineType { get { return _fHAStreamlineType; } set { _fHAStreamlineType = value; } }
        private DirtyValue<decimal?> _finalBaseMortgageAmount;
        public decimal? FinalBaseMortgageAmount { get { return _finalBaseMortgageAmount; } set { _finalBaseMortgageAmount = value; } }
        private DirtyValue<decimal?> _financeableMortgageFeesIfCharged;
        public decimal? FinanceableMortgageFeesIfCharged { get { return _financeableMortgageFeesIfCharged; } set { _financeableMortgageFeesIfCharged = value; } }
        private DirtyValue<bool?> _haveOtherPendingApplicationForFHA;
        public bool? HaveOtherPendingApplicationForFHA { get { return _haveOtherPendingApplicationForFHA; } set { _haveOtherPendingApplicationForFHA = value; } }
        private DirtyValue<bool?> _hUDOwned;
        public bool? HUDOwned { get { return _hUDOwned; } set { _hUDOwned = value; } }
        private DirtyValue<bool?> _hUDREOIndicator;
        public bool? HUDREOIndicator { get { return _hUDREOIndicator; } set { _hUDREOIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _independentConsultantFee;
        public decimal? IndependentConsultantFee { get { return _independentConsultantFee; } set { _independentConsultantFee = value; } }
        private DirtyValue<decimal?> _initialBaseMortgageAmountPlusEEMImprovementAmount;
        public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get { return _initialBaseMortgageAmountPlusEEMImprovementAmount; } set { _initialBaseMortgageAmountPlusEEMImprovementAmount = value; } }
        private DirtyValue<decimal?> _initialDrawAtClosingArchitecturalorEngineeringFees;
        public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get { return _initialDrawAtClosingArchitecturalorEngineeringFees; } set { _initialDrawAtClosingArchitecturalorEngineeringFees = value; } }
        private DirtyValue<decimal?> _initialDrawAtClosingConsultantFees;
        public decimal? InitialDrawAtClosingConsultantFees { get { return _initialDrawAtClosingConsultantFees; } set { _initialDrawAtClosingConsultantFees = value; } }
        private DirtyValue<decimal?> _initialDrawAtClosingPermitFees;
        public decimal? InitialDrawAtClosingPermitFees { get { return _initialDrawAtClosingPermitFees; } set { _initialDrawAtClosingPermitFees = value; } }
        private DirtyValue<decimal?> _initialDrawAtClosingTotal;
        public decimal? InitialDrawAtClosingTotal { get { return _initialDrawAtClosingTotal; } set { _initialDrawAtClosingTotal = value; } }
        private DirtyValue<decimal?> _inspectionFeeAmount;
        public decimal? InspectionFeeAmount { get { return _inspectionFeeAmount; } set { _inspectionFeeAmount = value; } }
        private DirtyValue<decimal?> _inspectionFeesDuringRehabilitation;
        public decimal? InspectionFeesDuringRehabilitation { get { return _inspectionFeesDuringRehabilitation; } set { _inspectionFeesDuringRehabilitation = value; } }
        private DirtyValue<int?> _inspectionFeeTimes;
        public int? InspectionFeeTimes { get { return _inspectionFeeTimes; } set { _inspectionFeeTimes = value; } }
        private DirtyValue<decimal?> _interestDueonExistingMortgage;
        public decimal? InterestDueonExistingMortgage { get { return _interestDueonExistingMortgage; } set { _interestDueonExistingMortgage = value; } }
        private DirtyValue<decimal?> _lateCharges;
        public decimal? LateCharges { get { return _lateCharges; } set { _lateCharges = value; } }
        private DirtyValue<bool?> _lDPGSAForBorrower;
        public bool? LDPGSAForBorrower { get { return _lDPGSAForBorrower; } set { _lDPGSAForBorrower = value; } }
        private DirtyValue<bool?> _lDPGSAForCoBorrower;
        public bool? LDPGSAForCoBorrower { get { return _lDPGSAForCoBorrower; } set { _lDPGSAForCoBorrower = value; } }
        private DirtyValue<bool?> _leasedFromSomeoneElse;
        public bool? LeasedFromSomeoneElse { get { return _leasedFromSomeoneElse; } set { _leasedFromSomeoneElse = value; } }
        private DirtyValue<DateTime?> _leaseExpiradionDate;
        public DateTime? LeaseExpiradionDate { get { return _leaseExpiradionDate; } set { _leaseExpiradionDate = value; } }
        private DirtyValue<decimal?> _leaseMonthlyPayment;
        public decimal? LeaseMonthlyPayment { get { return _leaseMonthlyPayment; } set { _leaseMonthlyPayment = value; } }
        private DirtyValue<decimal?> _lessAllowableDownpayment;
        public decimal? LessAllowableDownpayment { get { return _lessAllowableDownpayment; } set { _lessAllowableDownpayment = value; } }
        private DirtyValue<decimal?> _lesserOf3AOr3B;
        public decimal? LesserOf3AOr3B { get { return _lesserOf3AOr3B; } set { _lesserOf3AOr3B = value; } }
        private DirtyValue<decimal?> _lesserOf3AOr3BMultiply3F;
        public decimal? LesserOf3AOr3BMultiply3F { get { return _lesserOf3AOr3BMultiply3F; } set { _lesserOf3AOr3BMultiply3F = value; } }
        private DirtyValue<decimal?> _lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get { return _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; } set { _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = value; } }
        private DirtyValue<decimal?> _lesserOfSalesPrice;
        public decimal? LesserOfSalesPrice { get { return _lesserOfSalesPrice; } set { _lesserOfSalesPrice = value; } }
        private DirtyValue<decimal?> _lesserOfSumAmount;
        public decimal? LesserOfSumAmount { get { return _lesserOfSumAmount; } set { _lesserOfSumAmount = value; } }
        private DirtyValue<decimal?> _lesserOfSumAsIs;
        public decimal? LesserOfSumAsIs { get { return _lesserOfSumAsIs; } set { _lesserOfSumAsIs = value; } }
        private DirtyValue<decimal?> _lesserOfSumPercent;
        public decimal? LesserOfSumPercent { get { return _lesserOfSumPercent; } set { _lesserOfSumPercent = value; } }
        private DirtyValue<decimal?> _lessLeadBasedPaintCredit;
        public decimal? LessLeadBasedPaintCredit { get { return _lessLeadBasedPaintCredit; } set { _lessLeadBasedPaintCredit = value; } }
        private DirtyValue<bool?> _limitedProgram;
        public bool? LimitedProgram { get { return _limitedProgram; } set { _limitedProgram = value; } }
        private DirtyValue<bool?> _loanFor203KIndicator;
        public bool? LoanFor203KIndicator { get { return _loanFor203KIndicator; } set { _loanFor203KIndicator = value; } }
        private DirtyValue<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractor;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get { return _materialCostsOrderedPrepaidByBorrowerContractor; } set { _materialCostsOrderedPrepaidByBorrowerContractor = value; } }
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get { return _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; } set { _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = value; } }
        private DirtyValue<decimal?> _maximumMortgageWithUFMIP;
        public decimal? MaximumMortgageWithUFMIP { get { return _maximumMortgageWithUFMIP; } set { _maximumMortgageWithUFMIP = value; } }
        private DirtyValue<decimal?> _mIPDueOnExistingMortgage;
        public decimal? MIPDueOnExistingMortgage { get { return _mIPDueOnExistingMortgage; } set { _mIPDueOnExistingMortgage = value; } }
        private DirtyValue<decimal?> _mIPLTV;
        public decimal? MIPLTV { get { return _mIPLTV; } set { _mIPLTV = value; } }
        private DirtyValue<bool?> _mtgOrDeedOfTrusOnProperty;
        public bool? MtgOrDeedOfTrusOnProperty { get { return _mtgOrDeedOfTrusOnProperty; } set { _mtgOrDeedOfTrusOnProperty = value; } }
        private DirtyValue<decimal?> _mtgPaymentEscrowedAmount;
        public decimal? MtgPaymentEscrowedAmount { get { return _mtgPaymentEscrowedAmount; } set { _mtgPaymentEscrowedAmount = value; } }
        private DirtyValue<int?> _mtgPaymentEscrowedTimes;
        public int? MtgPaymentEscrowedTimes { get { return _mtgPaymentEscrowedTimes; } set { _mtgPaymentEscrowedTimes = value; } }
        private DirtyValue<decimal?> _nationwideMortgageLimit;
        public decimal? NationwideMortgageLimit { get { return _nationwideMortgageLimit; } set { _nationwideMortgageLimit = value; } }
        private DirtyValue<decimal?> _nationwideMortgageLimitAfter120Percent;
        public decimal? NationwideMortgageLimitAfter120Percent { get { return _nationwideMortgageLimitAfter120Percent; } set { _nationwideMortgageLimitAfter120Percent = value; } }
        private DirtyValue<bool?> _newResidential;
        public bool? NewResidential { get { return _newResidential; } set { _newResidential = value; } }
        private DirtyValue<string> _nonresidentialTypeOfUse;
        public string NonresidentialTypeOfUse { get { return _nonresidentialTypeOfUse; } set { _nonresidentialTypeOfUse = value; } }
        private DirtyValue<int?> _numberOfHistoricUnits;
        public int? NumberOfHistoricUnits { get { return _numberOfHistoricUnits; } set { _numberOfHistoricUnits = value; } }
        private DirtyValue<int?> _numberOfMultifamilyUnits;
        public int? NumberOfMultifamilyUnits { get { return _numberOfMultifamilyUnits; } set { _numberOfMultifamilyUnits = value; } }
        private DirtyValue<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private DirtyValue<bool?> _ownedByBorrower;
        public bool? OwnedByBorrower { get { return _ownedByBorrower; } set { _ownedByBorrower = value; } }
        private DirtyValue<decimal?> _percentAfterImprovedValue;
        public decimal? PercentAfterImprovedValue { get { return _percentAfterImprovedValue; } set { _percentAfterImprovedValue = value; } }
        private DirtyValue<decimal?> _permitsAndOtherFee;
        public decimal? PermitsAndOtherFee { get { return _permitsAndOtherFee; } set { _permitsAndOtherFee = value; } }
        private DirtyValue<decimal?> _planReviewerFeeAddition;
        public decimal? PlanReviewerFeeAddition { get { return _planReviewerFeeAddition; } set { _planReviewerFeeAddition = value; } }
        private DirtyValue<decimal?> _planReviewerFeeAmount;
        public decimal? PlanReviewerFeeAmount { get { return _planReviewerFeeAmount; } set { _planReviewerFeeAmount = value; } }
        private DirtyValue<int?> _planReviewerFeeMiles;
        public int? PlanReviewerFeeMiles { get { return _planReviewerFeeMiles; } set { _planReviewerFeeMiles = value; } }
        private DirtyValue<decimal?> _prepaymentPenalties;
        public decimal? PrepaymentPenalties { get { return _prepaymentPenalties; } set { _prepaymentPenalties = value; } }
        private DirtyValue<string> _propertyOwnerAddress;
        public string PropertyOwnerAddress { get { return _propertyOwnerAddress; } set { _propertyOwnerAddress = value; } }
        private DirtyValue<string> _propertyOwnerCity;
        public string PropertyOwnerCity { get { return _propertyOwnerCity; } set { _propertyOwnerCity = value; } }
        private DirtyValue<string> _propertyOwnerName;
        public string PropertyOwnerName { get { return _propertyOwnerName; } set { _propertyOwnerName = value; } }
        private DirtyValue<string> _propertyOwnerPostalCode;
        public string PropertyOwnerPostalCode { get { return _propertyOwnerPostalCode; } set { _propertyOwnerPostalCode = value; } }
        private DirtyValue<string> _propertyOwnerState;
        public string PropertyOwnerState { get { return _propertyOwnerState; } set { _propertyOwnerState = value; } }
        private DirtyValue<string> _propertyToBeImproved;
        public string PropertyToBeImproved { get { return _propertyToBeImproved; } set { _propertyToBeImproved = value; } }
        private DirtyValue<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private DirtyValue<DateTime?> _purchaseDate;
        public DateTime? PurchaseDate { get { return _purchaseDate; } set { _purchaseDate = value; } }
        private DirtyValue<bool?> _purchasedOnContract;
        public bool? PurchasedOnContract { get { return _purchasedOnContract; } set { _purchasedOnContract = value; } }
        private DirtyValue<decimal?> _purchaseMaximumMortgageAmount;
        public decimal? PurchaseMaximumMortgageAmount { get { return _purchaseMaximumMortgageAmount; } set { _purchaseMaximumMortgageAmount = value; } }
        private DirtyValue<decimal?> _purchaseMaximumMortgagePercent;
        public decimal? PurchaseMaximumMortgagePercent { get { return _purchaseMaximumMortgagePercent; } set { _purchaseMaximumMortgagePercent = value; } }
        private DirtyValue<decimal?> _purchasePriceLessInducementToPurchase;
        public decimal? PurchasePriceLessInducementToPurchase { get { return _purchasePriceLessInducementToPurchase; } set { _purchasePriceLessInducementToPurchase = value; } }
        private DirtyValue<decimal?> _refinanceMaximumMortgageAmount;
        public decimal? RefinanceMaximumMortgageAmount { get { return _refinanceMaximumMortgageAmount; } set { _refinanceMaximumMortgageAmount = value; } }
        private DirtyValue<bool?> _refinancingATitleILoan;
        public bool? RefinancingATitleILoan { get { return _refinancingATitleILoan; } set { _refinancingATitleILoan = value; } }
        private DirtyValue<decimal?> _rehabilitationEscrowAccount;
        public decimal? RehabilitationEscrowAccount { get { return _rehabilitationEscrowAccount; } set { _rehabilitationEscrowAccount = value; } }
        private DirtyValue<decimal?> _rehabilitationEscrowAmountBalanceForFutureDraws;
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get { return _rehabilitationEscrowAmountBalanceForFutureDraws; } set { _rehabilitationEscrowAmountBalanceForFutureDraws = value; } }
        private DirtyValue<decimal?> _rentalCashFlowBalance;
        public decimal? RentalCashFlowBalance { get { return _rentalCashFlowBalance; } set { _rentalCashFlowBalance = value; } }
        private DirtyValue<string> _residencyType;
        public string ResidencyType { get { return _residencyType; } set { _residencyType = value; } }
        private DirtyValue<string> _riskClass;
        public string RiskClass { get { return _riskClass; } set { _riskClass = value; } }
        private DirtyValue<bool?> _scoredByTotal;
        public bool? ScoredByTotal { get { return _scoredByTotal; } set { _scoredByTotal = value; } }
        private DirtyList<SecondaryFinancingProvider> _secondaryFinancingProviders;
        public IList<SecondaryFinancingProvider> SecondaryFinancingProviders { get { return _secondaryFinancingProviders ?? (_secondaryFinancingProviders = new DirtyList<SecondaryFinancingProvider>()); } set { _secondaryFinancingProviders = new DirtyList<SecondaryFinancingProvider>(value); } }
        private DirtyValue<decimal?> _sellerContributionRate;
        public decimal? SellerContributionRate { get { return _sellerContributionRate; } set { _sellerContributionRate = value; } }
        private DirtyValue<bool?> _simpleRefinance;
        public bool? SimpleRefinance { get { return _simpleRefinance; } set { _simpleRefinance = value; } }
        private DirtyValue<decimal?> _statutoryInvestment;
        public decimal? StatutoryInvestment { get { return _statutoryInvestment; } set { _statutoryInvestment = value; } }
        private DirtyValue<decimal?> _step2EPlusStep1E;
        public decimal? Step2EPlusStep1E { get { return _step2EPlusStep1E; } set { _step2EPlusStep1E = value; } }
        private DirtyValue<bool?> _streamlined;
        public bool? Streamlined { get { return _streamlined; } set { _streamlined = value; } }
        private DirtyValue<decimal?> _subTotalForEscrowAccount;
        public decimal? SubTotalForEscrowAccount { get { return _subTotalForEscrowAccount; } set { _subTotalForEscrowAccount = value; } }
        private DirtyValue<decimal?> _subTotalForReleaseAtClosing;
        public decimal? SubTotalForReleaseAtClosing { get { return _subTotalForReleaseAtClosing; } set { _subTotalForReleaseAtClosing = value; } }
        private DirtyValue<decimal?> _sumForInvestor;
        public decimal? SumForInvestor { get { return _sumForInvestor; } set { _sumForInvestor = value; } }
        private DirtyValue<decimal?> _sumForOwnerOccupied;
        public decimal? SumForOwnerOccupied { get { return _sumForOwnerOccupied; } set { _sumForOwnerOccupied = value; } }
        private DirtyValue<decimal?> _sumOfExistingDebt;
        public decimal? SumOfExistingDebt { get { return _sumOfExistingDebt; } set { _sumOfExistingDebt = value; } }
        private DirtyValue<decimal?> _suplementalOriginationFee;
        public decimal? SuplementalOriginationFee { get { return _suplementalOriginationFee; } set { _suplementalOriginationFee = value; } }
        private DirtyValue<decimal?> _title1LoanBalance;
        public decimal? Title1LoanBalance { get { return _title1LoanBalance; } set { _title1LoanBalance = value; } }
        private DirtyValue<string> _title1LoanNumber;
        public string Title1LoanNumber { get { return _title1LoanNumber; } set { _title1LoanNumber = value; } }
        private DirtyValue<string> _title1LoanWithWhom;
        public string Title1LoanWithWhom { get { return _title1LoanWithWhom; } set { _title1LoanWithWhom = value; } }
        private DirtyValue<decimal?> _titleUpdateFeeAmount;
        public decimal? TitleUpdateFeeAmount { get { return _titleUpdateFeeAmount; } set { _titleUpdateFeeAmount = value; } }
        private DirtyValue<decimal?> _titleUpdateFees;
        public decimal? TitleUpdateFees { get { return _titleUpdateFees; } set { _titleUpdateFees = value; } }
        private DirtyValue<int?> _titleUpdateFeeTimes;
        public int? TitleUpdateFeeTimes { get { return _titleUpdateFeeTimes; } set { _titleUpdateFeeTimes = value; } }
        private DirtyValue<decimal?> _totalCostsOfRepairsInA6;
        public decimal? TotalCostsOfRepairsInA6 { get { return _totalCostsOfRepairsInA6; } set { _totalCostsOfRepairsInA6 = value; } }
        private DirtyValue<decimal?> _totalEscrowCommitment;
        public decimal? TotalEscrowCommitment { get { return _totalEscrowCommitment; } set { _totalEscrowCommitment = value; } }
        private DirtyValue<decimal?> _totalEscrowedFunds;
        public decimal? TotalEscrowedFunds { get { return _totalEscrowedFunds; } set { _totalEscrowedFunds = value; } }
        private DirtyValue<decimal?> _totalFixedUnpaidBalance;
        public decimal? TotalFixedUnpaidBalance { get { return _totalFixedUnpaidBalance; } set { _totalFixedUnpaidBalance = value; } }
        private DirtyValue<decimal?> _totalForBorrowerEstimatedProfit;
        public decimal? TotalForBorrowerEstimatedProfit { get { return _totalForBorrowerEstimatedProfit; } set { _totalForBorrowerEstimatedProfit = value; } }
        private DirtyValue<decimal?> _totalForInspectionAndTitleFee;
        public decimal? TotalForInspectionAndTitleFee { get { return _totalForInspectionAndTitleFee; } set { _totalForInspectionAndTitleFee = value; } }
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        public decimal? TotalForLesserOfSumAsIs { get { return _totalForLesserOfSumAsIs; } set { _totalForLesserOfSumAsIs = value; } }
        private DirtyValue<decimal?> _totalForMtgPaymentEscrowed;
        public decimal? TotalForMtgPaymentEscrowed { get { return _totalForMtgPaymentEscrowed; } set { _totalForMtgPaymentEscrowed = value; } }
        private DirtyValue<decimal?> _totalForPlanReviewerFee;
        public decimal? TotalForPlanReviewerFee { get { return _totalForPlanReviewerFee; } set { _totalForPlanReviewerFee = value; } }
        private DirtyValue<decimal?> _totalForRehabilitationCost;
        public decimal? TotalForRehabilitationCost { get { return _totalForRehabilitationCost; } set { _totalForRehabilitationCost = value; } }
        private DirtyValue<decimal?> _totalRehabilitationCosts;
        public decimal? TotalRehabilitationCosts { get { return _totalRehabilitationCosts; } set { _totalRehabilitationCosts = value; } }
        private DirtyValue<decimal?> _totalRehabilitationCostsFeesReserves;
        public decimal? TotalRehabilitationCostsFeesReserves { get { return _totalRehabilitationCostsFeesReserves; } set { _totalRehabilitationCostsFeesReserves = value; } }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceFirstLien;
        public decimal? UnpaidPrincipalBalanceFirstLien { get { return _unpaidPrincipalBalanceFirstLien; } set { _unpaidPrincipalBalanceFirstLien = value; } }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfAnyJuniorLiens;
        public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get { return _unpaidPrincipalBalanceOfAnyJuniorLiens; } set { _unpaidPrincipalBalanceOfAnyJuniorLiens = value; } }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfPurchaseJuniorLiens;
        public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get { return _unpaidPrincipalBalanceOfPurchaseJuniorLiens; } set { _unpaidPrincipalBalanceOfPurchaseJuniorLiens = value; } }
        private DirtyValue<decimal?> _valueEstablished;
        public decimal? ValueEstablished { get { return _valueEstablished; } set { _valueEstablished = value; } }
        private DirtyValue<decimal?> _windEnergySystemActualCost;
        public decimal? WindEnergySystemActualCost { get { return _windEnergySystemActualCost; } set { _windEnergySystemActualCost = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _actualCashInvRequired.Dirty
                    || _adjustedMaxMtgAmount.Dirty
                    || _afterImprovedValue.Dirty
                    || _afterImprovedValueAfter20Percent.Dirty
                    || _allowableEnergyImprovements.Dirty
                    || _appropriateLTVFactor.Dirty
                    || _architecturalEngineeringFee.Dirty
                    || _asIsValue.Dirty
                    || _baseMortgageAmountFrom3COr3D.Dirty
                    || _borrowerAcknowledgement.Dirty
                    || _borrowerEstimatedProfit1.Dirty
                    || _borrowerEstimatedProfit2.Dirty
                    || _borrowerPaidClosingCosts.Dirty
                    || _borrowerRequiredInvestment.Dirty
                    || _borrowersOwnFundsforContingencyReserves.Dirty
                    || _buildingOnOwnLand.Dirty
                    || _caseAssignedDate.Dirty
                    || _caseLTV.Dirty
                    || _childSupportBalance.Dirty
                    || _cHUMSForAppraisal.Dirty
                    || _commitmentMaximumMortgageAmount.Dirty
                    || _commitmentStage.Dirty
                    || _constructionRepairsRehabilitationCosts.Dirty
                    || _contingencyReserveCostsAmount.Dirty
                    || _contingencyReserveCostsPercent.Dirty
                    || _contractSalesPrice.Dirty
                    || _criteriaForAppropriateLTVFactor.Dirty
                    || _dealerContractorAddress.Dirty
                    || _dealerContractorCity.Dirty
                    || _dealerContractorName.Dirty
                    || _dealerContractorPostalCode.Dirty
                    || _dealerContractorState.Dirty
                    || _discountPointsAmount.Dirty
                    || _discountPointsPercent.Dirty
                    || _eEMIndicator.Dirty
                    || _energyEfficientMortgageAmount.Dirty
                    || _escrowCommitment.Dirty
                    || _escrowShortages.Dirty
                    || _existing203KDebtTotal.Dirty
                    || _existingDebt.Dirty
                    || _existingDebtPlusRehabCosts.Dirty
                    || _existingDebtPlusRehabCostsPlusNewLoanFees.Dirty
                    || _feasibilityStudyWhenNecessary.Dirty
                    || _feesAssociatedWithNewLoan.Dirty
                    || _fHA203kB10SubTotal.Dirty
                    || _fHA203kRemarks.Dirty
                    || _fHAStreamlineType.Dirty
                    || _finalBaseMortgageAmount.Dirty
                    || _financeableMortgageFeesIfCharged.Dirty
                    || _haveOtherPendingApplicationForFHA.Dirty
                    || _hUDOwned.Dirty
                    || _hUDREOIndicator.Dirty
                    || _id.Dirty
                    || _independentConsultantFee.Dirty
                    || _initialBaseMortgageAmountPlusEEMImprovementAmount.Dirty
                    || _initialDrawAtClosingArchitecturalorEngineeringFees.Dirty
                    || _initialDrawAtClosingConsultantFees.Dirty
                    || _initialDrawAtClosingPermitFees.Dirty
                    || _initialDrawAtClosingTotal.Dirty
                    || _inspectionFeeAmount.Dirty
                    || _inspectionFeesDuringRehabilitation.Dirty
                    || _inspectionFeeTimes.Dirty
                    || _interestDueonExistingMortgage.Dirty
                    || _lateCharges.Dirty
                    || _lDPGSAForBorrower.Dirty
                    || _lDPGSAForCoBorrower.Dirty
                    || _leasedFromSomeoneElse.Dirty
                    || _leaseExpiradionDate.Dirty
                    || _leaseMonthlyPayment.Dirty
                    || _lessAllowableDownpayment.Dirty
                    || _lesserOf3AOr3B.Dirty
                    || _lesserOf3AOr3BMultiply3F.Dirty
                    || _lesserOfMaximumFinanceableSolarOrWindEnergyAmount.Dirty
                    || _lesserOfSalesPrice.Dirty
                    || _lesserOfSumAmount.Dirty
                    || _lesserOfSumAsIs.Dirty
                    || _lesserOfSumPercent.Dirty
                    || _lessLeadBasedPaintCredit.Dirty
                    || _limitedProgram.Dirty
                    || _loanFor203KIndicator.Dirty
                    || _loanPurpose.Dirty
                    || _materialCostsOrderedPrepaidByBorrowerContractor.Dirty
                    || _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Dirty
                    || _maximumMortgageWithUFMIP.Dirty
                    || _mIPDueOnExistingMortgage.Dirty
                    || _mIPLTV.Dirty
                    || _mtgOrDeedOfTrusOnProperty.Dirty
                    || _mtgPaymentEscrowedAmount.Dirty
                    || _mtgPaymentEscrowedTimes.Dirty
                    || _nationwideMortgageLimit.Dirty
                    || _nationwideMortgageLimitAfter120Percent.Dirty
                    || _newResidential.Dirty
                    || _nonresidentialTypeOfUse.Dirty
                    || _numberOfHistoricUnits.Dirty
                    || _numberOfMultifamilyUnits.Dirty
                    || _otherDescription.Dirty
                    || _ownedByBorrower.Dirty
                    || _percentAfterImprovedValue.Dirty
                    || _permitsAndOtherFee.Dirty
                    || _planReviewerFeeAddition.Dirty
                    || _planReviewerFeeAmount.Dirty
                    || _planReviewerFeeMiles.Dirty
                    || _prepaymentPenalties.Dirty
                    || _propertyOwnerAddress.Dirty
                    || _propertyOwnerCity.Dirty
                    || _propertyOwnerName.Dirty
                    || _propertyOwnerPostalCode.Dirty
                    || _propertyOwnerState.Dirty
                    || _propertyToBeImproved.Dirty
                    || _propertyType.Dirty
                    || _purchaseDate.Dirty
                    || _purchasedOnContract.Dirty
                    || _purchaseMaximumMortgageAmount.Dirty
                    || _purchaseMaximumMortgagePercent.Dirty
                    || _purchasePriceLessInducementToPurchase.Dirty
                    || _refinanceMaximumMortgageAmount.Dirty
                    || _refinancingATitleILoan.Dirty
                    || _rehabilitationEscrowAccount.Dirty
                    || _rehabilitationEscrowAmountBalanceForFutureDraws.Dirty
                    || _rentalCashFlowBalance.Dirty
                    || _residencyType.Dirty
                    || _riskClass.Dirty
                    || _scoredByTotal.Dirty
                    || _sellerContributionRate.Dirty
                    || _simpleRefinance.Dirty
                    || _statutoryInvestment.Dirty
                    || _step2EPlusStep1E.Dirty
                    || _streamlined.Dirty
                    || _subTotalForEscrowAccount.Dirty
                    || _subTotalForReleaseAtClosing.Dirty
                    || _sumForInvestor.Dirty
                    || _sumForOwnerOccupied.Dirty
                    || _sumOfExistingDebt.Dirty
                    || _suplementalOriginationFee.Dirty
                    || _title1LoanBalance.Dirty
                    || _title1LoanNumber.Dirty
                    || _title1LoanWithWhom.Dirty
                    || _titleUpdateFeeAmount.Dirty
                    || _titleUpdateFees.Dirty
                    || _titleUpdateFeeTimes.Dirty
                    || _totalCostsOfRepairsInA6.Dirty
                    || _totalEscrowCommitment.Dirty
                    || _totalEscrowedFunds.Dirty
                    || _totalFixedUnpaidBalance.Dirty
                    || _totalForBorrowerEstimatedProfit.Dirty
                    || _totalForInspectionAndTitleFee.Dirty
                    || _totalForLesserOfSumAsIs.Dirty
                    || _totalForMtgPaymentEscrowed.Dirty
                    || _totalForPlanReviewerFee.Dirty
                    || _totalForRehabilitationCost.Dirty
                    || _totalRehabilitationCosts.Dirty
                    || _totalRehabilitationCostsFeesReserves.Dirty
                    || _unpaidPrincipalBalanceFirstLien.Dirty
                    || _unpaidPrincipalBalanceOfAnyJuniorLiens.Dirty
                    || _unpaidPrincipalBalanceOfPurchaseJuniorLiens.Dirty
                    || _valueEstablished.Dirty
                    || _windEnergySystemActualCost.Dirty
                    || _secondaryFinancingProviders?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _actualCashInvRequired.Dirty = value;
                _adjustedMaxMtgAmount.Dirty = value;
                _afterImprovedValue.Dirty = value;
                _afterImprovedValueAfter20Percent.Dirty = value;
                _allowableEnergyImprovements.Dirty = value;
                _appropriateLTVFactor.Dirty = value;
                _architecturalEngineeringFee.Dirty = value;
                _asIsValue.Dirty = value;
                _baseMortgageAmountFrom3COr3D.Dirty = value;
                _borrowerAcknowledgement.Dirty = value;
                _borrowerEstimatedProfit1.Dirty = value;
                _borrowerEstimatedProfit2.Dirty = value;
                _borrowerPaidClosingCosts.Dirty = value;
                _borrowerRequiredInvestment.Dirty = value;
                _borrowersOwnFundsforContingencyReserves.Dirty = value;
                _buildingOnOwnLand.Dirty = value;
                _caseAssignedDate.Dirty = value;
                _caseLTV.Dirty = value;
                _childSupportBalance.Dirty = value;
                _cHUMSForAppraisal.Dirty = value;
                _commitmentMaximumMortgageAmount.Dirty = value;
                _commitmentStage.Dirty = value;
                _constructionRepairsRehabilitationCosts.Dirty = value;
                _contingencyReserveCostsAmount.Dirty = value;
                _contingencyReserveCostsPercent.Dirty = value;
                _contractSalesPrice.Dirty = value;
                _criteriaForAppropriateLTVFactor.Dirty = value;
                _dealerContractorAddress.Dirty = value;
                _dealerContractorCity.Dirty = value;
                _dealerContractorName.Dirty = value;
                _dealerContractorPostalCode.Dirty = value;
                _dealerContractorState.Dirty = value;
                _discountPointsAmount.Dirty = value;
                _discountPointsPercent.Dirty = value;
                _eEMIndicator.Dirty = value;
                _energyEfficientMortgageAmount.Dirty = value;
                _escrowCommitment.Dirty = value;
                _escrowShortages.Dirty = value;
                _existing203KDebtTotal.Dirty = value;
                _existingDebt.Dirty = value;
                _existingDebtPlusRehabCosts.Dirty = value;
                _existingDebtPlusRehabCostsPlusNewLoanFees.Dirty = value;
                _feasibilityStudyWhenNecessary.Dirty = value;
                _feesAssociatedWithNewLoan.Dirty = value;
                _fHA203kB10SubTotal.Dirty = value;
                _fHA203kRemarks.Dirty = value;
                _fHAStreamlineType.Dirty = value;
                _finalBaseMortgageAmount.Dirty = value;
                _financeableMortgageFeesIfCharged.Dirty = value;
                _haveOtherPendingApplicationForFHA.Dirty = value;
                _hUDOwned.Dirty = value;
                _hUDREOIndicator.Dirty = value;
                _id.Dirty = value;
                _independentConsultantFee.Dirty = value;
                _initialBaseMortgageAmountPlusEEMImprovementAmount.Dirty = value;
                _initialDrawAtClosingArchitecturalorEngineeringFees.Dirty = value;
                _initialDrawAtClosingConsultantFees.Dirty = value;
                _initialDrawAtClosingPermitFees.Dirty = value;
                _initialDrawAtClosingTotal.Dirty = value;
                _inspectionFeeAmount.Dirty = value;
                _inspectionFeesDuringRehabilitation.Dirty = value;
                _inspectionFeeTimes.Dirty = value;
                _interestDueonExistingMortgage.Dirty = value;
                _lateCharges.Dirty = value;
                _lDPGSAForBorrower.Dirty = value;
                _lDPGSAForCoBorrower.Dirty = value;
                _leasedFromSomeoneElse.Dirty = value;
                _leaseExpiradionDate.Dirty = value;
                _leaseMonthlyPayment.Dirty = value;
                _lessAllowableDownpayment.Dirty = value;
                _lesserOf3AOr3B.Dirty = value;
                _lesserOf3AOr3BMultiply3F.Dirty = value;
                _lesserOfMaximumFinanceableSolarOrWindEnergyAmount.Dirty = value;
                _lesserOfSalesPrice.Dirty = value;
                _lesserOfSumAmount.Dirty = value;
                _lesserOfSumAsIs.Dirty = value;
                _lesserOfSumPercent.Dirty = value;
                _lessLeadBasedPaintCredit.Dirty = value;
                _limitedProgram.Dirty = value;
                _loanFor203KIndicator.Dirty = value;
                _loanPurpose.Dirty = value;
                _materialCostsOrderedPrepaidByBorrowerContractor.Dirty = value;
                _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Dirty = value;
                _maximumMortgageWithUFMIP.Dirty = value;
                _mIPDueOnExistingMortgage.Dirty = value;
                _mIPLTV.Dirty = value;
                _mtgOrDeedOfTrusOnProperty.Dirty = value;
                _mtgPaymentEscrowedAmount.Dirty = value;
                _mtgPaymentEscrowedTimes.Dirty = value;
                _nationwideMortgageLimit.Dirty = value;
                _nationwideMortgageLimitAfter120Percent.Dirty = value;
                _newResidential.Dirty = value;
                _nonresidentialTypeOfUse.Dirty = value;
                _numberOfHistoricUnits.Dirty = value;
                _numberOfMultifamilyUnits.Dirty = value;
                _otherDescription.Dirty = value;
                _ownedByBorrower.Dirty = value;
                _percentAfterImprovedValue.Dirty = value;
                _permitsAndOtherFee.Dirty = value;
                _planReviewerFeeAddition.Dirty = value;
                _planReviewerFeeAmount.Dirty = value;
                _planReviewerFeeMiles.Dirty = value;
                _prepaymentPenalties.Dirty = value;
                _propertyOwnerAddress.Dirty = value;
                _propertyOwnerCity.Dirty = value;
                _propertyOwnerName.Dirty = value;
                _propertyOwnerPostalCode.Dirty = value;
                _propertyOwnerState.Dirty = value;
                _propertyToBeImproved.Dirty = value;
                _propertyType.Dirty = value;
                _purchaseDate.Dirty = value;
                _purchasedOnContract.Dirty = value;
                _purchaseMaximumMortgageAmount.Dirty = value;
                _purchaseMaximumMortgagePercent.Dirty = value;
                _purchasePriceLessInducementToPurchase.Dirty = value;
                _refinanceMaximumMortgageAmount.Dirty = value;
                _refinancingATitleILoan.Dirty = value;
                _rehabilitationEscrowAccount.Dirty = value;
                _rehabilitationEscrowAmountBalanceForFutureDraws.Dirty = value;
                _rentalCashFlowBalance.Dirty = value;
                _residencyType.Dirty = value;
                _riskClass.Dirty = value;
                _scoredByTotal.Dirty = value;
                _sellerContributionRate.Dirty = value;
                _simpleRefinance.Dirty = value;
                _statutoryInvestment.Dirty = value;
                _step2EPlusStep1E.Dirty = value;
                _streamlined.Dirty = value;
                _subTotalForEscrowAccount.Dirty = value;
                _subTotalForReleaseAtClosing.Dirty = value;
                _sumForInvestor.Dirty = value;
                _sumForOwnerOccupied.Dirty = value;
                _sumOfExistingDebt.Dirty = value;
                _suplementalOriginationFee.Dirty = value;
                _title1LoanBalance.Dirty = value;
                _title1LoanNumber.Dirty = value;
                _title1LoanWithWhom.Dirty = value;
                _titleUpdateFeeAmount.Dirty = value;
                _titleUpdateFees.Dirty = value;
                _titleUpdateFeeTimes.Dirty = value;
                _totalCostsOfRepairsInA6.Dirty = value;
                _totalEscrowCommitment.Dirty = value;
                _totalEscrowedFunds.Dirty = value;
                _totalFixedUnpaidBalance.Dirty = value;
                _totalForBorrowerEstimatedProfit.Dirty = value;
                _totalForInspectionAndTitleFee.Dirty = value;
                _totalForLesserOfSumAsIs.Dirty = value;
                _totalForMtgPaymentEscrowed.Dirty = value;
                _totalForPlanReviewerFee.Dirty = value;
                _totalForRehabilitationCost.Dirty = value;
                _totalRehabilitationCosts.Dirty = value;
                _totalRehabilitationCostsFeesReserves.Dirty = value;
                _unpaidPrincipalBalanceFirstLien.Dirty = value;
                _unpaidPrincipalBalanceOfAnyJuniorLiens.Dirty = value;
                _unpaidPrincipalBalanceOfPurchaseJuniorLiens.Dirty = value;
                _valueEstablished.Dirty = value;
                _windEnergySystemActualCost.Dirty = value;
                if (_secondaryFinancingProviders != null) _secondaryFinancingProviders.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}