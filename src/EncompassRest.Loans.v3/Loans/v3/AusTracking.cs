using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AusTracking
/// </summary>
public sealed partial class AusTracking : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _acceptPlusEligible;
    private DirtyValue<string?>? _affordableProductType;
    private DirtyValue<decimal?>? _allOtherPayments;
    private DirtyValue<int?>? _amortizationMonths;
    private DirtyValue<StringEnumValue<AmortizationType>>? _amortizationType;
    private DirtyValue<decimal?>? _amtSubordinateFin;
    private DirtyValue<string?>? _appraisalTypeMaf;
    private DirtyValue<int?>? _appraisedValue;
    private DirtyValue<decimal?>? _armQualifyingRate;
    private DirtyValue<DateTime?>? _assessedDateTime;
    private DirtyValue<string?>? _assessmentType;
    private DirtyValue<string?>? _ausLogExtensionId;
    private DirtyValue<string?>? _ausOrderLinkId;
    private DirtyValue<string?>? _ausRecommendation;
    private DirtyValue<string?>? _ausResponseFileName;
    private DirtyValue<string?>? _ausStatus;
    private DirtyValue<StringEnumValue<LogAUSTrackingType>>? _ausTrackingType;
    private DirtyValue<string?>? _ausTransactionId;
    private DirtyValue<string?>? _ausVersion;
    private DirtyValue<string?>? _balloon;
    private DirtyValue<int?>? _balloonTerm;
    private DirtyValue<decimal?>? _borrowerAssetAmount;
    private DirtyValue<string?>? _borrowerAssetName;
    private DirtyValue<string?>? _borrowerAssetType;
    private DirtyValue<string?>? _borrowerCreditScore1;
    private DirtyValue<string?>? _borrowerCreditScore2;
    private DirtyValue<string?>? _borrowerCreditScore3;
    private DirtyValue<string?>? _borrowerEquifaxBeacon;
    private DirtyValue<string?>? _borrowerExperianFico;
    private DirtyValue<decimal?>? _borrowerIncomeAmount;
    private DirtyValue<string?>? _borrowerIncomeName;
    private DirtyValue<string?>? _borrowerIncomeType;
    private DirtyValue<string?>? _borrowerInstitutionName;
    private DirtyValue<string?>? _borrowerName;
    private DirtyValue<string?>? _borrowerScoreName;
    private DirtyValue<string?>? _borrowerTransUnionEmpirica;
    private DirtyValue<string?>? _borrowerType1;
    private DirtyValue<string?>? _borrowerType2;
    private DirtyValue<decimal?>? _boughtDownRate;
    private DirtyValue<string?>? _buydown;
    private DirtyValue<decimal?>? _cashBack;
    private DirtyValue<decimal?>? _cashOutAmount;
    private DirtyValue<decimal?>? _cltv;
    private DirtyValue<decimal?>? _coBorrowerAssetAmount;
    private DirtyValue<string?>? _coBorrowerAssetName;
    private DirtyValue<string?>? _coBorrowerAssetType;
    private DirtyValue<string?>? _coBorrowerCreditScore1;
    private DirtyValue<string?>? _coBorrowerCreditScore2;
    private DirtyValue<string?>? _coBorrowerCreditScore3;
    private DirtyValue<string?>? _coBorrowerEquifaxBeacon;
    private DirtyValue<string?>? _coBorrowerExperianFico;
    private DirtyValue<decimal?>? _coBorrowerIncomeAmount;
    private DirtyValue<string?>? _coBorrowerIncomeName;
    private DirtyValue<string?>? _coBorrowerIncomeType;
    private DirtyValue<string?>? _coBorrowerInstitutionName;
    private DirtyValue<string?>? _coborrowerName;
    private DirtyValue<string?>? _coBorrowerScoreName;
    private DirtyValue<string?>? _coBorrowerTransUnionEmpirica;
    private DirtyValue<string?>? _code1;
    private DirtyValue<string?>? _code2;
    private DirtyValue<string?>? _codeDescription1;
    private DirtyValue<string?>? _codeDescription2;
    private DirtyValue<string?>? _communityLending;
    private DirtyValue<DateTime?>? _createdOn;
    private DirtyValue<string?>? _creditAgency1;
    private DirtyValue<string?>? _creditAgency2;
    private DirtyValue<DateTime?>? _creditReportDate1;
    private DirtyValue<DateTime?>? _creditReportDate2;
    private DirtyValue<string?>? _creditReportId1;
    private DirtyValue<string?>? _creditReportId2;
    private DirtyValue<StringEnumValue<AmortizationType>>? _curedAmortizationType;
    private DirtyValue<int?>? _curedAppraisedValue;
    private DirtyValue<decimal?>? _curedCltv;
    private DirtyValue<decimal?>? _curedHousingExpenseRatio;
    private DirtyValue<StringEnumValue<LoanPurposeType>>? _curedLoanPurpose;
    private DirtyValue<int?>? _curedLoanTerm;
    private DirtyValue<StringEnumValue<LoanType>>? _curedLoanType;
    private DirtyValue<decimal?>? _curedLtv;
    private DirtyValue<decimal?>? _curedNoteRate;
    private DirtyValue<decimal?>? _curedProposedTotalHousingPayment;
    private DirtyValue<StringEnumValue<RefinancePurpose>>? _curedRefinancePurpose;
    private DirtyValue<decimal?>? _curedTotalExpenseRatio;
    private DirtyValue<decimal?>? _curedTotalLoanAmount;
    private DirtyValue<decimal?>? _curedTotalMonthlyIncome;
    private DirtyValue<decimal?>? _debtRatio;
    private DirtyValue<string?>? _documentationLevel;
    private DirtyValue<string?>? _duCaseIdorLpausKey;
    private DirtyValue<StringEnumValue<PropertyType>>? _duPropertyType;
    private DirtyValue<string?>? _eFolderGuid;
    private DirtyValue<string?>? _errorInfo;
    private DirtyValue<decimal?>? _excessAvailableAssetsNoVerified;
    private DirtyValue<string?>? _fatalEditInfo;
    private DirtyValue<StringEnumValue<LogFileType>>? _fileType;
    private DirtyValue<decimal?>? _financedMiAmount;
    private DirtyValue<decimal?>? _firstPandI;
    private DirtyValue<DateTime?>? _firstSubmissionDate;
    private DirtyValue<string?>? _firstSubmissionTime;
    private DirtyValue<string?>? _freddieDocClass;
    private DirtyValue<decimal?>? _fundsRequiredClose;
    private DirtyValue<decimal?>? _hlctv;
    private DirtyValue<decimal?>? _housingExpense;
    private DirtyValue<decimal?>? _housingExpenseRatio;
    private DirtyValue<decimal?>? _housingRatio;
    private DirtyValue<decimal?>? _htltv;
    private DirtyValue<string?>? _includingLess10Mos;
    private DirtyValue<decimal?>? _incomeAssetBase;
    private DirtyValue<decimal?>? _incomeAssetBonus;
    private DirtyValue<decimal?>? _incomeAssetCommission;
    private DirtyValue<decimal?>? _incomeAssetOther;
    private DirtyValue<decimal?>? _incomeAssetOvertime;
    private DirtyValue<decimal?>? _incomeAssetPosCashFlow;
    private DirtyValue<decimal?>? _incomeAssetPositiveNetRental;
    private DirtyValue<string?>? _indicatorScore;
    private DirtyValue<string?>? _intendedUseofProperty;
    private DirtyValue<string?>? _lclaEvaluatedServiceConclusion1;
    private DirtyValue<string?>? _lclaEvaluatedServiceConclusion2;
    private DirtyValue<string?>? _lclaEvaluatedServiceConclusion3;
    private DirtyValue<string?>? _lclaEvaluatedServiceConclusion4;
    private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType1>>? _lclaEvaluatedServiceType1;
    private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType2>>? _lclaEvaluatedServiceType2;
    private DirtyValue<StringEnumValue<LogLCLAEvaluatedServiceType3>>? _lclaEvaluatedServiceType3;
    private DirtyValue<string?>? _lclaEvaluatedServiceType4;
    private DirtyValue<string?>? _lenderLoan;
    private DirtyValue<StringEnumValue<LienType>>? _lienType;
    private DirtyValue<decimal?>? _loanAmount;
    private DirtyValue<string?>? _loanApplicationId;
    private DirtyValue<string?>? _loanProcessingStage;
    private DirtyValue<string?>? _loanProspectorId;
    private DirtyValue<StringEnumValue<LoanPurposeType>>? _loanPurpose;
    private DirtyValue<int?>? _loanTerm;
    private DirtyValue<StringEnumValue<LoanType>>? _loanType;
    private DirtyValue<DateTime?>? _lpAssmtExpDate;
    private DirtyValue<StringEnumValue<OtherPropertyType>>? _lpPropertyType;
    private DirtyValue<string?>? _lpVersion;
    private DirtyValue<string?>? _lqaCollateralRepWarrantyServiceConclusion;
    private DirtyValue<string?>? _lqaCreditRiskAssessmentConclusion;
    private DirtyValue<string?>? _lqaDataCompareFieldConclusion;
    private DirtyValue<string?>? _lqaDataCompareFieldName;
    private DirtyValue<string?>? _lqaDataCompareResult;
    private DirtyValue<string?>? _lqalpKey;
    private DirtyValue<string?>? _lqaPurchaseEligibilityResult;
    private DirtyValue<string?>? _lqaRiskAssessmentKey;
    private DirtyValue<DateTime?>? _lqaSubmissionDateTime;
    private DirtyValue<decimal?>? _ltv;
    private DirtyValue<decimal?>? _maxMortgageLimit;
    private DirtyValue<string?>? _miDecision;
    private DirtyValue<string?>? _mortgageType;
    private DirtyValue<string?>? _negAmortizationType;
    private DirtyValue<decimal?>? _negativeNetRental;
    private DirtyValue<decimal?>? _netCashBack;
    private DirtyValue<string?>? _newConstruction;
    private DirtyValue<decimal?>? _noteRate;
    private DirtyValue<string?>? _notpNumber;
    private DirtyValue<int?>? _noUnits;
    private DirtyValue<string?>? _numberOfSubmissions;
    private DirtyValue<string?>? _occupancyStatus;
    private DirtyValue<decimal?>? _occupantDebtRatio;
    private DirtyValue<decimal?>? _occupantHousingRatio;
    private DirtyValue<string?>? _offeringIdentifier;
    private DirtyValue<string?>? _orderStatus;
    private DirtyValue<string?>? _originatingCompany;
    private DirtyValue<decimal?>? _ownerExistingMtg;
    private DirtyValue<decimal?>? _pandI;
    private DirtyValue<int?>? _paymentFrequency;
    private DirtyValue<string?>? _presentAddress;
    private DirtyValue<string?>? _presentAddressCity;
    private DirtyValue<string?>? _presentAddressState;
    private DirtyValue<string?>? _presentAddressZipCode;
    private DirtyValue<decimal?>? _presentHousingExpense;
    private DirtyValue<decimal?>? _presentPrincipalHousingPayment;
    private DirtyValue<string?>? _propertyAddress;
    private DirtyValue<string?>? _propertyCity;
    private DirtyValue<string?>? _propertyState;
    private DirtyValue<string?>? _propertyZipcode;
    private DirtyValue<decimal?>? _proposedHazardInsurance;
    private DirtyValue<decimal?>? _proposedHoaFees;
    private DirtyValue<decimal?>? _proposedHousingPiti;
    private DirtyValue<decimal?>? _proposedMortgageInsurance;
    private DirtyValue<decimal?>? _proposedOtherPayment;
    private DirtyValue<decimal?>? _proposedTaxes;
    private DirtyValue<decimal?>? _proposedTotalHousingPayment;
    private DirtyValue<decimal?>? _proposedTotalMonthlyDebt;
    private DirtyValue<string?>? _purchaseEligibility;
    private DirtyValue<decimal?>? _qualifyingRate;
    private DirtyValue<string?>? _recordType;
    private DirtyValue<StringEnumValue<RefinancePurpose>>? _refinancePurpose;
    private DirtyValue<DateTime?>? _requestedDateTime;
    private DirtyValue<decimal?>? _reserves;
    private DirtyValue<decimal?>? _reservesRequiredVerified;
    private DirtyValue<string?>? _riskClass;
    private DirtyValue<string?>? _salesConcessions;
    private DirtyValue<decimal?>? _salesPrice;
    private DirtyValue<decimal?>? _secondPandI;
    private DirtyValue<string?>? _selectedBorrower;
    private DirtyValue<string?>? _selectedRepository;
    private DirtyValue<string?>? _sellerNumber;
    private DirtyValue<decimal?>? _subjNegCashFlow;
    private DirtyValue<DateTime?>? _submissionDate;
    private DirtyValue<string?>? _submissionNumber;
    private DirtyValue<string?>? _submissionTime;
    private DirtyValue<string?>? _submittedBy;
    private DirtyValue<string?>? _submittingCompany;
    private DirtyValue<string?>? _temporarySubsidyBuydown;
    private DirtyValue<decimal?>? _tltv;
    private DirtyValue<decimal?>? _totalAsset;
    private DirtyValue<decimal?>? _totalExpense;
    private DirtyValue<decimal?>? _totalExpensePmt;
    private DirtyValue<decimal?>? _totalExpenseRatio;
    private DirtyValue<decimal?>? _totalFundsVerified;
    private DirtyValue<decimal?>? _totalLoanAmount;
    private DirtyValue<decimal?>? _totalMonthlyIncome;
    private DirtyValue<string?>? _tpoNumber;
    private DirtyValue<string?>? _transactionId;
    private DirtyValue<string?>? _underwritingRiskAssessOther;
    private DirtyValue<StringEnumValue<RiskAssessmentType>>? _underwritingRiskAssessType;
    private DirtyValue<string?>? _withUndisclosedDebt;

    /// <summary>
    /// AUS Tracking - Freddie Mac - Accept Plus Eligible [AUS.X127]
    /// </summary>
    public string? AcceptPlusEligible { get => _acceptPlusEligible; set => SetField(ref _acceptPlusEligible, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Affordable Product Type [AUS.X155]
    /// </summary>
    public string? AffordableProductType { get => _affordableProductType; set => SetField(ref _affordableProductType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - All Other Payments [AUS.X71]
    /// </summary>
    public decimal? AllOtherPayments { get => _allOtherPayments; set => SetField(ref _allOtherPayments, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Amortization Months [AUS.X144]
    /// </summary>
    public int? AmortizationMonths { get => _amortizationMonths; set => SetField(ref _amortizationMonths, value); }

    /// <summary>
    /// AUS Tracking - Amortization Type [AUS.X22]
    /// </summary>
    public StringEnumValue<AmortizationType> AmortizationType { get => _amortizationType; set => SetField(ref _amortizationType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Amt. Subordinate Fin. [AUS.X57]
    /// </summary>
    public decimal? AmtSubordinateFin { get => _amtSubordinateFin; set => SetField(ref _amtSubordinateFin, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Appraisal Type/MAF [AUS.X125]
    /// </summary>
    public string? AppraisalTypeMaf { get => _appraisalTypeMaf; set => SetField(ref _appraisalTypeMaf, value); }

    /// <summary>
    /// AUS Tracking - Appraised Value [AUS.X18]
    /// </summary>
    public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - ARM Qualifying Rate [AUS.X145]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ArmQualifyingRate { get => _armQualifyingRate; set => SetField(ref _armQualifyingRate, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Assessed [AUS.X169]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AssessedDateTime { get => _assessedDateTime; set => SetField(ref _assessedDateTime, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Assessment Type [AUS.X123]
    /// </summary>
    public string? AssessmentType { get => _assessmentType; set => SetField(ref _assessmentType, value); }

    /// <summary>
    /// AUS Tracking - AUS Log Extension Id [AUS.X197]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AusLogExtensionId { get => _ausLogExtensionId; set => SetField(ref _ausLogExtensionId, value); }

    /// <summary>
    /// AUS Tracking - AUS Order LinkId  [AUS.X196]
    /// </summary>
    public string? AusOrderLinkId { get => _ausOrderLinkId; set => SetField(ref _ausOrderLinkId, value); }

    /// <summary>
    /// AUS Tracking - AUS Recommendation [AUS.X6]
    /// </summary>
    public string? AusRecommendation { get => _ausRecommendation; set => SetField(ref _ausRecommendation, value); }

    /// <summary>
    /// AUS Tracking - Aus Response File Name [AUS.X198]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AusResponseFileName { get => _ausResponseFileName; set => SetField(ref _ausResponseFileName, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Status [AUS.X121]
    /// </summary>
    public string? AusStatus { get => _ausStatus; set => SetField(ref _ausStatus, value); }

    /// <summary>
    /// AUS Tracking - AUS Tracking Type [AUS.X999]
    /// </summary>
    public StringEnumValue<LogAUSTrackingType> AusTrackingType { get => _ausTrackingType; set => SetField(ref _ausTrackingType, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - AUS Transaction # [AUS.X114]
    /// </summary>
    public string? AusTransactionId { get => _ausTransactionId; set => SetField(ref _ausTransactionId, value); }

    /// <summary>
    /// AUS Tracking - AUS Version # [AUS.X9]
    /// </summary>
    public string? AusVersion { get => _ausVersion; set => SetField(ref _ausVersion, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Balloon [AUS.X53]
    /// </summary>
    public string? Balloon { get => _balloon; set => SetField(ref _balloon, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Balloon Term [AUS.X143]
    /// </summary>
    public int? BalloonTerm { get => _balloonTerm; set => SetField(ref _balloonTerm, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Amount [AUS.X109]
    /// </summary>
    public decimal? BorrowerAssetAmount { get => _borrowerAssetAmount; set => SetField(ref _borrowerAssetAmount, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Name [AUS.X106]
    /// </summary>
    public string? BorrowerAssetName { get => _borrowerAssetName; set => SetField(ref _borrowerAssetName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Asset Type [AUS.X107]
    /// </summary>
    public string? BorrowerAssetType { get => _borrowerAssetType; set => SetField(ref _borrowerAssetType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 1 [AUS.X93]
    /// </summary>
    public string? BorrowerCreditScore1 { get => _borrowerCreditScore1; set => SetField(ref _borrowerCreditScore1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 2 [AUS.X94]
    /// </summary>
    public string? BorrowerCreditScore2 { get => _borrowerCreditScore2; set => SetField(ref _borrowerCreditScore2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Credit Score 3 [AUS.X95]
    /// </summary>
    public string? BorrowerCreditScore3 { get => _borrowerCreditScore3; set => SetField(ref _borrowerCreditScore3, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Equifax/BEACON [AUS.X134]
    /// </summary>
    public string? BorrowerEquifaxBeacon { get => _borrowerEquifaxBeacon; set => SetField(ref _borrowerEquifaxBeacon, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Experian/FICO [AUS.X132]
    /// </summary>
    public string? BorrowerExperianFico { get => _borrowerExperianFico; set => SetField(ref _borrowerExperianFico, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Amount [AUS.X102]
    /// </summary>
    public decimal? BorrowerIncomeAmount { get => _borrowerIncomeAmount; set => SetField(ref _borrowerIncomeAmount, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Name [AUS.X100]
    /// </summary>
    public string? BorrowerIncomeName { get => _borrowerIncomeName; set => SetField(ref _borrowerIncomeName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Income Type [AUS.X101]
    /// </summary>
    public string? BorrowerIncomeType { get => _borrowerIncomeType; set => SetField(ref _borrowerIncomeType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Institution Name [AUS.X108]
    /// </summary>
    public string? BorrowerInstitutionName { get => _borrowerInstitutionName; set => SetField(ref _borrowerInstitutionName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Name [AUS.X43]
    /// </summary>
    public string? BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Score Name [AUS.X92]
    /// </summary>
    public string? BorrowerScoreName { get => _borrowerScoreName; set => SetField(ref _borrowerScoreName, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Borrower Trans Union/Empirica [AUS.X133]
    /// </summary>
    public string? BorrowerTransUnionEmpirica { get => _borrowerTransUnionEmpirica; set => SetField(ref _borrowerTransUnionEmpirica, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type [AUS.X84]
    /// </summary>
    public string? BorrowerType1 { get => _borrowerType1; set => SetField(ref _borrowerType1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Borrower Type 2 [AUS.X88]
    /// </summary>
    public string? BorrowerType2 { get => _borrowerType2; set => SetField(ref _borrowerType2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Bought Down Rate [AUS.X64]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BoughtDownRate { get => _boughtDownRate; set => SetField(ref _boughtDownRate, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Buydown [AUS.X59]
    /// </summary>
    public string? Buydown { get => _buydown; set => SetField(ref _buydown, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Cash Back [AUS.X77]
    /// </summary>
    public decimal? CashBack { get => _cashBack; set => SetField(ref _cashBack, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Cash Out Amount [AUS.X158]
    /// </summary>
    public decimal? CashOutAmount { get => _cashOutAmount; set => SetField(ref _cashOutAmount, value); }

    /// <summary>
    /// AUS Tracking - CLTV [AUS.X12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Amount [AUS.X113]
    /// </summary>
    public decimal? CoBorrowerAssetAmount { get => _coBorrowerAssetAmount; set => SetField(ref _coBorrowerAssetAmount, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Name [AUS.X110]
    /// </summary>
    public string? CoBorrowerAssetName { get => _coBorrowerAssetName; set => SetField(ref _coBorrowerAssetName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Asset Type [AUS.X111]
    /// </summary>
    public string? CoBorrowerAssetType { get => _coBorrowerAssetType; set => SetField(ref _coBorrowerAssetType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 1 [AUS.X97]
    /// </summary>
    public string? CoBorrowerCreditScore1 { get => _coBorrowerCreditScore1; set => SetField(ref _coBorrowerCreditScore1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 2 [AUS.X98]
    /// </summary>
    public string? CoBorrowerCreditScore2 { get => _coBorrowerCreditScore2; set => SetField(ref _coBorrowerCreditScore2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Credit Score 3 [AUS.X99]
    /// </summary>
    public string? CoBorrowerCreditScore3 { get => _coBorrowerCreditScore3; set => SetField(ref _coBorrowerCreditScore3, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Equifax BEACON [AUS.X137]
    /// </summary>
    public string? CoBorrowerEquifaxBeacon { get => _coBorrowerEquifaxBeacon; set => SetField(ref _coBorrowerEquifaxBeacon, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Experian FICO [AUS.X135]
    /// </summary>
    public string? CoBorrowerExperianFico { get => _coBorrowerExperianFico; set => SetField(ref _coBorrowerExperianFico, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Amount [AUS.X105]
    /// </summary>
    public decimal? CoBorrowerIncomeAmount { get => _coBorrowerIncomeAmount; set => SetField(ref _coBorrowerIncomeAmount, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Name [AUS.X103]
    /// </summary>
    public string? CoBorrowerIncomeName { get => _coBorrowerIncomeName; set => SetField(ref _coBorrowerIncomeName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Income Type [AUS.X104]
    /// </summary>
    public string? CoBorrowerIncomeType { get => _coBorrowerIncomeType; set => SetField(ref _coBorrowerIncomeType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Institution Name [AUS.X112]
    /// </summary>
    public string? CoBorrowerInstitutionName { get => _coBorrowerInstitutionName; set => SetField(ref _coBorrowerInstitutionName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Coborrower Name [AUS.X45]
    /// </summary>
    public string? CoborrowerName { get => _coborrowerName; set => SetField(ref _coborrowerName, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - CoBorrower Score Name 2 [AUS.X96]
    /// </summary>
    public string? CoBorrowerScoreName { get => _coBorrowerScoreName; set => SetField(ref _coBorrowerScoreName, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - CoBorrower Trans Union/Empirica [AUS.X136]
    /// </summary>
    public string? CoBorrowerTransUnionEmpirica { get => _coBorrowerTransUnionEmpirica; set => SetField(ref _coBorrowerTransUnionEmpirica, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 1 [AUS.X80]
    /// </summary>
    public string? Code1 { get => _code1; set => SetField(ref _code1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code 2 [AUS.X82]
    /// </summary>
    public string? Code2 { get => _code2; set => SetField(ref _code2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 1 [AUS.X81]
    /// </summary>
    public string? CodeDescription1 { get => _codeDescription1; set => SetField(ref _codeDescription1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Code Description 2 [AUS.X83]
    /// </summary>
    public string? CodeDescription2 { get => _codeDescription2; set => SetField(ref _codeDescription2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Community Lending [AUS.X54]
    /// </summary>
    public string? CommunityLending { get => _communityLending; set => SetField(ref _communityLending, value); }

    /// <summary>
    /// AUSTrackingContract CreatedOn
    /// </summary>
    public DateTime? CreatedOn { get => _createdOn; set => SetField(ref _createdOn, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 1 [AUS.X85]
    /// </summary>
    public string? CreditAgency1 { get => _creditAgency1; set => SetField(ref _creditAgency1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Agency 2 [AUS.X89]
    /// </summary>
    public string? CreditAgency2 { get => _creditAgency2; set => SetField(ref _creditAgency2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 1 [AUS.X87]
    /// </summary>
    public DateTime? CreditReportDate1 { get => _creditReportDate1; set => SetField(ref _creditReportDate1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report Date 2 [AUS.X91]
    /// </summary>
    public DateTime? CreditReportDate2 { get => _creditReportDate2; set => SetField(ref _creditReportDate2, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 1 [AUS.X86]
    /// </summary>
    public string? CreditReportId1 { get => _creditReportId1; set => SetField(ref _creditReportId1, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Credit Report ID 2 [AUS.X90]
    /// </summary>
    public string? CreditReportId2 { get => _creditReportId2; set => SetField(ref _creditReportId2, value); }

    /// <summary>
    /// Cured AUS Tracking - Amortization Type [AUS.CuredX22]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<AmortizationType> CuredAmortizationType { get => _curedAmortizationType; set => SetField(ref _curedAmortizationType, value); }

    /// <summary>
    /// Cured AUS Tracking - Appraised Value [AUS.CuredX18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? CuredAppraisedValue { get => _curedAppraisedValue; set => SetField(ref _curedAppraisedValue, value); }

    /// <summary>
    /// CuredAUS Tracking - CLTV [AUS.CuredX12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredCltv { get => _curedCltv; set => SetField(ref _curedCltv, value); }

    /// <summary>
    /// Cured AUS Tracking - Housing Expense Ratio [AUS.CuredX14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredHousingExpenseRatio { get => _curedHousingExpenseRatio; set => SetField(ref _curedHousingExpenseRatio, value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Purpose [AUS.CuredX23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanPurposeType> CuredLoanPurpose { get => _curedLoanPurpose; set => SetField(ref _curedLoanPurpose, value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Term [AUS.CuredX21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? CuredLoanTerm { get => _curedLoanTerm; set => SetField(ref _curedLoanTerm, value); }

    /// <summary>
    /// Cured AUS Tracking - Loan Type [AUS.CuredX20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<LoanType> CuredLoanType { get => _curedLoanType; set => SetField(ref _curedLoanType, value); }

    /// <summary>
    /// Cured AUS Tracking - LTV [AUS.CuredX11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredLtv { get => _curedLtv; set => SetField(ref _curedLtv, value); }

    /// <summary>
    /// Cured AUS Tracking - Note Rate [AUS.CuredX19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredNoteRate { get => _curedNoteRate; set => SetField(ref _curedNoteRate, value); }

    /// <summary>
    /// Cured AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.CuredX32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredProposedTotalHousingPayment { get => _curedProposedTotalHousingPayment; set => SetField(ref _curedProposedTotalHousingPayment, value); }

    /// <summary>
    /// Cured AUS Tracking - Refinance Purpose [AUS.CuredX24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<RefinancePurpose> CuredRefinancePurpose { get => _curedRefinancePurpose; set => SetField(ref _curedRefinancePurpose, value); }

    /// <summary>
    /// Cured AUS Tracking - Total Expense Ratio [AUS.CuredX15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CuredTotalExpenseRatio { get => _curedTotalExpenseRatio; set => SetField(ref _curedTotalExpenseRatio, value); }

    /// <summary>
    /// Cured AUS Tracking - Total Loan Amount [AUS.CuredX16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredTotalLoanAmount { get => _curedTotalLoanAmount; set => SetField(ref _curedTotalLoanAmount, value); }

    /// <summary>
    /// Cured AUS Tracking - Income / Assets - Total Monthly Income [AUS.CuredX41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredTotalMonthlyIncome { get => _curedTotalMonthlyIncome; set => SetField(ref _curedTotalMonthlyIncome, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Debt Ratio [AUS.X149]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DebtRatio { get => _debtRatio; set => SetField(ref _debtRatio, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Documentation Level [AUS.X118]
    /// </summary>
    public string? DocumentationLevel { get => _documentationLevel; set => SetField(ref _documentationLevel, value); }

    /// <summary>
    /// AUS Tracking - DU Case ID/ LP AUS Key # [AUS.X7]
    /// </summary>
    public string? DuCaseIdorLpausKey { get => _duCaseIdorLpausKey; set => SetField(ref _duCaseIdorLpausKey, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Type [AUS.X50]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"MHAdvantage\"]")]
    public StringEnumValue<PropertyType> DuPropertyType { get => _duPropertyType; set => SetField(ref _duPropertyType, value); }

    /// <summary>
    /// AUS Tracking - eFolder GUID [AUS.EFOLDERGUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EFolderGuid { get => _eFolderGuid; set => SetField(ref _eFolderGuid, value); }

    /// <summary>
    /// AUS Tracking - Error Info [AUS.X195]
    /// </summary>
    public string? ErrorInfo { get => _errorInfo; set => SetField(ref _errorInfo, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Excess Available Assets, not required to be Verified [AUS.X79]
    /// </summary>
    public decimal? ExcessAvailableAssetsNoVerified { get => _excessAvailableAssetsNoVerified; set => SetField(ref _excessAvailableAssetsNoVerified, value); }

    /// <summary>
    /// AUS Tracking - Fatal Edit Info [AUS.X193]
    /// </summary>
    public string? FatalEditInfo { get => _fatalEditInfo; set => SetField(ref _fatalEditInfo, value); }

    /// <summary>
    /// AUS Tracking - File Type [AUS.X192]
    /// </summary>
    public StringEnumValue<LogFileType> FileType { get => _fileType; set => SetField(ref _fileType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Financed MI Amount [AUS.X61]
    /// </summary>
    public decimal? FinancedMiAmount { get => _financedMiAmount; set => SetField(ref _financedMiAmount, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - First P&amp;I [AUS.X25]
    /// </summary>
    public decimal? FirstPandI { get => _firstPandI; set => SetField(ref _firstPandI, value); }

    /// <summary>
    /// AUS Tracking - First Submission Date [AUS.X4]
    /// </summary>
    public DateTime? FirstSubmissionDate { get => _firstSubmissionDate; set => SetField(ref _firstSubmissionDate, value); }

    /// <summary>
    /// AUS Tracking - First Submission Time [AUS.X174]
    /// </summary>
    public string? FirstSubmissionTime { get => _firstSubmissionTime; set => SetField(ref _firstSubmissionTime, value); }

    /// <summary>
    /// AUS Tracking - Doc Class (Freddie) [AUS.X10]
    /// </summary>
    public string? FreddieDocClass { get => _freddieDocClass; set => SetField(ref _freddieDocClass, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Funds Required to Close [AUS.X74]
    /// </summary>
    public decimal? FundsRequiredClose { get => _fundsRequiredClose; set => SetField(ref _fundsRequiredClose, value); }

    /// <summary>
    /// AUS Tracking - HLCTV [AUS.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Hlctv { get => _hlctv; set => SetField(ref _hlctv, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Housing Expense [AUS.X65]
    /// </summary>
    public decimal? HousingExpense { get => _housingExpense; set => SetField(ref _housingExpense, value); }

    /// <summary>
    /// AUS Tracking - Housing Expense Ratio [AUS.X14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HousingExpenseRatio { get => _housingExpenseRatio; set => SetField(ref _housingExpenseRatio, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Housing Ratio [AUS.X148]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HousingRatio { get => _housingRatio; set => SetField(ref _housingRatio, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - HTLTV [AUS.X147]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Htltv { get => _htltv; set => SetField(ref _htltv, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Including Less Than 10 Mos. [AUS.X67]
    /// </summary>
    public string? IncludingLess10Mos { get => _includingLess10Mos; set => SetField(ref _includingLess10Mos, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Base [AUS.X34]
    /// </summary>
    public decimal? IncomeAssetBase { get => _incomeAssetBase; set => SetField(ref _incomeAssetBase, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Bonus [AUS.X36]
    /// </summary>
    public decimal? IncomeAssetBonus { get => _incomeAssetBonus; set => SetField(ref _incomeAssetBonus, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Commission [AUS.X35]
    /// </summary>
    public decimal? IncomeAssetCommission { get => _incomeAssetCommission; set => SetField(ref _incomeAssetCommission, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Other [AUS.X38]
    /// </summary>
    public decimal? IncomeAssetOther { get => _incomeAssetOther; set => SetField(ref _incomeAssetOther, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Overtime [AUS.X37]
    /// </summary>
    public decimal? IncomeAssetOvertime { get => _incomeAssetOvertime; set => SetField(ref _incomeAssetOvertime, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Subj. Pos. Cash Flow [AUS.X40]
    /// </summary>
    public decimal? IncomeAssetPosCashFlow { get => _incomeAssetPosCashFlow; set => SetField(ref _incomeAssetPosCashFlow, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Positive Net Rental [AUS.X39]
    /// </summary>
    public decimal? IncomeAssetPositiveNetRental { get => _incomeAssetPositiveNetRental; set => SetField(ref _incomeAssetPositiveNetRental, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Indicator Score [AUS.X128]
    /// </summary>
    public string? IndicatorScore { get => _indicatorScore; set => SetField(ref _indicatorScore, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Intended Use of Property [AUS.X157]
    /// </summary>
    public string? IntendedUseofProperty { get => _intendedUseofProperty; set => SetField(ref _intendedUseofProperty, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 1 [AUS.X185]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion1 { get => _lclaEvaluatedServiceConclusion1; set => SetField(ref _lclaEvaluatedServiceConclusion1, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 2 [AUS.X187]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion2 { get => _lclaEvaluatedServiceConclusion2; set => SetField(ref _lclaEvaluatedServiceConclusion2, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Conclusion 3 [AUS.X189]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion3 { get => _lclaEvaluatedServiceConclusion3; set => SetField(ref _lclaEvaluatedServiceConclusion3, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - LCLAEvaluated Service Conclusion 4 [AUS.X191]
    /// </summary>
    public string? LclaEvaluatedServiceConclusion4 { get => _lclaEvaluatedServiceConclusion4; set => SetField(ref _lclaEvaluatedServiceConclusion4, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 1 [AUS.X184]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType1> LclaEvaluatedServiceType1 { get => _lclaEvaluatedServiceType1; set => SetField(ref _lclaEvaluatedServiceType1, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 2 [AUS.X186]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType2> LclaEvaluatedServiceType2 { get => _lclaEvaluatedServiceType2; set => SetField(ref _lclaEvaluatedServiceType2, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 3 [AUS.X188]
    /// </summary>
    public StringEnumValue<LogLCLAEvaluatedServiceType3> LclaEvaluatedServiceType3 { get => _lclaEvaluatedServiceType3; set => SetField(ref _lclaEvaluatedServiceType3, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - Evaluated Service Type 4 [AUS.X190]
    /// </summary>
    public string? LclaEvaluatedServiceType4 { get => _lclaEvaluatedServiceType4; set => SetField(ref _lclaEvaluatedServiceType4, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lender Loan # [AUS.X44]
    /// </summary>
    public string? LenderLoan { get => _lenderLoan; set => SetField(ref _lenderLoan, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Lien Type [AUS.X56]
    /// </summary>
    public StringEnumValue<LienType> LienType { get => _lienType; set => SetField(ref _lienType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Loan Amount [AUS.X60]
    /// </summary>
    public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Application # [AUS.X142]
    /// </summary>
    public string? LoanApplicationId { get => _loanApplicationId; set => SetField(ref _loanApplicationId, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Processing Stage [AUS.X122]
    /// </summary>
    public string? LoanProcessingStage { get => _loanProcessingStage; set => SetField(ref _loanProcessingStage, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Loan Prospector ID [AUS.X115]
    /// </summary>
    public string? LoanProspectorId { get => _loanProspectorId; set => SetField(ref _loanProspectorId, value); }

    /// <summary>
    /// AUS Tracking - Loan Purpose [AUS.X23]
    /// </summary>
    public StringEnumValue<LoanPurposeType> LoanPurpose { get => _loanPurpose; set => SetField(ref _loanPurpose, value); }

    /// <summary>
    /// AUS Tracking - Loan Term [AUS.X21]
    /// </summary>
    public int? LoanTerm { get => _loanTerm; set => SetField(ref _loanTerm, value); }

    /// <summary>
    /// AUS Tracking - Loan Type [AUS.X20]
    /// </summary>
    public StringEnumValue<LoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Assmt. Exp. Date [AUS.X131]
    /// </summary>
    public DateTime? LpAssmtExpDate { get => _lpAssmtExpDate; set => SetField(ref _lpAssmtExpDate, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Property Type [AUS.X172]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Detached Condominium\"]")]
    public StringEnumValue<OtherPropertyType> LpPropertyType { get => _lpPropertyType; set => SetField(ref _lpPropertyType, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - LP Version [AUS.X124]
    /// </summary>
    public string? LpVersion { get => _lpVersion; set => SetField(ref _lpVersion, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Collateral Rep and Warranty Service Conclusion [AUS.X183]
    /// </summary>
    public string? LqaCollateralRepWarrantyServiceConclusion { get => _lqaCollateralRepWarrantyServiceConclusion; set => SetField(ref _lqaCollateralRepWarrantyServiceConclusion, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Credit Risk Assessment Conclusion [AUS.X181]
    /// </summary>
    public string? LqaCreditRiskAssessmentConclusion { get => _lqaCreditRiskAssessmentConclusion; set => SetField(ref _lqaCreditRiskAssessmentConclusion, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Conclusion [AUS.X179]
    /// </summary>
    public string? LqaDataCompareFieldConclusion { get => _lqaDataCompareFieldConclusion; set => SetField(ref _lqaDataCompareFieldConclusion, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Field Name [AUS.X178]
    /// </summary>
    public string? LqaDataCompareFieldName { get => _lqaDataCompareFieldName; set => SetField(ref _lqaDataCompareFieldName, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Data Compare Result [AUS.X175]
    /// </summary>
    public string? LqaDataCompareResult { get => _lqaDataCompareResult; set => SetField(ref _lqaDataCompareResult, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - LP Key [AUS.X176]
    /// </summary>
    public string? LqalpKey { get => _lqalpKey; set => SetField(ref _lqalpKey, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Purchase Eligibility Result [AUS.X182]
    /// </summary>
    public string? LqaPurchaseEligibilityResult { get => _lqaPurchaseEligibilityResult; set => SetField(ref _lqaPurchaseEligibilityResult, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Risk Assessment Key [AUS.X180]
    /// </summary>
    public string? LqaRiskAssessmentKey { get => _lqaRiskAssessmentKey; set => SetField(ref _lqaRiskAssessmentKey, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LQA - Submission DateTime [AUS.X177]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LqaSubmissionDateTime { get => _lqaSubmissionDateTime; set => SetField(ref _lqaSubmissionDateTime, value); }

    /// <summary>
    /// AUS Tracking - LTV [AUS.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Max Mortgage Limit [AUS.X162]
    /// </summary>
    public decimal? MaxMortgageLimit { get => _maxMortgageLimit; set => SetField(ref _maxMortgageLimit, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - MI Decision [AUS.X126]
    /// </summary>
    public string? MiDecision { get => _miDecision; set => SetField(ref _miDecision, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Mortgage Type [AUS.X119]
    /// </summary>
    public string? MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Neg. Amortization Type [AUS.X152]
    /// </summary>
    public string? NegAmortizationType { get => _negAmortizationType; set => SetField(ref _negAmortizationType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Negative Net Rental [AUS.X69]
    /// </summary>
    public decimal? NegativeNetRental { get => _negativeNetRental; set => SetField(ref _negativeNetRental, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Net Cash Back [AUS.X78]
    /// </summary>
    public decimal? NetCashBack { get => _netCashBack; set => SetField(ref _netCashBack, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - New Construction [AUS.X154]
    /// </summary>
    public string? NewConstruction { get => _newConstruction; set => SetField(ref _newConstruction, value); }

    /// <summary>
    /// AUS Tracking - Note Rate [AUS.X19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NoteRate { get => _noteRate; set => SetField(ref _noteRate, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - NOTP Number [AUS.X171]
    /// </summary>
    public string? NotpNumber { get => _notpNumber; set => SetField(ref _notpNumber, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - No Units [AUS.X51]
    /// </summary>
    public int? NoUnits { get => _noUnits; set => SetField(ref _noUnits, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - # of Submissions [AUS.X170]
    /// </summary>
    public string? NumberOfSubmissions { get => _numberOfSubmissions; set => SetField(ref _numberOfSubmissions, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Occupancy Status [AUS.X52]
    /// </summary>
    public string? OccupancyStatus { get => _occupancyStatus; set => SetField(ref _occupancyStatus, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Debt Ratio [AUS.X151]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OccupantDebtRatio { get => _occupantDebtRatio; set => SetField(ref _occupantDebtRatio, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Occupant Housing Ratio [AUS.X150]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OccupantHousingRatio { get => _occupantHousingRatio; set => SetField(ref _occupantHousingRatio, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Offering Identifier [AUS.X156]
    /// </summary>
    public string? OfferingIdentifier { get => _offeringIdentifier; set => SetField(ref _offeringIdentifier, value); }

    /// <summary>
    /// AUS Tracking - Order Status [AUS.X194]
    /// </summary>
    public string? OrderStatus { get => _orderStatus; set => SetField(ref _orderStatus, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Originating Company [AUS.X164]
    /// </summary>
    public string? OriginatingCompany { get => _originatingCompany; set => SetField(ref _originatingCompany, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Owner Existing Mtg. [AUS.X58]
    /// </summary>
    public decimal? OwnerExistingMtg { get => _ownerExistingMtg; set => SetField(ref _ownerExistingMtg, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - P &amp; I [AUS.X62]
    /// </summary>
    public decimal? PandI { get => _pandI; set => SetField(ref _pandI, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Payment Frequency [AUS.X55]
    /// </summary>
    public int? PaymentFrequency { get => _paymentFrequency; set => SetField(ref _paymentFrequency, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address [AUS.X138]
    /// </summary>
    public string? PresentAddress { get => _presentAddress; set => SetField(ref _presentAddress, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address City [AUS.X139]
    /// </summary>
    public string? PresentAddressCity { get => _presentAddressCity; set => SetField(ref _presentAddressCity, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address State [AUS.X140]
    /// </summary>
    public string? PresentAddressState { get => _presentAddressState; set => SetField(ref _presentAddressState, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Address Zipcode [AUS.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PresentAddressZipCode { get => _presentAddressZipCode; set => SetField(ref _presentAddressZipCode, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Present Housing Expense [AUS.X161]
    /// </summary>
    public decimal? PresentHousingExpense { get => _presentHousingExpense; set => SetField(ref _presentHousingExpense, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Present/Principal Housing Payment [AUS.X73]
    /// </summary>
    public decimal? PresentPrincipalHousingPayment { get => _presentPrincipalHousingPayment; set => SetField(ref _presentPrincipalHousingPayment, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Address [AUS.X46]
    /// </summary>
    public string? PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property City [AUS.X47]
    /// </summary>
    public string? PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property State [AUS.X48]
    /// </summary>
    public string? PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Property Zipcode [AUS.X49]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyZipcode { get => _propertyZipcode; set => SetField(ref _propertyZipcode, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Hazard Insurance [AUS.X27]
    /// </summary>
    public decimal? ProposedHazardInsurance { get => _proposedHazardInsurance; set => SetField(ref _proposedHazardInsurance, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - HOA Fees [AUS.X30]
    /// </summary>
    public decimal? ProposedHoaFees { get => _proposedHoaFees; set => SetField(ref _proposedHoaFees, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Proposed Housing (PITI) [AUS.X160]
    /// </summary>
    public decimal? ProposedHousingPiti { get => _proposedHousingPiti; set => SetField(ref _proposedHousingPiti, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Mortgage Insurance [AUS.X29]
    /// </summary>
    public decimal? ProposedMortgageInsurance { get => _proposedMortgageInsurance; set => SetField(ref _proposedMortgageInsurance, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Other [AUS.X31]
    /// </summary>
    public decimal? ProposedOtherPayment { get => _proposedOtherPayment; set => SetField(ref _proposedOtherPayment, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Taxes [AUS.X28]
    /// </summary>
    public decimal? ProposedTaxes { get => _proposedTaxes; set => SetField(ref _proposedTaxes, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Housing Payment [AUS.X32]
    /// </summary>
    public decimal? ProposedTotalHousingPayment { get => _proposedTotalHousingPayment; set => SetField(ref _proposedTotalHousingPayment, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Total Monthly Debt [AUS.X33]
    /// </summary>
    public decimal? ProposedTotalMonthlyDebt { get => _proposedTotalMonthlyDebt; set => SetField(ref _proposedTotalMonthlyDebt, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Purchase Eligibility [AUS.X120]
    /// </summary>
    public string? PurchaseEligibility { get => _purchaseEligibility; set => SetField(ref _purchaseEligibility, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Qualifying Rate [AUS.X63]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QualifyingRate { get => _qualifyingRate; set => SetField(ref _qualifyingRate, value); }

    /// <summary>
    /// AUSTrackingContract RecordType
    /// </summary>
    public string? RecordType { get => _recordType; set => SetField(ref _recordType, value); }

    /// <summary>
    /// AUS Tracking - Refinance Purpose [AUS.X24]
    /// </summary>
    public StringEnumValue<RefinancePurpose> RefinancePurpose { get => _refinancePurpose; set => SetField(ref _refinancePurpose, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Date Time Requested [AUS.X168]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RequestedDateTime { get => _requestedDateTime; set => SetField(ref _requestedDateTime, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Reserves [AUS.X159]
    /// </summary>
    public decimal? Reserves { get => _reserves; set => SetField(ref _reserves, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Reserves Req'ed to be Verified [AUS.X75]
    /// </summary>
    public decimal? ReservesRequiredVerified { get => _reservesRequiredVerified; set => SetField(ref _reservesRequiredVerified, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Risk Class [AUS.X117]
    /// </summary>
    public string? RiskClass { get => _riskClass; set => SetField(ref _riskClass, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Sales Concessions [AUS.X163]
    /// </summary>
    public string? SalesConcessions { get => _salesConcessions; set => SetField(ref _salesConcessions, value); }

    /// <summary>
    /// AUS Tracking - Sales Price [AUS.X17]
    /// </summary>
    public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }

    /// <summary>
    /// AUS Tracking - Proposed Monthly Payment / Debt - Second P&amp;I [AUS.X26]
    /// </summary>
    public decimal? SecondPandI { get => _secondPandI; set => SetField(ref _secondPandI, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Borrower [AUS.X130]
    /// </summary>
    public string? SelectedBorrower { get => _selectedBorrower; set => SetField(ref _selectedBorrower, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Selected Repository [AUS.X129]
    /// </summary>
    public string? SelectedRepository { get => _selectedRepository; set => SetField(ref _selectedRepository, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Seller Number [AUS.X166]
    /// </summary>
    public string? SellerNumber { get => _sellerNumber; set => SetField(ref _sellerNumber, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Subj. Neg. Cash Flow [AUS.X70]
    /// </summary>
    public decimal? SubjNegCashFlow { get => _subjNegCashFlow; set => SetField(ref _subjNegCashFlow, value); }

    /// <summary>
    /// AUS Tracking - Submission Date [AUS.X3]
    /// </summary>
    public DateTime? SubmissionDate { get => _submissionDate; set => SetField(ref _submissionDate, value); }

    /// <summary>
    /// AUS Tracking - Submission Number [AUS.X5]
    /// </summary>
    public string? SubmissionNumber { get => _submissionNumber; set => SetField(ref _submissionNumber, value); }

    /// <summary>
    /// AUS Tracking - Submission Time [AUS.X173]
    /// </summary>
    public string? SubmissionTime { get => _submissionTime; set => SetField(ref _submissionTime, value); }

    /// <summary>
    /// AUS Tracking - Submitted By [AUS.X8]
    /// </summary>
    public string? SubmittedBy { get => _submittedBy; set => SetField(ref _submittedBy, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Submitting Company [AUS.X165]
    /// </summary>
    public string? SubmittingCompany { get => _submittingCompany; set => SetField(ref _submittingCompany, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Temporary Subsidy Buydown [AUS.X153]
    /// </summary>
    public string? TemporarySubsidyBuydown { get => _temporarySubsidyBuydown; set => SetField(ref _temporarySubsidyBuydown, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TLTV [AUS.X146]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Tltv { get => _tltv; set => SetField(ref _tltv, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Assets [AUS.X42]
    /// </summary>
    public decimal? TotalAsset { get => _totalAsset; set => SetField(ref _totalAsset, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense [AUS.X66]
    /// </summary>
    public decimal? TotalExpense { get => _totalExpense; set => SetField(ref _totalExpense, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Expense Pmt [AUS.X72]
    /// </summary>
    public decimal? TotalExpensePmt { get => _totalExpensePmt; set => SetField(ref _totalExpensePmt, value); }

    /// <summary>
    /// AUS Tracking - Total Expense Ratio [AUS.X15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalExpenseRatio { get => _totalExpenseRatio; set => SetField(ref _totalExpenseRatio, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - Total Funds to be Verified [AUS.X76]
    /// </summary>
    public decimal? TotalFundsVerified { get => _totalFundsVerified; set => SetField(ref _totalFundsVerified, value); }

    /// <summary>
    /// AUS Tracking - Total Loan Amount [AUS.X16]
    /// </summary>
    public decimal? TotalLoanAmount { get => _totalLoanAmount; set => SetField(ref _totalLoanAmount, value); }

    /// <summary>
    /// AUS Tracking - Income / Assets - Total Monthly Income [AUS.X41]
    /// </summary>
    public decimal? TotalMonthlyIncome { get => _totalMonthlyIncome; set => SetField(ref _totalMonthlyIncome, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - TPO Number [AUS.X167]
    /// </summary>
    public string? TpoNumber { get => _tpoNumber; set => SetField(ref _tpoNumber, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac - Transaction ID [AUS.X116]
    /// </summary>
    public string? TransactionId { get => _transactionId; set => SetField(ref _transactionId, value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Other Type [AUS.X2]
    /// </summary>
    public string? UnderwritingRiskAssessOther { get => _underwritingRiskAssessOther; set => SetField(ref _underwritingRiskAssessOther, value); }

    /// <summary>
    /// AUS Tracking - Underwriting Risk Assess Type [AUS.X1]
    /// </summary>
    public StringEnumValue<RiskAssessmentType> UnderwritingRiskAssessType { get => _underwritingRiskAssessType; set => SetField(ref _underwritingRiskAssessType, value); }

    /// <summary>
    /// AUS Tracking - Fannie Mae - With Undisclosed Debt [AUS.X68]
    /// </summary>
    public string? WithUndisclosedDebt { get => _withUndisclosedDebt; set => SetField(ref _withUndisclosedDebt, value); }
}