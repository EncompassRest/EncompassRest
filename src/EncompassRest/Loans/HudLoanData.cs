using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HudLoanData
    /// </summary>
    public sealed partial class HudLoanData : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualCashInvRequired;
        private DirtyValue<decimal?> _adjustedMaxMtgAmount;
        private DirtyValue<decimal?> _afterImprovedValue;
        private DirtyValue<decimal?> _afterImprovedValueAfter20Percent;
        private DirtyValue<decimal?> _allowableEnergyImprovements;
        private DirtyValue<decimal?> _appropriateLTVFactor;
        private DirtyValue<decimal?> _architecturalEngineeringFee;
        private DirtyValue<decimal?> _asIsValue;
        private DirtyValue<decimal?> _baseMortgageAmountFrom3COr3D;
        private DirtyValue<StringEnumValue<BorrowerAcknowledgement>> _borrowerAcknowledgement;
        private DirtyValue<decimal?> _borrowerEstimatedProfit1;
        private DirtyValue<decimal?> _borrowerEstimatedProfit2;
        private DirtyValue<decimal?> _borrowerPaidClosingCosts;
        private DirtyValue<decimal?> _borrowerRequiredInvestment;
        private DirtyValue<decimal?> _borrowersOwnFundsforContingencyReserves;
        private DirtyValue<bool?> _buildingOnOwnLand;
        private DirtyValue<DateTime?> _caseAssignedDate;
        private DirtyValue<decimal?> _caseLTV;
        private DirtyValue<decimal?> _childSupportBalance;
        private DirtyValue<string> _cHUMSForAppraisal;
        private DirtyValue<decimal?> _commitmentMaximumMortgageAmount;
        private DirtyValue<string> _commitmentStage;
        private DirtyValue<decimal?> _constructionRepairsRehabilitationCosts;
        private DirtyValue<decimal?> _contingencyReserveCostsAmount;
        private DirtyValue<decimal?> _contingencyReserveCostsPercent;
        private DirtyValue<decimal?> _contractSalesPrice;
        private DirtyValue<StringEnumValue<CriteriaForAppropriateLTVFactor>> _criteriaForAppropriateLTVFactor;
        private DirtyValue<string> _dealerContractorAddress;
        private DirtyValue<string> _dealerContractorCity;
        private DirtyValue<string> _dealerContractorName;
        private DirtyValue<string> _dealerContractorPostalCode;
        private DirtyValue<StringEnumValue<State>> _dealerContractorState;
        private DirtyValue<decimal?> _discountPointsAmount;
        private DirtyValue<decimal?> _discountPointsPercent;
        private DirtyValue<bool?> _eEMIndicator;
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        private DirtyValue<string> _escrowCommitment;
        private DirtyValue<decimal?> _escrowShortages;
        private DirtyValue<decimal?> _existing203KDebtTotal;
        private DirtyValue<bool?> _existingDebt;
        private DirtyValue<decimal?> _existingDebtPlusRehabCosts;
        private DirtyValue<decimal?> _existingDebtPlusRehabCostsPlusNewLoanFees;
        private DirtyValue<decimal?> _feasibilityStudyWhenNecessary;
        private DirtyValue<decimal?> _feesAssociatedWithNewLoan;
        private DirtyValue<decimal?> _fHA203kB10SubTotal;
        private DirtyValue<string> _fHA203kRemarks;
        private DirtyValue<StringEnumValue<FHAStreamlineType>> _fHAStreamlineType;
        private DirtyValue<decimal?> _finalBaseMortgageAmount;
        private DirtyValue<decimal?> _financeableMortgageFeesIfCharged;
        private DirtyValue<bool?> _haveOtherPendingApplicationForFHA;
        private DirtyValue<bool?> _hUDOwned;
        private DirtyValue<bool?> _hUDREOIndicator;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _independentConsultantFee;
        private DirtyValue<decimal?> _initialBaseMortgageAmountPlusEEMImprovementAmount;
        private DirtyValue<decimal?> _initialDrawAtClosingArchitecturalorEngineeringFees;
        private DirtyValue<decimal?> _initialDrawAtClosingConsultantFees;
        private DirtyValue<decimal?> _initialDrawAtClosingPermitFees;
        private DirtyValue<decimal?> _initialDrawAtClosingTotal;
        private DirtyValue<decimal?> _inspectionFeeAmount;
        private DirtyValue<decimal?> _inspectionFeesDuringRehabilitation;
        private DirtyValue<int?> _inspectionFeeTimes;
        private DirtyValue<decimal?> _interestDueonExistingMortgage;
        private DirtyValue<decimal?> _lateCharges;
        private DirtyValue<bool?> _lDPGSAForBorrower;
        private DirtyValue<bool?> _lDPGSAForCoBorrower;
        private DirtyValue<bool?> _leasedFromSomeoneElse;
        private DirtyValue<DateTime?> _leaseExpiradionDate;
        private DirtyValue<decimal?> _leaseMonthlyPayment;
        private DirtyValue<decimal?> _lessAllowableDownpayment;
        private DirtyValue<decimal?> _lesserOf3AOr3B;
        private DirtyValue<decimal?> _lesserOf3AOr3BMultiply3F;
        private DirtyValue<decimal?> _lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
        private DirtyValue<decimal?> _lesserOfSalesPrice;
        private DirtyValue<decimal?> _lesserOfSumAmount;
        private DirtyValue<decimal?> _lesserOfSumAsIs;
        private DirtyValue<decimal?> _lesserOfSumPercent;
        private DirtyValue<decimal?> _lessLeadBasedPaintCredit;
        private DirtyValue<bool?> _limitedProgram;
        private DirtyValue<bool?> _loanFor203KIndicator;
        private DirtyValue<string> _loanPurpose;
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractor;
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
        private DirtyValue<decimal?> _maximumMortgageWithUFMIP;
        private DirtyValue<decimal?> _mIPDueOnExistingMortgage;
        private DirtyValue<decimal?> _mIPLTV;
        private DirtyValue<bool?> _mtgOrDeedOfTrusOnProperty;
        private DirtyValue<decimal?> _mtgPaymentEscrowedAmount;
        private DirtyValue<int?> _mtgPaymentEscrowedTimes;
        private DirtyValue<decimal?> _nationwideMortgageLimit;
        private DirtyValue<decimal?> _nationwideMortgageLimitAfter120Percent;
        private DirtyValue<bool?> _newResidential;
        private DirtyValue<string> _nonresidentialTypeOfUse;
        private DirtyValue<int?> _numberOfHistoricUnits;
        private DirtyValue<int?> _numberOfMultifamilyUnits;
        private DirtyValue<string> _otherDescription;
        private DirtyValue<bool?> _ownedByBorrower;
        private DirtyValue<decimal?> _percentAfterImprovedValue;
        private DirtyValue<decimal?> _permitsAndOtherFee;
        private DirtyValue<decimal?> _planReviewerFeeAddition;
        private DirtyValue<decimal?> _planReviewerFeeAmount;
        private DirtyValue<int?> _planReviewerFeeMiles;
        private DirtyValue<decimal?> _prepaymentPenalties;
        private DirtyValue<string> _propertyOwnerAddress;
        private DirtyValue<string> _propertyOwnerCity;
        private DirtyValue<string> _propertyOwnerName;
        private DirtyValue<string> _propertyOwnerPostalCode;
        private DirtyValue<StringEnumValue<State>> _propertyOwnerState;
        private DirtyValue<StringEnumValue<PropertyToBeImproved>> _propertyToBeImproved;
        private DirtyValue<StringEnumValue<HudLoanDataPropertyType>> _propertyType;
        private DirtyValue<DateTime?> _purchaseDate;
        private DirtyValue<bool?> _purchasedOnContract;
        private DirtyValue<decimal?> _purchaseMaximumMortgageAmount;
        private DirtyValue<decimal?> _purchaseMaximumMortgagePercent;
        private DirtyValue<decimal?> _purchasePriceLessInducementToPurchase;
        private DirtyValue<decimal?> _refinanceMaximumMortgageAmount;
        private DirtyValue<bool?> _refinancingATitleILoan;
        private DirtyValue<decimal?> _rehabilitationEscrowAccount;
        private DirtyValue<decimal?> _rehabilitationEscrowAmountBalanceForFutureDraws;
        private DirtyValue<decimal?> _rentalCashFlowBalance;
        private DirtyValue<StringEnumValue<HudLoanDataResidencyType>> _residencyType;
        private DirtyValue<StringEnumValue<HudLoanDataRiskClass>> _riskClass;
        private DirtyValue<bool?> _scoredByTotal;
        private DirtyList<SecondaryFinancingProvider> _secondaryFinancingProviders;
        private DirtyValue<decimal?> _sellerContributionRate;
        private DirtyValue<bool?> _simpleRefinance;
        private DirtyValue<decimal?> _statutoryInvestment;
        private DirtyValue<decimal?> _step2EPlusStep1E;
        private DirtyValue<bool?> _streamlined;
        private DirtyValue<decimal?> _subTotalForEscrowAccount;
        private DirtyValue<decimal?> _subTotalForReleaseAtClosing;
        private DirtyValue<decimal?> _sumForInvestor;
        private DirtyValue<decimal?> _sumForOwnerOccupied;
        private DirtyValue<decimal?> _sumOfExistingDebt;
        private DirtyValue<decimal?> _suplementalOriginationFee;
        private DirtyValue<decimal?> _title1LoanBalance;
        private DirtyValue<string> _title1LoanNumber;
        private DirtyValue<string> _title1LoanWithWhom;
        private DirtyValue<decimal?> _titleUpdateFeeAmount;
        private DirtyValue<decimal?> _titleUpdateFees;
        private DirtyValue<int?> _titleUpdateFeeTimes;
        private DirtyValue<decimal?> _totalCostsOfRepairsInA6;
        private DirtyValue<decimal?> _totalEscrowCommitment;
        private DirtyValue<decimal?> _totalEscrowedFunds;
        private DirtyValue<decimal?> _totalFixedUnpaidBalance;
        private DirtyValue<decimal?> _totalForBorrowerEstimatedProfit;
        private DirtyValue<decimal?> _totalForInspectionAndTitleFee;
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        private DirtyValue<decimal?> _totalForMtgPaymentEscrowed;
        private DirtyValue<decimal?> _totalForPlanReviewerFee;
        private DirtyValue<decimal?> _totalForRehabilitationCost;
        private DirtyValue<decimal?> _totalRehabilitationCosts;
        private DirtyValue<decimal?> _totalRehabilitationCostsFeesReserves;
        private DirtyValue<decimal?> _unpaidPrincipalBalanceFirstLien;
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfAnyJuniorLiens;
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfPurchaseJuniorLiens;
        private DirtyValue<decimal?> _valueEstablished;
        private DirtyValue<string> _waterPurificationAgent;
        private DirtyValue<string> _waterPurificationOrganization;
        private DirtyValue<string> _waterPurificationPayees;
        private DirtyValue<decimal?> _windEnergySystemActualCost;

        /// <summary>
        /// FHA 203k C6 Actual Cash Invest Required [MAX23K.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ActualCashInvRequired { get => _actualCashInvRequired; set => SetField(ref _actualCashInvRequired, value); }

        /// <summary>
        /// FHA 203k C7 Adj Max Mtg Amt [MAX23K.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdjustedMaxMtgAmount { get => _adjustedMaxMtgAmount; set => SetField(ref _adjustedMaxMtgAmount, value); }

        /// <summary>
        /// FHA 203k A3 After Improved Value [MAX23K.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AfterImprovedValue { get => _afterImprovedValue; set => SetField(ref _afterImprovedValue, value); }

        /// <summary>
        /// FHA 203k - Step 2F × 20% (After-Improved Value × 20%) [MAX23K.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AfterImprovedValueAfter20Percent { get => _afterImprovedValueAfter20Percent; set => SetField(ref _afterImprovedValueAfter20Percent, value); }

        /// <summary>
        /// FHA 203k A6 Allowable Energy Improvements [MAX23K.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AllowableEnergyImprovements { get => _allowableEnergyImprovements; set => SetField(ref _allowableEnergyImprovements, value); }

        /// <summary>
        /// FHA 203k - Appropriate LTV Factor [MAX23K.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AppropriateLTVFactor { get => _appropriateLTVFactor; set => SetField(ref _appropriateLTVFactor, value); }

        /// <summary>
        /// FHA 203k B6 Architect/Engineering Fees [MAX23K.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ArchitecturalEngineeringFee { get => _architecturalEngineeringFee; set => SetField(ref _architecturalEngineeringFee, value); }

        /// <summary>
        /// FHA 203k A2 As Is Value [MAX23K.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AsIsValue { get => _asIsValue; set => SetField(ref _asIsValue, value); }

        /// <summary>
        /// FHA 203k - Base Mortgage Amount (Lesser of 3C or 3D) [MAX23K.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BaseMortgageAmountFrom3COr3D { get => _baseMortgageAmountFrom3COr3D; set => SetField(ref _baseMortgageAmountFrom3COr3D, value); }

        /// <summary>
        /// FHA 203k Borr Acknowledgement [MAX23K.X73]
        /// </summary>
        public StringEnumValue<BorrowerAcknowledgement> BorrowerAcknowledgement { get => _borrowerAcknowledgement; set => SetField(ref _borrowerAcknowledgement, value); }

        /// <summary>
        /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerEstimatedProfit1 { get => _borrowerEstimatedProfit1; set => SetField(ref _borrowerEstimatedProfit1, value); }

        /// <summary>
        /// FHA 203k Borrower Estimated Profit [MAX23K.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerEstimatedProfit2 { get => _borrowerEstimatedProfit2; set => SetField(ref _borrowerEstimatedProfit2, value); }

        /// <summary>
        /// FHA 203k D3 Borrower Paid Closing Costs [MAX23K.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerPaidClosingCosts { get => _borrowerPaidClosingCosts; set => SetField(ref _borrowerPaidClosingCosts, value); }

        /// <summary>
        /// FHA 203k D6 Borr Required Investment [MAX23K.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerRequiredInvestment { get => _borrowerRequiredInvestment; set => SetField(ref _borrowerRequiredInvestment, value); }

        /// <summary>
        /// FHA 203k - Borrowers Own Funds for Contingency Reserves (if not financed in 6:A1) [MAX23K.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorrowersOwnFundsforContingencyReserves { get => _borrowersOwnFundsforContingencyReserves; set => SetField(ref _borrowersOwnFundsforContingencyReserves, value); }

        /// <summary>
        /// HUD 92900 LT Building On Own Land [2998]
        /// </summary>
        public bool? BuildingOnOwnLand { get => _buildingOnOwnLand; set => SetField(ref _buildingOnOwnLand, value); }

        /// <summary>
        /// Lock Request Date Case Number Assigned [3042]
        /// </summary>
        public DateTime? CaseAssignedDate { get => _caseAssignedDate; set => SetField(ref _caseAssignedDate, value); }

        /// <summary>
        /// Initial Draw at Closing Total 203K Case LTV [MAX23K.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CaseLTV { get => _caseLTV; set => SetField(ref _caseLTV, value); }

        /// <summary>
        /// HUD 92900 LT Child Support Unpaid Balance [3023]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ChildSupportBalance { get => _childSupportBalance; set => SetField(ref _childSupportBalance, value); }

        /// <summary>
        /// HUD 92900 LT CHUMS ID# For Reviewer of Appraisal [3030]
        /// </summary>
        public string CHUMSForAppraisal { get => _cHUMSForAppraisal; set => SetField(ref _cHUMSForAppraisal, value); }

        /// <summary>
        /// FHA 203k E1 Max Mortgage Amount [MAX23K.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? CommitmentMaximumMortgageAmount { get => _commitmentMaximumMortgageAmount; set => SetField(ref _commitmentMaximumMortgageAmount, value); }

        /// <summary>
        /// FHA 203k Commitment Stage [MAX23K.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CommitmentStage { get => _commitmentStage; set => SetField(ref _commitmentStage, value); }

        /// <summary>
        /// FHA 203k - Costs of construction, repairs and rehabilitation [MAX23K.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConstructionRepairsRehabilitationCosts { get => _constructionRepairsRehabilitationCosts; set => SetField(ref _constructionRepairsRehabilitationCosts, value); }

        /// <summary>
        /// FHA 203k B2 Contingency Reserve on Repair Costs [MAX23K.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ContingencyReserveCostsAmount { get => _contingencyReserveCostsAmount; set => SetField(ref _contingencyReserveCostsAmount, value); }

        /// <summary>
        /// FHA 203k B2 Contingency Reserve % (10-20% of B1) [MAX23K.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ContingencyReserveCostsPercent { get => _contingencyReserveCostsPercent; set => SetField(ref _contingencyReserveCostsPercent, value); }

        /// <summary>
        /// FHA 203k A1 Contract Sales Price [MAX23K.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ContractSalesPrice { get => _contractSalesPrice; set => SetField(ref _contractSalesPrice, value); }

        /// <summary>
        /// FHA 203k - Criteria for Appropriate LTV Factor [MAX23K.X118]
        /// </summary>
        public StringEnumValue<CriteriaForAppropriateLTVFactor> CriteriaForAppropriateLTVFactor { get => _criteriaForAppropriateLTVFactor; set => SetField(ref _criteriaForAppropriateLTVFactor, value); }

        /// <summary>
        /// HUD Property Improve Dealer/Contractor Addr [CAPIAP.X144]
        /// </summary>
        public string DealerContractorAddress { get => _dealerContractorAddress; set => SetField(ref _dealerContractorAddress, value); }

        /// <summary>
        /// HUD Property Improve Dealer/Contractor City [CAPIAP.X145]
        /// </summary>
        public string DealerContractorCity { get => _dealerContractorCity; set => SetField(ref _dealerContractorCity, value); }

        /// <summary>
        /// HUD Leased Info Dealer/Contractor Name [982]
        /// </summary>
        public string DealerContractorName { get => _dealerContractorName; set => SetField(ref _dealerContractorName, value); }

        /// <summary>
        /// HUD Property Improve Dealer/Contractor Zip [CAPIAP.X147]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string DealerContractorPostalCode { get => _dealerContractorPostalCode; set => SetField(ref _dealerContractorPostalCode, value); }

        /// <summary>
        /// HUD Property Improve Dealer/Contractor State [CAPIAP.X146]
        /// </summary>
        public StringEnumValue<State> DealerContractorState { get => _dealerContractorState; set => SetField(ref _dealerContractorState, value); }

        /// <summary>
        /// FHA 203k B12 Discount Points Amt [MAX23K.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DiscountPointsAmount { get => _discountPointsAmount; set => SetField(ref _discountPointsAmount, value); }

        /// <summary>
        /// FHA 203k B12 Discount Points % of B10 [MAX23K.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DiscountPointsPercent { get => _discountPointsPercent; set => SetField(ref _discountPointsPercent, value); }

        /// <summary>
        /// HUD 92900 LT Energy Efficient Mortgage [2997]
        /// </summary>
        public bool? EEMIndicator { get => _eEMIndicator; set => SetField(ref _eEMIndicator, value); }

        /// <summary>
        /// FHA 203k F1 Energy Efficient  Mtg Amt [MAX23K.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => SetField(ref _energyEfficientMortgageAmount, value); }

        /// <summary>
        /// FHA 203k Escrow Commitment [MAX23K.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string EscrowCommitment { get => _escrowCommitment; set => SetField(ref _escrowCommitment, value); }

        /// <summary>
        /// FHA 203k - Escrow shortages [MAX23K.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EscrowShortages { get => _escrowShortages; set => SetField(ref _escrowShortages, value); }

        /// <summary>
        /// FHA 203k - Existing Debt Total [MAX23K.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Existing203KDebtTotal { get => _existing203KDebtTotal; set => SetField(ref _existing203KDebtTotal, value); }

        /// <summary>
        /// FHA 203k A1 Existing Debt [MAX23K.X75]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Existing Debt\"}")]
        public bool? ExistingDebt { get => _existingDebt; set => SetField(ref _existingDebt, value); }

        /// <summary>
        /// FHA 203k - Existing Debt plus Rehab Costs [MAX23K.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingDebtPlusRehabCosts { get => _existingDebtPlusRehabCosts; set => SetField(ref _existingDebtPlusRehabCosts, value); }

        /// <summary>
        /// FHA 203k - Existing Debt Plus Rehab Costs Plus New Loan Fees [MAX23K.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get => _existingDebtPlusRehabCostsPlusNewLoanFees; set => SetField(ref _existingDebtPlusRehabCostsPlusNewLoanFees, value); }

        /// <summary>
        /// FHA 203k - Feasibility Study when necessary [MAX23K.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeasibilityStudyWhenNecessary { get => _feasibilityStudyWhenNecessary; set => SetField(ref _feasibilityStudyWhenNecessary, value); }

        /// <summary>
        /// FHA 203k - Fees Associated with the New Loan [MAX23K.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeesAssociatedWithNewLoan { get => _feesAssociatedWithNewLoan; set => SetField(ref _feesAssociatedWithNewLoan, value); }

        /// <summary>
        /// FHA 203k B10 Subtotal (B5-B9) [MAX23K.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FHA203kB10SubTotal { get => _fHA203kB10SubTotal; set => SetField(ref _fHA203kB10SubTotal, value); }

        /// <summary>
        /// FHA 203k Remarks [MAX23K.X53]
        /// </summary>
        public string FHA203kRemarks { get => _fHA203kRemarks; set => SetField(ref _fHA203kRemarks, value); }

        /// <summary>
        /// HUD 92900 LT FHA Streamline Type [3659]
        /// </summary>
        public StringEnumValue<FHAStreamlineType> FHAStreamlineType { get => _fHAStreamlineType; set => SetField(ref _fHAStreamlineType, value); }

        /// <summary>
        /// FHA 203k - Final Base Mortgage Amount = Lesser of (Sum of Step 4B + Step 4E) or Step 4F [MAX23K.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinalBaseMortgageAmount { get => _finalBaseMortgageAmount; set => SetField(ref _finalBaseMortgageAmount, value); }

        /// <summary>
        /// FHA 203k - Financeable Mortgage Fees, if charged (Sum of C1 and C2) [MAX23K.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinanceableMortgageFeesIfCharged { get => _financeableMortgageFeesIfCharged; set => SetField(ref _financeableMortgageFeesIfCharged, value); }

        /// <summary>
        /// HUD Property Improve Other Pending Appl [CAPIAP.X1]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Have other pending application for FHA Title I Loan\"}")]
        public bool? HaveOtherPendingApplicationForFHA { get => _haveOtherPendingApplicationForFHA; set => SetField(ref _haveOtherPendingApplicationForFHA, value); }

        /// <summary>
        /// FHA 203k Property HUD-Owned [MAX23K.X1]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"HUD-Owned\"}")]
        public bool? HUDOwned { get => _hUDOwned; set => SetField(ref _hUDOwned, value); }

        /// <summary>
        /// HUD 92900 LT HUD REO [2999]
        /// </summary>
        public bool? HUDREOIndicator { get => _hUDREOIndicator; set => SetField(ref _hUDREOIndicator, value); }

        /// <summary>
        /// HudLoanData Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// FHA 203k B7 Independent Consultant Fees [MAX23K.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? IndependentConsultantFee { get => _independentConsultantFee; set => SetField(ref _independentConsultantFee, value); }

        /// <summary>
        /// FHA 203k - Initial Base Mortgage Amount + EEM Improvement Amount [MAX23K.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get => _initialBaseMortgageAmountPlusEEMImprovementAmount; set => SetField(ref _initialBaseMortgageAmountPlusEEMImprovementAmount, value); }

        /// <summary>
        /// Initial Draw at Closing Total 203K Architectural or Engineering Fees [MAX23K.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get => _initialDrawAtClosingArchitecturalorEngineeringFees; set => SetField(ref _initialDrawAtClosingArchitecturalorEngineeringFees, value); }

        /// <summary>
        /// Initial Draw at Closing Total 203K Consultant Fees [MAX23K.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialDrawAtClosingConsultantFees { get => _initialDrawAtClosingConsultantFees; set => SetField(ref _initialDrawAtClosingConsultantFees, value); }

        /// <summary>
        /// Initial Draw at Closing Total 203K Permit Fees [MAX23K.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialDrawAtClosingPermitFees { get => _initialDrawAtClosingPermitFees; set => SetField(ref _initialDrawAtClosingPermitFees, value); }

        /// <summary>
        /// FHA 203k - Initial Draw at Closing Total (sum of B1 thru B7) [MAX23K.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialDrawAtClosingTotal { get => _initialDrawAtClosingTotal; set => SetField(ref _initialDrawAtClosingTotal, value); }

        /// <summary>
        /// FHA 203k B3 Cost Per Inspection [MAX23K.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeeAmount { get => _inspectionFeeAmount; set => SetField(ref _inspectionFeeAmount, value); }

        /// <summary>
        /// FHA 203k - Inspection Fees (work Performed during Rehabilitation) [MAX23K.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InspectionFeesDuringRehabilitation { get => _inspectionFeesDuringRehabilitation; set => SetField(ref _inspectionFeesDuringRehabilitation, value); }

        /// <summary>
        /// FHA 203k B3 # Inspections [MAX23K.X11]
        /// </summary>
        public int? InspectionFeeTimes { get => _inspectionFeeTimes; set => SetField(ref _inspectionFeeTimes, value); }

        /// <summary>
        /// FHA 203k - Interest due on the existing mortgage(s) [MAX23K.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InterestDueonExistingMortgage { get => _interestDueonExistingMortgage; set => SetField(ref _interestDueonExistingMortgage, value); }

        /// <summary>
        /// FHA 203k - Late Charges [MAX23K.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LateCharges { get => _lateCharges; set => SetField(ref _lateCharges, value); }

        /// <summary>
        /// HUD 92900 LT LDP / GSA For Borrower [3026]
        /// </summary>
        public bool? LDPGSAForBorrower { get => _lDPGSAForBorrower; set => SetField(ref _lDPGSAForBorrower, value); }

        /// <summary>
        /// HUD 92900 LT LDP / GSA For CoBorrower [3027]
        /// </summary>
        public bool? LDPGSAForCoBorrower { get => _lDPGSAForCoBorrower; set => SetField(ref _lDPGSAForCoBorrower, value); }

        /// <summary>
        /// HUD Property Improve Leased from Other [CAPIAP.X46]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Leased from someone else\"}")]
        public bool? LeasedFromSomeoneElse { get => _leasedFromSomeoneElse; set => SetField(ref _leasedFromSomeoneElse, value); }

        /// <summary>
        /// HUD Property Improve Lease Exp Date [CAPIAP.X55]
        /// </summary>
        public DateTime? LeaseExpiradionDate { get => _leaseExpiradionDate; set => SetField(ref _leaseExpiradionDate, value); }

        /// <summary>
        /// HUD Property Improve Lease Mo Pymt [CAPIAP.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LeaseMonthlyPayment { get => _leaseMonthlyPayment; set => SetField(ref _leaseMonthlyPayment, value); }

        /// <summary>
        /// FHA 203k C5 Allowable Down/HUD-Owned Property [MAX23K.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LessAllowableDownpayment { get => _lessAllowableDownpayment; set => SetField(ref _lessAllowableDownpayment, value); }

        /// <summary>
        /// FHA 203k - Lesser of 3A or 3B [MAX23K.X86]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LesserOf3AOr3B { get => _lesserOf3AOr3B; set => SetField(ref _lesserOf3AOr3B, value); }

        /// <summary>
        /// FHA 203k - Lesser of 3A or 3B * 3F [MAX23K.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LesserOf3AOr3BMultiply3F { get => _lesserOf3AOr3BMultiply3F; set => SetField(ref _lesserOf3AOr3BMultiply3F, value); }

        /// <summary>
        /// FHA 203k - Lesser of (Step 4C or Step 4D) = Maximum Financeable Solar/Wind Energy Amount [MAX23K.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get => _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; set => SetField(ref _lesserOfMaximumFinanceableSolarOrWindEnergyAmount, value); }

        /// <summary>
        /// FHA 203k C1 Lesser of Sales Price/As Is Value [MAX23K.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LesserOfSalesPrice { get => _lesserOfSalesPrice; set => SetField(ref _lesserOfSalesPrice, value); }

        /// <summary>
        /// FHA 203k C3 Lesser (C1+C2)/110% After Imprvd Val [MAX23K.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LesserOfSumAmount { get => _lesserOfSumAmount; set => SetField(ref _lesserOfSumAmount, value); }

        /// <summary>
        /// FHA 203k D2 Sum(A2+B14) [MAX23K.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LesserOfSumAsIs { get => _lesserOfSumAsIs; set => SetField(ref _lesserOfSumAsIs, value); }

        /// <summary>
        /// FHA 203k C3 Sum (C1+C2) [MAX23K.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LesserOfSumPercent { get => _lesserOfSumPercent; set => SetField(ref _lesserOfSumPercent, value); }

        /// <summary>
        /// Less Lead-Based Paint Credit [MAX23K.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LessLeadBasedPaintCredit { get => _lessLeadBasedPaintCredit; set => SetField(ref _lessLeadBasedPaintCredit, value); }

        /// <summary>
        /// FHA 203k - Limited Program [MAX23K.X117]
        /// </summary>
        public bool? LimitedProgram { get => _limitedProgram; set => SetField(ref _limitedProgram, value); }

        /// <summary>
        /// HUD 92900 LT Loan for 203K [3000]
        /// </summary>
        public bool? LoanFor203KIndicator { get => _loanFor203KIndicator; set => SetField(ref _loanFor203KIndicator, value); }

        /// <summary>
        /// HUD 92900 LT CHUMS ID# For Loan Purpose [3031]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanPurpose { get => _loanPurpose; set => SetField(ref _loanPurpose, value); }

        /// <summary>
        /// FHA 203k - Material costs for items ordered and prepaid by Borrower/or contractor (under contract for delivery) [MAX23K.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get => _materialCostsOrderedPrepaidByBorrowerContractor; set => SetField(ref _materialCostsOrderedPrepaidByBorrowerContractor, value); }

        /// <summary>
        /// FHA 203k - Up to 50% of materials costs for items ordered but not yet paid for by the Borrower/or contractor [MAX23K.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get => _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; set => SetField(ref _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent, value); }

        /// <summary>
        /// FHA 203k Max Mortgage with UFMIP [MAX23K.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumMortgageWithUFMIP { get => _maximumMortgageWithUFMIP; set => SetField(ref _maximumMortgageWithUFMIP, value); }

        /// <summary>
        /// FHA 203k - Mortgage Insurance Premium (MIP) due on existing mortgage(s) [MAX23K.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MIPDueOnExistingMortgage { get => _mIPDueOnExistingMortgage; set => SetField(ref _mIPDueOnExistingMortgage, value); }

        /// <summary>
        /// FHA 203k - MIP LTV = 3E divided by 2F (ie Base Mortgage Amount divided by After Improved Value) [MAX23K.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MIPLTV { get => _mIPLTV; set => SetField(ref _mIPLTV, value); }

        /// <summary>
        /// HUD Property Improve Mtg/Deed of Trust [CAPIAP.X48]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Mtg or deed of trust on property\"}")]
        public bool? MtgOrDeedOfTrusOnProperty { get => _mtgOrDeedOfTrusOnProperty; set => SetField(ref _mtgOrDeedOfTrusOnProperty, value); }

        /// <summary>
        /// FHA 203k B4 Cost Per Mo [MAX23K.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MtgPaymentEscrowedAmount { get => _mtgPaymentEscrowedAmount; set => SetField(ref _mtgPaymentEscrowedAmount, value); }

        /// <summary>
        /// FHA 203k B4 # Mos Mtg Pymts [MAX23K.X16]
        /// </summary>
        public int? MtgPaymentEscrowedTimes { get => _mtgPaymentEscrowedTimes; set => SetField(ref _mtgPaymentEscrowedTimes, value); }

        /// <summary>
        /// FHA 203k - Nationwide Mortgage Limit [MAX23K.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NationwideMortgageLimit { get => _nationwideMortgageLimit; set => SetField(ref _nationwideMortgageLimit, value); }

        /// <summary>
        /// FHA 203k - Step 3D × 120% (Nationwide Mortgage Limit × 120%) [MAX23K.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NationwideMortgageLimitAfter120Percent { get => _nationwideMortgageLimitAfter120Percent; set => SetField(ref _nationwideMortgageLimitAfter120Percent, value); }

        /// <summary>
        /// HUD Property Improve New Res/Occ > 90 Days [CAPIAP.X56]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"This property is a new residential, and it has been occupied for longer than 90 days\"}")]
        public bool? NewResidential { get => _newResidential; set => SetField(ref _newResidential, value); }

        /// <summary>
        /// HUD Property Improve Nonresidential Type of Use [CAPIAP.X43]
        /// </summary>
        public string NonresidentialTypeOfUse { get => _nonresidentialTypeOfUse; set => SetField(ref _nonresidentialTypeOfUse, value); }

        /// <summary>
        /// HUD Property Improve Hist Residential # Units [CAPIAP.X44]
        /// </summary>
        public int? NumberOfHistoricUnits { get => _numberOfHistoricUnits; set => SetField(ref _numberOfHistoricUnits, value); }

        /// <summary>
        /// HUD Property Improve Multifamily # Units [CAPIAP.X61]
        /// </summary>
        public int? NumberOfMultifamilyUnits { get => _numberOfMultifamilyUnits; set => SetField(ref _numberOfMultifamilyUnits, value); }

        /// <summary>
        /// FHA 203k Other Descr [MAX23K.X74]
        /// </summary>
        public string OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

        /// <summary>
        /// HUD Property Improve Owned by Borr [CAPIAP.X45]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Owned by Borrower\"}")]
        public bool? OwnedByBorrower { get => _ownedByBorrower; set => SetField(ref _ownedByBorrower, value); }

        /// <summary>
        /// FHA 203k A4 110% After Improved Value [MAX23K.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PercentAfterImprovedValue { get => _percentAfterImprovedValue; set => SetField(ref _percentAfterImprovedValue, value); }

        /// <summary>
        /// FHA 203k B8 Permits/Other Fees [MAX23K.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PermitsAndOtherFee { get => _permitsAndOtherFee; set => SetField(ref _permitsAndOtherFee, value); }

        /// <summary>
        /// FHA Consultant Fees [MAX23K.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PlanReviewerFeeAddition { get => _planReviewerFeeAddition; set => SetField(ref _planReviewerFeeAddition, value); }

        /// <summary>
        /// FHA 203k B9 Plan Reviewer Amt Per Mile [MAX23K.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PlanReviewerFeeAmount { get => _planReviewerFeeAmount; set => SetField(ref _planReviewerFeeAmount, value); }

        /// <summary>
        /// FHA 203k B9 Plan Reviewer # Miles [MAX23K.X22]
        /// </summary>
        public int? PlanReviewerFeeMiles { get => _planReviewerFeeMiles; set => SetField(ref _planReviewerFeeMiles, value); }

        /// <summary>
        /// FHA 203k - Prepayment penalties assessed [MAX23K.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PrepaymentPenalties { get => _prepaymentPenalties; set => SetField(ref _prepaymentPenalties, value); }

        /// <summary>
        /// HUD Property Improve Owner Addr [CAPIAP.X50]
        /// </summary>
        public string PropertyOwnerAddress { get => _propertyOwnerAddress; set => SetField(ref _propertyOwnerAddress, value); }

        /// <summary>
        /// HUD Property Improve Owner City [CAPIAP.X51]
        /// </summary>
        public string PropertyOwnerCity { get => _propertyOwnerCity; set => SetField(ref _propertyOwnerCity, value); }

        /// <summary>
        /// HUD Property Improve Owner Name [CAPIAP.X49]
        /// </summary>
        public string PropertyOwnerName { get => _propertyOwnerName; set => SetField(ref _propertyOwnerName, value); }

        /// <summary>
        /// HUD Property Improve Owner Zip [CAPIAP.X53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PropertyOwnerPostalCode { get => _propertyOwnerPostalCode; set => SetField(ref _propertyOwnerPostalCode, value); }

        /// <summary>
        /// HUD Property Improve Owner State [CAPIAP.X52]
        /// </summary>
        public StringEnumValue<State> PropertyOwnerState { get => _propertyOwnerState; set => SetField(ref _propertyOwnerState, value); }

        /// <summary>
        /// HUD Property Improve HUD Property Type [CAPIAP.X60]
        /// </summary>
        public StringEnumValue<PropertyToBeImproved> PropertyToBeImproved { get => _propertyToBeImproved; set => SetField(ref _propertyToBeImproved, value); }

        /// <summary>
        /// HUD 92900 LT Subject Property Type [2996]
        /// </summary>
        public StringEnumValue<HudLoanDataPropertyType> PropertyType { get => _propertyType; set => SetField(ref _propertyType, value); }

        /// <summary>
        /// Subject Property Purchase Date [1518]
        /// </summary>
        public DateTime? PurchaseDate { get => _purchaseDate; set => SetField(ref _purchaseDate, value); }

        /// <summary>
        /// HUD Property Improve Purch on Contract [CAPIAP.X47]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Being Purchased on contract\"}")]
        public bool? PurchasedOnContract { get => _purchasedOnContract; set => SetField(ref _purchasedOnContract, value); }

        /// <summary>
        /// FHA 203k C5 Max Mtg Amt [MAX23K.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PurchaseMaximumMortgageAmount { get => _purchaseMaximumMortgageAmount; set => SetField(ref _purchaseMaximumMortgageAmount, value); }

        /// <summary>
        /// FHA 203k C5 Required Adj Amt [MAX23K.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PurchaseMaximumMortgagePercent { get => _purchaseMaximumMortgagePercent; set => SetField(ref _purchaseMaximumMortgagePercent, value); }

        /// <summary>
        /// FHA 203k - Purchase Price Less Inducement to Purchase [MAX23K.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PurchasePriceLessInducementToPurchase { get => _purchasePriceLessInducementToPurchase; set => SetField(ref _purchasePriceLessInducementToPurchase, value); }

        /// <summary>
        /// FHA 203k D5 Max Mtg Amt [MAX23K.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RefinanceMaximumMortgageAmount { get => _refinanceMaximumMortgageAmount; set => SetField(ref _refinanceMaximumMortgageAmount, value); }

        /// <summary>
        /// HUD Property Improve Refi Title 1 Loan [CAPIAP.X2]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Refinancing a Title I loan\"}")]
        public bool? RefinancingATitleILoan { get => _refinancingATitleILoan; set => SetField(ref _refinancingATitleILoan, value); }

        /// <summary>
        /// FHA 203k - Rehabilitation Escrow Account (Sum of A1 thru A3) [MAX23K.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RehabilitationEscrowAccount { get => _rehabilitationEscrowAccount; set => SetField(ref _rehabilitationEscrowAccount, value); }

        /// <summary>
        /// FHA 203k - Rehabilitation Escrow Amount Balance (for Future Draws) = 6A minus 6B [MAX23K.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get => _rehabilitationEscrowAmountBalanceForFutureDraws; set => SetField(ref _rehabilitationEscrowAmountBalanceForFutureDraws, value); }

        /// <summary>
        /// HUD 92900 LT Rental Cash Flow Balance [3024]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RentalCashFlowBalance { get => _rentalCashFlowBalance; set => SetField(ref _rentalCashFlowBalance, value); }

        /// <summary>
        /// FHA 203k Owner Type [MAX23K.X69]
        /// </summary>
        public StringEnumValue<HudLoanDataResidencyType> ResidencyType { get => _residencyType; set => SetField(ref _residencyType, value); }

        /// <summary>
        /// HUD 92900 LT Risk Class [3029]
        /// </summary>
        public StringEnumValue<HudLoanDataRiskClass> RiskClass { get => _riskClass; set => SetField(ref _riskClass, value); }

        /// <summary>
        /// HUD 92900 LT Scored By TOTAL [3028]
        /// </summary>
        public bool? ScoredByTotal { get => _scoredByTotal; set => SetField(ref _scoredByTotal, value); }

        /// <summary>
        /// HudLoanData SecondaryFinancingProviders
        /// </summary>
        public IList<SecondaryFinancingProvider> SecondaryFinancingProviders { get => GetField(ref _secondaryFinancingProviders); set => SetField(ref _secondaryFinancingProviders, value); }

        /// <summary>
        /// Lock Request Total Seller Contribution Percentage [3048]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SellerContributionRate { get => _sellerContributionRate; set => SetField(ref _sellerContributionRate, value); }

        /// <summary>
        /// HUD 92900 LT Simple Refinance [4056]
        /// </summary>
        public bool? SimpleRefinance { get => _simpleRefinance; set => SetField(ref _simpleRefinance, value); }

        /// <summary>
        /// FHA 203k C4 Statutory Investment Required [MAX23K.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? StatutoryInvestment { get => _statutoryInvestment; set => SetField(ref _statutoryInvestment, value); }

        /// <summary>
        /// FHA 203k - Step 2E + Step 1E (i.e. Adjusted As-Is Value + Step 1 Total) [MAX23K.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Step2EPlusStep1E { get => _step2EPlusStep1E; set => SetField(ref _step2EPlusStep1E, value); }

        /// <summary>
        /// FHA 203k Streamlined [MAX23K.X78]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Streamlined (k)\"}")]
        public bool? Streamlined { get => _streamlined; set => SetField(ref _streamlined, value); }

        /// <summary>
        /// FHA 203k B5 Subtotal Rehab Escrow Acct (B1-B4) [MAX23K.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubTotalForEscrowAccount { get => _subTotalForEscrowAccount; set => SetField(ref _subTotalForEscrowAccount, value); }

        /// <summary>
        /// FHA 203k B13 Subtotal Release at Closing [MAX23K.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubTotalForReleaseAtClosing { get => _subTotalForReleaseAtClosing; set => SetField(ref _subTotalForReleaseAtClosing, value); }

        /// <summary>
        /// FHA 203k D4 Sum(D2+D3) [MAX23K.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SumForInvestor { get => _sumForInvestor; set => SetField(ref _sumForInvestor, value); }

        /// <summary>
        /// FHA 203k D4 Sum(D2+D3)x85% or 97/95/90% [MAX23K.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SumForOwnerOccupied { get => _sumForOwnerOccupied; set => SetField(ref _sumForOwnerOccupied, value); }

        /// <summary>
        /// FHA 203k D1 (A1+B14+A5+Prepaids+Disc-B12) [MAX23K.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SumOfExistingDebt { get => _sumOfExistingDebt; set => SetField(ref _sumOfExistingDebt, value); }

        /// <summary>
        /// FHA 203k B11 Supplemental Origination Fee [MAX23K.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SuplementalOriginationFee { get => _suplementalOriginationFee; set => SetField(ref _suplementalOriginationFee, value); }

        /// <summary>
        /// HUD Property Improve Title 1 Loan Bal [CAPIAP.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Title1LoanBalance { get => _title1LoanBalance; set => SetField(ref _title1LoanBalance, value); }

        /// <summary>
        /// HUD Property Improve Title 1 Loan # [CAPIAP.X3]
        /// </summary>
        public string Title1LoanNumber { get => _title1LoanNumber; set => SetField(ref _title1LoanNumber, value); }

        /// <summary>
        /// HUD Property Improve Title 1 Loan with Whom [CAPIAP.X59]
        /// </summary>
        public string Title1LoanWithWhom { get => _title1LoanWithWhom; set => SetField(ref _title1LoanWithWhom, value); }

        /// <summary>
        /// FHA 203k B3 Cost Per Update [MAX23K.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TitleUpdateFeeAmount { get => _titleUpdateFeeAmount; set => SetField(ref _titleUpdateFeeAmount, value); }

        /// <summary>
        /// FHA 203k - Title Update Fees [MAX23K.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TitleUpdateFees { get => _titleUpdateFees; set => SetField(ref _titleUpdateFees, value); }

        /// <summary>
        /// FHA 203k B3 # Updates [MAX23K.X13]
        /// </summary>
        public int? TitleUpdateFeeTimes { get => _titleUpdateFeeTimes; set => SetField(ref _titleUpdateFeeTimes, value); }

        /// <summary>
        /// FHA 203k B1 Total Cost Repairs Incl A6 [MAX23K.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalCostsOfRepairsInA6 { get => _totalCostsOfRepairsInA6; set => SetField(ref _totalCostsOfRepairsInA6, value); }

        /// <summary>
        /// FHA 203k E3 Total Escrow Commitment [MAX23K.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalEscrowCommitment { get => _totalEscrowCommitment; set => SetField(ref _totalEscrowCommitment, value); }

        /// <summary>
        /// FHA 203k Total Escrowed Funds [MAX23K.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalEscrowedFunds { get => _totalEscrowedFunds; set => SetField(ref _totalEscrowedFunds, value); }

        /// <summary>
        /// HUD 92900 LT Total Fixed Unpaid Balance [3025]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalFixedUnpaidBalance { get => _totalFixedUnpaidBalance; set => SetField(ref _totalFixedUnpaidBalance, value); }

        /// <summary>
        /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalForBorrowerEstimatedProfit { get => _totalForBorrowerEstimatedProfit; set => SetField(ref _totalForBorrowerEstimatedProfit, value); }

        /// <summary>
        /// FHA 203k B3 Title Update Fee [MAX23K.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalForInspectionAndTitleFee { get => _totalForInspectionAndTitleFee; set => SetField(ref _totalForInspectionAndTitleFee, value); }

        /// <summary>
        /// FHA 203k D2 Lesser of Sum(A2+B14)/A4 [MAX23K.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => SetField(ref _totalForLesserOfSumAsIs, value); }

        /// <summary>
        /// FHA 203k B4 Mtg Pymt Escrowed [MAX23K.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalForMtgPaymentEscrowed { get => _totalForMtgPaymentEscrowed; set => SetField(ref _totalForMtgPaymentEscrowed, value); }

        /// <summary>
        /// FHA 203k B9 Plan Reviewer Fees [MAX23K.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalForPlanReviewerFee { get => _totalForPlanReviewerFee; set => SetField(ref _totalForPlanReviewerFee, value); }

        /// <summary>
        /// FHA 203k B14 Total Rehabilitation Cost [MAX23K.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalForRehabilitationCost { get => _totalForRehabilitationCost; set => SetField(ref _totalForRehabilitationCost, value); }

        /// <summary>
        /// FHA 203k C2 Total Rehabilitation Cost [MAX23K.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalRehabilitationCosts { get => _totalRehabilitationCosts; set => SetField(ref _totalRehabilitationCosts, value); }

        /// <summary>
        /// FHA 203k - Total Rehabilitation Costs, Fees and Reserves (Sum of 1A, 1B, 1C) Not to exceed $35,000 [MAX23K.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalRehabilitationCostsFeesReserves { get => _totalRehabilitationCostsFeesReserves; set => SetField(ref _totalRehabilitationCostsFeesReserves, value); }

        /// <summary>
        /// FHA 203k - Unpaid Principal Balance (First Lien) [MAX23K.X124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnpaidPrincipalBalanceFirstLien { get => _unpaidPrincipalBalanceFirstLien; set => SetField(ref _unpaidPrincipalBalanceFirstLien, value); }

        /// <summary>
        /// FHA 203k - Unpaid Principal Balance of any junior liens [MAX23K.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get => _unpaidPrincipalBalanceOfAnyJuniorLiens; set => SetField(ref _unpaidPrincipalBalanceOfAnyJuniorLiens, value); }

        /// <summary>
        /// FHA 203k - 2.Unpaid Principal Balance Purchase Junior Lien [MAX23K.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get => _unpaidPrincipalBalanceOfPurchaseJuniorLiens; set => SetField(ref _unpaidPrincipalBalanceOfPurchaseJuniorLiens, value); }

        /// <summary>
        /// FHA 203k E2 Value Established C5 or D5 [MAX23K.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ValueEstablished { get => _valueEstablished; set => SetField(ref _valueEstablished, value); }

        /// <summary>
        /// FHA Basic Info - Water Purification Local Health Agent [4250]
        /// </summary>
        public string WaterPurificationAgent { get => _waterPurificationAgent; set => SetField(ref _waterPurificationAgent, value); }

        /// <summary>
        /// FHA Basic Info - Water Purification Maintenance Organization [4249]
        /// </summary>
        public string WaterPurificationOrganization { get => _waterPurificationOrganization; set => SetField(ref _waterPurificationOrganization, value); }

        /// <summary>
        /// FHA Basic Info - Water Purification Other Payees [4251]
        /// </summary>
        public string WaterPurificationPayees { get => _waterPurificationPayees; set => SetField(ref _waterPurificationPayees, value); }

        /// <summary>
        /// FHA 203k - Solar/Wind Energy System Actual Cost [MAX23K.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? WindEnergySystemActualCost { get => _windEnergySystemActualCost; set => SetField(ref _windEnergySystemActualCost, value); }
    }
}