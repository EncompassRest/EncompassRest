using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ToolsRights
    /// </summary>
    public sealed class ToolsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ToolsRights PurchaseAdviceForm
        /// </summary>
        [JsonProperty(" PurchaseAdviceForm")]
        [AllowNull]
        public PurchaseAdviceFormRights PurchaseAdviceForm { get => GetEntity<PurchaseAdviceFormRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights ShippingDetail
        /// </summary>
        [JsonProperty(" ShippingDetail")]
        public bool? ShippingDetail { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights AmortizationSchedule
        /// </summary>
        public bool? AmortizationSchedule { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights AntiSteeringSafeHarborDisclosure
        /// </summary>
        [JsonProperty("anti-SteeringSafeHarborDisclosure")]
        public bool? AntiSteeringSafeHarborDisclosure { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights AuditTrail
        /// </summary>
        public bool? AuditTrail { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights AUSTracking
        /// </summary>
        [AllowNull]
        public AUSTrackingRights AUSTracking { get => GetEntity<AUSTrackingRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights BrokerCheckCalculation
        /// </summary>
        public bool? BrokerCheckCalculation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights BusinessContacts
        /// </summary>
        public bool? BusinessContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights CashtoClose
        /// </summary>
        [JsonProperty("cash-to-Close")]
        public bool? CashtoClose { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights CollateralTracking
        /// </summary>
        [AllowNull]
        public CollateralTrackingRights CollateralTracking { get => GetEntity<CollateralTrackingRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights ConversationLog
        /// </summary>
        public bool? ConversationLog { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights CorrespondentComplianceReviewData
        /// </summary>
        public bool? CorrespondentComplianceReviewData { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights CorrespondentLoanStatus
        /// </summary>
        public bool? CorrespondentLoanStatus { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights CorrespondentPurchaseAdviceForm
        /// </summary>
        public bool? CorrespondentPurchaseAdviceForm { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights DebtConsolidation
        /// </summary>
        public bool? DebtConsolidation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights DisclosureTracking
        /// </summary>
        [AllowNull]
        public DisclosureTrackingRights DisclosureTracking { get => GetEntity<DisclosureTrackingRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights ECSDataViewer
        /// </summary>
        public bool? ECSDataViewer { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights FeeVarianceWorksheet
        /// </summary>
        [AllowNull]
        public FeeVarianceWorksheetRights FeeVarianceWorksheet { get => GetEntity<FeeVarianceWorksheetRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights FileContacts
        /// </summary>
        [AllowNull]
        public FileContactsRights FileContacts { get => GetEntity<FileContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights FundingBalancingWorksheet
        /// </summary>
        public bool? FundingBalancingWorksheet { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights FundingWorksheet
        /// </summary>
        public bool? FundingWorksheet { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights ImportFundingWorksheet
        /// </summary>
        public bool? ImportFundingWorksheet { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights InterimServicing
        /// </summary>
        [AllowNull]
        public InterimServicingRights InterimServicing { get => GetEntity<InterimServicingRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights LoanComparison
        /// </summary>
        public bool? LoanComparison { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights LockComparisonTool
        /// </summary>
        [JsonProperty("lockComparisionTool")]
        public bool? LockComparisonTool { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights LockRequestForm
        /// </summary>
        public bool? LockRequestForm { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights LOCompTool
        /// </summary>
        [AllowNull]
        public LOCompToolRights LOCompTool { get => GetEntity<LOCompToolRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights NetTangibleBenefit
        /// </summary>
        public bool? NetTangibleBenefit { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights PiggybackLoans
        /// </summary>
        public bool? PiggybackLoans { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights Prequalification
        /// </summary>
        public bool? Prequalification { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights ProfitManagement
        /// </summary>
        public bool? ProfitManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights RentVsOwn
        /// </summary>
        [JsonProperty("rentVs.Own")]
        public bool? RentVsOwn { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights RepAndWarrantTracker
        /// </summary>
        [AllowNull]
        public RepAndWarrantTrackerRights RepAndWarrantTracker { get => GetEntity<RepAndWarrantTrackerRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights SecondaryRegistration
        /// </summary>
        public bool? SecondaryRegistration { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights SecureFormTransfer
        /// </summary>
        public bool? SecureFormTransfer { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights Tasks
        /// </summary>
        [AllowNull]
        public TasksRights Tasks { get => GetEntity<TasksRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights TPOInformation
        /// </summary>
        [AllowNull]
        public TPOInformationRights TPOInformation { get => GetEntity<TPOInformationRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights TQLServices
        /// </summary>
        [AllowNull]
        public TQLServicesRights TQLServices { get => GetEntity<TQLServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// ToolsRights TrustAccount
        /// </summary>
        public bool? TrustAccount { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights UnderwriterSummary
        /// </summary>
        public bool? UnderwriterSummary { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ToolsRights VerificationAndDocumentationTracking
        /// </summary>
        [AllowNull]
        public VerificationAndDocumentationTrackingRights VerificationAndDocumentationTracking { get => GetEntity<VerificationAndDocumentationTrackingRights>(); set => SetEntity(value); }
    }
}