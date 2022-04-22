using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// HudLoanData
/// </summary>
public sealed partial class HudLoanData : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FHA 203k C6 Actual Cash Invest Required [MAX23K.X38]
    /// </summary>
    public decimal? ActualCashInvRequired { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C7 Adj Max Mtg Amt [MAX23K.X39]
    /// </summary>
    public decimal? AdjustedMaxMtgAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A3 After Improved Value [MAX23K.X6]
    /// </summary>
    public decimal? AfterImprovedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Step 2F × 20% (After-Improved Value × 20%) [MAX23K.X98]
    /// </summary>
    public decimal? AfterImprovedValueAfter20Percent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A6 Allowable Energy Improvements [MAX23K.X8]
    /// </summary>
    public decimal? AllowableEnergyImprovements { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Appropriate LTV Factor [MAX23K.X87]
    /// </summary>
    public decimal? AppropriateLTVFactor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B6 Architect/Engineering Fees [MAX23K.X19]
    /// </summary>
    public decimal? ArchitecturalEngineeringFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A2 As Is Value [MAX23K.X5]
    /// </summary>
    public decimal? AsIsValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Base Mortgage Amount (Lesser of 3C or 3D) [MAX23K.X90]
    /// </summary>
    public decimal? BaseMortgageAmountFrom3COr3D { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Borr Acknowledgement [MAX23K.X73]
    /// </summary>
    public StringEnumValue<BorrowerAcknowledgement> BorrowerAcknowledgement { get => GetValue<StringEnumValue<BorrowerAcknowledgement>>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X76]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerEstimatedProfit1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Borrower Estimated Profit [MAX23K.X31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerEstimatedProfit2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D3 Borrower Paid Closing Costs [MAX23K.X59]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerPaidClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D6 Borr Required Investment [MAX23K.X48]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerRequiredInvestment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Borrowers Own Funds for Contingency Reserves (if not financed in 6:A1) [MAX23K.X95]
    /// </summary>
    public decimal? BorrowersOwnFundsforContingencyReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Building On Own Land [2998]
    /// </summary>
    public bool? BuildingOnOwnLand { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Case Number Assigned Date [3042]
    /// </summary>
    public DateTime? CaseAssignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Draw at Closing Total 203K Case LTV [MAX23K.X120]
    /// </summary>
    public decimal? CaseLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Child Support Unpaid Balance [3023]
    /// </summary>
    public decimal? ChildSupportBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT CHUMS ID# For Reviewer of Appraisal [3030]
    /// </summary>
    public string? CHUMSForAppraisal { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k E1 Max Mortgage Amount [MAX23K.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CommitmentMaximumMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Commitment Stage [MAX23K.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CommitmentStage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Costs of construction, repairs and rehabilitation [MAX23K.X80]
    /// </summary>
    public decimal? ConstructionRepairsRehabilitationCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B2 Contingency Reserve on Repair Costs [MAX23K.X10]
    /// </summary>
    public decimal? ContingencyReserveCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B2 Contingency Reserve % (10-20% of B1) [MAX23K.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ContingencyReserveCostsPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A1 Contract Sales Price [MAX23K.X40]
    /// </summary>
    public decimal? ContractSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Criteria for Appropriate LTV Factor [MAX23K.X118]
    /// </summary>
    public StringEnumValue<CriteriaForAppropriateLTVFactor> CriteriaForAppropriateLTVFactor { get => GetValue<StringEnumValue<CriteriaForAppropriateLTVFactor>>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Dealer/Contractor Addr [CAPIAP.X144]
    /// </summary>
    public string? DealerContractorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Dealer/Contractor City [CAPIAP.X145]
    /// </summary>
    public string? DealerContractorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Leased Info Dealer/Contractor Name [982]
    /// </summary>
    public string? DealerContractorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Dealer/Contractor Zip [CAPIAP.X147]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? DealerContractorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Dealer/Contractor State [CAPIAP.X146]
    /// </summary>
    public StringEnumValue<State> DealerContractorState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B12 Discount Points Amt [MAX23K.X27]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiscountPointsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B12 Discount Points % of B10 [MAX23K.X26]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPointsPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Energy Efficient Mortgage [2997]
    /// </summary>
    public bool? EEMIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k F1 Energy Efficient  Mtg Amt [MAX23K.X67]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EnergyEfficientMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Escrow Commitment [MAX23K.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EscrowCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Escrow shortages [MAX23K.X131]
    /// </summary>
    public decimal? EscrowShortages { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Existing Debt Total [MAX23K.X132]
    /// </summary>
    public decimal? Existing203KDebtTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A1 Existing Debt [MAX23K.X75]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Existing Debt\"}")]
    public bool? ExistingDebt { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Existing Debt plus Rehab Costs [MAX23K.X109]
    /// </summary>
    public decimal? ExistingDebtPlusRehabCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Existing Debt Plus Rehab Costs Plus New Loan Fees [MAX23K.X112]
    /// </summary>
    public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Feasibility Study when necessary [MAX23K.X81]
    /// </summary>
    public decimal? FeasibilityStudyWhenNecessary { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Fees Associated with the New Loan [MAX23K.X108]
    /// </summary>
    public decimal? FeesAssociatedWithNewLoan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B10 Subtotal (B5-B9) [MAX23K.X25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FHA203kB10SubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Remarks [MAX23K.X53]
    /// </summary>
    public string? FHA203kRemarks { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT FHA Streamline Type [3659]
    /// </summary>
    public StringEnumValue<FHAStreamlineType> FHAStreamlineType { get => GetValue<StringEnumValue<FHAStreamlineType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Final Base Mortgage Amount = Lesser of (Sum of Step 4B + Step 4E) or Step 4F [MAX23K.X101]
    /// </summary>
    public decimal? FinalBaseMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Financeable Mortgage Fees, if charged (Sum of C1 and C2) [MAX23K.X82]
    /// </summary>
    public decimal? FinanceableMortgageFeesIfCharged { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Other Pending Appl [CAPIAP.X1]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Have other pending application for FHA Title I Loan\"}")]
    public bool? HaveOtherPendingApplicationForFHA { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Property HUD-Owned [MAX23K.X1]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"HUD-Owned\"}")]
    public bool? HUDOwned { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT HUD REO [2999]
    /// </summary>
    public bool? HUDREOIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HudLoanData Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B7 Independent Consultant Fees [MAX23K.X20]
    /// </summary>
    public decimal? IndependentConsultantFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Initial Base Mortgage Amount + EEM Improvement Amount [MAX23K.X96]
    /// </summary>
    public decimal? InitialBaseMortgageAmountPlusEEMImprovementAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Draw at Closing Total 203K Architectural or Engineering Fees [MAX23K.X122]
    /// </summary>
    public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Draw at Closing Total 203K Consultant Fees [MAX23K.X121]
    /// </summary>
    public decimal? InitialDrawAtClosingConsultantFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Draw at Closing Total 203K Permit Fees [MAX23K.X123]
    /// </summary>
    public decimal? InitialDrawAtClosingPermitFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Initial Draw at Closing Total (sum of B1 thru B7) [MAX23K.X93]
    /// </summary>
    public decimal? InitialDrawAtClosingTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B3 Cost Per Inspection [MAX23K.X12]
    /// </summary>
    public decimal? InspectionFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Inspection Fees (work Performed during Rehabilitation) [MAX23K.X113]
    /// </summary>
    public decimal? InspectionFeesDuringRehabilitation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B3 # Inspections [MAX23K.X11]
    /// </summary>
    public int? InspectionFeeTimes { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Interest due on the existing mortgage(s) [MAX23K.X127]
    /// </summary>
    public decimal? InterestDueonExistingMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Late Charges [MAX23K.X130]
    /// </summary>
    public decimal? LateCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT LDP / SAM For Borrower [3026]
    /// </summary>
    public bool? LDPGSAForBorrower { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT LDP / SAM For CoBorrower [3027]
    /// </summary>
    public bool? LDPGSAForCoBorrower { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Leased from Other [CAPIAP.X46]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Leased from someone else\"}")]
    public bool? LeasedFromSomeoneElse { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Lease Exp Date [CAPIAP.X55]
    /// </summary>
    public DateTime? LeaseExpiradionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Lease Mo Pymt [CAPIAP.X54]
    /// </summary>
    public decimal? LeaseMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C5 Allowable Down/HUD-Owned Property [MAX23K.X36]
    /// </summary>
    public decimal? LessAllowableDownpayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Lesser of 3A or 3B [MAX23K.X86]
    /// </summary>
    public decimal? LesserOf3AOr3B { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Lesser of 3A or 3B * 3F [MAX23K.X88]
    /// </summary>
    public decimal? LesserOf3AOr3BMultiply3F { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Lesser of (Step 4C or Step 4D) = Maximum Financeable Solar/Wind Energy Amount [MAX23K.X99]
    /// </summary>
    public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C1 Lesser of Sales Price/As Is Value [MAX23K.X30]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserOfSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C3 Lesser (C1+C2)/110% After Imprvd Val [MAX23K.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserOfSumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D2 Sum(A2+B14) [MAX23K.X42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserOfSumAsIs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C3 Sum (C1+C2) [MAX23K.X32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserOfSumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Less Lead-Based Paint Credit [MAX23K.X119]
    /// </summary>
    public decimal? LessLeadBasedPaintCredit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Limited Program [MAX23K.X117]
    /// </summary>
    public bool? LimitedProgram { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Loan for 203K [3000]
    /// </summary>
    public bool? LoanFor203KIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT CHUMS ID# For Loan Purpose [3031]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanPurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Material costs for items ordered and prepaid by Borrower/or contractor (under contract for delivery) [MAX23K.X91]
    /// </summary>
    public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Up to 50% of materials costs for items ordered but not yet paid for by the Borrower/or contractor [MAX23K.X92]
    /// </summary>
    public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Max Mortgage with UFMIP [MAX23K.X79]
    /// </summary>
    public decimal? MaximumMortgageWithUFMIP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Mortgage Insurance Premium (MIP) due on existing mortgage(s) [MAX23K.X128]
    /// </summary>
    public decimal? MIPDueOnExistingMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - MIP LTV = 3E divided by 2F (ie Base Mortgage Amount divided by After Improved Value) [MAX23K.X104]
    /// </summary>
    public decimal? MIPLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Mtg/Deed of Trust [CAPIAP.X48]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Mtg or deed of trust on property\"}")]
    public bool? MtgOrDeedOfTrusOnProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B4 Cost Per Mo [MAX23K.X63]
    /// </summary>
    public decimal? MtgPaymentEscrowedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B4 # Mos Mtg Pymts [MAX23K.X16]
    /// </summary>
    public int? MtgPaymentEscrowedTimes { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Nationwide Mortgage Limit [MAX23K.X89]
    /// </summary>
    public decimal? NationwideMortgageLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Step 3D × 120% (Nationwide Mortgage Limit × 120%) [MAX23K.X100]
    /// </summary>
    public decimal? NationwideMortgageLimitAfter120Percent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve New Res/Occ > 90 Days [CAPIAP.X56]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"This property is a new residential, and it has been occupied for longer than 90 days\"}")]
    public bool? NewResidential { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Nonresidential Type of Use [CAPIAP.X43]
    /// </summary>
    public string? NonresidentialTypeOfUse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Hist Residential # Units [CAPIAP.X44]
    /// </summary>
    public int? NumberOfHistoricUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Multifamily # Units [CAPIAP.X61]
    /// </summary>
    public int? NumberOfMultifamilyUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Other Descr [MAX23K.X74]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owned by Borr [CAPIAP.X45]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Owned by Borrower\"}")]
    public bool? OwnedByBorrower { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k A4 110% After Improved Value [MAX23K.X7]
    /// </summary>
    public decimal? PercentAfterImprovedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B8 Permits/Other Fees [MAX23K.X21]
    /// </summary>
    public decimal? PermitsAndOtherFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Consultant Fees [MAX23K.X77]
    /// </summary>
    public decimal? PlanReviewerFeeAddition { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B9 Plan Reviewer Amt Per Mile [MAX23K.X23]
    /// </summary>
    public decimal? PlanReviewerFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B9 Plan Reviewer # Miles [MAX23K.X22]
    /// </summary>
    public int? PlanReviewerFeeMiles { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Prepayment penalties assessed [MAX23K.X129]
    /// </summary>
    public decimal? PrepaymentPenalties { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owner Addr [CAPIAP.X50]
    /// </summary>
    public string? PropertyOwnerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owner City [CAPIAP.X51]
    /// </summary>
    public string? PropertyOwnerCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owner Name [CAPIAP.X49]
    /// </summary>
    public string? PropertyOwnerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owner Zip [CAPIAP.X53]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyOwnerPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Owner State [CAPIAP.X52]
    /// </summary>
    public StringEnumValue<State> PropertyOwnerState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve HUD Property Type [CAPIAP.X60]
    /// </summary>
    public StringEnumValue<PropertyToBeImproved> PropertyToBeImproved { get => GetValue<StringEnumValue<PropertyToBeImproved>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Subject Property Type [2996]
    /// </summary>
    public StringEnumValue<HudLoanDataPropertyType> PropertyType { get => GetValue<StringEnumValue<HudLoanDataPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Purchase Date [1518]
    /// </summary>
    public DateTime? PurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Purch on Contract [CAPIAP.X47]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Being Purchased on contract\"}")]
    public bool? PurchasedOnContract { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C5 Max Mtg Amt [MAX23K.X37]
    /// </summary>
    public decimal? PurchaseMaximumMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C5 Required Adj Amt [MAX23K.X35]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PurchaseMaximumMortgagePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Purchase Price Less Inducement to Purchase [MAX23K.X84]
    /// </summary>
    public decimal? PurchasePriceLessInducementToPurchase { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D5 Max Mtg Amt [MAX23K.X47]
    /// </summary>
    public decimal? RefinanceMaximumMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Refi Title 1 Loan [CAPIAP.X2]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Refinancing a Title I loan\"}")]
    public bool? RefinancingATitleILoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Rehabilitation Construction Period Months [MAX23K.X133]
    /// </summary>
    public StringEnumValue<RehabConstructionPeriodMonths> RehabConstructionPeriodMonths { get => GetValue<StringEnumValue<RehabConstructionPeriodMonths>>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Rehabilitation Escrow Account (Sum of A1 thru A3) [MAX23K.X103]
    /// </summary>
    public decimal? RehabilitationEscrowAccount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Rehabilitation Escrow Amount Balance (for Future Draws) = 6A minus 6B [MAX23K.X115]
    /// </summary>
    public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Rental Cash Flow Balance [3024]
    /// </summary>
    public decimal? RentalCashFlowBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Owner Type [MAX23K.X69]
    /// </summary>
    public StringEnumValue<HudLoanDataResidencyType> ResidencyType { get => GetValue<StringEnumValue<HudLoanDataResidencyType>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Risk Class [3029]
    /// </summary>
    public StringEnumValue<HudLoanDataRiskClass> RiskClass { get => GetValue<StringEnumValue<HudLoanDataRiskClass>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Scored By TOTAL [3028]
    /// </summary>
    public bool? ScoredByTotal { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HudLoanData SecondaryFinancingProviders
    /// </summary>
    [AllowNull]
    public IList<SecondaryFinancingProvider> SecondaryFinancingProviders { get => GetList<SecondaryFinancingProvider>(); set => SetList(value); }

    /// <summary>
    /// Lock Request Total Seller Contribution Percentage [3048]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellerContributionRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Simple Refinance [4056]
    /// </summary>
    public bool? SimpleRefinance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C4 Statutory Investment Required [MAX23K.X34]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? StatutoryInvestment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Step 2E + Step 1E (i.e. Adjusted As-Is Value + Step 1 Total) [MAX23K.X85]
    /// </summary>
    public decimal? Step2EPlusStep1E { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Streamlined [MAX23K.X78]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Streamlined (k)\"}")]
    public bool? Streamlined { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B5 Subtotal Rehab Escrow Acct (B1-B4) [MAX23K.X18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubTotalForEscrowAccount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B13 Subtotal Release at Closing [MAX23K.X28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubTotalForReleaseAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D4 Sum(D2+D3) [MAX23K.X45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SumForInvestor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D4 Sum(D2+D3)x85% or 97/95/90% [MAX23K.X46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SumForOwnerOccupied { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D1 (A1+B14+A5+Prepaids+Disc-B12) [MAX23K.X41]
    /// </summary>
    public decimal? SumOfExistingDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B11 Supplemental Origination Fee [MAX23K.X44]
    /// </summary>
    public decimal? SuplementalOriginationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Title 1 Loan Bal [CAPIAP.X4]
    /// </summary>
    public decimal? Title1LoanBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Title 1 Loan # [CAPIAP.X3]
    /// </summary>
    public string? Title1LoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Property Improve Title 1 Loan with Whom [CAPIAP.X59]
    /// </summary>
    public string? Title1LoanWithWhom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B3 Cost Per Update [MAX23K.X14]
    /// </summary>
    public decimal? TitleUpdateFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Title Update Fees [MAX23K.X114]
    /// </summary>
    public decimal? TitleUpdateFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B3 # Updates [MAX23K.X13]
    /// </summary>
    public int? TitleUpdateFeeTimes { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B1 Total Cost Repairs Incl A6 [MAX23K.X70]
    /// </summary>
    public decimal? TotalCostsOfRepairsInA6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k E3 Total Escrow Commitment [MAX23K.X51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEscrowCommitment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k Total Escrowed Funds [MAX23K.X68]
    /// </summary>
    public decimal? TotalEscrowedFunds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 92900 LT Total Fixed Unpaid Balance [3025]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalFixedUnpaidBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k E4 Borrower Estimated Profits [MAX23K.X52]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorrowerEstimatedProfit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B3 Title Update Fee [MAX23K.X15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForInspectionAndTitleFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k D2 Lesser of Sum(A2+B14)/A4 [MAX23K.X43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForLesserOfSumAsIs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B4 Mtg Pymt Escrowed [MAX23K.X17]
    /// </summary>
    public decimal? TotalForMtgPaymentEscrowed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B9 Plan Reviewer Fees [MAX23K.X24]
    /// </summary>
    public decimal? TotalForPlanReviewerFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k B14 Total Rehabilitation Cost [MAX23K.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForRehabilitationCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k C2 Total Rehabilitation Cost [MAX23K.X61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalRehabilitationCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Total Rehabilitation Costs, Fees and Reserves (Sum of 1A, 1B, 1C) Not to exceed $35,000 [MAX23K.X83]
    /// </summary>
    public decimal? TotalRehabilitationCostsFeesReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Unpaid Principal Balance (First Lien) [MAX23K.X124]
    /// </summary>
    public decimal? UnpaidPrincipalBalanceFirstLien { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Unpaid Principal Balance of any junior liens [MAX23K.X126]
    /// </summary>
    public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - 2.Unpaid Principal Balance Purchase Junior Lien [MAX23K.X125]
    /// </summary>
    public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k E2 Value Established C5 or D5 [MAX23K.X50]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ValueEstablished { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Basic Info - Water Purification Local Health Agent [4250]
    /// </summary>
    public string? WaterPurificationAgent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Basic Info - Water Purification Maintenance Organization [4249]
    /// </summary>
    public string? WaterPurificationOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Basic Info - Water Purification Other Payees [4251]
    /// </summary>
    public string? WaterPurificationPayees { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA 203k - Solar/Wind Energy System Actual Cost [MAX23K.X97]
    /// </summary>
    public decimal? WindEnergySystemActualCost { get => GetValue<decimal?>(); set => SetValue(value); }
}