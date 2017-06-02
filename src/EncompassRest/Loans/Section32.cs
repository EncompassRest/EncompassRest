using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Section32 : IClean
    {
        private Value<bool?> _appraisalFeeToBeFinancedIndicator;
        public bool? AppraisalFeeToBeFinancedIndicator { get { return _appraisalFeeToBeFinancedIndicator; } set { _appraisalFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _appraisalPortionOfFeeIndicator;
        public bool? AppraisalPortionOfFeeIndicator { get { return _appraisalPortionOfFeeIndicator; } set { _appraisalPortionOfFeeIndicator = value; } }
        private Value<decimal?> _aprExceedsTsyForFirstMortgage;
        public decimal? AprExceedsTsyForFirstMortgage { get { return _aprExceedsTsyForFirstMortgage; } set { _aprExceedsTsyForFirstMortgage = value; } }
        private Value<decimal?> _aprExceedsTsyForSubordinateMortgage;
        public decimal? AprExceedsTsyForSubordinateMortgage { get { return _aprExceedsTsyForSubordinateMortgage; } set { _aprExceedsTsyForSubordinateMortgage = value; } }
        private Value<bool?> _assumptionFeeToBeFinancedIndicator;
        public bool? AssumptionFeeToBeFinancedIndicator { get { return _assumptionFeeToBeFinancedIndicator; } set { _assumptionFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _assumptionPortionOfFeeIndicator;
        public bool? AssumptionPortionOfFeeIndicator { get { return _assumptionPortionOfFeeIndicator; } set { _assumptionPortionOfFeeIndicator = value; } }
        private Value<bool?> _attorneyFeeToBeFinancedIndicator;
        public bool? AttorneyFeeToBeFinancedIndicator { get { return _attorneyFeeToBeFinancedIndicator; } set { _attorneyFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _attorneyPortionOfFeeIndicator;
        public bool? AttorneyPortionOfFeeIndicator { get { return _attorneyPortionOfFeeIndicator; } set { _attorneyPortionOfFeeIndicator = value; } }
        private Value<bool?> _cityCountyTaxStampsFeeToBeFinancedIndicator;
        public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get { return _cityCountyTaxStampsFeeToBeFinancedIndicator; } set { _cityCountyTaxStampsFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _cityCountyTaxStampsPortionOfFeeIndicator;
        public bool? CityCountyTaxStampsPortionOfFeeIndicator { get { return _cityCountyTaxStampsPortionOfFeeIndicator; } set { _cityCountyTaxStampsPortionOfFeeIndicator = value; } }
        private Value<bool?> _closingFeeToBeFinancedIndicator;
        public bool? ClosingFeeToBeFinancedIndicator { get { return _closingFeeToBeFinancedIndicator; } set { _closingFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _closingPortionOfFeeIndicator;
        public bool? ClosingPortionOfFeeIndicator { get { return _closingPortionOfFeeIndicator; } set { _closingPortionOfFeeIndicator = value; } }
        private Value<bool?> _creditReportFeeToBeFinancedIndicator;
        public bool? CreditReportFeeToBeFinancedIndicator { get { return _creditReportFeeToBeFinancedIndicator; } set { _creditReportFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _creditReportPortionOfFeeIndicator;
        public bool? CreditReportPortionOfFeeIndicator { get { return _creditReportPortionOfFeeIndicator; } set { _creditReportPortionOfFeeIndicator = value; } }
        private Value<bool?> _docPrepFeeToBeFinancedIndicator;
        public bool? DocPrepFeeToBeFinancedIndicator { get { return _docPrepFeeToBeFinancedIndicator; } set { _docPrepFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _docPrepPortionOfFeeIndicator;
        public bool? DocPrepPortionOfFeeIndicator { get { return _docPrepPortionOfFeeIndicator; } set { _docPrepPortionOfFeeIndicator = value; } }
        private Value<string> _exceed2PercentPrepayPenalty;
        public string Exceed2PercentPrepayPenalty { get { return _exceed2PercentPrepayPenalty; } set { _exceed2PercentPrepayPenalty = value; } }
        private Value<decimal?> _hoepaAPR;
        public decimal? HoepaAPR { get { return _hoepaAPR; } set { _hoepaAPR = value; } }
        private Value<decimal?> _hoepaFee;
        public decimal? HoepaFee { get { return _hoepaFee; } set { _hoepaFee = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _jurisdications;
        public string Jurisdications { get { return _jurisdications; } set { _jurisdications = value; } }
        private Value<bool?> _lendersInspectionFeeToBeFinancedIndicator;
        public bool? LendersInspectionFeeToBeFinancedIndicator { get { return _lendersInspectionFeeToBeFinancedIndicator; } set { _lendersInspectionFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _lendersInspectionPortionOfFeeIndicator;
        public bool? LendersInspectionPortionOfFeeIndicator { get { return _lendersInspectionPortionOfFeeIndicator; } set { _lendersInspectionPortionOfFeeIndicator = value; } }
        private Value<bool?> _loanDiscountFeeToBeFinancedIndicator;
        public bool? LoanDiscountFeeToBeFinancedIndicator { get { return _loanDiscountFeeToBeFinancedIndicator; } set { _loanDiscountFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _loanDiscountPortionOfFeeIndicator;
        public bool? LoanDiscountPortionOfFeeIndicator { get { return _loanDiscountPortionOfFeeIndicator; } set { _loanDiscountPortionOfFeeIndicator = value; } }
        private Value<bool?> _loanOriginationFeeToBeFinancedIndicator;
        public bool? LoanOriginationFeeToBeFinancedIndicator { get { return _loanOriginationFeeToBeFinancedIndicator; } set { _loanOriginationFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _loanOriginationPortionOfFeeIndicator;
        public bool? LoanOriginationPortionOfFeeIndicator { get { return _loanOriginationPortionOfFeeIndicator; } set { _loanOriginationPortionOfFeeIndicator = value; } }
        private Value<string> _loanQualifyAsHighCostMortgage;
        public string LoanQualifyAsHighCostMortgage { get { return _loanQualifyAsHighCostMortgage; } set { _loanQualifyAsHighCostMortgage = value; } }
        private Value<decimal?> _maximumPercentageOfLoan;
        public decimal? MaximumPercentageOfLoan { get { return _maximumPercentageOfLoan; } set { _maximumPercentageOfLoan = value; } }
        private Value<decimal?> _maximumPointsAndFees;
        public decimal? MaximumPointsAndFees { get { return _maximumPointsAndFees; } set { _maximumPointsAndFees = value; } }
        private Value<bool?> _mortgageBrokerFeeToBeFinancedIndicator;
        public bool? MortgageBrokerFeeToBeFinancedIndicator { get { return _mortgageBrokerFeeToBeFinancedIndicator; } set { _mortgageBrokerFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _mortgageBrokerPortionOfFeeIndicator;
        public bool? MortgageBrokerPortionOfFeeIndicator { get { return _mortgageBrokerPortionOfFeeIndicator; } set { _mortgageBrokerPortionOfFeeIndicator = value; } }
        private Value<bool?> _mortgageInspectionFeeToBeFinancedIndicator;
        public bool? MortgageInspectionFeeToBeFinancedIndicator { get { return _mortgageInspectionFeeToBeFinancedIndicator; } set { _mortgageInspectionFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _mortgageInspectionPortionOfFeeIndicator;
        public bool? MortgageInspectionPortionOfFeeIndicator { get { return _mortgageInspectionPortionOfFeeIndicator; } set { _mortgageInspectionPortionOfFeeIndicator = value; } }
        private Value<bool?> _mortgageInsuranceFeeToBeFinancedIndicator;
        public bool? MortgageInsuranceFeeToBeFinancedIndicator { get { return _mortgageInsuranceFeeToBeFinancedIndicator; } set { _mortgageInsuranceFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _mortgageInsurancePortionOfFeeIndicator;
        public bool? MortgageInsurancePortionOfFeeIndicator { get { return _mortgageInsurancePortionOfFeeIndicator; } set { _mortgageInsurancePortionOfFeeIndicator = value; } }
        private Value<bool?> _mortgageInsurancePremiumFeeToBeFinancedIndicator;
        public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get { return _mortgageInsurancePremiumFeeToBeFinancedIndicator; } set { _mortgageInsurancePremiumFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _mortgageInsurancePremiumPortionOfFeeIndicator;
        public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get { return _mortgageInsurancePremiumPortionOfFeeIndicator; } set { _mortgageInsurancePremiumPortionOfFeeIndicator = value; } }
        private Value<bool?> _notaryFeeToBeFinancedIndicator;
        public bool? NotaryFeeToBeFinancedIndicator { get { return _notaryFeeToBeFinancedIndicator; } set { _notaryFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _notaryPortionOfFeeIndicator;
        public bool? NotaryPortionOfFeeIndicator { get { return _notaryPortionOfFeeIndicator; } set { _notaryPortionOfFeeIndicator = value; } }
        private Value<bool?> _otherHighCostIndicator;
        public bool? OtherHighCostIndicator { get { return _otherHighCostIndicator; } set { _otherHighCostIndicator = value; } }
        private Value<string> _penaltyChargeMoreThan36Months;
        public string PenaltyChargeMoreThan36Months { get { return _penaltyChargeMoreThan36Months; } set { _penaltyChargeMoreThan36Months = value; } }
        private Value<bool?> _pestInspectionFeeToBeFinancedIndicator;
        public bool? PestInspectionFeeToBeFinancedIndicator { get { return _pestInspectionFeeToBeFinancedIndicator; } set { _pestInspectionFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _pestInspectionPortionOfFeeIndicator;
        public bool? PestInspectionPortionOfFeeIndicator { get { return _pestInspectionPortionOfFeeIndicator; } set { _pestInspectionPortionOfFeeIndicator = value; } }
        private Value<decimal?> _prepayPenaltyPercentofAmtPrepaid;
        public decimal? PrepayPenaltyPercentofAmtPrepaid { get { return _prepayPenaltyPercentofAmtPrepaid; } set { _prepayPenaltyPercentofAmtPrepaid = value; } }
        private Value<bool?> _processingFeeToBeFinancedIndicator;
        public bool? ProcessingFeeToBeFinancedIndicator { get { return _processingFeeToBeFinancedIndicator; } set { _processingFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _processingPortionOfFeeIndicator;
        public bool? ProcessingPortionOfFeeIndicator { get { return _processingPortionOfFeeIndicator; } set { _processingPortionOfFeeIndicator = value; } }
        private Value<decimal?> _rateSetIndex;
        public decimal? RateSetIndex { get { return _rateSetIndex; } set { _rateSetIndex = value; } }
        private Value<bool?> _recordingFeeToBeFinancedIndicator;
        public bool? RecordingFeeToBeFinancedIndicator { get { return _recordingFeeToBeFinancedIndicator; } set { _recordingFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _recordingPortionOfFeeIndicator;
        public bool? RecordingPortionOfFeeIndicator { get { return _recordingPortionOfFeeIndicator; } set { _recordingPortionOfFeeIndicator = value; } }
        private Value<string> _resultOfPointAndFees;
        public string ResultOfPointAndFees { get { return _resultOfPointAndFees; } set { _resultOfPointAndFees = value; } }
        private Value<string> _resultOfSecurityYieldTest;
        public string ResultOfSecurityYieldTest { get { return _resultOfSecurityYieldTest; } set { _resultOfSecurityYieldTest = value; } }
        private Value<bool?> _section32Indicator;
        public bool? Section32Indicator { get { return _section32Indicator; } set { _section32Indicator = value; } }
        private Value<decimal?> _section35AveragePrimeRate;
        public decimal? Section35AveragePrimeRate { get { return _section35AveragePrimeRate; } set { _section35AveragePrimeRate = value; } }
        private Value<string> _section35IsSecondAppraisalRequired;
        public string Section35IsSecondAppraisalRequired { get { return _section35IsSecondAppraisalRequired; } set { _section35IsSecondAppraisalRequired = value; } }
        private Value<DateTime?> _section35PriorAcquisitionDate;
        public DateTime? Section35PriorAcquisitionDate { get { return _section35PriorAcquisitionDate; } set { _section35PriorAcquisitionDate = value; } }
        private Value<decimal?> _section35PriorAcquisitionPrice;
        public decimal? Section35PriorAcquisitionPrice { get { return _section35PriorAcquisitionPrice; } set { _section35PriorAcquisitionPrice = value; } }
        private Value<string> _section35PriorAcquisitionSource;
        public string Section35PriorAcquisitionSource { get { return _section35PriorAcquisitionSource; } set { _section35PriorAcquisitionSource = value; } }
        private Value<string> _section35ResultOfSecurityYieldTest;
        public string Section35ResultOfSecurityYieldTest { get { return _section35ResultOfSecurityYieldTest; } set { _section35ResultOfSecurityYieldTest = value; } }
        private Value<DateTime?> _section35SalesContractDate;
        public DateTime? Section35SalesContractDate { get { return _section35SalesContractDate; } set { _section35SalesContractDate = value; } }
        private Value<bool?> _stateTaxStampsFeeToBeFinancedIndicator;
        public bool? StateTaxStampsFeeToBeFinancedIndicator { get { return _stateTaxStampsFeeToBeFinancedIndicator; } set { _stateTaxStampsFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _stateTaxStampsPortionOfFeeIndicator;
        public bool? StateTaxStampsPortionOfFeeIndicator { get { return _stateTaxStampsPortionOfFeeIndicator; } set { _stateTaxStampsPortionOfFeeIndicator = value; } }
        private Value<bool?> _surveyFeeToBeFinancedIndicator;
        public bool? SurveyFeeToBeFinancedIndicator { get { return _surveyFeeToBeFinancedIndicator; } set { _surveyFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _surveyPortionOfFeeIndicator;
        public bool? SurveyPortionOfFeeIndicator { get { return _surveyPortionOfFeeIndicator; } set { _surveyPortionOfFeeIndicator = value; } }
        private Value<bool?> _taxServiceFeeToBeFinancedIndicator;
        public bool? TaxServiceFeeToBeFinancedIndicator { get { return _taxServiceFeeToBeFinancedIndicator; } set { _taxServiceFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _taxServicePortionOfFeeIndicator;
        public bool? TaxServicePortionOfFeeIndicator { get { return _taxServicePortionOfFeeIndicator; } set { _taxServicePortionOfFeeIndicator = value; } }
        private Value<bool?> _titleBinderFeeToBeFinancedIndicator;
        public bool? TitleBinderFeeToBeFinancedIndicator { get { return _titleBinderFeeToBeFinancedIndicator; } set { _titleBinderFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _titleBinderPortionOfFeeIndicator;
        public bool? TitleBinderPortionOfFeeIndicator { get { return _titleBinderPortionOfFeeIndicator; } set { _titleBinderPortionOfFeeIndicator = value; } }
        private Value<bool?> _titleExaminationFeeToBeFinancedIndicator;
        public bool? TitleExaminationFeeToBeFinancedIndicator { get { return _titleExaminationFeeToBeFinancedIndicator; } set { _titleExaminationFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _titleExaminationPortionOfFeeIndicator;
        public bool? TitleExaminationPortionOfFeeIndicator { get { return _titleExaminationPortionOfFeeIndicator; } set { _titleExaminationPortionOfFeeIndicator = value; } }
        private Value<bool?> _titleInsuranceFeeToBeFinancedIndicator;
        public bool? TitleInsuranceFeeToBeFinancedIndicator { get { return _titleInsuranceFeeToBeFinancedIndicator; } set { _titleInsuranceFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _titleInsurancePortionOfFeeIndicator;
        public bool? TitleInsurancePortionOfFeeIndicator { get { return _titleInsurancePortionOfFeeIndicator; } set { _titleInsurancePortionOfFeeIndicator = value; } }
        private Value<bool?> _titleSearchFeeToBeFinancedIndicator;
        public bool? TitleSearchFeeToBeFinancedIndicator { get { return _titleSearchFeeToBeFinancedIndicator; } set { _titleSearchFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _titleSearchPortionOfFeeIndicator;
        public bool? TitleSearchPortionOfFeeIndicator { get { return _titleSearchPortionOfFeeIndicator; } set { _titleSearchPortionOfFeeIndicator = value; } }
        private Value<decimal?> _totalPointsAndFees;
        public decimal? TotalPointsAndFees { get { return _totalPointsAndFees; } set { _totalPointsAndFees = value; } }
        private Value<decimal?> _treasurySecurityYield;
        public decimal? TreasurySecurityYield { get { return _treasurySecurityYield; } set { _treasurySecurityYield = value; } }
        private Value<bool?> _underwritingFeeToBeFinancedIndicator;
        public bool? UnderwritingFeeToBeFinancedIndicator { get { return _underwritingFeeToBeFinancedIndicator; } set { _underwritingFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _underwritingPortionOfFeeIndicator;
        public bool? UnderwritingPortionOfFeeIndicator { get { return _underwritingPortionOfFeeIndicator; } set { _underwritingPortionOfFeeIndicator = value; } }
        private Value<decimal?> _userDefined1109BorPaidAmount;
        public decimal? UserDefined1109BorPaidAmount { get { return _userDefined1109BorPaidAmount; } set { _userDefined1109BorPaidAmount = value; } }
        private Value<bool?> _userDefined1109FeeToBeFinancedIndicator;
        public bool? UserDefined1109FeeToBeFinancedIndicator { get { return _userDefined1109FeeToBeFinancedIndicator; } set { _userDefined1109FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1109PortionOfFeeIndicator;
        public bool? UserDefined1109PortionOfFeeIndicator { get { return _userDefined1109PortionOfFeeIndicator; } set { _userDefined1109PortionOfFeeIndicator = value; } }
        private Value<decimal?> _userDefined1110BorPaidAmount;
        public decimal? UserDefined1110BorPaidAmount { get { return _userDefined1110BorPaidAmount; } set { _userDefined1110BorPaidAmount = value; } }
        private Value<bool?> _userDefined1110FeeToBeFinancedIndicator;
        public bool? UserDefined1110FeeToBeFinancedIndicator { get { return _userDefined1110FeeToBeFinancedIndicator; } set { _userDefined1110FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1110PortionOfFeeIndicator;
        public bool? UserDefined1110PortionOfFeeIndicator { get { return _userDefined1110PortionOfFeeIndicator; } set { _userDefined1110PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1111FeeToBeFinancedIndicator;
        public bool? UserDefined1111FeeToBeFinancedIndicator { get { return _userDefined1111FeeToBeFinancedIndicator; } set { _userDefined1111FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1111PortionOfFeeIndicator;
        public bool? UserDefined1111PortionOfFeeIndicator { get { return _userDefined1111PortionOfFeeIndicator; } set { _userDefined1111PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1112FeeToBeFinancedIndicator;
        public bool? UserDefined1112FeeToBeFinancedIndicator { get { return _userDefined1112FeeToBeFinancedIndicator; } set { _userDefined1112FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1112PortionOfFeeIndicator;
        public bool? UserDefined1112PortionOfFeeIndicator { get { return _userDefined1112PortionOfFeeIndicator; } set { _userDefined1112PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1113FeeToBeFinancedIndicator;
        public bool? UserDefined1113FeeToBeFinancedIndicator { get { return _userDefined1113FeeToBeFinancedIndicator; } set { _userDefined1113FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1113PortionOfFeeIndicator;
        public bool? UserDefined1113PortionOfFeeIndicator { get { return _userDefined1113PortionOfFeeIndicator; } set { _userDefined1113PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1114FeeToBeFinancedIndicator;
        public bool? UserDefined1114FeeToBeFinancedIndicator { get { return _userDefined1114FeeToBeFinancedIndicator; } set { _userDefined1114FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1114PortionOfFeeIndicator;
        public bool? UserDefined1114PortionOfFeeIndicator { get { return _userDefined1114PortionOfFeeIndicator; } set { _userDefined1114PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1204FeeToBeFinancedIndicator;
        public bool? UserDefined1204FeeToBeFinancedIndicator { get { return _userDefined1204FeeToBeFinancedIndicator; } set { _userDefined1204FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1204PortionOfFeeIndicator;
        public bool? UserDefined1204PortionOfFeeIndicator { get { return _userDefined1204PortionOfFeeIndicator; } set { _userDefined1204PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1205FeeToBeFinancedIndicator;
        public bool? UserDefined1205FeeToBeFinancedIndicator { get { return _userDefined1205FeeToBeFinancedIndicator; } set { _userDefined1205FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1205PortionOfFeeIndicator;
        public bool? UserDefined1205PortionOfFeeIndicator { get { return _userDefined1205PortionOfFeeIndicator; } set { _userDefined1205PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1206FeeToBeFinancedIndicator;
        public bool? UserDefined1206FeeToBeFinancedIndicator { get { return _userDefined1206FeeToBeFinancedIndicator; } set { _userDefined1206FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1206PortionOfFeeIndicator;
        public bool? UserDefined1206PortionOfFeeIndicator { get { return _userDefined1206PortionOfFeeIndicator; } set { _userDefined1206PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1303FeeToBeFinancedIndicator;
        public bool? UserDefined1303FeeToBeFinancedIndicator { get { return _userDefined1303FeeToBeFinancedIndicator; } set { _userDefined1303FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1303PortionOfFeeIndicator;
        public bool? UserDefined1303PortionOfFeeIndicator { get { return _userDefined1303PortionOfFeeIndicator; } set { _userDefined1303PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1304FeeToBeFinancedIndicator;
        public bool? UserDefined1304FeeToBeFinancedIndicator { get { return _userDefined1304FeeToBeFinancedIndicator; } set { _userDefined1304FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1304PortionOfFeeIndicator;
        public bool? UserDefined1304PortionOfFeeIndicator { get { return _userDefined1304PortionOfFeeIndicator; } set { _userDefined1304PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1305FeeToBeFinancedIndicator;
        public bool? UserDefined1305FeeToBeFinancedIndicator { get { return _userDefined1305FeeToBeFinancedIndicator; } set { _userDefined1305FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1305PortionOfFeeIndicator;
        public bool? UserDefined1305PortionOfFeeIndicator { get { return _userDefined1305PortionOfFeeIndicator; } set { _userDefined1305PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1306FeeToBeFinancedIndicator;
        public bool? UserDefined1306FeeToBeFinancedIndicator { get { return _userDefined1306FeeToBeFinancedIndicator; } set { _userDefined1306FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1306PortionOfFeeIndicator;
        public bool? UserDefined1306PortionOfFeeIndicator { get { return _userDefined1306PortionOfFeeIndicator; } set { _userDefined1306PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1307FeeToBeFinancedIndicator;
        public bool? UserDefined1307FeeToBeFinancedIndicator { get { return _userDefined1307FeeToBeFinancedIndicator; } set { _userDefined1307FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1307PortionOfFeeIndicator;
        public bool? UserDefined1307PortionOfFeeIndicator { get { return _userDefined1307PortionOfFeeIndicator; } set { _userDefined1307PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1308FeeToBeFinancedIndicator;
        public bool? UserDefined1308FeeToBeFinancedIndicator { get { return _userDefined1308FeeToBeFinancedIndicator; } set { _userDefined1308FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1308PortionOfFeeIndicator;
        public bool? UserDefined1308PortionOfFeeIndicator { get { return _userDefined1308PortionOfFeeIndicator; } set { _userDefined1308PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined1309FeeToBeFinancedIndicator;
        public bool? UserDefined1309FeeToBeFinancedIndicator { get { return _userDefined1309FeeToBeFinancedIndicator; } set { _userDefined1309FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined1309PortionOfFeeIndicator;
        public bool? UserDefined1309PortionOfFeeIndicator { get { return _userDefined1309PortionOfFeeIndicator; } set { _userDefined1309PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined813FeeToBeFinancedIndicator;
        public bool? UserDefined813FeeToBeFinancedIndicator { get { return _userDefined813FeeToBeFinancedIndicator; } set { _userDefined813FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined813PortionOfFeeIndicator;
        public bool? UserDefined813PortionOfFeeIndicator { get { return _userDefined813PortionOfFeeIndicator; } set { _userDefined813PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined814FeeToBeFinancedIndicator;
        public bool? UserDefined814FeeToBeFinancedIndicator { get { return _userDefined814FeeToBeFinancedIndicator; } set { _userDefined814FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined814PortionOfFeeIndicator;
        public bool? UserDefined814PortionOfFeeIndicator { get { return _userDefined814PortionOfFeeIndicator; } set { _userDefined814PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined815FeeToBeFinancedIndicator;
        public bool? UserDefined815FeeToBeFinancedIndicator { get { return _userDefined815FeeToBeFinancedIndicator; } set { _userDefined815FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined815PortionOfFeeIndicator;
        public bool? UserDefined815PortionOfFeeIndicator { get { return _userDefined815PortionOfFeeIndicator; } set { _userDefined815PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined816FeeToBeFinancedIndicator;
        public bool? UserDefined816FeeToBeFinancedIndicator { get { return _userDefined816FeeToBeFinancedIndicator; } set { _userDefined816FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined816PortionOfFeeIndicator;
        public bool? UserDefined816PortionOfFeeIndicator { get { return _userDefined816PortionOfFeeIndicator; } set { _userDefined816PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined817FeeToBeFinancedIndicator;
        public bool? UserDefined817FeeToBeFinancedIndicator { get { return _userDefined817FeeToBeFinancedIndicator; } set { _userDefined817FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined817PortionOfFeeIndicator;
        public bool? UserDefined817PortionOfFeeIndicator { get { return _userDefined817PortionOfFeeIndicator; } set { _userDefined817PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined818FeeToBeFinancedIndicator;
        public bool? UserDefined818FeeToBeFinancedIndicator { get { return _userDefined818FeeToBeFinancedIndicator; } set { _userDefined818FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined818PortionOfFeeIndicator;
        public bool? UserDefined818PortionOfFeeIndicator { get { return _userDefined818PortionOfFeeIndicator; } set { _userDefined818PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined819FeeToBeFinancedIndicator;
        public bool? UserDefined819FeeToBeFinancedIndicator { get { return _userDefined819FeeToBeFinancedIndicator; } set { _userDefined819FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined819PortionOfFeeIndicator;
        public bool? UserDefined819PortionOfFeeIndicator { get { return _userDefined819PortionOfFeeIndicator; } set { _userDefined819PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined820FeeToBeFinancedIndicator;
        public bool? UserDefined820FeeToBeFinancedIndicator { get { return _userDefined820FeeToBeFinancedIndicator; } set { _userDefined820FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined820PortionOfFeeIndicator;
        public bool? UserDefined820PortionOfFeeIndicator { get { return _userDefined820PortionOfFeeIndicator; } set { _userDefined820PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined821FeeToBeFinancedIndicator;
        public bool? UserDefined821FeeToBeFinancedIndicator { get { return _userDefined821FeeToBeFinancedIndicator; } set { _userDefined821FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined821PortionOfFeeIndicator;
        public bool? UserDefined821PortionOfFeeIndicator { get { return _userDefined821PortionOfFeeIndicator; } set { _userDefined821PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined822FeeToBeFinancedIndicator;
        public bool? UserDefined822FeeToBeFinancedIndicator { get { return _userDefined822FeeToBeFinancedIndicator; } set { _userDefined822FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined822PortionOfFeeIndicator;
        public bool? UserDefined822PortionOfFeeIndicator { get { return _userDefined822PortionOfFeeIndicator; } set { _userDefined822PortionOfFeeIndicator = value; } }
        private Value<bool?> _userDefined823FeeToBeFinancedIndicator;
        public bool? UserDefined823FeeToBeFinancedIndicator { get { return _userDefined823FeeToBeFinancedIndicator; } set { _userDefined823FeeToBeFinancedIndicator = value; } }
        private Value<bool?> _userDefined823PortionOfFeeIndicator;
        public bool? UserDefined823PortionOfFeeIndicator { get { return _userDefined823PortionOfFeeIndicator; } set { _userDefined823PortionOfFeeIndicator = value; } }
        private Value<bool?> _wireTransferFeeToBeFinancedIndicator;
        public bool? WireTransferFeeToBeFinancedIndicator { get { return _wireTransferFeeToBeFinancedIndicator; } set { _wireTransferFeeToBeFinancedIndicator = value; } }
        private Value<bool?> _wireTransferPortionOfFeeIndicator;
        public bool? WireTransferPortionOfFeeIndicator { get { return _wireTransferPortionOfFeeIndicator; } set { _wireTransferPortionOfFeeIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisalFeeToBeFinancedIndicator.Clean
                    && _appraisalPortionOfFeeIndicator.Clean
                    && _aprExceedsTsyForFirstMortgage.Clean
                    && _aprExceedsTsyForSubordinateMortgage.Clean
                    && _assumptionFeeToBeFinancedIndicator.Clean
                    && _assumptionPortionOfFeeIndicator.Clean
                    && _attorneyFeeToBeFinancedIndicator.Clean
                    && _attorneyPortionOfFeeIndicator.Clean
                    && _cityCountyTaxStampsFeeToBeFinancedIndicator.Clean
                    && _cityCountyTaxStampsPortionOfFeeIndicator.Clean
                    && _closingFeeToBeFinancedIndicator.Clean
                    && _closingPortionOfFeeIndicator.Clean
                    && _creditReportFeeToBeFinancedIndicator.Clean
                    && _creditReportPortionOfFeeIndicator.Clean
                    && _docPrepFeeToBeFinancedIndicator.Clean
                    && _docPrepPortionOfFeeIndicator.Clean
                    && _exceed2PercentPrepayPenalty.Clean
                    && _hoepaAPR.Clean
                    && _hoepaFee.Clean
                    && _id.Clean
                    && _jurisdications.Clean
                    && _lendersInspectionFeeToBeFinancedIndicator.Clean
                    && _lendersInspectionPortionOfFeeIndicator.Clean
                    && _loanDiscountFeeToBeFinancedIndicator.Clean
                    && _loanDiscountPortionOfFeeIndicator.Clean
                    && _loanOriginationFeeToBeFinancedIndicator.Clean
                    && _loanOriginationPortionOfFeeIndicator.Clean
                    && _loanQualifyAsHighCostMortgage.Clean
                    && _maximumPercentageOfLoan.Clean
                    && _maximumPointsAndFees.Clean
                    && _mortgageBrokerFeeToBeFinancedIndicator.Clean
                    && _mortgageBrokerPortionOfFeeIndicator.Clean
                    && _mortgageInspectionFeeToBeFinancedIndicator.Clean
                    && _mortgageInspectionPortionOfFeeIndicator.Clean
                    && _mortgageInsuranceFeeToBeFinancedIndicator.Clean
                    && _mortgageInsurancePortionOfFeeIndicator.Clean
                    && _mortgageInsurancePremiumFeeToBeFinancedIndicator.Clean
                    && _mortgageInsurancePremiumPortionOfFeeIndicator.Clean
                    && _notaryFeeToBeFinancedIndicator.Clean
                    && _notaryPortionOfFeeIndicator.Clean
                    && _otherHighCostIndicator.Clean
                    && _penaltyChargeMoreThan36Months.Clean
                    && _pestInspectionFeeToBeFinancedIndicator.Clean
                    && _pestInspectionPortionOfFeeIndicator.Clean
                    && _prepayPenaltyPercentofAmtPrepaid.Clean
                    && _processingFeeToBeFinancedIndicator.Clean
                    && _processingPortionOfFeeIndicator.Clean
                    && _rateSetIndex.Clean
                    && _recordingFeeToBeFinancedIndicator.Clean
                    && _recordingPortionOfFeeIndicator.Clean
                    && _resultOfPointAndFees.Clean
                    && _resultOfSecurityYieldTest.Clean
                    && _section32Indicator.Clean
                    && _section35AveragePrimeRate.Clean
                    && _section35IsSecondAppraisalRequired.Clean
                    && _section35PriorAcquisitionDate.Clean
                    && _section35PriorAcquisitionPrice.Clean
                    && _section35PriorAcquisitionSource.Clean
                    && _section35ResultOfSecurityYieldTest.Clean
                    && _section35SalesContractDate.Clean
                    && _stateTaxStampsFeeToBeFinancedIndicator.Clean
                    && _stateTaxStampsPortionOfFeeIndicator.Clean
                    && _surveyFeeToBeFinancedIndicator.Clean
                    && _surveyPortionOfFeeIndicator.Clean
                    && _taxServiceFeeToBeFinancedIndicator.Clean
                    && _taxServicePortionOfFeeIndicator.Clean
                    && _titleBinderFeeToBeFinancedIndicator.Clean
                    && _titleBinderPortionOfFeeIndicator.Clean
                    && _titleExaminationFeeToBeFinancedIndicator.Clean
                    && _titleExaminationPortionOfFeeIndicator.Clean
                    && _titleInsuranceFeeToBeFinancedIndicator.Clean
                    && _titleInsurancePortionOfFeeIndicator.Clean
                    && _titleSearchFeeToBeFinancedIndicator.Clean
                    && _titleSearchPortionOfFeeIndicator.Clean
                    && _totalPointsAndFees.Clean
                    && _treasurySecurityYield.Clean
                    && _underwritingFeeToBeFinancedIndicator.Clean
                    && _underwritingPortionOfFeeIndicator.Clean
                    && _userDefined1109BorPaidAmount.Clean
                    && _userDefined1109FeeToBeFinancedIndicator.Clean
                    && _userDefined1109PortionOfFeeIndicator.Clean
                    && _userDefined1110BorPaidAmount.Clean
                    && _userDefined1110FeeToBeFinancedIndicator.Clean
                    && _userDefined1110PortionOfFeeIndicator.Clean
                    && _userDefined1111FeeToBeFinancedIndicator.Clean
                    && _userDefined1111PortionOfFeeIndicator.Clean
                    && _userDefined1112FeeToBeFinancedIndicator.Clean
                    && _userDefined1112PortionOfFeeIndicator.Clean
                    && _userDefined1113FeeToBeFinancedIndicator.Clean
                    && _userDefined1113PortionOfFeeIndicator.Clean
                    && _userDefined1114FeeToBeFinancedIndicator.Clean
                    && _userDefined1114PortionOfFeeIndicator.Clean
                    && _userDefined1204FeeToBeFinancedIndicator.Clean
                    && _userDefined1204PortionOfFeeIndicator.Clean
                    && _userDefined1205FeeToBeFinancedIndicator.Clean
                    && _userDefined1205PortionOfFeeIndicator.Clean
                    && _userDefined1206FeeToBeFinancedIndicator.Clean
                    && _userDefined1206PortionOfFeeIndicator.Clean
                    && _userDefined1303FeeToBeFinancedIndicator.Clean
                    && _userDefined1303PortionOfFeeIndicator.Clean
                    && _userDefined1304FeeToBeFinancedIndicator.Clean
                    && _userDefined1304PortionOfFeeIndicator.Clean
                    && _userDefined1305FeeToBeFinancedIndicator.Clean
                    && _userDefined1305PortionOfFeeIndicator.Clean
                    && _userDefined1306FeeToBeFinancedIndicator.Clean
                    && _userDefined1306PortionOfFeeIndicator.Clean
                    && _userDefined1307FeeToBeFinancedIndicator.Clean
                    && _userDefined1307PortionOfFeeIndicator.Clean
                    && _userDefined1308FeeToBeFinancedIndicator.Clean
                    && _userDefined1308PortionOfFeeIndicator.Clean
                    && _userDefined1309FeeToBeFinancedIndicator.Clean
                    && _userDefined1309PortionOfFeeIndicator.Clean
                    && _userDefined813FeeToBeFinancedIndicator.Clean
                    && _userDefined813PortionOfFeeIndicator.Clean
                    && _userDefined814FeeToBeFinancedIndicator.Clean
                    && _userDefined814PortionOfFeeIndicator.Clean
                    && _userDefined815FeeToBeFinancedIndicator.Clean
                    && _userDefined815PortionOfFeeIndicator.Clean
                    && _userDefined816FeeToBeFinancedIndicator.Clean
                    && _userDefined816PortionOfFeeIndicator.Clean
                    && _userDefined817FeeToBeFinancedIndicator.Clean
                    && _userDefined817PortionOfFeeIndicator.Clean
                    && _userDefined818FeeToBeFinancedIndicator.Clean
                    && _userDefined818PortionOfFeeIndicator.Clean
                    && _userDefined819FeeToBeFinancedIndicator.Clean
                    && _userDefined819PortionOfFeeIndicator.Clean
                    && _userDefined820FeeToBeFinancedIndicator.Clean
                    && _userDefined820PortionOfFeeIndicator.Clean
                    && _userDefined821FeeToBeFinancedIndicator.Clean
                    && _userDefined821PortionOfFeeIndicator.Clean
                    && _userDefined822FeeToBeFinancedIndicator.Clean
                    && _userDefined822PortionOfFeeIndicator.Clean
                    && _userDefined823FeeToBeFinancedIndicator.Clean
                    && _userDefined823PortionOfFeeIndicator.Clean
                    && _wireTransferFeeToBeFinancedIndicator.Clean
                    && _wireTransferPortionOfFeeIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _appraisalFeeToBeFinancedIndicator; v0.Clean = value; _appraisalFeeToBeFinancedIndicator = v0;
                var v1 = _appraisalPortionOfFeeIndicator; v1.Clean = value; _appraisalPortionOfFeeIndicator = v1;
                var v2 = _aprExceedsTsyForFirstMortgage; v2.Clean = value; _aprExceedsTsyForFirstMortgage = v2;
                var v3 = _aprExceedsTsyForSubordinateMortgage; v3.Clean = value; _aprExceedsTsyForSubordinateMortgage = v3;
                var v4 = _assumptionFeeToBeFinancedIndicator; v4.Clean = value; _assumptionFeeToBeFinancedIndicator = v4;
                var v5 = _assumptionPortionOfFeeIndicator; v5.Clean = value; _assumptionPortionOfFeeIndicator = v5;
                var v6 = _attorneyFeeToBeFinancedIndicator; v6.Clean = value; _attorneyFeeToBeFinancedIndicator = v6;
                var v7 = _attorneyPortionOfFeeIndicator; v7.Clean = value; _attorneyPortionOfFeeIndicator = v7;
                var v8 = _cityCountyTaxStampsFeeToBeFinancedIndicator; v8.Clean = value; _cityCountyTaxStampsFeeToBeFinancedIndicator = v8;
                var v9 = _cityCountyTaxStampsPortionOfFeeIndicator; v9.Clean = value; _cityCountyTaxStampsPortionOfFeeIndicator = v9;
                var v10 = _closingFeeToBeFinancedIndicator; v10.Clean = value; _closingFeeToBeFinancedIndicator = v10;
                var v11 = _closingPortionOfFeeIndicator; v11.Clean = value; _closingPortionOfFeeIndicator = v11;
                var v12 = _creditReportFeeToBeFinancedIndicator; v12.Clean = value; _creditReportFeeToBeFinancedIndicator = v12;
                var v13 = _creditReportPortionOfFeeIndicator; v13.Clean = value; _creditReportPortionOfFeeIndicator = v13;
                var v14 = _docPrepFeeToBeFinancedIndicator; v14.Clean = value; _docPrepFeeToBeFinancedIndicator = v14;
                var v15 = _docPrepPortionOfFeeIndicator; v15.Clean = value; _docPrepPortionOfFeeIndicator = v15;
                var v16 = _exceed2PercentPrepayPenalty; v16.Clean = value; _exceed2PercentPrepayPenalty = v16;
                var v17 = _hoepaAPR; v17.Clean = value; _hoepaAPR = v17;
                var v18 = _hoepaFee; v18.Clean = value; _hoepaFee = v18;
                var v19 = _id; v19.Clean = value; _id = v19;
                var v20 = _jurisdications; v20.Clean = value; _jurisdications = v20;
                var v21 = _lendersInspectionFeeToBeFinancedIndicator; v21.Clean = value; _lendersInspectionFeeToBeFinancedIndicator = v21;
                var v22 = _lendersInspectionPortionOfFeeIndicator; v22.Clean = value; _lendersInspectionPortionOfFeeIndicator = v22;
                var v23 = _loanDiscountFeeToBeFinancedIndicator; v23.Clean = value; _loanDiscountFeeToBeFinancedIndicator = v23;
                var v24 = _loanDiscountPortionOfFeeIndicator; v24.Clean = value; _loanDiscountPortionOfFeeIndicator = v24;
                var v25 = _loanOriginationFeeToBeFinancedIndicator; v25.Clean = value; _loanOriginationFeeToBeFinancedIndicator = v25;
                var v26 = _loanOriginationPortionOfFeeIndicator; v26.Clean = value; _loanOriginationPortionOfFeeIndicator = v26;
                var v27 = _loanQualifyAsHighCostMortgage; v27.Clean = value; _loanQualifyAsHighCostMortgage = v27;
                var v28 = _maximumPercentageOfLoan; v28.Clean = value; _maximumPercentageOfLoan = v28;
                var v29 = _maximumPointsAndFees; v29.Clean = value; _maximumPointsAndFees = v29;
                var v30 = _mortgageBrokerFeeToBeFinancedIndicator; v30.Clean = value; _mortgageBrokerFeeToBeFinancedIndicator = v30;
                var v31 = _mortgageBrokerPortionOfFeeIndicator; v31.Clean = value; _mortgageBrokerPortionOfFeeIndicator = v31;
                var v32 = _mortgageInspectionFeeToBeFinancedIndicator; v32.Clean = value; _mortgageInspectionFeeToBeFinancedIndicator = v32;
                var v33 = _mortgageInspectionPortionOfFeeIndicator; v33.Clean = value; _mortgageInspectionPortionOfFeeIndicator = v33;
                var v34 = _mortgageInsuranceFeeToBeFinancedIndicator; v34.Clean = value; _mortgageInsuranceFeeToBeFinancedIndicator = v34;
                var v35 = _mortgageInsurancePortionOfFeeIndicator; v35.Clean = value; _mortgageInsurancePortionOfFeeIndicator = v35;
                var v36 = _mortgageInsurancePremiumFeeToBeFinancedIndicator; v36.Clean = value; _mortgageInsurancePremiumFeeToBeFinancedIndicator = v36;
                var v37 = _mortgageInsurancePremiumPortionOfFeeIndicator; v37.Clean = value; _mortgageInsurancePremiumPortionOfFeeIndicator = v37;
                var v38 = _notaryFeeToBeFinancedIndicator; v38.Clean = value; _notaryFeeToBeFinancedIndicator = v38;
                var v39 = _notaryPortionOfFeeIndicator; v39.Clean = value; _notaryPortionOfFeeIndicator = v39;
                var v40 = _otherHighCostIndicator; v40.Clean = value; _otherHighCostIndicator = v40;
                var v41 = _penaltyChargeMoreThan36Months; v41.Clean = value; _penaltyChargeMoreThan36Months = v41;
                var v42 = _pestInspectionFeeToBeFinancedIndicator; v42.Clean = value; _pestInspectionFeeToBeFinancedIndicator = v42;
                var v43 = _pestInspectionPortionOfFeeIndicator; v43.Clean = value; _pestInspectionPortionOfFeeIndicator = v43;
                var v44 = _prepayPenaltyPercentofAmtPrepaid; v44.Clean = value; _prepayPenaltyPercentofAmtPrepaid = v44;
                var v45 = _processingFeeToBeFinancedIndicator; v45.Clean = value; _processingFeeToBeFinancedIndicator = v45;
                var v46 = _processingPortionOfFeeIndicator; v46.Clean = value; _processingPortionOfFeeIndicator = v46;
                var v47 = _rateSetIndex; v47.Clean = value; _rateSetIndex = v47;
                var v48 = _recordingFeeToBeFinancedIndicator; v48.Clean = value; _recordingFeeToBeFinancedIndicator = v48;
                var v49 = _recordingPortionOfFeeIndicator; v49.Clean = value; _recordingPortionOfFeeIndicator = v49;
                var v50 = _resultOfPointAndFees; v50.Clean = value; _resultOfPointAndFees = v50;
                var v51 = _resultOfSecurityYieldTest; v51.Clean = value; _resultOfSecurityYieldTest = v51;
                var v52 = _section32Indicator; v52.Clean = value; _section32Indicator = v52;
                var v53 = _section35AveragePrimeRate; v53.Clean = value; _section35AveragePrimeRate = v53;
                var v54 = _section35IsSecondAppraisalRequired; v54.Clean = value; _section35IsSecondAppraisalRequired = v54;
                var v55 = _section35PriorAcquisitionDate; v55.Clean = value; _section35PriorAcquisitionDate = v55;
                var v56 = _section35PriorAcquisitionPrice; v56.Clean = value; _section35PriorAcquisitionPrice = v56;
                var v57 = _section35PriorAcquisitionSource; v57.Clean = value; _section35PriorAcquisitionSource = v57;
                var v58 = _section35ResultOfSecurityYieldTest; v58.Clean = value; _section35ResultOfSecurityYieldTest = v58;
                var v59 = _section35SalesContractDate; v59.Clean = value; _section35SalesContractDate = v59;
                var v60 = _stateTaxStampsFeeToBeFinancedIndicator; v60.Clean = value; _stateTaxStampsFeeToBeFinancedIndicator = v60;
                var v61 = _stateTaxStampsPortionOfFeeIndicator; v61.Clean = value; _stateTaxStampsPortionOfFeeIndicator = v61;
                var v62 = _surveyFeeToBeFinancedIndicator; v62.Clean = value; _surveyFeeToBeFinancedIndicator = v62;
                var v63 = _surveyPortionOfFeeIndicator; v63.Clean = value; _surveyPortionOfFeeIndicator = v63;
                var v64 = _taxServiceFeeToBeFinancedIndicator; v64.Clean = value; _taxServiceFeeToBeFinancedIndicator = v64;
                var v65 = _taxServicePortionOfFeeIndicator; v65.Clean = value; _taxServicePortionOfFeeIndicator = v65;
                var v66 = _titleBinderFeeToBeFinancedIndicator; v66.Clean = value; _titleBinderFeeToBeFinancedIndicator = v66;
                var v67 = _titleBinderPortionOfFeeIndicator; v67.Clean = value; _titleBinderPortionOfFeeIndicator = v67;
                var v68 = _titleExaminationFeeToBeFinancedIndicator; v68.Clean = value; _titleExaminationFeeToBeFinancedIndicator = v68;
                var v69 = _titleExaminationPortionOfFeeIndicator; v69.Clean = value; _titleExaminationPortionOfFeeIndicator = v69;
                var v70 = _titleInsuranceFeeToBeFinancedIndicator; v70.Clean = value; _titleInsuranceFeeToBeFinancedIndicator = v70;
                var v71 = _titleInsurancePortionOfFeeIndicator; v71.Clean = value; _titleInsurancePortionOfFeeIndicator = v71;
                var v72 = _titleSearchFeeToBeFinancedIndicator; v72.Clean = value; _titleSearchFeeToBeFinancedIndicator = v72;
                var v73 = _titleSearchPortionOfFeeIndicator; v73.Clean = value; _titleSearchPortionOfFeeIndicator = v73;
                var v74 = _totalPointsAndFees; v74.Clean = value; _totalPointsAndFees = v74;
                var v75 = _treasurySecurityYield; v75.Clean = value; _treasurySecurityYield = v75;
                var v76 = _underwritingFeeToBeFinancedIndicator; v76.Clean = value; _underwritingFeeToBeFinancedIndicator = v76;
                var v77 = _underwritingPortionOfFeeIndicator; v77.Clean = value; _underwritingPortionOfFeeIndicator = v77;
                var v78 = _userDefined1109BorPaidAmount; v78.Clean = value; _userDefined1109BorPaidAmount = v78;
                var v79 = _userDefined1109FeeToBeFinancedIndicator; v79.Clean = value; _userDefined1109FeeToBeFinancedIndicator = v79;
                var v80 = _userDefined1109PortionOfFeeIndicator; v80.Clean = value; _userDefined1109PortionOfFeeIndicator = v80;
                var v81 = _userDefined1110BorPaidAmount; v81.Clean = value; _userDefined1110BorPaidAmount = v81;
                var v82 = _userDefined1110FeeToBeFinancedIndicator; v82.Clean = value; _userDefined1110FeeToBeFinancedIndicator = v82;
                var v83 = _userDefined1110PortionOfFeeIndicator; v83.Clean = value; _userDefined1110PortionOfFeeIndicator = v83;
                var v84 = _userDefined1111FeeToBeFinancedIndicator; v84.Clean = value; _userDefined1111FeeToBeFinancedIndicator = v84;
                var v85 = _userDefined1111PortionOfFeeIndicator; v85.Clean = value; _userDefined1111PortionOfFeeIndicator = v85;
                var v86 = _userDefined1112FeeToBeFinancedIndicator; v86.Clean = value; _userDefined1112FeeToBeFinancedIndicator = v86;
                var v87 = _userDefined1112PortionOfFeeIndicator; v87.Clean = value; _userDefined1112PortionOfFeeIndicator = v87;
                var v88 = _userDefined1113FeeToBeFinancedIndicator; v88.Clean = value; _userDefined1113FeeToBeFinancedIndicator = v88;
                var v89 = _userDefined1113PortionOfFeeIndicator; v89.Clean = value; _userDefined1113PortionOfFeeIndicator = v89;
                var v90 = _userDefined1114FeeToBeFinancedIndicator; v90.Clean = value; _userDefined1114FeeToBeFinancedIndicator = v90;
                var v91 = _userDefined1114PortionOfFeeIndicator; v91.Clean = value; _userDefined1114PortionOfFeeIndicator = v91;
                var v92 = _userDefined1204FeeToBeFinancedIndicator; v92.Clean = value; _userDefined1204FeeToBeFinancedIndicator = v92;
                var v93 = _userDefined1204PortionOfFeeIndicator; v93.Clean = value; _userDefined1204PortionOfFeeIndicator = v93;
                var v94 = _userDefined1205FeeToBeFinancedIndicator; v94.Clean = value; _userDefined1205FeeToBeFinancedIndicator = v94;
                var v95 = _userDefined1205PortionOfFeeIndicator; v95.Clean = value; _userDefined1205PortionOfFeeIndicator = v95;
                var v96 = _userDefined1206FeeToBeFinancedIndicator; v96.Clean = value; _userDefined1206FeeToBeFinancedIndicator = v96;
                var v97 = _userDefined1206PortionOfFeeIndicator; v97.Clean = value; _userDefined1206PortionOfFeeIndicator = v97;
                var v98 = _userDefined1303FeeToBeFinancedIndicator; v98.Clean = value; _userDefined1303FeeToBeFinancedIndicator = v98;
                var v99 = _userDefined1303PortionOfFeeIndicator; v99.Clean = value; _userDefined1303PortionOfFeeIndicator = v99;
                var v100 = _userDefined1304FeeToBeFinancedIndicator; v100.Clean = value; _userDefined1304FeeToBeFinancedIndicator = v100;
                var v101 = _userDefined1304PortionOfFeeIndicator; v101.Clean = value; _userDefined1304PortionOfFeeIndicator = v101;
                var v102 = _userDefined1305FeeToBeFinancedIndicator; v102.Clean = value; _userDefined1305FeeToBeFinancedIndicator = v102;
                var v103 = _userDefined1305PortionOfFeeIndicator; v103.Clean = value; _userDefined1305PortionOfFeeIndicator = v103;
                var v104 = _userDefined1306FeeToBeFinancedIndicator; v104.Clean = value; _userDefined1306FeeToBeFinancedIndicator = v104;
                var v105 = _userDefined1306PortionOfFeeIndicator; v105.Clean = value; _userDefined1306PortionOfFeeIndicator = v105;
                var v106 = _userDefined1307FeeToBeFinancedIndicator; v106.Clean = value; _userDefined1307FeeToBeFinancedIndicator = v106;
                var v107 = _userDefined1307PortionOfFeeIndicator; v107.Clean = value; _userDefined1307PortionOfFeeIndicator = v107;
                var v108 = _userDefined1308FeeToBeFinancedIndicator; v108.Clean = value; _userDefined1308FeeToBeFinancedIndicator = v108;
                var v109 = _userDefined1308PortionOfFeeIndicator; v109.Clean = value; _userDefined1308PortionOfFeeIndicator = v109;
                var v110 = _userDefined1309FeeToBeFinancedIndicator; v110.Clean = value; _userDefined1309FeeToBeFinancedIndicator = v110;
                var v111 = _userDefined1309PortionOfFeeIndicator; v111.Clean = value; _userDefined1309PortionOfFeeIndicator = v111;
                var v112 = _userDefined813FeeToBeFinancedIndicator; v112.Clean = value; _userDefined813FeeToBeFinancedIndicator = v112;
                var v113 = _userDefined813PortionOfFeeIndicator; v113.Clean = value; _userDefined813PortionOfFeeIndicator = v113;
                var v114 = _userDefined814FeeToBeFinancedIndicator; v114.Clean = value; _userDefined814FeeToBeFinancedIndicator = v114;
                var v115 = _userDefined814PortionOfFeeIndicator; v115.Clean = value; _userDefined814PortionOfFeeIndicator = v115;
                var v116 = _userDefined815FeeToBeFinancedIndicator; v116.Clean = value; _userDefined815FeeToBeFinancedIndicator = v116;
                var v117 = _userDefined815PortionOfFeeIndicator; v117.Clean = value; _userDefined815PortionOfFeeIndicator = v117;
                var v118 = _userDefined816FeeToBeFinancedIndicator; v118.Clean = value; _userDefined816FeeToBeFinancedIndicator = v118;
                var v119 = _userDefined816PortionOfFeeIndicator; v119.Clean = value; _userDefined816PortionOfFeeIndicator = v119;
                var v120 = _userDefined817FeeToBeFinancedIndicator; v120.Clean = value; _userDefined817FeeToBeFinancedIndicator = v120;
                var v121 = _userDefined817PortionOfFeeIndicator; v121.Clean = value; _userDefined817PortionOfFeeIndicator = v121;
                var v122 = _userDefined818FeeToBeFinancedIndicator; v122.Clean = value; _userDefined818FeeToBeFinancedIndicator = v122;
                var v123 = _userDefined818PortionOfFeeIndicator; v123.Clean = value; _userDefined818PortionOfFeeIndicator = v123;
                var v124 = _userDefined819FeeToBeFinancedIndicator; v124.Clean = value; _userDefined819FeeToBeFinancedIndicator = v124;
                var v125 = _userDefined819PortionOfFeeIndicator; v125.Clean = value; _userDefined819PortionOfFeeIndicator = v125;
                var v126 = _userDefined820FeeToBeFinancedIndicator; v126.Clean = value; _userDefined820FeeToBeFinancedIndicator = v126;
                var v127 = _userDefined820PortionOfFeeIndicator; v127.Clean = value; _userDefined820PortionOfFeeIndicator = v127;
                var v128 = _userDefined821FeeToBeFinancedIndicator; v128.Clean = value; _userDefined821FeeToBeFinancedIndicator = v128;
                var v129 = _userDefined821PortionOfFeeIndicator; v129.Clean = value; _userDefined821PortionOfFeeIndicator = v129;
                var v130 = _userDefined822FeeToBeFinancedIndicator; v130.Clean = value; _userDefined822FeeToBeFinancedIndicator = v130;
                var v131 = _userDefined822PortionOfFeeIndicator; v131.Clean = value; _userDefined822PortionOfFeeIndicator = v131;
                var v132 = _userDefined823FeeToBeFinancedIndicator; v132.Clean = value; _userDefined823FeeToBeFinancedIndicator = v132;
                var v133 = _userDefined823PortionOfFeeIndicator; v133.Clean = value; _userDefined823PortionOfFeeIndicator = v133;
                var v134 = _wireTransferFeeToBeFinancedIndicator; v134.Clean = value; _wireTransferFeeToBeFinancedIndicator = v134;
                var v135 = _wireTransferPortionOfFeeIndicator; v135.Clean = value; _wireTransferPortionOfFeeIndicator = v135;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Section32()
        {
            Clean = true;
        }
    }
}