using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Loan : IClean
    {
        public AdditionalRequests AdditionalRequests { get; set; }
        private Value<DateTime?> _adverseActionDate;
        public DateTime? AdverseActionDate { get { return _adverseActionDate; } set { _adverseActionDate = value; } }
        private Value<List<AffiliatedBusinessArrangement>> _affiliatedBusinessArrangements;
        public List<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get { return _affiliatedBusinessArrangements; } set { _affiliatedBusinessArrangements = value; } }
        private Value<string> _agencyCaseIdentifier;
        public string AgencyCaseIdentifier { get { return _agencyCaseIdentifier; } set { _agencyCaseIdentifier = value; } }
        private Value<decimal?> _alterationsImprovementsOrRepairsAmount;
        public decimal? AlterationsImprovementsOrRepairsAmount { get { return _alterationsImprovementsOrRepairsAmount; } set { _alterationsImprovementsOrRepairsAmount = value; } }
        private Value<List<Application>> _applications;
        public List<Application> Applications { get { return _applications; } set { _applications = value; } }
        private Value<string> _applicationTakenMethodType;
        public string ApplicationTakenMethodType { get { return _applicationTakenMethodType; } set { _applicationTakenMethodType = value; } }
        private Value<DateTime?> _aprDisclosureDate;
        public DateTime? AprDisclosureDate { get { return _aprDisclosureDate; } set { _aprDisclosureDate = value; } }
        private Value<string> _armTypeDescription;
        public string ArmTypeDescription { get { return _armTypeDescription; } set { _armTypeDescription = value; } }
        public ATRQMCommon ATRQMCommon { get; set; }
        private Value<decimal?> _baseLoanAmount;
        public decimal? BaseLoanAmount { get { return _baseLoanAmount; } set { _baseLoanAmount = value; } }
        private Value<bool?> _belowMarketSubordinateFinancingIndicator;
        public bool? BelowMarketSubordinateFinancingIndicator { get { return _belowMarketSubordinateFinancingIndicator; } set { _belowMarketSubordinateFinancingIndicator = value; } }
        private Value<string> _billingCategory;
        public string BillingCategory { get { return _billingCategory; } set { _billingCategory = value; } }
        private Value<decimal?> _biweeklyPaymentAmount;
        public decimal? BiweeklyPaymentAmount { get { return _biweeklyPaymentAmount; } set { _biweeklyPaymentAmount = value; } }
        private Value<int?> _bLTV;
        public int? BLTV { get { return _bLTV; } set { _bLTV = value; } }
        private Value<bool?> _borrowerCoBorrowerMarriedIndicator;
        public bool? BorrowerCoBorrowerMarriedIndicator { get { return _borrowerCoBorrowerMarriedIndicator; } set { _borrowerCoBorrowerMarriedIndicator = value; } }
        private Value<decimal?> _borrowerPaidClosingCostsAmount;
        public decimal? BorrowerPaidClosingCostsAmount { get { return _borrowerPaidClosingCostsAmount; } set { _borrowerPaidClosingCostsAmount = value; } }
        private Value<decimal?> _borrowerPaidDiscountPointsAmount;
        public decimal? BorrowerPaidDiscountPointsAmount { get { return _borrowerPaidDiscountPointsAmount; } set { _borrowerPaidDiscountPointsAmount = value; } }
        private Value<decimal?> _borrowerPaidFHAVAClosingCostsAmount;
        public decimal? BorrowerPaidFHAVAClosingCostsAmount { get { return _borrowerPaidFHAVAClosingCostsAmount; } set { _borrowerPaidFHAVAClosingCostsAmount = value; } }
        private Value<decimal?> _borrowerRequestedLoanAmount;
        public decimal? BorrowerRequestedLoanAmount { get { return _borrowerRequestedLoanAmount; } set { _borrowerRequestedLoanAmount = value; } }
        private Value<decimal?> _brokerPaidClosingCostsAmount;
        public decimal? BrokerPaidClosingCostsAmount { get { return _brokerPaidClosingCostsAmount; } set { _brokerPaidClosingCostsAmount = value; } }
        private Value<bool?> _buydownIndicator;
        public bool? BuydownIndicator { get { return _buydownIndicator; } set { _buydownIndicator = value; } }
        private Value<decimal?> _buydownMonthlyPaymentAmount;
        public decimal? BuydownMonthlyPaymentAmount { get { return _buydownMonthlyPaymentAmount; } set { _buydownMonthlyPaymentAmount = value; } }
        private Value<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get { return _buydownRatePercent; } set { _buydownRatePercent = value; } }
        private Value<decimal?> _cashFromToBorrowerAmount;
        public decimal? CashFromToBorrowerAmount { get { return _cashFromToBorrowerAmount; } set { _cashFromToBorrowerAmount = value; } }
        private Value<string> _channel;
        public string Channel { get { return _channel; } set { _channel = value; } }
        private Value<DateTime?> _closingBillingDate;
        public DateTime? ClosingBillingDate { get { return _closingBillingDate; } set { _closingBillingDate = value; } }
        public ClosingCost ClosingCost { get; set; }
        private Value<string> _closingCostProgram;
        public string ClosingCostProgram { get { return _closingCostProgram; } set { _closingCostProgram = value; } }
        private Value<decimal?> _closingCostsAndPrepaidsFromOtherLienAmount;
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get { return _closingCostsAndPrepaidsFromOtherLienAmount; } set { _closingCostsAndPrepaidsFromOtherLienAmount = value; } }
        private Value<decimal?> _closingCostsPaidByOthersAmount;
        public decimal? ClosingCostsPaidByOthersAmount { get { return _closingCostsPaidByOthersAmount; } set { _closingCostsPaidByOthersAmount = value; } }
        private Value<string> _closingDocsStackingOrder;
        public string ClosingDocsStackingOrder { get { return _closingDocsStackingOrder; } set { _closingDocsStackingOrder = value; } }
        public ClosingDocument ClosingDocument { get; set; }
        private Value<int?> _collateralManagerScore;
        public int? CollateralManagerScore { get { return _collateralManagerScore; } set { _collateralManagerScore = value; } }
        private Value<decimal?> _combinedLtv;
        public decimal? CombinedLtv { get { return _combinedLtv; } set { _combinedLtv = value; } }
        private Value<string> _commitmentNumber;
        public string CommitmentNumber { get { return _commitmentNumber; } set { _commitmentNumber = value; } }
        public CommitmentTerms CommitmentTerms { get; set; }
        private Value<List<ComplianceTestLog>> _complianceTestLogs;
        public List<ComplianceTestLog> ComplianceTestLogs { get { return _complianceTestLogs; } set { _complianceTestLogs = value; } }
        private Value<string> _conformingJumbo;
        public string ConformingJumbo { get { return _conformingJumbo; } set { _conformingJumbo = value; } }
        public ConstructionManagement ConstructionManagement { get; set; }
        private Value<string> _consumerConnectSiteID;
        public string ConsumerConnectSiteID { get { return _consumerConnectSiteID; } set { _consumerConnectSiteID = value; } }
        private Value<List<Contact>> _contacts;
        public List<Contact> Contacts { get { return _contacts; } set { _contacts = value; } }
        private Value<bool?> _contactUpdatedIndicator;
        public bool? ContactUpdatedIndicator { get { return _contactUpdatedIndicator; } set { _contactUpdatedIndicator = value; } }
        private Value<decimal?> _contractSellerCreditAmount;
        public decimal? ContractSellerCreditAmount { get { return _contractSellerCreditAmount; } set { _contractSellerCreditAmount = value; } }
        private Value<List<ConversationLog>> _conversationLogs;
        public List<ConversationLog> ConversationLogs { get { return _conversationLogs; } set { _conversationLogs = value; } }
        private Value<bool?> _copyBrokerToLenderIndicator;
        public bool? CopyBrokerToLenderIndicator { get { return _copyBrokerToLenderIndicator; } set { _copyBrokerToLenderIndicator = value; } }
        private Value<string> _copyLoanNumLenderCaseNum;
        public string CopyLoanNumLenderCaseNum { get { return _copyLoanNumLenderCaseNum; } set { _copyLoanNumLenderCaseNum = value; } }
        public Correspondent Correspondent { get; set; }
        private Value<string> _creditScoreToUse;
        public string CreditScoreToUse { get { return _creditScoreToUse; } set { _creditScoreToUse = value; } }
        private Value<List<CrmLog>> _crmLogs;
        public List<CrmLog> CrmLogs { get { return _crmLogs; } set { _crmLogs = value; } }
        public Application CurrentApplication { get; set; }
        private Value<int?> _currentApplicationIndex;
        public int? CurrentApplicationIndex { get { return _currentApplicationIndex; } set { _currentApplicationIndex = value; } }
        private Value<bool?> _currentApplicationIsPrimary;
        public bool? CurrentApplicationIsPrimary { get { return _currentApplicationIsPrimary; } set { _currentApplicationIsPrimary = value; } }
        private Value<string> _currentFirstMortgageHolderType;
        public string CurrentFirstMortgageHolderType { get { return _currentFirstMortgageHolderType; } set { _currentFirstMortgageHolderType = value; } }
        private Value<List<CustomField>> _customFields;
        public List<CustomField> CustomFields { get { return _customFields; } set { _customFields = value; } }
        public CustomModelFields CustomModelFields { get; set; }
        private Value<List<DataTracLog>> _dataTracLogs;
        public List<DataTracLog> DataTracLogs { get { return _dataTracLogs; } set { _dataTracLogs = value; } }
        private Value<bool?> _dBIndicator;
        public bool? DBIndicator { get { return _dBIndicator; } set { _dBIndicator = value; } }
        private Value<bool?> _deductOverwireAmountIndicator;
        public bool? DeductOverwireAmountIndicator { get { return _deductOverwireAmountIndicator; } set { _deductOverwireAmountIndicator = value; } }
        private Value<bool?> _disableESignConsentAlert;
        public bool? DisableESignConsentAlert { get { return _disableESignConsentAlert; } set { _disableESignConsentAlert = value; } }
        private Value<bool?> _disableKeyPricingAlert;
        public bool? DisableKeyPricingAlert { get { return _disableKeyPricingAlert; } set { _disableKeyPricingAlert = value; } }
        public DisclosureNotices DisclosureNotices { get; set; }
        private Value<List<DisclosureTracking2015Log>> _disclosureTracking2015Logs;
        public List<DisclosureTracking2015Log> DisclosureTracking2015Logs { get { return _disclosureTracking2015Logs; } set { _disclosureTracking2015Logs = value; } }
        private Value<List<DisclosureTrackingLog>> _disclosureTrackingLogs;
        public List<DisclosureTrackingLog> DisclosureTrackingLogs { get { return _disclosureTrackingLogs; } set { _disclosureTrackingLogs = value; } }
        private Value<decimal?> _discountPoint;
        public decimal? DiscountPoint { get { return _discountPoint; } set { _discountPoint = value; } }
        private Value<string> _docEngine;
        public string DocEngine { get { return _docEngine; } set { _docEngine = value; } }
        private Value<List<DocumentLog>> _documentLogs;
        public List<DocumentLog> DocumentLogs { get { return _documentLogs; } set { _documentLogs = value; } }
        private Value<string> _doNotCheckEmail;
        public string DoNotCheckEmail { get { return _doNotCheckEmail; } set { _doNotCheckEmail = value; } }
        private Value<bool?> _doNotPrintCompensationFees;
        public bool? DoNotPrintCompensationFees { get { return _doNotPrintCompensationFees; } set { _doNotPrintCompensationFees = value; } }
        private Value<List<DownloadLog>> _downloadLogs;
        public List<DownloadLog> DownloadLogs { get { return _downloadLogs; } set { _downloadLogs = value; } }
        public DownPayment DownPayment { get; set; }
        private Value<decimal?> _downPaymentPercent;
        public decimal? DownPaymentPercent { get { return _downPaymentPercent; } set { _downPaymentPercent = value; } }
        private Value<List<EdmLog>> _edmLogs;
        public List<EdmLog> EdmLogs { get { return _edmLogs; } set { _edmLogs = value; } }
        private Value<string> _elliUCDFields;
        public string ElliUCDFields { get { return _elliUCDFields; } set { _elliUCDFields = value; } }
        private Value<List<EmailTriggerLog>> _emailTriggerLogs;
        public List<EmailTriggerLog> EmailTriggerLogs { get { return _emailTriggerLogs; } set { _emailTriggerLogs = value; } }
        public EmDocument EmDocument { get; set; }
        public EmDocumentInvestor EmDocumentInvestor { get; set; }
        public EmDocumentLender EmDocumentLender { get; set; }
        private Value<string> _emXmlVersionId;
        public string EmXmlVersionId { get { return _emXmlVersionId; } set { _emXmlVersionId = value; } }
        private Value<string> _encompassId;
        public string EncompassId { get { return _encompassId; } set { _encompassId = value; } }
        private Value<string> _encompassVersion;
        public string EncompassVersion { get { return _encompassVersion; } set { _encompassVersion = value; } }
        private Value<bool?> _enforceCountyLoanLimit;
        public bool? EnforceCountyLoanLimit { get { return _enforceCountyLoanLimit; } set { _enforceCountyLoanLimit = value; } }
        private Value<decimal?> _estimatedClosingCostsAmount;
        public decimal? EstimatedClosingCostsAmount { get { return _estimatedClosingCostsAmount; } set { _estimatedClosingCostsAmount = value; } }
        private Value<decimal?> _estimatedConstructionInterest;
        public decimal? EstimatedConstructionInterest { get { return _estimatedConstructionInterest; } set { _estimatedConstructionInterest = value; } }
        private Value<decimal?> _estimatedPrepaidItemsAmount;
        public decimal? EstimatedPrepaidItemsAmount { get { return _estimatedPrepaidItemsAmount; } set { _estimatedPrepaidItemsAmount = value; } }
        private Value<string> _exportLoanNumber;
        public string ExportLoanNumber { get { return _exportLoanNumber; } set { _exportLoanNumber = value; } }
        public FannieMae FannieMae { get; set; }
        private Value<List<Fee>> _fees;
        public List<Fee> Fees { get { return _fees; } set { _fees = value; } }
        private Value<decimal?> _fhaMiPremiumRefundAmount;
        public decimal? FhaMiPremiumRefundAmount { get { return _fhaMiPremiumRefundAmount; } set { _fhaMiPremiumRefundAmount = value; } }
        public FhaVaLoan FhaVaLoan { get; set; }
        private Value<string> _fHAVALoanOriginatorIdentifier;
        public string FHAVALoanOriginatorIdentifier { get { return _fHAVALoanOriginatorIdentifier; } set { _fHAVALoanOriginatorIdentifier = value; } }
        private Value<List<FieldLockData>> _fieldLockData;
        public List<FieldLockData> FieldLockData { get { return _fieldLockData; } set { _fieldLockData = value; } }
        private Value<decimal?> _firstAdjustmentMinimum;
        public decimal? FirstAdjustmentMinimum { get { return _firstAdjustmentMinimum; } set { _firstAdjustmentMinimum = value; } }
        private Value<decimal?> _firstSubordinateLienAmount;
        public decimal? FirstSubordinateLienAmount { get { return _firstSubordinateLienAmount; } set { _firstSubordinateLienAmount = value; } }
        private Value<bool?> _firstTimeHomebuyersIndicator;
        public bool? FirstTimeHomebuyersIndicator { get { return _firstTimeHomebuyersIndicator; } set { _firstTimeHomebuyersIndicator = value; } }
        private Value<string> _fnmCommunityLendingProductName;
        public string FnmCommunityLendingProductName { get { return _fnmCommunityLendingProductName; } set { _fnmCommunityLendingProductName = value; } }
        private Value<bool?> _fnmCommunitySecondsIndicator;
        public bool? FnmCommunitySecondsIndicator { get { return _fnmCommunitySecondsIndicator; } set { _fnmCommunitySecondsIndicator = value; } }
        private Value<bool?> _fnmNeighborsMortgageEligibilityIndicator;
        public bool? FnmNeighborsMortgageEligibilityIndicator { get { return _fnmNeighborsMortgageEligibilityIndicator; } set { _fnmNeighborsMortgageEligibilityIndicator = value; } }
        private Value<List<Form>> _forms;
        public List<Form> Forms { get { return _forms; } set { _forms = value; } }
        private Value<int?> _fraudScore;
        public int? FraudScore { get { return _fraudScore; } set { _fraudScore = value; } }
        public FreddieMac FreddieMac { get; set; }
        public Funding Funding { get; set; }
        private Value<string> _fundingDeductionList;
        public string FundingDeductionList { get { return _fundingDeductionList; } set { _fundingDeductionList = value; } }
        private Value<string> _fundingFeeList;
        public string FundingFeeList { get { return _fundingFeeList; } set { _fundingFeeList = value; } }
        private Value<List<FundingFee>> _fundingFees;
        public List<FundingFee> FundingFees { get { return _fundingFees; } set { _fundingFees = value; } }
        public Gfe Gfe { get; set; }
        private Value<string> _governmentLoanLenderIdentifier;
        public string GovernmentLoanLenderIdentifier { get { return _governmentLoanLenderIdentifier; } set { _governmentLoanLenderIdentifier = value; } }
        private Value<string> _governmentLoanSponsorIdentifier;
        public string GovernmentLoanSponsorIdentifier { get { return _governmentLoanSponsorIdentifier; } set { _governmentLoanSponsorIdentifier = value; } }
        private Value<decimal?> _governmentMortgageCreditCertificateAmount;
        public decimal? GovernmentMortgageCreditCertificateAmount { get { return _governmentMortgageCreditCertificateAmount; } set { _governmentMortgageCreditCertificateAmount = value; } }
        private Value<string> _hasAbusinessRelationshipWith;
        public string HasAbusinessRelationshipWith { get { return _hasAbusinessRelationshipWith; } set { _hasAbusinessRelationshipWith = value; } }
        private Value<decimal?> _hcltvHtltv;
        public decimal? HcltvHtltv { get { return _hcltvHtltv; } set { _hcltvHtltv = value; } }
        private Value<decimal?> _helocTeaserRate;
        public decimal? HelocTeaserRate { get { return _helocTeaserRate; } set { _helocTeaserRate = value; } }
        public Hmda Hmda { get; set; }
        private Value<List<HomeCounselingProvider>> _homeCounselingProviders;
        public List<HomeCounselingProvider> HomeCounselingProviders { get { return _homeCounselingProviders; } set { _homeCounselingProviders = value; } }
        private Value<string> _homeCounselingProvidersDistance;
        public string HomeCounselingProvidersDistance { get { return _homeCounselingProvidersDistance; } set { _homeCounselingProvidersDistance = value; } }
        private Value<string> _homeCounselingProvidersLanguageNames;
        public string HomeCounselingProvidersLanguageNames { get { return _homeCounselingProvidersLanguageNames; } set { _homeCounselingProvidersLanguageNames = value; } }
        private Value<string> _homeCounselingProvidersServiceNames;
        public string HomeCounselingProvidersServiceNames { get { return _homeCounselingProvidersServiceNames; } set { _homeCounselingProvidersServiceNames = value; } }
        private Value<int?> _householdSizeCount;
        public int? HouseholdSizeCount { get { return _householdSizeCount; } set { _householdSizeCount = value; } }
        private Value<List<HtmlEmailLog>> _htmlEmailLogs;
        public List<HtmlEmailLog> HtmlEmailLogs { get { return _htmlEmailLogs; } set { _htmlEmailLogs = value; } }
        public Hud1Es Hud1Es { get; set; }
        private Value<decimal?> _hudIncomeLimitAdjustmentFactor;
        public decimal? HudIncomeLimitAdjustmentFactor { get { return _hudIncomeLimitAdjustmentFactor; } set { _hudIncomeLimitAdjustmentFactor = value; } }
        private Value<decimal?> _hudLendingIncomeLimitAmount;
        public decimal? HudLendingIncomeLimitAmount { get { return _hudLendingIncomeLimitAmount; } set { _hudLendingIncomeLimitAmount = value; } }
        public HudLoanData HudLoanData { get; set; }
        private Value<decimal?> _hudMedianIncomeAmount;
        public decimal? HudMedianIncomeAmount { get { return _hudMedianIncomeAmount; } set { _hudMedianIncomeAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _includeUSDAFeeInClosing;
        public bool? IncludeUSDAFeeInClosing { get { return _includeUSDAFeeInClosing; } set { _includeUSDAFeeInClosing = value; } }
        private Value<decimal?> _initialInterestRate;
        public decimal? InitialInterestRate { get { return _initialInterestRate; } set { _initialInterestRate = value; } }
        private Value<string> _insuranceAuthorizationIndicator;
        public string InsuranceAuthorizationIndicator { get { return _insuranceAuthorizationIndicator; } set { _insuranceAuthorizationIndicator = value; } }
        public InterimServicing InterimServicing { get; set; }
        private Value<DateTime?> _interviewerApplicationSignedDate;
        public DateTime? InterviewerApplicationSignedDate { get { return _interviewerApplicationSignedDate; } set { _interviewerApplicationSignedDate = value; } }
        private Value<string> _interviewerEmail;
        public string InterviewerEmail { get { return _interviewerEmail; } set { _interviewerEmail = value; } }
        private Value<string> _interviewerLicenseIdentifier;
        public string InterviewerLicenseIdentifier { get { return _interviewerLicenseIdentifier; } set { _interviewerLicenseIdentifier = value; } }
        private Value<string> _interviewerPhoneNumber;
        public string InterviewerPhoneNumber { get { return _interviewerPhoneNumber; } set { _interviewerPhoneNumber = value; } }
        private Value<string> _interviewersCompanyStateLicense;
        public string InterviewersCompanyStateLicense { get { return _interviewersCompanyStateLicense; } set { _interviewersCompanyStateLicense = value; } }
        private Value<string> _interviewersId;
        public string InterviewersId { get { return _interviewersId; } set { _interviewersId = value; } }
        private Value<string> _inverviewerName;
        public string InverviewerName { get { return _inverviewerName; } set { _inverviewerName = value; } }
        private Value<bool?> _isCreditorProhibitsBorrower;
        public bool? IsCreditorProhibitsBorrower { get { return _isCreditorProhibitsBorrower; } set { _isCreditorProhibitsBorrower = value; } }
        private Value<bool?> _isEmployeeLoan;
        public bool? IsEmployeeLoan { get { return _isEmployeeLoan; } set { _isEmployeeLoan = value; } }
        private Value<bool?> _isLSSecondaryFile;
        public bool? IsLSSecondaryFile { get { return _isLSSecondaryFile; } set { _isLSSecondaryFile = value; } }
        private Value<bool?> _isRequiredInterestReserveCompoundInterest;
        public bool? IsRequiredInterestReserveCompoundInterest { get { return _isRequiredInterestReserveCompoundInterest; } set { _isRequiredInterestReserveCompoundInterest = value; } }
        private Value<decimal?> _landIfAcquiredSeperatelyAmount;
        public decimal? LandIfAcquiredSeperatelyAmount { get { return _landIfAcquiredSeperatelyAmount; } set { _landIfAcquiredSeperatelyAmount = value; } }
        private Value<string> _leadSource;
        public string LeadSource { get { return _leadSource; } set { _leadSource = value; } }
        private Value<string> _lenderCaseIdentifier;
        public string LenderCaseIdentifier { get { return _lenderCaseIdentifier; } set { _lenderCaseIdentifier = value; } }
        private Value<string> _lenderChannel;
        public string LenderChannel { get { return _lenderChannel; } set { _lenderChannel = value; } }
        private Value<decimal?> _lenderCreditsInFunding;
        public decimal? LenderCreditsInFunding { get { return _lenderCreditsInFunding; } set { _lenderCreditsInFunding = value; } }
        private Value<string> _lenderInvestorCode;
        public string LenderInvestorCode { get { return _lenderInvestorCode; } set { _lenderInvestorCode = value; } }
        private Value<decimal?> _lenderPaidClosignCostsDotAmount;
        public decimal? LenderPaidClosignCostsDotAmount { get { return _lenderPaidClosignCostsDotAmount; } set { _lenderPaidClosignCostsDotAmount = value; } }
        private Value<decimal?> _lenderPaidClosingCostsAmount;
        public decimal? LenderPaidClosingCostsAmount { get { return _lenderPaidClosingCostsAmount; } set { _lenderPaidClosingCostsAmount = value; } }
        private Value<decimal?> _lesserAppraisedValueOrSalesPrice;
        public decimal? LesserAppraisedValueOrSalesPrice { get { return _lesserAppraisedValueOrSalesPrice; } set { _lesserAppraisedValueOrSalesPrice = value; } }
        private Value<decimal?> _lifeInsuranceCoverageAmount;
        public decimal? LifeInsuranceCoverageAmount { get { return _lifeInsuranceCoverageAmount; } set { _lifeInsuranceCoverageAmount = value; } }
        private Value<decimal?> _lifeInsuranceEstimatedMonthlyAmount;
        public decimal? LifeInsuranceEstimatedMonthlyAmount { get { return _lifeInsuranceEstimatedMonthlyAmount; } set { _lifeInsuranceEstimatedMonthlyAmount = value; } }
        private Value<decimal?> _lifeInsuranceTotalProtectedMonthlyAmount;
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get { return _lifeInsuranceTotalProtectedMonthlyAmount; } set { _lifeInsuranceTotalProtectedMonthlyAmount = value; } }
        private Value<string> _linkId;
        public string LinkId { get { return _linkId; } set { _linkId = value; } }
        private Value<List<LoanActionLog>> _loanActionLogs;
        public List<LoanActionLog> LoanActionLogs { get { return _loanActionLogs; } set { _loanActionLogs = value; } }
        private Value<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get { return _loanAmortizationTermMonths; } set { _loanAmortizationTermMonths = value; } }
        private Value<string> _loanAmortizationType;
        public string LoanAmortizationType { get { return _loanAmortizationType; } set { _loanAmortizationType = value; } }
        private Value<string> _loanCreatedDate;
        public string LoanCreatedDate { get { return _loanCreatedDate; } set { _loanCreatedDate = value; } }
        private Value<DateTime?> _loanCreatedDateUtc;
        public DateTime? LoanCreatedDateUtc { get { return _loanCreatedDateUtc; } set { _loanCreatedDateUtc = value; } }
        private Value<string> _loanIdNumber;
        public string LoanIdNumber { get { return _loanIdNumber; } set { _loanIdNumber = value; } }
        private Value<bool?> _loanImportStatusIndicator;
        public bool? LoanImportStatusIndicator { get { return _loanImportStatusIndicator; } set { _loanImportStatusIndicator = value; } }
        private Value<string> _loanLinkSyncType;
        public string LoanLinkSyncType { get { return _loanLinkSyncType; } set { _loanLinkSyncType = value; } }
        private Value<string> _loanNumber;
        public string LoanNumber { get { return _loanNumber; } set { _loanNumber = value; } }
        public LoanProductData LoanProductData { get; set; }
        private Value<string> _loanProgramName;
        public string LoanProgramName { get { return _loanProgramName; } set { _loanProgramName = value; } }
        private Value<List<LoanProgram>> _loanPrograms;
        public List<LoanProgram> LoanPrograms { get { return _loanPrograms; } set { _loanPrograms = value; } }
        private Value<string> _loanPurposeOfRefinanceType;
        public string LoanPurposeOfRefinanceType { get { return _loanPurposeOfRefinanceType; } set { _loanPurposeOfRefinanceType = value; } }
        private Value<string> _loanSource;
        public string LoanSource { get { return _loanSource; } set { _loanSource = value; } }
        public LoanSubmission LoanSubmission { get; set; }
        private Value<decimal?> _loanTotalProposedMonthlyMaintenanceAmount;
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get { return _loanTotalProposedMonthlyMaintenanceAmount; } set { _loanTotalProposedMonthlyMaintenanceAmount = value; } }
        private Value<decimal?> _loanTotalProposedMonthlyUtilitiesAmount;
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get { return _loanTotalProposedMonthlyUtilitiesAmount; } set { _loanTotalProposedMonthlyUtilitiesAmount = value; } }
        private Value<string> _loanUnderwriterCHUMSIdentifier;
        public string LoanUnderwriterCHUMSIdentifier { get { return _loanUnderwriterCHUMSIdentifier; } set { _loanUnderwriterCHUMSIdentifier = value; } }
        private Value<string> _loanVALoanProcedureType;
        public string LoanVALoanProcedureType { get { return _loanVALoanProcedureType; } set { _loanVALoanProcedureType = value; } }
        private Value<decimal?> _loanVARateReductionInitialComputationTotalAmount;
        public decimal? LoanVARateReductionInitialComputationTotalAmount { get { return _loanVARateReductionInitialComputationTotalAmount; } set { _loanVARateReductionInitialComputationTotalAmount = value; } }
        private Value<decimal?> _loanVAResidualIncomeAmount;
        public decimal? LoanVAResidualIncomeAmount { get { return _loanVAResidualIncomeAmount; } set { _loanVAResidualIncomeAmount = value; } }
        private Value<int?> _loanVersionId;
        public int? LoanVersionId { get { return _loanVersionId; } set { _loanVersionId = value; } }
        private Value<List<LockConfirmLog>> _lockConfirmLogs;
        public List<LockConfirmLog> LockConfirmLogs { get { return _lockConfirmLogs; } set { _lockConfirmLogs = value; } }
        private Value<List<LockDenialLog>> _lockDenialLogs;
        public List<LockDenialLog> LockDenialLogs { get { return _lockDenialLogs; } set { _lockDenialLogs = value; } }
        private Value<List<LockRequestLog>> _lockRequestLogs;
        public List<LockRequestLog> LockRequestLogs { get { return _lockRequestLogs; } set { _lockRequestLogs = value; } }
        public ElliLOCompensation LOCompensation { get; set; }
        private Value<List<LogEntryLog>> _logEntryLogs;
        public List<LogEntryLog> LogEntryLogs { get { return _logEntryLogs; } set { _logEntryLogs = value; } }
        private Value<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        private Value<decimal?> _ltvPropertyValue;
        public decimal? LtvPropertyValue { get { return _ltvPropertyValue; } set { _ltvPropertyValue = value; } }
        private Value<string> _masterCommitmentNumber;
        public string MasterCommitmentNumber { get { return _masterCommitmentNumber; } set { _masterCommitmentNumber = value; } }
        private Value<DateTime?> _maturityDate;
        public DateTime? MaturityDate { get { return _maturityDate; } set { _maturityDate = value; } }
        private Value<decimal?> _maxBackRatio;
        public decimal? MaxBackRatio { get { return _maxBackRatio; } set { _maxBackRatio = value; } }
        private Value<decimal?> _maxFrontRatio;
        public decimal? MaxFrontRatio { get { return _maxFrontRatio; } set { _maxFrontRatio = value; } }
        public Mcaw Mcaw { get; set; }
        private Value<string> _mersNumber;
        public string MersNumber { get { return _mersNumber; } set { _mersNumber = value; } }
        private Value<DateTime?> _mersNumberRegistrationDate;
        public DateTime? MersNumberRegistrationDate { get { return _mersNumberRegistrationDate; } set { _mersNumberRegistrationDate = value; } }
        private Value<decimal?> _miAndFundingFeeFinancedAmount;
        public decimal? MiAndFundingFeeFinancedAmount { get { return _miAndFundingFeeFinancedAmount; } set { _miAndFundingFeeFinancedAmount = value; } }
        private Value<decimal?> _miAndFundingFeeTotalAmount;
        public decimal? MiAndFundingFeeTotalAmount { get { return _miAndFundingFeeTotalAmount; } set { _miAndFundingFeeTotalAmount = value; } }
        private Value<DateTime?> _milestoneApprovedDate;
        public DateTime? MilestoneApprovedDate { get { return _milestoneApprovedDate; } set { _milestoneApprovedDate = value; } }
        private Value<DateTime?> _milestoneApprovedDueDate;
        public DateTime? MilestoneApprovedDueDate { get { return _milestoneApprovedDueDate; } set { _milestoneApprovedDueDate = value; } }
        private Value<DateTime?> _milestoneCompletedDate;
        public DateTime? MilestoneCompletedDate { get { return _milestoneCompletedDate; } set { _milestoneCompletedDate = value; } }
        private Value<DateTime?> _milestoneCompletedDueDate;
        public DateTime? MilestoneCompletedDueDate { get { return _milestoneCompletedDueDate; } set { _milestoneCompletedDueDate = value; } }
        private Value<DateTime?> _milestoneCurrentDateUtc;
        public DateTime? MilestoneCurrentDateUtc { get { return _milestoneCurrentDateUtc; } set { _milestoneCurrentDateUtc = value; } }
        private Value<string> _milestoneCurrentName;
        public string MilestoneCurrentName { get { return _milestoneCurrentName; } set { _milestoneCurrentName = value; } }
        private Value<DateTime?> _milestoneDocSignedDate;
        public DateTime? MilestoneDocSignedDate { get { return _milestoneDocSignedDate; } set { _milestoneDocSignedDate = value; } }
        private Value<DateTime?> _milestoneDocSignedDueDate;
        public DateTime? MilestoneDocSignedDueDate { get { return _milestoneDocSignedDueDate; } set { _milestoneDocSignedDueDate = value; } }
        private Value<int?> _milestoneDuration;
        public int? MilestoneDuration { get { return _milestoneDuration; } set { _milestoneDuration = value; } }
        private Value<DateTime?> _milestoneFileStartedDate;
        public DateTime? MilestoneFileStartedDate { get { return _milestoneFileStartedDate; } set { _milestoneFileStartedDate = value; } }
        private Value<List<MilestoneFreeRoleLog>> _milestoneFreeRoleLogs;
        public List<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get { return _milestoneFreeRoleLogs; } set { _milestoneFreeRoleLogs = value; } }
        private Value<DateTime?> _milestoneFundedDate;
        public DateTime? MilestoneFundedDate { get { return _milestoneFundedDate; } set { _milestoneFundedDate = value; } }
        private Value<DateTime?> _milestoneFundedDueDate;
        public DateTime? MilestoneFundedDueDate { get { return _milestoneFundedDueDate; } set { _milestoneFundedDueDate = value; } }
        private Value<List<MilestoneLog>> _milestoneLogs;
        public List<MilestoneLog> MilestoneLogs { get { return _milestoneLogs; } set { _milestoneLogs = value; } }
        private Value<DateTime?> _milestoneProcessedDate;
        public DateTime? MilestoneProcessedDate { get { return _milestoneProcessedDate; } set { _milestoneProcessedDate = value; } }
        private Value<string> _milestoneStage;
        public string MilestoneStage { get { return _milestoneStage; } set { _milestoneStage = value; } }
        private Value<DateTime?> _milestoneSubmittedDate;
        public DateTime? MilestoneSubmittedDate { get { return _milestoneSubmittedDate; } set { _milestoneSubmittedDate = value; } }
        private Value<DateTime?> _milestoneSubmittedDueDate;
        public DateTime? MilestoneSubmittedDueDate { get { return _milestoneSubmittedDueDate; } set { _milestoneSubmittedDueDate = value; } }
        private Value<List<MilestoneTaskLog>> _milestoneTaskLogs;
        public List<MilestoneTaskLog> MilestoneTaskLogs { get { return _milestoneTaskLogs; } set { _milestoneTaskLogs = value; } }
        private Value<List<MilestoneTemplateLog>> _milestoneTemplateLogs;
        public List<MilestoneTemplateLog> MilestoneTemplateLogs { get { return _milestoneTemplateLogs; } set { _milestoneTemplateLogs = value; } }
        private Value<decimal?> _mipBorrowerPaidInCashAmount;
        public decimal? MipBorrowerPaidInCashAmount { get { return _mipBorrowerPaidInCashAmount; } set { _mipBorrowerPaidInCashAmount = value; } }
        private Value<decimal?> _mipPaidInCashAmount;
        public decimal? MipPaidInCashAmount { get { return _mipPaidInCashAmount; } set { _mipPaidInCashAmount = value; } }
        public Miscellaneous Miscellaneous { get; set; }
        private Value<decimal?> _monthlyPIPaymentAmountForLE1andCD1;
        public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get { return _monthlyPIPaymentAmountForLE1andCD1; } set { _monthlyPIPaymentAmountForLE1andCD1 = value; } }
        private Value<decimal?> _mortgageInsurancePremiumFHARefundAmount;
        public decimal? MortgageInsurancePremiumFHARefundAmount { get { return _mortgageInsurancePremiumFHARefundAmount; } set { _mortgageInsurancePremiumFHARefundAmount = value; } }
        private Value<decimal?> _mortgageInsurancePremiumUpfrontFactorPercent;
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get { return _mortgageInsurancePremiumUpfrontFactorPercent; } set { _mortgageInsurancePremiumUpfrontFactorPercent = value; } }
        private Value<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        private Value<string> _msaIdentifier;
        public string MsaIdentifier { get { return _msaIdentifier; } set { _msaIdentifier = value; } }
        public NetTangibleBenefit NetTangibleBenefit { get; set; }
        private Value<decimal?> _newFirstMortgageAmount;
        public decimal? NewFirstMortgageAmount { get { return _newFirstMortgageAmount; } set { _newFirstMortgageAmount = value; } }
        private Value<string> _nmlsLoanOriginatorId;
        public string NmlsLoanOriginatorId { get { return _nmlsLoanOriginatorId; } set { _nmlsLoanOriginatorId = value; } }
        private Value<bool?> _noClosingCostOption;
        public bool? NoClosingCostOption { get { return _noClosingCostOption; } set { _noClosingCostOption = value; } }
        private Value<bool?> _notRequiredForPurchaseSaleOrRefinance;
        public bool? NotRequiredForPurchaseSaleOrRefinance { get { return _notRequiredForPurchaseSaleOrRefinance; } set { _notRequiredForPurchaseSaleOrRefinance = value; } }
        private Value<bool?> _notRequiredForSettlementOfYourLoan;
        public bool? NotRequiredForSettlementOfYourLoan { get { return _notRequiredForSettlementOfYourLoan; } set { _notRequiredForSettlementOfYourLoan = value; } }
        private Value<string> _occupancyType;
        public string OccupancyType { get { return _occupancyType; } set { _occupancyType = value; } }
        private Value<string> _openingDocsInvestorCode;
        public string OpeningDocsInvestorCode { get { return _openingDocsInvestorCode; } set { _openingDocsInvestorCode = value; } }
        private Value<string> _openingDocsLoanProgramType;
        public string OpeningDocsLoanProgramType { get { return _openingDocsLoanProgramType; } set { _openingDocsLoanProgramType = value; } }
        private Value<string> _openingDocsPlanDescription;
        public string OpeningDocsPlanDescription { get { return _openingDocsPlanDescription; } set { _openingDocsPlanDescription = value; } }
        private Value<string> _openingDocsPlanId;
        public string OpeningDocsPlanId { get { return _openingDocsPlanId; } set { _openingDocsPlanId = value; } }
        private Value<string> _openingDocsProgramCode;
        public string OpeningDocsProgramCode { get { return _openingDocsProgramCode; } set { _openingDocsProgramCode = value; } }
        private Value<string> _openingDocsStackingOrder;
        public string OpeningDocsStackingOrder { get { return _openingDocsStackingOrder; } set { _openingDocsStackingOrder = value; } }
        private Value<string> _organizationCode;
        public string OrganizationCode { get { return _organizationCode; } set { _organizationCode = value; } }
        private Value<DateTime?> _originationDate;
        public DateTime? OriginationDate { get { return _originationDate; } set { _originationDate = value; } }
        private Value<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get { return _otherAmortizationTypeDescription; } set { _otherAmortizationTypeDescription = value; } }
        private Value<string> _otherMortgageTypeDescription;
        public string OtherMortgageTypeDescription { get { return _otherMortgageTypeDescription; } set { _otherMortgageTypeDescription = value; } }
        private Value<decimal?> _otherPaidClosingCostsAmount;
        public decimal? OtherPaidClosingCostsAmount { get { return _otherPaidClosingCostsAmount; } set { _otherPaidClosingCostsAmount = value; } }
        private Value<decimal?> _overwireAmount;
        public decimal? OverwireAmount { get { return _overwireAmount; } set { _overwireAmount = value; } }
        private Value<bool?> _paymentScheduleCalcRequiredIndicator;
        public bool? PaymentScheduleCalcRequiredIndicator { get { return _paymentScheduleCalcRequiredIndicator; } set { _paymentScheduleCalcRequiredIndicator = value; } }
        private Value<string> _percentageOfOwnership;
        public string PercentageOfOwnership { get { return _percentageOfOwnership; } set { _percentageOfOwnership = value; } }
        private Value<decimal?> _percentageOwnershipInterest;
        public decimal? PercentageOwnershipInterest { get { return _percentageOwnershipInterest; } set { _percentageOwnershipInterest = value; } }
        private Value<bool?> _pmiIndicator;
        public bool? PmiIndicator { get { return _pmiIndicator; } set { _pmiIndicator = value; } }
        private Value<List<PostClosingConditionLog>> _postClosingConditionLogs;
        public List<PostClosingConditionLog> PostClosingConditionLogs { get { return _postClosingConditionLogs; } set { _postClosingConditionLogs = value; } }
        private Value<List<PreliminaryConditionLog>> _preliminaryConditionLogs;
        public List<PreliminaryConditionLog> PreliminaryConditionLogs { get { return _preliminaryConditionLogs; } set { _preliminaryConditionLogs = value; } }
        public Prequalification Prequalification { get; set; }
        private Value<decimal?> _principalAndInterestMonthlyPaymentAmount;
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get { return _principalAndInterestMonthlyPaymentAmount; } set { _principalAndInterestMonthlyPaymentAmount = value; } }
        private Value<string> _print2003Application;
        public string Print2003Application { get { return _print2003Application; } set { _print2003Application = value; } }
        private Value<List<PrintLog>> _printLogs;
        public List<PrintLog> PrintLogs { get { return _printLogs; } set { _printLogs = value; } }
        public PrivacyPolicy PrivacyPolicy { get; set; }
        public ProfitManagement ProfitManagement { get; set; }
        public Property Property { get; set; }
        private Value<int?> _propertyAppraisedValueAmount;
        public int? PropertyAppraisedValueAmount { get { return _propertyAppraisedValueAmount; } set { _propertyAppraisedValueAmount = value; } }
        private Value<bool?> _propertyEnergyEfficientHomeIndicator;
        public bool? PropertyEnergyEfficientHomeIndicator { get { return _propertyEnergyEfficientHomeIndicator; } set { _propertyEnergyEfficientHomeIndicator = value; } }
        private Value<int?> _propertyEstimatedValueAmount;
        public int? PropertyEstimatedValueAmount { get { return _propertyEstimatedValueAmount; } set { _propertyEstimatedValueAmount = value; } }
        private Value<string> _proposedDuesAmount;
        public string ProposedDuesAmount { get { return _proposedDuesAmount; } set { _proposedDuesAmount = value; } }
        private Value<decimal?> _proposedFirstMortgageAmount;
        public decimal? ProposedFirstMortgageAmount { get { return _proposedFirstMortgageAmount; } set { _proposedFirstMortgageAmount = value; } }
        private Value<decimal?> _proposedGroundRentAmount;
        public decimal? ProposedGroundRentAmount { get { return _proposedGroundRentAmount; } set { _proposedGroundRentAmount = value; } }
        private Value<string> _proposedHazardInsuranceAmount;
        public string ProposedHazardInsuranceAmount { get { return _proposedHazardInsuranceAmount; } set { _proposedHazardInsuranceAmount = value; } }
        private Value<decimal?> _proposedHousingExpenseTotal;
        public decimal? ProposedHousingExpenseTotal { get { return _proposedHousingExpenseTotal; } set { _proposedHousingExpenseTotal = value; } }
        private Value<string> _proposedMortgageInsuranceAmount;
        public string ProposedMortgageInsuranceAmount { get { return _proposedMortgageInsuranceAmount; } set { _proposedMortgageInsuranceAmount = value; } }
        private Value<decimal?> _proposedOtherAmount;
        public decimal? ProposedOtherAmount { get { return _proposedOtherAmount; } set { _proposedOtherAmount = value; } }
        private Value<decimal?> _proposedOtherMortgagesAmount;
        public decimal? ProposedOtherMortgagesAmount { get { return _proposedOtherMortgagesAmount; } set { _proposedOtherMortgagesAmount = value; } }
        private Value<string> _proposedRealEstateTaxesAmount;
        public string ProposedRealEstateTaxesAmount { get { return _proposedRealEstateTaxesAmount; } set { _proposedRealEstateTaxesAmount = value; } }
        private Value<List<PurchaseCredit>> _purchaseCredits;
        public List<PurchaseCredit> PurchaseCredits { get { return _purchaseCredits; } set { _purchaseCredits = value; } }
        private Value<decimal?> _purchasePriceAmount;
        public decimal? PurchasePriceAmount { get { return _purchasePriceAmount; } set { _purchasePriceAmount = value; } }
        public RateLock RateLock { get; set; }
        private Value<string> _referralAddress;
        public string ReferralAddress { get { return _referralAddress; } set { _referralAddress = value; } }
        private Value<string> _referralCity;
        public string ReferralCity { get { return _referralCity; } set { _referralCity = value; } }
        private Value<decimal?> _referralFeeAmount;
        public decimal? ReferralFeeAmount { get { return _referralFeeAmount; } set { _referralFeeAmount = value; } }
        private Value<string> _referralPostalCode;
        public string ReferralPostalCode { get { return _referralPostalCode; } set { _referralPostalCode = value; } }
        private Value<string> _referralSource;
        public string ReferralSource { get { return _referralSource; } set { _referralSource = value; } }
        private Value<string> _referralState;
        public string ReferralState { get { return _referralState; } set { _referralState = value; } }
        private Value<decimal?> _refinanceIncludingDebtsToBePaidOffAmount;
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get { return _refinanceIncludingDebtsToBePaidOffAmount; } set { _refinanceIncludingDebtsToBePaidOffAmount = value; } }
        private Value<List<RegistrationLog>> _registrationLogs;
        public List<RegistrationLog> RegistrationLogs { get { return _registrationLogs; } set { _registrationLogs = value; } }
        public RegulationZ RegulationZ { get; set; }
        private Value<List<RemovedLogRecord>> _removedLogRecords;
        public List<RemovedLogRecord> RemovedLogRecords { get { return _removedLogRecords; } set { _removedLogRecords = value; } }
        private Value<decimal?> _repurchaseCostAmount;
        public decimal? RepurchaseCostAmount { get { return _repurchaseCostAmount; } set { _repurchaseCostAmount = value; } }
        private Value<DateTime?> _repurchaseDate;
        public DateTime? RepurchaseDate { get { return _repurchaseDate; } set { _repurchaseDate = value; } }
        private Value<decimal?> _requestedInterestRatePercent;
        public decimal? RequestedInterestRatePercent { get { return _requestedInterestRatePercent; } set { _requestedInterestRatePercent = value; } }
        private Value<decimal?> _salesConcessionAmount;
        public decimal? SalesConcessionAmount { get { return _salesConcessionAmount; } set { _salesConcessionAmount = value; } }
        private Value<decimal?> _secondSubordinateAmount;
        public decimal? SecondSubordinateAmount { get { return _secondSubordinateAmount; } set { _secondSubordinateAmount = value; } }
        public Section32 Section32 { get; set; }
        private Value<string> _sectionOfActType;
        public string SectionOfActType { get { return _sectionOfActType; } set { _sectionOfActType = value; } }
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get; set; }
        private Value<decimal?> _sellerPaidClosingCostsAmount;
        public decimal? SellerPaidClosingCostsAmount { get { return _sellerPaidClosingCostsAmount; } set { _sellerPaidClosingCostsAmount = value; } }
        private Value<string> _serviceProviderAdditionalInfo;
        public string ServiceProviderAdditionalInfo { get { return _serviceProviderAdditionalInfo; } set { _serviceProviderAdditionalInfo = value; } }
        private Value<List<ServiceProviderContact>> _serviceProviderContacts;
        public List<ServiceProviderContact> ServiceProviderContacts { get { return _serviceProviderContacts; } set { _serviceProviderContacts = value; } }
        private Value<DateTime?> _serviceProviderDateIssued;
        public DateTime? ServiceProviderDateIssued { get { return _serviceProviderDateIssued; } set { _serviceProviderDateIssued = value; } }
        public ServicingDisclosure ServicingDisclosure { get; set; }
        private Value<bool?> _setForSettlementServicesOfAnAttorney;
        public bool? SetForSettlementServicesOfAnAttorney { get { return _setForSettlementServicesOfAnAttorney; } set { _setForSettlementServicesOfAnAttorney = value; } }
        private Value<bool?> _setForTheSettlementServicesListed;
        public bool? SetForTheSettlementServicesListed { get { return _setForTheSettlementServicesListed; } set { _setForTheSettlementServicesListed = value; } }
        private Value<List<SettlementServiceCharge>> _settlementServiceCharges;
        public List<SettlementServiceCharge> SettlementServiceCharges { get { return _settlementServiceCharges; } set { _settlementServiceCharges = value; } }
        public Shipping Shipping { get; set; }
        private Value<bool?> _simpleRefinanceType;
        public bool? SimpleRefinanceType { get { return _simpleRefinanceType; } set { _simpleRefinanceType = value; } }
        private Value<decimal?> _startingAdjPrice;
        public decimal? StartingAdjPrice { get { return _startingAdjPrice; } set { _startingAdjPrice = value; } }
        private Value<decimal?> _startingAdjRate;
        public decimal? StartingAdjRate { get { return _startingAdjRate; } set { _startingAdjRate = value; } }
        public StateDisclosure StateDisclosure { get; set; }
        public StatementCreditDenial StatementCreditDenial { get; set; }
        private Value<List<StatusOnlineLog>> _statusOnlineLogs;
        public List<StatusOnlineLog> StatusOnlineLogs { get { return _statusOnlineLogs; } set { _statusOnlineLogs = value; } }
        private Value<decimal?> _subjectPropertyGrossRentalIncomeAmount;
        public decimal? SubjectPropertyGrossRentalIncomeAmount { get { return _subjectPropertyGrossRentalIncomeAmount; } set { _subjectPropertyGrossRentalIncomeAmount = value; } }
        private Value<decimal?> _subjectPropertyOccupancyPercent;
        public decimal? SubjectPropertyOccupancyPercent { get { return _subjectPropertyOccupancyPercent; } set { _subjectPropertyOccupancyPercent = value; } }
        private Value<decimal?> _subordinateLienAmount;
        public decimal? SubordinateLienAmount { get { return _subordinateLienAmount; } set { _subordinateLienAmount = value; } }
        private Value<string> _systemIdGuid;
        public string SystemIdGuid { get { return _systemIdGuid; } set { _systemIdGuid = value; } }
        private Value<DateTime?> _tilApplicationDate;
        public DateTime? TilApplicationDate { get { return _tilApplicationDate; } set { _tilApplicationDate = value; } }
        private Value<string> _titleHolderName1;
        public string TitleHolderName1 { get { return _titleHolderName1; } set { _titleHolderName1 = value; } }
        private Value<string> _titleHolderName2;
        public string TitleHolderName2 { get { return _titleHolderName2; } set { _titleHolderName2 = value; } }
        private Value<decimal?> _tltv;
        public decimal? Tltv { get { return _tltv; } set { _tltv = value; } }
        private Value<decimal?> _totalClosingCostsAmount;
        public decimal? TotalClosingCostsAmount { get { return _totalClosingCostsAmount; } set { _totalClosingCostsAmount = value; } }
        private Value<decimal?> _totalDeductionsAmount;
        public decimal? TotalDeductionsAmount { get { return _totalDeductionsAmount; } set { _totalDeductionsAmount = value; } }
        private Value<decimal?> _totalFeesCostAmount;
        public decimal? TotalFeesCostAmount { get { return _totalFeesCostAmount; } set { _totalFeesCostAmount = value; } }
        private Value<decimal?> _totalFeesCreditAmount;
        public decimal? TotalFeesCreditAmount { get { return _totalFeesCreditAmount; } set { _totalFeesCreditAmount = value; } }
        private Value<decimal?> _totalNonborrowerPaidClosingCostsAmount;
        public decimal? TotalNonborrowerPaidClosingCostsAmount { get { return _totalNonborrowerPaidClosingCostsAmount; } set { _totalNonborrowerPaidClosingCostsAmount = value; } }
        private Value<decimal?> _totalPaidOutsideClosingAmount;
        public decimal? TotalPaidOutsideClosingAmount { get { return _totalPaidOutsideClosingAmount; } set { _totalPaidOutsideClosingAmount = value; } }
        private Value<decimal?> _totalPaidToBrokerAmount;
        public decimal? TotalPaidToBrokerAmount { get { return _totalPaidToBrokerAmount; } set { _totalPaidToBrokerAmount = value; } }
        private Value<decimal?> _totalWireTransferAmount;
        public decimal? TotalWireTransferAmount { get { return _totalWireTransferAmount; } set { _totalWireTransferAmount = value; } }
        public TPO TPO { get; set; }
        public TQL TQL { get; set; }
        public TrustAccount TrustAccount { get; set; }
        public Tsum Tsum { get; set; }
        private Value<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get { return _twelveMonthMortgageRentalHistoryIndicator; } set { _twelveMonthMortgageRentalHistoryIndicator = value; } }
        public Uldd Uldd { get; set; }
        public UnderwriterSummary UnderwriterSummary { get; set; }
        private Value<List<UnderwritingConditionLog>> _underwritingConditionLogs;
        public List<UnderwritingConditionLog> UnderwritingConditionLogs { get { return _underwritingConditionLogs; } set { _underwritingConditionLogs = value; } }
        private Value<bool?> _underwritingEscrowIndicator;
        public bool? UnderwritingEscrowIndicator { get { return _underwritingEscrowIndicator; } set { _underwritingEscrowIndicator = value; } }
        private Value<decimal?> _undiscountedRate;
        public decimal? UndiscountedRate { get { return _undiscountedRate; } set { _undiscountedRate = value; } }
        private Value<int?> _unimprovedAppraisedValue;
        public int? UnimprovedAppraisedValue { get { return _unimprovedAppraisedValue; } set { _unimprovedAppraisedValue = value; } }
        private Value<int?> _unimprovedEstimatedValue;
        public int? UnimprovedEstimatedValue { get { return _unimprovedEstimatedValue; } set { _unimprovedEstimatedValue = value; } }
        private Value<string> _urlPage4Comments;
        public string UrlPage4Comments { get { return _urlPage4Comments; } set { _urlPage4Comments = value; } }
        public Usda Usda { get; set; }
        private Value<string> _usdaGovernmentLoanType;
        public string UsdaGovernmentLoanType { get { return _usdaGovernmentLoanType; } set { _usdaGovernmentLoanType = value; } }
        private Value<bool?> _use2018DiIndicator;
        public bool? Use2018DiIndicator { get { return _use2018DiIndicator; } set { _use2018DiIndicator = value; } }
        private Value<string> _useNew2015FormsIndicator;
        public string UseNew2015FormsIndicator { get { return _useNew2015FormsIndicator; } set { _useNew2015FormsIndicator = value; } }
        private Value<bool?> _useNewHudIndicator;
        public bool? UseNewHudIndicator { get { return _useNewHudIndicator; } set { _useNewHudIndicator = value; } }
        private Value<decimal?> _vAEntitlementAmount;
        public decimal? VAEntitlementAmount { get { return _vAEntitlementAmount; } set { _vAEntitlementAmount = value; } }
        public VaLoanData VaLoanData { get; set; }
        private Value<List<VerificationLog>> _verificationLogs;
        public List<VerificationLog> VerificationLogs { get { return _verificationLogs; } set { _verificationLogs = value; } }
        private Value<string> _virtualFields;
        public string VirtualFields { get { return _virtualFields; } set { _virtualFields = value; } }
        private Value<string> _websiteId;
        public string WebsiteId { get { return _websiteId; } set { _websiteId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adverseActionDate.Clean
                    && _affiliatedBusinessArrangements.Clean
                    && _agencyCaseIdentifier.Clean
                    && _alterationsImprovementsOrRepairsAmount.Clean
                    && _applications.Clean
                    && _applicationTakenMethodType.Clean
                    && _aprDisclosureDate.Clean
                    && _armTypeDescription.Clean
                    && _baseLoanAmount.Clean
                    && _belowMarketSubordinateFinancingIndicator.Clean
                    && _billingCategory.Clean
                    && _biweeklyPaymentAmount.Clean
                    && _bLTV.Clean
                    && _borrowerCoBorrowerMarriedIndicator.Clean
                    && _borrowerPaidClosingCostsAmount.Clean
                    && _borrowerPaidDiscountPointsAmount.Clean
                    && _borrowerPaidFHAVAClosingCostsAmount.Clean
                    && _borrowerRequestedLoanAmount.Clean
                    && _brokerPaidClosingCostsAmount.Clean
                    && _buydownIndicator.Clean
                    && _buydownMonthlyPaymentAmount.Clean
                    && _buydownRatePercent.Clean
                    && _cashFromToBorrowerAmount.Clean
                    && _channel.Clean
                    && _closingBillingDate.Clean
                    && _closingCostProgram.Clean
                    && _closingCostsAndPrepaidsFromOtherLienAmount.Clean
                    && _closingCostsPaidByOthersAmount.Clean
                    && _closingDocsStackingOrder.Clean
                    && _collateralManagerScore.Clean
                    && _combinedLtv.Clean
                    && _commitmentNumber.Clean
                    && _complianceTestLogs.Clean
                    && _conformingJumbo.Clean
                    && _consumerConnectSiteID.Clean
                    && _contacts.Clean
                    && _contactUpdatedIndicator.Clean
                    && _contractSellerCreditAmount.Clean
                    && _conversationLogs.Clean
                    && _copyBrokerToLenderIndicator.Clean
                    && _copyLoanNumLenderCaseNum.Clean
                    && _creditScoreToUse.Clean
                    && _crmLogs.Clean
                    && _currentApplicationIndex.Clean
                    && _currentApplicationIsPrimary.Clean
                    && _currentFirstMortgageHolderType.Clean
                    && _customFields.Clean
                    && _dataTracLogs.Clean
                    && _dBIndicator.Clean
                    && _deductOverwireAmountIndicator.Clean
                    && _disableESignConsentAlert.Clean
                    && _disableKeyPricingAlert.Clean
                    && _disclosureTracking2015Logs.Clean
                    && _disclosureTrackingLogs.Clean
                    && _discountPoint.Clean
                    && _docEngine.Clean
                    && _documentLogs.Clean
                    && _doNotCheckEmail.Clean
                    && _doNotPrintCompensationFees.Clean
                    && _downloadLogs.Clean
                    && _downPaymentPercent.Clean
                    && _edmLogs.Clean
                    && _elliUCDFields.Clean
                    && _emailTriggerLogs.Clean
                    && _emXmlVersionId.Clean
                    && _encompassId.Clean
                    && _encompassVersion.Clean
                    && _enforceCountyLoanLimit.Clean
                    && _estimatedClosingCostsAmount.Clean
                    && _estimatedConstructionInterest.Clean
                    && _estimatedPrepaidItemsAmount.Clean
                    && _exportLoanNumber.Clean
                    && _fees.Clean
                    && _fhaMiPremiumRefundAmount.Clean
                    && _fHAVALoanOriginatorIdentifier.Clean
                    && _fieldLockData.Clean
                    && _firstAdjustmentMinimum.Clean
                    && _firstSubordinateLienAmount.Clean
                    && _firstTimeHomebuyersIndicator.Clean
                    && _fnmCommunityLendingProductName.Clean
                    && _fnmCommunitySecondsIndicator.Clean
                    && _fnmNeighborsMortgageEligibilityIndicator.Clean
                    && _forms.Clean
                    && _fraudScore.Clean
                    && _fundingDeductionList.Clean
                    && _fundingFeeList.Clean
                    && _fundingFees.Clean
                    && _governmentLoanLenderIdentifier.Clean
                    && _governmentLoanSponsorIdentifier.Clean
                    && _governmentMortgageCreditCertificateAmount.Clean
                    && _hasAbusinessRelationshipWith.Clean
                    && _hcltvHtltv.Clean
                    && _helocTeaserRate.Clean
                    && _homeCounselingProviders.Clean
                    && _homeCounselingProvidersDistance.Clean
                    && _homeCounselingProvidersLanguageNames.Clean
                    && _homeCounselingProvidersServiceNames.Clean
                    && _householdSizeCount.Clean
                    && _htmlEmailLogs.Clean
                    && _hudIncomeLimitAdjustmentFactor.Clean
                    && _hudLendingIncomeLimitAmount.Clean
                    && _hudMedianIncomeAmount.Clean
                    && _id.Clean
                    && _includeUSDAFeeInClosing.Clean
                    && _initialInterestRate.Clean
                    && _insuranceAuthorizationIndicator.Clean
                    && _interviewerApplicationSignedDate.Clean
                    && _interviewerEmail.Clean
                    && _interviewerLicenseIdentifier.Clean
                    && _interviewerPhoneNumber.Clean
                    && _interviewersCompanyStateLicense.Clean
                    && _interviewersId.Clean
                    && _inverviewerName.Clean
                    && _isCreditorProhibitsBorrower.Clean
                    && _isEmployeeLoan.Clean
                    && _isLSSecondaryFile.Clean
                    && _isRequiredInterestReserveCompoundInterest.Clean
                    && _landIfAcquiredSeperatelyAmount.Clean
                    && _leadSource.Clean
                    && _lenderCaseIdentifier.Clean
                    && _lenderChannel.Clean
                    && _lenderCreditsInFunding.Clean
                    && _lenderInvestorCode.Clean
                    && _lenderPaidClosignCostsDotAmount.Clean
                    && _lenderPaidClosingCostsAmount.Clean
                    && _lesserAppraisedValueOrSalesPrice.Clean
                    && _lifeInsuranceCoverageAmount.Clean
                    && _lifeInsuranceEstimatedMonthlyAmount.Clean
                    && _lifeInsuranceTotalProtectedMonthlyAmount.Clean
                    && _linkId.Clean
                    && _loanActionLogs.Clean
                    && _loanAmortizationTermMonths.Clean
                    && _loanAmortizationType.Clean
                    && _loanCreatedDate.Clean
                    && _loanCreatedDateUtc.Clean
                    && _loanIdNumber.Clean
                    && _loanImportStatusIndicator.Clean
                    && _loanLinkSyncType.Clean
                    && _loanNumber.Clean
                    && _loanProgramName.Clean
                    && _loanPrograms.Clean
                    && _loanPurposeOfRefinanceType.Clean
                    && _loanSource.Clean
                    && _loanTotalProposedMonthlyMaintenanceAmount.Clean
                    && _loanTotalProposedMonthlyUtilitiesAmount.Clean
                    && _loanUnderwriterCHUMSIdentifier.Clean
                    && _loanVALoanProcedureType.Clean
                    && _loanVARateReductionInitialComputationTotalAmount.Clean
                    && _loanVAResidualIncomeAmount.Clean
                    && _loanVersionId.Clean
                    && _lockConfirmLogs.Clean
                    && _lockDenialLogs.Clean
                    && _lockRequestLogs.Clean
                    && _logEntryLogs.Clean
                    && _ltv.Clean
                    && _ltvPropertyValue.Clean
                    && _masterCommitmentNumber.Clean
                    && _maturityDate.Clean
                    && _maxBackRatio.Clean
                    && _maxFrontRatio.Clean
                    && _mersNumber.Clean
                    && _mersNumberRegistrationDate.Clean
                    && _miAndFundingFeeFinancedAmount.Clean
                    && _miAndFundingFeeTotalAmount.Clean
                    && _milestoneApprovedDate.Clean
                    && _milestoneApprovedDueDate.Clean
                    && _milestoneCompletedDate.Clean
                    && _milestoneCompletedDueDate.Clean
                    && _milestoneCurrentDateUtc.Clean
                    && _milestoneCurrentName.Clean
                    && _milestoneDocSignedDate.Clean
                    && _milestoneDocSignedDueDate.Clean
                    && _milestoneDuration.Clean
                    && _milestoneFileStartedDate.Clean
                    && _milestoneFreeRoleLogs.Clean
                    && _milestoneFundedDate.Clean
                    && _milestoneFundedDueDate.Clean
                    && _milestoneLogs.Clean
                    && _milestoneProcessedDate.Clean
                    && _milestoneStage.Clean
                    && _milestoneSubmittedDate.Clean
                    && _milestoneSubmittedDueDate.Clean
                    && _milestoneTaskLogs.Clean
                    && _milestoneTemplateLogs.Clean
                    && _mipBorrowerPaidInCashAmount.Clean
                    && _mipPaidInCashAmount.Clean
                    && _monthlyPIPaymentAmountForLE1andCD1.Clean
                    && _mortgageInsurancePremiumFHARefundAmount.Clean
                    && _mortgageInsurancePremiumUpfrontFactorPercent.Clean
                    && _mortgageType.Clean
                    && _msaIdentifier.Clean
                    && _newFirstMortgageAmount.Clean
                    && _nmlsLoanOriginatorId.Clean
                    && _noClosingCostOption.Clean
                    && _notRequiredForPurchaseSaleOrRefinance.Clean
                    && _notRequiredForSettlementOfYourLoan.Clean
                    && _occupancyType.Clean
                    && _openingDocsInvestorCode.Clean
                    && _openingDocsLoanProgramType.Clean
                    && _openingDocsPlanDescription.Clean
                    && _openingDocsPlanId.Clean
                    && _openingDocsProgramCode.Clean
                    && _openingDocsStackingOrder.Clean
                    && _organizationCode.Clean
                    && _originationDate.Clean
                    && _otherAmortizationTypeDescription.Clean
                    && _otherMortgageTypeDescription.Clean
                    && _otherPaidClosingCostsAmount.Clean
                    && _overwireAmount.Clean
                    && _paymentScheduleCalcRequiredIndicator.Clean
                    && _percentageOfOwnership.Clean
                    && _percentageOwnershipInterest.Clean
                    && _pmiIndicator.Clean
                    && _postClosingConditionLogs.Clean
                    && _preliminaryConditionLogs.Clean
                    && _principalAndInterestMonthlyPaymentAmount.Clean
                    && _print2003Application.Clean
                    && _printLogs.Clean
                    && _propertyAppraisedValueAmount.Clean
                    && _propertyEnergyEfficientHomeIndicator.Clean
                    && _propertyEstimatedValueAmount.Clean
                    && _proposedDuesAmount.Clean
                    && _proposedFirstMortgageAmount.Clean
                    && _proposedGroundRentAmount.Clean
                    && _proposedHazardInsuranceAmount.Clean
                    && _proposedHousingExpenseTotal.Clean
                    && _proposedMortgageInsuranceAmount.Clean
                    && _proposedOtherAmount.Clean
                    && _proposedOtherMortgagesAmount.Clean
                    && _proposedRealEstateTaxesAmount.Clean
                    && _purchaseCredits.Clean
                    && _purchasePriceAmount.Clean
                    && _referralAddress.Clean
                    && _referralCity.Clean
                    && _referralFeeAmount.Clean
                    && _referralPostalCode.Clean
                    && _referralSource.Clean
                    && _referralState.Clean
                    && _refinanceIncludingDebtsToBePaidOffAmount.Clean
                    && _registrationLogs.Clean
                    && _removedLogRecords.Clean
                    && _repurchaseCostAmount.Clean
                    && _repurchaseDate.Clean
                    && _requestedInterestRatePercent.Clean
                    && _salesConcessionAmount.Clean
                    && _secondSubordinateAmount.Clean
                    && _sectionOfActType.Clean
                    && _sellerPaidClosingCostsAmount.Clean
                    && _serviceProviderAdditionalInfo.Clean
                    && _serviceProviderContacts.Clean
                    && _serviceProviderDateIssued.Clean
                    && _setForSettlementServicesOfAnAttorney.Clean
                    && _setForTheSettlementServicesListed.Clean
                    && _settlementServiceCharges.Clean
                    && _simpleRefinanceType.Clean
                    && _startingAdjPrice.Clean
                    && _startingAdjRate.Clean
                    && _statusOnlineLogs.Clean
                    && _subjectPropertyGrossRentalIncomeAmount.Clean
                    && _subjectPropertyOccupancyPercent.Clean
                    && _subordinateLienAmount.Clean
                    && _systemIdGuid.Clean
                    && _tilApplicationDate.Clean
                    && _titleHolderName1.Clean
                    && _titleHolderName2.Clean
                    && _tltv.Clean
                    && _totalClosingCostsAmount.Clean
                    && _totalDeductionsAmount.Clean
                    && _totalFeesCostAmount.Clean
                    && _totalFeesCreditAmount.Clean
                    && _totalNonborrowerPaidClosingCostsAmount.Clean
                    && _totalPaidOutsideClosingAmount.Clean
                    && _totalPaidToBrokerAmount.Clean
                    && _totalWireTransferAmount.Clean
                    && _twelveMonthMortgageRentalHistoryIndicator.Clean
                    && _underwritingConditionLogs.Clean
                    && _underwritingEscrowIndicator.Clean
                    && _undiscountedRate.Clean
                    && _unimprovedAppraisedValue.Clean
                    && _unimprovedEstimatedValue.Clean
                    && _urlPage4Comments.Clean
                    && _usdaGovernmentLoanType.Clean
                    && _use2018DiIndicator.Clean
                    && _useNew2015FormsIndicator.Clean
                    && _useNewHudIndicator.Clean
                    && _vAEntitlementAmount.Clean
                    && _verificationLogs.Clean
                    && _virtualFields.Clean
                    && _websiteId.Clean
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
                var adverseActionDate = _adverseActionDate; adverseActionDate.Clean = value; _adverseActionDate = adverseActionDate;
                var affiliatedBusinessArrangements = _affiliatedBusinessArrangements; affiliatedBusinessArrangements.Clean = value; _affiliatedBusinessArrangements = affiliatedBusinessArrangements;
                var agencyCaseIdentifier = _agencyCaseIdentifier; agencyCaseIdentifier.Clean = value; _agencyCaseIdentifier = agencyCaseIdentifier;
                var alterationsImprovementsOrRepairsAmount = _alterationsImprovementsOrRepairsAmount; alterationsImprovementsOrRepairsAmount.Clean = value; _alterationsImprovementsOrRepairsAmount = alterationsImprovementsOrRepairsAmount;
                var applications = _applications; applications.Clean = value; _applications = applications;
                var applicationTakenMethodType = _applicationTakenMethodType; applicationTakenMethodType.Clean = value; _applicationTakenMethodType = applicationTakenMethodType;
                var aprDisclosureDate = _aprDisclosureDate; aprDisclosureDate.Clean = value; _aprDisclosureDate = aprDisclosureDate;
                var armTypeDescription = _armTypeDescription; armTypeDescription.Clean = value; _armTypeDescription = armTypeDescription;
                var baseLoanAmount = _baseLoanAmount; baseLoanAmount.Clean = value; _baseLoanAmount = baseLoanAmount;
                var belowMarketSubordinateFinancingIndicator = _belowMarketSubordinateFinancingIndicator; belowMarketSubordinateFinancingIndicator.Clean = value; _belowMarketSubordinateFinancingIndicator = belowMarketSubordinateFinancingIndicator;
                var billingCategory = _billingCategory; billingCategory.Clean = value; _billingCategory = billingCategory;
                var biweeklyPaymentAmount = _biweeklyPaymentAmount; biweeklyPaymentAmount.Clean = value; _biweeklyPaymentAmount = biweeklyPaymentAmount;
                var bLTV = _bLTV; bLTV.Clean = value; _bLTV = bLTV;
                var borrowerCoBorrowerMarriedIndicator = _borrowerCoBorrowerMarriedIndicator; borrowerCoBorrowerMarriedIndicator.Clean = value; _borrowerCoBorrowerMarriedIndicator = borrowerCoBorrowerMarriedIndicator;
                var borrowerPaidClosingCostsAmount = _borrowerPaidClosingCostsAmount; borrowerPaidClosingCostsAmount.Clean = value; _borrowerPaidClosingCostsAmount = borrowerPaidClosingCostsAmount;
                var borrowerPaidDiscountPointsAmount = _borrowerPaidDiscountPointsAmount; borrowerPaidDiscountPointsAmount.Clean = value; _borrowerPaidDiscountPointsAmount = borrowerPaidDiscountPointsAmount;
                var borrowerPaidFHAVAClosingCostsAmount = _borrowerPaidFHAVAClosingCostsAmount; borrowerPaidFHAVAClosingCostsAmount.Clean = value; _borrowerPaidFHAVAClosingCostsAmount = borrowerPaidFHAVAClosingCostsAmount;
                var borrowerRequestedLoanAmount = _borrowerRequestedLoanAmount; borrowerRequestedLoanAmount.Clean = value; _borrowerRequestedLoanAmount = borrowerRequestedLoanAmount;
                var brokerPaidClosingCostsAmount = _brokerPaidClosingCostsAmount; brokerPaidClosingCostsAmount.Clean = value; _brokerPaidClosingCostsAmount = brokerPaidClosingCostsAmount;
                var buydownIndicator = _buydownIndicator; buydownIndicator.Clean = value; _buydownIndicator = buydownIndicator;
                var buydownMonthlyPaymentAmount = _buydownMonthlyPaymentAmount; buydownMonthlyPaymentAmount.Clean = value; _buydownMonthlyPaymentAmount = buydownMonthlyPaymentAmount;
                var buydownRatePercent = _buydownRatePercent; buydownRatePercent.Clean = value; _buydownRatePercent = buydownRatePercent;
                var cashFromToBorrowerAmount = _cashFromToBorrowerAmount; cashFromToBorrowerAmount.Clean = value; _cashFromToBorrowerAmount = cashFromToBorrowerAmount;
                var channel = _channel; channel.Clean = value; _channel = channel;
                var closingBillingDate = _closingBillingDate; closingBillingDate.Clean = value; _closingBillingDate = closingBillingDate;
                var closingCostProgram = _closingCostProgram; closingCostProgram.Clean = value; _closingCostProgram = closingCostProgram;
                var closingCostsAndPrepaidsFromOtherLienAmount = _closingCostsAndPrepaidsFromOtherLienAmount; closingCostsAndPrepaidsFromOtherLienAmount.Clean = value; _closingCostsAndPrepaidsFromOtherLienAmount = closingCostsAndPrepaidsFromOtherLienAmount;
                var closingCostsPaidByOthersAmount = _closingCostsPaidByOthersAmount; closingCostsPaidByOthersAmount.Clean = value; _closingCostsPaidByOthersAmount = closingCostsPaidByOthersAmount;
                var closingDocsStackingOrder = _closingDocsStackingOrder; closingDocsStackingOrder.Clean = value; _closingDocsStackingOrder = closingDocsStackingOrder;
                var collateralManagerScore = _collateralManagerScore; collateralManagerScore.Clean = value; _collateralManagerScore = collateralManagerScore;
                var combinedLtv = _combinedLtv; combinedLtv.Clean = value; _combinedLtv = combinedLtv;
                var commitmentNumber = _commitmentNumber; commitmentNumber.Clean = value; _commitmentNumber = commitmentNumber;
                var complianceTestLogs = _complianceTestLogs; complianceTestLogs.Clean = value; _complianceTestLogs = complianceTestLogs;
                var conformingJumbo = _conformingJumbo; conformingJumbo.Clean = value; _conformingJumbo = conformingJumbo;
                var consumerConnectSiteID = _consumerConnectSiteID; consumerConnectSiteID.Clean = value; _consumerConnectSiteID = consumerConnectSiteID;
                var contacts = _contacts; contacts.Clean = value; _contacts = contacts;
                var contactUpdatedIndicator = _contactUpdatedIndicator; contactUpdatedIndicator.Clean = value; _contactUpdatedIndicator = contactUpdatedIndicator;
                var contractSellerCreditAmount = _contractSellerCreditAmount; contractSellerCreditAmount.Clean = value; _contractSellerCreditAmount = contractSellerCreditAmount;
                var conversationLogs = _conversationLogs; conversationLogs.Clean = value; _conversationLogs = conversationLogs;
                var copyBrokerToLenderIndicator = _copyBrokerToLenderIndicator; copyBrokerToLenderIndicator.Clean = value; _copyBrokerToLenderIndicator = copyBrokerToLenderIndicator;
                var copyLoanNumLenderCaseNum = _copyLoanNumLenderCaseNum; copyLoanNumLenderCaseNum.Clean = value; _copyLoanNumLenderCaseNum = copyLoanNumLenderCaseNum;
                var creditScoreToUse = _creditScoreToUse; creditScoreToUse.Clean = value; _creditScoreToUse = creditScoreToUse;
                var crmLogs = _crmLogs; crmLogs.Clean = value; _crmLogs = crmLogs;
                var currentApplicationIndex = _currentApplicationIndex; currentApplicationIndex.Clean = value; _currentApplicationIndex = currentApplicationIndex;
                var currentApplicationIsPrimary = _currentApplicationIsPrimary; currentApplicationIsPrimary.Clean = value; _currentApplicationIsPrimary = currentApplicationIsPrimary;
                var currentFirstMortgageHolderType = _currentFirstMortgageHolderType; currentFirstMortgageHolderType.Clean = value; _currentFirstMortgageHolderType = currentFirstMortgageHolderType;
                var customFields = _customFields; customFields.Clean = value; _customFields = customFields;
                var dataTracLogs = _dataTracLogs; dataTracLogs.Clean = value; _dataTracLogs = dataTracLogs;
                var dBIndicator = _dBIndicator; dBIndicator.Clean = value; _dBIndicator = dBIndicator;
                var deductOverwireAmountIndicator = _deductOverwireAmountIndicator; deductOverwireAmountIndicator.Clean = value; _deductOverwireAmountIndicator = deductOverwireAmountIndicator;
                var disableESignConsentAlert = _disableESignConsentAlert; disableESignConsentAlert.Clean = value; _disableESignConsentAlert = disableESignConsentAlert;
                var disableKeyPricingAlert = _disableKeyPricingAlert; disableKeyPricingAlert.Clean = value; _disableKeyPricingAlert = disableKeyPricingAlert;
                var disclosureTracking2015Logs = _disclosureTracking2015Logs; disclosureTracking2015Logs.Clean = value; _disclosureTracking2015Logs = disclosureTracking2015Logs;
                var disclosureTrackingLogs = _disclosureTrackingLogs; disclosureTrackingLogs.Clean = value; _disclosureTrackingLogs = disclosureTrackingLogs;
                var discountPoint = _discountPoint; discountPoint.Clean = value; _discountPoint = discountPoint;
                var docEngine = _docEngine; docEngine.Clean = value; _docEngine = docEngine;
                var documentLogs = _documentLogs; documentLogs.Clean = value; _documentLogs = documentLogs;
                var doNotCheckEmail = _doNotCheckEmail; doNotCheckEmail.Clean = value; _doNotCheckEmail = doNotCheckEmail;
                var doNotPrintCompensationFees = _doNotPrintCompensationFees; doNotPrintCompensationFees.Clean = value; _doNotPrintCompensationFees = doNotPrintCompensationFees;
                var downloadLogs = _downloadLogs; downloadLogs.Clean = value; _downloadLogs = downloadLogs;
                var downPaymentPercent = _downPaymentPercent; downPaymentPercent.Clean = value; _downPaymentPercent = downPaymentPercent;
                var edmLogs = _edmLogs; edmLogs.Clean = value; _edmLogs = edmLogs;
                var elliUCDFields = _elliUCDFields; elliUCDFields.Clean = value; _elliUCDFields = elliUCDFields;
                var emailTriggerLogs = _emailTriggerLogs; emailTriggerLogs.Clean = value; _emailTriggerLogs = emailTriggerLogs;
                var emXmlVersionId = _emXmlVersionId; emXmlVersionId.Clean = value; _emXmlVersionId = emXmlVersionId;
                var encompassId = _encompassId; encompassId.Clean = value; _encompassId = encompassId;
                var encompassVersion = _encompassVersion; encompassVersion.Clean = value; _encompassVersion = encompassVersion;
                var enforceCountyLoanLimit = _enforceCountyLoanLimit; enforceCountyLoanLimit.Clean = value; _enforceCountyLoanLimit = enforceCountyLoanLimit;
                var estimatedClosingCostsAmount = _estimatedClosingCostsAmount; estimatedClosingCostsAmount.Clean = value; _estimatedClosingCostsAmount = estimatedClosingCostsAmount;
                var estimatedConstructionInterest = _estimatedConstructionInterest; estimatedConstructionInterest.Clean = value; _estimatedConstructionInterest = estimatedConstructionInterest;
                var estimatedPrepaidItemsAmount = _estimatedPrepaidItemsAmount; estimatedPrepaidItemsAmount.Clean = value; _estimatedPrepaidItemsAmount = estimatedPrepaidItemsAmount;
                var exportLoanNumber = _exportLoanNumber; exportLoanNumber.Clean = value; _exportLoanNumber = exportLoanNumber;
                var fees = _fees; fees.Clean = value; _fees = fees;
                var fhaMiPremiumRefundAmount = _fhaMiPremiumRefundAmount; fhaMiPremiumRefundAmount.Clean = value; _fhaMiPremiumRefundAmount = fhaMiPremiumRefundAmount;
                var fHAVALoanOriginatorIdentifier = _fHAVALoanOriginatorIdentifier; fHAVALoanOriginatorIdentifier.Clean = value; _fHAVALoanOriginatorIdentifier = fHAVALoanOriginatorIdentifier;
                var fieldLockData = _fieldLockData; fieldLockData.Clean = value; _fieldLockData = fieldLockData;
                var firstAdjustmentMinimum = _firstAdjustmentMinimum; firstAdjustmentMinimum.Clean = value; _firstAdjustmentMinimum = firstAdjustmentMinimum;
                var firstSubordinateLienAmount = _firstSubordinateLienAmount; firstSubordinateLienAmount.Clean = value; _firstSubordinateLienAmount = firstSubordinateLienAmount;
                var firstTimeHomebuyersIndicator = _firstTimeHomebuyersIndicator; firstTimeHomebuyersIndicator.Clean = value; _firstTimeHomebuyersIndicator = firstTimeHomebuyersIndicator;
                var fnmCommunityLendingProductName = _fnmCommunityLendingProductName; fnmCommunityLendingProductName.Clean = value; _fnmCommunityLendingProductName = fnmCommunityLendingProductName;
                var fnmCommunitySecondsIndicator = _fnmCommunitySecondsIndicator; fnmCommunitySecondsIndicator.Clean = value; _fnmCommunitySecondsIndicator = fnmCommunitySecondsIndicator;
                var fnmNeighborsMortgageEligibilityIndicator = _fnmNeighborsMortgageEligibilityIndicator; fnmNeighborsMortgageEligibilityIndicator.Clean = value; _fnmNeighborsMortgageEligibilityIndicator = fnmNeighborsMortgageEligibilityIndicator;
                var forms = _forms; forms.Clean = value; _forms = forms;
                var fraudScore = _fraudScore; fraudScore.Clean = value; _fraudScore = fraudScore;
                var fundingDeductionList = _fundingDeductionList; fundingDeductionList.Clean = value; _fundingDeductionList = fundingDeductionList;
                var fundingFeeList = _fundingFeeList; fundingFeeList.Clean = value; _fundingFeeList = fundingFeeList;
                var fundingFees = _fundingFees; fundingFees.Clean = value; _fundingFees = fundingFees;
                var governmentLoanLenderIdentifier = _governmentLoanLenderIdentifier; governmentLoanLenderIdentifier.Clean = value; _governmentLoanLenderIdentifier = governmentLoanLenderIdentifier;
                var governmentLoanSponsorIdentifier = _governmentLoanSponsorIdentifier; governmentLoanSponsorIdentifier.Clean = value; _governmentLoanSponsorIdentifier = governmentLoanSponsorIdentifier;
                var governmentMortgageCreditCertificateAmount = _governmentMortgageCreditCertificateAmount; governmentMortgageCreditCertificateAmount.Clean = value; _governmentMortgageCreditCertificateAmount = governmentMortgageCreditCertificateAmount;
                var hasAbusinessRelationshipWith = _hasAbusinessRelationshipWith; hasAbusinessRelationshipWith.Clean = value; _hasAbusinessRelationshipWith = hasAbusinessRelationshipWith;
                var hcltvHtltv = _hcltvHtltv; hcltvHtltv.Clean = value; _hcltvHtltv = hcltvHtltv;
                var helocTeaserRate = _helocTeaserRate; helocTeaserRate.Clean = value; _helocTeaserRate = helocTeaserRate;
                var homeCounselingProviders = _homeCounselingProviders; homeCounselingProviders.Clean = value; _homeCounselingProviders = homeCounselingProviders;
                var homeCounselingProvidersDistance = _homeCounselingProvidersDistance; homeCounselingProvidersDistance.Clean = value; _homeCounselingProvidersDistance = homeCounselingProvidersDistance;
                var homeCounselingProvidersLanguageNames = _homeCounselingProvidersLanguageNames; homeCounselingProvidersLanguageNames.Clean = value; _homeCounselingProvidersLanguageNames = homeCounselingProvidersLanguageNames;
                var homeCounselingProvidersServiceNames = _homeCounselingProvidersServiceNames; homeCounselingProvidersServiceNames.Clean = value; _homeCounselingProvidersServiceNames = homeCounselingProvidersServiceNames;
                var householdSizeCount = _householdSizeCount; householdSizeCount.Clean = value; _householdSizeCount = householdSizeCount;
                var htmlEmailLogs = _htmlEmailLogs; htmlEmailLogs.Clean = value; _htmlEmailLogs = htmlEmailLogs;
                var hudIncomeLimitAdjustmentFactor = _hudIncomeLimitAdjustmentFactor; hudIncomeLimitAdjustmentFactor.Clean = value; _hudIncomeLimitAdjustmentFactor = hudIncomeLimitAdjustmentFactor;
                var hudLendingIncomeLimitAmount = _hudLendingIncomeLimitAmount; hudLendingIncomeLimitAmount.Clean = value; _hudLendingIncomeLimitAmount = hudLendingIncomeLimitAmount;
                var hudMedianIncomeAmount = _hudMedianIncomeAmount; hudMedianIncomeAmount.Clean = value; _hudMedianIncomeAmount = hudMedianIncomeAmount;
                var id = _id; id.Clean = value; _id = id;
                var includeUSDAFeeInClosing = _includeUSDAFeeInClosing; includeUSDAFeeInClosing.Clean = value; _includeUSDAFeeInClosing = includeUSDAFeeInClosing;
                var initialInterestRate = _initialInterestRate; initialInterestRate.Clean = value; _initialInterestRate = initialInterestRate;
                var insuranceAuthorizationIndicator = _insuranceAuthorizationIndicator; insuranceAuthorizationIndicator.Clean = value; _insuranceAuthorizationIndicator = insuranceAuthorizationIndicator;
                var interviewerApplicationSignedDate = _interviewerApplicationSignedDate; interviewerApplicationSignedDate.Clean = value; _interviewerApplicationSignedDate = interviewerApplicationSignedDate;
                var interviewerEmail = _interviewerEmail; interviewerEmail.Clean = value; _interviewerEmail = interviewerEmail;
                var interviewerLicenseIdentifier = _interviewerLicenseIdentifier; interviewerLicenseIdentifier.Clean = value; _interviewerLicenseIdentifier = interviewerLicenseIdentifier;
                var interviewerPhoneNumber = _interviewerPhoneNumber; interviewerPhoneNumber.Clean = value; _interviewerPhoneNumber = interviewerPhoneNumber;
                var interviewersCompanyStateLicense = _interviewersCompanyStateLicense; interviewersCompanyStateLicense.Clean = value; _interviewersCompanyStateLicense = interviewersCompanyStateLicense;
                var interviewersId = _interviewersId; interviewersId.Clean = value; _interviewersId = interviewersId;
                var inverviewerName = _inverviewerName; inverviewerName.Clean = value; _inverviewerName = inverviewerName;
                var isCreditorProhibitsBorrower = _isCreditorProhibitsBorrower; isCreditorProhibitsBorrower.Clean = value; _isCreditorProhibitsBorrower = isCreditorProhibitsBorrower;
                var isEmployeeLoan = _isEmployeeLoan; isEmployeeLoan.Clean = value; _isEmployeeLoan = isEmployeeLoan;
                var isLSSecondaryFile = _isLSSecondaryFile; isLSSecondaryFile.Clean = value; _isLSSecondaryFile = isLSSecondaryFile;
                var isRequiredInterestReserveCompoundInterest = _isRequiredInterestReserveCompoundInterest; isRequiredInterestReserveCompoundInterest.Clean = value; _isRequiredInterestReserveCompoundInterest = isRequiredInterestReserveCompoundInterest;
                var landIfAcquiredSeperatelyAmount = _landIfAcquiredSeperatelyAmount; landIfAcquiredSeperatelyAmount.Clean = value; _landIfAcquiredSeperatelyAmount = landIfAcquiredSeperatelyAmount;
                var leadSource = _leadSource; leadSource.Clean = value; _leadSource = leadSource;
                var lenderCaseIdentifier = _lenderCaseIdentifier; lenderCaseIdentifier.Clean = value; _lenderCaseIdentifier = lenderCaseIdentifier;
                var lenderChannel = _lenderChannel; lenderChannel.Clean = value; _lenderChannel = lenderChannel;
                var lenderCreditsInFunding = _lenderCreditsInFunding; lenderCreditsInFunding.Clean = value; _lenderCreditsInFunding = lenderCreditsInFunding;
                var lenderInvestorCode = _lenderInvestorCode; lenderInvestorCode.Clean = value; _lenderInvestorCode = lenderInvestorCode;
                var lenderPaidClosignCostsDotAmount = _lenderPaidClosignCostsDotAmount; lenderPaidClosignCostsDotAmount.Clean = value; _lenderPaidClosignCostsDotAmount = lenderPaidClosignCostsDotAmount;
                var lenderPaidClosingCostsAmount = _lenderPaidClosingCostsAmount; lenderPaidClosingCostsAmount.Clean = value; _lenderPaidClosingCostsAmount = lenderPaidClosingCostsAmount;
                var lesserAppraisedValueOrSalesPrice = _lesserAppraisedValueOrSalesPrice; lesserAppraisedValueOrSalesPrice.Clean = value; _lesserAppraisedValueOrSalesPrice = lesserAppraisedValueOrSalesPrice;
                var lifeInsuranceCoverageAmount = _lifeInsuranceCoverageAmount; lifeInsuranceCoverageAmount.Clean = value; _lifeInsuranceCoverageAmount = lifeInsuranceCoverageAmount;
                var lifeInsuranceEstimatedMonthlyAmount = _lifeInsuranceEstimatedMonthlyAmount; lifeInsuranceEstimatedMonthlyAmount.Clean = value; _lifeInsuranceEstimatedMonthlyAmount = lifeInsuranceEstimatedMonthlyAmount;
                var lifeInsuranceTotalProtectedMonthlyAmount = _lifeInsuranceTotalProtectedMonthlyAmount; lifeInsuranceTotalProtectedMonthlyAmount.Clean = value; _lifeInsuranceTotalProtectedMonthlyAmount = lifeInsuranceTotalProtectedMonthlyAmount;
                var linkId = _linkId; linkId.Clean = value; _linkId = linkId;
                var loanActionLogs = _loanActionLogs; loanActionLogs.Clean = value; _loanActionLogs = loanActionLogs;
                var loanAmortizationTermMonths = _loanAmortizationTermMonths; loanAmortizationTermMonths.Clean = value; _loanAmortizationTermMonths = loanAmortizationTermMonths;
                var loanAmortizationType = _loanAmortizationType; loanAmortizationType.Clean = value; _loanAmortizationType = loanAmortizationType;
                var loanCreatedDate = _loanCreatedDate; loanCreatedDate.Clean = value; _loanCreatedDate = loanCreatedDate;
                var loanCreatedDateUtc = _loanCreatedDateUtc; loanCreatedDateUtc.Clean = value; _loanCreatedDateUtc = loanCreatedDateUtc;
                var loanIdNumber = _loanIdNumber; loanIdNumber.Clean = value; _loanIdNumber = loanIdNumber;
                var loanImportStatusIndicator = _loanImportStatusIndicator; loanImportStatusIndicator.Clean = value; _loanImportStatusIndicator = loanImportStatusIndicator;
                var loanLinkSyncType = _loanLinkSyncType; loanLinkSyncType.Clean = value; _loanLinkSyncType = loanLinkSyncType;
                var loanNumber = _loanNumber; loanNumber.Clean = value; _loanNumber = loanNumber;
                var loanProgramName = _loanProgramName; loanProgramName.Clean = value; _loanProgramName = loanProgramName;
                var loanPrograms = _loanPrograms; loanPrograms.Clean = value; _loanPrograms = loanPrograms;
                var loanPurposeOfRefinanceType = _loanPurposeOfRefinanceType; loanPurposeOfRefinanceType.Clean = value; _loanPurposeOfRefinanceType = loanPurposeOfRefinanceType;
                var loanSource = _loanSource; loanSource.Clean = value; _loanSource = loanSource;
                var loanTotalProposedMonthlyMaintenanceAmount = _loanTotalProposedMonthlyMaintenanceAmount; loanTotalProposedMonthlyMaintenanceAmount.Clean = value; _loanTotalProposedMonthlyMaintenanceAmount = loanTotalProposedMonthlyMaintenanceAmount;
                var loanTotalProposedMonthlyUtilitiesAmount = _loanTotalProposedMonthlyUtilitiesAmount; loanTotalProposedMonthlyUtilitiesAmount.Clean = value; _loanTotalProposedMonthlyUtilitiesAmount = loanTotalProposedMonthlyUtilitiesAmount;
                var loanUnderwriterCHUMSIdentifier = _loanUnderwriterCHUMSIdentifier; loanUnderwriterCHUMSIdentifier.Clean = value; _loanUnderwriterCHUMSIdentifier = loanUnderwriterCHUMSIdentifier;
                var loanVALoanProcedureType = _loanVALoanProcedureType; loanVALoanProcedureType.Clean = value; _loanVALoanProcedureType = loanVALoanProcedureType;
                var loanVARateReductionInitialComputationTotalAmount = _loanVARateReductionInitialComputationTotalAmount; loanVARateReductionInitialComputationTotalAmount.Clean = value; _loanVARateReductionInitialComputationTotalAmount = loanVARateReductionInitialComputationTotalAmount;
                var loanVAResidualIncomeAmount = _loanVAResidualIncomeAmount; loanVAResidualIncomeAmount.Clean = value; _loanVAResidualIncomeAmount = loanVAResidualIncomeAmount;
                var loanVersionId = _loanVersionId; loanVersionId.Clean = value; _loanVersionId = loanVersionId;
                var lockConfirmLogs = _lockConfirmLogs; lockConfirmLogs.Clean = value; _lockConfirmLogs = lockConfirmLogs;
                var lockDenialLogs = _lockDenialLogs; lockDenialLogs.Clean = value; _lockDenialLogs = lockDenialLogs;
                var lockRequestLogs = _lockRequestLogs; lockRequestLogs.Clean = value; _lockRequestLogs = lockRequestLogs;
                var logEntryLogs = _logEntryLogs; logEntryLogs.Clean = value; _logEntryLogs = logEntryLogs;
                var ltv = _ltv; ltv.Clean = value; _ltv = ltv;
                var ltvPropertyValue = _ltvPropertyValue; ltvPropertyValue.Clean = value; _ltvPropertyValue = ltvPropertyValue;
                var masterCommitmentNumber = _masterCommitmentNumber; masterCommitmentNumber.Clean = value; _masterCommitmentNumber = masterCommitmentNumber;
                var maturityDate = _maturityDate; maturityDate.Clean = value; _maturityDate = maturityDate;
                var maxBackRatio = _maxBackRatio; maxBackRatio.Clean = value; _maxBackRatio = maxBackRatio;
                var maxFrontRatio = _maxFrontRatio; maxFrontRatio.Clean = value; _maxFrontRatio = maxFrontRatio;
                var mersNumber = _mersNumber; mersNumber.Clean = value; _mersNumber = mersNumber;
                var mersNumberRegistrationDate = _mersNumberRegistrationDate; mersNumberRegistrationDate.Clean = value; _mersNumberRegistrationDate = mersNumberRegistrationDate;
                var miAndFundingFeeFinancedAmount = _miAndFundingFeeFinancedAmount; miAndFundingFeeFinancedAmount.Clean = value; _miAndFundingFeeFinancedAmount = miAndFundingFeeFinancedAmount;
                var miAndFundingFeeTotalAmount = _miAndFundingFeeTotalAmount; miAndFundingFeeTotalAmount.Clean = value; _miAndFundingFeeTotalAmount = miAndFundingFeeTotalAmount;
                var milestoneApprovedDate = _milestoneApprovedDate; milestoneApprovedDate.Clean = value; _milestoneApprovedDate = milestoneApprovedDate;
                var milestoneApprovedDueDate = _milestoneApprovedDueDate; milestoneApprovedDueDate.Clean = value; _milestoneApprovedDueDate = milestoneApprovedDueDate;
                var milestoneCompletedDate = _milestoneCompletedDate; milestoneCompletedDate.Clean = value; _milestoneCompletedDate = milestoneCompletedDate;
                var milestoneCompletedDueDate = _milestoneCompletedDueDate; milestoneCompletedDueDate.Clean = value; _milestoneCompletedDueDate = milestoneCompletedDueDate;
                var milestoneCurrentDateUtc = _milestoneCurrentDateUtc; milestoneCurrentDateUtc.Clean = value; _milestoneCurrentDateUtc = milestoneCurrentDateUtc;
                var milestoneCurrentName = _milestoneCurrentName; milestoneCurrentName.Clean = value; _milestoneCurrentName = milestoneCurrentName;
                var milestoneDocSignedDate = _milestoneDocSignedDate; milestoneDocSignedDate.Clean = value; _milestoneDocSignedDate = milestoneDocSignedDate;
                var milestoneDocSignedDueDate = _milestoneDocSignedDueDate; milestoneDocSignedDueDate.Clean = value; _milestoneDocSignedDueDate = milestoneDocSignedDueDate;
                var milestoneDuration = _milestoneDuration; milestoneDuration.Clean = value; _milestoneDuration = milestoneDuration;
                var milestoneFileStartedDate = _milestoneFileStartedDate; milestoneFileStartedDate.Clean = value; _milestoneFileStartedDate = milestoneFileStartedDate;
                var milestoneFreeRoleLogs = _milestoneFreeRoleLogs; milestoneFreeRoleLogs.Clean = value; _milestoneFreeRoleLogs = milestoneFreeRoleLogs;
                var milestoneFundedDate = _milestoneFundedDate; milestoneFundedDate.Clean = value; _milestoneFundedDate = milestoneFundedDate;
                var milestoneFundedDueDate = _milestoneFundedDueDate; milestoneFundedDueDate.Clean = value; _milestoneFundedDueDate = milestoneFundedDueDate;
                var milestoneLogs = _milestoneLogs; milestoneLogs.Clean = value; _milestoneLogs = milestoneLogs;
                var milestoneProcessedDate = _milestoneProcessedDate; milestoneProcessedDate.Clean = value; _milestoneProcessedDate = milestoneProcessedDate;
                var milestoneStage = _milestoneStage; milestoneStage.Clean = value; _milestoneStage = milestoneStage;
                var milestoneSubmittedDate = _milestoneSubmittedDate; milestoneSubmittedDate.Clean = value; _milestoneSubmittedDate = milestoneSubmittedDate;
                var milestoneSubmittedDueDate = _milestoneSubmittedDueDate; milestoneSubmittedDueDate.Clean = value; _milestoneSubmittedDueDate = milestoneSubmittedDueDate;
                var milestoneTaskLogs = _milestoneTaskLogs; milestoneTaskLogs.Clean = value; _milestoneTaskLogs = milestoneTaskLogs;
                var milestoneTemplateLogs = _milestoneTemplateLogs; milestoneTemplateLogs.Clean = value; _milestoneTemplateLogs = milestoneTemplateLogs;
                var mipBorrowerPaidInCashAmount = _mipBorrowerPaidInCashAmount; mipBorrowerPaidInCashAmount.Clean = value; _mipBorrowerPaidInCashAmount = mipBorrowerPaidInCashAmount;
                var mipPaidInCashAmount = _mipPaidInCashAmount; mipPaidInCashAmount.Clean = value; _mipPaidInCashAmount = mipPaidInCashAmount;
                var monthlyPIPaymentAmountForLE1andCD1 = _monthlyPIPaymentAmountForLE1andCD1; monthlyPIPaymentAmountForLE1andCD1.Clean = value; _monthlyPIPaymentAmountForLE1andCD1 = monthlyPIPaymentAmountForLE1andCD1;
                var mortgageInsurancePremiumFHARefundAmount = _mortgageInsurancePremiumFHARefundAmount; mortgageInsurancePremiumFHARefundAmount.Clean = value; _mortgageInsurancePremiumFHARefundAmount = mortgageInsurancePremiumFHARefundAmount;
                var mortgageInsurancePremiumUpfrontFactorPercent = _mortgageInsurancePremiumUpfrontFactorPercent; mortgageInsurancePremiumUpfrontFactorPercent.Clean = value; _mortgageInsurancePremiumUpfrontFactorPercent = mortgageInsurancePremiumUpfrontFactorPercent;
                var mortgageType = _mortgageType; mortgageType.Clean = value; _mortgageType = mortgageType;
                var msaIdentifier = _msaIdentifier; msaIdentifier.Clean = value; _msaIdentifier = msaIdentifier;
                var newFirstMortgageAmount = _newFirstMortgageAmount; newFirstMortgageAmount.Clean = value; _newFirstMortgageAmount = newFirstMortgageAmount;
                var nmlsLoanOriginatorId = _nmlsLoanOriginatorId; nmlsLoanOriginatorId.Clean = value; _nmlsLoanOriginatorId = nmlsLoanOriginatorId;
                var noClosingCostOption = _noClosingCostOption; noClosingCostOption.Clean = value; _noClosingCostOption = noClosingCostOption;
                var notRequiredForPurchaseSaleOrRefinance = _notRequiredForPurchaseSaleOrRefinance; notRequiredForPurchaseSaleOrRefinance.Clean = value; _notRequiredForPurchaseSaleOrRefinance = notRequiredForPurchaseSaleOrRefinance;
                var notRequiredForSettlementOfYourLoan = _notRequiredForSettlementOfYourLoan; notRequiredForSettlementOfYourLoan.Clean = value; _notRequiredForSettlementOfYourLoan = notRequiredForSettlementOfYourLoan;
                var occupancyType = _occupancyType; occupancyType.Clean = value; _occupancyType = occupancyType;
                var openingDocsInvestorCode = _openingDocsInvestorCode; openingDocsInvestorCode.Clean = value; _openingDocsInvestorCode = openingDocsInvestorCode;
                var openingDocsLoanProgramType = _openingDocsLoanProgramType; openingDocsLoanProgramType.Clean = value; _openingDocsLoanProgramType = openingDocsLoanProgramType;
                var openingDocsPlanDescription = _openingDocsPlanDescription; openingDocsPlanDescription.Clean = value; _openingDocsPlanDescription = openingDocsPlanDescription;
                var openingDocsPlanId = _openingDocsPlanId; openingDocsPlanId.Clean = value; _openingDocsPlanId = openingDocsPlanId;
                var openingDocsProgramCode = _openingDocsProgramCode; openingDocsProgramCode.Clean = value; _openingDocsProgramCode = openingDocsProgramCode;
                var openingDocsStackingOrder = _openingDocsStackingOrder; openingDocsStackingOrder.Clean = value; _openingDocsStackingOrder = openingDocsStackingOrder;
                var organizationCode = _organizationCode; organizationCode.Clean = value; _organizationCode = organizationCode;
                var originationDate = _originationDate; originationDate.Clean = value; _originationDate = originationDate;
                var otherAmortizationTypeDescription = _otherAmortizationTypeDescription; otherAmortizationTypeDescription.Clean = value; _otherAmortizationTypeDescription = otherAmortizationTypeDescription;
                var otherMortgageTypeDescription = _otherMortgageTypeDescription; otherMortgageTypeDescription.Clean = value; _otherMortgageTypeDescription = otherMortgageTypeDescription;
                var otherPaidClosingCostsAmount = _otherPaidClosingCostsAmount; otherPaidClosingCostsAmount.Clean = value; _otherPaidClosingCostsAmount = otherPaidClosingCostsAmount;
                var overwireAmount = _overwireAmount; overwireAmount.Clean = value; _overwireAmount = overwireAmount;
                var paymentScheduleCalcRequiredIndicator = _paymentScheduleCalcRequiredIndicator; paymentScheduleCalcRequiredIndicator.Clean = value; _paymentScheduleCalcRequiredIndicator = paymentScheduleCalcRequiredIndicator;
                var percentageOfOwnership = _percentageOfOwnership; percentageOfOwnership.Clean = value; _percentageOfOwnership = percentageOfOwnership;
                var percentageOwnershipInterest = _percentageOwnershipInterest; percentageOwnershipInterest.Clean = value; _percentageOwnershipInterest = percentageOwnershipInterest;
                var pmiIndicator = _pmiIndicator; pmiIndicator.Clean = value; _pmiIndicator = pmiIndicator;
                var postClosingConditionLogs = _postClosingConditionLogs; postClosingConditionLogs.Clean = value; _postClosingConditionLogs = postClosingConditionLogs;
                var preliminaryConditionLogs = _preliminaryConditionLogs; preliminaryConditionLogs.Clean = value; _preliminaryConditionLogs = preliminaryConditionLogs;
                var principalAndInterestMonthlyPaymentAmount = _principalAndInterestMonthlyPaymentAmount; principalAndInterestMonthlyPaymentAmount.Clean = value; _principalAndInterestMonthlyPaymentAmount = principalAndInterestMonthlyPaymentAmount;
                var print2003Application = _print2003Application; print2003Application.Clean = value; _print2003Application = print2003Application;
                var printLogs = _printLogs; printLogs.Clean = value; _printLogs = printLogs;
                var propertyAppraisedValueAmount = _propertyAppraisedValueAmount; propertyAppraisedValueAmount.Clean = value; _propertyAppraisedValueAmount = propertyAppraisedValueAmount;
                var propertyEnergyEfficientHomeIndicator = _propertyEnergyEfficientHomeIndicator; propertyEnergyEfficientHomeIndicator.Clean = value; _propertyEnergyEfficientHomeIndicator = propertyEnergyEfficientHomeIndicator;
                var propertyEstimatedValueAmount = _propertyEstimatedValueAmount; propertyEstimatedValueAmount.Clean = value; _propertyEstimatedValueAmount = propertyEstimatedValueAmount;
                var proposedDuesAmount = _proposedDuesAmount; proposedDuesAmount.Clean = value; _proposedDuesAmount = proposedDuesAmount;
                var proposedFirstMortgageAmount = _proposedFirstMortgageAmount; proposedFirstMortgageAmount.Clean = value; _proposedFirstMortgageAmount = proposedFirstMortgageAmount;
                var proposedGroundRentAmount = _proposedGroundRentAmount; proposedGroundRentAmount.Clean = value; _proposedGroundRentAmount = proposedGroundRentAmount;
                var proposedHazardInsuranceAmount = _proposedHazardInsuranceAmount; proposedHazardInsuranceAmount.Clean = value; _proposedHazardInsuranceAmount = proposedHazardInsuranceAmount;
                var proposedHousingExpenseTotal = _proposedHousingExpenseTotal; proposedHousingExpenseTotal.Clean = value; _proposedHousingExpenseTotal = proposedHousingExpenseTotal;
                var proposedMortgageInsuranceAmount = _proposedMortgageInsuranceAmount; proposedMortgageInsuranceAmount.Clean = value; _proposedMortgageInsuranceAmount = proposedMortgageInsuranceAmount;
                var proposedOtherAmount = _proposedOtherAmount; proposedOtherAmount.Clean = value; _proposedOtherAmount = proposedOtherAmount;
                var proposedOtherMortgagesAmount = _proposedOtherMortgagesAmount; proposedOtherMortgagesAmount.Clean = value; _proposedOtherMortgagesAmount = proposedOtherMortgagesAmount;
                var proposedRealEstateTaxesAmount = _proposedRealEstateTaxesAmount; proposedRealEstateTaxesAmount.Clean = value; _proposedRealEstateTaxesAmount = proposedRealEstateTaxesAmount;
                var purchaseCredits = _purchaseCredits; purchaseCredits.Clean = value; _purchaseCredits = purchaseCredits;
                var purchasePriceAmount = _purchasePriceAmount; purchasePriceAmount.Clean = value; _purchasePriceAmount = purchasePriceAmount;
                var referralAddress = _referralAddress; referralAddress.Clean = value; _referralAddress = referralAddress;
                var referralCity = _referralCity; referralCity.Clean = value; _referralCity = referralCity;
                var referralFeeAmount = _referralFeeAmount; referralFeeAmount.Clean = value; _referralFeeAmount = referralFeeAmount;
                var referralPostalCode = _referralPostalCode; referralPostalCode.Clean = value; _referralPostalCode = referralPostalCode;
                var referralSource = _referralSource; referralSource.Clean = value; _referralSource = referralSource;
                var referralState = _referralState; referralState.Clean = value; _referralState = referralState;
                var refinanceIncludingDebtsToBePaidOffAmount = _refinanceIncludingDebtsToBePaidOffAmount; refinanceIncludingDebtsToBePaidOffAmount.Clean = value; _refinanceIncludingDebtsToBePaidOffAmount = refinanceIncludingDebtsToBePaidOffAmount;
                var registrationLogs = _registrationLogs; registrationLogs.Clean = value; _registrationLogs = registrationLogs;
                var removedLogRecords = _removedLogRecords; removedLogRecords.Clean = value; _removedLogRecords = removedLogRecords;
                var repurchaseCostAmount = _repurchaseCostAmount; repurchaseCostAmount.Clean = value; _repurchaseCostAmount = repurchaseCostAmount;
                var repurchaseDate = _repurchaseDate; repurchaseDate.Clean = value; _repurchaseDate = repurchaseDate;
                var requestedInterestRatePercent = _requestedInterestRatePercent; requestedInterestRatePercent.Clean = value; _requestedInterestRatePercent = requestedInterestRatePercent;
                var salesConcessionAmount = _salesConcessionAmount; salesConcessionAmount.Clean = value; _salesConcessionAmount = salesConcessionAmount;
                var secondSubordinateAmount = _secondSubordinateAmount; secondSubordinateAmount.Clean = value; _secondSubordinateAmount = secondSubordinateAmount;
                var sectionOfActType = _sectionOfActType; sectionOfActType.Clean = value; _sectionOfActType = sectionOfActType;
                var sellerPaidClosingCostsAmount = _sellerPaidClosingCostsAmount; sellerPaidClosingCostsAmount.Clean = value; _sellerPaidClosingCostsAmount = sellerPaidClosingCostsAmount;
                var serviceProviderAdditionalInfo = _serviceProviderAdditionalInfo; serviceProviderAdditionalInfo.Clean = value; _serviceProviderAdditionalInfo = serviceProviderAdditionalInfo;
                var serviceProviderContacts = _serviceProviderContacts; serviceProviderContacts.Clean = value; _serviceProviderContacts = serviceProviderContacts;
                var serviceProviderDateIssued = _serviceProviderDateIssued; serviceProviderDateIssued.Clean = value; _serviceProviderDateIssued = serviceProviderDateIssued;
                var setForSettlementServicesOfAnAttorney = _setForSettlementServicesOfAnAttorney; setForSettlementServicesOfAnAttorney.Clean = value; _setForSettlementServicesOfAnAttorney = setForSettlementServicesOfAnAttorney;
                var setForTheSettlementServicesListed = _setForTheSettlementServicesListed; setForTheSettlementServicesListed.Clean = value; _setForTheSettlementServicesListed = setForTheSettlementServicesListed;
                var settlementServiceCharges = _settlementServiceCharges; settlementServiceCharges.Clean = value; _settlementServiceCharges = settlementServiceCharges;
                var simpleRefinanceType = _simpleRefinanceType; simpleRefinanceType.Clean = value; _simpleRefinanceType = simpleRefinanceType;
                var startingAdjPrice = _startingAdjPrice; startingAdjPrice.Clean = value; _startingAdjPrice = startingAdjPrice;
                var startingAdjRate = _startingAdjRate; startingAdjRate.Clean = value; _startingAdjRate = startingAdjRate;
                var statusOnlineLogs = _statusOnlineLogs; statusOnlineLogs.Clean = value; _statusOnlineLogs = statusOnlineLogs;
                var subjectPropertyGrossRentalIncomeAmount = _subjectPropertyGrossRentalIncomeAmount; subjectPropertyGrossRentalIncomeAmount.Clean = value; _subjectPropertyGrossRentalIncomeAmount = subjectPropertyGrossRentalIncomeAmount;
                var subjectPropertyOccupancyPercent = _subjectPropertyOccupancyPercent; subjectPropertyOccupancyPercent.Clean = value; _subjectPropertyOccupancyPercent = subjectPropertyOccupancyPercent;
                var subordinateLienAmount = _subordinateLienAmount; subordinateLienAmount.Clean = value; _subordinateLienAmount = subordinateLienAmount;
                var systemIdGuid = _systemIdGuid; systemIdGuid.Clean = value; _systemIdGuid = systemIdGuid;
                var tilApplicationDate = _tilApplicationDate; tilApplicationDate.Clean = value; _tilApplicationDate = tilApplicationDate;
                var titleHolderName1 = _titleHolderName1; titleHolderName1.Clean = value; _titleHolderName1 = titleHolderName1;
                var titleHolderName2 = _titleHolderName2; titleHolderName2.Clean = value; _titleHolderName2 = titleHolderName2;
                var tltv = _tltv; tltv.Clean = value; _tltv = tltv;
                var totalClosingCostsAmount = _totalClosingCostsAmount; totalClosingCostsAmount.Clean = value; _totalClosingCostsAmount = totalClosingCostsAmount;
                var totalDeductionsAmount = _totalDeductionsAmount; totalDeductionsAmount.Clean = value; _totalDeductionsAmount = totalDeductionsAmount;
                var totalFeesCostAmount = _totalFeesCostAmount; totalFeesCostAmount.Clean = value; _totalFeesCostAmount = totalFeesCostAmount;
                var totalFeesCreditAmount = _totalFeesCreditAmount; totalFeesCreditAmount.Clean = value; _totalFeesCreditAmount = totalFeesCreditAmount;
                var totalNonborrowerPaidClosingCostsAmount = _totalNonborrowerPaidClosingCostsAmount; totalNonborrowerPaidClosingCostsAmount.Clean = value; _totalNonborrowerPaidClosingCostsAmount = totalNonborrowerPaidClosingCostsAmount;
                var totalPaidOutsideClosingAmount = _totalPaidOutsideClosingAmount; totalPaidOutsideClosingAmount.Clean = value; _totalPaidOutsideClosingAmount = totalPaidOutsideClosingAmount;
                var totalPaidToBrokerAmount = _totalPaidToBrokerAmount; totalPaidToBrokerAmount.Clean = value; _totalPaidToBrokerAmount = totalPaidToBrokerAmount;
                var totalWireTransferAmount = _totalWireTransferAmount; totalWireTransferAmount.Clean = value; _totalWireTransferAmount = totalWireTransferAmount;
                var twelveMonthMortgageRentalHistoryIndicator = _twelveMonthMortgageRentalHistoryIndicator; twelveMonthMortgageRentalHistoryIndicator.Clean = value; _twelveMonthMortgageRentalHistoryIndicator = twelveMonthMortgageRentalHistoryIndicator;
                var underwritingConditionLogs = _underwritingConditionLogs; underwritingConditionLogs.Clean = value; _underwritingConditionLogs = underwritingConditionLogs;
                var underwritingEscrowIndicator = _underwritingEscrowIndicator; underwritingEscrowIndicator.Clean = value; _underwritingEscrowIndicator = underwritingEscrowIndicator;
                var undiscountedRate = _undiscountedRate; undiscountedRate.Clean = value; _undiscountedRate = undiscountedRate;
                var unimprovedAppraisedValue = _unimprovedAppraisedValue; unimprovedAppraisedValue.Clean = value; _unimprovedAppraisedValue = unimprovedAppraisedValue;
                var unimprovedEstimatedValue = _unimprovedEstimatedValue; unimprovedEstimatedValue.Clean = value; _unimprovedEstimatedValue = unimprovedEstimatedValue;
                var urlPage4Comments = _urlPage4Comments; urlPage4Comments.Clean = value; _urlPage4Comments = urlPage4Comments;
                var usdaGovernmentLoanType = _usdaGovernmentLoanType; usdaGovernmentLoanType.Clean = value; _usdaGovernmentLoanType = usdaGovernmentLoanType;
                var use2018DiIndicator = _use2018DiIndicator; use2018DiIndicator.Clean = value; _use2018DiIndicator = use2018DiIndicator;
                var useNew2015FormsIndicator = _useNew2015FormsIndicator; useNew2015FormsIndicator.Clean = value; _useNew2015FormsIndicator = useNew2015FormsIndicator;
                var useNewHudIndicator = _useNewHudIndicator; useNewHudIndicator.Clean = value; _useNewHudIndicator = useNewHudIndicator;
                var vAEntitlementAmount = _vAEntitlementAmount; vAEntitlementAmount.Clean = value; _vAEntitlementAmount = vAEntitlementAmount;
                var verificationLogs = _verificationLogs; verificationLogs.Clean = value; _verificationLogs = verificationLogs;
                var virtualFields = _virtualFields; virtualFields.Clean = value; _virtualFields = virtualFields;
                var websiteId = _websiteId; websiteId.Clean = value; _websiteId = websiteId;
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
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Loan()
        {
            Clean = true;
        }
    }
}