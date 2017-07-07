using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class HudLoanData : IClean
    {
        private Value<decimal?> _actualCashInvRequired;
        public decimal? ActualCashInvRequired { get { return _actualCashInvRequired; } set { _actualCashInvRequired = value; } }
        private Value<decimal?> _adjustedMaxMtgAmount;
        public decimal? AdjustedMaxMtgAmount { get { return _adjustedMaxMtgAmount; } set { _adjustedMaxMtgAmount = value; } }
        private Value<decimal?> _afterImprovedValue;
        public decimal? AfterImprovedValue { get { return _afterImprovedValue; } set { _afterImprovedValue = value; } }
        private Value<decimal?> _afterImprovedValueAfter20Percent;
        public decimal? AfterImprovedValueAfter20Percent { get { return _afterImprovedValueAfter20Percent; } set { _afterImprovedValueAfter20Percent = value; } }
        private Value<decimal?> _allowableEnergyImprovements;
        public decimal? AllowableEnergyImprovements { get { return _allowableEnergyImprovements; } set { _allowableEnergyImprovements = value; } }
        private Value<decimal?> _appropriateLTVFactor;
        public decimal? AppropriateLTVFactor { get { return _appropriateLTVFactor; } set { _appropriateLTVFactor = value; } }
        private Value<decimal?> _architecturalEngineeringFee;
        public decimal? ArchitecturalEngineeringFee { get { return _architecturalEngineeringFee; } set { _architecturalEngineeringFee = value; } }
        private Value<decimal?> _asIsValue;
        public decimal? AsIsValue { get { return _asIsValue; } set { _asIsValue = value; } }
        private Value<decimal?> _baseMortgageAmountFrom3COr3D;
        public decimal? BaseMortgageAmountFrom3COr3D { get { return _baseMortgageAmountFrom3COr3D; } set { _baseMortgageAmountFrom3COr3D = value; } }
        private Value<string> _borrowerAcknowledgement;
        public string BorrowerAcknowledgement { get { return _borrowerAcknowledgement; } set { _borrowerAcknowledgement = value; } }
        private Value<decimal?> _borrowerEstimatedProfit1;
        public decimal? BorrowerEstimatedProfit1 { get { return _borrowerEstimatedProfit1; } set { _borrowerEstimatedProfit1 = value; } }
        private Value<decimal?> _borrowerEstimatedProfit2;
        public decimal? BorrowerEstimatedProfit2 { get { return _borrowerEstimatedProfit2; } set { _borrowerEstimatedProfit2 = value; } }
        private Value<decimal?> _borrowerPaidClosingCosts;
        public decimal? BorrowerPaidClosingCosts { get { return _borrowerPaidClosingCosts; } set { _borrowerPaidClosingCosts = value; } }
        private Value<decimal?> _borrowerRequiredInvestment;
        public decimal? BorrowerRequiredInvestment { get { return _borrowerRequiredInvestment; } set { _borrowerRequiredInvestment = value; } }
        private Value<decimal?> _borrowersOwnFundsforContingencyReserves;
        public decimal? BorrowersOwnFundsforContingencyReserves { get { return _borrowersOwnFundsforContingencyReserves; } set { _borrowersOwnFundsforContingencyReserves = value; } }
        private Value<bool?> _buildingOnOwnLand;
        public bool? BuildingOnOwnLand { get { return _buildingOnOwnLand; } set { _buildingOnOwnLand = value; } }
        private Value<DateTime?> _caseAssignedDate;
        public DateTime? CaseAssignedDate { get { return _caseAssignedDate; } set { _caseAssignedDate = value; } }
        private Value<decimal?> _caseLTV;
        public decimal? CaseLTV { get { return _caseLTV; } set { _caseLTV = value; } }
        private Value<decimal?> _childSupportBalance;
        public decimal? ChildSupportBalance { get { return _childSupportBalance; } set { _childSupportBalance = value; } }
        private Value<string> _cHUMSForAppraisal;
        public string CHUMSForAppraisal { get { return _cHUMSForAppraisal; } set { _cHUMSForAppraisal = value; } }
        private Value<decimal?> _commitmentMaximumMortgageAmount;
        public decimal? CommitmentMaximumMortgageAmount { get { return _commitmentMaximumMortgageAmount; } set { _commitmentMaximumMortgageAmount = value; } }
        private Value<string> _commitmentStage;
        public string CommitmentStage { get { return _commitmentStage; } set { _commitmentStage = value; } }
        private Value<decimal?> _constructionRepairsRehabilitationCosts;
        public decimal? ConstructionRepairsRehabilitationCosts { get { return _constructionRepairsRehabilitationCosts; } set { _constructionRepairsRehabilitationCosts = value; } }
        private Value<decimal?> _contingencyReserveCostsAmount;
        public decimal? ContingencyReserveCostsAmount { get { return _contingencyReserveCostsAmount; } set { _contingencyReserveCostsAmount = value; } }
        private Value<decimal?> _contingencyReserveCostsPercent;
        public decimal? ContingencyReserveCostsPercent { get { return _contingencyReserveCostsPercent; } set { _contingencyReserveCostsPercent = value; } }
        private Value<decimal?> _contractSalesPrice;
        public decimal? ContractSalesPrice { get { return _contractSalesPrice; } set { _contractSalesPrice = value; } }
        private Value<string> _criteriaForAppropriateLTVFactor;
        public string CriteriaForAppropriateLTVFactor { get { return _criteriaForAppropriateLTVFactor; } set { _criteriaForAppropriateLTVFactor = value; } }
        private Value<string> _dealerContractorAddress;
        public string DealerContractorAddress { get { return _dealerContractorAddress; } set { _dealerContractorAddress = value; } }
        private Value<string> _dealerContractorCity;
        public string DealerContractorCity { get { return _dealerContractorCity; } set { _dealerContractorCity = value; } }
        private Value<string> _dealerContractorName;
        public string DealerContractorName { get { return _dealerContractorName; } set { _dealerContractorName = value; } }
        private Value<string> _dealerContractorPostalCode;
        public string DealerContractorPostalCode { get { return _dealerContractorPostalCode; } set { _dealerContractorPostalCode = value; } }
        private Value<string> _dealerContractorState;
        public string DealerContractorState { get { return _dealerContractorState; } set { _dealerContractorState = value; } }
        private Value<decimal?> _discountPointsAmount;
        public decimal? DiscountPointsAmount { get { return _discountPointsAmount; } set { _discountPointsAmount = value; } }
        private Value<decimal?> _discountPointsPercent;
        public decimal? DiscountPointsPercent { get { return _discountPointsPercent; } set { _discountPointsPercent = value; } }
        private Value<bool?> _eEMIndicator;
        public bool? EEMIndicator { get { return _eEMIndicator; } set { _eEMIndicator = value; } }
        private Value<decimal?> _energyEfficientMortgageAmount;
        public decimal? EnergyEfficientMortgageAmount { get { return _energyEfficientMortgageAmount; } set { _energyEfficientMortgageAmount = value; } }
        private Value<string> _escrowCommitment;
        public string EscrowCommitment { get { return _escrowCommitment; } set { _escrowCommitment = value; } }
        private Value<decimal?> _escrowShortages;
        public decimal? EscrowShortages { get { return _escrowShortages; } set { _escrowShortages = value; } }
        private Value<decimal?> _existing203KDebtTotal;
        public decimal? Existing203KDebtTotal { get { return _existing203KDebtTotal; } set { _existing203KDebtTotal = value; } }
        private Value<bool?> _existingDebt;
        public bool? ExistingDebt { get { return _existingDebt; } set { _existingDebt = value; } }
        private Value<decimal?> _existingDebtPlusRehabCosts;
        public decimal? ExistingDebtPlusRehabCosts { get { return _existingDebtPlusRehabCosts; } set { _existingDebtPlusRehabCosts = value; } }
        private Value<decimal?> _existingDebtPlusRehabCostsPlusNewLoanFees;
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get { return _existingDebtPlusRehabCostsPlusNewLoanFees; } set { _existingDebtPlusRehabCostsPlusNewLoanFees = value; } }
        private Value<decimal?> _feasibilityStudyWhenNecessary;
        public decimal? FeasibilityStudyWhenNecessary { get { return _feasibilityStudyWhenNecessary; } set { _feasibilityStudyWhenNecessary = value; } }
        private Value<decimal?> _feesAssociatedWithNewLoan;
        public decimal? FeesAssociatedWithNewLoan { get { return _feesAssociatedWithNewLoan; } set { _feesAssociatedWithNewLoan = value; } }
        private Value<decimal?> _fHA203kB10SubTotal;
        public decimal? FHA203kB10SubTotal { get { return _fHA203kB10SubTotal; } set { _fHA203kB10SubTotal = value; } }
        private Value<string> _fHA203kRemarks;
        public string FHA203kRemarks { get { return _fHA203kRemarks; } set { _fHA203kRemarks = value; } }
        private Value<string> _fHAStreamlineType;
        public string FHAStreamlineType { get { return _fHAStreamlineType; } set { _fHAStreamlineType = value; } }
        private Value<decimal?> _finalBaseMortgageAmount;
        public decimal? FinalBaseMortgageAmount { get { return _finalBaseMortgageAmount; } set { _finalBaseMortgageAmount = value; } }
        private Value<decimal?> _financeableMortgageFeesIfCharged;
        public decimal? FinanceableMortgageFeesIfCharged { get { return _financeableMortgageFeesIfCharged; } set { _financeableMortgageFeesIfCharged = value; } }
        private Value<bool?> _haveOtherPendingApplicationForFHA;
        public bool? HaveOtherPendingApplicationForFHA { get { return _haveOtherPendingApplicationForFHA; } set { _haveOtherPendingApplicationForFHA = value; } }
        private Value<bool?> _hUDOwned;
        public bool? HUDOwned { get { return _hUDOwned; } set { _hUDOwned = value; } }
        private Value<bool?> _hUDREOIndicator;
        public bool? HUDREOIndicator { get { return _hUDREOIndicator; } set { _hUDREOIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _independentConsultantFee;
        public decimal? IndependentConsultantFee { get { return _independentConsultantFee; } set { _independentConsultantFee = value; } }
        private Value<decimal?> _initialBaseMortgageAmountPlusEEMImprovementAmount;
        public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get { return _initialBaseMortgageAmountPlusEEMImprovementAmount; } set { _initialBaseMortgageAmountPlusEEMImprovementAmount = value; } }
        private Value<decimal?> _initialDrawAtClosingArchitecturalorEngineeringFees;
        public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get { return _initialDrawAtClosingArchitecturalorEngineeringFees; } set { _initialDrawAtClosingArchitecturalorEngineeringFees = value; } }
        private Value<decimal?> _initialDrawAtClosingConsultantFees;
        public decimal? InitialDrawAtClosingConsultantFees { get { return _initialDrawAtClosingConsultantFees; } set { _initialDrawAtClosingConsultantFees = value; } }
        private Value<decimal?> _initialDrawAtClosingPermitFees;
        public decimal? InitialDrawAtClosingPermitFees { get { return _initialDrawAtClosingPermitFees; } set { _initialDrawAtClosingPermitFees = value; } }
        private Value<decimal?> _initialDrawAtClosingTotal;
        public decimal? InitialDrawAtClosingTotal { get { return _initialDrawAtClosingTotal; } set { _initialDrawAtClosingTotal = value; } }
        private Value<decimal?> _inspectionFeeAmount;
        public decimal? InspectionFeeAmount { get { return _inspectionFeeAmount; } set { _inspectionFeeAmount = value; } }
        private Value<decimal?> _inspectionFeesDuringRehabilitation;
        public decimal? InspectionFeesDuringRehabilitation { get { return _inspectionFeesDuringRehabilitation; } set { _inspectionFeesDuringRehabilitation = value; } }
        private Value<int?> _inspectionFeeTimes;
        public int? InspectionFeeTimes { get { return _inspectionFeeTimes; } set { _inspectionFeeTimes = value; } }
        private Value<decimal?> _interestDueonExistingMortgage;
        public decimal? InterestDueonExistingMortgage { get { return _interestDueonExistingMortgage; } set { _interestDueonExistingMortgage = value; } }
        private Value<decimal?> _lateCharges;
        public decimal? LateCharges { get { return _lateCharges; } set { _lateCharges = value; } }
        private Value<bool?> _lDPGSAForBorrower;
        public bool? LDPGSAForBorrower { get { return _lDPGSAForBorrower; } set { _lDPGSAForBorrower = value; } }
        private Value<bool?> _lDPGSAForCoBorrower;
        public bool? LDPGSAForCoBorrower { get { return _lDPGSAForCoBorrower; } set { _lDPGSAForCoBorrower = value; } }
        private Value<bool?> _leasedFromSomeoneElse;
        public bool? LeasedFromSomeoneElse { get { return _leasedFromSomeoneElse; } set { _leasedFromSomeoneElse = value; } }
        private Value<DateTime?> _leaseExpiradionDate;
        public DateTime? LeaseExpiradionDate { get { return _leaseExpiradionDate; } set { _leaseExpiradionDate = value; } }
        private Value<decimal?> _leaseMonthlyPayment;
        public decimal? LeaseMonthlyPayment { get { return _leaseMonthlyPayment; } set { _leaseMonthlyPayment = value; } }
        private Value<decimal?> _lessAllowableDownpayment;
        public decimal? LessAllowableDownpayment { get { return _lessAllowableDownpayment; } set { _lessAllowableDownpayment = value; } }
        private Value<decimal?> _lesserOf3AOr3B;
        public decimal? LesserOf3AOr3B { get { return _lesserOf3AOr3B; } set { _lesserOf3AOr3B = value; } }
        private Value<decimal?> _lesserOf3AOr3BMultiply3F;
        public decimal? LesserOf3AOr3BMultiply3F { get { return _lesserOf3AOr3BMultiply3F; } set { _lesserOf3AOr3BMultiply3F = value; } }
        private Value<decimal?> _lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get { return _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; } set { _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = value; } }
        private Value<decimal?> _lesserOfSalesPrice;
        public decimal? LesserOfSalesPrice { get { return _lesserOfSalesPrice; } set { _lesserOfSalesPrice = value; } }
        private Value<decimal?> _lesserOfSumAmount;
        public decimal? LesserOfSumAmount { get { return _lesserOfSumAmount; } set { _lesserOfSumAmount = value; } }
        private Value<decimal?> _lesserOfSumAsIs;
        public decimal? LesserOfSumAsIs { get { return _lesserOfSumAsIs; } set { _lesserOfSumAsIs = value; } }
        private Value<decimal?> _lesserOfSumPercent;
        public decimal? LesserOfSumPercent { get { return _lesserOfSumPercent; } set { _lesserOfSumPercent = value; } }
        private Value<decimal?> _lessLeadBasedPaintCredit;
        public decimal? LessLeadBasedPaintCredit { get { return _lessLeadBasedPaintCredit; } set { _lessLeadBasedPaintCredit = value; } }
        private Value<bool?> _limitedProgram;
        public bool? LimitedProgram { get { return _limitedProgram; } set { _limitedProgram = value; } }
        private Value<bool?> _loanFor203KIndicator;
        public bool? LoanFor203KIndicator { get { return _loanFor203KIndicator; } set { _loanFor203KIndicator = value; } }
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        private Value<decimal?> _materialCostsOrderedPrepaidByBorrowerContractor;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get { return _materialCostsOrderedPrepaidByBorrowerContractor; } set { _materialCostsOrderedPrepaidByBorrowerContractor = value; } }
        private Value<decimal?> _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get { return _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; } set { _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = value; } }
        private Value<decimal?> _maximumMortgageWithUFMIP;
        public decimal? MaximumMortgageWithUFMIP { get { return _maximumMortgageWithUFMIP; } set { _maximumMortgageWithUFMIP = value; } }
        private Value<decimal?> _mIPDueOnExistingMortgage;
        public decimal? MIPDueOnExistingMortgage { get { return _mIPDueOnExistingMortgage; } set { _mIPDueOnExistingMortgage = value; } }
        private Value<decimal?> _mIPLTV;
        public decimal? MIPLTV { get { return _mIPLTV; } set { _mIPLTV = value; } }
        private Value<bool?> _mtgOrDeedOfTrusOnProperty;
        public bool? MtgOrDeedOfTrusOnProperty { get { return _mtgOrDeedOfTrusOnProperty; } set { _mtgOrDeedOfTrusOnProperty = value; } }
        private Value<decimal?> _mtgPaymentEscrowedAmount;
        public decimal? MtgPaymentEscrowedAmount { get { return _mtgPaymentEscrowedAmount; } set { _mtgPaymentEscrowedAmount = value; } }
        private Value<int?> _mtgPaymentEscrowedTimes;
        public int? MtgPaymentEscrowedTimes { get { return _mtgPaymentEscrowedTimes; } set { _mtgPaymentEscrowedTimes = value; } }
        private Value<decimal?> _nationwideMortgageLimit;
        public decimal? NationwideMortgageLimit { get { return _nationwideMortgageLimit; } set { _nationwideMortgageLimit = value; } }
        private Value<decimal?> _nationwideMortgageLimitAfter120Percent;
        public decimal? NationwideMortgageLimitAfter120Percent { get { return _nationwideMortgageLimitAfter120Percent; } set { _nationwideMortgageLimitAfter120Percent = value; } }
        private Value<bool?> _newResidential;
        public bool? NewResidential { get { return _newResidential; } set { _newResidential = value; } }
        private Value<string> _nonresidentialTypeOfUse;
        public string NonresidentialTypeOfUse { get { return _nonresidentialTypeOfUse; } set { _nonresidentialTypeOfUse = value; } }
        private Value<int?> _numberOfHistoricUnits;
        public int? NumberOfHistoricUnits { get { return _numberOfHistoricUnits; } set { _numberOfHistoricUnits = value; } }
        private Value<int?> _numberOfMultifamilyUnits;
        public int? NumberOfMultifamilyUnits { get { return _numberOfMultifamilyUnits; } set { _numberOfMultifamilyUnits = value; } }
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private Value<bool?> _ownedByBorrower;
        public bool? OwnedByBorrower { get { return _ownedByBorrower; } set { _ownedByBorrower = value; } }
        private Value<decimal?> _percentAfterImprovedValue;
        public decimal? PercentAfterImprovedValue { get { return _percentAfterImprovedValue; } set { _percentAfterImprovedValue = value; } }
        private Value<decimal?> _permitsAndOtherFee;
        public decimal? PermitsAndOtherFee { get { return _permitsAndOtherFee; } set { _permitsAndOtherFee = value; } }
        private Value<decimal?> _planReviewerFeeAddition;
        public decimal? PlanReviewerFeeAddition { get { return _planReviewerFeeAddition; } set { _planReviewerFeeAddition = value; } }
        private Value<decimal?> _planReviewerFeeAmount;
        public decimal? PlanReviewerFeeAmount { get { return _planReviewerFeeAmount; } set { _planReviewerFeeAmount = value; } }
        private Value<int?> _planReviewerFeeMiles;
        public int? PlanReviewerFeeMiles { get { return _planReviewerFeeMiles; } set { _planReviewerFeeMiles = value; } }
        private Value<decimal?> _prepaymentPenalties;
        public decimal? PrepaymentPenalties { get { return _prepaymentPenalties; } set { _prepaymentPenalties = value; } }
        private Value<string> _propertyOwnerAddress;
        public string PropertyOwnerAddress { get { return _propertyOwnerAddress; } set { _propertyOwnerAddress = value; } }
        private Value<string> _propertyOwnerCity;
        public string PropertyOwnerCity { get { return _propertyOwnerCity; } set { _propertyOwnerCity = value; } }
        private Value<string> _propertyOwnerName;
        public string PropertyOwnerName { get { return _propertyOwnerName; } set { _propertyOwnerName = value; } }
        private Value<string> _propertyOwnerPostalCode;
        public string PropertyOwnerPostalCode { get { return _propertyOwnerPostalCode; } set { _propertyOwnerPostalCode = value; } }
        private Value<string> _propertyOwnerState;
        public string PropertyOwnerState { get { return _propertyOwnerState; } set { _propertyOwnerState = value; } }
        private Value<string> _propertyToBeImproved;
        public string PropertyToBeImproved { get { return _propertyToBeImproved; } set { _propertyToBeImproved = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<DateTime?> _purchaseDate;
        public DateTime? PurchaseDate { get { return _purchaseDate; } set { _purchaseDate = value; } }
        private Value<bool?> _purchasedOnContract;
        public bool? PurchasedOnContract { get { return _purchasedOnContract; } set { _purchasedOnContract = value; } }
        private Value<decimal?> _purchaseMaximumMortgageAmount;
        public decimal? PurchaseMaximumMortgageAmount { get { return _purchaseMaximumMortgageAmount; } set { _purchaseMaximumMortgageAmount = value; } }
        private Value<decimal?> _purchaseMaximumMortgagePercent;
        public decimal? PurchaseMaximumMortgagePercent { get { return _purchaseMaximumMortgagePercent; } set { _purchaseMaximumMortgagePercent = value; } }
        private Value<decimal?> _purchasePriceLessInducementToPurchase;
        public decimal? PurchasePriceLessInducementToPurchase { get { return _purchasePriceLessInducementToPurchase; } set { _purchasePriceLessInducementToPurchase = value; } }
        private Value<decimal?> _refinanceMaximumMortgageAmount;
        public decimal? RefinanceMaximumMortgageAmount { get { return _refinanceMaximumMortgageAmount; } set { _refinanceMaximumMortgageAmount = value; } }
        private Value<bool?> _refinancingATitleILoan;
        public bool? RefinancingATitleILoan { get { return _refinancingATitleILoan; } set { _refinancingATitleILoan = value; } }
        private Value<decimal?> _rehabilitationEscrowAccount;
        public decimal? RehabilitationEscrowAccount { get { return _rehabilitationEscrowAccount; } set { _rehabilitationEscrowAccount = value; } }
        private Value<decimal?> _rehabilitationEscrowAmountBalanceForFutureDraws;
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get { return _rehabilitationEscrowAmountBalanceForFutureDraws; } set { _rehabilitationEscrowAmountBalanceForFutureDraws = value; } }
        private Value<decimal?> _rentalCashFlowBalance;
        public decimal? RentalCashFlowBalance { get { return _rentalCashFlowBalance; } set { _rentalCashFlowBalance = value; } }
        private Value<string> _residencyType;
        public string ResidencyType { get { return _residencyType; } set { _residencyType = value; } }
        private Value<string> _riskClass;
        public string RiskClass { get { return _riskClass; } set { _riskClass = value; } }
        private Value<bool?> _scoredByTotal;
        public bool? ScoredByTotal { get { return _scoredByTotal; } set { _scoredByTotal = value; } }
        private Value<List<SecondaryFinancingProvider>> _secondaryFinancingProviders;
        public List<SecondaryFinancingProvider> SecondaryFinancingProviders { get { return _secondaryFinancingProviders; } set { _secondaryFinancingProviders = value; } }
        private Value<decimal?> _sellerContributionRate;
        public decimal? SellerContributionRate { get { return _sellerContributionRate; } set { _sellerContributionRate = value; } }
        private Value<bool?> _simpleRefinance;
        public bool? SimpleRefinance { get { return _simpleRefinance; } set { _simpleRefinance = value; } }
        private Value<decimal?> _statutoryInvestment;
        public decimal? StatutoryInvestment { get { return _statutoryInvestment; } set { _statutoryInvestment = value; } }
        private Value<decimal?> _step2EPlusStep1E;
        public decimal? Step2EPlusStep1E { get { return _step2EPlusStep1E; } set { _step2EPlusStep1E = value; } }
        private Value<bool?> _streamlined;
        public bool? Streamlined { get { return _streamlined; } set { _streamlined = value; } }
        private Value<decimal?> _subTotalForEscrowAccount;
        public decimal? SubTotalForEscrowAccount { get { return _subTotalForEscrowAccount; } set { _subTotalForEscrowAccount = value; } }
        private Value<decimal?> _subTotalForReleaseAtClosing;
        public decimal? SubTotalForReleaseAtClosing { get { return _subTotalForReleaseAtClosing; } set { _subTotalForReleaseAtClosing = value; } }
        private Value<decimal?> _sumForInvestor;
        public decimal? SumForInvestor { get { return _sumForInvestor; } set { _sumForInvestor = value; } }
        private Value<decimal?> _sumForOwnerOccupied;
        public decimal? SumForOwnerOccupied { get { return _sumForOwnerOccupied; } set { _sumForOwnerOccupied = value; } }
        private Value<decimal?> _sumOfExistingDebt;
        public decimal? SumOfExistingDebt { get { return _sumOfExistingDebt; } set { _sumOfExistingDebt = value; } }
        private Value<decimal?> _suplementalOriginationFee;
        public decimal? SuplementalOriginationFee { get { return _suplementalOriginationFee; } set { _suplementalOriginationFee = value; } }
        private Value<decimal?> _title1LoanBalance;
        public decimal? Title1LoanBalance { get { return _title1LoanBalance; } set { _title1LoanBalance = value; } }
        private Value<string> _title1LoanNumber;
        public string Title1LoanNumber { get { return _title1LoanNumber; } set { _title1LoanNumber = value; } }
        private Value<string> _title1LoanWithWhom;
        public string Title1LoanWithWhom { get { return _title1LoanWithWhom; } set { _title1LoanWithWhom = value; } }
        private Value<decimal?> _titleUpdateFeeAmount;
        public decimal? TitleUpdateFeeAmount { get { return _titleUpdateFeeAmount; } set { _titleUpdateFeeAmount = value; } }
        private Value<decimal?> _titleUpdateFees;
        public decimal? TitleUpdateFees { get { return _titleUpdateFees; } set { _titleUpdateFees = value; } }
        private Value<int?> _titleUpdateFeeTimes;
        public int? TitleUpdateFeeTimes { get { return _titleUpdateFeeTimes; } set { _titleUpdateFeeTimes = value; } }
        private Value<decimal?> _totalCostsOfRepairsInA6;
        public decimal? TotalCostsOfRepairsInA6 { get { return _totalCostsOfRepairsInA6; } set { _totalCostsOfRepairsInA6 = value; } }
        private Value<decimal?> _totalEscrowCommitment;
        public decimal? TotalEscrowCommitment { get { return _totalEscrowCommitment; } set { _totalEscrowCommitment = value; } }
        private Value<decimal?> _totalEscrowedFunds;
        public decimal? TotalEscrowedFunds { get { return _totalEscrowedFunds; } set { _totalEscrowedFunds = value; } }
        private Value<decimal?> _totalFixedUnpaidBalance;
        public decimal? TotalFixedUnpaidBalance { get { return _totalFixedUnpaidBalance; } set { _totalFixedUnpaidBalance = value; } }
        private Value<decimal?> _totalForBorrowerEstimatedProfit;
        public decimal? TotalForBorrowerEstimatedProfit { get { return _totalForBorrowerEstimatedProfit; } set { _totalForBorrowerEstimatedProfit = value; } }
        private Value<decimal?> _totalForInspectionAndTitleFee;
        public decimal? TotalForInspectionAndTitleFee { get { return _totalForInspectionAndTitleFee; } set { _totalForInspectionAndTitleFee = value; } }
        private Value<decimal?> _totalForLesserOfSumAsIs;
        public decimal? TotalForLesserOfSumAsIs { get { return _totalForLesserOfSumAsIs; } set { _totalForLesserOfSumAsIs = value; } }
        private Value<decimal?> _totalForMtgPaymentEscrowed;
        public decimal? TotalForMtgPaymentEscrowed { get { return _totalForMtgPaymentEscrowed; } set { _totalForMtgPaymentEscrowed = value; } }
        private Value<decimal?> _totalForPlanReviewerFee;
        public decimal? TotalForPlanReviewerFee { get { return _totalForPlanReviewerFee; } set { _totalForPlanReviewerFee = value; } }
        private Value<decimal?> _totalForRehabilitationCost;
        public decimal? TotalForRehabilitationCost { get { return _totalForRehabilitationCost; } set { _totalForRehabilitationCost = value; } }
        private Value<decimal?> _totalRehabilitationCosts;
        public decimal? TotalRehabilitationCosts { get { return _totalRehabilitationCosts; } set { _totalRehabilitationCosts = value; } }
        private Value<decimal?> _totalRehabilitationCostsFeesReserves;
        public decimal? TotalRehabilitationCostsFeesReserves { get { return _totalRehabilitationCostsFeesReserves; } set { _totalRehabilitationCostsFeesReserves = value; } }
        private Value<decimal?> _unpaidPrincipalBalanceFirstLien;
        public decimal? UnpaidPrincipalBalanceFirstLien { get { return _unpaidPrincipalBalanceFirstLien; } set { _unpaidPrincipalBalanceFirstLien = value; } }
        private Value<decimal?> _unpaidPrincipalBalanceOfAnyJuniorLiens;
        public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get { return _unpaidPrincipalBalanceOfAnyJuniorLiens; } set { _unpaidPrincipalBalanceOfAnyJuniorLiens = value; } }
        private Value<decimal?> _unpaidPrincipalBalanceOfPurchaseJuniorLiens;
        public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get { return _unpaidPrincipalBalanceOfPurchaseJuniorLiens; } set { _unpaidPrincipalBalanceOfPurchaseJuniorLiens = value; } }
        private Value<decimal?> _valueEstablished;
        public decimal? ValueEstablished { get { return _valueEstablished; } set { _valueEstablished = value; } }
        private Value<decimal?> _windEnergySystemActualCost;
        public decimal? WindEnergySystemActualCost { get { return _windEnergySystemActualCost; } set { _windEnergySystemActualCost = value; } }
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
                    && _caseLTV.Clean
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
                    && _escrowShortages.Clean
                    && _existing203KDebtTotal.Clean
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
                    && _initialDrawAtClosingArchitecturalorEngineeringFees.Clean
                    && _initialDrawAtClosingConsultantFees.Clean
                    && _initialDrawAtClosingPermitFees.Clean
                    && _initialDrawAtClosingTotal.Clean
                    && _inspectionFeeAmount.Clean
                    && _inspectionFeesDuringRehabilitation.Clean
                    && _inspectionFeeTimes.Clean
                    && _interestDueonExistingMortgage.Clean
                    && _lateCharges.Clean
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
                    && _lessLeadBasedPaintCredit.Clean
                    && _limitedProgram.Clean
                    && _loanFor203KIndicator.Clean
                    && _loanPurpose.Clean
                    && _materialCostsOrderedPrepaidByBorrowerContractor.Clean
                    && _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean
                    && _maximumMortgageWithUFMIP.Clean
                    && _mIPDueOnExistingMortgage.Clean
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
                    && _prepaymentPenalties.Clean
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
                    && _unpaidPrincipalBalanceFirstLien.Clean
                    && _unpaidPrincipalBalanceOfAnyJuniorLiens.Clean
                    && _unpaidPrincipalBalanceOfPurchaseJuniorLiens.Clean
                    && _valueEstablished.Clean
                    && _windEnergySystemActualCost.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var actualCashInvRequired = _actualCashInvRequired; actualCashInvRequired.Clean = value; _actualCashInvRequired = actualCashInvRequired;
                var adjustedMaxMtgAmount = _adjustedMaxMtgAmount; adjustedMaxMtgAmount.Clean = value; _adjustedMaxMtgAmount = adjustedMaxMtgAmount;
                var afterImprovedValue = _afterImprovedValue; afterImprovedValue.Clean = value; _afterImprovedValue = afterImprovedValue;
                var afterImprovedValueAfter20Percent = _afterImprovedValueAfter20Percent; afterImprovedValueAfter20Percent.Clean = value; _afterImprovedValueAfter20Percent = afterImprovedValueAfter20Percent;
                var allowableEnergyImprovements = _allowableEnergyImprovements; allowableEnergyImprovements.Clean = value; _allowableEnergyImprovements = allowableEnergyImprovements;
                var appropriateLTVFactor = _appropriateLTVFactor; appropriateLTVFactor.Clean = value; _appropriateLTVFactor = appropriateLTVFactor;
                var architecturalEngineeringFee = _architecturalEngineeringFee; architecturalEngineeringFee.Clean = value; _architecturalEngineeringFee = architecturalEngineeringFee;
                var asIsValue = _asIsValue; asIsValue.Clean = value; _asIsValue = asIsValue;
                var baseMortgageAmountFrom3COr3D = _baseMortgageAmountFrom3COr3D; baseMortgageAmountFrom3COr3D.Clean = value; _baseMortgageAmountFrom3COr3D = baseMortgageAmountFrom3COr3D;
                var borrowerAcknowledgement = _borrowerAcknowledgement; borrowerAcknowledgement.Clean = value; _borrowerAcknowledgement = borrowerAcknowledgement;
                var borrowerEstimatedProfit1 = _borrowerEstimatedProfit1; borrowerEstimatedProfit1.Clean = value; _borrowerEstimatedProfit1 = borrowerEstimatedProfit1;
                var borrowerEstimatedProfit2 = _borrowerEstimatedProfit2; borrowerEstimatedProfit2.Clean = value; _borrowerEstimatedProfit2 = borrowerEstimatedProfit2;
                var borrowerPaidClosingCosts = _borrowerPaidClosingCosts; borrowerPaidClosingCosts.Clean = value; _borrowerPaidClosingCosts = borrowerPaidClosingCosts;
                var borrowerRequiredInvestment = _borrowerRequiredInvestment; borrowerRequiredInvestment.Clean = value; _borrowerRequiredInvestment = borrowerRequiredInvestment;
                var borrowersOwnFundsforContingencyReserves = _borrowersOwnFundsforContingencyReserves; borrowersOwnFundsforContingencyReserves.Clean = value; _borrowersOwnFundsforContingencyReserves = borrowersOwnFundsforContingencyReserves;
                var buildingOnOwnLand = _buildingOnOwnLand; buildingOnOwnLand.Clean = value; _buildingOnOwnLand = buildingOnOwnLand;
                var caseAssignedDate = _caseAssignedDate; caseAssignedDate.Clean = value; _caseAssignedDate = caseAssignedDate;
                var caseLTV = _caseLTV; caseLTV.Clean = value; _caseLTV = caseLTV;
                var childSupportBalance = _childSupportBalance; childSupportBalance.Clean = value; _childSupportBalance = childSupportBalance;
                var cHUMSForAppraisal = _cHUMSForAppraisal; cHUMSForAppraisal.Clean = value; _cHUMSForAppraisal = cHUMSForAppraisal;
                var commitmentMaximumMortgageAmount = _commitmentMaximumMortgageAmount; commitmentMaximumMortgageAmount.Clean = value; _commitmentMaximumMortgageAmount = commitmentMaximumMortgageAmount;
                var commitmentStage = _commitmentStage; commitmentStage.Clean = value; _commitmentStage = commitmentStage;
                var constructionRepairsRehabilitationCosts = _constructionRepairsRehabilitationCosts; constructionRepairsRehabilitationCosts.Clean = value; _constructionRepairsRehabilitationCosts = constructionRepairsRehabilitationCosts;
                var contingencyReserveCostsAmount = _contingencyReserveCostsAmount; contingencyReserveCostsAmount.Clean = value; _contingencyReserveCostsAmount = contingencyReserveCostsAmount;
                var contingencyReserveCostsPercent = _contingencyReserveCostsPercent; contingencyReserveCostsPercent.Clean = value; _contingencyReserveCostsPercent = contingencyReserveCostsPercent;
                var contractSalesPrice = _contractSalesPrice; contractSalesPrice.Clean = value; _contractSalesPrice = contractSalesPrice;
                var criteriaForAppropriateLTVFactor = _criteriaForAppropriateLTVFactor; criteriaForAppropriateLTVFactor.Clean = value; _criteriaForAppropriateLTVFactor = criteriaForAppropriateLTVFactor;
                var dealerContractorAddress = _dealerContractorAddress; dealerContractorAddress.Clean = value; _dealerContractorAddress = dealerContractorAddress;
                var dealerContractorCity = _dealerContractorCity; dealerContractorCity.Clean = value; _dealerContractorCity = dealerContractorCity;
                var dealerContractorName = _dealerContractorName; dealerContractorName.Clean = value; _dealerContractorName = dealerContractorName;
                var dealerContractorPostalCode = _dealerContractorPostalCode; dealerContractorPostalCode.Clean = value; _dealerContractorPostalCode = dealerContractorPostalCode;
                var dealerContractorState = _dealerContractorState; dealerContractorState.Clean = value; _dealerContractorState = dealerContractorState;
                var discountPointsAmount = _discountPointsAmount; discountPointsAmount.Clean = value; _discountPointsAmount = discountPointsAmount;
                var discountPointsPercent = _discountPointsPercent; discountPointsPercent.Clean = value; _discountPointsPercent = discountPointsPercent;
                var eEMIndicator = _eEMIndicator; eEMIndicator.Clean = value; _eEMIndicator = eEMIndicator;
                var energyEfficientMortgageAmount = _energyEfficientMortgageAmount; energyEfficientMortgageAmount.Clean = value; _energyEfficientMortgageAmount = energyEfficientMortgageAmount;
                var escrowCommitment = _escrowCommitment; escrowCommitment.Clean = value; _escrowCommitment = escrowCommitment;
                var escrowShortages = _escrowShortages; escrowShortages.Clean = value; _escrowShortages = escrowShortages;
                var existing203KDebtTotal = _existing203KDebtTotal; existing203KDebtTotal.Clean = value; _existing203KDebtTotal = existing203KDebtTotal;
                var existingDebt = _existingDebt; existingDebt.Clean = value; _existingDebt = existingDebt;
                var existingDebtPlusRehabCosts = _existingDebtPlusRehabCosts; existingDebtPlusRehabCosts.Clean = value; _existingDebtPlusRehabCosts = existingDebtPlusRehabCosts;
                var existingDebtPlusRehabCostsPlusNewLoanFees = _existingDebtPlusRehabCostsPlusNewLoanFees; existingDebtPlusRehabCostsPlusNewLoanFees.Clean = value; _existingDebtPlusRehabCostsPlusNewLoanFees = existingDebtPlusRehabCostsPlusNewLoanFees;
                var feasibilityStudyWhenNecessary = _feasibilityStudyWhenNecessary; feasibilityStudyWhenNecessary.Clean = value; _feasibilityStudyWhenNecessary = feasibilityStudyWhenNecessary;
                var feesAssociatedWithNewLoan = _feesAssociatedWithNewLoan; feesAssociatedWithNewLoan.Clean = value; _feesAssociatedWithNewLoan = feesAssociatedWithNewLoan;
                var fHA203kB10SubTotal = _fHA203kB10SubTotal; fHA203kB10SubTotal.Clean = value; _fHA203kB10SubTotal = fHA203kB10SubTotal;
                var fHA203kRemarks = _fHA203kRemarks; fHA203kRemarks.Clean = value; _fHA203kRemarks = fHA203kRemarks;
                var fHAStreamlineType = _fHAStreamlineType; fHAStreamlineType.Clean = value; _fHAStreamlineType = fHAStreamlineType;
                var finalBaseMortgageAmount = _finalBaseMortgageAmount; finalBaseMortgageAmount.Clean = value; _finalBaseMortgageAmount = finalBaseMortgageAmount;
                var financeableMortgageFeesIfCharged = _financeableMortgageFeesIfCharged; financeableMortgageFeesIfCharged.Clean = value; _financeableMortgageFeesIfCharged = financeableMortgageFeesIfCharged;
                var haveOtherPendingApplicationForFHA = _haveOtherPendingApplicationForFHA; haveOtherPendingApplicationForFHA.Clean = value; _haveOtherPendingApplicationForFHA = haveOtherPendingApplicationForFHA;
                var hUDOwned = _hUDOwned; hUDOwned.Clean = value; _hUDOwned = hUDOwned;
                var hUDREOIndicator = _hUDREOIndicator; hUDREOIndicator.Clean = value; _hUDREOIndicator = hUDREOIndicator;
                var id = _id; id.Clean = value; _id = id;
                var independentConsultantFee = _independentConsultantFee; independentConsultantFee.Clean = value; _independentConsultantFee = independentConsultantFee;
                var initialBaseMortgageAmountPlusEEMImprovementAmount = _initialBaseMortgageAmountPlusEEMImprovementAmount; initialBaseMortgageAmountPlusEEMImprovementAmount.Clean = value; _initialBaseMortgageAmountPlusEEMImprovementAmount = initialBaseMortgageAmountPlusEEMImprovementAmount;
                var initialDrawAtClosingArchitecturalorEngineeringFees = _initialDrawAtClosingArchitecturalorEngineeringFees; initialDrawAtClosingArchitecturalorEngineeringFees.Clean = value; _initialDrawAtClosingArchitecturalorEngineeringFees = initialDrawAtClosingArchitecturalorEngineeringFees;
                var initialDrawAtClosingConsultantFees = _initialDrawAtClosingConsultantFees; initialDrawAtClosingConsultantFees.Clean = value; _initialDrawAtClosingConsultantFees = initialDrawAtClosingConsultantFees;
                var initialDrawAtClosingPermitFees = _initialDrawAtClosingPermitFees; initialDrawAtClosingPermitFees.Clean = value; _initialDrawAtClosingPermitFees = initialDrawAtClosingPermitFees;
                var initialDrawAtClosingTotal = _initialDrawAtClosingTotal; initialDrawAtClosingTotal.Clean = value; _initialDrawAtClosingTotal = initialDrawAtClosingTotal;
                var inspectionFeeAmount = _inspectionFeeAmount; inspectionFeeAmount.Clean = value; _inspectionFeeAmount = inspectionFeeAmount;
                var inspectionFeesDuringRehabilitation = _inspectionFeesDuringRehabilitation; inspectionFeesDuringRehabilitation.Clean = value; _inspectionFeesDuringRehabilitation = inspectionFeesDuringRehabilitation;
                var inspectionFeeTimes = _inspectionFeeTimes; inspectionFeeTimes.Clean = value; _inspectionFeeTimes = inspectionFeeTimes;
                var interestDueonExistingMortgage = _interestDueonExistingMortgage; interestDueonExistingMortgage.Clean = value; _interestDueonExistingMortgage = interestDueonExistingMortgage;
                var lateCharges = _lateCharges; lateCharges.Clean = value; _lateCharges = lateCharges;
                var lDPGSAForBorrower = _lDPGSAForBorrower; lDPGSAForBorrower.Clean = value; _lDPGSAForBorrower = lDPGSAForBorrower;
                var lDPGSAForCoBorrower = _lDPGSAForCoBorrower; lDPGSAForCoBorrower.Clean = value; _lDPGSAForCoBorrower = lDPGSAForCoBorrower;
                var leasedFromSomeoneElse = _leasedFromSomeoneElse; leasedFromSomeoneElse.Clean = value; _leasedFromSomeoneElse = leasedFromSomeoneElse;
                var leaseExpiradionDate = _leaseExpiradionDate; leaseExpiradionDate.Clean = value; _leaseExpiradionDate = leaseExpiradionDate;
                var leaseMonthlyPayment = _leaseMonthlyPayment; leaseMonthlyPayment.Clean = value; _leaseMonthlyPayment = leaseMonthlyPayment;
                var lessAllowableDownpayment = _lessAllowableDownpayment; lessAllowableDownpayment.Clean = value; _lessAllowableDownpayment = lessAllowableDownpayment;
                var lesserOf3AOr3B = _lesserOf3AOr3B; lesserOf3AOr3B.Clean = value; _lesserOf3AOr3B = lesserOf3AOr3B;
                var lesserOf3AOr3BMultiply3F = _lesserOf3AOr3BMultiply3F; lesserOf3AOr3BMultiply3F.Clean = value; _lesserOf3AOr3BMultiply3F = lesserOf3AOr3BMultiply3F;
                var lesserOfMaximumFinanceableSolarOrWindEnergyAmount = _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; lesserOfMaximumFinanceableSolarOrWindEnergyAmount.Clean = value; _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
                var lesserOfSalesPrice = _lesserOfSalesPrice; lesserOfSalesPrice.Clean = value; _lesserOfSalesPrice = lesserOfSalesPrice;
                var lesserOfSumAmount = _lesserOfSumAmount; lesserOfSumAmount.Clean = value; _lesserOfSumAmount = lesserOfSumAmount;
                var lesserOfSumAsIs = _lesserOfSumAsIs; lesserOfSumAsIs.Clean = value; _lesserOfSumAsIs = lesserOfSumAsIs;
                var lesserOfSumPercent = _lesserOfSumPercent; lesserOfSumPercent.Clean = value; _lesserOfSumPercent = lesserOfSumPercent;
                var lessLeadBasedPaintCredit = _lessLeadBasedPaintCredit; lessLeadBasedPaintCredit.Clean = value; _lessLeadBasedPaintCredit = lessLeadBasedPaintCredit;
                var limitedProgram = _limitedProgram; limitedProgram.Clean = value; _limitedProgram = limitedProgram;
                var loanFor203KIndicator = _loanFor203KIndicator; loanFor203KIndicator.Clean = value; _loanFor203KIndicator = loanFor203KIndicator;
                var loanPurpose = _loanPurpose; loanPurpose.Clean = value; _loanPurpose = loanPurpose;
                var materialCostsOrderedPrepaidByBorrowerContractor = _materialCostsOrderedPrepaidByBorrowerContractor; materialCostsOrderedPrepaidByBorrowerContractor.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractor = materialCostsOrderedPrepaidByBorrowerContractor;
                var materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
                var maximumMortgageWithUFMIP = _maximumMortgageWithUFMIP; maximumMortgageWithUFMIP.Clean = value; _maximumMortgageWithUFMIP = maximumMortgageWithUFMIP;
                var mIPDueOnExistingMortgage = _mIPDueOnExistingMortgage; mIPDueOnExistingMortgage.Clean = value; _mIPDueOnExistingMortgage = mIPDueOnExistingMortgage;
                var mIPLTV = _mIPLTV; mIPLTV.Clean = value; _mIPLTV = mIPLTV;
                var mtgOrDeedOfTrusOnProperty = _mtgOrDeedOfTrusOnProperty; mtgOrDeedOfTrusOnProperty.Clean = value; _mtgOrDeedOfTrusOnProperty = mtgOrDeedOfTrusOnProperty;
                var mtgPaymentEscrowedAmount = _mtgPaymentEscrowedAmount; mtgPaymentEscrowedAmount.Clean = value; _mtgPaymentEscrowedAmount = mtgPaymentEscrowedAmount;
                var mtgPaymentEscrowedTimes = _mtgPaymentEscrowedTimes; mtgPaymentEscrowedTimes.Clean = value; _mtgPaymentEscrowedTimes = mtgPaymentEscrowedTimes;
                var nationwideMortgageLimit = _nationwideMortgageLimit; nationwideMortgageLimit.Clean = value; _nationwideMortgageLimit = nationwideMortgageLimit;
                var nationwideMortgageLimitAfter120Percent = _nationwideMortgageLimitAfter120Percent; nationwideMortgageLimitAfter120Percent.Clean = value; _nationwideMortgageLimitAfter120Percent = nationwideMortgageLimitAfter120Percent;
                var newResidential = _newResidential; newResidential.Clean = value; _newResidential = newResidential;
                var nonresidentialTypeOfUse = _nonresidentialTypeOfUse; nonresidentialTypeOfUse.Clean = value; _nonresidentialTypeOfUse = nonresidentialTypeOfUse;
                var numberOfHistoricUnits = _numberOfHistoricUnits; numberOfHistoricUnits.Clean = value; _numberOfHistoricUnits = numberOfHistoricUnits;
                var numberOfMultifamilyUnits = _numberOfMultifamilyUnits; numberOfMultifamilyUnits.Clean = value; _numberOfMultifamilyUnits = numberOfMultifamilyUnits;
                var otherDescription = _otherDescription; otherDescription.Clean = value; _otherDescription = otherDescription;
                var ownedByBorrower = _ownedByBorrower; ownedByBorrower.Clean = value; _ownedByBorrower = ownedByBorrower;
                var percentAfterImprovedValue = _percentAfterImprovedValue; percentAfterImprovedValue.Clean = value; _percentAfterImprovedValue = percentAfterImprovedValue;
                var permitsAndOtherFee = _permitsAndOtherFee; permitsAndOtherFee.Clean = value; _permitsAndOtherFee = permitsAndOtherFee;
                var planReviewerFeeAddition = _planReviewerFeeAddition; planReviewerFeeAddition.Clean = value; _planReviewerFeeAddition = planReviewerFeeAddition;
                var planReviewerFeeAmount = _planReviewerFeeAmount; planReviewerFeeAmount.Clean = value; _planReviewerFeeAmount = planReviewerFeeAmount;
                var planReviewerFeeMiles = _planReviewerFeeMiles; planReviewerFeeMiles.Clean = value; _planReviewerFeeMiles = planReviewerFeeMiles;
                var prepaymentPenalties = _prepaymentPenalties; prepaymentPenalties.Clean = value; _prepaymentPenalties = prepaymentPenalties;
                var propertyOwnerAddress = _propertyOwnerAddress; propertyOwnerAddress.Clean = value; _propertyOwnerAddress = propertyOwnerAddress;
                var propertyOwnerCity = _propertyOwnerCity; propertyOwnerCity.Clean = value; _propertyOwnerCity = propertyOwnerCity;
                var propertyOwnerName = _propertyOwnerName; propertyOwnerName.Clean = value; _propertyOwnerName = propertyOwnerName;
                var propertyOwnerPostalCode = _propertyOwnerPostalCode; propertyOwnerPostalCode.Clean = value; _propertyOwnerPostalCode = propertyOwnerPostalCode;
                var propertyOwnerState = _propertyOwnerState; propertyOwnerState.Clean = value; _propertyOwnerState = propertyOwnerState;
                var propertyToBeImproved = _propertyToBeImproved; propertyToBeImproved.Clean = value; _propertyToBeImproved = propertyToBeImproved;
                var propertyType = _propertyType; propertyType.Clean = value; _propertyType = propertyType;
                var purchaseDate = _purchaseDate; purchaseDate.Clean = value; _purchaseDate = purchaseDate;
                var purchasedOnContract = _purchasedOnContract; purchasedOnContract.Clean = value; _purchasedOnContract = purchasedOnContract;
                var purchaseMaximumMortgageAmount = _purchaseMaximumMortgageAmount; purchaseMaximumMortgageAmount.Clean = value; _purchaseMaximumMortgageAmount = purchaseMaximumMortgageAmount;
                var purchaseMaximumMortgagePercent = _purchaseMaximumMortgagePercent; purchaseMaximumMortgagePercent.Clean = value; _purchaseMaximumMortgagePercent = purchaseMaximumMortgagePercent;
                var purchasePriceLessInducementToPurchase = _purchasePriceLessInducementToPurchase; purchasePriceLessInducementToPurchase.Clean = value; _purchasePriceLessInducementToPurchase = purchasePriceLessInducementToPurchase;
                var refinanceMaximumMortgageAmount = _refinanceMaximumMortgageAmount; refinanceMaximumMortgageAmount.Clean = value; _refinanceMaximumMortgageAmount = refinanceMaximumMortgageAmount;
                var refinancingATitleILoan = _refinancingATitleILoan; refinancingATitleILoan.Clean = value; _refinancingATitleILoan = refinancingATitleILoan;
                var rehabilitationEscrowAccount = _rehabilitationEscrowAccount; rehabilitationEscrowAccount.Clean = value; _rehabilitationEscrowAccount = rehabilitationEscrowAccount;
                var rehabilitationEscrowAmountBalanceForFutureDraws = _rehabilitationEscrowAmountBalanceForFutureDraws; rehabilitationEscrowAmountBalanceForFutureDraws.Clean = value; _rehabilitationEscrowAmountBalanceForFutureDraws = rehabilitationEscrowAmountBalanceForFutureDraws;
                var rentalCashFlowBalance = _rentalCashFlowBalance; rentalCashFlowBalance.Clean = value; _rentalCashFlowBalance = rentalCashFlowBalance;
                var residencyType = _residencyType; residencyType.Clean = value; _residencyType = residencyType;
                var riskClass = _riskClass; riskClass.Clean = value; _riskClass = riskClass;
                var scoredByTotal = _scoredByTotal; scoredByTotal.Clean = value; _scoredByTotal = scoredByTotal;
                var secondaryFinancingProviders = _secondaryFinancingProviders; secondaryFinancingProviders.Clean = value; _secondaryFinancingProviders = secondaryFinancingProviders;
                var sellerContributionRate = _sellerContributionRate; sellerContributionRate.Clean = value; _sellerContributionRate = sellerContributionRate;
                var simpleRefinance = _simpleRefinance; simpleRefinance.Clean = value; _simpleRefinance = simpleRefinance;
                var statutoryInvestment = _statutoryInvestment; statutoryInvestment.Clean = value; _statutoryInvestment = statutoryInvestment;
                var step2EPlusStep1E = _step2EPlusStep1E; step2EPlusStep1E.Clean = value; _step2EPlusStep1E = step2EPlusStep1E;
                var streamlined = _streamlined; streamlined.Clean = value; _streamlined = streamlined;
                var subTotalForEscrowAccount = _subTotalForEscrowAccount; subTotalForEscrowAccount.Clean = value; _subTotalForEscrowAccount = subTotalForEscrowAccount;
                var subTotalForReleaseAtClosing = _subTotalForReleaseAtClosing; subTotalForReleaseAtClosing.Clean = value; _subTotalForReleaseAtClosing = subTotalForReleaseAtClosing;
                var sumForInvestor = _sumForInvestor; sumForInvestor.Clean = value; _sumForInvestor = sumForInvestor;
                var sumForOwnerOccupied = _sumForOwnerOccupied; sumForOwnerOccupied.Clean = value; _sumForOwnerOccupied = sumForOwnerOccupied;
                var sumOfExistingDebt = _sumOfExistingDebt; sumOfExistingDebt.Clean = value; _sumOfExistingDebt = sumOfExistingDebt;
                var suplementalOriginationFee = _suplementalOriginationFee; suplementalOriginationFee.Clean = value; _suplementalOriginationFee = suplementalOriginationFee;
                var title1LoanBalance = _title1LoanBalance; title1LoanBalance.Clean = value; _title1LoanBalance = title1LoanBalance;
                var title1LoanNumber = _title1LoanNumber; title1LoanNumber.Clean = value; _title1LoanNumber = title1LoanNumber;
                var title1LoanWithWhom = _title1LoanWithWhom; title1LoanWithWhom.Clean = value; _title1LoanWithWhom = title1LoanWithWhom;
                var titleUpdateFeeAmount = _titleUpdateFeeAmount; titleUpdateFeeAmount.Clean = value; _titleUpdateFeeAmount = titleUpdateFeeAmount;
                var titleUpdateFees = _titleUpdateFees; titleUpdateFees.Clean = value; _titleUpdateFees = titleUpdateFees;
                var titleUpdateFeeTimes = _titleUpdateFeeTimes; titleUpdateFeeTimes.Clean = value; _titleUpdateFeeTimes = titleUpdateFeeTimes;
                var totalCostsOfRepairsInA6 = _totalCostsOfRepairsInA6; totalCostsOfRepairsInA6.Clean = value; _totalCostsOfRepairsInA6 = totalCostsOfRepairsInA6;
                var totalEscrowCommitment = _totalEscrowCommitment; totalEscrowCommitment.Clean = value; _totalEscrowCommitment = totalEscrowCommitment;
                var totalEscrowedFunds = _totalEscrowedFunds; totalEscrowedFunds.Clean = value; _totalEscrowedFunds = totalEscrowedFunds;
                var totalFixedUnpaidBalance = _totalFixedUnpaidBalance; totalFixedUnpaidBalance.Clean = value; _totalFixedUnpaidBalance = totalFixedUnpaidBalance;
                var totalForBorrowerEstimatedProfit = _totalForBorrowerEstimatedProfit; totalForBorrowerEstimatedProfit.Clean = value; _totalForBorrowerEstimatedProfit = totalForBorrowerEstimatedProfit;
                var totalForInspectionAndTitleFee = _totalForInspectionAndTitleFee; totalForInspectionAndTitleFee.Clean = value; _totalForInspectionAndTitleFee = totalForInspectionAndTitleFee;
                var totalForLesserOfSumAsIs = _totalForLesserOfSumAsIs; totalForLesserOfSumAsIs.Clean = value; _totalForLesserOfSumAsIs = totalForLesserOfSumAsIs;
                var totalForMtgPaymentEscrowed = _totalForMtgPaymentEscrowed; totalForMtgPaymentEscrowed.Clean = value; _totalForMtgPaymentEscrowed = totalForMtgPaymentEscrowed;
                var totalForPlanReviewerFee = _totalForPlanReviewerFee; totalForPlanReviewerFee.Clean = value; _totalForPlanReviewerFee = totalForPlanReviewerFee;
                var totalForRehabilitationCost = _totalForRehabilitationCost; totalForRehabilitationCost.Clean = value; _totalForRehabilitationCost = totalForRehabilitationCost;
                var totalRehabilitationCosts = _totalRehabilitationCosts; totalRehabilitationCosts.Clean = value; _totalRehabilitationCosts = totalRehabilitationCosts;
                var totalRehabilitationCostsFeesReserves = _totalRehabilitationCostsFeesReserves; totalRehabilitationCostsFeesReserves.Clean = value; _totalRehabilitationCostsFeesReserves = totalRehabilitationCostsFeesReserves;
                var unpaidPrincipalBalanceFirstLien = _unpaidPrincipalBalanceFirstLien; unpaidPrincipalBalanceFirstLien.Clean = value; _unpaidPrincipalBalanceFirstLien = unpaidPrincipalBalanceFirstLien;
                var unpaidPrincipalBalanceOfAnyJuniorLiens = _unpaidPrincipalBalanceOfAnyJuniorLiens; unpaidPrincipalBalanceOfAnyJuniorLiens.Clean = value; _unpaidPrincipalBalanceOfAnyJuniorLiens = unpaidPrincipalBalanceOfAnyJuniorLiens;
                var unpaidPrincipalBalanceOfPurchaseJuniorLiens = _unpaidPrincipalBalanceOfPurchaseJuniorLiens; unpaidPrincipalBalanceOfPurchaseJuniorLiens.Clean = value; _unpaidPrincipalBalanceOfPurchaseJuniorLiens = unpaidPrincipalBalanceOfPurchaseJuniorLiens;
                var valueEstablished = _valueEstablished; valueEstablished.Clean = value; _valueEstablished = valueEstablished;
                var windEnergySystemActualCost = _windEnergySystemActualCost; windEnergySystemActualCost.Clean = value; _windEnergySystemActualCost = windEnergySystemActualCost;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public HudLoanData()
        {
            Clean = true;
        }
    }
}