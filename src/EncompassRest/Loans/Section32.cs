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
                var appraisalFeeToBeFinancedIndicator = _appraisalFeeToBeFinancedIndicator; appraisalFeeToBeFinancedIndicator.Clean = value; _appraisalFeeToBeFinancedIndicator = appraisalFeeToBeFinancedIndicator;
                var appraisalPortionOfFeeIndicator = _appraisalPortionOfFeeIndicator; appraisalPortionOfFeeIndicator.Clean = value; _appraisalPortionOfFeeIndicator = appraisalPortionOfFeeIndicator;
                var aprExceedsTsyForFirstMortgage = _aprExceedsTsyForFirstMortgage; aprExceedsTsyForFirstMortgage.Clean = value; _aprExceedsTsyForFirstMortgage = aprExceedsTsyForFirstMortgage;
                var aprExceedsTsyForSubordinateMortgage = _aprExceedsTsyForSubordinateMortgage; aprExceedsTsyForSubordinateMortgage.Clean = value; _aprExceedsTsyForSubordinateMortgage = aprExceedsTsyForSubordinateMortgage;
                var assumptionFeeToBeFinancedIndicator = _assumptionFeeToBeFinancedIndicator; assumptionFeeToBeFinancedIndicator.Clean = value; _assumptionFeeToBeFinancedIndicator = assumptionFeeToBeFinancedIndicator;
                var assumptionPortionOfFeeIndicator = _assumptionPortionOfFeeIndicator; assumptionPortionOfFeeIndicator.Clean = value; _assumptionPortionOfFeeIndicator = assumptionPortionOfFeeIndicator;
                var attorneyFeeToBeFinancedIndicator = _attorneyFeeToBeFinancedIndicator; attorneyFeeToBeFinancedIndicator.Clean = value; _attorneyFeeToBeFinancedIndicator = attorneyFeeToBeFinancedIndicator;
                var attorneyPortionOfFeeIndicator = _attorneyPortionOfFeeIndicator; attorneyPortionOfFeeIndicator.Clean = value; _attorneyPortionOfFeeIndicator = attorneyPortionOfFeeIndicator;
                var cityCountyTaxStampsFeeToBeFinancedIndicator = _cityCountyTaxStampsFeeToBeFinancedIndicator; cityCountyTaxStampsFeeToBeFinancedIndicator.Clean = value; _cityCountyTaxStampsFeeToBeFinancedIndicator = cityCountyTaxStampsFeeToBeFinancedIndicator;
                var cityCountyTaxStampsPortionOfFeeIndicator = _cityCountyTaxStampsPortionOfFeeIndicator; cityCountyTaxStampsPortionOfFeeIndicator.Clean = value; _cityCountyTaxStampsPortionOfFeeIndicator = cityCountyTaxStampsPortionOfFeeIndicator;
                var closingFeeToBeFinancedIndicator = _closingFeeToBeFinancedIndicator; closingFeeToBeFinancedIndicator.Clean = value; _closingFeeToBeFinancedIndicator = closingFeeToBeFinancedIndicator;
                var closingPortionOfFeeIndicator = _closingPortionOfFeeIndicator; closingPortionOfFeeIndicator.Clean = value; _closingPortionOfFeeIndicator = closingPortionOfFeeIndicator;
                var creditReportFeeToBeFinancedIndicator = _creditReportFeeToBeFinancedIndicator; creditReportFeeToBeFinancedIndicator.Clean = value; _creditReportFeeToBeFinancedIndicator = creditReportFeeToBeFinancedIndicator;
                var creditReportPortionOfFeeIndicator = _creditReportPortionOfFeeIndicator; creditReportPortionOfFeeIndicator.Clean = value; _creditReportPortionOfFeeIndicator = creditReportPortionOfFeeIndicator;
                var docPrepFeeToBeFinancedIndicator = _docPrepFeeToBeFinancedIndicator; docPrepFeeToBeFinancedIndicator.Clean = value; _docPrepFeeToBeFinancedIndicator = docPrepFeeToBeFinancedIndicator;
                var docPrepPortionOfFeeIndicator = _docPrepPortionOfFeeIndicator; docPrepPortionOfFeeIndicator.Clean = value; _docPrepPortionOfFeeIndicator = docPrepPortionOfFeeIndicator;
                var exceed2PercentPrepayPenalty = _exceed2PercentPrepayPenalty; exceed2PercentPrepayPenalty.Clean = value; _exceed2PercentPrepayPenalty = exceed2PercentPrepayPenalty;
                var hoepaAPR = _hoepaAPR; hoepaAPR.Clean = value; _hoepaAPR = hoepaAPR;
                var hoepaFee = _hoepaFee; hoepaFee.Clean = value; _hoepaFee = hoepaFee;
                var id = _id; id.Clean = value; _id = id;
                var jurisdications = _jurisdications; jurisdications.Clean = value; _jurisdications = jurisdications;
                var lendersInspectionFeeToBeFinancedIndicator = _lendersInspectionFeeToBeFinancedIndicator; lendersInspectionFeeToBeFinancedIndicator.Clean = value; _lendersInspectionFeeToBeFinancedIndicator = lendersInspectionFeeToBeFinancedIndicator;
                var lendersInspectionPortionOfFeeIndicator = _lendersInspectionPortionOfFeeIndicator; lendersInspectionPortionOfFeeIndicator.Clean = value; _lendersInspectionPortionOfFeeIndicator = lendersInspectionPortionOfFeeIndicator;
                var loanDiscountFeeToBeFinancedIndicator = _loanDiscountFeeToBeFinancedIndicator; loanDiscountFeeToBeFinancedIndicator.Clean = value; _loanDiscountFeeToBeFinancedIndicator = loanDiscountFeeToBeFinancedIndicator;
                var loanDiscountPortionOfFeeIndicator = _loanDiscountPortionOfFeeIndicator; loanDiscountPortionOfFeeIndicator.Clean = value; _loanDiscountPortionOfFeeIndicator = loanDiscountPortionOfFeeIndicator;
                var loanOriginationFeeToBeFinancedIndicator = _loanOriginationFeeToBeFinancedIndicator; loanOriginationFeeToBeFinancedIndicator.Clean = value; _loanOriginationFeeToBeFinancedIndicator = loanOriginationFeeToBeFinancedIndicator;
                var loanOriginationPortionOfFeeIndicator = _loanOriginationPortionOfFeeIndicator; loanOriginationPortionOfFeeIndicator.Clean = value; _loanOriginationPortionOfFeeIndicator = loanOriginationPortionOfFeeIndicator;
                var loanQualifyAsHighCostMortgage = _loanQualifyAsHighCostMortgage; loanQualifyAsHighCostMortgage.Clean = value; _loanQualifyAsHighCostMortgage = loanQualifyAsHighCostMortgage;
                var maximumPercentageOfLoan = _maximumPercentageOfLoan; maximumPercentageOfLoan.Clean = value; _maximumPercentageOfLoan = maximumPercentageOfLoan;
                var maximumPointsAndFees = _maximumPointsAndFees; maximumPointsAndFees.Clean = value; _maximumPointsAndFees = maximumPointsAndFees;
                var mortgageBrokerFeeToBeFinancedIndicator = _mortgageBrokerFeeToBeFinancedIndicator; mortgageBrokerFeeToBeFinancedIndicator.Clean = value; _mortgageBrokerFeeToBeFinancedIndicator = mortgageBrokerFeeToBeFinancedIndicator;
                var mortgageBrokerPortionOfFeeIndicator = _mortgageBrokerPortionOfFeeIndicator; mortgageBrokerPortionOfFeeIndicator.Clean = value; _mortgageBrokerPortionOfFeeIndicator = mortgageBrokerPortionOfFeeIndicator;
                var mortgageInspectionFeeToBeFinancedIndicator = _mortgageInspectionFeeToBeFinancedIndicator; mortgageInspectionFeeToBeFinancedIndicator.Clean = value; _mortgageInspectionFeeToBeFinancedIndicator = mortgageInspectionFeeToBeFinancedIndicator;
                var mortgageInspectionPortionOfFeeIndicator = _mortgageInspectionPortionOfFeeIndicator; mortgageInspectionPortionOfFeeIndicator.Clean = value; _mortgageInspectionPortionOfFeeIndicator = mortgageInspectionPortionOfFeeIndicator;
                var mortgageInsuranceFeeToBeFinancedIndicator = _mortgageInsuranceFeeToBeFinancedIndicator; mortgageInsuranceFeeToBeFinancedIndicator.Clean = value; _mortgageInsuranceFeeToBeFinancedIndicator = mortgageInsuranceFeeToBeFinancedIndicator;
                var mortgageInsurancePortionOfFeeIndicator = _mortgageInsurancePortionOfFeeIndicator; mortgageInsurancePortionOfFeeIndicator.Clean = value; _mortgageInsurancePortionOfFeeIndicator = mortgageInsurancePortionOfFeeIndicator;
                var mortgageInsurancePremiumFeeToBeFinancedIndicator = _mortgageInsurancePremiumFeeToBeFinancedIndicator; mortgageInsurancePremiumFeeToBeFinancedIndicator.Clean = value; _mortgageInsurancePremiumFeeToBeFinancedIndicator = mortgageInsurancePremiumFeeToBeFinancedIndicator;
                var mortgageInsurancePremiumPortionOfFeeIndicator = _mortgageInsurancePremiumPortionOfFeeIndicator; mortgageInsurancePremiumPortionOfFeeIndicator.Clean = value; _mortgageInsurancePremiumPortionOfFeeIndicator = mortgageInsurancePremiumPortionOfFeeIndicator;
                var notaryFeeToBeFinancedIndicator = _notaryFeeToBeFinancedIndicator; notaryFeeToBeFinancedIndicator.Clean = value; _notaryFeeToBeFinancedIndicator = notaryFeeToBeFinancedIndicator;
                var notaryPortionOfFeeIndicator = _notaryPortionOfFeeIndicator; notaryPortionOfFeeIndicator.Clean = value; _notaryPortionOfFeeIndicator = notaryPortionOfFeeIndicator;
                var otherHighCostIndicator = _otherHighCostIndicator; otherHighCostIndicator.Clean = value; _otherHighCostIndicator = otherHighCostIndicator;
                var penaltyChargeMoreThan36Months = _penaltyChargeMoreThan36Months; penaltyChargeMoreThan36Months.Clean = value; _penaltyChargeMoreThan36Months = penaltyChargeMoreThan36Months;
                var pestInspectionFeeToBeFinancedIndicator = _pestInspectionFeeToBeFinancedIndicator; pestInspectionFeeToBeFinancedIndicator.Clean = value; _pestInspectionFeeToBeFinancedIndicator = pestInspectionFeeToBeFinancedIndicator;
                var pestInspectionPortionOfFeeIndicator = _pestInspectionPortionOfFeeIndicator; pestInspectionPortionOfFeeIndicator.Clean = value; _pestInspectionPortionOfFeeIndicator = pestInspectionPortionOfFeeIndicator;
                var prepayPenaltyPercentofAmtPrepaid = _prepayPenaltyPercentofAmtPrepaid; prepayPenaltyPercentofAmtPrepaid.Clean = value; _prepayPenaltyPercentofAmtPrepaid = prepayPenaltyPercentofAmtPrepaid;
                var processingFeeToBeFinancedIndicator = _processingFeeToBeFinancedIndicator; processingFeeToBeFinancedIndicator.Clean = value; _processingFeeToBeFinancedIndicator = processingFeeToBeFinancedIndicator;
                var processingPortionOfFeeIndicator = _processingPortionOfFeeIndicator; processingPortionOfFeeIndicator.Clean = value; _processingPortionOfFeeIndicator = processingPortionOfFeeIndicator;
                var rateSetIndex = _rateSetIndex; rateSetIndex.Clean = value; _rateSetIndex = rateSetIndex;
                var recordingFeeToBeFinancedIndicator = _recordingFeeToBeFinancedIndicator; recordingFeeToBeFinancedIndicator.Clean = value; _recordingFeeToBeFinancedIndicator = recordingFeeToBeFinancedIndicator;
                var recordingPortionOfFeeIndicator = _recordingPortionOfFeeIndicator; recordingPortionOfFeeIndicator.Clean = value; _recordingPortionOfFeeIndicator = recordingPortionOfFeeIndicator;
                var resultOfPointAndFees = _resultOfPointAndFees; resultOfPointAndFees.Clean = value; _resultOfPointAndFees = resultOfPointAndFees;
                var resultOfSecurityYieldTest = _resultOfSecurityYieldTest; resultOfSecurityYieldTest.Clean = value; _resultOfSecurityYieldTest = resultOfSecurityYieldTest;
                var section32Indicator = _section32Indicator; section32Indicator.Clean = value; _section32Indicator = section32Indicator;
                var section35AveragePrimeRate = _section35AveragePrimeRate; section35AveragePrimeRate.Clean = value; _section35AveragePrimeRate = section35AveragePrimeRate;
                var section35IsSecondAppraisalRequired = _section35IsSecondAppraisalRequired; section35IsSecondAppraisalRequired.Clean = value; _section35IsSecondAppraisalRequired = section35IsSecondAppraisalRequired;
                var section35PriorAcquisitionDate = _section35PriorAcquisitionDate; section35PriorAcquisitionDate.Clean = value; _section35PriorAcquisitionDate = section35PriorAcquisitionDate;
                var section35PriorAcquisitionPrice = _section35PriorAcquisitionPrice; section35PriorAcquisitionPrice.Clean = value; _section35PriorAcquisitionPrice = section35PriorAcquisitionPrice;
                var section35PriorAcquisitionSource = _section35PriorAcquisitionSource; section35PriorAcquisitionSource.Clean = value; _section35PriorAcquisitionSource = section35PriorAcquisitionSource;
                var section35ResultOfSecurityYieldTest = _section35ResultOfSecurityYieldTest; section35ResultOfSecurityYieldTest.Clean = value; _section35ResultOfSecurityYieldTest = section35ResultOfSecurityYieldTest;
                var section35SalesContractDate = _section35SalesContractDate; section35SalesContractDate.Clean = value; _section35SalesContractDate = section35SalesContractDate;
                var stateTaxStampsFeeToBeFinancedIndicator = _stateTaxStampsFeeToBeFinancedIndicator; stateTaxStampsFeeToBeFinancedIndicator.Clean = value; _stateTaxStampsFeeToBeFinancedIndicator = stateTaxStampsFeeToBeFinancedIndicator;
                var stateTaxStampsPortionOfFeeIndicator = _stateTaxStampsPortionOfFeeIndicator; stateTaxStampsPortionOfFeeIndicator.Clean = value; _stateTaxStampsPortionOfFeeIndicator = stateTaxStampsPortionOfFeeIndicator;
                var surveyFeeToBeFinancedIndicator = _surveyFeeToBeFinancedIndicator; surveyFeeToBeFinancedIndicator.Clean = value; _surveyFeeToBeFinancedIndicator = surveyFeeToBeFinancedIndicator;
                var surveyPortionOfFeeIndicator = _surveyPortionOfFeeIndicator; surveyPortionOfFeeIndicator.Clean = value; _surveyPortionOfFeeIndicator = surveyPortionOfFeeIndicator;
                var taxServiceFeeToBeFinancedIndicator = _taxServiceFeeToBeFinancedIndicator; taxServiceFeeToBeFinancedIndicator.Clean = value; _taxServiceFeeToBeFinancedIndicator = taxServiceFeeToBeFinancedIndicator;
                var taxServicePortionOfFeeIndicator = _taxServicePortionOfFeeIndicator; taxServicePortionOfFeeIndicator.Clean = value; _taxServicePortionOfFeeIndicator = taxServicePortionOfFeeIndicator;
                var titleBinderFeeToBeFinancedIndicator = _titleBinderFeeToBeFinancedIndicator; titleBinderFeeToBeFinancedIndicator.Clean = value; _titleBinderFeeToBeFinancedIndicator = titleBinderFeeToBeFinancedIndicator;
                var titleBinderPortionOfFeeIndicator = _titleBinderPortionOfFeeIndicator; titleBinderPortionOfFeeIndicator.Clean = value; _titleBinderPortionOfFeeIndicator = titleBinderPortionOfFeeIndicator;
                var titleExaminationFeeToBeFinancedIndicator = _titleExaminationFeeToBeFinancedIndicator; titleExaminationFeeToBeFinancedIndicator.Clean = value; _titleExaminationFeeToBeFinancedIndicator = titleExaminationFeeToBeFinancedIndicator;
                var titleExaminationPortionOfFeeIndicator = _titleExaminationPortionOfFeeIndicator; titleExaminationPortionOfFeeIndicator.Clean = value; _titleExaminationPortionOfFeeIndicator = titleExaminationPortionOfFeeIndicator;
                var titleInsuranceFeeToBeFinancedIndicator = _titleInsuranceFeeToBeFinancedIndicator; titleInsuranceFeeToBeFinancedIndicator.Clean = value; _titleInsuranceFeeToBeFinancedIndicator = titleInsuranceFeeToBeFinancedIndicator;
                var titleInsurancePortionOfFeeIndicator = _titleInsurancePortionOfFeeIndicator; titleInsurancePortionOfFeeIndicator.Clean = value; _titleInsurancePortionOfFeeIndicator = titleInsurancePortionOfFeeIndicator;
                var titleSearchFeeToBeFinancedIndicator = _titleSearchFeeToBeFinancedIndicator; titleSearchFeeToBeFinancedIndicator.Clean = value; _titleSearchFeeToBeFinancedIndicator = titleSearchFeeToBeFinancedIndicator;
                var titleSearchPortionOfFeeIndicator = _titleSearchPortionOfFeeIndicator; titleSearchPortionOfFeeIndicator.Clean = value; _titleSearchPortionOfFeeIndicator = titleSearchPortionOfFeeIndicator;
                var totalPointsAndFees = _totalPointsAndFees; totalPointsAndFees.Clean = value; _totalPointsAndFees = totalPointsAndFees;
                var treasurySecurityYield = _treasurySecurityYield; treasurySecurityYield.Clean = value; _treasurySecurityYield = treasurySecurityYield;
                var underwritingFeeToBeFinancedIndicator = _underwritingFeeToBeFinancedIndicator; underwritingFeeToBeFinancedIndicator.Clean = value; _underwritingFeeToBeFinancedIndicator = underwritingFeeToBeFinancedIndicator;
                var underwritingPortionOfFeeIndicator = _underwritingPortionOfFeeIndicator; underwritingPortionOfFeeIndicator.Clean = value; _underwritingPortionOfFeeIndicator = underwritingPortionOfFeeIndicator;
                var userDefined1109BorPaidAmount = _userDefined1109BorPaidAmount; userDefined1109BorPaidAmount.Clean = value; _userDefined1109BorPaidAmount = userDefined1109BorPaidAmount;
                var userDefined1109FeeToBeFinancedIndicator = _userDefined1109FeeToBeFinancedIndicator; userDefined1109FeeToBeFinancedIndicator.Clean = value; _userDefined1109FeeToBeFinancedIndicator = userDefined1109FeeToBeFinancedIndicator;
                var userDefined1109PortionOfFeeIndicator = _userDefined1109PortionOfFeeIndicator; userDefined1109PortionOfFeeIndicator.Clean = value; _userDefined1109PortionOfFeeIndicator = userDefined1109PortionOfFeeIndicator;
                var userDefined1110BorPaidAmount = _userDefined1110BorPaidAmount; userDefined1110BorPaidAmount.Clean = value; _userDefined1110BorPaidAmount = userDefined1110BorPaidAmount;
                var userDefined1110FeeToBeFinancedIndicator = _userDefined1110FeeToBeFinancedIndicator; userDefined1110FeeToBeFinancedIndicator.Clean = value; _userDefined1110FeeToBeFinancedIndicator = userDefined1110FeeToBeFinancedIndicator;
                var userDefined1110PortionOfFeeIndicator = _userDefined1110PortionOfFeeIndicator; userDefined1110PortionOfFeeIndicator.Clean = value; _userDefined1110PortionOfFeeIndicator = userDefined1110PortionOfFeeIndicator;
                var userDefined1111FeeToBeFinancedIndicator = _userDefined1111FeeToBeFinancedIndicator; userDefined1111FeeToBeFinancedIndicator.Clean = value; _userDefined1111FeeToBeFinancedIndicator = userDefined1111FeeToBeFinancedIndicator;
                var userDefined1111PortionOfFeeIndicator = _userDefined1111PortionOfFeeIndicator; userDefined1111PortionOfFeeIndicator.Clean = value; _userDefined1111PortionOfFeeIndicator = userDefined1111PortionOfFeeIndicator;
                var userDefined1112FeeToBeFinancedIndicator = _userDefined1112FeeToBeFinancedIndicator; userDefined1112FeeToBeFinancedIndicator.Clean = value; _userDefined1112FeeToBeFinancedIndicator = userDefined1112FeeToBeFinancedIndicator;
                var userDefined1112PortionOfFeeIndicator = _userDefined1112PortionOfFeeIndicator; userDefined1112PortionOfFeeIndicator.Clean = value; _userDefined1112PortionOfFeeIndicator = userDefined1112PortionOfFeeIndicator;
                var userDefined1113FeeToBeFinancedIndicator = _userDefined1113FeeToBeFinancedIndicator; userDefined1113FeeToBeFinancedIndicator.Clean = value; _userDefined1113FeeToBeFinancedIndicator = userDefined1113FeeToBeFinancedIndicator;
                var userDefined1113PortionOfFeeIndicator = _userDefined1113PortionOfFeeIndicator; userDefined1113PortionOfFeeIndicator.Clean = value; _userDefined1113PortionOfFeeIndicator = userDefined1113PortionOfFeeIndicator;
                var userDefined1114FeeToBeFinancedIndicator = _userDefined1114FeeToBeFinancedIndicator; userDefined1114FeeToBeFinancedIndicator.Clean = value; _userDefined1114FeeToBeFinancedIndicator = userDefined1114FeeToBeFinancedIndicator;
                var userDefined1114PortionOfFeeIndicator = _userDefined1114PortionOfFeeIndicator; userDefined1114PortionOfFeeIndicator.Clean = value; _userDefined1114PortionOfFeeIndicator = userDefined1114PortionOfFeeIndicator;
                var userDefined1204FeeToBeFinancedIndicator = _userDefined1204FeeToBeFinancedIndicator; userDefined1204FeeToBeFinancedIndicator.Clean = value; _userDefined1204FeeToBeFinancedIndicator = userDefined1204FeeToBeFinancedIndicator;
                var userDefined1204PortionOfFeeIndicator = _userDefined1204PortionOfFeeIndicator; userDefined1204PortionOfFeeIndicator.Clean = value; _userDefined1204PortionOfFeeIndicator = userDefined1204PortionOfFeeIndicator;
                var userDefined1205FeeToBeFinancedIndicator = _userDefined1205FeeToBeFinancedIndicator; userDefined1205FeeToBeFinancedIndicator.Clean = value; _userDefined1205FeeToBeFinancedIndicator = userDefined1205FeeToBeFinancedIndicator;
                var userDefined1205PortionOfFeeIndicator = _userDefined1205PortionOfFeeIndicator; userDefined1205PortionOfFeeIndicator.Clean = value; _userDefined1205PortionOfFeeIndicator = userDefined1205PortionOfFeeIndicator;
                var userDefined1206FeeToBeFinancedIndicator = _userDefined1206FeeToBeFinancedIndicator; userDefined1206FeeToBeFinancedIndicator.Clean = value; _userDefined1206FeeToBeFinancedIndicator = userDefined1206FeeToBeFinancedIndicator;
                var userDefined1206PortionOfFeeIndicator = _userDefined1206PortionOfFeeIndicator; userDefined1206PortionOfFeeIndicator.Clean = value; _userDefined1206PortionOfFeeIndicator = userDefined1206PortionOfFeeIndicator;
                var userDefined1303FeeToBeFinancedIndicator = _userDefined1303FeeToBeFinancedIndicator; userDefined1303FeeToBeFinancedIndicator.Clean = value; _userDefined1303FeeToBeFinancedIndicator = userDefined1303FeeToBeFinancedIndicator;
                var userDefined1303PortionOfFeeIndicator = _userDefined1303PortionOfFeeIndicator; userDefined1303PortionOfFeeIndicator.Clean = value; _userDefined1303PortionOfFeeIndicator = userDefined1303PortionOfFeeIndicator;
                var userDefined1304FeeToBeFinancedIndicator = _userDefined1304FeeToBeFinancedIndicator; userDefined1304FeeToBeFinancedIndicator.Clean = value; _userDefined1304FeeToBeFinancedIndicator = userDefined1304FeeToBeFinancedIndicator;
                var userDefined1304PortionOfFeeIndicator = _userDefined1304PortionOfFeeIndicator; userDefined1304PortionOfFeeIndicator.Clean = value; _userDefined1304PortionOfFeeIndicator = userDefined1304PortionOfFeeIndicator;
                var userDefined1305FeeToBeFinancedIndicator = _userDefined1305FeeToBeFinancedIndicator; userDefined1305FeeToBeFinancedIndicator.Clean = value; _userDefined1305FeeToBeFinancedIndicator = userDefined1305FeeToBeFinancedIndicator;
                var userDefined1305PortionOfFeeIndicator = _userDefined1305PortionOfFeeIndicator; userDefined1305PortionOfFeeIndicator.Clean = value; _userDefined1305PortionOfFeeIndicator = userDefined1305PortionOfFeeIndicator;
                var userDefined1306FeeToBeFinancedIndicator = _userDefined1306FeeToBeFinancedIndicator; userDefined1306FeeToBeFinancedIndicator.Clean = value; _userDefined1306FeeToBeFinancedIndicator = userDefined1306FeeToBeFinancedIndicator;
                var userDefined1306PortionOfFeeIndicator = _userDefined1306PortionOfFeeIndicator; userDefined1306PortionOfFeeIndicator.Clean = value; _userDefined1306PortionOfFeeIndicator = userDefined1306PortionOfFeeIndicator;
                var userDefined1307FeeToBeFinancedIndicator = _userDefined1307FeeToBeFinancedIndicator; userDefined1307FeeToBeFinancedIndicator.Clean = value; _userDefined1307FeeToBeFinancedIndicator = userDefined1307FeeToBeFinancedIndicator;
                var userDefined1307PortionOfFeeIndicator = _userDefined1307PortionOfFeeIndicator; userDefined1307PortionOfFeeIndicator.Clean = value; _userDefined1307PortionOfFeeIndicator = userDefined1307PortionOfFeeIndicator;
                var userDefined1308FeeToBeFinancedIndicator = _userDefined1308FeeToBeFinancedIndicator; userDefined1308FeeToBeFinancedIndicator.Clean = value; _userDefined1308FeeToBeFinancedIndicator = userDefined1308FeeToBeFinancedIndicator;
                var userDefined1308PortionOfFeeIndicator = _userDefined1308PortionOfFeeIndicator; userDefined1308PortionOfFeeIndicator.Clean = value; _userDefined1308PortionOfFeeIndicator = userDefined1308PortionOfFeeIndicator;
                var userDefined1309FeeToBeFinancedIndicator = _userDefined1309FeeToBeFinancedIndicator; userDefined1309FeeToBeFinancedIndicator.Clean = value; _userDefined1309FeeToBeFinancedIndicator = userDefined1309FeeToBeFinancedIndicator;
                var userDefined1309PortionOfFeeIndicator = _userDefined1309PortionOfFeeIndicator; userDefined1309PortionOfFeeIndicator.Clean = value; _userDefined1309PortionOfFeeIndicator = userDefined1309PortionOfFeeIndicator;
                var userDefined813FeeToBeFinancedIndicator = _userDefined813FeeToBeFinancedIndicator; userDefined813FeeToBeFinancedIndicator.Clean = value; _userDefined813FeeToBeFinancedIndicator = userDefined813FeeToBeFinancedIndicator;
                var userDefined813PortionOfFeeIndicator = _userDefined813PortionOfFeeIndicator; userDefined813PortionOfFeeIndicator.Clean = value; _userDefined813PortionOfFeeIndicator = userDefined813PortionOfFeeIndicator;
                var userDefined814FeeToBeFinancedIndicator = _userDefined814FeeToBeFinancedIndicator; userDefined814FeeToBeFinancedIndicator.Clean = value; _userDefined814FeeToBeFinancedIndicator = userDefined814FeeToBeFinancedIndicator;
                var userDefined814PortionOfFeeIndicator = _userDefined814PortionOfFeeIndicator; userDefined814PortionOfFeeIndicator.Clean = value; _userDefined814PortionOfFeeIndicator = userDefined814PortionOfFeeIndicator;
                var userDefined815FeeToBeFinancedIndicator = _userDefined815FeeToBeFinancedIndicator; userDefined815FeeToBeFinancedIndicator.Clean = value; _userDefined815FeeToBeFinancedIndicator = userDefined815FeeToBeFinancedIndicator;
                var userDefined815PortionOfFeeIndicator = _userDefined815PortionOfFeeIndicator; userDefined815PortionOfFeeIndicator.Clean = value; _userDefined815PortionOfFeeIndicator = userDefined815PortionOfFeeIndicator;
                var userDefined816FeeToBeFinancedIndicator = _userDefined816FeeToBeFinancedIndicator; userDefined816FeeToBeFinancedIndicator.Clean = value; _userDefined816FeeToBeFinancedIndicator = userDefined816FeeToBeFinancedIndicator;
                var userDefined816PortionOfFeeIndicator = _userDefined816PortionOfFeeIndicator; userDefined816PortionOfFeeIndicator.Clean = value; _userDefined816PortionOfFeeIndicator = userDefined816PortionOfFeeIndicator;
                var userDefined817FeeToBeFinancedIndicator = _userDefined817FeeToBeFinancedIndicator; userDefined817FeeToBeFinancedIndicator.Clean = value; _userDefined817FeeToBeFinancedIndicator = userDefined817FeeToBeFinancedIndicator;
                var userDefined817PortionOfFeeIndicator = _userDefined817PortionOfFeeIndicator; userDefined817PortionOfFeeIndicator.Clean = value; _userDefined817PortionOfFeeIndicator = userDefined817PortionOfFeeIndicator;
                var userDefined818FeeToBeFinancedIndicator = _userDefined818FeeToBeFinancedIndicator; userDefined818FeeToBeFinancedIndicator.Clean = value; _userDefined818FeeToBeFinancedIndicator = userDefined818FeeToBeFinancedIndicator;
                var userDefined818PortionOfFeeIndicator = _userDefined818PortionOfFeeIndicator; userDefined818PortionOfFeeIndicator.Clean = value; _userDefined818PortionOfFeeIndicator = userDefined818PortionOfFeeIndicator;
                var userDefined819FeeToBeFinancedIndicator = _userDefined819FeeToBeFinancedIndicator; userDefined819FeeToBeFinancedIndicator.Clean = value; _userDefined819FeeToBeFinancedIndicator = userDefined819FeeToBeFinancedIndicator;
                var userDefined819PortionOfFeeIndicator = _userDefined819PortionOfFeeIndicator; userDefined819PortionOfFeeIndicator.Clean = value; _userDefined819PortionOfFeeIndicator = userDefined819PortionOfFeeIndicator;
                var userDefined820FeeToBeFinancedIndicator = _userDefined820FeeToBeFinancedIndicator; userDefined820FeeToBeFinancedIndicator.Clean = value; _userDefined820FeeToBeFinancedIndicator = userDefined820FeeToBeFinancedIndicator;
                var userDefined820PortionOfFeeIndicator = _userDefined820PortionOfFeeIndicator; userDefined820PortionOfFeeIndicator.Clean = value; _userDefined820PortionOfFeeIndicator = userDefined820PortionOfFeeIndicator;
                var userDefined821FeeToBeFinancedIndicator = _userDefined821FeeToBeFinancedIndicator; userDefined821FeeToBeFinancedIndicator.Clean = value; _userDefined821FeeToBeFinancedIndicator = userDefined821FeeToBeFinancedIndicator;
                var userDefined821PortionOfFeeIndicator = _userDefined821PortionOfFeeIndicator; userDefined821PortionOfFeeIndicator.Clean = value; _userDefined821PortionOfFeeIndicator = userDefined821PortionOfFeeIndicator;
                var userDefined822FeeToBeFinancedIndicator = _userDefined822FeeToBeFinancedIndicator; userDefined822FeeToBeFinancedIndicator.Clean = value; _userDefined822FeeToBeFinancedIndicator = userDefined822FeeToBeFinancedIndicator;
                var userDefined822PortionOfFeeIndicator = _userDefined822PortionOfFeeIndicator; userDefined822PortionOfFeeIndicator.Clean = value; _userDefined822PortionOfFeeIndicator = userDefined822PortionOfFeeIndicator;
                var userDefined823FeeToBeFinancedIndicator = _userDefined823FeeToBeFinancedIndicator; userDefined823FeeToBeFinancedIndicator.Clean = value; _userDefined823FeeToBeFinancedIndicator = userDefined823FeeToBeFinancedIndicator;
                var userDefined823PortionOfFeeIndicator = _userDefined823PortionOfFeeIndicator; userDefined823PortionOfFeeIndicator.Clean = value; _userDefined823PortionOfFeeIndicator = userDefined823PortionOfFeeIndicator;
                var wireTransferFeeToBeFinancedIndicator = _wireTransferFeeToBeFinancedIndicator; wireTransferFeeToBeFinancedIndicator.Clean = value; _wireTransferFeeToBeFinancedIndicator = wireTransferFeeToBeFinancedIndicator;
                var wireTransferPortionOfFeeIndicator = _wireTransferPortionOfFeeIndicator; wireTransferPortionOfFeeIndicator.Clean = value; _wireTransferPortionOfFeeIndicator = wireTransferPortionOfFeeIndicator;
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