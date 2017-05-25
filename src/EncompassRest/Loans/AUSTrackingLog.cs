using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AUSTrackingLog : IClean
    {
        private Value<int?> _aUSTrackingLogIndex;
        public int? AUSTrackingLogIndex { get { return _aUSTrackingLogIndex; } set { _aUSTrackingLogIndex = value; } }
        private Value<string> _batchDocumentRefId;
        public string BatchDocumentRefId { get { return _batchDocumentRefId; } set { _batchDocumentRefId = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private Value<bool?> _isHistory;
        public bool? IsHistory { get { return _isHistory; } set { _isHistory = value; } }
        private Value<string> _log_AcceptPlusEligible;
        public string Log_AcceptPlusEligible { get { return _log_AcceptPlusEligible; } set { _log_AcceptPlusEligible = value; } }
        private Value<string> _log_AffordableProductType;
        public string Log_AffordableProductType { get { return _log_AffordableProductType; } set { _log_AffordableProductType = value; } }
        private Value<decimal?> _log_AllOtherPayments;
        public decimal? Log_AllOtherPayments { get { return _log_AllOtherPayments; } set { _log_AllOtherPayments = value; } }
        private Value<int?> _log_AmortizationMonths;
        public int? Log_AmortizationMonths { get { return _log_AmortizationMonths; } set { _log_AmortizationMonths = value; } }
        private Value<string> _log_AmortizationType;
        public string Log_AmortizationType { get { return _log_AmortizationType; } set { _log_AmortizationType = value; } }
        private Value<decimal?> _log_AmtSubordinateFin;
        public decimal? Log_AmtSubordinateFin { get { return _log_AmtSubordinateFin; } set { _log_AmtSubordinateFin = value; } }
        private Value<string> _log_AppraisalTypeMAF;
        public string Log_AppraisalTypeMAF { get { return _log_AppraisalTypeMAF; } set { _log_AppraisalTypeMAF = value; } }
        private Value<int?> _log_AppraisedValue;
        public int? Log_AppraisedValue { get { return _log_AppraisedValue; } set { _log_AppraisedValue = value; } }
        private Value<decimal?> _log_ARMQualifyingRate;
        public decimal? Log_ARMQualifyingRate { get { return _log_ARMQualifyingRate; } set { _log_ARMQualifyingRate = value; } }
        private Value<string> _log_AssessmentType;
        public string Log_AssessmentType { get { return _log_AssessmentType; } set { _log_AssessmentType = value; } }
        private Value<string> _log_AUSRecommendation;
        public string Log_AUSRecommendation { get { return _log_AUSRecommendation; } set { _log_AUSRecommendation = value; } }
        private Value<string> _log_AUSStatus;
        public string Log_AUSStatus { get { return _log_AUSStatus; } set { _log_AUSStatus = value; } }
        private Value<string> _log_AUSTrackingType;
        public string Log_AUSTrackingType { get { return _log_AUSTrackingType; } set { _log_AUSTrackingType = value; } }
        private Value<string> _log_AUSTransactionID;
        public string Log_AUSTransactionID { get { return _log_AUSTransactionID; } set { _log_AUSTransactionID = value; } }
        private Value<string> _log_AUSVersion;
        public string Log_AUSVersion { get { return _log_AUSVersion; } set { _log_AUSVersion = value; } }
        private Value<string> _log_Balloon;
        public string Log_Balloon { get { return _log_Balloon; } set { _log_Balloon = value; } }
        private Value<int?> _log_BalloonTerm;
        public int? Log_BalloonTerm { get { return _log_BalloonTerm; } set { _log_BalloonTerm = value; } }
        private Value<decimal?> _log_BorrowerAssetAmount;
        public decimal? Log_BorrowerAssetAmount { get { return _log_BorrowerAssetAmount; } set { _log_BorrowerAssetAmount = value; } }
        private Value<string> _log_BorrowerAssetName;
        public string Log_BorrowerAssetName { get { return _log_BorrowerAssetName; } set { _log_BorrowerAssetName = value; } }
        private Value<string> _log_BorrowerAssetType;
        public string Log_BorrowerAssetType { get { return _log_BorrowerAssetType; } set { _log_BorrowerAssetType = value; } }
        private Value<string> _log_BorrowerCreditScore1;
        public string Log_BorrowerCreditScore1 { get { return _log_BorrowerCreditScore1; } set { _log_BorrowerCreditScore1 = value; } }
        private Value<string> _log_BorrowerCreditScore2;
        public string Log_BorrowerCreditScore2 { get { return _log_BorrowerCreditScore2; } set { _log_BorrowerCreditScore2 = value; } }
        private Value<string> _log_BorrowerCreditScore3;
        public string Log_BorrowerCreditScore3 { get { return _log_BorrowerCreditScore3; } set { _log_BorrowerCreditScore3 = value; } }
        private Value<string> _log_BorrowerEquifaxBEACON;
        public string Log_BorrowerEquifaxBEACON { get { return _log_BorrowerEquifaxBEACON; } set { _log_BorrowerEquifaxBEACON = value; } }
        private Value<string> _log_BorrowerExperianFICO;
        public string Log_BorrowerExperianFICO { get { return _log_BorrowerExperianFICO; } set { _log_BorrowerExperianFICO = value; } }
        private Value<decimal?> _log_BorrowerIncomeAmount;
        public decimal? Log_BorrowerIncomeAmount { get { return _log_BorrowerIncomeAmount; } set { _log_BorrowerIncomeAmount = value; } }
        private Value<string> _log_BorrowerIncomeName;
        public string Log_BorrowerIncomeName { get { return _log_BorrowerIncomeName; } set { _log_BorrowerIncomeName = value; } }
        private Value<string> _log_BorrowerIncomeType;
        public string Log_BorrowerIncomeType { get { return _log_BorrowerIncomeType; } set { _log_BorrowerIncomeType = value; } }
        private Value<string> _log_BorrowerInstitutionName;
        public string Log_BorrowerInstitutionName { get { return _log_BorrowerInstitutionName; } set { _log_BorrowerInstitutionName = value; } }
        private Value<string> _log_BorrowerName;
        public string Log_BorrowerName { get { return _log_BorrowerName; } set { _log_BorrowerName = value; } }
        private Value<string> _log_BorrowerScoreName;
        public string Log_BorrowerScoreName { get { return _log_BorrowerScoreName; } set { _log_BorrowerScoreName = value; } }
        private Value<string> _log_BorrowerTransUnionEmpirica;
        public string Log_BorrowerTransUnionEmpirica { get { return _log_BorrowerTransUnionEmpirica; } set { _log_BorrowerTransUnionEmpirica = value; } }
        private Value<string> _log_BorrowerType1;
        public string Log_BorrowerType1 { get { return _log_BorrowerType1; } set { _log_BorrowerType1 = value; } }
        private Value<string> _log_BorrowerType2;
        public string Log_BorrowerType2 { get { return _log_BorrowerType2; } set { _log_BorrowerType2 = value; } }
        private Value<decimal?> _log_BoughtDownRate;
        public decimal? Log_BoughtDownRate { get { return _log_BoughtDownRate; } set { _log_BoughtDownRate = value; } }
        private Value<string> _log_Buydown;
        public string Log_Buydown { get { return _log_Buydown; } set { _log_Buydown = value; } }
        private Value<decimal?> _log_CashBack;
        public decimal? Log_CashBack { get { return _log_CashBack; } set { _log_CashBack = value; } }
        private Value<decimal?> _log_CashOutAmount;
        public decimal? Log_CashOutAmount { get { return _log_CashOutAmount; } set { _log_CashOutAmount = value; } }
        private Value<decimal?> _log_CLTV;
        public decimal? Log_CLTV { get { return _log_CLTV; } set { _log_CLTV = value; } }
        private Value<decimal?> _log_CoBorrowerAssetAmount;
        public decimal? Log_CoBorrowerAssetAmount { get { return _log_CoBorrowerAssetAmount; } set { _log_CoBorrowerAssetAmount = value; } }
        private Value<string> _log_CoBorrowerAssetName;
        public string Log_CoBorrowerAssetName { get { return _log_CoBorrowerAssetName; } set { _log_CoBorrowerAssetName = value; } }
        private Value<string> _log_CoBorrowerAssetType;
        public string Log_CoBorrowerAssetType { get { return _log_CoBorrowerAssetType; } set { _log_CoBorrowerAssetType = value; } }
        private Value<string> _log_CoBorrowerCreditScore1;
        public string Log_CoBorrowerCreditScore1 { get { return _log_CoBorrowerCreditScore1; } set { _log_CoBorrowerCreditScore1 = value; } }
        private Value<string> _log_CoBorrowerCreditScore2;
        public string Log_CoBorrowerCreditScore2 { get { return _log_CoBorrowerCreditScore2; } set { _log_CoBorrowerCreditScore2 = value; } }
        private Value<string> _log_CoBorrowerCreditScore3;
        public string Log_CoBorrowerCreditScore3 { get { return _log_CoBorrowerCreditScore3; } set { _log_CoBorrowerCreditScore3 = value; } }
        private Value<string> _log_CoBorrowerEquifaxBEACON;
        public string Log_CoBorrowerEquifaxBEACON { get { return _log_CoBorrowerEquifaxBEACON; } set { _log_CoBorrowerEquifaxBEACON = value; } }
        private Value<string> _log_CoBorrowerExperianFICO;
        public string Log_CoBorrowerExperianFICO { get { return _log_CoBorrowerExperianFICO; } set { _log_CoBorrowerExperianFICO = value; } }
        private Value<decimal?> _log_CoBorrowerIncomeAmount;
        public decimal? Log_CoBorrowerIncomeAmount { get { return _log_CoBorrowerIncomeAmount; } set { _log_CoBorrowerIncomeAmount = value; } }
        private Value<string> _log_CoBorrowerIncomeName;
        public string Log_CoBorrowerIncomeName { get { return _log_CoBorrowerIncomeName; } set { _log_CoBorrowerIncomeName = value; } }
        private Value<string> _log_CoBorrowerIncomeType;
        public string Log_CoBorrowerIncomeType { get { return _log_CoBorrowerIncomeType; } set { _log_CoBorrowerIncomeType = value; } }
        private Value<string> _log_CoBorrowerInstitutionName;
        public string Log_CoBorrowerInstitutionName { get { return _log_CoBorrowerInstitutionName; } set { _log_CoBorrowerInstitutionName = value; } }
        private Value<string> _log_CoborrowerName;
        public string Log_CoborrowerName { get { return _log_CoborrowerName; } set { _log_CoborrowerName = value; } }
        private Value<string> _log_CoBorrowerScoreName;
        public string Log_CoBorrowerScoreName { get { return _log_CoBorrowerScoreName; } set { _log_CoBorrowerScoreName = value; } }
        private Value<string> _log_CoBorrowerTransUnionEmpirica;
        public string Log_CoBorrowerTransUnionEmpirica { get { return _log_CoBorrowerTransUnionEmpirica; } set { _log_CoBorrowerTransUnionEmpirica = value; } }
        private Value<string> _log_Code1;
        public string Log_Code1 { get { return _log_Code1; } set { _log_Code1 = value; } }
        private Value<string> _log_Code2;
        public string Log_Code2 { get { return _log_Code2; } set { _log_Code2 = value; } }
        private Value<string> _log_CodeDescription1;
        public string Log_CodeDescription1 { get { return _log_CodeDescription1; } set { _log_CodeDescription1 = value; } }
        private Value<string> _log_CodeDescription2;
        public string Log_CodeDescription2 { get { return _log_CodeDescription2; } set { _log_CodeDescription2 = value; } }
        private Value<string> _log_CommunityLending;
        public string Log_CommunityLending { get { return _log_CommunityLending; } set { _log_CommunityLending = value; } }
        private Value<DateTime?> _log_CreatedOn;
        public DateTime? Log_CreatedOn { get { return _log_CreatedOn; } set { _log_CreatedOn = value; } }
        private Value<string> _log_CreditAgency1;
        public string Log_CreditAgency1 { get { return _log_CreditAgency1; } set { _log_CreditAgency1 = value; } }
        private Value<string> _log_CreditAgency2;
        public string Log_CreditAgency2 { get { return _log_CreditAgency2; } set { _log_CreditAgency2 = value; } }
        private Value<DateTime?> _log_CreditReportDate1;
        public DateTime? Log_CreditReportDate1 { get { return _log_CreditReportDate1; } set { _log_CreditReportDate1 = value; } }
        private Value<DateTime?> _log_CreditReportDate2;
        public DateTime? Log_CreditReportDate2 { get { return _log_CreditReportDate2; } set { _log_CreditReportDate2 = value; } }
        private Value<string> _log_CreditReportID1;
        public string Log_CreditReportID1 { get { return _log_CreditReportID1; } set { _log_CreditReportID1 = value; } }
        private Value<string> _log_CreditReportID2;
        public string Log_CreditReportID2 { get { return _log_CreditReportID2; } set { _log_CreditReportID2 = value; } }
        private Value<string> _log_CuredAmortizationType;
        public string Log_CuredAmortizationType { get { return _log_CuredAmortizationType; } set { _log_CuredAmortizationType = value; } }
        private Value<int?> _log_CuredAppraisedValue;
        public int? Log_CuredAppraisedValue { get { return _log_CuredAppraisedValue; } set { _log_CuredAppraisedValue = value; } }
        private Value<decimal?> _log_CuredCLTV;
        public decimal? Log_CuredCLTV { get { return _log_CuredCLTV; } set { _log_CuredCLTV = value; } }
        private Value<decimal?> _log_CuredHousingExpenseRatio;
        public decimal? Log_CuredHousingExpenseRatio { get { return _log_CuredHousingExpenseRatio; } set { _log_CuredHousingExpenseRatio = value; } }
        private Value<string> _log_CuredLoanPurpose;
        public string Log_CuredLoanPurpose { get { return _log_CuredLoanPurpose; } set { _log_CuredLoanPurpose = value; } }
        private Value<int?> _log_CuredLoanTerm;
        public int? Log_CuredLoanTerm { get { return _log_CuredLoanTerm; } set { _log_CuredLoanTerm = value; } }
        private Value<string> _log_CuredLoanType;
        public string Log_CuredLoanType { get { return _log_CuredLoanType; } set { _log_CuredLoanType = value; } }
        private Value<decimal?> _log_CuredLTV;
        public decimal? Log_CuredLTV { get { return _log_CuredLTV; } set { _log_CuredLTV = value; } }
        private Value<decimal?> _log_CuredNoteRate;
        public decimal? Log_CuredNoteRate { get { return _log_CuredNoteRate; } set { _log_CuredNoteRate = value; } }
        private Value<decimal?> _log_CuredProposedTotalHousingPayment;
        public decimal? Log_CuredProposedTotalHousingPayment { get { return _log_CuredProposedTotalHousingPayment; } set { _log_CuredProposedTotalHousingPayment = value; } }
        private Value<string> _log_CuredRefinancePurpose;
        public string Log_CuredRefinancePurpose { get { return _log_CuredRefinancePurpose; } set { _log_CuredRefinancePurpose = value; } }
        private Value<decimal?> _log_CuredTotalExpenseRatio;
        public decimal? Log_CuredTotalExpenseRatio { get { return _log_CuredTotalExpenseRatio; } set { _log_CuredTotalExpenseRatio = value; } }
        private Value<decimal?> _log_CuredTotalLoanAmount;
        public decimal? Log_CuredTotalLoanAmount { get { return _log_CuredTotalLoanAmount; } set { _log_CuredTotalLoanAmount = value; } }
        private Value<decimal?> _log_CuredTotalMonthlyIncome;
        public decimal? Log_CuredTotalMonthlyIncome { get { return _log_CuredTotalMonthlyIncome; } set { _log_CuredTotalMonthlyIncome = value; } }
        private Value<string> _log_DateTimeAssessed;
        public string Log_DateTimeAssessed { get { return _log_DateTimeAssessed; } set { _log_DateTimeAssessed = value; } }
        private Value<string> _log_DateTimeRequested;
        public string Log_DateTimeRequested { get { return _log_DateTimeRequested; } set { _log_DateTimeRequested = value; } }
        private Value<decimal?> _log_DebtRatio;
        public decimal? Log_DebtRatio { get { return _log_DebtRatio; } set { _log_DebtRatio = value; } }
        private Value<string> _log_DocumentationLevel;
        public string Log_DocumentationLevel { get { return _log_DocumentationLevel; } set { _log_DocumentationLevel = value; } }
        private Value<string> _log_DUCaseIDorLPAUSKey;
        public string Log_DUCaseIDorLPAUSKey { get { return _log_DUCaseIDorLPAUSKey; } set { _log_DUCaseIDorLPAUSKey = value; } }
        private Value<string> _log_DUPropertyType;
        public string Log_DUPropertyType { get { return _log_DUPropertyType; } set { _log_DUPropertyType = value; } }
        private Value<string> _log_eFolderGUID;
        public string Log_eFolderGUID { get { return _log_eFolderGUID; } set { _log_eFolderGUID = value; } }
        private Value<decimal?> _log_ExcessAvailableAssetsNoVerified;
        public decimal? Log_ExcessAvailableAssetsNoVerified { get { return _log_ExcessAvailableAssetsNoVerified; } set { _log_ExcessAvailableAssetsNoVerified = value; } }
        private Value<decimal?> _log_FinancedMIAmount;
        public decimal? Log_FinancedMIAmount { get { return _log_FinancedMIAmount; } set { _log_FinancedMIAmount = value; } }
        private Value<decimal?> _log_FirstPandI;
        public decimal? Log_FirstPandI { get { return _log_FirstPandI; } set { _log_FirstPandI = value; } }
        private Value<DateTime?> _log_FirstSubmissionDate;
        public DateTime? Log_FirstSubmissionDate { get { return _log_FirstSubmissionDate; } set { _log_FirstSubmissionDate = value; } }
        private Value<string> _log_FirstSubmissionTime;
        public string Log_FirstSubmissionTime { get { return _log_FirstSubmissionTime; } set { _log_FirstSubmissionTime = value; } }
        private Value<string> _log_FreddieDocClass;
        public string Log_FreddieDocClass { get { return _log_FreddieDocClass; } set { _log_FreddieDocClass = value; } }
        private Value<decimal?> _log_FundsRequiredClose;
        public decimal? Log_FundsRequiredClose { get { return _log_FundsRequiredClose; } set { _log_FundsRequiredClose = value; } }
        private Value<string> _log_GUID;
        public string Log_GUID { get { return _log_GUID; } set { _log_GUID = value; } }
        private Value<decimal?> _log_HLCTV;
        public decimal? Log_HLCTV { get { return _log_HLCTV; } set { _log_HLCTV = value; } }
        private Value<decimal?> _log_HousingExpense;
        public decimal? Log_HousingExpense { get { return _log_HousingExpense; } set { _log_HousingExpense = value; } }
        private Value<decimal?> _log_HousingExpenseRatio;
        public decimal? Log_HousingExpenseRatio { get { return _log_HousingExpenseRatio; } set { _log_HousingExpenseRatio = value; } }
        private Value<decimal?> _log_HousingRatio;
        public decimal? Log_HousingRatio { get { return _log_HousingRatio; } set { _log_HousingRatio = value; } }
        private Value<decimal?> _log_HTLTV;
        public decimal? Log_HTLTV { get { return _log_HTLTV; } set { _log_HTLTV = value; } }
        private Value<string> _log_IncludingLess10Mos;
        public string Log_IncludingLess10Mos { get { return _log_IncludingLess10Mos; } set { _log_IncludingLess10Mos = value; } }
        private Value<decimal?> _log_IncomeAssetBase;
        public decimal? Log_IncomeAssetBase { get { return _log_IncomeAssetBase; } set { _log_IncomeAssetBase = value; } }
        private Value<decimal?> _log_IncomeAssetBonus;
        public decimal? Log_IncomeAssetBonus { get { return _log_IncomeAssetBonus; } set { _log_IncomeAssetBonus = value; } }
        private Value<decimal?> _log_IncomeAssetCommission;
        public decimal? Log_IncomeAssetCommission { get { return _log_IncomeAssetCommission; } set { _log_IncomeAssetCommission = value; } }
        private Value<decimal?> _log_IncomeAssetOther;
        public decimal? Log_IncomeAssetOther { get { return _log_IncomeAssetOther; } set { _log_IncomeAssetOther = value; } }
        private Value<decimal?> _log_IncomeAssetOvertime;
        public decimal? Log_IncomeAssetOvertime { get { return _log_IncomeAssetOvertime; } set { _log_IncomeAssetOvertime = value; } }
        private Value<decimal?> _log_IncomeAssetPosCashFlow;
        public decimal? Log_IncomeAssetPosCashFlow { get { return _log_IncomeAssetPosCashFlow; } set { _log_IncomeAssetPosCashFlow = value; } }
        private Value<decimal?> _log_IncomeAssetPositiveNetRental;
        public decimal? Log_IncomeAssetPositiveNetRental { get { return _log_IncomeAssetPositiveNetRental; } set { _log_IncomeAssetPositiveNetRental = value; } }
        private Value<string> _log_IndicatorScore;
        public string Log_IndicatorScore { get { return _log_IndicatorScore; } set { _log_IndicatorScore = value; } }
        private Value<string> _log_IntendedUseofProperty;
        public string Log_IntendedUseofProperty { get { return _log_IntendedUseofProperty; } set { _log_IntendedUseofProperty = value; } }
        private Value<string> _log_LCLAEvaluatedServiceConclusion1;
        public string Log_LCLAEvaluatedServiceConclusion1 { get { return _log_LCLAEvaluatedServiceConclusion1; } set { _log_LCLAEvaluatedServiceConclusion1 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceConclusion2;
        public string Log_LCLAEvaluatedServiceConclusion2 { get { return _log_LCLAEvaluatedServiceConclusion2; } set { _log_LCLAEvaluatedServiceConclusion2 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceConclusion3;
        public string Log_LCLAEvaluatedServiceConclusion3 { get { return _log_LCLAEvaluatedServiceConclusion3; } set { _log_LCLAEvaluatedServiceConclusion3 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceConclusion4;
        public string Log_LCLAEvaluatedServiceConclusion4 { get { return _log_LCLAEvaluatedServiceConclusion4; } set { _log_LCLAEvaluatedServiceConclusion4 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceType1;
        public string Log_LCLAEvaluatedServiceType1 { get { return _log_LCLAEvaluatedServiceType1; } set { _log_LCLAEvaluatedServiceType1 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceType2;
        public string Log_LCLAEvaluatedServiceType2 { get { return _log_LCLAEvaluatedServiceType2; } set { _log_LCLAEvaluatedServiceType2 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceType3;
        public string Log_LCLAEvaluatedServiceType3 { get { return _log_LCLAEvaluatedServiceType3; } set { _log_LCLAEvaluatedServiceType3 = value; } }
        private Value<string> _log_LCLAEvaluatedServiceType4;
        public string Log_LCLAEvaluatedServiceType4 { get { return _log_LCLAEvaluatedServiceType4; } set { _log_LCLAEvaluatedServiceType4 = value; } }
        private Value<string> _log_LenderLoan;
        public string Log_LenderLoan { get { return _log_LenderLoan; } set { _log_LenderLoan = value; } }
        private Value<string> _log_LienType;
        public string Log_LienType { get { return _log_LienType; } set { _log_LienType = value; } }
        private Value<decimal?> _log_LoanAmount;
        public decimal? Log_LoanAmount { get { return _log_LoanAmount; } set { _log_LoanAmount = value; } }
        private Value<string> _log_LoanApplicationID;
        public string Log_LoanApplicationID { get { return _log_LoanApplicationID; } set { _log_LoanApplicationID = value; } }
        private Value<string> _log_LoanProcessingStage;
        public string Log_LoanProcessingStage { get { return _log_LoanProcessingStage; } set { _log_LoanProcessingStage = value; } }
        private Value<string> _log_LoanProspectorID;
        public string Log_LoanProspectorID { get { return _log_LoanProspectorID; } set { _log_LoanProspectorID = value; } }
        private Value<string> _log_LoanPurpose;
        public string Log_LoanPurpose { get { return _log_LoanPurpose; } set { _log_LoanPurpose = value; } }
        private Value<int?> _log_LoanTerm;
        public int? Log_LoanTerm { get { return _log_LoanTerm; } set { _log_LoanTerm = value; } }
        private Value<string> _log_LoanType;
        public string Log_LoanType { get { return _log_LoanType; } set { _log_LoanType = value; } }
        private Value<DateTime?> _log_LPAssmtExpDate;
        public DateTime? Log_LPAssmtExpDate { get { return _log_LPAssmtExpDate; } set { _log_LPAssmtExpDate = value; } }
        private Value<string> _log_LPPropertyType;
        public string Log_LPPropertyType { get { return _log_LPPropertyType; } set { _log_LPPropertyType = value; } }
        private Value<string> _log_LPVersion;
        public string Log_LPVersion { get { return _log_LPVersion; } set { _log_LPVersion = value; } }
        private Value<string> _log_LQACollateralRepWarrantyServiceConclusion;
        public string Log_LQACollateralRepWarrantyServiceConclusion { get { return _log_LQACollateralRepWarrantyServiceConclusion; } set { _log_LQACollateralRepWarrantyServiceConclusion = value; } }
        private Value<string> _log_LQACreditRiskAssessmentConclusion;
        public string Log_LQACreditRiskAssessmentConclusion { get { return _log_LQACreditRiskAssessmentConclusion; } set { _log_LQACreditRiskAssessmentConclusion = value; } }
        private Value<string> _log_LQADataCompareFieldConclusion;
        public string Log_LQADataCompareFieldConclusion { get { return _log_LQADataCompareFieldConclusion; } set { _log_LQADataCompareFieldConclusion = value; } }
        private Value<string> _log_LQADataCompareFieldName;
        public string Log_LQADataCompareFieldName { get { return _log_LQADataCompareFieldName; } set { _log_LQADataCompareFieldName = value; } }
        private Value<string> _log_LQADataCompareResult;
        public string Log_LQADataCompareResult { get { return _log_LQADataCompareResult; } set { _log_LQADataCompareResult = value; } }
        private Value<string> _log_LQALPKey;
        public string Log_LQALPKey { get { return _log_LQALPKey; } set { _log_LQALPKey = value; } }
        private Value<string> _log_LQAPurchaseEligibilityResult;
        public string Log_LQAPurchaseEligibilityResult { get { return _log_LQAPurchaseEligibilityResult; } set { _log_LQAPurchaseEligibilityResult = value; } }
        private Value<string> _log_LQARiskAssessmentKey;
        public string Log_LQARiskAssessmentKey { get { return _log_LQARiskAssessmentKey; } set { _log_LQARiskAssessmentKey = value; } }
        private Value<DateTime?> _log_LQASubmissionDateTime;
        public DateTime? Log_LQASubmissionDateTime { get { return _log_LQASubmissionDateTime; } set { _log_LQASubmissionDateTime = value; } }
        private Value<decimal?> _log_LTV;
        public decimal? Log_LTV { get { return _log_LTV; } set { _log_LTV = value; } }
        private Value<decimal?> _log_MaxMortgageLimit;
        public decimal? Log_MaxMortgageLimit { get { return _log_MaxMortgageLimit; } set { _log_MaxMortgageLimit = value; } }
        private Value<string> _log_MIDecision;
        public string Log_MIDecision { get { return _log_MIDecision; } set { _log_MIDecision = value; } }
        private Value<string> _log_MortgageType;
        public string Log_MortgageType { get { return _log_MortgageType; } set { _log_MortgageType = value; } }
        private Value<string> _log_NegAmortizationType;
        public string Log_NegAmortizationType { get { return _log_NegAmortizationType; } set { _log_NegAmortizationType = value; } }
        private Value<decimal?> _log_NegativeNetRental;
        public decimal? Log_NegativeNetRental { get { return _log_NegativeNetRental; } set { _log_NegativeNetRental = value; } }
        private Value<decimal?> _log_NetCashBack;
        public decimal? Log_NetCashBack { get { return _log_NetCashBack; } set { _log_NetCashBack = value; } }
        private Value<string> _log_NewConstruction;
        public string Log_NewConstruction { get { return _log_NewConstruction; } set { _log_NewConstruction = value; } }
        private Value<decimal?> _log_NoteRate;
        public decimal? Log_NoteRate { get { return _log_NoteRate; } set { _log_NoteRate = value; } }
        private Value<string> _log_NOTPNumber;
        public string Log_NOTPNumber { get { return _log_NOTPNumber; } set { _log_NOTPNumber = value; } }
        private Value<int?> _log_NoUnits;
        public int? Log_NoUnits { get { return _log_NoUnits; } set { _log_NoUnits = value; } }
        private Value<string> _log_NumberOfSubmissions;
        public string Log_NumberOfSubmissions { get { return _log_NumberOfSubmissions; } set { _log_NumberOfSubmissions = value; } }
        private Value<string> _log_OccupancyStatus;
        public string Log_OccupancyStatus { get { return _log_OccupancyStatus; } set { _log_OccupancyStatus = value; } }
        private Value<decimal?> _log_OccupantDebtRatio;
        public decimal? Log_OccupantDebtRatio { get { return _log_OccupantDebtRatio; } set { _log_OccupantDebtRatio = value; } }
        private Value<decimal?> _log_OccupantHousingRatio;
        public decimal? Log_OccupantHousingRatio { get { return _log_OccupantHousingRatio; } set { _log_OccupantHousingRatio = value; } }
        private Value<string> _log_OfferingIdentifier;
        public string Log_OfferingIdentifier { get { return _log_OfferingIdentifier; } set { _log_OfferingIdentifier = value; } }
        private Value<string> _log_OriginatingCompany;
        public string Log_OriginatingCompany { get { return _log_OriginatingCompany; } set { _log_OriginatingCompany = value; } }
        private Value<decimal?> _log_OwnerExistingMtg;
        public decimal? Log_OwnerExistingMtg { get { return _log_OwnerExistingMtg; } set { _log_OwnerExistingMtg = value; } }
        private Value<decimal?> _log_PandI;
        public decimal? Log_PandI { get { return _log_PandI; } set { _log_PandI = value; } }
        private Value<int?> _log_PaymentFrequency;
        public int? Log_PaymentFrequency { get { return _log_PaymentFrequency; } set { _log_PaymentFrequency = value; } }
        private Value<string> _log_PresentAddress;
        public string Log_PresentAddress { get { return _log_PresentAddress; } set { _log_PresentAddress = value; } }
        private Value<string> _log_PresentAddressCity;
        public string Log_PresentAddressCity { get { return _log_PresentAddressCity; } set { _log_PresentAddressCity = value; } }
        private Value<string> _log_PresentAddressState;
        public string Log_PresentAddressState { get { return _log_PresentAddressState; } set { _log_PresentAddressState = value; } }
        private Value<string> _log_PresentAddressZipCode;
        public string Log_PresentAddressZipCode { get { return _log_PresentAddressZipCode; } set { _log_PresentAddressZipCode = value; } }
        private Value<decimal?> _log_PresentHousingExpense;
        public decimal? Log_PresentHousingExpense { get { return _log_PresentHousingExpense; } set { _log_PresentHousingExpense = value; } }
        private Value<decimal?> _log_PresentPrincipalHousingPayment;
        public decimal? Log_PresentPrincipalHousingPayment { get { return _log_PresentPrincipalHousingPayment; } set { _log_PresentPrincipalHousingPayment = value; } }
        private Value<string> _log_PropertyAddress;
        public string Log_PropertyAddress { get { return _log_PropertyAddress; } set { _log_PropertyAddress = value; } }
        private Value<string> _log_PropertyCity;
        public string Log_PropertyCity { get { return _log_PropertyCity; } set { _log_PropertyCity = value; } }
        private Value<string> _log_PropertyState;
        public string Log_PropertyState { get { return _log_PropertyState; } set { _log_PropertyState = value; } }
        private Value<string> _log_PropertyZipcode;
        public string Log_PropertyZipcode { get { return _log_PropertyZipcode; } set { _log_PropertyZipcode = value; } }
        private Value<decimal?> _log_ProposedHazardInsurance;
        public decimal? Log_ProposedHazardInsurance { get { return _log_ProposedHazardInsurance; } set { _log_ProposedHazardInsurance = value; } }
        private Value<decimal?> _log_ProposedHOAFees;
        public decimal? Log_ProposedHOAFees { get { return _log_ProposedHOAFees; } set { _log_ProposedHOAFees = value; } }
        private Value<decimal?> _log_ProposedHousingPITI;
        public decimal? Log_ProposedHousingPITI { get { return _log_ProposedHousingPITI; } set { _log_ProposedHousingPITI = value; } }
        private Value<decimal?> _log_ProposedMortgageInsurance;
        public decimal? Log_ProposedMortgageInsurance { get { return _log_ProposedMortgageInsurance; } set { _log_ProposedMortgageInsurance = value; } }
        private Value<decimal?> _log_ProposedOtherPayment;
        public decimal? Log_ProposedOtherPayment { get { return _log_ProposedOtherPayment; } set { _log_ProposedOtherPayment = value; } }
        private Value<decimal?> _log_ProposedTaxes;
        public decimal? Log_ProposedTaxes { get { return _log_ProposedTaxes; } set { _log_ProposedTaxes = value; } }
        private Value<decimal?> _log_ProposedTotalHousingPayment;
        public decimal? Log_ProposedTotalHousingPayment { get { return _log_ProposedTotalHousingPayment; } set { _log_ProposedTotalHousingPayment = value; } }
        private Value<decimal?> _log_ProposedTotalMonthlyDebt;
        public decimal? Log_ProposedTotalMonthlyDebt { get { return _log_ProposedTotalMonthlyDebt; } set { _log_ProposedTotalMonthlyDebt = value; } }
        private Value<string> _log_PurchaseEligibility;
        public string Log_PurchaseEligibility { get { return _log_PurchaseEligibility; } set { _log_PurchaseEligibility = value; } }
        private Value<decimal?> _log_QualifyingRate;
        public decimal? Log_QualifyingRate { get { return _log_QualifyingRate; } set { _log_QualifyingRate = value; } }
        private Value<string> _log_RecordType;
        public string Log_RecordType { get { return _log_RecordType; } set { _log_RecordType = value; } }
        private Value<string> _log_RefinancePurpose;
        public string Log_RefinancePurpose { get { return _log_RefinancePurpose; } set { _log_RefinancePurpose = value; } }
        private Value<decimal?> _log_Reserves;
        public decimal? Log_Reserves { get { return _log_Reserves; } set { _log_Reserves = value; } }
        private Value<decimal?> _log_ReservesRequiredVerified;
        public decimal? Log_ReservesRequiredVerified { get { return _log_ReservesRequiredVerified; } set { _log_ReservesRequiredVerified = value; } }
        private Value<string> _log_RiskClass;
        public string Log_RiskClass { get { return _log_RiskClass; } set { _log_RiskClass = value; } }
        private Value<string> _log_SalesConcessions;
        public string Log_SalesConcessions { get { return _log_SalesConcessions; } set { _log_SalesConcessions = value; } }
        private Value<decimal?> _log_SalesPrice;
        public decimal? Log_SalesPrice { get { return _log_SalesPrice; } set { _log_SalesPrice = value; } }
        private Value<decimal?> _log_SecondPandI;
        public decimal? Log_SecondPandI { get { return _log_SecondPandI; } set { _log_SecondPandI = value; } }
        private Value<string> _log_SelectedBorrower;
        public string Log_SelectedBorrower { get { return _log_SelectedBorrower; } set { _log_SelectedBorrower = value; } }
        private Value<string> _log_SelectedRepository;
        public string Log_SelectedRepository { get { return _log_SelectedRepository; } set { _log_SelectedRepository = value; } }
        private Value<string> _log_SellerNumber;
        public string Log_SellerNumber { get { return _log_SellerNumber; } set { _log_SellerNumber = value; } }
        private Value<decimal?> _log_SubjNegCashFlow;
        public decimal? Log_SubjNegCashFlow { get { return _log_SubjNegCashFlow; } set { _log_SubjNegCashFlow = value; } }
        private Value<DateTime?> _log_SubmissionDate;
        public DateTime? Log_SubmissionDate { get { return _log_SubmissionDate; } set { _log_SubmissionDate = value; } }
        private Value<string> _log_SubmissionNumber;
        public string Log_SubmissionNumber { get { return _log_SubmissionNumber; } set { _log_SubmissionNumber = value; } }
        private Value<string> _log_SubmissionTime;
        public string Log_SubmissionTime { get { return _log_SubmissionTime; } set { _log_SubmissionTime = value; } }
        private Value<string> _log_SubmittedBy;
        public string Log_SubmittedBy { get { return _log_SubmittedBy; } set { _log_SubmittedBy = value; } }
        private Value<string> _log_SubmittingCompany;
        public string Log_SubmittingCompany { get { return _log_SubmittingCompany; } set { _log_SubmittingCompany = value; } }
        private Value<string> _log_TemporarySubsidyBuydown;
        public string Log_TemporarySubsidyBuydown { get { return _log_TemporarySubsidyBuydown; } set { _log_TemporarySubsidyBuydown = value; } }
        private Value<decimal?> _log_TLTV;
        public decimal? Log_TLTV { get { return _log_TLTV; } set { _log_TLTV = value; } }
        private Value<decimal?> _log_TotalAsset;
        public decimal? Log_TotalAsset { get { return _log_TotalAsset; } set { _log_TotalAsset = value; } }
        private Value<decimal?> _log_TotalExpense;
        public decimal? Log_TotalExpense { get { return _log_TotalExpense; } set { _log_TotalExpense = value; } }
        private Value<decimal?> _log_TotalExpensePmt;
        public decimal? Log_TotalExpensePmt { get { return _log_TotalExpensePmt; } set { _log_TotalExpensePmt = value; } }
        private Value<decimal?> _log_TotalExpenseRatio;
        public decimal? Log_TotalExpenseRatio { get { return _log_TotalExpenseRatio; } set { _log_TotalExpenseRatio = value; } }
        private Value<decimal?> _log_TotalFundsVerified;
        public decimal? Log_TotalFundsVerified { get { return _log_TotalFundsVerified; } set { _log_TotalFundsVerified = value; } }
        private Value<decimal?> _log_TotalLoanAmount;
        public decimal? Log_TotalLoanAmount { get { return _log_TotalLoanAmount; } set { _log_TotalLoanAmount = value; } }
        private Value<decimal?> _log_TotalMonthlyIncome;
        public decimal? Log_TotalMonthlyIncome { get { return _log_TotalMonthlyIncome; } set { _log_TotalMonthlyIncome = value; } }
        private Value<string> _log_TPONumber;
        public string Log_TPONumber { get { return _log_TPONumber; } set { _log_TPONumber = value; } }
        private Value<string> _log_TransactionID;
        public string Log_TransactionID { get { return _log_TransactionID; } set { _log_TransactionID = value; } }
        private Value<string> _log_UnderwritingRiskAssessOther;
        public string Log_UnderwritingRiskAssessOther { get { return _log_UnderwritingRiskAssessOther; } set { _log_UnderwritingRiskAssessOther = value; } }
        private Value<string> _log_UnderwritingRiskAssessType;
        public string Log_UnderwritingRiskAssessType { get { return _log_UnderwritingRiskAssessType; } set { _log_UnderwritingRiskAssessType = value; } }
        private Value<string> _log_WithUndisclosedDebt;
        public string Log_WithUndisclosedDebt { get { return _log_WithUndisclosedDebt; } set { _log_WithUndisclosedDebt = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aUSTrackingLogIndex.Clean
                    && _batchDocumentRefId.Clean
                    && _id.Clean
                    && _isEmpty.Clean
                    && _isHistory.Clean
                    && _log_AcceptPlusEligible.Clean
                    && _log_AffordableProductType.Clean
                    && _log_AllOtherPayments.Clean
                    && _log_AmortizationMonths.Clean
                    && _log_AmortizationType.Clean
                    && _log_AmtSubordinateFin.Clean
                    && _log_AppraisalTypeMAF.Clean
                    && _log_AppraisedValue.Clean
                    && _log_ARMQualifyingRate.Clean
                    && _log_AssessmentType.Clean
                    && _log_AUSRecommendation.Clean
                    && _log_AUSStatus.Clean
                    && _log_AUSTrackingType.Clean
                    && _log_AUSTransactionID.Clean
                    && _log_AUSVersion.Clean
                    && _log_Balloon.Clean
                    && _log_BalloonTerm.Clean
                    && _log_BorrowerAssetAmount.Clean
                    && _log_BorrowerAssetName.Clean
                    && _log_BorrowerAssetType.Clean
                    && _log_BorrowerCreditScore1.Clean
                    && _log_BorrowerCreditScore2.Clean
                    && _log_BorrowerCreditScore3.Clean
                    && _log_BorrowerEquifaxBEACON.Clean
                    && _log_BorrowerExperianFICO.Clean
                    && _log_BorrowerIncomeAmount.Clean
                    && _log_BorrowerIncomeName.Clean
                    && _log_BorrowerIncomeType.Clean
                    && _log_BorrowerInstitutionName.Clean
                    && _log_BorrowerName.Clean
                    && _log_BorrowerScoreName.Clean
                    && _log_BorrowerTransUnionEmpirica.Clean
                    && _log_BorrowerType1.Clean
                    && _log_BorrowerType2.Clean
                    && _log_BoughtDownRate.Clean
                    && _log_Buydown.Clean
                    && _log_CashBack.Clean
                    && _log_CashOutAmount.Clean
                    && _log_CLTV.Clean
                    && _log_CoBorrowerAssetAmount.Clean
                    && _log_CoBorrowerAssetName.Clean
                    && _log_CoBorrowerAssetType.Clean
                    && _log_CoBorrowerCreditScore1.Clean
                    && _log_CoBorrowerCreditScore2.Clean
                    && _log_CoBorrowerCreditScore3.Clean
                    && _log_CoBorrowerEquifaxBEACON.Clean
                    && _log_CoBorrowerExperianFICO.Clean
                    && _log_CoBorrowerIncomeAmount.Clean
                    && _log_CoBorrowerIncomeName.Clean
                    && _log_CoBorrowerIncomeType.Clean
                    && _log_CoBorrowerInstitutionName.Clean
                    && _log_CoborrowerName.Clean
                    && _log_CoBorrowerScoreName.Clean
                    && _log_CoBorrowerTransUnionEmpirica.Clean
                    && _log_Code1.Clean
                    && _log_Code2.Clean
                    && _log_CodeDescription1.Clean
                    && _log_CodeDescription2.Clean
                    && _log_CommunityLending.Clean
                    && _log_CreatedOn.Clean
                    && _log_CreditAgency1.Clean
                    && _log_CreditAgency2.Clean
                    && _log_CreditReportDate1.Clean
                    && _log_CreditReportDate2.Clean
                    && _log_CreditReportID1.Clean
                    && _log_CreditReportID2.Clean
                    && _log_CuredAmortizationType.Clean
                    && _log_CuredAppraisedValue.Clean
                    && _log_CuredCLTV.Clean
                    && _log_CuredHousingExpenseRatio.Clean
                    && _log_CuredLoanPurpose.Clean
                    && _log_CuredLoanTerm.Clean
                    && _log_CuredLoanType.Clean
                    && _log_CuredLTV.Clean
                    && _log_CuredNoteRate.Clean
                    && _log_CuredProposedTotalHousingPayment.Clean
                    && _log_CuredRefinancePurpose.Clean
                    && _log_CuredTotalExpenseRatio.Clean
                    && _log_CuredTotalLoanAmount.Clean
                    && _log_CuredTotalMonthlyIncome.Clean
                    && _log_DateTimeAssessed.Clean
                    && _log_DateTimeRequested.Clean
                    && _log_DebtRatio.Clean
                    && _log_DocumentationLevel.Clean
                    && _log_DUCaseIDorLPAUSKey.Clean
                    && _log_DUPropertyType.Clean
                    && _log_eFolderGUID.Clean
                    && _log_ExcessAvailableAssetsNoVerified.Clean
                    && _log_FinancedMIAmount.Clean
                    && _log_FirstPandI.Clean
                    && _log_FirstSubmissionDate.Clean
                    && _log_FirstSubmissionTime.Clean
                    && _log_FreddieDocClass.Clean
                    && _log_FundsRequiredClose.Clean
                    && _log_GUID.Clean
                    && _log_HLCTV.Clean
                    && _log_HousingExpense.Clean
                    && _log_HousingExpenseRatio.Clean
                    && _log_HousingRatio.Clean
                    && _log_HTLTV.Clean
                    && _log_IncludingLess10Mos.Clean
                    && _log_IncomeAssetBase.Clean
                    && _log_IncomeAssetBonus.Clean
                    && _log_IncomeAssetCommission.Clean
                    && _log_IncomeAssetOther.Clean
                    && _log_IncomeAssetOvertime.Clean
                    && _log_IncomeAssetPosCashFlow.Clean
                    && _log_IncomeAssetPositiveNetRental.Clean
                    && _log_IndicatorScore.Clean
                    && _log_IntendedUseofProperty.Clean
                    && _log_LCLAEvaluatedServiceConclusion1.Clean
                    && _log_LCLAEvaluatedServiceConclusion2.Clean
                    && _log_LCLAEvaluatedServiceConclusion3.Clean
                    && _log_LCLAEvaluatedServiceConclusion4.Clean
                    && _log_LCLAEvaluatedServiceType1.Clean
                    && _log_LCLAEvaluatedServiceType2.Clean
                    && _log_LCLAEvaluatedServiceType3.Clean
                    && _log_LCLAEvaluatedServiceType4.Clean
                    && _log_LenderLoan.Clean
                    && _log_LienType.Clean
                    && _log_LoanAmount.Clean
                    && _log_LoanApplicationID.Clean
                    && _log_LoanProcessingStage.Clean
                    && _log_LoanProspectorID.Clean
                    && _log_LoanPurpose.Clean
                    && _log_LoanTerm.Clean
                    && _log_LoanType.Clean
                    && _log_LPAssmtExpDate.Clean
                    && _log_LPPropertyType.Clean
                    && _log_LPVersion.Clean
                    && _log_LQACollateralRepWarrantyServiceConclusion.Clean
                    && _log_LQACreditRiskAssessmentConclusion.Clean
                    && _log_LQADataCompareFieldConclusion.Clean
                    && _log_LQADataCompareFieldName.Clean
                    && _log_LQADataCompareResult.Clean
                    && _log_LQALPKey.Clean
                    && _log_LQAPurchaseEligibilityResult.Clean
                    && _log_LQARiskAssessmentKey.Clean
                    && _log_LQASubmissionDateTime.Clean
                    && _log_LTV.Clean
                    && _log_MaxMortgageLimit.Clean
                    && _log_MIDecision.Clean
                    && _log_MortgageType.Clean
                    && _log_NegAmortizationType.Clean
                    && _log_NegativeNetRental.Clean
                    && _log_NetCashBack.Clean
                    && _log_NewConstruction.Clean
                    && _log_NoteRate.Clean
                    && _log_NOTPNumber.Clean
                    && _log_NoUnits.Clean
                    && _log_NumberOfSubmissions.Clean
                    && _log_OccupancyStatus.Clean
                    && _log_OccupantDebtRatio.Clean
                    && _log_OccupantHousingRatio.Clean
                    && _log_OfferingIdentifier.Clean
                    && _log_OriginatingCompany.Clean
                    && _log_OwnerExistingMtg.Clean
                    && _log_PandI.Clean
                    && _log_PaymentFrequency.Clean
                    && _log_PresentAddress.Clean
                    && _log_PresentAddressCity.Clean
                    && _log_PresentAddressState.Clean
                    && _log_PresentAddressZipCode.Clean
                    && _log_PresentHousingExpense.Clean
                    && _log_PresentPrincipalHousingPayment.Clean
                    && _log_PropertyAddress.Clean
                    && _log_PropertyCity.Clean
                    && _log_PropertyState.Clean
                    && _log_PropertyZipcode.Clean
                    && _log_ProposedHazardInsurance.Clean
                    && _log_ProposedHOAFees.Clean
                    && _log_ProposedHousingPITI.Clean
                    && _log_ProposedMortgageInsurance.Clean
                    && _log_ProposedOtherPayment.Clean
                    && _log_ProposedTaxes.Clean
                    && _log_ProposedTotalHousingPayment.Clean
                    && _log_ProposedTotalMonthlyDebt.Clean
                    && _log_PurchaseEligibility.Clean
                    && _log_QualifyingRate.Clean
                    && _log_RecordType.Clean
                    && _log_RefinancePurpose.Clean
                    && _log_Reserves.Clean
                    && _log_ReservesRequiredVerified.Clean
                    && _log_RiskClass.Clean
                    && _log_SalesConcessions.Clean
                    && _log_SalesPrice.Clean
                    && _log_SecondPandI.Clean
                    && _log_SelectedBorrower.Clean
                    && _log_SelectedRepository.Clean
                    && _log_SellerNumber.Clean
                    && _log_SubjNegCashFlow.Clean
                    && _log_SubmissionDate.Clean
                    && _log_SubmissionNumber.Clean
                    && _log_SubmissionTime.Clean
                    && _log_SubmittedBy.Clean
                    && _log_SubmittingCompany.Clean
                    && _log_TemporarySubsidyBuydown.Clean
                    && _log_TLTV.Clean
                    && _log_TotalAsset.Clean
                    && _log_TotalExpense.Clean
                    && _log_TotalExpensePmt.Clean
                    && _log_TotalExpenseRatio.Clean
                    && _log_TotalFundsVerified.Clean
                    && _log_TotalLoanAmount.Clean
                    && _log_TotalMonthlyIncome.Clean
                    && _log_TPONumber.Clean
                    && _log_TransactionID.Clean
                    && _log_UnderwritingRiskAssessOther.Clean
                    && _log_UnderwritingRiskAssessType.Clean
                    && _log_WithUndisclosedDebt.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _aUSTrackingLogIndex; v0.Clean = value; _aUSTrackingLogIndex = v0;
                var v1 = _batchDocumentRefId; v1.Clean = value; _batchDocumentRefId = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _isEmpty; v3.Clean = value; _isEmpty = v3;
                var v4 = _isHistory; v4.Clean = value; _isHistory = v4;
                var v5 = _log_AcceptPlusEligible; v5.Clean = value; _log_AcceptPlusEligible = v5;
                var v6 = _log_AffordableProductType; v6.Clean = value; _log_AffordableProductType = v6;
                var v7 = _log_AllOtherPayments; v7.Clean = value; _log_AllOtherPayments = v7;
                var v8 = _log_AmortizationMonths; v8.Clean = value; _log_AmortizationMonths = v8;
                var v9 = _log_AmortizationType; v9.Clean = value; _log_AmortizationType = v9;
                var v10 = _log_AmtSubordinateFin; v10.Clean = value; _log_AmtSubordinateFin = v10;
                var v11 = _log_AppraisalTypeMAF; v11.Clean = value; _log_AppraisalTypeMAF = v11;
                var v12 = _log_AppraisedValue; v12.Clean = value; _log_AppraisedValue = v12;
                var v13 = _log_ARMQualifyingRate; v13.Clean = value; _log_ARMQualifyingRate = v13;
                var v14 = _log_AssessmentType; v14.Clean = value; _log_AssessmentType = v14;
                var v15 = _log_AUSRecommendation; v15.Clean = value; _log_AUSRecommendation = v15;
                var v16 = _log_AUSStatus; v16.Clean = value; _log_AUSStatus = v16;
                var v17 = _log_AUSTrackingType; v17.Clean = value; _log_AUSTrackingType = v17;
                var v18 = _log_AUSTransactionID; v18.Clean = value; _log_AUSTransactionID = v18;
                var v19 = _log_AUSVersion; v19.Clean = value; _log_AUSVersion = v19;
                var v20 = _log_Balloon; v20.Clean = value; _log_Balloon = v20;
                var v21 = _log_BalloonTerm; v21.Clean = value; _log_BalloonTerm = v21;
                var v22 = _log_BorrowerAssetAmount; v22.Clean = value; _log_BorrowerAssetAmount = v22;
                var v23 = _log_BorrowerAssetName; v23.Clean = value; _log_BorrowerAssetName = v23;
                var v24 = _log_BorrowerAssetType; v24.Clean = value; _log_BorrowerAssetType = v24;
                var v25 = _log_BorrowerCreditScore1; v25.Clean = value; _log_BorrowerCreditScore1 = v25;
                var v26 = _log_BorrowerCreditScore2; v26.Clean = value; _log_BorrowerCreditScore2 = v26;
                var v27 = _log_BorrowerCreditScore3; v27.Clean = value; _log_BorrowerCreditScore3 = v27;
                var v28 = _log_BorrowerEquifaxBEACON; v28.Clean = value; _log_BorrowerEquifaxBEACON = v28;
                var v29 = _log_BorrowerExperianFICO; v29.Clean = value; _log_BorrowerExperianFICO = v29;
                var v30 = _log_BorrowerIncomeAmount; v30.Clean = value; _log_BorrowerIncomeAmount = v30;
                var v31 = _log_BorrowerIncomeName; v31.Clean = value; _log_BorrowerIncomeName = v31;
                var v32 = _log_BorrowerIncomeType; v32.Clean = value; _log_BorrowerIncomeType = v32;
                var v33 = _log_BorrowerInstitutionName; v33.Clean = value; _log_BorrowerInstitutionName = v33;
                var v34 = _log_BorrowerName; v34.Clean = value; _log_BorrowerName = v34;
                var v35 = _log_BorrowerScoreName; v35.Clean = value; _log_BorrowerScoreName = v35;
                var v36 = _log_BorrowerTransUnionEmpirica; v36.Clean = value; _log_BorrowerTransUnionEmpirica = v36;
                var v37 = _log_BorrowerType1; v37.Clean = value; _log_BorrowerType1 = v37;
                var v38 = _log_BorrowerType2; v38.Clean = value; _log_BorrowerType2 = v38;
                var v39 = _log_BoughtDownRate; v39.Clean = value; _log_BoughtDownRate = v39;
                var v40 = _log_Buydown; v40.Clean = value; _log_Buydown = v40;
                var v41 = _log_CashBack; v41.Clean = value; _log_CashBack = v41;
                var v42 = _log_CashOutAmount; v42.Clean = value; _log_CashOutAmount = v42;
                var v43 = _log_CLTV; v43.Clean = value; _log_CLTV = v43;
                var v44 = _log_CoBorrowerAssetAmount; v44.Clean = value; _log_CoBorrowerAssetAmount = v44;
                var v45 = _log_CoBorrowerAssetName; v45.Clean = value; _log_CoBorrowerAssetName = v45;
                var v46 = _log_CoBorrowerAssetType; v46.Clean = value; _log_CoBorrowerAssetType = v46;
                var v47 = _log_CoBorrowerCreditScore1; v47.Clean = value; _log_CoBorrowerCreditScore1 = v47;
                var v48 = _log_CoBorrowerCreditScore2; v48.Clean = value; _log_CoBorrowerCreditScore2 = v48;
                var v49 = _log_CoBorrowerCreditScore3; v49.Clean = value; _log_CoBorrowerCreditScore3 = v49;
                var v50 = _log_CoBorrowerEquifaxBEACON; v50.Clean = value; _log_CoBorrowerEquifaxBEACON = v50;
                var v51 = _log_CoBorrowerExperianFICO; v51.Clean = value; _log_CoBorrowerExperianFICO = v51;
                var v52 = _log_CoBorrowerIncomeAmount; v52.Clean = value; _log_CoBorrowerIncomeAmount = v52;
                var v53 = _log_CoBorrowerIncomeName; v53.Clean = value; _log_CoBorrowerIncomeName = v53;
                var v54 = _log_CoBorrowerIncomeType; v54.Clean = value; _log_CoBorrowerIncomeType = v54;
                var v55 = _log_CoBorrowerInstitutionName; v55.Clean = value; _log_CoBorrowerInstitutionName = v55;
                var v56 = _log_CoborrowerName; v56.Clean = value; _log_CoborrowerName = v56;
                var v57 = _log_CoBorrowerScoreName; v57.Clean = value; _log_CoBorrowerScoreName = v57;
                var v58 = _log_CoBorrowerTransUnionEmpirica; v58.Clean = value; _log_CoBorrowerTransUnionEmpirica = v58;
                var v59 = _log_Code1; v59.Clean = value; _log_Code1 = v59;
                var v60 = _log_Code2; v60.Clean = value; _log_Code2 = v60;
                var v61 = _log_CodeDescription1; v61.Clean = value; _log_CodeDescription1 = v61;
                var v62 = _log_CodeDescription2; v62.Clean = value; _log_CodeDescription2 = v62;
                var v63 = _log_CommunityLending; v63.Clean = value; _log_CommunityLending = v63;
                var v64 = _log_CreatedOn; v64.Clean = value; _log_CreatedOn = v64;
                var v65 = _log_CreditAgency1; v65.Clean = value; _log_CreditAgency1 = v65;
                var v66 = _log_CreditAgency2; v66.Clean = value; _log_CreditAgency2 = v66;
                var v67 = _log_CreditReportDate1; v67.Clean = value; _log_CreditReportDate1 = v67;
                var v68 = _log_CreditReportDate2; v68.Clean = value; _log_CreditReportDate2 = v68;
                var v69 = _log_CreditReportID1; v69.Clean = value; _log_CreditReportID1 = v69;
                var v70 = _log_CreditReportID2; v70.Clean = value; _log_CreditReportID2 = v70;
                var v71 = _log_CuredAmortizationType; v71.Clean = value; _log_CuredAmortizationType = v71;
                var v72 = _log_CuredAppraisedValue; v72.Clean = value; _log_CuredAppraisedValue = v72;
                var v73 = _log_CuredCLTV; v73.Clean = value; _log_CuredCLTV = v73;
                var v74 = _log_CuredHousingExpenseRatio; v74.Clean = value; _log_CuredHousingExpenseRatio = v74;
                var v75 = _log_CuredLoanPurpose; v75.Clean = value; _log_CuredLoanPurpose = v75;
                var v76 = _log_CuredLoanTerm; v76.Clean = value; _log_CuredLoanTerm = v76;
                var v77 = _log_CuredLoanType; v77.Clean = value; _log_CuredLoanType = v77;
                var v78 = _log_CuredLTV; v78.Clean = value; _log_CuredLTV = v78;
                var v79 = _log_CuredNoteRate; v79.Clean = value; _log_CuredNoteRate = v79;
                var v80 = _log_CuredProposedTotalHousingPayment; v80.Clean = value; _log_CuredProposedTotalHousingPayment = v80;
                var v81 = _log_CuredRefinancePurpose; v81.Clean = value; _log_CuredRefinancePurpose = v81;
                var v82 = _log_CuredTotalExpenseRatio; v82.Clean = value; _log_CuredTotalExpenseRatio = v82;
                var v83 = _log_CuredTotalLoanAmount; v83.Clean = value; _log_CuredTotalLoanAmount = v83;
                var v84 = _log_CuredTotalMonthlyIncome; v84.Clean = value; _log_CuredTotalMonthlyIncome = v84;
                var v85 = _log_DateTimeAssessed; v85.Clean = value; _log_DateTimeAssessed = v85;
                var v86 = _log_DateTimeRequested; v86.Clean = value; _log_DateTimeRequested = v86;
                var v87 = _log_DebtRatio; v87.Clean = value; _log_DebtRatio = v87;
                var v88 = _log_DocumentationLevel; v88.Clean = value; _log_DocumentationLevel = v88;
                var v89 = _log_DUCaseIDorLPAUSKey; v89.Clean = value; _log_DUCaseIDorLPAUSKey = v89;
                var v90 = _log_DUPropertyType; v90.Clean = value; _log_DUPropertyType = v90;
                var v91 = _log_eFolderGUID; v91.Clean = value; _log_eFolderGUID = v91;
                var v92 = _log_ExcessAvailableAssetsNoVerified; v92.Clean = value; _log_ExcessAvailableAssetsNoVerified = v92;
                var v93 = _log_FinancedMIAmount; v93.Clean = value; _log_FinancedMIAmount = v93;
                var v94 = _log_FirstPandI; v94.Clean = value; _log_FirstPandI = v94;
                var v95 = _log_FirstSubmissionDate; v95.Clean = value; _log_FirstSubmissionDate = v95;
                var v96 = _log_FirstSubmissionTime; v96.Clean = value; _log_FirstSubmissionTime = v96;
                var v97 = _log_FreddieDocClass; v97.Clean = value; _log_FreddieDocClass = v97;
                var v98 = _log_FundsRequiredClose; v98.Clean = value; _log_FundsRequiredClose = v98;
                var v99 = _log_GUID; v99.Clean = value; _log_GUID = v99;
                var v100 = _log_HLCTV; v100.Clean = value; _log_HLCTV = v100;
                var v101 = _log_HousingExpense; v101.Clean = value; _log_HousingExpense = v101;
                var v102 = _log_HousingExpenseRatio; v102.Clean = value; _log_HousingExpenseRatio = v102;
                var v103 = _log_HousingRatio; v103.Clean = value; _log_HousingRatio = v103;
                var v104 = _log_HTLTV; v104.Clean = value; _log_HTLTV = v104;
                var v105 = _log_IncludingLess10Mos; v105.Clean = value; _log_IncludingLess10Mos = v105;
                var v106 = _log_IncomeAssetBase; v106.Clean = value; _log_IncomeAssetBase = v106;
                var v107 = _log_IncomeAssetBonus; v107.Clean = value; _log_IncomeAssetBonus = v107;
                var v108 = _log_IncomeAssetCommission; v108.Clean = value; _log_IncomeAssetCommission = v108;
                var v109 = _log_IncomeAssetOther; v109.Clean = value; _log_IncomeAssetOther = v109;
                var v110 = _log_IncomeAssetOvertime; v110.Clean = value; _log_IncomeAssetOvertime = v110;
                var v111 = _log_IncomeAssetPosCashFlow; v111.Clean = value; _log_IncomeAssetPosCashFlow = v111;
                var v112 = _log_IncomeAssetPositiveNetRental; v112.Clean = value; _log_IncomeAssetPositiveNetRental = v112;
                var v113 = _log_IndicatorScore; v113.Clean = value; _log_IndicatorScore = v113;
                var v114 = _log_IntendedUseofProperty; v114.Clean = value; _log_IntendedUseofProperty = v114;
                var v115 = _log_LCLAEvaluatedServiceConclusion1; v115.Clean = value; _log_LCLAEvaluatedServiceConclusion1 = v115;
                var v116 = _log_LCLAEvaluatedServiceConclusion2; v116.Clean = value; _log_LCLAEvaluatedServiceConclusion2 = v116;
                var v117 = _log_LCLAEvaluatedServiceConclusion3; v117.Clean = value; _log_LCLAEvaluatedServiceConclusion3 = v117;
                var v118 = _log_LCLAEvaluatedServiceConclusion4; v118.Clean = value; _log_LCLAEvaluatedServiceConclusion4 = v118;
                var v119 = _log_LCLAEvaluatedServiceType1; v119.Clean = value; _log_LCLAEvaluatedServiceType1 = v119;
                var v120 = _log_LCLAEvaluatedServiceType2; v120.Clean = value; _log_LCLAEvaluatedServiceType2 = v120;
                var v121 = _log_LCLAEvaluatedServiceType3; v121.Clean = value; _log_LCLAEvaluatedServiceType3 = v121;
                var v122 = _log_LCLAEvaluatedServiceType4; v122.Clean = value; _log_LCLAEvaluatedServiceType4 = v122;
                var v123 = _log_LenderLoan; v123.Clean = value; _log_LenderLoan = v123;
                var v124 = _log_LienType; v124.Clean = value; _log_LienType = v124;
                var v125 = _log_LoanAmount; v125.Clean = value; _log_LoanAmount = v125;
                var v126 = _log_LoanApplicationID; v126.Clean = value; _log_LoanApplicationID = v126;
                var v127 = _log_LoanProcessingStage; v127.Clean = value; _log_LoanProcessingStage = v127;
                var v128 = _log_LoanProspectorID; v128.Clean = value; _log_LoanProspectorID = v128;
                var v129 = _log_LoanPurpose; v129.Clean = value; _log_LoanPurpose = v129;
                var v130 = _log_LoanTerm; v130.Clean = value; _log_LoanTerm = v130;
                var v131 = _log_LoanType; v131.Clean = value; _log_LoanType = v131;
                var v132 = _log_LPAssmtExpDate; v132.Clean = value; _log_LPAssmtExpDate = v132;
                var v133 = _log_LPPropertyType; v133.Clean = value; _log_LPPropertyType = v133;
                var v134 = _log_LPVersion; v134.Clean = value; _log_LPVersion = v134;
                var v135 = _log_LQACollateralRepWarrantyServiceConclusion; v135.Clean = value; _log_LQACollateralRepWarrantyServiceConclusion = v135;
                var v136 = _log_LQACreditRiskAssessmentConclusion; v136.Clean = value; _log_LQACreditRiskAssessmentConclusion = v136;
                var v137 = _log_LQADataCompareFieldConclusion; v137.Clean = value; _log_LQADataCompareFieldConclusion = v137;
                var v138 = _log_LQADataCompareFieldName; v138.Clean = value; _log_LQADataCompareFieldName = v138;
                var v139 = _log_LQADataCompareResult; v139.Clean = value; _log_LQADataCompareResult = v139;
                var v140 = _log_LQALPKey; v140.Clean = value; _log_LQALPKey = v140;
                var v141 = _log_LQAPurchaseEligibilityResult; v141.Clean = value; _log_LQAPurchaseEligibilityResult = v141;
                var v142 = _log_LQARiskAssessmentKey; v142.Clean = value; _log_LQARiskAssessmentKey = v142;
                var v143 = _log_LQASubmissionDateTime; v143.Clean = value; _log_LQASubmissionDateTime = v143;
                var v144 = _log_LTV; v144.Clean = value; _log_LTV = v144;
                var v145 = _log_MaxMortgageLimit; v145.Clean = value; _log_MaxMortgageLimit = v145;
                var v146 = _log_MIDecision; v146.Clean = value; _log_MIDecision = v146;
                var v147 = _log_MortgageType; v147.Clean = value; _log_MortgageType = v147;
                var v148 = _log_NegAmortizationType; v148.Clean = value; _log_NegAmortizationType = v148;
                var v149 = _log_NegativeNetRental; v149.Clean = value; _log_NegativeNetRental = v149;
                var v150 = _log_NetCashBack; v150.Clean = value; _log_NetCashBack = v150;
                var v151 = _log_NewConstruction; v151.Clean = value; _log_NewConstruction = v151;
                var v152 = _log_NoteRate; v152.Clean = value; _log_NoteRate = v152;
                var v153 = _log_NOTPNumber; v153.Clean = value; _log_NOTPNumber = v153;
                var v154 = _log_NoUnits; v154.Clean = value; _log_NoUnits = v154;
                var v155 = _log_NumberOfSubmissions; v155.Clean = value; _log_NumberOfSubmissions = v155;
                var v156 = _log_OccupancyStatus; v156.Clean = value; _log_OccupancyStatus = v156;
                var v157 = _log_OccupantDebtRatio; v157.Clean = value; _log_OccupantDebtRatio = v157;
                var v158 = _log_OccupantHousingRatio; v158.Clean = value; _log_OccupantHousingRatio = v158;
                var v159 = _log_OfferingIdentifier; v159.Clean = value; _log_OfferingIdentifier = v159;
                var v160 = _log_OriginatingCompany; v160.Clean = value; _log_OriginatingCompany = v160;
                var v161 = _log_OwnerExistingMtg; v161.Clean = value; _log_OwnerExistingMtg = v161;
                var v162 = _log_PandI; v162.Clean = value; _log_PandI = v162;
                var v163 = _log_PaymentFrequency; v163.Clean = value; _log_PaymentFrequency = v163;
                var v164 = _log_PresentAddress; v164.Clean = value; _log_PresentAddress = v164;
                var v165 = _log_PresentAddressCity; v165.Clean = value; _log_PresentAddressCity = v165;
                var v166 = _log_PresentAddressState; v166.Clean = value; _log_PresentAddressState = v166;
                var v167 = _log_PresentAddressZipCode; v167.Clean = value; _log_PresentAddressZipCode = v167;
                var v168 = _log_PresentHousingExpense; v168.Clean = value; _log_PresentHousingExpense = v168;
                var v169 = _log_PresentPrincipalHousingPayment; v169.Clean = value; _log_PresentPrincipalHousingPayment = v169;
                var v170 = _log_PropertyAddress; v170.Clean = value; _log_PropertyAddress = v170;
                var v171 = _log_PropertyCity; v171.Clean = value; _log_PropertyCity = v171;
                var v172 = _log_PropertyState; v172.Clean = value; _log_PropertyState = v172;
                var v173 = _log_PropertyZipcode; v173.Clean = value; _log_PropertyZipcode = v173;
                var v174 = _log_ProposedHazardInsurance; v174.Clean = value; _log_ProposedHazardInsurance = v174;
                var v175 = _log_ProposedHOAFees; v175.Clean = value; _log_ProposedHOAFees = v175;
                var v176 = _log_ProposedHousingPITI; v176.Clean = value; _log_ProposedHousingPITI = v176;
                var v177 = _log_ProposedMortgageInsurance; v177.Clean = value; _log_ProposedMortgageInsurance = v177;
                var v178 = _log_ProposedOtherPayment; v178.Clean = value; _log_ProposedOtherPayment = v178;
                var v179 = _log_ProposedTaxes; v179.Clean = value; _log_ProposedTaxes = v179;
                var v180 = _log_ProposedTotalHousingPayment; v180.Clean = value; _log_ProposedTotalHousingPayment = v180;
                var v181 = _log_ProposedTotalMonthlyDebt; v181.Clean = value; _log_ProposedTotalMonthlyDebt = v181;
                var v182 = _log_PurchaseEligibility; v182.Clean = value; _log_PurchaseEligibility = v182;
                var v183 = _log_QualifyingRate; v183.Clean = value; _log_QualifyingRate = v183;
                var v184 = _log_RecordType; v184.Clean = value; _log_RecordType = v184;
                var v185 = _log_RefinancePurpose; v185.Clean = value; _log_RefinancePurpose = v185;
                var v186 = _log_Reserves; v186.Clean = value; _log_Reserves = v186;
                var v187 = _log_ReservesRequiredVerified; v187.Clean = value; _log_ReservesRequiredVerified = v187;
                var v188 = _log_RiskClass; v188.Clean = value; _log_RiskClass = v188;
                var v189 = _log_SalesConcessions; v189.Clean = value; _log_SalesConcessions = v189;
                var v190 = _log_SalesPrice; v190.Clean = value; _log_SalesPrice = v190;
                var v191 = _log_SecondPandI; v191.Clean = value; _log_SecondPandI = v191;
                var v192 = _log_SelectedBorrower; v192.Clean = value; _log_SelectedBorrower = v192;
                var v193 = _log_SelectedRepository; v193.Clean = value; _log_SelectedRepository = v193;
                var v194 = _log_SellerNumber; v194.Clean = value; _log_SellerNumber = v194;
                var v195 = _log_SubjNegCashFlow; v195.Clean = value; _log_SubjNegCashFlow = v195;
                var v196 = _log_SubmissionDate; v196.Clean = value; _log_SubmissionDate = v196;
                var v197 = _log_SubmissionNumber; v197.Clean = value; _log_SubmissionNumber = v197;
                var v198 = _log_SubmissionTime; v198.Clean = value; _log_SubmissionTime = v198;
                var v199 = _log_SubmittedBy; v199.Clean = value; _log_SubmittedBy = v199;
                var v200 = _log_SubmittingCompany; v200.Clean = value; _log_SubmittingCompany = v200;
                var v201 = _log_TemporarySubsidyBuydown; v201.Clean = value; _log_TemporarySubsidyBuydown = v201;
                var v202 = _log_TLTV; v202.Clean = value; _log_TLTV = v202;
                var v203 = _log_TotalAsset; v203.Clean = value; _log_TotalAsset = v203;
                var v204 = _log_TotalExpense; v204.Clean = value; _log_TotalExpense = v204;
                var v205 = _log_TotalExpensePmt; v205.Clean = value; _log_TotalExpensePmt = v205;
                var v206 = _log_TotalExpenseRatio; v206.Clean = value; _log_TotalExpenseRatio = v206;
                var v207 = _log_TotalFundsVerified; v207.Clean = value; _log_TotalFundsVerified = v207;
                var v208 = _log_TotalLoanAmount; v208.Clean = value; _log_TotalLoanAmount = v208;
                var v209 = _log_TotalMonthlyIncome; v209.Clean = value; _log_TotalMonthlyIncome = v209;
                var v210 = _log_TPONumber; v210.Clean = value; _log_TPONumber = v210;
                var v211 = _log_TransactionID; v211.Clean = value; _log_TransactionID = v211;
                var v212 = _log_UnderwritingRiskAssessOther; v212.Clean = value; _log_UnderwritingRiskAssessOther = v212;
                var v213 = _log_UnderwritingRiskAssessType; v213.Clean = value; _log_UnderwritingRiskAssessType = v213;
                var v214 = _log_WithUndisclosedDebt; v214.Clean = value; _log_WithUndisclosedDebt = v214;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}