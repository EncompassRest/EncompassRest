using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ToolsRights
    /// </summary>
    public sealed class ToolsRights : DirtyExtensibleObject
    {
        private PurchaseAdviceFormRights? _purchaseAdviceForm;
        private DirtyValue<bool?>? _shippingDetail;
        private DirtyValue<bool?>? _amortizationSchedule;
        private DirtyValue<bool?>? _antiSteeringSafeHarborDisclosure;
        private DirtyValue<bool?>? _auditTrail;
        private AUSTrackingRights? _aUSTracking;
        private DirtyValue<bool?>? _brokerCheckCalculation;
        private DirtyValue<bool?>? _businessContacts;
        private DirtyValue<bool?>? _cashtoClose;
        private CollateralTrackingRights? _collateralTracking;
        private DirtyValue<bool?>? _conversationLog;
        private DirtyValue<bool?>? _correspondentComplianceReviewData;
        private DirtyValue<bool?>? _correspondentLoanStatus;
        private DirtyValue<bool?>? _correspondentPurchaseAdviceForm;
        private DirtyValue<bool?>? _debtConsolidation;
        private DisclosureTrackingRights? _disclosureTracking;
        private DirtyValue<bool?>? _eCSDataViewer;
        private FeeVarianceWorksheetRights? _feeVarianceWorksheet;
        private FileContactsRights? _fileContacts;
        private DirtyValue<bool?>? _fundingBalancingWorksheet;
        private DirtyValue<bool?>? _fundingWorksheet;
        private DirtyValue<bool?>? _importFundingWorksheet;
        private InterimServicingRights? _interimServicing;
        private DirtyValue<bool?>? _loanComparison;
        private DirtyValue<bool?>? _lockRequestForm;
        private LOCompToolRights? _lOCompTool;
        private DirtyValue<bool?>? _netTangibleBenefit;
        private DirtyValue<bool?>? _piggybackLoans;
        private DirtyValue<bool?>? _prequalification;
        private DirtyValue<bool?>? _profitManagement;
        private DirtyValue<bool?>? _rentVsOwn;
        private RepAndWarrantTrackerRights? _repAndWarrantTracker;
        private DirtyValue<bool?>? _secondaryRegistration;
        private DirtyValue<bool?>? _secureFormTransfer;
        private TasksRights? _tasks;
        private TPOInformationRights? _tPOInformation;
        private TQLServicesRights? _tQLServices;
        private DirtyValue<bool?>? _trustAccount;
        private DirtyValue<bool?>? _underwriterSummary;
        private VerificationAndDocumentationTrackingRights? _verificationAndDocumentationTracking;

        /// <summary>
        /// ToolsRights PurchaseAdviceForm
        /// </summary>
        [JsonProperty(" PurchaseAdviceForm")]
        [AllowNull]
        public PurchaseAdviceFormRights PurchaseAdviceForm { get => GetField(ref _purchaseAdviceForm); set => SetField(ref _purchaseAdviceForm, value); }

        /// <summary>
        /// ToolsRights ShippingDetail
        /// </summary>
        [JsonProperty(" ShippingDetail")]
        public bool? ShippingDetail { get => _shippingDetail; set => SetField(ref _shippingDetail, value); }

        /// <summary>
        /// ToolsRights AmortizationSchedule
        /// </summary>
        public bool? AmortizationSchedule { get => _amortizationSchedule; set => SetField(ref _amortizationSchedule, value); }

        /// <summary>
        /// ToolsRights AntiSteeringSafeHarborDisclosure
        /// </summary>
        [JsonProperty("anti-SteeringSafeHarborDisclosure")]
        public bool? AntiSteeringSafeHarborDisclosure { get => _antiSteeringSafeHarborDisclosure; set => SetField(ref _antiSteeringSafeHarborDisclosure, value); }

        /// <summary>
        /// ToolsRights AuditTrail
        /// </summary>
        public bool? AuditTrail { get => _auditTrail; set => SetField(ref _auditTrail, value); }

        /// <summary>
        /// ToolsRights AUSTracking
        /// </summary>
        [AllowNull]
        public AUSTrackingRights AUSTracking { get => GetField(ref _aUSTracking); set => SetField(ref _aUSTracking, value); }

        /// <summary>
        /// ToolsRights BrokerCheckCalculation
        /// </summary>
        public bool? BrokerCheckCalculation { get => _brokerCheckCalculation; set => SetField(ref _brokerCheckCalculation, value); }

        /// <summary>
        /// ToolsRights BusinessContacts
        /// </summary>
        public bool? BusinessContacts { get => _businessContacts; set => SetField(ref _businessContacts, value); }

        /// <summary>
        /// ToolsRights CashtoClose
        /// </summary>
        [JsonProperty("cash-to-Close")]
        public bool? CashtoClose { get => _cashtoClose; set => SetField(ref _cashtoClose, value); }

        /// <summary>
        /// ToolsRights CollateralTracking
        /// </summary>
        [AllowNull]
        public CollateralTrackingRights CollateralTracking { get => GetField(ref _collateralTracking); set => SetField(ref _collateralTracking, value); }

        /// <summary>
        /// ToolsRights ConversationLog
        /// </summary>
        public bool? ConversationLog { get => _conversationLog; set => SetField(ref _conversationLog, value); }

        /// <summary>
        /// ToolsRights CorrespondentComplianceReviewData
        /// </summary>
        public bool? CorrespondentComplianceReviewData { get => _correspondentComplianceReviewData; set => SetField(ref _correspondentComplianceReviewData, value); }

        /// <summary>
        /// ToolsRights CorrespondentLoanStatus
        /// </summary>
        public bool? CorrespondentLoanStatus { get => _correspondentLoanStatus; set => SetField(ref _correspondentLoanStatus, value); }

        /// <summary>
        /// ToolsRights CorrespondentPurchaseAdviceForm
        /// </summary>
        public bool? CorrespondentPurchaseAdviceForm { get => _correspondentPurchaseAdviceForm; set => SetField(ref _correspondentPurchaseAdviceForm, value); }

        /// <summary>
        /// ToolsRights DebtConsolidation
        /// </summary>
        public bool? DebtConsolidation { get => _debtConsolidation; set => SetField(ref _debtConsolidation, value); }

        /// <summary>
        /// ToolsRights DisclosureTracking
        /// </summary>
        [AllowNull]
        public DisclosureTrackingRights DisclosureTracking { get => GetField(ref _disclosureTracking); set => SetField(ref _disclosureTracking, value); }

        /// <summary>
        /// ToolsRights ECSDataViewer
        /// </summary>
        public bool? ECSDataViewer { get => _eCSDataViewer; set => SetField(ref _eCSDataViewer, value); }

        /// <summary>
        /// ToolsRights FeeVarianceWorksheet
        /// </summary>
        [AllowNull]
        public FeeVarianceWorksheetRights FeeVarianceWorksheet { get => GetField(ref _feeVarianceWorksheet); set => SetField(ref _feeVarianceWorksheet, value); }

        /// <summary>
        /// ToolsRights FileContacts
        /// </summary>
        [AllowNull]
        public FileContactsRights FileContacts { get => GetField(ref _fileContacts); set => SetField(ref _fileContacts, value); }

        /// <summary>
        /// ToolsRights FundingBalancingWorksheet
        /// </summary>
        public bool? FundingBalancingWorksheet { get => _fundingBalancingWorksheet; set => SetField(ref _fundingBalancingWorksheet, value); }

        /// <summary>
        /// ToolsRights FundingWorksheet
        /// </summary>
        public bool? FundingWorksheet { get => _fundingWorksheet; set => SetField(ref _fundingWorksheet, value); }

        /// <summary>
        /// ToolsRights ImportFundingWorksheet
        /// </summary>
        public bool? ImportFundingWorksheet { get => _importFundingWorksheet; set => SetField(ref _importFundingWorksheet, value); }

        /// <summary>
        /// ToolsRights InterimServicing
        /// </summary>
        [AllowNull]
        public InterimServicingRights InterimServicing { get => GetField(ref _interimServicing); set => SetField(ref _interimServicing, value); }

        /// <summary>
        /// ToolsRights LoanComparison
        /// </summary>
        public bool? LoanComparison { get => _loanComparison; set => SetField(ref _loanComparison, value); }

        /// <summary>
        /// ToolsRights LockRequestForm
        /// </summary>
        public bool? LockRequestForm { get => _lockRequestForm; set => SetField(ref _lockRequestForm, value); }

        /// <summary>
        /// ToolsRights LOCompTool
        /// </summary>
        [AllowNull]
        public LOCompToolRights LOCompTool { get => GetField(ref _lOCompTool); set => SetField(ref _lOCompTool, value); }

        /// <summary>
        /// ToolsRights NetTangibleBenefit
        /// </summary>
        public bool? NetTangibleBenefit { get => _netTangibleBenefit; set => SetField(ref _netTangibleBenefit, value); }

        /// <summary>
        /// ToolsRights PiggybackLoans
        /// </summary>
        public bool? PiggybackLoans { get => _piggybackLoans; set => SetField(ref _piggybackLoans, value); }

        /// <summary>
        /// ToolsRights Prequalification
        /// </summary>
        public bool? Prequalification { get => _prequalification; set => SetField(ref _prequalification, value); }

        /// <summary>
        /// ToolsRights ProfitManagement
        /// </summary>
        public bool? ProfitManagement { get => _profitManagement; set => SetField(ref _profitManagement, value); }

        /// <summary>
        /// ToolsRights RentVsOwn
        /// </summary>
        [JsonProperty("rentVs.Own")]
        public bool? RentVsOwn { get => _rentVsOwn; set => SetField(ref _rentVsOwn, value); }

        /// <summary>
        /// ToolsRights RepAndWarrantTracker
        /// </summary>
        [AllowNull]
        public RepAndWarrantTrackerRights RepAndWarrantTracker { get => GetField(ref _repAndWarrantTracker); set => SetField(ref _repAndWarrantTracker, value); }

        /// <summary>
        /// ToolsRights SecondaryRegistration
        /// </summary>
        public bool? SecondaryRegistration { get => _secondaryRegistration; set => SetField(ref _secondaryRegistration, value); }

        /// <summary>
        /// ToolsRights SecureFormTransfer
        /// </summary>
        public bool? SecureFormTransfer { get => _secureFormTransfer; set => SetField(ref _secureFormTransfer, value); }

        /// <summary>
        /// ToolsRights Tasks
        /// </summary>
        [AllowNull]
        public TasksRights Tasks { get => GetField(ref _tasks); set => SetField(ref _tasks, value); }

        /// <summary>
        /// ToolsRights TPOInformation
        /// </summary>
        [AllowNull]
        public TPOInformationRights TPOInformation { get => GetField(ref _tPOInformation); set => SetField(ref _tPOInformation, value); }

        /// <summary>
        /// ToolsRights TQLServices
        /// </summary>
        [AllowNull]
        public TQLServicesRights TQLServices { get => GetField(ref _tQLServices); set => SetField(ref _tQLServices, value); }

        /// <summary>
        /// ToolsRights TrustAccount
        /// </summary>
        public bool? TrustAccount { get => _trustAccount; set => SetField(ref _trustAccount, value); }

        /// <summary>
        /// ToolsRights UnderwriterSummary
        /// </summary>
        public bool? UnderwriterSummary { get => _underwriterSummary; set => SetField(ref _underwriterSummary, value); }

        /// <summary>
        /// ToolsRights VerificationAndDocumentationTracking
        /// </summary>
        [AllowNull]
        public VerificationAndDocumentationTrackingRights VerificationAndDocumentationTracking { get => GetField(ref _verificationAndDocumentationTracking); set => SetField(ref _verificationAndDocumentationTracking, value); }
    }
}