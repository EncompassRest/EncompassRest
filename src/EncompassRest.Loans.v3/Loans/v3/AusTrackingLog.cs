using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AusTrackingLog
/// </summary>
public sealed partial class AusTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _acceptPlusEligible;
    private DirtyValue<string?>? _affordableProductType;
    private DirtyValue<decimal?>? _allOtherPayments;
    private DirtyValue<int?>? _amortizationMonths;
    private DirtyValue<string?>? _amortizationType;
    private DirtyValue<decimal?>? _amtSubordinateFin;
    private DirtyValue<string?>? _appraisalTypeMaf;
    private DirtyValue<int?>? _appraisedValue;
    private DirtyValue<decimal?>? _armQualifyingRate;
    private DirtyValue<DateTime?>? _assessedDateTime;
    private DirtyValue<string?>? _assessmentType;
    private DirtyValue<string?>? _ausOrderLinkId;
    private DirtyValue<string?>? _ausRecommendation;
    private DirtyValue<string?>? _ausStatus;
    private DirtyValue<string?>? _ausTrackingType;
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
    private DirtyValue<string?>? _curedAmortizationType;
    private DirtyValue<int?>? _curedAppraisedValue;
    private DirtyValue<decimal?>? _curedCltv;
    private DirtyValue<decimal?>? _curedHousingExpenseRatio;
    private DirtyValue<string?>? _curedLoanPurpose;
    private DirtyValue<int?>? _curedLoanTerm;
    private DirtyValue<string?>? _curedLoanType;
    private DirtyValue<decimal?>? _curedLtv;
    private DirtyValue<decimal?>? _curedNoteRate;
    private DirtyValue<decimal?>? _curedProposedTotalHousingPayment;
    private DirtyValue<string?>? _curedRefinancePurpose;
    private DirtyValue<decimal?>? _curedTotalExpenseRatio;
    private DirtyValue<decimal?>? _curedTotalLoanAmount;
    private DirtyValue<decimal?>? _curedTotalMonthlyIncome;
    private DirtyValue<decimal?>? _debtRatio;
    private DirtyValue<string?>? _documentationLevel;
    private DirtyValue<string?>? _duCaseIdorLpausKey;
    private DirtyValue<string?>? _duPropertyType;
    private DirtyValue<string?>? _eFolderGuid;
    private DirtyValue<string?>? _errorInfo;
    private DirtyValue<decimal?>? _excessAvailableAssetsNoVerified;
    private DirtyValue<string?>? _fatalEditInfo;
    private DirtyValue<string?>? _fileType;
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
    private DirtyValue<string?>? _id;
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
    private DirtyValue<string?>? _lclaEvaluatedServiceType1;
    private DirtyValue<string?>? _lclaEvaluatedServiceType2;
    private DirtyValue<string?>? _lclaEvaluatedServiceType3;
    private DirtyValue<string?>? _lclaEvaluatedServiceType4;
    private DirtyValue<string?>? _lenderLoan;
    private DirtyValue<string?>? _lienType;
    private DirtyValue<decimal?>? _loanAmount;
    private DirtyValue<string?>? _loanApplicationId;
    private DirtyValue<string?>? _loanProcessingStage;
    private DirtyValue<string?>? _loanProspectorId;
    private DirtyValue<string?>? _loanPurpose;
    private DirtyValue<int?>? _loanTerm;
    private DirtyValue<string?>? _loanType;
    private DirtyValue<DateTime?>? _lpAssmtExpDate;
    private DirtyValue<string?>? _lpPropertyType;
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
    private DirtyValue<string?>? _refinancePurpose;
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
    private DirtyValue<string?>? _underwritingRiskAssessType;
    private DirtyValue<string?>? _withUndisclosedDebt;

    /// <summary>
    /// AUSTrackingLogContract AcceptPlusEligible
    /// </summary>
    public string? AcceptPlusEligible { get => _acceptPlusEligible; set => SetField(ref _acceptPlusEligible, value); }

    /// <summary>
    /// AUSTrackingLogContract AffordableProductType
    /// </summary>
    public string? AffordableProductType { get => _affordableProductType; set => SetField(ref _affordableProductType, value); }

    /// <summary>
    /// AUSTrackingLogContract AllOtherPayments
    /// </summary>
    public decimal? AllOtherPayments { get => _allOtherPayments; set => SetField(ref _allOtherPayments, value); }

    /// <summary>
    /// AUSTrackingLogContract AmortizationMonths
    /// </summary>
    public int? AmortizationMonths { get => _amortizationMonths; set => SetField(ref _amortizationMonths, value); }

    /// <summary>
    /// AUSTrackingLogContract AmortizationType
    /// </summary>
    public string? AmortizationType { get => _amortizationType; set => SetField(ref _amortizationType, value); }

    /// <summary>
    /// AUSTrackingLogContract AmtSubordinateFin
    /// </summary>
    public decimal? AmtSubordinateFin { get => _amtSubordinateFin; set => SetField(ref _amtSubordinateFin, value); }

    /// <summary>
    /// AUSTrackingLogContract AppraisalTypeMaf
    /// </summary>
    public string? AppraisalTypeMaf { get => _appraisalTypeMaf; set => SetField(ref _appraisalTypeMaf, value); }

    /// <summary>
    /// AUSTrackingLogContract AppraisedValue
    /// </summary>
    public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

    /// <summary>
    /// AUSTrackingLogContract ArmQualifyingRate
    /// </summary>
    public decimal? ArmQualifyingRate { get => _armQualifyingRate; set => SetField(ref _armQualifyingRate, value); }

    /// <summary>
    /// AUSTrackingLogContract AssessedDateTime
    /// </summary>
    public DateTime? AssessedDateTime { get => _assessedDateTime; set => SetField(ref _assessedDateTime, value); }

    /// <summary>
    /// AUSTrackingLogContract AssessmentType
    /// </summary>
    public string? AssessmentType { get => _assessmentType; set => SetField(ref _assessmentType, value); }

    /// <summary>
    /// AUSTrackingLogContract AusOrderLinkId
    /// </summary>
    public string? AusOrderLinkId { get => _ausOrderLinkId; set => SetField(ref _ausOrderLinkId, value); }

    /// <summary>
    /// AUSTrackingLogContract AusRecommendation
    /// </summary>
    public string? AusRecommendation { get => _ausRecommendation; set => SetField(ref _ausRecommendation, value); }

    /// <summary>
    /// AUSTrackingLogContract AusStatus
    /// </summary>
    public string? AusStatus { get => _ausStatus; set => SetField(ref _ausStatus, value); }

    /// <summary>
    /// AUSTrackingLogContract AusTrackingType
    /// </summary>
    public string? AusTrackingType { get => _ausTrackingType; set => SetField(ref _ausTrackingType, value); }

    /// <summary>
    /// AUSTrackingLogContract AusTransactionId
    /// </summary>
    public string? AusTransactionId { get => _ausTransactionId; set => SetField(ref _ausTransactionId, value); }

    /// <summary>
    /// AUSTrackingLogContract AusVersion
    /// </summary>
    public string? AusVersion { get => _ausVersion; set => SetField(ref _ausVersion, value); }

    /// <summary>
    /// AUSTrackingLogContract Balloon
    /// </summary>
    public string? Balloon { get => _balloon; set => SetField(ref _balloon, value); }

    /// <summary>
    /// AUSTrackingLogContract BalloonTerm
    /// </summary>
    public int? BalloonTerm { get => _balloonTerm; set => SetField(ref _balloonTerm, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerAssetAmount
    /// </summary>
    public decimal? BorrowerAssetAmount { get => _borrowerAssetAmount; set => SetField(ref _borrowerAssetAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerAssetName
    /// </summary>
    public string? BorrowerAssetName { get => _borrowerAssetName; set => SetField(ref _borrowerAssetName, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerAssetType
    /// </summary>
    public string? BorrowerAssetType { get => _borrowerAssetType; set => SetField(ref _borrowerAssetType, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerCreditScore1
    /// </summary>
    public string? BorrowerCreditScore1 { get => _borrowerCreditScore1; set => SetField(ref _borrowerCreditScore1, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerCreditScore2
    /// </summary>
    public string? BorrowerCreditScore2 { get => _borrowerCreditScore2; set => SetField(ref _borrowerCreditScore2, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerCreditScore3
    /// </summary>
    public string? BorrowerCreditScore3 { get => _borrowerCreditScore3; set => SetField(ref _borrowerCreditScore3, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerEquifaxBeacon
    /// </summary>
    public string? BorrowerEquifaxBeacon { get => _borrowerEquifaxBeacon; set => SetField(ref _borrowerEquifaxBeacon, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerExperianFico
    /// </summary>
    public string? BorrowerExperianFico { get => _borrowerExperianFico; set => SetField(ref _borrowerExperianFico, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerIncomeAmount
    /// </summary>
    public decimal? BorrowerIncomeAmount { get => _borrowerIncomeAmount; set => SetField(ref _borrowerIncomeAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerIncomeName
    /// </summary>
    public string? BorrowerIncomeName { get => _borrowerIncomeName; set => SetField(ref _borrowerIncomeName, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerIncomeType
    /// </summary>
    public string? BorrowerIncomeType { get => _borrowerIncomeType; set => SetField(ref _borrowerIncomeType, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerInstitutionName
    /// </summary>
    public string? BorrowerInstitutionName { get => _borrowerInstitutionName; set => SetField(ref _borrowerInstitutionName, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerName
    /// </summary>
    public string? BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerScoreName
    /// </summary>
    public string? BorrowerScoreName { get => _borrowerScoreName; set => SetField(ref _borrowerScoreName, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerTransUnionEmpirica
    /// </summary>
    public string? BorrowerTransUnionEmpirica { get => _borrowerTransUnionEmpirica; set => SetField(ref _borrowerTransUnionEmpirica, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerType1
    /// </summary>
    public string? BorrowerType1 { get => _borrowerType1; set => SetField(ref _borrowerType1, value); }

    /// <summary>
    /// AUSTrackingLogContract BorrowerType2
    /// </summary>
    public string? BorrowerType2 { get => _borrowerType2; set => SetField(ref _borrowerType2, value); }

    /// <summary>
    /// AUSTrackingLogContract BoughtDownRate
    /// </summary>
    public decimal? BoughtDownRate { get => _boughtDownRate; set => SetField(ref _boughtDownRate, value); }

    /// <summary>
    /// AUSTrackingLogContract Buydown
    /// </summary>
    public string? Buydown { get => _buydown; set => SetField(ref _buydown, value); }

    /// <summary>
    /// AUSTrackingLogContract CashBack
    /// </summary>
    public decimal? CashBack { get => _cashBack; set => SetField(ref _cashBack, value); }

    /// <summary>
    /// AUSTrackingLogContract CashOutAmount
    /// </summary>
    public decimal? CashOutAmount { get => _cashOutAmount; set => SetField(ref _cashOutAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract Cltv
    /// </summary>
    public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerAssetAmount
    /// </summary>
    public decimal? CoBorrowerAssetAmount { get => _coBorrowerAssetAmount; set => SetField(ref _coBorrowerAssetAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerAssetName
    /// </summary>
    public string? CoBorrowerAssetName { get => _coBorrowerAssetName; set => SetField(ref _coBorrowerAssetName, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerAssetType
    /// </summary>
    public string? CoBorrowerAssetType { get => _coBorrowerAssetType; set => SetField(ref _coBorrowerAssetType, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerCreditScore1
    /// </summary>
    public string? CoBorrowerCreditScore1 { get => _coBorrowerCreditScore1; set => SetField(ref _coBorrowerCreditScore1, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerCreditScore2
    /// </summary>
    public string? CoBorrowerCreditScore2 { get => _coBorrowerCreditScore2; set => SetField(ref _coBorrowerCreditScore2, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerCreditScore3
    /// </summary>
    public string? CoBorrowerCreditScore3 { get => _coBorrowerCreditScore3; set => SetField(ref _coBorrowerCreditScore3, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerEquifaxBeacon
    /// </summary>
    public string? CoBorrowerEquifaxBeacon { get => _coBorrowerEquifaxBeacon; set => SetField(ref _coBorrowerEquifaxBeacon, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerExperianFico
    /// </summary>
    public string? CoBorrowerExperianFico { get => _coBorrowerExperianFico; set => SetField(ref _coBorrowerExperianFico, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerIncomeAmount
    /// </summary>
    public decimal? CoBorrowerIncomeAmount { get => _coBorrowerIncomeAmount; set => SetField(ref _coBorrowerIncomeAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerIncomeName
    /// </summary>
    public string? CoBorrowerIncomeName { get => _coBorrowerIncomeName; set => SetField(ref _coBorrowerIncomeName, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerIncomeType
    /// </summary>
    public string? CoBorrowerIncomeType { get => _coBorrowerIncomeType; set => SetField(ref _coBorrowerIncomeType, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerInstitutionName
    /// </summary>
    public string? CoBorrowerInstitutionName { get => _coBorrowerInstitutionName; set => SetField(ref _coBorrowerInstitutionName, value); }

    /// <summary>
    /// AUSTrackingLogContract CoborrowerName
    /// </summary>
    public string? CoborrowerName { get => _coborrowerName; set => SetField(ref _coborrowerName, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerScoreName
    /// </summary>
    public string? CoBorrowerScoreName { get => _coBorrowerScoreName; set => SetField(ref _coBorrowerScoreName, value); }

    /// <summary>
    /// AUSTrackingLogContract CoBorrowerTransUnionEmpirica
    /// </summary>
    public string? CoBorrowerTransUnionEmpirica { get => _coBorrowerTransUnionEmpirica; set => SetField(ref _coBorrowerTransUnionEmpirica, value); }

    /// <summary>
    /// AUSTrackingLogContract Code1
    /// </summary>
    public string? Code1 { get => _code1; set => SetField(ref _code1, value); }

    /// <summary>
    /// AUSTrackingLogContract Code2
    /// </summary>
    public string? Code2 { get => _code2; set => SetField(ref _code2, value); }

    /// <summary>
    /// AUSTrackingLogContract CodeDescription1
    /// </summary>
    public string? CodeDescription1 { get => _codeDescription1; set => SetField(ref _codeDescription1, value); }

    /// <summary>
    /// AUSTrackingLogContract CodeDescription2
    /// </summary>
    public string? CodeDescription2 { get => _codeDescription2; set => SetField(ref _codeDescription2, value); }

    /// <summary>
    /// AUSTrackingLogContract CommunityLending
    /// </summary>
    public string? CommunityLending { get => _communityLending; set => SetField(ref _communityLending, value); }

    /// <summary>
    /// AUSTrackingLogContract CreatedOn
    /// </summary>
    public DateTime? CreatedOn { get => _createdOn; set => SetField(ref _createdOn, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditAgency1
    /// </summary>
    public string? CreditAgency1 { get => _creditAgency1; set => SetField(ref _creditAgency1, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditAgency2
    /// </summary>
    public string? CreditAgency2 { get => _creditAgency2; set => SetField(ref _creditAgency2, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditReportDate1
    /// </summary>
    public DateTime? CreditReportDate1 { get => _creditReportDate1; set => SetField(ref _creditReportDate1, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditReportDate2
    /// </summary>
    public DateTime? CreditReportDate2 { get => _creditReportDate2; set => SetField(ref _creditReportDate2, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditReportId1
    /// </summary>
    public string? CreditReportId1 { get => _creditReportId1; set => SetField(ref _creditReportId1, value); }

    /// <summary>
    /// AUSTrackingLogContract CreditReportId2
    /// </summary>
    public string? CreditReportId2 { get => _creditReportId2; set => SetField(ref _creditReportId2, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredAmortizationType
    /// </summary>
    public string? CuredAmortizationType { get => _curedAmortizationType; set => SetField(ref _curedAmortizationType, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredAppraisedValue
    /// </summary>
    public int? CuredAppraisedValue { get => _curedAppraisedValue; set => SetField(ref _curedAppraisedValue, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredCltv
    /// </summary>
    public decimal? CuredCltv { get => _curedCltv; set => SetField(ref _curedCltv, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredHousingExpenseRatio
    /// </summary>
    public decimal? CuredHousingExpenseRatio { get => _curedHousingExpenseRatio; set => SetField(ref _curedHousingExpenseRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredLoanPurpose
    /// </summary>
    public string? CuredLoanPurpose { get => _curedLoanPurpose; set => SetField(ref _curedLoanPurpose, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredLoanTerm
    /// </summary>
    public int? CuredLoanTerm { get => _curedLoanTerm; set => SetField(ref _curedLoanTerm, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredLoanType
    /// </summary>
    public string? CuredLoanType { get => _curedLoanType; set => SetField(ref _curedLoanType, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredLtv
    /// </summary>
    public decimal? CuredLtv { get => _curedLtv; set => SetField(ref _curedLtv, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredNoteRate
    /// </summary>
    public decimal? CuredNoteRate { get => _curedNoteRate; set => SetField(ref _curedNoteRate, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredProposedTotalHousingPayment
    /// </summary>
    public decimal? CuredProposedTotalHousingPayment { get => _curedProposedTotalHousingPayment; set => SetField(ref _curedProposedTotalHousingPayment, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredRefinancePurpose
    /// </summary>
    public string? CuredRefinancePurpose { get => _curedRefinancePurpose; set => SetField(ref _curedRefinancePurpose, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredTotalExpenseRatio
    /// </summary>
    public decimal? CuredTotalExpenseRatio { get => _curedTotalExpenseRatio; set => SetField(ref _curedTotalExpenseRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredTotalLoanAmount
    /// </summary>
    public decimal? CuredTotalLoanAmount { get => _curedTotalLoanAmount; set => SetField(ref _curedTotalLoanAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract CuredTotalMonthlyIncome
    /// </summary>
    public decimal? CuredTotalMonthlyIncome { get => _curedTotalMonthlyIncome; set => SetField(ref _curedTotalMonthlyIncome, value); }

    /// <summary>
    /// AUSTrackingLogContract DebtRatio
    /// </summary>
    public decimal? DebtRatio { get => _debtRatio; set => SetField(ref _debtRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract DocumentationLevel
    /// </summary>
    public string? DocumentationLevel { get => _documentationLevel; set => SetField(ref _documentationLevel, value); }

    /// <summary>
    /// AUSTrackingLogContract DuCaseIdorLpausKey
    /// </summary>
    public string? DuCaseIdorLpausKey { get => _duCaseIdorLpausKey; set => SetField(ref _duCaseIdorLpausKey, value); }

    /// <summary>
    /// AUSTrackingLogContract DuPropertyType
    /// </summary>
    public string? DuPropertyType { get => _duPropertyType; set => SetField(ref _duPropertyType, value); }

    /// <summary>
    /// AUSTrackingLogContract EFolderGuid
    /// </summary>
    public string? EFolderGuid { get => _eFolderGuid; set => SetField(ref _eFolderGuid, value); }

    /// <summary>
    /// AUSTrackingLogContract ErrorInfo
    /// </summary>
    public string? ErrorInfo { get => _errorInfo; set => SetField(ref _errorInfo, value); }

    /// <summary>
    /// AUSTrackingLogContract ExcessAvailableAssetsNoVerified
    /// </summary>
    public decimal? ExcessAvailableAssetsNoVerified { get => _excessAvailableAssetsNoVerified; set => SetField(ref _excessAvailableAssetsNoVerified, value); }

    /// <summary>
    /// AUSTrackingLogContract FatalEditInfo
    /// </summary>
    public string? FatalEditInfo { get => _fatalEditInfo; set => SetField(ref _fatalEditInfo, value); }

    /// <summary>
    /// AUSTrackingLogContract FileType
    /// </summary>
    public string? FileType { get => _fileType; set => SetField(ref _fileType, value); }

    /// <summary>
    /// AUSTrackingLogContract FinancedMiAmount
    /// </summary>
    public decimal? FinancedMiAmount { get => _financedMiAmount; set => SetField(ref _financedMiAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract FirstPandI
    /// </summary>
    public decimal? FirstPandI { get => _firstPandI; set => SetField(ref _firstPandI, value); }

    /// <summary>
    /// AUSTrackingLogContract FirstSubmissionDate
    /// </summary>
    public DateTime? FirstSubmissionDate { get => _firstSubmissionDate; set => SetField(ref _firstSubmissionDate, value); }

    /// <summary>
    /// AUSTrackingLogContract FirstSubmissionTime
    /// </summary>
    public string? FirstSubmissionTime { get => _firstSubmissionTime; set => SetField(ref _firstSubmissionTime, value); }

    /// <summary>
    /// AUSTrackingLogContract FreddieDocClass
    /// </summary>
    public string? FreddieDocClass { get => _freddieDocClass; set => SetField(ref _freddieDocClass, value); }

    /// <summary>
    /// AUSTrackingLogContract FundsRequiredClose
    /// </summary>
    public decimal? FundsRequiredClose { get => _fundsRequiredClose; set => SetField(ref _fundsRequiredClose, value); }

    /// <summary>
    /// AUSTrackingLogContract Hlctv
    /// </summary>
    public decimal? Hlctv { get => _hlctv; set => SetField(ref _hlctv, value); }

    /// <summary>
    /// AUSTrackingLogContract HousingExpense
    /// </summary>
    public decimal? HousingExpense { get => _housingExpense; set => SetField(ref _housingExpense, value); }

    /// <summary>
    /// AUSTrackingLogContract HousingExpenseRatio
    /// </summary>
    public decimal? HousingExpenseRatio { get => _housingExpenseRatio; set => SetField(ref _housingExpenseRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract HousingRatio
    /// </summary>
    public decimal? HousingRatio { get => _housingRatio; set => SetField(ref _housingRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract Htltv
    /// </summary>
    public decimal? Htltv { get => _htltv; set => SetField(ref _htltv, value); }

    /// <summary>
    /// AUSTrackingLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// AUSTrackingLogContract IncludingLess10Mos
    /// </summary>
    public string? IncludingLess10Mos { get => _includingLess10Mos; set => SetField(ref _includingLess10Mos, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetBase
    /// </summary>
    public decimal? IncomeAssetBase { get => _incomeAssetBase; set => SetField(ref _incomeAssetBase, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetBonus
    /// </summary>
    public decimal? IncomeAssetBonus { get => _incomeAssetBonus; set => SetField(ref _incomeAssetBonus, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetCommission
    /// </summary>
    public decimal? IncomeAssetCommission { get => _incomeAssetCommission; set => SetField(ref _incomeAssetCommission, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetOther
    /// </summary>
    public decimal? IncomeAssetOther { get => _incomeAssetOther; set => SetField(ref _incomeAssetOther, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetOvertime
    /// </summary>
    public decimal? IncomeAssetOvertime { get => _incomeAssetOvertime; set => SetField(ref _incomeAssetOvertime, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetPosCashFlow
    /// </summary>
    public decimal? IncomeAssetPosCashFlow { get => _incomeAssetPosCashFlow; set => SetField(ref _incomeAssetPosCashFlow, value); }

    /// <summary>
    /// AUSTrackingLogContract IncomeAssetPositiveNetRental
    /// </summary>
    public decimal? IncomeAssetPositiveNetRental { get => _incomeAssetPositiveNetRental; set => SetField(ref _incomeAssetPositiveNetRental, value); }

    /// <summary>
    /// AUSTrackingLogContract IndicatorScore
    /// </summary>
    public string? IndicatorScore { get => _indicatorScore; set => SetField(ref _indicatorScore, value); }

    /// <summary>
    /// AUSTrackingLogContract IntendedUseofProperty
    /// </summary>
    public string? IntendedUseofProperty { get => _intendedUseofProperty; set => SetField(ref _intendedUseofProperty, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceConclusion1
    /// </summary>
    public string? LclaEvaluatedServiceConclusion1 { get => _lclaEvaluatedServiceConclusion1; set => SetField(ref _lclaEvaluatedServiceConclusion1, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceConclusion2
    /// </summary>
    public string? LclaEvaluatedServiceConclusion2 { get => _lclaEvaluatedServiceConclusion2; set => SetField(ref _lclaEvaluatedServiceConclusion2, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceConclusion3
    /// </summary>
    public string? LclaEvaluatedServiceConclusion3 { get => _lclaEvaluatedServiceConclusion3; set => SetField(ref _lclaEvaluatedServiceConclusion3, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceConclusion4
    /// </summary>
    public string? LclaEvaluatedServiceConclusion4 { get => _lclaEvaluatedServiceConclusion4; set => SetField(ref _lclaEvaluatedServiceConclusion4, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceType1
    /// </summary>
    public string? LclaEvaluatedServiceType1 { get => _lclaEvaluatedServiceType1; set => SetField(ref _lclaEvaluatedServiceType1, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceType2
    /// </summary>
    public string? LclaEvaluatedServiceType2 { get => _lclaEvaluatedServiceType2; set => SetField(ref _lclaEvaluatedServiceType2, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceType3
    /// </summary>
    public string? LclaEvaluatedServiceType3 { get => _lclaEvaluatedServiceType3; set => SetField(ref _lclaEvaluatedServiceType3, value); }

    /// <summary>
    /// AUSTrackingLogContract LclaEvaluatedServiceType4
    /// </summary>
    public string? LclaEvaluatedServiceType4 { get => _lclaEvaluatedServiceType4; set => SetField(ref _lclaEvaluatedServiceType4, value); }

    /// <summary>
    /// AUSTrackingLogContract LenderLoan
    /// </summary>
    public string? LenderLoan { get => _lenderLoan; set => SetField(ref _lenderLoan, value); }

    /// <summary>
    /// AUSTrackingLogContract LienType
    /// </summary>
    public string? LienType { get => _lienType; set => SetField(ref _lienType, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanAmount
    /// </summary>
    public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanApplicationId
    /// </summary>
    public string? LoanApplicationId { get => _loanApplicationId; set => SetField(ref _loanApplicationId, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanProcessingStage
    /// </summary>
    public string? LoanProcessingStage { get => _loanProcessingStage; set => SetField(ref _loanProcessingStage, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanProspectorId
    /// </summary>
    public string? LoanProspectorId { get => _loanProspectorId; set => SetField(ref _loanProspectorId, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanPurpose
    /// </summary>
    public string? LoanPurpose { get => _loanPurpose; set => SetField(ref _loanPurpose, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanTerm
    /// </summary>
    public int? LoanTerm { get => _loanTerm; set => SetField(ref _loanTerm, value); }

    /// <summary>
    /// AUSTrackingLogContract LoanType
    /// </summary>
    public string? LoanType { get => _loanType; set => SetField(ref _loanType, value); }

    /// <summary>
    /// AUSTrackingLogContract LpAssmtExpDate
    /// </summary>
    public DateTime? LpAssmtExpDate { get => _lpAssmtExpDate; set => SetField(ref _lpAssmtExpDate, value); }

    /// <summary>
    /// AUSTrackingLogContract LpPropertyType
    /// </summary>
    public string? LpPropertyType { get => _lpPropertyType; set => SetField(ref _lpPropertyType, value); }

    /// <summary>
    /// AUSTrackingLogContract LpVersion
    /// </summary>
    public string? LpVersion { get => _lpVersion; set => SetField(ref _lpVersion, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaCollateralRepWarrantyServiceConclusion
    /// </summary>
    public string? LqaCollateralRepWarrantyServiceConclusion { get => _lqaCollateralRepWarrantyServiceConclusion; set => SetField(ref _lqaCollateralRepWarrantyServiceConclusion, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaCreditRiskAssessmentConclusion
    /// </summary>
    public string? LqaCreditRiskAssessmentConclusion { get => _lqaCreditRiskAssessmentConclusion; set => SetField(ref _lqaCreditRiskAssessmentConclusion, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaDataCompareFieldConclusion
    /// </summary>
    public string? LqaDataCompareFieldConclusion { get => _lqaDataCompareFieldConclusion; set => SetField(ref _lqaDataCompareFieldConclusion, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaDataCompareFieldName
    /// </summary>
    public string? LqaDataCompareFieldName { get => _lqaDataCompareFieldName; set => SetField(ref _lqaDataCompareFieldName, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaDataCompareResult
    /// </summary>
    public string? LqaDataCompareResult { get => _lqaDataCompareResult; set => SetField(ref _lqaDataCompareResult, value); }

    /// <summary>
    /// AUSTrackingLogContract LqalpKey
    /// </summary>
    public string? LqalpKey { get => _lqalpKey; set => SetField(ref _lqalpKey, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaPurchaseEligibilityResult
    /// </summary>
    public string? LqaPurchaseEligibilityResult { get => _lqaPurchaseEligibilityResult; set => SetField(ref _lqaPurchaseEligibilityResult, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaRiskAssessmentKey
    /// </summary>
    public string? LqaRiskAssessmentKey { get => _lqaRiskAssessmentKey; set => SetField(ref _lqaRiskAssessmentKey, value); }

    /// <summary>
    /// AUSTrackingLogContract LqaSubmissionDateTime
    /// </summary>
    public DateTime? LqaSubmissionDateTime { get => _lqaSubmissionDateTime; set => SetField(ref _lqaSubmissionDateTime, value); }

    /// <summary>
    /// AUSTrackingLogContract Ltv
    /// </summary>
    public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

    /// <summary>
    /// AUSTrackingLogContract MaxMortgageLimit
    /// </summary>
    public decimal? MaxMortgageLimit { get => _maxMortgageLimit; set => SetField(ref _maxMortgageLimit, value); }

    /// <summary>
    /// AUSTrackingLogContract MiDecision
    /// </summary>
    public string? MiDecision { get => _miDecision; set => SetField(ref _miDecision, value); }

    /// <summary>
    /// AUSTrackingLogContract MortgageType
    /// </summary>
    public string? MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

    /// <summary>
    /// AUSTrackingLogContract NegAmortizationType
    /// </summary>
    public string? NegAmortizationType { get => _negAmortizationType; set => SetField(ref _negAmortizationType, value); }

    /// <summary>
    /// AUSTrackingLogContract NegativeNetRental
    /// </summary>
    public decimal? NegativeNetRental { get => _negativeNetRental; set => SetField(ref _negativeNetRental, value); }

    /// <summary>
    /// AUSTrackingLogContract NetCashBack
    /// </summary>
    public decimal? NetCashBack { get => _netCashBack; set => SetField(ref _netCashBack, value); }

    /// <summary>
    /// AUSTrackingLogContract NewConstruction
    /// </summary>
    public string? NewConstruction { get => _newConstruction; set => SetField(ref _newConstruction, value); }

    /// <summary>
    /// AUSTrackingLogContract NoteRate
    /// </summary>
    public decimal? NoteRate { get => _noteRate; set => SetField(ref _noteRate, value); }

    /// <summary>
    /// AUSTrackingLogContract NotpNumber
    /// </summary>
    public string? NotpNumber { get => _notpNumber; set => SetField(ref _notpNumber, value); }

    /// <summary>
    /// AUSTrackingLogContract NoUnits
    /// </summary>
    public int? NoUnits { get => _noUnits; set => SetField(ref _noUnits, value); }

    /// <summary>
    /// AUSTrackingLogContract NumberOfSubmissions
    /// </summary>
    public string? NumberOfSubmissions { get => _numberOfSubmissions; set => SetField(ref _numberOfSubmissions, value); }

    /// <summary>
    /// AUSTrackingLogContract OccupancyStatus
    /// </summary>
    public string? OccupancyStatus { get => _occupancyStatus; set => SetField(ref _occupancyStatus, value); }

    /// <summary>
    /// AUSTrackingLogContract OccupantDebtRatio
    /// </summary>
    public decimal? OccupantDebtRatio { get => _occupantDebtRatio; set => SetField(ref _occupantDebtRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract OccupantHousingRatio
    /// </summary>
    public decimal? OccupantHousingRatio { get => _occupantHousingRatio; set => SetField(ref _occupantHousingRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract OfferingIdentifier
    /// </summary>
    public string? OfferingIdentifier { get => _offeringIdentifier; set => SetField(ref _offeringIdentifier, value); }

    /// <summary>
    /// AUSTrackingLogContract OrderStatus
    /// </summary>
    public string? OrderStatus { get => _orderStatus; set => SetField(ref _orderStatus, value); }

    /// <summary>
    /// AUSTrackingLogContract OriginatingCompany
    /// </summary>
    public string? OriginatingCompany { get => _originatingCompany; set => SetField(ref _originatingCompany, value); }

    /// <summary>
    /// AUSTrackingLogContract OwnerExistingMtg
    /// </summary>
    public decimal? OwnerExistingMtg { get => _ownerExistingMtg; set => SetField(ref _ownerExistingMtg, value); }

    /// <summary>
    /// AUSTrackingLogContract PandI
    /// </summary>
    public decimal? PandI { get => _pandI; set => SetField(ref _pandI, value); }

    /// <summary>
    /// AUSTrackingLogContract PaymentFrequency
    /// </summary>
    public int? PaymentFrequency { get => _paymentFrequency; set => SetField(ref _paymentFrequency, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentAddress
    /// </summary>
    public string? PresentAddress { get => _presentAddress; set => SetField(ref _presentAddress, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentAddressCity
    /// </summary>
    public string? PresentAddressCity { get => _presentAddressCity; set => SetField(ref _presentAddressCity, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentAddressState
    /// </summary>
    public string? PresentAddressState { get => _presentAddressState; set => SetField(ref _presentAddressState, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentAddressZipCode
    /// </summary>
    public string? PresentAddressZipCode { get => _presentAddressZipCode; set => SetField(ref _presentAddressZipCode, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentHousingExpense
    /// </summary>
    public decimal? PresentHousingExpense { get => _presentHousingExpense; set => SetField(ref _presentHousingExpense, value); }

    /// <summary>
    /// AUSTrackingLogContract PresentPrincipalHousingPayment
    /// </summary>
    public decimal? PresentPrincipalHousingPayment { get => _presentPrincipalHousingPayment; set => SetField(ref _presentPrincipalHousingPayment, value); }

    /// <summary>
    /// AUSTrackingLogContract PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

    /// <summary>
    /// AUSTrackingLogContract PropertyCity
    /// </summary>
    public string? PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

    /// <summary>
    /// AUSTrackingLogContract PropertyState
    /// </summary>
    public string? PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

    /// <summary>
    /// AUSTrackingLogContract PropertyZipcode
    /// </summary>
    public string? PropertyZipcode { get => _propertyZipcode; set => SetField(ref _propertyZipcode, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedHazardInsurance
    /// </summary>
    public decimal? ProposedHazardInsurance { get => _proposedHazardInsurance; set => SetField(ref _proposedHazardInsurance, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedHoaFees
    /// </summary>
    public decimal? ProposedHoaFees { get => _proposedHoaFees; set => SetField(ref _proposedHoaFees, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedHousingPiti
    /// </summary>
    public decimal? ProposedHousingPiti { get => _proposedHousingPiti; set => SetField(ref _proposedHousingPiti, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedMortgageInsurance
    /// </summary>
    public decimal? ProposedMortgageInsurance { get => _proposedMortgageInsurance; set => SetField(ref _proposedMortgageInsurance, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedOtherPayment
    /// </summary>
    public decimal? ProposedOtherPayment { get => _proposedOtherPayment; set => SetField(ref _proposedOtherPayment, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedTaxes
    /// </summary>
    public decimal? ProposedTaxes { get => _proposedTaxes; set => SetField(ref _proposedTaxes, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedTotalHousingPayment
    /// </summary>
    public decimal? ProposedTotalHousingPayment { get => _proposedTotalHousingPayment; set => SetField(ref _proposedTotalHousingPayment, value); }

    /// <summary>
    /// AUSTrackingLogContract ProposedTotalMonthlyDebt
    /// </summary>
    public decimal? ProposedTotalMonthlyDebt { get => _proposedTotalMonthlyDebt; set => SetField(ref _proposedTotalMonthlyDebt, value); }

    /// <summary>
    /// AUSTrackingLogContract PurchaseEligibility
    /// </summary>
    public string? PurchaseEligibility { get => _purchaseEligibility; set => SetField(ref _purchaseEligibility, value); }

    /// <summary>
    /// AUSTrackingLogContract QualifyingRate
    /// </summary>
    public decimal? QualifyingRate { get => _qualifyingRate; set => SetField(ref _qualifyingRate, value); }

    /// <summary>
    /// AUSTrackingLogContract RecordType
    /// </summary>
    public string? RecordType { get => _recordType; set => SetField(ref _recordType, value); }

    /// <summary>
    /// AUSTrackingLogContract RefinancePurpose
    /// </summary>
    public string? RefinancePurpose { get => _refinancePurpose; set => SetField(ref _refinancePurpose, value); }

    /// <summary>
    /// AUSTrackingLogContract RequestedDateTime
    /// </summary>
    public DateTime? RequestedDateTime { get => _requestedDateTime; set => SetField(ref _requestedDateTime, value); }

    /// <summary>
    /// AUSTrackingLogContract Reserves
    /// </summary>
    public decimal? Reserves { get => _reserves; set => SetField(ref _reserves, value); }

    /// <summary>
    /// AUSTrackingLogContract ReservesRequiredVerified
    /// </summary>
    public decimal? ReservesRequiredVerified { get => _reservesRequiredVerified; set => SetField(ref _reservesRequiredVerified, value); }

    /// <summary>
    /// AUSTrackingLogContract RiskClass
    /// </summary>
    public string? RiskClass { get => _riskClass; set => SetField(ref _riskClass, value); }

    /// <summary>
    /// AUSTrackingLogContract SalesConcessions
    /// </summary>
    public string? SalesConcessions { get => _salesConcessions; set => SetField(ref _salesConcessions, value); }

    /// <summary>
    /// AUSTrackingLogContract SalesPrice
    /// </summary>
    public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }

    /// <summary>
    /// AUSTrackingLogContract SecondPandI
    /// </summary>
    public decimal? SecondPandI { get => _secondPandI; set => SetField(ref _secondPandI, value); }

    /// <summary>
    /// AUSTrackingLogContract SelectedBorrower
    /// </summary>
    public string? SelectedBorrower { get => _selectedBorrower; set => SetField(ref _selectedBorrower, value); }

    /// <summary>
    /// AUSTrackingLogContract SelectedRepository
    /// </summary>
    public string? SelectedRepository { get => _selectedRepository; set => SetField(ref _selectedRepository, value); }

    /// <summary>
    /// AUSTrackingLogContract SellerNumber
    /// </summary>
    public string? SellerNumber { get => _sellerNumber; set => SetField(ref _sellerNumber, value); }

    /// <summary>
    /// AUSTrackingLogContract SubjNegCashFlow
    /// </summary>
    public decimal? SubjNegCashFlow { get => _subjNegCashFlow; set => SetField(ref _subjNegCashFlow, value); }

    /// <summary>
    /// AUSTrackingLogContract SubmissionDate
    /// </summary>
    public DateTime? SubmissionDate { get => _submissionDate; set => SetField(ref _submissionDate, value); }

    /// <summary>
    /// AUSTrackingLogContract SubmissionNumber
    /// </summary>
    public string? SubmissionNumber { get => _submissionNumber; set => SetField(ref _submissionNumber, value); }

    /// <summary>
    /// AUSTrackingLogContract SubmissionTime
    /// </summary>
    public string? SubmissionTime { get => _submissionTime; set => SetField(ref _submissionTime, value); }

    /// <summary>
    /// AUSTrackingLogContract SubmittedBy
    /// </summary>
    public string? SubmittedBy { get => _submittedBy; set => SetField(ref _submittedBy, value); }

    /// <summary>
    /// AUSTrackingLogContract SubmittingCompany
    /// </summary>
    public string? SubmittingCompany { get => _submittingCompany; set => SetField(ref _submittingCompany, value); }

    /// <summary>
    /// AUSTrackingLogContract TemporarySubsidyBuydown
    /// </summary>
    public string? TemporarySubsidyBuydown { get => _temporarySubsidyBuydown; set => SetField(ref _temporarySubsidyBuydown, value); }

    /// <summary>
    /// AUSTrackingLogContract Tltv
    /// </summary>
    public decimal? Tltv { get => _tltv; set => SetField(ref _tltv, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalAsset
    /// </summary>
    public decimal? TotalAsset { get => _totalAsset; set => SetField(ref _totalAsset, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalExpense
    /// </summary>
    public decimal? TotalExpense { get => _totalExpense; set => SetField(ref _totalExpense, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalExpensePmt
    /// </summary>
    public decimal? TotalExpensePmt { get => _totalExpensePmt; set => SetField(ref _totalExpensePmt, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalExpenseRatio
    /// </summary>
    public decimal? TotalExpenseRatio { get => _totalExpenseRatio; set => SetField(ref _totalExpenseRatio, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalFundsVerified
    /// </summary>
    public decimal? TotalFundsVerified { get => _totalFundsVerified; set => SetField(ref _totalFundsVerified, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalLoanAmount
    /// </summary>
    public decimal? TotalLoanAmount { get => _totalLoanAmount; set => SetField(ref _totalLoanAmount, value); }

    /// <summary>
    /// AUSTrackingLogContract TotalMonthlyIncome
    /// </summary>
    public decimal? TotalMonthlyIncome { get => _totalMonthlyIncome; set => SetField(ref _totalMonthlyIncome, value); }

    /// <summary>
    /// AUSTrackingLogContract TpoNumber
    /// </summary>
    public string? TpoNumber { get => _tpoNumber; set => SetField(ref _tpoNumber, value); }

    /// <summary>
    /// AUSTrackingLogContract TransactionId
    /// </summary>
    public string? TransactionId { get => _transactionId; set => SetField(ref _transactionId, value); }

    /// <summary>
    /// AUSTrackingLogContract UnderwritingRiskAssessOther
    /// </summary>
    public string? UnderwritingRiskAssessOther { get => _underwritingRiskAssessOther; set => SetField(ref _underwritingRiskAssessOther, value); }

    /// <summary>
    /// AUSTrackingLogContract UnderwritingRiskAssessType
    /// </summary>
    public string? UnderwritingRiskAssessType { get => _underwritingRiskAssessType; set => SetField(ref _underwritingRiskAssessType, value); }

    /// <summary>
    /// AUSTrackingLogContract WithUndisclosedDebt
    /// </summary>
    public string? WithUndisclosedDebt { get => _withUndisclosedDebt; set => SetField(ref _withUndisclosedDebt, value); }
}