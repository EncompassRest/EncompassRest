using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AUSTrackingLog
    {
        public Value<int?> AUSTrackingLogIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSTrackingLogIndex() => !AUSTrackingLogIndex.Clean;
        public Value<string> BatchDocumentRefId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBatchDocumentRefId() => !BatchDocumentRefId.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsEmpty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmpty() => !IsEmpty.Clean;
        public Value<bool?> IsHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsHistory() => !IsHistory.Clean;
        public Value<string> Log_AcceptPlusEligible { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AcceptPlusEligible() => !Log_AcceptPlusEligible.Clean;
        public Value<string> Log_AffordableProductType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AffordableProductType() => !Log_AffordableProductType.Clean;
        public Value<decimal?> Log_AllOtherPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AllOtherPayments() => !Log_AllOtherPayments.Clean;
        public Value<int?> Log_AmortizationMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AmortizationMonths() => !Log_AmortizationMonths.Clean;
        public Value<string> Log_AmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AmortizationType() => !Log_AmortizationType.Clean;
        public Value<decimal?> Log_AmtSubordinateFin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AmtSubordinateFin() => !Log_AmtSubordinateFin.Clean;
        public Value<string> Log_AppraisalTypeMAF { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AppraisalTypeMAF() => !Log_AppraisalTypeMAF.Clean;
        public Value<int?> Log_AppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AppraisedValue() => !Log_AppraisedValue.Clean;
        public Value<decimal?> Log_ARMQualifyingRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ARMQualifyingRate() => !Log_ARMQualifyingRate.Clean;
        public Value<string> Log_AssessmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AssessmentType() => !Log_AssessmentType.Clean;
        public Value<string> Log_AUSRecommendation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AUSRecommendation() => !Log_AUSRecommendation.Clean;
        public Value<string> Log_AUSStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AUSStatus() => !Log_AUSStatus.Clean;
        public Value<string> Log_AUSTrackingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AUSTrackingType() => !Log_AUSTrackingType.Clean;
        public Value<string> Log_AUSTransactionID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AUSTransactionID() => !Log_AUSTransactionID.Clean;
        public Value<string> Log_AUSVersion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_AUSVersion() => !Log_AUSVersion.Clean;
        public Value<string> Log_Balloon { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_Balloon() => !Log_Balloon.Clean;
        public Value<int?> Log_BalloonTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BalloonTerm() => !Log_BalloonTerm.Clean;
        public Value<decimal?> Log_BorrowerAssetAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerAssetAmount() => !Log_BorrowerAssetAmount.Clean;
        public Value<string> Log_BorrowerAssetName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerAssetName() => !Log_BorrowerAssetName.Clean;
        public Value<string> Log_BorrowerAssetType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerAssetType() => !Log_BorrowerAssetType.Clean;
        public Value<string> Log_BorrowerCreditScore1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerCreditScore1() => !Log_BorrowerCreditScore1.Clean;
        public Value<string> Log_BorrowerCreditScore2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerCreditScore2() => !Log_BorrowerCreditScore2.Clean;
        public Value<string> Log_BorrowerCreditScore3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerCreditScore3() => !Log_BorrowerCreditScore3.Clean;
        public Value<string> Log_BorrowerEquifaxBEACON { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerEquifaxBEACON() => !Log_BorrowerEquifaxBEACON.Clean;
        public Value<string> Log_BorrowerExperianFICO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerExperianFICO() => !Log_BorrowerExperianFICO.Clean;
        public Value<decimal?> Log_BorrowerIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerIncomeAmount() => !Log_BorrowerIncomeAmount.Clean;
        public Value<string> Log_BorrowerIncomeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerIncomeName() => !Log_BorrowerIncomeName.Clean;
        public Value<string> Log_BorrowerIncomeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerIncomeType() => !Log_BorrowerIncomeType.Clean;
        public Value<string> Log_BorrowerInstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerInstitutionName() => !Log_BorrowerInstitutionName.Clean;
        public Value<string> Log_BorrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerName() => !Log_BorrowerName.Clean;
        public Value<string> Log_BorrowerScoreName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerScoreName() => !Log_BorrowerScoreName.Clean;
        public Value<string> Log_BorrowerTransUnionEmpirica { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerTransUnionEmpirica() => !Log_BorrowerTransUnionEmpirica.Clean;
        public Value<string> Log_BorrowerType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerType1() => !Log_BorrowerType1.Clean;
        public Value<string> Log_BorrowerType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BorrowerType2() => !Log_BorrowerType2.Clean;
        public Value<decimal?> Log_BoughtDownRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_BoughtDownRate() => !Log_BoughtDownRate.Clean;
        public Value<string> Log_Buydown { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_Buydown() => !Log_Buydown.Clean;
        public Value<decimal?> Log_CashBack { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CashBack() => !Log_CashBack.Clean;
        public Value<decimal?> Log_CashOutAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CashOutAmount() => !Log_CashOutAmount.Clean;
        public Value<decimal?> Log_CLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CLTV() => !Log_CLTV.Clean;
        public Value<decimal?> Log_CoBorrowerAssetAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerAssetAmount() => !Log_CoBorrowerAssetAmount.Clean;
        public Value<string> Log_CoBorrowerAssetName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerAssetName() => !Log_CoBorrowerAssetName.Clean;
        public Value<string> Log_CoBorrowerAssetType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerAssetType() => !Log_CoBorrowerAssetType.Clean;
        public Value<string> Log_CoBorrowerCreditScore1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerCreditScore1() => !Log_CoBorrowerCreditScore1.Clean;
        public Value<string> Log_CoBorrowerCreditScore2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerCreditScore2() => !Log_CoBorrowerCreditScore2.Clean;
        public Value<string> Log_CoBorrowerCreditScore3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerCreditScore3() => !Log_CoBorrowerCreditScore3.Clean;
        public Value<string> Log_CoBorrowerEquifaxBEACON { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerEquifaxBEACON() => !Log_CoBorrowerEquifaxBEACON.Clean;
        public Value<string> Log_CoBorrowerExperianFICO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerExperianFICO() => !Log_CoBorrowerExperianFICO.Clean;
        public Value<decimal?> Log_CoBorrowerIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerIncomeAmount() => !Log_CoBorrowerIncomeAmount.Clean;
        public Value<string> Log_CoBorrowerIncomeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerIncomeName() => !Log_CoBorrowerIncomeName.Clean;
        public Value<string> Log_CoBorrowerIncomeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerIncomeType() => !Log_CoBorrowerIncomeType.Clean;
        public Value<string> Log_CoBorrowerInstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerInstitutionName() => !Log_CoBorrowerInstitutionName.Clean;
        public Value<string> Log_CoborrowerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoborrowerName() => !Log_CoborrowerName.Clean;
        public Value<string> Log_CoBorrowerScoreName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerScoreName() => !Log_CoBorrowerScoreName.Clean;
        public Value<string> Log_CoBorrowerTransUnionEmpirica { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CoBorrowerTransUnionEmpirica() => !Log_CoBorrowerTransUnionEmpirica.Clean;
        public Value<string> Log_Code1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_Code1() => !Log_Code1.Clean;
        public Value<string> Log_Code2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_Code2() => !Log_Code2.Clean;
        public Value<string> Log_CodeDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CodeDescription1() => !Log_CodeDescription1.Clean;
        public Value<string> Log_CodeDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CodeDescription2() => !Log_CodeDescription2.Clean;
        public Value<string> Log_CommunityLending { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CommunityLending() => !Log_CommunityLending.Clean;
        public Value<DateTime?> Log_CreatedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreatedOn() => !Log_CreatedOn.Clean;
        public Value<string> Log_CreditAgency1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditAgency1() => !Log_CreditAgency1.Clean;
        public Value<string> Log_CreditAgency2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditAgency2() => !Log_CreditAgency2.Clean;
        public Value<DateTime?> Log_CreditReportDate1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditReportDate1() => !Log_CreditReportDate1.Clean;
        public Value<DateTime?> Log_CreditReportDate2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditReportDate2() => !Log_CreditReportDate2.Clean;
        public Value<string> Log_CreditReportID1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditReportID1() => !Log_CreditReportID1.Clean;
        public Value<string> Log_CreditReportID2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CreditReportID2() => !Log_CreditReportID2.Clean;
        public Value<string> Log_CuredAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredAmortizationType() => !Log_CuredAmortizationType.Clean;
        public Value<int?> Log_CuredAppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredAppraisedValue() => !Log_CuredAppraisedValue.Clean;
        public Value<decimal?> Log_CuredCLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredCLTV() => !Log_CuredCLTV.Clean;
        public Value<decimal?> Log_CuredHousingExpenseRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredHousingExpenseRatio() => !Log_CuredHousingExpenseRatio.Clean;
        public Value<string> Log_CuredLoanPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredLoanPurpose() => !Log_CuredLoanPurpose.Clean;
        public Value<int?> Log_CuredLoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredLoanTerm() => !Log_CuredLoanTerm.Clean;
        public Value<string> Log_CuredLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredLoanType() => !Log_CuredLoanType.Clean;
        public Value<decimal?> Log_CuredLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredLTV() => !Log_CuredLTV.Clean;
        public Value<decimal?> Log_CuredNoteRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredNoteRate() => !Log_CuredNoteRate.Clean;
        public Value<decimal?> Log_CuredProposedTotalHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredProposedTotalHousingPayment() => !Log_CuredProposedTotalHousingPayment.Clean;
        public Value<string> Log_CuredRefinancePurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredRefinancePurpose() => !Log_CuredRefinancePurpose.Clean;
        public Value<decimal?> Log_CuredTotalExpenseRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredTotalExpenseRatio() => !Log_CuredTotalExpenseRatio.Clean;
        public Value<decimal?> Log_CuredTotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredTotalLoanAmount() => !Log_CuredTotalLoanAmount.Clean;
        public Value<decimal?> Log_CuredTotalMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_CuredTotalMonthlyIncome() => !Log_CuredTotalMonthlyIncome.Clean;
        public Value<string> Log_DateTimeAssessed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DateTimeAssessed() => !Log_DateTimeAssessed.Clean;
        public Value<string> Log_DateTimeRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DateTimeRequested() => !Log_DateTimeRequested.Clean;
        public Value<decimal?> Log_DebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DebtRatio() => !Log_DebtRatio.Clean;
        public Value<string> Log_DocumentationLevel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DocumentationLevel() => !Log_DocumentationLevel.Clean;
        public Value<string> Log_DUCaseIDorLPAUSKey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DUCaseIDorLPAUSKey() => !Log_DUCaseIDorLPAUSKey.Clean;
        public Value<string> Log_DUPropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_DUPropertyType() => !Log_DUPropertyType.Clean;
        public Value<string> Log_eFolderGUID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_eFolderGUID() => !Log_eFolderGUID.Clean;
        public Value<decimal?> Log_ExcessAvailableAssetsNoVerified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ExcessAvailableAssetsNoVerified() => !Log_ExcessAvailableAssetsNoVerified.Clean;
        public Value<decimal?> Log_FinancedMIAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FinancedMIAmount() => !Log_FinancedMIAmount.Clean;
        public Value<decimal?> Log_FirstPandI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FirstPandI() => !Log_FirstPandI.Clean;
        public Value<DateTime?> Log_FirstSubmissionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FirstSubmissionDate() => !Log_FirstSubmissionDate.Clean;
        public Value<string> Log_FirstSubmissionTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FirstSubmissionTime() => !Log_FirstSubmissionTime.Clean;
        public Value<string> Log_FreddieDocClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FreddieDocClass() => !Log_FreddieDocClass.Clean;
        public Value<decimal?> Log_FundsRequiredClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_FundsRequiredClose() => !Log_FundsRequiredClose.Clean;
        public Value<string> Log_GUID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_GUID() => !Log_GUID.Clean;
        public Value<decimal?> Log_HLCTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_HLCTV() => !Log_HLCTV.Clean;
        public Value<decimal?> Log_HousingExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_HousingExpense() => !Log_HousingExpense.Clean;
        public Value<decimal?> Log_HousingExpenseRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_HousingExpenseRatio() => !Log_HousingExpenseRatio.Clean;
        public Value<decimal?> Log_HousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_HousingRatio() => !Log_HousingRatio.Clean;
        public Value<decimal?> Log_HTLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_HTLTV() => !Log_HTLTV.Clean;
        public Value<string> Log_IncludingLess10Mos { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncludingLess10Mos() => !Log_IncludingLess10Mos.Clean;
        public Value<decimal?> Log_IncomeAssetBase { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetBase() => !Log_IncomeAssetBase.Clean;
        public Value<decimal?> Log_IncomeAssetBonus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetBonus() => !Log_IncomeAssetBonus.Clean;
        public Value<decimal?> Log_IncomeAssetCommission { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetCommission() => !Log_IncomeAssetCommission.Clean;
        public Value<decimal?> Log_IncomeAssetOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetOther() => !Log_IncomeAssetOther.Clean;
        public Value<decimal?> Log_IncomeAssetOvertime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetOvertime() => !Log_IncomeAssetOvertime.Clean;
        public Value<decimal?> Log_IncomeAssetPosCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetPosCashFlow() => !Log_IncomeAssetPosCashFlow.Clean;
        public Value<decimal?> Log_IncomeAssetPositiveNetRental { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IncomeAssetPositiveNetRental() => !Log_IncomeAssetPositiveNetRental.Clean;
        public Value<string> Log_IndicatorScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IndicatorScore() => !Log_IndicatorScore.Clean;
        public Value<string> Log_IntendedUseofProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_IntendedUseofProperty() => !Log_IntendedUseofProperty.Clean;
        public Value<string> Log_LCLAEvaluatedServiceConclusion1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceConclusion1() => !Log_LCLAEvaluatedServiceConclusion1.Clean;
        public Value<string> Log_LCLAEvaluatedServiceConclusion2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceConclusion2() => !Log_LCLAEvaluatedServiceConclusion2.Clean;
        public Value<string> Log_LCLAEvaluatedServiceConclusion3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceConclusion3() => !Log_LCLAEvaluatedServiceConclusion3.Clean;
        public Value<string> Log_LCLAEvaluatedServiceConclusion4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceConclusion4() => !Log_LCLAEvaluatedServiceConclusion4.Clean;
        public Value<string> Log_LCLAEvaluatedServiceType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceType1() => !Log_LCLAEvaluatedServiceType1.Clean;
        public Value<string> Log_LCLAEvaluatedServiceType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceType2() => !Log_LCLAEvaluatedServiceType2.Clean;
        public Value<string> Log_LCLAEvaluatedServiceType3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceType3() => !Log_LCLAEvaluatedServiceType3.Clean;
        public Value<string> Log_LCLAEvaluatedServiceType4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LCLAEvaluatedServiceType4() => !Log_LCLAEvaluatedServiceType4.Clean;
        public Value<string> Log_LenderLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LenderLoan() => !Log_LenderLoan.Clean;
        public Value<string> Log_LienType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LienType() => !Log_LienType.Clean;
        public Value<decimal?> Log_LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanAmount() => !Log_LoanAmount.Clean;
        public Value<string> Log_LoanApplicationID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanApplicationID() => !Log_LoanApplicationID.Clean;
        public Value<string> Log_LoanProcessingStage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanProcessingStage() => !Log_LoanProcessingStage.Clean;
        public Value<string> Log_LoanProspectorID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanProspectorID() => !Log_LoanProspectorID.Clean;
        public Value<string> Log_LoanPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanPurpose() => !Log_LoanPurpose.Clean;
        public Value<int?> Log_LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanTerm() => !Log_LoanTerm.Clean;
        public Value<string> Log_LoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LoanType() => !Log_LoanType.Clean;
        public Value<DateTime?> Log_LPAssmtExpDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LPAssmtExpDate() => !Log_LPAssmtExpDate.Clean;
        public Value<string> Log_LPPropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LPPropertyType() => !Log_LPPropertyType.Clean;
        public Value<string> Log_LPVersion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LPVersion() => !Log_LPVersion.Clean;
        public Value<string> Log_LQACollateralRepWarrantyServiceConclusion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQACollateralRepWarrantyServiceConclusion() => !Log_LQACollateralRepWarrantyServiceConclusion.Clean;
        public Value<string> Log_LQACreditRiskAssessmentConclusion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQACreditRiskAssessmentConclusion() => !Log_LQACreditRiskAssessmentConclusion.Clean;
        public Value<string> Log_LQADataCompareFieldConclusion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQADataCompareFieldConclusion() => !Log_LQADataCompareFieldConclusion.Clean;
        public Value<string> Log_LQADataCompareFieldName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQADataCompareFieldName() => !Log_LQADataCompareFieldName.Clean;
        public Value<string> Log_LQADataCompareResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQADataCompareResult() => !Log_LQADataCompareResult.Clean;
        public Value<string> Log_LQALPKey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQALPKey() => !Log_LQALPKey.Clean;
        public Value<string> Log_LQAPurchaseEligibilityResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQAPurchaseEligibilityResult() => !Log_LQAPurchaseEligibilityResult.Clean;
        public Value<string> Log_LQARiskAssessmentKey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQARiskAssessmentKey() => !Log_LQARiskAssessmentKey.Clean;
        public Value<DateTime?> Log_LQASubmissionDateTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LQASubmissionDateTime() => !Log_LQASubmissionDateTime.Clean;
        public Value<decimal?> Log_LTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_LTV() => !Log_LTV.Clean;
        public Value<decimal?> Log_MaxMortgageLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_MaxMortgageLimit() => !Log_MaxMortgageLimit.Clean;
        public Value<string> Log_MIDecision { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_MIDecision() => !Log_MIDecision.Clean;
        public Value<string> Log_MortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_MortgageType() => !Log_MortgageType.Clean;
        public Value<string> Log_NegAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NegAmortizationType() => !Log_NegAmortizationType.Clean;
        public Value<decimal?> Log_NegativeNetRental { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NegativeNetRental() => !Log_NegativeNetRental.Clean;
        public Value<decimal?> Log_NetCashBack { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NetCashBack() => !Log_NetCashBack.Clean;
        public Value<string> Log_NewConstruction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NewConstruction() => !Log_NewConstruction.Clean;
        public Value<decimal?> Log_NoteRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NoteRate() => !Log_NoteRate.Clean;
        public Value<string> Log_NOTPNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NOTPNumber() => !Log_NOTPNumber.Clean;
        public Value<int?> Log_NoUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NoUnits() => !Log_NoUnits.Clean;
        public Value<string> Log_NumberOfSubmissions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_NumberOfSubmissions() => !Log_NumberOfSubmissions.Clean;
        public Value<string> Log_OccupancyStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OccupancyStatus() => !Log_OccupancyStatus.Clean;
        public Value<decimal?> Log_OccupantDebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OccupantDebtRatio() => !Log_OccupantDebtRatio.Clean;
        public Value<decimal?> Log_OccupantHousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OccupantHousingRatio() => !Log_OccupantHousingRatio.Clean;
        public Value<string> Log_OfferingIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OfferingIdentifier() => !Log_OfferingIdentifier.Clean;
        public Value<string> Log_OriginatingCompany { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OriginatingCompany() => !Log_OriginatingCompany.Clean;
        public Value<decimal?> Log_OwnerExistingMtg { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_OwnerExistingMtg() => !Log_OwnerExistingMtg.Clean;
        public Value<decimal?> Log_PandI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PandI() => !Log_PandI.Clean;
        public Value<int?> Log_PaymentFrequency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PaymentFrequency() => !Log_PaymentFrequency.Clean;
        public Value<string> Log_PresentAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentAddress() => !Log_PresentAddress.Clean;
        public Value<string> Log_PresentAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentAddressCity() => !Log_PresentAddressCity.Clean;
        public Value<string> Log_PresentAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentAddressState() => !Log_PresentAddressState.Clean;
        public Value<string> Log_PresentAddressZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentAddressZipCode() => !Log_PresentAddressZipCode.Clean;
        public Value<decimal?> Log_PresentHousingExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentHousingExpense() => !Log_PresentHousingExpense.Clean;
        public Value<decimal?> Log_PresentPrincipalHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PresentPrincipalHousingPayment() => !Log_PresentPrincipalHousingPayment.Clean;
        public Value<string> Log_PropertyAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PropertyAddress() => !Log_PropertyAddress.Clean;
        public Value<string> Log_PropertyCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PropertyCity() => !Log_PropertyCity.Clean;
        public Value<string> Log_PropertyState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PropertyState() => !Log_PropertyState.Clean;
        public Value<string> Log_PropertyZipcode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PropertyZipcode() => !Log_PropertyZipcode.Clean;
        public Value<decimal?> Log_ProposedHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedHazardInsurance() => !Log_ProposedHazardInsurance.Clean;
        public Value<decimal?> Log_ProposedHOAFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedHOAFees() => !Log_ProposedHOAFees.Clean;
        public Value<decimal?> Log_ProposedHousingPITI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedHousingPITI() => !Log_ProposedHousingPITI.Clean;
        public Value<decimal?> Log_ProposedMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedMortgageInsurance() => !Log_ProposedMortgageInsurance.Clean;
        public Value<decimal?> Log_ProposedOtherPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedOtherPayment() => !Log_ProposedOtherPayment.Clean;
        public Value<decimal?> Log_ProposedTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedTaxes() => !Log_ProposedTaxes.Clean;
        public Value<decimal?> Log_ProposedTotalHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedTotalHousingPayment() => !Log_ProposedTotalHousingPayment.Clean;
        public Value<decimal?> Log_ProposedTotalMonthlyDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ProposedTotalMonthlyDebt() => !Log_ProposedTotalMonthlyDebt.Clean;
        public Value<string> Log_PurchaseEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_PurchaseEligibility() => !Log_PurchaseEligibility.Clean;
        public Value<decimal?> Log_QualifyingRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_QualifyingRate() => !Log_QualifyingRate.Clean;
        public Value<string> Log_RecordType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_RecordType() => !Log_RecordType.Clean;
        public Value<string> Log_RefinancePurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_RefinancePurpose() => !Log_RefinancePurpose.Clean;
        public Value<decimal?> Log_Reserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_Reserves() => !Log_Reserves.Clean;
        public Value<decimal?> Log_ReservesRequiredVerified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_ReservesRequiredVerified() => !Log_ReservesRequiredVerified.Clean;
        public Value<string> Log_RiskClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_RiskClass() => !Log_RiskClass.Clean;
        public Value<string> Log_SalesConcessions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SalesConcessions() => !Log_SalesConcessions.Clean;
        public Value<decimal?> Log_SalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SalesPrice() => !Log_SalesPrice.Clean;
        public Value<decimal?> Log_SecondPandI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SecondPandI() => !Log_SecondPandI.Clean;
        public Value<string> Log_SelectedBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SelectedBorrower() => !Log_SelectedBorrower.Clean;
        public Value<string> Log_SelectedRepository { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SelectedRepository() => !Log_SelectedRepository.Clean;
        public Value<string> Log_SellerNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SellerNumber() => !Log_SellerNumber.Clean;
        public Value<decimal?> Log_SubjNegCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubjNegCashFlow() => !Log_SubjNegCashFlow.Clean;
        public Value<DateTime?> Log_SubmissionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubmissionDate() => !Log_SubmissionDate.Clean;
        public Value<string> Log_SubmissionNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubmissionNumber() => !Log_SubmissionNumber.Clean;
        public Value<string> Log_SubmissionTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubmissionTime() => !Log_SubmissionTime.Clean;
        public Value<string> Log_SubmittedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubmittedBy() => !Log_SubmittedBy.Clean;
        public Value<string> Log_SubmittingCompany { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_SubmittingCompany() => !Log_SubmittingCompany.Clean;
        public Value<string> Log_TemporarySubsidyBuydown { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TemporarySubsidyBuydown() => !Log_TemporarySubsidyBuydown.Clean;
        public Value<decimal?> Log_TLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TLTV() => !Log_TLTV.Clean;
        public Value<decimal?> Log_TotalAsset { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalAsset() => !Log_TotalAsset.Clean;
        public Value<decimal?> Log_TotalExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalExpense() => !Log_TotalExpense.Clean;
        public Value<decimal?> Log_TotalExpensePmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalExpensePmt() => !Log_TotalExpensePmt.Clean;
        public Value<decimal?> Log_TotalExpenseRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalExpenseRatio() => !Log_TotalExpenseRatio.Clean;
        public Value<decimal?> Log_TotalFundsVerified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalFundsVerified() => !Log_TotalFundsVerified.Clean;
        public Value<decimal?> Log_TotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalLoanAmount() => !Log_TotalLoanAmount.Clean;
        public Value<decimal?> Log_TotalMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TotalMonthlyIncome() => !Log_TotalMonthlyIncome.Clean;
        public Value<string> Log_TPONumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TPONumber() => !Log_TPONumber.Clean;
        public Value<string> Log_TransactionID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_TransactionID() => !Log_TransactionID.Clean;
        public Value<string> Log_UnderwritingRiskAssessOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_UnderwritingRiskAssessOther() => !Log_UnderwritingRiskAssessOther.Clean;
        public Value<string> Log_UnderwritingRiskAssessType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_UnderwritingRiskAssessType() => !Log_UnderwritingRiskAssessType.Clean;
        public Value<string> Log_WithUndisclosedDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLog_WithUndisclosedDebt() => !Log_WithUndisclosedDebt.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AUSTrackingLogIndex.Clean
                    && BatchDocumentRefId.Clean
                    && Id.Clean
                    && IsEmpty.Clean
                    && IsHistory.Clean
                    && Log_AcceptPlusEligible.Clean
                    && Log_AffordableProductType.Clean
                    && Log_AllOtherPayments.Clean
                    && Log_AmortizationMonths.Clean
                    && Log_AmortizationType.Clean
                    && Log_AmtSubordinateFin.Clean
                    && Log_AppraisalTypeMAF.Clean
                    && Log_AppraisedValue.Clean
                    && Log_ARMQualifyingRate.Clean
                    && Log_AssessmentType.Clean
                    && Log_AUSRecommendation.Clean
                    && Log_AUSStatus.Clean
                    && Log_AUSTrackingType.Clean
                    && Log_AUSTransactionID.Clean
                    && Log_AUSVersion.Clean
                    && Log_Balloon.Clean
                    && Log_BalloonTerm.Clean
                    && Log_BorrowerAssetAmount.Clean
                    && Log_BorrowerAssetName.Clean
                    && Log_BorrowerAssetType.Clean
                    && Log_BorrowerCreditScore1.Clean
                    && Log_BorrowerCreditScore2.Clean
                    && Log_BorrowerCreditScore3.Clean
                    && Log_BorrowerEquifaxBEACON.Clean
                    && Log_BorrowerExperianFICO.Clean
                    && Log_BorrowerIncomeAmount.Clean
                    && Log_BorrowerIncomeName.Clean
                    && Log_BorrowerIncomeType.Clean
                    && Log_BorrowerInstitutionName.Clean
                    && Log_BorrowerName.Clean
                    && Log_BorrowerScoreName.Clean
                    && Log_BorrowerTransUnionEmpirica.Clean
                    && Log_BorrowerType1.Clean
                    && Log_BorrowerType2.Clean
                    && Log_BoughtDownRate.Clean
                    && Log_Buydown.Clean
                    && Log_CashBack.Clean
                    && Log_CashOutAmount.Clean
                    && Log_CLTV.Clean
                    && Log_CoBorrowerAssetAmount.Clean
                    && Log_CoBorrowerAssetName.Clean
                    && Log_CoBorrowerAssetType.Clean
                    && Log_CoBorrowerCreditScore1.Clean
                    && Log_CoBorrowerCreditScore2.Clean
                    && Log_CoBorrowerCreditScore3.Clean
                    && Log_CoBorrowerEquifaxBEACON.Clean
                    && Log_CoBorrowerExperianFICO.Clean
                    && Log_CoBorrowerIncomeAmount.Clean
                    && Log_CoBorrowerIncomeName.Clean
                    && Log_CoBorrowerIncomeType.Clean
                    && Log_CoBorrowerInstitutionName.Clean
                    && Log_CoborrowerName.Clean
                    && Log_CoBorrowerScoreName.Clean
                    && Log_CoBorrowerTransUnionEmpirica.Clean
                    && Log_Code1.Clean
                    && Log_Code2.Clean
                    && Log_CodeDescription1.Clean
                    && Log_CodeDescription2.Clean
                    && Log_CommunityLending.Clean
                    && Log_CreatedOn.Clean
                    && Log_CreditAgency1.Clean
                    && Log_CreditAgency2.Clean
                    && Log_CreditReportDate1.Clean
                    && Log_CreditReportDate2.Clean
                    && Log_CreditReportID1.Clean
                    && Log_CreditReportID2.Clean
                    && Log_CuredAmortizationType.Clean
                    && Log_CuredAppraisedValue.Clean
                    && Log_CuredCLTV.Clean
                    && Log_CuredHousingExpenseRatio.Clean
                    && Log_CuredLoanPurpose.Clean
                    && Log_CuredLoanTerm.Clean
                    && Log_CuredLoanType.Clean
                    && Log_CuredLTV.Clean
                    && Log_CuredNoteRate.Clean
                    && Log_CuredProposedTotalHousingPayment.Clean
                    && Log_CuredRefinancePurpose.Clean
                    && Log_CuredTotalExpenseRatio.Clean
                    && Log_CuredTotalLoanAmount.Clean
                    && Log_CuredTotalMonthlyIncome.Clean
                    && Log_DateTimeAssessed.Clean
                    && Log_DateTimeRequested.Clean
                    && Log_DebtRatio.Clean
                    && Log_DocumentationLevel.Clean
                    && Log_DUCaseIDorLPAUSKey.Clean
                    && Log_DUPropertyType.Clean
                    && Log_eFolderGUID.Clean
                    && Log_ExcessAvailableAssetsNoVerified.Clean
                    && Log_FinancedMIAmount.Clean
                    && Log_FirstPandI.Clean
                    && Log_FirstSubmissionDate.Clean
                    && Log_FirstSubmissionTime.Clean
                    && Log_FreddieDocClass.Clean
                    && Log_FundsRequiredClose.Clean
                    && Log_GUID.Clean
                    && Log_HLCTV.Clean
                    && Log_HousingExpense.Clean
                    && Log_HousingExpenseRatio.Clean
                    && Log_HousingRatio.Clean
                    && Log_HTLTV.Clean
                    && Log_IncludingLess10Mos.Clean
                    && Log_IncomeAssetBase.Clean
                    && Log_IncomeAssetBonus.Clean
                    && Log_IncomeAssetCommission.Clean
                    && Log_IncomeAssetOther.Clean
                    && Log_IncomeAssetOvertime.Clean
                    && Log_IncomeAssetPosCashFlow.Clean
                    && Log_IncomeAssetPositiveNetRental.Clean
                    && Log_IndicatorScore.Clean
                    && Log_IntendedUseofProperty.Clean
                    && Log_LCLAEvaluatedServiceConclusion1.Clean
                    && Log_LCLAEvaluatedServiceConclusion2.Clean
                    && Log_LCLAEvaluatedServiceConclusion3.Clean
                    && Log_LCLAEvaluatedServiceConclusion4.Clean
                    && Log_LCLAEvaluatedServiceType1.Clean
                    && Log_LCLAEvaluatedServiceType2.Clean
                    && Log_LCLAEvaluatedServiceType3.Clean
                    && Log_LCLAEvaluatedServiceType4.Clean
                    && Log_LenderLoan.Clean
                    && Log_LienType.Clean
                    && Log_LoanAmount.Clean
                    && Log_LoanApplicationID.Clean
                    && Log_LoanProcessingStage.Clean
                    && Log_LoanProspectorID.Clean
                    && Log_LoanPurpose.Clean
                    && Log_LoanTerm.Clean
                    && Log_LoanType.Clean
                    && Log_LPAssmtExpDate.Clean
                    && Log_LPPropertyType.Clean
                    && Log_LPVersion.Clean
                    && Log_LQACollateralRepWarrantyServiceConclusion.Clean
                    && Log_LQACreditRiskAssessmentConclusion.Clean
                    && Log_LQADataCompareFieldConclusion.Clean
                    && Log_LQADataCompareFieldName.Clean
                    && Log_LQADataCompareResult.Clean
                    && Log_LQALPKey.Clean
                    && Log_LQAPurchaseEligibilityResult.Clean
                    && Log_LQARiskAssessmentKey.Clean
                    && Log_LQASubmissionDateTime.Clean
                    && Log_LTV.Clean
                    && Log_MaxMortgageLimit.Clean
                    && Log_MIDecision.Clean
                    && Log_MortgageType.Clean
                    && Log_NegAmortizationType.Clean
                    && Log_NegativeNetRental.Clean
                    && Log_NetCashBack.Clean
                    && Log_NewConstruction.Clean
                    && Log_NoteRate.Clean
                    && Log_NOTPNumber.Clean
                    && Log_NoUnits.Clean
                    && Log_NumberOfSubmissions.Clean
                    && Log_OccupancyStatus.Clean
                    && Log_OccupantDebtRatio.Clean
                    && Log_OccupantHousingRatio.Clean
                    && Log_OfferingIdentifier.Clean
                    && Log_OriginatingCompany.Clean
                    && Log_OwnerExistingMtg.Clean
                    && Log_PandI.Clean
                    && Log_PaymentFrequency.Clean
                    && Log_PresentAddress.Clean
                    && Log_PresentAddressCity.Clean
                    && Log_PresentAddressState.Clean
                    && Log_PresentAddressZipCode.Clean
                    && Log_PresentHousingExpense.Clean
                    && Log_PresentPrincipalHousingPayment.Clean
                    && Log_PropertyAddress.Clean
                    && Log_PropertyCity.Clean
                    && Log_PropertyState.Clean
                    && Log_PropertyZipcode.Clean
                    && Log_ProposedHazardInsurance.Clean
                    && Log_ProposedHOAFees.Clean
                    && Log_ProposedHousingPITI.Clean
                    && Log_ProposedMortgageInsurance.Clean
                    && Log_ProposedOtherPayment.Clean
                    && Log_ProposedTaxes.Clean
                    && Log_ProposedTotalHousingPayment.Clean
                    && Log_ProposedTotalMonthlyDebt.Clean
                    && Log_PurchaseEligibility.Clean
                    && Log_QualifyingRate.Clean
                    && Log_RecordType.Clean
                    && Log_RefinancePurpose.Clean
                    && Log_Reserves.Clean
                    && Log_ReservesRequiredVerified.Clean
                    && Log_RiskClass.Clean
                    && Log_SalesConcessions.Clean
                    && Log_SalesPrice.Clean
                    && Log_SecondPandI.Clean
                    && Log_SelectedBorrower.Clean
                    && Log_SelectedRepository.Clean
                    && Log_SellerNumber.Clean
                    && Log_SubjNegCashFlow.Clean
                    && Log_SubmissionDate.Clean
                    && Log_SubmissionNumber.Clean
                    && Log_SubmissionTime.Clean
                    && Log_SubmittedBy.Clean
                    && Log_SubmittingCompany.Clean
                    && Log_TemporarySubsidyBuydown.Clean
                    && Log_TLTV.Clean
                    && Log_TotalAsset.Clean
                    && Log_TotalExpense.Clean
                    && Log_TotalExpensePmt.Clean
                    && Log_TotalExpenseRatio.Clean
                    && Log_TotalFundsVerified.Clean
                    && Log_TotalLoanAmount.Clean
                    && Log_TotalMonthlyIncome.Clean
                    && Log_TPONumber.Clean
                    && Log_TransactionID.Clean
                    && Log_UnderwritingRiskAssessOther.Clean
                    && Log_UnderwritingRiskAssessType.Clean
                    && Log_WithUndisclosedDebt.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AUSTrackingLogIndex; v0.Clean = value; AUSTrackingLogIndex = v0;
                var v1 = BatchDocumentRefId; v1.Clean = value; BatchDocumentRefId = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = IsEmpty; v3.Clean = value; IsEmpty = v3;
                var v4 = IsHistory; v4.Clean = value; IsHistory = v4;
                var v5 = Log_AcceptPlusEligible; v5.Clean = value; Log_AcceptPlusEligible = v5;
                var v6 = Log_AffordableProductType; v6.Clean = value; Log_AffordableProductType = v6;
                var v7 = Log_AllOtherPayments; v7.Clean = value; Log_AllOtherPayments = v7;
                var v8 = Log_AmortizationMonths; v8.Clean = value; Log_AmortizationMonths = v8;
                var v9 = Log_AmortizationType; v9.Clean = value; Log_AmortizationType = v9;
                var v10 = Log_AmtSubordinateFin; v10.Clean = value; Log_AmtSubordinateFin = v10;
                var v11 = Log_AppraisalTypeMAF; v11.Clean = value; Log_AppraisalTypeMAF = v11;
                var v12 = Log_AppraisedValue; v12.Clean = value; Log_AppraisedValue = v12;
                var v13 = Log_ARMQualifyingRate; v13.Clean = value; Log_ARMQualifyingRate = v13;
                var v14 = Log_AssessmentType; v14.Clean = value; Log_AssessmentType = v14;
                var v15 = Log_AUSRecommendation; v15.Clean = value; Log_AUSRecommendation = v15;
                var v16 = Log_AUSStatus; v16.Clean = value; Log_AUSStatus = v16;
                var v17 = Log_AUSTrackingType; v17.Clean = value; Log_AUSTrackingType = v17;
                var v18 = Log_AUSTransactionID; v18.Clean = value; Log_AUSTransactionID = v18;
                var v19 = Log_AUSVersion; v19.Clean = value; Log_AUSVersion = v19;
                var v20 = Log_Balloon; v20.Clean = value; Log_Balloon = v20;
                var v21 = Log_BalloonTerm; v21.Clean = value; Log_BalloonTerm = v21;
                var v22 = Log_BorrowerAssetAmount; v22.Clean = value; Log_BorrowerAssetAmount = v22;
                var v23 = Log_BorrowerAssetName; v23.Clean = value; Log_BorrowerAssetName = v23;
                var v24 = Log_BorrowerAssetType; v24.Clean = value; Log_BorrowerAssetType = v24;
                var v25 = Log_BorrowerCreditScore1; v25.Clean = value; Log_BorrowerCreditScore1 = v25;
                var v26 = Log_BorrowerCreditScore2; v26.Clean = value; Log_BorrowerCreditScore2 = v26;
                var v27 = Log_BorrowerCreditScore3; v27.Clean = value; Log_BorrowerCreditScore3 = v27;
                var v28 = Log_BorrowerEquifaxBEACON; v28.Clean = value; Log_BorrowerEquifaxBEACON = v28;
                var v29 = Log_BorrowerExperianFICO; v29.Clean = value; Log_BorrowerExperianFICO = v29;
                var v30 = Log_BorrowerIncomeAmount; v30.Clean = value; Log_BorrowerIncomeAmount = v30;
                var v31 = Log_BorrowerIncomeName; v31.Clean = value; Log_BorrowerIncomeName = v31;
                var v32 = Log_BorrowerIncomeType; v32.Clean = value; Log_BorrowerIncomeType = v32;
                var v33 = Log_BorrowerInstitutionName; v33.Clean = value; Log_BorrowerInstitutionName = v33;
                var v34 = Log_BorrowerName; v34.Clean = value; Log_BorrowerName = v34;
                var v35 = Log_BorrowerScoreName; v35.Clean = value; Log_BorrowerScoreName = v35;
                var v36 = Log_BorrowerTransUnionEmpirica; v36.Clean = value; Log_BorrowerTransUnionEmpirica = v36;
                var v37 = Log_BorrowerType1; v37.Clean = value; Log_BorrowerType1 = v37;
                var v38 = Log_BorrowerType2; v38.Clean = value; Log_BorrowerType2 = v38;
                var v39 = Log_BoughtDownRate; v39.Clean = value; Log_BoughtDownRate = v39;
                var v40 = Log_Buydown; v40.Clean = value; Log_Buydown = v40;
                var v41 = Log_CashBack; v41.Clean = value; Log_CashBack = v41;
                var v42 = Log_CashOutAmount; v42.Clean = value; Log_CashOutAmount = v42;
                var v43 = Log_CLTV; v43.Clean = value; Log_CLTV = v43;
                var v44 = Log_CoBorrowerAssetAmount; v44.Clean = value; Log_CoBorrowerAssetAmount = v44;
                var v45 = Log_CoBorrowerAssetName; v45.Clean = value; Log_CoBorrowerAssetName = v45;
                var v46 = Log_CoBorrowerAssetType; v46.Clean = value; Log_CoBorrowerAssetType = v46;
                var v47 = Log_CoBorrowerCreditScore1; v47.Clean = value; Log_CoBorrowerCreditScore1 = v47;
                var v48 = Log_CoBorrowerCreditScore2; v48.Clean = value; Log_CoBorrowerCreditScore2 = v48;
                var v49 = Log_CoBorrowerCreditScore3; v49.Clean = value; Log_CoBorrowerCreditScore3 = v49;
                var v50 = Log_CoBorrowerEquifaxBEACON; v50.Clean = value; Log_CoBorrowerEquifaxBEACON = v50;
                var v51 = Log_CoBorrowerExperianFICO; v51.Clean = value; Log_CoBorrowerExperianFICO = v51;
                var v52 = Log_CoBorrowerIncomeAmount; v52.Clean = value; Log_CoBorrowerIncomeAmount = v52;
                var v53 = Log_CoBorrowerIncomeName; v53.Clean = value; Log_CoBorrowerIncomeName = v53;
                var v54 = Log_CoBorrowerIncomeType; v54.Clean = value; Log_CoBorrowerIncomeType = v54;
                var v55 = Log_CoBorrowerInstitutionName; v55.Clean = value; Log_CoBorrowerInstitutionName = v55;
                var v56 = Log_CoborrowerName; v56.Clean = value; Log_CoborrowerName = v56;
                var v57 = Log_CoBorrowerScoreName; v57.Clean = value; Log_CoBorrowerScoreName = v57;
                var v58 = Log_CoBorrowerTransUnionEmpirica; v58.Clean = value; Log_CoBorrowerTransUnionEmpirica = v58;
                var v59 = Log_Code1; v59.Clean = value; Log_Code1 = v59;
                var v60 = Log_Code2; v60.Clean = value; Log_Code2 = v60;
                var v61 = Log_CodeDescription1; v61.Clean = value; Log_CodeDescription1 = v61;
                var v62 = Log_CodeDescription2; v62.Clean = value; Log_CodeDescription2 = v62;
                var v63 = Log_CommunityLending; v63.Clean = value; Log_CommunityLending = v63;
                var v64 = Log_CreatedOn; v64.Clean = value; Log_CreatedOn = v64;
                var v65 = Log_CreditAgency1; v65.Clean = value; Log_CreditAgency1 = v65;
                var v66 = Log_CreditAgency2; v66.Clean = value; Log_CreditAgency2 = v66;
                var v67 = Log_CreditReportDate1; v67.Clean = value; Log_CreditReportDate1 = v67;
                var v68 = Log_CreditReportDate2; v68.Clean = value; Log_CreditReportDate2 = v68;
                var v69 = Log_CreditReportID1; v69.Clean = value; Log_CreditReportID1 = v69;
                var v70 = Log_CreditReportID2; v70.Clean = value; Log_CreditReportID2 = v70;
                var v71 = Log_CuredAmortizationType; v71.Clean = value; Log_CuredAmortizationType = v71;
                var v72 = Log_CuredAppraisedValue; v72.Clean = value; Log_CuredAppraisedValue = v72;
                var v73 = Log_CuredCLTV; v73.Clean = value; Log_CuredCLTV = v73;
                var v74 = Log_CuredHousingExpenseRatio; v74.Clean = value; Log_CuredHousingExpenseRatio = v74;
                var v75 = Log_CuredLoanPurpose; v75.Clean = value; Log_CuredLoanPurpose = v75;
                var v76 = Log_CuredLoanTerm; v76.Clean = value; Log_CuredLoanTerm = v76;
                var v77 = Log_CuredLoanType; v77.Clean = value; Log_CuredLoanType = v77;
                var v78 = Log_CuredLTV; v78.Clean = value; Log_CuredLTV = v78;
                var v79 = Log_CuredNoteRate; v79.Clean = value; Log_CuredNoteRate = v79;
                var v80 = Log_CuredProposedTotalHousingPayment; v80.Clean = value; Log_CuredProposedTotalHousingPayment = v80;
                var v81 = Log_CuredRefinancePurpose; v81.Clean = value; Log_CuredRefinancePurpose = v81;
                var v82 = Log_CuredTotalExpenseRatio; v82.Clean = value; Log_CuredTotalExpenseRatio = v82;
                var v83 = Log_CuredTotalLoanAmount; v83.Clean = value; Log_CuredTotalLoanAmount = v83;
                var v84 = Log_CuredTotalMonthlyIncome; v84.Clean = value; Log_CuredTotalMonthlyIncome = v84;
                var v85 = Log_DateTimeAssessed; v85.Clean = value; Log_DateTimeAssessed = v85;
                var v86 = Log_DateTimeRequested; v86.Clean = value; Log_DateTimeRequested = v86;
                var v87 = Log_DebtRatio; v87.Clean = value; Log_DebtRatio = v87;
                var v88 = Log_DocumentationLevel; v88.Clean = value; Log_DocumentationLevel = v88;
                var v89 = Log_DUCaseIDorLPAUSKey; v89.Clean = value; Log_DUCaseIDorLPAUSKey = v89;
                var v90 = Log_DUPropertyType; v90.Clean = value; Log_DUPropertyType = v90;
                var v91 = Log_eFolderGUID; v91.Clean = value; Log_eFolderGUID = v91;
                var v92 = Log_ExcessAvailableAssetsNoVerified; v92.Clean = value; Log_ExcessAvailableAssetsNoVerified = v92;
                var v93 = Log_FinancedMIAmount; v93.Clean = value; Log_FinancedMIAmount = v93;
                var v94 = Log_FirstPandI; v94.Clean = value; Log_FirstPandI = v94;
                var v95 = Log_FirstSubmissionDate; v95.Clean = value; Log_FirstSubmissionDate = v95;
                var v96 = Log_FirstSubmissionTime; v96.Clean = value; Log_FirstSubmissionTime = v96;
                var v97 = Log_FreddieDocClass; v97.Clean = value; Log_FreddieDocClass = v97;
                var v98 = Log_FundsRequiredClose; v98.Clean = value; Log_FundsRequiredClose = v98;
                var v99 = Log_GUID; v99.Clean = value; Log_GUID = v99;
                var v100 = Log_HLCTV; v100.Clean = value; Log_HLCTV = v100;
                var v101 = Log_HousingExpense; v101.Clean = value; Log_HousingExpense = v101;
                var v102 = Log_HousingExpenseRatio; v102.Clean = value; Log_HousingExpenseRatio = v102;
                var v103 = Log_HousingRatio; v103.Clean = value; Log_HousingRatio = v103;
                var v104 = Log_HTLTV; v104.Clean = value; Log_HTLTV = v104;
                var v105 = Log_IncludingLess10Mos; v105.Clean = value; Log_IncludingLess10Mos = v105;
                var v106 = Log_IncomeAssetBase; v106.Clean = value; Log_IncomeAssetBase = v106;
                var v107 = Log_IncomeAssetBonus; v107.Clean = value; Log_IncomeAssetBonus = v107;
                var v108 = Log_IncomeAssetCommission; v108.Clean = value; Log_IncomeAssetCommission = v108;
                var v109 = Log_IncomeAssetOther; v109.Clean = value; Log_IncomeAssetOther = v109;
                var v110 = Log_IncomeAssetOvertime; v110.Clean = value; Log_IncomeAssetOvertime = v110;
                var v111 = Log_IncomeAssetPosCashFlow; v111.Clean = value; Log_IncomeAssetPosCashFlow = v111;
                var v112 = Log_IncomeAssetPositiveNetRental; v112.Clean = value; Log_IncomeAssetPositiveNetRental = v112;
                var v113 = Log_IndicatorScore; v113.Clean = value; Log_IndicatorScore = v113;
                var v114 = Log_IntendedUseofProperty; v114.Clean = value; Log_IntendedUseofProperty = v114;
                var v115 = Log_LCLAEvaluatedServiceConclusion1; v115.Clean = value; Log_LCLAEvaluatedServiceConclusion1 = v115;
                var v116 = Log_LCLAEvaluatedServiceConclusion2; v116.Clean = value; Log_LCLAEvaluatedServiceConclusion2 = v116;
                var v117 = Log_LCLAEvaluatedServiceConclusion3; v117.Clean = value; Log_LCLAEvaluatedServiceConclusion3 = v117;
                var v118 = Log_LCLAEvaluatedServiceConclusion4; v118.Clean = value; Log_LCLAEvaluatedServiceConclusion4 = v118;
                var v119 = Log_LCLAEvaluatedServiceType1; v119.Clean = value; Log_LCLAEvaluatedServiceType1 = v119;
                var v120 = Log_LCLAEvaluatedServiceType2; v120.Clean = value; Log_LCLAEvaluatedServiceType2 = v120;
                var v121 = Log_LCLAEvaluatedServiceType3; v121.Clean = value; Log_LCLAEvaluatedServiceType3 = v121;
                var v122 = Log_LCLAEvaluatedServiceType4; v122.Clean = value; Log_LCLAEvaluatedServiceType4 = v122;
                var v123 = Log_LenderLoan; v123.Clean = value; Log_LenderLoan = v123;
                var v124 = Log_LienType; v124.Clean = value; Log_LienType = v124;
                var v125 = Log_LoanAmount; v125.Clean = value; Log_LoanAmount = v125;
                var v126 = Log_LoanApplicationID; v126.Clean = value; Log_LoanApplicationID = v126;
                var v127 = Log_LoanProcessingStage; v127.Clean = value; Log_LoanProcessingStage = v127;
                var v128 = Log_LoanProspectorID; v128.Clean = value; Log_LoanProspectorID = v128;
                var v129 = Log_LoanPurpose; v129.Clean = value; Log_LoanPurpose = v129;
                var v130 = Log_LoanTerm; v130.Clean = value; Log_LoanTerm = v130;
                var v131 = Log_LoanType; v131.Clean = value; Log_LoanType = v131;
                var v132 = Log_LPAssmtExpDate; v132.Clean = value; Log_LPAssmtExpDate = v132;
                var v133 = Log_LPPropertyType; v133.Clean = value; Log_LPPropertyType = v133;
                var v134 = Log_LPVersion; v134.Clean = value; Log_LPVersion = v134;
                var v135 = Log_LQACollateralRepWarrantyServiceConclusion; v135.Clean = value; Log_LQACollateralRepWarrantyServiceConclusion = v135;
                var v136 = Log_LQACreditRiskAssessmentConclusion; v136.Clean = value; Log_LQACreditRiskAssessmentConclusion = v136;
                var v137 = Log_LQADataCompareFieldConclusion; v137.Clean = value; Log_LQADataCompareFieldConclusion = v137;
                var v138 = Log_LQADataCompareFieldName; v138.Clean = value; Log_LQADataCompareFieldName = v138;
                var v139 = Log_LQADataCompareResult; v139.Clean = value; Log_LQADataCompareResult = v139;
                var v140 = Log_LQALPKey; v140.Clean = value; Log_LQALPKey = v140;
                var v141 = Log_LQAPurchaseEligibilityResult; v141.Clean = value; Log_LQAPurchaseEligibilityResult = v141;
                var v142 = Log_LQARiskAssessmentKey; v142.Clean = value; Log_LQARiskAssessmentKey = v142;
                var v143 = Log_LQASubmissionDateTime; v143.Clean = value; Log_LQASubmissionDateTime = v143;
                var v144 = Log_LTV; v144.Clean = value; Log_LTV = v144;
                var v145 = Log_MaxMortgageLimit; v145.Clean = value; Log_MaxMortgageLimit = v145;
                var v146 = Log_MIDecision; v146.Clean = value; Log_MIDecision = v146;
                var v147 = Log_MortgageType; v147.Clean = value; Log_MortgageType = v147;
                var v148 = Log_NegAmortizationType; v148.Clean = value; Log_NegAmortizationType = v148;
                var v149 = Log_NegativeNetRental; v149.Clean = value; Log_NegativeNetRental = v149;
                var v150 = Log_NetCashBack; v150.Clean = value; Log_NetCashBack = v150;
                var v151 = Log_NewConstruction; v151.Clean = value; Log_NewConstruction = v151;
                var v152 = Log_NoteRate; v152.Clean = value; Log_NoteRate = v152;
                var v153 = Log_NOTPNumber; v153.Clean = value; Log_NOTPNumber = v153;
                var v154 = Log_NoUnits; v154.Clean = value; Log_NoUnits = v154;
                var v155 = Log_NumberOfSubmissions; v155.Clean = value; Log_NumberOfSubmissions = v155;
                var v156 = Log_OccupancyStatus; v156.Clean = value; Log_OccupancyStatus = v156;
                var v157 = Log_OccupantDebtRatio; v157.Clean = value; Log_OccupantDebtRatio = v157;
                var v158 = Log_OccupantHousingRatio; v158.Clean = value; Log_OccupantHousingRatio = v158;
                var v159 = Log_OfferingIdentifier; v159.Clean = value; Log_OfferingIdentifier = v159;
                var v160 = Log_OriginatingCompany; v160.Clean = value; Log_OriginatingCompany = v160;
                var v161 = Log_OwnerExistingMtg; v161.Clean = value; Log_OwnerExistingMtg = v161;
                var v162 = Log_PandI; v162.Clean = value; Log_PandI = v162;
                var v163 = Log_PaymentFrequency; v163.Clean = value; Log_PaymentFrequency = v163;
                var v164 = Log_PresentAddress; v164.Clean = value; Log_PresentAddress = v164;
                var v165 = Log_PresentAddressCity; v165.Clean = value; Log_PresentAddressCity = v165;
                var v166 = Log_PresentAddressState; v166.Clean = value; Log_PresentAddressState = v166;
                var v167 = Log_PresentAddressZipCode; v167.Clean = value; Log_PresentAddressZipCode = v167;
                var v168 = Log_PresentHousingExpense; v168.Clean = value; Log_PresentHousingExpense = v168;
                var v169 = Log_PresentPrincipalHousingPayment; v169.Clean = value; Log_PresentPrincipalHousingPayment = v169;
                var v170 = Log_PropertyAddress; v170.Clean = value; Log_PropertyAddress = v170;
                var v171 = Log_PropertyCity; v171.Clean = value; Log_PropertyCity = v171;
                var v172 = Log_PropertyState; v172.Clean = value; Log_PropertyState = v172;
                var v173 = Log_PropertyZipcode; v173.Clean = value; Log_PropertyZipcode = v173;
                var v174 = Log_ProposedHazardInsurance; v174.Clean = value; Log_ProposedHazardInsurance = v174;
                var v175 = Log_ProposedHOAFees; v175.Clean = value; Log_ProposedHOAFees = v175;
                var v176 = Log_ProposedHousingPITI; v176.Clean = value; Log_ProposedHousingPITI = v176;
                var v177 = Log_ProposedMortgageInsurance; v177.Clean = value; Log_ProposedMortgageInsurance = v177;
                var v178 = Log_ProposedOtherPayment; v178.Clean = value; Log_ProposedOtherPayment = v178;
                var v179 = Log_ProposedTaxes; v179.Clean = value; Log_ProposedTaxes = v179;
                var v180 = Log_ProposedTotalHousingPayment; v180.Clean = value; Log_ProposedTotalHousingPayment = v180;
                var v181 = Log_ProposedTotalMonthlyDebt; v181.Clean = value; Log_ProposedTotalMonthlyDebt = v181;
                var v182 = Log_PurchaseEligibility; v182.Clean = value; Log_PurchaseEligibility = v182;
                var v183 = Log_QualifyingRate; v183.Clean = value; Log_QualifyingRate = v183;
                var v184 = Log_RecordType; v184.Clean = value; Log_RecordType = v184;
                var v185 = Log_RefinancePurpose; v185.Clean = value; Log_RefinancePurpose = v185;
                var v186 = Log_Reserves; v186.Clean = value; Log_Reserves = v186;
                var v187 = Log_ReservesRequiredVerified; v187.Clean = value; Log_ReservesRequiredVerified = v187;
                var v188 = Log_RiskClass; v188.Clean = value; Log_RiskClass = v188;
                var v189 = Log_SalesConcessions; v189.Clean = value; Log_SalesConcessions = v189;
                var v190 = Log_SalesPrice; v190.Clean = value; Log_SalesPrice = v190;
                var v191 = Log_SecondPandI; v191.Clean = value; Log_SecondPandI = v191;
                var v192 = Log_SelectedBorrower; v192.Clean = value; Log_SelectedBorrower = v192;
                var v193 = Log_SelectedRepository; v193.Clean = value; Log_SelectedRepository = v193;
                var v194 = Log_SellerNumber; v194.Clean = value; Log_SellerNumber = v194;
                var v195 = Log_SubjNegCashFlow; v195.Clean = value; Log_SubjNegCashFlow = v195;
                var v196 = Log_SubmissionDate; v196.Clean = value; Log_SubmissionDate = v196;
                var v197 = Log_SubmissionNumber; v197.Clean = value; Log_SubmissionNumber = v197;
                var v198 = Log_SubmissionTime; v198.Clean = value; Log_SubmissionTime = v198;
                var v199 = Log_SubmittedBy; v199.Clean = value; Log_SubmittedBy = v199;
                var v200 = Log_SubmittingCompany; v200.Clean = value; Log_SubmittingCompany = v200;
                var v201 = Log_TemporarySubsidyBuydown; v201.Clean = value; Log_TemporarySubsidyBuydown = v201;
                var v202 = Log_TLTV; v202.Clean = value; Log_TLTV = v202;
                var v203 = Log_TotalAsset; v203.Clean = value; Log_TotalAsset = v203;
                var v204 = Log_TotalExpense; v204.Clean = value; Log_TotalExpense = v204;
                var v205 = Log_TotalExpensePmt; v205.Clean = value; Log_TotalExpensePmt = v205;
                var v206 = Log_TotalExpenseRatio; v206.Clean = value; Log_TotalExpenseRatio = v206;
                var v207 = Log_TotalFundsVerified; v207.Clean = value; Log_TotalFundsVerified = v207;
                var v208 = Log_TotalLoanAmount; v208.Clean = value; Log_TotalLoanAmount = v208;
                var v209 = Log_TotalMonthlyIncome; v209.Clean = value; Log_TotalMonthlyIncome = v209;
                var v210 = Log_TPONumber; v210.Clean = value; Log_TPONumber = v210;
                var v211 = Log_TransactionID; v211.Clean = value; Log_TransactionID = v211;
                var v212 = Log_UnderwritingRiskAssessOther; v212.Clean = value; Log_UnderwritingRiskAssessOther = v212;
                var v213 = Log_UnderwritingRiskAssessType; v213.Clean = value; Log_UnderwritingRiskAssessType = v213;
                var v214 = Log_WithUndisclosedDebt; v214.Clean = value; Log_WithUndisclosedDebt = v214;
                _settingClean = 0;
            }
        }
    }
}