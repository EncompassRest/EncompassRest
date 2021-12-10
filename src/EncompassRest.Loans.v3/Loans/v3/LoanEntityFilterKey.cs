using System.Runtime.Serialization;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanEntityFilterKey
/// </summary>
public enum LoanEntityFilterKey
{
    /// <summary>
    /// additionalLoans
    /// </summary>
    [EnumMember(Value = "additionalLoans")]
    AdditionalLoans = 0,
    /// <summary>
    /// additionalRequests
    /// </summary>
    [EnumMember(Value = "additionalRequests")]
    AdditionalRequests = 1,
    /// <summary>
    /// additionalStateDisclosures
    /// </summary>
    [EnumMember(Value = "additionalStateDisclosures")]
    AdditionalStateDisclosures = 2,
    /// <summary>
    /// affiliatedBusinessArrangements
    /// </summary>
    [EnumMember(Value = "affiliatedBusinessArrangements")]
    AffiliatedBusinessArrangements = 3,
    /// <summary>
    /// aiq
    /// </summary>
    [EnumMember(Value = "aiq")]
    Aiq = 4,
    /// <summary>
    /// alertChangeCircumstances
    /// </summary>
    [EnumMember(Value = "alertChangeCircumstances")]
    AlertChangeCircumstances = 5,
    /// <summary>
    /// antiSteeringLoanOptions
    /// </summary>
    [EnumMember(Value = "antiSteeringLoanOptions")]
    AntiSteeringLoanOptions = 6,
    /// <summary>
    /// assets
    /// </summary>
    [EnumMember(Value = "assets")]
    Assets = 7,
    /// <summary>
    /// atrqmBorrower
    /// </summary>
    [EnumMember(Value = "atrqmBorrower")]
    AtrqmBorrower = 8,
    /// <summary>
    /// atrqmCommon
    /// </summary>
    [EnumMember(Value = "atrqmCommon")]
    AtrqmCommon = 9,
    /// <summary>
    /// ausTracking
    /// </summary>
    [EnumMember(Value = "ausTracking")]
    AusTracking = 10,
    /// <summary>
    /// borrower
    /// </summary>
    [EnumMember(Value = "borrower")]
    Borrower = 11,
    /// <summary>
    /// buydowns
    /// </summary>
    [EnumMember(Value = "buydowns")]
    Buydowns = 12,
    /// <summary>
    /// buySideAdjustments
    /// </summary>
    [EnumMember(Value = "buySideAdjustments")]
    BuySideAdjustments = 13,
    /// <summary>
    /// closingCost
    /// </summary>
    [EnumMember(Value = "closingCost")]
    ClosingCost = 14,
    /// <summary>
    /// closingDisclosure1
    /// </summary>
    [EnumMember(Value = "closingDisclosure1")]
    ClosingDisclosure1 = 15,
    /// <summary>
    /// closingDisclosure2
    /// </summary>
    [EnumMember(Value = "closingDisclosure2")]
    ClosingDisclosure2 = 16,
    /// <summary>
    /// closingDisclosure3
    /// </summary>
    [EnumMember(Value = "closingDisclosure3")]
    ClosingDisclosure3 = 17,
    /// <summary>
    /// closingDisclosure4
    /// </summary>
    [EnumMember(Value = "closingDisclosure4")]
    ClosingDisclosure4 = 18,
    /// <summary>
    /// closingDisclosure5
    /// </summary>
    [EnumMember(Value = "closingDisclosure5")]
    ClosingDisclosure5 = 19,
    /// <summary>
    /// closingDocument
    /// </summary>
    [EnumMember(Value = "closingDocument")]
    ClosingDocument = 20,
    /// <summary>
    /// closingEntities
    /// </summary>
    [EnumMember(Value = "closingEntities")]
    ClosingEntities = 21,
    /// <summary>
    /// coborrower
    /// </summary>
    [EnumMember(Value = "coborrower")]
    Coborrower = 22,
    /// <summary>
    /// collateralTracking
    /// </summary>
    [EnumMember(Value = "collateralTracking")]
    CollateralTracking = 23,
    /// <summary>
    /// commitmentTerms
    /// </summary>
    [EnumMember(Value = "commitmentTerms")]
    CommitmentTerms = 24,
    /// <summary>
    /// compSideAdjustments
    /// </summary>
    [EnumMember(Value = "compSideAdjustments")]
    CompSideAdjustments = 25,
    /// <summary>
    /// constructionManagement
    /// </summary>
    [EnumMember(Value = "constructionManagement")]
    ConstructionManagement = 26,
    /// <summary>
    /// contacts
    /// </summary>
    [EnumMember(Value = "contacts")]
    Contacts = 27,
    /// <summary>
    /// correspondent
    /// </summary>
    [EnumMember(Value = "correspondent")]
    Correspondent = 28,
    /// <summary>
    /// corrOtherInsurances
    /// </summary>
    [EnumMember(Value = "corrOtherInsurances")]
    CorrOtherInsurances = 29,
    /// <summary>
    /// creditReports
    /// </summary>
    [EnumMember(Value = "creditReports")]
    CreditReports = 30,
    /// <summary>
    /// currentAdjustments
    /// </summary>
    [EnumMember(Value = "currentAdjustments")]
    CurrentAdjustments = 31,
    /// <summary>
    /// currentApplication
    /// </summary>
    [EnumMember(Value = "currentApplication")]
    CurrentApplication = 32,
    /// <summary>
    /// customFields
    /// </summary>
    [EnumMember(Value = "customFields")]
    CustomFields = 33,
    /// <summary>
    /// disclosureNotices
    /// </summary>
    [EnumMember(Value = "disclosureNotices")]
    DisclosureNotices = 34,
    /// <summary>
    /// disclosures
    /// </summary>
    [EnumMember(Value = "disclosures")]
    Disclosures = 35,
    /// <summary>
    /// downPayment
    /// </summary>
    [EnumMember(Value = "downPayment")]
    DownPayment = 36,
    /// <summary>
    /// earlyChecks
    /// </summary>
    [EnumMember(Value = "earlyChecks")]
    EarlyChecks = 37,
    /// <summary>
    /// emDocument
    /// </summary>
    [EnumMember(Value = "emDocument")]
    EmDocument = 38,
    /// <summary>
    /// emDocumentInvestor
    /// </summary>
    [EnumMember(Value = "emDocumentInvestor")]
    EmDocumentInvestor = 39,
    /// <summary>
    /// emDocumentLender
    /// </summary>
    [EnumMember(Value = "emDocumentLender")]
    EmDocumentLender = 40,
    /// <summary>
    /// employment
    /// </summary>
    [EnumMember(Value = "employment")]
    Employment = 41,
    /// <summary>
    /// energyEfficientMortgage
    /// </summary>
    [EnumMember(Value = "energyEfficientMortgage")]
    EnergyEfficientMortgage = 42,
    /// <summary>
    /// energyEfficientMortgageItems
    /// </summary>
    [EnumMember(Value = "energyEfficientMortgageItems")]
    EnergyEfficientMortgageItems = 43,
    /// <summary>
    /// extraPayments
    /// </summary>
    [EnumMember(Value = "extraPayments")]
    ExtraPayments = 44,
    /// <summary>
    /// fannieMae
    /// </summary>
    [EnumMember(Value = "fannieMae")]
    FannieMae = 45,
    /// <summary>
    /// fees
    /// </summary>
    [EnumMember(Value = "fees")]
    Fees = 46,
    /// <summary>
    /// feeVarianceOther
    /// </summary>
    [EnumMember(Value = "feeVarianceOther")]
    FeeVarianceOther = 47,
    /// <summary>
    /// feeVariances
    /// </summary>
    [EnumMember(Value = "feeVariances")]
    FeeVariances = 48,
    /// <summary>
    /// fhaVaLoan
    /// </summary>
    [EnumMember(Value = "fhaVaLoan")]
    FhaVaLoan = 49,
    /// <summary>
    /// freddieMac
    /// </summary>
    [EnumMember(Value = "freddieMac")]
    FreddieMac = 50,
    /// <summary>
    /// funding
    /// </summary>
    [EnumMember(Value = "funding")]
    Funding = 51,
    /// <summary>
    /// gfe
    /// </summary>
    [EnumMember(Value = "gfe")]
    Gfe = 52,
    /// <summary>
    /// gfe2010
    /// </summary>
    [EnumMember(Value = "gfe2010")]
    Gfe2010 = 53,
    /// <summary>
    /// gfe2010Fees
    /// </summary>
    [EnumMember(Value = "gfe2010Fees")]
    Gfe2010Fees = 54,
    /// <summary>
    /// gfe2010FwbcFwscs
    /// </summary>
    [EnumMember(Value = "gfe2010FwbcFwscs")]
    Gfe2010FwbcFwscs = 55,
    /// <summary>
    /// gfe2010GfeCharges
    /// </summary>
    [EnumMember(Value = "gfe2010GfeCharges")]
    Gfe2010GfeCharges = 56,
    /// <summary>
    /// gfe2010Page
    /// </summary>
    [EnumMember(Value = "gfe2010Page")]
    Gfe2010Page = 57,
    /// <summary>
    /// gfe2010Section
    /// </summary>
    [EnumMember(Value = "gfe2010Section")]
    Gfe2010Section = 58,
    /// <summary>
    /// gfe2010WholePocs
    /// </summary>
    [EnumMember(Value = "gfe2010WholePocs")]
    Gfe2010WholePocs = 59,
    /// <summary>
    /// gfeFees
    /// </summary>
    [EnumMember(Value = "gfeFees")]
    GfeFees = 60,
    /// <summary>
    /// gfeLiens
    /// </summary>
    [EnumMember(Value = "gfeLiens")]
    GfeLiens = 61,
    /// <summary>
    /// gfePayments
    /// </summary>
    [EnumMember(Value = "gfePayments")]
    GfePayments = 62,
    /// <summary>
    /// gfePayoffs
    /// </summary>
    [EnumMember(Value = "gfePayoffs")]
    GfePayoffs = 63,
    /// <summary>
    /// giftsGrants
    /// </summary>
    [EnumMember(Value = "giftsGrants")]
    GiftsGrants = 64,
    /// <summary>
    /// gseTrackers
    /// </summary>
    [EnumMember(Value = "gseTrackers")]
    GseTrackers = 65,
    /// <summary>
    /// helocHistoricalIndexYearSettings
    /// </summary>
    [EnumMember(Value = "helocHistoricalIndexYearSettings")]
    HelocHistoricalIndexYearSettings = 66,
    /// <summary>
    /// helocRepaymentDrawPeriods
    /// </summary>
    [EnumMember(Value = "helocRepaymentDrawPeriods")]
    HelocRepaymentDrawPeriods = 67,
    /// <summary>
    /// hmda
    /// </summary>
    [EnumMember(Value = "hmda")]
    Hmda = 68,
    /// <summary>
    /// homeCounselingProviders
    /// </summary>
    [EnumMember(Value = "homeCounselingProviders")]
    HomeCounselingProviders = 69,
    /// <summary>
    /// hud1Es
    /// </summary>
    [EnumMember(Value = "hud1Es")]
    Hud1Es = 70,
    /// <summary>
    /// hud1EsDates
    /// </summary>
    [EnumMember(Value = "hud1EsDates")]
    Hud1EsDates = 71,
    /// <summary>
    /// hud1EsDueDates
    /// </summary>
    [EnumMember(Value = "hud1EsDueDates")]
    Hud1EsDueDates = 72,
    /// <summary>
    /// hud1EsItemizes
    /// </summary>
    [EnumMember(Value = "hud1EsItemizes")]
    Hud1EsItemizes = 73,
    /// <summary>
    /// hud1EsPayTos
    /// </summary>
    [EnumMember(Value = "hud1EsPayTos")]
    Hud1EsPayTos = 74,
    /// <summary>
    /// hud1EsSetups
    /// </summary>
    [EnumMember(Value = "hud1EsSetups")]
    Hud1EsSetups = 75,
    /// <summary>
    /// hudLoanData
    /// </summary>
    [EnumMember(Value = "hudLoanData")]
    HudLoanData = 76,
    /// <summary>
    /// income
    /// </summary>
    [EnumMember(Value = "income")]
    Income = 77,
    /// <summary>
    /// interimServicing
    /// </summary>
    [EnumMember(Value = "interimServicing")]
    InterimServicing = 78,
    /// <summary>
    /// investorDeliveryLogs
    /// </summary>
    [EnumMember(Value = "investorDeliveryLogs")]
    InvestorDeliveryLogs = 79,
    /// <summary>
    /// liabilities
    /// </summary>
    [EnumMember(Value = "liabilities")]
    Liabilities = 80,
    /// <summary>
    /// loan
    /// </summary>
    [EnumMember(Value = "loan")]
    Loan = 81,
    /// <summary>
    /// loanEstimate1
    /// </summary>
    [EnumMember(Value = "loanEstimate1")]
    LoanEstimate1 = 82,
    /// <summary>
    /// loanEstimate2
    /// </summary>
    [EnumMember(Value = "loanEstimate2")]
    LoanEstimate2 = 83,
    /// <summary>
    /// loanEstimate3
    /// </summary>
    [EnumMember(Value = "loanEstimate3")]
    LoanEstimate3 = 84,
    /// <summary>
    /// loanProductData
    /// </summary>
    [EnumMember(Value = "loanProductData")]
    LoanProductData = 85,
    /// <summary>
    /// loanPrograms
    /// </summary>
    [EnumMember(Value = "loanPrograms")]
    LoanPrograms = 86,
    /// <summary>
    /// loanSubmission
    /// </summary>
    [EnumMember(Value = "loanSubmission")]
    LoanSubmission = 87,
    /// <summary>
    /// loanSubmissionFees
    /// </summary>
    [EnumMember(Value = "loanSubmissionFees")]
    LoanSubmissionFees = 88,
    /// <summary>
    /// lockRequestAdjustments
    /// </summary>
    [EnumMember(Value = "lockRequestAdjustments")]
    LockRequestAdjustments = 89,
    /// <summary>
    /// lockRequestBorrowers
    /// </summary>
    [EnumMember(Value = "lockRequestBorrowers")]
    LockRequestBorrowers = 90,
    /// <summary>
    /// loCompensation
    /// </summary>
    [EnumMember(Value = "loCompensation")]
    LoCompensation = 91,
    /// <summary>
    /// mailingAddress
    /// </summary>
    [EnumMember(Value = "mailingAddress")]
    MailingAddress = 92,
    /// <summary>
    /// mcaw
    /// </summary>
    [EnumMember(Value = "mcaw")]
    Mcaw = 93,
    /// <summary>
    /// milestoneTemplateLogs
    /// </summary>
    [EnumMember(Value = "milestoneTemplateLogs")]
    MilestoneTemplateLogs = 94,
    /// <summary>
    /// militaryServices
    /// </summary>
    [EnumMember(Value = "militaryServices")]
    MilitaryServices = 95,
    /// <summary>
    /// miscellaneous
    /// </summary>
    [EnumMember(Value = "miscellaneous")]
    Miscellaneous = 96,
    /// <summary>
    /// netTangibleBenefit
    /// </summary>
    [EnumMember(Value = "netTangibleBenefit")]
    NetTangibleBenefit = 97,
    /// <summary>
    /// newYorkFees
    /// </summary>
    [EnumMember(Value = "newYorkFees")]
    NewYorkFees = 98,
    /// <summary>
    /// newYorkPrimaryLenders
    /// </summary>
    [EnumMember(Value = "newYorkPrimaryLenders")]
    NewYorkPrimaryLenders = 99,
    /// <summary>
    /// nonBorrowingOwners
    /// </summary>
    [EnumMember(Value = "nonBorrowingOwners")]
    NonBorrowingOwners = 100,
    /// <summary>
    /// nonVols
    /// </summary>
    [EnumMember(Value = "nonVols")]
    NonVols = 101,
    /// <summary>
    /// otherAssets
    /// </summary>
    [EnumMember(Value = "otherAssets")]
    OtherAssets = 102,
    /// <summary>
    /// otherIncomeSources
    /// </summary>
    [EnumMember(Value = "otherIncomeSources")]
    OtherIncomeSources = 103,
    /// <summary>
    /// otherLiabilities
    /// </summary>
    [EnumMember(Value = "otherLiabilities")]
    OtherLiabilities = 104,
    /// <summary>
    /// prepaymentPenalties
    /// </summary>
    [EnumMember(Value = "prepaymentPenalties")]
    PrepaymentPenalties = 105,
    /// <summary>
    /// prequalification
    /// </summary>
    [EnumMember(Value = "prequalification")]
    Prequalification = 106,
    /// <summary>
    /// prequalificationScenarios
    /// </summary>
    [EnumMember(Value = "prequalificationScenarios")]
    PrequalificationScenarios = 107,
    /// <summary>
    /// previousVaLoans
    /// </summary>
    [EnumMember(Value = "previousVaLoans")]
    PreviousVaLoans = 108,
    /// <summary>
    /// privacyPolicy
    /// </summary>
    [EnumMember(Value = "privacyPolicy")]
    PrivacyPolicy = 109,
    /// <summary>
    /// profitManagement
    /// </summary>
    [EnumMember(Value = "profitManagement")]
    ProfitManagement = 110,
    /// <summary>
    /// profitManagementItems
    /// </summary>
    [EnumMember(Value = "profitManagementItems")]
    ProfitManagementItems = 111,
    /// <summary>
    /// property
    /// </summary>
    [EnumMember(Value = "property")]
    Property = 112,
    /// <summary>
    /// propertyValuations
    /// </summary>
    [EnumMember(Value = "propertyValuations")]
    PropertyValuations = 113,
    /// <summary>
    /// providedDocuments
    /// </summary>
    [EnumMember(Value = "providedDocuments")]
    ProvidedDocuments = 114,
    /// <summary>
    /// purchaseAdvicePayouts
    /// </summary>
    [EnumMember(Value = "purchaseAdvicePayouts")]
    PurchaseAdvicePayouts = 115,
    /// <summary>
    /// purchaseCredits
    /// </summary>
    [EnumMember(Value = "purchaseCredits")]
    PurchaseCredits = 116,
    /// <summary>
    /// rateLock
    /// </summary>
    [EnumMember(Value = "rateLock")]
    RateLock = 117,
    /// <summary>
    /// rateLockBuydowns
    /// </summary>
    [EnumMember(Value = "rateLockBuydowns")]
    RateLockBuydowns = 118,
    /// <summary>
    /// regulationZ
    /// </summary>
    [EnumMember(Value = "regulationZ")]
    RegulationZ = 119,
    /// <summary>
    /// regulationZInterestRatePeriods
    /// </summary>
    [EnumMember(Value = "regulationZInterestRatePeriods")]
    RegulationZInterestRatePeriods = 120,
    /// <summary>
    /// regulationZPayments
    /// </summary>
    [EnumMember(Value = "regulationZPayments")]
    RegulationZPayments = 121,
    /// <summary>
    /// reoProperties
    /// </summary>
    [EnumMember(Value = "reoProperties")]
    ReoProperties = 122,
    /// <summary>
    /// residences
    /// </summary>
    [EnumMember(Value = "residences")]
    Residences = 123,
    /// <summary>
    /// respaHudDetails
    /// </summary>
    [EnumMember(Value = "respaHudDetails")]
    RespaHudDetails = 124,
    /// <summary>
    /// riders
    /// </summary>
    [EnumMember(Value = "riders")]
    Riders = 125,
    /// <summary>
    /// scenarios
    /// </summary>
    [EnumMember(Value = "scenarios")]
    Scenarios = 126,
    /// <summary>
    /// secondaryFinancingProviders
    /// </summary>
    [EnumMember(Value = "secondaryFinancingProviders")]
    SecondaryFinancingProviders = 127,
    /// <summary>
    /// section32
    /// </summary>
    [EnumMember(Value = "section32")]
    Section32 = 128,
    /// <summary>
    /// selectedHomeCounselingProvider
    /// </summary>
    [EnumMember(Value = "selectedHomeCounselingProvider")]
    SelectedHomeCounselingProvider = 129,
    /// <summary>
    /// selfEmployedIncome
    /// </summary>
    [EnumMember(Value = "selfEmployedIncome")]
    SelfEmployedIncome = 130,
    /// <summary>
    /// sellSideAdjustments
    /// </summary>
    [EnumMember(Value = "sellSideAdjustments")]
    SellSideAdjustments = 131,
    /// <summary>
    /// serviceProviderContacts
    /// </summary>
    [EnumMember(Value = "serviceProviderContacts")]
    ServiceProviderContacts = 132,
    /// <summary>
    /// servicingDisclosure
    /// </summary>
    [EnumMember(Value = "servicingDisclosure")]
    ServicingDisclosure = 133,
    /// <summary>
    /// settlementServiceCharges
    /// </summary>
    [EnumMember(Value = "settlementServiceCharges")]
    SettlementServiceCharges = 134,
    /// <summary>
    /// shipping
    /// </summary>
    [EnumMember(Value = "shipping")]
    Shipping = 135,
    /// <summary>
    /// shippingContacts
    /// </summary>
    [EnumMember(Value = "shippingContacts")]
    ShippingContacts = 136,
    /// <summary>
    /// specialFeatureCodes
    /// </summary>
    [EnumMember(Value = "specialFeatureCodes")]
    SpecialFeatureCodes = 137,
    /// <summary>
    /// stateDisclosure
    /// </summary>
    [EnumMember(Value = "stateDisclosure")]
    StateDisclosure = 138,
    /// <summary>
    /// stateLicenses
    /// </summary>
    [EnumMember(Value = "stateLicenses")]
    StateLicenses = 139,
    /// <summary>
    /// statementCreditDenial
    /// </summary>
    [EnumMember(Value = "statementCreditDenial")]
    StatementCreditDenial = 140,
    /// <summary>
    /// tax4506
    /// </summary>
    [EnumMember(Value = "tax4506")]
    Tax4506 = 141,
    /// <summary>
    /// tax4506s
    /// </summary>
    [EnumMember(Value = "tax4506s")]
    Tax4506s = 142,
    /// <summary>
    /// tax4506T
    /// </summary>
    [EnumMember(Value = "tax4506T")]
    Tax4506T = 143,
    /// <summary>
    /// tax4506Ts
    /// </summary>
    [EnumMember(Value = "tax4506Ts")]
    Tax4506Ts = 144,
    /// <summary>
    /// tpo
    /// </summary>
    [EnumMember(Value = "tpo")]
    Tpo = 145,
    /// <summary>
    /// tql
    /// </summary>
    [EnumMember(Value = "tql")]
    Tql = 146,
    /// <summary>
    /// tqlComplianceAlerts
    /// </summary>
    [EnumMember(Value = "tqlComplianceAlerts")]
    TqlComplianceAlerts = 147,
    /// <summary>
    /// tqlDocuments
    /// </summary>
    [EnumMember(Value = "tqlDocuments")]
    TqlDocuments = 148,
    /// <summary>
    /// tqlFraudAlerts
    /// </summary>
    [EnumMember(Value = "tqlFraudAlerts")]
    TqlFraudAlerts = 149,
    /// <summary>
    /// tqlReports
    /// </summary>
    [EnumMember(Value = "tqlReports")]
    TqlReports = 150,
    /// <summary>
    /// trustAccount
    /// </summary>
    [EnumMember(Value = "trustAccount")]
    TrustAccount = 151,
    /// <summary>
    /// trustAccountItems
    /// </summary>
    [EnumMember(Value = "trustAccountItems")]
    TrustAccountItems = 152,
    /// <summary>
    /// tsum
    /// </summary>
    [EnumMember(Value = "tsum")]
    Tsum = 153,
    /// <summary>
    /// ucdDetails
    /// </summary>
    [EnumMember(Value = "ucdDetails")]
    UcdDetails = 154,
    /// <summary>
    /// uldd
    /// </summary>
    [EnumMember(Value = "uldd")]
    Uldd = 155,
    /// <summary>
    /// underwriterSummary
    /// </summary>
    [EnumMember(Value = "underwriterSummary")]
    UnderwriterSummary = 156,
    /// <summary>
    /// urlaAlternateNames
    /// </summary>
    [EnumMember(Value = "urlaAlternateNames")]
    UrlaAlternateNames = 157,
    /// <summary>
    /// usda
    /// </summary>
    [EnumMember(Value = "usda")]
    Usda = 158,
    /// <summary>
    /// usdaHouseholdIncomes
    /// </summary>
    [EnumMember(Value = "usdaHouseholdIncomes")]
    UsdaHouseholdIncomes = 159,
    /// <summary>
    /// vaLoanData
    /// </summary>
    [EnumMember(Value = "vaLoanData")]
    VaLoanData = 160,
    /// <summary>
    /// valuations
    /// </summary>
    [EnumMember(Value = "valuations")]
    Valuations = 161,
    /// <summary>
    /// vods
    /// </summary>
    [EnumMember(Value = "vods")]
    Vods = 162,
    /// <summary>
    /// vols
    /// </summary>
    [EnumMember(Value = "vols")]
    Vols = 163
}