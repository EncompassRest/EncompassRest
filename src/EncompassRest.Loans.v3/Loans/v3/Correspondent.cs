using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Correspondent
/// </summary>
public sealed partial class Correspondent : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Correspondent ABA Number [CORRESPONDENT.X74]
    /// </summary>
    public string? AbaNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Account Number [CORRESPONDENT.X75]
    /// </summary>
    public string? AccountNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Account Number 2 [CORRESPONDENT.X76]
    /// </summary>
    public string? AccountNumber2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Activated By [CORRESPONDENT.X495]
    /// </summary>
    public string? ActivatedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Activated Date [CORRESPONDENT.X494]
    /// </summary>
    public DateTime? ActivatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Flood Coverage [CORRESPONDENT.X78]
    /// </summary>
    public decimal? AdditionalFloodCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Hazard Coverage [CORRESPONDENT.X79]
    /// </summary>
    public decimal? AdditionalHazardCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Company Name [CORRESPONDENT.X222]
    /// </summary>
    public string? AdditionalInsuranceCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Additional Coverage [CORRESPONDENT.X77]
    /// </summary>
    public decimal? AdditionalInsuranceCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Coverage Amount [CORRESPONDENT.X149]
    /// </summary>
    public decimal? AdditionalInsuranceCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X152]
    /// </summary>
    public int? AdditionalInsuranceCoverageTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Deductible [CORRESPONDENT.X160]
    /// </summary>
    public decimal? AdditionalInsuranceDeductible { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Estimator [CORRESPONDENT.X225]
    /// </summary>
    public string? AdditionalInsuranceEstimator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Exclude from PITI Payment [CORRESPONDENT.X176]
    /// </summary>
    public bool? AdditionalInsuranceExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Guaranteed Replacement Cost [CORRESPONDENT.X203]
    /// </summary>
    public bool? AdditionalInsuranceGuaranteedReplacementCost { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Monthly Amount [CORRESPONDENT.X363]
    /// </summary>
    public decimal? AdditionalInsuranceMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Payment Type [CORRESPONDENT.X461]
    /// </summary>
    public string? AdditionalInsurancePaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Policy Effective Date [CORRESPONDENT.X277]
    /// </summary>
    public DateTime? AdditionalInsurancePolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Policy Expiration Date [CORRESPONDENT.X282]
    /// </summary>
    public DateTime? AdditionalInsurancePolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Panel Number [CORRESPONDENT.X285]
    /// </summary>
    public string? AdditionalInsurancePolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Policy Premium [CORRESPONDENT.X288]
    /// </summary>
    public decimal? AdditionalInsurancePolicyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Policy Type [CORRESPONDENT.X290]
    /// </summary>
    public string? AdditionalInsurancePolicyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Premium Due Date [CORRESPONDENT.X295]
    /// </summary>
    public DateTime? AdditionalInsurancePremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance Estimator [CORRESPONDENT.X229]
    /// </summary>
    public string? AdditionalInsuranceType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee - Additional Charge [3932]
    /// </summary>
    public decimal? AdditionalLateFeeCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Wind Coverage [CORRESPONDENT.X80]
    /// </summary>
    public decimal? AdditionalWindCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent After-Improved LTV Value [CORRESPONDENT.X400]
    /// </summary>
    public decimal? AfterImprovedLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Aggregate Adjustment [CORRESPONDENT.X82]
    /// </summary>
    public decimal? AggregateAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Alternate Loan Number [4548]
    /// </summary>
    public string? AlternateLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent REGZ Total Amt Financed [CORRESPONDENT.X25]
    /// </summary>
    public decimal? AmountFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Annual Mip Rate [CORRESPONDENT.X84]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? AnnualMipRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Address County [CORRESPONDENT.X86]
    /// </summary>
    public string? AppraisalAddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Appt Date [CORRESPONDENT.X87]
    /// </summary>
    public DateTime? AppraisalApptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Checkbox [CORRESPONDENT.X438]
    /// </summary>
    public bool? AppraisalCheckbox { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal County Name [CORRESPONDENT.X88]
    /// </summary>
    public string? AppraisalCountyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Fee [CORRESPONDENT.X89]
    /// </summary>
    public decimal? AppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Date [CORRESPONDENT.X90]
    /// </summary>
    public DateTime? AppraisalFinalInspectionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Final Inspection Flag [CORRESPONDENT.X91]
    /// </summary>
    public bool? AppraisalFinalInspectionFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Zone [CORRESPONDENT.X92]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"None\"]")]
    public StringEnumValue<FloodZone> AppraisalFloodZone { get => GetValue<StringEnumValue<FloodZone>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 1 [CORRESPONDENT.X234]
    /// </summary>
    public string? AppraisalLegalDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Legal Description 2 [CORRESPONDENT.X235]
    /// </summary>
    public string? AppraisalLegalDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [CORRESPONDENT.X93]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalPropertyType { get => GetValue<StringEnumValue<AppraisalPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Usage [CORRESPONDENT.X351]
    /// </summary>
    public string? AppraisalUsage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisal Waiver [CORRESPONDENT.X94]
    /// </summary>
    public bool? AppraisalWaiver { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Condition [CORRESPONDENT.X95]
    /// </summary>
    public string? AppraisedCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraised Value [CORRESPONDENT.X96]
    /// </summary>
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Name [CORRESPONDENT.X97]
    /// </summary>
    public string? AppraiserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers License Number [CORRESPONDENT.X99]
    /// </summary>
    public string? AppraisersLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 1 [CORRESPONDENT.X101]
    /// </summary>
    public string? AppraisersPropertyAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers Property Address 2 [CORRESPONDENT.X102]
    /// </summary>
    public string? AppraisersPropertyAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraisers State License Number [CORRESPONDENT.X100]
    /// </summary>
    public string? AppraisersStateLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Appraiser Supervisors Name [CORRESPONDENT.X98]
    /// </summary>
    public string? AppraiserSupervisorsName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Cleared for Purchase Date [3921]
    /// </summary>
    public DateTime? ApprovedToFundDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent APR Percent [CORRESPONDENT.X103]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Index [CORRESPONDENT.X104]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmIndex { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Indicator [CORRESPONDENT.X449]
    /// </summary>
    public bool? ArmIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Margin [CORRESPONDENT.X105]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmMargin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Margin 2 [CORRESPONDENT.X106]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmMargin2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Floor Rate [CORRESPONDENT.X107]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmRateFloor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ARM Floor Rate 2 [CORRESPONDENT.X108]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmRateFloor2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Assignment Type [CORRESPONDENT.X476]
    /// </summary>
    public StringEnumValue<AssignmentType> AssignmentType { get => GetValue<StringEnumValue<AssignmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Appraised Value [CORRESPONDENT.X109]
    /// </summary>
    public int? AusAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Assets To Be Verified [CORRESPONDENT.X110]
    /// </summary>
    public decimal? AusAssetsToBeVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - AUS Results from Lender for CLTV [CORRESPONDENT.X469]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AusCltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Credit Report Cert Number [CORRESPONDENT.X111]
    /// </summary>
    public string? AusCreditReportCertNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Credit Report Date  [CORRESPONDENT.X112]
    /// </summary>
    public DateTime? AusCreditReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Aus Free Form Comments  [CORRESPONDENT.X114]
    /// </summary>
    public string? AusFreeFormComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - AUS Results from Lender for HCLTV [CORRESPONDENT.X470]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AusHcltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Interest Rate [CORRESPONDENT.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AusInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Total Loan Amount [CORRESPONDENT.X116]
    /// </summary>
    public decimal? AusLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - AUS Results from Lender for Loan Number [CORRESPONDENT.X471]
    /// </summary>
    public string? AusLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - AUS Results from Lender for LTV [CORRESPONDENT.X468]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AusLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking - Housing Expense Ratio [CORRESPONDENT.X117]
    /// </summary>
    public decimal? AusPrimaryHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking Property Address 1 [CORRESPONDENT.X118]
    /// </summary>
    public string? AusPropertyAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking Property Address 2 [CORRESPONDENT.X119]
    /// </summary>
    public string? AusPropertyAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking Property City [CORRESPONDENT.X120]
    /// </summary>
    public string? AusPropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking Property State [CORRESPONDENT.X121]
    /// </summary>
    public string? AusPropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Tracking Property Zipcode [CORRESPONDENT.X122]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AusPropertyZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Purchase Price [CORRESPONDENT.X123]
    /// </summary>
    public decimal? AusPurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Reference Number [CORRESPONDENT.X124]
    /// </summary>
    public string? AusReferenceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - AUS Results from Lender for Submission Number [CORRESPONDENT.X467]
    /// </summary>
    public string? AusSubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Total Assets [CORRESPONDENT.X125]
    /// </summary>
    public decimal? AusTotalAvailableAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Total DTI [CORRESPONDENT.X126]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AusTotalDti { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Total Monthly Debt [CORRESPONDENT.X127]
    /// </summary>
    public decimal? AusTotalMonthlyDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AUS Total Monthly Income [CORRESPONDENT.X128]
    /// </summary>
    public decimal? AusTotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Auto Publish Conditions [CORRESPONDENT.X55]
    /// </summary>
    public bool? AutoPublishConditions { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Average Prime Offer Rate [CORRESPONDENT.X85]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AveragePrimeOfferRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Appraised Value [CORRESPONDENT.X129]
    /// </summary>
    public decimal? AvmAppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Checkbox [CORRESPONDENT.X437]
    /// </summary>
    public bool? AvmCheckbox { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Confidence Score [CORRESPONDENT.X130]
    /// </summary>
    public string? AvmConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Date [CORRESPONDENT.X132]
    /// </summary>
    public DateTime? AvmOrderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Order Number [CORRESPONDENT.X131]
    /// </summary>
    public string? AvmOrderNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent AVM Type [CORRESPONDENT.X133]
    /// </summary>
    public string? AvmType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Bank Address [CORRESPONDENT.X134]
    /// </summary>
    public string? BankAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Address 2 [CORRESPONDENT.X135]
    /// </summary>
    public string? BankAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Bank AddressCity [CORRESPONDENT.X136]
    /// </summary>
    public string? BankAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Bank Address State [CORRESPONDENT.X137]
    /// </summary>
    public string? BankAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Bank Name  [CORRESPONDENT.X139]
    /// </summary>
    public string? BankName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Bank  Zip Code [CORRESPONDENT.X138]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BankZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Total Loan Amt (w/ MIP/FF) [CORRESPONDENT.X2]
    /// </summary>
    public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Base Price [3924]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Borrower Paid Discount Points [CORRESPONDENT.X447]
    /// </summary>
    public decimal? BorPaidDiscountPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Amount [CORRESPONDENT.X1]
    /// </summary>
    public decimal? BorrowerRequestedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Borrower Signed Indicator [CORRESPONDENT.X166]
    /// </summary>
    public bool? BorrowerSignedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Qual Ratio Bottom [CORRESPONDENT.X42]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BottomRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Building Status [CORRESPONDENT.X140]
    /// </summary>
    public StringEnumValue<BuildingStatusType> BuildingStatus { get => GetValue<StringEnumValue<BuildingStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Cancelled Date [4207]
    /// </summary>
    public DateTime? CancelledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Cash Out NTB Comparison Form Indicator [CORRESPONDENT.X431]
    /// </summary>
    public bool? CashOutNtbComparisonFormIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Cash to/from Borrower Amount [CORRESPONDENT.X477]
    /// </summary>
    public decimal? CashToOrFromBorrowerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Cash to/from Borrower Indicator [CORRESPONDENT.X482]
    /// </summary>
    public bool? CashToOrFromBorrowerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - CD Section J Lender Credit Total [CORRESPONDENT.X60]
    /// </summary>
    public decimal? CdSectionjLenderCreditTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CD Seller Credit Amount [CORRESPONDENT.X321]
    /// </summary>
    public decimal? CdSellerCreditAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CD Shoppable Services [CORRESPONDENT.X322]
    /// </summary>
    public decimal? CdShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CD Taxes And Govt Fees E [CORRESPONDENT.X336]
    /// </summary>
    public decimal? CdTaxesAndGovtFeesE { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CD Total Borrower Closing Costs [CORRESPONDENT.X339]
    /// </summary>
    public decimal? CdTotalBorrowerClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CEMA Indicator [CORRESPONDENT.X141]
    /// </summary>
    public bool? CemaIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Census Tract [CORRESPONDENT.X142]
    /// </summary>
    public string? CensusTrack { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Certificate Of Eligibility Provided [CORRESPONDENT.X143]
    /// </summary>
    public bool? CertOfEligibilityProvided { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent City Taxes Exclude PITI Payment [CORRESPONDENT.X177]
    /// </summary>
    public bool? CityTaxesExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent City Taxes Frequency [CORRESPONDENT.X199]
    /// </summary>
    public string? CityTaxesFrequency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent City Taxes Next Payment Due Date [CORRESPONDENT.X258]
    /// </summary>
    public DateTime? CityTaxesNextPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Borrower Adjustments [CORRESPONDENT.X81]
    /// </summary>
    public decimal? ClosingBorrowerAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Costs [CORRESPONDENT.X144]
    /// </summary>
    public decimal? ClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Disclosure Lender Credit Amount [CORRESPONDENT.X236]
    /// </summary>
    public decimal? ClosingDisclosureLenderCreditAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing Disclosure Lender POC Amount [CORRESPONDENT.X237]
    /// </summary>
    public decimal? ClosingDisclosureLenderPocAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Collateral Tracking Number [4547]
    /// </summary>
    public string? CollateralTrackingNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Collateral Underwriter Score [CORRESPONDENT.X113]
    /// </summary>
    public string? CollateralUnderwriterScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Comb Loan to Value (CLTV) [CORRESPONDENT.X12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CombinedLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Commitment Amount [CORRESPONDENT.X38]
    /// </summary>
    public decimal? CommitmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Commitment Type [4105]
    /// </summary>
    public StringEnumValue<CommitmentType> CommitmentType { get => GetValue<StringEnumValue<CommitmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Purchase Approval Date [3920]
    /// </summary>
    public DateTime? ConditionsReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Condo Project Class [CORRESPONDENT.X147]
    /// </summary>
    public string? CondoProjectClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Condo Project Status Type [CORRESPONDENT.X148]
    /// </summary>
    public string? CondoProjectStatusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Conversion/Modification Date [CORRESPONDENT.X436]
    /// </summary>
    public DateTime? ConversionModificationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Commitment Date [4527]
    /// </summary>
    public DateTime? CorrespondentCommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Commitment Expiration Date [4529]
    /// </summary>
    public DateTime? CorrespondentCommitmentExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Commitment Period [4528]
    /// </summary>
    public int? CorrespondentCommitmentPeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Correspondent Loan Has MI  [CORRESPONDENT.X489]
    /// </summary>
    public bool? CorrespondentLoanMiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Correspondent Status [3916]
    /// </summary>
    public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => GetValue<StringEnumValue<CorrespondentStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent CorrOtherInsurances
    /// </summary>
    [AllowNull]
    public IList<CorrOtherInsurance> CorrOtherInsurances { get => GetList<CorrOtherInsurance>(); set => SetList(value); }

    /// <summary>
    /// Correspondent County Taxes Exclude PITI Payment [CORRESPONDENT.X178]
    /// </summary>
    public bool? CountyTaxesExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent County Taxes Frequency [CORRESPONDENT.X200]
    /// </summary>
    public string? CountyTaxesFrequency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent County Taxes Monthly Amount [CORRESPONDENT.X383]
    /// </summary>
    public decimal? CountyTaxesMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent County Taxes Next Payment Due Date [CORRESPONDENT.X259]
    /// </summary>
    public DateTime? CountyTaxesNextPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Credit Report  [CORRESPONDENT.X157]
    /// </summary>
    public decimal? CreditReport { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Current Finance Charge [CORRESPONDENT.X404]
    /// </summary>
    public decimal? CurrentFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Custom Minimum Mi [CORRESPONDENT.X158]
    /// </summary>
    public string? CustomMinimumMi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Date Of Sale [CORRESPONDENT.X159]
    /// </summary>
    public DateTime? DateOfSale { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Delivery Expiration Date [3926]
    /// </summary>
    public DateTime? DeliveryExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Delivery Type [3967]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DeliveryType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Disclosed APR [CORRESPONDENT.X23]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosedAprPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Disclosed Daily Interest Charges [CORRESPONDENT.X26]
    /// </summary>
    public decimal? DisclosedDailyInterestCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Disclosed Fees Total Finance Charges [CORRESPONDENT.X24]
    /// </summary>
    public decimal? DisclosedFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Disclosed Temporary Buydown Fund [CORRESPONDENT.X472]
    /// </summary>
    public decimal? DisclosedTemporaryBuydownFund { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Closing disclosure Total Payments [CORRESPONDENT.X164]
    /// </summary>
    public decimal? DisclosedTotalPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Disclosed Upfront MIP Financed [CORRESPONDENT.X473]
    /// </summary>
    public decimal? DisclosedUpfrontMipFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Estimate - Disclosure Last Sent Date [CORRESPONDENT.X19]
    /// </summary>
    public DateTime? DisclosureLastSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Estimate - Disclosure Received Date [CORRESPONDENT.X20]
    /// </summary>
    public DateTime? DisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Disclosures
    /// </summary>
    [AllowNull]
    public IList<Disclosure> Disclosures { get => GetList<Disclosure>(); set => SetList(value); }

    /// <summary>
    /// Correspondent Discount Points Applied [CORRESPONDENT.X39]
    /// </summary>
    public decimal? DiscountPointsApplied { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Discount Points Paid by Other [CORRESPONDENT.X485]
    /// </summary>
    public decimal? DiscountPointsPaidbyOther { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Document Receipt Date [CORRESPONDENT.X483]
    /// </summary>
    public DateTime? DocumentReceiptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent EarlyChecks
    /// </summary>
    [AllowNull]
    public IList<EarlyCheck> EarlyChecks { get => GetList<EarlyCheck>(); set => SetList(value); }

    /// <summary>
    /// Correspondent Effective Property Value [CORRESPONDENT.X172]
    /// </summary>
    public decimal? EffectivePropertyValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Energy Efficient Indicator [CORRESPONDENT.X173]
    /// </summary>
    public bool? EnergyEfficientIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent eNote Indicator [CORRESPONDENT.X171]
    /// </summary>
    public bool? ENoteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X174]
    /// </summary>
    public decimal? EscrowHoldback { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Escrow Reserves Collected at Closing [CORRESPONDENT.X466]
    /// </summary>
    public decimal? EscrowReservesCollectedAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Estimated Escrow [CORRESPONDENT.X403]
    /// </summary>
    public decimal? EstimatedEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Estimated Value Of Repairs [CORRESPONDENT.X175]
    /// </summary>
    public decimal? EstValueOfRepairs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent USDA - Loan Closing - Fee Rate [CORRESPONDENT.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FeeRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHA Insured Date [CORRESPONDENT.X486]
    /// </summary>
    public DateTime? FhaInsuredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHA VA Case Number [CORRESPONDENT.X433]
    /// </summary>
    public string? FhaVaCaseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHLMC Energy Efficient Indicator [CORRESPONDENT.X184]
    /// </summary>
    public bool? FhlmcEnergyEfficientIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Freddie Mac - Purchase Eligibility [CORRESPONDENT.X185]
    /// </summary>
    public string? FhlmcPurchaseEligibility { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHLMC UCD  Case File ID # [CORRESPONDENT.X186]
    /// </summary>
    public string? FhlmcUcdCaseFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHLMC UCD Success Flag [CORRESPONDENT.X188]
    /// </summary>
    public bool? FhlmcUcdSuccessFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Final Inspection Req Indicator [CORRESPONDENT.X189]
    /// </summary>
    public bool? FinalInspectionReqIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Rate Change Payment Effective Date [CORRESPONDENT.X190]
    /// </summary>
    public DateTime? FirstPaymentChangeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter Additional Insurance Amount [CORRESPONDENT.X393]
    /// </summary>
    public decimal? FirstPaymentLetterAdditionalInsuranceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter City Taxes [CORRESPONDENT.X394]
    /// </summary>
    public decimal? FirstPaymentLetterCityTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter County Taxes [CORRESPONDENT.X395]
    /// </summary>
    public decimal? FirstPaymentLetterCountyTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter Flood Amount [CORRESPONDENT.X391]
    /// </summary>
    public decimal? FirstPaymentLetterFloodAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter Hazard Amount [CORRESPONDENT.X390]
    /// </summary>
    public decimal? FirstPaymentLetterHazardAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter HOA Amount [CORRESPONDENT.X397]
    /// </summary>
    public decimal? FirstPaymentLetterHoaAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter Other Taxes [CORRESPONDENT.X399]
    /// </summary>
    public decimal? FirstPaymentLetterOtherTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter PITI [CORRESPONDENT.X191]
    /// </summary>
    public decimal? FirstPaymentLetterPiti { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter PMI/MIP Amount [CORRESPONDENT.X398]
    /// </summary>
    public decimal? FirstPaymentLetterPmiMipAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter School Taxes [CORRESPONDENT.X396]
    /// </summary>
    public decimal? FirstPaymentLetterSchoolTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment Letter Wind/Hail Amount [CORRESPONDENT.X392]
    /// </summary>
    public decimal? FirstPaymentLetterWindHailAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Payment P&amp;I [CORRESPONDENT.X192]
    /// </summary>
    public decimal? FirstPaymentPi { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent First Rate Change Date [CORRESPONDENT.X448]
    /// </summary>
    public DateTime? FirstRateChangeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X153]
    /// </summary>
    public int? FloodCoverageTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Deductible [CORRESPONDENT.X161]
    /// </summary>
    public decimal? FloodDeductible { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Exclude from PITI Payment [CORRESPONDENT.X179]
    /// </summary>
    public bool? FloodExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood insurance coverage may not be available (Building/Mobile Home in CBRA or OPA) [CORRESPONDENT.X497]
    /// </summary>
    public bool? FloodInsuranceCoverageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Insurance Estimator [CORRESPONDENT.X226]
    /// </summary>
    public string? FloodInsuranceEstimator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Insurance Guaranteed Replacement Cost [CORRESPONDENT.X204]
    /// </summary>
    public bool? FloodInsuranceGuaranteedReplacementCost { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property has Flood Insurance  [CORRESPONDENT.X498]
    /// </summary>
    public bool? FloodInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Insurance Required [CORRESPONDENT.X193]
    /// </summary>
    public bool? FloodInsuranceRequired { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Payment Type [CORRESPONDENT.X462]
    /// </summary>
    public string? FloodPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Policy Effective Date [CORRESPONDENT.X278]
    /// </summary>
    public DateTime? FloodPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Policy Type [CORRESPONDENT.X291]
    /// </summary>
    public string? FloodPolicyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Premium Due Date [CORRESPONDENT.X296]
    /// </summary>
    public DateTime? FloodPremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FNMA UCD Case File Id [CORRESPONDENT.X195]
    /// </summary>
    public string? FnmaUcdCaseFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FNMA UCD Submission Date [CORRESPONDENT.X196]
    /// </summary>
    public DateTime? FnmaUcdSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FNMA UCD Success Flag [CORRESPONDENT.X197]
    /// </summary>
    public string? FnmaUcdSuccessFlag { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FNM Condominium Project Manager Project Identifier [CORRESPONDENT.X194]
    /// </summary>
    public string? FnmCondominiumProjectManagerProjectIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Freddie Project Class [CORRESPONDENT.X198]
    /// </summary>
    public string? FreddieProjectClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Purchase Date [3922]
    /// </summary>
    public DateTime? FundedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Grace Period # of Days [3927]
    /// </summary>
    public int? GracePeriodDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Grace Period Start Date [4110]
    /// </summary>
    public DateTime? GracePeriodStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Grace Period Start Trigger Date [4111]
    /// </summary>
    public string? GracePeriodStartTrigger { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent USDA - Tracking - Guarantee Fee Collected [CORRESPONDENT.X17]
    /// </summary>
    public decimal? GuaranteeFeeCollected { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X154]
    /// </summary>
    public int? HazardCoverageTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Deductible [CORRESPONDENT.X162]
    /// </summary>
    public decimal? HazardDeductible { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Exclude from PITI Payment [CORRESPONDENT.X180]
    /// </summary>
    public bool? HazardExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Insurance Estimator [CORRESPONDENT.X227]
    /// </summary>
    public string? HazardInsuranceEstimator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Insurance Guaranteed Replacement Cost [CORRESPONDENT.X205]
    /// </summary>
    public bool? HazardInsuranceGuaranteedReplacementCost { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property has Hazard Insurance  [CORRESPONDENT.X499]
    /// </summary>
    public bool? HazardInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Payment Type [CORRESPONDENT.X463]
    /// </summary>
    public string? HazardPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Policy Effective Date [CORRESPONDENT.X279]
    /// </summary>
    public DateTime? HazardPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Policy Type [CORRESPONDENT.X292]
    /// </summary>
    public string? HazardPolicyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Premium Due Date [CORRESPONDENT.X297]
    /// </summary>
    public DateTime? HazardPremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - High Priced Mortgage Loan Indicator [CORRESPONDENT.X474]
    /// </summary>
    public bool? HighPricedLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Obsolete - Correspondent High Priced Mortgage Loan Indicator [CORRESPONDENT.X207]
    /// </summary>
    public string? HighPricedMortageLoanIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Assessment Income [CORRESPONDENT.X208]
    /// </summary>
    public decimal? HoaBudgetedAssessmentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Budgeted Replacement Reserves [CORRESPONDENT.X209]
    /// </summary>
    public decimal? HoaBudgetedReplacementReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent HOA Litigation Status [CORRESPONDENT.X210]
    /// </summary>
    public bool? HoaLitigationStatus { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Home One Indicator [CORRESPONDENT.X211]
    /// </summary>
    public bool? HomeOneIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Home Possible Adv Indicator [CORRESPONDENT.X213]
    /// </summary>
    public bool? HomePossibleAdvIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Home Possible Indicator [CORRESPONDENT.X212]
    /// </summary>
    public bool? HomePossibleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Home Ready Indicator [CORRESPONDENT.X214]
    /// </summary>
    public bool? HomeReadyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Home Style Indicator [CORRESPONDENT.X215]
    /// </summary>
    public bool? HomeStyleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Housing Ratio [CORRESPONDENT.X450]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent IEAD Initial Deposit [CORRESPONDENT.X216]
    /// </summary>
    public decimal? IeadInitialDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Includes Walls In [CORRESPONDENT.X502]
    /// </summary>
    public bool? IncludesWallsIn { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Includes Wind/Hail [CORRESPONDENT.X478]
    /// </summary>
    public bool? IncludesWindOrHail { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Income Type [CORRESPONDENT.X220]
    /// </summary>
    public string? IncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Index Type [CORRESPONDENT.X221]
    /// </summary>
    public string? IndexType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Fees Initial Adjusted Rate Permanent Phase [CORRESPONDENT.X5]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialAdjustedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Fees Initial Adjusted Point Permanent Phase [CORRESPONDENT.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialAdjustedRatePoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Purchase Suspense Date [3918]
    /// </summary>
    public DateTime? InitialSuspenseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent TIL Intl Disclosure Provided Date [CORRESPONDENT.X18]
    /// </summary>
    public DateTime? InitialTilDisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent TIL Intl TIL Disclosure Rcvd Date [CORRESPONDENT.X22]
    /// </summary>
    public DateTime? InitialTilDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Insurance Type [CORRESPONDENT.X501]
    /// </summary>
    public string? InsuranceType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent My Company Wishes to not apply interest rate exportation [CORRESPONDENT.X504]
    /// </summary>
    public bool? InterestRateExportationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Additional Insurance included [CORRESPONDENT.X217]
    /// </summary>
    public bool? IsAdditionalInsurance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Flood Insurance included [CORRESPONDENT.X218]
    /// </summary>
    public bool? IsFloodInsurance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Hazard Included in Master Policy  [CORRESPONDENT.X500]
    /// </summary>
    public bool? IsHazardIncludedMasterPolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Improve Indicator [CORRESPONDENT.X230]
    /// </summary>
    public bool? IsSubjectPropertyImproved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Is the highest and the best use of subject property as improved [CORRESPONDENT.X432]
    /// </summary>
    public string? IsTheHighestAndTheBestUseOfSubjectPropertyAsImproved { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Insurance included [CORRESPONDENT.X219]
    /// </summary>
    public bool? IsWindHailInsurance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Jumbo [CORRESPONDENT.X362]
    /// </summary>
    public bool? Jumbo { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last AUS Result [CORRESPONDENT.X231]
    /// </summary>
    public string? LastAusResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last AUS Run Date [CORRESPONDENT.X232]
    /// </summary>
    public DateTime? LastAusRunDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last AUS Type [CORRESPONDENT.X233]
    /// </summary>
    public string? LastAusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last Disclosure Date [CORRESPONDENT.X401]
    /// </summary>
    public DateTime? LastDisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last Disclosure Received Date [CORRESPONDENT.X402]
    /// </summary>
    public DateTime? LastDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Last Published Conditions Notification Date Time [CORRESPONDENT.X56]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? LastPublishedConditionsNotificationDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Late Charge Days [CORRESPONDENT.X10]
    /// </summary>
    public int? LateChargeDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Late Charge % [CORRESPONDENT.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LateChargePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Days Begin [3928]
    /// </summary>
    public DateTime? LateDaysBegin { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Days End [3929]
    /// </summary>
    public DateTime? LateDaysEnd { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Days End Trigger  Date [4112]
    /// </summary>
    public string? LateDaysEndTrigger { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Late Fee [CORRESPONDENT.X9]
    /// </summary>
    public decimal? LateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee Charge Type [3936]
    /// </summary>
    public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => GetValue<StringEnumValue<LateFeeChargeType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee - Frequency [3933]
    /// </summary>
    public string? LateFeeFrequency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee - Notes [3935]
    /// </summary>
    public string? LateFeeNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee - Late Fee Percentage [3931]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
    public decimal? LateFeePercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee - Total Price Adjustment [3934]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, ReadOnly = true)]
    public decimal? LateFeeTotalPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Latest Conds Issued Date [3919]
    /// </summary>
    public DateTime? LatestConditionsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Lender Paid MI Rate [CORRESPONDENT.X491]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LenderPaidMiRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Lender Paid Premium Amount [CORRESPONDENT.X492]
    /// </summary>
    public decimal? LenderPaidPremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - LE Section J Lender Credit Total [CORRESPONDENT.X59]
    /// </summary>
    public int? LeSectionjLenderCreditTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - Amount Value [LATEFEESETTING.X17]
    /// </summary>
    public decimal? LfsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X1]
    /// </summary>
    public int? LfsCalculateAs { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - DayCleared [LATEFEESETTING.X12]
    /// </summary>
    public int? LfsDayCleared { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate [LATEFEESETTING.X13]
    /// </summary>
    public string? LfsDayClearedOtherDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Description [LATEFEESETTING.X18]
    /// </summary>
    public string? LfsDayClearedOtherDateDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value [LATEFEESETTING.X15]
    /// </summary>
    public DateTime? LfsDayClearedOtherDateValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - FeeHandledAs [LATEFEESETTING.X2]
    /// </summary>
    public int? LfsFeeHandledAs { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar [LATEFEESETTING.X3]
    /// </summary>
    public int? LfsGracePeriodCalendar { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - GracePeriodDays [LATEFEESETTING.X11]
    /// </summary>
    public int? LfsGracePeriodDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf [LATEFEESETTING.X4]
    /// </summary>
    public int? LfsGracePeriodLaterOf { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts [LATEFEESETTING.X5]
    /// </summary>
    public int? LfsGracePeriodStarts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X6]
    /// </summary>
    public int? LfsIncludeDay { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - LateFee Value [LATEFEESETTING.X16]
    /// </summary>
    public decimal? LfsLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn [LATEFEESETTING.X7]
    /// </summary>
    public int? LfsLateFeeBasedOn { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - MaxLateDays [LATEFEESETTING.X8]
    /// </summary>
    public int? LfsMaxLateDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - OtherDate [LATEFEESETTING.X9]
    /// </summary>
    public string? LfsOtherDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - OtherDate Value [LATEFEESETTING.X14]
    /// </summary>
    public DateTime? LfsOtherDateValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - External Late Fee Settings - StartOnWeekend [LATEFEESETTING.X10]
    /// </summary>
    public int? LfsStartOnWeekend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Life Of Loan [CORRESPONDENT.X238]
    /// </summary>
    public bool? LifeOfLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Life Time Cap 1 [CORRESPONDENT.X239]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LifeTimeCap1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Life Time Cap 2 [CORRESPONDENT.X240]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LifeTimeCap2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Living Area [CORRESPONDENT.X241]
    /// </summary>
    public decimal? LivingArea { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Discount Fee [CORRESPONDENT.X242]
    /// </summary>
    public decimal? LoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Loan is Committed [4532]
    /// </summary>
    public bool? LoanIsCommitted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Disclosed Product [CORRESPONDENT.X28]
    /// </summary>
    public string? LoanProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status [CORRESPONDENT.X53]
    /// </summary>
    public string? LoanStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status Change User Name [CORRESPONDENT.X245]
    /// </summary>
    public string? LoanStatusChangeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status Change DateTime Stamp [CORRESPONDENT.X246]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LoanStatusDateTimeStamp { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status Last Updated DateTime [CORRESPONDENT.X54]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? LoanStatusLastUpdatedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status OCR [CORRESPONDENT.X244]
    /// </summary>
    public string? LoanStatusOcr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent LOMA/LOMR [CORRESPONDENT.X247]
    /// </summary>
    public DateTime? LomaLomr { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Lookback Period 1 [CORRESPONDENT.X248]
    /// </summary>
    public string? LookbackPeriod1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Lookback Period 2 [CORRESPONDENT.X249]
    /// </summary>
    public string? LookbackPeriod2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Freddie Mac Loan To Value (LTV) [CORRESPONDENT.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Coverage Amount [CORRESPONDENT.X150]
    /// </summary>
    public decimal? MasterCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X155]
    /// </summary>
    public int? MasterCoverageTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Insurance Company Name [CORRESPONDENT.X223]
    /// </summary>
    public string? MasterInsuranceCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Payment Type [CORRESPONDENT.X464]
    /// </summary>
    public string? MasterPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Effective Date [CORRESPONDENT.X280]
    /// </summary>
    public DateTime? MasterPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Expiration Date [CORRESPONDENT.X283]
    /// </summary>
    public DateTime? MasterPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Company Name [CORRESPONDENT.X412]
    /// </summary>
    public string? MasterPolicyFloodCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Coverage Amount [CORRESPONDENT.X417]
    /// </summary>
    public decimal? MasterPolicyFloodCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Payment Type [CORRESPONDENT.X416]
    /// </summary>
    public string? MasterPolicyFloodPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Policy Effective Date [CORRESPONDENT.X414]
    /// </summary>
    public DateTime? MasterPolicyFloodPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Policy Expiration Date [CORRESPONDENT.X415]
    /// </summary>
    public DateTime? MasterPolicyFloodPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Flood: Policy Number [CORRESPONDENT.X413]
    /// </summary>
    public string? MasterPolicyFloodPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Company Name [CORRESPONDENT.X406]
    /// </summary>
    public string? MasterPolicyHazardCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Coverage Amount [CORRESPONDENT.X411]
    /// </summary>
    public decimal? MasterPolicyHazardCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Payment Type [CORRESPONDENT.X410]
    /// </summary>
    public string? MasterPolicyHazardPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Policy Effective Date [CORRESPONDENT.X408]
    /// </summary>
    public DateTime? MasterPolicyHazardPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Policy Expiration Date [CORRESPONDENT.X409]
    /// </summary>
    public DateTime? MasterPolicyHazardPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Hazard: Policy Number [CORRESPONDENT.X407]
    /// </summary>
    public string? MasterPolicyHazardPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Panel Number [CORRESPONDENT.X286]
    /// </summary>
    public string? MasterPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Company Name [CORRESPONDENT.X425]
    /// </summary>
    public string? MasterPolicyOtherCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Coverage Amount [CORRESPONDENT.X430]
    /// </summary>
    public decimal? MasterPolicyOtherCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Insurance Type Description [CORRESPONDENT.X424]
    /// </summary>
    public string? MasterPolicyOtherInsuranceTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Payment Type [CORRESPONDENT.X429]
    /// </summary>
    public string? MasterPolicyOtherPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Policy Effective Date [CORRESPONDENT.X427]
    /// </summary>
    public DateTime? MasterPolicyOtherPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Policy Expiration Date [CORRESPONDENT.X428]
    /// </summary>
    public DateTime? MasterPolicyOtherPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Other: Policy Number [CORRESPONDENT.X426]
    /// </summary>
    public string? MasterPolicyOtherPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Company Name [CORRESPONDENT.X418]
    /// </summary>
    public string? MasterPolicyWindOrHailCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Coverage Amount [CORRESPONDENT.X423]
    /// </summary>
    public decimal? MasterPolicyWindOrHailCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Payment Type [CORRESPONDENT.X422]
    /// </summary>
    public string? MasterPolicyWindOrHailPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Policy Effective Date [CORRESPONDENT.X420]
    /// </summary>
    public DateTime? MasterPolicyWindOrHailPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Policy Expiration Date [CORRESPONDENT.X421]
    /// </summary>
    public DateTime? MasterPolicyWindOrHailPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Master Policy Wind/Hail: Policy Number [CORRESPONDENT.X419]
    /// </summary>
    public string? MasterPolicyWindOrHailPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Max First Change Rate 1 [CORRESPONDENT.X250]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxFirstChangeRate1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Max First Change Rate 2 [CORRESPONDENT.X251]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxFirstChangeRate2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Min First Change Rate 1 [CORRESPONDENT.X253]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinFirstChangeRate1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Min First Change Rate 2 [CORRESPONDENT.X254]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinFirstChangeRate2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Mi Ordered By [CORRESPONDENT.X493]
    /// </summary>
    public StringEnumValue<MiOrderedBy> MiOrderedBy { get => GetValue<StringEnumValue<MiOrderedBy>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent MI Premium Payment Type [CORRESPONDENT.X252]
    /// </summary>
    public string? MiPremiumPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent MI Premium Term [CORRESPONDENT.X490]
    /// </summary>
    public int? MiPremiumTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Date of First Payment Without Monthly MI [CORRESPONDENT.X475]
    /// </summary>
    public DateTime? MiTerminationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Modification [CORRESPONDENT.X480]
    /// </summary>
    public bool? Modification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Modification Date [CORRESPONDENT.X481]
    /// </summary>
    public DateTime? ModificationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent MOM Indicator [CORRESPONDENT.X255]
    /// </summary>
    public bool? MomIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Amount [CORRESPONDENT.X446]
    /// </summary>
    public decimal? MonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent VA Monthly Housing Expense [CORRESPONDENT.X37]
    /// </summary>
    public decimal? MonthlyHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Premium Amount [CORRESPONDENT.X83]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? MonthlyPremiumAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit3 [CORRESPONDENT.X256]
    /// </summary>
    public decimal? MonthlyRentAmountUnit3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Monthly Rent Amount Unit4 [CORRESPONDENT.X257]
    /// </summary>
    public decimal? MonthlyRentAmountUnit4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Insurance Mtg Ins Mos Prepaid [CORRESPONDENT.X14]
    /// </summary>
    public int? MonthsOfMiPrepaid { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Insurance Mtg Ins Upfront Factor [CORRESPONDENT.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Negative Cash Flow [CORRESPONDENT.X439]
    /// </summary>
    public decimal? NegativeCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel date [CORRESPONDENT.X262]
    /// </summary>
    public DateTime? NfipPaneldate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NFIP Panel Number [CORRESPONDENT.X263]
    /// </summary>
    public string? NfipPanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - NFIP Program Type [CORRESPONDENT.X496]
    /// </summary>
    public StringEnumValue<NfipProgramType> NfipProgramType { get => GetValue<StringEnumValue<NfipProgramType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Non-Mortgage Payoff Amount [CORRESPONDENT.X264]
    /// </summary>
    public decimal? NonMortgagePayoffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Non-Shoppable Services (B) [CORRESPONDENT.X265]
    /// </summary>
    public decimal? NonShoppableServicesB { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Non-Traditional Credit [CORRESPONDENT.X266]
    /// </summary>
    public bool? NonTraditionalCredit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Notary Acknowledgement Date [CORRESPONDENT.X267]
    /// </summary>
    public DateTime? NotaryAcknowledgementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Note Date [3925]
    /// </summary>
    public DateTime? NoteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Note (P&amp;I) 2 [CORRESPONDENT.X360]
    /// </summary>
    public decimal? NotePAndI2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Note P &amp; I [CORRESPONDENT.X268]
    /// </summary>
    public decimal? NotePi { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent NOV Amount [CORRESPONDENT.X434]
    /// </summary>
    public decimal? NovAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms [CORRESPONDENT.X269]
    /// </summary>
    public int? NumberofBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 1 [CORRESPONDENT.X270]
    /// </summary>
    public int? NumberofBedroomsUnit1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Bedrooms Unit 2 [CORRESPONDENT.X271]
    /// </summary>
    public int? NumberofBedroomsUnit2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 3 [CORRESPONDENT.X70]
    /// </summary>
    public int? NumberOfBedroomUnit3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Bedroom Unit 4 [CORRESPONDENT.X71]
    /// </summary>
    public int? NumberOfBedroomUnit4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number Of Buydown Periods [CORRESPONDENT.X72]
    /// </summary>
    public int? NumberOfBuydownPeriods { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Number of Units [CORRESPONDENT.X272]
    /// </summary>
    public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Original Principal Balance [4107]
    /// </summary>
    public decimal? OriginalPrincipalBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Origination Charged (A) [CORRESPONDENT.X273]
    /// </summary>
    public decimal? OriginationChargedA { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Other Insurance Type [CORRESPONDENT.X451]
    /// </summary>
    public string? OtherInsuranceType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Other Taxes Exclude PITI Payment [CORRESPONDENT.X181]
    /// </summary>
    public bool? OtherTaxesExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Other Taxes Frequency [CORRESPONDENT.X201]
    /// </summary>
    public string? OtherTaxesFrequency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Other Taxes Monthly Amount [CORRESPONDENT.X385]
    /// </summary>
    public decimal? OtherTaxesMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Other Taxes Next Payment Due Date [CORRESPONDENT.X260]
    /// </summary>
    public DateTime? OtherTaxesNextPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Panel Number [CORRESPONDENT.X274]
    /// </summary>
    public string? PanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Payment Amount [CORRESPONDENT.X30]
    /// </summary>
    public decimal? PaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Periodic Change % [CORRESPONDENT.X275]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PeriodicChangePercent1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Periodic Change % [CORRESPONDENT.X276]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PeriodicChangePercent2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Points in Initial Adjusted Rate [CORRESPONDENT.X505]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PointsInInitialAdjustedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zip Code 4 digits [CORRESPONDENT.X358]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Power of Attorney Indicator [CORRESPONDENT.X294]
    /// </summary>
    public bool? PowerofAttorneyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Premium Term [CORRESPONDENT.X299]
    /// </summary>
    public string? PremiumTerm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Prepaid Finance [CORRESPONDENT.X300]
    /// </summary>
    public decimal? PrepaidFinance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Prepaid Interest Days [CORRESPONDENT.X73]
    /// </summary>
    public int? PrepaidInterestDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - Prepayment Penalty [CORRESPONDENT.X58]
    /// </summary>
    public bool? PrepaymentPenalty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Prepayment Penalty [CORRESPONDENT.X29]
    /// </summary>
    public bool? PrepaymentPenaltyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Prepayment Rider Indicator [CORRESPONDENT.X165]
    /// </summary>
    public bool? PrepaymentRiderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Mo Pymt (P&amp;I) [CORRESPONDENT.X3]
    /// </summary>
    public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - Prior Application Date [CORRESPONDENT.X62]
    /// </summary>
    public DateTime? PriorApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Prior Disclosed Daily Interest [CORRESPONDENT.X27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PriorDisclosedDailyInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - Prior Disclosure Date [CORRESPONDENT.X57]
    /// </summary>
    public DateTime? PriorDisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Project Class [CORRESPONDENT.X301]
    /// </summary>
    public StringEnumValue<ProjectType> ProjectClass { get => GetValue<StringEnumValue<ProjectType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Project Name [CORRESPONDENT.X302]
    /// </summary>
    public string? ProjectName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Acquired Less Than One Year Ago [CORRESPONDENT.X303]
    /// </summary>
    public bool? PropertyAcquiredLessThanOneYearAgo { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Type [CORRESPONDENT.X304]
    /// </summary>
    public string? PropertyAppraisalType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Appraisal Unit Number [CORRESPONDENT.X348]
    /// </summary>
    public string? PropertyAppraisalUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Attachment Type [CORRESPONDENT.X305]
    /// </summary>
    public StringEnumValue<AttachmentType> PropertyAttachmentType { get => GetValue<StringEnumValue<AttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Flip Indicator [CORRESPONDENT.X361]
    /// </summary>
    public bool? PropertyFlipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Occupancy Status [CORRESPONDENT.X306]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageCode { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Property Value [CORRESPONDENT.X307]
    /// </summary>
    public decimal? PropertyValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Expenses Proposed HOA [CORRESPONDENT.X34]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? ProposedDuesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Expenses Proposed Haz Ins [CORRESPONDENT.X31]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? ProposedHazardInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Expenses Proposed Mtg Ins [CORRESPONDENT.X33]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? ProposedMortgageInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Expenses Proposed Other Housing [CORRESPONDENT.X35]
    /// </summary>
    public decimal? ProposedOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Expenses Proposed Taxes [CORRESPONDENT.X32]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? ProposedRealEstateTaxesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Contract Sales Price [CORRESPONDENT.X308]
    /// </summary>
    public decimal? PurchaseContractSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rate Adjustment Periodic Cap [CORRESPONDENT.X309]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentPeriodicCap { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rate Adjustment Periodic Cap 2 [CORRESPONDENT.X310]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentPeriodicCap2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent ATR QM - Qualification - Rate Reduction Basis Points % [CORRESPONDENT.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateReductionBasisPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Rate Sheet ID [3923]
    /// </summary>
    public string? Ratesheet { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Received Date [3917]
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Recoupment Number of Months [CORRESPONDENT.X311]
    /// </summary>
    public int? RecoupmentNumberOfMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Reduced MI Indicator [CORRESPONDENT.X312]
    /// </summary>
    public bool? ReducedMiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Refinance Type [CORRESPONDENT.X503]
    /// </summary>
    public StringEnumValue<CorrespondentRefinanceType> RefinanceType { get => GetValue<StringEnumValue<CorrespondentRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Refund prorated unearned Up Front MI Premiums [CORRESPONDENT.X15]
    /// </summary>
    public bool? RefundUnearnedMipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Rejected Date [3940]
    /// </summary>
    public DateTime? RejectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Renovation [CORRESPONDENT.X479]
    /// </summary>
    public bool? Renovation { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Renovation Complete Indicator [CORRESPONDENT.X313]
    /// </summary>
    public bool? RenovationCompleteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Renovation Program  [CORRESPONDENT.X488]
    /// </summary>
    public bool? RenovationProgramIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 1 [CORRESPONDENT.X314]
    /// </summary>
    public decimal? RentAmountUnit1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Rent Amount Unit 2 [CORRESPONDENT.X315]
    /// </summary>
    public decimal? RentAmountUnit2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Riders
    /// </summary>
    [AllowNull]
    public IList<Rider> Riders { get => GetList<Rider>(); set => SetList(value); }

    /// <summary>
    /// Correspondent SAR Expiration Date [CORRESPONDENT.X435]
    /// </summary>
    public DateTime? SarExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Scenarios
    /// </summary>
    [AllowNull]
    public IList<Scenario> Scenarios { get => GetList<Scenario>(); set => SetList(value); }

    /// <summary>
    /// Correspondent Trans Details First Pymt Date [CORRESPONDENT.X40]
    /// </summary>
    public DateTime? ScheduledFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent School Taxes Monthly Amount [CORRESPONDENT.X384]
    /// </summary>
    public decimal? SchoolTaxesMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Sec 32 - HOEPA APR [CORRESPONDENT.X318]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Section32Apr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Section32 Disclosure Date [CORRESPONDENT.X319]
    /// </summary>
    public DateTime? Section32DisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan qualifies as high cost under Section 32 [CORRESPONDENT.X320]
    /// </summary>
    public bool? Section32Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Seller Paid Discount Fees [CORRESPONDENT.X484]
    /// </summary>
    public decimal? SellerPaidDiscountFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Site Value [CORRESPONDENT.X323]
    /// </summary>
    public decimal? SiteValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Specialty Product [CORRESPONDENT.X324]
    /// </summary>
    public string? SpecialtyProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Standard Deviation [CORRESPONDENT.X325]
    /// </summary>
    public string? StandardDeviation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Gross Rent [CORRESPONDENT.X327]
    /// </summary>
    public decimal? StatedGrossRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Condition [CORRESPONDENT.X328]
    /// </summary>
    public string? StatedPropertyCondition { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Stated Property Type [CORRESPONDENT.X329]
    /// </summary>
    public StringEnumValue<PropertyType> StatedPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State Taxes Exclude from PITI Payment [CORRESPONDENT.X182]
    /// </summary>
    public bool? StateTaxesExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State Taxes Frequency [CORRESPONDENT.X202]
    /// </summary>
    public string? StateTaxesFrequency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State Taxes Next Payment Due Date [CORRESPONDENT.X261]
    /// </summary>
    public DateTime? StateTaxesNextPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Address City [CORRESPONDENT.X330]
    /// </summary>
    public string? SubjectAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Improved [CORRESPONDENT.X331]
    /// </summary>
    public StringEnumValue<PropertyImprovementsType> SubjectPropertyImproved { get => GetValue<StringEnumValue<PropertyImprovementsType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent State [CORRESPONDENT.X326]
    /// </summary>
    public string? SubjectPropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subject Property Unit Number [CORRESPONDENT.X332]
    /// </summary>
    public string? SubjectPropertyUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Submitted for Review Date [4119]
    /// </summary>
    public DateTime? SubmittedforPurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subordination Type [CORRESPONDENT.X333]
    /// </summary>
    public string? SubordinationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Subsequent Adjustment Term [CORRESPONDENT.X334]
    /// </summary>
    public int? SubsequentAdjustmentTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Supervisory Appraisal Co License # [CORRESPONDENT.X335]
    /// </summary>
    public string? SupervisoryAppraiserLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Texas A6 Indicator [CORRESPONDENT.X337]
    /// </summary>
    public bool? TexasA6Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Texas A6 Indicator 2 [CORRESPONDENT.X338]
    /// </summary>
    public bool? TexasA6Indicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Trans Details Qual Ratio Top [CORRESPONDENT.X41]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TopRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Total Escrows Collected At Closing [CORRESPONDENT.X340]
    /// </summary>
    public decimal? TotalEscrowsCollectedAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Total Late Days [3930]
    /// </summary>
    public int? TotalLateDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Late Fee -Total Late Fee [3937]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Total Net Monthly Salary [CORRESPONDENT.X36]
    /// </summary>
    public decimal? TotalNetMonthlySalary { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent REGZ Total Amt All Pymts [CORRESPONDENT.X21]
    /// </summary>
    public decimal? TotalOfPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent TX Preclose CD Borrower Delivery Date [CORRESPONDENT.X341]
    /// </summary>
    public DateTime? TxPrecloseCdBorrDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent TX Preclose CD Borrower Receipt Date [CORRESPONDENT.X342]
    /// </summary>
    public DateTime? TxPrecloseCdBorrReceiptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UCDP Appraisal Effective Date [CORRESPONDENT.X343]
    /// </summary>
    public DateTime? UcdpAppraisalEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UCDP Appraised Value [CORRESPONDENT.X344]
    /// </summary>
    public int? UcdpAppraisedValueAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UCDP DOC File ID [CORRESPONDENT.X345]
    /// </summary>
    public string? UcdpDocFileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UCDP Over Valuation [CORRESPONDENT.X346]
    /// </summary>
    public string? UcdpOverValuation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent FHLMC UCD Submission Date [CORRESPONDENT.X187]
    /// </summary>
    public DateTime? UcdSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UCD EC Result [CORRESPONDENT.X167]
    /// </summary>
    public string? UcdSubmissionResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Underwriting Method [CORRESPONDENT.X347]
    /// </summary>
    public StringEnumValue<RiskAssessmentType> UnderwritingMethod { get => GetValue<StringEnumValue<RiskAssessmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent UnDiscounted Rate Permanent Phase [CORRESPONDENT.X4]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? UndiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Unpaid Principal Balance [4106]
    /// </summary>
    public decimal? UnpaidPrincipalBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Upfront MIP Rate [CORRESPONDENT.X349]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? UpfrontMipRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Up Front Premium Amt [CORRESPONDENT.X350]
    /// </summary>
    public decimal? UpfrontPremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent USDA One Time Close [CORRESPONDENT.X445]
    /// </summary>
    public bool? UsdaOneTimeClose { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent VA Cash Out NTB Comparison Form Date [CORRESPONDENT.X352]
    /// </summary>
    public DateTime? VaCashOutNtbComparisonFormDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent VA Insured Date [CORRESPONDENT.X487]
    /// </summary>
    public DateTime? VaInsuredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Compliance Review - VA IRRRL Statutory P&amp;I Amount [CORRESPONDENT.X61]
    /// </summary>
    public decimal? VaIrrrlStatutoryPAndIAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Valuations
    /// </summary>
    [AllowNull]
    public IList<Valuation> Valuations { get => GetList<Valuation>(); set => SetList(value); }

    /// <summary>
    /// Correspondent Value Used For Additional Insurance [CORRESPONDENT.X353]
    /// </summary>
    public decimal? ValueUsedForAdditionalInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Value Used For Flood Insurance [CORRESPONDENT.X354]
    /// </summary>
    public decimal? ValueUsedForFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Value Used For Hazard Insurance [CORRESPONDENT.X355]
    /// </summary>
    public decimal? ValueUsedForHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Value Used For Wind/Hail Insurance [CORRESPONDENT.X356]
    /// </summary>
    public decimal? ValueUsedForWindHailInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Voided Date [4208]
    /// </summary>
    public DateTime? VoidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Coverage Amount [CORRESPONDENT.X151]
    /// </summary>
    public decimal? WindHailCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Undefined [CORRESPONDENT.X156]
    /// </summary>
    public int? WindHailCoverageTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Deductible [CORRESPONDENT.X163]
    /// </summary>
    public decimal? WindHailDeductible { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Exclude from PITI Payment [CORRESPONDENT.X183]
    /// </summary>
    public bool? WindHailExcludePitiPayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Insurance Company Name [CORRESPONDENT.X224]
    /// </summary>
    public string? WindHailInsuranceCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Insurance Estimator [CORRESPONDENT.X228]
    /// </summary>
    public string? WindHailInsuranceEstimator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Insurance Guaranteed Replacement Cost [CORRESPONDENT.X206]
    /// </summary>
    public bool? WindHailInsuranceGuaranteedReplacementCost { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Payment Type [CORRESPONDENT.X465]
    /// </summary>
    public string? WindHailPaymentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Policy Effective Date [CORRESPONDENT.X281]
    /// </summary>
    public DateTime? WindHailPolicyEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Policy Expiration Date [CORRESPONDENT.X284]
    /// </summary>
    public DateTime? WindHailPolicyExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Panel Number [CORRESPONDENT.X287]
    /// </summary>
    public string? WindHailPolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Policy Premium [CORRESPONDENT.X289]
    /// </summary>
    public decimal? WindHailPolicyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent WindHail Policy Type [CORRESPONDENT.X293]
    /// </summary>
    public string? WindHailPolicyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Wind/Hail Premium Due Date [CORRESPONDENT.X298]
    /// </summary>
    public DateTime? WindHailPremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Withdrawal Requested Date [4242]
    /// </summary>
    public DateTime? WithdrawalRequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Loan Status - Withdrawn Date [4120]
    /// </summary>
    public DateTime? WithdrawnDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Year Built [CORRESPONDENT.X357]
    /// </summary>
    public string? YearBuilt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Zoning Compliance [CORRESPONDENT.X359]
    /// </summary>
    public string? ZoningCompliance { get => GetValue<string?>(); set => SetValue(value); }
}