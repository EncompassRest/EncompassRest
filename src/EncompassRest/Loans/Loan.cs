using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Loan
    /// </summary>
    public sealed partial class Loan : ExtensibleObject, IIdentifiable
    {
        private AdditionalRequests _additionalRequests;
        /// <summary>
        /// Loan AdditionalRequests
        /// </summary>
        public AdditionalRequests AdditionalRequests { get => _additionalRequests ?? (_additionalRequests = new AdditionalRequests()); set => _additionalRequests = value; }
        private DirtyValue<DateTime?> _adverseActionDate;
        /// <summary>
        /// Trans Details Current Status Date [749]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Current Status Date")]
        public DateTime? AdverseActionDate { get => _adverseActionDate; set => _adverseActionDate = value; }
        private DirtyList<AffiliatedBusinessArrangement> _affiliatedBusinessArrangements;
        /// <summary>
        /// Loan AffiliatedBusinessArrangements
        /// </summary>
        public IList<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get => _affiliatedBusinessArrangements ?? (_affiliatedBusinessArrangements = new DirtyList<AffiliatedBusinessArrangement>()); set => _affiliatedBusinessArrangements = new DirtyList<AffiliatedBusinessArrangement>(value); }
        private DirtyValue<string> _agencyCaseIdentifier;
        /// <summary>
        /// Trans Details Agency Case # [1040]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Agency Case #")]
        public string AgencyCaseIdentifier { get => _agencyCaseIdentifier; set => _agencyCaseIdentifier = value; }
        private DirtyValue<decimal?> _alterationsImprovementsOrRepairsAmount;
        /// <summary>
        /// Trans Details Alterations [967]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Alterations")]
        public decimal? AlterationsImprovementsOrRepairsAmount { get => _alterationsImprovementsOrRepairsAmount; set => _alterationsImprovementsOrRepairsAmount = value; }
        private DirtyList<Application> _applications;
        /// <summary>
        /// Loan Applications
        /// </summary>
        public IList<Application> Applications { get => _applications ?? (_applications = new DirtyList<Application>()); set => _applications = new DirtyList<Application>(value); }
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>> _applicationTakenMethodType;
        /// <summary>
        /// Trans Details Application Taken By [479]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Application Taken By")]
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => _applicationTakenMethodType = value; }
        private DirtyValue<DateTime?> _aprDisclosureDate;
        /// <summary>
        /// Trans Details Date APR Disclosed [363]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Date APR Disclosed")]
        public DateTime? AprDisclosureDate { get => _aprDisclosureDate; set => _aprDisclosureDate = value; }
        private DirtyValue<string> _armTypeDescription;
        /// <summary>
        /// Loan Info ARM Descr [248]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Descr")]
        public string ArmTypeDescription { get => _armTypeDescription; set => _armTypeDescription = value; }
        private ATRQMCommon _aTRQMCommon;
        /// <summary>
        /// Loan ATRQMCommon
        /// </summary>
        public ATRQMCommon ATRQMCommon { get => _aTRQMCommon ?? (_aTRQMCommon = new ATRQMCommon()); set => _aTRQMCommon = value; }
        private DirtyValue<decimal?> _baseLoanAmount;
        /// <summary>
        /// Trans Details Total Loan Amt (w/ MIP/FF) [2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Loan Amt (w/ MIP/FF)")]
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => _baseLoanAmount = value; }
        private DirtyValue<bool?> _belowMarketSubordinateFinancingIndicator;
        /// <summary>
        /// Fannie Mae Seller Prov Below Mkt Financing [MORNET.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Seller Prov Below Mkt Financing", OptionsJson = "{\"true\":\"Seller Provided Below Market Financing\"}")]
        public bool? BelowMarketSubordinateFinancingIndicator { get => _belowMarketSubordinateFinancingIndicator; set => _belowMarketSubordinateFinancingIndicator = value; }
        private DirtyValue<string> _billingCategory;
        /// <summary>
        /// Billing Category [BILLINGCATEGORY]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Billing Category")]
        public string BillingCategory { get => _billingCategory; set => _billingCategory = value; }
        private DirtyValue<decimal?> _biweeklyPaymentAmount;
        /// <summary>
        /// Biweekly Payment [3034]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Biweekly Payment")]
        public decimal? BiweeklyPaymentAmount { get => _biweeklyPaymentAmount; set => _biweeklyPaymentAmount = value; }
        private DirtyValue<int?> _bLTV;
        /// <summary>
        /// Base LTV Ratio Percent [4012]
        /// </summary>
        [LoanFieldProperty(Description = "Base LTV Ratio Percent")]
        public int? BLTV { get => _bLTV; set => _bLTV = value; }
        private DirtyValue<bool?> _borrowerCoBorrowerMarriedIndicator;
        /// <summary>
        /// Borr/Co-Borr Married Indicator [100]
        /// </summary>
        [LoanFieldProperty(Description = "Borr/Co-Borr Married Indicator", OptionsJson = "{\"true\":\"Borrower / Co-Borrower are Married\"}")]
        public bool? BorrowerCoBorrowerMarriedIndicator { get => _borrowerCoBorrowerMarriedIndicator; set => _borrowerCoBorrowerMarriedIndicator = value; }
        private DirtyValue<decimal?> _borrowerPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Borr [BORPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Borr")]
        public decimal? BorrowerPaidClosingCostsAmount { get => _borrowerPaidClosingCostsAmount; set => _borrowerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsAmount;
        /// <summary>
        /// Fees Loan Discount Fee Borr [1093]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Loan Discount Fee Borr")]
        public decimal? BorrowerPaidDiscountPointsAmount { get => _borrowerPaidDiscountPointsAmount; set => _borrowerPaidDiscountPointsAmount = value; }
        private DirtyValue<decimal?> _borrowerPaidFHAVAClosingCostsAmount;
        /// <summary>
        /// Fees Total FHA Closing Costs Borr [1132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total FHA Closing Costs Borr")]
        public decimal? BorrowerPaidFHAVAClosingCostsAmount { get => _borrowerPaidFHAVAClosingCostsAmount; set => _borrowerPaidFHAVAClosingCostsAmount = value; }
        private DirtyValue<int?> _borrowerPairCount;
        /// <summary>
        /// Number of Borrower Pairs [4460]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Number of Borrower Pairs")]
        public int? BorrowerPairCount { get => _borrowerPairCount; set => _borrowerPairCount = value; }
        private DirtyValue<decimal?> _borrowerRequestedLoanAmount;
        /// <summary>
        /// Trans Details Loan Amt [1109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Loan Amt")]
        public decimal? BorrowerRequestedLoanAmount { get => _borrowerRequestedLoanAmount; set => _borrowerRequestedLoanAmount = value; }
        private DirtyValue<decimal?> _brokerPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Broker [BKRPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Broker")]
        public decimal? BrokerPaidClosingCostsAmount { get => _brokerPaidClosingCostsAmount; set => _brokerPaidClosingCostsAmount = value; }
        private DirtyValue<bool?> _buydownIndicator;
        /// <summary>
        /// Loan Info Buydown [425]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown", OptionsJson = "{\"true\":\"Buydown\"}")]
        public bool? BuydownIndicator { get => _buydownIndicator; set => _buydownIndicator = value; }
        private DirtyValue<decimal?> _buydownMonthlyPaymentAmount;
        /// <summary>
        /// Monthly Buydown Payment [BUYDOWNPAYMENT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Monthly Buydown Payment")]
        public decimal? BuydownMonthlyPaymentAmount { get => _buydownMonthlyPaymentAmount; set => _buydownMonthlyPaymentAmount = value; }
        private DirtyValue<decimal?> _buydownRatePercent;
        /// <summary>
        /// FHA MCAW Buydown Rate [964]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "FHA MCAW Buydown Rate")]
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => _buydownRatePercent = value; }
        private DirtyValue<decimal?> _cashFromToBorrowerAmount;
        /// <summary>
        /// Trans Details Cash From Borr [142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Cash From Borr")]
        public decimal? CashFromToBorrowerAmount { get => _cashFromToBorrowerAmount; set => _cashFromToBorrowerAmount = value; }
        private DirtyValue<StringEnumValue<Channel>> _channel;
        /// <summary>
        /// Loan Info Channel [2626]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Channel")]
        public StringEnumValue<Channel> Channel { get => _channel; set => _channel = value; }
        private DirtyValue<DateTime?> _closingBillingDate;
        /// <summary>
        /// Closing Date for Billing Purposes [3260]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Date for Billing Purposes")]
        public DateTime? ClosingBillingDate { get => _closingBillingDate; set => _closingBillingDate = value; }
        private ClosingCost _closingCost;
        /// <summary>
        /// Loan ClosingCost
        /// </summary>
        public ClosingCost ClosingCost { get => _closingCost ?? (_closingCost = new ClosingCost()); set => _closingCost = value; }
        private DirtyValue<string> _closingCostProgram;
        /// <summary>
        /// Trans Details Closing Cost Program [1785]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Closing Cost Program")]
        public string ClosingCostProgram { get => _closingCostProgram; set => _closingCostProgram = value; }
        private DirtyValue<decimal?> _closingCostsAndPrepaidsFromOtherLienAmount;
        /// <summary>
        /// Trans Details CC From Second [1851]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details CC From Second")]
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get => _closingCostsAndPrepaidsFromOtherLienAmount; set => _closingCostsAndPrepaidsFromOtherLienAmount = value; }
        private DirtyValue<decimal?> _closingCostsPaidByOthersAmount;
        /// <summary>
        /// Trans Details CC Paid By Broker/Lender/Other [1852]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details CC Paid By Broker/Lender/Other")]
        public decimal? ClosingCostsPaidByOthersAmount { get => _closingCostsPaidByOthersAmount; set => _closingCostsPaidByOthersAmount = value; }
        private DirtyValue<string> _closingDocsStackingOrder;
        /// <summary>
        /// Closing Document Stacking Order [Closing.DocStkOrdr]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Document Stacking Order")]
        public string ClosingDocsStackingOrder { get => _closingDocsStackingOrder; set => _closingDocsStackingOrder = value; }
        private ClosingDocument _closingDocument;
        /// <summary>
        /// Loan ClosingDocument
        /// </summary>
        public ClosingDocument ClosingDocument { get => _closingDocument ?? (_closingDocument = new ClosingDocument()); set => _closingDocument = value; }
        private DirtyValue<int?> _collateralManagerScore;
        /// <summary>
        /// Collateral Manager Score # [3356]
        /// </summary>
        [LoanFieldProperty(Description = "Collateral Manager Score #")]
        public int? CollateralManagerScore { get => _collateralManagerScore; set => _collateralManagerScore = value; }
        private DirtyValue<decimal?> _combinedLtv;
        /// <summary>
        /// Trans Details Comb Loan to Value (CLTV) [976]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Comb Loan to Value (CLTV)")]
        public decimal? CombinedLtv { get => _combinedLtv; set => _combinedLtv = value; }
        private DirtyValue<string> _commitmentNumber;
        /// <summary>
        /// Commitment Number [3907]
        /// </summary>
        [LoanFieldProperty(Description = "Commitment Number")]
        public string CommitmentNumber { get => _commitmentNumber; set => _commitmentNumber = value; }
        private CommitmentTerms _commitmentTerms;
        /// <summary>
        /// Loan CommitmentTerms
        /// </summary>
        public CommitmentTerms CommitmentTerms { get => _commitmentTerms ?? (_commitmentTerms = new CommitmentTerms()); set => _commitmentTerms = value; }
        private DirtyList<ComplianceTestLog> _complianceTestLogs;
        /// <summary>
        /// Loan ComplianceTestLogs
        /// </summary>
        public IList<ComplianceTestLog> ComplianceTestLogs { get => _complianceTestLogs ?? (_complianceTestLogs = new DirtyList<ComplianceTestLog>()); set => _complianceTestLogs = new DirtyList<ComplianceTestLog>(value); }
        private DirtyValue<StringEnumValue<ConformingJumbo>> _conformingJumbo;
        /// <summary>
        /// Conforming Loan Indicator [3331]
        /// </summary>
        [LoanFieldProperty(Description = "Conforming Loan Indicator")]
        public StringEnumValue<ConformingJumbo> ConformingJumbo { get => _conformingJumbo; set => _conformingJumbo = value; }
        private ConstructionManagement _constructionManagement;
        /// <summary>
        /// Loan ConstructionManagement
        /// </summary>
        public ConstructionManagement ConstructionManagement { get => _constructionManagement ?? (_constructionManagement = new ConstructionManagement()); set => _constructionManagement = value; }
        private DirtyValue<string> _consumerConnectSiteID;
        /// <summary>
        /// Consumer Connect SiteID [ConsumerConnectSiteID]
        /// </summary>
        [LoanFieldProperty(Description = "Consumer Connect SiteID")]
        public string ConsumerConnectSiteID { get => _consumerConnectSiteID; set => _consumerConnectSiteID = value; }
        private DirtyList<Contact> _contacts;
        /// <summary>
        /// Loan Contacts
        /// </summary>
        public IList<Contact> Contacts { get => _contacts ?? (_contacts = new DirtyList<Contact>()); set => _contacts = new DirtyList<Contact>(value); }
        private DirtyValue<bool?> _contactUpdatedIndicator;
        /// <summary>
        /// Loan Info Contact Update [2821]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info Contact Update")]
        public bool? ContactUpdatedIndicator { get => _contactUpdatedIndicator; set => _contactUpdatedIndicator = value; }
        private DirtyValue<decimal?> _contractSellerCreditAmount;
        /// <summary>
        /// Contract Seller Credit Amount [NEWHUD2.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Contract Seller Credit Amount")]
        public decimal? ContractSellerCreditAmount { get => _contractSellerCreditAmount; set => _contractSellerCreditAmount = value; }
        private DirtyList<ConversationLog> _conversationLogs;
        /// <summary>
        /// Loan ConversationLogs
        /// </summary>
        public IList<ConversationLog> ConversationLogs { get => _conversationLogs ?? (_conversationLogs = new DirtyList<ConversationLog>()); set => _conversationLogs = new DirtyList<ConversationLog>(value); }
        private DirtyValue<bool?> _copyBrokerToLenderIndicator;
        /// <summary>
        /// Trans Details Copy to Lender Check Box [1969]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Copy to Lender Check Box", OptionsJson = "{\"true\":\"Copy to Lender\"}")]
        public bool? CopyBrokerToLenderIndicator { get => _copyBrokerToLenderIndicator; set => _copyBrokerToLenderIndicator = value; }
        private DirtyValue<StringEnumValue<YOrN>> _copyLoanNumLenderCaseNum;
        /// <summary>
        /// Trans Details Copy Loan # to Case # [1481]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Copy Loan # to Case #", OptionsJson = "{\"Y\":\"Copy Loan Number to lender case number\",\"N\":\"\"}")]
        public StringEnumValue<YOrN> CopyLoanNumLenderCaseNum { get => _copyLoanNumLenderCaseNum; set => _copyLoanNumLenderCaseNum = value; }
        private Correspondent _correspondent;
        /// <summary>
        /// Loan Correspondent
        /// </summary>
        public Correspondent Correspondent { get => _correspondent ?? (_correspondent = new Correspondent()); set => _correspondent = value; }
        private DirtyValue<string> _creditScoreToUse;
        /// <summary>
        /// Lock Request Credit Score for Decision Making [2853]
        /// </summary>
        [LoanFieldProperty(Description = "Lock Request Credit Score for Decision Making")]
        public string CreditScoreToUse { get => _creditScoreToUse; set => _creditScoreToUse = value; }
        private DirtyList<CrmLog> _crmLogs;
        /// <summary>
        /// Loan CrmLogs
        /// </summary>
        public IList<CrmLog> CrmLogs { get => _crmLogs ?? (_crmLogs = new DirtyList<CrmLog>()); set => _crmLogs = new DirtyList<CrmLog>(value); }
        private DirtyValue<bool?> _currentApplicationIsPrimary;
        /// <summary>
        /// Loan CurrentApplicationIsPrimary
        /// </summary>
        public bool? CurrentApplicationIsPrimary { get => _currentApplicationIsPrimary; set => _currentApplicationIsPrimary = value; }
        private DirtyValue<StringEnumValue<CurrentFirstMortgageHolderType>> _currentFirstMortgageHolderType;
        /// <summary>
        /// Trans Details First Mtg Owner [991]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details First Mtg Owner")]
        public StringEnumValue<CurrentFirstMortgageHolderType> CurrentFirstMortgageHolderType { get => _currentFirstMortgageHolderType; set => _currentFirstMortgageHolderType = value; }
        private DirtyList<CustomField> _customFields;
        /// <summary>
        /// Loan CustomFields
        /// </summary>
        public IList<CustomField> CustomFields { get => _customFields ?? (_customFields = new DirtyList<CustomField>()); set => _customFields = new DirtyList<CustomField>(value); }
        private CustomModelFields _customModelFields;
        /// <summary>
        /// Loan CustomModelFields
        /// </summary>
        public CustomModelFields CustomModelFields { get => _customModelFields ?? (_customModelFields = new CustomModelFields()); set => _customModelFields = value; }
        private DirtyList<DataTracLog> _dataTracLogs;
        /// <summary>
        /// Loan DataTracLogs
        /// </summary>
        public IList<DataTracLog> DataTracLogs { get => _dataTracLogs ?? (_dataTracLogs = new DirtyList<DataTracLog>()); set => _dataTracLogs = new DirtyList<DataTracLog>(value); }
        private DirtyValue<bool?> _dBIndicator;
        /// <summary>
        /// Loan DBIndicator
        /// </summary>
        public bool? DBIndicator { get => _dBIndicator; set => _dBIndicator = value; }
        private DirtyValue<bool?> _deductOverwireAmountIndicator;
        /// <summary>
        /// Trans Details Deduct Overwire Amt From Broker Check [2833]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Deduct Overwire Amt From Broker Check")]
        public bool? DeductOverwireAmountIndicator { get => _deductOverwireAmountIndicator; set => _deductOverwireAmountIndicator = value; }
        private DirtyValue<bool?> _disableESignConsentAlert;
        /// <summary>
        /// Disable eConsent Alert [4072]
        /// </summary>
        [LoanFieldProperty(Description = "Disable eConsent Alert")]
        public bool? DisableESignConsentAlert { get => _disableESignConsentAlert; set => _disableESignConsentAlert = value; }
        private DirtyValue<bool?> _disableKeyPricingAlert;
        /// <summary>
        /// Disable Key Pricing Alert [4062]
        /// </summary>
        [LoanFieldProperty(Description = "Disable Key Pricing Alert")]
        public bool? DisableKeyPricingAlert { get => _disableKeyPricingAlert; set => _disableKeyPricingAlert = value; }
        private DisclosureNotices _disclosureNotices;
        /// <summary>
        /// Loan DisclosureNotices
        /// </summary>
        public DisclosureNotices DisclosureNotices { get => _disclosureNotices ?? (_disclosureNotices = new DisclosureNotices()); set => _disclosureNotices = value; }
        private DirtyList<DisclosureTracking2015Log> _disclosureTracking2015Logs;
        /// <summary>
        /// Loan DisclosureTracking2015Logs
        /// </summary>
        public IList<DisclosureTracking2015Log> DisclosureTracking2015Logs { get => _disclosureTracking2015Logs ?? (_disclosureTracking2015Logs = new DirtyList<DisclosureTracking2015Log>()); set => _disclosureTracking2015Logs = new DirtyList<DisclosureTracking2015Log>(value); }
        private DirtyList<DisclosureTrackingLog> _disclosureTrackingLogs;
        /// <summary>
        /// Loan DisclosureTrackingLogs
        /// </summary>
        public IList<DisclosureTrackingLog> DisclosureTrackingLogs { get => _disclosureTrackingLogs ?? (_disclosureTrackingLogs = new DirtyList<DisclosureTrackingLog>()); set => _disclosureTrackingLogs = new DirtyList<DisclosureTrackingLog>(value); }
        private DirtyValue<decimal?> _discountPoint;
        /// <summary>
        /// Trans Detail Discount Point [1010]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Trans Detail Discount Point")]
        public decimal? DiscountPoint { get => _discountPoint; set => _discountPoint = value; }
        private DirtyValue<StringEnumValue<DocEngine>> _docEngine;
        /// <summary>
        /// Ellie Mae Document Engine Version [Docs.Engine]
        /// </summary>
        [LoanFieldProperty(Description = "Ellie Mae Document Engine Version")]
        public StringEnumValue<DocEngine> DocEngine { get => _docEngine; set => _docEngine = value; }
        private DirtyList<DocumentLog> _documentLogs;
        /// <summary>
        /// Loan DocumentLogs
        /// </summary>
        public IList<DocumentLog> DocumentLogs { get => _documentLogs ?? (_documentLogs = new DirtyList<DocumentLog>()); set => _documentLogs = new DirtyList<DocumentLog>(value); }
        private DirtyList<DocumentOrderLog> _documentOrderLogs;
        /// <summary>
        /// Loan DocumentOrderLogs
        /// </summary>
        public IList<DocumentOrderLog> DocumentOrderLogs { get => _documentOrderLogs ?? (_documentOrderLogs = new DirtyList<DocumentOrderLog>()); set => _documentOrderLogs = new DirtyList<DocumentOrderLog>(value); }
        private DirtyValue<string> _doNotCheckEmail;
        /// <summary>
        /// Do Not Check Email When Loan File Is Saved [3040]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Do Not Check Email When Loan File Is Saved")]
        public string DoNotCheckEmail { get => _doNotCheckEmail; set => _doNotCheckEmail = value; }
        private DirtyValue<bool?> _doNotPrintCompensationFees;
        /// <summary>
        /// Fees Do not print line 824 and 825 Check Box [1970]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Do not print line 824 and 825 Check Box", OptionsJson = "{\"true\":\"Do not print line 824 and 825\"}")]
        public bool? DoNotPrintCompensationFees { get => _doNotPrintCompensationFees; set => _doNotPrintCompensationFees = value; }
        private DirtyList<DownloadLog> _downloadLogs;
        /// <summary>
        /// Loan DownloadLogs
        /// </summary>
        public IList<DownloadLog> DownloadLogs { get => _downloadLogs ?? (_downloadLogs = new DirtyList<DownloadLog>()); set => _downloadLogs = new DirtyList<DownloadLog>(value); }
        private DownPayment _downPayment;
        /// <summary>
        /// Loan DownPayment
        /// </summary>
        public DownPayment DownPayment { get => _downPayment ?? (_downPayment = new DownPayment()); set => _downPayment = value; }
        private DirtyValue<decimal?> _downPaymentPercent;
        /// <summary>
        /// Trans Details Down Pmt % [1771]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Down Pmt %")]
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => _downPaymentPercent = value; }
        private DirtyValue<int?> _eDeliveryVersion;
        /// <summary>
        /// eDelivery - Version [EDELIVERY.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "eDelivery - Version")]
        public int? EDeliveryVersion { get => _eDeliveryVersion; set => _eDeliveryVersion = value; }
        private DirtyList<EdmLog> _edmLogs;
        /// <summary>
        /// Loan EdmLogs
        /// </summary>
        public IList<EdmLog> EdmLogs { get => _edmLogs ?? (_edmLogs = new DirtyList<EdmLog>()); set => _edmLogs = new DirtyList<EdmLog>(value); }
        private ElliUCDDetail _elliUCDFields;
        /// <summary>
        /// Loan ElliUCDFields
        /// </summary>
        public ElliUCDDetail ElliUCDFields { get => _elliUCDFields ?? (_elliUCDFields = new ElliUCDDetail()); set => _elliUCDFields = value; }
        private DirtyList<EmailTriggerLog> _emailTriggerLogs;
        /// <summary>
        /// Loan EmailTriggerLogs
        /// </summary>
        public IList<EmailTriggerLog> EmailTriggerLogs { get => _emailTriggerLogs ?? (_emailTriggerLogs = new DirtyList<EmailTriggerLog>()); set => _emailTriggerLogs = new DirtyList<EmailTriggerLog>(value); }
        private EmDocument _emDocument;
        /// <summary>
        /// Loan EmDocument
        /// </summary>
        public EmDocument EmDocument { get => _emDocument ?? (_emDocument = new EmDocument()); set => _emDocument = value; }
        private EmDocumentInvestor _emDocumentInvestor;
        /// <summary>
        /// Loan EmDocumentInvestor
        /// </summary>
        public EmDocumentInvestor EmDocumentInvestor { get => _emDocumentInvestor ?? (_emDocumentInvestor = new EmDocumentInvestor()); set => _emDocumentInvestor = value; }
        private EmDocumentLender _emDocumentLender;
        /// <summary>
        /// Loan EmDocumentLender
        /// </summary>
        public EmDocumentLender EmDocumentLender { get => _emDocumentLender ?? (_emDocumentLender = new EmDocumentLender()); set => _emDocumentLender = value; }
        private DirtyValue<string> _emXmlVersionId;
        /// <summary>
        /// Loan EmXmlVersionId
        /// </summary>
        public string EmXmlVersionId { get => _emXmlVersionId; set => _emXmlVersionId = value; }
        private DirtyValue<string> _encompassId;
        /// <summary>
        /// Loan Info Loan ID [GUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info Loan ID")]
        public string EncompassId { get => _encompassId; set => _encompassId = value; }
        private DirtyValue<string> _encompassVersion;
        /// <summary>
        /// Encompass Version [SYS.X611]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Encompass Version")]
        public string EncompassVersion { get => _encompassVersion; set => _encompassVersion = value; }
        private DirtyValue<bool?> _enforceCountyLoanLimit;
        /// <summary>
        /// Enforce County Loan Limit [3894]
        /// </summary>
        [LoanFieldProperty(Description = "Enforce County Loan Limit")]
        public bool? EnforceCountyLoanLimit { get => _enforceCountyLoanLimit; set => _enforceCountyLoanLimit = value; }
        private DirtyValue<decimal?> _estimatedClosingCostsAmount;
        /// <summary>
        /// Trans Details Est Closing Costs [137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Est Closing Costs")]
        public decimal? EstimatedClosingCostsAmount { get => _estimatedClosingCostsAmount; set => _estimatedClosingCostsAmount = value; }
        private DirtyValue<decimal?> _estimatedConstructionInterest;
        /// <summary>
        /// Trans Details Estimated Construction Interest [4088]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Estimated Construction Interest")]
        public decimal? EstimatedConstructionInterest { get => _estimatedConstructionInterest; set => _estimatedConstructionInterest = value; }
        private DirtyValue<decimal?> _estimatedPrepaidItemsAmount;
        /// <summary>
        /// Trans Details Est Prepaids [138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Est Prepaids")]
        public decimal? EstimatedPrepaidItemsAmount { get => _estimatedPrepaidItemsAmount; set => _estimatedPrepaidItemsAmount = value; }
        private DirtyValue<StringEnumValue<ExportLoanNumber>> _exportLoanNumber;
        /// <summary>
        /// Export Investor or Lender Loan Number [2573]
        /// </summary>
        [LoanFieldProperty(Description = "Export Investor or Lender Loan Number")]
        public StringEnumValue<ExportLoanNumber> ExportLoanNumber { get => _exportLoanNumber; set => _exportLoanNumber = value; }
        private FannieMae _fannieMae;
        /// <summary>
        /// Loan FannieMae
        /// </summary>
        public FannieMae FannieMae { get => _fannieMae ?? (_fannieMae = new FannieMae()); set => _fannieMae = value; }
        private DirtyList<Fee> _fees;
        /// <summary>
        /// Loan Fees
        /// </summary>
        public IList<Fee> Fees { get => _fees ?? (_fees = new DirtyList<Fee>()); set => _fees = new DirtyList<Fee>(value); }
        private DirtyValue<decimal?> _fhaMiPremiumRefundAmount;
        /// <summary>
        /// FHA MIP Refund Amt [1134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MIP Refund Amt")]
        public decimal? FhaMiPremiumRefundAmount { get => _fhaMiPremiumRefundAmount; set => _fhaMiPremiumRefundAmount = value; }
        private FhaVaLoan _fhaVaLoan;
        /// <summary>
        /// Loan FhaVaLoan
        /// </summary>
        public FhaVaLoan FhaVaLoan { get => _fhaVaLoan ?? (_fhaVaLoan = new FhaVaLoan()); set => _fhaVaLoan = value; }
        private DirtyValue<string> _fHAVALoanOriginatorIdentifier;
        /// <summary>
        /// Loan FHAVALoanOriginatorIdentifier
        /// </summary>
        public string FHAVALoanOriginatorIdentifier { get => _fHAVALoanOriginatorIdentifier; set => _fHAVALoanOriginatorIdentifier = value; }
        private DirtyList<FieldLockData> _fieldLockData;
        /// <summary>
        /// Loan FieldLockData
        /// </summary>
        public IList<FieldLockData> FieldLockData { get => _fieldLockData ?? (_fieldLockData = new DirtyList<FieldLockData>()); set => _fieldLockData = new DirtyList<FieldLockData>(value); }
        private DirtyValue<decimal?> _firstAdjustmentMinimum;
        /// <summary>
        /// First Adjustment Minimum Value [3557]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "First Adjustment Minimum Value")]
        public decimal? FirstAdjustmentMinimum { get => _firstAdjustmentMinimum; set => _firstAdjustmentMinimum = value; }
        private DirtyValue<decimal?> _firstSubordinateLienAmount;
        /// <summary>
        /// Trans Details Sub Fin First Mtg Loan Amt [427]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Sub Fin First Mtg Loan Amt")]
        public decimal? FirstSubordinateLienAmount { get => _firstSubordinateLienAmount; set => _firstSubordinateLienAmount = value; }
        private DirtyValue<bool?> _firstTimeHomebuyersIndicator;
        /// <summary>
        /// Borr First Time Homebuyer [934]
        /// </summary>
        [LoanFieldProperty(Description = "Borr First Time Homebuyer")]
        public bool? FirstTimeHomebuyersIndicator { get => _firstTimeHomebuyersIndicator; set => _firstTimeHomebuyersIndicator = value; }
        private DirtyValue<StringEnumValue<FnmCommunityLendingProductName>> _fnmCommunityLendingProductName;
        /// <summary>
        /// Fannie Mae Community Lending Product [MORNET.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Lending Product")]
        public StringEnumValue<FnmCommunityLendingProductName> FnmCommunityLendingProductName { get => _fnmCommunityLendingProductName; set => _fnmCommunityLendingProductName = value; }
        private DirtyValue<bool?> _fnmCommunitySecondsIndicator;
        /// <summary>
        /// Fannie Mae Community Seconds [MORNET.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Seconds", OptionsJson = "{\"true\":\"Community Seconds\"}")]
        public bool? FnmCommunitySecondsIndicator { get => _fnmCommunitySecondsIndicator; set => _fnmCommunitySecondsIndicator = value; }
        private DirtyValue<bool?> _fnmNeighborsMortgageEligibilityIndicator;
        /// <summary>
        /// Fannie Mae FannieNeighbors Elig [MORNET.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae FannieNeighbors Elig", OptionsJson = "{\"true\":\"FannieNeighbors Eligible\"}")]
        public bool? FnmNeighborsMortgageEligibilityIndicator { get => _fnmNeighborsMortgageEligibilityIndicator; set => _fnmNeighborsMortgageEligibilityIndicator = value; }
        private DirtyList<Form> _forms;
        /// <summary>
        /// Loan Forms
        /// </summary>
        public IList<Form> Forms { get => _forms ?? (_forms = new DirtyList<Form>()); set => _forms = new DirtyList<Form>(value); }
        private DirtyValue<int?> _fraudScore;
        /// <summary>
        /// Fraud Score # [3340]
        /// </summary>
        [LoanFieldProperty(Description = "Fraud Score #")]
        public int? FraudScore { get => _fraudScore; set => _fraudScore = value; }
        private FreddieMac _freddieMac;
        /// <summary>
        /// Loan FreddieMac
        /// </summary>
        public FreddieMac FreddieMac { get => _freddieMac ?? (_freddieMac = new FreddieMac()); set => _freddieMac = value; }
        private Funding _funding;
        /// <summary>
        /// Loan Funding
        /// </summary>
        public Funding Funding { get => _funding ?? (_funding = new Funding()); set => _funding = value; }
        private DirtyValue<string> _fundingDeductionList;
        /// <summary>
        /// Funding Worksheet Deduction Items [2971]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Funding Worksheet Deduction Items")]
        public string FundingDeductionList { get => _fundingDeductionList; set => _fundingDeductionList = value; }
        private DirtyValue<string> _fundingFeeList;
        /// <summary>
        /// Funding Worksheet Fee List [2972]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Funding Worksheet Fee List")]
        public string FundingFeeList { get => _fundingFeeList; set => _fundingFeeList = value; }
        private DirtyList<FundingFee> _fundingFees;
        /// <summary>
        /// Loan FundingFees
        /// </summary>
        public IList<FundingFee> FundingFees { get => _fundingFees ?? (_fundingFees = new DirtyList<FundingFee>()); set => _fundingFees = new DirtyList<FundingFee>(value); }
        private Gfe _gfe;
        /// <summary>
        /// Loan Gfe
        /// </summary>
        public Gfe Gfe { get => _gfe ?? (_gfe = new Gfe()); set => _gfe = value; }
        private DirtyValue<string> _governmentLoanLenderIdentifier;
        /// <summary>
        /// Loan GovernmentLoanLenderIdentifier
        /// </summary>
        public string GovernmentLoanLenderIdentifier { get => _governmentLoanLenderIdentifier; set => _governmentLoanLenderIdentifier = value; }
        private DirtyValue<string> _governmentLoanSponsorIdentifier;
        /// <summary>
        /// Loan GovernmentLoanSponsorIdentifier
        /// </summary>
        public string GovernmentLoanSponsorIdentifier { get => _governmentLoanSponsorIdentifier; set => _governmentLoanSponsorIdentifier = value; }
        private DirtyValue<decimal?> _governmentMortgageCreditCertificateAmount;
        /// <summary>
        /// Fannie Mae Mortgage Credit [MORNET.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae Mortgage Credit")]
        public decimal? GovernmentMortgageCreditCertificateAmount { get => _governmentMortgageCreditCertificateAmount; set => _governmentMortgageCreditCertificateAmount = value; }
        private DirtyValue<string> _hasAbusinessRelationshipWith;
        /// <summary>
        /// Disclosure Bus Affiliate Name [AFF.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Bus Affiliate Name")]
        public string HasAbusinessRelationshipWith { get => _hasAbusinessRelationshipWith; set => _hasAbusinessRelationshipWith = value; }
        private DirtyValue<decimal?> _hcltvHtltv;
        /// <summary>
        /// Trans Details HCLTV/HTLTV [1540]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details HCLTV/HTLTV")]
        public decimal? HcltvHtltv { get => _hcltvHtltv; set => _hcltvHtltv = value; }
        private DirtyValue<decimal?> _helocTeaserRate;
        /// <summary>
        /// HELOC Teaser Rate [1482]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Teaser Rate")]
        public decimal? HelocTeaserRate { get => _helocTeaserRate; set => _helocTeaserRate = value; }
        private Hmda _hmda;
        /// <summary>
        /// Loan Hmda
        /// </summary>
        public Hmda Hmda { get => _hmda ?? (_hmda = new Hmda()); set => _hmda = value; }
        private DirtyList<HomeCounselingProvider> _homeCounselingProviders;
        /// <summary>
        /// Loan HomeCounselingProviders
        /// </summary>
        public IList<HomeCounselingProvider> HomeCounselingProviders { get => _homeCounselingProviders ?? (_homeCounselingProviders = new DirtyList<HomeCounselingProvider>()); set => _homeCounselingProviders = new DirtyList<HomeCounselingProvider>(value); }
        private DirtyValue<string> _homeCounselingProvidersDistance;
        /// <summary>
        /// Home Counseling Provider - Settings - Distance [HCSETTING.DISTANCE]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Settings - Distance")]
        public string HomeCounselingProvidersDistance { get => _homeCounselingProvidersDistance; set => _homeCounselingProvidersDistance = value; }
        private DirtyValue<string> _homeCounselingProvidersLanguageNames;
        /// <summary>
        /// Home Counseling Provider - Settings - Language Names [HCSETTING.LANGUAGES]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Settings - Language Names")]
        public string HomeCounselingProvidersLanguageNames { get => _homeCounselingProvidersLanguageNames; set => _homeCounselingProvidersLanguageNames = value; }
        private DirtyValue<string> _homeCounselingProvidersServiceNames;
        /// <summary>
        /// Home Counseling Provider - Settings - Service Names [HCSETTING.SERVICES]
        /// </summary>
        [LoanFieldProperty(Description = "Home Counseling Provider - Settings - Service Names")]
        public string HomeCounselingProvidersServiceNames { get => _homeCounselingProvidersServiceNames; set => _homeCounselingProvidersServiceNames = value; }
        private DirtyValue<int?> _householdSizeCount;
        /// <summary>
        /// Loan HouseholdSizeCount
        /// </summary>
        public int? HouseholdSizeCount { get => _householdSizeCount; set => _householdSizeCount = value; }
        private DirtyList<HtmlEmailLog> _htmlEmailLogs;
        /// <summary>
        /// Loan HtmlEmailLogs
        /// </summary>
        public IList<HtmlEmailLog> HtmlEmailLogs { get => _htmlEmailLogs ?? (_htmlEmailLogs = new DirtyList<HtmlEmailLog>()); set => _htmlEmailLogs = new DirtyList<HtmlEmailLog>(value); }
        private Hud1Es _hud1Es;
        /// <summary>
        /// Loan Hud1Es
        /// </summary>
        public Hud1Es Hud1Es { get => _hud1Es ?? (_hud1Es = new Hud1Es()); set => _hud1Es = value; }
        private DirtyValue<decimal?> _hudIncomeLimitAdjustmentFactor;
        /// <summary>
        /// Fannie Mae Income Limit Adj Factor [MORNET.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae Income Limit Adj Factor")]
        public decimal? HudIncomeLimitAdjustmentFactor { get => _hudIncomeLimitAdjustmentFactor; set => _hudIncomeLimitAdjustmentFactor = value; }
        private DirtyValue<decimal?> _hudLendingIncomeLimitAmount;
        /// <summary>
        /// Fannie Mae Community Lending Inc Limit [MORNET.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae Community Lending Inc Limit")]
        public decimal? HudLendingIncomeLimitAmount { get => _hudLendingIncomeLimitAmount; set => _hudLendingIncomeLimitAmount = value; }
        private HudLoanData _hudLoanData;
        /// <summary>
        /// Loan HudLoanData
        /// </summary>
        public HudLoanData HudLoanData { get => _hudLoanData ?? (_hudLoanData = new HudLoanData()); set => _hudLoanData = value; }
        private DirtyValue<decimal?> _hudMedianIncomeAmount;
        /// <summary>
        /// Fannie Mae HUD Median Income [MORNET.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae HUD Median Income")]
        public decimal? HudMedianIncomeAmount { get => _hudMedianIncomeAmount; set => _hudMedianIncomeAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Loan Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _includeUSDAFeeInClosing;
        /// <summary>
        /// Trans Details Include USDA Upfront Guarantee Fee in Closing [3551]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Include USDA Upfront Guarantee Fee in Closing")]
        public bool? IncludeUSDAFeeInClosing { get => _includeUSDAFeeInClosing; set => _includeUSDAFeeInClosing = value; }
        private DirtyValue<decimal?> _initialInterestRate;
        /// <summary>
        /// Initial Interest Rate [4113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Initial Interest Rate")]
        public decimal? InitialInterestRate { get => _initialInterestRate; set => _initialInterestRate = value; }
        private DirtyValue<string> _initialInterestRateUI;
        /// <summary>
        /// Initial Interest Rate - Display field with KBYO rounding rules  [KBYO.XD4113]
        /// </summary>
        [LoanFieldProperty(Description = "Initial Interest Rate - Display field with KBYO rounding rules ")]
        public string InitialInterestRateUI { get => _initialInterestRateUI; set => _initialInterestRateUI = value; }
        private DirtyValue<string> _insuranceAuthorizationIndicator;
        /// <summary>
        /// Trans Details Insurance Authorization Indicator [1984]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Insurance Authorization Indicator")]
        public string InsuranceAuthorizationIndicator { get => _insuranceAuthorizationIndicator; set => _insuranceAuthorizationIndicator = value; }
        private InterimServicing _interimServicing;
        /// <summary>
        /// Loan InterimServicing
        /// </summary>
        public InterimServicing InterimServicing { get => _interimServicing ?? (_interimServicing = new InterimServicing()); set => _interimServicing = value; }
        private DirtyValue<DateTime?> _interviewerApplicationSignedDate;
        /// <summary>
        /// Fannie Mae Interview Date [MORNET.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Interview Date")]
        public DateTime? InterviewerApplicationSignedDate { get => _interviewerApplicationSignedDate; set => _interviewerApplicationSignedDate = value; }
        private DirtyValue<string> _interviewerEmail;
        /// <summary>
        /// Trans Details Interviewer Email [3968]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interviewer Email")]
        public string InterviewerEmail { get => _interviewerEmail; set => _interviewerEmail = value; }
        private DirtyValue<string> _interviewerLicenseIdentifier;
        /// <summary>
        /// Interviewer's License Number [2306]
        /// </summary>
        [LoanFieldProperty(Description = "Interviewer's License Number")]
        public string InterviewerLicenseIdentifier { get => _interviewerLicenseIdentifier; set => _interviewerLicenseIdentifier = value; }
        private DirtyValue<string> _interviewerPhoneNumber;
        /// <summary>
        /// Trans Details Interviewer Phone [1823]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Trans Details Interviewer Phone")]
        public string InterviewerPhoneNumber { get => _interviewerPhoneNumber; set => _interviewerPhoneNumber = value; }
        private DirtyValue<string> _interviewersCompanyStateLicense;
        /// <summary>
        /// The state license number for the interviewer's company. [3629]
        /// </summary>
        [LoanFieldProperty(Description = "The state license number for the interviewer's company.")]
        public string InterviewersCompanyStateLicense { get => _interviewersCompanyStateLicense; set => _interviewersCompanyStateLicense = value; }
        private DirtyValue<string> _interviewersId;
        /// <summary>
        /// Trans Details Interviewer ID [3239]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interviewer ID")]
        public string InterviewersId { get => _interviewersId; set => _interviewersId = value; }
        private DirtyValue<string> _inverviewerName;
        /// <summary>
        /// Trans Details Interviewer Name [1612]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interviewer Name")]
        public string InverviewerName { get => _inverviewerName; set => _inverviewerName = value; }
        private DirtyValue<bool?> _isCreditorProhibitsBorrower;
        /// <summary>
        /// Trans Details Creditor Prohibits Borrower from making interest Payments [4087]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Creditor Prohibits Borrower from making interest Payments")]
        public bool? IsCreditorProhibitsBorrower { get => _isCreditorProhibitsBorrower; set => _isCreditorProhibitsBorrower = value; }
        private DirtyValue<bool?> _isEmployeeLoan;
        /// <summary>
        /// Is Employee Loan? [4181]
        /// </summary>
        [LoanFieldProperty(Description = "Is Employee Loan?")]
        public bool? IsEmployeeLoan { get => _isEmployeeLoan; set => _isEmployeeLoan = value; }
        private DirtyValue<bool?> _isLSSecondaryFile;
        /// <summary>
        /// Indicator for loan link sync type [4117]
        /// </summary>
        [LoanFieldProperty(Description = "Indicator for loan link sync type")]
        public bool? IsLSSecondaryFile { get => _isLSSecondaryFile; set => _isLSSecondaryFile = value; }
        private DirtyValue<bool?> _isRequiredInterestReserveCompoundInterest;
        /// <summary>
        /// Trans Details Required Interest Reserve (Compound Interest) [4086]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Required Interest Reserve (Compound Interest)")]
        public bool? IsRequiredInterestReserveCompoundInterest { get => _isRequiredInterestReserveCompoundInterest; set => _isRequiredInterestReserveCompoundInterest = value; }
        private DirtyValue<decimal?> _landIfAcquiredSeperatelyAmount;
        /// <summary>
        /// Trans Details Land [968]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Land")]
        public decimal? LandIfAcquiredSeperatelyAmount { get => _landIfAcquiredSeperatelyAmount; set => _landIfAcquiredSeperatelyAmount = value; }
        private DirtyValue<string> _leadSource;
        /// <summary>
        /// Loan Info Lead Source [2976]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info Lead Source")]
        public string LeadSource { get => _leadSource; set => _leadSource = value; }
        private DirtyValue<string> _lenderCaseIdentifier;
        /// <summary>
        /// File Contacts Lender Case # [305]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender Case #")]
        public string LenderCaseIdentifier { get => _lenderCaseIdentifier; set => _lenderCaseIdentifier = value; }
        private DirtyValue<StringEnumValue<LenderChannel>> _lenderChannel;
        /// <summary>
        /// Lender Channel [3332]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Channel")]
        public StringEnumValue<LenderChannel> LenderChannel { get => _lenderChannel; set => _lenderChannel = value; }
        private DirtyValue<decimal?> _lenderCreditsInFunding;
        /// <summary>
        /// Trans Details Lender Credits In Funding [4083]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Lender Credits In Funding")]
        public decimal? LenderCreditsInFunding { get => _lenderCreditsInFunding; set => _lenderCreditsInFunding = value; }
        private DirtyValue<string> _lenderInvestorCode;
        /// <summary>
        /// File Contacts Investor Code [476]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "File Contacts Investor Code")]
        public string LenderInvestorCode { get => _lenderInvestorCode; set => _lenderInvestorCode = value; }
        private DirtyValue<decimal?> _lenderPaidClosignCostsDotAmount;
        /// <summary>
        /// Fees Total Closing Costs Lender In Details of Transaction [LENPCCINDOT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Lender In Details of Transaction")]
        public decimal? LenderPaidClosignCostsDotAmount { get => _lenderPaidClosignCostsDotAmount; set => _lenderPaidClosignCostsDotAmount = value; }
        private DirtyValue<decimal?> _lenderPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Lender [LENPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Lender")]
        public decimal? LenderPaidClosingCostsAmount { get => _lenderPaidClosingCostsAmount; set => _lenderPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _lesserAppraisedValueOrSalesPrice;
        /// <summary>
        /// Lesser of Appraised Value or Original Sales Price [MORNET.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Lesser of Appraised Value or Original Sales Price")]
        public decimal? LesserAppraisedValueOrSalesPrice { get => _lesserAppraisedValueOrSalesPrice; set => _lesserAppraisedValueOrSalesPrice = value; }
        private DirtyValue<decimal?> _lifeInsuranceCoverageAmount;
        /// <summary>
        /// Trans Details Total Mo Pymt w/ Life Ins [1560]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Total Mo Pymt w/ Life Ins")]
        public decimal? LifeInsuranceCoverageAmount { get => _lifeInsuranceCoverageAmount; set => _lifeInsuranceCoverageAmount = value; }
        private DirtyValue<decimal?> _lifeInsuranceEstimatedMonthlyAmount;
        /// <summary>
        /// Insurance Est Mo Life Ins Pmt [1558]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Est Mo Life Ins Pmt")]
        public decimal? LifeInsuranceEstimatedMonthlyAmount { get => _lifeInsuranceEstimatedMonthlyAmount; set => _lifeInsuranceEstimatedMonthlyAmount = value; }
        private DirtyValue<decimal?> _lifeInsuranceTotalProtectedMonthlyAmount;
        /// <summary>
        /// Insurance Life Insurance Coverage [1559]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Life Insurance Coverage")]
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get => _lifeInsuranceTotalProtectedMonthlyAmount; set => _lifeInsuranceTotalProtectedMonthlyAmount = value; }
        private DirtyValue<decimal?> _linkedBorrowerRequestedLoanAmount;
        /// <summary>
        /// Trans Details Loan Amt - Copied from Linked Loan [LINK_1109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Loan Amt - Copied from Linked Loan")]
        public decimal? LinkedBorrowerRequestedLoanAmount { get => _linkedBorrowerRequestedLoanAmount; set => _linkedBorrowerRequestedLoanAmount = value; }
        private DirtyValue<string> _linkId;
        /// <summary>
        /// Loan LinkId [LINKGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LinkId { get => _linkId; set => _linkId = value; }
        private DirtyList<LoanActionLog> _loanActionLogs;
        /// <summary>
        /// Loan LoanActionLogs
        /// </summary>
        public IList<LoanActionLog> LoanActionLogs { get => _loanActionLogs ?? (_loanActionLogs = new DirtyList<LoanActionLog>()); set => _loanActionLogs = new DirtyList<LoanActionLog>(value); }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        /// <summary>
        /// Trans Details Term (Mos) [4]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Term (Mos)")]
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => _loanAmortizationTermMonths = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _loanAmortizationType;
        /// <summary>
        /// Trans Details Amort Type [608]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type")]
        public StringEnumValue<AmortizationType> LoanAmortizationType { get => _loanAmortizationType; set => _loanAmortizationType = value; }
        private DirtyValue<string> _loanCreatedDate;
        /// <summary>
        /// Loan LoanCreatedDate
        /// </summary>
        public string LoanCreatedDate { get => _loanCreatedDate; set => _loanCreatedDate = value; }
        private DirtyValue<DateTime?> _loanCreatedDateUtc;
        /// <summary>
        /// Loan Info Loan Created Date [2025]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true, Description = "Loan Info Loan Created Date")]
        public DateTime? LoanCreatedDateUtc { get => _loanCreatedDateUtc; set => _loanCreatedDateUtc = value; }
        private DirtyValue<string> _loanIdNumber;
        /// <summary>
        /// Loan ID # [4063]
        /// </summary>
        [LoanFieldProperty(Description = "Loan ID #")]
        public string LoanIdNumber { get => _loanIdNumber; set => _loanIdNumber = value; }
        private DirtyValue<bool?> _loanImportStatusIndicator;
        /// <summary>
        /// Loan Info Loan Import Status [3051]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Loan Import Status")]
        public bool? LoanImportStatusIndicator { get => _loanImportStatusIndicator; set => _loanImportStatusIndicator = value; }
        private DirtyValue<StringEnumValue<LoanLinkSyncType>> _loanLinkSyncType;
        /// <summary>
        /// Loan Link Sync Type [4185]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Link Sync Type")]
        public StringEnumValue<LoanLinkSyncType> LoanLinkSyncType { get => _loanLinkSyncType; set => _loanLinkSyncType = value; }
        private DirtyValue<string> _loanNumber;
        /// <summary>
        /// Trans Details Loan # [364]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan #")]
        public string LoanNumber { get => _loanNumber; set => _loanNumber = value; }
        private LoanProductData _loanProductData;
        /// <summary>
        /// Loan LoanProductData
        /// </summary>
        public LoanProductData LoanProductData { get => _loanProductData ?? (_loanProductData = new LoanProductData()); set => _loanProductData = value; }
        private DirtyValue<string> _loanProgramName;
        /// <summary>
        /// Trans Details Loan Program [1401]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Program")]
        public string LoanProgramName { get => _loanProgramName; set => _loanProgramName = value; }
        private DirtyList<LoanProgram> _loanPrograms;
        /// <summary>
        /// Loan LoanPrograms
        /// </summary>
        public IList<LoanProgram> LoanPrograms { get => _loanPrograms ?? (_loanPrograms = new DirtyList<LoanProgram>()); set => _loanPrograms = new DirtyList<LoanProgram>(value); }
        private DirtyValue<StringEnumValue<LoanPurposeOfRefinanceType>> _loanPurposeOfRefinanceType;
        /// <summary>
        /// Refinance Type [MORNET.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Refinance Type")]
        public StringEnumValue<LoanPurposeOfRefinanceType> LoanPurposeOfRefinanceType { get => _loanPurposeOfRefinanceType; set => _loanPurposeOfRefinanceType = value; }
        private DirtyValue<string> _loanSource;
        /// <summary>
        /// Loan Info Loan Source [2024]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Loan Source")]
        public string LoanSource { get => _loanSource; set => _loanSource = value; }
        private LoanSubmission _loanSubmission;
        /// <summary>
        /// Loan LoanSubmission
        /// </summary>
        public LoanSubmission LoanSubmission { get => _loanSubmission ?? (_loanSubmission = new LoanSubmission()); set => _loanSubmission = value; }
        private DirtyValue<decimal?> _loanTotalProposedMonthlyMaintenanceAmount;
        /// <summary>
        /// VA Mo Shelter Exp Est Maintenance [1147]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Mo Shelter Exp Est Maintenance")]
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get => _loanTotalProposedMonthlyMaintenanceAmount; set => _loanTotalProposedMonthlyMaintenanceAmount = value; }
        private DirtyValue<decimal?> _loanTotalProposedMonthlyUtilitiesAmount;
        /// <summary>
        /// VA Mo Shelter Exp Est Utilities [1148]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Mo Shelter Exp Est Utilities")]
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get => _loanTotalProposedMonthlyUtilitiesAmount; set => _loanTotalProposedMonthlyUtilitiesAmount = value; }
        private DirtyValue<string> _loanUnderwriterCHUMSIdentifier;
        /// <summary>
        /// Loan LoanUnderwriterCHUMSIdentifier
        /// </summary>
        public string LoanUnderwriterCHUMSIdentifier { get => _loanUnderwriterCHUMSIdentifier; set => _loanUnderwriterCHUMSIdentifier = value; }
        private DirtyValue<string> _loanVALoanProcedureType;
        /// <summary>
        /// Loan LoanVALoanProcedureType
        /// </summary>
        public string LoanVALoanProcedureType { get => _loanVALoanProcedureType; set => _loanVALoanProcedureType = value; }
        private DirtyValue<decimal?> _loanVARateReductionInitialComputationTotalAmount;
        /// <summary>
        /// Loan LoanVARateReductionInitialComputationTotalAmount
        /// </summary>
        public decimal? LoanVARateReductionInitialComputationTotalAmount { get => _loanVARateReductionInitialComputationTotalAmount; set => _loanVARateReductionInitialComputationTotalAmount = value; }
        private DirtyValue<decimal?> _loanVAResidualIncomeAmount;
        /// <summary>
        /// Loan LoanVAResidualIncomeAmount
        /// </summary>
        public decimal? LoanVAResidualIncomeAmount { get => _loanVAResidualIncomeAmount; set => _loanVAResidualIncomeAmount = value; }
        private DirtyValue<int?> _loanVersionId;
        /// <summary>
        /// Loan LoanVersionId
        /// </summary>
        public int? LoanVersionId { get => _loanVersionId; set => _loanVersionId = value; }
        private DirtyList<LockConfirmLog> _lockConfirmLogs;
        /// <summary>
        /// Loan LockConfirmLogs
        /// </summary>
        public IList<LockConfirmLog> LockConfirmLogs { get => _lockConfirmLogs ?? (_lockConfirmLogs = new DirtyList<LockConfirmLog>()); set => _lockConfirmLogs = new DirtyList<LockConfirmLog>(value); }
        private DirtyList<LockDenialLog> _lockDenialLogs;
        /// <summary>
        /// Loan LockDenialLogs
        /// </summary>
        public IList<LockDenialLog> LockDenialLogs { get => _lockDenialLogs ?? (_lockDenialLogs = new DirtyList<LockDenialLog>()); set => _lockDenialLogs = new DirtyList<LockDenialLog>(value); }
        private DirtyList<LockRequestLog> _lockRequestLogs;
        /// <summary>
        /// Loan LockRequestLogs
        /// </summary>
        public IList<LockRequestLog> LockRequestLogs { get => _lockRequestLogs ?? (_lockRequestLogs = new DirtyList<LockRequestLog>()); set => _lockRequestLogs = new DirtyList<LockRequestLog>(value); }
        private ElliLOCompensation _lOCompensation;
        /// <summary>
        /// Loan LOCompensation
        /// </summary>
        public ElliLOCompensation LOCompensation { get => _lOCompensation ?? (_lOCompensation = new ElliLOCompensation()); set => _lOCompensation = value; }
        private DirtyList<LogEntryLog> _logEntryLogs;
        /// <summary>
        /// Loan LogEntryLogs
        /// </summary>
        public IList<LogEntryLog> LogEntryLogs { get => _logEntryLogs ?? (_logEntryLogs = new DirtyList<LogEntryLog>()); set => _logEntryLogs = new DirtyList<LogEntryLog>(value); }
        private DirtyValue<decimal?> _ltv;
        /// <summary>
        /// Freddie Mac Loan To Value (LTV) [353]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Freddie Mac Loan To Value (LTV)")]
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<decimal?> _ltvPropertyValue;
        /// <summary>
        /// Subject Property Value for LTV [358]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Subject Property Value for LTV")]
        public decimal? LtvPropertyValue { get => _ltvPropertyValue; set => _ltvPropertyValue = value; }
        private DirtyValue<string> _masterCommitmentNumber;
        /// <summary>
        /// Master Commitment Number [3908]
        /// </summary>
        [LoanFieldProperty(Description = "Master Commitment Number")]
        public string MasterCommitmentNumber { get => _masterCommitmentNumber; set => _masterCommitmentNumber = value; }
        private DirtyValue<DateTime?> _maturityDate;
        /// <summary>
        /// Trans Details Loan Maturity Date [78]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Maturity Date")]
        public DateTime? MaturityDate { get => _maturityDate; set => _maturityDate = value; }
        private DirtyValue<decimal?> _maxBackRatio;
        /// <summary>
        /// Prequal Qual Ratio Bottom [1791]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Prequal Qual Ratio Bottom")]
        public decimal? MaxBackRatio { get => _maxBackRatio; set => _maxBackRatio = value; }
        private DirtyValue<decimal?> _maxFrontRatio;
        /// <summary>
        /// Prequal Qual Ratio Top [1790]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Prequal Qual Ratio Top")]
        public decimal? MaxFrontRatio { get => _maxFrontRatio; set => _maxFrontRatio = value; }
        private Mcaw _mcaw;
        /// <summary>
        /// Loan Mcaw
        /// </summary>
        public Mcaw Mcaw { get => _mcaw ?? (_mcaw = new Mcaw()); set => _mcaw = value; }
        private DirtyValue<string> _mersNumber;
        /// <summary>
        /// Trans Details MERS MIN # [1051]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details MERS MIN #")]
        public string MersNumber { get => _mersNumber; set => _mersNumber = value; }
        private DirtyValue<DateTime?> _mersNumberRegistrationDate;
        /// <summary>
        /// Shipping MERS Registration Date [2023]
        /// </summary>
        [LoanFieldProperty(Description = "Shipping MERS Registration Date")]
        public DateTime? MersNumberRegistrationDate { get => _mersNumberRegistrationDate; set => _mersNumberRegistrationDate = value; }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        /// <summary>
        /// Trans Details PMI/MIP/FF Financed [1045]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details PMI/MIP/FF Financed")]
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => _miAndFundingFeeFinancedAmount = value; }
        private DirtyValue<decimal?> _miAndFundingFeeTotalAmount;
        /// <summary>
        /// Trans Details PMI/MIP/FF Amt [969]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details PMI/MIP/FF Amt")]
        public decimal? MiAndFundingFeeTotalAmount { get => _miAndFundingFeeTotalAmount; set => _miAndFundingFeeTotalAmount = value; }
        private DirtyValue<DateTime?> _milestoneApprovedDate;
        /// <summary>
        /// Tracking - Approved Milestone Date [MS.APP]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Approved Milestone Date")]
        public DateTime? MilestoneApprovedDate { get => _milestoneApprovedDate; set => _milestoneApprovedDate = value; }
        private DirtyValue<DateTime?> _milestoneApprovedDueDate;
        /// <summary>
        /// Tracking - Approved Milestone Due Date [MS.APP.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Approved Milestone Due Date")]
        public DateTime? MilestoneApprovedDueDate { get => _milestoneApprovedDueDate; set => _milestoneApprovedDueDate = value; }
        private DirtyValue<DateTime?> _milestoneCompletedDate;
        /// <summary>
        /// Tracking - Completed Milestone Date [MS.CLO]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Completed Milestone Date")]
        public DateTime? MilestoneCompletedDate { get => _milestoneCompletedDate; set => _milestoneCompletedDate = value; }
        private DirtyValue<DateTime?> _milestoneCompletedDueDate;
        /// <summary>
        /// Tracking - Completed Milestone Due Date [MS.CLO.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Completed Milestone Due Date")]
        public DateTime? MilestoneCompletedDueDate { get => _milestoneCompletedDueDate; set => _milestoneCompletedDueDate = value; }
        private DirtyValue<DateTime?> _milestoneCurrentDateUtc;
        /// <summary>
        /// Tracking - Current Milestone Date [MS.STATUSDATE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true, Description = "Tracking - Current Milestone Date")]
        public DateTime? MilestoneCurrentDateUtc { get => _milestoneCurrentDateUtc; set => _milestoneCurrentDateUtc = value; }
        private DirtyValue<StringEnumValue<MilestoneCurrentName>> _milestoneCurrentName;
        /// <summary>
        /// Tracking - Current Milestone Name [MS.STATUS]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Current Milestone Name")]
        public StringEnumValue<MilestoneCurrentName> MilestoneCurrentName { get => _milestoneCurrentName; set => _milestoneCurrentName = value; }
        private DirtyValue<DateTime?> _milestoneDocSignedDate;
        /// <summary>
        /// Tracking - Doc Signed Milestone Date [MS.DOC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Doc Signed Milestone Date")]
        public DateTime? MilestoneDocSignedDate { get => _milestoneDocSignedDate; set => _milestoneDocSignedDate = value; }
        private DirtyValue<DateTime?> _milestoneDocSignedDueDate;
        /// <summary>
        /// Tracking - Doc Signed Milestone Due Date [MS.DOC.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Doc Signed Milestone Due Date")]
        public DateTime? MilestoneDocSignedDueDate { get => _milestoneDocSignedDueDate; set => _milestoneDocSignedDueDate = value; }
        private DirtyValue<int?> _milestoneDuration;
        /// <summary>
        /// Tracking - Loan Milestone Duration [MS.LOANDURATION]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Loan Milestone Duration")]
        public int? MilestoneDuration { get => _milestoneDuration; set => _milestoneDuration = value; }
        private DirtyValue<DateTime?> _milestoneFileStartedDate;
        /// <summary>
        /// Tracking - File Started Milestone Date [MS.START]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - File Started Milestone Date")]
        public DateTime? MilestoneFileStartedDate { get => _milestoneFileStartedDate; set => _milestoneFileStartedDate = value; }
        private DirtyList<MilestoneFreeRoleLog> _milestoneFreeRoleLogs;
        /// <summary>
        /// Loan MilestoneFreeRoleLogs
        /// </summary>
        public IList<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get => _milestoneFreeRoleLogs ?? (_milestoneFreeRoleLogs = new DirtyList<MilestoneFreeRoleLog>()); set => _milestoneFreeRoleLogs = new DirtyList<MilestoneFreeRoleLog>(value); }
        private DirtyValue<DateTime?> _milestoneFundedDate;
        /// <summary>
        /// Tracking - Funded Milestone Date [MS.FUN]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Funded Milestone Date")]
        public DateTime? MilestoneFundedDate { get => _milestoneFundedDate; set => _milestoneFundedDate = value; }
        private DirtyValue<DateTime?> _milestoneFundedDueDate;
        /// <summary>
        /// Tracking - Funded Milestone Due Date [MS.FUN.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Funded Milestone Due Date")]
        public DateTime? MilestoneFundedDueDate { get => _milestoneFundedDueDate; set => _milestoneFundedDueDate = value; }
        private DirtyList<MilestoneLog> _milestoneLogs;
        /// <summary>
        /// Loan MilestoneLogs
        /// </summary>
        public IList<MilestoneLog> MilestoneLogs { get => _milestoneLogs ?? (_milestoneLogs = new DirtyList<MilestoneLog>()); set => _milestoneLogs = new DirtyList<MilestoneLog>(value); }
        private DirtyValue<DateTime?> _milestoneProcessedDate;
        /// <summary>
        /// Tracking - Processed Milestone Date [MS.PROC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Processed Milestone Date")]
        public DateTime? MilestoneProcessedDate { get => _milestoneProcessedDate; set => _milestoneProcessedDate = value; }
        private DirtyValue<string> _milestoneStage;
        /// <summary>
        /// Tracking - Milestone Stage [1601]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Milestone Stage")]
        public string MilestoneStage { get => _milestoneStage; set => _milestoneStage = value; }
        private DirtyValue<DateTime?> _milestoneSubmittedDate;
        /// <summary>
        /// Tracking - Submitted Milestone Date [MS.SUB]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Submitted Milestone Date")]
        public DateTime? MilestoneSubmittedDate { get => _milestoneSubmittedDate; set => _milestoneSubmittedDate = value; }
        private DirtyValue<DateTime?> _milestoneSubmittedDueDate;
        /// <summary>
        /// Tracking - Submitted Milestone Due Date [MS.SUB.DUE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Tracking - Submitted Milestone Due Date")]
        public DateTime? MilestoneSubmittedDueDate { get => _milestoneSubmittedDueDate; set => _milestoneSubmittedDueDate = value; }
        private DirtyList<MilestoneTaskLog> _milestoneTaskLogs;
        /// <summary>
        /// Loan MilestoneTaskLogs
        /// </summary>
        public IList<MilestoneTaskLog> MilestoneTaskLogs { get => _milestoneTaskLogs ?? (_milestoneTaskLogs = new DirtyList<MilestoneTaskLog>()); set => _milestoneTaskLogs = new DirtyList<MilestoneTaskLog>(value); }
        private DirtyList<MilestoneTemplateLog> _milestoneTemplateLogs;
        /// <summary>
        /// Loan MilestoneTemplateLogs
        /// </summary>
        public IList<MilestoneTemplateLog> MilestoneTemplateLogs { get => _milestoneTemplateLogs ?? (_milestoneTemplateLogs = new DirtyList<MilestoneTemplateLog>()); set => _milestoneTemplateLogs = new DirtyList<MilestoneTemplateLog>(value); }
        private DirtyValue<decimal?> _mipBorrowerPaidInCashAmount;
        /// <summary>
        /// PMI Prepaid in Cash by Borrower [3033]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "PMI Prepaid in Cash by Borrower")]
        public decimal? MipBorrowerPaidInCashAmount { get => _mipBorrowerPaidInCashAmount; set => _mipBorrowerPaidInCashAmount = value; }
        private DirtyValue<decimal?> _mipPaidInCashAmount;
        /// <summary>
        /// Expenses Calc MIP/PMI Amt Paid In Cash [1760]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Calc MIP/PMI Amt Paid In Cash")]
        public decimal? MipPaidInCashAmount { get => _mipPaidInCashAmount; set => _mipPaidInCashAmount = value; }
        private Miscellaneous _miscellaneous;
        /// <summary>
        /// Loan Miscellaneous
        /// </summary>
        public Miscellaneous Miscellaneous { get => _miscellaneous ?? (_miscellaneous = new Miscellaneous()); set => _miscellaneous = value; }
        private DirtyValue<decimal?> _monthlyPIPaymentAmountForLE1andCD1;
        /// <summary>
        /// Trans Details Monthly PI Payment Amount For LE1 and CD1 [4085]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Monthly PI Payment Amount For LE1 and CD1")]
        public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get => _monthlyPIPaymentAmountForLE1andCD1; set => _monthlyPIPaymentAmountForLE1andCD1 = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremiumFHARefundAmount;
        /// <summary>
        /// Loan MortgageInsurancePremiumFHARefundAmount
        /// </summary>
        public decimal? MortgageInsurancePremiumFHARefundAmount { get => _mortgageInsurancePremiumFHARefundAmount; set => _mortgageInsurancePremiumFHARefundAmount = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremiumUpfrontFactorPercent;
        /// <summary>
        /// Insurance Mtg Ins Upfront Factor [1107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Insurance Mtg Ins Upfront Factor")]
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => _mortgageInsurancePremiumUpfrontFactorPercent; set => _mortgageInsurancePremiumUpfrontFactorPercent = value; }
        private DirtyValue<StringEnumValue<LoanType>> _mortgageType;
        /// <summary>
        /// Trans Details Loan Type [1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<LoanType> MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<string> _msaIdentifier;
        /// <summary>
        /// Fannie Mae Metro Stat Area/County [MORNET.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Metro Stat Area/County")]
        public string MsaIdentifier { get => _msaIdentifier; set => _msaIdentifier = value; }
        private NetTangibleBenefit _netTangibleBenefit;
        /// <summary>
        /// Loan NetTangibleBenefit
        /// </summary>
        public NetTangibleBenefit NetTangibleBenefit { get => _netTangibleBenefit ?? (_netTangibleBenefit = new NetTangibleBenefit()); set => _netTangibleBenefit = value; }
        private DirtyValue<decimal?> _newFirstMortgageAmount;
        /// <summary>
        /// Trans Details New First Mtg [1845]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details New First Mtg")]
        public decimal? NewFirstMortgageAmount { get => _newFirstMortgageAmount; set => _newFirstMortgageAmount = value; }
        private DirtyValue<string> _nmlsLoanOriginatorId;
        /// <summary>
        /// NMLS Loan Originator ID [3238]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Loan Originator ID")]
        public string NmlsLoanOriginatorId { get => _nmlsLoanOriginatorId; set => _nmlsLoanOriginatorId = value; }
        private DirtyValue<bool?> _noClosingCostOption;
        /// <summary>
        /// Rate Lock No Closing Cost Option [3891]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock No Closing Cost Option")]
        public bool? NoClosingCostOption { get => _noClosingCostOption; set => _noClosingCostOption = value; }
        private DirtyList<NonBorrowingOwner> _nonBorrowingOwners;
        /// <summary>
        /// Loan NonBorrowingOwners
        /// </summary>
        public IList<NonBorrowingOwner> NonBorrowingOwners { get => _nonBorrowingOwners ?? (_nonBorrowingOwners = new DirtyList<NonBorrowingOwner>()); set => _nonBorrowingOwners = new DirtyList<NonBorrowingOwner>(value); }
        private DirtyList<NonVol> _nonVols;
        /// <summary>
        /// Loan NonVols
        /// </summary>
        public IList<NonVol> NonVols { get => _nonVols ?? (_nonVols = new DirtyList<NonVol>()); set => _nonVols = new DirtyList<NonVol>(value); }
        private DirtyValue<bool?> _notRequiredForPurchaseSaleOrRefinance;
        /// <summary>
        /// Disclosure Purchase Sale or Refi [AFF.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Purchase Sale or Refi", OptionsJson = "{\"true\":\"purchase, sale, or refinance of, the subject property.\"}")]
        public bool? NotRequiredForPurchaseSaleOrRefinance { get => _notRequiredForPurchaseSaleOrRefinance; set => _notRequiredForPurchaseSaleOrRefinance = value; }
        private DirtyValue<bool?> _notRequiredForSettlementOfYourLoan;
        /// <summary>
        /// Disclosure Settlement of Loan [AFF.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Settlement of Loan", OptionsJson = "{\"true\":\"settlement of your loan on,\"}")]
        public bool? NotRequiredForSettlementOfYourLoan { get => _notRequiredForSettlementOfYourLoan; set => _notRequiredForSettlementOfYourLoan = value; }
        private DirtyValue<StringEnumValue<OccupancyType>> _occupancyType;
        /// <summary>
        /// Occupancy Type [3335]
        /// </summary>
        [LoanFieldProperty(Description = "Occupancy Type")]
        public StringEnumValue<OccupancyType> OccupancyType { get => _occupancyType; set => _occupancyType = value; }
        private DirtyValue<string> _openingDocsInvestorCode;
        /// <summary>
        /// Disclosures - Investor Code [Opening.InvCd]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosures - Investor Code")]
        public string OpeningDocsInvestorCode { get => _openingDocsInvestorCode; set => _openingDocsInvestorCode = value; }
        private DirtyValue<StringEnumValue<DocsLoanProgramType>> _openingDocsLoanProgramType;
        /// <summary>
        /// Disclosures - Plan Code Type [Opening.LoanProgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosures - Plan Code Type")]
        public StringEnumValue<DocsLoanProgramType> OpeningDocsLoanProgramType { get => _openingDocsLoanProgramType; set => _openingDocsLoanProgramType = value; }
        private DirtyValue<string> _openingDocsPlanDescription;
        /// <summary>
        /// Disclosures - Plan Description [Opening.PlanDesc]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosures - Plan Description")]
        public string OpeningDocsPlanDescription { get => _openingDocsPlanDescription; set => _openingDocsPlanDescription = value; }
        private DirtyValue<string> _openingDocsPlanId;
        /// <summary>
        /// Disclosures - Ellie Mae Plan ID [Opening.PlanID]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosures - Ellie Mae Plan ID")]
        public string OpeningDocsPlanId { get => _openingDocsPlanId; set => _openingDocsPlanId = value; }
        private DirtyValue<string> _openingDocsProgramCode;
        /// <summary>
        /// Disclosures - Program Code [Opening.ProgCd]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosures - Program Code")]
        public string OpeningDocsProgramCode { get => _openingDocsProgramCode; set => _openingDocsProgramCode = value; }
        private DirtyValue<string> _openingDocsStackingOrder;
        /// <summary>
        /// Opening Document Stacking Order [Opening.DocStkOrdr]
        /// </summary>
        [LoanFieldProperty(Description = "Opening Document Stacking Order")]
        public string OpeningDocsStackingOrder { get => _openingDocsStackingOrder; set => _openingDocsStackingOrder = value; }
        private DirtyValue<string> _organizationCode;
        /// <summary>
        /// Company - Users Organization Code [ORGID]
        /// </summary>
        [LoanFieldProperty(Description = "Company - Users Organization Code")]
        public string OrganizationCode { get => _organizationCode; set => _organizationCode = value; }
        private DirtyValue<DateTime?> _originationDate;
        /// <summary>
        /// Trans Details Application Date [745]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Application Date")]
        public DateTime? OriginationDate { get => _originationDate; set => _originationDate = value; }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        /// <summary>
        /// Trans Details Amort Type Other Descr [994]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type Other Descr")]
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => _otherAmortizationTypeDescription = value; }
        private DirtyValue<string> _otherMortgageTypeDescription;
        /// <summary>
        /// Trans Details Loan Type Other [1063]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type Other")]
        public string OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => _otherMortgageTypeDescription = value; }
        private DirtyValue<decimal?> _otherPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Other [OTHPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Other")]
        public decimal? OtherPaidClosingCostsAmount { get => _otherPaidClosingCostsAmount; set => _otherPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _overwireAmount;
        /// <summary>
        /// Trans Details Overwire Amount [2005]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Overwire Amount")]
        public decimal? OverwireAmount { get => _overwireAmount; set => _overwireAmount = value; }
        private DirtyValue<bool?> _paymentScheduleCalcRequiredIndicator;
        /// <summary>
        /// Payment Schedule Calculation is Required [CALCREQUIRED]
        /// </summary>
        [LoanFieldProperty(Description = "Payment Schedule Calculation is Required")]
        public bool? PaymentScheduleCalcRequiredIndicator { get => _paymentScheduleCalcRequiredIndicator; set => _paymentScheduleCalcRequiredIndicator = value; }
        private DirtyValue<string> _percentageOfOwnership;
        /// <summary>
        /// Disclosure Bus Affiliate Relationship/% [AFF.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Bus Affiliate Relationship/%")]
        public string PercentageOfOwnership { get => _percentageOfOwnership; set => _percentageOfOwnership = value; }
        private DirtyValue<decimal?> _percentageOwnershipInterest;
        /// <summary>
        /// The Percentage of Ownership Interest is [AFF.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "The Percentage of Ownership Interest is")]
        public decimal? PercentageOwnershipInterest { get => _percentageOwnershipInterest; set => _percentageOwnershipInterest = value; }
        private DirtyValue<bool?> _pmiIndicator;
        /// <summary>
        /// Private Mortgage Insurance Indicator [3336]
        /// </summary>
        [LoanFieldProperty(Description = "Private Mortgage Insurance Indicator", OptionsJson = "{\"true\":\"PMI Included\",\"false\":\"PMI Not Included\"}")]
        public bool? PmiIndicator { get => _pmiIndicator; set => _pmiIndicator = value; }
        private DirtyList<PostClosingConditionLog> _postClosingConditionLogs;
        /// <summary>
        /// Loan PostClosingConditionLogs
        /// </summary>
        public IList<PostClosingConditionLog> PostClosingConditionLogs { get => _postClosingConditionLogs ?? (_postClosingConditionLogs = new DirtyList<PostClosingConditionLog>()); set => _postClosingConditionLogs = new DirtyList<PostClosingConditionLog>(value); }
        private DirtyList<PreliminaryConditionLog> _preliminaryConditionLogs;
        /// <summary>
        /// Loan PreliminaryConditionLogs
        /// </summary>
        public IList<PreliminaryConditionLog> PreliminaryConditionLogs { get => _preliminaryConditionLogs ?? (_preliminaryConditionLogs = new DirtyList<PreliminaryConditionLog>()); set => _preliminaryConditionLogs = new DirtyList<PreliminaryConditionLog>(value); }
        private Prequalification _prequalification;
        /// <summary>
        /// Loan Prequalification
        /// </summary>
        public Prequalification Prequalification { get => _prequalification ?? (_prequalification = new Prequalification()); set => _prequalification = value; }
        private DirtyValue<decimal?> _principalAndInterestMonthlyPaymentAmount;
        /// <summary>
        /// Trans Details Mo Pymt (P&amp;I) [5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Mo Pymt (P&I)")]
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => _principalAndInterestMonthlyPaymentAmount; set => _principalAndInterestMonthlyPaymentAmount = value; }
        private DirtyValue<StringEnumValue<Print2003Application>> _print2003Application;
        /// <summary>
        /// Trans Details Print 2003 Appl [1825]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Print 2003 Appl")]
        public StringEnumValue<Print2003Application> Print2003Application { get => _print2003Application; set => _print2003Application = value; }
        private DirtyList<PrintLog> _printLogs;
        /// <summary>
        /// Loan PrintLogs
        /// </summary>
        public IList<PrintLog> PrintLogs { get => _printLogs ?? (_printLogs = new DirtyList<PrintLog>()); set => _printLogs = new DirtyList<PrintLog>(value); }
        private PrivacyPolicy _privacyPolicy;
        /// <summary>
        /// Loan PrivacyPolicy
        /// </summary>
        public PrivacyPolicy PrivacyPolicy { get => _privacyPolicy ?? (_privacyPolicy = new PrivacyPolicy()); set => _privacyPolicy = value; }
        private ProfitManagement _profitManagement;
        /// <summary>
        /// Loan ProfitManagement
        /// </summary>
        public ProfitManagement ProfitManagement { get => _profitManagement ?? (_profitManagement = new ProfitManagement()); set => _profitManagement = value; }
        private Property _property;
        /// <summary>
        /// Loan Property
        /// </summary>
        public Property Property { get => _property ?? (_property = new Property()); set => _property = value; }
        private DirtyValue<int?> _propertyAppraisedValueAmount;
        /// <summary>
        /// Subject Property Appraised Value [356]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Appraised Value")]
        public int? PropertyAppraisedValueAmount { get => _propertyAppraisedValueAmount; set => _propertyAppraisedValueAmount = value; }
        private DirtyValue<bool?> _propertyEnergyEfficientHomeIndicator;
        /// <summary>
        /// Fannie Mae Energy Effic Mtg Indicator [157]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Energy Effic Mtg Indicator", OptionsJson = "{\"true\":\"Energy Efficient Mortgage\"}")]
        public bool? PropertyEnergyEfficientHomeIndicator { get => _propertyEnergyEfficientHomeIndicator; set => _propertyEnergyEfficientHomeIndicator = value; }
        private DirtyValue<int?> _propertyEstimatedValueAmount;
        /// <summary>
        /// Subject Property Est Value [1821]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Est Value")]
        public int? PropertyEstimatedValueAmount { get => _propertyEstimatedValueAmount; set => _propertyEstimatedValueAmount = value; }
        private DirtyValue<string> _proposedDuesAmount;
        /// <summary>
        /// Expenses Proposed HOA [233]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Proposed HOA")]
        public string ProposedDuesAmount { get => _proposedDuesAmount; set => _proposedDuesAmount = value; }
        private DirtyValue<decimal?> _proposedFirstMortgageAmount;
        /// <summary>
        /// Expenses Proposed Mtg Pymt [228]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Proposed Mtg Pymt")]
        public decimal? ProposedFirstMortgageAmount { get => _proposedFirstMortgageAmount; set => _proposedFirstMortgageAmount = value; }
        private DirtyValue<decimal?> _proposedGroundRentAmount;
        /// <summary>
        /// Loan ProposedGroundRentAmount
        /// </summary>
        public decimal? ProposedGroundRentAmount { get => _proposedGroundRentAmount; set => _proposedGroundRentAmount = value; }
        private DirtyValue<string> _proposedHazardInsuranceAmount;
        /// <summary>
        /// Expenses Proposed Haz Ins [230]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Proposed Haz Ins")]
        public string ProposedHazardInsuranceAmount { get => _proposedHazardInsuranceAmount; set => _proposedHazardInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedHousingExpenseTotal;
        /// <summary>
        /// Expenses Proposed Total Housing [912]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Proposed Total Housing")]
        public decimal? ProposedHousingExpenseTotal { get => _proposedHousingExpenseTotal; set => _proposedHousingExpenseTotal = value; }
        private DirtyValue<string> _proposedMortgageInsuranceAmount;
        /// <summary>
        /// Expenses Proposed Mtg Ins [232]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Proposed Mtg Ins")]
        public string ProposedMortgageInsuranceAmount { get => _proposedMortgageInsuranceAmount; set => _proposedMortgageInsuranceAmount = value; }
        private DirtyValue<decimal?> _proposedOtherAmount;
        /// <summary>
        /// Expenses Proposed Other Housing [234]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Proposed Other Housing")]
        public decimal? ProposedOtherAmount { get => _proposedOtherAmount; set => _proposedOtherAmount = value; }
        private DirtyValue<decimal?> _proposedOtherMortgagesAmount;
        /// <summary>
        /// Expenses Proposed Other Pymt [229]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Proposed Other Pymt")]
        public decimal? ProposedOtherMortgagesAmount { get => _proposedOtherMortgagesAmount; set => _proposedOtherMortgagesAmount = value; }
        private DirtyValue<string> _proposedRealEstateTaxesAmount;
        /// <summary>
        /// Expenses Proposed Taxes [1405]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Proposed Taxes")]
        public string ProposedRealEstateTaxesAmount { get => _proposedRealEstateTaxesAmount; set => _proposedRealEstateTaxesAmount = value; }
        private DirtyList<PurchaseCredit> _purchaseCredits;
        /// <summary>
        /// Loan PurchaseCredits
        /// </summary>
        public IList<PurchaseCredit> PurchaseCredits { get => _purchaseCredits ?? (_purchaseCredits = new DirtyList<PurchaseCredit>()); set => _purchaseCredits = new DirtyList<PurchaseCredit>(value); }
        private DirtyValue<decimal?> _purchasePriceAmount;
        /// <summary>
        /// Trans Details Purchase Price [136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Purchase Price")]
        public decimal? PurchasePriceAmount { get => _purchasePriceAmount; set => _purchasePriceAmount = value; }
        private RateLock _rateLock;
        /// <summary>
        /// Loan RateLock
        /// </summary>
        public RateLock RateLock { get => _rateLock ?? (_rateLock = new RateLock()); set => _rateLock = value; }
        private DirtyValue<string> _referralAddress;
        /// <summary>
        /// File Contacts Referral Addr [1830]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Referral Addr")]
        public string ReferralAddress { get => _referralAddress; set => _referralAddress = value; }
        private DirtyValue<string> _referralCity;
        /// <summary>
        /// File Contacts Referral City [1831]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Referral City")]
        public string ReferralCity { get => _referralCity; set => _referralCity = value; }
        private DirtyValue<decimal?> _referralFeeAmount;
        /// <summary>
        /// File Contacts Referral Fee [1834]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts Referral Fee")]
        public decimal? ReferralFeeAmount { get => _referralFeeAmount; set => _referralFeeAmount = value; }
        private DirtyValue<string> _referralPostalCode;
        /// <summary>
        /// File Contacts Referral Zip [1833]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "File Contacts Referral Zip")]
        public string ReferralPostalCode { get => _referralPostalCode; set => _referralPostalCode = value; }
        private DirtyValue<string> _referralSource;
        /// <summary>
        /// File Contacts Referral Name [1822]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Referral Name")]
        public string ReferralSource { get => _referralSource; set => _referralSource = value; }
        private EntityReference _referralSourceContact;
        /// <summary>
        /// Loan ReferralSourceContact
        /// </summary>
        public EntityReference ReferralSourceContact { get => _referralSourceContact ?? (_referralSourceContact = new EntityReference()); set => _referralSourceContact = value; }
        private DirtyValue<StringEnumValue<State>> _referralState;
        /// <summary>
        /// File Contacts Referral State [1832]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Referral State")]
        public StringEnumValue<State> ReferralState { get => _referralState; set => _referralState = value; }
        private DirtyValue<decimal?> _refinanceIncludingDebtsToBePaidOffAmount;
        /// <summary>
        /// Trans Details Refinance [1092]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Refinance")]
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get => _refinanceIncludingDebtsToBePaidOffAmount; set => _refinanceIncludingDebtsToBePaidOffAmount = value; }
        private DirtyList<RegistrationLog> _registrationLogs;
        /// <summary>
        /// Loan RegistrationLogs
        /// </summary>
        public IList<RegistrationLog> RegistrationLogs { get => _registrationLogs ?? (_registrationLogs = new DirtyList<RegistrationLog>()); set => _registrationLogs = new DirtyList<RegistrationLog>(value); }
        private RegulationZ _regulationZ;
        /// <summary>
        /// Loan RegulationZ
        /// </summary>
        public RegulationZ RegulationZ { get => _regulationZ ?? (_regulationZ = new RegulationZ()); set => _regulationZ = value; }
        private DirtyList<RemovedLogRecord> _removedLogRecords;
        /// <summary>
        /// Loan RemovedLogRecords
        /// </summary>
        public IList<RemovedLogRecord> RemovedLogRecords { get => _removedLogRecords ?? (_removedLogRecords = new DirtyList<RemovedLogRecord>()); set => _removedLogRecords = new DirtyList<RemovedLogRecord>(value); }
        private DirtyValue<decimal?> _repurchaseCostAmount;
        /// <summary>
        /// Repurchase Cost [3313]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Repurchase Cost")]
        public decimal? RepurchaseCostAmount { get => _repurchaseCostAmount; set => _repurchaseCostAmount = value; }
        private DirtyValue<DateTime?> _repurchaseDate;
        /// <summary>
        /// Repurchase Date [3312]
        /// </summary>
        [LoanFieldProperty(Description = "Repurchase Date")]
        public DateTime? RepurchaseDate { get => _repurchaseDate; set => _repurchaseDate = value; }
        private DirtyValue<decimal?> _requestedInterestRatePercent;
        /// <summary>
        /// Trans Details Interest Rate [3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Interest Rate")]
        public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => _requestedInterestRatePercent = value; }
        private DirtyValue<string> _requestedInterestRatePercentUI;
        /// <summary>
        /// Trans Details Interest Rate - Display field with KBYO rounding rules [KBYO.XD3]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interest Rate - Display field with KBYO rounding rules")]
        public string RequestedInterestRatePercentUI { get => _requestedInterestRatePercentUI; set => _requestedInterestRatePercentUI = value; }
        private DirtyValue<decimal?> _salesConcessionAmount;
        /// <summary>
        /// Fannie Mae Seller Concessions [MORNET.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae Seller Concessions")]
        public decimal? SalesConcessionAmount { get => _salesConcessionAmount; set => _salesConcessionAmount = value; }
        private DirtyValue<decimal?> _secondSubordinateAmount;
        /// <summary>
        /// Trans Details Sub Fin Second Mtg Loan Amt [428]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Sub Fin Second Mtg Loan Amt")]
        public decimal? SecondSubordinateAmount { get => _secondSubordinateAmount; set => _secondSubordinateAmount = value; }
        private Section32 _section32;
        /// <summary>
        /// Loan Section32
        /// </summary>
        public Section32 Section32 { get => _section32 ?? (_section32 = new Section32()); set => _section32 = value; }
        private DirtyValue<StringEnumValue<SectionOfActType>> _sectionOfActType;
        /// <summary>
        /// Loan Info Section of Housing Act [1039]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Section of Housing Act")]
        public StringEnumValue<SectionOfActType> SectionOfActType { get => _sectionOfActType; set => _sectionOfActType = value; }
        private SelectedHomeCounselingProvider _selectedHomeCounselingProvider;
        /// <summary>
        /// Loan SelectedHomeCounselingProvider
        /// </summary>
        public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get => _selectedHomeCounselingProvider ?? (_selectedHomeCounselingProvider = new SelectedHomeCounselingProvider()); set => _selectedHomeCounselingProvider = value; }
        private DirtyValue<decimal?> _sellerPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Seller [143]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Seller")]
        public decimal? SellerPaidClosingCostsAmount { get => _sellerPaidClosingCostsAmount; set => _sellerPaidClosingCostsAmount = value; }
        private DirtyValue<DateTime?> _serverDateTimeDDMApplied;
        /// <summary>
        /// Server Date Time DDM Applied [DMDDM.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true, Description = "Server Date Time DDM Applied")]
        public DateTime? ServerDateTimeDDMApplied { get => _serverDateTimeDDMApplied; set => _serverDateTimeDDMApplied = value; }
        private DirtyValue<string> _serviceProviderAdditionalInfo;
        /// <summary>
        /// Settlement Service Provided - Additional Information [SP.ADDITIONALINFO]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provided - Additional Information")]
        public string ServiceProviderAdditionalInfo { get => _serviceProviderAdditionalInfo; set => _serviceProviderAdditionalInfo = value; }
        private DirtyList<ServiceProviderContact> _serviceProviderContacts;
        /// <summary>
        /// Loan ServiceProviderContacts
        /// </summary>
        public IList<ServiceProviderContact> ServiceProviderContacts { get => _serviceProviderContacts ?? (_serviceProviderContacts = new DirtyList<ServiceProviderContact>()); set => _serviceProviderContacts = new DirtyList<ServiceProviderContact>(value); }
        private DirtyValue<DateTime?> _serviceProviderDateIssued;
        /// <summary>
        /// Settlement Service Provided - Date Issued [SP.DATEISSUED]
        /// </summary>
        [LoanFieldProperty(Description = "Settlement Service Provided - Date Issued")]
        public DateTime? ServiceProviderDateIssued { get => _serviceProviderDateIssued; set => _serviceProviderDateIssued = value; }
        private ServicingDisclosure _servicingDisclosure;
        /// <summary>
        /// Loan ServicingDisclosure
        /// </summary>
        public ServicingDisclosure ServicingDisclosure { get => _servicingDisclosure ?? (_servicingDisclosure = new ServicingDisclosure()); set => _servicingDisclosure = value; }
        private DirtyValue<bool?> _setForSettlementServicesOfAnAttorney;
        /// <summary>
        /// Disclosure Required to Use Listed Provider [AFF.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Required to Use Listed Provider")]
        public bool? SetForSettlementServicesOfAnAttorney { get => _setForSettlementServicesOfAnAttorney; set => _setForSettlementServicesOfAnAttorney = value; }
        private DirtyValue<bool?> _setForTheSettlementServicesListed;
        /// <summary>
        /// Disclosure Not required to Use Listed Provider [AFF.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Not required to Use Listed Provider")]
        public bool? SetForTheSettlementServicesListed { get => _setForTheSettlementServicesListed; set => _setForTheSettlementServicesListed = value; }
        private DirtyList<SettlementServiceCharge> _settlementServiceCharges;
        /// <summary>
        /// Loan SettlementServiceCharges
        /// </summary>
        public IList<SettlementServiceCharge> SettlementServiceCharges { get => _settlementServiceCharges ?? (_settlementServiceCharges = new DirtyList<SettlementServiceCharge>()); set => _settlementServiceCharges = new DirtyList<SettlementServiceCharge>(value); }
        private Shipping _shipping;
        /// <summary>
        /// Loan Shipping
        /// </summary>
        public Shipping Shipping { get => _shipping ?? (_shipping = new Shipping()); set => _shipping = value; }
        private DirtyValue<bool?> _simpleRefinanceType;
        /// <summary>
        /// Simple Refinance (FHA to FHA) [MORNET.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Simple Refinance (FHA to FHA)")]
        public bool? SimpleRefinanceType { get => _simpleRefinanceType; set => _simpleRefinanceType = value; }
        private DirtyValue<decimal?> _startingAdjPrice;
        /// <summary>
        /// Loan StartingAdjPrice
        /// </summary>
        public decimal? StartingAdjPrice { get => _startingAdjPrice; set => _startingAdjPrice = value; }
        private DirtyValue<decimal?> _startingAdjRate;
        /// <summary>
        /// Loan StartingAdjRate
        /// </summary>
        public decimal? StartingAdjRate { get => _startingAdjRate; set => _startingAdjRate = value; }
        private StateDisclosure _stateDisclosure;
        /// <summary>
        /// Loan StateDisclosure
        /// </summary>
        public StateDisclosure StateDisclosure { get => _stateDisclosure ?? (_stateDisclosure = new StateDisclosure()); set => _stateDisclosure = value; }
        private StatementCreditDenial _statementCreditDenial;
        /// <summary>
        /// Loan StatementCreditDenial
        /// </summary>
        public StatementCreditDenial StatementCreditDenial { get => _statementCreditDenial ?? (_statementCreditDenial = new StatementCreditDenial()); set => _statementCreditDenial = value; }
        private DirtyList<StatusOnlineLog> _statusOnlineLogs;
        /// <summary>
        /// Loan StatusOnlineLogs
        /// </summary>
        public IList<StatusOnlineLog> StatusOnlineLogs { get => _statusOnlineLogs ?? (_statusOnlineLogs = new DirtyList<StatusOnlineLog>()); set => _statusOnlineLogs = new DirtyList<StatusOnlineLog>(value); }
        private DirtyValue<decimal?> _subjectPropertyGrossRentalIncomeAmount;
        /// <summary>
        /// Subject Property Gross Rent [1005]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Gross Rent")]
        public decimal? SubjectPropertyGrossRentalIncomeAmount { get => _subjectPropertyGrossRentalIncomeAmount; set => _subjectPropertyGrossRentalIncomeAmount = value; }
        private DirtyValue<decimal?> _subjectPropertyOccupancyPercent;
        /// <summary>
        /// Subject Property Occupancy Rate [1487]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Occupancy Rate")]
        public decimal? SubjectPropertyOccupancyPercent { get => _subjectPropertyOccupancyPercent; set => _subjectPropertyOccupancyPercent = value; }
        private DirtyValue<decimal?> _subordinateLienAmount;
        /// <summary>
        /// Trans Details Subordinate Financing [140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Subordinate Financing")]
        public decimal? SubordinateLienAmount { get => _subordinateLienAmount; set => _subordinateLienAmount = value; }
        private DirtyValue<string> _systemIdGuid;
        /// <summary>
        /// LE Latest Guid [SYS.X610]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Latest Guid")]
        public string SystemIdGuid { get => _systemIdGuid; set => _systemIdGuid = value; }
        private DirtyValue<DateTime?> _tilApplicationDate;
        /// <summary>
        /// TIL Application Date [3292]
        /// </summary>
        [LoanFieldProperty(Description = "TIL Application Date")]
        public DateTime? TilApplicationDate { get => _tilApplicationDate; set => _tilApplicationDate = value; }
        private DirtyValue<string> _titleHolderName1;
        /// <summary>
        /// Subject Property Title Name 1 [31]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Name 1")]
        public string TitleHolderName1 { get => _titleHolderName1; set => _titleHolderName1 = value; }
        private DirtyValue<string> _titleHolderName2;
        /// <summary>
        /// Subject Property Title Name 2 [1602]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Name 2")]
        public string TitleHolderName2 { get => _titleHolderName2; set => _titleHolderName2 = value; }
        private DirtyValue<decimal?> _tltv;
        /// <summary>
        /// Freddie Mac Total Loan to Value (TLTV) [975]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Freddie Mac Total Loan to Value (TLTV)")]
        public decimal? Tltv { get => _tltv; set => _tltv = value; }
        private DirtyValue<decimal?> _totalClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs [TOTPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Closing Costs")]
        public decimal? TotalClosingCostsAmount { get => _totalClosingCostsAmount; set => _totalClosingCostsAmount = value; }
        private DirtyValue<decimal?> _totalDeductionsAmount;
        /// <summary>
        /// Trans Details Total Deductions [1989]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Deductions")]
        public decimal? TotalDeductionsAmount { get => _totalDeductionsAmount; set => _totalDeductionsAmount = value; }
        private DirtyValue<decimal?> _totalFeesCostAmount;
        /// <summary>
        /// Fees Total Costs [1073]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Costs")]
        public decimal? TotalFeesCostAmount { get => _totalFeesCostAmount; set => _totalFeesCostAmount = value; }
        private DirtyValue<decimal?> _totalFeesCreditAmount;
        /// <summary>
        /// Fees Total Credits [1844]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Credits")]
        public decimal? TotalFeesCreditAmount { get => _totalFeesCreditAmount; set => _totalFeesCreditAmount = value; }
        private DirtyValue<decimal?> _totalNonborrowerPaidClosingCostsAmount;
        /// <summary>
        /// Fees Total Closing Costs Non-Borr [TNBPCC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Non-Borr")]
        public decimal? TotalNonborrowerPaidClosingCostsAmount { get => _totalNonborrowerPaidClosingCostsAmount; set => _totalNonborrowerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _totalPaidOutsideClosingAmount;
        /// <summary>
        /// Fees Total Paid Outside of Closing (Oth Summaries) [TOTPOC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Paid Outside of Closing (Oth Summaries)")]
        public decimal? TotalPaidOutsideClosingAmount { get => _totalPaidOutsideClosingAmount; set => _totalPaidOutsideClosingAmount = value; }
        private DirtyValue<decimal?> _totalPaidToBrokerAmount;
        /// <summary>
        /// Trans Details Total Paid To [1988]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Paid To")]
        public decimal? TotalPaidToBrokerAmount { get => _totalPaidToBrokerAmount; set => _totalPaidToBrokerAmount = value; }
        private DirtyValue<decimal?> _totalWireTransferAmount;
        /// <summary>
        /// Trans Details Total Wire Transfer [1990]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Wire Transfer")]
        public decimal? TotalWireTransferAmount { get => _totalWireTransferAmount; set => _totalWireTransferAmount = value; }
        private TPO _tPO;
        /// <summary>
        /// Loan TPO
        /// </summary>
        public TPO TPO { get => _tPO ?? (_tPO = new TPO()); set => _tPO = value; }
        private TQL _tQL;
        /// <summary>
        /// Loan TQL
        /// </summary>
        public TQL TQL { get => _tQL ?? (_tQL = new TQL()); set => _tQL = value; }
        private TrustAccount _trustAccount;
        /// <summary>
        /// Loan TrustAccount
        /// </summary>
        public TrustAccount TrustAccount { get => _trustAccount ?? (_trustAccount = new TrustAccount()); set => _trustAccount = value; }
        private Tsum _tsum;
        /// <summary>
        /// Loan Tsum
        /// </summary>
        public Tsum Tsum { get => _tsum ?? (_tsum = new Tsum()); set => _tsum = value; }
        private DirtyValue<bool?> _twelveMonthMortgageRentalHistoryIndicator;
        /// <summary>
        /// Borrower Can Demonstrate 12-Month Mortgage/Rental History [3515]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Can Demonstrate 12-Month Mortgage/Rental History")]
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get => _twelveMonthMortgageRentalHistoryIndicator; set => _twelveMonthMortgageRentalHistoryIndicator = value; }
        private Uldd _uldd;
        /// <summary>
        /// Loan Uldd
        /// </summary>
        public Uldd Uldd { get => _uldd ?? (_uldd = new Uldd()); set => _uldd = value; }
        private UnderwriterSummary _underwriterSummary;
        /// <summary>
        /// Loan UnderwriterSummary
        /// </summary>
        public UnderwriterSummary UnderwriterSummary { get => _underwriterSummary ?? (_underwriterSummary = new UnderwriterSummary()); set => _underwriterSummary = value; }
        private DirtyList<UnderwritingConditionLog> _underwritingConditionLogs;
        /// <summary>
        /// Loan UnderwritingConditionLogs
        /// </summary>
        public IList<UnderwritingConditionLog> UnderwritingConditionLogs { get => _underwritingConditionLogs ?? (_underwritingConditionLogs = new DirtyList<UnderwritingConditionLog>()); set => _underwritingConditionLogs = new DirtyList<UnderwritingConditionLog>(value); }
        private DirtyValue<bool?> _underwritingEscrowIndicator;
        /// <summary>
        /// Underwriting Escrow [1550]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Escrow", OptionsJson = "{\"true\":\"Escrow (T&I)\"}")]
        public bool? UnderwritingEscrowIndicator { get => _underwritingEscrowIndicator; set => _underwritingEscrowIndicator = value; }
        private DirtyValue<decimal?> _undiscountedRate;
        /// <summary>
        /// UnDiscounted Rate [3293]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "UnDiscounted Rate")]
        public decimal? UndiscountedRate { get => _undiscountedRate; set => _undiscountedRate = value; }
        private DirtyValue<int?> _unimprovedAppraisedValue;
        /// <summary>
        /// Construction Management - Basic Info - Unimproved Appraised Value [4090]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management - Basic Info - Unimproved Appraised Value")]
        public int? UnimprovedAppraisedValue { get => _unimprovedAppraisedValue; set => _unimprovedAppraisedValue = value; }
        private DirtyValue<int?> _unimprovedEstimatedValue;
        /// <summary>
        /// Construction Management - Basic Info - Unimproved Estimated Value [4089]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management - Basic Info - Unimproved Estimated Value")]
        public int? UnimprovedEstimatedValue { get => _unimprovedEstimatedValue; set => _unimprovedEstimatedValue = value; }
        private DirtyValue<string> _urlPage4Comments;
        /// <summary>
        /// 1003 Page 4 Comments [1003p4]
        /// </summary>
        [LoanFieldProperty(Description = "1003 Page 4 Comments")]
        public string UrlPage4Comments { get => _urlPage4Comments; set => _urlPage4Comments = value; }
        private Usda _usda;
        /// <summary>
        /// Loan Usda
        /// </summary>
        public Usda Usda { get => _usda ?? (_usda = new Usda()); set => _usda = value; }
        private DirtyValue<StringEnumValue<UsdaGovernmentLoanType>> _usdaGovernmentLoanType;
        /// <summary>
        /// USDA-RHS Government Loan Type [Terms.USDAGovtType]
        /// </summary>
        [LoanFieldProperty(Description = "USDA-RHS Government Loan Type")]
        public StringEnumValue<UsdaGovernmentLoanType> UsdaGovernmentLoanType { get => _usdaGovernmentLoanType; set => _usdaGovernmentLoanType = value; }
        private DirtyValue<bool?> _use2018DiIndicator;
        /// <summary>
        /// Use 2018 DI [4142]
        /// </summary>
        [LoanFieldProperty(Description = "Use 2018 DI", OptionsJson = "{\"true\":\"Use 2018 DI\"}")]
        public bool? Use2018DiIndicator { get => _use2018DiIndicator; set => _use2018DiIndicator = value; }
        private DirtyValue<StringEnumValue<UseNew2015FormsIndicator>> _useNew2015FormsIndicator;
        /// <summary>
        /// Use New LE, CD, GFE And HUD [3969]
        /// </summary>
        [LoanFieldProperty(Description = "Use New LE, CD, GFE And HUD")]
        public StringEnumValue<UseNew2015FormsIndicator> UseNew2015FormsIndicator { get => _useNew2015FormsIndicator; set => _useNew2015FormsIndicator = value; }
        private DirtyValue<bool?> _useNewHudIndicator;
        /// <summary>
        /// Use New GFE And HUD [NEWHUD.X354]
        /// </summary>
        [LoanFieldProperty(Description = "Use New GFE And HUD")]
        public bool? UseNewHudIndicator { get => _useNewHudIndicator; set => _useNewHudIndicator = value; }
        private DirtyValue<decimal?> _vAEntitlementAmount;
        /// <summary>
        /// VA Loan Summ Entitlement Amt [VASUMM.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Entitlement Amt")]
        public decimal? VAEntitlementAmount { get => _vAEntitlementAmount; set => _vAEntitlementAmount = value; }
        private VaLoanData _vaLoanData;
        /// <summary>
        /// Loan VaLoanData
        /// </summary>
        public VaLoanData VaLoanData { get => _vaLoanData ?? (_vaLoanData = new VaLoanData()); set => _vaLoanData = value; }
        private DirtyList<VerificationLog> _verificationLogs;
        /// <summary>
        /// Loan VerificationLogs
        /// </summary>
        public IList<VerificationLog> VerificationLogs { get => _verificationLogs ?? (_verificationLogs = new DirtyList<VerificationLog>()); set => _verificationLogs = new DirtyList<VerificationLog>(value); }
        private DirtyDictionary<string, string> _virtualFields;
        /// <summary>
        /// Loan VirtualFields
        /// </summary>
        public IDictionary<string, string> VirtualFields { get => _virtualFields ?? (_virtualFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _virtualFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }
        private DirtyValue<string> _websiteId;
        /// <summary>
        /// Website ID [WEBSITEID]
        /// </summary>
        [LoanFieldProperty(Description = "Website ID")]
        public string WebsiteId { get => _websiteId; set => _websiteId = value; }
    }
}