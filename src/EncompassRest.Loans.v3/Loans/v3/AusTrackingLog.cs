using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AusTrackingLog
/// </summary>
public sealed partial class AusTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AusTrackingLog AcceptPlusEligible
    /// </summary>
    public string? AcceptPlusEligible { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AffordableProductType
    /// </summary>
    public string? AffordableProductType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AllOtherPayments
    /// </summary>
    public decimal? AllOtherPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AmortizationMonths
    /// </summary>
    public int? AmortizationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AmortizationType
    /// </summary>
    public string? AmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AmtSubordinateFin
    /// </summary>
    public decimal? AmtSubordinateFin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AppraisalTypeMaf
    /// </summary>
    public string? AppraisalTypeMaf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AppraisedValue
    /// </summary>
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ArmQualifyingRate
    /// </summary>
    public decimal? ArmQualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AssessedDateTime
    /// </summary>
    public DateTime? AssessedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AssessmentType
    /// </summary>
    public string? AssessmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusAverageMedianCreditScore
    /// </summary>
    public string? AusAverageMedianCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusLogExtensionId
    /// </summary>
    public string? AusLogExtensionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusOrderLinkId
    /// </summary>
    public string? AusOrderLinkId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusRecommendation
    /// </summary>
    public string? AusRecommendation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusResponseFileName
    /// </summary>
    public string? AusResponseFileName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusStatus
    /// </summary>
    public string? AusStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusTrackingType
    /// </summary>
    public string? AusTrackingType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusTransactionId
    /// </summary>
    public string? AusTransactionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog AusVersion
    /// </summary>
    public string? AusVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Balloon
    /// </summary>
    public string? Balloon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BalloonTerm
    /// </summary>
    public int? BalloonTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerAssetAmount
    /// </summary>
    public decimal? BorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerAssetName
    /// </summary>
    public string? BorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerAssetType
    /// </summary>
    public string? BorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerCreditScore1
    /// </summary>
    public string? BorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerCreditScore2
    /// </summary>
    public string? BorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerCreditScore3
    /// </summary>
    public string? BorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerEquifaxBeacon
    /// </summary>
    public string? BorrowerEquifaxBeacon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerExperianFico
    /// </summary>
    public string? BorrowerExperianFico { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerIncomeAmount
    /// </summary>
    public decimal? BorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerIncomeName
    /// </summary>
    public string? BorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerIncomeType
    /// </summary>
    public string? BorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerInstitutionName
    /// </summary>
    public string? BorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerName
    /// </summary>
    public string? BorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerScoreName
    /// </summary>
    public string? BorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerTransUnionEmpirica
    /// </summary>
    public string? BorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerType1
    /// </summary>
    public string? BorrowerType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BorrowerType2
    /// </summary>
    public string? BorrowerType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog BoughtDownRate
    /// </summary>
    public decimal? BoughtDownRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Buydown
    /// </summary>
    public string? Buydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CashBack
    /// </summary>
    public decimal? CashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CashOutAmount
    /// </summary>
    public decimal? CashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Cltv
    /// </summary>
    public decimal? Cltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerAssetAmount
    /// </summary>
    public decimal? CoBorrowerAssetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerAssetName
    /// </summary>
    public string? CoBorrowerAssetName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerAssetType
    /// </summary>
    public string? CoBorrowerAssetType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerCreditScore1
    /// </summary>
    public string? CoBorrowerCreditScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerCreditScore2
    /// </summary>
    public string? CoBorrowerCreditScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerCreditScore3
    /// </summary>
    public string? CoBorrowerCreditScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerEquifaxBeacon
    /// </summary>
    public string? CoBorrowerEquifaxBeacon { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerExperianFico
    /// </summary>
    public string? CoBorrowerExperianFico { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerIncomeAmount
    /// </summary>
    public decimal? CoBorrowerIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerIncomeName
    /// </summary>
    public string? CoBorrowerIncomeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerIncomeType
    /// </summary>
    public string? CoBorrowerIncomeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerInstitutionName
    /// </summary>
    public string? CoBorrowerInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoborrowerName
    /// </summary>
    public string? CoborrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerScoreName
    /// </summary>
    public string? CoBorrowerScoreName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CoBorrowerTransUnionEmpirica
    /// </summary>
    public string? CoBorrowerTransUnionEmpirica { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Code1
    /// </summary>
    public string? Code1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Code2
    /// </summary>
    public string? Code2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CodeDescription1
    /// </summary>
    public string? CodeDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CodeDescription2
    /// </summary>
    public string? CodeDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CommunityLending
    /// </summary>
    public string? CommunityLending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreatedOn
    /// </summary>
    public DateTime? CreatedOn { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditAgency1
    /// </summary>
    public string? CreditAgency1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditAgency2
    /// </summary>
    public string? CreditAgency2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditReportDate1
    /// </summary>
    public DateTime? CreditReportDate1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditReportDate2
    /// </summary>
    public DateTime? CreditReportDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditReportId1
    /// </summary>
    public string? CreditReportId1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CreditReportId2
    /// </summary>
    public string? CreditReportId2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredAmortizationType
    /// </summary>
    public string? CuredAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredAppraisedValue
    /// </summary>
    public int? CuredAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredAusAverageMedianCreditScore
    /// </summary>
    public string? CuredAusAverageMedianCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredCltv
    /// </summary>
    public decimal? CuredCltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredHousingExpenseRatio
    /// </summary>
    public decimal? CuredHousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredLoanPurpose
    /// </summary>
    public string? CuredLoanPurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredLoanTerm
    /// </summary>
    public int? CuredLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredLoanType
    /// </summary>
    public string? CuredLoanType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredLtv
    /// </summary>
    public decimal? CuredLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredNoteRate
    /// </summary>
    public decimal? CuredNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredProposedTotalHousingPayment
    /// </summary>
    public decimal? CuredProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredRefinancePurpose
    /// </summary>
    public string? CuredRefinancePurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredTotalExpenseRatio
    /// </summary>
    public decimal? CuredTotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredTotalLoanAmount
    /// </summary>
    public decimal? CuredTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog CuredTotalMonthlyIncome
    /// </summary>
    public decimal? CuredTotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog DebtRatio
    /// </summary>
    public decimal? DebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog DocumentationLevel
    /// </summary>
    public string? DocumentationLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog DuCaseIdorLpausKey
    /// </summary>
    public string? DuCaseIdorLpausKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog DuPropertyType
    /// </summary>
    public string? DuPropertyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog EFolderGuid
    /// </summary>
    public string? EFolderGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ErrorInfo
    /// </summary>
    public string? ErrorInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ExcessAvailableAssetsNoVerified
    /// </summary>
    public decimal? ExcessAvailableAssetsNoVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FatalEditInfo
    /// </summary>
    public string? FatalEditInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FileType
    /// </summary>
    public string? FileType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FinancedMiAmount
    /// </summary>
    public decimal? FinancedMiAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FirstPandI
    /// </summary>
    public decimal? FirstPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FirstSubmissionDate
    /// </summary>
    public DateTime? FirstSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FirstSubmissionTime
    /// </summary>
    public string? FirstSubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FreddieDocClass
    /// </summary>
    public string? FreddieDocClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog FundsRequiredClose
    /// </summary>
    public decimal? FundsRequiredClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Hlctv
    /// </summary>
    public decimal? Hlctv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog HousingExpense
    /// </summary>
    public decimal? HousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog HousingExpenseRatio
    /// </summary>
    public decimal? HousingExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog HousingRatio
    /// </summary>
    public decimal? HousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Htltv
    /// </summary>
    public decimal? Htltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncludingLess10Mos
    /// </summary>
    public string? IncludingLess10Mos { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetBase
    /// </summary>
    public decimal? IncomeAssetBase { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetBonus
    /// </summary>
    public decimal? IncomeAssetBonus { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetCommission
    /// </summary>
    public decimal? IncomeAssetCommission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetOther
    /// </summary>
    public decimal? IncomeAssetOther { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetOvertime
    /// </summary>
    public decimal? IncomeAssetOvertime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetPosCashFlow
    /// </summary>
    public decimal? IncomeAssetPosCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IncomeAssetPositiveNetRental
    /// </summary>
    public decimal? IncomeAssetPositiveNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IndicatorScore
    /// </summary>
    public string? IndicatorScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog IntendedUseofProperty
    /// </summary>
    public string? IntendedUseofProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceConclusion1
    /// </summary>
    public string? LclaEvaluatedServiceConclusion1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceConclusion2
    /// </summary>
    public string? LclaEvaluatedServiceConclusion2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceConclusion3
    /// </summary>
    public string? LclaEvaluatedServiceConclusion3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceConclusion4
    /// </summary>
    public string? LclaEvaluatedServiceConclusion4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceType1
    /// </summary>
    public string? LclaEvaluatedServiceType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceType2
    /// </summary>
    public string? LclaEvaluatedServiceType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceType3
    /// </summary>
    public string? LclaEvaluatedServiceType3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LclaEvaluatedServiceType4
    /// </summary>
    public string? LclaEvaluatedServiceType4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LenderLoan
    /// </summary>
    public string? LenderLoan { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LienType
    /// </summary>
    public string? LienType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanAmount
    /// </summary>
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanApplicationId
    /// </summary>
    public string? LoanApplicationId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanProcessingStage
    /// </summary>
    public string? LoanProcessingStage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanProspectorId
    /// </summary>
    public string? LoanProspectorId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanPurpose
    /// </summary>
    public string? LoanPurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanTerm
    /// </summary>
    public int? LoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LoanType
    /// </summary>
    public string? LoanType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LpAssmtExpDate
    /// </summary>
    public DateTime? LpAssmtExpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LpPropertyType
    /// </summary>
    public string? LpPropertyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LpVersion
    /// </summary>
    public string? LpVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaCollateralRepWarrantyServiceConclusion
    /// </summary>
    public string? LqaCollateralRepWarrantyServiceConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaCreditRiskAssessmentConclusion
    /// </summary>
    public string? LqaCreditRiskAssessmentConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaDataCompareFieldConclusion
    /// </summary>
    public string? LqaDataCompareFieldConclusion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaDataCompareFieldName
    /// </summary>
    public string? LqaDataCompareFieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaDataCompareResult
    /// </summary>
    public string? LqaDataCompareResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqalpKey
    /// </summary>
    public string? LqalpKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaPurchaseEligibilityResult
    /// </summary>
    public string? LqaPurchaseEligibilityResult { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaRiskAssessmentKey
    /// </summary>
    public string? LqaRiskAssessmentKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog LqaSubmissionDateTime
    /// </summary>
    public DateTime? LqaSubmissionDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Ltv
    /// </summary>
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog MaxMortgageLimit
    /// </summary>
    public decimal? MaxMortgageLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog MiDecision
    /// </summary>
    public string? MiDecision { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog MortgageType
    /// </summary>
    public string? MortgageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NegAmortizationType
    /// </summary>
    public string? NegAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NegativeNetRental
    /// </summary>
    public decimal? NegativeNetRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NetCashBack
    /// </summary>
    public decimal? NetCashBack { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NewConstruction
    /// </summary>
    public string? NewConstruction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NoteRate
    /// </summary>
    public decimal? NoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NotpNumber
    /// </summary>
    public string? NotpNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NoUnits
    /// </summary>
    public int? NoUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog NumberOfSubmissions
    /// </summary>
    public string? NumberOfSubmissions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OccupancyStatus
    /// </summary>
    public string? OccupancyStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OccupantDebtRatio
    /// </summary>
    public decimal? OccupantDebtRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OccupantHousingRatio
    /// </summary>
    public decimal? OccupantHousingRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OfferingIdentifier
    /// </summary>
    public string? OfferingIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OrderStatus
    /// </summary>
    public string? OrderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OriginatingCompany
    /// </summary>
    public string? OriginatingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog OwnerExistingMtg
    /// </summary>
    public decimal? OwnerExistingMtg { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PandI
    /// </summary>
    public decimal? PandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PaymentFrequency
    /// </summary>
    public int? PaymentFrequency { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentAddress
    /// </summary>
    public string? PresentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentAddressCity
    /// </summary>
    public string? PresentAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentAddressState
    /// </summary>
    public string? PresentAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentAddressZipCode
    /// </summary>
    public string? PresentAddressZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentHousingExpense
    /// </summary>
    public decimal? PresentHousingExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PresentPrincipalHousingPayment
    /// </summary>
    public decimal? PresentPrincipalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PropertyCity
    /// </summary>
    public string? PropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PropertyState
    /// </summary>
    public string? PropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PropertyZipcode
    /// </summary>
    public string? PropertyZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedHazardInsurance
    /// </summary>
    public decimal? ProposedHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedHoaFees
    /// </summary>
    public decimal? ProposedHoaFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedHousingPiti
    /// </summary>
    public decimal? ProposedHousingPiti { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedMortgageInsurance
    /// </summary>
    public decimal? ProposedMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedOtherPayment
    /// </summary>
    public decimal? ProposedOtherPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedTaxes
    /// </summary>
    public decimal? ProposedTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedTotalHousingPayment
    /// </summary>
    public decimal? ProposedTotalHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ProposedTotalMonthlyDebt
    /// </summary>
    public decimal? ProposedTotalMonthlyDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog PurchaseEligibility
    /// </summary>
    public string? PurchaseEligibility { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog QualifyingRate
    /// </summary>
    public decimal? QualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog RecordType
    /// </summary>
    public string? RecordType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog RefinancePurpose
    /// </summary>
    public string? RefinancePurpose { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog RequestedDateTime
    /// </summary>
    public DateTime? RequestedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Reserves
    /// </summary>
    public decimal? Reserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog ReservesRequiredVerified
    /// </summary>
    public decimal? ReservesRequiredVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog RiskClass
    /// </summary>
    public string? RiskClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SalesConcessions
    /// </summary>
    public string? SalesConcessions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SalesPrice
    /// </summary>
    public decimal? SalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SecondPandI
    /// </summary>
    public decimal? SecondPandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SelectedBorrower
    /// </summary>
    public string? SelectedBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SelectedRepository
    /// </summary>
    public string? SelectedRepository { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SellerNumber
    /// </summary>
    public string? SellerNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubjNegCashFlow
    /// </summary>
    public decimal? SubjNegCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubmissionDate
    /// </summary>
    public DateTime? SubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubmissionNumber
    /// </summary>
    public string? SubmissionNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubmissionTime
    /// </summary>
    public string? SubmissionTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubmittedBy
    /// </summary>
    public string? SubmittedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog SubmittingCompany
    /// </summary>
    public string? SubmittingCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TemporarySubsidyBuydown
    /// </summary>
    public string? TemporarySubsidyBuydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog Tltv
    /// </summary>
    public decimal? Tltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalAsset
    /// </summary>
    public decimal? TotalAsset { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalExpense
    /// </summary>
    public decimal? TotalExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalExpensePmt
    /// </summary>
    public decimal? TotalExpensePmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalExpenseRatio
    /// </summary>
    public decimal? TotalExpenseRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalFundsVerified
    /// </summary>
    public decimal? TotalFundsVerified { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalLoanAmount
    /// </summary>
    public decimal? TotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TotalMonthlyIncome
    /// </summary>
    public decimal? TotalMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TpoNumber
    /// </summary>
    public string? TpoNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog TransactionId
    /// </summary>
    public string? TransactionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog UnderwritingRiskAssessOther
    /// </summary>
    public string? UnderwritingRiskAssessOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog UnderwritingRiskAssessType
    /// </summary>
    public string? UnderwritingRiskAssessType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AusTrackingLog WithUndisclosedDebt
    /// </summary>
    public string? WithUndisclosedDebt { get => GetValue<string?>(); set => SetValue(value); }
}