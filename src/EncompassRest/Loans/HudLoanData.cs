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
                var v17 = _caseLTV; v17.Clean = value; _caseLTV = v17;
                var v18 = _childSupportBalance; v18.Clean = value; _childSupportBalance = v18;
                var v19 = _cHUMSForAppraisal; v19.Clean = value; _cHUMSForAppraisal = v19;
                var v20 = _commitmentMaximumMortgageAmount; v20.Clean = value; _commitmentMaximumMortgageAmount = v20;
                var v21 = _commitmentStage; v21.Clean = value; _commitmentStage = v21;
                var v22 = _constructionRepairsRehabilitationCosts; v22.Clean = value; _constructionRepairsRehabilitationCosts = v22;
                var v23 = _contingencyReserveCostsAmount; v23.Clean = value; _contingencyReserveCostsAmount = v23;
                var v24 = _contingencyReserveCostsPercent; v24.Clean = value; _contingencyReserveCostsPercent = v24;
                var v25 = _contractSalesPrice; v25.Clean = value; _contractSalesPrice = v25;
                var v26 = _criteriaForAppropriateLTVFactor; v26.Clean = value; _criteriaForAppropriateLTVFactor = v26;
                var v27 = _dealerContractorAddress; v27.Clean = value; _dealerContractorAddress = v27;
                var v28 = _dealerContractorCity; v28.Clean = value; _dealerContractorCity = v28;
                var v29 = _dealerContractorName; v29.Clean = value; _dealerContractorName = v29;
                var v30 = _dealerContractorPostalCode; v30.Clean = value; _dealerContractorPostalCode = v30;
                var v31 = _dealerContractorState; v31.Clean = value; _dealerContractorState = v31;
                var v32 = _discountPointsAmount; v32.Clean = value; _discountPointsAmount = v32;
                var v33 = _discountPointsPercent; v33.Clean = value; _discountPointsPercent = v33;
                var v34 = _eEMIndicator; v34.Clean = value; _eEMIndicator = v34;
                var v35 = _energyEfficientMortgageAmount; v35.Clean = value; _energyEfficientMortgageAmount = v35;
                var v36 = _escrowCommitment; v36.Clean = value; _escrowCommitment = v36;
                var v37 = _escrowShortages; v37.Clean = value; _escrowShortages = v37;
                var v38 = _existing203KDebtTotal; v38.Clean = value; _existing203KDebtTotal = v38;
                var v39 = _existingDebt; v39.Clean = value; _existingDebt = v39;
                var v40 = _existingDebtPlusRehabCosts; v40.Clean = value; _existingDebtPlusRehabCosts = v40;
                var v41 = _existingDebtPlusRehabCostsPlusNewLoanFees; v41.Clean = value; _existingDebtPlusRehabCostsPlusNewLoanFees = v41;
                var v42 = _feasibilityStudyWhenNecessary; v42.Clean = value; _feasibilityStudyWhenNecessary = v42;
                var v43 = _feesAssociatedWithNewLoan; v43.Clean = value; _feesAssociatedWithNewLoan = v43;
                var v44 = _fHA203kB10SubTotal; v44.Clean = value; _fHA203kB10SubTotal = v44;
                var v45 = _fHA203kRemarks; v45.Clean = value; _fHA203kRemarks = v45;
                var v46 = _fHAStreamlineType; v46.Clean = value; _fHAStreamlineType = v46;
                var v47 = _finalBaseMortgageAmount; v47.Clean = value; _finalBaseMortgageAmount = v47;
                var v48 = _financeableMortgageFeesIfCharged; v48.Clean = value; _financeableMortgageFeesIfCharged = v48;
                var v49 = _haveOtherPendingApplicationForFHA; v49.Clean = value; _haveOtherPendingApplicationForFHA = v49;
                var v50 = _hUDOwned; v50.Clean = value; _hUDOwned = v50;
                var v51 = _hUDREOIndicator; v51.Clean = value; _hUDREOIndicator = v51;
                var v52 = _id; v52.Clean = value; _id = v52;
                var v53 = _independentConsultantFee; v53.Clean = value; _independentConsultantFee = v53;
                var v54 = _initialBaseMortgageAmountPlusEEMImprovementAmount; v54.Clean = value; _initialBaseMortgageAmountPlusEEMImprovementAmount = v54;
                var v55 = _initialDrawAtClosingArchitecturalorEngineeringFees; v55.Clean = value; _initialDrawAtClosingArchitecturalorEngineeringFees = v55;
                var v56 = _initialDrawAtClosingConsultantFees; v56.Clean = value; _initialDrawAtClosingConsultantFees = v56;
                var v57 = _initialDrawAtClosingPermitFees; v57.Clean = value; _initialDrawAtClosingPermitFees = v57;
                var v58 = _initialDrawAtClosingTotal; v58.Clean = value; _initialDrawAtClosingTotal = v58;
                var v59 = _inspectionFeeAmount; v59.Clean = value; _inspectionFeeAmount = v59;
                var v60 = _inspectionFeesDuringRehabilitation; v60.Clean = value; _inspectionFeesDuringRehabilitation = v60;
                var v61 = _inspectionFeeTimes; v61.Clean = value; _inspectionFeeTimes = v61;
                var v62 = _interestDueonExistingMortgage; v62.Clean = value; _interestDueonExistingMortgage = v62;
                var v63 = _lateCharges; v63.Clean = value; _lateCharges = v63;
                var v64 = _lDPGSAForBorrower; v64.Clean = value; _lDPGSAForBorrower = v64;
                var v65 = _lDPGSAForCoBorrower; v65.Clean = value; _lDPGSAForCoBorrower = v65;
                var v66 = _leasedFromSomeoneElse; v66.Clean = value; _leasedFromSomeoneElse = v66;
                var v67 = _leaseExpiradionDate; v67.Clean = value; _leaseExpiradionDate = v67;
                var v68 = _leaseMonthlyPayment; v68.Clean = value; _leaseMonthlyPayment = v68;
                var v69 = _lessAllowableDownpayment; v69.Clean = value; _lessAllowableDownpayment = v69;
                var v70 = _lesserOf3AOr3B; v70.Clean = value; _lesserOf3AOr3B = v70;
                var v71 = _lesserOf3AOr3BMultiply3F; v71.Clean = value; _lesserOf3AOr3BMultiply3F = v71;
                var v72 = _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; v72.Clean = value; _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = v72;
                var v73 = _lesserOfSalesPrice; v73.Clean = value; _lesserOfSalesPrice = v73;
                var v74 = _lesserOfSumAmount; v74.Clean = value; _lesserOfSumAmount = v74;
                var v75 = _lesserOfSumAsIs; v75.Clean = value; _lesserOfSumAsIs = v75;
                var v76 = _lesserOfSumPercent; v76.Clean = value; _lesserOfSumPercent = v76;
                var v77 = _lessLeadBasedPaintCredit; v77.Clean = value; _lessLeadBasedPaintCredit = v77;
                var v78 = _limitedProgram; v78.Clean = value; _limitedProgram = v78;
                var v79 = _loanFor203KIndicator; v79.Clean = value; _loanFor203KIndicator = v79;
                var v80 = _loanPurpose; v80.Clean = value; _loanPurpose = v80;
                var v81 = _materialCostsOrderedPrepaidByBorrowerContractor; v81.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractor = v81;
                var v82 = _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; v82.Clean = value; _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = v82;
                var v83 = _maximumMortgageWithUFMIP; v83.Clean = value; _maximumMortgageWithUFMIP = v83;
                var v84 = _mIPDueOnExistingMortgage; v84.Clean = value; _mIPDueOnExistingMortgage = v84;
                var v85 = _mIPLTV; v85.Clean = value; _mIPLTV = v85;
                var v86 = _mtgOrDeedOfTrusOnProperty; v86.Clean = value; _mtgOrDeedOfTrusOnProperty = v86;
                var v87 = _mtgPaymentEscrowedAmount; v87.Clean = value; _mtgPaymentEscrowedAmount = v87;
                var v88 = _mtgPaymentEscrowedTimes; v88.Clean = value; _mtgPaymentEscrowedTimes = v88;
                var v89 = _nationwideMortgageLimit; v89.Clean = value; _nationwideMortgageLimit = v89;
                var v90 = _nationwideMortgageLimitAfter120Percent; v90.Clean = value; _nationwideMortgageLimitAfter120Percent = v90;
                var v91 = _newResidential; v91.Clean = value; _newResidential = v91;
                var v92 = _nonresidentialTypeOfUse; v92.Clean = value; _nonresidentialTypeOfUse = v92;
                var v93 = _numberOfHistoricUnits; v93.Clean = value; _numberOfHistoricUnits = v93;
                var v94 = _numberOfMultifamilyUnits; v94.Clean = value; _numberOfMultifamilyUnits = v94;
                var v95 = _otherDescription; v95.Clean = value; _otherDescription = v95;
                var v96 = _ownedByBorrower; v96.Clean = value; _ownedByBorrower = v96;
                var v97 = _percentAfterImprovedValue; v97.Clean = value; _percentAfterImprovedValue = v97;
                var v98 = _permitsAndOtherFee; v98.Clean = value; _permitsAndOtherFee = v98;
                var v99 = _planReviewerFeeAddition; v99.Clean = value; _planReviewerFeeAddition = v99;
                var v100 = _planReviewerFeeAmount; v100.Clean = value; _planReviewerFeeAmount = v100;
                var v101 = _planReviewerFeeMiles; v101.Clean = value; _planReviewerFeeMiles = v101;
                var v102 = _prepaymentPenalties; v102.Clean = value; _prepaymentPenalties = v102;
                var v103 = _propertyOwnerAddress; v103.Clean = value; _propertyOwnerAddress = v103;
                var v104 = _propertyOwnerCity; v104.Clean = value; _propertyOwnerCity = v104;
                var v105 = _propertyOwnerName; v105.Clean = value; _propertyOwnerName = v105;
                var v106 = _propertyOwnerPostalCode; v106.Clean = value; _propertyOwnerPostalCode = v106;
                var v107 = _propertyOwnerState; v107.Clean = value; _propertyOwnerState = v107;
                var v108 = _propertyToBeImproved; v108.Clean = value; _propertyToBeImproved = v108;
                var v109 = _propertyType; v109.Clean = value; _propertyType = v109;
                var v110 = _purchaseDate; v110.Clean = value; _purchaseDate = v110;
                var v111 = _purchasedOnContract; v111.Clean = value; _purchasedOnContract = v111;
                var v112 = _purchaseMaximumMortgageAmount; v112.Clean = value; _purchaseMaximumMortgageAmount = v112;
                var v113 = _purchaseMaximumMortgagePercent; v113.Clean = value; _purchaseMaximumMortgagePercent = v113;
                var v114 = _purchasePriceLessInducementToPurchase; v114.Clean = value; _purchasePriceLessInducementToPurchase = v114;
                var v115 = _refinanceMaximumMortgageAmount; v115.Clean = value; _refinanceMaximumMortgageAmount = v115;
                var v116 = _refinancingATitleILoan; v116.Clean = value; _refinancingATitleILoan = v116;
                var v117 = _rehabilitationEscrowAccount; v117.Clean = value; _rehabilitationEscrowAccount = v117;
                var v118 = _rehabilitationEscrowAmountBalanceForFutureDraws; v118.Clean = value; _rehabilitationEscrowAmountBalanceForFutureDraws = v118;
                var v119 = _rentalCashFlowBalance; v119.Clean = value; _rentalCashFlowBalance = v119;
                var v120 = _residencyType; v120.Clean = value; _residencyType = v120;
                var v121 = _riskClass; v121.Clean = value; _riskClass = v121;
                var v122 = _scoredByTotal; v122.Clean = value; _scoredByTotal = v122;
                var v123 = _secondaryFinancingProviders; v123.Clean = value; _secondaryFinancingProviders = v123;
                var v124 = _sellerContributionRate; v124.Clean = value; _sellerContributionRate = v124;
                var v125 = _simpleRefinance; v125.Clean = value; _simpleRefinance = v125;
                var v126 = _statutoryInvestment; v126.Clean = value; _statutoryInvestment = v126;
                var v127 = _step2EPlusStep1E; v127.Clean = value; _step2EPlusStep1E = v127;
                var v128 = _streamlined; v128.Clean = value; _streamlined = v128;
                var v129 = _subTotalForEscrowAccount; v129.Clean = value; _subTotalForEscrowAccount = v129;
                var v130 = _subTotalForReleaseAtClosing; v130.Clean = value; _subTotalForReleaseAtClosing = v130;
                var v131 = _sumForInvestor; v131.Clean = value; _sumForInvestor = v131;
                var v132 = _sumForOwnerOccupied; v132.Clean = value; _sumForOwnerOccupied = v132;
                var v133 = _sumOfExistingDebt; v133.Clean = value; _sumOfExistingDebt = v133;
                var v134 = _suplementalOriginationFee; v134.Clean = value; _suplementalOriginationFee = v134;
                var v135 = _title1LoanBalance; v135.Clean = value; _title1LoanBalance = v135;
                var v136 = _title1LoanNumber; v136.Clean = value; _title1LoanNumber = v136;
                var v137 = _title1LoanWithWhom; v137.Clean = value; _title1LoanWithWhom = v137;
                var v138 = _titleUpdateFeeAmount; v138.Clean = value; _titleUpdateFeeAmount = v138;
                var v139 = _titleUpdateFees; v139.Clean = value; _titleUpdateFees = v139;
                var v140 = _titleUpdateFeeTimes; v140.Clean = value; _titleUpdateFeeTimes = v140;
                var v141 = _totalCostsOfRepairsInA6; v141.Clean = value; _totalCostsOfRepairsInA6 = v141;
                var v142 = _totalEscrowCommitment; v142.Clean = value; _totalEscrowCommitment = v142;
                var v143 = _totalEscrowedFunds; v143.Clean = value; _totalEscrowedFunds = v143;
                var v144 = _totalFixedUnpaidBalance; v144.Clean = value; _totalFixedUnpaidBalance = v144;
                var v145 = _totalForBorrowerEstimatedProfit; v145.Clean = value; _totalForBorrowerEstimatedProfit = v145;
                var v146 = _totalForInspectionAndTitleFee; v146.Clean = value; _totalForInspectionAndTitleFee = v146;
                var v147 = _totalForLesserOfSumAsIs; v147.Clean = value; _totalForLesserOfSumAsIs = v147;
                var v148 = _totalForMtgPaymentEscrowed; v148.Clean = value; _totalForMtgPaymentEscrowed = v148;
                var v149 = _totalForPlanReviewerFee; v149.Clean = value; _totalForPlanReviewerFee = v149;
                var v150 = _totalForRehabilitationCost; v150.Clean = value; _totalForRehabilitationCost = v150;
                var v151 = _totalRehabilitationCosts; v151.Clean = value; _totalRehabilitationCosts = v151;
                var v152 = _totalRehabilitationCostsFeesReserves; v152.Clean = value; _totalRehabilitationCostsFeesReserves = v152;
                var v153 = _unpaidPrincipalBalanceFirstLien; v153.Clean = value; _unpaidPrincipalBalanceFirstLien = v153;
                var v154 = _unpaidPrincipalBalanceOfAnyJuniorLiens; v154.Clean = value; _unpaidPrincipalBalanceOfAnyJuniorLiens = v154;
                var v155 = _unpaidPrincipalBalanceOfPurchaseJuniorLiens; v155.Clean = value; _unpaidPrincipalBalanceOfPurchaseJuniorLiens = v155;
                var v156 = _valueEstablished; v156.Clean = value; _valueEstablished = v156;
                var v157 = _windEnergySystemActualCost; v157.Clean = value; _windEnergySystemActualCost = v157;
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