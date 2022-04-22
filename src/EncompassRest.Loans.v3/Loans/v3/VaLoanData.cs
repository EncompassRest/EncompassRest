using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// VaLoanData
/// </summary>
public sealed partial class VaLoanData : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// VA Loan Disbursement - Date Aquired - If land aquired by separate transaction [VASUMM.X63]
    /// </summary>
    public DateTime? AcquiredLandDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal DescAcres [600]
    /// </summary>
    public decimal? Acres { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Describe additional security taken and list of others (including spouse) [VASUMM.X62]
    /// </summary>
    public string? AdditionalSecurityDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits Street [VAVOB.X3]
    /// </summary>
    public string? AdministratorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits City [VAVOB.X4]
    /// </summary>
    public string? AdministratorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits Attn [VAVOB.X2]
    /// </summary>
    public string? AdministratorContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits Name [VAVOB.X1]
    /// </summary>
    public string? AdministratorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits Zip [VAVOB.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AdministratorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA To Admin of Benefits State [VAVOB.X5]
    /// </summary>
    public string? AdministratorState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Property Age [VASUMM.X8]
    /// </summary>
    public int? AgeOfProperty { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Amount of Proposed Liens [VASUMM.X126]
    /// </summary>
    public decimal? AmountOfProposedLiens { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Energy Improve Amt [961]
    /// </summary>
    public decimal? AmountSpentOnEnergyImprovements { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in [VASUMM.X65]
    /// </summary>
    public StringEnumValue<AmountTypeWithheld> AmountTypeWithheld { get => GetValue<StringEnumValue<AmountTypeWithheld>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in [VASUMM.X66]
    /// </summary>
    public decimal? AmountWithheld { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Annual Ground Rent Amt [1035]
    /// </summary>
    public decimal? AnnualGroundRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Annual Maintenance Assessment [3643]
    /// </summary>
    public decimal? AnnualMaintenanceAssessment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Annual RE Taxes [1031]
    /// </summary>
    public decimal? AnnualRealEstateTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Annual Special Assessment [VASUMM.X59]
    /// </summary>
    public decimal? AnnualSpecialAssessment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantAddressCity [VAELIG.X76], [VAVOB.X45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantAddressPostalCode [VAELIG.X78], [VAVOB.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
    public string? ApplicantAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantAddressState [VAELIG.X77], [VAVOB.X46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantAddressStreetLine1 [VAELIG.X75], [VAVOB.X44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantBirthDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ApplicantBirthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Email Address [VAELIG.X97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantEmailAddressText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantFirstNameWithMiddleName
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantFirstNameWithMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Veteran Sex [VASUMM.X35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantHmdaGenderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Daytime Phone [VAELIG.X74]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? ApplicantHomePhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantLastNameWithSuffix
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantLastNameWithSuffix { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantTaxIdentificationIdentifier
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
    public string? ApplicantTaxIdentificationIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData ApplicantWorkPhoneNumber
    /// </summary>
    public string? ApplicantWorkPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Appraisal Type [962]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalType { get => GetValue<StringEnumValue<AppraisalPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Date of Assignment [415]
    /// </summary>
    public DateTime? AssignmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Automatic Procedure [VASUMM.X51]
    /// </summary>
    public bool? AutomaticProcedure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Time Avail AM [686]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? AvailableForInspectionAmIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Date/Time Avail for Inspec [681]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? AvailableForInspectionDateAndTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Disc Points Paid by Veteran Amt [VASUMM.X46]
    /// </summary>
    public decimal? BorrowerPaidDiscountPointsTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Building Type [602]
    /// </summary>
    public StringEnumValue<BuildingType> BuildingType { get => GetValue<StringEnumValue<BuildingType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Buyer Purch Lot Separately [1344]
    /// </summary>
    public bool? BuyerPurchasingLotSeparately { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Amount of Cash Directly Disbursed to Borrower(s) [VASUMM.X114]
    /// </summary>
    public decimal? CashDisbursedToBorrowerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Subtract Any Cash Payment from Veteran [VARRRWS.X1]
    /// </summary>
    public decimal? CashPaymentFromVeteran { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - CD Non Shoppable Less Funding Fee [VASUMM.X137]
    /// </summary>
    public decimal? CdNonShoppableLessFundingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Certifcation Filed Claim Prior to Discharge [VAVOB.X71]
    /// </summary>
    public StringEnumValue<ClaimDisabilityBenefits> ClaimDisabilityBenefits { get => GetValue<StringEnumValue<ClaimDisabilityBenefits>>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Clothes Washer [302]
    /// </summary>
    public bool? ClothesWasherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Constr Completed [726]
    /// </summary>
    public DateTime? ConstructionCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Plan [1021]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<ConstructionPlan> ConstructionPlan { get => GetValue<StringEnumValue<ConstructionPlan>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Constr Warranty Incl [722]
    /// </summary>
    public bool? ConstructionWarrantyIncluded { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Contract # Approved By VA [1037]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ContractNoApprovedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Credit Score [VASUMM.X23]
    /// </summary>
    public int? CreditScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Currently on Military Duty [VAVOB.X68]
    /// </summary>
    public bool? CurrentlyOnMilitaryDuty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Disability Amount Collected [VASUMM.X68]
    /// </summary>
    public decimal? DisabilityAmountCollected { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Amount of Disbursements less Mortgage Payoffs [VASUMM.X115]
    /// </summary>
    public decimal? DisbursementsLessPayoffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Discount Fee % [VARRRWS.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Disc Points Paid by Veteran % [VASUMM.X48]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Dishwasher [301]
    /// </summary>
    public bool? DishwasherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Dryer [308]
    /// </summary>
    public bool? DryerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded) [3347]
    /// </summary>
    public string? EmailToBeNotifiedWhenUploaded { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Energy Improvements Addition of Feature [379]
    /// </summary>
    public bool? EnergyImprovementsAdditionOfFeature { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Entitlement Code [VASUMM.X2]
    /// </summary>
    public string? EntitlementCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Other [320]
    /// </summary>
    public string? EquipmentOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Home Equity Remaining Amount [VASUMM.X113]
    /// </summary>
    public decimal? EstimatedImpactofHomeEquityRemainingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Interest Rate [VASUMM.X105]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? EstimatedImpactofInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Loan Balance Amount [VASUMM.X103]
    /// </summary>
    public decimal? EstimatedImpactofLoanBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Loan-to-Value Percentage [VASUMM.X109]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? EstimatedImpactofLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Remaining Term Months [VASUMM.X104]
    /// </summary>
    public int? EstimatedImpactofRemainingTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Total Remaining Scheduled Payments [VASUMM.X108]
    /// </summary>
    public decimal? EstimatedImpactofTotalRemainingPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Exclude Taxes and Insurance [VASUMM.X100]
    /// </summary>
    public bool? ExcludeTaxesInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Home Equity Remaining Amount [VASUMM.X111]
    /// </summary>
    public decimal? ExistingHomeEquityRemainingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Loan Balance [VASUMM.X102]
    /// </summary>
    public decimal? ExistingLoanBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Loan First Payment Date [VASUMM.X123]
    /// </summary>
    public DateTime? ExistingLoanFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Reasonable (Appraised) Value [VASUMM.X110]
    /// </summary>
    public decimal? ExistingReasonableAppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Total of the Remaining Scheduled Payments [VASUMM.X106]
    /// </summary>
    public decimal? ExistingTotalRemainingPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing VA Loan Number [VASUMM.X101]
    /// </summary>
    public string? ExistingVaLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Discount (Based from line 9) [VARRRWS.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FinalDiscountAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Funding Fee (Round to Nearest Dollar) [VARRRWS.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FinalFundingFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final Recoupment Form Provided Date [VASUMM.X136]
    /// </summary>
    public DateTime? FinalRecoupmentFormProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - First Chattel  [VASUMM.X53]
    /// </summary>
    public bool? FirstChattelLoanType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ 1st Time Use VA Loan Program [VASUMM.X49]
    /// </summary>
    public bool? FirstTimeUse { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Discount Info [990]
    /// </summary>
    public bool? FundingFeeExempt { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Garbage Disposal [309]
    /// </summary>
    public bool? GarbageDisposalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Lender Credit In Recoupment Test [VASUMM.X148]
    /// </summary>
    public bool? IncludeLenderCreditIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section A In Recoupment Test [VASUMM.X140]
    /// </summary>
    public bool? IncludeSectionAIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section B Other In Recoupment Test [VASUMM.X142]
    /// </summary>
    public bool? IncludeSectionBOtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section B VA Funding Fee In Recoupment Test [VASUMM.X141]
    /// </summary>
    public bool? IncludeSectionBVaFundingFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section C In Recoupment Test [VASUMM.X143]
    /// </summary>
    public bool? IncludeSectionCIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section E In Recoupment Test [VASUMM.X144]
    /// </summary>
    public bool? IncludeSectionEIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section F In Recoupment Test [VASUMM.X145]
    /// </summary>
    public bool? IncludeSectionFIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section G In Recoupment Test [VASUMM.X146]
    /// </summary>
    public bool? IncludeSectionGIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Include Section H In Recoupment Test [VASUMM.X147]
    /// </summary>
    public bool? IncludeSectionHIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Recoupment Form Provided Date [VASUMM.X135]
    /// </summary>
    public DateTime? InitialRecoupmentFormProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Initial Computation Total [VARRRWS.X2]
    /// </summary>
    public decimal? InitialTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Inspec By [1020]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<InspectionWillBeMadeBy> InspectionWillBeMadeBy { get => GetValue<StringEnumValue<InspectionWillBeMadeBy>>(); set => SetValue(value); }

    /// <summary>
    /// VA Energy Improvements Insulation [380]
    /// </summary>
    public bool? Insulation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Type [3642]
    /// </summary>
    public StringEnumValue<InsuranceType> InsuranceType { get => GetValue<StringEnumValue<InsuranceType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Irreg Sq Ft [1043]
    /// </summary>
    public int? IrregularLotSizeInSquareFeet { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData IsDelinquent30Days
    /// </summary>
    public bool? IsDelinquent30Days { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Keys At [683]
    /// </summary>
    public string? KeysAtAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Land Purchase Price [VASUMM.X64]
    /// </summary>
    public decimal? LandPurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Lease Is [1033]
    /// </summary>
    public StringEnumValue<LeaseholdType> LeaseholdType { get => GetValue<StringEnumValue<LeaseholdType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Lender SAR ID [VASUMM.X6]
    /// </summary>
    public string? LenderSar { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Opening Recoupment Months [VASUMM.X139]
    /// </summary>
    public int? LeRecoupmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Total Opening Closing Costs [VASUMM.X138]
    /// </summary>
    public decimal? LeTotalClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 1 [VALA.X10]
    /// </summary>
    public string? LoanAnalysisRemarks1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 2 [VALA.X11]
    /// </summary>
    public string? LoanAnalysisRemarks2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 3 [VALA.X12]
    /// </summary>
    public string? LoanAnalysisRemarks3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 4 [VALA.X13]
    /// </summary>
    public string? LoanAnalysisRemarks4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 5 [VALA.X14]
    /// </summary>
    public string? LoanAnalysisRemarks5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 6 [VALA.X15]
    /// </summary>
    public string? LoanAnalysisRemarks6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 7 [VALA.X16]
    /// </summary>
    public string? LoanAnalysisRemarks7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 8 [VALA.X17]
    /// </summary>
    public string? LoanAnalysisRemarks8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Remarks 9 [VALA.X18]
    /// </summary>
    public string? LoanAnalysisRemarks9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Loan Code [958]
    /// </summary>
    public StringEnumValue<LoanCode> LoanCode { get => GetValue<StringEnumValue<LoanCode>>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Loan Procedure [953]
    /// </summary>
    public StringEnumValue<LoanProcedure> LoanProcedure { get => GetValue<StringEnumValue<LoanProcedure>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ VA Recognized Auto Underwriting Sys [VASUMM.X4]
    /// </summary>
    public bool? LoanProcessedUnderAu { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 1 [VASUMM.X37]
    /// </summary>
    public string? LoanSummaryRemarks1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 2 [VASUMM.X38]
    /// </summary>
    public string? LoanSummaryRemarks2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 3 [VASUMM.X39]
    /// </summary>
    public string? LoanSummaryRemarks3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 4 [VASUMM.X40]
    /// </summary>
    public string? LoanSummaryRemarks4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 5 [VASUMM.X41]
    /// </summary>
    public string? LoanSummaryRemarks5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 6 [VASUMM.X42]
    /// </summary>
    public string? LoanSummaryRemarks6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 7 [VASUMM.X43]
    /// </summary>
    public string? LoanSummaryRemarks7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Remarks 8 [VASUMM.X44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanSummaryRemarks8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Lot Dimensions [1042]
    /// </summary>
    public string? LotDimensions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Mailing Addr Street [VAELIG.X51]
    /// </summary>
    public string? MailingAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Mailing Addr City [VAELIG.X54]
    /// </summary>
    public string? MailingCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Mailing Addr Zip [VAELIG.X56]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MailingPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Mailing Addr State [VAELIG.X55]
    /// </summary>
    public string? MailingState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Manufactured Home [963]
    /// </summary>
    public StringEnumValue<ManufacturedHome> ManufacturedHome { get => GetValue<StringEnumValue<ManufacturedHome>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Energy Improve MCRV # [989]
    /// </summary>
    public string? McrvNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Branch of Service [954]
    /// </summary>
    public StringEnumValue<MilitaryBranchOfService> MilitaryBranchOfService { get => GetValue<StringEnumValue<MilitaryBranchOfService>>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData MilitaryServices
    /// </summary>
    [AllowNull]
    public IList<MilitaryService> MilitaryServices { get => GetList<MilitaryService>(); set => SetList(value); }

    /// <summary>
    /// VA Mineral Rights Reserved [1032]
    /// </summary>
    public string? MineralRightsReserved { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Occupant Name [730]
    /// </summary>
    public string? NameOfOccupant { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Owner Name [727]
    /// </summary>
    public string? NameOfOwner { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Warranty Program Name [724]
    /// </summary>
    public string? NameOfWarrantyProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Negative Rents [VALA.X30]
    /// </summary>
    public decimal? NegativeRents { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Energy Improvements None [376]
    /// </summary>
    public bool? NoEnergyImprovements { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan [VASUMM.X61]
    /// </summary>
    public string? NonRealtyDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property # Buildings [604]
    /// </summary>
    public string? NumberOfBuildings { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Occupant Phone [731]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? OccupantTelephone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA On Military Duty Day Following Separation [VAVOB.X69]
    /// </summary>
    public bool? OnMilitaryDutyFollowingSeparation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Orig Int Rate [VASUMM.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginalInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Orig Loan Amt [VASUMM.X15]
    /// </summary>
    public decimal? OriginalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Orig Term [VASUMM.X18]
    /// </summary>
    public int? OriginalTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Y/N Appraisers Orig Value Est Changed [VASUMM.X13]
    /// </summary>
    public bool? OriginalValueEstimateChanged { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Origination Fee [VARRRWS.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OriginationFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Add Other Allowable Closing Costs/Prepaids [VARRRWS.X6]
    /// </summary>
    public decimal? OtherClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Estate in Property - Other Description [VASUMM.X58]
    /// </summary>
    public string? OtherDescriptionEstateProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Other Description [VASUMM.X56]
    /// </summary>
    public string? OtherDescriptionLoanType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Estate in Property - Other [VASUMM.X57]
    /// </summary>
    public bool? OtherEstateProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Other Improvements [381]
    /// </summary>
    public bool? OtherImprovements { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Other [VASUMM.X55]
    /// </summary>
    public bool? OtherLoanType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Paid In Full Loan # [VASUMM.X14]
    /// </summary>
    public string? PaidInFullVaLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 1 Incl on Line 41 [VALA.X20]
    /// </summary>
    public bool? PayoffIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 2 Incl on Line 41 [VALA.X21]
    /// </summary>
    public bool? PayoffIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 3 Incl on Line 41 [VALA.X22]
    /// </summary>
    public bool? PayoffIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 4 Incl on Line 41 [VALA.X23]
    /// </summary>
    public bool? PayoffIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 5 Incl on Line 41 [VALA.X24]
    /// </summary>
    public bool? PayoffIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 6 Incl on Line 41 [VALA.X25]
    /// </summary>
    public bool? PayoffIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Liability 7 Incl on Line 41 [VALA.X26]
    /// </summary>
    public bool? PayoffIndicator7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Alimony/Child Supp Incl on Line 41 [VALA.X27]
    /// </summary>
    public bool? PayoffIndicator8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Other Liabilities Incl on Line 41 [VALA.X28]
    /// </summary>
    public bool? PayoffIndicator9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Pest Report Fee [VASUMM.X69]
    /// </summary>
    public decimal? PestReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Plan Prev Case # [1022]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PlansSubmitted { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Address [3350]
    /// </summary>
    public string? PocAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information City [3351]
    /// </summary>
    public string? PocCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Name [3349]
    /// </summary>
    public string? PocName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Phone [3354]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PocPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information State [3352]
    /// </summary>
    public string? PocState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Zipcode [3353]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PocZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Discount Amt [VARRRWS.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryDiscountAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Funding Fee [VARRRWS.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryFundingFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Preliminary Loan Amt Total [VARRRWS.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Military Previous VA Loan Not Applicable (NA) [VAELIG.X113]
    /// </summary>
    public bool? PreviousVaLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData PreviousVaLoans
    /// </summary>
    [AllowNull]
    public IList<PreviousVaLoan> PreviousVaLoans { get => GetList<PreviousVaLoan>(); set => SetList(value); }

    /// <summary>
    /// VA Loan Disbursement - Prior Approval Procedure [VASUMM.X52]
    /// </summary>
    public bool? PriorApprovalProcedure { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Prior Loan Type [VASUMM.X50]
    /// </summary>
    public StringEnumValue<PriorLoanType> PriorLoanType { get => GetValue<StringEnumValue<PriorLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Energy Improve Property Desig [988]
    /// </summary>
    public StringEnumValue<PropertyDesignation> PropertyDesignation { get => GetValue<StringEnumValue<PropertyDesignation>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Property Gross Living Area [VASUMM.X7]
    /// </summary>
    public int? PropertyGrossLivingArea { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr 1 [765]
    /// </summary>
    public string? PropertyLegalDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr 2 [766]
    /// </summary>
    public string? PropertyLegalDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr 3 [797]
    /// </summary>
    public string? PropertyLegalDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr 4 [798]
    /// </summary>
    public string? PropertyLegalDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Type [728]
    /// </summary>
    public StringEnumValue<PropertyOccupancyType> PropertyOccupancyType { get => GetValue<StringEnumValue<PropertyOccupancyType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Proposed Home Equity Remaining Amount [VASUMM.X112]
    /// </summary>
    public decimal? ProposedHomeEquityRemainingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Proposed Sale Contract Attached [1036]
    /// </summary>
    public bool? ProposedSaleContractAttached { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Proposed Total of the Remaining Scheduled Payments [VASUMM.X107]
    /// </summary>
    public decimal? ProposedTotalRemainingPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Military Purple Heart Recipient Indicator [VAELIG.X114]
    /// </summary>
    public bool? PurpleHeartRecipientIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Loan Purpose [956]
    /// </summary>
    public StringEnumValue<VaLoanDataPurposeOfLoan> PurposeOfLoan { get => GetValue<StringEnumValue<VaLoanDataPurposeOfLoan>>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Range Oven [204]
    /// </summary>
    public bool? RangeOvenIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value [VASUMM.X67]
    /// </summary>
    public bool? ReasonableValueCompleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Loan Info Refi Existing Lien [VASUMM.X149]
    /// </summary>
    public decimal? RefinancePropertyExistingLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Refrigerator [209]
    /// </summary>
    public bool? RefrigeratorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Rent [729]
    /// </summary>
    public string? Rent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Energy Improvements Replacement of System [378]
    /// </summary>
    public bool? ReplacementOfSystem { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Risk Classification [VASUMM.X21]
    /// </summary>
    public StringEnumValue<RiskClassification> RiskClassification { get => GetValue<StringEnumValue<RiskClassification>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Date SAR Issued Value [VASUMM.X9]
    /// </summary>
    public DateTime? SarDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Svc # [VAVOB.X67]
    /// </summary>
    public string? ServiceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Survey to Seller [377]
    /// </summary>
    public bool? SolarHeatingOrCooling { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 1 [1028]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 2 [1029]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 3 [1030]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Street Access [720]
    /// </summary>
    public StringEnumValue<PublicOrPrivate> StreetAccess { get => GetValue<StringEnumValue<PublicOrPrivate>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Street Maint [721]
    /// </summary>
    public StringEnumValue<PublicOrPrivate> StreetMaintenance { get => GetValue<StringEnumValue<PublicOrPrivate>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Underwriting System Used [VASUMM.X17]
    /// </summary>
    public StringEnumValue<SystemUsed> SystemUsed { get => GetValue<StringEnumValue<SystemUsed>>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Title [GAPPR.X5]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Title Limitations 1 [926]
    /// </summary>
    public string? TitleLimitations1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Title Limitations 2 [927]
    /// </summary>
    public string? TitleLimitations2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Title Limitations 3 [928]
    /// </summary>
    public string? TitleLimitations3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Baths [VASUMM.X11]
    /// </summary>
    public decimal? TotalBaths { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Bedrooms [VASUMM.X12]
    /// </summary>
    public int? TotalBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Total CLosing Cost Less Guarantee Fee [VASUMM.X124]
    /// </summary>
    public decimal? TotalClosingCostLessGuaranteeFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Analysis Total Debt Mo Pymt [VALA.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDebtMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Total Disc Points Chrgd Amt [VASUMM.X45]
    /// </summary>
    public decimal? TotalDiscountPointCharged { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Total Disc Points Chrgd % [VASUMM.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalDiscountPointsCharged { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Total - Max Loan Amt [VARRRWS.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForMaxLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Total Monthly Payment [VASUMM.X98]
    /// </summary>
    public decimal? TotalMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Increase in Total Paid Over Life of Loan [VASUMM.X122]
    /// </summary>
    public decimal? TotalPaidOverLifeIncreasedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Total Proposed Monthly Payment [VASUMM.X99]
    /// </summary>
    public decimal? TotalProposedMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Total Rooms [VASUMM.X10]
    /// </summary>
    public int? TotalRooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Total Unpaid Special Assessments [VASUMM.X60]
    /// </summary>
    public decimal? TotalUnpaidSpecialAssessments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ HYBRID-ARM Type [VASUMM.X24]
    /// </summary>
    public StringEnumValue<TypeOfHybridARM> TypeOfHybridArm { get => GetValue<StringEnumValue<TypeOfHybridARM>>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Mtg Type [959]
    /// </summary>
    public StringEnumValue<TypeOfMortgage> TypeOfMortgage { get => GetValue<StringEnumValue<TypeOfMortgage>>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Ownership Type [957]
    /// </summary>
    public StringEnumValue<TypeOfOwnsership> TypeOfOwnership { get => GetValue<StringEnumValue<TypeOfOwnsership>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Energy Improve Structure Type [986]
    /// </summary>
    public StringEnumValue<TypeOfStructure> TypeOfStructure { get => GetValue<StringEnumValue<TypeOfStructure>>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Type [VAVOB.X72]
    /// </summary>
    public StringEnumValue<TypeOfVeteran> TypeOfVeteran { get => GetValue<StringEnumValue<TypeOfVeteran>>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Unsecured  [VASUMM.X54]
    /// </summary>
    public bool? UnsecuredLoanType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Elec [1096]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesElectricDescription { get => GetValue<StringEnumValue<UtilitiesDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Gas [1097]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesGasDescription { get => GetValue<StringEnumValue<UtilitiesDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Sewer [1099]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesSewerDescription { get => GetValue<StringEnumValue<UtilitiesDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Water [1098]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesWaterDescription { get => GetValue<StringEnumValue<UtilitiesDescription>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Appraisal Sent Date [VASUMM.X73]
    /// </summary>
    public DateTime? VaAppraisalSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Do/Do Not Have VA Benefit-Related Indebtedness [VAVOB.X70]
    /// </summary>
    public StringEnumValue<VABenefitRelatedIndebtedness> VaBenefitRelatedIndebtedness { get => GetValue<StringEnumValue<VABenefitRelatedIndebtedness>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Builder Description [3851]
    /// </summary>
    public string? VaBuilderDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA 261805 Builder ID Number [3348]
    /// </summary>
    public string? VaBuilderIdNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Cash-Out Refinance Type [VASUMM.X125]
    /// </summary>
    public StringEnumValue<VACashOutRefinanceType> VaCashOutRefinanceType { get => GetValue<StringEnumValue<VACashOutRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Claim Folder # [VAVOB.X66]
    /// </summary>
    public string? VaClaimFolderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Claim # [VAELIG.X23]
    /// </summary>
    public string? VaClaimNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Date NOV and Appraisal Mailed to Borrower [VASUMM.X77]
    /// </summary>
    public DateTime? VaDateNovAppraisalMailedToBorrower { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA EEM Included in Base Loan Amount Indicator [VASUMM.X133]
    /// </summary>
    public bool? VaEemIncludedinBaseLoanAmountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Energy Efficient Improvements Financed Amount [VASUMM.X132]
    /// </summary>
    public decimal? VaEnergyEfficientImprovementsFinancedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Financed Closing Costs to Exclude [VASUMM.X134]
    /// </summary>
    public decimal? VaFinancedClosingCostsToExcludeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Interest Rate Indicator [VASUMM.X118]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactInterestRateIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Loan Balance Indicator [VASUMM.X116]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactLoanBalanceIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact LTV Indicator [VASUMM.X120]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactLtvIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Remaining Equity Indicator [VASUMM.X121]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactRemainingEquityIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Remaining Term Indicator [VASUMM.X117]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactRemainingTermIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Scheduled Payments Indicator [VASUMM.X119]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactScheduledPaymentsIndicator { get => GetValue<StringEnumValue<IncreaseOrDecrease>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan? [VASUMM.X36]
    /// </summary>
    public bool? VaIsDelinquent30Days { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months? [VASUMM.X30]
    /// </summary>
    public bool? VaLatePaymentIn6Months { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VaLoanData VaLoanSummaryApplicantType
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> VaLoanSummaryApplicantType { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - NOV Date Received [VASUMM.X74]
    /// </summary>
    public DateTime? VaNovDateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - NOV Date Reviewed [VASUMM.X75]
    /// </summary>
    public DateTime? VaNovDateReviewed { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - NOV Issued Date [VASUMM.X76]
    /// </summary>
    public DateTime? VaNovIssuedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Original Amortization Type [VASUMM.X20]
    /// </summary>
    public StringEnumValue<AmortizationType> VaOriginalAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Original Monthly Payment [VASUMM.X19]
    /// </summary>
    public decimal? VaOriginalMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - 2nd Tier Entitlement [VASUMM.X96]
    /// </summary>
    public string? VaQualification2ndTierEntitlement { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Country Region [VASUMM.X95]
    /// </summary>
    public StringEnumValue<VAQualificationCountryRegion> VaQualificationCountryRegion { get => GetValue<StringEnumValue<VAQualificationCountryRegion>>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - VA County Limits [VASUMM.X97]
    /// </summary>
    public decimal? VaQualificationCountyLimits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Rate Reduced Solely by Discount Points Indicator [VASUMM.X131]
    /// </summary>
    public bool? VaRateReducedSolelybyDiscountPointsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Recoup Closing Costs [VASUMM.X27]
    /// </summary>
    public int? VaRecoupmentClosingCosts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids [VASUMM.X26]
    /// </summary>
    public bool? VaRecoupmentExcludePrepaids { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment [VASUMM.X22]
    /// </summary>
    public decimal? VaRecoupmentMonthlyDecreaseInPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Months [VASUMM.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? VaRecoupmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs [VASUMM.X25]
    /// </summary>
    public decimal? VaRecoupmentTotalClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Years [VASUMM.X28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? VaRecoupmentYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Statutory Closing Costs [VASUMM.X127]
    /// </summary>
    public decimal? VaStatutoryClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Statutory P&amp;I Payment [VASUMM.X128]
    /// </summary>
    public decimal? VaStatutoryMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Statutory P&amp;I Reduction [VASUMM.X129]
    /// </summary>
    public decimal? VaStatutoryMonthlyReduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Statutory Recoupment Months [VASUMM.X130]
    /// </summary>
    public int? VaStatutoryRecoupmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Cert. of Commitment Issued by VA [VASUMM.X86]
    /// </summary>
    public DateTime? VaTrackingCertOfCommitmentIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - COE Issue Date [VASUMM.X80]
    /// </summary>
    public DateTime? VaTrackingCoeIssueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - COE Issue History [VASUMM.X81]
    /// </summary>
    public string? VaTrackingCoeIssueHistory { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Final Approval Commitment Date [VASUMM.X88]
    /// </summary>
    public DateTime? VaTrackingFinalApprovalCommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - GSA Exclusionary List Checked [VASUMM.X85]
    /// </summary>
    public bool? VaTrackingGsaExclusionaryListChecked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Flood Policy [VASUMM.X91]
    /// </summary>
    public bool? VaTrackingInsuranceFloodPolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Hazard Policy [VASUMM.X92]
    /// </summary>
    public bool? VaTrackingInsuranceHazardPolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Wind/Hail Policy [VASUMM.X94]
    /// </summary>
    public bool? VaTrackingInsuranceWindOrHailPolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Wood Destroying Policy [VASUMM.X93]
    /// </summary>
    public bool? VaTrackingInsuranceWoodDestroyingPolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Is SAR LAPP Certified [VASUMM.X72]
    /// </summary>
    public bool? VaTrackingIsSarLappCertified { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Loan Guarantee Cert. (LGC) Receipt [VASUMM.X84]
    /// </summary>
    public DateTime? VaTrackingLoanGuaranteeCertReceipt { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - VA Master Commitment Lock Expired [VASUMM.X87]
    /// </summary>
    public DateTime? VaTrackingMasterCommitmentLockExpired { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Ordered Date [VASUMM.X79]
    /// </summary>
    public DateTime? VaTrackingOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Paid Date [VASUMM.X82]
    /// </summary>
    public DateTime? VaTrackingPaidDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Purchase Contract Date [VASUMM.X89]
    /// </summary>
    public DateTime? VaTrackingPurchaseContractDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - Receipt Received [VASUMM.X83]
    /// </summary>
    public bool? VaTrackingReceiptReceived { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - SAR ID [VASUMM.X71]
    /// </summary>
    public string? VaTrackingSarId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Management Tool - SAR Name [VASUMM.X70]
    /// </summary>
    public string? VaTrackingSarName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment Vent Fan [316]
    /// </summary>
    public bool? VentFanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Discharged/Have Svc-Connected Disabilities [VAELIG.X22]
    /// </summary>
    public bool? VeteranDischargedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Veteran Service Status [955]
    /// </summary>
    public StringEnumValue<VeteranServiceType> VeteranServiceType { get => GetValue<StringEnumValue<VeteranServiceType>>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Addr [1026]
    /// </summary>
    public string? WarrantorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor City [GAPPR.X11]
    /// </summary>
    public string? WarrantorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Name [1025]
    /// </summary>
    public string? WarrantorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Phone [1027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? WarrantorPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Zip [GAPPR.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? WarrantorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor State [GAPPR.X12]
    /// </summary>
    public string? WarrantorState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Warranty Program Expiration Date [725]
    /// </summary>
    public DateTime? WarrantyProgramExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Equipment W/W Carpet [318]
    /// </summary>
    public bool? WwCarpetIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}