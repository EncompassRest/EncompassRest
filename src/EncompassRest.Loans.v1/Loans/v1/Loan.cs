using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Loan
/// </summary>
public sealed partial class Loan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// 4b. Other New Mortgage Loans on the Property You are Buying or Refinancing Does not Apply [URLA.X237]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
    public bool? AdditionalLoanDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan AdditionalRequests
    /// </summary>
    [AllowNull]
    public AdditionalRequests AdditionalRequests { get => GetEntity<AdditionalRequests>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Current Status Date [749]
    /// </summary>
    public DateTime? AdverseActionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan AffiliatedBusinessArrangements
    /// </summary>
    [AllowNull]
    public IList<AffiliatedBusinessArrangement> AffiliatedBusinessArrangements { get => GetList<AffiliatedBusinessArrangement>(); set => SetList(value); }

    /// <summary>
    /// Affordable Loan Indicator [URLA.X210]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan \"}")]
    public bool? AffordableLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Agency Case # [1040]
    /// </summary>
    public string? AgencyCaseIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Aiq
    /// </summary>
    [AllowNull]
    public Aiq Aiq { get => GetEntity<Aiq>(); set => SetEntity(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Apply to LEorCD [4462]
    /// </summary>
    public string? AlertChangeCircumstanceApplyLECD { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan AlertChangeCircumstances
    /// </summary>
    [AllowNull]
    public IList<AlertChangeCircumstance> AlertChangeCircumstances { get => GetList<AlertChangeCircumstance>(); set => SetList(value); }

    /// <summary>
    /// Loan AllowPrint2003Application
    /// </summary>
    public bool? AllowPrint2003Application { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Alterations [967]
    /// </summary>
    public decimal? AlterationsImprovementsOrRepairsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Applications
    /// </summary>
    [AllowNull]
    public IList<Application> Applications { get => GetList<Application>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Application Taken By [479]
    /// </summary>
    public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => GetValue<StringEnumValue<ApplicationTakenMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Date APR Disclosed [363]
    /// </summary>
    public DateTime? AprDisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Descr [248]
    /// </summary>
    public string? ArmTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ATRQMCommon
    /// </summary>
    [AllowNull]
    public ATRQMCommon ATRQMCommon { get => GetEntity<ATRQMCommon>(); set => SetEntity(value); }

    /// <summary>
    /// Average Representative Credit Score [4752]
    /// </summary>
    public int? AverageRepresentativeCreditScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Loan Amt (w/ MIP/FF) [2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Seller Prov Below Mkt Financing [MORNET.X12]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Seller Provided Below Market Financing\"}")]
    public bool? BelowMarketSubordinateFinancingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Billing Category [BILLINGCATEGORY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BillingCategory { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Biweekly Payment [3034]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BiweeklyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Base LTV Ratio Percent [4012]
    /// </summary>
    public int? BLTV { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// BORROWER Community Property State Resident Indicator [URLA.X129]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"At least one borrower lives in a community property state.\"}")]
    public bool? BorrCommunityPropertyStateResidentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Estimated Closing Costs Amount [URLA.X146]
    /// </summary>
    public decimal? BorrEstimatedClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr/Co-Borr Married Indicator [100]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Borrower / Co-Borrower are Married\"}")]
    public bool? BorrowerCoBorrowerMarriedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower count  [URLA.X194]
    /// </summary>
    public string? BorrowerCount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Full Name [URLA.X158]
    /// </summary>
    public string? BorrowerFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Borr [BORPCC]
    /// </summary>
    public decimal? BorrowerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Loan Discount Fee Borr [1093]
    /// </summary>
    public decimal? BorrowerPaidDiscountPointsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total FHA Closing Costs Borr [1132]
    /// </summary>
    public decimal? BorrowerPaidFHAVAClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Number of Borrower Pairs [4460]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BorrowerPairCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Amt [1109]
    /// </summary>
    public decimal? BorrowerRequestedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Requested Loan Amount [URLA.X70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerRequestedLoanAmountURLA { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Broker [BKRPCC]
    /// </summary>
    public decimal? BrokerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Buydown [425]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Buydown\"}")]
    public bool? BuydownIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Monthly Buydown Payment [BUYDOWNPAYMENT]
    /// </summary>
    public decimal? BuydownMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Buydown Rate [964]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuydownRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Calculated Draw Amount [4525]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CalculatedDrawAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Calculated Loan Amount [4526]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CalculatedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Cash From Borr [142]
    /// </summary>
    public decimal? CashFromToBorrowerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Channel [2626]
    /// </summary>
    public StringEnumValue<Channel> Channel { get => GetValue<StringEnumValue<Channel>>(); set => SetValue(value); }

    /// <summary>
    /// Closed End Primary Mortgage Loan Amount [4487]
    /// </summary>
    public decimal? ClosedEndPrimaryMortgageLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closed End Subordinate Mortgage Loan Amount [4488]
    /// </summary>
    public decimal? ClosedEndSubordinateMortgageLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Date for Billing Purposes [3260]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ClosingBillingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ClosingCost
    /// </summary>
    [AllowNull]
    public ClosingCost ClosingCost { get => GetEntity<ClosingCost>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Closing Cost Program [1785]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details CC From Second [1851]
    /// </summary>
    public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details CC Paid By Broker/Lender/Other [1852]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ClosingCostsPaidByOthersAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Document Stacking Order [Closing.DocStkOrdr]
    /// </summary>
    public string? ClosingDocsStackingOrder { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ClosingDocument
    /// </summary>
    [AllowNull]
    public ClosingDocument ClosingDocument { get => GetEntity<ClosingDocument>(); set => SetEntity(value); }

    /// <summary>
    /// Collateral Manager Score # [3356]
    /// </summary>
    public int? CollateralManagerScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan CollateralTracking
    /// </summary>
    [AllowNull]
    public CollateralTracking CollateralTracking { get => GetEntity<CollateralTracking>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Comb Loan to Value (CLTV) [976]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CombinedLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Commitment Number [3907]
    /// </summary>
    public string? CommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan CommitmentTerms
    /// </summary>
    [AllowNull]
    public CommitmentTerms CommitmentTerms { get => GetEntity<CommitmentTerms>(); set => SetEntity(value); }

    /// <summary>
    /// Community Property State Resident Indicator [URLA.X130]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The property is in a community property state.\"}")]
    public bool? CommunityPropertyStateResidentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Compliance Review Type [4721]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Correspondent Compliance Review\",\"N\":\"Retail Compliance Review\"}")]
    public bool? ComplianceReviewType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ComplianceTestLogs
    /// </summary>
    [AllowNull]
    public IList<ComplianceTestLog> ComplianceTestLogs { get => GetList<ComplianceTestLog>(); set => SetList(value); }

    /// <summary>
    /// Condominium Project Type Indicator [URLA.X205]
    /// </summary>
    public bool? CondominiumIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Conforming Loan Indicator [3331]
    /// </summary>
    public StringEnumValue<ConformingJumbo> ConformingJumbo { get => GetValue<StringEnumValue<ConformingJumbo>>(); set => SetValue(value); }

    /// <summary>
    /// Construction Loan Indicator [URLA.X133]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Construction-Conversion/Construction-to-Permanent\"}")]
    public bool? ConstructionLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ConstructionManagement
    /// </summary>
    [AllowNull]
    public ConstructionManagement ConstructionManagement { get => GetEntity<ConstructionManagement>(); set => SetEntity(value); }

    /// <summary>
    /// Construction To Permanent Closing Type [URLA.X134]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"OneClosing\":\"Single Closing\"}")]
    public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => GetValue<StringEnumValue<ConstructionToPermanentClosingType>>(); set => SetValue(value); }

    /// <summary>
    /// Consumer Connect SiteID [ConsumerConnectSiteID]
    /// </summary>
    public string? ConsumerConnectSiteID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Consumer Eligible to Order Home Insurance [ConsumerHIOrderEligible]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? ConsumerHomeInsuranceOrderEligible { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Contacts
    /// </summary>
    [AllowNull]
    public IList<Contact> Contacts { get => GetList<Contact>(); set => SetList(value); }

    /// <summary>
    /// Loan Info Contact Update [2821]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? ContactUpdatedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Contract Seller Credit Amount [NEWHUD2.X23]
    /// </summary>
    public decimal? ContractSellerCreditAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ConversationLogs
    /// </summary>
    [AllowNull]
    public IList<ConversationLog> ConversationLogs { get => GetList<ConversationLog>(); set => SetList(value); }

    /// <summary>
    /// Conversion Of Contract For Deed Indicator [URLA.X131]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Conversion of Contract for Deed or Land Contract\"}")]
    public bool? ConversionOfContractForDeedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cooperative Project Type Indicator [URLA.X206]
    /// </summary>
    public bool? CooperativeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Copy to Lender Check Box [1969]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copy to Lender\"}")]
    public bool? CopyBrokerToLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Copy Loan # to Case # [1481]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Copy Loan Number to lender case number\",\"N\":\"\"}")]
    public StringEnumValue<YOrN> CopyLoanNumLenderCaseNum { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Correspondent
    /// </summary>
    [AllowNull]
    public Correspondent Correspondent { get => GetEntity<Correspondent>(); set => SetEntity(value); }

    /// <summary>
    /// Counseling Borrower Full Name [URLA.X164]
    /// </summary>
    public string? CounselingBorrowerFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Counseling Completed Date [URLA.X163]
    /// </summary>
    public DateTime? CounselingCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Credit Score for Decision Making [2853]
    /// </summary>
    public string? CreditScoreToUse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan CrmLogs
    /// </summary>
    [AllowNull]
    public IList<CrmLog> CrmLogs { get => GetList<CrmLog>(); set => SetList(value); }

    /// <summary>
    /// Loan CurrentApplicationIndex
    /// </summary>
    public int? CurrentApplicationIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan CurrentApplicationIsPrimary
    /// </summary>
    public bool? CurrentApplicationIsPrimary { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details First Mtg Owner [991]
    /// </summary>
    public StringEnumValue<CurrentFirstMortgageHolderType> CurrentFirstMortgageHolderType { get => GetValue<StringEnumValue<CurrentFirstMortgageHolderType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan CustomFields
    /// </summary>
    [AllowNull]
    public IList<CustomField> CustomFields { get => GetList<CustomField>(); set => SetList(value); }

    /// <summary>
    /// Loan CustomModelFields
    /// </summary>
    public CustomModelFields? CustomModelFields { get => GetValue<CustomModelFields?>(); set => SetValue(value); }

    /// <summary>
    /// Loan DataTracLogs
    /// </summary>
    [AllowNull]
    public IList<DataTracLog> DataTracLogs { get => GetList<DataTracLog>(); set => SetList(value); }

    /// <summary>
    /// Loan DBIndicator
    /// </summary>
    public bool? DBIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Deduct Overwire Amt From Broker Check [2833]
    /// </summary>
    public bool? DeductOverwireAmountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disable eConsent Alert [4072]
    /// </summary>
    public bool? DisableESignConsentAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disable Key Pricing Alert [4062]
    /// </summary>
    public bool? DisableKeyPricingAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan DisclosureNotices
    /// </summary>
    [AllowNull]
    public DisclosureNotices DisclosureNotices { get => GetEntity<DisclosureNotices>(); set => SetEntity(value); }

    /// <summary>
    /// Loan DisclosureTracking2015Logs
    /// </summary>
    [AllowNull]
    public IList<DisclosureTracking2015Log> DisclosureTracking2015Logs { get => GetList<DisclosureTracking2015Log>(); set => SetList(value); }

    /// <summary>
    /// Loan DisclosureTrackingLogs
    /// </summary>
    [AllowNull]
    public IList<DisclosureTrackingLog> DisclosureTrackingLogs { get => GetList<DisclosureTrackingLog>(); set => SetList(value); }

    /// <summary>
    /// Trans Detail Discount Point [1010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Ellie Mae Document Engine Version [Docs.Engine]
    /// </summary>
    public StringEnumValue<DocEngine> DocEngine { get => GetValue<StringEnumValue<DocEngine>>(); set => SetValue(value); }

    /// <summary>
    /// Loan DocumentLogs
    /// </summary>
    [AllowNull]
    public IList<DocumentLog> DocumentLogs { get => GetList<DocumentLog>(); set => SetList(value); }

    /// <summary>
    /// Loan DocumentOrderLogs
    /// </summary>
    [AllowNull]
    public IList<DocumentOrderLog> DocumentOrderLogs { get => GetList<DocumentOrderLog>(); set => SetList(value); }

    /// <summary>
    /// Loan DocumentTrackingLogs
    /// </summary>
    [AllowNull]
    public IList<DocumentTrackingLog> DocumentTrackingLogs { get => GetList<DocumentTrackingLog>(); set => SetList(value); }

    /// <summary>
    /// Do Not Check Email When Loan File Is Saved [3040]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DoNotCheckEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Do not print line 824 and 825 Check Box [1970]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Do not print line 824 and 825\"}")]
    public bool? DoNotPrintCompensationFees { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan DownloadLogs
    /// </summary>
    [AllowNull]
    public IList<DownloadLog> DownloadLogs { get => GetList<DownloadLog>(); set => SetList(value); }

    /// <summary>
    /// Loan DownPayment
    /// </summary>
    [AllowNull]
    public DownPayment DownPayment { get => GetEntity<DownPayment>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Down Pmt % [1771]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DownPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// eDelivery - Version [EDELIVERY.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? EDeliveryVersion { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan EdmLogs
    /// </summary>
    [AllowNull]
    public IList<EdmLog> EdmLogs { get => GetList<EdmLog>(); set => SetList(value); }

    /// <summary>
    /// Loan ElliUCDFields
    /// </summary>
    public ElliUCDDetail? ElliUCDFields { get => GetValue<ElliUCDDetail?>(); set => SetValue(value); }

    /// <summary>
    /// Loan EmailTriggerLogs
    /// </summary>
    [AllowNull]
    public IList<EmailTriggerLog> EmailTriggerLogs { get => GetList<EmailTriggerLog>(); set => SetList(value); }

    /// <summary>
    /// Loan EmDocument
    /// </summary>
    [AllowNull]
    public EmDocument EmDocument { get => GetEntity<EmDocument>(); set => SetEntity(value); }

    /// <summary>
    /// Loan EmDocumentInvestor
    /// </summary>
    [AllowNull]
    public EmDocumentInvestor EmDocumentInvestor { get => GetEntity<EmDocumentInvestor>(); set => SetEntity(value); }

    /// <summary>
    /// Loan EmDocumentLender
    /// </summary>
    [AllowNull]
    public EmDocumentLender EmDocumentLender { get => GetEntity<EmDocumentLender>(); set => SetEntity(value); }

    /// <summary>
    /// Loan EmXmlVersionId [1000]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EmXmlVersionId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Loan ID [GUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EncompassId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Encompass Version [SYS.X611]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EncompassVersion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Energy Improvement Amount [4785]
    /// </summary>
    public decimal? EnergyImprovementAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Enforce County Loan Limit [3894]
    /// </summary>
    public bool? EnforceCountyLoanLimit { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan EnhancedConditionLogs
    /// </summary>
    [AllowNull]
    public IList<EnhancedConditionLog> EnhancedConditionLogs { get => GetList<EnhancedConditionLog>(); set => SetList(value); }

    /// <summary>
    /// eNote Authoritative Copy [4728]
    /// </summary>
    public bool? EnoteAuthoritativeCopy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Controller Org Id [4729]
    /// </summary>
    public string? EnoteControllerOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Controller Org Name [4730]
    /// </summary>
    public string? EnoteControllerOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Delagatee for Transfer Org Id [4741]
    /// </summary>
    public string? EnoteDelagateeForTransferOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Delagatee for Transfer Org Name [4742]
    /// </summary>
    public string? EnoteDelagateeForTransferOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Lender Name [4725]
    /// </summary>
    public string? EnoteLenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Location Org Id [4731]
    /// </summary>
    public string? EnoteLocationOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Location Org Name [4732]
    /// </summary>
    public string? EnoteLocationOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Master Servicer Org Id [4733]
    /// </summary>
    public string? EnoteMasterServiceOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Master Servicer Org Name [4734]
    /// </summary>
    public string? EnoteMasterServiceOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote MERS MIN Number [4726]
    /// </summary>
    public string? EnoteMersMinNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Registered DateTime [4727]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EnoteRegisteredDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Secured Party Delagatee Org Id [4739]
    /// </summary>
    public string? EnoteSecuredPartyDelagateeOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Secured Party Delagatee Org Name [4740]
    /// </summary>
    public string? EnoteSecuredPartyDelagateeOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Secured Party Org Id [4737]
    /// </summary>
    public string? EnoteSecuredPartyOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Secured Party Org Name [4738]
    /// </summary>
    public string? EnoteSecuredPartyOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Subservicer Org Id [4735]
    /// </summary>
    public string? EnoteSubservicerOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Subservicer Org Name [4736]
    /// </summary>
    public string? EnoteSubservicerOrgName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Transfer Effective Date [4743]
    /// </summary>
    public DateTime? EnoteTransferEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eNote Transfer Status [4744]
    /// </summary>
    public StringEnumValue<EnoteTransferStatus> EnoteTransferStatus { get => GetValue<StringEnumValue<EnoteTransferStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Est Closing Costs [137]
    /// </summary>
    public decimal? EstimatedClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Estimated Construction Interest [4088]
    /// </summary>
    public decimal? EstimatedConstructionInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Est Prepaids [138]
    /// </summary>
    public decimal? EstimatedPrepaidItemsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Existing Liens And Draw Used [4521]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLiensAndDrawUsed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Existing Liens Used [4522]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLiensUsed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expected Borrower Count [URLA.X261]
    /// </summary>
    public int? ExpectedBorrowerCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Export Investor or Lender Loan Number [2573]
    /// </summary>
    public StringEnumValue<ExportLoanNumber> ExportLoanNumber { get => GetValue<StringEnumValue<ExportLoanNumber>>(); set => SetValue(value); }

    /// <summary>
    /// Loan ExportLogs
    /// </summary>
    [AllowNull]
    public IList<ExportLog> ExportLogs { get => GetList<ExportLog>(); set => SetList(value); }

    /// <summary>
    /// Loan FannieMae
    /// </summary>
    [AllowNull]
    public FannieMae FannieMae { get => GetEntity<FannieMae>(); set => SetEntity(value); }

    /// <summary>
    /// Loan FannieServiceDuLogs
    /// </summary>
    [AllowNull]
    public IList<FannieServiceDuLog> FannieServiceDuLogs { get => GetList<FannieServiceDuLog>(); set => SetList(value); }

    /// <summary>
    /// Loan FannieServiceEcLogs
    /// </summary>
    [AllowNull]
    public IList<FannieServiceEcLog> FannieServiceEcLogs { get => GetList<FannieServiceEcLog>(); set => SetList(value); }

    /// <summary>
    /// Loan Fees
    /// </summary>
    [AllowNull]
    public IList<Fee> Fees { get => GetList<Fee>(); set => SetList(value); }

    /// <summary>
    /// FHA MIP Refund Amt [1134]
    /// </summary>
    public decimal? FhaMiPremiumRefundAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan FhaVaLoan
    /// </summary>
    [AllowNull]
    public FhaVaLoan FhaVaLoan { get => GetEntity<FhaVaLoan>(); set => SetEntity(value); }

    /// <summary>
    /// Loan FHAVALoanOriginatorIdentifier
    /// </summary>
    public string? FHAVALoanOriginatorIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan FieldLockData
    /// </summary>
    [AllowNull]
    public IList<FieldLockData> FieldLockData { get => GetList<FieldLockData>(); set => SetList(value); }

    /// <summary>
    /// First Adjustment Minimum Value [3557]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FirstAdjustmentMinimum { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Sub Fin First Mtg Loan Amt [427]
    /// </summary>
    public decimal? FirstSubordinateLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr First Time Homebuyer [934]
    /// </summary>
    public bool? FirstTimeHomebuyersIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Community Lending Product [MORNET.X27]
    /// </summary>
    public StringEnumValue<FnmCommunityLendingProductName> FnmCommunityLendingProductName { get => GetValue<StringEnumValue<FnmCommunityLendingProductName>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Community Seconds [MORNET.X29]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Seconds\"}")]
    public bool? FnmCommunitySecondsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae FannieNeighbors Elig [MORNET.X28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"FannieNeighbors Eligible\"}")]
    public bool? FnmNeighborsMortgageEligibilityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Forms
    /// </summary>
    [AllowNull]
    public IList<Form> Forms { get => GetList<Form>(); set => SetList(value); }

    /// <summary>
    /// Fraud Score # [3340]
    /// </summary>
    public int? FraudScore { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan FreddieMac
    /// </summary>
    [AllowNull]
    public FreddieMac FreddieMac { get => GetEntity<FreddieMac>(); set => SetEntity(value); }

    /// <summary>
    /// Loan FreddieServiceLpaLogs
    /// </summary>
    [AllowNull]
    public IList<FreddieServiceLpaLog> FreddieServiceLpaLogs { get => GetList<FreddieServiceLpaLog>(); set => SetList(value); }

    /// <summary>
    /// Loan FreddieServiceLqaLogs
    /// </summary>
    [AllowNull]
    public IList<FreddieServiceLqaLog> FreddieServiceLqaLogs { get => GetList<FreddieServiceLqaLog>(); set => SetList(value); }

    /// <summary>
    /// Loan Funding
    /// </summary>
    [AllowNull]
    public Funding Funding { get => GetEntity<Funding>(); set => SetEntity(value); }

    /// <summary>
    /// Funding Worksheet Deduction Items [2971]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FundingDeductionList { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Worksheet Fee List [2972]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FundingFeeList { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan FundingFees
    /// </summary>
    [AllowNull]
    public IList<FundingFee> FundingFees { get => GetList<FundingFee>(); set => SetList(value); }

    /// <summary>
    /// Loan Gfe
    /// </summary>
    [AllowNull]
    public Gfe Gfe { get => GetEntity<Gfe>(); set => SetEntity(value); }

    /// <summary>
    /// Loan GoodFaithFeeVarianceCureLogs
    /// </summary>
    [AllowNull]
    public IList<GoodFaithFeeVarianceCureLog> GoodFaithFeeVarianceCureLogs { get => GetList<GoodFaithFeeVarianceCureLog>(); set => SetList(value); }

    /// <summary>
    /// Loan GovernmentLoanLenderIdentifier
    /// </summary>
    public string? GovernmentLoanLenderIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan GovernmentLoanSponsorIdentifier
    /// </summary>
    public string? GovernmentLoanSponsorIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Mortgage Credit [MORNET.X33]
    /// </summary>
    public decimal? GovernmentMortgageCreditCertificateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Government Refinance Type [URLA.X166]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"FullDocumentation\":\"Full Documentation (FNMA/FRE)\",\"InterestRateReductionRefinanceLoan\":\"Interest Rate Reduction Refinance Loan (FNMA/FRE)\",\"Other\":\"Other (FNMA Retired/FRE)\",\"StreamlineWithAppraisal\":\"Streamline With Appraisal (FNMA)\",\"StreamlineWithoutAppraisal\":\"Streamline Without Appraisal (FNMA/FRE)\"}")]
    public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => GetValue<StringEnumValue<GovernmentRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// Government Refinance Type Other Description [URLA.X167]
    /// </summary>
    public StringEnumValue<GovernmentRefinanceTypeOtherDescription> GovernmentRefinanceTypeOtherDescription { get => GetValue<StringEnumValue<GovernmentRefinanceTypeOtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Bus Affiliate Name [AFF.X2]
    /// </summary>
    public string? HasAbusinessRelationshipWith { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details HCLTV/HTLTV [1540]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HcltvHtltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HELOC Teaser Rate [1482]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocTeaserRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Hmda
    /// </summary>
    [AllowNull]
    public Hmda Hmda { get => GetEntity<Hmda>(); set => SetEntity(value); }

    /// <summary>
    /// Loan HomeCounselingProviders
    /// </summary>
    [AllowNull]
    public IList<HomeCounselingProvider> HomeCounselingProviders { get => GetList<HomeCounselingProvider>(); set => SetList(value); }

    /// <summary>
    /// Home Counseling Provider - Settings - Distance [HCSETTING.DISTANCE]
    /// </summary>
    public string? HomeCounselingProvidersDistance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Settings - Language Names [HCSETTING.LANGUAGES]
    /// </summary>
    public string? HomeCounselingProvidersLanguageNames { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Settings - Service Names [HCSETTING.SERVICES]
    /// </summary>
    public string? HomeCounselingProvidersServiceNames { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan HouseholdSizeCount
    /// </summary>
    public int? HouseholdSizeCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Housing Counseling Agency [URLA.X156]
    /// </summary>
    public string? HousingCounselingAgency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Housing Counseling Agency FullName [URLA.X162]
    /// </summary>
    public string? HousingCounselingAgencyFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan HtmlEmailLogs
    /// </summary>
    [AllowNull]
    public IList<HtmlEmailLog> HtmlEmailLogs { get => GetList<HtmlEmailLog>(); set => SetList(value); }

    /// <summary>
    /// Loan Hud1Es
    /// </summary>
    [AllowNull]
    public Hud1Es Hud1Es { get => GetEntity<Hud1Es>(); set => SetEntity(value); }

    /// <summary>
    /// Fannie Mae Income Limit Adj Factor [MORNET.X31]
    /// </summary>
    public decimal? HudIncomeLimitAdjustmentFactor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Community Lending Inc Limit [MORNET.X32]
    /// </summary>
    public decimal? HudLendingIncomeLimitAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan HudLoanData
    /// </summary>
    [AllowNull]
    public HudLoanData HudLoanData { get => GetEntity<HudLoanData>(); set => SetEntity(value); }

    /// <summary>
    /// Fannie Mae HUD Median Income [MORNET.X30]
    /// </summary>
    public decimal? HudMedianIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Include USDA Upfront Guarantee Fee in Closing [3551]
    /// </summary>
    public bool? IncludeUSDAFeeInClosing { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Interest Rate [4113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Interest Rate - Display field with KBYO rounding rules  [KBYO.XD4113]
    /// </summary>
    public string? InitialInterestRateUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Insurance Authorization Indicator [1984]
    /// </summary>
    public string? InsuranceAuthorizationIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan InterimServicing
    /// </summary>
    [AllowNull]
    public InterimServicing InterimServicing { get => GetEntity<InterimServicing>(); set => SetEntity(value); }

    /// <summary>
    /// Fannie Mae Interview Date [MORNET.X69]
    /// </summary>
    public DateTime? InterviewerApplicationSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interviewer Email [3968]
    /// </summary>
    public string? InterviewerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Interviewer's License Number [2306]
    /// </summary>
    public string? InterviewerLicenseIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interviewer Phone [1823]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? InterviewerPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// The state license number for the interviewer's company. [3629]
    /// </summary>
    public string? InterviewersCompanyStateLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interviewer ID [3239]
    /// </summary>
    public string? InterviewersId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interviewer Name [1612]
    /// </summary>
    public string? InverviewerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan InvestorDeliveryLogs
    /// </summary>
    [AllowNull]
    public IList<InvestorDeliveryLog> InvestorDeliveryLogs { get => GetList<InvestorDeliveryLog>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Creditor Prohibits Borrower from making interest Payments [4087]
    /// </summary>
    public bool? IsCreditorProhibitsBorrower { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Is Employee Loan? [4181]
    /// </summary>
    public bool? IsEmployeeLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    ///  Loan Amount Rounding Indicator [4745]
    /// </summary>
    public bool? IsLoanAmountRounding { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Indicator for loan link sync type [4117]
    /// </summary>
    public bool? IsLSSecondaryFile { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Required Interest Reserve (Compound Interest) [4086]
    /// </summary>
    public bool? IsRequiredInterestReserveCompoundInterest { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Land [968]
    /// </summary>
    public decimal? LandIfAcquiredSeperatelyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Lead Source [2976]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeadSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Lead Source ID [4495]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeadSourceID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Lender Case # [305]
    /// </summary>
    public string? LenderCaseIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Channel [3332]
    /// </summary>
    public StringEnumValue<LenderChannel> LenderChannel { get => GetValue<StringEnumValue<LenderChannel>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Lender Credits In Funding [4083]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LenderCreditsInFunding { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Investor Code [476]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderInvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Lender In Details of Transaction [LENPCCINDOT]
    /// </summary>
    public decimal? LenderPaidClosignCostsDotAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Lender [LENPCC]
    /// </summary>
    public decimal? LenderPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lesser of Appraised Value or Original Sales Price [MORNET.X42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserAppraisedValueOrSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Mo Pymt w/ Life Ins [1560]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LifeInsuranceCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Est Mo Life Ins Pmt [1558]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LifeInsuranceEstimatedMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Life Insurance Coverage [1559]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Amt - Copied from Linked Loan [LINK_1109]
    /// </summary>
    public decimal? LinkedBorrowerRequestedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LinkId [LINKGUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LinkId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanActionLogs
    /// </summary>
    [AllowNull]
    public IList<LoanActionLog> LoanActionLogs { get => GetList<LoanActionLog>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Term (Mos) [4]
    /// </summary>
    public int? LoanAmortizationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type [608]
    /// </summary>
    public StringEnumValue<AmortizationType> LoanAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanCreatedDate
    /// </summary>
    public string? LoanCreatedDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Loan Created Date [2025]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? LoanCreatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Features Other Indicator [URLA.X242]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Other\"}")]
    public bool? LoanFeaturesOtherIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ID # [4063]
    /// </summary>
    public string? LoanIdNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Loan Import Status [3051]
    /// </summary>
    public bool? LoanImportStatusIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Link Sync Type [4185]
    /// </summary>
    public StringEnumValue<LoanLinkSyncType> LoanLinkSyncType { get => GetValue<StringEnumValue<LoanLinkSyncType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan # [364]
    /// </summary>
    public string? LoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanProductData
    /// </summary>
    [AllowNull]
    public LoanProductData LoanProductData { get => GetEntity<LoanProductData>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Loan Program [1401]
    /// </summary>
    public string? LoanProgramName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanPrograms
    /// </summary>
    [AllowNull]
    public IList<LoanProgram> LoanPrograms { get => GetList<LoanProgram>(); set => SetList(value); }

    /// <summary>
    /// Refinance Type [MORNET.X40]
    /// </summary>
    public StringEnumValue<LoanPurposeOfRefinanceType> LoanPurposeOfRefinanceType { get => GetValue<StringEnumValue<LoanPurposeOfRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Loan Source [2024]
    /// </summary>
    public string? LoanSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanSubmission
    /// </summary>
    [AllowNull]
    public LoanSubmission LoanSubmission { get => GetEntity<LoanSubmission>(); set => SetEntity(value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Maintenance [1147]
    /// </summary>
    public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Utilities [1148]
    /// </summary>
    public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanUnderwriterCHUMSIdentifier
    /// </summary>
    public string? LoanUnderwriterCHUMSIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanVALoanProcedureType
    /// </summary>
    public string? LoanVALoanProcedureType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanVARateReductionInitialComputationTotalAmount
    /// </summary>
    public decimal? LoanVARateReductionInitialComputationTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanVAResidualIncomeAmount
    /// </summary>
    public decimal? LoanVAResidualIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LoanVersionId
    /// </summary>
    public int? LoanVersionId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan LockCancellationLogs
    /// </summary>
    [AllowNull]
    public IList<LockCancellationLog> LockCancellationLogs { get => GetList<LockCancellationLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LockConfirmLogs
    /// </summary>
    [AllowNull]
    public IList<LockConfirmLog> LockConfirmLogs { get => GetList<LockConfirmLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LockDenialLogs
    /// </summary>
    [AllowNull]
    public IList<LockDenialLog> LockDenialLogs { get => GetList<LockDenialLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LockRemovedLogs
    /// </summary>
    [AllowNull]
    public IList<LockRemovedLog> LockRemovedLogs { get => GetList<LockRemovedLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LockRequestLogs
    /// </summary>
    [AllowNull]
    public IList<LockRequestLog> LockRequestLogs { get => GetList<LockRequestLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LockVoidLogs
    /// </summary>
    [AllowNull]
    public IList<LockVoidLog> LockVoidLogs { get => GetList<LockVoidLog>(); set => SetList(value); }

    /// <summary>
    /// Loan LOCompensation
    /// </summary>
    [AllowNull]
    public ElliLOCompensation LOCompensation { get => GetEntity<ElliLOCompensation>(); set => SetEntity(value); }

    /// <summary>
    /// Loan LogEntryLogs
    /// </summary>
    [AllowNull]
    public IList<LogEntryLog> LogEntryLogs { get => GetList<LogEntryLog>(); set => SetList(value); }

    /// <summary>
    /// Constr Loan Info - Lot Acquired Date [URLA.X236]
    /// </summary>
    public DateTime? LotAcquiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Loan To Value (LTV) [353]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Value for LTV [358]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LtvPropertyValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Master Commitment Number [3908]
    /// </summary>
    public string? MasterCommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Maturity Date [78]
    /// </summary>
    public DateTime? MaturityDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Qual Ratio Bottom [1791]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxBackRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Qual Ratio Top [1790]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxFrontRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Mcaw
    /// </summary>
    [AllowNull]
    public Mcaw Mcaw { get => GetEntity<Mcaw>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details MERS MIN # [1051]
    /// </summary>
    public string? MersNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping MERS Registration Date [2023]
    /// </summary>
    public DateTime? MersNumberRegistrationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MERS Organization ID [4722]
    /// </summary>
    public string? MersOrgId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details PMI/MIP/FF Financed [1045]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MiAndFundingFeeFinancedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details PMI/MIP/FF Amt [969]
    /// </summary>
    public decimal? MiAndFundingFeeTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Approved Milestone Date [MS.APP]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneApprovedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Approved Milestone Due Date [MS.APP.DUE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneApprovedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Completed Milestone Date [MS.CLO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Completed Milestone Due Date [MS.CLO.DUE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneCompletedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Current Milestone Date [MS.STATUSDATE]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? MilestoneCurrentDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Current Milestone Name [MS.STATUS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<MilestoneCurrentName> MilestoneCurrentName { get => GetValue<StringEnumValue<MilestoneCurrentName>>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Doc Signed Milestone Date [MS.DOC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneDocSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Doc Signed Milestone Due Date [MS.DOC.DUE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneDocSignedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Loan Milestone Duration [MS.LOANDURATION]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MilestoneDuration { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - File Started Milestone Date [MS.START]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneFileStartedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan MilestoneFreeRoleLogs
    /// </summary>
    [AllowNull]
    public IList<MilestoneFreeRoleLog> MilestoneFreeRoleLogs { get => GetList<MilestoneFreeRoleLog>(); set => SetList(value); }

    /// <summary>
    /// Tracking - Funded Milestone Date [MS.FUN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneFundedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Funded Milestone Due Date [MS.FUN.DUE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneFundedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan MilestoneHistoryLogs
    /// </summary>
    [AllowNull]
    public IList<MilestoneHistoryLog> MilestoneHistoryLogs { get => GetList<MilestoneHistoryLog>(); set => SetList(value); }

    /// <summary>
    /// Loan MilestoneLogs
    /// </summary>
    [AllowNull]
    public IList<MilestoneLog> MilestoneLogs { get => GetList<MilestoneLog>(); set => SetList(value); }

    /// <summary>
    /// Tracking - Processed Milestone Date [MS.PROC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneProcessedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Milestone Stage [1601]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MilestoneStage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Submitted Milestone Date [MS.SUB]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneSubmittedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Tracking - Submitted Milestone Due Date [MS.SUB.DUE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MilestoneSubmittedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan MilestoneTaskLogs
    /// </summary>
    [AllowNull]
    public IList<MilestoneTaskLog> MilestoneTaskLogs { get => GetList<MilestoneTaskLog>(); set => SetList(value); }

    /// <summary>
    /// Loan MilestoneTemplateLogs
    /// </summary>
    [AllowNull]
    public IList<MilestoneTemplateLog> MilestoneTemplateLogs { get => GetList<MilestoneTemplateLog>(); set => SetList(value); }

    /// <summary>
    /// PMI Prepaid in Cash by Borrower [3033]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MipBorrowerPaidInCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Amt Paid In Cash [1760]
    /// </summary>
    public decimal? MipPaidInCashAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Miscellaneous
    /// </summary>
    [AllowNull]
    public Miscellaneous Miscellaneous { get => GetEntity<Miscellaneous>(); set => SetEntity(value); }

    /// <summary>
    /// Loan MIServiceArchLogs
    /// </summary>
    [AllowNull]
    public IList<MIServiceArchLog> MIServiceArchLogs { get => GetList<MIServiceArchLog>(); set => SetList(value); }

    /// <summary>
    /// Loan MIServiceMgicLogs
    /// </summary>
    [AllowNull]
    public IList<MIServiceMgicLog> MIServiceMgicLogs { get => GetList<MIServiceMgicLog>(); set => SetList(value); }

    /// <summary>
    /// Loan MIServiceRadianLogs
    /// </summary>
    [AllowNull]
    public IList<MIServiceRadianLog> MIServiceRadianLogs { get => GetList<MIServiceRadianLog>(); set => SetList(value); }

    /// <summary>
    /// MERS Original Mortgagee (MOM) [4723]
    /// </summary>
    public bool? Mom { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Monthly PI Payment Amount For LE1 and CD1 [4085]
    /// </summary>
    public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan MortgageInsurancePremiumFHARefundAmount
    /// </summary>
    public decimal? MortgageInsurancePremiumFHARefundAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Upfront Factor [1107]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type [1172]
    /// </summary>
    public StringEnumValue<LoanType> MortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Metro Stat Area/County [MORNET.X26]
    /// </summary>
    public string? MsaIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trust Classification Type [URLA.X141]
    /// </summary>
    public StringEnumValue<NativeAmericanLandsType> NativeAmericanLandsType { get => GetValue<StringEnumValue<NativeAmericanLandsType>>(); set => SetValue(value); }

    /// <summary>
    /// Native American Lands Type Other Description [URLA.X142]
    /// </summary>
    public StringEnumValue<NativeAmericanLandsTypeOtherDescription> NativeAmericanLandsTypeOtherDescription { get => GetValue<StringEnumValue<NativeAmericanLandsTypeOtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Negative Amortization Indicator [URLA.X239]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Negative Amortization\"}")]
    public bool? NegativeAmortization { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan NetTangibleBenefit
    /// </summary>
    [AllowNull]
    public NetTangibleBenefit NetTangibleBenefit { get => GetEntity<NetTangibleBenefit>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details New First Mtg [1845]
    /// </summary>
    public decimal? NewFirstMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan originator last name [URLA.X186]
    /// </summary>
    public string? NewHELOCCreditorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X187]
    /// </summary>
    public decimal? NewHELOCMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA First New Mortgage Creditor Name [URLA.X182]
    /// </summary>
    public string? NewMortgageCreditorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X183]
    /// </summary>
    public decimal? NewMortgageMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan originator last name [URLA.X184]
    /// </summary>
    public string? NewSubordinateCreditorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X185]
    /// </summary>
    public decimal? NewSubordinateMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// New Non-Borrowing Owner linked to vesting added [NewVestingNboAlert]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NewVestingNboAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Loan Originator ID [3238]
    /// </summary>
    public string? NmlsLoanOriginatorId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock No Closing Cost Option [3891]
    /// </summary>
    public bool? NoClosingCostOption { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan NonBorrowingOwners
    /// </summary>
    [AllowNull]
    public IList<NonBorrowingOwner> NonBorrowingOwners { get => GetList<NonBorrowingOwner>(); set => SetList(value); }

    /// <summary>
    /// Loan NonVols
    /// </summary>
    [AllowNull]
    public IList<NonVol> NonVols { get => GetList<NonVol>(); set => SetList(value); }

    /// <summary>
    /// Property is not located in a project Indicator [URLA.X208]
    /// </summary>
    public bool? NotInProjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Purchase Sale or Refi [AFF.X6]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"purchase, sale, or refinance of, the subject property.\"}")]
    public bool? NotRequiredForPurchaseSaleOrRefinance { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Settlement of Loan [AFF.X5]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"settlement of your loan on,\"}")]
    public bool? NotRequiredForSettlementOfYourLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Occupancy Type [3335]
    /// </summary>
    public StringEnumValue<OccupancyType> OccupancyType { get => GetValue<StringEnumValue<OccupancyType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosures - Investor Code [Opening.InvCd]
    /// </summary>
    public string? OpeningDocsInvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosures - Plan Code Type [Opening.LoanProgTyp]
    /// </summary>
    public StringEnumValue<DocsLoanProgramType> OpeningDocsLoanProgramType { get => GetValue<StringEnumValue<DocsLoanProgramType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosures - Plan Description [Opening.PlanDesc]
    /// </summary>
    public string? OpeningDocsPlanDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosures - Ellie Mae Plan ID [Opening.PlanID]
    /// </summary>
    public string? OpeningDocsPlanId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosures - Program Code [Opening.ProgCd]
    /// </summary>
    public string? OpeningDocsProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Opening Document Stacking Order [Opening.DocStkOrdr]
    /// </summary>
    public string? OpeningDocsStackingOrder { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Company - Users Organization Code [ORGID]
    /// </summary>
    public string? OrganizationCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Application Date [745]
    /// </summary>
    public DateTime? OriginationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Originator Address Line Text [URLA.X188]
    /// </summary>
    public string? OriginatorAddressLineText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Originator Unit Type Identifier [URLA.X189]
    /// </summary>
    public StringEnumValue<UnitType> OriginatorAddressUnitDesignatorType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Originator Address Unit Identifier [URLA.X190]
    /// </summary>
    public string? OriginatorAddressUnitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan Originator first name [URLA.X170]
    /// </summary>
    public string? OriginatorFirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan originator last name [URLA.X172]
    /// </summary>
    public string? OriginatorLastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan originator middle name [URLA.X171]
    /// </summary>
    public string? OriginatorMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan originator suffix name [URLA.X173]
    /// </summary>
    public string? OriginatorSuffixName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type Other Descr [994]
    /// </summary>
    public string? OtherAmortizationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type Other [1063]
    /// </summary>
    public string? OtherMortgageTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Other [OTHPCC]
    /// </summary>
    public decimal? OtherPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Overwire Amount [2005]
    /// </summary>
    public decimal? OverwireAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Ownership Completed Date [URLA.X157]
    /// </summary>
    public DateTime? OwnershipCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PACE Loan Payoff Amount [4786]
    /// </summary>
    public decimal? PaceLoanPayoffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  Payment Deferred for First Five Years Indicator [URLA.X209]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment Deferred for First Five Years\"}")]
    public bool? PaymentDeferredFirstFiveYears { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Payment Schedule Calculation is Required [CALCREQUIRED]
    /// </summary>
    public bool? PaymentScheduleCalcRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Bus Affiliate Relationship/% [AFF.X3]
    /// </summary>
    public string? PercentageOfOwnership { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// The Percentage of Ownership Interest is [AFF.X32]
    /// </summary>
    public decimal? PercentageOwnershipInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Private Mortgage Insurance Indicator [3336]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"PMI Included\",\"N\":\"PMI Not Included\"}")]
    public bool? PmiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan PostClosingConditionLogs
    /// </summary>
    [AllowNull]
    public IList<PostClosingConditionLog> PostClosingConditionLogs { get => GetList<PostClosingConditionLog>(); set => SetList(value); }

    /// <summary>
    /// Loan PreliminaryConditionLogs
    /// </summary>
    [AllowNull]
    public IList<PreliminaryConditionLog> PreliminaryConditionLogs { get => GetList<PreliminaryConditionLog>(); set => SetList(value); }

    /// <summary>
    /// Undefined [URLA.X240]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prepayment Penalty / Prepayment Penalty Term\"}")]
    public bool? PrepaymentPenaltyTerm { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Prequalification
    /// </summary>
    [AllowNull]
    public Prequalification Prequalification { get => GetEntity<Prequalification>(); set => SetEntity(value); }

    /// <summary>
    /// Trans Details Mo Pymt (P&amp;I) [5]
    /// </summary>
    public decimal? PrincipalAndInterestMonthlyPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Print 2003 Appl [1825]
    /// </summary>
    public StringEnumValue<Print2003Application> Print2003Application { get => GetValue<StringEnumValue<Print2003Application>>(); set => SetValue(value); }

    /// <summary>
    /// PrintLenderPages [URLA.X231]
    /// </summary>
    public bool? PrintLenderPages { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan PrintLogs
    /// </summary>
    [AllowNull]
    public IList<PrintLog> PrintLogs { get => GetList<PrintLog>(); set => SetList(value); }

    /// <summary>
    /// Print both ULI / NULI and Loan Number [URLA.X238]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print both ULI / NULI and Loan Number\"}")]
    public bool? PrintULIAndLoanNoURLA { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Print ULI on URLA [URLA.X119]
    /// </summary>
    public bool? PrintULIonURLA { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan PrivacyPolicy
    /// </summary>
    [AllowNull]
    public PrivacyPolicy PrivacyPolicy { get => GetEntity<PrivacyPolicy>(); set => SetEntity(value); }

    /// <summary>
    /// Product Description [URLA.X143]
    /// </summary>
    public string? ProductDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ProfitManagement
    /// </summary>
    [AllowNull]
    public ProfitManagement ProfitManagement { get => GetEntity<ProfitManagement>(); set => SetEntity(value); }

    /// <summary>
    /// Government Refinance Type [URLA.X168]
    /// </summary>
    public StringEnumValue<ProjectLegalStructureType> ProjectLegalStructureType { get => GetValue<StringEnumValue<ProjectLegalStructureType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Property
    /// </summary>
    [AllowNull]
    public Property Property { get => GetEntity<Property>(); set => SetEntity(value); }

    /// <summary>
    /// Subject Property Appraised Value [356]
    /// </summary>
    public int? PropertyAppraisedValueAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Energy Effic Mtg Indicator [157]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Energy Efficient Mortgage\"}")]
    public bool? PropertyEnergyEfficientHomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Est Value [1821]
    /// </summary>
    public int? PropertyEstimatedValueAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Property Existing Clean Energy Lien Indicator [URLA.X135]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Property is currently subject to a lien that could take priority over the first mortgage lien, such as a clean energy lien paid through property taxes (e.g., the Property Assessed  Clean Energy program).\"}")]
    public bool? PropertyExistingCleanEnergyLienIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan PropertyValuations
    /// </summary>
    [AllowNull]
    public IList<PropertyValuation> PropertyValuations { get => GetList<PropertyValuation>(); set => SetList(value); }

    /// <summary>
    /// Expenses Proposed HOA [233]
    /// </summary>
    public string? ProposedDuesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Mtg Pymt [228]
    /// </summary>
    public decimal? ProposedFirstMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ProposedGroundRentAmount
    /// </summary>
    public decimal? ProposedGroundRentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Haz Ins [230]
    /// </summary>
    public string? ProposedHazardInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Total Housing [912]
    /// </summary>
    public decimal? ProposedHousingExpenseTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Mtg Ins [232]
    /// </summary>
    public string? ProposedMortgageInsuranceAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Other Housing [234]
    /// </summary>
    public decimal? ProposedOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Other Pymt [229]
    /// </summary>
    public decimal? ProposedOtherMortgagesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Taxes [1405]
    /// </summary>
    public string? ProposedRealEstateTaxesAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Planned Unit Development Project Type Indicator [URLA.X207]
    /// </summary>
    public bool? PUDIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan PurchaseConditionLogs
    /// </summary>
    [AllowNull]
    public IList<PurchaseConditionLog> PurchaseConditionLogs { get => GetList<PurchaseConditionLog>(); set => SetList(value); }

    /// <summary>
    /// Loan PurchaseCredits
    /// </summary>
    [AllowNull]
    public IList<PurchaseCredit> PurchaseCredits { get => GetList<PurchaseCredit>(); set => SetList(value); }

    /// <summary>
    /// Trans Details Purchase Price [136]
    /// </summary>
    public decimal? PurchasePriceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan RateLock
    /// </summary>
    [AllowNull]
    public RateLock RateLock { get => GetEntity<RateLock>(); set => SetEntity(value); }

    /// <summary>
    /// File Contacts Referral Addr [1830]
    /// </summary>
    public string? ReferralAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Referral City [1831]
    /// </summary>
    public string? ReferralCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Referral Fee [1834]
    /// </summary>
    public decimal? ReferralFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Referral Zip [1833]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ReferralPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Referral Name [1822]
    /// </summary>
    public string? ReferralSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ReferralSourceContact
    /// </summary>
    public EntityReference? ReferralSourceContact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Referral State [1832]
    /// </summary>
    public StringEnumValue<State> ReferralState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Refinance Cash Out Determination Type [URLA.X165]
    /// </summary>
    public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => GetValue<StringEnumValue<RefinanceCashOutDeterminationType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Refinance [1092]
    /// </summary>
    public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan RegistrationLogs
    /// </summary>
    [AllowNull]
    public IList<RegistrationLog> RegistrationLogs { get => GetList<RegistrationLog>(); set => SetList(value); }

    /// <summary>
    /// Loan RegulationZ
    /// </summary>
    [AllowNull]
    public RegulationZ RegulationZ { get => GetEntity<RegulationZ>(); set => SetEntity(value); }

    /// <summary>
    /// Relationship Vesting Type [URLA.X138]
    /// </summary>
    public StringEnumValue<RelationshipVestingType> RelationshipVestingType { get => GetValue<StringEnumValue<RelationshipVestingType>>(); set => SetValue(value); }

    /// <summary>
    /// Relationship Vesting Type Other Description [URLA.X139]
    /// </summary>
    public string? RelationshipVestingTypeOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan RemovedLogRecords
    /// </summary>
    [AllowNull]
    public IList<RemovedLogRecord> RemovedLogRecords { get => GetList<RemovedLogRecord>(); set => SetList(value); }

    /// <summary>
    /// Renovation Loan Indicator [URLA.X132]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Renovation\"}")]
    public bool? RenovationLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expected Net Monthly Rental Income For LENDER to Calculate [URLA.X81]
    /// </summary>
    public decimal? RentalEstimatedNetMonthlyRentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// 4c. Rental Income onthe Property You want to Purchase - For Purchase Only Does not Apply [URLA.X80]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
    public bool? RentalIncomeSectionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Repurchase Cost [3313]
    /// </summary>
    public decimal? RepurchaseCostAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Repurchase Date [3312]
    /// </summary>
    public DateTime? RepurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Rate [3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestedInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Rate - Display field with KBYO rounding rules [KBYO.XD3]
    /// </summary>
    public string? RequestedInterestRatePercentUI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Mae Seller Concessions [MORNET.X71]
    /// </summary>
    public decimal? SalesConcessionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Sub Fin Second Mtg Loan Amt [428]
    /// </summary>
    public decimal? SecondSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Section32
    /// </summary>
    [AllowNull]
    public Section32 Section32 { get => GetEntity<Section32>(); set => SetEntity(value); }

    /// <summary>
    /// Loan Info Section of Housing Act [1039]
    /// </summary>
    public StringEnumValue<SectionOfActType> SectionOfActType { get => GetValue<StringEnumValue<SectionOfActType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan SelectedHomeCounselingProvider
    /// </summary>
    [AllowNull]
    public SelectedHomeCounselingProvider SelectedHomeCounselingProvider { get => GetEntity<SelectedHomeCounselingProvider>(); set => SetEntity(value); }

    /// <summary>
    /// Loan SellConditionLogs
    /// </summary>
    [AllowNull]
    public IList<SellConditionLog> SellConditionLogs { get => GetList<SellConditionLog>(); set => SetList(value); }

    /// <summary>
    /// Fees Total Closing Costs Seller [143]
    /// </summary>
    public decimal? SellerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Server Date Time DDM Applied [DMDDM.X1]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? ServerDateTimeDDMApplied { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provided - Additional Information [SP.ADDITIONALINFO]
    /// </summary>
    public string? ServiceProviderAdditionalInfo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ServiceProviderContacts
    /// </summary>
    [AllowNull]
    public IList<ServiceProviderContact> ServiceProviderContacts { get => GetList<ServiceProviderContact>(); set => SetList(value); }

    /// <summary>
    /// Settlement Service Provided - Date Issued [SP.DATEISSUED]
    /// </summary>
    public DateTime? ServiceProviderDateIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan ServicingDisclosure
    /// </summary>
    [AllowNull]
    public ServicingDisclosure ServicingDisclosure { get => GetEntity<ServicingDisclosure>(); set => SetEntity(value); }

    /// <summary>
    /// Loan ServicingPrintLogs
    /// </summary>
    [AllowNull]
    public IList<ServicingPrintLog> ServicingPrintLogs { get => GetList<ServicingPrintLog>(); set => SetList(value); }

    /// <summary>
    /// Disclosure Required to Use Listed Provider [AFF.X31]
    /// </summary>
    public bool? SetForSettlementServicesOfAnAttorney { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Not required to Use Listed Provider [AFF.X4]
    /// </summary>
    public bool? SetForTheSettlementServicesListed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Agent Disbursed Funds Date [4724]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? SettlementAgentDisbursedFundsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan SettlementServiceCharges
    /// </summary>
    [AllowNull]
    public IList<SettlementServiceCharge> SettlementServiceCharges { get => GetList<SettlementServiceCharge>(); set => SetList(value); }

    /// <summary>
    /// Loan Shipping
    /// </summary>
    [AllowNull]
    public Shipping Shipping { get => GetEntity<Shipping>(); set => SetEntity(value); }

    /// <summary>
    /// Simple Refinance (FHA to FHA) [MORNET.X41]
    /// </summary>
    public bool? SimpleRefinanceType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan SourceEntityUrn
    /// </summary>
    public string? SourceEntityUrn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan SpecialFeatureCodes
    /// </summary>
    [AllowNull]
    public IList<SpecialFeatureCode> SpecialFeatureCodes { get => GetList<SpecialFeatureCode>(); set => SetList(value); }

    /// <summary>
    /// Loan StartingAdjPrice
    /// </summary>
    public decimal? StartingAdjPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan StartingAdjRate
    /// </summary>
    public decimal? StartingAdjRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan StateDisclosure
    /// </summary>
    [AllowNull]
    public StateDisclosure StateDisclosure { get => GetEntity<StateDisclosure>(); set => SetEntity(value); }

    /// <summary>
    /// Loan StatementCreditDenial
    /// </summary>
    [AllowNull]
    public StatementCreditDenial StatementCreditDenial { get => GetEntity<StatementCreditDenial>(); set => SetEntity(value); }

    /// <summary>
    /// Loan StatusOnlineLogs
    /// </summary>
    [AllowNull]
    public IList<StatusOnlineLog> StatusOnlineLogs { get => GetList<StatusOnlineLog>(); set => SetList(value); }

    /// <summary>
    /// Subject Property Gross Rent [1005]
    /// </summary>
    public decimal? SubjectPropertyGrossRentalIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Occupancy Rate [1487]
    /// </summary>
    public decimal? SubjectPropertyOccupancyPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Subordinate Financing [140]
    /// </summary>
    public decimal? SubordinateLienAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Proposed Supplemental Property Insurance Amount [URLA.X144]
    /// </summary>
    public decimal? SupplementalPropertyInsuranceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Latest Guid [SYS.X610]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SystemIdGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Target CLTV [4523]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? TargetCLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Target HCLTV [4524]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? TargetHCLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan TargetTradeLogs
    /// </summary>
    [AllowNull]
    public IList<TargetTradeLog> TargetTradeLogs { get => GetList<TargetTradeLog>(); set => SetList(value); }

    /// <summary>
    /// Temporary Buydown [4645]
    /// </summary>
    public string? TemporaryBuydown { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Temporary Interest Rate Buydown/Initial Buydown Rate [URLA.X241]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Temporary Interest Rate Buydown/Initial Buydown Rate\"}")]
    public bool? TemporaryOrInitialInterestRateBuydown { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Application Date [3292]
    /// </summary>
    public DateTime? TilApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Full Name [URLA.X137]
    /// </summary>
    public string? TitleHolderFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Title Name 1 [31]
    /// </summary>
    public string? TitleHolderName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Title Name 2 [1602]
    /// </summary>
    public string? TitleHolderName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Title Will Be Full Name [URLA.X136]
    /// </summary>
    public string? TitleWillBeFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Total Loan to Value (TLTV) [975]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Tltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Additional Mortgages [URLA.X211]
    /// </summary>
    public decimal? TotalAdditionalMortgages { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs [TOTPCC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Deductions [1989]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDeductionsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Costs [1073]
    /// </summary>
    public decimal? TotalFeesCostAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Credits [1844]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalFeesCreditAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Non-Borr [TNBPCC]
    /// </summary>
    public decimal? TotalNonborrowerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Non Subject Property Debts ToBe Paid Off Amount [URLA.X145]
    /// </summary>
    public decimal? TotalNonSubjectPropertyDebtsToBePaidOffAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Total Total Of Gifts Grants [URLA.X150]
    /// </summary>
    public decimal? TotalOfGiftsGrants { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Total Total Other Asset To Loan [URLA.X151]
    /// </summary>
    public decimal? TotalOtherAssetToLoan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Paid Outside of Closing (Oth Summaries) [TOTPOC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaidOutsideClosingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Paid To [1988]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaidToBrokerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Subordinate Financing Amount [URLA.X147]
    /// </summary>
    public decimal? TotalSubordinateFinancingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Wire Transfer [1990]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalWireTransferAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan TPO
    /// </summary>
    [AllowNull]
    public TPO TPO { get => GetEntity<TPO>(); set => SetEntity(value); }

    /// <summary>
    /// Flag to indicate TPO Migration process is done [TPO_MIGRATION]
    /// </summary>
    public bool? TPOMigrationDone { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan TQL
    /// </summary>
    [AllowNull]
    public TQL TQL { get => GetEntity<TQL>(); set => SetEntity(value); }

    /// <summary>
    /// Loan TrustAccount
    /// </summary>
    [AllowNull]
    public TrustAccount TrustAccount { get => GetEntity<TrustAccount>(); set => SetEntity(value); }

    /// <summary>
    /// Trust Classification Type [URLA.X140]
    /// </summary>
    public StringEnumValue<TrustClassificationType> TrustClassificationType { get => GetValue<StringEnumValue<TrustClassificationType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Tsum
    /// </summary>
    [AllowNull]
    public Tsum Tsum { get => GetEntity<Tsum>(); set => SetEntity(value); }

    /// <summary>
    /// Borrower Can Demonstrate 12-Month Mortgage/Rental History [3515]
    /// </summary>
    public bool? TwelveMonthMortgageRentalHistoryIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Case File ID [4486]
    /// </summary>
    public string? UCDCaseFileID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Fannie Mae Case File Status Type [4503]
    /// </summary>
    public string? UCDFNMACasefileStatusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Fannie Mae Case File Warning Indicator [4504]
    /// </summary>
    public string? UCDFNMACasefileWarningIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Loan Closing Match Status Type [4507]
    /// </summary>
    public string? UCDLoanCLSMatchStatusType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Original Submission Date [4506]
    /// </summary>
    public DateTime? UCDOrigSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Submission Date [4505]
    /// </summary>
    public DateTime? UCDSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Uldd
    /// </summary>
    [AllowNull]
    public Uldd Uldd { get => GetEntity<Uldd>(); set => SetEntity(value); }

    /// <summary>
    /// Loan UnderwriterSummary
    /// </summary>
    [AllowNull]
    public UnderwriterSummary UnderwriterSummary { get => GetEntity<UnderwriterSummary>(); set => SetEntity(value); }

    /// <summary>
    /// Loan UnderwritingConditionLogs
    /// </summary>
    [AllowNull]
    public IList<UnderwritingConditionLog> UnderwritingConditionLogs { get => GetList<UnderwritingConditionLog>(); set => SetList(value); }

    /// <summary>
    /// Underwriting Escrow [1550]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow (T&I)\"}")]
    public bool? UnderwritingEscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnDiscounted Rate [3293]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? UndiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management - Basic Info - Unimproved Appraised Value [4090]
    /// </summary>
    public int? UnimprovedAppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Management - Basic Info - Unimproved Estimated Value [4089]
    /// </summary>
    public int? UnimprovedEstimatedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Loan Identifier [URLA.X120]
    /// </summary>
    public string? URLALoanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Total Credits Amount [URLA.X152]
    /// </summary>
    public decimal? URLATotalCreditsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Total Mortgage Loans Amount [URLA.X148]
    /// </summary>
    public decimal? URLATotalMortgageLoansAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// URLA Total Other Credits Amount [URLA.X149]
    /// </summary>
    public decimal? URLATotalOtherCreditsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// 1003 Page 4 Comments [1003p4]
    /// </summary>
    public string? UrlPage4Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Usda
    /// </summary>
    [AllowNull]
    public Usda Usda { get => GetEntity<Usda>(); set => SetEntity(value); }

    /// <summary>
    /// USDA-RHS Government Loan Type [Terms.USDAGovtType]
    /// </summary>
    public StringEnumValue<UsdaGovernmentLoanType> UsdaGovernmentLoanType { get => GetValue<StringEnumValue<UsdaGovernmentLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Use 2018 DI [4142]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Use 2018 DI\"}")]
    public bool? Use2018DiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Apply Enhanced Conditions to Loan [ENHANCEDCOND.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? UseEnhancedConditionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Use New LE, CD, GFE And HUD [3969]
    /// </summary>
    public StringEnumValue<UseNew2015FormsIndicator> UseNew2015FormsIndicator { get => GetValue<StringEnumValue<UseNew2015FormsIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Use New GFE And HUD [NEWHUD.X354]
    /// </summary>
    public bool? UseNewHudIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VA Loan Summ Entitlement Amt [VASUMM.X3]
    /// </summary>
    public decimal? VAEntitlementAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan VaLoanData
    /// </summary>
    [AllowNull]
    public VaLoanData VaLoanData { get => GetEntity<VaLoanData>(); set => SetEntity(value); }

    /// <summary>
    /// Valuation Used for LTV [4520]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ValuationUsed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan VerificationLogs
    /// </summary>
    [AllowNull]
    public IList<VerificationLog> VerificationLogs { get => GetList<VerificationLog>(); set => SetList(value); }

    /// <summary>
    /// Loan VirtualFields
    /// </summary>
    [AllowNull]
    public IDictionary<string, string?> VirtualFields { get => GetDictionary<string, string?>(); set => SetDictionary(value); }

    /// <summary>
    /// Website ID [WEBSITEID]
    /// </summary>
    public string? WebsiteId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Workflow Id [4685]
    /// </summary>
    public string? WorkFlowId { get => GetValue<string?>(); set => SetValue(value); }
}