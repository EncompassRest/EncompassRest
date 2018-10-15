using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AUSTrackingLog
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class AUSTrackingLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _aUSTrackingLogIndex;
        private DirtyValue<string> _batchDocumentRefId;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isEmpty;
        private DirtyValue<bool?> _isHistory;
        private DirtyValue<string> _logAcceptPlusEligible;
        private DirtyValue<string> _logAffordableProductType;
        private DirtyValue<decimal?> _logAllOtherPayments;
        private DirtyValue<int?> _logAmortizationMonths;
        private DirtyValue<StringEnumValue<AmortizationType>> _logAmortizationType;
        private DirtyValue<decimal?> _logAmtSubordinateFin;
        private DirtyValue<string> _logAppraisalTypeMAF;
        private DirtyValue<int?> _logAppraisedValue;
        private DirtyValue<decimal?> _logARMQualifyingRate;
        private DirtyValue<string> _logAssessmentType;
        private DirtyValue<string> _logAUSRecommendation;
        private DirtyValue<string> _logAUSStatus;
        private DirtyValue<StringEnumValue<LogAUSTrackingType>> _logAUSTrackingType;
        private DirtyValue<string> _logAUSTransactionID;
        private DirtyValue<string> _logAUSVersion;
        private DirtyValue<string> _logBalloon;
        private DirtyValue<int?> _logBalloonTerm;
        private DirtyValue<decimal?> _logBorrowerAssetAmount;
        private DirtyValue<string> _logBorrowerAssetName;
        private DirtyValue<string> _logBorrowerAssetType;
        private DirtyValue<string> _logBorrowerCreditScore1;
        private DirtyValue<string> _logBorrowerCreditScore2;
        private DirtyValue<string> _logBorrowerCreditScore3;
        private DirtyValue<string> _logBorrowerEquifaxBEACON;
        private DirtyValue<string> _logBorrowerExperianFICO;
        private DirtyValue<decimal?> _logBorrowerIncomeAmount;
        private DirtyValue<string> _logBorrowerIncomeName;
        private DirtyValue<string> _logBorrowerIncomeType;
        private DirtyValue<string> _logBorrowerInstitutionName;
        private DirtyValue<string> _logBorrowerName;
        private DirtyValue<string> _logBorrowerScoreName;
        private DirtyValue<string> _logBorrowerTransUnionEmpirica;
        private DirtyValue<string> _logBorrowerType1;
        private DirtyValue<string> _logBorrowerType2;
        private DirtyValue<decimal?> _logBoughtDownRate;
        private DirtyValue<string> _logBuydown;
        private DirtyValue<decimal?> _logCashBack;
        private DirtyValue<decimal?> _logCashOutAmount;
        private DirtyValue<decimal?> _logCLTV;
        private DirtyValue<decimal?> _logCoBorrowerAssetAmount;
        private DirtyValue<string> _logCoBorrowerAssetName;
        private DirtyValue<string> _logCoBorrowerAssetType;
        private DirtyValue<string> _logCoBorrowerCreditScore1;
        private DirtyValue<string> _logCoBorrowerCreditScore2;
        private DirtyValue<string> _logCoBorrowerCreditScore3;
        private DirtyValue<string> _logCoBorrowerEquifaxBEACON;
        private DirtyValue<string> _logCoBorrowerExperianFICO;
        private DirtyValue<decimal?> _logCoBorrowerIncomeAmount;
        private DirtyValue<string> _logCoBorrowerIncomeName;
        private DirtyValue<string> _logCoBorrowerIncomeType;
        private DirtyValue<string> _logCoBorrowerInstitutionName;
        private DirtyValue<string> _logCoborrowerName;
        private DirtyValue<string> _logCoBorrowerScoreName;
        private DirtyValue<string> _logCoBorrowerTransUnionEmpirica;
        private DirtyValue<string> _logCode1;
        private DirtyValue<string> _logCode2;
        private DirtyValue<string> _logCodeDescription1;
        private DirtyValue<string> _logCodeDescription2;
        private DirtyValue<string> _logCommunityLending;
        private DirtyValue<DateTime?> _logCreatedOn;
        private DirtyValue<string> _logCreditAgency1;
        private DirtyValue<string> _logCreditAgency2;
        private DirtyValue<DateTime?> _logCreditReportDate1;
        private DirtyValue<DateTime?> _logCreditReportDate2;
        private DirtyValue<string> _logCreditReportID1;
        private DirtyValue<string> _logCreditReportID2;
        private DirtyValue<StringEnumValue<AmortizationType>> _logCuredAmortizationType;
        private DirtyValue<int?> _logCuredAppraisedValue;
        private DirtyValue<decimal?> _logCuredCLTV;
        private DirtyValue<decimal?> _logCuredHousingExpenseRatio;
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logCuredLoanPurpose;
        private DirtyValue<int?> _logCuredLoanTerm;
        private DirtyValue<StringEnumValue<LoanType>> _logCuredLoanType;
        private DirtyValue<decimal?> _logCuredLTV;
        private DirtyValue<decimal?> _logCuredNoteRate;
        private DirtyValue<decimal?> _logCuredProposedTotalHousingPayment;
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logCuredRefinancePurpose;
        private DirtyValue<decimal?> _logCuredTotalExpenseRatio;
        private DirtyValue<decimal?> _logCuredTotalLoanAmount;
        private DirtyValue<decimal?> _logCuredTotalMonthlyIncome;
        private DirtyValue<string> _logDateTimeAssessed;
        private DirtyValue<string> _logDateTimeRequested;
        private DirtyValue<decimal?> _logDebtRatio;
        private DirtyValue<string> _logDocumentationLevel;
        private DirtyValue<string> _logDUCaseIDorLPAUSKey;
        private DirtyValue<StringEnumValue<PropertyType>> _logDUPropertyType;
        private DirtyValue<string> _logeFolderGUID;
        private DirtyValue<decimal?> _logExcessAvailableAssetsNoVerified;
        private DirtyValue<decimal?> _logFinancedMIAmount;
        private DirtyValue<decimal?> _logFirstPandI;
        private DirtyValue<DateTime?> _logFirstSubmissionDate;
        private DirtyValue<string> _logFirstSubmissionTime;
        private DirtyValue<string> _logFreddieDocClass;
        private DirtyValue<decimal?> _logFundsRequiredClose;
        private DirtyValue<string> _logGUID;
        private DirtyValue<decimal?> _logHLCTV;
        private DirtyValue<decimal?> _logHousingExpense;
        private DirtyValue<decimal?> _logHousingExpenseRatio;
        private DirtyValue<decimal?> _logHousingRatio;
        private DirtyValue<decimal?> _logHTLTV;
        private DirtyValue<string> _logIncludingLess10Mos;
        private DirtyValue<decimal?> _logIncomeAssetBase;
        private DirtyValue<decimal?> _logIncomeAssetBonus;
        private DirtyValue<decimal?> _logIncomeAssetCommission;
        private DirtyValue<decimal?> _logIncomeAssetOther;
        private DirtyValue<decimal?> _logIncomeAssetOvertime;
        private DirtyValue<decimal?> _logIncomeAssetPosCashFlow;
        private DirtyValue<decimal?> _logIncomeAssetPositiveNetRental;
        private DirtyValue<string> _logIndicatorScore;
        private DirtyValue<string> _logIntendedUseofProperty;
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion1;
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion2;
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion3;
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion4;
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType1>> _logLCLAEvaluatedServiceType1;
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType2>> _logLCLAEvaluatedServiceType2;
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType3>> _logLCLAEvaluatedServiceType3;
        private DirtyValue<string> _logLCLAEvaluatedServiceType4;
        private DirtyValue<string> _logLenderLoan;
        private DirtyValue<StringEnumValue<LienType>> _logLienType;
        private DirtyValue<decimal?> _logLoanAmount;
        private DirtyValue<string> _logLoanApplicationID;
        private DirtyValue<string> _logLoanProcessingStage;
        private DirtyValue<string> _logLoanProspectorID;
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logLoanPurpose;
        private DirtyValue<int?> _logLoanTerm;
        private DirtyValue<StringEnumValue<LoanType>> _logLoanType;
        private DirtyValue<DateTime?> _logLPAssmtExpDate;
        private DirtyValue<StringEnumValue<OtherPropertyType>> _logLPPropertyType;
        private DirtyValue<string> _logLPVersion;
        private DirtyValue<string> _logLQACollateralRepWarrantyServiceConclusion;
        private DirtyValue<string> _logLQACreditRiskAssessmentConclusion;
        private DirtyValue<string> _logLQADataCompareFieldConclusion;
        private DirtyValue<string> _logLQADataCompareFieldName;
        private DirtyValue<string> _logLQADataCompareResult;
        private DirtyValue<string> _logLQALPKey;
        private DirtyValue<string> _logLQAPurchaseEligibilityResult;
        private DirtyValue<string> _logLQARiskAssessmentKey;
        private DirtyValue<DateTime?> _logLQASubmissionDateTime;
        private DirtyValue<decimal?> _logLTV;
        private DirtyValue<decimal?> _logMaxMortgageLimit;
        private DirtyValue<string> _logMIDecision;
        private DirtyValue<string> _logMortgageType;
        private DirtyValue<string> _logNegAmortizationType;
        private DirtyValue<decimal?> _logNegativeNetRental;
        private DirtyValue<decimal?> _logNetCashBack;
        private DirtyValue<string> _logNewConstruction;
        private DirtyValue<decimal?> _logNoteRate;
        private DirtyValue<string> _logNOTPNumber;
        private DirtyValue<int?> _logNoUnits;
        private DirtyValue<string> _logNumberOfSubmissions;
        private DirtyValue<string> _logOccupancyStatus;
        private DirtyValue<decimal?> _logOccupantDebtRatio;
        private DirtyValue<decimal?> _logOccupantHousingRatio;
        private DirtyValue<string> _logOfferingIdentifier;
        private DirtyValue<string> _logOriginatingCompany;
        private DirtyValue<decimal?> _logOwnerExistingMtg;
        private DirtyValue<decimal?> _logPandI;
        private DirtyValue<int?> _logPaymentFrequency;
        private DirtyValue<string> _logPresentAddress;
        private DirtyValue<string> _logPresentAddressCity;
        private DirtyValue<StringEnumValue<State>> _logPresentAddressState;
        private DirtyValue<string> _logPresentAddressZipCode;
        private DirtyValue<decimal?> _logPresentHousingExpense;
        private DirtyValue<decimal?> _logPresentPrincipalHousingPayment;
        private DirtyValue<string> _logPropertyAddress;
        private DirtyValue<string> _logPropertyCity;
        private DirtyValue<StringEnumValue<State>> _logPropertyState;
        private DirtyValue<string> _logPropertyZipcode;
        private DirtyValue<decimal?> _logProposedHazardInsurance;
        private DirtyValue<decimal?> _logProposedHOAFees;
        private DirtyValue<decimal?> _logProposedHousingPITI;
        private DirtyValue<decimal?> _logProposedMortgageInsurance;
        private DirtyValue<decimal?> _logProposedOtherPayment;
        private DirtyValue<decimal?> _logProposedTaxes;
        private DirtyValue<decimal?> _logProposedTotalHousingPayment;
        private DirtyValue<decimal?> _logProposedTotalMonthlyDebt;
        private DirtyValue<string> _logPurchaseEligibility;
        private DirtyValue<decimal?> _logQualifyingRate;
        private DirtyValue<string> _logRecordType;
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logRefinancePurpose;
        private DirtyValue<decimal?> _logReserves;
        private DirtyValue<decimal?> _logReservesRequiredVerified;
        private DirtyValue<string> _logRiskClass;
        private DirtyValue<string> _logSalesConcessions;
        private DirtyValue<decimal?> _logSalesPrice;
        private DirtyValue<decimal?> _logSecondPandI;
        private DirtyValue<string> _logSelectedBorrower;
        private DirtyValue<string> _logSelectedRepository;
        private DirtyValue<string> _logSellerNumber;
        private DirtyValue<decimal?> _logSubjNegCashFlow;
        private DirtyValue<DateTime?> _logSubmissionDate;
        private DirtyValue<string> _logSubmissionNumber;
        private DirtyValue<string> _logSubmissionTime;
        private DirtyValue<string> _logSubmittedBy;
        private DirtyValue<string> _logSubmittingCompany;
        private DirtyValue<string> _logTemporarySubsidyBuydown;
        private DirtyValue<decimal?> _logTLTV;
        private DirtyValue<decimal?> _logTotalAsset;
        private DirtyValue<decimal?> _logTotalExpense;
        private DirtyValue<decimal?> _logTotalExpensePmt;
        private DirtyValue<decimal?> _logTotalExpenseRatio;
        private DirtyValue<decimal?> _logTotalFundsVerified;
        private DirtyValue<decimal?> _logTotalLoanAmount;
        private DirtyValue<decimal?> _logTotalMonthlyIncome;
        private DirtyValue<string> _logTPONumber;
        private DirtyValue<string> _logTransactionID;
        private DirtyValue<string> _logUnderwritingRiskAssessOther;
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _logUnderwritingRiskAssessType;
        private DirtyValue<string> _logWithUndisclosedDebt;

        /// <summary>
        /// AUSTrackingLog AUSTrackingLogIndex
        /// </summary>
        public int? AUSTrackingLogIndex { get => _aUSTrackingLogIndex; set => SetField(ref _aUSTrackingLogIndex, value); }

        /// <summary>
        /// AUSTrackingLog BatchDocumentRefId
        /// </summary>
        public string BatchDocumentRefId { get => _batchDocumentRefId; set => SetField(ref _batchDocumentRefId, value); }

        /// <summary>
        /// AUSTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// AUSTrackingLog IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => SetField(ref _isEmpty, value); }

        /// <summary>
        /// AUSTrackingLog IsHistory
        /// </summary>
        public bool? IsHistory { get => _isHistory; set => SetField(ref _isHistory, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Accept Plus Eligible [AUS.X127]
        /// </summary>
        public string LogAcceptPlusEligible { get => _logAcceptPlusEligible; set => SetField(ref _logAcceptPlusEligible, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Affordable Product Type [AUS.X155]
        /// </summary>
        public string LogAffordableProductType { get => _logAffordableProductType; set => SetField(ref _logAffordableProductType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - All Other Payments [AUS.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogAllOtherPayments { get => _logAllOtherPayments; set => SetField(ref _logAllOtherPayments, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Amortization Months [AUS.X144]
        /// </summary>
        public int? LogAmortizationMonths { get => _logAmortizationMonths; set => SetField(ref _logAmortizationMonths, value); }

        /// <summary>
        /// AUS Tracking - Amortization Type [AUS.X22]
        /// </summary>
        public StringEnumValue<AmortizationType> LogAmortizationType { get => _logAmortizationType; set => SetField(ref _logAmortizationType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Amt. Subordinate Fin. [AUS.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogAmtSubordinateFin { get => _logAmtSubordinateFin; set => SetField(ref _logAmtSubordinateFin, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Appraisal Type/MAF [AUS.X125]
        /// </summary>
        public string LogAppraisalTypeMAF { get => _logAppraisalTypeMAF; set => SetField(ref _logAppraisalTypeMAF, value); }

        /// <summary>
        /// AUS Tracking - Appraised Value [AUS.X18]
        /// </summary>
        public int? LogAppraisedValue { get => _logAppraisedValue; set => SetField(ref _logAppraisedValue, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - ARM Qualifying Rate [AUS.X145]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogARMQualifyingRate { get => _logARMQualifyingRate; set => SetField(ref _logARMQualifyingRate, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Assessment Type [AUS.X123]
        /// </summary>
        public string LogAssessmentType { get => _logAssessmentType; set => SetField(ref _logAssessmentType, value); }

        /// <summary>
        /// AUS Tracking - AUS Recommendation [AUS.X6]
        /// </summary>
        public string LogAUSRecommendation { get => _logAUSRecommendation; set => SetField(ref _logAUSRecommendation, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - AUS Status [AUS.X121]
        /// </summary>
        public string LogAUSStatus { get => _logAUSStatus; set => SetField(ref _logAUSStatus, value); }

        /// <summary>
        /// AUS Tracking - AUS Tracking Type [AUS.X999]
        /// </summary>
        public StringEnumValue<LogAUSTrackingType> LogAUSTrackingType { get => _logAUSTrackingType; set => SetField(ref _logAUSTrackingType, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - AUS Transaction # [AUS.X114]
        /// </summary>
        public string LogAUSTransactionID { get => _logAUSTransactionID; set => SetField(ref _logAUSTransactionID, value); }

        /// <summary>
        /// AUS Tracking - AUS Version # [AUS.X9]
        /// </summary>
        public string LogAUSVersion { get => _logAUSVersion; set => SetField(ref _logAUSVersion, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Balloon [AUS.X53]
        /// </summary>
        public string LogBalloon { get => _logBalloon; set => SetField(ref _logBalloon, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Balloon Term [AUS.X143]
        /// </summary>
        public int? LogBalloonTerm { get => _logBalloonTerm; set => SetField(ref _logBalloonTerm, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Amount [AUS.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogBorrowerAssetAmount { get => _logBorrowerAssetAmount; set => SetField(ref _logBorrowerAssetAmount, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Name [AUS.X106]
        /// </summary>
        public string LogBorrowerAssetName { get => _logBorrowerAssetName; set => SetField(ref _logBorrowerAssetName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Type [AUS.X107]
        /// </summary>
        public string LogBorrowerAssetType { get => _logBorrowerAssetType; set => SetField(ref _logBorrowerAssetType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 1 [AUS.X93]
        /// </summary>
        public string LogBorrowerCreditScore1 { get => _logBorrowerCreditScore1; set => SetField(ref _logBorrowerCreditScore1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 2 [AUS.X94]
        /// </summary>
        public string LogBorrowerCreditScore2 { get => _logBorrowerCreditScore2; set => SetField(ref _logBorrowerCreditScore2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 3 [AUS.X95]
        /// </summary>
        public string LogBorrowerCreditScore3 { get => _logBorrowerCreditScore3; set => SetField(ref _logBorrowerCreditScore3, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Equifax/BEACON [AUS.X134]
        /// </summary>
        public string LogBorrowerEquifaxBEACON { get => _logBorrowerEquifaxBEACON; set => SetField(ref _logBorrowerEquifaxBEACON, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Experian/FICO [AUS.X132]
        /// </summary>
        public string LogBorrowerExperianFICO { get => _logBorrowerExperianFICO; set => SetField(ref _logBorrowerExperianFICO, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Amount [AUS.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogBorrowerIncomeAmount { get => _logBorrowerIncomeAmount; set => SetField(ref _logBorrowerIncomeAmount, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Name [AUS.X100]
        /// </summary>
        public string LogBorrowerIncomeName { get => _logBorrowerIncomeName; set => SetField(ref _logBorrowerIncomeName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Type [AUS.X101]
        /// </summary>
        public string LogBorrowerIncomeType { get => _logBorrowerIncomeType; set => SetField(ref _logBorrowerIncomeType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Institution Name [AUS.X108]
        /// </summary>
        public string LogBorrowerInstitutionName { get => _logBorrowerInstitutionName; set => SetField(ref _logBorrowerInstitutionName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Name [AUS.X43]
        /// </summary>
        public string LogBorrowerName { get => _logBorrowerName; set => SetField(ref _logBorrowerName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Score Name [AUS.X92]
        /// </summary>
        public string LogBorrowerScoreName { get => _logBorrowerScoreName; set => SetField(ref _logBorrowerScoreName, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica [AUS.X133]
        /// </summary>
        public string LogBorrowerTransUnionEmpirica { get => _logBorrowerTransUnionEmpirica; set => SetField(ref _logBorrowerTransUnionEmpirica, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Type [AUS.X84]
        /// </summary>
        public string LogBorrowerType1 { get => _logBorrowerType1; set => SetField(ref _logBorrowerType1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Type 2 [AUS.X88]
        /// </summary>
        public string LogBorrowerType2 { get => _logBorrowerType2; set => SetField(ref _logBorrowerType2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Bought Down Rate [AUS.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogBoughtDownRate { get => _logBoughtDownRate; set => SetField(ref _logBoughtDownRate, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Buydown [AUS.X59]
        /// </summary>
        public string LogBuydown { get => _logBuydown; set => SetField(ref _logBuydown, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Cash Back [AUS.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogCashBack { get => _logCashBack; set => SetField(ref _logCashBack, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Cash Out Amount [AUS.X158]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogCashOutAmount { get => _logCashOutAmount; set => SetField(ref _logCashOutAmount, value); }

        /// <summary>
        /// AUS Tracking - CLTV [AUS.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogCLTV { get => _logCLTV; set => SetField(ref _logCLTV, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Amount [AUS.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogCoBorrowerAssetAmount { get => _logCoBorrowerAssetAmount; set => SetField(ref _logCoBorrowerAssetAmount, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Name [AUS.X110]
        /// </summary>
        public string LogCoBorrowerAssetName { get => _logCoBorrowerAssetName; set => SetField(ref _logCoBorrowerAssetName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Type [AUS.X111]
        /// </summary>
        public string LogCoBorrowerAssetType { get => _logCoBorrowerAssetType; set => SetField(ref _logCoBorrowerAssetType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 1 [AUS.X97]
        /// </summary>
        public string LogCoBorrowerCreditScore1 { get => _logCoBorrowerCreditScore1; set => SetField(ref _logCoBorrowerCreditScore1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 2 [AUS.X98]
        /// </summary>
        public string LogCoBorrowerCreditScore2 { get => _logCoBorrowerCreditScore2; set => SetField(ref _logCoBorrowerCreditScore2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 3 [AUS.X99]
        /// </summary>
        public string LogCoBorrowerCreditScore3 { get => _logCoBorrowerCreditScore3; set => SetField(ref _logCoBorrowerCreditScore3, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON [AUS.X137]
        /// </summary>
        public string LogCoBorrowerEquifaxBEACON { get => _logCoBorrowerEquifaxBEACON; set => SetField(ref _logCoBorrowerEquifaxBEACON, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Experian FICO [AUS.X135]
        /// </summary>
        public string LogCoBorrowerExperianFICO { get => _logCoBorrowerExperianFICO; set => SetField(ref _logCoBorrowerExperianFICO, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Amount [AUS.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogCoBorrowerIncomeAmount { get => _logCoBorrowerIncomeAmount; set => SetField(ref _logCoBorrowerIncomeAmount, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Name [AUS.X103]
        /// </summary>
        public string LogCoBorrowerIncomeName { get => _logCoBorrowerIncomeName; set => SetField(ref _logCoBorrowerIncomeName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Type [AUS.X104]
        /// </summary>
        public string LogCoBorrowerIncomeType { get => _logCoBorrowerIncomeType; set => SetField(ref _logCoBorrowerIncomeType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Institution Name [AUS.X112]
        /// </summary>
        public string LogCoBorrowerInstitutionName { get => _logCoBorrowerInstitutionName; set => SetField(ref _logCoBorrowerInstitutionName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Coborrower Name [AUS.X45]
        /// </summary>
        public string LogCoborrowerName { get => _logCoborrowerName; set => SetField(ref _logCoborrowerName, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Score Name 2 [AUS.X96]
        /// </summary>
        public string LogCoBorrowerScoreName { get => _logCoBorrowerScoreName; set => SetField(ref _logCoBorrowerScoreName, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica [AUS.X136]
        /// </summary>
        public string LogCoBorrowerTransUnionEmpirica { get => _logCoBorrowerTransUnionEmpirica; set => SetField(ref _logCoBorrowerTransUnionEmpirica, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Code 1 [AUS.X80]
        /// </summary>
        public string LogCode1 { get => _logCode1; set => SetField(ref _logCode1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Code 2 [AUS.X82]
        /// </summary>
        public string LogCode2 { get => _logCode2; set => SetField(ref _logCode2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Code Description 1 [AUS.X81]
        /// </summary>
        public string LogCodeDescription1 { get => _logCodeDescription1; set => SetField(ref _logCodeDescription1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Code Description 2 [AUS.X83]
        /// </summary>
        public string LogCodeDescription2 { get => _logCodeDescription2; set => SetField(ref _logCodeDescription2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Community Lending [AUS.X54]
        /// </summary>
        public string LogCommunityLending { get => _logCommunityLending; set => SetField(ref _logCommunityLending, value); }

        /// <summary>
        /// AUSTrackingLog LogCreatedOn
        /// </summary>
        public DateTime? LogCreatedOn { get => _logCreatedOn; set => SetField(ref _logCreatedOn, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Agency 1 [AUS.X85]
        /// </summary>
        public string LogCreditAgency1 { get => _logCreditAgency1; set => SetField(ref _logCreditAgency1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Agency 2 [AUS.X89]
        /// </summary>
        public string LogCreditAgency2 { get => _logCreditAgency2; set => SetField(ref _logCreditAgency2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report Date 1 [AUS.X87]
        /// </summary>
        public DateTime? LogCreditReportDate1 { get => _logCreditReportDate1; set => SetField(ref _logCreditReportDate1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report Date 2 [AUS.X91]
        /// </summary>
        public DateTime? LogCreditReportDate2 { get => _logCreditReportDate2; set => SetField(ref _logCreditReportDate2, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report ID 1 [AUS.X86]
        /// </summary>
        public string LogCreditReportID1 { get => _logCreditReportID1; set => SetField(ref _logCreditReportID1, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report ID 2 [AUS.X90]
        /// </summary>
        public string LogCreditReportID2 { get => _logCreditReportID2; set => SetField(ref _logCreditReportID2, value); }

        /// <summary>
        /// Cured AUS Tracking - Amortization Type [AUS.CuredX22]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<AmortizationType> LogCuredAmortizationType { get => _logCuredAmortizationType; set => SetField(ref _logCuredAmortizationType, value); }

        /// <summary>
        /// Cured AUS Tracking - Appraised Value [AUS.CuredX18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LogCuredAppraisedValue { get => _logCuredAppraisedValue; set => SetField(ref _logCuredAppraisedValue, value); }

        /// <summary>
        /// CuredAUS Tracking - CLTV [AUS.CuredX12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LogCuredCLTV { get => _logCuredCLTV; set => SetField(ref _logCuredCLTV, value); }

        /// <summary>
        /// Cured AUS Tracking - Housing Expense Ratio [AUS.CuredX14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LogCuredHousingExpenseRatio { get => _logCuredHousingExpenseRatio; set => SetField(ref _logCuredHousingExpenseRatio, value); }

        /// <summary>
        /// Cured AUS Tracking - Loan Purpose [AUS.CuredX23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<LoanPurposeType> LogCuredLoanPurpose { get => _logCuredLoanPurpose; set => SetField(ref _logCuredLoanPurpose, value); }

        /// <summary>
        /// Cured AUS Tracking - Loan Term [AUS.CuredX21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LogCuredLoanTerm { get => _logCuredLoanTerm; set => SetField(ref _logCuredLoanTerm, value); }

        /// <summary>
        /// Cured AUS Tracking - Loan Type [AUS.CuredX20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<LoanType> LogCuredLoanType { get => _logCuredLoanType; set => SetField(ref _logCuredLoanType, value); }

        /// <summary>
        /// Cured AUS Tracking - LTV [AUS.CuredX11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LogCuredLTV { get => _logCuredLTV; set => SetField(ref _logCuredLTV, value); }

        /// <summary>
        /// Cured AUS Tracking - Note Rate [AUS.CuredX19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LogCuredNoteRate { get => _logCuredNoteRate; set => SetField(ref _logCuredNoteRate, value); }

        /// <summary>
        /// Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.CuredX32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LogCuredProposedTotalHousingPayment { get => _logCuredProposedTotalHousingPayment; set => SetField(ref _logCuredProposedTotalHousingPayment, value); }

        /// <summary>
        /// Cured AUS Tracking - Refinance Purpose [AUS.CuredX24]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<RefinancePurpose> LogCuredRefinancePurpose { get => _logCuredRefinancePurpose; set => SetField(ref _logCuredRefinancePurpose, value); }

        /// <summary>
        /// Cured AUS Tracking - Total Expense Ratio [AUS.CuredX15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LogCuredTotalExpenseRatio { get => _logCuredTotalExpenseRatio; set => SetField(ref _logCuredTotalExpenseRatio, value); }

        /// <summary>
        /// Cured AUS Tracking - Total Loan Amount [AUS.CuredX16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LogCuredTotalLoanAmount { get => _logCuredTotalLoanAmount; set => SetField(ref _logCuredTotalLoanAmount, value); }

        /// <summary>
        /// Cured AUS Tracking - Income / Assets - Total Monthly Income [AUS.CuredX41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LogCuredTotalMonthlyIncome { get => _logCuredTotalMonthlyIncome; set => SetField(ref _logCuredTotalMonthlyIncome, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Date Time Assessed [AUS.X169]
        /// </summary>
        public string LogDateTimeAssessed { get => _logDateTimeAssessed; set => SetField(ref _logDateTimeAssessed, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Date Time Requested [AUS.X168]
        /// </summary>
        public string LogDateTimeRequested { get => _logDateTimeRequested; set => SetField(ref _logDateTimeRequested, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Debt Ratio [AUS.X149]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogDebtRatio { get => _logDebtRatio; set => SetField(ref _logDebtRatio, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Documentation Level [AUS.X118]
        /// </summary>
        public string LogDocumentationLevel { get => _logDocumentationLevel; set => SetField(ref _logDocumentationLevel, value); }

        /// <summary>
        /// AUS Tracking - DU Case ID/ LP AUS Key # [AUS.X7]
        /// </summary>
        public string LogDUCaseIDorLPAUSKey { get => _logDUCaseIDorLPAUSKey; set => SetField(ref _logDUCaseIDorLPAUSKey, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Type [AUS.X50]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"MHAdvantage\"]")]
        public StringEnumValue<PropertyType> LogDUPropertyType { get => _logDUPropertyType; set => SetField(ref _logDUPropertyType, value); }

        /// <summary>
        /// AUS Tracking - eFolder GUID [AUS.EFOLDERGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LogeFolderGUID { get => _logeFolderGUID; set => SetField(ref _logeFolderGUID, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified [AUS.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogExcessAvailableAssetsNoVerified { get => _logExcessAvailableAssetsNoVerified; set => SetField(ref _logExcessAvailableAssetsNoVerified, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Financed MI Amount [AUS.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogFinancedMIAmount { get => _logFinancedMIAmount; set => SetField(ref _logFinancedMIAmount, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - First P&amp;I [AUS.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogFirstPandI { get => _logFirstPandI; set => SetField(ref _logFirstPandI, value); }

        /// <summary>
        /// AUS Tracking - First Submission Date [AUS.X4]
        /// </summary>
        public DateTime? LogFirstSubmissionDate { get => _logFirstSubmissionDate; set => SetField(ref _logFirstSubmissionDate, value); }

        /// <summary>
        /// AUS Tracking - First Submission Time [AUS.X174]
        /// </summary>
        public string LogFirstSubmissionTime { get => _logFirstSubmissionTime; set => SetField(ref _logFirstSubmissionTime, value); }

        /// <summary>
        /// AUS Tracking - Doc Class (Freddie) [AUS.X10]
        /// </summary>
        public string LogFreddieDocClass { get => _logFreddieDocClass; set => SetField(ref _logFreddieDocClass, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Funds Required to Close [AUS.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogFundsRequiredClose { get => _logFundsRequiredClose; set => SetField(ref _logFundsRequiredClose, value); }

        /// <summary>
        /// AUSTrackingLog LogGUID
        /// </summary>
        public string LogGUID { get => _logGUID; set => SetField(ref _logGUID, value); }

        /// <summary>
        /// AUS Tracking - HLCTV [AUS.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogHLCTV { get => _logHLCTV; set => SetField(ref _logHLCTV, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Housing Expense [AUS.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogHousingExpense { get => _logHousingExpense; set => SetField(ref _logHousingExpense, value); }

        /// <summary>
        /// AUS Tracking - Housing Expense Ratio [AUS.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogHousingExpenseRatio { get => _logHousingExpenseRatio; set => SetField(ref _logHousingExpenseRatio, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Housing Ratio [AUS.X148]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogHousingRatio { get => _logHousingRatio; set => SetField(ref _logHousingRatio, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - HTLTV [AUS.X147]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogHTLTV { get => _logHTLTV; set => SetField(ref _logHTLTV, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Including Less Than 10 Mos. [AUS.X67]
        /// </summary>
        public string LogIncludingLess10Mos { get => _logIncludingLess10Mos; set => SetField(ref _logIncludingLess10Mos, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Base [AUS.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetBase { get => _logIncomeAssetBase; set => SetField(ref _logIncomeAssetBase, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Bonus [AUS.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetBonus { get => _logIncomeAssetBonus; set => SetField(ref _logIncomeAssetBonus, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Commission [AUS.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetCommission { get => _logIncomeAssetCommission; set => SetField(ref _logIncomeAssetCommission, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Other [AUS.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetOther { get => _logIncomeAssetOther; set => SetField(ref _logIncomeAssetOther, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Overtime [AUS.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetOvertime { get => _logIncomeAssetOvertime; set => SetField(ref _logIncomeAssetOvertime, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Subj. Pos. Cash Flow [AUS.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetPosCashFlow { get => _logIncomeAssetPosCashFlow; set => SetField(ref _logIncomeAssetPosCashFlow, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Positive Net Rental [AUS.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogIncomeAssetPositiveNetRental { get => _logIncomeAssetPositiveNetRental; set => SetField(ref _logIncomeAssetPositiveNetRental, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Indicator Score [AUS.X128]
        /// </summary>
        public string LogIndicatorScore { get => _logIndicatorScore; set => SetField(ref _logIndicatorScore, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Intended Use of Property [AUS.X157]
        /// </summary>
        public string LogIntendedUseofProperty { get => _logIntendedUseofProperty; set => SetField(ref _logIntendedUseofProperty, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1 [AUS.X185]
        /// </summary>
        public string LogLCLAEvaluatedServiceConclusion1 { get => _logLCLAEvaluatedServiceConclusion1; set => SetField(ref _logLCLAEvaluatedServiceConclusion1, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2 [AUS.X187]
        /// </summary>
        public string LogLCLAEvaluatedServiceConclusion2 { get => _logLCLAEvaluatedServiceConclusion2; set => SetField(ref _logLCLAEvaluatedServiceConclusion2, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3 [AUS.X189]
        /// </summary>
        public string LogLCLAEvaluatedServiceConclusion3 { get => _logLCLAEvaluatedServiceConclusion3; set => SetField(ref _logLCLAEvaluatedServiceConclusion3, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4 [AUS.X191]
        /// </summary>
        public string LogLCLAEvaluatedServiceConclusion4 { get => _logLCLAEvaluatedServiceConclusion4; set => SetField(ref _logLCLAEvaluatedServiceConclusion4, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1 [AUS.X184]
        /// </summary>
        public StringEnumValue<LogLCLAEvaluatedServiceType1> LogLCLAEvaluatedServiceType1 { get => _logLCLAEvaluatedServiceType1; set => SetField(ref _logLCLAEvaluatedServiceType1, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2 [AUS.X186]
        /// </summary>
        public StringEnumValue<LogLCLAEvaluatedServiceType2> LogLCLAEvaluatedServiceType2 { get => _logLCLAEvaluatedServiceType2; set => SetField(ref _logLCLAEvaluatedServiceType2, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3 [AUS.X188]
        /// </summary>
        public StringEnumValue<LogLCLAEvaluatedServiceType3> LogLCLAEvaluatedServiceType3 { get => _logLCLAEvaluatedServiceType3; set => SetField(ref _logLCLAEvaluatedServiceType3, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4 [AUS.X190]
        /// </summary>
        public string LogLCLAEvaluatedServiceType4 { get => _logLCLAEvaluatedServiceType4; set => SetField(ref _logLCLAEvaluatedServiceType4, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Lender Loan # [AUS.X44]
        /// </summary>
        public string LogLenderLoan { get => _logLenderLoan; set => SetField(ref _logLenderLoan, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Lien Type [AUS.X56]
        /// </summary>
        public StringEnumValue<LienType> LogLienType { get => _logLienType; set => SetField(ref _logLienType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Loan Amount [AUS.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogLoanAmount { get => _logLoanAmount; set => SetField(ref _logLoanAmount, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Application # [AUS.X142]
        /// </summary>
        public string LogLoanApplicationID { get => _logLoanApplicationID; set => SetField(ref _logLoanApplicationID, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Processing Stage [AUS.X122]
        /// </summary>
        public string LogLoanProcessingStage { get => _logLoanProcessingStage; set => SetField(ref _logLoanProcessingStage, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Prospector ID [AUS.X115]
        /// </summary>
        public string LogLoanProspectorID { get => _logLoanProspectorID; set => SetField(ref _logLoanProspectorID, value); }

        /// <summary>
        /// AUS Tracking - Loan Purpose [AUS.X23]
        /// </summary>
        public StringEnumValue<LoanPurposeType> LogLoanPurpose { get => _logLoanPurpose; set => SetField(ref _logLoanPurpose, value); }

        /// <summary>
        /// AUS Tracking - Loan Term [AUS.X21]
        /// </summary>
        public int? LogLoanTerm { get => _logLoanTerm; set => SetField(ref _logLoanTerm, value); }

        /// <summary>
        /// AUS Tracking - Loan Type [AUS.X20]
        /// </summary>
        public StringEnumValue<LoanType> LogLoanType { get => _logLoanType; set => SetField(ref _logLoanType, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - LP Assmt. Exp. Date [AUS.X131]
        /// </summary>
        public DateTime? LogLPAssmtExpDate { get => _logLPAssmtExpDate; set => SetField(ref _logLPAssmtExpDate, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Property Type [AUS.X172]
        /// </summary>
        public StringEnumValue<OtherPropertyType> LogLPPropertyType { get => _logLPPropertyType; set => SetField(ref _logLPPropertyType, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - LP Version [AUS.X124]
        /// </summary>
        public string LogLPVersion { get => _logLPVersion; set => SetField(ref _logLPVersion, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion [AUS.X183]
        /// </summary>
        public string LogLQACollateralRepWarrantyServiceConclusion { get => _logLQACollateralRepWarrantyServiceConclusion; set => SetField(ref _logLQACollateralRepWarrantyServiceConclusion, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion [AUS.X181]
        /// </summary>
        public string LogLQACreditRiskAssessmentConclusion { get => _logLQACreditRiskAssessmentConclusion; set => SetField(ref _logLQACreditRiskAssessmentConclusion, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion [AUS.X179]
        /// </summary>
        public string LogLQADataCompareFieldConclusion { get => _logLQADataCompareFieldConclusion; set => SetField(ref _logLQADataCompareFieldConclusion, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Field Name [AUS.X178]
        /// </summary>
        public string LogLQADataCompareFieldName { get => _logLQADataCompareFieldName; set => SetField(ref _logLQADataCompareFieldName, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Result [AUS.X175]
        /// </summary>
        public string LogLQADataCompareResult { get => _logLQADataCompareResult; set => SetField(ref _logLQADataCompareResult, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - LP Key [AUS.X176]
        /// </summary>
        public string LogLQALPKey { get => _logLQALPKey; set => SetField(ref _logLQALPKey, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result [AUS.X182]
        /// </summary>
        public string LogLQAPurchaseEligibilityResult { get => _logLQAPurchaseEligibilityResult; set => SetField(ref _logLQAPurchaseEligibilityResult, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Risk Assessment Key [AUS.X180]
        /// </summary>
        public string LogLQARiskAssessmentKey { get => _logLQARiskAssessmentKey; set => SetField(ref _logLQARiskAssessmentKey, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Submission DateTime [AUS.X177]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LogLQASubmissionDateTime { get => _logLQASubmissionDateTime; set => SetField(ref _logLQASubmissionDateTime, value); }

        /// <summary>
        /// AUS Tracking - LTV [AUS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogLTV { get => _logLTV; set => SetField(ref _logLTV, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Max Mortgage Limit [AUS.X162]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogMaxMortgageLimit { get => _logMaxMortgageLimit; set => SetField(ref _logMaxMortgageLimit, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - MI Decision [AUS.X126]
        /// </summary>
        public string LogMIDecision { get => _logMIDecision; set => SetField(ref _logMIDecision, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Mortgage Type [AUS.X119]
        /// </summary>
        public string LogMortgageType { get => _logMortgageType; set => SetField(ref _logMortgageType, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Neg. Amortization Type [AUS.X152]
        /// </summary>
        public string LogNegAmortizationType { get => _logNegAmortizationType; set => SetField(ref _logNegAmortizationType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Negative Net Rental [AUS.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogNegativeNetRental { get => _logNegativeNetRental; set => SetField(ref _logNegativeNetRental, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Net Cash Back [AUS.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogNetCashBack { get => _logNetCashBack; set => SetField(ref _logNetCashBack, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - New Construction [AUS.X154]
        /// </summary>
        public string LogNewConstruction { get => _logNewConstruction; set => SetField(ref _logNewConstruction, value); }

        /// <summary>
        /// AUS Tracking - Note Rate [AUS.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogNoteRate { get => _logNoteRate; set => SetField(ref _logNoteRate, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - NOTP Number [AUS.X171]
        /// </summary>
        public string LogNOTPNumber { get => _logNOTPNumber; set => SetField(ref _logNOTPNumber, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - No Units [AUS.X51]
        /// </summary>
        public int? LogNoUnits { get => _logNoUnits; set => SetField(ref _logNoUnits, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - # of Submissions [AUS.X170]
        /// </summary>
        public string LogNumberOfSubmissions { get => _logNumberOfSubmissions; set => SetField(ref _logNumberOfSubmissions, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Occupancy Status [AUS.X52]
        /// </summary>
        public string LogOccupancyStatus { get => _logOccupancyStatus; set => SetField(ref _logOccupancyStatus, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Occupant Debt Ratio [AUS.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogOccupantDebtRatio { get => _logOccupantDebtRatio; set => SetField(ref _logOccupantDebtRatio, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Occupant Housing Ratio [AUS.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogOccupantHousingRatio { get => _logOccupantHousingRatio; set => SetField(ref _logOccupantHousingRatio, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Offering Identifier [AUS.X156]
        /// </summary>
        public string LogOfferingIdentifier { get => _logOfferingIdentifier; set => SetField(ref _logOfferingIdentifier, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Originating Company [AUS.X164]
        /// </summary>
        public string LogOriginatingCompany { get => _logOriginatingCompany; set => SetField(ref _logOriginatingCompany, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Owner Existing Mtg. [AUS.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogOwnerExistingMtg { get => _logOwnerExistingMtg; set => SetField(ref _logOwnerExistingMtg, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - P &amp; I [AUS.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogPandI { get => _logPandI; set => SetField(ref _logPandI, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Payment Frequency [AUS.X55]
        /// </summary>
        public int? LogPaymentFrequency { get => _logPaymentFrequency; set => SetField(ref _logPaymentFrequency, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address [AUS.X138]
        /// </summary>
        public string LogPresentAddress { get => _logPresentAddress; set => SetField(ref _logPresentAddress, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address City [AUS.X139]
        /// </summary>
        public string LogPresentAddressCity { get => _logPresentAddressCity; set => SetField(ref _logPresentAddressCity, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address State [AUS.X140]
        /// </summary>
        public StringEnumValue<State> LogPresentAddressState { get => _logPresentAddressState; set => SetField(ref _logPresentAddressState, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address Zipcode [AUS.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LogPresentAddressZipCode { get => _logPresentAddressZipCode; set => SetField(ref _logPresentAddressZipCode, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Housing Expense [AUS.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogPresentHousingExpense { get => _logPresentHousingExpense; set => SetField(ref _logPresentHousingExpense, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Present/Principal Housing Payment [AUS.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogPresentPrincipalHousingPayment { get => _logPresentPrincipalHousingPayment; set => SetField(ref _logPresentPrincipalHousingPayment, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Address [AUS.X46]
        /// </summary>
        public string LogPropertyAddress { get => _logPropertyAddress; set => SetField(ref _logPropertyAddress, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Property City [AUS.X47]
        /// </summary>
        public string LogPropertyCity { get => _logPropertyCity; set => SetField(ref _logPropertyCity, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Property State [AUS.X48]
        /// </summary>
        public StringEnumValue<State> LogPropertyState { get => _logPropertyState; set => SetField(ref _logPropertyState, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Zipcode [AUS.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LogPropertyZipcode { get => _logPropertyZipcode; set => SetField(ref _logPropertyZipcode, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance [AUS.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedHazardInsurance { get => _logProposedHazardInsurance; set => SetField(ref _logProposedHazardInsurance, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees [AUS.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedHOAFees { get => _logProposedHOAFees; set => SetField(ref _logProposedHOAFees, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Proposed Housing (PITI) [AUS.X160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedHousingPITI { get => _logProposedHousingPITI; set => SetField(ref _logProposedHousingPITI, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance [AUS.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedMortgageInsurance { get => _logProposedMortgageInsurance; set => SetField(ref _logProposedMortgageInsurance, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Other [AUS.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedOtherPayment { get => _logProposedOtherPayment; set => SetField(ref _logProposedOtherPayment, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Taxes [AUS.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedTaxes { get => _logProposedTaxes; set => SetField(ref _logProposedTaxes, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedTotalHousingPayment { get => _logProposedTotalHousingPayment; set => SetField(ref _logProposedTotalHousingPayment, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt [AUS.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogProposedTotalMonthlyDebt { get => _logProposedTotalMonthlyDebt; set => SetField(ref _logProposedTotalMonthlyDebt, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Purchase Eligibility [AUS.X120]
        /// </summary>
        public string LogPurchaseEligibility { get => _logPurchaseEligibility; set => SetField(ref _logPurchaseEligibility, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Qualifying Rate [AUS.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogQualifyingRate { get => _logQualifyingRate; set => SetField(ref _logQualifyingRate, value); }

        /// <summary>
        /// AUSTrackingLog LogRecordType
        /// </summary>
        public string LogRecordType { get => _logRecordType; set => SetField(ref _logRecordType, value); }

        /// <summary>
        /// AUS Tracking - Refinance Purpose [AUS.X24]
        /// </summary>
        public StringEnumValue<RefinancePurpose> LogRefinancePurpose { get => _logRefinancePurpose; set => SetField(ref _logRefinancePurpose, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Reserves [AUS.X159]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogReserves { get => _logReserves; set => SetField(ref _logReserves, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified [AUS.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogReservesRequiredVerified { get => _logReservesRequiredVerified; set => SetField(ref _logReservesRequiredVerified, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Risk Class [AUS.X117]
        /// </summary>
        public string LogRiskClass { get => _logRiskClass; set => SetField(ref _logRiskClass, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Sales Concessions [AUS.X163]
        /// </summary>
        public string LogSalesConcessions { get => _logSalesConcessions; set => SetField(ref _logSalesConcessions, value); }

        /// <summary>
        /// AUS Tracking - Sales Price [AUS.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogSalesPrice { get => _logSalesPrice; set => SetField(ref _logSalesPrice, value); }

        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Second P&amp;I [AUS.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogSecondPandI { get => _logSecondPandI; set => SetField(ref _logSecondPandI, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Selected Borrower [AUS.X130]
        /// </summary>
        public string LogSelectedBorrower { get => _logSelectedBorrower; set => SetField(ref _logSelectedBorrower, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Selected Repository [AUS.X129]
        /// </summary>
        public string LogSelectedRepository { get => _logSelectedRepository; set => SetField(ref _logSelectedRepository, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Seller Number [AUS.X166]
        /// </summary>
        public string LogSellerNumber { get => _logSellerNumber; set => SetField(ref _logSellerNumber, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow [AUS.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogSubjNegCashFlow { get => _logSubjNegCashFlow; set => SetField(ref _logSubjNegCashFlow, value); }

        /// <summary>
        /// AUS Tracking - Submission Date [AUS.X3]
        /// </summary>
        public DateTime? LogSubmissionDate { get => _logSubmissionDate; set => SetField(ref _logSubmissionDate, value); }

        /// <summary>
        /// AUS Tracking - Submission Number [AUS.X5]
        /// </summary>
        public string LogSubmissionNumber { get => _logSubmissionNumber; set => SetField(ref _logSubmissionNumber, value); }

        /// <summary>
        /// AUS Tracking - Submission Time [AUS.X173]
        /// </summary>
        public string LogSubmissionTime { get => _logSubmissionTime; set => SetField(ref _logSubmissionTime, value); }

        /// <summary>
        /// AUS Tracking - Submitted By [AUS.X8]
        /// </summary>
        public string LogSubmittedBy { get => _logSubmittedBy; set => SetField(ref _logSubmittedBy, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Submitting Company [AUS.X165]
        /// </summary>
        public string LogSubmittingCompany { get => _logSubmittingCompany; set => SetField(ref _logSubmittingCompany, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Temporary Subsidy Buydown [AUS.X153]
        /// </summary>
        public string LogTemporarySubsidyBuydown { get => _logTemporarySubsidyBuydown; set => SetField(ref _logTemporarySubsidyBuydown, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - TLTV [AUS.X146]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogTLTV { get => _logTLTV; set => SetField(ref _logTLTV, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Total Assets [AUS.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalAsset { get => _logTotalAsset; set => SetField(ref _logTotalAsset, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Expense [AUS.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalExpense { get => _logTotalExpense; set => SetField(ref _logTotalExpense, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Expense Pmt [AUS.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalExpensePmt { get => _logTotalExpensePmt; set => SetField(ref _logTotalExpensePmt, value); }

        /// <summary>
        /// AUS Tracking - Total Expense Ratio [AUS.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LogTotalExpenseRatio { get => _logTotalExpenseRatio; set => SetField(ref _logTotalExpenseRatio, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Funds to be Verified [AUS.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalFundsVerified { get => _logTotalFundsVerified; set => SetField(ref _logTotalFundsVerified, value); }

        /// <summary>
        /// AUS Tracking - Total Loan Amount [AUS.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalLoanAmount { get => _logTotalLoanAmount; set => SetField(ref _logTotalLoanAmount, value); }

        /// <summary>
        /// AUS Tracking - Income / Assets - Total Monthly Income [AUS.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LogTotalMonthlyIncome { get => _logTotalMonthlyIncome; set => SetField(ref _logTotalMonthlyIncome, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - TPO Number [AUS.X167]
        /// </summary>
        public string LogTPONumber { get => _logTPONumber; set => SetField(ref _logTPONumber, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac - Transaction ID [AUS.X116]
        /// </summary>
        public string LogTransactionID { get => _logTransactionID; set => SetField(ref _logTransactionID, value); }

        /// <summary>
        /// AUS Tracking - Underwriting Risk Assess Other Type [AUS.X2]
        /// </summary>
        public string LogUnderwritingRiskAssessOther { get => _logUnderwritingRiskAssessOther; set => SetField(ref _logUnderwritingRiskAssessOther, value); }

        /// <summary>
        /// AUS Tracking - Underwriting Risk Assess Type [AUS.X1]
        /// </summary>
        public StringEnumValue<RiskAssessmentType> LogUnderwritingRiskAssessType { get => _logUnderwritingRiskAssessType; set => SetField(ref _logUnderwritingRiskAssessType, value); }

        /// <summary>
        /// AUS Tracking - Fannie Mae - With Undisclosed Debt [AUS.X68]
        /// </summary>
        public string LogWithUndisclosedDebt { get => _logWithUndisclosedDebt; set => SetField(ref _logWithUndisclosedDebt, value); }
    }
}