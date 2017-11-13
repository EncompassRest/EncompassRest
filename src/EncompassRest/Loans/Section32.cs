using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Section32 : IDirty
    {
        private DirtyValue<bool?> _appraisalFeeToBeFinancedIndicator;
        public bool? AppraisalFeeToBeFinancedIndicator { get => _appraisalFeeToBeFinancedIndicator; set => _appraisalFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _appraisalPortionOfFeeIndicator;
        public bool? AppraisalPortionOfFeeIndicator { get => _appraisalPortionOfFeeIndicator; set => _appraisalPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _aprExceedsTsyForFirstMortgage;
        public decimal? AprExceedsTsyForFirstMortgage { get => _aprExceedsTsyForFirstMortgage; set => _aprExceedsTsyForFirstMortgage = value; }
        private DirtyValue<decimal?> _aprExceedsTsyForSubordinateMortgage;
        public decimal? AprExceedsTsyForSubordinateMortgage { get => _aprExceedsTsyForSubordinateMortgage; set => _aprExceedsTsyForSubordinateMortgage = value; }
        private DirtyValue<bool?> _assumptionFeeToBeFinancedIndicator;
        public bool? AssumptionFeeToBeFinancedIndicator { get => _assumptionFeeToBeFinancedIndicator; set => _assumptionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _assumptionPortionOfFeeIndicator;
        public bool? AssumptionPortionOfFeeIndicator { get => _assumptionPortionOfFeeIndicator; set => _assumptionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _attorneyFeeToBeFinancedIndicator;
        public bool? AttorneyFeeToBeFinancedIndicator { get => _attorneyFeeToBeFinancedIndicator; set => _attorneyFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _attorneyPortionOfFeeIndicator;
        public bool? AttorneyPortionOfFeeIndicator { get => _attorneyPortionOfFeeIndicator; set => _attorneyPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _cityCountyTaxStampsFeeToBeFinancedIndicator;
        public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get => _cityCountyTaxStampsFeeToBeFinancedIndicator; set => _cityCountyTaxStampsFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _cityCountyTaxStampsPortionOfFeeIndicator;
        public bool? CityCountyTaxStampsPortionOfFeeIndicator { get => _cityCountyTaxStampsPortionOfFeeIndicator; set => _cityCountyTaxStampsPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _closingFeeToBeFinancedIndicator;
        public bool? ClosingFeeToBeFinancedIndicator { get => _closingFeeToBeFinancedIndicator; set => _closingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _closingPortionOfFeeIndicator;
        public bool? ClosingPortionOfFeeIndicator { get => _closingPortionOfFeeIndicator; set => _closingPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _creditReportFeeToBeFinancedIndicator;
        public bool? CreditReportFeeToBeFinancedIndicator { get => _creditReportFeeToBeFinancedIndicator; set => _creditReportFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _creditReportPortionOfFeeIndicator;
        public bool? CreditReportPortionOfFeeIndicator { get => _creditReportPortionOfFeeIndicator; set => _creditReportPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _docPrepFeeToBeFinancedIndicator;
        public bool? DocPrepFeeToBeFinancedIndicator { get => _docPrepFeeToBeFinancedIndicator; set => _docPrepFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _docPrepPortionOfFeeIndicator;
        public bool? DocPrepPortionOfFeeIndicator { get => _docPrepPortionOfFeeIndicator; set => _docPrepPortionOfFeeIndicator = value; }
        private StringEnumValue<DoesOrDoesNot2> _exceed2PercentPrepayPenalty;
        public StringEnumValue<DoesOrDoesNot2> Exceed2PercentPrepayPenalty { get => _exceed2PercentPrepayPenalty; set => _exceed2PercentPrepayPenalty = value; }
        private DirtyValue<decimal?> _hoepaAPR;
        public decimal? HoepaAPR { get => _hoepaAPR; set => _hoepaAPR = value; }
        private DirtyValue<decimal?> _hoepaFee;
        public decimal? HoepaFee { get => _hoepaFee; set => _hoepaFee = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _jurisdications;
        public string Jurisdications { get => _jurisdications; set => _jurisdications = value; }
        private DirtyValue<bool?> _lendersInspectionFeeToBeFinancedIndicator;
        public bool? LendersInspectionFeeToBeFinancedIndicator { get => _lendersInspectionFeeToBeFinancedIndicator; set => _lendersInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _lendersInspectionPortionOfFeeIndicator;
        public bool? LendersInspectionPortionOfFeeIndicator { get => _lendersInspectionPortionOfFeeIndicator; set => _lendersInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _loanDiscountFeeToBeFinancedIndicator;
        public bool? LoanDiscountFeeToBeFinancedIndicator { get => _loanDiscountFeeToBeFinancedIndicator; set => _loanDiscountFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _loanDiscountPortionOfFeeIndicator;
        public bool? LoanDiscountPortionOfFeeIndicator { get => _loanDiscountPortionOfFeeIndicator; set => _loanDiscountPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _loanOriginationFeeToBeFinancedIndicator;
        public bool? LoanOriginationFeeToBeFinancedIndicator { get => _loanOriginationFeeToBeFinancedIndicator; set => _loanOriginationFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _loanOriginationPortionOfFeeIndicator;
        public bool? LoanOriginationPortionOfFeeIndicator { get => _loanOriginationPortionOfFeeIndicator; set => _loanOriginationPortionOfFeeIndicator = value; }
        private DirtyValue<string> _loanQualifyAsHighCostMortgage;
        public string LoanQualifyAsHighCostMortgage { get => _loanQualifyAsHighCostMortgage; set => _loanQualifyAsHighCostMortgage = value; }
        private DirtyValue<decimal?> _maximumPercentageOfLoan;
        public decimal? MaximumPercentageOfLoan { get => _maximumPercentageOfLoan; set => _maximumPercentageOfLoan = value; }
        private DirtyValue<decimal?> _maximumPointsAndFees;
        public decimal? MaximumPointsAndFees { get => _maximumPointsAndFees; set => _maximumPointsAndFees = value; }
        private DirtyValue<bool?> _mortgageBrokerFeeToBeFinancedIndicator;
        public bool? MortgageBrokerFeeToBeFinancedIndicator { get => _mortgageBrokerFeeToBeFinancedIndicator; set => _mortgageBrokerFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageBrokerPortionOfFeeIndicator;
        public bool? MortgageBrokerPortionOfFeeIndicator { get => _mortgageBrokerPortionOfFeeIndicator; set => _mortgageBrokerPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInspectionFeeToBeFinancedIndicator;
        public bool? MortgageInspectionFeeToBeFinancedIndicator { get => _mortgageInspectionFeeToBeFinancedIndicator; set => _mortgageInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInspectionPortionOfFeeIndicator;
        public bool? MortgageInspectionPortionOfFeeIndicator { get => _mortgageInspectionPortionOfFeeIndicator; set => _mortgageInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInsuranceFeeToBeFinancedIndicator;
        public bool? MortgageInsuranceFeeToBeFinancedIndicator { get => _mortgageInsuranceFeeToBeFinancedIndicator; set => _mortgageInsuranceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePortionOfFeeIndicator;
        public bool? MortgageInsurancePortionOfFeeIndicator { get => _mortgageInsurancePortionOfFeeIndicator; set => _mortgageInsurancePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePremiumFeeToBeFinancedIndicator;
        public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get => _mortgageInsurancePremiumFeeToBeFinancedIndicator; set => _mortgageInsurancePremiumFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _mortgageInsurancePremiumPortionOfFeeIndicator;
        public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get => _mortgageInsurancePremiumPortionOfFeeIndicator; set => _mortgageInsurancePremiumPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _notaryFeeToBeFinancedIndicator;
        public bool? NotaryFeeToBeFinancedIndicator { get => _notaryFeeToBeFinancedIndicator; set => _notaryFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _notaryPortionOfFeeIndicator;
        public bool? NotaryPortionOfFeeIndicator { get => _notaryPortionOfFeeIndicator; set => _notaryPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _otherHighCostIndicator;
        public bool? OtherHighCostIndicator { get => _otherHighCostIndicator; set => _otherHighCostIndicator = value; }
        private StringEnumValue<PenaltyChargeMoreThan36Months> _penaltyChargeMoreThan36Months;
        public StringEnumValue<PenaltyChargeMoreThan36Months> PenaltyChargeMoreThan36Months { get => _penaltyChargeMoreThan36Months; set => _penaltyChargeMoreThan36Months = value; }
        private DirtyValue<bool?> _pestInspectionFeeToBeFinancedIndicator;
        public bool? PestInspectionFeeToBeFinancedIndicator { get => _pestInspectionFeeToBeFinancedIndicator; set => _pestInspectionFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _pestInspectionPortionOfFeeIndicator;
        public bool? PestInspectionPortionOfFeeIndicator { get => _pestInspectionPortionOfFeeIndicator; set => _pestInspectionPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _prepayPenaltyPercentofAmtPrepaid;
        public decimal? PrepayPenaltyPercentofAmtPrepaid { get => _prepayPenaltyPercentofAmtPrepaid; set => _prepayPenaltyPercentofAmtPrepaid = value; }
        private DirtyValue<bool?> _processingFeeToBeFinancedIndicator;
        public bool? ProcessingFeeToBeFinancedIndicator { get => _processingFeeToBeFinancedIndicator; set => _processingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _processingPortionOfFeeIndicator;
        public bool? ProcessingPortionOfFeeIndicator { get => _processingPortionOfFeeIndicator; set => _processingPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _rateSetIndex;
        public decimal? RateSetIndex { get => _rateSetIndex; set => _rateSetIndex = value; }
        private DirtyValue<bool?> _recordingFeeToBeFinancedIndicator;
        public bool? RecordingFeeToBeFinancedIndicator { get => _recordingFeeToBeFinancedIndicator; set => _recordingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _recordingPortionOfFeeIndicator;
        public bool? RecordingPortionOfFeeIndicator { get => _recordingPortionOfFeeIndicator; set => _recordingPortionOfFeeIndicator = value; }
        private DirtyValue<string> _resultOfPointAndFees;
        public string ResultOfPointAndFees { get => _resultOfPointAndFees; set => _resultOfPointAndFees = value; }
        private DirtyValue<string> _resultOfSecurityYieldTest;
        public string ResultOfSecurityYieldTest { get => _resultOfSecurityYieldTest; set => _resultOfSecurityYieldTest = value; }
        private DirtyValue<bool?> _section32Indicator;
        public bool? Section32Indicator { get => _section32Indicator; set => _section32Indicator = value; }
        private DirtyValue<decimal?> _section35AveragePrimeRate;
        public decimal? Section35AveragePrimeRate { get => _section35AveragePrimeRate; set => _section35AveragePrimeRate = value; }
        private StringEnumValue<DoesOrDoesNot> _section35IsSecondAppraisalRequired;
        public StringEnumValue<DoesOrDoesNot> Section35IsSecondAppraisalRequired { get => _section35IsSecondAppraisalRequired; set => _section35IsSecondAppraisalRequired = value; }
        private DirtyValue<DateTime?> _section35PriorAcquisitionDate;
        public DateTime? Section35PriorAcquisitionDate { get => _section35PriorAcquisitionDate; set => _section35PriorAcquisitionDate = value; }
        private DirtyValue<decimal?> _section35PriorAcquisitionPrice;
        public decimal? Section35PriorAcquisitionPrice { get => _section35PriorAcquisitionPrice; set => _section35PriorAcquisitionPrice = value; }
        private DirtyValue<string> _section35PriorAcquisitionSource;
        public string Section35PriorAcquisitionSource { get => _section35PriorAcquisitionSource; set => _section35PriorAcquisitionSource = value; }
        private DirtyValue<string> _section35ResultOfSecurityYieldTest;
        public string Section35ResultOfSecurityYieldTest { get => _section35ResultOfSecurityYieldTest; set => _section35ResultOfSecurityYieldTest = value; }
        private DirtyValue<DateTime?> _section35SalesContractDate;
        public DateTime? Section35SalesContractDate { get => _section35SalesContractDate; set => _section35SalesContractDate = value; }
        private DirtyValue<bool?> _stateTaxStampsFeeToBeFinancedIndicator;
        public bool? StateTaxStampsFeeToBeFinancedIndicator { get => _stateTaxStampsFeeToBeFinancedIndicator; set => _stateTaxStampsFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _stateTaxStampsPortionOfFeeIndicator;
        public bool? StateTaxStampsPortionOfFeeIndicator { get => _stateTaxStampsPortionOfFeeIndicator; set => _stateTaxStampsPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _surveyFeeToBeFinancedIndicator;
        public bool? SurveyFeeToBeFinancedIndicator { get => _surveyFeeToBeFinancedIndicator; set => _surveyFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _surveyPortionOfFeeIndicator;
        public bool? SurveyPortionOfFeeIndicator { get => _surveyPortionOfFeeIndicator; set => _surveyPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _taxServiceFeeToBeFinancedIndicator;
        public bool? TaxServiceFeeToBeFinancedIndicator { get => _taxServiceFeeToBeFinancedIndicator; set => _taxServiceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _taxServicePortionOfFeeIndicator;
        public bool? TaxServicePortionOfFeeIndicator { get => _taxServicePortionOfFeeIndicator; set => _taxServicePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleBinderFeeToBeFinancedIndicator;
        public bool? TitleBinderFeeToBeFinancedIndicator { get => _titleBinderFeeToBeFinancedIndicator; set => _titleBinderFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleBinderPortionOfFeeIndicator;
        public bool? TitleBinderPortionOfFeeIndicator { get => _titleBinderPortionOfFeeIndicator; set => _titleBinderPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleExaminationFeeToBeFinancedIndicator;
        public bool? TitleExaminationFeeToBeFinancedIndicator { get => _titleExaminationFeeToBeFinancedIndicator; set => _titleExaminationFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleExaminationPortionOfFeeIndicator;
        public bool? TitleExaminationPortionOfFeeIndicator { get => _titleExaminationPortionOfFeeIndicator; set => _titleExaminationPortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleInsuranceFeeToBeFinancedIndicator;
        public bool? TitleInsuranceFeeToBeFinancedIndicator { get => _titleInsuranceFeeToBeFinancedIndicator; set => _titleInsuranceFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleInsurancePortionOfFeeIndicator;
        public bool? TitleInsurancePortionOfFeeIndicator { get => _titleInsurancePortionOfFeeIndicator; set => _titleInsurancePortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _titleSearchFeeToBeFinancedIndicator;
        public bool? TitleSearchFeeToBeFinancedIndicator { get => _titleSearchFeeToBeFinancedIndicator; set => _titleSearchFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _titleSearchPortionOfFeeIndicator;
        public bool? TitleSearchPortionOfFeeIndicator { get => _titleSearchPortionOfFeeIndicator; set => _titleSearchPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _totalPointsAndFees;
        public decimal? TotalPointsAndFees { get => _totalPointsAndFees; set => _totalPointsAndFees = value; }
        private DirtyValue<decimal?> _treasurySecurityYield;
        public decimal? TreasurySecurityYield { get => _treasurySecurityYield; set => _treasurySecurityYield = value; }
        private DirtyValue<bool?> _underwritingFeeToBeFinancedIndicator;
        public bool? UnderwritingFeeToBeFinancedIndicator { get => _underwritingFeeToBeFinancedIndicator; set => _underwritingFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _underwritingPortionOfFeeIndicator;
        public bool? UnderwritingPortionOfFeeIndicator { get => _underwritingPortionOfFeeIndicator; set => _underwritingPortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _userDefined1109BorPaidAmount;
        public decimal? UserDefined1109BorPaidAmount { get => _userDefined1109BorPaidAmount; set => _userDefined1109BorPaidAmount = value; }
        private DirtyValue<bool?> _userDefined1109FeeToBeFinancedIndicator;
        public bool? UserDefined1109FeeToBeFinancedIndicator { get => _userDefined1109FeeToBeFinancedIndicator; set => _userDefined1109FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1109PortionOfFeeIndicator;
        public bool? UserDefined1109PortionOfFeeIndicator { get => _userDefined1109PortionOfFeeIndicator; set => _userDefined1109PortionOfFeeIndicator = value; }
        private DirtyValue<decimal?> _userDefined1110BorPaidAmount;
        public decimal? UserDefined1110BorPaidAmount { get => _userDefined1110BorPaidAmount; set => _userDefined1110BorPaidAmount = value; }
        private DirtyValue<bool?> _userDefined1110FeeToBeFinancedIndicator;
        public bool? UserDefined1110FeeToBeFinancedIndicator { get => _userDefined1110FeeToBeFinancedIndicator; set => _userDefined1110FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1110PortionOfFeeIndicator;
        public bool? UserDefined1110PortionOfFeeIndicator { get => _userDefined1110PortionOfFeeIndicator; set => _userDefined1110PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1111FeeToBeFinancedIndicator;
        public bool? UserDefined1111FeeToBeFinancedIndicator { get => _userDefined1111FeeToBeFinancedIndicator; set => _userDefined1111FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1111PortionOfFeeIndicator;
        public bool? UserDefined1111PortionOfFeeIndicator { get => _userDefined1111PortionOfFeeIndicator; set => _userDefined1111PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1112FeeToBeFinancedIndicator;
        public bool? UserDefined1112FeeToBeFinancedIndicator { get => _userDefined1112FeeToBeFinancedIndicator; set => _userDefined1112FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1112PortionOfFeeIndicator;
        public bool? UserDefined1112PortionOfFeeIndicator { get => _userDefined1112PortionOfFeeIndicator; set => _userDefined1112PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1113FeeToBeFinancedIndicator;
        public bool? UserDefined1113FeeToBeFinancedIndicator { get => _userDefined1113FeeToBeFinancedIndicator; set => _userDefined1113FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1113PortionOfFeeIndicator;
        public bool? UserDefined1113PortionOfFeeIndicator { get => _userDefined1113PortionOfFeeIndicator; set => _userDefined1113PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1114FeeToBeFinancedIndicator;
        public bool? UserDefined1114FeeToBeFinancedIndicator { get => _userDefined1114FeeToBeFinancedIndicator; set => _userDefined1114FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1114PortionOfFeeIndicator;
        public bool? UserDefined1114PortionOfFeeIndicator { get => _userDefined1114PortionOfFeeIndicator; set => _userDefined1114PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1204FeeToBeFinancedIndicator;
        public bool? UserDefined1204FeeToBeFinancedIndicator { get => _userDefined1204FeeToBeFinancedIndicator; set => _userDefined1204FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1204PortionOfFeeIndicator;
        public bool? UserDefined1204PortionOfFeeIndicator { get => _userDefined1204PortionOfFeeIndicator; set => _userDefined1204PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1205FeeToBeFinancedIndicator;
        public bool? UserDefined1205FeeToBeFinancedIndicator { get => _userDefined1205FeeToBeFinancedIndicator; set => _userDefined1205FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1205PortionOfFeeIndicator;
        public bool? UserDefined1205PortionOfFeeIndicator { get => _userDefined1205PortionOfFeeIndicator; set => _userDefined1205PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1206FeeToBeFinancedIndicator;
        public bool? UserDefined1206FeeToBeFinancedIndicator { get => _userDefined1206FeeToBeFinancedIndicator; set => _userDefined1206FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1206PortionOfFeeIndicator;
        public bool? UserDefined1206PortionOfFeeIndicator { get => _userDefined1206PortionOfFeeIndicator; set => _userDefined1206PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1303FeeToBeFinancedIndicator;
        public bool? UserDefined1303FeeToBeFinancedIndicator { get => _userDefined1303FeeToBeFinancedIndicator; set => _userDefined1303FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1303PortionOfFeeIndicator;
        public bool? UserDefined1303PortionOfFeeIndicator { get => _userDefined1303PortionOfFeeIndicator; set => _userDefined1303PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1304FeeToBeFinancedIndicator;
        public bool? UserDefined1304FeeToBeFinancedIndicator { get => _userDefined1304FeeToBeFinancedIndicator; set => _userDefined1304FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1304PortionOfFeeIndicator;
        public bool? UserDefined1304PortionOfFeeIndicator { get => _userDefined1304PortionOfFeeIndicator; set => _userDefined1304PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1305FeeToBeFinancedIndicator;
        public bool? UserDefined1305FeeToBeFinancedIndicator { get => _userDefined1305FeeToBeFinancedIndicator; set => _userDefined1305FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1305PortionOfFeeIndicator;
        public bool? UserDefined1305PortionOfFeeIndicator { get => _userDefined1305PortionOfFeeIndicator; set => _userDefined1305PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1306FeeToBeFinancedIndicator;
        public bool? UserDefined1306FeeToBeFinancedIndicator { get => _userDefined1306FeeToBeFinancedIndicator; set => _userDefined1306FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1306PortionOfFeeIndicator;
        public bool? UserDefined1306PortionOfFeeIndicator { get => _userDefined1306PortionOfFeeIndicator; set => _userDefined1306PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1307FeeToBeFinancedIndicator;
        public bool? UserDefined1307FeeToBeFinancedIndicator { get => _userDefined1307FeeToBeFinancedIndicator; set => _userDefined1307FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1307PortionOfFeeIndicator;
        public bool? UserDefined1307PortionOfFeeIndicator { get => _userDefined1307PortionOfFeeIndicator; set => _userDefined1307PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1308FeeToBeFinancedIndicator;
        public bool? UserDefined1308FeeToBeFinancedIndicator { get => _userDefined1308FeeToBeFinancedIndicator; set => _userDefined1308FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1308PortionOfFeeIndicator;
        public bool? UserDefined1308PortionOfFeeIndicator { get => _userDefined1308PortionOfFeeIndicator; set => _userDefined1308PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined1309FeeToBeFinancedIndicator;
        public bool? UserDefined1309FeeToBeFinancedIndicator { get => _userDefined1309FeeToBeFinancedIndicator; set => _userDefined1309FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined1309PortionOfFeeIndicator;
        public bool? UserDefined1309PortionOfFeeIndicator { get => _userDefined1309PortionOfFeeIndicator; set => _userDefined1309PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined813FeeToBeFinancedIndicator;
        public bool? UserDefined813FeeToBeFinancedIndicator { get => _userDefined813FeeToBeFinancedIndicator; set => _userDefined813FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined813PortionOfFeeIndicator;
        public bool? UserDefined813PortionOfFeeIndicator { get => _userDefined813PortionOfFeeIndicator; set => _userDefined813PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined814FeeToBeFinancedIndicator;
        public bool? UserDefined814FeeToBeFinancedIndicator { get => _userDefined814FeeToBeFinancedIndicator; set => _userDefined814FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined814PortionOfFeeIndicator;
        public bool? UserDefined814PortionOfFeeIndicator { get => _userDefined814PortionOfFeeIndicator; set => _userDefined814PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined815FeeToBeFinancedIndicator;
        public bool? UserDefined815FeeToBeFinancedIndicator { get => _userDefined815FeeToBeFinancedIndicator; set => _userDefined815FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined815PortionOfFeeIndicator;
        public bool? UserDefined815PortionOfFeeIndicator { get => _userDefined815PortionOfFeeIndicator; set => _userDefined815PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined816FeeToBeFinancedIndicator;
        public bool? UserDefined816FeeToBeFinancedIndicator { get => _userDefined816FeeToBeFinancedIndicator; set => _userDefined816FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined816PortionOfFeeIndicator;
        public bool? UserDefined816PortionOfFeeIndicator { get => _userDefined816PortionOfFeeIndicator; set => _userDefined816PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined817FeeToBeFinancedIndicator;
        public bool? UserDefined817FeeToBeFinancedIndicator { get => _userDefined817FeeToBeFinancedIndicator; set => _userDefined817FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined817PortionOfFeeIndicator;
        public bool? UserDefined817PortionOfFeeIndicator { get => _userDefined817PortionOfFeeIndicator; set => _userDefined817PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined818FeeToBeFinancedIndicator;
        public bool? UserDefined818FeeToBeFinancedIndicator { get => _userDefined818FeeToBeFinancedIndicator; set => _userDefined818FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined818PortionOfFeeIndicator;
        public bool? UserDefined818PortionOfFeeIndicator { get => _userDefined818PortionOfFeeIndicator; set => _userDefined818PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined819FeeToBeFinancedIndicator;
        public bool? UserDefined819FeeToBeFinancedIndicator { get => _userDefined819FeeToBeFinancedIndicator; set => _userDefined819FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined819PortionOfFeeIndicator;
        public bool? UserDefined819PortionOfFeeIndicator { get => _userDefined819PortionOfFeeIndicator; set => _userDefined819PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined820FeeToBeFinancedIndicator;
        public bool? UserDefined820FeeToBeFinancedIndicator { get => _userDefined820FeeToBeFinancedIndicator; set => _userDefined820FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined820PortionOfFeeIndicator;
        public bool? UserDefined820PortionOfFeeIndicator { get => _userDefined820PortionOfFeeIndicator; set => _userDefined820PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined821FeeToBeFinancedIndicator;
        public bool? UserDefined821FeeToBeFinancedIndicator { get => _userDefined821FeeToBeFinancedIndicator; set => _userDefined821FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined821PortionOfFeeIndicator;
        public bool? UserDefined821PortionOfFeeIndicator { get => _userDefined821PortionOfFeeIndicator; set => _userDefined821PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined822FeeToBeFinancedIndicator;
        public bool? UserDefined822FeeToBeFinancedIndicator { get => _userDefined822FeeToBeFinancedIndicator; set => _userDefined822FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined822PortionOfFeeIndicator;
        public bool? UserDefined822PortionOfFeeIndicator { get => _userDefined822PortionOfFeeIndicator; set => _userDefined822PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _userDefined823FeeToBeFinancedIndicator;
        public bool? UserDefined823FeeToBeFinancedIndicator { get => _userDefined823FeeToBeFinancedIndicator; set => _userDefined823FeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _userDefined823PortionOfFeeIndicator;
        public bool? UserDefined823PortionOfFeeIndicator { get => _userDefined823PortionOfFeeIndicator; set => _userDefined823PortionOfFeeIndicator = value; }
        private DirtyValue<bool?> _wireTransferFeeToBeFinancedIndicator;
        public bool? WireTransferFeeToBeFinancedIndicator { get => _wireTransferFeeToBeFinancedIndicator; set => _wireTransferFeeToBeFinancedIndicator = value; }
        private DirtyValue<bool?> _wireTransferPortionOfFeeIndicator;
        public bool? WireTransferPortionOfFeeIndicator { get => _wireTransferPortionOfFeeIndicator; set => _wireTransferPortionOfFeeIndicator = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _appraisalFeeToBeFinancedIndicator.Dirty
                    || _appraisalPortionOfFeeIndicator.Dirty
                    || _aprExceedsTsyForFirstMortgage.Dirty
                    || _aprExceedsTsyForSubordinateMortgage.Dirty
                    || _assumptionFeeToBeFinancedIndicator.Dirty
                    || _assumptionPortionOfFeeIndicator.Dirty
                    || _attorneyFeeToBeFinancedIndicator.Dirty
                    || _attorneyPortionOfFeeIndicator.Dirty
                    || _cityCountyTaxStampsFeeToBeFinancedIndicator.Dirty
                    || _cityCountyTaxStampsPortionOfFeeIndicator.Dirty
                    || _closingFeeToBeFinancedIndicator.Dirty
                    || _closingPortionOfFeeIndicator.Dirty
                    || _creditReportFeeToBeFinancedIndicator.Dirty
                    || _creditReportPortionOfFeeIndicator.Dirty
                    || _docPrepFeeToBeFinancedIndicator.Dirty
                    || _docPrepPortionOfFeeIndicator.Dirty
                    || _exceed2PercentPrepayPenalty.Dirty
                    || _hoepaAPR.Dirty
                    || _hoepaFee.Dirty
                    || _id.Dirty
                    || _jurisdications.Dirty
                    || _lendersInspectionFeeToBeFinancedIndicator.Dirty
                    || _lendersInspectionPortionOfFeeIndicator.Dirty
                    || _loanDiscountFeeToBeFinancedIndicator.Dirty
                    || _loanDiscountPortionOfFeeIndicator.Dirty
                    || _loanOriginationFeeToBeFinancedIndicator.Dirty
                    || _loanOriginationPortionOfFeeIndicator.Dirty
                    || _loanQualifyAsHighCostMortgage.Dirty
                    || _maximumPercentageOfLoan.Dirty
                    || _maximumPointsAndFees.Dirty
                    || _mortgageBrokerFeeToBeFinancedIndicator.Dirty
                    || _mortgageBrokerPortionOfFeeIndicator.Dirty
                    || _mortgageInspectionFeeToBeFinancedIndicator.Dirty
                    || _mortgageInspectionPortionOfFeeIndicator.Dirty
                    || _mortgageInsuranceFeeToBeFinancedIndicator.Dirty
                    || _mortgageInsurancePortionOfFeeIndicator.Dirty
                    || _mortgageInsurancePremiumFeeToBeFinancedIndicator.Dirty
                    || _mortgageInsurancePremiumPortionOfFeeIndicator.Dirty
                    || _notaryFeeToBeFinancedIndicator.Dirty
                    || _notaryPortionOfFeeIndicator.Dirty
                    || _otherHighCostIndicator.Dirty
                    || _penaltyChargeMoreThan36Months.Dirty
                    || _pestInspectionFeeToBeFinancedIndicator.Dirty
                    || _pestInspectionPortionOfFeeIndicator.Dirty
                    || _prepayPenaltyPercentofAmtPrepaid.Dirty
                    || _processingFeeToBeFinancedIndicator.Dirty
                    || _processingPortionOfFeeIndicator.Dirty
                    || _rateSetIndex.Dirty
                    || _recordingFeeToBeFinancedIndicator.Dirty
                    || _recordingPortionOfFeeIndicator.Dirty
                    || _resultOfPointAndFees.Dirty
                    || _resultOfSecurityYieldTest.Dirty
                    || _section32Indicator.Dirty
                    || _section35AveragePrimeRate.Dirty
                    || _section35IsSecondAppraisalRequired.Dirty
                    || _section35PriorAcquisitionDate.Dirty
                    || _section35PriorAcquisitionPrice.Dirty
                    || _section35PriorAcquisitionSource.Dirty
                    || _section35ResultOfSecurityYieldTest.Dirty
                    || _section35SalesContractDate.Dirty
                    || _stateTaxStampsFeeToBeFinancedIndicator.Dirty
                    || _stateTaxStampsPortionOfFeeIndicator.Dirty
                    || _surveyFeeToBeFinancedIndicator.Dirty
                    || _surveyPortionOfFeeIndicator.Dirty
                    || _taxServiceFeeToBeFinancedIndicator.Dirty
                    || _taxServicePortionOfFeeIndicator.Dirty
                    || _titleBinderFeeToBeFinancedIndicator.Dirty
                    || _titleBinderPortionOfFeeIndicator.Dirty
                    || _titleExaminationFeeToBeFinancedIndicator.Dirty
                    || _titleExaminationPortionOfFeeIndicator.Dirty
                    || _titleInsuranceFeeToBeFinancedIndicator.Dirty
                    || _titleInsurancePortionOfFeeIndicator.Dirty
                    || _titleSearchFeeToBeFinancedIndicator.Dirty
                    || _titleSearchPortionOfFeeIndicator.Dirty
                    || _totalPointsAndFees.Dirty
                    || _treasurySecurityYield.Dirty
                    || _underwritingFeeToBeFinancedIndicator.Dirty
                    || _underwritingPortionOfFeeIndicator.Dirty
                    || _userDefined1109BorPaidAmount.Dirty
                    || _userDefined1109FeeToBeFinancedIndicator.Dirty
                    || _userDefined1109PortionOfFeeIndicator.Dirty
                    || _userDefined1110BorPaidAmount.Dirty
                    || _userDefined1110FeeToBeFinancedIndicator.Dirty
                    || _userDefined1110PortionOfFeeIndicator.Dirty
                    || _userDefined1111FeeToBeFinancedIndicator.Dirty
                    || _userDefined1111PortionOfFeeIndicator.Dirty
                    || _userDefined1112FeeToBeFinancedIndicator.Dirty
                    || _userDefined1112PortionOfFeeIndicator.Dirty
                    || _userDefined1113FeeToBeFinancedIndicator.Dirty
                    || _userDefined1113PortionOfFeeIndicator.Dirty
                    || _userDefined1114FeeToBeFinancedIndicator.Dirty
                    || _userDefined1114PortionOfFeeIndicator.Dirty
                    || _userDefined1204FeeToBeFinancedIndicator.Dirty
                    || _userDefined1204PortionOfFeeIndicator.Dirty
                    || _userDefined1205FeeToBeFinancedIndicator.Dirty
                    || _userDefined1205PortionOfFeeIndicator.Dirty
                    || _userDefined1206FeeToBeFinancedIndicator.Dirty
                    || _userDefined1206PortionOfFeeIndicator.Dirty
                    || _userDefined1303FeeToBeFinancedIndicator.Dirty
                    || _userDefined1303PortionOfFeeIndicator.Dirty
                    || _userDefined1304FeeToBeFinancedIndicator.Dirty
                    || _userDefined1304PortionOfFeeIndicator.Dirty
                    || _userDefined1305FeeToBeFinancedIndicator.Dirty
                    || _userDefined1305PortionOfFeeIndicator.Dirty
                    || _userDefined1306FeeToBeFinancedIndicator.Dirty
                    || _userDefined1306PortionOfFeeIndicator.Dirty
                    || _userDefined1307FeeToBeFinancedIndicator.Dirty
                    || _userDefined1307PortionOfFeeIndicator.Dirty
                    || _userDefined1308FeeToBeFinancedIndicator.Dirty
                    || _userDefined1308PortionOfFeeIndicator.Dirty
                    || _userDefined1309FeeToBeFinancedIndicator.Dirty
                    || _userDefined1309PortionOfFeeIndicator.Dirty
                    || _userDefined813FeeToBeFinancedIndicator.Dirty
                    || _userDefined813PortionOfFeeIndicator.Dirty
                    || _userDefined814FeeToBeFinancedIndicator.Dirty
                    || _userDefined814PortionOfFeeIndicator.Dirty
                    || _userDefined815FeeToBeFinancedIndicator.Dirty
                    || _userDefined815PortionOfFeeIndicator.Dirty
                    || _userDefined816FeeToBeFinancedIndicator.Dirty
                    || _userDefined816PortionOfFeeIndicator.Dirty
                    || _userDefined817FeeToBeFinancedIndicator.Dirty
                    || _userDefined817PortionOfFeeIndicator.Dirty
                    || _userDefined818FeeToBeFinancedIndicator.Dirty
                    || _userDefined818PortionOfFeeIndicator.Dirty
                    || _userDefined819FeeToBeFinancedIndicator.Dirty
                    || _userDefined819PortionOfFeeIndicator.Dirty
                    || _userDefined820FeeToBeFinancedIndicator.Dirty
                    || _userDefined820PortionOfFeeIndicator.Dirty
                    || _userDefined821FeeToBeFinancedIndicator.Dirty
                    || _userDefined821PortionOfFeeIndicator.Dirty
                    || _userDefined822FeeToBeFinancedIndicator.Dirty
                    || _userDefined822PortionOfFeeIndicator.Dirty
                    || _userDefined823FeeToBeFinancedIndicator.Dirty
                    || _userDefined823PortionOfFeeIndicator.Dirty
                    || _wireTransferFeeToBeFinancedIndicator.Dirty
                    || _wireTransferPortionOfFeeIndicator.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _appraisalFeeToBeFinancedIndicator.Dirty = value;
                _appraisalPortionOfFeeIndicator.Dirty = value;
                _aprExceedsTsyForFirstMortgage.Dirty = value;
                _aprExceedsTsyForSubordinateMortgage.Dirty = value;
                _assumptionFeeToBeFinancedIndicator.Dirty = value;
                _assumptionPortionOfFeeIndicator.Dirty = value;
                _attorneyFeeToBeFinancedIndicator.Dirty = value;
                _attorneyPortionOfFeeIndicator.Dirty = value;
                _cityCountyTaxStampsFeeToBeFinancedIndicator.Dirty = value;
                _cityCountyTaxStampsPortionOfFeeIndicator.Dirty = value;
                _closingFeeToBeFinancedIndicator.Dirty = value;
                _closingPortionOfFeeIndicator.Dirty = value;
                _creditReportFeeToBeFinancedIndicator.Dirty = value;
                _creditReportPortionOfFeeIndicator.Dirty = value;
                _docPrepFeeToBeFinancedIndicator.Dirty = value;
                _docPrepPortionOfFeeIndicator.Dirty = value;
                _exceed2PercentPrepayPenalty.Dirty = value;
                _hoepaAPR.Dirty = value;
                _hoepaFee.Dirty = value;
                _id.Dirty = value;
                _jurisdications.Dirty = value;
                _lendersInspectionFeeToBeFinancedIndicator.Dirty = value;
                _lendersInspectionPortionOfFeeIndicator.Dirty = value;
                _loanDiscountFeeToBeFinancedIndicator.Dirty = value;
                _loanDiscountPortionOfFeeIndicator.Dirty = value;
                _loanOriginationFeeToBeFinancedIndicator.Dirty = value;
                _loanOriginationPortionOfFeeIndicator.Dirty = value;
                _loanQualifyAsHighCostMortgage.Dirty = value;
                _maximumPercentageOfLoan.Dirty = value;
                _maximumPointsAndFees.Dirty = value;
                _mortgageBrokerFeeToBeFinancedIndicator.Dirty = value;
                _mortgageBrokerPortionOfFeeIndicator.Dirty = value;
                _mortgageInspectionFeeToBeFinancedIndicator.Dirty = value;
                _mortgageInspectionPortionOfFeeIndicator.Dirty = value;
                _mortgageInsuranceFeeToBeFinancedIndicator.Dirty = value;
                _mortgageInsurancePortionOfFeeIndicator.Dirty = value;
                _mortgageInsurancePremiumFeeToBeFinancedIndicator.Dirty = value;
                _mortgageInsurancePremiumPortionOfFeeIndicator.Dirty = value;
                _notaryFeeToBeFinancedIndicator.Dirty = value;
                _notaryPortionOfFeeIndicator.Dirty = value;
                _otherHighCostIndicator.Dirty = value;
                _penaltyChargeMoreThan36Months.Dirty = value;
                _pestInspectionFeeToBeFinancedIndicator.Dirty = value;
                _pestInspectionPortionOfFeeIndicator.Dirty = value;
                _prepayPenaltyPercentofAmtPrepaid.Dirty = value;
                _processingFeeToBeFinancedIndicator.Dirty = value;
                _processingPortionOfFeeIndicator.Dirty = value;
                _rateSetIndex.Dirty = value;
                _recordingFeeToBeFinancedIndicator.Dirty = value;
                _recordingPortionOfFeeIndicator.Dirty = value;
                _resultOfPointAndFees.Dirty = value;
                _resultOfSecurityYieldTest.Dirty = value;
                _section32Indicator.Dirty = value;
                _section35AveragePrimeRate.Dirty = value;
                _section35IsSecondAppraisalRequired.Dirty = value;
                _section35PriorAcquisitionDate.Dirty = value;
                _section35PriorAcquisitionPrice.Dirty = value;
                _section35PriorAcquisitionSource.Dirty = value;
                _section35ResultOfSecurityYieldTest.Dirty = value;
                _section35SalesContractDate.Dirty = value;
                _stateTaxStampsFeeToBeFinancedIndicator.Dirty = value;
                _stateTaxStampsPortionOfFeeIndicator.Dirty = value;
                _surveyFeeToBeFinancedIndicator.Dirty = value;
                _surveyPortionOfFeeIndicator.Dirty = value;
                _taxServiceFeeToBeFinancedIndicator.Dirty = value;
                _taxServicePortionOfFeeIndicator.Dirty = value;
                _titleBinderFeeToBeFinancedIndicator.Dirty = value;
                _titleBinderPortionOfFeeIndicator.Dirty = value;
                _titleExaminationFeeToBeFinancedIndicator.Dirty = value;
                _titleExaminationPortionOfFeeIndicator.Dirty = value;
                _titleInsuranceFeeToBeFinancedIndicator.Dirty = value;
                _titleInsurancePortionOfFeeIndicator.Dirty = value;
                _titleSearchFeeToBeFinancedIndicator.Dirty = value;
                _titleSearchPortionOfFeeIndicator.Dirty = value;
                _totalPointsAndFees.Dirty = value;
                _treasurySecurityYield.Dirty = value;
                _underwritingFeeToBeFinancedIndicator.Dirty = value;
                _underwritingPortionOfFeeIndicator.Dirty = value;
                _userDefined1109BorPaidAmount.Dirty = value;
                _userDefined1109FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1109PortionOfFeeIndicator.Dirty = value;
                _userDefined1110BorPaidAmount.Dirty = value;
                _userDefined1110FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1110PortionOfFeeIndicator.Dirty = value;
                _userDefined1111FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1111PortionOfFeeIndicator.Dirty = value;
                _userDefined1112FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1112PortionOfFeeIndicator.Dirty = value;
                _userDefined1113FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1113PortionOfFeeIndicator.Dirty = value;
                _userDefined1114FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1114PortionOfFeeIndicator.Dirty = value;
                _userDefined1204FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1204PortionOfFeeIndicator.Dirty = value;
                _userDefined1205FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1205PortionOfFeeIndicator.Dirty = value;
                _userDefined1206FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1206PortionOfFeeIndicator.Dirty = value;
                _userDefined1303FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1303PortionOfFeeIndicator.Dirty = value;
                _userDefined1304FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1304PortionOfFeeIndicator.Dirty = value;
                _userDefined1305FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1305PortionOfFeeIndicator.Dirty = value;
                _userDefined1306FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1306PortionOfFeeIndicator.Dirty = value;
                _userDefined1307FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1307PortionOfFeeIndicator.Dirty = value;
                _userDefined1308FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1308PortionOfFeeIndicator.Dirty = value;
                _userDefined1309FeeToBeFinancedIndicator.Dirty = value;
                _userDefined1309PortionOfFeeIndicator.Dirty = value;
                _userDefined813FeeToBeFinancedIndicator.Dirty = value;
                _userDefined813PortionOfFeeIndicator.Dirty = value;
                _userDefined814FeeToBeFinancedIndicator.Dirty = value;
                _userDefined814PortionOfFeeIndicator.Dirty = value;
                _userDefined815FeeToBeFinancedIndicator.Dirty = value;
                _userDefined815PortionOfFeeIndicator.Dirty = value;
                _userDefined816FeeToBeFinancedIndicator.Dirty = value;
                _userDefined816PortionOfFeeIndicator.Dirty = value;
                _userDefined817FeeToBeFinancedIndicator.Dirty = value;
                _userDefined817PortionOfFeeIndicator.Dirty = value;
                _userDefined818FeeToBeFinancedIndicator.Dirty = value;
                _userDefined818PortionOfFeeIndicator.Dirty = value;
                _userDefined819FeeToBeFinancedIndicator.Dirty = value;
                _userDefined819PortionOfFeeIndicator.Dirty = value;
                _userDefined820FeeToBeFinancedIndicator.Dirty = value;
                _userDefined820PortionOfFeeIndicator.Dirty = value;
                _userDefined821FeeToBeFinancedIndicator.Dirty = value;
                _userDefined821PortionOfFeeIndicator.Dirty = value;
                _userDefined822FeeToBeFinancedIndicator.Dirty = value;
                _userDefined822PortionOfFeeIndicator.Dirty = value;
                _userDefined823FeeToBeFinancedIndicator.Dirty = value;
                _userDefined823PortionOfFeeIndicator.Dirty = value;
                _wireTransferFeeToBeFinancedIndicator.Dirty = value;
                _wireTransferPortionOfFeeIndicator.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}