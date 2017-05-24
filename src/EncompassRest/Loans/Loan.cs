using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Loan
    {
        public AdditionalRequests AdditionalRequests { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalRequests() => AdditionalRequests?.Clean == false;
        public Value<DateTime?> AdverseActionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdverseActionDate() => !AdverseActionDate.Clean;
        public Value<List<AffiliatedBusinessArrangement>> AffiliatedBusinessArrangements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliatedBusinessArrangements() => !AffiliatedBusinessArrangements.Clean;
        public Value<string> AgencyCaseIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyCaseIdentifier() => !AgencyCaseIdentifier.Clean;
        public Value<decimal?> AlterationsImprovementsOrRepairsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlterationsImprovementsOrRepairsAmount() => !AlterationsImprovementsOrRepairsAmount.Clean;
        public Value<List<Application>> Applications { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplications() => !Applications.Clean;
        public Value<string> ApplicationTakenMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationTakenMethodType() => !ApplicationTakenMethodType.Clean;
        public Value<DateTime?> AprDisclosureDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprDisclosureDate() => !AprDisclosureDate.Clean;
        public Value<string> ArmTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmTypeDescription() => !ArmTypeDescription.Clean;
        public ATRQMCommon ATRQMCommon { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRQMCommon() => ATRQMCommon?.Clean == false;
        public Value<decimal?> BaseLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseLoanAmount() => !BaseLoanAmount.Clean;
        public Value<bool?> BelowMarketSubordinateFinancingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBelowMarketSubordinateFinancingIndicator() => !BelowMarketSubordinateFinancingIndicator.Clean;
        public Value<string> BillingCategory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBillingCategory() => !BillingCategory.Clean;
        public Value<decimal?> BiweeklyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBiweeklyPaymentAmount() => !BiweeklyPaymentAmount.Clean;
        public Value<int?> BLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBLTV() => !BLTV.Clean;
        public Value<bool?> BorrowerCoBorrowerMarriedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCoBorrowerMarriedIndicator() => !BorrowerCoBorrowerMarriedIndicator.Clean;
        public Value<decimal?> BorrowerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidClosingCostsAmount() => !BorrowerPaidClosingCostsAmount.Clean;
        public Value<decimal?> BorrowerPaidDiscountPointsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidDiscountPointsAmount() => !BorrowerPaidDiscountPointsAmount.Clean;
        public Value<decimal?> BorrowerPaidFHAVAClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidFHAVAClosingCostsAmount() => !BorrowerPaidFHAVAClosingCostsAmount.Clean;
        public Value<decimal?> BorrowerRequestedLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerRequestedLoanAmount() => !BorrowerRequestedLoanAmount.Clean;
        public Value<decimal?> BrokerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPaidClosingCostsAmount() => !BrokerPaidClosingCostsAmount.Clean;
        public Value<bool?> BuydownIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIndicator() => !BuydownIndicator.Clean;
        public Value<decimal?> BuydownMonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownMonthlyPaymentAmount() => !BuydownMonthlyPaymentAmount.Clean;
        public Value<decimal?> BuydownRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownRatePercent() => !BuydownRatePercent.Clean;
        public Value<decimal?> CashFromToBorrowerAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashFromToBorrowerAmount() => !CashFromToBorrowerAmount.Clean;
        public Value<string> Channel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChannel() => !Channel.Clean;
        public Value<DateTime?> ClosingBillingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingBillingDate() => !ClosingBillingDate.Clean;
        public ClosingCost ClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost() => ClosingCost?.Clean == false;
        public Value<string> ClosingCostProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostProgram() => !ClosingCostProgram.Clean;
        public Value<decimal?> ClosingCostsAndPrepaidsFromOtherLienAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostsAndPrepaidsFromOtherLienAmount() => !ClosingCostsAndPrepaidsFromOtherLienAmount.Clean;
        public Value<decimal?> ClosingCostsPaidByOthersAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostsPaidByOthersAmount() => !ClosingCostsPaidByOthersAmount.Clean;
        public Value<string> ClosingDocsStackingOrder { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocsStackingOrder() => !ClosingDocsStackingOrder.Clean;
        public ClosingDocument ClosingDocument { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocument() => ClosingDocument?.Clean == false;
        public Value<int?> CollateralManagerScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralManagerScore() => !CollateralManagerScore.Clean;
        public Value<decimal?> CombinedLtv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCombinedLtv() => !CombinedLtv.Clean;
        public Value<string> CommitmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentNumber() => !CommitmentNumber.Clean;
        public CommitmentTerms CommitmentTerms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentTerms() => CommitmentTerms?.Clean == false;
        public Value<List<ComplianceTestLog>> ComplianceTestLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComplianceTestLogs() => !ComplianceTestLogs.Clean;
        public Value<string> ConformingJumbo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConformingJumbo() => !ConformingJumbo.Clean;
        public ConstructionManagement ConstructionManagement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionManagement() => ConstructionManagement?.Clean == false;
        public Value<string> ConsumerConnectSiteID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConsumerConnectSiteID() => !ConsumerConnectSiteID.Clean;
        public Value<List<Contact>> Contacts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContacts() => !Contacts.Clean;
        public Value<bool?> ContactUpdatedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactUpdatedIndicator() => !ContactUpdatedIndicator.Clean;
        public Value<decimal?> ContractSellerCreditAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractSellerCreditAmount() => !ContractSellerCreditAmount.Clean;
        public Value<List<ConversationLog>> ConversationLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConversationLogs() => !ConversationLogs.Clean;
        public Value<bool?> CopyBrokerToLenderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyBrokerToLenderIndicator() => !CopyBrokerToLenderIndicator.Clean;
        public Value<string> CopyLoanNumLenderCaseNum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyLoanNumLenderCaseNum() => !CopyLoanNumLenderCaseNum.Clean;
        public Correspondent Correspondent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondent() => Correspondent?.Clean == false;
        public Value<string> CreditScoreToUse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScoreToUse() => !CreditScoreToUse.Clean;
        public Value<List<CrmLog>> CrmLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCrmLogs() => !CrmLogs.Clean;
        public Application CurrentApplication { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentApplication() => CurrentApplication?.Clean == false;
        public Value<int?> CurrentApplicationIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentApplicationIndex() => !CurrentApplicationIndex.Clean;
        public Value<bool?> CurrentApplicationIsPrimary { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentApplicationIsPrimary() => !CurrentApplicationIsPrimary.Clean;
        public Value<string> CurrentFirstMortgageHolderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentFirstMortgageHolderType() => !CurrentFirstMortgageHolderType.Clean;
        public Value<List<CustomField>> CustomFields { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCustomFields() => !CustomFields.Clean;
        public CustomModelFields CustomModelFields { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCustomModelFields() => CustomModelFields?.Clean == false;
        public Value<List<DataTracLog>> DataTracLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDataTracLogs() => !DataTracLogs.Clean;
        public Value<bool?> DBIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDBIndicator() => !DBIndicator.Clean;
        public Value<bool?> DeductOverwireAmountIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeductOverwireAmountIndicator() => !DeductOverwireAmountIndicator.Clean;
        public Value<bool?> DisableESignConsentAlert { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisableESignConsentAlert() => !DisableESignConsentAlert.Clean;
        public Value<bool?> DisableKeyPricingAlert { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisableKeyPricingAlert() => !DisableKeyPricingAlert.Clean;
        public DisclosureNotices DisclosureNotices { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureNotices() => DisclosureNotices?.Clean == false;
        public Value<List<DisclosureTracking2015Log>> DisclosureTracking2015Logs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureTracking2015Logs() => !DisclosureTracking2015Logs.Clean;
        public Value<List<DisclosureTrackingLog>> DisclosureTrackingLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureTrackingLogs() => !DisclosureTrackingLogs.Clean;
        public Value<decimal?> DiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoint() => !DiscountPoint.Clean;
        public Value<string> DocEngine { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocEngine() => !DocEngine.Clean;
        public Value<List<DocumentLog>> DocumentLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentLogs() => !DocumentLogs.Clean;
        public Value<string> DoNotCheckEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDoNotCheckEmail() => !DoNotCheckEmail.Clean;
        public Value<bool?> DoNotPrintCompensationFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDoNotPrintCompensationFees() => !DoNotPrintCompensationFees.Clean;
        public Value<List<DownloadLog>> DownloadLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownloadLogs() => !DownloadLogs.Clean;
        public DownPayment DownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPayment() => DownPayment?.Clean == false;
        public Value<decimal?> DownPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentPercent() => !DownPaymentPercent.Clean;
        public Value<List<EdmLog>> EdmLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEdmLogs() => !EdmLogs.Clean;
        public Value<List<EmailTriggerLog>> EmailTriggerLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmailTriggerLogs() => !EmailTriggerLogs.Clean;
        public EmDocument EmDocument { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmDocument() => EmDocument?.Clean == false;
        public EmDocumentInvestor EmDocumentInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmDocumentInvestor() => EmDocumentInvestor?.Clean == false;
        public EmDocumentLender EmDocumentLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmDocumentLender() => EmDocumentLender?.Clean == false;
        public Value<string> EmXmlVersionId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmXmlVersionId() => !EmXmlVersionId.Clean;
        public Value<string> EncompassId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEncompassId() => !EncompassId.Clean;
        public Value<bool?> EnforceCountyLoanLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnforceCountyLoanLimit() => !EnforceCountyLoanLimit.Clean;
        public Value<decimal?> EstimatedClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedClosingCostsAmount() => !EstimatedClosingCostsAmount.Clean;
        public Value<decimal?> EstimatedConstructionInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedConstructionInterest() => !EstimatedConstructionInterest.Clean;
        public Value<decimal?> EstimatedPrepaidItemsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedPrepaidItemsAmount() => !EstimatedPrepaidItemsAmount.Clean;
        public Value<string> ExportLoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExportLoanNumber() => !ExportLoanNumber.Clean;
        public FannieMae FannieMae { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieMae() => FannieMae?.Clean == false;
        public Value<List<Fee>> Fees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFees() => !Fees.Clean;
        public Value<decimal?> FhaMiPremiumRefundAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaMiPremiumRefundAmount() => !FhaMiPremiumRefundAmount.Clean;
        public FhaVaLoan FhaVaLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaVaLoan() => FhaVaLoan?.Clean == false;
        public Value<string> FHAVALoanOriginatorIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAVALoanOriginatorIdentifier() => !FHAVALoanOriginatorIdentifier.Clean;
        public Value<List<FieldLockData>> FieldLockData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFieldLockData() => !FieldLockData.Clean;
        public Value<decimal?> FirstAdjustmentMinimum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstAdjustmentMinimum() => !FirstAdjustmentMinimum.Clean;
        public Value<decimal?> FirstSubordinateLienAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstSubordinateLienAmount() => !FirstSubordinateLienAmount.Clean;
        public Value<bool?> FirstTimeHomebuyersIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTimeHomebuyersIndicator() => !FirstTimeHomebuyersIndicator.Clean;
        public Value<string> FnmCommunityLendingProductName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnmCommunityLendingProductName() => !FnmCommunityLendingProductName.Clean;
        public Value<bool?> FnmCommunitySecondsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnmCommunitySecondsIndicator() => !FnmCommunitySecondsIndicator.Clean;
        public Value<bool?> FnmNeighborsMortgageEligibilityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnmNeighborsMortgageEligibilityIndicator() => !FnmNeighborsMortgageEligibilityIndicator.Clean;
        public Value<List<Form>> Forms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForms() => !Forms.Clean;
        public Value<int?> FraudScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFraudScore() => !FraudScore.Clean;
        public FreddieMac FreddieMac { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMac() => FreddieMac?.Clean == false;
        public Funding Funding { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFunding() => Funding?.Clean == false;
        public Value<string> FundingDeductionList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingDeductionList() => !FundingDeductionList.Clean;
        public Value<string> FundingFeeList { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFeeList() => !FundingFeeList.Clean;
        public Value<List<FundingFee>> FundingFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFees() => !FundingFees.Clean;
        public Gfe Gfe { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe() => Gfe?.Clean == false;
        public Value<string> GovernmentLoanLenderIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentLoanLenderIdentifier() => !GovernmentLoanLenderIdentifier.Clean;
        public Value<string> GovernmentLoanSponsorIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentLoanSponsorIdentifier() => !GovernmentLoanSponsorIdentifier.Clean;
        public Value<decimal?> GovernmentMortgageCreditCertificateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentMortgageCreditCertificateAmount() => !GovernmentMortgageCreditCertificateAmount.Clean;
        public Value<string> HasAbusinessRelationshipWith { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasAbusinessRelationshipWith() => !HasAbusinessRelationshipWith.Clean;
        public Value<decimal?> HcltvHtltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHcltvHtltv() => !HcltvHtltv.Clean;
        public Value<decimal?> HelocTeaserRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHelocTeaserRate() => !HelocTeaserRate.Clean;
        public Hmda Hmda { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmda() => Hmda?.Clean == false;
        public Value<List<HomeCounselingProvider>> HomeCounselingProviders { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProviders() => !HomeCounselingProviders.Clean;
        public Value<string> HomeCounselingProvidersDistance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProvidersDistance() => !HomeCounselingProvidersDistance.Clean;
        public Value<string> HomeCounselingProvidersLanguageNames { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProvidersLanguageNames() => !HomeCounselingProvidersLanguageNames.Clean;
        public Value<string> HomeCounselingProvidersServiceNames { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProvidersServiceNames() => !HomeCounselingProvidersServiceNames.Clean;
        public Value<int?> HouseholdSizeCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHouseholdSizeCount() => !HouseholdSizeCount.Clean;
        public Value<List<HtmlEmailLog>> HtmlEmailLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHtmlEmailLogs() => !HtmlEmailLogs.Clean;
        public Hud1Es Hud1Es { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Es() => Hud1Es?.Clean == false;
        public Value<decimal?> HudIncomeLimitAdjustmentFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudIncomeLimitAdjustmentFactor() => !HudIncomeLimitAdjustmentFactor.Clean;
        public Value<decimal?> HudLendingIncomeLimitAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLendingIncomeLimitAmount() => !HudLendingIncomeLimitAmount.Clean;
        public HudLoanData HudLoanData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudLoanData() => HudLoanData?.Clean == false;
        public Value<decimal?> HudMedianIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudMedianIncomeAmount() => !HudMedianIncomeAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IncludeUSDAFeeInClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeUSDAFeeInClosing() => !IncludeUSDAFeeInClosing.Clean;
        public Value<decimal?> InitialInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialInterestRate() => !InitialInterestRate.Clean;
        public Value<string> InsuranceAuthorizationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceAuthorizationIndicator() => !InsuranceAuthorizationIndicator.Clean;
        public InterimServicing InterimServicing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterimServicing() => InterimServicing?.Clean == false;
        public Value<DateTime?> InterviewerApplicationSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewerApplicationSignedDate() => !InterviewerApplicationSignedDate.Clean;
        public Value<string> InterviewerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewerEmail() => !InterviewerEmail.Clean;
        public Value<string> InterviewerLicenseIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewerLicenseIdentifier() => !InterviewerLicenseIdentifier.Clean;
        public Value<string> InterviewerPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewerPhoneNumber() => !InterviewerPhoneNumber.Clean;
        public Value<string> InterviewersCompanyStateLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewersCompanyStateLicense() => !InterviewersCompanyStateLicense.Clean;
        public Value<string> InterviewersId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterviewersId() => !InterviewersId.Clean;
        public Value<string> InverviewerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInverviewerName() => !InverviewerName.Clean;
        public Value<bool?> IsCreditorProhibitsBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsCreditorProhibitsBorrower() => !IsCreditorProhibitsBorrower.Clean;
        public Value<bool?> IsEmployeeLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEmployeeLoan() => !IsEmployeeLoan.Clean;
        public Value<bool?> IsLSSecondaryFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLSSecondaryFile() => !IsLSSecondaryFile.Clean;
        public Value<bool?> IsRequiredInterestReserveCompoundInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsRequiredInterestReserveCompoundInterest() => !IsRequiredInterestReserveCompoundInterest.Clean;
        public Value<decimal?> LandIfAcquiredSeperatelyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandIfAcquiredSeperatelyAmount() => !LandIfAcquiredSeperatelyAmount.Clean;
        public Value<string> LeadSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeadSource() => !LeadSource.Clean;
        public Value<string> LenderCaseIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCaseIdentifier() => !LenderCaseIdentifier.Clean;
        public Value<string> LenderChannel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderChannel() => !LenderChannel.Clean;
        public Value<decimal?> LenderCreditsInFunding { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCreditsInFunding() => !LenderCreditsInFunding.Clean;
        public Value<string> LenderInvestorCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorCode() => !LenderInvestorCode.Clean;
        public Value<decimal?> LenderPaidClosignCostsDotAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidClosignCostsDotAmount() => !LenderPaidClosignCostsDotAmount.Clean;
        public Value<decimal?> LenderPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidClosingCostsAmount() => !LenderPaidClosingCostsAmount.Clean;
        public Value<decimal?> LesserAppraisedValueOrSalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserAppraisedValueOrSalesPrice() => !LesserAppraisedValueOrSalesPrice.Clean;
        public Value<decimal?> LifeInsuranceCoverageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLifeInsuranceCoverageAmount() => !LifeInsuranceCoverageAmount.Clean;
        public Value<decimal?> LifeInsuranceEstimatedMonthlyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLifeInsuranceEstimatedMonthlyAmount() => !LifeInsuranceEstimatedMonthlyAmount.Clean;
        public Value<decimal?> LifeInsuranceTotalProtectedMonthlyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLifeInsuranceTotalProtectedMonthlyAmount() => !LifeInsuranceTotalProtectedMonthlyAmount.Clean;
        public Value<string> LinkId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinkId() => !LinkId.Clean;
        public Value<List<LoanActionLog>> LoanActionLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanActionLogs() => !LoanActionLogs.Clean;
        public Value<int?> LoanAmortizationTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationTermMonths() => !LoanAmortizationTermMonths.Clean;
        public Value<string> LoanAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationType() => !LoanAmortizationType.Clean;
        public Value<string> LoanCreatedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanCreatedDate() => !LoanCreatedDate.Clean;
        public Value<DateTime?> LoanCreatedDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanCreatedDateUtc() => !LoanCreatedDateUtc.Clean;
        public Value<string> LoanIdNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanIdNumber() => !LoanIdNumber.Clean;
        public Value<bool?> LoanImportStatusIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanImportStatusIndicator() => !LoanImportStatusIndicator.Clean;
        public Value<string> LoanLinkSyncType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLinkSyncType() => !LoanLinkSyncType.Clean;
        public Value<string> LoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanNumber() => !LoanNumber.Clean;
        public LoanProductData LoanProductData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProductData() => LoanProductData?.Clean == false;
        public Value<string> LoanProgramName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgramName() => !LoanProgramName.Clean;
        public Value<List<LoanProgram>> LoanPrograms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPrograms() => !LoanPrograms.Clean;
        public Value<string> LoanPurposeOfRefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurposeOfRefinanceType() => !LoanPurposeOfRefinanceType.Clean;
        public Value<string> LoanSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSource() => !LoanSource.Clean;
        public LoanSubmission LoanSubmission { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSubmission() => LoanSubmission?.Clean == false;
        public Value<decimal?> LoanTotalProposedMonthlyMaintenanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTotalProposedMonthlyMaintenanceAmount() => !LoanTotalProposedMonthlyMaintenanceAmount.Clean;
        public Value<decimal?> LoanTotalProposedMonthlyUtilitiesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTotalProposedMonthlyUtilitiesAmount() => !LoanTotalProposedMonthlyUtilitiesAmount.Clean;
        public Value<string> LoanUnderwriterCHUMSIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanUnderwriterCHUMSIdentifier() => !LoanUnderwriterCHUMSIdentifier.Clean;
        public Value<string> LoanVALoanProcedureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanVALoanProcedureType() => !LoanVALoanProcedureType.Clean;
        public Value<decimal?> LoanVARateReductionInitialComputationTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanVARateReductionInitialComputationTotalAmount() => !LoanVARateReductionInitialComputationTotalAmount.Clean;
        public Value<decimal?> LoanVAResidualIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanVAResidualIncomeAmount() => !LoanVAResidualIncomeAmount.Clean;
        public Value<int?> LoanVersionId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanVersionId() => !LoanVersionId.Clean;
        public Value<List<LockConfirmLog>> LockConfirmLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockConfirmLogs() => !LockConfirmLogs.Clean;
        public Value<List<LockDenialLog>> LockDenialLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockDenialLogs() => !LockDenialLogs.Clean;
        public Value<List<LockRequestLog>> LockRequestLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockRequestLogs() => !LockRequestLogs.Clean;
        public ElliLOCompensation LOCompensation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOCompensation() => LOCompensation?.Clean == false;
        public Value<List<LogEntryLog>> LogEntryLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogEntryLogs() => !LogEntryLogs.Clean;
        public Value<decimal?> Ltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv() => !Ltv.Clean;
        public Value<decimal?> LtvPropertyValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtvPropertyValue() => !LtvPropertyValue.Clean;
        public Value<string> MasterCommitmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMasterCommitmentNumber() => !MasterCommitmentNumber.Clean;
        public Value<DateTime?> MaturityDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaturityDate() => !MaturityDate.Clean;
        public Value<decimal?> MaxBackRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxBackRatio() => !MaxBackRatio.Clean;
        public Value<decimal?> MaxFrontRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxFrontRatio() => !MaxFrontRatio.Clean;
        public Mcaw Mcaw { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMcaw() => Mcaw?.Clean == false;
        public Value<string> MersNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersNumber() => !MersNumber.Clean;
        public Value<DateTime?> MersNumberRegistrationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMersNumberRegistrationDate() => !MersNumberRegistrationDate.Clean;
        public Value<decimal?> MiAndFundingFeeFinancedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiAndFundingFeeFinancedAmount() => !MiAndFundingFeeFinancedAmount.Clean;
        public Value<decimal?> MiAndFundingFeeTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiAndFundingFeeTotalAmount() => !MiAndFundingFeeTotalAmount.Clean;
        public Value<DateTime?> MilestoneApprovedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneApprovedDate() => !MilestoneApprovedDate.Clean;
        public Value<DateTime?> MilestoneApprovedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneApprovedDueDate() => !MilestoneApprovedDueDate.Clean;
        public Value<DateTime?> MilestoneCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneCompletedDate() => !MilestoneCompletedDate.Clean;
        public Value<DateTime?> MilestoneCompletedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneCompletedDueDate() => !MilestoneCompletedDueDate.Clean;
        public Value<DateTime?> MilestoneCurrentDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneCurrentDateUtc() => !MilestoneCurrentDateUtc.Clean;
        public Value<string> MilestoneCurrentName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneCurrentName() => !MilestoneCurrentName.Clean;
        public Value<DateTime?> MilestoneDocSignedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneDocSignedDate() => !MilestoneDocSignedDate.Clean;
        public Value<DateTime?> MilestoneDocSignedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneDocSignedDueDate() => !MilestoneDocSignedDueDate.Clean;
        public Value<int?> MilestoneDuration { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneDuration() => !MilestoneDuration.Clean;
        public Value<DateTime?> MilestoneFileStartedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneFileStartedDate() => !MilestoneFileStartedDate.Clean;
        public Value<List<MilestoneFreeRoleLog>> MilestoneFreeRoleLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneFreeRoleLogs() => !MilestoneFreeRoleLogs.Clean;
        public Value<DateTime?> MilestoneFundedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneFundedDate() => !MilestoneFundedDate.Clean;
        public Value<DateTime?> MilestoneFundedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneFundedDueDate() => !MilestoneFundedDueDate.Clean;
        public Value<List<MilestoneLog>> MilestoneLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneLogs() => !MilestoneLogs.Clean;
        public Value<DateTime?> MilestoneProcessedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneProcessedDate() => !MilestoneProcessedDate.Clean;
        public Value<string> MilestoneStage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneStage() => !MilestoneStage.Clean;
        public Value<DateTime?> MilestoneSubmittedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneSubmittedDate() => !MilestoneSubmittedDate.Clean;
        public Value<DateTime?> MilestoneSubmittedDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneSubmittedDueDate() => !MilestoneSubmittedDueDate.Clean;
        public Value<List<MilestoneTaskLog>> MilestoneTaskLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneTaskLogs() => !MilestoneTaskLogs.Clean;
        public Value<List<MilestoneTemplateLog>> MilestoneTemplateLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilestoneTemplateLogs() => !MilestoneTemplateLogs.Clean;
        public Value<decimal?> MipBorrowerPaidInCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMipBorrowerPaidInCashAmount() => !MipBorrowerPaidInCashAmount.Clean;
        public Value<decimal?> MipPaidInCashAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMipPaidInCashAmount() => !MipPaidInCashAmount.Clean;
        public Miscellaneous Miscellaneous { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiscellaneous() => Miscellaneous?.Clean == false;
        public Value<decimal?> MonthlyPIPaymentAmountForLE1andCD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIPaymentAmountForLE1andCD1() => !MonthlyPIPaymentAmountForLE1andCD1.Clean;
        public Value<decimal?> MortgageInsurancePremiumFHARefundAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePremiumFHARefundAmount() => !MortgageInsurancePremiumFHARefundAmount.Clean;
        public Value<decimal?> MortgageInsurancePremiumUpfrontFactorPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePremiumUpfrontFactorPercent() => !MortgageInsurancePremiumUpfrontFactorPercent.Clean;
        public Value<string> MortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageType() => !MortgageType.Clean;
        public Value<string> MsaIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMsaIdentifier() => !MsaIdentifier.Clean;
        public NetTangibleBenefit NetTangibleBenefit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetTangibleBenefit() => NetTangibleBenefit?.Clean == false;
        public Value<decimal?> NewFirstMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewFirstMortgageAmount() => !NewFirstMortgageAmount.Clean;
        public Value<string> NmlsLoanOriginatorId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsLoanOriginatorId() => !NmlsLoanOriginatorId.Clean;
        public Value<bool?> NoClosingCostOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoClosingCostOption() => !NoClosingCostOption.Clean;
        public Value<bool?> NotRequiredForPurchaseSaleOrRefinance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotRequiredForPurchaseSaleOrRefinance() => !NotRequiredForPurchaseSaleOrRefinance.Clean;
        public Value<bool?> NotRequiredForSettlementOfYourLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotRequiredForSettlementOfYourLoan() => !NotRequiredForSettlementOfYourLoan.Clean;
        public Value<string> OccupancyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancyType() => !OccupancyType.Clean;
        public Value<string> OpeningDocsInvestorCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsInvestorCode() => !OpeningDocsInvestorCode.Clean;
        public Value<string> OpeningDocsLoanProgramType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsLoanProgramType() => !OpeningDocsLoanProgramType.Clean;
        public Value<string> OpeningDocsPlanDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsPlanDescription() => !OpeningDocsPlanDescription.Clean;
        public Value<string> OpeningDocsPlanId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsPlanId() => !OpeningDocsPlanId.Clean;
        public Value<string> OpeningDocsProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsProgramCode() => !OpeningDocsProgramCode.Clean;
        public Value<string> OpeningDocsStackingOrder { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpeningDocsStackingOrder() => !OpeningDocsStackingOrder.Clean;
        public Value<string> OrganizationCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationCode() => !OrganizationCode.Clean;
        public Value<DateTime?> OriginationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationDate() => !OriginationDate.Clean;
        public Value<string> OtherAmortizationTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmortizationTypeDescription() => !OtherAmortizationTypeDescription.Clean;
        public Value<string> OtherMortgageTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMortgageTypeDescription() => !OtherMortgageTypeDescription.Clean;
        public Value<decimal?> OtherPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherPaidClosingCostsAmount() => !OtherPaidClosingCostsAmount.Clean;
        public Value<decimal?> OverwireAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOverwireAmount() => !OverwireAmount.Clean;
        public Value<bool?> PaymentScheduleCalcRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentScheduleCalcRequiredIndicator() => !PaymentScheduleCalcRequiredIndicator.Clean;
        public Value<string> PercentageOfOwnership { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentageOfOwnership() => !PercentageOfOwnership.Clean;
        public Value<decimal?> PercentageOwnershipInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentageOwnershipInterest() => !PercentageOwnershipInterest.Clean;
        public Value<bool?> PmiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmiIndicator() => !PmiIndicator.Clean;
        public Value<List<PostClosingConditionLog>> PostClosingConditionLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostClosingConditionLogs() => !PostClosingConditionLogs.Clean;
        public Value<List<PreliminaryConditionLog>> PreliminaryConditionLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryConditionLogs() => !PreliminaryConditionLogs.Clean;
        public Prequalification Prequalification { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrequalification() => Prequalification?.Clean == false;
        public Value<decimal?> PrincipalAndInterestMonthlyPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalAndInterestMonthlyPaymentAmount() => !PrincipalAndInterestMonthlyPaymentAmount.Clean;
        public Value<string> Print2003Application { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrint2003Application() => !Print2003Application.Clean;
        public Value<List<PrintLog>> PrintLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintLogs() => !PrintLogs.Clean;
        public PrivacyPolicy PrivacyPolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrivacyPolicy() => PrivacyPolicy?.Clean == false;
        public ProfitManagement ProfitManagement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProfitManagement() => ProfitManagement?.Clean == false;
        public Property Property { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProperty() => Property?.Clean == false;
        public Value<int?> PropertyAppraisedValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAppraisedValueAmount() => !PropertyAppraisedValueAmount.Clean;
        public Value<bool?> PropertyEnergyEfficientHomeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyEnergyEfficientHomeIndicator() => !PropertyEnergyEfficientHomeIndicator.Clean;
        public Value<int?> PropertyEstimatedValueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyEstimatedValueAmount() => !PropertyEstimatedValueAmount.Clean;
        public Value<string> ProposedDuesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedDuesAmount() => !ProposedDuesAmount.Clean;
        public Value<decimal?> ProposedFirstMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedFirstMortgageAmount() => !ProposedFirstMortgageAmount.Clean;
        public Value<decimal?> ProposedGroundRentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedGroundRentAmount() => !ProposedGroundRentAmount.Clean;
        public Value<string> ProposedHazardInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedHazardInsuranceAmount() => !ProposedHazardInsuranceAmount.Clean;
        public Value<decimal?> ProposedHousingExpenseTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedHousingExpenseTotal() => !ProposedHousingExpenseTotal.Clean;
        public Value<string> ProposedMortgageInsuranceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMortgageInsuranceAmount() => !ProposedMortgageInsuranceAmount.Clean;
        public Value<decimal?> ProposedOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedOtherAmount() => !ProposedOtherAmount.Clean;
        public Value<decimal?> ProposedOtherMortgagesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedOtherMortgagesAmount() => !ProposedOtherMortgagesAmount.Clean;
        public Value<string> ProposedRealEstateTaxesAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedRealEstateTaxesAmount() => !ProposedRealEstateTaxesAmount.Clean;
        public Value<List<PurchaseCredit>> PurchaseCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseCredits() => !PurchaseCredits.Clean;
        public Value<decimal?> PurchasePriceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceAmount() => !PurchasePriceAmount.Clean;
        public RateLock RateLock { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLock() => RateLock?.Clean == false;
        public Value<string> ReferralAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralAddress() => !ReferralAddress.Clean;
        public Value<string> ReferralCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralCity() => !ReferralCity.Clean;
        public Value<decimal?> ReferralFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralFeeAmount() => !ReferralFeeAmount.Clean;
        public Value<string> ReferralPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralPostalCode() => !ReferralPostalCode.Clean;
        public Value<string> ReferralSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralSource() => !ReferralSource.Clean;
        public Value<string> ReferralState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferralState() => !ReferralState.Clean;
        public Value<decimal?> RefinanceIncludingDebtsToBePaidOffAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceIncludingDebtsToBePaidOffAmount() => !RefinanceIncludingDebtsToBePaidOffAmount.Clean;
        public Value<List<RegistrationLog>> RegistrationLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegistrationLogs() => !RegistrationLogs.Clean;
        public RegulationZ RegulationZ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulationZ() => RegulationZ?.Clean == false;
        public Value<List<RemovedLogRecord>> RemovedLogRecords { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemovedLogRecords() => !RemovedLogRecords.Clean;
        public Value<decimal?> RepurchaseCostAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepurchaseCostAmount() => !RepurchaseCostAmount.Clean;
        public Value<DateTime?> RepurchaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepurchaseDate() => !RepurchaseDate.Clean;
        public Value<decimal?> RequestedInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedInterestRatePercent() => !RequestedInterestRatePercent.Clean;
        public Value<decimal?> SalesConcessionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSalesConcessionAmount() => !SalesConcessionAmount.Clean;
        public Value<decimal?> SecondSubordinateAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondSubordinateAmount() => !SecondSubordinateAmount.Clean;
        public Section32 Section32 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection32() => Section32?.Clean == false;
        public Value<string> SectionOfActType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSectionOfActType() => !SectionOfActType.Clean;
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedHomeCounselingProvider() => SelectedHomeCounselingProvider?.Clean == false;
        public Value<decimal?> SellerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPaidClosingCostsAmount() => !SellerPaidClosingCostsAmount.Clean;
        public Value<string> ServiceProviderAdditionalInfo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProviderAdditionalInfo() => !ServiceProviderAdditionalInfo.Clean;
        public Value<List<ServiceProviderContact>> ServiceProviderContacts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProviderContacts() => !ServiceProviderContacts.Clean;
        public Value<DateTime?> ServiceProviderDateIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceProviderDateIssued() => !ServiceProviderDateIssued.Clean;
        public ServicingDisclosure ServicingDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingDisclosure() => ServicingDisclosure?.Clean == false;
        public Value<bool?> SetForSettlementServicesOfAnAttorney { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSetForSettlementServicesOfAnAttorney() => !SetForSettlementServicesOfAnAttorney.Clean;
        public Value<bool?> SetForTheSettlementServicesListed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSetForTheSettlementServicesListed() => !SetForTheSettlementServicesListed.Clean;
        public Value<List<SettlementServiceCharge>> SettlementServiceCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementServiceCharges() => !SettlementServiceCharges.Clean;
        public Shipping Shipping { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShipping() => Shipping?.Clean == false;
        public Value<bool?> SimpleRefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSimpleRefinanceType() => !SimpleRefinanceType.Clean;
        public Value<decimal?> StartingAdjPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartingAdjPrice() => !StartingAdjPrice.Clean;
        public Value<decimal?> StartingAdjRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartingAdjRate() => !StartingAdjRate.Clean;
        public StateDisclosure StateDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateDisclosure() => StateDisclosure?.Clean == false;
        public StatementCreditDenial StatementCreditDenial { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatementCreditDenial() => StatementCreditDenial?.Clean == false;
        public Value<List<StatusOnlineLog>> StatusOnlineLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatusOnlineLogs() => !StatusOnlineLogs.Clean;
        public Value<decimal?> SubjectPropertyGrossRentalIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyGrossRentalIncomeAmount() => !SubjectPropertyGrossRentalIncomeAmount.Clean;
        public Value<decimal?> SubjectPropertyOccupancyPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyOccupancyPercent() => !SubjectPropertyOccupancyPercent.Clean;
        public Value<decimal?> SubordinateLienAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubordinateLienAmount() => !SubordinateLienAmount.Clean;
        public Value<string> SystemIdGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemIdGuid() => !SystemIdGuid.Clean;
        public Value<DateTime?> TilApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTilApplicationDate() => !TilApplicationDate.Clean;
        public Value<string> TitleHolderName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleHolderName1() => !TitleHolderName1.Clean;
        public Value<string> TitleHolderName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleHolderName2() => !TitleHolderName2.Clean;
        public Value<decimal?> Tltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTltv() => !Tltv.Clean;
        public Value<decimal?> TotalClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCostsAmount() => !TotalClosingCostsAmount.Clean;
        public Value<decimal?> TotalDeductionsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDeductionsAmount() => !TotalDeductionsAmount.Clean;
        public Value<decimal?> TotalFeesCostAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFeesCostAmount() => !TotalFeesCostAmount.Clean;
        public Value<decimal?> TotalFeesCreditAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFeesCreditAmount() => !TotalFeesCreditAmount.Clean;
        public Value<decimal?> TotalNonborrowerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNonborrowerPaidClosingCostsAmount() => !TotalNonborrowerPaidClosingCostsAmount.Clean;
        public Value<decimal?> TotalPaidOutsideClosingAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidOutsideClosingAmount() => !TotalPaidOutsideClosingAmount.Clean;
        public Value<decimal?> TotalPaidToBrokerAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidToBrokerAmount() => !TotalPaidToBrokerAmount.Clean;
        public Value<decimal?> TotalWireTransferAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalWireTransferAmount() => !TotalWireTransferAmount.Clean;
        public TPO TPO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTPO() => TPO?.Clean == false;
        public TQL TQL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQL() => TQL?.Clean == false;
        public TrustAccount TrustAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustAccount() => TrustAccount?.Clean == false;
        public Tsum Tsum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTsum() => Tsum?.Clean == false;
        public Value<bool?> TwelveMonthMortgageRentalHistoryIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTwelveMonthMortgageRentalHistoryIndicator() => !TwelveMonthMortgageRentalHistoryIndicator.Clean;
        public Uldd Uldd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUldd() => Uldd?.Clean == false;
        public UnderwriterSummary UnderwriterSummary { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwriterSummary() => UnderwriterSummary?.Clean == false;
        public Value<List<UnderwritingConditionLog>> UnderwritingConditionLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingConditionLogs() => !UnderwritingConditionLogs.Clean;
        public Value<bool?> UnderwritingEscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingEscrowIndicator() => !UnderwritingEscrowIndicator.Clean;
        public Value<decimal?> UndiscountedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUndiscountedRate() => !UndiscountedRate.Clean;
        public Value<int?> UnimprovedAppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnimprovedAppraisedValue() => !UnimprovedAppraisedValue.Clean;
        public Value<int?> UnimprovedEstimatedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnimprovedEstimatedValue() => !UnimprovedEstimatedValue.Clean;
        public Value<string> UrlPage4Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUrlPage4Comments() => !UrlPage4Comments.Clean;
        public Usda Usda { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsda() => Usda?.Clean == false;
        public Value<string> UsdaGovernmentLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaGovernmentLoanType() => !UsdaGovernmentLoanType.Clean;
        public Value<bool?> Use2018DiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUse2018DiIndicator() => !Use2018DiIndicator.Clean;
        public Value<string> UseNew2015FormsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseNew2015FormsIndicator() => !UseNew2015FormsIndicator.Clean;
        public Value<bool?> UseNewHudIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseNewHudIndicator() => !UseNewHudIndicator.Clean;
        public Value<decimal?> VAEntitlementAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAEntitlementAmount() => !VAEntitlementAmount.Clean;
        public VaLoanData VaLoanData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaLoanData() => VaLoanData?.Clean == false;
        public Value<List<VerificationLog>> VerificationLogs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationLogs() => !VerificationLogs.Clean;
        public Value<string> VirtualFields { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVirtualFields() => !VirtualFields.Clean;
        public Value<string> WebsiteId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWebsiteId() => !WebsiteId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdverseActionDate.Clean
                    && AffiliatedBusinessArrangements.Clean
                    && AgencyCaseIdentifier.Clean
                    && AlterationsImprovementsOrRepairsAmount.Clean
                    && Applications.Clean
                    && ApplicationTakenMethodType.Clean
                    && AprDisclosureDate.Clean
                    && ArmTypeDescription.Clean
                    && BaseLoanAmount.Clean
                    && BelowMarketSubordinateFinancingIndicator.Clean
                    && BillingCategory.Clean
                    && BiweeklyPaymentAmount.Clean
                    && BLTV.Clean
                    && BorrowerCoBorrowerMarriedIndicator.Clean
                    && BorrowerPaidClosingCostsAmount.Clean
                    && BorrowerPaidDiscountPointsAmount.Clean
                    && BorrowerPaidFHAVAClosingCostsAmount.Clean
                    && BorrowerRequestedLoanAmount.Clean
                    && BrokerPaidClosingCostsAmount.Clean
                    && BuydownIndicator.Clean
                    && BuydownMonthlyPaymentAmount.Clean
                    && BuydownRatePercent.Clean
                    && CashFromToBorrowerAmount.Clean
                    && Channel.Clean
                    && ClosingBillingDate.Clean
                    && ClosingCostProgram.Clean
                    && ClosingCostsAndPrepaidsFromOtherLienAmount.Clean
                    && ClosingCostsPaidByOthersAmount.Clean
                    && ClosingDocsStackingOrder.Clean
                    && CollateralManagerScore.Clean
                    && CombinedLtv.Clean
                    && CommitmentNumber.Clean
                    && ComplianceTestLogs.Clean
                    && ConformingJumbo.Clean
                    && ConsumerConnectSiteID.Clean
                    && Contacts.Clean
                    && ContactUpdatedIndicator.Clean
                    && ContractSellerCreditAmount.Clean
                    && ConversationLogs.Clean
                    && CopyBrokerToLenderIndicator.Clean
                    && CopyLoanNumLenderCaseNum.Clean
                    && CreditScoreToUse.Clean
                    && CrmLogs.Clean
                    && CurrentApplicationIndex.Clean
                    && CurrentApplicationIsPrimary.Clean
                    && CurrentFirstMortgageHolderType.Clean
                    && CustomFields.Clean
                    && DataTracLogs.Clean
                    && DBIndicator.Clean
                    && DeductOverwireAmountIndicator.Clean
                    && DisableESignConsentAlert.Clean
                    && DisableKeyPricingAlert.Clean
                    && DisclosureTracking2015Logs.Clean
                    && DisclosureTrackingLogs.Clean
                    && DiscountPoint.Clean
                    && DocEngine.Clean
                    && DocumentLogs.Clean
                    && DoNotCheckEmail.Clean
                    && DoNotPrintCompensationFees.Clean
                    && DownloadLogs.Clean
                    && DownPaymentPercent.Clean
                    && EdmLogs.Clean
                    && EmailTriggerLogs.Clean
                    && EmXmlVersionId.Clean
                    && EncompassId.Clean
                    && EnforceCountyLoanLimit.Clean
                    && EstimatedClosingCostsAmount.Clean
                    && EstimatedConstructionInterest.Clean
                    && EstimatedPrepaidItemsAmount.Clean
                    && ExportLoanNumber.Clean
                    && Fees.Clean
                    && FhaMiPremiumRefundAmount.Clean
                    && FHAVALoanOriginatorIdentifier.Clean
                    && FieldLockData.Clean
                    && FirstAdjustmentMinimum.Clean
                    && FirstSubordinateLienAmount.Clean
                    && FirstTimeHomebuyersIndicator.Clean
                    && FnmCommunityLendingProductName.Clean
                    && FnmCommunitySecondsIndicator.Clean
                    && FnmNeighborsMortgageEligibilityIndicator.Clean
                    && Forms.Clean
                    && FraudScore.Clean
                    && FundingDeductionList.Clean
                    && FundingFeeList.Clean
                    && FundingFees.Clean
                    && GovernmentLoanLenderIdentifier.Clean
                    && GovernmentLoanSponsorIdentifier.Clean
                    && GovernmentMortgageCreditCertificateAmount.Clean
                    && HasAbusinessRelationshipWith.Clean
                    && HcltvHtltv.Clean
                    && HelocTeaserRate.Clean
                    && HomeCounselingProviders.Clean
                    && HomeCounselingProvidersDistance.Clean
                    && HomeCounselingProvidersLanguageNames.Clean
                    && HomeCounselingProvidersServiceNames.Clean
                    && HouseholdSizeCount.Clean
                    && HtmlEmailLogs.Clean
                    && HudIncomeLimitAdjustmentFactor.Clean
                    && HudLendingIncomeLimitAmount.Clean
                    && HudMedianIncomeAmount.Clean
                    && Id.Clean
                    && IncludeUSDAFeeInClosing.Clean
                    && InitialInterestRate.Clean
                    && InsuranceAuthorizationIndicator.Clean
                    && InterviewerApplicationSignedDate.Clean
                    && InterviewerEmail.Clean
                    && InterviewerLicenseIdentifier.Clean
                    && InterviewerPhoneNumber.Clean
                    && InterviewersCompanyStateLicense.Clean
                    && InterviewersId.Clean
                    && InverviewerName.Clean
                    && IsCreditorProhibitsBorrower.Clean
                    && IsEmployeeLoan.Clean
                    && IsLSSecondaryFile.Clean
                    && IsRequiredInterestReserveCompoundInterest.Clean
                    && LandIfAcquiredSeperatelyAmount.Clean
                    && LeadSource.Clean
                    && LenderCaseIdentifier.Clean
                    && LenderChannel.Clean
                    && LenderCreditsInFunding.Clean
                    && LenderInvestorCode.Clean
                    && LenderPaidClosignCostsDotAmount.Clean
                    && LenderPaidClosingCostsAmount.Clean
                    && LesserAppraisedValueOrSalesPrice.Clean
                    && LifeInsuranceCoverageAmount.Clean
                    && LifeInsuranceEstimatedMonthlyAmount.Clean
                    && LifeInsuranceTotalProtectedMonthlyAmount.Clean
                    && LinkId.Clean
                    && LoanActionLogs.Clean
                    && LoanAmortizationTermMonths.Clean
                    && LoanAmortizationType.Clean
                    && LoanCreatedDate.Clean
                    && LoanCreatedDateUtc.Clean
                    && LoanIdNumber.Clean
                    && LoanImportStatusIndicator.Clean
                    && LoanLinkSyncType.Clean
                    && LoanNumber.Clean
                    && LoanProgramName.Clean
                    && LoanPrograms.Clean
                    && LoanPurposeOfRefinanceType.Clean
                    && LoanSource.Clean
                    && LoanTotalProposedMonthlyMaintenanceAmount.Clean
                    && LoanTotalProposedMonthlyUtilitiesAmount.Clean
                    && LoanUnderwriterCHUMSIdentifier.Clean
                    && LoanVALoanProcedureType.Clean
                    && LoanVARateReductionInitialComputationTotalAmount.Clean
                    && LoanVAResidualIncomeAmount.Clean
                    && LoanVersionId.Clean
                    && LockConfirmLogs.Clean
                    && LockDenialLogs.Clean
                    && LockRequestLogs.Clean
                    && LogEntryLogs.Clean
                    && Ltv.Clean
                    && LtvPropertyValue.Clean
                    && MasterCommitmentNumber.Clean
                    && MaturityDate.Clean
                    && MaxBackRatio.Clean
                    && MaxFrontRatio.Clean
                    && MersNumber.Clean
                    && MersNumberRegistrationDate.Clean
                    && MiAndFundingFeeFinancedAmount.Clean
                    && MiAndFundingFeeTotalAmount.Clean
                    && MilestoneApprovedDate.Clean
                    && MilestoneApprovedDueDate.Clean
                    && MilestoneCompletedDate.Clean
                    && MilestoneCompletedDueDate.Clean
                    && MilestoneCurrentDateUtc.Clean
                    && MilestoneCurrentName.Clean
                    && MilestoneDocSignedDate.Clean
                    && MilestoneDocSignedDueDate.Clean
                    && MilestoneDuration.Clean
                    && MilestoneFileStartedDate.Clean
                    && MilestoneFreeRoleLogs.Clean
                    && MilestoneFundedDate.Clean
                    && MilestoneFundedDueDate.Clean
                    && MilestoneLogs.Clean
                    && MilestoneProcessedDate.Clean
                    && MilestoneStage.Clean
                    && MilestoneSubmittedDate.Clean
                    && MilestoneSubmittedDueDate.Clean
                    && MilestoneTaskLogs.Clean
                    && MilestoneTemplateLogs.Clean
                    && MipBorrowerPaidInCashAmount.Clean
                    && MipPaidInCashAmount.Clean
                    && MonthlyPIPaymentAmountForLE1andCD1.Clean
                    && MortgageInsurancePremiumFHARefundAmount.Clean
                    && MortgageInsurancePremiumUpfrontFactorPercent.Clean
                    && MortgageType.Clean
                    && MsaIdentifier.Clean
                    && NewFirstMortgageAmount.Clean
                    && NmlsLoanOriginatorId.Clean
                    && NoClosingCostOption.Clean
                    && NotRequiredForPurchaseSaleOrRefinance.Clean
                    && NotRequiredForSettlementOfYourLoan.Clean
                    && OccupancyType.Clean
                    && OpeningDocsInvestorCode.Clean
                    && OpeningDocsLoanProgramType.Clean
                    && OpeningDocsPlanDescription.Clean
                    && OpeningDocsPlanId.Clean
                    && OpeningDocsProgramCode.Clean
                    && OpeningDocsStackingOrder.Clean
                    && OrganizationCode.Clean
                    && OriginationDate.Clean
                    && OtherAmortizationTypeDescription.Clean
                    && OtherMortgageTypeDescription.Clean
                    && OtherPaidClosingCostsAmount.Clean
                    && OverwireAmount.Clean
                    && PaymentScheduleCalcRequiredIndicator.Clean
                    && PercentageOfOwnership.Clean
                    && PercentageOwnershipInterest.Clean
                    && PmiIndicator.Clean
                    && PostClosingConditionLogs.Clean
                    && PreliminaryConditionLogs.Clean
                    && PrincipalAndInterestMonthlyPaymentAmount.Clean
                    && Print2003Application.Clean
                    && PrintLogs.Clean
                    && PropertyAppraisedValueAmount.Clean
                    && PropertyEnergyEfficientHomeIndicator.Clean
                    && PropertyEstimatedValueAmount.Clean
                    && ProposedDuesAmount.Clean
                    && ProposedFirstMortgageAmount.Clean
                    && ProposedGroundRentAmount.Clean
                    && ProposedHazardInsuranceAmount.Clean
                    && ProposedHousingExpenseTotal.Clean
                    && ProposedMortgageInsuranceAmount.Clean
                    && ProposedOtherAmount.Clean
                    && ProposedOtherMortgagesAmount.Clean
                    && ProposedRealEstateTaxesAmount.Clean
                    && PurchaseCredits.Clean
                    && PurchasePriceAmount.Clean
                    && ReferralAddress.Clean
                    && ReferralCity.Clean
                    && ReferralFeeAmount.Clean
                    && ReferralPostalCode.Clean
                    && ReferralSource.Clean
                    && ReferralState.Clean
                    && RefinanceIncludingDebtsToBePaidOffAmount.Clean
                    && RegistrationLogs.Clean
                    && RemovedLogRecords.Clean
                    && RepurchaseCostAmount.Clean
                    && RepurchaseDate.Clean
                    && RequestedInterestRatePercent.Clean
                    && SalesConcessionAmount.Clean
                    && SecondSubordinateAmount.Clean
                    && SectionOfActType.Clean
                    && SellerPaidClosingCostsAmount.Clean
                    && ServiceProviderAdditionalInfo.Clean
                    && ServiceProviderContacts.Clean
                    && ServiceProviderDateIssued.Clean
                    && SetForSettlementServicesOfAnAttorney.Clean
                    && SetForTheSettlementServicesListed.Clean
                    && SettlementServiceCharges.Clean
                    && SimpleRefinanceType.Clean
                    && StartingAdjPrice.Clean
                    && StartingAdjRate.Clean
                    && StatusOnlineLogs.Clean
                    && SubjectPropertyGrossRentalIncomeAmount.Clean
                    && SubjectPropertyOccupancyPercent.Clean
                    && SubordinateLienAmount.Clean
                    && SystemIdGuid.Clean
                    && TilApplicationDate.Clean
                    && TitleHolderName1.Clean
                    && TitleHolderName2.Clean
                    && Tltv.Clean
                    && TotalClosingCostsAmount.Clean
                    && TotalDeductionsAmount.Clean
                    && TotalFeesCostAmount.Clean
                    && TotalFeesCreditAmount.Clean
                    && TotalNonborrowerPaidClosingCostsAmount.Clean
                    && TotalPaidOutsideClosingAmount.Clean
                    && TotalPaidToBrokerAmount.Clean
                    && TotalWireTransferAmount.Clean
                    && TwelveMonthMortgageRentalHistoryIndicator.Clean
                    && UnderwritingConditionLogs.Clean
                    && UnderwritingEscrowIndicator.Clean
                    && UndiscountedRate.Clean
                    && UnimprovedAppraisedValue.Clean
                    && UnimprovedEstimatedValue.Clean
                    && UrlPage4Comments.Clean
                    && UsdaGovernmentLoanType.Clean
                    && Use2018DiIndicator.Clean
                    && UseNew2015FormsIndicator.Clean
                    && UseNewHudIndicator.Clean
                    && VAEntitlementAmount.Clean
                    && VerificationLogs.Clean
                    && VirtualFields.Clean
                    && WebsiteId.Clean
                    && AdditionalRequests.Clean
                    && ATRQMCommon.Clean
                    && ClosingCost.Clean
                    && ClosingDocument.Clean
                    && CommitmentTerms.Clean
                    && ConstructionManagement.Clean
                    && Correspondent.Clean
                    && CurrentApplication.Clean
                    && CustomModelFields.Clean
                    && DisclosureNotices.Clean
                    && DownPayment.Clean
                    && EmDocument.Clean
                    && EmDocumentInvestor.Clean
                    && EmDocumentLender.Clean
                    && FannieMae.Clean
                    && FhaVaLoan.Clean
                    && FreddieMac.Clean
                    && Funding.Clean
                    && Gfe.Clean
                    && Hmda.Clean
                    && Hud1Es.Clean
                    && HudLoanData.Clean
                    && InterimServicing.Clean
                    && LoanProductData.Clean
                    && LoanSubmission.Clean
                    && LOCompensation.Clean
                    && Mcaw.Clean
                    && Miscellaneous.Clean
                    && NetTangibleBenefit.Clean
                    && Prequalification.Clean
                    && PrivacyPolicy.Clean
                    && ProfitManagement.Clean
                    && Property.Clean
                    && RateLock.Clean
                    && RegulationZ.Clean
                    && Section32.Clean
                    && SelectedHomeCounselingProvider.Clean
                    && ServicingDisclosure.Clean
                    && Shipping.Clean
                    && StateDisclosure.Clean
                    && StatementCreditDenial.Clean
                    && TPO.Clean
                    && TQL.Clean
                    && TrustAccount.Clean
                    && Tsum.Clean
                    && Uldd.Clean
                    && UnderwriterSummary.Clean
                    && Usda.Clean
                    && VaLoanData.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdverseActionDate; v0.Clean = value; AdverseActionDate = v0;
                var v1 = AffiliatedBusinessArrangements; v1.Clean = value; AffiliatedBusinessArrangements = v1;
                var v2 = AgencyCaseIdentifier; v2.Clean = value; AgencyCaseIdentifier = v2;
                var v3 = AlterationsImprovementsOrRepairsAmount; v3.Clean = value; AlterationsImprovementsOrRepairsAmount = v3;
                var v4 = Applications; v4.Clean = value; Applications = v4;
                var v5 = ApplicationTakenMethodType; v5.Clean = value; ApplicationTakenMethodType = v5;
                var v6 = AprDisclosureDate; v6.Clean = value; AprDisclosureDate = v6;
                var v7 = ArmTypeDescription; v7.Clean = value; ArmTypeDescription = v7;
                var v8 = BaseLoanAmount; v8.Clean = value; BaseLoanAmount = v8;
                var v9 = BelowMarketSubordinateFinancingIndicator; v9.Clean = value; BelowMarketSubordinateFinancingIndicator = v9;
                var v10 = BillingCategory; v10.Clean = value; BillingCategory = v10;
                var v11 = BiweeklyPaymentAmount; v11.Clean = value; BiweeklyPaymentAmount = v11;
                var v12 = BLTV; v12.Clean = value; BLTV = v12;
                var v13 = BorrowerCoBorrowerMarriedIndicator; v13.Clean = value; BorrowerCoBorrowerMarriedIndicator = v13;
                var v14 = BorrowerPaidClosingCostsAmount; v14.Clean = value; BorrowerPaidClosingCostsAmount = v14;
                var v15 = BorrowerPaidDiscountPointsAmount; v15.Clean = value; BorrowerPaidDiscountPointsAmount = v15;
                var v16 = BorrowerPaidFHAVAClosingCostsAmount; v16.Clean = value; BorrowerPaidFHAVAClosingCostsAmount = v16;
                var v17 = BorrowerRequestedLoanAmount; v17.Clean = value; BorrowerRequestedLoanAmount = v17;
                var v18 = BrokerPaidClosingCostsAmount; v18.Clean = value; BrokerPaidClosingCostsAmount = v18;
                var v19 = BuydownIndicator; v19.Clean = value; BuydownIndicator = v19;
                var v20 = BuydownMonthlyPaymentAmount; v20.Clean = value; BuydownMonthlyPaymentAmount = v20;
                var v21 = BuydownRatePercent; v21.Clean = value; BuydownRatePercent = v21;
                var v22 = CashFromToBorrowerAmount; v22.Clean = value; CashFromToBorrowerAmount = v22;
                var v23 = Channel; v23.Clean = value; Channel = v23;
                var v24 = ClosingBillingDate; v24.Clean = value; ClosingBillingDate = v24;
                var v25 = ClosingCostProgram; v25.Clean = value; ClosingCostProgram = v25;
                var v26 = ClosingCostsAndPrepaidsFromOtherLienAmount; v26.Clean = value; ClosingCostsAndPrepaidsFromOtherLienAmount = v26;
                var v27 = ClosingCostsPaidByOthersAmount; v27.Clean = value; ClosingCostsPaidByOthersAmount = v27;
                var v28 = ClosingDocsStackingOrder; v28.Clean = value; ClosingDocsStackingOrder = v28;
                var v29 = CollateralManagerScore; v29.Clean = value; CollateralManagerScore = v29;
                var v30 = CombinedLtv; v30.Clean = value; CombinedLtv = v30;
                var v31 = CommitmentNumber; v31.Clean = value; CommitmentNumber = v31;
                var v32 = ComplianceTestLogs; v32.Clean = value; ComplianceTestLogs = v32;
                var v33 = ConformingJumbo; v33.Clean = value; ConformingJumbo = v33;
                var v34 = ConsumerConnectSiteID; v34.Clean = value; ConsumerConnectSiteID = v34;
                var v35 = Contacts; v35.Clean = value; Contacts = v35;
                var v36 = ContactUpdatedIndicator; v36.Clean = value; ContactUpdatedIndicator = v36;
                var v37 = ContractSellerCreditAmount; v37.Clean = value; ContractSellerCreditAmount = v37;
                var v38 = ConversationLogs; v38.Clean = value; ConversationLogs = v38;
                var v39 = CopyBrokerToLenderIndicator; v39.Clean = value; CopyBrokerToLenderIndicator = v39;
                var v40 = CopyLoanNumLenderCaseNum; v40.Clean = value; CopyLoanNumLenderCaseNum = v40;
                var v41 = CreditScoreToUse; v41.Clean = value; CreditScoreToUse = v41;
                var v42 = CrmLogs; v42.Clean = value; CrmLogs = v42;
                var v43 = CurrentApplicationIndex; v43.Clean = value; CurrentApplicationIndex = v43;
                var v44 = CurrentApplicationIsPrimary; v44.Clean = value; CurrentApplicationIsPrimary = v44;
                var v45 = CurrentFirstMortgageHolderType; v45.Clean = value; CurrentFirstMortgageHolderType = v45;
                var v46 = CustomFields; v46.Clean = value; CustomFields = v46;
                var v47 = DataTracLogs; v47.Clean = value; DataTracLogs = v47;
                var v48 = DBIndicator; v48.Clean = value; DBIndicator = v48;
                var v49 = DeductOverwireAmountIndicator; v49.Clean = value; DeductOverwireAmountIndicator = v49;
                var v50 = DisableESignConsentAlert; v50.Clean = value; DisableESignConsentAlert = v50;
                var v51 = DisableKeyPricingAlert; v51.Clean = value; DisableKeyPricingAlert = v51;
                var v52 = DisclosureTracking2015Logs; v52.Clean = value; DisclosureTracking2015Logs = v52;
                var v53 = DisclosureTrackingLogs; v53.Clean = value; DisclosureTrackingLogs = v53;
                var v54 = DiscountPoint; v54.Clean = value; DiscountPoint = v54;
                var v55 = DocEngine; v55.Clean = value; DocEngine = v55;
                var v56 = DocumentLogs; v56.Clean = value; DocumentLogs = v56;
                var v57 = DoNotCheckEmail; v57.Clean = value; DoNotCheckEmail = v57;
                var v58 = DoNotPrintCompensationFees; v58.Clean = value; DoNotPrintCompensationFees = v58;
                var v59 = DownloadLogs; v59.Clean = value; DownloadLogs = v59;
                var v60 = DownPaymentPercent; v60.Clean = value; DownPaymentPercent = v60;
                var v61 = EdmLogs; v61.Clean = value; EdmLogs = v61;
                var v62 = EmailTriggerLogs; v62.Clean = value; EmailTriggerLogs = v62;
                var v63 = EmXmlVersionId; v63.Clean = value; EmXmlVersionId = v63;
                var v64 = EncompassId; v64.Clean = value; EncompassId = v64;
                var v65 = EnforceCountyLoanLimit; v65.Clean = value; EnforceCountyLoanLimit = v65;
                var v66 = EstimatedClosingCostsAmount; v66.Clean = value; EstimatedClosingCostsAmount = v66;
                var v67 = EstimatedConstructionInterest; v67.Clean = value; EstimatedConstructionInterest = v67;
                var v68 = EstimatedPrepaidItemsAmount; v68.Clean = value; EstimatedPrepaidItemsAmount = v68;
                var v69 = ExportLoanNumber; v69.Clean = value; ExportLoanNumber = v69;
                var v70 = Fees; v70.Clean = value; Fees = v70;
                var v71 = FhaMiPremiumRefundAmount; v71.Clean = value; FhaMiPremiumRefundAmount = v71;
                var v72 = FHAVALoanOriginatorIdentifier; v72.Clean = value; FHAVALoanOriginatorIdentifier = v72;
                var v73 = FieldLockData; v73.Clean = value; FieldLockData = v73;
                var v74 = FirstAdjustmentMinimum; v74.Clean = value; FirstAdjustmentMinimum = v74;
                var v75 = FirstSubordinateLienAmount; v75.Clean = value; FirstSubordinateLienAmount = v75;
                var v76 = FirstTimeHomebuyersIndicator; v76.Clean = value; FirstTimeHomebuyersIndicator = v76;
                var v77 = FnmCommunityLendingProductName; v77.Clean = value; FnmCommunityLendingProductName = v77;
                var v78 = FnmCommunitySecondsIndicator; v78.Clean = value; FnmCommunitySecondsIndicator = v78;
                var v79 = FnmNeighborsMortgageEligibilityIndicator; v79.Clean = value; FnmNeighborsMortgageEligibilityIndicator = v79;
                var v80 = Forms; v80.Clean = value; Forms = v80;
                var v81 = FraudScore; v81.Clean = value; FraudScore = v81;
                var v82 = FundingDeductionList; v82.Clean = value; FundingDeductionList = v82;
                var v83 = FundingFeeList; v83.Clean = value; FundingFeeList = v83;
                var v84 = FundingFees; v84.Clean = value; FundingFees = v84;
                var v85 = GovernmentLoanLenderIdentifier; v85.Clean = value; GovernmentLoanLenderIdentifier = v85;
                var v86 = GovernmentLoanSponsorIdentifier; v86.Clean = value; GovernmentLoanSponsorIdentifier = v86;
                var v87 = GovernmentMortgageCreditCertificateAmount; v87.Clean = value; GovernmentMortgageCreditCertificateAmount = v87;
                var v88 = HasAbusinessRelationshipWith; v88.Clean = value; HasAbusinessRelationshipWith = v88;
                var v89 = HcltvHtltv; v89.Clean = value; HcltvHtltv = v89;
                var v90 = HelocTeaserRate; v90.Clean = value; HelocTeaserRate = v90;
                var v91 = HomeCounselingProviders; v91.Clean = value; HomeCounselingProviders = v91;
                var v92 = HomeCounselingProvidersDistance; v92.Clean = value; HomeCounselingProvidersDistance = v92;
                var v93 = HomeCounselingProvidersLanguageNames; v93.Clean = value; HomeCounselingProvidersLanguageNames = v93;
                var v94 = HomeCounselingProvidersServiceNames; v94.Clean = value; HomeCounselingProvidersServiceNames = v94;
                var v95 = HouseholdSizeCount; v95.Clean = value; HouseholdSizeCount = v95;
                var v96 = HtmlEmailLogs; v96.Clean = value; HtmlEmailLogs = v96;
                var v97 = HudIncomeLimitAdjustmentFactor; v97.Clean = value; HudIncomeLimitAdjustmentFactor = v97;
                var v98 = HudLendingIncomeLimitAmount; v98.Clean = value; HudLendingIncomeLimitAmount = v98;
                var v99 = HudMedianIncomeAmount; v99.Clean = value; HudMedianIncomeAmount = v99;
                var v100 = Id; v100.Clean = value; Id = v100;
                var v101 = IncludeUSDAFeeInClosing; v101.Clean = value; IncludeUSDAFeeInClosing = v101;
                var v102 = InitialInterestRate; v102.Clean = value; InitialInterestRate = v102;
                var v103 = InsuranceAuthorizationIndicator; v103.Clean = value; InsuranceAuthorizationIndicator = v103;
                var v104 = InterviewerApplicationSignedDate; v104.Clean = value; InterviewerApplicationSignedDate = v104;
                var v105 = InterviewerEmail; v105.Clean = value; InterviewerEmail = v105;
                var v106 = InterviewerLicenseIdentifier; v106.Clean = value; InterviewerLicenseIdentifier = v106;
                var v107 = InterviewerPhoneNumber; v107.Clean = value; InterviewerPhoneNumber = v107;
                var v108 = InterviewersCompanyStateLicense; v108.Clean = value; InterviewersCompanyStateLicense = v108;
                var v109 = InterviewersId; v109.Clean = value; InterviewersId = v109;
                var v110 = InverviewerName; v110.Clean = value; InverviewerName = v110;
                var v111 = IsCreditorProhibitsBorrower; v111.Clean = value; IsCreditorProhibitsBorrower = v111;
                var v112 = IsEmployeeLoan; v112.Clean = value; IsEmployeeLoan = v112;
                var v113 = IsLSSecondaryFile; v113.Clean = value; IsLSSecondaryFile = v113;
                var v114 = IsRequiredInterestReserveCompoundInterest; v114.Clean = value; IsRequiredInterestReserveCompoundInterest = v114;
                var v115 = LandIfAcquiredSeperatelyAmount; v115.Clean = value; LandIfAcquiredSeperatelyAmount = v115;
                var v116 = LeadSource; v116.Clean = value; LeadSource = v116;
                var v117 = LenderCaseIdentifier; v117.Clean = value; LenderCaseIdentifier = v117;
                var v118 = LenderChannel; v118.Clean = value; LenderChannel = v118;
                var v119 = LenderCreditsInFunding; v119.Clean = value; LenderCreditsInFunding = v119;
                var v120 = LenderInvestorCode; v120.Clean = value; LenderInvestorCode = v120;
                var v121 = LenderPaidClosignCostsDotAmount; v121.Clean = value; LenderPaidClosignCostsDotAmount = v121;
                var v122 = LenderPaidClosingCostsAmount; v122.Clean = value; LenderPaidClosingCostsAmount = v122;
                var v123 = LesserAppraisedValueOrSalesPrice; v123.Clean = value; LesserAppraisedValueOrSalesPrice = v123;
                var v124 = LifeInsuranceCoverageAmount; v124.Clean = value; LifeInsuranceCoverageAmount = v124;
                var v125 = LifeInsuranceEstimatedMonthlyAmount; v125.Clean = value; LifeInsuranceEstimatedMonthlyAmount = v125;
                var v126 = LifeInsuranceTotalProtectedMonthlyAmount; v126.Clean = value; LifeInsuranceTotalProtectedMonthlyAmount = v126;
                var v127 = LinkId; v127.Clean = value; LinkId = v127;
                var v128 = LoanActionLogs; v128.Clean = value; LoanActionLogs = v128;
                var v129 = LoanAmortizationTermMonths; v129.Clean = value; LoanAmortizationTermMonths = v129;
                var v130 = LoanAmortizationType; v130.Clean = value; LoanAmortizationType = v130;
                var v131 = LoanCreatedDate; v131.Clean = value; LoanCreatedDate = v131;
                var v132 = LoanCreatedDateUtc; v132.Clean = value; LoanCreatedDateUtc = v132;
                var v133 = LoanIdNumber; v133.Clean = value; LoanIdNumber = v133;
                var v134 = LoanImportStatusIndicator; v134.Clean = value; LoanImportStatusIndicator = v134;
                var v135 = LoanLinkSyncType; v135.Clean = value; LoanLinkSyncType = v135;
                var v136 = LoanNumber; v136.Clean = value; LoanNumber = v136;
                var v137 = LoanProgramName; v137.Clean = value; LoanProgramName = v137;
                var v138 = LoanPrograms; v138.Clean = value; LoanPrograms = v138;
                var v139 = LoanPurposeOfRefinanceType; v139.Clean = value; LoanPurposeOfRefinanceType = v139;
                var v140 = LoanSource; v140.Clean = value; LoanSource = v140;
                var v141 = LoanTotalProposedMonthlyMaintenanceAmount; v141.Clean = value; LoanTotalProposedMonthlyMaintenanceAmount = v141;
                var v142 = LoanTotalProposedMonthlyUtilitiesAmount; v142.Clean = value; LoanTotalProposedMonthlyUtilitiesAmount = v142;
                var v143 = LoanUnderwriterCHUMSIdentifier; v143.Clean = value; LoanUnderwriterCHUMSIdentifier = v143;
                var v144 = LoanVALoanProcedureType; v144.Clean = value; LoanVALoanProcedureType = v144;
                var v145 = LoanVARateReductionInitialComputationTotalAmount; v145.Clean = value; LoanVARateReductionInitialComputationTotalAmount = v145;
                var v146 = LoanVAResidualIncomeAmount; v146.Clean = value; LoanVAResidualIncomeAmount = v146;
                var v147 = LoanVersionId; v147.Clean = value; LoanVersionId = v147;
                var v148 = LockConfirmLogs; v148.Clean = value; LockConfirmLogs = v148;
                var v149 = LockDenialLogs; v149.Clean = value; LockDenialLogs = v149;
                var v150 = LockRequestLogs; v150.Clean = value; LockRequestLogs = v150;
                var v151 = LogEntryLogs; v151.Clean = value; LogEntryLogs = v151;
                var v152 = Ltv; v152.Clean = value; Ltv = v152;
                var v153 = LtvPropertyValue; v153.Clean = value; LtvPropertyValue = v153;
                var v154 = MasterCommitmentNumber; v154.Clean = value; MasterCommitmentNumber = v154;
                var v155 = MaturityDate; v155.Clean = value; MaturityDate = v155;
                var v156 = MaxBackRatio; v156.Clean = value; MaxBackRatio = v156;
                var v157 = MaxFrontRatio; v157.Clean = value; MaxFrontRatio = v157;
                var v158 = MersNumber; v158.Clean = value; MersNumber = v158;
                var v159 = MersNumberRegistrationDate; v159.Clean = value; MersNumberRegistrationDate = v159;
                var v160 = MiAndFundingFeeFinancedAmount; v160.Clean = value; MiAndFundingFeeFinancedAmount = v160;
                var v161 = MiAndFundingFeeTotalAmount; v161.Clean = value; MiAndFundingFeeTotalAmount = v161;
                var v162 = MilestoneApprovedDate; v162.Clean = value; MilestoneApprovedDate = v162;
                var v163 = MilestoneApprovedDueDate; v163.Clean = value; MilestoneApprovedDueDate = v163;
                var v164 = MilestoneCompletedDate; v164.Clean = value; MilestoneCompletedDate = v164;
                var v165 = MilestoneCompletedDueDate; v165.Clean = value; MilestoneCompletedDueDate = v165;
                var v166 = MilestoneCurrentDateUtc; v166.Clean = value; MilestoneCurrentDateUtc = v166;
                var v167 = MilestoneCurrentName; v167.Clean = value; MilestoneCurrentName = v167;
                var v168 = MilestoneDocSignedDate; v168.Clean = value; MilestoneDocSignedDate = v168;
                var v169 = MilestoneDocSignedDueDate; v169.Clean = value; MilestoneDocSignedDueDate = v169;
                var v170 = MilestoneDuration; v170.Clean = value; MilestoneDuration = v170;
                var v171 = MilestoneFileStartedDate; v171.Clean = value; MilestoneFileStartedDate = v171;
                var v172 = MilestoneFreeRoleLogs; v172.Clean = value; MilestoneFreeRoleLogs = v172;
                var v173 = MilestoneFundedDate; v173.Clean = value; MilestoneFundedDate = v173;
                var v174 = MilestoneFundedDueDate; v174.Clean = value; MilestoneFundedDueDate = v174;
                var v175 = MilestoneLogs; v175.Clean = value; MilestoneLogs = v175;
                var v176 = MilestoneProcessedDate; v176.Clean = value; MilestoneProcessedDate = v176;
                var v177 = MilestoneStage; v177.Clean = value; MilestoneStage = v177;
                var v178 = MilestoneSubmittedDate; v178.Clean = value; MilestoneSubmittedDate = v178;
                var v179 = MilestoneSubmittedDueDate; v179.Clean = value; MilestoneSubmittedDueDate = v179;
                var v180 = MilestoneTaskLogs; v180.Clean = value; MilestoneTaskLogs = v180;
                var v181 = MilestoneTemplateLogs; v181.Clean = value; MilestoneTemplateLogs = v181;
                var v182 = MipBorrowerPaidInCashAmount; v182.Clean = value; MipBorrowerPaidInCashAmount = v182;
                var v183 = MipPaidInCashAmount; v183.Clean = value; MipPaidInCashAmount = v183;
                var v184 = MonthlyPIPaymentAmountForLE1andCD1; v184.Clean = value; MonthlyPIPaymentAmountForLE1andCD1 = v184;
                var v185 = MortgageInsurancePremiumFHARefundAmount; v185.Clean = value; MortgageInsurancePremiumFHARefundAmount = v185;
                var v186 = MortgageInsurancePremiumUpfrontFactorPercent; v186.Clean = value; MortgageInsurancePremiumUpfrontFactorPercent = v186;
                var v187 = MortgageType; v187.Clean = value; MortgageType = v187;
                var v188 = MsaIdentifier; v188.Clean = value; MsaIdentifier = v188;
                var v189 = NewFirstMortgageAmount; v189.Clean = value; NewFirstMortgageAmount = v189;
                var v190 = NmlsLoanOriginatorId; v190.Clean = value; NmlsLoanOriginatorId = v190;
                var v191 = NoClosingCostOption; v191.Clean = value; NoClosingCostOption = v191;
                var v192 = NotRequiredForPurchaseSaleOrRefinance; v192.Clean = value; NotRequiredForPurchaseSaleOrRefinance = v192;
                var v193 = NotRequiredForSettlementOfYourLoan; v193.Clean = value; NotRequiredForSettlementOfYourLoan = v193;
                var v194 = OccupancyType; v194.Clean = value; OccupancyType = v194;
                var v195 = OpeningDocsInvestorCode; v195.Clean = value; OpeningDocsInvestorCode = v195;
                var v196 = OpeningDocsLoanProgramType; v196.Clean = value; OpeningDocsLoanProgramType = v196;
                var v197 = OpeningDocsPlanDescription; v197.Clean = value; OpeningDocsPlanDescription = v197;
                var v198 = OpeningDocsPlanId; v198.Clean = value; OpeningDocsPlanId = v198;
                var v199 = OpeningDocsProgramCode; v199.Clean = value; OpeningDocsProgramCode = v199;
                var v200 = OpeningDocsStackingOrder; v200.Clean = value; OpeningDocsStackingOrder = v200;
                var v201 = OrganizationCode; v201.Clean = value; OrganizationCode = v201;
                var v202 = OriginationDate; v202.Clean = value; OriginationDate = v202;
                var v203 = OtherAmortizationTypeDescription; v203.Clean = value; OtherAmortizationTypeDescription = v203;
                var v204 = OtherMortgageTypeDescription; v204.Clean = value; OtherMortgageTypeDescription = v204;
                var v205 = OtherPaidClosingCostsAmount; v205.Clean = value; OtherPaidClosingCostsAmount = v205;
                var v206 = OverwireAmount; v206.Clean = value; OverwireAmount = v206;
                var v207 = PaymentScheduleCalcRequiredIndicator; v207.Clean = value; PaymentScheduleCalcRequiredIndicator = v207;
                var v208 = PercentageOfOwnership; v208.Clean = value; PercentageOfOwnership = v208;
                var v209 = PercentageOwnershipInterest; v209.Clean = value; PercentageOwnershipInterest = v209;
                var v210 = PmiIndicator; v210.Clean = value; PmiIndicator = v210;
                var v211 = PostClosingConditionLogs; v211.Clean = value; PostClosingConditionLogs = v211;
                var v212 = PreliminaryConditionLogs; v212.Clean = value; PreliminaryConditionLogs = v212;
                var v213 = PrincipalAndInterestMonthlyPaymentAmount; v213.Clean = value; PrincipalAndInterestMonthlyPaymentAmount = v213;
                var v214 = Print2003Application; v214.Clean = value; Print2003Application = v214;
                var v215 = PrintLogs; v215.Clean = value; PrintLogs = v215;
                var v216 = PropertyAppraisedValueAmount; v216.Clean = value; PropertyAppraisedValueAmount = v216;
                var v217 = PropertyEnergyEfficientHomeIndicator; v217.Clean = value; PropertyEnergyEfficientHomeIndicator = v217;
                var v218 = PropertyEstimatedValueAmount; v218.Clean = value; PropertyEstimatedValueAmount = v218;
                var v219 = ProposedDuesAmount; v219.Clean = value; ProposedDuesAmount = v219;
                var v220 = ProposedFirstMortgageAmount; v220.Clean = value; ProposedFirstMortgageAmount = v220;
                var v221 = ProposedGroundRentAmount; v221.Clean = value; ProposedGroundRentAmount = v221;
                var v222 = ProposedHazardInsuranceAmount; v222.Clean = value; ProposedHazardInsuranceAmount = v222;
                var v223 = ProposedHousingExpenseTotal; v223.Clean = value; ProposedHousingExpenseTotal = v223;
                var v224 = ProposedMortgageInsuranceAmount; v224.Clean = value; ProposedMortgageInsuranceAmount = v224;
                var v225 = ProposedOtherAmount; v225.Clean = value; ProposedOtherAmount = v225;
                var v226 = ProposedOtherMortgagesAmount; v226.Clean = value; ProposedOtherMortgagesAmount = v226;
                var v227 = ProposedRealEstateTaxesAmount; v227.Clean = value; ProposedRealEstateTaxesAmount = v227;
                var v228 = PurchaseCredits; v228.Clean = value; PurchaseCredits = v228;
                var v229 = PurchasePriceAmount; v229.Clean = value; PurchasePriceAmount = v229;
                var v230 = ReferralAddress; v230.Clean = value; ReferralAddress = v230;
                var v231 = ReferralCity; v231.Clean = value; ReferralCity = v231;
                var v232 = ReferralFeeAmount; v232.Clean = value; ReferralFeeAmount = v232;
                var v233 = ReferralPostalCode; v233.Clean = value; ReferralPostalCode = v233;
                var v234 = ReferralSource; v234.Clean = value; ReferralSource = v234;
                var v235 = ReferralState; v235.Clean = value; ReferralState = v235;
                var v236 = RefinanceIncludingDebtsToBePaidOffAmount; v236.Clean = value; RefinanceIncludingDebtsToBePaidOffAmount = v236;
                var v237 = RegistrationLogs; v237.Clean = value; RegistrationLogs = v237;
                var v238 = RemovedLogRecords; v238.Clean = value; RemovedLogRecords = v238;
                var v239 = RepurchaseCostAmount; v239.Clean = value; RepurchaseCostAmount = v239;
                var v240 = RepurchaseDate; v240.Clean = value; RepurchaseDate = v240;
                var v241 = RequestedInterestRatePercent; v241.Clean = value; RequestedInterestRatePercent = v241;
                var v242 = SalesConcessionAmount; v242.Clean = value; SalesConcessionAmount = v242;
                var v243 = SecondSubordinateAmount; v243.Clean = value; SecondSubordinateAmount = v243;
                var v244 = SectionOfActType; v244.Clean = value; SectionOfActType = v244;
                var v245 = SellerPaidClosingCostsAmount; v245.Clean = value; SellerPaidClosingCostsAmount = v245;
                var v246 = ServiceProviderAdditionalInfo; v246.Clean = value; ServiceProviderAdditionalInfo = v246;
                var v247 = ServiceProviderContacts; v247.Clean = value; ServiceProviderContacts = v247;
                var v248 = ServiceProviderDateIssued; v248.Clean = value; ServiceProviderDateIssued = v248;
                var v249 = SetForSettlementServicesOfAnAttorney; v249.Clean = value; SetForSettlementServicesOfAnAttorney = v249;
                var v250 = SetForTheSettlementServicesListed; v250.Clean = value; SetForTheSettlementServicesListed = v250;
                var v251 = SettlementServiceCharges; v251.Clean = value; SettlementServiceCharges = v251;
                var v252 = SimpleRefinanceType; v252.Clean = value; SimpleRefinanceType = v252;
                var v253 = StartingAdjPrice; v253.Clean = value; StartingAdjPrice = v253;
                var v254 = StartingAdjRate; v254.Clean = value; StartingAdjRate = v254;
                var v255 = StatusOnlineLogs; v255.Clean = value; StatusOnlineLogs = v255;
                var v256 = SubjectPropertyGrossRentalIncomeAmount; v256.Clean = value; SubjectPropertyGrossRentalIncomeAmount = v256;
                var v257 = SubjectPropertyOccupancyPercent; v257.Clean = value; SubjectPropertyOccupancyPercent = v257;
                var v258 = SubordinateLienAmount; v258.Clean = value; SubordinateLienAmount = v258;
                var v259 = SystemIdGuid; v259.Clean = value; SystemIdGuid = v259;
                var v260 = TilApplicationDate; v260.Clean = value; TilApplicationDate = v260;
                var v261 = TitleHolderName1; v261.Clean = value; TitleHolderName1 = v261;
                var v262 = TitleHolderName2; v262.Clean = value; TitleHolderName2 = v262;
                var v263 = Tltv; v263.Clean = value; Tltv = v263;
                var v264 = TotalClosingCostsAmount; v264.Clean = value; TotalClosingCostsAmount = v264;
                var v265 = TotalDeductionsAmount; v265.Clean = value; TotalDeductionsAmount = v265;
                var v266 = TotalFeesCostAmount; v266.Clean = value; TotalFeesCostAmount = v266;
                var v267 = TotalFeesCreditAmount; v267.Clean = value; TotalFeesCreditAmount = v267;
                var v268 = TotalNonborrowerPaidClosingCostsAmount; v268.Clean = value; TotalNonborrowerPaidClosingCostsAmount = v268;
                var v269 = TotalPaidOutsideClosingAmount; v269.Clean = value; TotalPaidOutsideClosingAmount = v269;
                var v270 = TotalPaidToBrokerAmount; v270.Clean = value; TotalPaidToBrokerAmount = v270;
                var v271 = TotalWireTransferAmount; v271.Clean = value; TotalWireTransferAmount = v271;
                var v272 = TwelveMonthMortgageRentalHistoryIndicator; v272.Clean = value; TwelveMonthMortgageRentalHistoryIndicator = v272;
                var v273 = UnderwritingConditionLogs; v273.Clean = value; UnderwritingConditionLogs = v273;
                var v274 = UnderwritingEscrowIndicator; v274.Clean = value; UnderwritingEscrowIndicator = v274;
                var v275 = UndiscountedRate; v275.Clean = value; UndiscountedRate = v275;
                var v276 = UnimprovedAppraisedValue; v276.Clean = value; UnimprovedAppraisedValue = v276;
                var v277 = UnimprovedEstimatedValue; v277.Clean = value; UnimprovedEstimatedValue = v277;
                var v278 = UrlPage4Comments; v278.Clean = value; UrlPage4Comments = v278;
                var v279 = UsdaGovernmentLoanType; v279.Clean = value; UsdaGovernmentLoanType = v279;
                var v280 = Use2018DiIndicator; v280.Clean = value; Use2018DiIndicator = v280;
                var v281 = UseNew2015FormsIndicator; v281.Clean = value; UseNew2015FormsIndicator = v281;
                var v282 = UseNewHudIndicator; v282.Clean = value; UseNewHudIndicator = v282;
                var v283 = VAEntitlementAmount; v283.Clean = value; VAEntitlementAmount = v283;
                var v284 = VerificationLogs; v284.Clean = value; VerificationLogs = v284;
                var v285 = VirtualFields; v285.Clean = value; VirtualFields = v285;
                var v286 = WebsiteId; v286.Clean = value; WebsiteId = v286;
                if (AdditionalRequests != null) AdditionalRequests.Clean = value;
                if (ATRQMCommon != null) ATRQMCommon.Clean = value;
                if (ClosingCost != null) ClosingCost.Clean = value;
                if (ClosingDocument != null) ClosingDocument.Clean = value;
                if (CommitmentTerms != null) CommitmentTerms.Clean = value;
                if (ConstructionManagement != null) ConstructionManagement.Clean = value;
                if (Correspondent != null) Correspondent.Clean = value;
                if (CurrentApplication != null) CurrentApplication.Clean = value;
                if (CustomModelFields != null) CustomModelFields.Clean = value;
                if (DisclosureNotices != null) DisclosureNotices.Clean = value;
                if (DownPayment != null) DownPayment.Clean = value;
                if (EmDocument != null) EmDocument.Clean = value;
                if (EmDocumentInvestor != null) EmDocumentInvestor.Clean = value;
                if (EmDocumentLender != null) EmDocumentLender.Clean = value;
                if (FannieMae != null) FannieMae.Clean = value;
                if (FhaVaLoan != null) FhaVaLoan.Clean = value;
                if (FreddieMac != null) FreddieMac.Clean = value;
                if (Funding != null) Funding.Clean = value;
                if (Gfe != null) Gfe.Clean = value;
                if (Hmda != null) Hmda.Clean = value;
                if (Hud1Es != null) Hud1Es.Clean = value;
                if (HudLoanData != null) HudLoanData.Clean = value;
                if (InterimServicing != null) InterimServicing.Clean = value;
                if (LoanProductData != null) LoanProductData.Clean = value;
                if (LoanSubmission != null) LoanSubmission.Clean = value;
                if (LOCompensation != null) LOCompensation.Clean = value;
                if (Mcaw != null) Mcaw.Clean = value;
                if (Miscellaneous != null) Miscellaneous.Clean = value;
                if (NetTangibleBenefit != null) NetTangibleBenefit.Clean = value;
                if (Prequalification != null) Prequalification.Clean = value;
                if (PrivacyPolicy != null) PrivacyPolicy.Clean = value;
                if (ProfitManagement != null) ProfitManagement.Clean = value;
                if (Property != null) Property.Clean = value;
                if (RateLock != null) RateLock.Clean = value;
                if (RegulationZ != null) RegulationZ.Clean = value;
                if (Section32 != null) Section32.Clean = value;
                if (SelectedHomeCounselingProvider != null) SelectedHomeCounselingProvider.Clean = value;
                if (ServicingDisclosure != null) ServicingDisclosure.Clean = value;
                if (Shipping != null) Shipping.Clean = value;
                if (StateDisclosure != null) StateDisclosure.Clean = value;
                if (StatementCreditDenial != null) StatementCreditDenial.Clean = value;
                if (TPO != null) TPO.Clean = value;
                if (TQL != null) TQL.Clean = value;
                if (TrustAccount != null) TrustAccount.Clean = value;
                if (Tsum != null) Tsum.Clean = value;
                if (Uldd != null) Uldd.Clean = value;
                if (UnderwriterSummary != null) UnderwriterSummary.Clean = value;
                if (Usda != null) Usda.Clean = value;
                if (VaLoanData != null) VaLoanData.Clean = value;
                _settingClean = 0;
            }
        }
    }
}