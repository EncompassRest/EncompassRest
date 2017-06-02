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
        private Value<List<EmailTriggerLog>> _emailTriggerLogs;
        public List<EmailTriggerLog> EmailTriggerLogs { get { return _emailTriggerLogs; } set { _emailTriggerLogs = value; } }
        public EmDocument EmDocument { get; set; }
        public EmDocumentInvestor EmDocumentInvestor { get; set; }
        public EmDocumentLender EmDocumentLender { get; set; }
        private Value<string> _emXmlVersionId;
        public string EmXmlVersionId { get { return _emXmlVersionId; } set { _emXmlVersionId = value; } }
        private Value<string> _encompassId;
        public string EncompassId { get { return _encompassId; } set { _encompassId = value; } }
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
                    && _emailTriggerLogs.Clean
                    && _emXmlVersionId.Clean
                    && _encompassId.Clean
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
                var v0 = _adverseActionDate; v0.Clean = value; _adverseActionDate = v0;
                var v1 = _affiliatedBusinessArrangements; v1.Clean = value; _affiliatedBusinessArrangements = v1;
                var v2 = _agencyCaseIdentifier; v2.Clean = value; _agencyCaseIdentifier = v2;
                var v3 = _alterationsImprovementsOrRepairsAmount; v3.Clean = value; _alterationsImprovementsOrRepairsAmount = v3;
                var v4 = _applications; v4.Clean = value; _applications = v4;
                var v5 = _applicationTakenMethodType; v5.Clean = value; _applicationTakenMethodType = v5;
                var v6 = _aprDisclosureDate; v6.Clean = value; _aprDisclosureDate = v6;
                var v7 = _armTypeDescription; v7.Clean = value; _armTypeDescription = v7;
                var v8 = _baseLoanAmount; v8.Clean = value; _baseLoanAmount = v8;
                var v9 = _belowMarketSubordinateFinancingIndicator; v9.Clean = value; _belowMarketSubordinateFinancingIndicator = v9;
                var v10 = _billingCategory; v10.Clean = value; _billingCategory = v10;
                var v11 = _biweeklyPaymentAmount; v11.Clean = value; _biweeklyPaymentAmount = v11;
                var v12 = _bLTV; v12.Clean = value; _bLTV = v12;
                var v13 = _borrowerCoBorrowerMarriedIndicator; v13.Clean = value; _borrowerCoBorrowerMarriedIndicator = v13;
                var v14 = _borrowerPaidClosingCostsAmount; v14.Clean = value; _borrowerPaidClosingCostsAmount = v14;
                var v15 = _borrowerPaidDiscountPointsAmount; v15.Clean = value; _borrowerPaidDiscountPointsAmount = v15;
                var v16 = _borrowerPaidFHAVAClosingCostsAmount; v16.Clean = value; _borrowerPaidFHAVAClosingCostsAmount = v16;
                var v17 = _borrowerRequestedLoanAmount; v17.Clean = value; _borrowerRequestedLoanAmount = v17;
                var v18 = _brokerPaidClosingCostsAmount; v18.Clean = value; _brokerPaidClosingCostsAmount = v18;
                var v19 = _buydownIndicator; v19.Clean = value; _buydownIndicator = v19;
                var v20 = _buydownMonthlyPaymentAmount; v20.Clean = value; _buydownMonthlyPaymentAmount = v20;
                var v21 = _buydownRatePercent; v21.Clean = value; _buydownRatePercent = v21;
                var v22 = _cashFromToBorrowerAmount; v22.Clean = value; _cashFromToBorrowerAmount = v22;
                var v23 = _channel; v23.Clean = value; _channel = v23;
                var v24 = _closingBillingDate; v24.Clean = value; _closingBillingDate = v24;
                var v25 = _closingCostProgram; v25.Clean = value; _closingCostProgram = v25;
                var v26 = _closingCostsAndPrepaidsFromOtherLienAmount; v26.Clean = value; _closingCostsAndPrepaidsFromOtherLienAmount = v26;
                var v27 = _closingCostsPaidByOthersAmount; v27.Clean = value; _closingCostsPaidByOthersAmount = v27;
                var v28 = _closingDocsStackingOrder; v28.Clean = value; _closingDocsStackingOrder = v28;
                var v29 = _collateralManagerScore; v29.Clean = value; _collateralManagerScore = v29;
                var v30 = _combinedLtv; v30.Clean = value; _combinedLtv = v30;
                var v31 = _commitmentNumber; v31.Clean = value; _commitmentNumber = v31;
                var v32 = _complianceTestLogs; v32.Clean = value; _complianceTestLogs = v32;
                var v33 = _conformingJumbo; v33.Clean = value; _conformingJumbo = v33;
                var v34 = _consumerConnectSiteID; v34.Clean = value; _consumerConnectSiteID = v34;
                var v35 = _contacts; v35.Clean = value; _contacts = v35;
                var v36 = _contactUpdatedIndicator; v36.Clean = value; _contactUpdatedIndicator = v36;
                var v37 = _contractSellerCreditAmount; v37.Clean = value; _contractSellerCreditAmount = v37;
                var v38 = _conversationLogs; v38.Clean = value; _conversationLogs = v38;
                var v39 = _copyBrokerToLenderIndicator; v39.Clean = value; _copyBrokerToLenderIndicator = v39;
                var v40 = _copyLoanNumLenderCaseNum; v40.Clean = value; _copyLoanNumLenderCaseNum = v40;
                var v41 = _creditScoreToUse; v41.Clean = value; _creditScoreToUse = v41;
                var v42 = _crmLogs; v42.Clean = value; _crmLogs = v42;
                var v43 = _currentApplicationIndex; v43.Clean = value; _currentApplicationIndex = v43;
                var v44 = _currentApplicationIsPrimary; v44.Clean = value; _currentApplicationIsPrimary = v44;
                var v45 = _currentFirstMortgageHolderType; v45.Clean = value; _currentFirstMortgageHolderType = v45;
                var v46 = _customFields; v46.Clean = value; _customFields = v46;
                var v47 = _dataTracLogs; v47.Clean = value; _dataTracLogs = v47;
                var v48 = _dBIndicator; v48.Clean = value; _dBIndicator = v48;
                var v49 = _deductOverwireAmountIndicator; v49.Clean = value; _deductOverwireAmountIndicator = v49;
                var v50 = _disableESignConsentAlert; v50.Clean = value; _disableESignConsentAlert = v50;
                var v51 = _disableKeyPricingAlert; v51.Clean = value; _disableKeyPricingAlert = v51;
                var v52 = _disclosureTracking2015Logs; v52.Clean = value; _disclosureTracking2015Logs = v52;
                var v53 = _disclosureTrackingLogs; v53.Clean = value; _disclosureTrackingLogs = v53;
                var v54 = _discountPoint; v54.Clean = value; _discountPoint = v54;
                var v55 = _docEngine; v55.Clean = value; _docEngine = v55;
                var v56 = _documentLogs; v56.Clean = value; _documentLogs = v56;
                var v57 = _doNotCheckEmail; v57.Clean = value; _doNotCheckEmail = v57;
                var v58 = _doNotPrintCompensationFees; v58.Clean = value; _doNotPrintCompensationFees = v58;
                var v59 = _downloadLogs; v59.Clean = value; _downloadLogs = v59;
                var v60 = _downPaymentPercent; v60.Clean = value; _downPaymentPercent = v60;
                var v61 = _edmLogs; v61.Clean = value; _edmLogs = v61;
                var v62 = _emailTriggerLogs; v62.Clean = value; _emailTriggerLogs = v62;
                var v63 = _emXmlVersionId; v63.Clean = value; _emXmlVersionId = v63;
                var v64 = _encompassId; v64.Clean = value; _encompassId = v64;
                var v65 = _enforceCountyLoanLimit; v65.Clean = value; _enforceCountyLoanLimit = v65;
                var v66 = _estimatedClosingCostsAmount; v66.Clean = value; _estimatedClosingCostsAmount = v66;
                var v67 = _estimatedConstructionInterest; v67.Clean = value; _estimatedConstructionInterest = v67;
                var v68 = _estimatedPrepaidItemsAmount; v68.Clean = value; _estimatedPrepaidItemsAmount = v68;
                var v69 = _exportLoanNumber; v69.Clean = value; _exportLoanNumber = v69;
                var v70 = _fees; v70.Clean = value; _fees = v70;
                var v71 = _fhaMiPremiumRefundAmount; v71.Clean = value; _fhaMiPremiumRefundAmount = v71;
                var v72 = _fHAVALoanOriginatorIdentifier; v72.Clean = value; _fHAVALoanOriginatorIdentifier = v72;
                var v73 = _fieldLockData; v73.Clean = value; _fieldLockData = v73;
                var v74 = _firstAdjustmentMinimum; v74.Clean = value; _firstAdjustmentMinimum = v74;
                var v75 = _firstSubordinateLienAmount; v75.Clean = value; _firstSubordinateLienAmount = v75;
                var v76 = _firstTimeHomebuyersIndicator; v76.Clean = value; _firstTimeHomebuyersIndicator = v76;
                var v77 = _fnmCommunityLendingProductName; v77.Clean = value; _fnmCommunityLendingProductName = v77;
                var v78 = _fnmCommunitySecondsIndicator; v78.Clean = value; _fnmCommunitySecondsIndicator = v78;
                var v79 = _fnmNeighborsMortgageEligibilityIndicator; v79.Clean = value; _fnmNeighborsMortgageEligibilityIndicator = v79;
                var v80 = _forms; v80.Clean = value; _forms = v80;
                var v81 = _fraudScore; v81.Clean = value; _fraudScore = v81;
                var v82 = _fundingDeductionList; v82.Clean = value; _fundingDeductionList = v82;
                var v83 = _fundingFeeList; v83.Clean = value; _fundingFeeList = v83;
                var v84 = _fundingFees; v84.Clean = value; _fundingFees = v84;
                var v85 = _governmentLoanLenderIdentifier; v85.Clean = value; _governmentLoanLenderIdentifier = v85;
                var v86 = _governmentLoanSponsorIdentifier; v86.Clean = value; _governmentLoanSponsorIdentifier = v86;
                var v87 = _governmentMortgageCreditCertificateAmount; v87.Clean = value; _governmentMortgageCreditCertificateAmount = v87;
                var v88 = _hasAbusinessRelationshipWith; v88.Clean = value; _hasAbusinessRelationshipWith = v88;
                var v89 = _hcltvHtltv; v89.Clean = value; _hcltvHtltv = v89;
                var v90 = _helocTeaserRate; v90.Clean = value; _helocTeaserRate = v90;
                var v91 = _homeCounselingProviders; v91.Clean = value; _homeCounselingProviders = v91;
                var v92 = _homeCounselingProvidersDistance; v92.Clean = value; _homeCounselingProvidersDistance = v92;
                var v93 = _homeCounselingProvidersLanguageNames; v93.Clean = value; _homeCounselingProvidersLanguageNames = v93;
                var v94 = _homeCounselingProvidersServiceNames; v94.Clean = value; _homeCounselingProvidersServiceNames = v94;
                var v95 = _householdSizeCount; v95.Clean = value; _householdSizeCount = v95;
                var v96 = _htmlEmailLogs; v96.Clean = value; _htmlEmailLogs = v96;
                var v97 = _hudIncomeLimitAdjustmentFactor; v97.Clean = value; _hudIncomeLimitAdjustmentFactor = v97;
                var v98 = _hudLendingIncomeLimitAmount; v98.Clean = value; _hudLendingIncomeLimitAmount = v98;
                var v99 = _hudMedianIncomeAmount; v99.Clean = value; _hudMedianIncomeAmount = v99;
                var v100 = _id; v100.Clean = value; _id = v100;
                var v101 = _includeUSDAFeeInClosing; v101.Clean = value; _includeUSDAFeeInClosing = v101;
                var v102 = _initialInterestRate; v102.Clean = value; _initialInterestRate = v102;
                var v103 = _insuranceAuthorizationIndicator; v103.Clean = value; _insuranceAuthorizationIndicator = v103;
                var v104 = _interviewerApplicationSignedDate; v104.Clean = value; _interviewerApplicationSignedDate = v104;
                var v105 = _interviewerEmail; v105.Clean = value; _interviewerEmail = v105;
                var v106 = _interviewerLicenseIdentifier; v106.Clean = value; _interviewerLicenseIdentifier = v106;
                var v107 = _interviewerPhoneNumber; v107.Clean = value; _interviewerPhoneNumber = v107;
                var v108 = _interviewersCompanyStateLicense; v108.Clean = value; _interviewersCompanyStateLicense = v108;
                var v109 = _interviewersId; v109.Clean = value; _interviewersId = v109;
                var v110 = _inverviewerName; v110.Clean = value; _inverviewerName = v110;
                var v111 = _isCreditorProhibitsBorrower; v111.Clean = value; _isCreditorProhibitsBorrower = v111;
                var v112 = _isEmployeeLoan; v112.Clean = value; _isEmployeeLoan = v112;
                var v113 = _isLSSecondaryFile; v113.Clean = value; _isLSSecondaryFile = v113;
                var v114 = _isRequiredInterestReserveCompoundInterest; v114.Clean = value; _isRequiredInterestReserveCompoundInterest = v114;
                var v115 = _landIfAcquiredSeperatelyAmount; v115.Clean = value; _landIfAcquiredSeperatelyAmount = v115;
                var v116 = _leadSource; v116.Clean = value; _leadSource = v116;
                var v117 = _lenderCaseIdentifier; v117.Clean = value; _lenderCaseIdentifier = v117;
                var v118 = _lenderChannel; v118.Clean = value; _lenderChannel = v118;
                var v119 = _lenderCreditsInFunding; v119.Clean = value; _lenderCreditsInFunding = v119;
                var v120 = _lenderInvestorCode; v120.Clean = value; _lenderInvestorCode = v120;
                var v121 = _lenderPaidClosignCostsDotAmount; v121.Clean = value; _lenderPaidClosignCostsDotAmount = v121;
                var v122 = _lenderPaidClosingCostsAmount; v122.Clean = value; _lenderPaidClosingCostsAmount = v122;
                var v123 = _lesserAppraisedValueOrSalesPrice; v123.Clean = value; _lesserAppraisedValueOrSalesPrice = v123;
                var v124 = _lifeInsuranceCoverageAmount; v124.Clean = value; _lifeInsuranceCoverageAmount = v124;
                var v125 = _lifeInsuranceEstimatedMonthlyAmount; v125.Clean = value; _lifeInsuranceEstimatedMonthlyAmount = v125;
                var v126 = _lifeInsuranceTotalProtectedMonthlyAmount; v126.Clean = value; _lifeInsuranceTotalProtectedMonthlyAmount = v126;
                var v127 = _linkId; v127.Clean = value; _linkId = v127;
                var v128 = _loanActionLogs; v128.Clean = value; _loanActionLogs = v128;
                var v129 = _loanAmortizationTermMonths; v129.Clean = value; _loanAmortizationTermMonths = v129;
                var v130 = _loanAmortizationType; v130.Clean = value; _loanAmortizationType = v130;
                var v131 = _loanCreatedDate; v131.Clean = value; _loanCreatedDate = v131;
                var v132 = _loanCreatedDateUtc; v132.Clean = value; _loanCreatedDateUtc = v132;
                var v133 = _loanIdNumber; v133.Clean = value; _loanIdNumber = v133;
                var v134 = _loanImportStatusIndicator; v134.Clean = value; _loanImportStatusIndicator = v134;
                var v135 = _loanLinkSyncType; v135.Clean = value; _loanLinkSyncType = v135;
                var v136 = _loanNumber; v136.Clean = value; _loanNumber = v136;
                var v137 = _loanProgramName; v137.Clean = value; _loanProgramName = v137;
                var v138 = _loanPrograms; v138.Clean = value; _loanPrograms = v138;
                var v139 = _loanPurposeOfRefinanceType; v139.Clean = value; _loanPurposeOfRefinanceType = v139;
                var v140 = _loanSource; v140.Clean = value; _loanSource = v140;
                var v141 = _loanTotalProposedMonthlyMaintenanceAmount; v141.Clean = value; _loanTotalProposedMonthlyMaintenanceAmount = v141;
                var v142 = _loanTotalProposedMonthlyUtilitiesAmount; v142.Clean = value; _loanTotalProposedMonthlyUtilitiesAmount = v142;
                var v143 = _loanUnderwriterCHUMSIdentifier; v143.Clean = value; _loanUnderwriterCHUMSIdentifier = v143;
                var v144 = _loanVALoanProcedureType; v144.Clean = value; _loanVALoanProcedureType = v144;
                var v145 = _loanVARateReductionInitialComputationTotalAmount; v145.Clean = value; _loanVARateReductionInitialComputationTotalAmount = v145;
                var v146 = _loanVAResidualIncomeAmount; v146.Clean = value; _loanVAResidualIncomeAmount = v146;
                var v147 = _loanVersionId; v147.Clean = value; _loanVersionId = v147;
                var v148 = _lockConfirmLogs; v148.Clean = value; _lockConfirmLogs = v148;
                var v149 = _lockDenialLogs; v149.Clean = value; _lockDenialLogs = v149;
                var v150 = _lockRequestLogs; v150.Clean = value; _lockRequestLogs = v150;
                var v151 = _logEntryLogs; v151.Clean = value; _logEntryLogs = v151;
                var v152 = _ltv; v152.Clean = value; _ltv = v152;
                var v153 = _ltvPropertyValue; v153.Clean = value; _ltvPropertyValue = v153;
                var v154 = _masterCommitmentNumber; v154.Clean = value; _masterCommitmentNumber = v154;
                var v155 = _maturityDate; v155.Clean = value; _maturityDate = v155;
                var v156 = _maxBackRatio; v156.Clean = value; _maxBackRatio = v156;
                var v157 = _maxFrontRatio; v157.Clean = value; _maxFrontRatio = v157;
                var v158 = _mersNumber; v158.Clean = value; _mersNumber = v158;
                var v159 = _mersNumberRegistrationDate; v159.Clean = value; _mersNumberRegistrationDate = v159;
                var v160 = _miAndFundingFeeFinancedAmount; v160.Clean = value; _miAndFundingFeeFinancedAmount = v160;
                var v161 = _miAndFundingFeeTotalAmount; v161.Clean = value; _miAndFundingFeeTotalAmount = v161;
                var v162 = _milestoneApprovedDate; v162.Clean = value; _milestoneApprovedDate = v162;
                var v163 = _milestoneApprovedDueDate; v163.Clean = value; _milestoneApprovedDueDate = v163;
                var v164 = _milestoneCompletedDate; v164.Clean = value; _milestoneCompletedDate = v164;
                var v165 = _milestoneCompletedDueDate; v165.Clean = value; _milestoneCompletedDueDate = v165;
                var v166 = _milestoneCurrentDateUtc; v166.Clean = value; _milestoneCurrentDateUtc = v166;
                var v167 = _milestoneCurrentName; v167.Clean = value; _milestoneCurrentName = v167;
                var v168 = _milestoneDocSignedDate; v168.Clean = value; _milestoneDocSignedDate = v168;
                var v169 = _milestoneDocSignedDueDate; v169.Clean = value; _milestoneDocSignedDueDate = v169;
                var v170 = _milestoneDuration; v170.Clean = value; _milestoneDuration = v170;
                var v171 = _milestoneFileStartedDate; v171.Clean = value; _milestoneFileStartedDate = v171;
                var v172 = _milestoneFreeRoleLogs; v172.Clean = value; _milestoneFreeRoleLogs = v172;
                var v173 = _milestoneFundedDate; v173.Clean = value; _milestoneFundedDate = v173;
                var v174 = _milestoneFundedDueDate; v174.Clean = value; _milestoneFundedDueDate = v174;
                var v175 = _milestoneLogs; v175.Clean = value; _milestoneLogs = v175;
                var v176 = _milestoneProcessedDate; v176.Clean = value; _milestoneProcessedDate = v176;
                var v177 = _milestoneStage; v177.Clean = value; _milestoneStage = v177;
                var v178 = _milestoneSubmittedDate; v178.Clean = value; _milestoneSubmittedDate = v178;
                var v179 = _milestoneSubmittedDueDate; v179.Clean = value; _milestoneSubmittedDueDate = v179;
                var v180 = _milestoneTaskLogs; v180.Clean = value; _milestoneTaskLogs = v180;
                var v181 = _milestoneTemplateLogs; v181.Clean = value; _milestoneTemplateLogs = v181;
                var v182 = _mipBorrowerPaidInCashAmount; v182.Clean = value; _mipBorrowerPaidInCashAmount = v182;
                var v183 = _mipPaidInCashAmount; v183.Clean = value; _mipPaidInCashAmount = v183;
                var v184 = _monthlyPIPaymentAmountForLE1andCD1; v184.Clean = value; _monthlyPIPaymentAmountForLE1andCD1 = v184;
                var v185 = _mortgageInsurancePremiumFHARefundAmount; v185.Clean = value; _mortgageInsurancePremiumFHARefundAmount = v185;
                var v186 = _mortgageInsurancePremiumUpfrontFactorPercent; v186.Clean = value; _mortgageInsurancePremiumUpfrontFactorPercent = v186;
                var v187 = _mortgageType; v187.Clean = value; _mortgageType = v187;
                var v188 = _msaIdentifier; v188.Clean = value; _msaIdentifier = v188;
                var v189 = _newFirstMortgageAmount; v189.Clean = value; _newFirstMortgageAmount = v189;
                var v190 = _nmlsLoanOriginatorId; v190.Clean = value; _nmlsLoanOriginatorId = v190;
                var v191 = _noClosingCostOption; v191.Clean = value; _noClosingCostOption = v191;
                var v192 = _notRequiredForPurchaseSaleOrRefinance; v192.Clean = value; _notRequiredForPurchaseSaleOrRefinance = v192;
                var v193 = _notRequiredForSettlementOfYourLoan; v193.Clean = value; _notRequiredForSettlementOfYourLoan = v193;
                var v194 = _occupancyType; v194.Clean = value; _occupancyType = v194;
                var v195 = _openingDocsInvestorCode; v195.Clean = value; _openingDocsInvestorCode = v195;
                var v196 = _openingDocsLoanProgramType; v196.Clean = value; _openingDocsLoanProgramType = v196;
                var v197 = _openingDocsPlanDescription; v197.Clean = value; _openingDocsPlanDescription = v197;
                var v198 = _openingDocsPlanId; v198.Clean = value; _openingDocsPlanId = v198;
                var v199 = _openingDocsProgramCode; v199.Clean = value; _openingDocsProgramCode = v199;
                var v200 = _openingDocsStackingOrder; v200.Clean = value; _openingDocsStackingOrder = v200;
                var v201 = _organizationCode; v201.Clean = value; _organizationCode = v201;
                var v202 = _originationDate; v202.Clean = value; _originationDate = v202;
                var v203 = _otherAmortizationTypeDescription; v203.Clean = value; _otherAmortizationTypeDescription = v203;
                var v204 = _otherMortgageTypeDescription; v204.Clean = value; _otherMortgageTypeDescription = v204;
                var v205 = _otherPaidClosingCostsAmount; v205.Clean = value; _otherPaidClosingCostsAmount = v205;
                var v206 = _overwireAmount; v206.Clean = value; _overwireAmount = v206;
                var v207 = _paymentScheduleCalcRequiredIndicator; v207.Clean = value; _paymentScheduleCalcRequiredIndicator = v207;
                var v208 = _percentageOfOwnership; v208.Clean = value; _percentageOfOwnership = v208;
                var v209 = _percentageOwnershipInterest; v209.Clean = value; _percentageOwnershipInterest = v209;
                var v210 = _pmiIndicator; v210.Clean = value; _pmiIndicator = v210;
                var v211 = _postClosingConditionLogs; v211.Clean = value; _postClosingConditionLogs = v211;
                var v212 = _preliminaryConditionLogs; v212.Clean = value; _preliminaryConditionLogs = v212;
                var v213 = _principalAndInterestMonthlyPaymentAmount; v213.Clean = value; _principalAndInterestMonthlyPaymentAmount = v213;
                var v214 = _print2003Application; v214.Clean = value; _print2003Application = v214;
                var v215 = _printLogs; v215.Clean = value; _printLogs = v215;
                var v216 = _propertyAppraisedValueAmount; v216.Clean = value; _propertyAppraisedValueAmount = v216;
                var v217 = _propertyEnergyEfficientHomeIndicator; v217.Clean = value; _propertyEnergyEfficientHomeIndicator = v217;
                var v218 = _propertyEstimatedValueAmount; v218.Clean = value; _propertyEstimatedValueAmount = v218;
                var v219 = _proposedDuesAmount; v219.Clean = value; _proposedDuesAmount = v219;
                var v220 = _proposedFirstMortgageAmount; v220.Clean = value; _proposedFirstMortgageAmount = v220;
                var v221 = _proposedGroundRentAmount; v221.Clean = value; _proposedGroundRentAmount = v221;
                var v222 = _proposedHazardInsuranceAmount; v222.Clean = value; _proposedHazardInsuranceAmount = v222;
                var v223 = _proposedHousingExpenseTotal; v223.Clean = value; _proposedHousingExpenseTotal = v223;
                var v224 = _proposedMortgageInsuranceAmount; v224.Clean = value; _proposedMortgageInsuranceAmount = v224;
                var v225 = _proposedOtherAmount; v225.Clean = value; _proposedOtherAmount = v225;
                var v226 = _proposedOtherMortgagesAmount; v226.Clean = value; _proposedOtherMortgagesAmount = v226;
                var v227 = _proposedRealEstateTaxesAmount; v227.Clean = value; _proposedRealEstateTaxesAmount = v227;
                var v228 = _purchaseCredits; v228.Clean = value; _purchaseCredits = v228;
                var v229 = _purchasePriceAmount; v229.Clean = value; _purchasePriceAmount = v229;
                var v230 = _referralAddress; v230.Clean = value; _referralAddress = v230;
                var v231 = _referralCity; v231.Clean = value; _referralCity = v231;
                var v232 = _referralFeeAmount; v232.Clean = value; _referralFeeAmount = v232;
                var v233 = _referralPostalCode; v233.Clean = value; _referralPostalCode = v233;
                var v234 = _referralSource; v234.Clean = value; _referralSource = v234;
                var v235 = _referralState; v235.Clean = value; _referralState = v235;
                var v236 = _refinanceIncludingDebtsToBePaidOffAmount; v236.Clean = value; _refinanceIncludingDebtsToBePaidOffAmount = v236;
                var v237 = _registrationLogs; v237.Clean = value; _registrationLogs = v237;
                var v238 = _removedLogRecords; v238.Clean = value; _removedLogRecords = v238;
                var v239 = _repurchaseCostAmount; v239.Clean = value; _repurchaseCostAmount = v239;
                var v240 = _repurchaseDate; v240.Clean = value; _repurchaseDate = v240;
                var v241 = _requestedInterestRatePercent; v241.Clean = value; _requestedInterestRatePercent = v241;
                var v242 = _salesConcessionAmount; v242.Clean = value; _salesConcessionAmount = v242;
                var v243 = _secondSubordinateAmount; v243.Clean = value; _secondSubordinateAmount = v243;
                var v244 = _sectionOfActType; v244.Clean = value; _sectionOfActType = v244;
                var v245 = _sellerPaidClosingCostsAmount; v245.Clean = value; _sellerPaidClosingCostsAmount = v245;
                var v246 = _serviceProviderAdditionalInfo; v246.Clean = value; _serviceProviderAdditionalInfo = v246;
                var v247 = _serviceProviderContacts; v247.Clean = value; _serviceProviderContacts = v247;
                var v248 = _serviceProviderDateIssued; v248.Clean = value; _serviceProviderDateIssued = v248;
                var v249 = _setForSettlementServicesOfAnAttorney; v249.Clean = value; _setForSettlementServicesOfAnAttorney = v249;
                var v250 = _setForTheSettlementServicesListed; v250.Clean = value; _setForTheSettlementServicesListed = v250;
                var v251 = _settlementServiceCharges; v251.Clean = value; _settlementServiceCharges = v251;
                var v252 = _simpleRefinanceType; v252.Clean = value; _simpleRefinanceType = v252;
                var v253 = _startingAdjPrice; v253.Clean = value; _startingAdjPrice = v253;
                var v254 = _startingAdjRate; v254.Clean = value; _startingAdjRate = v254;
                var v255 = _statusOnlineLogs; v255.Clean = value; _statusOnlineLogs = v255;
                var v256 = _subjectPropertyGrossRentalIncomeAmount; v256.Clean = value; _subjectPropertyGrossRentalIncomeAmount = v256;
                var v257 = _subjectPropertyOccupancyPercent; v257.Clean = value; _subjectPropertyOccupancyPercent = v257;
                var v258 = _subordinateLienAmount; v258.Clean = value; _subordinateLienAmount = v258;
                var v259 = _systemIdGuid; v259.Clean = value; _systemIdGuid = v259;
                var v260 = _tilApplicationDate; v260.Clean = value; _tilApplicationDate = v260;
                var v261 = _titleHolderName1; v261.Clean = value; _titleHolderName1 = v261;
                var v262 = _titleHolderName2; v262.Clean = value; _titleHolderName2 = v262;
                var v263 = _tltv; v263.Clean = value; _tltv = v263;
                var v264 = _totalClosingCostsAmount; v264.Clean = value; _totalClosingCostsAmount = v264;
                var v265 = _totalDeductionsAmount; v265.Clean = value; _totalDeductionsAmount = v265;
                var v266 = _totalFeesCostAmount; v266.Clean = value; _totalFeesCostAmount = v266;
                var v267 = _totalFeesCreditAmount; v267.Clean = value; _totalFeesCreditAmount = v267;
                var v268 = _totalNonborrowerPaidClosingCostsAmount; v268.Clean = value; _totalNonborrowerPaidClosingCostsAmount = v268;
                var v269 = _totalPaidOutsideClosingAmount; v269.Clean = value; _totalPaidOutsideClosingAmount = v269;
                var v270 = _totalPaidToBrokerAmount; v270.Clean = value; _totalPaidToBrokerAmount = v270;
                var v271 = _totalWireTransferAmount; v271.Clean = value; _totalWireTransferAmount = v271;
                var v272 = _twelveMonthMortgageRentalHistoryIndicator; v272.Clean = value; _twelveMonthMortgageRentalHistoryIndicator = v272;
                var v273 = _underwritingConditionLogs; v273.Clean = value; _underwritingConditionLogs = v273;
                var v274 = _underwritingEscrowIndicator; v274.Clean = value; _underwritingEscrowIndicator = v274;
                var v275 = _undiscountedRate; v275.Clean = value; _undiscountedRate = v275;
                var v276 = _unimprovedAppraisedValue; v276.Clean = value; _unimprovedAppraisedValue = v276;
                var v277 = _unimprovedEstimatedValue; v277.Clean = value; _unimprovedEstimatedValue = v277;
                var v278 = _urlPage4Comments; v278.Clean = value; _urlPage4Comments = v278;
                var v279 = _usdaGovernmentLoanType; v279.Clean = value; _usdaGovernmentLoanType = v279;
                var v280 = _use2018DiIndicator; v280.Clean = value; _use2018DiIndicator = v280;
                var v281 = _useNew2015FormsIndicator; v281.Clean = value; _useNew2015FormsIndicator = v281;
                var v282 = _useNewHudIndicator; v282.Clean = value; _useNewHudIndicator = v282;
                var v283 = _vAEntitlementAmount; v283.Clean = value; _vAEntitlementAmount = v283;
                var v284 = _verificationLogs; v284.Clean = value; _verificationLogs = v284;
                var v285 = _virtualFields; v285.Clean = value; _virtualFields = v285;
                var v286 = _websiteId; v286.Clean = value; _websiteId = v286;
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