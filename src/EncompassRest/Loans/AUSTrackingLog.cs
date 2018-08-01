using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AUSTrackingLog
    /// </summary>
    public sealed partial class AUSTrackingLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _aUSTrackingLogIndex;
        /// <summary>
        /// AUSTrackingLog AUSTrackingLogIndex
        /// </summary>
        public int? AUSTrackingLogIndex { get => _aUSTrackingLogIndex; set => _aUSTrackingLogIndex = value; }
        private DirtyValue<string> _batchDocumentRefId;
        /// <summary>
        /// AUSTrackingLog BatchDocumentRefId
        /// </summary>
        public string BatchDocumentRefId { get => _batchDocumentRefId; set => _batchDocumentRefId = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AUSTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isEmpty;
        /// <summary>
        /// AUSTrackingLog IsEmpty
        /// </summary>
        public bool? IsEmpty { get => _isEmpty; set => _isEmpty = value; }
        private DirtyValue<bool?> _isHistory;
        /// <summary>
        /// AUSTrackingLog IsHistory
        /// </summary>
        public bool? IsHistory { get => _isHistory; set => _isHistory = value; }
        private DirtyValue<string> _logAcceptPlusEligible;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Accept Plus Eligible [AUS.X127]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Accept Plus Eligible")]
        public string LogAcceptPlusEligible { get => _logAcceptPlusEligible; set => _logAcceptPlusEligible = value; }
        private DirtyValue<string> _logAffordableProductType;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Affordable Product Type [AUS.X155]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Affordable Product Type")]
        public string LogAffordableProductType { get => _logAffordableProductType; set => _logAffordableProductType = value; }
        private DirtyValue<decimal?> _logAllOtherPayments;
        /// <summary>
        /// AUS Tracking - Fannie Mae - All Other Payments [AUS.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - All Other Payments")]
        public decimal? LogAllOtherPayments { get => _logAllOtherPayments; set => _logAllOtherPayments = value; }
        private DirtyValue<int?> _logAmortizationMonths;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Amortization Months [AUS.X144]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Amortization Months")]
        public int? LogAmortizationMonths { get => _logAmortizationMonths; set => _logAmortizationMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _logAmortizationType;
        /// <summary>
        /// AUS Tracking - Amortization Type [AUS.X22]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Amortization Type")]
        public StringEnumValue<AmortizationType> LogAmortizationType { get => _logAmortizationType; set => _logAmortizationType = value; }
        private DirtyValue<decimal?> _logAmtSubordinateFin;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Amt. Subordinate Fin. [AUS.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Amt. Subordinate Fin.")]
        public decimal? LogAmtSubordinateFin { get => _logAmtSubordinateFin; set => _logAmtSubordinateFin = value; }
        private DirtyValue<string> _logAppraisalTypeMAF;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Appraisal Type/MAF [AUS.X125]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Appraisal Type/MAF")]
        public string LogAppraisalTypeMAF { get => _logAppraisalTypeMAF; set => _logAppraisalTypeMAF = value; }
        private DirtyValue<int?> _logAppraisedValue;
        /// <summary>
        /// AUS Tracking - Appraised Value [AUS.X18]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Appraised Value")]
        public int? LogAppraisedValue { get => _logAppraisedValue; set => _logAppraisedValue = value; }
        private DirtyValue<decimal?> _logARMQualifyingRate;
        /// <summary>
        /// AUS Tracking - Freddie Mac - ARM Qualifying Rate [AUS.X145]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - ARM Qualifying Rate")]
        public decimal? LogARMQualifyingRate { get => _logARMQualifyingRate; set => _logARMQualifyingRate = value; }
        private DirtyValue<string> _logAssessmentType;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Assessment Type [AUS.X123]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Assessment Type")]
        public string LogAssessmentType { get => _logAssessmentType; set => _logAssessmentType = value; }
        private DirtyValue<string> _logAUSRecommendation;
        /// <summary>
        /// AUS Tracking - AUS Recommendation [AUS.X6]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - AUS Recommendation")]
        public string LogAUSRecommendation { get => _logAUSRecommendation; set => _logAUSRecommendation = value; }
        private DirtyValue<string> _logAUSStatus;
        /// <summary>
        /// AUS Tracking - Freddie Mac - AUS Status [AUS.X121]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - AUS Status")]
        public string LogAUSStatus { get => _logAUSStatus; set => _logAUSStatus = value; }
        private DirtyValue<StringEnumValue<LogAUSTrackingType>> _logAUSTrackingType;
        /// <summary>
        /// AUS Tracking - AUS Tracking Type [AUS.X999]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - AUS Tracking Type")]
        public StringEnumValue<LogAUSTrackingType> LogAUSTrackingType { get => _logAUSTrackingType; set => _logAUSTrackingType = value; }
        private DirtyValue<string> _logAUSTransactionID;
        /// <summary>
        /// AUS Tracking - Freddie Mac - AUS Transaction # [AUS.X114]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - AUS Transaction #")]
        public string LogAUSTransactionID { get => _logAUSTransactionID; set => _logAUSTransactionID = value; }
        private DirtyValue<string> _logAUSVersion;
        /// <summary>
        /// AUS Tracking - AUS Version # [AUS.X9]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - AUS Version #")]
        public string LogAUSVersion { get => _logAUSVersion; set => _logAUSVersion = value; }
        private DirtyValue<string> _logBalloon;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Balloon [AUS.X53]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Balloon")]
        public string LogBalloon { get => _logBalloon; set => _logBalloon = value; }
        private DirtyValue<int?> _logBalloonTerm;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Balloon Term [AUS.X143]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Balloon Term")]
        public int? LogBalloonTerm { get => _logBalloonTerm; set => _logBalloonTerm = value; }
        private DirtyValue<decimal?> _logBorrowerAssetAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Amount [AUS.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Borrower Asset Amount")]
        public decimal? LogBorrowerAssetAmount { get => _logBorrowerAssetAmount; set => _logBorrowerAssetAmount = value; }
        private DirtyValue<string> _logBorrowerAssetName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Name [AUS.X106]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Asset Name")]
        public string LogBorrowerAssetName { get => _logBorrowerAssetName; set => _logBorrowerAssetName = value; }
        private DirtyValue<string> _logBorrowerAssetType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Asset Type [AUS.X107]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Asset Type")]
        public string LogBorrowerAssetType { get => _logBorrowerAssetType; set => _logBorrowerAssetType = value; }
        private DirtyValue<string> _logBorrowerCreditScore1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 1 [AUS.X93]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Credit Score 1")]
        public string LogBorrowerCreditScore1 { get => _logBorrowerCreditScore1; set => _logBorrowerCreditScore1 = value; }
        private DirtyValue<string> _logBorrowerCreditScore2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 2 [AUS.X94]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Credit Score 2")]
        public string LogBorrowerCreditScore2 { get => _logBorrowerCreditScore2; set => _logBorrowerCreditScore2 = value; }
        private DirtyValue<string> _logBorrowerCreditScore3;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Credit Score 3 [AUS.X95]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Credit Score 3")]
        public string LogBorrowerCreditScore3 { get => _logBorrowerCreditScore3; set => _logBorrowerCreditScore3 = value; }
        private DirtyValue<string> _logBorrowerEquifaxBEACON;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Equifax/BEACON [AUS.X134]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Borrower Equifax/BEACON")]
        public string LogBorrowerEquifaxBEACON { get => _logBorrowerEquifaxBEACON; set => _logBorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _logBorrowerExperianFICO;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Experian/FICO [AUS.X132]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Borrower Experian/FICO")]
        public string LogBorrowerExperianFICO { get => _logBorrowerExperianFICO; set => _logBorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _logBorrowerIncomeAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Amount [AUS.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Borrower Income Amount")]
        public decimal? LogBorrowerIncomeAmount { get => _logBorrowerIncomeAmount; set => _logBorrowerIncomeAmount = value; }
        private DirtyValue<string> _logBorrowerIncomeName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Name [AUS.X100]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Income Name")]
        public string LogBorrowerIncomeName { get => _logBorrowerIncomeName; set => _logBorrowerIncomeName = value; }
        private DirtyValue<string> _logBorrowerIncomeType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Income Type [AUS.X101]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Income Type")]
        public string LogBorrowerIncomeType { get => _logBorrowerIncomeType; set => _logBorrowerIncomeType = value; }
        private DirtyValue<string> _logBorrowerInstitutionName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Institution Name [AUS.X108]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Institution Name")]
        public string LogBorrowerInstitutionName { get => _logBorrowerInstitutionName; set => _logBorrowerInstitutionName = value; }
        private DirtyValue<string> _logBorrowerName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Name [AUS.X43]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Name")]
        public string LogBorrowerName { get => _logBorrowerName; set => _logBorrowerName = value; }
        private DirtyValue<string> _logBorrowerScoreName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Score Name [AUS.X92]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Score Name")]
        public string LogBorrowerScoreName { get => _logBorrowerScoreName; set => _logBorrowerScoreName = value; }
        private DirtyValue<string> _logBorrowerTransUnionEmpirica;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica [AUS.X133]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica")]
        public string LogBorrowerTransUnionEmpirica { get => _logBorrowerTransUnionEmpirica; set => _logBorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _logBorrowerType1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Type [AUS.X84]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Type")]
        public string LogBorrowerType1 { get => _logBorrowerType1; set => _logBorrowerType1 = value; }
        private DirtyValue<string> _logBorrowerType2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Borrower Type 2 [AUS.X88]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Borrower Type 2")]
        public string LogBorrowerType2 { get => _logBorrowerType2; set => _logBorrowerType2 = value; }
        private DirtyValue<decimal?> _logBoughtDownRate;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Bought Down Rate [AUS.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Fannie Mae - Bought Down Rate")]
        public decimal? LogBoughtDownRate { get => _logBoughtDownRate; set => _logBoughtDownRate = value; }
        private DirtyValue<string> _logBuydown;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Buydown [AUS.X59]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Buydown")]
        public string LogBuydown { get => _logBuydown; set => _logBuydown = value; }
        private DirtyValue<decimal?> _logCashBack;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Cash Back [AUS.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Cash Back")]
        public decimal? LogCashBack { get => _logCashBack; set => _logCashBack = value; }
        private DirtyValue<decimal?> _logCashOutAmount;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Cash Out Amount [AUS.X158]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Freddie Mac - Cash Out Amount")]
        public decimal? LogCashOutAmount { get => _logCashOutAmount; set => _logCashOutAmount = value; }
        private DirtyValue<decimal?> _logCLTV;
        /// <summary>
        /// AUS Tracking - CLTV [AUS.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - CLTV")]
        public decimal? LogCLTV { get => _logCLTV; set => _logCLTV = value; }
        private DirtyValue<decimal?> _logCoBorrowerAssetAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Amount [AUS.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - CoBorrower Asset Amount")]
        public decimal? LogCoBorrowerAssetAmount { get => _logCoBorrowerAssetAmount; set => _logCoBorrowerAssetAmount = value; }
        private DirtyValue<string> _logCoBorrowerAssetName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Name [AUS.X110]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Asset Name")]
        public string LogCoBorrowerAssetName { get => _logCoBorrowerAssetName; set => _logCoBorrowerAssetName = value; }
        private DirtyValue<string> _logCoBorrowerAssetType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Asset Type [AUS.X111]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Asset Type")]
        public string LogCoBorrowerAssetType { get => _logCoBorrowerAssetType; set => _logCoBorrowerAssetType = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 1 [AUS.X97]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Credit Score 1")]
        public string LogCoBorrowerCreditScore1 { get => _logCoBorrowerCreditScore1; set => _logCoBorrowerCreditScore1 = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 2 [AUS.X98]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Credit Score 2")]
        public string LogCoBorrowerCreditScore2 { get => _logCoBorrowerCreditScore2; set => _logCoBorrowerCreditScore2 = value; }
        private DirtyValue<string> _logCoBorrowerCreditScore3;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 3 [AUS.X99]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Credit Score 3")]
        public string LogCoBorrowerCreditScore3 { get => _logCoBorrowerCreditScore3; set => _logCoBorrowerCreditScore3 = value; }
        private DirtyValue<string> _logCoBorrowerEquifaxBEACON;
        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON [AUS.X137]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON")]
        public string LogCoBorrowerEquifaxBEACON { get => _logCoBorrowerEquifaxBEACON; set => _logCoBorrowerEquifaxBEACON = value; }
        private DirtyValue<string> _logCoBorrowerExperianFICO;
        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Experian FICO [AUS.X135]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - CoBorrower Experian FICO")]
        public string LogCoBorrowerExperianFICO { get => _logCoBorrowerExperianFICO; set => _logCoBorrowerExperianFICO = value; }
        private DirtyValue<decimal?> _logCoBorrowerIncomeAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Amount [AUS.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - CoBorrower Income Amount")]
        public decimal? LogCoBorrowerIncomeAmount { get => _logCoBorrowerIncomeAmount; set => _logCoBorrowerIncomeAmount = value; }
        private DirtyValue<string> _logCoBorrowerIncomeName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Name [AUS.X103]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Income Name")]
        public string LogCoBorrowerIncomeName { get => _logCoBorrowerIncomeName; set => _logCoBorrowerIncomeName = value; }
        private DirtyValue<string> _logCoBorrowerIncomeType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Income Type [AUS.X104]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Income Type")]
        public string LogCoBorrowerIncomeType { get => _logCoBorrowerIncomeType; set => _logCoBorrowerIncomeType = value; }
        private DirtyValue<string> _logCoBorrowerInstitutionName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Institution Name [AUS.X112]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Institution Name")]
        public string LogCoBorrowerInstitutionName { get => _logCoBorrowerInstitutionName; set => _logCoBorrowerInstitutionName = value; }
        private DirtyValue<string> _logCoborrowerName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Coborrower Name [AUS.X45]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Coborrower Name")]
        public string LogCoborrowerName { get => _logCoborrowerName; set => _logCoborrowerName = value; }
        private DirtyValue<string> _logCoBorrowerScoreName;
        /// <summary>
        /// AUS Tracking - Fannie Mae - CoBorrower Score Name 2 [AUS.X96]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - CoBorrower Score Name 2")]
        public string LogCoBorrowerScoreName { get => _logCoBorrowerScoreName; set => _logCoBorrowerScoreName = value; }
        private DirtyValue<string> _logCoBorrowerTransUnionEmpirica;
        /// <summary>
        /// AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica [AUS.X136]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica")]
        public string LogCoBorrowerTransUnionEmpirica { get => _logCoBorrowerTransUnionEmpirica; set => _logCoBorrowerTransUnionEmpirica = value; }
        private DirtyValue<string> _logCode1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Code 1 [AUS.X80]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Code 1")]
        public string LogCode1 { get => _logCode1; set => _logCode1 = value; }
        private DirtyValue<string> _logCode2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Code 2 [AUS.X82]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Code 2")]
        public string LogCode2 { get => _logCode2; set => _logCode2 = value; }
        private DirtyValue<string> _logCodeDescription1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Code Description 1 [AUS.X81]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Code Description 1")]
        public string LogCodeDescription1 { get => _logCodeDescription1; set => _logCodeDescription1 = value; }
        private DirtyValue<string> _logCodeDescription2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Code Description 2 [AUS.X83]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Code Description 2")]
        public string LogCodeDescription2 { get => _logCodeDescription2; set => _logCodeDescription2 = value; }
        private DirtyValue<string> _logCommunityLending;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Community Lending [AUS.X54]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Community Lending")]
        public string LogCommunityLending { get => _logCommunityLending; set => _logCommunityLending = value; }
        private DirtyValue<DateTime?> _logCreatedOn;
        /// <summary>
        /// AUSTrackingLog LogCreatedOn
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LogCreatedOn { get => _logCreatedOn; set => _logCreatedOn = value; }
        private DirtyValue<string> _logCreditAgency1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Agency 1 [AUS.X85]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Agency 1")]
        public string LogCreditAgency1 { get => _logCreditAgency1; set => _logCreditAgency1 = value; }
        private DirtyValue<string> _logCreditAgency2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Agency 2 [AUS.X89]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Agency 2")]
        public string LogCreditAgency2 { get => _logCreditAgency2; set => _logCreditAgency2 = value; }
        private DirtyValue<DateTime?> _logCreditReportDate1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report Date 1 [AUS.X87]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Report Date 1")]
        public DateTime? LogCreditReportDate1 { get => _logCreditReportDate1; set => _logCreditReportDate1 = value; }
        private DirtyValue<DateTime?> _logCreditReportDate2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report Date 2 [AUS.X91]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Report Date 2")]
        public DateTime? LogCreditReportDate2 { get => _logCreditReportDate2; set => _logCreditReportDate2 = value; }
        private DirtyValue<string> _logCreditReportID1;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report ID 1 [AUS.X86]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Report ID 1")]
        public string LogCreditReportID1 { get => _logCreditReportID1; set => _logCreditReportID1 = value; }
        private DirtyValue<string> _logCreditReportID2;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Credit Report ID 2 [AUS.X90]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Credit Report ID 2")]
        public string LogCreditReportID2 { get => _logCreditReportID2; set => _logCreditReportID2 = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _logCuredAmortizationType;
        /// <summary>
        /// Cured AUS Tracking - Amortization Type [AUS.CuredX22]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Amortization Type")]
        public StringEnumValue<AmortizationType> LogCuredAmortizationType { get => _logCuredAmortizationType; set => _logCuredAmortizationType = value; }
        private DirtyValue<int?> _logCuredAppraisedValue;
        /// <summary>
        /// Cured AUS Tracking - Appraised Value [AUS.CuredX18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Appraised Value")]
        public int? LogCuredAppraisedValue { get => _logCuredAppraisedValue; set => _logCuredAppraisedValue = value; }
        private DirtyValue<decimal?> _logCuredCLTV;
        /// <summary>
        /// CuredAUS Tracking - CLTV [AUS.CuredX12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "CuredAUS Tracking - CLTV")]
        public decimal? LogCuredCLTV { get => _logCuredCLTV; set => _logCuredCLTV = value; }
        private DirtyValue<decimal?> _logCuredHousingExpenseRatio;
        /// <summary>
        /// Cured AUS Tracking - Housing Expense Ratio [AUS.CuredX14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Cured AUS Tracking - Housing Expense Ratio")]
        public decimal? LogCuredHousingExpenseRatio { get => _logCuredHousingExpenseRatio; set => _logCuredHousingExpenseRatio = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logCuredLoanPurpose;
        /// <summary>
        /// Cured AUS Tracking - Loan Purpose [AUS.CuredX23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Loan Purpose")]
        public StringEnumValue<LoanPurposeType> LogCuredLoanPurpose { get => _logCuredLoanPurpose; set => _logCuredLoanPurpose = value; }
        private DirtyValue<int?> _logCuredLoanTerm;
        /// <summary>
        /// Cured AUS Tracking - Loan Term [AUS.CuredX21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Loan Term")]
        public int? LogCuredLoanTerm { get => _logCuredLoanTerm; set => _logCuredLoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _logCuredLoanType;
        /// <summary>
        /// Cured AUS Tracking - Loan Type [AUS.CuredX20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Loan Type")]
        public StringEnumValue<LoanType> LogCuredLoanType { get => _logCuredLoanType; set => _logCuredLoanType = value; }
        private DirtyValue<decimal?> _logCuredLTV;
        /// <summary>
        /// Cured AUS Tracking - LTV [AUS.CuredX11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Cured AUS Tracking - LTV")]
        public decimal? LogCuredLTV { get => _logCuredLTV; set => _logCuredLTV = value; }
        private DirtyValue<decimal?> _logCuredNoteRate;
        /// <summary>
        /// Cured AUS Tracking - Note Rate [AUS.CuredX19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Cured AUS Tracking - Note Rate")]
        public decimal? LogCuredNoteRate { get => _logCuredNoteRate; set => _logCuredNoteRate = value; }
        private DirtyValue<decimal?> _logCuredProposedTotalHousingPayment;
        /// <summary>
        /// Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.CuredX32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment")]
        public decimal? LogCuredProposedTotalHousingPayment { get => _logCuredProposedTotalHousingPayment; set => _logCuredProposedTotalHousingPayment = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logCuredRefinancePurpose;
        /// <summary>
        /// Cured AUS Tracking - Refinance Purpose [AUS.CuredX24]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cured AUS Tracking - Refinance Purpose")]
        public StringEnumValue<RefinancePurpose> LogCuredRefinancePurpose { get => _logCuredRefinancePurpose; set => _logCuredRefinancePurpose = value; }
        private DirtyValue<decimal?> _logCuredTotalExpenseRatio;
        /// <summary>
        /// Cured AUS Tracking - Total Expense Ratio [AUS.CuredX15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Cured AUS Tracking - Total Expense Ratio")]
        public decimal? LogCuredTotalExpenseRatio { get => _logCuredTotalExpenseRatio; set => _logCuredTotalExpenseRatio = value; }
        private DirtyValue<decimal?> _logCuredTotalLoanAmount;
        /// <summary>
        /// Cured AUS Tracking - Total Loan Amount [AUS.CuredX16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured AUS Tracking - Total Loan Amount")]
        public decimal? LogCuredTotalLoanAmount { get => _logCuredTotalLoanAmount; set => _logCuredTotalLoanAmount = value; }
        private DirtyValue<decimal?> _logCuredTotalMonthlyIncome;
        /// <summary>
        /// Cured AUS Tracking - Income / Assets - Total Monthly Income [AUS.CuredX41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured AUS Tracking - Income / Assets - Total Monthly Income")]
        public decimal? LogCuredTotalMonthlyIncome { get => _logCuredTotalMonthlyIncome; set => _logCuredTotalMonthlyIncome = value; }
        private DirtyValue<string> _logDateTimeAssessed;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Date Time Assessed [AUS.X169]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Date Time Assessed")]
        public string LogDateTimeAssessed { get => _logDateTimeAssessed; set => _logDateTimeAssessed = value; }
        private DirtyValue<string> _logDateTimeRequested;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Date Time Requested [AUS.X168]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Date Time Requested")]
        public string LogDateTimeRequested { get => _logDateTimeRequested; set => _logDateTimeRequested = value; }
        private DirtyValue<decimal?> _logDebtRatio;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Debt Ratio [AUS.X149]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - Debt Ratio")]
        public decimal? LogDebtRatio { get => _logDebtRatio; set => _logDebtRatio = value; }
        private DirtyValue<string> _logDocumentationLevel;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Documentation Level [AUS.X118]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Documentation Level")]
        public string LogDocumentationLevel { get => _logDocumentationLevel; set => _logDocumentationLevel = value; }
        private DirtyValue<string> _logDUCaseIDorLPAUSKey;
        /// <summary>
        /// AUS Tracking - DU Case ID/ LP AUS Key # [AUS.X7]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - DU Case ID/ LP AUS Key #")]
        public string LogDUCaseIDorLPAUSKey { get => _logDUCaseIDorLPAUSKey; set => _logDUCaseIDorLPAUSKey = value; }
        private DirtyValue<StringEnumValue<PropertyType>> _logDUPropertyType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Type [AUS.X50]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Property Type")]
        public StringEnumValue<PropertyType> LogDUPropertyType { get => _logDUPropertyType; set => _logDUPropertyType = value; }
        private DirtyValue<string> _logeFolderGUID;
        /// <summary>
        /// AUS Tracking - eFolder GUID [AUS.EFOLDERGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "AUS Tracking - eFolder GUID")]
        public string LogeFolderGUID { get => _logeFolderGUID; set => _logeFolderGUID = value; }
        private DirtyValue<decimal?> _logExcessAvailableAssetsNoVerified;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified [AUS.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified")]
        public decimal? LogExcessAvailableAssetsNoVerified { get => _logExcessAvailableAssetsNoVerified; set => _logExcessAvailableAssetsNoVerified = value; }
        private DirtyValue<decimal?> _logFinancedMIAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Financed MI Amount [AUS.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Financed MI Amount")]
        public decimal? LogFinancedMIAmount { get => _logFinancedMIAmount; set => _logFinancedMIAmount = value; }
        private DirtyValue<decimal?> _logFirstPandI;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - First P&amp;I [AUS.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - First P&I")]
        public decimal? LogFirstPandI { get => _logFirstPandI; set => _logFirstPandI = value; }
        private DirtyValue<DateTime?> _logFirstSubmissionDate;
        /// <summary>
        /// AUS Tracking - First Submission Date [AUS.X4]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - First Submission Date")]
        public DateTime? LogFirstSubmissionDate { get => _logFirstSubmissionDate; set => _logFirstSubmissionDate = value; }
        private DirtyValue<string> _logFirstSubmissionTime;
        /// <summary>
        /// AUS Tracking - First Submission Time [AUS.X174]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - First Submission Time")]
        public string LogFirstSubmissionTime { get => _logFirstSubmissionTime; set => _logFirstSubmissionTime = value; }
        private DirtyValue<string> _logFreddieDocClass;
        /// <summary>
        /// AUS Tracking - Doc Class (Freddie) [AUS.X10]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Doc Class (Freddie)")]
        public string LogFreddieDocClass { get => _logFreddieDocClass; set => _logFreddieDocClass = value; }
        private DirtyValue<decimal?> _logFundsRequiredClose;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Funds Required to Close [AUS.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Funds Required to Close")]
        public decimal? LogFundsRequiredClose { get => _logFundsRequiredClose; set => _logFundsRequiredClose = value; }
        private DirtyValue<string> _logGUID;
        /// <summary>
        /// AUSTrackingLog LogGUID
        /// </summary>
        public string LogGUID { get => _logGUID; set => _logGUID = value; }
        private DirtyValue<decimal?> _logHLCTV;
        /// <summary>
        /// AUS Tracking - HLCTV [AUS.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - HLCTV")]
        public decimal? LogHLCTV { get => _logHLCTV; set => _logHLCTV = value; }
        private DirtyValue<decimal?> _logHousingExpense;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Housing Expense [AUS.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Housing Expense")]
        public decimal? LogHousingExpense { get => _logHousingExpense; set => _logHousingExpense = value; }
        private DirtyValue<decimal?> _logHousingExpenseRatio;
        /// <summary>
        /// AUS Tracking - Housing Expense Ratio [AUS.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Housing Expense Ratio")]
        public decimal? LogHousingExpenseRatio { get => _logHousingExpenseRatio; set => _logHousingExpenseRatio = value; }
        private DirtyValue<decimal?> _logHousingRatio;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Housing Ratio [AUS.X148]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - Housing Ratio")]
        public decimal? LogHousingRatio { get => _logHousingRatio; set => _logHousingRatio = value; }
        private DirtyValue<decimal?> _logHTLTV;
        /// <summary>
        /// AUS Tracking - Freddie Mac - HTLTV [AUS.X147]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - HTLTV")]
        public decimal? LogHTLTV { get => _logHTLTV; set => _logHTLTV = value; }
        private DirtyValue<string> _logIncludingLess10Mos;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Including Less Than 10 Mos. [AUS.X67]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Including Less Than 10 Mos.")]
        public string LogIncludingLess10Mos { get => _logIncludingLess10Mos; set => _logIncludingLess10Mos = value; }
        private DirtyValue<decimal?> _logIncomeAssetBase;
        /// <summary>
        /// AUS Tracking - Income / Assets - Base [AUS.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Base")]
        public decimal? LogIncomeAssetBase { get => _logIncomeAssetBase; set => _logIncomeAssetBase = value; }
        private DirtyValue<decimal?> _logIncomeAssetBonus;
        /// <summary>
        /// AUS Tracking - Income / Assets - Bonus [AUS.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Bonus")]
        public decimal? LogIncomeAssetBonus { get => _logIncomeAssetBonus; set => _logIncomeAssetBonus = value; }
        private DirtyValue<decimal?> _logIncomeAssetCommission;
        /// <summary>
        /// AUS Tracking - Income / Assets - Commission [AUS.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Commission")]
        public decimal? LogIncomeAssetCommission { get => _logIncomeAssetCommission; set => _logIncomeAssetCommission = value; }
        private DirtyValue<decimal?> _logIncomeAssetOther;
        /// <summary>
        /// AUS Tracking - Income / Assets - Other [AUS.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Other")]
        public decimal? LogIncomeAssetOther { get => _logIncomeAssetOther; set => _logIncomeAssetOther = value; }
        private DirtyValue<decimal?> _logIncomeAssetOvertime;
        /// <summary>
        /// AUS Tracking - Income / Assets - Overtime [AUS.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Overtime")]
        public decimal? LogIncomeAssetOvertime { get => _logIncomeAssetOvertime; set => _logIncomeAssetOvertime = value; }
        private DirtyValue<decimal?> _logIncomeAssetPosCashFlow;
        /// <summary>
        /// AUS Tracking - Income / Assets - Subj. Pos. Cash Flow [AUS.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Subj. Pos. Cash Flow")]
        public decimal? LogIncomeAssetPosCashFlow { get => _logIncomeAssetPosCashFlow; set => _logIncomeAssetPosCashFlow = value; }
        private DirtyValue<decimal?> _logIncomeAssetPositiveNetRental;
        /// <summary>
        /// AUS Tracking - Income / Assets - Positive Net Rental [AUS.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Positive Net Rental")]
        public decimal? LogIncomeAssetPositiveNetRental { get => _logIncomeAssetPositiveNetRental; set => _logIncomeAssetPositiveNetRental = value; }
        private DirtyValue<string> _logIndicatorScore;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Indicator Score [AUS.X128]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Indicator Score")]
        public string LogIndicatorScore { get => _logIndicatorScore; set => _logIndicatorScore = value; }
        private DirtyValue<string> _logIntendedUseofProperty;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Intended Use of Property [AUS.X157]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Intended Use of Property")]
        public string LogIntendedUseofProperty { get => _logIntendedUseofProperty; set => _logIntendedUseofProperty = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion1;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1 [AUS.X185]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1")]
        public string LogLCLAEvaluatedServiceConclusion1 { get => _logLCLAEvaluatedServiceConclusion1; set => _logLCLAEvaluatedServiceConclusion1 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion2;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2 [AUS.X187]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2")]
        public string LogLCLAEvaluatedServiceConclusion2 { get => _logLCLAEvaluatedServiceConclusion2; set => _logLCLAEvaluatedServiceConclusion2 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion3;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3 [AUS.X189]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3")]
        public string LogLCLAEvaluatedServiceConclusion3 { get => _logLCLAEvaluatedServiceConclusion3; set => _logLCLAEvaluatedServiceConclusion3 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceConclusion4;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4 [AUS.X191]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4")]
        public string LogLCLAEvaluatedServiceConclusion4 { get => _logLCLAEvaluatedServiceConclusion4; set => _logLCLAEvaluatedServiceConclusion4 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType1>> _logLCLAEvaluatedServiceType1;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1 [AUS.X184]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1")]
        public StringEnumValue<LogLCLAEvaluatedServiceType1> LogLCLAEvaluatedServiceType1 { get => _logLCLAEvaluatedServiceType1; set => _logLCLAEvaluatedServiceType1 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType2>> _logLCLAEvaluatedServiceType2;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2 [AUS.X186]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2")]
        public StringEnumValue<LogLCLAEvaluatedServiceType2> LogLCLAEvaluatedServiceType2 { get => _logLCLAEvaluatedServiceType2; set => _logLCLAEvaluatedServiceType2 = value; }
        private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType3>> _logLCLAEvaluatedServiceType3;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3 [AUS.X188]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3")]
        public StringEnumValue<LogLCLAEvaluatedServiceType3> LogLCLAEvaluatedServiceType3 { get => _logLCLAEvaluatedServiceType3; set => _logLCLAEvaluatedServiceType3 = value; }
        private DirtyValue<string> _logLCLAEvaluatedServiceType4;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4 [AUS.X190]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4")]
        public string LogLCLAEvaluatedServiceType4 { get => _logLCLAEvaluatedServiceType4; set => _logLCLAEvaluatedServiceType4 = value; }
        private DirtyValue<string> _logLenderLoan;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Lender Loan # [AUS.X44]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Lender Loan #")]
        public string LogLenderLoan { get => _logLenderLoan; set => _logLenderLoan = value; }
        private DirtyValue<StringEnumValue<LienType>> _logLienType;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Lien Type [AUS.X56]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Lien Type")]
        public StringEnumValue<LienType> LogLienType { get => _logLienType; set => _logLienType = value; }
        private DirtyValue<decimal?> _logLoanAmount;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Loan Amount [AUS.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Loan Amount")]
        public decimal? LogLoanAmount { get => _logLoanAmount; set => _logLoanAmount = value; }
        private DirtyValue<string> _logLoanApplicationID;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Application # [AUS.X142]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Loan Application #")]
        public string LogLoanApplicationID { get => _logLoanApplicationID; set => _logLoanApplicationID = value; }
        private DirtyValue<string> _logLoanProcessingStage;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Processing Stage [AUS.X122]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Loan Processing Stage")]
        public string LogLoanProcessingStage { get => _logLoanProcessingStage; set => _logLoanProcessingStage = value; }
        private DirtyValue<string> _logLoanProspectorID;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Loan Prospector ID [AUS.X115]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Loan Prospector ID")]
        public string LogLoanProspectorID { get => _logLoanProspectorID; set => _logLoanProspectorID = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _logLoanPurpose;
        /// <summary>
        /// AUS Tracking - Loan Purpose [AUS.X23]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Loan Purpose")]
        public StringEnumValue<LoanPurposeType> LogLoanPurpose { get => _logLoanPurpose; set => _logLoanPurpose = value; }
        private DirtyValue<int?> _logLoanTerm;
        /// <summary>
        /// AUS Tracking - Loan Term [AUS.X21]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Loan Term")]
        public int? LogLoanTerm { get => _logLoanTerm; set => _logLoanTerm = value; }
        private DirtyValue<StringEnumValue<LoanType>> _logLoanType;
        /// <summary>
        /// AUS Tracking - Loan Type [AUS.X20]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Loan Type")]
        public StringEnumValue<LoanType> LogLoanType { get => _logLoanType; set => _logLoanType = value; }
        private DirtyValue<DateTime?> _logLPAssmtExpDate;
        /// <summary>
        /// AUS Tracking - Freddie Mac - LP Assmt. Exp. Date [AUS.X131]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - LP Assmt. Exp. Date")]
        public DateTime? LogLPAssmtExpDate { get => _logLPAssmtExpDate; set => _logLPAssmtExpDate = value; }
        private DirtyValue<StringEnumValue<OtherPropertyType>> _logLPPropertyType;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Property Type [AUS.X172]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Property Type")]
        public StringEnumValue<OtherPropertyType> LogLPPropertyType { get => _logLPPropertyType; set => _logLPPropertyType = value; }
        private DirtyValue<string> _logLPVersion;
        /// <summary>
        /// AUS Tracking - Freddie Mac - LP Version [AUS.X124]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - LP Version")]
        public string LogLPVersion { get => _logLPVersion; set => _logLPVersion = value; }
        private DirtyValue<string> _logLQACollateralRepWarrantyServiceConclusion;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion [AUS.X183]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion")]
        public string LogLQACollateralRepWarrantyServiceConclusion { get => _logLQACollateralRepWarrantyServiceConclusion; set => _logLQACollateralRepWarrantyServiceConclusion = value; }
        private DirtyValue<string> _logLQACreditRiskAssessmentConclusion;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion [AUS.X181]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion")]
        public string LogLQACreditRiskAssessmentConclusion { get => _logLQACreditRiskAssessmentConclusion; set => _logLQACreditRiskAssessmentConclusion = value; }
        private DirtyValue<string> _logLQADataCompareFieldConclusion;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion [AUS.X179]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion")]
        public string LogLQADataCompareFieldConclusion { get => _logLQADataCompareFieldConclusion; set => _logLQADataCompareFieldConclusion = value; }
        private DirtyValue<string> _logLQADataCompareFieldName;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Field Name [AUS.X178]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Data Compare Field Name")]
        public string LogLQADataCompareFieldName { get => _logLQADataCompareFieldName; set => _logLQADataCompareFieldName = value; }
        private DirtyValue<string> _logLQADataCompareResult;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Data Compare Result [AUS.X175]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Data Compare Result")]
        public string LogLQADataCompareResult { get => _logLQADataCompareResult; set => _logLQADataCompareResult = value; }
        private DirtyValue<string> _logLQALPKey;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - LP Key [AUS.X176]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - LP Key")]
        public string LogLQALPKey { get => _logLQALPKey; set => _logLQALPKey = value; }
        private DirtyValue<string> _logLQAPurchaseEligibilityResult;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result [AUS.X182]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result")]
        public string LogLQAPurchaseEligibilityResult { get => _logLQAPurchaseEligibilityResult; set => _logLQAPurchaseEligibilityResult = value; }
        private DirtyValue<string> _logLQARiskAssessmentKey;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Risk Assessment Key [AUS.X180]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LQA - Risk Assessment Key")]
        public string LogLQARiskAssessmentKey { get => _logLQARiskAssessmentKey; set => _logLQARiskAssessmentKey = value; }
        private DirtyValue<DateTime?> _logLQASubmissionDateTime;
        /// <summary>
        /// AUS Tracking - Freddie Mac LQA - Submission DateTime [AUS.X177]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, Description = "AUS Tracking - Freddie Mac LQA - Submission DateTime")]
        public DateTime? LogLQASubmissionDateTime { get => _logLQASubmissionDateTime; set => _logLQASubmissionDateTime = value; }
        private DirtyValue<decimal?> _logLTV;
        /// <summary>
        /// AUS Tracking - LTV [AUS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - LTV")]
        public decimal? LogLTV { get => _logLTV; set => _logLTV = value; }
        private DirtyValue<decimal?> _logMaxMortgageLimit;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Max Mortgage Limit [AUS.X162]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Freddie Mac - Max Mortgage Limit")]
        public decimal? LogMaxMortgageLimit { get => _logMaxMortgageLimit; set => _logMaxMortgageLimit = value; }
        private DirtyValue<string> _logMIDecision;
        /// <summary>
        /// AUS Tracking - Freddie Mac - MI Decision [AUS.X126]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - MI Decision")]
        public string LogMIDecision { get => _logMIDecision; set => _logMIDecision = value; }
        private DirtyValue<string> _logMortgageType;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Mortgage Type [AUS.X119]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Mortgage Type")]
        public string LogMortgageType { get => _logMortgageType; set => _logMortgageType = value; }
        private DirtyValue<string> _logNegAmortizationType;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Neg. Amortization Type [AUS.X152]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Neg. Amortization Type")]
        public string LogNegAmortizationType { get => _logNegAmortizationType; set => _logNegAmortizationType = value; }
        private DirtyValue<decimal?> _logNegativeNetRental;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Negative Net Rental [AUS.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Negative Net Rental")]
        public decimal? LogNegativeNetRental { get => _logNegativeNetRental; set => _logNegativeNetRental = value; }
        private DirtyValue<decimal?> _logNetCashBack;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Net Cash Back [AUS.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Net Cash Back")]
        public decimal? LogNetCashBack { get => _logNetCashBack; set => _logNetCashBack = value; }
        private DirtyValue<string> _logNewConstruction;
        /// <summary>
        /// AUS Tracking - Freddie Mac - New Construction [AUS.X154]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - New Construction")]
        public string LogNewConstruction { get => _logNewConstruction; set => _logNewConstruction = value; }
        private DirtyValue<decimal?> _logNoteRate;
        /// <summary>
        /// AUS Tracking - Note Rate [AUS.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Note Rate")]
        public decimal? LogNoteRate { get => _logNoteRate; set => _logNoteRate = value; }
        private DirtyValue<string> _logNOTPNumber;
        /// <summary>
        /// AUS Tracking - Freddie Mac - NOTP Number [AUS.X171]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - NOTP Number")]
        public string LogNOTPNumber { get => _logNOTPNumber; set => _logNOTPNumber = value; }
        private DirtyValue<int?> _logNoUnits;
        /// <summary>
        /// AUS Tracking - Fannie Mae - No Units [AUS.X51]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - No Units")]
        public int? LogNoUnits { get => _logNoUnits; set => _logNoUnits = value; }
        private DirtyValue<string> _logNumberOfSubmissions;
        /// <summary>
        /// AUS Tracking - Freddie Mac - # of Submissions [AUS.X170]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - # of Submissions")]
        public string LogNumberOfSubmissions { get => _logNumberOfSubmissions; set => _logNumberOfSubmissions = value; }
        private DirtyValue<string> _logOccupancyStatus;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Occupancy Status [AUS.X52]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Occupancy Status")]
        public string LogOccupancyStatus { get => _logOccupancyStatus; set => _logOccupancyStatus = value; }
        private DirtyValue<decimal?> _logOccupantDebtRatio;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Occupant Debt Ratio [AUS.X151]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - Occupant Debt Ratio")]
        public decimal? LogOccupantDebtRatio { get => _logOccupantDebtRatio; set => _logOccupantDebtRatio = value; }
        private DirtyValue<decimal?> _logOccupantHousingRatio;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Occupant Housing Ratio [AUS.X150]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - Occupant Housing Ratio")]
        public decimal? LogOccupantHousingRatio { get => _logOccupantHousingRatio; set => _logOccupantHousingRatio = value; }
        private DirtyValue<string> _logOfferingIdentifier;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Offering Identifier [AUS.X156]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Offering Identifier")]
        public string LogOfferingIdentifier { get => _logOfferingIdentifier; set => _logOfferingIdentifier = value; }
        private DirtyValue<string> _logOriginatingCompany;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Originating Company [AUS.X164]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Originating Company")]
        public string LogOriginatingCompany { get => _logOriginatingCompany; set => _logOriginatingCompany = value; }
        private DirtyValue<decimal?> _logOwnerExistingMtg;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Owner Existing Mtg. [AUS.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Owner Existing Mtg.")]
        public decimal? LogOwnerExistingMtg { get => _logOwnerExistingMtg; set => _logOwnerExistingMtg = value; }
        private DirtyValue<decimal?> _logPandI;
        /// <summary>
        /// AUS Tracking - Fannie Mae - P &amp; I [AUS.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - P & I")]
        public decimal? LogPandI { get => _logPandI; set => _logPandI = value; }
        private DirtyValue<int?> _logPaymentFrequency;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Payment Frequency [AUS.X55]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Payment Frequency")]
        public int? LogPaymentFrequency { get => _logPaymentFrequency; set => _logPaymentFrequency = value; }
        private DirtyValue<string> _logPresentAddress;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address [AUS.X138]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Present Address")]
        public string LogPresentAddress { get => _logPresentAddress; set => _logPresentAddress = value; }
        private DirtyValue<string> _logPresentAddressCity;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address City [AUS.X139]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Present Address City")]
        public string LogPresentAddressCity { get => _logPresentAddressCity; set => _logPresentAddressCity = value; }
        private DirtyValue<StringEnumValue<State>> _logPresentAddressState;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address State [AUS.X140]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Present Address State")]
        public StringEnumValue<State> LogPresentAddressState { get => _logPresentAddressState; set => _logPresentAddressState = value; }
        private DirtyValue<string> _logPresentAddressZipCode;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Address Zipcode [AUS.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "AUS Tracking - Freddie Mac - Present Address Zipcode")]
        public string LogPresentAddressZipCode { get => _logPresentAddressZipCode; set => _logPresentAddressZipCode = value; }
        private DirtyValue<decimal?> _logPresentHousingExpense;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Present Housing Expense [AUS.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Freddie Mac - Present Housing Expense")]
        public decimal? LogPresentHousingExpense { get => _logPresentHousingExpense; set => _logPresentHousingExpense = value; }
        private DirtyValue<decimal?> _logPresentPrincipalHousingPayment;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Present/Principal Housing Payment [AUS.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Present/Principal Housing Payment")]
        public decimal? LogPresentPrincipalHousingPayment { get => _logPresentPrincipalHousingPayment; set => _logPresentPrincipalHousingPayment = value; }
        private DirtyValue<string> _logPropertyAddress;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Address [AUS.X46]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Property Address")]
        public string LogPropertyAddress { get => _logPropertyAddress; set => _logPropertyAddress = value; }
        private DirtyValue<string> _logPropertyCity;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Property City [AUS.X47]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Property City")]
        public string LogPropertyCity { get => _logPropertyCity; set => _logPropertyCity = value; }
        private DirtyValue<StringEnumValue<State>> _logPropertyState;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Property State [AUS.X48]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - Property State")]
        public StringEnumValue<State> LogPropertyState { get => _logPropertyState; set => _logPropertyState = value; }
        private DirtyValue<string> _logPropertyZipcode;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Property Zipcode [AUS.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "AUS Tracking - Fannie Mae - Property Zipcode")]
        public string LogPropertyZipcode { get => _logPropertyZipcode; set => _logPropertyZipcode = value; }
        private DirtyValue<decimal?> _logProposedHazardInsurance;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance [AUS.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance")]
        public decimal? LogProposedHazardInsurance { get => _logProposedHazardInsurance; set => _logProposedHazardInsurance = value; }
        private DirtyValue<decimal?> _logProposedHOAFees;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees [AUS.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees")]
        public decimal? LogProposedHOAFees { get => _logProposedHOAFees; set => _logProposedHOAFees = value; }
        private DirtyValue<decimal?> _logProposedHousingPITI;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Proposed Housing (PITI) [AUS.X160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Freddie Mac - Proposed Housing (PITI)")]
        public decimal? LogProposedHousingPITI { get => _logProposedHousingPITI; set => _logProposedHousingPITI = value; }
        private DirtyValue<decimal?> _logProposedMortgageInsurance;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance [AUS.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance")]
        public decimal? LogProposedMortgageInsurance { get => _logProposedMortgageInsurance; set => _logProposedMortgageInsurance = value; }
        private DirtyValue<decimal?> _logProposedOtherPayment;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Other [AUS.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Other")]
        public decimal? LogProposedOtherPayment { get => _logProposedOtherPayment; set => _logProposedOtherPayment = value; }
        private DirtyValue<decimal?> _logProposedTaxes;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Taxes [AUS.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Taxes")]
        public decimal? LogProposedTaxes { get => _logProposedTaxes; set => _logProposedTaxes = value; }
        private DirtyValue<decimal?> _logProposedTotalHousingPayment;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment")]
        public decimal? LogProposedTotalHousingPayment { get => _logProposedTotalHousingPayment; set => _logProposedTotalHousingPayment = value; }
        private DirtyValue<decimal?> _logProposedTotalMonthlyDebt;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt [AUS.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt")]
        public decimal? LogProposedTotalMonthlyDebt { get => _logProposedTotalMonthlyDebt; set => _logProposedTotalMonthlyDebt = value; }
        private DirtyValue<string> _logPurchaseEligibility;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Purchase Eligibility [AUS.X120]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Purchase Eligibility")]
        public string LogPurchaseEligibility { get => _logPurchaseEligibility; set => _logPurchaseEligibility = value; }
        private DirtyValue<decimal?> _logQualifyingRate;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Qualifying Rate [AUS.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Fannie Mae - Qualifying Rate")]
        public decimal? LogQualifyingRate { get => _logQualifyingRate; set => _logQualifyingRate = value; }
        private DirtyValue<string> _logRecordType;
        /// <summary>
        /// AUSTrackingLog LogRecordType
        /// </summary>
        public string LogRecordType { get => _logRecordType; set => _logRecordType = value; }
        private DirtyValue<StringEnumValue<RefinancePurpose>> _logRefinancePurpose;
        /// <summary>
        /// AUS Tracking - Refinance Purpose [AUS.X24]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Refinance Purpose")]
        public StringEnumValue<RefinancePurpose> LogRefinancePurpose { get => _logRefinancePurpose; set => _logRefinancePurpose = value; }
        private DirtyValue<decimal?> _logReserves;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Reserves [AUS.X159]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Freddie Mac - Reserves")]
        public decimal? LogReserves { get => _logReserves; set => _logReserves = value; }
        private DirtyValue<decimal?> _logReservesRequiredVerified;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified [AUS.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified")]
        public decimal? LogReservesRequiredVerified { get => _logReservesRequiredVerified; set => _logReservesRequiredVerified = value; }
        private DirtyValue<string> _logRiskClass;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Risk Class [AUS.X117]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Risk Class")]
        public string LogRiskClass { get => _logRiskClass; set => _logRiskClass = value; }
        private DirtyValue<string> _logSalesConcessions;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Sales Concessions [AUS.X163]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Sales Concessions")]
        public string LogSalesConcessions { get => _logSalesConcessions; set => _logSalesConcessions = value; }
        private DirtyValue<decimal?> _logSalesPrice;
        /// <summary>
        /// AUS Tracking - Sales Price [AUS.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Sales Price")]
        public decimal? LogSalesPrice { get => _logSalesPrice; set => _logSalesPrice = value; }
        private DirtyValue<decimal?> _logSecondPandI;
        /// <summary>
        /// AUS Tracking - Proposed Monthly Payment / Debt - Second P&amp;I [AUS.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Proposed Monthly Payment / Debt - Second P&I")]
        public decimal? LogSecondPandI { get => _logSecondPandI; set => _logSecondPandI = value; }
        private DirtyValue<string> _logSelectedBorrower;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Selected Borrower [AUS.X130]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Selected Borrower")]
        public string LogSelectedBorrower { get => _logSelectedBorrower; set => _logSelectedBorrower = value; }
        private DirtyValue<string> _logSelectedRepository;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Selected Repository [AUS.X129]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Selected Repository")]
        public string LogSelectedRepository { get => _logSelectedRepository; set => _logSelectedRepository = value; }
        private DirtyValue<string> _logSellerNumber;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Seller Number [AUS.X166]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Seller Number")]
        public string LogSellerNumber { get => _logSellerNumber; set => _logSellerNumber = value; }
        private DirtyValue<decimal?> _logSubjNegCashFlow;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow [AUS.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow")]
        public decimal? LogSubjNegCashFlow { get => _logSubjNegCashFlow; set => _logSubjNegCashFlow = value; }
        private DirtyValue<DateTime?> _logSubmissionDate;
        /// <summary>
        /// AUS Tracking - Submission Date [AUS.X3]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Submission Date")]
        public DateTime? LogSubmissionDate { get => _logSubmissionDate; set => _logSubmissionDate = value; }
        private DirtyValue<string> _logSubmissionNumber;
        /// <summary>
        /// AUS Tracking - Submission Number [AUS.X5]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Submission Number")]
        public string LogSubmissionNumber { get => _logSubmissionNumber; set => _logSubmissionNumber = value; }
        private DirtyValue<string> _logSubmissionTime;
        /// <summary>
        /// AUS Tracking - Submission Time [AUS.X173]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Submission Time")]
        public string LogSubmissionTime { get => _logSubmissionTime; set => _logSubmissionTime = value; }
        private DirtyValue<string> _logSubmittedBy;
        /// <summary>
        /// AUS Tracking - Submitted By [AUS.X8]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Submitted By")]
        public string LogSubmittedBy { get => _logSubmittedBy; set => _logSubmittedBy = value; }
        private DirtyValue<string> _logSubmittingCompany;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Submitting Company [AUS.X165]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Submitting Company")]
        public string LogSubmittingCompany { get => _logSubmittingCompany; set => _logSubmittingCompany = value; }
        private DirtyValue<string> _logTemporarySubsidyBuydown;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Temporary Subsidy Buydown [AUS.X153]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Temporary Subsidy Buydown")]
        public string LogTemporarySubsidyBuydown { get => _logTemporarySubsidyBuydown; set => _logTemporarySubsidyBuydown = value; }
        private DirtyValue<decimal?> _logTLTV;
        /// <summary>
        /// AUS Tracking - Freddie Mac - TLTV [AUS.X146]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Freddie Mac - TLTV")]
        public decimal? LogTLTV { get => _logTLTV; set => _logTLTV = value; }
        private DirtyValue<decimal?> _logTotalAsset;
        /// <summary>
        /// AUS Tracking - Income / Assets - Total Assets [AUS.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Total Assets")]
        public decimal? LogTotalAsset { get => _logTotalAsset; set => _logTotalAsset = value; }
        private DirtyValue<decimal?> _logTotalExpense;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Expense [AUS.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Total Expense")]
        public decimal? LogTotalExpense { get => _logTotalExpense; set => _logTotalExpense = value; }
        private DirtyValue<decimal?> _logTotalExpensePmt;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Expense Pmt [AUS.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Total Expense Pmt")]
        public decimal? LogTotalExpensePmt { get => _logTotalExpensePmt; set => _logTotalExpensePmt = value; }
        private DirtyValue<decimal?> _logTotalExpenseRatio;
        /// <summary>
        /// AUS Tracking - Total Expense Ratio [AUS.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "AUS Tracking - Total Expense Ratio")]
        public decimal? LogTotalExpenseRatio { get => _logTotalExpenseRatio; set => _logTotalExpenseRatio = value; }
        private DirtyValue<decimal?> _logTotalFundsVerified;
        /// <summary>
        /// AUS Tracking - Fannie Mae - Total Funds to be Verified [AUS.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Fannie Mae - Total Funds to be Verified")]
        public decimal? LogTotalFundsVerified { get => _logTotalFundsVerified; set => _logTotalFundsVerified = value; }
        private DirtyValue<decimal?> _logTotalLoanAmount;
        /// <summary>
        /// AUS Tracking - Total Loan Amount [AUS.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Total Loan Amount")]
        public decimal? LogTotalLoanAmount { get => _logTotalLoanAmount; set => _logTotalLoanAmount = value; }
        private DirtyValue<decimal?> _logTotalMonthlyIncome;
        /// <summary>
        /// AUS Tracking - Income / Assets - Total Monthly Income [AUS.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AUS Tracking - Income / Assets - Total Monthly Income")]
        public decimal? LogTotalMonthlyIncome { get => _logTotalMonthlyIncome; set => _logTotalMonthlyIncome = value; }
        private DirtyValue<string> _logTPONumber;
        /// <summary>
        /// AUS Tracking - Freddie Mac - TPO Number [AUS.X167]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - TPO Number")]
        public string LogTPONumber { get => _logTPONumber; set => _logTPONumber = value; }
        private DirtyValue<string> _logTransactionID;
        /// <summary>
        /// AUS Tracking - Freddie Mac - Transaction ID [AUS.X116]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac - Transaction ID")]
        public string LogTransactionID { get => _logTransactionID; set => _logTransactionID = value; }
        private DirtyValue<string> _logUnderwritingRiskAssessOther;
        /// <summary>
        /// AUS Tracking - Underwriting Risk Assess Other Type [AUS.X2]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Underwriting Risk Assess Other Type")]
        public string LogUnderwritingRiskAssessOther { get => _logUnderwritingRiskAssessOther; set => _logUnderwritingRiskAssessOther = value; }
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _logUnderwritingRiskAssessType;
        /// <summary>
        /// AUS Tracking - Underwriting Risk Assess Type [AUS.X1]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Underwriting Risk Assess Type")]
        public StringEnumValue<RiskAssessmentType> LogUnderwritingRiskAssessType { get => _logUnderwritingRiskAssessType; set => _logUnderwritingRiskAssessType = value; }
        private DirtyValue<string> _logWithUndisclosedDebt;
        /// <summary>
        /// AUS Tracking - Fannie Mae - With Undisclosed Debt [AUS.X68]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Fannie Mae - With Undisclosed Debt")]
        public string LogWithUndisclosedDebt { get => _logWithUndisclosedDebt; set => _logWithUndisclosedDebt = value; }
        internal override bool DirtyInternal
        {
            get => _aUSTrackingLogIndex.Dirty
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