using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Section32
/// </summary>
public sealed partial class Section32 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _appraisalFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _appraisalPortionOfFeeIndicator;
    private DirtyValue<decimal?>? _aprExceedsTsyForFirstMortgage;
    private DirtyValue<decimal?>? _aprExceedsTsyForSubordinateMortgage;
    private DirtyValue<bool?>? _assumptionFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _assumptionPortionOfFeeIndicator;
    private DirtyValue<bool?>? _attorneyFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _attorneyPortionOfFeeIndicator;
    private DirtyValue<bool?>? _cityCountyTaxStampsFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _cityCountyTaxStampsPortionOfFeeIndicator;
    private DirtyValue<bool?>? _closingFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _closingPortionOfFeeIndicator;
    private DirtyValue<bool?>? _creditReportFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _creditReportPortionOfFeeIndicator;
    private DirtyValue<bool?>? _docPrepFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _docPrepPortionOfFeeIndicator;
    private DirtyValue<StringEnumValue<DoesOrDoesNot2>>? _exceed2PercentPrepayPenalty;
    private DirtyValue<decimal?>? _hoepaAPR;
    private DirtyValue<decimal?>? _hoepaFee;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _jurisdications;
    private DirtyValue<bool?>? _lendersInspectionFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _lendersInspectionPortionOfFeeIndicator;
    private DirtyValue<bool?>? _loanDiscountFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _loanDiscountPortionOfFeeIndicator;
    private DirtyValue<bool?>? _loanOriginationFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _loanOriginationPortionOfFeeIndicator;
    private DirtyValue<string?>? _loanQualifyAsHighCostMortgage;
    private DirtyValue<decimal?>? _maximumPercentageOfLoan;
    private DirtyValue<decimal?>? _maximumPointsAndFees;
    private DirtyValue<bool?>? _mortgageBrokerFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _mortgageBrokerPortionOfFeeIndicator;
    private DirtyValue<bool?>? _mortgageInspectionFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _mortgageInspectionPortionOfFeeIndicator;
    private DirtyValue<bool?>? _mortgageInsuranceFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _mortgageInsurancePortionOfFeeIndicator;
    private DirtyValue<bool?>? _mortgageInsurancePremiumFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _mortgageInsurancePremiumPortionOfFeeIndicator;
    private DirtyValue<bool?>? _notaryFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _notaryPortionOfFeeIndicator;
    private DirtyValue<bool?>? _otherHighCostIndicator;
    private DirtyValue<StringEnumValue<PenaltyChargeMoreThan36Months>>? _penaltyChargeMoreThan36Months;
    private DirtyValue<bool?>? _pestInspectionFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _pestInspectionPortionOfFeeIndicator;
    private DirtyValue<decimal?>? _prepayPenaltyPercentofAmtPrepaid;
    private DirtyValue<bool?>? _processingFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _processingPortionOfFeeIndicator;
    private DirtyValue<decimal?>? _rateSetIndex;
    private DirtyValue<bool?>? _recordingFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _recordingPortionOfFeeIndicator;
    private DirtyValue<string?>? _resultOfPointAndFees;
    private DirtyValue<string?>? _resultOfSecurityYieldTest;
    private DirtyValue<bool?>? _section32Indicator;
    private DirtyValue<decimal?>? _section35AveragePrimeRate;
    private DirtyValue<StringEnumValue<DoesOrDoesNot>>? _section35IsSecondAppraisalRequired;
    private DirtyValue<DateTime?>? _section35PriorAcquisitionDate;
    private DirtyValue<decimal?>? _section35PriorAcquisitionPrice;
    private DirtyValue<string?>? _section35PriorAcquisitionSource;
    private DirtyValue<string?>? _section35ResultOfSecurityYieldTest;
    private DirtyValue<DateTime?>? _section35SalesContractDate;
    private DirtyValue<bool?>? _sellerPaidFeesImpacts;
    private DirtyValue<bool?>? _stateTaxStampsFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _stateTaxStampsPortionOfFeeIndicator;
    private DirtyValue<bool?>? _surveyFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _surveyPortionOfFeeIndicator;
    private DirtyValue<bool?>? _taxServiceFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _taxServicePortionOfFeeIndicator;
    private DirtyValue<bool?>? _titleBinderFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _titleBinderPortionOfFeeIndicator;
    private DirtyValue<bool?>? _titleExaminationFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _titleExaminationPortionOfFeeIndicator;
    private DirtyValue<bool?>? _titleInsuranceFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _titleInsurancePortionOfFeeIndicator;
    private DirtyValue<bool?>? _titleSearchFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _titleSearchPortionOfFeeIndicator;
    private DirtyValue<decimal?>? _totalPointsAndFees;
    private DirtyValue<decimal?>? _treasurySecurityYield;
    private DirtyValue<bool?>? _underwritingFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _underwritingPortionOfFeeIndicator;
    private DirtyValue<decimal?>? _userDefined1109BorPaidAmount;
    private DirtyValue<bool?>? _userDefined1109FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1109PortionOfFeeIndicator;
    private DirtyValue<decimal?>? _userDefined1110BorPaidAmount;
    private DirtyValue<bool?>? _userDefined1110FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1110PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1111FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1111PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1112FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1112PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1113FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1113PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1114FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1114PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1204FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1204PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1205FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1205PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1206FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1206PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1303FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1303PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1304FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1304PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1305FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1305PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1306FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1306PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1307FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1307PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1308FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1308PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined1309FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined1309PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined813FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined813PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined814FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined814PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined815FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined815PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined816FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined816PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined817FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined817PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined818FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined818PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined819FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined819PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined820FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined820PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined821FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined821PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined822FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined822PortionOfFeeIndicator;
    private DirtyValue<bool?>? _userDefined823FeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _userDefined823PortionOfFeeIndicator;
    private DirtyValue<bool?>? _wireTransferFeeToBeFinancedIndicator;
    private DirtyValue<bool?>? _wireTransferPortionOfFeeIndicator;

    /// <summary>
    /// Sec 32 Appraisal Fee To Be Financed [S32DISC.X76]
    /// </summary>
    public bool? AppraisalFeeToBeFinancedIndicator { get => _appraisalFeeToBeFinancedIndicator; set => SetField(ref _appraisalFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Appraisal Fee Lender/Brkr Rec Portion [S32DISC.X26]
    /// </summary>
    public bool? AppraisalPortionOfFeeIndicator { get => _appraisalPortionOfFeeIndicator; set => SetField(ref _appraisalPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 % Loan Exceeds Treasury Security Yield [S32DISC.X98]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprExceedsTsyForFirstMortgage { get => _aprExceedsTsyForFirstMortgage; set => SetField(ref _aprExceedsTsyForFirstMortgage, value); }

    /// <summary>
    /// Sec 32 Loan Exceeds % For Subordinate Mtgs [S32DISC.X99]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprExceedsTsyForSubordinateMortgage { get => _aprExceedsTsyForSubordinateMortgage; set => SetField(ref _aprExceedsTsyForSubordinateMortgage, value); }

    /// <summary>
    /// Sec 32 Assumption Fee To Be Financed [S32DISC.X131]
    /// </summary>
    public bool? AssumptionFeeToBeFinancedIndicator { get => _assumptionFeeToBeFinancedIndicator; set => SetField(ref _assumptionFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Assumption Fee Lender/Brkr Rec Portion [S32DISC.X130]
    /// </summary>
    public bool? AssumptionPortionOfFeeIndicator { get => _assumptionPortionOfFeeIndicator; set => SetField(ref _assumptionPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Attorney Fee To Be Financed [S32DISC.X133]
    /// </summary>
    public bool? AttorneyFeeToBeFinancedIndicator { get => _attorneyFeeToBeFinancedIndicator; set => SetField(ref _attorneyFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Attorney Fee Lender/Brkr Rec Portion [S32DISC.X132]
    /// </summary>
    public bool? AttorneyPortionOfFeeIndicator { get => _attorneyPortionOfFeeIndicator; set => SetField(ref _attorneyPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 City/County Tax/Stamps To Be Financed [S32DISC.X86]
    /// </summary>
    public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get => _cityCountyTaxStampsFeeToBeFinancedIndicator; set => SetField(ref _cityCountyTaxStampsFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 City/County Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X37]
    /// </summary>
    public bool? CityCountyTaxStampsPortionOfFeeIndicator { get => _cityCountyTaxStampsPortionOfFeeIndicator; set => SetField(ref _cityCountyTaxStampsPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Closing/Escrow Fee To Be Financed [S32DISC.X78]
    /// </summary>
    public bool? ClosingFeeToBeFinancedIndicator { get => _closingFeeToBeFinancedIndicator; set => SetField(ref _closingFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Closing/Escrow Fee Lender/Brkr Rec Portion [S32DISC.X29]
    /// </summary>
    public bool? ClosingPortionOfFeeIndicator { get => _closingPortionOfFeeIndicator; set => SetField(ref _closingPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Credit Report To Be Financed [S32DISC.X77]
    /// </summary>
    public bool? CreditReportFeeToBeFinancedIndicator { get => _creditReportFeeToBeFinancedIndicator; set => SetField(ref _creditReportFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Credit Report Lender/Brkr Rec Portion [S32DISC.X28]
    /// </summary>
    public bool? CreditReportPortionOfFeeIndicator { get => _creditReportPortionOfFeeIndicator; set => SetField(ref _creditReportPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Doc Prep Fee To Be Financed [S32DISC.X79]
    /// </summary>
    public bool? DocPrepFeeToBeFinancedIndicator { get => _docPrepFeeToBeFinancedIndicator; set => SetField(ref _docPrepFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Doc Prep Fee Lender/Brkr Rec Portion [S32DISC.X30]
    /// </summary>
    public bool? DocPrepPortionOfFeeIndicator { get => _docPrepPortionOfFeeIndicator; set => SetField(ref _docPrepPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 - Maximum Prepayment Penalty does/does not exceed 2% of the amount prepaid [S32DISC.X179]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> Exceed2PercentPrepayPenalty { get => _exceed2PercentPrepayPenalty; set => SetField(ref _exceed2PercentPrepayPenalty, value); }

    /// <summary>
    /// Sec 32 - HOEPA APR [S32DISC.X177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HoepaAPR { get => _hoepaAPR; set => SetField(ref _hoepaAPR, value); }

    /// <summary>
    /// Sec 32 Current HOEPA Fee Trigger [S32DISC.X50]
    /// </summary>
    public decimal? HoepaFee { get => _hoepaFee; set => SetField(ref _hoepaFee, value); }

    /// <summary>
    /// Section32 Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Jurisdictions under which loan qualifies as high cost [HighCost.Jurisdications]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Jurisdications { get => _jurisdications; set => SetField(ref _jurisdications, value); }

    /// <summary>
    /// Sec 32 Lenders Inspect Fee To Be Financed [S32DISC.X58]
    /// </summary>
    public bool? LendersInspectionFeeToBeFinancedIndicator { get => _lendersInspectionFeeToBeFinancedIndicator; set => SetField(ref _lendersInspectionFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Lenders Inspect Fee Lender/Brkr Rec Portion [S32DISC.X7]
    /// </summary>
    public bool? LendersInspectionPortionOfFeeIndicator { get => _lendersInspectionPortionOfFeeIndicator; set => SetField(ref _lendersInspectionPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Loan Discount Fee To Be Financed [S32DISC.X55]
    /// </summary>
    public bool? LoanDiscountFeeToBeFinancedIndicator { get => _loanDiscountFeeToBeFinancedIndicator; set => SetField(ref _loanDiscountFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Loan Discount Fee Lender/Brkr Rec Portion [S32DISC.X4]
    /// </summary>
    public bool? LoanDiscountPortionOfFeeIndicator { get => _loanDiscountPortionOfFeeIndicator; set => SetField(ref _loanDiscountPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Loan Orig Fee To Be Financed [S32DISC.X54]
    /// </summary>
    public bool? LoanOriginationFeeToBeFinancedIndicator { get => _loanOriginationFeeToBeFinancedIndicator; set => SetField(ref _loanOriginationFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Loan Orig Fee Lender/Brkr Rec Portion [S32DISC.X3]
    /// </summary>
    public bool? LoanOriginationPortionOfFeeIndicator { get => _loanOriginationPortionOfFeeIndicator; set => SetField(ref _loanOriginationPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Qualifies as High Cost Mtg Under Section 32 [S32DISC.X51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanQualifyAsHighCostMortgage { get => _loanQualifyAsHighCostMortgage; set => SetField(ref _loanQualifyAsHighCostMortgage, value); }

    /// <summary>
    /// Sec 32 Max % of Loan Amt for Allowed Fees [S32DISC.X100]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumPercentageOfLoan { get => _maximumPercentageOfLoan; set => SetField(ref _maximumPercentageOfLoan, value); }

    /// <summary>
    /// Sec 32 Max Allowed Points/Fees [S32DISC.X101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumPointsAndFees { get => _maximumPointsAndFees; set => SetField(ref _maximumPointsAndFees, value); }

    /// <summary>
    /// Sec 32 Mtg Broker Fee To Be Financed [S32DISC.X66]
    /// </summary>
    public bool? MortgageBrokerFeeToBeFinancedIndicator { get => _mortgageBrokerFeeToBeFinancedIndicator; set => SetField(ref _mortgageBrokerFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg Broker Fee Lender/Brkr Rec Portion [S32DISC.X15]
    /// </summary>
    public bool? MortgageBrokerPortionOfFeeIndicator { get => _mortgageBrokerPortionOfFeeIndicator; set => SetField(ref _mortgageBrokerPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 MI Application Fee To Be Financed [S32DISC.X129]
    /// </summary>
    public bool? MortgageInspectionFeeToBeFinancedIndicator { get => _mortgageInspectionFeeToBeFinancedIndicator; set => SetField(ref _mortgageInspectionFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 MI Application Fee Lender/Brkr Rec Portion [S32DISC.X128]
    /// </summary>
    public bool? MortgageInspectionPortionOfFeeIndicator { get => _mortgageInspectionPortionOfFeeIndicator; set => SetField(ref _mortgageInspectionPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg Ins To Be Financed [S32DISC.X147]
    /// </summary>
    public bool? MortgageInsuranceFeeToBeFinancedIndicator { get => _mortgageInsuranceFeeToBeFinancedIndicator; set => SetField(ref _mortgageInsuranceFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg Ins Lender/Brkr Rec Portion [S32DISC.X146]
    /// </summary>
    public bool? MortgageInsurancePortionOfFeeIndicator { get => _mortgageInsurancePortionOfFeeIndicator; set => SetField(ref _mortgageInsurancePortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg Ins Prem To Be Financed [S32DISC.X145]
    /// </summary>
    public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get => _mortgageInsurancePremiumFeeToBeFinancedIndicator; set => SetField(ref _mortgageInsurancePremiumFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg Ins Prem Lender/Brkr Rec Portion [S32DISC.X144]
    /// </summary>
    public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get => _mortgageInsurancePremiumPortionOfFeeIndicator; set => SetField(ref _mortgageInsurancePremiumPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Notary Fees To Be Financed [S32DISC.X80]
    /// </summary>
    public bool? NotaryFeeToBeFinancedIndicator { get => _notaryFeeToBeFinancedIndicator; set => SetField(ref _notaryFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Notary Fees Lender/Brkr Rec Portion [S32DISC.X31]
    /// </summary>
    public bool? NotaryPortionOfFeeIndicator { get => _notaryPortionOfFeeIndicator; set => SetField(ref _notaryPortionOfFeeIndicator, value); }

    /// <summary>
    /// Loan qualifies as high cost under a state/county/local jurisdiction [HighCost.Local]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? OtherHighCostIndicator { get => _otherHighCostIndicator; set => SetField(ref _otherHighCostIndicator, value); }

    /// <summary>
    /// Sec 32 - There is a prepayment penalty and it will/will not be charged more than 36 months after consummation or account opening. [S32DISC.X180]
    /// </summary>
    public StringEnumValue<PenaltyChargeMoreThan36Months> PenaltyChargeMoreThan36Months { get => _penaltyChargeMoreThan36Months; set => SetField(ref _penaltyChargeMoreThan36Months, value); }

    /// <summary>
    /// Sec 32 Pest Inspect To Be Financed [S32DISC.X90]
    /// </summary>
    public bool? PestInspectionFeeToBeFinancedIndicator { get => _pestInspectionFeeToBeFinancedIndicator; set => SetField(ref _pestInspectionFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Pest Inspect Lender/Brkr Rec Portion [S32DISC.X41]
    /// </summary>
    public bool? PestInspectionPortionOfFeeIndicator { get => _pestInspectionPortionOfFeeIndicator; set => SetField(ref _pestInspectionPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 - Prepayment Penalty Amount Percentage of Amount Prepaid [S32DISC.X178]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepayPenaltyPercentofAmtPrepaid { get => _prepayPenaltyPercentofAmtPrepaid; set => SetField(ref _prepayPenaltyPercentofAmtPrepaid, value); }

    /// <summary>
    /// Sec 32 Proc Fee To Be Financed [S32DISC.X103]
    /// </summary>
    public bool? ProcessingFeeToBeFinancedIndicator { get => _processingFeeToBeFinancedIndicator; set => SetField(ref _processingFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Proc Fee Lender/Brkr Rec Portion [S32DISC.X102]
    /// </summary>
    public bool? ProcessingPortionOfFeeIndicator { get => _processingPortionOfFeeIndicator; set => SetField(ref _processingPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 - Rate Set Index [S32DISC.X150]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateSetIndex { get => _rateSetIndex; set => SetField(ref _rateSetIndex, value); }

    /// <summary>
    /// Sec 32 Recording Fees To Be Financed [S32DISC.X85]
    /// </summary>
    public bool? RecordingFeeToBeFinancedIndicator { get => _recordingFeeToBeFinancedIndicator; set => SetField(ref _recordingFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Recording Fees Lender/Brkr Rec Portion [S32DISC.X36]
    /// </summary>
    public bool? RecordingPortionOfFeeIndicator { get => _recordingPortionOfFeeIndicator; set => SetField(ref _recordingPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Points/Fees Test Results [S32DISC.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ResultOfPointAndFees { get => _resultOfPointAndFees; set => SetField(ref _resultOfPointAndFees, value); }

    /// <summary>
    /// Sec 32 Security Yield Test Result [S32DISC.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ResultOfSecurityYieldTest { get => _resultOfSecurityYieldTest; set => SetField(ref _resultOfSecurityYieldTest, value); }

    /// <summary>
    /// Loan qualifies as high cost under Section 32 [HighCost.Federal]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? Section32Indicator { get => _section32Indicator; set => SetField(ref _section32Indicator, value); }

    /// <summary>
    /// Sec 35 HPML Average Prime Offer Rate [3134]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Section35AveragePrimeRate { get => _section35AveragePrimeRate; set => SetField(ref _section35AveragePrimeRate, value); }

    /// <summary>
    /// Sec 35 HPML Second Appraisal Required [3856]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<DoesOrDoesNot> Section35IsSecondAppraisalRequired { get => _section35IsSecondAppraisalRequired; set => SetField(ref _section35IsSecondAppraisalRequired, value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Date [3853]
    /// </summary>
    public DateTime? Section35PriorAcquisitionDate { get => _section35PriorAcquisitionDate; set => SetField(ref _section35PriorAcquisitionDate, value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Price [3854]
    /// </summary>
    public decimal? Section35PriorAcquisitionPrice { get => _section35PriorAcquisitionPrice; set => SetField(ref _section35PriorAcquisitionPrice, value); }

    /// <summary>
    /// Sec 35 HPML Prior Acquisition Source [3852]
    /// </summary>
    public string? Section35PriorAcquisitionSource { get => _section35PriorAcquisitionSource; set => SetField(ref _section35PriorAcquisitionSource, value); }

    /// <summary>
    /// Sec 35 Security Yield Test Result [3135]
    /// </summary>
    public string? Section35ResultOfSecurityYieldTest { get => _section35ResultOfSecurityYieldTest; set => SetField(ref _section35ResultOfSecurityYieldTest, value); }

    /// <summary>
    /// Sec 35 HPML Sales Contract Date [3855]
    /// </summary>
    public DateTime? Section35SalesContractDate { get => _section35SalesContractDate; set => SetField(ref _section35SalesContractDate, value); }

    /// <summary>
    /// Sec 32 - Seller Paid Buydown included in 2015 Itemization Section 32 Points &amp; Fees. [S32DISC.X181]
    /// </summary>
    public bool? SellerPaidFeesImpacts { get => _sellerPaidFeesImpacts; set => SetField(ref _sellerPaidFeesImpacts, value); }

    /// <summary>
    /// Sec 32 State Tax/Stamps To Be Financed [S32DISC.X87]
    /// </summary>
    public bool? StateTaxStampsFeeToBeFinancedIndicator { get => _stateTaxStampsFeeToBeFinancedIndicator; set => SetField(ref _stateTaxStampsFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 State Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X38]
    /// </summary>
    public bool? StateTaxStampsPortionOfFeeIndicator { get => _stateTaxStampsPortionOfFeeIndicator; set => SetField(ref _stateTaxStampsPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Survey To - To Be Financed [S32DISC.X89]
    /// </summary>
    public bool? SurveyFeeToBeFinancedIndicator { get => _surveyFeeToBeFinancedIndicator; set => SetField(ref _surveyFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Survey To Lender/Brkr Rec Portion [S32DISC.X40]
    /// </summary>
    public bool? SurveyPortionOfFeeIndicator { get => _surveyPortionOfFeeIndicator; set => SetField(ref _surveyPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Tax Svcing Fee To Be Financed [S32DISC.X59]
    /// </summary>
    public bool? TaxServiceFeeToBeFinancedIndicator { get => _taxServiceFeeToBeFinancedIndicator; set => SetField(ref _taxServiceFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Tax Svcing Fee Lender/Brkr Rec Portion [S32DISC.X8]
    /// </summary>
    public bool? TaxServicePortionOfFeeIndicator { get => _taxServicePortionOfFeeIndicator; set => SetField(ref _taxServicePortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Title Ins Binder To Be Financed [S32DISC.X143]
    /// </summary>
    public bool? TitleBinderFeeToBeFinancedIndicator { get => _titleBinderFeeToBeFinancedIndicator; set => SetField(ref _titleBinderFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Title Ins Binder Lender/Brkr Rec Portion [S32DISC.X142]
    /// </summary>
    public bool? TitleBinderPortionOfFeeIndicator { get => _titleBinderPortionOfFeeIndicator; set => SetField(ref _titleBinderPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Title Examination To Be Financed [S32DISC.X141]
    /// </summary>
    public bool? TitleExaminationFeeToBeFinancedIndicator { get => _titleExaminationFeeToBeFinancedIndicator; set => SetField(ref _titleExaminationFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Title Examination Lender/Brkr Rec Portion [S32DISC.X140]
    /// </summary>
    public bool? TitleExaminationPortionOfFeeIndicator { get => _titleExaminationPortionOfFeeIndicator; set => SetField(ref _titleExaminationPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Title Ins Lenders To Be Financed [S32DISC.X82]
    /// </summary>
    public bool? TitleInsuranceFeeToBeFinancedIndicator { get => _titleInsuranceFeeToBeFinancedIndicator; set => SetField(ref _titleInsuranceFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Title Ins Lenders Lender/Brkr Rec Portion [S32DISC.X33]
    /// </summary>
    public bool? TitleInsurancePortionOfFeeIndicator { get => _titleInsurancePortionOfFeeIndicator; set => SetField(ref _titleInsurancePortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Abst/Title Search To Be Financed [S32DISC.X139]
    /// </summary>
    public bool? TitleSearchFeeToBeFinancedIndicator { get => _titleSearchFeeToBeFinancedIndicator; set => SetField(ref _titleSearchFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Abst/Title Search Lender/Brkr Rec Portion [S32DISC.X138]
    /// </summary>
    public bool? TitleSearchPortionOfFeeIndicator { get => _titleSearchPortionOfFeeIndicator; set => SetField(ref _titleSearchPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Total Points/Fees Appl Under Section 32 [S32DISC.X48]
    /// </summary>
    public decimal? TotalPointsAndFees { get => _totalPointsAndFees; set => SetField(ref _totalPointsAndFees, value); }

    /// <summary>
    /// Sec 32 Treasury Security Yield % [S32DISC.X1]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TreasurySecurityYield { get => _treasurySecurityYield; set => SetField(ref _treasurySecurityYield, value); }

    /// <summary>
    /// Sec 32 Underwriting Fee To Be Financed [S32DISC.X60]
    /// </summary>
    public bool? UnderwritingFeeToBeFinancedIndicator { get => _underwritingFeeToBeFinancedIndicator; set => SetField(ref _underwritingFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Underwriting Fee Lender/Brkr Rec Portion [S32DISC.X9]
    /// </summary>
    public bool? UnderwritingPortionOfFeeIndicator { get => _underwritingPortionOfFeeIndicator; set => SetField(ref _underwritingPortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg User Defined 1109 Borrower Paid Amount [S32DISC.X148]
    /// </summary>
    public decimal? UserDefined1109BorPaidAmount { get => _userDefined1109BorPaidAmount; set => SetField(ref _userDefined1109BorPaidAmount, value); }

    /// <summary>
    /// Sec 32 Line 1109 To Be Financed [S32DISC.X84]
    /// </summary>
    public bool? UserDefined1109FeeToBeFinancedIndicator { get => _userDefined1109FeeToBeFinancedIndicator; set => SetField(ref _userDefined1109FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1109 Lender/Brkr Rec Portion [S32DISC.X35]
    /// </summary>
    public bool? UserDefined1109PortionOfFeeIndicator { get => _userDefined1109PortionOfFeeIndicator; set => SetField(ref _userDefined1109PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Mtg User Defined 1110 Borrower Paid Amount [S32DISC.X149]
    /// </summary>
    public decimal? UserDefined1110BorPaidAmount { get => _userDefined1110BorPaidAmount; set => SetField(ref _userDefined1110BorPaidAmount, value); }

    /// <summary>
    /// Sec 32 Line 1110 To Be Financed [S32DISC.X107]
    /// </summary>
    public bool? UserDefined1110FeeToBeFinancedIndicator { get => _userDefined1110FeeToBeFinancedIndicator; set => SetField(ref _userDefined1110FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1110 Lender/Brkr Rec Portion [S32DISC.X106]
    /// </summary>
    public bool? UserDefined1110PortionOfFeeIndicator { get => _userDefined1110PortionOfFeeIndicator; set => SetField(ref _userDefined1110PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1111 To Be Financed [S32DISC.X113]
    /// </summary>
    public bool? UserDefined1111FeeToBeFinancedIndicator { get => _userDefined1111FeeToBeFinancedIndicator; set => SetField(ref _userDefined1111FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1111 Lender/Brkr Rec Portion [S32DISC.X112]
    /// </summary>
    public bool? UserDefined1111PortionOfFeeIndicator { get => _userDefined1111PortionOfFeeIndicator; set => SetField(ref _userDefined1111PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1112 To Be Financed [S32DISC.X115]
    /// </summary>
    public bool? UserDefined1112FeeToBeFinancedIndicator { get => _userDefined1112FeeToBeFinancedIndicator; set => SetField(ref _userDefined1112FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1112 Lender/Brkr Rec Portion [S32DISC.X114]
    /// </summary>
    public bool? UserDefined1112PortionOfFeeIndicator { get => _userDefined1112PortionOfFeeIndicator; set => SetField(ref _userDefined1112PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1113 To Be Financed [S32DISC.X117]
    /// </summary>
    public bool? UserDefined1113FeeToBeFinancedIndicator { get => _userDefined1113FeeToBeFinancedIndicator; set => SetField(ref _userDefined1113FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1113 Lender/Brkr Rec Portion [S32DISC.X116]
    /// </summary>
    public bool? UserDefined1113PortionOfFeeIndicator { get => _userDefined1113PortionOfFeeIndicator; set => SetField(ref _userDefined1113PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1114 To Be Financed [S32DISC.X119]
    /// </summary>
    public bool? UserDefined1114FeeToBeFinancedIndicator { get => _userDefined1114FeeToBeFinancedIndicator; set => SetField(ref _userDefined1114FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1114 Lender/Brkr Rec Portion [S32DISC.X118]
    /// </summary>
    public bool? UserDefined1114PortionOfFeeIndicator { get => _userDefined1114PortionOfFeeIndicator; set => SetField(ref _userDefined1114PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 1 To Be Financed [S32DISC.X88]
    /// </summary>
    public bool? UserDefined1204FeeToBeFinancedIndicator { get => _userDefined1204FeeToBeFinancedIndicator; set => SetField(ref _userDefined1204FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 1 Lender/Brkr Rec Portion [S32DISC.X39]
    /// </summary>
    public bool? UserDefined1204PortionOfFeeIndicator { get => _userDefined1204PortionOfFeeIndicator; set => SetField(ref _userDefined1204PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 2 To Be Financed [S32DISC.X109]
    /// </summary>
    public bool? UserDefined1205FeeToBeFinancedIndicator { get => _userDefined1205FeeToBeFinancedIndicator; set => SetField(ref _userDefined1205FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 2 Lender/Brkr Rec Portion [S32DISC.X108]
    /// </summary>
    public bool? UserDefined1205PortionOfFeeIndicator { get => _userDefined1205PortionOfFeeIndicator; set => SetField(ref _userDefined1205PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 3 To Be Financed [S32DISC.X111]
    /// </summary>
    public bool? UserDefined1206FeeToBeFinancedIndicator { get => _userDefined1206FeeToBeFinancedIndicator; set => SetField(ref _userDefined1206FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 User Def 3 Lender/Brkr Rec Portion [S32DISC.X110]
    /// </summary>
    public bool? UserDefined1206PortionOfFeeIndicator { get => _userDefined1206PortionOfFeeIndicator; set => SetField(ref _userDefined1206PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1303 To Be Financed [S32DISC.X93]
    /// </summary>
    public bool? UserDefined1303FeeToBeFinancedIndicator { get => _userDefined1303FeeToBeFinancedIndicator; set => SetField(ref _userDefined1303FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1303 Lender/Brkr Rec Portion [S32DISC.X44]
    /// </summary>
    public bool? UserDefined1303PortionOfFeeIndicator { get => _userDefined1303PortionOfFeeIndicator; set => SetField(ref _userDefined1303PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1304 To Be Financed [S32DISC.X94]
    /// </summary>
    public bool? UserDefined1304FeeToBeFinancedIndicator { get => _userDefined1304FeeToBeFinancedIndicator; set => SetField(ref _userDefined1304FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1304 Lender/Brkr Rec Portion [S32DISC.X45]
    /// </summary>
    public bool? UserDefined1304PortionOfFeeIndicator { get => _userDefined1304PortionOfFeeIndicator; set => SetField(ref _userDefined1304PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1305 To Be Financed [S32DISC.X95]
    /// </summary>
    public bool? UserDefined1305FeeToBeFinancedIndicator { get => _userDefined1305FeeToBeFinancedIndicator; set => SetField(ref _userDefined1305FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1305 Lender/Brkr Rec Portion [S32DISC.X46]
    /// </summary>
    public bool? UserDefined1305PortionOfFeeIndicator { get => _userDefined1305PortionOfFeeIndicator; set => SetField(ref _userDefined1305PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1306 To Be Financed [S32DISC.X96]
    /// </summary>
    public bool? UserDefined1306FeeToBeFinancedIndicator { get => _userDefined1306FeeToBeFinancedIndicator; set => SetField(ref _userDefined1306FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1306 Lender/Brkr Rec Portion [S32DISC.X47]
    /// </summary>
    public bool? UserDefined1306PortionOfFeeIndicator { get => _userDefined1306PortionOfFeeIndicator; set => SetField(ref _userDefined1306PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1307 To Be Financed [S32DISC.X121]
    /// </summary>
    public bool? UserDefined1307FeeToBeFinancedIndicator { get => _userDefined1307FeeToBeFinancedIndicator; set => SetField(ref _userDefined1307FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1307 Lender/Brkr Rec Portion [S32DISC.X120]
    /// </summary>
    public bool? UserDefined1307PortionOfFeeIndicator { get => _userDefined1307PortionOfFeeIndicator; set => SetField(ref _userDefined1307PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1308 To Be Financed [S32DISC.X123]
    /// </summary>
    public bool? UserDefined1308FeeToBeFinancedIndicator { get => _userDefined1308FeeToBeFinancedIndicator; set => SetField(ref _userDefined1308FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1308 Lender/Brkr Rec Portion [S32DISC.X122]
    /// </summary>
    public bool? UserDefined1308PortionOfFeeIndicator { get => _userDefined1308PortionOfFeeIndicator; set => SetField(ref _userDefined1308PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1309 To Be Financed [S32DISC.X125]
    /// </summary>
    public bool? UserDefined1309FeeToBeFinancedIndicator { get => _userDefined1309FeeToBeFinancedIndicator; set => SetField(ref _userDefined1309FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 1309 Lender/Brkr Rec Portion [S32DISC.X124]
    /// </summary>
    public bool? UserDefined1309PortionOfFeeIndicator { get => _userDefined1309PortionOfFeeIndicator; set => SetField(ref _userDefined1309PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 813 To Be Financed [S32DISC.X68]
    /// </summary>
    public bool? UserDefined813FeeToBeFinancedIndicator { get => _userDefined813FeeToBeFinancedIndicator; set => SetField(ref _userDefined813FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 813 Lender/Brkr Rec Portion [S32DISC.X17]
    /// </summary>
    public bool? UserDefined813PortionOfFeeIndicator { get => _userDefined813PortionOfFeeIndicator; set => SetField(ref _userDefined813PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 814 To Be Financed [S32DISC.X69]
    /// </summary>
    public bool? UserDefined814FeeToBeFinancedIndicator { get => _userDefined814FeeToBeFinancedIndicator; set => SetField(ref _userDefined814FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 814 Lender/Brkr Rec Portion [S32DISC.X18]
    /// </summary>
    public bool? UserDefined814PortionOfFeeIndicator { get => _userDefined814PortionOfFeeIndicator; set => SetField(ref _userDefined814PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 815 To Be Financed [S32DISC.X70]
    /// </summary>
    public bool? UserDefined815FeeToBeFinancedIndicator { get => _userDefined815FeeToBeFinancedIndicator; set => SetField(ref _userDefined815FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 815 Lender/Brkr Rec Portion [S32DISC.X19]
    /// </summary>
    public bool? UserDefined815PortionOfFeeIndicator { get => _userDefined815PortionOfFeeIndicator; set => SetField(ref _userDefined815PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 816 To Be Financed [S32DISC.X71]
    /// </summary>
    public bool? UserDefined816FeeToBeFinancedIndicator { get => _userDefined816FeeToBeFinancedIndicator; set => SetField(ref _userDefined816FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 816 Lender/Brkr Rec Portion [S32DISC.X20]
    /// </summary>
    public bool? UserDefined816PortionOfFeeIndicator { get => _userDefined816PortionOfFeeIndicator; set => SetField(ref _userDefined816PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 817 To Be Financed [S32DISC.X72]
    /// </summary>
    public bool? UserDefined817FeeToBeFinancedIndicator { get => _userDefined817FeeToBeFinancedIndicator; set => SetField(ref _userDefined817FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 817 Lender/Brkr Rec Portion [S32DISC.X21]
    /// </summary>
    public bool? UserDefined817PortionOfFeeIndicator { get => _userDefined817PortionOfFeeIndicator; set => SetField(ref _userDefined817PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 818 To Be Financed [S32DISC.X73]
    /// </summary>
    public bool? UserDefined818FeeToBeFinancedIndicator { get => _userDefined818FeeToBeFinancedIndicator; set => SetField(ref _userDefined818FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 818 Lender/Brkr Rec Portion [S32DISC.X22]
    /// </summary>
    public bool? UserDefined818PortionOfFeeIndicator { get => _userDefined818PortionOfFeeIndicator; set => SetField(ref _userDefined818PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 819 To Be Financed [S32DISC.X74]
    /// </summary>
    public bool? UserDefined819FeeToBeFinancedIndicator { get => _userDefined819FeeToBeFinancedIndicator; set => SetField(ref _userDefined819FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 819 Lender/Brkr Rec Portion [S32DISC.X23]
    /// </summary>
    public bool? UserDefined819PortionOfFeeIndicator { get => _userDefined819PortionOfFeeIndicator; set => SetField(ref _userDefined819PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 820 To Be Financed [S32DISC.X75]
    /// </summary>
    public bool? UserDefined820FeeToBeFinancedIndicator { get => _userDefined820FeeToBeFinancedIndicator; set => SetField(ref _userDefined820FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 820 Lender/Brkr Rec Portion [S32DISC.X24]
    /// </summary>
    public bool? UserDefined820PortionOfFeeIndicator { get => _userDefined820PortionOfFeeIndicator; set => SetField(ref _userDefined820PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 821 To Be Financed [S32DISC.X127]
    /// </summary>
    public bool? UserDefined821FeeToBeFinancedIndicator { get => _userDefined821FeeToBeFinancedIndicator; set => SetField(ref _userDefined821FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 821 Lender/Brkr Rec Portion [S32DISC.X126]
    /// </summary>
    public bool? UserDefined821PortionOfFeeIndicator { get => _userDefined821PortionOfFeeIndicator; set => SetField(ref _userDefined821PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 822 To Be Financed [S32DISC.X135]
    /// </summary>
    public bool? UserDefined822FeeToBeFinancedIndicator { get => _userDefined822FeeToBeFinancedIndicator; set => SetField(ref _userDefined822FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 822 Lender/Brkr Rec Portion [S32DISC.X134]
    /// </summary>
    public bool? UserDefined822PortionOfFeeIndicator { get => _userDefined822PortionOfFeeIndicator; set => SetField(ref _userDefined822PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Line 823 To Be Financed [S32DISC.X137]
    /// </summary>
    public bool? UserDefined823FeeToBeFinancedIndicator { get => _userDefined823FeeToBeFinancedIndicator; set => SetField(ref _userDefined823FeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Line 823 Lender/Brkr Rec Portion [S32DISC.X136]
    /// </summary>
    public bool? UserDefined823PortionOfFeeIndicator { get => _userDefined823PortionOfFeeIndicator; set => SetField(ref _userDefined823PortionOfFeeIndicator, value); }

    /// <summary>
    /// Sec 32 Wire Trans Fee To Be Financed [S32DISC.X105]
    /// </summary>
    public bool? WireTransferFeeToBeFinancedIndicator { get => _wireTransferFeeToBeFinancedIndicator; set => SetField(ref _wireTransferFeeToBeFinancedIndicator, value); }

    /// <summary>
    /// Sec 32 Wire Trans Fee Lender/Brkr Rec Portion [S32DISC.X104]
    /// </summary>
    public bool? WireTransferPortionOfFeeIndicator { get => _wireTransferPortionOfFeeIndicator; set => SetField(ref _wireTransferPortionOfFeeIndicator, value); }
}