using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Loan : IDirty
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
        //private Value<string> _elliUCDFields;
        //public string ElliUCDFields { get { return _elliUCDFields; } set { _elliUCDFields = value; } }
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
        //private Value<string> _virtualFields;
        //public string VirtualFields { get { return _virtualFields; } set { _virtualFields = value; } }
        private Value<string> _websiteId;
        public string WebsiteId { get { return _websiteId; } set { _websiteId = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _adverseActionDate.Dirty
                    || _affiliatedBusinessArrangements.Dirty
                    || _agencyCaseIdentifier.Dirty
                    || _alterationsImprovementsOrRepairsAmount.Dirty
                    || _applications.Dirty
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
                    || _complianceTestLogs.Dirty
                    || _conformingJumbo.Dirty
                    || _consumerConnectSiteID.Dirty
                    || _contacts.Dirty
                    || _contactUpdatedIndicator.Dirty
                    || _contractSellerCreditAmount.Dirty
                    || _conversationLogs.Dirty
                    || _copyBrokerToLenderIndicator.Dirty
                    || _copyLoanNumLenderCaseNum.Dirty
                    || _creditScoreToUse.Dirty
                    || _crmLogs.Dirty
                    || _currentApplicationIndex.Dirty
                    || _currentApplicationIsPrimary.Dirty
                    || _currentFirstMortgageHolderType.Dirty
                    || _customFields.Dirty
                    || _dataTracLogs.Dirty
                    || _dBIndicator.Dirty
                    || _deductOverwireAmountIndicator.Dirty
                    || _disableESignConsentAlert.Dirty
                    || _disableKeyPricingAlert.Dirty
                    || _disclosureTracking2015Logs.Dirty
                    || _disclosureTrackingLogs.Dirty
                    || _discountPoint.Dirty
                    || _docEngine.Dirty
                    || _documentLogs.Dirty
                    || _doNotCheckEmail.Dirty
                    || _doNotPrintCompensationFees.Dirty
                    || _downloadLogs.Dirty
                    || _downPaymentPercent.Dirty
                    || _edmLogs.Dirty
                    //|| _elliUCDFields.Dirty
                    || _emailTriggerLogs.Dirty
                    || _emXmlVersionId.Dirty
                    || _encompassId.Dirty
                    || _encompassVersion.Dirty
                    || _enforceCountyLoanLimit.Dirty
                    || _estimatedClosingCostsAmount.Dirty
                    || _estimatedConstructionInterest.Dirty
                    || _estimatedPrepaidItemsAmount.Dirty
                    || _exportLoanNumber.Dirty
                    || _fees.Dirty
                    || _fhaMiPremiumRefundAmount.Dirty
                    || _fHAVALoanOriginatorIdentifier.Dirty
                    || _fieldLockData.Dirty
                    || _firstAdjustmentMinimum.Dirty
                    || _firstSubordinateLienAmount.Dirty
                    || _firstTimeHomebuyersIndicator.Dirty
                    || _fnmCommunityLendingProductName.Dirty
                    || _fnmCommunitySecondsIndicator.Dirty
                    || _fnmNeighborsMortgageEligibilityIndicator.Dirty
                    || _forms.Dirty
                    || _fraudScore.Dirty
                    || _fundingDeductionList.Dirty
                    || _fundingFeeList.Dirty
                    || _fundingFees.Dirty
                    || _governmentLoanLenderIdentifier.Dirty
                    || _governmentLoanSponsorIdentifier.Dirty
                    || _governmentMortgageCreditCertificateAmount.Dirty
                    || _hasAbusinessRelationshipWith.Dirty
                    || _hcltvHtltv.Dirty
                    || _helocTeaserRate.Dirty
                    || _homeCounselingProviders.Dirty
                    || _homeCounselingProvidersDistance.Dirty
                    || _homeCounselingProvidersLanguageNames.Dirty
                    || _homeCounselingProvidersServiceNames.Dirty
                    || _householdSizeCount.Dirty
                    || _htmlEmailLogs.Dirty
                    || _hudIncomeLimitAdjustmentFactor.Dirty
                    || _hudLendingIncomeLimitAmount.Dirty
                    || _hudMedianIncomeAmount.Dirty
                    || _id.Dirty
                    || _includeUSDAFeeInClosing.Dirty
                    || _initialInterestRate.Dirty
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
                    || _linkId.Dirty
                    || _loanActionLogs.Dirty
                    || _loanAmortizationTermMonths.Dirty
                    || _loanAmortizationType.Dirty
                    || _loanCreatedDate.Dirty
                    || _loanCreatedDateUtc.Dirty
                    || _loanIdNumber.Dirty
                    || _loanImportStatusIndicator.Dirty
                    || _loanLinkSyncType.Dirty
                    || _loanNumber.Dirty
                    || _loanProgramName.Dirty
                    || _loanPrograms.Dirty
                    || _loanPurposeOfRefinanceType.Dirty
                    || _loanSource.Dirty
                    || _loanTotalProposedMonthlyMaintenanceAmount.Dirty
                    || _loanTotalProposedMonthlyUtilitiesAmount.Dirty
                    || _loanUnderwriterCHUMSIdentifier.Dirty
                    || _loanVALoanProcedureType.Dirty
                    || _loanVARateReductionInitialComputationTotalAmount.Dirty
                    || _loanVAResidualIncomeAmount.Dirty
                    || _loanVersionId.Dirty
                    || _lockConfirmLogs.Dirty
                    || _lockDenialLogs.Dirty
                    || _lockRequestLogs.Dirty
                    || _logEntryLogs.Dirty
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
                    || _milestoneFreeRoleLogs.Dirty
                    || _milestoneFundedDate.Dirty
                    || _milestoneFundedDueDate.Dirty
                    || _milestoneLogs.Dirty
                    || _milestoneProcessedDate.Dirty
                    || _milestoneStage.Dirty
                    || _milestoneSubmittedDate.Dirty
                    || _milestoneSubmittedDueDate.Dirty
                    || _milestoneTaskLogs.Dirty
                    || _milestoneTemplateLogs.Dirty
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
                    || _postClosingConditionLogs.Dirty
                    || _preliminaryConditionLogs.Dirty
                    || _principalAndInterestMonthlyPaymentAmount.Dirty
                    || _print2003Application.Dirty
                    || _printLogs.Dirty
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
                    || _purchaseCredits.Dirty
                    || _purchasePriceAmount.Dirty
                    || _referralAddress.Dirty
                    || _referralCity.Dirty
                    || _referralFeeAmount.Dirty
                    || _referralPostalCode.Dirty
                    || _referralSource.Dirty
                    || _referralState.Dirty
                    || _refinanceIncludingDebtsToBePaidOffAmount.Dirty
                    || _registrationLogs.Dirty
                    || _removedLogRecords.Dirty
                    || _repurchaseCostAmount.Dirty
                    || _repurchaseDate.Dirty
                    || _requestedInterestRatePercent.Dirty
                    || _salesConcessionAmount.Dirty
                    || _secondSubordinateAmount.Dirty
                    || _sectionOfActType.Dirty
                    || _sellerPaidClosingCostsAmount.Dirty
                    || _serviceProviderAdditionalInfo.Dirty
                    || _serviceProviderContacts.Dirty
                    || _serviceProviderDateIssued.Dirty
                    || _setForSettlementServicesOfAnAttorney.Dirty
                    || _setForTheSettlementServicesListed.Dirty
                    || _settlementServiceCharges.Dirty
                    || _simpleRefinanceType.Dirty
                    || _startingAdjPrice.Dirty
                    || _startingAdjRate.Dirty
                    || _statusOnlineLogs.Dirty
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
                    || _underwritingConditionLogs.Dirty
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
                    || _verificationLogs.Dirty
                    //|| _virtualFields.Dirty
                    || _websiteId.Dirty
                    || AdditionalRequests?.Dirty == true
                    || ATRQMCommon?.Dirty == true
                    || ClosingCost?.Dirty == true
                    || ClosingDocument?.Dirty == true
                    || CommitmentTerms?.Dirty == true
                    || ConstructionManagement?.Dirty == true
                    || Correspondent?.Dirty == true
                    || CurrentApplication?.Dirty == true
                    || CustomModelFields?.Dirty == true
                    || DisclosureNotices?.Dirty == true
                    || DownPayment?.Dirty == true
                    || EmDocument?.Dirty == true
                    || EmDocumentInvestor?.Dirty == true
                    || EmDocumentLender?.Dirty == true
                    || FannieMae?.Dirty == true
                    || FhaVaLoan?.Dirty == true
                    || FreddieMac?.Dirty == true
                    || Funding?.Dirty == true
                    || Gfe?.Dirty == true
                    || Hmda?.Dirty == true
                    || Hud1Es?.Dirty == true
                    || HudLoanData?.Dirty == true
                    || InterimServicing?.Dirty == true
                    || LoanProductData?.Dirty == true
                    || LoanSubmission?.Dirty == true
                    || LOCompensation?.Dirty == true
                    || Mcaw?.Dirty == true
                    || Miscellaneous?.Dirty == true
                    || NetTangibleBenefit?.Dirty == true
                    || Prequalification?.Dirty == true
                    || PrivacyPolicy?.Dirty == true
                    || ProfitManagement?.Dirty == true
                    || Property?.Dirty == true
                    || RateLock?.Dirty == true
                    || RegulationZ?.Dirty == true
                    || Section32?.Dirty == true
                    || SelectedHomeCounselingProvider?.Dirty == true
                    || ServicingDisclosure?.Dirty == true
                    || Shipping?.Dirty == true
                    || StateDisclosure?.Dirty == true
                    || StatementCreditDenial?.Dirty == true
                    || TPO?.Dirty == true
                    || TQL?.Dirty == true
                    || TrustAccount?.Dirty == true
                    || Tsum?.Dirty == true
                    || Uldd?.Dirty == true
                    || UnderwriterSummary?.Dirty == true
                    || Usda?.Dirty == true
                    || VaLoanData?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _adverseActionDate.Dirty = value;
                _affiliatedBusinessArrangements.Dirty = value;
                _agencyCaseIdentifier.Dirty = value;
                _alterationsImprovementsOrRepairsAmount.Dirty = value;
                _applications.Dirty = value;
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
                _complianceTestLogs.Dirty = value;
                _conformingJumbo.Dirty = value;
                _consumerConnectSiteID.Dirty = value;
                _contacts.Dirty = value;
                _contactUpdatedIndicator.Dirty = value;
                _contractSellerCreditAmount.Dirty = value;
                _conversationLogs.Dirty = value;
                _copyBrokerToLenderIndicator.Dirty = value;
                _copyLoanNumLenderCaseNum.Dirty = value;
                _creditScoreToUse.Dirty = value;
                _crmLogs.Dirty = value;
                _currentApplicationIndex.Dirty = value;
                _currentApplicationIsPrimary.Dirty = value;
                _currentFirstMortgageHolderType.Dirty = value;
                _customFields.Dirty = value;
                _dataTracLogs.Dirty = value;
                _dBIndicator.Dirty = value;
                _deductOverwireAmountIndicator.Dirty = value;
                _disableESignConsentAlert.Dirty = value;
                _disableKeyPricingAlert.Dirty = value;
                _disclosureTracking2015Logs.Dirty = value;
                _disclosureTrackingLogs.Dirty = value;
                _discountPoint.Dirty = value;
                _docEngine.Dirty = value;
                _documentLogs.Dirty = value;
                _doNotCheckEmail.Dirty = value;
                _doNotPrintCompensationFees.Dirty = value;
                _downloadLogs.Dirty = value;
                _downPaymentPercent.Dirty = value;
                _edmLogs.Dirty = value;
                //_elliUCDFields.Dirty = value;
                _emailTriggerLogs.Dirty = value;
                _emXmlVersionId.Dirty = value;
                _encompassId.Dirty = value;
                _encompassVersion.Dirty = value;
                _enforceCountyLoanLimit.Dirty = value;
                _estimatedClosingCostsAmount.Dirty = value;
                _estimatedConstructionInterest.Dirty = value;
                _estimatedPrepaidItemsAmount.Dirty = value;
                _exportLoanNumber.Dirty = value;
                _fees.Dirty = value;
                _fhaMiPremiumRefundAmount.Dirty = value;
                _fHAVALoanOriginatorIdentifier.Dirty = value;
                _fieldLockData.Dirty = value;
                _firstAdjustmentMinimum.Dirty = value;
                _firstSubordinateLienAmount.Dirty = value;
                _firstTimeHomebuyersIndicator.Dirty = value;
                _fnmCommunityLendingProductName.Dirty = value;
                _fnmCommunitySecondsIndicator.Dirty = value;
                _fnmNeighborsMortgageEligibilityIndicator.Dirty = value;
                _forms.Dirty = value;
                _fraudScore.Dirty = value;
                _fundingDeductionList.Dirty = value;
                _fundingFeeList.Dirty = value;
                _fundingFees.Dirty = value;
                _governmentLoanLenderIdentifier.Dirty = value;
                _governmentLoanSponsorIdentifier.Dirty = value;
                _governmentMortgageCreditCertificateAmount.Dirty = value;
                _hasAbusinessRelationshipWith.Dirty = value;
                _hcltvHtltv.Dirty = value;
                _helocTeaserRate.Dirty = value;
                _homeCounselingProviders.Dirty = value;
                _homeCounselingProvidersDistance.Dirty = value;
                _homeCounselingProvidersLanguageNames.Dirty = value;
                _homeCounselingProvidersServiceNames.Dirty = value;
                _householdSizeCount.Dirty = value;
                _htmlEmailLogs.Dirty = value;
                _hudIncomeLimitAdjustmentFactor.Dirty = value;
                _hudLendingIncomeLimitAmount.Dirty = value;
                _hudMedianIncomeAmount.Dirty = value;
                _id.Dirty = value;
                _includeUSDAFeeInClosing.Dirty = value;
                _initialInterestRate.Dirty = value;
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
                _linkId.Dirty = value;
                _loanActionLogs.Dirty = value;
                _loanAmortizationTermMonths.Dirty = value;
                _loanAmortizationType.Dirty = value;
                _loanCreatedDate.Dirty = value;
                _loanCreatedDateUtc.Dirty = value;
                _loanIdNumber.Dirty = value;
                _loanImportStatusIndicator.Dirty = value;
                _loanLinkSyncType.Dirty = value;
                _loanNumber.Dirty = value;
                _loanProgramName.Dirty = value;
                _loanPrograms.Dirty = value;
                _loanPurposeOfRefinanceType.Dirty = value;
                _loanSource.Dirty = value;
                _loanTotalProposedMonthlyMaintenanceAmount.Dirty = value;
                _loanTotalProposedMonthlyUtilitiesAmount.Dirty = value;
                _loanUnderwriterCHUMSIdentifier.Dirty = value;
                _loanVALoanProcedureType.Dirty = value;
                _loanVARateReductionInitialComputationTotalAmount.Dirty = value;
                _loanVAResidualIncomeAmount.Dirty = value;
                _loanVersionId.Dirty = value;
                _lockConfirmLogs.Dirty = value;
                _lockDenialLogs.Dirty = value;
                _lockRequestLogs.Dirty = value;
                _logEntryLogs.Dirty = value;
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
                _milestoneFreeRoleLogs.Dirty = value;
                _milestoneFundedDate.Dirty = value;
                _milestoneFundedDueDate.Dirty = value;
                _milestoneLogs.Dirty = value;
                _milestoneProcessedDate.Dirty = value;
                _milestoneStage.Dirty = value;
                _milestoneSubmittedDate.Dirty = value;
                _milestoneSubmittedDueDate.Dirty = value;
                _milestoneTaskLogs.Dirty = value;
                _milestoneTemplateLogs.Dirty = value;
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
                _postClosingConditionLogs.Dirty = value;
                _preliminaryConditionLogs.Dirty = value;
                _principalAndInterestMonthlyPaymentAmount.Dirty = value;
                _print2003Application.Dirty = value;
                _printLogs.Dirty = value;
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
                _purchaseCredits.Dirty = value;
                _purchasePriceAmount.Dirty = value;
                _referralAddress.Dirty = value;
                _referralCity.Dirty = value;
                _referralFeeAmount.Dirty = value;
                _referralPostalCode.Dirty = value;
                _referralSource.Dirty = value;
                _referralState.Dirty = value;
                _refinanceIncludingDebtsToBePaidOffAmount.Dirty = value;
                _registrationLogs.Dirty = value;
                _removedLogRecords.Dirty = value;
                _repurchaseCostAmount.Dirty = value;
                _repurchaseDate.Dirty = value;
                _requestedInterestRatePercent.Dirty = value;
                _salesConcessionAmount.Dirty = value;
                _secondSubordinateAmount.Dirty = value;
                _sectionOfActType.Dirty = value;
                _sellerPaidClosingCostsAmount.Dirty = value;
                _serviceProviderAdditionalInfo.Dirty = value;
                _serviceProviderContacts.Dirty = value;
                _serviceProviderDateIssued.Dirty = value;
                _setForSettlementServicesOfAnAttorney.Dirty = value;
                _setForTheSettlementServicesListed.Dirty = value;
                _settlementServiceCharges.Dirty = value;
                _simpleRefinanceType.Dirty = value;
                _startingAdjPrice.Dirty = value;
                _startingAdjRate.Dirty = value;
                _statusOnlineLogs.Dirty = value;
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
                _underwritingConditionLogs.Dirty = value;
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
                _verificationLogs.Dirty = value;
                //_virtualFields.Dirty = value;
                _websiteId.Dirty = value;
                if (AdditionalRequests != null) AdditionalRequests.Dirty = value;
                if (ATRQMCommon != null) ATRQMCommon.Dirty = value;
                if (ClosingCost != null) ClosingCost.Dirty = value;
                if (ClosingDocument != null) ClosingDocument.Dirty = value;
                if (CommitmentTerms != null) CommitmentTerms.Dirty = value;
                if (ConstructionManagement != null) ConstructionManagement.Dirty = value;
                if (Correspondent != null) Correspondent.Dirty = value;
                if (CurrentApplication != null) CurrentApplication.Dirty = value;
                if (CustomModelFields != null) CustomModelFields.Dirty = value;
                if (DisclosureNotices != null) DisclosureNotices.Dirty = value;
                if (DownPayment != null) DownPayment.Dirty = value;
                if (EmDocument != null) EmDocument.Dirty = value;
                if (EmDocumentInvestor != null) EmDocumentInvestor.Dirty = value;
                if (EmDocumentLender != null) EmDocumentLender.Dirty = value;
                if (FannieMae != null) FannieMae.Dirty = value;
                if (FhaVaLoan != null) FhaVaLoan.Dirty = value;
                if (FreddieMac != null) FreddieMac.Dirty = value;
                if (Funding != null) Funding.Dirty = value;
                if (Gfe != null) Gfe.Dirty = value;
                if (Hmda != null) Hmda.Dirty = value;
                if (Hud1Es != null) Hud1Es.Dirty = value;
                if (HudLoanData != null) HudLoanData.Dirty = value;
                if (InterimServicing != null) InterimServicing.Dirty = value;
                if (LoanProductData != null) LoanProductData.Dirty = value;
                if (LoanSubmission != null) LoanSubmission.Dirty = value;
                if (LOCompensation != null) LOCompensation.Dirty = value;
                if (Mcaw != null) Mcaw.Dirty = value;
                if (Miscellaneous != null) Miscellaneous.Dirty = value;
                if (NetTangibleBenefit != null) NetTangibleBenefit.Dirty = value;
                if (Prequalification != null) Prequalification.Dirty = value;
                if (PrivacyPolicy != null) PrivacyPolicy.Dirty = value;
                if (ProfitManagement != null) ProfitManagement.Dirty = value;
                if (Property != null) Property.Dirty = value;
                if (RateLock != null) RateLock.Dirty = value;
                if (RegulationZ != null) RegulationZ.Dirty = value;
                if (Section32 != null) Section32.Dirty = value;
                if (SelectedHomeCounselingProvider != null) SelectedHomeCounselingProvider.Dirty = value;
                if (ServicingDisclosure != null) ServicingDisclosure.Dirty = value;
                if (Shipping != null) Shipping.Dirty = value;
                if (StateDisclosure != null) StateDisclosure.Dirty = value;
                if (StatementCreditDenial != null) StatementCreditDenial.Dirty = value;
                if (TPO != null) TPO.Dirty = value;
                if (TQL != null) TQL.Dirty = value;
                if (TrustAccount != null) TrustAccount.Dirty = value;
                if (Tsum != null) Tsum.Dirty = value;
                if (Uldd != null) Uldd.Dirty = value;
                if (UnderwriterSummary != null) UnderwriterSummary.Dirty = value;
                if (Usda != null) Usda.Dirty = value;
                if (VaLoanData != null) VaLoanData.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}