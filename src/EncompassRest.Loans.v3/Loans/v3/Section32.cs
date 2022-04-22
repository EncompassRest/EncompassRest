using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Section32
/// </summary>
public sealed partial class Section32 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Sec 32 Appraisal Fee To Be Financed [S32DISC.X76]
    /// </summary>
    public bool? AppraisalFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Appraisal Fee Lender/Brkr Rec Portion [S32DISC.X26]
    /// </summary>
    public bool? AppraisalPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 % Loan Exceeds Treasury Security Yield [S32DISC.X98]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprExceedsTsyForFirstMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Loan Exceeds % For Subordinate Mtgs [S32DISC.X99]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprExceedsTsyForSubordinateMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Assumption Fee To Be Financed [S32DISC.X131]
    /// </summary>
    public bool? AssumptionFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Assumption Fee Lender/Brkr Rec Portion [S32DISC.X130]
    /// </summary>
    public bool? AssumptionPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Attorney Fee To Be Financed [S32DISC.X133]
    /// </summary>
    public bool? AttorneyFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Attorney Fee Lender/Brkr Rec Portion [S32DISC.X132]
    /// </summary>
    public bool? AttorneyPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 City/County Tax/Stamps To Be Financed [S32DISC.X86]
    /// </summary>
    public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 City/County Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X37]
    /// </summary>
    public bool? CityCountyTaxStampsPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Closing/Escrow Fee To Be Financed [S32DISC.X78]
    /// </summary>
    public bool? ClosingFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Closing/Escrow Fee Lender/Brkr Rec Portion [S32DISC.X29]
    /// </summary>
    public bool? ClosingPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Credit Report To Be Financed [S32DISC.X77]
    /// </summary>
    public bool? CreditReportFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Credit Report Lender/Brkr Rec Portion [S32DISC.X28]
    /// </summary>
    public bool? CreditReportPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Doc Prep Fee To Be Financed [S32DISC.X79]
    /// </summary>
    public bool? DocPrepFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Doc Prep Fee Lender/Brkr Rec Portion [S32DISC.X30]
    /// </summary>
    public bool? DocPrepPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - Maximum Prepayment Penalty does/does not exceed 2% of the amount prepaid [S32DISC.X179]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> Exceed2PercentPrepayPenalty { get => GetValue<StringEnumValue<DoesOrDoesNot2>>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - HOEPA APR [S32DISC.X177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HoepaApr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Current HOEPA Fee Trigger [S32DISC.X50]
    /// </summary>
    public decimal? HoepaFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Jurisdictions under which loan qualifies as high cost [HighCost.Jurisdications]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Jurisdictions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Lenders Inspect Fee To Be Financed [S32DISC.X58]
    /// </summary>
    public bool? LendersInspectionFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Lenders Inspect Fee Lender/Brkr Rec Portion [S32DISC.X7]
    /// </summary>
    public bool? LendersInspectionPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Loan Discount Fee To Be Financed [S32DISC.X55]
    /// </summary>
    public bool? LoanDiscountFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Loan Discount Fee Lender/Brkr Rec Portion [S32DISC.X4]
    /// </summary>
    public bool? LoanDiscountPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Loan Orig Fee To Be Financed [S32DISC.X54]
    /// </summary>
    public bool? LoanOriginationFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Loan Orig Fee Lender/Brkr Rec Portion [S32DISC.X3]
    /// </summary>
    public bool? LoanOriginationPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Qualifies as High Cost Mtg Under Section 32 [S32DISC.X51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanQualifyAsHighCostMortgage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Max % of Loan Amt for Allowed Fees [S32DISC.X100]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumPercentageOfLoan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Max Allowed Points/Fees [S32DISC.X101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumPointsAndFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Broker Fee To Be Financed [S32DISC.X66]
    /// </summary>
    public bool? MortgageBrokerFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Broker Fee Lender/Brkr Rec Portion [S32DISC.X15]
    /// </summary>
    public bool? MortgageBrokerPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 MI Application Fee To Be Financed [S32DISC.X129]
    /// </summary>
    public bool? MortgageInspectionFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 MI Application Fee Lender/Brkr Rec Portion [S32DISC.X128]
    /// </summary>
    public bool? MortgageInspectionPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Ins To Be Financed [S32DISC.X147]
    /// </summary>
    public bool? MortgageInsuranceFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Ins Lender/Brkr Rec Portion [S32DISC.X146]
    /// </summary>
    public bool? MortgageInsurancePortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Ins Prem To Be Financed [S32DISC.X145]
    /// </summary>
    public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg Ins Prem Lender/Brkr Rec Portion [S32DISC.X144]
    /// </summary>
    public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Notary Fees To Be Financed [S32DISC.X80]
    /// </summary>
    public bool? NotaryFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Notary Fees Lender/Brkr Rec Portion [S32DISC.X31]
    /// </summary>
    public bool? NotaryPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan qualifies as high cost under a state/county/local jurisdiction [HighCost.Local]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? OtherHighCostIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - There is a prepayment penalty and it will/will not be charged more than 36 months after consummation or account opening. [S32DISC.X180]
    /// </summary>
    public StringEnumValue<PenaltyChargeMoreThan36Months> PenaltyChargeMoreThan36Months { get => GetValue<StringEnumValue<PenaltyChargeMoreThan36Months>>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Pest Inspect To Be Financed [S32DISC.X90]
    /// </summary>
    public bool? PestInspectionFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Pest Inspect Lender/Brkr Rec Portion [S32DISC.X41]
    /// </summary>
    public bool? PestInspectionPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - Prepayment Penalty Amount Percentage of Amount Prepaid [S32DISC.X178]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepayPenaltyPercentofAmtPrepaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Proc Fee To Be Financed [S32DISC.X103]
    /// </summary>
    public bool? ProcessingFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Proc Fee Lender/Brkr Rec Portion [S32DISC.X102]
    /// </summary>
    public bool? ProcessingPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - Rate Set Index [S32DISC.X150]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateSetIndex { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Recording Fees To Be Financed [S32DISC.X85]
    /// </summary>
    public bool? RecordingFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Recording Fees Lender/Brkr Rec Portion [S32DISC.X36]
    /// </summary>
    public bool? RecordingPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Points/Fees Test Results [S32DISC.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ResultOfPointAndFees { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Security Yield Test Result [S32DISC.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ResultOfSecurityYieldTest { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan qualifies as high cost under Section 32 [HighCost.Federal]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? Section32Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Average Prime Offer Rate [3134]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Section35AveragePrimeRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Second Appraisal Required [3856]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<DoesOrDoesNot> Section35IsSecondAppraisalRequired { get => GetValue<StringEnumValue<DoesOrDoesNot>>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Date [3853]
    /// </summary>
    public DateTime? Section35PriorAcquisitionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Price [3854]
    /// </summary>
    public decimal? Section35PriorAcquisitionPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Source [3852]
    /// </summary>
    public string? Section35PriorAcquisitionSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 Security Yield Test Result [3135]
    /// </summary>
    public string? Section35ResultOfSecurityYieldTest { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 35 HPML Sales Contract Date [3855]
    /// </summary>
    public DateTime? Section35SalesContractDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 - Seller Paid Buydown included in 2015 Itemization Section 32 Points &amp; Fees. [S32DISC.X181]
    /// </summary>
    public bool? SellerPaidFeesImpacts { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 State Tax/Stamps To Be Financed [S32DISC.X87]
    /// </summary>
    public bool? StateTaxStampsFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 State Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X38]
    /// </summary>
    public bool? StateTaxStampsPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Survey To - To Be Financed [S32DISC.X89]
    /// </summary>
    public bool? SurveyFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Survey To Lender/Brkr Rec Portion [S32DISC.X40]
    /// </summary>
    public bool? SurveyPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Tax Svcing Fee To Be Financed [S32DISC.X59]
    /// </summary>
    public bool? TaxServiceFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Tax Svcing Fee Lender/Brkr Rec Portion [S32DISC.X8]
    /// </summary>
    public bool? TaxServicePortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Ins Binder To Be Financed [S32DISC.X143]
    /// </summary>
    public bool? TitleBinderFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Ins Binder Lender/Brkr Rec Portion [S32DISC.X142]
    /// </summary>
    public bool? TitleBinderPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Examination To Be Financed [S32DISC.X141]
    /// </summary>
    public bool? TitleExaminationFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Examination Lender/Brkr Rec Portion [S32DISC.X140]
    /// </summary>
    public bool? TitleExaminationPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Ins Lenders To Be Financed [S32DISC.X82]
    /// </summary>
    public bool? TitleInsuranceFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Title Ins Lenders Lender/Brkr Rec Portion [S32DISC.X33]
    /// </summary>
    public bool? TitleInsurancePortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Abst/Title Search To Be Financed [S32DISC.X139]
    /// </summary>
    public bool? TitleSearchFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Abst/Title Search Lender/Brkr Rec Portion [S32DISC.X138]
    /// </summary>
    public bool? TitleSearchPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Total Points/Fees Appl Under Section 32 [S32DISC.X48]
    /// </summary>
    public decimal? TotalPointsAndFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Treasury Security Yield % [S32DISC.X1]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TreasurySecurityYield { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Underwriting Fee To Be Financed [S32DISC.X60]
    /// </summary>
    public bool? UnderwritingFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Underwriting Fee Lender/Brkr Rec Portion [S32DISC.X9]
    /// </summary>
    public bool? UnderwritingPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg User Defined 1109 Borrower Paid Amount [S32DISC.X148]
    /// </summary>
    public decimal? UserDefined1109BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1109 To Be Financed [S32DISC.X84]
    /// </summary>
    public bool? UserDefined1109FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1109 Lender/Brkr Rec Portion [S32DISC.X35]
    /// </summary>
    public bool? UserDefined1109PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Mtg User Defined 1110 Borrower Paid Amount [S32DISC.X149]
    /// </summary>
    public decimal? UserDefined1110BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1110 To Be Financed [S32DISC.X107]
    /// </summary>
    public bool? UserDefined1110FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1110 Lender/Brkr Rec Portion [S32DISC.X106]
    /// </summary>
    public bool? UserDefined1110PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1111 To Be Financed [S32DISC.X113]
    /// </summary>
    public bool? UserDefined1111FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1111 Lender/Brkr Rec Portion [S32DISC.X112]
    /// </summary>
    public bool? UserDefined1111PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1112 To Be Financed [S32DISC.X115]
    /// </summary>
    public bool? UserDefined1112FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1112 Lender/Brkr Rec Portion [S32DISC.X114]
    /// </summary>
    public bool? UserDefined1112PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1113 To Be Financed [S32DISC.X117]
    /// </summary>
    public bool? UserDefined1113FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1113 Lender/Brkr Rec Portion [S32DISC.X116]
    /// </summary>
    public bool? UserDefined1113PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1114 To Be Financed [S32DISC.X119]
    /// </summary>
    public bool? UserDefined1114FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1114 Lender/Brkr Rec Portion [S32DISC.X118]
    /// </summary>
    public bool? UserDefined1114PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 1 To Be Financed [S32DISC.X88]
    /// </summary>
    public bool? UserDefined1204FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 1 Lender/Brkr Rec Portion [S32DISC.X39]
    /// </summary>
    public bool? UserDefined1204PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 2 To Be Financed [S32DISC.X109]
    /// </summary>
    public bool? UserDefined1205FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 2 Lender/Brkr Rec Portion [S32DISC.X108]
    /// </summary>
    public bool? UserDefined1205PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 3 To Be Financed [S32DISC.X111]
    /// </summary>
    public bool? UserDefined1206FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 User Def 3 Lender/Brkr Rec Portion [S32DISC.X110]
    /// </summary>
    public bool? UserDefined1206PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1303 To Be Financed [S32DISC.X93]
    /// </summary>
    public bool? UserDefined1303FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1303 Lender/Brkr Rec Portion [S32DISC.X44]
    /// </summary>
    public bool? UserDefined1303PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1304 To Be Financed [S32DISC.X94]
    /// </summary>
    public bool? UserDefined1304FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1304 Lender/Brkr Rec Portion [S32DISC.X45]
    /// </summary>
    public bool? UserDefined1304PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1305 To Be Financed [S32DISC.X95]
    /// </summary>
    public bool? UserDefined1305FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1305 Lender/Brkr Rec Portion [S32DISC.X46]
    /// </summary>
    public bool? UserDefined1305PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1306 To Be Financed [S32DISC.X96]
    /// </summary>
    public bool? UserDefined1306FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1306 Lender/Brkr Rec Portion [S32DISC.X47]
    /// </summary>
    public bool? UserDefined1306PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1307 To Be Financed [S32DISC.X121]
    /// </summary>
    public bool? UserDefined1307FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1307 Lender/Brkr Rec Portion [S32DISC.X120]
    /// </summary>
    public bool? UserDefined1307PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1308 To Be Financed [S32DISC.X123]
    /// </summary>
    public bool? UserDefined1308FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1308 Lender/Brkr Rec Portion [S32DISC.X122]
    /// </summary>
    public bool? UserDefined1308PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1309 To Be Financed [S32DISC.X125]
    /// </summary>
    public bool? UserDefined1309FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 1309 Lender/Brkr Rec Portion [S32DISC.X124]
    /// </summary>
    public bool? UserDefined1309PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 813 To Be Financed [S32DISC.X68]
    /// </summary>
    public bool? UserDefined813FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 813 Lender/Brkr Rec Portion [S32DISC.X17]
    /// </summary>
    public bool? UserDefined813PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 814 To Be Financed [S32DISC.X69]
    /// </summary>
    public bool? UserDefined814FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 814 Lender/Brkr Rec Portion [S32DISC.X18]
    /// </summary>
    public bool? UserDefined814PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 815 To Be Financed [S32DISC.X70]
    /// </summary>
    public bool? UserDefined815FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 815 Lender/Brkr Rec Portion [S32DISC.X19]
    /// </summary>
    public bool? UserDefined815PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 816 To Be Financed [S32DISC.X71]
    /// </summary>
    public bool? UserDefined816FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 816 Lender/Brkr Rec Portion [S32DISC.X20]
    /// </summary>
    public bool? UserDefined816PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 817 To Be Financed [S32DISC.X72]
    /// </summary>
    public bool? UserDefined817FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 817 Lender/Brkr Rec Portion [S32DISC.X21]
    /// </summary>
    public bool? UserDefined817PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 818 To Be Financed [S32DISC.X73]
    /// </summary>
    public bool? UserDefined818FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 818 Lender/Brkr Rec Portion [S32DISC.X22]
    /// </summary>
    public bool? UserDefined818PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 819 To Be Financed [S32DISC.X74]
    /// </summary>
    public bool? UserDefined819FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 819 Lender/Brkr Rec Portion [S32DISC.X23]
    /// </summary>
    public bool? UserDefined819PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 820 To Be Financed [S32DISC.X75]
    /// </summary>
    public bool? UserDefined820FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 820 Lender/Brkr Rec Portion [S32DISC.X24]
    /// </summary>
    public bool? UserDefined820PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 821 To Be Financed [S32DISC.X127]
    /// </summary>
    public bool? UserDefined821FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 821 Lender/Brkr Rec Portion [S32DISC.X126]
    /// </summary>
    public bool? UserDefined821PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 822 To Be Financed [S32DISC.X135]
    /// </summary>
    public bool? UserDefined822FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 822 Lender/Brkr Rec Portion [S32DISC.X134]
    /// </summary>
    public bool? UserDefined822PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 823 To Be Financed [S32DISC.X137]
    /// </summary>
    public bool? UserDefined823FeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Line 823 Lender/Brkr Rec Portion [S32DISC.X136]
    /// </summary>
    public bool? UserDefined823PortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Wire Trans Fee To Be Financed [S32DISC.X105]
    /// </summary>
    public bool? WireTransferFeeToBeFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Sec 32 Wire Trans Fee Lender/Brkr Rec Portion [S32DISC.X104]
    /// </summary>
    public bool? WireTransferPortionOfFeeIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}