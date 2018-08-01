using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HudLoanData
    /// </summary>
    public sealed partial class HudLoanData : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualCashInvRequired;
        /// <summary>
        /// FHA 203k C6 Actual Cash Invest Required [MAX23K.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k C6 Actual Cash Invest Required")]
        public decimal? ActualCashInvRequired { get => _actualCashInvRequired; set => _actualCashInvRequired = value; }
        private DirtyValue<decimal?> _adjustedMaxMtgAmount;
        /// <summary>
        /// FHA 203k C7 Adj Max Mtg Amt [MAX23K.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k C7 Adj Max Mtg Amt")]
        public decimal? AdjustedMaxMtgAmount { get => _adjustedMaxMtgAmount; set => _adjustedMaxMtgAmount = value; }
        private DirtyValue<decimal?> _afterImprovedValue;
        /// <summary>
        /// FHA 203k A3 After Improved Value [MAX23K.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k A3 After Improved Value")]
        public decimal? AfterImprovedValue { get => _afterImprovedValue; set => _afterImprovedValue = value; }
        private DirtyValue<decimal?> _afterImprovedValueAfter20Percent;
        /// <summary>
        /// FHA 203k - Step 2F × 20% (After-Improved Value × 20%) [MAX23K.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Step 2F × 20% (After-Improved Value × 20%)")]
        public decimal? AfterImprovedValueAfter20Percent { get => _afterImprovedValueAfter20Percent; set => _afterImprovedValueAfter20Percent = value; }
        private DirtyValue<decimal?> _allowableEnergyImprovements;
        /// <summary>
        /// FHA 203k A6 Allowable Energy Improvements [MAX23K.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k A6 Allowable Energy Improvements")]
        public decimal? AllowableEnergyImprovements { get => _allowableEnergyImprovements; set => _allowableEnergyImprovements = value; }
        private DirtyValue<decimal?> _appropriateLTVFactor;
        /// <summary>
        /// FHA 203k - Appropriate LTV Factor [MAX23K.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Appropriate LTV Factor")]
        public decimal? AppropriateLTVFactor { get => _appropriateLTVFactor; set => _appropriateLTVFactor = value; }
        private DirtyValue<decimal?> _architecturalEngineeringFee;
        /// <summary>
        /// FHA 203k B6 Architect/Engineering Fees [MAX23K.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B6 Architect/Engineering Fees")]
        public decimal? ArchitecturalEngineeringFee { get => _architecturalEngineeringFee; set => _architecturalEngineeringFee = value; }
        private DirtyValue<decimal?> _asIsValue;
        /// <summary>
        /// FHA 203k A2 As Is Value [MAX23K.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k A2 As Is Value")]
        public decimal? AsIsValue { get => _asIsValue; set => _asIsValue = value; }
        private DirtyValue<decimal?> _baseMortgageAmountFrom3COr3D;
        /// <summary>
        /// FHA 203k - Base Mortgage Amount (Lesser of 3C or 3D) [MAX23K.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Base Mortgage Amount (Lesser of 3C or 3D)")]
        public decimal? BaseMortgageAmountFrom3COr3D { get => _baseMortgageAmountFrom3COr3D; set => _baseMortgageAmountFrom3COr3D = value; }
        private DirtyValue<StringEnumValue<BorrowerAcknowledgement>> _borrowerAcknowledgement;
        /// <summary>
        /// FHA 203k Borr Acknowledgement [MAX23K.X73]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Borr Acknowledgement")]
        public StringEnumValue<BorrowerAcknowledgement> BorrowerAcknowledgement { get => _borrowerAcknowledgement; set => _borrowerAcknowledgement = value; }
        private DirtyValue<decimal?> _borrowerEstimatedProfit1;
        /// <summary>
        /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k E4 Borrower Estimated Profits")]
        public decimal? BorrowerEstimatedProfit1 { get => _borrowerEstimatedProfit1; set => _borrowerEstimatedProfit1 = value; }
        private DirtyValue<decimal?> _borrowerEstimatedProfit2;
        /// <summary>
        /// FHA 203k Borrower Estimated Profit [MAX23K.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k Borrower Estimated Profit")]
        public decimal? BorrowerEstimatedProfit2 { get => _borrowerEstimatedProfit2; set => _borrowerEstimatedProfit2 = value; }
        private DirtyValue<decimal?> _borrowerPaidClosingCosts;
        /// <summary>
        /// FHA 203k D3 Borrower Paid Closing Costs [MAX23K.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D3 Borrower Paid Closing Costs")]
        public decimal? BorrowerPaidClosingCosts { get => _borrowerPaidClosingCosts; set => _borrowerPaidClosingCosts = value; }
        private DirtyValue<decimal?> _borrowerRequiredInvestment;
        /// <summary>
        /// FHA 203k D6 Borr Required Investment [MAX23K.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D6 Borr Required Investment")]
        public decimal? BorrowerRequiredInvestment { get => _borrowerRequiredInvestment; set => _borrowerRequiredInvestment = value; }
        private DirtyValue<decimal?> _borrowersOwnFundsforContingencyReserves;
        /// <summary>
        /// FHA 203k - Borrowers Own Funds for Contingency Reserves (if not financed in 6:A1) [MAX23K.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Borrowers Own Funds for Contingency Reserves (if not financed in 6:A1)")]
        public decimal? BorrowersOwnFundsforContingencyReserves { get => _borrowersOwnFundsforContingencyReserves; set => _borrowersOwnFundsforContingencyReserves = value; }
        private DirtyValue<bool?> _buildingOnOwnLand;
        /// <summary>
        /// HUD 92900 LT Building On Own Land [2998]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Building On Own Land")]
        public bool? BuildingOnOwnLand { get => _buildingOnOwnLand; set => _buildingOnOwnLand = value; }
        private DirtyValue<DateTime?> _caseAssignedDate;
        /// <summary>
        /// Lock Request Date Case Number Assigned [3042]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Date Case Number Assigned")]
        public DateTime? CaseAssignedDate { get => _caseAssignedDate; set => _caseAssignedDate = value; }
        private DirtyValue<decimal?> _caseLTV;
        /// <summary>
        /// Initial Draw at Closing Total 203K Case LTV [MAX23K.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Draw at Closing Total 203K Case LTV")]
        public decimal? CaseLTV { get => _caseLTV; set => _caseLTV = value; }
        private DirtyValue<decimal?> _childSupportBalance;
        /// <summary>
        /// HUD 92900 LT Child Support Unpaid Balance [3023]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 92900 LT Child Support Unpaid Balance")]
        public decimal? ChildSupportBalance { get => _childSupportBalance; set => _childSupportBalance = value; }
        private DirtyValue<string> _cHUMSForAppraisal;
        /// <summary>
        /// HUD 92900 LT CHUMS ID# For Reviewer of Appraisal [3030]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT CHUMS ID# For Reviewer of Appraisal")]
        public string CHUMSForAppraisal { get => _cHUMSForAppraisal; set => _cHUMSForAppraisal = value; }
        private DirtyValue<decimal?> _commitmentMaximumMortgageAmount;
        /// <summary>
        /// FHA 203k E1 Max Mortgage Amount [MAX23K.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k E1 Max Mortgage Amount")]
        public decimal? CommitmentMaximumMortgageAmount { get => _commitmentMaximumMortgageAmount; set => _commitmentMaximumMortgageAmount = value; }
        private DirtyValue<string> _commitmentStage;
        /// <summary>
        /// FHA 203k Commitment Stage [MAX23K.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "FHA 203k Commitment Stage")]
        public string CommitmentStage { get => _commitmentStage; set => _commitmentStage = value; }
        private DirtyValue<decimal?> _constructionRepairsRehabilitationCosts;
        /// <summary>
        /// FHA 203k - Costs of construction, repairs and rehabilitation [MAX23K.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Costs of construction, repairs and rehabilitation")]
        public decimal? ConstructionRepairsRehabilitationCosts { get => _constructionRepairsRehabilitationCosts; set => _constructionRepairsRehabilitationCosts = value; }
        private DirtyValue<decimal?> _contingencyReserveCostsAmount;
        /// <summary>
        /// FHA 203k B2 Contingency Reserve on Repair Costs [MAX23K.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B2 Contingency Reserve on Repair Costs")]
        public decimal? ContingencyReserveCostsAmount { get => _contingencyReserveCostsAmount; set => _contingencyReserveCostsAmount = value; }
        private DirtyValue<decimal?> _contingencyReserveCostsPercent;
        /// <summary>
        /// FHA 203k B2 Contingency Reserve % (10-20% of B1) [MAX23K.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "FHA 203k B2 Contingency Reserve % (10-20% of B1)")]
        public decimal? ContingencyReserveCostsPercent { get => _contingencyReserveCostsPercent; set => _contingencyReserveCostsPercent = value; }
        private DirtyValue<decimal?> _contractSalesPrice;
        /// <summary>
        /// FHA 203k A1 Contract Sales Price [MAX23K.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k A1 Contract Sales Price")]
        public decimal? ContractSalesPrice { get => _contractSalesPrice; set => _contractSalesPrice = value; }
        private DirtyValue<StringEnumValue<CriteriaForAppropriateLTVFactor>> _criteriaForAppropriateLTVFactor;
        /// <summary>
        /// FHA 203k - Criteria for Appropriate LTV Factor [MAX23K.X118]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k - Criteria for Appropriate LTV Factor")]
        public StringEnumValue<CriteriaForAppropriateLTVFactor> CriteriaForAppropriateLTVFactor { get => _criteriaForAppropriateLTVFactor; set => _criteriaForAppropriateLTVFactor = value; }
        private DirtyValue<string> _dealerContractorAddress;
        /// <summary>
        /// HUD Property Improve Dealer/Contractor Addr [CAPIAP.X144]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Dealer/Contractor Addr")]
        public string DealerContractorAddress { get => _dealerContractorAddress; set => _dealerContractorAddress = value; }
        private DirtyValue<string> _dealerContractorCity;
        /// <summary>
        /// HUD Property Improve Dealer/Contractor City [CAPIAP.X145]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Dealer/Contractor City")]
        public string DealerContractorCity { get => _dealerContractorCity; set => _dealerContractorCity = value; }
        private DirtyValue<string> _dealerContractorName;
        /// <summary>
        /// HUD Leased Info Dealer/Contractor Name [982]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Leased Info Dealer/Contractor Name")]
        public string DealerContractorName { get => _dealerContractorName; set => _dealerContractorName = value; }
        private DirtyValue<string> _dealerContractorPostalCode;
        /// <summary>
        /// HUD Property Improve Dealer/Contractor Zip [CAPIAP.X147]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD Property Improve Dealer/Contractor Zip")]
        public string DealerContractorPostalCode { get => _dealerContractorPostalCode; set => _dealerContractorPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _dealerContractorState;
        /// <summary>
        /// HUD Property Improve Dealer/Contractor State [CAPIAP.X146]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Dealer/Contractor State")]
        public StringEnumValue<State> DealerContractorState { get => _dealerContractorState; set => _dealerContractorState = value; }
        private DirtyValue<decimal?> _discountPointsAmount;
        /// <summary>
        /// FHA 203k B12 Discount Points Amt [MAX23K.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B12 Discount Points Amt")]
        public decimal? DiscountPointsAmount { get => _discountPointsAmount; set => _discountPointsAmount = value; }
        private DirtyValue<decimal?> _discountPointsPercent;
        /// <summary>
        /// FHA 203k B12 Discount Points % of B10 [MAX23K.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "FHA 203k B12 Discount Points % of B10")]
        public decimal? DiscountPointsPercent { get => _discountPointsPercent; set => _discountPointsPercent = value; }
        private DirtyValue<bool?> _eEMIndicator;
        /// <summary>
        /// HUD 92900 LT Energy Efficient Mortgage [2997]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Energy Efficient Mortgage")]
        public bool? EEMIndicator { get => _eEMIndicator; set => _eEMIndicator = value; }
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        /// <summary>
        /// FHA 203k F1 Energy Efficient  Mtg Amt [MAX23K.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k F1 Energy Efficient  Mtg Amt")]
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => _energyEfficientMortgageAmount = value; }
        private DirtyValue<string> _escrowCommitment;
        /// <summary>
        /// FHA 203k Escrow Commitment [MAX23K.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "FHA 203k Escrow Commitment")]
        public string EscrowCommitment { get => _escrowCommitment; set => _escrowCommitment = value; }
        private DirtyValue<decimal?> _escrowShortages;
        /// <summary>
        /// FHA 203k - Escrow shortages [MAX23K.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Escrow shortages")]
        public decimal? EscrowShortages { get => _escrowShortages; set => _escrowShortages = value; }
        private DirtyValue<decimal?> _existing203KDebtTotal;
        /// <summary>
        /// FHA 203k - Existing Debt Total [MAX23K.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Existing Debt Total")]
        public decimal? Existing203KDebtTotal { get => _existing203KDebtTotal; set => _existing203KDebtTotal = value; }
        private DirtyValue<bool?> _existingDebt;
        /// <summary>
        /// FHA 203k A1 Existing Debt [MAX23K.X75]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k A1 Existing Debt", OptionsJson = "{\"true\":\"Existing Debt\"}")]
        public bool? ExistingDebt { get => _existingDebt; set => _existingDebt = value; }
        private DirtyValue<decimal?> _existingDebtPlusRehabCosts;
        /// <summary>
        /// FHA 203k - Existing Debt plus Rehab Costs [MAX23K.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Existing Debt plus Rehab Costs")]
        public decimal? ExistingDebtPlusRehabCosts { get => _existingDebtPlusRehabCosts; set => _existingDebtPlusRehabCosts = value; }
        private DirtyValue<decimal?> _existingDebtPlusRehabCostsPlusNewLoanFees;
        /// <summary>
        /// FHA 203k - Existing Debt Plus Rehab Costs Plus New Loan Fees [MAX23K.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Existing Debt Plus Rehab Costs Plus New Loan Fees")]
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get => _existingDebtPlusRehabCostsPlusNewLoanFees; set => _existingDebtPlusRehabCostsPlusNewLoanFees = value; }
        private DirtyValue<decimal?> _feasibilityStudyWhenNecessary;
        /// <summary>
        /// FHA 203k - Feasibility Study when necessary [MAX23K.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Feasibility Study when necessary")]
        public decimal? FeasibilityStudyWhenNecessary { get => _feasibilityStudyWhenNecessary; set => _feasibilityStudyWhenNecessary = value; }
        private DirtyValue<decimal?> _feesAssociatedWithNewLoan;
        /// <summary>
        /// FHA 203k - Fees Associated with the New Loan [MAX23K.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Fees Associated with the New Loan")]
        public decimal? FeesAssociatedWithNewLoan { get => _feesAssociatedWithNewLoan; set => _feesAssociatedWithNewLoan = value; }
        private DirtyValue<decimal?> _fHA203kB10SubTotal;
        /// <summary>
        /// FHA 203k B10 Subtotal (B5-B9) [MAX23K.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B10 Subtotal (B5-B9)")]
        public decimal? FHA203kB10SubTotal { get => _fHA203kB10SubTotal; set => _fHA203kB10SubTotal = value; }
        private DirtyValue<string> _fHA203kRemarks;
        /// <summary>
        /// FHA 203k Remarks [MAX23K.X53]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Remarks")]
        public string FHA203kRemarks { get => _fHA203kRemarks; set => _fHA203kRemarks = value; }
        private DirtyValue<StringEnumValue<FHAStreamlineType>> _fHAStreamlineType;
        /// <summary>
        /// HUD 92900 LT FHA Streamline Type [3659]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT FHA Streamline Type")]
        public StringEnumValue<FHAStreamlineType> FHAStreamlineType { get => _fHAStreamlineType; set => _fHAStreamlineType = value; }
        private DirtyValue<decimal?> _finalBaseMortgageAmount;
        /// <summary>
        /// FHA 203k - Final Base Mortgage Amount = Lesser of (Sum of Step 4B + Step 4E) or Step 4F [MAX23K.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Final Base Mortgage Amount = Lesser of (Sum of Step 4B + Step 4E) or Step 4F")]
        public decimal? FinalBaseMortgageAmount { get => _finalBaseMortgageAmount; set => _finalBaseMortgageAmount = value; }
        private DirtyValue<decimal?> _financeableMortgageFeesIfCharged;
        /// <summary>
        /// FHA 203k - Financeable Mortgage Fees, if charged (Sum of C1 and C2) [MAX23K.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Financeable Mortgage Fees, if charged (Sum of C1 and C2)")]
        public decimal? FinanceableMortgageFeesIfCharged { get => _financeableMortgageFeesIfCharged; set => _financeableMortgageFeesIfCharged = value; }
        private DirtyValue<bool?> _haveOtherPendingApplicationForFHA;
        /// <summary>
        /// HUD Property Improve Other Pending Appl [CAPIAP.X1]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Other Pending Appl", OptionsJson = "{\"true\":\"Have other pending application for FHA Title I Loan\"}")]
        public bool? HaveOtherPendingApplicationForFHA { get => _haveOtherPendingApplicationForFHA; set => _haveOtherPendingApplicationForFHA = value; }
        private DirtyValue<bool?> _hUDOwned;
        /// <summary>
        /// FHA 203k Property HUD-Owned [MAX23K.X1]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Property HUD-Owned", OptionsJson = "{\"true\":\"HUD-Owned\"}")]
        public bool? HUDOwned { get => _hUDOwned; set => _hUDOwned = value; }
        private DirtyValue<bool?> _hUDREOIndicator;
        /// <summary>
        /// HUD 92900 LT HUD REO [2999]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT HUD REO")]
        public bool? HUDREOIndicator { get => _hUDREOIndicator; set => _hUDREOIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// HudLoanData Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _independentConsultantFee;
        /// <summary>
        /// FHA 203k B7 Independent Consultant Fees [MAX23K.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B7 Independent Consultant Fees")]
        public decimal? IndependentConsultantFee { get => _independentConsultantFee; set => _independentConsultantFee = value; }
        private DirtyValue<decimal?> _initialBaseMortgageAmountPlusEEMImprovementAmount;
        /// <summary>
        /// FHA 203k - Initial Base Mortgage Amount + EEM Improvement Amount [MAX23K.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Initial Base Mortgage Amount + EEM Improvement Amount")]
        public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get => _initialBaseMortgageAmountPlusEEMImprovementAmount; set => _initialBaseMortgageAmountPlusEEMImprovementAmount = value; }
        private DirtyValue<decimal?> _initialDrawAtClosingArchitecturalorEngineeringFees;
        /// <summary>
        /// Initial Draw at Closing Total 203K Architectural or Engineering Fees [MAX23K.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Draw at Closing Total 203K Architectural or Engineering Fees")]
        public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get => _initialDrawAtClosingArchitecturalorEngineeringFees; set => _initialDrawAtClosingArchitecturalorEngineeringFees = value; }
        private DirtyValue<decimal?> _initialDrawAtClosingConsultantFees;
        /// <summary>
        /// Initial Draw at Closing Total 203K Consultant Fees [MAX23K.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Draw at Closing Total 203K Consultant Fees")]
        public decimal? InitialDrawAtClosingConsultantFees { get => _initialDrawAtClosingConsultantFees; set => _initialDrawAtClosingConsultantFees = value; }
        private DirtyValue<decimal?> _initialDrawAtClosingPermitFees;
        /// <summary>
        /// Initial Draw at Closing Total 203K Permit Fees [MAX23K.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Draw at Closing Total 203K Permit Fees")]
        public decimal? InitialDrawAtClosingPermitFees { get => _initialDrawAtClosingPermitFees; set => _initialDrawAtClosingPermitFees = value; }
        private DirtyValue<decimal?> _initialDrawAtClosingTotal;
        /// <summary>
        /// FHA 203k - Initial Draw at Closing Total (sum of B1 thru B7) [MAX23K.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Initial Draw at Closing Total (sum of B1 thru B7)")]
        public decimal? InitialDrawAtClosingTotal { get => _initialDrawAtClosingTotal; set => _initialDrawAtClosingTotal = value; }
        private DirtyValue<decimal?> _inspectionFeeAmount;
        /// <summary>
        /// FHA 203k B3 Cost Per Inspection [MAX23K.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B3 Cost Per Inspection")]
        public decimal? InspectionFeeAmount { get => _inspectionFeeAmount; set => _inspectionFeeAmount = value; }
        private DirtyValue<decimal?> _inspectionFeesDuringRehabilitation;
        /// <summary>
        /// FHA 203k - Inspection Fees (work Performed during Rehabilitation) [MAX23K.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Inspection Fees (work Performed during Rehabilitation)")]
        public decimal? InspectionFeesDuringRehabilitation { get => _inspectionFeesDuringRehabilitation; set => _inspectionFeesDuringRehabilitation = value; }
        private DirtyValue<int?> _inspectionFeeTimes;
        /// <summary>
        /// FHA 203k B3 # Inspections [MAX23K.X11]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k B3 # Inspections")]
        public int? InspectionFeeTimes { get => _inspectionFeeTimes; set => _inspectionFeeTimes = value; }
        private DirtyValue<decimal?> _interestDueonExistingMortgage;
        /// <summary>
        /// FHA 203k - Interest due on the existing mortgage(s) [MAX23K.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Interest due on the existing mortgage(s)")]
        public decimal? InterestDueonExistingMortgage { get => _interestDueonExistingMortgage; set => _interestDueonExistingMortgage = value; }
        private DirtyValue<decimal?> _lateCharges;
        /// <summary>
        /// FHA 203k - Late Charges [MAX23K.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Late Charges")]
        public decimal? LateCharges { get => _lateCharges; set => _lateCharges = value; }
        private DirtyValue<bool?> _lDPGSAForBorrower;
        /// <summary>
        /// HUD 92900 LT LDP / GSA For Borrower [3026]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT LDP / GSA For Borrower")]
        public bool? LDPGSAForBorrower { get => _lDPGSAForBorrower; set => _lDPGSAForBorrower = value; }
        private DirtyValue<bool?> _lDPGSAForCoBorrower;
        /// <summary>
        /// HUD 92900 LT LDP / GSA For CoBorrower [3027]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT LDP / GSA For CoBorrower")]
        public bool? LDPGSAForCoBorrower { get => _lDPGSAForCoBorrower; set => _lDPGSAForCoBorrower = value; }
        private DirtyValue<bool?> _leasedFromSomeoneElse;
        /// <summary>
        /// HUD Property Improve Leased from Other [CAPIAP.X46]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Leased from Other", OptionsJson = "{\"true\":\"Leased from someone else\"}")]
        public bool? LeasedFromSomeoneElse { get => _leasedFromSomeoneElse; set => _leasedFromSomeoneElse = value; }
        private DirtyValue<DateTime?> _leaseExpiradionDate;
        /// <summary>
        /// HUD Property Improve Lease Exp Date [CAPIAP.X55]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Lease Exp Date")]
        public DateTime? LeaseExpiradionDate { get => _leaseExpiradionDate; set => _leaseExpiradionDate = value; }
        private DirtyValue<decimal?> _leaseMonthlyPayment;
        /// <summary>
        /// HUD Property Improve Lease Mo Pymt [CAPIAP.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Lease Mo Pymt")]
        public decimal? LeaseMonthlyPayment { get => _leaseMonthlyPayment; set => _leaseMonthlyPayment = value; }
        private DirtyValue<decimal?> _lessAllowableDownpayment;
        /// <summary>
        /// FHA 203k C5 Allowable Down/HUD-Owned Property [MAX23K.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k C5 Allowable Down/HUD-Owned Property")]
        public decimal? LessAllowableDownpayment { get => _lessAllowableDownpayment; set => _lessAllowableDownpayment = value; }
        private DirtyValue<decimal?> _lesserOf3AOr3B;
        /// <summary>
        /// FHA 203k - Lesser of 3A or 3B [MAX23K.X86]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Lesser of 3A or 3B")]
        public decimal? LesserOf3AOr3B { get => _lesserOf3AOr3B; set => _lesserOf3AOr3B = value; }
        private DirtyValue<decimal?> _lesserOf3AOr3BMultiply3F;
        /// <summary>
        /// FHA 203k - Lesser of 3A or 3B * 3F [MAX23K.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Lesser of 3A or 3B * 3F")]
        public decimal? LesserOf3AOr3BMultiply3F { get => _lesserOf3AOr3BMultiply3F; set => _lesserOf3AOr3BMultiply3F = value; }
        private DirtyValue<decimal?> _lesserOfMaximumFinanceableSolarOrWindEnergyAmount;
        /// <summary>
        /// FHA 203k - Lesser of (Step 4C or Step 4D) = Maximum Financeable Solar/Wind Energy Amount [MAX23K.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Lesser of (Step 4C or Step 4D) = Maximum Financeable Solar/Wind Energy Amount")]
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get => _lesserOfMaximumFinanceableSolarOrWindEnergyAmount; set => _lesserOfMaximumFinanceableSolarOrWindEnergyAmount = value; }
        private DirtyValue<decimal?> _lesserOfSalesPrice;
        /// <summary>
        /// FHA 203k C1 Lesser of Sales Price/As Is Value [MAX23K.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k C1 Lesser of Sales Price/As Is Value")]
        public decimal? LesserOfSalesPrice { get => _lesserOfSalesPrice; set => _lesserOfSalesPrice = value; }
        private DirtyValue<decimal?> _lesserOfSumAmount;
        /// <summary>
        /// FHA 203k C3 Lesser (C1+C2)/110% After Imprvd Val [MAX23K.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k C3 Lesser (C1+C2)/110% After Imprvd Val")]
        public decimal? LesserOfSumAmount { get => _lesserOfSumAmount; set => _lesserOfSumAmount = value; }
        private DirtyValue<decimal?> _lesserOfSumAsIs;
        /// <summary>
        /// FHA 203k D2 Sum(A2+B14) [MAX23K.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D2 Sum(A2+B14)")]
        public decimal? LesserOfSumAsIs { get => _lesserOfSumAsIs; set => _lesserOfSumAsIs = value; }
        private DirtyValue<decimal?> _lesserOfSumPercent;
        /// <summary>
        /// FHA 203k C3 Sum (C1+C2) [MAX23K.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k C3 Sum (C1+C2)")]
        public decimal? LesserOfSumPercent { get => _lesserOfSumPercent; set => _lesserOfSumPercent = value; }
        private DirtyValue<decimal?> _lessLeadBasedPaintCredit;
        /// <summary>
        /// Less Lead-Based Paint Credit [MAX23K.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Less Lead-Based Paint Credit")]
        public decimal? LessLeadBasedPaintCredit { get => _lessLeadBasedPaintCredit; set => _lessLeadBasedPaintCredit = value; }
        private DirtyValue<bool?> _limitedProgram;
        /// <summary>
        /// FHA 203k - Limited Program [MAX23K.X117]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k - Limited Program")]
        public bool? LimitedProgram { get => _limitedProgram; set => _limitedProgram = value; }
        private DirtyValue<bool?> _loanFor203KIndicator;
        /// <summary>
        /// HUD 92900 LT Loan for 203K [3000]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Loan for 203K")]
        public bool? LoanFor203KIndicator { get => _loanFor203KIndicator; set => _loanFor203KIndicator = value; }
        private DirtyValue<string> _loanPurpose;
        /// <summary>
        /// HUD 92900 LT CHUMS ID# For Loan Purpose [3031]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD 92900 LT CHUMS ID# For Loan Purpose")]
        public string LoanPurpose { get => _loanPurpose; set => _loanPurpose = value; }
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractor;
        /// <summary>
        /// FHA 203k - Material costs for items ordered and prepaid by Borrower/or contractor (under contract for delivery) [MAX23K.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Material costs for items ordered and prepaid by Borrower/or contractor (under contract for delivery)")]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get => _materialCostsOrderedPrepaidByBorrowerContractor; set => _materialCostsOrderedPrepaidByBorrowerContractor = value; }
        private DirtyValue<decimal?> _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent;
        /// <summary>
        /// FHA 203k - Up to 50% of materials costs for items ordered but not yet paid for by the Borrower/or contractor [MAX23K.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Up to 50% of materials costs for items ordered but not yet paid for by the Borrower/or contractor")]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get => _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent; set => _materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent = value; }
        private DirtyValue<decimal?> _maximumMortgageWithUFMIP;
        /// <summary>
        /// FHA 203k Max Mortgage with UFMIP [MAX23K.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k Max Mortgage with UFMIP")]
        public decimal? MaximumMortgageWithUFMIP { get => _maximumMortgageWithUFMIP; set => _maximumMortgageWithUFMIP = value; }
        private DirtyValue<decimal?> _mIPDueOnExistingMortgage;
        /// <summary>
        /// FHA 203k - Mortgage Insurance Premium (MIP) due on existing mortgage(s) [MAX23K.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Mortgage Insurance Premium (MIP) due on existing mortgage(s)")]
        public decimal? MIPDueOnExistingMortgage { get => _mIPDueOnExistingMortgage; set => _mIPDueOnExistingMortgage = value; }
        private DirtyValue<decimal?> _mIPLTV;
        /// <summary>
        /// FHA 203k - MIP LTV = 3E divided by 2F (ie Base Mortgage Amount divided by After Improved Value) [MAX23K.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - MIP LTV = 3E divided by 2F (ie Base Mortgage Amount divided by After Improved Value)")]
        public decimal? MIPLTV { get => _mIPLTV; set => _mIPLTV = value; }
        private DirtyValue<bool?> _mtgOrDeedOfTrusOnProperty;
        /// <summary>
        /// HUD Property Improve Mtg/Deed of Trust [CAPIAP.X48]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Mtg/Deed of Trust", OptionsJson = "{\"true\":\"Mtg or deed of trust on property\"}")]
        public bool? MtgOrDeedOfTrusOnProperty { get => _mtgOrDeedOfTrusOnProperty; set => _mtgOrDeedOfTrusOnProperty = value; }
        private DirtyValue<decimal?> _mtgPaymentEscrowedAmount;
        /// <summary>
        /// FHA 203k B4 Cost Per Mo [MAX23K.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B4 Cost Per Mo")]
        public decimal? MtgPaymentEscrowedAmount { get => _mtgPaymentEscrowedAmount; set => _mtgPaymentEscrowedAmount = value; }
        private DirtyValue<int?> _mtgPaymentEscrowedTimes;
        /// <summary>
        /// FHA 203k B4 # Mos Mtg Pymts [MAX23K.X16]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k B4 # Mos Mtg Pymts")]
        public int? MtgPaymentEscrowedTimes { get => _mtgPaymentEscrowedTimes; set => _mtgPaymentEscrowedTimes = value; }
        private DirtyValue<decimal?> _nationwideMortgageLimit;
        /// <summary>
        /// FHA 203k - Nationwide Mortgage Limit [MAX23K.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Nationwide Mortgage Limit")]
        public decimal? NationwideMortgageLimit { get => _nationwideMortgageLimit; set => _nationwideMortgageLimit = value; }
        private DirtyValue<decimal?> _nationwideMortgageLimitAfter120Percent;
        /// <summary>
        /// FHA 203k - Step 3D × 120% (Nationwide Mortgage Limit × 120%) [MAX23K.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Step 3D × 120% (Nationwide Mortgage Limit × 120%)")]
        public decimal? NationwideMortgageLimitAfter120Percent { get => _nationwideMortgageLimitAfter120Percent; set => _nationwideMortgageLimitAfter120Percent = value; }
        private DirtyValue<bool?> _newResidential;
        /// <summary>
        /// HUD Property Improve New Res/Occ > 90 Days [CAPIAP.X56]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve New Res/Occ > 90 Days", OptionsJson = "{\"true\":\"This property is a new residential, and it has been occupied for longer than 90 days\"}")]
        public bool? NewResidential { get => _newResidential; set => _newResidential = value; }
        private DirtyValue<string> _nonresidentialTypeOfUse;
        /// <summary>
        /// HUD Property Improve Nonresidential Type of Use [CAPIAP.X43]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Nonresidential Type of Use")]
        public string NonresidentialTypeOfUse { get => _nonresidentialTypeOfUse; set => _nonresidentialTypeOfUse = value; }
        private DirtyValue<int?> _numberOfHistoricUnits;
        /// <summary>
        /// HUD Property Improve Hist Residential # Units [CAPIAP.X44]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Hist Residential # Units")]
        public int? NumberOfHistoricUnits { get => _numberOfHistoricUnits; set => _numberOfHistoricUnits = value; }
        private DirtyValue<int?> _numberOfMultifamilyUnits;
        /// <summary>
        /// HUD Property Improve Multifamily # Units [CAPIAP.X61]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Multifamily # Units")]
        public int? NumberOfMultifamilyUnits { get => _numberOfMultifamilyUnits; set => _numberOfMultifamilyUnits = value; }
        private DirtyValue<string> _otherDescription;
        /// <summary>
        /// FHA 203k Other Descr [MAX23K.X74]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Other Descr")]
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _ownedByBorrower;
        /// <summary>
        /// HUD Property Improve Owned by Borr [CAPIAP.X45]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Owned by Borr", OptionsJson = "{\"true\":\"Owned by Borrower\"}")]
        public bool? OwnedByBorrower { get => _ownedByBorrower; set => _ownedByBorrower = value; }
        private DirtyValue<decimal?> _percentAfterImprovedValue;
        /// <summary>
        /// FHA 203k A4 110% After Improved Value [MAX23K.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k A4 110% After Improved Value")]
        public decimal? PercentAfterImprovedValue { get => _percentAfterImprovedValue; set => _percentAfterImprovedValue = value; }
        private DirtyValue<decimal?> _permitsAndOtherFee;
        /// <summary>
        /// FHA 203k B8 Permits/Other Fees [MAX23K.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B8 Permits/Other Fees")]
        public decimal? PermitsAndOtherFee { get => _permitsAndOtherFee; set => _permitsAndOtherFee = value; }
        private DirtyValue<decimal?> _planReviewerFeeAddition;
        /// <summary>
        /// FHA Consultant Fees [MAX23K.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA Consultant Fees")]
        public decimal? PlanReviewerFeeAddition { get => _planReviewerFeeAddition; set => _planReviewerFeeAddition = value; }
        private DirtyValue<decimal?> _planReviewerFeeAmount;
        /// <summary>
        /// FHA 203k B9 Plan Reviewer Amt Per Mile [MAX23K.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B9 Plan Reviewer Amt Per Mile")]
        public decimal? PlanReviewerFeeAmount { get => _planReviewerFeeAmount; set => _planReviewerFeeAmount = value; }
        private DirtyValue<int?> _planReviewerFeeMiles;
        /// <summary>
        /// FHA 203k B9 Plan Reviewer # Miles [MAX23K.X22]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k B9 Plan Reviewer # Miles")]
        public int? PlanReviewerFeeMiles { get => _planReviewerFeeMiles; set => _planReviewerFeeMiles = value; }
        private DirtyValue<decimal?> _prepaymentPenalties;
        /// <summary>
        /// FHA 203k - Prepayment penalties assessed [MAX23K.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Prepayment penalties assessed")]
        public decimal? PrepaymentPenalties { get => _prepaymentPenalties; set => _prepaymentPenalties = value; }
        private DirtyValue<string> _propertyOwnerAddress;
        /// <summary>
        /// HUD Property Improve Owner Addr [CAPIAP.X50]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Owner Addr")]
        public string PropertyOwnerAddress { get => _propertyOwnerAddress; set => _propertyOwnerAddress = value; }
        private DirtyValue<string> _propertyOwnerCity;
        /// <summary>
        /// HUD Property Improve Owner City [CAPIAP.X51]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Owner City")]
        public string PropertyOwnerCity { get => _propertyOwnerCity; set => _propertyOwnerCity = value; }
        private DirtyValue<string> _propertyOwnerName;
        /// <summary>
        /// HUD Property Improve Owner Name [CAPIAP.X49]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Owner Name")]
        public string PropertyOwnerName { get => _propertyOwnerName; set => _propertyOwnerName = value; }
        private DirtyValue<string> _propertyOwnerPostalCode;
        /// <summary>
        /// HUD Property Improve Owner Zip [CAPIAP.X53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD Property Improve Owner Zip")]
        public string PropertyOwnerPostalCode { get => _propertyOwnerPostalCode; set => _propertyOwnerPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _propertyOwnerState;
        /// <summary>
        /// HUD Property Improve Owner State [CAPIAP.X52]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Owner State")]
        public StringEnumValue<State> PropertyOwnerState { get => _propertyOwnerState; set => _propertyOwnerState = value; }
        private DirtyValue<StringEnumValue<PropertyToBeImproved>> _propertyToBeImproved;
        /// <summary>
        /// HUD Property Improve HUD Property Type [CAPIAP.X60]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve HUD Property Type")]
        public StringEnumValue<PropertyToBeImproved> PropertyToBeImproved { get => _propertyToBeImproved; set => _propertyToBeImproved = value; }
        private DirtyValue<StringEnumValue<HudLoanDataPropertyType>> _propertyType;
        /// <summary>
        /// HUD 92900 LT Subject Property Type [2996]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Subject Property Type")]
        public StringEnumValue<HudLoanDataPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<DateTime?> _purchaseDate;
        /// <summary>
        /// Subject Property Purchase Date [1518]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Purchase Date")]
        public DateTime? PurchaseDate { get => _purchaseDate; set => _purchaseDate = value; }
        private DirtyValue<bool?> _purchasedOnContract;
        /// <summary>
        /// HUD Property Improve Purch on Contract [CAPIAP.X47]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Purch on Contract", OptionsJson = "{\"true\":\"Being Purchased on contract\"}")]
        public bool? PurchasedOnContract { get => _purchasedOnContract; set => _purchasedOnContract = value; }
        private DirtyValue<decimal?> _purchaseMaximumMortgageAmount;
        /// <summary>
        /// FHA 203k C5 Max Mtg Amt [MAX23K.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k C5 Max Mtg Amt")]
        public decimal? PurchaseMaximumMortgageAmount { get => _purchaseMaximumMortgageAmount; set => _purchaseMaximumMortgageAmount = value; }
        private DirtyValue<decimal?> _purchaseMaximumMortgagePercent;
        /// <summary>
        /// FHA 203k C5 Required Adj Amt [MAX23K.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "FHA 203k C5 Required Adj Amt")]
        public decimal? PurchaseMaximumMortgagePercent { get => _purchaseMaximumMortgagePercent; set => _purchaseMaximumMortgagePercent = value; }
        private DirtyValue<decimal?> _purchasePriceLessInducementToPurchase;
        /// <summary>
        /// FHA 203k - Purchase Price Less Inducement to Purchase [MAX23K.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Purchase Price Less Inducement to Purchase")]
        public decimal? PurchasePriceLessInducementToPurchase { get => _purchasePriceLessInducementToPurchase; set => _purchasePriceLessInducementToPurchase = value; }
        private DirtyValue<decimal?> _refinanceMaximumMortgageAmount;
        /// <summary>
        /// FHA 203k D5 Max Mtg Amt [MAX23K.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k D5 Max Mtg Amt")]
        public decimal? RefinanceMaximumMortgageAmount { get => _refinanceMaximumMortgageAmount; set => _refinanceMaximumMortgageAmount = value; }
        private DirtyValue<bool?> _refinancingATitleILoan;
        /// <summary>
        /// HUD Property Improve Refi Title 1 Loan [CAPIAP.X2]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Refi Title 1 Loan", OptionsJson = "{\"true\":\"Refinancing a Title I loan\"}")]
        public bool? RefinancingATitleILoan { get => _refinancingATitleILoan; set => _refinancingATitleILoan = value; }
        private DirtyValue<decimal?> _rehabilitationEscrowAccount;
        /// <summary>
        /// FHA 203k - Rehabilitation Escrow Account (Sum of A1 thru A3) [MAX23K.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Rehabilitation Escrow Account (Sum of A1 thru A3)")]
        public decimal? RehabilitationEscrowAccount { get => _rehabilitationEscrowAccount; set => _rehabilitationEscrowAccount = value; }
        private DirtyValue<decimal?> _rehabilitationEscrowAmountBalanceForFutureDraws;
        /// <summary>
        /// FHA 203k - Rehabilitation Escrow Amount Balance (for Future Draws) = 6A minus 6B [MAX23K.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Rehabilitation Escrow Amount Balance (for Future Draws) = 6A minus 6B")]
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get => _rehabilitationEscrowAmountBalanceForFutureDraws; set => _rehabilitationEscrowAmountBalanceForFutureDraws = value; }
        private DirtyValue<decimal?> _rentalCashFlowBalance;
        /// <summary>
        /// HUD 92900 LT Rental Cash Flow Balance [3024]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 92900 LT Rental Cash Flow Balance")]
        public decimal? RentalCashFlowBalance { get => _rentalCashFlowBalance; set => _rentalCashFlowBalance = value; }
        private DirtyValue<StringEnumValue<HudLoanDataResidencyType>> _residencyType;
        /// <summary>
        /// FHA 203k Owner Type [MAX23K.X69]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Owner Type")]
        public StringEnumValue<HudLoanDataResidencyType> ResidencyType { get => _residencyType; set => _residencyType = value; }
        private DirtyValue<StringEnumValue<HudLoanDataRiskClass>> _riskClass;
        /// <summary>
        /// HUD 92900 LT Risk Class [3029]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Risk Class")]
        public StringEnumValue<HudLoanDataRiskClass> RiskClass { get => _riskClass; set => _riskClass = value; }
        private DirtyValue<bool?> _scoredByTotal;
        /// <summary>
        /// HUD 92900 LT Scored By TOTAL [3028]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Scored By TOTAL")]
        public bool? ScoredByTotal { get => _scoredByTotal; set => _scoredByTotal = value; }
        private DirtyList<SecondaryFinancingProvider> _secondaryFinancingProviders;
        /// <summary>
        /// HudLoanData SecondaryFinancingProviders
        /// </summary>
        public IList<SecondaryFinancingProvider> SecondaryFinancingProviders { get => _secondaryFinancingProviders ?? (_secondaryFinancingProviders = new DirtyList<SecondaryFinancingProvider>()); set => _secondaryFinancingProviders = new DirtyList<SecondaryFinancingProvider>(value); }
        private DirtyValue<decimal?> _sellerContributionRate;
        /// <summary>
        /// Lock Request Total Seller Contribution Percentage [3048]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lock Request Total Seller Contribution Percentage")]
        public decimal? SellerContributionRate { get => _sellerContributionRate; set => _sellerContributionRate = value; }
        private DirtyValue<bool?> _simpleRefinance;
        /// <summary>
        /// HUD 92900 LT Simple Refinance [4056]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 92900 LT Simple Refinance")]
        public bool? SimpleRefinance { get => _simpleRefinance; set => _simpleRefinance = value; }
        private DirtyValue<decimal?> _statutoryInvestment;
        /// <summary>
        /// FHA 203k C4 Statutory Investment Required [MAX23K.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k C4 Statutory Investment Required")]
        public decimal? StatutoryInvestment { get => _statutoryInvestment; set => _statutoryInvestment = value; }
        private DirtyValue<decimal?> _step2EPlusStep1E;
        /// <summary>
        /// FHA 203k - Step 2E + Step 1E (i.e. Adjusted As-Is Value + Step 1 Total) [MAX23K.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Step 2E + Step 1E (i.e. Adjusted As-Is Value + Step 1 Total)")]
        public decimal? Step2EPlusStep1E { get => _step2EPlusStep1E; set => _step2EPlusStep1E = value; }
        private DirtyValue<bool?> _streamlined;
        /// <summary>
        /// FHA 203k Streamlined [MAX23K.X78]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k Streamlined", OptionsJson = "{\"true\":\"Streamlined (k)\"}")]
        public bool? Streamlined { get => _streamlined; set => _streamlined = value; }
        private DirtyValue<decimal?> _subTotalForEscrowAccount;
        /// <summary>
        /// FHA 203k B5 Subtotal Rehab Escrow Acct (B1-B4) [MAX23K.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B5 Subtotal Rehab Escrow Acct (B1-B4)")]
        public decimal? SubTotalForEscrowAccount { get => _subTotalForEscrowAccount; set => _subTotalForEscrowAccount = value; }
        private DirtyValue<decimal?> _subTotalForReleaseAtClosing;
        /// <summary>
        /// FHA 203k B13 Subtotal Release at Closing [MAX23K.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B13 Subtotal Release at Closing")]
        public decimal? SubTotalForReleaseAtClosing { get => _subTotalForReleaseAtClosing; set => _subTotalForReleaseAtClosing = value; }
        private DirtyValue<decimal?> _sumForInvestor;
        /// <summary>
        /// FHA 203k D4 Sum(D2+D3) [MAX23K.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D4 Sum(D2+D3)")]
        public decimal? SumForInvestor { get => _sumForInvestor; set => _sumForInvestor = value; }
        private DirtyValue<decimal?> _sumForOwnerOccupied;
        /// <summary>
        /// FHA 203k D4 Sum(D2+D3)x85% or 97/95/90% [MAX23K.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D4 Sum(D2+D3)x85% or 97/95/90%")]
        public decimal? SumForOwnerOccupied { get => _sumForOwnerOccupied; set => _sumForOwnerOccupied = value; }
        private DirtyValue<decimal?> _sumOfExistingDebt;
        /// <summary>
        /// FHA 203k D1 (A1+B14+A5+Prepaids+Disc-B12) [MAX23K.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k D1 (A1+B14+A5+Prepaids+Disc-B12)")]
        public decimal? SumOfExistingDebt { get => _sumOfExistingDebt; set => _sumOfExistingDebt = value; }
        private DirtyValue<decimal?> _suplementalOriginationFee;
        /// <summary>
        /// FHA 203k B11 Supplemental Origination Fee [MAX23K.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B11 Supplemental Origination Fee")]
        public decimal? SuplementalOriginationFee { get => _suplementalOriginationFee; set => _suplementalOriginationFee = value; }
        private DirtyValue<decimal?> _title1LoanBalance;
        /// <summary>
        /// HUD Property Improve Title 1 Loan Bal [CAPIAP.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Property Improve Title 1 Loan Bal")]
        public decimal? Title1LoanBalance { get => _title1LoanBalance; set => _title1LoanBalance = value; }
        private DirtyValue<string> _title1LoanNumber;
        /// <summary>
        /// HUD Property Improve Title 1 Loan # [CAPIAP.X3]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Title 1 Loan #")]
        public string Title1LoanNumber { get => _title1LoanNumber; set => _title1LoanNumber = value; }
        private DirtyValue<string> _title1LoanWithWhom;
        /// <summary>
        /// HUD Property Improve Title 1 Loan with Whom [CAPIAP.X59]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Improve Title 1 Loan with Whom")]
        public string Title1LoanWithWhom { get => _title1LoanWithWhom; set => _title1LoanWithWhom = value; }
        private DirtyValue<decimal?> _titleUpdateFeeAmount;
        /// <summary>
        /// FHA 203k B3 Cost Per Update [MAX23K.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B3 Cost Per Update")]
        public decimal? TitleUpdateFeeAmount { get => _titleUpdateFeeAmount; set => _titleUpdateFeeAmount = value; }
        private DirtyValue<decimal?> _titleUpdateFees;
        /// <summary>
        /// FHA 203k - Title Update Fees [MAX23K.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Title Update Fees")]
        public decimal? TitleUpdateFees { get => _titleUpdateFees; set => _titleUpdateFees = value; }
        private DirtyValue<int?> _titleUpdateFeeTimes;
        /// <summary>
        /// FHA 203k B3 # Updates [MAX23K.X13]
        /// </summary>
        [LoanFieldProperty(Description = "FHA 203k B3 # Updates")]
        public int? TitleUpdateFeeTimes { get => _titleUpdateFeeTimes; set => _titleUpdateFeeTimes = value; }
        private DirtyValue<decimal?> _totalCostsOfRepairsInA6;
        /// <summary>
        /// FHA 203k B1 Total Cost Repairs Incl A6 [MAX23K.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B1 Total Cost Repairs Incl A6")]
        public decimal? TotalCostsOfRepairsInA6 { get => _totalCostsOfRepairsInA6; set => _totalCostsOfRepairsInA6 = value; }
        private DirtyValue<decimal?> _totalEscrowCommitment;
        /// <summary>
        /// FHA 203k E3 Total Escrow Commitment [MAX23K.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k E3 Total Escrow Commitment")]
        public decimal? TotalEscrowCommitment { get => _totalEscrowCommitment; set => _totalEscrowCommitment = value; }
        private DirtyValue<decimal?> _totalEscrowedFunds;
        /// <summary>
        /// FHA 203k Total Escrowed Funds [MAX23K.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k Total Escrowed Funds")]
        public decimal? TotalEscrowedFunds { get => _totalEscrowedFunds; set => _totalEscrowedFunds = value; }
        private DirtyValue<decimal?> _totalFixedUnpaidBalance;
        /// <summary>
        /// HUD 92900 LT Total Fixed Unpaid Balance [3025]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD 92900 LT Total Fixed Unpaid Balance")]
        public decimal? TotalFixedUnpaidBalance { get => _totalFixedUnpaidBalance; set => _totalFixedUnpaidBalance = value; }
        private DirtyValue<decimal?> _totalForBorrowerEstimatedProfit;
        /// <summary>
        /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k E4 Borrower Estimated Profits")]
        public decimal? TotalForBorrowerEstimatedProfit { get => _totalForBorrowerEstimatedProfit; set => _totalForBorrowerEstimatedProfit = value; }
        private DirtyValue<decimal?> _totalForInspectionAndTitleFee;
        /// <summary>
        /// FHA 203k B3 Title Update Fee [MAX23K.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B3 Title Update Fee")]
        public decimal? TotalForInspectionAndTitleFee { get => _totalForInspectionAndTitleFee; set => _totalForInspectionAndTitleFee = value; }
        private DirtyValue<decimal?> _totalForLesserOfSumAsIs;
        /// <summary>
        /// FHA 203k D2 Lesser of Sum(A2+B14)/A4 [MAX23K.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k D2 Lesser of Sum(A2+B14)/A4")]
        public decimal? TotalForLesserOfSumAsIs { get => _totalForLesserOfSumAsIs; set => _totalForLesserOfSumAsIs = value; }
        private DirtyValue<decimal?> _totalForMtgPaymentEscrowed;
        /// <summary>
        /// FHA 203k B4 Mtg Pymt Escrowed [MAX23K.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B4 Mtg Pymt Escrowed")]
        public decimal? TotalForMtgPaymentEscrowed { get => _totalForMtgPaymentEscrowed; set => _totalForMtgPaymentEscrowed = value; }
        private DirtyValue<decimal?> _totalForPlanReviewerFee;
        /// <summary>
        /// FHA 203k B9 Plan Reviewer Fees [MAX23K.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k B9 Plan Reviewer Fees")]
        public decimal? TotalForPlanReviewerFee { get => _totalForPlanReviewerFee; set => _totalForPlanReviewerFee = value; }
        private DirtyValue<decimal?> _totalForRehabilitationCost;
        /// <summary>
        /// FHA 203k B14 Total Rehabilitation Cost [MAX23K.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k B14 Total Rehabilitation Cost")]
        public decimal? TotalForRehabilitationCost { get => _totalForRehabilitationCost; set => _totalForRehabilitationCost = value; }
        private DirtyValue<decimal?> _totalRehabilitationCosts;
        /// <summary>
        /// FHA 203k C2 Total Rehabilitation Cost [MAX23K.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k C2 Total Rehabilitation Cost")]
        public decimal? TotalRehabilitationCosts { get => _totalRehabilitationCosts; set => _totalRehabilitationCosts = value; }
        private DirtyValue<decimal?> _totalRehabilitationCostsFeesReserves;
        /// <summary>
        /// FHA 203k - Total Rehabilitation Costs, Fees and Reserves (Sum of 1A, 1B, 1C) Not to exceed $35,000 [MAX23K.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Total Rehabilitation Costs, Fees and Reserves (Sum of 1A, 1B, 1C) Not to exceed $35,000")]
        public decimal? TotalRehabilitationCostsFeesReserves { get => _totalRehabilitationCostsFeesReserves; set => _totalRehabilitationCostsFeesReserves = value; }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceFirstLien;
        /// <summary>
        /// FHA 203k - Unpaid Principal Balance (First Lien) [MAX23K.X124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Unpaid Principal Balance (First Lien)")]
        public decimal? UnpaidPrincipalBalanceFirstLien { get => _unpaidPrincipalBalanceFirstLien; set => _unpaidPrincipalBalanceFirstLien = value; }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfAnyJuniorLiens;
        /// <summary>
        /// FHA 203k - Unpaid Principal Balance of any junior liens [MAX23K.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Unpaid Principal Balance of any junior liens")]
        public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get => _unpaidPrincipalBalanceOfAnyJuniorLiens; set => _unpaidPrincipalBalanceOfAnyJuniorLiens = value; }
        private DirtyValue<decimal?> _unpaidPrincipalBalanceOfPurchaseJuniorLiens;
        /// <summary>
        /// FHA 203k - 2.Unpaid Principal Balance Purchase Junior Lien [MAX23K.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - 2.Unpaid Principal Balance Purchase Junior Lien")]
        public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get => _unpaidPrincipalBalanceOfPurchaseJuniorLiens; set => _unpaidPrincipalBalanceOfPurchaseJuniorLiens = value; }
        private DirtyValue<decimal?> _valueEstablished;
        /// <summary>
        /// FHA 203k E2 Value Established C5 or D5 [MAX23K.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA 203k E2 Value Established C5 or D5")]
        public decimal? ValueEstablished { get => _valueEstablished; set => _valueEstablished = value; }
        private DirtyValue<string> _waterPurificationAgent;
        /// <summary>
        /// FHA Basic Info - Water Purification Local Health Agent [4250]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Basic Info - Water Purification Local Health Agent")]
        public string WaterPurificationAgent { get => _waterPurificationAgent; set => _waterPurificationAgent = value; }
        private DirtyValue<string> _waterPurificationOrganization;
        /// <summary>
        /// FHA Basic Info - Water Purification Maintenance Organization [4249]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Basic Info - Water Purification Maintenance Organization")]
        public string WaterPurificationOrganization { get => _waterPurificationOrganization; set => _waterPurificationOrganization = value; }
        private DirtyValue<string> _waterPurificationPayees;
        /// <summary>
        /// FHA Basic Info - Water Purification Other Payees [4251]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Basic Info - Water Purification Other Payees")]
        public string WaterPurificationPayees { get => _waterPurificationPayees; set => _waterPurificationPayees = value; }
        private DirtyValue<decimal?> _windEnergySystemActualCost;
        /// <summary>
        /// FHA 203k - Solar/Wind Energy System Actual Cost [MAX23K.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA 203k - Solar/Wind Energy System Actual Cost")]
        public decimal? WindEnergySystemActualCost { get => _windEnergySystemActualCost; set => _windEnergySystemActualCost = value; }
        internal override bool DirtyInternal
        {
            get => _actualCashInvRequired.Dirty
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
                || _waterPurificationAgent.Dirty
                || _waterPurificationOrganization.Dirty
                || _waterPurificationPayees.Dirty
                || _windEnergySystemActualCost.Dirty
                || _secondaryFinancingProviders?.Dirty == true;
            set
            {
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
                _waterPurificationAgent.Dirty = value;
                _waterPurificationOrganization.Dirty = value;
                _waterPurificationPayees.Dirty = value;
                _windEnergySystemActualCost.Dirty = value;
                if (_secondaryFinancingProviders != null) _secondaryFinancingProviders.Dirty = value;
            }
        }
    }
}