using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class AUSTrackingLog : ExtensibleObject
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
        private DirtyValue<string> _log_AcceptPlusEligible;
        public string Log_AcceptPlusEligible { get => _log_AcceptPlusEligible; set => _log_AcceptPlusEligible = value; }
        private DirtyValue<string> _log_AffordableProductType;
        public string Log_AffordableProductType { get => _log_AffordableProductType; set => _log_AffordableProductType = value; }
        private DirtyValue<decimal?> _log_AllOtherPayments;
        public decimal? Log_AllOtherPayments { get => _log_AllOtherPayments; set => _log_AllOtherPayments = value; }
        private DirtyValue<int?> _log_AmortizationMonths;
        public int? Log_AmortizationMonths { get => _log_AmortizationMonths; set => _log_AmortizationMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _log_AmortizationType;
        public StringEnumValue<AmortizationType> Log_AmortizationType { get => _log_AmortizationType; set => _log_AmortizationType = value; }
        private DirtyValue<decimal?> _log_AmtSubordinateFin;
        public decimal? Log_AmtSubordinateFin { get => _log_AmtSubordinateFin; set => _log_AmtSubordinateFin = value; }
        private DirtyValue<string> _log_AppraisalTypeMAF;
        public string Log_AppraisalTypeMAF { get => _log_AppraisalTypeMAF; set => _log_AppraisalTypeMAF = value; }
        private DirtyValue<int?> _log_AppraisedValue;
        public int? Log_AppraisedValue { get => _log_AppraisedValue; set => _log_AppraisedValue = value; }
        private DirtyValue<decimal?> _log_ARMQualifyingRate;
        public decimal? Log_ARMQualifyingRate { get => _log_ARMQualifyingRate; set => _log_ARMQualifyingRate = value; }
        private DirtyValue<string> _log_AssessmentType;
        public string Log_AssessmentType { get => _log_AssessmentType; set => _log_AssessmentType = value; }
        private DirtyValue<string> _log_AUSRecommendation;
        public string Log_AUSRecommendation { get => _log_AUSRecommendation; set => _log_AUSRecommendation = value; }
        private DirtyValue<string> _log_AUSStatus;
        public string Log_AUSStatus { get => _log_AUSStatus; set => _log_AUSStatus = value; }
        private DirtyValue<StringEnumValue<Log_AUSTrackingType>> _log_AUSTrackingType;
        public StringEnumValue<Log_AUSTrackingType> Log_AUSTrackingType { get => _log_AUSTrackingType; set => _log_AUSTrackingType = value; }
        private DirtyValue<string> _log_AUSTransactionID;
        public string Log_AUSTransactionID { get => _log_AUSTransactionID; set => _log_AUSTransactionID = value; }
        private DirtyValue<string> _log_AUSVersion;
        public string Log_AUSVersion { get => _log_AUSVersion; set => _log_AUSVersion = value; }
        private DirtyValue<string> _log_Balloon;
        public string Log_Balloon { get => _log_Balloon; set => _log_Balloon = value; }
        private DirtyValue<int?> _log_BalloonTerm;
        public int? Log_BalloonTerm { get => _log_BalloonTerm; set => _log_BalloonTerm = value; }
        private DirtyValue<decimal?> _log_BorrowerAssetAmount;
        public decimal? Log_BorrowerAssetAmount { get => _log_BorrowerAssetAmount; set => _log_BorrowerAssetAmount = value; }
        private DirtyValue<string> _log_BorrowerAssetName;
        public string Log_BorrowerAssetName { get => _log_BorrowerAssetName; set => _log_BorrowerAssetName = value; }
        private DirtyValue<string> _log_BorrowerAssetType;
        public string Log_BorrowerAssetType { get => _log_BorrowerAssetType; set => _log_BorrowerAssetType = value; }
        private DirtyValue<string> _log_BorrowerCreditScore1;
        public string Log_BorrowerCreditScore1 { get => _log_BorrowerCreditScore1; set => _log_BorrowerCreditScore1 = value; }
        private DirtyValue<string> _log_BorrowerCreditScore2;
        public string Log_BorrowerCreditScore2 { get => _log_BorrowerCreditScore2; set => _log_BorrowerCreditScore2 = value; }
        private DirtyValue<string> _log_BorrowerCreditScore3;
        public string Log_BorrowerCreditScore3 { get => _log_BorrowerCreditScore3; set => _log_BorrowerCreditScore3 = value; }
        private DirtyValue<string> _log_BorrowerEquifaxBEACON;
        public string Log_BorrowerEquifaxBEACON { get => _log_BorrowerEquifaxBEACON; set => _log_BorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _log_BorrowerExperianFICO;
        public string Log_BorrowerExperianFICO { get => _log_BorrowerExperianFICO; set => _log_BorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _log_BorrowerIncomeAmount;
        public decimal? Log_BorrowerIncomeAmount { get => _log_BorrowerIncomeAmount; set => _log_BorrowerIncomeAmount = value; }
        private DirtyValue<string> _log_BorrowerIncomeName;
        public string Log_BorrowerIncomeName { get => _log_BorrowerIncomeName; set => _log_BorrowerIncomeName = value; }
        private DirtyValue<string> _log_BorrowerIncomeType;
        public string Log_BorrowerIncomeType { get => _log_BorrowerIncomeType; set => _log_BorrowerIncomeType = value; }
        private DirtyValue<string> _log_BorrowerInstitutionName;
        public string Log_BorrowerInstitutionName { get => _log_BorrowerInstitutionName; set => _log_BorrowerInstitutionName = value; }
        private DirtyValue<string> _log_BorrowerName;
        public string Log_BorrowerName { get => _log_BorrowerName; set => _log_BorrowerName = value; }
        private DirtyValue<string> _log_BorrowerScoreName;
        public string Log_BorrowerScoreName { get => _log_BorrowerScoreName; set => _log_BorrowerScoreName = value; }
        private DirtyValue<string> _log_BorrowerTransUnionEmpirica;
        public string Log_BorrowerTransUnionEmpirica { get => _log_BorrowerTransUnionEmpirica; set => _log_BorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _log_BorrowerType1;
        public string Log_BorrowerType1 { get => _log_BorrowerType1; set => _log_BorrowerType1 = value; }
        private DirtyValue<string> _log_BorrowerType2;
        public string Log_BorrowerType2 { get => _log_BorrowerType2; set => _log_BorrowerType2 = value; }
        private DirtyValue<decimal?> _log_BoughtDownRate;
        public decimal? Log_BoughtDownRate { get => _log_BoughtDownRate; set => _log_BoughtDownRate = value; }
        private DirtyValue<string> _log_Buydown;
        public string Log_Buydown { get => _log_Buydown; set => _log_Buydown = value; }
        private DirtyValue<decimal?> _log_CashBack;
        public decimal? Log_CashBack { get => _log_CashBack; set => _log_CashBack = value; }
        private DirtyValue<decimal?> _log_CashOutAmount;
        public decimal? Log_CashOutAmount { get => _log_CashOutAmount; set => _log_CashOutAmount = value; }
        private DirtyValue<decimal?> _log_CLTV;
        public decimal? Log_CLTV { get => _log_CLTV; set => _log_CLTV = value; }
        private DirtyValue<decimal?> _log_CoBorrowerAssetAmount;
        public decimal? Log_CoBorrowerAssetAmount { get => _log_CoBorrowerAssetAmount; set => _log_CoBorrowerAssetAmount = value; }
        private DirtyValue<string> _log_CoBorrowerAssetName;
        public string Log_CoBorrowerAssetName { get => _log_CoBorrowerAssetName; set => _log_CoBorrowerAssetName = value; }
        private DirtyValue<string> _log_CoBorrowerAssetType;
        public string Log_CoBorrowerAssetType { get => _log_CoBorrowerAssetType; set => _log_CoBorrowerAssetType = value; }
        private DirtyValue<string> _log_CoBorrowerCreditScore1;
        public string Log_CoBorrowerCreditScore1 { get => _log_CoBorrowerCreditScore1; set => _log_CoBorrowerCreditScore1 = value; }
        private DirtyValue<string> _log_CoBorrowerCreditScore2;
        public string Log_CoBorrowerCreditScore2 { get => _log_CoBorrowerCreditScore2; set => _log_CoBorrowerCreditScore2 = value; }
        private DirtyValue<string> _log_CoBorrowerCreditScore3;
        public string Log_CoBorrowerCreditScore3 { get => _log_CoBorrowerCreditScore3; set => _log_CoBorrowerCreditScore3 = value; }
        private DirtyValue<string> _log_CoBorrowerEquifaxBEACON;
        public string Log_CoBorrowerEquifaxBEACON { get => _log_CoBorrowerEquifaxBEACON; set => _log_CoBorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _log_CoBorrowerExperianFICO;
        public string Log_CoBorrowerExperianFICO { get => _log_CoBorrowerExperianFICO; set => _log_CoBorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _log_CoBorrowerIncomeAmount;
        public decimal? Log_CoBorrowerIncomeAmount { get => _log_CoBorrowerIncomeAmount; set => _log_CoBorrowerIncomeAmount = value; }
        private DirtyValue<string> _log_CoBorrowerIncomeName;
        public string Log_CoBorrowerIncomeName { get => _log_CoBorrowerIncomeName; set => _log_CoBorrowerIncomeName = value; }
        private DirtyValue<string> _log_CoBorrowerIncomeType;
        public string Log_CoBorrowerIncomeType { get => _log_CoBorrowerIncomeType; set => _log_CoBorrowerIncomeType = value; }
        private DirtyValue<string> _log_CoBorrowerInstitutionName;
        public string Log_CoBorrowerInstitutionName { get => _log_CoBorrowerInstitutionName; set => _log_CoBorrowerInstitutionName = value; }
        private DirtyValue<string> _log_CoborrowerName;
        public string Log_CoborrowerName { get => _log_CoborrowerName; set => _log_CoborrowerName = value; }
        private DirtyValue<string> _log_CoBorrowerScoreName;
        public string Log_CoBorrowerScoreName { get => _log_CoBorrowerScoreName; set => _log_CoBorrowerScoreName = value; }
        private DirtyValue<string> _log_CoBorrowerTransUnionEmpirica;
        public string Log_CoBorrowerTransUnionEmpirica { get => _log_CoBorrowerTransUnionEmpirica; set => _log_CoBorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _log_Code1;
        public string Log_Code1 { get => _log_Code1; set => _log_Code1 = value; }
        private DirtyValue<string> _log_Code2;
        public string Log_Code2 { get => _log_Code2; set => _log_Code2 = value; }
        private DirtyValue<string> _log_CodeDescription1;
        public string Log_CodeDescription1 { get => _log_CodeDescription1; set => _log_CodeDescription1 = value; }
        private DirtyValue<string> _log_CodeDescription2;
        public string Log_CodeDescription2 { get => _log_CodeDescription2; set => _log_CodeDescription2 = value; }
        private DirtyValue<string> _log_CommunityLending;
        public string Log_CommunityLending { get => _log_CommunityLending; set => _log_CommunityLending = value; }
        private DirtyValue<DateTime?> _log_CreatedOn;
        public DateTime? Log_CreatedOn { get => _log_CreatedOn; set => _log_CreatedOn = value; }
        private DirtyValue<string> _log_CreditAgency1;
        public string Log_CreditAgency1 { get => _log_CreditAgency1; set => _log_CreditAgency1 = value; }
        private DirtyValue<string> _log_CreditAgency2;
        public string Log_CreditAgency2 { get => _log_CreditAgency2; set => _log_CreditAgency2 = value; }
        private DirtyValue<DateTime?> _log_CreditReportDate1;
        public DateTime? Log_CreditReportDate1 { get => _log_CreditReportDate1; set => _log_CreditReportDate1 = value; }
        private DirtyValue<DateTime?> _log_CreditReportDate2;
        public DateTime? Log_CreditReportDate2 { get => _log_CreditReportDate2; set => _log_CreditReportDate2 = value; }
        private DirtyValue<string> _log_CreditReportID1;
        public string Log_CreditReportID1 { get => _log_CreditReportID1; set => _log_CreditReportID1 = value; }
        private DirtyValue<string> _log_CreditReportID2;
        public string Log_CreditReportID2 { get => _log_CreditReportID2; set => _log_CreditReportID2 = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _log_CuredAmortizationType;
        public StringEnumValue<AmortizationType> Log_CuredAmortizationType { get => _log_CuredAmortizationType; set => _log_CuredAmortizationType = value; }
        private DirtyValue<int?> _log_CuredAppraisedValue;
        public int? Log_CuredAppraisedValue { get => _log_CuredAppraisedValue; set => _log_CuredAppraisedValue = value; }
        private DirtyValue<decimal?> _log_CuredCLTV;
        public decimal? Log_CuredCLTV { get => _log_CuredCLTV; set => _log_CuredCLTV = value; }
        private DirtyValue<decimal?> _log_CuredHousingExpenseRatio;
        public decimal? Log_CuredHousingExpenseRatio { get => _log_CuredHousingExpenseRatio; set => _log_CuredHousingExpenseRatio = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _log_CuredLoanPurpose;
        public StringEnumValue<LoanPurposeType> Log_CuredLoanPurpose { get => _log_CuredLoanPurpose; set => _log_CuredLoanPurpose = value; }
        private DirtyValue<int?> _log_CuredLoanTerm;
        public int? Log_CuredLoanTerm { get => _log_CuredLoanTerm; set => _log_CuredLoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _log_CuredLoanType;
        public StringEnumValue<LoanType> Log_CuredLoanType { get => _log_CuredLoanType; set => _log_CuredLoanType = value; }
        private DirtyValue<decimal?> _log_CuredLTV;
        public decimal? Log_CuredLTV { get => _log_CuredLTV; set => _log_CuredLTV = value; }
        private DirtyValue<decimal?> _log_CuredNoteRate;
        public decimal? Log_CuredNoteRate { get => _log_CuredNoteRate; set => _log_CuredNoteRate = value; }
        private DirtyValue<decimal?> _log_CuredProposedTotalHousingPayment;
        public decimal? Log_CuredProposedTotalHousingPayment { get => _log_CuredProposedTotalHousingPayment; set => _log_CuredProposedTotalHousingPayment = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _log_CuredRefinancePurpose;
        public StringEnumValue<RefinancePurpose> Log_CuredRefinancePurpose { get => _log_CuredRefinancePurpose; set => _log_CuredRefinancePurpose = value; }
        private DirtyValue<decimal?> _log_CuredTotalExpenseRatio;
        public decimal? Log_CuredTotalExpenseRatio { get => _log_CuredTotalExpenseRatio; set => _log_CuredTotalExpenseRatio = value; }
        private DirtyValue<decimal?> _log_CuredTotalLoanAmount;
        public decimal? Log_CuredTotalLoanAmount { get => _log_CuredTotalLoanAmount; set => _log_CuredTotalLoanAmount = value; }
        private DirtyValue<decimal?> _log_CuredTotalMonthlyIncome;
        public decimal? Log_CuredTotalMonthlyIncome { get => _log_CuredTotalMonthlyIncome; set => _log_CuredTotalMonthlyIncome = value; }
        private DirtyValue<string> _log_DateTimeAssessed;
        public string Log_DateTimeAssessed { get => _log_DateTimeAssessed; set => _log_DateTimeAssessed = value; }
        private DirtyValue<string> _log_DateTimeRequested;
        public string Log_DateTimeRequested { get => _log_DateTimeRequested; set => _log_DateTimeRequested = value; }
        private DirtyValue<decimal?> _log_DebtRatio;
        public decimal? Log_DebtRatio { get => _log_DebtRatio; set => _log_DebtRatio = value; }
        private DirtyValue<string> _log_DocumentationLevel;
        public string Log_DocumentationLevel { get => _log_DocumentationLevel; set => _log_DocumentationLevel = value; }
        private DirtyValue<string> _log_DUCaseIDorLPAUSKey;
        public string Log_DUCaseIDorLPAUSKey { get => _log_DUCaseIDorLPAUSKey; set => _log_DUCaseIDorLPAUSKey = value; }
        private DirtyValue<StringEnumValue<PropertyType>> _log_DUPropertyType;
        public StringEnumValue<PropertyType> Log_DUPropertyType { get => _log_DUPropertyType; set => _log_DUPropertyType = value; }
        private DirtyValue<string> _log_eFolderGUID;
        public string Log_eFolderGUID { get => _log_eFolderGUID; set => _log_eFolderGUID = value; }
        private DirtyValue<decimal?> _log_ExcessAvailableAssetsNoVerified;
        public decimal? Log_ExcessAvailableAssetsNoVerified { get => _log_ExcessAvailableAssetsNoVerified; set => _log_ExcessAvailableAssetsNoVerified = value; }
        private DirtyValue<decimal?> _log_FinancedMIAmount;
        public decimal? Log_FinancedMIAmount { get => _log_FinancedMIAmount; set => _log_FinancedMIAmount = value; }
        private DirtyValue<decimal?> _log_FirstPandI;
        public decimal? Log_FirstPandI { get => _log_FirstPandI; set => _log_FirstPandI = value; }
        private DirtyValue<DateTime?> _log_FirstSubmissionDate;
        public DateTime? Log_FirstSubmissionDate { get => _log_FirstSubmissionDate; set => _log_FirstSubmissionDate = value; }
        private DirtyValue<string> _log_FirstSubmissionTime;
        public string Log_FirstSubmissionTime { get => _log_FirstSubmissionTime; set => _log_FirstSubmissionTime = value; }
        private DirtyValue<string> _log_FreddieDocClass;
        public string Log_FreddieDocClass { get => _log_FreddieDocClass; set => _log_FreddieDocClass = value; }
        private DirtyValue<decimal?> _log_FundsRequiredClose;
        public decimal? Log_FundsRequiredClose { get => _log_FundsRequiredClose; set => _log_FundsRequiredClose = value; }
        private DirtyValue<string> _log_GUID;
        public string Log_GUID { get => _log_GUID; set => _log_GUID = value; }
        private DirtyValue<decimal?> _log_HLCTV;
        public decimal? Log_HLCTV { get => _log_HLCTV; set => _log_HLCTV = value; }
        private DirtyValue<decimal?> _log_HousingExpense;
        public decimal? Log_HousingExpense { get => _log_HousingExpense; set => _log_HousingExpense = value; }
        private DirtyValue<decimal?> _log_HousingExpenseRatio;
        public decimal? Log_HousingExpenseRatio { get => _log_HousingExpenseRatio; set => _log_HousingExpenseRatio = value; }
        private DirtyValue<decimal?> _log_HousingRatio;
        public decimal? Log_HousingRatio { get => _log_HousingRatio; set => _log_HousingRatio = value; }
        private DirtyValue<decimal?> _log_HTLTV;
        public decimal? Log_HTLTV { get => _log_HTLTV; set => _log_HTLTV = value; }
        private DirtyValue<string> _log_IncludingLess10Mos;
        public string Log_IncludingLess10Mos { get => _log_IncludingLess10Mos; set => _log_IncludingLess10Mos = value; }
        private DirtyValue<decimal?> _log_IncomeAssetBase;
        public decimal? Log_IncomeAssetBase { get => _log_IncomeAssetBase; set => _log_IncomeAssetBase = value; }
        private DirtyValue<decimal?> _log_IncomeAssetBonus;
        public decimal? Log_IncomeAssetBonus { get => _log_IncomeAssetBonus; set => _log_IncomeAssetBonus = value; }
        private DirtyValue<decimal?> _log_IncomeAssetCommission;
        public decimal? Log_IncomeAssetCommission { get => _log_IncomeAssetCommission; set => _log_IncomeAssetCommission = value; }
        private DirtyValue<decimal?> _log_IncomeAssetOther;
        public decimal? Log_IncomeAssetOther { get => _log_IncomeAssetOther; set => _log_IncomeAssetOther = value; }
        private DirtyValue<decimal?> _log_IncomeAssetOvertime;
        public decimal? Log_IncomeAssetOvertime { get => _log_IncomeAssetOvertime; set => _log_IncomeAssetOvertime = value; }
        private DirtyValue<decimal?> _log_IncomeAssetPosCashFlow;
        public decimal? Log_IncomeAssetPosCashFlow { get => _log_IncomeAssetPosCashFlow; set => _log_IncomeAssetPosCashFlow = value; }
        private DirtyValue<decimal?> _log_IncomeAssetPositiveNetRental;
        public decimal? Log_IncomeAssetPositiveNetRental { get => _log_IncomeAssetPositiveNetRental; set => _log_IncomeAssetPositiveNetRental = value; }
        private DirtyValue<string> _log_IndicatorScore;
        public string Log_IndicatorScore { get => _log_IndicatorScore; set => _log_IndicatorScore = value; }
        private DirtyValue<string> _log_IntendedUseofProperty;
        public string Log_IntendedUseofProperty { get => _log_IntendedUseofProperty; set => _log_IntendedUseofProperty = value; }
        private DirtyValue<string> _log_LCLAEvaluatedServiceConclusion1;
        public string Log_LCLAEvaluatedServiceConclusion1 { get => _log_LCLAEvaluatedServiceConclusion1; set => _log_LCLAEvaluatedServiceConclusion1 = value; }
        private DirtyValue<string> _log_LCLAEvaluatedServiceConclusion2;
        public string Log_LCLAEvaluatedServiceConclusion2 { get => _log_LCLAEvaluatedServiceConclusion2; set => _log_LCLAEvaluatedServiceConclusion2 = value; }
        private DirtyValue<string> _log_LCLAEvaluatedServiceConclusion3;
        public string Log_LCLAEvaluatedServiceConclusion3 { get => _log_LCLAEvaluatedServiceConclusion3; set => _log_LCLAEvaluatedServiceConclusion3 = value; }
        private DirtyValue<string> _log_LCLAEvaluatedServiceConclusion4;
        public string Log_LCLAEvaluatedServiceConclusion4 { get => _log_LCLAEvaluatedServiceConclusion4; set => _log_LCLAEvaluatedServiceConclusion4 = value; }
        private DirtyValue<StringEnumValue<Log_LCLAEvaluatedServiceType1>> _log_LCLAEvaluatedServiceType1;
        public StringEnumValue<Log_LCLAEvaluatedServiceType1> Log_LCLAEvaluatedServiceType1 { get => _log_LCLAEvaluatedServiceType1; set => _log_LCLAEvaluatedServiceType1 = value; }
        private DirtyValue<StringEnumValue<Log_LCLAEvaluatedServiceType2>> _log_LCLAEvaluatedServiceType2;
        public StringEnumValue<Log_LCLAEvaluatedServiceType2> Log_LCLAEvaluatedServiceType2 { get => _log_LCLAEvaluatedServiceType2; set => _log_LCLAEvaluatedServiceType2 = value; }
        private DirtyValue<StringEnumValue<Log_LCLAEvaluatedServiceType3>> _log_LCLAEvaluatedServiceType3;
        public StringEnumValue<Log_LCLAEvaluatedServiceType3> Log_LCLAEvaluatedServiceType3 { get => _log_LCLAEvaluatedServiceType3; set => _log_LCLAEvaluatedServiceType3 = value; }
        private DirtyValue<string> _log_LCLAEvaluatedServiceType4;
        public string Log_LCLAEvaluatedServiceType4 { get => _log_LCLAEvaluatedServiceType4; set => _log_LCLAEvaluatedServiceType4 = value; }
        private DirtyValue<string> _log_LenderLoan;
        public string Log_LenderLoan { get => _log_LenderLoan; set => _log_LenderLoan = value; }
        private DirtyValue<StringEnumValue<LienType>> _log_LienType;
        public StringEnumValue<LienType> Log_LienType { get => _log_LienType; set => _log_LienType = value; }
        private DirtyValue<decimal?> _log_LoanAmount;
        public decimal? Log_LoanAmount { get => _log_LoanAmount; set => _log_LoanAmount = value; }
        private DirtyValue<string> _log_LoanApplicationID;
        public string Log_LoanApplicationID { get => _log_LoanApplicationID; set => _log_LoanApplicationID = value; }
        private DirtyValue<string> _log_LoanProcessingStage;
        public string Log_LoanProcessingStage { get => _log_LoanProcessingStage; set => _log_LoanProcessingStage = value; }
        private DirtyValue<string> _log_LoanProspectorID;
        public string Log_LoanProspectorID { get => _log_LoanProspectorID; set => _log_LoanProspectorID = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _log_LoanPurpose;
        public StringEnumValue<LoanPurposeType> Log_LoanPurpose { get => _log_LoanPurpose; set => _log_LoanPurpose = value; }
        private DirtyValue<int?> _log_LoanTerm;
        public int? Log_LoanTerm { get => _log_LoanTerm; set => _log_LoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _log_LoanType;
        public StringEnumValue<LoanType> Log_LoanType { get => _log_LoanType; set => _log_LoanType = value; }
        private DirtyValue<DateTime?> _log_LPAssmtExpDate;
        public DateTime? Log_LPAssmtExpDate { get => _log_LPAssmtExpDate; set => _log_LPAssmtExpDate = value; }
        private DirtyValue<StringEnumValue<OtherPropertyType>> _log_LPPropertyType;
        public StringEnumValue<OtherPropertyType> Log_LPPropertyType { get => _log_LPPropertyType; set => _log_LPPropertyType = value; }
        private DirtyValue<string> _log_LPVersion;
        public string Log_LPVersion { get => _log_LPVersion; set => _log_LPVersion = value; }
        private DirtyValue<string> _log_LQACollateralRepWarrantyServiceConclusion;
        public string Log_LQACollateralRepWarrantyServiceConclusion { get => _log_LQACollateralRepWarrantyServiceConclusion; set => _log_LQACollateralRepWarrantyServiceConclusion = value; }
        private DirtyValue<string> _log_LQACreditRiskAssessmentConclusion;
        public string Log_LQACreditRiskAssessmentConclusion { get => _log_LQACreditRiskAssessmentConclusion; set => _log_LQACreditRiskAssessmentConclusion = value; }
        private DirtyValue<string> _log_LQADataCompareFieldConclusion;
        public string Log_LQADataCompareFieldConclusion { get => _log_LQADataCompareFieldConclusion; set => _log_LQADataCompareFieldConclusion = value; }
        private DirtyValue<string> _log_LQADataCompareFieldName;
        public string Log_LQADataCompareFieldName { get => _log_LQADataCompareFieldName; set => _log_LQADataCompareFieldName = value; }
        private DirtyValue<string> _log_LQADataCompareResult;
        public string Log_LQADataCompareResult { get => _log_LQADataCompareResult; set => _log_LQADataCompareResult = value; }
        private DirtyValue<string> _log_LQALPKey;
        public string Log_LQALPKey { get => _log_LQALPKey; set => _log_LQALPKey = value; }
        private DirtyValue<string> _log_LQAPurchaseEligibilityResult;
        public string Log_LQAPurchaseEligibilityResult { get => _log_LQAPurchaseEligibilityResult; set => _log_LQAPurchaseEligibilityResult = value; }
        private DirtyValue<string> _log_LQARiskAssessmentKey;
        public string Log_LQARiskAssessmentKey { get => _log_LQARiskAssessmentKey; set => _log_LQARiskAssessmentKey = value; }
        private DirtyValue<DateTime?> _log_LQASubmissionDateTime;
        public DateTime? Log_LQASubmissionDateTime { get => _log_LQASubmissionDateTime; set => _log_LQASubmissionDateTime = value; }
        private DirtyValue<decimal?> _log_LTV;
        public decimal? Log_LTV { get => _log_LTV; set => _log_LTV = value; }
        private DirtyValue<decimal?> _log_MaxMortgageLimit;
        public decimal? Log_MaxMortgageLimit { get => _log_MaxMortgageLimit; set => _log_MaxMortgageLimit = value; }
        private DirtyValue<string> _log_MIDecision;
        public string Log_MIDecision { get => _log_MIDecision; set => _log_MIDecision = value; }
        private DirtyValue<string> _log_MortgageType;
        public string Log_MortgageType { get => _log_MortgageType; set => _log_MortgageType = value; }
        private DirtyValue<string> _log_NegAmortizationType;
        public string Log_NegAmortizationType { get => _log_NegAmortizationType; set => _log_NegAmortizationType = value; }
        private DirtyValue<decimal?> _log_NegativeNetRental;
        public decimal? Log_NegativeNetRental { get => _log_NegativeNetRental; set => _log_NegativeNetRental = value; }
        private DirtyValue<decimal?> _log_NetCashBack;
        public decimal? Log_NetCashBack { get => _log_NetCashBack; set => _log_NetCashBack = value; }
        private DirtyValue<string> _log_NewConstruction;
        public string Log_NewConstruction { get => _log_NewConstruction; set => _log_NewConstruction = value; }
        private DirtyValue<decimal?> _log_NoteRate;
        public decimal? Log_NoteRate { get => _log_NoteRate; set => _log_NoteRate = value; }
        private DirtyValue<string> _log_NOTPNumber;
        public string Log_NOTPNumber { get => _log_NOTPNumber; set => _log_NOTPNumber = value; }
        private DirtyValue<int?> _log_NoUnits;
        public int? Log_NoUnits { get => _log_NoUnits; set => _log_NoUnits = value; }
        private DirtyValue<string> _log_NumberOfSubmissions;
        public string Log_NumberOfSubmissions { get => _log_NumberOfSubmissions; set => _log_NumberOfSubmissions = value; }
        private DirtyValue<string> _log_OccupancyStatus;
        public string Log_OccupancyStatus { get => _log_OccupancyStatus; set => _log_OccupancyStatus = value; }
        private DirtyValue<decimal?> _log_OccupantDebtRatio;
        public decimal? Log_OccupantDebtRatio { get => _log_OccupantDebtRatio; set => _log_OccupantDebtRatio = value; }
        private DirtyValue<decimal?> _log_OccupantHousingRatio;
        public decimal? Log_OccupantHousingRatio { get => _log_OccupantHousingRatio; set => _log_OccupantHousingRatio = value; }
        private DirtyValue<string> _log_OfferingIdentifier;
        public string Log_OfferingIdentifier { get => _log_OfferingIdentifier; set => _log_OfferingIdentifier = value; }
        private DirtyValue<string> _log_OriginatingCompany;
        public string Log_OriginatingCompany { get => _log_OriginatingCompany; set => _log_OriginatingCompany = value; }
        private DirtyValue<decimal?> _log_OwnerExistingMtg;
        public decimal? Log_OwnerExistingMtg { get => _log_OwnerExistingMtg; set => _log_OwnerExistingMtg = value; }
        private DirtyValue<decimal?> _log_PandI;
        public decimal? Log_PandI { get => _log_PandI; set => _log_PandI = value; }
        private DirtyValue<int?> _log_PaymentFrequency;
        public int? Log_PaymentFrequency { get => _log_PaymentFrequency; set => _log_PaymentFrequency = value; }
        private DirtyValue<string> _log_PresentAddress;
        public string Log_PresentAddress { get => _log_PresentAddress; set => _log_PresentAddress = value; }
        private DirtyValue<string> _log_PresentAddressCity;
        public string Log_PresentAddressCity { get => _log_PresentAddressCity; set => _log_PresentAddressCity = value; }
        private DirtyValue<string> _log_PresentAddressState;
        public string Log_PresentAddressState { get => _log_PresentAddressState; set => _log_PresentAddressState = value; }
        private DirtyValue<string> _log_PresentAddressZipCode;
        public string Log_PresentAddressZipCode { get => _log_PresentAddressZipCode; set => _log_PresentAddressZipCode = value; }
        private DirtyValue<decimal?> _log_PresentHousingExpense;
        public decimal? Log_PresentHousingExpense { get => _log_PresentHousingExpense; set => _log_PresentHousingExpense = value; }
        private DirtyValue<decimal?> _log_PresentPrincipalHousingPayment;
        public decimal? Log_PresentPrincipalHousingPayment { get => _log_PresentPrincipalHousingPayment; set => _log_PresentPrincipalHousingPayment = value; }
        private DirtyValue<string> _log_PropertyAddress;
        public string Log_PropertyAddress { get => _log_PropertyAddress; set => _log_PropertyAddress = value; }
        private DirtyValue<string> _log_PropertyCity;
        public string Log_PropertyCity { get => _log_PropertyCity; set => _log_PropertyCity = value; }
        private DirtyValue<string> _log_PropertyState;
        public string Log_PropertyState { get => _log_PropertyState; set => _log_PropertyState = value; }
        private DirtyValue<string> _log_PropertyZipcode;
        public string Log_PropertyZipcode { get => _log_PropertyZipcode; set => _log_PropertyZipcode = value; }
        private DirtyValue<decimal?> _log_ProposedHazardInsurance;
        public decimal? Log_ProposedHazardInsurance { get => _log_ProposedHazardInsurance; set => _log_ProposedHazardInsurance = value; }
        private DirtyValue<decimal?> _log_ProposedHOAFees;
        public decimal? Log_ProposedHOAFees { get => _log_ProposedHOAFees; set => _log_ProposedHOAFees = value; }
        private DirtyValue<decimal?> _log_ProposedHousingPITI;
        public decimal? Log_ProposedHousingPITI { get => _log_ProposedHousingPITI; set => _log_ProposedHousingPITI = value; }
        private DirtyValue<decimal?> _log_ProposedMortgageInsurance;
        public decimal? Log_ProposedMortgageInsurance { get => _log_ProposedMortgageInsurance; set => _log_ProposedMortgageInsurance = value; }
        private DirtyValue<decimal?> _log_ProposedOtherPayment;
        public decimal? Log_ProposedOtherPayment { get => _log_ProposedOtherPayment; set => _log_ProposedOtherPayment = value; }
        private DirtyValue<decimal?> _log_ProposedTaxes;
        public decimal? Log_ProposedTaxes { get => _log_ProposedTaxes; set => _log_ProposedTaxes = value; }
        private DirtyValue<decimal?> _log_ProposedTotalHousingPayment;
        public decimal? Log_ProposedTotalHousingPayment { get => _log_ProposedTotalHousingPayment; set => _log_ProposedTotalHousingPayment = value; }
        private DirtyValue<decimal?> _log_ProposedTotalMonthlyDebt;
        public decimal? Log_ProposedTotalMonthlyDebt { get => _log_ProposedTotalMonthlyDebt; set => _log_ProposedTotalMonthlyDebt = value; }
        private DirtyValue<string> _log_PurchaseEligibility;
        public string Log_PurchaseEligibility { get => _log_PurchaseEligibility; set => _log_PurchaseEligibility = value; }
        private DirtyValue<decimal?> _log_QualifyingRate;
        public decimal? Log_QualifyingRate { get => _log_QualifyingRate; set => _log_QualifyingRate = value; }
        private DirtyValue<string> _log_RecordType;
        public string Log_RecordType { get => _log_RecordType; set => _log_RecordType = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _log_RefinancePurpose;
        public StringEnumValue<RefinancePurpose> Log_RefinancePurpose { get => _log_RefinancePurpose; set => _log_RefinancePurpose = value; }
        private DirtyValue<decimal?> _log_Reserves;
        public decimal? Log_Reserves { get => _log_Reserves; set => _log_Reserves = value; }
        private DirtyValue<decimal?> _log_ReservesRequiredVerified;
        public decimal? Log_ReservesRequiredVerified { get => _log_ReservesRequiredVerified; set => _log_ReservesRequiredVerified = value; }
        private DirtyValue<string> _log_RiskClass;
        public string Log_RiskClass { get => _log_RiskClass; set => _log_RiskClass = value; }
        private DirtyValue<string> _log_SalesConcessions;
        public string Log_SalesConcessions { get => _log_SalesConcessions; set => _log_SalesConcessions = value; }
        private DirtyValue<decimal?> _log_SalesPrice;
        public decimal? Log_SalesPrice { get => _log_SalesPrice; set => _log_SalesPrice = value; }
        private DirtyValue<decimal?> _log_SecondPandI;
        public decimal? Log_SecondPandI { get => _log_SecondPandI; set => _log_SecondPandI = value; }
        private DirtyValue<string> _log_SelectedBorrower;
        public string Log_SelectedBorrower { get => _log_SelectedBorrower; set => _log_SelectedBorrower = value; }
        private DirtyValue<string> _log_SelectedRepository;
        public string Log_SelectedRepository { get => _log_SelectedRepository; set => _log_SelectedRepository = value; }
        private DirtyValue<string> _log_SellerNumber;
        public string Log_SellerNumber { get => _log_SellerNumber; set => _log_SellerNumber = value; }
        private DirtyValue<decimal?> _log_SubjNegCashFlow;
        public decimal? Log_SubjNegCashFlow { get => _log_SubjNegCashFlow; set => _log_SubjNegCashFlow = value; }
        private DirtyValue<DateTime?> _log_SubmissionDate;
        public DateTime? Log_SubmissionDate { get => _log_SubmissionDate; set => _log_SubmissionDate = value; }
        private DirtyValue<string> _log_SubmissionNumber;
        public string Log_SubmissionNumber { get => _log_SubmissionNumber; set => _log_SubmissionNumber = value; }
        private DirtyValue<string> _log_SubmissionTime;
        public string Log_SubmissionTime { get => _log_SubmissionTime; set => _log_SubmissionTime = value; }
        private DirtyValue<string> _log_SubmittedBy;
        public string Log_SubmittedBy { get => _log_SubmittedBy; set => _log_SubmittedBy = value; }
        private DirtyValue<string> _log_SubmittingCompany;
        public string Log_SubmittingCompany { get => _log_SubmittingCompany; set => _log_SubmittingCompany = value; }
        private DirtyValue<string> _log_TemporarySubsidyBuydown;
        public string Log_TemporarySubsidyBuydown { get => _log_TemporarySubsidyBuydown; set => _log_TemporarySubsidyBuydown = value; }
        private DirtyValue<decimal?> _log_TLTV;
        public decimal? Log_TLTV { get => _log_TLTV; set => _log_TLTV = value; }
        private DirtyValue<decimal?> _log_TotalAsset;
        public decimal? Log_TotalAsset { get => _log_TotalAsset; set => _log_TotalAsset = value; }
        private DirtyValue<decimal?> _log_TotalExpense;
        public decimal? Log_TotalExpense { get => _log_TotalExpense; set => _log_TotalExpense = value; }
        private DirtyValue<decimal?> _log_TotalExpensePmt;
        public decimal? Log_TotalExpensePmt { get => _log_TotalExpensePmt; set => _log_TotalExpensePmt = value; }
        private DirtyValue<decimal?> _log_TotalExpenseRatio;
        public decimal? Log_TotalExpenseRatio { get => _log_TotalExpenseRatio; set => _log_TotalExpenseRatio = value; }
        private DirtyValue<decimal?> _log_TotalFundsVerified;
        public decimal? Log_TotalFundsVerified { get => _log_TotalFundsVerified; set => _log_TotalFundsVerified = value; }
        private DirtyValue<decimal?> _log_TotalLoanAmount;
        public decimal? Log_TotalLoanAmount { get => _log_TotalLoanAmount; set => _log_TotalLoanAmount = value; }
        private DirtyValue<decimal?> _log_TotalMonthlyIncome;
        public decimal? Log_TotalMonthlyIncome { get => _log_TotalMonthlyIncome; set => _log_TotalMonthlyIncome = value; }
        private DirtyValue<string> _log_TPONumber;
        public string Log_TPONumber { get => _log_TPONumber; set => _log_TPONumber = value; }
        private DirtyValue<string> _log_TransactionID;
        public string Log_TransactionID { get => _log_TransactionID; set => _log_TransactionID = value; }
        private DirtyValue<string> _log_UnderwritingRiskAssessOther;
        public string Log_UnderwritingRiskAssessOther { get => _log_UnderwritingRiskAssessOther; set => _log_UnderwritingRiskAssessOther = value; }
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _log_UnderwritingRiskAssessType;
        public StringEnumValue<RiskAssessmentType> Log_UnderwritingRiskAssessType { get => _log_UnderwritingRiskAssessType; set => _log_UnderwritingRiskAssessType = value; }
        private DirtyValue<string> _log_WithUndisclosedDebt;
        public string Log_WithUndisclosedDebt { get => _log_WithUndisclosedDebt; set => _log_WithUndisclosedDebt = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aUSTrackingLogIndex.Dirty
                    || _batchDocumentRefId.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _isHistory.Dirty
                    || _log_AcceptPlusEligible.Dirty
                    || _log_AffordableProductType.Dirty
                    || _log_AllOtherPayments.Dirty
                    || _log_AmortizationMonths.Dirty
                    || _log_AmortizationType.Dirty
                    || _log_AmtSubordinateFin.Dirty
                    || _log_AppraisalTypeMAF.Dirty
                    || _log_AppraisedValue.Dirty
                    || _log_ARMQualifyingRate.Dirty
                    || _log_AssessmentType.Dirty
                    || _log_AUSRecommendation.Dirty
                    || _log_AUSStatus.Dirty
                    || _log_AUSTrackingType.Dirty
                    || _log_AUSTransactionID.Dirty
                    || _log_AUSVersion.Dirty
                    || _log_Balloon.Dirty
                    || _log_BalloonTerm.Dirty
                    || _log_BorrowerAssetAmount.Dirty
                    || _log_BorrowerAssetName.Dirty
                    || _log_BorrowerAssetType.Dirty
                    || _log_BorrowerCreditScore1.Dirty
                    || _log_BorrowerCreditScore2.Dirty
                    || _log_BorrowerCreditScore3.Dirty
                    || _log_BorrowerEquifaxBEACON.Dirty
                    || _log_BorrowerExperianFICO.Dirty
                    || _log_BorrowerIncomeAmount.Dirty
                    || _log_BorrowerIncomeName.Dirty
                    || _log_BorrowerIncomeType.Dirty
                    || _log_BorrowerInstitutionName.Dirty
                    || _log_BorrowerName.Dirty
                    || _log_BorrowerScoreName.Dirty
                    || _log_BorrowerTransUnionEmpirica.Dirty
                    || _log_BorrowerType1.Dirty
                    || _log_BorrowerType2.Dirty
                    || _log_BoughtDownRate.Dirty
                    || _log_Buydown.Dirty
                    || _log_CashBack.Dirty
                    || _log_CashOutAmount.Dirty
                    || _log_CLTV.Dirty
                    || _log_CoBorrowerAssetAmount.Dirty
                    || _log_CoBorrowerAssetName.Dirty
                    || _log_CoBorrowerAssetType.Dirty
                    || _log_CoBorrowerCreditScore1.Dirty
                    || _log_CoBorrowerCreditScore2.Dirty
                    || _log_CoBorrowerCreditScore3.Dirty
                    || _log_CoBorrowerEquifaxBEACON.Dirty
                    || _log_CoBorrowerExperianFICO.Dirty
                    || _log_CoBorrowerIncomeAmount.Dirty
                    || _log_CoBorrowerIncomeName.Dirty
                    || _log_CoBorrowerIncomeType.Dirty
                    || _log_CoBorrowerInstitutionName.Dirty
                    || _log_CoborrowerName.Dirty
                    || _log_CoBorrowerScoreName.Dirty
                    || _log_CoBorrowerTransUnionEmpirica.Dirty
                    || _log_Code1.Dirty
                    || _log_Code2.Dirty
                    || _log_CodeDescription1.Dirty
                    || _log_CodeDescription2.Dirty
                    || _log_CommunityLending.Dirty
                    || _log_CreatedOn.Dirty
                    || _log_CreditAgency1.Dirty
                    || _log_CreditAgency2.Dirty
                    || _log_CreditReportDate1.Dirty
                    || _log_CreditReportDate2.Dirty
                    || _log_CreditReportID1.Dirty
                    || _log_CreditReportID2.Dirty
                    || _log_CuredAmortizationType.Dirty
                    || _log_CuredAppraisedValue.Dirty
                    || _log_CuredCLTV.Dirty
                    || _log_CuredHousingExpenseRatio.Dirty
                    || _log_CuredLoanPurpose.Dirty
                    || _log_CuredLoanTerm.Dirty
                    || _log_CuredLoanType.Dirty
                    || _log_CuredLTV.Dirty
                    || _log_CuredNoteRate.Dirty
                    || _log_CuredProposedTotalHousingPayment.Dirty
                    || _log_CuredRefinancePurpose.Dirty
                    || _log_CuredTotalExpenseRatio.Dirty
                    || _log_CuredTotalLoanAmount.Dirty
                    || _log_CuredTotalMonthlyIncome.Dirty
                    || _log_DateTimeAssessed.Dirty
                    || _log_DateTimeRequested.Dirty
                    || _log_DebtRatio.Dirty
                    || _log_DocumentationLevel.Dirty
                    || _log_DUCaseIDorLPAUSKey.Dirty
                    || _log_DUPropertyType.Dirty
                    || _log_eFolderGUID.Dirty
                    || _log_ExcessAvailableAssetsNoVerified.Dirty
                    || _log_FinancedMIAmount.Dirty
                    || _log_FirstPandI.Dirty
                    || _log_FirstSubmissionDate.Dirty
                    || _log_FirstSubmissionTime.Dirty
                    || _log_FreddieDocClass.Dirty
                    || _log_FundsRequiredClose.Dirty
                    || _log_GUID.Dirty
                    || _log_HLCTV.Dirty
                    || _log_HousingExpense.Dirty
                    || _log_HousingExpenseRatio.Dirty
                    || _log_HousingRatio.Dirty
                    || _log_HTLTV.Dirty
                    || _log_IncludingLess10Mos.Dirty
                    || _log_IncomeAssetBase.Dirty
                    || _log_IncomeAssetBonus.Dirty
                    || _log_IncomeAssetCommission.Dirty
                    || _log_IncomeAssetOther.Dirty
                    || _log_IncomeAssetOvertime.Dirty
                    || _log_IncomeAssetPosCashFlow.Dirty
                    || _log_IncomeAssetPositiveNetRental.Dirty
                    || _log_IndicatorScore.Dirty
                    || _log_IntendedUseofProperty.Dirty
                    || _log_LCLAEvaluatedServiceConclusion1.Dirty
                    || _log_LCLAEvaluatedServiceConclusion2.Dirty
                    || _log_LCLAEvaluatedServiceConclusion3.Dirty
                    || _log_LCLAEvaluatedServiceConclusion4.Dirty
                    || _log_LCLAEvaluatedServiceType1.Dirty
                    || _log_LCLAEvaluatedServiceType2.Dirty
                    || _log_LCLAEvaluatedServiceType3.Dirty
                    || _log_LCLAEvaluatedServiceType4.Dirty
                    || _log_LenderLoan.Dirty
                    || _log_LienType.Dirty
                    || _log_LoanAmount.Dirty
                    || _log_LoanApplicationID.Dirty
                    || _log_LoanProcessingStage.Dirty
                    || _log_LoanProspectorID.Dirty
                    || _log_LoanPurpose.Dirty
                    || _log_LoanTerm.Dirty
                    || _log_LoanType.Dirty
                    || _log_LPAssmtExpDate.Dirty
                    || _log_LPPropertyType.Dirty
                    || _log_LPVersion.Dirty
                    || _log_LQACollateralRepWarrantyServiceConclusion.Dirty
                    || _log_LQACreditRiskAssessmentConclusion.Dirty
                    || _log_LQADataCompareFieldConclusion.Dirty
                    || _log_LQADataCompareFieldName.Dirty
                    || _log_LQADataCompareResult.Dirty
                    || _log_LQALPKey.Dirty
                    || _log_LQAPurchaseEligibilityResult.Dirty
                    || _log_LQARiskAssessmentKey.Dirty
                    || _log_LQASubmissionDateTime.Dirty
                    || _log_LTV.Dirty
                    || _log_MaxMortgageLimit.Dirty
                    || _log_MIDecision.Dirty
                    || _log_MortgageType.Dirty
                    || _log_NegAmortizationType.Dirty
                    || _log_NegativeNetRental.Dirty
                    || _log_NetCashBack.Dirty
                    || _log_NewConstruction.Dirty
                    || _log_NoteRate.Dirty
                    || _log_NOTPNumber.Dirty
                    || _log_NoUnits.Dirty
                    || _log_NumberOfSubmissions.Dirty
                    || _log_OccupancyStatus.Dirty
                    || _log_OccupantDebtRatio.Dirty
                    || _log_OccupantHousingRatio.Dirty
                    || _log_OfferingIdentifier.Dirty
                    || _log_OriginatingCompany.Dirty
                    || _log_OwnerExistingMtg.Dirty
                    || _log_PandI.Dirty
                    || _log_PaymentFrequency.Dirty
                    || _log_PresentAddress.Dirty
                    || _log_PresentAddressCity.Dirty
                    || _log_PresentAddressState.Dirty
                    || _log_PresentAddressZipCode.Dirty
                    || _log_PresentHousingExpense.Dirty
                    || _log_PresentPrincipalHousingPayment.Dirty
                    || _log_PropertyAddress.Dirty
                    || _log_PropertyCity.Dirty
                    || _log_PropertyState.Dirty
                    || _log_PropertyZipcode.Dirty
                    || _log_ProposedHazardInsurance.Dirty
                    || _log_ProposedHOAFees.Dirty
                    || _log_ProposedHousingPITI.Dirty
                    || _log_ProposedMortgageInsurance.Dirty
                    || _log_ProposedOtherPayment.Dirty
                    || _log_ProposedTaxes.Dirty
                    || _log_ProposedTotalHousingPayment.Dirty
                    || _log_ProposedTotalMonthlyDebt.Dirty
                    || _log_PurchaseEligibility.Dirty
                    || _log_QualifyingRate.Dirty
                    || _log_RecordType.Dirty
                    || _log_RefinancePurpose.Dirty
                    || _log_Reserves.Dirty
                    || _log_ReservesRequiredVerified.Dirty
                    || _log_RiskClass.Dirty
                    || _log_SalesConcessions.Dirty
                    || _log_SalesPrice.Dirty
                    || _log_SecondPandI.Dirty
                    || _log_SelectedBorrower.Dirty
                    || _log_SelectedRepository.Dirty
                    || _log_SellerNumber.Dirty
                    || _log_SubjNegCashFlow.Dirty
                    || _log_SubmissionDate.Dirty
                    || _log_SubmissionNumber.Dirty
                    || _log_SubmissionTime.Dirty
                    || _log_SubmittedBy.Dirty
                    || _log_SubmittingCompany.Dirty
                    || _log_TemporarySubsidyBuydown.Dirty
                    || _log_TLTV.Dirty
                    || _log_TotalAsset.Dirty
                    || _log_TotalExpense.Dirty
                    || _log_TotalExpensePmt.Dirty
                    || _log_TotalExpenseRatio.Dirty
                    || _log_TotalFundsVerified.Dirty
                    || _log_TotalLoanAmount.Dirty
                    || _log_TotalMonthlyIncome.Dirty
                    || _log_TPONumber.Dirty
                    || _log_TransactionID.Dirty
                    || _log_UnderwritingRiskAssessOther.Dirty
                    || _log_UnderwritingRiskAssessType.Dirty
                    || _log_WithUndisclosedDebt.Dirty;
            }
            set
            {
                _aUSTrackingLogIndex.Dirty = value;
                _batchDocumentRefId.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _isHistory.Dirty = value;
                _log_AcceptPlusEligible.Dirty = value;
                _log_AffordableProductType.Dirty = value;
                _log_AllOtherPayments.Dirty = value;
                _log_AmortizationMonths.Dirty = value;
                _log_AmortizationType.Dirty = value;
                _log_AmtSubordinateFin.Dirty = value;
                _log_AppraisalTypeMAF.Dirty = value;
                _log_AppraisedValue.Dirty = value;
                _log_ARMQualifyingRate.Dirty = value;
                _log_AssessmentType.Dirty = value;
                _log_AUSRecommendation.Dirty = value;
                _log_AUSStatus.Dirty = value;
                _log_AUSTrackingType.Dirty = value;
                _log_AUSTransactionID.Dirty = value;
                _log_AUSVersion.Dirty = value;
                _log_Balloon.Dirty = value;
                _log_BalloonTerm.Dirty = value;
                _log_BorrowerAssetAmount.Dirty = value;
                _log_BorrowerAssetName.Dirty = value;
                _log_BorrowerAssetType.Dirty = value;
                _log_BorrowerCreditScore1.Dirty = value;
                _log_BorrowerCreditScore2.Dirty = value;
                _log_BorrowerCreditScore3.Dirty = value;
                _log_BorrowerEquifaxBEACON.Dirty = value;
                _log_BorrowerExperianFICO.Dirty = value;
                _log_BorrowerIncomeAmount.Dirty = value;
                _log_BorrowerIncomeName.Dirty = value;
                _log_BorrowerIncomeType.Dirty = value;
                _log_BorrowerInstitutionName.Dirty = value;
                _log_BorrowerName.Dirty = value;
                _log_BorrowerScoreName.Dirty = value;
                _log_BorrowerTransUnionEmpirica.Dirty = value;
                _log_BorrowerType1.Dirty = value;
                _log_BorrowerType2.Dirty = value;
                _log_BoughtDownRate.Dirty = value;
                _log_Buydown.Dirty = value;
                _log_CashBack.Dirty = value;
                _log_CashOutAmount.Dirty = value;
                _log_CLTV.Dirty = value;
                _log_CoBorrowerAssetAmount.Dirty = value;
                _log_CoBorrowerAssetName.Dirty = value;
                _log_CoBorrowerAssetType.Dirty = value;
                _log_CoBorrowerCreditScore1.Dirty = value;
                _log_CoBorrowerCreditScore2.Dirty = value;
                _log_CoBorrowerCreditScore3.Dirty = value;
                _log_CoBorrowerEquifaxBEACON.Dirty = value;
                _log_CoBorrowerExperianFICO.Dirty = value;
                _log_CoBorrowerIncomeAmount.Dirty = value;
                _log_CoBorrowerIncomeName.Dirty = value;
                _log_CoBorrowerIncomeType.Dirty = value;
                _log_CoBorrowerInstitutionName.Dirty = value;
                _log_CoborrowerName.Dirty = value;
                _log_CoBorrowerScoreName.Dirty = value;
                _log_CoBorrowerTransUnionEmpirica.Dirty = value;
                _log_Code1.Dirty = value;
                _log_Code2.Dirty = value;
                _log_CodeDescription1.Dirty = value;
                _log_CodeDescription2.Dirty = value;
                _log_CommunityLending.Dirty = value;
                _log_CreatedOn.Dirty = value;
                _log_CreditAgency1.Dirty = value;
                _log_CreditAgency2.Dirty = value;
                _log_CreditReportDate1.Dirty = value;
                _log_CreditReportDate2.Dirty = value;
                _log_CreditReportID1.Dirty = value;
                _log_CreditReportID2.Dirty = value;
                _log_CuredAmortizationType.Dirty = value;
                _log_CuredAppraisedValue.Dirty = value;
                _log_CuredCLTV.Dirty = value;
                _log_CuredHousingExpenseRatio.Dirty = value;
                _log_CuredLoanPurpose.Dirty = value;
                _log_CuredLoanTerm.Dirty = value;
                _log_CuredLoanType.Dirty = value;
                _log_CuredLTV.Dirty = value;
                _log_CuredNoteRate.Dirty = value;
                _log_CuredProposedTotalHousingPayment.Dirty = value;
                _log_CuredRefinancePurpose.Dirty = value;
                _log_CuredTotalExpenseRatio.Dirty = value;
                _log_CuredTotalLoanAmount.Dirty = value;
                _log_CuredTotalMonthlyIncome.Dirty = value;
                _log_DateTimeAssessed.Dirty = value;
                _log_DateTimeRequested.Dirty = value;
                _log_DebtRatio.Dirty = value;
                _log_DocumentationLevel.Dirty = value;
                _log_DUCaseIDorLPAUSKey.Dirty = value;
                _log_DUPropertyType.Dirty = value;
                _log_eFolderGUID.Dirty = value;
                _log_ExcessAvailableAssetsNoVerified.Dirty = value;
                _log_FinancedMIAmount.Dirty = value;
                _log_FirstPandI.Dirty = value;
                _log_FirstSubmissionDate.Dirty = value;
                _log_FirstSubmissionTime.Dirty = value;
                _log_FreddieDocClass.Dirty = value;
                _log_FundsRequiredClose.Dirty = value;
                _log_GUID.Dirty = value;
                _log_HLCTV.Dirty = value;
                _log_HousingExpense.Dirty = value;
                _log_HousingExpenseRatio.Dirty = value;
                _log_HousingRatio.Dirty = value;
                _log_HTLTV.Dirty = value;
                _log_IncludingLess10Mos.Dirty = value;
                _log_IncomeAssetBase.Dirty = value;
                _log_IncomeAssetBonus.Dirty = value;
                _log_IncomeAssetCommission.Dirty = value;
                _log_IncomeAssetOther.Dirty = value;
                _log_IncomeAssetOvertime.Dirty = value;
                _log_IncomeAssetPosCashFlow.Dirty = value;
                _log_IncomeAssetPositiveNetRental.Dirty = value;
                _log_IndicatorScore.Dirty = value;
                _log_IntendedUseofProperty.Dirty = value;
                _log_LCLAEvaluatedServiceConclusion1.Dirty = value;
                _log_LCLAEvaluatedServiceConclusion2.Dirty = value;
                _log_LCLAEvaluatedServiceConclusion3.Dirty = value;
                _log_LCLAEvaluatedServiceConclusion4.Dirty = value;
                _log_LCLAEvaluatedServiceType1.Dirty = value;
                _log_LCLAEvaluatedServiceType2.Dirty = value;
                _log_LCLAEvaluatedServiceType3.Dirty = value;
                _log_LCLAEvaluatedServiceType4.Dirty = value;
                _log_LenderLoan.Dirty = value;
                _log_LienType.Dirty = value;
                _log_LoanAmount.Dirty = value;
                _log_LoanApplicationID.Dirty = value;
                _log_LoanProcessingStage.Dirty = value;
                _log_LoanProspectorID.Dirty = value;
                _log_LoanPurpose.Dirty = value;
                _log_LoanTerm.Dirty = value;
                _log_LoanType.Dirty = value;
                _log_LPAssmtExpDate.Dirty = value;
                _log_LPPropertyType.Dirty = value;
                _log_LPVersion.Dirty = value;
                _log_LQACollateralRepWarrantyServiceConclusion.Dirty = value;
                _log_LQACreditRiskAssessmentConclusion.Dirty = value;
                _log_LQADataCompareFieldConclusion.Dirty = value;
                _log_LQADataCompareFieldName.Dirty = value;
                _log_LQADataCompareResult.Dirty = value;
                _log_LQALPKey.Dirty = value;
                _log_LQAPurchaseEligibilityResult.Dirty = value;
                _log_LQARiskAssessmentKey.Dirty = value;
                _log_LQASubmissionDateTime.Dirty = value;
                _log_LTV.Dirty = value;
                _log_MaxMortgageLimit.Dirty = value;
                _log_MIDecision.Dirty = value;
                _log_MortgageType.Dirty = value;
                _log_NegAmortizationType.Dirty = value;
                _log_NegativeNetRental.Dirty = value;
                _log_NetCashBack.Dirty = value;
                _log_NewConstruction.Dirty = value;
                _log_NoteRate.Dirty = value;
                _log_NOTPNumber.Dirty = value;
                _log_NoUnits.Dirty = value;
                _log_NumberOfSubmissions.Dirty = value;
                _log_OccupancyStatus.Dirty = value;
                _log_OccupantDebtRatio.Dirty = value;
                _log_OccupantHousingRatio.Dirty = value;
                _log_OfferingIdentifier.Dirty = value;
                _log_OriginatingCompany.Dirty = value;
                _log_OwnerExistingMtg.Dirty = value;
                _log_PandI.Dirty = value;
                _log_PaymentFrequency.Dirty = value;
                _log_PresentAddress.Dirty = value;
                _log_PresentAddressCity.Dirty = value;
                _log_PresentAddressState.Dirty = value;
                _log_PresentAddressZipCode.Dirty = value;
                _log_PresentHousingExpense.Dirty = value;
                _log_PresentPrincipalHousingPayment.Dirty = value;
                _log_PropertyAddress.Dirty = value;
                _log_PropertyCity.Dirty = value;
                _log_PropertyState.Dirty = value;
                _log_PropertyZipcode.Dirty = value;
                _log_ProposedHazardInsurance.Dirty = value;
                _log_ProposedHOAFees.Dirty = value;
                _log_ProposedHousingPITI.Dirty = value;
                _log_ProposedMortgageInsurance.Dirty = value;
                _log_ProposedOtherPayment.Dirty = value;
                _log_ProposedTaxes.Dirty = value;
                _log_ProposedTotalHousingPayment.Dirty = value;
                _log_ProposedTotalMonthlyDebt.Dirty = value;
                _log_PurchaseEligibility.Dirty = value;
                _log_QualifyingRate.Dirty = value;
                _log_RecordType.Dirty = value;
                _log_RefinancePurpose.Dirty = value;
                _log_Reserves.Dirty = value;
                _log_ReservesRequiredVerified.Dirty = value;
                _log_RiskClass.Dirty = value;
                _log_SalesConcessions.Dirty = value;
                _log_SalesPrice.Dirty = value;
                _log_SecondPandI.Dirty = value;
                _log_SelectedBorrower.Dirty = value;
                _log_SelectedRepository.Dirty = value;
                _log_SellerNumber.Dirty = value;
                _log_SubjNegCashFlow.Dirty = value;
                _log_SubmissionDate.Dirty = value;
                _log_SubmissionNumber.Dirty = value;
                _log_SubmissionTime.Dirty = value;
                _log_SubmittedBy.Dirty = value;
                _log_SubmittingCompany.Dirty = value;
                _log_TemporarySubsidyBuydown.Dirty = value;
                _log_TLTV.Dirty = value;
                _log_TotalAsset.Dirty = value;
                _log_TotalExpense.Dirty = value;
                _log_TotalExpensePmt.Dirty = value;
                _log_TotalExpenseRatio.Dirty = value;
                _log_TotalFundsVerified.Dirty = value;
                _log_TotalLoanAmount.Dirty = value;
                _log_TotalMonthlyIncome.Dirty = value;
                _log_TPONumber.Dirty = value;
                _log_TransactionID.Dirty = value;
                _log_UnderwritingRiskAssessOther.Dirty = value;
                _log_UnderwritingRiskAssessType.Dirty = value;
                _log_WithUndisclosedDebt.Dirty = value;
            }
        }
    }
}