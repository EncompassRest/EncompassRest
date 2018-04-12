#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class AUSTrackingLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _aUSTrackingLogIndex;
        public int? AUSTrackingLogIndex { get => _aUSTrackingLogIndex; set => _aUSTrackingLogIndex = value; }
        private DirtyValue<string> _batchDocumentRefId;
        public string BatchDocumentRefId { get => _batchDocumentRefId; set => _batchDocumentRefId = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<bool?> _isHistory;
        public bool? IsHistory { get => _isHistory; set => _isHistory = value; }
        private DirtyValue<string> _logAcceptPlusEligible;
        public string LogAcceptPlusEligible { get => _logAcceptPlusEligible; set => _logAcceptPlusEligible = value; }
        private DirtyValue<string> _logAffordableProductType;
        public string LogAffordableProductType { get => _logAffordableProductType; set => _logAffordableProductType = value; }
        private DirtyValue<decimal?> _logAllOtherPayments;
        public decimal? LogAllOtherPayments { get => _logAllOtherPayments; set => _logAllOtherPayments = value; }
        private DirtyValue<int?> _logAmortizationMonths;
        public int? LogAmortizationMonths { get => _logAmortizationMonths; set => _logAmortizationMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _logAmortizationType;
        public StringEnumValue<AmortizationType> LogAmortizationType { get => _logAmortizationType; set => _logAmortizationType = value; }
        private DirtyValue<decimal?> _logAmtSubordinateFin;
        public decimal? LogAmtSubordinateFin { get => _logAmtSubordinateFin; set => _logAmtSubordinateFin = value; }
        private DirtyValue<string> _logAppraisalTypeMAF;
        public string LogAppraisalTypeMAF { get => _logAppraisalTypeMAF; set => _logAppraisalTypeMAF = value; }
        private DirtyValue<int?> _logAppraisedValue;
        public int? LogAppraisedValue { get => _logAppraisedValue; set => _logAppraisedValue = value; }
        private DirtyValue<decimal?> _logARMQualifyingRate;
        public decimal? LogARMQualifyingRate { get => _logARMQualifyingRate; set => _logARMQualifyingRate = value; }
        private DirtyValue<string> _logAssessmentType;
        public string LogAssessmentType { get => _logAssessmentType; set => _logAssessmentType = value; }
        private DirtyValue<string> _logAUSRecommendation;
        public string LogAUSRecommendation { get => _logAUSRecommendation; set => _logAUSRecommendation = value; }
        private DirtyValue<string> _logAUSStatus;
        public string LogAUSStatus { get => _logAUSStatus; set => _logAUSStatus = value; }
        private DirtyValue<StringEnumValue<LogAUSTrackingType>> _logAUSTrackingType;
        public StringEnumValue<LogAUSTrackingType> LogAUSTrackingType { get => _logAUSTrackingType; set => _logAUSTrackingType = value; }
        private DirtyValue<string> _logAUSTransactionID;
        public string LogAUSTransactionID { get => _logAUSTransactionID; set => _logAUSTransactionID = value; }
        private DirtyValue<string> _logAUSVersion;
        public string LogAUSVersion { get => _logAUSVersion; set => _logAUSVersion = value; }
        private DirtyValue<string> _logBalloon;
        public string LogBalloon { get => _logBalloon; set => _logBalloon = value; }
        private DirtyValue<int?> _logBalloonTerm;
        public int? LogBalloonTerm { get => _logBalloonTerm; set => _logBalloonTerm = value; }
        private DirtyValue<decimal?> _logBorrowerAssetAmount;
        public decimal? LogBorrowerAssetAmount { get => _logBorrowerAssetAmount; set => _logBorrowerAssetAmount = value; }
        private DirtyValue<string> _logBorrowerAssetName;
        public string LogBorrowerAssetName { get => _logBorrowerAssetName; set => _logBorrowerAssetName = value; }
        private DirtyValue<string> _logBorrowerAssetType;
        public string LogBorrowerAssetType { get => _logBorrowerAssetType; set => _logBorrowerAssetType = value; }
        private DirtyValue<string> _logBorrowerCreditScore1;
        public string LogBorrowerCreditScore1 { get => _logBorrowerCreditScore1; set => _logBorrowerCreditScore1 = value; }
        private DirtyValue<string> _logBorrowerCreditScore2;
        public string LogBorrowerCreditScore2 { get => _logBorrowerCreditScore2; set => _logBorrowerCreditScore2 = value; }
        private DirtyValue<string> _logBorrowerCreditScore3;
        public string LogBorrowerCreditScore3 { get => _logBorrowerCreditScore3; set => _logBorrowerCreditScore3 = value; }
        private DirtyValue<string> _logBorrowerEquifaxBEACON;
        public string LogBorrowerEquifaxBEACON { get => _logBorrowerEquifaxBEACON; set => _logBorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _logBorrowerExperianFICO;
        public string LogBorrowerExperianFICO { get => _logBorrowerExperianFICO; set => _logBorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _logBorrowerIncomeAmount;
        public decimal? LogBorrowerIncomeAmount { get => _logBorrowerIncomeAmount; set => _logBorrowerIncomeAmount = value; }
        private DirtyValue<string> _logBorrowerIncomeName;
        public string LogBorrowerIncomeName { get => _logBorrowerIncomeName; set => _logBorrowerIncomeName = value; }
        private DirtyValue<string> _logBorrowerIncomeType;
        public string LogBorrowerIncomeType { get => _logBorrowerIncomeType; set => _logBorrowerIncomeType = value; }
        private DirtyValue<string> _logBorrowerInstitutionName;
        public string LogBorrowerInstitutionName { get => _logBorrowerInstitutionName; set => _logBorrowerInstitutionName = value; }
        private DirtyValue<string> _logBorrowerName;
        public string LogBorrowerName { get => _logBorrowerName; set => _logBorrowerName = value; }
        private DirtyValue<string> _logBorrowerScoreName;
        public string LogBorrowerScoreName { get => _logBorrowerScoreName; set => _logBorrowerScoreName = value; }
        private DirtyValue<string> _logBorrowerTransUnionEmpirica;
        public string LogBorrowerTransUnionEmpirica { get => _logBorrowerTransUnionEmpirica; set => _logBorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _logBorrowerType1;
        public string LogBorrowerType1 { get => _logBorrowerType1; set => _logBorrowerType1 = value; }
        private DirtyValue<string> _logBorrowerType2;
        public string LogBorrowerType2 { get => _logBorrowerType2; set => _logBorrowerType2 = value; }
        private DirtyValue<decimal?> _logBoughtDownRate;
        public decimal? LogBoughtDownRate { get => _logBoughtDownRate; set => _logBoughtDownRate = value; }
        private DirtyValue<string> _logBuydown;
        public string LogBuydown { get => _logBuydown; set => _logBuydown = value; }
        private DirtyValue<decimal?> _logCashBack;
        public decimal? LogCashBack { get => _logCashBack; set => _logCashBack = value; }
        private DirtyValue<decimal?> _logCashOutAmount;
        public decimal? LogCashOutAmount { get => _logCashOutAmount; set => _logCashOutAmount = value; }
        private DirtyValue<decimal?> _logCLTV;
        public decimal? LogCLTV { get => _logCLTV; set => _logCLTV = value; }
        private DirtyValue<decimal?> _logCoBorrowerAssetAmount;
        public decimal? LogCoBorrowerAssetAmount { get => _logCoBorrowerAssetAmount; set => _logCoBorrowerAssetAmount = value; }
        private DirtyValue<string> _logCoBorrowerAssetName;
        public string LogCoBorrowerAssetName { get => _logCoBorrowerAssetName; set => _logCoBorrowerAssetName = value; }
        private DirtyValue<string> _logCoBorrowerAssetType;
        public string LogCoBorrowerAssetType { get => _logCoBorrowerAssetType; set => _logCoBorrowerAssetType = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore1;
        public string LogCoBorrowerCreditScore1 { get => _logCoBorrowerCreditScore1; set => _logCoBorrowerCreditScore1 = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore2;
        public string LogCoBorrowerCreditScore2 { get => _logCoBorrowerCreditScore2; set => _logCoBorrowerCreditScore2 = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore3;
        public string LogCoBorrowerCreditScore3 { get => _logCoBorrowerCreditScore3; set => _logCoBorrowerCreditScore3 = value; }
        private DirtyValue<string> _logCoBorrowerEquifaxBEACON;
        public string LogCoBorrowerEquifaxBEACON { get => _logCoBorrowerEquifaxBEACON; set => _logCoBorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _logCoBorrowerExperianFICO;
        public string LogCoBorrowerExperianFICO { get => _logCoBorrowerExperianFICO; set => _logCoBorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _logCoBorrowerIncomeAmount;
        public decimal? LogCoBorrowerIncomeAmount { get => _logCoBorrowerIncomeAmount; set => _logCoBorrowerIncomeAmount = value; }
        private DirtyValue<string> _logCoBorrowerIncomeName;
        public string LogCoBorrowerIncomeName { get => _logCoBorrowerIncomeName; set => _logCoBorrowerIncomeName = value; }
        private DirtyValue<string> _logCoBorrowerIncomeType;
        public string LogCoBorrowerIncomeType { get => _logCoBorrowerIncomeType; set => _logCoBorrowerIncomeType = value; }
        private DirtyValue<string> _logCoBorrowerInstitutionName;
        public string LogCoBorrowerInstitutionName { get => _logCoBorrowerInstitutionName; set => _logCoBorrowerInstitutionName = value; }
        private DirtyValue<string> _logCoborrowerName;
        public string LogCoborrowerName { get => _logCoborrowerName; set => _logCoborrowerName = value; }
        private DirtyValue<string> _logCoBorrowerScoreName;
        public string LogCoBorrowerScoreName { get => _logCoBorrowerScoreName; set => _logCoBorrowerScoreName = value; }
        private DirtyValue<string> _logCoBorrowerTransUnionEmpirica;
        public string LogCoBorrowerTransUnionEmpirica { get => _logCoBorrowerTransUnionEmpirica; set => _logCoBorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _logCode1;
        public string LogCode1 { get => _logCode1; set => _logCode1 = value; }
        private DirtyValue<string> _logCode2;
        public string LogCode2 { get => _logCode2; set => _logCode2 = value; }
        private DirtyValue<string> _logCodeDescription1;
        public string LogCodeDescription1 { get => _logCodeDescription1; set => _logCodeDescription1 = value; }
        private DirtyValue<string> _logCodeDescription2;
        public string LogCodeDescription2 { get => _logCodeDescription2; set => _logCodeDescription2 = value; }
        private DirtyValue<string> _logCommunityLending;
        public string LogCommunityLending { get => _logCommunityLending; set => _logCommunityLending = value; }
        private DirtyValue<DateTime?> _logCreatedOn;
        public DateTime? LogCreatedOn { get => _logCreatedOn; set => _logCreatedOn = value; }
        private DirtyValue<string> _logCreditAgency1;
        public string LogCreditAgency1 { get => _logCreditAgency1; set => _logCreditAgency1 = value; }
        private DirtyValue<string> _logCreditAgency2;
        public string LogCreditAgency2 { get => _logCreditAgency2; set => _logCreditAgency2 = value; }
        private DirtyValue<DateTime?> _logCreditReportDate1;
        public DateTime? LogCreditReportDate1 { get => _logCreditReportDate1; set => _logCreditReportDate1 = value; }
        private DirtyValue<DateTime?> _logCreditReportDate2;
        public DateTime? LogCreditReportDate2 { get => _logCreditReportDate2; set => _logCreditReportDate2 = value; }
        private DirtyValue<string> _logCreditReportID1;
        public string LogCreditReportID1 { get => _logCreditReportID1; set => _logCreditReportID1 = value; }
        private DirtyValue<string> _logCreditReportID2;
        public string LogCreditReportID2 { get => _logCreditReportID2; set => _logCreditReportID2 = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _logCuredAmortizationType;
        public StringEnumValue<AmortizationType> LogCuredAmortizationType { get => _logCuredAmortizationType; set => _logCuredAmortizationType = value; }
        private DirtyValue<int?> _logCuredAppraisedValue;
        public int? LogCuredAppraisedValue { get => _logCuredAppraisedValue; set => _logCuredAppraisedValue = value; }
        private DirtyValue<decimal?> _logCuredCLTV;
        public decimal? LogCuredCLTV { get => _logCuredCLTV; set => _logCuredCLTV = value; }
        private DirtyValue<decimal?> _logCuredHousingExpenseRatio;
        public decimal? LogCuredHousingExpenseRatio { get => _logCuredHousingExpenseRatio; set => _logCuredHousingExpenseRatio = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logCuredLoanPurpose;
        public StringEnumValue<LoanPurposeType> LogCuredLoanPurpose { get => _logCuredLoanPurpose; set => _logCuredLoanPurpose = value; }
        private DirtyValue<int?> _logCuredLoanTerm;
        public int? LogCuredLoanTerm { get => _logCuredLoanTerm; set => _logCuredLoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _logCuredLoanType;
        public StringEnumValue<LoanType> LogCuredLoanType { get => _logCuredLoanType; set => _logCuredLoanType = value; }
        private DirtyValue<decimal?> _logCuredLTV;
        public decimal? LogCuredLTV { get => _logCuredLTV; set => _logCuredLTV = value; }
        private DirtyValue<decimal?> _logCuredNoteRate;
        public decimal? LogCuredNoteRate { get => _logCuredNoteRate; set => _logCuredNoteRate = value; }
        private DirtyValue<decimal?> _logCuredProposedTotalHousingPayment;
        public decimal? LogCuredProposedTotalHousingPayment { get => _logCuredProposedTotalHousingPayment; set => _logCuredProposedTotalHousingPayment = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logCuredRefinancePurpose;
        public StringEnumValue<RefinancePurpose> LogCuredRefinancePurpose { get => _logCuredRefinancePurpose; set => _logCuredRefinancePurpose = value; }
        private DirtyValue<decimal?> _logCuredTotalExpenseRatio;
        public decimal? LogCuredTotalExpenseRatio { get => _logCuredTotalExpenseRatio; set => _logCuredTotalExpenseRatio = value; }
        private DirtyValue<decimal?> _logCuredTotalLoanAmount;
        public decimal? LogCuredTotalLoanAmount { get => _logCuredTotalLoanAmount; set => _logCuredTotalLoanAmount = value; }
        private DirtyValue<decimal?> _logCuredTotalMonthlyIncome;
        public decimal? LogCuredTotalMonthlyIncome { get => _logCuredTotalMonthlyIncome; set => _logCuredTotalMonthlyIncome = value; }
        private DirtyValue<string> _logDateTimeAssessed;
        public string LogDateTimeAssessed { get => _logDateTimeAssessed; set => _logDateTimeAssessed = value; }
        private DirtyValue<string> _logDateTimeRequested;
        public string LogDateTimeRequested { get => _logDateTimeRequested; set => _logDateTimeRequested = value; }
        private DirtyValue<decimal?> _logDebtRatio;
        public decimal? LogDebtRatio { get => _logDebtRatio; set => _logDebtRatio = value; }
        private DirtyValue<string> _logDocumentationLevel;
        public string LogDocumentationLevel { get => _logDocumentationLevel; set => _logDocumentationLevel = value; }
        private DirtyValue<string> _logDUCaseIDorLPAUSKey;
        public string LogDUCaseIDorLPAUSKey { get => _logDUCaseIDorLPAUSKey; set => _logDUCaseIDorLPAUSKey = value; }
        private DirtyValue<StringEnumValue<PropertyType>> _logDUPropertyType;
        public StringEnumValue<PropertyType> LogDUPropertyType { get => _logDUPropertyType; set => _logDUPropertyType = value; }
        private DirtyValue<string> _logeFolderGUID;
        public string LogeFolderGUID { get => _logeFolderGUID; set => _logeFolderGUID = value; }
        private DirtyValue<decimal?> _logExcessAvailableAssetsNoVerified;
        public decimal? LogExcessAvailableAssetsNoVerified { get => _logExcessAvailableAssetsNoVerified; set => _logExcessAvailableAssetsNoVerified = value; }
        private DirtyValue<decimal?> _logFinancedMIAmount;
        public decimal? LogFinancedMIAmount { get => _logFinancedMIAmount; set => _logFinancedMIAmount = value; }
        private DirtyValue<decimal?> _logFirstPandI;
        public decimal? LogFirstPandI { get => _logFirstPandI; set => _logFirstPandI = value; }
        private DirtyValue<DateTime?> _logFirstSubmissionDate;
        public DateTime? LogFirstSubmissionDate { get => _logFirstSubmissionDate; set => _logFirstSubmissionDate = value; }
        private DirtyValue<string> _logFirstSubmissionTime;
        public string LogFirstSubmissionTime { get => _logFirstSubmissionTime; set => _logFirstSubmissionTime = value; }
        private DirtyValue<string> _logFreddieDocClass;
        public string LogFreddieDocClass { get => _logFreddieDocClass; set => _logFreddieDocClass = value; }
        private DirtyValue<decimal?> _logFundsRequiredClose;
        public decimal? LogFundsRequiredClose { get => _logFundsRequiredClose; set => _logFundsRequiredClose = value; }
        private DirtyValue<string> _logGUID;
        public string LogGUID { get => _logGUID; set => _logGUID = value; }
        private DirtyValue<decimal?> _logHLCTV;
        public decimal? LogHLCTV { get => _logHLCTV; set => _logHLCTV = value; }
        private DirtyValue<decimal?> _logHousingExpense;
        public decimal? LogHousingExpense { get => _logHousingExpense; set => _logHousingExpense = value; }
        private DirtyValue<decimal?> _logHousingExpenseRatio;
        public decimal? LogHousingExpenseRatio { get => _logHousingExpenseRatio; set => _logHousingExpenseRatio = value; }
        private DirtyValue<decimal?> _logHousingRatio;
        public decimal? LogHousingRatio { get => _logHousingRatio; set => _logHousingRatio = value; }
        private DirtyValue<decimal?> _logHTLTV;
        public decimal? LogHTLTV { get => _logHTLTV; set => _logHTLTV = value; }
        private DirtyValue<string> _logIncludingLess10Mos;
        public string LogIncludingLess10Mos { get => _logIncludingLess10Mos; set => _logIncludingLess10Mos = value; }
        private DirtyValue<decimal?> _logIncomeAssetBase;
        public decimal? LogIncomeAssetBase { get => _logIncomeAssetBase; set => _logIncomeAssetBase = value; }
        private DirtyValue<decimal?> _logIncomeAssetBonus;
        public decimal? LogIncomeAssetBonus { get => _logIncomeAssetBonus; set => _logIncomeAssetBonus = value; }
        private DirtyValue<decimal?> _logIncomeAssetCommission;
        public decimal? LogIncomeAssetCommission { get => _logIncomeAssetCommission; set => _logIncomeAssetCommission = value; }
        private DirtyValue<decimal?> _logIncomeAssetOther;
        public decimal? LogIncomeAssetOther { get => _logIncomeAssetOther; set => _logIncomeAssetOther = value; }
        private DirtyValue<decimal?> _logIncomeAssetOvertime;
        public decimal? LogIncomeAssetOvertime { get => _logIncomeAssetOvertime; set => _logIncomeAssetOvertime = value; }
        private DirtyValue<decimal?> _logIncomeAssetPosCashFlow;
        public decimal? LogIncomeAssetPosCashFlow { get => _logIncomeAssetPosCashFlow; set => _logIncomeAssetPosCashFlow = value; }
        private DirtyValue<decimal?> _logIncomeAssetPositiveNetRental;
        public decimal? LogIncomeAssetPositiveNetRental { get => _logIncomeAssetPositiveNetRental; set => _logIncomeAssetPositiveNetRental = value; }
        private DirtyValue<string> _logIndicatorScore;
        public string LogIndicatorScore { get => _logIndicatorScore; set => _logIndicatorScore = value; }
        private DirtyValue<string> _logIntendedUseofProperty;
        public string LogIntendedUseofProperty { get => _logIntendedUseofProperty; set => _logIntendedUseofProperty = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion1;
        public string LogLCLAEvaluatedServiceConclusion1 { get => _logLCLAEvaluatedServiceConclusion1; set => _logLCLAEvaluatedServiceConclusion1 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion2;
        public string LogLCLAEvaluatedServiceConclusion2 { get => _logLCLAEvaluatedServiceConclusion2; set => _logLCLAEvaluatedServiceConclusion2 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion3;
        public string LogLCLAEvaluatedServiceConclusion3 { get => _logLCLAEvaluatedServiceConclusion3; set => _logLCLAEvaluatedServiceConclusion3 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion4;
        public string LogLCLAEvaluatedServiceConclusion4 { get => _logLCLAEvaluatedServiceConclusion4; set => _logLCLAEvaluatedServiceConclusion4 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType1>> _logLCLAEvaluatedServiceType1;
        public StringEnumValue<LogLCLAEvaluatedServiceType1> LogLCLAEvaluatedServiceType1 { get => _logLCLAEvaluatedServiceType1; set => _logLCLAEvaluatedServiceType1 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType2>> _logLCLAEvaluatedServiceType2;
        public StringEnumValue<LogLCLAEvaluatedServiceType2> LogLCLAEvaluatedServiceType2 { get => _logLCLAEvaluatedServiceType2; set => _logLCLAEvaluatedServiceType2 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType3>> _logLCLAEvaluatedServiceType3;
        public StringEnumValue<LogLCLAEvaluatedServiceType3> LogLCLAEvaluatedServiceType3 { get => _logLCLAEvaluatedServiceType3; set => _logLCLAEvaluatedServiceType3 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceType4;
        public string LogLCLAEvaluatedServiceType4 { get => _logLCLAEvaluatedServiceType4; set => _logLCLAEvaluatedServiceType4 = value; }
        private DirtyValue<string> _logLenderLoan;
        public string LogLenderLoan { get => _logLenderLoan; set => _logLenderLoan = value; }
        private DirtyValue<StringEnumValue<LienType>> _logLienType;
        public StringEnumValue<LienType> LogLienType { get => _logLienType; set => _logLienType = value; }
        private DirtyValue<decimal?> _logLoanAmount;
        public decimal? LogLoanAmount { get => _logLoanAmount; set => _logLoanAmount = value; }
        private DirtyValue<string> _logLoanApplicationID;
        public string LogLoanApplicationID { get => _logLoanApplicationID; set => _logLoanApplicationID = value; }
        private DirtyValue<string> _logLoanProcessingStage;
        public string LogLoanProcessingStage { get => _logLoanProcessingStage; set => _logLoanProcessingStage = value; }
        private DirtyValue<string> _logLoanProspectorID;
        public string LogLoanProspectorID { get => _logLoanProspectorID; set => _logLoanProspectorID = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logLoanPurpose;
        public StringEnumValue<LoanPurposeType> LogLoanPurpose { get => _logLoanPurpose; set => _logLoanPurpose = value; }
        private DirtyValue<int?> _logLoanTerm;
        public int? LogLoanTerm { get => _logLoanTerm; set => _logLoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _logLoanType;
        public StringEnumValue<LoanType> LogLoanType { get => _logLoanType; set => _logLoanType = value; }
        private DirtyValue<DateTime?> _logLPAssmtExpDate;
        public DateTime? LogLPAssmtExpDate { get => _logLPAssmtExpDate; set => _logLPAssmtExpDate = value; }
        private DirtyValue<StringEnumValue<OtherPropertyType>> _logLPPropertyType;
        public StringEnumValue<OtherPropertyType> LogLPPropertyType { get => _logLPPropertyType; set => _logLPPropertyType = value; }
        private DirtyValue<string> _logLPVersion;
        public string LogLPVersion { get => _logLPVersion; set => _logLPVersion = value; }
        private DirtyValue<string> _logLQACollateralRepWarrantyServiceConclusion;
        public string LogLQACollateralRepWarrantyServiceConclusion { get => _logLQACollateralRepWarrantyServiceConclusion; set => _logLQACollateralRepWarrantyServiceConclusion = value; }
        private DirtyValue<string> _logLQACreditRiskAssessmentConclusion;
        public string LogLQACreditRiskAssessmentConclusion { get => _logLQACreditRiskAssessmentConclusion; set => _logLQACreditRiskAssessmentConclusion = value; }
        private DirtyValue<string> _logLQADataCompareFieldConclusion;
        public string LogLQADataCompareFieldConclusion { get => _logLQADataCompareFieldConclusion; set => _logLQADataCompareFieldConclusion = value; }
        private DirtyValue<string> _logLQADataCompareFieldName;
        public string LogLQADataCompareFieldName { get => _logLQADataCompareFieldName; set => _logLQADataCompareFieldName = value; }
        private DirtyValue<string> _logLQADataCompareResult;
        public string LogLQADataCompareResult { get => _logLQADataCompareResult; set => _logLQADataCompareResult = value; }
        private DirtyValue<string> _logLQALPKey;
        public string LogLQALPKey { get => _logLQALPKey; set => _logLQALPKey = value; }
        private DirtyValue<string> _logLQAPurchaseEligibilityResult;
        public string LogLQAPurchaseEligibilityResult { get => _logLQAPurchaseEligibilityResult; set => _logLQAPurchaseEligibilityResult = value; }
        private DirtyValue<string> _logLQARiskAssessmentKey;
        public string LogLQARiskAssessmentKey { get => _logLQARiskAssessmentKey; set => _logLQARiskAssessmentKey = value; }
        private DirtyValue<DateTime?> _logLQASubmissionDateTime;
        public DateTime? LogLQASubmissionDateTime { get => _logLQASubmissionDateTime; set => _logLQASubmissionDateTime = value; }
        private DirtyValue<decimal?> _logLTV;
        public decimal? LogLTV { get => _logLTV; set => _logLTV = value; }
        private DirtyValue<decimal?> _logMaxMortgageLimit;
        public decimal? LogMaxMortgageLimit { get => _logMaxMortgageLimit; set => _logMaxMortgageLimit = value; }
        private DirtyValue<string> _logMIDecision;
        public string LogMIDecision { get => _logMIDecision; set => _logMIDecision = value; }
        private DirtyValue<string> _logMortgageType;
        public string LogMortgageType { get => _logMortgageType; set => _logMortgageType = value; }
        private DirtyValue<string> _logNegAmortizationType;
        public string LogNegAmortizationType { get => _logNegAmortizationType; set => _logNegAmortizationType = value; }
        private DirtyValue<decimal?> _logNegativeNetRental;
        public decimal? LogNegativeNetRental { get => _logNegativeNetRental; set => _logNegativeNetRental = value; }
        private DirtyValue<decimal?> _logNetCashBack;
        public decimal? LogNetCashBack { get => _logNetCashBack; set => _logNetCashBack = value; }
        private DirtyValue<string> _logNewConstruction;
        public string LogNewConstruction { get => _logNewConstruction; set => _logNewConstruction = value; }
        private DirtyValue<decimal?> _logNoteRate;
        public decimal? LogNoteRate { get => _logNoteRate; set => _logNoteRate = value; }
        private DirtyValue<string> _logNOTPNumber;
        public string LogNOTPNumber { get => _logNOTPNumber; set => _logNOTPNumber = value; }
        private DirtyValue<int?> _logNoUnits;
        public int? LogNoUnits { get => _logNoUnits; set => _logNoUnits = value; }
        private DirtyValue<string> _logNumberOfSubmissions;
        public string LogNumberOfSubmissions { get => _logNumberOfSubmissions; set => _logNumberOfSubmissions = value; }
        private DirtyValue<string> _logOccupancyStatus;
        public string LogOccupancyStatus { get => _logOccupancyStatus; set => _logOccupancyStatus = value; }
        private DirtyValue<decimal?> _logOccupantDebtRatio;
        public decimal? LogOccupantDebtRatio { get => _logOccupantDebtRatio; set => _logOccupantDebtRatio = value; }
        private DirtyValue<decimal?> _logOccupantHousingRatio;
        public decimal? LogOccupantHousingRatio { get => _logOccupantHousingRatio; set => _logOccupantHousingRatio = value; }
        private DirtyValue<string> _logOfferingIdentifier;
        public string LogOfferingIdentifier { get => _logOfferingIdentifier; set => _logOfferingIdentifier = value; }
        private DirtyValue<string> _logOriginatingCompany;
        public string LogOriginatingCompany { get => _logOriginatingCompany; set => _logOriginatingCompany = value; }
        private DirtyValue<decimal?> _logOwnerExistingMtg;
        public decimal? LogOwnerExistingMtg { get => _logOwnerExistingMtg; set => _logOwnerExistingMtg = value; }
        private DirtyValue<decimal?> _logPandI;
        public decimal? LogPandI { get => _logPandI; set => _logPandI = value; }
        private DirtyValue<int?> _logPaymentFrequency;
        public int? LogPaymentFrequency { get => _logPaymentFrequency; set => _logPaymentFrequency = value; }
        private DirtyValue<string> _logPresentAddress;
        public string LogPresentAddress { get => _logPresentAddress; set => _logPresentAddress = value; }
        private DirtyValue<string> _logPresentAddressCity;
        public string LogPresentAddressCity { get => _logPresentAddressCity; set => _logPresentAddressCity = value; }
        private DirtyValue<string> _logPresentAddressState;
        public string LogPresentAddressState { get => _logPresentAddressState; set => _logPresentAddressState = value; }
        private DirtyValue<string> _logPresentAddressZipCode;
        public string LogPresentAddressZipCode { get => _logPresentAddressZipCode; set => _logPresentAddressZipCode = value; }
        private DirtyValue<decimal?> _logPresentHousingExpense;
        public decimal? LogPresentHousingExpense { get => _logPresentHousingExpense; set => _logPresentHousingExpense = value; }
        private DirtyValue<decimal?> _logPresentPrincipalHousingPayment;
        public decimal? LogPresentPrincipalHousingPayment { get => _logPresentPrincipalHousingPayment; set => _logPresentPrincipalHousingPayment = value; }
        private DirtyValue<string> _logPropertyAddress;
        public string LogPropertyAddress { get => _logPropertyAddress; set => _logPropertyAddress = value; }
        private DirtyValue<string> _logPropertyCity;
        public string LogPropertyCity { get => _logPropertyCity; set => _logPropertyCity = value; }
        private DirtyValue<string> _logPropertyState;
        public string LogPropertyState { get => _logPropertyState; set => _logPropertyState = value; }
        private DirtyValue<string> _logPropertyZipcode;
        public string LogPropertyZipcode { get => _logPropertyZipcode; set => _logPropertyZipcode = value; }
        private DirtyValue<decimal?> _logProposedHazardInsurance;
        public decimal? LogProposedHazardInsurance { get => _logProposedHazardInsurance; set => _logProposedHazardInsurance = value; }
        private DirtyValue<decimal?> _logProposedHOAFees;
        public decimal? LogProposedHOAFees { get => _logProposedHOAFees; set => _logProposedHOAFees = value; }
        private DirtyValue<decimal?> _logProposedHousingPITI;
        public decimal? LogProposedHousingPITI { get => _logProposedHousingPITI; set => _logProposedHousingPITI = value; }
        private DirtyValue<decimal?> _logProposedMortgageInsurance;
        public decimal? LogProposedMortgageInsurance { get => _logProposedMortgageInsurance; set => _logProposedMortgageInsurance = value; }
        private DirtyValue<decimal?> _logProposedOtherPayment;
        public decimal? LogProposedOtherPayment { get => _logProposedOtherPayment; set => _logProposedOtherPayment = value; }
        private DirtyValue<decimal?> _logProposedTaxes;
        public decimal? LogProposedTaxes { get => _logProposedTaxes; set => _logProposedTaxes = value; }
        private DirtyValue<decimal?> _logProposedTotalHousingPayment;
        public decimal? LogProposedTotalHousingPayment { get => _logProposedTotalHousingPayment; set => _logProposedTotalHousingPayment = value; }
        private DirtyValue<decimal?> _logProposedTotalMonthlyDebt;
        public decimal? LogProposedTotalMonthlyDebt { get => _logProposedTotalMonthlyDebt; set => _logProposedTotalMonthlyDebt = value; }
        private DirtyValue<string> _logPurchaseEligibility;
        public string LogPurchaseEligibility { get => _logPurchaseEligibility; set => _logPurchaseEligibility = value; }
        private DirtyValue<decimal?> _logQualifyingRate;
        public decimal? LogQualifyingRate { get => _logQualifyingRate; set => _logQualifyingRate = value; }
        private DirtyValue<string> _logRecordType;
        public string LogRecordType { get => _logRecordType; set => _logRecordType = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logRefinancePurpose;
        public StringEnumValue<RefinancePurpose> LogRefinancePurpose { get => _logRefinancePurpose; set => _logRefinancePurpose = value; }
        private DirtyValue<decimal?> _logReserves;
        public decimal? LogReserves { get => _logReserves; set => _logReserves = value; }
        private DirtyValue<decimal?> _logReservesRequiredVerified;
        public decimal? LogReservesRequiredVerified { get => _logReservesRequiredVerified; set => _logReservesRequiredVerified = value; }
        private DirtyValue<string> _logRiskClass;
        public string LogRiskClass { get => _logRiskClass; set => _logRiskClass = value; }
        private DirtyValue<string> _logSalesConcessions;
        public string LogSalesConcessions { get => _logSalesConcessions; set => _logSalesConcessions = value; }
        private DirtyValue<decimal?> _logSalesPrice;
        public decimal? LogSalesPrice { get => _logSalesPrice; set => _logSalesPrice = value; }
        private DirtyValue<decimal?> _logSecondPandI;
        public decimal? LogSecondPandI { get => _logSecondPandI; set => _logSecondPandI = value; }
        private DirtyValue<string> _logSelectedBorrower;
        public string LogSelectedBorrower { get => _logSelectedBorrower; set => _logSelectedBorrower = value; }
        private DirtyValue<string> _logSelectedRepository;
        public string LogSelectedRepository { get => _logSelectedRepository; set => _logSelectedRepository = value; }
        private DirtyValue<string> _logSellerNumber;
        public string LogSellerNumber { get => _logSellerNumber; set => _logSellerNumber = value; }
        private DirtyValue<decimal?> _logSubjNegCashFlow;
        public decimal? LogSubjNegCashFlow { get => _logSubjNegCashFlow; set => _logSubjNegCashFlow = value; }
        private DirtyValue<DateTime?> _logSubmissionDate;
        public DateTime? LogSubmissionDate { get => _logSubmissionDate; set => _logSubmissionDate = value; }
        private DirtyValue<string> _logSubmissionNumber;
        public string LogSubmissionNumber { get => _logSubmissionNumber; set => _logSubmissionNumber = value; }
        private DirtyValue<string> _logSubmissionTime;
        public string LogSubmissionTime { get => _logSubmissionTime; set => _logSubmissionTime = value; }
        private DirtyValue<string> _logSubmittedBy;
        public string LogSubmittedBy { get => _logSubmittedBy; set => _logSubmittedBy = value; }
        private DirtyValue<string> _logSubmittingCompany;
        public string LogSubmittingCompany { get => _logSubmittingCompany; set => _logSubmittingCompany = value; }
        private DirtyValue<string> _logTemporarySubsidyBuydown;
        public string LogTemporarySubsidyBuydown { get => _logTemporarySubsidyBuydown; set => _logTemporarySubsidyBuydown = value; }
        private DirtyValue<decimal?> _logTLTV;
        public decimal? LogTLTV { get => _logTLTV; set => _logTLTV = value; }
        private DirtyValue<decimal?> _logTotalAsset;
        public decimal? LogTotalAsset { get => _logTotalAsset; set => _logTotalAsset = value; }
        private DirtyValue<decimal?> _logTotalExpense;
        public decimal? LogTotalExpense { get => _logTotalExpense; set => _logTotalExpense = value; }
        private DirtyValue<decimal?> _logTotalExpensePmt;
        public decimal? LogTotalExpensePmt { get => _logTotalExpensePmt; set => _logTotalExpensePmt = value; }
        private DirtyValue<decimal?> _logTotalExpenseRatio;
        public decimal? LogTotalExpenseRatio { get => _logTotalExpenseRatio; set => _logTotalExpenseRatio = value; }
        private DirtyValue<decimal?> _logTotalFundsVerified;
        public decimal? LogTotalFundsVerified { get => _logTotalFundsVerified; set => _logTotalFundsVerified = value; }
        private DirtyValue<decimal?> _logTotalLoanAmount;
        public decimal? LogTotalLoanAmount { get => _logTotalLoanAmount; set => _logTotalLoanAmount = value; }
        private DirtyValue<decimal?> _logTotalMonthlyIncome;
        public decimal? LogTotalMonthlyIncome { get => _logTotalMonthlyIncome; set => _logTotalMonthlyIncome = value; }
        private DirtyValue<string> _logTPONumber;
        public string LogTPONumber { get => _logTPONumber; set => _logTPONumber = value; }
        private DirtyValue<string> _logTransactionID;
        public string LogTransactionID { get => _logTransactionID; set => _logTransactionID = value; }
        private DirtyValue<string> _logUnderwritingRiskAssessOther;
        public string LogUnderwritingRiskAssessOther { get => _logUnderwritingRiskAssessOther; set => _logUnderwritingRiskAssessOther = value; }
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _logUnderwritingRiskAssessType;
        public StringEnumValue<RiskAssessmentType> LogUnderwritingRiskAssessType { get => _logUnderwritingRiskAssessType; set => _logUnderwritingRiskAssessType = value; }
        private DirtyValue<string> _logWithUndisclosedDebt;
        public string LogWithUndisclosedDebt { get => _logWithUndisclosedDebt; set => _logWithUndisclosedDebt = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aUSTrackingLogIndex.Dirty
                    || _batchDocumentRefId.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _isHistory.Dirty
                    || _logAcceptPlusEligible.Dirty
                    || _logAffordableProductType.Dirty
                    || _logAllOtherPayments.Dirty
                    || _logAmortizationMonths.Dirty
                    || _logAmortizationType.Dirty
                    || _logAmtSubordinateFin.Dirty
                    || _logAppraisalTypeMAF.Dirty
                    || _logAppraisedValue.Dirty
                    || _logARMQualifyingRate.Dirty
                    || _logAssessmentType.Dirty
                    || _logAUSRecommendation.Dirty
                    || _logAUSStatus.Dirty
                    || _logAUSTrackingType.Dirty
                    || _logAUSTransactionID.Dirty
                    || _logAUSVersion.Dirty
                    || _logBalloon.Dirty
                    || _logBalloonTerm.Dirty
                    || _logBorrowerAssetAmount.Dirty
                    || _logBorrowerAssetName.Dirty
                    || _logBorrowerAssetType.Dirty
                    || _logBorrowerCreditScore1.Dirty
                    || _logBorrowerCreditScore2.Dirty
                    || _logBorrowerCreditScore3.Dirty
                    || _logBorrowerEquifaxBEACON.Dirty
                    || _logBorrowerExperianFICO.Dirty
                    || _logBorrowerIncomeAmount.Dirty
                    || _logBorrowerIncomeName.Dirty
                    || _logBorrowerIncomeType.Dirty
                    || _logBorrowerInstitutionName.Dirty
                    || _logBorrowerName.Dirty
                    || _logBorrowerScoreName.Dirty
                    || _logBorrowerTransUnionEmpirica.Dirty
                    || _logBorrowerType1.Dirty
                    || _logBorrowerType2.Dirty
                    || _logBoughtDownRate.Dirty
                    || _logBuydown.Dirty
                    || _logCashBack.Dirty
                    || _logCashOutAmount.Dirty
                    || _logCLTV.Dirty
                    || _logCoBorrowerAssetAmount.Dirty
                    || _logCoBorrowerAssetName.Dirty
                    || _logCoBorrowerAssetType.Dirty
                    || _logCoBorrowerCreditScore1.Dirty
                    || _logCoBorrowerCreditScore2.Dirty
                    || _logCoBorrowerCreditScore3.Dirty
                    || _logCoBorrowerEquifaxBEACON.Dirty
                    || _logCoBorrowerExperianFICO.Dirty
                    || _logCoBorrowerIncomeAmount.Dirty
                    || _logCoBorrowerIncomeName.Dirty
                    || _logCoBorrowerIncomeType.Dirty
                    || _logCoBorrowerInstitutionName.Dirty
                    || _logCoborrowerName.Dirty
                    || _logCoBorrowerScoreName.Dirty
                    || _logCoBorrowerTransUnionEmpirica.Dirty
                    || _logCode1.Dirty
                    || _logCode2.Dirty
                    || _logCodeDescription1.Dirty
                    || _logCodeDescription2.Dirty
                    || _logCommunityLending.Dirty
                    || _logCreatedOn.Dirty
                    || _logCreditAgency1.Dirty
                    || _logCreditAgency2.Dirty
                    || _logCreditReportDate1.Dirty
                    || _logCreditReportDate2.Dirty
                    || _logCreditReportID1.Dirty
                    || _logCreditReportID2.Dirty
                    || _logCuredAmortizationType.Dirty
                    || _logCuredAppraisedValue.Dirty
                    || _logCuredCLTV.Dirty
                    || _logCuredHousingExpenseRatio.Dirty
                    || _logCuredLoanPurpose.Dirty
                    || _logCuredLoanTerm.Dirty
                    || _logCuredLoanType.Dirty
                    || _logCuredLTV.Dirty
                    || _logCuredNoteRate.Dirty
                    || _logCuredProposedTotalHousingPayment.Dirty
                    || _logCuredRefinancePurpose.Dirty
                    || _logCuredTotalExpenseRatio.Dirty
                    || _logCuredTotalLoanAmount.Dirty
                    || _logCuredTotalMonthlyIncome.Dirty
                    || _logDateTimeAssessed.Dirty
                    || _logDateTimeRequested.Dirty
                    || _logDebtRatio.Dirty
                    || _logDocumentationLevel.Dirty
                    || _logDUCaseIDorLPAUSKey.Dirty
                    || _logDUPropertyType.Dirty
                    || _logeFolderGUID.Dirty
                    || _logExcessAvailableAssetsNoVerified.Dirty
                    || _logFinancedMIAmount.Dirty
                    || _logFirstPandI.Dirty
                    || _logFirstSubmissionDate.Dirty
                    || _logFirstSubmissionTime.Dirty
                    || _logFreddieDocClass.Dirty
                    || _logFundsRequiredClose.Dirty
                    || _logGUID.Dirty
                    || _logHLCTV.Dirty
                    || _logHousingExpense.Dirty
                    || _logHousingExpenseRatio.Dirty
                    || _logHousingRatio.Dirty
                    || _logHTLTV.Dirty
                    || _logIncludingLess10Mos.Dirty
                    || _logIncomeAssetBase.Dirty
                    || _logIncomeAssetBonus.Dirty
                    || _logIncomeAssetCommission.Dirty
                    || _logIncomeAssetOther.Dirty
                    || _logIncomeAssetOvertime.Dirty
                    || _logIncomeAssetPosCashFlow.Dirty
                    || _logIncomeAssetPositiveNetRental.Dirty
                    || _logIndicatorScore.Dirty
                    || _logIntendedUseofProperty.Dirty
                    || _logLCLAEvaluatedServiceConclusion1.Dirty
                    || _logLCLAEvaluatedServiceConclusion2.Dirty
                    || _logLCLAEvaluatedServiceConclusion3.Dirty
                    || _logLCLAEvaluatedServiceConclusion4.Dirty
                    || _logLCLAEvaluatedServiceType1.Dirty
                    || _logLCLAEvaluatedServiceType2.Dirty
                    || _logLCLAEvaluatedServiceType3.Dirty
                    || _logLCLAEvaluatedServiceType4.Dirty
                    || _logLenderLoan.Dirty
                    || _logLienType.Dirty
                    || _logLoanAmount.Dirty
                    || _logLoanApplicationID.Dirty
                    || _logLoanProcessingStage.Dirty
                    || _logLoanProspectorID.Dirty
                    || _logLoanPurpose.Dirty
                    || _logLoanTerm.Dirty
                    || _logLoanType.Dirty
                    || _logLPAssmtExpDate.Dirty
                    || _logLPPropertyType.Dirty
                    || _logLPVersion.Dirty
                    || _logLQACollateralRepWarrantyServiceConclusion.Dirty
                    || _logLQACreditRiskAssessmentConclusion.Dirty
                    || _logLQADataCompareFieldConclusion.Dirty
                    || _logLQADataCompareFieldName.Dirty
                    || _logLQADataCompareResult.Dirty
                    || _logLQALPKey.Dirty
                    || _logLQAPurchaseEligibilityResult.Dirty
                    || _logLQARiskAssessmentKey.Dirty
                    || _logLQASubmissionDateTime.Dirty
                    || _logLTV.Dirty
                    || _logMaxMortgageLimit.Dirty
                    || _logMIDecision.Dirty
                    || _logMortgageType.Dirty
                    || _logNegAmortizationType.Dirty
                    || _logNegativeNetRental.Dirty
                    || _logNetCashBack.Dirty
                    || _logNewConstruction.Dirty
                    || _logNoteRate.Dirty
                    || _logNOTPNumber.Dirty
                    || _logNoUnits.Dirty
                    || _logNumberOfSubmissions.Dirty
                    || _logOccupancyStatus.Dirty
                    || _logOccupantDebtRatio.Dirty
                    || _logOccupantHousingRatio.Dirty
                    || _logOfferingIdentifier.Dirty
                    || _logOriginatingCompany.Dirty
                    || _logOwnerExistingMtg.Dirty
                    || _logPandI.Dirty
                    || _logPaymentFrequency.Dirty
                    || _logPresentAddress.Dirty
                    || _logPresentAddressCity.Dirty
                    || _logPresentAddressState.Dirty
                    || _logPresentAddressZipCode.Dirty
                    || _logPresentHousingExpense.Dirty
                    || _logPresentPrincipalHousingPayment.Dirty
                    || _logPropertyAddress.Dirty
                    || _logPropertyCity.Dirty
                    || _logPropertyState.Dirty
                    || _logPropertyZipcode.Dirty
                    || _logProposedHazardInsurance.Dirty
                    || _logProposedHOAFees.Dirty
                    || _logProposedHousingPITI.Dirty
                    || _logProposedMortgageInsurance.Dirty
                    || _logProposedOtherPayment.Dirty
                    || _logProposedTaxes.Dirty
                    || _logProposedTotalHousingPayment.Dirty
                    || _logProposedTotalMonthlyDebt.Dirty
                    || _logPurchaseEligibility.Dirty
                    || _logQualifyingRate.Dirty
                    || _logRecordType.Dirty
                    || _logRefinancePurpose.Dirty
                    || _logReserves.Dirty
                    || _logReservesRequiredVerified.Dirty
                    || _logRiskClass.Dirty
                    || _logSalesConcessions.Dirty
                    || _logSalesPrice.Dirty
                    || _logSecondPandI.Dirty
                    || _logSelectedBorrower.Dirty
                    || _logSelectedRepository.Dirty
                    || _logSellerNumber.Dirty
                    || _logSubjNegCashFlow.Dirty
                    || _logSubmissionDate.Dirty
                    || _logSubmissionNumber.Dirty
                    || _logSubmissionTime.Dirty
                    || _logSubmittedBy.Dirty
                    || _logSubmittingCompany.Dirty
                    || _logTemporarySubsidyBuydown.Dirty
                    || _logTLTV.Dirty
                    || _logTotalAsset.Dirty
                    || _logTotalExpense.Dirty
                    || _logTotalExpensePmt.Dirty
                    || _logTotalExpenseRatio.Dirty
                    || _logTotalFundsVerified.Dirty
                    || _logTotalLoanAmount.Dirty
                    || _logTotalMonthlyIncome.Dirty
                    || _logTPONumber.Dirty
                    || _logTransactionID.Dirty
                    || _logUnderwritingRiskAssessOther.Dirty
                    || _logUnderwritingRiskAssessType.Dirty
                    || _logWithUndisclosedDebt.Dirty;
            }
            set
            {
                _aUSTrackingLogIndex.Dirty = value;
                _batchDocumentRefId.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _isHistory.Dirty = value;
                _logAcceptPlusEligible.Dirty = value;
                _logAffordableProductType.Dirty = value;
                _logAllOtherPayments.Dirty = value;
                _logAmortizationMonths.Dirty = value;
                _logAmortizationType.Dirty = value;
                _logAmtSubordinateFin.Dirty = value;
                _logAppraisalTypeMAF.Dirty = value;
                _logAppraisedValue.Dirty = value;
                _logARMQualifyingRate.Dirty = value;
                _logAssessmentType.Dirty = value;
                _logAUSRecommendation.Dirty = value;
                _logAUSStatus.Dirty = value;
                _logAUSTrackingType.Dirty = value;
                _logAUSTransactionID.Dirty = value;
                _logAUSVersion.Dirty = value;
                _logBalloon.Dirty = value;
                _logBalloonTerm.Dirty = value;
                _logBorrowerAssetAmount.Dirty = value;
                _logBorrowerAssetName.Dirty = value;
                _logBorrowerAssetType.Dirty = value;
                _logBorrowerCreditScore1.Dirty = value;
                _logBorrowerCreditScore2.Dirty = value;
                _logBorrowerCreditScore3.Dirty = value;
                _logBorrowerEquifaxBEACON.Dirty = value;
                _logBorrowerExperianFICO.Dirty = value;
                _logBorrowerIncomeAmount.Dirty = value;
                _logBorrowerIncomeName.Dirty = value;
                _logBorrowerIncomeType.Dirty = value;
                _logBorrowerInstitutionName.Dirty = value;
                _logBorrowerName.Dirty = value;
                _logBorrowerScoreName.Dirty = value;
                _logBorrowerTransUnionEmpirica.Dirty = value;
                _logBorrowerType1.Dirty = value;
                _logBorrowerType2.Dirty = value;
                _logBoughtDownRate.Dirty = value;
                _logBuydown.Dirty = value;
                _logCashBack.Dirty = value;
                _logCashOutAmount.Dirty = value;
                _logCLTV.Dirty = value;
                _logCoBorrowerAssetAmount.Dirty = value;
                _logCoBorrowerAssetName.Dirty = value;
                _logCoBorrowerAssetType.Dirty = value;
                _logCoBorrowerCreditScore1.Dirty = value;
                _logCoBorrowerCreditScore2.Dirty = value;
                _logCoBorrowerCreditScore3.Dirty = value;
                _logCoBorrowerEquifaxBEACON.Dirty = value;
                _logCoBorrowerExperianFICO.Dirty = value;
                _logCoBorrowerIncomeAmount.Dirty = value;
                _logCoBorrowerIncomeName.Dirty = value;
                _logCoBorrowerIncomeType.Dirty = value;
                _logCoBorrowerInstitutionName.Dirty = value;
                _logCoborrowerName.Dirty = value;
                _logCoBorrowerScoreName.Dirty = value;
                _logCoBorrowerTransUnionEmpirica.Dirty = value;
                _logCode1.Dirty = value;
                _logCode2.Dirty = value;
                _logCodeDescription1.Dirty = value;
                _logCodeDescription2.Dirty = value;
                _logCommunityLending.Dirty = value;
                _logCreatedOn.Dirty = value;
                _logCreditAgency1.Dirty = value;
                _logCreditAgency2.Dirty = value;
                _logCreditReportDate1.Dirty = value;
                _logCreditReportDate2.Dirty = value;
                _logCreditReportID1.Dirty = value;
                _logCreditReportID2.Dirty = value;
                _logCuredAmortizationType.Dirty = value;
                _logCuredAppraisedValue.Dirty = value;
                _logCuredCLTV.Dirty = value;
                _logCuredHousingExpenseRatio.Dirty = value;
                _logCuredLoanPurpose.Dirty = value;
                _logCuredLoanTerm.Dirty = value;
                _logCuredLoanType.Dirty = value;
                _logCuredLTV.Dirty = value;
                _logCuredNoteRate.Dirty = value;
                _logCuredProposedTotalHousingPayment.Dirty = value;
                _logCuredRefinancePurpose.Dirty = value;
                _logCuredTotalExpenseRatio.Dirty = value;
                _logCuredTotalLoanAmount.Dirty = value;
                _logCuredTotalMonthlyIncome.Dirty = value;
                _logDateTimeAssessed.Dirty = value;
                _logDateTimeRequested.Dirty = value;
                _logDebtRatio.Dirty = value;
                _logDocumentationLevel.Dirty = value;
                _logDUCaseIDorLPAUSKey.Dirty = value;
                _logDUPropertyType.Dirty = value;
                _logeFolderGUID.Dirty = value;
                _logExcessAvailableAssetsNoVerified.Dirty = value;
                _logFinancedMIAmount.Dirty = value;
                _logFirstPandI.Dirty = value;
                _logFirstSubmissionDate.Dirty = value;
                _logFirstSubmissionTime.Dirty = value;
                _logFreddieDocClass.Dirty = value;
                _logFundsRequiredClose.Dirty = value;
                _logGUID.Dirty = value;
                _logHLCTV.Dirty = value;
                _logHousingExpense.Dirty = value;
                _logHousingExpenseRatio.Dirty = value;
                _logHousingRatio.Dirty = value;
                _logHTLTV.Dirty = value;
                _logIncludingLess10Mos.Dirty = value;
                _logIncomeAssetBase.Dirty = value;
                _logIncomeAssetBonus.Dirty = value;
                _logIncomeAssetCommission.Dirty = value;
                _logIncomeAssetOther.Dirty = value;
                _logIncomeAssetOvertime.Dirty = value;
                _logIncomeAssetPosCashFlow.Dirty = value;
                _logIncomeAssetPositiveNetRental.Dirty = value;
                _logIndicatorScore.Dirty = value;
                _logIntendedUseofProperty.Dirty = value;
                _logLCLAEvaluatedServiceConclusion1.Dirty = value;
                _logLCLAEvaluatedServiceConclusion2.Dirty = value;
                _logLCLAEvaluatedServiceConclusion3.Dirty = value;
                _logLCLAEvaluatedServiceConclusion4.Dirty = value;
                _logLCLAEvaluatedServiceType1.Dirty = value;
                _logLCLAEvaluatedServiceType2.Dirty = value;
                _logLCLAEvaluatedServiceType3.Dirty = value;
                _logLCLAEvaluatedServiceType4.Dirty = value;
                _logLenderLoan.Dirty = value;
                _logLienType.Dirty = value;
                _logLoanAmount.Dirty = value;
                _logLoanApplicationID.Dirty = value;
                _logLoanProcessingStage.Dirty = value;
                _logLoanProspectorID.Dirty = value;
                _logLoanPurpose.Dirty = value;
                _logLoanTerm.Dirty = value;
                _logLoanType.Dirty = value;
                _logLPAssmtExpDate.Dirty = value;
                _logLPPropertyType.Dirty = value;
                _logLPVersion.Dirty = value;
                _logLQACollateralRepWarrantyServiceConclusion.Dirty = value;
                _logLQACreditRiskAssessmentConclusion.Dirty = value;
                _logLQADataCompareFieldConclusion.Dirty = value;
                _logLQADataCompareFieldName.Dirty = value;
                _logLQADataCompareResult.Dirty = value;
                _logLQALPKey.Dirty = value;
                _logLQAPurchaseEligibilityResult.Dirty = value;
                _logLQARiskAssessmentKey.Dirty = value;
                _logLQASubmissionDateTime.Dirty = value;
                _logLTV.Dirty = value;
                _logMaxMortgageLimit.Dirty = value;
                _logMIDecision.Dirty = value;
                _logMortgageType.Dirty = value;
                _logNegAmortizationType.Dirty = value;
                _logNegativeNetRental.Dirty = value;
                _logNetCashBack.Dirty = value;
                _logNewConstruction.Dirty = value;
                _logNoteRate.Dirty = value;
                _logNOTPNumber.Dirty = value;
                _logNoUnits.Dirty = value;
                _logNumberOfSubmissions.Dirty = value;
                _logOccupancyStatus.Dirty = value;
                _logOccupantDebtRatio.Dirty = value;
                _logOccupantHousingRatio.Dirty = value;
                _logOfferingIdentifier.Dirty = value;
                _logOriginatingCompany.Dirty = value;
                _logOwnerExistingMtg.Dirty = value;
                _logPandI.Dirty = value;
                _logPaymentFrequency.Dirty = value;
                _logPresentAddress.Dirty = value;
                _logPresentAddressCity.Dirty = value;
                _logPresentAddressState.Dirty = value;
                _logPresentAddressZipCode.Dirty = value;
                _logPresentHousingExpense.Dirty = value;
                _logPresentPrincipalHousingPayment.Dirty = value;
                _logPropertyAddress.Dirty = value;
                _logPropertyCity.Dirty = value;
                _logPropertyState.Dirty = value;
                _logPropertyZipcode.Dirty = value;
                _logProposedHazardInsurance.Dirty = value;
                _logProposedHOAFees.Dirty = value;
                _logProposedHousingPITI.Dirty = value;
                _logProposedMortgageInsurance.Dirty = value;
                _logProposedOtherPayment.Dirty = value;
                _logProposedTaxes.Dirty = value;
                _logProposedTotalHousingPayment.Dirty = value;
                _logProposedTotalMonthlyDebt.Dirty = value;
                _logPurchaseEligibility.Dirty = value;
                _logQualifyingRate.Dirty = value;
                _logRecordType.Dirty = value;
                _logRefinancePurpose.Dirty = value;
                _logReserves.Dirty = value;
                _logReservesRequiredVerified.Dirty = value;
                _logRiskClass.Dirty = value;
                _logSalesConcessions.Dirty = value;
                _logSalesPrice.Dirty = value;
                _logSecondPandI.Dirty = value;
                _logSelectedBorrower.Dirty = value;
                _logSelectedRepository.Dirty = value;
                _logSellerNumber.Dirty = value;
                _logSubjNegCashFlow.Dirty = value;
                _logSubmissionDate.Dirty = value;
                _logSubmissionNumber.Dirty = value;
                _logSubmissionTime.Dirty = value;
                _logSubmittedBy.Dirty = value;
                _logSubmittingCompany.Dirty = value;
                _logTemporarySubsidyBuydown.Dirty = value;
                _logTLTV.Dirty = value;
                _logTotalAsset.Dirty = value;
                _logTotalExpense.Dirty = value;
                _logTotalExpensePmt.Dirty = value;
                _logTotalExpenseRatio.Dirty = value;
                _logTotalFundsVerified.Dirty = value;
                _logTotalLoanAmount.Dirty = value;
                _logTotalMonthlyIncome.Dirty = value;
                _logTPONumber.Dirty = value;
                _logTransactionID.Dirty = value;
                _logUnderwritingRiskAssessOther.Dirty = value;
                _logUnderwritingRiskAssessType.Dirty = value;
                _logWithUndisclosedDebt.Dirty = value;
            }
        }
    }
}