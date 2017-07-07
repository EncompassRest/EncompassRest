using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var aUSTrackingLogIndex = _aUSTrackingLogIndex; aUSTrackingLogIndex.Clean = value; _aUSTrackingLogIndex = aUSTrackingLogIndex;
                var batchDocumentRefId = _batchDocumentRefId; batchDocumentRefId.Clean = value; _batchDocumentRefId = batchDocumentRefId;
                var id = _id; id.Clean = value; _id = id;
                var isEmpty = _isEmpty; isEmpty.Clean = value; _isEmpty = isEmpty;
                var isHistory = _isHistory; isHistory.Clean = value; _isHistory = isHistory;
                var log_AcceptPlusEligible = _log_AcceptPlusEligible; log_AcceptPlusEligible.Clean = value; _log_AcceptPlusEligible = log_AcceptPlusEligible;
                var log_AffordableProductType = _log_AffordableProductType; log_AffordableProductType.Clean = value; _log_AffordableProductType = log_AffordableProductType;
                var log_AllOtherPayments = _log_AllOtherPayments; log_AllOtherPayments.Clean = value; _log_AllOtherPayments = log_AllOtherPayments;
                var log_AmortizationMonths = _log_AmortizationMonths; log_AmortizationMonths.Clean = value; _log_AmortizationMonths = log_AmortizationMonths;
                var log_AmortizationType = _log_AmortizationType; log_AmortizationType.Clean = value; _log_AmortizationType = log_AmortizationType;
                var log_AmtSubordinateFin = _log_AmtSubordinateFin; log_AmtSubordinateFin.Clean = value; _log_AmtSubordinateFin = log_AmtSubordinateFin;
                var log_AppraisalTypeMAF = _log_AppraisalTypeMAF; log_AppraisalTypeMAF.Clean = value; _log_AppraisalTypeMAF = log_AppraisalTypeMAF;
                var log_AppraisedValue = _log_AppraisedValue; log_AppraisedValue.Clean = value; _log_AppraisedValue = log_AppraisedValue;
                var log_ARMQualifyingRate = _log_ARMQualifyingRate; log_ARMQualifyingRate.Clean = value; _log_ARMQualifyingRate = log_ARMQualifyingRate;
                var log_AssessmentType = _log_AssessmentType; log_AssessmentType.Clean = value; _log_AssessmentType = log_AssessmentType;
                var log_AUSRecommendation = _log_AUSRecommendation; log_AUSRecommendation.Clean = value; _log_AUSRecommendation = log_AUSRecommendation;
                var log_AUSStatus = _log_AUSStatus; log_AUSStatus.Clean = value; _log_AUSStatus = log_AUSStatus;
                var log_AUSTrackingType = _log_AUSTrackingType; log_AUSTrackingType.Clean = value; _log_AUSTrackingType = log_AUSTrackingType;
                var log_AUSTransactionID = _log_AUSTransactionID; log_AUSTransactionID.Clean = value; _log_AUSTransactionID = log_AUSTransactionID;
                var log_AUSVersion = _log_AUSVersion; log_AUSVersion.Clean = value; _log_AUSVersion = log_AUSVersion;
                var log_Balloon = _log_Balloon; log_Balloon.Clean = value; _log_Balloon = log_Balloon;
                var log_BalloonTerm = _log_BalloonTerm; log_BalloonTerm.Clean = value; _log_BalloonTerm = log_BalloonTerm;
                var log_BorrowerAssetAmount = _log_BorrowerAssetAmount; log_BorrowerAssetAmount.Clean = value; _log_BorrowerAssetAmount = log_BorrowerAssetAmount;
                var log_BorrowerAssetName = _log_BorrowerAssetName; log_BorrowerAssetName.Clean = value; _log_BorrowerAssetName = log_BorrowerAssetName;
                var log_BorrowerAssetType = _log_BorrowerAssetType; log_BorrowerAssetType.Clean = value; _log_BorrowerAssetType = log_BorrowerAssetType;
                var log_BorrowerCreditScore1 = _log_BorrowerCreditScore1; log_BorrowerCreditScore1.Clean = value; _log_BorrowerCreditScore1 = log_BorrowerCreditScore1;
                var log_BorrowerCreditScore2 = _log_BorrowerCreditScore2; log_BorrowerCreditScore2.Clean = value; _log_BorrowerCreditScore2 = log_BorrowerCreditScore2;
                var log_BorrowerCreditScore3 = _log_BorrowerCreditScore3; log_BorrowerCreditScore3.Clean = value; _log_BorrowerCreditScore3 = log_BorrowerCreditScore3;
                var log_BorrowerEquifaxBEACON = _log_BorrowerEquifaxBEACON; log_BorrowerEquifaxBEACON.Clean = value; _log_BorrowerEquifaxBEACON = log_BorrowerEquifaxBEACON;
                var log_BorrowerExperianFICO = _log_BorrowerExperianFICO; log_BorrowerExperianFICO.Clean = value; _log_BorrowerExperianFICO = log_BorrowerExperianFICO;
                var log_BorrowerIncomeAmount = _log_BorrowerIncomeAmount; log_BorrowerIncomeAmount.Clean = value; _log_BorrowerIncomeAmount = log_BorrowerIncomeAmount;
                var log_BorrowerIncomeName = _log_BorrowerIncomeName; log_BorrowerIncomeName.Clean = value; _log_BorrowerIncomeName = log_BorrowerIncomeName;
                var log_BorrowerIncomeType = _log_BorrowerIncomeType; log_BorrowerIncomeType.Clean = value; _log_BorrowerIncomeType = log_BorrowerIncomeType;
                var log_BorrowerInstitutionName = _log_BorrowerInstitutionName; log_BorrowerInstitutionName.Clean = value; _log_BorrowerInstitutionName = log_BorrowerInstitutionName;
                var log_BorrowerName = _log_BorrowerName; log_BorrowerName.Clean = value; _log_BorrowerName = log_BorrowerName;
                var log_BorrowerScoreName = _log_BorrowerScoreName; log_BorrowerScoreName.Clean = value; _log_BorrowerScoreName = log_BorrowerScoreName;
                var log_BorrowerTransUnionEmpirica = _log_BorrowerTransUnionEmpirica; log_BorrowerTransUnionEmpirica.Clean = value; _log_BorrowerTransUnionEmpirica = log_BorrowerTransUnionEmpirica;
                var log_BorrowerType1 = _log_BorrowerType1; log_BorrowerType1.Clean = value; _log_BorrowerType1 = log_BorrowerType1;
                var log_BorrowerType2 = _log_BorrowerType2; log_BorrowerType2.Clean = value; _log_BorrowerType2 = log_BorrowerType2;
                var log_BoughtDownRate = _log_BoughtDownRate; log_BoughtDownRate.Clean = value; _log_BoughtDownRate = log_BoughtDownRate;
                var log_Buydown = _log_Buydown; log_Buydown.Clean = value; _log_Buydown = log_Buydown;
                var log_CashBack = _log_CashBack; log_CashBack.Clean = value; _log_CashBack = log_CashBack;
                var log_CashOutAmount = _log_CashOutAmount; log_CashOutAmount.Clean = value; _log_CashOutAmount = log_CashOutAmount;
                var log_CLTV = _log_CLTV; log_CLTV.Clean = value; _log_CLTV = log_CLTV;
                var log_CoBorrowerAssetAmount = _log_CoBorrowerAssetAmount; log_CoBorrowerAssetAmount.Clean = value; _log_CoBorrowerAssetAmount = log_CoBorrowerAssetAmount;
                var log_CoBorrowerAssetName = _log_CoBorrowerAssetName; log_CoBorrowerAssetName.Clean = value; _log_CoBorrowerAssetName = log_CoBorrowerAssetName;
                var log_CoBorrowerAssetType = _log_CoBorrowerAssetType; log_CoBorrowerAssetType.Clean = value; _log_CoBorrowerAssetType = log_CoBorrowerAssetType;
                var log_CoBorrowerCreditScore1 = _log_CoBorrowerCreditScore1; log_CoBorrowerCreditScore1.Clean = value; _log_CoBorrowerCreditScore1 = log_CoBorrowerCreditScore1;
                var log_CoBorrowerCreditScore2 = _log_CoBorrowerCreditScore2; log_CoBorrowerCreditScore2.Clean = value; _log_CoBorrowerCreditScore2 = log_CoBorrowerCreditScore2;
                var log_CoBorrowerCreditScore3 = _log_CoBorrowerCreditScore3; log_CoBorrowerCreditScore3.Clean = value; _log_CoBorrowerCreditScore3 = log_CoBorrowerCreditScore3;
                var log_CoBorrowerEquifaxBEACON = _log_CoBorrowerEquifaxBEACON; log_CoBorrowerEquifaxBEACON.Clean = value; _log_CoBorrowerEquifaxBEACON = log_CoBorrowerEquifaxBEACON;
                var log_CoBorrowerExperianFICO = _log_CoBorrowerExperianFICO; log_CoBorrowerExperianFICO.Clean = value; _log_CoBorrowerExperianFICO = log_CoBorrowerExperianFICO;
                var log_CoBorrowerIncomeAmount = _log_CoBorrowerIncomeAmount; log_CoBorrowerIncomeAmount.Clean = value; _log_CoBorrowerIncomeAmount = log_CoBorrowerIncomeAmount;
                var log_CoBorrowerIncomeName = _log_CoBorrowerIncomeName; log_CoBorrowerIncomeName.Clean = value; _log_CoBorrowerIncomeName = log_CoBorrowerIncomeName;
                var log_CoBorrowerIncomeType = _log_CoBorrowerIncomeType; log_CoBorrowerIncomeType.Clean = value; _log_CoBorrowerIncomeType = log_CoBorrowerIncomeType;
                var log_CoBorrowerInstitutionName = _log_CoBorrowerInstitutionName; log_CoBorrowerInstitutionName.Clean = value; _log_CoBorrowerInstitutionName = log_CoBorrowerInstitutionName;
                var log_CoborrowerName = _log_CoborrowerName; log_CoborrowerName.Clean = value; _log_CoborrowerName = log_CoborrowerName;
                var log_CoBorrowerScoreName = _log_CoBorrowerScoreName; log_CoBorrowerScoreName.Clean = value; _log_CoBorrowerScoreName = log_CoBorrowerScoreName;
                var log_CoBorrowerTransUnionEmpirica = _log_CoBorrowerTransUnionEmpirica; log_CoBorrowerTransUnionEmpirica.Clean = value; _log_CoBorrowerTransUnionEmpirica = log_CoBorrowerTransUnionEmpirica;
                var log_Code1 = _log_Code1; log_Code1.Clean = value; _log_Code1 = log_Code1;
                var log_Code2 = _log_Code2; log_Code2.Clean = value; _log_Code2 = log_Code2;
                var log_CodeDescription1 = _log_CodeDescription1; log_CodeDescription1.Clean = value; _log_CodeDescription1 = log_CodeDescription1;
                var log_CodeDescription2 = _log_CodeDescription2; log_CodeDescription2.Clean = value; _log_CodeDescription2 = log_CodeDescription2;
                var log_CommunityLending = _log_CommunityLending; log_CommunityLending.Clean = value; _log_CommunityLending = log_CommunityLending;
                var log_CreatedOn = _log_CreatedOn; log_CreatedOn.Clean = value; _log_CreatedOn = log_CreatedOn;
                var log_CreditAgency1 = _log_CreditAgency1; log_CreditAgency1.Clean = value; _log_CreditAgency1 = log_CreditAgency1;
                var log_CreditAgency2 = _log_CreditAgency2; log_CreditAgency2.Clean = value; _log_CreditAgency2 = log_CreditAgency2;
                var log_CreditReportDate1 = _log_CreditReportDate1; log_CreditReportDate1.Clean = value; _log_CreditReportDate1 = log_CreditReportDate1;
                var log_CreditReportDate2 = _log_CreditReportDate2; log_CreditReportDate2.Clean = value; _log_CreditReportDate2 = log_CreditReportDate2;
                var log_CreditReportID1 = _log_CreditReportID1; log_CreditReportID1.Clean = value; _log_CreditReportID1 = log_CreditReportID1;
                var log_CreditReportID2 = _log_CreditReportID2; log_CreditReportID2.Clean = value; _log_CreditReportID2 = log_CreditReportID2;
                var log_CuredAmortizationType = _log_CuredAmortizationType; log_CuredAmortizationType.Clean = value; _log_CuredAmortizationType = log_CuredAmortizationType;
                var log_CuredAppraisedValue = _log_CuredAppraisedValue; log_CuredAppraisedValue.Clean = value; _log_CuredAppraisedValue = log_CuredAppraisedValue;
                var log_CuredCLTV = _log_CuredCLTV; log_CuredCLTV.Clean = value; _log_CuredCLTV = log_CuredCLTV;
                var log_CuredHousingExpenseRatio = _log_CuredHousingExpenseRatio; log_CuredHousingExpenseRatio.Clean = value; _log_CuredHousingExpenseRatio = log_CuredHousingExpenseRatio;
                var log_CuredLoanPurpose = _log_CuredLoanPurpose; log_CuredLoanPurpose.Clean = value; _log_CuredLoanPurpose = log_CuredLoanPurpose;
                var log_CuredLoanTerm = _log_CuredLoanTerm; log_CuredLoanTerm.Clean = value; _log_CuredLoanTerm = log_CuredLoanTerm;
                var log_CuredLoanType = _log_CuredLoanType; log_CuredLoanType.Clean = value; _log_CuredLoanType = log_CuredLoanType;
                var log_CuredLTV = _log_CuredLTV; log_CuredLTV.Clean = value; _log_CuredLTV = log_CuredLTV;
                var log_CuredNoteRate = _log_CuredNoteRate; log_CuredNoteRate.Clean = value; _log_CuredNoteRate = log_CuredNoteRate;
                var log_CuredProposedTotalHousingPayment = _log_CuredProposedTotalHousingPayment; log_CuredProposedTotalHousingPayment.Clean = value; _log_CuredProposedTotalHousingPayment = log_CuredProposedTotalHousingPayment;
                var log_CuredRefinancePurpose = _log_CuredRefinancePurpose; log_CuredRefinancePurpose.Clean = value; _log_CuredRefinancePurpose = log_CuredRefinancePurpose;
                var log_CuredTotalExpenseRatio = _log_CuredTotalExpenseRatio; log_CuredTotalExpenseRatio.Clean = value; _log_CuredTotalExpenseRatio = log_CuredTotalExpenseRatio;
                var log_CuredTotalLoanAmount = _log_CuredTotalLoanAmount; log_CuredTotalLoanAmount.Clean = value; _log_CuredTotalLoanAmount = log_CuredTotalLoanAmount;
                var log_CuredTotalMonthlyIncome = _log_CuredTotalMonthlyIncome; log_CuredTotalMonthlyIncome.Clean = value; _log_CuredTotalMonthlyIncome = log_CuredTotalMonthlyIncome;
                var log_DateTimeAssessed = _log_DateTimeAssessed; log_DateTimeAssessed.Clean = value; _log_DateTimeAssessed = log_DateTimeAssessed;
                var log_DateTimeRequested = _log_DateTimeRequested; log_DateTimeRequested.Clean = value; _log_DateTimeRequested = log_DateTimeRequested;
                var log_DebtRatio = _log_DebtRatio; log_DebtRatio.Clean = value; _log_DebtRatio = log_DebtRatio;
                var log_DocumentationLevel = _log_DocumentationLevel; log_DocumentationLevel.Clean = value; _log_DocumentationLevel = log_DocumentationLevel;
                var log_DUCaseIDorLPAUSKey = _log_DUCaseIDorLPAUSKey; log_DUCaseIDorLPAUSKey.Clean = value; _log_DUCaseIDorLPAUSKey = log_DUCaseIDorLPAUSKey;
                var log_DUPropertyType = _log_DUPropertyType; log_DUPropertyType.Clean = value; _log_DUPropertyType = log_DUPropertyType;
                var log_eFolderGUID = _log_eFolderGUID; log_eFolderGUID.Clean = value; _log_eFolderGUID = log_eFolderGUID;
                var log_ExcessAvailableAssetsNoVerified = _log_ExcessAvailableAssetsNoVerified; log_ExcessAvailableAssetsNoVerified.Clean = value; _log_ExcessAvailableAssetsNoVerified = log_ExcessAvailableAssetsNoVerified;
                var log_FinancedMIAmount = _log_FinancedMIAmount; log_FinancedMIAmount.Clean = value; _log_FinancedMIAmount = log_FinancedMIAmount;
                var log_FirstPandI = _log_FirstPandI; log_FirstPandI.Clean = value; _log_FirstPandI = log_FirstPandI;
                var log_FirstSubmissionDate = _log_FirstSubmissionDate; log_FirstSubmissionDate.Clean = value; _log_FirstSubmissionDate = log_FirstSubmissionDate;
                var log_FirstSubmissionTime = _log_FirstSubmissionTime; log_FirstSubmissionTime.Clean = value; _log_FirstSubmissionTime = log_FirstSubmissionTime;
                var log_FreddieDocClass = _log_FreddieDocClass; log_FreddieDocClass.Clean = value; _log_FreddieDocClass = log_FreddieDocClass;
                var log_FundsRequiredClose = _log_FundsRequiredClose; log_FundsRequiredClose.Clean = value; _log_FundsRequiredClose = log_FundsRequiredClose;
                var log_GUID = _log_GUID; log_GUID.Clean = value; _log_GUID = log_GUID;
                var log_HLCTV = _log_HLCTV; log_HLCTV.Clean = value; _log_HLCTV = log_HLCTV;
                var log_HousingExpense = _log_HousingExpense; log_HousingExpense.Clean = value; _log_HousingExpense = log_HousingExpense;
                var log_HousingExpenseRatio = _log_HousingExpenseRatio; log_HousingExpenseRatio.Clean = value; _log_HousingExpenseRatio = log_HousingExpenseRatio;
                var log_HousingRatio = _log_HousingRatio; log_HousingRatio.Clean = value; _log_HousingRatio = log_HousingRatio;
                var log_HTLTV = _log_HTLTV; log_HTLTV.Clean = value; _log_HTLTV = log_HTLTV;
                var log_IncludingLess10Mos = _log_IncludingLess10Mos; log_IncludingLess10Mos.Clean = value; _log_IncludingLess10Mos = log_IncludingLess10Mos;
                var log_IncomeAssetBase = _log_IncomeAssetBase; log_IncomeAssetBase.Clean = value; _log_IncomeAssetBase = log_IncomeAssetBase;
                var log_IncomeAssetBonus = _log_IncomeAssetBonus; log_IncomeAssetBonus.Clean = value; _log_IncomeAssetBonus = log_IncomeAssetBonus;
                var log_IncomeAssetCommission = _log_IncomeAssetCommission; log_IncomeAssetCommission.Clean = value; _log_IncomeAssetCommission = log_IncomeAssetCommission;
                var log_IncomeAssetOther = _log_IncomeAssetOther; log_IncomeAssetOther.Clean = value; _log_IncomeAssetOther = log_IncomeAssetOther;
                var log_IncomeAssetOvertime = _log_IncomeAssetOvertime; log_IncomeAssetOvertime.Clean = value; _log_IncomeAssetOvertime = log_IncomeAssetOvertime;
                var log_IncomeAssetPosCashFlow = _log_IncomeAssetPosCashFlow; log_IncomeAssetPosCashFlow.Clean = value; _log_IncomeAssetPosCashFlow = log_IncomeAssetPosCashFlow;
                var log_IncomeAssetPositiveNetRental = _log_IncomeAssetPositiveNetRental; log_IncomeAssetPositiveNetRental.Clean = value; _log_IncomeAssetPositiveNetRental = log_IncomeAssetPositiveNetRental;
                var log_IndicatorScore = _log_IndicatorScore; log_IndicatorScore.Clean = value; _log_IndicatorScore = log_IndicatorScore;
                var log_IntendedUseofProperty = _log_IntendedUseofProperty; log_IntendedUseofProperty.Clean = value; _log_IntendedUseofProperty = log_IntendedUseofProperty;
                var log_LCLAEvaluatedServiceConclusion1 = _log_LCLAEvaluatedServiceConclusion1; log_LCLAEvaluatedServiceConclusion1.Clean = value; _log_LCLAEvaluatedServiceConclusion1 = log_LCLAEvaluatedServiceConclusion1;
                var log_LCLAEvaluatedServiceConclusion2 = _log_LCLAEvaluatedServiceConclusion2; log_LCLAEvaluatedServiceConclusion2.Clean = value; _log_LCLAEvaluatedServiceConclusion2 = log_LCLAEvaluatedServiceConclusion2;
                var log_LCLAEvaluatedServiceConclusion3 = _log_LCLAEvaluatedServiceConclusion3; log_LCLAEvaluatedServiceConclusion3.Clean = value; _log_LCLAEvaluatedServiceConclusion3 = log_LCLAEvaluatedServiceConclusion3;
                var log_LCLAEvaluatedServiceConclusion4 = _log_LCLAEvaluatedServiceConclusion4; log_LCLAEvaluatedServiceConclusion4.Clean = value; _log_LCLAEvaluatedServiceConclusion4 = log_LCLAEvaluatedServiceConclusion4;
                var log_LCLAEvaluatedServiceType1 = _log_LCLAEvaluatedServiceType1; log_LCLAEvaluatedServiceType1.Clean = value; _log_LCLAEvaluatedServiceType1 = log_LCLAEvaluatedServiceType1;
                var log_LCLAEvaluatedServiceType2 = _log_LCLAEvaluatedServiceType2; log_LCLAEvaluatedServiceType2.Clean = value; _log_LCLAEvaluatedServiceType2 = log_LCLAEvaluatedServiceType2;
                var log_LCLAEvaluatedServiceType3 = _log_LCLAEvaluatedServiceType3; log_LCLAEvaluatedServiceType3.Clean = value; _log_LCLAEvaluatedServiceType3 = log_LCLAEvaluatedServiceType3;
                var log_LCLAEvaluatedServiceType4 = _log_LCLAEvaluatedServiceType4; log_LCLAEvaluatedServiceType4.Clean = value; _log_LCLAEvaluatedServiceType4 = log_LCLAEvaluatedServiceType4;
                var log_LenderLoan = _log_LenderLoan; log_LenderLoan.Clean = value; _log_LenderLoan = log_LenderLoan;
                var log_LienType = _log_LienType; log_LienType.Clean = value; _log_LienType = log_LienType;
                var log_LoanAmount = _log_LoanAmount; log_LoanAmount.Clean = value; _log_LoanAmount = log_LoanAmount;
                var log_LoanApplicationID = _log_LoanApplicationID; log_LoanApplicationID.Clean = value; _log_LoanApplicationID = log_LoanApplicationID;
                var log_LoanProcessingStage = _log_LoanProcessingStage; log_LoanProcessingStage.Clean = value; _log_LoanProcessingStage = log_LoanProcessingStage;
                var log_LoanProspectorID = _log_LoanProspectorID; log_LoanProspectorID.Clean = value; _log_LoanProspectorID = log_LoanProspectorID;
                var log_LoanPurpose = _log_LoanPurpose; log_LoanPurpose.Clean = value; _log_LoanPurpose = log_LoanPurpose;
                var log_LoanTerm = _log_LoanTerm; log_LoanTerm.Clean = value; _log_LoanTerm = log_LoanTerm;
                var log_LoanType = _log_LoanType; log_LoanType.Clean = value; _log_LoanType = log_LoanType;
                var log_LPAssmtExpDate = _log_LPAssmtExpDate; log_LPAssmtExpDate.Clean = value; _log_LPAssmtExpDate = log_LPAssmtExpDate;
                var log_LPPropertyType = _log_LPPropertyType; log_LPPropertyType.Clean = value; _log_LPPropertyType = log_LPPropertyType;
                var log_LPVersion = _log_LPVersion; log_LPVersion.Clean = value; _log_LPVersion = log_LPVersion;
                var log_LQACollateralRepWarrantyServiceConclusion = _log_LQACollateralRepWarrantyServiceConclusion; log_LQACollateralRepWarrantyServiceConclusion.Clean = value; _log_LQACollateralRepWarrantyServiceConclusion = log_LQACollateralRepWarrantyServiceConclusion;
                var log_LQACreditRiskAssessmentConclusion = _log_LQACreditRiskAssessmentConclusion; log_LQACreditRiskAssessmentConclusion.Clean = value; _log_LQACreditRiskAssessmentConclusion = log_LQACreditRiskAssessmentConclusion;
                var log_LQADataCompareFieldConclusion = _log_LQADataCompareFieldConclusion; log_LQADataCompareFieldConclusion.Clean = value; _log_LQADataCompareFieldConclusion = log_LQADataCompareFieldConclusion;
                var log_LQADataCompareFieldName = _log_LQADataCompareFieldName; log_LQADataCompareFieldName.Clean = value; _log_LQADataCompareFieldName = log_LQADataCompareFieldName;
                var log_LQADataCompareResult = _log_LQADataCompareResult; log_LQADataCompareResult.Clean = value; _log_LQADataCompareResult = log_LQADataCompareResult;
                var log_LQALPKey = _log_LQALPKey; log_LQALPKey.Clean = value; _log_LQALPKey = log_LQALPKey;
                var log_LQAPurchaseEligibilityResult = _log_LQAPurchaseEligibilityResult; log_LQAPurchaseEligibilityResult.Clean = value; _log_LQAPurchaseEligibilityResult = log_LQAPurchaseEligibilityResult;
                var log_LQARiskAssessmentKey = _log_LQARiskAssessmentKey; log_LQARiskAssessmentKey.Clean = value; _log_LQARiskAssessmentKey = log_LQARiskAssessmentKey;
                var log_LQASubmissionDateTime = _log_LQASubmissionDateTime; log_LQASubmissionDateTime.Clean = value; _log_LQASubmissionDateTime = log_LQASubmissionDateTime;
                var log_LTV = _log_LTV; log_LTV.Clean = value; _log_LTV = log_LTV;
                var log_MaxMortgageLimit = _log_MaxMortgageLimit; log_MaxMortgageLimit.Clean = value; _log_MaxMortgageLimit = log_MaxMortgageLimit;
                var log_MIDecision = _log_MIDecision; log_MIDecision.Clean = value; _log_MIDecision = log_MIDecision;
                var log_MortgageType = _log_MortgageType; log_MortgageType.Clean = value; _log_MortgageType = log_MortgageType;
                var log_NegAmortizationType = _log_NegAmortizationType; log_NegAmortizationType.Clean = value; _log_NegAmortizationType = log_NegAmortizationType;
                var log_NegativeNetRental = _log_NegativeNetRental; log_NegativeNetRental.Clean = value; _log_NegativeNetRental = log_NegativeNetRental;
                var log_NetCashBack = _log_NetCashBack; log_NetCashBack.Clean = value; _log_NetCashBack = log_NetCashBack;
                var log_NewConstruction = _log_NewConstruction; log_NewConstruction.Clean = value; _log_NewConstruction = log_NewConstruction;
                var log_NoteRate = _log_NoteRate; log_NoteRate.Clean = value; _log_NoteRate = log_NoteRate;
                var log_NOTPNumber = _log_NOTPNumber; log_NOTPNumber.Clean = value; _log_NOTPNumber = log_NOTPNumber;
                var log_NoUnits = _log_NoUnits; log_NoUnits.Clean = value; _log_NoUnits = log_NoUnits;
                var log_NumberOfSubmissions = _log_NumberOfSubmissions; log_NumberOfSubmissions.Clean = value; _log_NumberOfSubmissions = log_NumberOfSubmissions;
                var log_OccupancyStatus = _log_OccupancyStatus; log_OccupancyStatus.Clean = value; _log_OccupancyStatus = log_OccupancyStatus;
                var log_OccupantDebtRatio = _log_OccupantDebtRatio; log_OccupantDebtRatio.Clean = value; _log_OccupantDebtRatio = log_OccupantDebtRatio;
                var log_OccupantHousingRatio = _log_OccupantHousingRatio; log_OccupantHousingRatio.Clean = value; _log_OccupantHousingRatio = log_OccupantHousingRatio;
                var log_OfferingIdentifier = _log_OfferingIdentifier; log_OfferingIdentifier.Clean = value; _log_OfferingIdentifier = log_OfferingIdentifier;
                var log_OriginatingCompany = _log_OriginatingCompany; log_OriginatingCompany.Clean = value; _log_OriginatingCompany = log_OriginatingCompany;
                var log_OwnerExistingMtg = _log_OwnerExistingMtg; log_OwnerExistingMtg.Clean = value; _log_OwnerExistingMtg = log_OwnerExistingMtg;
                var log_PandI = _log_PandI; log_PandI.Clean = value; _log_PandI = log_PandI;
                var log_PaymentFrequency = _log_PaymentFrequency; log_PaymentFrequency.Clean = value; _log_PaymentFrequency = log_PaymentFrequency;
                var log_PresentAddress = _log_PresentAddress; log_PresentAddress.Clean = value; _log_PresentAddress = log_PresentAddress;
                var log_PresentAddressCity = _log_PresentAddressCity; log_PresentAddressCity.Clean = value; _log_PresentAddressCity = log_PresentAddressCity;
                var log_PresentAddressState = _log_PresentAddressState; log_PresentAddressState.Clean = value; _log_PresentAddressState = log_PresentAddressState;
                var log_PresentAddressZipCode = _log_PresentAddressZipCode; log_PresentAddressZipCode.Clean = value; _log_PresentAddressZipCode = log_PresentAddressZipCode;
                var log_PresentHousingExpense = _log_PresentHousingExpense; log_PresentHousingExpense.Clean = value; _log_PresentHousingExpense = log_PresentHousingExpense;
                var log_PresentPrincipalHousingPayment = _log_PresentPrincipalHousingPayment; log_PresentPrincipalHousingPayment.Clean = value; _log_PresentPrincipalHousingPayment = log_PresentPrincipalHousingPayment;
                var log_PropertyAddress = _log_PropertyAddress; log_PropertyAddress.Clean = value; _log_PropertyAddress = log_PropertyAddress;
                var log_PropertyCity = _log_PropertyCity; log_PropertyCity.Clean = value; _log_PropertyCity = log_PropertyCity;
                var log_PropertyState = _log_PropertyState; log_PropertyState.Clean = value; _log_PropertyState = log_PropertyState;
                var log_PropertyZipcode = _log_PropertyZipcode; log_PropertyZipcode.Clean = value; _log_PropertyZipcode = log_PropertyZipcode;
                var log_ProposedHazardInsurance = _log_ProposedHazardInsurance; log_ProposedHazardInsurance.Clean = value; _log_ProposedHazardInsurance = log_ProposedHazardInsurance;
                var log_ProposedHOAFees = _log_ProposedHOAFees; log_ProposedHOAFees.Clean = value; _log_ProposedHOAFees = log_ProposedHOAFees;
                var log_ProposedHousingPITI = _log_ProposedHousingPITI; log_ProposedHousingPITI.Clean = value; _log_ProposedHousingPITI = log_ProposedHousingPITI;
                var log_ProposedMortgageInsurance = _log_ProposedMortgageInsurance; log_ProposedMortgageInsurance.Clean = value; _log_ProposedMortgageInsurance = log_ProposedMortgageInsurance;
                var log_ProposedOtherPayment = _log_ProposedOtherPayment; log_ProposedOtherPayment.Clean = value; _log_ProposedOtherPayment = log_ProposedOtherPayment;
                var log_ProposedTaxes = _log_ProposedTaxes; log_ProposedTaxes.Clean = value; _log_ProposedTaxes = log_ProposedTaxes;
                var log_ProposedTotalHousingPayment = _log_ProposedTotalHousingPayment; log_ProposedTotalHousingPayment.Clean = value; _log_ProposedTotalHousingPayment = log_ProposedTotalHousingPayment;
                var log_ProposedTotalMonthlyDebt = _log_ProposedTotalMonthlyDebt; log_ProposedTotalMonthlyDebt.Clean = value; _log_ProposedTotalMonthlyDebt = log_ProposedTotalMonthlyDebt;
                var log_PurchaseEligibility = _log_PurchaseEligibility; log_PurchaseEligibility.Clean = value; _log_PurchaseEligibility = log_PurchaseEligibility;
                var log_QualifyingRate = _log_QualifyingRate; log_QualifyingRate.Clean = value; _log_QualifyingRate = log_QualifyingRate;
                var log_RecordType = _log_RecordType; log_RecordType.Clean = value; _log_RecordType = log_RecordType;
                var log_RefinancePurpose = _log_RefinancePurpose; log_RefinancePurpose.Clean = value; _log_RefinancePurpose = log_RefinancePurpose;
                var log_Reserves = _log_Reserves; log_Reserves.Clean = value; _log_Reserves = log_Reserves;
                var log_ReservesRequiredVerified = _log_ReservesRequiredVerified; log_ReservesRequiredVerified.Clean = value; _log_ReservesRequiredVerified = log_ReservesRequiredVerified;
                var log_RiskClass = _log_RiskClass; log_RiskClass.Clean = value; _log_RiskClass = log_RiskClass;
                var log_SalesConcessions = _log_SalesConcessions; log_SalesConcessions.Clean = value; _log_SalesConcessions = log_SalesConcessions;
                var log_SalesPrice = _log_SalesPrice; log_SalesPrice.Clean = value; _log_SalesPrice = log_SalesPrice;
                var log_SecondPandI = _log_SecondPandI; log_SecondPandI.Clean = value; _log_SecondPandI = log_SecondPandI;
                var log_SelectedBorrower = _log_SelectedBorrower; log_SelectedBorrower.Clean = value; _log_SelectedBorrower = log_SelectedBorrower;
                var log_SelectedRepository = _log_SelectedRepository; log_SelectedRepository.Clean = value; _log_SelectedRepository = log_SelectedRepository;
                var log_SellerNumber = _log_SellerNumber; log_SellerNumber.Clean = value; _log_SellerNumber = log_SellerNumber;
                var log_SubjNegCashFlow = _log_SubjNegCashFlow; log_SubjNegCashFlow.Clean = value; _log_SubjNegCashFlow = log_SubjNegCashFlow;
                var log_SubmissionDate = _log_SubmissionDate; log_SubmissionDate.Clean = value; _log_SubmissionDate = log_SubmissionDate;
                var log_SubmissionNumber = _log_SubmissionNumber; log_SubmissionNumber.Clean = value; _log_SubmissionNumber = log_SubmissionNumber;
                var log_SubmissionTime = _log_SubmissionTime; log_SubmissionTime.Clean = value; _log_SubmissionTime = log_SubmissionTime;
                var log_SubmittedBy = _log_SubmittedBy; log_SubmittedBy.Clean = value; _log_SubmittedBy = log_SubmittedBy;
                var log_SubmittingCompany = _log_SubmittingCompany; log_SubmittingCompany.Clean = value; _log_SubmittingCompany = log_SubmittingCompany;
                var log_TemporarySubsidyBuydown = _log_TemporarySubsidyBuydown; log_TemporarySubsidyBuydown.Clean = value; _log_TemporarySubsidyBuydown = log_TemporarySubsidyBuydown;
                var log_TLTV = _log_TLTV; log_TLTV.Clean = value; _log_TLTV = log_TLTV;
                var log_TotalAsset = _log_TotalAsset; log_TotalAsset.Clean = value; _log_TotalAsset = log_TotalAsset;
                var log_TotalExpense = _log_TotalExpense; log_TotalExpense.Clean = value; _log_TotalExpense = log_TotalExpense;
                var log_TotalExpensePmt = _log_TotalExpensePmt; log_TotalExpensePmt.Clean = value; _log_TotalExpensePmt = log_TotalExpensePmt;
                var log_TotalExpenseRatio = _log_TotalExpenseRatio; log_TotalExpenseRatio.Clean = value; _log_TotalExpenseRatio = log_TotalExpenseRatio;
                var log_TotalFundsVerified = _log_TotalFundsVerified; log_TotalFundsVerified.Clean = value; _log_TotalFundsVerified = log_TotalFundsVerified;
                var log_TotalLoanAmount = _log_TotalLoanAmount; log_TotalLoanAmount.Clean = value; _log_TotalLoanAmount = log_TotalLoanAmount;
                var log_TotalMonthlyIncome = _log_TotalMonthlyIncome; log_TotalMonthlyIncome.Clean = value; _log_TotalMonthlyIncome = log_TotalMonthlyIncome;
                var log_TPONumber = _log_TPONumber; log_TPONumber.Clean = value; _log_TPONumber = log_TPONumber;
                var log_TransactionID = _log_TransactionID; log_TransactionID.Clean = value; _log_TransactionID = log_TransactionID;
                var log_UnderwritingRiskAssessOther = _log_UnderwritingRiskAssessOther; log_UnderwritingRiskAssessOther.Clean = value; _log_UnderwritingRiskAssessOther = log_UnderwritingRiskAssessOther;
                var log_UnderwritingRiskAssessType = _log_UnderwritingRiskAssessType; log_UnderwritingRiskAssessType.Clean = value; _log_UnderwritingRiskAssessType = log_UnderwritingRiskAssessType;
                var log_WithUndisclosedDebt = _log_WithUndisclosedDebt; log_WithUndisclosedDebt.Clean = value; _log_WithUndisclosedDebt = log_WithUndisclosedDebt;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public AUSTrackingLog()
        {
            Clean = true;
        }
    }
}