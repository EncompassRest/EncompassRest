using System.Runtime.Serialization;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanEntity
    /// </summary>
    public enum LoanEntity
    {
        /// <summary>
        /// AdditionalRequests
        /// </summary>
        AdditionalRequests = 1,
        /// <summary>
        /// AdditionalStateDisclosure
        /// </summary>
        AdditionalStateDisclosure = 2,
        /// <summary>
        /// AffiliatedBusinessArrangement
        /// </summary>
        AffiliatedBusinessArrangement = 3,
        /// <summary>
        /// AntiSteeringLoanOption
        /// </summary>
        AntiSteeringLoanOption = 4,
        /// <summary>
        /// Application
        /// </summary>
        Application = 5,
        /// <summary>
        /// Asset
        /// </summary>
        Asset = 6,
        /// <summary>
        /// AUSTrackingLog
        /// </summary>
        AUSTrackingLog = 7,
        /// <summary>
        /// ATRQMBorrower
        /// </summary>
        ATRQMBorrower = 8,
        /// <summary>
        /// ATRQMCommon
        /// </summary>
        ATRQMCommon = 9,
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 10,
        /// <summary>
        /// Buydown
        /// </summary>
        Buydown = 12,
        /// <summary>
        /// ClosingCost
        /// </summary>
        ClosingCost = 13,
        /// <summary>
        /// ClosingDisclosure1
        /// </summary>
        ClosingDisclosure1 = 14,
        /// <summary>
        /// ClosingDisclosure2
        /// </summary>
        ClosingDisclosure2 = 15,
        /// <summary>
        /// ClosingDisclosure3
        /// </summary>
        ClosingDisclosure3 = 16,
        /// <summary>
        /// ClosingDisclosure4
        /// </summary>
        ClosingDisclosure4 = 17,
        /// <summary>
        /// ClosingDisclosure5
        /// </summary>
        ClosingDisclosure5 = 18,
        /// <summary>
        /// ClosingDocument
        /// </summary>
        ClosingDocument = 19,
        /// <summary>
        /// ClosingEntity
        /// </summary>
        ClosingEntity = 20,
        /// <summary>
        /// CommitmentTerms
        /// </summary>
        CommitmentTerms = 21,
        /// <summary>
        /// ComplianceTestLog
        /// </summary>
        ComplianceTestLog = 22,
        /// <summary>
        /// Contact
        /// </summary>
        Contact = 23,
        /// <summary>
        /// ConstructionManagement
        /// </summary>
        ConstructionManagement = 24,
        /// <summary>
        /// ConversationLog
        /// </summary>
        ConversationLog = 25,
        /// <summary>
        /// Correspondent
        /// </summary>
        Correspondent = 26,
        /// <summary>
        /// CrmLog
        /// </summary>
        CrmLog = 27,
        /// <summary>
        /// CustomField
        /// </summary>
        CustomField = 28,
        /// <summary>
        /// DataTracLog
        /// </summary>
        DataTracLog = 29,
        /// <summary>
        /// DisclosureForm
        /// </summary>
        DisclosureForm = 30,
        /// <summary>
        /// DisclosureNotices
        /// </summary>
        DisclosureNotices = 31,
        /// <summary>
        /// DisclosureTracking2015Log
        /// </summary>
        DisclosureTracking2015Log = 32,
        /// <summary>
        /// DisclosureTrackingLog
        /// </summary>
        DisclosureTrackingLog = 33,
        /// <summary>
        /// DocumentLog
        /// </summary>
        DocumentLog = 34,
        /// <summary>
        /// DownloadLog
        /// </summary>
        DownloadLog = 35,
        /// <summary>
        /// DownPayment
        /// </summary>
        DownPayment = 36,
        /// <summary>
        /// EdmDocument
        /// </summary>
        EdmDocument = 37,
        /// <summary>
        /// EdmLog
        /// </summary>
        EdmLog = 38,
        /// <summary>
        /// ElliLOCompensation
        /// </summary>
        ElliLOCompensation = 39,
        /// <summary>
        /// EmailTriggerLog
        /// </summary>
        EmailTriggerLog = 40,
        /// <summary>
        /// EmDocumentInvestor
        /// </summary>
        EmDocumentInvestor = 41,
        /// <summary>
        /// EmDocumentLender
        /// </summary>
        EmDocumentLender = 42,
        /// <summary>
        /// EmDocument
        /// </summary>
        EmDocument = 43,
        /// <summary>
        /// Employment
        /// </summary>
        Employment = 44,
        /// <summary>
        /// EnergyEfficientMortgageItem
        /// </summary>
        EnergyEfficientMortgageItem = 45,
        /// <summary>
        /// EnergyEfficientMortgage
        /// </summary>
        EnergyEfficientMortgage = 46,
        /// <summary>
        /// EscrowDisbursementTransaction
        /// </summary>
        EscrowDisbursementTransaction = 47,
        /// <summary>
        /// EscrowInterestTransaction
        /// </summary>
        EscrowInterestTransaction = 48,
        /// <summary>
        /// FannieMae
        /// </summary>
        FannieMae = 49,
        /// <summary>
        /// Fee
        /// </summary>
        Fee = 50,
        /// <summary>
        /// FeeVariance
        /// </summary>
        FeeVariance = 51,
        /// <summary>
        /// FeeVarianceOther
        /// </summary>
        FeeVarianceOther = 52,
        /// <summary>
        /// FhaVaLoan
        /// </summary>
        FhaVaLoan = 53,
        /// <summary>
        /// Form
        /// </summary>
        Form = 54,
        /// <summary>
        /// FreddieMac
        /// </summary>
        FreddieMac = 55,
        /// <summary>
        /// Funding
        /// </summary>
        Funding = 56,
        /// <summary>
        /// Gfe2010Fee
        /// </summary>
        Gfe2010Fee = 57,
        /// <summary>
        /// Gfe2010FwbcFwsc
        /// </summary>
        Gfe2010FwbcFwsc = 58,
        /// <summary>
        /// Gfe2010GfeCharge
        /// </summary>
        Gfe2010GfeCharge = 59,
        /// <summary>
        /// Gfe2010
        /// </summary>
        Gfe2010 = 60,
        /// <summary>
        /// Gfe2010Page
        /// </summary>
        Gfe2010Page = 61,
        /// <summary>
        /// Gfe2010Section
        /// </summary>
        Gfe2010Section = 62,
        /// <summary>
        /// Gfe2010WholePoc
        /// </summary>
        Gfe2010WholePoc = 63,
        /// <summary>
        /// GfeFee
        /// </summary>
        GfeFee = 64,
        /// <summary>
        /// GfeLien
        /// </summary>
        GfeLien = 65,
        /// <summary>
        /// Gfe
        /// </summary>
        Gfe = 66,
        /// <summary>
        /// GfePayment
        /// </summary>
        GfePayment = 67,
        /// <summary>
        /// GfePayoff
        /// </summary>
        GfePayoff = 68,
        /// <summary>
        /// HelocRepaymentDrawPeriod
        /// </summary>
        HelocRepaymentDrawPeriod = 69,
        /// <summary>
        /// Hmda
        /// </summary>
        Hmda = 70,
        /// <summary>
        /// HomeCounselingProvider
        /// </summary>
        HomeCounselingProvider = 71,
        /// <summary>
        /// HtmlEmailLog
        /// </summary>
        HtmlEmailLog = 72,
        /// <summary>
        /// Hud1EsDate
        /// </summary>
        Hud1EsDate = 73,
        /// <summary>
        /// Hud1EsDueDate
        /// </summary>
        Hud1EsDueDate = 74,
        /// <summary>
        /// Hud1EsItemize
        /// </summary>
        Hud1EsItemize = 75,
        /// <summary>
        /// Hud1Es
        /// </summary>
        Hud1Es = 76,
        /// <summary>
        /// Hud1EsPayTo
        /// </summary>
        Hud1EsPayTo = 77,
        /// <summary>
        /// Hud1EsSetup
        /// </summary>
        Hud1EsSetup = 78,
        /// <summary>
        /// HudLoanData
        /// </summary>
        HudLoanData = 79,
        /// <summary>
        /// Income
        /// </summary>
        Income = 80,
        /// <summary>
        /// InterimServicing
        /// </summary>
        InterimServicing = 81,
        /// <summary>
        /// InterimServicingTransaction
        /// </summary>
        InterimServicingTransaction = 82,
        /// <summary>
        /// Liability
        /// </summary>
        Liability = 83,
        /// <summary>
        /// Loan
        /// </summary>
        Loan = 84,
        /// <summary>
        /// LoanAssociate
        /// </summary>
        LoanAssociate = 85,
        /// <summary>
        /// LoanEstimate1
        /// </summary>
        LoanEstimate1 = 86,
        /// <summary>
        /// LoanEstimate2
        /// </summary>
        LoanEstimate2 = 87,
        /// <summary>
        /// LoanEstimate3
        /// </summary>
        LoanEstimate3 = 88,
        /// <summary>
        /// LoanProductData
        /// </summary>
        LoanProductData = 89,
        /// <summary>
        /// LoanProgram
        /// </summary>
        LoanProgram = 90,
        /// <summary>
        /// LoanSubmissionFee
        /// </summary>
        LoanSubmissionFee = 91,
        /// <summary>
        /// LoanSubmission
        /// </summary>
        LoanSubmission = 92,
        /// <summary>
        /// LockCancellationLog
        /// </summary>
        LockCancellationLog = 93,
        /// <summary>
        /// LockConfirmLog
        /// </summary>
        LockConfirmLog = 94,
        /// <summary>
        /// LockDenialLog
        /// </summary>
        LockDenialLog = 95,
        /// <summary>
        /// LockRequestBorrower
        /// </summary>
        LockRequestBorrower = 96,
        /// <summary>
        /// LockRequestLog
        /// </summary>
        LockRequestLog = 97,
        /// <summary>
        /// LogAlert
        /// </summary>
        LogAlert = 99,
        /// <summary>
        /// LogComment
        /// </summary>
        LogComment = 100,
        /// <summary>
        /// LogEntryLog
        /// </summary>
        LogEntryLog = 101,
        /// <summary>
        /// LogRecord
        /// </summary>
        LogRecord = 102,
        /// <summary>
        /// LogSnapshotField
        /// </summary>
        LogSnapshotField = 103,
        /// <summary>
        /// Mcaw
        /// </summary>
        Mcaw = 104,
        /// <summary>
        /// MilestoneFreeRoleLog
        /// </summary>
        MilestoneFreeRoleLog = 105,
        /// <summary>
        /// MilestoneLog
        /// </summary>
        MilestoneLog = 106,
        /// <summary>
        /// MilestoneTaskContact
        /// </summary>
        MilestoneTaskContact = 107,
        /// <summary>
        /// MilestoneTaskLog
        /// </summary>
        MilestoneTaskLog = 108,
        /// <summary>
        /// MilestoneTemplateLog
        /// </summary>
        MilestoneTemplateLog = 109,
        /// <summary>
        /// MilitaryService
        /// </summary>
        MilitaryService = 110,
        /// <summary>
        /// Miscellaneous
        /// </summary>
        Miscellaneous = 111,
        /// <summary>
        /// NetTangibleBenefit
        /// </summary>
        NetTangibleBenefit = 112,
        /// <summary>
        /// NewYorkFee
        /// </summary>
        NewYorkFee = 113,
        /// <summary>
        /// NewYorkPrimaryLender
        /// </summary>
        NewYorkPrimaryLender = 114,
        /// <summary>
        /// OtherTransaction
        /// </summary>
        OtherTransaction = 115,
        /// <summary>
        /// PaymentReversalTransaction
        /// </summary>
        PaymentReversalTransaction = 116,
        /// <summary>
        /// PaymentTransaction
        /// </summary>
        PaymentTransaction = 117,
        /// <summary>
        /// PostClosingConditionLog
        /// </summary>
        PostClosingConditionLog = 118,
        /// <summary>
        /// PreliminaryConditionLog
        /// </summary>
        PreliminaryConditionLog = 119,
        /// <summary>
        /// PrepaymentPenalty
        /// </summary>
        PrepaymentPenalty = 120,
        /// <summary>
        /// Prequalification
        /// </summary>
        Prequalification = 121,
        /// <summary>
        /// PrequalificationScenario
        /// </summary>
        PrequalificationScenario = 122,
        /// <summary>
        /// PreviousVaLoan
        /// </summary>
        PreviousVaLoan = 123,
        /// <summary>
        /// PriceAdjustment
        /// </summary>
        PriceAdjustment = 124,
        /// <summary>
        /// PrintForm
        /// </summary>
        PrintForm = 125,
        /// <summary>
        /// PrintLog
        /// </summary>
        PrintLog = 126,
        /// <summary>
        /// PrivacyPolicy
        /// </summary>
        PrivacyPolicy = 127,
        /// <summary>
        /// ProfitManagementItem
        /// </summary>
        ProfitManagementItem = 128,
        /// <summary>
        /// ProfitManagement
        /// </summary>
        ProfitManagement = 129,
        /// <summary>
        /// Property
        /// </summary>
        Property = 130,
        /// <summary>
        /// PurchaseAdvicePayout
        /// </summary>
        PurchaseAdvicePayout = 131,
        /// <summary>
        /// PurchaseCredit
        /// </summary>
        PurchaseCredit = 132,
        /// <summary>
        /// RateLock
        /// </summary>
        RateLock = 133,
        /// <summary>
        /// RegistrationLog
        /// </summary>
        RegistrationLog = 134,
        /// <summary>
        /// RegulationZInterestRatePeriod
        /// </summary>
        RegulationZInterestRatePeriod = 135,
        /// <summary>
        /// RegulationZ
        /// </summary>
        RegulationZ = 136,
        /// <summary>
        /// RegulationZPayment
        /// </summary>
        RegulationZPayment = 137,
        /// <summary>
        /// ReoProperty
        /// </summary>
        ReoProperty = 138,
        /// <summary>
        /// Residence
        /// </summary>
        Residence = 139,
        /// <summary>
        /// RespaHudDetail
        /// </summary>
        RespaHudDetail = 140,
        /// <summary>
        /// SchedulePaymentTransaction
        /// </summary>
        SchedulePaymentTransaction = 141,
        /// <summary>
        /// SecondaryFinancingProvider
        /// </summary>
        SecondaryFinancingProvider = 142,
        /// <summary>
        /// Section32
        /// </summary>
        Section32 = 143,
        /// <summary>
        /// SelectedHomeCounselingProvider
        /// </summary>
        SelectedHomeCounselingProvider = 144,
        /// <summary>
        /// SelfEmployedIncome
        /// </summary>
        SelfEmployedIncome = 145,
        /// <summary>
        /// ServiceProviderContact
        /// </summary>
        ServiceProviderContact = 146,
        /// <summary>
        /// ServicingDisclosure
        /// </summary>
        ServicingDisclosure = 147,
        /// <summary>
        /// SettlementServiceCharge
        /// </summary>
        SettlementServiceCharge = 148,
        /// <summary>
        /// ShippingContact
        /// </summary>
        ShippingContact = 149,
        /// <summary>
        /// Shipping
        /// </summary>
        Shipping = 150,
        /// <summary>
        /// StateDisclosure
        /// </summary>
        StateDisclosure = 151,
        /// <summary>
        /// StateLicense
        /// </summary>
        StateLicense = 152,
        /// <summary>
        /// StatementCreditDenial
        /// </summary>
        StatementCreditDenial = 153,
        /// <summary>
        /// StatusOnlineEvent
        /// </summary>
        StatusOnlineEvent = 154,
        /// <summary>
        /// StatusOnlineLog
        /// </summary>
        StatusOnlineLog = 155,
        /// <summary>
        /// Tax4506
        /// </summary>
        Tax4506 = 156,
        /// <summary>
        /// TPO
        /// </summary>
        TPO = 157,
        /// <summary>
        /// TQLComplianceAlert
        /// </summary>
        TQLComplianceAlert = 158,
        /// <summary>
        /// TQLDocument
        /// </summary>
        TQLDocument = 159,
        /// <summary>
        /// TQLFraudAlert
        /// </summary>
        TQLFraudAlert = 160,
        /// <summary>
        /// TQL
        /// </summary>
        TQL = 161,
        /// <summary>
        /// TQLReportInformation
        /// </summary>
        TQLReportInformation = 162,
        /// <summary>
        /// TrustAccountItem
        /// </summary>
        TrustAccountItem = 163,
        /// <summary>
        /// TrustAccount
        /// </summary>
        TrustAccount = 164,
        /// <summary>
        /// Tsum
        /// </summary>
        Tsum = 165,
        /// <summary>
        /// UCDDetail
        /// </summary>
        UCDDetail = 166,
        /// <summary>
        /// Uldd
        /// </summary>
        Uldd = 167,
        /// <summary>
        /// UnderwriterSummary
        /// </summary>
        UnderwriterSummary = 168,
        /// <summary>
        /// UnderwritingConditionLog
        /// </summary>
        UnderwritingConditionLog = 169,
        /// <summary>
        /// UsdaHouseholdIncome
        /// </summary>
        UsdaHouseholdIncome = 170,
        /// <summary>
        /// Usda
        /// </summary>
        Usda = 171,
        /// <summary>
        /// VaLoanData
        /// </summary>
        VaLoanData = 172,
        /// <summary>
        /// VerificationLog
        /// </summary>
        VerificationLog = 173,
        /// <summary>
        /// LoanActionLog
        /// </summary>
        LoanActionLog = 174,
        /// <summary>
        /// FieldLockData
        /// </summary>
        FieldLockData = 175,
        /// <summary>
        /// FundingFee
        /// </summary>
        FundingFee = 176,
        /// <summary>
        /// RemovedLogRecord
        /// </summary>
        RemovedLogRecord = 177,
        /// <summary>
        /// PrincipalDisbursementTransaction
        /// </summary>
        PrincipalDisbursementTransaction = 178,
        /// <summary>
        /// VirtualFields
        /// </summary>
        VirtualFields = 179,
        /// <summary>
        /// CustomModelFields
        /// </summary>
        CustomModelFields = 180,
        /// <summary>
        /// NonVol
        /// </summary>
        [EnumMember(Value = "NonVols")]
        NonVol = 181,
        /// <summary>
        /// ElliUCDDetail
        /// </summary>
        [EnumMember(Value = "ElliUCDFields")]
        ElliUCDDetail = 182,
        /// <summary>
        /// ExtraPayment
        /// </summary>
        ExtraPayment = 183,
        /// <summary>
        /// DocumentOrderLog
        /// </summary>
        DocumentOrderLog = 184,
        /// <summary>
        /// DocumentAudit
        /// </summary>
        DocumentAudit = 185,
        /// <summary>
        /// DocumentTrackingLog
        /// </summary>
        DocumentTrackingLog = 186,
        /// <summary>
        /// LoanPurchaseTransaction
        /// </summary>
        LoanPurchaseTransaction = 187,
        /// <summary>
        /// FannieServiceEcLog
        /// </summary>
        FannieServiceEcLog = 188,
        /// <summary>
        /// FannieServiceDuLog
        /// </summary>
        FannieServiceDuLog = 189,
        /// <summary>
        /// FreddieServiceLpaLog
        /// </summary>
        FreddieServiceLpaLog = 190,
        /// <summary>
        /// FreddieServiceLqaLog
        /// </summary>
        FreddieServiceLqaLog = 191,
        /// <summary>
        /// NonBorrowingOwner
        /// </summary>
        NonBorrowingOwner = 192,
        /// <summary>
        /// AlertChangeCircumstance
        /// </summary>
        AlertChangeCircumstance = 193,
        /// <summary>
        /// CollateralTracking
        /// </summary>
        CollateralTracking = 194,
        /// <summary>
        /// ExportLog
        /// </summary>
        ExportLog = 195,
        /// <summary>
        /// ExportLogServiceType
        /// </summary>
        ExportLogServiceType = 196,
        /// <summary>
        /// MIServiceArchLog
        /// </summary>
        MIServiceArchLog = 197,
        /// <summary>
        /// MIServiceMgicLog
        /// </summary>
        MIServiceMgicLog = 198,
        /// <summary>
        /// MIServiceRadianLog
        /// </summary>
        MIServiceRadianLog = 199,
        /// <summary>
        /// GSETracker
        /// </summary>
        GSETracker = 200,
        /// <summary>
        /// OtherAsset
        /// </summary>
        OtherAsset = 201,
        /// <summary>
        /// OtherLiability
        /// </summary>
        OtherLiability = 202,
        /// <summary>
        /// GiftGrant
        /// </summary>
        GiftGrant = 203,
        /// <summary>
        /// OtherIncomeSource
        /// </summary>
        OtherIncomeSource = 204,
        /// <summary>
        /// URLAAlternateName
        /// </summary>
        URLAAlternateName = 205,
        /// <summary>
        /// LockRemovedLog
        /// </summary>
        LockRemovedLog = 206,
        /// <summary>
        /// GoodFaithFeeVarianceCureLog
        /// </summary>
        GoodFaithFeeVarianceCureLog = 207,
        /// <summary>
        /// MilestoneHistoryLog
        /// </summary>
        MilestoneHistoryLog = 208,
        /// <summary>
        /// ServicingPrintLog
        /// </summary>
        ServicingPrintLog = 209,
        /// <summary>
        /// ServicingPrintLogFieldList
        /// </summary>
        ServicingPrintLogFieldList = 210,
        /// <summary>
        /// PurchaseConditionLog
        /// </summary>
        PurchaseConditionLog = 211,
        /// <summary>
        /// AdditionalLoan
        /// </summary>
        AdditionalLoan = 212,
        /// <summary>
        /// HelocHistoricalIndexYearSetting
        /// </summary>
        HelocHistoricalIndexYearSetting = 213,
        /// <summary>
        /// RateLockBuydown
        /// </summary>
        RateLockBuydown = 214,
        /// <summary>
        /// TargetTradeLog
        /// </summary>
        TargetTradeLog = 215,
        /// <summary>
        /// PriceAdjustmentLogRecord
        /// </summary>
        PriceAdjustmentLogRecord = 216,
        /// <summary>
        /// Valuation
        /// </summary>
        Valuation = 217,
        /// <summary>
        /// EarlyCheck
        /// </summary>
        EarlyCheck = 218,
        /// <summary>
        /// Rider
        /// </summary>
        Rider = 219,
        /// <summary>
        /// PropertyValuation
        /// </summary>
        PropertyValuation = 220,
        /// <summary>
        /// SellConditionLog
        /// </summary>
        SellConditionLog = 221,
        /// <summary>
        /// Scenario
        /// </summary>
        Scenario = 222,
        /// <summary>
        /// SpecialFeatureCode
        /// </summary>
        SpecialFeatureCode = 223,
        /// <summary>
        /// EnhancedConditionLog
        /// </summary>
        EnhancedConditionLog = 224,
        /// <summary>
        /// EnhancedConditionDefinition
        /// </summary>
        EnhancedConditionDefinition = 225,
        /// <summary>
        /// OptionDefinition
        /// </summary>
        OptionDefinition = 226,
        /// <summary>
        /// TrackingDefinition
        /// </summary>
        TrackingDefinition = 227,
        /// <summary>
        /// TrackingEntryLog
        /// </summary>
        TrackingEntryLog = 228,
        /// <summary>
        /// Disclosure
        /// </summary>
        Disclosure = 229,
        /// <summary>
        /// CreditReport
        /// </summary>
        CreditReport = 230,
        /// <summary>
        /// ProvidedDocument
        /// </summary>
        ProvidedDocument = 231
    }
}