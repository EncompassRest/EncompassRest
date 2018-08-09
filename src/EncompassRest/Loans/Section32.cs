using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Section32
    /// </summary>
    public sealed partial class Section32 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _appraisalFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Appraisal Fee To Be Financed [S32DISC.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Appraisal Fee To Be Financed")]
        public bool? AppraisalFeeToBeFinancedIndicator { get => _appraisalFeeToBeFinancedIndicator; set => _appraisalFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _appraisalPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Appraisal Fee Lender/Brkr Rec Portion [S32DISC.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Appraisal Fee Lender/Brkr Rec Portion")]
        public bool? AppraisalPortionOfFeeIndicator { get => _appraisalPortionOfFeeIndicator; set => _appraisalPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _aprExceedsTsyForFirstMortgage;
        /// <summary>
        /// Sec 32 % Loan Exceeds Treasury Security Yield [S32DISC.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 % Loan Exceeds Treasury Security Yield")]
        public decimal? AprExceedsTsyForFirstMortgage { get => _aprExceedsTsyForFirstMortgage; set => _aprExceedsTsyForFirstMortgage = value; }
        private DirtyValue<decimal?> _aprExceedsTsyForSubordinateMortgage;
        /// <summary>
        /// Sec 32 Loan Exceeds % For Subordinate Mtgs [S32DISC.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 Loan Exceeds % For Subordinate Mtgs")]
        public decimal? AprExceedsTsyForSubordinateMortgage { get => _aprExceedsTsyForSubordinateMortgage; set => _aprExceedsTsyForSubordinateMortgage = value; }
        private DirtyValue<bool?> _assumptionFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Assumption Fee To Be Financed [S32DISC.X131]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Assumption Fee To Be Financed")]
        public bool? AssumptionFeeToBeFinancedIndicator { get => _assumptionFeeToBeFinancedIndicator; set => _assumptionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _assumptionPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Assumption Fee Lender/Brkr Rec Portion [S32DISC.X130]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Assumption Fee Lender/Brkr Rec Portion")]
        public bool? AssumptionPortionOfFeeIndicator { get => _assumptionPortionOfFeeIndicator; set => _assumptionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _attorneyFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Attorney Fee To Be Financed [S32DISC.X133]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Attorney Fee To Be Financed")]
        public bool? AttorneyFeeToBeFinancedIndicator { get => _attorneyFeeToBeFinancedIndicator; set => _attorneyFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _attorneyPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Attorney Fee Lender/Brkr Rec Portion [S32DISC.X132]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Attorney Fee Lender/Brkr Rec Portion")]
        public bool? AttorneyPortionOfFeeIndicator { get => _attorneyPortionOfFeeIndicator; set => _attorneyPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _cityCountyTaxStampsFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 City/County Tax/Stamps To Be Financed [S32DISC.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 City/County Tax/Stamps To Be Financed")]
        public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get => _cityCountyTaxStampsFeeToBeFinancedIndicator; set => _cityCountyTaxStampsFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _cityCountyTaxStampsPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 City/County Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 City/County Tax/Stamps Lender/Brkr Rec Portion")]
        public bool? CityCountyTaxStampsPortionOfFeeIndicator { get => _cityCountyTaxStampsPortionOfFeeIndicator; set => _cityCountyTaxStampsPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _closingFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Closing/Escrow Fee To Be Financed [S32DISC.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Closing/Escrow Fee To Be Financed")]
        public bool? ClosingFeeToBeFinancedIndicator { get => _closingFeeToBeFinancedIndicator; set => _closingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _closingPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Closing/Escrow Fee Lender/Brkr Rec Portion [S32DISC.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Closing/Escrow Fee Lender/Brkr Rec Portion")]
        public bool? ClosingPortionOfFeeIndicator { get => _closingPortionOfFeeIndicator; set => _closingPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _creditReportFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Credit Report To Be Financed [S32DISC.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Credit Report To Be Financed")]
        public bool? CreditReportFeeToBeFinancedIndicator { get => _creditReportFeeToBeFinancedIndicator; set => _creditReportFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _creditReportPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Credit Report Lender/Brkr Rec Portion [S32DISC.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Credit Report Lender/Brkr Rec Portion")]
        public bool? CreditReportPortionOfFeeIndicator { get => _creditReportPortionOfFeeIndicator; set => _creditReportPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _docPrepFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Doc Prep Fee To Be Financed [S32DISC.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Doc Prep Fee To Be Financed")]
        public bool? DocPrepFeeToBeFinancedIndicator { get => _docPrepFeeToBeFinancedIndicator; set => _docPrepFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _docPrepPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Doc Prep Fee Lender/Brkr Rec Portion [S32DISC.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Doc Prep Fee Lender/Brkr Rec Portion")]
        public bool? DocPrepPortionOfFeeIndicator { get => _docPrepPortionOfFeeIndicator; set => _docPrepPortionOfFeeIndicator = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _exceed2PercentPrepayPenalty;
        /// <summary>
        /// Sec 32 - Maximum Prepayment Penalty does/does not exceed 2% of the amount prepaid [S32DISC.X179]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 - Maximum Prepayment Penalty does/does not exceed 2% of the amount prepaid")]
        public StringEnumValue<DoesOrDoesNot2> Exceed2PercentPrepayPenalty { get => _exceed2PercentPrepayPenalty; set => _exceed2PercentPrepayPenalty = value; }
        private DirtyValue<decimal?> _hoepaAPR;
        /// <summary>
        /// Sec 32 - HOEPA APR [S32DISC.X177]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 - HOEPA APR")]
        public decimal? HoepaAPR { get => _hoepaAPR; set => _hoepaAPR = value; }
        private DirtyValue<decimal?> _hoepaFee;
        /// <summary>
        /// Sec 32 Current HOEPA Fee Trigger [S32DISC.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Sec 32 Current HOEPA Fee Trigger")]
        public decimal? HoepaFee { get => _hoepaFee; set => _hoepaFee = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Section32 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _jurisdications;
        /// <summary>
        /// Jurisdictions under which loan qualifies as high cost [HighCost.Jurisdications]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Jurisdictions under which loan qualifies as high cost")]
        public string Jurisdications { get => _jurisdications; set => _jurisdications = value; }
        private DirtyValue<bool?> _lendersInspectionFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Lenders Inspect Fee To Be Financed [S32DISC.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Lenders Inspect Fee To Be Financed")]
        public bool? LendersInspectionFeeToBeFinancedIndicator { get => _lendersInspectionFeeToBeFinancedIndicator; set => _lendersInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _lendersInspectionPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Lenders Inspect Fee Lender/Brkr Rec Portion [S32DISC.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Lenders Inspect Fee Lender/Brkr Rec Portion")]
        public bool? LendersInspectionPortionOfFeeIndicator { get => _lendersInspectionPortionOfFeeIndicator; set => _lendersInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _loanDiscountFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Loan Discount Fee To Be Financed [S32DISC.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Loan Discount Fee To Be Financed")]
        public bool? LoanDiscountFeeToBeFinancedIndicator { get => _loanDiscountFeeToBeFinancedIndicator; set => _loanDiscountFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _loanDiscountPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Loan Discount Fee Lender/Brkr Rec Portion [S32DISC.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Loan Discount Fee Lender/Brkr Rec Portion")]
        public bool? LoanDiscountPortionOfFeeIndicator { get => _loanDiscountPortionOfFeeIndicator; set => _loanDiscountPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _loanOriginationFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Loan Orig Fee To Be Financed [S32DISC.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Loan Orig Fee To Be Financed")]
        public bool? LoanOriginationFeeToBeFinancedIndicator { get => _loanOriginationFeeToBeFinancedIndicator; set => _loanOriginationFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _loanOriginationPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Loan Orig Fee Lender/Brkr Rec Portion [S32DISC.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Loan Orig Fee Lender/Brkr Rec Portion")]
        public bool? LoanOriginationPortionOfFeeIndicator { get => _loanOriginationPortionOfFeeIndicator; set => _loanOriginationPortionOfFeeIndicator = value; }
        private DirtyValue<string> _loanQualifyAsHighCostMortgage;
        /// <summary>
        /// Sec 32 Qualifies as High Cost Mtg Under Section 32 [S32DISC.X51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Sec 32 Qualifies as High Cost Mtg Under Section 32")]
        public string LoanQualifyAsHighCostMortgage { get => _loanQualifyAsHighCostMortgage; set => _loanQualifyAsHighCostMortgage = value; }
        private DirtyValue<decimal?> _maximumPercentageOfLoan;
        /// <summary>
        /// Sec 32 Max % of Loan Amt for Allowed Fees [S32DISC.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 Max % of Loan Amt for Allowed Fees")]
        public decimal? MaximumPercentageOfLoan { get => _maximumPercentageOfLoan; set => _maximumPercentageOfLoan = value; }
        private DirtyValue<decimal?> _maximumPointsAndFees;
        /// <summary>
        /// Sec 32 Max Allowed Points/Fees [S32DISC.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Sec 32 Max Allowed Points/Fees")]
        public decimal? MaximumPointsAndFees { get => _maximumPointsAndFees; set => _maximumPointsAndFees = value; }
        private DirtyValue<bool?> _mortgageBrokerFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Mtg Broker Fee To Be Financed [S32DISC.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Broker Fee To Be Financed")]
        public bool? MortgageBrokerFeeToBeFinancedIndicator { get => _mortgageBrokerFeeToBeFinancedIndicator; set => _mortgageBrokerFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageBrokerPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Mtg Broker Fee Lender/Brkr Rec Portion [S32DISC.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Broker Fee Lender/Brkr Rec Portion")]
        public bool? MortgageBrokerPortionOfFeeIndicator { get => _mortgageBrokerPortionOfFeeIndicator; set => _mortgageBrokerPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInspectionFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 MI Application Fee To Be Financed [S32DISC.X129]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 MI Application Fee To Be Financed")]
        public bool? MortgageInspectionFeeToBeFinancedIndicator { get => _mortgageInspectionFeeToBeFinancedIndicator; set => _mortgageInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInspectionPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 MI Application Fee Lender/Brkr Rec Portion [S32DISC.X128]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 MI Application Fee Lender/Brkr Rec Portion")]
        public bool? MortgageInspectionPortionOfFeeIndicator { get => _mortgageInspectionPortionOfFeeIndicator; set => _mortgageInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInsuranceFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Mtg Ins To Be Financed [S32DISC.X147]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Ins To Be Financed")]
        public bool? MortgageInsuranceFeeToBeFinancedIndicator { get => _mortgageInsuranceFeeToBeFinancedIndicator; set => _mortgageInsuranceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Mtg Ins Lender/Brkr Rec Portion [S32DISC.X146]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Ins Lender/Brkr Rec Portion")]
        public bool? MortgageInsurancePortionOfFeeIndicator { get => _mortgageInsurancePortionOfFeeIndicator; set => _mortgageInsurancePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePremiumFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Mtg Ins Prem To Be Financed [S32DISC.X145]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Ins Prem To Be Financed")]
        public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get => _mortgageInsurancePremiumFeeToBeFinancedIndicator; set => _mortgageInsurancePremiumFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePremiumPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Mtg Ins Prem Lender/Brkr Rec Portion [S32DISC.X144]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Mtg Ins Prem Lender/Brkr Rec Portion")]
        public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get => _mortgageInsurancePremiumPortionOfFeeIndicator; set => _mortgageInsurancePremiumPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _notaryFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Notary Fees To Be Financed [S32DISC.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Notary Fees To Be Financed")]
        public bool? NotaryFeeToBeFinancedIndicator { get => _notaryFeeToBeFinancedIndicator; set => _notaryFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _notaryPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Notary Fees Lender/Brkr Rec Portion [S32DISC.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Notary Fees Lender/Brkr Rec Portion")]
        public bool? NotaryPortionOfFeeIndicator { get => _notaryPortionOfFeeIndicator; set => _notaryPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _otherHighCostIndicator;
        /// <summary>
        /// Loan qualifies as high cost under a state/county/local jurisdiction [HighCost.Local]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan qualifies as high cost under a state/county/local jurisdiction")]
        public bool? OtherHighCostIndicator { get => _otherHighCostIndicator; set => _otherHighCostIndicator = value; }
        private DirtyValue<StringEnumValue<PenaltyChargeMoreThan36Months>> _penaltyChargeMoreThan36Months;
        /// <summary>
        /// Sec 32 - There is a prepayment penalty and it will/will not be charged more than 36 months after consummation or account opening. [S32DISC.X180]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 - There is a prepayment penalty and it will/will not be charged more than 36 months after consummation or account opening.")]
        public StringEnumValue<PenaltyChargeMoreThan36Months> PenaltyChargeMoreThan36Months { get => _penaltyChargeMoreThan36Months; set => _penaltyChargeMoreThan36Months = value; }
        private DirtyValue<bool?> _pestInspectionFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Pest Inspect To Be Financed [S32DISC.X90]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Pest Inspect To Be Financed")]
        public bool? PestInspectionFeeToBeFinancedIndicator { get => _pestInspectionFeeToBeFinancedIndicator; set => _pestInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _pestInspectionPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Pest Inspect Lender/Brkr Rec Portion [S32DISC.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Pest Inspect Lender/Brkr Rec Portion")]
        public bool? PestInspectionPortionOfFeeIndicator { get => _pestInspectionPortionOfFeeIndicator; set => _pestInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _prepayPenaltyPercentofAmtPrepaid;
        /// <summary>
        /// Sec 32 - Prepayment Penalty Amount Percentage of Amount Prepaid [S32DISC.X178]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 - Prepayment Penalty Amount Percentage of Amount Prepaid")]
        public decimal? PrepayPenaltyPercentofAmtPrepaid { get => _prepayPenaltyPercentofAmtPrepaid; set => _prepayPenaltyPercentofAmtPrepaid = value; }
        private DirtyValue<bool?> _processingFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Proc Fee To Be Financed [S32DISC.X103]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Proc Fee To Be Financed")]
        public bool? ProcessingFeeToBeFinancedIndicator { get => _processingFeeToBeFinancedIndicator; set => _processingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _processingPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Proc Fee Lender/Brkr Rec Portion [S32DISC.X102]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Proc Fee Lender/Brkr Rec Portion")]
        public bool? ProcessingPortionOfFeeIndicator { get => _processingPortionOfFeeIndicator; set => _processingPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _rateSetIndex;
        /// <summary>
        /// Sec 32 - Rate Set Index [S32DISC.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 - Rate Set Index")]
        public decimal? RateSetIndex { get => _rateSetIndex; set => _rateSetIndex = value; }
        private DirtyValue<bool?> _recordingFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Recording Fees To Be Financed [S32DISC.X85]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Recording Fees To Be Financed")]
        public bool? RecordingFeeToBeFinancedIndicator { get => _recordingFeeToBeFinancedIndicator; set => _recordingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _recordingPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Recording Fees Lender/Brkr Rec Portion [S32DISC.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Recording Fees Lender/Brkr Rec Portion")]
        public bool? RecordingPortionOfFeeIndicator { get => _recordingPortionOfFeeIndicator; set => _recordingPortionOfFeeIndicator = value; }
        private DirtyValue<string> _resultOfPointAndFees;
        /// <summary>
        /// Sec 32 Points/Fees Test Results [S32DISC.X49]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Sec 32 Points/Fees Test Results")]
        public string ResultOfPointAndFees { get => _resultOfPointAndFees; set => _resultOfPointAndFees = value; }
        private DirtyValue<string> _resultOfSecurityYieldTest;
        /// <summary>
        /// Sec 32 Security Yield Test Result [S32DISC.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Sec 32 Security Yield Test Result")]
        public string ResultOfSecurityYieldTest { get => _resultOfSecurityYieldTest; set => _resultOfSecurityYieldTest = value; }
        private DirtyValue<bool?> _section32Indicator;
        /// <summary>
        /// Loan qualifies as high cost under Section 32 [HighCost.Federal]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan qualifies as high cost under Section 32")]
        public bool? Section32Indicator { get => _section32Indicator; set => _section32Indicator = value; }
        private DirtyValue<decimal?> _section35AveragePrimeRate;
        /// <summary>
        /// Sec 35 HPML Average Prime Offer Rate [3134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 35 HPML Average Prime Offer Rate")]
        public decimal? Section35AveragePrimeRate { get => _section35AveragePrimeRate; set => _section35AveragePrimeRate = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot>> _section35IsSecondAppraisalRequired;
        /// <summary>
        /// Sec 35 HPML Second Appraisal Required [3856]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Sec 35 HPML Second Appraisal Required")]
        public StringEnumValue<DoesOrDoesNot> Section35IsSecondAppraisalRequired { get => _section35IsSecondAppraisalRequired; set => _section35IsSecondAppraisalRequired = value; }
        private DirtyValue<DateTime?> _section35PriorAcquisitionDate;
        /// <summary>
        /// Sec 35 HPML Prior Acquisition Date [3853]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 35 HPML Prior Acquisition Date")]
        public DateTime? Section35PriorAcquisitionDate { get => _section35PriorAcquisitionDate; set => _section35PriorAcquisitionDate = value; }
        private DirtyValue<decimal?> _section35PriorAcquisitionPrice;
        /// <summary>
        /// Sec 35 HPML Prior Acquisition Price [3854]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Sec 35 HPML Prior Acquisition Price")]
        public decimal? Section35PriorAcquisitionPrice { get => _section35PriorAcquisitionPrice; set => _section35PriorAcquisitionPrice = value; }
        private DirtyValue<string> _section35PriorAcquisitionSource;
        /// <summary>
        /// Sec 35 HPML Prior Acquisition Source [3852]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 35 HPML Prior Acquisition Source")]
        public string Section35PriorAcquisitionSource { get => _section35PriorAcquisitionSource; set => _section35PriorAcquisitionSource = value; }
        private DirtyValue<string> _section35ResultOfSecurityYieldTest;
        /// <summary>
        /// Sec 35 Security Yield Test Result [3135]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 35 Security Yield Test Result")]
        public string Section35ResultOfSecurityYieldTest { get => _section35ResultOfSecurityYieldTest; set => _section35ResultOfSecurityYieldTest = value; }
        private DirtyValue<DateTime?> _section35SalesContractDate;
        /// <summary>
        /// Sec 35 HPML Sales Contract Date [3855]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 35 HPML Sales Contract Date")]
        public DateTime? Section35SalesContractDate { get => _section35SalesContractDate; set => _section35SalesContractDate = value; }
        private DirtyValue<bool?> _stateTaxStampsFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 State Tax/Stamps To Be Financed [S32DISC.X87]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 State Tax/Stamps To Be Financed")]
        public bool? StateTaxStampsFeeToBeFinancedIndicator { get => _stateTaxStampsFeeToBeFinancedIndicator; set => _stateTaxStampsFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _stateTaxStampsPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 State Tax/Stamps Lender/Brkr Rec Portion [S32DISC.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 State Tax/Stamps Lender/Brkr Rec Portion")]
        public bool? StateTaxStampsPortionOfFeeIndicator { get => _stateTaxStampsPortionOfFeeIndicator; set => _stateTaxStampsPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _surveyFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Survey To - To Be Financed [S32DISC.X89]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Survey To - To Be Financed")]
        public bool? SurveyFeeToBeFinancedIndicator { get => _surveyFeeToBeFinancedIndicator; set => _surveyFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _surveyPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Survey To Lender/Brkr Rec Portion [S32DISC.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Survey To Lender/Brkr Rec Portion")]
        public bool? SurveyPortionOfFeeIndicator { get => _surveyPortionOfFeeIndicator; set => _surveyPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _taxServiceFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Tax Svcing Fee To Be Financed [S32DISC.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Tax Svcing Fee To Be Financed")]
        public bool? TaxServiceFeeToBeFinancedIndicator { get => _taxServiceFeeToBeFinancedIndicator; set => _taxServiceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _taxServicePortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Tax Svcing Fee Lender/Brkr Rec Portion [S32DISC.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Tax Svcing Fee Lender/Brkr Rec Portion")]
        public bool? TaxServicePortionOfFeeIndicator { get => _taxServicePortionOfFeeIndicator; set => _taxServicePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleBinderFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Title Ins Binder To Be Financed [S32DISC.X143]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Ins Binder To Be Financed")]
        public bool? TitleBinderFeeToBeFinancedIndicator { get => _titleBinderFeeToBeFinancedIndicator; set => _titleBinderFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleBinderPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Title Ins Binder Lender/Brkr Rec Portion [S32DISC.X142]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Ins Binder Lender/Brkr Rec Portion")]
        public bool? TitleBinderPortionOfFeeIndicator { get => _titleBinderPortionOfFeeIndicator; set => _titleBinderPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleExaminationFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Title Examination To Be Financed [S32DISC.X141]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Examination To Be Financed")]
        public bool? TitleExaminationFeeToBeFinancedIndicator { get => _titleExaminationFeeToBeFinancedIndicator; set => _titleExaminationFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleExaminationPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Title Examination Lender/Brkr Rec Portion [S32DISC.X140]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Examination Lender/Brkr Rec Portion")]
        public bool? TitleExaminationPortionOfFeeIndicator { get => _titleExaminationPortionOfFeeIndicator; set => _titleExaminationPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleInsuranceFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Title Ins Lenders To Be Financed [S32DISC.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Ins Lenders To Be Financed")]
        public bool? TitleInsuranceFeeToBeFinancedIndicator { get => _titleInsuranceFeeToBeFinancedIndicator; set => _titleInsuranceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleInsurancePortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Title Ins Lenders Lender/Brkr Rec Portion [S32DISC.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Title Ins Lenders Lender/Brkr Rec Portion")]
        public bool? TitleInsurancePortionOfFeeIndicator { get => _titleInsurancePortionOfFeeIndicator; set => _titleInsurancePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleSearchFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Abst/Title Search To Be Financed [S32DISC.X139]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Abst/Title Search To Be Financed")]
        public bool? TitleSearchFeeToBeFinancedIndicator { get => _titleSearchFeeToBeFinancedIndicator; set => _titleSearchFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleSearchPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Abst/Title Search Lender/Brkr Rec Portion [S32DISC.X138]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Abst/Title Search Lender/Brkr Rec Portion")]
        public bool? TitleSearchPortionOfFeeIndicator { get => _titleSearchPortionOfFeeIndicator; set => _titleSearchPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _totalPointsAndFees;
        /// <summary>
        /// Sec 32 Total Points/Fees Appl Under Section 32 [S32DISC.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Sec 32 Total Points/Fees Appl Under Section 32")]
        public decimal? TotalPointsAndFees { get => _totalPointsAndFees; set => _totalPointsAndFees = value; }
        private DirtyValue<decimal?> _treasurySecurityYield;
        /// <summary>
        /// Sec 32 Treasury Security Yield % [S32DISC.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Sec 32 Treasury Security Yield %")]
        public decimal? TreasurySecurityYield { get => _treasurySecurityYield; set => _treasurySecurityYield = value; }
        private DirtyValue<bool?> _underwritingFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Underwriting Fee To Be Financed [S32DISC.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Underwriting Fee To Be Financed")]
        public bool? UnderwritingFeeToBeFinancedIndicator { get => _underwritingFeeToBeFinancedIndicator; set => _underwritingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _underwritingPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Underwriting Fee Lender/Brkr Rec Portion [S32DISC.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Underwriting Fee Lender/Brkr Rec Portion")]
        public bool? UnderwritingPortionOfFeeIndicator { get => _underwritingPortionOfFeeIndicator; set => _underwritingPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _userDefined1109BorPaidAmount;
        /// <summary>
        /// Sec 32 Mtg User Defined 1109 Borrower Paid Amount [S32DISC.X148]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Sec 32 Mtg User Defined 1109 Borrower Paid Amount")]
        public decimal? UserDefined1109BorPaidAmount { get => _userDefined1109BorPaidAmount; set => _userDefined1109BorPaidAmount = value; }
        private DirtyValue<bool?> _userDefined1109FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1109 To Be Financed [S32DISC.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1109 To Be Financed")]
        public bool? UserDefined1109FeeToBeFinancedIndicator { get => _userDefined1109FeeToBeFinancedIndicator; set => _userDefined1109FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1109PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1109 Lender/Brkr Rec Portion [S32DISC.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1109 Lender/Brkr Rec Portion")]
        public bool? UserDefined1109PortionOfFeeIndicator { get => _userDefined1109PortionOfFeeIndicator; set => _userDefined1109PortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _userDefined1110BorPaidAmount;
        /// <summary>
        /// Sec 32 Mtg User Defined 1110 Borrower Paid Amount [S32DISC.X149]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Sec 32 Mtg User Defined 1110 Borrower Paid Amount")]
        public decimal? UserDefined1110BorPaidAmount { get => _userDefined1110BorPaidAmount; set => _userDefined1110BorPaidAmount = value; }
        private DirtyValue<bool?> _userDefined1110FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1110 To Be Financed [S32DISC.X107]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1110 To Be Financed")]
        public bool? UserDefined1110FeeToBeFinancedIndicator { get => _userDefined1110FeeToBeFinancedIndicator; set => _userDefined1110FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1110PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1110 Lender/Brkr Rec Portion [S32DISC.X106]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1110 Lender/Brkr Rec Portion")]
        public bool? UserDefined1110PortionOfFeeIndicator { get => _userDefined1110PortionOfFeeIndicator; set => _userDefined1110PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1111FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1111 To Be Financed [S32DISC.X113]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1111 To Be Financed")]
        public bool? UserDefined1111FeeToBeFinancedIndicator { get => _userDefined1111FeeToBeFinancedIndicator; set => _userDefined1111FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1111PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1111 Lender/Brkr Rec Portion [S32DISC.X112]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1111 Lender/Brkr Rec Portion")]
        public bool? UserDefined1111PortionOfFeeIndicator { get => _userDefined1111PortionOfFeeIndicator; set => _userDefined1111PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1112FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1112 To Be Financed [S32DISC.X115]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1112 To Be Financed")]
        public bool? UserDefined1112FeeToBeFinancedIndicator { get => _userDefined1112FeeToBeFinancedIndicator; set => _userDefined1112FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1112PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1112 Lender/Brkr Rec Portion [S32DISC.X114]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1112 Lender/Brkr Rec Portion")]
        public bool? UserDefined1112PortionOfFeeIndicator { get => _userDefined1112PortionOfFeeIndicator; set => _userDefined1112PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1113FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1113 To Be Financed [S32DISC.X117]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1113 To Be Financed")]
        public bool? UserDefined1113FeeToBeFinancedIndicator { get => _userDefined1113FeeToBeFinancedIndicator; set => _userDefined1113FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1113PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1113 Lender/Brkr Rec Portion [S32DISC.X116]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1113 Lender/Brkr Rec Portion")]
        public bool? UserDefined1113PortionOfFeeIndicator { get => _userDefined1113PortionOfFeeIndicator; set => _userDefined1113PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1114FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1114 To Be Financed [S32DISC.X119]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1114 To Be Financed")]
        public bool? UserDefined1114FeeToBeFinancedIndicator { get => _userDefined1114FeeToBeFinancedIndicator; set => _userDefined1114FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1114PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1114 Lender/Brkr Rec Portion [S32DISC.X118]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1114 Lender/Brkr Rec Portion")]
        public bool? UserDefined1114PortionOfFeeIndicator { get => _userDefined1114PortionOfFeeIndicator; set => _userDefined1114PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1204FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 User Def 1 To Be Financed [S32DISC.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 1 To Be Financed")]
        public bool? UserDefined1204FeeToBeFinancedIndicator { get => _userDefined1204FeeToBeFinancedIndicator; set => _userDefined1204FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1204PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 User Def 1 Lender/Brkr Rec Portion [S32DISC.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 1 Lender/Brkr Rec Portion")]
        public bool? UserDefined1204PortionOfFeeIndicator { get => _userDefined1204PortionOfFeeIndicator; set => _userDefined1204PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1205FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 User Def 2 To Be Financed [S32DISC.X109]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 2 To Be Financed")]
        public bool? UserDefined1205FeeToBeFinancedIndicator { get => _userDefined1205FeeToBeFinancedIndicator; set => _userDefined1205FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1205PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 User Def 2 Lender/Brkr Rec Portion [S32DISC.X108]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 2 Lender/Brkr Rec Portion")]
        public bool? UserDefined1205PortionOfFeeIndicator { get => _userDefined1205PortionOfFeeIndicator; set => _userDefined1205PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1206FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 User Def 3 To Be Financed [S32DISC.X111]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 3 To Be Financed")]
        public bool? UserDefined1206FeeToBeFinancedIndicator { get => _userDefined1206FeeToBeFinancedIndicator; set => _userDefined1206FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1206PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 User Def 3 Lender/Brkr Rec Portion [S32DISC.X110]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 User Def 3 Lender/Brkr Rec Portion")]
        public bool? UserDefined1206PortionOfFeeIndicator { get => _userDefined1206PortionOfFeeIndicator; set => _userDefined1206PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1303FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1303 To Be Financed [S32DISC.X93]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1303 To Be Financed")]
        public bool? UserDefined1303FeeToBeFinancedIndicator { get => _userDefined1303FeeToBeFinancedIndicator; set => _userDefined1303FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1303PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1303 Lender/Brkr Rec Portion [S32DISC.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1303 Lender/Brkr Rec Portion")]
        public bool? UserDefined1303PortionOfFeeIndicator { get => _userDefined1303PortionOfFeeIndicator; set => _userDefined1303PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1304FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1304 To Be Financed [S32DISC.X94]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1304 To Be Financed")]
        public bool? UserDefined1304FeeToBeFinancedIndicator { get => _userDefined1304FeeToBeFinancedIndicator; set => _userDefined1304FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1304PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1304 Lender/Brkr Rec Portion [S32DISC.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1304 Lender/Brkr Rec Portion")]
        public bool? UserDefined1304PortionOfFeeIndicator { get => _userDefined1304PortionOfFeeIndicator; set => _userDefined1304PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1305FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1305 To Be Financed [S32DISC.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1305 To Be Financed")]
        public bool? UserDefined1305FeeToBeFinancedIndicator { get => _userDefined1305FeeToBeFinancedIndicator; set => _userDefined1305FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1305PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1305 Lender/Brkr Rec Portion [S32DISC.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1305 Lender/Brkr Rec Portion")]
        public bool? UserDefined1305PortionOfFeeIndicator { get => _userDefined1305PortionOfFeeIndicator; set => _userDefined1305PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1306FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1306 To Be Financed [S32DISC.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1306 To Be Financed")]
        public bool? UserDefined1306FeeToBeFinancedIndicator { get => _userDefined1306FeeToBeFinancedIndicator; set => _userDefined1306FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1306PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1306 Lender/Brkr Rec Portion [S32DISC.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1306 Lender/Brkr Rec Portion")]
        public bool? UserDefined1306PortionOfFeeIndicator { get => _userDefined1306PortionOfFeeIndicator; set => _userDefined1306PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1307FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1307 To Be Financed [S32DISC.X121]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1307 To Be Financed")]
        public bool? UserDefined1307FeeToBeFinancedIndicator { get => _userDefined1307FeeToBeFinancedIndicator; set => _userDefined1307FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1307PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1307 Lender/Brkr Rec Portion [S32DISC.X120]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1307 Lender/Brkr Rec Portion")]
        public bool? UserDefined1307PortionOfFeeIndicator { get => _userDefined1307PortionOfFeeIndicator; set => _userDefined1307PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1308FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1308 To Be Financed [S32DISC.X123]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1308 To Be Financed")]
        public bool? UserDefined1308FeeToBeFinancedIndicator { get => _userDefined1308FeeToBeFinancedIndicator; set => _userDefined1308FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1308PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1308 Lender/Brkr Rec Portion [S32DISC.X122]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1308 Lender/Brkr Rec Portion")]
        public bool? UserDefined1308PortionOfFeeIndicator { get => _userDefined1308PortionOfFeeIndicator; set => _userDefined1308PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1309FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 1309 To Be Financed [S32DISC.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1309 To Be Financed")]
        public bool? UserDefined1309FeeToBeFinancedIndicator { get => _userDefined1309FeeToBeFinancedIndicator; set => _userDefined1309FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1309PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 1309 Lender/Brkr Rec Portion [S32DISC.X124]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 1309 Lender/Brkr Rec Portion")]
        public bool? UserDefined1309PortionOfFeeIndicator { get => _userDefined1309PortionOfFeeIndicator; set => _userDefined1309PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined813FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 813 To Be Financed [S32DISC.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 813 To Be Financed")]
        public bool? UserDefined813FeeToBeFinancedIndicator { get => _userDefined813FeeToBeFinancedIndicator; set => _userDefined813FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined813PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 813 Lender/Brkr Rec Portion [S32DISC.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 813 Lender/Brkr Rec Portion")]
        public bool? UserDefined813PortionOfFeeIndicator { get => _userDefined813PortionOfFeeIndicator; set => _userDefined813PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined814FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 814 To Be Financed [S32DISC.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 814 To Be Financed")]
        public bool? UserDefined814FeeToBeFinancedIndicator { get => _userDefined814FeeToBeFinancedIndicator; set => _userDefined814FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined814PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 814 Lender/Brkr Rec Portion [S32DISC.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 814 Lender/Brkr Rec Portion")]
        public bool? UserDefined814PortionOfFeeIndicator { get => _userDefined814PortionOfFeeIndicator; set => _userDefined814PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined815FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 815 To Be Financed [S32DISC.X70]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 815 To Be Financed")]
        public bool? UserDefined815FeeToBeFinancedIndicator { get => _userDefined815FeeToBeFinancedIndicator; set => _userDefined815FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined815PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 815 Lender/Brkr Rec Portion [S32DISC.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 815 Lender/Brkr Rec Portion")]
        public bool? UserDefined815PortionOfFeeIndicator { get => _userDefined815PortionOfFeeIndicator; set => _userDefined815PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined816FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 816 To Be Financed [S32DISC.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 816 To Be Financed")]
        public bool? UserDefined816FeeToBeFinancedIndicator { get => _userDefined816FeeToBeFinancedIndicator; set => _userDefined816FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined816PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 816 Lender/Brkr Rec Portion [S32DISC.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 816 Lender/Brkr Rec Portion")]
        public bool? UserDefined816PortionOfFeeIndicator { get => _userDefined816PortionOfFeeIndicator; set => _userDefined816PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined817FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 817 To Be Financed [S32DISC.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 817 To Be Financed")]
        public bool? UserDefined817FeeToBeFinancedIndicator { get => _userDefined817FeeToBeFinancedIndicator; set => _userDefined817FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined817PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 817 Lender/Brkr Rec Portion [S32DISC.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 817 Lender/Brkr Rec Portion")]
        public bool? UserDefined817PortionOfFeeIndicator { get => _userDefined817PortionOfFeeIndicator; set => _userDefined817PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined818FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 818 To Be Financed [S32DISC.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 818 To Be Financed")]
        public bool? UserDefined818FeeToBeFinancedIndicator { get => _userDefined818FeeToBeFinancedIndicator; set => _userDefined818FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined818PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 818 Lender/Brkr Rec Portion [S32DISC.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 818 Lender/Brkr Rec Portion")]
        public bool? UserDefined818PortionOfFeeIndicator { get => _userDefined818PortionOfFeeIndicator; set => _userDefined818PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined819FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 819 To Be Financed [S32DISC.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 819 To Be Financed")]
        public bool? UserDefined819FeeToBeFinancedIndicator { get => _userDefined819FeeToBeFinancedIndicator; set => _userDefined819FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined819PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 819 Lender/Brkr Rec Portion [S32DISC.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 819 Lender/Brkr Rec Portion")]
        public bool? UserDefined819PortionOfFeeIndicator { get => _userDefined819PortionOfFeeIndicator; set => _userDefined819PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined820FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 820 To Be Financed [S32DISC.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 820 To Be Financed")]
        public bool? UserDefined820FeeToBeFinancedIndicator { get => _userDefined820FeeToBeFinancedIndicator; set => _userDefined820FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined820PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 820 Lender/Brkr Rec Portion [S32DISC.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 820 Lender/Brkr Rec Portion")]
        public bool? UserDefined820PortionOfFeeIndicator { get => _userDefined820PortionOfFeeIndicator; set => _userDefined820PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined821FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 821 To Be Financed [S32DISC.X127]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 821 To Be Financed")]
        public bool? UserDefined821FeeToBeFinancedIndicator { get => _userDefined821FeeToBeFinancedIndicator; set => _userDefined821FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined821PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 821 Lender/Brkr Rec Portion [S32DISC.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 821 Lender/Brkr Rec Portion")]
        public bool? UserDefined821PortionOfFeeIndicator { get => _userDefined821PortionOfFeeIndicator; set => _userDefined821PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined822FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 822 To Be Financed [S32DISC.X135]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 822 To Be Financed")]
        public bool? UserDefined822FeeToBeFinancedIndicator { get => _userDefined822FeeToBeFinancedIndicator; set => _userDefined822FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined822PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 822 Lender/Brkr Rec Portion [S32DISC.X134]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 822 Lender/Brkr Rec Portion")]
        public bool? UserDefined822PortionOfFeeIndicator { get => _userDefined822PortionOfFeeIndicator; set => _userDefined822PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined823FeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Line 823 To Be Financed [S32DISC.X137]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 823 To Be Financed")]
        public bool? UserDefined823FeeToBeFinancedIndicator { get => _userDefined823FeeToBeFinancedIndicator; set => _userDefined823FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined823PortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Line 823 Lender/Brkr Rec Portion [S32DISC.X136]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Line 823 Lender/Brkr Rec Portion")]
        public bool? UserDefined823PortionOfFeeIndicator { get => _userDefined823PortionOfFeeIndicator; set => _userDefined823PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _wireTransferFeeToBeFinancedIndicator;
        /// <summary>
        /// Sec 32 Wire Trans Fee To Be Financed [S32DISC.X105]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Wire Trans Fee To Be Financed")]
        public bool? WireTransferFeeToBeFinancedIndicator { get => _wireTransferFeeToBeFinancedIndicator; set => _wireTransferFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _wireTransferPortionOfFeeIndicator;
        /// <summary>
        /// Sec 32 Wire Trans Fee Lender/Brkr Rec Portion [S32DISC.X104]
        /// </summary>
        [LoanFieldProperty(Description = "Sec 32 Wire Trans Fee Lender/Brkr Rec Portion")]
        public bool? WireTransferPortionOfFeeIndicator { get => _wireTransferPortionOfFeeIndicator; set => _wireTransferPortionOfFeeIndicator = value; }
    }
}