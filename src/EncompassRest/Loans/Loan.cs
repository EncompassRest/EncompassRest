#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Loan : ExtensibleObject, IIdentifiable
    {
        private AdditionalRequests _additionalRequests;
        public AdditionalRequests AdditionalRequests { get => _additionalRequests ?? (_additionalRequests = new AdditionalRequests()); set => _additionalRequests = value; }
        private DirtyValue<DateTime?> _adverseActionDate;
        public DateTime? AdverseActionDate { get => _adverseActionDate; set => _adverseActionDate = value; }
        private DirtyList<AffiliatedBusinessArrangement> _affiliatedBusinessArrangements;
        public IList<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get => _affiliatedBusinessArrangements ?? (_affiliatedBusinessArrangements = new DirtyList<AffiliatedBusinessArrangement>()); set => _affiliatedBusinessArrangements = new DirtyList<AffiliatedBusinessArrangement>(value); }
        private DirtyValue<string> _agencyCaseIdentifier;
        public string AgencyCaseIdentifier { get => _agencyCaseIdentifier; set => _agencyCaseIdentifier = value; }
        private DirtyValue<decimal?> _alterationsImprovementsOrRepairsAmount;
        public decimal? AlterationsImprovementsOrRepairsAmount { get => _alterationsImprovementsOrRepairsAmount; set => _alterationsImprovementsOrRepairsAmount = value; }
        private DirtyList<Application> _applications;
        public IList<Application> Applications { get => _applications ?? (_applications = new DirtyList<Application>()); set => _applications = new DirtyList<Application>(value); }
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>> _applicationTakenMethodType;
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => _applicationTakenMethodType = value; }
        private DirtyValue<DateTime?> _aprDisclosureDate;
        public DateTime? AprDisclosureDate { get => _aprDisclosureDate; set => _aprDisclosureDate = value; }
        private DirtyValue<string> _armTypeDescription;
        public string ArmTypeDescription { get => _armTypeDescription; set => _armTypeDescription = value; }
        private ATRQMCommon _aTRQMCommon;
        public ATRQMCommon ATRQMCommon { get => _aTRQMCommon ?? (_aTRQMCommon = new ATRQMCommon()); set => _aTRQMCommon = value; }
        private DirtyValue<decimal?> _baseLoanAmount;
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => _baseLoanAmount = value; }
        private DirtyValue<bool?> _belowMarketSubordinateFinancingIndicator;
        public bool? BelowMarketSubordinateFinancingIndicator { get => _belowMarketSubordinateFinancingIndicator; set => _belowMarketSubordinateFinancingIndicator = value; }
        private DirtyValue<string> _billingCategory;
        public string BillingCategory { get => _billingCategory; set => _billingCategory = value; }
        private DirtyValue<decimal?> _biweeklyPaymentAmount;
        public decimal? BiweeklyPaymentAmount { get => _biweeklyPaymentAmount; set => _biweeklyPaymentAmount = value; }
        private DirtyValue<int?> _bLTV;
        public int? BLTV { get => _bLTV; set => _bLTV = value; }
        private DirtyValue<bool?> _borrowerCoBorrowerMarriedIndicator;
        public bool? BorrowerCoBorrowerMarriedIndicator { get => _borrowerCoBorrowerMarriedIndicator; set => _borrowerCoBorrowerMarriedIndicator = value; }
        private DirtyValue<decimal?> _borrowerPaidClosingCostsAmount;
        public decimal? BorrowerPaidClosingCostsAmount { get => _borrowerPaidClosingCostsAmount; set => _borrowerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsAmount;
        public decimal? BorrowerPaidDiscountPointsAmount { get => _borrowerPaidDiscountPointsAmount; set => _borrowerPaidDiscountPointsAmount = value; }
        private DirtyValue<decimal?> _borrowerPaidFHAVAClosingCostsAmount;
        public decimal? BorrowerPaidFHAVAClosingCostsAmount { get => _borrowerPaidFHAVAClosingCostsAmount; set => _borrowerPaidFHAVAClosingCostsAmount = value; }
        private DirtyValue<int?> _borrowerPairCount;
        public int? BorrowerPairCount { get => _borrowerPairCount; set => _borrowerPairCount = value; }
        private DirtyValue<decimal?> _borrowerRequestedLoanAmount;
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => _borrowerRequestedLoanAmount = value; }
        private DirtyValue<decimal?> _brokerPaidClosingCostsAmount;
        public decimal? BrokerPaidClosingCostsAmount { get => _brokerPaidClosingCostsAmount; set => _brokerPaidClosingCostsAmount = value; }
        private DirtyValue<bool?> _buydownIndicator;
        public bool? BuydownIndicator { get => _buydownIndicator; set => _buydownIndicator = value; }
        private DirtyValue<decimal?> _buydownMonthlyPaymentAmount;
        public decimal? BuydownMonthlyPaymentAmount { get => _buydownMonthlyPaymentAmount; set => _buydownMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => _buydownRatePercent = value; }
        private DirtyValue<decimal?> _cashFromToBorrowerAmount;
        public decimal? CashFromToBorrowerAmount { get => _cashFromToBorrowerAmount; set => _cashFromToBorrowerAmount = value; }
        private DirtyValue<StringEnumValue<Channel>> _channel;
        public StringEnumValue<Channel> Channel { get => _channel; set => _channel = value; }
        private DirtyValue<DateTime?> _closingBillingDate;
        public DateTime? ClosingBillingDate { get => _closingBillingDate; set => _closingBillingDate = value; }
        private ClosingCost _closingCost;
        public ClosingCost ClosingCost { get => _closingCost ?? (_closingCost = new ClosingCost()); set => _closingCost = value; }
        private DirtyValue<string> _closingCostProgram;
        public string ClosingCostProgram { get => _closingCostProgram; set => _closingCostProgram = value; }
        private DirtyValue<decimal?> _closingCostsAndPrepaidsFromOtherLienAmount;
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get => _closingCostsAndPrepaidsFromOtherLienAmount; set => _closingCostsAndPrepaidsFromOtherLienAmount = value; }
        private DirtyValue<decimal?> _closingCostsPaidByOthersAmount;
        public decimal? ClosingCostsPaidByOthersAmount { get => _closingCostsPaidByOthersAmount; set => _closingCostsPaidByOthersAmount = value; }
        private DirtyValue<string> _closingDocsStackingOrder;
        public string ClosingDocsStackingOrder { get => _closingDocsStackingOrder; set => _closingDocsStackingOrder = value; }
        private ClosingDocument _closingDocument;
        public ClosingDocument ClosingDocument { get => _closingDocument ?? (_closingDocument = new ClosingDocument()); set => _closingDocument = value; }
        private DirtyValue<int?> _collateralManagerScore;
        public int? CollateralManagerScore { get => _collateralManagerScore; set => _collateralManagerScore = value; }
        private DirtyValue<decimal?> _combinedLtv;
        public decimal? CombinedLtv { get => _combinedLtv; set => _combinedLtv = value; }
        private DirtyValue<string> _commitmentNumber;
        public string CommitmentNumber { get => _commitmentNumber; set => _commitmentNumber = value; }
        private CommitmentTerms _commitmentTerms;
        public CommitmentTerms CommitmentTerms { get => _commitmentTerms ?? (_commitmentTerms = new CommitmentTerms()); set => _commitmentTerms = value; }
        private DirtyList<ComplianceTestLog> _complianceTestLogs;
        public IList<ComplianceTestLog> ComplianceTestLogs { get => _complianceTestLogs ?? (_complianceTestLogs = new DirtyList<ComplianceTestLog>()); set => _complianceTestLogs = new DirtyList<ComplianceTestLog>(value); }
        private DirtyValue<StringEnumValue<ConformingJumbo>> _conformingJumbo;
        public StringEnumValue<ConformingJumbo> ConformingJumbo { get => _conformingJumbo; set => _conformingJumbo = value; }
        private ConstructionManagement _constructionManagement;
        public ConstructionManagement ConstructionManagement { get => _constructionManagement ?? (_constructionManagement = new ConstructionManagement()); set => _constructionManagement = value; }
        private DirtyValue<string> _consumerConnectSiteID;
        public string ConsumerConnectSiteID { get => _consumerConnectSiteID; set => _consumerConnectSiteID = value; }
        private DirtyList<Contact> _contacts;
        public IList<Contact> Contacts { get => _contacts ?? (_contacts = new DirtyList<Contact>()); set => _contacts = new DirtyList<Contact>(value); }
        private DirtyValue<bool?> _contactUpdatedIndicator;
        public bool? ContactUpdatedIndicator { get => _contactUpdatedIndicator; set => _contactUpdatedIndicator = value; }
        private DirtyValue<decimal?> _contractSellerCreditAmount;
        public decimal? ContractSellerCreditAmount { get => _contractSellerCreditAmount; set => _contractSellerCreditAmount = value; }
        private DirtyList<ConversationLog> _conversationLogs;
        public IList<ConversationLog> ConversationLogs { get => _conversationLogs ?? (_conversationLogs = new DirtyList<ConversationLog>()); set => _conversationLogs = new DirtyList<ConversationLog>(value); }
        private DirtyValue<bool?> _copyBrokerToLenderIndicator;
        public bool? CopyBrokerToLenderIndicator { get => _copyBrokerToLenderIndicator; set => _copyBrokerToLenderIndicator = value; }
        private DirtyValue<StringEnumValue<YOrN>> _copyLoanNumLenderCaseNum;
        public StringEnumValue<YOrN> CopyLoanNumLenderCaseNum { get => _copyLoanNumLenderCaseNum; set => _copyLoanNumLenderCaseNum = value; }
        private Correspondent _correspondent;
        public Correspondent Correspondent { get => _correspondent ?? (_correspondent = new Correspondent()); set => _correspondent = value; }
        private DirtyValue<string> _creditScoreToUse;
        public string CreditScoreToUse { get => _creditScoreToUse; set => _creditScoreToUse = value; }
        private DirtyList<CrmLog> _crmLogs;
        public IList<CrmLog> CrmLogs { get => _crmLogs ?? (_crmLogs = new DirtyList<CrmLog>()); set => _crmLogs = new DirtyList<CrmLog>(value); }
        private Application _currentApplication;
        public Application CurrentApplication { get => _currentApplication ?? (_currentApplication = new Application()); set => _currentApplication = value; }
        private DirtyValue<int?> _currentApplicationIndex;
        public int? CurrentApplicationIndex { get => _currentApplicationIndex; set => _currentApplicationIndex = value; }
        private DirtyValue<bool?> _currentApplicationIsPrimary;
        public bool? CurrentApplicationIsPrimary { get => _currentApplicationIsPrimary; set => _currentApplicationIsPrimary = value; }
        private DirtyValue<StringEnumValue<CurrentFirstMortgageHolderType>> _currentFirstMortgageHolderType;
        public StringEnumValue<CurrentFirstMortgageHolderType> CurrentFirstMortgageHolderType { get => _currentFirstMortgageHolderType; set => _currentFirstMortgageHolderType = value; }
        private DirtyList<CustomField> _customFields;
        public IList<CustomField> CustomFields { get => _customFields ?? (_customFields = new DirtyList<CustomField>()); set => _customFields = new DirtyList<CustomField>(value); }
        private CustomModelFields _customModelFields;
        public CustomModelFields CustomModelFields { get => _customModelFields ?? (_customModelFields = new CustomModelFields()); set => _customModelFields = value; }
        private DirtyList<DataTracLog> _dataTracLogs;
        public IList<DataTracLog> DataTracLogs { get => _dataTracLogs ?? (_dataTracLogs = new DirtyList<DataTracLog>()); set => _dataTracLogs = new DirtyList<DataTracLog>(value); }
        private DirtyValue<bool?> _dBIndicator;
        public bool? DBIndicator { get => _dBIndicator; set => _dBIndicator = value; }
        private DirtyValue<bool?> _deductOverwireAmountIndicator;
        public bool? DeductOverwireAmountIndicator { get => _deductOverwireAmountIndicator; set => _deductOverwireAmountIndicator = value; }
        private DirtyValue<bool?> _disableESignConsentAlert;
        public bool? DisableESignConsentAlert { get => _disableESignConsentAlert; set => _disableESignConsentAlert = value; }
        private DirtyValue<bool?> _disableKeyPricingAlert;
        public bool? DisableKeyPricingAlert { get => _disableKeyPricingAlert; set => _disableKeyPricingAlert = value; }
        private DisclosureNotices _disclosureNotices;
        public DisclosureNotices DisclosureNotices { get => _disclosureNotices ?? (_disclosureNotices = new DisclosureNotices()); set => _disclosureNotices = value; }
        private DirtyList<DisclosureTracking2015Log> _disclosureTracking2015Logs;
        public IList<DisclosureTracking2015Log> DisclosureTracking2015Logs { get => _disclosureTracking2015Logs ?? (_disclosureTracking2015Logs = new DirtyList<DisclosureTracking2015Log>()); set => _disclosureTracking2015Logs = new DirtyList<DisclosureTracking2015Log>(value); }
        private DirtyList<DisclosureTrackingLog> _disclosureTrackingLogs;
        public IList<DisclosureTrackingLog> DisclosureTrackingLogs { get => _disclosureTrackingLogs ?? (_disclosureTrackingLogs = new DirtyList<DisclosureTrackingLog>()); set => _disclosureTrackingLogs = new DirtyList<DisclosureTrackingLog>(value); }
        private DirtyValue<decimal?> _discountPoint;
        public decimal? DiscountPoint { get => _discountPoint; set => _discountPoint = value; }
        private DirtyValue<StringEnumValue<DocEngine>> _docEngine;
        public StringEnumValue<DocEngine> DocEngine { get => _docEngine; set => _docEngine = value; }
        private DirtyList<DocumentLog> _documentLogs;
        public IList<DocumentLog> DocumentLogs { get => _documentLogs ?? (_documentLogs = new DirtyList<DocumentLog>()); set => _documentLogs = new DirtyList<DocumentLog>(value); }
        private DirtyList<DocumentOrderLog> _documentOrderLogs;
        public IList<DocumentOrderLog> DocumentOrderLogs { get => _documentOrderLogs ?? (_documentOrderLogs = new DirtyList<DocumentOrderLog>()); set => _documentOrderLogs = new DirtyList<DocumentOrderLog>(value); }
        private DirtyValue<string> _doNotCheckEmail;
        public string DoNotCheckEmail { get => _doNotCheckEmail; set => _doNotCheckEmail = value; }
        private DirtyValue<bool?> _doNotPrintCompensationFees;
        public bool? DoNotPrintCompensationFees { get => _doNotPrintCompensationFees; set => _doNotPrintCompensationFees = value; }
        private DirtyList<DownloadLog> _downloadLogs;
        public IList<DownloadLog> DownloadLogs { get => _downloadLogs ?? (_downloadLogs = new DirtyList<DownloadLog>()); set => _downloadLogs = new DirtyList<DownloadLog>(value); }
        private DownPayment _downPayment;
        public DownPayment DownPayment { get => _downPayment ?? (_downPayment = new DownPayment()); set => _downPayment = value; }
        private DirtyValue<decimal?> _downPaymentPercent;
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => _downPaymentPercent = value; }
        private DirtyValue<int?> _eDeliveryVersion;
        public int? EDeliveryVersion { get => _eDeliveryVersion; set => _eDeliveryVersion = value; }
        private DirtyList<EdmLog> _edmLogs;
        public IList<EdmLog> EdmLogs { get => _edmLogs ?? (_edmLogs = new DirtyList<EdmLog>()); set => _edmLogs = new DirtyList<EdmLog>(value); }
        private DirtyList<EmailTriggerLog> _emailTriggerLogs;
        public IList<EmailTriggerLog> EmailTriggerLogs { get => _emailTriggerLogs ?? (_emailTriggerLogs = new DirtyList<EmailTriggerLog>()); set => _emailTriggerLogs = new DirtyList<EmailTriggerLog>(value); }
        private EmDocument _emDocument;
        public EmDocument EmDocument { get => _emDocument ?? (_emDocument = new EmDocument()); set => _emDocument = value; }
        private EmDocumentInvestor _emDocumentInvestor;
        public EmDocumentInvestor EmDocumentInvestor { get => _emDocumentInvestor ?? (_emDocumentInvestor = new EmDocumentInvestor()); set => _emDocumentInvestor = value; }
        private EmDocumentLender _emDocumentLender;
        public EmDocumentLender EmDocumentLender { get => _emDocumentLender ?? (_emDocumentLender = new EmDocumentLender()); set => _emDocumentLender = value; }
        private DirtyValue<string> _emXmlVersionId;
        public string EmXmlVersionId { get => _emXmlVersionId; set => _emXmlVersionId = value; }
        private DirtyValue<string> _encompassId;
        public string EncompassId { get => _encompassId; set => _encompassId = value; }
        private DirtyValue<string> _encompassVersion;
        public string EncompassVersion { get => _encompassVersion; set => _encompassVersion = value; }
        private DirtyValue<bool?> _enforceCountyLoanLimit;
        public bool? EnforceCountyLoanLimit { get => _enforceCountyLoanLimit; set => _enforceCountyLoanLimit = value; }
        private DirtyValue<decimal?> _estimatedClosingCostsAmount;
        public decimal? EstimatedClosingCostsAmount { get => _estimatedClosingCostsAmount; set => _estimatedClosingCostsAmount = value; }
        private DirtyValue<decimal?> _estimatedConstructionInterest;
        public decimal? EstimatedConstructionInterest { get => _estimatedConstructionInterest; set => _estimatedConstructionInterest = value; }
        private DirtyValue<decimal?> _estimatedPrepaidItemsAmount;
        public decimal? EstimatedPrepaidItemsAmount { get => _estimatedPrepaidItemsAmount; set => _estimatedPrepaidItemsAmount = value; }
        private DirtyValue<StringEnumValue<ExportLoanNumber>> _exportLoanNumber;
        public StringEnumValue<ExportLoanNumber> ExportLoanNumber { get => _exportLoanNumber; set => _exportLoanNumber = value; }
        private FannieMae _fannieMae;
        public FannieMae FannieMae { get => _fannieMae ?? (_fannieMae = new FannieMae()); set => _fannieMae = value; }
        private DirtyList<Fee> _fees;
        public IList<Fee> Fees { get => _fees ?? (_fees = new DirtyList<Fee>()); set => _fees = new DirtyList<Fee>(value); }
        private DirtyValue<decimal?> _fhaMiPremiumRefundAmount;
        public decimal? FhaMiPremiumRefundAmount { get => _fhaMiPremiumRefundAmount; set => _fhaMiPremiumRefundAmount = value; }
        private FhaVaLoan _fhaVaLoan;
        public FhaVaLoan FhaVaLoan { get => _fhaVaLoan ?? (_fhaVaLoan = new FhaVaLoan()); set => _fhaVaLoan = value; }
        private DirtyValue<string> _fHAVALoanOriginatorIdentifier;
        public string FHAVALoanOriginatorIdentifier { get => _fHAVALoanOriginatorIdentifier; set => _fHAVALoanOriginatorIdentifier = value; }
        private DirtyList<FieldLockData> _fieldLockData;
        public IList<FieldLockData> FieldLockData { get => _fieldLockData ?? (_fieldLockData = new DirtyList<FieldLockData>()); set => _fieldLockData = new DirtyList<FieldLockData>(value); }
        private DirtyValue<decimal?> _firstAdjustmentMinimum;
        public decimal? FirstAdjustmentMinimum { get => _firstAdjustmentMinimum; set => _firstAdjustmentMinimum = value; }
        private DirtyValue<decimal?> _firstSubordinateLienAmount;
        public decimal? FirstSubordinateLienAmount { get => _firstSubordinateLienAmount; set => _firstSubordinateLienAmount = value; }
        private DirtyValue<bool?> _firstTimeHomebuyersIndicator;
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => _firstTimeHomebuyersIndicator = value; }
        private DirtyValue<StringEnumValue<FnmCommunityLendingProductName>> _fnmCommunityLendingProductName;
        public StringEnumValue<FnmCommunityLendingProductName> FnmCommunityLendingProductName { get => _fnmCommunityLendingProductName; set => _fnmCommunityLendingProductName = value; }
        private DirtyValue<bool?> _fnmCommunitySecondsIndicator;
        public bool? FnmCommunitySecondsIndicator { get => _fnmCommunitySecondsIndicator; set => _fnmCommunitySecondsIndicator = value; }
        private DirtyValue<bool?> _fnmNeighborsMortgageEligibilityIndicator;
        public bool? FnmNeighborsMortgageEligibilityIndicator { get => _fnmNeighborsMortgageEligibilityIndicator; set => _fnmNeighborsMortgageEligibilityIndicator = value; }
        private DirtyList<Form> _forms;
        public IList<Form> Forms { get => _forms ?? (_forms = new DirtyList<Form>()); set => _forms = new DirtyList<Form>(value); }
        private DirtyValue<int?> _fraudScore;
        public int? FraudScore { get => _fraudScore; set => _fraudScore = value; }
        private FreddieMac _freddieMac;
        public FreddieMac FreddieMac { get => _freddieMac ?? (_freddieMac = new FreddieMac()); set => _freddieMac = value; }
        private Funding _funding;
        public Funding Funding { get => _funding ?? (_funding = new Funding()); set => _funding = value; }
        private DirtyValue<string> _fundingDeductionList;
        public string FundingDeductionList { get => _fundingDeductionList; set => _fundingDeductionList = value; }
        private DirtyValue<string> _fundingFeeList;
        public string FundingFeeList { get => _fundingFeeList; set => _fundingFeeList = value; }
        private DirtyList<FundingFee> _fundingFees;
        public IList<FundingFee> FundingFees { get => _fundingFees ?? (_fundingFees = new DirtyList<FundingFee>()); set => _fundingFees = new DirtyList<FundingFee>(value); }
        private Gfe _gfe;
        public Gfe Gfe { get => _gfe ?? (_gfe = new Gfe()); set => _gfe = value; }
        private DirtyValue<string> _governmentLoanLenderIdentifier;
        public string GovernmentLoanLenderIdentifier { get => _governmentLoanLenderIdentifier; set => _governmentLoanLenderIdentifier = value; }
        private DirtyValue<string> _governmentLoanSponsorIdentifier;
        public string GovernmentLoanSponsorIdentifier { get => _governmentLoanSponsorIdentifier; set => _governmentLoanSponsorIdentifier = value; }
        private DirtyValue<decimal?> _governmentMortgageCreditCertificateAmount;
        public decimal? GovernmentMortgageCreditCertificateAmount { get => _governmentMortgageCreditCertificateAmount; set => _governmentMortgageCreditCertificateAmount = value; }
        private DirtyValue<string> _hasAbusinessRelationshipWith;
        public string HasAbusinessRelationshipWith { get => _hasAbusinessRelationshipWith; set => _hasAbusinessRelationshipWith = value; }
        private DirtyValue<decimal?> _hcltvHtltv;
        public decimal? HcltvHtltv { get => _hcltvHtltv; set => _hcltvHtltv = value; }
        private DirtyValue<decimal?> _helocTeaserRate;
        public decimal? HelocTeaserRate { get => _helocTeaserRate; set => _helocTeaserRate = value; }
        private Hmda _hmda;
        public Hmda Hmda { get => _hmda ?? (_hmda = new Hmda()); set => _hmda = value; }
        private DirtyList<HomeCounselingProvider> _homeCounselingProviders;
        public IList<HomeCounselingProvider> HomeCounselingProviders { get => _homeCounselingProviders ?? (_homeCounselingProviders = new DirtyList<HomeCounselingProvider>()); set => _homeCounselingProviders = new DirtyList<HomeCounselingProvider>(value); }
        private DirtyValue<string> _homeCounselingProvidersDistance;
        public string HomeCounselingProvidersDistance { get => _homeCounselingProvidersDistance; set => _homeCounselingProvidersDistance = value; }
        private DirtyValue<string> _homeCounselingProvidersLanguageNames;
        public string HomeCounselingProvidersLanguageNames { get => _homeCounselingProvidersLanguageNames; set => _homeCounselingProvidersLanguageNames = value; }
        private DirtyValue<string> _homeCounselingProvidersServiceNames;
        public string HomeCounselingProvidersServiceNames { get => _homeCounselingProvidersServiceNames; set => _homeCounselingProvidersServiceNames = value; }
        private DirtyValue<int?> _householdSizeCount;
        public int? HouseholdSizeCount { get => _householdSizeCount; set => _householdSizeCount = value; }
        private DirtyList<HtmlEmailLog> _htmlEmailLogs;
        public IList<HtmlEmailLog> HtmlEmailLogs { get => _htmlEmailLogs ?? (_htmlEmailLogs = new DirtyList<HtmlEmailLog>()); set => _htmlEmailLogs = new DirtyList<HtmlEmailLog>(value); }
        private Hud1Es _hud1Es;
        public Hud1Es Hud1Es { get => _hud1Es ?? (_hud1Es = new Hud1Es()); set => _hud1Es = value; }
        private DirtyValue<decimal?> _hudIncomeLimitAdjustmentFactor;
        public decimal? HudIncomeLimitAdjustmentFactor { get => _hudIncomeLimitAdjustmentFactor; set => _hudIncomeLimitAdjustmentFactor = value; }
        private DirtyValue<decimal?> _hudLendingIncomeLimitAmount;
        public decimal? HudLendingIncomeLimitAmount { get => _hudLendingIncomeLimitAmount; set => _hudLendingIncomeLimitAmount = value; }
        private HudLoanData _hudLoanData;
        public HudLoanData HudLoanData { get => _hudLoanData ?? (_hudLoanData = new HudLoanData()); set => _hudLoanData = value; }
        private DirtyValue<decimal?> _hudMedianIncomeAmount;
        public decimal? HudMedianIncomeAmount { get => _hudMedianIncomeAmount; set => _hudMedianIncomeAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _includeUSDAFeeInClosing;
        public bool? IncludeUSDAFeeInClosing { get => _includeUSDAFeeInClosing; set => _includeUSDAFeeInClosing = value; }
        private DirtyValue<decimal?> _initialInterestRate;
        public decimal? InitialInterestRate { get => _initialInterestRate; set => _initialInterestRate = value; }
        private DirtyValue<string> _initialInterestRateUI;
        public string InitialInterestRateUI { get => _initialInterestRateUI; set => _initialInterestRateUI = value; }
        private DirtyValue<string> _insuranceAuthorizationIndicator;
        public string InsuranceAuthorizationIndicator { get => _insuranceAuthorizationIndicator; set => _insuranceAuthorizationIndicator = value; }
        private InterimServicing _interimServicing;
        public InterimServicing InterimServicing { get => _interimServicing ?? (_interimServicing = new InterimServicing()); set => _interimServicing = value; }
        private DirtyValue<DateTime?> _interviewerApplicationSignedDate;
        public DateTime? InterviewerApplicationSignedDate { get => _interviewerApplicationSignedDate; set => _interviewerApplicationSignedDate = value; }
        private DirtyValue<string> _interviewerEmail;
        public string InterviewerEmail { get => _interviewerEmail; set => _interviewerEmail = value; }
        private DirtyValue<string> _interviewerLicenseIdentifier;
        public string InterviewerLicenseIdentifier { get => _interviewerLicenseIdentifier; set => _interviewerLicenseIdentifier = value; }
        private DirtyValue<string> _interviewerPhoneNumber;
        public string InterviewerPhoneNumber { get => _interviewerPhoneNumber; set => _interviewerPhoneNumber = value; }
        private DirtyValue<string> _interviewersCompanyStateLicense;
        public string InterviewersCompanyStateLicense { get => _interviewersCompanyStateLicense; set => _interviewersCompanyStateLicense = value; }
        private DirtyValue<string> _interviewersId;
        public string InterviewersId { get => _interviewersId; set => _interviewersId = value; }
        private DirtyValue<string> _inverviewerName;
        public string InverviewerName { get => _inverviewerName; set => _inverviewerName = value; }
        private DirtyValue<bool?> _isCreditorProhibitsBorrower;
        public bool? IsCreditorProhibitsBorrower { get => _isCreditorProhibitsBorrower; set => _isCreditorProhibitsBorrower = value; }
        private DirtyValue<bool?> _isEmployeeLoan;
        public bool? IsEmployeeLoan { get => _isEmployeeLoan; set => _isEmployeeLoan = value; }
        private DirtyValue<bool?> _isLSSecondaryFile;
        public bool? IsLSSecondaryFile { get => _isLSSecondaryFile; set => _isLSSecondaryFile = value; }
        private DirtyValue<bool?> _isRequiredInterestReserveCompoundInterest;
        public bool? IsRequiredInterestReserveCompoundInterest { get => _isRequiredInterestReserveCompoundInterest; set => _isRequiredInterestReserveCompoundInterest = value; }
        private DirtyValue<decimal?> _landIfAcquiredSeperatelyAmount;
        public decimal? LandIfAcquiredSeperatelyAmount { get => _landIfAcquiredSeperatelyAmount; set => _landIfAcquiredSeperatelyAmount = value; }
        private DirtyValue<string> _leadSource;
        public string LeadSource { get => _leadSource; set => _leadSource = value; }
        private DirtyValue<string> _lenderCaseIdentifier;
        public string LenderCaseIdentifier { get => _lenderCaseIdentifier; set => _lenderCaseIdentifier = value; }
        private DirtyValue<StringEnumValue<LenderChannel>> _lenderChannel;
        public StringEnumValue<LenderChannel> LenderChannel { get => _lenderChannel; set => _lenderChannel = value; }
        private DirtyValue<decimal?> _lenderCreditsInFunding;
        public decimal? LenderCreditsInFunding { get => _lenderCreditsInFunding; set => _lenderCreditsInFunding = value; }
        private DirtyValue<string> _lenderInvestorCode;
        public string LenderInvestorCode { get => _lenderInvestorCode; set => _lenderInvestorCode = value; }
        private DirtyValue<decimal?> _lenderPaidClosignCostsDotAmount;
        public decimal? LenderPaidClosignCostsDotAmount { get => _lenderPaidClosignCostsDotAmount; set => _lenderPaidClosignCostsDotAmount = value; }
        private DirtyValue<decimal?> _lenderPaidClosingCostsAmount;
        public decimal? LenderPaidClosingCostsAmount { get => _lenderPaidClosingCostsAmount; set => _lenderPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _lesserAppraisedValueOrSalesPrice;
        public decimal? LesserAppraisedValueOrSalesPrice { get => _lesserAppraisedValueOrSalesPrice; set => _lesserAppraisedValueOrSalesPrice = value; }
        private DirtyValue<decimal?> _lifeInsuranceCoverageAmount;
        public decimal? LifeInsuranceCoverageAmount { get => _lifeInsuranceCoverageAmount; set => _lifeInsuranceCoverageAmount = value; }
        private DirtyValue<decimal?> _lifeInsuranceEstimatedMonthlyAmount;
        public decimal? LifeInsuranceEstimatedMonthlyAmount { get => _lifeInsuranceEstimatedMonthlyAmount; set => _lifeInsuranceEstimatedMonthlyAmount = value; }
        private DirtyValue<decimal?> _lifeInsuranceTotalProtectedMonthlyAmount;
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get => _lifeInsuranceTotalProtectedMonthlyAmount; set => _lifeInsuranceTotalProtectedMonthlyAmount = value; }
        private DirtyValue<decimal?> _linkedBorrowerRequestedLoanAmount;
        public decimal? LinkedBorrowerRequestedLoanAmount { get => _linkedBorrowerRequestedLoanAmount; set => _linkedBorrowerRequestedLoanAmount = value; }
        private DirtyValue<string> _linkId;
        public string LinkId { get => _linkId; set => _linkId = value; }
        private DirtyList<LoanActionLog> _loanActionLogs;
        public IList<LoanActionLog> LoanActionLogs { get => _loanActionLogs ?? (_loanActionLogs = new DirtyList<LoanActionLog>()); set => _loanActionLogs = new DirtyList<LoanActionLog>(value); }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => _loanAmortizationTermMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanAmortizationType;
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => _loanAmortizationType = value; }
        private DirtyValue<string> _loanCreatedDate;
        public string LoanCreatedDate { get => _loanCreatedDate; set => _loanCreatedDate = value; }
        private DirtyValue<DateTime?> _loanCreatedDateUtc;
        public DateTime? LoanCreatedDateUtc { get => _loanCreatedDateUtc; set => _loanCreatedDateUtc = value; }
        private DirtyValue<string> _loanIdNumber;
        public string LoanIdNumber { get => _loanIdNumber; set => _loanIdNumber = value; }
        private DirtyValue<bool?> _loanImportStatusIndicator;
        public bool? LoanImportStatusIndicator { get => _loanImportStatusIndicator; set => _loanImportStatusIndicator = value; }
        private DirtyValue<StringEnumValue<LoanLinkSyncType>> _loanLinkSyncType;
        public StringEnumValue<LoanLinkSyncType> LoanLinkSyncType { get => _loanLinkSyncType; set => _loanLinkSyncType = value; }
        private DirtyValue<string> _loanNumber;
        public string LoanNumber { get => _loanNumber; set => _loanNumber = value; }
        private LoanProductData _loanProductData;
        public LoanProductData LoanProductData { get => _loanProductData ?? (_loanProductData = new LoanProductData()); set => _loanProductData = value; }
        private DirtyValue<string> _loanProgramName;
        public string LoanProgramName { get => _loanProgramName; set => _loanProgramName = value; }
        private DirtyList<LoanProgram> _loanPrograms;
        public IList<LoanProgram> LoanPrograms { get => _loanPrograms ?? (_loanPrograms = new DirtyList<LoanProgram>()); set => _loanPrograms = new DirtyList<LoanProgram>(value); }
        private DirtyValue<StringEnumValue<LoanPurposeOfRefinanceType>> _loanPurposeOfRefinanceType;
        public StringEnumValue<LoanPurposeOfRefinanceType> LoanPurposeOfRefinanceType { get => _loanPurposeOfRefinanceType; set => _loanPurposeOfRefinanceType = value; }
        private DirtyValue<string> _loanSource;
        public string LoanSource { get => _loanSource; set => _loanSource = value; }
        private LoanSubmission _loanSubmission;
        public LoanSubmission LoanSubmission { get => _loanSubmission ?? (_loanSubmission = new LoanSubmission()); set => _loanSubmission = value; }
        private DirtyValue<decimal?> _loanTotalProposedMonthlyMaintenanceAmount;
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get => _loanTotalProposedMonthlyMaintenanceAmount; set => _loanTotalProposedMonthlyMaintenanceAmount = value; }
        private DirtyValue<decimal?> _loanTotalProposedMonthlyUtilitiesAmount;
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get => _loanTotalProposedMonthlyUtilitiesAmount; set => _loanTotalProposedMonthlyUtilitiesAmount = value; }
        private DirtyValue<string> _loanUnderwriterCHUMSIdentifier;
        public string LoanUnderwriterCHUMSIdentifier { get => _loanUnderwriterCHUMSIdentifier; set => _loanUnderwriterCHUMSIdentifier = value; }
        private DirtyValue<string> _loanVALoanProcedureType;
        public string LoanVALoanProcedureType { get => _loanVALoanProcedureType; set => _loanVALoanProcedureType = value; }
        private DirtyValue<decimal?> _loanVARateReductionInitialComputationTotalAmount;
        public decimal? LoanVARateReductionInitialComputationTotalAmount { get => _loanVARateReductionInitialComputationTotalAmount; set => _loanVARateReductionInitialComputationTotalAmount = value; }
        private DirtyValue<decimal?> _loanVAResidualIncomeAmount;
        public decimal? LoanVAResidualIncomeAmount { get => _loanVAResidualIncomeAmount; set => _loanVAResidualIncomeAmount = value; }
        private DirtyValue<int?> _loanVersionId;
        public int? LoanVersionId { get => _loanVersionId; set => _loanVersionId = value; }
        private DirtyList<LockConfirmLog> _lockConfirmLogs;
        public IList<LockConfirmLog> LockConfirmLogs { get => _lockConfirmLogs ?? (_lockConfirmLogs = new DirtyList<LockConfirmLog>()); set => _lockConfirmLogs = new DirtyList<LockConfirmLog>(value); }
        private DirtyList<LockDenialLog> _lockDenialLogs;
        public IList<LockDenialLog> LockDenialLogs { get => _lockDenialLogs ?? (_lockDenialLogs = new DirtyList<LockDenialLog>()); set => _lockDenialLogs = new DirtyList<LockDenialLog>(value); }
        private DirtyList<LockRequestLog> _lockRequestLogs;
        public IList<LockRequestLog> LockRequestLogs { get => _lockRequestLogs ?? (_lockRequestLogs = new DirtyList<LockRequestLog>()); set => _lockRequestLogs = new DirtyList<LockRequestLog>(value); }
        private ElliLOCompensation _lOCompensation;
        public ElliLOCompensation LOCompensation { get => _lOCompensation ?? (_lOCompensation = new ElliLOCompensation()); set => _lOCompensation = value; }
        private DirtyList<LogEntryLog> _logEntryLogs;
        public IList<LogEntryLog> LogEntryLogs { get => _logEntryLogs ?? (_logEntryLogs = new DirtyList<LogEntryLog>()); set => _logEntryLogs = new DirtyList<LogEntryLog>(value); }
        private DirtyValue<decimal?> _ltv;
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<decimal?> _ltvPropertyValue;
        public decimal? LtvPropertyValue { get => _ltvPropertyValue; set => _ltvPropertyValue = value; }
        private DirtyValue<string> _masterCommitmentNumber;
        public string MasterCommitmentNumber { get => _masterCommitmentNumber; set => _masterCommitmentNumber = value; }
        private DirtyValue<DateTime?> _maturityDate;
        public DateTime? MaturityDate { get => _maturityDate; set => _maturityDate = value; }
        private DirtyValue<decimal?> _maxBackRatio;
        public decimal? MaxBackRatio { get => _maxBackRatio; set => _maxBackRatio = value; }
        private DirtyValue<decimal?> _maxFrontRatio;
        public decimal? MaxFrontRatio { get => _maxFrontRatio; set => _maxFrontRatio = value; }
        private Mcaw _mcaw;
        public Mcaw Mcaw { get => _mcaw ?? (_mcaw = new Mcaw()); set => _mcaw = value; }
        private DirtyValue<string> _mersNumber;
        public string MersNumber { get => _mersNumber; set => _mersNumber = value; }
        private DirtyValue<DateTime?> _mersNumberRegistrationDate;
        public DateTime? MersNumberRegistrationDate { get => _mersNumberRegistrationDate; set => _mersNumberRegistrationDate = value; }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => _miAndFundingFeeFinancedAmount = value; }
        private DirtyValue<decimal?> _miAndFundingFeeTotalAmount;
        public decimal? MiAndFundingFeeTotalAmount { get => _miAndFundingFeeTotalAmount; set => _miAndFundingFeeTotalAmount = value; }
        private DirtyValue<DateTime?> _milestoneApprovedDate;
        public DateTime? MilestoneApprovedDate { get => _milestoneApprovedDate; set => _milestoneApprovedDate = value; }
        private DirtyValue<DateTime?> _milestoneApprovedDueDate;
        public DateTime? MilestoneApprovedDueDate { get => _milestoneApprovedDueDate; set => _milestoneApprovedDueDate = value; }
        private DirtyValue<DateTime?> _milestoneCompletedDate;
        public DateTime? MilestoneCompletedDate { get => _milestoneCompletedDate; set => _milestoneCompletedDate = value; }
        private DirtyValue<DateTime?> _milestoneCompletedDueDate;
        public DateTime? MilestoneCompletedDueDate { get => _milestoneCompletedDueDate; set => _milestoneCompletedDueDate = value; }
        private DirtyValue<DateTime?> _milestoneCurrentDateUtc;
        public DateTime? MilestoneCurrentDateUtc { get => _milestoneCurrentDateUtc; set => _milestoneCurrentDateUtc = value; }
        private DirtyValue<StringEnumValue<MilestoneCurrentName>> _milestoneCurrentName;
        public StringEnumValue<MilestoneCurrentName> MilestoneCurrentName { get => _milestoneCurrentName; set => _milestoneCurrentName = value; }
        private DirtyValue<DateTime?> _milestoneDocSignedDate;
        public DateTime? MilestoneDocSignedDate { get => _milestoneDocSignedDate; set => _milestoneDocSignedDate = value; }
        private DirtyValue<DateTime?> _milestoneDocSignedDueDate;
        public DateTime? MilestoneDocSignedDueDate { get => _milestoneDocSignedDueDate; set => _milestoneDocSignedDueDate = value; }
        private DirtyValue<int?> _milestoneDuration;
        public int? MilestoneDuration { get => _milestoneDuration; set => _milestoneDuration = value; }
        private DirtyValue<DateTime?> _milestoneFileStartedDate;
        public DateTime? MilestoneFileStartedDate { get => _milestoneFileStartedDate; set => _milestoneFileStartedDate = value; }
        private DirtyList<MilestoneFreeRoleLog> _milestoneFreeRoleLogs;
        public IList<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get => _milestoneFreeRoleLogs ?? (_milestoneFreeRoleLogs = new DirtyList<MilestoneFreeRoleLog>()); set => _milestoneFreeRoleLogs = new DirtyList<MilestoneFreeRoleLog>(value); }
        private DirtyValue<DateTime?> _milestoneFundedDate;
        public DateTime? MilestoneFundedDate { get => _milestoneFundedDate; set => _milestoneFundedDate = value; }
        private DirtyValue<DateTime?> _milestoneFundedDueDate;
        public DateTime? MilestoneFundedDueDate { get => _milestoneFundedDueDate; set => _milestoneFundedDueDate = value; }
        private DirtyList<MilestoneLog> _milestoneLogs;
        public IList<MilestoneLog> MilestoneLogs { get => _milestoneLogs ?? (_milestoneLogs = new DirtyList<MilestoneLog>()); set => _milestoneLogs = new DirtyList<MilestoneLog>(value); }
        private DirtyValue<DateTime?> _milestoneProcessedDate;
        public DateTime? MilestoneProcessedDate { get => _milestoneProcessedDate; set => _milestoneProcessedDate = value; }
        private DirtyValue<string> _milestoneStage;
        public string MilestoneStage { get => _milestoneStage; set => _milestoneStage = value; }
        private DirtyValue<DateTime?> _milestoneSubmittedDate;
        public DateTime? MilestoneSubmittedDate { get => _milestoneSubmittedDate; set => _milestoneSubmittedDate = value; }
        private DirtyValue<DateTime?> _milestoneSubmittedDueDate;
        public DateTime? MilestoneSubmittedDueDate { get => _milestoneSubmittedDueDate; set => _milestoneSubmittedDueDate = value; }
        private DirtyList<MilestoneTaskLog> _milestoneTaskLogs;
        public IList<MilestoneTaskLog> MilestoneTaskLogs { get => _milestoneTaskLogs ?? (_milestoneTaskLogs = new DirtyList<MilestoneTaskLog>()); set => _milestoneTaskLogs = new DirtyList<MilestoneTaskLog>(value); }
        private DirtyList<MilestoneTemplateLog> _milestoneTemplateLogs;
        public IList<MilestoneTemplateLog> MilestoneTemplateLogs { get => _milestoneTemplateLogs ?? (_milestoneTemplateLogs = new DirtyList<MilestoneTemplateLog>()); set => _milestoneTemplateLogs = new DirtyList<MilestoneTemplateLog>(value); }
        private DirtyValue<decimal?> _mipBorrowerPaidInCashAmount;
        public decimal? MipBorrowerPaidInCashAmount { get => _mipBorrowerPaidInCashAmount; set => _mipBorrowerPaidInCashAmount = value; }
        private DirtyValue<decimal?> _mipPaidInCashAmount;
        public decimal? MipPaidInCashAmount { get => _mipPaidInCashAmount; set => _mipPaidInCashAmount = value; }
        private Miscellaneous _miscellaneous;
        public Miscellaneous Miscellaneous { get => _miscellaneous ?? (_miscellaneous = new Miscellaneous()); set => _miscellaneous = value; }
        private DirtyValue<decimal?> _monthlyPIPaymentAmountForLE1andCD1;
        public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get => _monthlyPIPaymentAmountForLE1andCD1; set => _monthlyPIPaymentAmountForLE1andCD1 = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremiumFHARefundAmount;
        public decimal? MortgageInsurancePremiumFHARefundAmount { get => _mortgageInsurancePremiumFHARefundAmount; set => _mortgageInsurancePremiumFHARefundAmount = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremiumUpfrontFactorPercent;
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => _mortgageInsurancePremiumUpfrontFactorPercent; set => _mortgageInsurancePremiumUpfrontFactorPercent = value; }
        private DirtyValue<StringEnumValue<LoanType>> _mortgageType;
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<string> _msaIdentifier;
        public string MsaIdentifier { get => _msaIdentifier; set => _msaIdentifier = value; }
        private NetTangibleBenefit _netTangibleBenefit;
        public NetTangibleBenefit NetTangibleBenefit { get => _netTangibleBenefit ?? (_netTangibleBenefit = new NetTangibleBenefit()); set => _netTangibleBenefit = value; }
        private DirtyValue<decimal?> _newFirstMortgageAmount;
        public decimal? NewFirstMortgageAmount { get => _newFirstMortgageAmount; set => _newFirstMortgageAmount = value; }
        private DirtyValue<string> _nmlsLoanOriginatorId;
        public string NmlsLoanOriginatorId { get => _nmlsLoanOriginatorId; set => _nmlsLoanOriginatorId = value; }
        private DirtyValue<bool?> _noClosingCostOption;
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => _noClosingCostOption = value; }
        private DirtyList<NonVol> _nonVols;
        public IList<NonVol> NonVols { get => _nonVols ?? (_nonVols = new DirtyList<NonVol>()); set => _nonVols = new DirtyList<NonVol>(value); }
        private DirtyValue<bool?> _notRequiredForPurchaseSaleOrRefinance;
        public bool? NotRequiredForPurchaseSaleOrRefinance { get => _notRequiredForPurchaseSaleOrRefinance; set => _notRequiredForPurchaseSaleOrRefinance = value; }
        private DirtyValue<bool?> _notRequiredForSettlementOfYourLoan;
        public bool? NotRequiredForSettlementOfYourLoan { get => _notRequiredForSettlementOfYourLoan; set => _notRequiredForSettlementOfYourLoan = value; }
        private DirtyValue<StringEnumValue<OccupancyType>> _occupancyType;
        public StringEnumValue<OccupancyType> OccupancyType { get => _occupancyType; set => _occupancyType = value; }
        private DirtyValue<string> _openingDocsInvestorCode;
        public string OpeningDocsInvestorCode { get => _openingDocsInvestorCode; set => _openingDocsInvestorCode = value; }
        private DirtyValue<StringEnumValue<DocsLoanProgramType>> _openingDocsLoanProgramType;
        public StringEnumValue<DocsLoanProgramType> OpeningDocsLoanProgramType { get => _openingDocsLoanProgramType; set => _openingDocsLoanProgramType = value; }
        private DirtyValue<string> _openingDocsPlanDescription;
        public string OpeningDocsPlanDescription { get => _openingDocsPlanDescription; set => _openingDocsPlanDescription = value; }
        private DirtyValue<string> _openingDocsPlanId;
        public string OpeningDocsPlanId { get => _openingDocsPlanId; set => _openingDocsPlanId = value; }
        private DirtyValue<string> _openingDocsProgramCode;
        public string OpeningDocsProgramCode { get => _openingDocsProgramCode; set => _openingDocsProgramCode = value; }
        private DirtyValue<string> _openingDocsStackingOrder;
        public string OpeningDocsStackingOrder { get => _openingDocsStackingOrder; set => _openingDocsStackingOrder = value; }
        private DirtyValue<string> _organizationCode;
        public string OrganizationCode { get => _organizationCode; set => _organizationCode = value; }
        private DirtyValue<DateTime?> _originationDate;
        public DateTime? OriginationDate { get => _originationDate; set => _originationDate = value; }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => _otherAmortizationTypeDescription = value; }
        private DirtyValue<string> _otherMortgageTypeDescription;
        public string OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => _otherMortgageTypeDescription = value; }
        private DirtyValue<decimal?> _otherPaidClosingCostsAmount;
        public decimal? OtherPaidClosingCostsAmount { get => _otherPaidClosingCostsAmount; set => _otherPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _overwireAmount;
        public decimal? OverwireAmount { get => _overwireAmount; set => _overwireAmount = value; }
        private DirtyValue<bool?> _paymentScheduleCalcRequiredIndicator;
        public bool? PaymentScheduleCalcRequiredIndicator { get => _paymentScheduleCalcRequiredIndicator; set => _paymentScheduleCalcRequiredIndicator = value; }
        private DirtyValue<string> _percentageOfOwnership;
        public string PercentageOfOwnership { get => _percentageOfOwnership; set => _percentageOfOwnership = value; }
        private DirtyValue<decimal?> _percentageOwnershipInterest;
        public decimal? PercentageOwnershipInterest { get => _percentageOwnershipInterest; set => _percentageOwnershipInterest = value; }
        private DirtyValue<bool?> _pmiIndicator;
        public bool? PmiIndicator { get => _pmiIndicator; set => _pmiIndicator = value; }
        private DirtyList<PostClosingConditionLog> _postClosingConditionLogs;
        public IList<PostClosingConditionLog> PostClosingConditionLogs { get => _postClosingConditionLogs ?? (_postClosingConditionLogs = new DirtyList<PostClosingConditionLog>()); set => _postClosingConditionLogs = new DirtyList<PostClosingConditionLog>(value); }
        private DirtyList<PreliminaryConditionLog> _preliminaryConditionLogs;
        public IList<PreliminaryConditionLog> PreliminaryConditionLogs { get => _preliminaryConditionLogs ?? (_preliminaryConditionLogs = new DirtyList<PreliminaryConditionLog>()); set => _preliminaryConditionLogs = new DirtyList<PreliminaryConditionLog>(value); }
        private Prequalification _prequalification;
        public Prequalification Prequalification { get => _prequalification ?? (_prequalification = new Prequalification()); set => _prequalification = value; }
        private DirtyValue<decimal?> _principalAndInterestMonthlyPaymentAmount;
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => _principalAndInterestMonthlyPaymentAmount; set => _principalAndInterestMonthlyPaymentAmount = value; }
        private DirtyValue<StringEnumValue<Print2003Application>> _print2003Application;
        public StringEnumValue<Print2003Application> Print2003Application { get => _print2003Application; set => _print2003Application = value; }
        private DirtyList<PrintLog> _printLogs;
        public IList<PrintLog> PrintLogs { get => _printLogs ?? (_printLogs = new DirtyList<PrintLog>()); set => _printLogs = new DirtyList<PrintLog>(value); }
        private PrivacyPolicy _privacyPolicy;
        public PrivacyPolicy PrivacyPolicy { get => _privacyPolicy ?? (_privacyPolicy = new PrivacyPolicy()); set => _privacyPolicy = value; }
        private ProfitManagement _profitManagement;
        public ProfitManagement ProfitManagement { get => _profitManagement ?? (_profitManagement = new ProfitManagement()); set => _profitManagement = value; }
        private Property _property;
        public Property Property { get => _property ?? (_property = new Property()); set => _property = value; }
        private DirtyValue<int?> _propertyAppraisedValueAmount;
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => _propertyAppraisedValueAmount = value; }
        private DirtyValue<bool?> _propertyEnergyEfficientHomeIndicator;
        public bool? PropertyEnergyEfficientHomeIndicator { get => _propertyEnergyEfficientHomeIndicator; set => _propertyEnergyEfficientHomeIndicator = value; }
        private DirtyValue<int?> _propertyEstimatedValueAmount;
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => _propertyEstimatedValueAmount = value; }
        private DirtyValue<string> _proposedDuesAmount;
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => _proposedDuesAmount = value; }
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => _proposedFirstMortgageAmount = value; }
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => _proposedGroundRentAmount = value; }
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => _proposedHazardInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedHousingExpenseTotal;
        public decimal? ProposedHousingExpenseTotal { get => _proposedHousingExpenseTotal; set => _proposedHousingExpenseTotal = value; }
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => _proposedMortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedOtherAmount;
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => _proposedOtherAmount = value; }
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => _proposedOtherMortgagesAmount = value; }
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => _proposedRealEstateTaxesAmount = value; }
        private DirtyList<PurchaseCredit> _purchaseCredits;
        public IList<PurchaseCredit> PurchaseCredits { get => _purchaseCredits ?? (_purchaseCredits = new DirtyList<PurchaseCredit>()); set => _purchaseCredits = new DirtyList<PurchaseCredit>(value); }
        private DirtyValue<decimal?> _purchasePriceAmount;
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => _purchasePriceAmount = value; }
        private RateLock _rateLock;
        public RateLock RateLock { get => _rateLock ?? (_rateLock = new RateLock()); set => _rateLock = value; }
        private DirtyValue<string> _referralAddress;
        public string ReferralAddress { get => _referralAddress; set => _referralAddress = value; }
        private DirtyValue<string> _referralCity;
        public string ReferralCity { get => _referralCity; set => _referralCity = value; }
        private DirtyValue<decimal?> _referralFeeAmount;
        public decimal? ReferralFeeAmount { get => _referralFeeAmount; set => _referralFeeAmount = value; }
        private DirtyValue<string> _referralPostalCode;
        public string ReferralPostalCode { get => _referralPostalCode; set => _referralPostalCode = value; }
        private DirtyValue<string> _referralSource;
        public string ReferralSource { get => _referralSource; set => _referralSource = value; }
        private EntityReference _referralSourceContact;
        public EntityReference ReferralSourceContact { get => _referralSourceContact ?? (_referralSourceContact = new EntityReference()); set => _referralSourceContact = value; }
        private DirtyValue<string> _referralState;
        public string ReferralState { get => _referralState; set => _referralState = value; }
        private DirtyValue<decimal?> _refinanceIncludingDebtsToBePaidOffAmount;
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get => _refinanceIncludingDebtsToBePaidOffAmount; set => _refinanceIncludingDebtsToBePaidOffAmount = value; }
        private DirtyList<RegistrationLog> _registrationLogs;
        public IList<RegistrationLog> RegistrationLogs { get => _registrationLogs ?? (_registrationLogs = new DirtyList<RegistrationLog>()); set => _registrationLogs = new DirtyList<RegistrationLog>(value); }
        private RegulationZ _regulationZ;
        public RegulationZ RegulationZ { get => _regulationZ ?? (_regulationZ = new RegulationZ()); set => _regulationZ = value; }
        private DirtyList<RemovedLogRecord> _removedLogRecords;
        public IList<RemovedLogRecord> RemovedLogRecords { get => _removedLogRecords ?? (_removedLogRecords = new DirtyList<RemovedLogRecord>()); set => _removedLogRecords = new DirtyList<RemovedLogRecord>(value); }
        private DirtyValue<decimal?> _repurchaseCostAmount;
        public decimal? RepurchaseCostAmount { get => _repurchaseCostAmount; set => _repurchaseCostAmount = value; }
        private DirtyValue<DateTime?> _repurchaseDate;
        public DateTime? RepurchaseDate { get => _repurchaseDate; set => _repurchaseDate = value; }
        private DirtyValue<decimal?> _requestedInterestRatePercent;
        public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => _requestedInterestRatePercent = value; }
        private DirtyValue<string> _requestedInterestRatePercentUI;
        public string RequestedInterestRatePercentUI { get => _requestedInterestRatePercentUI; set => _requestedInterestRatePercentUI = value; }
        private DirtyValue<decimal?> _salesConcessionAmount;
        public decimal? SalesConcessionAmount { get => _salesConcessionAmount; set => _salesConcessionAmount = value; }
        private DirtyValue<decimal?> _secondSubordinateAmount;
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => _secondSubordinateAmount = value; }
        private Section32 _section32;
        public Section32 Section32 { get => _section32 ?? (_section32 = new Section32()); set => _section32 = value; }
        private DirtyValue<StringEnumValue<SectionOfActType>> _sectionOfActType;
        public StringEnumValue<SectionOfActType> SectionOfActType { get => _sectionOfActType; set => _sectionOfActType = value; }
        private SelectedHomeCounselingProvider _selectedHomeCounselingProvider;
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get => _selectedHomeCounselingProvider ?? (_selectedHomeCounselingProvider = new SelectedHomeCounselingProvider()); set => _selectedHomeCounselingProvider = value; }
        private DirtyValue<decimal?> _sellerPaidClosingCostsAmount;
        public decimal? SellerPaidClosingCostsAmount { get => _sellerPaidClosingCostsAmount; set => _sellerPaidClosingCostsAmount = value; }
        private DirtyValue<DateTime?> _serverDateTimeDDMApplied;
        public DateTime? ServerDateTimeDDMApplied { get => _serverDateTimeDDMApplied; set => _serverDateTimeDDMApplied = value; }
        private DirtyValue<string> _serviceProviderAdditionalInfo;
        public string ServiceProviderAdditionalInfo { get => _serviceProviderAdditionalInfo; set => _serviceProviderAdditionalInfo = value; }
        private DirtyList<ServiceProviderContact> _serviceProviderContacts;
        public IList<ServiceProviderContact> ServiceProviderContacts { get => _serviceProviderContacts ?? (_serviceProviderContacts = new DirtyList<ServiceProviderContact>()); set => _serviceProviderContacts = new DirtyList<ServiceProviderContact>(value); }
        private DirtyValue<DateTime?> _serviceProviderDateIssued;
        public DateTime? ServiceProviderDateIssued { get => _serviceProviderDateIssued; set => _serviceProviderDateIssued = value; }
        private ServicingDisclosure _servicingDisclosure;
        public ServicingDisclosure ServicingDisclosure { get => _servicingDisclosure ?? (_servicingDisclosure = new ServicingDisclosure()); set => _servicingDisclosure = value; }
        private DirtyValue<bool?> _setForSettlementServicesOfAnAttorney;
        public bool? SetForSettlementServicesOfAnAttorney { get => _setForSettlementServicesOfAnAttorney; set => _setForSettlementServicesOfAnAttorney = value; }
        private DirtyValue<bool?> _setForTheSettlementServicesListed;
        public bool? SetForTheSettlementServicesListed { get => _setForTheSettlementServicesListed; set => _setForTheSettlementServicesListed = value; }
        private DirtyList<SettlementServiceCharge> _settlementServiceCharges;
        public IList<SettlementServiceCharge> SettlementServiceCharges { get => _settlementServiceCharges ?? (_settlementServiceCharges = new DirtyList<SettlementServiceCharge>()); set => _settlementServiceCharges = new DirtyList<SettlementServiceCharge>(value); }
        private Shipping _shipping;
        public Shipping Shipping { get => _shipping ?? (_shipping = new Shipping()); set => _shipping = value; }
        private DirtyValue<bool?> _simpleRefinanceType;
        public bool? SimpleRefinanceType { get => _simpleRefinanceType; set => _simpleRefinanceType = value; }
        private DirtyValue<decimal?> _startingAdjPrice;
        public decimal? StartingAdjPrice { get => _startingAdjPrice; set => _startingAdjPrice = value; }
        private DirtyValue<decimal?> _startingAdjRate;
        public decimal? StartingAdjRate { get => _startingAdjRate; set => _startingAdjRate = value; }
        private StateDisclosure _stateDisclosure;
        public StateDisclosure StateDisclosure { get => _stateDisclosure ?? (_stateDisclosure = new StateDisclosure()); set => _stateDisclosure = value; }
        private StatementCreditDenial _statementCreditDenial;
        public StatementCreditDenial StatementCreditDenial { get => _statementCreditDenial ?? (_statementCreditDenial = new StatementCreditDenial()); set => _statementCreditDenial = value; }
        private DirtyList<StatusOnlineLog> _statusOnlineLogs;
        public IList<StatusOnlineLog> StatusOnlineLogs { get => _statusOnlineLogs ?? (_statusOnlineLogs = new DirtyList<StatusOnlineLog>()); set => _statusOnlineLogs = new DirtyList<StatusOnlineLog>(value); }
        private DirtyValue<decimal?> _subjectPropertyGrossRentalIncomeAmount;
        public decimal? SubjectPropertyGrossRentalIncomeAmount { get => _subjectPropertyGrossRentalIncomeAmount; set => _subjectPropertyGrossRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _subjectPropertyOccupancyPercent;
        public decimal? SubjectPropertyOccupancyPercent { get => _subjectPropertyOccupancyPercent; set => _subjectPropertyOccupancyPercent = value; }
        private DirtyValue<decimal?> _subordinateLienAmount;
        public decimal? SubordinateLienAmount { get => _subordinateLienAmount; set => _subordinateLienAmount = value; }
        private DirtyValue<string> _systemIdGuid;
        public string SystemIdGuid { get => _systemIdGuid; set => _systemIdGuid = value; }
        private DirtyValue<DateTime?> _tilApplicationDate;
        public DateTime? TilApplicationDate { get => _tilApplicationDate; set => _tilApplicationDate = value; }
        private DirtyValue<string> _titleHolderName1;
        public string TitleHolderName1 { get => _titleHolderName1; set => _titleHolderName1 = value; }
        private DirtyValue<string> _titleHolderName2;
        public string TitleHolderName2 { get => _titleHolderName2; set => _titleHolderName2 = value; }
        private DirtyValue<decimal?> _tltv;
        public decimal? Tltv { get => _tltv; set => _tltv = value; }
        private DirtyValue<decimal?> _totalClosingCostsAmount;
        public decimal? TotalClosingCostsAmount { get => _totalClosingCostsAmount; set => _totalClosingCostsAmount = value; }
        private DirtyValue<decimal?> _totalDeductionsAmount;
        public decimal? TotalDeductionsAmount { get => _totalDeductionsAmount; set => _totalDeductionsAmount = value; }
        private DirtyValue<decimal?> _totalFeesCostAmount;
        public decimal? TotalFeesCostAmount { get => _totalFeesCostAmount; set => _totalFeesCostAmount = value; }
        private DirtyValue<decimal?> _totalFeesCreditAmount;
        public decimal? TotalFeesCreditAmount { get => _totalFeesCreditAmount; set => _totalFeesCreditAmount = value; }
        private DirtyValue<decimal?> _totalNonborrowerPaidClosingCostsAmount;
        public decimal? TotalNonborrowerPaidClosingCostsAmount { get => _totalNonborrowerPaidClosingCostsAmount; set => _totalNonborrowerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _totalPaidOutsideClosingAmount;
        public decimal? TotalPaidOutsideClosingAmount { get => _totalPaidOutsideClosingAmount; set => _totalPaidOutsideClosingAmount = value; }
        private DirtyValue<decimal?> _totalPaidToBrokerAmount;
        public decimal? TotalPaidToBrokerAmount { get => _totalPaidToBrokerAmount; set => _totalPaidToBrokerAmount = value; }
        private DirtyValue<decimal?> _totalWireTransferAmount;
        public decimal? TotalWireTransferAmount { get => _totalWireTransferAmount; set => _totalWireTransferAmount = value; }
        private TPO _tPO;
        public TPO TPO { get => _tPO ?? (_tPO = new TPO()); set => _tPO = value; }
        private TQL _tQL;
        public TQL TQL { get => _tQL ?? (_tQL = new TQL()); set => _tQL = value; }
        private TrustAccount _trustAccount;
        public TrustAccount TrustAccount { get => _trustAccount ?? (_trustAccount = new TrustAccount()); set => _trustAccount = value; }
        private Tsum _tsum;
        public Tsum Tsum { get => _tsum ?? (_tsum = new Tsum()); set => _tsum = value; }
        private DirtyValue<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => _twelveMonthMortgageRentalHistoryIndicator = value; }
        private Uldd _uldd;
        public Uldd Uldd { get => _uldd ?? (_uldd = new Uldd()); set => _uldd = value; }
        private UnderwriterSummary _underwriterSummary;
        public UnderwriterSummary UnderwriterSummary { get => _underwriterSummary ?? (_underwriterSummary = new UnderwriterSummary()); set => _underwriterSummary = value; }
        private DirtyList<UnderwritingConditionLog> _underwritingConditionLogs;
        public IList<UnderwritingConditionLog> UnderwritingConditionLogs { get => _underwritingConditionLogs ?? (_underwritingConditionLogs = new DirtyList<UnderwritingConditionLog>()); set => _underwritingConditionLogs = new DirtyList<UnderwritingConditionLog>(value); }
        private DirtyValue<bool?> _underwritingEscrowIndicator;
        public bool? UnderwritingEscrowIndicator { get => _underwritingEscrowIndicator; set => _underwritingEscrowIndicator = value; }
        private DirtyValue<decimal?> _undiscountedRate;
        public decimal? UndiscountedRate { get => _undiscountedRate; set => _undiscountedRate = value; }
        private DirtyValue<int?> _unimprovedAppraisedValue;
        public int? UnimprovedAppraisedValue { get => _unimprovedAppraisedValue; set => _unimprovedAppraisedValue = value; }
        private DirtyValue<int?> _unimprovedEstimatedValue;
        public int? UnimprovedEstimatedValue { get => _unimprovedEstimatedValue; set => _unimprovedEstimatedValue = value; }
        private DirtyValue<string> _urlPage4Comments;
        public string UrlPage4Comments { get => _urlPage4Comments; set => _urlPage4Comments = value; }
        private Usda _usda;
        public Usda Usda { get => _usda ?? (_usda = new Usda()); set => _usda = value; }
        private DirtyValue<StringEnumValue<UsdaGovernmentLoanType>> _usdaGovernmentLoanType;
        public StringEnumValue<UsdaGovernmentLoanType> UsdaGovernmentLoanType { get => _usdaGovernmentLoanType; set => _usdaGovernmentLoanType = value; }
        private DirtyValue<bool?> _use2018DiIndicator;
        public bool? Use2018DiIndicator { get => _use2018DiIndicator; set => _use2018DiIndicator = value; }
        private DirtyValue<StringEnumValue<UseNew2015FormsIndicator>> _useNew2015FormsIndicator;
        public StringEnumValue<UseNew2015FormsIndicator> UseNew2015FormsIndicator { get => _useNew2015FormsIndicator; set => _useNew2015FormsIndicator = value; }
        private DirtyValue<bool?> _useNewHudIndicator;
        public bool? UseNewHudIndicator { get => _useNewHudIndicator; set => _useNewHudIndicator = value; }
        private DirtyValue<decimal?> _vAEntitlementAmount;
        public decimal? VAEntitlementAmount { get => _vAEntitlementAmount; set => _vAEntitlementAmount = value; }
        private VaLoanData _vaLoanData;
        public VaLoanData VaLoanData { get => _vaLoanData ?? (_vaLoanData = new VaLoanData()); set => _vaLoanData = value; }
        private DirtyList<VerificationLog> _verificationLogs;
        public IList<VerificationLog> VerificationLogs { get => _verificationLogs ?? (_verificationLogs = new DirtyList<VerificationLog>()); set => _verificationLogs = new DirtyList<VerificationLog>(value); }
        private DirtyValue<string> _websiteId;
        public string WebsiteId { get => _websiteId; set => _websiteId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adverseActionDate.Dirty
                    || _agencyCaseIdentifier.Dirty
                    || _alterationsImprovementsOrRepairsAmount.Dirty
                    || _applicationTakenMethodType.Dirty
                    || _aprDisclosureDate.Dirty
                    || _armTypeDescription.Dirty
                    || _baseLoanAmount.Dirty
                    || _belowMarketSubordinateFinancingIndicator.Dirty
                    || _billingCategory.Dirty
                    || _biweeklyPaymentAmount.Dirty
                    || _bLTV.Dirty
                    || _borrowerCoBorrowerMarriedIndicator.Dirty
                    || _borrowerPaidClosingCostsAmount.Dirty
                    || _borrowerPaidDiscountPointsAmount.Dirty
                    || _borrowerPaidFHAVAClosingCostsAmount.Dirty
                    || _borrowerPairCount.Dirty
                    || _borrowerRequestedLoanAmount.Dirty
                    || _brokerPaidClosingCostsAmount.Dirty
                    || _buydownIndicator.Dirty
                    || _buydownMonthlyPaymentAmount.Dirty
                    || _buydownRatePercent.Dirty
                    || _cashFromToBorrowerAmount.Dirty
                    || _channel.Dirty
                    || _closingBillingDate.Dirty
                    || _closingCostProgram.Dirty
                    || _closingCostsAndPrepaidsFromOtherLienAmount.Dirty
                    || _closingCostsPaidByOthersAmount.Dirty
                    || _closingDocsStackingOrder.Dirty
                    || _collateralManagerScore.Dirty
                    || _combinedLtv.Dirty
                    || _commitmentNumber.Dirty
                    || _conformingJumbo.Dirty
                    || _consumerConnectSiteID.Dirty
                    || _contactUpdatedIndicator.Dirty
                    || _contractSellerCreditAmount.Dirty
                    || _copyBrokerToLenderIndicator.Dirty
                    || _copyLoanNumLenderCaseNum.Dirty
                    || _creditScoreToUse.Dirty
                    || _currentApplicationIndex.Dirty
                    || _currentApplicationIsPrimary.Dirty
                    || _currentFirstMortgageHolderType.Dirty
                    || _dBIndicator.Dirty
                    || _deductOverwireAmountIndicator.Dirty
                    || _disableESignConsentAlert.Dirty
                    || _disableKeyPricingAlert.Dirty
                    || _discountPoint.Dirty
                    || _docEngine.Dirty
                    || _doNotCheckEmail.Dirty
                    || _doNotPrintCompensationFees.Dirty
                    || _downPaymentPercent.Dirty
                    || _eDeliveryVersion.Dirty
                    || _emXmlVersionId.Dirty
                    || _encompassId.Dirty
                    || _encompassVersion.Dirty
                    || _enforceCountyLoanLimit.Dirty
                    || _estimatedClosingCostsAmount.Dirty
                    || _estimatedConstructionInterest.Dirty
                    || _estimatedPrepaidItemsAmount.Dirty
                    || _exportLoanNumber.Dirty
                    || _fhaMiPremiumRefundAmount.Dirty
                    || _fHAVALoanOriginatorIdentifier.Dirty
                    || _firstAdjustmentMinimum.Dirty
                    || _firstSubordinateLienAmount.Dirty
                    || _firstTimeHomebuyersIndicator.Dirty
                    || _fnmCommunityLendingProductName.Dirty
                    || _fnmCommunitySecondsIndicator.Dirty
                    || _fnmNeighborsMortgageEligibilityIndicator.Dirty
                    || _fraudScore.Dirty
                    || _fundingDeductionList.Dirty
                    || _fundingFeeList.Dirty
                    || _governmentLoanLenderIdentifier.Dirty
                    || _governmentLoanSponsorIdentifier.Dirty
                    || _governmentMortgageCreditCertificateAmount.Dirty
                    || _hasAbusinessRelationshipWith.Dirty
                    || _hcltvHtltv.Dirty
                    || _helocTeaserRate.Dirty
                    || _homeCounselingProvidersDistance.Dirty
                    || _homeCounselingProvidersLanguageNames.Dirty
                    || _homeCounselingProvidersServiceNames.Dirty
                    || _householdSizeCount.Dirty
                    || _hudIncomeLimitAdjustmentFactor.Dirty
                    || _hudLendingIncomeLimitAmount.Dirty
                    || _hudMedianIncomeAmount.Dirty
                    || _id.Dirty
                    || _includeUSDAFeeInClosing.Dirty
                    || _initialInterestRate.Dirty
                    || _initialInterestRateUI.Dirty
                    || _insuranceAuthorizationIndicator.Dirty
                    || _interviewerApplicationSignedDate.Dirty
                    || _interviewerEmail.Dirty
                    || _interviewerLicenseIdentifier.Dirty
                    || _interviewerPhoneNumber.Dirty
                    || _interviewersCompanyStateLicense.Dirty
                    || _interviewersId.Dirty
                    || _inverviewerName.Dirty
                    || _isCreditorProhibitsBorrower.Dirty
                    || _isEmployeeLoan.Dirty
                    || _isLSSecondaryFile.Dirty
                    || _isRequiredInterestReserveCompoundInterest.Dirty
                    || _landIfAcquiredSeperatelyAmount.Dirty
                    || _leadSource.Dirty
                    || _lenderCaseIdentifier.Dirty
                    || _lenderChannel.Dirty
                    || _lenderCreditsInFunding.Dirty
                    || _lenderInvestorCode.Dirty
                    || _lenderPaidClosignCostsDotAmount.Dirty
                    || _lenderPaidClosingCostsAmount.Dirty
                    || _lesserAppraisedValueOrSalesPrice.Dirty
                    || _lifeInsuranceCoverageAmount.Dirty
                    || _lifeInsuranceEstimatedMonthlyAmount.Dirty
                    || _lifeInsuranceTotalProtectedMonthlyAmount.Dirty
                    || _linkedBorrowerRequestedLoanAmount.Dirty
                    || _linkId.Dirty
                    || _loanAmortizationTermMonths.Dirty
                    || _loanAmortizationType.Dirty
                    || _loanCreatedDate.Dirty
                    || _loanCreatedDateUtc.Dirty
                    || _loanIdNumber.Dirty
                    || _loanImportStatusIndicator.Dirty
                    || _loanLinkSyncType.Dirty
                    || _loanNumber.Dirty
                    || _loanProgramName.Dirty
                    || _loanPurposeOfRefinanceType.Dirty
                    || _loanSource.Dirty
                    || _loanTotalProposedMonthlyMaintenanceAmount.Dirty
                    || _loanTotalProposedMonthlyUtilitiesAmount.Dirty
                    || _loanUnderwriterCHUMSIdentifier.Dirty
                    || _loanVALoanProcedureType.Dirty
                    || _loanVARateReductionInitialComputationTotalAmount.Dirty
                    || _loanVAResidualIncomeAmount.Dirty
                    || _loanVersionId.Dirty
                    || _ltv.Dirty
                    || _ltvPropertyValue.Dirty
                    || _masterCommitmentNumber.Dirty
                    || _maturityDate.Dirty
                    || _maxBackRatio.Dirty
                    || _maxFrontRatio.Dirty
                    || _mersNumber.Dirty
                    || _mersNumberRegistrationDate.Dirty
                    || _miAndFundingFeeFinancedAmount.Dirty
                    || _miAndFundingFeeTotalAmount.Dirty
                    || _milestoneApprovedDate.Dirty
                    || _milestoneApprovedDueDate.Dirty
                    || _milestoneCompletedDate.Dirty
                    || _milestoneCompletedDueDate.Dirty
                    || _milestoneCurrentDateUtc.Dirty
                    || _milestoneCurrentName.Dirty
                    || _milestoneDocSignedDate.Dirty
                    || _milestoneDocSignedDueDate.Dirty
                    || _milestoneDuration.Dirty
                    || _milestoneFileStartedDate.Dirty
                    || _milestoneFundedDate.Dirty
                    || _milestoneFundedDueDate.Dirty
                    || _milestoneProcessedDate.Dirty
                    || _milestoneStage.Dirty
                    || _milestoneSubmittedDate.Dirty
                    || _milestoneSubmittedDueDate.Dirty
                    || _mipBorrowerPaidInCashAmount.Dirty
                    || _mipPaidInCashAmount.Dirty
                    || _monthlyPIPaymentAmountForLE1andCD1.Dirty
                    || _mortgageInsurancePremiumFHARefundAmount.Dirty
                    || _mortgageInsurancePremiumUpfrontFactorPercent.Dirty
                    || _mortgageType.Dirty
                    || _msaIdentifier.Dirty
                    || _newFirstMortgageAmount.Dirty
                    || _nmlsLoanOriginatorId.Dirty
                    || _noClosingCostOption.Dirty
                    || _notRequiredForPurchaseSaleOrRefinance.Dirty
                    || _notRequiredForSettlementOfYourLoan.Dirty
                    || _occupancyType.Dirty
                    || _openingDocsInvestorCode.Dirty
                    || _openingDocsLoanProgramType.Dirty
                    || _openingDocsPlanDescription.Dirty
                    || _openingDocsPlanId.Dirty
                    || _openingDocsProgramCode.Dirty
                    || _openingDocsStackingOrder.Dirty
                    || _organizationCode.Dirty
                    || _originationDate.Dirty
                    || _otherAmortizationTypeDescription.Dirty
                    || _otherMortgageTypeDescription.Dirty
                    || _otherPaidClosingCostsAmount.Dirty
                    || _overwireAmount.Dirty
                    || _paymentScheduleCalcRequiredIndicator.Dirty
                    || _percentageOfOwnership.Dirty
                    || _percentageOwnershipInterest.Dirty
                    || _pmiIndicator.Dirty
                    || _principalAndInterestMonthlyPaymentAmount.Dirty
                    || _print2003Application.Dirty
                    || _propertyAppraisedValueAmount.Dirty
                    || _propertyEnergyEfficientHomeIndicator.Dirty
                    || _propertyEstimatedValueAmount.Dirty
                    || _proposedDuesAmount.Dirty
                    || _proposedFirstMortgageAmount.Dirty
                    || _proposedGroundRentAmount.Dirty
                    || _proposedHazardInsuranceAmount.Dirty
                    || _proposedHousingExpenseTotal.Dirty
                    || _proposedMortgageInsuranceAmount.Dirty
                    || _proposedOtherAmount.Dirty
                    || _proposedOtherMortgagesAmount.Dirty
                    || _proposedRealEstateTaxesAmount.Dirty
                    || _purchasePriceAmount.Dirty
                    || _referralAddress.Dirty
                    || _referralCity.Dirty
                    || _referralFeeAmount.Dirty
                    || _referralPostalCode.Dirty
                    || _referralSource.Dirty
                    || _referralState.Dirty
                    || _refinanceIncludingDebtsToBePaidOffAmount.Dirty
                    || _repurchaseCostAmount.Dirty
                    || _repurchaseDate.Dirty
                    || _requestedInterestRatePercent.Dirty
                    || _requestedInterestRatePercentUI.Dirty
                    || _salesConcessionAmount.Dirty
                    || _secondSubordinateAmount.Dirty
                    || _sectionOfActType.Dirty
                    || _sellerPaidClosingCostsAmount.Dirty
                    || _serverDateTimeDDMApplied.Dirty
                    || _serviceProviderAdditionalInfo.Dirty
                    || _serviceProviderDateIssued.Dirty
                    || _setForSettlementServicesOfAnAttorney.Dirty
                    || _setForTheSettlementServicesListed.Dirty
                    || _simpleRefinanceType.Dirty
                    || _startingAdjPrice.Dirty
                    || _startingAdjRate.Dirty
                    || _subjectPropertyGrossRentalIncomeAmount.Dirty
                    || _subjectPropertyOccupancyPercent.Dirty
                    || _subordinateLienAmount.Dirty
                    || _systemIdGuid.Dirty
                    || _tilApplicationDate.Dirty
                    || _titleHolderName1.Dirty
                    || _titleHolderName2.Dirty
                    || _tltv.Dirty
                    || _totalClosingCostsAmount.Dirty
                    || _totalDeductionsAmount.Dirty
                    || _totalFeesCostAmount.Dirty
                    || _totalFeesCreditAmount.Dirty
                    || _totalNonborrowerPaidClosingCostsAmount.Dirty
                    || _totalPaidOutsideClosingAmount.Dirty
                    || _totalPaidToBrokerAmount.Dirty
                    || _totalWireTransferAmount.Dirty
                    || _twelveMonthMortgageRentalHistoryIndicator.Dirty
                    || _underwritingEscrowIndicator.Dirty
                    || _undiscountedRate.Dirty
                    || _unimprovedAppraisedValue.Dirty
                    || _unimprovedEstimatedValue.Dirty
                    || _urlPage4Comments.Dirty
                    || _usdaGovernmentLoanType.Dirty
                    || _use2018DiIndicator.Dirty
                    || _useNew2015FormsIndicator.Dirty
                    || _useNewHudIndicator.Dirty
                    || _vAEntitlementAmount.Dirty
                    || _websiteId.Dirty
                    || _additionalRequests?.Dirty == true
                    || _affiliatedBusinessArrangements?.Dirty == true
                    || _applications?.Dirty == true
                    || _aTRQMCommon?.Dirty == true
                    || _closingCost?.Dirty == true
                    || _closingDocument?.Dirty == true
                    || _commitmentTerms?.Dirty == true
                    || _complianceTestLogs?.Dirty == true
                    || _constructionManagement?.Dirty == true
                    || _contacts?.Dirty == true
                    || _conversationLogs?.Dirty == true
                    || _correspondent?.Dirty == true
                    || _crmLogs?.Dirty == true
                    || _currentApplication?.Dirty == true
                    || _customFields?.Dirty == true
                    || _customModelFields?.Dirty == true
                    || _dataTracLogs?.Dirty == true
                    || _disclosureNotices?.Dirty == true
                    || _disclosureTracking2015Logs?.Dirty == true
                    || _disclosureTrackingLogs?.Dirty == true
                    || _documentLogs?.Dirty == true
                    || _documentOrderLogs?.Dirty == true
                    || _downloadLogs?.Dirty == true
                    || _downPayment?.Dirty == true
                    || _edmLogs?.Dirty == true
                    || _emailTriggerLogs?.Dirty == true
                    || _emDocument?.Dirty == true
                    || _emDocumentInvestor?.Dirty == true
                    || _emDocumentLender?.Dirty == true
                    || _fannieMae?.Dirty == true
                    || _fees?.Dirty == true
                    || _fhaVaLoan?.Dirty == true
                    || _fieldLockData?.Dirty == true
                    || _forms?.Dirty == true
                    || _freddieMac?.Dirty == true
                    || _funding?.Dirty == true
                    || _fundingFees?.Dirty == true
                    || _gfe?.Dirty == true
                    || _hmda?.Dirty == true
                    || _homeCounselingProviders?.Dirty == true
                    || _htmlEmailLogs?.Dirty == true
                    || _hud1Es?.Dirty == true
                    || _hudLoanData?.Dirty == true
                    || _interimServicing?.Dirty == true
                    || _loanActionLogs?.Dirty == true
                    || _loanProductData?.Dirty == true
                    || _loanPrograms?.Dirty == true
                    || _loanSubmission?.Dirty == true
                    || _lockConfirmLogs?.Dirty == true
                    || _lockDenialLogs?.Dirty == true
                    || _lockRequestLogs?.Dirty == true
                    || _lOCompensation?.Dirty == true
                    || _logEntryLogs?.Dirty == true
                    || _mcaw?.Dirty == true
                    || _milestoneFreeRoleLogs?.Dirty == true
                    || _milestoneLogs?.Dirty == true
                    || _milestoneTaskLogs?.Dirty == true
                    || _milestoneTemplateLogs?.Dirty == true
                    || _miscellaneous?.Dirty == true
                    || _netTangibleBenefit?.Dirty == true
                    || _nonVols?.Dirty == true
                    || _postClosingConditionLogs?.Dirty == true
                    || _preliminaryConditionLogs?.Dirty == true
                    || _prequalification?.Dirty == true
                    || _printLogs?.Dirty == true
                    || _privacyPolicy?.Dirty == true
                    || _profitManagement?.Dirty == true
                    || _property?.Dirty == true
                    || _purchaseCredits?.Dirty == true
                    || _rateLock?.Dirty == true
                    || _referralSourceContact?.Dirty == true
                    || _registrationLogs?.Dirty == true
                    || _regulationZ?.Dirty == true
                    || _removedLogRecords?.Dirty == true
                    || _section32?.Dirty == true
                    || _selectedHomeCounselingProvider?.Dirty == true
                    || _serviceProviderContacts?.Dirty == true
                    || _servicingDisclosure?.Dirty == true
                    || _settlementServiceCharges?.Dirty == true
                    || _shipping?.Dirty == true
                    || _stateDisclosure?.Dirty == true
                    || _statementCreditDenial?.Dirty == true
                    || _statusOnlineLogs?.Dirty == true
                    || _tPO?.Dirty == true
                    || _tQL?.Dirty == true
                    || _trustAccount?.Dirty == true
                    || _tsum?.Dirty == true
                    || _uldd?.Dirty == true
                    || _underwriterSummary?.Dirty == true
                    || _underwritingConditionLogs?.Dirty == true
                    || _usda?.Dirty == true
                    || _vaLoanData?.Dirty == true
                    || _verificationLogs?.Dirty == true;
            }
            set
            {
                _adverseActionDate.Dirty = value;
                _agencyCaseIdentifier.Dirty = value;
                _alterationsImprovementsOrRepairsAmount.Dirty = value;
                _applicationTakenMethodType.Dirty = value;
                _aprDisclosureDate.Dirty = value;
                _armTypeDescription.Dirty = value;
                _baseLoanAmount.Dirty = value;
                _belowMarketSubordinateFinancingIndicator.Dirty = value;
                _billingCategory.Dirty = value;
                _biweeklyPaymentAmount.Dirty = value;
                _bLTV.Dirty = value;
                _borrowerCoBorrowerMarriedIndicator.Dirty = value;
                _borrowerPaidClosingCostsAmount.Dirty = value;
                _borrowerPaidDiscountPointsAmount.Dirty = value;
                _borrowerPaidFHAVAClosingCostsAmount.Dirty = value;
                _borrowerPairCount.Dirty = value;
                _borrowerRequestedLoanAmount.Dirty = value;
                _brokerPaidClosingCostsAmount.Dirty = value;
                _buydownIndicator.Dirty = value;
                _buydownMonthlyPaymentAmount.Dirty = value;
                _buydownRatePercent.Dirty = value;
                _cashFromToBorrowerAmount.Dirty = value;
                _channel.Dirty = value;
                _closingBillingDate.Dirty = value;
                _closingCostProgram.Dirty = value;
                _closingCostsAndPrepaidsFromOtherLienAmount.Dirty = value;
                _closingCostsPaidByOthersAmount.Dirty = value;
                _closingDocsStackingOrder.Dirty = value;
                _collateralManagerScore.Dirty = value;
                _combinedLtv.Dirty = value;
                _commitmentNumber.Dirty = value;
                _conformingJumbo.Dirty = value;
                _consumerConnectSiteID.Dirty = value;
                _contactUpdatedIndicator.Dirty = value;
                _contractSellerCreditAmount.Dirty = value;
                _copyBrokerToLenderIndicator.Dirty = value;
                _copyLoanNumLenderCaseNum.Dirty = value;
                _creditScoreToUse.Dirty = value;
                _currentApplicationIndex.Dirty = value;
                _currentApplicationIsPrimary.Dirty = value;
                _currentFirstMortgageHolderType.Dirty = value;
                _dBIndicator.Dirty = value;
                _deductOverwireAmountIndicator.Dirty = value;
                _disableESignConsentAlert.Dirty = value;
                _disableKeyPricingAlert.Dirty = value;
                _discountPoint.Dirty = value;
                _docEngine.Dirty = value;
                _doNotCheckEmail.Dirty = value;
                _doNotPrintCompensationFees.Dirty = value;
                _downPaymentPercent.Dirty = value;
                _eDeliveryVersion.Dirty = value;
                _emXmlVersionId.Dirty = value;
                _encompassId.Dirty = value;
                _encompassVersion.Dirty = value;
                _enforceCountyLoanLimit.Dirty = value;
                _estimatedClosingCostsAmount.Dirty = value;
                _estimatedConstructionInterest.Dirty = value;
                _estimatedPrepaidItemsAmount.Dirty = value;
                _exportLoanNumber.Dirty = value;
                _fhaMiPremiumRefundAmount.Dirty = value;
                _fHAVALoanOriginatorIdentifier.Dirty = value;
                _firstAdjustmentMinimum.Dirty = value;
                _firstSubordinateLienAmount.Dirty = value;
                _firstTimeHomebuyersIndicator.Dirty = value;
                _fnmCommunityLendingProductName.Dirty = value;
                _fnmCommunitySecondsIndicator.Dirty = value;
                _fnmNeighborsMortgageEligibilityIndicator.Dirty = value;
                _fraudScore.Dirty = value;
                _fundingDeductionList.Dirty = value;
                _fundingFeeList.Dirty = value;
                _governmentLoanLenderIdentifier.Dirty = value;
                _governmentLoanSponsorIdentifier.Dirty = value;
                _governmentMortgageCreditCertificateAmount.Dirty = value;
                _hasAbusinessRelationshipWith.Dirty = value;
                _hcltvHtltv.Dirty = value;
                _helocTeaserRate.Dirty = value;
                _homeCounselingProvidersDistance.Dirty = value;
                _homeCounselingProvidersLanguageNames.Dirty = value;
                _homeCounselingProvidersServiceNames.Dirty = value;
                _householdSizeCount.Dirty = value;
                _hudIncomeLimitAdjustmentFactor.Dirty = value;
                _hudLendingIncomeLimitAmount.Dirty = value;
                _hudMedianIncomeAmount.Dirty = value;
                _id.Dirty = value;
                _includeUSDAFeeInClosing.Dirty = value;
                _initialInterestRate.Dirty = value;
                _initialInterestRateUI.Dirty = value;
                _insuranceAuthorizationIndicator.Dirty = value;
                _interviewerApplicationSignedDate.Dirty = value;
                _interviewerEmail.Dirty = value;
                _interviewerLicenseIdentifier.Dirty = value;
                _interviewerPhoneNumber.Dirty = value;
                _interviewersCompanyStateLicense.Dirty = value;
                _interviewersId.Dirty = value;
                _inverviewerName.Dirty = value;
                _isCreditorProhibitsBorrower.Dirty = value;
                _isEmployeeLoan.Dirty = value;
                _isLSSecondaryFile.Dirty = value;
                _isRequiredInterestReserveCompoundInterest.Dirty = value;
                _landIfAcquiredSeperatelyAmount.Dirty = value;
                _leadSource.Dirty = value;
                _lenderCaseIdentifier.Dirty = value;
                _lenderChannel.Dirty = value;
                _lenderCreditsInFunding.Dirty = value;
                _lenderInvestorCode.Dirty = value;
                _lenderPaidClosignCostsDotAmount.Dirty = value;
                _lenderPaidClosingCostsAmount.Dirty = value;
                _lesserAppraisedValueOrSalesPrice.Dirty = value;
                _lifeInsuranceCoverageAmount.Dirty = value;
                _lifeInsuranceEstimatedMonthlyAmount.Dirty = value;
                _lifeInsuranceTotalProtectedMonthlyAmount.Dirty = value;
                _linkedBorrowerRequestedLoanAmount.Dirty = value;
                _linkId.Dirty = value;
                _loanAmortizationTermMonths.Dirty = value;
                _loanAmortizationType.Dirty = value;
                _loanCreatedDate.Dirty = value;
                _loanCreatedDateUtc.Dirty = value;
                _loanIdNumber.Dirty = value;
                _loanImportStatusIndicator.Dirty = value;
                _loanLinkSyncType.Dirty = value;
                _loanNumber.Dirty = value;
                _loanProgramName.Dirty = value;
                _loanPurposeOfRefinanceType.Dirty = value;
                _loanSource.Dirty = value;
                _loanTotalProposedMonthlyMaintenanceAmount.Dirty = value;
                _loanTotalProposedMonthlyUtilitiesAmount.Dirty = value;
                _loanUnderwriterCHUMSIdentifier.Dirty = value;
                _loanVALoanProcedureType.Dirty = value;
                _loanVARateReductionInitialComputationTotalAmount.Dirty = value;
                _loanVAResidualIncomeAmount.Dirty = value;
                _loanVersionId.Dirty = value;
                _ltv.Dirty = value;
                _ltvPropertyValue.Dirty = value;
                _masterCommitmentNumber.Dirty = value;
                _maturityDate.Dirty = value;
                _maxBackRatio.Dirty = value;
                _maxFrontRatio.Dirty = value;
                _mersNumber.Dirty = value;
                _mersNumberRegistrationDate.Dirty = value;
                _miAndFundingFeeFinancedAmount.Dirty = value;
                _miAndFundingFeeTotalAmount.Dirty = value;
                _milestoneApprovedDate.Dirty = value;
                _milestoneApprovedDueDate.Dirty = value;
                _milestoneCompletedDate.Dirty = value;
                _milestoneCompletedDueDate.Dirty = value;
                _milestoneCurrentDateUtc.Dirty = value;
                _milestoneCurrentName.Dirty = value;
                _milestoneDocSignedDate.Dirty = value;
                _milestoneDocSignedDueDate.Dirty = value;
                _milestoneDuration.Dirty = value;
                _milestoneFileStartedDate.Dirty = value;
                _milestoneFundedDate.Dirty = value;
                _milestoneFundedDueDate.Dirty = value;
                _milestoneProcessedDate.Dirty = value;
                _milestoneStage.Dirty = value;
                _milestoneSubmittedDate.Dirty = value;
                _milestoneSubmittedDueDate.Dirty = value;
                _mipBorrowerPaidInCashAmount.Dirty = value;
                _mipPaidInCashAmount.Dirty = value;
                _monthlyPIPaymentAmountForLE1andCD1.Dirty = value;
                _mortgageInsurancePremiumFHARefundAmount.Dirty = value;
                _mortgageInsurancePremiumUpfrontFactorPercent.Dirty = value;
                _mortgageType.Dirty = value;
                _msaIdentifier.Dirty = value;
                _newFirstMortgageAmount.Dirty = value;
                _nmlsLoanOriginatorId.Dirty = value;
                _noClosingCostOption.Dirty = value;
                _notRequiredForPurchaseSaleOrRefinance.Dirty = value;
                _notRequiredForSettlementOfYourLoan.Dirty = value;
                _occupancyType.Dirty = value;
                _openingDocsInvestorCode.Dirty = value;
                _openingDocsLoanProgramType.Dirty = value;
                _openingDocsPlanDescription.Dirty = value;
                _openingDocsPlanId.Dirty = value;
                _openingDocsProgramCode.Dirty = value;
                _openingDocsStackingOrder.Dirty = value;
                _organizationCode.Dirty = value;
                _originationDate.Dirty = value;
                _otherAmortizationTypeDescription.Dirty = value;
                _otherMortgageTypeDescription.Dirty = value;
                _otherPaidClosingCostsAmount.Dirty = value;
                _overwireAmount.Dirty = value;
                _paymentScheduleCalcRequiredIndicator.Dirty = value;
                _percentageOfOwnership.Dirty = value;
                _percentageOwnershipInterest.Dirty = value;
                _pmiIndicator.Dirty = value;
                _principalAndInterestMonthlyPaymentAmount.Dirty = value;
                _print2003Application.Dirty = value;
                _propertyAppraisedValueAmount.Dirty = value;
                _propertyEnergyEfficientHomeIndicator.Dirty = value;
                _propertyEstimatedValueAmount.Dirty = value;
                _proposedDuesAmount.Dirty = value;
                _proposedFirstMortgageAmount.Dirty = value;
                _proposedGroundRentAmount.Dirty = value;
                _proposedHazardInsuranceAmount.Dirty = value;
                _proposedHousingExpenseTotal.Dirty = value;
                _proposedMortgageInsuranceAmount.Dirty = value;
                _proposedOtherAmount.Dirty = value;
                _proposedOtherMortgagesAmount.Dirty = value;
                _proposedRealEstateTaxesAmount.Dirty = value;
                _purchasePriceAmount.Dirty = value;
                _referralAddress.Dirty = value;
                _referralCity.Dirty = value;
                _referralFeeAmount.Dirty = value;
                _referralPostalCode.Dirty = value;
                _referralSource.Dirty = value;
                _referralState.Dirty = value;
                _refinanceIncludingDebtsToBePaidOffAmount.Dirty = value;
                _repurchaseCostAmount.Dirty = value;
                _repurchaseDate.Dirty = value;
                _requestedInterestRatePercent.Dirty = value;
                _requestedInterestRatePercentUI.Dirty = value;
                _salesConcessionAmount.Dirty = value;
                _secondSubordinateAmount.Dirty = value;
                _sectionOfActType.Dirty = value;
                _sellerPaidClosingCostsAmount.Dirty = value;
                _serverDateTimeDDMApplied.Dirty = value;
                _serviceProviderAdditionalInfo.Dirty = value;
                _serviceProviderDateIssued.Dirty = value;
                _setForSettlementServicesOfAnAttorney.Dirty = value;
                _setForTheSettlementServicesListed.Dirty = value;
                _simpleRefinanceType.Dirty = value;
                _startingAdjPrice.Dirty = value;
                _startingAdjRate.Dirty = value;
                _subjectPropertyGrossRentalIncomeAmount.Dirty = value;
                _subjectPropertyOccupancyPercent.Dirty = value;
                _subordinateLienAmount.Dirty = value;
                _systemIdGuid.Dirty = value;
                _tilApplicationDate.Dirty = value;
                _titleHolderName1.Dirty = value;
                _titleHolderName2.Dirty = value;
                _tltv.Dirty = value;
                _totalClosingCostsAmount.Dirty = value;
                _totalDeductionsAmount.Dirty = value;
                _totalFeesCostAmount.Dirty = value;
                _totalFeesCreditAmount.Dirty = value;
                _totalNonborrowerPaidClosingCostsAmount.Dirty = value;
                _totalPaidOutsideClosingAmount.Dirty = value;
                _totalPaidToBrokerAmount.Dirty = value;
                _totalWireTransferAmount.Dirty = value;
                _twelveMonthMortgageRentalHistoryIndicator.Dirty = value;
                _underwritingEscrowIndicator.Dirty = value;
                _undiscountedRate.Dirty = value;
                _unimprovedAppraisedValue.Dirty = value;
                _unimprovedEstimatedValue.Dirty = value;
                _urlPage4Comments.Dirty = value;
                _usdaGovernmentLoanType.Dirty = value;
                _use2018DiIndicator.Dirty = value;
                _useNew2015FormsIndicator.Dirty = value;
                _useNewHudIndicator.Dirty = value;
                _vAEntitlementAmount.Dirty = value;
                _websiteId.Dirty = value;
                if (_additionalRequests != null) _additionalRequests.Dirty = value;
                if (_affiliatedBusinessArrangements != null) _affiliatedBusinessArrangements.Dirty = value;
                if (_applications != null) _applications.Dirty = value;
                if (_aTRQMCommon != null) _aTRQMCommon.Dirty = value;
                if (_closingCost != null) _closingCost.Dirty = value;
                if (_closingDocument != null) _closingDocument.Dirty = value;
                if (_commitmentTerms != null) _commitmentTerms.Dirty = value;
                if (_complianceTestLogs != null) _complianceTestLogs.Dirty = value;
                if (_constructionManagement != null) _constructionManagement.Dirty = value;
                if (_contacts != null) _contacts.Dirty = value;
                if (_conversationLogs != null) _conversationLogs.Dirty = value;
                if (_correspondent != null) _correspondent.Dirty = value;
                if (_crmLogs != null) _crmLogs.Dirty = value;
                if (_currentApplication != null) _currentApplication.Dirty = value;
                if (_customFields != null) _customFields.Dirty = value;
                if (_customModelFields != null) _customModelFields.Dirty = value;
                if (_dataTracLogs != null) _dataTracLogs.Dirty = value;
                if (_disclosureNotices != null) _disclosureNotices.Dirty = value;
                if (_disclosureTracking2015Logs != null) _disclosureTracking2015Logs.Dirty = value;
                if (_disclosureTrackingLogs != null) _disclosureTrackingLogs.Dirty = value;
                if (_documentLogs != null) _documentLogs.Dirty = value;
                if (_documentOrderLogs != null) _documentOrderLogs.Dirty = value;
                if (_downloadLogs != null) _downloadLogs.Dirty = value;
                if (_downPayment != null) _downPayment.Dirty = value;
                if (_edmLogs != null) _edmLogs.Dirty = value;
                if (_emailTriggerLogs != null) _emailTriggerLogs.Dirty = value;
                if (_emDocument != null) _emDocument.Dirty = value;
                if (_emDocumentInvestor != null) _emDocumentInvestor.Dirty = value;
                if (_emDocumentLender != null) _emDocumentLender.Dirty = value;
                if (_fannieMae != null) _fannieMae.Dirty = value;
                if (_fees != null) _fees.Dirty = value;
                if (_fhaVaLoan != null) _fhaVaLoan.Dirty = value;
                if (_fieldLockData != null) _fieldLockData.Dirty = value;
                if (_forms != null) _forms.Dirty = value;
                if (_freddieMac != null) _freddieMac.Dirty = value;
                if (_funding != null) _funding.Dirty = value;
                if (_fundingFees != null) _fundingFees.Dirty = value;
                if (_gfe != null) _gfe.Dirty = value;
                if (_hmda != null) _hmda.Dirty = value;
                if (_homeCounselingProviders != null) _homeCounselingProviders.Dirty = value;
                if (_htmlEmailLogs != null) _htmlEmailLogs.Dirty = value;
                if (_hud1Es != null) _hud1Es.Dirty = value;
                if (_hudLoanData != null) _hudLoanData.Dirty = value;
                if (_interimServicing != null) _interimServicing.Dirty = value;
                if (_loanActionLogs != null) _loanActionLogs.Dirty = value;
                if (_loanProductData != null) _loanProductData.Dirty = value;
                if (_loanPrograms != null) _loanPrograms.Dirty = value;
                if (_loanSubmission != null) _loanSubmission.Dirty = value;
                if (_lockConfirmLogs != null) _lockConfirmLogs.Dirty = value;
                if (_lockDenialLogs != null) _lockDenialLogs.Dirty = value;
                if (_lockRequestLogs != null) _lockRequestLogs.Dirty = value;
                if (_lOCompensation != null) _lOCompensation.Dirty = value;
                if (_logEntryLogs != null) _logEntryLogs.Dirty = value;
                if (_mcaw != null) _mcaw.Dirty = value;
                if (_milestoneFreeRoleLogs != null) _milestoneFreeRoleLogs.Dirty = value;
                if (_milestoneLogs != null) _milestoneLogs.Dirty = value;
                if (_milestoneTaskLogs != null) _milestoneTaskLogs.Dirty = value;
                if (_milestoneTemplateLogs != null) _milestoneTemplateLogs.Dirty = value;
                if (_miscellaneous != null) _miscellaneous.Dirty = value;
                if (_netTangibleBenefit != null) _netTangibleBenefit.Dirty = value;
                if (_nonVols != null) _nonVols.Dirty = value;
                if (_postClosingConditionLogs != null) _postClosingConditionLogs.Dirty = value;
                if (_preliminaryConditionLogs != null) _preliminaryConditionLogs.Dirty = value;
                if (_prequalification != null) _prequalification.Dirty = value;
                if (_printLogs != null) _printLogs.Dirty = value;
                if (_privacyPolicy != null) _privacyPolicy.Dirty = value;
                if (_profitManagement != null) _profitManagement.Dirty = value;
                if (_property != null) _property.Dirty = value;
                if (_purchaseCredits != null) _purchaseCredits.Dirty = value;
                if (_rateLock != null) _rateLock.Dirty = value;
                if (_referralSourceContact != null) _referralSourceContact.Dirty = value;
                if (_registrationLogs != null) _registrationLogs.Dirty = value;
                if (_regulationZ != null) _regulationZ.Dirty = value;
                if (_removedLogRecords != null) _removedLogRecords.Dirty = value;
                if (_section32 != null) _section32.Dirty = value;
                if (_selectedHomeCounselingProvider != null) _selectedHomeCounselingProvider.Dirty = value;
                if (_serviceProviderContacts != null) _serviceProviderContacts.Dirty = value;
                if (_servicingDisclosure != null) _servicingDisclosure.Dirty = value;
                if (_settlementServiceCharges != null) _settlementServiceCharges.Dirty = value;
                if (_shipping != null) _shipping.Dirty = value;
                if (_stateDisclosure != null) _stateDisclosure.Dirty = value;
                if (_statementCreditDenial != null) _statementCreditDenial.Dirty = value;
                if (_statusOnlineLogs != null) _statusOnlineLogs.Dirty = value;
                if (_tPO != null) _tPO.Dirty = value;
                if (_tQL != null) _tQL.Dirty = value;
                if (_trustAccount != null) _trustAccount.Dirty = value;
                if (_tsum != null) _tsum.Dirty = value;
                if (_uldd != null) _uldd.Dirty = value;
                if (_underwriterSummary != null) _underwriterSummary.Dirty = value;
                if (_underwritingConditionLogs != null) _underwritingConditionLogs.Dirty = value;
                if (_usda != null) _usda.Dirty = value;
                if (_vaLoanData != null) _vaLoanData.Dirty = value;
                if (_verificationLogs != null) _verificationLogs.Dirty = value;
            }
        }
    }
}